<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_genera_fatture
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_genera_fatture))
        Me.DG_generatore = New System.Windows.Forms.DataGridView()
        Me.fatturo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_societa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_destinatari_ID_CLI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_id_dest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_riga_fattura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.condomino = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_canone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fatturabile = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_tipo_intervento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrizione_intervento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.attiva = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.numero_fatturo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_generatore_fatture = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_generatore_fatture = New PoP2.Comuni.DS_generatore_fatture()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DG_fatturabili = New System.Windows.Forms.DataGridView()
        Me.DG_clienti_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_societa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.R_fattura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_clienti_fatturabili = New System.Windows.Forms.BindingSource(Me.components)
        Me.LB_tipo_servizio = New System.Windows.Forms.ListBox()
        Me.LB_numero_fastture = New System.Windows.Forms.Label()
        Me.LB_titolo = New System.Windows.Forms.Label()
        Me.TA_generatore_fatture = New PoP2.Comuni.DS_generatore_fattureTableAdapters.TA_generatore_fatture()
        Me.TableAdapterManager = New PoP2.Comuni.DS_generatore_fattureTableAdapters.TableAdapterManager()
        Me.BS_tipo_servizio = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_tipo_servizio = New PoP2.Comuni.DS_generatore_fattureTableAdapters.TA_tipo_servizio()
        Me.TA_clienti_fatturabili = New PoP2.Comuni.DS_generatore_fattureTableAdapters.TA_clienti_fatturabili()
        Me.BS_iva_codici = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_iva_codici = New PoP2.Comuni.DS_generatore_fattureTableAdapters.TA_iva_codici()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BT_deseleziona = New System.Windows.Forms.Button()
        Me.BT_seleziona = New System.Windows.Forms.Button()
        Me.BT_caricaOrdini = New System.Windows.Forms.Button()
        Me.elenco_gen_fatture = New System.Windows.Forms.TreeView()
        Me.TS_informazioni = New System.Windows.Forms.ToolStrip()
        Me.TS_BT_termina = New System.Windows.Forms.ToolStripButton()
        Me.TT_CB_anno = New System.Windows.Forms.ToolStripComboBox()
        Me.TT_CB_mese = New System.Windows.Forms.ToolStripComboBox()
        Me.TS_PB_genera = New System.Windows.Forms.ToolStripProgressBar()
        Me.TS_TX_ricerca = New System.Windows.Forms.ToolStripTextBox()
        Me.TS_BT_cerca = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TS_LB_genera = New System.Windows.Forms.ToolStripLabel()
        Me.TS_BT_selezione = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TV_ordini = New System.Windows.Forms.TreeView()
        Me.PB_ordini = New System.Windows.Forms.ProgressBar()
        Me.BS_ordini = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_ordini = New PoP2.Comuni.DS_generatore_fattureTableAdapters.TA_ordini()
        CType(Me.DG_generatore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_generatore_fatture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_generatore_fatture, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_fatturabili, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti_fatturabili, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_tipo_servizio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_iva_codici, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TS_informazioni.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.BS_ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_generatore
        '
        Me.DG_generatore.AllowUserToAddRows = False
        Me.DG_generatore.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DG_generatore.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_generatore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_generatore.AutoGenerateColumns = False
        Me.DG_generatore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_generatore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_generatore.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.fatturo, Me.COL_societa, Me.DG_destinatari_ID_CLI, Me.COL_id_dest, Me.COL_riga_fattura, Me.pagamento, Me.condomino, Me.COL_canone, Me.num, Me.fatturabile, Me.id_tipo_intervento, Me.descrizione_intervento, Me.attiva, Me.numero_fatturo})
        Me.DG_generatore.DataSource = Me.BS_generatore_fatture
        Me.DG_generatore.Location = New System.Drawing.Point(12, 472)
        Me.DG_generatore.Name = "DG_generatore"
        Me.DG_generatore.RowHeadersWidth = 10
        Me.DG_generatore.Size = New System.Drawing.Size(144, 61)
        Me.DG_generatore.TabIndex = 1
        Me.DG_generatore.Visible = False
        '
        'fatturo
        '
        Me.fatturo.DataPropertyName = "des"
        Me.fatturo.FillWeight = 5.0!
        Me.fatturo.HeaderText = "des"
        Me.fatturo.Name = "fatturo"
        Me.fatturo.Visible = False
        '
        'COL_societa
        '
        Me.COL_societa.DataPropertyName = "societa"
        Me.COL_societa.FillWeight = 40.0!
        Me.COL_societa.HeaderText = "societa"
        Me.COL_societa.Name = "COL_societa"
        '
        'DG_destinatari_ID_CLI
        '
        Me.DG_destinatari_ID_CLI.DataPropertyName = "id_terminale"
        Me.DG_destinatari_ID_CLI.FillWeight = 5.0!
        Me.DG_destinatari_ID_CLI.HeaderText = "id_terminale"
        Me.DG_destinatari_ID_CLI.Name = "DG_destinatari_ID_CLI"
        Me.DG_destinatari_ID_CLI.Visible = False
        '
        'COL_id_dest
        '
        Me.COL_id_dest.DataPropertyName = "id_dest"
        Me.COL_id_dest.FillWeight = 5.0!
        Me.COL_id_dest.HeaderText = "id_dest"
        Me.COL_id_dest.Name = "COL_id_dest"
        Me.COL_id_dest.Visible = False
        '
        'COL_riga_fattura
        '
        Me.COL_riga_fattura.DataPropertyName = "riga_fattura"
        Me.COL_riga_fattura.FillWeight = 30.0!
        Me.COL_riga_fattura.HeaderText = "riga_fattura"
        Me.COL_riga_fattura.Name = "COL_riga_fattura"
        '
        'pagamento
        '
        Me.pagamento.DataPropertyName = "pagamento"
        Me.pagamento.FillWeight = 30.0!
        Me.pagamento.HeaderText = "pagamento"
        Me.pagamento.Name = "pagamento"
        Me.pagamento.Visible = False
        '
        'condomino
        '
        Me.condomino.DataPropertyName = "condomino"
        Me.condomino.FillWeight = 5.0!
        Me.condomino.HeaderText = "C"
        Me.condomino.Name = "condomino"
        '
        'COL_canone
        '
        Me.COL_canone.DataPropertyName = "canone"
        Me.COL_canone.FillWeight = 15.0!
        Me.COL_canone.HeaderText = "canone"
        Me.COL_canone.Name = "COL_canone"
        '
        'num
        '
        Me.num.DataPropertyName = "num"
        Me.num.FillWeight = 5.0!
        Me.num.HeaderText = "num"
        Me.num.Name = "num"
        Me.num.Visible = False
        '
        'fatturabile
        '
        Me.fatturabile.DataPropertyName = "fatturabile"
        Me.fatturabile.FillWeight = 5.0!
        Me.fatturabile.HeaderText = "fatturabile"
        Me.fatturabile.Name = "fatturabile"
        Me.fatturabile.Visible = False
        '
        'id_tipo_intervento
        '
        Me.id_tipo_intervento.DataPropertyName = "extra"
        Me.id_tipo_intervento.FillWeight = 5.0!
        Me.id_tipo_intervento.HeaderText = "extra"
        Me.id_tipo_intervento.Name = "id_tipo_intervento"
        Me.id_tipo_intervento.Visible = False
        '
        'descrizione_intervento
        '
        Me.descrizione_intervento.DataPropertyName = "descrizione"
        Me.descrizione_intervento.FillWeight = 15.0!
        Me.descrizione_intervento.HeaderText = "descrizione"
        Me.descrizione_intervento.Name = "descrizione_intervento"
        '
        'attiva
        '
        Me.attiva.FillWeight = 5.0!
        Me.attiva.HeaderText = "OK"
        Me.attiva.Name = "attiva"
        Me.attiva.ToolTipText = "Attivo la fatturazione"
        '
        'numero_fatturo
        '
        Me.numero_fatturo.FillWeight = 5.0!
        Me.numero_fatturo.HeaderText = "n°"
        Me.numero_fatturo.Name = "numero_fatturo"
        '
        'BS_generatore_fatture
        '
        Me.BS_generatore_fatture.DataMember = "DT_generatore_fatture"
        Me.BS_generatore_fatture.DataSource = Me.DS_generatore_fatture
        '
        'DS_generatore_fatture
        '
        Me.DS_generatore_fatture.DataSetName = "DS_generatore_fatture"
        Me.DS_generatore_fatture.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "omino_cerca.png")
        Me.ImageList1.Images.SetKeyName(1, "omino_OK.png")
        Me.ImageList1.Images.SetKeyName(2, "omino_spegne.png")
        Me.ImageList1.Images.SetKeyName(3, "omino_carta.png")
        '
        'DG_fatturabili
        '
        Me.DG_fatturabili.AllowUserToAddRows = False
        Me.DG_fatturabili.AllowUserToDeleteRows = False
        Me.DG_fatturabili.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_fatturabili.AutoGenerateColumns = False
        Me.DG_fatturabili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_fatturabili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_fatturabili.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DG_clienti_ID, Me.C_societa, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.R_fattura})
        Me.DG_fatturabili.DataSource = Me.BS_clienti_fatturabili
        Me.DG_fatturabili.Location = New System.Drawing.Point(3, 33)
        Me.DG_fatturabili.Name = "DG_fatturabili"
        Me.DG_fatturabili.ReadOnly = True
        Me.DG_fatturabili.RowHeadersWidth = 10
        Me.DG_fatturabili.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_fatturabili.Size = New System.Drawing.Size(537, 265)
        Me.DG_fatturabili.TabIndex = 6
        '
        'DG_clienti_ID
        '
        Me.DG_clienti_ID.DataPropertyName = "id"
        Me.DG_clienti_ID.HeaderText = "id"
        Me.DG_clienti_ID.Name = "DG_clienti_ID"
        Me.DG_clienti_ID.ReadOnly = True
        Me.DG_clienti_ID.Visible = False
        '
        'C_societa
        '
        Me.C_societa.DataPropertyName = "societa"
        Me.C_societa.FillWeight = 40.0!
        Me.C_societa.HeaderText = "societa"
        Me.C_societa.Name = "C_societa"
        Me.C_societa.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "address"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "postalcode"
        Me.DataGridViewTextBoxColumn4.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "postalcode"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "city"
        Me.DataGridViewTextBoxColumn5.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "city"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "region"
        Me.DataGridViewTextBoxColumn6.FillWeight = 5.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "region"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Visible = False
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "state"
        Me.DataGridViewTextBoxColumn7.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "state"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "email_name"
        Me.DataGridViewTextBoxColumn8.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "email_name"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "partitaiva"
        Me.DataGridViewTextBoxColumn9.FillWeight = 15.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "partitaiva"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "pagamento"
        Me.DataGridViewTextBoxColumn10.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "pagamento"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "des_pagamento"
        Me.DataGridViewTextBoxColumn11.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "des_pagamento"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "bancaappog"
        Me.DataGridViewTextBoxColumn12.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "bancaappog"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "contabilita"
        Me.DataGridViewTextBoxColumn13.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "contabilita"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "attivo"
        Me.DataGridViewTextBoxColumn14.FillWeight = 5.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "ATT"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn14.ToolTipText = "Se il cliente é attivo"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "budget"
        Me.DataGridViewTextBoxColumn15.FillWeight = 5.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "BDG"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn15.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn15.ToolTipText = "Se il cliente é solo finanziario"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "condomino"
        Me.DataGridViewTextBoxColumn16.FillWeight = 5.0!
        Me.DataGridViewTextBoxColumn16.HeaderText = "CON"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn16.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn16.ToolTipText = "Se é un condominio"
        '
        'R_fattura
        '
        Me.R_fattura.FillWeight = 5.0!
        Me.R_fattura.HeaderText = "X"
        Me.R_fattura.Name = "R_fattura"
        Me.R_fattura.ReadOnly = True
        Me.R_fattura.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.R_fattura.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'BS_clienti_fatturabili
        '
        Me.BS_clienti_fatturabili.DataMember = "DT_clienti_fatturabili"
        Me.BS_clienti_fatturabili.DataSource = Me.DS_generatore_fatture
        '
        'LB_tipo_servizio
        '
        Me.LB_tipo_servizio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_tipo_servizio.FormattingEnabled = True
        Me.LB_tipo_servizio.Location = New System.Drawing.Point(622, 33)
        Me.LB_tipo_servizio.Name = "LB_tipo_servizio"
        Me.LB_tipo_servizio.Size = New System.Drawing.Size(329, 264)
        Me.LB_tipo_servizio.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.LB_tipo_servizio, "Seleziona il tipo di fattura da preparare")
        '
        'LB_numero_fastture
        '
        Me.LB_numero_fastture.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_numero_fastture.AutoSize = True
        Me.LB_numero_fastture.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LB_numero_fastture.Location = New System.Drawing.Point(3, 311)
        Me.LB_numero_fastture.Name = "LB_numero_fastture"
        Me.LB_numero_fastture.Size = New System.Drawing.Size(537, 20)
        Me.LB_numero_fastture.TabIndex = 9
        Me.LB_numero_fastture.Text = "Elenca le fatture generabili"
        '
        'LB_titolo
        '
        Me.LB_titolo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_titolo.AutoSize = True
        Me.LB_titolo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LB_titolo.Location = New System.Drawing.Point(622, 10)
        Me.LB_titolo.Name = "LB_titolo"
        Me.LB_titolo.Size = New System.Drawing.Size(329, 20)
        Me.LB_titolo.TabIndex = 11
        Me.LB_titolo.Text = "Tipologia di servizio"
        '
        'TA_generatore_fatture
        '
        Me.TA_generatore_fatture.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.TA_righe_fatture = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_generatore_fattureTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BS_tipo_servizio
        '
        Me.BS_tipo_servizio.DataMember = "DT_tipo_servizio"
        Me.BS_tipo_servizio.DataSource = Me.DS_generatore_fatture
        '
        'TA_tipo_servizio
        '
        Me.TA_tipo_servizio.ClearBeforeFill = True
        '
        'TA_clienti_fatturabili
        '
        Me.TA_clienti_fatturabili.ClearBeforeFill = True
        '
        'BS_iva_codici
        '
        Me.BS_iva_codici.DataSource = Me.DS_generatore_fatture
        Me.BS_iva_codici.Position = 0
        '
        'TA_iva_codici
        '
        Me.TA_iva_codici.ClearBeforeFill = True
        '
        'BT_deseleziona
        '
        Me.BT_deseleziona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_deseleziona.ImageKey = "omino_spegne.png"
        Me.BT_deseleziona.ImageList = Me.ImageList1
        Me.BT_deseleziona.Location = New System.Drawing.Point(3, 112)
        Me.BT_deseleziona.Name = "BT_deseleziona"
        Me.BT_deseleziona.Size = New System.Drawing.Size(64, 70)
        Me.BT_deseleziona.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.BT_deseleziona, "Deseleziona tutti i clienti")
        Me.BT_deseleziona.UseVisualStyleBackColor = True
        '
        'BT_seleziona
        '
        Me.BT_seleziona.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_seleziona.ImageKey = "omino_OK.png"
        Me.BT_seleziona.ImageList = Me.ImageList1
        Me.BT_seleziona.Location = New System.Drawing.Point(3, 23)
        Me.BT_seleziona.Name = "BT_seleziona"
        Me.BT_seleziona.Size = New System.Drawing.Size(64, 64)
        Me.BT_seleziona.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.BT_seleziona, "Seleziona tutti i clienti")
        Me.BT_seleziona.UseVisualStyleBackColor = True
        '
        'BT_caricaOrdini
        '
        Me.BT_caricaOrdini.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_caricaOrdini.ImageKey = "omino_OK.png"
        Me.BT_caricaOrdini.ImageList = Me.ImageList1
        Me.BT_caricaOrdini.Location = New System.Drawing.Point(3, 29)
        Me.BT_caricaOrdini.Name = "BT_caricaOrdini"
        Me.BT_caricaOrdini.Size = New System.Drawing.Size(64, 86)
        Me.BT_caricaOrdini.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.BT_caricaOrdini, "Ricarica ordini Materiale")
        Me.BT_caricaOrdini.UseVisualStyleBackColor = True
        '
        'elenco_gen_fatture
        '
        Me.elenco_gen_fatture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.elenco_gen_fatture.Location = New System.Drawing.Point(3, 334)
        Me.elenco_gen_fatture.Name = "elenco_gen_fatture"
        Me.elenco_gen_fatture.Size = New System.Drawing.Size(537, 266)
        Me.elenco_gen_fatture.TabIndex = 13
        '
        'TS_informazioni
        '
        Me.TS_informazioni.AutoSize = False
        Me.TS_informazioni.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TS_informazioni.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.TS_informazioni.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_BT_termina, Me.TT_CB_anno, Me.TT_CB_mese, Me.TS_PB_genera, Me.TS_TX_ricerca, Me.TS_BT_cerca, Me.ToolStripSeparator1, Me.TS_LB_genera, Me.TS_BT_selezione})
        Me.TS_informazioni.Location = New System.Drawing.Point(0, 603)
        Me.TS_informazioni.Name = "TS_informazioni"
        Me.TS_informazioni.Size = New System.Drawing.Size(954, 61)
        Me.TS_informazioni.TabIndex = 19
        Me.TS_informazioni.Text = "ToolStrip1"
        '
        'TS_BT_termina
        '
        Me.TS_BT_termina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TS_BT_termina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_BT_termina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.TS_BT_termina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_BT_termina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_BT_termina.Name = "TS_BT_termina"
        Me.TS_BT_termina.Size = New System.Drawing.Size(52, 58)
        Me.TS_BT_termina.Text = "Termina"
        '
        'TT_CB_anno
        '
        Me.TT_CB_anno.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_anno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_anno.Name = "TT_CB_anno"
        Me.TT_CB_anno.Size = New System.Drawing.Size(121, 61)
        '
        'TT_CB_mese
        '
        Me.TT_CB_mese.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_mese.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_mese.Name = "TT_CB_mese"
        Me.TT_CB_mese.Size = New System.Drawing.Size(121, 61)
        '
        'TS_PB_genera
        '
        Me.TS_PB_genera.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TS_PB_genera.Name = "TS_PB_genera"
        Me.TS_PB_genera.Size = New System.Drawing.Size(200, 58)
        Me.TS_PB_genera.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'TS_TX_ricerca
        '
        Me.TS_TX_ricerca.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TS_TX_ricerca.Name = "TS_TX_ricerca"
        Me.TS_TX_ricerca.Size = New System.Drawing.Size(200, 61)
        Me.TS_TX_ricerca.ToolTipText = "Ricerca il cliente per la fatturazione"
        '
        'TS_BT_cerca
        '
        Me.TS_BT_cerca.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_BT_cerca.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_cerca48x48
        Me.TS_BT_cerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_BT_cerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_BT_cerca.Name = "TS_BT_cerca"
        Me.TS_BT_cerca.Size = New System.Drawing.Size(52, 58)
        Me.TS_BT_cerca.Text = "Cerca"
        Me.TS_BT_cerca.ToolTipText = "Avvia la ricerca"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 61)
        '
        'TS_LB_genera
        '
        Me.TS_LB_genera.Margin = New System.Windows.Forms.Padding(20, 1, 0, 2)
        Me.TS_LB_genera.Name = "TS_LB_genera"
        Me.TS_LB_genera.Size = New System.Drawing.Size(44, 58)
        Me.TS_LB_genera.Text = "Genera"
        '
        'TS_BT_selezione
        '
        Me.TS_BT_selezione.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TS_BT_selezione.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_carta48x48
        Me.TS_BT_selezione.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TS_BT_selezione.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TS_BT_selezione.Name = "TS_BT_selezione"
        Me.TS_BT_selezione.Size = New System.Drawing.Size(52, 58)
        Me.TS_BT_selezione.Text = "Genera"
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(537, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Elenco dei clienti fatturabili"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_fatturabili, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_tipo_servizio, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_titolo, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.elenco_gen_fatture, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_numero_fastture, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 2, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(954, 603)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.BT_deseleziona, 0, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.BT_seleziona, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(546, 33)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.81081!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.83784!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.27027!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(70, 185)
        Me.TableLayoutPanel2.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "De-Seleziona"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Seleziona"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.AutoScroll = True
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BT_caricaOrdini, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label5, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(546, 334)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.81081!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.83784!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.27027!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(70, 243)
        Me.TableLayoutPanel3.TabIndex = 23
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 26)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Cerca Ordini"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.TV_ordini, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.PB_ordini, 0, 1)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(622, 334)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.88288!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.11712!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(329, 266)
        Me.TableLayoutPanel4.TabIndex = 24
        '
        'TV_ordini
        '
        Me.TV_ordini.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TV_ordini.Location = New System.Drawing.Point(3, 3)
        Me.TV_ordini.Name = "TV_ordini"
        Me.TV_ordini.Size = New System.Drawing.Size(323, 214)
        Me.TV_ordini.TabIndex = 22
        '
        'PB_ordini
        '
        Me.PB_ordini.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PB_ordini.Location = New System.Drawing.Point(3, 223)
        Me.PB_ordini.Name = "PB_ordini"
        Me.PB_ordini.Size = New System.Drawing.Size(323, 40)
        Me.PB_ordini.TabIndex = 23
        '
        'BS_ordini
        '
        Me.BS_ordini.DataSource = Me.DS_generatore_fatture
        Me.BS_ordini.Position = 0
        '
        'TA_ordini
        '
        Me.TA_ordini.ClearBeforeFill = True
        '
        'FRM_genera_fatture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(954, 664)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.TS_informazioni)
        Me.Controls.Add(Me.DG_generatore)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_genera_fatture"
        Me.Text = "Generatore di Fatture"
        CType(Me.DG_generatore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_generatore_fatture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_generatore_fatture, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_fatturabili, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti_fatturabili, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_tipo_servizio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_iva_codici, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TS_informazioni.ResumeLayout(False)
        Me.TS_informazioni.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.BS_ordini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_generatore_fatture As DS_generatore_fatture
    Friend WithEvents BS_generatore_fatture As BindingSource
    Friend WithEvents TA_generatore_fatture As DS_generatore_fattureTableAdapters.TA_generatore_fatture
    Friend WithEvents TableAdapterManager As DS_generatore_fattureTableAdapters.TableAdapterManager
    Friend WithEvents DG_generatore As DataGridView
    Friend WithEvents BS_tipo_servizio As BindingSource
    Friend WithEvents TA_tipo_servizio As DS_generatore_fattureTableAdapters.TA_tipo_servizio
    Friend WithEvents BS_clienti_fatturabili As BindingSource
    Friend WithEvents TA_clienti_fatturabili As DS_generatore_fattureTableAdapters.TA_clienti_fatturabili
    Friend WithEvents DG_fatturabili As DataGridView
    Friend WithEvents BT_seleziona As Button
    Friend WithEvents LB_tipo_servizio As ListBox
    Friend WithEvents LB_numero_fastture As Label
    Friend WithEvents LB_titolo As Label
    Friend WithEvents attiva As DataGridViewCheckBoxColumn
    Friend WithEvents numero_fatturo As DataGridViewTextBoxColumn
    Friend WithEvents fatturo As DataGridViewTextBoxColumn
    Friend WithEvents COL_societa As DataGridViewTextBoxColumn
    Friend WithEvents DG_destinatari_ID_CLI As DataGridViewTextBoxColumn
    Friend WithEvents COL_id_dest As DataGridViewTextBoxColumn
    Friend WithEvents COL_riga_fattura As DataGridViewTextBoxColumn
    Friend WithEvents pagamento As DataGridViewTextBoxColumn
    Friend WithEvents condomino As DataGridViewTextBoxColumn
    Friend WithEvents COL_canone As DataGridViewTextBoxColumn
    Friend WithEvents num As DataGridViewTextBoxColumn
    Friend WithEvents fatturabile As DataGridViewTextBoxColumn
    Friend WithEvents id_tipo_intervento As DataGridViewTextBoxColumn
    Friend WithEvents descrizione_intervento As DataGridViewTextBoxColumn
    Friend WithEvents attivo As DataGridViewTextBoxColumn
    Friend WithEvents BS_iva_codici As BindingSource
    Friend WithEvents TA_iva_codici As DS_generatore_fattureTableAdapters.TA_iva_codici
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BT_deseleziona As Button
    Friend WithEvents elenco_gen_fatture As TreeView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents DG_clienti_ID As DataGridViewTextBoxColumn
    Friend WithEvents R_fattura As DataGridViewTextBoxColumn
    Friend WithEvents C_societa As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewCheckBoxColumn
    Friend WithEvents TS_informazioni As ToolStrip
    Friend WithEvents TS_BT_termina As ToolStripButton
    Friend WithEvents TS_PB_genera As ToolStripProgressBar
    Friend WithEvents TS_TX_ricerca As ToolStripTextBox
    Friend WithEvents TS_BT_cerca As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TS_BT_selezione As ToolStripButton
    Friend WithEvents TS_LB_genera As ToolStripLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents TT_CB_anno As ToolStripComboBox
    Friend WithEvents TT_CB_mese As ToolStripComboBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TV_ordini As TreeView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BT_caricaOrdini As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents BS_ordini As BindingSource
    Friend WithEvents TA_ordini As DS_generatore_fattureTableAdapters.TA_ordini
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents PB_ordini As ProgressBar
End Class
