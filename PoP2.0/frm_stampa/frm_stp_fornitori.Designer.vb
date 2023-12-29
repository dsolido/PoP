<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stp_fornitori
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stp_fornitori))
        Me.DT_fornitoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_magazzino = New PoP2._0.DS_magazzino()
        Me.rpt_fornitori = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DT_fornitoriTableAdapter = New PoP2._0.DS_magazzinoTableAdapters.DT_fornitoriTableAdapter()
        CType(Me.DT_fornitoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_magazzino, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DT_fornitoriBindingSource
        '
        Me.DT_fornitoriBindingSource.DataMember = "DT_fornitori"
        Me.DT_fornitoriBindingSource.DataSource = Me.DS_magazzino
        '
        'DS_magazzino
        '
        Me.DS_magazzino.DataSetName = "DS_magazzino"
        Me.DS_magazzino.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rpt_fornitori
        '
        Me.rpt_fornitori.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_stp_Magazzino"
        ReportDataSource1.Value = Me.DT_fornitoriBindingSource
        Me.rpt_fornitori.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpt_fornitori.LocalReport.ReportEmbeddedResource = "PoP2._0.elenco_Fornitori.rdlc"
        Me.rpt_fornitori.Location = New System.Drawing.Point(0, 0)
        Me.rpt_fornitori.Name = "rpt_fornitori"
        'Me.rpt_fornitori.ServerReport.BearerToken = Nothing
        Me.rpt_fornitori.Size = New System.Drawing.Size(584, 361)
        Me.rpt_fornitori.TabIndex = 0
        '
        'DT_fornitoriTableAdapter
        '
        Me.DT_fornitoriTableAdapter.ClearBeforeFill = True
        '
        'frm_stp_fornitori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.rpt_fornitori)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stp_fornitori"
        Me.Text = "Elenco Fornitori"
        CType(Me.DT_fornitoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_magazzino, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rpt_fornitori As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_fornitoriBindingSource As BindingSource
    Friend WithEvents DS_magazzino As DS_magazzino
    Friend WithEvents DT_fornitoriTableAdapter As DS_magazzinoTableAdapters.DT_fornitoriTableAdapter
End Class
