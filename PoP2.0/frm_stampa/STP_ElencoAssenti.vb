Public Class STP_ElencoAssenti
    Dim G_idAZ As Integer = GlobalVarPOP.G_idAZ
    Dim G_periodo As String
    Public Sub New(ByVal p As String)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        G_periodo = p
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub STP_ElencoAssenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_agenda.FillByMeseOrdineDipendente(Me.DS_ag.DT_agenda, G_periodo, G_idAZ)

        Me.TA_azienda.Fill(Me.DS_azienda.DT_azienda)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class