<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCantieriRiepilogoPresenze
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCantieriRiepilogoPresenze))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_clienti = New System.Windows.Forms.DataGridView()
        Me.DataDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SocietaDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocazioneDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CognomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotaleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FatturabileDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_riepilogo = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.BN_barra = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.TT_CB_anno = New System.Windows.Forms.ToolStripComboBox()
        Me.TT_CB_mese = New System.Windows.Forms.ToolStripComboBox()
        Me.SocietaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnagraficaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TA_riepilogoOre = New PoP2.Comuni.DS_utentiTableAdapters.TA_riepilogoOre()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DG_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_riepilogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BN_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BN_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.01414!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.98587!))
        Me.TableLayoutPanel1.Controls.Add(Me.DG_clienti, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 2)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.3026!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.69741!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1132, 347)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DG_clienti
        '
        Me.DG_clienti.AllowUserToAddRows = False
        Me.DG_clienti.AllowUserToDeleteRows = False
        Me.DG_clienti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_clienti.AutoGenerateColumns = False
        Me.DG_clienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clienti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataDataGridViewTextBoxColumn1, Me.SocietaDataGridViewTextBoxColumn1, Me.LocazioneDataGridViewTextBoxColumn1, Me.CognomeDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn1, Me.TotaleDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn1, Me.FatturabileDataGridViewTextBoxColumn})
        Me.DG_clienti.DataSource = Me.BS_riepilogo
        Me.DG_clienti.Location = New System.Drawing.Point(3, 3)
        Me.DG_clienti.Name = "DG_clienti"
        Me.DG_clienti.ReadOnly = True
        Me.DG_clienti.RowHeadersWidth = 4
        Me.DG_clienti.Size = New System.Drawing.Size(978, 289)
        Me.DG_clienti.TabIndex = 0
        '
        'DataDataGridViewTextBoxColumn1
        '
        Me.DataDataGridViewTextBoxColumn1.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn1.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn1.Name = "DataDataGridViewTextBoxColumn1"
        Me.DataDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'SocietaDataGridViewTextBoxColumn1
        '
        Me.SocietaDataGridViewTextBoxColumn1.DataPropertyName = "societa"
        Me.SocietaDataGridViewTextBoxColumn1.HeaderText = "societa"
        Me.SocietaDataGridViewTextBoxColumn1.Name = "SocietaDataGridViewTextBoxColumn1"
        Me.SocietaDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'LocazioneDataGridViewTextBoxColumn1
        '
        Me.LocazioneDataGridViewTextBoxColumn1.DataPropertyName = "locazione"
        Me.LocazioneDataGridViewTextBoxColumn1.HeaderText = "locazione"
        Me.LocazioneDataGridViewTextBoxColumn1.Name = "LocazioneDataGridViewTextBoxColumn1"
        Me.LocazioneDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CognomeDataGridViewTextBoxColumn
        '
        Me.CognomeDataGridViewTextBoxColumn.DataPropertyName = "cognome"
        Me.CognomeDataGridViewTextBoxColumn.HeaderText = "cognome"
        Me.CognomeDataGridViewTextBoxColumn.Name = "CognomeDataGridViewTextBoxColumn"
        Me.CognomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescrizioneDataGridViewTextBoxColumn1
        '
        Me.DescrizioneDataGridViewTextBoxColumn1.DataPropertyName = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn1.HeaderText = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn1.Name = "DescrizioneDataGridViewTextBoxColumn1"
        Me.DescrizioneDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'TotaleDataGridViewTextBoxColumn
        '
        Me.TotaleDataGridViewTextBoxColumn.DataPropertyName = "totale"
        Me.TotaleDataGridViewTextBoxColumn.HeaderText = "totale"
        Me.TotaleDataGridViewTextBoxColumn.Name = "TotaleDataGridViewTextBoxColumn"
        Me.TotaleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoteDataGridViewTextBoxColumn1
        '
        Me.NoteDataGridViewTextBoxColumn1.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn1.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn1.Name = "NoteDataGridViewTextBoxColumn1"
        Me.NoteDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FatturabileDataGridViewTextBoxColumn
        '
        Me.FatturabileDataGridViewTextBoxColumn.DataPropertyName = "fatturabile"
        Me.FatturabileDataGridViewTextBoxColumn.HeaderText = "fatturabile"
        Me.FatturabileDataGridViewTextBoxColumn.Name = "FatturabileDataGridViewTextBoxColumn"
        Me.FatturabileDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BS_riepilogo
        '
        Me.BS_riepilogo.DataMember = "DT_riepilogoOre"
        Me.BS_riepilogo.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BN_barra
        '
        Me.BN_barra.AddNewItem = Nothing
        Me.BN_barra.AutoSize = False
        Me.BN_barra.BindingSource = Me.BS_riepilogo
        Me.BN_barra.CountItem = Me.BindingNavigatorCountItem
        Me.BN_barra.DeleteItem = Nothing
        Me.BN_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BN_barra.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.BN_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTestoRicerca, Me.TTBTRicerca, Me.ToolStripSeparator2, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTAggiunge, Me.TTBTElimina, Me.TTBTannulla, Me.TTBTSalva, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator1, Me.TTPB, Me.TT_CB_anno, Me.TT_CB_mese})
        Me.BN_barra.Location = New System.Drawing.Point(0, 352)
        Me.BN_barra.MoveFirstItem = Me.BindingNavigatorMoveLastItem
        Me.BN_barra.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BN_barra.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BN_barra.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BN_barra.Name = "BN_barra"
        Me.BN_barra.PositionItem = Me.BindingNavigatorPositionItem
        Me.BN_barra.Size = New System.Drawing.Size(1135, 98)
        Me.BN_barra.TabIndex = 123
        Me.BN_barra.Text = "BarraNavigazione"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 95)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.BackColor = System.Drawing.Color.LightBlue
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(116, 98)
        Me.TTTestoRicerca.ToolTipText = "Immettere l'anno di lavoro"
        '
        'TTBTRicerca
        '
        Me.TTBTRicerca.AutoSize = False
        Me.TTBTRicerca.Image = Global.PoP2.Comuni.My.Resources.Resources.ominofoglioore
        Me.TTBTRicerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTRicerca.Name = "TTBTRicerca"
        Me.TTBTRicerca.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicerca.Text = "Gruppa"
        Me.TTBTRicerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicerca.ToolTipText = "Raggruppa"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 98)
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
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 98)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 98)
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 98)
        '
        'TTBTAggiunge
        '
        Me.TTBTAggiunge.AutoSize = False
        Me.TTBTAggiunge.Image = Global.PoP2.Comuni.My.Resources.Resources.modifica
        Me.TTBTAggiunge.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTAggiunge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTAggiunge.Name = "TTBTAggiunge"
        Me.TTBTAggiunge.RightToLeftAutoMirrorImage = True
        Me.TTBTAggiunge.Size = New System.Drawing.Size(50, 70)
        Me.TTBTAggiunge.Text = "Modifica"
        Me.TTBTAggiunge.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTAggiunge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTAggiunge.Visible = False
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
        Me.TTBTElimina.Visible = False
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
        Me.TTBTannulla.Visible = False
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
        Me.TTBTSalva.Visible = False
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
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 98)
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
        Me.TT_CB_anno.Size = New System.Drawing.Size(140, 98)
        '
        'TT_CB_mese
        '
        Me.TT_CB_mese.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_mese.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_mese.Name = "TT_CB_mese"
        Me.TT_CB_mese.Size = New System.Drawing.Size(150, 98)
        '
        'SocietaDataGridViewTextBoxColumn
        '
        Me.SocietaDataGridViewTextBoxColumn.DataPropertyName = "societa"
        Me.SocietaDataGridViewTextBoxColumn.HeaderText = "societa"
        Me.SocietaDataGridViewTextBoxColumn.Name = "SocietaDataGridViewTextBoxColumn"
        '
        'LocazioneDataGridViewTextBoxColumn
        '
        Me.LocazioneDataGridViewTextBoxColumn.DataPropertyName = "locazione"
        Me.LocazioneDataGridViewTextBoxColumn.HeaderText = "locazione"
        Me.LocazioneDataGridViewTextBoxColumn.Name = "LocazioneDataGridViewTextBoxColumn"
        '
        'AnagraficaDataGridViewTextBoxColumn
        '
        Me.AnagraficaDataGridViewTextBoxColumn.DataPropertyName = "anagrafica"
        Me.AnagraficaDataGridViewTextBoxColumn.HeaderText = "anagrafica"
        Me.AnagraficaDataGridViewTextBoxColumn.Name = "AnagraficaDataGridViewTextBoxColumn"
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        '
        'OreDataGridViewTextBoxColumn
        '
        Me.OreDataGridViewTextBoxColumn.DataPropertyName = "ore"
        Me.OreDataGridViewTextBoxColumn.HeaderText = "ore"
        Me.OreDataGridViewTextBoxColumn.Name = "OreDataGridViewTextBoxColumn"
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        '
        'TA_riepilogoOre
        '
        Me.TA_riepilogoOre.ClearBeforeFill = True
        '
        'FRM_ClienteRiepilogoOre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 450)
        Me.Controls.Add(Me.BN_barra)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_ClienteRiepilogoOre"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Riepilogo Presenze Cliente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.DG_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_riepilogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BN_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BN_barra.ResumeLayout(False)
        Me.BN_barra.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BN_barra As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents TTTestoRicerca As ToolStripTextBox
    Friend WithEvents TTBTRicerca As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTBTannulla As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TTPB As ToolStripProgressBar
    Friend WithEvents TT_CB_anno As ToolStripComboBox
    Friend WithEvents TT_CB_mese As ToolStripComboBox
    Friend WithEvents SocietaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocazioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnagraficaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DG_clienti As DataGridView
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents BS_riepilogo As BindingSource
    Friend WithEvents TA_riepilogoOre As DS_utentiTableAdapters.TA_riepilogoOre
    Friend WithEvents DataDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents SocietaDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents LocazioneDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents CognomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TotaleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FatturabileDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
