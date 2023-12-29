Public Class FRMstpclienticonpec
    Dim FT As String
    Public Sub New(Optional ByVal _ft As String = Nothing)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        FT = _ft
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'DS_clienti.DTclienticonpec'. È possibile spostarla o rimuoverla se necessario.
        Me.TAclienticonpec.Fill(Me.DS_clienti.DTclienticonpec)
        If Not IsNothing(FT) Then
            BSclientipec.Filter = FT
            If BSclientipec.Count < 1 Then
                Return
            End If
        End If
        ReportViewer1.RefreshReport()

    End Sub

End Class