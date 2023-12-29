Public Class frmCercaDettaglioCliente
    Dim dtDettaglio As DS_clienti.DT_locazione_newDataTable
    Dim idDes As Integer = Nothing
    Dim idCli As Integer = Nothing
    Dim Destinatario As String
    Friend Risposta(1) As String
    Public Sub New(ByRef cg As DS_clienti.DT_locazione_newDataTable, ByVal _idDes As Integer, ByVal _Destinatario As String, ByVal _idCli As Integer)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        dtDettaglio = cg '.Select("id_terminale =" & idCli)
        idCli = _idCli
        idDes = _idDes
        Destinatario = _Destinatario

    End Sub
    Private Sub FRM_selezionacantiere_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If dtDettaglio.Rows.Count = 0 Then
            Me.TA_locazione_new.QR_fillID_terminale(dtDettaglio, idCli)
        End If
        bsLocazione.DataSource = dtDettaglio
        bsLocazione.Filter = "id_terminale = " & idCli
        If bsLocazione.Count = 0 Then
            Return
        End If
        Dim x As Int16
        If Destinatario <> "" Then
            For Each rg In bsLocazione
                If rg("locazione") = Destinatario Then
                    bsLocazione.Position = x
                    Exit For
                End If
                x += 1
            Next

        End If

        TX_ricerca.Focus()
    End Sub

    Private Sub TX_ricerca_TextChanged(sender As Object, e As EventArgs) Handles TX_ricerca.TextChanged
        Dim testo As TextBox
        testo = DirectCast(sender, TextBox)
        Do While True
            bsLocazione.Filter = "id_terminale = " & idCli & " AND " & String.Format("locazione LIKE '%{0}%'", testo.Text)
            If bsLocazione.Count > 0 Then
                Exit Do
            Else
                testo.Text = testo.Text.Substring(0, testo.Text.Length - 1)
                testo.SelectionStart = testo.Text.Length
            End If
        Loop
    End Sub
    Private Sub TX_ricerca_TextInvio(sender As Object, e As KeyEventArgs) Handles TX_ricerca.KeyDown
        Dim rg As DS_clienti.DT_locazione_newRow
        rg = DirectCast(bsLocazione.Current, DataRowView).Row

        If e.KeyCode = Keys.Enter Then
            If MsgBox("Confermi il dettaglio cliente " & rg.locazione, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                BT_termina.PerformClick()
            End If
        End If
    End Sub

    Private Sub BT_termina_Click(sender As Object, e As EventArgs) Handles BT_termina.Click
        Dim rg As DS_clienti.DT_locazione_newRow
        rg = DirectCast(bsLocazione.Current, DataRowView).Row
        idDes = rg.id
        Destinatario = rg.locazione
        Risposta(0) = idDes
        Risposta(1) = Destinatario
        Me.Close()
    End Sub
End Class