<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_stp_Tesserino
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
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BS_tesserino = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.TA_tesserino = New PoP2.Comuni.DS_utentiTableAdapters.TA_tesserino()
        CType(Me.BS_tesserino, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "DataSet1"
        ReportDataSource2.Value = Me.BS_tesserino
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2.Dipendenti.RP_Tesserino.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(482, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'BS_tesserino
        '
        Me.BS_tesserino.DataMember = "DT_Tesserino"
        Me.BS_tesserino.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TA_tesserino
        '
        Me.TA_tesserino.ClearBeforeFill = True
        '
        'FRM_stp_Tesserino
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FRM_stp_Tesserino"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FRM_stp_Tesserino"
        CType(Me.BS_tesserino, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BS_tesserino As BindingSource
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents TA_tesserino As DS_utentiTableAdapters.TA_tesserino
End Class
