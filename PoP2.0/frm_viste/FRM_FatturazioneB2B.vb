Imports System.Text
Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports MySql.Data.MySqlClient



Class FRM_FatturazioneB2B
    Dim path As String
    Private nome As String = GlobalVarPOP.G_nomeutente
    Dim S_periodo As String = GlobalVarPOP.GPeriodo

    Private Sub FatturazioneB2B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oldNum As DS_servizio.DT_info_pop2Row = Nothing

        Try
            'recupera le infomrazioni dell'utente 
            oldNum = dsolidofunc.legge_informazioni(Me.Name, nome)    'ricarica i valori salvati

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

        Dim tmpMese, tmpAnno As Integer

        AggiornaComboPeriodo(TT_CB_mese, TT_CB_anno)
        tmpMese = S_periodo.Split("-").Last
        tmpAnno = S_periodo.Split("-").First


        S_periodo = TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
        '        If Not F_caricaFatture() Then
        '       MsgBox("Non caricate correttamente")
        '      End If
        Try
            BS_fattura.Position = BS_fattura.Find(oldNum.identificativo, oldNum.stringa_identificativo)
        Catch ex As Exception

        End Try

    End Sub
    Private Function F_caricaFatture()
        Me.TA_trasmittente.Fill(Me.DS_FE.DT_trasmittente)
        Try
            Me.TA_sommaFE.FillByPeriodo(Me.DS_FE.DT_sommeFE, S_periodo)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_FE.DT_sommeFE.GetErrors
            Dim msg As New StringBuilder
            For Each e In err
                Console.WriteLine(e.RowError)
            Next
            Return (False)
        End Try
        Try
            Me.TA_righeFE.FillByPeriodo(Me.DS_FE.DT_righeFE, S_periodo)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_FE.DT_righeFE.GetErrors
            Dim msg As New StringBuilder
            For Each e In err
                Console.WriteLine(e.RowError)
            Next
            Return (False)
        End Try
        Try
            Me.TA_fatturaFE.FillByPERIODO(Me.DS_FE.DT_fatturaFE, S_periodo)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_FE.DT_fatturaFE.GetErrors
            Dim msg As New StringBuilder
            For Each e In err
                Console.WriteLine(e.RowError)
            Next
            Return (False)
        End Try

        Return (True)
    End Function


    Private Sub TT_CB_anno_SelectChange(sender As Object, e As EventArgs) Handles TT_CB_anno.SelectedIndexChanged, TT_CB_mese.SelectedIndexChanged
        S_periodo = TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
        If Not F_caricaFatture() Then
            MsgBox("Non caricate correttamente")
        End If
    End Sub

    Private Sub CiclaFatture()
        path = TrovaCartella("F:\")
        TTPB.Maximum = BS_fattura.Count
        Dim rg_trasmittente As DS_FE.DT_trasmittenteRow
        rg_trasmittente = DirectCast(BS_trasmittente.Current, DataRowView).Row
        Dim rg_fattura As DS_FE.DT_fatturaFERow
        Dim i As Integer = 0
        Dim numeroFatte As Integer = 0
        For Each rg As DataGridViewRow In DG_fatturaFE.SelectedRows
            TTPB.Value = i
            System.Windows.Forms.Application.DoEvents()
            '
            'Crea la fattura nuova in XML
            '
            Dim id As Integer = rg.Cells(DGWCidfatturaunq.Index).Value
            Dim fn As String = rg.Cells(DGWCnfatt.Index).Value

            Dim Fat As New DS_FE.DT_fatturaFEDataTable
            Dim Rig As New DS_FE.DT_righeFEDataTable
            Using TFE As New DS_FETableAdapters.TA_fatturaFE
                Try
                    TFE.FillByid(Fat, id)
                Catch ex As Exception
                    Dim err As DataRow() = Fat.GetErrors
                    For Each List In err
                        Console.WriteLine(List.RowError)
                    Next
                End Try
            End Using

            Using TFR As New DS_FETableAdapters.TA_righeFE
                TFR.FillBynumerofattura(Rig, fn)
            End Using

            creaFE.nuova(rg_trasmittente, Fat, Rig, path)
            i += 1
            'se supera le due fatture termina
#If DEBUG Then
            ' Cicla solo 15 fatture per evitare di intasare la cartella
            'If numeroFatte > 10 Then
            'Exit For
            'End If
#End If
        Next
        Me.Text = "Terminato la conversione di " & numeroFatte & " fatture su " & i & " in archivio"
        Threading.Thread.Sleep(4000)
        Me.Text = "Fatturazione B2B"
        'MsgBox("Terminato la conversione di " & numeroFatte & " fatture su " & i & " in archivio")
        TTPB.Value = 0
    End Sub

    Public Function TrovaCartella(ByRef nomeCartella As String) As String
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            nomeCartella = FolderBrowserDialog1.SelectedPath
        End If
        If FolderBrowserDialog1.SelectedPath.Trim.Length = 0 Then
            Return False
        Else
            Return nomeCartella
        End If

    End Function


    Private Function LoadPeriodo(oldNum As DataRow) As String
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

        End Try
        Return (TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")) 'aggiunge uno per'problemi suoi.... hahahah
    End Function

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        P_chiusuraApp(BS_fattura)
        Me.Close()
    End Sub
    Private Sub P_chiusuraApp(ByVal BS_tmp As BindingSource)
        Dim mese As Integer = (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
        Dim anno As Integer = TT_CB_anno.SelectedItem
        Dim posizione As String = ""
        Dim S_ultimo_ID As String
        Dim rTemp As DS_FE.DT_fatturaFERow = Nothing
        If BS_tmp.Count > 0 Then
            rTemp = DirectCast(BS_tmp.Current, DataRowView).Row
            posizione = rTemp.fat_num_da
        End If
        If IsNothing(rTemp) Then
            S_ultimo_ID = "0"
        Else
            S_ultimo_ID = rTemp.fat_num_da
        End If
        Dim N_ultimo_ID As Integer = S_ultimo_ID.Split("/").First
        Dim nome_ri As Array = {BS_tmp.DataMember, "fat_num_da", N_ultimo_ID.ToString, mese.ToString, anno.ToString, posizione}
        If Not memorizza_informazioni(Me.Name, BS_tmp.Position, nome, nome_ri) Then
            MessageBox.Show("problemi con la memorizzazione delle informazioni in uscita")
        End If
        Me.Dispose()

    End Sub

    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        CiclaFatture()
    End Sub

    Private Sub TTTestoRicerca_Click(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        Dim TestoRicercato As String = TTTestoRicerca.Text
        BS_fattura.Filter = String.Format("ricerca LIKE '%{0}%'", TestoRicercato.Trim)
        If BS_fattura.Count < 0 Then
            MsgBox("Non trovata corrispondenza")
            BS_fattura.RemoveFilter()
            TTTestoRicerca.Text = ""
        End If
    End Sub

    Private Sub TTBTRicerca_Click(sender As Object, e As EventArgs) 
        BS_fattura.RemoveFilter()
        TTTestoRicerca.Text = ""
    End Sub

    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) 
        Dim f As New frmAggiungeAziendaAutofattura
        f.Show()

    End Sub
End Class
