Public Class FRM_findClienti

    Public orari_ID(3) As Integer

    Public Sub New(Optional ByRef _iddip As Integer = -1, Optional ByRef _idcli As Integer = -1, Optional ByRef _iddes As Integer = -1)
        orari_ID(1) = _iddip
        orari_ID(2) = _idcli
        orari_ID(3) = _iddes
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRM_findClienti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TA_locazioni.Fill(Me.DS_orari.DT_locazioni)
        Me.TA_clienti.Fill(Me.DS_orari.DT_clienti)
        Me.TA_utenti.Fill(Me.DS_orari.DT_utenti)
        If orari_ID(1) > 0 Then
            BS_utenti.Filter = "id = " & orari_ID(1)
        End If
        If orari_ID(2) > 0 Then
            BS_clienti.Filter = "id = " & orari_ID(2)
            BS_locazioni.Filter = "id_terminale = " & orari_ID(2)
        End If
        If orari_ID(3) > 0 Then
            BS_locazioni.Filter = String.Format("id = {0} AND id_terminale = {1}", orari_ID(3), orari_ID(2))
        End If

    End Sub
    Private Sub FRMdispose() Handles MyBase.FormClosing
        orari_ID(1) = DirectCast(BS_utenti.Current, DataRowView).Row.Item("id")
        orari_ID(2) = DirectCast(BS_clienti.Current, DataRowView).Row.Item("id")
        orari_ID(3) = DirectCast(BS_locazioni.Current, DataRowView).Row.Item("id")
    End Sub
    Private Sub TX_ricercadipendente_TextChanged(sender As Object, e As EventArgs) Handles TX_ricercadipendente.TextChanged
        BS_utenti.RemoveFilter()
        BS_utenti.Filter = String.Format("anagrafica LIKE '%{0}%'", TX_ricercadipendente.Text)
    End Sub

    Private Sub cmd_termina_Click(sender As Object, e As EventArgs) Handles cmd_termina.Click
        Me.Close()
    End Sub

    Private Sub TXT_ric_cliente_TextChanged(sender As Object, e As EventArgs) Handles TXT_ric_cliente.TextChanged
        BS_clienti.RemoveFilter()
        BS_clienti.Filter = String.Format("societa LIKE '%{0}%'", TXT_ric_cliente.Text)
        Dim id_cli As Integer = DG_clienti.CurrentRow.Cells(1).Value
        BS_locazioni.RemoveFilter()
        BS_locazioni.Filter = String.Format("id_terminale = {0}", id_cli)
    End Sub
End Class