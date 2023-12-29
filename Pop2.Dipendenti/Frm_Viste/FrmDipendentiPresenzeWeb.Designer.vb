<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDipendentiPresenzeWeb
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
        Dim GiornoLabel As System.Windows.Forms.Label
        Dim IngressoLabel As System.Windows.Forms.Label
        Dim UscitaLabel As System.Windows.Forms.Label
        Dim Id_terminaleLabel As System.Windows.Forms.Label
        Dim Id_locazioneLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDipendentiPresenzeWeb))
        Me.GiornoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BS_presenzeWEB = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.IngressoTextBox = New System.Windows.Forms.TextBox()
        Me.UscitaTextBox = New System.Windows.Forms.TextBox()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        Me.TA_presenzeWEB = New PoP2.Comuni.DS_utentiTableAdapters.TA_presenzeWEB()
        Me.TableAdapterManager = New PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager()
        Me.DTdestinatariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_destinatari = New PoP2.Comuni.DS_utentiTableAdapters.TA_destinatari()
        GiornoLabel = New System.Windows.Forms.Label()
        IngressoLabel = New System.Windows.Forms.Label()
        UscitaLabel = New System.Windows.Forms.Label()
        Id_terminaleLabel = New System.Windows.Forms.Label()
        Id_locazioneLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.BS_presenzeWEB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        CType(Me.DTdestinatariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GiornoLabel
        '
        GiornoLabel.AutoSize = True
        GiornoLabel.Location = New System.Drawing.Point(22, 27)
        GiornoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GiornoLabel.Name = "GiornoLabel"
        GiornoLabel.Size = New System.Drawing.Size(57, 20)
        GiornoLabel.TabIndex = 0
        GiornoLabel.Text = "giorno:"
        '
        'IngressoLabel
        '
        IngressoLabel.AutoSize = True
        IngressoLabel.Location = New System.Drawing.Point(22, 64)
        IngressoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IngressoLabel.Name = "IngressoLabel"
        IngressoLabel.Size = New System.Drawing.Size(73, 20)
        IngressoLabel.TabIndex = 2
        IngressoLabel.Text = "ingresso:"
        '
        'UscitaLabel
        '
        UscitaLabel.AutoSize = True
        UscitaLabel.Location = New System.Drawing.Point(22, 104)
        UscitaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UscitaLabel.Name = "UscitaLabel"
        UscitaLabel.Size = New System.Drawing.Size(55, 20)
        UscitaLabel.TabIndex = 4
        UscitaLabel.Text = "uscita:"
        '
        'Id_terminaleLabel
        '
        Id_terminaleLabel.AutoSize = True
        Id_terminaleLabel.Location = New System.Drawing.Point(22, 140)
        Id_terminaleLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_terminaleLabel.Name = "Id_terminaleLabel"
        Id_terminaleLabel.Size = New System.Drawing.Size(58, 20)
        Id_terminaleLabel.TabIndex = 16
        Id_terminaleLabel.Text = "Cliente"
        '
        'Id_locazioneLabel
        '
        Id_locazioneLabel.AutoSize = True
        Id_locazioneLabel.Location = New System.Drawing.Point(22, 181)
        Id_locazioneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Id_locazioneLabel.Name = "Id_locazioneLabel"
        Id_locazioneLabel.Size = New System.Drawing.Size(126, 20)
        Id_locazioneLabel.TabIndex = 18
        Id_locazioneLabel.Text = "Dettaglio Cliente"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(22, 275)
        NoteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(45, 20)
        NoteLabel.TabIndex = 24
        NoteLabel.Text = "note:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(22, 225)
        Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(72, 20)
        Label1.TabIndex = 191
        Label1.Text = "Tipologia"
        '
        'GiornoDateTimePicker
        '
        Me.GiornoDateTimePicker.CalendarMonthBackground = System.Drawing.SystemColors.ButtonFace
        Me.GiornoDateTimePicker.CustomFormat = "d"
        Me.GiornoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_presenzeWEB, "giorno", True))
        Me.GiornoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.GiornoDateTimePicker.Location = New System.Drawing.Point(169, 17)
        Me.GiornoDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GiornoDateTimePicker.Name = "GiornoDateTimePicker"
        Me.GiornoDateTimePicker.Size = New System.Drawing.Size(63, 26)
        Me.GiornoDateTimePicker.TabIndex = 0
        '
        'BS_presenzeWEB
        '
        Me.BS_presenzeWEB.DataMember = "DT_presenzeWEB"
        Me.BS_presenzeWEB.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IngressoTextBox
        '
        Me.IngressoTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.IngressoTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IngressoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_presenzeWEB, "ingresso", True))
        Me.IngressoTextBox.Location = New System.Drawing.Point(169, 64)
        Me.IngressoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IngressoTextBox.Name = "IngressoTextBox"
        Me.IngressoTextBox.Size = New System.Drawing.Size(76, 19)
        Me.IngressoTextBox.TabIndex = 1
        '
        'UscitaTextBox
        '
        Me.UscitaTextBox.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.UscitaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UscitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_presenzeWEB, "uscita", True))
        Me.UscitaTextBox.Location = New System.Drawing.Point(169, 97)
        Me.UscitaTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UscitaTextBox.Name = "UscitaTextBox"
        Me.UscitaTextBox.Size = New System.Drawing.Size(76, 19)
        Me.UscitaTextBox.TabIndex = 2
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_presenzeWEB, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(169, 268)
        Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(298, 26)
        Me.NoteTextBox.TabIndex = 20
        '
        'DM_barra
        '
        Me.DM_barra.AddNewItem = Nothing
        Me.DM_barra.AutoSize = False
        Me.DM_barra.CountItem = Nothing
        Me.DM_barra.DeleteItem = Nothing
        Me.DM_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DM_barra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DM_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTSalva, Me.TTBTTermina, Me.TTBTannulla})
        Me.DM_barra.Location = New System.Drawing.Point(0, 308)
        Me.DM_barra.MoveFirstItem = Nothing
        Me.DM_barra.MoveLastItem = Nothing
        Me.DM_barra.MoveNextItem = Nothing
        Me.DM_barra.MovePreviousItem = Nothing
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.PositionItem = Nothing
        Me.DM_barra.Size = New System.Drawing.Size(484, 79)
        Me.DM_barra.TabIndex = 190
        Me.DM_barra.Text = "BindingNavigator1"
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
        Me.TTBTannulla.CheckOnClick = True
        Me.TTBTannulla.DoubleClickEnabled = True
        Me.TTBTannulla.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.TTBTannulla.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_ricarica
        Me.TTBTannulla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTannulla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTannulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTannulla.Name = "TTBTannulla"
        Me.TTBTannulla.Size = New System.Drawing.Size(50, 70)
        Me.TTBTannulla.Text = "Annulla"
        Me.TTBTannulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTannulla.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'TA_presenzeWEB
        '
        Me.TA_presenzeWEB.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DTdestinatariBindingSource
        '
        Me.DTdestinatariBindingSource.DataMember = "DT_destinatari"
        Me.DTdestinatariBindingSource.DataSource = Me.DS_utenti
        '
        'TA_destinatari
        '
        Me.TA_destinatari.ClearBeforeFill = True
        '
        'FRMdipendentimodificapresenzeweb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 387)
        Me.ControlBox = False
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.DM_barra)
        Me.Controls.Add(GiornoLabel)
        Me.Controls.Add(Me.GiornoDateTimePicker)
        Me.Controls.Add(IngressoLabel)
        Me.Controls.Add(Me.IngressoTextBox)
        Me.Controls.Add(UscitaLabel)
        Me.Controls.Add(Me.UscitaTextBox)
        Me.Controls.Add(Id_terminaleLabel)
        Me.Controls.Add(Id_locazioneLabel)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "FRMdipendentimodificapresenzeweb"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modifica Presenze WEB"
        CType(Me.BS_presenzeWEB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        CType(Me.DTdestinatariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents BS_presenzeWEB As BindingSource
    Friend WithEvents TA_presenzeWEB As DS_utentiTableAdapters.TA_presenzeWEB
    Friend WithEvents TableAdapterManager As DS_utentiTableAdapters.TableAdapterManager
    Friend WithEvents GiornoDateTimePicker As DateTimePicker
    Friend WithEvents IngressoTextBox As TextBox
    Friend WithEvents UscitaTextBox As TextBox
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTannulla As ToolStripButton
    Friend WithEvents DTdestinatariBindingSource As BindingSource
    Friend WithEvents TA_destinatari As DS_utentiTableAdapters.TA_destinatari
End Class
