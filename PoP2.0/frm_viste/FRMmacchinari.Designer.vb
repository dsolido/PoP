<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMmacchinari
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMmacchinari))
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
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
        Me.TTBTModifica = New System.Windows.Forms.ToolStripButton()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.Pic = New System.Windows.Forms.PictureBox()
        Me.TABmovimenti = New System.Windows.Forms.TabControl()
        Me.TBmacchinari = New System.Windows.Forms.TabPage()
        Me.LYmacchinari = New System.Windows.Forms.TableLayoutPanel()
        Me.DGmacchinari = New System.Windows.Forms.DataGridView()
        Me.LLmacchina = New System.Windows.Forms.LinkLabel()
        Me.CheckImmagineAttiva = New System.Windows.Forms.CheckBox()
        Me.TBmovimenti = New System.Windows.Forms.TabPage()
        Me.DGmovimenti = New System.Windows.Forms.DataGridView()
        Me.BSclienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_clienti = New PoP2.Comuni.DS_clienti()
        Me.BSlocazioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSUtenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.RelLocazioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGWCmarca = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGWCfornitore = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGWCMOVnu = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TAimmagini = New PoP2.Comuni.DS_prodottiTableAdapters.TAimmagini()
        Me.BSimmagini = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_prodotti = New PoP2.Comuni.DS_prodotti()
        Me.TA_locazione_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_locazione_new()
        Me.TA_cantieri_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_cantieri_new()
        Me.TA_utenti = New PoP2.Comuni.DS_utentiTableAdapters.TA_utenti()
        Me.DGWCidmacchinario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMovRevisione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMovBatterie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ErroriMacchinari = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.BSfornitore = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSmacchinari = New PoP2.Comuni.DSmacchinari()
        Me.BSmarche = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSmacchinari = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGWCMovID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMovidmacchina = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGWCMovidcliente = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGWCMovidlocazione = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGWCMovidutente = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGWCMovidservizio = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.BSservizio = New System.Windows.Forms.BindingSource(Me.components)
        Me.DGWCMovdata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMovAnnotazioni = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMovIDnfc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BSmovimenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAmacchine = New PoP2.Comuni.DSmacchinariTableAdapters.TAmacchine()
        Me.TableAdapterManager = New PoP2.Comuni.DSmacchinariTableAdapters.TableAdapterManager()
        Me.TAmarche = New PoP2.Comuni.DSmacchinariTableAdapters.TAmarche()
        Me.TAfornitori = New PoP2.Comuni.DSmacchinariTableAdapters.TAfornitori()
        Me.TAmovimentimacchine = New PoP2.Comuni.DSmacchinariTableAdapters.TAmovimentimacchine()
        Me.TAservizio = New PoP2.Comuni.DSmacchinariTableAdapters.TAservizio()
        Me.DGWCMACidMacchinari = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMacImmagine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMACDescrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMACidFornitore = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGWCMACidMarca = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DGWCMACDataAcquisto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMACprezzo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMACnu = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DGWCMacRevisione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMacBatterie = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCMacNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.immagini = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TABmovimenti.SuspendLayout()
        Me.TBmacchinari.SuspendLayout()
        Me.LYmacchinari.SuspendLayout()
        CType(Me.DGmacchinari, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TBmovimenti.SuspendLayout()
        CType(Me.DGmovimenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSclienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSlocazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RelLocazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSimmagini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_prodotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErroriMacchinari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSfornitore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSmacchinari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSmarche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSmacchinari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSservizio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSmovimenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DM_barra
        '
        Me.DM_barra.AddNewItem = Nothing
        Me.DM_barra.AutoSize = False
        Me.DM_barra.BindingSource = Me.BSmacchinari
        Me.DM_barra.CountItem = Me.ToolStripLabel1
        Me.DM_barra.DeleteItem = Nothing
        Me.DM_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DM_barra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DM_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTestoRicerca, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator4})
        Me.DM_barra.Location = New System.Drawing.Point(0, 665)
        Me.DM_barra.MoveFirstItem = Me.ToolStripButton1
        Me.DM_barra.MoveLastItem = Me.ToolStripButton4
        Me.DM_barra.MoveNextItem = Me.ToolStripButton3
        Me.DM_barra.MovePreviousItem = Me.ToolStripButton2
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.PositionItem = Me.ToolStripTextBox1
        Me.DM_barra.Size = New System.Drawing.Size(1234, 79)
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
        Me.TTBTModifica.Image = CType(resources.GetObject("TTBTModifica.Image"), System.Drawing.Image)
        Me.TTBTModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTModifica.Name = "TTBTModifica"
        Me.TTBTModifica.RightToLeftAutoMirrorImage = True
        Me.TTBTModifica.Size = New System.Drawing.Size(50, 70)
        Me.TTBTModifica.Text = "Modifica"
        Me.TTBTModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTModifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 79)
        '
        'Pic
        '
        Me.Pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Pic.Location = New System.Drawing.Point(667, 415)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(300, 300)
        Me.Pic.TabIndex = 193
        Me.Pic.TabStop = False
        Me.Pic.Visible = False
        '
        'TABmovimenti
        '
        Me.TABmovimenti.Controls.Add(Me.TBmacchinari)
        Me.TABmovimenti.Controls.Add(Me.TBmovimenti)
        Me.TABmovimenti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TABmovimenti.Location = New System.Drawing.Point(0, 0)
        Me.TABmovimenti.Name = "TABmovimenti"
        Me.TABmovimenti.SelectedIndex = 0
        Me.TABmovimenti.Size = New System.Drawing.Size(1234, 665)
        Me.TABmovimenti.TabIndex = 195
        '
        'TBmacchinari
        '
        Me.TBmacchinari.Controls.Add(Me.LYmacchinari)
        Me.TBmacchinari.Location = New System.Drawing.Point(4, 22)
        Me.TBmacchinari.Name = "TBmacchinari"
        Me.TBmacchinari.Padding = New System.Windows.Forms.Padding(3)
        Me.TBmacchinari.Size = New System.Drawing.Size(1226, 639)
        Me.TBmacchinari.TabIndex = 0
        Me.TBmacchinari.Text = "Macchine"
        Me.TBmacchinari.UseVisualStyleBackColor = True
        '
        'LYmacchinari
        '
        Me.LYmacchinari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LYmacchinari.ColumnCount = 1
        Me.LYmacchinari.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.LYmacchinari.Controls.Add(Me.DGmacchinari, 0, 1)
        Me.LYmacchinari.Controls.Add(Me.LLmacchina, 0, 0)
        Me.LYmacchinari.Controls.Add(Me.CheckImmagineAttiva, 0, 2)
        Me.LYmacchinari.Location = New System.Drawing.Point(6, 6)
        Me.LYmacchinari.Name = "LYmacchinari"
        Me.LYmacchinari.RowCount = 3
        Me.LYmacchinari.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35.0!))
        Me.LYmacchinari.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.0116!))
        Me.LYmacchinari.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.9884!))
        Me.LYmacchinari.Size = New System.Drawing.Size(1214, 627)
        Me.LYmacchinari.TabIndex = 195
        '
        'DGmacchinari
        '
        Me.DGmacchinari.AllowUserToAddRows = False
        Me.DGmacchinari.AllowUserToOrderColumns = True
        Me.DGmacchinari.AutoGenerateColumns = False
        Me.DGmacchinari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGmacchinari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DGmacchinari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGmacchinari.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWCMACidMacchinari, Me.DGWCMacImmagine, Me.DGWCMACDescrizione, Me.DGWCMACidFornitore, Me.DGWCMACidMarca, Me.DGWCMACDataAcquisto, Me.DGWCMACprezzo, Me.DGWCMACnu, Me.DGWCMacRevisione, Me.DGWCMacBatterie, Me.DGWCMacNote})
        Me.DGmacchinari.DataSource = Me.BSmacchinari
        Me.DGmacchinari.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGmacchinari.Location = New System.Drawing.Point(3, 38)
        Me.DGmacchinari.Name = "DGmacchinari"
        Me.DGmacchinari.Size = New System.Drawing.Size(1208, 479)
        Me.DGmacchinari.TabIndex = 2
        '
        'LLmacchina
        '
        Me.LLmacchina.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LLmacchina.AutoSize = True
        Me.LLmacchina.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSmacchinari, "descrizione", True))
        Me.LLmacchina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLmacchina.Location = New System.Drawing.Point(3, 7)
        Me.LLmacchina.Name = "LLmacchina"
        Me.LLmacchina.Size = New System.Drawing.Size(77, 20)
        Me.LLmacchina.TabIndex = 191
        Me.LLmacchina.TabStop = True
        Me.LLmacchina.Text = "macchina"
        '
        'CheckImmagineAttiva
        '
        Me.CheckImmagineAttiva.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckImmagineAttiva.AutoSize = True
        Me.CheckImmagineAttiva.Checked = True
        Me.CheckImmagineAttiva.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckImmagineAttiva.ImageIndex = 1
        Me.CheckImmagineAttiva.ImageList = Me.immagini
        Me.CheckImmagineAttiva.Location = New System.Drawing.Point(3, 523)
        Me.CheckImmagineAttiva.Name = "CheckImmagineAttiva"
        Me.CheckImmagineAttiva.Size = New System.Drawing.Size(84, 84)
        Me.CheckImmagineAttiva.TabIndex = 192
        Me.CheckImmagineAttiva.UseVisualStyleBackColor = True
        '
        'TBmovimenti
        '
        Me.TBmovimenti.Controls.Add(Me.DGmovimenti)
        Me.TBmovimenti.Location = New System.Drawing.Point(4, 22)
        Me.TBmovimenti.Name = "TBmovimenti"
        Me.TBmovimenti.Padding = New System.Windows.Forms.Padding(3)
        Me.TBmovimenti.Size = New System.Drawing.Size(1226, 639)
        Me.TBmovimenti.TabIndex = 1
        Me.TBmovimenti.Text = "Posizione Macchine"
        Me.TBmovimenti.UseVisualStyleBackColor = True
        '
        'DGmovimenti
        '
        Me.DGmovimenti.AllowUserToAddRows = False
        Me.DGmovimenti.AutoGenerateColumns = False
        Me.DGmovimenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGmovimenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGmovimenti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWCMovID, Me.DGWCMovidmacchina, Me.DGWCMovidcliente, Me.DGWCMovidlocazione, Me.DGWCMovidutente, Me.DGWCMovidservizio, Me.DGWCMovdata, Me.DGWCMovAnnotazioni, Me.DGWCMovIDnfc})
        Me.DGmovimenti.DataSource = Me.BSmovimenti
        Me.DGmovimenti.Location = New System.Drawing.Point(6, 6)
        Me.DGmovimenti.Name = "DGmovimenti"
        Me.DGmovimenti.Size = New System.Drawing.Size(1214, 627)
        Me.DGmovimenti.TabIndex = 0
        '
        'BSclienti
        '
        Me.BSclienti.DataMember = "DT_cantieri_new"
        Me.BSclienti.DataSource = Me.DS_clienti
        '
        'DS_clienti
        '
        Me.DS_clienti.DataSetName = "DS_clienti"
        Me.DS_clienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BSlocazioni
        '
        Me.BSlocazioni.DataMember = "DT_locazione_new"
        Me.BSlocazioni.DataSource = Me.DS_clienti
        '
        'BSUtenti
        '
        Me.BSUtenti.DataMember = "DT_utenti"
        Me.BSUtenti.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RelLocazioni
        '
        Me.RelLocazioni.DataMember = "DT_cantieri_new_DT_locazione_new"
        Me.RelLocazioni.DataSource = Me.BSclienti
        '
        'DGWCmarca
        '
        Me.DGWCmarca.DataPropertyName = "idmarca"
        Me.DGWCmarca.DataSource = Me.BSmarche
        Me.DGWCmarca.DisplayMember = "Azienda"
        Me.DGWCmarca.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DGWCmarca.FillWeight = 40.0!
        Me.DGWCmarca.HeaderText = "Marca"
        Me.DGWCmarca.Name = "DGWCmarca"
        Me.DGWCmarca.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCmarca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCmarca.ValueMember = "id"
        Me.DGWCmarca.Width = 92
        '
        'DGWCfornitore
        '
        Me.DGWCfornitore.DataPropertyName = "idforn"
        Me.DGWCfornitore.DataSource = Me.BSfornitore
        Me.DGWCfornitore.DisplayMember = "anagrafica"
        Me.DGWCfornitore.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DGWCfornitore.FillWeight = 40.0!
        Me.DGWCfornitore.HeaderText = "Fornitore"
        Me.DGWCfornitore.Name = "DGWCfornitore"
        Me.DGWCfornitore.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCfornitore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCfornitore.ValueMember = "id"
        Me.DGWCfornitore.Width = 93
        '
        'DGWCMOVnu
        '
        Me.DGWCMOVnu.Name = "DGWCMOVnu"
        '
        'TAimmagini
        '
        Me.TAimmagini.ClearBeforeFill = True
        '
        'BSimmagini
        '
        Me.BSimmagini.DataMember = "DTimmagini"
        Me.BSimmagini.DataSource = Me.DS_prodotti
        '
        'DS_prodotti
        '
        Me.DS_prodotti.DataSetName = "DS_prodotti"
        Me.DS_prodotti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_locazione_new
        '
        Me.TA_locazione_new.ClearBeforeFill = True
        '
        'TA_cantieri_new
        '
        Me.TA_cantieri_new.ClearBeforeFill = True
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'DGWCidmacchinario
        '
        Me.DGWCidmacchinario.DataPropertyName = "id"
        Me.DGWCidmacchinario.FillWeight = 30.0!
        Me.DGWCidmacchinario.HeaderText = "id"
        Me.DGWCidmacchinario.Name = "DGWCidmacchinario"
        '
        'DGWCMovRevisione
        '
        Me.DGWCMovRevisione.Name = "DGWCMovRevisione"
        '
        'DGWCMovBatterie
        '
        Me.DGWCMovBatterie.Name = "DGWCMovBatterie"
        '
        'ErroriMacchinari
        '
        Me.ErroriMacchinari.ContainerControl = Me
        '
        'BSfornitore
        '
        Me.BSfornitore.DataMember = "DTfornitori"
        Me.BSfornitore.DataSource = Me.DSmacchinari
        '
        'DSmacchinari
        '
        Me.DSmacchinari.DataSetName = "DSmacchinari"
        Me.DSmacchinari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BSmarche
        '
        Me.BSmarche.DataMember = "DTmarche"
        Me.BSmarche.DataSource = Me.DSmacchinari
        '
        'BSmacchinari
        '
        Me.BSmacchinari.DataMember = "DTmacchine"
        Me.BSmacchinari.DataSource = Me.DSmacchinari
        '
        'DGWCMovID
        '
        Me.DGWCMovID.DataPropertyName = "id"
        Me.DGWCMovID.FillWeight = 20.0!
        Me.DGWCMovID.HeaderText = "id"
        Me.DGWCMovID.Name = "DGWCMovID"
        '
        'DGWCMovidmacchina
        '
        Me.DGWCMovidmacchina.DataPropertyName = "idmacchina"
        Me.DGWCMovidmacchina.DataSource = Me.BSmacchinari
        Me.DGWCMovidmacchina.DisplayMember = "descrizione"
        Me.DGWCMovidmacchina.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DGWCMovidmacchina.HeaderText = "Tipo Macchina"
        Me.DGWCMovidmacchina.Name = "DGWCMovidmacchina"
        Me.DGWCMovidmacchina.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCMovidmacchina.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCMovidmacchina.ValueMember = "id"
        '
        'DGWCMovidcliente
        '
        Me.DGWCMovidcliente.DataPropertyName = "idcliente"
        Me.DGWCMovidcliente.DataSource = Me.BSclienti
        Me.DGWCMovidcliente.DisplayMember = "societa"
        Me.DGWCMovidcliente.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox
        Me.DGWCMovidcliente.HeaderText = "Cliente"
        Me.DGWCMovidcliente.Name = "DGWCMovidcliente"
        Me.DGWCMovidcliente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCMovidcliente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCMovidcliente.ValueMember = "id"
        '
        'DGWCMovidlocazione
        '
        Me.DGWCMovidlocazione.DataPropertyName = "idlocazione"
        Me.DGWCMovidlocazione.DataSource = Me.BSlocazioni
        Me.DGWCMovidlocazione.DisplayMember = "locazione"
        Me.DGWCMovidlocazione.HeaderText = "Dettaglio Cliente"
        Me.DGWCMovidlocazione.Name = "DGWCMovidlocazione"
        Me.DGWCMovidlocazione.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCMovidlocazione.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCMovidlocazione.ValueMember = "id"
        '
        'DGWCMovidutente
        '
        Me.DGWCMovidutente.DataPropertyName = "idutente"
        Me.DGWCMovidutente.DataSource = Me.BSUtenti
        Me.DGWCMovidutente.DisplayMember = "Anagrafica"
        Me.DGWCMovidutente.HeaderText = "idutente"
        Me.DGWCMovidutente.Name = "DGWCMovidutente"
        Me.DGWCMovidutente.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCMovidutente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCMovidutente.ValueMember = "id"
        '
        'DGWCMovidservizio
        '
        Me.DGWCMovidservizio.DataPropertyName = "id_servizio"
        Me.DGWCMovidservizio.DataSource = Me.BSservizio
        Me.DGWCMovidservizio.DisplayMember = "descrizione"
        Me.DGWCMovidservizio.HeaderText = "id_servizio"
        Me.DGWCMovidservizio.Name = "DGWCMovidservizio"
        Me.DGWCMovidservizio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCMovidservizio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCMovidservizio.ValueMember = "id"
        '
        'BSservizio
        '
        Me.BSservizio.DataMember = "DTservizio"
        Me.BSservizio.DataSource = Me.DSmacchinari
        '
        'DGWCMovdata
        '
        Me.DGWCMovdata.DataPropertyName = "data"
        Me.DGWCMovdata.HeaderText = "data"
        Me.DGWCMovdata.Name = "DGWCMovdata"
        '
        'DGWCMovAnnotazioni
        '
        Me.DGWCMovAnnotazioni.DataPropertyName = "note"
        Me.DGWCMovAnnotazioni.HeaderText = "note"
        Me.DGWCMovAnnotazioni.Name = "DGWCMovAnnotazioni"
        '
        'DGWCMovIDnfc
        '
        Me.DGWCMovIDnfc.DataPropertyName = "IDnfc"
        Me.DGWCMovIDnfc.HeaderText = "IDnfc"
        Me.DGWCMovIDnfc.Name = "DGWCMovIDnfc"
        '
        'BSmovimenti
        '
        Me.BSmovimenti.DataMember = "DTmovimentimacchine"
        Me.BSmovimenti.DataSource = Me.DSmacchinari
        '
        'TAmacchine
        '
        Me.TAmacchine.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DSmacchinariTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TAmarche
        '
        Me.TAmarche.ClearBeforeFill = True
        '
        'TAfornitori
        '
        Me.TAfornitori.ClearBeforeFill = True
        '
        'TAmovimentimacchine
        '
        Me.TAmovimentimacchine.ClearBeforeFill = True
        '
        'TAservizio
        '
        Me.TAservizio.ClearBeforeFill = True
        '
        'DGWCMACidMacchinari
        '
        Me.DGWCMACidMacchinari.DataPropertyName = "id"
        Me.DGWCMACidMacchinari.FillWeight = 20.0!
        Me.DGWCMACidMacchinari.HeaderText = "id"
        Me.DGWCMACidMacchinari.Name = "DGWCMACidMacchinari"
        '
        'DGWCMacImmagine
        '
        Me.DGWCMacImmagine.FillWeight = 20.0!
        Me.DGWCMacImmagine.HeaderText = "Foto"
        Me.DGWCMacImmagine.Name = "DGWCMacImmagine"
        '
        'DGWCMACDescrizione
        '
        Me.DGWCMACDescrizione.DataPropertyName = "descrizione"
        Me.DGWCMACDescrizione.HeaderText = "descrizione"
        Me.DGWCMACDescrizione.Name = "DGWCMACDescrizione"
        '
        'DGWCMACidFornitore
        '
        Me.DGWCMACidFornitore.DataPropertyName = "idforn"
        Me.DGWCMACidFornitore.DataSource = Me.BSfornitore
        Me.DGWCMACidFornitore.DisplayMember = "anagrafica"
        Me.DGWCMACidFornitore.FillWeight = 60.0!
        Me.DGWCMACidFornitore.HeaderText = "Fornitore"
        Me.DGWCMACidFornitore.Name = "DGWCMACidFornitore"
        Me.DGWCMACidFornitore.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCMACidFornitore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCMACidFornitore.ValueMember = "id"
        '
        'DGWCMACidMarca
        '
        Me.DGWCMACidMarca.DataPropertyName = "idmarca"
        Me.DGWCMACidMarca.DataSource = Me.BSmarche
        Me.DGWCMACidMarca.DisplayMember = "Azienda"
        Me.DGWCMACidMarca.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DGWCMACidMarca.FillWeight = 60.0!
        Me.DGWCMACidMarca.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DGWCMACidMarca.HeaderText = "Marca"
        Me.DGWCMACidMarca.Name = "DGWCMACidMarca"
        Me.DGWCMACidMarca.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCMACidMarca.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCMACidMarca.ValueMember = "id"
        '
        'DGWCMACDataAcquisto
        '
        Me.DGWCMACDataAcquisto.DataPropertyName = "dtacquisto"
        Me.DGWCMACDataAcquisto.FillWeight = 40.0!
        Me.DGWCMACDataAcquisto.HeaderText = "Data Acq"
        Me.DGWCMACDataAcquisto.Name = "DGWCMACDataAcquisto"
        '
        'DGWCMACprezzo
        '
        Me.DGWCMACprezzo.DataPropertyName = "prezzo"
        Me.DGWCMACprezzo.FillWeight = 40.0!
        Me.DGWCMACprezzo.HeaderText = "Prezzo"
        Me.DGWCMACprezzo.Name = "DGWCMACprezzo"
        '
        'DGWCMACnu
        '
        Me.DGWCMACnu.DataPropertyName = "nu"
        Me.DGWCMACnu.FalseValue = "0"
        Me.DGWCMACnu.FillWeight = 15.0!
        Me.DGWCMACnu.HeaderText = "N/U"
        Me.DGWCMACnu.IndeterminateValue = "0"
        Me.DGWCMACnu.Name = "DGWCMACnu"
        Me.DGWCMACnu.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGWCMACnu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DGWCMACnu.TrueValue = "1"
        '
        'DGWCMacRevisione
        '
        Me.DGWCMacRevisione.DataPropertyName = "revisione"
        Me.DGWCMacRevisione.FillWeight = 40.0!
        Me.DGWCMacRevisione.HeaderText = "Data Rev"
        Me.DGWCMacRevisione.Name = "DGWCMacRevisione"
        '
        'DGWCMacBatterie
        '
        Me.DGWCMacBatterie.DataPropertyName = "batterie"
        Me.DGWCMacBatterie.FillWeight = 40.0!
        Me.DGWCMacBatterie.HeaderText = "Data Batt"
        Me.DGWCMacBatterie.Name = "DGWCMacBatterie"
        '
        'DGWCMacNote
        '
        Me.DGWCMacNote.DataPropertyName = "note"
        Me.DGWCMacNote.HeaderText = "Note"
        Me.DGWCMacNote.Name = "DGWCMacNote"
        '
        'immagini
        '
        Me.immagini.ImageStream = CType(resources.GetObject("immagini.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.immagini.TransparentColor = System.Drawing.Color.Transparent
        Me.immagini.Images.SetKeyName(0, "nofoto.png")
        Me.immagini.Images.SetKeyName(1, "foto.png")
        '
        'FRMmacchinari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 744)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.TABmovimenti)
        Me.Controls.Add(Me.DM_barra)
        Me.Name = "FRMmacchinari"
        Me.Text = "Macchinari"
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TABmovimenti.ResumeLayout(False)
        Me.TBmacchinari.ResumeLayout(False)
        Me.LYmacchinari.ResumeLayout(False)
        Me.LYmacchinari.PerformLayout()
        CType(Me.DGmacchinari, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TBmovimenti.ResumeLayout(False)
        CType(Me.DGmovimenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSclienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSlocazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RelLocazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSimmagini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_prodotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErroriMacchinari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSfornitore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSmacchinari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSmarche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSmacchinari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSservizio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSmovimenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSmacchinari As DSmacchinari
    Friend WithEvents BSmacchinari As BindingSource
    Friend WithEvents TAmacchine As DSmacchinariTableAdapters.TAmacchine
    Friend WithEvents TableAdapterManager As DSmacchinariTableAdapters.TableAdapterManager
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TTBTElimina As ToolStripButton
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
    Friend WithEvents TTBTModifica As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BSmarche As BindingSource
    Friend WithEvents TAmarche As DSmacchinariTableAdapters.TAmarche
    Friend WithEvents BSfornitore As BindingSource
    Friend WithEvents TAfornitori As DSmacchinariTableAdapters.TAfornitori
    Friend WithEvents TAimmagini As DS_prodottiTableAdapters.TAimmagini
    Friend WithEvents BSimmagini As BindingSource
    Friend WithEvents DS_prodotti As DS_prodotti
    Friend WithEvents Pic As PictureBox
    Friend WithEvents TABmovimenti As TabControl
    Friend WithEvents TBmacchinari As TabPage
    Friend WithEvents LYmacchinari As TableLayoutPanel
    Friend WithEvents DGmacchinari As DataGridView
    Friend WithEvents LLmacchina As LinkLabel
    Friend WithEvents CheckImmagineAttiva As CheckBox
    Friend WithEvents TBmovimenti As TabPage
    Friend WithEvents BSmovimenti As BindingSource
    Friend WithEvents TAmovimentimacchine As DSmacchinariTableAdapters.TAmovimentimacchine
    Friend WithEvents DGmovimenti As DataGridView
    Friend WithEvents BSlocazioni As BindingSource
    Friend WithEvents DS_clienti As DS_clienti
    Friend WithEvents TA_locazione_new As DS_clientiTableAdapters.TA_locazione_new
    Friend WithEvents DGWCidmacchinario As DataGridViewTextBoxColumn
    Friend WithEvents DGWCmarca As DataGridViewComboBoxColumn
    Friend WithEvents DGWCfornitore As DataGridViewComboBoxColumn
    Friend WithEvents BSclienti As BindingSource
    Friend WithEvents RelLocazioni As BindingSource
    Friend WithEvents TA_cantieri_new As DS_clientiTableAdapters.TA_cantieri_new
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents BSUtenti As BindingSource
    Friend WithEvents TA_utenti As DS_utentiTableAdapters.TA_utenti
    Friend WithEvents BSservizio As BindingSource
    Friend WithEvents TAservizio As DSmacchinariTableAdapters.TAservizio
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMOVnu As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMovRevisione As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMovBatterie As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMovID As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMovidmacchina As DataGridViewComboBoxColumn
    Friend WithEvents DGWCMovidcliente As DataGridViewComboBoxColumn
    Friend WithEvents DGWCMovidlocazione As DataGridViewComboBoxColumn
    Friend WithEvents DGWCMovidutente As DataGridViewComboBoxColumn
    Friend WithEvents DGWCMovidservizio As DataGridViewComboBoxColumn
    Friend WithEvents DGWCMovdata As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMovAnnotazioni As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMovIDnfc As DataGridViewTextBoxColumn
    Friend WithEvents ErroriMacchinari As ErrorProvider
    Friend WithEvents DGWCMACidMacchinari As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMacImmagine As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMACDescrizione As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMACidFornitore As DataGridViewComboBoxColumn
    Friend WithEvents DGWCMACidMarca As DataGridViewComboBoxColumn
    Friend WithEvents DGWCMACDataAcquisto As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMACprezzo As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMACnu As DataGridViewCheckBoxColumn
    Friend WithEvents DGWCMacRevisione As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMacBatterie As DataGridViewTextBoxColumn
    Friend WithEvents DGWCMacNote As DataGridViewTextBoxColumn
    Friend WithEvents immagini As ImageList
End Class
