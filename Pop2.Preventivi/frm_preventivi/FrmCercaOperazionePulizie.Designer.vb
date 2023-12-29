Imports Pop2.Comuni
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCercaOperazionePulizie
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpegnometroquadroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImpegnonumeroDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AttivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdcategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsPreventivoOperazioni = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsPreventivi = New PoP2.Comuni.DSPreventivi()
        Me.TaPreventiviOperazioni = New PoP2.Comuni.DSPreventiviTableAdapters.taPreventiviOperazioni()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsPreventivoOperazioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsPreventivi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn, Me.ImpegnometroquadroDataGridViewTextBoxColumn, Me.ImpegnonumeroDataGridViewTextBoxColumn, Me.DataDataGridViewTextBoxColumn, Me.AttivoDataGridViewTextBoxColumn, Me.IdcategoriaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.bsPreventivoOperazioni
        Me.DataGridView1.Location = New System.Drawing.Point(25, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(754, 357)
        Me.DataGridView1.TabIndex = 5
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(26, 390)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(266, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(635, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(143, 35)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Termina"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        Me.DescrizioneDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImpegnometroquadroDataGridViewTextBoxColumn
        '
        Me.ImpegnometroquadroDataGridViewTextBoxColumn.DataPropertyName = "impegnometroquadro"
        Me.ImpegnometroquadroDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.ImpegnometroquadroDataGridViewTextBoxColumn.HeaderText = "impegnometroquadro"
        Me.ImpegnometroquadroDataGridViewTextBoxColumn.Name = "ImpegnometroquadroDataGridViewTextBoxColumn"
        Me.ImpegnometroquadroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImpegnonumeroDataGridViewTextBoxColumn
        '
        Me.ImpegnonumeroDataGridViewTextBoxColumn.DataPropertyName = "impegnonumero"
        Me.ImpegnonumeroDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.ImpegnonumeroDataGridViewTextBoxColumn.HeaderText = "impegnonumero"
        Me.ImpegnonumeroDataGridViewTextBoxColumn.Name = "ImpegnonumeroDataGridViewTextBoxColumn"
        Me.ImpegnonumeroDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataDataGridViewTextBoxColumn
        '
        Me.DataDataGridViewTextBoxColumn.DataPropertyName = "data"
        Me.DataDataGridViewTextBoxColumn.FillWeight = 20.0!
        Me.DataDataGridViewTextBoxColumn.HeaderText = "data"
        Me.DataDataGridViewTextBoxColumn.Name = "DataDataGridViewTextBoxColumn"
        Me.DataDataGridViewTextBoxColumn.ReadOnly = True
        Me.DataDataGridViewTextBoxColumn.Visible = False
        '
        'AttivoDataGridViewTextBoxColumn
        '
        Me.AttivoDataGridViewTextBoxColumn.DataPropertyName = "attivo"
        Me.AttivoDataGridViewTextBoxColumn.HeaderText = "attivo"
        Me.AttivoDataGridViewTextBoxColumn.Name = "AttivoDataGridViewTextBoxColumn"
        Me.AttivoDataGridViewTextBoxColumn.ReadOnly = True
        Me.AttivoDataGridViewTextBoxColumn.Visible = False
        '
        'IdcategoriaDataGridViewTextBoxColumn
        '
        Me.IdcategoriaDataGridViewTextBoxColumn.DataPropertyName = "idcategoria"
        Me.IdcategoriaDataGridViewTextBoxColumn.HeaderText = "idcategoria"
        Me.IdcategoriaDataGridViewTextBoxColumn.Name = "IdcategoriaDataGridViewTextBoxColumn"
        Me.IdcategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdcategoriaDataGridViewTextBoxColumn.Visible = False
        '
        'bsPreventivoOperazioni
        '
        Me.bsPreventivoOperazioni.DataMember = "dtPreventiviOperazioni"
        Me.bsPreventivoOperazioni.DataSource = Me.DsPreventivi
        '
        'DsPreventivi
        '
        Me.DsPreventivi.DataSetName = "dsPreventivi"
        Me.DsPreventivi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaPreventiviOperazioni
        '
        Me.TaPreventiviOperazioni.ClearBeforeFill = True
        '
        'FrmCercaOperazionePulizie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmCercaOperazionePulizie"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmCercaOperazionePulizie"
        Me.TopMost = True
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsPreventivoOperazioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsPreventivi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DsPreventivi As dsPreventivi
    Friend WithEvents bsPreventivoOperazioni As BindingSource
    Friend WithEvents TaPreventiviOperazioni As dsPreventiviTableAdapters.taPreventiviOperazioni
    Friend WithEvents Button1 As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpegnometroquadroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImpegnonumeroDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AttivoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdcategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
