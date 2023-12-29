<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_MOD_dipendenti
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
        Dim CognomeLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim CfLabel As System.Windows.Forms.Label
        Dim IndirizzoLabel As System.Windows.Forms.Label
        Dim CittaLabel As System.Windows.Forms.Label
        Dim CapLabel As System.Windows.Forms.Label
        Dim NazioneLabel As System.Windows.Forms.Label
        Dim ProvinciaLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim CellulareLabel As System.Windows.Forms.Label
        Dim EmailnameLabel As System.Windows.Forms.Label
        Dim DatanascitaLabel As System.Windows.Forms.Label
        Dim LuogonascitaLabel As System.Windows.Forms.Label
        Dim ProvnascitaLabel As System.Windows.Forms.Label
        Dim NazionalitaLabel As System.Windows.Forms.Label
        Dim DataassLabel As System.Windows.Forms.Label
        Dim DatalicLabel As System.Windows.Forms.Label
        Dim Dat_licLabel As System.Windows.Forms.Label
        Dim LivelloLabel As System.Windows.Forms.Label
        Dim OreLabel As System.Windows.Forms.Label
        Dim NumeropiediLabel As System.Windows.Forms.Label
        Dim TagliadivisaLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MOD_dipendenti))
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.bs_Utenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.CognomeTextBox = New System.Windows.Forms.TextBox()
        Me.CB_livelli = New System.Windows.Forms.ComboBox()
        Me.BS_livelli = New System.Windows.Forms.BindingSource(Me.components)
        Me.TagliadivisaComboBox = New System.Windows.Forms.ComboBox()
        Me.NumeropiediComboBox = New System.Windows.Forms.ComboBox()
        Me.Dat_licDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DatalicDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.DataassDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailnameTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.CellulareTextBox = New System.Windows.Forms.TextBox()
        Me.NazioneTextBox = New System.Windows.Forms.TextBox()
        Me.CapTextBox = New System.Windows.Forms.TextBox()
        Me.CittaTextBox = New System.Windows.Forms.TextBox()
        Me.ProvinciaTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.CfTextBox = New System.Windows.Forms.TextBox()
        Me.StatoCheckBox = New System.Windows.Forms.CheckBox()
        Me.IndirizzoTextBox = New System.Windows.Forms.TextBox()
        Me.DatanascitaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.LuogonascitaTextBox = New System.Windows.Forms.TextBox()
        Me.OreTextBox = New System.Windows.Forms.TextBox()
        Me.InterinaleCheckBox = New System.Windows.Forms.CheckBox()
        Me.LicenzioCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProvnascitaTextBox = New System.Windows.Forms.TextBox()
        Me.NazionalitaTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BS_foto = New System.Windows.Forms.BindingSource(Me.components)
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DT_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ttProgressbar = New System.Windows.Forms.ToolStripProgressBar()
        Me.MNU_foto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MNU_aggiungifoto = New System.Windows.Forms.ToolStripMenuItem()
        Me.MNU_eliminafoto = New System.Windows.Forms.ToolStripMenuItem()
        Me.TA_livelli = New PoP2.Comuni.DS_utentiTableAdapters.TA_livelli()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TA_utentiFoto = New PoP2.Comuni.DS_utentiTableAdapters.TA_utentiFoto()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TA_utenti = New PoP2.Comuni.DS_utentiTableAdapters.TA_utenti()
        Me.TableAdapterManager = New PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager()
        CognomeLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        CfLabel = New System.Windows.Forms.Label()
        IndirizzoLabel = New System.Windows.Forms.Label()
        CittaLabel = New System.Windows.Forms.Label()
        CapLabel = New System.Windows.Forms.Label()
        NazioneLabel = New System.Windows.Forms.Label()
        ProvinciaLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        CellulareLabel = New System.Windows.Forms.Label()
        EmailnameLabel = New System.Windows.Forms.Label()
        DatanascitaLabel = New System.Windows.Forms.Label()
        LuogonascitaLabel = New System.Windows.Forms.Label()
        ProvnascitaLabel = New System.Windows.Forms.Label()
        NazionalitaLabel = New System.Windows.Forms.Label()
        DataassLabel = New System.Windows.Forms.Label()
        DatalicLabel = New System.Windows.Forms.Label()
        Dat_licLabel = New System.Windows.Forms.Label()
        LivelloLabel = New System.Windows.Forms.Label()
        OreLabel = New System.Windows.Forms.Label()
        NumeropiediLabel = New System.Windows.Forms.Label()
        TagliadivisaLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.bs_Utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_livelli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_barra.SuspendLayout()
        Me.MNU_foto.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'CognomeLabel
        '
        CognomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CognomeLabel.AutoSize = True
        CognomeLabel.Location = New System.Drawing.Point(4, 56)
        CognomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CognomeLabel.Name = "CognomeLabel"
        CognomeLabel.Size = New System.Drawing.Size(81, 21)
        CognomeLabel.TabIndex = 2
        CognomeLabel.Text = "Cognome:"
        CognomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NomeLabel
        '
        NomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        NomeLabel.AutoSize = True
        NomeLabel.Location = New System.Drawing.Point(314, 56)
        NomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(56, 21)
        NomeLabel.TabIndex = 3
        NomeLabel.Text = "Nome:"
        NomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CfLabel
        '
        CfLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CfLabel.AutoSize = True
        CfLabel.Location = New System.Drawing.Point(577, 56)
        CfLabel.Name = "CfLabel"
        CfLabel.Size = New System.Drawing.Size(110, 21)
        CfLabel.TabIndex = 4
        CfLabel.Text = "Codice Fiscale:"
        CfLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'IndirizzoLabel
        '
        IndirizzoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        IndirizzoLabel.AutoSize = True
        IndirizzoLabel.Location = New System.Drawing.Point(3, 116)
        IndirizzoLabel.Name = "IndirizzoLabel"
        IndirizzoLabel.Size = New System.Drawing.Size(72, 21)
        IndirizzoLabel.TabIndex = 6
        IndirizzoLabel.Text = "Indirizzo:"
        '
        'CittaLabel
        '
        CittaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CittaLabel.AutoSize = True
        CittaLabel.Location = New System.Drawing.Point(577, 116)
        CittaLabel.Name = "CittaLabel"
        CittaLabel.Size = New System.Drawing.Size(42, 21)
        CittaLabel.TabIndex = 8
        CittaLabel.Text = "citta:"
        '
        'CapLabel
        '
        CapLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CapLabel.AutoSize = True
        CapLabel.Location = New System.Drawing.Point(793, 116)
        CapLabel.Name = "CapLabel"
        CapLabel.Size = New System.Drawing.Size(37, 21)
        CapLabel.TabIndex = 0
        CapLabel.Text = "cap:"
        '
        'NazioneLabel
        '
        NazioneLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        NazioneLabel.AutoSize = True
        NazioneLabel.Location = New System.Drawing.Point(3, 172)
        NazioneLabel.Name = "NazioneLabel"
        NazioneLabel.Size = New System.Drawing.Size(67, 21)
        NazioneLabel.TabIndex = 0
        NazioneLabel.Text = "nazione:"
        '
        'ProvinciaLabel
        '
        ProvinciaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ProvinciaLabel.AutoSize = True
        ProvinciaLabel.Location = New System.Drawing.Point(313, 116)
        ProvinciaLabel.Name = "ProvinciaLabel"
        ProvinciaLabel.Size = New System.Drawing.Size(77, 21)
        ProvinciaLabel.TabIndex = 0
        ProvinciaLabel.Text = "provincia:"
        '
        'TelefonoLabel
        '
        TelefonoLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(577, 172)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(31, 21)
        TelefonoLabel.TabIndex = 0
        TelefonoLabel.Text = "Tel:"
        '
        'CellulareLabel
        '
        CellulareLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        CellulareLabel.AutoSize = True
        CellulareLabel.Location = New System.Drawing.Point(313, 172)
        CellulareLabel.Name = "CellulareLabel"
        CellulareLabel.Size = New System.Drawing.Size(45, 21)
        CellulareLabel.TabIndex = 0
        CellulareLabel.Text = "Mob:"
        '
        'EmailnameLabel
        '
        EmailnameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        EmailnameLabel.AutoSize = True
        EmailnameLabel.Location = New System.Drawing.Point(793, 172)
        EmailnameLabel.Name = "EmailnameLabel"
        EmailnameLabel.Size = New System.Drawing.Size(51, 21)
        EmailnameLabel.TabIndex = 0
        EmailnameLabel.Text = "Email:"
        '
        'DatanascitaLabel
        '
        DatanascitaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        DatanascitaLabel.AutoSize = True
        DatanascitaLabel.Location = New System.Drawing.Point(3, 228)
        DatanascitaLabel.Name = "DatanascitaLabel"
        DatanascitaLabel.Size = New System.Drawing.Size(91, 21)
        DatanascitaLabel.TabIndex = 0
        DatanascitaLabel.Text = "datanascita:"
        '
        'LuogonascitaLabel
        '
        LuogonascitaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        LuogonascitaLabel.AutoSize = True
        LuogonascitaLabel.Location = New System.Drawing.Point(313, 228)
        LuogonascitaLabel.Name = "LuogonascitaLabel"
        LuogonascitaLabel.Size = New System.Drawing.Size(101, 21)
        LuogonascitaLabel.TabIndex = 0
        LuogonascitaLabel.Text = "luogonascita:"
        '
        'ProvnascitaLabel
        '
        ProvnascitaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        ProvnascitaLabel.AutoSize = True
        ProvnascitaLabel.Location = New System.Drawing.Point(793, 228)
        ProvnascitaLabel.Name = "ProvnascitaLabel"
        ProvnascitaLabel.Size = New System.Drawing.Size(77, 21)
        ProvnascitaLabel.TabIndex = 0
        ProvnascitaLabel.Text = "Provincia:"
        '
        'NazionalitaLabel
        '
        NazionalitaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        NazionalitaLabel.AutoSize = True
        NazionalitaLabel.Location = New System.Drawing.Point(577, 228)
        NazionalitaLabel.Name = "NazionalitaLabel"
        NazionalitaLabel.Size = New System.Drawing.Size(91, 21)
        NazionalitaLabel.TabIndex = 0
        NazionalitaLabel.Text = "Nazionalita:"
        '
        'DataassLabel
        '
        DataassLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DataassLabel.AutoSize = True
        DataassLabel.Location = New System.Drawing.Point(3, 297)
        DataassLabel.Name = "DataassLabel"
        DataassLabel.Size = New System.Drawing.Size(73, 21)
        DataassLabel.TabIndex = 0
        DataassLabel.Text = "Data Ass:"
        DataassLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DatalicLabel
        '
        DatalicLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        DatalicLabel.AutoSize = True
        DatalicLabel.Location = New System.Drawing.Point(313, 297)
        DatalicLabel.Name = "DatalicLabel"
        DatalicLabel.Size = New System.Drawing.Size(82, 21)
        DatalicLabel.TabIndex = 0
        DatalicLabel.Text = "Data Scad:"
        DatalicLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Dat_licLabel
        '
        Dat_licLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Dat_licLabel.AutoSize = True
        Dat_licLabel.Location = New System.Drawing.Point(577, 297)
        Dat_licLabel.Name = "Dat_licLabel"
        Dat_licLabel.Size = New System.Drawing.Size(68, 21)
        Dat_licLabel.TabIndex = 0
        Dat_licLabel.Text = "Data Lic:"
        '
        'LivelloLabel
        '
        LivelloLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        LivelloLabel.AutoSize = True
        LivelloLabel.Location = New System.Drawing.Point(3, 355)
        LivelloLabel.Name = "LivelloLabel"
        LivelloLabel.Size = New System.Drawing.Size(141, 21)
        LivelloLabel.TabIndex = 25
        LivelloLabel.Text = "Livello Assunzione:"
        '
        'OreLabel
        '
        OreLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        OreLabel.AutoSize = True
        OreLabel.Location = New System.Drawing.Point(313, 355)
        OreLabel.Name = "OreLabel"
        OreLabel.Size = New System.Drawing.Size(36, 21)
        OreLabel.TabIndex = 27
        OreLabel.Text = "ore:"
        '
        'NumeropiediLabel
        '
        NumeropiediLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        NumeropiediLabel.AutoSize = True
        NumeropiediLabel.Location = New System.Drawing.Point(577, 355)
        NumeropiediLabel.Name = "NumeropiediLabel"
        NumeropiediLabel.Size = New System.Drawing.Size(102, 21)
        NumeropiediLabel.TabIndex = 0
        NumeropiediLabel.Text = "numeropiedi:"
        '
        'TagliadivisaLabel
        '
        TagliadivisaLabel.Anchor = System.Windows.Forms.AnchorStyles.Left
        TagliadivisaLabel.AutoSize = True
        TagliadivisaLabel.Location = New System.Drawing.Point(793, 355)
        TagliadivisaLabel.Name = "TagliadivisaLabel"
        TagliadivisaLabel.Size = New System.Drawing.Size(96, 21)
        TagliadivisaLabel.TabIndex = 0
        TagliadivisaLabel.Text = "Taglia divisa:"
        '
        'NoteLabel
        '
        NoteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(3, 39)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(76, 21)
        NoteLabel.TabIndex = 0
        NoteLabel.Text = "note:"
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.7401!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.973!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.88732!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.39957!))
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox4, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CognomeTextBox, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.CB_livelli, 0, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.TagliadivisaComboBox, 3, 13)
        Me.TableLayoutPanel1.Controls.Add(TagliadivisaLabel, 3, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.NumeropiediComboBox, 2, 13)
        Me.TableLayoutPanel1.Controls.Add(NumeropiediLabel, 2, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.Dat_licDateTimePicker, 2, 11)
        Me.TableLayoutPanel1.Controls.Add(Dat_licLabel, 2, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.DatalicDateTimePicker, 1, 11)
        Me.TableLayoutPanel1.Controls.Add(DatalicLabel, 1, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.DataassDateTimePicker, 0, 11)
        Me.TableLayoutPanel1.Controls.Add(DataassLabel, 0, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.EmailnameTextBox, 3, 7)
        Me.TableLayoutPanel1.Controls.Add(EmailnameLabel, 3, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TelefonoTextBox, 2, 7)
        Me.TableLayoutPanel1.Controls.Add(TelefonoLabel, 2, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.CellulareTextBox, 1, 7)
        Me.TableLayoutPanel1.Controls.Add(CellulareLabel, 1, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.NazioneTextBox, 0, 7)
        Me.TableLayoutPanel1.Controls.Add(Me.CapTextBox, 3, 5)
        Me.TableLayoutPanel1.Controls.Add(NazioneLabel, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(CapLabel, 3, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.CittaTextBox, 2, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.ProvinciaTextBox, 1, 5)
        Me.TableLayoutPanel1.Controls.Add(CittaLabel, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(ProvinciaLabel, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(CognomeLabel, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(NomeLabel, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.NomeTextBox, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(CfLabel, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.CfTextBox, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.StatoCheckBox, 3, 3)
        Me.TableLayoutPanel1.Controls.Add(IndirizzoLabel, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.IndirizzoTextBox, 0, 5)
        Me.TableLayoutPanel1.Controls.Add(DatanascitaLabel, 0, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.DatanascitaDateTimePicker, 0, 9)
        Me.TableLayoutPanel1.Controls.Add(LuogonascitaLabel, 1, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.LuogonascitaTextBox, 1, 9)
        Me.TableLayoutPanel1.Controls.Add(LivelloLabel, 0, 12)
        Me.TableLayoutPanel1.Controls.Add(OreLabel, 1, 12)
        Me.TableLayoutPanel1.Controls.Add(Me.OreTextBox, 1, 13)
        Me.TableLayoutPanel1.Controls.Add(Me.InterinaleCheckBox, 3, 10)
        Me.TableLayoutPanel1.Controls.Add(Me.LicenzioCheckBox, 3, 11)
        Me.TableLayoutPanel1.Controls.Add(ProvnascitaLabel, 3, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.ProvnascitaTextBox, 3, 9)
        Me.TableLayoutPanel1.Controls.Add(NazionalitaLabel, 2, 8)
        Me.TableLayoutPanel1.Controls.Add(Me.NazionalitaTextBox, 2, 9)
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox2, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox3, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TextBox1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 57)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 14
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(947, 416)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "user", True))
        Me.TextBox4.Location = New System.Drawing.Point(313, 24)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(211, 29)
        Me.TextBox4.TabIndex = 151
        '
        'bs_Utenti
        '
        Me.bs_Utenti.DataMember = "DT_utenti"
        Me.bs_Utenti.DataSource = Me.DS_utenti
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(313, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 21)
        Me.Label7.TabIndex = 152
        Me.Label7.Text = "User"
        '
        'CognomeTextBox
        '
        Me.CognomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "cognome", True))
        Me.CognomeTextBox.Location = New System.Drawing.Point(3, 80)
        Me.CognomeTextBox.Name = "CognomeTextBox"
        Me.CognomeTextBox.Size = New System.Drawing.Size(303, 29)
        Me.CognomeTextBox.TabIndex = 3
        '
        'CB_livelli
        '
        Me.CB_livelli.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bs_Utenti, "livello", True))
        Me.CB_livelli.DataSource = Me.BS_livelli
        Me.CB_livelli.DisplayMember = "descrizione"
        Me.CB_livelli.FormattingEnabled = True
        Me.CB_livelli.Location = New System.Drawing.Point(3, 379)
        Me.CB_livelli.Name = "CB_livelli"
        Me.CB_livelli.Size = New System.Drawing.Size(291, 29)
        Me.CB_livelli.TabIndex = 21
        Me.CB_livelli.ValueMember = "id"
        '
        'BS_livelli
        '
        Me.BS_livelli.DataMember = "DT_livelli"
        Me.BS_livelli.DataSource = Me.DS_utenti
        '
        'TagliadivisaComboBox
        '
        Me.TagliadivisaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "tagliadivisa", True))
        Me.TagliadivisaComboBox.FormattingEnabled = True
        Me.TagliadivisaComboBox.Items.AddRange(New Object() {"X SMALL", "SMALL", "MEDIUM", "LARGE", "X LARGE", "XX LARGE", "XXX LARGE"})
        Me.TagliadivisaComboBox.Location = New System.Drawing.Point(793, 379)
        Me.TagliadivisaComboBox.Name = "TagliadivisaComboBox"
        Me.TagliadivisaComboBox.Size = New System.Drawing.Size(91, 29)
        Me.TagliadivisaComboBox.TabIndex = 24
        '
        'NumeropiediComboBox
        '
        Me.NumeropiediComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "numeropiedi", True))
        Me.NumeropiediComboBox.FormattingEnabled = True
        Me.NumeropiediComboBox.Items.AddRange(New Object() {"36", "37", "38", "39", "40", "41", "42", "43", "44", "45"})
        Me.NumeropiediComboBox.Location = New System.Drawing.Point(577, 379)
        Me.NumeropiediComboBox.Name = "NumeropiediComboBox"
        Me.NumeropiediComboBox.Size = New System.Drawing.Size(91, 29)
        Me.NumeropiediComboBox.TabIndex = 23
        '
        'Dat_licDateTimePicker
        '
        Me.Dat_licDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Dat_licDateTimePicker.CustomFormat = "dd-MM-yyyy"
        Me.Dat_licDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "dat_lic", True))
        Me.Dat_licDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Dat_licDateTimePicker.Location = New System.Drawing.Point(577, 322)
        Me.Dat_licDateTimePicker.Name = "Dat_licDateTimePicker"
        Me.Dat_licDateTimePicker.Size = New System.Drawing.Size(111, 29)
        Me.Dat_licDateTimePicker.TabIndex = 20
        '
        'DatalicDateTimePicker
        '
        Me.DatalicDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DatalicDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "datalic", True))
        Me.DatalicDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatalicDateTimePicker.Location = New System.Drawing.Point(313, 322)
        Me.DatalicDateTimePicker.Name = "DatalicDateTimePicker"
        Me.DatalicDateTimePicker.Size = New System.Drawing.Size(111, 29)
        Me.DatalicDateTimePicker.TabIndex = 19
        '
        'DataassDateTimePicker
        '
        Me.DataassDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DataassDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "dataass", True))
        Me.DataassDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DataassDateTimePicker.Location = New System.Drawing.Point(3, 322)
        Me.DataassDateTimePicker.Name = "DataassDateTimePicker"
        Me.DataassDateTimePicker.Size = New System.Drawing.Size(111, 29)
        Me.DataassDateTimePicker.TabIndex = 18
        '
        'EmailnameTextBox
        '
        Me.EmailnameTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmailnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "emailname", True))
        Me.EmailnameTextBox.Location = New System.Drawing.Point(793, 196)
        Me.EmailnameTextBox.Name = "EmailnameTextBox"
        Me.EmailnameTextBox.Size = New System.Drawing.Size(151, 29)
        Me.EmailnameTextBox.TabIndex = 13
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(577, 196)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(210, 29)
        Me.TelefonoTextBox.TabIndex = 12
        '
        'CellulareTextBox
        '
        Me.CellulareTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CellulareTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "cellulare", True))
        Me.CellulareTextBox.Location = New System.Drawing.Point(313, 196)
        Me.CellulareTextBox.Name = "CellulareTextBox"
        Me.CellulareTextBox.Size = New System.Drawing.Size(258, 29)
        Me.CellulareTextBox.TabIndex = 11
        '
        'NazioneTextBox
        '
        Me.NazioneTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NazioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "nazione", True))
        Me.NazioneTextBox.Location = New System.Drawing.Point(3, 196)
        Me.NazioneTextBox.Name = "NazioneTextBox"
        Me.NazioneTextBox.Size = New System.Drawing.Size(304, 29)
        Me.NazioneTextBox.TabIndex = 10
        '
        'CapTextBox
        '
        Me.CapTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "cap", True))
        Me.CapTextBox.Location = New System.Drawing.Point(793, 140)
        Me.CapTextBox.Name = "CapTextBox"
        Me.CapTextBox.Size = New System.Drawing.Size(60, 29)
        Me.CapTextBox.TabIndex = 9
        '
        'CittaTextBox
        '
        Me.CittaTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CittaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "citta", True))
        Me.CittaTextBox.Location = New System.Drawing.Point(577, 140)
        Me.CittaTextBox.Name = "CittaTextBox"
        Me.CittaTextBox.Size = New System.Drawing.Size(210, 29)
        Me.CittaTextBox.TabIndex = 8
        '
        'ProvinciaTextBox
        '
        Me.ProvinciaTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ProvinciaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "provincia", True))
        Me.ProvinciaTextBox.Location = New System.Drawing.Point(313, 140)
        Me.ProvinciaTextBox.Name = "ProvinciaTextBox"
        Me.ProvinciaTextBox.Size = New System.Drawing.Size(40, 29)
        Me.ProvinciaTextBox.TabIndex = 7
        '
        'NomeTextBox
        '
        Me.NomeTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "nome", True))
        Me.NomeTextBox.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomeTextBox.Location = New System.Drawing.Point(314, 81)
        Me.NomeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(256, 29)
        Me.NomeTextBox.TabIndex = 4
        '
        'CfTextBox
        '
        Me.CfTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CfTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "cf", True))
        Me.CfTextBox.Location = New System.Drawing.Point(577, 82)
        Me.CfTextBox.Name = "CfTextBox"
        Me.CfTextBox.Size = New System.Drawing.Size(210, 29)
        Me.CfTextBox.TabIndex = 5
        '
        'StatoCheckBox
        '
        Me.StatoCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatoCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.StatoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bs_Utenti, "stato", True))
        Me.StatoCheckBox.Location = New System.Drawing.Point(793, 80)
        Me.StatoCheckBox.Name = "StatoCheckBox"
        Me.StatoCheckBox.Size = New System.Drawing.Size(100, 33)
        Me.StatoCheckBox.TabIndex = 4
        Me.StatoCheckBox.Text = "Attivo"
        Me.StatoCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.StatoCheckBox.UseVisualStyleBackColor = True
        '
        'IndirizzoTextBox
        '
        Me.IndirizzoTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.IndirizzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "indirizzo", True))
        Me.IndirizzoTextBox.Location = New System.Drawing.Point(3, 140)
        Me.IndirizzoTextBox.Name = "IndirizzoTextBox"
        Me.IndirizzoTextBox.Size = New System.Drawing.Size(304, 29)
        Me.IndirizzoTextBox.TabIndex = 6
        '
        'DatanascitaDateTimePicker
        '
        Me.DatanascitaDateTimePicker.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.DatanascitaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "datanascita", True))
        Me.DatanascitaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DatanascitaDateTimePicker.Location = New System.Drawing.Point(3, 252)
        Me.DatanascitaDateTimePicker.Name = "DatanascitaDateTimePicker"
        Me.DatanascitaDateTimePicker.Size = New System.Drawing.Size(111, 29)
        Me.DatanascitaDateTimePicker.TabIndex = 14
        '
        'LuogonascitaTextBox
        '
        Me.LuogonascitaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LuogonascitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "luogonascita", True))
        Me.LuogonascitaTextBox.Location = New System.Drawing.Point(313, 252)
        Me.LuogonascitaTextBox.Name = "LuogonascitaTextBox"
        Me.LuogonascitaTextBox.Size = New System.Drawing.Size(258, 29)
        Me.LuogonascitaTextBox.TabIndex = 15
        '
        'OreTextBox
        '
        Me.OreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "ore", True))
        Me.OreTextBox.Location = New System.Drawing.Point(313, 379)
        Me.OreTextBox.Name = "OreTextBox"
        Me.OreTextBox.Size = New System.Drawing.Size(91, 29)
        Me.OreTextBox.TabIndex = 22
        '
        'InterinaleCheckBox
        '
        Me.InterinaleCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.InterinaleCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.InterinaleCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bs_Utenti, "interinale", True))
        Me.InterinaleCheckBox.Location = New System.Drawing.Point(793, 287)
        Me.InterinaleCheckBox.Name = "InterinaleCheckBox"
        Me.InterinaleCheckBox.Size = New System.Drawing.Size(100, 28)
        Me.InterinaleCheckBox.TabIndex = 25
        Me.InterinaleCheckBox.Text = "Interinale"
        Me.InterinaleCheckBox.UseVisualStyleBackColor = True
        '
        'LicenzioCheckBox
        '
        Me.LicenzioCheckBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.LicenzioCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.LicenzioCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.bs_Utenti, "licenzio", True))
        Me.LicenzioCheckBox.Location = New System.Drawing.Point(793, 321)
        Me.LicenzioCheckBox.Name = "LicenzioCheckBox"
        Me.LicenzioCheckBox.Size = New System.Drawing.Size(100, 31)
        Me.LicenzioCheckBox.TabIndex = 26
        Me.LicenzioCheckBox.Text = "Licenzio"
        Me.LicenzioCheckBox.UseVisualStyleBackColor = True
        '
        'ProvnascitaTextBox
        '
        Me.ProvnascitaTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ProvnascitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "provnascita", True))
        Me.ProvnascitaTextBox.Location = New System.Drawing.Point(793, 252)
        Me.ProvnascitaTextBox.Name = "ProvnascitaTextBox"
        Me.ProvnascitaTextBox.Size = New System.Drawing.Size(40, 29)
        Me.ProvnascitaTextBox.TabIndex = 17
        '
        'NazionalitaTextBox
        '
        Me.NazionalitaTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NazionalitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "nazionalita", True))
        Me.NazionalitaTextBox.Location = New System.Drawing.Point(577, 252)
        Me.NazionalitaTextBox.Name = "NazionalitaTextBox"
        Me.NazionalitaTextBox.Size = New System.Drawing.Size(210, 29)
        Me.NazionalitaTextBox.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 21)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "COD QR"
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "id_qr", True))
        Me.TextBox2.Location = New System.Drawing.Point(3, 24)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 29)
        Me.TextBox2.TabIndex = 0
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "id_terminale", True))
        Me.TextBox3.Location = New System.Drawing.Point(793, 24)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 29)
        Me.TextBox3.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(793, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 21)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Livello"
        '
        'TextBox1
        '
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "pwd", True))
        Me.TextBox1.Location = New System.Drawing.Point(577, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 29)
        Me.TextBox1.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(577, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 21)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Password"
        '
        'BS_foto
        '
        Me.BS_foto.DataMember = "DT_utentiFoto"
        Me.BS_foto.DataSource = Me.DS_utenti
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.bs_Utenti, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(85, 12)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.NoteTextBox.Size = New System.Drawing.Size(861, 74)
        Me.NoteTextBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(197, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(753, 51)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Modifica / Inserimento Dipendente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DT_barra
        '
        Me.DT_barra.AddNewItem = Nothing
        Me.DT_barra.AutoSize = False
        Me.DT_barra.CountItem = Me.BindingNavigatorCountItem
        Me.DT_barra.DeleteItem = Nothing
        Me.DT_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTSalva, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTTermina, Me.ToolStripSeparator3, Me.TTBTStampa, Me.ttProgressbar})
        Me.DT_barra.Location = New System.Drawing.Point(0, 582)
        Me.DT_barra.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_barra.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_barra.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_barra.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_barra.Name = "DT_barra"
        Me.DT_barra.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_barra.Size = New System.Drawing.Size(955, 87)
        Me.DT_barra.TabIndex = 28
        Me.DT_barra.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 84)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        Me.BindingNavigatorCountItem.Visible = False
        '
        'TTBTSalva
        '
        Me.TTBTSalva.AutoSize = False
        Me.TTBTSalva.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTBTSalva.Image = CType(resources.GetObject("TTBTSalva.Image"), System.Drawing.Image)
        Me.TTBTSalva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTSalva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTSalva.Name = "TTBTSalva"
        Me.TTBTSalva.Size = New System.Drawing.Size(75, 75)
        Me.TTBTSalva.Text = "Ok"
        Me.TTBTSalva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTSalva.ToolTipText = "Conferma modifiche"
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
        Me.BindingNavigatorMoveFirstItem.Visible = False
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
        Me.BindingNavigatorMovePreviousItem.Visible = False
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 87)
        Me.BindingNavigatorSeparator.Visible = False
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 33)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        Me.BindingNavigatorPositionItem.Visible = False
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 87)
        Me.BindingNavigatorSeparator1.Visible = False
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
        Me.BindingNavigatorMoveNextItem.Visible = False
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
        Me.BindingNavigatorMoveLastItem.Visible = False
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 87)
        Me.BindingNavigatorSeparator2.Visible = False
        '
        'TTBTTermina
        '
        Me.TTBTTermina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TTBTTermina.AutoSize = False
        Me.TTBTTermina.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTBTTermina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.TTBTTermina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTTermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTTermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTTermina.Name = "TTBTTermina"
        Me.TTBTTermina.Size = New System.Drawing.Size(75, 75)
        Me.TTBTTermina.Text = "Termina"
        Me.TTBTTermina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTTermina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 87)
        Me.ToolStripSeparator3.Visible = False
        '
        'TTBTStampa
        '
        Me.TTBTStampa.AutoSize = False
        Me.TTBTStampa.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTBTStampa.Image = CType(resources.GetObject("TTBTStampa.Image"), System.Drawing.Image)
        Me.TTBTStampa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTStampa.Name = "TTBTStampa"
        Me.TTBTStampa.Size = New System.Drawing.Size(75, 75)
        Me.TTBTStampa.Text = "Stampa"
        Me.TTBTStampa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTStampa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTStampa.ToolTipText = "Stampa del tesserino di riconoscimento"
        '
        'ttProgressbar
        '
        Me.ttProgressbar.Name = "ttProgressbar"
        Me.ttProgressbar.Size = New System.Drawing.Size(200, 84)
        '
        'MNU_foto
        '
        Me.MNU_foto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MNU_aggiungifoto, Me.MNU_eliminafoto})
        Me.MNU_foto.Name = "MNU_aggiunta"
        Me.MNU_foto.Size = New System.Drawing.Size(127, 48)
        '
        'MNU_aggiungifoto
        '
        Me.MNU_aggiungifoto.Name = "MNU_aggiungifoto"
        Me.MNU_aggiungifoto.Size = New System.Drawing.Size(126, 22)
        Me.MNU_aggiungifoto.Text = "Aggiunge"
        '
        'MNU_eliminafoto
        '
        Me.MNU_eliminafoto.Name = "MNU_eliminafoto"
        Me.MNU_eliminafoto.Size = New System.Drawing.Size(126, 22)
        Me.MNU_eliminafoto.Text = "Elimina"
        '
        'TA_livelli
        '
        Me.TA_livelli.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(100, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 51)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TA_utentiFoto
        '
        Me.TA_utentiFoto.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 51)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "COD:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel1, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 3
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(955, 582)
        Me.TableLayoutPanel2.TabIndex = 150
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 97.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 759.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label2, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 2, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(953, 51)
        Me.TableLayoutPanel3.TabIndex = 5
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.690869!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.30913!))
        Me.TableLayoutPanel4.Controls.Add(NoteLabel, 0, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.NoteTextBox, 1, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 480)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(949, 99)
        Me.TableLayoutPanel4.TabIndex = 6
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FRM_MOD_dipendenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 669)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.DT_barra)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRM_MOD_dipendenti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Inserimento Dipendenti"
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.bs_Utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_livelli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_barra.ResumeLayout(False)
        Me.DT_barra.PerformLayout()
        Me.MNU_foto.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CfTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents IndirizzoTextBox As TextBox
    Friend WithEvents ProvinciaTextBox As TextBox
    Friend WithEvents CittaTextBox As TextBox
    Friend WithEvents CapTextBox As TextBox
    Friend WithEvents NazioneTextBox As TextBox
    Friend WithEvents TelefonoTextBox As TextBox
    Friend WithEvents CellulareTextBox As TextBox
    Friend WithEvents EmailnameTextBox As TextBox
    Friend WithEvents DatanascitaDateTimePicker As DateTimePicker
    Friend WithEvents LuogonascitaTextBox As TextBox
    Friend WithEvents ProvnascitaTextBox As TextBox
    Friend WithEvents NazionalitaTextBox As TextBox
    Friend WithEvents OreTextBox As TextBox
    Friend WithEvents DataassDateTimePicker As DateTimePicker
    Friend WithEvents DatalicDateTimePicker As DateTimePicker
    Friend WithEvents Dat_licDateTimePicker As DateTimePicker
    Friend WithEvents LicenzioCheckBox As CheckBox
    Friend WithEvents InterinaleCheckBox As CheckBox
    Friend WithEvents NumeropiediComboBox As ComboBox
    Friend WithEvents TagliadivisaComboBox As ComboBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DT_barra As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents StatoCheckBox As CheckBox
    Friend WithEvents CB_livelli As ComboBox
    Friend WithEvents MNU_foto As ContextMenuStrip
    Friend WithEvents MNU_aggiungifoto As ToolStripMenuItem
    Friend WithEvents MNU_eliminafoto As ToolStripMenuItem
    Friend WithEvents BS_livelli As BindingSource
    Friend WithEvents TA_livelli As DS_utentiTableAdapters.TA_livelli
    Friend WithEvents Label2 As Label
    Friend WithEvents BS_foto As BindingSource
    Friend WithEvents TA_utentiFoto As DS_utentiTableAdapters.TA_utentiFoto
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents bs_Utenti As BindingSource
    Friend WithEvents TA_utenti As DS_utentiTableAdapters.TA_utenti
    Friend WithEvents TableAdapterManager As DS_utentiTableAdapters.TableAdapterManager
    Friend WithEvents CognomeTextBox As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ttProgressbar As ToolStripProgressBar
End Class
