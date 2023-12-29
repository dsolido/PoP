<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_giorno
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
        Me.DG_giorno = New System.Windows.Forms.DataGridView()
        Me.C_Ora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_Assente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_sostituto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_cliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_locazione = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_note = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DG_giorno, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_giorno
        '
        Me.DG_giorno.AllowUserToAddRows = False
        Me.DG_giorno.AllowUserToDeleteRows = False
        Me.DG_giorno.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_giorno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_giorno.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_Ora, Me.C_Assente, Me.C_sostituto, Me.C_cliente, Me.C_locazione, Me.C_tipo, Me.C_note, Me.C_ID})
        Me.DG_giorno.Location = New System.Drawing.Point(4, 4)
        Me.DG_giorno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DG_giorno.Name = "DG_giorno"
        Me.DG_giorno.ReadOnly = True
        Me.DG_giorno.RowHeadersWidth = 4
        Me.DG_giorno.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_giorno.Size = New System.Drawing.Size(1061, 514)
        Me.DG_giorno.TabIndex = 195
        '
        'C_Ora
        '
        Me.C_Ora.FillWeight = 20.0!
        Me.C_Ora.HeaderText = "Ora"
        Me.C_Ora.Name = "C_Ora"
        Me.C_Ora.ReadOnly = True
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
        'FRM_giorno
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 554)
        Me.Controls.Add(Me.DG_giorno)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FRM_giorno"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agenda Giornaliera"
        CType(Me.DG_giorno, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DG_giorno As DataGridView
    Friend WithEvents C_Ora As DataGridViewTextBoxColumn
    Friend WithEvents C_Assente As DataGridViewTextBoxColumn
    Friend WithEvents C_sostituto As DataGridViewTextBoxColumn
    Friend WithEvents C_cliente As DataGridViewTextBoxColumn
    Friend WithEvents C_locazione As DataGridViewTextBoxColumn
    Friend WithEvents C_tipo As DataGridViewTextBoxColumn
    Friend WithEvents C_note As DataGridViewTextBoxColumn
    Friend WithEvents C_ID As DataGridViewTextBoxColumn
End Class
