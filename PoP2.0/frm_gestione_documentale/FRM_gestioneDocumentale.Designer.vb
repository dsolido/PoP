<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_gestioneDocumentale
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_gestioneDocumentale))
        Me.DG_cantieri = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_cantieri = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_gestione_documenti = New PoP2.Comuni.DS_gestione_documenti()
        Me.DG_file = New System.Windows.Forms.DataGridView()
        Me.COL_data_file = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_fileAlias = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.COL_descrizione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COL_download = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RELcantierefile = New System.Windows.Forms.BindingSource(Me.components)
        Me.RELfilecategoria = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.LB_ricerca = New System.Windows.Forms.Label()
        Me.TX_ricerca = New System.Windows.Forms.TextBox()
        Me.BT_cercaCartella = New System.Windows.Forms.Button()
        Me.immagini = New System.Windows.Forms.ImageList(Me.components)
        Me.LB_deposito = New System.Windows.Forms.Label()
        Me.TX_deposito = New System.Windows.Forms.TextBox()
        Me.CercaCartella = New System.Windows.Forms.FolderBrowserDialog()
        Me.BT_caricadocumento = New System.Windows.Forms.Button()
        Me.ApreDocumento = New System.Windows.Forms.OpenFileDialog()
        Me.RELCantieriCategorie = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.LB_ricercafile = New System.Windows.Forms.Label()
        Me.TZ_ricercafile = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_elimina = New System.Windows.Forms.Button()
        Me.TableAdapterManager = New PoP2.Comuni.DS_gestione_documentiTableAdapters.TableAdapterManager()
        Me.TA_cantieri = New PoP2.Comuni.DS_gestione_documentiTableAdapters.TA_cantieri()
        Me.TA_file = New PoP2.Comuni.DS_gestione_documentiTableAdapters.TA_file()
        Me.TA_categorie = New PoP2.Comuni.DS_gestione_documentiTableAdapters.TA_categorie()
        CType(Me.DG_cantieri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_cantieri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_gestione_documenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_file, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RELcantierefile, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RELfilecategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.RELCantieriCategorie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_cantieri
        '
        Me.DG_cantieri.AllowUserToAddRows = False
        Me.DG_cantieri.AllowUserToDeleteRows = False
        Me.DG_cantieri.AutoGenerateColumns = False
        Me.DG_cantieri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_cantieri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_cantieri.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.DG_cantieri.DataSource = Me.BS_cantieri
        Me.DG_cantieri.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_cantieri.Location = New System.Drawing.Point(3, 3)
        Me.DG_cantieri.Name = "DG_cantieri"
        Me.DG_cantieri.ReadOnly = True
        Me.DG_cantieri.RowHeadersWidth = 4
        Me.DG_cantieri.Size = New System.Drawing.Size(222, 445)
        Me.DG_cantieri.TabIndex = 0
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "societa"
        Me.DataGridViewTextBoxColumn2.HeaderText = "societa"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'BS_cantieri
        '
        Me.BS_cantieri.DataMember = "DT_cantieri"
        Me.BS_cantieri.DataSource = Me.DS_gestione_documenti
        '
        'DS_gestione_documenti
        '
        Me.DS_gestione_documenti.DataSetName = "DS_gestione_documenti"
        Me.DS_gestione_documenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DG_file
        '
        Me.DG_file.AllowUserToAddRows = False
        Me.DG_file.AllowUserToDeleteRows = False
        Me.DG_file.AutoGenerateColumns = False
        Me.DG_file.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_file.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_file.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COL_data_file, Me.COL_fileAlias, Me.COL_descrizione, Me.COL_download})
        Me.DG_file.DataSource = Me.RELcantierefile
        Me.DG_file.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_file.Location = New System.Drawing.Point(231, 3)
        Me.DG_file.Name = "DG_file"
        Me.DG_file.RowHeadersWidth = 4
        Me.DG_file.Size = New System.Drawing.Size(662, 445)
        Me.DG_file.TabIndex = 1
        '
        'COL_data_file
        '
        Me.COL_data_file.DataPropertyName = "data_file"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.COL_data_file.DefaultCellStyle = DataGridViewCellStyle1
        Me.COL_data_file.FillWeight = 40.0!
        Me.COL_data_file.HeaderText = "data"
        Me.COL_data_file.MinimumWidth = 10
        Me.COL_data_file.Name = "COL_data_file"
        Me.COL_data_file.ReadOnly = True
        '
        'COL_fileAlias
        '
        Me.COL_fileAlias.DataPropertyName = "file_alias"
        Me.COL_fileAlias.HeaderText = "Nome"
        Me.COL_fileAlias.MinimumWidth = 10
        Me.COL_fileAlias.Name = "COL_fileAlias"
        Me.COL_fileAlias.ReadOnly = True
        Me.COL_fileAlias.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.COL_fileAlias.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'COL_descrizione
        '
        Me.COL_descrizione.DataPropertyName = "descrizione"
        Me.COL_descrizione.HeaderText = "descrizione"
        Me.COL_descrizione.MinimumWidth = 10
        Me.COL_descrizione.Name = "COL_descrizione"
        '
        'COL_download
        '
        Me.COL_download.DataPropertyName = "downloads"
        Me.COL_download.FillWeight = 20.0!
        Me.COL_download.HeaderText = "DL"
        Me.COL_download.MinimumWidth = 10
        Me.COL_download.Name = "COL_download"
        Me.COL_download.ReadOnly = True
        '
        'RELcantierefile
        '
        Me.RELcantierefile.DataMember = "REL_cantiere_file"
        Me.RELcantierefile.DataSource = Me.BS_cantieri
        '
        'RELfilecategoria
        '
        Me.RELfilecategoria.DataMember = "REL_file_Categoria"
        Me.RELfilecategoria.DataSource = Me.RELcantierefile
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.61491!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.38509!))
        Me.TableLayoutPanel3.Controls.Add(Me.LB_ricerca, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.TX_ricerca, 1, 0)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 454)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(222, 32)
        Me.TableLayoutPanel3.TabIndex = 10
        '
        'LB_ricerca
        '
        Me.LB_ricerca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_ricerca.Location = New System.Drawing.Point(3, 3)
        Me.LB_ricerca.Margin = New System.Windows.Forms.Padding(3)
        Me.LB_ricerca.Name = "LB_ricerca"
        Me.LB_ricerca.Size = New System.Drawing.Size(86, 26)
        Me.LB_ricerca.TabIndex = 9
        Me.LB_ricerca.Text = "Ricerca"
        Me.LB_ricerca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TX_ricerca
        '
        Me.TX_ricerca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TX_ricerca.Location = New System.Drawing.Point(93, 5)
        Me.TX_ricerca.Margin = New System.Windows.Forms.Padding(1, 5, 1, 1)
        Me.TX_ricerca.Name = "TX_ricerca"
        Me.TX_ricerca.Size = New System.Drawing.Size(128, 22)
        Me.TX_ricerca.TabIndex = 5
        '
        'BT_cercaCartella
        '
        Me.BT_cercaCartella.ImageIndex = 0
        Me.BT_cercaCartella.ImageList = Me.immagini
        Me.BT_cercaCartella.Location = New System.Drawing.Point(498, 0)
        Me.BT_cercaCartella.Name = "BT_cercaCartella"
        Me.BT_cercaCartella.Size = New System.Drawing.Size(37, 27)
        Me.BT_cercaCartella.TabIndex = 17
        Me.BT_cercaCartella.UseVisualStyleBackColor = True
        '
        'immagini
        '
        Me.immagini.ImageStream = CType(resources.GetObject("immagini.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.immagini.TransparentColor = System.Drawing.Color.Transparent
        Me.immagini.Images.SetKeyName(0, "OminoCartelletta48.png")
        '
        'LB_deposito
        '
        Me.LB_deposito.AutoSize = True
        Me.LB_deposito.Location = New System.Drawing.Point(12, 9)
        Me.LB_deposito.Name = "LB_deposito"
        Me.LB_deposito.Size = New System.Drawing.Size(167, 16)
        Me.LB_deposito.TabIndex = 14
        Me.LB_deposito.Text = "Cartella remota documenti:"
        '
        'TX_deposito
        '
        Me.TX_deposito.Location = New System.Drawing.Point(189, 3)
        Me.TX_deposito.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_deposito.Name = "TX_deposito"
        Me.TX_deposito.Size = New System.Drawing.Size(296, 22)
        Me.TX_deposito.TabIndex = 13
        '
        'BT_caricadocumento
        '
        Me.BT_caricadocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_caricadocumento.Image = CType(resources.GetObject("BT_caricadocumento.Image"), System.Drawing.Image)
        Me.BT_caricadocumento.Location = New System.Drawing.Point(1, 1)
        Me.BT_caricadocumento.Margin = New System.Windows.Forms.Padding(1)
        Me.BT_caricadocumento.Name = "BT_caricadocumento"
        Me.BT_caricadocumento.Size = New System.Drawing.Size(60, 64)
        Me.BT_caricadocumento.TabIndex = 18
        Me.BT_caricadocumento.UseVisualStyleBackColor = True
        '
        'ApreDocumento
        '
        Me.ApreDocumento.FileName = "*"
        '
        'RELCantieriCategorie
        '
        Me.RELCantieriCategorie.DataMember = "REL_CantieriCategorie"
        Me.RELCantieriCategorie.DataSource = Me.BS_cantieri
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.42373!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.57627!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_cantieri, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_file, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(15, 73)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.22904!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.770961!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(961, 489)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.5272!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.4728!))
        Me.TableLayoutPanel2.Controls.Add(Me.LB_ricercafile, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TZ_ricercafile, 1, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(231, 454)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(662, 32)
        Me.TableLayoutPanel2.TabIndex = 19
        '
        'LB_ricercafile
        '
        Me.LB_ricercafile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LB_ricercafile.Location = New System.Drawing.Point(3, 3)
        Me.LB_ricercafile.Margin = New System.Windows.Forms.Padding(3)
        Me.LB_ricercafile.Name = "LB_ricercafile"
        Me.LB_ricercafile.Size = New System.Drawing.Size(103, 26)
        Me.LB_ricercafile.TabIndex = 9
        Me.LB_ricercafile.Text = "Ricerca"
        Me.LB_ricercafile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TZ_ricercafile
        '
        Me.TZ_ricercafile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TZ_ricercafile.Location = New System.Drawing.Point(110, 5)
        Me.TZ_ricercafile.Margin = New System.Windows.Forms.Padding(1, 5, 1, 1)
        Me.TZ_ricercafile.Name = "TZ_ricercafile"
        Me.TZ_ricercafile.Size = New System.Drawing.Size(551, 22)
        Me.TZ_ricercafile.TabIndex = 5
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 1
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.BT_elimina, 0, 1)
        Me.TableLayoutPanel4.Controls.Add(Me.BT_caricadocumento, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(897, 1)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 2
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(62, 132)
        Me.TableLayoutPanel4.TabIndex = 20
        '
        'BT_elimina
        '
        Me.BT_elimina.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BT_elimina.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_cestino48
        Me.BT_elimina.Location = New System.Drawing.Point(1, 67)
        Me.BT_elimina.Margin = New System.Windows.Forms.Padding(1)
        Me.BT_elimina.Name = "BT_elimina"
        Me.BT_elimina.Size = New System.Drawing.Size(60, 64)
        Me.BT_elimina.TabIndex = 19
        Me.BT_elimina.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_gestione_documentiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TA_cantieri
        '
        Me.TA_cantieri.ClearBeforeFill = True
        '
        'TA_file
        '
        Me.TA_file.ClearBeforeFill = True
        '
        'TA_categorie
        '
        Me.TA_categorie.ClearBeforeFill = True
        '
        'FRM_gestioneDocumentale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(985, 617)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BT_cercaCartella)
        Me.Controls.Add(Me.LB_deposito)
        Me.Controls.Add(Me.TX_deposito)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRM_gestioneDocumentale"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione Documentale"
        CType(Me.DG_cantieri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_cantieri, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_gestione_documenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_file, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RELcantierefile, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RELfilecategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.RELCantieriCategorie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_gestione_documenti As DS_gestione_documenti
    Friend WithEvents TableAdapterManager As DS_gestione_documentiTableAdapters.TableAdapterManager
    Friend WithEvents BS_cantieri As BindingSource
    Friend WithEvents TA_cantieri As DS_gestione_documentiTableAdapters.TA_cantieri
    Friend WithEvents DG_cantieri As DataGridView
    Friend WithEvents TA_file As DS_gestione_documentiTableAdapters.TA_file
    Friend WithEvents DG_file As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents RELcantierefile As BindingSource
    Friend WithEvents RELfilecategoria As BindingSource
    Friend WithEvents TA_categorie As DS_gestione_documentiTableAdapters.TA_categorie
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents LB_ricerca As Label
    Friend WithEvents TX_ricerca As TextBox
    Friend WithEvents BT_cercaCartella As Button
    Friend WithEvents LB_deposito As Label
    Friend WithEvents TX_deposito As TextBox
    Friend WithEvents immagini As ImageList
    Friend WithEvents CercaCartella As FolderBrowserDialog
    Friend WithEvents BT_caricadocumento As Button
    Friend WithEvents ApreDocumento As OpenFileDialog
    Friend WithEvents RELCantieriCategorie As BindingSource
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents LB_ricercafile As Label
    Friend WithEvents TZ_ricercafile As TextBox
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents BT_elimina As Button
    Friend WithEvents COL_data_file As DataGridViewTextBoxColumn
    Friend WithEvents COL_fileAlias As DataGridViewLinkColumn
    Friend WithEvents COL_descrizione As DataGridViewTextBoxColumn
    Friend WithEvents COL_download As DataGridViewTextBoxColumn
End Class
