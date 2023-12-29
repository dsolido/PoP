<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMgestSos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMgestSos))
        Me.DSfestivita = New PoP2.Comuni.DSfestivita()
        Me.BSutentisost = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAutentisostituzioni = New PoP2.Comuni.DSfestivitaTableAdapters.TAutentisostituzioni()
        Me.TableAdapterManager = New PoP2.Comuni.DSfestivitaTableAdapters.TableAdapterManager()
        Me.DM_barra = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTElimina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTAggiunge = New System.Windows.Forms.ToolStripButton()
        Me.TTBTModifica = New System.Windows.Forms.ToolStripButton()
        Me.TTBTSalva = New System.Windows.Forms.ToolStripButton()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BSutenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LVimpegni = New System.Windows.Forms.ListView()
        Me.txDipendente = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TA_utenti = New PoP2.Comuni.DS_utentiTableAdapters.TA_utenti()
        Me.TableAdapterManager1 = New PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager()
        Me.cmbSostituto = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DSfestivita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BSutentisost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DM_barra.SuspendLayout()
        CType(Me.BSutenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DSfestivita
        '
        Me.DSfestivita.DataSetName = "DSfestivita"
        Me.DSfestivita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BSutentisost
        '
        Me.BSutentisost.DataMember = "DTutentisostituzioni"
        Me.BSutentisost.DataSource = Me.DSfestivita
        '
        'TAutentisostituzioni
        '
        Me.TAutentisostituzioni.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DSfestivitaTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DM_barra
        '
        Me.DM_barra.AddNewItem = Nothing
        Me.DM_barra.AutoSize = False
        Me.DM_barra.BindingSource = Me.BSutentisost
        Me.DM_barra.CountItem = Me.ToolStripLabel1
        Me.DM_barra.DeleteItem = Nothing
        Me.DM_barra.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DM_barra.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.DM_barra.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.TTBTAggiunge, Me.TTBTModifica, Me.TTBTElimina, Me.TTBTSalva, Me.TTBTTermina, Me.ToolStripSeparator4})
        Me.DM_barra.Location = New System.Drawing.Point(0, 515)
        Me.DM_barra.MoveFirstItem = Me.ToolStripButton1
        Me.DM_barra.MoveLastItem = Me.ToolStripButton4
        Me.DM_barra.MoveNextItem = Me.ToolStripButton3
        Me.DM_barra.MovePreviousItem = Me.ToolStripButton2
        Me.DM_barra.Name = "DM_barra"
        Me.DM_barra.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.DM_barra.PositionItem = Me.ToolStripTextBox1
        Me.DM_barra.Size = New System.Drawing.Size(1134, 72)
        Me.DM_barra.TabIndex = 12
        Me.DM_barra.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(55, 69)
        Me.ToolStripLabel1.Text = "di {0}"
        Me.ToolStripLabel1.ToolTipText = "Numero totale di elementi"
        '
        'TTBTElimina
        '
        Me.TTBTElimina.AutoSize = False
        Me.TTBTElimina.Image = CType(resources.GetObject("TTBTElimina.Image"), System.Drawing.Image)
        Me.TTBTElimina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTElimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTElimina.Name = "TTBTElimina"
        Me.TTBTElimina.RightToLeftAutoMirrorImage = True
        Me.TTBTElimina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTElimina.Text = "Elimina"
        Me.TTBTElimina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTElimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.AutoSize = False
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton1.Text = "Inizio"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton2.Text = "Indietro"
        Me.ToolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 72)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Posizione"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(53, 33)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Posizione corrente"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 72)
        Me.ToolStripSeparator2.Visible = False
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.AutoSize = False
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton3.Text = "Avanti"
        Me.ToolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.AutoSize = False
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(40, 40)
        Me.ToolStripButton4.Text = "Fine"
        Me.ToolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 72)
        Me.ToolStripSeparator3.Visible = False
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
        'TTBTModifica
        '
        Me.TTBTModifica.AutoSize = False
        Me.TTBTModifica.Image = CType(resources.GetObject("TTBTModifica.Image"), System.Drawing.Image)
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
        Me.TTBTTermina.Image = CType(resources.GetObject("TTBTTermina.Image"), System.Drawing.Image)
        Me.TTBTTermina.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTTermina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTTermina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTTermina.Name = "TTBTTermina"
        Me.TTBTTermina.Size = New System.Drawing.Size(50, 70)
        Me.TTBTTermina.Text = "Termina"
        Me.TTBTTermina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTTermina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 72)
        Me.ToolStripSeparator4.Visible = False
        '
        'BSutenti
        '
        Me.BSutenti.DataMember = "DT_utenti"
        Me.BSutenti.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.LVimpegni)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(604, 262)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(523, 232)
        Me.GroupBox1.TabIndex = 202
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Impegno già Programmati"
        '
        'LVimpegni
        '
        Me.LVimpegni.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVimpegni.HideSelection = False
        Me.LVimpegni.Location = New System.Drawing.Point(3, 16)
        Me.LVimpegni.Name = "LVimpegni"
        Me.LVimpegni.Size = New System.Drawing.Size(517, 213)
        Me.LVimpegni.TabIndex = 202
        Me.LVimpegni.UseCompatibleStateImageBehavior = False
        '
        'txDipendente
        '
        Me.txDipendente.Location = New System.Drawing.Point(24, 35)
        Me.txDipendente.Name = "txDipendente"
        Me.txDipendente.Size = New System.Drawing.Size(337, 26)
        Me.txDipendente.TabIndex = 203
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 205
        Me.Label4.Text = "Turni di lavoro"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 5)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(182, 20)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Dipendente da sostituire"
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = PoP2.Comuni.DS_utentiTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'cmbSostituto
        '
        Me.cmbSostituto.DataSource = Me.BSutenti
        Me.cmbSostituto.DisplayMember = "Anagrafica"
        Me.cmbSostituto.FormattingEnabled = True
        Me.cmbSostituto.Location = New System.Drawing.Point(24, 287)
        Me.cmbSostituto.Name = "cmbSostituto"
        Me.cmbSostituto.Size = New System.Drawing.Size(483, 28)
        Me.cmbSostituto.TabIndex = 207
        Me.cmbSostituto.ValueMember = "id"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(24, 351)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(182, 26)
        Me.DateTimePicker1.TabIndex = 208
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(319, 351)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(188, 26)
        Me.DateTimePicker2.TabIndex = 209
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 210
        Me.Label1.Text = "Dalla Data"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(315, 328)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 211
        Me.Label2.Text = "Alla Data"
        '
        'FRMgestSos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 587)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.cmbSostituto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txDipendente)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DM_barra)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FRMgestSos"
        Me.Text = "Sostituzioni"
        CType(Me.DSfestivita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BSutentisost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DM_barra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DM_barra.ResumeLayout(False)
        Me.DM_barra.PerformLayout()
        CType(Me.BSutenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DSfestivita As DSfestivita
    Friend WithEvents BSutentisost As BindingSource
    Friend WithEvents TAutentisostituzioni As DSfestivitaTableAdapters.TAutentisostituzioni
    Friend WithEvents TableAdapterManager As DSfestivitaTableAdapters.TableAdapterManager
    Friend WithEvents DM_barra As BindingNavigator
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents TTBTElimina As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents TTBTAggiunge As ToolStripButton
    Friend WithEvents TTBTModifica As ToolStripButton
    Friend WithEvents TTBTSalva As ToolStripButton
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BSutenti As BindingSource
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LVimpegni As ListView
    Friend WithEvents txDipendente As TextBox

    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TA_utenti As DS_utentiTableAdapters.TA_utenti
    Friend WithEvents TableAdapterManager1 As DS_utentiTableAdapters.TableAdapterManager
    Friend WithEvents cmbSostituto As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
