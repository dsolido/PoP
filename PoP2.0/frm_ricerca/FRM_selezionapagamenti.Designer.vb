<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_selezionapagamenti
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
        Me.DT_pagamenti_newDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BS_pagamenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_clienti = New PoP2.Comuni.DS_clienti()
        Me.BT_termina = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_ricerca = New System.Windows.Forms.TextBox()
        Me.TA_pagamenti_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_pagamenti_new()
        Me.TableAdapterManager = New PoP2.Comuni.DS_clientiTableAdapters.TableAdapterManager()
        CType(Me.DT_pagamenti_newDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_pagamenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DT_pagamenti_newDataGridView
        '
        Me.DT_pagamenti_newDataGridView.AllowUserToAddRows = False
        Me.DT_pagamenti_newDataGridView.AllowUserToDeleteRows = False
        Me.DT_pagamenti_newDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DT_pagamenti_newDataGridView.AutoGenerateColumns = False
        Me.DT_pagamenti_newDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DT_pagamenti_newDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DT_pagamenti_newDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.DT_pagamenti_newDataGridView.DataSource = Me.BS_pagamenti
        Me.DT_pagamenti_newDataGridView.Location = New System.Drawing.Point(1, 1)
        Me.DT_pagamenti_newDataGridView.Margin = New System.Windows.Forms.Padding(1)
        Me.DT_pagamenti_newDataGridView.Name = "DT_pagamenti_newDataGridView"
        Me.DT_pagamenti_newDataGridView.ReadOnly = True
        Me.DT_pagamenti_newDataGridView.RowHeadersWidth = 4
        Me.DT_pagamenti_newDataGridView.Size = New System.Drawing.Size(430, 280)
        Me.DT_pagamenti_newDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "des"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Descrizione Pagamento"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'BS_pagamenti
        '
        Me.BS_pagamenti.DataMember = "DT_pagamenti_new"
        Me.BS_pagamenti.DataSource = Me.DS_clienti
        '
        'DS_clienti
        '
        Me.DS_clienti.DataSetName = "DS_clienti"
        Me.DS_clienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BT_termina
        '
        Me.BT_termina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_termina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.BT_termina.Location = New System.Drawing.Point(361, 363)
        Me.BT_termina.Name = "BT_termina"
        Me.BT_termina.Size = New System.Drawing.Size(61, 68)
        Me.BT_termina.TabIndex = 7
        Me.BT_termina.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(158, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Ricerca il cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TX_ricerca
        '
        Me.TX_ricerca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TX_ricerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TX_ricerca.Location = New System.Drawing.Point(58, 311)
        Me.TX_ricerca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TX_ricerca.Name = "TX_ricerca"
        Me.TX_ricerca.Size = New System.Drawing.Size(326, 32)
        Me.TX_ricerca.TabIndex = 5
        '
        'TA_pagamenti_new
        '
        Me.TA_pagamenti_new.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_clientiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FRM_selezionapagamenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 441)
        Me.ControlBox = False
        Me.Controls.Add(Me.BT_termina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TX_ricerca)
        Me.Controls.Add(Me.DT_pagamenti_newDataGridView)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_selezionapagamenti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleziona Pagamenti"
        CType(Me.DT_pagamenti_newDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_pagamenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_clienti As DS_clienti
    Friend WithEvents BS_pagamenti As BindingSource
    Friend WithEvents TA_pagamenti_new As DS_clientiTableAdapters.TA_pagamenti_new
    Friend WithEvents TableAdapterManager As DS_clientiTableAdapters.TableAdapterManager
    Friend WithEvents DT_pagamenti_newDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents BT_termina As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TX_ricerca As TextBox
End Class
