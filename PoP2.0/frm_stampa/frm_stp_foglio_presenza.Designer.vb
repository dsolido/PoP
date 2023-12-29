<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_stp_foglio_presenza
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.DT_fp_stpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_personale = New PoP2.Comuni.DS_personale()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DT_fp_stp_TA = New PoP2.Comuni.DS_personaleTableAdapters.DT_fp_stp_TA()
        CType(Me.DT_fp_stpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DT_fp_stpBindingSource
        '
        Me.DT_fp_stpBindingSource.DataMember = "DT_fp_stp"
        Me.DT_fp_stpBindingSource.DataSource = Me.DS_personale
        '
        'DS_personale
        '
        Me.DS_personale.DataSetName = "DS_personale"
        Me.DS_personale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS"
        ReportDataSource1.Value = Me.DT_fp_stpBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.fp.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        'Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(784, 561)
        Me.ReportViewer1.TabIndex = 0
        '
        'DT_fp_stp_TA
        '
        Me.DT_fp_stp_TA.ClearBeforeFill = True
        '
        'frm_stp_foglio_presenza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frm_stp_foglio_presenza"
        Me.Text = "Foglio Presenza"
        CType(Me.DT_fp_stpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_fp_stpBindingSource As BindingSource
    Friend WithEvents DS_personale As DS_personale
    Friend WithEvents DT_fp_stp_TA As DS_personaleTableAdapters.DT_fp_stp_TA
End Class
