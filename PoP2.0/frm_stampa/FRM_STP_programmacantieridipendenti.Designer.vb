<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_STP_programmacantieridipendenti
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_STP_programmacantieridipendenti))
        Me.DT_aziendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_azienda = New PoP2.Comuni.DS_azienda()
        Me.DT_impegno_viewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_riepiloghi = New PoP2.Comuni.DS_riepiloghi()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TA_azienda = New PoP2.Comuni.DS_aziendaTableAdapters.TA_azienda()
        Me.TA_impegno_view = New PoP2.Comuni.DS_riepiloghiTableAdapters.TA_impegno_view()
        CType(Me.DT_aziendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_impegno_viewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_riepiloghi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DT_aziendaBindingSource
        '
        Me.DT_aziendaBindingSource.DataMember = "DT_azienda"
        Me.DT_aziendaBindingSource.DataSource = Me.DS_azienda
        '
        'DS_azienda
        '
        Me.DS_azienda.DataSetName = "DS_azienda"
        Me.DS_azienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_impegno_viewBindingSource
        '
        Me.DT_impegno_viewBindingSource.DataMember = "DT_impegno_view"
        Me.DT_impegno_viewBindingSource.DataSource = Me.DS_riepiloghi
        '
        'DS_riepiloghi
        '
        Me.DS_riepiloghi.DataSetName = "DS_riepiloghi"
        Me.DS_riepiloghi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_azienda"
        ReportDataSource1.Value = Me.DT_aziendaBindingSource
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.DT_impegno_viewBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_prospettoClientiDipendenti.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        'Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'TA_azienda
        '
        Me.TA_azienda.ClearBeforeFill = True
        '
        'TA_impegno_view
        '
        Me.TA_impegno_view.ClearBeforeFill = True
        '
        'FRM_STP_programmacantieridipendenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_STP_programmacantieridipendenti"
        Me.Text = "Distribuzione personale sui cantieri"
        CType(Me.DT_aziendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_impegno_viewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_riepiloghi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_aziendaBindingSource As BindingSource
    Friend WithEvents DS_azienda As DS_azienda
    Friend WithEvents DT_impegno_viewBindingSource As BindingSource
    Friend WithEvents DS_riepiloghi As DS_riepiloghi
    Friend WithEvents TA_azienda As DS_aziendaTableAdapters.TA_azienda
    Friend WithEvents TA_impegno_view As DS_riepiloghiTableAdapters.TA_impegno_view
End Class
