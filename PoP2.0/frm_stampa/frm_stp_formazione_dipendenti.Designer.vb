<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_stp_formazione_dipendenti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_stp_formazione_dipendenti))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DS_personale = New PoP2.Comuni.DS_personale()
        Me.DT_UtentiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_UtentiTableAdapter = New PoP2.Comuni.DS_personaleTableAdapters.DT_UtentiTableAdapter()
        Me.DT_utenti_forBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DT_utenti_for_TA = New PoP2.Comuni.DS_personaleTableAdapters.DT_utenti_for_TA()
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_UtentiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_utenti_forBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_Utenti"
        ReportDataSource1.Value = Me.DT_UtentiBindingSource
        ReportDataSource2.Name = "DS_formaz"
        ReportDataSource2.Value = Me.DT_utenti_forBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.formazione_dipendenti.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        'Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(584, 361)
        Me.ReportViewer1.TabIndex = 0
        '
        'DS_personale
        '
        Me.DS_personale.DataSetName = "DS_personale"
        Me.DS_personale.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_UtentiBindingSource
        '
        Me.DT_UtentiBindingSource.DataMember = "DT_Utenti"
        Me.DT_UtentiBindingSource.DataSource = Me.DS_personale
        '
        'DT_UtentiTableAdapter
        '
        Me.DT_UtentiTableAdapter.ClearBeforeFill = True
        '
        'DT_utenti_forBindingSource
        '
        Me.DT_utenti_forBindingSource.DataMember = "DT_utenti_for"
        Me.DT_utenti_forBindingSource.DataSource = Me.DS_personale
        '
        'DT_utenti_for_TA
        '
        Me.DT_utenti_for_TA.ClearBeforeFill = True
        '
        'frm_stp_formazione_dipendenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_stp_formazione_dipendenti"
        Me.Text = "Stampa formazioni dipendente"
        CType(Me.DS_personale, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_UtentiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_utenti_forBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DT_UtentiBindingSource As BindingSource
    Friend WithEvents DS_personale As DS_personale
    Friend WithEvents DT_utenti_forBindingSource As BindingSource
    Friend WithEvents DT_UtentiTableAdapter As DS_personaleTableAdapters.DT_UtentiTableAdapter
    Friend WithEvents DT_utenti_for_TA As DS_personaleTableAdapters.DT_utenti_for_TA
End Class
