<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCercaDettaglioCliente
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
        Me.DG_cliente = New System.Windows.Forms.DataGridView()
        Me.IdDettaglioDatagridviewColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocazioneDatagridviewColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsLocazione = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_clienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_clienti = New PoP2.Comuni.DS_clienti()
        Me.BT_termina = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TX_ricerca = New System.Windows.Forms.TextBox()
        Me.TA_clienti = New PoP2.Comuni.DS_clientiTableAdapters.TA_cantieri_new()
        Me.BS_pagamenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_pagamenti_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_pagamenti_new()
        Me.TableAdapterManager = New PoP2.Comuni.DS_clientiTableAdapters.TableAdapterManager()
        Me.TA_locazione_new = New PoP2.Comuni.DS_clientiTableAdapters.TA_locazione_new()
        CType(Me.DG_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsLocazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_pagamenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DG_cliente
        '
        Me.DG_cliente.AllowUserToAddRows = False
        Me.DG_cliente.AllowUserToDeleteRows = False
        Me.DG_cliente.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DG_cliente.AutoGenerateColumns = False
        Me.DG_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_cliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDettaglioDatagridviewColumn, Me.LocazioneDatagridviewColumn})
        Me.DG_cliente.DataSource = Me.bsLocazione
        Me.DG_cliente.Location = New System.Drawing.Point(5, 4)
        Me.DG_cliente.Margin = New System.Windows.Forms.Padding(1)
        Me.DG_cliente.Name = "DG_cliente"
        Me.DG_cliente.ReadOnly = True
        Me.DG_cliente.RowHeadersWidth = 4
        Me.DG_cliente.Size = New System.Drawing.Size(437, 290)
        Me.DG_cliente.TabIndex = 1
        '
        'IdDettaglioDatagridviewColumn
        '
        Me.IdDettaglioDatagridviewColumn.DataPropertyName = "id"
        Me.IdDettaglioDatagridviewColumn.HeaderText = "id"
        Me.IdDettaglioDatagridviewColumn.Name = "IdDettaglioDatagridviewColumn"
        Me.IdDettaglioDatagridviewColumn.ReadOnly = True
        Me.IdDettaglioDatagridviewColumn.Visible = False
        '
        'LocazioneDatagridviewColumn
        '
        Me.LocazioneDatagridviewColumn.DataPropertyName = "locazione"
        Me.LocazioneDatagridviewColumn.HeaderText = "Dettaglio"
        Me.LocazioneDatagridviewColumn.Name = "LocazioneDatagridviewColumn"
        Me.LocazioneDatagridviewColumn.ReadOnly = True
        '
        'bsLocazione
        '
        Me.bsLocazione.DataMember = "DT_cantieri_new_DT_locazione_new"
        Me.bsLocazione.DataSource = Me.BS_clienti
        '
        'BS_clienti
        '
        Me.BS_clienti.DataMember = "DT_cantieri_new"
        Me.BS_clienti.DataSource = Me.DS_clienti
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
        Me.BT_termina.Location = New System.Drawing.Point(381, 373)
        Me.BT_termina.Name = "BT_termina"
        Me.BT_termina.Size = New System.Drawing.Size(58, 68)
        Me.BT_termina.TabIndex = 10
        Me.BT_termina.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(158, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Ricerca il cliente"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TX_ricerca
        '
        Me.TX_ricerca.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TX_ricerca.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!)
        Me.TX_ricerca.Location = New System.Drawing.Point(58, 321)
        Me.TX_ricerca.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TX_ricerca.Name = "TX_ricerca"
        Me.TX_ricerca.Size = New System.Drawing.Size(343, 32)
        Me.TX_ricerca.TabIndex = 8
        '
        'TA_clienti
        '
        Me.TA_clienti.ClearBeforeFill = True
        '
        'BS_pagamenti
        '
        Me.BS_pagamenti.DataMember = "DT_pagamenti_new"
        Me.BS_pagamenti.DataSource = Me.DS_clienti
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
        'TA_locazione_new
        '
        Me.TA_locazione_new.ClearBeforeFill = True
        '
        'FRM_selezionacantiere
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(443, 443)
        Me.ControlBox = False
        Me.Controls.Add(Me.BT_termina)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TX_ricerca)
        Me.Controls.Add(Me.DG_cliente)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmCercaDettaglioCliente"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Seleziona Dettaglio"
        CType(Me.DG_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsLocazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_pagamenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DG_cliente As DataGridView
    Friend WithEvents DS_clienti As DS_clienti
    Friend WithEvents BS_clienti As BindingSource
    Friend WithEvents TA_clienti As DS_clientiTableAdapters.TA_cantieri_new
    Friend WithEvents BT_termina As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TX_ricerca As TextBox
    Friend WithEvents BS_pagamenti As BindingSource
    Friend WithEvents TA_pagamenti_new As DS_clientiTableAdapters.TA_pagamenti_new
    Friend WithEvents TableAdapterManager As DS_clientiTableAdapters.TableAdapterManager
    Friend WithEvents IdDettaglioDatagridviewColumn As DataGridViewTextBoxColumn
    Friend WithEvents LocazioneDatagridviewColumn As DataGridViewTextBoxColumn
    Friend WithEvents bsLocazione As BindingSource
    Friend WithEvents TA_locazione_new As DS_clientiTableAdapters.TA_locazione_new
End Class
