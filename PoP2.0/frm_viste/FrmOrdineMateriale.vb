Imports System.Text



Public Class FrmOrdineMateriale
    Dim G_AZ As Integer = GlobalVarPOP.G_idAZ
    Dim G_periodo As String = ""
    Dim G_nome As String = GlobalVarPOP.G_nomeutente
    Dim G_IVA As Decimal = GlobalVarPOP.G_iva
    Dim ridimensionamento As Boolean
    Dim id As Int16 'Se viene passato un ID
    Friend dtWebOrdini As New DS_Ordini.DTordiniWebDataTable
    Friend bsWebOrdini As New BindingSource
    Friend aStato() As String = {"RICEVUTO", "TRANSITO", "CONSEGNATO", ""}
    Public Sub New(Optional _id As Int16 = -1)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        id = _id
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRM_OrdineMateriale_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbOrdineRighe.Text = "Dettaglio Ordine"
        Dim oldNum As DS_servizio.DT_info_pop2Row = Nothing
        Try
            'recupera le infomrazioni dell'utente 
            Dim nome As String = GlobalVarPOP.G_nomeutente
            oldNum = dsolidofunc.legge_informazioni(Me.Name, nome)    'ricarica i valori salvati
        Catch
        End Try
        AggiornaComboPeriodo(TT_CB_mese, TT_CB_anno)

        If id <> -1 Then
            Me.TA_ordini.FillByID(Me.DS_Ordini.DT_ordini, id)
            Me.TA_ordinirighe.FillByID_ordine(Me.DS_Ordini.DT_ordinirighe, id)
            Dim tmpAnno As Int16
            Dim tmpMese As Int16
            Dim tmprg As DS_Ordini.DT_ordiniRow
            tmprg = DirectCast(bsOrdini.Current, DataRowView).Row
            tmpAnno = tmprg.data_ordine.Year
            tmpMese = tmprg.data_ordine.Month
            TT_CB_anno.SelectedItem = tmpAnno
            TT_CB_mese.SelectedIndex = tmpMese - 1
            Dim G_periodo As String = tmpAnno.ToString & "-" & tmpMese.ToString.PadLeft(2, "00")
            bsOrdini.Position = bsOrdini.Find("id", id)
        Else
            Dim G_periodo As String = GlobalVarPOP.GPeriodo
            If tsFiltro.Checked Then
                Me.TA_ordini.FillByinviato(Me.DS_Ordini.DT_ordini, 0)
            Else
                Me.TA_ordini.FillByPeriodo(Me.DS_Ordini.DT_ordini, G_periodo, G_AZ)
            End If
        End If
        AddHandler DG_ordini.CellEnter, AddressOf F_calcolaTotaleCliente
        'Richiama la funzione per il tasto F7 quando si e sulla cella prodotti
        AddHandler DG_ordinirighe.KeyDown, AddressOf DG_controlloTasti
        AddHandler DG_ordini.KeyDown, AddressOf DG_controlloTasti
        AddHandler DG_ordinirighe.GotFocus, AddressOf AttivaSpiegazioni
        AddHandler DG_ordinirighe.LostFocus, AddressOf CancellaSpiegazioni
        AddHandler DG_ordini.GotFocus, AddressOf AttivaSpiegazioni
        AddHandler DG_ordini.LostFocus, AddressOf CancellaSpiegazioni
        F_calcolaTotaleCliente()
        bsWebOrdini.DataMember = "dtordiniweb"
        bsWebOrdini.DataSource = dtWebOrdini
        Using ta As New DS_OrdiniTableAdapters.TAordiniWeb
            ta.Fill(dtWebOrdini)
        End Using

    End Sub


    Private Sub AttivaSpiegazioni(sender As Object, e As EventArgs)
        'Dim KK As Object = e.GetType
        Dim KK As DataGridView
        KK = DirectCast(sender, DataGridView)
        If Not IsNothing(KK) Then

            Dim TT As String = KK.Name
            If TT = "DG_ordini" Then
                TTLB1.Text = "F5 duplica ordine "
                TTLB1.Visible = True
                TTLB2.Text = "ORDINE:   Seleziona la riga e premi CANC per eliminare "
                TTLB2.Visible = True
                DG_ordini.BackgroundColor = System.Drawing.Color.LightGreen
                DG_ordinirighe.BackgroundColor = DefaultBackColor
            ElseIf TT = "DG_ordinirighe" Then
                TTLB1.Text = "F7 cerca un prodotto "
                TTLB1.Visible = True
                TTLB2.Text = "DETTAGLIO:   Seleziona la riga e premi CANC per eliminare "
                TTLB2.Visible = True
                DG_ordini.BackgroundColor = DefaultBackColor
                DG_ordinirighe.BackgroundColor = System.Drawing.Color.LightGreen
            End If
        End If

    End Sub
    Private Sub CancellaSpiegazioni()
        TTLB1.Visible = False

        TTLB2.Visible = False
    End Sub

    Private Function F_ricaricaDT()
        G_periodo = If(G_periodo.Length = 7, G_periodo, Now().Year & "-" & Now.Month.ToString.PadRight(2, "0"))
        Try
            If tsFiltro.Checked Then
                Me.TA_ordini.FillByinviato(Me.DS_Ordini.DT_ordini, 0)
                Me.TA_ordinirighe.Fill(Me.DS_Ordini.DT_ordinirighe)
            Else
                Me.TA_ordini.FillByPeriodo(Me.DS_Ordini.DT_ordini, G_periodo, G_AZ)
                Me.TA_ordinirighe.FillByPeriodo(Me.DS_Ordini.DT_ordinirighe, G_periodo)
            End If

            F_CalcolaTotale()
        Catch ex As Exception
#If DEBUG Then
            Dim err As DataRow() = Me.DS_Ordini.DT_ordinirighe.GetErrors
            Dim msg As New StringBuilder
            For Each e In err
                MsgBox(e.RowError)
            Next
            Return (False)
#End If
        End Try
        Return (True)
    End Function
    Private Function F_CalcolaTotale()
        Using DT As New DS_OrdiniTableAdapters.TA_righeTot
            Using TA As New DS_Ordini.DT_righeTotDataTable
                DT.Fill(TA, G_AZ, G_periodo)
                Dim tot As Decimal
                For Each RG In TA
                    'Calcola il totale Ordini
                    tot = tot + RG.totNetto
                Next
                LBT.Text = tot.ToString("N2") & " €"
            End Using
        End Using
        Return (True)
    End Function
    Private Sub F_calcolaTotaleCliente()
        'If CK_storico.Checked = True Then
        '    CaricaTreeOrdini()
        'Else
        'Se Falso Calcola solo i totali
        CalcolaTotali()
        'End If
    End Sub

    Private Sub TT_CB_periodo_Click(sender As Object, e As EventArgs) Handles TT_CB_anno.SelectedIndexChanged, TT_CB_mese.SelectedIndexChanged ' se cambi la data
        If TT_CB_mese.SelectedIndex >= 0 Then
            G_periodo = TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
            F_ricaricaDT()
        End If
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        P_chiusuraApp(BN_barra.BindingSource)
        Me.Close()
    End Sub
    Private Sub P_chiusuraApp(ByVal BS_tmp As BindingSource)
        Dim posizione As String = ""
        Dim S_ultimo_ID As String

        Dim rTemp As DS_Ordini.DT_ordiniRow = Nothing

        If Not IsDBNull(BS_tmp) Or BS_tmp.Count > 0 Then
            rTemp = DirectCast(BS_tmp.Current, DataRowView).Row
            posizione = rTemp.id
        End If

        If IsNothing(rTemp) Then
            S_ultimo_ID = "0"
        Else
            S_ultimo_ID = rTemp.id
        End If
        Dim N_ultimo_ID As Integer = S_ultimo_ID.Split("/").First
        Dim nome_ri As Array = {BS_tmp.DataMember, "id", N_ultimo_ID.ToString, "", "", posizione}
        If Not memorizza_informazioni(Me.Name, BS_tmp.Position, G_nome, nome_ri) Then
            MessageBox.Show("problemi con la memorizzazione delle informazioni in uscita")
        End If
        Me.Dispose()
    End Sub
    Private Sub CalcolaTotali()
        Dim RG_O As DS_Ordini.DT_ordiniRow
        If bsOrdini.Count < 0 Then
            Return
        End If
        RG_O = DirectCast(bsOrdini.Current, DataRowView).Row
        Dim RG As DS_Ordini.DT_ordinirigheRow
        Dim IDC As Integer = RG_O.id_cliente
        Dim IDOrdineReale As Integer = RG_O.id  ' memorizza l'ID per poter assegnare il valore corretto del totale dell'ordine
        Dim IDO As Integer = 0
        Dim TotOrd As Decimal
        Dim TotCli As Decimal = 0
        Using TA As New DS_OrdiniTableAdapters.TA_righeTot
            Using DT As New DS_Ordini.DT_righeTotDataTable
                Dim rgTot As DS_Ordini.DT_righeTotRow
                Try
                    TA.FillByClientePeriodo(DT, GlobalVarPOP.G_idAZ, G_periodo, IDC)
                Catch ex As Exception
                    Dim err As DataRow() = Me.DS_Ordini.DT_ordinirighe.GetErrors
                    Dim msg As New StringBuilder
                    For Each e In err
#If DEBUG Then
                        MsgBox(e.RowError)
#End If
                    Next
                End Try
                Dim totRighe As Integer = DT.Count
                'PB_ordini.Maximum = totRighe
                Dim hn As Integer = 0
                For Each rgTot In DT
                    hn = hn + 1
                    '   PB_ordini.Value = hn - 1
                    'Nuovo Ordine
                    If IDO <> rgTot.id_ordine Then
                        IDO = rgTot.id_ordine
                        TotOrd = 0
                    End If
                    Dim prezzonetto As Decimal = rgTot.totNetto
                    TotOrd = TotOrd + prezzonetto
                    'Dettaglio riga 

                    TotCli = TotCli + prezzonetto

                    If IDOrdineReale = IDO Then
                        LBO.Text = TotOrd.ToString("N2")
                    End If
                    'Assegna all'albero del Destinatario il totale
                Next
                LBC.Text = TotCli.ToString("N2")
                LB_C.Text = "Tot " & If(IsDBNull(TT_CB_mese.SelectedItem), "", TT_CB_mese.SelectedItem)

                'PB_ordini.Value = 0
            End Using
        End Using

    End Sub
    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTModifica.Click
        Dim f As New FRM_MOD_ordini(bsOrdini)
        f.ShowDialog()
        MemorizzaOrdine()
    End Sub
    Private Sub MemorizzaOrdine()
        bsOrdini.EndEdit()
        Dim RG As DS_Ordini.DT_ordiniRow
        RG = DirectCast(bsOrdini.Current, DataRowView).Row
        Dim oldID As Integer = 0
        Dim idWebOrdini As Integer
        If Not RG.Isid_webordiniNull Then
            idWebOrdini = RG.id_webordini
        End If
        If RG.RowState = DataRowState.Modified Then
            oldID = RG.id

            Me.TA_ordini.QR_Modifica(RG.id_cliente, RG.id_locazione, RG.id_fornitore, RG.id_utente, RG.data_ordine, RG.id_az, RG.annotazioni, RG.i_inviato, RG.d_inviato, idWebOrdini, RG.id)
            RG.AcceptChanges()
            Me.TA_ordini.FillByPeriodo(Me.DS_Ordini.DT_ordini, G_periodo, G_AZ)
            bsOrdini.Position = bsOrdini.Find("id", oldID)
        End If
        If RG.RowState = DataRowState.Added Then
            Dim d_az As Integer = G_AZ
            Me.TA_ordini.QR_Inserisce(RG.id, RG.id_cliente, RG.id_locazione, RG.id_fornitore, RG.id_utente, RG.data_ordine, RG.annotazioni, d_az, If(RG.Isi_inviatoNull, 0, RG.i_inviato), RG.d_inviato, idWebOrdini)
            RG.AcceptChanges()
            Me.TA_ordini.FillByPeriodo(Me.DS_Ordini.DT_ordini, G_periodo, G_AZ)
            bsOrdini.Position = bsOrdini.Find("id", oldID)
        End If
    End Sub
    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim RG As DS_Ordini.DT_ordiniRow
        Dim RG_riga As DS_Ordini.DT_ordinirigheRow
        RG = DirectCast(bsOrdini.Current, DataRowView).Row
        If MsgBox("Confermi l' eliminazione dell' Ordine n° " & RG.id & " Cliente " & RG.societa, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim OldID As Integer = RG.id
            For Each RG_T In BS_righeOrdini
                RG_riga = DirectCast(RG_T, DataRowView).Row
                If RG_riga.id_ordine = OldID Then
                    RG_riga.Delete()
                End If
            Next
            RG.Delete()
            TA_ordini.QR_EliminaID(OldID)
            TA_ordinirighe.QR_eliminaOrdine(OldID)
        End If
    End Sub

    Private Sub DG_controlloTasti(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'Avvia la ricerca nuovi prodotti
        Dim KK As New DataGridView
        KK = DirectCast(sender, DataGridView)
        Dim KeyAscii As Short = e.KeyCode
        If KK.Name = "DG_ordinirighe" Then
            If KeyAscii = 118 Then
                If Not e.Handled Then
                    MemorizzaRigaOrdine()
                    e.SuppressKeyPress = True
                End If
            End If
        ElseIf KK.Name = "DG_ordini" Then
            If KeyAscii = 116 Then
                If Not e.Handled Then
                    DuplicaOrdine()
                    e.SuppressKeyPress = True
                End If
            End If
        End If
        'KK = Nothing
    End Sub
    Private Sub DuplicaOrdine()
        'Memorizza la riga ordine attuale
        Dim RG As DS_Ordini.DT_ordiniRow
        RG = DirectCast(bsOrdini.Current, DataRowView).Row
        Dim OldORDID As Integer = RG.id
        Dim NewORDID As Integer = TA_ordini.SQnuovoID + 1
        ' Crea un oggetto datarow dove memorizzare le informazioni
        Dim O_RG As DS_Ordini.DT_ordiniRow
        'Aggiunge una nuova riga nell'oggetto Bindingsource collegato
        bsOrdini.AddNew()
        O_RG = DirectCast(bsOrdini.Current, DataRowView).Row
        O_RG.id = NewORDID
        O_RG.data_ordine = Now
        O_RG.id_az = G_AZ
        O_RG.annotazioni = "COPIA " & RG.annotazioni
        O_RG.id_cliente = RG.id_cliente
        O_RG.societa = RG.societa
        O_RG.id_fornitore = RG.id_fornitore
        O_RG.fornitore = RG.fornitore
        O_RG.id_locazione = RG.id_locazione
        O_RG.locazione = RG.locazione
        O_RG.id_utente = RG.id_utente
        O_RG.anagrafica = RG.anagrafica
        Dim F As New FRM_MOD_ordini(bsOrdini)
        F.ShowDialog()
        MemorizzaOrdine()
        Using TA As New DS_OrdiniTableAdapters.TA_ordinirighe
            Using DT As New DS_Ordini.DT_ordinirigheDataTable
                TA.FillByID_ordine(DT, OldORDID)
                Dim g As Integer = DT.Count
                For Each RRG In DT
                    TA_ordinirighe.QR_Inserisce(NewORDID, RRG.id_prodotto, RRG.posizione, RRG.quantita,
                                                RRG.prezzo_unitario, RRG.sconto, RRG.tax, RRG.fatturabile, RRG.aggiornamento,
                                                Now, RRG.id_az)
                Next
            End Using
        End Using
        TA_ordinirighe.FillByPeriodo(DS_Ordini.DT_ordinirighe, G_periodo)
        MsgBox("Duplicato")
    End Sub
    Private Sub MemorizzaRigaOrdine()
        ' questa funzione serve a Memorizzare le informazioni trovate in FIND_Prodotti

        Dim f As New FRM_FIND_prodotti(RELrigheordineBindingSource, bsOrdini)
        f.ShowDialog()
    End Sub
    Private Sub bsRRG_AddingNew(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles RELrigheordineBindingSource.AddingNew

    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click

        Dim RG As DS_Ordini.DT_ordinirigheRow
        Using TA As New DS_OrdiniTableAdapters.TA_ordinirighe
            Using DT As New DS_Ordini.DT_ordinirigheDataTable
                For Each RG_T As DataRowView In RELrigheordineBindingSource
                    RG = DirectCast(RG_T, DataRowView).Row

                    Select Case RG.RowState
                        Case DataRowState.Added
                            TA.QR_Inserisce(RG.id_ordine, RG.id_prodotto, RG.posizione, RG.quantita, RG.prezzo_unitario, RG.sconto, RG.tax, If(RG.IsfatturabileNull, 0, RG.fatturabile), RG.aggiornamento, RG.dataordine, G_AZ)
                            RG.AcceptChanges()
                        Case DataRowState.Modified
                            TA.QR_Modifica(RG.id_ordine, RG.id_prodotto, RG.posizione, RG.quantita, RG.prezzo_unitario, RG.sconto, RG.tax, If(RG.IsfatturabileNull, 0, RG.fatturabile), RG.aggiornamento, RG.dataordine, G_AZ, RG.id)
                            RG.AcceptChanges()
                    End Select
                    TTBTannulla.BackColor = DefaultBackColor
                    TTBTSalva.BackColor = DefaultBackColor
                Next
            End Using
        End Using

    End Sub

    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        Try
            Dim stp As Form
            Dim tipo As Integer
            Dim pos As FolderBrowserDialog = New FolderBrowserDialog
            If InputBox("PDF o stampa ? ", "Scegli cosa fare", "PDF") = "PDF" Then
                tipo = 1
                pos.ShowDialog()
            Else
                tipo = 0
            End If

            For Each vv As DataGridViewRow In DG_ordini.SelectedRows
                'Console.WriteLine(vv.Value)
                Dim oldID As Integer = vv.Cells(DGWCoID.Index).Value
                stp = New FRM_STP_Ordini(oldID, tipo, pos.SelectedPath)                                            ' Apre la maschera con il numero ordine
                stp.ShowDialog()
                TA_ordini.QR_stampato(1, Now(), oldID)
            Next
            TA_ordini.FillByPeriodo(DS_Ordini.DT_ordini, G_periodo, G_AZ)
        Catch ex As Exception
#If DEBUG Then
            Console.WriteLine(ex.Message)
#End If
        End Try

    End Sub

    Private Sub TTBTannulla_Click(sender As Object, e As EventArgs) Handles TTBTannulla.Click
        BS_righeOrdini.CancelEdit()
        TTBTannulla.BackColor = DefaultBackColor
        TTBTSalva.BackColor = DefaultBackColor
        TA_ordinirighe.FillByPeriodo(DS_Ordini.DT_ordinirighe, G_periodo)
    End Sub

    Private Sub DT_ordinirigheElimina(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DG_ordinirighe.UserDeletingRow
        Dim oldROW As DataGridViewRow
        oldROW = DirectCast(e.Row, DataGridViewRow)
        Dim OldID As Integer
        OldID = oldROW.Cells(DGWCidRighe.Index).Value
        If MsgBox("Elimino " & oldROW.Cells(DGWCqta.Index).Value & " pz di " & oldROW.Cells(DGWCdescrizione.Index).Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Using DT As New DS_OrdiniTableAdapters.TA_ordinirighe
                DT.QR_eliminaID(OldID)
            End Using
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub DT_ordinirigheIniziamodifica(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DG_ordinirighe.RowValidating
        TTBTannulla.BackColor = System.Drawing.Color.Red
        TTBTSalva.BackColor = System.Drawing.Color.Green
    End Sub


    Private Sub TTTestoRicerca_Click(sender As Object, e As EventArgs) Handles TTBTRicerca.Click
        Dim TMP_ricerca As String = TTTestoRicerca.Text
        bsOrdini.Filter = String.Format("ricerca LIKE '%{0}%'", TMP_ricerca)
        Dim NN As Integer = 0
        Do While bsOrdini.Count < 1
            NN += 1
            TTTestoRicerca.Text = TTTestoRicerca.Text.Substring(0, TTTestoRicerca.Text.Length() - NN)
            bsOrdini.RemoveFilter()
            bsOrdini.Filter = String.Format("ricerca LIKE '%{0}%'", TMP_ricerca)
        Loop
    End Sub

    Private Sub DG_ordini_validate(sender As Object, e As DataGridViewCellEventArgs) Handles DG_ordini.RowValidated

        'dgwcId_webordini
    End Sub
    Private Sub DG_ordini_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_ordini.CellContentClick
        Dim tmpCell As DataGridViewCell
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        If e.RowIndex < 0 Then
            Return
        End If
        tmpCell = tmpDG(e.ColumnIndex, e.RowIndex)
        Select Case e.ColumnIndex
            Case dgwcId_webordini.Index
                Dim wo As New FRMOrdiniWeb(tmpCell.Value)
                wo.ShowDialog()
        End Select
    End Sub

    Private Sub DG_ordini_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_ordini.CellFormatting
        Select Case e.ColumnIndex
            Case DGWCoInviato.Index
                If e.Value IsNot Nothing Then
                    ' Check for the string "pink" in the cell.
                    Dim columnValue As Boolean
                    columnValue = CBool(e.Value)
                    e.Value = If(columnValue, ImageList1.Images(1), ImageList1.Images(0))
                End If
            Case dgwcStato.Index
                If Not String.IsNullOrEmpty(DG_ordini(dgwcId_webordini.Index, e.RowIndex).Value.ToString) Then
                    Dim posizione As Int16
                    Dim idwebOrdini As Int16 = DG_ordini(dgwcId_webordini.Index, e.RowIndex).Value
                    Dim Stato As Int16
                    posizione = bsWebOrdini.Find("id", idwebOrdini)
                    If posizione > 0 Then
                        bsWebOrdini.Position = posizione
                        Dim rgWebOrdini As DS_Ordini.DTordiniWebRow
                        rgWebOrdini = DirectCast(bsWebOrdini.Current, DataRowView).Row
                        Stato = rgWebOrdini.inviato
                    End If
                    DG_ordini(dgwcId_webordini.Index, e.RowIndex).ToolTipText = aStato(Stato)
                    DG_ordini(dgwcStato.Index, e.RowIndex).ToolTipText = aStato(Stato)
                    e.Value = ImageList2.Images(Stato)
                Else
                    e.Value = ImageList2.Images(3)
                End If



        End Select
    End Sub


    Private Sub lbPresenzeCliente_MouseMove(sender As Object, e As MouseEventArgs) Handles lbOrdineRighe.MouseMove
        If e.Button <> System.Windows.Forms.MouseButtons.Left Then
            Return
        End If

        Dim txTmp As Label
        txTmp = DirectCast(sender, Label)
        Select Case txTmp.Name
            Case lbOrdineRighe.Name

                Dim tbl As TableLayoutPanel = TL_1
                Dim a1 As Integer
                If tbl.RowStyles(0).SizeType = SizeType.Percent Then
                    a1 = tbl.Height * tbl.RowStyles(0).Height / 100
                Else
                    a1 = tbl.RowStyles(0).Height
                End If
                tbl.RowStyles(0).SizeType = SizeType.Absolute
                tbl.RowStyles(0).Height = a1
                Dim beam0 As Integer = tbl.RowStyles(0).Height + tbl.RowStyles(1).Height
                If beam0 - e.Y > 0 And beam0 + e.Y < tbl.Height Then
                    tbl.RowStyles(0).Height = tbl.RowStyles(0).Height + e.Y
                End If
        End Select
    End Sub
    Private Sub lbPresenzecursorToDefault(sender As Object, e As EventArgs) Handles lbOrdineRighe.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub lblPresenzecursorePremuto(sender As Object, e As EventArgs) Handles lbOrdineRighe.MouseHover
        Me.Cursor = Cursors.HSplit
    End Sub

    Private Sub tsFiltroControllo(sender As Object, e As EventArgs)
        If bsOrdini.Count > 0 Then
            Dim testo() As String = {"Non Stampato", "Periodo di Lavoro"}
            tsFiltro.Text = testo(If(tsFiltro.Checked, 1, 0))
            F_ricaricaDT()
        End If
    End Sub

    Private Sub TTBTAggiunge_Click_1(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click
        bsOrdini.AddNew()
        DG_ordini.Focus()

    End Sub
End Class