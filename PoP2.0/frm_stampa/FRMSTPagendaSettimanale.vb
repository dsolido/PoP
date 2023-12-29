Public Class FRMSTPagendaSettimanale
    Dim d1, d2 As DateTime
    Dim iddip As Integer
    Dim DT As DataTable
    Public Sub New(ByVal _d1 As DateTime, ByVal _d2 As DateTime, Optional _iddip As Integer = Nothing, Optional tmpDT As DataTable = Nothing)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        d1 = _d1
        d2 = _d2
        iddip = _iddip
        DT = tmpDT
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub FRMSTPagendaSettimanale_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Not IsNothing(DT) Then
            DTsostituzioniBindingSource.DataSource = DT
        Else
            If IsNothing(iddip) Or iddip = 0 Then
                Me.TAsostituzioni.FillByDaA(Me.DS_ag.DTsostituzioni, d1, d2)
            Else
                Me.TAsostituzioni.FillByDaAperDipendente(Me.DS_ag.DTsostituzioni, d1, d2, iddip)
            End If
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class