Imports Pop2.Comuni
Public Class FrmCercaOperazionePulizie
    Public idOperazione As Int16
    Public txOperazione As String

    Public Sub New(ByRef bs As BindingSource, ByRef tx As String)
        ' La chiamata è richiesta dalla finestra di progettazione.
        If IsNothing(bs) Then
            Return
        End If

        InitializeComponent()
        bsPreventivoOperazioni.DataSource = bs.DataSource
        txOperazione = tx

    End Sub

    Private Sub FrmCercaOperazionePulizie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TextBox1.Text = txOperazione
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.Focus()

    End Sub
    Private Sub textbox1_keypress(sender As Object, e As PreviewKeyDownEventArgs) Handles TextBox1.PreviewKeyDown
        Select Case e.KeyValue
            Case Keys.Up
                bsPreventivoOperazioni.MovePrevious()

            Case Keys.Down
                bsPreventivoOperazioni.MoveNext()
            Case Keys.Enter
                Dim rgOperazione As dsPreventivi.dtPreventiviOperazioniRow
                If bsPreventivoOperazioni.Count > 0 Then
                    rgOperazione = DirectCast(bsPreventivoOperazioni.Current, DataRowView).Row
                    idOperazione = rgOperazione.id
                    txOperazione = rgOperazione.descrizione
                    Me.Close()
                End If
            Case Keys.End
                bsPreventivoOperazioni.MoveLast()
            Case Keys.Home
                bsPreventivoOperazioni.MoveFirst()
        End Select

    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim txTMP As TextBox
        txTMP = DirectCast(sender, TextBox)
        Dim testo As String

        testo = txTMP.Text.Replace("'", "''")
        bsPreventivoOperazioni.Filter = String.Format("descrizione LIKE '%{0}%' or tag LIKE '%{0}%'", testo)
        If bsPreventivoOperazioni.Count <= 0 Then
            txTMP.Text = txTMP.Text.Substring(0, txTMP.Text.Length - 1)
            txTMP.SelectionStart = txTMP.Text.Length
            testo = txTMP.Text.Replace("'", ".")
            bsPreventivoOperazioni.Filter = String.Format("descrizione LIKE '%{0}%' OR tag LIKE '%{0}%'", testo)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim rgOperazione As dsPreventivi.dtPreventiviOperazioniRow
        If bsPreventivoOperazioni.Count > 0 Then
            rgOperazione = DirectCast(bsPreventivoOperazioni.Current, DataRowView).Row
            idOperazione = rgOperazione.id
            txOperazione = rgOperazione.descrizione
            Me.Close()
        End If

    End Sub
End Class