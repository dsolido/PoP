<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_selezionafornitore
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
        Me.BT_termina = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_ricerca = New System.Windows.Forms.TextBox()
        Me.DG_fornitore = New System.Windows.Forms.DataGridView()
        Me.DS_prodotti = New PoP2.Comuni.DS_prodotti()
        Me.BS_forni = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_forni = New PoP2.Comuni.DS_prodottiTableAdapters.TA_fornitori()
        Me.TableAdapterManager = New PoP2.Comuni.DS_prodottiTableAdapters.TableAdapterManager()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnagraficaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DG_fornitore, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_prodotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_forni, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BT_termina
        '
        Me.BT_termina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BT_termina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.BT_termina.Location = New System.Drawing.Point(417, 407)
        Me.BT_termina.Name = "BT_termina"
        Me.BT_termina.Size = New System.Drawing.Size(58, 68)
        Me.BT_termina.TabIndex = 14
        Me.BT_termina.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(160, 330)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Ricerca Fornitore"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TX_ricerca
        '
        Me.TX_ricerca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TX_ricerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TX_ricerca.Location = New System.Drawing.Point(60, 355)
        Me.TX_ricerca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TX_ricerca.Name = "TX_ricerca"
        Me.TX_ricerca.Size = New System.Drawing.Size(377, 32)
        Me.TX_ricerca.TabIndex = 12
        '
        'DG_fornitore
        '
        Me.DG_fornitore.AllowUserToAddRows = False
        Me.DG_fornitore.AllowUserToDeleteRows = False
        Me.DG_fornitore.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_fornitore.AutoGenerateColumns = False
        Me.DG_fornitore.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_fornitore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_fornitore.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.AnagraficaDataGridViewTextBoxColumn})
        Me.DG_fornitore.DataSource = Me.BS_forni
        Me.DG_fornitore.Location = New System.Drawing.Point(2, 5)
        Me.DG_fornitore.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_fornitore.Name = "DG_fornitore"
        Me.DG_fornitore.ReadOnly = True
        Me.DG_fornitore.RowHeadersWidth = 4
        Me.DG_fornitore.Size = New System.Drawing.Size(481, 320)
        Me.DG_fornitore.TabIndex = 11
        '
        'DS_prodotti
        '
        Me.DS_prodotti.DataSetName = "DS_prodotti"
        Me.DS_prodotti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_forni
        '
        Me.BS_forni.DataMember = "DT_fornitori"
        Me.BS_forni.DataSource = Me.DS_prodotti
        '
        'TA_forni
        '
        Me.TA_forni.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_prodottiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 10.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AnagraficaDataGridViewTextBoxColumn
        '
        Me.AnagraficaDataGridViewTextBoxColumn.DataPropertyName = "anagrafica"
        Me.AnagraficaDataGridViewTextBoxColumn.HeaderText = "anagrafica"
        Me.AnagraficaDataGridViewTextBoxColumn.Name = "AnagraficaDataGridViewTextBoxColumn"
        Me.AnagraficaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FRM_selezionafornitore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 480)
        Me.Controls.Add(Me.BT_termina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TX_ricerca)
        Me.Controls.Add(Me.DG_fornitore)
        Me.Name = "FRM_selezionafornitore"
        Me.Text = "Seleziona Fornitore"
        CType(Me.DG_fornitore, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_prodotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_forni, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BT_termina As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TX_ricerca As TextBox
    Friend WithEvents DG_fornitore As DataGridView
    Friend WithEvents DS_prodotti As DS_prodotti
    Friend WithEvents BS_forni As BindingSource
    Friend WithEvents TA_forni As DS_prodottiTableAdapters.TA_fornitori
    Friend WithEvents TableAdapterManager As DS_prodottiTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AnagraficaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
