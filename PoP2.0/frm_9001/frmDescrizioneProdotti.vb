Public Class frmDescrizioneProdotti
    Private Sub frmDescrizioneProdotti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TaProdotti.Fill(Me.DsProcedure.dtProdotti)
    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()
    End Sub


    Private Sub dgwIstruzioni_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgwIstruzioni.RowValidated
        Dim bs As BindingSource = bsProdotti
        Dim ta As dsProcedureTableAdapters.taProdotti
        ta = TaProdotti
        Dim rgRighe As dsProcedure.dtProdottiRow
        If bs.Count <= 0 Then
            Return
        End If
        bs.EndEdit()
        rgRighe = DirectCast(bs.Current, DataRowView).Row
        Select Case rgRighe.RowState
            Case DataRowState.Modified
                ta.UpdateQuery(rgRighe.descrizione, rgRighe.id_tipologia, rgRighe.descrizionecommerciale, rgRighe.id)
                rgRighe.AcceptChanges()
        End Select
    End Sub
    Private Sub TTTestoRicerca_TextChange(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        Dim testo As ToolStripTextBox = DirectCast(sender, ToolStripTextBox)
        Dim bs As BindingSource = bsProdotti
        Dim filtro As String = String.Format("descrizione LIKE '%{0}%' or tag LIKE '%{0}%'", testo.Text)
        bs.Filter = filtro
        Dim x As Int16
        x = 0
        Do While bs.Count = 0 And testo.TextLength > 0
            x += 1
            testo.Text = testo.Text.Substring(0, testo.TextLength - x)
            filtro = String.Format("descrizione LIKE '%{0}%' or tag LIKE '%{0}%'", testo.Text)
            bs.Filter = filtro
            If bs.Count > 0 Then
                testo.SelectionStart = testo.TextLength
                Exit Do
            End If
        Loop

    End Sub
End Class