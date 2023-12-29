<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_STP_elencodipendenti
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
        Me.BS_dipendenti = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_utenti = New PoP2.Comuni.DS_utenti()
        Me.DT_aziendaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_azienda = New PoP2.Comuni.DS_azienda()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TA_utenti = New PoP2.Comuni.DS_utentiTableAdapters.TA_utenti()
        Me.TA_azienda = New PoP2.Comuni.DS_aziendaTableAdapters.TA_azienda()
        CType(Me.BS_dipendenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DT_aziendaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BS_dipendenti
        '
        Me.BS_dipendenti.DataMember = "DT_utenti"
        Me.BS_dipendenti.DataSource = Me.DS_utenti
        '
        'DS_utenti
        '
        Me.DS_utenti.DataSetName = "DS_utenti"
        Me.DS_utenti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DT_aziendaBindingSource
        '
        Me.DT_aziendaBindingSource.DataMember = "DT_azienda"
        Me.DT_aziendaBindingSource.DataSource = Me.DS_azienda
        '
        'DS_azienda
        '
        Me.DS_azienda.DataSetName = "DS_azienda"
        Me.DS_azienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_utenti"
        ReportDataSource1.Value = Me.BS_dipendenti
        ReportDataSource2.Name = "DS_azienda"
        ReportDataSource2.Value = Me.DT_aziendaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_elencodipendenti.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        'Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(659, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'TA_utenti
        '
        Me.TA_utenti.ClearBeforeFill = True
        '
        'TA_azienda
        '
        Me.TA_azienda.ClearBeforeFill = True
        '
        'FRM_STP_elencodipendenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FRM_STP_elencodipendenti"
        Me.Text = "Elenco dei dipendenti"
        CType(Me.BS_dipendenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_utenti, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DT_aziendaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BS_dipendenti As BindingSource
    Friend WithEvents DS_utenti As DS_utenti
    Friend WithEvents DT_aziendaBindingSource As BindingSource
    Friend WithEvents DS_azienda As DS_azienda
    Friend WithEvents TA_utenti As DS_utentiTableAdapters.TA_utenti
    Friend WithEvents TA_azienda As DS_aziendaTableAdapters.TA_azienda
End Class
