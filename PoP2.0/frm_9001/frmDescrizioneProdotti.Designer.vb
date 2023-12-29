<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDescrizioneProdotti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDescrizioneProdotti))
        Me.DT_BarraNavigazione = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.TTBTRicerca = New System.Windows.Forms.ToolStripButton()
        Me.TTTestoRicerca = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.dgwIstruzioni = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdtipologiaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizionecommercialeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TagDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescrizioneDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bsProdotti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DsProcedure = New PoP2.Comuni.DSProcedure()
        Me.TaProdotti = New PoP2.Comuni.DSProcedureTableAdapters.taProdotti()
        CType(Me.DT_BarraNavigazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_BarraNavigazione.SuspendLayout()
        CType(Me.dgwIstruzioni, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsProdotti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DsProcedure, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DT_BarraNavigazione
        '
        Me.DT_BarraNavigazione.AddNewItem = Nothing
        Me.DT_BarraNavigazione.AutoSize = False
        Me.DT_BarraNavigazione.BindingSource = Me.bsProdotti
        Me.DT_BarraNavigazione.CountItem = Me.BindingNavigatorCountItem
        Me.DT_BarraNavigazione.DeleteItem = Nothing
        Me.DT_BarraNavigazione.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_BarraNavigazione.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicerca, Me.TTTestoRicerca, Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.TTBTTermina, Me.TTBTStampa})
        Me.DT_BarraNavigazione.Location = New System.Drawing.Point(0, 558)
        Me.DT_BarraNavigazione.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DT_BarraNavigazione.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DT_BarraNavigazione.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DT_BarraNavigazione.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DT_BarraNavigazione.Name = "DT_BarraNavigazione"
        Me.DT_BarraNavigazione.PositionItem = Me.BindingNavigatorPositionItem
        Me.DT_BarraNavigazione.Size = New System.Drawing.Size(800, 76)
        Me.DT_BarraNavigazione.TabIndex = 150
        Me.DT_BarraNavigazione.Text = "DS_Navigatore"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 73)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'TTBTRicerca
        '
        Me.TTBTRicerca.AutoSize = False
        Me.TTBTRicerca.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_ricarica
        Me.TTBTRicerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTRicerca.Name = "TTBTRicerca"
        Me.TTBTRicerca.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicerca.Text = "Ricarica"
        Me.TTBTRicerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicerca.ToolTipText = "Elimina tutti i filtri e ricarica tutti gli archivi"
        '
        'TTTestoRicerca
        '
        Me.TTTestoRicerca.AutoSize = False
        Me.TTTestoRicerca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TTTestoRicerca.Font = New System.Drawing.Font("Segoe UI", 18.0!)
        Me.TTTestoRicerca.Margin = New System.Windows.Forms.Padding(1, 0, 1, 5)
        Me.TTTestoRicerca.Name = "TTTestoRicerca"
        Me.TTTestoRicerca.Size = New System.Drawing.Size(133, 32)
        Me.TTTestoRicerca.ToolTipText = "Ricerca all'interno dell'archivio per SOCIETA' / P.IVA / CITTA'"
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
        Me.BindingNavigatorMoveFirstItem.ToolTipText = "Va all'inizio dell'elenco clienti"
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
        Me.BindingNavigatorMovePreviousItem.ToolTipText = "Va al cliente precedente"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 76)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 33)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 76)
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
        Me.BindingNavigatorMoveNextItem.ToolTipText = "Va al cliente successivo"
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
        Me.BindingNavigatorMoveLastItem.ToolTipText = "Procede alla fine dell'archivio"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 76)
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
        Me.TTBTTermina.ToolTipText = "Chiude la maschera e torna al menù principale"
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
        Me.TTBTStampa.ToolTipText = "Stampa un elenco dei clienti in base alle scelte"
        Me.TTBTStampa.Visible = False
        '
        'dgwIstruzioni
        '
        Me.dgwIstruzioni.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgwIstruzioni.AutoGenerateColumns = False
        Me.dgwIstruzioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgwIstruzioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwIstruzioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.IdtipologiaDataGridViewTextBoxColumn, Me.DescrizionecommercialeDataGridViewTextBoxColumn, Me.TagDataGridViewTextBoxColumn, Me.DescrizioneDataGridViewTextBoxColumn})
        Me.dgwIstruzioni.DataSource = Me.bsProdotti
        Me.dgwIstruzioni.Location = New System.Drawing.Point(0, 2)
        Me.dgwIstruzioni.Name = "dgwIstruzioni"
        Me.dgwIstruzioni.RowHeadersWidth = 20
        Me.dgwIstruzioni.Size = New System.Drawing.Size(800, 466)
        Me.dgwIstruzioni.TabIndex = 149
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 10.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'IdtipologiaDataGridViewTextBoxColumn
        '
        Me.IdtipologiaDataGridViewTextBoxColumn.DataPropertyName = "id_tipologia"
        Me.IdtipologiaDataGridViewTextBoxColumn.FillWeight = 10.0!
        Me.IdtipologiaDataGridViewTextBoxColumn.HeaderText = "id_tipologia"
        Me.IdtipologiaDataGridViewTextBoxColumn.Name = "IdtipologiaDataGridViewTextBoxColumn"
        '
        'DescrizionecommercialeDataGridViewTextBoxColumn
        '
        Me.DescrizionecommercialeDataGridViewTextBoxColumn.DataPropertyName = "descrizionecommerciale"
        Me.DescrizionecommercialeDataGridViewTextBoxColumn.HeaderText = "descrizionecommerciale"
        Me.DescrizionecommercialeDataGridViewTextBoxColumn.Name = "DescrizionecommercialeDataGridViewTextBoxColumn"
        '
        'TagDataGridViewTextBoxColumn
        '
        Me.TagDataGridViewTextBoxColumn.DataPropertyName = "tag"
        Me.TagDataGridViewTextBoxColumn.HeaderText = "tag"
        Me.TagDataGridViewTextBoxColumn.Name = "TagDataGridViewTextBoxColumn"
        '
        'DescrizioneDataGridViewTextBoxColumn
        '
        Me.DescrizioneDataGridViewTextBoxColumn.DataPropertyName = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.HeaderText = "descrizione"
        Me.DescrizioneDataGridViewTextBoxColumn.Name = "DescrizioneDataGridViewTextBoxColumn"
        '
        'bsProdotti
        '
        Me.bsProdotti.DataMember = "dtProdotti"
        Me.bsProdotti.DataSource = Me.DsProcedure
        '
        'DsProcedure
        '
        Me.DsProcedure.DataSetName = "dsProcedure"
        Me.DsProcedure.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TaProdotti
        '
        Me.TaProdotti.ClearBeforeFill = True
        '
        'frmDescrizioneProdotti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 634)
        Me.Controls.Add(Me.DT_BarraNavigazione)
        Me.Controls.Add(Me.dgwIstruzioni)
        Me.Name = "frmDescrizioneProdotti"
        Me.Text = "frmDescrizioneProdotti"
        CType(Me.DT_BarraNavigazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_BarraNavigazione.ResumeLayout(False)
        Me.DT_BarraNavigazione.PerformLayout()
        CType(Me.dgwIstruzioni, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsProdotti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DsProcedure, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DT_BarraNavigazione As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents TTBTRicerca As ToolStripButton
    Friend WithEvents TTTestoRicerca As ToolStripTextBox
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents dgwIstruzioni As DataGridView
    Friend WithEvents DsProcedure As dsProcedure
    Friend WithEvents bsProdotti As BindingSource
    Friend WithEvents TaProdotti As dsProcedureTableAdapters.taProdotti
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdtipologiaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizionecommercialeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescrizioneDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
