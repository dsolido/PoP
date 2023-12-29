<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDipendentePianodiLavoro
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
        Dim Lu_iLabel As System.Windows.Forms.Label
        Dim Ma_iLabel As System.Windows.Forms.Label
        Dim Me_iLabel As System.Windows.Forms.Label
        Dim Gi_iLabel As System.Windows.Forms.Label
        Dim Ve_iLabel As System.Windows.Forms.Label
        Dim Sa_iLabel As System.Windows.Forms.Label
        Dim Do_iLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDipendentePianodiLavoro))
        Me.LBdestinatari = New System.Windows.Forms.ListBox()
        Me.bsOrari = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.RELclientidestinatariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTclientiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTutentiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Lu_iTextBox = New System.Windows.Forms.TextBox()
        Me.Lu_uTextBox = New System.Windows.Forms.TextBox()
        Me.Ma_iTextBox = New System.Windows.Forms.TextBox()
        Me.Ma_uTextBox = New System.Windows.Forms.TextBox()
        Me.Me_iTextBox = New System.Windows.Forms.TextBox()
        Me.Me_uTextBox = New System.Windows.Forms.TextBox()
        Me.Gi_iTextBox = New System.Windows.Forms.TextBox()
        Me.Gi_uTextBox = New System.Windows.Forms.TextBox()
        Me.Ve_iTextBox = New System.Windows.Forms.TextBox()
        Me.Ve_uTextBox = New System.Windows.Forms.TextBox()
        Me.Sa_iTextBox = New System.Windows.Forms.TextBox()
        Me.Sa_uTextBox = New System.Windows.Forms.TextBox()
        Me.Do_iTextBox = New System.Windows.Forms.TextBox()
        Me.Do_uTextBox = New System.Windows.Forms.TextBox()
        Me.DT_BarraNavigazione = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTRicerca = New System.Windows.Forms.ToolStripButton()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
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
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTPB = New System.Windows.Forms.ToolStripProgressBar()
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        Me.TT_CB_anno = New System.Windows.Forms.ToolStripComboBox()
        Me.TT_CB_mese = New System.Windows.Forms.ToolStripComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BT_trisettimanale = New System.Windows.Forms.Button()
        Me.BT_giornaliero = New System.Windows.Forms.Button()
        Me.BT_vuota = New System.Windows.Forms.Button()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.QuindicinaleCheckBox = New System.Windows.Forms.CheckBox()
        Me.AttivoCheckBox = New System.Windows.Forms.CheckBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CB_utenti = New System.Windows.Forms.ComboBox()
        Me.TA_utenti1 = New PoP2.Comuni.DS_utentiTableAdapters.TA_utenti()
        Me.CB_clienti = New System.Windows.Forms.ComboBox()
        Me.TA_clienti1 = New PoP2.Comuni.DS_utentiTableAdapters.TA_clienti()
        Me.TA_destinatari = New PoP2.Comuni.DS_utentiTableAdapters.TA_destinatari()
        Lu_iLabel = New System.Windows.Forms.Label()
        Ma_iLabel = New System.Windows.Forms.Label()
        Me_iLabel = New System.Windows.Forms.Label()
        Gi_iLabel = New System.Windows.Forms.Label()
        Ve_iLabel = New System.Windows.Forms.Label()
        Sa_iLabel = New System.Windows.Forms.Label()
        Do_iLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        CType(Me.bsOrari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RELclientidestinatariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTclientiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTutentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_BarraNavigazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_BarraNavigazione.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lu_iLabel
        '
        Lu_iLabel.AutoSize = True
        Lu_iLabel.Location = New System.Drawing.Point(362, 43)
        Lu_iLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Lu_iLabel.Name = "Lu_iLabel"
        Lu_iLabel.Size = New System.Drawing.Size(51, 17)
        Lu_iLabel.TabIndex = 11
        Lu_iLabel.Text = "Lunedì"
        '
        'Ma_iLabel
        '
        Ma_iLabel.AutoSize = True
        Ma_iLabel.Location = New System.Drawing.Point(358, 75)
        Ma_iLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ma_iLabel.Name = "Ma_iLabel"
        Ma_iLabel.Size = New System.Drawing.Size(55, 17)
        Ma_iLabel.TabIndex = 15
        Ma_iLabel.Text = "Martedì"
        '
        'Me_iLabel
        '
        Me_iLabel.AutoSize = True
        Me_iLabel.Location = New System.Drawing.Point(344, 107)
        Me_iLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me_iLabel.Name = "Me_iLabel"
        Me_iLabel.Size = New System.Drawing.Size(69, 17)
        Me_iLabel.TabIndex = 19
        Me_iLabel.Text = "Mercoledì"
        '
        'Gi_iLabel
        '
        Gi_iLabel.AutoSize = True
        Gi_iLabel.Location = New System.Drawing.Point(357, 139)
        Gi_iLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Gi_iLabel.Name = "Gi_iLabel"
        Gi_iLabel.Size = New System.Drawing.Size(56, 17)
        Gi_iLabel.TabIndex = 23
        Gi_iLabel.Text = "Giovedì"
        '
        'Ve_iLabel
        '
        Ve_iLabel.AutoSize = True
        Ve_iLabel.Location = New System.Drawing.Point(356, 171)
        Ve_iLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ve_iLabel.Name = "Ve_iLabel"
        Ve_iLabel.Size = New System.Drawing.Size(57, 17)
        Ve_iLabel.TabIndex = 27
        Ve_iLabel.Text = "Venerdì"
        '
        'Sa_iLabel
        '
        Sa_iLabel.AutoSize = True
        Sa_iLabel.Location = New System.Drawing.Point(360, 203)
        Sa_iLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Sa_iLabel.Name = "Sa_iLabel"
        Sa_iLabel.Size = New System.Drawing.Size(53, 17)
        Sa_iLabel.TabIndex = 31
        Sa_iLabel.Text = "Sabato"
        '
        'Do_iLabel
        '
        Do_iLabel.AutoSize = True
        Do_iLabel.Location = New System.Drawing.Point(342, 235)
        Do_iLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Do_iLabel.Name = "Do_iLabel"
        Do_iLabel.Size = New System.Drawing.Size(71, 17)
        Do_iLabel.TabIndex = 35
        Do_iLabel.Text = "Domenica"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(382, 268)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(40, 17)
        NoteLabel.TabIndex = 155
        NoteLabel.Text = "note:"
        '
        'LBdestinatari
        '
        Me.LBdestinatari.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsOrari, "id_des", True))
        Me.LBdestinatari.ItemHeight = 16
        Me.LBdestinatari.Location = New System.Drawing.Point(118, 131)
        Me.LBdestinatari.Name = "LBdestinatari"
        Me.LBdestinatari.Size = New System.Drawing.Size(189, 148)
        Me.LBdestinatari.TabIndex = 2
        '
        'bsOrari
        '
        Me.bsOrari.DataMember = "DT_orari"
        Me.bsOrari.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RELclientidestinatariBindingSource
        '
        Me.RELclientidestinatariBindingSource.DataMember = "REL_clientidestinatari"
        Me.RELclientidestinatariBindingSource.DataSource = Me.DTclientiBindingSource
        '
        'DTclientiBindingSource
        '
        Me.DTclientiBindingSource.DataMember = "DT_clienti"
        Me.DTclientiBindingSource.DataSource = Me.DS_utenti
        '
        'DTutentiBindingSource
        '
        Me.DTutentiBindingSource.DataMember = "DT_utenti"
        Me.DTutentiBindingSource.DataSource = Me.DS_utenti
        '
        'Lu_iTextBox
        '
        Me.Lu_iTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lu_iTextBox.Location = New System.Drawing.Point(430, 44)
        Me.Lu_iTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Lu_iTextBox.Name = "Lu_iTextBox"
        Me.Lu_iTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Lu_iTextBox.TabIndex = 4
        '
        'Lu_uTextBox
        '
        Me.Lu_uTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Lu_uTextBox.Location = New System.Drawing.Point(506, 44)
        Me.Lu_uTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Lu_uTextBox.Name = "Lu_uTextBox"
        Me.Lu_uTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Lu_uTextBox.TabIndex = 5
        '
        'Ma_iTextBox
        '
        Me.Ma_iTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Ma_iTextBox.Location = New System.Drawing.Point(430, 76)
        Me.Ma_iTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Ma_iTextBox.Name = "Ma_iTextBox"
        Me.Ma_iTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Ma_iTextBox.TabIndex = 6
        '
        'Ma_uTextBox
        '
        Me.Ma_uTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Ma_uTextBox.Location = New System.Drawing.Point(506, 76)
        Me.Ma_uTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Ma_uTextBox.Name = "Ma_uTextBox"
        Me.Ma_uTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Ma_uTextBox.TabIndex = 7
        '
        'Me_iTextBox
        '
        Me.Me_iTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Me_iTextBox.Location = New System.Drawing.Point(430, 108)
        Me.Me_iTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Me_iTextBox.Name = "Me_iTextBox"
        Me.Me_iTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Me_iTextBox.TabIndex = 8
        '
        'Me_uTextBox
        '
        Me.Me_uTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Me_uTextBox.Location = New System.Drawing.Point(506, 108)
        Me.Me_uTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Me_uTextBox.Name = "Me_uTextBox"
        Me.Me_uTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Me_uTextBox.TabIndex = 9
        '
        'Gi_iTextBox
        '
        Me.Gi_iTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Gi_iTextBox.Location = New System.Drawing.Point(430, 140)
        Me.Gi_iTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Gi_iTextBox.Name = "Gi_iTextBox"
        Me.Gi_iTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Gi_iTextBox.TabIndex = 10
        '
        'Gi_uTextBox
        '
        Me.Gi_uTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Gi_uTextBox.Location = New System.Drawing.Point(506, 140)
        Me.Gi_uTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Gi_uTextBox.Name = "Gi_uTextBox"
        Me.Gi_uTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Gi_uTextBox.TabIndex = 11
        '
        'Ve_iTextBox
        '
        Me.Ve_iTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Ve_iTextBox.Location = New System.Drawing.Point(430, 172)
        Me.Ve_iTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Ve_iTextBox.Name = "Ve_iTextBox"
        Me.Ve_iTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Ve_iTextBox.TabIndex = 12
        '
        'Ve_uTextBox
        '
        Me.Ve_uTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Ve_uTextBox.Location = New System.Drawing.Point(506, 172)
        Me.Ve_uTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Ve_uTextBox.Name = "Ve_uTextBox"
        Me.Ve_uTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Ve_uTextBox.TabIndex = 13
        '
        'Sa_iTextBox
        '
        Me.Sa_iTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sa_iTextBox.Location = New System.Drawing.Point(430, 204)
        Me.Sa_iTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Sa_iTextBox.Name = "Sa_iTextBox"
        Me.Sa_iTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Sa_iTextBox.TabIndex = 14
        '
        'Sa_uTextBox
        '
        Me.Sa_uTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Sa_uTextBox.Location = New System.Drawing.Point(506, 204)
        Me.Sa_uTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Sa_uTextBox.Name = "Sa_uTextBox"
        Me.Sa_uTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Sa_uTextBox.TabIndex = 15
        '
        'Do_iTextBox
        '
        Me.Do_iTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Do_iTextBox.Location = New System.Drawing.Point(430, 236)
        Me.Do_iTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Do_iTextBox.Name = "Do_iTextBox"
        Me.Do_iTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Do_iTextBox.TabIndex = 16
        '
        'Do_uTextBox
        '
        Me.Do_uTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Do_uTextBox.Location = New System.Drawing.Point(506, 236)
        Me.Do_uTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Do_uTextBox.Name = "Do_uTextBox"
        Me.Do_uTextBox.Size = New System.Drawing.Size(70, 23)
        Me.Do_uTextBox.TabIndex = 17
        '
        'DT_BarraNavigazione
        '
        Me.DT_BarraNavigazione.AddNewItem = Nothing
        Me.DT_BarraNavigazione.AutoSize = False
        Me.DT_BarraNavigazione.CountItem = Me.BindingNavigatorCountItem
        Me.DT_BarraNavigazione.DeleteItem = Nothing
        Me.DT_BarraNavigazione.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_BarraNavigazione.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.DT_BarraNavigazione.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicerca, Me.TTTestoRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator3, Me.TTPB, Me.TTBTannulla, Me.TT_CB_anno, Me.TT_CB_mese})
        Me.DT_BarraNavigazione.Location = New System.Drawing.Point(0, 355)
        Me.DT_BarraNavigazione.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_BarraNavigazione.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_BarraNavigazione.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_BarraNavigazione.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_BarraNavigazione.Name = "DT_BarraNavigazione"
        Me.DT_BarraNavigazione.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_BarraNavigazione.Size = New System.Drawing.Size(785, 76)
        Me.DT_BarraNavigazione.TabIndex = 147
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
        'TTBTRicerca
        '
        Me.TTBTRicerca.AutoSize = False
        Me.TTBTRicerca.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_ricarica
        Me.TTBTRicerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTRicerca.Name = "TTBTRicerca"
        Me.TTBTRicerca.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicerca.Text = "Ricarica"
        Me.TTBTRicerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicerca.ToolTipText = "Elimina tutti i filtri e ricarica tutti gli archivi"
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
        Me.TTBTAggiunge.ToolTipText = "Aggiunge un nuovo cliente o un nuovo destinatario o un nuovo codice per la fattur" &
    "a elettronica"
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
        Me.TTBTElimina.ToolTipText = "Elimina il Cliente selezionato compreso tutte le destinazioni"
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
        Me.TTBTSalva.ToolTipText = "Memorizza tutte le informazioni inserite"
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 76)
        '
        'TTPB
        '
        Me.TTPB.Name = "TTPB"
        Me.TTPB.Size = New System.Drawing.Size(133, 95)
        Me.TTPB.Visible = False
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
        Me.TTBTannulla.ToolTipText = "Annulla ogni inserimento e ricarica i dati"
        Me.TTBTannulla.Visible = False
        '
        'TT_CB_anno
        '
        Me.TT_CB_anno.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_anno.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_anno.Name = "TT_CB_anno"
        Me.TT_CB_anno.Size = New System.Drawing.Size(160, 38)
        Me.TT_CB_anno.Visible = False
        '
        'TT_CB_mese
        '
        Me.TT_CB_mese.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_mese.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_mese.Name = "TT_CB_mese"
        Me.TT_CB_mese.Size = New System.Drawing.Size(150, 38)
        Me.TT_CB_mese.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(20, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 17)
        Me.Label1.TabIndex = 148
        Me.Label1.Text = "Dipendente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(19, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 17)
        Me.Label2.TabIndex = 149
        Me.Label2.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(20, 131)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 17)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Destinazione"
        '
        'BT_trisettimanale
        '
        Me.BT_trisettimanale.AutoSize = True
        Me.BT_trisettimanale.Location = New System.Drawing.Point(592, 107)
        Me.BT_trisettimanale.Name = "BT_trisettimanale"
        Me.BT_trisettimanale.Size = New System.Drawing.Size(117, 27)
        Me.BT_trisettimanale.TabIndex = 151
        Me.BT_trisettimanale.Text = "Trisettimanle"
        Me.BT_trisettimanale.UseVisualStyleBackColor = True
        '
        'BT_giornaliero
        '
        Me.BT_giornaliero.AutoSize = True
        Me.BT_giornaliero.Location = New System.Drawing.Point(592, 77)
        Me.BT_giornaliero.Name = "BT_giornaliero"
        Me.BT_giornaliero.Size = New System.Drawing.Size(117, 27)
        Me.BT_giornaliero.TabIndex = 152
        Me.BT_giornaliero.Text = "Giornaliero"
        Me.BT_giornaliero.UseVisualStyleBackColor = True
        '
        'BT_vuota
        '
        Me.BT_vuota.AutoSize = True
        Me.BT_vuota.Location = New System.Drawing.Point(592, 44)
        Me.BT_vuota.Name = "BT_vuota"
        Me.BT_vuota.Size = New System.Drawing.Size(117, 27)
        Me.BT_vuota.TabIndex = 153
        Me.BT_vuota.Text = "Azzera"
        Me.BT_vuota.UseVisualStyleBackColor = True
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Location = New System.Drawing.Point(428, 265)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(247, 23)
        Me.NoteTextBox.TabIndex = 156
        '
        'QuindicinaleCheckBox
        '
        Me.QuindicinaleCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.QuindicinaleCheckBox.Location = New System.Drawing.Point(428, 294)
        Me.QuindicinaleCheckBox.Name = "QuindicinaleCheckBox"
        Me.QuindicinaleCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.QuindicinaleCheckBox.TabIndex = 157
        Me.QuindicinaleCheckBox.Text = "Quindicinale"
        Me.QuindicinaleCheckBox.UseVisualStyleBackColor = True
        '
        'AttivoCheckBox
        '
        Me.AttivoCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.AttivoCheckBox.Location = New System.Drawing.Point(571, 294)
        Me.AttivoCheckBox.Name = "AttivoCheckBox"
        Me.AttivoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.AttivoCheckBox.TabIndex = 158
        Me.AttivoCheckBox.Text = "Attivo"
        Me.AttivoCheckBox.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "omino_no.png")
        Me.ImageList1.Images.SetKeyName(1, "omino_si.png")
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CheckBox1.Appearance = System.Windows.Forms.Appearance.Button
        Me.CheckBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CheckBox1.ImageList = Me.ImageList1
        Me.CheckBox1.Location = New System.Drawing.Point(735, 0)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(50, 50)
        Me.CheckBox1.TabIndex = 159
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CB_utenti
        '
        Me.CB_utenti.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsOrari, "id_dip", True))
        Me.CB_utenti.FormattingEnabled = True
        Me.CB_utenti.Location = New System.Drawing.Point(118, 33)
        Me.CB_utenti.Name = "CB_utenti"
        Me.CB_utenti.Size = New System.Drawing.Size(189, 24)
        Me.CB_utenti.TabIndex = 0
        '
        'TA_utenti1
        '
        Me.TA_utenti1.ClearBeforeFill = True
        '
        'CB_clienti
        '
        Me.CB_clienti.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.bsOrari, "id_cli", True))
        Me.CB_clienti.FormattingEnabled = True
        Me.CB_clienti.Location = New System.Drawing.Point(118, 77)
        Me.CB_clienti.Name = "CB_clienti"
        Me.CB_clienti.Size = New System.Drawing.Size(189, 24)
        Me.CB_clienti.TabIndex = 1
        '
        'TA_clienti1
        '
        Me.TA_clienti1.ClearBeforeFill = True
        '
        'TA_destinatari
        '
        Me.TA_destinatari.ClearBeforeFill = True
        '
        'frmDipendentePianodiLavoro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 431)
        Me.Controls.Add(Me.CB_clienti)
        Me.Controls.Add(Me.CB_utenti)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.AttivoCheckBox)
        Me.Controls.Add(Me.QuindicinaleCheckBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.BT_vuota)
        Me.Controls.Add(Me.BT_giornaliero)
        Me.Controls.Add(Me.BT_trisettimanale)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DT_BarraNavigazione)
        Me.Controls.Add(Lu_iLabel)
        Me.Controls.Add(Me.Lu_iTextBox)
        Me.Controls.Add(Me.Lu_uTextBox)
        Me.Controls.Add(Ma_iLabel)
        Me.Controls.Add(Me.Ma_iTextBox)
        Me.Controls.Add(Me.Ma_uTextBox)
        Me.Controls.Add(Me_iLabel)
        Me.Controls.Add(Me.Me_iTextBox)
        Me.Controls.Add(Me.Me_uTextBox)
        Me.Controls.Add(Gi_iLabel)
        Me.Controls.Add(Me.Gi_iTextBox)
        Me.Controls.Add(Me.Gi_uTextBox)
        Me.Controls.Add(Ve_iLabel)
        Me.Controls.Add(Me.Ve_iTextBox)
        Me.Controls.Add(Me.Ve_uTextBox)
        Me.Controls.Add(Sa_iLabel)
        Me.Controls.Add(Me.Sa_iTextBox)
        Me.Controls.Add(Me.Sa_uTextBox)
        Me.Controls.Add(Do_iLabel)
        Me.Controls.Add(Me.Do_iTextBox)
        Me.Controls.Add(Me.Do_uTextBox)
        Me.Controls.Add(Me.LBdestinatari)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmDipendentePianodiLavoro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dettaglio inserimento ore"
        CType(Me.bsOrari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RELclientidestinatariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTclientiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTutentiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_BarraNavigazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_BarraNavigazione.ResumeLayout(False)
        Me.DT_BarraNavigazione.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBdestinatari As ListBox
    Friend WithEvents Lu_iTextBox As TextBox
    Friend WithEvents Lu_uTextBox As TextBox
    Friend WithEvents Ma_iTextBox As TextBox
    Friend WithEvents Ma_uTextBox As TextBox
    Friend WithEvents Me_iTextBox As TextBox
    Friend WithEvents Me_uTextBox As TextBox
    Friend WithEvents Gi_iTextBox As TextBox
    Friend WithEvents Gi_uTextBox As TextBox
    Friend WithEvents Ve_iTextBox As TextBox
    Friend WithEvents Ve_uTextBox As TextBox
    Friend WithEvents Sa_iTextBox As TextBox
    Friend WithEvents Sa_uTextBox As TextBox
    Friend WithEvents Do_iTextBox As TextBox
    Friend WithEvents Do_uTextBox As TextBox
    Friend WithEvents DT_BarraNavigazione As BindingNavigator
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
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents TTBTModifica As ToolStripButton
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TTPB As ToolStripProgressBar
    Friend WithEvents TTBTannulla As ToolStripButton
    Friend WithEvents TT_CB_anno As ToolStripComboBox
    Friend WithEvents TT_CB_mese As ToolStripComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BT_trisettimanale As Button
    Friend WithEvents BT_giornaliero As Button
    Friend WithEvents BT_vuota As Button
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents QuindicinaleCheckBox As CheckBox
    Friend WithEvents AttivoCheckBox As CheckBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CB_utenti As ComboBox
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents DTutentiBindingSource As BindingSource
    Friend WithEvents TA_utenti1 As DS_utentiTableAdapters.TA_utenti
    Friend WithEvents CB_clienti As ComboBox
    Friend WithEvents DTclientiBindingSource As BindingSource
    Friend WithEvents TA_clienti1 As DS_utentiTableAdapters.TA_clienti
    Friend WithEvents RELclientidestinatariBindingSource As BindingSource
    Friend WithEvents bsOrari As BindingSource

    Friend WithEvents TA_destinatari As DS_utentiTableAdapters.TA_destinatari
End Class
