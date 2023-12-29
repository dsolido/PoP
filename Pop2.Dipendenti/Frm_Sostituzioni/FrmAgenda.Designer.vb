<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAgenda
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAgenda))
        Me.DG_settimana = New System.Windows.Forms.DataGridView()
        Me.C_ora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Lun = New DataGridViewRichTextBox.DataGridViewRichTextBoxColumn()
        Me.C_Mar = New DataGridViewRichTextBox.DataGridViewRichTextBoxColumn()
        Me.C_Mer = New DataGridViewRichTextBox.DataGridViewRichTextBoxColumn()
        Me.C_Gio = New DataGridViewRichTextBox.DataGridViewRichTextBoxColumn()
        Me.C_Ven = New DataGridViewRichTextBox.DataGridViewRichTextBoxColumn()
        Me.C_Sab = New DataGridViewRichTextBox.DataGridViewRichTextBoxColumn()
        Me.C_Dom = New DataGridViewRichTextBox.DataGridViewRichTextBoxColumn()
        Me.BarraAgenda = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BT_Day_7 = New System.Windows.Forms.ToolStripButton()
        Me.BT_Day_1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTLB_informazioni = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BT_Day1 = New System.Windows.Forms.ToolStripButton()
        Me.BT_Day7 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.TTTS_oggiora = New System.Windows.Forms.ToolStripMenuItem()
        Me.TTTS_oggilunedi = New System.Windows.Forms.ToolStripMenuItem()
        Me.TTBT_oggi = New System.Windows.Forms.ToolStripButton()
        Me.TTBT_aggiorna = New System.Windows.Forms.ToolStripButton()
        Me.TT_Giorno = New System.Windows.Forms.ToolStripButton()
        Me.BS_locazioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_clienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_agenda = New PoP2.Comuni.DS_ag()
        Me.DG_giorno = New System.Windows.Forms.DataGridView()
        Me.CC_ora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Assente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_sostituto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_locazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LB_agendagiornaliera = New System.Windows.Forms.Label()
        Me.LB_agendasettimanale = New System.Windows.Forms.Label()
        Me.BS_utenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_tipo = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New PoP2.Comuni.DS_agTableAdapters.TableAdapterManager()
        Me.TA_utenti = New PoP2.Comuni.DS_agTableAdapters.TA_utenti()
        Me.TA_clienti = New PoP2.Comuni.DS_agTableAdapters.TA_clienti()
        Me.TAtipo = New PoP2.Comuni.DS_agTableAdapters.taTipo()
        Me.TA_locazioni = New PoP2.Comuni.DS_agTableAdapters.TA_locazioni()
        Me.bsSostituzioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAsostituzioni = New PoP2.Comuni.DS_agTableAdapters.TAsostituzioni()
        CType(Me.DG_settimana, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarraAgenda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BarraAgenda.SuspendLayout()
        CType(Me.BS_locazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_giorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsSostituzioni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_settimana
        '
        Me.DG_settimana.AllowUserToAddRows = False
        Me.DG_settimana.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DG_settimana.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_settimana.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_settimana.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_settimana.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_settimana.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_ora, Me.C_Lun, Me.C_Mar, Me.C_Mer, Me.C_Gio, Me.C_Ven, Me.C_Sab, Me.C_Dom})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Courier New", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_settimana.DefaultCellStyle = DataGridViewCellStyle3
        Me.DG_settimana.Location = New System.Drawing.Point(1, 26)
        Me.DG_settimana.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_settimana.Name = "DG_settimana"
        Me.DG_settimana.ReadOnly = True
        Me.DG_settimana.RowHeadersWidth = 40
        Me.DG_settimana.RowTemplate.Height = 15
        Me.DG_settimana.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_settimana.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DG_settimana.Size = New System.Drawing.Size(1185, 500)
        Me.DG_settimana.TabIndex = 191
        '
        'C_ora
        '
        Me.C_ora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.C_ora.FillWeight = 40.0!
        Me.C_ora.Frozen = True
        Me.C_ora.HeaderText = "ore"
        Me.C_ora.MinimumWidth = 40
        Me.C_ora.Name = "C_ora"
        Me.C_ora.ReadOnly = True
        Me.C_ora.Width = 54
        '
        'C_Lun
        '
        Me.C_Lun.HeaderText = "Lunedì"
        Me.C_Lun.MinimumWidth = 10
        Me.C_Lun.Name = "C_Lun"
        Me.C_Lun.ReadOnly = True
        '
        'C_Mar
        '
        Me.C_Mar.HeaderText = "Martedì"
        Me.C_Mar.MinimumWidth = 10
        Me.C_Mar.Name = "C_Mar"
        Me.C_Mar.ReadOnly = True
        '
        'C_Mer
        '
        Me.C_Mer.HeaderText = "Mercoledì"
        Me.C_Mer.MinimumWidth = 10
        Me.C_Mer.Name = "C_Mer"
        Me.C_Mer.ReadOnly = True
        '
        'C_Gio
        '
        Me.C_Gio.HeaderText = "Giovedì"
        Me.C_Gio.MinimumWidth = 10
        Me.C_Gio.Name = "C_Gio"
        Me.C_Gio.ReadOnly = True
        '
        'C_Ven
        '
        Me.C_Ven.HeaderText = "Venerdì"
        Me.C_Ven.MinimumWidth = 10
        Me.C_Ven.Name = "C_Ven"
        Me.C_Ven.ReadOnly = True
        '
        'C_Sab
        '
        Me.C_Sab.HeaderText = "Sabato"
        Me.C_Sab.MinimumWidth = 10
        Me.C_Sab.Name = "C_Sab"
        Me.C_Sab.ReadOnly = True
        '
        'C_Dom
        '
        Me.C_Dom.FillWeight = 50.0!
        Me.C_Dom.HeaderText = "Domenica"
        Me.C_Dom.MinimumWidth = 10
        Me.C_Dom.Name = "C_Dom"
        Me.C_Dom.ReadOnly = True
        '
        'BarraAgenda
        '
        Me.BarraAgenda.AddNewItem = Nothing
        Me.BarraAgenda.CountItem = Nothing
        Me.BarraAgenda.DeleteItem = Nothing
        Me.BarraAgenda.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.BarraAgenda.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.BarraAgenda.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BT_Day_7, Me.BT_Day_1, Me.ToolStripSeparator1, Me.TTLB_informazioni, Me.BindingNavigatorSeparator2, Me.BT_Day1, Me.BT_Day7, Me.ToolStripSplitButton1, Me.TTBT_oggi, Me.TTBT_aggiorna, Me.TT_Giorno})
        Me.BarraAgenda.Location = New System.Drawing.Point(0, 0)
        Me.BarraAgenda.MoveFirstItem = Nothing
        Me.BarraAgenda.MoveLastItem = Nothing
        Me.BarraAgenda.MoveNextItem = Nothing
        Me.BarraAgenda.MovePreviousItem = Nothing
        Me.BarraAgenda.Name = "BarraAgenda"
        Me.BarraAgenda.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.BarraAgenda.PositionItem = Nothing
        Me.BarraAgenda.Size = New System.Drawing.Size(1190, 55)
        Me.BarraAgenda.TabIndex = 192
        Me.BarraAgenda.Text = "BindingNavigator1"
        '
        'BT_Day_7
        '
        Me.BT_Day_7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_Day_7.Image = Global.PoP2.Comuni.My.Resources.Resources.freccia48sx
        Me.BT_Day_7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_Day_7.Name = "BT_Day_7"
        Me.BT_Day_7.RightToLeftAutoMirrorImage = True
        Me.BT_Day_7.Size = New System.Drawing.Size(52, 52)
        Me.BT_Day_7.Tag = "-7"
        Me.BT_Day_7.Text = "Sposta in prima posizione"
        Me.BT_Day_7.ToolTipText = "Settimana precedente"
        '
        'BT_Day_1
        '
        Me.BT_Day_1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_Day_1.Image = Global.PoP2.Comuni.My.Resources.Resources.freccia48sx
        Me.BT_Day_1.Name = "BT_Day_1"
        Me.BT_Day_1.RightToLeftAutoMirrorImage = True
        Me.BT_Day_1.Size = New System.Drawing.Size(36, 52)
        Me.BT_Day_1.Tag = "-1"
        Me.BT_Day_1.Text = "Sposta indietro"
        Me.BT_Day_1.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 55)
        '
        'TTLB_informazioni
        '
        Me.TTLB_informazioni.Name = "TTLB_informazioni"
        Me.TTLB_informazioni.Size = New System.Drawing.Size(87, 52)
        Me.TTLB_informazioni.Text = "Giorno"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 55)
        '
        'BT_Day1
        '
        Me.BT_Day1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_Day1.Image = Global.PoP2.Comuni.My.Resources.Resources.freccia48dx
        Me.BT_Day1.Name = "BT_Day1"
        Me.BT_Day1.RightToLeftAutoMirrorImage = True
        Me.BT_Day1.Size = New System.Drawing.Size(36, 52)
        Me.BT_Day1.Tag = "1"
        Me.BT_Day1.Text = "Sposta avanti"
        Me.BT_Day1.Visible = False
        '
        'BT_Day7
        '
        Me.BT_Day7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BT_Day7.Image = Global.PoP2.Comuni.My.Resources.Resources.freccia48dx
        Me.BT_Day7.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BT_Day7.Name = "BT_Day7"
        Me.BT_Day7.RightToLeftAutoMirrorImage = True
        Me.BT_Day7.Size = New System.Drawing.Size(52, 52)
        Me.BT_Day7.Tag = "7"
        Me.BT_Day7.Text = "Sposta in ultima posizione"
        Me.BT_Day7.ToolTipText = "Settimana prossima"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTS_oggiora, Me.TTTS_oggilunedi})
        Me.ToolStripSplitButton1.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_presenze48
        Me.ToolStripSplitButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(64, 52)
        Me.ToolStripSplitButton1.Text = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.ToolTipText = "Impostazioni"
        '
        'TTTS_oggiora
        '
        Me.TTTS_oggiora.Name = "TTTS_oggiora"
        Me.TTTS_oggiora.Size = New System.Drawing.Size(397, 36)
        Me.TTTS_oggiora.Tag = "1"
        Me.TTTS_oggiora.Text = "Primo giorno Agenda OGGI"
        '
        'TTTS_oggilunedi
        '
        Me.TTTS_oggilunedi.Name = "TTTS_oggilunedi"
        Me.TTTS_oggilunedi.Size = New System.Drawing.Size(397, 36)
        Me.TTTS_oggilunedi.Tag = "2"
        Me.TTTS_oggilunedi.Text = "Primo giorno Agenda Lunedì"
        '
        'TTBT_oggi
        '
        Me.TTBT_oggi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.TTBT_oggi.Image = Global.PoP2.Comuni.My.Resources.Resources.omino48ditosu
        Me.TTBT_oggi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBT_oggi.Name = "TTBT_oggi"
        Me.TTBT_oggi.Size = New System.Drawing.Size(71, 52)
        Me.TTBT_oggi.Text = "Oggi"
        '
        'TTBT_aggiorna
        '
        Me.TTBT_aggiorna.Image = Global.PoP2.Comuni.My.Resources.Resources.allerta48
        Me.TTBT_aggiorna.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBT_aggiorna.Name = "TTBT_aggiorna"
        Me.TTBT_aggiorna.Size = New System.Drawing.Size(52, 52)
        Me.TTBT_aggiorna.ToolTipText = "Ricarica Agenda"
        '
        'TT_Giorno
        '
        Me.TT_Giorno.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TT_Giorno.Image = Global.PoP2.Comuni.My.Resources.Resources.omino48agenda
        Me.TT_Giorno.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TT_Giorno.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TT_Giorno.Name = "TT_Giorno"
        Me.TT_Giorno.Size = New System.Drawing.Size(52, 52)
        Me.TT_Giorno.Text = "ToolStripButton1"
        Me.TT_Giorno.ToolTipText = "Apre agenda giornaliera"
        '
        'BS_locazioni
        '
        Me.BS_locazioni.DataMember = "clienti_R_locazioni"
        Me.BS_locazioni.DataSource = Me.BS_clienti
        '
        'BS_clienti
        '
        Me.BS_clienti.DataMember = "DT_clienti"
        Me.BS_clienti.DataSource = Me.DS_agenda
        '
        'DS_agenda
        '
        Me.DS_agenda.DataSetName = "DS_ag"
        Me.DS_agenda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DG_giorno
        '
        Me.DG_giorno.AllowUserToAddRows = False
        Me.DG_giorno.AllowUserToDeleteRows = False
        Me.DG_giorno.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_giorno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_giorno.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DG_giorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_giorno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CC_ora, Me.C_Assente, Me.C_sostituto, Me.C_cliente, Me.C_locazione, Me.C_tipo, Me.C_note, Me.C_ID})
        Me.DG_giorno.Location = New System.Drawing.Point(1, 552)
        Me.DG_giorno.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_giorno.Name = "DG_giorno"
        Me.DG_giorno.ReadOnly = True
        Me.DG_giorno.RowHeadersWidth = 4
        Me.DG_giorno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_giorno.Size = New System.Drawing.Size(1185, 98)
        Me.DG_giorno.TabIndex = 196
        '
        'CC_ora
        '
        Me.CC_ora.FillWeight = 20.0!
        Me.CC_ora.HeaderText = "Ora"
        Me.CC_ora.Name = "CC_ora"
        Me.CC_ora.ReadOnly = True
        '
        'C_Assente
        '
        Me.C_Assente.FillWeight = 50.0!
        Me.C_Assente.HeaderText = "Assente"
        Me.C_Assente.Name = "C_Assente"
        Me.C_Assente.ReadOnly = True
        '
        'C_sostituto
        '
        Me.C_sostituto.FillWeight = 50.0!
        Me.C_sostituto.HeaderText = "Sostituzione"
        Me.C_sostituto.Name = "C_sostituto"
        Me.C_sostituto.ReadOnly = True
        '
        'C_cliente
        '
        Me.C_cliente.FillWeight = 50.0!
        Me.C_cliente.HeaderText = "Cantiere"
        Me.C_cliente.Name = "C_cliente"
        Me.C_cliente.ReadOnly = True
        '
        'C_locazione
        '
        Me.C_locazione.FillWeight = 50.0!
        Me.C_locazione.HeaderText = "Destinatario"
        Me.C_locazione.Name = "C_locazione"
        Me.C_locazione.ReadOnly = True
        '
        'C_tipo
        '
        Me.C_tipo.FillWeight = 30.0!
        Me.C_tipo.HeaderText = "Tipo"
        Me.C_tipo.Name = "C_tipo"
        Me.C_tipo.ReadOnly = True
        '
        'C_note
        '
        Me.C_note.FillWeight = 30.0!
        Me.C_note.HeaderText = "Note"
        Me.C_note.Name = "C_note"
        Me.C_note.ReadOnly = True
        '
        'C_ID
        '
        Me.C_ID.HeaderText = "identificativo"
        Me.C_ID.Name = "C_ID"
        Me.C_ID.ReadOnly = True
        Me.C_ID.Visible = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.6609!))
        Me.TableLayoutPanel1.Controls.Add(Me.LB_agendagiornaliera, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.LB_agendasettimanale, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_giorno, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_settimana, 0, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 58)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1187, 651)
        Me.TableLayoutPanel1.TabIndex = 197
        '
        'LB_agendagiornaliera
        '
        Me.LB_agendagiornaliera.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_agendagiornaliera.AutoSize = True
        Me.LB_agendagiornaliera.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.LB_agendagiornaliera.Location = New System.Drawing.Point(3, 527)
        Me.LB_agendagiornaliera.Name = "LB_agendagiornaliera"
        Me.LB_agendagiornaliera.Size = New System.Drawing.Size(1181, 24)
        Me.LB_agendagiornaliera.TabIndex = 200
        Me.LB_agendagiornaliera.Text = "Agenda Giornaliera"
        Me.LB_agendagiornaliera.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LB_agendasettimanale
        '
        Me.LB_agendasettimanale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_agendasettimanale.AutoSize = True
        Me.LB_agendasettimanale.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.LB_agendasettimanale.Location = New System.Drawing.Point(3, 0)
        Me.LB_agendasettimanale.Name = "LB_agendasettimanale"
        Me.LB_agendasettimanale.Size = New System.Drawing.Size(1181, 25)
        Me.LB_agendasettimanale.TabIndex = 199
        Me.LB_agendasettimanale.Text = "Agenda Settimanale"
        Me.LB_agendasettimanale.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BS_utenti
        '
        Me.BS_utenti.DataMember = "DT_utenti"
        Me.BS_utenti.DataSource = Me.DS_agenda
        '
        'BS_tipo
        '
        Me.BS_tipo.DataMember = "DT_tipo"
        Me.BS_tipo.DataSource = Me.DS_agenda
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_agTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'TA_clienti
        '
        Me.TA_clienti.ClearBeforeFill = True
        '
        'TA_tipo
        '
        Me.TAtipo.ClearBeforeFill = True
        '
        'TA_locazioni
        '
        Me.TA_locazioni.ClearBeforeFill = True
        '
        'bsSostituzioni
        '
        Me.bsSostituzioni.DataMember = "DTsostituzioni"
        Me.bsSostituzioni.DataSource = Me.DS_agenda
        '
        'TAsostituzioni
        '
        Me.TAsostituzioni.ClearBeforeFill = True
        '
        'FrmAgenda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1190, 711)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BarraAgenda)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmAgenda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DG_settimana, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarraAgenda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BarraAgenda.ResumeLayout(False)
        Me.BarraAgenda.PerformLayout()
        CType(Me.BS_locazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_agenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_giorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsSostituzioni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS_agenda As DS_ag
    Friend WithEvents TableAdapterManager As DS_agTableAdapters.TableAdapterManager
    Friend WithEvents BS_utenti As BindingSource
    Friend WithEvents TA_utenti As DS_agTableAdapters.TA_utenti
    Friend WithEvents TA_clienti As DS_agTableAdapters.TA_clienti
    Friend WithEvents BS_tipo As BindingSource
    Friend WithEvents TAtipo As DS_agTableAdapters.taTipo
    Friend WithEvents BS_clienti As BindingSource
    Friend WithEvents TA_locazioni As DS_agTableAdapters.TA_locazioni
    Friend WithEvents BS_locazioni As BindingSource
    Friend WithEvents DG_settimana As DataGridView
    Friend WithEvents BarraAgenda As BindingNavigator
    Friend WithEvents BT_Day_7 As ToolStripButton
    Friend WithEvents BT_Day_1 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents TTLB_informazioni As ToolStripLabel
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BT_Day1 As ToolStripButton
    Friend WithEvents BT_Day7 As ToolStripButton
    Friend WithEvents TTBT_oggi As ToolStripButton
    Friend WithEvents ToolStripSplitButton1 As ToolStripSplitButton
    Friend WithEvents TTTS_oggiora As ToolStripMenuItem
    Friend WithEvents TTTS_oggilunedi As ToolStripMenuItem
    Friend WithEvents TTBT_aggiorna As ToolStripButton
    Friend WithEvents TT_Giorno As ToolStripButton
    Friend WithEvents DG_giorno As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents CC_ora As DataGridViewTextBoxColumn
    Friend WithEvents C_Assente As DataGridViewTextBoxColumn
    Friend WithEvents C_sostituto As DataGridViewTextBoxColumn
    Friend WithEvents C_cliente As DataGridViewTextBoxColumn
    Friend WithEvents C_locazione As DataGridViewTextBoxColumn
    Friend WithEvents C_tipo As DataGridViewTextBoxColumn
    Friend WithEvents C_note As DataGridViewTextBoxColumn
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
    Friend WithEvents LB_agendagiornaliera As Label
    Friend WithEvents LB_agendasettimanale As Label
    Friend WithEvents bsSostituzioni As BindingSource
    Friend WithEvents TAsostituzioni As DS_agTableAdapters.TAsostituzioni
    Friend WithEvents C_ora As DataGridViewTextBoxColumn
    Friend WithEvents C_Lun As DataGridViewRichTextBox.DataGridViewRichTextBoxColumn
    Friend WithEvents C_Mar As DataGridViewRichTextBox.DataGridViewRichTextBoxColumn
    Friend WithEvents C_Mer As DataGridViewRichTextBox.DataGridViewRichTextBoxColumn
    Friend WithEvents C_Gio As DataGridViewRichTextBox.DataGridViewRichTextBoxColumn
    Friend WithEvents C_Ven As DataGridViewRichTextBox.DataGridViewRichTextBoxColumn
    Friend WithEvents C_Sab As DataGridViewRichTextBox.DataGridViewRichTextBoxColumn
    Friend WithEvents C_Dom As DataGridViewRichTextBox.DataGridViewRichTextBoxColumn
End Class
