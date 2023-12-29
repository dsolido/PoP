Public Class FRM_selezionafornitore
    Dim RF As DS_prodotti.DT_fornitoriRow
    Public IDTrovato As Integer
    Public Sub New(Optional ByRef cg As DataRow = Nothing)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        RF = cg
    End Sub
    Private Sub FRM_fornitore_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_forni.Fill(Me.DS_prodotti.DT_fornitori)
        Try
            BS_forni.Position = BS_forni.Find("id", RF.id)
            For Each pp In DG_fornitore.Rows
                If pp.cells(0).value = RF.id Then
                    DG_fornitore.ClearSelection()
                    DG_fornitore.CurrentCell = DG_fornitore.Item(1, DG_fornitore.CurrentRow.Index)
                    DG_fornitore.CurrentRow.Selected = True
                End If
            Next
        Catch ex As Exception
        End Try
        TX_ricerca.Focus()
    End Sub

    Private Sub TX_ricerca_TextChanged(sender As Object, e As EventArgs) Handles TX_ricerca.TextChanged
        Dim testo As TextBox
        testo = DirectCast(sender, TextBox)
        Dim ricerca As String = testo.Text.Trim
        Dim valore As Integer = 0
        Dim I_Ricerca As Integer = testo.Text.Length
        Do While True
            ricerca = ricerca.Substring(0, ricerca.Length - valore)
            testo.Text = ricerca
            testo.SelectionStart = ricerca.Length
            BS_forni.Filter = String.Format("anagrafica LIKE '%{0}%'", ricerca)
            If BS_forni.Count > 0 Then
                Exit Do
            Else
                valore += 1
                If I_Ricerca < valore Then
                    BS_forni.RemoveFilter()
                    MsgBox("Nessun Filtro applicabile")
                    Exit Do
                End If
            End If
        Loop
    End Sub
    Private Sub TX_ricerca_TextInvio(sender As Object, e As KeyEventArgs) Handles TX_ricerca.KeyDown
        Dim rg As DS_prodotti.DT_fornitoriRow
        rg = DirectCast(BS_forni.Current, DataRowView).Row
        If e.KeyCode = Keys.Enter Then
            If MsgBox("Confermi il Fornitore " & rg.anagrafica, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                BT_termina.PerformClick()
            End If
        End If
    End Sub

    Private Sub BT_termina_Click(sender As Object, e As EventArgs) Handles BT_termina.Click
        If BS_forni.Count > 0 Then
            RF = DirectCast(BS_forni.Current, DataRowView).Row
            IDTrovato = RF.id
        End If
        Me.Close()
    End Sub

End Class