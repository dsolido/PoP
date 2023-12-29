Imports System.IO

Public Class FRMpubblicaFatturePDF
    Dim G_periodo As String

    Dim G_tipologia As Integer = 2 'Assegna 2 per i clienti

    Dim _mese As String() = New String() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"}
    Private Sub FRMpubblicaFatturePDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        G_DirectoryAvvio.Text = "V:\ns\documenti\Clienti\"
        Dim DT_memo As DS_servizio.DT_info_pop2Row
        DT_memo = dsolidofunc.legge_informazioni(Me.Name, GlobalVarPOP.G_nomeutente)
        G_periodo = LoadPeriodo(DT_memo)
        If TT_CB_mese.SelectedIndex < Now.Month - 1 Then
            If MsgBox("Stai lavorando col mese di " & TT_CB_mese.SelectedItem & ", imposto il mese Corretto ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TT_CB_mese.SelectedIndex = Now.Month - 1
            End If
        End If
        If TT_CB_anno.SelectedItem < Now.Year Then
            If MsgBox("Stai lavorando nell'anno " & TT_CB_anno.SelectedItem & ", imposto l'anno Corretto ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TT_CB_anno.SelectedItem = Now.Year
            End If
        End If
        CaricaDB(Nothing, Nothing)
        CaricaViewList()
    End Sub
    Private Sub CaricaDB(sender As Object, e As EventArgs) Handles TTBTAggiorna.Click
        Me.TA_cantieri_new.Fill(Me.DS_clienti.DT_cantieri_new, New System.Nullable(Of Integer)(CType(GlobalVarPOP.G_idAZ, Integer)))
        CaricaViewList()
    End Sub
    Private Sub CaricaViewList()
        SuspendLayout()
        Dim lv As ListView = ListView1
        lv.Items.Clear()

        If lv.Columns.Count = 0 Then
            With lv
                .View = View.Details
                .FullRowSelect = True
                .Columns.Add("id")
                .Columns.Add("Cliente")
            End With
        End If
        lv.Columns(0).TextAlign = HorizontalAlignment.Right
        lv.Columns(1).Width = 200
        For Each rgCantieri As DS_clienti.DT_cantieri_newRow In Me.DS_clienti.DT_cantieri_new
            If rgCantieri.attivo = 1 Then
                lv.Items.Add(New ListViewItem({rgCantieri.id.ToString, rgCantieri.societa}))
            End If
        Next
        ResumeLayout()
    End Sub


    Private Function LoadPeriodo(oldNum As DataRow) As String
        Dim x As Integer = 0
        For l = -20 To 1
            TT_CB_anno.Items.Add(Now.Year + l)
            x = x + 1
        Next

        For t = 0 To 11
            TT_CB_mese.Items.Add(_mese(t))
        Next
        Try
            Dim ValAnno As Integer = If(oldNum.Item("anno") > 10, oldNum.Item("anno"), Now.Year)
            Dim nAnn As Integer = TT_CB_anno.FindString(ValAnno)        'cerca il valore salvato all'interno del combo Anno
            Dim ValMese As Integer = If(oldNum.Item("mese") - 1 >= 0, oldNum.Item("mese") - 1, Now.Month - 1)
            TT_CB_mese.SelectedIndex = ValMese   'idem per il mese
            TT_CB_anno.SelectedIndex = nAnn      'seleziona l'index corretto
        Catch ex As Exception
        End Try
        Return (TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")) 'aggiunge uno per'problemi suoi.... hahahah
    End Function
    Private Sub TT_CB_anno_Click(sender As Object, e As EventArgs) Handles TT_CB_anno.SelectedIndexChanged, TT_CB_mese.SelectedIndexChanged ' se cambi la data 
        G_periodo = (TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")) 'aggiunge uno per'problemi suoi.... hahahah
    End Sub

    Private Sub CaricaViewFatture(ByRef DT As DataTable, ByVal idClienti As ListView.SelectedListViewItemCollection)
        SuspendLayout()
        Dim lv As ListView = ListView2
        lv.Items.Clear()
        If lv.Columns.Count = 0 Then
            With lv
                .View = View.Details
                .FullRowSelect = True
                .Columns.Add("ord")
                .Columns.Add("n° Fattura")
                .Columns.Add("Data")
                .Columns.Add("idCli")
            End With
        End If
        lv.Columns(0).Width = 30
        lv.Columns(0).TextAlign = HorizontalAlignment.Right
        lv.Columns(1).Width = 80
        lv.Columns(1).TextAlign = HorizontalAlignment.Right
        lv.Columns(2).Width = 200
        lv.Columns(2).TextAlign = HorizontalAlignment.Left
        lv.Columns(3).Width = 0
        lv.Columns(3).TextAlign = HorizontalAlignment.Right

        Dim x As Integer = 0

        For Each rgFattura As DS_generatore_fatture.DT_fattureRow In DT.Rows
            For Each idcli As ListViewItem In idClienti
                Dim id As Integer
                id = Integer.Parse(idcli.Text.ToString)
                If rgFattura.fat_cli_id = CInt(id) Then
                    x += 1
                    lv.Items.Add(New ListViewItem({x, rgFattura.fat_num_da.ToString, rgFattura.fat_data, rgFattura.fat_cli_id}))
                End If
            Next


        Next
        ResumeLayout()
    End Sub


    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Dim nome_ri As Array = {"", "id", 0, TT_CB_mese.SelectedIndex + 1, TT_CB_anno.SelectedItem, ""}
        dsolidofunc.memorizza_informazioni(Me.Name, 0, GlobalVarPOP.G_nomeutente, nome_ri)
        Me.Close()
    End Sub

    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        CreailPDF()


    End Sub


    Private Sub ListView1_SelectedChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        Dim lv As ListView = DirectCast(sender, ListView)
        'Dim f = e.Item
        Using DTft As New DS_generatore_fatture.DT_fattureDataTable
            Using TA As New DS_generatore_fattureTableAdapters.TA_fatture
                TA.FillByPeriodo(DTft, G_periodo)
                If DTft.Rows.Count > 0 Then
                    Dim listViewSubItem As ListView.SelectedListViewItemCollection = lv.SelectedItems
                    CaricaViewFatture(DTft, listViewSubItem)
                End If
            End Using
        End Using


    End Sub

    Private Function CreailPDF()

        Dim lv As ListView = DirectCast(ListView2, ListView)
        Me.FolderBrowserDialog1.ShowDialog()
        Dim posizione As String = FolderBrowserDialog1.SelectedPath

        Dim x As Int16 = 0
        Dim listViewSubItem As ListView.SelectedListViewItemCollection = lv.SelectedItems

        Dim matrice As String(,) = New String(listViewSubItem.Count, 2) {}
        If listViewSubItem.Count = 0 Then
            Return True
        End If
        'aFat_num_da.CopyTo(listViewSubItem.Item(0), 0)
        For Each tmpID As ListViewItem In listViewSubItem

            matrice(x, 0) = tmpID.SubItems(1).Text
            matrice(x, 1) = Integer.Parse(tmpID.SubItems(3).Text)
            matrice(x, 2) = ""
            x += 1
        Next


        PBelaborazione.Maximum = matrice.GetUpperBound(0) - 1
        PBelaborazione.Value = 0
        PBelaborazione.ToolTipText = "Creo i PDF"

        EsitoOperazione.Items.Clear()
        EsitoOperazione.Items.Add("Inizio Elaborazione dei Dati")
        For x = 0 To matrice.GetUpperBound(0) - 1

            Using DTFattura As New DS_fattura.DT_fatturaDataTable
                Using TaFattura As New DS_fatturaTableAdapters.TA_fattura
                    TaFattura.FillByFattura(DTFattura, matrice(x, 0))                                              'carica la fattura specifica
                End Using
                Dim DTtotale As New DS_fattura.DT_fattura_totDataTable
                Dim DTrighe As New DS_fattura.DT_fattura_righeDataTable
                Using TaTotale As New DS_fatturaTableAdapters.TA_fattura_tot
                    TaTotale.FillByFattura(DTtotale, matrice(x, 0))                                                'carica la riga totali specifica
                End Using
                Using TArighe As New DS_fatturaTableAdapters.TA_fattura_righe
                    TArighe.FillByFattura(DTrighe, matrice(x, 0))                                                  'carica le righe della fattura specifiche
                End Using
                Dim BSfattura As New BindingSource
                Dim BSrighe As New BindingSource
                Dim BStotale As New BindingSource

                'Assegna un binding ad ogni Datatableview per la stampa

                BSfattura.DataMember = DTFattura.TableName
                BSfattura.DataSource = DTFattura
                BStotale.DataMember = DTtotale.TableName
                BStotale.DataSource = DTtotale
                BSrighe.DataMember = DTrighe.TableName
                BSrighe.DataSource = DTrighe

                Dim stampa As New FRM_stp_fattura(matrice(x, 0), "fattura", G_periodo, posizione)              'avvia la procedura di stampa PDF della fattura specifica
                stampa.ShowDialog()
                Dim nomeFile As String = stampa.nomefileFatturaGenerata                             'Memorizza il nome della fattura generata
                Dim testo As String
                Using DT As New DS_clienti.DT_cantieri_newDataTable
                    Using TA As New DS_clientiTableAdapters.TA_cantieri_new
                        TA.FillByID(DT, GlobalVarPOP.G_idAZ, matrice(x, 1))
                        testo = String.Format("Creata la fattura n° {0} del Cliente {1}", matrice(x, 0), DT(0).societa)
                    End Using
                End Using
                Dim numeroElementi As Integer = EsitoOperazione.Items.Count
                EsitoOperazione.Items.Insert(numeroElementi, testo)
                'nomeFile = EliminaCaratteriSpeciali(nomeFile)
                matrice(x, 2) = posizione & "\" & nomeFile & ".pdf"
                'Process.Start(posizione & "\" & nomeFile & ".pdf")
            End Using
            PBelaborazione.Value = x
        Next
        AggiungeDocumentialcliente(matrice, True)
        Return True
    End Function

    Private Function AggiungeDocumentialcliente(Optional ByVal matrice As String(,) = Nothing, Optional ByVal EliminaDoc As Boolean = False)
        'Assegna la riga Utente Remoto
        EsitoOperazione.Items.Clear()
        PBelaborazione.Maximum = matrice.GetUpperBound(0) - 1
        PBelaborazione.Value = 0
        PBelaborazione.ToolTipText = "Pubblico i documenti"
        Dim maxElementi As Integer
        maxElementi = matrice.GetUpperBound(0) - 1
        For x = 0 To maxElementi
            Dim idCliente As Integer = matrice(x, 1)    ' Memorizza l'ID del cliente a cui appartiene la Fattura
            Dim CartellaDestinazione As String
            Dim Societa As String
            Using DT As New DS_clienti.DT_cantieri_newDataTable
                Using TA As New DS_clientiTableAdapters.TA_cantieri_new
                    TA.FillByID(DT, GlobalVarPOP.G_idAZ, idCliente)
                    Societa = DT(0).societa

                End Using
            End Using
            CartellaDestinazione = Societa.Replace(" ", "_").Replace(".", "_").Replace("#", "_").Replace("pdf", "_").Replace("-", "_").Replace(Chr(34), "")
            Dim Testonome As String
            Dim TestoAlias As String
            Dim TestoDesc As String
            Dim TestoEstensione As String
            Dim TestoSize As String
            Dim TestoData As DateTime


            Dim folderPath As String
            Dim TestoDestinazione As String
            Dim Info As FileInfo
            Dim numeroElementi As Integer
            Dim Testo As String
            Dim TestoPath As String = matrice(x, 2)
            folderPath = G_DirectoryAvvio.Text & CartellaDestinazione
            If Not My.Computer.FileSystem.DirectoryExists(folderPath) Then
                If CKcontrolloAggiuntaDirectory.Checked Then
                    My.Computer.FileSystem.CreateDirectory(folderPath)
                    numeroElementi = EsitoOperazione.Items.Count
                    Testo = "Aggiunta Directory " & CartellaDestinazione & " per la società " & Societa
                    EsitoOperazione.Items.Insert(numeroElementi, Testo)
                Else
                    If MsgBox("Attenzione per proseguire devo creare la Directory " & CartellaDestinazione & " Confermi", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        Return True
                    End If
                    My.Computer.FileSystem.CreateDirectory(folderPath.Replace(Chr(34), ""))
                End If
            End If

            If IsDBNull(TestoPath) Then
                Continue For
            End If
            If TestoPath = Nothing Then
                Continue For
            End If
            If TestoPath.Length < 1 Then
                Continue For
            End If
            Info = New FileInfo(TestoPath)
            If Not Info.Exists Then
                Continue For
            End If
            Testonome = TestoPath.Split("\").Last
            'Scrive come deve rappresentare il documento nella linea di descrizione
            TestoAlias = Testonome.Replace("#", "").Replace("pdf", "")
            TestoDesc = Testonome.Replace("#", "|").Replace(".", "").Replace("pdf", "")

            'Elimina tutti i caratteri compromettenti
            Testonome = Testonome.Replace(" ", "_").Replace(".", "_").Replace("#", "_").Replace("pdf", "_").Replace("-", "_") & Info.Extension
            TestoDestinazione = folderPath & "\" & Testonome


            TestoEstensione = Info.Extension
            TestoSize = ControllaeFormattaNumeri(Info.Length / 1000) & " KB"
            TestoData = Info.CreationTime
            Dim InfoDestinazione = New FileInfo(TestoDestinazione)
            If InfoDestinazione.Exists Then
                If CKcontrolloAggiuntaDirectory.Checked Then
                Else
                    If MsgBox("Sostituisco il file ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                        numeroElementi = EsitoOperazione.Items.Count
                        Testo = String.Format("Saltata operazione {0} di {1} non Sostituita la Fattura {2} già presente del Cliente {3}", x + 1, maxElementi + 1, matrice(x, 0), Societa)
                        EsitoOperazione.Items.Insert(numeroElementi, Testo)
                        Continue For
                    End If
                End If
                numeroElementi = EsitoOperazione.Items.Count
                Testo = String.Format("Operazione {0} di {1} Sostituisco la Fattura {2} già presente del Cliente {3}", x + 1, maxElementi + 1, matrice(x, 0), Societa)
                EsitoOperazione.Items.Insert(numeroElementi, Testo)
            Else
                numeroElementi = EsitoOperazione.Items.Count
                Testo = String.Format("Elaborazione n° {0} di {1} Aggiunta la fattura {2} del Cliente {3}", x + 1, maxElementi + 1, matrice(x, 0), Societa)
                EsitoOperazione.Items.Insert(numeroElementi, Testo)
            End If
            'Sposta o copia il documento
            'Se il parametro l'ha passato la generazione delle Fatture, sposta direttamente il documento, altrimenti lavora in base alla CK_spostacopia
            If EliminaDoc Then
                My.Computer.FileSystem.MoveFile(TestoPath, TestoDestinazione, True)
                impostaPermessiFile(TestoDestinazione, "http")
            Else
                Try
                    My.Computer.FileSystem.CopyFile(TestoPath, TestoDestinazione, True)
                    impostaPermessiFile(TestoDestinazione, "http")
                Catch ex As Exception
                    MsgBox("Problemi a registrare il documento " & TestoDestinazione)
                    Return True
                End Try

            End If

            Dim newOrd As Integer = -1
            'Crea la Variabile DataRow per la tabella Documenti
            Dim R As DSwebcondiviso.DTfileRow

            Using TF As New DSwebcondivisoTableAdapters.TAfile

                'R.title = TestoAlias

                Using DF As New DSwebcondiviso.DTfileDataTable
                    TF.FillByUtente(DF, idCliente, G_tipologia)
                    R = DF.Rows.Add
                End Using
                R.title = TestoAlias


                R.size = TestoSize
                R.data_creazione = Now()
                R.url_download = Testonome
                R.data_modifica = Now
                R.user_id = idCliente
                R.user_access = idCliente
                R.downloads = 0
                R.access = 7
                R.views = 0
                R.published = 1
                R.notes = ""
                R.id_tipo = G_tipologia

                R.ordering = TF.SQultimoordine(idCliente, G_tipologia) + 1 ' ordina numero di carico

                Dim MeseTrovato As String = CercaMeseNelFILE(TestoPath)
                Dim Periodo As Integer
                Periodo = TestoData.Month - 1
                Dim Anno As Integer
                Anno = TT_CB_anno.SelectedItem
                Select Case Periodo
                    Case 0
                        Periodo = 12
                        Anno -= 1
                End Select
                R.cartella = CartellaDestinazione
                R.description = IIf(TestoPath.Contains("#"), "Fattura " & TestoPath.Split("\").Last.Substring(0, 9) & " relativa a ", "Documento relativo a ") & IIf(MeseTrovato <> Nothing, MeseTrovato, _mese(Periodo - 1)) & " Anno " & Anno

                TF.inserisce(R.user_id, R.title, R.description, R.size, R.url_download, R.downloads, R.notes, R.views,
                         R.access, R.user_access, R.ordering, R.published, R.data_creazione, R.data_modifica, R.cartella, R.id_tipo, 0)
            End Using
            PBelaborazione.Value = x
        Next
        Return True
    End Function

    Private Function CercaMeseNelFILE(ByVal file As String)
        Dim Mese As String = Nothing
        For Each mm In _mese
            If file.Contains(mm.ToLower) Then
                Mese = mm
                Exit For
            End If
        Next
        Return Mese
    End Function

End Class