<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_mod_fattura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_mod_fattura))
        Me.TX_num_da = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DT_v_ordiniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTBTRicerca = New System.Windows.Forms.ToolStripButton()
        Me.TTBTAggiunge = New System.Windows.Forms.ToolStripButton()
        Me.TTBTModifica = New System.Windows.Forms.ToolStripButton()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TX_fat_da = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TX_scadenza = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TX_pagamento = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TX_pagamento_data = New System.Windows.Forms.TextBox()
        Me.CK_pagata = New System.Windows.Forms.CheckBox()
        Me.CK_condominio = New System.Windows.Forms.CheckBox()
        Me.CK_nc = New System.Windows.Forms.CheckBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TX_pa_importo = New System.Windows.Forms.TextBox()
        Me.BT_cliente = New System.Windows.Forms.Button()
        Me.BT_pagamenti = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BS_pagamenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_fattura = New PoP2.Comuni.DS_fattura()
        Me.BS_cantieri = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_cantieri = New PoP2.Comuni.DS_fatturaTableAdapters.TA_cantieri()
        Me.TableAdapterManager = New PoP2.Comuni.DS_fatturaTableAdapters.TableAdapterManager()
        Me.TA_pagamenti = New PoP2.Comuni.DS_fatturaTableAdapters.TA_pagamenti()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_v_ordiniBindingNavigator.SuspendLayout()
        CType(Me.BS_pagamenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_cantieri, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TX_num_da
        '
        Me.TX_num_da.Location = New System.Drawing.Point(15, 30)
        Me.TX_num_da.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_num_da.Name = "TX_num_da"
        Me.TX_num_da.ReadOnly = True
        Me.TX_num_da.Size = New System.Drawing.Size(88, 23)
        Me.TX_num_da.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Numero Fattura"
        '
        'DT_v_ordiniBindingNavigator
        '
        Me.DT_v_ordiniBindingNavigator.AddNewItem = Nothing
        Me.DT_v_ordiniBindingNavigator.AutoSize = False
        Me.DT_v_ordiniBindingNavigator.CountItem = Nothing
        Me.DT_v_ordiniBindingNavigator.DeleteItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_v_ordiniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicerca, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.TTBTannulla})
        Me.DT_v_ordiniBindingNavigator.Location = New System.Drawing.Point(0, 302)
        Me.DT_v_ordiniBindingNavigator.MoveFirstItem = Nothing
        Me.DT_v_ordiniBindingNavigator.MoveLastItem = Nothing
        Me.DT_v_ordiniBindingNavigator.MoveNextItem = Nothing
        Me.DT_v_ordiniBindingNavigator.MovePreviousItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Name = "DT_v_ordiniBindingNavigator"
        Me.DT_v_ordiniBindingNavigator.PositionItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Size = New System.Drawing.Size(425, 79)
        Me.DT_v_ordiniBindingNavigator.TabIndex = 150
        Me.DT_v_ordiniBindingNavigator.Text = "BindingNavigator1"
        '
        'TTBTRicerca
        '
        Me.TTBTRicerca.AutoSize = False
        Me.TTBTRicerca.Image = Global.PoP2.Comuni.My.Resources.Resources.Omino_ricarica48
        Me.TTBTRicerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTRicerca.Name = "TTBTRicerca"
        Me.TTBTRicerca.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicerca.Text = "Ricarica"
        Me.TTBTRicerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicerca.ToolTipText = "Seleziona l'Anno"
        Me.TTBTRicerca.Visible = False
        '
        'TTBTAggiunge
        '
        Me.TTBTAggiunge.AutoSize = False
        Me.TTBTAggiunge.Image = CType(resources.GetObject("TTBTAggiunge.Image"), System.Drawing.Image)
        Me.TTBTAggiunge.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTAggiunge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTAggiunge.Name = "TTBTAggiunge"
        Me.TTBTAggiunge.RightToLeftAutoMirrorImage = True
        Me.TTBTAggiunge.Size = New System.Drawing.Size(50, 70)
        Me.TTBTAggiunge.Text = "Nuovo"
        Me.TTBTAggiunge.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTAggiunge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTAggiunge.Visible = False
        '
        'TTBTModifica
        '
        Me.TTBTModifica.AutoSize = False
        Me.TTBTModifica.Image = Global.PoP2.Comuni.My.Resources.Resources.modifica
        Me.TTBTModifica.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTModifica.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTModifica.Name = "TTBTModifica"
        Me.TTBTModifica.RightToLeftAutoMirrorImage = True
        Me.TTBTModifica.Size = New System.Drawing.Size(50, 70)
        Me.TTBTModifica.Text = "Modifica"
        Me.TTBTModifica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTModifica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTModifica.Visible = False
        '
        'TTBTElimina
        '
        Me.TTBTElimina.AutoSize = False
        Me.TTBTElimina.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_cestino48
        Me.TTBTElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTElimina.Name = "TTBTElimina"
        Me.TTBTElimina.RightToLeftAutoMirrorImage = True
        Me.TTBTElimina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTElimina.Text = "Elimina"
        Me.TTBTElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTElimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTElimina.Visible = False
        '
        'TTBTSalva
        '
        Me.TTBTSalva.AutoSize = False
        Me.TTBTSalva.Image = CType(resources.GetObject("TTBTSalva.Image"), System.Drawing.Image)
        Me.TTBTSalva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTSalva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTSalva.Name = "TTBTSalva"
        Me.TTBTSalva.Size = New System.Drawing.Size(50, 70)
        Me.TTBTSalva.Text = "Salva"
        Me.TTBTSalva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTSalva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTSalva.Visible = False
        '
        'TTBTTermina
        '
        Me.TTBTTermina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TTBTTermina.AutoSize = False
        Me.TTBTTermina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.TTBTTermina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTTermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTTermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTTermina.Name = "TTBTTermina"
        Me.TTBTTermina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTTermina.Text = "Termina"
        Me.TTBTTermina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTTermina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'TTBTannulla
        '
        Me.TTBTannulla.AutoSize = False
        Me.TTBTannulla.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TTBTannulla.Image = Global.PoP2.Comuni.My.Resources.Resources.ricicla48
        Me.TTBTannulla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTannulla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTannulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTannulla.Name = "TTBTannulla"
        Me.TTBTannulla.Size = New System.Drawing.Size(150, 75)
        Me.TTBTannulla.Text = "Annulla"
        Me.TTBTannulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTannulla.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        Me.TTBTannulla.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(150, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 17)
        Me.Label2.TabIndex = 148
        Me.Label2.Text = "Data"
        '
        'TX_fat_da
        '
        Me.TX_fat_da.Location = New System.Drawing.Point(153, 127)
        Me.TX_fat_da.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_fat_da.Name = "TX_fat_da"
        Me.TX_fat_da.Size = New System.Drawing.Size(88, 23)
        Me.TX_fat_da.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 150
        Me.Label3.Text = "Cliente"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(250, 106)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 152
        Me.Label4.Text = "Scadenza"
        '
        'TX_scadenza
        '
        Me.TX_scadenza.Location = New System.Drawing.Point(253, 127)
        Me.TX_scadenza.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_scadenza.Name = "TX_scadenza"
        Me.TX_scadenza.Size = New System.Drawing.Size(88, 23)
        Me.TX_scadenza.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 163)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 154
        Me.Label5.Text = "Pagamento"
        '
        'TX_pagamento
        '
        Me.TX_pagamento.Location = New System.Drawing.Point(15, 184)
        Me.TX_pagamento.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_pagamento.Name = "TX_pagamento"
        Me.TX_pagamento.ReadOnly = True
        Me.TX_pagamento.Size = New System.Drawing.Size(329, 23)
        Me.TX_pagamento.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 17)
        Me.Label6.TabIndex = 158
        Me.Label6.Text = "Data Pagamento"
        '
        'TX_pagamento_data
        '
        Me.TX_pagamento_data.Location = New System.Drawing.Point(127, 239)
        Me.TX_pagamento_data.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_pagamento_data.Name = "TX_pagamento_data"
        Me.TX_pagamento_data.Size = New System.Drawing.Size(88, 23)
        Me.TX_pagamento_data.TabIndex = 9
        '
        'CK_pagata
        '
        Me.CK_pagata.Appearance = System.Windows.Forms.Appearance.Button
        Me.CK_pagata.AutoSize = True
        Me.CK_pagata.Location = New System.Drawing.Point(15, 237)
        Me.CK_pagata.Name = "CK_pagata"
        Me.CK_pagata.Size = New System.Drawing.Size(90, 27)
        Me.CK_pagata.TabIndex = 8
        Me.CK_pagata.Text = "Pagamento"
        Me.CK_pagata.UseVisualStyleBackColor = True
        '
        'CK_condominio
        '
        Me.CK_condominio.Appearance = System.Windows.Forms.Appearance.Button
        Me.CK_condominio.AutoSize = True
        Me.CK_condominio.Location = New System.Drawing.Point(15, 127)
        Me.CK_condominio.Name = "CK_condominio"
        Me.CK_condominio.Size = New System.Drawing.Size(92, 27)
        Me.CK_condominio.TabIndex = 6
        Me.CK_condominio.Text = "Condominio"
        Me.CK_condominio.UseVisualStyleBackColor = True
        '
        'CK_nc
        '
        Me.CK_nc.Appearance = System.Windows.Forms.Appearance.Button
        Me.CK_nc.Location = New System.Drawing.Point(165, 28)
        Me.CK_nc.Name = "CK_nc"
        Me.CK_nc.Size = New System.Drawing.Size(128, 25)
        Me.CK_nc.TabIndex = 2
        Me.CK_nc.Text = "Nota di Credito"
        Me.CK_nc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CK_nc.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(253, 220)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 17)
        Me.Label10.TabIndex = 165
        Me.Label10.Text = "Importo Pagato"
        '
        'TX_pa_importo
        '
        Me.TX_pa_importo.Location = New System.Drawing.Point(256, 241)
        Me.TX_pa_importo.Margin = New System.Windows.Forms.Padding(4)
        Me.TX_pa_importo.Name = "TX_pa_importo"
        Me.TX_pa_importo.Size = New System.Drawing.Size(134, 23)
        Me.TX_pa_importo.TabIndex = 10
        '
        'BT_cliente
        '
        Me.BT_cliente.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_cerca48x48
        Me.BT_cliente.Location = New System.Drawing.Point(349, 42)
        Me.BT_cliente.Name = "BT_cliente"
        Me.BT_cliente.Size = New System.Drawing.Size(55, 59)
        Me.BT_cliente.TabIndex = 168
        Me.ToolTip1.SetToolTip(Me.BT_cliente, "Cerca il cliente")
        Me.BT_cliente.UseVisualStyleBackColor = True
        '
        'BT_pagamenti
        '
        Me.BT_pagamenti.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_cerca48x48
        Me.BT_pagamenti.Location = New System.Drawing.Point(351, 154)
        Me.BT_pagamenti.Name = "BT_pagamenti"
        Me.BT_pagamenti.Size = New System.Drawing.Size(55, 59)
        Me.BT_pagamenti.TabIndex = 169
        Me.ToolTip1.SetToolTip(Me.BT_pagamenti, "Cerca il tipo di pagamento")
        Me.BT_pagamenti.UseVisualStyleBackColor = True
        '
        'BS_pagamenti
        '
        Me.BS_pagamenti.DataMember = "DT_pagamenti"
        Me.BS_pagamenti.DataSource = Me.DS_fattura
        '
        'DS_fattura
        '
        Me.DS_fattura.DataSetName = "DS_fattura"
        Me.DS_fattura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_cantieri
        '
        Me.BS_cantieri.DataMember = "DT_cantieri"
        Me.BS_cantieri.DataSource = Me.DS_fattura
        '
        'TA_cantieri
        '
        Me.TA_cantieri.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_fatturaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TA_pagamenti
        '
        Me.TA_pagamenti.ClearBeforeFill = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DS_fattura, "DT_fattura.fat_cli_id", True))
        Me.ComboBox1.DataSource = Me.BS_cantieri
        Me.ComboBox1.DisplayMember = "societa"
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 77)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(329, 24)
        Me.ComboBox1.TabIndex = 170
        Me.ComboBox1.ValueMember = "id"
        '
        'FRM_mod_fattura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BT_pagamenti)
        Me.Controls.Add(Me.BT_cliente)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TX_pa_importo)
        Me.Controls.Add(Me.CK_nc)
        Me.Controls.Add(Me.CK_condominio)
        Me.Controls.Add(Me.CK_pagata)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TX_pagamento_data)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TX_pagamento)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TX_scadenza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TX_fat_da)
        Me.Controls.Add(Me.DT_v_ordiniBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TX_num_da)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRM_mod_fattura"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FRM_fattura_mod"
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_v_ordiniBindingNavigator.ResumeLayout(False)
        Me.DT_v_ordiniBindingNavigator.PerformLayout()
        CType(Me.BS_pagamenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_cantieri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_fattura As DS_fattura
    Friend WithEvents BS_cantieri As BindingSource
    Friend WithEvents TA_cantieri As DS_fatturaTableAdapters.TA_cantieri
    Friend WithEvents TableAdapterManager As DS_fatturaTableAdapters.TableAdapterManager
    Friend WithEvents TX_num_da As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DT_v_ordiniBindingNavigator As BindingNavigator
    Friend WithEvents TTBTRicerca As ToolStripButton
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents TTBTModifica As ToolStripButton
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTannulla As ToolStripButton
    Friend WithEvents Label2 As Label
    Friend WithEvents TX_fat_da As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TX_scadenza As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TX_pagamento As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TX_pagamento_data As TextBox
    Friend WithEvents CK_pagata As CheckBox
    Friend WithEvents BS_pagamenti As BindingSource
    Friend WithEvents TA_pagamenti As DS_fatturaTableAdapters.TA_pagamenti
    Friend WithEvents CK_condominio As CheckBox
    Friend WithEvents CK_nc As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TX_pa_importo As TextBox
    Friend WithEvents BT_cliente As Button
    Friend WithEvents BT_pagamenti As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ComboBox1 As ComboBox
End Class
