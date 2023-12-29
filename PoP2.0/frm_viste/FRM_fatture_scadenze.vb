Public Class FRM_fatture_scadenze
    Private nome As String = GlobalVarPOP.G_nomeutente
    Private OldRiga As DS_contabilita.DT_clienti_scadenzeRow
    Dim periodo As String 'imposta il periodo di intervento
    Dim filtro As String    ' è il filtro degli insoluti

    Private Sub FRM_clienti_contabilita_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim oldNum As DS_servizio.DT_info_pop2Row = Nothing
        Try
            'recupera le infomrazioni dell'utente 
            OldNum = dsolidofunc.legge_informazioni(Me.Name, nome)
        Catch
        End Try
        periodo = LoadPeriodo(oldNum)
        If TT_CB_mese.SelectedIndex < Now.Month - 1 Then
            If MsgBox("Stai lavorando col mese di " & TT_CB_mese.SelectedItem & ", imposto il mese Corretto ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TT_CB_mese.SelectedIndex = Now.Month - 1
            End If
        End If
        If TT_CB_anno.SelectedItem < Now.Year Then
            If MsgBox("Stai lavorando nell'anno " & TT_CB_anno.SelectedItem & ", imposto l'anno Corretto ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TT_CB_anno.SelectedItem = Now.Year
            End If
        End If

        Try
            'identifica la connesione se é remota o locale e la applica sui Tableadapter
            TA_clienti_scadenze.mostra(DS_contabilita.DT_clienti_scadenze)
        Catch
        End Try
        filtro = String.Format(" fat_scad < '{0}' AND fat_paga <= {1} AND fat_pa_fallimento <= {2}", Now.ToShortDateString, 0, 0)
        BS_clienti_scadenze.Filter = filtro
        If Not IsNothing(oldNum) Then
            BS_clienti_scadenze.Position = BS_clienti_scadenze.Find(oldNum.identificativo, oldNum.stringa_identificativo)
        End If
        RB_in.Checked = True

    End Sub
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
            Dim nAnn As Integer = TT_CB_anno.FindString(oldNum.Item("anno"))      'cerca il valore salvato all'interno del combo Anno
            TT_CB_anno.SelectedIndex = nAnn                                  'seleziona l'index corretto
            TT_CB_mese.SelectedIndex = oldNum.Item("mese") - 1                     'idem per il mese

        Catch ex As Exception

        End Try
        Return (TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")) 'aggiunge uno per'problemi suoi.... hahahah
    End Function

    Private Sub Situazione()
        OldRiga = DirectCast(Me.BS_clienti_scadenze.Current, DataRowView).Row
        'invia il codice id dell'ordine al report
        Dim filtro As String = BS_clienti_scadenze.Filter
        Dim attivo As Integer = OldRiga.id_cli
        Dim stp_frm As New frm_stp_sca_ins(filtro)
        stp_frm.ShowDialog()

    End Sub

    Private Sub RB_CheckedChanged(sender As Object, e As EventArgs) Handles RB_in.CheckedChanged, RB_im.CheckedChanged, RB_tutte.CheckedChanged,
                                                                             RB_perdita.CheckedChanged
        Dim chi As New RadioButton
        chi = DirectCast(sender, RadioButton)
        If chi.Name.Length <= 0 Then
            Exit Sub
        End If

        Select Case chi.Name
                'filtra solo fatture a non pagate e non a perdita e non Scadute
            Case "RB_in"
                If RB_in.Checked Then
                    filtro = String.Format(" fat_scad < '{0}' AND fat_paga <= {1} AND fat_pa_fallimento <= {2}", Now.ToShortDateString, 0, 0)
                Else
                    Exit Sub
                End If
                'filtra solo fatture a non pagate e non a perdita
            Case "RB_im"
                If RB_im.Checked Then
                    filtro = String.Format(" fat_paga <= {0} AND fat_pa_fallimento <= {1}", 0, 0)
                Else
                    Exit Sub
                End If
                'filtra solo fatture a Perdita
            Case "RB_perdita"
                If RB_perdita.Checked Then
                    filtro = String.Format(" fat_pa_fallimento = {0}", 1)
                Else
                    Exit Sub
                End If
            Case "RB_tutte"
                If RB_tutte.Checked Then
                    filtro = ""
                Else
                    Exit Sub
                End If
        End Select
        If TTTestoRicerca.Text.Length > 0 Then
            String.Format("ricerca LIKE '%{0}%' AND {1}", TTTestoRicerca.Text.Trim, filtro)
        ElseIf filtro.Length > 0 Then
            BS_clienti_scadenze.Filter = filtro
        Else
            filtro = ""
            BS_clienti_scadenze.RemoveFilter()
        End If
    End Sub
    Private Sub DG_Scadenze_cambiaSelect(sender As Object, e As DataGridViewCellEventArgs) Handles DT_clienti_scadenzeDataGridView.RowEnter
        Try

            Dim riga As DS_contabilita.DT_clienti_scadenzeRow
            riga = DirectCast(BS_clienti_scadenze.Current, DataRowView).Row
            Dim srSocieta As String = If(IsDBNull(DT_clienti_scadenzeDataGridView(5, e.RowIndex).Value), "", DT_clienti_scadenzeDataGridView(5, e.RowIndex).Value)
            Dim totali(2) As Decimal
            Dim tID_Cli As Integer = If(IsDBNull(DT_clienti_scadenzeDataGridView(1, e.RowIndex).Value), 0, DT_clienti_scadenzeDataGridView(1, e.RowIndex).Value)
            totali = ritornaSaldi(tID_Cli)
            TS_LB_totali.Text = String.Format("Cliente : {0}", srSocieta)
            TS_LB_totale.Text = String.Format("Totale {0}", totali(0))
            TS_LB_pagato.Text = String.Format("Pagato {0}", totali(1))
            TS_LB_differenza.Text = String.Format("Differenza {0}", totali(2))
            TS_LB_GranTotale.Text = String.Format("Totale Insoluti {0}", totali(3))

            TS_LB_differenza.Font = New Font(TS_LB_differenza.Font, FontStyle.Bold Or FontStyle.Italic)
            totali = Nothing
        Catch ex As Exception

        End Try

    End Sub

    Private Sub DT_clienti_scadenzeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DT_clienti_scadenzeDataGridView.CellContentClick
        Dim riga As DS_contabilita.DT_clienti_scadenzeRow
        riga = DirectCast(BS_clienti_scadenze.Current, DataRowView).Row
        Dim t_colonna As Integer = DG_BT_Pagato.Index
        If DT_clienti_scadenzeDataGridView(e.ColumnIndex, If(e.RowIndex < 0, 0, e.RowIndex)).ColumnIndex = t_colonna Then
            Dim puls As Integer = DT_clienti_scadenzeDataGridView(e.ColumnIndex, If(e.RowIndex < 0, 0, e.RowIndex)).Value
            If puls = 0 Then
                riga.fat_paga = -2
            Else
                riga.fat_paga = 0
                DT_clienti_scadenzeDataGridView.CurrentRow.DefaultCellStyle.BackColor = DefaultBackColor
                riga.fat_pa_dat = "01/01/1900"
                riga.fat_pa_des = " "
                riga.fat_pa_imp = 0
                BS_clienti_scadenze.CancelEdit()
                DT_clienti_scadenzeDataGridView.CancelEdit()
                Return
            End If
            riga.fat_pa_imp = If(riga.fat_pa_imp <> 0, riga.netto, riga.ivato)
            riga.fat_pa_dat = Now.ToShortDateString
            DT_clienti_scadenzeDataGridView.CurrentCell = DT_clienti_scadenzeDataGridView(DT_clienti_scadenzeDataGridView.Columns("COLpagatonote").Index, If(e.RowIndex < 0, 0, e.RowIndex))
            DT_clienti_scadenzeDataGridView.CurrentRow.DefaultCellStyle.BackColor = Color.LightSalmon
        End If
    End Sub
    Private Function RitornaSaldi(ByVal id_cli As Integer)
        'calcola il totale presente in elenco datagrid
        Dim totInsoluti(3) As Decimal

        For Each righeDG In BS_clienti_scadenze
            totInsoluti(3) = totInsoluti(3) + righeDG.item("ivato")
            If righeDG.item("id_cli") = id_cli Then
                totInsoluti(0) = totInsoluti(0) + righeDG.item("ivato")
                totInsoluti(1) = totInsoluti(1) + righeDG.item("fat_pa_imp")
            End If
        Next
        totInsoluti(2) = totInsoluti(0) - totInsoluti(1)
        Return (totInsoluti)
    End Function
    Private Sub BT_salva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        Dim risposta As MsgBoxResult
        risposta = MsgBox("Confermi il salvataggio dei dati?", MsgBoxStyle.YesNo)
        If risposta = MsgBoxResult.No Then Return

        Dim oldFil As String = BS_clienti_scadenze.Filter
        Dim rs As DataRowState
        Dim tg As DS_contabilita.DT_clienti_scadenzeRow
        For Each rg In BS_clienti_scadenze
            tg = DirectCast(rg, DataRowView).Row
            rs = tg.RowState
            If rs = DataRowState.Modified Then
                If rg.item("fat_paga") = -2 Then
                    Dim id As Integer = rg.item("idfatturaunq")
                    Dim ip As Decimal = rg.item("fat_pa_imp")
                    Dim dp As DateTime = rg.item("fat_pa_dat")
                    Dim pd As String = rg.item("fat_pa_des")
                    Dim pp As Integer = 1
                    Dim pf As Integer = rg.item("fat_pa_fallimento")
                    Using ad As New DS_contabilita.DT_fatturaDataTable
                        Dim rf As New DS_contabilitaTableAdapters.TA_fattura
                        rf.modifica(dp, pd, pp, ip, pf, id)
                    End Using
                Else
                    Dim id As Integer = rg.item("idfatturaunq")
                    Dim ip As Decimal = rg.item("fat_pa_imp")
                    Dim dp As DateTime
                    Dim op As IConvertible = TryCast(rg.item("fat_pa_dat"), IConvertible)
                    If op Is Nothing Then
                        dp = "01/01/1900"
                    Else
                        If IsDBNull(rg.item("fat_pa_dat")) Then
                            dp = "01/01/1900"
                        Else
                            dp = rg.item("fat_pa_dat")
                        End If
                    End If
                    Dim pd As String
                    If IsDBNull(rg.item("fat_pa_des")) Then
                        pd = ""
                    Else
                        pd = rg.item("fat_pa_des")
                    End If
                    Dim pf As Integer = If(IsDBNull(rg.item("fat_pa_fallimento")), 0, rg.item("fat_pa_fallimento"))
                    Dim pp As Integer = rg.item("fat_paga")
                    Using ad As New DS_contabilita.DT_fatturaDataTable
                        Dim rf As New DS_contabilitaTableAdapters.TA_fattura
                        rf.modifica(dp, pd, pp, ip, pf, id)
                    End Using
                End If
            End If

        Next
        TA_clienti_scadenze.mostra(DS_contabilita.DT_clienti_scadenze)
        BS_clienti_scadenze.Filter = oldFil
    End Sub

    Private Sub BT_annulla_Click(sender As Object, e As EventArgs) Handles TTBTannulla.Click
        Dim risposta As MsgBoxResult
        risposta = MsgBox("Annulli ogni modifica?", MsgBoxStyle.YesNo)
        If risposta = MsgBoxResult.No Then Return
        Dim oldFil As String = BS_clienti_scadenze.Filter
        Dim tg As DS_contabilita.DT_clienti_scadenzeRow
        For Each rg In BS_clienti_scadenze
            tg = DirectCast(rg, DataRowView).Row
            tg.RejectChanges()
        Next
        TA_clienti_scadenze.mostra(DS_contabilita.DT_clienti_scadenze)
        BS_clienti_scadenze.Filter = oldFil
    End Sub

    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        Situazione()
    End Sub

    Private Sub TTTestoRicerca_Click(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged

        Do While True
            If BS_clienti_scadenze.Count = 0 Then
                Exit Do
            End If
            Dim ADFiltro As String = If(filtro.Length() > 0, String.Format("AND {0}", filtro), "")
            BS_clienti_scadenze.Filter = String.Format("ricerca LIKE '%{0}%' ", TTTestoRicerca.Text.Trim) & ADFiltro
            If BS_clienti_scadenze.Count < 1 Then
                Dim lunghezza As Int16 = TTTestoRicerca.Text.Length()
                TTTestoRicerca.Text.Substring(0, lunghezza - 1)
            Else
                Exit Do
            End If
        Loop

    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Dim oldPos As Integer = BS_clienti_scadenze.Position
        If BS_clienti_scadenze.Count >= 1 Then
            OldRiga = DirectCast(BS_clienti_scadenze.Current, DataRowView).Row
            'in base al tipo di pulsante decido cosa fare
            Dim nome_ri = {BS_clienti_scadenze.DataMember, "fat_num_da", OldRiga.idfatturaunq, Now.Month, Now.Year, OldRiga.fat_num_da}
            If Not memorizza_informazioni(Me.Name, BS_clienti_scadenze.Position, nome, nome_ri) Then
                MessageBox.Show("problemi con la memorizzazione delle informazioni in uscita")
            End If
        End If
        Me.Dispose()
        Me.Close()
    End Sub

End Class