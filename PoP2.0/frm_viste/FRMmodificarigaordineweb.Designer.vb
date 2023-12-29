<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMmodificarigaordineweb
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
        Dim PosizioneLabel As System.Windows.Forms.Label
        Dim DataordineLabel As System.Windows.Forms.Label
        Dim Id_prodottoLabel As System.Windows.Forms.Label
        Dim QuantitaLabel As System.Windows.Forms.Label
        Dim Id_locazioneLabel As System.Windows.Forms.Label
        Dim Id_utenteLabel As System.Windows.Forms.Label
        Dim FornitoreLabel As System.Windows.Forms.Label
        Dim PrezzounitarioLabel As System.Windows.Forms.Label
        Dim ScontoLabel As System.Windows.Forms.Label
        Dim TaxLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMmodificarigaordineweb))
        Dim Label1 As System.Windows.Forms.Label
        Me.DS_Ordini = New PoP2.Comuni.DS_Ordini()
        Me.BSordiniRigaWeb = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAordiniRigaWeb = New PoP2.Comuni.DS_OrdiniTableAdapters.TAordiniRigaWeb()
        Me.TableAdapterManager = New PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager()
        Me.PosizioneTextBox = New System.Windows.Forms.TextBox()
        Me.DataordineDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BSprodotti = New System.Windows.Forms.BindingSource(Me.components)
        Me.QuantitaTextBox = New System.Windows.Forms.TextBox()
        Me.Id_locazioneComboBox = New System.Windows.Forms.ComboBox()
        Me.BSdettaglio = New System.Windows.Forms.BindingSource(Me.components)
        Me.Id_utenteComboBox = New System.Windows.Forms.ComboBox()
        Me.BSutenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrezzounitarioTextBox = New System.Windows.Forms.TextBox()
        Me.ScontoTextBox = New System.Windows.Forms.TextBox()
        Me.TaxTextBox = New System.Windows.Forms.TextBox()
        Me.TA_prodotti = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_prodotti()
        Me.TA_destinatari = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_destinatari()
        Me.TA_utenti = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_utenti()
        Me.DT_v_ordiniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
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
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CBfornitore = New System.Windows.Forms.ComboBox()
        Me.LBprodotti = New System.Windows.Forms.ListBox()
        Me.TXricercaprodotto = New System.Windows.Forms.TextBox()
        Me.LBnumero = New System.Windows.Forms.Label()
        Me.TX_descrizioneprodotto = New System.Windows.Forms.TextBox()
        PosizioneLabel = New System.Windows.Forms.Label()
        DataordineLabel = New System.Windows.Forms.Label()
        Id_prodottoLabel = New System.Windows.Forms.Label()
        QuantitaLabel = New System.Windows.Forms.Label()
        Id_locazioneLabel = New System.Windows.Forms.Label()
        Id_utenteLabel = New System.Windows.Forms.Label()
        FornitoreLabel = New System.Windows.Forms.Label()
        PrezzounitarioLabel = New System.Windows.Forms.Label()
        ScontoLabel = New System.Windows.Forms.Label()
        TaxLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSordiniRigaWeb, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSprodotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSdettaglio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSutenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_v_ordiniBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'PosizioneLabel
        '
        PosizioneLabel.AutoSize = True
        PosizioneLabel.Location = New System.Drawing.Point(40, 35)
        PosizioneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PosizioneLabel.Name = "PosizioneLabel"
        PosizioneLabel.Size = New System.Drawing.Size(47, 17)
        PosizioneLabel.TabIndex = 6
        PosizioneLabel.Text = "SORT"
        '
        'DataordineLabel
        '
        DataordineLabel.AutoSize = True
        DataordineLabel.Location = New System.Drawing.Point(198, 35)
        DataordineLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DataordineLabel.Name = "DataordineLabel"
        DataordineLabel.Size = New System.Drawing.Size(38, 17)
        DataordineLabel.TabIndex = 8
        DataordineLabel.Text = "Data"
        '
        'Id_prodottoLabel
        '
        Id_prodottoLabel.AutoSize = True
        Id_prodottoLabel.Location = New System.Drawing.Point(17, 216)
        Id_prodottoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_prodottoLabel.Name = "Id_prodottoLabel"
        Id_prodottoLabel.Size = New System.Drawing.Size(62, 17)
        Id_prodottoLabel.TabIndex = 10
        Id_prodottoLabel.Text = "Prodotto"
        '
        'QuantitaLabel
        '
        QuantitaLabel.AutoSize = True
        QuantitaLabel.Location = New System.Drawing.Point(406, 217)
        QuantitaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        QuantitaLabel.Name = "QuantitaLabel"
        QuantitaLabel.Size = New System.Drawing.Size(63, 17)
        QuantitaLabel.TabIndex = 12
        QuantitaLabel.Text = "quantita:"
        '
        'Id_locazioneLabel
        '
        Id_locazioneLabel.AutoSize = True
        Id_locazioneLabel.Location = New System.Drawing.Point(13, 102)
        Id_locazioneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_locazioneLabel.Name = "Id_locazioneLabel"
        Id_locazioneLabel.Size = New System.Drawing.Size(111, 17)
        Id_locazioneLabel.TabIndex = 14
        Id_locazioneLabel.Text = "Dettaglio Cliente"
        '
        'Id_utenteLabel
        '
        Id_utenteLabel.AutoSize = True
        Id_utenteLabel.Location = New System.Drawing.Point(73, 135)
        Id_utenteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_utenteLabel.Name = "Id_utenteLabel"
        Id_utenteLabel.Size = New System.Drawing.Size(50, 17)
        Id_utenteLabel.TabIndex = 16
        Id_utenteLabel.Text = "Utente"
        '
        'FornitoreLabel
        '
        FornitoreLabel.AutoSize = True
        FornitoreLabel.Location = New System.Drawing.Point(61, 168)
        FornitoreLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FornitoreLabel.Name = "FornitoreLabel"
        FornitoreLabel.Size = New System.Drawing.Size(65, 17)
        FornitoreLabel.TabIndex = 24
        FornitoreLabel.Text = "Fornitore"
        '
        'PrezzounitarioLabel
        '
        PrezzounitarioLabel.AutoSize = True
        PrezzounitarioLabel.Location = New System.Drawing.Point(497, 217)
        PrezzounitarioLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrezzounitarioLabel.Name = "PrezzounitarioLabel"
        PrezzounitarioLabel.Size = New System.Drawing.Size(107, 17)
        PrezzounitarioLabel.TabIndex = 26
        PrezzounitarioLabel.Text = "Prezzo unitario:"
        '
        'ScontoLabel
        '
        ScontoLabel.AutoSize = True
        ScontoLabel.Location = New System.Drawing.Point(406, 262)
        ScontoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ScontoLabel.Name = "ScontoLabel"
        ScontoLabel.Size = New System.Drawing.Size(54, 17)
        ScontoLabel.TabIndex = 28
        ScontoLabel.Text = "sconto:"
        '
        'TaxLabel
        '
        TaxLabel.AutoSize = True
        TaxLabel.Location = New System.Drawing.Point(497, 262)
        TaxLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TaxLabel.Name = "TaxLabel"
        TaxLabel.Size = New System.Drawing.Size(51, 17)
        TaxLabel.TabIndex = 32
        TaxLabel.Text = "Tasse:"
        '
        'DS_Ordini
        '
        Me.DS_Ordini.DataSetName = "DS_Ordini"
        Me.DS_Ordini.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BSordiniRigaWeb
        '
        Me.BSordiniRigaWeb.DataMember = "DTordiniRigaWeb"
        Me.BSordiniRigaWeb.DataSource = Me.DS_Ordini
        '
        'TAordiniRigaWeb
        '
        Me.TAordiniRigaWeb.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PosizioneTextBox
        '
        Me.PosizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSordiniRigaWeb, "posizione", True))
        Me.PosizioneTextBox.Location = New System.Drawing.Point(98, 30)
        Me.PosizioneTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PosizioneTextBox.Name = "PosizioneTextBox"
        Me.PosizioneTextBox.Size = New System.Drawing.Size(65, 23)
        Me.PosizioneTextBox.TabIndex = 7
        '
        'DataordineDateTimePicker
        '
        Me.DataordineDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BSordiniRigaWeb, "dataordine", True))
        Me.DataordineDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DataordineDateTimePicker.Location = New System.Drawing.Point(267, 30)
        Me.DataordineDateTimePicker.Margin = New System.Windows.Forms.Padding(4)
        Me.DataordineDateTimePicker.Name = "DataordineDateTimePicker"
        Me.DataordineDateTimePicker.Size = New System.Drawing.Size(123, 23)
        Me.DataordineDateTimePicker.TabIndex = 9
        '
        'BSprodotti
        '
        Me.BSprodotti.DataMember = "DT_prodotti"
        Me.BSprodotti.DataSource = Me.DS_Ordini
        '
        'QuantitaTextBox
        '
        Me.QuantitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSordiniRigaWeb, "quantita", True))
        Me.QuantitaTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.QuantitaTextBox.Location = New System.Drawing.Point(406, 237)
        Me.QuantitaTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.QuantitaTextBox.Name = "QuantitaTextBox"
        Me.QuantitaTextBox.Size = New System.Drawing.Size(77, 23)
        Me.QuantitaTextBox.TabIndex = 13
        '
        'Id_locazioneComboBox
        '
        Me.Id_locazioneComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BSordiniRigaWeb, "id_locazione", True))
        Me.Id_locazioneComboBox.DataSource = Me.BSdettaglio
        Me.Id_locazioneComboBox.DisplayMember = "locazione"
        Me.Id_locazioneComboBox.FormattingEnabled = True
        Me.Id_locazioneComboBox.Location = New System.Drawing.Point(133, 98)
        Me.Id_locazioneComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_locazioneComboBox.Name = "Id_locazioneComboBox"
        Me.Id_locazioneComboBox.Size = New System.Drawing.Size(265, 24)
        Me.Id_locazioneComboBox.TabIndex = 15
        Me.Id_locazioneComboBox.ValueMember = "id"
        '
        'BSdettaglio
        '
        Me.BSdettaglio.DataMember = "DT_destinatari"
        Me.BSdettaglio.DataSource = Me.DS_Ordini
        '
        'Id_utenteComboBox
        '
        Me.Id_utenteComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BSordiniRigaWeb, "id_utente", True))
        Me.Id_utenteComboBox.DataSource = Me.BSutenti
        Me.Id_utenteComboBox.DisplayMember = "anagrafica"
        Me.Id_utenteComboBox.FormattingEnabled = True
        Me.Id_utenteComboBox.Location = New System.Drawing.Point(133, 132)
        Me.Id_utenteComboBox.Margin = New System.Windows.Forms.Padding(4)
        Me.Id_utenteComboBox.Name = "Id_utenteComboBox"
        Me.Id_utenteComboBox.Size = New System.Drawing.Size(265, 24)
        Me.Id_utenteComboBox.TabIndex = 17
        Me.Id_utenteComboBox.ValueMember = "id"
        '
        'BSutenti
        '
        Me.BSutenti.DataMember = "DT_utenti"
        Me.BSutenti.DataSource = Me.DS_Ordini
        '
        'PrezzounitarioTextBox
        '
        Me.PrezzounitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSordiniRigaWeb, "prezzounitario", True))
        Me.PrezzounitarioTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.PrezzounitarioTextBox.Location = New System.Drawing.Point(497, 237)
        Me.PrezzounitarioTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.PrezzounitarioTextBox.Name = "PrezzounitarioTextBox"
        Me.PrezzounitarioTextBox.Size = New System.Drawing.Size(147, 23)
        Me.PrezzounitarioTextBox.TabIndex = 27
        '
        'ScontoTextBox
        '
        Me.ScontoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSordiniRigaWeb, "sconto", True))
        Me.ScontoTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ScontoTextBox.Location = New System.Drawing.Point(406, 283)
        Me.ScontoTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ScontoTextBox.Name = "ScontoTextBox"
        Me.ScontoTextBox.Size = New System.Drawing.Size(83, 23)
        Me.ScontoTextBox.TabIndex = 29
        '
        'TaxTextBox
        '
        Me.TaxTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSordiniRigaWeb, "tax", True))
        Me.TaxTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TaxTextBox.Location = New System.Drawing.Point(497, 282)
        Me.TaxTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.TaxTextBox.Name = "TaxTextBox"
        Me.TaxTextBox.Size = New System.Drawing.Size(91, 23)
        Me.TaxTextBox.TabIndex = 33
        '
        'TA_prodotti
        '
        Me.TA_prodotti.ClearBeforeFill = True
        '
        'TA_destinatari
        '
        Me.TA_destinatari.ClearBeforeFill = True
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'DT_v_ordiniBindingNavigator
        '
        Me.DT_v_ordiniBindingNavigator.AddNewItem = Nothing
        Me.DT_v_ordiniBindingNavigator.AutoSize = False
        Me.DT_v_ordiniBindingNavigator.BindingSource = Me.BSordiniRigaWeb
        Me.DT_v_ordiniBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DT_v_ordiniBindingNavigator.DeleteItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_v_ordiniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTAggiunge, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.ToolStripSeparator3})
        Me.DT_v_ordiniBindingNavigator.Location = New System.Drawing.Point(0, 565)
        Me.DT_v_ordiniBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_v_ordiniBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_v_ordiniBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_v_ordiniBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_v_ordiniBindingNavigator.Name = "DT_v_ordiniBindingNavigator"
        Me.DT_v_ordiniBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_v_ordiniBindingNavigator.Size = New System.Drawing.Size(772, 97)
        Me.DT_v_ordiniBindingNavigator.TabIndex = 162
        Me.DT_v_ordiniBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 94)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
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
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 97)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 97)
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 97)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 97)
        '
        'CBfornitore
        '
        Me.CBfornitore.FormattingEnabled = True
        Me.CBfornitore.Location = New System.Drawing.Point(133, 166)
        Me.CBfornitore.Margin = New System.Windows.Forms.Padding(4)
        Me.CBfornitore.Name = "CBfornitore"
        Me.CBfornitore.Size = New System.Drawing.Size(265, 24)
        Me.CBfornitore.TabIndex = 163
        '
        'LBprodotti
        '
        Me.LBprodotti.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LBprodotti.FormattingEnabled = True
        Me.LBprodotti.ItemHeight = 16
        Me.LBprodotti.Location = New System.Drawing.Point(22, 390)
        Me.LBprodotti.Margin = New System.Windows.Forms.Padding(4)
        Me.LBprodotti.Name = "LBprodotti"
        Me.LBprodotti.Size = New System.Drawing.Size(455, 148)
        Me.LBprodotti.TabIndex = 164
        '
        'TXricercaprodotto
        '
        Me.TXricercaprodotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TXricercaprodotto.Location = New System.Drawing.Point(22, 359)
        Me.TXricercaprodotto.Margin = New System.Windows.Forms.Padding(4)
        Me.TXricercaprodotto.Name = "TXricercaprodotto"
        Me.TXricercaprodotto.Size = New System.Drawing.Size(381, 23)
        Me.TXricercaprodotto.TabIndex = 165
        '
        'LBnumero
        '
        Me.LBnumero.AutoSize = True
        Me.LBnumero.Location = New System.Drawing.Point(20, 545)
        Me.LBnumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBnumero.Name = "LBnumero"
        Me.LBnumero.Size = New System.Drawing.Size(60, 17)
        Me.LBnumero.TabIndex = 166
        Me.LBnumero.Text = "numero:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(23, 338)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(169, 17)
        Label1.TabIndex = 167
        Label1.Text = "Elenco prodotti disponibili"
        '
        'TX_descrizioneprodotto
        '
        Me.TX_descrizioneprodotto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSordiniRigaWeb, "descrizione", True))
        Me.TX_descrizioneprodotto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TX_descrizioneprodotto.Location = New System.Drawing.Point(16, 237)
        Me.TX_descrizioneprodotto.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_descrizioneprodotto.Name = "TX_descrizioneprodotto"
        Me.TX_descrizioneprodotto.Size = New System.Drawing.Size(381, 23)
        Me.TX_descrizioneprodotto.TabIndex = 168
        '
        'FRMmodificarigaordineweb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 662)
        Me.Controls.Add(Me.TX_descrizioneprodotto)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.LBnumero)
        Me.Controls.Add(Me.TXricercaprodotto)
        Me.Controls.Add(Me.LBprodotti)
        Me.Controls.Add(Me.CBfornitore)
        Me.Controls.Add(Me.DT_v_ordiniBindingNavigator)
        Me.Controls.Add(PosizioneLabel)
        Me.Controls.Add(Me.PosizioneTextBox)
        Me.Controls.Add(DataordineLabel)
        Me.Controls.Add(Me.DataordineDateTimePicker)
        Me.Controls.Add(Id_prodottoLabel)
        Me.Controls.Add(QuantitaLabel)
        Me.Controls.Add(Me.QuantitaTextBox)
        Me.Controls.Add(Id_locazioneLabel)
        Me.Controls.Add(Me.Id_locazioneComboBox)
        Me.Controls.Add(Id_utenteLabel)
        Me.Controls.Add(Me.Id_utenteComboBox)
        Me.Controls.Add(FornitoreLabel)
        Me.Controls.Add(PrezzounitarioLabel)
        Me.Controls.Add(Me.PrezzounitarioTextBox)
        Me.Controls.Add(ScontoLabel)
        Me.Controls.Add(Me.ScontoTextBox)
        Me.Controls.Add(TaxLabel)
        Me.Controls.Add(Me.TaxTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRMmodificarigaordineweb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modifica Dettaglio Ordini Web"
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSordiniRigaWeb, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSprodotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSdettaglio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSutenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_v_ordiniBindingNavigator.ResumeLayout(False)
        Me.DT_v_ordiniBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_Ordini As DS_Ordini
    Friend WithEvents BSordiniRigaWeb As BindingSource
    Friend WithEvents TAordiniRigaWeb As DS_OrdiniTableAdapters.TAordiniRigaWeb
    Friend WithEvents TableAdapterManager As DS_OrdiniTableAdapters.TableAdapterManager
    Friend WithEvents PosizioneTextBox As TextBox
    Friend WithEvents DataordineDateTimePicker As DateTimePicker
    Friend WithEvents QuantitaTextBox As TextBox
    Friend WithEvents Id_locazioneComboBox As ComboBox
    Friend WithEvents Id_utenteComboBox As ComboBox
    Friend WithEvents PrezzounitarioTextBox As TextBox
    Friend WithEvents ScontoTextBox As TextBox
    Friend WithEvents TaxTextBox As TextBox
    Friend WithEvents BSprodotti As BindingSource
    Friend WithEvents TA_prodotti As DS_OrdiniTableAdapters.TA_prodotti
    Friend WithEvents BSdettaglio As BindingSource
    Friend WithEvents BSutenti As BindingSource
    Friend WithEvents TA_destinatari As DS_OrdiniTableAdapters.TA_destinatari
    Friend WithEvents TA_utenti As DS_OrdiniTableAdapters.TA_utenti
    Friend WithEvents DT_v_ordiniBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
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
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CBfornitore As ComboBox
    Friend WithEvents LBprodotti As ListBox
    Friend WithEvents TXricercaprodotto As TextBox
    Friend WithEvents LBnumero As Label
    Friend WithEvents TX_descrizioneprodotto As TextBox
End Class
