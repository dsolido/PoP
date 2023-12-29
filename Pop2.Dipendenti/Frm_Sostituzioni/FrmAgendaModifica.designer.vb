<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmAgendaModifica
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
        Dim DataeventoLabel As System.Windows.Forms.Label
        Dim Id_dip_aLabel As System.Windows.Forms.Label
        Dim Id_cliLabel As System.Windows.Forms.Label
        Dim Id_desLabel As System.Windows.Forms.Label
        Dim Id_tipoLabel As System.Windows.Forms.Label
        Dim Ora_iLabel As System.Windows.Forms.Label
        Dim Ora_fLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgendaModifica))
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
        Me.DS_agenda = New PoP2.Comuni.DS_ag()
        Me.TableAdapterManager = New PoP2.Comuni.DS_agTableAdapters.TableAdapterManager()
        Me.BN_navigazione = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BS_a = New System.Windows.Forms.BindingSource(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TT_inizio = New System.Windows.Forms.ToolStripButton()
        Me.TT_prima = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TT_dopo = New System.Windows.Forms.ToolStripButton()
        Me.TT_ultimo = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TT_aggiunge = New System.Windows.Forms.ToolStripButton()
        Me.TT_elimina = New System.Windows.Forms.ToolStripButton()
        Me.TT_salva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTtermina = New System.Windows.Forms.ToolStripButton()
        Me.DT_dallaData = New System.Windows.Forms.DateTimePicker()
        Me.BS_utentiA = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_utentiB = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_clienti = New System.Windows.Forms.ComboBox()
        Me.BS_clienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_locazioni = New System.Windows.Forms.ComboBox()
        Me.BS_R_locazioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.CB_tipo = New System.Windows.Forms.ComboBox()
        Me.bSTipo = New System.Windows.Forms.BindingSource(Me.components)
        Me.Ora_iDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Ora_fDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.TA_utenti = New PoP2.Comuni.DS_agTableAdapters.TA_utenti()
        Me.TA_clienti = New PoP2.Comuni.DS_agTableAdapters.TA_clienti()
        Me.TA_locazioni = New PoP2.Comuni.DS_agTableAdapters.TA_locazioni()
        Me.DT_allaData = New System.Windows.Forms.DateTimePicker()
        Me.BT_alla = New System.Windows.Forms.CheckBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DG_orari = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGCsocieta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGClocazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGC1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGC2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGC3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGC4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGC5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGC6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGC7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGC8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_relOrari = New System.Windows.Forms.BindingSource(Me.components)
        Me.LB_orariDip = New System.Windows.Forms.Label()
        Me.TA_orari = New PoP2.Comuni.DS_agTableAdapters.TA_orari()
        Me.TAsostituzioni = New PoP2.Comuni.DS_agTableAdapters.TAsostituzioni()
        Me.DGorarisostituto = New System.Windows.Forms.DataGridView()
        Me.colCantiere = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colInizio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colFine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colTipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GRorarisostituto = New System.Windows.Forms.GroupBox()
        Me.btElaboratantigiorni = New System.Windows.Forms.Button()
        Me.LWperiodo = New System.Windows.Forms.ListView()
        Me.btMemorizzaDati = New System.Windows.Forms.Button()
        Me.TXricercautente = New System.Windows.Forms.TextBox()
        Me.bsOrario = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTipAgenda = New System.Windows.Forms.ToolTip(Me.components)
        Me.ckDefinitivo = New System.Windows.Forms.CheckBox()
        Me.img60px = New System.Windows.Forms.ImageList(Me.components)
        Me.TaTipo = New PoP2.Comuni.DS_agTableAdapters.taTipo()
        Me.CB_utenteA = New System.Windows.Forms.ListBox()
        Me.CB_utenteB = New System.Windows.Forms.ListBox()
        Me.TXricercasostituto = New System.Windows.Forms.TextBox()
        Me.lbSostituto = New System.Windows.Forms.Label()
        DataeventoLabel = New System.Windows.Forms.Label()
        Id_dip_aLabel = New System.Windows.Forms.Label()
        Id_cliLabel = New System.Windows.Forms.Label()
        Id_desLabel = New System.Windows.Forms.Label()
        Id_tipoLabel = New System.Windows.Forms.Label()
        Ora_iLabel = New System.Windows.Forms.Label()
        Ora_fLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        CType(Me.DS_agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BN_navigazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BN_navigazione.SuspendLayout()
        CType(Me.BS_a, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_utentiA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_utentiB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_R_locazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bSTipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DG_orari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_relOrari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGorarisostituto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRorarisostituto.SuspendLayout()
        CType(Me.bsOrario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataeventoLabel
        '
        DataeventoLabel.AutoSize = True
        DataeventoLabel.Location = New System.Drawing.Point(63, 15)
        DataeventoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DataeventoLabel.Name = "DataeventoLabel"
        DataeventoLabel.Size = New System.Drawing.Size(44, 20)
        DataeventoLabel.TabIndex = 7
        DataeventoLabel.Text = "Data"
        '
        'Id_dip_aLabel
        '
        Id_dip_aLabel.AutoSize = True
        Id_dip_aLabel.Location = New System.Drawing.Point(40, 47)
        Id_dip_aLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_dip_aLabel.Name = "Id_dip_aLabel"
        Id_dip_aLabel.Size = New System.Drawing.Size(68, 20)
        Id_dip_aLabel.TabIndex = 9
        Id_dip_aLabel.Text = "Assente"
        '
        'Id_cliLabel
        '
        Id_cliLabel.AutoSize = True
        Id_cliLabel.Location = New System.Drawing.Point(52, 324)
        Id_cliLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_cliLabel.Name = "Id_cliLabel"
        Id_cliLabel.Size = New System.Drawing.Size(58, 20)
        Id_cliLabel.TabIndex = 13
        Id_cliLabel.Text = "Cliente"
        '
        'Id_desLabel
        '
        Id_desLabel.AutoSize = True
        Id_desLabel.Location = New System.Drawing.Point(15, 356)
        Id_desLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_desLabel.Name = "Id_desLabel"
        Id_desLabel.Size = New System.Drawing.Size(95, 20)
        Id_desLabel.TabIndex = 15
        Id_desLabel.Text = "Destinatario"
        '
        'Id_tipoLabel
        '
        Id_tipoLabel.AutoSize = True
        Id_tipoLabel.Location = New System.Drawing.Point(4, 388)
        Id_tipoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_tipoLabel.Name = "Id_tipoLabel"
        Id_tipoLabel.Size = New System.Drawing.Size(105, 20)
        Id_tipoLabel.TabIndex = 17
        Id_tipoLabel.Text = "Tipo Assenza"
        '
        'Ora_iLabel
        '
        Ora_iLabel.AutoSize = True
        Ora_iLabel.Location = New System.Drawing.Point(32, 293)
        Ora_iLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ora_iLabel.Name = "Ora_iLabel"
        Ora_iLabel.Size = New System.Drawing.Size(76, 20)
        Ora_iLabel.TabIndex = 19
        Ora_iLabel.Text = "Ora Inizio"
        '
        'Ora_fLabel
        '
        Ora_fLabel.AutoSize = True
        Ora_fLabel.Location = New System.Drawing.Point(216, 293)
        Ora_fLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Ora_fLabel.Name = "Ora_fLabel"
        Ora_fLabel.Size = New System.Drawing.Size(65, 20)
        Ora_fLabel.TabIndex = 21
        Ora_fLabel.Text = "Ora fine"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(62, 421)
        NoteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(47, 20)
        NoteLabel.TabIndex = 23
        NoteLabel.Text = "Note:"
        '
        'DS_agenda
        '
        Me.DS_agenda.DataSetName = "DS_ag"
        Me.DS_agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_agTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BN_navigazione
        '
        Me.BN_navigazione.AddNewItem = Nothing
        Me.BN_navigazione.AutoSize = False
        Me.BN_navigazione.BindingSource = Me.BS_a
        Me.BN_navigazione.CountItem = Me.BindingNavigatorCountItem
        Me.BN_navigazione.DeleteItem = Nothing
        Me.BN_navigazione.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BN_navigazione.Font = New System.Drawing.Font("Segoe UI", 16.0!)
        Me.BN_navigazione.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TT_inizio, Me.TT_prima, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.TT_dopo, Me.TT_ultimo, Me.BindingNavigatorSeparator2, Me.TT_aggiunge, Me.TT_elimina, Me.TT_salva, Me.TTBTtermina})
        Me.BN_navigazione.Location = New System.Drawing.Point(0, 759)
        Me.BN_navigazione.MoveFirstItem = Me.TT_inizio
        Me.BN_navigazione.MoveLastItem = Me.TT_ultimo
        Me.BN_navigazione.MoveNextItem = Me.TT_dopo
        Me.BN_navigazione.MovePreviousItem = Me.TT_prima
        Me.BN_navigazione.Name = "BN_navigazione"
        Me.BN_navigazione.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BN_navigazione.PositionItem = Me.BindingNavigatorPositionItem
        Me.BN_navigazione.Size = New System.Drawing.Size(851, 70)
        Me.BN_navigazione.TabIndex = 0
        Me.BN_navigazione.Text = "BindingNavigator1"
        '
        'BS_a
        '
        Me.BS_a.DataMember = "DTsostituzioni"
        Me.BS_a.DataSource = Me.DS_agenda
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(63, 67)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'TT_inizio
        '
        Me.TT_inizio.AutoSize = False
        Me.TT_inizio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TT_inizio.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TT_inizio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TT_inizio.Name = "TT_inizio"
        Me.TT_inizio.RightToLeftAutoMirrorImage = True
        Me.TT_inizio.Size = New System.Drawing.Size(60, 60)
        Me.TT_inizio.Text = "Sposta in prima posizione"
        '
        'TT_prima
        '
        Me.TT_prima.AutoSize = False
        Me.TT_prima.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TT_prima.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TT_prima.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TT_prima.Name = "TT_prima"
        Me.TT_prima.RightToLeftAutoMirrorImage = True
        Me.TT_prima.Size = New System.Drawing.Size(60, 60)
        Me.TT_prima.Text = "Sposta indietro"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 70)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(73, 29)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'TT_dopo
        '
        Me.TT_dopo.AutoSize = False
        Me.TT_dopo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TT_dopo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TT_dopo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TT_dopo.Name = "TT_dopo"
        Me.TT_dopo.RightToLeftAutoMirrorImage = True
        Me.TT_dopo.Size = New System.Drawing.Size(60, 60)
        Me.TT_dopo.Text = "Sposta avanti"
        '
        'TT_ultimo
        '
        Me.TT_ultimo.AutoSize = False
        Me.TT_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TT_ultimo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TT_ultimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TT_ultimo.Name = "TT_ultimo"
        Me.TT_ultimo.RightToLeftAutoMirrorImage = True
        Me.TT_ultimo.Size = New System.Drawing.Size(60, 60)
        Me.TT_ultimo.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 70)
        '
        'TT_aggiunge
        '
        Me.TT_aggiunge.AutoSize = False
        Me.TT_aggiunge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TT_aggiunge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TT_aggiunge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TT_aggiunge.Name = "TT_aggiunge"
        Me.TT_aggiunge.RightToLeftAutoMirrorImage = True
        Me.TT_aggiunge.Size = New System.Drawing.Size(60, 60)
        Me.TT_aggiunge.Text = "Aggiungi nuovo"
        '
        'TT_elimina
        '
        Me.TT_elimina.AutoSize = False
        Me.TT_elimina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TT_elimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TT_elimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TT_elimina.Name = "TT_elimina"
        Me.TT_elimina.RightToLeftAutoMirrorImage = True
        Me.TT_elimina.Size = New System.Drawing.Size(60, 60)
        Me.TT_elimina.Text = "Elimina"
        '
        'TT_salva
        '
        Me.TT_salva.AutoSize = False
        Me.TT_salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TT_salva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TT_salva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TT_salva.Name = "TT_salva"
        Me.TT_salva.Size = New System.Drawing.Size(60, 60)
        Me.TT_salva.Text = "Salva dati"
        '
        'TTBTtermina
        '
        Me.TTBTtermina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TTBTtermina.AutoSize = False
        Me.TTBTtermina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.TTBTtermina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TTBTtermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTtermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTtermina.Name = "TTBTtermina"
        Me.TTBTtermina.Size = New System.Drawing.Size(60, 60)
        Me.TTBTtermina.Text = "ToolStripButton1"
        Me.TTBTtermina.ToolTipText = "Termina la sessione"
        '
        'DT_dallaData
        '
        Me.DT_dallaData.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_a, "data", True))
        Me.DT_dallaData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_dallaData.Location = New System.Drawing.Point(115, 14)
        Me.DT_dallaData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DT_dallaData.Name = "DT_dallaData"
        Me.DT_dallaData.Size = New System.Drawing.Size(112, 26)
        Me.DT_dallaData.TabIndex = 0
        '
        'BS_utentiA
        '
        Me.BS_utentiA.DataMember = "DT_utenti"
        Me.BS_utentiA.DataSource = Me.DS_agenda
        '
        'BS_utentiB
        '
        Me.BS_utentiB.DataMember = "DT_utenti"
        Me.BS_utentiB.DataSource = Me.DS_agenda
        '
        'CB_clienti
        '
        Me.CB_clienti.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_a, "idcli", True))
        Me.CB_clienti.DataSource = Me.BS_clienti
        Me.CB_clienti.DisplayMember = "societa"
        Me.CB_clienti.FormattingEnabled = True
        Me.CB_clienti.Location = New System.Drawing.Point(115, 321)
        Me.CB_clienti.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CB_clienti.Name = "CB_clienti"
        Me.CB_clienti.Size = New System.Drawing.Size(253, 28)
        Me.CB_clienti.TabIndex = 7
        Me.CB_clienti.ValueMember = "id"
        '
        'BS_clienti
        '
        Me.BS_clienti.DataMember = "DT_clienti"
        Me.BS_clienti.DataSource = Me.DS_agenda
        '
        'CB_locazioni
        '
        Me.CB_locazioni.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_a, "iddes", True))
        Me.CB_locazioni.DataSource = Me.BS_R_locazioni
        Me.CB_locazioni.DisplayMember = "locazione"
        Me.CB_locazioni.FormattingEnabled = True
        Me.CB_locazioni.Location = New System.Drawing.Point(115, 352)
        Me.CB_locazioni.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CB_locazioni.Name = "CB_locazioni"
        Me.CB_locazioni.Size = New System.Drawing.Size(253, 28)
        Me.CB_locazioni.TabIndex = 8
        Me.CB_locazioni.ValueMember = "id"
        '
        'BS_R_locazioni
        '
        Me.BS_R_locazioni.DataMember = "clienti_R_locazioni"
        Me.BS_R_locazioni.DataSource = Me.BS_clienti
        '
        'CB_tipo
        '
        Me.CB_tipo.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_a, "idtipo", True))
        Me.CB_tipo.DataSource = Me.bSTipo
        Me.CB_tipo.DisplayMember = "descrizione"
        Me.CB_tipo.FormattingEnabled = True
        Me.CB_tipo.Location = New System.Drawing.Point(115, 384)
        Me.CB_tipo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CB_tipo.Name = "CB_tipo"
        Me.CB_tipo.Size = New System.Drawing.Size(253, 28)
        Me.CB_tipo.TabIndex = 9
        Me.CB_tipo.ValueMember = "id"
        '
        'bSTipo
        '
        Me.bSTipo.DataMember = "dtTipo"
        Me.bSTipo.DataSource = Me.DS_agenda
        '
        'Ora_iDateTimePicker
        '
        Me.Ora_iDateTimePicker.CustomFormat = "HH:mm"
        Me.Ora_iDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_a, "ing", True))
        Me.Ora_iDateTimePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right
        Me.Ora_iDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Ora_iDateTimePicker.Location = New System.Drawing.Point(116, 290)
        Me.Ora_iDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ora_iDateTimePicker.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Ora_iDateTimePicker.Name = "Ora_iDateTimePicker"
        Me.Ora_iDateTimePicker.ShowUpDown = True
        Me.Ora_iDateTimePicker.Size = New System.Drawing.Size(77, 26)
        Me.Ora_iDateTimePicker.TabIndex = 5
        '
        'Ora_fDateTimePicker
        '
        Me.Ora_fDateTimePicker.CustomFormat = "HH:mm"
        Me.Ora_fDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_a, "usc", True))
        Me.Ora_fDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Ora_fDateTimePicker.Location = New System.Drawing.Point(289, 290)
        Me.Ora_fDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Ora_fDateTimePicker.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.Ora_fDateTimePicker.Name = "Ora_fDateTimePicker"
        Me.Ora_fDateTimePicker.ShowUpDown = True
        Me.Ora_fDateTimePicker.Size = New System.Drawing.Size(78, 26)
        Me.Ora_fDateTimePicker.TabIndex = 6
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_a, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(114, 415)
        Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(253, 26)
        Me.NoteTextBox.TabIndex = 10
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'TA_clienti
        '
        Me.TA_clienti.ClearBeforeFill = True
        '
        'TA_locazioni
        '
        Me.TA_locazioni.ClearBeforeFill = True
        '
        'DT_allaData
        '
        Me.DT_allaData.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_allaData.Location = New System.Drawing.Point(114, 451)
        Me.DT_allaData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DT_allaData.Name = "DT_allaData"
        Me.DT_allaData.Size = New System.Drawing.Size(112, 26)
        Me.DT_allaData.TabIndex = 11
        Me.DT_allaData.Visible = False
        '
        'BT_alla
        '
        Me.BT_alla.Appearance = System.Windows.Forms.Appearance.Button
        Me.BT_alla.AutoSize = True
        Me.BT_alla.Location = New System.Drawing.Point(42, 450)
        Me.BT_alla.Name = "BT_alla"
        Me.BT_alla.Size = New System.Drawing.Size(66, 30)
        Me.BT_alla.TabIndex = 10
        Me.BT_alla.Text = "Fino al"
        Me.BT_alla.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "off.png")
        Me.ImageList1.Images.SetKeyName(1, "on.png")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DG_orari, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_orariDip, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 541)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.247422!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.75258!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(851, 222)
        Me.TableLayoutPanel1.TabIndex = 29
        '
        'DG_orari
        '
        Me.DG_orari.AllowUserToAddRows = False
        Me.DG_orari.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_orari.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_orari.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_orari.AutoGenerateColumns = False
        Me.DG_orari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_orari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_orari.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DGCsocieta, Me.DGClocazione, Me.DGC1, Me.DGC2, Me.DGC3, Me.DGC4, Me.DGC5, Me.DGC6, Me.DGC7, Me.DGC8})
        Me.DG_orari.DataSource = Me.BS_relOrari
        Me.DG_orari.Location = New System.Drawing.Point(3, 21)
        Me.DG_orari.Name = "DG_orari"
        Me.DG_orari.ReadOnly = True
        Me.DG_orari.RowHeadersWidth = 4
        Me.DG_orari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_orari.Size = New System.Drawing.Size(845, 198)
        Me.DG_orari.TabIndex = 3
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn13.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "id"
        Me.DataGridViewTextBoxColumn13.MinimumWidth = 6
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'DGCsocieta
        '
        Me.DGCsocieta.DataPropertyName = "societa"
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGCsocieta.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGCsocieta.FillWeight = 15.0!
        Me.DGCsocieta.HeaderText = "societa"
        Me.DGCsocieta.MinimumWidth = 6
        Me.DGCsocieta.Name = "DGCsocieta"
        Me.DGCsocieta.ReadOnly = True
        '
        'DGClocazione
        '
        Me.DGClocazione.DataPropertyName = "locazione"
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DGClocazione.DefaultCellStyle = DataGridViewCellStyle3
        Me.DGClocazione.FillWeight = 20.0!
        Me.DGClocazione.HeaderText = "locazione"
        Me.DGClocazione.MinimumWidth = 6
        Me.DGClocazione.Name = "DGClocazione"
        Me.DGClocazione.ReadOnly = True
        '
        'DGC1
        '
        Me.DGC1.DataPropertyName = "T_lu"
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.Format = "t"
        DataGridViewCellStyle4.NullValue = " "
        Me.DGC1.DefaultCellStyle = DataGridViewCellStyle4
        Me.DGC1.FillWeight = 10.0!
        Me.DGC1.HeaderText = "Lun"
        Me.DGC1.MinimumWidth = 6
        Me.DGC1.Name = "DGC1"
        Me.DGC1.ReadOnly = True
        '
        'DGC2
        '
        Me.DGC2.DataPropertyName = "T_ma"
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle5.Format = "t"
        Me.DGC2.DefaultCellStyle = DataGridViewCellStyle5
        Me.DGC2.FillWeight = 10.0!
        Me.DGC2.HeaderText = "Mar"
        Me.DGC2.MinimumWidth = 6
        Me.DGC2.Name = "DGC2"
        Me.DGC2.ReadOnly = True
        '
        'DGC3
        '
        Me.DGC3.DataPropertyName = "T_me"
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle6.Format = "t"
        Me.DGC3.DefaultCellStyle = DataGridViewCellStyle6
        Me.DGC3.FillWeight = 10.0!
        Me.DGC3.HeaderText = "Mer"
        Me.DGC3.MinimumWidth = 6
        Me.DGC3.Name = "DGC3"
        Me.DGC3.ReadOnly = True
        '
        'DGC4
        '
        Me.DGC4.DataPropertyName = "T_gi"
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle7.Format = "t"
        Me.DGC4.DefaultCellStyle = DataGridViewCellStyle7
        Me.DGC4.FillWeight = 10.0!
        Me.DGC4.HeaderText = "Gio"
        Me.DGC4.MinimumWidth = 6
        Me.DGC4.Name = "DGC4"
        Me.DGC4.ReadOnly = True
        '
        'DGC5
        '
        Me.DGC5.DataPropertyName = "T_ve"
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle8.Format = "t"
        Me.DGC5.DefaultCellStyle = DataGridViewCellStyle8
        Me.DGC5.FillWeight = 10.0!
        Me.DGC5.HeaderText = "Ven"
        Me.DGC5.MinimumWidth = 6
        Me.DGC5.Name = "DGC5"
        Me.DGC5.ReadOnly = True
        '
        'DGC6
        '
        Me.DGC6.DataPropertyName = "T_sa"
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle9.Format = "t"
        Me.DGC6.DefaultCellStyle = DataGridViewCellStyle9
        Me.DGC6.FillWeight = 10.0!
        Me.DGC6.HeaderText = "Sab"
        Me.DGC6.MinimumWidth = 6
        Me.DGC6.Name = "DGC6"
        Me.DGC6.ReadOnly = True
        '
        'DGC7
        '
        Me.DGC7.DataPropertyName = "T_do"
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        DataGridViewCellStyle10.Format = "t"
        Me.DGC7.DefaultCellStyle = DataGridViewCellStyle10
        Me.DGC7.FillWeight = 10.0!
        Me.DGC7.HeaderText = "Dom"
        Me.DGC7.MinimumWidth = 6
        Me.DGC7.Name = "DGC7"
        Me.DGC7.ReadOnly = True
        '
        'DGC8
        '
        Me.DGC8.DataPropertyName = "T_set"
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.Format = "t"
        Me.DGC8.DefaultCellStyle = DataGridViewCellStyle11
        Me.DGC8.FillWeight = 12.0!
        Me.DGC8.HeaderText = "Tot"
        Me.DGC8.MinimumWidth = 6
        Me.DGC8.Name = "DGC8"
        Me.DGC8.ReadOnly = True
        '
        'BS_relOrari
        '
        Me.BS_relOrari.DataMember = "DT_orari"
        Me.BS_relOrari.DataSource = Me.DS_agenda
        '
        'LB_orariDip
        '
        Me.LB_orariDip.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_orariDip.AutoSize = True
        Me.LB_orariDip.Location = New System.Drawing.Point(3, 0)
        Me.LB_orariDip.Name = "LB_orariDip"
        Me.LB_orariDip.Size = New System.Drawing.Size(845, 18)
        Me.LB_orariDip.TabIndex = 173
        Me.LB_orariDip.Text = "Clicca con il tasto CTRL per segnare più orari della stessa giornata"
        Me.LB_orariDip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TA_orari
        '
        Me.TA_orari.ClearBeforeFill = True
        '
        'TAsostituzioni
        '
        Me.TAsostituzioni.ClearBeforeFill = True
        '
        'DGorarisostituto
        '
        Me.DGorarisostituto.AllowUserToAddRows = False
        Me.DGorarisostituto.AllowUserToDeleteRows = False
        Me.DGorarisostituto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGorarisostituto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGorarisostituto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGorarisostituto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colCantiere, Me.colInizio, Me.colFine, Me.colTipo})
        Me.DGorarisostituto.Location = New System.Drawing.Point(6, 20)
        Me.DGorarisostituto.Name = "DGorarisostituto"
        Me.DGorarisostituto.ReadOnly = True
        Me.DGorarisostituto.RowHeadersVisible = False
        Me.DGorarisostituto.Size = New System.Drawing.Size(440, 285)
        Me.DGorarisostituto.TabIndex = 30
        '
        'colCantiere
        '
        Me.colCantiere.HeaderText = "Dettaglio"
        Me.colCantiere.Name = "colCantiere"
        Me.colCantiere.ReadOnly = True
        '
        'colInizio
        '
        Me.colInizio.FillWeight = 40.0!
        Me.colInizio.HeaderText = "Inizio"
        Me.colInizio.Name = "colInizio"
        Me.colInizio.ReadOnly = True
        '
        'colFine
        '
        Me.colFine.FillWeight = 40.0!
        Me.colFine.HeaderText = "Fine"
        Me.colFine.Name = "colFine"
        Me.colFine.ReadOnly = True
        '
        'colTipo
        '
        Me.colTipo.FillWeight = 30.0!
        Me.colTipo.HeaderText = "Tipo"
        Me.colTipo.Name = "colTipo"
        Me.colTipo.ReadOnly = True
        '
        'GRorarisostituto
        '
        Me.GRorarisostituto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GRorarisostituto.Controls.Add(Me.DGorarisostituto)
        Me.GRorarisostituto.Location = New System.Drawing.Point(392, 6)
        Me.GRorarisostituto.Name = "GRorarisostituto"
        Me.GRorarisostituto.Size = New System.Drawing.Size(447, 311)
        Me.GRorarisostituto.TabIndex = 31
        Me.GRorarisostituto.TabStop = False
        Me.GRorarisostituto.Text = "Visualizza impegni SOSTITUTO"
        '
        'btElaboratantigiorni
        '
        Me.btElaboratantigiorni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btElaboratantigiorni.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btElaboratantigiorni.Location = New System.Drawing.Point(113, 485)
        Me.btElaboratantigiorni.Name = "btElaboratantigiorni"
        Me.btElaboratantigiorni.Size = New System.Drawing.Size(118, 34)
        Me.btElaboratantigiorni.TabIndex = 10
        Me.btElaboratantigiorni.Text = "Genera"
        Me.btElaboratantigiorni.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTipAgenda.SetToolTip(Me.btElaboratantigiorni, "Genera i dati per più giorni di lavoro")
        Me.btElaboratantigiorni.UseVisualStyleBackColor = True
        Me.btElaboratantigiorni.Visible = False
        '
        'LWperiodo
        '
        Me.LWperiodo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LWperiodo.HideSelection = False
        Me.LWperiodo.Location = New System.Drawing.Point(396, 323)
        Me.LWperiodo.Name = "LWperiodo"
        Me.LWperiodo.Size = New System.Drawing.Size(443, 148)
        Me.LWperiodo.TabIndex = 33
        Me.LWperiodo.UseCompatibleStateImageBehavior = False
        '
        'btMemorizzaDati
        '
        Me.btMemorizzaDati.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btMemorizzaDati.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btMemorizzaDati.Location = New System.Drawing.Point(237, 485)
        Me.btMemorizzaDati.Name = "btMemorizzaDati"
        Me.btMemorizzaDati.Size = New System.Drawing.Size(132, 34)
        Me.btMemorizzaDati.TabIndex = 11
        Me.btMemorizzaDati.Text = "Memorizza i dati"
        Me.btMemorizzaDati.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTipAgenda.SetToolTip(Me.btMemorizzaDati, "Memorizza i dati generati per più giorni di lavoro")
        Me.btMemorizzaDati.UseVisualStyleBackColor = True
        Me.btMemorizzaDati.Visible = False
        '
        'TXricercautente
        '
        Me.TXricercautente.Location = New System.Drawing.Point(116, 44)
        Me.TXricercautente.Name = "TXricercautente"
        Me.TXricercautente.Size = New System.Drawing.Size(165, 26)
        Me.TXricercautente.TabIndex = 1
        '
        'bsOrario
        '
        Me.bsOrario.DataMember = "DT_orari"
        Me.bsOrario.DataSource = Me.DS_agenda
        '
        'ToolTipAgenda
        '
        Me.ToolTipAgenda.IsBalloon = True
        Me.ToolTipAgenda.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'ckDefinitivo
        '
        Me.ckDefinitivo.Appearance = System.Windows.Forms.Appearance.Button
        Me.ckDefinitivo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ckDefinitivo.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.BS_a, "idconferma", True))
        Me.ckDefinitivo.FlatAppearance.BorderSize = 0
        Me.ckDefinitivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ckDefinitivo.ImageKey = "omino_no.png"
        Me.ckDefinitivo.ImageList = Me.img60px
        Me.ckDefinitivo.Location = New System.Drawing.Point(59, 78)
        Me.ckDefinitivo.Name = "ckDefinitivo"
        Me.ckDefinitivo.Size = New System.Drawing.Size(38, 51)
        Me.ckDefinitivo.TabIndex = 35
        Me.ckDefinitivo.UseVisualStyleBackColor = True
        '
        'img60px
        '
        Me.img60px.ImageStream = CType(resources.GetObject("img60px.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.img60px.TransparentColor = System.Drawing.Color.Transparent
        Me.img60px.Images.SetKeyName(0, "omino_no.png")
        Me.img60px.Images.SetKeyName(1, "confermato.png")
        '
        'TaTipo
        '
        Me.TaTipo.ClearBeforeFill = True
        '
        'CB_utenteA
        '
        Me.CB_utenteA.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_a, "idsost", True))
        Me.CB_utenteA.DataSource = Me.BS_utentiA
        Me.CB_utenteA.DisplayMember = "anagrafica"
        Me.CB_utenteA.FormattingEnabled = True
        Me.CB_utenteA.ItemHeight = 20
        Me.CB_utenteA.Location = New System.Drawing.Point(115, 76)
        Me.CB_utenteA.Name = "CB_utenteA"
        Me.CB_utenteA.Size = New System.Drawing.Size(254, 84)
        Me.CB_utenteA.TabIndex = 2
        Me.CB_utenteA.ValueMember = "id"
        '
        'CB_utenteB
        '
        Me.CB_utenteB.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_a, "iddip", True))
        Me.CB_utenteB.DataSource = Me.BS_utentiB
        Me.CB_utenteB.DisplayMember = "anagrafica"
        Me.CB_utenteB.FormattingEnabled = True
        Me.CB_utenteB.ItemHeight = 20
        Me.CB_utenteB.Location = New System.Drawing.Point(115, 198)
        Me.CB_utenteB.Name = "CB_utenteB"
        Me.CB_utenteB.Size = New System.Drawing.Size(254, 84)
        Me.CB_utenteB.TabIndex = 4
        Me.CB_utenteB.ValueMember = "id"
        '
        'TXricercasostituto
        '
        Me.TXricercasostituto.Location = New System.Drawing.Point(116, 166)
        Me.TXricercasostituto.Name = "TXricercasostituto"
        Me.TXricercasostituto.Size = New System.Drawing.Size(165, 26)
        Me.TXricercasostituto.TabIndex = 3
        '
        'lbSostituto
        '
        Me.lbSostituto.AutoSize = True
        Me.lbSostituto.Location = New System.Drawing.Point(35, 166)
        Me.lbSostituto.Name = "lbSostituto"
        Me.lbSostituto.Size = New System.Drawing.Size(73, 20)
        Me.lbSostituto.TabIndex = 36
        Me.lbSostituto.Text = "Sostituto"
        '
        'FrmAgendaModifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 829)
        Me.Controls.Add(Me.lbSostituto)
        Me.Controls.Add(Me.CB_utenteB)
        Me.Controls.Add(Me.TXricercasostituto)
        Me.Controls.Add(Me.CB_utenteA)
        Me.Controls.Add(Me.ckDefinitivo)
        Me.Controls.Add(Me.TXricercautente)
        Me.Controls.Add(Me.btMemorizzaDati)
        Me.Controls.Add(Me.LWperiodo)
        Me.Controls.Add(Me.btElaboratantigiorni)
        Me.Controls.Add(Me.GRorarisostituto)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BT_alla)
        Me.Controls.Add(Me.DT_allaData)
        Me.Controls.Add(DataeventoLabel)
        Me.Controls.Add(Me.DT_dallaData)
        Me.Controls.Add(Id_dip_aLabel)
        Me.Controls.Add(Id_cliLabel)
        Me.Controls.Add(Me.CB_clienti)
        Me.Controls.Add(Id_desLabel)
        Me.Controls.Add(Me.CB_locazioni)
        Me.Controls.Add(Id_tipoLabel)
        Me.Controls.Add(Me.CB_tipo)
        Me.Controls.Add(Ora_iLabel)
        Me.Controls.Add(Me.Ora_iDateTimePicker)
        Me.Controls.Add(Ora_fLabel)
        Me.Controls.Add(Me.Ora_fDateTimePicker)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Me.BN_navigazione)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmAgendaModifica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aggiornamento Agenda"
        CType(Me.DS_agenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BN_navigazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BN_navigazione.ResumeLayout(False)
        Me.BN_navigazione.PerformLayout()
        CType(Me.BS_a, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_utentiA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_utentiB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_R_locazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bSTipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DG_orari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_relOrari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGorarisostituto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRorarisostituto.ResumeLayout(False)
        CType(Me.bsOrario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_agenda As DS_ag
    Friend WithEvents TableAdapterManager As DS_agTableAdapters.TableAdapterManager
    Friend WithEvents BN_navigazione As BindingNavigator
    Friend WithEvents TT_aggiunge As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents TT_elimina As ToolStripButton
    Friend WithEvents TT_inizio As ToolStripButton
    Friend WithEvents TT_prima As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents TT_dopo As ToolStripButton
    Friend WithEvents TT_ultimo As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TT_salva As ToolStripButton
    Friend WithEvents DT_dallaData As DateTimePicker
    Friend WithEvents CB_clienti As ComboBox
    Friend WithEvents CB_locazioni As ComboBox
    Friend WithEvents CB_tipo As ComboBox
    Friend WithEvents Ora_iDateTimePicker As DateTimePicker
    Friend WithEvents Ora_fDateTimePicker As DateTimePicker
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents BS_utentiA As BindingSource
    Friend WithEvents TA_utenti As DS_agTableAdapters.TA_utenti
    Friend WithEvents BS_clienti As BindingSource
    Friend WithEvents TA_clienti As DS_agTableAdapters.TA_clienti
    Friend WithEvents BS_R_locazioni As BindingSource
    Friend WithEvents TA_locazioni As DS_agTableAdapters.TA_locazioni
    Friend WithEvents BS_utentiB As BindingSource
    Friend WithEvents DT_allaData As DateTimePicker
    Friend WithEvents BT_alla As CheckBox
    Friend WithEvents BS_a As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents BS_relOrari As BindingSource
    Friend WithEvents TA_orari As DS_agTableAdapters.TA_orari
    Friend WithEvents DG_orari As DataGridView
    Friend WithEvents LB_orariDip As Label
    Friend WithEvents TAsostituzioni As DS_agTableAdapters.TAsostituzioni
    Friend WithEvents DGorarisostituto As DataGridView
    Friend WithEvents GRorarisostituto As GroupBox
    Friend WithEvents colCantiere As DataGridViewTextBoxColumn
    Friend WithEvents colInizio As DataGridViewTextBoxColumn
    Friend WithEvents colFine As DataGridViewTextBoxColumn
    Friend WithEvents colTipo As DataGridViewTextBoxColumn
    Friend WithEvents btElaboratantigiorni As Button
    Friend WithEvents LWperiodo As ListView
    Friend WithEvents btMemorizzaDati As Button
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DGCsocieta As DataGridViewTextBoxColumn
    Friend WithEvents DGClocazione As DataGridViewTextBoxColumn
    Friend WithEvents DGC1 As DataGridViewTextBoxColumn
    Friend WithEvents DGC2 As DataGridViewTextBoxColumn
    Friend WithEvents DGC3 As DataGridViewTextBoxColumn
    Friend WithEvents DGC4 As DataGridViewTextBoxColumn
    Friend WithEvents DGC5 As DataGridViewTextBoxColumn
    Friend WithEvents DGC6 As DataGridViewTextBoxColumn
    Friend WithEvents DGC7 As DataGridViewTextBoxColumn
    Friend WithEvents DGC8 As DataGridViewTextBoxColumn
    Friend WithEvents TXricercautente As TextBox
    Friend WithEvents bsOrario As BindingSource
    Friend WithEvents TTBTtermina As ToolStripButton
    Friend WithEvents ToolTipAgenda As ToolTip
    Friend WithEvents ckDefinitivo As CheckBox
    Friend WithEvents img60px As ImageList
    Friend WithEvents bSTipo As BindingSource
    Friend WithEvents TaTipo As DS_agTableAdapters.taTipo
    Friend WithEvents CB_utenteA As ListBox
    Friend WithEvents CB_utenteB As ListBox
    Friend WithEvents TXricercasostituto As TextBox
    Friend WithEvents lbSostituto As Label
End Class
