<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRMmail))
        Me.RTXmessaggio = New System.Windows.Forms.RichTextBox()
        Me.TXdestinatario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXoggetto = New System.Windows.Forms.TextBox()
        Me.BTAllega = New System.Windows.Forms.Button()
        Me.cercaallegato = New System.Windows.Forms.OpenFileDialog()
        Me.LWelenco = New System.Windows.Forms.ListView()
        Me.elencoimmaginiallegati = New System.Windows.Forms.ImageList(Me.components)
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel7 = New System.Windows.Forms.TableLayoutPanel()
        Me.LBX_esito = New System.Windows.Forms.ListBox()
        Me.BTtermina = New System.Windows.Forms.Button()
        Me.BTNinvio = New System.Windows.Forms.Button()
        Me.PB_mail = New System.Windows.Forms.ProgressBar()
        Me.TableLayoutPanel6 = New System.Windows.Forms.TableLayoutPanel()
        Me.BTFirma = New System.Windows.Forms.Button()
        Me.TableLayoutPanel5 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TableLayoutPanel7.SuspendLayout()
        Me.TableLayoutPanel6.SuspendLayout()
        Me.TableLayoutPanel5.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'RTXmessaggio
        '
        Me.RTXmessaggio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RTXmessaggio.Location = New System.Drawing.Point(4, 149)
        Me.RTXmessaggio.Margin = New System.Windows.Forms.Padding(4)
        Me.RTXmessaggio.Name = "RTXmessaggio"
        Me.RTXmessaggio.Size = New System.Drawing.Size(910, 326)
        Me.RTXmessaggio.TabIndex = 0
        Me.RTXmessaggio.Text = ""
        '
        'TXdestinatario
        '
        Me.TXdestinatario.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXdestinatario.Location = New System.Drawing.Point(69, 1)
        Me.TXdestinatario.Margin = New System.Windows.Forms.Padding(1)
        Me.TXdestinatario.Name = "TXdestinatario"
        Me.TXdestinatario.Size = New System.Drawing.Size(846, 22)
        Me.TXdestinatario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 1)
        Me.Label1.Margin = New System.Windows.Forms.Padding(1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "A:"
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 1)
        Me.Label2.Margin = New System.Windows.Forms.Padding(1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Oggetto:"
        '
        'TXoggetto
        '
        Me.TXoggetto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TXoggetto.Location = New System.Drawing.Point(69, 1)
        Me.TXoggetto.Margin = New System.Windows.Forms.Padding(1)
        Me.TXoggetto.Name = "TXoggetto"
        Me.TXoggetto.Size = New System.Drawing.Size(846, 22)
        Me.TXoggetto.TabIndex = 0
        '
        'BTAllega
        '
        Me.BTAllega.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTAllega.Location = New System.Drawing.Point(201, 1)
        Me.BTAllega.Margin = New System.Windows.Forms.Padding(1)
        Me.BTAllega.Name = "BTAllega"
        Me.BTAllega.Size = New System.Drawing.Size(98, 36)
        Me.BTAllega.TabIndex = 4
        Me.BTAllega.Text = "Allega"
        Me.BTAllega.UseVisualStyleBackColor = True
        '
        'cercaallegato
        '
        Me.cercaallegato.FileName = "cercaallegato"
        '
        'LWelenco
        '
        Me.LWelenco.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LWelenco.HideSelection = False
        Me.LWelenco.LargeImageList = Me.elencoimmaginiallegati
        Me.LWelenco.Location = New System.Drawing.Point(303, 3)
        Me.LWelenco.Name = "LWelenco"
        Me.LWelenco.Size = New System.Drawing.Size(610, 32)
        Me.LWelenco.SmallImageList = Me.elencoimmaginiallegati
        Me.LWelenco.TabIndex = 5
        Me.LWelenco.UseCompatibleStateImageBehavior = False
        Me.LWelenco.View = System.Windows.Forms.View.SmallIcon
        '
        'elencoimmaginiallegati
        '
        Me.elencoimmaginiallegati.ImageStream = CType(resources.GetObject("elencoimmaginiallegati.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.elencoimmaginiallegati.TransparentColor = System.Drawing.Color.Transparent
        Me.elencoimmaginiallegati.Images.SetKeyName(0, "iconapng.png")
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel7, 0, 6)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel6, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel4, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.RTXmessaggio, 0, 5)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 7
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(918, 554)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'TableLayoutPanel7
        '
        Me.TableLayoutPanel7.ColumnCount = 4
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 312.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 317.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 141.0!))
        Me.TableLayoutPanel7.Controls.Add(Me.LBX_esito, 0, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BTtermina, 2, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.BTNinvio, 3, 0)
        Me.TableLayoutPanel7.Controls.Add(Me.PB_mail, 1, 0)
        Me.TableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel7.Location = New System.Drawing.Point(3, 482)
        Me.TableLayoutPanel7.Name = "TableLayoutPanel7"
        Me.TableLayoutPanel7.RowCount = 1
        Me.TableLayoutPanel7.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel7.Size = New System.Drawing.Size(912, 69)
        Me.TableLayoutPanel7.TabIndex = 6
        '
        'LBX_esito
        '
        Me.LBX_esito.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.LBX_esito.FormattingEnabled = True
        Me.LBX_esito.ItemHeight = 16
        Me.LBX_esito.Location = New System.Drawing.Point(0, 0)
        Me.LBX_esito.Margin = New System.Windows.Forms.Padding(0)
        Me.LBX_esito.Name = "LBX_esito"
        Me.LBX_esito.Size = New System.Drawing.Size(312, 68)
        Me.LBX_esito.TabIndex = 8
        '
        'BTtermina
        '
        Me.BTtermina.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTtermina.Location = New System.Drawing.Point(630, 1)
        Me.BTtermina.Margin = New System.Windows.Forms.Padding(1)
        Me.BTtermina.Name = "BTtermina"
        Me.BTtermina.Size = New System.Drawing.Size(140, 67)
        Me.BTtermina.TabIndex = 6
        Me.BTtermina.Text = "Termina"
        Me.BTtermina.UseVisualStyleBackColor = True
        '
        'BTNinvio
        '
        Me.BTNinvio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNinvio.Location = New System.Drawing.Point(772, 1)
        Me.BTNinvio.Margin = New System.Windows.Forms.Padding(1)
        Me.BTNinvio.Name = "BTNinvio"
        Me.BTNinvio.Size = New System.Drawing.Size(139, 67)
        Me.BTNinvio.TabIndex = 0
        Me.BTNinvio.Text = "Invia"
        Me.BTNinvio.UseVisualStyleBackColor = True
        '
        'PB_mail
        '
        Me.PB_mail.Location = New System.Drawing.Point(313, 1)
        Me.PB_mail.Margin = New System.Windows.Forms.Padding(1)
        Me.PB_mail.Name = "PB_mail"
        Me.PB_mail.Size = New System.Drawing.Size(315, 67)
        Me.PB_mail.TabIndex = 9
        '
        'TableLayoutPanel6
        '
        Me.TableLayoutPanel6.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel6.ColumnCount = 4
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel6.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Controls.Add(Me.LWelenco, 3, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.BTAllega, 2, 0)
        Me.TableLayoutPanel6.Controls.Add(Me.BTFirma, 1, 0)
        Me.TableLayoutPanel6.Location = New System.Drawing.Point(1, 106)
        Me.TableLayoutPanel6.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel6.Name = "TableLayoutPanel6"
        Me.TableLayoutPanel6.RowCount = 1
        Me.TableLayoutPanel6.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel6.Size = New System.Drawing.Size(916, 38)
        Me.TableLayoutPanel6.TabIndex = 4
        '
        'BTFirma
        '
        Me.BTFirma.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.BTFirma.Location = New System.Drawing.Point(101, 1)
        Me.BTFirma.Margin = New System.Windows.Forms.Padding(1)
        Me.BTFirma.Name = "BTFirma"
        Me.BTFirma.Size = New System.Drawing.Size(98, 36)
        Me.BTFirma.TabIndex = 0
        Me.BTFirma.Text = "Firma"
        Me.BTFirma.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel5
        '
        Me.TableLayoutPanel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel5.ColumnCount = 2
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.532751!))
        Me.TableLayoutPanel5.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.46725!))
        Me.TableLayoutPanel5.Controls.Add(Me.TXoggetto, 1, 0)
        Me.TableLayoutPanel5.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel5.Location = New System.Drawing.Point(1, 81)
        Me.TableLayoutPanel5.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel5.Name = "TableLayoutPanel5"
        Me.TableLayoutPanel5.RowCount = 1
        Me.TableLayoutPanel5.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel5.Size = New System.Drawing.Size(916, 23)
        Me.TableLayoutPanel5.TabIndex = 3
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 7.532751!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.46725!))
        Me.TableLayoutPanel4.Controls.Add(Me.TXdestinatario, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(1, 56)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(916, 23)
        Me.TableLayoutPanel4.TabIndex = 2
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110.0!))
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(1, 1)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(916, 28)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(1, 31)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(1)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(916, 23)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'FRMmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(918, 554)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRMmail"
        Me.Text = "Invio Mail"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel7.ResumeLayout(False)
        Me.TableLayoutPanel6.ResumeLayout(False)
        Me.TableLayoutPanel5.ResumeLayout(False)
        Me.TableLayoutPanel5.PerformLayout()
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RTXmessaggio As RichTextBox
    Friend WithEvents TXdestinatario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXoggetto As TextBox
    Friend WithEvents BTAllega As Button
    Friend WithEvents cercaallegato As OpenFileDialog
    Friend WithEvents LWelenco As ListView
    Friend WithEvents elencoimmaginiallegati As ImageList
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel6 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel5 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel4 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents BTFirma As Button
    Friend WithEvents TableLayoutPanel7 As TableLayoutPanel
    Friend WithEvents LBX_esito As ListBox
    Friend WithEvents BTtermina As Button
    Friend WithEvents BTNinvio As Button
    Friend WithEvents PB_mail As ProgressBar
End Class
