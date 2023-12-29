<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCantieriRese
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCantieriRese))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LB_ore = New System.Windows.Forms.Label()
        Me.LB_resa = New System.Windows.Forms.Label()
        Me.LB_etichettaresa = New System.Windows.Forms.Label()
        Me.LB_importo = New System.Windows.Forms.Label()
        Me.DG_clienti = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_clienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_clienti = New PoP2.Comuni.DS_clienti()
        Me.TA_clienti = New PoP2.Comuni.DS_clientiTableAdapters.TA_cantieri_new()
        Me.TA_ClientiFatturanti = New PoP2.Comuni.DS_clientiTableAdapters.TA_ClientiFatturanti()
        Me.TableAdapterManager1 = New PoP2.Comuni.DS_clientiTableAdapters.TableAdapterManager()
        Me.BS_rese = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_fattura = New PoP2.Comuni.DS_fattura()
        Me.BS_ore = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_oreR = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_ore = New PoP2.Comuni.DS_fatturaTableAdapters.TA_ore()
        Me.TableAdapterManager = New PoP2.Comuni.DS_fatturaTableAdapters.TableAdapterManager()
        Me.TA_rese = New PoP2.Comuni.DS_fatturaTableAdapters.TA_rese()
        Me.TA_oreR = New PoP2.Comuni.DS_fatturaTableAdapters.TA_oreR()
        Me.CB_selezionatipofattura = New System.Windows.Forms.ComboBox()
        Me.DSfatturatipo = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_fattura_tipo = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura_tipo()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbReseCliente = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGWfatturato = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbGraficoResa = New System.Windows.Forms.TabPage()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ckTipoFatturato = New System.Windows.Forms.CheckBox()
        Me.cmbAnno = New System.Windows.Forms.ComboBox()
        Me.cmbTipoOre = New System.Windows.Forms.ComboBox()
        Me.DS_ag = New PoP2.Comuni.DS_ag()
        Me.DtTipoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaTipo = New PoP2.Comuni.DS_agTableAdapters.taTipo()
        Me.lbFiltraggio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.DTtipologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_tipologia = New PoP2.Comuni.DS_utentiTableAdapters.TA_tipologia()
        Me.DGWCdettaglio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMese = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCTotaleImporto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCTotaleOre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCresaOraria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DG_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_rese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_ore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_oreR, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSfatturatipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tbReseCliente.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        CType(Me.DGWfatturato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbGraficoResa.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtTipoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTtipologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.38628!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.61372!))
        Me.TableLayoutPanel1.Controls.Add(Me.LB_ore, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_resa, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_etichettaresa, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_importo, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(439, 499)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(554, 63)
        Me.TableLayoutPanel1.TabIndex = 7
        '
        'LB_ore
        '
        Me.LB_ore.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LB_ore.AutoSize = True
        Me.LB_ore.Location = New System.Drawing.Point(331, 7)
        Me.LB_ore.Name = "LB_ore"
        Me.LB_ore.Size = New System.Drawing.Size(35, 20)
        Me.LB_ore.TabIndex = 4
        Me.LB_ore.Text = "Ore"
        '
        'LB_resa
        '
        Me.LB_resa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LB_resa.AutoSize = True
        Me.LB_resa.Location = New System.Drawing.Point(332, 38)
        Me.LB_resa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LB_resa.Name = "LB_resa"
        Me.LB_resa.Size = New System.Drawing.Size(14, 20)
        Me.LB_resa.TabIndex = 2
        Me.LB_resa.Text = "-"
        '
        'LB_etichettaresa
        '
        Me.LB_etichettaresa.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LB_etichettaresa.AutoSize = True
        Me.LB_etichettaresa.Location = New System.Drawing.Point(3, 38)
        Me.LB_etichettaresa.Name = "LB_etichettaresa"
        Me.LB_etichettaresa.Size = New System.Drawing.Size(191, 20)
        Me.LB_etichettaresa.TabIndex = 5
        Me.LB_etichettaresa.Text = "Resa economica Annuale"
        '
        'LB_importo
        '
        Me.LB_importo.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LB_importo.AutoSize = True
        Me.LB_importo.Location = New System.Drawing.Point(3, 7)
        Me.LB_importo.Name = "LB_importo"
        Me.LB_importo.Size = New System.Drawing.Size(75, 20)
        Me.LB_importo.TabIndex = 3
        Me.LB_importo.Text = "Fatturato"
        '
        'DG_clienti
        '
        Me.DG_clienti.AllowUserToAddRows = False
        Me.DG_clienti.AllowUserToDeleteRows = False
        Me.DG_clienti.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DG_clienti.AutoGenerateColumns = False
        Me.DG_clienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clienti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3})
        Me.DG_clienti.DataSource = Me.BS_clienti
        Me.DG_clienti.Location = New System.Drawing.Point(12, 12)
        Me.DG_clienti.Name = "DG_clienti"
        Me.DG_clienti.ReadOnly = True
        Me.DG_clienti.RowHeadersWidth = 4
        Me.DG_clienti.Size = New System.Drawing.Size(421, 443)
        Me.DG_clienti.TabIndex = 8
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "societa"
        Me.DataGridViewTextBoxColumn3.HeaderText = "societa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'BS_clienti
        '
        Me.BS_clienti.DataMember = "DT_ClientiFatturanti"
        Me.BS_clienti.DataSource = Me.DS_clienti
        '
        'DS_clienti
        '
        Me.DS_clienti.DataSetName = "DS_clienti"
        Me.DS_clienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_clienti
        '
        Me.TA_clienti.ClearBeforeFill = True
        '
        'TA_ClientiFatturanti
        '
        Me.TA_ClientiFatturanti.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PoP2.Comuni.DS_clientiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BS_rese
        '
        Me.BS_rese.DataMember = "DT_rese"
        Me.BS_rese.DataSource = Me.DS_fattura
        '
        'DS_fattura
        '
        Me.DS_fattura.DataSetName = "DS_fattura"
        Me.DS_fattura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_ore
        '
        Me.BS_ore.DataMember = "DT_ore"
        Me.BS_ore.DataSource = Me.DS_fattura
        '
        'BS_oreR
        '
        Me.BS_oreR.DataMember = "DT_oreR"
        Me.BS_oreR.DataSource = Me.DS_fattura
        '
        'TA_ore
        '
        Me.TA_ore.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_fatturaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TA_rese
        '
        Me.TA_rese.ClearBeforeFill = True
        '
        'TA_oreR
        '
        Me.TA_oreR.ClearBeforeFill = True
        '
        'CB_selezionatipofattura
        '
        Me.CB_selezionatipofattura.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CB_selezionatipofattura.DataSource = Me.DSfatturatipo
        Me.CB_selezionatipofattura.DisplayMember = "descrizione"
        Me.CB_selezionatipofattura.FormattingEnabled = True
        Me.CB_selezionatipofattura.Location = New System.Drawing.Point(121, 536)
        Me.CB_selezionatipofattura.Name = "CB_selezionatipofattura"
        Me.CB_selezionatipofattura.Size = New System.Drawing.Size(181, 28)
        Me.CB_selezionatipofattura.TabIndex = 11
        Me.CB_selezionatipofattura.ValueMember = "id"
        '
        'DSfatturatipo
        '
        Me.DSfatturatipo.DataMember = "DT_fattura_tipo"
        Me.DSfatturatipo.DataSource = Me.DS_fattura
        '
        'TA_fattura_tipo
        '
        Me.TA_fattura_tipo.ClearBeforeFill = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbReseCliente)
        Me.TabControl1.Controls.Add(Me.tbGraficoResa)
        Me.TabControl1.Location = New System.Drawing.Point(439, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(811, 450)
        Me.TabControl1.TabIndex = 12
        '
        'tbReseCliente
        '
        Me.tbReseCliente.Controls.Add(Me.TableLayoutPanel4)
        Me.tbReseCliente.Location = New System.Drawing.Point(4, 29)
        Me.tbReseCliente.Name = "tbReseCliente"
        Me.tbReseCliente.Padding = New System.Windows.Forms.Padding(3)
        Me.tbReseCliente.Size = New System.Drawing.Size(803, 417)
        Me.tbReseCliente.TabIndex = 1
        Me.tbReseCliente.Text = "Elenco Rese"
        Me.tbReseCliente.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.95093!))
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(10, 31)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(783, 373)
        Me.TableLayoutPanel4.TabIndex = 148
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.TableLayoutPanel7, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(781, 371)
        Me.TableLayoutPanel5.TabIndex = 4
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel7.ColumnCount = 1
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.DGWfatturato, 0, 1)
        Me.TableLayoutPanel7.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel7.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 2
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(779, 369)
        Me.TableLayoutPanel7.TabIndex = 6
        '
        'DGWfatturato
        '
        Me.DGWfatturato.AllowUserToAddRows = False
        Me.DGWfatturato.AllowUserToDeleteRows = False
        Me.DGWfatturato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGWfatturato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGWfatturato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGWfatturato.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWCdettaglio, Me.DGWCMese, Me.DGWCTotaleImporto, Me.DGWCTotaleOre, Me.DGWCresaOraria})
        Me.DGWfatturato.Location = New System.Drawing.Point(1, 30)
        Me.DGWfatturato.Margin = New System.Windows.Forms.Padding(1)
        Me.DGWfatturato.Name = "DGWfatturato"
        Me.DGWfatturato.ReadOnly = True
        Me.DGWfatturato.RowHeadersWidth = 4
        Me.DGWfatturato.Size = New System.Drawing.Size(777, 338)
        Me.DGWfatturato.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(773, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fatturato Periodo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbGraficoResa
        '
        Me.tbGraficoResa.Controls.Add(Me.Chart1)
        Me.tbGraficoResa.Location = New System.Drawing.Point(4, 29)
        Me.tbGraficoResa.Name = "tbGraficoResa"
        Me.tbGraficoResa.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGraficoResa.Size = New System.Drawing.Size(803, 417)
        Me.tbGraficoResa.TabIndex = 0
        Me.tbGraficoResa.Text = "Grafico Riepilogativo"
        Me.tbGraficoResa.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        Me.Chart1.BorderSkin.BackColor = System.Drawing.Color.LightGray
        Me.Chart1.BorderSkin.BorderColor = System.Drawing.Color.Gainsboro
        Me.Chart1.BorderSkin.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        Me.Chart1.BorderSkin.BorderWidth = 0
        Me.Chart1.BorderSkin.SkinStyle = System.Windows.Forms.DataVisualization.Charting.BorderSkinStyle.Raised
        ChartArea1.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.LightGray
        ChartArea1.AxisX.TitleFont = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold)
        ChartArea1.AxisY.ScaleBreakStyle.LineColor = System.Drawing.Color.Gainsboro
        ChartArea1.BorderColor = System.Drawing.Color.Gray
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Alignment = System.Drawing.StringAlignment.Center
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(3, 3)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series3"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(797, 411)
        Me.Chart1.TabIndex = 11
        Me.Chart1.Text = "Chart1"
        '
        'ckTipoFatturato
        '
        Me.ckTipoFatturato.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckTipoFatturato.AutoSize = True
        Me.ckTipoFatturato.Location = New System.Drawing.Point(12, 461)
        Me.ckTipoFatturato.Name = "ckTipoFatturato"
        Me.ckTipoFatturato.Size = New System.Drawing.Size(180, 24)
        Me.ckTipoFatturato.TabIndex = 13
        Me.ckTipoFatturato.Text = "Separo tipo Fatturato"
        Me.ckTipoFatturato.UseVisualStyleBackColor = True
        '
        'cmbAnno
        '
        Me.cmbAnno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAnno.FormattingEnabled = True
        Me.cmbAnno.Location = New System.Drawing.Point(12, 536)
        Me.cmbAnno.Name = "cmbAnno"
        Me.cmbAnno.Size = New System.Drawing.Size(103, 28)
        Me.cmbAnno.TabIndex = 14
        '
        'cmbTipoOre
        '
        Me.cmbTipoOre.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmbTipoOre.DataSource = Me.DTtipologiaBindingSource
        Me.cmbTipoOre.DisplayMember = "descrizione"
        Me.cmbTipoOre.FormattingEnabled = True
        Me.cmbTipoOre.Location = New System.Drawing.Point(308, 536)
        Me.cmbTipoOre.Name = "cmbTipoOre"
        Me.cmbTipoOre.Size = New System.Drawing.Size(124, 28)
        Me.cmbTipoOre.TabIndex = 15
        Me.cmbTipoOre.ValueMember = "id_tipo"
        '
        'DS_ag
        '
        Me.DS_ag.DataSetName = "DS_ag"
        Me.DS_ag.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DtTipoBindingSource
        '
        Me.DtTipoBindingSource.DataMember = "dtTipo"
        Me.DtTipoBindingSource.DataSource = Me.DS_ag
        '
        'TaTipo
        '
        Me.TaTipo.ClearBeforeFill = True
        '
        'lbFiltraggio
        '
        Me.lbFiltraggio.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbFiltraggio.AutoSize = True
        Me.lbFiltraggio.Location = New System.Drawing.Point(129, 516)
        Me.lbFiltraggio.Name = "lbFiltraggio"
        Me.lbFiltraggio.Size = New System.Drawing.Size(169, 20)
        Me.lbFiltraggio.TabIndex = 16
        Me.lbFiltraggio.Text = "Seleziona Tipo Fattura"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 513)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Tipo Presenza"
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DTtipologiaBindingSource
        '
        Me.DTtipologiaBindingSource.DataMember = "DT_tipologia"
        Me.DTtipologiaBindingSource.DataSource = Me.DS_utenti
        '
        'TA_tipologia
        '
        Me.TA_tipologia.ClearBeforeFill = True
        '
        'DGWCdettaglio
        '
        Me.DGWCdettaglio.HeaderText = "Dettaglio"
        Me.DGWCdettaglio.Name = "DGWCdettaglio"
        Me.DGWCdettaglio.ReadOnly = True
        '
        'DGWCMese
        '
        Me.DGWCMese.FillWeight = 60.0!
        Me.DGWCMese.HeaderText = "Mese"
        Me.DGWCMese.Name = "DGWCMese"
        Me.DGWCMese.ReadOnly = True
        '
        'DGWCTotaleImporto
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DGWCTotaleImporto.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGWCTotaleImporto.FillWeight = 80.0!
        Me.DGWCTotaleImporto.HeaderText = "Importo Fattura"
        Me.DGWCTotaleImporto.Name = "DGWCTotaleImporto"
        Me.DGWCTotaleImporto.ReadOnly = True
        '
        'DGWCTotaleOre
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DGWCTotaleOre.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGWCTotaleOre.FillWeight = 60.0!
        Me.DGWCTotaleOre.HeaderText = "Ore Mensili"
        Me.DGWCTotaleOre.Name = "DGWCTotaleOre"
        Me.DGWCTotaleOre.ReadOnly = True
        '
        'DGWCresaOraria
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DGWCresaOraria.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGWCresaOraria.FillWeight = 60.0!
        Me.DGWCresaOraria.HeaderText = "Resa Oraria"
        Me.DGWCresaOraria.Name = "DGWCresaOraria"
        Me.DGWCresaOraria.ReadOnly = True
        '
        'frmCantieriRese
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 570)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbFiltraggio)
        Me.Controls.Add(Me.cmbTipoOre)
        Me.Controls.Add(Me.cmbAnno)
        Me.Controls.Add(Me.ckTipoFatturato)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.CB_selezionatipofattura)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.DG_clienti)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCantieriRese"
        Me.Text = "Riepilogo Rese Cliente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DG_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_rese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_ore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_oreR, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSfatturatipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tbReseCliente.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel7.PerformLayout()
        CType(Me.DGWfatturato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbGraficoResa.ResumeLayout(False)
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtTipoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTtipologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_fattura As DS_fattura
    Friend WithEvents BS_ore As BindingSource
    Friend WithEvents TA_ore As DS_fatturaTableAdapters.TA_ore
    Friend WithEvents TableAdapterManager As DS_fatturaTableAdapters.TableAdapterManager
    Friend WithEvents BS_rese As BindingSource
    Friend WithEvents TA_rese As DS_fatturaTableAdapters.TA_rese
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LB_resa As Label
    Friend WithEvents BS_oreR As BindingSource
    Friend WithEvents TA_oreR As DS_fatturaTableAdapters.TA_oreR
    Friend WithEvents DS_clienti As DS_clienti
    Friend WithEvents BS_clienti As BindingSource
    Friend WithEvents TA_clienti As DS_clientiTableAdapters.TA_cantieri_new
    Friend WithEvents DG_clienti As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents LB_etichettaresa As Label
    Friend WithEvents LB_ore As Label
    Friend WithEvents LB_importo As Label
    Friend WithEvents TA_ClientiFatturanti As DS_clientiTableAdapters.TA_ClientiFatturanti
    Friend WithEvents TableAdapterManager1 As DS_clientiTableAdapters.TableAdapterManager
    Friend WithEvents CB_selezionatipofattura As ComboBox
    Friend WithEvents DSfatturatipo As BindingSource
    Friend WithEvents TA_fattura_tipo As DS_fatturaTableAdapters.TA_fattura_tipo
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tbGraficoResa As TabPage
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents tbReseCliente As TabPage
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents DGWfatturato As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents ckTipoFatturato As CheckBox
    Friend WithEvents cmbAnno As ComboBox
    Friend WithEvents cmbTipoOre As ComboBox
    Friend WithEvents DS_ag As DS_ag
    Friend WithEvents DtTipoBindingSource As BindingSource
    Friend WithEvents TaTipo As DS_agTableAdapters.taTipo
    Friend WithEvents lbFiltraggio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents DTtipologiaBindingSource As BindingSource
    Friend WithEvents TA_tipologia As DS_utentiTableAdapters.TA_tipologia
    Friend WithEvents DGWCdettaglio As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMese As DataGridViewTextBoxColumn
    Friend WithEvents DGWCTotaleImporto As DataGridViewTextBoxColumn
    Friend WithEvents DGWCTotaleOre As DataGridViewTextBoxColumn
    Friend WithEvents DGWCresaOraria As DataGridViewTextBoxColumn
End Class
