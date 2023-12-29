Imports System.IO
Imports iTextSharp.text.pdf
Imports System.Text
Imports System.Security.Permissions
Imports System.Security

Public Class FRM_separatorePDF
    Dim G_DirectoriDipendenti As String = "V:\joomla\jdownload\dipendenti\"
    Dim G_DirectoriDeposito As String = "C:\users\Public"
    Dim G_idAZ As Integer = GlobalVarPOP.G_idAZ
    Dim G_FileCaricato As String
    Dim G_Prosegue As Boolean = True

    Private Sub FRM_separatorePDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaDati()
        AggiornaComboPeriodo(cmbMese, cmbAnno)
        PNLConfermato.BackColor = Color.Red
        PNLsalvataggio.BackColor = Color.Red
    End Sub
    Private Function ControllaDirectory(ByVal DirectoridaControllare As String)
        Dim outFile As String = DirectoridaControllare & "\prova.txt"
        Try
            If Not File.Exists(outFile) Then
                ' Create a file to write to. 
                Using sw As StreamWriter = File.CreateText(outFile)
                    sw.WriteLine("Verifica")
                    sw.WriteLine("di")
                    sw.WriteLine("Trasferimento")
                End Using
            End If

            ' Open the file to read from. 
            Using sr As StreamReader = File.OpenText(outFile)
                Do While sr.Peek() >= 0
                    Console.WriteLine(sr.ReadLine())
                Loop
            End Using
        Catch ex As Exception
            MsgBox("Non puoi proseguire perché non hai accesso alla cartella " & DirectoridaControllare)
            Return (False)
        End Try

        Return (True)
    End Function
    Private Function CercaTesto(ByVal Doc As String, Optional ByVal PrimoTestoCercato As String = Nothing,
                           Optional ByVal SecondoTestoCercato As String = Nothing, Optional ByRef PagineElaborate As Integer = 0)
        Dim NumeroPagina As Integer = 0
        Dim TotalePagine As Integer
        Dim Chiave As String
        Dim SecondaChiave As String
        Dim listaEsito As String(,) = New String(0, 1) {}

        If PrimoTestoCercato <> Nothing Then
            If PrimoTestoCercato.Length > 0 Then
                Chiave = EliminaCaratteriSpeciali(PrimoTestoCercato, True).Trim.ToUpper
                SecondaChiave = EliminaCaratteriSpeciali(SecondoTestoCercato, True).Trim.ToUpper
            Else
                Chiave = "xxx"
                SecondaChiave = EliminaCaratteriSpeciali(SecondoTestoCercato, True).ToUpper
                'MsgBox("Seleziona qualcosa di più idoneo")
                'Return
            End If
        Else
            Chiave = "xxx"
            SecondaChiave = EliminaCaratteriSpeciali(SecondoTestoCercato, True).ToUpper
        End If
        Using readerPdf As New iText.Kernel.Pdf.PdfReader(Doc)
            Using document As New iText.Kernel.Pdf.PdfDocument(readerPdf)
                ' Ottieni il numero di pagine nel documento
                TotalePagine = document.GetNumberOfPages()
                For contaPagine As Integer = 1 To TotalePagine
                    Dim pdfPage = document.GetPage(contaPagine)
                    Dim strategy As New iText.Kernel.Pdf.Canvas.Parser.Listener.LocationTextExtractionStrategy()
                    Dim processor As New iText.Kernel.Pdf.Canvas.Parser.PdfCanvasProcessor(strategy)
                    processor.ProcessPageContent(pdfPage)
                    Dim testo As String = strategy.GetResultantText()
                    If testo.Contains(SecondaChiave) Then
                        PagineElaborate += 1
                        NumeroPagina = contaPagine
                        Exit For
                    End If
                Next

                If NumeroPagina = 0 Then
                    TotalePagine = document.GetNumberOfPages()
                    For contaPagine As Integer = 1 To TotalePagine
                        Dim pdfPage = document.GetPage(contaPagine)
                        Dim strategy As New iText.Kernel.Pdf.Canvas.Parser.Listener.LocationTextExtractionStrategy()
                        Dim processor As New iText.Kernel.Pdf.Canvas.Parser.PdfCanvasProcessor(strategy)
                        processor.ProcessPageContent(pdfPage)
                        Dim testo As String = strategy.GetResultantText()
                        If testo.Contains(Chiave) Then
                            PagineElaborate += 1
                            NumeroPagina = contaPagine
                            Exit For
                        End If
                    Next


                End If
                If NumeroPagina = 0 Then
                    listaEsito(0, 0) = "NO " & Chiave
                Else
                    listaEsito(0, 0) = "SI " & Chiave
                End If
                readerPdf.Close()
            End Using

        End Using

        Dim TestoData As String
        Dim Mese As String = (cmbMese.SelectedIndex + 1).ToString().PadLeft(2, "0")
        Dim Anno As String = cmbAnno.SelectedItem
        Try
            Dim nomeuscita As String
            nomeuscita = Doc.Split("\").Last.Trim.Split(".").First
            nomeuscita = Strings.Right(nomeuscita, 4)
            TestoData = nomeuscita.Substring(0, If(nomeuscita.Length > 4, 4, nomeuscita.Length))
            TestoData = Mese & "-" & Anno
        Catch ex As Exception
            TestoData = "Stampato " & Mese & "-" & Anno
        End Try
        Dim NomeFile As String  'Memorizza il file con il Cognome e poi il CF
        NomeFile = "_" & PrimoTestoCercato & "_" & SecondoTestoCercato

        If listaEsito(0, 0).Substring(0, 2) = "SI" Then
            listaEsito(0, 1) = G_DirectoriDeposito & "\BP_" & TestoData & NomeFile
            SplitPdfByParts(Doc, listaEsito(0, 1) & ".pdf", NumeroPagina)
        Else
            listaEsito(0, 1) = ""
        End If

        Return listaEsito
    End Function
    Private Sub CaricaDati()
        Using dtUtenti As New DS_utenti.DT_utentiDataTable
            Using taUtenti As New DS_utentiTableAdapters.TA_utenti
                taUtenti.FillByAttivi(dtUtenti, 1, G_idAZ)                 'DTll  Tabella Utenti Locali
                BS_utenti.DataSource = dtUtenti
            End Using
        End Using
    End Sub

    Private Sub SplitPdfByParts(ByVal sourcePdf As String, ByVal baseNameOutPdf As String,
                                      Optional ByVal Paginaesatta As Integer = 0)
        ' Copia la pagina nel nuovo documento PDF di output
        If Paginaesatta = 0 Then
            Return
        End If
        Using pdfuscita As New iText.Kernel.Pdf.PdfDocument(New iText.Kernel.Pdf.PdfWriter(baseNameOutPdf))
            Using pdfingresso As New iText.Kernel.Pdf.PdfDocument(New iText.Kernel.Pdf.PdfReader(sourcePdf))
                Dim PaginadaCopiare As iText.Kernel.Pdf.PdfPage = pdfingresso.GetPage(Paginaesatta)
                Dim PageSize As iText.Kernel.Geom.Rectangle = PaginadaCopiare.GetPageSize
                Dim NuovaPagina As iText.Kernel.Pdf.PdfPage = pdfuscita.AddNewPage(New iText.Kernel.Geom.PageSize(PageSize))
                ' Usa CopyTo invece di CopyAsFormXObject
                Dim canvas As New iText.Kernel.Pdf.Canvas.PdfCanvas(NuovaPagina)
                Dim pdfFormXObject As iText.Kernel.Pdf.Xobject.PdfFormXObject = PaginadaCopiare.CopyAsFormXObject(pdfuscita)
                canvas.AddXObject(pdfFormXObject)
            End Using
        End Using
        PNLConfermato.BackColor = Color.Red
        PNLsalvataggio.BackColor = Color.Red
    End Sub
    'Class listaValori
    '    Public Property Valori As String(,)

    '    ' Costruttore della classe
    '    Public Sub New(valoriArray As String(,))
    '        Valori = valoriArray
    '    End Sub
    'End Class
    Public Class ListaValori
        Private resultArray(,) As String

        ' Costruttore della classe
        Public Sub New(rows As Integer)
            ' Inizializza l'array con le dimensioni specificate
            ReDim resultArray(rows - 1, 1)
        End Sub

        ' Metodo per aggiungere le due stringhe all'array
        Public Sub AggiungiStringhe(row As Integer, stringa1 As String, stringa2 As String)
            ' Verifica che gli indici siano all'interno dei limiti dell'array
            If row >= 0 AndAlso row < resultArray.GetLength(0) Then
                resultArray(row, 0) = IIf(IsNothing(stringa1), "", stringa1)
                resultArray(row, 1) = IIf(IsNothing(stringa2), "", stringa2)

            End If
        End Sub

        ' Metodo per ottenere il valore risultante in una specifica posizione dell'array
        Public Function OttenereRisultato(row As Integer, col As Integer) As String
            ' Verifica che gli indici siano all'interno dei limiti dell'array
            If row >= 0 AndAlso row < resultArray.GetLength(0) AndAlso col >= 0 AndAlso col < resultArray.GetLength(1) Then
                Return resultArray(row, col)
            End If
        End Function
        Public Function Ottienilarray() As String(,)
            Return resultArray
        End Function
    End Class

    Private Sub BT_ricerca_Click(sender As Object, e As EventArgs) Handles BT_ricerca.Click
        If TX_analizzato.Text.Length < 6 And TX_deposito.Text.Length < 6 Then
            MsgBox("Segui tutta la procedura")
            Return
        End If

        G_Prosegue = True
        Dim DGsel As DataGridViewSelectedRowCollection
        DGsel = DG_utenti.SelectedRows
        Dim F As Integer
        F = DG_utenti.GetCellCount(DataGridViewElementStates.Selected)
        PB_avanzamento.Maximum = Int(F / 2)
        Dim ContaRighe As Integer = 0
        Dim PagineElaborate As Integer = 0
        Dim listaEsito As ListaValori = New ListaValori(DGsel.Count - 1)

        If tx_testoricerca.Text.Length > 0 Then
            PB_avanzamento.Maximum = 1
            Dim PrimaCol As String = tx_testoricerca.Text
            Dim SecondaCol As String = tx_testoricerca.Text
            CercaTesto(G_FileCaricato, PrimaCol, SecondaCol)
            PB_avanzamento.Value = 1
        Else
            For Each RR In DGsel.OfType(Of DataGridViewRow)().Cast(Of DataGridViewRow)().Reverse()
                Dim PrimaCol As String = RR.Cells.Item(0).Value.ToString.Trim
                Dim SecondaCol As String = RR.Cells.Item(1).Value.ToString.Trim
                Dim ritorna(0, 1) As String

                ritorna = (CercaTesto(G_FileCaricato, PrimaCol, SecondaCol, PagineElaborate))
                listaEsito.AggiungiStringhe(ContaRighe, ritorna(0, 0), ritorna(0, 1))
                PB_avanzamento.Value = ContaRighe
                If Not G_Prosegue Then
                    DG_utenti.ClearSelection()
                    Exit For
                End If
                ContaRighe += 1
            Next
            PB_avanzamento.Value = Int(F / 2)
        End If
        Dim hh As New Form
        hh.Text = "Elementi non elaborati"
        hh.StartPosition = FormStartPosition.CenterParent
        hh.Size = New Size(400, 400)
        Dim list As New ListBox
        list.Dock = DockStyle.Fill

        'ListaEsitoNegativo.Add("Elaborate " & PagineElaborate & " pagine su " & ContaRighe - 1 & " ")
        Dim elencoEsito As String()
        For k = 0 To listaEsito.Ottienilarray.GetLongLength(0) - 1
            elencoEsito.Add(listaEsito.OttenereRisultato(k, 0))
        Next
        list.DataSource = elencoEsito.Where(Function(s) Not String.IsNullOrEmpty(s)).ToArray()
        hh.Controls.Add(list)
        hh.ShowDialog()
        list.Dispose()
        hh.Dispose()

        If MsgBox("Publico direttamente le buste Paga ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            elencoEsito = Nothing
            For k = 0 To listaEsito.Ottienilarray.GetLongLength(0) - 1
                elencoEsito.Add(listaEsito.OttenereRisultato(k, 1))
            Next
            elencoEsito = elencoEsito.Where(Function(s) Not String.IsNullOrEmpty(s)).ToArray()
        End If
    End Sub

    Private Sub BT_cerca_Click(sender As Object, e As EventArgs) Handles BT_cercaCartella.Click
        CercaCartella.SelectedPath = If(TX_deposito.Text.Length > 0, TX_deposito.Text, G_DirectoriDeposito)
        CercaCartella.ShowDialog()
        If Not ControllaDirectory(CercaCartella.SelectedPath) Then
            Return
        End If
        TX_deposito.Text = CercaCartella.SelectedPath
        G_DirectoriDeposito = CercaCartella.SelectedPath
        PNLsalvataggio.BackColor = Color.LightGreen
    End Sub

    Private Sub BT_cercadocumento_Click(sender As Object, e As EventArgs) Handles BT_cercadocumento.Click
        If Not ApreDocumento.ShowDialog() > 0 Then
            MsgBox("Nessun Documento selezionato")
            Return
        End If
        Dim PathdaControllare As String = ApreDocumento.FileName.Replace(ApreDocumento.SafeFileName, "")
        Do While Not ControllaDirectory(PathdaControllare)
            If MsgBox("Proseguo o termino?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Else
                Return
            End If
        Loop
        G_FileCaricato = ApreDocumento.FileName
        TX_analizzato.Text = ApreDocumento.SafeFileName
        PNLConfermato.BackColor = Color.LightGreen
    End Sub

    Private Sub BT_termina_Click(sender As Object, e As EventArgs) Handles BT_termina.Click
        Me.Close()
    End Sub
End Class