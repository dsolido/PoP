Public Class FRM_STP_ProgrammaFerie
    Dim DT_prog As DataTable
    Public Sub New(ByRef DT As DataTable)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        DT_prog = DT
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRM_STP_ProgrammaFerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BS_ProgrammazioneFerie.DataSource = DT_prog
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class