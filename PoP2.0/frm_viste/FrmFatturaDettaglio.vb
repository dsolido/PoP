

Public Class FrmFatturaDettaglio
    Dim G_Fattura As String
    Dim G_anno As Integer
    Dim G_Cli As DS_clienti.DT_cantieri_newRow
    Dim G_Dest As New DS_clienti.DT_locazione_newDataTable
    Dim G_nuovo As Boolean = False
    Friend WithEvents DG_fatturaArticoli As DataGridView
    Dim G_periodo As String
    Dim DRtmp As New DataGridViewRow
    Dim DT_storico As New DS_fattura.DT_fattura_righeDataTable
    Public Sub New(ByRef Fattura As String, ByVal idCli As DataRow, ByVal periodo As String, ByRef _DGtmp As DataGridViewRow)
        InitializeComponent()
        G_Fattura = Fattura
        G_Cli = idCli
        G_periodo = periodo
        DRtmp = _DGtmp
    End Sub
    Private Sub FRMmodificaFattura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TA_fattura_tipo.Fill(Me.DS_fattura.DT_fattura_tipo)

        Me.TA_iva.Fill(Me.DS_fattura.DT_iva)
        Me.TA_contore.FillByClientePeriodo(Me.DS_clienti.DT_contore, G_periodo, G_Cli.id)
        Me.TA_presenzeWEB.FillByClientePeriodo(Me.DS_clienti.DT_presenzeWEB, G_Cli.id, G_periodo)
        Me.TA_fatturaArticoli.Fill(Me.DS_fattura.DT_fatturaArticoli)
        Me.TA_fattura.FillByFattura(Me.DS_fattura.DT_fattura, G_Fattura)
        Me.TA_fattura_righe.FillByFattura(Me.DS_fattura.DT_fattura_righe, G_Fattura)
        Me.TA_tipologia.mostra(Me.DS_utenti.DT_tipologia)

        G_anno = G_Fattura.Split("/").Last

        Using TA_storico As New DS_fatturaTableAdapters.TA_fattura_righe
            TA_storico.FillByStorico_Cliente(DT_storico, G_Cli.id)
        End Using
        '        Me.TA_ordini.FillByCliente(Me.DS_Ordini.DT_ordini, G_Cli.id, frmavvio.G_idAZ)
        Me.TA_ordinirighe.FillByCliente(Me.DS_Ordini.DT_ordinirighe, G_Cli.id, G_anno)
        BS_storico.DataMember = DT_storico.TableName
        BS_storico.DataSource = DT_storico

        G_nuovo = True
        Using TA_locazioni As New DS_clientiTableAdapters.TA_locazione_new
            TA_locazioni.QR_fillID_terminale(G_Dest, G_Cli.id)
        End Using
        BSlocazioni.DataSource = G_Dest
        Dim totalefattura As Decimal
        For Each RG As DataRow In DS_fattura.DT_fattura_righe
            totalefattura = totalefattura + RG.Item("totale")
        Next
        If IsNothing(totalefattura) Then
            LBtotale.Text = 0
        Else
            LBtotale.Text = totalefattura
        End If
        'If BScontore.Count = 0 Then
        ' Return
        'End If
        AggiornaTabPresenze()
        AggiornaValoriPresenze()
    End Sub
    Private Sub CreaDG_elencoarticoli()

        DG_fatturaArticoli = New System.Windows.Forms.DataGridView()
        CType(Me.DG_fatturaArticoli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBL_articoli.Controls.Add(Me.DG_fatturaArticoli)
        'DG_fatturaArticoli
        Me.DG_fatturaArticoli.AutoGenerateColumns = False
        Me.DG_fatturaArticoli.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_fatturaArticoli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_fatturaArticoli.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn49})
        Me.DG_fatturaArticoli.DataSource = Me.BS_fatturaArticoli
        Me.DG_fatturaArticoli.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_fatturaArticoli.Location = New System.Drawing.Point(0, 90)
        Me.DG_fatturaArticoli.Margin = New System.Windows.Forms.Padding(0)
        Me.DG_fatturaArticoli.Name = "DG_fatturaArticoli"
        Me.DG_fatturaArticoli.RowHeadersWidth = 4
        Me.DG_fatturaArticoli.Size = New System.Drawing.Size(528, 339)
        Me.DG_fatturaArticoli.TabIndex = 10
        CType(Me.DG_fatturaArticoli, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub
    'Private Function AggiornaDati()
    '    Select Case TB_elenchi.Name
    '        Case TBLpresenzeWEB.Name
    '            If BSpresenzeweb.Count = 0 Then
    '                Return True
    '            End If
    '            CreaTabellaTotalePresenze() 'Genera la tabella Totale presenze remote
    '            RiempieTabellaTotalePresenzeWEB() 'Riempie con i valori
    '    End Select

    'End Function
    Private Sub AggiungeRighe(ByVal Optional Aggiunge As Boolean = False)
        Dim nuovoOrdine As Integer
        Dim RGF As DS_fattura.DT_fatturaRow
        RGF = DirectCast(BSfattura.Current, DataRowView).Row
        Dim RGR As DS_fattura.DT_fattura_righeRow
        If BSrighefattura.Count > 0 Then
            RGR = DirectCast(BSrighefattura.Current, DataRowView).Row
            nuovoOrdine = RGR.ordine + 1
        Else
            nuovoOrdine = 0
        End If
        If Aggiunge Then
            BSrighefattura.AddNew()
        End If
        RGR = DirectCast(BSrighefattura.Current, DataRowView).Row
        Dim RGD As DS_clienti.DT_locazione_newRow
        RGD = DirectCast(BSlocazioni.Current, DataRowView).Row
        RGR.cfa_idcli = G_Cli.id
        RGR.ordine = nuovoOrdine
        Using TA As New DS_clientiTableAdapters.TA_tipo_fatture_IVA_new
            RGR.cfa_iva = TA.SQvaloreIVA(1)   'Imposta il valore dell'IVA
            RGR.tipo_iva = TA.SQ_tipoIVA(1)
        End Using
        RGR.cfa_id = nuovoOrdine
        RGR.cfa_des = " "
        RGR.cfa_iddest = -1
        RGR.fat_data = RGF.fat_data
        RGR.cfa_fa_num = RGF.fat_num_da
        RGR.cfa_dataunica = Now()
        RGR.cfa_prezzo = 0
        RGR.cfa_sconto = 0
        RGR.cfa_pulofor = 1 ' indica la valuta 1 per €
        RGR.cfa_quanti = 0
        RGR.cfa_tipo = 1 'indica il tipo di linea per calcoli futuri su centro di costi
        RGR.cfa_rc = 1          'indica il tipo di imposizione IVA
        RGR.totale = (RGR.cfa_quanti * RGR.cfa_prezzo) * 1 - (RGR.cfa_sconto / 100)
        RGR.valoreiva = RGR.cfa_iva
    End Sub
    Private Sub DT_fattura_righeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_righefattura.CellDoubleClick
        Dim senderGrid As DataGridView
        senderGrid = DirectCast(sender, DataGridView)
        Dim Colonna As DataGridViewColumn = Nothing
        Colonna = senderGrid.Columns(e.ColumnIndex)
        Dim Cella As DataGridViewCell
        Cella = senderGrid(e.ColumnIndex, e.RowIndex)
        'If Cella.Value = Nothing Then
        '    'BSrighefattura.AddNew()

        'End If
    End Sub


    Private Sub DG_locazioni_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_locazioni.CellDoubleClick
        Dim nuovoOrdine As Integer
        Dim RGF As DS_fattura.DT_fatturaRow
        RGF = DirectCast(BSfattura.Current, DataRowView).Row
        Dim RGR As DS_fattura.DT_fattura_righeRow
        nuovoOrdine = OttienenuovoOrdine()
        'End Using

        BSrighefattura.AddNew()
        RGR = DirectCast(BSrighefattura.Current, DataRowView).Row
        Dim RGD As DS_clienti.DT_locazione_newRow
        RGD = DirectCast(BSlocazioni.Current, DataRowView).Row
        RGR.cfa_idcli = G_Cli.id
        RGR.ordine = nuovoOrdine
        Using TA As New DS_clientiTableAdapters.TA_tipo_fatture_IVA_new
            RGR.cfa_iva = TA.SQvaloreIVA(RGD.fatturabile)   'Imposta il valore dell'IVA
            RGR.tipo_iva = TA.SQ_tipoIVA(RGD.fatturabile)
        End Using
        RGR.cfa_id = nuovoOrdine
        RGR.cfa_des = RGD.riga_fattura
        RGR.cfa_iddest = RGD.id
        RGR.fat_data = RGF.fat_data
        RGR.cfa_fa_num = RGF.fat_num_da
        RGR.cfa_dataunica = Now()
        RGR.cfa_prezzo = RGD.canone
        RGR.cfa_sconto = 0
        RGR.cfa_pulofor = 1 ' indica la valuta 1 per €
        RGR.cfa_quanti = 1
        RGR.pagata = 0
        RGR.cfa_tipo = RGD.extra 'indica il tipo di linea per calcoli futuri su centro di costi
        RGR.cfa_rc = RGD.fatturabile          'indica il tipo di imposizione IVA
        RGR.totale = (RGR.cfa_quanti * RGR.cfa_prezzo) * 1 - (RGR.cfa_sconto / 100)
        RGR.valoreiva = RGR.cfa_iva
        BSrighefattura.EndEdit()
        DG_righefattura.Focus()
    End Sub
    Private Function OttienenuovoOrdine() As Integer
        Dim nuovoordine As Integer
        Dim RGR As DS_fattura.DT_fattura_righeRow
        If BSrighefattura.Count > 0 Then
            BSrighefattura.MoveLast()
            RGR = DirectCast(BSrighefattura.Current, DataRowView).Row
            nuovoordine = RGR.ordine + 1
            If BSrighefattura.Count <= nuovoordine Then
                nuovoordine = BSrighefattura.Count + 1
            End If
        Else
            nuovoordine = 0
        End If
        Return nuovoordine
    End Function
    Private Sub BTN_salva_Click(sender As Object, e As EventArgs) Handles BTN_salva.Click
        BSrighefattura.EndEdit()
        Dim RGR As DS_fattura.DT_fattura_righeRow
        For Each RG In BSrighefattura
            RGR = DirectCast(RG, DataRowView).Row
            Select Case RGR.RowState
                Case DataRowState.Added
                    TA_fattura_righe.QR_inserisce(RGR.cfa_id, RGR.ordine, RGR.cfa_fa_num, RGR.cfa_des,
                                                RGR.cfa_quanti, RGR.cfa_prezzo, RGR.cfa_sconto, RGR.cfa_iva, RGR.cfa_iddest,
                                                RGR.cfa_idcli, RGR.cfa_pulofor, RGR.cfa_dataunica, RGR.cfa_rc, RGR.cfa_tipo)
                Case DataRowState.Modified
                    TA_fattura_righe.QR_modifica(RGR.ordine, RGR.cfa_fa_num, RGR.cfa_des,
                                                RGR.cfa_quanti, RGR.cfa_prezzo, RGR.cfa_sconto, RGR.cfa_iva, RGR.cfa_iddest,
                                                RGR.cfa_idcli, RGR.cfa_pulofor, RGR.cfa_dataunica, RGR.cfa_rc, RGR.cfa_tipo, RGR.id)
            End Select
            RGR.AcceptChanges()
        Next
        TA_fattura_righe.FillByFattura(DS_fattura.DT_fattura_righe, G_Fattura)
        Dim totalefattura As Decimal
        For Each RG As DataRow In DS_fattura.DT_fattura_righe
            totalefattura = totalefattura + RG.Item("totale")
        Next
        If IsNothing(totalefattura) Then
            LBtotale.Text = 0
        Else
            LBtotale.Text = totalefattura
        End If
        Using TA_storico As New DS_fatturaTableAdapters.TA_fattura_righe
            TA_storico.FillByStorico_Cliente(DT_storico, G_Cli.id)
        End Using

    End Sub

    Private Sub BTN_termina_Click(sender As Object, e As EventArgs) Handles BTN_termina.Click
        For Each RG As DataRowView In BSrighefattura
            If RG.Row.RowState <> DataRowState.Unchanged Then
                If MsgBox("Attenzione ci sono modifiche non memorizzate, memorizzo ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    BTN_salva.PerformClick()
                End If
            End If
        Next
        DGpresenzeremote.DataSource = ""
        DGpresenzereali.DataSource = ""

        Me.Close()

    End Sub

    Private Sub BTN_aggiungi_Click(sender As Object, e As EventArgs) Handles BTN_aggiungi.Click
        AggiungeRighe(True)
        BSrighefattura.EndEdit()
        DG_righefattura.Focus()

    End Sub

    Private Sub BTN_elimina_Click(sender As Object, e As EventArgs) Handles BTN_elimina.Click
        Dim RGR As DS_fattura.DT_fattura_righeRow
        If BSrighefattura.Count > 0 Then
            RGR = DirectCast(BSrighefattura.Current, DataRowView).Row
            TA_fattura_righe.QR_elimina(RGR.id)
            'TA_fattura_righe.FillByFattura(DS_fattura.DT_fattura_righe, G_Fattura)
            RGR.AcceptChanges()
        End If

    End Sub

    Private Sub DG_fatturaArticoli_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_fatturaArticoli.CellDoubleClick
        'Se doppio clicchi sugli articoli preimpostati
        Dim nuovoOrdine As Integer
        Dim RGF As DS_fattura.DT_fatturaRow
        RGF = DirectCast(BSfattura.Current, DataRowView).Row
        Dim RGR As DS_fattura.DT_fattura_righeRow
        nuovoOrdine = OttienenuovoOrdine()
        'End Using
        BSrighefattura.AddNew()
        RGR = DirectCast(BSrighefattura.Current, DataRowView).Row
        Dim RGD As DS_fattura.DT_fatturaArticoliRow
        RGD = DirectCast(BS_fatturaArticoli.Current, DataRowView).Row
        RGR.cfa_idcli = G_Cli.id
        RGR.ordine = nuovoOrdine
        Using TA As New DS_clientiTableAdapters.TA_tipo_fatture_IVA_new
            RGR.cfa_iva = TA.SQvaloreIVA(RGD.id_codiceIVA)   'Imposta il valore dell'IVA
            'RGR.tipo_iva = TA.SQ_tipoIVA(RGD.fatturabile)
        End Using
        RGR.cfa_id = nuovoOrdine
        RGR.cfa_des = RGD.descrizione
        RGR.cfa_iddest = RGD.id
        RGR.fat_data = RGF.fat_data
        RGR.cfa_fa_num = RGF.fat_num_da
        RGR.cfa_dataunica = Now()
        RGR.cfa_prezzo = RGD.prezzo
        RGR.cfa_sconto = 0
        RGR.cfa_pulofor = 1 ' indica la valuta 1 per €
        RGR.cfa_quanti = 1
        RGR.pagata = 0
        RGR.cfa_tipo = 1 'RGD.extra 'indica il tipo di linea per calcoli futuri su centro di costi
        RGR.cfa_rc = RGD.id_codiceIVA 'indica il tipo di imposizione IVA
        RGR.totale = (RGR.cfa_quanti * RGR.cfa_prezzo) * 1 - (RGR.cfa_sconto / 100)
        RGR.valoreiva = RGR.cfa_iva
        BSrighefattura.EndEdit()
        DG_righefattura.Focus()
    End Sub
    Private Sub DG_fatturaArticoli_RowInserisce(sender As Object, e As DataGridViewCellEventArgs) Handles DG_fatturaArticoli.RowValidated
        ' si verifica quando convalido una nuova riga preimpostata
        Dim nuovoprodotto As Integer
        Dim RGF As DS_fattura.DT_fatturaArticoliRow
        nuovoprodotto = TA_fatturaArticoli.SQnuovoid_prodotto() + 1
        BS_fatturaArticoli.EndEdit()
        RGF = DirectCast(BS_fatturaArticoli.Current, DataRowView).Row
        Select Case RGF.RowState
            Case DataViewRowState.Added
                RGF.id_prod = nuovoprodotto
                TA_fatturaArticoli.QRinserisce(nuovoprodotto, RGF.descrizione, RGF.prezzo, IIf(RGF.Isid_codiceIVANull, 1, RGF.id_codiceIVA))
            Case DataViewRowState.ModifiedCurrent
                TA_fatturaArticoli.QRmodifica(RGF.id_prod, RGF.descrizione, RGF.prezzo, RGF.id_codiceIVA, RGF.id)
        End Select
        RGF.AcceptChanges()
    End Sub
    Private Function CreaTabellaTotalePresenze(tmpDG As DataGridView)

        Dim TotaleLarghezza As Integer = tmpDG.Width - 50

        tmpDG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        tmpDG.ScrollBars = ScrollBars.Vertical
        tmpDG.Columns.Clear()
        Dim ColoDettaglioCellaStile As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim ColoTotaleCellaStile As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim ColoDettaglioText As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Dim ColoTipologiaText As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()
        Dim ColoTotaleText As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn()

        ColoDettaglioText.Width = TotaleLarghezza / 100 * 50.0
        ColoDettaglioText.HeaderText = "Dettaglio Cliente"
        ColoDettaglioText.Name = "ColPDettaglio"
        ColoDettaglioCellaStile.Alignment = DataGridViewContentAlignment.MiddleLeft
        ColoDettaglioText.DefaultCellStyle = ColoDettaglioCellaStile

        ColoTipologiaText.Width = TotaleLarghezza / 100 * 20.0
        ColoTipologiaText.HeaderText = "Tipologia"
        ColoTipologiaText.Name = "ColPTipologia"
        ColoDettaglioCellaStile.Alignment = DataGridViewContentAlignment.MiddleLeft
        ColoTipologiaText.DefaultCellStyle = ColoDettaglioCellaStile

        ColoTotaleText.Width = TotaleLarghezza / 100 * 10.0
        ColoTotaleText.HeaderText = "Totale"
        ColoTotaleText.Name = "ColPTotale"
        ColoTotaleCellaStile.Alignment = DataGridViewContentAlignment.MiddleRight
        ColoTotaleCellaStile.Format = "N2"
        ColoTotaleText.DefaultCellStyle = ColoTotaleCellaStile
        tmpDG.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {ColoDettaglioText, ColoTipologiaText, ColoTotaleText})

    End Function
    Private Function RiempieRiepiloghi(ByRef tmpDG As DataGridView, tmpBS As BindingSource, ByRef RGW As Object)

        Dim Totale As Decimal = 0
        Dim GranTotale As Decimal = 0
        Dim TotaleAssenze As Decimal = 0
        Dim Id_dest As Integer
        Dim Dettaglio As String
        Dim fg As DataGridView
        fg = tmpDG

        Dim DTrr As New DataTable
        DTrr = CrealanuovaDatatable("RiepilogoReali")
        Dim row As DataRow
        row = DTrr.NewRow()

        For Each RG As DataRowView In tmpBS
            RGW = DirectCast(RG, DataRowView).Row
            row = DTrr.NewRow()
            Select Case tmpBS.DataMember
                Case = "DT_contore"
                    row("ore") = RGW.ore
                    row("idDes") = RGW.id_dest
                    row("Des") = RGW.locazione
                    row("idTipo") = RGW.id_tipo
                    row("tipo") = RGW.tipologia
                    row("destipo") = RGW.id_dest & "-" & RGW.id_tipo
                Case "DT_presenzeWEB"
                    Dim tmpTime As New TimeSpan
                    tmpTime = TimeSpan.Parse(RGW.orario)
                    row("ore") = tmpTime.TotalHours
                    row("idDes") = RGW.id_locazione
                    row("Des") = RGW.locazione
                    row("idTipo") = RGW.inviato
                    row("tipo") = RGW.descrizione
                    row("destipo") = RGW.id_locazione & "-" & RGW.inviato
            End Select
            DTrr.Rows.Add(row)
        Next

        Dim view As New DataView(DTrr)
        view.Sort = "idDes,tipo"
        Id_dest = view.Item(0).Row.Item("idDes")
        Dettaglio = view.Item(0).Row.Item("Des")
        Dim Tipologia As String = view.Item(0).Row.Item("tipo")
        Dim DesTipo As String = view.Item(0).Row.Item("destipo")
        'Dim Dettaglio As String = RGP.locazione
        For Each rg As DataRowView In view
            Dim tmpTime As New Decimal
            Dim tmpTipo As New Integer
            tmpTime = rg.Item("ore")
            'Somma il Gran Totale
            tmpTipo = rg.Item("idTipo")
            'Se è diverso da assente allora somma il totale
            If tmpTipo <> 2 Then
                GranTotale += tmpTime
            Else
                TotaleAssenze += tmpTime
            End If

            Select Case DesTipo
                Case <> rg.Item("destipo")
                    tmpDG.Rows.Add({Dettaglio, Tipologia, Totale})
                    DesTipo = rg.Item("destipo")
                    Dettaglio = rg.Item("Des")
                    Tipologia = rg.Item("tipo")
                    Totale = tmpTime
                Case = rg.Item("destipo")
                    Dettaglio = rg.Item("Des")
                    Tipologia = rg.Item("tipo")
                    Totale = Totale + tmpTime
            End Select

        Next
        tmpDG.Rows.Add({Dettaglio, Tipologia, Totale})
        tmpDG.Rows.Add({"Totale Presenze", "", GranTotale})
        tmpDG.Rows.Add({"Totale Assenze", "", TotaleAssenze})
        Return True
    End Function
    Private Function RiempieTabellaTotalePresenzeWEB()
        Dim RGP As DS_clienti.DT_presenzeWEBRow
        Dim Totale As Decimal
        Dim GranTotale As Decimal

        RGP = DirectCast(BSpresenzeweb.Current, DataRowView).Row

        Dim Id_dest As Integer = RGP.id_locazione
        Dim Dettaglio As String = RGP.locazione
        For Each RG As DataRowView In BSpresenzeweb
            RGP = DirectCast(RG, DataRowView).Row
            Dim tmpTime As New TimeSpan
            tmpTime = TimeSpan.Parse(RGP.orario)
            GranTotale = GranTotale + tmpTime.TotalHours
            If Id_dest <> RGP.id_locazione Then
                DGtotalepresenzeremote.Rows.Add({Dettaglio, Totale})
                Id_dest = RGP.id_locazione
                Dettaglio = RGP.locazione
                Totale = tmpTime.TotalHours
            Else
                Dettaglio = RGP.locazione
                Totale = Totale + tmpTime.TotalHours
            End If
        Next
        DGtotalepresenzeremote.Rows.Add({Dettaglio, Totale})
        DGtotalepresenzeremote.Rows.Add({"gran Totale", GranTotale})
        Return True
    End Function
    Private Function RiempieTabellaTotalePresenzeReali()

        Dim RGP As DS_clienti.DT_contoreRow
        Dim Totale As Decimal
        Dim GranTotale As Decimal
        Dim TotaleAssenze As Decimal
        RGP = DirectCast(BScontore.Current, DataRowView).Row
        Dim DTrr As DataTable

        DTrr = CrealanuovaDatatable("RiepilogoReali")
        ' NewRow to create a DataRow.
        Dim row As DataRow
        row = DTrr.NewRow()


        For Each RG As DataRowView In BScontore
            RGP = DirectCast(RG, DataRowView).Row
            row = DTrr.NewRow()
            row("ore") = RGP.ore
            row("idDes") = RGP.id_dest
            row("Des") = RGP.locazione
            row("idTipo") = RGP.id_tipo
            row("tipo") = RGP.tipologia
            row("destipo") = RGP.id_dest & "-" & RGP.id_tipo
            DTrr.Rows.Add(row)
        Next
        ' Create DataView
        Dim view As New DataView(DTrr)
        view.Sort = "idDes"
        Dim Id_dest As Integer = view.Item(0).Row.Item("idDes")
        Dim Dettaglio As String = view.Item(0).Row.Item("Des")
        Dim Tipologia As String = view.Item(0).Row.Item("tipo")
        Dim DesTipo As String = view.Item(0).Row.Item("destipo")
        'Dim Dettaglio As String = RGP.locazione
        For Each rg As DataRowView In view
            Dim tmpTime As New Decimal
            Dim tmpTipo As New Integer
            tmpTime = rg.Item("ore")
            'Somma il Gran Totale
            tmpTipo = rg.Item("idTipo")
            If tmpTipo <> 2 Then
                GranTotale += tmpTime
            Else
                TotaleAssenze += tmpTime
            End If

            Select Case DesTipo
                Case <> rg.Item("destipo")
                    DGtotalepresenze.Rows.Add({Dettaglio, Tipologia, Totale})
                    DesTipo = rg.Item("destipo")
                    Dettaglio = rg.Item("Des")
                    Tipologia = rg.Item("tipo")
                    Totale = tmpTime
                Case = rg.Item("destipo")
                    Dettaglio = rg.Item("Des")
                    Tipologia = rg.Item("tipo")
                    Totale = Totale + tmpTime
            End Select

        Next
        DGtotalepresenze.Rows.Add({Dettaglio, Tipologia, Totale})
        DGtotalepresenze.Rows.Add({"Totale Presenze", "", GranTotale})
        DGtotalepresenze.Rows.Add({"Totale Assenze", "", TotaleAssenze})
        Return True
    End Function
    Private Function CrealanuovaDatatable(ByRef NomeTabella As String) As DataTable
        ' Create a new DataTable titled 'Names.'
        Dim namesTable As New DataTable(NomeTabella)

        ' Add three column objects to the table.
        Dim idColumn As New DataColumn()
        idColumn.DataType = System.Type.GetType("System.Int32")
        idColumn.ColumnName = "id"
        idColumn.AutoIncrement = True
        namesTable.Columns.Add(idColumn)

        Dim fNameColumn As New DataColumn()
        fNameColumn.DataType = System.Type.GetType("System.Decimal")
        fNameColumn.ColumnName = "ore"
        fNameColumn.DefaultValue = 0
        namesTable.Columns.Add(fNameColumn)
        ' Create an array for DataColumn objects.
        Dim fidDesColumn As New DataColumn()
        fidDesColumn.DataType = System.Type.GetType("System.Int32")
        fidDesColumn.ColumnName = "idDes"
        fidDesColumn.DefaultValue = 0
        namesTable.Columns.Add(fidDesColumn)

        Dim fDesColumn As New DataColumn()
        fDesColumn.DataType = System.Type.GetType("System.String")
        fDesColumn.ColumnName = "Des"
        fDesColumn.DefaultValue = ""
        namesTable.Columns.Add(fDesColumn)

        Dim fidTipoColumn As New DataColumn()
        fidTipoColumn.DataType = System.Type.GetType("System.Int32")
        fidTipoColumn.ColumnName = "idTipo"
        fidTipoColumn.DefaultValue = 0
        namesTable.Columns.Add(fidTipoColumn)

        Dim ftipoColumn As New DataColumn()
        ftipoColumn.DataType = System.Type.GetType("System.String")
        ftipoColumn.ColumnName = "tipo"
        ftipoColumn.DefaultValue = ""
        namesTable.Columns.Add(ftipoColumn)

        Dim fDesTipoColumn As New DataColumn()
        fDesTipoColumn.DataType = System.Type.GetType("System.String")
        fDesTipoColumn.ColumnName = "destipo"
        fDesTipoColumn.DefaultValue = 0
        namesTable.Columns.Add(fDesTipoColumn)

        Dim keys(0) As DataColumn
        keys(0) = idColumn
        namesTable.PrimaryKey = keys
        ' Return the new DataTable.
        CrealanuovaDatatable = namesTable

    End Function
    Private Sub TB_elenchiSeleziona(sender As Object, e As EventArgs) Handles TB_elenchi.SelectedIndexChanged
        Dim tab As TabControl
        tab = DirectCast(sender, TabControl)
        Select Case tab.SelectedTab.Name
            Case TBL_articoli.Name
                Dim x As Integer
                For x = 0 To Me.TBL_articoli.Controls.Count - 1
                    If (CType(Me.TBL_articoli.Controls(x).Name, String)) = "DG_fatturaArticoli" Then
                        Return
                    End If
                Next
                CreaDG_elencoarticoli()
            Case TBL_storicoFattura.Name

            Case TBLpresenzeReali.Name
                AggiornaTabPresenze()
            Case Else
                BSrigheordini.RemoveFilter()
        End Select
        TXricerca.Text = TXricerca.Text & " "
    End Sub
    Private Sub AggiornaTabPresenze()
        Dim mese As Integer = G_periodo.Split("-").Last

        BSrigheordini.Filter = "fatturabile = 1 AND strmese LIKE '%" & mese.ToString() & "%' OR fatturabile = 1 AND strmese LIKE '%" & (mese - 1).ToString().PadLeft(2, "00") & "%'"
#If DEBUG Then
        Dim valore As String
        Dim RGT As DS_Ordini.DT_ordinirigheRow
        For Each FT In BSrigheordini
            RGT = DirectCast(FT, DataRowView).Row
            Console.WriteLine(RGT.strmese)
        Next

#End If

        If BSrigheordini.Count > 0 Then
            LBpresenzaordini.BackColor = Color.Green
            LBpresenzaordini.Text = "PRESENTI"
        Else
            LBpresenzaordini.BackColor = DefaultBackColor
            LBpresenzaordini.Text = "NON PRESENTI"
        End If

        If BSpresenzeweb.Count > 0 Then
            CreaTabellaTotalePresenze(DGtotalepresenzeremote) 'Genera la tabella Totale presenze remote
            Dim RGW As DS_clienti.DT_presenzeWEBRow
            RGW = DirectCast(BSpresenzeweb.Current, DataRowView).Row
            RiempieRiepiloghi(DGtotalepresenzeremote, BSpresenzeweb, RGW)
        End If

        If BScontore.Count > 0 Then
            CreaTabellaTotalePresenze(DGtotalepresenze) 'Genera la tabella Totale presenze remote
            Dim RG As DS_clienti.DT_contoreRow
            RG = DirectCast(BScontore.Current, DataRowView).Row
            RiempieRiepiloghi(DGtotalepresenze, BScontore, RG)
        End If

    End Sub


    Private Sub TXricerca_TextChanged(sender As Object, e As EventArgs) Handles TXricerca.TextChanged
        Dim TX As TextBox
        TX = DirectCast(sender, TextBox)
        TX.Text = TX.Text.Trim
        Select Case TB_elenchi.SelectedTab.Name
            Case TBL_storicoFattura.Name
                Do While BS_storico.Count > 0
                    BS_storico.Filter = "cfa_des LIKE '%" & TX.Text & "%'"
                    If BS_storico.Count > 0 Then
                        Exit Do
                    End If
                    BS_storico.RemoveFilter()
                    TX.Text = TX.Text.Substring(0, TX.Text.Length - 1)
                    TX.SelectionStart = TX.Text.Length
                Loop
            Case TBL_articoli.Name
                Do While BS_fatturaArticoli.Count > 0
                    BS_fatturaArticoli.Filter = "descrizione LIKE '%" & TX.Text & "%'"
                    If BS_fatturaArticoli.Count > 0 Then
                        Exit Do
                    End If
                    BS_fatturaArticoli.RemoveFilter()
                    TX.Text = TX.Text.Substring(0, TX.Text.Length - 1)
                    TX.SelectionStart = TX.Text.Length
                Loop
            Case TBL_dettagliocliente.Name
                Do While BSlocazioni.Count > 0
                    BSlocazioni.Filter = "locazione LIKE '%" & TX.Text & "%'"
                    If BSlocazioni.Count > 0 Then
                        Exit Do
                    End If
                    BSlocazioni.RemoveFilter()
                    TX.Text = TX.Text.Substring(0, TX.Text.Length - 1)
                    TX.SelectionStart = TX.Text.Length
                Loop
        End Select
    End Sub

    Private Sub DG_storico_celldoubleclick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_storico.CellContentDoubleClick
        ' Crea la riga partendo dallo storico
        'Predispone il nuovo inserimento
        Dim nuovoOrdine As Integer
        Dim RGF As DS_fattura.DT_fatturaRow
        RGF = DirectCast(BSfattura.Current, DataRowView).Row
        Dim RGR As DS_fattura.DT_fattura_righeRow
        nuovoOrdine = OttienenuovoOrdine()

        'Aggiunge la nuova riga
        BSrighefattura.AddNew()
        RGR = DirectCast(BSrighefattura.Current, DataRowView).Row
        Dim RGD As DS_fattura.DT_fattura_righeRow
        RGD = DirectCast(BS_storico.Current, DataRowView).Row
        'Memorizza il cliente
        RGR.cfa_idcli = G_Cli.id
        'Memorizza il nuovo Ordine
        RGR.ordine = nuovoOrdine
        RGR.cfa_iva = RGD.cfa_iva   'Imposta il valore dell'IVA
        RGR.tipo_iva = RGD.tipo_iva
        RGR.cfa_id = nuovoOrdine
        RGR.cfa_des = RGD.cfa_des
        RGR.cfa_iddest = RGD.cfa_iddest
        RGR.fat_data = RGF.fat_data
        RGR.cfa_fa_num = RGF.fat_num_da
        RGR.cfa_dataunica = Now()
        RGR.cfa_prezzo = RGD.cfa_prezzo
        RGR.cfa_sconto = RGD.cfa_sconto
        RGR.cfa_pulofor = RGD.cfa_pulofor ' indica la valuta 1 per €
        RGR.cfa_quanti = RGD.cfa_quanti
        RGR.pagata = 0
        RGR.cfa_tipo = RGD.cfa_tipo 'RGD.extra 'indica il tipo di linea per calcoli futuri su centro di costi
        RGR.cfa_rc = RGD.cfa_rc 'indica il tipo di imposizione IVA
        RGR.totale = (RGR.cfa_quanti * RGR.cfa_prezzo) * 1 - (RGR.cfa_sconto / 100)
        RGR.valoreiva = RGR.cfa_iva
        BSrighefattura.EndEdit()
        DG_righefattura.Focus()
    End Sub

    Private Sub DGordinirighe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGordinirighe.CellContentClick
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            Return
        End If

        Dim Cella As DataGridViewCell
        Cella = DirectCast(sender, DataGridView)(e.ColumnIndex, e.RowIndex)
        Dim RGD As DS_Ordini.DT_ordinirigheRow
        BSrigheordini.EndEdit()
        RGD = DirectCast(BSrigheordini.Current, DataRowView).Row

        Select Case Cella.ColumnIndex
            Case 7  'indica che è stata cliccata su consegnata
                TA_ordinirighe.QR_consegnato(IIf(RGD.consegnato = 0, 1, 0), Now(), RGD.id)
                RGD.AcceptChanges()
            Case 8 ' indica che è stata fatturata
                TA_ordinirighe.QR_memorizzafattura(IIf(RGD.fatturato = 0, 1, 0), G_Fattura, 0, RGD.id)
                RGD.AcceptChanges()
            Case 1
                If MsgBox("Aggiungo la riga", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim nuovoordine As Integer = OttienenuovoOrdine()

                    BSrighefattura.AddNew()
                    Dim RGF As DS_fattura.DT_fatturaRow
                    RGF = DirectCast(BSfattura.Current, DataRowView).Row
                    Dim RGR As DS_fattura.DT_fattura_righeRow
                    RGR = DirectCast(BSrighefattura.Current, DataRowView).Row
                    'Memorizza il cliente
                    RGR.cfa_idcli = G_Cli.id
                    'Memorizza il nuovo Ordine
                    RGR.ordine = nuovoordine
                    Using TA As New DS_clientiTableAdapters.TA_tipo_fatture_IVA_new
                        RGR.cfa_iva = RGD.tax   'Imposta il valore dell'IVA
                        RGR.tipo_iva = 1
                    End Using
                    RGR.cfa_id = nuovoordine
                    RGR.cfa_des = RGD.descrizione
                    RGR.cfa_iddest = RGD.id_locazione
                    RGR.fat_data = RGF.fat_data
                    RGR.cfa_fa_num = RGF.fat_num_da
                    RGR.cfa_dataunica = Now()
                    RGR.cfa_prezzo = RGD.prezzo_unitario
                    RGR.cfa_sconto = RGD.sconto
                    RGR.cfa_pulofor = 1 ' indica la valuta 1 per €
                    RGR.cfa_quanti = RGD.quantita
                    RGR.pagata = 0
                    RGR.cfa_tipo = RGD.fatturabile 'RGD.extra 'indica il tipo di linea per calcoli futuri su centro di costi
                    RGR.cfa_rc = 2 'indica il tipo di imposizione IVA
                    RGR.totale = (RGR.cfa_quanti * RGR.cfa_prezzo) * 1 - (RGR.cfa_sconto / 100)
                    RGR.valoreiva = RGR.cfa_iva
                    BSrighefattura.EndEdit()
                    DG_righefattura.Focus()

                End If

        End Select
    End Sub

    Private Sub DGpresenzeremote_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim Cella As DataGridViewCell
        If e.ColumnIndex < 0 Or e.RowIndex < 0 Then
            Return
        End If
        Cella = DirectCast(sender, DataGridView)(e.ColumnIndex, e.RowIndex)
        Dim RGD As DS_clienti.DT_presenzeWEBRow
        RGD = DirectCast(BSpresenzeweb.Current, DataRowView).Row
        Dim RGL As DS_clienti.DT_locazione_newRow
        RGL = DirectCast(BSlocazioni.Current, DataRowView).Row
        Select Case e.ColumnIndex
            Case 0
                Dim codice As Integer
                codice = DGpresenzeremote(e.ColumnIndex, e.RowIndex).Value
                Dim G As New FrmDipendentiPresenzeWeb(codice)
                G.ShowDialog()
                Return
            Case Else
                If MsgBox("Hai selezionato il dettaglio cliente?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    Return
                End If
                If MsgBox("Aggiungo la riga", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Dim nuovoordine As Integer = OttienenuovoOrdine()
                    BSrighefattura.AddNew()
                    Dim RGF As DS_fattura.DT_fatturaRow
                    RGF = DirectCast(BSfattura.Current, DataRowView).Row
                    Dim RGR As DS_fattura.DT_fattura_righeRow
                    RGR = DirectCast(BSrighefattura.Current, DataRowView).Row

                    'Memorizza il cliente
                    RGR.cfa_idcli = G_Cli.id
                    'Memorizza il nuovo Ordine
                    RGR.ordine = nuovoordine
                    Using TA As New DS_clientiTableAdapters.TA_tipo_fatture_IVA_new
                        RGR.cfa_iva = TA.SQvaloreIVA(RGL.fatturabile)   'Imposta il valore dell'IVA
                        RGR.tipo_iva = TA.SQ_tipoIVA(RGL.fatturabile)
                    End Using

                    RGR.cfa_id = nuovoordine
                    RGR.cfa_des = "Intervento straordinario"
                    RGR.cfa_iddest = RGD.id_locazione
                    RGR.fat_data = RGF.fat_data
                    RGR.cfa_fa_num = RGF.fat_num_da
                    RGR.cfa_dataunica = Now()
                    RGR.cfa_prezzo = RGL.canone
                    RGR.cfa_sconto = 0
                    RGR.cfa_pulofor = 1 ' indica la valuta 1 per €
                    RGR.cfa_quanti = RGR.totale
                    RGR.pagata = 0
                    RGR.cfa_tipo = RGL.fatturabile 'RGD.extra 'indica il tipo di linea per calcoli futuri su centro di costi
                    RGR.cfa_rc = 2 'indica il tipo di imposizione IVA
                    RGR.totale = (RGR.cfa_quanti * RGR.cfa_prezzo) * 1 - (RGR.cfa_sconto / 100)
                    RGR.valoreiva = RGR.cfa_iva
                    BSrighefattura.EndEdit()
                    DG_righefattura.Focus()
                End If

        End Select
    End Sub


    Private Sub AggiornaValoriPresenze()
        If IsNothing(G_periodo) Then
            Return
        End If
        Dim risp As Boolean
        Dim pp As creaTabellaOreMese = New creaTabellaOreMese
        pp.Mese = G_periodo.Split("-").Last
        pp.Anno = G_periodo.Split("-").First
        pp.dataGridPresenze = dgwPresenzeReali
        pp.DescPrimaTabella = "Reali"
        pp.dimFontCella = 8
        risp = pp.Crea()
        caricaDatiReali(dgwPresenzeReali)
        Dim p2 As creaTabellaOreMese = New creaTabellaOreMese
        p2.Mese = G_periodo.Split("-").Last
        p2.Anno = G_periodo.Split("-").First
        p2.dataGridPresenze = dgwPresenzeTimbrate
        p2.DescPrimaTabella = "Timbrate"
        p2.dimFontCella = 8
        risp = p2.Crea()
        caricaDatiWeb(dgwPresenzeTimbrate)
    End Sub

    Private Sub caricaDatiWeb(ByVal dg_view As DataGridView)

        Dim idDGW As String
        Dim oldRow As Int32 = 0
        Using dt As New DS_clienti.DT_presenzeWEBDataTable
            Using ta As New DS_clientiTableAdapters.TA_presenzeWEB
                ta.FillByPeriodoTotale(dt, G_periodo, G_Cli.id)
            End Using
            If dg_view.Rows.Count > 0 Then
                oldRow = dg_view.CurrentRow.Index
                'individua l'ID principale
                idDGW = dg_view(0, oldRow).Value
            End If
            Dim pp As dgCaricaDatiPresenze = New dgCaricaDatiPresenze
            pp.Mese = G_periodo.Split("-").Last
            pp.Anno = G_periodo.Split("-").First
            pp.dtPresenze = dt
            pp.idCantiere = G_Cli.id
            pp.rgDataRow = DirectCast(BSpresenzeweb.Current, DataRowView)
            pp.remota = True
            pp.dataGridAppoggio = dg_view
            Dim risp As Boolean = pp.caricaDati
            Dim xr As Int32 = 0
            For Each riga As DataGridViewRow In dg_view.Rows
                If riga.Cells(0).Value = idDGW Then
                    dg_view.CurrentCell = dg_view(0, xr)
                End If
                xr += 1
            Next

        End Using

    End Sub
    Private Sub caricaDatiReali(ByVal dg_view As DataGridView)

        Dim idDGW As String
        Dim oldRow As Int32 = 0
        Using dt As New DS_clienti.DT_contoreDataTable
            Using ta As New DS_clientiTableAdapters.TA_contore
                ta.FillByClientePeriodo(dt, G_periodo, G_Cli.id)
            End Using
            If dg_view.Rows.Count > 0 Then
                oldRow = dg_view.CurrentRow.Index
                'individua l'ID principale
                idDGW = dg_view(0, oldRow).Value
            End If
            Dim pp As dgCaricaDatiPresenze = New dgCaricaDatiPresenze
            pp.Mese = G_periodo.Split("-").Last
            pp.Anno = G_periodo.Split("-").First
            pp.dtPresenze = dt
            pp.idCantiere = G_Cli.id
            pp.rgDataRow = DirectCast(BSpresenzeweb.Current, DataRowView)
            pp.reale = True
            pp.dataGridAppoggio = dg_view
            Dim risp As Boolean = pp.caricaDati
            Dim xr As Int32 = 0
            For Each riga As DataGridViewRow In dg_view.Rows
                If riga.Cells(0).Value = idDGW Then
                    dg_view.CurrentCell = dg_view(0, xr)
                End If
                xr += 1
            Next

        End Using

    End Sub

    Private Sub CambiaTab_Tabindex(sender As Object, e As EventArgs) Handles TB_elenchi.SelectedIndexChanged
        If TB_elenchi.SelectedTab.Name = tb_grigliapresenze.Name Then
            AggiornaValoriPresenze()
        End If
    End Sub

    'Private Sub btnCaricaReali_Click(sender As Object, e As EventArgs) Handles btnCaricaReali.Click
    '    AggiornaValoriPresenze()
    'End Sub


    Private Sub dgwPresenzeTimbrate_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwPresenzeTimbrate.CellContentClick

        'Apre Form modifica delle presenze Remote
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            Dim sGiorno, sDettaglio As String
            sGiorno = tmpDG.Columns(e.ColumnIndex).HeaderText

            Dim Mese As Integer = G_periodo.Split("-").Last
            Dim Anno As Integer = G_periodo.Split("-").First
            Dim giorno As String = sGiorno.Substring(1, 3).Trim

            Dim data As String
            If eNumerico(giorno) Then
                data = DateSerial(Anno, Mese, giorno).ToShortDateString
                sDettaglio = tmpDG(0, e.RowIndex).Tag
                Using dt As New DS_clienti.DT_presenzeWEBDataTable
                    Using ta As New DS_clientiTableAdapters.TA_presenzeWEB
                        ta.FillByDettaglioGiorno(dt, sDettaglio, data)
                        Dim xDT As DataTable
                        Dim Clas As dgCaricaDatiPresenze = New dgCaricaDatiPresenze
                        Clas.remota = True
                        xDT = Clas.CreaDTTotali(dt)
                        Dim d As New frmElencoPresenzeInserite(xDT)
                        d.ShowDialog()
                    End Using
                End Using
            Else
                Return
            End If

        End If
    End Sub

    Private Sub dgwPresenzeReali_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwPresenzeReali.CellContentClick
        'Apre Form modifica delle presenze Remote
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        If e.RowIndex > 0 And e.ColumnIndex > 0 Then
            Dim sGiorno, sDettaglio As String
            sGiorno = tmpDG.Columns(e.ColumnIndex).HeaderText

            Dim Mese As Integer = G_periodo.Split("-").Last
            Dim Anno As Integer = G_periodo.Split("-").First
            Dim Giorno As Integer = sGiorno.Substring(1, 3)
            Dim data As String = DateSerial(Anno, Mese, Giorno).ToShortDateString
            sDettaglio = tmpDG(0, e.RowIndex).Tag
            Using dt As New DS_clienti.DT_contoreDataTable
                Using ta As New DS_clientiTableAdapters.TA_contore
                    ta.FillByDettaglioGiorno(dt, sDettaglio, data)
                    Dim xDT As DataTable
                    Dim Clas As dgCaricaDatiPresenze = New dgCaricaDatiPresenze
                    Clas.reale = True
                    xDT = Clas.CreaDTTotali(dt)
                    Dim d As New frmElencoPresenzeInserite(xDT)
                    d.ShowDialog()
                End Using
            End Using
        End If
    End Sub
    Private Function eNumerico(ByVal Expression As Object) As Boolean
        Dim isNum As Boolean
        Dim retNum As Double
        isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, retNum)
        Return isNum
    End Function

End Class