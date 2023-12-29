<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMSTPagendaSettimanale
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_ag = New PoP2.Comuni.DS_ag()
        Me.DTsostituzioniBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TAsostituzioni = New PoP2.Comuni.DS_agTableAdapters.TAsostituzioni()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTsostituzioniBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DSagenda"
        ReportDataSource1.Value = Me.DTsostituzioniBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.rpAgendaSettimanalesostituzioni.rdlc"
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
        'DTsostituzioniBindingSource
        '
        Me.DTsostituzioniBindingSource.DataMember = "DTsostituzioni"
        Me.DTsostituzioniBindingSource.DataSource = Me.DS_ag
        '
        'TAsostituzioni
        '
        Me.TAsostituzioni.ClearBeforeFill = True
        '
        'FRMSTPagendaSettimanale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FRMSTPagendaSettimanale"
        Me.Text = "FRMSTPagendaSettimanale"
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTsostituzioniBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents DTsostituzioniBindingSource As BindingSource
    Friend WithEvents DS_ag As DS_ag
    Friend WithEvents TAsostituzioni As DS_agTableAdapters.TAsostituzioni
End Class
