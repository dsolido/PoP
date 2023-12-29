<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_Formazione
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
        Dim Dt_forLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim DescrizioneLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Formazione))
        Me.Dt_forDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BS_utentiformazione = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTAggiunge = New System.Windows.Forms.ToolStripButton()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CB_descrizione = New System.Windows.Forms.ComboBox()
        Me.BS_formazione = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_utentiformazione = New PoP2.Comuni.DS_utentiTableAdapters.TA_utentiformazione()
        Me.TA_formazione = New PoP2.Comuni.DS_utentiTableAdapters.TA_formazione()
        Dt_forLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        CType(Me.BS_utentiformazione, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        CType(Me.BS_formazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Dt_forLabel
        '
        Dt_forLabel.AutoSize = True
        Dt_forLabel.Location = New System.Drawing.Point(30, 78)
        Dt_forLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Dt_forLabel.Name = "Dt_forLabel"
        Dt_forLabel.Size = New System.Drawing.Size(136, 20)
        Dt_forLabel.TabIndex = 7
        Dt_forLabel.Text = "Data Formazione:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(30, 106)
        NoteLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(47, 20)
        NoteLabel.TabIndex = 9
        NoteLabel.Text = "Note:"
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(31, 42)
        DescrizioneLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(131, 20)
        DescrizioneLabel.TabIndex = 147
        DescrizioneLabel.Text = "Tipo Formazione:"
        '
        'Dt_forDateTimePicker
        '
        Me.Dt_forDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BS_utentiformazione, "dt_for", True))
        Me.Dt_forDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_utentiformazione, "dt_for", True))
        Me.Dt_forDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dt_forDateTimePicker.Location = New System.Drawing.Point(176, 74)
        Me.Dt_forDateTimePicker.Margin = New System.Windows.Forms.Padding(2)
        Me.Dt_forDateTimePicker.Name = "Dt_forDateTimePicker"
        Me.Dt_forDateTimePicker.Size = New System.Drawing.Size(111, 26)
        Me.Dt_forDateTimePicker.TabIndex = 8
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NoteTextBox
        '
        Me.NoteTextBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BS_utentiformazione, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(176, 106)
        Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.Size = New System.Drawing.Size(336, 26)
        Me.NoteTextBox.TabIndex = 10
        '
        'DM_barra
        '
        Me.DM_barra.AddNewItem = Nothing
        Me.DM_barra.AutoSize = False
        Me.DM_barra.BindingSource = Me.BS_utentiformazione
        Me.DM_barra.CountItem = Me.BindingNavigatorCountItem
        Me.DM_barra.DeleteItem = Me.TTBTElimina
        Me.DM_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DM_barra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DM_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTTestoRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTAggiunge, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator3})
        Me.DM_barra.Location = New System.Drawing.Point(0, 162)
        Me.DM_barra.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DM_barra.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DM_barra.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DM_barra.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.PositionItem = Me.BindingNavigatorPositionItem
        Me.DM_barra.Size = New System.Drawing.Size(704, 70)
        Me.DM_barra.TabIndex = 147
        Me.DM_barra.Text = "BarraNavigazione"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 67)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
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
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.BackColor = System.Drawing.SystemColors.Info
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(100, 70)
        Me.TTTestoRicerca.ToolTipText = "Immettere l'anno di lavoro"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.AutoSize = False
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(50, 40)
        Me.BindingNavigatorMoveFirstItem.Text = "Inizio"
        Me.BindingNavigatorMoveFirstItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.AutoSize = False
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(50, 40)
        Me.BindingNavigatorMovePreviousItem.Text = "Indietro"
        Me.BindingNavigatorMovePreviousItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 70)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 33)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 70)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.AutoSize = False
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(50, 40)
        Me.BindingNavigatorMoveNextItem.Text = "Avanti"
        Me.BindingNavigatorMoveNextItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.AutoSize = False
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(50, 40)
        Me.BindingNavigatorMoveLastItem.Text = "Fine"
        Me.BindingNavigatorMoveLastItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 70)
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
        'TTBTStampa
        '
        Me.TTBTStampa.AutoSize = False
        Me.TTBTStampa.Image = CType(resources.GetObject("TTBTStampa.Image"), System.Drawing.Image)
        Me.TTBTStampa.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTStampa.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTStampa.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTStampa.Name = "TTBTStampa"
        Me.TTBTStampa.Size = New System.Drawing.Size(50, 70)
        Me.TTBTStampa.Text = "Stampa"
        Me.TTBTStampa.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTStampa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 70)
        '
        'CB_descrizione
        '
        Me.CB_descrizione.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CB_descrizione.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_utentiformazione, "id_for", True))
        Me.CB_descrizione.DataSource = Me.BS_formazione
        Me.CB_descrizione.DisplayMember = "Descrizione"
        Me.CB_descrizione.FormattingEnabled = True
        Me.CB_descrizione.Location = New System.Drawing.Point(176, 42)
        Me.CB_descrizione.Margin = New System.Windows.Forms.Padding(2)
        Me.CB_descrizione.Name = "CB_descrizione"
        Me.CB_descrizione.Size = New System.Drawing.Size(336, 28)
        Me.CB_descrizione.TabIndex = 148
        Me.CB_descrizione.ValueMember = "id"
        '
        'BS_formazione
        '
        Me.BS_formazione.DataMember = "DT_formazione"
        Me.BS_formazione.DataSource = Me.DS_utenti
        '
        'TA_utentiformazione
        '
        Me.TA_utentiformazione.ClearBeforeFill = True
        '
        'TA_formazione
        '
        Me.TA_formazione.ClearBeforeFill = True
        '
        'FRM_Formazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 232)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.CB_descrizione)
        Me.Controls.Add(Me.DM_barra)
        Me.Controls.Add(Dt_forLabel)
        Me.Controls.Add(Me.Dt_forDateTimePicker)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FRM_Formazione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Formazione specifica del dipendente"
        CType(Me.BS_utentiformazione, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        CType(Me.BS_formazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dt_forDateTimePicker As DateTimePicker
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents TTTestoRicerca As ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CB_descrizione As ComboBox
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents BS_utentiformazione As BindingSource
    Friend WithEvents TA_utentiformazione As DS_utentiTableAdapters.TA_utentiformazione
    Friend WithEvents BS_formazione As BindingSource
    Friend WithEvents TA_formazione As DS_utentiTableAdapters.TA_formazione
End Class
