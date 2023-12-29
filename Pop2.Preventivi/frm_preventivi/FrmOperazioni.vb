Imports Pop2.Comuni
Public Class FrmOperazioni
    Dim bstmp As BindingSource = New BindingSource

    Private Sub FrmOperazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TaPreventiviOperazioni.Fill(Me.DsPreventivi.dtPreventiviOperazioni)
        dgwOperazioni.AutoGenerateColumns = False
        dgwOperazioni.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        dgwOperazioni.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize

        Dim dgwcDescrizioneOperazione As DataGridViewTextBoxColumn = New DataGridViewTextBoxColumn
        dgwcDescrizioneOperazione.DataPropertyName = "descrizione"
        dgwcDescrizioneOperazione.FillWeight = 150.0!
        dgwcDescrizioneOperazione.HeaderText = "Descrizione"
        dgwcDescrizioneOperazione.Name = "dgwcDescrizioneOperazione"
        Dim dgwcCategoria As DataGridViewComboBoxColumn = New DataGridViewComboBoxColumn
        dgwcCategoria.DataPropertyName = "id_categoria"
        dgwcCategoria.DataSource = Me.bsPreventiviCategorie
        dgwcCategoria.DisplayMember = "descrizione"
        dgwcCategoria.FillWeight = 80.0!
        dgwcCategoria.HeaderText = "Categoria"
        dgwcCategoria.Name = "dgwcCategoriaOperazione"
        dgwcCategoria.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        dgwcCategoria.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        dgwcCategoria.ValueMember = "id"
        dgwOperazioni.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {dgwcDescrizioneOperazione, dgwcCategoria})
        Dim ds As DataTable
        ds = New dsPreventivi.dtPreventiviOperazioniDataTable
        ds = DsPreventivi.dtPreventiviOperazioni
        bstmp.DataMember = "dtPreventiviOperazioni"
        bstmp.DataSource = ds
        dgwOperazioni.DataSource = bstmp
        Me.TaPreventiviCategorie.Fill(Me.DsPreventivi.dtPreventiviCategorie)


    End Sub

    Private Sub DtPreventiviOperazioniDataGridView_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwOperazioni.RowValidating


    End Sub

    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click
        bsPreventiviOperazioni.AddNew()

    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        bsPreventiviOperazioni.EndEdit()
        Dim rg As dsPreventivi.dtPreventiviOperazioniRow
        rg = DirectCast(bsPreventiviOperazioni.Current, DataRowView).Row
        If rg.RowState = DataRowState.Added Then
            If rg.IsdescrizioneNull Then
                MsgBox("Mi spiace non ha inserito una descrizione corretta, riprova")
                bsPreventiviOperazioni.CancelEdit()
                Return
            End If
            TaPreventiviOperazioni.InsertQuery(rg.descrizione, If(rg.IsimpegnometroquadroNull, Nothing, rg.impegnometroquadro), If(rg.IsdataNull, Now(), rg.data), If(rg.IsattivoNull, 1, rg.attivo), If(rg.IsidcategoriaNull, 1, rg.idcategoria), If(rg.IsimpegnonumeroNull, Nothing, rg.impegnonumero))
            rg.AcceptChanges()
        ElseIf rg.RowState = DataRowState.Modified Then
            TaPreventiviOperazioni.UpdateQuery(rg.descrizione, rg.impegnometroquadro, rg.data, rg.attivo, rg.idcategoria, rg.impegnonumero, rg.id)
            rg.AcceptChanges()
        End If
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()
    End Sub

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        bsPreventiviOperazioni.EndEdit()
        Dim rg As dsPreventivi.dtPreventiviOperazioniRow
        rg = DirectCast(bsPreventiviOperazioni.Current, DataRowView).Row
        If MsgBox(String.Format("Sei sicuro di vole eliminare la riga {0} {1} {0} {2}", vbCrLf, rg.descrizione, "E' irreversibile"), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TaPreventiviOperazioni.DeleteQuery(rg.id)
        End If

    End Sub

    Private Sub DescrizioneTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescrizioneTextBox.TextChanged
        Dim tx As TextBox = DirectCast(sender, TextBox)
        If String.IsNullOrEmpty(tx.Text) Then
            bstmp.RemoveFilter()
            Return
        End If
        tx.Text = Propper(tx.Text)
        tx.SelectionStart = tx.Text.Length
        Dim ricerca As String
        ricerca = tx.Text.Replace("'", " ")
        bstmp.Filter = String.Format("descrizione LIKE '%{0}%'", ricerca)
    End Sub
End Class