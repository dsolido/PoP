<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRapportoQualita
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRapportoQualita))
        Me.dtQuestionarioVotazioneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.dsControlloQualita = New PoP2.Comuni.DSControlloQualita()
        Me.cmbClientecheharisposto = New System.Windows.Forms.ComboBox()
        Me.cmbDateDisponibili = New System.Windows.Forms.ComboBox()
        Me.cmbTipoSondaggio = New System.Windows.Forms.ComboBox()
        Me.DtCqQuestionarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnGeneraReport = New System.Windows.Forms.Button()
        Me.btnTermina = New System.Windows.Forms.Button()
        Me.taQuestionarioVotazione = New PoP2.Comuni.DSControlloQualitaTableAdapters.taQuestionarioVotazione()
        Me.TaCqQuestionario = New PoP2.Comuni.DSControlloQualitaTableAdapters.taCqQuestionario()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btnStampatutto = New System.Windows.Forms.Button()
        Me.tabRapporti = New System.Windows.Forms.TabControl()
        Me.tpRapporto = New System.Windows.Forms.TabPage()
        Me.tpElencoRapporti = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dgwSocieta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwidCli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwDatasondaggio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwidsondaggio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwEsitosondaggio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dtQuestionarioVotazioneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dsControlloQualita, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtCqQuestionarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabRapporti.SuspendLayout()
        Me.tpRapporto.SuspendLayout()
        Me.tpElencoRapporti.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtQuestionarioVotazioneBindingSource
        '
        Me.dtQuestionarioVotazioneBindingSource.DataMember = "dtQuestionarioVotazione"
        Me.dtQuestionarioVotazioneBindingSource.DataSource = Me.dsControlloQualita
        '
        'dsControlloQualita
        '
        Me.dsControlloQualita.DataSetName = "dsControlloQualita"
        Me.dsControlloQualita.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cmbClientecheharisposto
        '
        Me.cmbClientecheharisposto.FormattingEnabled = True
        Me.cmbClientecheharisposto.Location = New System.Drawing.Point(400, 73)
        Me.cmbClientecheharisposto.Name = "cmbClientecheharisposto"
        Me.cmbClientecheharisposto.Size = New System.Drawing.Size(391, 28)
        Me.cmbClientecheharisposto.TabIndex = 2
        '
        'cmbDateDisponibili
        '
        Me.cmbDateDisponibili.FormattingEnabled = True
        Me.cmbDateDisponibili.Location = New System.Drawing.Point(240, 73)
        Me.cmbDateDisponibili.Name = "cmbDateDisponibili"
        Me.cmbDateDisponibili.Size = New System.Drawing.Size(154, 28)
        Me.cmbDateDisponibili.TabIndex = 1
        '
        'cmbTipoSondaggio
        '
        Me.cmbTipoSondaggio.DataSource = Me.DtCqQuestionarioBindingSource
        Me.cmbTipoSondaggio.DisplayMember = "descrizione"
        Me.cmbTipoSondaggio.FormattingEnabled = True
        Me.cmbTipoSondaggio.Location = New System.Drawing.Point(13, 73)
        Me.cmbTipoSondaggio.Name = "cmbTipoSondaggio"
        Me.cmbTipoSondaggio.Size = New System.Drawing.Size(221, 28)
        Me.cmbTipoSondaggio.TabIndex = 0
        Me.cmbTipoSondaggio.ValueMember = "id"
        '
        'DtCqQuestionarioBindingSource
        '
        Me.DtCqQuestionarioBindingSource.DataMember = "dtCqQuestionario"
        Me.DtCqQuestionarioBindingSource.DataSource = Me.dsControlloQualita
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Tipo di Sondaggio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(243, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Date disponibili"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(407, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(136, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cliente disponibile"
        '
        'btnGeneraReport
        '
        Me.btnGeneraReport.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_stampa48
        Me.btnGeneraReport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnGeneraReport.Location = New System.Drawing.Point(349, 107)
        Me.btnGeneraReport.Name = "btnGeneraReport"
        Me.btnGeneraReport.Size = New System.Drawing.Size(178, 59)
        Me.btnGeneraReport.TabIndex = 3
        Me.btnGeneraReport.Text = "Genera Report"
        Me.btnGeneraReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGeneraReport.UseVisualStyleBackColor = True
        '
        'btnTermina
        '
        Me.btnTermina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.btnTermina.Location = New System.Drawing.Point(717, 107)
        Me.btnTermina.Name = "btnTermina"
        Me.btnTermina.Size = New System.Drawing.Size(73, 58)
        Me.btnTermina.TabIndex = 7
        Me.btnTermina.UseVisualStyleBackColor = True
        '
        'taQuestionarioVotazione
        '
        Me.taQuestionarioVotazione.ClearBeforeFill = True
        '
        'TaCqQuestionario
        '
        Me.TaCqQuestionario.ClearBeforeFill = True
        '
        'Timer1
        '
        '
        'btnStampatutto
        '
        Me.btnStampatutto.Image = Global.PoP2.Comuni.My.Resources.Resources.omino_stampa48
        Me.btnStampatutto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnStampatutto.Location = New System.Drawing.Point(533, 107)
        Me.btnStampatutto.Name = "btnStampatutto"
        Me.btnStampatutto.Size = New System.Drawing.Size(178, 59)
        Me.btnStampatutto.TabIndex = 8
        Me.btnStampatutto.Text = "Stampa tutte le schede"
        Me.btnStampatutto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnStampatutto.UseVisualStyleBackColor = True
        '
        'tabRapporti
        '
        Me.tabRapporti.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabRapporti.Controls.Add(Me.tpRapporto)
        Me.tabRapporti.Controls.Add(Me.tpElencoRapporti)
        Me.tabRapporti.Location = New System.Drawing.Point(10, 199)
        Me.tabRapporti.Name = "tabRapporti"
        Me.tabRapporti.SelectedIndex = 0
        Me.tabRapporti.Size = New System.Drawing.Size(780, 603)
        Me.tabRapporti.TabIndex = 9
        '
        'tpRapporto
        '
        Me.tpRapporto.Controls.Add(Me.ReportViewer1)
        Me.tpRapporto.Location = New System.Drawing.Point(4, 29)
        Me.tpRapporto.Name = "tpRapporto"
        Me.tpRapporto.Padding = New System.Windows.Forms.Padding(3)
        Me.tpRapporto.Size = New System.Drawing.Size(772, 570)
        Me.tpRapporto.TabIndex = 0
        Me.tpRapporto.Text = "Rapporto Singolo"
        Me.tpRapporto.UseVisualStyleBackColor = True
        '
        'tpElencoRapporti
        '
        Me.tpElencoRapporti.Controls.Add(Me.DataGridView1)
        Me.tpElencoRapporti.Location = New System.Drawing.Point(4, 29)
        Me.tpElencoRapporti.Name = "tpElencoRapporti"
        Me.tpElencoRapporti.Padding = New System.Windows.Forms.Padding(3)
        Me.tpElencoRapporti.Size = New System.Drawing.Size(772, 570)
        Me.tpElencoRapporti.TabIndex = 1
        Me.tpElencoRapporti.Text = "Elenco Rapporti"
        Me.tpElencoRapporti.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.dtQuestionarioVotazioneBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "PoP2._0.rpt_rapportoQualita.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(3, 3)
        Me.ReportViewer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(766, 564)
        Me.ReportViewer1.TabIndex = 5
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwSocieta, Me.dgwidCli, Me.dgwDatasondaggio, Me.dgwidsondaggio, Me.dgwEsitosondaggio})
        Me.DataGridView1.Location = New System.Drawing.Point(15, 21)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(738, 535)
        Me.DataGridView1.TabIndex = 0
        '
        'dgwSocieta
        '
        Me.dgwSocieta.HeaderText = "Società"
        Me.dgwSocieta.Name = "dgwSocieta"
        '
        'dgwidCli
        '
        Me.dgwidCli.HeaderText = "idcliente"
        Me.dgwidCli.Name = "dgwidCli"
        Me.dgwidCli.Visible = False
        '
        'dgwDatasondaggio
        '
        Me.dgwDatasondaggio.HeaderText = "Data"
        Me.dgwDatasondaggio.Name = "dgwDatasondaggio"
        Me.dgwDatasondaggio.Visible = False
        '
        'dgwidsondaggio
        '
        Me.dgwidsondaggio.HeaderText = "idSondaggio"
        Me.dgwidsondaggio.Name = "dgwidsondaggio"
        Me.dgwidsondaggio.Visible = False
        '
        'dgwEsitosondaggio
        '
        Me.dgwEsitosondaggio.HeaderText = "Media Risultato"
        Me.dgwEsitosondaggio.Name = "dgwEsitosondaggio"
        '
        'FrmRapportoQualita
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 814)
        Me.Controls.Add(Me.tabRapporti)
        Me.Controls.Add(Me.btnStampatutto)
        Me.Controls.Add(Me.btnTermina)
        Me.Controls.Add(Me.btnGeneraReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTipoSondaggio)
        Me.Controls.Add(Me.cmbDateDisponibili)
        Me.Controls.Add(Me.cmbClientecheharisposto)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FrmRapportoQualita"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rapporti Qualità"
        CType(Me.dtQuestionarioVotazioneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dsControlloQualita, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtCqQuestionarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabRapporti.ResumeLayout(False)
        Me.tpRapporto.ResumeLayout(False)
        Me.tpElencoRapporti.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtQuestionarioVotazioneBindingSource As BindingSource
    Friend WithEvents dsControlloQualita As dsControlloQualita
    Friend WithEvents taQuestionarioVotazione As dsControlloQualitaTableAdapters.taQuestionarioVotazione
    Friend WithEvents cmbClientecheharisposto As ComboBox
    Friend WithEvents cmbDateDisponibili As ComboBox
    Friend WithEvents cmbTipoSondaggio As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnGeneraReport As Button
    Friend WithEvents btnTermina As Button
    Friend WithEvents DtCqQuestionarioBindingSource As BindingSource
    Friend WithEvents TaCqQuestionario As dsControlloQualitaTableAdapters.taCqQuestionario
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnStampatutto As Button
    Friend WithEvents tabRapporti As TabControl
    Friend WithEvents tpRapporto As TabPage
    Friend WithEvents ReportViewer1 As ReportViewer
    Friend WithEvents tpElencoRapporti As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dgwSocieta As DataGridViewTextBoxColumn
    Friend WithEvents dgwidCli As DataGridViewTextBoxColumn
    Friend WithEvents dgwDatasondaggio As DataGridViewTextBoxColumn
    Friend WithEvents dgwidsondaggio As DataGridViewTextBoxColumn
    Friend WithEvents dgwEsitosondaggio As DataGridViewTextBoxColumn
End Class
