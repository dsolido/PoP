Public Class frm_stp_sca_ins
    Private filtro As String
    Private Cliente As Integer
    Public Sub New(ByVal Optional _filtro As String = "", ByVal Optional idCli As Integer = -1)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        filtro = _filtro
        Cliente = idCli
    End Sub
    Private Sub frm_stp_sca_ins_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Cliente > 0 Then
            CaricaDati()
        Else
            Try
                Me.TA_clienti_scadenze.mostra(Me.DS_contabilita.DT_clienti_scadenze)
            Catch ex As Exception

            End Try

        End If
        If filtro.Trim.Length > 0 Then
            DT_clienti_scadenzeBindingSource.Filter = filtro
        Else
            DT_clienti_scadenzeBindingSource.RemoveFilter()
        End If
        Me.ReportViewer1.RefreshReport()
    End Sub
    Private Function CaricaDati()
        Try
            Me.TA_clienti_scadenze.mostra_cliente(Me.DS_contabilita.DT_clienti_scadenze, Cliente)
        Catch ex As Exception
            Dim err As DataRow() = DS_contabilita.DT_clienti_scadenze.GetErrors
#If DEBUG Then
            For Each e In err
                Console.WriteLine(e.RowError)
            Next
#End If
        End Try
        Return True
    End Function

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class