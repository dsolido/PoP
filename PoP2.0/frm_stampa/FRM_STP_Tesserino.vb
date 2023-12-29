Public Class FRM_stp_Tesserino
    Dim ID As Integer
    Dim FIL As String
    Public Sub New(Optional ByRef _id As Integer = -1, Optional ByRef _fil As String = "")

        ID = _id
        FIL = _fil
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRM_stp_Tesserino_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If ID > 0 Then
            Me.TA_tesserino.FillByUtente(Me.DS_utenti.DT_Tesserino, ID)
        Else
            If FIL <> "" Then
                Me.TA_tesserino.Fill(Me.DS_utenti.DT_Tesserino)
                BS_tesserino.Filter = FIL
            Else
                MsgBox("Nessun filtro valido")
                Return
            End If
        End If
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class