<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAggiungeAziendaAutofattura
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAggiungeAziendaAutofattura))
        Me.dgwAzienda = New System.Windows.Forms.DataGridView()
        Me.dgwcidAzienda = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcragionesociale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsAzienda = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_FE = New PoP2.Comuni.DS_FE()
        Me.rbsFatturaAutofattura = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwFatturaAutofattura = New System.Windows.Forms.DataGridView()
        Me.dgwcIDfattura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcNumeroFattura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsPagamenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_fattura = New PoP2.Comuni.DS_fattura()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rbsFatturaRigheAutofattura = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwFatturaRigheAutofattura = New System.Windows.Forms.DataGridView()
        Me.dgwcIDrighe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcDescrizioneRiga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwccfa_rc = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsIva = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DT_v_ordiniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.ttxRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TA_azienda = New PoP2.Comuni.DS_FETableAdapters.TA_azienda()
        Me.TableAdapterManager = New PoP2.Comuni.DS_FETableAdapters.TableAdapterManager()
        Me.TaFatturaAutofattura = New PoP2.Comuni.DS_FETableAdapters.taFatturaAutofattura()
        Me.TaFatturaRigheAutofattura = New PoP2.Comuni.DS_FETableAdapters.taFatturaRigheAutofattura()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DtFatturaCodiciTDBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_pagamenti = New PoP2.Comuni.DS_fatturaTableAdapters.TA_pagamenti()
        Me.TA_iva = New PoP2.Comuni.DS_fatturaTableAdapters.TA_iva()
        Me.TaFatturaCodiciTD = New PoP2.Comuni.DS_fatturaTableAdapters.taFatturaCodiciTD()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgwAzienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAzienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_FE, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbsFatturaAutofattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwFatturaAutofattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPagamenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rbsFatturaRigheAutofattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwFatturaRigheAutofattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsIva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_v_ordiniBindingNavigator.SuspendLayout()
        CType(Me.DtFatturaCodiciTDBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgwAzienda
        '
        Me.dgwAzienda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwAzienda.AutoGenerateColumns = False
        Me.dgwAzienda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwAzienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAzienda.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcidAzienda, Me.dgwcragionesociale, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn18})
        Me.dgwAzienda.DataSource = Me.bsAzienda
        Me.dgwAzienda.Location = New System.Drawing.Point(12, 12)
        Me.dgwAzienda.Name = "dgwAzienda"
        Me.dgwAzienda.Size = New System.Drawing.Size(1288, 251)
        Me.dgwAzienda.TabIndex = 0
        '
        'dgwcidAzienda
        '
        Me.dgwcidAzienda.DataPropertyName = "id"
        Me.dgwcidAzienda.FillWeight = 20.0!
        Me.dgwcidAzienda.HeaderText = "id"
        Me.dgwcidAzienda.Name = "dgwcidAzienda"
        '
        'dgwcragionesociale
        '
        Me.dgwcragionesociale.DataPropertyName = "ragione_sociale"
        Me.dgwcragionesociale.HeaderText = "ragione sociale"
        Me.dgwcragionesociale.Name = "dgwcragionesociale"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "indirizzo_leg"
        Me.DataGridViewTextBoxColumn3.HeaderText = "indirizzo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "localita_leg"
        Me.DataGridViewTextBoxColumn4.HeaderText = "localita"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cap_leg"
        Me.DataGridViewTextBoxColumn5.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "cap"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "provincia_leg"
        Me.DataGridViewTextBoxColumn6.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "provincia"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "partita_IVA"
        Me.DataGridViewTextBoxColumn13.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "partita IVA"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "codicefiscale"
        Me.DataGridViewTextBoxColumn15.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "codice fiscale"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Nazione"
        Me.DataGridViewTextBoxColumn18.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Nazione"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'bsAzienda
        '
        Me.bsAzienda.DataMember = "DT_azienda"
        Me.bsAzienda.DataSource = Me.DS_FE
        '
        'DS_FE
        '
        Me.DS_FE.DataSetName = "DS_FE"
        Me.DS_FE.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rbsFatturaAutofattura
        '
        Me.rbsFatturaAutofattura.DataMember = "DT_azienda_dtFatturaAutofattura"
        Me.rbsFatturaAutofattura.DataSource = Me.bsAzienda
        '
        'dgwFatturaAutofattura
        '
        Me.dgwFatturaAutofattura.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwFatturaAutofattura.AutoGenerateColumns = False
        Me.dgwFatturaAutofattura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwFatturaAutofattura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwFatturaAutofattura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcIDfattura, Me.DataGridViewTextBoxColumn46, Me.dgwcNumeroFattura, Me.DataGridViewTextBoxColumn47, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn44, Me.DataGridViewTextBoxColumn45, Me.DataGridViewTextBoxColumn37})
        Me.dgwFatturaAutofattura.DataSource = Me.rbsFatturaAutofattura
        Me.dgwFatturaAutofattura.Location = New System.Drawing.Point(12, 268)
        Me.dgwFatturaAutofattura.Name = "dgwFatturaAutofattura"
        Me.dgwFatturaAutofattura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwFatturaAutofattura.Size = New System.Drawing.Size(1288, 221)
        Me.dgwFatturaAutofattura.TabIndex = 1
        '
        'dgwcIDfattura
        '
        Me.dgwcIDfattura.DataPropertyName = "id"
        Me.dgwcIDfattura.HeaderText = "id"
        Me.dgwcIDfattura.Name = "dgwcIDfattura"
        Me.dgwcIDfattura.Visible = False
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "datainvio"
        Me.DataGridViewTextBoxColumn46.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn46.HeaderText = "datainvio"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'dgwcNumeroFattura
        '
        Me.dgwcNumeroFattura.DataPropertyName = "fat_num_da"
        Me.dgwcNumeroFattura.FillWeight = 50.0!
        Me.dgwcNumeroFattura.HeaderText = "numero"
        Me.dgwcNumeroFattura.Name = "dgwcNumeroFattura"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn47.HeaderText = "note"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        Me.DataGridViewTextBoxColumn47.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "fat_data"
        Me.DataGridViewTextBoxColumn30.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn30.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "fat_paga"
        Me.DataGridViewTextBoxColumn33.FalseValue = "0"
        Me.DataGridViewTextBoxColumn33.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn33.HeaderText = "Pagata"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn33.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn33.TrueValue = "1"
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "fat_scad"
        Me.DataGridViewTextBoxColumn32.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn32.HeaderText = "Scadenza"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "fat_pa_dat"
        Me.DataGridViewTextBoxColumn35.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn35.HeaderText = "Data Pag"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "fat_cod_paga"
        Me.DataGridViewTextBoxColumn44.DataSource = Me.bsPagamenti
        Me.DataGridViewTextBoxColumn44.DisplayMember = "des"
        Me.DataGridViewTextBoxColumn44.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn44.HeaderText = "pagamento"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        Me.DataGridViewTextBoxColumn44.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn44.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn44.ValueMember = "id"
        '
        'bsPagamenti
        '
        Me.bsPagamenti.DataMember = "DT_pagamenti"
        Me.bsPagamenti.DataSource = Me.DS_fattura
        '
        'DS_fattura
        '
        Me.DS_fattura.DataSetName = "DS_fattura"
        Me.DS_fattura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "fat_nc"
        Me.DataGridViewTextBoxColumn45.FalseValue = "0"
        Me.DataGridViewTextBoxColumn45.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn45.HeaderText = "NC"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        Me.DataGridViewTextBoxColumn45.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn45.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn45.TrueValue = "1"
        Me.DataGridViewTextBoxColumn45.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "fat_pa_des"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Desc Pag"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'rbsFatturaRigheAutofattura
        '
        Me.rbsFatturaRigheAutofattura.DataMember = "dtFatturaAutofattura_dtFatturaRigheAutofattura"
        Me.rbsFatturaRigheAutofattura.DataSource = Me.rbsFatturaAutofattura
        '
        'dgwFatturaRigheAutofattura
        '
        Me.dgwFatturaRigheAutofattura.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwFatturaRigheAutofattura.AutoGenerateColumns = False
        Me.dgwFatturaRigheAutofattura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwFatturaRigheAutofattura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwFatturaRigheAutofattura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcIDrighe, Me.DataGridViewTextBoxColumn48, Me.DataGridViewTextBoxColumn49, Me.dgwcDescrizioneRiga, Me.DataGridViewTextBoxColumn51, Me.DataGridViewTextBoxColumn52, Me.DataGridViewTextBoxColumn53, Me.dgwccfa_rc, Me.DataGridViewTextBoxColumn54})
        Me.dgwFatturaRigheAutofattura.DataSource = Me.rbsFatturaRigheAutofattura
        Me.dgwFatturaRigheAutofattura.Location = New System.Drawing.Point(12, 494)
        Me.dgwFatturaRigheAutofattura.Name = "dgwFatturaRigheAutofattura"
        Me.dgwFatturaRigheAutofattura.Size = New System.Drawing.Size(1288, 155)
        Me.dgwFatturaRigheAutofattura.TabIndex = 2
        '
        'dgwcIDrighe
        '
        Me.dgwcIDrighe.DataPropertyName = "id"
        Me.dgwcIDrighe.HeaderText = "id"
        Me.dgwcIDrighe.Name = "dgwcIDrighe"
        Me.dgwcIDrighe.Visible = False
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "ordine"
        Me.DataGridViewTextBoxColumn48.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn48.HeaderText = "sort"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "cfa_fa_num"
        Me.DataGridViewTextBoxColumn49.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn49.HeaderText = "numero"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        Me.DataGridViewTextBoxColumn49.Visible = False
        '
        'dgwcDescrizioneRiga
        '
        Me.dgwcDescrizioneRiga.DataPropertyName = "cfa_des"
        Me.dgwcDescrizioneRiga.FillWeight = 60.0!
        Me.dgwcDescrizioneRiga.HeaderText = "Descrizione"
        Me.dgwcDescrizioneRiga.Name = "dgwcDescrizioneRiga"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "cfa_quanti"
        Me.DataGridViewTextBoxColumn51.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn51.HeaderText = "q.tà"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "cfa_prezzo"
        Me.DataGridViewTextBoxColumn52.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn52.HeaderText = "Prezzo"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        Me.DataGridViewTextBoxColumn52.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "cfa_sconto"
        Me.DataGridViewTextBoxColumn53.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn53.HeaderText = "Sconto"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'dgwccfa_rc
        '
        Me.dgwccfa_rc.DataPropertyName = "cfa_rc"
        Me.dgwccfa_rc.DataSource = Me.bsIva
        Me.dgwccfa_rc.DisplayMember = "nome"
        Me.dgwccfa_rc.HeaderText = "Iva"
        Me.dgwccfa_rc.Name = "dgwccfa_rc"
        Me.dgwccfa_rc.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwccfa_rc.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgwccfa_rc.ValueMember = "codiceiva"
        '
        'bsIva
        '
        Me.bsIva.DataMember = "DT_iva"
        Me.bsIva.DataSource = Me.DS_fattura
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "cfa_iva"
        Me.DataGridViewTextBoxColumn54.HeaderText = "iva"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn54.Visible = False
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "fat_data"
        Me.DataGridViewTextBoxColumn28.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn28.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        Me.DataGridViewTextBoxColumn28.Width = 192
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn43.HeaderText = "note"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        Me.DataGridViewTextBoxColumn43.Width = 5
        '
        'DT_v_ordiniBindingNavigator
        '
        Me.DT_v_ordiniBindingNavigator.AddNewItem = Nothing
        Me.DT_v_ordiniBindingNavigator.AutoSize = False
        Me.DT_v_ordiniBindingNavigator.BindingSource = Me.bsAzienda
        Me.DT_v_ordiniBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DT_v_ordiniBindingNavigator.DeleteItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_v_ordiniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ttxRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator1, Me.TTPB})
        Me.DT_v_ordiniBindingNavigator.Location = New System.Drawing.Point(0, 713)
        Me.DT_v_ordiniBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_v_ordiniBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_v_ordiniBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_v_ordiniBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_v_ordiniBindingNavigator.Name = "DT_v_ordiniBindingNavigator"
        Me.DT_v_ordiniBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_v_ordiniBindingNavigator.Size = New System.Drawing.Size(1320, 80)
        Me.DT_v_ordiniBindingNavigator.TabIndex = 120
        Me.DT_v_ordiniBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 77)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'ttxRicerca
        '
        Me.ttxRicerca.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.ttxRicerca.Name = "ttxRicerca"
        Me.ttxRicerca.Size = New System.Drawing.Size(150, 80)
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.AutoSize = False
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(50, 40)
        Me.BindingNavigatorMoveFirstItem.Text = "Inizio"
        Me.BindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.AutoSize = False
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(50, 40)
        Me.BindingNavigatorMovePreviousItem.Text = "Indietro"
        Me.BindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 80)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 33)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 80)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.AutoSize = False
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(50, 40)
        Me.BindingNavigatorMoveNextItem.Text = "Avanti"
        Me.BindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.AutoSize = False
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(50, 40)
        Me.BindingNavigatorMoveLastItem.Text = "Fine"
        Me.BindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 80)
        '
        'TTBTTermina
        '
        Me.TTBTTermina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TTBTTermina.AutoSize = False
        Me.TTBTTermina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.TTBTTermina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTTermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTTermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTTermina.Name = "TTBTTermina"
        Me.TTBTTermina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTTermina.Text = "Termina"
        Me.TTBTTermina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTTermina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTStampa
        '
        Me.TTBTStampa.AutoSize = False
        Me.TTBTStampa.Image = CType(resources.GetObject("TTBTStampa.Image"), System.Drawing.Image)
        Me.TTBTStampa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTStampa.Name = "TTBTStampa"
        Me.TTBTStampa.Size = New System.Drawing.Size(50, 70)
        Me.TTBTStampa.Text = "Stampa"
        Me.TTBTStampa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTStampa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 80)
        '
        'TTPB
        '
        Me.TTPB.Name = "TTPB"
        Me.TTPB.Size = New System.Drawing.Size(100, 77)
        '
        'TA_azienda
        '
        Me.TA_azienda.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_FETableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TaFatturaAutofattura
        '
        Me.TaFatturaAutofattura.ClearBeforeFill = True
        '
        'TaFatturaRigheAutofattura
        '
        Me.TaFatturaRigheAutofattura.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.DtFatturaCodiciTDBindingSource
        Me.ComboBox1.DisplayMember = "descrizione"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(127, 674)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(376, 24)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "valore"
        '
        'DtFatturaCodiciTDBindingSource
        '
        Me.DtFatturaCodiciTDBindingSource.DataMember = "dtFatturaCodiciTD"
        Me.DtFatturaCodiciTDBindingSource.DataSource = Me.DS_fattura
        '
        'TA_pagamenti
        '
        Me.TA_pagamenti.ClearBeforeFill = True
        '
        'TA_iva
        '
        Me.TA_iva.ClearBeforeFill = True
        '
        'TaFatturaCodiciTD
        '
        Me.TaFatturaCodiciTD.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(21, 677)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 17)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Tipo di Fattura"
        '
        'frmAggiungeAziendaAutofattura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1320, 793)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.DT_v_ordiniBindingNavigator)
        Me.Controls.Add(Me.dgwFatturaRigheAutofattura)
        Me.Controls.Add(Me.dgwFatturaAutofattura)
        Me.Controls.Add(Me.dgwAzienda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmAggiungeAziendaAutofattura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Autofatturazione"
        CType(Me.dgwAzienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAzienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_FE, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbsFatturaAutofattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwFatturaAutofattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPagamenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rbsFatturaRigheAutofattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwFatturaRigheAutofattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsIva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_v_ordiniBindingNavigator.ResumeLayout(False)
        Me.DT_v_ordiniBindingNavigator.PerformLayout()
        CType(Me.DtFatturaCodiciTDBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_FE As DS_FE
    Friend WithEvents bsAzienda As BindingSource
    Friend WithEvents TA_azienda As DS_FETableAdapters.TA_azienda
    Friend WithEvents TableAdapterManager As DS_FETableAdapters.TableAdapterManager
    Friend WithEvents dgwAzienda As DataGridView
    Friend WithEvents bsPagamenti As BindingSource
    Friend WithEvents TA_pagamenti As DS_fatturaTableAdapters.TA_pagamenti
    Friend WithEvents bsIva As BindingSource
    Friend WithEvents TA_iva As DS_fatturaTableAdapters.TA_iva
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewComboBoxColumn
    Friend WithEvents DS_fattura As DS_fattura
    Friend WithEvents rbsFatturaAutofattura As BindingSource
    Friend WithEvents TaFatturaAutofattura As DS_FETableAdapters.taFatturaAutofattura
    Friend WithEvents dgwFatturaAutofattura As DataGridView
    Friend WithEvents rbsFatturaRigheAutofattura As BindingSource
    Friend WithEvents TaFatturaRigheAutofattura As DS_FETableAdapters.taFatturaRigheAutofattura
    Friend WithEvents dgwFatturaRigheAutofattura As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents DT_v_ordiniBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TTPB As ToolStripProgressBar
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents dgwcIDfattura As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcNumeroFattura As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcIDrighe As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDescrizioneRiga As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents dgwccfa_rc As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcidAzienda As DataGridViewTextBoxColumn
    Friend WithEvents dgwcragionesociale As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DtFatturaCodiciTDBindingSource As BindingSource
    Friend WithEvents TaFatturaCodiciTD As DS_fatturaTableAdapters.taFatturaCodiciTD
    Friend WithEvents Label1 As Label
    Friend WithEvents ttxRicerca As ToolStripTextBox
End Class
