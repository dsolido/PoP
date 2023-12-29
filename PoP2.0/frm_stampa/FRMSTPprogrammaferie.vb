Public Class FRMSTPprogrammaferie

    Dim DT_prog As DataView
    Public Sub New(ByRef DT As DataView)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        DT_prog = DT
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub


    Private Sub FRMSTPprogrammaferie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DT_ProgrammazioneFerieBindingSource.DataSource = DT_prog
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class