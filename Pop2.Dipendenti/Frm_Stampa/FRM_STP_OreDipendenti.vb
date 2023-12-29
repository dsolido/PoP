Public Class FRM_stp_OreDipendenti
    Dim I_IDDip As Integer
    Dim I_IDCli As Integer

    Public Sub New(ByVal Optional dip As Integer = -1, ByVal Optional cli As Integer = -1)
        I_IDCli = cli
        I_IDDip = dip
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRM_stp_OreDipendenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If I_IDDip <> -1 Then
            Me.TA_orario_STP.FillByID_dip(DS_orari.DT_orario_STP, I_IDDip)
            Me.TA_orario_STP_totali.FillByID_dip(DS_orari.DT_orario_STP_totali, I_IDDip)
        ElseIf I_IDCli <> -1 Then
            Me.TA_orario_STP.FillByID_cli(DS_orari.DT_orario_STP, I_IDCli)
            Me.TA_orario_STP_totali.FillByID_cli(DS_orari.DT_orario_STP_totali, I_IDCli)
        Else
            Me.TA_orario_STP.Fill(Me.DS_orari.DT_orario_STP)
            Me.TA_orario_STP_totali.Fill(DS_orari.DT_orario_STP_totali)
        End If

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class