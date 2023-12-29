<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRMstpclienticonpec
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMstpclienticonpec))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.BSclientipec = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_clienti = New PoP2.Comuni.DS_clienti()
        Me.TAclienticonpec = New PoP2.Comuni.DS_clientiTableAdapters.TAclienticonpec()
        CType(Me.BSclientipec, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Clienticonposta"
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.RP_ClientiPec.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(607, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'BSclientipec
        '
        Me.BSclientipec.DataMember = "DTclienticonpec"
        Me.BSclientipec.DataSource = Me.DS_clienti
        '
        'DS_clienti
        '
        Me.DS_clienti.DataSetName = "DS_clienti"
        Me.DS_clienti.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TAclienticonpec
        '
        Me.TAclienticonpec.ClearBeforeFill = True
        '
        'FRMstpclienticonpec
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FRMstpclienticonpec"
        Me.Text = "Elenco Clienti con PEC"
        CType(Me.BSclientipec, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_clienti, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DS_clienti As DS_clienti
    Friend WithEvents TAclienticonpec As DS_clientiTableAdapters.TAclienticonpec
    Friend WithEvents BSclientipec As BindingSource
End Class
