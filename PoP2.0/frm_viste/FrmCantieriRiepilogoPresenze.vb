Public Class frmCantieriRiepilogoPresenze
    Dim S_periodo As String = GlobalVarPOP.GPeriodo
    Dim G_IDAZ As Integer = GlobalVarPOP.G_idAZ
    Private Sub FRM_RiepilogoOreCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim oldNum As DataRow = Nothing

        Try
            'recupera le infomrazioni dell'utente 
            Dim nome As String = GlobalVarPOP.G_nomeutente
            oldNum = dsolidofunc.legge_informazioni(Me.Name, nome)    'ricarica i valori salvati
            AggiornaComboPeriodo(TT_CB_mese, TT_CB_anno)
        Catch
        End Try
        Me.TA_riepilogoOre.FillByPeriodo(Me.DS_utenti.DT_riepilogoOre, S_periodo)
        If Not IsNothing(oldNum) Then
            BS_riepilogo.Position = BS_riepilogo.Find("id", oldNum.Item(8))
        End If


    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Dim mese As Integer
        Dim anno As Integer
        Try
            mese = S_periodo.Substring(5, 2)
        Catch ex As Exception
            mese = Now().Month
        End Try
        Try
            anno = S_periodo.Substring(0, 4)
        Catch ex As Exception
            anno = Now().Year
        End Try
        Dim rg As DS_utenti.DT_riepilogoOreRow = Nothing
        Try
            rg = DirectCast(BS_riepilogo.Current, DataRowView).Row
        Catch ex As Exception

        End Try
        Dim oldid As Object = Nothing
        Dim nome_ri As Array
        Try
            'memorizza il numero di fattura
            oldid = CType(If(Not IsDBNull(rg.id), rg.id, "no"), Integer)
        Catch ex As Exception

        End Try

        If oldid <> Nothing Then
            nome_ri = {Me.Name, "id", oldid, mese.ToString, anno.ToString}
        Else
            nome_ri = {Me.Name, "id", 1, mese.ToString, anno.ToString}
        End If
        Dim nome As String = GlobalVarPOP.G_nomeutente

        If Not memorizza_informazioni(Me.Name, BS_riepilogo.Position, nome, nome_ri) Then
            MessageBox.Show("problemi con la memorizzazione delle informazioni in uscita")
        End If
        Dispose()
        Close()

    End Sub

    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        Dim RG As DS_utenti.DT_riepilogoOreRow
        RG = DirectCast(BS_riepilogo.Current, DataRowView).Row
        'BS_riepilogo.Filter = "id_cli = " & RG.id_cli
        Dim K As New FRM_riepilogo_presenze_Cliente(BS_riepilogo)
        K.ShowDialog()
        BS_riepilogo.RemoveFilter()
    End Sub
    Private Function F_PopolaCMBPeriodo(oldNum As DataRow) As String ' restituisce una stringa indicante il periodo 
        Dim _mese As String() = New String() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"}
        Dim _anno(12) As Integer
        Dim x As Integer = 0
        For l = -10 To 1
            _anno(x) = Now.Year + l
            TT_CB_anno.Items.Add(Now.Year + l)
            x = x + 1
        Next
        For t = 0 To 11
            TT_CB_mese.Items.Add(_mese(t))
        Next
        Try
            Dim nAnn As Integer = TT_CB_anno.FindString(oldNum.Item(11))      'cerca il valore salvato all'interno del combo Anno
            TT_CB_anno.SelectedIndex = nAnn                                  'seleziona l'index corretto
            TT_CB_mese.SelectedIndex = oldNum.Item(10) - 1                     'idem per il mese

        Catch ex As Exception
            TT_CB_anno.SelectedItem = Now.Year                                  'seleziona l'index corretto
            TT_CB_mese.SelectedIndex = Now.Month - 1
        End Try
        Return (TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")) 'aggiunge uno per'problemi suoi.... hahahah
    End Function

    Private Sub TT_CB_anno_Click(sender As Object, e As EventArgs) Handles TT_CB_anno.SelectedIndexChanged, TT_CB_mese.SelectedIndexChanged ' se cambi la data
        If TT_CB_mese.SelectedIndex >= 0 Then
            S_periodo = TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
            Try
                Me.TA_riepilogoOre.FillByPeriodo(DS_utenti.DT_riepilogoOre, S_periodo)
            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub TTTestoRicerca_Click(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        'Dim OldFil As String = BS_riepilogo.Filter
        BS_riepilogo.Filter = String.Format("ricerca LIKE '%{0}%'", TTTestoRicerca.Text)
        Dim NN As Integer = 0
        Do While BS_riepilogo.Count < 1
            NN += 1
            If TTTestoRicerca.Text.Length() > 0 Then
                TTTestoRicerca.Text = TTTestoRicerca.Text.Substring(0, If(TTTestoRicerca.Text.Length() - NN <= 0, 0, TTTestoRicerca.Text.Length() - NN))
                BS_riepilogo.Filter = String.Format("ricerca LIKE '%{0}%'", TTTestoRicerca.Text)
                TTTestoRicerca.SelectionStart = TTTestoRicerca.Text.Length
                G_CambiaColore(TTTestoRicerca)
            Else

                Exit Do
            End If
        Loop
    End Sub

    Private Sub TTBTRicerca_Click(sender As Object, e As EventArgs) Handles TTBTRicerca.Click
        Me.TA_riepilogoOre.FillByPeriodoRaggruppato(DS_utenti.DT_riepilogoOre, S_periodo)
    End Sub
End Class