<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_AggiungeAvviso
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim DataLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_AggiungeAvviso))
        Me.DS_servizio = New PoP2.Comuni.DS_servizio()
        Me.BS_user = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_credenziali = New PoP2.Comuni.DS_servizioTableAdapters.TA_credenziali()
        Me.TableAdapterManager = New PoP2.Comuni.DS_servizioTableAdapters.TableAdapterManager()
        Me.BS_avvisi = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_ag = New PoP2.Comuni.DS_ag()
        Me.TA_avvisi = New PoP2.Comuni.DS_agTableAdapters.TA_avvisi()
        Me.TableAdapterManager1 = New PoP2.Comuni.DS_agTableAdapters.TableAdapterManager()
        Me.TX_cosa = New System.Windows.Forms.TextBox()
        Me.DT_quando = New System.Windows.Forms.DateTimePicker()
        Me.TL_controlloAgenda = New System.Windows.Forms.TableLayoutPanel()
        Me.BT_avanti = New System.Windows.Forms.Button()
        Me.BT_oggi = New System.Windows.Forms.Button()
        Me.CKL_utenti = New System.Windows.Forms.CheckedListBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        DataLabel = New System.Windows.Forms.Label()
        CType(Me.DS_servizio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_user, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_avvisi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TL_controlloAgenda.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(1, 90)
        IdLabel.Margin = New System.Windows.Forms.Padding(1)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(67, 20)
        IdLabel.TabIndex = 1
        IdLabel.Text = "a Chi ?:"
        IdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(1, 58)
        DescrizioneLabel.Margin = New System.Windows.Forms.Padding(1)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(67, 20)
        DescrizioneLabel.TabIndex = 2
        DescrizioneLabel.Text = "Cosa ?:"
        '
        'DataLabel
        '
        DataLabel.AutoSize = True
        DataLabel.Location = New System.Drawing.Point(1, 27)
        DataLabel.Margin = New System.Windows.Forms.Padding(1)
        DataLabel.Name = "DataLabel"
        DataLabel.Size = New System.Drawing.Size(86, 20)
        DataLabel.TabIndex = 4
        DataLabel.Text = "Quando? :"
        '
        'DS_servizio
        '
        Me.DS_servizio.DataSetName = "DS_servizio"
        Me.DS_servizio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_user
        '
        Me.BS_user.DataMember = "DT_credenziali"
        Me.BS_user.DataSource = Me.DS_servizio
        '
        'TA_credenziali
        '
        Me.TA_credenziali.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_servizioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BS_avvisi
        '
        Me.BS_avvisi.DataMember = "DT_avvisi"
        Me.BS_avvisi.DataSource = Me.DS_ag
        '
        'DS_ag
        '
        Me.DS_ag.DataSetName = "DS_ag"
        Me.DS_ag.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_avvisi
        '
        Me.TA_avvisi.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PoP2.Comuni.DS_agTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TX_cosa
        '
        Me.TX_cosa.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_avvisi, "descrizione", True))
        Me.TX_cosa.Location = New System.Drawing.Point(101, 58)
        Me.TX_cosa.Margin = New System.Windows.Forms.Padding(1)
        Me.TX_cosa.Name = "TX_cosa"
        Me.TX_cosa.Size = New System.Drawing.Size(313, 26)
        Me.TX_cosa.TabIndex = 2
        '
        'DT_quando
        '
        Me.DT_quando.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_avvisi, "data", True))
        Me.DT_quando.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DT_quando.Location = New System.Drawing.Point(101, 27)
        Me.DT_quando.Margin = New System.Windows.Forms.Padding(1)
        Me.DT_quando.Name = "DT_quando"
        Me.DT_quando.Size = New System.Drawing.Size(121, 26)
        Me.DT_quando.TabIndex = 1
        '
        'TL_controlloAgenda
        '
        Me.TL_controlloAgenda.ColumnCount = 4
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.57469!))
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.36028!))
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.70826!))
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.18102!))
        Me.TL_controlloAgenda.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TL_controlloAgenda.Controls.Add(Me.BT_avanti, 2, 4)
        Me.TL_controlloAgenda.Controls.Add(DataLabel, 0, 1)
        Me.TL_controlloAgenda.Controls.Add(Me.BT_oggi, 3, 4)
        Me.TL_controlloAgenda.Controls.Add(Me.DT_quando, 1, 1)
        Me.TL_controlloAgenda.Controls.Add(DescrizioneLabel, 0, 2)
        Me.TL_controlloAgenda.Controls.Add(IdLabel, 0, 3)
        Me.TL_controlloAgenda.Controls.Add(Me.TX_cosa, 1, 2)
        Me.TL_controlloAgenda.Controls.Add(Me.CKL_utenti, 1, 3)
        Me.TL_controlloAgenda.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TL_controlloAgenda.Location = New System.Drawing.Point(0, 0)
        Me.TL_controlloAgenda.Margin = New System.Windows.Forms.Padding(0)
        Me.TL_controlloAgenda.Name = "TL_controlloAgenda"
        Me.TL_controlloAgenda.RowCount = 5
        Me.TL_controlloAgenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.558824!))
        Me.TL_controlloAgenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.39706!))
        Me.TL_controlloAgenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.76471!))
        Me.TL_controlloAgenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.10876!))
        Me.TL_controlloAgenda.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84.0!))
        Me.TL_controlloAgenda.Size = New System.Drawing.Size(569, 357)
        Me.TL_controlloAgenda.TabIndex = 199
        '
        'BT_avanti
        '
        Me.BT_avanti.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_avanti.Image = Global.PoP2.Comuni.My.Resources.Resources.ominoConferma48
        Me.BT_avanti.Location = New System.Drawing.Point(418, 275)
        Me.BT_avanti.Name = "BT_avanti"
        Me.BT_avanti.Size = New System.Drawing.Size(71, 79)
        Me.BT_avanti.TabIndex = 4
        Me.BT_avanti.Tag = "1"
        Me.ToolTip1.SetToolTip(Me.BT_avanti, "Conferma l'avviso")
        Me.BT_avanti.UseVisualStyleBackColor = True
        '
        'BT_oggi
        '
        Me.BT_oggi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BT_oggi.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.BT_oggi.Location = New System.Drawing.Point(496, 275)
        Me.BT_oggi.Name = "BT_oggi"
        Me.BT_oggi.Size = New System.Drawing.Size(70, 79)
        Me.BT_oggi.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BT_oggi, "Termina senza inserire l'avviso")
        Me.BT_oggi.UseVisualStyleBackColor = True
        '
        'CKL_utenti
        '
        Me.CKL_utenti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CKL_utenti.FormattingEnabled = True
        Me.CKL_utenti.Location = New System.Drawing.Point(103, 92)
        Me.CKL_utenti.Name = "CKL_utenti"
        Me.CKL_utenti.Size = New System.Drawing.Size(309, 172)
        Me.CKL_utenti.TabIndex = 6
        '
        'FRM_AggiungeAvviso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 357)
        Me.Controls.Add(Me.TL_controlloAgenda)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRM_AggiungeAvviso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Aggiunge ALLERT"
        CType(Me.DS_servizio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_user, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_avvisi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TL_controlloAgenda.ResumeLayout(False)
        Me.TL_controlloAgenda.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DS_servizio As DS_servizio
    Friend WithEvents BS_user As BindingSource
    Friend WithEvents TA_credenziali As DS_servizioTableAdapters.TA_credenziali
    Friend WithEvents TableAdapterManager As DS_servizioTableAdapters.TableAdapterManager
    Friend WithEvents DS_ag As DS_ag
    Friend WithEvents BS_avvisi As BindingSource
    Friend WithEvents TA_avvisi As DS_agTableAdapters.TA_avvisi
    Friend WithEvents TableAdapterManager1 As DS_agTableAdapters.TableAdapterManager
    Friend WithEvents TX_cosa As TextBox
    Friend WithEvents DT_quando As DateTimePicker
    Friend WithEvents TL_controlloAgenda As TableLayoutPanel
    Friend WithEvents BT_avanti As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BT_oggi As Button
    Friend WithEvents CKL_utenti As CheckedListBox
End Class
