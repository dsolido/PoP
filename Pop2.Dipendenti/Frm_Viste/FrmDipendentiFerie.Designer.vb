<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDipendentiFerie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDipendentiFerie))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.bsUtentiFerie = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSfestivita = New PoP2.Comuni.DSfestivita()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TT_CB_anno = New System.Windows.Forms.ToolStripComboBox()
        Me.TT_CB_mese = New System.Windows.Forms.ToolStripComboBox()
        Me.tsFiltro = New System.Windows.Forms.ToolStripDropDownButton()
        Me.VisualizzaLeFerieDaGestireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerieApprovateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerieRifiutateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerieGestiteNelMeseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElencoDiChiHaChiestoLeFerieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsCollegamentoCambioData = New System.Windows.Forms.ToolStripButton()
        Me.tsEtichettaSpiegazioni = New System.Windows.Forms.ToolStripLabel()
        Me.bsCalendario = New System.Windows.Forms.BindingSource(Me.components)
        Me.tblVisualizzato = New System.Windows.Forms.TableLayoutPanel()
        Me.lbPianodilavorodipendente = New System.Windows.Forms.Label()
        Me.dgwDestinatariMese = New System.Windows.Forms.DataGridView()
        Me.dgwSviluppoOreDipendenteMese = New System.Windows.Forms.DataGridView()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgwFerieUtente = New System.Windows.Forms.DataGridView()
        Me.dgwcAnagrafica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcFerieUtenteDataRichiesta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcControllo = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.bsUtentiFerieLeggenda = New System.Windows.Forms.BindingSource(Me.components)
        Me.dgwcFerieUtenteInizio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcFerieUtenteFine = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IduservisioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatavisioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IduseraccettazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataaccettazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwSostituzioni = New System.Windows.Forms.DataGridView()
        Me.dgwcSostituto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsPossibiliSostituti = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbDestinatarioMese = New System.Windows.Forms.Label()
        Me.lbDipendentiFerie = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tblPrincipale = New System.Windows.Forms.TableLayoutPanel()
        Me.TA_cal = New PoP2.Comuni.DS_utentiTableAdapters.TA_cal()
        Me.TableAdapterManager = New PoP2.Comuni.DSfestivitaTableAdapters.TableAdapterManager()
        Me.bsPianoOrarioDipendente = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAferieutente = New PoP2.Comuni.DSfestivitaTableAdapters.TAferieutente()
        Me.bsClientiFerie = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAferiecliente = New PoP2.Comuni.DSfestivitaTableAdapters.TAferiecliente()
        Me.bsPianoOrarioCliente = New System.Windows.Forms.BindingSource(Me.components)
        Me.TaUtentiFerieLeggenda = New PoP2.Comuni.DSfestivitaTableAdapters.taUtentiFerieLeggenda()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        CType(Me.bsUtentiFerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSfestivita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblVisualizzato.SuspendLayout()
        CType(Me.dgwDestinatariMese, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwSviluppoOreDipendenteMese, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.dgwFerieUtente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUtentiFerieLeggenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwSostituzioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPossibiliSostituti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tblPrincipale.SuspendLayout()
        CType(Me.bsPianoOrarioDipendente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsClientiFerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPianoOrarioCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DM_barra
        '
        Me.DM_barra.AddNewItem = Nothing
        Me.DM_barra.AutoSize = False
        Me.DM_barra.BindingSource = Me.bsUtentiFerie
        Me.DM_barra.CountItem = Me.BindingNavigatorCountItem
        Me.DM_barra.DeleteItem = Nothing
        Me.DM_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DM_barra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DM_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTestoRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator3, Me.TT_CB_anno, Me.TT_CB_mese, Me.tsFiltro, Me.tsCollegamentoCambioData, Me.tsEtichettaSpiegazioni})
        Me.DM_barra.Location = New System.Drawing.Point(0, 732)
        Me.DM_barra.Margin = New System.Windows.Forms.Padding(1)
        Me.DM_barra.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DM_barra.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DM_barra.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DM_barra.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.PositionItem = Me.BindingNavigatorPositionItem
        Me.DM_barra.Size = New System.Drawing.Size(1484, 79)
        Me.DM_barra.TabIndex = 190
        Me.DM_barra.Text = "BindingNavigator1"
        '
        'bsUtentiFerie
        '
        Me.bsUtentiFerie.DataMember = "DTferieutente"
        Me.bsUtentiFerie.DataSource = Me.DSfestivita
        '
        'DSfestivita
        '
        Me.DSfestivita.DataSetName = "DSfestivita"
        Me.DSfestivita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 76)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
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
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 79)
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
        Me.TT_CB_mese.Size = New System.Drawing.Size(150, 79)
        '
        'tsFiltro
        '
        Me.tsFiltro.AutoSize = False
        Me.tsFiltro.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsFiltro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VisualizzaLeFerieDaGestireToolStripMenuItem, Me.FerieApprovateToolStripMenuItem, Me.FerieRifiutateToolStripMenuItem, Me.FerieGestiteNelMeseToolStripMenuItem, Me.ElencoDiChiHaChiestoLeFerieToolStripMenuItem})
        Me.tsFiltro.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_cerca48x48
        Me.tsFiltro.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsFiltro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFiltro.Name = "tsFiltro"
        Me.tsFiltro.Size = New System.Drawing.Size(60, 76)
        Me.tsFiltro.Text = "ToolStripDropDownButton1"
        '
        'VisualizzaLeFerieDaGestireToolStripMenuItem
        '
        Me.VisualizzaLeFerieDaGestireToolStripMenuItem.Checked = True
        Me.VisualizzaLeFerieDaGestireToolStripMenuItem.CheckOnClick = True
        Me.VisualizzaLeFerieDaGestireToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.VisualizzaLeFerieDaGestireToolStripMenuItem.Name = "VisualizzaLeFerieDaGestireToolStripMenuItem"
        Me.VisualizzaLeFerieDaGestireToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.VisualizzaLeFerieDaGestireToolStripMenuItem.Text = "Richieste ancora da Gestire"
        '
        'FerieApprovateToolStripMenuItem
        '
        Me.FerieApprovateToolStripMenuItem.CheckOnClick = True
        Me.FerieApprovateToolStripMenuItem.Name = "FerieApprovateToolStripMenuItem"
        Me.FerieApprovateToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.FerieApprovateToolStripMenuItem.Text = "Ultime Richieste Approvate"
        '
        'FerieRifiutateToolStripMenuItem
        '
        Me.FerieRifiutateToolStripMenuItem.CheckOnClick = True
        Me.FerieRifiutateToolStripMenuItem.Name = "FerieRifiutateToolStripMenuItem"
        Me.FerieRifiutateToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.FerieRifiutateToolStripMenuItem.Text = "Richieste Rifiutate"
        '
        'FerieGestiteNelMeseToolStripMenuItem
        '
        Me.FerieGestiteNelMeseToolStripMenuItem.CheckOnClick = True
        Me.FerieGestiteNelMeseToolStripMenuItem.Name = "FerieGestiteNelMeseToolStripMenuItem"
        Me.FerieGestiteNelMeseToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.FerieGestiteNelMeseToolStripMenuItem.Text = "Tutte le Richieste del mese"
        '
        'ElencoDiChiHaChiestoLeFerieToolStripMenuItem
        '
        Me.ElencoDiChiHaChiestoLeFerieToolStripMenuItem.Name = "ElencoDiChiHaChiestoLeFerieToolStripMenuItem"
        Me.ElencoDiChiHaChiestoLeFerieToolStripMenuItem.Size = New System.Drawing.Size(217, 22)
        Me.ElencoDiChiHaChiestoLeFerieToolStripMenuItem.Text = "Elenco di tutto il personale"
        '
        'tsCollegamentoCambioData
        '
        Me.tsCollegamentoCambioData.AutoSize = False
        Me.tsCollegamentoCambioData.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsCollegamentoCambioData.Image = Global.PoP2.Comuni.My.Resources.Resources.ominoConferma48
        Me.tsCollegamentoCambioData.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsCollegamentoCambioData.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCollegamentoCambioData.Name = "tsCollegamentoCambioData"
        Me.tsCollegamentoCambioData.Size = New System.Drawing.Size(60, 76)
        Me.tsCollegamentoCambioData.Text = "ToolStripButton1"
        Me.tsCollegamentoCambioData.ToolTipText = "Collega le ferie del dipendente al periodo analizzato"
        '
        'tsEtichettaSpiegazioni
        '
        Me.tsEtichettaSpiegazioni.Name = "tsEtichettaSpiegazioni"
        Me.tsEtichettaSpiegazioni.Size = New System.Drawing.Size(493, 76)
        Me.tsEtichettaSpiegazioni.Text = "In Questo momento, quando seleziono un dipendente automaticamente aggiorna il per" &
    "iodo"
        '
        'tblVisualizzato
        '
        Me.tblVisualizzato.ColumnCount = 1
        Me.tblVisualizzato.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblVisualizzato.Controls.Add(Me.lbPianodilavorodipendente, 0, 2)
        Me.tblVisualizzato.Controls.Add(Me.dgwDestinatariMese, 0, 5)
        Me.tblVisualizzato.Controls.Add(Me.dgwSviluppoOreDipendenteMese, 0, 3)
        Me.tblVisualizzato.Controls.Add(Me.TableLayoutPanel2, 0, 1)
        Me.tblVisualizzato.Controls.Add(Me.lbDestinatarioMese, 0, 4)
        Me.tblVisualizzato.Controls.Add(Me.lbDipendentiFerie, 0, 0)
        Me.tblVisualizzato.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tblVisualizzato.Location = New System.Drawing.Point(3, 3)
        Me.tblVisualizzato.Name = "tblVisualizzato"
        Me.tblVisualizzato.Padding = New System.Windows.Forms.Padding(1)
        Me.tblVisualizzato.RowCount = 6
        Me.tblVisualizzato.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblVisualizzato.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.63374!))
        Me.tblVisualizzato.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblVisualizzato.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.02337!))
        Me.tblVisualizzato.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblVisualizzato.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3429!))
        Me.tblVisualizzato.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tblVisualizzato.Size = New System.Drawing.Size(1478, 710)
        Me.tblVisualizzato.TabIndex = 191
        '
        'lbPianodilavorodipendente
        '
        Me.lbPianodilavorodipendente.AutoSize = True
        Me.lbPianodilavorodipendente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbPianodilavorodipendente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPianodilavorodipendente.Location = New System.Drawing.Point(4, 232)
        Me.lbPianodilavorodipendente.Name = "lbPianodilavorodipendente"
        Me.lbPianodilavorodipendente.Size = New System.Drawing.Size(1470, 20)
        Me.lbPianodilavorodipendente.TabIndex = 186
        Me.lbPianodilavorodipendente.Text = "Piano di lavoro del dipendente"
        Me.lbPianodilavorodipendente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgwDestinatariMese
        '
        Me.dgwDestinatariMese.AllowUserToAddRows = False
        Me.dgwDestinatariMese.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwDestinatariMese.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgwDestinatariMese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgwDestinatariMese.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgwDestinatariMese.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwDestinatariMese.Location = New System.Drawing.Point(3, 494)
        Me.dgwDestinatariMese.Margin = New System.Windows.Forms.Padding(2)
        Me.dgwDestinatariMese.Name = "dgwDestinatariMese"
        Me.dgwDestinatariMese.ReadOnly = True
        Me.dgwDestinatariMese.RowHeadersWidth = 4
        Me.dgwDestinatariMese.Size = New System.Drawing.Size(1472, 213)
        Me.dgwDestinatariMese.TabIndex = 183
        '
        'dgwSviluppoOreDipendenteMese
        '
        Me.dgwSviluppoOreDipendenteMese.AllowUserToAddRows = False
        Me.dgwSviluppoOreDipendenteMese.AllowUserToDeleteRows = False
        Me.dgwSviluppoOreDipendenteMese.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwSviluppoOreDipendenteMese.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwSviluppoOreDipendenteMese.Location = New System.Drawing.Point(3, 254)
        Me.dgwSviluppoOreDipendenteMese.Margin = New System.Windows.Forms.Padding(2)
        Me.dgwSviluppoOreDipendenteMese.Name = "dgwSviluppoOreDipendenteMese"
        Me.dgwSviluppoOreDipendenteMese.ReadOnly = True
        Me.dgwSviluppoOreDipendenteMese.RowHeadersWidth = 4
        Me.dgwSviluppoOreDipendenteMese.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgwSviluppoOreDipendenteMese.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black
        Me.dgwSviluppoOreDipendenteMese.Size = New System.Drawing.Size(1472, 216)
        Me.dgwSviluppoOreDipendenteMese.TabIndex = 182
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.AutoScroll = True
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.32511!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.67489!))
        Me.TableLayoutPanel2.Controls.Add(Me.dgwFerieUtente, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.dgwSostituzioni, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(2, 22)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1474, 209)
        Me.TableLayoutPanel2.TabIndex = 180
        '
        'dgwFerieUtente
        '
        Me.dgwFerieUtente.AutoGenerateColumns = False
        Me.dgwFerieUtente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwFerieUtente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwFerieUtente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcAnagrafica, Me.dgwcFerieUtenteDataRichiesta, Me.dgwcControllo, Me.dgwcFerieUtenteInizio, Me.dgwcFerieUtenteFine, Me.NoteDataGridViewTextBoxColumn, Me.IduservisioneDataGridViewTextBoxColumn, Me.DatavisioneDataGridViewTextBoxColumn, Me.IduseraccettazioneDataGridViewTextBoxColumn, Me.DataaccettazioneDataGridViewTextBoxColumn})
        Me.dgwFerieUtente.DataSource = Me.bsUtentiFerie
        Me.dgwFerieUtente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwFerieUtente.Location = New System.Drawing.Point(2, 2)
        Me.dgwFerieUtente.Margin = New System.Windows.Forms.Padding(2)
        Me.dgwFerieUtente.Name = "dgwFerieUtente"
        Me.dgwFerieUtente.Size = New System.Drawing.Size(1238, 205)
        Me.dgwFerieUtente.TabIndex = 3
        '
        'dgwcAnagrafica
        '
        Me.dgwcAnagrafica.DataPropertyName = "anagrafica"
        Me.dgwcAnagrafica.HeaderText = "anagrafica"
        Me.dgwcAnagrafica.Name = "dgwcAnagrafica"
        Me.dgwcAnagrafica.ReadOnly = True
        '
        'dgwcFerieUtenteDataRichiesta
        '
        Me.dgwcFerieUtenteDataRichiesta.DataPropertyName = "data"
        DataGridViewCellStyle3.Format = "d"
        Me.dgwcFerieUtenteDataRichiesta.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgwcFerieUtenteDataRichiesta.FillWeight = 30.0!
        Me.dgwcFerieUtenteDataRichiesta.HeaderText = "Richiesto in data"
        Me.dgwcFerieUtenteDataRichiesta.Name = "dgwcFerieUtenteDataRichiesta"
        '
        'dgwcControllo
        '
        Me.dgwcControllo.DataPropertyName = "controllo"
        Me.dgwcControllo.DataSource = Me.bsUtentiFerieLeggenda
        Me.dgwcControllo.DisplayMember = "descrizione"
        Me.dgwcControllo.FillWeight = 40.0!
        Me.dgwcControllo.HeaderText = "Visto"
        Me.dgwcControllo.Name = "dgwcControllo"
        Me.dgwcControllo.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcControllo.ValueMember = "id"
        '
        'bsUtentiFerieLeggenda
        '
        Me.bsUtentiFerieLeggenda.DataMember = "dtUtentiFerieLeggenda"
        Me.bsUtentiFerieLeggenda.DataSource = Me.DSfestivita
        '
        'dgwcFerieUtenteInizio
        '
        Me.dgwcFerieUtenteInizio.DataPropertyName = "inizio"
        Me.dgwcFerieUtenteInizio.FillWeight = 25.0!
        Me.dgwcFerieUtenteInizio.HeaderText = "Inizio"
        Me.dgwcFerieUtenteInizio.Name = "dgwcFerieUtenteInizio"
        '
        'dgwcFerieUtenteFine
        '
        Me.dgwcFerieUtenteFine.DataPropertyName = "fine"
        Me.dgwcFerieUtenteFine.FillWeight = 25.0!
        Me.dgwcFerieUtenteFine.HeaderText = "Fine"
        Me.dgwcFerieUtenteFine.Name = "dgwcFerieUtenteFine"
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn.FillWeight = 60.0!
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        '
        'IduservisioneDataGridViewTextBoxColumn
        '
        Me.IduservisioneDataGridViewTextBoxColumn.DataPropertyName = "visionato"
        Me.IduservisioneDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.IduservisioneDataGridViewTextBoxColumn.HeaderText = "Visto"
        Me.IduservisioneDataGridViewTextBoxColumn.Name = "IduservisioneDataGridViewTextBoxColumn"
        '
        'DatavisioneDataGridViewTextBoxColumn
        '
        Me.DatavisioneDataGridViewTextBoxColumn.DataPropertyName = "data_visione"
        DataGridViewCellStyle4.Format = "d"
        Me.DatavisioneDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.DatavisioneDataGridViewTextBoxColumn.FillWeight = 25.0!
        Me.DatavisioneDataGridViewTextBoxColumn.HeaderText = "in Data"
        Me.DatavisioneDataGridViewTextBoxColumn.Name = "DatavisioneDataGridViewTextBoxColumn"
        '
        'IduseraccettazioneDataGridViewTextBoxColumn
        '
        Me.IduseraccettazioneDataGridViewTextBoxColumn.DataPropertyName = "autorizzato"
        Me.IduseraccettazioneDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.IduseraccettazioneDataGridViewTextBoxColumn.HeaderText = "Autorizzato"
        Me.IduseraccettazioneDataGridViewTextBoxColumn.Name = "IduseraccettazioneDataGridViewTextBoxColumn"
        '
        'DataaccettazioneDataGridViewTextBoxColumn
        '
        Me.DataaccettazioneDataGridViewTextBoxColumn.DataPropertyName = "data_accettazione"
        DataGridViewCellStyle5.Format = "d"
        Me.DataaccettazioneDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.DataaccettazioneDataGridViewTextBoxColumn.FillWeight = 25.0!
        Me.DataaccettazioneDataGridViewTextBoxColumn.HeaderText = "in Data"
        Me.DataaccettazioneDataGridViewTextBoxColumn.Name = "DataaccettazioneDataGridViewTextBoxColumn"
        '
        'dgwSostituzioni
        '
        Me.dgwSostituzioni.AllowUserToAddRows = False
        Me.dgwSostituzioni.AllowUserToDeleteRows = False
        Me.dgwSostituzioni.AutoGenerateColumns = False
        Me.dgwSostituzioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwSostituzioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwSostituzioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcSostituto})
        Me.dgwSostituzioni.DataSource = Me.bsPossibiliSostituti
        Me.dgwSostituzioni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwSostituzioni.Location = New System.Drawing.Point(1245, 3)
        Me.dgwSostituzioni.Name = "dgwSostituzioni"
        Me.dgwSostituzioni.ReadOnly = True
        Me.dgwSostituzioni.RowHeadersVisible = False
        Me.dgwSostituzioni.Size = New System.Drawing.Size(226, 203)
        Me.dgwSostituzioni.TabIndex = 4
        '
        'dgwcSostituto
        '
        Me.dgwcSostituto.DataPropertyName = "anagrafica"
        Me.dgwcSostituto.HeaderText = "Sostituto"
        Me.dgwcSostituto.Name = "dgwcSostituto"
        Me.dgwcSostituto.ReadOnly = True
        '
        'lbDestinatarioMese
        '
        Me.lbDestinatarioMese.AutoSize = True
        Me.lbDestinatarioMese.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbDestinatarioMese.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDestinatarioMese.Location = New System.Drawing.Point(4, 472)
        Me.lbDestinatarioMese.Name = "lbDestinatarioMese"
        Me.lbDestinatarioMese.Size = New System.Drawing.Size(1470, 20)
        Me.lbDestinatarioMese.TabIndex = 184
        Me.lbDestinatarioMese.Text = "Mese"
        Me.lbDestinatarioMese.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbDipendentiFerie
        '
        Me.lbDipendentiFerie.AutoSize = True
        Me.lbDipendentiFerie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbDipendentiFerie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDipendentiFerie.Location = New System.Drawing.Point(4, 1)
        Me.lbDipendentiFerie.Name = "lbDipendentiFerie"
        Me.lbDipendentiFerie.Size = New System.Drawing.Size(1470, 20)
        Me.lbDipendentiFerie.TabIndex = 185
        Me.lbDipendentiFerie.Text = "Elenco dei dipendenti che hanno richiesto le ferie"
        Me.lbDipendentiFerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "anagrafica"
        Me.DataGridViewTextBoxColumn1.HeaderText = "anagrafica"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 508
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "inizio"
        DataGridViewCellStyle6.Format = "d"
        Me.DataGridViewTextBoxColumn2.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn2.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 252
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "fine"
        Me.DataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 252
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "fine"
        Me.DataGridViewTextBoxColumn4.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Fine"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 123
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn5.HeaderText = "note"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 292
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "id_user_visione"
        Me.DataGridViewTextBoxColumn6.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "id_user_visione"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 59
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id_user_accettazione"
        Me.DataGridViewTextBoxColumn7.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "id_user_accettazione"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 58
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "data_visione"
        Me.DataGridViewTextBoxColumn8.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn8.HeaderText = "data_visione"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 88
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "data_accettazione"
        Me.DataGridViewTextBoxColumn9.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn9.HeaderText = "data_accettazione"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 88
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "anagrafica"
        Me.DataGridViewTextBoxColumn11.HeaderText = "anagrafica"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 513
        '
        'tblPrincipale
        '
        Me.tblPrincipale.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tblPrincipale.ColumnCount = 2
        Me.tblPrincipale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPrincipale.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0!))
        Me.tblPrincipale.Controls.Add(Me.tblVisualizzato, 0, 0)
        Me.tblPrincipale.Location = New System.Drawing.Point(0, 12)
        Me.tblPrincipale.Name = "tblPrincipale"
        Me.tblPrincipale.RowCount = 1
        Me.tblPrincipale.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.tblPrincipale.Size = New System.Drawing.Size(1484, 716)
        Me.tblPrincipale.TabIndex = 192
        '
        'TA_cal
        '
        Me.TA_cal.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DSfestivitaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'bsPianoOrarioDipendente
        '
        Me.bsPianoOrarioDipendente.DataMember = "dtPianoOrario"
        Me.bsPianoOrarioDipendente.DataSource = Me.DSfestivita
        '
        'TAferieutente
        '
        Me.TAferieutente.ClearBeforeFill = True
        '
        'bsClientiFerie
        '
        Me.bsClientiFerie.DataMember = "DTferiecliente"
        Me.bsClientiFerie.DataSource = Me.DSfestivita
        '
        'TAferiecliente
        '
        Me.TAferiecliente.ClearBeforeFill = True
        '
        'bsPianoOrarioCliente
        '
        Me.bsPianoOrarioCliente.DataMember = "dtPianoOrario"
        Me.bsPianoOrarioCliente.DataSource = Me.DSfestivita
        '
        'TaUtentiFerieLeggenda
        '
        Me.TaUtentiFerieLeggenda.ClearBeforeFill = True
        '
        'frmDipendentiFerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 811)
        Me.Controls.Add(Me.tblPrincipale)
        Me.Controls.Add(Me.DM_barra)
        Me.Name = "frmDipendentiFerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDipendentiFerie"
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        CType(Me.bsUtentiFerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSfestivita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblVisualizzato.ResumeLayout(False)
        Me.tblVisualizzato.PerformLayout()
        CType(Me.dgwDestinatariMese, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwSviluppoOreDipendenteMese, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.dgwFerieUtente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUtentiFerieLeggenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwSostituzioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPossibiliSostituti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tblPrincipale.ResumeLayout(False)
        CType(Me.bsPianoOrarioDipendente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsClientiFerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPianoOrarioCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DSfestivita As DSfestivita
    Friend WithEvents TableAdapterManager As DSfestivitaTableAdapters.TableAdapterManager
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents TTTestoRicerca As ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TT_CB_anno As ToolStripComboBox
    Friend WithEvents TT_CB_mese As ToolStripComboBox
    Friend WithEvents bsCalendario As BindingSource
    Friend WithEvents TA_cal As DS_utentiTableAdapters.TA_cal
    Friend WithEvents tblVisualizzato As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents bsPianoOrarioDipendente As BindingSource
    Friend WithEvents bsUtentiFerie As BindingSource
    Friend WithEvents TAferieutente As DSfestivitaTableAdapters.TAferieutente
    Friend WithEvents dgwFerieUtente As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents dgwSviluppoOreDipendenteMese As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents dgwDestinatariMese As DataGridView
    Friend WithEvents bsClientiFerie As BindingSource
    Friend WithEvents TAferiecliente As DSfestivitaTableAdapters.TAferiecliente
    Friend WithEvents bsPianoOrarioCliente As BindingSource
    Friend WithEvents bsUtentiFerieLeggenda As BindingSource
    Friend WithEvents TaUtentiFerieLeggenda As DSfestivitaTableAdapters.taUtentiFerieLeggenda
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents tsFiltro As ToolStripDropDownButton
    Friend WithEvents VisualizzaLeFerieDaGestireToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerieApprovateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerieRifiutateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FerieGestiteNelMeseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgwSostituzioni As DataGridView
    Friend WithEvents dgwcSostituto As DataGridViewTextBoxColumn
    Friend WithEvents bsPossibiliSostituti As BindingSource
    Friend WithEvents lbDestinatarioMese As Label
    Friend WithEvents lbPianodilavorodipendente As Label
    Friend WithEvents lbDipendentiFerie As Label
    Friend WithEvents tblPrincipale As TableLayoutPanel
    Friend WithEvents dgwcAnagrafica As DataGridViewTextBoxColumn
    Friend WithEvents dgwcFerieUtenteDataRichiesta As DataGridViewTextBoxColumn
    Friend WithEvents dgwcControllo As DataGridViewComboBoxColumn
    Friend WithEvents dgwcFerieUtenteInizio As DataGridViewTextBoxColumn
    Friend WithEvents dgwcFerieUtenteFine As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IduservisioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DatavisioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IduseraccettazioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataaccettazioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ElencoDiChiHaChiestoLeFerieToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsCollegamentoCambioData As ToolStripButton
    Friend WithEvents tsEtichettaSpiegazioni As ToolStripLabel
End Class
