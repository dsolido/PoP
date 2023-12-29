<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_findClienti
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
        Dim LB_ricercadipendente As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim SocietaLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TX_ricercadipendente = New System.Windows.Forms.TextBox()
        Me.DG_utenti = New System.Windows.Forms.DataGridView()
        Me.C_ana = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_IDDip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_utenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_orari = New PoP2.Comuni.DS_orari()
        Me.DG_Locazione = New System.Windows.Forms.DataGridView()
        Me.LocazioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_DIDCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_IDDes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_locazioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.TX_RIC_locazione = New System.Windows.Forms.TextBox()
        Me.DG_clienti = New System.Windows.Forms.DataGridView()
        Me.C_societa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_IDcli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_clienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.TXT_ric_cliente = New System.Windows.Forms.TextBox()
        Me.TA_utenti = New PoP2.Comuni.DS_orariTableAdapters.TA_utenti()
        Me.TA_clienti = New PoP2.Comuni.DS_orariTableAdapters.TA_clienti()
        Me.TA_locazioni = New PoP2.Comuni.DS_orariTableAdapters.TA_locazioni()
        Me.cmd_termina = New System.Windows.Forms.Button()
        LB_ricercadipendente = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        SocietaLabel = New System.Windows.Forms.Label()
        CType(Me.DG_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_orari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_Locazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_locazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LB_ricercadipendente
        '
        LB_ricercadipendente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        LB_ricercadipendente.AutoSize = True
        LB_ricercadipendente.Location = New System.Drawing.Point(12, 170)
        LB_ricercadipendente.Name = "LB_ricercadipendente"
        LB_ricercadipendente.Size = New System.Drawing.Size(44, 13)
        LB_ricercadipendente.TabIndex = 75
        LB_ricercadipendente.Text = "Ricerca"
        '
        'Label3
        '
        Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(417, 170)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(44, 13)
        Label3.TabIndex = 71
        Label3.Text = "Ricerca"
        '
        'SocietaLabel
        '
        SocietaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        SocietaLabel.AutoSize = True
        SocietaLabel.Location = New System.Drawing.Point(216, 170)
        SocietaLabel.Name = "SocietaLabel"
        SocietaLabel.Size = New System.Drawing.Size(44, 13)
        SocietaLabel.TabIndex = 68
        SocietaLabel.Text = "Ricerca"
        '
        'TX_ricercadipendente
        '
        Me.TX_ricercadipendente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TX_ricercadipendente.Location = New System.Drawing.Point(63, 166)
        Me.TX_ricercadipendente.Name = "TX_ricercadipendente"
        Me.TX_ricercadipendente.Size = New System.Drawing.Size(147, 20)
        Me.TX_ricercadipendente.TabIndex = 74
        '
        'DG_utenti
        '
        Me.DG_utenti.AllowUserToAddRows = False
        Me.DG_utenti.AllowUserToDeleteRows = False
        Me.DG_utenti.AllowUserToOrderColumns = True
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DG_utenti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_utenti.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DG_utenti.AutoGenerateColumns = False
        Me.DG_utenti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_utenti.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DG_utenti.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_utenti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DG_utenti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_utenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_utenti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_ana, Me.C_IDDip})
        Me.DG_utenti.DataSource = Me.BS_utenti
        Me.DG_utenti.Location = New System.Drawing.Point(12, 14)
        Me.DG_utenti.Name = "DG_utenti"
        Me.DG_utenti.ReadOnly = True
        Me.DG_utenti.RowHeadersWidth = 5
        Me.DG_utenti.Size = New System.Drawing.Size(195, 143)
        Me.DG_utenti.TabIndex = 73
        '
        'C_ana
        '
        Me.C_ana.DataPropertyName = "anagrafica"
        Me.C_ana.HeaderText = "anagrafica"
        Me.C_ana.Name = "C_ana"
        Me.C_ana.ReadOnly = True
        '
        'C_IDDip
        '
        Me.C_IDDip.DataPropertyName = "id"
        Me.C_IDDip.HeaderText = "id"
        Me.C_IDDip.Name = "C_IDDip"
        Me.C_IDDip.ReadOnly = True
        Me.C_IDDip.Visible = False
        '
        'BS_utenti
        '
        Me.BS_utenti.DataMember = "DT_utenti"
        Me.BS_utenti.DataSource = Me.DS_orari
        '
        'DS_orari
        '
        Me.DS_orari.DataSetName = "DS_orari"
        Me.DS_orari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DG_Locazione
        '
        Me.DG_Locazione.AllowUserToAddRows = False
        Me.DG_Locazione.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DG_Locazione.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Locazione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DG_Locazione.AutoGenerateColumns = False
        Me.DG_Locazione.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Locazione.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DG_Locazione.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_Locazione.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DG_Locazione.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_Locazione.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Locazione.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LocazioneDataGridViewTextBoxColumn, Me.C_DIDCli, Me.C_IDDes})
        Me.DG_Locazione.DataSource = Me.BS_locazioni
        Me.DG_Locazione.Location = New System.Drawing.Point(417, 15)
        Me.DG_Locazione.Name = "DG_Locazione"
        Me.DG_Locazione.ReadOnly = True
        Me.DG_Locazione.RowHeadersWidth = 5
        Me.DG_Locazione.Size = New System.Drawing.Size(195, 143)
        Me.DG_Locazione.TabIndex = 72
        '
        'LocazioneDataGridViewTextBoxColumn
        '
        Me.LocazioneDataGridViewTextBoxColumn.DataPropertyName = "locazione"
        Me.LocazioneDataGridViewTextBoxColumn.HeaderText = "locazione"
        Me.LocazioneDataGridViewTextBoxColumn.Name = "LocazioneDataGridViewTextBoxColumn"
        Me.LocazioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'C_DIDCli
        '
        Me.C_DIDCli.DataPropertyName = "id_terminale"
        Me.C_DIDCli.HeaderText = "id_terminale"
        Me.C_DIDCli.Name = "C_DIDCli"
        Me.C_DIDCli.ReadOnly = True
        Me.C_DIDCli.Visible = False
        '
        'C_IDDes
        '
        Me.C_IDDes.DataPropertyName = "id"
        Me.C_IDDes.HeaderText = "ID_Destinatario"
        Me.C_IDDes.Name = "C_IDDes"
        Me.C_IDDes.ReadOnly = True
        Me.C_IDDes.Visible = False
        '
        'BS_locazioni
        '
        Me.BS_locazioni.DataMember = "DT_locazioni"
        Me.BS_locazioni.DataSource = Me.DS_orari
        '
        'TX_RIC_locazione
        '
        Me.TX_RIC_locazione.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TX_RIC_locazione.Location = New System.Drawing.Point(465, 166)
        Me.TX_RIC_locazione.Name = "TX_RIC_locazione"
        Me.TX_RIC_locazione.Size = New System.Drawing.Size(147, 20)
        Me.TX_RIC_locazione.TabIndex = 70
        '
        'DG_clienti
        '
        Me.DG_clienti.AllowUserToAddRows = False
        Me.DG_clienti.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DG_clienti.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_clienti.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.DG_clienti.AutoGenerateColumns = False
        Me.DG_clienti.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clienti.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.DG_clienti.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DG_clienti.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DG_clienti.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clienti.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_societa, Me.C_IDcli})
        Me.DG_clienti.DataSource = Me.BS_clienti
        Me.DG_clienti.Location = New System.Drawing.Point(216, 14)
        Me.DG_clienti.Name = "DG_clienti"
        Me.DG_clienti.ReadOnly = True
        Me.DG_clienti.RowHeadersWidth = 5
        Me.DG_clienti.Size = New System.Drawing.Size(195, 143)
        Me.DG_clienti.TabIndex = 69
        '
        'C_societa
        '
        Me.C_societa.DataPropertyName = "societa"
        Me.C_societa.HeaderText = "societa"
        Me.C_societa.Name = "C_societa"
        Me.C_societa.ReadOnly = True
        '
        'C_IDcli
        '
        Me.C_IDcli.DataPropertyName = "id"
        Me.C_IDcli.HeaderText = "id"
        Me.C_IDcli.Name = "C_IDcli"
        Me.C_IDcli.ReadOnly = True
        Me.C_IDcli.Visible = False
        '
        'BS_clienti
        '
        Me.BS_clienti.DataMember = "DT_clienti"
        Me.BS_clienti.DataSource = Me.DS_orari
        '
        'TXT_ric_cliente
        '
        Me.TXT_ric_cliente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXT_ric_cliente.Location = New System.Drawing.Point(264, 166)
        Me.TXT_ric_cliente.Name = "TXT_ric_cliente"
        Me.TXT_ric_cliente.Size = New System.Drawing.Size(147, 20)
        Me.TXT_ric_cliente.TabIndex = 67
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
        'cmd_termina
        '
        Me.cmd_termina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_termina.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.cmd_termina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_termina.FlatAppearance.BorderSize = 0
        Me.cmd_termina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_termina.Location = New System.Drawing.Point(570, 201)
        Me.cmd_termina.Name = "cmd_termina"
        Me.cmd_termina.Size = New System.Drawing.Size(40, 40)
        Me.cmd_termina.TabIndex = 76
        Me.cmd_termina.UseVisualStyleBackColor = True
        '
        'FRM_findClienti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(622, 253)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmd_termina)
        Me.Controls.Add(Me.TX_ricercadipendente)
        Me.Controls.Add(LB_ricercadipendente)
        Me.Controls.Add(Me.DG_utenti)
        Me.Controls.Add(Me.DG_Locazione)
        Me.Controls.Add(Me.TX_RIC_locazione)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.DG_clienti)
        Me.Controls.Add(Me.TXT_ric_cliente)
        Me.Controls.Add(SocietaLabel)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_findClienti"
        Me.ShowIcon = False
        Me.Text = "FRM_findClienti"
        CType(Me.DG_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_orari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_Locazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_locazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TX_ricercadipendente As TextBox
    Friend WithEvents DG_utenti As DataGridView
    Friend WithEvents DG_Locazione As DataGridView
    Friend WithEvents TX_RIC_locazione As TextBox
    Friend WithEvents DG_clienti As DataGridView
    Friend WithEvents TXT_ric_cliente As TextBox
    Friend WithEvents DS_orari As DS_orari
    Friend WithEvents BS_utenti As BindingSource
    Friend WithEvents TA_utenti As DS_orariTableAdapters.TA_utenti
    Friend WithEvents C_ana As DataGridViewTextBoxColumn
    Friend WithEvents C_IDDip As DataGridViewTextBoxColumn
    Friend WithEvents BS_clienti As BindingSource
    Friend WithEvents TA_clienti As DS_orariTableAdapters.TA_clienti
    Friend WithEvents C_societa As DataGridViewTextBoxColumn
    Friend WithEvents C_IDcli As DataGridViewTextBoxColumn
    Friend WithEvents BS_locazioni As BindingSource
    Friend WithEvents TA_locazioni As DS_orariTableAdapters.TA_locazioni
    Friend WithEvents LocazioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents C_DIDCli As DataGridViewTextBoxColumn
    Friend WithEvents C_IDDes As DataGridViewTextBoxColumn
    Friend WithEvents cmd_termina As Button
End Class
