<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlloPosizioneGPS
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlloPosizioneGPS))
        Me.txtLatitudine = New System.Windows.Forms.TextBox()
        Me.txtLongitudine = New System.Windows.Forms.TextBox()
        Me.dgwDettaglioCliente = New System.Windows.Forms.DataGridView()
        Me.dgwcIDdettaglio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcLocazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcSddress = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcCitta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsElencoDettagli = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_clienti = New PoP2.Comuni.DS_clienti()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.dgwDipendenti = New System.Windows.Forms.DataGridView()
        Me.dgwcIDDipendente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CognomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IndirizzoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CittaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsUtenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.TA_locazione_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_locazione_new()
        Me.TableAdapterManager = New PoP2.Comuni.DS_clientiTableAdapters.TableAdapterManager()
        Me.pbRegistrazione = New System.Windows.Forms.ProgressBar()
        Me.txLonDipendente = New System.Windows.Forms.TextBox()
        Me.txLatDipendente = New System.Windows.Forms.TextBox()
        Me.btAggiornaDipendenti = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwDistanzePercorse = New System.Windows.Forms.DataGridView()
        Me.btnCalcolaDistanzenelMese = New System.Windows.Forms.Button()
        Me.ckDettaglio = New System.Windows.Forms.CheckBox()
        Me.txCostoCarburante = New System.Windows.Forms.TextBox()
        Me.lbCostoCarburante = New System.Windows.Forms.Label()
        Me.TA_utenti = New PoP2.Comuni.DS_utentiTableAdapters.TA_utenti()
        Me.lbFiltroDettaglioCantiere = New System.Windows.Forms.Label()
        Me.tbFiltrodettagliocantiere = New System.Windows.Forms.TextBox()
        Me.lbResalitriaChilometro = New System.Windows.Forms.Label()
        Me.txResaLitriaChilometro = New System.Windows.Forms.TextBox()
        CType(Me.dgwDettaglioCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsElencoDettagli, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwDipendenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsUtenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgwDistanzePercorse, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtLatitudine
        '
        Me.txtLatitudine.Location = New System.Drawing.Point(14, 271)
        Me.txtLatitudine.Name = "txtLatitudine"
        Me.txtLatitudine.Size = New System.Drawing.Size(100, 20)
        Me.txtLatitudine.TabIndex = 0
        '
        'txtLongitudine
        '
        Me.txtLongitudine.Location = New System.Drawing.Point(14, 297)
        Me.txtLongitudine.Name = "txtLongitudine"
        Me.txtLongitudine.Size = New System.Drawing.Size(102, 20)
        Me.txtLongitudine.TabIndex = 1
        '
        'dgwDettaglioCliente
        '
        Me.dgwDettaglioCliente.AllowUserToAddRows = False
        Me.dgwDettaglioCliente.AllowUserToDeleteRows = False
        Me.dgwDettaglioCliente.AutoGenerateColumns = False
        Me.dgwDettaglioCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwDettaglioCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDettaglioCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcIDdettaglio, Me.dgwcLocazione, Me.dgwcSddress, Me.dgwcCitta})
        Me.dgwDettaglioCliente.DataSource = Me.bsElencoDettagli
        Me.dgwDettaglioCliente.Location = New System.Drawing.Point(12, 12)
        Me.dgwDettaglioCliente.Name = "dgwDettaglioCliente"
        Me.dgwDettaglioCliente.ReadOnly = True
        Me.dgwDettaglioCliente.RowHeadersVisible = False
        Me.dgwDettaglioCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDettaglioCliente.Size = New System.Drawing.Size(290, 252)
        Me.dgwDettaglioCliente.TabIndex = 4
        '
        'dgwcIDdettaglio
        '
        Me.dgwcIDdettaglio.DataPropertyName = "id"
        Me.dgwcIDdettaglio.HeaderText = "id"
        Me.dgwcIDdettaglio.Name = "dgwcIDdettaglio"
        Me.dgwcIDdettaglio.ReadOnly = True
        Me.dgwcIDdettaglio.Visible = False
        '
        'dgwcLocazione
        '
        Me.dgwcLocazione.DataPropertyName = "locazione"
        Me.dgwcLocazione.HeaderText = "Cliente"
        Me.dgwcLocazione.Name = "dgwcLocazione"
        Me.dgwcLocazione.ReadOnly = True
        '
        'dgwcSddress
        '
        Me.dgwcSddress.DataPropertyName = "address"
        Me.dgwcSddress.HeaderText = "Indirizzo"
        Me.dgwcSddress.Name = "dgwcSddress"
        Me.dgwcSddress.ReadOnly = True
        '
        'dgwcCitta
        '
        Me.dgwcCitta.DataPropertyName = "citta"
        Me.dgwcCitta.HeaderText = "citta"
        Me.dgwcCitta.Name = "dgwcCitta"
        Me.dgwcCitta.ReadOnly = True
        '
        'bsElencoDettagli
        '
        Me.bsElencoDettagli.DataMember = "DT_locazione_new"
        Me.bsElencoDettagli.DataSource = Me.DS_clienti
        '
        'DS_clienti
        '
        Me.DS_clienti.DataSetName = "DS_clienti"
        Me.DS_clienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(136, 270)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(123, 47)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Aggiorna Cantieri"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(308, 12)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(325, 252)
        Me.WebBrowser1.TabIndex = 6
        '
        'dgwDipendenti
        '
        Me.dgwDipendenti.AllowUserToAddRows = False
        Me.dgwDipendenti.AllowUserToDeleteRows = False
        Me.dgwDipendenti.AutoGenerateColumns = False
        Me.dgwDipendenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwDipendenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDipendenti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcIDDipendente, Me.NomeDataGridViewTextBoxColumn, Me.CognomeDataGridViewTextBoxColumn, Me.IndirizzoDataGridViewTextBoxColumn, Me.CittaDataGridViewTextBoxColumn})
        Me.dgwDipendenti.DataSource = Me.bsUtenti
        Me.dgwDipendenti.Location = New System.Drawing.Point(648, 18)
        Me.dgwDipendenti.Name = "dgwDipendenti"
        Me.dgwDipendenti.ReadOnly = True
        Me.dgwDipendenti.RowHeadersVisible = False
        Me.dgwDipendenti.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgwDipendenti.Size = New System.Drawing.Size(356, 246)
        Me.dgwDipendenti.TabIndex = 7
        '
        'dgwcIDDipendente
        '
        Me.dgwcIDDipendente.DataPropertyName = "id"
        Me.dgwcIDDipendente.FillWeight = 10.0!
        Me.dgwcIDDipendente.HeaderText = "id"
        Me.dgwcIDDipendente.Name = "dgwcIDDipendente"
        Me.dgwcIDDipendente.ReadOnly = True
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        Me.NomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CognomeDataGridViewTextBoxColumn
        '
        Me.CognomeDataGridViewTextBoxColumn.DataPropertyName = "cognome"
        Me.CognomeDataGridViewTextBoxColumn.HeaderText = "cognome"
        Me.CognomeDataGridViewTextBoxColumn.Name = "CognomeDataGridViewTextBoxColumn"
        Me.CognomeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IndirizzoDataGridViewTextBoxColumn
        '
        Me.IndirizzoDataGridViewTextBoxColumn.DataPropertyName = "indirizzo"
        Me.IndirizzoDataGridViewTextBoxColumn.HeaderText = "indirizzo"
        Me.IndirizzoDataGridViewTextBoxColumn.Name = "IndirizzoDataGridViewTextBoxColumn"
        Me.IndirizzoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CittaDataGridViewTextBoxColumn
        '
        Me.CittaDataGridViewTextBoxColumn.DataPropertyName = "citta"
        Me.CittaDataGridViewTextBoxColumn.HeaderText = "citta"
        Me.CittaDataGridViewTextBoxColumn.Name = "CittaDataGridViewTextBoxColumn"
        Me.CittaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'bsUtenti
        '
        Me.bsUtenti.DataMember = "DT_utenti"
        Me.bsUtenti.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_locazione_new
        '
        Me.TA_locazione_new.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_clientiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'pbRegistrazione
        '
        Me.pbRegistrazione.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pbRegistrazione.Location = New System.Drawing.Point(0, 682)
        Me.pbRegistrazione.Name = "pbRegistrazione"
        Me.pbRegistrazione.Size = New System.Drawing.Size(1016, 23)
        Me.pbRegistrazione.TabIndex = 8
        '
        'txLonDipendente
        '
        Me.txLonDipendente.Location = New System.Drawing.Point(648, 297)
        Me.txLonDipendente.Name = "txLonDipendente"
        Me.txLonDipendente.Size = New System.Drawing.Size(102, 20)
        Me.txLonDipendente.TabIndex = 10
        '
        'txLatDipendente
        '
        Me.txLatDipendente.Location = New System.Drawing.Point(650, 271)
        Me.txLatDipendente.Name = "txLatDipendente"
        Me.txLatDipendente.Size = New System.Drawing.Size(100, 20)
        Me.txLatDipendente.TabIndex = 9
        '
        'btAggiornaDipendenti
        '
        Me.btAggiornaDipendenti.Enabled = False
        Me.btAggiornaDipendenti.Location = New System.Drawing.Point(769, 270)
        Me.btAggiornaDipendenti.Name = "btAggiornaDipendenti"
        Me.btAggiornaDipendenti.Size = New System.Drawing.Size(123, 47)
        Me.btAggiornaDipendenti.TabIndex = 1
        Me.btAggiornaDipendenti.Text = "Aggiorna Dipendenti"
        Me.btAggiornaDipendenti.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "locazione"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 190
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "address"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Indirizzo"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 95
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "citta"
        Me.DataGridViewTextBoxColumn4.HeaderText = "citta"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 96
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn5.FillWeight = 10.0!
        Me.DataGridViewTextBoxColumn5.HeaderText = "id"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 9
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn6.HeaderText = "nome"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 86
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "cognome"
        Me.DataGridViewTextBoxColumn7.HeaderText = "cognome"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 86
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "indirizzo"
        Me.DataGridViewTextBoxColumn8.HeaderText = "indirizzo"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 86
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "citta"
        Me.DataGridViewTextBoxColumn9.HeaderText = "citta"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 86
        '
        'dgwDistanzePercorse
        '
        Me.dgwDistanzePercorse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwDistanzePercorse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwDistanzePercorse.Location = New System.Drawing.Point(14, 342)
        Me.dgwDistanzePercorse.Name = "dgwDistanzePercorse"
        Me.dgwDistanzePercorse.RowHeadersVisible = False
        Me.dgwDistanzePercorse.Size = New System.Drawing.Size(807, 315)
        Me.dgwDistanzePercorse.TabIndex = 12
        '
        'btnCalcolaDistanzenelMese
        '
        Me.btnCalcolaDistanzenelMese.Location = New System.Drawing.Point(847, 489)
        Me.btnCalcolaDistanzenelMese.Name = "btnCalcolaDistanzenelMese"
        Me.btnCalcolaDistanzenelMese.Size = New System.Drawing.Size(88, 157)
        Me.btnCalcolaDistanzenelMese.TabIndex = 6
        Me.btnCalcolaDistanzenelMese.Text = "Esegui il Calcolo"
        Me.btnCalcolaDistanzenelMese.UseVisualStyleBackColor = True
        '
        'ckDettaglio
        '
        Me.ckDettaglio.AutoSize = True
        Me.ckDettaglio.Location = New System.Drawing.Point(847, 466)
        Me.ckDettaglio.Name = "ckDettaglio"
        Me.ckDettaglio.Size = New System.Drawing.Size(88, 17)
        Me.ckDettaglio.TabIndex = 14
        Me.ckDettaglio.Text = "Con dettaglio"
        Me.ckDettaglio.UseVisualStyleBackColor = True
        '
        'txCostoCarburante
        '
        Me.txCostoCarburante.Location = New System.Drawing.Point(847, 342)
        Me.txCostoCarburante.Name = "txCostoCarburante"
        Me.txCostoCarburante.Size = New System.Drawing.Size(88, 20)
        Me.txCostoCarburante.TabIndex = 2
        '
        'lbCostoCarburante
        '
        Me.lbCostoCarburante.AutoSize = True
        Me.lbCostoCarburante.Location = New System.Drawing.Point(846, 326)
        Me.lbCostoCarburante.Name = "lbCostoCarburante"
        Me.lbCostoCarburante.Size = New System.Drawing.Size(89, 13)
        Me.lbCostoCarburante.TabIndex = 16
        Me.lbCostoCarburante.Text = "Costo Carburante"
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'lbFiltroDettaglioCantiere
        '
        Me.lbFiltroDettaglioCantiere.AutoSize = True
        Me.lbFiltroDettaglioCantiere.Location = New System.Drawing.Point(846, 414)
        Me.lbFiltroDettaglioCantiere.Name = "lbFiltroDettaglioCantiere"
        Me.lbFiltroDettaglioCantiere.Size = New System.Drawing.Size(67, 13)
        Me.lbFiltroDettaglioCantiere.TabIndex = 18
        Me.lbFiltroDettaglioCantiere.Text = "Filtra Cantieri"
        '
        'tbFiltrodettagliocantiere
        '
        Me.tbFiltrodettagliocantiere.Location = New System.Drawing.Point(847, 430)
        Me.tbFiltrodettagliocantiere.Name = "tbFiltrodettagliocantiere"
        Me.tbFiltrodettagliocantiere.Size = New System.Drawing.Size(88, 20)
        Me.tbFiltrodettagliocantiere.TabIndex = 4
        '
        'lbResalitriaChilometro
        '
        Me.lbResalitriaChilometro.AutoSize = True
        Me.lbResalitriaChilometro.Location = New System.Drawing.Point(846, 371)
        Me.lbResalitriaChilometro.Name = "lbResalitriaChilometro"
        Me.lbResalitriaChilometro.Size = New System.Drawing.Size(80, 13)
        Me.lbResalitriaChilometro.TabIndex = 20
        Me.lbResalitriaChilometro.Text = "Resa Litri al Km"
        '
        'txResaLitriaChilometro
        '
        Me.txResaLitriaChilometro.Location = New System.Drawing.Point(847, 387)
        Me.txResaLitriaChilometro.Name = "txResaLitriaChilometro"
        Me.txResaLitriaChilometro.Size = New System.Drawing.Size(88, 20)
        Me.txResaLitriaChilometro.TabIndex = 3
        Me.txResaLitriaChilometro.Text = "0,066"
        '
        'frmControlloPosizioneGPS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 705)
        Me.Controls.Add(Me.lbResalitriaChilometro)
        Me.Controls.Add(Me.txResaLitriaChilometro)
        Me.Controls.Add(Me.lbFiltroDettaglioCantiere)
        Me.Controls.Add(Me.tbFiltrodettagliocantiere)
        Me.Controls.Add(Me.lbCostoCarburante)
        Me.Controls.Add(Me.txCostoCarburante)
        Me.Controls.Add(Me.ckDettaglio)
        Me.Controls.Add(Me.btnCalcolaDistanzenelMese)
        Me.Controls.Add(Me.dgwDistanzePercorse)
        Me.Controls.Add(Me.btAggiornaDipendenti)
        Me.Controls.Add(Me.txLonDipendente)
        Me.Controls.Add(Me.txLatDipendente)
        Me.Controls.Add(Me.pbRegistrazione)
        Me.Controls.Add(Me.dgwDipendenti)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgwDettaglioCliente)
        Me.Controls.Add(Me.txtLongitudine)
        Me.Controls.Add(Me.txtLatitudine)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmControlloPosizioneGPS"
        Me.Text = "Gestione Posizione Dipendenti"
        CType(Me.dgwDettaglioCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsElencoDettagli, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwDipendenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsUtenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgwDistanzePercorse, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLatitudine As TextBox
    Friend WithEvents txtLongitudine As TextBox
    Friend WithEvents DS_clienti As DS_clienti
    Friend WithEvents bsElencoDettagli As BindingSource
    Friend WithEvents TA_locazione_new As DS_clientiTableAdapters.TA_locazione_new
    Friend WithEvents TableAdapterManager As DS_clientiTableAdapters.TableAdapterManager
    Friend WithEvents dgwDettaglioCliente As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents dgwDipendenti As DataGridView
    Friend WithEvents dgwcIDdettaglio As DataGridViewTextBoxColumn
    Friend WithEvents dgwcLocazione As DataGridViewTextBoxColumn
    Friend WithEvents pbRegistrazione As ProgressBar
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents bsUtenti As BindingSource
    Friend WithEvents TA_utenti As DS_utentiTableAdapters.TA_utenti
    Friend WithEvents txLonDipendente As TextBox
    Friend WithEvents txLatDipendente As TextBox
    Friend WithEvents btAggiornaDipendenti As Button
    Friend WithEvents dgwcSddress As DataGridViewTextBoxColumn
    Friend WithEvents dgwcCitta As DataGridViewTextBoxColumn
    Friend WithEvents dgwcIDDipendente As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CognomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IndirizzoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CittaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents dgwDistanzePercorse As DataGridView
    Friend WithEvents btnCalcolaDistanzenelMese As Button
    Friend WithEvents ckDettaglio As CheckBox
    Friend WithEvents txCostoCarburante As TextBox
    Friend WithEvents lbCostoCarburante As Label
    Friend WithEvents lbFiltroDettaglioCantiere As Label
    Friend WithEvents tbFiltrodettagliocantiere As TextBox
    Friend WithEvents lbResalitriaChilometro As Label
    Friend WithEvents txResaLitriaChilometro As TextBox
End Class
