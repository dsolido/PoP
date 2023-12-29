Imports System.Text

Public Class FrmFattura
    Dim G_periodo As String
    Private nome As String = GlobalVarPOP.G_nomeutente
    Dim ResaMinima As Decimal = GlobalVarPOP.ResaMinima
    Dim FAvvisi As New Form
    Dim LAvvisi As New ListBox
    Dim oldNum As DataRow = Nothing

    Private Sub MascheraAvvisi()
        With LAvvisi
            .Top = 10
            .Left = 10
            .Width = 750
            .Height = 160
        End With

        With FAvvisi
            .StartPosition = FormStartPosition.CenterScreen
            .Width = 800
            .Height = 200
            .Controls.Add(LAvvisi)
        End With
    End Sub
    Private Sub FRM_Fattura_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Me.TA_valuta.Fill(Me.DS_fattura.DT_valuta)
        Me.TA_iva.Fill(Me.DS_fattura.DT_iva)
        Me.TA_tiposervizio.mostra(Me.DS_fattura.DT_tipo_servizio)
        Me.TA_destinatari.Fill(Me.DS_fattura.DT_destinatari)
        Me.TA_cantieri.Fill(Me.DS_fattura.DT_cantieri)

        'recupera le infomrazioni dell'utente 
        oldNum = dsolidofunc.legge_informazioni(Me.Name, nome)    'ricarica i valori salvati

        G_periodo = GlobalVarPOP.GPeriodo
        AggiornaComboPeriodo(TT_CB_mese, TT_CB_anno)
        TT_CB_anno.SelectedItem = G_periodo.Split("-").First
        TT_CB_mese.SelectedIndex = G_periodo.Split("-").Last - 1

        Dim N_id As Integer = If(IsNothing(oldNum), 0, oldNum.Item(3))
        Dim S_po As String = If(IsNothing(oldNum), " ", If(IsDBNull(oldNum.Item(8)), "", oldNum.Item(8)))
        BT_resa.Visible = False
        AddHandler TT_CB_anno.SelectedIndexChanged, AddressOf TT_CB_anno_Controllo
        AddHandler TT_CB_mese.SelectedIndexChanged, AddressOf TT_CB_anno_Controllo

        CaricaFatture(N_id, S_po.PadLeft(4, "0") & "/" & TT_CB_anno.SelectedItem, TT_CB_anno.SelectedItem)
        RiepilogoAnnuale(TT_CB_anno.SelectedItem)

        F_aggiornatotale()
    End Sub
    Private Function CaricaFatture(ByVal numPos As Integer, Optional ByVal ID_stringa As String = "", Optional ByVal TAnno As String = "")


        Me.TA_fattura.FillByPeriodo(Me.DS_fattura.DT_fattura, G_periodo)

        Me.TA_fattura_righe.FillByPeriodo(Me.DS_fattura.DT_fattura_righe, G_periodo)

        Me.TA_fattura_tot.FillByPeriodo(Me.DS_fattura.DT_fattura_tot, G_periodo)

        'Me.TA_rese.FillByCliente_Anno(Me.DS_fattura.DT_rese, G_periodo.Split("-").First, G_periodo.Split("-").First)

        Me.TA_contore.FillByPeriodo(Me.DS_fattura.DT_contore, G_periodo)

        Me.TA_contoreTot.FillByPeriodo(Me.DS_fattura.DT_contoreTot, G_periodo)

        Me.TA_ore.FillByAnno(Me.DS_fattura.DT_ore, G_periodo.Split("-").First, G_periodo.Split("-").First)

        If ID_stringa = "" Then
            DG_fattura.ClearSelection()
            DG_fattura.CurrentCell = DG_fattura.Item(0, 0)
            DG_fattura.CurrentRow.Selected = True
            Return (True)
        End If
        Dim dg_r As DataGridViewRow
        Dim I_rx As Integer = 0
        For Each dg_r In DG_fattura.Rows
            If dg_r.Cells("Col_numero").Value = ID_stringa Then
                DG_fattura.ClearSelection()
                DG_fattura.CurrentCell = DG_fattura.Item(0, I_rx)    'riposiziona sulla riga corretta il datagrid
                DG_fattura.CurrentRow.Selected = True
                Return (True)
            End If
            I_rx += 1
        Next

        Return (True)
    End Function
    Private Function RiepilogoAnnuale(Optional ByVal TAnno As String = "")

        Dim totOre As Decimal
        Dim TotOreMese As Decimal
        Dim totFat As Decimal = 0

        For Each rg In DS_fattura.DT_fattura_tot
            totFat = rg.Item("dapagare")
        Next

        totOre = Me.TA_contoreTot.SQ_totaleAnno(TAnno)

        LBT_totaleAnno.Text = Format(totFat, "C2")
        LBT_oreAnno.Text = Format(totOre, "N2")
        LBT_reseAnno.Text = Format(totFat / totOre, "C2")
        TotOreMese = Me.TA_contoreTot.SQ_totalePeriodo(G_periodo)

        For Each rg In DS_fattura.DT_fattura_tot
            totFat = totFat + rg.Item("dapagare")
        Next
        LBT_totaleMese.Text = Format(totFat, "C2")
        LBT_oreMese.Text = Format(TotOreMese, "N2")
        LBT_reseMese.Text = Format(totFat / TotOreMese, "C2")

        Return (True)

    End Function

    Private Function F_aggiornatotale() As Decimal
        Dim Tot_fattura As Decimal
        Dim Tot_ore As Decimal
        If BS_fatturaFattura_tot.Count = 0 Then
            Return True
        End If
        Tot_fattura = DirectCast(BS_fatturaFattura_tot.Current, DataRowView).Row.Item("tot_netto")
        For Each tt In DG_ore.Rows
            Try
                Tot_ore += tt.cells("GC_oreTot").value
            Catch ex As Exception

            End Try
        Next
        F_aggiornatotale = Tot_fattura / If(Tot_ore = 0, 1, Tot_ore)
        LB_fatturato.Text = "Importo: " & Format(Tot_fattura, "N2")
        LB_ore.Text = "Ore: " & Format(Tot_ore, "N2")
        LB_resa.Text = "Resa: " & Format(F_aggiornatotale, "N2")
        If ResaMinima > F_aggiornatotale Then
            LB_resa.ForeColor = Color.Red
        Else
            LB_resa.ForeColor = Color.Green
        End If

        Return True
    End Function
    Private Function F_resaCliente()
        Dim IDCli As Integer = DirectCast(BS_clienti.Current, DataRowView).Row.Item("id")
        Using ta As New DS_fatturaTableAdapters.TA_rese
            Using dt As New DS_fattura.DT_reseDataTable
                'ta.FillByClienteAnno(dt)

            End Using
        End Using
        Return True
    End Function


    Private Sub Stampa_right(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TTBTStampa.MouseDown
        'se hai premuto il click sinistro su cmd_stampa ti propone il menù di stampa
        If e.Button = Windows.Forms.MouseButtons.Left Then
            menustampa.Show(New Point(MousePosition.X, MousePosition.Y))
        End If
    End Sub
    Private Sub Stpsingola(ByVal sender As Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles menustampa.ItemClicked
        'Dim menu = DirectCast(sender, ContextMenuStrip)
        Dim toolStrip = e.ClickedItem
        Dim posizione As String
        Dim riga As DS_fattura.DT_fatturaRow
        Select Case toolStrip.Name
            Case "TS_stp_singola"
                Dim stampa As New FRM_STP_fatture(BS_fattura, BS_fattura_righe, BS_fatturaFattura_tot)
                riga = DirectCast(BS_fattura.Current, DataRowView).Row
                BS_fattura.Filter = "fat_num_da = '" & riga.fat_num_da & "'"
                stampa.ShowDialog()
                'riga = DirectCast(BS_fattura.Current, DataRowView).Row
                'Me.Cerca_pos.ShowDialog()
                'posizione = Cerca_pos.SelectedPath
                'Dim stampa As New FRM_stp_fattura(riga.fat_num_da, "fattura", G_periodo, posizione)
                'stampa.Show()
            Case "TS_stp_tutte"
                BS_fattura.MoveFirst()
                riga = DirectCast(BS_fattura.Current, DataRowView).Row
                Dim oldnumero As String
                oldnumero = riga.fat_num_da
                Me.Cerca_pos.ShowDialog()
                posizione = Cerca_pos.SelectedPath
                TTPB_stampa.Maximum = BS_fattura.Count
                Try
                    BS_fattura.Position = BS_fattura.Find("fat_num_da", oldnumero)
                Catch ex As Exception
                End Try
                TTPB_stampa.Value = BS_fattura.Position
                Dim totrighe As Integer = BS_fattura.Count

                If MsgBox("confermi la stampa di " & TTPB_stampa.Maximum & " Fatture", MsgBoxStyle.YesNo, "Conferma") = MsgBoxResult.Yes Then
                    Dim supporto As Integer = 0
                    Dim ms As MsgBoxResult = MsgBox("Scegli se stampare su PDF o su CARTA o Annulla?", MsgBoxStyle.YesNoCancel)
                    If ms = MsgBoxResult.No Then
                        supporto = 1
                        Dim stampa As New FRM_stp_fattura(riga.fat_num_da, "fattura", G_periodo, posizione, supporto)
                        stampa.Show()
                    ElseIf ms = MsgBoxResult.Cancel Then
                        Exit Sub
                        MsgBox("Annullata la stampa la stampa")
                        TTPB_stampa.Value = 0
                    ElseIf ms = MsgBoxResult.Yes Then
                        For v = 0 To totrighe - 1
                            BS_fattura.Position = v
                            riga = DirectCast(BS_fattura.Current, DataRowView).Row
                            System.Windows.Forms.Application.DoEvents()
                            Dim stampa As New FRM_stp_fattura(riga.fat_num_da, "fattura", G_periodo, posizione, supporto)
                            stampa.Show()
                            System.Windows.Forms.Application.DoEvents()
                            TTPB_stampa.Value = BS_fattura.Position
                        Next
                    End If
                    MsgBox("Terminata la stampa")
                    TTPB_stampa.Value = 0

                End If
            Case "TS_elenco_fatture"
                riga = DirectCast(BS_fattura.Current, DataRowView).Row
                Dim stampa As New FRM_stp_fattura_elenco(G_periodo)
                stampa.ShowDialog()
        End Select

    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        P_chiusuraApp(BS_fattura)
        Me.Close()
    End Sub
    Private Sub P_chiusuraApp(ByVal BS_tmp As BindingSource)
        Dim mese As Integer = (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
        Dim anno As Integer = TT_CB_anno.SelectedItem
        Dim posizione As String = ""
        Dim S_ultimo_ID As String
        Dim rTemp As DS_fattura.DT_fatturaRow = Nothing
        If BS_tmp.Count > 0 Then
            rTemp = DirectCast(BS_tmp.Current, DataRowView).Row
            posizione = rTemp.fat_num_da
        End If

        If IsNothing(rTemp) Then
            S_ultimo_ID = "0"
        Else
            S_ultimo_ID = rTemp.fat_num_da
        End If
        Dim N_ultimo_ID As Integer = 1
        Try
            N_ultimo_ID = S_ultimo_ID.Split("/").First
        Catch ex As Exception

        End Try

        Dim nome_ri As Array = {BS_tmp.DataMember, "id", N_ultimo_ID.ToString, mese.ToString, anno.ToString, posizione}
        If Not memorizza_informazioni(Me.Name, BS_tmp.Position, nome, nome_ri) Then
            MessageBox.Show("problemi con la memorizzazione delle informazioni in uscita")
        End If
        Me.Dispose()

    End Sub
    Private Sub TTTestoRicerca_func(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        Dim ttt As ToolStripTextBox = DirectCast(sender, ToolStripTextBox)
        Dim txt As String = ttt.Text
        BS_fattura.Filter = String.Format("ricerca LIKE '%{0}%'", txt.Trim)
            If BS_fattura.Count <= 0 Then
            BS_fattura.RemoveFilter()
            ttt.Text = txt.Substring(0, If(txt.Length - 1 <= 0, 0, txt.Length - 1))
            ttt.SelectionStart = ttt.Text.Length
        End If
    End Sub


    Private Sub TTBTModifica_Click(sender As Object, e As EventArgs) Handles TTBTModifica.Click
        Dim Cur_row As DS_fattura.DT_fatturaRow
        Cur_row = DirectCast(BS_fattura.Current, DataRowView).Row
        Dim f As New FRM_mod_fattura(Cur_row)
        f.ShowDialog()
        Cur_row = f.RG_fat
        If f.Modificato Then
            Dim N_id As Int16 = BS_fattura.Position
            Dim S_po As String = Cur_row.fat_num_da

            TA_fattura.QR_modifica(Cur_row.fat_cli_id, Cur_row.fat_data, Cur_row.fat_scad, Cur_row.fat_paga, Cur_row.fat_pa_dat,
                                            Cur_row.fat_pa_des, Cur_row.fat_con_l, Cur_row.fat_pa_imp, Cur_row.fat_cod_iva,
                                            Cur_row.fat_cod_paga, Cur_row.fat_nc, Cur_row.idfatturaunq)
            CaricaFatture(N_id, S_po, TT_CB_anno.SelectedItem)
        End If

    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        Dim RG_fat As DS_fattura.DT_fatturaRow
        'Dim RG_faR As DS_fattura.DT_fattura_righeRow
        RG_fat = DirectCast(BS_fattura.Current, DataRowView).Row

        BS_fattura.EndEdit()

        Dim modificate As Boolean
        Dim N_id As Int16 = BS_fattura.Position
        Dim S_po As String = RG_fat.fat_num_da

        For Each rg In BS_fattura
            RG_fat = DirectCast(rg, DataRowView).Row
            Select Case RG_fat.RowState
                Case DataRowState.Modified
                    RG_fat = ControllaSalvataggioFattura(RG_fat)
                    TA_fattura.QR_modifica(RG_fat.fat_cli_id, RG_fat.fat_data, RG_fat.fat_scad, RG_fat.fat_paga, RG_fat.fat_pa_dat,
                                            RG_fat.fat_pa_des, RG_fat.fat_con_l, RG_fat.fat_pa_imp, RG_fat.fat_cod_iva,
                                            RG_fat.fat_cod_paga, RG_fat.fat_nc, RG_fat.idfatturaunq)
                    RG_fat.AcceptChanges()
                    modificate = True
                Case DataRowState.Added
            End Select
        Next
        If modificate Then
            CaricaFatture(N_id, S_po, TT_CB_anno.SelectedItem)
        End If
    End Sub
    Private Function ControllaSalvataggioFattura(ByRef _RG As DataRow)
        Dim RG As DS_fattura.DT_fatturaRow
        RG = _RG
        RG.fat_pa_des = If(RG.Isfat_pa_desNull, "", RG.fat_pa_des)
        Return (RG)
    End Function
    Private Sub DG_righe_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_righe.CellDoubleClick
        'Carica la finestra delle righe e passa le righe fattura e i datatable dei servizi accessori
        Dim DTtip As DataTable = Me.DS_fattura.DT_tipo_servizio
        Dim DTiva As DataTable = Me.DS_fattura.DT_iva
        Dim DTVal As DataTable = Me.DS_fattura.DT_valuta
        Dim DTCli As DataTable = Me.DS_fattura.DT_cantieri
        Dim DTDes As DataTable = Me.DS_fattura.DT_destinatari
        Dim DTrig As DataTable = Me.DS_fattura.DT_fattura_righe
        Dim ff As New FRM_mod_rigafattura(BS_fattura_righe.Current, BS_fattura.Current,
                                          DTtip, DTiva, DTVal, DTCli, DTDes, DTrig)
        ff.ShowDialog()
        TA_fattura_righe.FillByPeriodo(DS_fattura.DT_fattura_righe, G_periodo)
        Me.TA_fattura_tot.FillByPeriodo(Me.DS_fattura.DT_fattura_tot, G_periodo)
    End Sub

    Private Sub BT_resa_Click(sender As Object, e As EventArgs)
        F_aggiornatotale()
    End Sub

    Private Sub DG_fattura_CellContentClick() Handles DG_fattura.CellClick, DG_fattura.CellEnter
        F_aggiornatotale()
    End Sub

    Private Sub TT_CB_anno_Controllo()
        G_periodo = (TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")) 'aggiunge uno per'problemi suoi.... hahahah
        Dim N_id As Integer = If(IsNothing(oldNum), 0, oldNum.Item(3))
        Dim S_po As String = If(IsNothing(oldNum), " ", If(IsDBNull(oldNum.Item(8)), "", oldNum.Item(8)))
        CaricaFatture(N_id, S_po.PadLeft(4, "0") & "/" & TT_CB_anno.SelectedItem, TT_CB_anno.SelectedItem)
        RiepilogoAnnuale(TT_CB_anno.SelectedItem)

    End Sub

    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click
        Dim rg As DS_fattura.DT_fatturaRow
        rg = DirectCast(BS_fattura.Current, DataRowView).Row

        Dim _nuovo_num(1) As String
        Dim newData As DateTime = rg.fat_data
        Dim newScad As DateTime = rg.fat_scad
        Dim newCond As Integer = rg.fat_con_l
        Dim newCodI As Integer = rg.fat_cod_iva
        Dim newCodP As Integer = rg.fat_cod_paga

        _nuovo_num = nuovo_numero_fattura()
        Using ad As New DS_fatturaTableAdapters.TA_fattura
            ad.QR_inserisce(_nuovo_num(1), _nuovo_num(0), rg.fat_cli_id, newData, newScad, 0, "01-01-1900", "", newCond, 0,
                  newCodI, Now, newCodP)
        End Using
        Using ad As New DS_fatturaTableAdapters.TA_fattura_righe
            ad.QR_inserisce(1, 1, _nuovo_num(0), "nuovo", 1, 0, 0, 0, 1, rg.fat_cli_id,
             1, Now, 1, 1)
        End Using
        CaricaFatture(0, _nuovo_num(0))
        TTBTModifica.PerformClick()
    End Sub
    Private Function Nuovo_numero_fattura()
        'Ottiene il numero nuovo fattura
        Dim anno As Integer = TT_CB_anno.SelectedItem
        Dim _d(1) As String
        Using oldN As New DS_generatore_fattureTableAdapters.Interrogazioni_fattura
            _d(0) = oldN.ultimonumeroFattura(anno)
            _d(1) = oldN.idprogressivoFattura(anno)
            _d(0) = _d(1).ToString.PadLeft(4, "0") & "/" & _d(0).Split("/").Skip(1).First
        End Using
        Return (_d)
    End Function

End Class