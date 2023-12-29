<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMmod_macchinari
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
        Dim IdmarcaLabel As System.Windows.Forms.Label
        Dim DtacquistoLabel As System.Windows.Forms.Label
        Dim PrezzoLabel As System.Windows.Forms.Label
        Dim NuLabel As System.Windows.Forms.Label
        Dim RevisioneLabel As System.Windows.Forms.Label
        Dim BatterieLabel As System.Windows.Forms.Label
        Dim NoteLabel As System.Windows.Forms.Label
        Dim AnagraficaLabel As System.Windows.Forms.Label
        Dim FotoLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMmod_macchinari))
        Me.DSmacchinari = New PoP2.Comuni.DSmacchinari()
        Me.BSmacchine = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAmacchine = New PoP2.Comuni.DSmacchinariTableAdapters.TAmacchine()
        Me.TableAdapterManager = New PoP2.Comuni.DSmacchinariTableAdapters.TableAdapterManager()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.DescrizioneTextBox = New System.Windows.Forms.TextBox()
        Me.DtacquistoDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.PrezzoTextBox = New System.Windows.Forms.TextBox()
        Me.NuTextBox = New System.Windows.Forms.TextBox()
        Me.RevisioneDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.BatterieDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NoteTextBox = New System.Windows.Forms.TextBox()
        Me.FotoPictureBox = New System.Windows.Forms.PictureBox()
        Me.BSfornitori = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_prodotti = New PoP2.Comuni.DS_prodotti()
        Me.TA_fornitori = New PoP2.Comuni.DS_prodottiTableAdapters.TA_fornitori()
        Me.BSmarche = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_prodottimarche = New PoP2.Comuni.DS_prodottiTableAdapters.TA_prodottimarche()
        Me.TableAdapterManager1 = New PoP2.Comuni.DS_prodottiTableAdapters.TableAdapterManager()
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        IdLabel = New System.Windows.Forms.Label()
        DescrizioneLabel = New System.Windows.Forms.Label()
        IdmarcaLabel = New System.Windows.Forms.Label()
        DtacquistoLabel = New System.Windows.Forms.Label()
        PrezzoLabel = New System.Windows.Forms.Label()
        NuLabel = New System.Windows.Forms.Label()
        RevisioneLabel = New System.Windows.Forms.Label()
        BatterieLabel = New System.Windows.Forms.Label()
        NoteLabel = New System.Windows.Forms.Label()
        AnagraficaLabel = New System.Windows.Forms.Label()
        FotoLabel = New System.Windows.Forms.Label()
        CType(Me.DSmacchinari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSmacchine, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSfornitori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_prodotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSmarche, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(52, 44)
        IdLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(25, 20)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'DescrizioneLabel
        '
        DescrizioneLabel.AutoSize = True
        DescrizioneLabel.Location = New System.Drawing.Point(52, 80)
        DescrizioneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DescrizioneLabel.Name = "DescrizioneLabel"
        DescrizioneLabel.Size = New System.Drawing.Size(93, 20)
        DescrizioneLabel.TabIndex = 3
        DescrizioneLabel.Text = "descrizione:"
        '
        'IdmarcaLabel
        '
        IdmarcaLabel.AutoSize = True
        IdmarcaLabel.Location = New System.Drawing.Point(56, 156)
        IdmarcaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        IdmarcaLabel.Name = "IdmarcaLabel"
        IdmarcaLabel.Size = New System.Drawing.Size(53, 20)
        IdmarcaLabel.TabIndex = 7
        IdmarcaLabel.Text = "Marca"
        '
        'DtacquistoLabel
        '
        DtacquistoLabel.AutoSize = True
        DtacquistoLabel.Location = New System.Drawing.Point(52, 204)
        DtacquistoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        DtacquistoLabel.Name = "DtacquistoLabel"
        DtacquistoLabel.Size = New System.Drawing.Size(87, 20)
        DtacquistoLabel.TabIndex = 9
        DtacquistoLabel.Text = "dtacquisto:"
        '
        'PrezzoLabel
        '
        PrezzoLabel.AutoSize = True
        PrezzoLabel.Location = New System.Drawing.Point(52, 242)
        PrezzoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        PrezzoLabel.Name = "PrezzoLabel"
        PrezzoLabel.Size = New System.Drawing.Size(61, 20)
        PrezzoLabel.TabIndex = 11
        PrezzoLabel.Text = "prezzo:"
        '
        'NuLabel
        '
        NuLabel.AutoSize = True
        NuLabel.Location = New System.Drawing.Point(52, 282)
        NuLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NuLabel.Name = "NuLabel"
        NuLabel.Size = New System.Drawing.Size(31, 20)
        NuLabel.TabIndex = 13
        NuLabel.Text = "nu:"
        '
        'RevisioneLabel
        '
        RevisioneLabel.AutoSize = True
        RevisioneLabel.Location = New System.Drawing.Point(52, 324)
        RevisioneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        RevisioneLabel.Name = "RevisioneLabel"
        RevisioneLabel.Size = New System.Drawing.Size(75, 20)
        RevisioneLabel.TabIndex = 15
        RevisioneLabel.Text = "revisione:"
        '
        'BatterieLabel
        '
        BatterieLabel.AutoSize = True
        BatterieLabel.Location = New System.Drawing.Point(52, 364)
        BatterieLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        BatterieLabel.Name = "BatterieLabel"
        BatterieLabel.Size = New System.Drawing.Size(67, 20)
        BatterieLabel.TabIndex = 17
        BatterieLabel.Text = "batterie:"
        '
        'NoteLabel
        '
        NoteLabel.AutoSize = True
        NoteLabel.Location = New System.Drawing.Point(52, 402)
        NoteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NoteLabel.Name = "NoteLabel"
        NoteLabel.Size = New System.Drawing.Size(45, 20)
        NoteLabel.TabIndex = 19
        NoteLabel.Text = "note:"
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(52, 116)
        AnagraficaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(73, 20)
        AnagraficaLabel.TabIndex = 21
        AnagraficaLabel.Text = "Fornitore"
        '
        'FotoLabel
        '
        FotoLabel.AutoSize = True
        FotoLabel.Location = New System.Drawing.Point(456, 198)
        FotoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        FotoLabel.Name = "FotoLabel"
        FotoLabel.Size = New System.Drawing.Size(41, 20)
        FotoLabel.TabIndex = 25
        FotoLabel.Text = "foto:"
        '
        'DSmacchinari
        '
        Me.DSmacchinari.DataSetName = "DSmacchinari"
        Me.DSmacchinari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BSmacchine
        '
        Me.BSmacchine.DataMember = "DTmacchine"
        Me.BSmacchine.DataSource = Me.DSmacchinari
        '
        'TAmacchine
        '
        Me.TAmacchine.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DSmacchinariTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSmacchine, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(155, 40)
        Me.IdTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(110, 26)
        Me.IdTextBox.TabIndex = 2
        '
        'DescrizioneTextBox
        '
        Me.DescrizioneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSmacchine, "descrizione", True))
        Me.DescrizioneTextBox.Location = New System.Drawing.Point(155, 76)
        Me.DescrizioneTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DescrizioneTextBox.Name = "DescrizioneTextBox"
        Me.DescrizioneTextBox.Size = New System.Drawing.Size(556, 26)
        Me.DescrizioneTextBox.TabIndex = 4
        '
        'DtacquistoDateTimePicker
        '
        Me.DtacquistoDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BSmacchine, "dtacquisto", True))
        Me.DtacquistoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtacquistoDateTimePicker.Location = New System.Drawing.Point(155, 198)
        Me.DtacquistoDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DtacquistoDateTimePicker.Name = "DtacquistoDateTimePicker"
        Me.DtacquistoDateTimePicker.Size = New System.Drawing.Size(125, 26)
        Me.DtacquistoDateTimePicker.TabIndex = 10
        '
        'PrezzoTextBox
        '
        Me.PrezzoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSmacchine, "prezzo", True))
        Me.PrezzoTextBox.Location = New System.Drawing.Point(155, 238)
        Me.PrezzoTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PrezzoTextBox.Name = "PrezzoTextBox"
        Me.PrezzoTextBox.Size = New System.Drawing.Size(298, 26)
        Me.PrezzoTextBox.TabIndex = 12
        '
        'NuTextBox
        '
        Me.NuTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSmacchine, "nu", True))
        Me.NuTextBox.Location = New System.Drawing.Point(155, 278)
        Me.NuTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NuTextBox.Name = "NuTextBox"
        Me.NuTextBox.Size = New System.Drawing.Size(298, 26)
        Me.NuTextBox.TabIndex = 14
        '
        'RevisioneDateTimePicker
        '
        Me.RevisioneDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BSmacchine, "revisione", True))
        Me.RevisioneDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.RevisioneDateTimePicker.Location = New System.Drawing.Point(155, 318)
        Me.RevisioneDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.RevisioneDateTimePicker.Name = "RevisioneDateTimePicker"
        Me.RevisioneDateTimePicker.Size = New System.Drawing.Size(125, 26)
        Me.RevisioneDateTimePicker.TabIndex = 16
        '
        'BatterieDateTimePicker
        '
        Me.BatterieDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BSmacchine, "batterie", True))
        Me.BatterieDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.BatterieDateTimePicker.Location = New System.Drawing.Point(155, 358)
        Me.BatterieDateTimePicker.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BatterieDateTimePicker.Name = "BatterieDateTimePicker"
        Me.BatterieDateTimePicker.Size = New System.Drawing.Size(125, 26)
        Me.BatterieDateTimePicker.TabIndex = 18
        '
        'NoteTextBox
        '
        Me.NoteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BSmacchine, "note", True))
        Me.NoteTextBox.Location = New System.Drawing.Point(155, 398)
        Me.NoteTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NoteTextBox.Name = "NoteTextBox"
        Me.NoteTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.NoteTextBox.Size = New System.Drawing.Size(556, 26)
        Me.NoteTextBox.TabIndex = 20
        '
        'FotoPictureBox
        '
        Me.FotoPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.BSmacchine, "foto", True))
        Me.FotoPictureBox.Location = New System.Drawing.Point(505, 198)
        Me.FotoPictureBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FotoPictureBox.Name = "FotoPictureBox"
        Me.FotoPictureBox.Size = New System.Drawing.Size(200, 174)
        Me.FotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FotoPictureBox.TabIndex = 26
        Me.FotoPictureBox.TabStop = False
        '
        'BSfornitori
        '
        Me.BSfornitori.DataMember = "DT_fornitori"
        Me.BSfornitori.DataSource = Me.DS_prodotti
        '
        'DS_prodotti
        '
        Me.DS_prodotti.DataSetName = "DS_prodotti"
        Me.DS_prodotti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_fornitori
        '
        Me.TA_fornitori.ClearBeforeFill = True
        '
        'BSmarche
        '
        Me.BSmarche.DataMember = "DT_prodottimarche"
        Me.BSmarche.DataSource = Me.DS_prodotti
        '
        'TA_prodottimarche
        '
        Me.TA_prodottimarche.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PoP2.Comuni.DS_prodottiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        Me.DM_barra.Location = New System.Drawing.Point(0, 505)
        Me.DM_barra.MoveFirstItem = Nothing
        Me.DM_barra.MoveLastItem = Nothing
        Me.DM_barra.MoveNextItem = Nothing
        Me.DM_barra.MovePreviousItem = Nothing
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.PositionItem = Nothing
        Me.DM_barra.Size = New System.Drawing.Size(743, 79)
        Me.DM_barra.TabIndex = 191
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
        'FRMmod_macchinari
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(743, 584)
        Me.Controls.Add(Me.DM_barra)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(DescrizioneLabel)
        Me.Controls.Add(Me.DescrizioneTextBox)
        Me.Controls.Add(IdmarcaLabel)
        Me.Controls.Add(DtacquistoLabel)
        Me.Controls.Add(Me.DtacquistoDateTimePicker)
        Me.Controls.Add(PrezzoLabel)
        Me.Controls.Add(Me.PrezzoTextBox)
        Me.Controls.Add(NuLabel)
        Me.Controls.Add(Me.NuTextBox)
        Me.Controls.Add(RevisioneLabel)
        Me.Controls.Add(Me.RevisioneDateTimePicker)
        Me.Controls.Add(BatterieLabel)
        Me.Controls.Add(Me.BatterieDateTimePicker)
        Me.Controls.Add(NoteLabel)
        Me.Controls.Add(Me.NoteTextBox)
        Me.Controls.Add(AnagraficaLabel)
        Me.Controls.Add(FotoLabel)
        Me.Controls.Add(Me.FotoPictureBox)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRMmod_macchinari"
        Me.Text = "FRMmod_macchinari"
        CType(Me.DSmacchinari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSmacchine, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FotoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSfornitori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_prodotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSmarche, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSmacchinari As DSmacchinari
    Friend WithEvents BSmacchine As BindingSource
    Friend WithEvents TAmacchine As DSmacchinariTableAdapters.TAmacchine
    Friend WithEvents TableAdapterManager As DSmacchinariTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DescrizioneTextBox As TextBox
    Friend WithEvents DtacquistoDateTimePicker As DateTimePicker
    Friend WithEvents PrezzoTextBox As TextBox
    Friend WithEvents NuTextBox As TextBox
    Friend WithEvents RevisioneDateTimePicker As DateTimePicker
    Friend WithEvents BatterieDateTimePicker As DateTimePicker
    Friend WithEvents NoteTextBox As TextBox
    Friend WithEvents FotoPictureBox As PictureBox
    Friend WithEvents DS_prodotti As DS_prodotti
    Friend WithEvents BSfornitori As BindingSource
    Friend WithEvents TA_fornitori As DS_prodottiTableAdapters.TA_fornitori
    Friend WithEvents BSmarche As BindingSource
    Friend WithEvents TA_prodottimarche As DS_prodottiTableAdapters.TA_prodottimarche
    Friend WithEvents TableAdapterManager1 As DS_prodottiTableAdapters.TableAdapterManager
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTannulla As ToolStripButton
End Class
