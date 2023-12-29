Public Class FRMSTPstampaelencosostituzionidellasettimana
    Dim G_periodo As String
    Public Sub New(ByVal _p As String)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        G_periodo = _p
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub FRMSTPstampaelencosostituzionidellasettimana_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_azienda.Fill(Me.DS_azienda.DT_azienda)

        Me.TAsostituzioni.FillByMese(DS_ag.DTsostituzioni, G_periodo)

        Me.ReportViewer1.RefreshReport()
    End Sub

End Class