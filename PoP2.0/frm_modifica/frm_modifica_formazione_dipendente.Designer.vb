<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_modifica_formazione_dipendente
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
        Dim Dt_forLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_modifica_formazione_dipendente))
        Me.DS_personale = New PoP2.Comuni.DS_personale()
        Me.DT_utenti_forBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_utenti_for_TA = New PoP2.Comuni.DS_personaleTableAdapters.DT_utenti_for_TA()
        Me.TableAdapterManager = New PoP2.Comuni.DS_personaleTableAdapters.TableAdapterManager()
        Me.Dt_forDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.DT_tipo_formBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_tipo_form_TA = New PoP2.Comuni.DS_personaleTableAdapters.DT_tipo_form_TA()
        Me.DescrizioneListBox = New System.Windows.Forms.ListBox()
        Me.cmd_elimina = New System.Windows.Forms.Button()
        Me.cmd_salva = New System.Windows.Forms.Button()
        Me.cmd_termina = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Dt_forLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_utenti_forBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_tipo_formBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dt_forLabel
        '
        Dt_forLabel.AutoSize = True
        Dt_forLabel.Location = New System.Drawing.Point(15, 12)
        Dt_forLabel.Name = "Dt_forLabel"
        Dt_forLabel.Size = New System.Drawing.Size(116, 13)
        Dt_forLabel.TabIndex = 0
        Dt_forLabel.Text = "Data inizio Formazione:"
        '
        'NoteLabel
        '
        NoteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(15, 202)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(111, 13)
        NoteLabel.TabIndex = 2
        NoteLabel.Text = "Eventuali annotazioni "
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(15, 51)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(132, 13)
        DescrizioneLabel.TabIndex = 6
        DescrizioneLabel.Text = "Tipo di formazione erogata"
        '
        'DS_personale
        '
        Me.DS_personale.DataSetName = "DS_personale"
        Me.DS_personale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_utenti_forBindingSource
        '
        Me.DT_utenti_forBindingSource.DataMember = "DT_utenti_for"
        Me.DT_utenti_forBindingSource.DataSource = Me.DS_personale
        '
        'DT_utenti_for_TA
        '
        Me.DT_utenti_for_TA.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_personaleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Dt_forDateTimePicker
        '
        Me.Dt_forDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DT_utenti_forBindingSource, "dt_for", True))
        Me.Dt_forDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_utenti_forBindingSource, "dt_for", True))
        Me.Dt_forDateTimePicker.Location = New System.Drawing.Point(15, 28)
        Me.Dt_forDateTimePicker.Name = "Dt_forDateTimePicker"
        Me.Dt_forDateTimePicker.Size = New System.Drawing.Size(178, 20)
        Me.Dt_forDateTimePicker.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.Dt_forDateTimePicker, "Quando é stata erogata la formazione")
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DT_utenti_forBindingSource, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(15, 219)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(201, 20)
        Me.NoteTextBox.TabIndex = 3
        '
        'DT_tipo_formBindingSource
        '
        Me.DT_tipo_formBindingSource.DataMember = "DT_tipo_form"
        Me.DT_tipo_formBindingSource.DataSource = Me.DS_personale
        '
        'DT_tipo_form_TA
        '
        Me.DT_tipo_form_TA.ClearBeforeFill = True
        '
        'DescrizioneListBox
        '
        Me.DescrizioneListBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DescrizioneListBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DT_utenti_forBindingSource, "id_for", True))
        Me.DescrizioneListBox.DataSource = Me.DT_tipo_formBindingSource
        Me.DescrizioneListBox.DisplayMember = "Descrizione"
        Me.DescrizioneListBox.FormattingEnabled = True
        Me.DescrizioneListBox.Location = New System.Drawing.Point(15, 67)
        Me.DescrizioneListBox.Name = "DescrizioneListBox"
        Me.DescrizioneListBox.Size = New System.Drawing.Size(201, 134)
        Me.DescrizioneListBox.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.DescrizioneListBox, "Seleziona il tipo di formazione da assegnare al dipendente, ricordati di salvare " &
        "la selezione")
        Me.DescrizioneListBox.ValueMember = "id"
        '
        'cmd_elimina
        '
        Me.cmd_elimina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_elimina.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_elimina.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.omino_cestino48
        Me.cmd_elimina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_elimina.FlatAppearance.BorderSize = 0
        Me.cmd_elimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_elimina.Location = New System.Drawing.Point(63, 251)
        Me.cmd_elimina.Name = "cmd_elimina"
        Me.cmd_elimina.Size = New System.Drawing.Size(40, 40)
        Me.cmd_elimina.TabIndex = 53
        Me.cmd_elimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.cmd_elimina, "Elimina la formazione del dipendente")
        Me.cmd_elimina.UseVisualStyleBackColor = False
        '
        'cmd_salva
        '
        Me.cmd_salva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_salva.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_salva.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.ominoConferma48
        Me.cmd_salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_salva.FlatAppearance.BorderSize = 0
        Me.cmd_salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salva.Location = New System.Drawing.Point(17, 251)
        Me.cmd_salva.Name = "cmd_salva"
        Me.cmd_salva.Size = New System.Drawing.Size(40, 40)
        Me.cmd_salva.TabIndex = 51
        Me.cmd_salva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ToolTip1.SetToolTip(Me.cmd_salva, "Salva per memorizzare la formazione per il dipendente")
        Me.cmd_salva.UseVisualStyleBackColor = False
        '
        'cmd_termina
        '
        Me.cmd_termina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_termina.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.cmd_termina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_termina.FlatAppearance.BorderSize = 0
        Me.cmd_termina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_termina.Location = New System.Drawing.Point(176, 250)
        Me.cmd_termina.Name = "cmd_termina"
        Me.cmd_termina.Size = New System.Drawing.Size(40, 40)
        Me.cmd_termina.TabIndex = 50
        Me.ToolTip1.SetToolTip(Me.cmd_termina, "Termina la modifica")
        Me.cmd_termina.UseVisualStyleBackColor = True
        '
        'frm_modifica_formazione_dipendente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 302)
        Me.Controls.Add(Me.cmd_elimina)
        Me.Controls.Add(Me.cmd_salva)
        Me.Controls.Add(Me.cmd_termina)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneListBox)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(Dt_forLabel)
        Me.Controls.Add(Me.Dt_forDateTimePicker)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_modifica_formazione_dipendente"
        Me.Text = "Gestione Formazione"
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_utenti_forBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_tipo_formBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DS_personale As DS_personale
    Friend WithEvents DT_utenti_forBindingSource As BindingSource
    Friend WithEvents DT_utenti_for_TA As DS_personaleTableAdapters.DT_utenti_for_TA
    Friend WithEvents TableAdapterManager As DS_personaleTableAdapters.TableAdapterManager
    Friend WithEvents Dt_forDateTimePicker As DateTimePicker
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents DT_tipo_formBindingSource As BindingSource
    Friend WithEvents DT_tipo_form_TA As DS_personaleTableAdapters.DT_tipo_form_TA
    Friend WithEvents DescrizioneListBox As ListBox
    Friend WithEvents cmd_elimina As Button
    Friend WithEvents cmd_salva As Button
    Friend WithEvents cmd_termina As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
