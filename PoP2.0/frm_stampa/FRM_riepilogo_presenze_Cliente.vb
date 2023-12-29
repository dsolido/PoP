Public Class FRM_riepilogo_presenze_Cliente
    Dim DT As New BindingSource
    Public Sub New(_DT As BindingSource)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        DT = _DT
        BS_riepilogo.DataSource = DT

    End Sub
    Private Sub FRM_riepilogo_presenze_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class