<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_stp_fattura_elenco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_stp_fattura_elenco))
        Me.DS_fattura = New PoP2.Comuni.DS_fattura()
        Me.DS_azienda = New PoP2.Comuni.DS_azienda()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TA_STP_fattura = New PoP2.Comuni.DS_fatturaTableAdapters.TA_STP_fattura()
        Me.TA_azienda = New PoP2.Comuni.DS_aziendaTableAdapters.TA_azienda()
        Me.BS_STP_fattura = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_azienda = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_STP_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_azienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DS_fattura
        '
        Me.DS_fattura.DataSetName = "DS_fattura"
        Me.DS_fattura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DS_azienda
        '
        Me.DS_azienda.DataSetName = "DS_azienda"
        Me.DS_azienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_elenco"
        ReportDataSource1.Value = Me.BS_STP_fattura
        ReportDataSource2.Name = "DS_azienda"
        ReportDataSource2.Value = Me.BS_azienda
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_fattura_elenco_fatture.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'TA_STP_fattura
        '
        Me.TA_STP_fattura.ClearBeforeFill = True
        '
        'TA_azienda
        '
        Me.TA_azienda.ClearBeforeFill = True
        '
        'BS_STP_fattura
        '
        Me.BS_STP_fattura.DataMember = "DT_STP_fattura"
        Me.BS_STP_fattura.DataSource = Me.DS_fattura
        '
        'BS_azienda
        '
        Me.BS_azienda.DataMember = "DT_azienda"
        Me.BS_azienda.DataSource = Me.DS_azienda
        '
        'FRM_stp_fattura_elenco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_stp_fattura_elenco"
        Me.Text = "Elenco Fatture"
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_STP_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_azienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DS_fattura As DS_fattura
    Friend WithEvents DS_azienda As DS_azienda
    Friend WithEvents TA_STP_fattura As DS_fatturaTableAdapters.TA_STP_fattura
    Friend WithEvents TA_azienda As DS_aziendaTableAdapters.TA_azienda
    Friend WithEvents BS_STP_fattura As BindingSource
    Friend WithEvents BS_azienda As BindingSource
End Class
