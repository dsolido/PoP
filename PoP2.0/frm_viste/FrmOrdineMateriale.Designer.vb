<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOrdineMateriale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOrdineMateriale))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TTLB2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TTLB1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BN_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bsOrdini = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Ordini = New PoP2.Comuni.DS_Ordini()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.TTBTRicerca = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
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
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.tsMenuFiltro = New System.Windows.Forms.ToolStripDropDownButton()
        Me.tsFiltro = New System.Windows.Forms.ToolStripMenuItem()
        Me.TTBTRicarica = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TT_CB_mese = New System.Windows.Forms.ToolStripComboBox()
        Me.TTPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.TT_CB_anno = New System.Windows.Forms.ToolStripComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TL_1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_ordinirighe = New System.Windows.Forms.DataGridView()
        Me.DGWCposizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCunitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.scontoTextColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.taxTextColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCtotalenetto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_ordini = New System.Windows.Forms.DataGridView()
        Me.DGWCoInviato = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DGWCoID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataordineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocietaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCofornitore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.anagrafica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCototalenetto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnnotazioniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcId_webordini = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.dgwcStato = New System.Windows.Forms.DataGridViewImageColumn()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LB_O = New System.Windows.Forms.Label()
        Me.LB_C = New System.Windows.Forms.Label()
        Me.LB_T = New System.Windows.Forms.Label()
        Me.LBT = New System.Windows.Forms.Label()
        Me.LBC = New System.Windows.Forms.Label()
        Me.LBO = New System.Windows.Forms.Label()
        Me.lbOrdineRighe = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableAdapterManager = New PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager()
        Me.TA_ordinirighe = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_ordinirighe()
        Me.TA_ordini = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_ordini()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Col_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.totRiga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCfatturabile = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DGWCidRighe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCdescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCqta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RELrigheordineBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_righeOrdini = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusStrip1.SuspendLayout()
        CType(Me.BN_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BN_barra.SuspendLayout()
        CType(Me.bsOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TL_1.SuspendLayout()
        CType(Me.DG_ordinirighe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.RELrigheordineBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_righeOrdini, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "fatturabile"
        Me.DataGridViewTextBoxColumn14.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "F"
        Me.DataGridViewTextBoxColumn14.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn14.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn14.Width = 34
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTLB2, Me.TTLB1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 839)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1261, 22)
        Me.StatusStrip1.TabIndex = 121
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TTLB2
        '
        Me.TTLB2.Name = "TTLB2"
        Me.TTLB2.Size = New System.Drawing.Size(10, 17)
        Me.TTLB2.Text = " "
        '
        'TTLB1
        '
        Me.TTLB1.Name = "TTLB1"
        Me.TTLB1.Size = New System.Drawing.Size(296, 17)
        Me.TTLB1.Text = "F7 su descrizione prodotto, cerca e inserisce nuova riga"
        '
        'BN_barra
        '
        Me.BN_barra.AddNewItem = Nothing
        Me.BN_barra.AutoSize = False
        Me.BN_barra.BindingSource = Me.bsOrdini
        Me.BN_barra.CountItem = Me.BindingNavigatorCountItem
        Me.BN_barra.DeleteItem = Nothing
        Me.BN_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BN_barra.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.BN_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTestoRicerca, Me.TTBTRicerca, Me.ToolStripSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTannulla, Me.TTBTSalva, Me.TTBTStampa, Me.TTBTTermina, Me.tsMenuFiltro, Me.TTBTRicarica, Me.ToolStripSeparator1, Me.TT_CB_mese, Me.TTPB, Me.TT_CB_anno})
        Me.BN_barra.Location = New System.Drawing.Point(0, 761)
        Me.BN_barra.MoveFirstItem = Me.BindingNavigatorMoveLastItem
        Me.BN_barra.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BN_barra.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BN_barra.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BN_barra.Name = "BN_barra"
        Me.BN_barra.PositionItem = Me.BindingNavigatorPositionItem
        Me.BN_barra.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BN_barra.Size = New System.Drawing.Size(1261, 78)
        Me.BN_barra.TabIndex = 122
        Me.BN_barra.Text = "BarraNavigazione"
        '
        'bsOrdini
        '
        Me.bsOrdini.DataMember = "DT_ordini"
        Me.bsOrdini.DataSource = Me.DS_Ordini
        '
        'DS_Ordini
        '
        Me.DS_Ordini.DataSetName = "DS_Ordini"
        Me.DS_Ordini.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 75)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(116, 78)
        Me.TTTestoRicerca.ToolTipText = "Immettere l'anno di lavoro"
        '
        'TTBTRicerca
        '
        Me.TTBTRicerca.AutoSize = False
        Me.TTBTRicerca.Image = CType(resources.GetObject("TTBTRicerca.Image"), System.Drawing.Image)
        Me.TTBTRicerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTRicerca.Name = "TTBTRicerca"
        Me.TTBTRicerca.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicerca.Text = "Cerca"
        Me.TTBTRicerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicerca.ToolTipText = "Seleziona l'Anno"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 78)
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
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 78)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(58, 33)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 78)
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 78)
        '
        'TTBTAggiunge
        '
        Me.TTBTAggiunge.AutoSize = False
        Me.TTBTAggiunge.Image = CType(resources.GetObject("TTBTAggiunge.Image"), System.Drawing.Image)
        Me.TTBTAggiunge.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTAggiunge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTAggiunge.Name = "TTBTAggiunge"
        Me.TTBTAggiunge.RightToLeftAutoMirrorImage = True
        Me.TTBTAggiunge.Size = New System.Drawing.Size(60, 70)
        Me.TTBTAggiunge.Text = "Aggiunge"
        Me.TTBTAggiunge.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTAggiunge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTAggiunge.Visible = False
        '
        'TTBTModifica
        '
        Me.TTBTModifica.AutoSize = False
        Me.TTBTModifica.Image = CType(resources.GetObject("TTBTModifica.Image"), System.Drawing.Image)
        Me.TTBTModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTModifica.Name = "TTBTModifica"
        Me.TTBTModifica.RightToLeftAutoMirrorImage = True
        Me.TTBTModifica.Size = New System.Drawing.Size(60, 70)
        Me.TTBTModifica.Text = "Modifica"
        Me.TTBTModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTModifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTElimina
        '
        Me.TTBTElimina.AutoSize = False
        Me.TTBTElimina.Image = CType(resources.GetObject("TTBTElimina.Image"), System.Drawing.Image)
        Me.TTBTElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTElimina.Name = "TTBTElimina"
        Me.TTBTElimina.RightToLeftAutoMirrorImage = True
        Me.TTBTElimina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTElimina.Text = "Elimina"
        Me.TTBTElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTElimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTannulla
        '
        Me.TTBTannulla.AutoSize = False
        Me.TTBTannulla.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TTBTannulla.Image = CType(resources.GetObject("TTBTannulla.Image"), System.Drawing.Image)
        Me.TTBTannulla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTannulla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTannulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTannulla.Name = "TTBTannulla"
        Me.TTBTannulla.Size = New System.Drawing.Size(50, 70)
        Me.TTBTannulla.Text = "Annulla"
        Me.TTBTannulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTannulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'TTBTTermina
        '
        Me.TTBTTermina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TTBTTermina.AutoSize = False
        Me.TTBTTermina.Image = CType(resources.GetObject("TTBTTermina.Image"), System.Drawing.Image)
        Me.TTBTTermina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTTermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTTermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTTermina.Name = "TTBTTermina"
        Me.TTBTTermina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTTermina.Text = "Termina"
        Me.TTBTTermina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTTermina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tsMenuFiltro
        '
        Me.tsMenuFiltro.AutoSize = False
        Me.tsMenuFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsMenuFiltro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFiltro})
        Me.tsMenuFiltro.Image = CType(resources.GetObject("tsMenuFiltro.Image"), System.Drawing.Image)
        Me.tsMenuFiltro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsMenuFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsMenuFiltro.Name = "tsMenuFiltro"
        Me.tsMenuFiltro.Size = New System.Drawing.Size(50, 70)
        Me.tsMenuFiltro.Text = "ToolStripSplitButton1"
        Me.tsMenuFiltro.ToolTipText = "Filtro Ordini Stampati/Periodo"
        '
        'tsFiltro
        '
        Me.tsFiltro.AutoSize = False
        Me.tsFiltro.CheckOnClick = True
        Me.tsFiltro.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsFiltro.Image = CType(resources.GetObject("tsFiltro.Image"), System.Drawing.Image)
        Me.tsFiltro.Name = "tsFiltro"
        Me.tsFiltro.Size = New System.Drawing.Size(180, 48)
        Me.tsFiltro.Text = "Non Stampati"
        Me.tsFiltro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.tsFiltro.ToolTipText = "Attivato Filtra solo Gli ordini non stampati" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Disattivato Filtra gli ordini in ba" &
    "se al periodo" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TTBTRicarica
        '
        Me.TTBTRicarica.AutoSize = False
        Me.TTBTRicarica.Image = CType(resources.GetObject("TTBTRicarica.Image"), System.Drawing.Image)
        Me.TTBTRicarica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicarica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicarica.Name = "TTBTRicarica"
        Me.TTBTRicarica.RightToLeftAutoMirrorImage = True
        Me.TTBTRicarica.Size = New System.Drawing.Size(60, 70)
        Me.TTBTRicarica.Text = "Ricarica"
        Me.TTBTRicarica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicarica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicarica.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 78)
        '
        'TT_CB_mese
        '
        Me.TT_CB_mese.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_mese.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_mese.Name = "TT_CB_mese"
        Me.TT_CB_mese.Size = New System.Drawing.Size(150, 78)
        '
        'TTPB
        '
        Me.TTPB.Name = "TTPB"
        Me.TTPB.Size = New System.Drawing.Size(233, 95)
        Me.TTPB.Visible = False
        '
        'TT_CB_anno
        '
        Me.TT_CB_anno.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_anno.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_anno.Name = "TT_CB_anno"
        Me.TT_CB_anno.Size = New System.Drawing.Size(140, 38)
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "omino_no.ico")
        Me.ImageList1.Images.SetKeyName(1, "omino_stampa48.png")
        '
        'TL_1
        '
        Me.TL_1.ColumnCount = 1
        Me.TL_1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TL_1.Controls.Add(Me.DG_ordinirighe, 0, 2)
        Me.TL_1.Controls.Add(Me.DG_ordini, 0, 0)
        Me.TL_1.Controls.Add(Me.TableLayoutPanel3, 0, 3)
        Me.TL_1.Controls.Add(Me.lbOrdineRighe, 0, 1)
        Me.TL_1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TL_1.Location = New System.Drawing.Point(0, 0)
        Me.TL_1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TL_1.Name = "TL_1"
        Me.TL_1.RowCount = 4
        Me.TL_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.5!))
        Me.TL_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TL_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.5!))
        Me.TL_1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TL_1.Size = New System.Drawing.Size(1261, 761)
        Me.TL_1.TabIndex = 123
        '
        'DG_ordinirighe
        '
        Me.DG_ordinirighe.AutoGenerateColumns = False
        Me.DG_ordinirighe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_ordinirighe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ordinirighe.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWCfatturabile, Me.DGWCidRighe, Me.DGWCposizione, Me.DGWCdescrizione, Me.DGWCqta, Me.DGWCunitario, Me.scontoTextColumn, Me.taxTextColumn, Me.DGWCtotalenetto})
        Me.DG_ordinirighe.DataSource = Me.RELrigheordineBindingSource
        Me.DG_ordinirighe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_ordinirighe.Location = New System.Drawing.Point(3, 449)
        Me.DG_ordinirighe.Name = "DG_ordinirighe"
        Me.DG_ordinirighe.RowHeadersWidth = 25
        Me.DG_ordinirighe.Size = New System.Drawing.Size(1255, 248)
        Me.DG_ordinirighe.TabIndex = 26
        '
        'DGWCposizione
        '
        Me.DGWCposizione.DataPropertyName = "posizione"
        Me.DGWCposizione.FillWeight = 10.0!
        Me.DGWCposizione.HeaderText = "SORT"
        Me.DGWCposizione.Name = "DGWCposizione"
        '
        'DGWCunitario
        '
        Me.DGWCunitario.DataPropertyName = "prezzo_unitario"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        Me.DGWCunitario.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGWCunitario.FillWeight = 20.0!
        Me.DGWCunitario.HeaderText = "Unitario"
        Me.DGWCunitario.Name = "DGWCunitario"
        '
        'scontoTextColumn
        '
        Me.scontoTextColumn.DataPropertyName = "sconto"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        Me.scontoTextColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.scontoTextColumn.FillWeight = 10.0!
        Me.scontoTextColumn.HeaderText = "Sc"
        Me.scontoTextColumn.Name = "scontoTextColumn"
        '
        'taxTextColumn
        '
        Me.taxTextColumn.DataPropertyName = "tax"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N2"
        Me.taxTextColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.taxTextColumn.FillWeight = 10.0!
        Me.taxTextColumn.HeaderText = "Tax"
        Me.taxTextColumn.Name = "taxTextColumn"
        '
        'DGWCtotalenetto
        '
        Me.DGWCtotalenetto.DataPropertyName = "totalenetto"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.Format = "N2"
        Me.DGWCtotalenetto.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGWCtotalenetto.FillWeight = 20.0!
        Me.DGWCtotalenetto.HeaderText = "Netto"
        Me.DGWCtotalenetto.Name = "DGWCtotalenetto"
        '
        'DG_ordini
        '
        Me.DG_ordini.AllowUserToAddRows = False
        Me.DG_ordini.AllowUserToDeleteRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_ordini.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DG_ordini.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_ordini.AutoGenerateColumns = False
        Me.DG_ordini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ordini.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWCoInviato, Me.DGWCoID, Me.DataordineDataGridViewTextBoxColumn, Me.SocietaDataGridViewTextBoxColumn, Me.LocazioneDataGridViewTextBoxColumn, Me.DGWCofornitore, Me.anagrafica, Me.DGWCototalenetto, Me.AnnotazioniDataGridViewTextBoxColumn, Me.dgwcId_webordini, Me.dgwcStato})
        Me.DG_ordini.DataSource = Me.bsOrdini
        Me.DG_ordini.Location = New System.Drawing.Point(3, 4)
        Me.DG_ordini.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DG_ordini.Name = "DG_ordini"
        Me.DG_ordini.ReadOnly = True
        Me.DG_ordini.RowHeadersWidth = 4
        Me.DG_ordini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_ordini.Size = New System.Drawing.Size(1255, 416)
        Me.DG_ordini.TabIndex = 6
        '
        'DGWCoInviato
        '
        Me.DGWCoInviato.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DGWCoInviato.DataPropertyName = "i_inviato"
        Me.DGWCoInviato.FillWeight = 10.0!
        Me.DGWCoInviato.Frozen = True
        Me.DGWCoInviato.HeaderText = "STP"
        Me.DGWCoInviato.Name = "DGWCoInviato"
        Me.DGWCoInviato.ReadOnly = True
        Me.DGWCoInviato.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCoInviato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCoInviato.Width = 49
        '
        'DGWCoID
        '
        Me.DGWCoID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DGWCoID.DataPropertyName = "id"
        Me.DGWCoID.FillWeight = 15.0!
        Me.DGWCoID.Frozen = True
        Me.DGWCoID.HeaderText = "id"
        Me.DGWCoID.Name = "DGWCoID"
        Me.DGWCoID.ReadOnly = True
        Me.DGWCoID.Width = 48
        '
        'DataordineDataGridViewTextBoxColumn
        '
        Me.DataordineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DataordineDataGridViewTextBoxColumn.DataPropertyName = "data_ordine"
        Me.DataordineDataGridViewTextBoxColumn.FillWeight = 30.0!
        Me.DataordineDataGridViewTextBoxColumn.Frozen = True
        Me.DataordineDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataordineDataGridViewTextBoxColumn.Name = "DataordineDataGridViewTextBoxColumn"
        Me.DataordineDataGridViewTextBoxColumn.ReadOnly = True
        Me.DataordineDataGridViewTextBoxColumn.Width = 97
        '
        'SocietaDataGridViewTextBoxColumn
        '
        Me.SocietaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.SocietaDataGridViewTextBoxColumn.DataPropertyName = "societa"
        Me.SocietaDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.SocietaDataGridViewTextBoxColumn.Frozen = True
        Me.SocietaDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.SocietaDataGridViewTextBoxColumn.Name = "SocietaDataGridViewTextBoxColumn"
        Me.SocietaDataGridViewTextBoxColumn.ReadOnly = True
        Me.SocietaDataGridViewTextBoxColumn.Width = 162
        '
        'LocazioneDataGridViewTextBoxColumn
        '
        Me.LocazioneDataGridViewTextBoxColumn.DataPropertyName = "locazione"
        Me.LocazioneDataGridViewTextBoxColumn.FillWeight = 70.0!
        Me.LocazioneDataGridViewTextBoxColumn.HeaderText = "Dettaglio"
        Me.LocazioneDataGridViewTextBoxColumn.Name = "LocazioneDataGridViewTextBoxColumn"
        Me.LocazioneDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocazioneDataGridViewTextBoxColumn.Width = 245
        '
        'DGWCofornitore
        '
        Me.DGWCofornitore.DataPropertyName = "fornitore"
        Me.DGWCofornitore.FillWeight = 25.0!
        Me.DGWCofornitore.HeaderText = "Fornitore"
        Me.DGWCofornitore.Name = "DGWCofornitore"
        Me.DGWCofornitore.ReadOnly = True
        Me.DGWCofornitore.Width = 88
        '
        'anagrafica
        '
        Me.anagrafica.DataPropertyName = "anagrafica"
        Me.anagrafica.FillWeight = 40.0!
        Me.anagrafica.HeaderText = "Dipendente"
        Me.anagrafica.MinimumWidth = 10
        Me.anagrafica.Name = "anagrafica"
        Me.anagrafica.ReadOnly = True
        Me.anagrafica.Width = 120
        '
        'DGWCototalenetto
        '
        Me.DGWCototalenetto.DataPropertyName = "totalenetto"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "N2"
        Me.DGWCototalenetto.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGWCototalenetto.FillWeight = 25.0!
        Me.DGWCototalenetto.HeaderText = "Netto"
        Me.DGWCototalenetto.Name = "DGWCototalenetto"
        Me.DGWCototalenetto.ReadOnly = True
        Me.DGWCototalenetto.Width = 80
        '
        'AnnotazioniDataGridViewTextBoxColumn
        '
        Me.AnnotazioniDataGridViewTextBoxColumn.DataPropertyName = "annotazioni"
        Me.AnnotazioniDataGridViewTextBoxColumn.FillWeight = 80.0!
        Me.AnnotazioniDataGridViewTextBoxColumn.HeaderText = "Note"
        Me.AnnotazioniDataGridViewTextBoxColumn.Name = "AnnotazioniDataGridViewTextBoxColumn"
        Me.AnnotazioniDataGridViewTextBoxColumn.ReadOnly = True
        Me.AnnotazioniDataGridViewTextBoxColumn.Width = 200
        '
        'dgwcId_webordini
        '
        Me.dgwcId_webordini.DataPropertyName = "id_webordini"
        Me.dgwcId_webordini.FillWeight = 15.0!
        Me.dgwcId_webordini.HeaderText = "WEB"
        Me.dgwcId_webordini.Name = "dgwcId_webordini"
        Me.dgwcId_webordini.ReadOnly = True
        Me.dgwcId_webordini.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcId_webordini.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgwcId_webordini.Width = 60
        '
        'dgwcStato
        '
        Me.dgwcStato.HeaderText = "Stato"
        Me.dgwcStato.Name = "dgwcStato"
        Me.dgwcStato.ReadOnly = True
        Me.dgwcStato.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcStato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.dgwcStato.Width = 80
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.4802!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.519798!))
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 703)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1255, 55)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.28571!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.05714!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.25714!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571!))
        Me.TableLayoutPanel1.Controls.Add(Me.LB_O, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_C, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_T, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LBT, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LBC, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LBO, 3, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1129, 47)
        Me.TableLayoutPanel1.TabIndex = 5
        '
        'LB_O
        '
        Me.LB_O.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_O.AutoSize = True
        Me.LB_O.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_O.Location = New System.Drawing.Point(970, 0)
        Me.LB_O.Name = "LB_O"
        Me.LB_O.Size = New System.Drawing.Size(156, 23)
        Me.LB_O.TabIndex = 4
        Me.LB_O.Text = "Totale Ordine"
        Me.LB_O.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_C
        '
        Me.LB_C.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_C.AutoSize = True
        Me.LB_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_C.Location = New System.Drawing.Point(775, 0)
        Me.LB_C.Name = "LB_C"
        Me.LB_C.Size = New System.Drawing.Size(189, 23)
        Me.LB_C.TabIndex = 3
        Me.LB_C.Text = "Totale Cliente"
        Me.LB_C.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_T
        '
        Me.LB_T.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_T.AutoSize = True
        Me.LB_T.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_T.Location = New System.Drawing.Point(571, 0)
        Me.LB_T.Name = "LB_T"
        Me.LB_T.Size = New System.Drawing.Size(198, 23)
        Me.LB_T.TabIndex = 10
        Me.LB_T.Text = "Totale Mese"
        Me.LB_T.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBT
        '
        Me.LBT.AutoSize = True
        Me.LBT.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBT.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBT.Location = New System.Drawing.Point(571, 23)
        Me.LBT.Name = "LBT"
        Me.LBT.Size = New System.Drawing.Size(198, 24)
        Me.LBT.TabIndex = 11
        Me.LBT.Text = "LB_tot"
        Me.LBT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBC
        '
        Me.LBC.AutoSize = True
        Me.LBC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBC.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBC.Location = New System.Drawing.Point(775, 23)
        Me.LBC.Name = "LBC"
        Me.LBC.Size = New System.Drawing.Size(189, 24)
        Me.LBC.TabIndex = 12
        Me.LBC.Text = "LB_tot"
        Me.LBC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LBO
        '
        Me.LBO.AutoSize = True
        Me.LBO.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBO.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBO.Location = New System.Drawing.Point(970, 23)
        Me.LBO.Name = "LBO"
        Me.LBO.Size = New System.Drawing.Size(156, 24)
        Me.LBO.TabIndex = 13
        Me.LBO.Text = "LB_tot"
        Me.LBO.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbOrdineRighe
        '
        Me.lbOrdineRighe.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lbOrdineRighe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbOrdineRighe.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbOrdineRighe.Location = New System.Drawing.Point(3, 424)
        Me.lbOrdineRighe.Name = "lbOrdineRighe"
        Me.lbOrdineRighe.Size = New System.Drawing.Size(1255, 22)
        Me.lbOrdineRighe.TabIndex = 27
        Me.lbOrdineRighe.Text = "Dettaglio Ordine "
        Me.lbOrdineRighe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ImageList2
        '
        Me.ImageList2.ImageStream = CType(resources.GetObject("ImageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList2.Images.SetKeyName(0, "gestione.png")
        Me.ImageList2.Images.SetKeyName(1, "spedizione.png")
        Me.ImageList2.Images.SetKeyName(2, "consegna.png")
        Me.ImageList2.Images.SetKeyName(3, "vuoto.png")
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.FillWeight = 15.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 189
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "data_ordine"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.Format = "N2"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn2.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "data_ordine"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 89
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "societa"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "N2"
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn3.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "societa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 207
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "locazione"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "N2"
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridViewTextBoxColumn4.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "locazione"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 206
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fornitore"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "N2"
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridViewTextBoxColumn5.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fornitore"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 75
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "annotazioni"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Format = "N2"
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn6.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Annotazioni"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn6.Width = 382
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id"
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle12.Format = "N2"
        Me.DataGridViewTextBoxColumn7.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn7.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        Me.DataGridViewTextBoxColumn7.Width = 26
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "posizione"
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle13.Format = "N2"
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridViewTextBoxColumn8.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "O"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        Me.DataGridViewTextBoxColumn8.Width = 26
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "posizione"
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.Format = "N2"
        Me.DataGridViewTextBoxColumn9.DefaultCellStyle = DataGridViewCellStyle14
        Me.DataGridViewTextBoxColumn9.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "O"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Visible = False
        Me.DataGridViewTextBoxColumn9.Width = 104
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TA_ordinirighe
        '
        Me.TA_ordinirighe.ClearBeforeFill = True
        '
        'TA_ordini
        '
        Me.TA_ordini.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "quantita"
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.Format = "N2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataGridViewTextBoxColumn10.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "Q.tà"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 134
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "prezzo_unitario"
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle16.Format = "N2"
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridViewTextBoxColumn11.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Prezzo UN"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Visible = False
        Me.DataGridViewTextBoxColumn11.Width = 113
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "sconto"
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle17.Format = "N2"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle17
        Me.DataGridViewTextBoxColumn12.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "sconto"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        Me.DataGridViewTextBoxColumn12.Width = 95
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "tax"
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle18.Format = "N2"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle18
        Me.DataGridViewTextBoxColumn13.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "TAX"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        Me.DataGridViewTextBoxColumn13.Width = 124
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "tax"
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle19.Format = "N2"
        Me.DataGridViewTextBoxColumn15.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataGridViewTextBoxColumn15.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "TAX"
        Me.DataGridViewTextBoxColumn15.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        Me.DataGridViewTextBoxColumn15.Width = 52
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "tipoProdotto"
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle20.Format = "N2"
        Me.DataGridViewTextBoxColumn16.DefaultCellStyle = DataGridViewCellStyle20
        Me.DataGridViewTextBoxColumn16.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn16.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Width = 77
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "tipoProdotto"
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle21.Format = "N2"
        Me.DataGridViewTextBoxColumn17.DefaultCellStyle = DataGridViewCellStyle21
        Me.DataGridViewTextBoxColumn17.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn17.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn17.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        Me.DataGridViewTextBoxColumn17.Width = 88
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "descrizione"
        Me.DataGridViewTextBoxColumn18.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn18.HeaderText = "Descrizione"
        Me.DataGridViewTextBoxColumn18.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Width = 211
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "tipoProdotto"
        Me.DataGridViewTextBoxColumn19.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn19.HeaderText = "Tipo"
        Me.DataGridViewTextBoxColumn19.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Width = 168
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "totalenetto"
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle22.Format = "N2"
        Me.DataGridViewTextBoxColumn20.DefaultCellStyle = DataGridViewCellStyle22
        Me.DataGridViewTextBoxColumn20.FillWeight = 25.0!
        Me.DataGridViewTextBoxColumn20.HeaderText = "Netto"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        Me.DataGridViewTextBoxColumn20.Width = 106
        '
        'Col_ID
        '
        Me.Col_ID.DataPropertyName = "id"
        Me.Col_ID.HeaderText = "ID"
        Me.Col_ID.MinimumWidth = 10
        Me.Col_ID.Name = "Col_ID"
        Me.Col_ID.Visible = False
        '
        'totRiga
        '
        Me.totRiga.DataPropertyName = "totRiga"
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle23.Format = "N2"
        Me.totRiga.DefaultCellStyle = DataGridViewCellStyle23
        Me.totRiga.FillWeight = 30.0!
        Me.totRiga.HeaderText = "Totale"
        Me.totRiga.MinimumWidth = 10
        Me.totRiga.Name = "totRiga"
        Me.totRiga.ReadOnly = True
        '
        'DGWCfatturabile
        '
        Me.DGWCfatturabile.DataPropertyName = "fatturabile"
        Me.DGWCfatturabile.FalseValue = "0"
        Me.DGWCfatturabile.FillWeight = 10.0!
        Me.DGWCfatturabile.HeaderText = "FATT"
        Me.DGWCfatturabile.Name = "DGWCfatturabile"
        Me.DGWCfatturabile.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCfatturabile.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCfatturabile.TrueValue = "1"
        '
        'DGWCidRighe
        '
        Me.DGWCidRighe.DataPropertyName = "id"
        Me.DGWCidRighe.FillWeight = 10.0!
        Me.DGWCidRighe.HeaderText = "id"
        Me.DGWCidRighe.Name = "DGWCidRighe"
        '
        'DGWCdescrizione
        '
        Me.DGWCdescrizione.DataPropertyName = "descrizione"
        Me.DGWCdescrizione.HeaderText = "Prodotto"
        Me.DGWCdescrizione.Name = "DGWCdescrizione"
        '
        'DGWCqta
        '
        Me.DGWCqta.DataPropertyName = "quantita"
        Me.DGWCqta.FillWeight = 10.0!
        Me.DGWCqta.HeaderText = "Q.tà"
        Me.DGWCqta.Name = "DGWCqta"
        '
        'RELrigheordineBindingSource
        '
        Me.RELrigheordineBindingSource.DataMember = "RELrigheordine"
        Me.RELrigheordineBindingSource.DataSource = Me.bsOrdini
        '
        'FrmOrdineMateriale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1261, 861)
        Me.Controls.Add(Me.TL_1)
        Me.Controls.Add(Me.BN_barra)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmOrdineMateriale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordini Materiale"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.BN_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BN_barra.ResumeLayout(False)
        Me.BN_barra.PerformLayout()
        CType(Me.bsOrdini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TL_1.ResumeLayout(False)
        CType(Me.DG_ordinirighe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_ordini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.RELrigheordineBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_righeOrdini, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_Ordini As DS_Ordini
    Friend WithEvents TableAdapterManager As DS_OrdiniTableAdapters.TableAdapterManager
    Friend WithEvents TA_ordinirighe As DS_OrdiniTableAdapters.TA_ordinirighe
    Friend WithEvents BS_righeOrdini As BindingSource
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TTLB2 As ToolStripStatusLabel
    Friend WithEvents TTLB1 As ToolStripStatusLabel
    Friend WithEvents BN_barra As BindingNavigator
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
    Friend WithEvents TTBTModifica As ToolStripButton
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTBTannulla As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TTPB As ToolStripProgressBar
    Friend WithEvents TT_CB_anno As ToolStripComboBox
    Friend WithEvents TT_CB_mese As ToolStripComboBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents Col_ID As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents totRiga As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents bsOrdini As BindingSource
    Friend WithEvents TA_ordini As DS_OrdiniTableAdapters.TA_ordini
    Friend WithEvents TL_1 As TableLayoutPanel
    Friend WithEvents DG_ordini As DataGridView
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LB_O As Label
    Friend WithEvents LB_C As Label
    Friend WithEvents LB_T As Label
    Friend WithEvents LBT As Label
    Friend WithEvents LBC As Label
    Friend WithEvents LBO As Label
    Friend WithEvents RELrigheordineBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DG_ordinirighe As DataGridView
    Friend WithEvents DGWCfatturabile As DataGridViewCheckBoxColumn
    Friend WithEvents DGWCidRighe As DataGridViewTextBoxColumn
    Friend WithEvents DGWCposizione As DataGridViewTextBoxColumn
    Friend WithEvents DGWCdescrizione As DataGridViewTextBoxColumn
    Friend WithEvents DGWCqta As DataGridViewTextBoxColumn
    Friend WithEvents DGWCunitario As DataGridViewTextBoxColumn
    Friend WithEvents scontoTextColumn As DataGridViewTextBoxColumn
    Friend WithEvents taxTextColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGWCtotalenetto As DataGridViewTextBoxColumn
    Friend WithEvents lbOrdineRighe As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tsMenuFiltro As ToolStripDropDownButton
    Friend WithEvents tsFiltro As ToolStripMenuItem
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents DGWCoInviato As DataGridViewImageColumn
    Friend WithEvents DGWCoID As DataGridViewTextBoxColumn
    Friend WithEvents DataordineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SocietaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocazioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DGWCofornitore As DataGridViewTextBoxColumn
    Friend WithEvents anagrafica As DataGridViewTextBoxColumn
    Friend WithEvents DGWCototalenetto As DataGridViewTextBoxColumn
    Friend WithEvents AnnotazioniDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents dgwcId_webordini As DataGridViewLinkColumn
    Friend WithEvents dgwcStato As DataGridViewImageColumn
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents TTBTRicarica As ToolStripButton
End Class
