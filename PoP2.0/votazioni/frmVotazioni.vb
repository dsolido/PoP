Public Class frmVotazioni
    Private Sub frmVotazioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'DS_utenti.dtVotazione'. È possibile spostarla o rimuoverla se necessario.
        Me.TaVotazione.Fill(Me.DS_utenti.dtVotazione)

    End Sub
End Class