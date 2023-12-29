Public Class FRM_STP_programmacantieridipendenti
    Private Sub FRM_STP_impegno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TA_azienda.Fill(Me.DS_azienda.DT_azienda)
        Me.TA_impegno_view.Fill(Me.DS_riepiloghi.DT_impegno_view)
        Me.ReportViewer1.RefreshReport()

    End Sub
End Class