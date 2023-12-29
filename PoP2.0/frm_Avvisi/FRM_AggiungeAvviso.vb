Public Class FRM_AggiungeAvviso
    Dim ID_utente As Integer
    Dim G_idAZ As Integer
    Public Sub New(ByVal _ID_utente As Integer, ByVal _idaz As Integer)
        InitializeComponent()
        ID_utente = _ID_utente
        G_idAZ = _idaz
    End Sub

    Private Sub FRM_AggiungeAvviso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaCKL()
    End Sub
    Private Sub CaricaCKL()
        CKL_utenti.Items.Clear()
        Using TA As New DS_servizioTableAdapters.TA_credenziali
            Using DT As New DS_servizio.DT_credenzialiDataTable
                TA.FillByMessaggi(DT, G_idAZ)    'Verifica solo gli avvisi per l'utente e per tutti
                Dim kk As Integer = 0
                For Each RG In DT
                    Dim riga As Object
                    riga = RG.uid
                    Dim lvi As CheckAvvisi = New CheckAvvisi() With {.Name = RG.uid, .Testo = RG.uid, .Tag = RG.id}
                    CKL_utenti.Items.Add(lvi)
                    CKL_utenti.Items.Item(kk).ToString()
                    kk += 1
                Next
            End Using
        End Using
    End Sub
    Private Sub BT_avanti_Click(sender As Object, e As EventArgs) Handles BT_avanti.Click
        Using TA As New DS_agTableAdapters.TA_avvisi
            Dim RGC As CheckAvvisi
            For Each RGC In CKL_utenti.CheckedItems
                TA.QR_Inserisci(TX_cosa.Text, DT_quando.Value, 0, ID_utente, RGC.Tag, 0, G_idAZ)
            Next
        End Using
        Me.Close()
    End Sub

    Private Sub BT_oggi_Click(sender As Object, e As EventArgs) Handles BT_oggi.Click
        Me.Close()
    End Sub
End Class