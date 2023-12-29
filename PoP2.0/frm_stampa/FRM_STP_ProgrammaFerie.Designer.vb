<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_STP_ProgrammaFerie
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_STP_ProgrammaFerie))
        Me.BS_ProgrammazioneFerie = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_Stampe = New PoP2.Comuni.DS_Stampe()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        CType(Me.BS_ProgrammazioneFerie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_Stampe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BS_ProgrammazioneFerie
        '
        Me.BS_ProgrammazioneFerie.DataMember = "DT_ProgrammazioneFerie"
        Me.BS_ProgrammazioneFerie.DataSource = Me.DS_Stampe
        '
        'DS_Stampe
        '
        Me.DS_Stampe.DataSetName = "DS_Stampe"
        Me.DS_Stampe.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DS_programmazione"
        ReportDataSource1.Value = Me.BS_ProgrammazioneFerie
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_programmaferie.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        'Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(652, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'FRM_STP_ProgrammaFerie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRM_STP_ProgrammaFerie"
        Me.Text = "Programmazione delle Ferie"
        CType(Me.BS_ProgrammazioneFerie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_Stampe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents BS_ProgrammazioneFerie As BindingSource
    Friend WithEvents DS_Stampe As DS_Stampe
End Class
