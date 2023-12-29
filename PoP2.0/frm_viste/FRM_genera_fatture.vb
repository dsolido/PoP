Imports System.Text

Public Class FRM_genera_fatture

    Dim x_periodo As String
    Private nome As String = GlobalVarPOP.G_nomeutente
    Private Sub FRM_genera_fatture_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oldNum As DataRow = Nothing
        Try
            'recupera le infomrazioni dell'utente 
            oldNum = dsolidofunc.legge_informazioni(Me.Name, nome)    'ricarica i valori salvati
            Dim TAnno As Integer
            Try
                TAnno = oldNum.Item("anno")
            Catch ex As Exception
                TAnno = Now().Year
            End Try
            x_periodo = LoadPeriodo(oldNum)
            If x_periodo = "-00" Then
                x_periodo = Now.Year.ToString & "-" & ("0" & Now().Month).PadRight(2)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try




        '        AddHandler TT_CB_anno.SelectedIndexChanged, AddressOf CMB_periodo_SelectedIndexChanged
        '       AddHandler TT_CB_mese.SelectedIndexChanged, AddressOf CMB_periodo_SelectedIndexChanged
        caricaDB()

        Me.TA_tipo_servizio.mostra(Me.DS_generatore_fatture.DT_tipo_servizio)
        Me.TA_iva_codici.Fill(Me.DS_generatore_fatture.DT_iva_codici)
        Me.TA_generatore_fatture.mostra(Me.DS_generatore_fatture.DT_generatore_fatture)
        For Each riga In Me.DS_generatore_fatture.DT_tipo_servizio.Select("descrizione <> ''", "id ASC")
            LB_tipo_servizio.Items.Add(riga.Item("descrizione"))
        Next
        LB_tipo_servizio.SelectionMode = SelectionMode.MultiSimple
        DG_fatturabili.Sort(DG_fatturabili.Columns("C_societa"), System.ComponentModel.ListSortDirection.Ascending)
        DG_generatore.Sort(DG_generatore.Columns("COL_societa"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub caricaDB()
        Try
            Me.TA_clienti_fatturabili.FillBybudget_attivo(Me.DS_generatore_fatture.DT_clienti_fatturabili, 1, 1)
        Catch ex As Exception
            Dim Err As DataRow() = Me.DS_generatore_fatture.DT_clienti_fatturabili.GetErrors
            Dim msg As New StringBuilder
            For Each e In Err
#If DEBUG Then
                Console.WriteLine(e.RowError)
#End If
            Next
        End Try

    End Sub

    Private Sub CMB_periodo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TT_CB_anno.SelectedIndexChanged, TT_CB_mese.SelectedIndexChanged
        x_periodo = TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0") 'aggiunge uno per'problemi suoi.... hahahah
    End Sub
    Private Sub BT_canoni_Click(sender As Object, e As EventArgs) Handles TS_BT_selezione.Click
        Dim d As Integer
        Dim o As DataGridViewRow
        Dim cell As DataGridViewCheckBoxCell
        Dim c_id_dest As DataGridViewTextBoxCell
        Dim r_id_dest(0) As Integer
        Dim n As Integer = 0
        Dim n_fatt As Integer

        DG_generatore.ClearSelection()
        Dim tmp_generate As New DataTable
        Dim tmp_riga As DS_generatore_fatture.DT_generatore_fattureRow
        tmp_generate = DS_generatore_fatture.DT_generatore_fatture.Clone()

        For Each aut_clienti In DG_fatturabili.SelectedRows
            n_fatt += 1
            For Each o In DG_generatore.Rows
                If o.Cells.Item("DG_destinatari_ID_CLI").Value = aut_clienti.cells.item("DG_clienti_ID").value Then
                    For Each d In LB_tipo_servizio.SelectedIndices
                        If o.Cells.Item("id_tipo_intervento").Value = d Then
                            c_id_dest = o.Cells.Item("COL_id_dest")
                            cell = o.Cells.Item("attiva")
                            cell.Value = 1
                            Dim g_pos As Integer = BS_generatore_fatture.Find("id_dest", c_id_dest.Value)
                            tmp_riga = DirectCast(BS_generatore_fatture.Item(g_pos), DataRowView).Row
                            tmp_generate.ImportRow(tmp_riga)
                            n += 1
                            If n > 0 Then
                                'adegua il valore dell'array
                                Array.Resize(r_id_dest, r_id_dest.Length + 1)
                            End If
                        End If
                    Next
                End If
            Next
        Next
#If DEBUG Then

        For Each h In tmp_generate.Rows
            Try
                If h.societa <> Nothing Then
                    Console.WriteLine(h.societa)
                End If
            Catch ex As Exception
            End Try
        Next
        Console.WriteLine(r_id_dest.Length)
#End If
        LB_numero_fastture.Text = "Fatture Clienti Generate : " & n_fatt
        genera_albero()
        Dim risp As DialogResult
        risp = MessageBox.Show("Procedo con l'elaborazione ?", "Seleziona ?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        Select Case risp
            Case DialogResult.Yes
                'avvia la generazione delle fatture
                genera_fattura(tmp_generate)
            Case DialogResult.No
                'Vuota completamente le selezioni fatte
                If Me.Controls.Contains(elenco_gen_fatture) Then
                    Svuota_albero()
                    For Each o In DG_generatore.Rows
                        cell = o.Cells("attiva")
                        cell.Value = 0
                    Next
                    LB_numero_fastture.Text = "Nessuna fattura generata : " & n_fatt
                End If
                BT_deseleziona.PerformClick()
            Case DialogResult.Cancel
        End Select
    End Sub

    Private Sub Svuota_albero()
        elenco_gen_fatture.Nodes.Clear()
    End Sub

    Private Sub BT_seleziona_Click(sender As Object, e As EventArgs) Handles BT_seleziona.Click
        For Each v In DG_fatturabili.Rows
            Try
                v.selected = True
                v.cells.item("R_fattura").value = 1
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub genera_albero()

        Dim o As DataGridViewRow
        Dim cell As DataGridViewCheckBoxCell
        Dim c_id_dest As Integer
        Dim c_id_clie As Integer
        Dim c_canone As Decimal
        Dim c_riga As String
        Dim c_societa As String
        Dim root = New TreeNode
        Dim n As Integer = 0
        Dim tot_per As Integer = 0
        elenco_gen_fatture.Nodes.Clear()
        root.Text = x_periodo                 'attiva il treeview ed inizializza il primo nodo
        root.Name = x_periodo                 'immette il nome univoco del primo nodo
        elenco_gen_fatture.Nodes.Add(root)
        Dim nodo_cli_vecchio As String = ""     'serve a capire quando cambia il nodo
        Dim old_id_Cli As Integer = 0           'meomorizza il numero id_cliente per la variaizonze dei totali
        Dim tot_cli(1) As Decimal
        Dim tot_des_cli(1) As Decimal

        Dim t As Integer = DG_generatore.Rows.Count
        Dim x_cli As Integer = 0                    'contatore per i totali dei clienti
        DG_generatore.Sort(DG_generatore.Columns("COL_societa"), System.ComponentModel.ListSortDirection.Ascending)
        For Each o In DG_generatore.Rows
            cell = o.Cells("attiva")
            If cell.Value = 1 Then   'se é selezionato
                n += 1
                c_id_dest = o.Cells.Item("COL_id_dest").Value
                c_id_clie = o.Cells.Item("DG_destinatari_ID_CLI").Value
                c_canone = o.Cells.Item("COL_canone").Value
                c_riga = o.Cells.Item("COL_riga_fattura").Value
                c_societa = o.Cells.Item("COL_societa").Value
                'c_destinatario = o.Cells.Item("fatturo").Value
                Dim nodo_cli As String = "C-" & c_id_clie.ToString.PadLeft(10, "0") 'ipotizza un codice unico ID
                Dim nodo_des As String = "D-" & c_id_dest.ToString.PadLeft(10, "0")
                Dim old_nodo As String = ""
                tot_per = tot_per + c_canone   'somma tutti i canoni
                If nodo_cli_vecchio <> nodo_cli Then
                    'se cambia il cliente crea una nuova diramazione
                    AddSottoNodo(elenco_gen_fatture, root.Name, nodo_cli, "")
                End If
                AddSottoNodo(elenco_gen_fatture, nodo_cli, nodo_des, "")            'stesso cliente nuova destinazione
                nodo_cli_vecchio = nodo_cli
                Console.WriteLine(nodo_cli)
                If old_id_Cli = c_id_clie Then  'se il cliente rimane invariato aggiunge al totale cliente
                    tot_cli(x_cli) = tot_cli(x_cli) + c_canone
                    tot_des_cli(x_cli) = c_canone
                    'inserisce il testo sul nodo
                    Dim testo As String = c_societa.PadRight(50) & tot_cli(x_cli)
                    elenco_gen_fatture.Nodes(root.Name).Nodes(nodo_cli).Text = testo
                Else    'se il cliente cambia
                    x_cli = x_cli + 1
                    old_id_Cli = c_id_clie
                    Array.Resize(tot_cli, tot_cli.Length + 1)   'aumenta il valore dell'array
                    Array.Resize(tot_des_cli, tot_des_cli.Length + 1)   'aumenta il valore dell'array
                    tot_cli(x_cli) = c_canone
                    tot_des_cli(x_cli) = c_canone
                    Dim testo As String = c_societa.PadRight(50) & " € " & tot_cli(x_cli)
                    elenco_gen_fatture.Nodes(root.Name).Nodes(nodo_cli).Text = testo
                End If
                'inserisce la descrizione del destinatario
                Dim des_text As String = c_riga.PadRight(50) & " € " & c_canone
                elenco_gen_fatture.Nodes(root.Name).Nodes(nodo_cli).Nodes(nodo_des).Text = des_text
            End If
        Next
        'inserisce il primo cliente

    End Sub
    Private Sub genera_fattura(ByVal DT_elenco As DataTable)
        'imposta il periodo di fatturazione
        Dim mese As Integer = TT_CB_mese.SelectedIndex + 1
        'x_periodo.Split("-").Skip(1).First
        Dim anno As Integer = x_periodo.Split("-").First
        Dim _dataFat As New DateTime
        _dataFat = DateSerial(anno, mese + 1, 0)
        'abbina un Binding al Datatable
        Dim BS_elenco As New BindingSource
        BS_elenco.DataSource = DT_elenco
        BS_elenco.Sort = "societa"
        Dim oldCli As Integer = 0 'memorizza l'ultimo identificativo Cliente
        Dim newCli As Integer = 0 'memorizza id cliente
        Dim _nuovo_num(1) As String
        Dim ordine As Integer = 0 'inserisce il numero di ordinamento delle righe in fattura
        Dim nProgress As Integer = 0
        'Se esistono righe che contengono clienti inizia il ciclo
        Dim totalerighe As Integer = BS_elenco.Count
        If totalerighe > 0 Then
            TS_PB_genera.Maximum = totalerighe
            'Cicla il Binding con la tablella dei clienti selezionati
            Dim new_id_righe As Integer = 0
            For Each riga In BS_elenco
                'aziona una barra progressiva
                nProgress += 1
                TS_PB_genera.Value = nProgress
                Dim fat_pa As Integer = riga.Item("pagamento")
                Dim num As Integer = riga.Item("num")
                newCli = riga.Item("id_cli")
                'se il numero di giorni é inferiore o = a 0 allora lo aumenta per calcolare la scadenza corretta
                num = IIf(num <= 0, 20, num)
                Dim _TmpSca As DateTime = _dataFat.AddDays(num)
                Dim _dateSca As New DateTime
                _dateSca = DateSerial(_TmpSca.Year, _TmpSca.Month, 0)
                If oldCli <> newCli Then
                    Dim continuo As String()
                    continuo = nuovo_numero_fattura()
                    If continuo.Length = 0 Then
                        Return
                    Else
                        _nuovo_num = continuo 'assegna un nuovo numero di fattura
                    End If
                    Using ad As New DS_generatore_fattureTableAdapters.TA_fatture
                        ad.Inserisce(_nuovo_num(1), _nuovo_num(0), newCli, _dataFat, _dateSca, 0, "01-01-1900", "", riga.item("condomino"),
                              0, riga.item("extra"), Now, fat_pa)
                        ordine = 0
                    End Using
                End If
                oldCli = newCli
                'Aggiunge il numero di ordine delle righe
                ordine += 1
                'Using ad As New DS_generatore_fattureTableAdapters.Interrogazioni_fattura
                '    new_id_righe = ad.ultimoIDrighe + 1 'assegna il numero progressivo alla riga fattura
                'End Using
                Using ad As New DS_generatore_fattureTableAdapters.TA_righe_fatture
                    Dim val_IVA As DS_generatore_fatture.DT_iva_codiciRow
                    Dim valore As Decimal
                    'Seleziona il tipo di valore IVA
                    For Each val_IVA In Me.DS_generatore_fatture.DT_iva_codici
                        If val_IVA.codiceiva = riga.Item("fatturabile") Then
                            valore = val_IVA.valoreiva
                        End If
                    Next
                    ad.Inserisce(ordine, _nuovo_num(0), riga.item("riga_fattura"), 1, riga.item("canone"), 0, valore, riga.item("id_dest"), newCli,
                     1, Now, riga.item("fatturabile"), riga.item("extra"))
                End Using
                Console.WriteLine(newCli)
            Next
            MsgBox("Terminata elaborazione", MsgBoxStyle.Information)
            TS_PB_genera.Value = 0
        End If

    End Sub

    Private Function nuovo_numero_fattura() As String()
        'Ottiene il numero nuovo fattura
        Dim anno As Integer = TT_CB_anno.SelectedItem
        Dim _d(1) As String
        Using oldN As New DS_generatore_fattureTableAdapters.Interrogazioni_fattura
            _d(0) = oldN.ultimonumeroFattura(anno)
            _d(1) = oldN.idprogressivoFattura(anno)
            If _d(0) = Nothing Then
                If MsgBox("Procedo con la nuova numerazione? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    _d(0) = "0001/" & anno.ToString
                    _d(1) = "1"
                Else Return Nothing
                End If
            End If
            _d(0) = _d(1).ToString.PadLeft(4, "0") & "/" & _d(0).Split("/").Skip(1).First
        End Using
        Return (_d)
    End Function
    Private Sub AddSottoNodo(ByVal tvw As TreeView, ByVal parentKey As String, ByVal childKey As String, testo As String)
        If tvw.Nodes.IndexOfKey(parentKey) > -1 Then
            tvw.Nodes(parentKey).Nodes.Add(childKey, testo)
        Else
            Dim nd As TreeNode = TrovaNodo(tvw.Nodes, parentKey)
            If nd IsNot Nothing Then
                nd.Nodes.Add(childKey, testo)
            Else
                Throw New IndexOutOfRangeException("Nodo con chiave '" & parentKey & "' non trovato")
            End If
        End If
    End Sub
    Private Function TrovaNodo(ByVal tnodescoll As TreeNodeCollection, ByVal key As String) As TreeNode
        For Each nd In tnodescoll
            Dim nodo As TreeNode = SottoNodo(nd, key)
            If nodo IsNot Nothing Then
                Return nodo
            Else
                Return TrovaNodo(nd.nodes, key)
            End If
        Next
        Return Nothing
    End Function
    Private Function SottoNodo(ByVal nodo As TreeNode, ByVal key As String) As TreeNode
        If nodo.Nodes.IndexOfKey(key) > -1 Then
            Return nodo.Nodes.Item(key)
        Else
            Return Nothing
        End If
    End Function

    Private Sub BT_deseleziona_Click(sender As Object, e As EventArgs) Handles BT_deseleziona.Click
        For Each v In DG_fatturabili.Rows
            Try
                v.selected = False
                v.cells.item("R_fattura").value = 0
            Catch ex As Exception

            End Try
        Next
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

    Private Sub BT_cerca_Click(sender As Object, e As EventArgs) Handles TS_BT_cerca.Click
        Dim testo As String = TS_TX_ricerca.Text
        If testo.Length > 0 Then
            BS_clienti_fatturabili.Filter = String.Format("societa LIKE '%{0}%'", testo)
        Else
            BS_clienti_fatturabili.RemoveFilter()
        End If

    End Sub

    Private Sub TS_BT_termina_Click(sender As Object, e As EventArgs) Handles TS_BT_termina.Click
        P_chiusuraApp(BS_clienti_fatturabili)
        Me.Close()
    End Sub
    Private Sub P_chiusuraApp(ByVal BS_tmp As BindingSource)
        Dim mese As Integer = (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
        Dim anno As Integer = TT_CB_anno.SelectedItem
        Dim posizione As String = ""
        Dim rTemp As DS_generatore_fatture.DT_clienti_fatturabiliRow = Nothing
        If BS_tmp.Count > 0 Then
            rTemp = DirectCast(BS_tmp.Current, DataRowView).Row
            posizione = rTemp.id
        End If

        Dim N_ultimo_ID As Integer = rTemp.id
        Dim nome_ri As Array = {BS_tmp.DataMember, "id", N_ultimo_ID.ToString, mese.ToString, anno.ToString, posizione}
        If Not memorizza_informazioni(Me.Name, BS_tmp.Position, nome, nome_ri) Then
            MessageBox.Show("problemi con la memorizzazione delle informazioni in uscita")
        End If
        Me.Dispose()
    End Sub

    Private Sub BT_caricaOrdini_Click(sender As Object, e As EventArgs) Handles BT_caricaOrdini.Click
        CaricaTreeOrdini()
    End Sub
    Private Sub CaricaTreeOrdini()
        Dim TRoo As TreeNode
        Dim TRCli As TreeNode = Nothing
        Dim TRLoc As TreeNode = Nothing
        Dim TRNoo As TreeNode = Nothing
        Dim RG As DS_generatore_fatture.DT_ordiniRow
        Using TA As New DS_generatore_fattureTableAdapters.TA_ordini
            Using DT As New DS_generatore_fatture.DT_ordiniDataTable
                Try
                    TA_ordini.FillByPeriodo(DT, GlobalVarPOP.G_idAZ, x_periodo)

                Catch ex As Exception
                    Dim err As DataRow() = Me.DS_generatore_fatture.DT_ordini.GetErrors
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
                        TRCli.Nodes.Item(OldOL).Tag = RG.id     'tagga l' ordine clienti per usi futuri
                    End If
                    'Evidenzia se è uno straordinario

                    If RG.fatturabile = 2 Then
                        TRCli.Nodes.Item(OldOL).NodeFont = nFonB
                    Else
                        TRCli.Nodes.Item(OldOL).NodeFont = nFonN
                    End If
                    'If L_esteso Then
                    '    ' Calcola il totale per le stesse note
                    '    TNot = TNot + RG.totNetto
                    '    Dim Confronto1 As String = IDLoc.ToString & IDNot.Trim
                    '    Dim Confronto2 As String = RG.id_locazione.ToString & RG.annotazioni.Trim
                    '    If Confronto1.Trim <> Confronto2.Trim Then
                    '        TNot = 0
                    '        OldNot = RG.annotazioni
                    '        OldON = "NT:" & RG.id.ToString
                    '        TRNoo = TRLoc.Nodes.Add(OldON, OldNot)
                    '    End If
                    '    'Dettaglio riga 
                    '    rigaFigl = RG.locazione & " " & " Tipo " & " " & RG.descrizione & " Ore " & RG.totale & If(RG.note.Trim.Length > 0, " note " & RG.note.Trim, "")
                    '    'Aggiunge il dettaglio sotto le note
                    '    TRNoo.Nodes.Add("RG" & RG.id.ToString, rigaFigl)
                    '    'Assegna all'albero delle Note
                    '    TRLoc.Nodes.Item(OldON).Text = OldNot & " n° " & TNot.ToString("N2")
                    '    'Assegna all'albero del Destinatario il totale

                    'End If
                    'Nuova nota
                    TGen = TGen + RG.totNetto
                    TDes = TDes + RG.totNetto
                    TCli = TCli + RG.totNetto

                    TRCli.Nodes.Item(OldOL).Text = OldLoc & " n° " & TDes.ToString("N2")
                    'Prova ad assegnare il totale al Clien te
                    TRoo.Nodes.Item(OldOC).Text = OldCli & " n° " & TCli.ToString("N2")
                    IDLoc = RG.id_locazione
                    IDCli = RG.id_cliente
                    IDNot = RG.annotazioni
                Next
                TV_ordini.Nodes.Item("RD01").Text = "Totale Ordini " & TGen.ToString("N2")
                PB_ordini.Value = 0
            End Using
        End Using
    End Sub

    Private Sub TV_ordini_AfterSelect(sender As Object, e As TreeNodeMouseClickEventArgs) Handles TV_ordini.NodeMouseDoubleClick
        'Dim tmp_node As New TreeNode
        'tmp_node = e.Node
        'Dim f As New FRM_MOD_righe_ordini(tmp_node.Tag)
        'f.ShowDialog()
    End Sub
End Class