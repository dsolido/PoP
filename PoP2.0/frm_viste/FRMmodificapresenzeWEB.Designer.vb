<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMmodificapresenzeWEB
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
        Dim SocietaLabel As System.Windows.Forms.Label
        Dim LocazioneLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim GiornoLabel As System.Windows.Forms.Label
        Dim IngressoLabel As System.Windows.Forms.Label
        Dim UscitaLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMmodificapresenzeWEB))
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.DT_clientiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_clienti = New PoP2.Comuni.DS_utentiTableAdapters.TA_clienti()
        Me.TableAdapterManager = New PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager()
        Me.DT_presenzeWEBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SocietaComboBox = New System.Windows.Forms.ComboBox()
        Me.DT_destinatariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_destinatari = New PoP2.Comuni.DS_utentiTableAdapters.TA_destinatari()
        Me.LocazioneListBox = New System.Windows.Forms.ListBox()
        Me.RELclientidestinatariBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_tipologiaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_tipologia = New PoP2.Comuni.DS_utentiTableAdapters.TA_tipologia()
        Me.DescrizioneListBox = New System.Windows.Forms.ListBox()
        Me.TA_presenzeWEB = New PoP2.Comuni.DS_utentiTableAdapters.TA_presenzeWEB()
        Me.GiornoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.IngressoTextBox = New System.Windows.Forms.TextBox()
        Me.UscitaTextBox = New System.Windows.Forms.TextBox()
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        Me.BTClientieLocazioniNascoste = New System.Windows.Forms.Button()
        SocietaLabel = New System.Windows.Forms.Label()
        LocazioneLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        GiornoLabel = New System.Windows.Forms.Label()
        IngressoLabel = New System.Windows.Forms.Label()
        UscitaLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_clientiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_presenzeWEBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_destinatariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RELclientidestinatariBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_tipologiaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'SocietaLabel
        '
        SocietaLabel.AutoSize = True
        SocietaLabel.Location = New System.Drawing.Point(36, 132)
        SocietaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SocietaLabel.Name = "SocietaLabel"
        SocietaLabel.Size = New System.Drawing.Size(62, 20)
        SocietaLabel.TabIndex = 1
        SocietaLabel.Text = "Cliente:"
        '
        'LocazioneLabel
        '
        LocazioneLabel.AutoSize = True
        LocazioneLabel.Location = New System.Drawing.Point(21, 169)
        LocazioneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LocazioneLabel.Name = "LocazioneLabel"
        LocazioneLabel.Size = New System.Drawing.Size(77, 20)
        LocazioneLabel.TabIndex = 3
        LocazioneLabel.Text = "Dettaglio:"
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(3, 283)
        DescrizioneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(95, 20)
        DescrizioneLabel.TabIndex = 5
        DescrizioneLabel.Text = "Operazione:"
        '
        'GiornoLabel
        '
        GiornoLabel.AutoSize = True
        GiornoLabel.Location = New System.Drawing.Point(41, 25)
        GiornoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        GiornoLabel.Name = "GiornoLabel"
        GiornoLabel.Size = New System.Drawing.Size(57, 20)
        GiornoLabel.TabIndex = 7
        GiornoLabel.Text = "giorno:"
        '
        'IngressoLabel
        '
        IngressoLabel.AutoSize = True
        IngressoLabel.Location = New System.Drawing.Point(25, 58)
        IngressoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IngressoLabel.Name = "IngressoLabel"
        IngressoLabel.Size = New System.Drawing.Size(73, 20)
        IngressoLabel.TabIndex = 9
        IngressoLabel.Text = "ingresso:"
        '
        'UscitaLabel
        '
        UscitaLabel.AutoSize = True
        UscitaLabel.Location = New System.Drawing.Point(43, 94)
        UscitaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        UscitaLabel.Name = "UscitaLabel"
        UscitaLabel.Size = New System.Drawing.Size(55, 20)
        UscitaLabel.TabIndex = 11
        UscitaLabel.Text = "uscita:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(53, 401)
        NoteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(45, 20)
        NoteLabel.TabIndex = 13
        NoteLabel.Text = "note:"
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_clientiBindingSource
        '
        Me.DT_clientiBindingSource.DataMember = "DT_clienti"
        Me.DT_clientiBindingSource.DataSource = Me.DS_utenti
        '
        'TA_clienti
        '
        Me.TA_clienti.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DT_presenzeWEBBindingSource
        '
        Me.DT_presenzeWEBBindingSource.DataMember = "DT_presenzeWEB"
        Me.DT_presenzeWEBBindingSource.DataSource = Me.DS_utenti
        '
        'SocietaComboBox
        '
        Me.SocietaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_presenzeWEBBindingSource, "id_terminale", True))
        Me.SocietaComboBox.DataSource = Me.DT_clientiBindingSource
        Me.SocietaComboBox.DisplayMember = "societa"
        Me.SocietaComboBox.FormattingEnabled = True
        Me.SocietaComboBox.Location = New System.Drawing.Point(109, 128)
        Me.SocietaComboBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SocietaComboBox.Name = "SocietaComboBox"
        Me.SocietaComboBox.Size = New System.Drawing.Size(279, 28)
        Me.SocietaComboBox.TabIndex = 3
        Me.SocietaComboBox.ValueMember = "id"
        '
        'DT_destinatariBindingSource
        '
        Me.DT_destinatariBindingSource.DataMember = "REL_clientidestinatari"
        Me.DT_destinatariBindingSource.DataSource = Me.DT_clientiBindingSource
        '
        'TA_destinatari
        '
        Me.TA_destinatari.ClearBeforeFill = True
        '
        'LocazioneListBox
        '
        Me.LocazioneListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_presenzeWEBBindingSource, "id_locazione", True))
        Me.LocazioneListBox.DataSource = Me.RELclientidestinatariBindingSource
        Me.LocazioneListBox.DisplayMember = "locazione"
        Me.LocazioneListBox.FormattingEnabled = True
        Me.LocazioneListBox.ItemHeight = 20
        Me.LocazioneListBox.Location = New System.Drawing.Point(109, 169)
        Me.LocazioneListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LocazioneListBox.Name = "LocazioneListBox"
        Me.LocazioneListBox.Size = New System.Drawing.Size(357, 104)
        Me.LocazioneListBox.TabIndex = 4
        Me.LocazioneListBox.ValueMember = "id"
        '
        'RELclientidestinatariBindingSource
        '
        Me.RELclientidestinatariBindingSource.DataMember = "REL_clientidestinatari"
        Me.RELclientidestinatariBindingSource.DataSource = Me.DT_clientiBindingSource
        '
        'DT_tipologiaBindingSource
        '
        Me.DT_tipologiaBindingSource.DataMember = "DT_tipologia"
        Me.DT_tipologiaBindingSource.DataSource = Me.DS_utenti
        '
        'TA_tipologia
        '
        Me.TA_tipologia.ClearBeforeFill = True
        '
        'DescrizioneListBox
        '
        Me.DescrizioneListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_presenzeWEBBindingSource, "inviato", True))
        Me.DescrizioneListBox.DataSource = Me.DT_tipologiaBindingSource
        Me.DescrizioneListBox.DisplayMember = "descrizione"
        Me.DescrizioneListBox.FormattingEnabled = True
        Me.DescrizioneListBox.ItemHeight = 20
        Me.DescrizioneListBox.Location = New System.Drawing.Point(109, 283)
        Me.DescrizioneListBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DescrizioneListBox.Name = "DescrizioneListBox"
        Me.DescrizioneListBox.Size = New System.Drawing.Size(357, 104)
        Me.DescrizioneListBox.TabIndex = 5
        Me.DescrizioneListBox.ValueMember = "id_tipo"
        '
        'TA_presenzeWEB
        '
        Me.TA_presenzeWEB.ClearBeforeFill = True
        '
        'GiornoDateTimePicker
        '
        Me.GiornoDateTimePicker.CustomFormat = "d"
        Me.GiornoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DT_presenzeWEBBindingSource, "giorno", True))
        Me.GiornoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.GiornoDateTimePicker.Location = New System.Drawing.Point(109, 21)
        Me.GiornoDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GiornoDateTimePicker.Name = "GiornoDateTimePicker"
        Me.GiornoDateTimePicker.Size = New System.Drawing.Size(58, 26)
        Me.GiornoDateTimePicker.TabIndex = 0
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_presenzeWEBBindingSource, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(109, 397)
        Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NoteTextBox.Multiline = True
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(357, 74)
        Me.NoteTextBox.TabIndex = 6
        '
        'IngressoTextBox
        '
        Me.IngressoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_presenzeWEBBindingSource, "ingresso", True))
        Me.IngressoTextBox.Location = New System.Drawing.Point(109, 56)
        Me.IngressoTextBox.Name = "IngressoTextBox"
        Me.IngressoTextBox.Size = New System.Drawing.Size(86, 26)
        Me.IngressoTextBox.TabIndex = 1
        '
        'UscitaTextBox
        '
        Me.UscitaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_presenzeWEBBindingSource, "uscita", True))
        Me.UscitaTextBox.Location = New System.Drawing.Point(109, 88)
        Me.UscitaTextBox.Name = "UscitaTextBox"
        Me.UscitaTextBox.Size = New System.Drawing.Size(86, 26)
        Me.UscitaTextBox.TabIndex = 2
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
        Me.DM_barra.Location = New System.Drawing.Point(0, 490)
        Me.DM_barra.MoveFirstItem = Nothing
        Me.DM_barra.MoveLastItem = Nothing
        Me.DM_barra.MoveNextItem = Nothing
        Me.DM_barra.MovePreviousItem = Nothing
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.PositionItem = Nothing
        Me.DM_barra.Size = New System.Drawing.Size(486, 79)
        Me.DM_barra.TabIndex = 7
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
        'BTClientieLocazioniNascoste
        '
        Me.BTClientieLocazioniNascoste.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTClientieLocazioniNascoste.Location = New System.Drawing.Point(387, 127)
        Me.BTClientieLocazioniNascoste.Name = "BTClientieLocazioniNascoste"
        Me.BTClientieLocazioniNascoste.Size = New System.Drawing.Size(79, 31)
        Me.BTClientieLocazioniNascoste.TabIndex = 192
        Me.BTClientieLocazioniNascoste.Text = "Attivo tutti"
        Me.BTClientieLocazioniNascoste.UseVisualStyleBackColor = True
        '
        'FRMmodificapresenzeWEB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(486, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTClientieLocazioniNascoste)
        Me.Controls.Add(Me.DM_barra)
        Me.Controls.Add(Me.UscitaTextBox)
        Me.Controls.Add(Me.IngressoTextBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(UscitaLabel)
        Me.Controls.Add(IngressoLabel)
        Me.Controls.Add(GiornoLabel)
        Me.Controls.Add(Me.GiornoDateTimePicker)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneListBox)
        Me.Controls.Add(LocazioneLabel)
        Me.Controls.Add(Me.LocazioneListBox)
        Me.Controls.Add(SocietaLabel)
        Me.Controls.Add(Me.SocietaComboBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRMmodificapresenzeWEB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Modifica Presenze WEB"
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_clientiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_presenzeWEBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_destinatariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RELclientidestinatariBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_tipologiaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents DT_clientiBindingSource As BindingSource
    Friend WithEvents TA_clienti As DS_utentiTableAdapters.TA_clienti
    Friend WithEvents TableAdapterManager As DS_utentiTableAdapters.TableAdapterManager
    Friend WithEvents SocietaComboBox As ComboBox
    Friend WithEvents DT_destinatariBindingSource As BindingSource
    Friend WithEvents TA_destinatari As DS_utentiTableAdapters.TA_destinatari
    Friend WithEvents LocazioneListBox As ListBox
    Friend WithEvents DT_tipologiaBindingSource As BindingSource
    Friend WithEvents TA_tipologia As DS_utentiTableAdapters.TA_tipologia
    Friend WithEvents DescrizioneListBox As ListBox
    Friend WithEvents DT_presenzeWEBBindingSource As BindingSource
    Friend WithEvents TA_presenzeWEB As DS_utentiTableAdapters.TA_presenzeWEB
    Friend WithEvents GiornoDateTimePicker As DateTimePicker
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents RELclientidestinatariBindingSource As BindingSource
    Friend WithEvents IngressoTextBox As TextBox
    Friend WithEvents UscitaTextBox As TextBox
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTannulla As ToolStripButton
    Friend WithEvents BTClientieLocazioniNascoste As Button
End Class
