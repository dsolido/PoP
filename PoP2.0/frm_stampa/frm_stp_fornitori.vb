Public Class frm_stp_fornitori
    Private Sub frm_stp_fornitori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'DS_magazzino.DT_fornitori'. È possibile spostarla o rimuoverla se necessario.
        Me.DT_fornitoriTableAdapter.fill(Me.DS_magazzino.DT_fornitori)

        Me.rpt_fornitori.RefreshReport()
    End Sub

    Private Sub rpt_fornitori_Load(sender As Object, e As EventArgs) Handles rpt_fornitori.Load

    End Sub
End Class