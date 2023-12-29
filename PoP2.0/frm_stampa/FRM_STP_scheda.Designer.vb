<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stp_scheda
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stp_scheda))
        Me.rpt_scheda_prodotti = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DT_prodottiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_prodotti = New PoP2.Comuni.DS_prodotti()
        Me.TA_prodotti = New PoP2.Comuni.DS_prodottiTableAdapters.TA_prodotti()
        CType(Me.DT_prodottiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_prodotti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpt_scheda_prodotti
        '
        Me.rpt_scheda_prodotti.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DT_prodottiBindingSource
        Me.rpt_scheda_prodotti.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpt_scheda_prodotti.LocalReport.DisplayName = "Scheda Materiale"
        Me.rpt_scheda_prodotti.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_schedaMateriale.rdlc"
        Me.rpt_scheda_prodotti.Location = New System.Drawing.Point(0, 0)
        Me.rpt_scheda_prodotti.Name = "rpt_scheda_prodotti"
        Me.rpt_scheda_prodotti.ShowFindControls = False
        Me.rpt_scheda_prodotti.ShowRefreshButton = False
        Me.rpt_scheda_prodotti.Size = New System.Drawing.Size(756, 510)
        Me.rpt_scheda_prodotti.TabIndex = 0
        '
        'DT_prodottiBindingSource
        '
        Me.DT_prodottiBindingSource.DataMember = "DT_prodotti"
        Me.DT_prodottiBindingSource.DataSource = Me.DS_prodotti
        '
        'DS_prodotti
        '
        Me.DS_prodotti.DataSetName = "DS_prodotti"
        Me.DS_prodotti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_prodotti
        '
        Me.TA_prodotti.ClearBeforeFill = True
        '
        'frm_stp_scheda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(756, 510)
        Me.Controls.Add(Me.rpt_scheda_prodotti)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stp_scheda"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stampa Scheda Prodotti"
        CType(Me.DT_prodottiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_prodotti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents rpt_scheda_prodotti As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DS_prodotti As DS_prodotti
    Friend WithEvents TA_prodotti As DS_prodottiTableAdapters.TA_prodotti
    Friend WithEvents DT_prodottiBindingSource As BindingSource
End Class
