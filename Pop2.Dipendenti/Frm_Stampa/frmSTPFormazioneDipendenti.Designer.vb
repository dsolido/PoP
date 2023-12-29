<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSTPFormazioneDipendenti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSTPFormazioneDipendenti))
        Me.dtFFormazioneScadenzeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSwebcondiviso = New PoP2.Comuni.DSwebcondiviso()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.taFormazioneScadenze = New PoP2.Comuni.DSwebcondivisoTableAdapters.taFormazioneScadenze()
        CType(Me.dtFFormazioneScadenzeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSwebcondiviso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtFFormazioneScadenzeBindingSource
        '
        Me.dtFFormazioneScadenzeBindingSource.DataMember = "dtFFormazioneScadenze"
        Me.dtFFormazioneScadenzeBindingSource.DataSource = Me.DSwebcondiviso
        '
        'DSwebcondiviso
        '
        Me.DSwebcondiviso.DataSetName = "DSwebcondiviso"
        Me.DSwebcondiviso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.dtFFormazioneScadenzeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2.Dipendenti.rpFormazione.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 12)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(910, 858)
        Me.ReportViewer1.TabIndex = 0
        '
        'taFormazioneScadenze
        '
        Me.taFormazioneScadenze.ClearBeforeFill = True
        '
        'frmSTPFormazioneDipendenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(934, 882)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSTPFormazioneDipendenti"
        Me.Text = "frmSTPFormazioneDipendenti"
        CType(Me.dtFFormazioneScadenzeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSwebcondiviso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents dtFFormazioneScadenzeBindingSource As BindingSource
    Friend WithEvents DSwebcondiviso As DSwebcondiviso
    Friend WithEvents taFormazioneScadenze As DSwebcondivisoTableAdapters.taFormazioneScadenze
End Class
