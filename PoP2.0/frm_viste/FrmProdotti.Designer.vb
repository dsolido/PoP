<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmProdotti
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
        Dim PrezzovenditaLabel As System.Windows.Forms.Label
        Dim DescrizioneclienteLabel As System.Windows.Forms.Label
        Dim TagLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmProdotti))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DSBarNaviga = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bsProdotti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Ordini = New PoP2.Comuni.DS_Ordini()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTRicarica = New System.Windows.Forms.ToolStripButton()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTAggiunge = New System.Windows.Forms.ToolStripButton()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.dgwProdotti = New System.Windows.Forms.DataGridView()
        Me.DGWCId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcProdotto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcIdTipologia = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsCategorie = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGWCid_fornitore = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsFornitori = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGWCid_marca = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsProdottiMarche = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGWCschedatura = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DGWCfatturabile = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DGWCtax = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCquantita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCPrezzounitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCPrezzoconfezione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCsconto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCTipoconfezione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCTag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCdata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tapProdotti = New System.Windows.Forms.TabControl()
        Me.pagProdotti = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tblImmagini = New System.Windows.Forms.TableLayoutPanel()
        Me.tblInfoAggiuntive = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TagTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneclienteTextBox = New System.Windows.Forms.TextBox()
        Me.btPropostaPrezzoVendita = New System.Windows.Forms.Button()
        Me.PrezzovenditaTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgwProdottiSimili = New System.Windows.Forms.DataGridView()
        Me.dgwcSID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSPrezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSFornitore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pagStatistiche = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ckProdotto = New System.Windows.Forms.CheckBox()
        Me.btTracciailGrafico = New System.Windows.Forms.Button()
        Me.cbFornitore = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckFornitore = New System.Windows.Forms.CheckBox()
        Me.ckAnno = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nudAnno = New System.Windows.Forms.NumericUpDown()
        Me.dgwStatistiche = New System.Windows.Forms.DataGridView()
        Me.dgwcStid_prodotto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcStDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcStPrezzoLordo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcStPrezzoNetto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcStidFornitore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcStOccorrenze = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcStAnno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IntercettaErrori = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TableAdapterManager = New PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager()
        Me.TA_fornitori = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_fornitori()
        Me.TaProdottiMarche = New PoP2.Comuni.DS_OrdiniTableAdapters.taProdottiMarche()
        Me.bsImmagini = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaImmagini = New PoP2.Comuni.DS_OrdiniTableAdapters.taImmagini()
        Me.TaProdotti = New PoP2.Comuni.DS_OrdiniTableAdapters.taProdotti()
        Me.TaCategorie = New PoP2.Comuni.DS_OrdiniTableAdapters.taCategorie()
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
        PrezzovenditaLabel = New System.Windows.Forms.Label()
        DescrizioneclienteLabel = New System.Windows.Forms.Label()
        TagLabel = New System.Windows.Forms.Label()
        CType(Me.DSBarNaviga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DSBarNaviga.SuspendLayout()
        CType(Me.bsProdotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwProdotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsFornitori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProdottiMarche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tapProdotti.SuspendLayout()
        Me.pagProdotti.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.tblImmagini.SuspendLayout()
        Me.tblInfoAggiuntive.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgwProdottiSimili, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pagStatistiche.SuspendLayout()
        CType(Me.nudAnno, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwStatistiche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IntercettaErrori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsImmagini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrezzovenditaLabel
        '
        PrezzovenditaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        PrezzovenditaLabel.AutoSize = True
        PrezzovenditaLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        PrezzovenditaLabel.Location = New System.Drawing.Point(133, 74)
        PrezzovenditaLabel.Name = "PrezzovenditaLabel"
        PrezzovenditaLabel.Size = New System.Drawing.Size(119, 17)
        PrezzovenditaLabel.TabIndex = 122
        PrezzovenditaLabel.Text = "Prezzo di Vendita"
        '
        'DescrizioneclienteLabel
        '
        DescrizioneclienteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        DescrizioneclienteLabel.AutoSize = True
        DescrizioneclienteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DescrizioneclienteLabel.Location = New System.Drawing.Point(103, 48)
        DescrizioneclienteLabel.Name = "DescrizioneclienteLabel"
        DescrizioneclienteLabel.Size = New System.Drawing.Size(149, 17)
        DescrizioneclienteLabel.TabIndex = 121
        DescrizioneclienteLabel.Text = "Descrizione di Vendita"
        '
        'TagLabel
        '
        TagLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        TagLabel.AutoSize = True
        TagLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        TagLabel.Location = New System.Drawing.Point(189, 22)
        TagLabel.Name = "TagLabel"
        TagLabel.Size = New System.Drawing.Size(63, 17)
        TagLabel.TabIndex = 123
        TagLabel.Text = "Etichette"
        '
        'DSBarNaviga
        '
        Me.DSBarNaviga.AddNewItem = Nothing
        Me.DSBarNaviga.AutoSize = False
        Me.DSBarNaviga.BindingSource = Me.bsProdotti
        Me.DSBarNaviga.CountItem = Me.ToolStripLabel1
        Me.DSBarNaviga.DeleteItem = Nothing
        Me.DSBarNaviga.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DSBarNaviga.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicarica, Me.TTTestoRicerca, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.TTBTAggiunge, Me.TTBTElimina, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator4, Me.TTPB})
        Me.DSBarNaviga.Location = New System.Drawing.Point(0, 757)
        Me.DSBarNaviga.MoveFirstItem = Me.ToolStripButton1
        Me.DSBarNaviga.MoveLastItem = Me.ToolStripButton4
        Me.DSBarNaviga.MoveNextItem = Me.ToolStripButton3
        Me.DSBarNaviga.MovePreviousItem = Me.ToolStripButton2
        Me.DSBarNaviga.Name = "DSBarNaviga"
        Me.DSBarNaviga.PositionItem = Me.ToolStripTextBox1
        Me.DSBarNaviga.Size = New System.Drawing.Size(1215, 80)
        Me.DSBarNaviga.TabIndex = 120
        Me.DSBarNaviga.Text = "BindingNavigator1"
        '
        'bsProdotti
        '
        Me.bsProdotti.DataMember = "dtProdotti"
        Me.bsProdotti.DataSource = Me.DS_Ordini
        '
        'DS_Ordini
        '
        Me.DS_Ordini.DataSetName = "DS_Ordini"
        Me.DS_Ordini.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 77)
        Me.ToolStripLabel1.Text = "di {0}"
        Me.ToolStripLabel1.ToolTipText = "Numero totale di elementi"
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
        Me.TTBTRicarica.ToolTipText = "Seleziona l'Anno"
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Courier New", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(100, 80)
        Me.TTTestoRicerca.ToolTipText = "Immettere l'anno di lavoro"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(50, 40)
        Me.ToolStripButton1.Text = "Inizio"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(50, 40)
        Me.ToolStripButton2.Text = "Indietro"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 80)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posizione"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 33)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posizione corrente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 80)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(50, 40)
        Me.ToolStripButton3.Text = "Avanti"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(50, 40)
        Me.ToolStripButton4.Text = "Fine"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 80)
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 80)
        '
        'TTPB
        '
        Me.TTPB.Name = "TTPB"
        Me.TTPB.Size = New System.Drawing.Size(200, 77)
        '
        'dgwProdotti
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgwProdotti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwProdotti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwProdotti.AutoGenerateColumns = False
        Me.dgwProdotti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwProdotti.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgwProdotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwProdotti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWCId, Me.dgwcProdotto, Me.dgwcIdTipologia, Me.DGWCid_fornitore, Me.DGWCid_marca, Me.DGWCschedatura, Me.DGWCfatturabile, Me.DGWCtax, Me.DGWCquantita, Me.DGWCPrezzounitario, Me.DGWCPrezzoconfezione, Me.DGWCsconto, Me.DGWCTipoconfezione, Me.DGWCNote, Me.DGWCTag, Me.DGWCdata})
        Me.dgwProdotti.DataSource = Me.bsProdotti
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwProdotti.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgwProdotti.Location = New System.Drawing.Point(3, 3)
        Me.dgwProdotti.Name = "dgwProdotti"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwProdotti.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgwProdotti.RowHeadersWidth = 21
        Me.dgwProdotti.Size = New System.Drawing.Size(1195, 359)
        Me.dgwProdotti.TabIndex = 120
        '
        'DGWCId
        '
        Me.DGWCId.DataPropertyName = "id"
        Me.DGWCId.FillWeight = 15.0!
        Me.DGWCId.HeaderText = "id"
        Me.DGWCId.Name = "DGWCId"
        '
        'dgwcProdotto
        '
        Me.dgwcProdotto.DataPropertyName = "descrizione"
        Me.dgwcProdotto.FillWeight = 50.0!
        Me.dgwcProdotto.HeaderText = "Articolo"
        Me.dgwcProdotto.Name = "dgwcProdotto"
        Me.dgwcProdotto.ToolTipText = "Descrizione dell'articolo"
        '
        'dgwcIdTipologia
        '
        Me.dgwcIdTipologia.DataPropertyName = "id_tipologia"
        Me.dgwcIdTipologia.DataSource = Me.bsCategorie
        Me.dgwcIdTipologia.DisplayMember = "descrizione"
        Me.dgwcIdTipologia.DropDownWidth = 160
        Me.dgwcIdTipologia.FillWeight = 20.0!
        Me.dgwcIdTipologia.HeaderText = "tipo"
        Me.dgwcIdTipologia.Name = "dgwcIdTipologia"
        Me.dgwcIdTipologia.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcIdTipologia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgwcIdTipologia.ToolTipText = "Tipologia articolo"
        Me.dgwcIdTipologia.ValueMember = "id"
        '
        'bsCategorie
        '
        Me.bsCategorie.DataMember = "dtCategorie"
        Me.bsCategorie.DataSource = Me.DS_Ordini
        '
        'DGWCid_fornitore
        '
        Me.DGWCid_fornitore.DataPropertyName = "id_fornitore"
        Me.DGWCid_fornitore.DataSource = Me.bsFornitori
        Me.DGWCid_fornitore.DisplayMember = "anagrafica"
        Me.DGWCid_fornitore.DropDownWidth = 160
        Me.DGWCid_fornitore.FillWeight = 30.0!
        Me.DGWCid_fornitore.HeaderText = "fornitore"
        Me.DGWCid_fornitore.Name = "DGWCid_fornitore"
        Me.DGWCid_fornitore.ValueMember = "id"
        '
        'bsFornitori
        '
        Me.bsFornitori.DataMember = "DT_fornitori"
        Me.bsFornitori.DataSource = Me.DS_Ordini
        '
        'DGWCid_marca
        '
        Me.DGWCid_marca.DataPropertyName = "id_marca"
        Me.DGWCid_marca.DataSource = Me.bsProdottiMarche
        Me.DGWCid_marca.DisplayMember = "Azienda"
        Me.DGWCid_marca.DropDownWidth = 100
        Me.DGWCid_marca.FillWeight = 20.0!
        Me.DGWCid_marca.HeaderText = "marca"
        Me.DGWCid_marca.Name = "DGWCid_marca"
        Me.DGWCid_marca.ToolTipText = "Marca dell'articolo"
        Me.DGWCid_marca.ValueMember = "id"
        '
        'bsProdottiMarche
        '
        Me.bsProdottiMarche.DataMember = "dtProdottiMarche"
        Me.bsProdottiMarche.DataSource = Me.DS_Ordini
        '
        'DGWCschedatura
        '
        Me.DGWCschedatura.DataPropertyName = "schedatura"
        Me.DGWCschedatura.FalseValue = "0"
        Me.DGWCschedatura.FillWeight = 10.0!
        Me.DGWCschedatura.HeaderText = "SC"
        Me.DGWCschedatura.IndeterminateValue = "0"
        Me.DGWCschedatura.Name = "DGWCschedatura"
        Me.DGWCschedatura.ToolTipText = "Schedato ?"
        Me.DGWCschedatura.TrueValue = "1"
        '
        'DGWCfatturabile
        '
        Me.DGWCfatturabile.DataPropertyName = "fatturabile"
        Me.DGWCfatturabile.FalseValue = "0"
        Me.DGWCfatturabile.FillWeight = 10.0!
        Me.DGWCfatturabile.HeaderText = "FA"
        Me.DGWCfatturabile.IndeterminateValue = "0"
        Me.DGWCfatturabile.Name = "DGWCfatturabile"
        Me.DGWCfatturabile.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCfatturabile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCfatturabile.ToolTipText = "Fatturabile ?"
        Me.DGWCfatturabile.TrueValue = "1"
        '
        'DGWCtax
        '
        Me.DGWCtax.DataPropertyName = "tax"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.DGWCtax.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGWCtax.FillWeight = 10.0!
        Me.DGWCtax.HeaderText = "Tax"
        Me.DGWCtax.Name = "DGWCtax"
        Me.DGWCtax.ToolTipText = "Tasse applicate all'articolo"
        '
        'DGWCquantita
        '
        Me.DGWCquantita.DataPropertyName = "quantita_conf"
        Me.DGWCquantita.FillWeight = 15.0!
        Me.DGWCquantita.HeaderText = "Q.tà"
        Me.DGWCquantita.Name = "DGWCquantita"
        '
        'DGWCPrezzounitario
        '
        Me.DGWCPrezzounitario.DataPropertyName = "prezzounitario"
        Me.DGWCPrezzounitario.FillWeight = 25.0!
        Me.DGWCPrezzounitario.HeaderText = "€ sing"
        Me.DGWCPrezzounitario.Name = "DGWCPrezzounitario"
        Me.DGWCPrezzounitario.ToolTipText = "Prezzo unitario"
        '
        'DGWCPrezzoconfezione
        '
        Me.DGWCPrezzoconfezione.DataPropertyName = "prezzoconfezione"
        DataGridViewCellStyle4.Format = "C2"
        Me.DGWCPrezzoconfezione.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGWCPrezzoconfezione.FillWeight = 25.0!
        Me.DGWCPrezzoconfezione.HeaderText = "€ conf"
        Me.DGWCPrezzoconfezione.Name = "DGWCPrezzoconfezione"
        Me.DGWCPrezzoconfezione.ToolTipText = "Prezzo per la confezione"
        '
        'DGWCsconto
        '
        Me.DGWCsconto.DataPropertyName = "sconto"
        Me.DGWCsconto.FillWeight = 10.0!
        Me.DGWCsconto.HeaderText = "sconto"
        Me.DGWCsconto.Name = "DGWCsconto"
        '
        'DGWCTipoconfezione
        '
        Me.DGWCTipoconfezione.DataPropertyName = "tipoconfezione"
        Me.DGWCTipoconfezione.FillWeight = 15.0!
        Me.DGWCTipoconfezione.HeaderText = "conf"
        Me.DGWCTipoconfezione.Name = "DGWCTipoconfezione"
        Me.DGWCTipoconfezione.ToolTipText = "Confezionamento"
        '
        'DGWCNote
        '
        Me.DGWCNote.DataPropertyName = "note"
        Me.DGWCNote.FillWeight = 20.0!
        Me.DGWCNote.HeaderText = "note"
        Me.DGWCNote.Name = "DGWCNote"
        Me.DGWCNote.ToolTipText = "Indicare l'utilizzo"
        '
        'DGWCTag
        '
        Me.DGWCTag.DataPropertyName = "tag"
        Me.DGWCTag.FillWeight = 30.0!
        Me.DGWCTag.HeaderText = "tag"
        Me.DGWCTag.Name = "DGWCTag"
        Me.DGWCTag.ToolTipText = "Indicare i campi di ricerca"
        Me.DGWCTag.Visible = False
        '
        'DGWCdata
        '
        Me.DGWCdata.DataPropertyName = "data"
        Me.DGWCdata.FillWeight = 20.0!
        Me.DGWCdata.HeaderText = "data"
        Me.DGWCdata.Name = "DGWCdata"
        Me.DGWCdata.ToolTipText = "Data inserimento"
        '
        'tapProdotti
        '
        Me.tapProdotti.Controls.Add(Me.pagProdotti)
        Me.tapProdotti.Controls.Add(Me.pagStatistiche)
        Me.tapProdotti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tapProdotti.Location = New System.Drawing.Point(0, 0)
        Me.tapProdotti.Name = "tapProdotti"
        Me.tapProdotti.SelectedIndex = 0
        Me.tapProdotti.Size = New System.Drawing.Size(1215, 757)
        Me.tapProdotti.TabIndex = 121
        '
        'pagProdotti
        '
        Me.pagProdotti.AutoScroll = True
        Me.pagProdotti.Controls.Add(Me.TableLayoutPanel1)
        Me.pagProdotti.Location = New System.Drawing.Point(4, 22)
        Me.pagProdotti.Name = "pagProdotti"
        Me.pagProdotti.Padding = New System.Windows.Forms.Padding(3)
        Me.pagProdotti.Size = New System.Drawing.Size(1207, 731)
        Me.pagProdotti.TabIndex = 0
        Me.pagProdotti.Text = "Elenco Prodotti"
        Me.pagProdotti.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.dgwProdotti, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tblImmagini, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.34483!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.65517!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1201, 725)
        Me.TableLayoutPanel1.TabIndex = 127
        '
        'tblImmagini
        '
        Me.tblImmagini.ColumnCount = 2
        Me.tblImmagini.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.28033!))
        Me.tblImmagini.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.71967!))
        Me.tblImmagini.Controls.Add(Me.tblInfoAggiuntive, 1, 0)
        Me.tblImmagini.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblImmagini.Location = New System.Drawing.Point(3, 368)
        Me.tblImmagini.Name = "tblImmagini"
        Me.tblImmagini.RowCount = 1
        Me.tblImmagini.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.tblImmagini.Size = New System.Drawing.Size(1195, 354)
        Me.tblImmagini.TabIndex = 121
        '
        'tblInfoAggiuntive
        '
        Me.tblInfoAggiuntive.ColumnCount = 2
        Me.tblInfoAggiuntive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.29925!))
        Me.tblInfoAggiuntive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.70074!))
        Me.tblInfoAggiuntive.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblInfoAggiuntive.Controls.Add(Me.GroupBox1, 1, 0)
        Me.tblInfoAggiuntive.Controls.Add(Me.Panel1, 0, 0)
        Me.tblInfoAggiuntive.Controls.Add(Me.GroupBox2, 1, 1)
        Me.tblInfoAggiuntive.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblInfoAggiuntive.Location = New System.Drawing.Point(328, 3)
        Me.tblInfoAggiuntive.Name = "tblInfoAggiuntive"
        Me.tblInfoAggiuntive.RowCount = 2
        Me.tblInfoAggiuntive.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.09524!))
        Me.tblInfoAggiuntive.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.90476!))
        Me.tblInfoAggiuntive.Size = New System.Drawing.Size(864, 348)
        Me.tblInfoAggiuntive.TabIndex = 122
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TagTextBox)
        Me.GroupBox1.Controls.Add(Me.DescrizioneclienteTextBox)
        Me.GroupBox1.Controls.Add(Me.btPropostaPrezzoVendita)
        Me.GroupBox1.Controls.Add(Me.PrezzovenditaTextBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(264, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(597, 126)
        Me.GroupBox1.TabIndex = 128
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informazioni aggiuntive per il prodotto"
        '
        'TagTextBox
        '
        Me.TagTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProdotti, "tag", True))
        Me.TagTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TagTextBox.Location = New System.Drawing.Point(6, 19)
        Me.TagTextBox.Name = "TagTextBox"
        Me.TagTextBox.Size = New System.Drawing.Size(564, 23)
        Me.TagTextBox.TabIndex = 124
        '
        'DescrizioneclienteTextBox
        '
        Me.DescrizioneclienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProdotti, "descrizionecliente", True))
        Me.DescrizioneclienteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.DescrizioneclienteTextBox.Location = New System.Drawing.Point(6, 45)
        Me.DescrizioneclienteTextBox.Name = "DescrizioneclienteTextBox"
        Me.DescrizioneclienteTextBox.Size = New System.Drawing.Size(564, 23)
        Me.DescrizioneclienteTextBox.TabIndex = 122
        '
        'btPropostaPrezzoVendita
        '
        Me.btPropostaPrezzoVendita.Location = New System.Drawing.Point(126, 73)
        Me.btPropostaPrezzoVendita.Name = "btPropostaPrezzoVendita"
        Me.btPropostaPrezzoVendita.Size = New System.Drawing.Size(113, 23)
        Me.btPropostaPrezzoVendita.TabIndex = 126
        Me.btPropostaPrezzoVendita.Text = "Proponi Prezzo"
        Me.btPropostaPrezzoVendita.UseVisualStyleBackColor = True
        '
        'PrezzovenditaTextBox
        '
        Me.PrezzovenditaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsProdotti, "prezzovendita", True))
        Me.PrezzovenditaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PrezzovenditaTextBox.Location = New System.Drawing.Point(6, 71)
        Me.PrezzovenditaTextBox.Name = "PrezzovenditaTextBox"
        Me.PrezzovenditaTextBox.Size = New System.Drawing.Size(100, 23)
        Me.PrezzovenditaTextBox.TabIndex = 123
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(PrezzovenditaLabel)
        Me.Panel1.Controls.Add(DescrizioneclienteLabel)
        Me.Panel1.Controls.Add(TagLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 126)
        Me.Panel1.TabIndex = 128
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgwProdottiSimili)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(264, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(597, 210)
        Me.GroupBox2.TabIndex = 129
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Prodotti Attinenti"
        '
        'dgwProdottiSimili
        '
        Me.dgwProdottiSimili.AllowUserToAddRows = False
        Me.dgwProdottiSimili.AllowUserToDeleteRows = False
        Me.dgwProdottiSimili.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwProdottiSimili.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgwProdottiSimili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwProdottiSimili.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcSID, Me.dgwcSDescrizione, Me.dgwcSPrezzo, Me.dgwcSFornitore})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwProdottiSimili.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgwProdottiSimili.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwProdottiSimili.Location = New System.Drawing.Point(3, 16)
        Me.dgwProdottiSimili.Name = "dgwProdottiSimili"
        Me.dgwProdottiSimili.ReadOnly = True
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwProdottiSimili.RowHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgwProdottiSimili.RowHeadersWidth = 21
        Me.dgwProdottiSimili.Size = New System.Drawing.Size(591, 191)
        Me.dgwProdottiSimili.TabIndex = 125
        '
        'dgwcSID
        '
        Me.dgwcSID.FillWeight = 30.0!
        Me.dgwcSID.HeaderText = "id"
        Me.dgwcSID.Name = "dgwcSID"
        Me.dgwcSID.ReadOnly = True
        '
        'dgwcSDescrizione
        '
        Me.dgwcSDescrizione.HeaderText = "Descrizione"
        Me.dgwcSDescrizione.Name = "dgwcSDescrizione"
        Me.dgwcSDescrizione.ReadOnly = True
        '
        'dgwcSPrezzo
        '
        Me.dgwcSPrezzo.FillWeight = 40.0!
        Me.dgwcSPrezzo.HeaderText = "Prezzo"
        Me.dgwcSPrezzo.Name = "dgwcSPrezzo"
        Me.dgwcSPrezzo.ReadOnly = True
        '
        'dgwcSFornitore
        '
        Me.dgwcSFornitore.FillWeight = 50.0!
        Me.dgwcSFornitore.HeaderText = "Fornitore"
        Me.dgwcSFornitore.Name = "dgwcSFornitore"
        Me.dgwcSFornitore.ReadOnly = True
        '
        'pagStatistiche
        '
        Me.pagStatistiche.Controls.Add(Me.Label3)
        Me.pagStatistiche.Controls.Add(Me.ckProdotto)
        Me.pagStatistiche.Controls.Add(Me.btTracciailGrafico)
        Me.pagStatistiche.Controls.Add(Me.cbFornitore)
        Me.pagStatistiche.Controls.Add(Me.Label2)
        Me.pagStatistiche.Controls.Add(Me.ckFornitore)
        Me.pagStatistiche.Controls.Add(Me.ckAnno)
        Me.pagStatistiche.Controls.Add(Me.Label1)
        Me.pagStatistiche.Controls.Add(Me.nudAnno)
        Me.pagStatistiche.Controls.Add(Me.dgwStatistiche)
        Me.pagStatistiche.Location = New System.Drawing.Point(4, 22)
        Me.pagStatistiche.Name = "pagStatistiche"
        Me.pagStatistiche.Padding = New System.Windows.Forms.Padding(3)
        Me.pagStatistiche.Size = New System.Drawing.Size(1207, 731)
        Me.pagStatistiche.TabIndex = 1
        Me.pagStatistiche.Text = "Statistiche Prodotti"
        Me.pagStatistiche.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1037, 540)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Prodotto"
        '
        'ckProdotto
        '
        Me.ckProdotto.AutoSize = True
        Me.ckProdotto.Location = New System.Drawing.Point(997, 539)
        Me.ckProdotto.Name = "ckProdotto"
        Me.ckProdotto.Size = New System.Drawing.Size(15, 14)
        Me.ckProdotto.TabIndex = 11
        Me.ckProdotto.UseVisualStyleBackColor = True
        '
        'btTracciailGrafico
        '
        Me.btTracciailGrafico.Location = New System.Drawing.Point(999, 684)
        Me.btTracciailGrafico.Name = "btTracciailGrafico"
        Me.btTracciailGrafico.Size = New System.Drawing.Size(107, 23)
        Me.btTracciailGrafico.TabIndex = 10
        Me.btTracciailGrafico.Text = "Traccia il Grafico"
        Me.btTracciailGrafico.UseVisualStyleBackColor = True
        '
        'cbFornitore
        '
        Me.cbFornitore.DataSource = Me.bsFornitori
        Me.cbFornitore.DisplayMember = "anagrafica"
        Me.cbFornitore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.cbFornitore.FormattingEnabled = True
        Me.cbFornitore.Location = New System.Drawing.Point(1042, 594)
        Me.cbFornitore.Name = "cbFornitore"
        Me.cbFornitore.Size = New System.Drawing.Size(157, 28)
        Me.cbFornitore.TabIndex = 9
        Me.cbFornitore.ValueMember = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1037, 576)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fornitore"
        '
        'ckFornitore
        '
        Me.ckFornitore.AutoSize = True
        Me.ckFornitore.Location = New System.Drawing.Point(999, 601)
        Me.ckFornitore.Name = "ckFornitore"
        Me.ckFornitore.Size = New System.Drawing.Size(15, 14)
        Me.ckFornitore.TabIndex = 5
        Me.ckFornitore.UseVisualStyleBackColor = True
        '
        'ckAnno
        '
        Me.ckAnno.AutoSize = True
        Me.ckAnno.Checked = True
        Me.ckAnno.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckAnno.Location = New System.Drawing.Point(1001, 648)
        Me.ckAnno.Name = "ckAnno"
        Me.ckAnno.Size = New System.Drawing.Size(15, 14)
        Me.ckAnno.TabIndex = 4
        Me.ckAnno.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1039, 625)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Anno Competenza"
        '
        'nudAnno
        '
        Me.nudAnno.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nudAnno.Location = New System.Drawing.Point(1042, 641)
        Me.nudAnno.Name = "nudAnno"
        Me.nudAnno.Size = New System.Drawing.Size(106, 26)
        Me.nudAnno.TabIndex = 2
        '
        'dgwStatistiche
        '
        Me.dgwStatistiche.AllowUserToAddRows = False
        Me.dgwStatistiche.AllowUserToDeleteRows = False
        Me.dgwStatistiche.AllowUserToOrderColumns = True
        Me.dgwStatistiche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwStatistiche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwStatistiche.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcStid_prodotto, Me.dgwcStDescrizione, Me.dgwcStPrezzoLordo, Me.dgwcStPrezzoNetto, Me.dgwcStidFornitore, Me.dgwcStOccorrenze, Me.dgwcStAnno})
        Me.dgwStatistiche.Location = New System.Drawing.Point(26, 506)
        Me.dgwStatistiche.Name = "dgwStatistiche"
        Me.dgwStatistiche.ReadOnly = True
        Me.dgwStatistiche.Size = New System.Drawing.Size(943, 201)
        Me.dgwStatistiche.TabIndex = 1
        '
        'dgwcStid_prodotto
        '
        Me.dgwcStid_prodotto.FillWeight = 20.0!
        Me.dgwcStid_prodotto.HeaderText = "id Prodotto"
        Me.dgwcStid_prodotto.Name = "dgwcStid_prodotto"
        Me.dgwcStid_prodotto.ReadOnly = True
        '
        'dgwcStDescrizione
        '
        Me.dgwcStDescrizione.FillWeight = 60.0!
        Me.dgwcStDescrizione.HeaderText = "Descrizione"
        Me.dgwcStDescrizione.Name = "dgwcStDescrizione"
        Me.dgwcStDescrizione.ReadOnly = True
        '
        'dgwcStPrezzoLordo
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        Me.dgwcStPrezzoLordo.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgwcStPrezzoLordo.FillWeight = 30.0!
        Me.dgwcStPrezzoLordo.HeaderText = "Totale Lordo"
        Me.dgwcStPrezzoLordo.Name = "dgwcStPrezzoLordo"
        Me.dgwcStPrezzoLordo.ReadOnly = True
        '
        'dgwcStPrezzoNetto
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "C2"
        Me.dgwcStPrezzoNetto.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgwcStPrezzoNetto.FillWeight = 30.0!
        Me.dgwcStPrezzoNetto.HeaderText = "Totale Netto"
        Me.dgwcStPrezzoNetto.Name = "dgwcStPrezzoNetto"
        Me.dgwcStPrezzoNetto.ReadOnly = True
        '
        'dgwcStidFornitore
        '
        Me.dgwcStidFornitore.FillWeight = 20.0!
        Me.dgwcStidFornitore.HeaderText = "idFornitore"
        Me.dgwcStidFornitore.Name = "dgwcStidFornitore"
        Me.dgwcStidFornitore.ReadOnly = True
        '
        'dgwcStOccorrenze
        '
        Me.dgwcStOccorrenze.FillWeight = 30.0!
        Me.dgwcStOccorrenze.HeaderText = "Occorrenza"
        Me.dgwcStOccorrenze.Name = "dgwcStOccorrenze"
        Me.dgwcStOccorrenze.ReadOnly = True
        '
        'dgwcStAnno
        '
        Me.dgwcStAnno.FillWeight = 30.0!
        Me.dgwcStAnno.HeaderText = "Periodo"
        Me.dgwcStAnno.Name = "dgwcStAnno"
        Me.dgwcStAnno.ReadOnly = True
        '
        'IntercettaErrori
        '
        Me.IntercettaErrori.ContainerControl = Me
        Me.IntercettaErrori.Icon = CType(resources.GetObject("IntercettaErrori.Icon"), System.Drawing.Icon)
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TA_fornitori
        '
        Me.TA_fornitori.ClearBeforeFill = True
        '
        'TaProdottiMarche
        '
        Me.TaProdottiMarche.ClearBeforeFill = True
        '
        'bsImmagini
        '
        Me.bsImmagini.DataMember = "dtImmagini"
        Me.bsImmagini.DataSource = Me.DS_Ordini
        '
        'TaImmagini
        '
        Me.TaImmagini.ClearBeforeFill = True
        '
        'TaProdotti
        '
        Me.TaProdotti.ClearBeforeFill = True
        '
        'TaCategorie
        '
        Me.TaCategorie.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 73
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 245
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Prezzo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 98
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fornitore"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 122
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn5.FillWeight = 15.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 54
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "descrizione"
        Me.DataGridViewTextBoxColumn6.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Articolo"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ToolTipText = "Descrizione dell'articolo"
        Me.DataGridViewTextBoxColumn6.Width = 179
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "tax"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn7.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Tax"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ToolTipText = "Tasse applicate all'articolo"
        Me.DataGridViewTextBoxColumn7.Width = 36
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "quantita_conf"
        Me.DataGridViewTextBoxColumn8.FillWeight = 15.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Q.tà"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 54
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "prezzounitario"
        Me.DataGridViewTextBoxColumn9.FillWeight = 25.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "€ sing"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ToolTipText = "Prezzo unitario"
        Me.DataGridViewTextBoxColumn9.Width = 89
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "prezzoconfezione"
        DataGridViewCellStyle13.Format = "C2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn10.FillWeight = 25.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "€ conf"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ToolTipText = "Prezzo per la confezione"
        Me.DataGridViewTextBoxColumn10.Width = 90
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "sconto"
        Me.DataGridViewTextBoxColumn11.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "sconto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 36
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "tipoconfezione"
        Me.DataGridViewTextBoxColumn12.FillWeight = 15.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "conf"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ToolTipText = "Confezionamento"
        Me.DataGridViewTextBoxColumn12.Width = 54
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn13.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "note"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ToolTipText = "Indicare l'utilizzo"
        Me.DataGridViewTextBoxColumn13.Width = 72
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "tag"
        Me.DataGridViewTextBoxColumn14.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "tag"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ToolTipText = "Indicare i campi di ricerca"
        Me.DataGridViewTextBoxColumn14.Width = 107
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn15.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "data"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ToolTipText = "Data inserimento"
        Me.DataGridViewTextBoxColumn15.Width = 72
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn16.HeaderText = "id Prodotto"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Width = 82
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Width = 245
        '
        'DataGridViewTextBoxColumn18
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "C2"
        Me.DataGridViewTextBoxColumn18.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn18.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Totale Lordo"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.Width = 123
        '
        'DataGridViewTextBoxColumn19
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "C2"
        Me.DataGridViewTextBoxColumn19.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn19.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn19.HeaderText = "Totale Netto"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.Width = 123
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn20.HeaderText = "idFornitore"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.Width = 82
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn21.HeaderText = "Occorrenza"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.Width = 122
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn22.HeaderText = "Anno"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.Width = 123
        '
        'FrmProdotti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1215, 837)
        Me.Controls.Add(Me.tapProdotti)
        Me.Controls.Add(Me.DSBarNaviga)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmProdotti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmProdotti"
        CType(Me.DSBarNaviga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DSBarNaviga.ResumeLayout(False)
        Me.DSBarNaviga.PerformLayout()
        CType(Me.bsProdotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwProdotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsFornitori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProdottiMarche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tapProdotti.ResumeLayout(False)
        Me.pagProdotti.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.tblImmagini.ResumeLayout(False)
        Me.tblInfoAggiuntive.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgwProdottiSimili, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pagStatistiche.ResumeLayout(False)
        Me.pagStatistiche.PerformLayout()
        CType(Me.nudAnno, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwStatistiche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IntercettaErrori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsImmagini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSBarNaviga As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TTBTRicarica As ToolStripButton
    Friend WithEvents TTTestoRicerca As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TTPB As ToolStripProgressBar
    Friend WithEvents DS_Ordini As DS_Ordini
    Friend WithEvents TableAdapterManager As DS_OrdiniTableAdapters.TableAdapterManager
    Friend WithEvents dgwProdotti As DataGridView
    Friend WithEvents bsFornitori As BindingSource
    Friend WithEvents TA_fornitori As DS_OrdiniTableAdapters.TA_fornitori
    Friend WithEvents bsProdottiMarche As BindingSource
    Friend WithEvents TaProdottiMarche As DS_OrdiniTableAdapters.taProdottiMarche
    Friend WithEvents tapProdotti As TabControl
    Friend WithEvents pagProdotti As TabPage
    Friend WithEvents pagStatistiche As TabPage
    Friend WithEvents bsImmagini As BindingSource
    Friend WithEvents TaImmagini As DS_OrdiniTableAdapters.taImmagini
    Friend WithEvents bsProdotti As BindingSource
    Friend WithEvents TaProdotti As DS_OrdiniTableAdapters.taProdotti
    Friend WithEvents TaCategorie As DS_OrdiniTableAdapters.taCategorie
    Friend WithEvents bsCategorie As BindingSource
    Friend WithEvents IntercettaErrori As ErrorProvider
    Friend WithEvents dgwStatistiche As DataGridView
    Friend WithEvents cbFornitore As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ckFornitore As CheckBox
    Friend WithEvents ckAnno As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents nudAnno As NumericUpDown
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
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents btTracciailGrafico As Button
    Friend WithEvents DGWCId As DataGridViewTextBoxColumn
    Friend WithEvents dgwcProdotto As DataGridViewTextBoxColumn
    Friend WithEvents dgwcIdTipologia As DataGridViewComboBoxColumn
    Friend WithEvents DGWCid_fornitore As DataGridViewComboBoxColumn
    Friend WithEvents DGWCid_marca As DataGridViewComboBoxColumn
    Friend WithEvents DGWCschedatura As DataGridViewCheckBoxColumn
    Friend WithEvents DGWCfatturabile As DataGridViewCheckBoxColumn
    Friend WithEvents DGWCtax As DataGridViewTextBoxColumn
    Friend WithEvents DGWCquantita As DataGridViewTextBoxColumn
    Friend WithEvents DGWCPrezzounitario As DataGridViewTextBoxColumn
    Friend WithEvents DGWCPrezzoconfezione As DataGridViewTextBoxColumn
    Friend WithEvents DGWCsconto As DataGridViewTextBoxColumn
    Friend WithEvents DGWCTipoconfezione As DataGridViewTextBoxColumn
    Friend WithEvents DGWCNote As DataGridViewTextBoxColumn
    Friend WithEvents DGWCTag As DataGridViewTextBoxColumn
    Friend WithEvents DGWCdata As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents ckProdotto As CheckBox
    Friend WithEvents dgwcStid_prodotto As DataGridViewTextBoxColumn
    Friend WithEvents dgwcStDescrizione As DataGridViewTextBoxColumn
    Friend WithEvents dgwcStPrezzoLordo As DataGridViewTextBoxColumn
    Friend WithEvents dgwcStPrezzoNetto As DataGridViewTextBoxColumn
    Friend WithEvents dgwcStidFornitore As DataGridViewTextBoxColumn
    Friend WithEvents dgwcStOccorrenze As DataGridViewTextBoxColumn
    Friend WithEvents dgwcStAnno As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents tblImmagini As TableLayoutPanel
    Friend WithEvents tblInfoAggiuntive As TableLayoutPanel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TagTextBox As TextBox
    Friend WithEvents DescrizioneclienteTextBox As TextBox
    Friend WithEvents btPropostaPrezzoVendita As Button
    Friend WithEvents PrezzovenditaTextBox As TextBox
    Friend WithEvents dgwProdottiSimili As DataGridView
    Friend WithEvents dgwcSID As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSDescrizione As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSPrezzo As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSFornitore As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents GroupBox2 As GroupBox
End Class
