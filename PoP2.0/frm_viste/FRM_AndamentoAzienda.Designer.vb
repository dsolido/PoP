<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_AndamentoAzienda
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_AndamentoAzienda))
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TTBTRicerca = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TTBTTermina = New System.Windows.Forms.ToolStripButton()
        Me.TTBTStampa = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DT_v_ordiniBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TA_fattura_tot = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura_tot()
        Me.DS_fattura = New PoP2.Comuni.DS_fattura()
        Me.BS_tot = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_contoreTot = New PoP2.Comuni.DS_fatturaTableAdapters.TA_contoreTot()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DT_v_ordiniBindingNavigator.SuspendLayout()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_tot, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Chart1
        '
        Me.Chart1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea1.Name = "Importi"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(12, 12)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "Importi"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series2.ChartArea = "Importi"
        Series2.Legend = "Legend1"
        Series2.Name = "Series2"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1004, 342)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'TTBTRicerca
        '
        Me.TTBTRicerca.AutoSize = False
        Me.TTBTRicerca.Image = Global.PoP2.Comuni.My.Resources.Resources.Omino_ricarica48
        Me.TTBTRicerca.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.TTBTRicerca.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TTBTRicerca.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TTBTRicerca.Name = "TTBTRicerca"
        Me.TTBTRicerca.Size = New System.Drawing.Size(50, 70)
        Me.TTBTRicerca.Text = "Ricarica"
        Me.TTBTRicerca.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.TTBTRicerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.TTBTRicerca.ToolTipText = "Seleziona l'Anno"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 79)
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
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 79)
        '
        'DT_v_ordiniBindingNavigator
        '
        Me.DT_v_ordiniBindingNavigator.AddNewItem = Nothing
        Me.DT_v_ordiniBindingNavigator.AutoSize = False
        Me.DT_v_ordiniBindingNavigator.CountItem = Nothing
        Me.DT_v_ordiniBindingNavigator.DeleteItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DT_v_ordiniBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTBTRicerca, Me.BindingNavigatorSeparator2, Me.TTBTTermina, Me.TTBTStampa, Me.ToolStripSeparator3})
        Me.DT_v_ordiniBindingNavigator.Location = New System.Drawing.Point(0, 371)
        Me.DT_v_ordiniBindingNavigator.MoveFirstItem = Nothing
        Me.DT_v_ordiniBindingNavigator.MoveLastItem = Nothing
        Me.DT_v_ordiniBindingNavigator.MoveNextItem = Nothing
        Me.DT_v_ordiniBindingNavigator.MovePreviousItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Name = "DT_v_ordiniBindingNavigator"
        Me.DT_v_ordiniBindingNavigator.PositionItem = Nothing
        Me.DT_v_ordiniBindingNavigator.Size = New System.Drawing.Size(1126, 79)
        Me.DT_v_ordiniBindingNavigator.TabIndex = 146
        Me.DT_v_ordiniBindingNavigator.Text = "BindingNavigator1"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(1022, 52)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox2.TabIndex = 148
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(1022, 117)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(92, 21)
        Me.ComboBox3.TabIndex = 149
        '
        'TA_fattura_tot
        '
        Me.TA_fattura_tot.ClearBeforeFill = True
        '
        'DS_fattura
        '
        Me.DS_fattura.DataSetName = "DS_fattura"
        Me.DS_fattura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_tot
        '
        Me.BS_tot.DataMember = "DT_fattura_tot"
        Me.BS_tot.DataSource = Me.DS_fattura
        '
        'TA_contoreTot
        '
        Me.TA_contoreTot.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1022, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 13)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "Ore"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(1022, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 152
        Me.Label3.Text = "Resa"
        '
        'FRM_AndamentoAzienda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.DT_v_ordiniBindingNavigator)
        Me.Controls.Add(Me.Chart1)
        Me.Name = "FRM_AndamentoAzienda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Andamento"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_v_ordiniBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DT_v_ordiniBindingNavigator.ResumeLayout(False)
        Me.DT_v_ordiniBindingNavigator.PerformLayout()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_tot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents TA_fattura_tot As DS_fatturaTableAdapters.TA_fattura_tot
    Friend WithEvents DS_fattura As DS_fattura
    Friend WithEvents BS_tot As BindingSource
    Friend WithEvents TA_contoreTot As DS_fatturaTableAdapters.TA_contoreTot
    Friend WithEvents TTBTRicerca As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TTBTTermina As ToolStripButton
    Friend WithEvents TTBTStampa As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DT_v_ordiniBindingNavigator As BindingNavigator
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
End Class
