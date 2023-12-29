<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDipendentiGestioneFerie
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDipendentiGestioneFerie))
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DGelencoUtenti = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DGWCidDip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcAnagraficaUtente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsutenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PGferiecliente = New System.Windows.Forms.ProgressBar()
        Me.ckNonVisualizzaLavoriInFerie = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.CKclientichiusi = New System.Windows.Forms.CheckBox()
        Me.ckFerienonconfermate = New System.Windows.Forms.CheckBox()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.dgwFerieDipendente = New System.Windows.Forms.DataGridView()
        Me.InizioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NoteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ControlloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnagraficaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisionatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AutorizzatoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantiereDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsferie = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSfestivita = New PoP2.Comuni.DSfestivita()
        Me.dgwFoglioPresenza = New System.Windows.Forms.DataGridView()
        Me.CartellaDestinazione = New System.Windows.Forms.FolderBrowserDialog()
        Me.TTcmbmese = New System.Windows.Forms.ToolStripComboBox()
        Me.TTcmbanno = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.PGbar = New System.Windows.Forms.ToolStripProgressBar()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.BTaggiorna = New System.Windows.Forms.ToolStripButton()
        Me.BTgenera = New System.Windows.Forms.ToolStripButton()
        Me.ttsButtonCaricaDati = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.BTtermina = New System.Windows.Forms.ToolStripButton()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn43 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn44 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn45 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn46 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn47 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn48 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn49 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn50 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn51 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn52 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn53 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn54 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn55 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn56 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn57 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsorariolavoro = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_orari = New PoP2.Comuni.DS_orari()
        Me.TA_utenti = New PoP2.Comuni.DS_utentiTableAdapters.TA_utenti()
        Me.TableAdapterManager = New PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager()
        Me.TA_orario = New PoP2.Comuni.DS_orariTableAdapters.TA_orario()
        Me.TableAdapterManager2 = New PoP2.Comuni.DS_orariTableAdapters.TableAdapterManager()
        Me.DS_ag = New PoP2.Comuni.DS_ag()
        Me.bsPiano = New System.Windows.Forms.BindingSource(Me.components)
        Me.BSpianotmp = New System.Windows.Forms.BindingSource(Me.components)
        Me.bssostituzioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.bspianodilavoro = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAferieutente = New PoP2.Comuni.DSfestivitaTableAdapters.TAferieutente()
        Me.TableAdapterManager1 = New PoP2.Comuni.DSfestivitaTableAdapters.TableAdapterManager()
        Me.TApianodilavoro = New PoP2.Comuni.DSfestivitaTableAdapters.TApianodilavoro()
        Me.bstipoorario = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAtipoorario = New PoP2.Comuni.DSfestivitaTableAdapters.TAtipoorario()
        Me.TAutentisostituzioni = New PoP2.Comuni.DSfestivitaTableAdapters.TAutentisostituzioni()
        Me.TaPiano = New PoP2.Comuni.DSfestivitaTableAdapters.taPiano()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DGelencoUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsutenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        CType(Me.dgwFerieDipendente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsferie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSfestivita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwFoglioPresenza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.bsorariolavoro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_orari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPiano, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSpianotmp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bssostituzioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bspianodilavoro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bstipoorario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel5, 1, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1221, 871)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 1
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Controls.Add(Me.DGelencoUtenti, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel1, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TableLayoutPanel4, 0, 3)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 4
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(494, 865)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'DGelencoUtenti
        '
        Me.DGelencoUtenti.AllowUserToAddRows = False
        Me.DGelencoUtenti.AllowUserToDeleteRows = False
        Me.DGelencoUtenti.AllowUserToOrderColumns = True
        Me.DGelencoUtenti.AutoGenerateColumns = False
        Me.DGelencoUtenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGelencoUtenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGelencoUtenti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn32, Me.DGWCidDip, Me.dgwcAnagraficaUtente, Me.DataGridViewTextBoxColumn17})
        Me.DGelencoUtenti.DataSource = Me.bsutenti
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGelencoUtenti.DefaultCellStyle = DataGridViewCellStyle1
        Me.DGelencoUtenti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DGelencoUtenti.Location = New System.Drawing.Point(3, 33)
        Me.DGelencoUtenti.Name = "DGelencoUtenti"
        Me.DGelencoUtenti.ReadOnly = True
        Me.DGelencoUtenti.RowHeadersVisible = False
        Me.DGelencoUtenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGelencoUtenti.Size = New System.Drawing.Size(488, 678)
        Me.DGelencoUtenti.TabIndex = 0
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "interinale"
        Me.DataGridViewTextBoxColumn32.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn32.HeaderText = "I"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        Me.DataGridViewTextBoxColumn32.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn32.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DGWCidDip
        '
        Me.DGWCidDip.DataPropertyName = "id"
        Me.DGWCidDip.FillWeight = 20.0!
        Me.DGWCidDip.HeaderText = "id"
        Me.DGWCidDip.Name = "DGWCidDip"
        Me.DGWCidDip.ReadOnly = True
        '
        'dgwcAnagraficaUtente
        '
        Me.dgwcAnagraficaUtente.DataPropertyName = "Anagrafica"
        Me.dgwcAnagraficaUtente.HeaderText = "Anagrafica"
        Me.dgwcAnagraficaUtente.Name = "dgwcAnagraficaUtente"
        Me.dgwcAnagraficaUtente.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "cellulare"
        Me.DataGridViewTextBoxColumn17.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn17.HeaderText = "cellulare"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'bsutenti
        '
        Me.bsutenti.DataMember = "DT_utenti"
        Me.bsutenti.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoScroll = True
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PGferiecliente, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.ckNonVisualizzaLavoriInFerie, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 717)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(488, 69)
        Me.TableLayoutPanel1.TabIndex = 14
        '
        'PGferiecliente
        '
        Me.PGferiecliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PGferiecliente.Location = New System.Drawing.Point(3, 52)
        Me.PGferiecliente.Name = "PGferiecliente"
        Me.PGferiecliente.Size = New System.Drawing.Size(482, 14)
        Me.PGferiecliente.TabIndex = 13
        '
        'ckNonVisualizzaLavoriInFerie
        '
        Me.ckNonVisualizzaLavoriInFerie.Appearance = System.Windows.Forms.Appearance.Button
        Me.ckNonVisualizzaLavoriInFerie.AutoSize = True
        Me.ckNonVisualizzaLavoriInFerie.Checked = True
        Me.ckNonVisualizzaLavoriInFerie.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ckNonVisualizzaLavoriInFerie.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ckNonVisualizzaLavoriInFerie.Location = New System.Drawing.Point(3, 23)
        Me.ckNonVisualizzaLavoriInFerie.Name = "ckNonVisualizzaLavoriInFerie"
        Me.ckNonVisualizzaLavoriInFerie.Size = New System.Drawing.Size(482, 23)
        Me.ckNonVisualizzaLavoriInFerie.TabIndex = 14
        Me.ckNonVisualizzaLavoriInFerie.Text = "Non visualizzare i lavori quando sono in ferie"
        Me.ckNonVisualizzaLavoriInFerie.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(488, 30)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Elenco Dipendenti"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.CKclientichiusi, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.ckFerienonconfermate, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 792)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.85185!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.14815!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(488, 70)
        Me.TableLayoutPanel4.TabIndex = 16
        '
        'CKclientichiusi
        '
        Me.CKclientichiusi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CKclientichiusi.Appearance = System.Windows.Forms.Appearance.Button
        Me.CKclientichiusi.AutoSize = True
        Me.CKclientichiusi.Checked = True
        Me.CKclientichiusi.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CKclientichiusi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CKclientichiusi.Location = New System.Drawing.Point(3, 39)
        Me.CKclientichiusi.Name = "CKclientichiusi"
        Me.CKclientichiusi.Size = New System.Drawing.Size(482, 28)
        Me.CKclientichiusi.TabIndex = 17
        Me.CKclientichiusi.Text = "Elimina clienti chiusi"
        Me.CKclientichiusi.UseVisualStyleBackColor = True
        '
        'ckFerienonconfermate
        '
        Me.ckFerienonconfermate.Appearance = System.Windows.Forms.Appearance.Button
        Me.ckFerienonconfermate.AutoSize = True
        Me.ckFerienonconfermate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ckFerienonconfermate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ckFerienonconfermate.Location = New System.Drawing.Point(3, 3)
        Me.ckFerienonconfermate.Name = "ckFerienonconfermate"
        Me.ckFerienonconfermate.Size = New System.Drawing.Size(482, 30)
        Me.ckFerienonconfermate.TabIndex = 18
        Me.ckFerienonconfermate.Text = "Visualizza tutte le ferie anche non confermate"
        Me.ckFerienonconfermate.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.ColumnCount = 1
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Controls.Add(Me.dgwFerieDipendente, 0, 1)
        Me.TableLayoutPanel5.Controls.Add(Me.dgwFoglioPresenza, 0, 0)
        Me.TableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(503, 3)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 2
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.20809!))
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.79191!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(715, 865)
        Me.TableLayoutPanel5.TabIndex = 1
        '
        'dgwFerieDipendente
        '
        Me.dgwFerieDipendente.AllowUserToAddRows = False
        Me.dgwFerieDipendente.AllowUserToDeleteRows = False
        Me.dgwFerieDipendente.AutoGenerateColumns = False
        Me.dgwFerieDipendente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwFerieDipendente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwFerieDipendente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.InizioDataGridViewTextBoxColumn, Me.FineDataGridViewTextBoxColumn, Me.NoteDataGridViewTextBoxColumn, Me.ControlloDataGridViewTextBoxColumn, Me.AnagraficaDataGridViewTextBoxColumn, Me.VisionatoDataGridViewTextBoxColumn, Me.AutorizzatoDataGridViewTextBoxColumn, Me.CantiereDataGridViewTextBoxColumn})
        Me.dgwFerieDipendente.DataSource = Me.bsferie
        Me.dgwFerieDipendente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwFerieDipendente.Location = New System.Drawing.Point(3, 765)
        Me.dgwFerieDipendente.Name = "dgwFerieDipendente"
        Me.dgwFerieDipendente.ReadOnly = True
        Me.dgwFerieDipendente.RowHeadersWidth = 4
        Me.dgwFerieDipendente.Size = New System.Drawing.Size(709, 97)
        Me.dgwFerieDipendente.TabIndex = 178
        '
        'InizioDataGridViewTextBoxColumn
        '
        Me.InizioDataGridViewTextBoxColumn.DataPropertyName = "inizio"
        Me.InizioDataGridViewTextBoxColumn.HeaderText = "inizio"
        Me.InizioDataGridViewTextBoxColumn.Name = "InizioDataGridViewTextBoxColumn"
        Me.InizioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FineDataGridViewTextBoxColumn
        '
        Me.FineDataGridViewTextBoxColumn.DataPropertyName = "fine"
        Me.FineDataGridViewTextBoxColumn.HeaderText = "fine"
        Me.FineDataGridViewTextBoxColumn.Name = "FineDataGridViewTextBoxColumn"
        Me.FineDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NoteDataGridViewTextBoxColumn
        '
        Me.NoteDataGridViewTextBoxColumn.DataPropertyName = "note"
        Me.NoteDataGridViewTextBoxColumn.HeaderText = "note"
        Me.NoteDataGridViewTextBoxColumn.Name = "NoteDataGridViewTextBoxColumn"
        Me.NoteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ControlloDataGridViewTextBoxColumn
        '
        Me.ControlloDataGridViewTextBoxColumn.DataPropertyName = "controllo"
        Me.ControlloDataGridViewTextBoxColumn.HeaderText = "controllo"
        Me.ControlloDataGridViewTextBoxColumn.Name = "ControlloDataGridViewTextBoxColumn"
        Me.ControlloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnagraficaDataGridViewTextBoxColumn
        '
        Me.AnagraficaDataGridViewTextBoxColumn.DataPropertyName = "anagrafica"
        Me.AnagraficaDataGridViewTextBoxColumn.HeaderText = "anagrafica"
        Me.AnagraficaDataGridViewTextBoxColumn.Name = "AnagraficaDataGridViewTextBoxColumn"
        Me.AnagraficaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VisionatoDataGridViewTextBoxColumn
        '
        Me.VisionatoDataGridViewTextBoxColumn.DataPropertyName = "visionato"
        Me.VisionatoDataGridViewTextBoxColumn.HeaderText = "visionato"
        Me.VisionatoDataGridViewTextBoxColumn.Name = "VisionatoDataGridViewTextBoxColumn"
        Me.VisionatoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AutorizzatoDataGridViewTextBoxColumn
        '
        Me.AutorizzatoDataGridViewTextBoxColumn.DataPropertyName = "autorizzato"
        Me.AutorizzatoDataGridViewTextBoxColumn.HeaderText = "autorizzato"
        Me.AutorizzatoDataGridViewTextBoxColumn.Name = "AutorizzatoDataGridViewTextBoxColumn"
        Me.AutorizzatoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantiereDataGridViewTextBoxColumn
        '
        Me.CantiereDataGridViewTextBoxColumn.DataPropertyName = "cantiere"
        Me.CantiereDataGridViewTextBoxColumn.HeaderText = "cantiere"
        Me.CantiereDataGridViewTextBoxColumn.Name = "CantiereDataGridViewTextBoxColumn"
        Me.CantiereDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsferie
        '
        Me.bsferie.DataMember = "DTferieutente"
        Me.bsferie.DataSource = Me.DSfestivita
        '
        'DSfestivita
        '
        Me.DSfestivita.DataSetName = "DSfestivita"
        Me.DSfestivita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dgwFoglioPresenza
        '
        Me.dgwFoglioPresenza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwFoglioPresenza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgwFoglioPresenza.Location = New System.Drawing.Point(3, 3)
        Me.dgwFoglioPresenza.Name = "dgwFoglioPresenza"
        Me.dgwFoglioPresenza.Size = New System.Drawing.Size(709, 756)
        Me.dgwFoglioPresenza.TabIndex = 3
        '
        'TTcmbmese
        '
        Me.TTcmbmese.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TTcmbmese.Name = "TTcmbmese"
        Me.TTcmbmese.Size = New System.Drawing.Size(121, 70)
        '
        'TTcmbanno
        '
        Me.TTcmbanno.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.TTcmbanno.Name = "TTcmbanno"
        Me.TTcmbanno.Size = New System.Drawing.Size(121, 70)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'PGbar
        '
        Me.PGbar.Name = "PGbar"
        Me.PGbar.Size = New System.Drawing.Size(400, 67)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTcmbmese, Me.TTcmbanno, Me.ToolStripSeparator1, Me.BTaggiorna, Me.BTgenera, Me.ttsButtonCaricaDati, Me.TTBTStampa, Me.BTtermina, Me.PGbar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 871)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1221, 70)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'BTaggiorna
        '
        Me.BTaggiorna.AutoSize = False
        Me.BTaggiorna.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTaggiorna.Image = Global.PoP2.Comuni.My.Resources.Resources.ricicla48
        Me.BTaggiorna.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BTaggiorna.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTaggiorna.Name = "BTaggiorna"
        Me.BTaggiorna.Size = New System.Drawing.Size(60, 70)
        Me.BTaggiorna.Text = "Aggiorna"
        Me.BTaggiorna.ToolTipText = "Ricarica le tabelle"
        '
        'BTgenera
        '
        Me.BTgenera.AutoSize = False
        Me.BTgenera.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTgenera.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_setting48
        Me.BTgenera.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BTgenera.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTgenera.Name = "BTgenera"
        Me.BTgenera.Size = New System.Drawing.Size(60, 70)
        Me.BTgenera.Text = "Genera"
        Me.BTgenera.ToolTipText = "Genera il documento"
        '
        'ttsButtonCaricaDati
        '
        Me.ttsButtonCaricaDati.AutoSize = False
        Me.ttsButtonCaricaDati.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ttsButtonCaricaDati.Image = Global.PoP2.Comuni.My.Resources.Resources.logoXLS
        Me.ttsButtonCaricaDati.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ttsButtonCaricaDati.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ttsButtonCaricaDati.Name = "ttsButtonCaricaDati"
        Me.ttsButtonCaricaDati.Size = New System.Drawing.Size(60, 70)
        Me.ttsButtonCaricaDati.Text = "Carica i dati in remoto"
        Me.ttsButtonCaricaDati.ToolTipText = "Crea una tabella Excel (Excel deve essere installato)"
        '
        'TTBTStampa
        '
        Me.TTBTStampa.AutoSize = False
        Me.TTBTStampa.Enabled = False
        Me.TTBTStampa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTStampa.Name = "TTBTStampa"
        Me.TTBTStampa.Size = New System.Drawing.Size(62, 70)
        Me.TTBTStampa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTStampa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTStampa.ToolTipText = "Genera i documenti selezionati e li stampa in PDF"
        Me.TTBTStampa.Visible = False
        '
        'BTtermina
        '
        Me.BTtermina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BTtermina.AutoSize = False
        Me.BTtermina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTtermina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.BTtermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BTtermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTtermina.Name = "BTtermina"
        Me.BTtermina.Size = New System.Drawing.Size(60, 60)
        Me.BTtermina.Text = "Termina"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "logoXLS.png")
        Me.ImageList1.Images.SetKeyName(1, "omino_ricarica.png")
        Me.ImageList1.Images.SetKeyName(2, "omino_setting48.png")
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 43
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Anagrafica"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Anagrafica"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 211
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn3.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "id"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 81
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "emailname"
        Me.DataGridViewTextBoxColumn4.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "emailname"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 129
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "fine"
        Me.DataGridViewTextBoxColumn5.HeaderText = "fine"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 88
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn6.HeaderText = "note"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 88
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "controllo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "controllo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 88
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "anagrafica"
        Me.DataGridViewTextBoxColumn8.HeaderText = "anagrafica"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 87
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "visionato"
        Me.DataGridViewTextBoxColumn11.HeaderText = "visionato"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 88
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "autorizzato"
        Me.DataGridViewTextBoxColumn12.HeaderText = "autorizzato"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 88
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "cantiere"
        Me.DataGridViewTextBoxColumn13.HeaderText = "cantiere"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.Width = 88
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn15.HeaderText = "id"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "id_cli"
        Me.DataGridViewTextBoxColumn16.HeaderText = "id_cli"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "id_des"
        Me.DataGridViewTextBoxColumn19.HeaderText = "id_des"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "lu_i"
        Me.DataGridViewTextBoxColumn20.HeaderText = "lu_i"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "lu_u"
        Me.DataGridViewTextBoxColumn21.HeaderText = "lu_u"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "ma_i"
        Me.DataGridViewTextBoxColumn22.HeaderText = "ma_i"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "ma_u"
        Me.DataGridViewTextBoxColumn23.HeaderText = "ma_u"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "me_i"
        Me.DataGridViewTextBoxColumn24.HeaderText = "me_i"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "me_u"
        Me.DataGridViewTextBoxColumn25.HeaderText = "me_u"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "gi_i"
        Me.DataGridViewTextBoxColumn26.HeaderText = "gi_i"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "gi_u"
        Me.DataGridViewTextBoxColumn27.HeaderText = "gi_u"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "ve_i"
        Me.DataGridViewTextBoxColumn28.HeaderText = "ve_i"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "ve_u"
        Me.DataGridViewTextBoxColumn29.HeaderText = "ve_u"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "sa_i"
        Me.DataGridViewTextBoxColumn30.HeaderText = "sa_i"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "sa_u"
        Me.DataGridViewTextBoxColumn31.HeaderText = "sa_u"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "do_i"
        Me.DataGridViewTextBoxColumn33.HeaderText = "do_i"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "do_u"
        Me.DataGridViewTextBoxColumn35.HeaderText = "do_u"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "anagrafica"
        Me.DataGridViewTextBoxColumn36.HeaderText = "anagrafica"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        Me.DataGridViewTextBoxColumn36.ReadOnly = True
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "destinatario"
        Me.DataGridViewTextBoxColumn37.HeaderText = "destinatario"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "societa"
        Me.DataGridViewTextBoxColumn38.HeaderText = "societa"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "inizio"
        Me.DataGridViewTextBoxColumn39.HeaderText = "inizio"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "fine"
        Me.DataGridViewTextBoxColumn40.HeaderText = "fine"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "attivo"
        Me.DataGridViewTextBoxColumn41.HeaderText = "attivo"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn42.HeaderText = "note"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DataGridViewTextBoxColumn43
        '
        Me.DataGridViewTextBoxColumn43.DataPropertyName = "quindicinale"
        Me.DataGridViewTextBoxColumn43.HeaderText = "quindicinale"
        Me.DataGridViewTextBoxColumn43.Name = "DataGridViewTextBoxColumn43"
        '
        'DataGridViewTextBoxColumn44
        '
        Me.DataGridViewTextBoxColumn44.DataPropertyName = "iddip"
        Me.DataGridViewTextBoxColumn44.HeaderText = "iddip"
        Me.DataGridViewTextBoxColumn44.Name = "DataGridViewTextBoxColumn44"
        '
        'DataGridViewTextBoxColumn45
        '
        Me.DataGridViewTextBoxColumn45.DataPropertyName = "iddes"
        Me.DataGridViewTextBoxColumn45.HeaderText = "iddes"
        Me.DataGridViewTextBoxColumn45.Name = "DataGridViewTextBoxColumn45"
        '
        'DataGridViewTextBoxColumn46
        '
        Me.DataGridViewTextBoxColumn46.DataPropertyName = "data"
        Me.DataGridViewTextBoxColumn46.HeaderText = "data"
        Me.DataGridViewTextBoxColumn46.Name = "DataGridViewTextBoxColumn46"
        '
        'DataGridViewTextBoxColumn47
        '
        Me.DataGridViewTextBoxColumn47.DataPropertyName = "ing"
        Me.DataGridViewTextBoxColumn47.HeaderText = "ing"
        Me.DataGridViewTextBoxColumn47.Name = "DataGridViewTextBoxColumn47"
        '
        'DataGridViewTextBoxColumn48
        '
        Me.DataGridViewTextBoxColumn48.DataPropertyName = "usc"
        Me.DataGridViewTextBoxColumn48.HeaderText = "usc"
        Me.DataGridViewTextBoxColumn48.Name = "DataGridViewTextBoxColumn48"
        '
        'DataGridViewTextBoxColumn49
        '
        Me.DataGridViewTextBoxColumn49.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn49.HeaderText = "note"
        Me.DataGridViewTextBoxColumn49.Name = "DataGridViewTextBoxColumn49"
        '
        'DataGridViewTextBoxColumn50
        '
        Me.DataGridViewTextBoxColumn50.DataPropertyName = "locazione"
        Me.DataGridViewTextBoxColumn50.HeaderText = "locazione"
        Me.DataGridViewTextBoxColumn50.Name = "DataGridViewTextBoxColumn50"
        '
        'DataGridViewTextBoxColumn51
        '
        Me.DataGridViewTextBoxColumn51.DataPropertyName = "anagrafica"
        Me.DataGridViewTextBoxColumn51.HeaderText = "anagrafica"
        Me.DataGridViewTextBoxColumn51.Name = "DataGridViewTextBoxColumn51"
        Me.DataGridViewTextBoxColumn51.ReadOnly = True
        '
        'DataGridViewTextBoxColumn52
        '
        Me.DataGridViewTextBoxColumn52.DataPropertyName = "idsost"
        Me.DataGridViewTextBoxColumn52.HeaderText = "idsost"
        Me.DataGridViewTextBoxColumn52.Name = "DataGridViewTextBoxColumn52"
        '
        'DataGridViewTextBoxColumn53
        '
        Me.DataGridViewTextBoxColumn53.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn53.HeaderText = "id"
        Me.DataGridViewTextBoxColumn53.Name = "DataGridViewTextBoxColumn53"
        '
        'DataGridViewTextBoxColumn54
        '
        Me.DataGridViewTextBoxColumn54.DataPropertyName = "id_dip"
        Me.DataGridViewTextBoxColumn54.FillWeight = 20.0!
        Me.DataGridViewTextBoxColumn54.HeaderText = "id_dip"
        Me.DataGridViewTextBoxColumn54.Name = "DataGridViewTextBoxColumn54"
        Me.DataGridViewTextBoxColumn54.Width = 26
        '
        'DataGridViewTextBoxColumn55
        '
        Me.DataGridViewTextBoxColumn55.DataPropertyName = "inizio"
        Me.DataGridViewTextBoxColumn55.HeaderText = "inizio"
        Me.DataGridViewTextBoxColumn55.Name = "DataGridViewTextBoxColumn55"
        Me.DataGridViewTextBoxColumn55.ReadOnly = True
        Me.DataGridViewTextBoxColumn55.Width = 132
        '
        'DataGridViewTextBoxColumn56
        '
        Me.DataGridViewTextBoxColumn56.DataPropertyName = "fine"
        Me.DataGridViewTextBoxColumn56.FillWeight = 40.0!
        Me.DataGridViewTextBoxColumn56.HeaderText = "fine"
        Me.DataGridViewTextBoxColumn56.Name = "DataGridViewTextBoxColumn56"
        Me.DataGridViewTextBoxColumn56.Width = 53
        '
        'DataGridViewTextBoxColumn57
        '
        Me.DataGridViewTextBoxColumn57.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn57.FillWeight = 60.0!
        Me.DataGridViewTextBoxColumn57.HeaderText = "note"
        Me.DataGridViewTextBoxColumn57.Name = "DataGridViewTextBoxColumn57"
        Me.DataGridViewTextBoxColumn57.Width = 80
        '
        'bsorariolavoro
        '
        Me.bsorariolavoro.DataMember = "DT_orario"
        Me.bsorariolavoro.DataSource = Me.DS_orari
        '
        'DS_orari
        '
        Me.DS_orari.DataSetName = "DS_orari"
        Me.DS_orari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TA_orario
        '
        Me.TA_orario.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager2.Connection = Nothing
        Me.TableAdapterManager2.UpdateOrder = PoP2.Comuni.DS_orariTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DS_ag
        '
        Me.DS_ag.DataSetName = "DS_ag"
        Me.DS_ag.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'bsPiano
        '
        Me.bsPiano.DataMember = "dtPiano"
        Me.bsPiano.DataSource = Me.DSfestivita
        '
        'BSpianotmp
        '
        Me.BSpianotmp.DataMember = "DTPianotmp"
        Me.BSpianotmp.DataSource = Me.DSfestivita
        '
        'bssostituzioni
        '
        Me.bssostituzioni.DataMember = "DTutentisostituzioni"
        Me.bssostituzioni.DataSource = Me.DSfestivita
        '
        'bspianodilavoro
        '
        Me.bspianodilavoro.DataMember = "DTpianodilavoro"
        Me.bspianodilavoro.DataSource = Me.DSfestivita
        '
        'TAferieutente
        '
        Me.TAferieutente.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PoP2.Comuni.DSfestivitaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TApianodilavoro
        '
        Me.TApianodilavoro.ClearBeforeFill = True
        '
        'bstipoorario
        '
        Me.bstipoorario.DataMember = "DTtipoorario"
        Me.bstipoorario.DataSource = Me.DSfestivita
        '
        'TAtipoorario
        '
        Me.TAtipoorario.ClearBeforeFill = True
        '
        'TAutentisostituzioni
        '
        Me.TAutentisostituzioni.ClearBeforeFill = True
        '
        'TaPiano
        '
        Me.TaPiano.ClearBeforeFill = True
        '
        'frmDipendentiGestioneFerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1221, 941)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDipendentiGestioneFerie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Programmazione Mensile per dipendente"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.DGelencoUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsutenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.TableLayoutPanel5.ResumeLayout(False)
        CType(Me.dgwFerieDipendente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsferie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSfestivita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwFoglioPresenza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.bsorariolavoro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_orari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPiano, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSpianotmp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bssostituzioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bspianodilavoro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bstipoorario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents bsutenti As BindingSource
    Friend WithEvents TA_utenti As DS_utentiTableAdapters.TA_utenti
    Friend WithEvents TableAdapterManager As DS_utentiTableAdapters.TableAdapterManager
    Friend WithEvents DSfestivita As DSfestivita
    Friend WithEvents bsferie As BindingSource
    Friend WithEvents TAferieutente As DSfestivitaTableAdapters.TAferieutente
    Friend WithEvents TableAdapterManager1 As DSfestivitaTableAdapters.TableAdapterManager
    Friend WithEvents bspianodilavoro As BindingSource
    Friend WithEvents TApianodilavoro As DSfestivitaTableAdapters.TApianodilavoro
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DS_orari As DS_orari
    Friend WithEvents bsorariolavoro As BindingSource
    Friend WithEvents TA_orario As DS_orariTableAdapters.TA_orario
    Friend WithEvents TableAdapterManager2 As DS_orariTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn43 As DataGridViewTextBoxColumn
    Friend WithEvents bstipoorario As BindingSource
    Friend WithEvents TAtipoorario As DSfestivitaTableAdapters.TAtipoorario
    Friend WithEvents bssostituzioni As BindingSource
    Friend WithEvents TAutentisostituzioni As DSfestivitaTableAdapters.TAutentisostituzioni
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn44 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn45 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn46 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn47 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn48 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn49 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn50 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn51 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn52 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn53 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn54 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn55 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn56 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn57 As DataGridViewTextBoxColumn
    Friend WithEvents BSpianotmp As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DGelencoUtenti As DataGridView
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents PGferiecliente As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents CKclientichiusi As CheckBox
    Friend WithEvents ckFerienonconfermate As CheckBox
    Friend WithEvents CartellaDestinazione As FolderBrowserDialog
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewCheckBoxColumn
    Friend WithEvents DGWCidDip As DataGridViewTextBoxColumn
    Friend WithEvents dgwcAnagraficaUtente As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents TaPiano As DSfestivitaTableAdapters.taPiano
    Friend WithEvents TTcmbmese As ToolStripComboBox
    Friend WithEvents TTcmbanno As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BTaggiorna As ToolStripButton
    Friend WithEvents BTgenera As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents BTtermina As ToolStripButton
    Friend WithEvents PGbar As ToolStripProgressBar
    Friend WithEvents ttsButtonCaricaDati As ToolStripButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents bsPiano As BindingSource
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents dgwFoglioPresenza As DataGridView
    Friend WithEvents dgwFerieDipendente As DataGridView
    Friend WithEvents DS_ag As DS_ag
    Friend WithEvents InizioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NoteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ControlloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnagraficaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VisionatoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutorizzatoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantiereDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents ckNonVisualizzaLavoriInFerie As CheckBox
End Class
