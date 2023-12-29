Imports Pop2.Comuni

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmOperazioni
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim ImpegnometroquadroLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim AttivoLabel As System.Windows.Forms.Label
        Dim IdcategoriaLabel As System.Windows.Forms.Label
        Dim ImpegnonumeroLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmOperazioni))
        Me.DsPreventivi = New Pop2.Comuni.dsPreventivi()
        Me.bsPreventiviOperazioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaPreventiviOperazioni = New Pop2.Comuni.dsPreventiviTableAdapters.taPreventiviOperazioni()
        Me.TableAdapterManager = New Pop2.Comuni.dsPreventiviTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.ImpegnometroquadroTextBox = New System.Windows.Forms.TextBox()
        Me.DataDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ImpegnonumeroTextBox = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.bsPreventiviCategorie = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaPreventiviCategorie = New Pop2.Comuni.dsPreventiviTableAdapters.taPreventiviCategorie()
        Me.dgwOperazioni = New System.Windows.Forms.DataGridView()
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
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.BK_filtro = New System.Windows.Forms.ToolStripDropDownButton()
        Me.InScadenzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BudgetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttiviToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TuttiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        IdLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        ImpegnometroquadroLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        AttivoLabel = New System.Windows.Forms.Label()
        IdcategoriaLabel = New System.Windows.Forms.Label()
        ImpegnonumeroLabel = New System.Windows.Forms.Label()
        CType(Me.DsPreventivi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventiviOperazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventiviCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwOperazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(16, 131)
        IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(23, 17)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(16, 158)
        DescrizioneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(84, 17)
        DescrizioneLabel.TabIndex = 3
        DescrizioneLabel.Text = "descrizione:"
        '
        'ImpegnometroquadroLabel
        '
        ImpegnometroquadroLabel.AutoSize = True
        ImpegnometroquadroLabel.Location = New System.Drawing.Point(170, 269)
        ImpegnometroquadroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ImpegnometroquadroLabel.Name = "ImpegnometroquadroLabel"
        ImpegnometroquadroLabel.Size = New System.Drawing.Size(97, 17)
        ImpegnometroquadroLabel.TabIndex = 5
        ImpegnometroquadroLabel.Text = "Impegno al m²"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(16, 186)
        DataLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(40, 17)
        DataLabel.TabIndex = 7
        DataLabel.Text = "data:"
        '
        'AttivoLabel
        '
        AttivoLabel.AutoSize = True
        AttivoLabel.Location = New System.Drawing.Point(16, 215)
        AttivoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AttivoLabel.Name = "AttivoLabel"
        AttivoLabel.Size = New System.Drawing.Size(46, 17)
        AttivoLabel.TabIndex = 9
        AttivoLabel.Text = "attivo:"
        '
        'IdcategoriaLabel
        '
        IdcategoriaLabel.AutoSize = True
        IdcategoriaLabel.Location = New System.Drawing.Point(16, 244)
        IdcategoriaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdcategoriaLabel.Name = "IdcategoriaLabel"
        IdcategoriaLabel.Size = New System.Drawing.Size(69, 17)
        IdcategoriaLabel.TabIndex = 11
        IdcategoriaLabel.Text = "Categoria"
        '
        'ImpegnonumeroLabel
        '
        ImpegnonumeroLabel.AutoSize = True
        ImpegnonumeroLabel.Location = New System.Drawing.Point(301, 269)
        ImpegnonumeroLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ImpegnonumeroLabel.Name = "ImpegnonumeroLabel"
        ImpegnonumeroLabel.Size = New System.Drawing.Size(92, 17)
        ImpegnonumeroLabel.TabIndex = 13
        ImpegnonumeroLabel.Text = "Impegno a n°"
        '
        'DsPreventivi
        '
        Me.DsPreventivi.DataSetName = "dsPreventivi"
        Me.DsPreventivi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsPreventiviOperazioni
        '
        Me.bsPreventiviOperazioni.DataMember = "dtPreventiviOperazioni"
        Me.bsPreventiviOperazioni.DataSource = Me.DsPreventivi
        '
        'TaPreventiviOperazioni
        '
        Me.TaPreventiviOperazioni.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = Pop2.Comuni.dsPreventiviTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviOperazioni, "id", True))
        Me.IdTextBox.Enabled = False
        Me.IdTextBox.Location = New System.Drawing.Point(170, 127)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(45, 23)
        Me.IdTextBox.TabIndex = 2
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviOperazioni, "descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(170, 154)
        Me.DescrizioneTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(512, 23)
        Me.DescrizioneTextBox.TabIndex = 0
        '
        'ImpegnometroquadroTextBox
        '
        Me.ImpegnometroquadroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviOperazioni, "impegnometroquadro", True))
        Me.ImpegnometroquadroTextBox.Location = New System.Drawing.Point(179, 290)
        Me.ImpegnometroquadroTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpegnometroquadroTextBox.Name = "ImpegnometroquadroTextBox"
        Me.ImpegnometroquadroTextBox.Size = New System.Drawing.Size(78, 23)
        Me.ImpegnometroquadroTextBox.TabIndex = 4
        '
        'DataDateTimePicker
        '
        Me.DataDateTimePicker.CustomFormat = ""
        Me.DataDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.bsPreventiviOperazioni, "data", True))
        Me.DataDateTimePicker.Location = New System.Drawing.Point(170, 181)
        Me.DataDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DataDateTimePicker.Name = "DataDateTimePicker"
        Me.DataDateTimePicker.Size = New System.Drawing.Size(265, 23)
        Me.DataDateTimePicker.TabIndex = 1
        '
        'ImpegnonumeroTextBox
        '
        Me.ImpegnonumeroTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bsPreventiviOperazioni, "impegnonumero", True))
        Me.ImpegnonumeroTextBox.Location = New System.Drawing.Point(319, 290)
        Me.ImpegnonumeroTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImpegnonumeroTextBox.Name = "ImpegnonumeroTextBox"
        Me.ImpegnonumeroTextBox.Size = New System.Drawing.Size(56, 23)
        Me.ImpegnonumeroTextBox.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.bsPreventiviOperazioni, "attivo", True))
        Me.CheckBox1.Location = New System.Drawing.Point(170, 211)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(45, 25)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsPreventiviOperazioni, "idcategoria", True))
        Me.ComboBox1.DataSource = Me.bsPreventiviCategorie
        Me.ComboBox1.DisplayMember = "descrizione"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(170, 239)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(216, 24)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.ValueMember = "id"
        '
        'bsPreventiviCategorie
        '
        Me.bsPreventiviCategorie.DataMember = "dtPreventiviCategorie"
        Me.bsPreventiviCategorie.DataSource = Me.DsPreventivi
        '
        'TaPreventiviCategorie
        '
        Me.TaPreventiviCategorie.ClearBeforeFill = True
        '
        'dgwOperazioni
        '
        Me.dgwOperazioni.AllowUserToAddRows = False
        Me.dgwOperazioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwOperazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwOperazioni.Location = New System.Drawing.Point(12, 12)
        Me.dgwOperazioni.Name = "dgwOperazioni"
        Me.dgwOperazioni.ReadOnly = True
        Me.dgwOperazioni.RowHeadersWidth = 21
        Me.dgwOperazioni.Size = New System.Drawing.Size(672, 108)
        Me.dgwOperazioni.TabIndex = 16
        '
        'DM_barra
        '
        Me.DM_barra.AddNewItem = Nothing
        Me.DM_barra.AutoSize = False
        Me.DM_barra.BindingSource = Me.bsPreventiviOperazioni
        Me.DM_barra.CountItem = Me.ToolStripLabel1
        Me.DM_barra.DeleteItem = Me.TTBTElimina
        Me.DM_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DM_barra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DM_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTestoRicerca, Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.TTBTAggiunge, Me.TTBTSalva, Me.TTBTElimina, Me.TTBTTermina, Me.BK_filtro, Me.ToolStripSeparator7})
        Me.DM_barra.Location = New System.Drawing.Point(0, 333)
        Me.DM_barra.MoveFirstItem = Me.ToolStripButton1
        Me.DM_barra.MoveLastItem = Me.ToolStripButton4
        Me.DM_barra.MoveNextItem = Me.ToolStripButton3
        Me.DM_barra.MovePreviousItem = Me.ToolStripButton2
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.PositionItem = Me.ToolStripTextBox1
        Me.DM_barra.Size = New System.Drawing.Size(695, 91)
        Me.DM_barra.TabIndex = 193
        Me.DM_barra.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 88)
        Me.ToolStripLabel1.Text = "di {0}"
        Me.ToolStripLabel1.ToolTipText = "Numero totale di elementi"
        '
        'TTBTElimina
        '
        Me.TTBTElimina.AutoSize = False
        Me.TTBTElimina.Image = Global.Pop2.Comuni.My.Resources.Resources.omino_cestino48
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
        Me.TTTestoRicerca.BackColor = System.Drawing.Color.LightCyan
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(116, 91)
        Me.TTTestoRicerca.ToolTipText = "Immettere l'anno di lavoro"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(45, 40)
        Me.ToolStripButton1.Text = "Inizio"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(45, 40)
        Me.ToolStripButton2.Text = "Indietro"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 91)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posizione"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(45, 33)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posizione corrente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 91)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(45, 40)
        Me.ToolStripButton3.Text = "Avanti"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(45, 40)
        Me.ToolStripButton4.Text = "Fine"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 91)
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
        Me.TTBTTermina.Image = Global.Pop2.Comuni.My.Resources.Resources.ominotermina48
        Me.TTBTTermina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTTermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTTermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTTermina.Name = "TTBTTermina"
        Me.TTBTTermina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTTermina.Text = "Termina"
        Me.TTBTTermina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTTermina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BK_filtro
        '
        Me.BK_filtro.AutoSize = False
        Me.BK_filtro.DoubleClickEnabled = True
        Me.BK_filtro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InScadenzaToolStripMenuItem, Me.BudgetToolStripMenuItem, Me.AttiviToolStripMenuItem, Me.TuttiToolStripMenuItem})
        Me.BK_filtro.Image = Global.Pop2.Comuni.My.Resources.Resources.omino_cerca48x48
        Me.BK_filtro.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BK_filtro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BK_filtro.Name = "BK_filtro"
        Me.BK_filtro.Size = New System.Drawing.Size(65, 88)
        Me.BK_filtro.Text = "Filtra"
        Me.BK_filtro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'InScadenzaToolStripMenuItem
        '
        Me.InScadenzaToolStripMenuItem.Name = "InScadenzaToolStripMenuItem"
        Me.InScadenzaToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.InScadenzaToolStripMenuItem.Text = "In Scadenza"
        '
        'BudgetToolStripMenuItem
        '
        Me.BudgetToolStripMenuItem.Name = "BudgetToolStripMenuItem"
        Me.BudgetToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.BudgetToolStripMenuItem.Text = "Budget"
        '
        'AttiviToolStripMenuItem
        '
        Me.AttiviToolStripMenuItem.Name = "AttiviToolStripMenuItem"
        Me.AttiviToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.AttiviToolStripMenuItem.Text = "Attivi"
        '
        'TuttiToolStripMenuItem
        '
        Me.TuttiToolStripMenuItem.Name = "TuttiToolStripMenuItem"
        Me.TuttiToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.TuttiToolStripMenuItem.Text = "Tutti"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(6, 91)
        '
        'FrmOperazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(695, 424)
        Me.Controls.Add(Me.DM_barra)
        Me.Controls.Add(Me.dgwOperazioni)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(ImpegnometroquadroLabel)
        Me.Controls.Add(Me.ImpegnometroquadroTextBox)
        Me.Controls.Add(DataLabel)
        Me.Controls.Add(Me.DataDateTimePicker)
        Me.Controls.Add(AttivoLabel)
        Me.Controls.Add(IdcategoriaLabel)
        Me.Controls.Add(ImpegnonumeroLabel)
        Me.Controls.Add(Me.ImpegnonumeroTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmOperazioni"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operazioni Capitolato"
        CType(Me.DsPreventivi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventiviOperazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventiviCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwOperazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DsPreventivi As dsPreventivi
    Friend WithEvents bsPreventiviOperazioni As BindingSource
    Friend WithEvents TaPreventiviOperazioni As dsPreventiviTableAdapters.taPreventiviOperazioni
    Friend WithEvents TableAdapterManager As dsPreventiviTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DescrizioneTextBox As TextBox
    Friend WithEvents ImpegnometroquadroTextBox As TextBox
    Friend WithEvents DataDateTimePicker As DateTimePicker
    Friend WithEvents ImpegnonumeroTextBox As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents bsPreventiviCategorie As BindingSource
    Friend WithEvents TaPreventiviCategorie As dsPreventiviTableAdapters.taPreventiviCategorie
    Friend WithEvents dgwOperazioni As DataGridView
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
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents BK_filtro As ToolStripDropDownButton
    Friend WithEvents InScadenzaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BudgetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttiviToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TuttiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
End Class
