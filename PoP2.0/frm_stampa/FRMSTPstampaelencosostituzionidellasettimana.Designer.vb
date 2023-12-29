<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMSTPstampaelencosostituzionidellasettimana
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
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_ag = New PoP2.Comuni.DS_ag()
        Me.DT_agendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_agenda = New PoP2.Comuni.DS_agTableAdapters.TA_agenda()
        Me.DS_azienda = New PoP2.Comuni.DS_azienda()
        Me.DT_aziendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_azienda = New PoP2.Comuni.DS_aziendaTableAdapters.TA_azienda()
        Me.DTsostituzioniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAsostituzioni = New PoP2.Comuni.DS_agTableAdapters.TAsostituzioni()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_agendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_aziendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTsostituzioniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DT_agendaBindingSource
        ReportDataSource2.Name = "DS_azienda"
        ReportDataSource2.Value = Me.DT_aziendaBindingSource
        ReportDataSource3.Name = "Sostituzioni"
        ReportDataSource3.Value = Me.DTsostituzioniBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_ElencoSostituzioni.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DS_ag
        '
        Me.DS_ag.DataSetName = "DS_ag"
        Me.DS_ag.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_agendaBindingSource
        '
        Me.DT_agendaBindingSource.DataMember = "DT_agenda"
        Me.DT_agendaBindingSource.DataSource = Me.DS_ag
        '
        'TA_agenda
        '
        Me.TA_agenda.ClearBeforeFill = True
        '
        'DS_azienda
        '
        Me.DS_azienda.DataSetName = "DS_azienda"
        Me.DS_azienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_aziendaBindingSource
        '
        Me.DT_aziendaBindingSource.DataMember = "DT_azienda"
        Me.DT_aziendaBindingSource.DataSource = Me.DS_azienda
        '
        'TA_azienda
        '
        Me.TA_azienda.ClearBeforeFill = True
        '
        'DTsostituzioniBindingSource
        '
        Me.DTsostituzioniBindingSource.DataMember = "DTsostituzioni"
        Me.DTsostituzioniBindingSource.DataSource = Me.DS_ag
        '
        'TAsostituzioni
        '
        Me.TAsostituzioni.ClearBeforeFill = True
        '
        'FRMSTPstampaelencosostituzionidellasettimana
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FRMSTPstampaelencosostituzionidellasettimana"
        Me.Text = "FRMSTPstampaelencosostituzionidellasettimana"
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_agendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_aziendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTsostituzioniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_agendaBindingSource As BindingSource
    Friend WithEvents DS_ag As DS_ag
    Friend WithEvents DT_aziendaBindingSource As BindingSource
    Friend WithEvents DS_azienda As DS_azienda
    Friend WithEvents DTsostituzioniBindingSource As BindingSource
    Friend WithEvents TA_agenda As DS_agTableAdapters.TA_agenda
    Friend WithEvents TA_azienda As DS_aziendaTableAdapters.TA_azienda
    Friend WithEvents TAsostituzioni As DS_agTableAdapters.TAsostituzioni
End Class
