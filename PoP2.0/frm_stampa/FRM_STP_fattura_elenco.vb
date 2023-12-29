Imports System.Text
Public Class FRM_stp_fattura_elenco
    Dim periodo As String 'mese-anno'
    Public Sub New(ByVal _p)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        periodo = _p

    End Sub
    Private Sub FRM_stp_fattura_elenco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.TA_azienda.FillByID(Me.DS_azienda.DT_azienda, GlobalVarPOP.G_idAZ)
            Me.TA_STP_fattura.FillByPeriodo(Me.DS_fattura.DT_STP_fattura, periodo)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_fattura.DT_STP_fattura.GetErrors
            Dim msg As New StringBuilder
        End Try

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class