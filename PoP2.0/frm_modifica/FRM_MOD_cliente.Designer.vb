<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_mod_cliente
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim ImeiLabel As System.Windows.Forms.Label
        Dim SocietaLabel As System.Windows.Forms.Label
        Dim AddressLabel As System.Windows.Forms.Label
        Dim PostalcodeLabel As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim RegionLabel As System.Windows.Forms.Label
        Dim StateLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim Email_nameLabel As System.Windows.Forms.Label
        Dim First_nameLabel As System.Windows.Forms.Label
        Dim PartitaivaLabel As System.Windows.Forms.Label
        Dim Work_phoneLabel As System.Windows.Forms.Label
        Dim Work_extensionLabel As System.Windows.Forms.Label
        Dim Home_phoneLabel As System.Windows.Forms.Label
        Dim Mobile_phoneLabel As System.Windows.Forms.Label
        Dim Fax_numberLabel As System.Windows.Forms.Label
        Dim BancaappogLabel As System.Windows.Forms.Label
        Dim Data_inizioLabel As System.Windows.Forms.Label
        Dim Data_termineLabel As System.Windows.Forms.Label
        Dim ContabilitaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_mod_cliente))
        Me.DS_clienti = New PoP2.Comuni.DS_clienti()
        Me.BS_clienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New PoP2.Comuni.DS_clientiTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ImeiTextBox = New System.Windows.Forms.TextBox()
        Me.SocietaTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.PostalcodeTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.RegionTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Email_nameTextBox = New System.Windows.Forms.TextBox()
        Me.First_nameTextBox = New System.Windows.Forms.TextBox()
        Me.PartitaivaTextBox = New System.Windows.Forms.TextBox()
        Me.Work_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Work_extensionTextBox = New System.Windows.Forms.TextBox()
        Me.Home_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Mobile_phoneTextBox = New System.Windows.Forms.TextBox()
        Me.Fax_numberTextBox = New System.Windows.Forms.TextBox()
        Me.BancaappogTextBox = New System.Windows.Forms.TextBox()
        Me.Data_inizioDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Data_termineDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ContabilitaTextBox = New System.Windows.Forms.TextBox()
        Me.AttivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.BudgetCheckBox = New System.Windows.Forms.CheckBox()
        Me.CondominoCheckBox = New System.Windows.Forms.CheckBox()
        Me.L_mobileCheckBox = New System.Windows.Forms.CheckBox()
        Me.DT_v_ordiniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTBTRicerca = New System.Windows.Forms.ToolStripButton()
        Me.TTBTAggiunge = New System.Windows.Forms.ToolStripButton()
        Me.TTBTModifica = New System.Windows.Forms.ToolStripButton()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TA_cantieri_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_cantieri_new()
        IdLabel = New System.Windows.Forms.Label()
        ImeiLabel = New System.Windows.Forms.Label()
        SocietaLabel = New System.Windows.Forms.Label()
        AddressLabel = New System.Windows.Forms.Label()
        PostalcodeLabel = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        RegionLabel = New System.Windows.Forms.Label()
        StateLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        Email_nameLabel = New System.Windows.Forms.Label()
        First_nameLabel = New System.Windows.Forms.Label()
        PartitaivaLabel = New System.Windows.Forms.Label()
        Work_phoneLabel = New System.Windows.Forms.Label()
        Work_extensionLabel = New System.Windows.Forms.Label()
        Home_phoneLabel = New System.Windows.Forms.Label()
        Mobile_phoneLabel = New System.Windows.Forms.Label()
        Fax_numberLabel = New System.Windows.Forms.Label()
        BancaappogLabel = New System.Windows.Forms.Label()
        Data_inizioLabel = New System.Windows.Forms.Label()
        Data_termineLabel = New System.Windows.Forms.Label()
        ContabilitaLabel = New System.Windows.Forms.Label()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_v_ordiniBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(27, 36)
        IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 16)
        IdLabel.TabIndex = 2
        IdLabel.Text = "id:"
        '
        'ImeiLabel
        '
        ImeiLabel.AutoSize = True
        ImeiLabel.Location = New System.Drawing.Point(268, 36)
        ImeiLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ImeiLabel.Name = "ImeiLabel"
        ImeiLabel.Size = New System.Drawing.Size(36, 16)
        ImeiLabel.TabIndex = 4
        ImeiLabel.Text = "imei:"
        '
        'SocietaLabel
        '
        SocietaLabel.AutoSize = True
        SocietaLabel.Location = New System.Drawing.Point(27, 68)
        SocietaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SocietaLabel.Name = "SocietaLabel"
        SocietaLabel.Size = New System.Drawing.Size(57, 16)
        SocietaLabel.TabIndex = 6
        SocietaLabel.Text = "Societa:"
        '
        'AddressLabel
        '
        AddressLabel.AutoSize = True
        AddressLabel.Location = New System.Drawing.Point(27, 98)
        AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AddressLabel.Name = "AddressLabel"
        AddressLabel.Size = New System.Drawing.Size(59, 16)
        AddressLabel.TabIndex = 8
        AddressLabel.Text = "Indirizzo:"
        '
        'PostalcodeLabel
        '
        PostalcodeLabel.AutoSize = True
        PostalcodeLabel.Location = New System.Drawing.Point(442, 98)
        PostalcodeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PostalcodeLabel.Name = "PostalcodeLabel"
        PostalcodeLabel.Size = New System.Drawing.Size(38, 16)
        PostalcodeLabel.TabIndex = 10
        PostalcodeLabel.Text = "CAP:"
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Location = New System.Drawing.Point(600, 99)
        CityLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(37, 16)
        CityLabel.TabIndex = 12
        CityLabel.Text = "Città:"
        '
        'RegionLabel
        '
        RegionLabel.AutoSize = True
        RegionLabel.Location = New System.Drawing.Point(930, 100)
        RegionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RegionLabel.Name = "RegionLabel"
        RegionLabel.Size = New System.Drawing.Size(30, 16)
        RegionLabel.TabIndex = 14
        RegionLabel.Text = "PR:"
        '
        'StateLabel
        '
        StateLabel.AutoSize = True
        StateLabel.Location = New System.Drawing.Point(27, 128)
        StateLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StateLabel.Name = "StateLabel"
        StateLabel.Size = New System.Drawing.Size(42, 16)
        StateLabel.TabIndex = 16
        StateLabel.Text = "Stato:"
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Location = New System.Drawing.Point(280, 129)
        TitleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(45, 16)
        TitleLabel.TabIndex = 18
        TitleLabel.Text = "Titolo:"
        '
        'Email_nameLabel
        '
        Email_nameLabel.AutoSize = True
        Email_nameLabel.Location = New System.Drawing.Point(27, 158)
        Email_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Email_nameLabel.Name = "Email_nameLabel"
        Email_nameLabel.Size = New System.Drawing.Size(44, 16)
        Email_nameLabel.TabIndex = 20
        Email_nameLabel.Text = "email:"
        '
        'First_nameLabel
        '
        First_nameLabel.AutoSize = True
        First_nameLabel.Location = New System.Drawing.Point(413, 129)
        First_nameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        First_nameLabel.Name = "First_nameLabel"
        First_nameLabel.Size = New System.Drawing.Size(96, 16)
        First_nameLabel.TabIndex = 22
        First_nameLabel.Text = "Responsabile:"
        '
        'PartitaivaLabel
        '
        PartitaivaLabel.AutoSize = True
        PartitaivaLabel.Location = New System.Drawing.Point(27, 188)
        PartitaivaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PartitaivaLabel.Name = "PartitaivaLabel"
        PartitaivaLabel.Size = New System.Drawing.Size(73, 16)
        PartitaivaLabel.TabIndex = 24
        PartitaivaLabel.Text = "Partita IVA:"
        '
        'Work_phoneLabel
        '
        Work_phoneLabel.AutoSize = True
        Work_phoneLabel.Location = New System.Drawing.Point(27, 218)
        Work_phoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Work_phoneLabel.Name = "Work_phoneLabel"
        Work_phoneLabel.Size = New System.Drawing.Size(98, 16)
        Work_phoneLabel.TabIndex = 26
        Work_phoneLabel.Text = "Telefono Fisso"
        '
        'Work_extensionLabel
        '
        Work_extensionLabel.AutoSize = True
        Work_extensionLabel.Location = New System.Drawing.Point(27, 250)
        Work_extensionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Work_extensionLabel.Name = "Work_extensionLabel"
        Work_extensionLabel.Size = New System.Drawing.Size(108, 16)
        Work_extensionLabel.TabIndex = 28
        Work_extensionLabel.Text = "Telefono Interno:"
        '
        'Home_phoneLabel
        '
        Home_phoneLabel.AutoSize = True
        Home_phoneLabel.Location = New System.Drawing.Point(453, 250)
        Home_phoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Home_phoneLabel.Name = "Home_phoneLabel"
        Home_phoneLabel.Size = New System.Drawing.Size(109, 16)
        Home_phoneLabel.TabIndex = 30
        Home_phoneLabel.Text = "Telefono Mobile:"
        '
        'Mobile_phoneLabel
        '
        Mobile_phoneLabel.AutoSize = True
        Mobile_phoneLabel.Location = New System.Drawing.Point(453, 188)
        Mobile_phoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Mobile_phoneLabel.Name = "Mobile_phoneLabel"
        Mobile_phoneLabel.Size = New System.Drawing.Size(98, 16)
        Mobile_phoneLabel.TabIndex = 32
        Mobile_phoneLabel.Text = "Codice Fiscale"
        '
        'Fax_numberLabel
        '
        Fax_numberLabel.AutoSize = True
        Fax_numberLabel.Location = New System.Drawing.Point(453, 219)
        Fax_numberLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Fax_numberLabel.Name = "Fax_numberLabel"
        Fax_numberLabel.Size = New System.Drawing.Size(33, 16)
        Fax_numberLabel.TabIndex = 34
        Fax_numberLabel.Text = "Fax:"
        '
        'BancaappogLabel
        '
        BancaappogLabel.AutoSize = True
        BancaappogLabel.Location = New System.Drawing.Point(27, 315)
        BancaappogLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BancaappogLabel.Name = "BancaappogLabel"
        BancaappogLabel.Size = New System.Drawing.Size(50, 16)
        BancaappogLabel.TabIndex = 38
        BancaappogLabel.Text = "Banca:"
        '
        'Data_inizioLabel
        '
        Data_inizioLabel.AutoSize = True
        Data_inizioLabel.Location = New System.Drawing.Point(27, 348)
        Data_inizioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Data_inizioLabel.Name = "Data_inizioLabel"
        Data_inizioLabel.Size = New System.Drawing.Size(71, 16)
        Data_inizioLabel.TabIndex = 40
        Data_inizioLabel.Text = "data inizio:"
        '
        'Data_termineLabel
        '
        Data_termineLabel.AutoSize = True
        Data_termineLabel.Location = New System.Drawing.Point(453, 348)
        Data_termineLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Data_termineLabel.Name = "Data_termineLabel"
        Data_termineLabel.Size = New System.Drawing.Size(85, 16)
        Data_termineLabel.TabIndex = 42
        Data_termineLabel.Text = "data termine:"
        '
        'ContabilitaLabel
        '
        ContabilitaLabel.AutoSize = True
        ContabilitaLabel.Location = New System.Drawing.Point(27, 377)
        ContabilitaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ContabilitaLabel.Name = "ContabilitaLabel"
        ContabilitaLabel.Size = New System.Drawing.Size(128, 16)
        ContabilitaLabel.TabIndex = 44
        ContabilitaLabel.Text = "Referente contabile:"
        '
        'DS_clienti
        '
        Me.DS_clienti.DataSetName = "DS_clienti"
        Me.DS_clienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_clienti
        '
        Me.BS_clienti.DataMember = "DT_cantieri_new"
        Me.BS_clienti.DataSource = Me.DS_clienti
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_clientiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(161, 32)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(63, 22)
        Me.IdTextBox.TabIndex = 1
        '
        'ImeiTextBox
        '
        Me.ImeiTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "imei", True))
        Me.ImeiTextBox.Location = New System.Drawing.Point(387, 32)
        Me.ImeiTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ImeiTextBox.Name = "ImeiTextBox"
        Me.ImeiTextBox.Size = New System.Drawing.Size(117, 22)
        Me.ImeiTextBox.TabIndex = 2
        '
        'SocietaTextBox
        '
        Me.SocietaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "societa", True))
        Me.SocietaTextBox.Location = New System.Drawing.Point(161, 64)
        Me.SocietaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.SocietaTextBox.Name = "SocietaTextBox"
        Me.SocietaTextBox.Size = New System.Drawing.Size(265, 22)
        Me.SocietaTextBox.TabIndex = 3
        '
        'AddressTextBox
        '
        Me.AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "address", True))
        Me.AddressTextBox.Location = New System.Drawing.Point(161, 94)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(265, 22)
        Me.AddressTextBox.TabIndex = 4
        '
        'PostalcodeTextBox
        '
        Me.PostalcodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "postalcode", True))
        Me.PostalcodeTextBox.Location = New System.Drawing.Point(488, 94)
        Me.PostalcodeTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PostalcodeTextBox.Name = "PostalcodeTextBox"
        Me.PostalcodeTextBox.Size = New System.Drawing.Size(92, 22)
        Me.PostalcodeTextBox.TabIndex = 5
        '
        'CityTextBox
        '
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "city", True))
        Me.CityTextBox.Location = New System.Drawing.Point(645, 96)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(265, 22)
        Me.CityTextBox.TabIndex = 6
        '
        'RegionTextBox
        '
        Me.RegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "region", True))
        Me.RegionTextBox.Location = New System.Drawing.Point(989, 96)
        Me.RegionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.RegionTextBox.Name = "RegionTextBox"
        Me.RegionTextBox.Size = New System.Drawing.Size(49, 22)
        Me.RegionTextBox.TabIndex = 7
        '
        'StateTextBox
        '
        Me.StateTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "state", True))
        Me.StateTextBox.Location = New System.Drawing.Point(161, 124)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(105, 22)
        Me.StateTextBox.TabIndex = 8
        '
        'TitleTextBox
        '
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "title", True))
        Me.TitleTextBox.Location = New System.Drawing.Point(330, 126)
        Me.TitleTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(71, 22)
        Me.TitleTextBox.TabIndex = 9
        '
        'Email_nameTextBox
        '
        Me.Email_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "email_name", True))
        Me.Email_nameTextBox.Location = New System.Drawing.Point(161, 154)
        Me.Email_nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Email_nameTextBox.Name = "Email_nameTextBox"
        Me.Email_nameTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Email_nameTextBox.TabIndex = 11
        '
        'First_nameTextBox
        '
        Me.First_nameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "first_name", True))
        Me.First_nameTextBox.Location = New System.Drawing.Point(521, 125)
        Me.First_nameTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.First_nameTextBox.Name = "First_nameTextBox"
        Me.First_nameTextBox.Size = New System.Drawing.Size(265, 22)
        Me.First_nameTextBox.TabIndex = 10
        '
        'PartitaivaTextBox
        '
        Me.PartitaivaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "partitaiva", True))
        Me.PartitaivaTextBox.Location = New System.Drawing.Point(161, 184)
        Me.PartitaivaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PartitaivaTextBox.Name = "PartitaivaTextBox"
        Me.PartitaivaTextBox.Size = New System.Drawing.Size(265, 22)
        Me.PartitaivaTextBox.TabIndex = 12
        '
        'Work_phoneTextBox
        '
        Me.Work_phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "work_phone", True))
        Me.Work_phoneTextBox.Location = New System.Drawing.Point(161, 214)
        Me.Work_phoneTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Work_phoneTextBox.Name = "Work_phoneTextBox"
        Me.Work_phoneTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Work_phoneTextBox.TabIndex = 14
        '
        'Work_extensionTextBox
        '
        Me.Work_extensionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "work_extension", True))
        Me.Work_extensionTextBox.Location = New System.Drawing.Point(161, 246)
        Me.Work_extensionTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Work_extensionTextBox.Name = "Work_extensionTextBox"
        Me.Work_extensionTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Work_extensionTextBox.TabIndex = 16
        '
        'Home_phoneTextBox
        '
        Me.Home_phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "home_phone", True))
        Me.Home_phoneTextBox.Location = New System.Drawing.Point(571, 246)
        Me.Home_phoneTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Home_phoneTextBox.Name = "Home_phoneTextBox"
        Me.Home_phoneTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Home_phoneTextBox.TabIndex = 17
        '
        'Mobile_phoneTextBox
        '
        Me.Mobile_phoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "mobile_phone", True))
        Me.Mobile_phoneTextBox.Location = New System.Drawing.Point(571, 184)
        Me.Mobile_phoneTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Mobile_phoneTextBox.Name = "Mobile_phoneTextBox"
        Me.Mobile_phoneTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Mobile_phoneTextBox.TabIndex = 13
        '
        'Fax_numberTextBox
        '
        Me.Fax_numberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "fax_number", True))
        Me.Fax_numberTextBox.Location = New System.Drawing.Point(571, 215)
        Me.Fax_numberTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Fax_numberTextBox.Name = "Fax_numberTextBox"
        Me.Fax_numberTextBox.Size = New System.Drawing.Size(265, 22)
        Me.Fax_numberTextBox.TabIndex = 15
        '
        'BancaappogTextBox
        '
        Me.BancaappogTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "bancaappog", True))
        Me.BancaappogTextBox.Location = New System.Drawing.Point(161, 311)
        Me.BancaappogTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.BancaappogTextBox.Name = "BancaappogTextBox"
        Me.BancaappogTextBox.Size = New System.Drawing.Size(733, 22)
        Me.BancaappogTextBox.TabIndex = 19
        '
        'Data_inizioDateTimePicker
        '
        Me.Data_inizioDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_clienti, "data_inizio", True))
        Me.Data_inizioDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Data_inizioDateTimePicker.Location = New System.Drawing.Point(161, 343)
        Me.Data_inizioDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.Data_inizioDateTimePicker.Name = "Data_inizioDateTimePicker"
        Me.Data_inizioDateTimePicker.Size = New System.Drawing.Size(104, 22)
        Me.Data_inizioDateTimePicker.TabIndex = 20
        '
        'Data_termineDateTimePicker
        '
        Me.Data_termineDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_clienti, "data_termine", True))
        Me.Data_termineDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Data_termineDateTimePicker.Location = New System.Drawing.Point(571, 343)
        Me.Data_termineDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.Data_termineDateTimePicker.Name = "Data_termineDateTimePicker"
        Me.Data_termineDateTimePicker.Size = New System.Drawing.Size(104, 22)
        Me.Data_termineDateTimePicker.TabIndex = 21
        '
        'ContabilitaTextBox
        '
        Me.ContabilitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_clienti, "contabilita", True))
        Me.ContabilitaTextBox.Location = New System.Drawing.Point(161, 373)
        Me.ContabilitaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ContabilitaTextBox.Name = "ContabilitaTextBox"
        Me.ContabilitaTextBox.Size = New System.Drawing.Size(265, 22)
        Me.ContabilitaTextBox.TabIndex = 22
        '
        'AttivoCheckBox
        '
        Me.AttivoCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.AttivoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_clienti, "attivo", True))
        Me.AttivoCheckBox.Location = New System.Drawing.Point(161, 404)
        Me.AttivoCheckBox.Name = "AttivoCheckBox"
        Me.AttivoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AttivoCheckBox.TabIndex = 23
        Me.AttivoCheckBox.Text = "ATTIVO"
        Me.AttivoCheckBox.UseVisualStyleBackColor = True
        '
        'BudgetCheckBox
        '
        Me.BudgetCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.BudgetCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_clienti, "budget", True))
        Me.BudgetCheckBox.Location = New System.Drawing.Point(348, 404)
        Me.BudgetCheckBox.Name = "BudgetCheckBox"
        Me.BudgetCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.BudgetCheckBox.TabIndex = 24
        Me.BudgetCheckBox.Text = "BUDGET"
        Me.BudgetCheckBox.UseVisualStyleBackColor = True
        '
        'CondominoCheckBox
        '
        Me.CondominoCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.CondominoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_clienti, "condomino", True))
        Me.CondominoCheckBox.Location = New System.Drawing.Point(562, 404)
        Me.CondominoCheckBox.Name = "CondominoCheckBox"
        Me.CondominoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.CondominoCheckBox.TabIndex = 25
        Me.CondominoCheckBox.Text = "CONDOMINIO"
        Me.CondominoCheckBox.UseVisualStyleBackColor = True
        '
        'L_mobileCheckBox
        '
        Me.L_mobileCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.L_mobileCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_clienti, "l_mobile", True))
        Me.L_mobileCheckBox.Location = New System.Drawing.Point(732, 404)
        Me.L_mobileCheckBox.Name = "L_mobileCheckBox"
        Me.L_mobileCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.L_mobileCheckBox.TabIndex = 26
        Me.L_mobileCheckBox.Text = "P.IVA / CF"
        Me.L_mobileCheckBox.UseVisualStyleBackColor = True
        '
        'DT_v_ordiniBindingNavigator
        '
        Me.DT_v_ordiniBindingNavigator.AddNewItem = Nothing
        Me.DT_v_ordiniBindingNavigator.AutoSize = False
        Me.DT_v_ordiniBindingNavigator.CountItem = Nothing
        Me.DT_v_ordiniBindingNavigator.DeleteItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_v_ordiniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicerca, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTTermina, Me.TTBTannulla, Me.TTBTSalva})
        Me.DT_v_ordiniBindingNavigator.Location = New System.Drawing.Point(0, 451)
        Me.DT_v_ordiniBindingNavigator.MoveFirstItem = Nothing
        Me.DT_v_ordiniBindingNavigator.MoveLastItem = Nothing
        Me.DT_v_ordiniBindingNavigator.MoveNextItem = Nothing
        Me.DT_v_ordiniBindingNavigator.MovePreviousItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Name = "DT_v_ordiniBindingNavigator"
        Me.DT_v_ordiniBindingNavigator.PositionItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Size = New System.Drawing.Size(1067, 79)
        Me.DT_v_ordiniBindingNavigator.TabIndex = 151
        Me.DT_v_ordiniBindingNavigator.Text = "BindingNavigator1"
        '
        'TTBTRicerca
        '
        Me.TTBTRicerca.AutoSize = False
        Me.TTBTRicerca.Image = Global.PoP2.Comuni.My.Resources.Resources.Omino_ricarica48
        Me.TTBTRicerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTRicerca.Name = "TTBTRicerca"
        Me.TTBTRicerca.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicerca.Text = "Ricarica"
        Me.TTBTRicerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicerca.ToolTipText = "Seleziona l'Anno"
        Me.TTBTRicerca.Visible = False
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
        Me.TTBTAggiunge.Visible = False
        '
        'TTBTModifica
        '
        Me.TTBTModifica.AutoSize = False
        Me.TTBTModifica.Image = Global.PoP2.Comuni.My.Resources.Resources.modifica
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
        Me.TTBTElimina.Visible = False
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
        'TTBTannulla
        '
        Me.TTBTannulla.AutoSize = False
        Me.TTBTannulla.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TTBTannulla.Image = Global.PoP2.Comuni.My.Resources.Resources.ricicla48
        Me.TTBTannulla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTannulla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTannulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTannulla.Name = "TTBTannulla"
        Me.TTBTannulla.Size = New System.Drawing.Size(150, 75)
        Me.TTBTannulla.Text = "Annulla"
        Me.TTBTannulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTannulla.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.TTBTannulla.Visible = False
        '
        'TTBTSalva
        '
        Me.TTBTSalva.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
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
        'TA_cantieri_new
        '
        Me.TA_cantieri_new.ClearBeforeFill = True
        '
        'FRM_mod_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 530)
        Me.Controls.Add(Me.DT_v_ordiniBindingNavigator)
        Me.Controls.Add(Me.L_mobileCheckBox)
        Me.Controls.Add(Me.CondominoCheckBox)
        Me.Controls.Add(Me.BudgetCheckBox)
        Me.Controls.Add(Me.AttivoCheckBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(ImeiLabel)
        Me.Controls.Add(Me.ImeiTextBox)
        Me.Controls.Add(SocietaLabel)
        Me.Controls.Add(Me.SocietaTextBox)
        Me.Controls.Add(AddressLabel)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(PostalcodeLabel)
        Me.Controls.Add(Me.PostalcodeTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(RegionLabel)
        Me.Controls.Add(Me.RegionTextBox)
        Me.Controls.Add(StateLabel)
        Me.Controls.Add(Me.StateTextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(Email_nameLabel)
        Me.Controls.Add(Me.Email_nameTextBox)
        Me.Controls.Add(First_nameLabel)
        Me.Controls.Add(Me.First_nameTextBox)
        Me.Controls.Add(PartitaivaLabel)
        Me.Controls.Add(Me.PartitaivaTextBox)
        Me.Controls.Add(Work_phoneLabel)
        Me.Controls.Add(Me.Work_phoneTextBox)
        Me.Controls.Add(Work_extensionLabel)
        Me.Controls.Add(Me.Work_extensionTextBox)
        Me.Controls.Add(Home_phoneLabel)
        Me.Controls.Add(Me.Home_phoneTextBox)
        Me.Controls.Add(Mobile_phoneLabel)
        Me.Controls.Add(Me.Mobile_phoneTextBox)
        Me.Controls.Add(Fax_numberLabel)
        Me.Controls.Add(Me.Fax_numberTextBox)
        Me.Controls.Add(BancaappogLabel)
        Me.Controls.Add(Me.BancaappogTextBox)
        Me.Controls.Add(Data_inizioLabel)
        Me.Controls.Add(Me.Data_inizioDateTimePicker)
        Me.Controls.Add(Data_termineLabel)
        Me.Controls.Add(Me.Data_termineDateTimePicker)
        Me.Controls.Add(ContabilitaLabel)
        Me.Controls.Add(Me.ContabilitaTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRM_mod_cliente"
        Me.Text = "Modifica Clienti"
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_v_ordiniBindingNavigator.ResumeLayout(False)
        Me.DT_v_ordiniBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_clienti As DS_clienti
    Friend WithEvents BS_clienti As BindingSource
    Friend WithEvents TableAdapterManager As DS_clientiTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ImeiTextBox As TextBox
    Friend WithEvents SocietaTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents PostalcodeTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents RegionTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents Email_nameTextBox As TextBox
    Friend WithEvents First_nameTextBox As TextBox
    Friend WithEvents PartitaivaTextBox As TextBox
    Friend WithEvents Work_phoneTextBox As TextBox
    Friend WithEvents Work_extensionTextBox As TextBox
    Friend WithEvents Home_phoneTextBox As TextBox
    Friend WithEvents Mobile_phoneTextBox As TextBox
    Friend WithEvents Fax_numberTextBox As TextBox
    Friend WithEvents BancaappogTextBox As TextBox
    Friend WithEvents Data_inizioDateTimePicker As DateTimePicker
    Friend WithEvents Data_termineDateTimePicker As DateTimePicker
    Friend WithEvents ContabilitaTextBox As TextBox
    Friend WithEvents AttivoCheckBox As CheckBox
    Friend WithEvents BudgetCheckBox As CheckBox
    Friend WithEvents CondominoCheckBox As CheckBox
    Friend WithEvents L_mobileCheckBox As CheckBox
    Friend WithEvents DT_v_ordiniBindingNavigator As BindingNavigator
    Friend WithEvents TTBTRicerca As ToolStripButton
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents TTBTModifica As ToolStripButton
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTannulla As ToolStripButton
    Friend WithEvents TA_cantieri_new As DS_clientiTableAdapters.TA_cantieri_new
End Class
