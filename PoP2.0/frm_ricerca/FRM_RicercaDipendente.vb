Public Class FRM_RicercaDipendente
    Public id_ritorno_utente As Integer
    Public tx_ritorno_utente As String
    Public Sub New(id, tx)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        id_ritorno_utente = id
        tx_ritorno_utente = tx
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRM_RicercaDipendente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim TMP_id As Integer = id_ritorno_utente
        Me.TA_utenti_ricerca.Fill(Me.DS_utenti.DT_utenti_ricerca, GlobalVarPOP.G_idAZ)
        If TMP_id <> -1 Then
            Dim N_pos As Integer = BS_ricerca.Find("id", TMP_id)
            '    For Each tt In DG_ricerca.Rows
            '        If tt(0).value = N_pos Then
            '            MsgBox("trovato")
            '        End If
            '    Next
        End If
    End Sub
    Private Function F_carica_elenco()
        '
        Return (True)
    End Function
    Private Sub BT_conferma_Click(sender As Object, e As EventArgs) Handles BT_conferma.Click
        Dim rg As DS_utenti.DT_utenti_ricercaRow
        rg = DirectCast(BS_ricerca.Current, DataRowView).Row
        id_ritorno_utente = rg.id
        tx_ritorno_utente = rg.cognome & " " & rg.nome
        BT_annulla.PerformClick()
    End Sub

    Private Sub BT_annulla_Click(sender As Object, e As EventArgs) Handles BT_annulla.Click
        Me.Dispose()
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        BS_ricerca.Filter = String.Format("ricerca LIKE '%{0}%'", TextBox1.Text)
        If BS_ricerca.Count < 1 Then
            BS_ricerca.RemoveFilter()
            TextBox1.Text = ""
        End If
    End Sub
End Class