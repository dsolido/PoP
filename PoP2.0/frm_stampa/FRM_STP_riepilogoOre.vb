Public Class FRM_stp_riepilogoOre
    Dim id_cli As Integer = -1
    Dim periodo As String
    Public Sub New(Optional ByVal _id_cli As Integer = -1, Optional ByVal _periodo As String = "")
        id_cli = _id_cli
        periodo = _periodo
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRM_stp_riepilogoOre_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_contore.FillByPeriodo_ID_cli(Me.DS_personale.DT_contore, periodo, id_cli)

        Me.DT_clienti_TableAdapter.FillByID_cli(Me.DS_personale.DT_clienti, id_cli)


        Me.ReportViewer1.RefreshReport
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class