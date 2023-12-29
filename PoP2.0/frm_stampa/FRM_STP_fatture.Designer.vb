<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_STP_fatture
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_STP_fatture))
        Me.BS_fattura = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_fattura = New PoP2.Comuni.DS_fattura()
        Me.BS_righe = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_tot = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_fattura = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura()
        Me.TA_fattura_tot = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura_tot()
        Me.TA_fattura_righe = New PoP2.Comuni.DS_fatturaTableAdapters.TA_fattura_righe()
        Me.ReportViewer2 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.BS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_righe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_tot, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'BS_righe
        '
        Me.BS_righe.DataMember = "DT_fattura_righe"
        Me.BS_righe.DataSource = Me.DS_fattura
        '
        'BS_tot
        '
        Me.BS_tot.DataMember = "DT_fattura_tot"
        Me.BS_tot.DataSource = Me.DS_fattura
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
        'ReportViewer2
        '
        Me.ReportViewer2.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BS_fattura
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.BS_righe
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.BS_tot
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer2.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer2.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_fatturaN.rdlc"
        Me.ReportViewer2.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer2.Name = "ReportViewer2"
        Me.ReportViewer2.ServerReport.BearerToken = Nothing
        Me.ReportViewer2.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer2.TabIndex = 1
        '
        'FRM_STP_fatture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_STP_fatture"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stampa Fatture"
        CType(Me.BS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_fattura, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_righe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_tot, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DS_fattura As DS_fattura
    Friend WithEvents TA_fattura As DS_fatturaTableAdapters.TA_fattura
    Friend WithEvents TA_fattura_tot As DS_fatturaTableAdapters.TA_fattura_tot
    Friend WithEvents TA_fattura_righe As DS_fatturaTableAdapters.TA_fattura_righe
    Friend WithEvents ReportViewer2 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BS_fattura As BindingSource
    Friend WithEvents BS_righe As BindingSource
    Friend WithEvents BS_tot As BindingSource
End Class
