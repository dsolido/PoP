Public Class frm_stp_foglio_presenza
    Private Sub frm_stp_foglio_presenza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'assegna il tipo di connessione
        Me.DT_fp_stp_TA.mostra(DS_personale.DT_fp_stp)
        Try
            Me.ReportViewer1.RefreshReport()
        Catch ex As Exception
#If DEBUG Then
            Console.WriteLine(ex.Message)
#End If

        End Try

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class