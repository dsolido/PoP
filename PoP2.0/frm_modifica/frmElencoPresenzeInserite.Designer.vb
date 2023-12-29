<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElencoPresenzeInserite
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmElencoPresenzeInserite))
        Me.dgwElencoPresenze = New System.Windows.Forms.DataGridView()
        Me.BDnavigazione = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BTN_elimina = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BTN_aggiungi = New System.Windows.Forms.ToolStripButton()
        Me.BTN_salva = New System.Windows.Forms.ToolStripButton()
        Me.BTN_termina = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgwElencoPresenze, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BDnavigazione, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BDnavigazione.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgwElencoPresenze
        '
        Me.dgwElencoPresenze.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgwElencoPresenze.Location = New System.Drawing.Point(12, 83)
        Me.dgwElencoPresenze.Name = "dgwElencoPresenze"
        Me.dgwElencoPresenze.Size = New System.Drawing.Size(776, 333)
        Me.dgwElencoPresenze.TabIndex = 0
        '
        'BDnavigazione
        '
        Me.BDnavigazione.AddNewItem = Nothing
        Me.BDnavigazione.AutoSize = False
        Me.BDnavigazione.CountItem = Me.BindingNavigatorCountItem
        Me.BDnavigazione.DeleteItem = Me.BTN_elimina
        Me.BDnavigazione.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BDnavigazione.ImageScalingSize = New System.Drawing.Size(80, 80)
        Me.BDnavigazione.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BTN_aggiungi, Me.BTN_elimina, Me.BTN_salva, Me.BTN_termina})
        Me.BDnavigazione.Location = New System.Drawing.Point(0, 656)
        Me.BDnavigazione.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BDnavigazione.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BDnavigazione.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BDnavigazione.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BDnavigazione.Name = "BDnavigazione"
        Me.BDnavigazione.PositionItem = Me.BindingNavigatorPositionItem
        Me.BDnavigazione.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.BDnavigazione.Size = New System.Drawing.Size(800, 72)
        Me.BDnavigazione.TabIndex = 9
        Me.BDnavigazione.Text = "Navigatore"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(34, 69)
        Me.BindingNavigatorCountItem.Text = "di {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Numero totale di elementi"
        '
        'BTN_elimina
        '
        Me.BTN_elimina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTN_elimina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominocestino2
        Me.BTN_elimina.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BTN_elimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_elimina.Margin = New System.Windows.Forms.Padding(0)
        Me.BTN_elimina.Name = "BTN_elimina"
        Me.BTN_elimina.Size = New System.Drawing.Size(79, 72)
        Me.BTN_elimina.Text = "ToolStripButton1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = Global.PoP2.Comuni.My.Resources.Resources.freccia48sx
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(84, 69)
        Me.BindingNavigatorMoveFirstItem.Text = "Sposta in prima posizione"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = Global.PoP2.Comuni.My.Resources.Resources.freccia48sx
        Me.BindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(52, 69)
        Me.BindingNavigatorMovePreviousItem.Text = "Sposta indietro"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 72)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posizione"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posizione corrente"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 72)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = Global.PoP2.Comuni.My.Resources.Resources.freccia48dx
        Me.BindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(52, 69)
        Me.BindingNavigatorMoveNextItem.Text = "Sposta avanti"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = Global.PoP2.Comuni.My.Resources.Resources.freccia48dx
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(84, 69)
        Me.BindingNavigatorMoveLastItem.Text = "Sposta in ultima posizione"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 72)
        '
        'BTN_aggiungi
        '
        Me.BTN_aggiungi.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTN_aggiungi.Image = Global.PoP2.Comuni.My.Resources.Resources.OminoAggiunge48
        Me.BTN_aggiungi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BTN_aggiungi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_aggiungi.Name = "BTN_aggiungi"
        Me.BTN_aggiungi.Size = New System.Drawing.Size(52, 69)
        Me.BTN_aggiungi.Text = "Aggiunge"
        Me.BTN_aggiungi.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'BTN_salva
        '
        Me.BTN_salva.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTN_salva.Image = Global.PoP2.Comuni.My.Resources.Resources.ominoConferma48
        Me.BTN_salva.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BTN_salva.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_salva.Name = "BTN_salva"
        Me.BTN_salva.Size = New System.Drawing.Size(52, 69)
        Me.BTN_salva.Text = "ToolStripButton1"
        '
        'BTN_termina
        '
        Me.BTN_termina.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.BTN_termina.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BTN_termina.Image = Global.PoP2.Comuni.My.Resources.Resources.ominotermina48
        Me.BTN_termina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BTN_termina.Name = "BTN_termina"
        Me.BTN_termina.Size = New System.Drawing.Size(84, 69)
        Me.BTN_termina.Text = "ToolStripButton1"
        '
        'frmElencoPresenzeInserite
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 728)
        Me.Controls.Add(Me.BDnavigazione)
        Me.Controls.Add(Me.dgwElencoPresenze)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmElencoPresenzeInserite"
        Me.Text = "Elenco Presenze inserite"
        CType(Me.dgwElencoPresenze, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BDnavigazione, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BDnavigazione.ResumeLayout(False)
        Me.BDnavigazione.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgwElencoPresenze As DataGridView
    Friend WithEvents BDnavigazione As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BTN_elimina As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents BTN_aggiungi As ToolStripButton
    Friend WithEvents BTN_salva As ToolStripButton
    Friend WithEvents BTN_termina As ToolStripButton
End Class
