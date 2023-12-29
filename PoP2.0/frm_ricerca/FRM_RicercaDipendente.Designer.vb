<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_RicercaDipendente
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.TableAdapterManager = New PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager()
        Me.DG_ricerca = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_ricerca = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_utenti_ricerca = New PoP2.Comuni.DS_utentiTableAdapters.TA_utenti_ricerca()
        Me.BT_conferma = New System.Windows.Forms.Button()
        Me.BT_annulla = New System.Windows.Forms.Button()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_ricerca, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_ricerca, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(78, 250)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(175, 29)
        Me.TextBox1.TabIndex = 5
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DG_ricerca
        '
        Me.DG_ricerca.AllowUserToAddRows = False
        Me.DG_ricerca.AllowUserToDeleteRows = False
        Me.DG_ricerca.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_ricerca.AutoGenerateColumns = False
        Me.DG_ricerca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_ricerca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ricerca.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.DG_ricerca.DataSource = Me.BS_ricerca
        Me.DG_ricerca.Location = New System.Drawing.Point(0, 3)
        Me.DG_ricerca.Name = "DG_ricerca"
        Me.DG_ricerca.ReadOnly = True
        Me.DG_ricerca.RowHeadersWidth = 4
        Me.DG_ricerca.Size = New System.Drawing.Size(364, 241)
        Me.DG_ricerca.TabIndex = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "cognome"
        Me.DataGridViewTextBoxColumn3.HeaderText = "cognome"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'BS_ricerca
        '
        Me.BS_ricerca.DataMember = "DT_utenti_ricerca"
        Me.BS_ricerca.DataSource = Me.DS_utenti
        '
        'TA_utenti_ricerca
        '
        Me.TA_utenti_ricerca.ClearBeforeFill = True
        '
        'BT_conferma
        '
        Me.BT_conferma.Image = Global.PoP2.Comuni.My.Resources.Resources.ominoConferma48
        Me.BT_conferma.Location = New System.Drawing.Point(243, 326)
        Me.BT_conferma.Margin = New System.Windows.Forms.Padding(4)
        Me.BT_conferma.Name = "BT_conferma"
        Me.BT_conferma.Size = New System.Drawing.Size(100, 86)
        Me.BT_conferma.TabIndex = 3
        Me.BT_conferma.Text = "Conferma"
        Me.BT_conferma.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_conferma.UseVisualStyleBackColor = True
        '
        'BT_annulla
        '
        Me.BT_annulla.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BT_annulla.Image = Global.PoP2.Comuni.My.Resources.Resources.allerta48
        Me.BT_annulla.Location = New System.Drawing.Point(116, 326)
        Me.BT_annulla.Name = "BT_annulla"
        Me.BT_annulla.Size = New System.Drawing.Size(110, 86)
        Me.BT_annulla.TabIndex = 4
        Me.BT_annulla.Text = "Annulla"
        Me.BT_annulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BT_annulla.UseVisualStyleBackColor = True
        '
        'FRM_RicercaDipendente
        '
        Me.AcceptButton = Me.BT_conferma
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.BT_annulla
        Me.ClientSize = New System.Drawing.Size(365, 423)
        Me.ControlBox = False
        Me.Controls.Add(Me.DG_ricerca)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.BT_annulla)
        Me.Controls.Add(Me.BT_conferma)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_RicercaDipendente"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Ricerca"
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_ricerca, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_ricerca, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents TableAdapterManager As DS_utentiTableAdapters.TableAdapterManager
    Friend WithEvents BT_conferma As Button
    Friend WithEvents BT_annulla As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BS_ricerca As BindingSource
    Friend WithEvents TA_utenti_ricerca As DS_utentiTableAdapters.TA_utenti_ricerca
    Friend WithEvents DG_ricerca As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
