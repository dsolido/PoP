Imports Microsoft.Reporting.WinForms

Public Class frm_stp_scheda
    Dim DT As BindingSource = Nothing
    Public Sub New(Optional ByVal _DT As BindingSource = Nothing)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        Try
            DT = _DT
        Catch ex As Exception

        End Try
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub frm_stp_scheda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            TA_prodotti.FillByscheda(DS_prodotti.DT_prodotti)
        Catch ex As Exception
        End Try
        Dim oldFil As String = DT.Filter
        Dim rig As Integer = 0
        DT_prodottiBindingSource.DataSource = DS_prodotti.DT_prodotti
        DT_prodottiBindingSource.Filter = oldFil

        For Each kk In DT_prodottiBindingSource
            rig += 1
            kk.item("riga_numero") = rig
        Next
        DT_prodottiBindingSource.EndEdit()
        'BS_prodotti.Sort = "id_tipologia"
        Me.rpt_scheda_prodotti.RefreshReport()
    End Sub
End Class