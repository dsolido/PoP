<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_stp_fattura
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_stp_fattura))
        Me.BS_fattura = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_fattura = New PoP2.Comuni.DS_fattura()
        Me.BS_fattura_tot = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_fattura_righe = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TA_fattura = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura()
        Me.TA_fattura_tot = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura_tot()
        Me.TA_fattura_righe = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura_righe()
        CType(Me.BS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_fattura_tot, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_fattura_righe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BS_fattura
        '
        Me.BS_fattura.DataMember = "DT_fattura"
        Me.BS_fattura.DataSource = Me.DS_fattura
        '
        'DS_fattura
        '
        Me.DS_fattura.DataSetName = "DS_fattura"
        Me.DS_fattura.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_fattura_tot
        '
        Me.BS_fattura_tot.DataMember = "DT_fattura_tot"
        Me.BS_fattura_tot.DataSource = Me.DS_fattura
        '
        'BS_fattura_righe
        '
        Me.BS_fattura_righe.DataMember = "DT_fattura_righe"
        Me.BS_fattura_righe.DataSource = Me.DS_fattura
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "fattura"
        ReportDataSource1.Value = Me.BS_fattura
        ReportDataSource2.Name = "totale"
        ReportDataSource2.Value = Me.BS_fattura_tot
        ReportDataSource3.Name = "righe"
        ReportDataSource3.Value = Me.BS_fattura_righe
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_fattura.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(670, 394)
        Me.ReportViewer1.TabIndex = 5
        '
        'TA_fattura
        '
        Me.TA_fattura.ClearBeforeFill = True
        '
        'TA_fattura_tot
        '
        Me.TA_fattura_tot.ClearBeforeFill = True
        '
        'TA_fattura_righe
        '
        Me.TA_fattura_righe.ClearBeforeFill = True
        '
        'FRM_stp_fattura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 394)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_stp_fattura"
        Me.Text = "Stampa delle Fatture"
        CType(Me.BS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_fattura_tot, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_fattura_righe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BS_fattura As BindingSource
    Friend WithEvents DS_fattura As DS_fattura
    Friend WithEvents BS_fattura_tot As BindingSource
    Friend WithEvents BS_fattura_righe As BindingSource
    Friend WithEvents TA_fattura As DS_fatturaTableAdapters.TA_fattura
    Friend WithEvents TA_fattura_tot As DS_fatturaTableAdapters.TA_fattura_tot
    Friend WithEvents TA_fattura_righe As DS_fatturaTableAdapters.TA_fattura_righe
    'Friend WithEvents TA_Q1_tot As DS_fatturazioneTableAdapter.TA_Q1_tot
End Class
