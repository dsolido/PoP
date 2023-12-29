<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_separatorePDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_separatorePDF))
        Me.DG_utenti = New System.Windows.Forms.DataGridView()
        Me.BS_utenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.ApreDocumento = New System.Windows.Forms.OpenFileDialog()
        Me.TX_deposito = New System.Windows.Forms.TextBox()
        Me.LB_deposito = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_analizzato = New System.Windows.Forms.TextBox()
        Me.BT_cercaCartella = New System.Windows.Forms.Button()
        Me.immagini = New System.Windows.Forms.ImageList(Me.components)
        Me.CercaCartella = New System.Windows.Forms.FolderBrowserDialog()
        Me.PB_avanzamento = New System.Windows.Forms.ProgressBar()
        Me.BT_termina = New System.Windows.Forms.Button()
        Me.BT_cercadocumento = New System.Windows.Forms.Button()
        Me.BT_ricerca = New System.Windows.Forms.Button()
        Me.LB_info = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PNLConfermato = New System.Windows.Forms.Panel()
        Me.PNLsalvataggio = New System.Windows.Forms.Panel()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.cmbMese = New System.Windows.Forms.ToolStripComboBox()
        Me.cmbAnno = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.tx_testoricerca = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripLabel3 = New System.Windows.Forms.ToolStripLabel()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCanagrafica = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColCF = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DG_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DG_utenti
        '
        Me.DG_utenti.AllowUserToAddRows = False
        Me.DG_utenti.AllowUserToDeleteRows = False
        Me.DG_utenti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_utenti.AutoGenerateColumns = False
        Me.DG_utenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_utenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_utenti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWCanagrafica, Me.ColCF})
        Me.DG_utenti.DataSource = Me.BS_utenti
        Me.DG_utenti.Location = New System.Drawing.Point(18, 138)
        Me.DG_utenti.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_utenti.Name = "DG_utenti"
        Me.DG_utenti.ReadOnly = True
        Me.DG_utenti.RowHeadersWidth = 4
        Me.DG_utenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_utenti.Size = New System.Drawing.Size(595, 319)
        Me.DG_utenti.TabIndex = 3
        '
        'ApreDocumento
        '
        Me.ApreDocumento.FileName = "OpenFileDialog1"
        '
        'TX_deposito
        '
        Me.TX_deposito.BackColor = System.Drawing.SystemColors.Menu
        Me.TX_deposito.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TX_deposito.Enabled = False
        Me.TX_deposito.Location = New System.Drawing.Point(310, 93)
        Me.TX_deposito.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_deposito.Name = "TX_deposito"
        Me.TX_deposito.Size = New System.Drawing.Size(296, 15)
        Me.TX_deposito.TabIndex = 4
        '
        'LB_deposito
        '
        Me.LB_deposito.AutoSize = True
        Me.LB_deposito.Location = New System.Drawing.Point(15, 92)
        Me.LB_deposito.Name = "LB_deposito"
        Me.LB_deposito.Size = New System.Drawing.Size(131, 16)
        Me.LB_deposito.TabIndex = 5
        Me.LB_deposito.Text = "Scegli dove salvare:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Scegli il Documento PDF:"
        '
        'TX_analizzato
        '
        Me.TX_analizzato.BackColor = System.Drawing.SystemColors.Menu
        Me.TX_analizzato.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TX_analizzato.Enabled = False
        Me.TX_analizzato.Location = New System.Drawing.Point(310, 31)
        Me.TX_analizzato.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_analizzato.Name = "TX_analizzato"
        Me.TX_analizzato.Size = New System.Drawing.Size(296, 15)
        Me.TX_analizzato.TabIndex = 6
        '
        'BT_cercaCartella
        '
        Me.BT_cercaCartella.Image = Global.PoP2.Comuni.My.Resources.Resources.ominoarchiviodocumenti
        Me.BT_cercaCartella.Location = New System.Drawing.Point(192, 70)
        Me.BT_cercaCartella.Name = "BT_cercaCartella"
        Me.BT_cercaCartella.Size = New System.Drawing.Size(57, 61)
        Me.BT_cercaCartella.TabIndex = 1
        Me.BT_cercaCartella.UseVisualStyleBackColor = True
        '
        'immagini
        '
        Me.immagini.ImageStream = CType(resources.GetObject("immagini.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.immagini.TransparentColor = System.Drawing.Color.Transparent
        Me.immagini.Images.SetKeyName(0, "OminoCartelletta48.png")
        '
        'PB_avanzamento
        '
        Me.PB_avanzamento.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PB_avanzamento.Location = New System.Drawing.Point(0, 606)
        Me.PB_avanzamento.Name = "PB_avanzamento"
        Me.PB_avanzamento.Size = New System.Drawing.Size(631, 23)
        Me.PB_avanzamento.TabIndex = 9
        '
        'BT_termina
        '
        Me.BT_termina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_termina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.BT_termina.Location = New System.Drawing.Point(556, 472)
        Me.BT_termina.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_termina.Name = "BT_termina"
        Me.BT_termina.Size = New System.Drawing.Size(57, 61)
        Me.BT_termina.TabIndex = 4
        Me.BT_termina.UseVisualStyleBackColor = True
        '
        'BT_cercadocumento
        '
        Me.BT_cercadocumento.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_carta48x48
        Me.BT_cercadocumento.Location = New System.Drawing.Point(192, 8)
        Me.BT_cercadocumento.Name = "BT_cercadocumento"
        Me.BT_cercadocumento.Size = New System.Drawing.Size(57, 61)
        Me.BT_cercadocumento.TabIndex = 0
        Me.BT_cercadocumento.UseVisualStyleBackColor = True
        '
        'BT_ricerca
        '
        Me.BT_ricerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BT_ricerca.Image = Global.PoP2.Comuni.My.Resources.Resources.ominofoglioore
        Me.BT_ricerca.Location = New System.Drawing.Point(192, 472)
        Me.BT_ricerca.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_ricerca.Name = "BT_ricerca"
        Me.BT_ricerca.Size = New System.Drawing.Size(57, 61)
        Me.BT_ricerca.TabIndex = 2
        Me.BT_ricerca.UseVisualStyleBackColor = True
        '
        'LB_info
        '
        Me.LB_info.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LB_info.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_info.Location = New System.Drawing.Point(0, 579)
        Me.LB_info.Name = "LB_info"
        Me.LB_info.Size = New System.Drawing.Size(631, 27)
        Me.LB_info.TabIndex = 14
        Me.LB_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 494)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 16)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Procedi all'elaborazione:"
        '
        'PNLConfermato
        '
        Me.PNLConfermato.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PNLConfermato.Location = New System.Drawing.Point(255, 30)
        Me.PNLConfermato.Name = "PNLConfermato"
        Me.PNLConfermato.Size = New System.Drawing.Size(49, 33)
        Me.PNLConfermato.TabIndex = 16
        '
        'PNLsalvataggio
        '
        Me.PNLsalvataggio.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.PNLsalvataggio.Location = New System.Drawing.Point(255, 92)
        Me.PNLsalvataggio.Name = "PNLsalvataggio"
        Me.PNLsalvataggio.Size = New System.Drawing.Size(49, 33)
        Me.PNLsalvataggio.TabIndex = 17
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.CountItem = Nothing
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2, Me.tx_testoricerca, Me.ToolStripLabel1, Me.cmbMese, Me.ToolStripSeparator1, Me.ToolStripLabel3, Me.cmbAnno})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 554)
        Me.BindingNavigator1.MoveFirstItem = Nothing
        Me.BindingNavigator1.MoveLastItem = Nothing
        Me.BindingNavigator1.MoveNextItem = Nothing
        Me.BindingNavigator1.MovePreviousItem = Nothing
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Nothing
        Me.BindingNavigator1.Size = New System.Drawing.Size(631, 25)
        Me.BindingNavigator1.TabIndex = 22
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'cmbMese
        '
        Me.cmbMese.Name = "cmbMese"
        Me.cmbMese.Size = New System.Drawing.Size(121, 25)
        '
        'cmbAnno
        '
        Me.cmbAnno.Name = "cmbAnno"
        Me.cmbAnno.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripLabel1.Text = "Mese Competenza"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(45, 22)
        Me.ToolStripLabel2.Text = "Ricerca"
        '
        'tx_testoricerca
        '
        Me.tx_testoricerca.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.tx_testoricerca.Name = "tx_testoricerca"
        Me.tx_testoricerca.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripLabel3
        '
        Me.ToolStripLabel3.Name = "ToolStripLabel3"
        Me.ToolStripLabel3.Size = New System.Drawing.Size(106, 22)
        Me.ToolStripLabel3.Text = "Anno Competenza"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "cf"
        Me.DataGridViewTextBoxColumn1.FillWeight = 70.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Codice Fiscale"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 10
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 589
        '
        'DGWCanagrafica
        '
        Me.DGWCanagrafica.DataPropertyName = "anagrafica"
        Me.DGWCanagrafica.HeaderText = "Anagrafica"
        Me.DGWCanagrafica.Name = "DGWCanagrafica"
        Me.DGWCanagrafica.ReadOnly = True
        '
        'ColCF
        '
        Me.ColCF.DataPropertyName = "cf"
        Me.ColCF.FillWeight = 70.0!
        Me.ColCF.HeaderText = "Codice Fiscale"
        Me.ColCF.MinimumWidth = 10
        Me.ColCF.Name = "ColCF"
        Me.ColCF.ReadOnly = True
        '
        'FRM_separatorePDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(631, 629)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.PNLsalvataggio)
        Me.Controls.Add(Me.PNLConfermato)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LB_info)
        Me.Controls.Add(Me.BT_termina)
        Me.Controls.Add(Me.BT_cercadocumento)
        Me.Controls.Add(Me.PB_avanzamento)
        Me.Controls.Add(Me.BT_cercaCartella)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TX_analizzato)
        Me.Controls.Add(Me.LB_deposito)
        Me.Controls.Add(Me.TX_deposito)
        Me.Controls.Add(Me.BT_ricerca)
        Me.Controls.Add(Me.DG_utenti)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRM_separatorePDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Analizzatore Documenti PDF"
        CType(Me.DG_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BS_utenti As BindingSource
    Friend WithEvents DG_utenti As DataGridView
    Friend WithEvents ApreDocumento As OpenFileDialog
    Friend WithEvents BT_ricerca As Button
    Friend WithEvents TX_deposito As TextBox
    Friend WithEvents LB_deposito As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TX_analizzato As TextBox
    Friend WithEvents BT_cercaCartella As Button
    Friend WithEvents CercaCartella As FolderBrowserDialog
    Friend WithEvents PB_avanzamento As ProgressBar
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents BT_cercadocumento As Button
    Friend WithEvents BT_termina As Button
    Friend WithEvents immagini As ImageList
    Friend WithEvents LB_info As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PNLConfermato As Panel
    Friend WithEvents PNLsalvataggio As Panel
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents tx_testoricerca As ToolStripTextBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cmbMese As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripLabel3 As ToolStripLabel
    Friend WithEvents cmbAnno As ToolStripComboBox
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DGWCanagrafica As DataGridViewTextBoxColumn
    Friend WithEvents ColCF As DataGridViewTextBoxColumn
End Class
