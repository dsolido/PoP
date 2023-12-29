<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_stp_OreDipendenti
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
        Me.BS_orario_STPe = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_orari = New PoP2.Comuni.DS_orari()
        Me.BS_orario_STP_totali = New System.Windows.Forms.BindingSource(Me.components)
        Me.BS_orari_STP = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TA_orario_STP = New PoP2.Comuni.DS_orariTableAdapters.TA_orario_STP()
        Me.TA_orario_STP_totali = New PoP2.Comuni.DS_orariTableAdapters.TA_orario_STP_totali()
        CType(Me.BS_orario_STPe, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_orari, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_orario_STP_totali, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_orari_STP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BS_orario_STPe
        '
        Me.BS_orario_STPe.DataMember = "DT_orario_STP"
        Me.BS_orario_STPe.DataSource = Me.DS_orari
        '
        'DS_orari
        '
        Me.DS_orari.DataSetName = "DS_orari"
        Me.DS_orari.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_orario_STP_totali
        '
        Me.BS_orario_STP_totali.DataMember = "DT_orario_STP_totali"
        Me.BS_orario_STP_totali.DataSource = Me.DS_orari
        '
        'BS_orari_STP
        '
        Me.BS_orari_STP.DataMember = "DT_orario_STP"
        Me.BS_orari_STP.DataSource = Me.DS_orari
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BS_orario_STPe
        ReportDataSource2.Name = "DataSet3"
        ReportDataSource2.Value = Me.BS_orario_STP_totali
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_programmadipendenti.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        'Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'TA_orario_STP
        '
        Me.TA_orario_STP.ClearBeforeFill = True
        '
        'TA_orario_STP_totali
        '
        Me.TA_orario_STP_totali.ClearBeforeFill = True
        '
        'FRM_stp_OreDipendenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FRM_stp_OreDipendenti"
        Me.Text = "Stampa riepilogo ore dipendente"
        CType(Me.BS_orario_STPe, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_orari, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_orario_STP_totali, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_orari_STP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DS_orari As DS_orari
    Friend WithEvents BS_orari_STP As BindingSource
    Friend WithEvents TA_orario_STP As DS_orariTableAdapters.TA_orario_STP
    Friend WithEvents BS_orario_STPe As BindingSource
    Friend WithEvents BS_orario_STP_totali As BindingSource
    Friend WithEvents TA_orario_STP_totali As DS_orariTableAdapters.TA_orario_STP_totali
End Class
