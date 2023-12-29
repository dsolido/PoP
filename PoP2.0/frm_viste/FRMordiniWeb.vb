Public Class FRMOrdiniWeb
    Dim statoOrdine As Integer = 1
    Dim idWebOrdini As Int16
    Public Sub New(Optional ByVal idWeb As Int16 = 0)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        idWebOrdini = idWeb
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRMOrdiniWeb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaArchivi()
        SegnalanonInviati()
        If idWebOrdini > 0 Then
            PosizioneOrdine(idWebOrdini)
        End If
    End Sub
    Private Function PosizioneOrdine(ByVal idWebOrdine)
        statoOrdine = 2
        Me.TAordiniWeb.Fill(Me.DS_Ordini.DTordiniWeb)
        Me.TAordiniRigaWeb.Fill(Me.DS_Ordini.DTordiniRigaWeb)
        BSordiniWeb.Filter = "id = " & idWebOrdine.ToString
        DescrizioneOrdini()

    End Function
    Private Sub CaricaArchivi()
        Me.TAordiniWeb.FillByElaborato(Me.DS_Ordini.DTordiniWeb, statoOrdine)
        Me.TAordiniRigaWeb.FillNonElaborato(Me.DS_Ordini.DTordiniRigaWeb, If(statoOrdine = 1, 0, statoOrdine))
        DescrizioneOrdini()
    End Sub
    Private Sub SegnalanonInviati()
        Dim tmpDGW As DataGridView
        tmpDGW = DGWordiniWeb
        For Each rg As DataGridViewRow In tmpDGW.Rows
            If rg.Cells(2).Value = 0 Then
                rg.DefaultCellStyle.BackColor = Color.Red
            End If
        Next
    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()
    End Sub

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim rgOrdiniWeb As DS_Ordini.DTordiniWebRow
        rgOrdiniWeb = DirectCast(BSordiniWeb.Current, DataRowView).Row
        If MsgBox("Confermi l'eliminazione dell'Ordine WEB n° " & rgOrdiniWeb.id & " effettuato da " & rgOrdiniWeb.anagrafica, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim tmpRGrighe As DS_Ordini.DTordiniRigaWebRow
            For Each tmpRGordiniRigheWeb As DataRowView In RordiniWebordiniRigaWeb
                tmpRGrighe = DirectCast(tmpRGordiniRigheWeb, DataRowView).Row
                TAordiniRigaWeb.elimina(tmpRGrighe.id)
            Next
            TAordiniWeb.elimina(rgOrdiniWeb.id)
            CaricaArchivi()
            RicaricaconPosizione()
        End If
    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        Dim RGoW As DS_Ordini.DTordiniWebRow
        Dim RGorW As DS_Ordini.DTordiniRigaWebRow
        Dim OldPos As Integer = BSordiniWeb.Position
        Dim righe(DGWordiniWeb.SelectedRows.Count - 1) As Integer
        For i = 0 To DGWordiniWeb.SelectedRows.Count - 1
            righe(i) = DGWordiniWeb.SelectedRows.Item(i).Cells(0).Value
        Next
        Array.Reverse(righe)
        For i = 0 To righe.Length - 1
            Dim UltimoID As Integer
            Dim id As Integer = righe(i)
            BSordiniWeb.Filter = "id=" & id
            '
            ' Se ci sono righe allora procede
            '
            If BSordiniWeb.Count > 0 Then
                '
                'Individua se cisono diversi fornitori e diversi tipi di ordine in modo da splittarlo in diversi ordini
                '
                RGoW = DirectCast(BSordiniWeb.Current, DataRowView).Row
                Dim tmpFornitore As Integer()
                Dim tmpFatturabile As Integer()

                Using DT As New DS_Ordini.DTordiniRigaWebDataTable
                    'Carica le righe per l'ordine specifico
                    Using TA As New DS_OrdiniTableAdapters.TAordiniRigaWeb
                        TA.FillByOrdineGroup(DT, id)
                    End Using
                    'scorre le righe per analizzare i fornitori
                    For Each tmpRG As DataRow In DT.Rows
                        If IsNothing(tmpFornitore) Then
                            ReDim tmpFornitore(0)
                        Else
                            Dim newarrsize = CInt(UBound(tmpFornitore) + 1)
                            ReDim Preserve tmpFornitore(newarrsize)
                        End If
                        tmpFornitore(UBound(tmpFornitore)) = tmpRG.Field(Of Integer)("id_fornitore")

                        'Suddivide l'ordine in diversi ordini in base al materiale se è fatturabile o no

                        If IsNothing(tmpFatturabile) Then
                            ReDim tmpFatturabile(0)

                        Else
                            Dim newarrsize = CInt(UBound(tmpFatturabile) + 1)
                            ReDim Preserve tmpFatturabile(newarrsize)

                        End If
                        tmpFatturabile(UBound(tmpFatturabile)) = tmpRG.Field(Of Integer)("fatturabile")

                    Next
                End Using

                Using TA As New DS_OrdiniTableAdapters.TA_ordini

                    For iriga = 0 To tmpFatturabile.Length() - 1
                        'Crea gli ordini sulla base di quanti tipi di materiale trova (Fornitura o Ordinario)
                        Dim ttID As Integer = TA.SQnuovoID()
                        If tmpFatturabile(iriga) = 1 Then
                            RGoW.annotazioni = "ATTENZIONE FORNITURA " & RGoW.annotazioni
                        End If
                        TA.QR_Inserisce(ttID, RGoW.id_cliente, RGoW.id_locazione, tmpFornitore(iriga), RGoW.id_utente, RGoW.data_ordine, RGoW.annotazioni, RGoW.id_az, 0, Now, RGoW.id)
                        UltimoID = TA.SQultimoID
                        BSwebordiniriga.RemoveFilter()

                        'Filtra il dettaglio ordini sulla base del valore del fornitore e del tipo di materiale

                        BSwebordiniriga.Filter = String.Format("id_ordine = {0} AND id_fornitore = {1} AND fatturabile = {2}", id, tmpFornitore(iriga), tmpFatturabile(iriga))
                        For Each tmpRGR As DataRowView In BSwebordiniriga
                            RGorW = DirectCast(tmpRGR, DataRowView).Row
                            Using TArighe As New DS_OrdiniTableAdapters.TA_ordinirighe
                                'Imposta come elaborato la riga
                                TAordiniRigaWeb.aggiornaElaborazione(2, RGorW.id)
                                TArighe.QR_Inserisce(UltimoID, RGorW.id_prodotto, RGorW.posizione, RGorW.quantita, RGorW.prezzounitario, RGorW.sconto, RGorW.tax, RGorW.fatturabile, RGorW.dataordine, RGoW.data_ordine, RGoW.id_az)
                            End Using
                        Next
                    Next
                End Using
            End If
            TAordiniWeb.AggiornaElaborazione(2, RGoW.id)
            BSordiniWeb.RemoveFilter()
        Next
        BSordiniWeb.Position = OldPos
        RicaricaconPosizione()
    End Sub
    Private Sub RicaricaconPosizione()
        Dim oldID As Integer
        Dim rgOrdiniWeb As DS_Ordini.DTordiniWebRow
        If BSordiniWeb.Count > 0 Then
            rgOrdiniWeb = DirectCast(BSordiniWeb.Current, DataRowView).Row
        oldID = rgOrdiniWeb.id
        CaricaArchivi()
        SegnalanonInviati()
        BSordiniWeb.Position = BSordiniWeb.Find("id", oldID)
        End If
    End Sub
    Private Sub TTSB_ricarica_Click(sender As Object, e As EventArgs) Handles TTSB_ricarica.Click
        RicaricaconPosizione()
    End Sub

    Private Sub DGWordinirigheWeb_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGWordinirigheWeb.CellContentClick
        Select Case e.ColumnIndex
            Case DGWRCid.Index
                Dim f As New FRMmodificarigaordineweb(RordiniWebordiniRigaWeb, DirectCast(BSordiniWeb.Current, DataRowView).Row)
                f.ShowDialog()
                RicaricaconPosizione()
            Case DGWRCprodotto.Index
        End Select
    End Sub

    Private Sub DGWordiniWeb_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGWordiniWeb.CellContentClick
        Dim colonna As DataGridViewColumn = DGWordiniWeb.Columns(e.ColumnIndex)
        If e.RowIndex > 0 Or e.ColumnIndex > 0 Then
            Select Case colonna.Name
                Case DGWCconvalidato.Name
                    Dim tmpID As Integer = DirectCast(BSordiniWeb.Current, DataRowView).Row.Item("id")
                    Dim tmpVal As Integer
                    tmpVal = DGWordiniWeb(colonna.Index, e.RowIndex).Value
                    DGWordiniWeb(colonna.Index, e.RowIndex).Value = If(tmpVal >= 2, 0, tmpVal + 1)
                    tmpVal = DGWordiniWeb(colonna.Index, e.RowIndex).Value
                    Dim TA As New DS_OrdiniTableAdapters.TAordiniWeb
                    TA.QRaggiornainvio(tmpVal, tmpID)
                    BSordiniWeb.EndEdit()
            End Select
        End If

    End Sub
    Private Sub DGWordiniRigheWeb_ConvalidaRiga(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGWordinirigheWeb.CellValidating
        Dim colonna As DataGridViewColumn = DGWordinirigheWeb.Columns(e.ColumnIndex)

        If e.RowIndex > 0 Or e.ColumnIndex > 0 Then
            Select Case colonna.Name
                Case DGWRCquantita.Name
                    Dim tmpID As Integer = DGWordinirigheWeb(0, e.RowIndex).Value
                    If e.FormattedValue >= 0 Then
                        Dim quantita As Decimal
                        quantita = e.FormattedValue
                        Using TA As New DS_OrdiniTableAdapters.TAordiniRigaWeb
                            TA.modificaquantita(quantita, tmpID)
                        End Using
                    End If
            End Select
        End If
    End Sub
    Private Sub TSBevasi_Click(sender As Object, e As EventArgs) Handles TSBevasi.Click
        TSLdescrizione.Text = ""
        statoOrdine = statoOrdine + 1
        If statoOrdine > 2 Then
            statoOrdine = 0
        End If
        Me.TAordiniWeb.FillByElaborato(Me.DS_Ordini.DTordiniWeb, statoOrdine)
        Me.TAordiniRigaWeb.FillNonElaborato(Me.DS_Ordini.DTordiniRigaWeb, If(statoOrdine = 1, 0, statoOrdine))
        DescrizioneOrdini()
    End Sub
    Private Sub DescrizioneOrdini()
        Dim letterafinale As String = "e "
        Dim letterafinale1 As String = "o "
        If BSordiniWeb.Count < 1 Then
            TSLdescrizione.Text = "Nessun "
        ElseIf BSordiniWeb.Count = 1 Then
            TSLdescrizione.Text = " C'è " & BSordiniWeb.Count().ToString & " "
        Else
            TSLdescrizione.Text = " Ci sono " & BSordiniWeb.Count().ToString & " "
            letterafinale = "i "
            letterafinale1 = "i "
        End If

        Select Case statoOrdine
            Case 0
                TSLdescrizione.Text = TSLdescrizione.Text & "ordin" & letterafinale & "in Sospeso"
            Case 1
                TSLdescrizione.Text = TSLdescrizione.Text & "ordin" & letterafinale & "da Evadere"
            Case 2
                TSLdescrizione.Text = TSLdescrizione.Text & "ordin" & letterafinale & "già Evas" & letterafinale1
        End Select

    End Sub
    Private Sub TTTestoRicerca_Change(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        Dim tmpText As String
        tmpText = TTTestoRicerca.Text
        'Dim tmpRG As DS_Ordini.DTordiniWebRow
        Dim Filtro As String
        If tmpText.Length > 0 Then
            Filtro = String.Format("locazione Like '%{0}%'", tmpText.Trim)
                BSordiniWeb.Filter = Filtro
        Else
            BSordiniWeb.RemoveFilter()
        End If

    End Sub
End Class