Imports System.Text

Public Class FRM_mod_rigafattura
    Dim RG_rf As DS_fattura.DT_fattura_righeRow
    Dim RG_ff As DS_fattura.DT_fatturaRow
    Dim TG_ts As DS_fattura.DT_tipo_servizioDataTable
    Dim TG_iv As DS_fattura.DT_ivaDataTable
    Dim TG_va As DS_fattura.DT_valutaDataTable
    Dim TG_cl As DS_fattura.DT_cantieriDataTable
    Dim TG_de As DS_fattura.DT_destinatariDataTable
    Dim TG_ri As DS_fattura.DT_fattura_righeDataTable



    Public Sub New(Optional ByRef rg As DataRowView = Nothing, Optional ByVal rf As DataRowView = Nothing,
                   Optional ByVal ts As DataTable = Nothing, Optional ByVal iv As DataTable = Nothing,
                   Optional ByVal va As DataTable = Nothing, Optional ByVal cl As DataTable = Nothing,
                   Optional ByVal de As DataTable = Nothing, Optional ByVal ri As DataTable = Nothing)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        RG_rf = DirectCast(rg, DataRowView).Row    'Riga righe_Fattura in esame
        RG_ff = DirectCast(rf, DataRowView).Row    'Riga Fattura in esame
        TG_ts = ts 'DT tabella tipo di servizio
        TG_iv = iv 'DT tabella IVA
        TG_va = va 'DT tabella valute
        TG_cl = cl 'DT clienti
        TG_de = de 'DT destinatari
        TG_ri = ri 'DataTable righe fattura
        BS_destinatari.DataSource = TG_de
        BS_righefattura.DataSource = TG_ri
        BS_righefattura.Filter = String.Format("cfa_fa_num = '{0}'", RG_rf.cfa_fa_num)
        BS_righefattura.Position = BS_righefattura.Find("id", RG_rf.id)
        BS_cantieri.DataSource = TG_cl
        BS_tiposervizio.DataSource = TG_ts
        BS_modoiva.DataSource = TG_iv
        BS_valuta.DataSource = TG_va
        CaricaTreeOrdini()
    End Sub
    Private Sub FRM_rigafattura_mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim new_id_righe As Integer = 0
        Using ad As New DS_fatturaTableAdapters.TA_fattura_righe
            new_id_righe = ad.SC_ultimoOrdine(RG_ff.fat_num_da) + 1 'assegna il numero progressivo alla riga fattura
        End Using
        Dim risposta As Boolean = CaricaDati()

        If RG_rf.RowState = DataRowState.Added Then
            RG_rf.cfa_fa_num = RG_ff.fat_num_da
            RG_rf.cfa_idcli = RG_ff.fat_cli_id
            RG_rf.ordine = new_id_righe
        End If

        AddHandler Cfa_quantiTextBox.TextChanged, AddressOf F_aggiornaTotale
        AddHandler Cfa_prezzoTextBox.TextChanged, AddressOf F_aggiornaTotale
    End Sub
    Private Function CaricaDati()
        Dim periodo As String = RG_ff.fat_data.Year & "-" & RG_ff.fat_data.Month.ToString.PadLeft(2, "0")
        'Carica lo storico del cliente
        Try
            Me.TA_fattura_righe.FillByStorico_Cliente(Me.DS_fattura.DT_fattura_righe, RG_ff.fat_cli_id)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_fattura.DT_fattura_righe.GetErrors
            Dim msg As New StringBuilder
            For Each e In err
                Console.WriteLine(e.RowError)
            Next
            Return (False)
        End Try
        Try
            Me.TA_contore.FillByID_cliPeriodo(Me.DS_fattura.DT_contore, RG_ff.fat_cli_id, periodo)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_fattura.DT_contore.GetErrors
            Dim msg As New StringBuilder
            For Each e In err
                Console.WriteLine(e.RowError)
            Next
            Return (False)

        End Try
        Return True

    End Function
    Private Sub CB_ClientiChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CB_clienti.SelectedIndexChanged
        Dim I_tmpID As Integer
        Try
            I_tmpID = Convert.ToInt16(CB_clienti.SelectedValue.ToString)
        Catch ex As Exception
            Return
        End Try
        Cfa_idcliTextBox.Text = I_tmpID
        For Each RG_cl In TG_cl
            If RG_cl.id = I_tmpID Then
                BS_destinatari.Filter = "id_terminale = " & RG_cl.id
            End If
        Next
    End Sub
    Private Sub CB_DestinatariChange() Handles CB_destinatari.SelectedIndexChanged
        Dim I_tmpID As Integer
        Dim RG_des As DS_fattura.DT_destinatariRow
        Try
            I_tmpID = Convert.ToInt16(CB_destinatari.SelectedValue.ToString)
        Catch ex As Exception
            Return
        End Try
        BS_destinatari.Position = BS_destinatari.Find("id", CB_destinatari.SelectedValue)

        RG_des = DirectCast(BS_destinatari.Current, DataRowView).Row

        Cfa_iddestTextBox.Text = RG_des.id
        RG_rf.cfa_iddest = RG_des.id
        'Cfa_prezzoTextBox.Text = RG_des.canone
        'RG_rf.cfa_prezzo = RG_des.canone
        '        Cfa_desTextBox.Text = RG_des.riga_fattura
        '       RG_rf.cfa_des = RG_des.riga_fattura
        Console.WriteLine(RG_des.locazione)
        'imposta il tipo di servizio in base al destinatario

        'Dim S_tiposervizio As String = ""
        'For Each RG_ts In TG_ts
        '    If RG_ts.id = RG_des.extra Then
        '        S_tiposervizio = RG_ts.descrizione
        '        Exit For
        '    End If
        'Next
        'CB_tiposervizio.Text = S_tiposervizio
        'RG_rf.cfa_rc = RG_des.extra
        ''imposta il tipo di servizio in base al destinatario
        'Dim S_tipoIva As String = ""
        'For Each RG_iv In TG_iv
        'If RG_iv.codiceiva = RG_des.extra Then
        '        S_tipoIva = RG_iv.descrizione
        '        Cfa_ivaTextBox.Text = RG_iv.valoreiva
        '        RG_rf.cfa_iva = RG_iv.valoreiva
        '        CB_iva.Text = RG_iv.descrizione
        '        Exit For
        '    End If
        'Next
        'RG_rf.cfa_rc = RG_des.fatturabile
        'CB_iva.Text = S_tipoIva
        CB_valuta.Text = "€"
        'RG_rf.cfa_pulofor = 1
    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()
    End Sub

    Private Sub DT_fattura_righeDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_storico.CellContentDoubleClick
        Dim RG_tmp As DS_fattura.DT_fattura_righeRow
        Dim RG_new As DS_fattura.DT_fattura_righeRow
        RG_tmp = DirectCast(BS_storico.Current, DataRowView).Row
        Dim new_id_righe As Integer = 0
        Using ad As New DS_fatturaTableAdapters.TA_fattura_righe
            new_id_righe = ad.SC_ultimoOrdine(RG_ff.fat_num_da) + 1 'assegna il numero progressivo alla riga fattura
        End Using
        BS_righefattura.AddNew()
        RG_new = DirectCast(BS_righefattura.Current, DataRowView).Row
        RG_new.cfa_dataunica = Now()
        RG_new.ordine = new_id_righe
        RG_new.cfa_des = RG_tmp.cfa_des         'Descrizione copiata
        RG_new.cfa_fa_num = RG_ff.fat_num_da    'Imposta il numero fattura corretto
        RG_new.cfa_idcli = RG_ff.fat_cli_id 'ID cliente
        Try
            RG_new.cfa_iddest = If(RG_rf.Iscfa_iddestNull, 0, RG_rf.cfa_iddest)    'ID destinatario corretto
        Catch ex As Exception
            RG_new.cfa_iddest = 0
        End Try

        RG_new.cfa_iva = RG_tmp.cfa_iva         'Iva copiata
        RG_new.cfa_prezzo = RG_tmp.cfa_prezzo   'Prezzo copiato
        RG_new.cfa_pulofor = RG_tmp.cfa_pulofor 'Tipo Servizio
        RG_new.cfa_quanti = RG_tmp.cfa_quanti   'Quantita
        RG_new.cfa_rc = RG_tmp.cfa_rc           'Tipo Imposte
        RG_new.cfa_sconto = RG_tmp.cfa_sconto   'Sconto
        RG_new.cfa_tipo = RG_tmp.cfa_tipo       '
        RG_new.cod_FE = RG_tmp.cod_FE           'Valore Fattura Eletteronica
        BS_righefattura.EndEdit()
    End Sub

    Private Sub TX_ricercastorico_TextChanged(sender As Object, e As EventArgs) Handles TX_ricercastorico.TextChanged
        Dim Ricerca As String
        Dim TX As New TextBox
        TX = DirectCast(sender, TextBox)
        Ricerca = TX.Text
        BS_storico.Filter = String.Format("cfa_des LIKE '%{0}%'", Ricerca)
        If BS_storico.Count < 1 Then
            BS_storico.RemoveFilter()
            TX.Text = ""
        End If
    End Sub

    Private Function F_aggiornaTotale()
        Try
            Dim Rt As DS_fattura.DT_fattura_righeRow
            Rt = DirectCast(BS_righefattura.Current, DataRowView).Row

            LB_totale.Text = Format((Cfa_quantiTextBox.Text * (Cfa_prezzoTextBox.Text * (1 - Cfa_scontoTextBox.Text))), "N2")
            Rt.totale = Format((Cfa_quantiTextBox.Text * (Cfa_prezzoTextBox.Text * (1 - Cfa_scontoTextBox.Text))), "N2")
        Catch ex As Exception
        End Try
        Return True
    End Function

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim Rt As DS_fattura.DT_fattura_righeRow
        Rt = DirectCast(BS_righefattura.Current, DataRowView).Row
        Dim id As Integer = Rt.id
        If MsgBox("Confermi l'eliminazione della riga " & Chr(13) & Rt.cfa_des, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '            BS_righefattura.Remove(Rt)
            TA_fattura_righe.QR_elimina(id)
            Rt.Delete()
        End If
    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        Dim Rt As DS_fattura.DT_fattura_righeRow

        BS_righefattura.EndEdit()
        For Each rg In BS_righefattura
            Rt = DirectCast(rg, DataRowView).Row
            Select Case Rt.RowState
                Case DataRowState.Modified
                    TA_fattura_righe.QR_modifica(Rt.ordine, Rt.cfa_fa_num, Rt.cfa_des,
                    Rt.cfa_quanti, Rt.cfa_prezzo, Rt.cfa_sconto,
                                                Rt.cfa_iva, Rt.cfa_iddest, Rt.cfa_idcli,
                                                Rt.cfa_pulofor, Rt.cfa_dataunica, Rt.cfa_rc, Rt.cfa_tipo,
                                                Rt.id)
                    Rt.AcceptChanges()
                Case DataRowState.Added
                    F_controlloCoerenza(Rt)
                    Try
                        TA_fattura_righe.QR_inserisce(Rt.id, Rt.ordine, Rt.cfa_fa_num, Rt.cfa_des,
                                                Rt.cfa_quanti, Rt.cfa_prezzo, Rt.cfa_sconto,
                                                Rt.cfa_iva, Rt.cfa_iddest, Rt.cfa_idcli,
                                                Rt.cfa_pulofor, Rt.cfa_dataunica, Rt.cfa_rc, Rt.cfa_tipo)

                    Catch ex As Exception

                    End Try
                    Rt.AcceptChanges()
            End Select
        Next

    End Sub
    Private Function F_controlloCoerenza(ByRef RG As DataRow) As DataRow
        Dim Rt As DS_fattura.DT_fattura_righeRow
        Dim Ri As DS_fattura.DT_ivaRow
        Rt = RG
        Rt.cfa_sconto = If(Rt.Iscfa_scontoNull, 0, Rt.cfa_sconto)
        Rt.cfa_dataunica = Now
        Rt.cfa_des = If(Rt.Iscfa_desNull, " ", Rt.cfa_des)
        Rt.cod_FE = If(Rt.Iscod_FENull, "N6", Rt.cod_FE)

        Dim cod_iva As Integer = DirectCast(BS_destinatari.Current, DataRowView).Row.Item("extra")
        Ri = DirectCast(BS_modoiva.Current, DataRowView).Row
        Rt.cfa_iva = Ri.valoreiva
        Rt.cfa_iva = If(Rt.Iscfa_ivaNull, 0, Rt.cfa_iva)

        Return Rt
    End Function

    Private Sub BT_presenze_Click(sender As Object, e As EventArgs) Handles BT_presenze.Click
        'Dim f As New FRM_inserimento_ore
        'f.ShowDialog()
        Dim periodo As String = RG_ff.fat_data.Year & "-" & RG_ff.fat_data.Month.ToString.PadLeft(2, "0")
        'Carica lo storico del cliente
        Me.TA_contore.FillByID_cliPeriodo(Me.DS_fattura.DT_contore, RG_ff.fat_cli_id, periodo)

    End Sub

    Private Sub DG_destinatari_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_destinatari.CellDoubleClick
        Dim RG_tmp As DS_fattura.DT_destinatariRow
        Dim RG_new As DS_fattura.DT_fattura_righeRow
        Dim RG_can As DS_fattura.DT_cantieriRow
        RG_tmp = DirectCast(BS_destinatari.Current, DataRowView).Row
        RG_can = DirectCast(BS_cantieri.Current, DataRowView).Row
        Dim new_id_righe As Integer = 0
        Using ad As New DS_fatturaTableAdapters.TA_fattura_righe
            new_id_righe = ad.SC_ultimoOrdine(RG_ff.fat_num_da) + 1 'assegna il numero progressivo alla riga fattura
        End Using
        BS_righefattura.AddNew()
        RG_new = DirectCast(BS_righefattura.Current, DataRowView).Row
        RG_new.cfa_dataunica = Now()
        RG_new.ordine = new_id_righe
        RG_new.cfa_des = RG_tmp.riga_fattura         'Descrizione copiata
        RG_new.cfa_fa_num = RG_ff.fat_num_da    'Imposta il numero fattura corretto
        RG_new.cfa_idcli = RG_ff.fat_cli_id 'ID cliente
        RG_new.cfa_iddest = If(RG_rf.Iscfa_iddestNull, 0, RG_rf.cfa_iddest)    'ID destinatario corretto
        RG_new.cfa_prezzo = RG_tmp.canone   'Prezzo copiato
        RG_new.cfa_pulofor = 1 'Tipo valuta
        RG_new.cfa_quanti = 1   'Quantita
        RG_new.cfa_rc = RG_tmp.fatturabile           'Tipo Imposte
        RG_new.cfa_sconto = 0   'Sconto
        RG_new.cfa_tipo = RG_tmp.extra       '
        BS_righefattura.EndEdit()

    End Sub

    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click
        Dim RG_new As DS_fattura.DT_fattura_righeRow

        Dim new_id_righe As Integer = 0
        Using ad As New DS_fatturaTableAdapters.TA_fattura_righe
            new_id_righe = ad.SC_ultimoOrdine(RG_ff.fat_num_da) + 1 'assegna il numero progressivo alla riga fattura
        End Using
        BS_righefattura.AddNew()
        RG_new = DirectCast(BS_righefattura.Current, DataRowView).Row
        OrdineTextBox.Text = new_id_righe
        Cfa_fa_numTextBox.Text = RG_ff.fat_num_da
        Cfa_desTextBox.Focus()
    End Sub

    Private Sub CaricaTreeOrdini()
        Dim TRoo As TreeNode
        Dim TRCli As TreeNode = Nothing
        Dim TRLoc As TreeNode = Nothing
        Dim TRNoo As TreeNode = Nothing
        Dim RG As DS_fattura.DT_ordiniRow
        Dim x_periodo As String = RG_ff.fat_data.Year & "-" & (RG_ff.fat_data.Month).ToString.PadLeft(2, "0")
        Using TA As New DS_fatturaTableAdapters.TA_ordini
            Using DT As New DS_fattura.DT_ordiniDataTable
                Try
                    TA.FillByCliente(DT, GlobalVarPOP.G_idAZ, RG_ff.fat_cli_id, x_periodo)
                Catch ex As Exception
                    Dim err As DataRow() = Me.DS_fattura.DT_ordini.GetErrors
                    Dim msg As New StringBuilder
                    For Each e In err
                        Console.WriteLine(e.RowError)
                    Next
                End Try
                Dim OldLoc As String = ""   'Dettaglio Locazione
                Dim OldCli As String = ""   'Dettaglio CLiente
                Dim OldNot As String = ""   'Dettaglio Note
                Dim rigaFigl As String = "" 'Riga dettaglio
                Dim OldOC As String = ""    'Codice Prima del cambio Cliente 
                Dim OldOL As String = ""    'Codice Prima del cambio Locazione
                Dim OldON As String = ""    'Codice Prima del cambio Note
                Dim IDCli As Integer = 0    'ID CLiente
                Dim IDLoc As Integer = 0    'ID locazione
                Dim IDNot As String = ""    'ID Note
                Dim TNot As Decimal = 0     'Totale Note uguali
                Dim TDes As Decimal = 0     'Totale Locazione
                Dim TCli As Decimal = 0     'Totale Cliente
                Dim TGen As Decimal = 0     'Totale Generale
                Dim nFonN As New Font("Arial", 8, FontStyle.Regular)
                Dim nFonB As New Font("Arial", 8, FontStyle.Bold)
                Dim hn As Integer
                TRoo = TV_ordini.Nodes.Add("RD01", "Totale Ordini ")
                Dim totRighe As Integer = DT.Count
                PB_ordini.Maximum = totRighe
                hn = 0
                For Each RG In DT
                    hn = hn + 1
                    PB_ordini.Value = hn - 1
                    'Nuovo Cliente
                    If IDCli <> RG.id_cliente Then
                        TCli = 0

                        OldCli = RG.societa
                        OldOC = "CT:" & RG.id_cliente.ToString ' memorizza il codice unico per il cliente
                        TRCli = TRoo.Nodes.Add(OldOC, OldCli)    'Crea il nodo clienti
                    End If
                    'Nuovo Destinatario
                    If IDLoc <> RG.id_locazione Then
                        TDes = 0
                        OldLoc = RG.data_ordine.Day & "-" & RG.data_ordine.Month & "*" & RG.locazione
                        OldOL = "LC:" & RG.id_locazione.ToString
                        TRLoc = TRCli.Nodes.Add(OldOL, OldLoc)
                        TRCli.Nodes.Item(OldOL).Tag = RG.id_locazione     'tagga l' ordine clienti per usi futuri
                    End If
                    'Evidenzia se è uno straordinario

                    If RG.fatturabile = 2 Then
                        TRCli.Nodes.Item(OldOL).NodeFont = nFonB
                    Else
                        TRCli.Nodes.Item(OldOL).NodeFont = nFonN
                    End If

                    ' Calcola il totale per le stesse note
                    TNot = TNot + RG.prezzo_unitario * RG.quantita
                    Dim Confronto1 As String = IDLoc.ToString & IDNot.Trim
                    Dim Confronto2 As String = RG.id_locazione.ToString
                    If Confronto1.Trim <> Confronto2.Trim Then
                            TNot = 0
                        OldNot = ""
                        OldON = "NT:" & RG.id_riga.ToString
                        TRNoo = TRLoc.Nodes.Add(OldON, OldNot)
                        End If
                    'Dettaglio riga 
                    rigaFigl = "Q.tà " & RG.quantita.ToString("N2") & "|" & RG.descrizione & " Totale " & (RG.prezzo_unitario * RG.quantita).ToString("N2")
                    'Aggiunge il dettaglio sotto le note
                    TRNoo.Nodes.Add("RG" & RG.id_riga.ToString, rigaFigl)
                    'Assegna all'albero delle Note
                    TRLoc.Nodes.Item(OldON).Text = OldNot & " n° " & TNot.ToString("N2")
                    'Assegna all'albero del Destinatario il totale

                    'Nuova nota




                    TGen = TGen + RG.prezzo_unitario * RG.quantita
                    TDes = TDes + RG.prezzo_unitario * RG.quantita
                    TCli = TCli + RG.prezzo_unitario * RG.quantita

                    TRCli.Nodes.Item(OldOL).Text = OldLoc & " n° " & TDes.ToString("N2")
                    'Prova ad assegnare il totale al Clien te
                    TRoo.Nodes.Item(OldOC).Text = OldCli & " n° " & TCli.ToString("N2")
                    IDLoc = RG.id_locazione
                    IDCli = RG.id_cliente
                    IDNot = " "
                Next
                TV_ordini.Nodes.Item("RD01").Text = "Totale Ordini " & TGen.ToString("N2")
                PB_ordini.Value = 0
            End Using
        End Using
    End Sub


End Class