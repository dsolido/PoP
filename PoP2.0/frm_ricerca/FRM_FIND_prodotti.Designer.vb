<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_FIND_prodotti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FIND_prodotti))
        Me.BS_prodotti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Ordini = New PoP2.Comuni.DS_Ordini()
        Me.TA_prodotti = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_prodotti()
        Me.TableAdapterManager = New PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager()
        Me.BSRRG = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_ordinirighe = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_ordinirighe()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BS_storico = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_storico = New PoP2.Comuni.DS_OrdiniTableAdapters.DT_storicoTableAdapter()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TX_cercastorico = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DG_prodotti = New System.Windows.Forms.DataGridView()
        Me.Col_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DG_storico = New System.Windows.Forms.DataGridView()
        Me.DataordineDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzounitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ScontoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrezzounitarioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FornitoreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Storico_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BT_conferma = New System.Windows.Forms.Button()
        Me.BT_termina = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_ricerca = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.BS_prodotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSRRG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_storico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DG_prodotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_storico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BS_prodotti
        '
        Me.BS_prodotti.DataMember = "DT_prodotti"
        Me.BS_prodotti.DataSource = Me.DS_Ordini
        '
        'DS_Ordini
        '
        Me.DS_Ordini.DataSetName = "DS_Ordini"
        Me.DS_Ordini.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_prodotti
        '
        Me.TA_prodotti.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BSRRG
        '
        Me.BSRRG.DataMember = "DT_ordinirighe"
        Me.BSRRG.DataSource = Me.DS_Ordini
        '
        'TA_ordinirighe
        '
        Me.TA_ordinirighe.ClearBeforeFill = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(396, 246)
        Me.ReportViewer1.TabIndex = 0
        '
        'BS_storico
        '
        Me.BS_storico.DataMember = "DT_storico"
        Me.BS_storico.DataSource = Me.DS_Ordini
        '
        'TA_storico
        '
        Me.TA_storico.ClearBeforeFill = True
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 344)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 16)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Ricerca nello storico"
        '
        'TX_cercastorico
        '
        Me.TX_cercastorico.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TX_cercastorico.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_cercastorico.Location = New System.Drawing.Point(16, 363)
        Me.TX_cercastorico.Name = "TX_cercastorico"
        Me.TX_cercastorico.Size = New System.Drawing.Size(240, 27)
        Me.TX_cercastorico.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.TX_cercastorico, "Ricerca all'interno degli ordini già fatti al cliente")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_prodotti, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DG_storico, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 42)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85141!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.1486!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1271, 294)
        Me.TableLayoutPanel1.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(639, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(196, 23)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Prodotti Disponibili"
        '
        'DG_prodotti
        '
        Me.DG_prodotti.AllowUserToAddRows = False
        Me.DG_prodotti.AllowUserToDeleteRows = False
        Me.DG_prodotti.AutoGenerateColumns = False
        Me.DG_prodotti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_prodotti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_prodotti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Col_id, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn7})
        Me.DG_prodotti.DataSource = Me.BS_prodotti
        Me.DG_prodotti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_prodotti.Location = New System.Drawing.Point(638, 42)
        Me.DG_prodotti.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DG_prodotti.Name = "DG_prodotti"
        Me.DG_prodotti.ReadOnly = True
        Me.DG_prodotti.RowHeadersWidth = 4
        Me.DG_prodotti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_prodotti.Size = New System.Drawing.Size(630, 248)
        Me.DG_prodotti.TabIndex = 0
        '
        'Col_id
        '
        Me.Col_id.DataPropertyName = "id"
        Me.Col_id.HeaderText = "id"
        Me.Col_id.Name = "Col_id"
        Me.Col_id.ReadOnly = True
        Me.Col_id.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "prodotto"
        Me.DataGridViewTextBoxColumn11.FillWeight = 35.0!
        Me.DataGridViewTextBoxColumn11.HeaderText = "Prodotto"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "prezzounitario"
        Me.DataGridViewTextBoxColumn4.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn4.HeaderText = "Prezzo"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "quantita_conf"
        Me.DataGridViewTextBoxColumn6.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn6.HeaderText = "Q.tà"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "prezzoconfezione"
        Me.DataGridViewTextBoxColumn2.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn2.HeaderText = "Conf/€"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "sconto"
        Me.DataGridViewTextBoxColumn3.FillWeight = 8.0!
        Me.DataGridViewTextBoxColumn3.HeaderText = "SC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "fornitore"
        Me.DataGridViewTextBoxColumn1.FillWeight = 15.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Forn"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "tipoconfezione"
        Me.DataGridViewTextBoxColumn5.FillWeight = 8.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "CNF"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "note"
        Me.DataGridViewTextBoxColumn7.FillWeight = 30.0!
        Me.DataGridViewTextBoxColumn7.HeaderText = "Note"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DG_storico
        '
        Me.DG_storico.AllowUserToAddRows = False
        Me.DG_storico.AllowUserToDeleteRows = False
        Me.DG_storico.AutoGenerateColumns = False
        Me.DG_storico.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_storico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_storico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataordineDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn, Me.QuantitaDataGridViewTextBoxColumn, Me.PrezzounitarioDataGridViewTextBoxColumn, Me.ScontoDataGridViewTextBoxColumn, Me.PrezzounitarioDataGridViewTextBoxColumn1, Me.FornitoreDataGridViewTextBoxColumn, Me.Storico_id})
        Me.DG_storico.DataSource = Me.BS_storico
        Me.DG_storico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DG_storico.Location = New System.Drawing.Point(4, 42)
        Me.DG_storico.Name = "DG_storico"
        Me.DG_storico.ReadOnly = True
        Me.DG_storico.RowHeadersWidth = 4
        Me.DG_storico.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_storico.Size = New System.Drawing.Size(628, 248)
        Me.DG_storico.TabIndex = 17
        '
        'DataordineDataGridViewTextBoxColumn
        '
        Me.DataordineDataGridViewTextBoxColumn.DataPropertyName = "data_ordine"
        Me.DataordineDataGridViewTextBoxColumn.FillWeight = 10.0!
        Me.DataordineDataGridViewTextBoxColumn.HeaderText = "Data"
        Me.DataordineDataGridViewTextBoxColumn.Name = "DataordineDataGridViewTextBoxColumn"
        Me.DataordineDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.FillWeight = 25.0!
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "Prodotto"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        Me.DescrizioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'QuantitaDataGridViewTextBoxColumn
        '
        Me.QuantitaDataGridViewTextBoxColumn.DataPropertyName = "quantita"
        Me.QuantitaDataGridViewTextBoxColumn.FillWeight = 5.0!
        Me.QuantitaDataGridViewTextBoxColumn.HeaderText = "Q.tà"
        Me.QuantitaDataGridViewTextBoxColumn.Name = "QuantitaDataGridViewTextBoxColumn"
        Me.QuantitaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrezzounitarioDataGridViewTextBoxColumn
        '
        Me.PrezzounitarioDataGridViewTextBoxColumn.DataPropertyName = "prezzo_unitario"
        Me.PrezzounitarioDataGridViewTextBoxColumn.FillWeight = 7.0!
        Me.PrezzounitarioDataGridViewTextBoxColumn.HeaderText = "Un/€"
        Me.PrezzounitarioDataGridViewTextBoxColumn.Name = "PrezzounitarioDataGridViewTextBoxColumn"
        Me.PrezzounitarioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ScontoDataGridViewTextBoxColumn
        '
        Me.ScontoDataGridViewTextBoxColumn.DataPropertyName = "sconto"
        Me.ScontoDataGridViewTextBoxColumn.FillWeight = 5.0!
        Me.ScontoDataGridViewTextBoxColumn.HeaderText = "SC"
        Me.ScontoDataGridViewTextBoxColumn.Name = "ScontoDataGridViewTextBoxColumn"
        Me.ScontoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrezzounitarioDataGridViewTextBoxColumn1
        '
        Me.PrezzounitarioDataGridViewTextBoxColumn1.DataPropertyName = "prezzounitario"
        Me.PrezzounitarioDataGridViewTextBoxColumn1.FillWeight = 7.0!
        Me.PrezzounitarioDataGridViewTextBoxColumn1.HeaderText = "Conf/€"
        Me.PrezzounitarioDataGridViewTextBoxColumn1.Name = "PrezzounitarioDataGridViewTextBoxColumn1"
        Me.PrezzounitarioDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FornitoreDataGridViewTextBoxColumn
        '
        Me.FornitoreDataGridViewTextBoxColumn.DataPropertyName = "fornitore"
        Me.FornitoreDataGridViewTextBoxColumn.FillWeight = 10.0!
        Me.FornitoreDataGridViewTextBoxColumn.HeaderText = "Forn"
        Me.FornitoreDataGridViewTextBoxColumn.Name = "FornitoreDataGridViewTextBoxColumn"
        Me.FornitoreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Storico_id
        '
        Me.Storico_id.DataPropertyName = "id"
        Me.Storico_id.HeaderText = "id"
        Me.Storico_id.Name = "Storico_id"
        Me.Storico_id.ReadOnly = True
        Me.Storico_id.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(4, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(391, 23)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Storico Prodotti già utilizzati dal cliente"
        '
        'BT_conferma
        '
        Me.BT_conferma.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BT_conferma.Image = Global.PoP2.Comuni.My.Resources.Resources.ominoConferma48
        Me.BT_conferma.Location = New System.Drawing.Point(1161, 345)
        Me.BT_conferma.Name = "BT_conferma"
        Me.BT_conferma.Size = New System.Drawing.Size(58, 68)
        Me.BT_conferma.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.BT_conferma, "Conferma")
        Me.BT_conferma.UseVisualStyleBackColor = True
        '
        'BT_termina
        '
        Me.BT_termina.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BT_termina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.BT_termina.Location = New System.Drawing.Point(1225, 344)
        Me.BT_termina.Name = "BT_termina"
        Me.BT_termina.Size = New System.Drawing.Size(58, 68)
        Me.BT_termina.TabIndex = 4
        Me.BT_termina.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(650, 345)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Ricerca nei prodotti"
        '
        'TX_ricerca
        '
        Me.TX_ricerca.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.TX_ricerca.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TX_ricerca.Location = New System.Drawing.Point(650, 364)
        Me.TX_ricerca.Name = "TX_ricerca"
        Me.TX_ricerca.Size = New System.Drawing.Size(240, 27)
        Me.TX_ricerca.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.TX_ricerca, "Ricerca all'interno dell'archivio prodotti")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 430)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1295, 25)
        Me.ToolStrip1.TabIndex = 35
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(770, 22)
        Me.ToolStripLabel1.Text = "Per confermare un nuovo prodotto, cliccare sul pulsante CONFERMA, per inserire un" &
    " nuovo prodotto da storico, cliccare sul prodotto selezionato"
        '
        'FRM_FIND_prodotti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1295, 455)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TX_cercastorico)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.BT_conferma)
        Me.Controls.Add(Me.BT_termina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TX_ricerca)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_FIND_prodotti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Trova Prodotti"
        CType(Me.BS_prodotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSRRG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_storico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DG_prodotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_storico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_Ordini As DS_Ordini
    Friend WithEvents BS_prodotti As BindingSource
    Friend WithEvents TA_prodotti As DS_OrdiniTableAdapters.TA_prodotti
    Friend WithEvents TableAdapterManager As DS_OrdiniTableAdapters.TableAdapterManager
    Friend WithEvents BSRRG As BindingSource
    Friend WithEvents TA_ordinirighe As DS_OrdiniTableAdapters.TA_ordinirighe
    Private WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BS_storico As BindingSource
    Friend WithEvents TA_storico As DS_OrdiniTableAdapters.DT_storicoTableAdapter
    Friend WithEvents Label4 As Label
    Friend WithEvents TX_cercastorico As TextBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents DG_storico As DataGridView
    Friend WithEvents DG_prodotti As DataGridView
    Friend WithEvents Col_id As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents BT_conferma As Button
    Friend WithEvents BT_termina As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TX_ricerca As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents DataordineDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantitaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezzounitarioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ScontoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrezzounitarioDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FornitoreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Storico_id As DataGridViewTextBoxColumn
End Class
