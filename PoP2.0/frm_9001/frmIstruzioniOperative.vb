Public Class frmIstruzioniOperative
    Private Sub frmIstruzioniOperative_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TaProcedureIstruzioni.Fill(Me.DsProcedure.dtProcedureIstruzioni)

    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()
    End Sub


    Private Sub dgwIstruzioni_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgwIstruzioni.RowValidated
        Dim bs As BindingSource = bsProcedureIstruzioni
        Dim ta As dsProcedureTableAdapters.taProcedureIstruzioni
        ta = TaProcedureIstruzioni
        Dim rgRighe As dsProcedure.dtProcedureIstruzioniRow
        If bs.Count <= 0 Then
            Return
        End If
        bs.EndEdit()
        rgRighe = DirectCast(bs.Current, DataRowView).Row
        Select Case rgRighe.RowState
            Case DataRowState.Added
                Dim ris As Integer = ta.InsertQuery(If(rgRighe.testo = "", Nothing, rgRighe.testo))
                rgRighe.AcceptChanges()
            Case DataRowState.Modified
                Dim ris As Integer = ta.UpdateQuery(If(rgRighe.testo = "", Nothing, rgRighe.testo), rgRighe.id)
                rgRighe.AcceptChanges()
        End Select
    End Sub
    Private Sub dgwIstruzioni_RowDeleted(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgwIstruzioni.UserDeletingRow
        If MsgBox("Elimino la riga ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim id As Int16
            id = e.Row.Cells(0).Value
            Dim ta As dsProcedureTableAdapters.taProcedureIstruzioni
            ta = TaProcedureIstruzioni
            Dim ris As Int16 = ta.DeleteQuery(id)
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub TTTestoRicerca_TextChange(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        Dim testo As ToolStripTextBox = DirectCast(sender, ToolStripTextBox)
        Dim bs As BindingSource = bsProcedureIstruzioni
        Dim filtro As String = String.Format("testo LIKE '%{0}%'", testo.Text)
        bs.Filter = filtro
        Dim x As Int16
        x = 0
        Do While bs.Count = 0 And testo.TextLength > 0
            x += 1
            testo.Text = testo.Text.Substring(0, testo.TextLength - x)
            filtro = String.Format("testo LIKE '%{0}%'", testo.Text)
            bs.Filter = filtro
            If bs.Count > 0 Then
                testo.SelectionStart = testo.TextLength
                Exit Do
            End If
        Loop

    End Sub
End Class