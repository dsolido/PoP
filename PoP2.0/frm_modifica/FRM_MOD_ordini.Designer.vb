<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_MOD_ordini
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
        Dim AnagraficaLabel As System.Windows.Forms.Label
        Dim FornitoreLabel As System.Windows.Forms.Label
        Dim LB_note As System.Windows.Forms.Label
        Dim LB_Data As System.Windows.Forms.Label
        Dim LB_id As System.Windows.Forms.Label
        Dim FraseLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MOD_ordini))
        Me.DS_Ordini = New PoP2.Comuni.DS_Ordini()
        Me.BS_clienti = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_clienti = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_clienti()
        Me.TableAdapterManager = New PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager()
        Me.CB_clienti = New System.Windows.Forms.ComboBox()
        Me.BS_locazioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_destinatari = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_destinatari()
        Me.CB_locazioni = New System.Windows.Forms.ComboBox()
        Me.BN_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTAggiunge = New System.Windows.Forms.ToolStripButton()
        Me.TTBTannulla = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BS_utenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_utenti = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_utenti()
        Me.CB_utenti = New System.Windows.Forms.ComboBox()
        Me.BS_fornitori = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_fornitori = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_fornitori()
        Me.CB_fornitore = New System.Windows.Forms.ComboBox()
        Me.TX_note = New System.Windows.Forms.TextBox()
        Me.TX_data = New System.Windows.Forms.TextBox()
        Me.TX_id = New System.Windows.Forms.TextBox()
        Me.BS_frasi = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_frasi = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_frasi()
        Me.LB_Frase = New System.Windows.Forms.ListBox()
        SocietaLabel = New System.Windows.Forms.Label()
        LocazioneLabel = New System.Windows.Forms.Label()
        AnagraficaLabel = New System.Windows.Forms.Label()
        FornitoreLabel = New System.Windows.Forms.Label()
        LB_note = New System.Windows.Forms.Label()
        LB_Data = New System.Windows.Forms.Label()
        LB_id = New System.Windows.Forms.Label()
        FraseLabel = New System.Windows.Forms.Label()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_locazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BN_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BN_barra.SuspendLayout()
        CType(Me.BS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_fornitori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_frasi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SocietaLabel
        '
        SocietaLabel.AutoSize = True
        SocietaLabel.Location = New System.Drawing.Point(7, 65)
        SocietaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        SocietaLabel.Name = "SocietaLabel"
        SocietaLabel.Size = New System.Drawing.Size(63, 19)
        SocietaLabel.TabIndex = 2
        SocietaLabel.Text = "societa:"
        '
        'LocazioneLabel
        '
        LocazioneLabel.AutoSize = True
        LocazioneLabel.Location = New System.Drawing.Point(333, 64)
        LocazioneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LocazioneLabel.Name = "LocazioneLabel"
        LocazioneLabel.Size = New System.Drawing.Size(80, 19)
        LocazioneLabel.TabIndex = 4
        LocazioneLabel.Text = "locazione:"
        '
        'AnagraficaLabel
        '
        AnagraficaLabel.AutoSize = True
        AnagraficaLabel.Location = New System.Drawing.Point(7, 124)
        AnagraficaLabel.Name = "AnagraficaLabel"
        AnagraficaLabel.Size = New System.Drawing.Size(87, 19)
        AnagraficaLabel.TabIndex = 121
        AnagraficaLabel.Text = "anagrafica:"
        '
        'FornitoreLabel
        '
        FornitoreLabel.AutoSize = True
        FornitoreLabel.Location = New System.Drawing.Point(333, 123)
        FornitoreLabel.Name = "FornitoreLabel"
        FornitoreLabel.Size = New System.Drawing.Size(79, 19)
        FornitoreLabel.TabIndex = 122
        FornitoreLabel.Text = "Fornitore:"
        '
        'LB_note
        '
        LB_note.AutoSize = True
        LB_note.Location = New System.Drawing.Point(7, 199)
        LB_note.Name = "LB_note"
        LB_note.Size = New System.Drawing.Size(42, 19)
        LB_note.TabIndex = 124
        LB_note.Text = "Note"
        '
        'LB_Data
        '
        LB_Data.AutoSize = True
        LB_Data.Location = New System.Drawing.Point(333, 9)
        LB_Data.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LB_Data.Name = "LB_Data"
        LB_Data.Size = New System.Drawing.Size(47, 19)
        LB_Data.TabIndex = 128
        LB_Data.Text = "Data:"
        '
        'LB_id
        '
        LB_id.AutoSize = True
        LB_id.Location = New System.Drawing.Point(7, 10)
        LB_id.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        LB_id.Name = "LB_id"
        LB_id.Size = New System.Drawing.Size(32, 19)
        LB_id.TabIndex = 127
        LB_id.Text = "ID:"
        '
        'FraseLabel
        '
        FraseLabel.AutoSize = True
        FraseLabel.Location = New System.Drawing.Point(412, 199)
        FraseLabel.Name = "FraseLabel"
        FraseLabel.Size = New System.Drawing.Size(137, 19)
        FraseLabel.TabIndex = 128
        FraseLabel.Text = "Frase Automatica:"
        '
        'DS_Ordini
        '
        Me.DS_Ordini.DataSetName = "DS_Ordini"
        Me.DS_Ordini.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_clienti
        '
        Me.BS_clienti.DataMember = "DT_clienti"
        Me.BS_clienti.DataSource = Me.DS_Ordini
        '
        'TA_clienti
        '
        Me.TA_clienti.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_OrdiniTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CB_clienti
        '
        Me.CB_clienti.DataSource = Me.BS_clienti
        Me.CB_clienti.DisplayMember = "societa"
        Me.CB_clienti.FormattingEnabled = True
        Me.CB_clienti.Location = New System.Drawing.Point(7, 92)
        Me.CB_clienti.Name = "CB_clienti"
        Me.CB_clienti.Size = New System.Drawing.Size(300, 27)
        Me.CB_clienti.TabIndex = 3
        Me.CB_clienti.ValueMember = "id"
        '
        'BS_locazioni
        '
        Me.BS_locazioni.DataMember = "DT_destinatari"
        Me.BS_locazioni.DataSource = Me.DS_Ordini
        '
        'TA_destinatari
        '
        Me.TA_destinatari.ClearBeforeFill = True
        '
        'CB_locazioni
        '
        Me.CB_locazioni.DataSource = Me.BS_locazioni
        Me.CB_locazioni.DisplayMember = "locazione"
        Me.CB_locazioni.FormattingEnabled = True
        Me.CB_locazioni.Location = New System.Drawing.Point(333, 91)
        Me.CB_locazioni.Name = "CB_locazioni"
        Me.CB_locazioni.Size = New System.Drawing.Size(300, 27)
        Me.CB_locazioni.TabIndex = 4
        Me.CB_locazioni.ValueMember = "id"
        '
        'BN_barra
        '
        Me.BN_barra.AddNewItem = Nothing
        Me.BN_barra.AutoSize = False
        Me.BN_barra.CountItem = Nothing
        Me.BN_barra.DeleteItem = Nothing
        Me.BN_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BN_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.TTBTTermina, Me.TTBTAggiunge, Me.TTBTannulla, Me.ToolStripSeparator2})
        Me.BN_barra.Location = New System.Drawing.Point(0, 396)
        Me.BN_barra.MoveFirstItem = Nothing
        Me.BN_barra.MoveLastItem = Nothing
        Me.BN_barra.MoveNextItem = Nothing
        Me.BN_barra.MovePreviousItem = Nothing
        Me.BN_barra.Name = "BN_barra"
        Me.BN_barra.PositionItem = Nothing
        Me.BN_barra.Size = New System.Drawing.Size(649, 98)
        Me.BN_barra.TabIndex = 120
        Me.BN_barra.Text = "BarraNavigazione"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 98)
        '
        'TTBTTermina
        '
        Me.TTBTTermina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TTBTTermina.AutoSize = False
        Me.TTBTTermina.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTBTTermina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominoConferma48
        Me.TTBTTermina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTTermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTTermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTTermina.Name = "TTBTTermina"
        Me.TTBTTermina.Size = New System.Drawing.Size(100, 75)
        Me.TTBTTermina.Text = "Conferma"
        Me.TTBTTermina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTTermina.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'TTBTAggiunge
        '
        Me.TTBTAggiunge.AutoSize = False
        Me.TTBTAggiunge.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTBTAggiunge.Image = CType(resources.GetObject("TTBTAggiunge.Image"), System.Drawing.Image)
        Me.TTBTAggiunge.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTAggiunge.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTAggiunge.Name = "TTBTAggiunge"
        Me.TTBTAggiunge.RightToLeftAutoMirrorImage = True
        Me.TTBTAggiunge.Size = New System.Drawing.Size(100, 75)
        Me.TTBTAggiunge.Text = "Nuovo"
        Me.TTBTAggiunge.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTAggiunge.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'TTBTannulla
        '
        Me.TTBTannulla.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.TTBTannulla.AutoSize = False
        Me.TTBTannulla.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.TTBTannulla.Image = CType(resources.GetObject("TTBTannulla.Image"), System.Drawing.Image)
        Me.TTBTannulla.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTannulla.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTannulla.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTannulla.Name = "TTBTannulla"
        Me.TTBTannulla.Size = New System.Drawing.Size(100, 75)
        Me.TTBTannulla.Text = "Annulla"
        Me.TTBTannulla.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTannulla.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 98)
        '
        'BS_utenti
        '
        Me.BS_utenti.DataMember = "DT_utenti"
        Me.BS_utenti.DataSource = Me.DS_Ordini
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'CB_utenti
        '
        Me.CB_utenti.DataSource = Me.BS_utenti
        Me.CB_utenti.DisplayMember = "anagrafica"
        Me.CB_utenti.FormattingEnabled = True
        Me.CB_utenti.Location = New System.Drawing.Point(7, 151)
        Me.CB_utenti.Name = "CB_utenti"
        Me.CB_utenti.Size = New System.Drawing.Size(300, 27)
        Me.CB_utenti.TabIndex = 5
        Me.CB_utenti.ValueMember = "id"
        '
        'BS_fornitori
        '
        Me.BS_fornitori.DataMember = "DT_fornitori"
        Me.BS_fornitori.DataSource = Me.DS_Ordini
        '
        'TA_fornitori
        '
        Me.TA_fornitori.ClearBeforeFill = True
        '
        'CB_fornitore
        '
        Me.CB_fornitore.DataSource = Me.BS_fornitori
        Me.CB_fornitore.DisplayMember = "anagrafica"
        Me.CB_fornitore.FormattingEnabled = True
        Me.CB_fornitore.Location = New System.Drawing.Point(333, 150)
        Me.CB_fornitore.Name = "CB_fornitore"
        Me.CB_fornitore.Size = New System.Drawing.Size(300, 27)
        Me.CB_fornitore.TabIndex = 6
        Me.CB_fornitore.ValueMember = "id"
        '
        'TX_note
        '
        Me.TX_note.Location = New System.Drawing.Point(7, 224)
        Me.TX_note.Name = "TX_note"
        Me.TX_note.Size = New System.Drawing.Size(387, 27)
        Me.TX_note.TabIndex = 7
        '
        'TX_data
        '
        Me.TX_data.Location = New System.Drawing.Point(333, 35)
        Me.TX_data.Name = "TX_data"
        Me.TX_data.Size = New System.Drawing.Size(100, 27)
        Me.TX_data.TabIndex = 2
        '
        'TX_id
        '
        Me.TX_id.Location = New System.Drawing.Point(7, 36)
        Me.TX_id.Name = "TX_id"
        Me.TX_id.ReadOnly = True
        Me.TX_id.Size = New System.Drawing.Size(100, 27)
        Me.TX_id.TabIndex = 1
        '
        'BS_frasi
        '
        Me.BS_frasi.DataMember = "DT_frasi"
        Me.BS_frasi.DataSource = Me.DS_Ordini
        '
        'TA_frasi
        '
        Me.TA_frasi.ClearBeforeFill = True
        '
        'LB_Frase
        '
        Me.LB_Frase.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.BS_frasi, "frase", True))
        Me.LB_Frase.DataBindings.Add(New System.Windows.Forms.Binding("SelectedItem", Me.BS_frasi, "frase", True))
        Me.LB_Frase.FormattingEnabled = True
        Me.LB_Frase.ItemHeight = 19
        Me.LB_Frase.Location = New System.Drawing.Point(416, 221)
        Me.LB_Frase.Name = "LB_Frase"
        Me.LB_Frase.Size = New System.Drawing.Size(217, 156)
        Me.LB_Frase.TabIndex = 129
        '
        'FRM_MOD_ordini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(649, 494)
        Me.Controls.Add(FraseLabel)
        Me.Controls.Add(Me.LB_Frase)
        Me.Controls.Add(LB_Data)
        Me.Controls.Add(LB_id)
        Me.Controls.Add(Me.TX_id)
        Me.Controls.Add(Me.TX_data)
        Me.Controls.Add(LB_note)
        Me.Controls.Add(Me.TX_note)
        Me.Controls.Add(FornitoreLabel)
        Me.Controls.Add(Me.CB_fornitore)
        Me.Controls.Add(AnagraficaLabel)
        Me.Controls.Add(Me.CB_utenti)
        Me.Controls.Add(Me.BN_barra)
        Me.Controls.Add(Me.CB_locazioni)
        Me.Controls.Add(Me.CB_clienti)
        Me.Controls.Add(LocazioneLabel)
        Me.Controls.Add(SocietaLabel)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRM_MOD_ordini"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestione Ordini"
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_locazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BN_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BN_barra.ResumeLayout(False)
        Me.BN_barra.PerformLayout()
        CType(Me.BS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_fornitori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_frasi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS_Ordini As DS_Ordini
    Friend WithEvents BS_clienti As BindingSource
    Friend WithEvents TA_clienti As DS_OrdiniTableAdapters.TA_clienti
    Friend WithEvents TableAdapterManager As DS_OrdiniTableAdapters.TableAdapterManager
    Friend WithEvents CB_clienti As ComboBox
    Friend WithEvents BS_locazioni As BindingSource
    Friend WithEvents TA_destinatari As DS_OrdiniTableAdapters.TA_destinatari
    Friend WithEvents CB_locazioni As ComboBox
    Friend WithEvents BN_barra As BindingNavigator
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTannulla As ToolStripButton
    Friend WithEvents BS_utenti As BindingSource
    Friend WithEvents TA_utenti As DS_OrdiniTableAdapters.TA_utenti
    Friend WithEvents CB_utenti As ComboBox
    Friend WithEvents BS_fornitori As BindingSource
    Friend WithEvents TA_fornitori As DS_OrdiniTableAdapters.TA_fornitori
    Friend WithEvents CB_fornitore As ComboBox
    Friend WithEvents TX_note As TextBox
    Friend WithEvents TX_data As TextBox
    Friend WithEvents TX_id As TextBox
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents BS_frasi As BindingSource
    Friend WithEvents TA_frasi As DS_OrdiniTableAdapters.TA_frasi
    Friend WithEvents LB_Frase As ListBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
