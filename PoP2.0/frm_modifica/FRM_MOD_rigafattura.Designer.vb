<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_mod_rigafattura
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
        Dim OrdineLabel As System.Windows.Forms.Label
        Dim Cfa_fa_numLabel As System.Windows.Forms.Label
        Dim Cfa_desLabel As System.Windows.Forms.Label
        Dim Cfa_quantiLabel As System.Windows.Forms.Label
        Dim Cfa_prezzoLabel As System.Windows.Forms.Label
        Dim Cfa_scontoLabel As System.Windows.Forms.Label
        Dim Cfa_ivaLabel As System.Windows.Forms.Label
        Dim Cfa_iddestLabel As System.Windows.Forms.Label
        Dim Cfa_idcliLabel As System.Windows.Forms.Label
        Dim Cfa_puloforLabel As System.Windows.Forms.Label
        Dim Cfa_rcLabel As System.Windows.Forms.Label
        Dim Cfa_tipoLabel As System.Windows.Forms.Label
        Dim SimboloLabel As System.Windows.Forms.Label
        Dim Tipo_rigaLabel As System.Windows.Forms.Label
        Dim Tipo_ivaLabel As System.Windows.Forms.Label
        Dim Cod_FELabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_mod_rigafattura))
        Me.OrdineTextBox = New System.Windows.Forms.TextBox()
        Me.BS_righefattura = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_fattura = New PoP2.Comuni.DS_fattura()
        Me.Cfa_fa_numTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_desTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_quantiTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_prezzoTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_scontoTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_ivaTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_iddestTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_idcliTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_puloforTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_rcTextBox = New System.Windows.Forms.TextBox()
        Me.Cfa_tipoTextBox = New System.Windows.Forms.TextBox()
        Me.SimboloTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_rigaTextBox = New System.Windows.Forms.TextBox()
        Me.Tipo_ivaTextBox = New System.Windows.Forms.TextBox()
        Me.CB_tiposervizio = New System.Windows.Forms.ComboBox()
        Me.BS_tiposervizio = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_iva = New System.Windows.Forms.ComboBox()
        Me.BS_modoiva = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_valuta = New System.Windows.Forms.ComboBox()
        Me.BS_valuta = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_destinatari = New System.Windows.Forms.ComboBox()
        Me.BS_destinatari = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_clienti = New System.Windows.Forms.ComboBox()
        Me.BS_cantieri = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DG_storico = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_storico = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_contoreDataGridView = New System.Windows.Forms.DataGridView()
        Me.locazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totOre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_contore = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_fattura_righe = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura_righe()
        Me.TableAdapterManager = New PoP2.Comuni.DS_fatturaTableAdapters.TableAdapterManager()
        Me.TA_contore = New PoP2.Comuni.DS_fatturaTableAdapters.TA_contore()
        Me.TA_cantieri = New PoP2.Comuni.DS_fatturaTableAdapters.TA_cantieri()
        Me.TA_destinatari = New PoP2.Comuni.DS_fatturaTableAdapters.TA_destinatari()
        Me.TA_iva = New PoP2.Comuni.DS_fatturaTableAdapters.TA_iva()
        Me.TA_valuta = New PoP2.Comuni.DS_fatturaTableAdapters.TA_valuta()
        Me.TX_ricercastorico = New System.Windows.Forms.TextBox()
        Me.LB_totale = New System.Windows.Forms.Label()
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BT_presenze = New System.Windows.Forms.Button()
        Me.DG_destinatari = New System.Windows.Forms.DataGridView()
        Me.LocazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CanoneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cod_FETextBox = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.TV_ordini = New System.Windows.Forms.TreeView()
        Me.PB_ordini = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DS_generatore_fatture = New PoP2.Comuni.DS_generatore_fatture()
        OrdineLabel = New System.Windows.Forms.Label()
        Cfa_fa_numLabel = New System.Windows.Forms.Label()
        Cfa_desLabel = New System.Windows.Forms.Label()
        Cfa_quantiLabel = New System.Windows.Forms.Label()
        Cfa_prezzoLabel = New System.Windows.Forms.Label()
        Cfa_scontoLabel = New System.Windows.Forms.Label()
        Cfa_ivaLabel = New System.Windows.Forms.Label()
        Cfa_iddestLabel = New System.Windows.Forms.Label()
        Cfa_idcliLabel = New System.Windows.Forms.Label()
        Cfa_puloforLabel = New System.Windows.Forms.Label()
        Cfa_rcLabel = New System.Windows.Forms.Label()
        Cfa_tipoLabel = New System.Windows.Forms.Label()
        SimboloLabel = New System.Windows.Forms.Label()
        Tipo_rigaLabel = New System.Windows.Forms.Label()
        Tipo_ivaLabel = New System.Windows.Forms.Label()
        Cod_FELabel = New System.Windows.Forms.Label()
        CType(Me.BS_righefattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_tiposervizio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_modoiva, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_valuta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_destinatari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_cantieri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_storico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_storico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_contoreDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_contore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_v_ordiniBindingNavigator.SuspendLayout()
        CType(Me.DG_destinatari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        CType(Me.DS_generatore_fatture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OrdineLabel
        '
        OrdineLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        OrdineLabel.AutoSize = True
        OrdineLabel.Location = New System.Drawing.Point(4, 0)
        OrdineLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        OrdineLabel.Name = "OrdineLabel"
        OrdineLabel.Size = New System.Drawing.Size(100, 29)
        OrdineLabel.TabIndex = 3
        OrdineLabel.Text = "ordine:"
        OrdineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cfa_fa_numLabel
        '
        Cfa_fa_numLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cfa_fa_numLabel.Location = New System.Drawing.Point(4, 29)
        Cfa_fa_numLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_fa_numLabel.Name = "Cfa_fa_numLabel"
        Cfa_fa_numLabel.Size = New System.Drawing.Size(100, 29)
        Cfa_fa_numLabel.TabIndex = 5
        Cfa_fa_numLabel.Text = "Numero Fattura:"
        Cfa_fa_numLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cfa_desLabel
        '
        Cfa_desLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cfa_desLabel.AutoSize = True
        Cfa_desLabel.Location = New System.Drawing.Point(4, 58)
        Cfa_desLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_desLabel.Name = "Cfa_desLabel"
        Cfa_desLabel.Size = New System.Drawing.Size(100, 29)
        Cfa_desLabel.TabIndex = 7
        Cfa_desLabel.Text = "Descrizione:"
        Cfa_desLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cfa_quantiLabel
        '
        Cfa_quantiLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cfa_quantiLabel.AutoSize = True
        Cfa_quantiLabel.Location = New System.Drawing.Point(4, 87)
        Cfa_quantiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_quantiLabel.Name = "Cfa_quantiLabel"
        Cfa_quantiLabel.Size = New System.Drawing.Size(100, 29)
        Cfa_quantiLabel.TabIndex = 9
        Cfa_quantiLabel.Text = "Q.ta:"
        Cfa_quantiLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cfa_prezzoLabel
        '
        Cfa_prezzoLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cfa_prezzoLabel.AutoSize = True
        Cfa_prezzoLabel.Location = New System.Drawing.Point(96, 0)
        Cfa_prezzoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_prezzoLabel.Name = "Cfa_prezzoLabel"
        Cfa_prezzoLabel.Size = New System.Drawing.Size(57, 28)
        Cfa_prezzoLabel.TabIndex = 11
        Cfa_prezzoLabel.Text = "Prezzo:"
        Cfa_prezzoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cfa_scontoLabel
        '
        Cfa_scontoLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cfa_scontoLabel.AutoSize = True
        Cfa_scontoLabel.Location = New System.Drawing.Point(277, 0)
        Cfa_scontoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_scontoLabel.Name = "Cfa_scontoLabel"
        Cfa_scontoLabel.Size = New System.Drawing.Size(57, 28)
        Cfa_scontoLabel.TabIndex = 13
        Cfa_scontoLabel.Text = "Sconto:"
        Cfa_scontoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cfa_ivaLabel
        '
        Cfa_ivaLabel.AutoSize = True
        Cfa_ivaLabel.Location = New System.Drawing.Point(152, 505)
        Cfa_ivaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_ivaLabel.Name = "Cfa_ivaLabel"
        Cfa_ivaLabel.Size = New System.Drawing.Size(29, 17)
        Cfa_ivaLabel.TabIndex = 15
        Cfa_ivaLabel.Text = "IVA"
        Cfa_ivaLabel.Visible = False
        '
        'Cfa_iddestLabel
        '
        Cfa_iddestLabel.AutoSize = True
        Cfa_iddestLabel.Location = New System.Drawing.Point(235, 507)
        Cfa_iddestLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_iddestLabel.Name = "Cfa_iddestLabel"
        Cfa_iddestLabel.Size = New System.Drawing.Size(73, 17)
        Cfa_iddestLabel.TabIndex = 17
        Cfa_iddestLabel.Text = "cfa iddest:"
        Cfa_iddestLabel.Visible = False
        '
        'Cfa_idcliLabel
        '
        Cfa_idcliLabel.AutoSize = True
        Cfa_idcliLabel.Location = New System.Drawing.Point(370, 510)
        Cfa_idcliLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_idcliLabel.Name = "Cfa_idcliLabel"
        Cfa_idcliLabel.Size = New System.Drawing.Size(59, 17)
        Cfa_idcliLabel.TabIndex = 19
        Cfa_idcliLabel.Text = "cfa idcli:"
        Cfa_idcliLabel.Visible = False
        '
        'Cfa_puloforLabel
        '
        Cfa_puloforLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Cfa_puloforLabel.AutoSize = True
        Cfa_puloforLabel.Location = New System.Drawing.Point(4, 50)
        Cfa_puloforLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_puloforLabel.Name = "Cfa_puloforLabel"
        Cfa_puloforLabel.Size = New System.Drawing.Size(98, 25)
        Cfa_puloforLabel.TabIndex = 21
        Cfa_puloforLabel.Text = "Valuta:"
        Cfa_puloforLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cfa_rcLabel
        '
        Cfa_rcLabel.AutoSize = True
        Cfa_rcLabel.Location = New System.Drawing.Point(679, 510)
        Cfa_rcLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_rcLabel.Name = "Cfa_rcLabel"
        Cfa_rcLabel.Size = New System.Drawing.Size(41, 17)
        Cfa_rcLabel.TabIndex = 25
        Cfa_rcLabel.Text = "id iva"
        Cfa_rcLabel.Visible = False
        '
        'Cfa_tipoLabel
        '
        Cfa_tipoLabel.AutoSize = True
        Cfa_tipoLabel.Location = New System.Drawing.Point(880, 507)
        Cfa_tipoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Cfa_tipoLabel.Name = "Cfa_tipoLabel"
        Cfa_tipoLabel.Size = New System.Drawing.Size(58, 17)
        Cfa_tipoLabel.TabIndex = 27
        Cfa_tipoLabel.Text = "cfa tipo:"
        Cfa_tipoLabel.Visible = False
        '
        'SimboloLabel
        '
        SimboloLabel.AutoSize = True
        SimboloLabel.Location = New System.Drawing.Point(488, 510)
        SimboloLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SimboloLabel.Name = "SimboloLabel"
        SimboloLabel.Size = New System.Drawing.Size(52, 17)
        SimboloLabel.TabIndex = 31
        SimboloLabel.Text = "Valuta:"
        SimboloLabel.Visible = False
        '
        'Tipo_rigaLabel
        '
        Tipo_rigaLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Tipo_rigaLabel.AutoSize = True
        Tipo_rigaLabel.Location = New System.Drawing.Point(4, 0)
        Tipo_rigaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tipo_rigaLabel.Name = "Tipo_rigaLabel"
        Tipo_rigaLabel.Size = New System.Drawing.Size(98, 25)
        Tipo_rigaLabel.TabIndex = 33
        Tipo_rigaLabel.Text = "Tipo Servizio"
        Tipo_rigaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Tipo_ivaLabel
        '
        Tipo_ivaLabel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Tipo_ivaLabel.AutoSize = True
        Tipo_ivaLabel.Location = New System.Drawing.Point(4, 25)
        Tipo_ivaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Tipo_ivaLabel.Name = "Tipo_ivaLabel"
        Tipo_ivaLabel.Size = New System.Drawing.Size(98, 25)
        Tipo_ivaLabel.TabIndex = 39
        Tipo_ivaLabel.Text = "Modalita IVA"
        Tipo_ivaLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Cod_FELabel
        '
        Cod_FELabel.AutoSize = True
        Cod_FELabel.Location = New System.Drawing.Point(1084, 510)
        Cod_FELabel.Name = "Cod_FELabel"
        Cod_FELabel.Size = New System.Drawing.Size(56, 17)
        Cod_FELabel.TabIndex = 164
        Cod_FELabel.Text = "cod FE:"
        Cod_FELabel.Visible = False
        '
        'OrdineTextBox
        '
        Me.OrdineTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "ordine", True))
        Me.OrdineTextBox.Location = New System.Drawing.Point(112, 4)
        Me.OrdineTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.OrdineTextBox.Name = "OrdineTextBox"
        Me.OrdineTextBox.Size = New System.Drawing.Size(55, 23)
        Me.OrdineTextBox.TabIndex = 1
        '
        'BS_righefattura
        '
        Me.BS_righefattura.DataMember = "DT_fattura_righe"
        Me.BS_righefattura.DataSource = Me.DS_fattura
        '
        'DS_fattura
        '
        Me.DS_fattura.DataSetName = "DS_fattura"
        Me.DS_fattura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Cfa_fa_numTextBox
        '
        Me.Cfa_fa_numTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "cfa_fa_num", True))
        Me.Cfa_fa_numTextBox.Location = New System.Drawing.Point(112, 33)
        Me.Cfa_fa_numTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_fa_numTextBox.Name = "Cfa_fa_numTextBox"
        Me.Cfa_fa_numTextBox.Size = New System.Drawing.Size(91, 23)
        Me.Cfa_fa_numTextBox.TabIndex = 2
        '
        'Cfa_desTextBox
        '
        Me.Cfa_desTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "cfa_des", True))
        Me.Cfa_desTextBox.Location = New System.Drawing.Point(112, 62)
        Me.Cfa_desTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_desTextBox.Name = "Cfa_desTextBox"
        Me.Cfa_desTextBox.Size = New System.Drawing.Size(477, 23)
        Me.Cfa_desTextBox.TabIndex = 3
        '
        'Cfa_quantiTextBox
        '
        Me.Cfa_quantiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "cfa_quanti", True))
        Me.Cfa_quantiTextBox.Location = New System.Drawing.Point(4, 4)
        Me.Cfa_quantiTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_quantiTextBox.Name = "Cfa_quantiTextBox"
        Me.Cfa_quantiTextBox.Size = New System.Drawing.Size(84, 23)
        Me.Cfa_quantiTextBox.TabIndex = 4
        '
        'Cfa_prezzoTextBox
        '
        Me.Cfa_prezzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "cfa_prezzo", True))
        Me.Cfa_prezzoTextBox.Location = New System.Drawing.Point(161, 4)
        Me.Cfa_prezzoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_prezzoTextBox.Name = "Cfa_prezzoTextBox"
        Me.Cfa_prezzoTextBox.Size = New System.Drawing.Size(106, 23)
        Me.Cfa_prezzoTextBox.TabIndex = 5
        '
        'Cfa_scontoTextBox
        '
        Me.Cfa_scontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "cfa_sconto", True))
        Me.Cfa_scontoTextBox.Location = New System.Drawing.Point(342, 4)
        Me.Cfa_scontoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_scontoTextBox.Name = "Cfa_scontoTextBox"
        Me.Cfa_scontoTextBox.Size = New System.Drawing.Size(68, 23)
        Me.Cfa_scontoTextBox.TabIndex = 6
        '
        'Cfa_ivaTextBox
        '
        Me.Cfa_ivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "cfa_iva", True))
        Me.Cfa_ivaTextBox.Location = New System.Drawing.Point(185, 501)
        Me.Cfa_ivaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_ivaTextBox.Name = "Cfa_ivaTextBox"
        Me.Cfa_ivaTextBox.Size = New System.Drawing.Size(53, 23)
        Me.Cfa_ivaTextBox.TabIndex = 7
        Me.Cfa_ivaTextBox.Visible = False
        '
        'Cfa_iddestTextBox
        '
        Me.Cfa_iddestTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "cfa_iddest", True))
        Me.Cfa_iddestTextBox.Location = New System.Drawing.Point(316, 504)
        Me.Cfa_iddestTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_iddestTextBox.Name = "Cfa_iddestTextBox"
        Me.Cfa_iddestTextBox.Size = New System.Drawing.Size(54, 23)
        Me.Cfa_iddestTextBox.TabIndex = 18
        Me.Cfa_iddestTextBox.Visible = False
        '
        'Cfa_idcliTextBox
        '
        Me.Cfa_idcliTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "cfa_idcli", True))
        Me.Cfa_idcliTextBox.Location = New System.Drawing.Point(426, 507)
        Me.Cfa_idcliTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_idcliTextBox.Name = "Cfa_idcliTextBox"
        Me.Cfa_idcliTextBox.Size = New System.Drawing.Size(54, 23)
        Me.Cfa_idcliTextBox.TabIndex = 20
        Me.Cfa_idcliTextBox.Visible = False
        '
        'Cfa_puloforTextBox
        '
        Me.Cfa_puloforTextBox.Location = New System.Drawing.Point(556, 506)
        Me.Cfa_puloforTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_puloforTextBox.Name = "Cfa_puloforTextBox"
        Me.Cfa_puloforTextBox.Size = New System.Drawing.Size(53, 23)
        Me.Cfa_puloforTextBox.TabIndex = 22
        Me.Cfa_puloforTextBox.Visible = False
        '
        'Cfa_rcTextBox
        '
        Me.Cfa_rcTextBox.Location = New System.Drawing.Point(747, 504)
        Me.Cfa_rcTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_rcTextBox.Name = "Cfa_rcTextBox"
        Me.Cfa_rcTextBox.Size = New System.Drawing.Size(53, 23)
        Me.Cfa_rcTextBox.TabIndex = 26
        Me.Cfa_rcTextBox.Visible = False
        '
        'Cfa_tipoTextBox
        '
        Me.Cfa_tipoTextBox.Location = New System.Drawing.Point(948, 504)
        Me.Cfa_tipoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Cfa_tipoTextBox.Name = "Cfa_tipoTextBox"
        Me.Cfa_tipoTextBox.Size = New System.Drawing.Size(53, 23)
        Me.Cfa_tipoTextBox.TabIndex = 28
        Me.Cfa_tipoTextBox.Visible = False
        '
        'SimboloTextBox
        '
        Me.SimboloTextBox.Location = New System.Drawing.Point(617, 506)
        Me.SimboloTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SimboloTextBox.Name = "SimboloTextBox"
        Me.SimboloTextBox.Size = New System.Drawing.Size(53, 23)
        Me.SimboloTextBox.TabIndex = 32
        Me.SimboloTextBox.Visible = False
        '
        'Tipo_rigaTextBox
        '
        Me.Tipo_rigaTextBox.Location = New System.Drawing.Point(1009, 504)
        Me.Tipo_rigaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Tipo_rigaTextBox.Name = "Tipo_rigaTextBox"
        Me.Tipo_rigaTextBox.Size = New System.Drawing.Size(53, 23)
        Me.Tipo_rigaTextBox.TabIndex = 34
        Me.Tipo_rigaTextBox.Visible = False
        '
        'Tipo_ivaTextBox
        '
        Me.Tipo_ivaTextBox.Location = New System.Drawing.Point(808, 504)
        Me.Tipo_ivaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Tipo_ivaTextBox.Name = "Tipo_ivaTextBox"
        Me.Tipo_ivaTextBox.Size = New System.Drawing.Size(53, 23)
        Me.Tipo_ivaTextBox.TabIndex = 40
        Me.Tipo_ivaTextBox.Visible = False
        '
        'CB_tiposervizio
        '
        Me.CB_tiposervizio.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_righefattura, "cfa_tipo", True))
        Me.CB_tiposervizio.DataSource = Me.BS_tiposervizio
        Me.CB_tiposervizio.DisplayMember = "descrizione"
        Me.CB_tiposervizio.FormattingEnabled = True
        Me.CB_tiposervizio.Location = New System.Drawing.Point(109, 3)
        Me.CB_tiposervizio.Name = "CB_tiposervizio"
        Me.CB_tiposervizio.Size = New System.Drawing.Size(347, 24)
        Me.CB_tiposervizio.TabIndex = 10
        Me.CB_tiposervizio.ValueMember = "id"
        '
        'BS_tiposervizio
        '
        Me.BS_tiposervizio.DataMember = "DT_tipo_servizio"
        Me.BS_tiposervizio.DataSource = Me.DS_fattura
        '
        'CB_iva
        '
        Me.CB_iva.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_righefattura, "cfa_rc", True))
        Me.CB_iva.DataSource = Me.BS_modoiva
        Me.CB_iva.DisplayMember = "descrizione"
        Me.CB_iva.FormattingEnabled = True
        Me.CB_iva.Location = New System.Drawing.Point(109, 28)
        Me.CB_iva.Name = "CB_iva"
        Me.CB_iva.Size = New System.Drawing.Size(240, 24)
        Me.CB_iva.TabIndex = 11
        Me.CB_iva.ValueMember = "codiceiva"
        '
        'BS_modoiva
        '
        Me.BS_modoiva.DataMember = "DT_iva"
        Me.BS_modoiva.DataSource = Me.DS_fattura
        '
        'CB_valuta
        '
        Me.CB_valuta.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_righefattura, "cfa_pulofor", True))
        Me.CB_valuta.DataSource = Me.BS_valuta
        Me.CB_valuta.DisplayMember = "simbolo"
        Me.CB_valuta.FormattingEnabled = True
        Me.CB_valuta.Location = New System.Drawing.Point(109, 53)
        Me.CB_valuta.Name = "CB_valuta"
        Me.CB_valuta.Size = New System.Drawing.Size(82, 24)
        Me.CB_valuta.TabIndex = 12
        Me.CB_valuta.ValueMember = "codicevaluta"
        '
        'BS_valuta
        '
        Me.BS_valuta.DataMember = "DT_valuta"
        Me.BS_valuta.DataSource = Me.DS_fattura
        '
        'CB_destinatari
        '
        Me.CB_destinatari.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_righefattura, "cfa_iddest", True))
        Me.CB_destinatari.DataSource = Me.BS_destinatari
        Me.CB_destinatari.DisplayMember = "locazione"
        Me.CB_destinatari.FormattingEnabled = True
        Me.CB_destinatari.Location = New System.Drawing.Point(111, 3)
        Me.CB_destinatari.Name = "CB_destinatari"
        Me.CB_destinatari.Size = New System.Drawing.Size(240, 24)
        Me.CB_destinatari.TabIndex = 9
        Me.CB_destinatari.ValueMember = "id"
        '
        'BS_destinatari
        '
        Me.BS_destinatari.DataMember = "DT_destinatari"
        Me.BS_destinatari.DataSource = Me.DS_fattura
        '
        'CB_clienti
        '
        Me.CB_clienti.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_righefattura, "cfa_idcli", True))
        Me.CB_clienti.DataSource = Me.BS_cantieri
        Me.CB_clienti.DisplayMember = "societa"
        Me.CB_clienti.FormattingEnabled = True
        Me.CB_clienti.Location = New System.Drawing.Point(111, 119)
        Me.CB_clienti.Name = "CB_clienti"
        Me.CB_clienti.Size = New System.Drawing.Size(240, 24)
        Me.CB_clienti.TabIndex = 8
        Me.CB_clienti.ValueMember = "id"
        '
        'BS_cantieri
        '
        Me.BS_cantieri.DataMember = "DT_cantieri"
        Me.BS_cantieri.DataSource = Me.DS_fattura
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 34)
        Me.Label1.TabIndex = 157
        Me.Label1.Text = "Cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 33)
        Me.Label2.TabIndex = 158
        Me.Label2.Text = "Destinatario"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DG_storico
        '
        Me.DG_storico.AllowUserToAddRows = False
        Me.DG_storico.AllowUserToDeleteRows = False
        Me.DG_storico.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_storico.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_storico.AutoGenerateColumns = False
        Me.DG_storico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_storico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_storico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_storico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn25})
        Me.DG_storico.DataSource = Me.BS_storico
        Me.DG_storico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_storico.Location = New System.Drawing.Point(649, 24)
        Me.DG_storico.Name = "DG_storico"
        Me.DG_storico.ReadOnly = True
        Me.DG_storico.RowHeadersWidth = 4
        Me.DG_storico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_storico.Size = New System.Drawing.Size(610, 150)
        Me.DG_storico.TabIndex = 158
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cfa_fa_num"
        Me.DataGridViewTextBoxColumn3.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Numero"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "cfa_des"
        Me.DataGridViewTextBoxColumn4.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Riga"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "cfa_quanti"
        DataGridViewCellStyle2.Format = "N1"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.FillWeight = 15.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "q.ta"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "cfa_prezzo"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn6.FillWeight = 25.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Prezzo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "totale"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn25.FillWeight = 25.0!
        Me.DataGridViewTextBoxColumn25.HeaderText = "Totale"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'BS_storico
        '
        Me.BS_storico.DataMember = "DT_fattura_righe"
        Me.BS_storico.DataSource = Me.DS_fattura
        '
        'DT_contoreDataGridView
        '
        Me.DT_contoreDataGridView.AllowUserToAddRows = False
        Me.DT_contoreDataGridView.AllowUserToDeleteRows = False
        Me.DT_contoreDataGridView.AllowUserToResizeColumns = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DT_contoreDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DT_contoreDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DT_contoreDataGridView.AutoGenerateColumns = False
        Me.DT_contoreDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DT_contoreDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DT_contoreDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DT_contoreDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.locazione, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.totOre})
        Me.DT_contoreDataGridView.DataSource = Me.BS_contore
        Me.DT_contoreDataGridView.Location = New System.Drawing.Point(649, 418)
        Me.DT_contoreDataGridView.Name = "DT_contoreDataGridView"
        Me.DT_contoreDataGridView.ReadOnly = True
        Me.DT_contoreDataGridView.RowHeadersWidth = 4
        Me.DT_contoreDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DT_contoreDataGridView.Size = New System.Drawing.Size(610, 113)
        Me.DT_contoreDataGridView.TabIndex = 158
        '
        'locazione
        '
        Me.locazione.DataPropertyName = "locazione"
        Me.locazione.FillWeight = 60.0!
        Me.locazione.HeaderText = "locazione"
        Me.locazione.Name = "locazione"
        Me.locazione.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "tipo"
        Me.DataGridViewTextBoxColumn10.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "tipo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn12.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "note"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'totOre
        '
        Me.totOre.DataPropertyName = "totOre"
        DataGridViewCellStyle6.Format = "N1"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.totOre.DefaultCellStyle = DataGridViewCellStyle6
        Me.totOre.FillWeight = 30.0!
        Me.totOre.HeaderText = "Totale"
        Me.totOre.Name = "totOre"
        Me.totOre.ReadOnly = True
        '
        'BS_contore
        '
        Me.BS_contore.DataMember = "DT_contore"
        Me.BS_contore.DataSource = Me.DS_fattura
        '
        'TA_fattura_righe
        '
        Me.TA_fattura_righe.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_fatturaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TA_contore
        '
        Me.TA_contore.ClearBeforeFill = True
        '
        'TA_cantieri
        '
        Me.TA_cantieri.ClearBeforeFill = True
        '
        'TA_destinatari
        '
        Me.TA_destinatari.ClearBeforeFill = True
        '
        'TA_iva
        '
        Me.TA_iva.ClearBeforeFill = True
        '
        'TA_valuta
        '
        Me.TA_valuta.ClearBeforeFill = True
        '
        'TX_ricercastorico
        '
        Me.TX_ricercastorico.BackColor = System.Drawing.SystemColors.Info
        Me.TX_ricercastorico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TX_ricercastorico.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TX_ricercastorico.Location = New System.Drawing.Point(127, 3)
        Me.TX_ricercastorico.Name = "TX_ricercastorico"
        Me.TX_ricercastorico.Size = New System.Drawing.Size(480, 26)
        Me.TX_ricercastorico.TabIndex = 159
        '
        'LB_totale
        '
        Me.LB_totale.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.LB_totale.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LB_totale.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "totale", True))
        Me.LB_totale.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.LB_totale.Location = New System.Drawing.Point(419, 0)
        Me.LB_totale.Name = "LB_totale"
        Me.LB_totale.Size = New System.Drawing.Size(99, 24)
        Me.LB_totale.TabIndex = 160
        Me.LB_totale.Text = "totale"
        Me.LB_totale.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DT_v_ordiniBindingNavigator
        '
        Me.DT_v_ordiniBindingNavigator.AddNewItem = Nothing
        Me.DT_v_ordiniBindingNavigator.AutoSize = False
        Me.DT_v_ordiniBindingNavigator.BindingSource = Me.BS_righefattura
        Me.DT_v_ordiniBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DT_v_ordiniBindingNavigator.DeleteItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_v_ordiniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicerca, Me.TTTestoRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator3, Me.TTPB, Me.TTBTannulla, Me.TT_CB_anno, Me.TT_CB_mese, Me.TTPB_stampa})
        Me.DT_v_ordiniBindingNavigator.Location = New System.Drawing.Point(0, 534)
        Me.DT_v_ordiniBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_v_ordiniBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_v_ordiniBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_v_ordiniBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_v_ordiniBindingNavigator.Name = "DT_v_ordiniBindingNavigator"
        Me.DT_v_ordiniBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_v_ordiniBindingNavigator.Size = New System.Drawing.Size(1262, 79)
        Me.DT_v_ordiniBindingNavigator.TabIndex = 161
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
        Me.TTBTRicerca.Visible = False
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.BackColor = System.Drawing.SystemColors.Info
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(100, 79)
        Me.TTTestoRicerca.ToolTipText = "Immettere l'anno di lavoro"
        Me.TTTestoRicerca.Visible = False
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
        Me.TTBTModifica.Visible = False
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
        Me.TTBTStampa.Visible = False
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
        Me.TTPB.Visible = False
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
        Me.TT_CB_anno.Visible = False
        '
        'TT_CB_mese
        '
        Me.TT_CB_mese.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_mese.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_mese.Name = "TT_CB_mese"
        Me.TT_CB_mese.Size = New System.Drawing.Size(150, 79)
        Me.TT_CB_mese.Visible = False
        '
        'TTPB_stampa
        '
        Me.TTPB_stampa.Name = "TTPB_stampa"
        Me.TTPB_stampa.Size = New System.Drawing.Size(500, 76)
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Label3.Location = New System.Drawing.Point(3, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 28)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Ricerca Storico"
        '
        'BT_presenze
        '
        Me.BT_presenze.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_presenze.Location = New System.Drawing.Point(109, 105)
        Me.BT_presenze.Name = "BT_presenze"
        Me.BT_presenze.Size = New System.Drawing.Size(145, 34)
        Me.BT_presenze.TabIndex = 163
        Me.BT_presenze.Text = "Gestione Presenze"
        Me.BT_presenze.UseVisualStyleBackColor = True
        '
        'DG_destinatari
        '
        Me.DG_destinatari.AllowUserToAddRows = False
        Me.DG_destinatari.AllowUserToDeleteRows = False
        Me.DG_destinatari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_destinatari.AutoGenerateColumns = False
        Me.DG_destinatari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_destinatari.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_destinatari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_destinatari.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocazioneDataGridViewTextBoxColumn, Me.CanoneDataGridViewTextBoxColumn})
        Me.DG_destinatari.DataSource = Me.BS_destinatari
        Me.DG_destinatari.Location = New System.Drawing.Point(649, 244)
        Me.DG_destinatari.Name = "DG_destinatari"
        Me.DG_destinatari.ReadOnly = True
        Me.DG_destinatari.RowHeadersWidth = 4
        Me.DG_destinatari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_destinatari.Size = New System.Drawing.Size(610, 142)
        Me.DG_destinatari.TabIndex = 164
        '
        'LocazioneDataGridViewTextBoxColumn
        '
        Me.LocazioneDataGridViewTextBoxColumn.DataPropertyName = "locazione"
        Me.LocazioneDataGridViewTextBoxColumn.HeaderText = "locazione"
        Me.LocazioneDataGridViewTextBoxColumn.Name = "LocazioneDataGridViewTextBoxColumn"
        Me.LocazioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CanoneDataGridViewTextBoxColumn
        '
        Me.CanoneDataGridViewTextBoxColumn.DataPropertyName = "canone"
        Me.CanoneDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.CanoneDataGridViewTextBoxColumn.HeaderText = "canone"
        Me.CanoneDataGridViewTextBoxColumn.Name = "CanoneDataGridViewTextBoxColumn"
        Me.CanoneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Cod_FETextBox
        '
        Me.Cod_FETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_righefattura, "cod_FE", True))
        Me.Cod_FETextBox.Location = New System.Drawing.Point(1146, 507)
        Me.Cod_FETextBox.Name = "Cod_FETextBox"
        Me.Cod_FETextBox.Size = New System.Drawing.Size(100, 23)
        Me.Cod_FETextBox.TabIndex = 165
        Me.Cod_FETextBox.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 646.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_storico, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_destinatari, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.DT_contoreDataGridView, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1262, 534)
        Me.TableLayoutPanel1.TabIndex = 166
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.TV_ordini, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.PB_ordini, 0, 1)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 418)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.88288!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.11712!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(640, 113)
        Me.TableLayoutPanel7.TabIndex = 171
        '
        'TV_ordini
        '
        Me.TV_ordini.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TV_ordini.Location = New System.Drawing.Point(3, 3)
        Me.TV_ordini.Name = "TV_ordini"
        Me.TV_ordini.Size = New System.Drawing.Size(634, 87)
        Me.TV_ordini.TabIndex = 22
        '
        'PB_ordini
        '
        Me.PB_ordini.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PB_ordini.Location = New System.Drawing.Point(3, 96)
        Me.PB_ordini.Name = "PB_ordini"
        Me.PB_ordini.Size = New System.Drawing.Size(634, 14)
        Me.PB_ordini.TabIndex = 23
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.32787!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.67213!))
        Me.TableLayoutPanel2.Controls.Add(Me.TX_ricercastorico, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(649, 180)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(610, 33)
        Me.TableLayoutPanel2.TabIndex = 159
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(649, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(610, 21)
        Me.Label4.TabIndex = 165
        Me.Label4.Text = "Storico"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.88312!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.11688!))
        Me.TableLayoutPanel3.Controls.Add(Me.Cfa_fa_numTextBox, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Cfa_fa_numLabel, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.OrdineTextBox, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(OrdineLabel, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Cfa_desTextBox, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Cfa_desLabel, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.CB_clienti, 1, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Cfa_quantiLabel, 0, 3)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 24)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 5
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(640, 150)
        Me.TableLayoutPanel3.TabIndex = 167
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 6
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 315.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Cfa_quantiTextBox, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Cfa_prezzoLabel, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Cfa_prezzoTextBox, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Cfa_scontoLabel, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Cfa_scontoTextBox, 4, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.LB_totale, 5, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(109, 88)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(530, 27)
        Me.TableLayoutPanel4.TabIndex = 8
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.88312!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.11688!))
        Me.TableLayoutPanel5.Controls.Add(Me.CB_destinatari, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 180)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(640, 33)
        Me.TableLayoutPanel5.TabIndex = 168
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 2
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33333!))
        Me.TableLayoutPanel6.Controls.Add(Tipo_rigaLabel, 0, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.CB_tiposervizio, 1, 0)
        Me.TableLayoutPanel6.Controls.Add(Tipo_ivaLabel, 0, 1)
        Me.TableLayoutPanel6.Controls.Add(Me.CB_iva, 1, 1)
        Me.TableLayoutPanel6.Controls.Add(Cfa_puloforLabel, 0, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.CB_valuta, 1, 2)
        Me.TableLayoutPanel6.Controls.Add(Me.BT_presenze, 1, 4)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(3, 244)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 5
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(640, 142)
        Me.TableLayoutPanel6.TabIndex = 169
        '
        'Label5
        '
        Me.Label5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(649, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(610, 26)
        Me.Label5.TabIndex = 166
        Me.Label5.Text = "Presenze inserite"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(649, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(610, 25)
        Me.Label6.TabIndex = 170
        Me.Label6.Text = "Righe Preimpostate"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(3, 389)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(640, 26)
        Me.Label7.TabIndex = 172
        Me.Label7.Text = "Riepilogo Ordine Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DS_generatore_fatture
        '
        Me.DS_generatore_fatture.DataSetName = "DS_generatore_fatture"
        Me.DS_generatore_fatture.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FRM_mod_rigafattura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1262, 613)
        Me.ControlBox = False
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Cod_FELabel)
        Me.Controls.Add(Me.Cod_FETextBox)
        Me.Controls.Add(Me.DT_v_ordiniBindingNavigator)
        Me.Controls.Add(Cfa_ivaLabel)
        Me.Controls.Add(Me.Cfa_ivaTextBox)
        Me.Controls.Add(Cfa_iddestLabel)
        Me.Controls.Add(Me.Cfa_iddestTextBox)
        Me.Controls.Add(Cfa_idcliLabel)
        Me.Controls.Add(Me.Cfa_idcliTextBox)
        Me.Controls.Add(Me.Cfa_puloforTextBox)
        Me.Controls.Add(Cfa_rcLabel)
        Me.Controls.Add(Me.Cfa_rcTextBox)
        Me.Controls.Add(Cfa_tipoLabel)
        Me.Controls.Add(Me.Cfa_tipoTextBox)
        Me.Controls.Add(SimboloLabel)
        Me.Controls.Add(Me.SimboloTextBox)
        Me.Controls.Add(Me.Tipo_rigaTextBox)
        Me.Controls.Add(Me.Tipo_ivaTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRM_mod_rigafattura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modifica Righe Fattura"
        CType(Me.BS_righefattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_tiposervizio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_modoiva, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_valuta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_destinatari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_cantieri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_storico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_storico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_contoreDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_contore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_v_ordiniBindingNavigator.ResumeLayout(False)
        Me.DT_v_ordiniBindingNavigator.PerformLayout()
        CType(Me.DG_destinatari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel6.PerformLayout()
        CType(Me.DS_generatore_fatture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OrdineTextBox As TextBox
    Friend WithEvents Cfa_fa_numTextBox As TextBox
    Friend WithEvents Cfa_desTextBox As TextBox
    Friend WithEvents Cfa_quantiTextBox As TextBox
    Friend WithEvents Cfa_prezzoTextBox As TextBox
    Friend WithEvents Cfa_scontoTextBox As TextBox
    Friend WithEvents Cfa_ivaTextBox As TextBox
    Friend WithEvents Cfa_iddestTextBox As TextBox
    Friend WithEvents Cfa_idcliTextBox As TextBox
    Friend WithEvents Cfa_puloforTextBox As TextBox
    Friend WithEvents Cfa_rcTextBox As TextBox
    Friend WithEvents Cfa_tipoTextBox As TextBox
    Friend WithEvents SimboloTextBox As TextBox
    Friend WithEvents Tipo_rigaTextBox As TextBox
    Friend WithEvents Tipo_ivaTextBox As TextBox
    Friend WithEvents DS_fattura As DS_fattura
    Friend WithEvents CB_tiposervizio As ComboBox
    Friend WithEvents CB_iva As ComboBox
    Friend WithEvents CB_valuta As ComboBox
    Friend WithEvents CB_destinatari As ComboBox
    Friend WithEvents CB_clienti As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BS_storico As BindingSource
    Friend WithEvents TA_fattura_righe As DS_fatturaTableAdapters.TA_fattura_righe
    Friend WithEvents TableAdapterManager As DS_fatturaTableAdapters.TableAdapterManager
    Friend WithEvents DG_storico As DataGridView
    Friend WithEvents BS_contore As BindingSource
    Friend WithEvents TA_contore As DS_fatturaTableAdapters.TA_contore
    Friend WithEvents DT_contoreDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents locazione As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents totOre As DataGridViewTextBoxColumn
    Friend WithEvents BS_cantieri As BindingSource
    Friend WithEvents TA_cantieri As DS_fatturaTableAdapters.TA_cantieri
    Friend WithEvents BS_destinatari As BindingSource
    Friend WithEvents TA_destinatari As DS_fatturaTableAdapters.TA_destinatari
    Friend WithEvents BS_righefattura As BindingSource
    Friend WithEvents BS_tiposervizio As BindingSource
    Friend WithEvents DT_tipo_servizioTableAdapter As DS_fatturaTableAdapters.TA_tipo_servizio
    Friend WithEvents BS_modoiva As BindingSource
    Friend WithEvents TA_iva As DS_fatturaTableAdapters.TA_iva
    Friend WithEvents BS_valuta As BindingSource
    Friend WithEvents TA_valuta As DS_fatturaTableAdapters.TA_valuta
    Friend WithEvents TX_ricercastorico As TextBox
    Friend WithEvents LB_totale As Label
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
    Friend WithEvents TTPB_stampa As ToolStripProgressBar
    Friend WithEvents Label3 As Label
    Friend WithEvents BT_presenze As Button
    Friend WithEvents DG_destinatari As DataGridView
    Friend WithEvents LocazioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CanoneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Cod_FETextBox As TextBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents Label6 As Label
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents TV_ordini As TreeView
    Friend WithEvents PB_ordini As ProgressBar
    Friend WithEvents Label7 As Label
    Friend WithEvents DS_generatore_fatture As DS_generatore_fatture
End Class
