<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_calendario
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
        Me.btn_genera = New System.Windows.Forms.Button()
        Me.dgCalendario = New System.Windows.Forms.DataGridView()
        Me.DGWCid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCgiorno = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCfesta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCfestivo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DGWCgm = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsCal = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.cmb_anno = New System.Windows.Forms.ComboBox()
        Me.TA_cal = New PoP2.Comuni.DS_utentiTableAdapters.TA_cal()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        CType(Me.dgCalendario, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsCal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_genera
        '
        Me.btn_genera.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_genera.Location = New System.Drawing.Point(12, 383)
        Me.btn_genera.Name = "btn_genera"
        Me.btn_genera.Size = New System.Drawing.Size(75, 23)
        Me.btn_genera.TabIndex = 0
        Me.btn_genera.Text = "Genera"
        Me.btn_genera.UseVisualStyleBackColor = True
        '
        'dgCalendario
        '
        Me.dgCalendario.AllowUserToAddRows = False
        Me.dgCalendario.AllowUserToDeleteRows = False
        Me.dgCalendario.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgCalendario.AutoGenerateColumns = False
        Me.dgCalendario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgCalendario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCalendario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DGWCid, Me.DGWCgiorno, Me.DGWCfesta, Me.DGWCfestivo, Me.DGWCgm})
        Me.dgCalendario.DataSource = Me.bsCal
        Me.dgCalendario.Location = New System.Drawing.Point(12, 46)
        Me.dgCalendario.Name = "dgCalendario"
        Me.dgCalendario.Size = New System.Drawing.Size(530, 307)
        Me.dgCalendario.TabIndex = 2
        '
        'DGWCid
        '
        Me.DGWCid.DataPropertyName = "id"
        Me.DGWCid.HeaderText = "id"
        Me.DGWCid.Name = "DGWCid"
        '
        'DGWCgiorno
        '
        Me.DGWCgiorno.DataPropertyName = "giorno"
        Me.DGWCgiorno.HeaderText = "giorno"
        Me.DGWCgiorno.Name = "DGWCgiorno"
        '
        'DGWCfesta
        '
        Me.DGWCfesta.DataPropertyName = "festa"
        Me.DGWCfesta.HeaderText = "festa"
        Me.DGWCfesta.Name = "DGWCfesta"
        '
        'DGWCfestivo
        '
        Me.DGWCfestivo.DataPropertyName = "festivo"
        Me.DGWCfestivo.HeaderText = "festivo"
        Me.DGWCfestivo.Name = "DGWCfestivo"
        '
        'DGWCgm
        '
        Me.DGWCgm.DataPropertyName = "gm"
        Me.DGWCgm.HeaderText = "gm"
        Me.DGWCgm.Name = "DGWCgm"
        Me.DGWCgm.ReadOnly = True
        '
        'bsCal
        '
        Me.bsCal.DataMember = "DT_cal"
        Me.bsCal.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmb_anno
        '
        Me.cmb_anno.FormattingEnabled = True
        Me.cmb_anno.Items.AddRange(New Object() {"2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmb_anno.Location = New System.Drawing.Point(12, 19)
        Me.cmb_anno.Name = "cmb_anno"
        Me.cmb_anno.Size = New System.Drawing.Size(101, 21)
        Me.cmb_anno.TabIndex = 3
        '
        'TA_cal
        '
        Me.TA_cal.ClearBeforeFill = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ProgressBar1.Location = New System.Drawing.Point(119, 374)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(422, 31)
        Me.ProgressBar1.TabIndex = 4
        '
        'frm_calendario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(554, 418)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.cmb_anno)
        Me.Controls.Add(Me.dgCalendario)
        Me.Controls.Add(Me.btn_genera)
        Me.Name = "frm_calendario"
        Me.Text = "calendario"
        CType(Me.dgCalendario, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsCal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_genera As Button
    Friend WithEvents dgCalendario As DataGridView
    Friend WithEvents cmb_anno As ComboBox
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents bsCal As BindingSource
    Friend WithEvents TA_cal As DS_utentiTableAdapters.TA_cal
    Friend WithEvents DGWCid As DataGridViewTextBoxColumn
    Friend WithEvents DGWCgiorno As DataGridViewTextBoxColumn
    Friend WithEvents DGWCfesta As DataGridViewTextBoxColumn
    Friend WithEvents DGWCfestivo As DataGridViewTextBoxColumn
    Friend WithEvents DGWCgm As DataGridViewTextBoxColumn
    Friend WithEvents ProgressBar1 As ProgressBar
End Class
