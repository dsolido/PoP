<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_STP_Ordini
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_STP_Ordini))
        Me.DT_ordiniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Ordini = New PoP2.Comuni.DS_Ordini()
        Me.DT_ordinirigheBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TA_ordini = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_ordini()
        Me.TA_ordinirighe = New PoP2.Comuni.DS_OrdiniTableAdapters.TA_ordinirighe()
        CType(Me.DT_ordiniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_ordinirigheBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DT_ordiniBindingSource
        '
        Me.DT_ordiniBindingSource.DataMember = "DT_ordini"
        Me.DT_ordiniBindingSource.DataSource = Me.DS_Ordini
        '
        'DS_Ordini
        '
        Me.DS_Ordini.DataSetName = "DS_Ordini"
        Me.DS_Ordini.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_ordinirigheBindingSource
        '
        Me.DT_ordinirigheBindingSource.DataMember = "DT_ordinirighe"
        Me.DT_ordinirigheBindingSource.DataSource = Me.DS_Ordini
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DT_ordiniBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.DT_ordinirigheBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_OrdineMateriale2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(811, 354)
        Me.ReportViewer1.TabIndex = 0
        '
        'TA_ordini
        '
        Me.TA_ordini.ClearBeforeFill = True
        '
        'TA_ordinirighe
        '
        Me.TA_ordinirighe.ClearBeforeFill = True
        '
        'FRM_STP_Ordini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 354)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_STP_Ordini"
        Me.Text = "Stampa Ordini"
        CType(Me.DT_ordiniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Ordini, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_ordinirigheBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_ordiniBindingSource As BindingSource
    Friend WithEvents DS_Ordini As DS_Ordini
    Friend WithEvents TA_ordini As DS_OrdiniTableAdapters.TA_ordini
    Friend WithEvents DT_ordinirigheBindingSource As BindingSource
    Friend WithEvents TA_ordinirighe As DS_OrdiniTableAdapters.TA_ordinirighe
End Class
