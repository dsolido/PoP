<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
    Friend WithEvents ApplicationTitle As System.Windows.Forms.Label
    Friend WithEvents Version As System.Windows.Forms.Label
    Friend WithEvents Copyright As System.Windows.Forms.Label
    Friend WithEvents MainLayoutPanel As System.Windows.Forms.TableLayoutPanel

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MainLayoutPanel = New System.Windows.Forms.TableLayoutPanel()
        Me.lbElencoAggiornamenti = New System.Windows.Forms.ListBox()
        Me.DtInformazioniReadmeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DSservizioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_servizio = New PoP2.Comuni.DS_servizio()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Version = New System.Windows.Forms.Label()
        Me.ApplicationTitle = New System.Windows.Forms.Label()
        Me.Copyright = New System.Windows.Forms.Label()
        Me.TaInformazioniReadme = New PoP2.Comuni.DS_servizioTableAdapters.taInformazioniReadme()
        Me.MainLayoutPanel.SuspendLayout()
        CType(Me.DtInformazioniReadmeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DSservizioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_servizio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MainLayoutPanel
        '
        Me.MainLayoutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.MainLayoutPanel.ColumnCount = 2
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 436.0!))
        Me.MainLayoutPanel.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.MainLayoutPanel.Controls.Add(Me.lbElencoAggiornamenti, 0, 0)
        Me.MainLayoutPanel.Controls.Add(Me.TableLayoutPanel1, 1, 0)
        Me.MainLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainLayoutPanel.Location = New System.Drawing.Point(0, 0)
        Me.MainLayoutPanel.Name = "MainLayoutPanel"
        Me.MainLayoutPanel.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 211.0!))
        Me.MainLayoutPanel.Size = New System.Drawing.Size(670, 303)
        Me.MainLayoutPanel.TabIndex = 0
        '
        'lbElencoAggiornamenti
        '
        Me.lbElencoAggiornamenti.DataSource = Me.DtInformazioniReadmeBindingSource
        Me.lbElencoAggiornamenti.DisplayMember = "dettaglio"
        Me.lbElencoAggiornamenti.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbElencoAggiornamenti.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lbElencoAggiornamenti.FormattingEnabled = True
        Me.lbElencoAggiornamenti.ItemHeight = 16
        Me.lbElencoAggiornamenti.Location = New System.Drawing.Point(3, 3)
        Me.lbElencoAggiornamenti.Name = "lbElencoAggiornamenti"
        Me.lbElencoAggiornamenti.Size = New System.Drawing.Size(430, 297)
        Me.lbElencoAggiornamenti.TabIndex = 2
        '
        'DtInformazioniReadmeBindingSource
        '
        Me.DtInformazioniReadmeBindingSource.DataMember = "dtInformazioniReadme"
        Me.DtInformazioniReadmeBindingSource.DataSource = Me.DSservizioBindingSource
        '
        'DSservizioBindingSource
        '
        Me.DSservizioBindingSource.DataSource = Me.DS_servizio
        Me.DSservizioBindingSource.Position = 0
        '
        'DS_servizio
        '
        Me.DS_servizio.DataSetName = "DS_servizio"
        Me.DS_servizio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.logocolor
        Me.TableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Version, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.ApplicationTitle, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Copyright, 0, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(439, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.06522!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.93478!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(227, 297)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'Version
        '
        Me.Version.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Version.BackColor = System.Drawing.Color.Transparent
        Me.Version.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Version.Location = New System.Drawing.Point(3, 241)
        Me.Version.Name = "Version"
        Me.Version.Size = New System.Drawing.Size(221, 20)
        Me.Version.TabIndex = 1
        Me.Version.Text = "Versione {0}.{1:00}"
        '
        'ApplicationTitle
        '
        Me.ApplicationTitle.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ApplicationTitle.BackColor = System.Drawing.Color.Transparent
        Me.ApplicationTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ApplicationTitle.Location = New System.Drawing.Point(3, 33)
        Me.ApplicationTitle.Name = "ApplicationTitle"
        Me.ApplicationTitle.Size = New System.Drawing.Size(221, 160)
        Me.ApplicationTitle.TabIndex = 0
        Me.ApplicationTitle.Text = "Titolo applicazione"
        Me.ApplicationTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'Copyright
        '
        Me.Copyright.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Copyright.BackColor = System.Drawing.Color.Transparent
        Me.Copyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Copyright.Location = New System.Drawing.Point(3, 276)
        Me.Copyright.Name = "Copyright"
        Me.Copyright.Size = New System.Drawing.Size(221, 21)
        Me.Copyright.TabIndex = 2
        Me.Copyright.Text = "Copyright"
        '
        'TaInformazioniReadme
        '
        Me.TaInformazioniReadme.ClearBeforeFill = True
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 303)
        Me.ControlBox = False
        Me.Controls.Add(Me.MainLayoutPanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.MainLayoutPanel.ResumeLayout(False)
        CType(Me.DtInformazioniReadmeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DSservizioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_servizio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbElencoAggiornamenti As ListBox
    Friend WithEvents DSservizioBindingSource As BindingSource
    Friend WithEvents DS_servizio As DS_servizio
    Friend WithEvents DtInformazioniReadmeBindingSource As BindingSource
    Friend WithEvents TaInformazioniReadme As DS_servizioTableAdapters.taInformazioniReadme
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
End Class
