<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stp_sca_ins
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stp_sca_ins))
        Me.DT_clienti_scadenzeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_contabilita = New PoP2.Comuni.DS_contabilita()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TA_clienti_scadenze = New PoP2.Comuni.DS_contabilitaTableAdapters.TA_clienti_scadenze()
        CType(Me.DT_clienti_scadenzeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_contabilita, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DT_clienti_scadenzeBindingSource
        '
        Me.DT_clienti_scadenzeBindingSource.DataMember = "DT_clienti_scadenze"
        Me.DT_clienti_scadenzeBindingSource.DataSource = Me.DS_contabilita
        '
        'DS_contabilita
        '
        Me.DS_contabilita.DataSetName = "DS_contabilita"
        Me.DS_contabilita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_stp"
        ReportDataSource1.Value = Me.DT_clienti_scadenzeBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.fattura_elenco_scadenze.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(600, 420)
        Me.ReportViewer1.TabIndex = 0
        '
        'TA_clienti_scadenze
        '
        Me.TA_clienti_scadenze.ClearBeforeFill = True
        '
        'frm_stp_sca_ins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 420)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stp_sca_ins"
        Me.Text = "Stampa Scadenze Cliente"
        CType(Me.DT_clienti_scadenzeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_contabilita, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_clienti_scadenzeBindingSource As BindingSource
    Friend WithEvents DS_contabilita As DS_contabilita
    Friend WithEvents TA_clienti_scadenze As DS_contabilitaTableAdapters.TA_clienti_scadenze
End Class
