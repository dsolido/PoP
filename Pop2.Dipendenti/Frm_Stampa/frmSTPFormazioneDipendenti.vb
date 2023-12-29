Public Class frmSTPFormazioneDipendenti
    Private Sub frmSTPFormazioneDipendenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.taFormazioneScadenze.FillByScaduta(Me.DSwebcondiviso.dtFFormazioneScadenze)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class