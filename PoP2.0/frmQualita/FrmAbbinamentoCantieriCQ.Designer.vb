<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAbbinamentoCantieriCQ
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAbbinamentoCantieriCQ))
        Me.TmpCQBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsControlloQualita = New PoP2.Comuni.dsControlloQualita()
        Me.dgwCliente = New System.Windows.Forms.DataGridView()
        Me.dgwcClientiID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcClientiSocieta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsClienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.relClientiDestinatari = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwDestinatarioArea = New System.Windows.Forms.DataGridView()
        Me.dgwcID_Area = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcDescrizioneArea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsArea = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwDettaglio = New System.Windows.Forms.DataGridView()
        Me.dgwcDettaglioID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcDettaglioControllo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgwcDettaglioIDdettaglio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcIDAbbinamentoTMP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsDettaglio = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwDettaglioClienti = New System.Windows.Forms.DataGridView()
        Me.dgwcidLocazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcLocazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DtClientidtDestinatariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TCSchedaElenco = New System.Windows.Forms.TabControl()
        Me.tpDettaglioInterventi = New System.Windows.Forms.TabPage()
        Me.dgwElencoCheckUp = New System.Windows.Forms.DataGridView()
        Me.dgwcDestinatario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcidDest = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcData = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcOperatore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tpReportCheckList = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.DT_BarraNavigazione = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTAggiorna = New System.Windows.Forms.ToolStripButton()
        Me.tsbStampa = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tbPresenzaControlli = New System.Windows.Forms.ToolStripProgressBar()
        Me.tsbEliminaControllo = New System.Windows.Forms.ToolStripSplitButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.bsControlloQualita = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaClienti = New PoP2.Comuni.dsControlloQualitaTableAdapters.taClienti()
        Me.TaDestinatari = New PoP2.Comuni.dsControlloQualitaTableAdapters.taDestinatari()
        Me.bsAbbinamento = New System.Windows.Forms.BindingSource(Me.components)
        Me.DtCqAbbinaAreaDettaglioDestinatario = New PoP2.Comuni.dsControlloQualitaTableAdapters.dtCqAbbinaAreaDettaglioDestinatario()
        Me.TableAdapterManager = New PoP2.Comuni.dsControlloQualitaTableAdapters.TableAdapterManager()
        Me.TaCqCategorie = New PoP2.Comuni.dsControlloQualitaTableAdapters.taCqCategorie()
        Me.DtCqDettaglio = New PoP2.Comuni.dsControlloQualitaTableAdapters.dtCqDettaglio()
        Me.taCq = New PoP2.Comuni.dsControlloQualitaTableAdapters.taCq()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        CType(Me.TmpCQBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsControlloQualita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.relClientiDestinatari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwDestinatarioArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsDettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwDettaglioClienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtClientidtDestinatariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TCSchedaElenco.SuspendLayout()
        Me.tpDettaglioInterventi.SuspendLayout()
        CType(Me.dgwElencoCheckUp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReportCheckList.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.DT_BarraNavigazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_BarraNavigazione.SuspendLayout()
        CType(Me.bsControlloQualita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsAbbinamento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TmpCQBindingSource
        '
        Me.TmpCQBindingSource.DataMember = "tmpCQ"
        Me.TmpCQBindingSource.DataSource = Me.DsControlloQualita
        '
        'DsControlloQualita
        '
        Me.DsControlloQualita.DataSetName = "dsControlloQualita"
        Me.DsControlloQualita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgwCliente
        '
        Me.dgwCliente.AllowUserToAddRows = False
        Me.dgwCliente.AllowUserToDeleteRows = False
        Me.dgwCliente.AllowUserToOrderColumns = True
        Me.dgwCliente.AutoGenerateColumns = False
        Me.dgwCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcClientiID, Me.dgwcClientiSocieta})
        Me.dgwCliente.DataSource = Me.bsClienti
        Me.dgwCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwCliente.Location = New System.Drawing.Point(4, 4)
        Me.dgwCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwCliente.Name = "dgwCliente"
        Me.dgwCliente.ReadOnly = True
        Me.dgwCliente.RowHeadersVisible = False
        Me.dgwCliente.Size = New System.Drawing.Size(266, 309)
        Me.dgwCliente.TabIndex = 0
        '
        'dgwcClientiID
        '
        Me.dgwcClientiID.DataPropertyName = "id"
        Me.dgwcClientiID.FillWeight = 20.0!
        Me.dgwcClientiID.HeaderText = "id"
        Me.dgwcClientiID.Name = "dgwcClientiID"
        Me.dgwcClientiID.ReadOnly = True
        Me.dgwcClientiID.Visible = False
        '
        'dgwcClientiSocieta
        '
        Me.dgwcClientiSocieta.DataPropertyName = "societa"
        Me.dgwcClientiSocieta.HeaderText = "societa"
        Me.dgwcClientiSocieta.Name = "dgwcClientiSocieta"
        Me.dgwcClientiSocieta.ReadOnly = True
        '
        'bsClienti
        '
        Me.bsClienti.DataMember = "dtClienti"
        Me.bsClienti.DataSource = Me.DsControlloQualita
        '
        'relClientiDestinatari
        '
        Me.relClientiDestinatari.DataMember = "dtClienti_dtDestinatari"
        Me.relClientiDestinatari.DataSource = Me.bsClienti
        '
        'dgwDestinatarioArea
        '
        Me.dgwDestinatarioArea.AllowUserToAddRows = False
        Me.dgwDestinatarioArea.AllowUserToDeleteRows = False
        Me.dgwDestinatarioArea.AllowUserToOrderColumns = True
        Me.dgwDestinatarioArea.AutoGenerateColumns = False
        Me.dgwDestinatarioArea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwDestinatarioArea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDestinatarioArea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcID_Area, Me.dgwcDescrizioneArea})
        Me.dgwDestinatarioArea.DataSource = Me.bsArea
        Me.dgwDestinatarioArea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwDestinatarioArea.Location = New System.Drawing.Point(284, 4)
        Me.dgwDestinatarioArea.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwDestinatarioArea.Name = "dgwDestinatarioArea"
        Me.dgwDestinatarioArea.ReadOnly = True
        Me.dgwDestinatarioArea.RowHeadersVisible = False
        Me.dgwDestinatarioArea.Size = New System.Drawing.Size(272, 633)
        Me.dgwDestinatarioArea.TabIndex = 4
        '
        'dgwcID_Area
        '
        Me.dgwcID_Area.DataPropertyName = "id"
        Me.dgwcID_Area.HeaderText = "id"
        Me.dgwcID_Area.Name = "dgwcID_Area"
        Me.dgwcID_Area.ReadOnly = True
        Me.dgwcID_Area.Visible = False
        '
        'dgwcDescrizioneArea
        '
        Me.dgwcDescrizioneArea.DataPropertyName = "descrizione"
        Me.dgwcDescrizioneArea.HeaderText = "descrizione"
        Me.dgwcDescrizioneArea.Name = "dgwcDescrizioneArea"
        Me.dgwcDescrizioneArea.ReadOnly = True
        '
        'bsArea
        '
        Me.bsArea.DataMember = "dtCqArea"
        Me.bsArea.DataSource = Me.DsControlloQualita
        '
        'dgwDettaglio
        '
        Me.dgwDettaglio.AutoGenerateColumns = False
        Me.dgwDettaglio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwDettaglio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDettaglio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcDettaglioID, Me.dgwcDettaglioControllo, Me.dgwcDettaglioIDdettaglio, Me.dgwcIDAbbinamentoTMP})
        Me.dgwDettaglio.DataSource = Me.bsDettaglio
        Me.dgwDettaglio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwDettaglio.Location = New System.Drawing.Point(564, 4)
        Me.dgwDettaglio.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwDettaglio.Name = "dgwDettaglio"
        Me.dgwDettaglio.Size = New System.Drawing.Size(272, 633)
        Me.dgwDettaglio.TabIndex = 5
        '
        'dgwcDettaglioID
        '
        Me.dgwcDettaglioID.DataPropertyName = "id"
        Me.dgwcDettaglioID.HeaderText = "id"
        Me.dgwcDettaglioID.Name = "dgwcDettaglioID"
        Me.dgwcDettaglioID.Visible = False
        '
        'dgwcDettaglioControllo
        '
        Me.dgwcDettaglioControllo.FalseValue = "False"
        Me.dgwcDettaglioControllo.FillWeight = 15.0!
        Me.dgwcDettaglioControllo.HeaderText = "Aggiungi"
        Me.dgwcDettaglioControllo.Name = "dgwcDettaglioControllo"
        Me.dgwcDettaglioControllo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcDettaglioControllo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgwcDettaglioControllo.TrueValue = "True"
        '
        'dgwcDettaglioIDdettaglio
        '
        Me.dgwcDettaglioIDdettaglio.DataPropertyName = "nome"
        Me.dgwcDettaglioIDdettaglio.HeaderText = "Dettaglio Operazione"
        Me.dgwcDettaglioIDdettaglio.Name = "dgwcDettaglioIDdettaglio"
        Me.dgwcDettaglioIDdettaglio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'dgwcIDAbbinamentoTMP
        '
        Me.dgwcIDAbbinamentoTMP.HeaderText = "idAbbinamento"
        Me.dgwcIDAbbinamentoTMP.Name = "dgwcIDAbbinamentoTMP"
        Me.dgwcIDAbbinamentoTMP.Visible = False
        '
        'bsDettaglio
        '
        Me.bsDettaglio.DataMember = "dtCqDettaglio"
        Me.bsDettaglio.DataSource = Me.DsControlloQualita
        '
        'dgwDettaglioClienti
        '
        Me.dgwDettaglioClienti.AllowUserToAddRows = False
        Me.dgwDettaglioClienti.AllowUserToDeleteRows = False
        Me.dgwDettaglioClienti.AllowUserToOrderColumns = True
        Me.dgwDettaglioClienti.AutoGenerateColumns = False
        Me.dgwDettaglioClienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwDettaglioClienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDettaglioClienti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcidLocazione, Me.dgwcLocazione})
        Me.dgwDettaglioClienti.DataSource = Me.DtClientidtDestinatariBindingSource
        Me.dgwDettaglioClienti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwDettaglioClienti.Location = New System.Drawing.Point(4, 321)
        Me.dgwDettaglioClienti.Margin = New System.Windows.Forms.Padding(4)
        Me.dgwDettaglioClienti.Name = "dgwDettaglioClienti"
        Me.dgwDettaglioClienti.ReadOnly = True
        Me.dgwDettaglioClienti.RowHeadersVisible = False
        Me.dgwDettaglioClienti.Size = New System.Drawing.Size(266, 310)
        Me.dgwDettaglioClienti.TabIndex = 7
        '
        'dgwcidLocazione
        '
        Me.dgwcidLocazione.DataPropertyName = "id"
        Me.dgwcidLocazione.FillWeight = 20.0!
        Me.dgwcidLocazione.HeaderText = "id"
        Me.dgwcidLocazione.Name = "dgwcidLocazione"
        Me.dgwcidLocazione.ReadOnly = True
        Me.dgwcidLocazione.Visible = False
        '
        'dgwcLocazione
        '
        Me.dgwcLocazione.DataPropertyName = "locazione"
        Me.dgwcLocazione.HeaderText = "Destinatario"
        Me.dgwcLocazione.Name = "dgwcLocazione"
        Me.dgwcLocazione.ReadOnly = True
        '
        'DtClientidtDestinatariBindingSource
        '
        Me.DtClientidtDestinatariBindingSource.DataMember = "dtClienti_dtDestinatari"
        Me.DtClientidtDestinatariBindingSource.DataSource = Me.bsClienti
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TCSchedaElenco, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgwDestinatarioArea, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgwDettaglio, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 12)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1401, 641)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'TCSchedaElenco
        '
        Me.TCSchedaElenco.Controls.Add(Me.tpDettaglioInterventi)
        Me.TCSchedaElenco.Controls.Add(Me.tpReportCheckList)
        Me.TCSchedaElenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TCSchedaElenco.Location = New System.Drawing.Point(843, 3)
        Me.TCSchedaElenco.Name = "TCSchedaElenco"
        Me.TCSchedaElenco.SelectedIndex = 0
        Me.TCSchedaElenco.Size = New System.Drawing.Size(555, 635)
        Me.TCSchedaElenco.TabIndex = 150
        '
        'tpDettaglioInterventi
        '
        Me.tpDettaglioInterventi.Controls.Add(Me.dgwElencoCheckUp)
        Me.tpDettaglioInterventi.Location = New System.Drawing.Point(4, 25)
        Me.tpDettaglioInterventi.Name = "tpDettaglioInterventi"
        Me.tpDettaglioInterventi.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDettaglioInterventi.Size = New System.Drawing.Size(547, 606)
        Me.tpDettaglioInterventi.TabIndex = 1
        Me.tpDettaglioInterventi.Text = "Elenco Check List"
        Me.tpDettaglioInterventi.UseVisualStyleBackColor = True
        '
        'dgwElencoCheckUp
        '
        Me.dgwElencoCheckUp.AllowUserToAddRows = False
        Me.dgwElencoCheckUp.AllowUserToDeleteRows = False
        Me.dgwElencoCheckUp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwElencoCheckUp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwElencoCheckUp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcDestinatario, Me.dgwcidDest, Me.dgwcData, Me.dgwcOperatore})
        Me.dgwElencoCheckUp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwElencoCheckUp.Location = New System.Drawing.Point(3, 3)
        Me.dgwElencoCheckUp.Name = "dgwElencoCheckUp"
        Me.dgwElencoCheckUp.ReadOnly = True
        Me.dgwElencoCheckUp.Size = New System.Drawing.Size(541, 600)
        Me.dgwElencoCheckUp.TabIndex = 0
        '
        'dgwcDestinatario
        '
        Me.dgwcDestinatario.HeaderText = "Destinatario"
        Me.dgwcDestinatario.Name = "dgwcDestinatario"
        Me.dgwcDestinatario.ReadOnly = True
        '
        'dgwcidDest
        '
        Me.dgwcidDest.HeaderText = "idDest"
        Me.dgwcidDest.Name = "dgwcidDest"
        Me.dgwcidDest.ReadOnly = True
        Me.dgwcidDest.Visible = False
        '
        'dgwcData
        '
        Me.dgwcData.FillWeight = 60.0!
        Me.dgwcData.HeaderText = "Data"
        Me.dgwcData.Name = "dgwcData"
        Me.dgwcData.ReadOnly = True
        '
        'dgwcOperatore
        '
        Me.dgwcOperatore.HeaderText = "Operatore"
        Me.dgwcOperatore.Name = "dgwcOperatore"
        Me.dgwcOperatore.ReadOnly = True
        '
        'tpReportCheckList
        '
        Me.tpReportCheckList.Controls.Add(Me.ReportViewer1)
        Me.tpReportCheckList.Location = New System.Drawing.Point(4, 25)
        Me.tpReportCheckList.Name = "tpReportCheckList"
        Me.tpReportCheckList.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReportCheckList.Size = New System.Drawing.Size(547, 606)
        Me.tpReportCheckList.TabIndex = 0
        Me.tpReportCheckList.Text = "Stampa Check List"
        Me.tpReportCheckList.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TmpCQBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.rpt_checkQualita.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(541, 600)
        Me.ReportViewer1.TabIndex = 7
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgwCliente, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgwDettaglioClienti, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(274, 635)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'DT_BarraNavigazione
        '
        Me.DT_BarraNavigazione.AddNewItem = Nothing
        Me.DT_BarraNavigazione.AutoSize = False
        Me.DT_BarraNavigazione.BindingSource = Me.bsClienti
        Me.DT_BarraNavigazione.CountItem = Me.BindingNavigatorCountItem
        Me.DT_BarraNavigazione.DeleteItem = Nothing
        Me.DT_BarraNavigazione.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_BarraNavigazione.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTestoRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTTermina, Me.TTBTAggiorna, Me.tsbStampa, Me.tbPresenzaControlli, Me.tsbEliminaControllo})
        Me.DT_BarraNavigazione.Location = New System.Drawing.Point(0, 696)
        Me.DT_BarraNavigazione.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_BarraNavigazione.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_BarraNavigazione.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_BarraNavigazione.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_BarraNavigazione.Name = "DT_BarraNavigazione"
        Me.DT_BarraNavigazione.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_BarraNavigazione.Size = New System.Drawing.Size(1425, 76)
        Me.DT_BarraNavigazione.TabIndex = 149
        Me.DT_BarraNavigazione.Text = "DS_Navigatore"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 73)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.AutoSize = False
        Me.TTTestoRicerca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Margin = New System.Windows.Forms.Padding(1, 0, 1, 5)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(133, 32)
        Me.TTTestoRicerca.ToolTipText = "Ricerca all'interno dell'archivio per SOCIETA' / P.IVA / CITTA'"
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
        Me.BindingNavigatorMoveFirstItem.ToolTipText = "Va all'inizio dell'elenco clienti"
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
        Me.BindingNavigatorMovePreviousItem.ToolTipText = "Va al cliente precedente"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 76)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 33)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 76)
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
        Me.BindingNavigatorMoveNextItem.ToolTipText = "Va al cliente successivo"
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
        Me.BindingNavigatorMoveLastItem.ToolTipText = "Procede alla fine dell'archivio"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 76)
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
        Me.TTBTTermina.ToolTipText = "Chiude la maschera e torna al menù principale"
        '
        'TTBTAggiorna
        '
        Me.TTBTAggiorna.AutoSize = False
        Me.TTBTAggiorna.Image = Global.PoP2.Comuni.My.Resources.Resources.ricicla48
        Me.TTBTAggiorna.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTAggiorna.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTAggiorna.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTAggiorna.Name = "TTBTAggiorna"
        Me.TTBTAggiorna.Size = New System.Drawing.Size(50, 70)
        Me.TTBTAggiorna.Text = "Ricarica"
        Me.TTBTAggiorna.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTAggiorna.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTAggiorna.ToolTipText = "Stampa un elenco dei clienti in base alle scelte"
        '
        'tsbStampa
        '
        Me.tsbStampa.AutoSize = False
        Me.tsbStampa.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_stampa48
        Me.tsbStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbStampa.Name = "tsbStampa"
        Me.tsbStampa.Size = New System.Drawing.Size(70, 70)
        Me.tsbStampa.Text = "Stampa"
        Me.tsbStampa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbStampa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tbPresenzaControlli
        '
        Me.tbPresenzaControlli.AutoSize = False
        Me.tbPresenzaControlli.AutoToolTip = True
        Me.tbPresenzaControlli.Name = "tbPresenzaControlli"
        Me.tbPresenzaControlli.Size = New System.Drawing.Size(200, 73)
        Me.tbPresenzaControlli.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.tbPresenzaControlli.ToolTipText = "Indica se sono presenti dei controlli effettuati"
        '
        'tsbEliminaControllo
        '
        Me.tsbEliminaControllo.AutoSize = False
        Me.tsbEliminaControllo.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_cestino48
        Me.tsbEliminaControllo.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.tsbEliminaControllo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsbEliminaControllo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEliminaControllo.Name = "tsbEliminaControllo"
        Me.tsbEliminaControllo.Size = New System.Drawing.Size(70, 70)
        Me.tsbEliminaControllo.Text = "Elimina"
        Me.tsbEliminaControllo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.tsbEliminaControllo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsbEliminaControllo.ToolTipText = "Elimina il controllo effettuato"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "autorizza.png")
        Me.ImageList1.Images.SetKeyName(1, "resettafiltro.png")
        '
        'bsControlloQualita
        '
        Me.bsControlloQualita.DataMember = "dtCq"
        Me.bsControlloQualita.DataSource = Me.DsControlloQualita
        '
        'TaClienti
        '
        Me.TaClienti.ClearBeforeFill = True
        '
        'TaDestinatari
        '
        Me.TaDestinatari.ClearBeforeFill = True
        '
        'bsAbbinamento
        '
        Me.bsAbbinamento.DataMember = "dtCqAbbinaAreaDettaglioDestinatario"
        Me.bsAbbinamento.DataSource = Me.DsControlloQualita
        '
        'DtCqAbbinaAreaDettaglioDestinatario
        '
        Me.DtCqAbbinaAreaDettaglioDestinatario.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.dsControlloQualitaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TaCqCategorie
        '
        Me.TaCqCategorie.ClearBeforeFill = True
        '
        'DtCqDettaglio
        '
        Me.DtCqDettaglio.ClearBeforeFill = True
        '
        'taCq
        '
        Me.taCq.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 55
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "societa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "societa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 332
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn3.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 166
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "locazione"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Destinatario"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 166
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn5.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "descrizione"
        Me.DataGridViewTextBoxColumn6.HeaderText = "descrizione"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 338
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn7.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Dettaglio Operazione"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn8.Width = 542
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn9.HeaderText = "idAbbinamento"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "descrizione"
        Me.DataGridViewTextBoxColumn10.HeaderText = "descrizione"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 269
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn11.HeaderText = "id"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Dettaglio Operazione"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.Width = 199
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.HeaderText = "idAbbinamento"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'FrmAbbinamentoCantieriCQ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1425, 772)
        Me.Controls.Add(Me.DT_BarraNavigazione)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmAbbinamentoCantieriCQ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Abbinamento Clienti per Qualita"
        CType(Me.TmpCQBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsControlloQualita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.relClientiDestinatari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwDestinatarioArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsDettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwDettaglioClienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtClientidtDestinatariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TCSchedaElenco.ResumeLayout(False)
        Me.tpDettaglioInterventi.ResumeLayout(False)
        CType(Me.dgwElencoCheckUp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReportCheckList.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.DT_BarraNavigazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_BarraNavigazione.ResumeLayout(False)
        Me.DT_BarraNavigazione.PerformLayout()
        CType(Me.bsControlloQualita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsAbbinamento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgwCliente As DataGridView
    Friend WithEvents DsControlloQualita As dsControlloQualita
    Friend WithEvents bsClienti As BindingSource
    Friend WithEvents TaClienti As dsControlloQualitaTableAdapters.taClienti
    Friend WithEvents relClientiDestinatari As BindingSource
    Friend WithEvents TaDestinatari As dsControlloQualitaTableAdapters.taDestinatari
    Friend WithEvents bsAbbinamento As BindingSource
    Friend WithEvents DtCqAbbinaAreaDettaglioDestinatario As dsControlloQualitaTableAdapters.dtCqAbbinaAreaDettaglioDestinatario
    Friend WithEvents TableAdapterManager As dsControlloQualitaTableAdapters.TableAdapterManager
    Friend WithEvents bsArea As BindingSource
    Friend WithEvents TaCqCategorie As dsControlloQualitaTableAdapters.taCqCategorie
    'Friend WithEvents TaCqDestinatarioArea As dsControlloQualitaTableAdapters.taCqDestinatarioArea
    Friend WithEvents dgwDestinatarioArea As DataGridView
    Friend WithEvents bsDettaglio As BindingSource
    Friend WithEvents DtCqDettaglio As dsControlloQualitaTableAdapters.dtCqDettaglio
    Friend WithEvents dgwDettaglio As DataGridView
    Friend WithEvents dgwcID_Area As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDescrizioneArea As DataGridViewTextBoxColumn
    Friend WithEvents dgwDettaglioClienti As DataGridView
    Friend WithEvents DtClientidtDestinatariBindingSource As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents DT_BarraNavigazione As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents TTTestoRicerca As ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTAggiorna As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDettaglioID As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDettaglioControllo As DataGridViewCheckBoxColumn
    Friend WithEvents dgwcDettaglioIDdettaglio As DataGridViewTextBoxColumn
    Friend WithEvents dgwcIDAbbinamentoTMP As DataGridViewTextBoxColumn
    Friend WithEvents dgwcidLocazione As DataGridViewTextBoxColumn
    Friend WithEvents dgwcLocazione As DataGridViewTextBoxColumn
    Friend WithEvents bsControlloQualita As BindingSource
    Friend WithEvents taCq As dsControlloQualitaTableAdapters.taCq
    Friend WithEvents tsbStampa As ToolStripDropDownButton
    Friend WithEvents TmpCQBindingSource As BindingSource
    Friend WithEvents tbPresenzaControlli As ToolStripProgressBar
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents dgwcClientiID As DataGridViewTextBoxColumn
    Friend WithEvents dgwcClientiSocieta As DataGridViewTextBoxColumn
    Friend WithEvents tsbEliminaControllo As ToolStripSplitButton
    Friend WithEvents TCSchedaElenco As TabControl
    Friend WithEvents tpReportCheckList As TabPage
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents tpDettaglioInterventi As TabPage
    Friend WithEvents dgwElencoCheckUp As DataGridView
    Friend WithEvents dgwcDestinatario As DataGridViewTextBoxColumn
    Friend WithEvents dgwcidDest As DataGridViewTextBoxColumn
    Friend WithEvents dgwcData As DataGridViewTextBoxColumn
    Friend WithEvents dgwcOperatore As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
End Class
