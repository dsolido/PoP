<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class STP_ElencoAssenti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(STP_ElencoAssenti))
        Me.BS_agenda = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_ag = New PoP2.Comuni.DS_ag()
        Me.BS_azienda = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_azienda = New PoP2.Comuni.DS_azienda()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TA_agenda = New PoP2.Comuni.DS_agTableAdapters.TA_agenda()
        Me.TA_azienda = New PoP2.Comuni.DS_aziendaTableAdapters.TA_azienda()
        CType(Me.BS_agenda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_azienda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BS_agenda
        '
        Me.BS_agenda.DataMember = "DT_agenda"
        Me.BS_agenda.DataSource = Me.DS_ag
        '
        'DS_ag
        '
        Me.DS_ag.DataSetName = "DS_ag"
        Me.DS_ag.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_azienda
        '
        Me.BS_azienda.DataMember = "DT_azienda"
        Me.BS_azienda.DataSource = Me.DS_azienda
        '
        'DS_azienda
        '
        Me.DS_azienda.DataSetName = "DS_azienda"
        Me.DS_azienda.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.DocumentMapWidth = 98
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.BS_agenda
        ReportDataSource2.Name = "DS_azienda"
        ReportDataSource2.Value = Me.BS_azienda
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_ElencoAssenti.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'TA_agenda
        '
        Me.TA_agenda.ClearBeforeFill = True
        '
        'TA_azienda
        '
        Me.TA_azienda.ClearBeforeFill = True
        '
        'STP_ElencoAssenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "STP_ElencoAssenti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Stampa elenco degli assenti"
        CType(Me.BS_agenda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_ag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_azienda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_azienda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BS_agenda As BindingSource
    Friend WithEvents DS_ag As DS_ag
    Friend WithEvents BS_azienda As BindingSource
    Friend WithEvents DS_azienda As DS_azienda
    Friend WithEvents TA_agenda As DS_agTableAdapters.TA_agenda
    Friend WithEvents TA_azienda As DS_aziendaTableAdapters.TA_azienda
End Class
