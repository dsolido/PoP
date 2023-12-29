<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMsostituzioni
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
        Dim IddesLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim IddipLabel1 As System.Windows.Forms.Label
        Dim IngLabel As System.Windows.Forms.Label
        Dim UscLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMsostituzioni))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DSfestivita = New PoP2.Comuni.DSfestivita()
        Me.BSutentisost = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAutentisostituzioni = New PoP2.Comuni.DSfestivitaTableAdapters.TAutentisostituzioni()
        Me.TableAdapterManager = New PoP2.Comuni.DSfestivitaTableAdapters.TableAdapterManager()
        Me.IddesTextBox = New System.Windows.Forms.TextBox()
        Me.Dinizio = New System.Windows.Forms.DateTimePicker()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
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
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.IddipComboBox = New System.Windows.Forms.ComboBox()
        Me.BSutenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.TA_utenti = New PoP2.Comuni.DS_utentiTableAdapters.TA_utenti()
        Me.IngTextBox = New System.Windows.Forms.TextBox()
        Me.UscTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Dfine = New System.Windows.Forms.DateTimePicker()
        Me.PassaggiNUD = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LBdettagliocliente = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LVimpegni = New System.Windows.Forms.ListView()
        Me.txDipendente = New System.Windows.Forms.TextBox()
        Me.dgPianolavoro = New System.Windows.Forms.DataGridView()
        Me.dgwcid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcIng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcusc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcDettaglio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcDal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcAl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSostituto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dgcModificaOrario = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgwcAssente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgwcNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEditata = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TA_locazione_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_locazione_new()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tmpBSSost = New System.Windows.Forms.BindingSource(Me.components)
        IddesLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        IddipLabel1 = New System.Windows.Forms.Label()
        IngLabel = New System.Windows.Forms.Label()
        UscLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.DSfestivita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSutentisost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        CType(Me.BSutenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PassaggiNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgPianolavoro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tmpBSSost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IddesLabel
        '
        IddesLabel.AutoSize = True
        IddesLabel.Location = New System.Drawing.Point(285, 385)
        IddesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IddesLabel.Name = "IddesLabel"
        IddesLabel.Size = New System.Drawing.Size(51, 20)
        IddesLabel.TabIndex = 5
        IddesLabel.Text = "iddes:"
        IddesLabel.Visible = False
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(83, 344)
        DataLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(34, 20)
        DataLabel.TabIndex = 7
        DataLabel.Text = "Da:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(72, 463)
        NoteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(45, 20)
        NoteLabel.TabIndex = 9
        NoteLabel.Text = "note:"
        '
        'IddipLabel1
        '
        IddipLabel1.AutoSize = True
        IddipLabel1.Location = New System.Drawing.Point(26, 305)
        IddipLabel1.Name = "IddipLabel1"
        IddipLabel1.Size = New System.Drawing.Size(87, 20)
        IddipLabel1.TabIndex = 190
        IddipLabel1.Text = "Sostituisce"
        '
        'IngLabel
        '
        IngLabel.AutoSize = True
        IngLabel.Location = New System.Drawing.Point(44, 401)
        IngLabel.Name = "IngLabel"
        IngLabel.Size = New System.Drawing.Size(73, 20)
        IngLabel.TabIndex = 191
        IngLabel.Text = "ingresso:"
        '
        'UscLabel
        '
        UscLabel.AutoSize = True
        UscLabel.Location = New System.Drawing.Point(62, 431)
        UscLabel.Name = "UscLabel"
        UscLabel.Size = New System.Drawing.Size(55, 20)
        UscLabel.TabIndex = 192
        UscLabel.Text = "uscita:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(285, 352)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(51, 20)
        Label1.TabIndex = 194
        Label1.Text = "iddes:"
        Label1.Visible = False
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(93, 372)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(24, 20)
        Label2.TabIndex = 197
        Label2.Text = "A:"
        '
        'DSfestivita
        '
        Me.DSfestivita.DataSetName = "DSfestivita"
        Me.DSfestivita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BSutentisost
        '
        Me.BSutentisost.DataMember = "DTutentisostituzioni"
        Me.BSutentisost.DataSource = Me.DSfestivita
        '
        'TAutentisostituzioni
        '
        Me.TAutentisostituzioni.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DSfestivitaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IddesTextBox
        '
        Me.IddesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSutentisost, "iddes", True))
        Me.IddesTextBox.Location = New System.Drawing.Point(356, 380)
        Me.IddesTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IddesTextBox.Name = "IddesTextBox"
        Me.IddesTextBox.Size = New System.Drawing.Size(121, 26)
        Me.IddesTextBox.TabIndex = 6
        Me.IddesTextBox.Visible = False
        '
        'Dinizio
        '
        Me.Dinizio.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BSutentisost, "data", True))
        Me.Dinizio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dinizio.Location = New System.Drawing.Point(134, 341)
        Me.Dinizio.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dinizio.Name = "Dinizio"
        Me.Dinizio.Size = New System.Drawing.Size(121, 26)
        Me.Dinizio.TabIndex = 2
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSutentisost, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(134, 457)
        Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(342, 26)
        Me.NoteTextBox.TabIndex = 6
        '
        'DM_barra
        '
        Me.DM_barra.AddNewItem = Nothing
        Me.DM_barra.AutoSize = False
        Me.DM_barra.BindingSource = Me.BSutentisost
        Me.DM_barra.CountItem = Me.ToolStripLabel1
        Me.DM_barra.DeleteItem = Me.TTBTElimina
        Me.DM_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DM_barra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DM_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.ToolStripSeparator4})
        Me.DM_barra.Location = New System.Drawing.Point(0, 515)
        Me.DM_barra.MoveFirstItem = Me.ToolStripButton1
        Me.DM_barra.MoveLastItem = Me.ToolStripButton4
        Me.DM_barra.MoveNextItem = Me.ToolStripButton3
        Me.DM_barra.MovePreviousItem = Me.ToolStripButton2
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.DM_barra.PositionItem = Me.ToolStripTextBox1
        Me.DM_barra.Size = New System.Drawing.Size(1121, 72)
        Me.DM_barra.TabIndex = 12
        Me.DM_barra.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 69)
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
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton1.Text = "Inizio"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton2.Text = "Indietro"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 72)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posizione"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(53, 33)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posizione corrente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 72)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton3.Text = "Avanti"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton4.Text = "Fine"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 72)
        Me.ToolStripSeparator3.Visible = False
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
        Me.TTBTModifica.Visible = False
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
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 72)
        Me.ToolStripSeparator4.Visible = False
        '
        'IddipComboBox
        '
        Me.IddipComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BSutentisost, "iddip", True))
        Me.IddipComboBox.DataSource = Me.BSutenti
        Me.IddipComboBox.DisplayMember = "Anagrafica"
        Me.IddipComboBox.FormattingEnabled = True
        Me.IddipComboBox.Location = New System.Drawing.Point(135, 305)
        Me.IddipComboBox.Name = "IddipComboBox"
        Me.IddipComboBox.Size = New System.Drawing.Size(342, 28)
        Me.IddipComboBox.TabIndex = 1
        Me.IddipComboBox.ValueMember = "id"
        '
        'BSutenti
        '
        Me.BSutenti.DataMember = "DT_utenti"
        Me.BSutenti.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'IngTextBox
        '
        Me.IngTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSutentisost, "ing", True))
        Me.IngTextBox.Location = New System.Drawing.Point(134, 398)
        Me.IngTextBox.Name = "IngTextBox"
        Me.IngTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IngTextBox.TabIndex = 4
        Me.IngTextBox.WordWrap = False
        '
        'UscTextBox
        '
        Me.UscTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSutentisost, "usc", True))
        Me.UscTextBox.Location = New System.Drawing.Point(134, 428)
        Me.UscTextBox.Name = "UscTextBox"
        Me.UscTextBox.Size = New System.Drawing.Size(100, 26)
        Me.UscTextBox.TabIndex = 5
        Me.UscTextBox.WordWrap = False
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSutentisost, "idsost", True))
        Me.TextBox1.Location = New System.Drawing.Point(356, 347)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(121, 26)
        Me.TextBox1.TabIndex = 195
        Me.TextBox1.Visible = False
        '
        'Dfine
        '
        Me.Dfine.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dfine.Location = New System.Drawing.Point(134, 369)
        Me.Dfine.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dfine.Name = "Dfine"
        Me.Dfine.Size = New System.Drawing.Size(121, 26)
        Me.Dfine.TabIndex = 3
        '
        'PassaggiNUD
        '
        Me.PassaggiNUD.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BSutentisost, "idpassaggi", True))
        Me.PassaggiNUD.Location = New System.Drawing.Point(135, 274)
        Me.PassaggiNUD.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.PassaggiNUD.Name = "PassaggiNUD"
        Me.PassaggiNUD.Size = New System.Drawing.Size(52, 26)
        Me.PassaggiNUD.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 277)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 20)
        Me.Label3.TabIndex = 199
        Me.Label3.Text = "N° Passaggi:"
        '
        'LBdettagliocliente
        '
        Me.LBdettagliocliente.AutoSize = True
        Me.LBdettagliocliente.Location = New System.Drawing.Point(210, 277)
        Me.LBdettagliocliente.Name = "LBdettagliocliente"
        Me.LBdettagliocliente.Size = New System.Drawing.Size(73, 20)
        Me.LBdettagliocliente.TabIndex = 200
        Me.LBdettagliocliente.Text = "Dettaglio"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LVimpegni)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(604, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(510, 232)
        Me.GroupBox1.TabIndex = 202
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impegno già Programmati"
        '
        'LVimpegni
        '
        Me.LVimpegni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVimpegni.HideSelection = False
        Me.LVimpegni.Location = New System.Drawing.Point(3, 16)
        Me.LVimpegni.Name = "LVimpegni"
        Me.LVimpegni.Size = New System.Drawing.Size(504, 213)
        Me.LVimpegni.TabIndex = 202
        Me.LVimpegni.UseCompatibleStateImageBehavior = False
        '
        'txDipendente
        '
        Me.txDipendente.Location = New System.Drawing.Point(24, 35)
        Me.txDipendente.Name = "txDipendente"
        Me.txDipendente.Size = New System.Drawing.Size(337, 26)
        Me.txDipendente.TabIndex = 203
        '
        'dgPianolavoro
        '
        Me.dgPianolavoro.AutoGenerateColumns = False
        Me.dgPianolavoro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPianolavoro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPianolavoro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcid, Me.dgwcIng, Me.dgwcusc, Me.dgwcDettaglio, Me.dgwcDal, Me.dgwcAl, Me.dgwcSostituto, Me.dgcModificaOrario, Me.dgwcAssente, Me.dgwcNote, Me.dgvEditata})
        Me.dgPianolavoro.DataSource = Me.tmpBSSost
        Me.dgPianolavoro.Location = New System.Drawing.Point(0, 90)
        Me.dgPianolavoro.Name = "dgPianolavoro"
        Me.dgPianolavoro.Size = New System.Drawing.Size(1097, 150)
        Me.dgPianolavoro.TabIndex = 204
        '
        'dgwcid
        '
        Me.dgwcid.HeaderText = "id"
        Me.dgwcid.Name = "dgwcid"
        Me.dgwcid.Visible = False
        '
        'dgwcIng
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgwcIng.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgwcIng.FillWeight = 30.0!
        Me.dgwcIng.HeaderText = "ing"
        Me.dgwcIng.Name = "dgwcIng"
        Me.dgwcIng.DataPropertyName = "ing"
        '
        'dgwcusc
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "t"
        Me.dgwcusc.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgwcusc.FillWeight = 30.0!
        Me.dgwcusc.HeaderText = "usc"
        Me.dgwcusc.Name = "dgwcusc"
        Me.dgwcusc.DataPropertyName = "usc"
        '
        'dgwcDettaglio
        '
        Me.dgwcDettaglio.FillWeight = 80.0!
        Me.dgwcDettaglio.HeaderText = "dettaglio"
        Me.dgwcDettaglio.Name = "dgwcDettaglio"
        Me.dgwcDettaglio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcDettaglio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable

        '
        'dgwcDal
        '
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dgwcDal.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgwcDal.FillWeight = 50.0!
        Me.dgwcDal.HeaderText = "dal"
        Me.dgwcDal.Name = "dgwcDal"
        '
        'dgwcAl
        '
        DataGridViewCellStyle4.Format = "d"
        Me.dgwcAl.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgwcAl.FillWeight = 50.0!
        Me.dgwcAl.HeaderText = "Al"
        Me.dgwcAl.Name = "dgwcAl"
        '
        'dgwcSostituto
        '
        Me.dgwcSostituto.DataSource = Me.BSutenti
        Me.dgwcSostituto.DisplayMember = "Anagrafica"
        Me.dgwcSostituto.HeaderText = "Sostituto"
        Me.dgwcSostituto.Name = "dgwcSostituto"
        Me.dgwcSostituto.ValueMember = "id"
        '
        'dgcModificaOrario
        '
        Me.dgcModificaOrario.FillWeight = 20.0!
        Me.dgcModificaOrario.HeaderText = "MOD"
        Me.dgcModificaOrario.Name = "dgcModificaOrario"
        '
        'dgwcAssente
        '
        Me.dgwcAssente.FillWeight = 20.0!
        Me.dgwcAssente.HeaderText = "ASS"
        Me.dgwcAssente.Name = "dgwcAssente"
        '
        'dgwcNote
        '
        Me.dgwcNote.HeaderText = "Note"
        Me.dgwcNote.Name = "dgwcNote"
        '
        'dgvEditata
        '
        Me.dgvEditata.FillWeight = 10.0!
        Me.dgvEditata.HeaderText = "Modificata"
        Me.dgvEditata.Name = "dgvEditata"
        '
        'TA_locazione_new
        '
        Me.TA_locazione_new.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Turni di lavoro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 20)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Dipendente da sostituire"
        '
        'FRMsostituzioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 587)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgPianolavoro)
        Me.Controls.Add(Me.txDipendente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LBdettagliocliente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PassaggiNUD)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.Dfine)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(UscLabel)
        Me.Controls.Add(Me.UscTextBox)
        Me.Controls.Add(IngLabel)
        Me.Controls.Add(Me.IngTextBox)
        Me.Controls.Add(IddipLabel1)
        Me.Controls.Add(Me.IddipComboBox)
        Me.Controls.Add(Me.DM_barra)
        Me.Controls.Add(IddesLabel)
        Me.Controls.Add(Me.IddesTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.Dinizio)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRMsostituzioni"
        Me.Text = "Sostituzioni"
        CType(Me.DSfestivita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSutentisost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        CType(Me.BSutenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PassaggiNUD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgPianolavoro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tmpBSSost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSfestivita As DSfestivita
    Friend WithEvents BSutentisost As BindingSource
    Friend WithEvents TAutentisostituzioni As DSfestivitaTableAdapters.TAutentisostituzioni
    Friend WithEvents TableAdapterManager As DSfestivitaTableAdapters.TableAdapterManager
    Friend WithEvents IddesTextBox As TextBox
    Friend WithEvents Dinizio As DateTimePicker
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TTBTElimina As ToolStripButton
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
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents IddipComboBox As ComboBox
    Friend WithEvents BSutenti As BindingSource
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents TA_utenti As DS_utentiTableAdapters.TA_utenti
    Friend WithEvents IngTextBox As TextBox
    Friend WithEvents UscTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Dfine As DateTimePicker
    Friend WithEvents PassaggiNUD As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents LBdettagliocliente As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LVimpegni As ListView
    Friend WithEvents txDipendente As TextBox
    Friend WithEvents dgPianolavoro As DataGridView
    Friend WithEvents TA_locazione_new As DS_clientiTableAdapters.TA_locazione_new
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgwcid As DataGridViewTextBoxColumn
    Friend WithEvents dgwcIng As DataGridViewTextBoxColumn
    Friend WithEvents dgwcusc As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDettaglio As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDal As DataGridViewTextBoxColumn
    Friend WithEvents dgwcAl As DataGridViewTextBoxColumn
    Friend WithEvents dgwcSostituto As DataGridViewComboBoxColumn
    Friend WithEvents dgcModificaOrario As DataGridViewCheckBoxColumn
    Friend WithEvents dgwcAssente As DataGridViewCheckBoxColumn
    Friend WithEvents dgwcNote As DataGridViewTextBoxColumn
    Friend WithEvents dgvEditata As DataGridViewTextBoxColumn
    Friend WithEvents tmpBSSost As BindingSource
End Class
