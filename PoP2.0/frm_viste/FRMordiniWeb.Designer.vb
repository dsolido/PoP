<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMOrdiniWeb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMOrdiniWeb))
        Me.DGWordiniWeb = New System.Windows.Forms.DataGridView()
        Me.BSordiniWeb = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Ordini = New PoP2.Comuni.DS_Ordini()
        Me.DGWordinirigheWeb = New System.Windows.Forms.DataGridView()
        Me.DGWRCid = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DGWRCposizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWRCdata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWRCprodotto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWRCquantita = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWRCfornitore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWRCdipendente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWRClocazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RordiniWebordiniRigaWeb = New System.Windows.Forms.BindingSource(Me.components)
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTSB_ricarica = New System.Windows.Forms.ToolStripButton()
        Me.TSBevasi = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.TSLdescrizione = New System.Windows.Forms.ToolStripLabel()
        Me.TTPB_stampa = New System.Windows.Forms.ToolStripProgressBar()
        Me.TAB_ordini = New System.Windows.Forms.TabControl()
        Me.TB_ordiniWeb = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TB_statistiche_Ordini = New System.Windows.Forms.TabPage()
        Me.TAordiniWeb = New PoP2.Comuni.DS_OrdiniTableAdapters.TAordiniWeb()
        Me.TableAdapterManager = New PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager()
        Me.TAordiniRigaWeb = New PoP2.Comuni.DS_OrdiniTableAdapters.TAordiniRigaWeb()
        Me.BSwebordiniriga = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGWCid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCinviato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCUtente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCconvalidato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGWordiniWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSordiniWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGWordinirigheWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RordiniWebordiniRigaWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        Me.TAB_ordini.SuspendLayout()
        Me.TB_ordiniWeb.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BSwebordiniriga, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGWordiniWeb
        '
        Me.DGWordiniWeb.AllowUserToAddRows = False
        Me.DGWordiniWeb.AllowUserToDeleteRows = False
        Me.DGWordiniWeb.AllowUserToResizeColumns = False
        Me.DGWordiniWeb.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DGWordiniWeb.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DGWordiniWeb.AutoGenerateColumns = False
        Me.DGWordiniWeb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGWordiniWeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGWordiniWeb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWCid, Me.DataGridViewTextBoxColumn6, Me.DGWCinviato, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn11, Me.DGWCUtente, Me.DataGridViewTextBoxColumn7, Me.DGWCconvalidato})
        Me.DGWordiniWeb.DataSource = Me.BSordiniWeb
        Me.DGWordiniWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGWordiniWeb.Location = New System.Drawing.Point(3, 3)
        Me.DGWordiniWeb.Name = "DGWordiniWeb"
        Me.DGWordiniWeb.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGWordiniWeb.Size = New System.Drawing.Size(1118, 224)
        Me.DGWordiniWeb.TabIndex = 1
        '
        'BSordiniWeb
        '
        Me.BSordiniWeb.DataMember = "DTordiniWeb"
        Me.BSordiniWeb.DataSource = Me.DS_Ordini
        '
        'DS_Ordini
        '
        Me.DS_Ordini.DataSetName = "DS_Ordini"
        Me.DS_Ordini.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DGWordinirigheWeb
        '
        Me.DGWordinirigheWeb.AutoGenerateColumns = False
        Me.DGWordinirigheWeb.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGWordinirigheWeb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGWordinirigheWeb.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWRCid, Me.DGWRCposizione, Me.DGWRCdata, Me.DGWRCprodotto, Me.DGWRCquantita, Me.DGWRCfornitore, Me.DGWRCdipendente, Me.DGWRClocazione})
        Me.DGWordinirigheWeb.DataSource = Me.RordiniWebordiniRigaWeb
        Me.DGWordinirigheWeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGWordinirigheWeb.Location = New System.Drawing.Point(3, 233)
        Me.DGWordinirigheWeb.Name = "DGWordinirigheWeb"
        Me.DGWordinirigheWeb.RowHeadersVisible = False
        Me.DGWordinirigheWeb.Size = New System.Drawing.Size(1118, 448)
        Me.DGWordinirigheWeb.TabIndex = 2
        '
        'DGWRCid
        '
        Me.DGWRCid.DataPropertyName = "id"
        Me.DGWRCid.FillWeight = 30.0!
        Me.DGWRCid.HeaderText = "id"
        Me.DGWRCid.Name = "DGWRCid"
        Me.DGWRCid.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWRCid.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DGWRCposizione
        '
        Me.DGWRCposizione.DataPropertyName = "posizione"
        Me.DGWRCposizione.FillWeight = 30.0!
        Me.DGWRCposizione.HeaderText = "SORT"
        Me.DGWRCposizione.Name = "DGWRCposizione"
        '
        'DGWRCdata
        '
        Me.DGWRCdata.DataPropertyName = "dataordine"
        Me.DGWRCdata.FillWeight = 45.0!
        Me.DGWRCdata.HeaderText = "Data"
        Me.DGWRCdata.Name = "DGWRCdata"
        '
        'DGWRCprodotto
        '
        Me.DGWRCprodotto.DataPropertyName = "descrizione"
        Me.DGWRCprodotto.HeaderText = "Prodotto"
        Me.DGWRCprodotto.Name = "DGWRCprodotto"
        '
        'DGWRCquantita
        '
        Me.DGWRCquantita.DataPropertyName = "quantita"
        Me.DGWRCquantita.FillWeight = 30.0!
        Me.DGWRCquantita.HeaderText = "Q.ta"
        Me.DGWRCquantita.Name = "DGWRCquantita"
        '
        'DGWRCfornitore
        '
        Me.DGWRCfornitore.DataPropertyName = "fornitore"
        Me.DGWRCfornitore.HeaderText = "Fornitore"
        Me.DGWRCfornitore.Name = "DGWRCfornitore"
        '
        'DGWRCdipendente
        '
        Me.DGWRCdipendente.DataPropertyName = "anagrafica"
        Me.DGWRCdipendente.HeaderText = "Dipendente"
        Me.DGWRCdipendente.Name = "DGWRCdipendente"
        Me.DGWRCdipendente.ReadOnly = True
        '
        'DGWRClocazione
        '
        Me.DGWRClocazione.DataPropertyName = "locazione"
        Me.DGWRClocazione.HeaderText = "Dettaglio Cliente"
        Me.DGWRClocazione.Name = "DGWRClocazione"
        '
        'RordiniWebordiniRigaWeb
        '
        Me.RordiniWebordiniRigaWeb.DataMember = "R_ordiniWeb_ordiniRigaWeb"
        Me.RordiniWebordiniRigaWeb.DataSource = Me.BSordiniWeb
        '
        'DM_barra
        '
        Me.DM_barra.AddNewItem = Nothing
        Me.DM_barra.AutoSize = False
        Me.DM_barra.BindingSource = Me.BSordiniWeb
        Me.DM_barra.CountItem = Me.ToolStripLabel1
        Me.DM_barra.DeleteItem = Nothing
        Me.DM_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DM_barra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DM_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTestoRicerca, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.TTSB_ricarica, Me.TSBevasi, Me.ToolStripSeparator4, Me.TSLdescrizione, Me.TTPB_stampa})
        Me.DM_barra.Location = New System.Drawing.Point(0, 732)
        Me.DM_barra.MoveFirstItem = Me.ToolStripButton1
        Me.DM_barra.MoveLastItem = Me.ToolStripButton4
        Me.DM_barra.MoveNextItem = Me.ToolStripButton3
        Me.DM_barra.MovePreviousItem = Me.ToolStripButton2
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.PositionItem = Me.ToolStripTextBox1
        Me.DM_barra.Size = New System.Drawing.Size(1144, 79)
        Me.DM_barra.TabIndex = 190
        Me.DM_barra.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 76)
        Me.ToolStripLabel1.Text = "di {0}"
        Me.ToolStripLabel1.ToolTipText = "Numero totale di elementi"
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.BackColor = System.Drawing.SystemColors.Info
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(100, 79)
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
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 79)
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
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 79)
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
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 79)
        '
        'TTBTElimina
        '
        Me.TTBTElimina.AutoSize = False
        Me.TTBTElimina.Image = CType(resources.GetObject("TTBTElimina.Image"), System.Drawing.Image)
        Me.TTBTElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTElimina.Name = "TTBTElimina"
        Me.TTBTElimina.RightToLeftAutoMirrorImage = True
        Me.TTBTElimina.Size = New System.Drawing.Size(70, 70)
        Me.TTBTElimina.Text = "Elimina"
        Me.TTBTElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTElimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTSalva
        '
        Me.TTBTSalva.AutoSize = False
        Me.TTBTSalva.Image = Global.PoP2.Comuni.My.Resources.Resources.ominofoglioore
        Me.TTBTSalva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTSalva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTSalva.Name = "TTBTSalva"
        Me.TTBTSalva.Size = New System.Drawing.Size(70, 70)
        Me.TTBTSalva.Text = "Trasporta"
        Me.TTBTSalva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTSalva.ToolTipText = "Trasporta nel Form Ordini"
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
        'TTSB_ricarica
        '
        Me.TTSB_ricarica.AutoSize = False
        Me.TTSB_ricarica.Image = Global.PoP2.Comuni.My.Resources.Resources.Omino_ricarica48
        Me.TTSB_ricarica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTSB_ricarica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTSB_ricarica.Name = "TTSB_ricarica"
        Me.TTSB_ricarica.Size = New System.Drawing.Size(70, 70)
        Me.TTSB_ricarica.Text = "Ricarica"
        Me.TTSB_ricarica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTSB_ricarica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTSB_ricarica.ToolTipText = "Ricarica gli Archivi"
        '
        'TSBevasi
        '
        Me.TSBevasi.AutoSize = False
        Me.TSBevasi.Image = Global.PoP2.Comuni.My.Resources.Resources.ominoarchiviodocumenti
        Me.TSBevasi.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TSBevasi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TSBevasi.Name = "TSBevasi"
        Me.TSBevasi.Size = New System.Drawing.Size(90, 70)
        Me.TSBevasi.Text = "Tipo Ordini"
        Me.TSBevasi.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TSBevasi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TSBevasi.ToolTipText = "Cambia stato"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 79)
        '
        'TSLdescrizione
        '
        Me.TSLdescrizione.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TSLdescrizione.Name = "TSLdescrizione"
        Me.TSLdescrizione.Size = New System.Drawing.Size(90, 76)
        Me.TSLdescrizione.Text = "Descrizione"
        Me.TSLdescrizione.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TTPB_stampa
        '
        Me.TTPB_stampa.Name = "TTPB_stampa"
        Me.TTPB_stampa.Size = New System.Drawing.Size(500, 16)
        '
        'TAB_ordini
        '
        Me.TAB_ordini.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TAB_ordini.Controls.Add(Me.TB_ordiniWeb)
        Me.TAB_ordini.Controls.Add(Me.TB_statistiche_Ordini)
        Me.TAB_ordini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TAB_ordini.Location = New System.Drawing.Point(0, 0)
        Me.TAB_ordini.Name = "TAB_ordini"
        Me.TAB_ordini.SelectedIndex = 0
        Me.TAB_ordini.Size = New System.Drawing.Size(1144, 729)
        Me.TAB_ordini.TabIndex = 191
        '
        'TB_ordiniWeb
        '
        Me.TB_ordiniWeb.Controls.Add(Me.TableLayoutPanel1)
        Me.TB_ordiniWeb.Location = New System.Drawing.Point(4, 29)
        Me.TB_ordiniWeb.Name = "TB_ordiniWeb"
        Me.TB_ordiniWeb.Padding = New System.Windows.Forms.Padding(3)
        Me.TB_ordiniWeb.Size = New System.Drawing.Size(1136, 696)
        Me.TB_ordiniWeb.TabIndex = 0
        Me.TB_ordiniWeb.Text = "Ordini Web"
        Me.TB_ordiniWeb.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DGWordiniWeb, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DGWordinirigheWeb, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 6)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.73134!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 66.26865!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1124, 684)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'TB_statistiche_Ordini
        '
        Me.TB_statistiche_Ordini.Location = New System.Drawing.Point(4, 29)
        Me.TB_statistiche_Ordini.Name = "TB_statistiche_Ordini"
        Me.TB_statistiche_Ordini.Padding = New System.Windows.Forms.Padding(3)
        Me.TB_statistiche_Ordini.Size = New System.Drawing.Size(1136, 696)
        Me.TB_statistiche_Ordini.TabIndex = 1
        Me.TB_statistiche_Ordini.Text = "Statistiche"
        Me.TB_statistiche_Ordini.UseVisualStyleBackColor = True
        '
        'TAordiniWeb
        '
        Me.TAordiniWeb.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TAordiniRigaWeb
        '
        Me.TAordiniRigaWeb.ClearBeforeFill = True
        '
        'BSwebordiniriga
        '
        Me.BSwebordiniriga.DataMember = "DTordiniRigaWeb"
        Me.BSwebordiniriga.DataSource = Me.DS_Ordini
        '
        'DGWCid
        '
        Me.DGWCid.DataPropertyName = "id"
        Me.DGWCid.FillWeight = 30.0!
        Me.DGWCid.HeaderText = "id"
        Me.DGWCid.Name = "DGWCid"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "data_ordine"
        Me.DataGridViewTextBoxColumn6.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DGWCinviato
        '
        Me.DGWCinviato.DataPropertyName = "inviato"
        Me.DGWCinviato.HeaderText = "inviato"
        Me.DGWCinviato.Name = "DGWCinviato"
        Me.DGWCinviato.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "societa"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "locazione"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Dettaglio Cliente"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DGWCUtente
        '
        Me.DGWCUtente.DataPropertyName = "anagrafica"
        Me.DGWCUtente.HeaderText = "Utente"
        Me.DGWCUtente.Name = "DGWCUtente"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "annotazioni"
        Me.DataGridViewTextBoxColumn7.FillWeight = 150.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DGWCconvalidato
        '
        Me.DGWCconvalidato.DataPropertyName = "inviato"
        Me.DGWCconvalidato.FillWeight = 20.0!
        Me.DGWCconvalidato.HeaderText = "CK"
        Me.DGWCconvalidato.Name = "DGWCconvalidato"
        '
        'FRMOrdiniWeb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1144, 811)
        Me.Controls.Add(Me.TAB_ordini)
        Me.Controls.Add(Me.DM_barra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMOrdiniWeb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ordini Remoti"
        CType(Me.DGWordiniWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSordiniWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGWordinirigheWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RordiniWebordiniRigaWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        Me.TAB_ordini.ResumeLayout(False)
        Me.TB_ordiniWeb.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.BSwebordiniriga, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_Ordini As DS_Ordini
    Friend WithEvents BSordiniWeb As BindingSource
    Friend WithEvents TAordiniWeb As DS_OrdiniTableAdapters.TAordiniWeb
    Friend WithEvents TableAdapterManager As DS_OrdiniTableAdapters.TableAdapterManager
    Friend WithEvents DGWordiniWeb As DataGridView
    Friend WithEvents DGWordinirigheWeb As DataGridView
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TTTestoRicerca As ToolStripTextBox
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents TTPB_stampa As ToolStripProgressBar
    Friend WithEvents TAB_ordini As TabControl
    Friend WithEvents TB_ordiniWeb As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TB_statistiche_Ordini As TabPage
    Friend WithEvents RordiniWebordiniRigaWeb As BindingSource
    Friend WithEvents TAordiniRigaWeb As DS_OrdiniTableAdapters.TAordiniRigaWeb
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CognomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TTSB_ricarica As ToolStripButton
    Friend WithEvents DGWRCid As DataGridViewLinkColumn
    Friend WithEvents DGWRCposizione As DataGridViewTextBoxColumn
    Friend WithEvents DGWRCdata As DataGridViewTextBoxColumn
    Friend WithEvents DGWRCprodotto As DataGridViewTextBoxColumn
    Friend WithEvents DGWRCquantita As DataGridViewTextBoxColumn
    Friend WithEvents DGWRCfornitore As DataGridViewTextBoxColumn
    Friend WithEvents DGWRCdipendente As DataGridViewTextBoxColumn
    Friend WithEvents DGWRClocazione As DataGridViewTextBoxColumn
    Friend WithEvents BSwebordiniriga As BindingSource
    Friend WithEvents TSBevasi As ToolStripButton
    Friend WithEvents TSLdescrizione As ToolStripLabel
    Friend WithEvents DGWCid As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DGWCinviato As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DGWCUtente As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DGWCconvalidato As DataGridViewTextBoxColumn
End Class
