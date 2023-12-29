<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmFattura
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFattura))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DG_fattura = New System.Windows.Forms.DataGridView()
        Me.Col_numero = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_societa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_des = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_114_codicedestinatario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_fattura = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_fattura = New PoP2.Comuni.DS_fattura()
        Me.DG_righe = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_totale = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_fattura_righe = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_v_ordiniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTRicerca = New System.Windows.Forms.ToolStripButton()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTAggiunge = New System.Windows.Forms.ToolStripButton()
        Me.TTBTModifica = New System.Windows.Forms.ToolStripButton()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        Me.TT_CB_anno = New System.Windows.Forms.ToolStripComboBox()
        Me.TT_CB_mese = New System.Windows.Forms.ToolStripComboBox()
        Me.TTPB_stampa = New System.Windows.Forms.ToolStripProgressBar()
        Me.menustampa = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TS_stp_singola = New System.Windows.Forms.ToolStripMenuItem()
        Me.TS_stp_tutte = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TS_elenco_fatture = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Cerca_pos = New System.Windows.Forms.FolderBrowserDialog()
        Me.DT_contoreDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_fatturaContore = New System.Windows.Forms.BindingSource(Me.components)
        Me.DG_ore = New System.Windows.Forms.DataGridView()
        Me.locazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GC_oreTot = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_fatturaContoreTot = New System.Windows.Forms.BindingSource(Me.components)
        Me.LB_resa = New System.Windows.Forms.Label()
        Me.LB_fatturato = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_totale = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_tot_ivato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_fatturaFattura_tot = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_Ore_Periodo = New System.Windows.Forms.DataGridView()
        Me.AnnoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_ore = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_Fatturato_Periodo = New System.Windows.Forms.DataGridView()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImportoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_rese = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_resa = New System.Windows.Forms.Button()
        Me.LB_ore = New System.Windows.Forms.Label()
        Me.TableLayoutPanel8 = New System.Windows.Forms.TableLayoutPanel()
        Me.LB_resaAnno = New System.Windows.Forms.Label()
        Me.LB_totaleOreAnno = New System.Windows.Forms.Label()
        Me.LB_totaleAnno = New System.Windows.Forms.Label()
        Me.LBT_totaleAnno = New System.Windows.Forms.Label()
        Me.LBT_oreAnno = New System.Windows.Forms.Label()
        Me.LBT_reseAnno = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBT_totaleMese = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LBT_oreMese = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LBT_reseMese = New System.Windows.Forms.Label()
        Me.BS_contoreTot = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_contore = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_fattura = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura()
        Me.TableAdapterManager = New PoP2.Comuni.DS_fatturaTableAdapters.TableAdapterManager()
        Me.TA_fattura_tot = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura_tot()
        Me.TA_fattura_righe = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura_righe()
        Me.BS_tiposervizio = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_tiposervizio = New PoP2.Comuni.DS_fatturaTableAdapters.TA_tipo_servizio()
        Me.BS_iva = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_iva = New PoP2.Comuni.DS_fatturaTableAdapters.TA_iva()
        Me.BS_valuta = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_valuta = New PoP2.Comuni.DS_fatturaTableAdapters.TA_valuta()
        Me.BS_clienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_cantieri = New PoP2.Comuni.DS_fatturaTableAdapters.TA_cantieri()
        Me.BS_destinatari = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_destinatari = New PoP2.Comuni.DS_fatturaTableAdapters.TA_destinatari()
        Me.TA_contore = New PoP2.Comuni.DS_fatturaTableAdapters.TA_contore()
        Me.TA_contoreTot = New PoP2.Comuni.DS_fatturaTableAdapters.TA_contoreTot()
        Me.TA_rese = New PoP2.Comuni.DS_fatturaTableAdapters.TA_rese()
        Me.TA_ore = New PoP2.Comuni.DS_fatturaTableAdapters.TA_ore()
        CType(Me.DG_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_righe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_fattura_righe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_v_ordiniBindingNavigator.SuspendLayout()
        Me.menustampa.SuspendLayout()
        CType(Me.DT_contoreDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_fatturaContore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_ore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_fatturaContoreTot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        CType(Me.DG_totale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_fatturaFattura_tot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.DG_Ore_Periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_ore, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.DG_Fatturato_Periodo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_rese, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel8.SuspendLayout()
        CType(Me.BS_contoreTot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_contore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_tiposervizio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_iva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_valuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_destinatari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_fattura
        '
        Me.DG_fattura.AllowUserToAddRows = False
        Me.DG_fattura.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_fattura.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_fattura.AutoGenerateColumns = False
        Me.DG_fattura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_fattura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_fattura.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_numero, Me.C_societa, Me.C_des, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn16, Me.C_114_codicedestinatario})
        Me.DG_fattura.DataSource = Me.BS_fattura
        Me.DG_fattura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_fattura.Location = New System.Drawing.Point(1, 1)
        Me.DG_fattura.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_fattura.Name = "DG_fattura"
        Me.DG_fattura.ReadOnly = True
        Me.DG_fattura.RowHeadersWidth = 4
        Me.DG_fattura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_fattura.Size = New System.Drawing.Size(1256, 269)
        Me.DG_fattura.TabIndex = 1
        '
        'Col_numero
        '
        Me.Col_numero.DataPropertyName = "fat_num_da"
        Me.Col_numero.FillWeight = 50.0!
        Me.Col_numero.HeaderText = "Numero"
        Me.Col_numero.Name = "Col_numero"
        Me.Col_numero.ReadOnly = True
        '
        'C_societa
        '
        Me.C_societa.DataPropertyName = "societa"
        Me.C_societa.HeaderText = "Societa"
        Me.C_societa.Name = "C_societa"
        Me.C_societa.ReadOnly = True
        '
        'C_des
        '
        Me.C_des.DataPropertyName = "des"
        Me.C_des.FillWeight = 70.0!
        Me.C_des.HeaderText = "Pagamento"
        Me.C_des.Name = "C_des"
        Me.C_des.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fat_data"
        Me.DataGridViewTextBoxColumn5.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fat_scad"
        Me.DataGridViewTextBoxColumn6.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Scadenza"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fat_con_l"
        Me.DataGridViewTextBoxColumn10.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "CON"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "fat_nc"
        Me.DataGridViewTextBoxColumn16.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn16.HeaderText = "NC"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'C_114_codicedestinatario
        '
        Me.C_114_codicedestinatario.DataPropertyName = "114_codicedestinatario"
        Me.C_114_codicedestinatario.FillWeight = 40.0!
        Me.C_114_codicedestinatario.HeaderText = "SDI"
        Me.C_114_codicedestinatario.Name = "C_114_codicedestinatario"
        Me.C_114_codicedestinatario.ReadOnly = True
        '
        'BS_fattura
        '
        Me.BS_fattura.DataMember = "DT_fattura"
        Me.BS_fattura.DataSource = Me.DS_fattura
        '
        'DS_fattura
        '
        Me.DS_fattura.DataSetName = "DS_fattura"
        Me.DS_fattura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DG_righe
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_righe.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_righe.AutoGenerateColumns = False
        Me.DG_righe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_righe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_righe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn18, Me.C_totale, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn29})
        Me.DG_righe.DataSource = Me.BS_fattura_righe
        Me.DG_righe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_righe.Location = New System.Drawing.Point(1, 1)
        Me.DG_righe.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_righe.Name = "DG_righe"
        Me.DG_righe.RowHeadersWidth = 4
        Me.DG_righe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_righe.Size = New System.Drawing.Size(934, 180)
        Me.DG_righe.TabIndex = 3
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "ordine"
        Me.DataGridViewTextBoxColumn11.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "O"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "cfa_des"
        Me.DataGridViewTextBoxColumn13.FillWeight = 140.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "cfa_quanti"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn14.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "Q.ta"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "cfa_prezzo"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "C2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn15.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "Prezzo"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "cfa_sconto"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.Format = "N2"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataGridViewTextBoxColumn18.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Sconto"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'C_totale
        '
        Me.C_totale.DataPropertyName = "totale"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.C_totale.DefaultCellStyle = DataGridViewCellStyle6
        Me.C_totale.FillWeight = 40.0!
        Me.C_totale.HeaderText = "totale"
        Me.C_totale.Name = "C_totale"
        Me.C_totale.ReadOnly = True
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "cfa_iva"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn19.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn19.HeaderText = "Iva"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn29.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn29.HeaderText = "Tipo Iva"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'BS_fattura_righe
        '
        Me.BS_fattura_righe.DataMember = "DT_fattura_DT_fattura_righe"
        Me.BS_fattura_righe.DataSource = Me.BS_fattura
        '
        'DT_v_ordiniBindingNavigator
        '
        Me.DT_v_ordiniBindingNavigator.AddNewItem = Nothing
        Me.DT_v_ordiniBindingNavigator.AutoSize = False
        Me.DT_v_ordiniBindingNavigator.BindingSource = Me.BS_fattura
        Me.DT_v_ordiniBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DT_v_ordiniBindingNavigator.DeleteItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_v_ordiniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicerca, Me.TTTestoRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator3, Me.TTPB, Me.TTBTannulla, Me.TT_CB_anno, Me.TT_CB_mese, Me.TTPB_stampa})
        Me.DT_v_ordiniBindingNavigator.Location = New System.Drawing.Point(0, 688)
        Me.DT_v_ordiniBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_v_ordiniBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_v_ordiniBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_v_ordiniBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_v_ordiniBindingNavigator.Name = "DT_v_ordiniBindingNavigator"
        Me.DT_v_ordiniBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_v_ordiniBindingNavigator.Size = New System.Drawing.Size(1282, 79)
        Me.DT_v_ordiniBindingNavigator.TabIndex = 145
        Me.DT_v_ordiniBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 76)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'TTBTRicerca
        '
        Me.TTBTRicerca.AutoSize = False
        Me.TTBTRicerca.Image = Global.PoP2.Comuni.My.Resources.Resources.Omino_ricarica48
        Me.TTBTRicerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTRicerca.Name = "TTBTRicerca"
        Me.TTBTRicerca.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicerca.Text = "Ricarica"
        Me.TTBTRicerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicerca.ToolTipText = "Seleziona l'Anno"
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.BackColor = System.Drawing.SystemColors.Info
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(100, 79)
        Me.TTTestoRicerca.ToolTipText = "Immettere l'anno di lavoro"
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
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 79)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 79)
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 79)
        '
        'TTBTAggiunge
        '
        Me.TTBTAggiunge.AutoSize = False
        Me.TTBTAggiunge.Image = CType(resources.GetObject("TTBTAggiunge.Image"), System.Drawing.Image)
        Me.TTBTAggiunge.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTAggiunge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTAggiunge.Name = "TTBTAggiunge"
        Me.TTBTAggiunge.RightToLeftAutoMirrorImage = True
        Me.TTBTAggiunge.Size = New System.Drawing.Size(50, 70)
        Me.TTBTAggiunge.Text = "Nuovo"
        Me.TTBTAggiunge.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTAggiunge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTModifica
        '
        Me.TTBTModifica.AutoSize = False
        Me.TTBTModifica.Image = Global.PoP2.Comuni.My.Resources.Resources.modifica
        Me.TTBTModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTModifica.Name = "TTBTModifica"
        Me.TTBTModifica.RightToLeftAutoMirrorImage = True
        Me.TTBTModifica.Size = New System.Drawing.Size(50, 70)
        Me.TTBTModifica.Text = "Modifica"
        Me.TTBTModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTModifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTElimina
        '
        Me.TTBTElimina.AutoSize = False
        Me.TTBTElimina.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_cestino48
        Me.TTBTElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTElimina.Name = "TTBTElimina"
        Me.TTBTElimina.RightToLeftAutoMirrorImage = True
        Me.TTBTElimina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTElimina.Text = "Elimina"
        Me.TTBTElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTElimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTSalva
        '
        Me.TTBTSalva.AutoSize = False
        Me.TTBTSalva.Image = CType(resources.GetObject("TTBTSalva.Image"), System.Drawing.Image)
        Me.TTBTSalva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTSalva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTSalva.Name = "TTBTSalva"
        Me.TTBTSalva.Size = New System.Drawing.Size(50, 70)
        Me.TTBTSalva.Text = "Salva"
        Me.TTBTSalva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 79)
        '
        'TTPB
        '
        Me.TTPB.Name = "TTPB"
        Me.TTPB.Size = New System.Drawing.Size(100, 76)
        '
        'TTBTannulla
        '
        Me.TTBTannulla.AutoSize = False
        Me.TTBTannulla.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TTBTannulla.Image = Global.PoP2.Comuni.My.Resources.Resources.ricicla48
        Me.TTBTannulla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTannulla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTannulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTannulla.Name = "TTBTannulla"
        Me.TTBTannulla.Size = New System.Drawing.Size(150, 75)
        Me.TTBTannulla.Text = "Annulla"
        Me.TTBTannulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTannulla.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.TTBTannulla.Visible = False
        '
        'TT_CB_anno
        '
        Me.TT_CB_anno.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_anno.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_anno.Name = "TT_CB_anno"
        Me.TT_CB_anno.Size = New System.Drawing.Size(121, 79)
        '
        'TT_CB_mese
        '
        Me.TT_CB_mese.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_mese.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_mese.Name = "TT_CB_mese"
        Me.TT_CB_mese.Size = New System.Drawing.Size(150, 38)
        '
        'TTPB_stampa
        '
        Me.TTPB_stampa.Name = "TTPB_stampa"
        Me.TTPB_stampa.Size = New System.Drawing.Size(500, 16)
        '
        'menustampa
        '
        Me.menustampa.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_stp_singola, Me.TS_stp_tutte, Me.ToolStripSeparator1, Me.TS_elenco_fatture, Me.ToolStripSeparator2})
        Me.menustampa.Name = "menustampa"
        Me.menustampa.Size = New System.Drawing.Size(233, 82)
        '
        'TS_stp_singola
        '
        Me.TS_stp_singola.Name = "TS_stp_singola"
        Me.TS_stp_singola.Size = New System.Drawing.Size(232, 22)
        Me.TS_stp_singola.Text = "Stampa Singola Fattura"
        '
        'TS_stp_tutte
        '
        Me.TS_stp_tutte.Name = "TS_stp_tutte"
        Me.TS_stp_tutte.Size = New System.Drawing.Size(232, 22)
        Me.TS_stp_tutte.Text = "Stampa in PDF  tutte le fatture"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(229, 6)
        '
        'TS_elenco_fatture
        '
        Me.TS_elenco_fatture.Name = "TS_elenco_fatture"
        Me.TS_elenco_fatture.Size = New System.Drawing.Size(232, 22)
        Me.TS_elenco_fatture.Text = "Elenco Fatture"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(229, 6)
        '
        'Cerca_pos
        '
        Me.Cerca_pos.Description = "Seleziona la destinazione"
        Me.Cerca_pos.SelectedPath = "C:\Users\d_sol\Documents\fatture"
        '
        'DT_contoreDataGridView
        '
        Me.DT_contoreDataGridView.AllowUserToAddRows = False
        Me.DT_contoreDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DT_contoreDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle8
        Me.DT_contoreDataGridView.AutoGenerateColumns = False
        Me.DT_contoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DT_contoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DT_contoreDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn21})
        Me.DT_contoreDataGridView.DataSource = Me.BS_fatturaContore
        Me.DT_contoreDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DT_contoreDataGridView.Location = New System.Drawing.Point(937, 1)
        Me.DT_contoreDataGridView.Margin = New System.Windows.Forms.Padding(1)
        Me.DT_contoreDataGridView.Name = "DT_contoreDataGridView"
        Me.DT_contoreDataGridView.ReadOnly = True
        Me.DT_contoreDataGridView.RowHeadersWidth = 4
        Me.DT_contoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DT_contoreDataGridView.Size = New System.Drawing.Size(318, 180)
        Me.DT_contoreDataGridView.TabIndex = 145
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "locazione"
        Me.DataGridViewTextBoxColumn7.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "locazione"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "totOre"
        Me.DataGridViewTextBoxColumn9.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "Ore"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn17.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn21.HeaderText = "note"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'BS_fatturaContore
        '
        Me.BS_fatturaContore.DataMember = "DT_fattura_DT_contore"
        Me.BS_fatturaContore.DataSource = Me.BS_fattura
        '
        'DG_ore
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_ore.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DG_ore.AutoGenerateColumns = False
        Me.DG_ore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_ore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ore.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.locazione, Me.GC_oreTot})
        Me.DG_ore.DataSource = Me.BS_fatturaContoreTot
        Me.DG_ore.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_ore.Location = New System.Drawing.Point(937, 183)
        Me.DG_ore.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_ore.Name = "DG_ore"
        Me.DG_ore.RowHeadersWidth = 4
        Me.DG_ore.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_ore.Size = New System.Drawing.Size(318, 135)
        Me.DG_ore.TabIndex = 145
        '
        'locazione
        '
        Me.locazione.DataPropertyName = "locazione"
        Me.locazione.HeaderText = "locazione"
        Me.locazione.Name = "locazione"
        '
        'GC_oreTot
        '
        Me.GC_oreTot.DataPropertyName = "totOre"
        Me.GC_oreTot.FillWeight = 30.0!
        Me.GC_oreTot.HeaderText = "GTot"
        Me.GC_oreTot.Name = "GC_oreTot"
        Me.GC_oreTot.ReadOnly = True
        '
        'BS_fatturaContoreTot
        '
        Me.BS_fatturaContoreTot.DataMember = "DT_fattura_DT_contoreTot"
        Me.BS_fatturaContoreTot.DataSource = Me.BS_fattura
        '
        'LB_resa
        '
        Me.LB_resa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_resa.AutoSize = True
        Me.LB_resa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_resa.Location = New System.Drawing.Point(135, 39)
        Me.LB_resa.Margin = New System.Windows.Forms.Padding(1)
        Me.LB_resa.Name = "LB_resa"
        Me.LB_resa.Size = New System.Drawing.Size(133, 16)
        Me.LB_resa.TabIndex = 146
        Me.LB_resa.Text = "Resa"
        '
        'LB_fatturato
        '
        Me.LB_fatturato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_fatturato.AutoSize = True
        Me.LB_fatturato.Location = New System.Drawing.Point(1, 10)
        Me.LB_fatturato.Margin = New System.Windows.Forms.Padding(1)
        Me.LB_fatturato.Name = "LB_fatturato"
        Me.LB_fatturato.Size = New System.Drawing.Size(132, 17)
        Me.LB_fatturato.TabIndex = 147
        Me.LB_fatturato.Text = "Fatturato"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_fattura, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.18182!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 59.81818!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1258, 675)
        Me.TableLayoutPanel1.TabIndex = 150
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.52229!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.47771!))
        Me.TableLayoutPanel2.Controls.Add(Me.DT_contoreDataGridView, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.DG_ore, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.DG_righe, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel8, 0, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 272)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.9697!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.0303!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 82.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1256, 402)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.95093!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.04907!))
        Me.TableLayoutPanel4.Controls.Add(Me.DG_totale, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1, 183)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(934, 135)
        Me.TableLayoutPanel4.TabIndex = 147
        '
        'DG_totale
        '
        Me.DG_totale.AllowUserToAddRows = False
        Me.DG_totale.AllowUserToDeleteRows = False
        Me.DG_totale.AutoGenerateColumns = False
        Me.DG_totale.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_totale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DG_totale.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_totale.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn4, Me.C_tot_ivato})
        Me.DG_totale.DataSource = Me.BS_fatturaFattura_tot
        Me.DG_totale.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_totale.Location = New System.Drawing.Point(467, 1)
        Me.DG_totale.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_totale.Name = "DG_totale"
        Me.DG_totale.ReadOnly = True
        Me.DG_totale.RowHeadersWidth = 4
        DataGridViewCellStyle13.Format = "C2"
        Me.DG_totale.RowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DG_totale.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.DG_totale.Size = New System.Drawing.Size(466, 133)
        Me.DG_totale.TabIndex = 3
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "tot_lordo"
        DataGridViewCellStyle10.Format = "C2"
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn1.HeaderText = "Lordo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "tot_netto"
        DataGridViewCellStyle11.Format = "C2"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn2.HeaderText = "Netto"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "tot_iva"
        DataGridViewCellStyle12.Format = "C2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn4.HeaderText = "Imposta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'C_tot_ivato
        '
        Me.C_tot_ivato.DataPropertyName = "tot_ivato"
        Me.C_tot_ivato.HeaderText = "Ivato"
        Me.C_tot_ivato.Name = "C_tot_ivato"
        Me.C_tot_ivato.ReadOnly = True
        '
        'BS_fatturaFattura_tot
        '
        Me.BS_fatturaFattura_tot.DataMember = "DT_fattura_DT_fattura_tot"
        Me.BS_fatturaFattura_tot.DataSource = Me.BS_fattura
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel6, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(464, 133)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 1
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.DG_Ore_Periodo, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(233, 1)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 2
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(230, 131)
        Me.TableLayoutPanel6.TabIndex = 5
        '
        'DG_Ore_Periodo
        '
        Me.DG_Ore_Periodo.AllowUserToAddRows = False
        Me.DG_Ore_Periodo.AllowUserToDeleteRows = False
        Me.DG_Ore_Periodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Ore_Periodo.AutoGenerateColumns = False
        Me.DG_Ore_Periodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Ore_Periodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Ore_Periodo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AnnoDataGridViewTextBoxColumn, Me.descrizione, Me.OreDataGridViewTextBoxColumn})
        Me.DG_Ore_Periodo.DataSource = Me.BS_ore
        Me.DG_Ore_Periodo.Location = New System.Drawing.Point(1, 30)
        Me.DG_Ore_Periodo.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_Ore_Periodo.Name = "DG_Ore_Periodo"
        Me.DG_Ore_Periodo.ReadOnly = True
        Me.DG_Ore_Periodo.RowHeadersWidth = 4
        Me.DG_Ore_Periodo.Size = New System.Drawing.Size(228, 100)
        Me.DG_Ore_Periodo.TabIndex = 5
        '
        'AnnoDataGridViewTextBoxColumn
        '
        Me.AnnoDataGridViewTextBoxColumn.DataPropertyName = "anno"
        Me.AnnoDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.AnnoDataGridViewTextBoxColumn.HeaderText = "Anno"
        Me.AnnoDataGridViewTextBoxColumn.Name = "AnnoDataGridViewTextBoxColumn"
        Me.AnnoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'descrizione
        '
        Me.descrizione.DataPropertyName = "descrizione"
        Me.descrizione.FillWeight = 95.0!
        Me.descrizione.HeaderText = "Tipo"
        Me.descrizione.Name = "descrizione"
        Me.descrizione.ReadOnly = True
        '
        'OreDataGridViewTextBoxColumn
        '
        Me.OreDataGridViewTextBoxColumn.DataPropertyName = "ore"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        DataGridViewCellStyle14.NullValue = Nothing
        Me.OreDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle14
        Me.OreDataGridViewTextBoxColumn.FillWeight = 75.0!
        Me.OreDataGridViewTextBoxColumn.HeaderText = "ore"
        Me.OreDataGridViewTextBoxColumn.Name = "OreDataGridViewTextBoxColumn"
        Me.OreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BS_ore
        '
        Me.BS_ore.DataMember = "DT_fattura_DT_ore"
        Me.BS_ore.DataSource = Me.BS_fattura
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(224, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Ore Periodo"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.DG_Fatturato_Periodo, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(230, 131)
        Me.TableLayoutPanel7.TabIndex = 6
        '
        'DG_Fatturato_Periodo
        '
        Me.DG_Fatturato_Periodo.AllowUserToAddRows = False
        Me.DG_Fatturato_Periodo.AllowUserToDeleteRows = False
        Me.DG_Fatturato_Periodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_Fatturato_Periodo.AutoGenerateColumns = False
        Me.DG_Fatturato_Periodo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Fatturato_Periodo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Fatturato_Periodo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataDataGridViewTextBoxColumn, Me.Tipo, Me.ImportoDataGridViewTextBoxColumn})
        Me.DG_Fatturato_Periodo.DataSource = Me.BS_rese
        Me.DG_Fatturato_Periodo.Location = New System.Drawing.Point(1, 30)
        Me.DG_Fatturato_Periodo.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_Fatturato_Periodo.Name = "DG_Fatturato_Periodo"
        Me.DG_Fatturato_Periodo.ReadOnly = True
        Me.DG_Fatturato_Periodo.RowHeadersWidth = 4
        Me.DG_Fatturato_Periodo.Size = New System.Drawing.Size(228, 100)
        Me.DG_Fatturato_Periodo.TabIndex = 4
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "Data"
        DataGridViewCellStyle15.NullValue = Nothing
        Me.DataDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.DataDataGridViewTextBoxColumn.HeaderText = "Anno"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.FillWeight = 80.0!
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'ImportoDataGridViewTextBoxColumn
        '
        Me.ImportoDataGridViewTextBoxColumn.DataPropertyName = "Importo"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "C2"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.ImportoDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle16
        Me.ImportoDataGridViewTextBoxColumn.FillWeight = 90.0!
        Me.ImportoDataGridViewTextBoxColumn.HeaderText = "Importo"
        Me.ImportoDataGridViewTextBoxColumn.Name = "ImportoDataGridViewTextBoxColumn"
        Me.ImportoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BS_rese
        '
        Me.BS_rese.DataMember = "DT_fattura_DT_rese"
        Me.BS_rese.DataSource = Me.BS_fattura
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fatturato Periodo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.BT_resa, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.LB_fatturato, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LB_ore, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.LB_resa, 1, 1)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(937, 320)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(269, 81)
        Me.TableLayoutPanel3.TabIndex = 146
        '
        'BT_resa
        '
        Me.BT_resa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_resa.Location = New System.Drawing.Point(1, 57)
        Me.BT_resa.Margin = New System.Windows.Forms.Padding(1)
        Me.BT_resa.Name = "BT_resa"
        Me.BT_resa.Size = New System.Drawing.Size(132, 23)
        Me.BT_resa.TabIndex = 154
        Me.BT_resa.Text = "Aggiorna Resa"
        Me.BT_resa.UseVisualStyleBackColor = True
        '
        'LB_ore
        '
        Me.LB_ore.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_ore.AutoSize = True
        Me.LB_ore.Location = New System.Drawing.Point(137, 11)
        Me.LB_ore.Name = "LB_ore"
        Me.LB_ore.Size = New System.Drawing.Size(129, 17)
        Me.LB_ore.TabIndex = 155
        Me.LB_ore.Text = "Ore"
        '
        'TableLayoutPanel8
        '
        Me.TableLayoutPanel8.ColumnCount = 4
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.Controls.Add(Me.LB_resaAnno, 2, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.LB_totaleOreAnno, 1, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.LB_totaleAnno, 0, 0)
        Me.TableLayoutPanel8.Controls.Add(Me.LBT_totaleAnno, 0, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.LBT_oreAnno, 1, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.LBT_reseAnno, 2, 1)
        Me.TableLayoutPanel8.Controls.Add(Me.Label3, 0, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.LBT_totaleMese, 0, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.Label5, 1, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.LBT_oreMese, 1, 3)
        Me.TableLayoutPanel8.Controls.Add(Me.Label7, 2, 2)
        Me.TableLayoutPanel8.Controls.Add(Me.LBT_reseMese, 2, 3)
        Me.TableLayoutPanel8.Location = New System.Drawing.Point(3, 322)
        Me.TableLayoutPanel8.Name = "TableLayoutPanel8"
        Me.TableLayoutPanel8.RowCount = 4
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel8.Size = New System.Drawing.Size(930, 77)
        Me.TableLayoutPanel8.TabIndex = 148
        '
        'LB_resaAnno
        '
        Me.LB_resaAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LB_resaAnno.AutoSize = True
        Me.LB_resaAnno.Location = New System.Drawing.Point(467, 2)
        Me.LB_resaAnno.Name = "LB_resaAnno"
        Me.LB_resaAnno.Size = New System.Drawing.Size(78, 17)
        Me.LB_resaAnno.TabIndex = 2
        Me.LB_resaAnno.Text = "Resa Anno"
        '
        'LB_totaleOreAnno
        '
        Me.LB_totaleOreAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LB_totaleOreAnno.AutoSize = True
        Me.LB_totaleOreAnno.Location = New System.Drawing.Point(235, 2)
        Me.LB_totaleOreAnno.Name = "LB_totaleOreAnno"
        Me.LB_totaleOreAnno.Size = New System.Drawing.Size(69, 17)
        Me.LB_totaleOreAnno.TabIndex = 1
        Me.LB_totaleOreAnno.Text = "Ore Anno"
        '
        'LB_totaleAnno
        '
        Me.LB_totaleAnno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_totaleAnno.AutoSize = True
        Me.LB_totaleAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LB_totaleAnno.Location = New System.Drawing.Point(3, 0)
        Me.LB_totaleAnno.Name = "LB_totaleAnno"
        Me.LB_totaleAnno.Size = New System.Drawing.Size(226, 19)
        Me.LB_totaleAnno.TabIndex = 0
        Me.LB_totaleAnno.Text = "Fatturato Anno"
        '
        'LBT_totaleAnno
        '
        Me.LBT_totaleAnno.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBT_totaleAnno.AutoSize = True
        Me.LBT_totaleAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.LBT_totaleAnno.ForeColor = System.Drawing.Color.Maroon
        Me.LBT_totaleAnno.Location = New System.Drawing.Point(1, 20)
        Me.LBT_totaleAnno.Margin = New System.Windows.Forms.Padding(1)
        Me.LBT_totaleAnno.Name = "LBT_totaleAnno"
        Me.LBT_totaleAnno.Size = New System.Drawing.Size(230, 17)
        Me.LBT_totaleAnno.TabIndex = 3
        Me.LBT_totaleAnno.Text = "Importo Anno"
        '
        'LBT_oreAnno
        '
        Me.LBT_oreAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBT_oreAnno.AutoSize = True
        Me.LBT_oreAnno.ForeColor = System.Drawing.Color.Maroon
        Me.LBT_oreAnno.Location = New System.Drawing.Point(233, 20)
        Me.LBT_oreAnno.Margin = New System.Windows.Forms.Padding(1)
        Me.LBT_oreAnno.Name = "LBT_oreAnno"
        Me.LBT_oreAnno.Size = New System.Drawing.Size(69, 17)
        Me.LBT_oreAnno.TabIndex = 4
        Me.LBT_oreAnno.Text = "Ore Anno"
        '
        'LBT_reseAnno
        '
        Me.LBT_reseAnno.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LBT_reseAnno.AutoSize = True
        Me.LBT_reseAnno.ForeColor = System.Drawing.Color.Maroon
        Me.LBT_reseAnno.Location = New System.Drawing.Point(465, 20)
        Me.LBT_reseAnno.Margin = New System.Windows.Forms.Padding(1)
        Me.LBT_reseAnno.Name = "LBT_reseAnno"
        Me.LBT_reseAnno.Size = New System.Drawing.Size(69, 17)
        Me.LBT_reseAnno.TabIndex = 5
        Me.LBT_reseAnno.Text = "Ore Anno"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fatturato Mese"
        '
        'LBT_totaleMese
        '
        Me.LBT_totaleMese.AutoSize = True
        Me.LBT_totaleMese.ForeColor = System.Drawing.Color.Maroon
        Me.LBT_totaleMese.Location = New System.Drawing.Point(3, 57)
        Me.LBT_totaleMese.Name = "LBT_totaleMese"
        Me.LBT_totaleMese.Size = New System.Drawing.Size(51, 17)
        Me.LBT_totaleMese.TabIndex = 7
        Me.LBT_totaleMese.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(235, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Ore Mese"
        '
        'LBT_oreMese
        '
        Me.LBT_oreMese.AutoSize = True
        Me.LBT_oreMese.ForeColor = System.Drawing.Color.Maroon
        Me.LBT_oreMese.Location = New System.Drawing.Point(235, 57)
        Me.LBT_oreMese.Name = "LBT_oreMese"
        Me.LBT_oreMese.Size = New System.Drawing.Size(51, 17)
        Me.LBT_oreMese.TabIndex = 9
        Me.LBT_oreMese.Text = "Label6"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(467, 38)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Rese Mese"
        '
        'LBT_reseMese
        '
        Me.LBT_reseMese.AutoSize = True
        Me.LBT_reseMese.ForeColor = System.Drawing.Color.Maroon
        Me.LBT_reseMese.Location = New System.Drawing.Point(467, 57)
        Me.LBT_reseMese.Name = "LBT_reseMese"
        Me.LBT_reseMese.Size = New System.Drawing.Size(51, 17)
        Me.LBT_reseMese.TabIndex = 11
        Me.LBT_reseMese.Text = "Label8"
        '
        'BS_contoreTot
        '
        Me.BS_contoreTot.DataMember = "DT_fattura_DT_contoreTot"
        Me.BS_contoreTot.DataSource = Me.BS_fattura
        '
        'BS_contore
        '
        Me.BS_contore.DataMember = "DT_contore"
        Me.BS_contore.DataSource = Me.DS_fattura
        '
        'TA_fattura
        '
        Me.TA_fattura.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_fatturaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TA_fattura_tot
        '
        Me.TA_fattura_tot.ClearBeforeFill = True
        '
        'TA_fattura_righe
        '
        Me.TA_fattura_righe.ClearBeforeFill = True
        '
        'BS_tiposervizio
        '
        Me.BS_tiposervizio.DataMember = "DT_tipo_servizio"
        Me.BS_tiposervizio.DataSource = Me.DS_fattura
        '
        'TA_tiposervizio
        '
        Me.TA_tiposervizio.ClearBeforeFill = True
        '
        'BS_iva
        '
        Me.BS_iva.DataMember = "DT_iva"
        Me.BS_iva.DataSource = Me.DS_fattura
        '
        'TA_iva
        '
        Me.TA_iva.ClearBeforeFill = True
        '
        'BS_valuta
        '
        Me.BS_valuta.DataMember = "DT_valuta"
        Me.BS_valuta.DataSource = Me.DS_fattura
        '
        'TA_valuta
        '
        Me.TA_valuta.ClearBeforeFill = True
        '
        'BS_clienti
        '
        Me.BS_clienti.DataMember = "DT_cantieri"
        Me.BS_clienti.DataSource = Me.DS_fattura
        '
        'TA_cantieri
        '
        Me.TA_cantieri.ClearBeforeFill = True
        '
        'BS_destinatari
        '
        Me.BS_destinatari.DataMember = "DT_destinatari"
        Me.BS_destinatari.DataSource = Me.DS_fattura
        '
        'TA_destinatari
        '
        Me.TA_destinatari.ClearBeforeFill = True
        '
        'TA_contore
        '
        Me.TA_contore.ClearBeforeFill = True
        '
        'TA_contoreTot
        '
        Me.TA_contoreTot.ClearBeforeFill = True
        '
        'TA_rese
        '
        Me.TA_rese.ClearBeforeFill = True
        '
        'TA_ore
        '
        Me.TA_ore.ClearBeforeFill = True
        '
        'FrmFattura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1282, 767)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DT_v_ordiniBindingNavigator)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmFattura"
        Me.Text = "Fatture"
        CType(Me.DG_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_righe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_fattura_righe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_v_ordiniBindingNavigator.ResumeLayout(False)
        Me.DT_v_ordiniBindingNavigator.PerformLayout()
        Me.menustampa.ResumeLayout(False)
        CType(Me.DT_contoreDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_fatturaContore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_ore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_fatturaContoreTot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        CType(Me.DG_totale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_fatturaFattura_tot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.DG_Ore_Periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_ore, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.DG_Fatturato_Periodo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_rese, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel8.ResumeLayout(False)
        Me.TableLayoutPanel8.PerformLayout()
        CType(Me.BS_contoreTot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_contore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_tiposervizio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_iva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_valuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_destinatari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_fattura As DS_fattura
    Friend WithEvents BS_fattura As BindingSource
    Friend WithEvents TA_fattura As DS_fatturaTableAdapters.TA_fattura
    Friend WithEvents TableAdapterManager As DS_fatturaTableAdapters.TableAdapterManager
    Friend WithEvents DG_fattura As DataGridView
    Friend WithEvents BS_fatturaFattura_tot As BindingSource
    Friend WithEvents TA_fattura_tot As DS_fatturaTableAdapters.TA_fattura_tot
    Friend WithEvents BS_fattura_righe As BindingSource
    Friend WithEvents TA_fattura_righe As DS_fatturaTableAdapters.TA_fattura_righe
    Friend WithEvents DG_righe As DataGridView
    Friend WithEvents DT_v_ordiniBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents TTBTRicerca As ToolStripButton
    Friend WithEvents TTTestoRicerca As ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents TTBTModifica As ToolStripButton
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TTPB As ToolStripProgressBar
    Friend WithEvents TTBTannulla As ToolStripButton
    Friend WithEvents TT_CB_anno As ToolStripComboBox
    Friend WithEvents TT_CB_mese As ToolStripComboBox
    Friend WithEvents menustampa As ContextMenuStrip
    Friend WithEvents TS_stp_singola As ToolStripMenuItem
    Friend WithEvents TS_stp_tutte As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TS_elenco_fatture As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents Cerca_pos As FolderBrowserDialog
    Friend WithEvents TTPB_stampa As ToolStripProgressBar
    Friend WithEvents BS_tiposervizio As BindingSource
    Friend WithEvents TA_tiposervizio As DS_fatturaTableAdapters.TA_tipo_servizio
    Friend WithEvents BS_iva As BindingSource
    Friend WithEvents TA_iva As DS_fatturaTableAdapters.TA_iva
    Friend WithEvents BS_valuta As BindingSource
    Friend WithEvents TA_valuta As DS_fatturaTableAdapters.TA_valuta
    Friend WithEvents BS_clienti As BindingSource
    Friend WithEvents TA_cantieri As DS_fatturaTableAdapters.TA_cantieri
    Friend WithEvents BS_destinatari As BindingSource
    Friend WithEvents TA_destinatari As DS_fatturaTableAdapters.TA_destinatari
    Friend WithEvents BS_contore As BindingSource
    Friend WithEvents TA_contore As DS_fatturaTableAdapters.TA_contore
    Friend WithEvents DT_contoreDataGridView As DataGridView
    Friend WithEvents BS_fatturaContore As BindingSource
    Friend WithEvents BS_contoreTot As BindingSource
    Friend WithEvents TA_contoreTot As DS_fatturaTableAdapters.TA_contoreTot
    Friend WithEvents DG_ore As DataGridView
    Friend WithEvents BS_fatturaContoreTot As BindingSource
    Friend WithEvents LB_resa As Label
    Friend WithEvents LB_fatturato As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents DG_totale As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents C_tot_ivato As DataGridViewTextBoxColumn
    Friend WithEvents DG_Fatturato_Periodo As DataGridView
    Friend WithEvents TA_rese As DS_fatturaTableAdapters.TA_rese
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents BS_rese As BindingSource
    Friend WithEvents DG_Ore_Periodo As DataGridView
    Friend WithEvents BS_ore As BindingSource
    Friend WithEvents TA_ore As DS_fatturaTableAdapters.TA_ore
    Friend WithEvents AnnoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents descrizione As DataGridViewTextBoxColumn
    Friend WithEvents OreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents ImportoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel8 As TableLayoutPanel
    Friend WithEvents LB_totaleAnno As Label
    Friend WithEvents LB_totaleOreAnno As Label
    Friend WithEvents LB_resaAnno As Label
    Friend WithEvents LBT_totaleAnno As Label
    Friend WithEvents LBT_oreAnno As Label
    Friend WithEvents LBT_reseAnno As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents LBT_totaleMese As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LBT_oreMese As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LBT_reseMese As Label
    Friend WithEvents locazione As DataGridViewTextBoxColumn
    Friend WithEvents GC_oreTot As DataGridViewTextBoxColumn
    Friend WithEvents BT_resa As Button
    Friend WithEvents LB_ore As Label
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents C_totale As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents Col_numero As DataGridViewTextBoxColumn
    Friend WithEvents C_societa As DataGridViewTextBoxColumn
    Friend WithEvents C_des As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents C_114_codicedestinatario As DataGridViewTextBoxColumn
End Class
