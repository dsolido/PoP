Imports System.IO
Public Class FRM_gestioneDocumentale
    Dim G_idAZ As Integer = GlobalVarPOP.G_idAZ
    Dim G_Directorypartenza As String = "V:\joomla\jdownload\"
    Dim G_IDutente As String = GlobalVarPOP.G_idUtente
    'Dim G_idRemotoUtente As Integer = GlobalVarPOP.G_id_remotoUtente
    'Dim G_idLocaleUtente As Integer = GlobalVarPOP.G_id_localeUtente
    Dim G_nomeUtente As String = GlobalVarPOP.G_nomeutente
    Dim G_livello As Integer = GlobalVarPOP.gradoaccesso
    Dim G_filtro As String = "attivo = '1'"
    'Dim DTrr As New DS_j.DT_joomutentiDataTable
    Private Sub FRM_gestioneDocumentale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_file.Fill(Me.DS_gestione_documenti.DT_file)
        Me.TA_categorie.Fill(Me.DS_gestione_documenti.DT_categorie)
        Me.TA_file.Fill(Me.DS_gestione_documenti.DT_file)
        Me.TA_cantieri.FillByAZ(Me.DS_gestione_documenti.DT_cantieri, G_idAZ)
        BS_cantieri.Filter = G_filtro
    End Sub
    Protected Sub DG_documenti(ByVal sender As Object, ByVal e As DataGridViewCellCancelEventArgs) Handles DG_file.RowValidating
        RELcantierefile.EndEdit()

        Dim o = Me.DS_gestione_documenti.DT_file.DataSet.HasChanges
        If o = True Then
            Dim RR As DS_gestione_documenti.DT_fileRow
            For Each _R In RELcantierefile
                RR = DirectCast(_R, DataRowView).Row
                If RR.RowState = DataRowState.Modified Then
                    TA_file.ModificaDescrizione(RR.descrizione, RR.file_id)
                End If
            Next
        End If

    End Sub
    Private Sub TX_ricercajutenti_TextChanged(sender As Object, e As EventArgs) Handles TX_ricerca.TextChanged, TZ_ricercafile.TextChanged
        Dim tmpTX As TextBox
        Dim tmpBS As BindingSource = Nothing
        tmpTX = DirectCast(sender, TextBox)
        Dim Chiave As String
        Dim FiltriAttivi As Boolean = False
        Select Case tmpTX.Name
            Case "TX_ricerca"
                tmpBS = BS_cantieri
                Chiave = "societa Like '%{0}%'"
                FiltriAttivi = True
            Case "TZ_ricercafile"
                tmpBS = RELcantierefile
                Chiave = "ricerca Like '%{0}%'"
                FiltriAttivi = False
        End Select
        Dim TMP_ricerca As String = tmpTX.Text
        Dim OldFil As String = tmpBS.Filter
        Dim f As Integer = tmpBS.Count
        tmpBS.RemoveFilter()
        If FiltriAttivi Then
            tmpBS.Filter = If(OldFil.Length > 0, G_filtro & " AND ", "") & String.Format(Chiave, tmpTX.Text)
        Else
            tmpBS.Filter = String.Format(Chiave, tmpTX.Text)
        End If

        Dim NN As Integer = 0
        Do While tmpBS.Count < 1
            NN += 1
            If tmpTX.Text.Length() > 0 Then
                tmpTX.Text = tmpTX.Text.Substring(0, If(tmpTX.Text.Length() - NN <= 0, 0, tmpTX.Text.Length() - NN))
                tmpBS.RemoveFilter()
                If FiltriAttivi Then
                    tmpBS.Filter = If(OldFil.Length > 0, G_filtro & " AND ", "") & String.Format(Chiave, tmpTX.Text)
                Else
                    tmpBS.Filter = String.Format(Chiave, tmpTX.Text)
                End If

                tmpTX.SelectionStart = tmpTX.Text.Length
                CambiaColore(LB_ricerca, tmpTX)
            Else
                Exit Do
            End If
        Loop
    End Sub
    Private Function ControllaDirectory(ByVal DirectoridaControllare As String)
        Dim outFile As String = DirectoridaControllare
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

    Private Sub BT_cerca_Click(sender As Object, e As EventArgs) Handles BT_cercaCartella.Click
        CercaCartella.SelectedPath = If(TX_deposito.Text.Length > 0, TX_deposito.Text, G_Directorypartenza)
        CercaCartella.ShowDialog()
        If Not ControllaDirectory(CercaCartella.SelectedPath) Then
            Return
        End If
        TX_deposito.Text = CercaCartella.SelectedPath
        G_Directorypartenza = CercaCartella.SelectedPath
    End Sub
    Private Sub TTBTDocumento(sender As Object, e As EventArgs) Handles BT_caricadocumento.Click
        If RELCantieriCategorie.Count = 0 Then
            CreaCategoria()
        End If
        Dim RGrem As DS_gestione_documenti.DT_cantieriRow
        Dim RGcat As DS_gestione_documenti.DT_categorieRow

        'assegna la riga Cantiere
        RGrem = DirectCast(BS_cantieri.Current, DataRowView).Row
        RGcat = DirectCast(RELcantieriCategorie.Current, DataRowView).Row

        Dim idCat As Integer = RGcat.id 'codice Categoria
        Dim idRem As Integer = RGrem.id 'codice Cantiere

        If Not ApreDocumento.ShowDialog() > 0 Then
            MsgBox("Nessun Documento selezionato")
            Return
        End If
        Dim TestoPath As String = ApreDocumento.FileName
        Dim folderPath As String = G_Directorypartenza & "\" & RGcat.dir_categoria_parent & "\" & RGcat.dir_categoria
        Dim TestoDestinazione As String = folderPath & "\" & ApreDocumento.SafeFileName
        Dim Info As FileInfo = New FileInfo(TestoPath)
        If Not Info.Exists Then
            Return
        End If

        Try
            My.Computer.FileSystem.CopyFile(TestoPath, TestoDestinazione, True)
            impostaPermessiFile(TestoDestinazione, "http")
        Catch ex As Exception
            MsgBox("Problemi a registrare il documento " & TestoDestinazione)
        End Try
        Dim Testonome As String = ApreDocumento.SafeFileName
        Dim TestoAlias As String = ApreDocumento.SafeFileName.Replace(" ", "_")
        Dim TestoDesc As String = "Documento"
        Dim TestoEstensione As String = Info.Extension
        Dim TestoSize As String = ControllaeFormattaNumeri(Info.Length / 1000) & " KB"
        Dim TestoData As DateTime = Info.CreationTime
        Dim TestoSha1 As String = CriptoSHA(ApreDocumento.FileName)
        Dim TestoMD5 As String = GenerateFileMD5(ApreDocumento.FileName)
        'Dim newOrd As Integer = TA_file.SQ_asset_id()
        Dim R As DS_gestione_documenti.DT_fileRow
        RELcantierefile.AddNew()
        R = DirectCast(RELcantierefile.Current, DataRowView).Row
        R.file_titolo = Testonome
        R.file_alias = TestoAlias
        R.file_icona = TestoEstensione.Substring(1, TestoEstensione.Length - 1) & ".png"
        R.descrizione = TestoDesc
        R.data_file = TestoData
        R.data_aggiunta = Now()
        R.autore = G_nomeUtente
        R.url_download = Testonome
        R.downloads = 0
        R.md5_valore = TestoMD5
        R.sha1_valore = TestoSha1
        R.creato_id = G_IDutente
        R.creato_da = Now()
        Dim Asset As Object
        Try
            Asset = TA_file.SQ_asset_id()
        Catch ex As Exception
            Asset = 1
        End Try



        R.asset_id = Asset + 1
        R.cantiere_id = idRem
        R.cantiere_nome = RGrem.societa
        R.cantiere_data = Now
        R.id_categoria = idCat 'identificativo Cartella corretta
        R.pubblicato = 1       '
        R.prezzo = 0
        R.rilascio = ""
        R.visto = 0
        'R.asset_id = newOrd  'Numero progressivo
        R.note = ""
        Dim Order As Object
        Try
            Order = TA_file.SQ_ordine(R.cantiere_id) + 1
        Catch ex As Exception
            Order = 1
        End Try
        R.ordinato = Order ' ordina numero di carico

        TA_file.Inserisce(R.file_titolo, R.file_alias, R.descrizione, R.file_icona, R.prezzo, R.rilascio,
                          R.data_aggiunta, R.data_file, R.url_download, R.md5_valore, R.sha1_valore, R.autore,
                          R.creato_da, R.creato_id, R.cantiere_nome, R.cantiere_id, R.cantiere_data, R.downloads,
                          R.id_categoria, R.note, R.visto, R.ordinato, R.pubblicato, R.asset_id)

        TA_file.Fill(DS_gestione_documenti.DT_file)
    End Sub

    Private Sub CreaCategoria()
        Dim RG_can As DS_gestione_documenti.DT_cantieriRow
        RG_can = DirectCast(BS_cantieri.Current, DataRowView).Row
        Dim esistegia As Integer = TA_categorie.SQ_esistegia(RG_can.id)
        If esistegia > 0 Then
            If MsgBox("Elimino la vecchia documentazione e riscrivo la nuova ? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim RG_cat As DS_gestione_documenti.DT_categorieRow
                RG_cat = DirectCast(RELCantieriCategorie.Current, DataRowView).Row
                Dim CartellaDestinazione As String = G_Directorypartenza & RG_cat.dir_categoria_parent
                EliminaCartellaCliente(CartellaDestinazione)
                TA_categorie.EliminaBycreatore(RG_can.id)
                TA_categorie.Fill(DS_gestione_documenti.DT_categorie)
            End If
        End If
        If RELCantieriCategorie.Count = 0 Then
            Dim RG_cat As DS_gestione_documenti.DT_categorieRow
            RELCantieriCategorie.AddNew()
            RG_cat = DirectCast(RELCantieriCategorie.Current, DataRowView).Row
            RG_cat.accesso = G_livello              'livello di accesso per lettura
            RG_cat.asset_id = G_IDutente
            RG_cat.creatore_id = RG_can.id          'id del cantiere
            Dim tmpDir As String = EliminaCaratteriSpeciali(RG_can.societa & RG_can.id.ToString.PadLeft(6, "0"))
            RG_cat.dir_categoria = tmpDir               'Cartella dove verranno memorizzati i documenti
            RG_cat.dir_categoria_parent = "preventivi"  'Cartella radice
            RG_cat.id_parent = 1
            RG_cat.editore_id = G_IDutente
            RG_cat.icona = "cartella.pic"
            RG_cat.livello = 2
            RG_cat.note = "Documenti di " & EliminaCaratteriSpeciali(RG_can.societa, False)
            RG_cat.pubblicato = 1
            RG_cat.titolo = "cartella"
            RG_cat.viste = 0
            RG_cat._alias = RG_can.societa
            RG_cat.creatore_data = Now()
            RG_cat.editore_data = Now()
            RG_cat.lft = 0
            RG_cat.rgt = 0
            RG_cat.descrizione = RG_can.societa & " " & RG_can.city
            RG_cat.ordine = 0

            TA_categorie.Inserisce(RG_cat.dir_categoria, RG_cat.dir_categoria_parent, RG_cat.id_parent, RG_cat.lft, RG_cat.rgt, RG_cat.livello, RG_cat.titolo,
                               RG_cat._alias, RG_cat.descrizione, RG_cat.icona, RG_cat.accesso, RG_cat.creatore_id, RG_cat.creatore_data, RG_cat.editore_id,
                               RG_cat.editore_data, RG_cat.note, RG_cat.viste, RG_cat.ordine, RG_cat.pubblicato, RG_cat.asset_id)
            Dim CartellaDestinazione As String
            CartellaDestinazione = G_Directorypartenza & RG_cat.dir_categoria_parent & "\" & tmpDir
            Try
                My.Computer.FileSystem.CreateDirectory(CartellaDestinazione)
                impostaPermessiFile(CartellaDestinazione, "http")
            Catch ex As Exception
                MsgBox("Problemi a Creare la cartella " & CartellaDestinazione)
                TA_categorie.EliminaBycreatore(RG_cat.creatore_id)
            End Try
            TA_categorie.Fill(DS_gestione_documenti.DT_categorie)
        End If

    End Sub
    Private Sub EliminaCartellaCliente(ByVal Cartella As String)
        Try
            My.Computer.FileSystem.DeleteDirectory(Cartella, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception
            MsgBox("Problemi a Creare la cartella " & Cartella)
        End Try
    End Sub
    Private Sub Apreildocumento(sender As Object, e As DataGridViewCellEventArgs) Handles DG_file.CellContentClick
        Dim senderGrid As DataGridView
        senderGrid = DirectCast(sender, DataGridView)
        Dim Colonna As Object = Nothing
        Try
            Colonna = DirectCast(senderGrid(e.ColumnIndex, e.RowIndex), DataGridViewLinkCell)
        Catch ex As Exception

        End Try

        If Not IsNothing(Colonna) Then
            Dim RGff As DS_gestione_documenti.DT_fileRow
            Dim RGcat As DS_gestione_documenti.DT_categorieRow
            RGff = DirectCast(RELcantierefile.Current, DataRowView).Row
            RGcat = DirectCast(RELCantieriCategorie.Current, DataRowView).Row
            Dim Documento As String
            Documento = G_Directorypartenza & "\" & RGcat.dir_categoria_parent & "\" & RGcat.dir_categoria & "\" & RGff.file_titolo
            If File.Exists(Documento) = True Then
                Process.Start(Documento)
            Else
                MsgBox("non trovo il documento")
            End If
        End If
    End Sub

    Private Sub BT_elimina_Click(sender As Object, e As EventArgs) Handles BT_elimina.Click
        Dim RGff As DS_gestione_documenti.DT_fileRow
        Dim RGcat As DS_gestione_documenti.DT_categorieRow
        RGff = DirectCast(RELcantierefile.Current, DataRowView).Row
        RGcat = DirectCast(RELCantieriCategorie.Current, DataRowView).Row
        Dim Documento As String
        Documento = G_Directorypartenza & "\" & RGcat.dir_categoria_parent & "\" & RGcat.dir_categoria & "\" & RGff.file_titolo
        If File.Exists(Documento) = True Then
            File.Delete(Documento)

            TA_file.Elimina(RGff.file_id)
            RGff.Delete()
        Else
            MsgBox("non trovo il documento")
        End If
    End Sub
End Class