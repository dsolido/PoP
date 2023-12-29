<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_STP_OreClienti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_STP_OreClienti))
        Me.RP_programmaperCliente = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_orari = New PoP2.Comuni.DS_orari()
        Me.DT_orario_STPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_orario_STP = New PoP2.Comuni.DS_orariTableAdapters.TA_orario_STP()
        Me.DT_orario_STP_totaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_orario_STP_totali = New PoP2.Comuni.DS_orariTableAdapters.TA_orario_STP_totali()
        CType(Me.DS_orari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_orario_STPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_orario_STP_totaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RP_programmaperCliente
        '
        Me.RP_programmaperCliente.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DT_orario_STPBindingSource
        ReportDataSource2.Name = "DataSet3"
        ReportDataSource2.Value = Me.DT_orario_STP_totaliBindingSource
        Me.RP_programmaperCliente.LocalReport.DataSources.Add(ReportDataSource1)
        Me.RP_programmaperCliente.LocalReport.DataSources.Add(ReportDataSource2)
        Me.RP_programmaperCliente.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_programmaclienti.rdlc"
        Me.RP_programmaperCliente.Location = New System.Drawing.Point(0, 0)
        Me.RP_programmaperCliente.Name = "RP_programmaperCliente"
        'Me.RP_programmaperCliente.ServerReport.BearerToken = Nothing
        Me.RP_programmaperCliente.Size = New System.Drawing.Size(800, 450)
        Me.RP_programmaperCliente.TabIndex = 0
        '
        'DS_orari
        '
        Me.DS_orari.DataSetName = "DS_orari"
        Me.DS_orari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_orario_STPBindingSource
        '
        Me.DT_orario_STPBindingSource.DataMember = "DT_orario_STP"
        Me.DT_orario_STPBindingSource.DataSource = Me.DS_orari
        '
        'TA_orario_STP
        '
        Me.TA_orario_STP.ClearBeforeFill = True
        '
        'DT_orario_STP_totaliBindingSource
        '
        Me.DT_orario_STP_totaliBindingSource.DataMember = "DT_orario_STP_totali"
        Me.DT_orario_STP_totaliBindingSource.DataSource = Me.DS_orari
        '
        'TA_orario_STP_totali
        '
        Me.TA_orario_STP_totali.ClearBeforeFill = True
        '
        'FRM_STP_ProgrammaCantieri
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.RP_programmaperCliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_STP_ProgrammaCantieri"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Programmazione oraria dipendenti nel Cantiere"
        CType(Me.DS_orari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_orario_STPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_orario_STP_totaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RP_programmaperCliente As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_orario_STPBindingSource As BindingSource
    Friend WithEvents DS_orari As DS_orari
    Friend WithEvents DT_orario_STP_totaliBindingSource As BindingSource
    Friend WithEvents TA_orario_STP As DS_orariTableAdapters.TA_orario_STP
    Friend WithEvents TA_orario_STP_totali As DS_orariTableAdapters.TA_orario_STP_totali
End Class
