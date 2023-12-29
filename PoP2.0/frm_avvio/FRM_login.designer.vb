<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")>
Partial Class Frm_login
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents OK As System.Windows.Forms.Button
    Friend WithEvents Cancel As System.Windows.Forms.Button

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_login))
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.OK = New System.Windows.Forms.Button()
        Me.Cancel = New System.Windows.Forms.Button()
        Me.DS_servizio = New PoP2.Comuni.DS_servizio()
        Me.BS_credenziali = New System.Windows.Forms.BindingSource(Me.components)
        Me.TA_credenziali = New PoP2.Comuni.DS_servizioTableAdapters.TA_credenziali()
        Me.TableAdapterManager = New PoP2.Comuni.DS_servizioTableAdapters.TableAdapterManager()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_servizio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_credenziali, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), System.Drawing.Image)
        Me.LogoPictureBox.Location = New System.Drawing.Point(3, 1)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(165, 193)
        Me.LogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(169, 5)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&Nome utente"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordLabel.Location = New System.Drawing.Point(169, 70)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(220, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&Password"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.Location = New System.Drawing.Point(169, 31)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(220, 26)
        Me.UsernameTextBox.TabIndex = 1
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.Location = New System.Drawing.Point(169, 96)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(220, 26)
        Me.PasswordTextBox.TabIndex = 3
        '
        'OK
        '
        Me.OK.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.ominoConferma48
        Me.OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.OK.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.OK.FlatAppearance.BorderSize = 0
        Me.OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OK.Location = New System.Drawing.Point(197, 132)
        Me.OK.Name = "OK"
        Me.OK.Size = New System.Drawing.Size(52, 52)
        Me.OK.TabIndex = 4
        '
        'Cancel
        '
        Me.Cancel.BackgroundImage = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.Cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel.FlatAppearance.BorderSize = 0
        Me.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Cancel.Location = New System.Drawing.Point(300, 132)
        Me.Cancel.Name = "Cancel"
        Me.Cancel.Size = New System.Drawing.Size(52, 52)
        Me.Cancel.TabIndex = 5
        '
        'DS_servizio
        '
        Me.DS_servizio.DataSetName = "DS_servizio"
        Me.DS_servizio.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_credenziali
        '
        Me.BS_credenziali.DataMember = "DT_credenziali"
        Me.BS_credenziali.DataSource = Me.DS_servizio
        '
        'TA_credenziali
        '
        Me.TA_credenziali.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = PoP2.Comuni.DS_servizioTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Frm_login
        '
        Me.AcceptButton = Me.OK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel
        Me.ClientSize = New System.Drawing.Size(421, 214)
        Me.ControlBox = False
        Me.Controls.Add(Me.Cancel)
        Me.Controls.Add(Me.OK)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Frm_login"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credenziali di accesso"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_servizio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_credenziali, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DS_servizio As DS_servizio
    Friend WithEvents BS_credenziali As BindingSource
    Friend WithEvents TA_credenziali As DS_servizioTableAdapters.TA_credenziali
    Friend WithEvents TableAdapterManager As DS_servizioTableAdapters.TableAdapterManager
End Class
