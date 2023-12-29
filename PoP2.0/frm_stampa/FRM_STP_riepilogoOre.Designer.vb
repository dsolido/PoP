<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_stp_riepilogoOre
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_personale = New PoP2.Comuni.DS_personale()
        Me.DT_contoreBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_contore = New PoP2.Comuni.DS_personaleTableAdapters.TA_contore()
        Me.DT_clientiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_clienti_TableAdapter = New PoP2.Comuni.DS_personaleTableAdapters.DT_clienti_TableAdapter()
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_contoreBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_clientiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Ore"
        ReportDataSource1.Value = Me.DT_contoreBindingSource
        ReportDataSource2.Name = "DS_clienti"
        ReportDataSource2.Value = Me.DT_clientiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.Riepilogo_ore_cliente.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        'Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DS_personale
        '
        Me.DS_personale.DataSetName = "DS_personale"
        Me.DS_personale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_contoreBindingSource
        '
        Me.DT_contoreBindingSource.DataMember = "DT_contore"
        Me.DT_contoreBindingSource.DataSource = Me.DS_personale
        '
        'TA_contore
        '
        Me.TA_contore.ClearBeforeFill = True
        '
        'DT_clientiBindingSource
        '
        Me.DT_clientiBindingSource.DataMember = "DT_clienti"
        Me.DT_clientiBindingSource.DataSource = Me.DS_personale
        '
        'DT_clienti_TableAdapter
        '
        Me.DT_clienti_TableAdapter.ClearBeforeFill = True
        '
        'FRM_stp_riepilogoOre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FRM_stp_riepilogoOre"
        Me.Text = "FRM_stp_riepilogoOre"
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_contoreBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_clientiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_contoreBindingSource As BindingSource
    Friend WithEvents DS_personale As DS_personale
    Friend WithEvents DT_clientiBindingSource As BindingSource
    Friend WithEvents TA_contore As DS_personaleTableAdapters.TA_contore
    Friend WithEvents DT_clienti_TableAdapter As DS_personaleTableAdapters.DT_clienti_TableAdapter
End Class
