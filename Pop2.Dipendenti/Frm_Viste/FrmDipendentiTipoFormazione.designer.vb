<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDipendentiTipoFormazione
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDipendentiTipoFormazione))
        Me.TXT_ricerca = New System.Windows.Forms.TextBox()
        Me.cmd_termina = New System.Windows.Forms.Button()
        Me.cmd_annulla = New System.Windows.Forms.Button()
        Me.cmd_elimina = New System.Windows.Forms.Button()
        Me.cmd_aggiunge = New System.Windows.Forms.Button()
        Me.cmd_salva = New System.Windows.Forms.Button()
        Me.DT_Cap_Gridview = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DT_tipo_formBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_personale = New PoP2.Comuni.DS_personale()
        Me.DT_tipo_form_TA = New PoP2.Comuni.DS_personaleTableAdapters.DT_tipo_form_TA()
        Me.TableAdapterManager = New PoP2.Comuni.DS_personaleTableAdapters.TableAdapterManager()
        Me.InformazioniTIPS = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DT_Cap_Gridview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_tipo_formBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TXT_ricerca
        '
        Me.TXT_ricerca.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TXT_ricerca.Location = New System.Drawing.Point(11, 299)
        Me.TXT_ricerca.Name = "TXT_ricerca"
        Me.TXT_ricerca.Size = New System.Drawing.Size(182, 20)
        Me.TXT_ricerca.TabIndex = 2
        Me.InformazioniTIPS.SetToolTip(Me.TXT_ricerca, "Ricerca il tipo di formazione in base alla descrizione")
        '
        'cmd_termina
        '
        Me.cmd_termina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_termina.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.cmd_termina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.cmd_termina.FlatAppearance.BorderSize = 0
        Me.cmd_termina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_termina.Location = New System.Drawing.Point(500, 288)
        Me.cmd_termina.Name = "cmd_termina"
        Me.cmd_termina.Size = New System.Drawing.Size(40, 40)
        Me.cmd_termina.TabIndex = 42
        Me.InformazioniTIPS.SetToolTip(Me.cmd_termina, "Termina la maschera")
        Me.cmd_termina.UseVisualStyleBackColor = True
        '
        'cmd_annulla
        '
        Me.cmd_annulla.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_annulla.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_annulla.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.ricicla48
        Me.cmd_annulla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_annulla.FlatAppearance.BorderSize = 0
        Me.cmd_annulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_annulla.Location = New System.Drawing.Point(362, 288)
        Me.cmd_annulla.Name = "cmd_annulla"
        Me.cmd_annulla.Size = New System.Drawing.Size(40, 40)
        Me.cmd_annulla.TabIndex = 49
        Me.cmd_annulla.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InformazioniTIPS.SetToolTip(Me.cmd_annulla, "Annulla l'ultima modifica effettuata")
        Me.cmd_annulla.UseVisualStyleBackColor = False
        '
        'cmd_elimina
        '
        Me.cmd_elimina.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_elimina.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_elimina.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.omino_cestino48
        Me.cmd_elimina.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_elimina.FlatAppearance.BorderSize = 0
        Me.cmd_elimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_elimina.Location = New System.Drawing.Point(454, 288)
        Me.cmd_elimina.Name = "cmd_elimina"
        Me.cmd_elimina.Size = New System.Drawing.Size(40, 40)
        Me.cmd_elimina.TabIndex = 48
        Me.cmd_elimina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InformazioniTIPS.SetToolTip(Me.cmd_elimina, "Elimina la formazione")
        Me.cmd_elimina.UseVisualStyleBackColor = False
        '
        'cmd_aggiunge
        '
        Me.cmd_aggiunge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_aggiunge.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_aggiunge.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.OminoAggiunge48
        Me.cmd_aggiunge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_aggiunge.FlatAppearance.BorderSize = 0
        Me.cmd_aggiunge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_aggiunge.Location = New System.Drawing.Point(316, 288)
        Me.cmd_aggiunge.Name = "cmd_aggiunge"
        Me.cmd_aggiunge.Size = New System.Drawing.Size(40, 40)
        Me.cmd_aggiunge.TabIndex = 47
        Me.cmd_aggiunge.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InformazioniTIPS.SetToolTip(Me.cmd_aggiunge, "Aggiunge una nuova formazione")
        Me.cmd_aggiunge.UseVisualStyleBackColor = False
        '
        'cmd_salva
        '
        Me.cmd_salva.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_salva.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_salva.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.ominoConferma48
        Me.cmd_salva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.cmd_salva.FlatAppearance.BorderSize = 0
        Me.cmd_salva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmd_salva.Location = New System.Drawing.Point(408, 288)
        Me.cmd_salva.Name = "cmd_salva"
        Me.cmd_salva.Size = New System.Drawing.Size(40, 40)
        Me.cmd_salva.TabIndex = 46
        Me.cmd_salva.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.InformazioniTIPS.SetToolTip(Me.cmd_salva, "Memorizza la formazione modificata")
        Me.cmd_salva.UseVisualStyleBackColor = False
        '
        'DT_Cap_Gridview
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.DT_Cap_Gridview.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DT_Cap_Gridview.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DT_Cap_Gridview.AutoGenerateColumns = False
        Me.DT_Cap_Gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DT_Cap_Gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DT_Cap_Gridview.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn})
        Me.DT_Cap_Gridview.DataSource = Me.DT_tipo_formBindingSource
        Me.DT_Cap_Gridview.Location = New System.Drawing.Point(12, 12)
        Me.DT_Cap_Gridview.Name = "DT_Cap_Gridview"
        Me.DT_Cap_Gridview.RowHeadersWidth = 15
        Me.DT_Cap_Gridview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DT_Cap_Gridview.Size = New System.Drawing.Size(532, 252)
        Me.DT_Cap_Gridview.TabIndex = 50
        Me.InformazioniTIPS.SetToolTip(Me.DT_Cap_Gridview, "Elenco dei tipi di formazione erogabili")
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "Descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        '
        'DT_tipo_formBindingSource
        '
        Me.DT_tipo_formBindingSource.DataMember = "DT_tipo_form"
        Me.DT_tipo_formBindingSource.DataSource = Me.DS_personale
        '
        'DS_personale
        '
        Me.DS_personale.DataSetName = "DS_personale"
        Me.DS_personale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_tipo_form_TA
        '
        Me.DT_tipo_form_TA.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.TA_contore_autocompleta_note = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_personaleTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'frmDipendentiTipoFormazione
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 337)
        Me.Controls.Add(Me.DT_Cap_Gridview)
        Me.Controls.Add(Me.cmd_annulla)
        Me.Controls.Add(Me.cmd_elimina)
        Me.Controls.Add(Me.cmd_aggiunge)
        Me.Controls.Add(Me.cmd_salva)
        Me.Controls.Add(Me.cmd_termina)
        Me.Controls.Add(Me.TXT_ricerca)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDipendentiTipoFormazione"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipologia Formazione"
        CType(Me.DT_Cap_Gridview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_tipo_formBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TXT_ricerca As TextBox
    Friend WithEvents cmd_termina As Button
    Friend WithEvents cmd_annulla As Button
    Friend WithEvents cmd_elimina As Button
    Friend WithEvents cmd_aggiunge As Button
    Friend WithEvents cmd_salva As Button
    Friend WithEvents DT_Cap_Gridview As DataGridView
    Friend WithEvents DS_personale As DS_personale
    Friend WithEvents DT_tipo_formBindingSource As BindingSource
    Friend WithEvents DT_tipo_form_TA As DS_personaleTableAdapters.DT_tipo_form_TA
    Friend WithEvents TableAdapterManager As DS_personaleTableAdapters.TableAdapterManager
    Friend WithEvents InformazioniTIPS As ToolTip
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
