Public Class FRMmodificapresenzeWEB
    Dim ID As Integer
    Friend RGweb As DS_utenti.DT_presenzeWEBRow
    Public Sub New(ByVal _ID As Integer)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        ID = _ID
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
    End Sub

    Private Sub FRMmodificapresenzeWEB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TA_tipologia.mostra(Me.DS_utenti.DT_tipologia)
        Me.TA_destinatari.FillByAttivi(Me.DS_utenti.DT_destinatari, 1)
        Me.TA_clienti.FillByAttivi(Me.DS_utenti.DT_clienti, GlobalVarPOP.G_idAZ, 1)
        Me.TA_presenzeWEB.FillByID(Me.DS_utenti.DT_presenzeWEB, ID)
        RGweb = DirectCast(DT_presenzeWEBBindingSource.Current, DataRowView).Row
    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        DT_presenzeWEBBindingSource.EndEdit()
        Me.Close()
    End Sub

    Private Sub TTBTannulla_Click(sender As Object, e As EventArgs) Handles TTBTannulla.Click
        DT_presenzeWEBBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        DT_presenzeWEBBindingSource.CancelEdit()
        Me.Close()
    End Sub

    Private Sub BTClientieLocazioniNascoste_Click(sender As Object, e As EventArgs) Handles BTClientieLocazioniNascoste.Click
        Me.TA_destinatari.Fill(Me.DS_utenti.DT_destinatari)
        Me.TA_clienti.Fill(Me.DS_utenti.DT_clienti)

    End Sub
End Class