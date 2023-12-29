<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_fatture_scadenze
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_fatture_scadenze))
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
        Me.DT_clienti_scadenzeDataGridView = New System.Windows.Forms.DataGridView()
        Me.BS_clienti_scadenze = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contabilita = New PoP2.Comuni.DS_contabilita()
        Me.GB_filtra = New System.Windows.Forms.GroupBox()
        Me.RB_perdita = New System.Windows.Forms.RadioButton()
        Me.RB_tutte = New System.Windows.Forms.RadioButton()
        Me.RB_in = New System.Windows.Forms.RadioButton()
        Me.RB_im = New System.Windows.Forms.RadioButton()
        Me.TT_informazioni = New System.Windows.Forms.ToolTip(Me.components)
        Me.TS_TabStrip = New System.Windows.Forms.ToolStrip()
        Me.TS_LB_totali = New System.Windows.Forms.ToolStripLabel()
        Me.TS_LB_totale = New System.Windows.Forms.ToolStripLabel()
        Me.TS_LB_pagato = New System.Windows.Forms.ToolStripLabel()
        Me.TS_LB_differenza = New System.Windows.Forms.ToolStripLabel()
        Me.TS_LB_GranTotale = New System.Windows.Forms.ToolStripLabel()
        Me.TA_clienti_scadenze = New PoP2.Comuni.DS_contabilitaTableAdapters.TA_clienti_scadenze()
        Me.TableAdapterManager = New PoP2.Comuni.DS_contabilitaTableAdapters.TableAdapterManager()
        Me.DT_v_ordiniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TTPB_stampa = New System.Windows.Forms.ToolStripProgressBar()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fat_scad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COLpagatonote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_BT_Pagato = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGfat_pa_fallimento = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CFat_id_cli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFat_Ivato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_SC_netto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CFat_pagato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DT_clienti_scadenzeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti_scadenze, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contabilita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GB_filtra.SuspendLayout()
        Me.TS_TabStrip.SuspendLayout()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_v_ordiniBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'DT_clienti_scadenzeDataGridView
        '
        Me.DT_clienti_scadenzeDataGridView.AllowUserToAddRows = False
        Me.DT_clienti_scadenzeDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DT_clienti_scadenzeDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DT_clienti_scadenzeDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DT_clienti_scadenzeDataGridView.AutoGenerateColumns = False
        Me.DT_clienti_scadenzeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DT_clienti_scadenzeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DT_clienti_scadenzeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn7, Me.fat_scad, Me.DataGridViewTextBoxColumn8, Me.COLpagatonote, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn12, Me.DG_BT_Pagato, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn15, Me.DGfat_pa_fallimento, Me.CFat_id_cli, Me.CFat_Ivato, Me.DG_SC_netto, Me.CFat_pagato, Me.DataGridViewTextBoxColumn3})
        Me.DT_clienti_scadenzeDataGridView.DataSource = Me.BS_clienti_scadenze
        Me.DT_clienti_scadenzeDataGridView.Location = New System.Drawing.Point(6, 8)
        Me.DT_clienti_scadenzeDataGridView.Name = "DT_clienti_scadenzeDataGridView"
        Me.DT_clienti_scadenzeDataGridView.RowHeadersWidth = 15
        Me.DT_clienti_scadenzeDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DT_clienti_scadenzeDataGridView.Size = New System.Drawing.Size(1101, 350)
        Me.DT_clienti_scadenzeDataGridView.TabIndex = 1
        '
        'BS_clienti_scadenze
        '
        Me.BS_clienti_scadenze.DataMember = "DT_clienti_scadenze"
        Me.BS_clienti_scadenze.DataSource = Me.DS_contabilita
        '
        'DS_contabilita
        '
        Me.DS_contabilita.DataSetName = "DS_contabilita"
        Me.DS_contabilita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GB_filtra
        '
        Me.GB_filtra.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GB_filtra.Controls.Add(Me.RB_perdita)
        Me.GB_filtra.Controls.Add(Me.RB_tutte)
        Me.GB_filtra.Controls.Add(Me.RB_in)
        Me.GB_filtra.Controls.Add(Me.RB_im)
        Me.GB_filtra.Location = New System.Drawing.Point(12, 377)
        Me.GB_filtra.Name = "GB_filtra"
        Me.GB_filtra.Size = New System.Drawing.Size(294, 93)
        Me.GB_filtra.TabIndex = 113
        Me.GB_filtra.TabStop = False
        Me.GB_filtra.Text = "Filtra"
        '
        'RB_perdita
        '
        Me.RB_perdita.AutoSize = True
        Me.RB_perdita.Location = New System.Drawing.Point(149, 19)
        Me.RB_perdita.Name = "RB_perdita"
        Me.RB_perdita.Size = New System.Drawing.Size(119, 17)
        Me.RB_perdita.TabIndex = 117
        Me.RB_perdita.Text = "Fatture in PERDITA"
        Me.TT_informazioni.SetToolTip(Me.RB_perdita, "Visualizza e stampa solo le fatture a perdita di tutto il periodo")
        Me.RB_perdita.UseVisualStyleBackColor = True
        '
        'RB_tutte
        '
        Me.RB_tutte.AutoSize = True
        Me.RB_tutte.Location = New System.Drawing.Point(9, 22)
        Me.RB_tutte.Name = "RB_tutte"
        Me.RB_tutte.Size = New System.Drawing.Size(61, 17)
        Me.RB_tutte.TabIndex = 116
        Me.RB_tutte.Text = "TUTTE"
        Me.TT_informazioni.SetToolTip(Me.RB_tutte, "Visualizza e stampa solo le fatture non pagate alla data odierna")
        Me.RB_tutte.UseVisualStyleBackColor = True
        '
        'RB_in
        '
        Me.RB_in.AutoSize = True
        Me.RB_in.Location = New System.Drawing.Point(9, 66)
        Me.RB_in.Name = "RB_in"
        Me.RB_in.Size = New System.Drawing.Size(115, 17)
        Me.RB_in.TabIndex = 114
        Me.RB_in.Text = "Fatture INSOLUTE"
        Me.TT_informazioni.SetToolTip(Me.RB_in, "Visualizza e stampa solo le fatture non pagate alla data odierna")
        Me.RB_in.UseVisualStyleBackColor = True
        '
        'RB_im
        '
        Me.RB_im.AutoSize = True
        Me.RB_im.Location = New System.Drawing.Point(9, 44)
        Me.RB_im.Name = "RB_im"
        Me.RB_im.Size = New System.Drawing.Size(116, 17)
        Me.RB_im.TabIndex = 113
        Me.RB_im.Text = "Fatture IMPAGATE"
        Me.TT_informazioni.SetToolTip(Me.RB_im, "Visualizza e stampa tutte le fatture non pagate ")
        Me.RB_im.UseVisualStyleBackColor = True
        '
        'TS_TabStrip
        '
        Me.TS_TabStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TS_TabStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TS_LB_totali, Me.TS_LB_totale, Me.TS_LB_pagato, Me.TS_LB_differenza, Me.TS_LB_GranTotale})
        Me.TS_TabStrip.Location = New System.Drawing.Point(0, 572)
        Me.TS_TabStrip.Name = "TS_TabStrip"
        Me.TS_TabStrip.Size = New System.Drawing.Size(1116, 25)
        Me.TS_TabStrip.TabIndex = 121
        Me.TS_TabStrip.Text = "Cliente :"
        '
        'TS_LB_totali
        '
        Me.TS_LB_totali.Name = "TS_LB_totali"
        Me.TS_LB_totali.Size = New System.Drawing.Size(50, 22)
        Me.TS_LB_totali.Text = "Cliente :"
        '
        'TS_LB_totale
        '
        Me.TS_LB_totale.Name = "TS_LB_totale"
        Me.TS_LB_totale.Size = New System.Drawing.Size(38, 22)
        Me.TS_LB_totale.Text = "Totale"
        '
        'TS_LB_pagato
        '
        Me.TS_LB_pagato.Name = "TS_LB_pagato"
        Me.TS_LB_pagato.Size = New System.Drawing.Size(44, 22)
        Me.TS_LB_pagato.Text = "Pagato"
        '
        'TS_LB_differenza
        '
        Me.TS_LB_differenza.Name = "TS_LB_differenza"
        Me.TS_LB_differenza.Size = New System.Drawing.Size(60, 22)
        Me.TS_LB_differenza.Text = "Differenza"
        '
        'TS_LB_GranTotale
        '
        Me.TS_LB_GranTotale.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TS_LB_GranTotale.Name = "TS_LB_GranTotale"
        Me.TS_LB_GranTotale.Size = New System.Drawing.Size(86, 22)
        Me.TS_LB_GranTotale.Text = "Totale Insoluti :"
        '
        'TA_clienti_scadenze
        '
        Me.TA_clienti_scadenze.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_contabilitaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DT_v_ordiniBindingNavigator
        '
        Me.DT_v_ordiniBindingNavigator.AddNewItem = Nothing
        Me.DT_v_ordiniBindingNavigator.AutoSize = False
        Me.DT_v_ordiniBindingNavigator.BindingSource = Me.BS_clienti_scadenze
        Me.DT_v_ordiniBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DT_v_ordiniBindingNavigator.DeleteItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_v_ordiniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicerca, Me.TTTestoRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator3, Me.TTPB, Me.TTBTannulla, Me.TT_CB_anno, Me.TT_CB_mese, Me.TTPB_stampa})
        Me.DT_v_ordiniBindingNavigator.Location = New System.Drawing.Point(0, 493)
        Me.DT_v_ordiniBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_v_ordiniBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_v_ordiniBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_v_ordiniBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_v_ordiniBindingNavigator.Name = "DT_v_ordiniBindingNavigator"
        Me.DT_v_ordiniBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_v_ordiniBindingNavigator.Size = New System.Drawing.Size(1116, 79)
        Me.DT_v_ordiniBindingNavigator.TabIndex = 146
        Me.DT_v_ordiniBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 76)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
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
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.BackColor = System.Drawing.SystemColors.Info
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(100, 79)
        Me.TTTestoRicerca.ToolTipText = "Immettere l'anno di lavoro"
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
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 79)
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
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 79)
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
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 79)
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 79)
        '
        'TTPB
        '
        Me.TTPB.Name = "TTPB"
        Me.TTPB.Size = New System.Drawing.Size(100, 76)
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
        '
        'TT_CB_anno
        '
        Me.TT_CB_anno.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_anno.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_anno.Name = "TT_CB_anno"
        Me.TT_CB_anno.Size = New System.Drawing.Size(121, 79)
        '
        'TT_CB_mese
        '
        Me.TT_CB_mese.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TT_CB_mese.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TT_CB_mese.Name = "TT_CB_mese"
        Me.TT_CB_mese.Size = New System.Drawing.Size(150, 38)
        '
        'TTPB_stampa
        '
        Me.TTPB_stampa.Name = "TTPB_stampa"
        Me.TTPB_stampa.Size = New System.Drawing.Size(500, 16)
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "idfatturaunq"
        Me.DataGridViewTextBoxColumn1.HeaderText = "idfatturaunq"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fat_data"
        Me.DataGridViewTextBoxColumn5.FillWeight = 22.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 74
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "fat_pa_dat"
        Me.DataGridViewTextBoxColumn14.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn14.HeaderText = "Pag. Data"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ToolTipText = "Data in cui è stato effettuato il pagamento"
        Me.DataGridViewTextBoxColumn14.Width = 67
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "fat_cod_paga"
        Me.DataGridViewTextBoxColumn16.HeaderText = "fat_cod_paga"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "ricerca"
        Me.DataGridViewTextBoxColumn17.HeaderText = "ricerca"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.Visible = False
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "fat_num_da"
        Me.DataGridViewTextBoxColumn6.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "N°Fatt"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "societa"
        Me.DataGridViewTextBoxColumn2.FillWeight = 48.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "societa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "fat_data"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn11.FillWeight = 22.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Data"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "pagamento"
        Me.DataGridViewTextBoxColumn4.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Tipo pagamento"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "idfatturaunq"
        Me.DataGridViewTextBoxColumn7.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "idfatturaunq"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'fat_scad
        '
        Me.fat_scad.DataPropertyName = "fat_scad"
        DataGridViewCellStyle3.Format = "d"
        Me.fat_scad.DefaultCellStyle = DataGridViewCellStyle3
        Me.fat_scad.FillWeight = 20.0!
        Me.fat_scad.HeaderText = "Scadenza"
        Me.fat_scad.Name = "fat_scad"
        Me.fat_scad.ReadOnly = True
        Me.fat_scad.ToolTipText = "Data Scadenza della Fattura"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "fat_pa_dat"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn8.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn8.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "Pag. Data"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ToolTipText = "Data in cui è stato effettuato il pagamento"
        '
        'COLpagatonote
        '
        Me.COLpagatonote.DataPropertyName = "fat_pa_des"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.COLpagatonote.DefaultCellStyle = DataGridViewCellStyle5
        Me.COLpagatonote.FillWeight = 55.0!
        Me.COLpagatonote.HeaderText = "Pagato NOTE"
        Me.COLpagatonote.Name = "COLpagatonote"
        Me.COLpagatonote.ToolTipText = "Annotazioni quali Banca pagamento"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fat_cod_paga"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.Format = "C2"
        Me.DataGridViewTextBoxColumn10.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn10.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn10.HeaderText = "fat_cod_paga"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "imponibile"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight
        DataGridViewCellStyle7.Format = "C2"
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridViewTextBoxColumn12.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn12.HeaderText = "imponibile"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.ToolTipText = "Imponibile della fattura"
        '
        'DG_BT_Pagato
        '
        Me.DG_BT_Pagato.DataPropertyName = "fat_paga"
        Me.DG_BT_Pagato.FillWeight = 10.0!
        Me.DG_BT_Pagato.HeaderText = "PA"
        Me.DG_BT_Pagato.Name = "DG_BT_Pagato"
        Me.DG_BT_Pagato.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DG_BT_Pagato.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DG_BT_Pagato.Text = "Fatture Pagate"
        Me.DG_BT_Pagato.ToolTipText = "Se é stata Pagata"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "imposta"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.Format = "C2"
        Me.DataGridViewTextBoxColumn13.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridViewTextBoxColumn13.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn13.HeaderText = "imposta"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.ToolTipText = "Imposta della Fattura"
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "ricerca"
        Me.DataGridViewTextBoxColumn15.FillWeight = 55.0!
        Me.DataGridViewTextBoxColumn15.HeaderText = "ricerca"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ToolTipText = "Annotazioni quali Banca pagamento"
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'DGfat_pa_fallimento
        '
        Me.DGfat_pa_fallimento.DataPropertyName = "fat_pa_fallimento"
        Me.DGfat_pa_fallimento.FillWeight = 10.0!
        Me.DGfat_pa_fallimento.HeaderText = "PE"
        Me.DGfat_pa_fallimento.Name = "DGfat_pa_fallimento"
        Me.DGfat_pa_fallimento.ToolTipText = "Fatture a Perdita"
        '
        'CFat_id_cli
        '
        Me.CFat_id_cli.DataPropertyName = "id_cli"
        Me.CFat_id_cli.FillWeight = 10.0!
        Me.CFat_id_cli.HeaderText = "id_cli"
        Me.CFat_id_cli.Name = "CFat_id_cli"
        Me.CFat_id_cli.Visible = False
        '
        'CFat_Ivato
        '
        Me.CFat_Ivato.DataPropertyName = "ivato"
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        Me.CFat_Ivato.DefaultCellStyle = DataGridViewCellStyle9
        Me.CFat_Ivato.FillWeight = 20.0!
        Me.CFat_Ivato.HeaderText = "Totale"
        Me.CFat_Ivato.Name = "CFat_Ivato"
        Me.CFat_Ivato.ReadOnly = True
        Me.CFat_Ivato.ToolTipText = "Totale della Fattura"
        '
        'DG_SC_netto
        '
        Me.DG_SC_netto.DataPropertyName = "netto"
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DG_SC_netto.DefaultCellStyle = DataGridViewCellStyle10
        Me.DG_SC_netto.FillWeight = 24.0!
        Me.DG_SC_netto.HeaderText = "A Pagare"
        Me.DG_SC_netto.Name = "DG_SC_netto"
        Me.DG_SC_netto.ReadOnly = True
        '
        'CFat_pagato
        '
        Me.CFat_pagato.DataPropertyName = "fat_pa_imp"
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.Format = "C2"
        Me.CFat_pagato.DefaultCellStyle = DataGridViewCellStyle11
        Me.CFat_pagato.FillWeight = 24.0!
        Me.CFat_pagato.HeaderText = "Pagato €"
        Me.CFat_pagato.Name = "CFat_pagato"
        Me.CFat_pagato.ToolTipText = "Importo Pagato"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "condomino"
        Me.DataGridViewTextBoxColumn3.FillWeight = 8.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "C"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ToolTipText = "Indica se é un condominio"
        '
        'FRM_fatture_scadenze
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1116, 597)
        Me.Controls.Add(Me.DT_v_ordiniBindingNavigator)
        Me.Controls.Add(Me.TS_TabStrip)
        Me.Controls.Add(Me.GB_filtra)
        Me.Controls.Add(Me.DT_clienti_scadenzeDataGridView)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_fatture_scadenze"
        Me.Text = "Scadenziario Clienti"
        CType(Me.DT_clienti_scadenzeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti_scadenze, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contabilita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GB_filtra.ResumeLayout(False)
        Me.GB_filtra.PerformLayout()
        Me.TS_TabStrip.ResumeLayout(False)
        Me.TS_TabStrip.PerformLayout()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_v_ordiniBindingNavigator.ResumeLayout(False)
        Me.DT_v_ordiniBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_contabilita As DS_contabilita
    Friend WithEvents BS_clienti_scadenze As BindingSource
    Friend WithEvents TA_clienti_scadenze As DS_contabilitaTableAdapters.TA_clienti_scadenze
    Friend WithEvents TableAdapterManager As DS_contabilitaTableAdapters.TableAdapterManager
    Friend WithEvents DT_clienti_scadenzeDataGridView As DataGridView
    Friend WithEvents GB_filtra As GroupBox
    Friend WithEvents RB_tutte As RadioButton
    Friend WithEvents TT_informazioni As ToolTip
    Friend WithEvents RB_in As RadioButton
    Friend WithEvents RB_im As RadioButton
    Friend WithEvents TS_TabStrip As ToolStrip
    Friend WithEvents TS_LB_totali As ToolStripLabel
    Friend WithEvents TS_LB_totale As ToolStripLabel
    Friend WithEvents TS_LB_pagato As ToolStripLabel
    Friend WithEvents TS_LB_differenza As ToolStripLabel
    Friend WithEvents TS_LB_GranTotale As ToolStripLabel
    Friend WithEvents RB_perdita As RadioButton
    Friend WithEvents DT_v_ordiniBindingNavigator As BindingNavigator
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
    Friend WithEvents TTPB_stampa As ToolStripProgressBar
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents fat_scad As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents COLpagatonote As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DG_BT_Pagato As DataGridViewButtonColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DGfat_pa_fallimento As DataGridViewCheckBoxColumn
    Friend WithEvents CFat_id_cli As DataGridViewTextBoxColumn
    Friend WithEvents CFat_Ivato As DataGridViewTextBoxColumn
    Friend WithEvents DG_SC_netto As DataGridViewTextBoxColumn
    Friend WithEvents CFat_pagato As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewCheckBoxColumn
End Class
