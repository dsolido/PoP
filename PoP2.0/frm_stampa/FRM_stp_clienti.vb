Public Class FRM_stp_clienti
    Dim B_attivi As Integer = 1
    Dim G_idAZ As Integer = GlobalVarPOP.G_idAZ
    Public Sub New(ByVal attivi As Integer)
        B_attivi = attivi
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub FRM_stp_clienti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DT_cantieri_TA.FillByAttivi(Me.DS_clienti.DT_cantieri_new, G_idAZ, B_attivi)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class