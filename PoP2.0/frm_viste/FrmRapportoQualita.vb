Public Class FrmRapportoQualita
    Private Sub FrmRapportoQualita_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'dsControlloQualita.dtCqQuestionario'. È possibile spostarla o rimuoverla se necessario.
        Me.TaCqQuestionario.Fill(Me.dsControlloQualita.dtCqQuestionario)
        Me.taQuestionarioVotazione.Fill(Me.dsControlloQualita.dtQuestionarioVotazione)
        Timer1.Start()
    End Sub

    Private Sub btnTermina_Click(sender As Object, e As EventArgs) Handles btnTermina.Click
        Me.Close()
    End Sub

    Private Sub btnGeneraReport_Click(sender As Object, e As EventArgs) Handles btnGeneraReport.Click
        If idCliente > 0 And dataSel.ToShortDateString <> "1/1/1900" And idQuestionario > 0 Then
            dtQuestionarioVotazioneBindingSource.Filter = String.Format("idCliente = {0} And al = '{1}' AND idQuestionario = {2}", idCliente, dataSel, idQuestionario)
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
    Dim idQuestionario As Int16
    Dim dataSel As DateTime
    Dim idCliente As Int16

    Private Sub cmbTipoSondaggio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoSondaggio.SelectedIndexChanged
        Dim cb As ComboBox
        cb = DirectCast(sender, ComboBox)
        idQuestionario = cb.SelectedValue
        Dim dtVota As DataTable = Me.dsControlloQualita.dtQuestionarioVotazione
        cmbDateDisponibili.Items.Clear()
        Dim dtData = From v As dsControlloQualita.dtQuestionarioVotazioneRow In dtVota Where v.idQuestionario >= idQuestionario Order By v.data Descending Group By v.al Into Group
        For Each r In dtData
            cmbDateDisponibili.Items.Add(r.al.ToShortDateString)
        Next
        If dtData.Count > 0 Then
            cmbDateDisponibili.SelectedIndex() = 0
            AddHandler cmbDateDisponibili.SelectedIndexChanged, AddressOf cmbDateDisponibili_SelectedIndexChanged
        Else
            dataSel = Nothing
            idCliente = 0
#Disable Warning BC42328 ' L'espressione 'AddressOf' non ha effetto in questo contesto perché l'argomento del metodo per 'AddressOf' richiede una conversione di tipo relaxed del tipo delegato dell'evento
            RemoveHandler cmbDateDisponibili.SelectedIndexChanged, AddressOf cmbDateDisponibili_SelectedIndexChanged
#Enable Warning BC42328 ' L'espressione 'AddressOf' non ha effetto in questo contesto perché l'argomento del metodo per 'AddressOf' richiede una conversione di tipo relaxed del tipo delegato dell'evento
            cmbDateDisponibili.ResetText()
        End If

    End Sub
    Private Function cmbDateDisponibili_SelectedIndexChanged()

        Dim cb As ComboBox
        cb = cmbDateDisponibili



        Dim dtVota As DataTable = Me.dsControlloQualita.dtQuestionarioVotazione
        cmbClientecheharisposto.Items.Clear()
        Dim dtData = From v As dsControlloQualita.dtQuestionarioVotazioneRow In dtVota Where v.idQuestionario >= idQuestionario Order By v.data Descending Group By v.societa Into Group

        For Each r In dtData
            cmbClientecheharisposto.Items.Add(r.societa)
        Next
        If dtData.Count > 0 Then
            cmbClientecheharisposto.SelectedIndex() = 0
            dataSel = cb.SelectedItem
            AddHandler cmbClientecheharisposto.SelectedIndexChanged, AddressOf cmbClientecheharisposto_SelectedIndexChanged
        Else
            dataSel = Nothing
            idCliente = 0
#Disable Warning BC42328 ' L'espressione 'AddressOf' non ha effetto in questo contesto perché l'argomento del metodo per 'AddressOf' richiede una conversione di tipo relaxed del tipo delegato dell'evento
            RemoveHandler cmbClientecheharisposto.SelectedIndexChanged, AddressOf cmbClientecheharisposto_SelectedIndexChanged
#Enable Warning BC42328 ' L'espressione 'AddressOf' non ha effetto in questo contesto perché l'argomento del metodo per 'AddressOf' richiede una conversione di tipo relaxed del tipo delegato dell'evento
            cmbClientecheharisposto.ResetText()
        End If
    End Function
    Private Function cmbClientecheharisposto_SelectedIndexChanged()
        Dim cb As ComboBox
        cb = cmbClientecheharisposto
        Dim Cliente As String = cb.SelectedItem
        Dim dtVota As DataTable = Me.dsControlloQualita.dtQuestionarioVotazione
        Dim dtData = From v As dsControlloQualita.dtQuestionarioVotazioneRow In dtVota Where v.idQuestionario >= idQuestionario And v.societa = Cliente
        idCliente = IIf(IsDBNull(dtData(0).idcliente), 0, dtData(0).idcliente)

    End Function

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If idCliente > 0 And dataSel.ToShortDateString <> "1/1/1900" And idQuestionario > 0 Then
            btnGeneraReport.Enabled = True
        Else
            btnGeneraReport.Enabled = False
        End If
    End Sub

    Private Sub btnStampatutto_Click(sender As Object, e As EventArgs) Handles btnStampatutto.Click
        Dim dtVota As DataTable = Me.dsControlloQualita.dtQuestionarioVotazione
        Dim dgwTMP As New DataGridView
        With dgwTMP
            .Left = 10
            .Top = 10
            .Height = 300
            .Width = 300
        End With

        Dim dtData = From v As dsControlloQualita.dtQuestionarioVotazioneRow In dtVota Where v.idQuestionario >= idQuestionario Order By v.data Descending Group By v.societa Into Group
        For Each r In dtData

            dtQuestionarioVotazioneBindingSource.Filter = String.Format("idCliente = {0} And al = '{1}' AND idQuestionario = {2}", r.Group.First.idcliente, r.Group.First.al, r.Group.First.idQuestionario)
            Me.ReportViewer1.RefreshReport()
        Next

    End Sub
End Class