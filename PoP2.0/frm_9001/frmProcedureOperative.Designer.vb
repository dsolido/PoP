<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmProcedureOperative
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProcedureOperative))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dtProcedureIOPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProcedure = New PoP2.Comuni.DSProcedure()
        Me.dtProcedureRigheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dtProcedureRevisioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bsProcedureIOP = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwRevisioni = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdproceduraDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumrevDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rlProcedureIOP_ProcedureRevisione = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdistruzioniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsProcedureIstruzioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdprodottoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsProdotti = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdmacchinarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsMacchinari = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdcategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsProcedureCategorie = New System.Windows.Forms.BindingSource(Me.components)
        Me.PannelloRicerca = New System.Windows.Forms.Panel()
        Me.dgwRicerca = New System.Windows.Forms.DataGridView()
        Me.dgwcRicercaID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcTesto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcidCategoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcIDIOP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcIDriga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbRicerca = New System.Windows.Forms.Label()
        Me.txRicerca = New System.Windows.Forms.TextBox()
        Me.dgwProdotti = New System.Windows.Forms.DataGridView()
        Me.IdprodottoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdottoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSortPro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWprodottiid_categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsrigheProdotti = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwMacchinari = New System.Windows.Forms.DataGridView()
        Me.IdmacchinarioDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSortMac = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsrigheMacchinari = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwIstruzioni = New System.Windows.Forms.DataGridView()
        Me.bsrigheIstruzioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwDPI = New System.Windows.Forms.DataGridView()
        Me.IdprodottoDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdottoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSortDPI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsrigheDPI = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwAttrezzature = New System.Windows.Forms.DataGridView()
        Me.IdprodottoDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdottoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSortAt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsrigheAttrezzature = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tabDisposizioni = New System.Windows.Forms.TableLayoutPanel()
        Me.dgwIOP = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitoloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcNoteIOP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImgDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VideoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LivelloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.bsProcedureRighe = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaProcedureIOP = New PoP2.Comuni.DSProcedureTableAdapters.taProcedureIOP()
        Me.TaProcedureRevisione = New PoP2.Comuni.DSProcedureTableAdapters.taProcedureRevisione()
        Me.TaProcedureCategorie = New PoP2.Comuni.DSProcedureTableAdapters.taProcedureCategorie()
        Me.TaProcedureRighe = New PoP2.Comuni.DSProcedureTableAdapters.taProcedureRighe()
        Me.TaMacchinari = New PoP2.Comuni.DSProcedureTableAdapters.taMacchinari()
        Me.TaProcedureIstruzioni = New PoP2.Comuni.DSProcedureTableAdapters.taProcedureIstruzioni()
        Me.TaProdotti = New PoP2.Comuni.DSProcedureTableAdapters.taProdotti()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.DT_BarraNavigazione = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTRicarica = New System.Windows.Forms.ToolStripButton()
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
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
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
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_istruzioni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.testo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSortIst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtProcedureIOPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProcedure, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtProcedureRigheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtProcedureRevisioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProcedureIOP, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwRevisioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rlProcedureIOP_ProcedureRevisione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProcedureIstruzioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProdotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMacchinari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProcedureCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PannelloRicerca.SuspendLayout()
        CType(Me.dgwRicerca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwProdotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsrigheProdotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwMacchinari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsrigheMacchinari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwIstruzioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsrigheIstruzioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwDPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsrigheDPI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwAttrezzature, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsrigheAttrezzature, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tabDisposizioni.SuspendLayout()
        CType(Me.dgwIOP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.bsProcedureRighe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.DT_BarraNavigazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_BarraNavigazione.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtProcedureIOPBindingSource
        '
        Me.dtProcedureIOPBindingSource.DataMember = "dtProcedureIOP"
        Me.dtProcedureIOPBindingSource.DataSource = Me.DsProcedure
        '
        'DsProcedure
        '
        Me.DsProcedure.DataSetName = "dsProcedure"
        Me.DsProcedure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtProcedureRigheBindingSource
        '
        Me.dtProcedureRigheBindingSource.DataMember = "dtProcedureRighe"
        Me.dtProcedureRigheBindingSource.DataSource = Me.DsProcedure
        '
        'dtProcedureRevisioneBindingSource
        '
        Me.dtProcedureRevisioneBindingSource.DataMember = "dtProcedureRevisione"
        Me.dtProcedureRevisioneBindingSource.DataSource = Me.DsProcedure
        '
        'bsProcedureIOP
        '
        Me.bsProcedureIOP.DataMember = "dtProcedureIOP"
        Me.bsProcedureIOP.DataSource = Me.DsProcedure
        '
        'dgwRevisioni
        '
        Me.dgwRevisioni.AutoGenerateColumns = False
        Me.dgwRevisioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwRevisioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwRevisioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn2, Me.IdproceduraDataGridViewTextBoxColumn1, Me.DataDataGridViewTextBoxColumn1, Me.NumrevDataGridViewTextBoxColumn})
        Me.dgwRevisioni.DataSource = Me.rlProcedureIOP_ProcedureRevisione
        Me.dgwRevisioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwRevisioni.Location = New System.Drawing.Point(3, 3)
        Me.dgwRevisioni.Name = "dgwRevisioni"
        Me.dgwRevisioni.RowHeadersWidth = 20
        Me.dgwRevisioni.Size = New System.Drawing.Size(207, 108)
        Me.dgwRevisioni.TabIndex = 2
        '
        'IdDataGridViewTextBoxColumn2
        '
        Me.IdDataGridViewTextBoxColumn2.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn2.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn2.Name = "IdDataGridViewTextBoxColumn2"
        Me.IdDataGridViewTextBoxColumn2.Visible = False
        '
        'IdproceduraDataGridViewTextBoxColumn1
        '
        Me.IdproceduraDataGridViewTextBoxColumn1.DataPropertyName = "id_procedura"
        Me.IdproceduraDataGridViewTextBoxColumn1.HeaderText = "id_procedura"
        Me.IdproceduraDataGridViewTextBoxColumn1.Name = "IdproceduraDataGridViewTextBoxColumn1"
        Me.IdproceduraDataGridViewTextBoxColumn1.Visible = False
        '
        'DataDataGridViewTextBoxColumn1
        '
        Me.DataDataGridViewTextBoxColumn1.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn1.FillWeight = 80.0!
        Me.DataDataGridViewTextBoxColumn1.HeaderText = "Data Rev"
        Me.DataDataGridViewTextBoxColumn1.Name = "DataDataGridViewTextBoxColumn1"
        '
        'NumrevDataGridViewTextBoxColumn
        '
        Me.NumrevDataGridViewTextBoxColumn.DataPropertyName = "num_rev"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.NumrevDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.NumrevDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.NumrevDataGridViewTextBoxColumn.HeaderText = "n° Rev"
        Me.NumrevDataGridViewTextBoxColumn.Name = "NumrevDataGridViewTextBoxColumn"
        '
        'rlProcedureIOP_ProcedureRevisione
        '
        Me.rlProcedureIOP_ProcedureRevisione.DataMember = "FK_dtProcedureRevisione_dtProcedureIOP"
        Me.rlProcedureIOP_ProcedureRevisione.DataSource = Me.bsProcedureIOP
        '
        'IdistruzioniDataGridViewTextBoxColumn
        '
        Me.IdistruzioniDataGridViewTextBoxColumn.DataPropertyName = "id_istruzioni"
        Me.IdistruzioniDataGridViewTextBoxColumn.DataSource = Me.bsProcedureIstruzioni
        Me.IdistruzioniDataGridViewTextBoxColumn.DisplayMember = "testo"
        Me.IdistruzioniDataGridViewTextBoxColumn.HeaderText = "Istruzioni"
        Me.IdistruzioniDataGridViewTextBoxColumn.Name = "IdistruzioniDataGridViewTextBoxColumn"
        Me.IdistruzioniDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdistruzioniDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdistruzioniDataGridViewTextBoxColumn.ValueMember = "id"
        '
        'bsProcedureIstruzioni
        '
        Me.bsProcedureIstruzioni.DataMember = "dtProcedureIstruzioni"
        Me.bsProcedureIstruzioni.DataSource = Me.DsProcedure
        '
        'IdprodottoDataGridViewTextBoxColumn
        '
        Me.IdprodottoDataGridViewTextBoxColumn.DataPropertyName = "id_prodotto"
        Me.IdprodottoDataGridViewTextBoxColumn.DataSource = Me.bsProdotti
        Me.IdprodottoDataGridViewTextBoxColumn.DisplayMember = "descrizione"
        Me.IdprodottoDataGridViewTextBoxColumn.HeaderText = "Prodotto"
        Me.IdprodottoDataGridViewTextBoxColumn.Name = "IdprodottoDataGridViewTextBoxColumn"
        Me.IdprodottoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdprodottoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdprodottoDataGridViewTextBoxColumn.ValueMember = "id"
        '
        'bsProdotti
        '
        Me.bsProdotti.DataMember = "dtProdotti"
        Me.bsProdotti.DataSource = Me.DsProcedure
        '
        'IdmacchinarioDataGridViewTextBoxColumn
        '
        Me.IdmacchinarioDataGridViewTextBoxColumn.DataPropertyName = "id_macchinario"
        Me.IdmacchinarioDataGridViewTextBoxColumn.DataSource = Me.bsMacchinari
        Me.IdmacchinarioDataGridViewTextBoxColumn.DisplayMember = "descrizione"
        Me.IdmacchinarioDataGridViewTextBoxColumn.HeaderText = "Macchinario"
        Me.IdmacchinarioDataGridViewTextBoxColumn.Name = "IdmacchinarioDataGridViewTextBoxColumn"
        Me.IdmacchinarioDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdmacchinarioDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdmacchinarioDataGridViewTextBoxColumn.ValueMember = "id"
        '
        'bsMacchinari
        '
        Me.bsMacchinari.DataMember = "dtMacchinari"
        Me.bsMacchinari.DataSource = Me.DsProcedure
        '
        'IdcategoriaDataGridViewTextBoxColumn
        '
        Me.IdcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria"
        Me.IdcategoriaDataGridViewTextBoxColumn.DataSource = Me.bsProcedureCategorie
        Me.IdcategoriaDataGridViewTextBoxColumn.DisplayMember = "nome"
        Me.IdcategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.IdcategoriaDataGridViewTextBoxColumn.Name = "IdcategoriaDataGridViewTextBoxColumn"
        Me.IdcategoriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IdcategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.IdcategoriaDataGridViewTextBoxColumn.ValueMember = "id"
        Me.IdcategoriaDataGridViewTextBoxColumn.Visible = False
        '
        'bsProcedureCategorie
        '
        Me.bsProcedureCategorie.DataMember = "dtProcedureCategorie"
        Me.bsProcedureCategorie.DataSource = Me.DsProcedure
        '
        'PannelloRicerca
        '
        Me.PannelloRicerca.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.PannelloRicerca.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PannelloRicerca.Controls.Add(Me.dgwRicerca)
        Me.PannelloRicerca.Controls.Add(Me.lbRicerca)
        Me.PannelloRicerca.Controls.Add(Me.txRicerca)
        Me.PannelloRicerca.Location = New System.Drawing.Point(2, 273)
        Me.PannelloRicerca.Name = "PannelloRicerca"
        Me.PannelloRicerca.Size = New System.Drawing.Size(351, 260)
        Me.PannelloRicerca.TabIndex = 4
        Me.PannelloRicerca.Visible = False
        '
        'dgwRicerca
        '
        Me.dgwRicerca.AllowUserToAddRows = False
        Me.dgwRicerca.AllowUserToDeleteRows = False
        Me.dgwRicerca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwRicerca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwRicerca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwRicerca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcRicercaID, Me.dgwcTesto, Me.dgwcidCategoria, Me.dgwcIDIOP, Me.dgwcIDriga})
        Me.dgwRicerca.Location = New System.Drawing.Point(4, 71)
        Me.dgwRicerca.Name = "dgwRicerca"
        Me.dgwRicerca.ReadOnly = True
        Me.dgwRicerca.RowHeadersVisible = False
        Me.dgwRicerca.Size = New System.Drawing.Size(339, 179)
        Me.dgwRicerca.TabIndex = 3
        '
        'dgwcRicercaID
        '
        Me.dgwcRicercaID.HeaderText = "ID"
        Me.dgwcRicercaID.Name = "dgwcRicercaID"
        Me.dgwcRicercaID.ReadOnly = True
        Me.dgwcRicercaID.Visible = False
        '
        'dgwcTesto
        '
        Me.dgwcTesto.HeaderText = "Descrizione"
        Me.dgwcTesto.Name = "dgwcTesto"
        Me.dgwcTesto.ReadOnly = True
        '
        'dgwcidCategoria
        '
        Me.dgwcidCategoria.HeaderText = "Categoria"
        Me.dgwcidCategoria.Name = "dgwcidCategoria"
        Me.dgwcidCategoria.ReadOnly = True
        Me.dgwcidCategoria.Visible = False
        '
        'dgwcIDIOP
        '
        Me.dgwcIDIOP.HeaderText = "IOP"
        Me.dgwcIDIOP.Name = "dgwcIDIOP"
        Me.dgwcIDIOP.ReadOnly = True
        Me.dgwcIDIOP.Visible = False
        '
        'dgwcIDriga
        '
        Me.dgwcIDriga.HeaderText = "idRiga"
        Me.dgwcIDriga.Name = "dgwcIDriga"
        Me.dgwcIDriga.ReadOnly = True
        Me.dgwcIDriga.Visible = False
        '
        'lbRicerca
        '
        Me.lbRicerca.AutoSize = True
        Me.lbRicerca.Location = New System.Drawing.Point(3, 11)
        Me.lbRicerca.Name = "lbRicerca"
        Me.lbRicerca.Size = New System.Drawing.Size(44, 13)
        Me.lbRicerca.TabIndex = 2
        Me.lbRicerca.Text = "Ricerca"
        '
        'txRicerca
        '
        Me.txRicerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txRicerca.Location = New System.Drawing.Point(3, 39)
        Me.txRicerca.Name = "txRicerca"
        Me.txRicerca.Size = New System.Drawing.Size(341, 22)
        Me.txRicerca.TabIndex = 0
        '
        'dgwProdotti
        '
        Me.dgwProdotti.AllowDrop = True
        Me.dgwProdotti.AutoGenerateColumns = False
        Me.dgwProdotti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwProdotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwProdotti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdprodottoDataGridViewTextBoxColumn1, Me.ProdottoDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn2, Me.dgwcSortPro, Me.DGWprodottiid_categoria})
        Me.dgwProdotti.DataSource = Me.bsrigheProdotti
        Me.dgwProdotti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwProdotti.Location = New System.Drawing.Point(348, 3)
        Me.dgwProdotti.Name = "dgwProdotti"
        Me.dgwProdotti.RowHeadersWidth = 20
        Me.dgwProdotti.Size = New System.Drawing.Size(323, 169)
        Me.dgwProdotti.TabIndex = 5
        '
        'IdprodottoDataGridViewTextBoxColumn1
        '
        Me.IdprodottoDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdprodottoDataGridViewTextBoxColumn1.HeaderText = "id_prodotto"
        Me.IdprodottoDataGridViewTextBoxColumn1.Name = "IdprodottoDataGridViewTextBoxColumn1"
        Me.IdprodottoDataGridViewTextBoxColumn1.Visible = False
        '
        'ProdottoDataGridViewTextBoxColumn
        '
        Me.ProdottoDataGridViewTextBoxColumn.DataPropertyName = "prodotto"
        Me.ProdottoDataGridViewTextBoxColumn.HeaderText = "prodotto"
        Me.ProdottoDataGridViewTextBoxColumn.Name = "ProdottoDataGridViewTextBoxColumn"
        Me.ProdottoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoteDataGridViewTextBoxColumn2
        '
        Me.NoteDataGridViewTextBoxColumn2.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn2.FillWeight = 50.0!
        Me.NoteDataGridViewTextBoxColumn2.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn2.Name = "NoteDataGridViewTextBoxColumn2"
        '
        'dgwcSortPro
        '
        Me.dgwcSortPro.DataPropertyName = "sort"
        Me.dgwcSortPro.HeaderText = "sort"
        Me.dgwcSortPro.Name = "dgwcSortPro"
        Me.dgwcSortPro.Visible = False
        '
        'DGWprodottiid_categoria
        '
        Me.DGWprodottiid_categoria.DataPropertyName = "id_categoria"
        Me.DGWprodottiid_categoria.HeaderText = "id_categoria"
        Me.DGWprodottiid_categoria.Name = "DGWprodottiid_categoria"
        Me.DGWprodottiid_categoria.Visible = False
        '
        'bsrigheProdotti
        '
        Me.bsrigheProdotti.DataMember = "dtProcedureRighe"
        Me.bsrigheProdotti.DataSource = Me.DsProcedure
        Me.bsrigheProdotti.Filter = "id_categoria=2"
        '
        'dgwMacchinari
        '
        Me.dgwMacchinari.AllowDrop = True
        Me.dgwMacchinari.AutoGenerateColumns = False
        Me.dgwMacchinari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwMacchinari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwMacchinari.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdmacchinarioDataGridViewTextBoxColumn2, Me.DescrizioneDataGridViewTextBoxColumn1, Me.NoteDataGridViewTextBoxColumn3, Me.dgwcSortMac})
        Me.dgwMacchinari.DataSource = Me.bsrigheMacchinari
        Me.dgwMacchinari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwMacchinari.Location = New System.Drawing.Point(348, 178)
        Me.dgwMacchinari.Name = "dgwMacchinari"
        Me.dgwMacchinari.RowHeadersWidth = 20
        Me.dgwMacchinari.Size = New System.Drawing.Size(323, 169)
        Me.dgwMacchinari.TabIndex = 6
        '
        'IdmacchinarioDataGridViewTextBoxColumn2
        '
        Me.IdmacchinarioDataGridViewTextBoxColumn2.DataPropertyName = "id"
        Me.IdmacchinarioDataGridViewTextBoxColumn2.HeaderText = "id"
        Me.IdmacchinarioDataGridViewTextBoxColumn2.Name = "IdmacchinarioDataGridViewTextBoxColumn2"
        Me.IdmacchinarioDataGridViewTextBoxColumn2.Visible = False
        '
        'DescrizioneDataGridViewTextBoxColumn1
        '
        Me.DescrizioneDataGridViewTextBoxColumn1.DataPropertyName = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn1.HeaderText = "Macchinari"
        Me.DescrizioneDataGridViewTextBoxColumn1.Name = "DescrizioneDataGridViewTextBoxColumn1"
        Me.DescrizioneDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NoteDataGridViewTextBoxColumn3
        '
        Me.NoteDataGridViewTextBoxColumn3.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn3.FillWeight = 50.0!
        Me.NoteDataGridViewTextBoxColumn3.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn3.Name = "NoteDataGridViewTextBoxColumn3"
        '
        'dgwcSortMac
        '
        Me.dgwcSortMac.DataPropertyName = "sort"
        Me.dgwcSortMac.HeaderText = "sort"
        Me.dgwcSortMac.Name = "dgwcSortMac"
        Me.dgwcSortMac.Visible = False
        '
        'bsrigheMacchinari
        '
        Me.bsrigheMacchinari.DataMember = "dtProcedureRighe"
        Me.bsrigheMacchinari.DataSource = Me.DsProcedure
        Me.bsrigheMacchinari.Filter = "id_categoria=4"
        '
        'dgwIstruzioni
        '
        Me.dgwIstruzioni.AllowDrop = True
        Me.dgwIstruzioni.AutoGenerateColumns = False
        Me.dgwIstruzioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwIstruzioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwIstruzioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_istruzioni, Me.testo, Me.DataGridViewTextBoxColumn28, Me.dgwcSortIst})
        Me.dgwIstruzioni.DataSource = Me.bsrigheIstruzioni
        Me.dgwIstruzioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwIstruzioni.Location = New System.Drawing.Point(3, 524)
        Me.dgwIstruzioni.Name = "dgwIstruzioni"
        Me.dgwIstruzioni.RowHeadersWidth = 20
        Me.dgwIstruzioni.Size = New System.Drawing.Size(674, 194)
        Me.dgwIstruzioni.TabIndex = 7
        '
        'bsrigheIstruzioni
        '
        Me.bsrigheIstruzioni.DataMember = "dtProcedureRighe"
        Me.bsrigheIstruzioni.DataSource = Me.DsProcedure
        Me.bsrigheIstruzioni.Filter = "id_categoria = 5"
        '
        'dgwDPI
        '
        Me.dgwDPI.AllowDrop = True
        Me.dgwDPI.AutoGenerateColumns = False
        Me.dgwDPI.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwDPI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDPI.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdprodottoDataGridViewTextBoxColumn3, Me.ProdottoDataGridViewTextBoxColumn2, Me.NoteDataGridViewTextBoxColumn4, Me.dgwcSortDPI})
        Me.dgwDPI.DataSource = Me.bsrigheDPI
        Me.dgwDPI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwDPI.Location = New System.Drawing.Point(3, 3)
        Me.dgwDPI.Name = "dgwDPI"
        Me.dgwDPI.RowHeadersWidth = 20
        Me.dgwDPI.Size = New System.Drawing.Size(339, 169)
        Me.dgwDPI.TabIndex = 8
        '
        'IdprodottoDataGridViewTextBoxColumn3
        '
        Me.IdprodottoDataGridViewTextBoxColumn3.DataPropertyName = "id"
        Me.IdprodottoDataGridViewTextBoxColumn3.HeaderText = "id_prodotto"
        Me.IdprodottoDataGridViewTextBoxColumn3.Name = "IdprodottoDataGridViewTextBoxColumn3"
        Me.IdprodottoDataGridViewTextBoxColumn3.Visible = False
        '
        'ProdottoDataGridViewTextBoxColumn2
        '
        Me.ProdottoDataGridViewTextBoxColumn2.DataPropertyName = "prodotto"
        Me.ProdottoDataGridViewTextBoxColumn2.HeaderText = "DPI"
        Me.ProdottoDataGridViewTextBoxColumn2.Name = "ProdottoDataGridViewTextBoxColumn2"
        Me.ProdottoDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'NoteDataGridViewTextBoxColumn4
        '
        Me.NoteDataGridViewTextBoxColumn4.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn4.FillWeight = 50.0!
        Me.NoteDataGridViewTextBoxColumn4.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn4.Name = "NoteDataGridViewTextBoxColumn4"
        '
        'dgwcSortDPI
        '
        Me.dgwcSortDPI.DataPropertyName = "sort"
        Me.dgwcSortDPI.HeaderText = "sort"
        Me.dgwcSortDPI.Name = "dgwcSortDPI"
        Me.dgwcSortDPI.Visible = False
        '
        'bsrigheDPI
        '
        Me.bsrigheDPI.DataMember = "dtProcedureRighe"
        Me.bsrigheDPI.DataSource = Me.DsProcedure
        Me.bsrigheDPI.Filter = "id_categoria=3"
        '
        'dgwAttrezzature
        '
        Me.dgwAttrezzature.AllowDrop = True
        Me.dgwAttrezzature.AutoGenerateColumns = False
        Me.dgwAttrezzature.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwAttrezzature.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwAttrezzature.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdprodottoDataGridViewTextBoxColumn2, Me.ProdottoDataGridViewTextBoxColumn1, Me.NoteDataGridViewTextBoxColumn, Me.dgwcSortAt})
        Me.dgwAttrezzature.DataSource = Me.bsrigheAttrezzature
        Me.dgwAttrezzature.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwAttrezzature.Location = New System.Drawing.Point(3, 178)
        Me.dgwAttrezzature.Name = "dgwAttrezzature"
        Me.dgwAttrezzature.RowHeadersWidth = 20
        Me.dgwAttrezzature.Size = New System.Drawing.Size(339, 169)
        Me.dgwAttrezzature.TabIndex = 9
        '
        'IdprodottoDataGridViewTextBoxColumn2
        '
        Me.IdprodottoDataGridViewTextBoxColumn2.DataPropertyName = "id"
        Me.IdprodottoDataGridViewTextBoxColumn2.HeaderText = "id"
        Me.IdprodottoDataGridViewTextBoxColumn2.Name = "IdprodottoDataGridViewTextBoxColumn2"
        Me.IdprodottoDataGridViewTextBoxColumn2.Visible = False
        '
        'ProdottoDataGridViewTextBoxColumn1
        '
        Me.ProdottoDataGridViewTextBoxColumn1.DataPropertyName = "prodotto"
        Me.ProdottoDataGridViewTextBoxColumn1.HeaderText = "Attrezzature"
        Me.ProdottoDataGridViewTextBoxColumn1.Name = "ProdottoDataGridViewTextBoxColumn1"
        Me.ProdottoDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        '
        'dgwcSortAt
        '
        Me.dgwcSortAt.DataPropertyName = "sort"
        Me.dgwcSortAt.HeaderText = "sort"
        Me.dgwcSortAt.Name = "dgwcSortAt"
        Me.dgwcSortAt.Visible = False
        '
        'bsrigheAttrezzature
        '
        Me.bsrigheAttrezzature.DataMember = "dtProcedureRighe"
        Me.bsrigheAttrezzature.DataSource = Me.DsProcedure
        Me.bsrigheAttrezzature.Filter = "id_categoria=1"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 78
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.dtProcedureIOPBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.dtProcedureRigheBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.dtProcedureRevisioneBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.ProcedureIOP.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 238)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(382, 480)
        Me.ReportViewer1.TabIndex = 10
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.20482!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.79518!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgwDPI, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgwProdotti, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.dgwAttrezzature, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.dgwMacchinari, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 168)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(674, 350)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'tabDisposizioni
        '
        Me.tabDisposizioni.ColumnCount = 1
        Me.tabDisposizioni.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.85235!))
        Me.tabDisposizioni.Controls.Add(Me.dgwIOP, 0, 0)
        Me.tabDisposizioni.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.tabDisposizioni.Controls.Add(Me.dgwIstruzioni, 0, 2)
        Me.tabDisposizioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDisposizioni.Location = New System.Drawing.Point(3, 3)
        Me.tabDisposizioni.Name = "tabDisposizioni"
        Me.tabDisposizioni.RowCount = 3
        Me.tabDisposizioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.69231!))
        Me.tabDisposizioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.30769!))
        Me.tabDisposizioni.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 199.0!))
        Me.tabDisposizioni.Size = New System.Drawing.Size(680, 721)
        Me.tabDisposizioni.TabIndex = 13
        '
        'dgwIOP
        '
        Me.dgwIOP.AutoGenerateColumns = False
        Me.dgwIOP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwIOP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwIOP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TitoloDataGridViewTextBoxColumn, Me.dgwcNoteIOP, Me.ImgDataGridViewTextBoxColumn, Me.VideoDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.LivelloDataGridViewTextBoxColumn})
        Me.dgwIOP.DataSource = Me.bsProcedureIOP
        Me.dgwIOP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwIOP.Location = New System.Drawing.Point(3, 3)
        Me.dgwIOP.Name = "dgwIOP"
        Me.dgwIOP.RowHeadersWidth = 20
        Me.dgwIOP.Size = New System.Drawing.Size(674, 159)
        Me.dgwIOP.TabIndex = 0
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'TitoloDataGridViewTextBoxColumn
        '
        Me.TitoloDataGridViewTextBoxColumn.DataPropertyName = "titolo"
        Me.TitoloDataGridViewTextBoxColumn.HeaderText = "titolo"
        Me.TitoloDataGridViewTextBoxColumn.Name = "TitoloDataGridViewTextBoxColumn"
        '
        'dgwcNoteIOP
        '
        Me.dgwcNoteIOP.DataPropertyName = "note"
        Me.dgwcNoteIOP.FillWeight = 40.0!
        Me.dgwcNoteIOP.HeaderText = "note"
        Me.dgwcNoteIOP.Name = "dgwcNoteIOP"
        '
        'ImgDataGridViewTextBoxColumn
        '
        Me.ImgDataGridViewTextBoxColumn.DataPropertyName = "img"
        Me.ImgDataGridViewTextBoxColumn.HeaderText = "img"
        Me.ImgDataGridViewTextBoxColumn.Name = "ImgDataGridViewTextBoxColumn"
        Me.ImgDataGridViewTextBoxColumn.Visible = False
        '
        'VideoDataGridViewTextBoxColumn
        '
        Me.VideoDataGridViewTextBoxColumn.DataPropertyName = "video"
        Me.VideoDataGridViewTextBoxColumn.HeaderText = "video"
        Me.VideoDataGridViewTextBoxColumn.Name = "VideoDataGridViewTextBoxColumn"
        Me.VideoDataGridViewTextBoxColumn.Visible = False
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn.FillWeight = 28.0!
        Me.DataDataGridViewTextBoxColumn.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        '
        'LivelloDataGridViewTextBoxColumn
        '
        Me.LivelloDataGridViewTextBoxColumn.DataPropertyName = "livello"
        Me.LivelloDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.LivelloDataGridViewTextBoxColumn.HeaderText = "Autoriz"
        Me.LivelloDataGridViewTextBoxColumn.Name = "LivelloDataGridViewTextBoxColumn"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.53167!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.46833!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.tabDisposizioni, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(5, 12)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1080, 727)
        Me.TableLayoutPanel3.TabIndex = 14
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.ReportViewer1, 0, 2)
        Me.TableLayoutPanel4.Controls.Add(Me.TableLayoutPanel5, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(689, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 3
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 115.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(388, 721)
        Me.TableLayoutPanel4.TabIndex = 15
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.dgwRevisioni, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(382, 114)
        Me.TableLayoutPanel5.TabIndex = 11
        '
        'bsProcedureRighe
        '
        Me.bsProcedureRighe.DataMember = "dtProcedureRighe"
        Me.bsProcedureRighe.DataSource = Me.DsProcedure
        '
        'TaProcedureIOP
        '
        Me.TaProcedureIOP.ClearBeforeFill = True
        '
        'TaProcedureRevisione
        '
        Me.TaProcedureRevisione.ClearBeforeFill = True
        '
        'TaProcedureCategorie
        '
        Me.TaProcedureCategorie.ClearBeforeFill = True
        '
        'TaProcedureRighe
        '
        Me.TaProcedureRighe.ClearBeforeFill = True
        '
        'TaMacchinari
        '
        Me.TaMacchinari.ClearBeforeFill = True
        '
        'TaProcedureIstruzioni
        '
        Me.TaProcedureIstruzioni.ClearBeforeFill = True
        '
        'TaProdotti
        '
        Me.TaProdotti.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 818)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1091, 22)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(504, 17)
        Me.ToolStripStatusLabel1.Text = "Premi F7 o doppio Click sulle griglie per cercare le definizioni, Seleziona la ri" &
    "ga e CANC elimina"
        '
        'DT_BarraNavigazione
        '
        Me.DT_BarraNavigazione.AddNewItem = Nothing
        Me.DT_BarraNavigazione.AutoSize = False
        Me.DT_BarraNavigazione.BindingSource = Me.bsProcedureIOP
        Me.DT_BarraNavigazione.CountItem = Me.BindingNavigatorCountItem
        Me.DT_BarraNavigazione.DeleteItem = Nothing
        Me.DT_BarraNavigazione.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_BarraNavigazione.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicarica, Me.TTTestoRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTTermina, Me.TTBTStampa})
        Me.DT_BarraNavigazione.Location = New System.Drawing.Point(0, 742)
        Me.DT_BarraNavigazione.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_BarraNavigazione.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_BarraNavigazione.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_BarraNavigazione.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_BarraNavigazione.Name = "DT_BarraNavigazione"
        Me.DT_BarraNavigazione.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_BarraNavigazione.Size = New System.Drawing.Size(1091, 76)
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
        'TTBTRicarica
        '
        Me.TTBTRicarica.AutoSize = False
        Me.TTBTRicarica.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_ricarica
        Me.TTBTRicarica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicarica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicarica.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTRicarica.Name = "TTBTRicarica"
        Me.TTBTRicarica.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicarica.Text = "Ricarica"
        Me.TTBTRicarica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicarica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicarica.ToolTipText = "Elimina tutti i filtri e ricarica tutti gli archivi"
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
        Me.TTBTStampa.ToolTipText = "Stampa un elenco dei clienti in base alle scelte"
        Me.TTBTStampa.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        Me.DataGridViewTextBoxColumn1.Width = 84
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "titolo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "titolo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        Me.DataGridViewTextBoxColumn2.Width = 419
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "img"
        Me.DataGridViewTextBoxColumn3.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "img"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Visible = False
        Me.DataGridViewTextBoxColumn3.Width = 106
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "video"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn4.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "video"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Visible = False
        Me.DataGridViewTextBoxColumn4.Width = 66
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn5.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "data"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Visible = False
        Me.DataGridViewTextBoxColumn5.Width = 84
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "livello"
        Me.DataGridViewTextBoxColumn6.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "livello"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 84
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn7.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 133
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id_procedura"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id_procedura"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn9.FillWeight = 80.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "data"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 91
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "num_rev"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridViewTextBoxColumn10.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "num_rev"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 57
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn11.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "note"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 304
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "sort"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn12.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "sort"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 61
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn13.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "id"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Width = 11
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn14.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "note"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Width = 109
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "sort"
        Me.DataGridViewTextBoxColumn15.HeaderText = "sort"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 110
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn16.HeaderText = "id_prodotto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "prodotto"
        Me.DataGridViewTextBoxColumn17.HeaderText = "prodotto"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 193
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn18.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = "note"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 96
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "sort"
        Me.DataGridViewTextBoxColumn19.HeaderText = "sort"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "id_categoria"
        Me.DataGridViewTextBoxColumn20.HeaderText = "id_categoria"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Visible = False
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn21.HeaderText = "id"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Visible = False
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "prodotto"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Attrezzature"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        Me.DataGridViewTextBoxColumn22.Width = 203
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn23.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn23.HeaderText = "note"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        Me.DataGridViewTextBoxColumn23.Width = 101
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "sort"
        Me.DataGridViewTextBoxColumn24.HeaderText = "sort"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        Me.DataGridViewTextBoxColumn24.Visible = False
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn25.HeaderText = "id"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.Visible = False
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "descrizione"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Macchinari"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        Me.DataGridViewTextBoxColumn26.ReadOnly = True
        Me.DataGridViewTextBoxColumn26.Width = 193
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn27.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn27.HeaderText = "note"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        Me.DataGridViewTextBoxColumn27.Width = 96
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn29.HeaderText = "id"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        Me.DataGridViewTextBoxColumn29.ReadOnly = True
        Me.DataGridViewTextBoxColumn29.Visible = False
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "testo"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Istruzioni"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        Me.DataGridViewTextBoxColumn30.ReadOnly = True
        Me.DataGridViewTextBoxColumn30.Width = 418
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn31.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn31.HeaderText = "note"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        Me.DataGridViewTextBoxColumn31.Width = 209
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "sort"
        Me.DataGridViewTextBoxColumn32.HeaderText = "sort"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Visible = False
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        Me.DataGridViewTextBoxColumn33.Visible = False
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        Me.DataGridViewTextBoxColumn34.Width = 336
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.HeaderText = "Categoria"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        Me.DataGridViewTextBoxColumn35.Visible = False
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.HeaderText = "IOP"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.Visible = False
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.HeaderText = "idRiga"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        Me.DataGridViewTextBoxColumn37.Visible = False
        '
        'IdDataGridViewTextBoxColumn3
        '
        Me.IdDataGridViewTextBoxColumn3.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn3.FillWeight = 10.0!
        Me.IdDataGridViewTextBoxColumn3.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn3.Name = "IdDataGridViewTextBoxColumn3"
        Me.IdDataGridViewTextBoxColumn3.Visible = False
        '
        'NoteDataGridViewTextBoxColumn1
        '
        Me.NoteDataGridViewTextBoxColumn1.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn1.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn1.Name = "NoteDataGridViewTextBoxColumn1"
        Me.NoteDataGridViewTextBoxColumn1.Visible = False
        '
        'id_istruzioni
        '
        Me.id_istruzioni.DataPropertyName = "id"
        Me.id_istruzioni.HeaderText = "id"
        Me.id_istruzioni.Name = "id_istruzioni"
        Me.id_istruzioni.ReadOnly = True
        Me.id_istruzioni.Visible = False
        '
        'testo
        '
        Me.testo.DataPropertyName = "testo"
        Me.testo.HeaderText = "Istruzioni"
        Me.testo.Name = "testo"
        Me.testo.ReadOnly = True
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn28.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn28.HeaderText = "note"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'dgwcSortIst
        '
        Me.dgwcSortIst.DataPropertyName = "sort"
        Me.dgwcSortIst.HeaderText = "sort"
        Me.dgwcSortIst.Name = "dgwcSortIst"
        Me.dgwcSortIst.ReadOnly = True
        Me.dgwcSortIst.Visible = False
        '
        'frmProcedureOperative
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1091, 840)
        Me.Controls.Add(Me.DT_BarraNavigazione)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.PannelloRicerca)
        Me.Controls.Add(Me.TableLayoutPanel3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmProcedureOperative"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procedure Operative"
        CType(Me.dtProcedureIOPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProcedure, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtProcedureRigheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtProcedureRevisioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProcedureIOP, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwRevisioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rlProcedureIOP_ProcedureRevisione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProcedureIstruzioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProdotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMacchinari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProcedureCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PannelloRicerca.ResumeLayout(False)
        Me.PannelloRicerca.PerformLayout()
        CType(Me.dgwRicerca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwProdotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsrigheProdotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwMacchinari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsrigheMacchinari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwIstruzioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsrigheIstruzioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwDPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsrigheDPI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwAttrezzature, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsrigheAttrezzature, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tabDisposizioni.ResumeLayout(False)
        CType(Me.dgwIOP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.bsProcedureRighe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.DT_BarraNavigazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_BarraNavigazione.ResumeLayout(False)
        Me.DT_BarraNavigazione.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DsProcedure As dsProcedure
    Friend WithEvents bsProcedureIOP As BindingSource
    Friend WithEvents TaProcedureIOP As dsProcedureTableAdapters.taProcedureIOP
    Friend WithEvents dgwRevisioni As DataGridView
    Friend WithEvents rlProcedureIOP_ProcedureRevisione As BindingSource
    Friend WithEvents TaProcedureRevisione As dsProcedureTableAdapters.taProcedureRevisione
    Friend WithEvents TaProcedureCategorie As dsProcedureTableAdapters.taProcedureCategorie
    Friend WithEvents TaProcedureRighe As dsProcedureTableAdapters.taProcedureRighe
    Friend WithEvents bsProcedureCategorie As BindingSource
    Friend WithEvents bsMacchinari As BindingSource
    Friend WithEvents TaMacchinari As dsProcedureTableAdapters.taMacchinari
    Friend WithEvents bsProcedureIstruzioni As BindingSource
    Friend WithEvents TaProcedureIstruzioni As dsProcedureTableAdapters.taProcedureIstruzioni
    Friend WithEvents bsProdotti As BindingSource
    Friend WithEvents TaProdotti As dsProcedureTableAdapters.taProdotti
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
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
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents IdistruzioniDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents IdprodottoDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents IdmacchinarioDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents IdcategoriaDataGridViewTextBoxColumn As DataGridViewComboBoxColumn
    Friend WithEvents bsProcedureRighe As BindingSource
    Friend WithEvents PannelloRicerca As Panel
    Friend WithEvents lbRicerca As Label
    Friend WithEvents txRicerca As TextBox
    Friend WithEvents dgwRicerca As DataGridView
    Friend WithEvents dgwProdotti As DataGridView
    Friend WithEvents dgwMacchinari As DataGridView
    Friend WithEvents dgwIstruzioni As DataGridView
    Friend WithEvents bsrigheProdotti As BindingSource
    Friend WithEvents dgwDPI As DataGridView
    Friend WithEvents bsrigheDPI As BindingSource
    Friend WithEvents bsrigheAttrezzature As BindingSource
    Friend WithEvents bsrigheMacchinari As BindingSource
    Friend WithEvents bsrigheIstruzioni As BindingSource
    Friend WithEvents dgwAttrezzature As DataGridView
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents dtProcedureIOPBindingSource As BindingSource
    Friend WithEvents dtProcedureRigheBindingSource As BindingSource
    Friend WithEvents dtProcedureRevisioneBindingSource As BindingSource
    Friend WithEvents dgwcRicercaID As DataGridViewTextBoxColumn
    Friend WithEvents dgwcTesto As DataGridViewTextBoxColumn
    Friend WithEvents dgwcidCategoria As DataGridViewTextBoxColumn
    Friend WithEvents dgwcIDIOP As DataGridViewTextBoxColumn
    Friend WithEvents dgwcIDriga As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tabDisposizioni As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents IdprodottoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ProdottoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSortPro As DataGridViewTextBoxColumn
    Friend WithEvents DGWprodottiid_categoria As DataGridViewTextBoxColumn
    Friend WithEvents IdmacchinarioDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSortMac As DataGridViewTextBoxColumn
    Friend WithEvents IdprodottoDataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ProdottoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSortDPI As DataGridViewTextBoxColumn
    Friend WithEvents IdprodottoDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents ProdottoDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSortAt As DataGridViewTextBoxColumn
    Friend WithEvents IdDataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents IdproceduraDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents NumrevDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents dgwIOP As DataGridView
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitoloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgwcNoteIOP As DataGridViewTextBoxColumn
    Friend WithEvents ImgDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VideoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LivelloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents DT_BarraNavigazione As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents TTBTRicarica As ToolStripButton
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
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents id_istruzioni As DataGridViewTextBoxColumn
    Friend WithEvents testo As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSortIst As DataGridViewTextBoxColumn
End Class
