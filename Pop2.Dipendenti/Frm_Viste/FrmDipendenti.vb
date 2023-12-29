#Disable Warning CA1707 ' Gli identificatori non devono contenere caratteri di sottolineatura
Imports System.IO
Imports System.Text
Imports MySql.Data.MySqlClient
Imports iTextSharp
Imports System.Uri
Imports Microsoft.Reporting.WinForms
Imports System.Globalization

Public Class FrmDipendenti
    Dim G_tipoFile = 1  'identifica il tipo di classificazione dei documenti 1 per i dipendentni, 2 per i clienti e 3 per tutti
#Disable Warning CA1805 ' Non eseguire inutilmente l'inizializzazione
    Dim RidimensionaTab As Boolean = False
#Enable Warning CA1805 ' Non eseguire inutilmente l'inizializzazione
    Dim BS_T As New BindingSource
    Dim BS_Cal As New BindingSource
    Dim G_Disco As String = "V:"        'Disco dove si memorizzano i documenti
    Dim G_nomeUtente As String = GlobalVarPOP.G_nomeutente
    Dim G_DirectoriDipendenti As String = G_Disco & "\ns\documenti\dipendenti\"
    Dim G_DirectoriModelliLettera As String = G_Disco & "\ns\documenti\MODELLI LETTERE\"
    Dim combo_loc As ComboBox   ' ComboBox non ancora valorizzato per le locazioni
    Private status As New StatusBar()
    Dim RRtempContore As DS_utenti.DT_contoreRow
    Dim PeriodoLocale As String
    Dim gArrayNomeUtenti As String() = GlobalVarPOP.gArrayNomeUtenti
    Dim gArrayColoreUtenti As String() = GlobalVarPOP.gArrayColoreUtenti
    Dim ApreChiudetbLayoutPianoLavoro As Boolean = False
    Dim dtUT As DSfestivita.dtPianoDataTable

    Private Sub FRM_Dipendenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TaFileClassificazione.Fill(Me.DSwebcondiviso.dtFileClassificazione)
        Me.TaWebMenu.Fill(Me.DSwebcondiviso.dtWebMenu)
        Me.TaUtentiFerieLeggenda.Fill(Me.DSfestivita.dtUtentiFerieLeggenda)
        Me.TaTipoFormazione.Fill(Me.DSwebcondiviso.dtTipoFormazione)

        BS_Cal.DataMember = "DT_cal"
        Me.Controls.Add(status)
        Dim DT_memo As DS_servizio.DT_info_pop2Row
        DT_memo = dsolidofunc.legge_informazioni(Me.Name, G_nomeUtente)

        AggiornaComboPeriodo(TT_CB_mese, TT_CB_anno)
        PeriodoLocale = GlobalVarPOP.GPeriodo

        AddHandler TT_CB_anno.SelectedIndexChanged, AddressOf aggiornaalcambioperiodo
        AddHandler TT_CB_mese.SelectedIndexChanged, AddressOf aggiornaalcambioperiodo

        Try
            CaricaDatabase()
        Catch ex As Exception
            MsgBox("Problemi nel caricare gli archivi")
        End Try
        Dim II As Int16 = 0

        CK_filtro.SetItemChecked(0, True)
        CK_filtro_controllo()


        AddHandler BS_utenti.CurrencyManager.PositionChanged, AddressOf AggiornamentoRighe
        If Not IsNothing(DT_memo) Then
            BS_utenti.Position = BS_utenti.Find(DT_memo.identificativo, DT_memo.valore_identificativo)
        End If
        Dim posizioneAssoluta As Integer = TBL_anagrafica.Width / 100 * TBL_anagrafica.ColumnStyles(0).Width
        TBL_anagrafica.ColumnStyles(0).SizeType = SizeType.Absolute
        TBL_anagrafica.ColumnStyles(0).Width = posizioneAssoluta
        'Dim cm As CurrencyManager = BSREL_UtentiContore.CurrencyManager
        'Attiva gli handler per l'inserimento delle presenze

        AddHandler DG_contore.EditingControlShowing, AddressOf DG_contore_controlloTesto
        AzzeracoloriDataGridUtenti()
        CKclientiabbinabili.CheckState = CheckState.Checked
        PopolaLeggenda()
    End Sub
    Private Sub DG_contore_controlloTesto(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles DG_contore.EditingControlShowing
        If Not TAB_dipendenti.SelectedTab.Name = TB_inserimentopresenze.Name Then
            Return
        End If
        Dim tt As Integer
        tt = DG_contore.CurrentCell.ColumnIndex

        If tt <> 5 Then
            Return
        End If

        Dim txtbox As TextBox = CType(e.Control, TextBox)
        ' Se c'è un controllo, aggiungo un gestore d'evento
        If Not (txtbox Is Nothing) Then
            AddHandler txtbox.KeyPress, AddressOf P_CellTextBox
        End If
    End Sub
    Private Sub P_CellTextBox(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim tt As DataGridViewCell
        tt = DG_contore.CurrentCell
        If tt.ColumnIndex <> DG_contore.Columns.Item("COL_orepresenza").Index Then
            Return
        End If
        Dim TX_temp As TextBox
        TX_temp = DirectCast(sender, TextBox)
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii < 48 And KeyAscii <> 24 And KeyAscii <> 8 And e.KeyChar <> "," And e.KeyChar <> "." Then
            KeyAscii = 0
        ElseIf KeyAscii > 58 Then
            KeyAscii = 0
        End If
        If e.KeyChar = "." Then
            KeyAscii = 44
        End If
        ' I 2punti è consentito
        ' ma non come primo carattere
        ' ovviamente se c'è una virgola
        ' non è consentito digitarne altri

        If KeyAscii = 44 And
            TX_temp.Text.IndexOf(",") > 1 Then
            KeyAscii = 0
        End If
        ' Reimposto il keychar
        e.KeyChar = Chr(KeyAscii)
    End Sub
    Private Sub AggiuntaBSContore(ByVal sender As Object, ByVal e As System.ComponentModel.AddingNewEventArgs) Handles BSREL_UtentiContore.AddingNew
        If BSREL_UtentiContore.Count > 0 Then
            RRtempContore = DirectCast(BSREL_UtentiContore.Current, DataRowView).Row
        End If
    End Sub
    Private Sub AggiuntaBSContoreListamodificata(ByVal sender As Object, ByVal e As System.ComponentModel.ListChangedEventArgs) Handles BSREL_UtentiContore.ListChanged
        'Console.WriteLine(e.ListChangedType.ToString)
        If TAB_dipendenti.SelectedTab.Name <> TB_inserimentopresenze.Name Then
            Return
        End If
        If IsNothing(RRtempContore) Then
            Return
        End If

        If e.ListChangedType.ToString = "ItemAdded" Then
            DG_contore(0, DG_contore.Rows.Count - 1).Value = RRtempContore.data
            DG_contore(1, DG_contore.Rows.Count - 1).Value = RRtempContore.id_cli
            DG_contore(3, DG_contore.Rows.Count - 1).Value = RRtempContore.id_tipo
            BSREL_UtentiContore.EndEdit()
        Else
            DG_contore(0, DG_contore.Rows.Count - 1).Value = ""
            DG_contore(1, DG_contore.Rows.Count - 1).Value = ""
            DG_contore(3, DG_contore.Rows.Count - 1).Value = ""
            BSREL_UtentiContore.EndEdit()
        End If
    End Sub

    Private Sub DG_contore_DataError(ByVal sender As Object, ByVal e As DataGridViewDataErrorEventArgs) Handles DG_contore.DataError

        If (e.Context = DataGridViewDataErrorContexts.Commit) Then
            DG_contore.Rows(e.RowIndex).Cells(0).Selected = True
            DG_contore.CancelEdit()
            If Not IsNothing(combo_loc) Then
                combo_loc.Dispose()
            End If
            DG_contore.Focus()
        End If
        If (e.Context = DataGridViewDataErrorContexts _
            .CurrentCellChange) Then
            MessageBox.Show("Cambio Cella")
        End If
        If (e.Context = DataGridViewDataErrorContexts.Parsing) _
            Then
            MessageBox.Show("Errore Sincronia")
        End If
        If (e.Context =
            DataGridViewDataErrorContexts.LeaveControl) Then
            MessageBox.Show("Errore nel rilascio della Cella")
        End If
        If (TypeOf (e.Exception) Is ConstraintException) Then
            Dim view As DataGridView = CType(sender, DataGridView)
            view.Rows(e.RowIndex).ErrorText = "Un Errore "
            view.Rows(e.RowIndex).Cells(e.ColumnIndex) _
                .ErrorText = "Un Errore "
            e.ThrowException = False
        End If
    End Sub
    ' ...In ingresso della cella
    Private Sub DG_contore_enter_cella(sender As Object, e As DataGridViewCellEventArgs) Handles DG_contore.CellEnter
        ' valuta quale colonna è
        'se é la colonna 3 (clienti) allora crea una combobox per scegliere il destinatario
        Dim colonna As Integer = e.ColumnIndex

        Select Case colonna
            Case 0
                Console.WriteLine(DG_contore(e.ColumnIndex, e.RowIndex).Value)


            Case DG_contore.Columns.Item("COL_destinatario").Index
                Try
                    Dim id_cli As Integer = DG_contore.CurrentRow.Cells.Item("C_id_cli").Value

                    BS_destinatari.Filter = "id_terminale = " & id_cli
                    If BS_destinatari.Count <= 0 Then
                        MessageBox.Show("Al Cliente manca il destinatario")
                        DG_contore.CurrentRow.Cells.Item("COL_societa").Selected = True
                        Exit Sub
                    End If
                    ' Istanziamo il ComboBox, e gli assegniamo gli elementi voluti
                    combo_loc = New ComboBox()
                    combo_loc.DataSource = BS_destinatari
                    combo_loc.DisplayMember = "locazione"
                    combo_loc.ValueMember = "id"
                    combo_loc.DropDownStyle = ComboBoxStyle.DropDown
                    combo_loc.FlatStyle = FlatStyle.Standard
                    ' Calcoliamo il rettangolo che rappresenta lo spazio della cella attuale, ed assegnamo al combo
                    ' la Location e la Size corrispondenti, in modo che occupi l'intera cella
                    Dim r As Rectangle = DG_contore.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    combo_loc.Location = New Point(r.X, r.Y)
                    combo_loc.Size = New Size(r.Width, r.Height)
                    ' Aggiungiamo un handler per fare in modo di controllare la selezione sul combo
                    AddHandler combo_loc.SelectedIndexChanged, AddressOf SelezioneCombo

                    ' L'eventuale valore di cella deve essere trasferito come testo del combo
                    combo_loc.SelectedItem = DG_contore.CurrentCell.Value
                    ' Aggiungiamo il combo alla griglia
                    DG_contore.Controls.Add(combo_loc)
                    combo_loc.Focus()
                    'combo_loc.SelectedIndex = 0
                    combo_loc.DroppedDown = True
                Catch ex As Exception

                End Try
            Case COL_tipo.Index

                'Dim combo As DataGridViewComboBoxCell
                'combo = CType(DG_contore(COL_tipo.Index, e.RowIndex), DataGridViewComboBoxCell)
                DG_contore(COL_tipo.Index, e.RowIndex).Value = 0
                'combo.Value = combo.Items(1)
        End Select
    End Sub

    ' ... in uscita dalla cella
    Private Sub DG_contore_lasciacella(sender As Object, e As DataGridViewCellEventArgs) Handles DG_contore.CellLeave
        ' Se il combo è istanziato, e la colonna è la terza, eseguiamo il Dispose del combo, per scaricarlo
        Dim l As Boolean    'se é locazione
        Dim c As Integer
        l = IsNothing(combo_loc)
        c = e.ColumnIndex
        'se non é vero che é nullo il combo ed é sulla colonna specifica
        Select Case c
            Case = 1
            Case = DG_contore.Columns.Item("COL_destinatario").Index
                If Not (l) Then
                    DG_contore.CurrentRow.Cells.Item("C_id_dest").Value = combo_loc.SelectedValue
                    DG_contore.CurrentRow.Cells.Item("COL_destinatario").Value = combo_loc.Text
                    combo_loc.Dispose()
                    'DG_contore.CurrentRow.Cells.Item("COL_tipo").Value = 0
                End If
            Case = 5
                'Memorizza le note in un database
                'Dim testoAnalizzato As String = DirectCast(BSREL_UtentiContore.Current, DataRowView).Row("note")
                'Dim risposta As Integer
                Try
                    'risposta = TA_contore_autocompleta_note.SQesiste(testoAnalizzato)
                Catch
                    '   risposta = 0
                End Try


                'If risposta <= 0 Then
                '    'TA_contore_autocompleta_note.inserisci(globalVarPop.G_nomeutente, testoAnalizzato)
                'End If
        End Select

    End Sub

    ' Handler che controlla la selezione sulla combo
    Private Sub SelezioneCombo(sender As Object, e As System.EventArgs)
        ' Se il combo è istanziato, allora facciamo in modo che il valore della cella venga prelevato dalla selezione in combo
        ' in questo modo, dopo essere usciti dalla combo la cella manterrà il valore selezionato
        Try
            If Not (IsNothing(combo_loc)) Then
                DG_contore.CurrentRow.Cells.Item("C_id_dest").Value = combo_loc.SelectedValue
                DG_contore.CurrentRow.Cells.Item("C_locazione").Value = combo_loc.Text
            End If
        Catch ex As Exception
        End Try

    End Sub


    Private Sub CK_collegato_CheckedChanged(sender As Object, e As EventArgs) Handles CK_collegato.CheckedChanged
        If CK_collegato.CheckState = 1 Then
            If MsgBox("Creo il collegamento ? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                CK_collegato.ImageIndex = CK_collegato.CheckState
                CreaNuovo()
            Else
                CK_collegato.CheckState = 0
                CK_collegato.ImageIndex = CK_collegato.CheckState
            End If
        End If
    End Sub
    'Private Sub TTBT_nuovoRemoto_Click(sender As Object, e As EventArgs) Handles TTBT_nuovoUtenteRemoto.Click
    '    CreaNuovo()
    'End Sub
    Private Sub CreaNuovo()
        Dim RGll As DS_utenti.DT_utentiRow
        RGll = DirectCast(BS_utenti.Current, DataRowView).Row
        'Controlla se esiste già in remoto l'abbinamento
        Dim TTnome As String = RGll.cognome.Substring(0, 2) & RGll.nome.Split(" ").First    'Prova a cercare se esite già un utente con nome o user simili    'Prova a cercare se esite già un utente con nome o user simili

        If RGll.emailname.Length < 4 Then
            If MsgBox("Attenzione manca un indirizzo Email utilizzabile, non posso procedere ", MsgBoxStyle.OkOnly) Then
                BSrr.CancelEdit()
                Return
            End If
        End If
        If RGll.pwd = 0 Then
            If MsgBox("Password inesistente, genero una nuova password ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim NewPassword As Integer
                Dim rnd1 As New Random()
                NewPassword = rnd1.Next(1000, 9999)

#If DEBUG Then
                MsgBox("Ho Creato ex novo la password nell'archivio locale")
#End If
                'TA.ModificaPassword(NewPassword, RGll.id)
                TA_utenti.QRmodificaPWD(NewPassword, NewPassword, RGll.id)
                RGll.pwd = NewPassword
                RGll.AcceptChanges()
            Else
                MsgBox("Devo interrompere la creazione dell'utente remoto" + Chr(13) + " vai in anagrafica utenti " & Chr(13) & "e inserisci la password manualmente")
                BSrr.CancelEdit()
                Return
            End If
        End If
        'abbina la password
        'Procede al salvataggio passando l'ID locale e la riga del Datatable Remoto compilata
    End Sub

    Private Sub AzzeracoloriDataGridUtenti()
        For Each RGDG In dgElencoDipendenti.Rows
            RGDG.cells("C_ore_E").Style.BackColor = Color.White
            RGDG.cells("C_ore_P").Style.BackColor = Color.White
        Next

    End Sub

    Private Sub CaricaTBRiepilogoOreMese()
        If TAB_dipendenti.SelectedTab.Name <> tbPianodilavoro.Name Then
            Return
        End If
        Dim RGloc As DS_utenti.DT_utentiRow
        RGloc = DirectCast(BS_utenti.Current, DataRowView).Row

        Using TA As New DS_utentiTableAdapters.TA_orari
            TA.FillByDipendentePeriodo(Me.DS_utenti.DT_orari, Now(), Now(), RGloc.id)
        End Using
        Using TA As New DS_utentiTableAdapters.TA_orari_totali
            Using DT As New DS_utenti.DT_orari_totaliDataTable
                TA.Fill(DT)
                BS_T.DataSource = DT
            End Using
        End Using
        Using TA As New DS_utentiTableAdapters.TA_cal
            Using DT As New DS_utenti.DT_calDataTable
                TA.FillByPeriodo(DT, PeriodoLocale)
                BS_Cal.DataSource = DT
            End Using
        End Using
        Me.TA_presenzeWEB.FillByPeriodo(Me.DS_utenti.DT_presenzeWEB, PeriodoLocale)

    End Sub
    Private Sub Formazione()
        Select Case TAB_dipendenti.SelectedTab.Name
            Case TB_anagraficadipendenti.Name

        End Select


    End Sub

    Private Sub AggiornamentoRighe()    'Gestione dello spostamento della riga dipendente
        If BS_utenti.Count <= 0 Then
            Return
        End If
        Dim RGll As DS_utenti.DT_utentiRow
        RGll = DirectCast(BS_utenti.Current, DataRowView).Row


        Select Case TAB_dipendenti.SelectedTab.Name
            Case TB_anagraficadipendenti.Name

                LBLanagrafica.Text = RGll.cognome & " " & RGll.nome
                '
                ' Pagina iniziale elenco dipendenti
                '
                TAfile.FillByUtenteTipo(DSwebcondiviso.DTfile, RGll.id, 3)
            Case TB_inserimentopresenze.Name

                LL_anagrafica3.Text = RGll.cognome & " " & RGll.nome
                BS_clienti.Filter = "attivo = 1"
                AggiornaInserimentoOre()

            Case TB_presenzeRemote.Name

                LL_anagrafica1.Text = RGll.cognome & " " & RGll.nome
                LBesitofiltro.Text = "Nessun filtro attivato"
                Pulisce_riepilogo_giorni()
                Dim kDat As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0)
                Using TA As New DS_utentiTableAdapters.TA_cal
                    Using DT As New DS_utenti.DT_calDataTable
                        TA.FillByPeriodo(DT, PeriodoLocale)
                        BS_Cal.DataSource = DT
                    End Using
                End Using
                TaPresenzaStampa.FillByDipendentePeriodo(Me.DS_utenti.dtPresenzaStampa, RGll.id, PeriodoLocale.Replace("-", ""))
                Select Case tabControlloTimbrature.SelectedTab.Name
                    Case tbTimbrate.Name
                        TA_presenzeWEB.FillByutenteperiodo(Me.DS_utenti.DT_presenzeWEB, PeriodoLocale, RGll.id)
                        If BSPresenzeWEB.Count > 0 Then
                            Dim testo(2) As String
                            testo = ElaboraPresenze.CreaGriglieTimbratureRemote(kDat, BSPresenzeWEB, DG_totaleoreweb, DG_totaleOreWebCliente, BS_tipologia, BScal)
                            LBtotaleDipendenteWeb.Text = testo(0)
                            LBtotalepresenzeClienteWEB.Text = testo(1)
                            LBesitofiltro.Text = testo(2)
                        Else
                            LBtotaleDipendenteWeb.Text = "0"
                        End If

                    Case tbPreviste.Name
                        Dim rit As Boolean = GeneraPianodiLavoroDipendente.CaricaIntestazioniPresenzePreviste(dgwOreinagenda, kDat.Day + 1, BS_Cal)
                        Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
                        Using ta As New DSfestivitaTableAdapters.TAtipoorario
                            ta.Fill(dtTipoOrario)
                        End Using

                        GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioDipendente(dgwOreinagenda, dtUT, BS_utenti, PeriodoLocale, dtTipoOrario, False, BS_Cal)
                    Case tbConfrontoPresenze.Name
                        TA_presenzeWEB.FillByutenteperiodo(Me.DS_utenti.DT_presenzeWEB, PeriodoLocale, RGll.id)
                        If BSPresenzeWEB.Count > 0 Then
                            Dim testo(2) As String
                            testo = ElaboraPresenze.CreaGriglieTimbratureRemote(kDat, BSPresenzeWEB, dgwConfrontoPresenze, DG_totaleOreWebCliente, BS_tipologia, BScal, False)
                            LBtotaleDipendenteWeb.Text = testo(0)
                            lbPresenzeCliente.Text = testo(1)
                            LBesitofiltro.Text = testo(2)
                        Else
                            LBtotaleDipendenteWeb.Text = "0"
                        End If
                        Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
                        Using ta As New DSfestivitaTableAdapters.TAtipoorario
                            ta.Fill(dtTipoOrario)
                        End Using

                        dtUT = GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioDipendente(dgwConfrontoPresenze, dtUT, BS_utenti, PeriodoLocale, dtTipoOrario, False, BS_Cal, False)
                        dgwConfrontoPresenze.Sort(dgwConfrontoPresenze.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
                End Select
            Case tbPianodilavoro.Name

                LL_AnagraficaFoglioPresenza.Text = RGll.cognome & " " & RGll.nome
                Dim periodoricerca As String
                periodoricerca = PeriodoLocale.Replace("-", "")
                Me.TAferieutente.FillByUtentePeriodo(Me.DSfestivita.DTferieutente, RGll.id, periodoricerca)

                'Se esiste un piano ferie
                CaricaPianodiLavoro(RGll.id)

                'Carica le tabelle che occorrono per il piano di lavoro
                CaricaTBRiepilogoOreMese()

                'Carica le intestazioni del mese

                GeneraPianodiLavoroDipendente.F_caricaintestazioneMese(dgwSviluppoOreMese, PeriodoLocale)
                Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
                Using ta As New DSfestivitaTableAdapters.TAtipoorario
                    ta.Fill(dtTipoOrario)
                End Using

                'Genera la DataTable che contiene i dati mensili comprese le assenze e sostituzioni e ferie
                GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioDipendente(dgwSviluppoOreMese, dtUT, BS_utenti, PeriodoLocale, dtTipoOrario, False, BS_Cal)

                AggiornaTabPianodiLavoro()

            Case TB_documentidipendenti.Name
                LL_anagrafica.Text = RGll.cognome & " " & RGll.nome
                '
                ' Pagina Documenti Dipendente
                '
                TAfile.FillByUtente(DSwebcondiviso.DTfile, RGll.id, G_tipoFile)
            Case TB_abbinamentoRilevatorePresenze.Name
                LL_abinamentoPresenzeRemote.Text = RGll.cognome & " " & RGll.nome
                '
                ' Aggiornamento Abbinamento Dipendenti Clienti
                '
                FiltroAbbinamentoClienti()
            Case tbWebApp.Name
                llWebAppAnagrafica.Text = RGll.cognome & " " & RGll.nome
                '
                ' Pagina Documenti Dipendente
                '
                ApreDBAutorizzazioni(RGll.id)
                TAfile.FillByUtente(DSwebcondiviso.DTfile, RGll.id, G_tipoFile)
                creaGruppoWebCategorie()
        End Select
    End Sub
    Private Sub AggiornaInserimentoOre()
        If BS_utenti.Count > 0 Then
            Dim RGll As DS_utenti.DT_utentiRow = DirectCast(BS_utenti.Current, DataRowView).Row
            TA_contore.FillByIDdip_Periodo_O_data(DS_utenti.DT_contore, RGll.id, PeriodoLocale)
            'Pulisce_riepilogo_giorni()
            'ContaDG_totaliPresenze()
        End If

    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Try
            Dim rg As DS_utenti.DT_utentiRow
            rg = DirectCast(BS_utenti.Current, DataRowView).Row
            Dim nome_ri As Array = {BS_utenti.DataMember, "id", rg.id, TT_CB_mese.SelectedIndex + 1, TT_CB_anno.SelectedItem, ""}
            dsolidofunc.memorizza_informazioni(Me.Name, BS_utenti.Position, GlobalVarPOP.G_nomeutente, nome_ri)
            DGdocumenti.DataSource = ""
            dgwClassificazione.DataSource = ""
        Catch ex As Exception

        End Try

        Try
            Me.Close()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub TTBTModifica_Click(sender As Object, e As EventArgs) Handles TTBTModifica.Click
        Dim RG As DS_utenti.DT_utentiRow
        RG = DirectCast(BS_utenti.Current, DataRowView).Row

        Dim f As New FRM_MOD_dipendenti(Me.DS_utenti.DT_utenti, RG.id)
        f.ShowDialog()
        TA_utenti.Fill(Me.DS_utenti.DT_utenti, GlobalVarPOP.G_idAZ)
    End Sub

    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click
        Dim I_nuovoID As Integer = TA_utenti.SP_UltimoID + 1
        Dim f As New FRM_MOD_dipendenti(Me.DS_utenti.DT_utenti, I_nuovoID, True)
        f.ShowDialog()
        TA_utenti.Fill(Me.DS_utenti.DT_utenti, GlobalVarPOP.G_idAZ)
    End Sub

    Private Sub TTTestoRicerca_Change(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged

        Dim ricerca As String
        ricerca = TTTestoRicerca.Text
        CK_filtro_controllo()
        Dim S_oldFiltro As String = BS_utenti.Filter
        Dim T_fil As String = S_oldFiltro
        BS_utenti.Filter = If(T_fil.Length > 0, T_fil & " AND ", "") & String.Format("ricerca LIKE '%{0}%'", ricerca)
        Dim NN As Integer = 0
        Do While BS_utenti.Count < 1
            NN += 1
            If ricerca.Length() > 0 Then
                ricerca = TTTestoRicerca.Text.Substring(0, If(TTTestoRicerca.Text.Length() - NN <= 0, 0, TTTestoRicerca.Text.Length() - NN))
                BS_utenti.Filter = If(T_fil.Length > 0, T_fil & " AND ", "") & String.Format("ricerca LIKE '%{0}%'", ricerca)
                TTTestoRicerca.Text = ricerca
                TTTestoRicerca.SelectionStart = TTTestoRicerca.Text.Length
                CambiaColore()
            Else
                CK_filtro_controllo()
                Exit Do
            End If
        Loop
        AggiornamentoRighe()
        ' F_caricaValoriMese()
    End Sub

    Private Sub CK_filtro_controllo() Handles CK_filtro.ItemCheck, CK_filtro.SelectedIndexChanged
        Dim S_Fil(3) As String
        Dim T_Fil As String
        Dim p As String
        'p = DirectCast(CK_filtro, CheckedListBox)
        S_Fil(0) = ""
        S_Fil(1) = ""
        S_Fil(2) = ""
        S_Fil(3) = ""

        For Each p In CK_filtro.CheckedItems
            'MsgBox(p.text)
            Select Case p
                Case "Attivi"
                    S_Fil(0) = " AND stato = 1"
                Case "Licenziati"
                    S_Fil(0) = " AND stato = 0"
                Case "Interinali"
                    S_Fil(1) = " AND interinale = 1"
                Case "Non Interinali"
                    S_Fil(2) = " AND interinale = 0"
                Case "In scadenza"
                    S_Fil(3) = String.Format(" AND datalic > '{0}'", DataMysql(Now()))
                Case Else
            End Select
        Next
        T_Fil = ""
        For N_fil = 0 To 3
            T_Fil = T_Fil & S_Fil(N_fil)
        Next

        T_Fil = If(T_Fil.Length < 4, "", If(T_Fil.Substring(0, 4) = " AND", T_Fil.Substring(4, T_Fil.Length - 4), T_Fil))
        BS_utenti.Filter = T_Fil

    End Sub
    Private Sub FotoPictureBox_Click(sender As Object, e As MouseEventArgs) Handles PIC_Foto.MouseDown
        'Quando clicchi sulla foto
        'se hai premuto il click sinistro ti propone il menù di stampa
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MNU_foto.Show(New Point(MousePosition.X, MousePosition.Y))
        End If
    End Sub

    Shared Function InsertImage(ByVal ImgPath As String) As System.Byte()
        Dim fs As New System.IO.FileStream(ImgPath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
        Dim b(fs.Length() - 1) As Byte
        fs.Read(b, 0, b.Length)
        fs.Close()

        Return b
    End Function
    'funzione per il ridimensionamento delle immagini
    Private Shared Function Ridimensiona(ByVal percorsoImmagine As String) As String
        Dim bm As Bitmap
        'dimensioni  originali
        Dim originalX As Integer
        Dim originalY As Integer
        'dimensioni finali
        Dim destinationX As Integer
        Dim destinationY As Integer
        'cartella e nome di destinazione
        Dim destinationFolder As String
        Dim destinationFileName As String
        'carica immagine originale
        If IsNothing(percorsoImmagine) Then
            percorsoImmagine = ""
        End If
        bm = New Bitmap(percorsoImmagine)
        'ricava dimensioni originali dell'immagine
        originalX = bm.Width
        originalY = bm.Height
        'imposta dimensioni finali
        destinationY = 156
        destinationX = CInt((destinationY / originalY) * originalX)

        'Dim ritaglioDestination As Int16
        Dim ritaglioOriginal As Int16
        'If destinationX > destinationY Then
        '    Dim a As Decimal = destinationY * 3 / 4
        '    ritaglioDestination = (destinationX - (destinationX * a / destinationY))
        '    ritaglioOriginal = originalX * (ritaglioDestination / destinationX)
        'End If
        'riduzione dell'immagine
        Dim thumb As New Bitmap(destinationX, destinationY)
        Dim g As Graphics = Graphics.FromImage(thumb)
        'impostazione del metodo di interpolazione utilizzato per il resize
        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        g.DrawImage(bm, New Rectangle(0, 0, destinationX, destinationY), New Rectangle(ritaglioOriginal, 0, originalX - ritaglioOriginal, originalY), GraphicsUnit.Pixel)
        g.Dispose()
        'salvataggio dell'immagine ridimensionata
        Dim nom As String = System.IO.Path.GetFileNameWithoutExtension(percorsoImmagine)
        Dim otp As Integer = nom.Length + 4

        destinationFolder = percorsoImmagine.Substring(0, percorsoImmagine.Length - otp)
        'salva il file a 120 px di altezza
        destinationFileName = destinationY & "_" & System.IO.Path.GetFileNameWithoutExtension(percorsoImmagine)
        thumb.Save(destinationFolder & destinationFileName & ".jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        bm.Dispose()
        thumb.Dispose()
        Return (destinationFolder & destinationFileName & ".jpg")
    End Function

    Private Sub Eliminafoto_Click(sender As Object, e As EventArgs) Handles MNU_eliminafoto.Click
        Dim rg As DS_utenti.DT_utentiRow = DirectCast(BS_utenti.Current, DataRowView).Row
        If MessageBox.Show("Vuoi eliminare la foto di " & rg.cognome, "attenzione", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            TA_utentiFoto.QR_elimina(rg.id)
        End If
        Dim RGF As DS_utenti.DT_utentiFotoRow
        RGF = DirectCast(BS_fotoutenti.Current, DataRowView).Row
        RGF.Delete()
    End Sub
    Shared Function InsertImage(ByVal ImgPath As String, ByVal Sql As String) As Boolean
        '        Try
        Dim objconn As Odbc.OdbcConnection
        Dim Str As New Pop2.Dipendenti.My.MySettings
        objconn = New Odbc.OdbcConnection(Str.imp_est)
        'Dim objconn As New Odbc.OdbcConnection("DRIVER={MySQL ODBC 3.51 Driver};SERVER=" & DB_SERVER & ";DATABASE=" & DB_NAME & ";USER=" & DB_USER & ";PASSWORD=" & DB_PWD & ";OPTION=3;")
        objconn.Open()
        Dim stream As System.IO.FileStream
        Dim flength As System.Int32 = 0
        stream = New System.IO.FileStream(ImgPath, System.IO.FileMode.Open, System.IO.FileAccess.Read)
        flength = CInt(stream.Length)
        Dim buffer(flength) As Byte
        stream.Read(buffer, 0, flength)
        Dim cmd As New Odbc.OdbcCommand(Sql, objconn)
        Dim param As Odbc.OdbcParameter = New Odbc.OdbcParameter("?", Odbc.OdbcType.Binary)
        param.Value = buffer
        cmd.Parameters.Add(param)
        cmd.ExecuteNonQuery()
        cmd = Nothing
        stream.Close()
        objconn.Close()
        '       Catch ex As Exception
        '      Return False
        '     End Try
        Return True
    End Function

    'Aggiunge la fotografia al dipendente
    Private Sub MNU_aggiungifoto_Click(sender As Object, e As EventArgs) Handles MNU_aggiungifoto.Click
        Try
            Dim dlgImmagine As New OpenFileDialog()
            dlgImmagine.Title = "Seleziona un immagine da importare"
            dlgImmagine.Multiselect = False
            dlgImmagine.Filter = "Formato GIF (*.gif)|*.gif|Formato JPEG(*.jpg)|*.jpg"
            dlgImmagine.FilterIndex = 2
            dlgImmagine.FileName = ""
            dlgImmagine.ShowDialog()
            TXT_imagine.Text = dlgImmagine.FileName

            TXT_imagine.Text = Ridimensiona(TXT_imagine.Text)
            Dim rg As DS_utenti.DT_utentiRow = DirectCast(BS_utenti.Current, DataRowView).Row
            If BS_fotoutenti.Count < 1 Then
                BS_fotoutenti.AddNew()
            End If
            Dim r As DS_utenti.DT_utentiFotoRow = DirectCast(BS_fotoutenti.Current, DataRowView).Row
            If r.IsfotoNull Then
                Dim strID As String = CType(rg.id, String)

                InsertImage(TXT_imagine.Text, "Insert INTO utenti_foto (foto,id_utente) VALUES (?," & strID & ")")
            Else
                Dim strID As String = CType(rg.id, String)
                Dim img As System.Byte()
                img = InsertImage(TXT_imagine.Text)
                Using dt As New DS_utentiTableAdapters.TA_utentiFoto
                    'Memorizzazione dell' immagine
                    dt.QR_modifica(img, strID)
                End Using
            End If
            Dim N_id As Integer
            Me.TA_utentiFoto.Fill(Me.DS_utenti.DT_utentiFoto)
            N_id = rg.id
        Catch ex As Exception
#If DEBUG Then
            Console.WriteLine(ex.Message)
#End If
        End Try
    End Sub


    Private Sub aggiornaalcambioperiodo(sender As Object, e As EventArgs)
        If TT_CB_mese.SelectedIndex >= 0 Then
            Dim RGDG As New DataGridViewRow
            PeriodoLocale = TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
            For Each RGDG In dgElencoDipendenti.Rows
                RGDG.Cells("C_ore_E").Style.BackColor = Color.White
                RGDG.Cells("C_ore_P").Style.BackColor = Color.White
                RGDG.Cells("C_ore_P").Value = ""
                RGDG.Cells("C_ore_E").Value = ""
            Next
        End If
        Using TA As New DS_utentiTableAdapters.TA_cal
            Using DT As New DS_utenti.DT_calDataTable
                TA.FillByPeriodo(DT, PeriodoLocale)
                BS_Cal.DataSource = DT
            End Using
        End Using
        DG_totaleoreweb.Columns.Clear()
        DG_totaleOreWebCliente.Columns.Clear()
        AggiornamentoRighe()
    End Sub
    Private Sub TableLayoutPanel1_Click(sender As Object, e As MouseEventArgs) Handles TBL_anagrafica.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            RidimensionaTab = True
            TBL_anagrafica.Cursor = Cursors.Hand
        End If
    End Sub
    Private Sub TableLayoutPanel1_modifica(sender As Object, e As MouseEventArgs) Handles TBL_anagrafica.MouseMove

        Dim posizioneAssoluta As Integer = TBL_anagrafica.ColumnStyles(0).Width
        If Not RidimensionaTab Then
            If e.X = posizioneAssoluta Then
                TBL_anagrafica.Cursor = Cursors.SizeAll
            Else
                TBL_anagrafica.Cursor = Cursors.Default
            End If
        Else
            With TBL_anagrafica
                '.ColumnStyles(1).SizeType = SizeType.Absolute
                '.ColumnStyles(1).Width = .Width - e.X
                .ColumnStyles(0).SizeType = SizeType.Absolute
                .ColumnStyles(0).Width = e.X
                .RowStyles(1).SizeType = SizeType.Absolute
                .RowStyles(1).Height = e.Y - .RowStyles(0).Height
            End With
        End If
    End Sub
    Private Sub TableLayoutPanel1_UnClick(sender As Object, e As MouseEventArgs) Handles TBL_anagrafica.MouseUp
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            RidimensionaTab = False
            TBL_anagrafica.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim rg As DS_utenti.DT_utentiRow
        rg = DirectCast(BS_utenti.Current, DataRowView).Row
        Using DT As New DS_utentiTableAdapters.TA_utenti
            If MsgBox("Vuoi eliminare l'utente " & rg.cognome, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If MsgBox("SEI ASSOLUTAMENTE SICURO DELL'ELIMINAZIONE", MsgBoxStyle.YesNo, "ATTENZIONE") <> MsgBoxResult.Yes Then
                    Return
                End If
                DT.QR_elimina(rg.id_progressivo)
                rg.Delete()
            End If
        End Using
    End Sub

    Private Sub TTBTStampa_MousDown(sender As Object, e As MouseEventArgs) Handles TTBTStampa.MouseDown
        'se hai premuto il click sinistro su cmd_stampa ti propone il menù
        If e.Button = Windows.Forms.MouseButtons.Left Or Windows.Forms.MouseButtons.Right Then
            MNU_stampa.Show(New Point(MousePosition.X, MousePosition.Y))
        End If
    End Sub
    Private Sub P_stampa(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles MNU_stampa.ItemClicked
        Dim toolStrip = e.ClickedItem
        Dim MNU_tmp As New ContextMenuStrip
        MNU_tmp = DirectCast(sender, ContextMenuStrip)
        Dim rg As DS_utenti.DT_utentiRow
        rg = DirectCast(BS_utenti.Current, DataRowView).Row
        Select Case toolStrip.Name
            Case "MNU_dipendentielenco"
                'Dim g As New FRM_prova()
                'g.ShowDialog()
                Dim s As New FRM_STP_elencodipendenti(BS_utenti)
                s.ShowDialog()
            Case "MNU_dipendenticonformazione"
                Dim s As New frm_stp_formazione_dipendenti(rg.id)
                s.ShowDialog()
            Case "MNU_impegno"
                Dim s As New FRM_STP_programmacantieridipendenti
                s.ShowDialog()
            Case "MNU_tesserino"
                Dim f As New FRM_stp_Tesserino(rg.id)
                f.Show()
            Case "MNU_pianolavoro"
                Dim I_riga As DS_utenti.DT_utentiRow
                I_riga = DirectCast(BS_utenti.Current, DataRowView).Row
                Dim N_idDip_TMP As Integer = 0
                Try
                    N_idDip_TMP = I_riga.id 'Memorizza il codice del cliente
                    Dim s As New FRM_stp_OreDipendenti(N_idDip_TMP)
                    s.ShowDialog()
                Catch ex As Exception

                End Try

            Case "TSM_StampaFoglioPresenza"
                Dim I_riga As DS_utenti.DT_utentiRow
                I_riga = DirectCast(BS_utenti.Current, DataRowView).Row
                Dim N_idDip_TMP As Integer = 0
                Try
                    N_idDip_TMP = I_riga.id 'Memorizza il codice del cliente
                    Dim s As New FRM_stp_OreDipendenti(N_idDip_TMP)
                    s.ShowDialog()
                Catch ex As Exception
                End Try
            Case "TSM_StampaProgrammaFerie"
                P_CiclaDG_orari()
            Case "TSM_StampaPresenzeweb"    'Stampa riepilogo WEB
                TabControl1.SelectedTab = tpStampaRiepilogo

                'btStampaRiepilogoPresenze.PerformClick()
            Case "ElencoScadenzaFormazioneToolStripMenuItem"
                Dim f As New frmSTPFormazioneDipendenti
                f.Show()
            Case "MNU_dipendenticonformazione"


        End Select
    End Sub

    Private Sub P_CiclaDG_orari()
        '
        '
        'Funzione per la stampa delle Ferie dell-Utente
        '
        '
        Dim rg As DS_utenti.DT_calRow
        Dim og As DS_utenti.DT_orariRow
        'utilizzato in caso di ferie del cliente

        Dim inizioferieD As DateTime ' Ferie per il dettaglio del Cliente
        Dim fineferieD As DateTime
        Dim inizioferieU As DateTime    ' Ferie per l'Utente
        Dim fineferieU As DateTime
        'Dim anno As Int16 = PeriodoLocale.Split("-").First
        'Dim mese As Int16 = PeriodoLocale.Split("-").Skip(1).First

        'Dim dataferie1 As DateTime = DateAdd("m", 0, DateSerial(anno, mese, 1))
        'Dim dataferie2 As DateTime = DateAdd("m", 1, DateSerial(anno, mese, 0))
        Dim Riga As Integer = 0
        Dim Dow As Int16
        Dim NomeI As String
        Dim NomeU As String
        Dim DT_prog As New DS_Stampe.DT_ProgrammazioneFerieDataTable
        Dim D_set() As String = {"Do", "Lu", "Ma", "Me", "Gi", "Ve", "Sa"}
        Dim id_dip As Integer = DirectCast(BS_utenti.Current, DataRowView).Row.Item("id")
        Dim nSel As Integer = dgElencoDipendenti.GetCellCount(DataGridViewElementStates.Selected)
        Dim ID_tmp(nSel - 1) As Integer

        For Each TT_id In dgElencoDipendenti.SelectedRows
            '            BS.Filter = "id_dip = " & TT_id.cells(0).value
            ' Dim oldDest As Int16 = DirectCast(BS_orario.Current, DataRowView).Row.Item("id_des")
            Dim DatI As TimeSpan
            Dim DatU As TimeSpan
            Dim passaggi As Integer = 0
            Using TMP As New DSfestivitaTableAdapters.TAferieutente
                Dim DT As New DSfestivita.DTferieutenteDataTable
                Dim idUtente As Int16 = TT_id.cells(0).value
                Dim inizio As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, 1)
                Dim fine As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0)
                Me.TAferieutente.FillByPeriodoConvalida(Me.DSfestivita.DTferieutente, PeriodoLocale.Replace("-", ""), 3)
                inizioferieU = Nothing
                fineferieU = Nothing
                If DT.Rows.Count > 0 Then
                    'For Each tmprgFerieU As DataRow In DT.Rows
                    inizioferieU = DT.Rows(0).Field(Of DateTime)("inizio")
                    fineferieU = DT.Rows(0).Field(Of DateTime)("fine")
                Else
                    Return
                End If
            End Using
            Dim oldDET As Integer
            For Each j In BS_relOrari
                passaggi += 1
                BS_Cal.MoveFirst()

                og = DirectCast(j, DataRowView).Row
                If oldDET <> og.id_des Then
                    oldDET = og.id_des
                    Using TMP As New DSfestivitaTableAdapters.TAferiecliente
                        Dim DT As New DSfestivita.DTferieclienteDataTable
                        TMP.FillBydettaglio(DT, oldDET, PeriodoLocale.Replace("-", ""))
                        If DT.Rows.Count > 0 Then
                            inizioferieD = DT.Rows(0).Field(Of DateTime)("inizio")
                            fineferieD = DT.Rows(0).Field(Of DateTime)("fine")
                        Else
                            inizioferieD = Nothing
                            fineferieD = Nothing
                        End If
                    End Using
                Else
                End If
                For Each l In BS_Cal
                    rg = DirectCast(l, DataRowView).Row
                    Dow = (rg.giorno.DayOfWeek)
                    NomeI = D_set(Dow) & "_i"
                    NomeU = D_set(Dow) & "_u"

                    Dim oraI As TimeSpan
                    Dim oraF As TimeSpan


                    Try
                        oraI = TimeSpan.Parse(og.Item(NomeI))
                    Catch e As FormatException
                        oraI = New TimeSpan(0, 0, 0)
                    End Try
                    Try
                        oraF = TimeSpan.Parse(og.Item(NomeU))
                    Catch ex As Exception
                        oraF = New TimeSpan(0, 0, 0)
                    End Try
                    If oraI <> New TimeSpan(0, 0, 0) Then
                        DT_prog.Rows.Add()
                        Riga = DT_prog.Rows.Count - 1
                        DT_prog.Rows(Riga).Item("Ing") = oraI
                        DT_prog.Rows(Riga).Item("Usc") = oraF
                        Dim s As String = "01-01-1900" & " " & oraI.ToString
                        DatI = ConvertToDateTime(s)
                        s = "01-01-1900" & " " & oraF.ToString
                        DatU = ConvertToDateTime(s)
                        If rg.festivo Then ' Se e una festivita allora Cambia il colore di sfondo
                            DT_prog.Rows(Riga).Item("Fes") = 1
                        ElseIf rg.giorno >= inizioferieU And rg.giorno <= fineferieU And rg.giorno >= inizioferieD And rg.giorno <= fineferieD Then
                            DT_prog.Rows(Riga).Item("Fes") = 4 ' Se manca sia il cliente che il dipendente
                        ElseIf rg.giorno >= inizioferieD And rg.giorno <= fineferieD Then
                            DT_prog.Rows(Riga).Item("Fes") = 3 ' se le ferie sono del cliente
                        ElseIf rg.giorno >= inizioferieU And rg.giorno <= fineferieU Then
                            DT_prog.Rows(Riga).Item("Fes") = 2 ' se le ferie sono del dipendente
                        Else
                            DT_prog.Rows(Riga).Item("Fes") = 0
                        End If
                        DT_prog.Rows(Riga).Item("Giorno") = rg.giorno.ToShortDateString
                        DT_prog.Rows(Riga).Item("Dipendente") = og.anagrafica
                        DT_prog.Rows(Riga).Item("Destinatario") = og.locazione & passaggi
                        DT_prog.Rows(Riga).Item("ID_dip") = og.id_dip
                        DT_prog.Rows(Riga).Item("ID_des") = og.id_des
                        '    DT_prog.Rows(Riga).Item("Tot") = og.Item(NomeU) - og.Item(NomeI)
                    Else
                        DT_prog.Rows.Add()
                        Riga = DT_prog.Rows.Count - 1
                        DT_prog.Rows(Riga).Item("Ing") = New TimeSpan(0, 0, 0)
                        DT_prog.Rows(Riga).Item("Usc") = New TimeSpan(0, 0, 0)
                        If rg.festivo Then ' Se e una festivita allora Cambia il colore di sfondo
                            DT_prog.Rows(Riga).Item("Fes") = 1
                        ElseIf rg.giorno >= inizioferieU And rg.giorno <= fineferieU And rg.giorno >= inizioferieD And rg.giorno <= fineferieD Then
                            DT_prog.Rows(Riga).Item("Fes") = 4 ' Se manca sia il cliente che il dipendente
                        ElseIf rg.giorno >= inizioferieD And rg.giorno <= fineferieD Then
                            DT_prog.Rows(Riga).Item("Fes") = 3 ' se le ferie sono del cliente
                        ElseIf rg.giorno >= inizioferieU And rg.giorno <= fineferieU Then
                            DT_prog.Rows(Riga).Item("Fes") = 2 ' se le ferie sono del dipendente
                        Else
                            DT_prog.Rows(Riga).Item("Fes") = 0
                        End If
                        DT_prog.Rows(Riga).Item("Giorno") = rg.giorno.ToShortDateString
                        DT_prog.Rows(Riga).Item("Dipendente") = og.anagrafica
                        DT_prog.Rows(Riga).Item("Destinatario") = og.locazione & passaggi
                        DT_prog.Rows(Riga).Item("ID_dip") = og.id_dip
                        DT_prog.Rows(Riga).Item("ID_des") = og.id_des
                    End If
                Next
            Next
        Next
#If DEBUG Then
        For Each yyy In DT_prog
            Console.WriteLine(yyy(0) & "-" & yyy(1) & "-" & yyy(2) & "-" & yyy(3) & "-" & yyy.Item("Fes") & "-")
        Next
#End If
        Dim f As New FRM_STP_ProgrammaFerie(DT_prog)
        f.Show()
#If DEBUG Then
        For Each rr In DT_prog.Rows
            Console.WriteLine(rr.Item("Giorno").ToString & rr.item("Destinatario") & " " & rr.Item("Ing").ToString & " " & rr.Item("Usc").ToString & " " & rr.Item("Tot").ToString)
        Next
#End If
    End Sub

    Private Sub TTBTannulla_Click(sender As Object, e As EventArgs) Handles TTBTannulla.Click
        Dim GG() As Integer = CaricaGiorniValidi()

        Dim tabelleSommaOre(,) As Decimal = CalcolaOrePreviste()

        Using Ta As New DS_utentiTableAdapters.TA_riepilogopresenze
            Using DTpresenze As New DS_utenti.DT_riepilogopresenzeDataTable
                Dim RGDT As DS_utenti.DT_riepilogopresenzeRow = Nothing
                Carica(Ta, DTpresenze)
                Dim ValID As Integer
                For Each RGDG In dgElencoDipendenti.Rows
                    ValID = RGDG.cells("C_id_dip").value

                    For Each RGTA In DTpresenze
                        If RGTA.id_dip = ValID Then
                            'se le ore previste sono minori o uguali di quelle realizzate verde
                            Dim TotaleP As Decimal = 0
                            Dim TotaleE As Decimal = 0
                            Dim tP As Integer = Decimal.TryParse(RGDG.cells("C_ore_P").value, TotaleP)
                            Dim tE As Integer = Decimal.TryParse(RGTA.totale, TotaleE)
                            Select Case TotaleP - TotaleE
                                Case < 0
                                    RGDG.cells("C_ore_E").Style.BackColor = Color.LightBlue
                                Case = 0
                                    RGDG.cells("C_ore_E").Style.BackColor = Color.LightGreen
                                    RGDG.cells("C_ore_P").Style.BackColor = Color.LightGreen
                                Case > 0
                                    RGDG.cells("C_ore_E").Style.BackColor = Color.LightCoral
                            End Select
                            RGDG.cells("C_ore_E").Value = RGTA.totale.ToString("N2")
                            Dim somma As Decimal = 0
                            For ff = 0 To tabelleSommaOre.GetLength(0) - 1
                                Dim id As Decimal = Nothing
                                id = tabelleSommaOre(ff, 0)
                                If id = ValID Then
                                    somma += tabelleSommaOre(ff, 1)
                                End If
                            Next
                            RGDG.cells("C_ore_P").Value = somma
                            'Dim rgSomma As DataRow = tabelleSommaOre.NewRow

                            'rgSomma = tabelleSommaOre.Rows.Find(ValID)


                        End If
                    Next
                Next
            End Using
        End Using
    End Sub

    Private Function CalcolaOrePreviste()
        Dim OreCalcolate As Decimal(,)
        Dim dinizio As DateTime = DateSerial(Integer.Parse(PeriodoLocale.Split("-").First), Integer.Parse(PeriodoLocale.Split("-").Last), 1)
        Dim dFine As DateTime = DateSerial(dinizio.Year, DateAdd("m", 1, dinizio).Month, 0)
        Dim bs As BindingSource = New BindingSource()
        TA_orari.FillByUtentiAttivi(Me.DS_utenti.DT_orari)
        Dim Cli As New DataTable
        bs.DataSource = Me.DS_utenti.DT_orari
        Cli = NewDToremese()                                'Crea la tabella
        'CaricaDatiOreDipendente(Cli, bs)                    'Popola la tabella
        'Definisce ListaOrari come nuova tabella di Cli
        Dim ListaOrari = Cli.AsEnumerable().GroupBy(Function(row) New With {
            Key .id_utente = row.Field(Of Int32)("id_utente"),
            Key .id_dettaglio = row.Field(Of Int32)("id_dettaglio")
        })
        Dim CliRaggruppata = Cli.Clone()
        'Memorizza in Cliraggruppata i valori di Listaorari le chiavi di raggruppamento sono dettaglio cliente e Dipendente
        For Each grp In ListaOrari
            CliRaggruppata.Rows.Add(grp.Key.id_utente, grp.Key.id_dettaglio, 0, "", "", "",
                                        grp.Sum(Function(row) row.Field(Of Decimal)("lun")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("mar")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("mer")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("gio")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("ven")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("sab")),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("dom")))
        Next
        Dim GiorniValidi As Array = CaricaGiorniValidi()
        Dim numeroDip As Integer = CliRaggruppata.Rows.Count
        CliRaggruppata = OrdinaTabella(CliRaggruppata, "id_utente ASC")
        ReDim OreCalcolate(numeroDip, 1)
        Dim xx As Integer = 0
        For Each rgSomme As DataRow In CliRaggruppata.Rows
            OreCalcolate(xx, 0) = rgSomme("id_utente")
            Dim TotaleOre As Decimal = 0
            For yy = 1 To GiorniValidi.GetLength(0)
                Dim dcalcolo As DateTime = DateSerial(Integer.Parse(PeriodoLocale.Split("-").First), Integer.Parse(PeriodoLocale.Split("-").Last), yy)

                Dim daySettimana As Integer = dcalcolo.DayOfWeek()
                If GiorniValidi(yy - 1) = 0 Then
                    TotaleOre += rgSomme(daySettimana + 6)
                End If

            Next

            Console.WriteLine(TotaleOre.ToString("n2") + "    " + rgSomme("id_utente").ToString)
            OreCalcolate(xx, 1) += TotaleOre
            xx += 1
        Next


        Return OreCalcolate
    End Function
    Private Function CaricaGiorniValidi() As Array
        ' Crea un arrai con i giorni disponibili del mese
        Dim logicalfesta As Integer()
        Using dt As New DS_utenti.DT_calDataTable
            Using ta As New DS_utentiTableAdapters.TA_cal
                ta.FillByPeriodo(dt, PeriodoLocale)

                For Each tt As DS_utenti.DT_calRow In dt.Rows
                    logicalfesta.Add(tt.festivo)
                Next
            End Using
        End Using

        Return logicalfesta
    End Function
    Private Function Carica(ByRef DT As DS_utentiTableAdapters.TA_riepilogopresenze, ByRef TA As DataTable)
        Try
            DT.FillByTotaleperDipendente(TA, PeriodoLocale)
        Catch ex As Exception
            Dim err As DataRow() = TA.GetErrors
            Dim msg As New StringBuilder
            For Each e In err
                Console.WriteLine(e.RowError)
            Next
            Return (False)
        End Try
        Return (True)
    End Function

    Private Sub TV_totali_ModificaPresenza(sender As Object, e As TreeNodeMouseClickEventArgs) ' Handles TV_totali.NodeMouseClick
        Dim Nodo As New TreeNode
        Nodo = e.Node
    End Sub

    Private Sub BT_avvioPresenze_Click(sender As Object, e As EventArgs)
        Dim RG_D As DS_utenti.DT_utentiRow
        RG_D = DirectCast(BS_utenti.Current, DataRowView).Row
        'Dim Presenze As New FRM_inserimento_ore(RG_D, periodolocale)
        'Presenze.ShowDialog()
    End Sub
    Private Sub CaricaDocumento()
        Dim RG As DS_utenti.DT_utentiRow
        RG = DirectCast(BS_utenti.Current, DataRowView).Row
        Dim pdfModello As String
        Dim pdfNuovo As String
        Dim posizionenuovo As String = ""
        Dim idSelezionato As Integer = RG.id

        If TrovaPosizione.SelectedPath = "" Then
            Return
        Else
            Try
                'For Each GG In File.Delete()
            Catch ex As Exception

            End Try
            Try
                Dim Lettera As String = ""
                Dim idlettera As Integer = LB_lettere.SelectedIndex
                BS_lettere.Find("id", idlettera)
                Dim RGlettere As DS_utenti.DT_lettereRow
                RGlettere = DirectCast(BS_lettere.Current, DataRowView).Row
                Lettera = RGlettere.nomefile
                If Lettera = "" Then
                    Return
                End If
                Dim sPath As String = TrovaPosizione.SelectedPath
                pdfModello = sPath & Lettera & ".pdf"
                If posizionenuovo = "" Then
                    posizionenuovo = sPath
                End If
                'pdfNuovo = SalvaPosizione.SelectedPath
                'Se non la trova, crea una directory temporanea sul desktop
                Dim destinazione As String
                destinazione = My.Computer.FileSystem.SpecialDirectories.Desktop & "\Temporanea"
                If Directory.Exists(destinazione) Then
                Else
                    Dim di As DirectoryInfo = Directory.CreateDirectory(destinazione)
                End If
                'crea il file nel percorso corretto
                pdfNuovo = destinazione & "\" & RGlettere.nomefile & "_" & EliminaCaratteriSpeciali(RG.cognome & RG.nome, True) & ".pdf"


                Dim inputPath As String = pdfModello
                Dim outputPath As String = pdfNuovo

                Using pdfReader As New iText.Kernel.Pdf.PdfReader(inputPath)
                    Using pdfWriter As New iText.Kernel.Pdf.PdfWriter(outputPath)
                        Using pdfDocument As New iText.Kernel.Pdf.PdfDocument(pdfReader, pdfWriter)
                            ' Ottieni l'oggetto PdfAcroForm dal documento
                            Dim acroForm As iText.Forms.PdfAcroForm = iText.Forms.PdfAcroForm.GetAcroForm(pdfDocument, True)
                            ' Esempio: imposta il valore di un campo di testo
                            For Each g In acroForm.GetAllFormFields
                                Console.WriteLine(g.Key)
                                Select Case g.Key
                                    Case "anagrafica"
                                        acroForm.GetField("anagrafica").SetValue(RG.nome & " " & RG.cognome)
                                    Case "nascita"
                                        acroForm.GetField("nascita").SetValue(RG.luogonascita & " " & RG.datanascita)
                                    Case "residenza"
                                        acroForm.GetField("residenza").SetValue(RG.indirizzo & " " & RG.citta)
                                    Case "identita"
                                        acroForm.GetField("identita").SetValue(RG.cf)
                                    Case "telefono"
                                        acroForm.GetField("telefono").SetValue(RG.cellulare)
                                    Case "username"
                                        acroForm.GetField("username").SetValue(RG.user)
                                    Case "password"
                                        acroForm.GetField("password").SetValue(RG.pwd)
                                    Case "residenza1"
                                        acroForm.GetField("residenza1").SetValue(RG.indirizzo & " " & RG.citta)
                                    Case Else
#If DEBUG Then
                                        Console.WriteLine("Esiste anche : " & g.Key)
#End If
                                End Select
                            Next


                        End Using
                    End Using
                End Using

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub

    Private Sub GeneraDocumento_Click(sender As Object, e As EventArgs) Handles BT_generadocumento.Click
        TrovaPosizione.SelectedPath = G_DirectoriModelliLettera
        Do While True
            If TrovaPosizione.SelectedPath <> "" Then
                CaricaDocumento()
                Exit Do
            Else
                If MsgBox("Cerco la cartella dei modelli?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    TrovaPosizione.ShowDialog()
                Else
                    Exit Do
                End If
            End If
        Loop

    End Sub

    Private Sub LL_anagrafica_Link(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_anagrafica.LinkClicked,
                                                                                                LL_anagrafica3.LinkClicked, LL_anagrafica1.LinkClicked, LL_abinamentoPresenzeRemote.LinkClicked, LBLanagrafica.LinkClicked,
                                                                                                llWebAppAnagrafica.LinkClicked, LinkLabelRiepilogoStampa.LinkClicked
        CollegamentoModificaUtente()
    End Sub

    Private Sub CollegamentoModificaUtente()
        Dim RG As DS_utenti.DT_utentiRow
        RG = DirectCast(BS_utenti.Current, DataRowView).Row
        Dim f As New FRM_MOD_dipendenti(DS_utenti.DT_utenti, RG.id)
        f.ShowDialog()
    End Sub


    Private Sub ControllaDirectory()
        If Not Dir(G_DirectoriDipendenti, vbDirectory) <> "" Then
            MsgBox("Non puoi proseguire perché non hai accesso alla cartella " & G_DirectoriDipendenti)
            TAB_dipendenti.SelectTab(0)
        End If
    End Sub

    Private Function VisualizzaDocumenti(ByVal RRDoc As DataGridViewRow, ByVal colDir As DataGridViewColumn, ByVal colFile As DataGridViewColumn)
        Dim sPath As String = G_DirectoriDipendenti & RRDoc.Cells(colDir.Index).Value

        Dim pdfModello As String = sPath & "\" & RRDoc.Cells(colFile.Index).Value
        If File.Exists(pdfModello) Then
            Process.Start(pdfModello)
        Else
            Return False
        End If
        Return True
    End Function
    Private Sub DGdocumentiDipendente_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGdocumenti.CellClick

        Dim senderGrid As DataGridView
        senderGrid = DirectCast(sender, DataGridView)
        If e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            Return
        End If
        Dim Cella As DataGridViewCell = senderGrid(e.ColumnIndex, e.RowIndex)
        Dim RigaTabella As DataGridViewRow
        RigaTabella = senderGrid.Rows(e.RowIndex)
        Select Case True
            Case TypeOf Cella Is DataGridViewLinkCell
                If Not VisualizzaDocumenti(RigaTabella, COLdocumentiCartella, COLdocumentifile) Then
                    MsgBox("Attenzione Documento non disponibile", MsgBoxStyle.OkOnly)
                End If
        End Select
    End Sub
    Private Sub DGdocumentiDipendente_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGdocumenti.CellValidating

        Dim senderGrid As DataGridView
        senderGrid = DirectCast(sender, DataGridView)
        Dim Colonna As DataGridViewCell = senderGrid(e.ColumnIndex, e.RowIndex)
        Dim RGff As DSwebcondiviso.DTfileRow
        RGff = DirectCast(bsfile.Current, DataRowView).Row

        Select Case True
            Case TypeOf Colonna Is DataGridViewCheckBoxCell
                Dim stato As DataGridViewCheckBoxCell
                stato = Colonna
                stato.Value = If(stato.Value > 0, 0, 1)
                TAfile.pubblica(If(e.FormattedValue, 1, 0), RGff.id)
                RGff.AcceptChanges()
                e.Cancel = False
            Case TypeOf Colonna Is DataGridViewTextBoxCell
                Dim stato As DataGridViewTextBoxCell
                stato = Colonna
                Select Case stato.ColumnIndex
                    Case COLdocumentidescrizione.Index
                        If Not (String.IsNullOrEmpty(e.FormattedValue.ToString())) Then
                            TAfile.modificadescrizioni(RGff.title, e.FormattedValue.ToString, "", RGff.id)
                            RGff.AcceptChanges()
                            e.Cancel = False
                        End If
                    Case OrderingDataGridViewTextBoxColumn.Index
                        Dim ordine As Int32
                        ordine = e.FormattedValue
                        TAfile.modificaOrdine(ordine, RGff.id)
                        RGff.AcceptChanges()
                        e.Cancel = False
                End Select
            Case TypeOf Colonna Is DataGridViewComboBoxCell
                Dim stato As DataGridViewComboBoxCell
                stato = Colonna
                Select Case stato.ColumnIndex
                    Case dgwcId_cat.Index
                        Dim Classificazione As Int32
                        'Classificazione = e.FormattedValue

                        Dim tmpRR As DSwebcondiviso.dtFileClassificazioneRow
                        tmpRR = DirectCast(bsClassificazioneFile.Current, DataRowView).Row
                        Classificazione = tmpRR.id
                        TAfile.UpdateQueryClassificazione(Classificazione, RGff.id)
                        RGff.AcceptChanges()
                        e.Cancel = False
                End Select
            Case Else

        End Select

        If Not IsNothing(Colonna) Then
        End If

    End Sub

    Private Sub TTBT_caricaDocumento_Click(sender As Object, e As EventArgs) Handles TTBT_caricaDocumento.Click
        Dim CartellaDestinazione As String
        Dim Testonome As String
        Dim TestoAlias As String
        Dim TestoDesc As String
        Dim TestoEstensione As String
        Dim TestoSize As String
        Dim TestoData As DateTime
        Dim TestoPaths As String()
        Dim nomeDirectory As String
        Dim RGloc As DS_utenti.DT_utentiRow
        RGloc = DirectCast(BS_utenti.Current, DataRowView).Row
        If bsfile.Count > 0 Then
            Dim RGdoc As DSwebcondiviso.DTfileRow
            RGdoc = DirectCast(bsfile.Current, DataRowView).Row
            nomeDirectory = RGdoc.cartella
            CartellaDestinazione = G_DirectoriDipendenti & RGdoc.cartella
        Else
            nomeDirectory = RGloc.cognome.Replace("'", "").Replace(" ", "_") & RGloc.nome.Replace("'", "_").Replace(" ", "_")
            Dim DirectoryInfo As DirectoryInfo
            CartellaDestinazione = G_DirectoriDipendenti & nomeDirectory
            DirectoryInfo = New DirectoryInfo(CartellaDestinazione)
            Dim CheckDirectory As Boolean = DirectoryInfo.Exists()
            If Not CheckDirectory Then
                If MsgBox("Non trovo la cartella di destinazione, la creo nuova ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    'TODO Generare la Cartella di destinazione se non la trova
                    Exit Sub
                End If
            End If
        End If


        Dim DestinazioneDocumento As String
        Dim Info As FileInfo
        OpenFileDialog1.Multiselect = True
        OpenFileDialog1.Filter = "documenti (" & RGloc.cognome & ".*)|*" & RGloc.cognome & "*.*"
        OpenFileDialog1.FileName = ""
        If Not OpenFileDialog1.ShowDialog() > 0 Then
            MsgBox("Nessun Documento selezionato")
            Return
        End If

        TestoPaths = OpenFileDialog1.FileNames 'Seleziona i documenti da caricare
        For Each TestoPath In TestoPaths
            'Genera il nome della directory dove salvare i documenti

            Testonome = TestoPath.Split("\").Last
            DestinazioneDocumento = CartellaDestinazione & "\" & Testonome
            If TestoPath.Length < 1 Then
                Continue For
            End If
            Info = New FileInfo(TestoPath)
            If Not Info.Exists Then
                Continue For
            End If
            TestoAlias = Testonome.Replace(" ", "_")
            TestoData = Info.CreationTime

            Select Case Testonome.Contains("BP_")
                Case True
                    Dim meseBusta As String
                    meseBusta = GlobalVarPOP.G_amese(TestoData.AddDays(-15).Month - 1) & " " & TestoData.AddDays(-10).Year.ToString
                    TestoDesc = String.Format("Busta Paga {0} ", meseBusta)
                Case Else
                    TestoDesc = "Documento"
            End Select


            TestoEstensione = Info.Extension
            TestoSize = ControllaeFormattaNumeri(Info.Length / 1000) & " KB"


            'Sposta o copia il documento
            Try
                If CK_spostacopia.CheckState = 0 Then
                    My.Computer.FileSystem.MoveFile(TestoPath, DestinazioneDocumento, True)
                Else
                    My.Computer.FileSystem.CopyFile(TestoPath, DestinazioneDocumento, True)
                End If
                impostaPermessiFile(DestinazioneDocumento, "http")
            Catch ex As Exception
                MsgBox("Problemi a registrare il documento " & DestinazioneDocumento)
                Return
            End Try

            Dim ultimo As Integer = TAfile.SQultimoordine(RGloc.id, 1) + 1
            TAfile.inserisce(RGloc.id, Testonome, TestoDesc, TestoSize, Testonome, 0, "", 0, 11, RGloc.id, ultimo, 1, TestoData, TestoData, nomeDirectory, 1, 0)
            TAfile.FillByUtente(Me.DSwebcondiviso.DTfile, RGloc.id, G_tipoFile)
        Next


    End Sub

    Private Sub TTBT_eliminaDocumentoRemoto_Click(sender As Object, e As EventArgs) Handles TTBT_eliminaDocumentoRemoto.Click
        Dim RGloc As DS_utenti.DT_utentiRow
        RGloc = DirectCast(BS_utenti.Current, DataRowView).Row
        Dim RGdoc As DSwebcondiviso.DTfileRow
        RGdoc = DirectCast(bsfile.Current, DataRowView).Row
        If MsgBox("Vuoi eliminare il collegamento al Documento ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim risposta As MsgBoxResult = MsgBox("Vuoi eliminare anche il FILE ? **IRREVERSIBILE** " &
                  Chr(13) & RGdoc.title, MsgBoxStyle.YesNoCancel)
            If risposta = MsgBoxResult.Yes Then
                Dim NomeFile As String = RGdoc.title
                Dim folderPath As String = G_DirectoriDipendenti & RGdoc.cartella
                Dim FileDaEliminare As String
                FileDaEliminare = folderPath & "\" & NomeFile
                If My.Computer.FileSystem.FileExists(FileDaEliminare) = True Then
                    My.Computer.FileSystem.DeleteFile(FileDaEliminare)
                Else
                    MsgBox("non ho trovato corrispondenza nella cartella dei documenti")
                End If
                TAfile.elimina(RGdoc.id)
                'ricarica i documenti
                TAfile.FillByUtente(DSwebcondiviso.DTfile, RGloc.id, G_tipoFile)
            ElseIf risposta = MsgBoxResult.No Then
                TAfile.elimina(RGdoc.id)
                TAfile.FillByUtente(DSwebcondiviso.DTfile, RGloc.id, G_tipoFile)
            End If

        End If

    End Sub

    Private Sub TX_ricerca_TextChanged(sender As Object, e As EventArgs)
        Dim tmpTX As TextBox
        Dim tmpBS As BindingSource = bsfile
        tmpTX = DirectCast(sender, TextBox)
        'tmpBS = REL_utentiRemotiDocumenti
        Dim TMP_ricerca As String = tmpTX.Text
        Dim OldFil As String = ""

        tmpBS.Filter = String.Format("description LIKE '%{0}%'", TMP_ricerca)
        Dim NN As Integer = 0
        Do While tmpBS.Count < 1
            NN += 1
            If TMP_ricerca.Length() > 0 Then
                TMP_ricerca = TMP_ricerca.Substring(0, If(TMP_ricerca.Length() - NN <= 0, 0, TMP_ricerca.Length() - NN))
                tmpBS.RemoveFilter()
                tmpTX.Text = TMP_ricerca
                tmpBS.Filter = String.Format("description LIKE '%{0}%'", TMP_ricerca)
                tmpTX.SelectionStart = TMP_ricerca.Length
                CambiaColore(LB_ricerca, tmpTX)
            Else
                Exit Do
            End If
        Loop
    End Sub

    Dim TipoGrigliaSelezionata As String

    Private Sub DG_Orari_CellContentClick(sender As Object, e As MouseEventArgs) Handles DG_orari.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Right Then
            MNU_orari.Show(New Point(MousePosition.X, MousePosition.Y))

        End If

    End Sub

    Private Sub DG_orari_CellContentCli(sender As Object, e As DataGridViewCellEventArgs) Handles DG_orari.CellClick


        If tabPianodiLavoro.SelectedIndex = tbDettaglioClienti.TabIndex Then
            Dim idDet As Integer
            idDet = DG_orari(DGWCiddes.Index, e.RowIndex).Value
            CaricaPianodiLavoroperCliente(idDet)
        End If
    End Sub


    Dim rgMemoriaOrarioRiga As DS_utenti.DT_orariRow
    Private Sub P_orari(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles MNU_orari.ItemClicked
        If BS_utenti.Count <= 0 Then
            Return
        End If
        Dim toolStrip = e.ClickedItem
        MNU_orari.Hide()

        'Prende la riga di Utenti
        Dim rg As DS_utenti.DT_utentiRow
        rg = DirectCast(BS_utenti.Current, DataRowView).Row

        'Prende la riga degli orari
        Dim idOre As Integer


        If DG_orari.Rows.Count > 0 Then
            idOre = DG_orari.CurrentRow.Cells(0).Value
        Else
            idOre = -1
        End If


        Dim dt As DataTable = New DS_utenti.DT_orariDataTable


        Using ta As New DS_utentiTableAdapters.TA_orari
            ta.FillBydipendente(dt, rg.id)
        End Using

        Select Case toolStrip.Name

            Case "MNU_orarioinserisce"
                Dim kr As DS_utenti.DT_orariRow
                kr = dt.NewRow
                kr.id = -1
                kr.id_dip = rg.id
                kr.id_cli = -1
                kr.id_des = -1
                dt.Rows.Add(kr)
                Dim f As New frmDipendentePianodiLavoro(-1, dt)
                f.ShowDialog()
                AggiornamentoRighe()

            Case "MNU_orariomodifica"
                'rgnew = dt.Rows(0)
                Dim f As New frmDipendentePianodiLavoro(idOre, dt)
                f.ShowDialog()
                AggiornamentoRighe()
            Case "MNU_orariocopia"      'copia e lo tiene in memoria
                'Dim rgMemoriaOrarioRiga As DS_clienti.DT_orariRow
                If DG_orari.Rows.Count = 0 Then
                    Return
                End If
                'Dim lista As EnumerableRowCollection
                TA_orari.FillByID(DS_utenti.DT_orari, idOre)
                rgMemoriaOrarioRiga = Me.DS_utenti.DT_orari.NewRow()
                rgMemoriaOrarioRiga = DirectCast(DS_utenti.DT_orari.Rows(0), DataRow)
                rgMemoriaOrarioRiga.id = -1
                '
                MsgBox("Orario Copiato")

            Case "MNU_orarioincolla"    'incolla as un altro dipendente

                If IsNothing(rgMemoriaOrarioRiga) <> True Then
                    Dim j As DS_utenti.DT_orariRow = rgMemoriaOrarioRiga
                    If j.Isid_dipNull Then
                        Return
                    End If
                    TA_orari.QR_inserisce(j.id_dip, j.id_cli, j.id_des, j.lu_i, j.lu_u, j.ma_i, j.ma_u, j.me_i, j.me_u, j.gi_i, j.gi_u, j.ve_i, j.ve_u, j.sa_i, j.sa_u, j.do_i, j.do_u)
                    idOre = TA_orari.QRultimoID()

                    Dim f As New frmDipendentePianodiLavoro(idOre, dt)
                    f.ShowDialog()
                    AggiornamentoRighe()
                End If
            Case "MNU_orarioelimina"    'elimina
                If idOre > 0 Then
                    If MsgBox("Confermi eliminazione del Dettaglio n° " & idOre.ToString() & " ?", MsgBoxStyle.YesNo, "Eliminazione") = MsgBoxResult.Yes Then
                        TA_orari.QR_elimina(idOre)
                        AggiornamentoRighe()
                    End If
                End If
        End Select
    End Sub

    Private Function CaricaDatiOreDipendente(ByRef cli As DataTable, ByRef dtTmp As DSfestivita.dtPianoDataTable)
        'Dim rgWeb As DataRow 'DS_utenti.DT_orariRow
        Dim CliRow As DataRow
        If dtTmp.Rows.Count > 0 Then
            For Each hg As DSfestivita.dtPianoRow In dtTmp.Rows
                CliRow = cli.NewRow
                CliRow("id_utente") = hg.iddip
                CliRow("anagrafica") = hg.ana
                CliRow("id_cliente") = hg.idcli
                CliRow("societa") = hg.soc
                CliRow("id_dettaglio") = hg.iddet
                CliRow("dettaglio") = hg.loc
                CliRow("dat") = hg.dat
                CliRow("ing") = TimeSpan.Parse(hg.ing.ToShortTimeString)
                CliRow("usc") = TimeSpan.Parse(hg.usc.ToShortTimeString)
                CliRow("tot") = hg.tot
                CliRow("idtipoSost") = hg.idtip
                cli.Rows.Add(CliRow)
            Next
        End If
        Return cli
    End Function
    Private Function CreaDTPianooperativoLavoro() As DataTable 'Crea una DT e la popola con i valori passati dal bindingsource
        Dim Ute As DataTable = New DataTable
        Ute.Namespace = "TABtmpUte"
        Dim CliRow As DataRow
        Dim colonna As DataColumn
        colonna = New DataColumn
        colonna.ColumnName = "id_utente"
        colonna.DataType = Type.GetType("System.Int32")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_cliente"
        colonna.DataType = Type.GetType("System.Int32")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_dettaglio"
        colonna.DataType = Type.GetType("System.Int32")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "anagrafica"
        colonna.DataType = Type.GetType("System.String")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "societa"
        colonna.DataType = Type.GetType("System.String")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dettaglio"
        colonna.DataType = Type.GetType("System.String")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dat"
        colonna.DataType = Type.GetType("System.DateTime")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "ing"
        colonna.DataType = Type.GetType("System.TimeSpan")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "usc"
        colonna.DataType = Type.GetType("System.TimeSpan")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "tot"
        colonna.DataType = Type.GetType("System.Decimal")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "idtipoSost"
        colonna.DataType = Type.GetType("System.Int32")
        Ute.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "idrecupero"
        colonna.DataType = Type.GetType("System.Int32")
        Ute.Columns.Add(colonna)
        Return Ute
    End Function

    Private Sub Pulisce_riepilogo_giorni()

        'Ripulisce la griglia dei totali giornalieri
        Select Case TAB_dipendenti.SelectedTab.Name
            Case TB_inserimentopresenze.Name
                DG_totalipresenze.Rows.Clear()
                DG_totalipresenze.AllowUserToAddRows = False
                DG_totalipresenze.AllowUserToDeleteRows = False
            Case TB_presenzeRemote.Name
                Select Case tabControlloTimbrature.SelectedTab.Name
                    Case tbPreviste.Name
                        With dgwOreinagenda
                            .Rows.Clear()
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                        End With
                    Case tbTimbrate.Name
                        With DG_totaleoreweb
                            .Rows.Clear()
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                        End With

                End Select
                With DG_totaleOreWebCliente
                    .Rows.Clear()
                    .AllowUserToAddRows = False
                    .AllowUserToDeleteRows = False
                End With

        End Select
    End Sub
    Private Sub dg_presenzeremote_error(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DG_presenzeRemote.DataError

    End Sub
    Private Sub ContaDG_totaliPresenze()


        'Procedura per calcolare i valori giornalieri delle presenze Remote
        If TAB_dipendenti.SelectedTab.Name <> TB_inserimentopresenze.Name Then
            Return
        End If

        Dim idDip As Integer = DirectCast(BS_utenti.Current, DataRowView).Row.Item("id")
        'Pulisce_riepilogo_giorni()
        'TA_contore.FillByIDdip_Periodo_O_data(DS_utenti.DT_contore, idDip, periodolocale)
        '        BS_contore.Filter = "id_dip = " & idDip
        Dim rg As DS_utenti.DT_contoreRow
        If BS_contore.Count > 0 Then
            rg = DirectCast(BS_contore.Current, DataRowView).Row
            BS_contore.MoveFirst()
        Else
            Return
        End If
        Dim kdat As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0)
        'Crea la tabella con le 31 celle più il nome della società
        Dim Larghezzacellamassima As Integer
        Larghezzacellamassima = (DG_totalipresenze.Width - 300) / kdat.Day + 1
        For tmpd = 0 To kdat.Day + 1 'aggiunge il totale
            'TODO verificare la scrittura dei totali
            Dim testo(2) As String
            testo = ElaboraPresenze.CreaGriglieTimbratureRemote(kdat, BS_contore, DG_totalipresenze, Nothing, BS_tipologia, BScal, True, False)
            LBtotaleDipendenteWeb.Text = testo(0)
            LBtotalepresenzeClienteWEB.Text = testo(1)
            LBesitofiltro.Text = testo(2)
        Next

    End Sub

    Private Sub DG_totaleoreweb_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DG_totaleoreweb.CellFormatting
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        Dim risp As Int16
        risp = e.RowIndex Mod 2
        If risp = 1 Then
            For CC = 1 To tmpDG.Columns.Count - 1
                If tmpDG.Columns(CC).HeaderText.Substring(0, 2) <> "FS" Then
                    If tmpDG(CC, e.RowIndex).Style.ForeColor <> Color.White Then
                        tmpDG(CC, e.RowIndex).Style.BackColor = Color.LightGreen
                    End If

                End If
            Next
        End If
    End Sub
    Private Sub DG_totaleoreweb_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_totaleoreweb.CellMouseClick
        Dim iddes As Integer
        Dim giorno As Integer
        Dim tDGV As DataGridView
        tDGV = DirectCast(sender, DataGridView)
        If e.RowIndex >= 0 Then
            iddes = TryCast(tDGV(0, e.RowIndex).Tag, IConvertible)
            giorno = TryCast(tDGV(e.ColumnIndex, e.RowIndex).Tag, IConvertible)
        End If
        If iddes <> 0 Then
            Dim Larghezzacellamassima As Integer
            Larghezzacellamassima = (DG_totaleoreweb.Width - 285) / DG_totaleoreweb.Columns.Count - 2
            Dim kDat As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0)
            Dim testo As String()
            testo = ElaboraPresenze.caricaRaccoltaClienti(iddes, DG_totaleOreWebCliente, kDat)
            LBtotalepresenzeClienteWEB.Text = testo(1)
        End If
        BTN_filtro.TextImageRelation = TextImageRelation.ImageAboveText

        If iddes = 0 And e.ColumnIndex > 0 And e.ColumnIndex < tDGV.Columns.Count - 1 And e.RowIndex < 0 Then
            Dim data As DateTime = New DateTime(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, e.ColumnIndex)
            RELutentiPresenzeWEB.Filter = String.Format("giorno = '{0}'", data)
            LBesitofiltro.Text = "Filtrato per il giorno " & data.ToShortDateString
            BTN_filtro.Visible = True
            BTN_filtro.Text = "Filtrato per Giorno"
        ElseIf iddes = 0 Or giorno = 0 Then
            RELutentiPresenzeWEB.RemoveFilter()
            LBesitofiltro.Text = "Nessun filtro attivato"
            BTN_filtro.Visible = False
            BTN_filtro.Text = "Nessun Filtro Attivo"

        ElseIf iddes = giorno Then
            RELutentiPresenzeWEB.Filter = String.Format("id_locazione = {0}", iddes)
            LBesitofiltro.Text = "Filtrato per il cliente " & tDGV(0, e.RowIndex).Value
            BTN_filtro.Visible = True
            BTN_filtro.Text = "Filtrato per Cliente"
        Else
            Dim data As DateTime = New DateTime(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, giorno)
            RELutentiPresenzeWEB.Filter = String.Format("giorno = '{0}' AND id_locazione = {1}", data.ToShortDateString, iddes)
            LBesitofiltro.Text = "Filtrato per il cliente " & tDGV(0, e.RowIndex).Value & " " & " il giorno " & giorno
            BTN_filtro.Visible = True
            BTN_filtro.Text = "Filtrato per Cliente e Giorno"
        End If
    End Sub

    Private Sub Annulla()
        BSREL_UtentiContore.CancelEdit()
        Dim rg As DS_personale.DT_contoreRow
        For Each gg In BSREL_UtentiContore
            rg = DirectCast(gg, DataRowView).Row
            Try
                rg.RejectChanges()
            Catch ex As Exception

            End Try

        Next

    End Sub
    Private Function DG_Nuovoinserimento()
        If Not DG_contore.NewRowIndex Then
            Dim Rind As Integer = DG_contore.Rows.Count
            Dim oldData As DateTime
            Dim oldCli As Integer
            Dim olddes As Integer
            Dim olddip As Integer
            Dim oldtip As Integer
            If Rind > 1 Then
                oldData = DG_contore("C_data", DG_contore.CurrentRow.Index).Value
                oldCli = DG_contore("C_id_cli", DG_contore.CurrentRow.Index).Value
                olddes = DG_contore("C_id_dest", DG_contore.CurrentRow.Index).Value
                '                olddip = DG_contore("C_id_dip", DG_contore.CurrentRow.Index).Value
                oldtip = DG_contore("C_id_tipo", DG_contore.CurrentRow.Index).Value
            Else
                oldData = DateSerial(Now().Year, Now().Month, 1)
            End If
            Dim rg As DS_utenti.DT_contoreRow
            'DG_contore.CurrentCell = DG_contore("C_data", Rind - 1)
            rg = DirectCast(BSREL_UtentiContore.Current, DataRowView).Row
            rg.data = oldData
            rg.id_cli = oldCli
            rg.id_dest = olddes
            rg.id_dip = olddip
            rg.id_tipo = oldtip
            DG_contore.Focus()
        End If
        Return True
    End Function



    Private Sub DG_contore_DefaultValuesNeeded(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles DG_contore.DefaultValuesNeeded
        Dim RGold As DS_utenti.DT_contoreRow
        Dim idcli As Integer
        Dim iddes As Integer
        Dim idtip As Integer
        Dim odata As DateTime
        Try
            If BSREL_UtentiContore.Count > 1 Then
                BSREL_UtentiContore.MovePrevious()
                RGold = DirectCast(BSREL_UtentiContore.Current, DataRowView).Row
                idcli = RGold.id_cli
                iddes = RGold.id_dest
                idtip = RGold.id_tipo
                odata = RGold.data
            Else
                odata = DateSerial(Now().Year, Now().Month, 1)
                idcli = 0
                iddes = 0
                idtip = 1
            End If
            With e.Row
                .Cells("CC_data").Value = odata
                .Cells("C_id_cli").Value = idcli
                .Cells("C_id_dest").Value = iddes
                .Cells("C_id_tipo").Value = idtip
            End With

        Catch ex As Exception

        End Try

    End Sub
    Private Sub DG_contore_Validating(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles DG_contore.RowValidating
        'Valida e inserisce la presenza
        If Not TAB_dipendenti.SelectedTab.Name = TB_inserimentopresenze.Name Then
            Return
        End If
        Dim RGold As DS_utenti.DT_contoreRow
        Dim n As Integer = BSREL_UtentiContore.Count
        Try
            BSREL_UtentiContore.EndEdit()
        Catch ex As Exception
            BSREL_UtentiContore.CancelEdit()
        End Try
        If n <= 0 Then
            Return
        End If
        RGold = DirectCast(BSREL_UtentiContore.Current, DataRowView).Row
        If n = 1 And RGold.ore = 0 Then
            Return
        End If
        Select Case RGold.RowState
            Case DataRowState.Added
                Dim newID As Integer = TA_contore.SQultimoID
                RGold.id = newID + 1
                Select Case True
                    Case RGold.ore <= 0
                        MsgBox("Inserisci un'ora corretta")
                        BSREL_UtentiContore.CancelEdit()
                    Case RGold.id_tipo = 0
                        MsgBox("Inserisci una tipologia corretta")
                        BSREL_UtentiContore.CancelEdit()
                    Case Else
                        Try
                            TA_contore.inserisce(RGold.id, RGold.id_cli, RGold.id_dip, RGold.id_dest, RGold.id_tipo, RGold.data, RGold.ore, RGold.note, Now())
                            RGold.AcceptChanges()
                        Catch ex As Exception
                            TA_contore.inserisce(RGold.id + 1, RGold.id_cli, RGold.id_dip, RGold.id_dest, RGold.id_tipo, RGold.data, RGold.ore, RGold.note, Now())
                            RGold.AcceptChanges()
                        End Try

                End Select
            Case DataRowState.Modified
                TA_contore.modifica(RGold.id_cli, RGold.id_dip, RGold.id_dest, RGold.id_tipo, RGold.data, RGold.ore, RGold.note, Now(), RGold.id)
                RGold.AcceptChanges()
        End Select

        DG_contore.Focus()
    End Sub
    Private Sub PIC_cestino_DragEnter(ByVal sender As Object,
  ByVal e As DragEventArgs) Handles PIC_cestino.DragEnter
        'Se contiene i dati giusti di tipo String
        Dim p As Object = e.Data.GetData(GetType(Integer))
        If e.Data.GetDataPresent(GetType(Integer)) Then
            'Continua a copiare
            e.Effect = DragDropEffects.Copy
        Else
            'Altrimenti annulla l'azione
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub PIC_cestino_DragDrop(ByVal sender As Object,
    ByVal e As DragEventArgs) Handles PIC_cestino.DragDrop
        'Ottiene i dati di tipo string presenti in memoria
        Dim S As Integer = e.Data.GetData(GetType(Integer))
        Dim RG As DS_utenti.DT_AUDPRow
        RG = DirectCast(RELAUDP.Current, DataRowView).Row
        RG.Delete()
        RELAUDP.EndEdit()
        TA_AUDP.elimina(S)
        RG.AcceptChanges()
        e.Effect = DragDropEffects.None
    End Sub

    Private Sub DGVprogramma_mouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGVprogramma.MouseDown
        Dim idTMP As Integer = DGVprogramma(DGVprogramma.Columns("DGVProgrammaCOL_id").Index, DGVprogramma.CurrentRow.Index).Value
        DGVprogramma.DoDragDrop(idTMP, DragDropEffects.Copy)
    End Sub
    Private Sub DGV_GiveFeedback(ByVal sender As Object, ByVal e As GiveFeedbackEventArgs) Handles DGV.GiveFeedback
        If ((e.Effect And DragDropEffects.Copy) = DragDropEffects.Copy) Then
            Cursor.Current = Cursors.UpArrow
        Else
            Cursor.Current = Cursors.Default
        End If
    End Sub
    Friend rowIndexFromMouseDown As Int16       'Indice Riga quando il mouse viene messo in DOWN
    Friend dragBoxFromMouseDown As Rectangle    'Memorizza il rettangolo che delimita le righe
    Private Sub DGV_mouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGV.MouseDown
        rowIndexFromMouseDown = DGV.HitTest(e.X, e.Y).RowIndex
        If Not rowIndexFromMouseDown = -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragBoxFromMouseDown = New Rectangle(New Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize)
        Else
            dragBoxFromMouseDown = Rectangle.Empty
        End If

    End Sub
    Private Sub DGV_mouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGV.MouseMove
        Dim f1 As MouseButtons
        f1 = e.Button
        Console.WriteLine(f1)
        If e.Button = MouseButtons.Left Then
            If Not dragBoxFromMouseDown = Rectangle.Empty And Not dragBoxFromMouseDown.Contains(e.X, e.Y) Then
                Dim idDip As Integer = DGV.Rows(rowIndexFromMouseDown).Cells(DGV_COL_id.Index).Value
                Dim dropEffect As DragDropEffects = DGV.DoDragDrop(idDip, DragDropEffects.Move)
            End If
        End If
    End Sub
    Private Sub DGV_drogOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGV.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub DGVprogramma_dragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGVprogramma.DragOver
        e.Effect = DragDropEffects.Move
    End Sub
    Private Sub DVGprogramma_DragEnter(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGVprogramma.DragEnter
        If e.Data.GetDataPresent(GetType(String)) Then
            'Continua a copiare
            e.Effect = DragDropEffects.Copy
        Else
            'Altrimenti annulla l'azione
            e.Effect = DragDropEffects.None
        End If
    End Sub
    Private Sub DGVprogramma_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGVprogramma.DragDrop

        'Ottiene i dati di tipo string presenti in memoria
        Dim idDes As String = e.Data.GetData(GetType(Integer))
        If idDes < 0 Then
            Return
        End If
        Dim RG As DS_utenti.DT_AUDPRow
        Dim idDip As Integer
        Dim idCli As Integer
        Dim Dettaglio, Societa As String
        Dim RGute As DS_utenti.DT_utentiRow
        RGute = DirectCast(BS_utenti.Current, DataRowView).Row
        idDip = RGute.id
        idCli = DGV(COL_DGV_id_terminale.Index, DGV.CurrentRow.Index).Value
        Dettaglio = DGV(DGV_Locazione.Index, DGV.CurrentRow.Index).Value
        Societa = DGclientiabbinabili(DGclientiabbinabili_societa.Index, DGclientiabbinabili.CurrentRow.Index).Value
        Dim controlloPresenza As Integer = 0
        If RELAUDP.Count > 0 Then
            RG = DirectCast(RELAUDP.Current, DataRowView).Row
            controlloPresenza = TA_AUDP.SQesistegia(idDip, idDes)
        End If
        If controlloPresenza = 0 Then
            RELAUDP.AddNew()
            RG = DirectCast(RELAUDP.Current, DataRowView).Row
            RG.note = Dettaglio
            RG.id_dip = idDip
            RG.id_cli = idCli
            RG.id_des = idDes
            RG.inizio_abbinamento = Now()
            RG.fine_abbinamento = Now().AddDays(365)
            RG.societa = Societa
            RG.locazione = Dettaglio
            Dim RGdip As DS_utenti.DT_utentiRow
            RGdip = DirectCast(BS_utenti.Current, DataRowView).Row
            RG.anagrafica = RGdip.Anagrafica
            Dim livello As Integer = 5
            RELAUDP.EndEdit()
            TA_AUDP.inserisce(RG.id_dip, RG.id_cli, RG.id_des, RG.inizio_abbinamento, RG.fine_abbinamento, RG.note, livello)
            RG.AcceptChanges()
            TA_AUDP.Fill(DS_utenti.DT_AUDP)
        Else
            MsgBox("Già presente")
        End If
        e.Effect = DragDropEffects.None
    End Sub
    'Private sub txvv(sender As Object, e As EventArgs) Handles TX_RX_cliente.Validating
    Private Sub TX_RX_cliente_TextChanged(sender As Object, e As EventArgs) Handles TX_RX_cliente.TextChanged
        Dim TMPTX As TextBox
        Dim ricerca As String
        TMPTX = DirectCast(sender, TextBox)
        ricerca = TMPTX.Text
        Dim S_oldFiltro As String = ""
        S_oldFiltro = IIf(CKclientiabbinabili.Checked = True, "attivo = 1", "")
        Dim T_fil As String = If(IsNothing(S_oldFiltro), "", S_oldFiltro)
        BS_clienti.Filter = If(T_fil.Length > 0, T_fil & " AND ", "") & String.Format("societa LIKE '%{0}%'", ricerca)
        Dim NN As Integer = 0
        Do While BS_clienti.Count < 1
            NN += 1
            If ricerca.Length() > 0 Then
                ricerca = TMPTX.Text.Substring(0, If(TMPTX.Text.Length() - NN <= 0, 0, TMPTX.Text.Length() - NN))
                BS_clienti.Filter = If(T_fil.Length > 0, T_fil & " AND ", "") & String.Format("societa LIKE '%{0}%'", ricerca)
                TMPTX.Text = ricerca
                TMPTX.SelectionStart = TMPTX.Text.Length
                CambiaColore()
            Else
                Exit Do
            End If
        Loop
    End Sub

    Private Sub DG_presenzeRemote_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_presenzeRemote.CellContentClick
        If e.RowIndex >= 0 And e.ColumnIndex = DGWCpresenzewebid.Index Then
            Dim RG As DS_utenti.DT_presenzeWEBRow
            RG = DirectCast(RELutentiPresenzeWEB.Current, DataRowView).Row
            Dim F As New FrmDipendentiPresenzeWeb(RG.id, Me.DS_utenti.DT_clienti, Me.DS_utenti.DT_destinatari, RG)
            F.ShowDialog()
            If RG.RowState = DataRowState.Modified Then
                TA_presenzeWEB.modificaPresenze(RG.id_terminale, RG.id_locazione, RG.giorno, RG.ingresso.ToString(), RG.uscita.ToString(), RG.note, RG.inviato, RG.id)
                RG.AcceptChanges()
                'BTN_aggiornaPresenzeWeb.PerformClick()
            End If

        End If
    End Sub


    Private Sub BTN_aggiornaPresenzeWeb_Click(sender As Object, e As EventArgs) Handles BTN_aggiornaPresenzeWeb.Click
        Dim RGll As DS_utenti.DT_utentiRow
        RGll = DirectCast(BS_utenti.Current, DataRowView).Row
        Dim kDat As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0)

        Using TA As New DS_utentiTableAdapters.TA_cal
            Using DT As New DS_utenti.DT_calDataTable
                TA.FillByPeriodo(DT, PeriodoLocale)
                BS_Cal.DataSource = DT
            End Using
        End Using
        Select Case tabControlloTimbrature.SelectedTab.Name
            Case tbTimbrate.Name
                TA_presenzeWEB.FillByutenteperiodo(Me.DS_utenti.DT_presenzeWEB, PeriodoLocale, RGll.id)
                If BSPresenzeWEB.Count > 0 Then
                    Dim testo(2) As String
                    testo = ElaboraPresenze.CreaGriglieTimbratureRemote(kDat, BSPresenzeWEB, DG_totaleoreweb, DG_totaleOreWebCliente, BS_tipologia, BScal)
                    TaPresenzaStampa.FillByDipendentePeriodo(Me.DS_utenti.dtPresenzaStampa, RGll.id, PeriodoLocale.Replace("-", ""))


                    LBtotaleDipendenteWeb.Text = testo(0)
                    LBtotalepresenzeClienteWEB.Text = testo(1)
                    LBesitofiltro.Text = testo(2)
                Else
                    LBtotaleDipendenteWeb.Text = "0"
                End If
            Case tbPreviste.Name
                Dim rit As Boolean = GeneraPianodiLavoroDipendente.CaricaIntestazioniPresenzePreviste(dgwOreinagenda, kDat.Day + 1, BS_Cal)
                Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
                Using ta As New DSfestivitaTableAdapters.TAtipoorario
                    ta.Fill(dtTipoOrario)
                End Using
                GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioDipendente(dgwOreinagenda, dtUT, BS_utenti, PeriodoLocale, dtTipoOrario, False, BS_Cal)
            Case tbConfrontoPresenze.Name
                TA_presenzeWEB.FillByutenteperiodo(Me.DS_utenti.DT_presenzeWEB, PeriodoLocale, RGll.id)
                If BSPresenzeWEB.Count > 0 Then
                    Dim testo(2) As String
                    testo = ElaboraPresenze.CreaGriglieTimbratureRemote(kDat, BSPresenzeWEB, dgwConfrontoPresenze, DG_totaleOreWebCliente, BS_tipologia, BScal, False)
                    LBtotaleDipendenteWeb.Text = testo(0)
                    lbPresenzeCliente.Text = testo(1)
                    LBesitofiltro.Text = testo(2)
                Else
                    LBtotaleDipendenteWeb.Text = "0"
                End If
                Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
                Using ta As New DSfestivitaTableAdapters.TAtipoorario
                    ta.Fill(dtTipoOrario)
                End Using

                dtUT = GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioDipendente(dgwConfrontoPresenze, dtUT, BS_utenti, PeriodoLocale, dtTipoOrario, False, BS_Cal, False)

        End Select

    End Sub


    Private Sub DG_presenzeRemote_cellFormatting(ByVal sender As Object,
                                                 ByVal e As DataGridViewCellFormattingEventArgs) Handles DG_presenzeRemote.CellFormatting

        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)

        If tmpDG.Columns(e.ColumnIndex).Name = DGWCpresenzewebingresso.Name Or tmpDG.Columns(e.ColumnIndex).Name = DGWCpresenzewebuscita.Name Or tmpDG.Columns(e.ColumnIndex).Name = DGWCpresenzeweborario.Name Then
            FormattaCellaOraCorta(e)
            If Not IsDBNull(tmpDG(DGWCpresenzewebid_esterno.Index, e.RowIndex).Value) Then
                Dim idUID As Integer = If(tmpDG(DGWCpresenzewebid_esterno.Index, e.RowIndex).Value > 6, 6, tmpDG(DGWCpresenzewebid_esterno.Index, e.RowIndex).Value)
                If idUID <> 0 Then
                    tmpDG(DGWCpresenzewebid.Index, e.RowIndex).ToolTipText = gArrayNomeUtenti(idUID - 1)
                    Dim Colore As Color = Color.FromName(gArrayColoreUtenti(idUID - 1))
                    e.CellStyle.BackColor = Colore
                End If
            End If
        ElseIf tmpDG.Columns(e.ColumnIndex).Name = DGWCpresenzewebGiorno.Name Then
            FormattaCellaDataCorta(e)
            If Not IsDBNull(tmpDG(DGWCpresenzewebid_esterno.Index, e.RowIndex).Value) Then
                Dim idUID As Integer = If(tmpDG(DGWCpresenzewebid_esterno.Index, e.RowIndex).Value > 6, 6, tmpDG(DGWCpresenzewebid_esterno.Index, e.RowIndex).Value)
                If idUID <> 0 Then
                    DG_presenzeRemote(DGWCpresenzewebid.Index, e.RowIndex).ToolTipText = gArrayNomeUtenti(idUID - 1)
                    Dim Colore As Color = Color.FromName(gArrayColoreUtenti(idUID - 1))
                    e.CellStyle.BackColor = Colore
                End If
            End If
        ElseIf Not IsDBNull(tmpDG(DGWCpresenzewebid_esterno.Index, e.RowIndex).Value) Then
            Dim idUID As Integer = If(tmpDG(DGWCpresenzewebid_esterno.Index, e.RowIndex).Value > 6, 6, tmpDG(DGWCpresenzewebid_esterno.Index, e.RowIndex).Value)
            If idUID <> 0 Then
                DG_presenzeRemote(DGWCpresenzewebid.Index, e.RowIndex).ToolTipText = gArrayNomeUtenti(idUID - 1)
                Dim Colore As Color = Color.FromName(gArrayColoreUtenti(idUID - 1))
                e.CellStyle.BackColor = Colore
            End If
        End If
    End Sub

    Private Shared Sub FormattaCellaDataCorta(ByVal formatting As DataGridViewCellFormattingEventArgs)
        If formatting.Value IsNot Nothing Then
            Try
                Dim dateString As System.Text.StringBuilder = New System.Text.StringBuilder()
                Dim theDate As Date = DateTime.Parse(formatting.Value.ToString())
                dateString.Append(theDate.Day.ToString().PadLeft(2, "0"))
                dateString.Append("/")
                dateString.Append(theDate.Month.ToString().PadLeft(2, "0"))
                '                dateString.Append(theDate.Year.ToString().Substring(2))
                formatting.Value = dateString.ToString()
                formatting.FormattingApplied = True
                Console.WriteLine(dateString.ToString())
            Catch notInDateFormat As FormatException

                formatting.FormattingApplied = False
            End Try
        End If
    End Sub
    Private Shared Sub FormattaCellaOraCorta(ByVal formatting As DataGridViewCellFormattingEventArgs)
        If formatting.Value IsNot Nothing Then
            Try
                Dim dateString As System.Text.StringBuilder = New System.Text.StringBuilder()
                Dim lora As TimeSpan = TimeSpan.Parse(formatting.Value.ToString())
                dateString.Append(lora.Hours.ToString().PadLeft(2, "0"))
                dateString.Append(":")
                dateString.Append(lora.Minutes.ToString().PadLeft(2, "0"))
                formatting.Value = dateString.ToString()
                formatting.FormattingApplied = True
            Catch notInDateFormat As FormatException

                formatting.FormattingApplied = False
            End Try
        End If
    End Sub

    Private Sub BTN_inviapresenze_Click(sender As Object, e As EventArgs) Handles BTN_inviapresenze.Click
        Dim RGp As DS_utenti.DT_presenzeWEBRow
        Dim LunghezzaFiltro As Int16
        If Not IsNothing(RELutentiPresenzeWEB.Filter) Then
            LunghezzaFiltro = CType(RELutentiPresenzeWEB.Filter.Length, Int16)
        Else
            LunghezzaFiltro = 0
        End If
        If LunghezzaFiltro > 0 Then
            Dim risp As MsgBoxResult
            risp = MsgBox("Attenzione è Attivo un filtro, vuoi disattivarlo ?", MsgBoxStyle.YesNoCancel)
            If risp = MsgBoxResult.Yes Then
                BTN_filtro.PerformClick()
            ElseIf risp = MsgBoxResult.Cancel Then
                Return
            End If
        End If
        'Dim k As Integer = RELutentiPresenzeWEB.Count
        RELutentiPresenzeWEB.Filter = "auto = 0"
        Dim MaxValue As Integer = RELutentiPresenzeWEB.Count
        TTPB.Maximum = MaxValue
        TTPB.Step = 1
        Dim xx As Integer = 0
        TTPB.Value = xx
        For Each RGpw In RELutentiPresenzeWEB
            xx += 1
            TTPB.Value = If(xx <= MaxValue, xx, MaxValue)
            System.Threading.Thread.Sleep(10)
            RGp = DirectCast(RGpw, DataRowView).Row
            If RGp.orario.ToString().Trim() = "" Then
                Continue For
            End If
            Dim Ora As TimeSpan
            Ora = TimeSpan.Parse(RGp.orario)
            Dim Nota As String = ""
            Try
                If Not IsDBNull(RGp.note) Then
                    Nota = RGp.note
                End If
            Catch ex As Exception
                Dim g As String = ex.Message
            End Try
            Dim Risultato0, Risultato1 As TimeSpan
            Dim Risultato2 As Decimal

            Risultato0 = ApprossimaOrario(RGp.ingresso, 15)
            Risultato1 = ApprossimaOrario(RGp.uscita, 15)
            Risultato2 = Math.Abs(Risultato1.Subtract(Risultato0).TotalHours)
            If RGp.giorno.Day > 27 Then
                Console.WriteLine(Risultato0.Subtract(Risultato1).Minutes)
            End If
            Dim Risp As Integer
            Risp = TA_contore.trasferimentoweb(RGp.id, RGp.id_terminale, RGp.id_utente, RGp.id_locazione, RGp.inviato, RGp.giorno, Risultato2, Nota, RGp.data, Now)
            If Risp <> 1 Then
                MsgBox("Inserimento del " & RGp.data.ToShortDateString & " per la societa :" & RGp.societa & " non riuscito")
            Else
                TA_presenzeWEB.inviato(1, RGp.id)
            End If
        Next
        TTPB.Value = 0
        RELutentiPresenzeWEB.RemoveFilter()
        TA_presenzeWEB.FillByPeriodo(Me.DS_utenti.DT_presenzeWEB, PeriodoLocale)
        If MsgBox("Vuoi stampare il riepilogo delle presenze ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BTstampariepilogooreweb.PerformClick()
            BTN_aggiornaPresenzeWeb.PerformClick()
        End If

    End Sub

    Private Sub DG_contore_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_contore.CellContentClick
        Dim idDip As Integer
        idDip = DirectCast(BS_utenti.Current, DataRowView).Row.Item("id")

        If e.RowIndex >= 0 And e.ColumnIndex = DG_contore.Columns(0).Index Then
            Dim idIP As Integer = DG_contore(e.ColumnIndex, e.RowIndex).Value
            Dim RG As DS_utenti.DT_presenzeWEBRow
            Using dt As New DS_utenti.DT_presenzeWEBDataTable
                Using ta As New DS_utentiTableAdapters.TA_presenzeWEB
                    ta.FillByID(dt, idIP)
                    RG = dt.Rows(0)
                End Using
            End Using
            Dim F As New FrmDipendentiPresenzeWeb(idIP, DS_utenti.DT_clienti, DS_utenti.DT_destinatari, RG)
            F.ShowDialog()
        End If
    End Sub

    Private Sub TAB_dipendenti_Click(sender As Object, e As EventArgs) Handles TAB_dipendenti.SelectedIndexChanged
        'Cambio TAB
        If BS_utenti.Count <= 0 Then
            Return
        End If
        Dim rgloc As DS_utenti.DT_utentiRow
        rgloc = DirectCast(BS_utenti.Current, DataRowView).Row
        AggiornamentoRighe()
        If TAB_dipendenti.SelectedTab.Name <> tbPianodilavoro.Name Then

        End If

    End Sub

    Private Sub BT_elimina_Click(sender As Object, e As EventArgs) Handles BT_elimina.Click
        Dim RGweb As DS_utenti.DT_presenzeWEBRow
        RGweb = DirectCast(RELutentiPresenzeWEB.Current, DataRowView).Row
        If MsgBox("sei sicuro di voler eliminare l'inserimento ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Using TA As New DS_utentiTableAdapters.TA_presenzeWEB
                TA.QRelimina(RGweb.id)
                DG_presenzeRemote.Rows.RemoveAt(DG_presenzeRemote.CurrentRow.Index)
                RGweb.AcceptChanges()
            End Using
        End If
    End Sub

    Private Sub BT_aggiunge_Click(sender As Object, e As EventArgs) Handles BT_aggiunge.Click
        Dim iddes As Integer    'Dettaglio
        Dim giorno As DateTime
        Dim idter As Integer    'Terminale
        Dim ing As TimeSpan
        Dim usc As TimeSpan
        Dim inv As Int32
        Dim RGweb As DS_utenti.DT_presenzeWEBRow
        If RELutentiPresenzeWEB.Count > 0 Then
            RGweb = DirectCast(RELutentiPresenzeWEB.Current, DataRowView).Row
            iddes = RGweb.id_locazione
            idter = RGweb.id_terminale
            giorno = RGweb.giorno
            ing = RGweb.ingresso
            usc = RGweb.uscita
            inv = RGweb.inviato
        End If
        RELutentiPresenzeWEB.AddNew()
        RGweb = DirectCast(RELutentiPresenzeWEB.Current, DataRowView).Row
        RGweb.data = Now
        RGweb.giorno = giorno
        RGweb.id_locazione = iddes
        RGweb.id_terminale = idter
        RGweb.ingresso = ing
        RGweb.uscita = usc
        RGweb.inviato = inv
        RGweb.note = ""

        RELutentiPresenzeWEB.EndEdit()
        TA_presenzeWEB.QRinseriscecompleto(GlobalVarPOP.G_idUtente, RGweb.id_terminale, RGweb.id_locazione, RGweb.id_utente, Now(), RGweb.giorno, RGweb.ingresso.ToString(), RGweb.uscita.ToString(), RGweb.note, RGweb.inviato)
        Dim idx As Integer = TA_presenzeWEB.QRultimoid()
        RGweb.id = idx
        RGweb.AcceptChanges()
        Dim F As New FrmDipendentiPresenzeWeb(idx, Me.DS_utenti.DT_clienti, Me.DS_utenti.DT_destinatari, RGweb)
        F.ShowDialog()
        BTN_aggiornaPresenzeWeb.PerformClick()
    End Sub

    Private Sub BTNaggiungiferie_Click(sender As Object, e As EventArgs) Handles btnAggiungiFerie.Click
        Dim RG As DSfestivita.DTferieutenteRow
        Dim RRLL As DS_utenti.DT_utentiRow
        RRLL = DirectCast(BS_utenti.Current, DataRowView).Row
        If btnAggiungiFerie.Tag = 0 Then
            If BSferieutente.Count > 0 Then
                If MsgBox("Vuoi aggiungere nuovo periodo", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    BSferieutente.AddNew()
                    RG = DirectCast(BSferieutente.Current, DataRowView).Row
                End If
            Else
                BSferieutente.AddNew()
                RG = DirectCast(BSferieutente.Current, DataRowView).Row
            End If
            txInizioFerie.Focus()
        Else
            BSferieutente.EndEdit()
            RG = DirectCast(BSferieutente.Current, DataRowView).Row
            RG.id_dip = RRLL.id
            RG.note = If(RG.IsnoteNull, RG.note = "", RG.note)
            If RG.IsinizioNull Then
                Return
            End If
            If RG.IsfineNull Then
                Return
            End If
            If MsgBox("confermi le ferie ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If RG.IscontrolloNull Then
                    RG.controllo = 1
                End If
                Select Case RG.controllo
                    Case 1
                        RG.id_user_visione = GlobalVarPOP.G_idUtente
                        RG.data_visione = Now()
                        RG.id_user_accettazione = GlobalVarPOP.G_idUtente
                        RG.data_accettazione = Now()
                    Case Else
                        If RG.Isid_user_visioneNull Then
                            RG.id_user_visione = GlobalVarPOP.G_idUtente
                        ElseIf RG.id_user_visione = 0 Then
                            RG.id_user_visione = GlobalVarPOP.G_idUtente
                        End If
                        If RG.Isdata_visioneNull Then
                            RG.data_visione = Now()
                        End If
                        RG.id_user_accettazione = GlobalVarPOP.G_idUtente
                        RG.data_accettazione = Now()
                End Select
                If RG.RowState = DataRowState.Modified Then
                    TAferieutente.QRmodifica(RG.id_dip, RG.inizio, RG.fine, If(RG.IsnoteNull, Nothing, RG.note), If(RG.IscontrolloNull, 0, RG.controllo),
                                             If(RG.Isid_cliNull, Nothing, RG.id_cli), If(RG.Isid_desNull, Nothing, RG.id_des), If(RG.Isid_user_visioneNull, Nothing, RG.id_user_visione),
                                             If(RG.Isid_user_accettazioneNull, Nothing, RG.id_user_accettazione), If(RG.Isdata_visioneNull, Nothing, RG.data_visione),
                                             If(RG.Isdata_accettazioneNull, Nothing, RG.data_accettazione), RG.id)
                ElseIf RG.RowState = DataRowState.Added Then
                    '' Sistemare Utente che approva
                    TAferieutente.QRinserisci(RG.id_dip, RG.inizio, RG.fine, If(RG.IsnoteNull, Nothing, RG.note),
                                              If(RG.IscontrolloNull, 0, RG.controllo), If(RG.Isid_cliNull, Nothing, RG.id_cli),
                                              If(RG.Isid_desNull, Nothing, RG.id_des), If(RG.Isid_user_visioneNull, Nothing, RG.id_user_visione),
                                              If(RG.Isid_user_accettazioneNull, Nothing, RG.id_user_accettazione), If(RG.Isdata_visioneNull, Nothing, RG.data_visione),
                                              If(RG.Isdata_accettazioneNull, Nothing, RG.data_accettazione))
                End If
            End If
            RG.AcceptChanges()
            BTNricalcolaferie.PerformClick()
        End If
        If btnAggiungiFerie.Tag = 0 Then
            btnAggiungiFerie.Tag = 1
        Else
            btnAggiungiFerie.Tag = 0
        End If
        btnAggiungiFerie.Text = If(btnAggiungiFerie.Tag = 1, "Salva", "Aggiungi")
    End Sub


    Private Sub BTNeliminaferie_Click(sender As Object, e As EventArgs) Handles btnEliminaFeriedip.Click
        Dim RG As DSfestivita.DTferieutenteRow
        If BSferieutente.Count > 0 Then
            RG = DirectCast(BSferieutente.Current, DataRowView).Row
            If MsgBox("Vuoi Eliminare il periodo dal " & RG.inizio & " al " & RG.fine & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TAferieutente.QReliminabyID(RG.id)
                RG.Delete()
            End If
        End If
    End Sub
    Private Sub DG_presenzeRemote_CellContentValidate(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DG_presenzeRemote.CellValidating
        Dim RG As DS_utenti.DT_presenzeWEBRow
        RG = DirectCast(RELutentiPresenzeWEB.Current, DataRowView).Row
        Dim tmpDG As DataGridView = DirectCast(sender, DataGridView)
        If tmpDG.IsCurrentCellDirty = True Then

            If e.RowIndex >= 0 And e.ColumnIndex = DGWCpresenzewebnote.Index Then  'se modifico le note
                If e.FormattedValue <> RG.note Then
                    BSPresenzeWEB.EndEdit()
                    'If MsgBox("Modifica la riga?") Then
                    Using TA As New DS_clientiTableAdapters.TA_presenzeWEB
                        TA.QRmodificanota(e.FormattedValue, RG.id)
                        RG.AcceptChanges()
                    End Using
                    'End If
                End If
            ElseIf e.RowIndex >= 0 And e.ColumnIndex = DGWCpresenzewebGiorno.Index Then  'se modifico la data
                Dim dataNew As DateTime
                dataNew = DateSerial(Integer.Parse(PeriodoLocale.Split("-").First), Integer.Parse(e.FormattedValue.ToString().Split("/").Last), Integer.Parse(e.FormattedValue.ToString().Split("/").First))
                If dataNew <> RG.giorno Then
                    BSPresenzeWEB.EndEdit()
                    'If MsgBox("Modifica la riga?") Then
                    Using TA As New DS_clientiTableAdapters.TA_presenzeWEB
                        TA.QRmodificagiorno(dataNew, RG.id)
                        RG.AcceptChanges()
                    End Using
                End If
            ElseIf e.RowIndex >= 0 And e.ColumnIndex = DGWCpresenzewebinviato.Index Then ' se convalido
                Dim Valore As Integer
                Valore = CType(e.FormattedValue, Integer)
                Valore = If(Valore = -1, 1, Valore)
                TA_presenzeWEB.QRconvalida(Valore, RG.id)
                RG.AcceptChanges()
            ElseIf e.RowIndex >= 0 And e.ColumnIndex = DGWCpresenzewebingresso.Index Then
                Dim tmpF As String = e.FormattedValue.ToString.Replace(".", ":").Replace("-", ":").Replace(",", ":")
                Dim tmpOrario As TimeSpan = TimeSpan.Parse(tmpF)
                RG.ingresso = tmpOrario
                Dim tmpTotale As String = (RG.uscita - RG.ingresso).ToString("hh\:mm")
                RG.orario = tmpTotale

                TA_presenzeWEB.modificaPresenze(RG.id_terminale, RG.id_locazione, RG.giorno, RG.ingresso.ToString("hh\:mm"), RG.uscita.ToString("hh\:mm"), RG.note, RG.inviato, RG.id)
                RG.AcceptChanges()

            ElseIf e.RowIndex >= 0 And e.ColumnIndex = DGWCpresenzewebuscita.Index Then
                Dim tmpF As String = e.FormattedValue.ToString.Replace(".", ":").Replace("-", ":").Replace(",", ":")
                Dim tmpOrario As TimeSpan = TimeSpan.Parse(tmpF)
                RG.uscita = tmpOrario
                Dim tmpTotale As String = (RG.uscita - RG.ingresso).ToString("hh\:mm")
                RG.orario = tmpTotale

                TA_presenzeWEB.modificaPresenze(RG.id_terminale, RG.id_locazione, RG.giorno, RG.ingresso.ToString("hh\:mm"), RG.uscita.ToString("hh\:mm"), RG.note, RG.inviato, RG.id)
                RG.AcceptChanges()
            ElseIf e.RowIndex >= 0 And e.ColumnIndex = DGWCpresenzewebid_locazione.Index Then
                'Dim Valore As Integer
                'Valore = CType(e.FormattedValue, Integer)
                'If Valore > 0 Then
                '    RG.id_locazione = Valore
                '    TA_presenzeWEB.modificaPresenze(RG.id_terminale, RG.id_locazione, RG.giorno, RG.ingresso.ToString, RG.uscita.ToString, RG.note, RG.inviato, RG.id)
                '    RG.AcceptChanges()
                'End If
            End If
        End If
    End Sub

    Private Sub BTN_filtro_Click(sender As Object, e As EventArgs) Handles BTN_filtro.Click
        RELutentiPresenzeWEB.RemoveFilter()
        BTN_filtro.Visible = False
        BTN_aggiornaPresenzeWeb.PerformClick()
    End Sub

    Private Sub BTNwhatsApp_Click(sender As Object, e As EventArgs) Handles BTNwhatsApp.Click
        Dim RG As DS_utenti.DT_utentiRow
        RG = DirectCast(BS_utenti.Current, DataRowView).Row

        Dim Mionumero As String
        If RG.IscellulareNull Then
            Mionumero = ""
        Else
            If RG.cellulare = "" Then
                Mionumero = ""
            Else
                Mionumero = "Phone="
                Mionumero = Mionumero & RG.cellulare.Replace(" ", "").Replace("-", "").Replace(".", "") & "&"
            End If
        End If
        Dim Testo As String = "text="
        Testo = Testo & Uri.EscapeDataString(TBXwa.Text)
        Dim Surl As String = "https://api.whatsapp.com/send?"

        Dim postdata As String = Surl & Mionumero & Testo

        Process.Start("Chrome.exe", postdata)

    End Sub

    Private Sub BTNconvalidaweb_Click(sender As Object, e As EventArgs) Handles BTNconvalidaweb.Click
        Dim RG As DS_utenti.DT_presenzeWEBRow
        If RELutentiPresenzeWEB.Count > 0 Then
            RG = DirectCast(RELutentiPresenzeWEB.Current, DataRowView).Row
            If MsgBox("Sei sicuro di voler convalidare le presenze del dipendente ?" & RG.anagrafica, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                BSPresenzeWEB.EndEdit()
                'If MsgBox("Modifica la riga?") Then
                Using TA As New DS_utentiTableAdapters.TA_presenzeWEB
                    TA.QRconvalidaildipendentenelperiodo(1, RG.id_utente, PeriodoLocale)
                    BTN_aggiornaPresenzeWeb.PerformClick()
                End Using
            End If
        Else
            MsgBox("Controlla se ci sono Filtri attivi ", MsgBoxStyle.OkOnly)
        End If
    End Sub

    Private Sub BTstampariepilogooreweb_Click(sender As Object, e As EventArgs) Handles BTstampariepilogooreweb.Click
        TabControl1.SelectedTab = tpStampaRiepilogo
        'btStampaRiepilogoPresenze.PerformClick()
    End Sub

    Private Sub RBselezionatesto0_CheckedChanged(sender As Object, e As EventArgs) Handles RBselezionatesto0.CheckedChanged
        CreaTestoCondivisione(1)
    End Sub
    Private Sub RBselezionatesto1_CheckedChanged(sender As Object, e As EventArgs) Handles RBselezionatesto1.CheckedChanged
        CreaTestoCondivisione(2)
    End Sub
    Private Sub CreaTestoCondivisione(ByVal Cosa As Integer)
        Dim RGdip As DS_utenti.DT_utentiRow
        If BS_utenti.Count <= 0 Then
            Return
        End If
        RGdip = DirectCast(BS_utenti.Current, DataRowView).Row
        '        VerificaUtenteRemoto(RGdip.id)

        Select Case Cosa
            Case 1
                Dim Testo As String
                TBXwa.Text = ""
                Testo = "Gent.mo " & RGdip.nome & vbCrLf
                Testo = Testo & "Qui sotto il collegamento alla WEB app per la rilevazione delle presenze " & vbCrLf
                Testo = Testo & "Questo Software ti permette di compilare in autonomia il tuo foglio presenze." & vbCrLf
                Testo = Testo & "Puoi modificare la data, il cliente ed il dettaglio, il tipo di presenza (normale, sostituzione, assenza)." & vbCrLf
                Testo = Testo & "è possibile fare le modifiche fino a quando non viene confermata la riga premendo sul pulsante verde." & vbCrLf
                Testo = Testo & "Una volta confermato non è più modificabile. ne da voi ne da noi." & vbCrLf
                Testo = Testo & "" & vbCrLf
                Testo = Testo & "la Web application è disponibile da questo collegamento" & vbCrLf & vbCrLf
                Testo = Testo & "https://www.pulizieuffici.biz/PW" & vbCrLf & vbCrLf
                Testo = Testo & "Le tue credenziali di accesso sono:" & vbCrLf
                Testo = Testo & "Nome Utente: " & RGdip.user & vbCrLf
                Testo = Testo & "Password: " & RGdip.pwd & vbCrLf & vbCrLf
                Testo = Testo & "puoi utilizzare il pulsante Aiuto per spiegazioni"
                Testo = Testo & "BUONA GIORNATA"
                TBXwa.Text = Testo
            Case 2
                TBXwa.Text = "Ciao " & RGdip.nome & vbCrLf
        End Select



    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BTeliminarigacontore.Click
        Dim oldPos As Integer = BSREL_UtentiContore.Position
        Dim rg As DS_utenti.DT_contoreRow
        Dim rgID As Integer
        If BSREL_UtentiContore.Count > 0 Then
            rg = DirectCast(BSREL_UtentiContore.Current, DataRowView).Row
            rgID = rg.id
        Else
            MsgBox("nessuna presenza da eliminare")
            Return
        End If

        Dim risp As DialogResult = MessageBox.Show(rg.anagrafica & " elimino l'inserimento n:" & rg.id, "Elimina", MessageBoxButtons.YesNo)
        If risp = DialogResult.Yes Then
            TA_contore.elimina(rg.id)
            DG_contore.Rows.RemoveAt(DG_contore.CurrentRow.Index)
        End If
    End Sub

    Private Sub BTaggiornaContore_Click(sender As Object, e As EventArgs) Handles BTaggiornacontore.Click

        AggiornaInserimentoOre()
    End Sub

    Private Sub TX_RX_abbinamento_TextChanged(sender As Object, e As EventArgs) Handles TX_RX_abbinamento.TextChanged
        Dim TMPTX As TextBox
        Dim ricerca As String
        TMPTX = DirectCast(sender, TextBox)
        ricerca = TMPTX.Text
        Dim S_oldFiltro As String = ""
        Dim T_fil As String = If(IsNothing(S_oldFiltro), "", S_oldFiltro)
        RELAUDP.Filter = If(T_fil.Length > 0, T_fil & " AND ", "") & String.Format("societa LIKE '%{0}%'", ricerca)
        Dim NN As Integer = 0
        Do While RELAUDP.Count < 1
            NN += 1
            If ricerca.Length() > 0 Then
                ricerca = TMPTX.Text.Substring(0, If(TMPTX.Text.Length() - NN <= 0, 0, TMPTX.Text.Length() - NN))
                RELAUDP.Filter = If(T_fil.Length > 0, T_fil & " AND ", "") & String.Format("societa LIKE '%{0}%'", ricerca)
                TMPTX.Text = ricerca
                TMPTX.SelectionStart = TMPTX.Text.Length
                CambiaColore()
            Else
                Exit Do
            End If
        Loop
    End Sub

    Private Sub CKclientiabbinabili_CheckedChanged(sender As Object, e As EventArgs) Handles CKclientiabbinabili.CheckedChanged
        FiltroAbbinamentoClienti()
    End Sub
    Private Sub FiltroAbbinamentoClienti()
        CKclientiabbinabili.Text = IIf(CKclientiabbinabili.Checked, "Clienti Attivi", "Tutti i clienti")
        Dim S_oldFiltro As String = ""
        S_oldFiltro = IIf(CKclientiabbinabili.Checked = True, "attivo = 1", "")

        Dim T_fil As String = If(IsNothing(S_oldFiltro), "", S_oldFiltro)
        BS_clienti.Filter = If(T_fil.Length > 0, T_fil & " AND ", "") & String.Format("societa LIKE '%{0}%'", TX_RX_cliente.Text)
        'RELclientidestinatari.Filter = "attivo = 1"
    End Sub



    '
    'Crea, recuperando le timbrate WEB, una tabella riepilogativa Mensile
    Private Sub CreaTabellaPresenzeMensile()
        Dim k As DataTable = Nothing
        Dim pp As PresenzeWeb = New PresenzeWeb
        If Not IsDBNull(Me.DS_utenti.DT_presenzeWEB) Then
            k = pp.CreaTabellaPresenze(Me.DS_utenti.DT_presenzeWEB, PeriodoLocale)
        End If

        For Each l In k.Rows
            Console.WriteLine(l("anagrafica"))
        Next
    End Sub


    Private Sub PopolaLeggenda()
#Disable Warning BC42025 ' L'accesso del membro condiviso, del membro costante, del membro di enumerazione o del tipo nidificato verrà effettuato tramite un'istanza
        Dim cc As ColoriDettaglio = New ColoriDettaglio()
        DGWdettaglioleggenda.Rows.Clear()
        DGWdettaglioleggenda.Rows.Add({"", " - "})
        DGWdettaglioleggenda.Rows.Add({"", "note"})
        DGWdettaglioleggenda(0, 1).Style.BackColor = cc.NorNote
        DGWdettaglioleggenda.Rows.Add({"AA", "assente"})
        DGWdettaglioleggenda(0, 2).Style.BackColor = cc.NorAss
        DGWdettaglioleggenda.Rows.Add({"AN", "assente con note"})
        DGWdettaglioleggenda(0, 3).Style.BackColor = cc.NorNoteAss
        DGWdettaglioleggenda.Rows.Add({"", "trasferito"})
        DGWdettaglioleggenda(0, 4).Style.BackColor = cc.XTraPres
        DGWdettaglioleggenda.Rows.Add({"", "trasf. con note"})
        DGWdettaglioleggenda(0, 5).Style.BackColor = cc.XTrNote
        DGWdettaglioleggenda.Rows.Add({"AA", "trasf. assente"})
        DGWdettaglioleggenda(0, 6).Style.BackColor = cc.XTrAss
        DGWdettaglioleggenda.Rows.Add({"AN", "trasf. assente con note"})
        DGWdettaglioleggenda(0, 7).Style.BackColor = cc.XTrNoteAss
#Enable Warning BC42025 ' L'accesso del membro condiviso, del membro costante, del membro di enumerazione o del tipo nidificato verrà effettuato tramite un'istanza

    End Sub




    Private Sub btnGestioneferie_Click(sender As Object, e As EventArgs) Handles btnGestioneFerie.Click
        'ApreChiudetbLayoutPianoLavoro = ChiudeApreTablayout(tblOrePreviste.ColumnStyles, ApreChiudetbLayoutPianoLavoro)
        Dim fr As New frmDipendentiGestioneFerie
        fr.Show()
    End Sub
    Private Function ChiudeApreTablayout(stileTMP As TableLayoutColumnStyleCollection, ByVal OC As Boolean) As Boolean

        Dim xx As Int16 = 0
        For Each style As ColumnStyle In stileTMP
            xx += 1
            Select Case xx
                Case 1
                    If OC Then
                        style.SizeType = SizeType.Percent
                        style.Width = 80
                    Else
                        style.SizeType = SizeType.Absolute
                        style.Width = 1
                    End If
                Case 2
                    If OC Then
                        style.SizeType = SizeType.Percent
                        style.Width = 20
                    Else
                        style.SizeType = SizeType.Absolute
                        style.Width = 1
                    End If
                Case 3
                    If Not OC Then
                        style.SizeType = SizeType.Percent
                        style.Width = 90
                        'rpFoglioMese.RefreshReport()
                    Else
                        style.SizeType = SizeType.Absolute
                        style.Width = 1
                    End If
            End Select
        Next
        Return Not OC
    End Function

    Private Function CaricaPianodiLavoro(ByVal iddip As Integer) As Boolean

        Dim giorni As String() = {"lu_", "ma_", "me_", "gi_", "ve_", "sa_", "do_"}
        DG_orari.Rows.Clear()

        Using dt As New DS_utenti.DT_orariDataTable
            Using ta As New DS_utentiTableAdapters.TA_orari
                Select Case True
                    Case ckPianodiLavoro1.Checked
                        ta.FillBydipendente(dt, iddip)
                    Case ckPianodiLavoro2.Checked
                        ta.FillByidDipendente_ordDettaglioCliente(dt, iddip)
                End Select
            End Using
            If dt.Rows.Count = 0 Then
                Return (True)
            End If
            Dim oldIDCheck As Integer = dt(0).id_cli
            Dim UltimaSocieta As String = dt(0).societa
            Dim pT(7) As Decimal
            Dim gT(7) As Decimal

            For Each rg As DS_utenti.DT_orariRow In dt.Rows
                Dim newIDCheck As Integer = rg.id_cli

                If ckPianodiLavoro3.Checked Then
                    If oldIDCheck <> newIDCheck Then
                        creaRigaOrario(pT, Color.LightGreen, "TOTALE " & UltimaSocieta.Substring(0, If(UltimaSocieta.Length >= 15, 15, UltimaSocieta.Length)))
                        For i = 0 To pT.Count - 1
                            pT(i) = 0
                        Next
                        oldIDCheck = newIDCheck
                        UltimaSocieta = rg.societa
                    End If
                End If

                Dim R As New DataGridViewRow
                Dim T(7) As String
                Dim S(6) As String
                Dim x As Integer = 0
                Dim TT As Decimal = 0
                For Each day As String In giorni
                    Dim t01 As TimeSpan = TimeSpan.Parse(rg.Field(Of String)(day & "i"))
                    Dim t02 As TimeSpan = TimeSpan.Parse(rg.Field(Of String)(day & "u"))
                    T(x) = If(t02.TotalHours - t01.TotalHours = 0, "", (t02.TotalHours - t01.TotalHours).ToString("N2"))
                    S(x) = If(t02.TotalHours - t01.TotalHours = 0, "", TempoStringaCorta(t01) & " - " & TempoStringaCorta(t02))
                    TT += t02.TotalHours - t01.TotalHours
                    pT(x) += t02.TotalHours - t01.TotalHours
                    gT(x) += t02.TotalHours - t01.TotalHours
                    x += 1
                Next
                Dim valori As Object() = {rg.id, rg.id_des, rg.locazione, S(0), T(0).ToString, S(1), T(1).ToString, S(2), T(2).ToString, S(3), T(3).ToString, S(4), T(4).ToString, S(5), T(5).ToString, S(6), T(6).ToString, TT.ToString}
                R.CreateCells(DG_orari, valori)
                DG_orari.Rows.Add(R)
            Next
            If ckPianodiLavoro3.Checked Then
                creaRigaOrario(pT, Color.LightGreen, "TOTALE " & UltimaSocieta.Substring(0, If(UltimaSocieta.Length >= 15, 15, UltimaSocieta.Length)))
            End If
            For i = 0 To pT.Count - 1
                pT(i) = 0
            Next
            creaRigaOrario(gT, Color.LightCoral, "Totale GENERALE")

        End Using

        Return (True)
    End Function
    Private Sub creaRigaOrario(ByVal pT() As Decimal, ByVal C As Color, ByVal Titolo As String)
        Dim q As New DataGridViewRow
        Dim sT(7) As String
        For i = 0 To pT.Count - 2
            sT(i) = If(pT(i) = 0, "", pT(i).ToString("N2"))
        Next
        sT(7) = pT.Sum().ToString("N2")
        Dim totaliparziali As Object() = {0, 0, Titolo, "", sT(0), "", sT(1), "", sT(2), "", sT(3), "", sT(4), "", sT(5), "", sT(6), sT(7)}
        q.CreateCells(DG_orari, totaliparziali)
        q.DefaultCellStyle.BackColor = C
        DG_orari.Rows.Add(q)
    End Sub


    Private Sub BTNricalcolaferie_Click(sender As Object, e As EventArgs) Handles BTNricalcolaferie.Click
        AggiornamentoRighe()
    End Sub

    Private Sub lbPresenzeCliente_MouseMove(sender As Object, e As MouseEventArgs) Handles TBL_inserimentopresenzeweb.MouseMove
        If e.Button <> System.Windows.Forms.MouseButtons.Left Then
            Return
        End If

        Dim txTmp As Label
        txTmp = DirectCast(sender, Label)
        Select Case txTmp.Name
            Case lbPresenzeCliente.Name
                Dim tbl As TableLayoutPanel = TBL_inserimentopresenzeweb
                Dim beam0 As Integer = tbl.RowStyles(0).Height + tbl.RowStyles(1).Height + tbl.RowStyles(2).Height
                If beam0 - e.Y > 0 And beam0 + e.Y < tbl.Height Then
                    tbl.RowStyles(2).Height = tbl.RowStyles(2).Height + e.Y
                End If
            Case LBesitofiltro.Name
                Dim tbl As TableLayoutPanel = TBL_inserimentopresenzeweb
                Dim altezza As Integer = tbl.RowStyles(4).Height
                tbl.RowStyles(4).SizeType = SizeType.Absolute
                tbl.RowStyles(4).Height = altezza
                Dim beam0 As Integer = tbl.RowStyles(0).Height + tbl.RowStyles(1).Height + tbl.RowStyles(2).Height + tbl.RowStyles(3).Height + tbl.RowStyles(4).Height + tbl.RowStyles(5).Height + tbl.RowStyles(6).Height
                If beam0 + e.Y > 0 And beam0 - e.Y < tbl.Height Then
                    tbl.RowStyles(6).Height = IIf(tbl.RowStyles(6).Height - e.Y > 0, tbl.RowStyles(6).Height - e.Y, tbl.RowStyles(6).Height)
                End If
                tbl.RowStyles(4).SizeType = SizeType.Percent
                tbl.RowStyles(4).Height = 100%
            Case LB_PianoMensile.Name
                Dim tbl As TableLayoutPanel = tblMonteOre
                Dim beam0 As Integer = tbl.RowStyles(0).Height + tbl.RowStyles(1).Height + tbl.RowStyles(2).Height
                If beam0 - e.Y > 0 And beam0 + e.Y < tbl.Height Then
                    tbl.RowStyles(2).Height = tbl.RowStyles(2).Height + e.Y
                End If
        End Select
    End Sub
    Private Sub lbPresenzecursorToDefault(sender As Object, e As EventArgs) Handles LB_PianoMensile.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub lblPresenzecursorePremuto(sender As Object, e As EventArgs) Handles LB_PianoMensile.MouseHover
        Me.Cursor = Cursors.HSplit
    End Sub

    Private Sub ckPianodiLavoro_CheckedChanged(sender As Object, e As EventArgs) Handles ckPianodiLavoro1.CheckedChanged, ckPianodiLavoro2.CheckedChanged
        Dim tmpCK As CheckBox = DirectCast(sender, CheckBox)
        Select Case tmpCK.Name
            Case ckPianodiLavoro2.Name
                ckPianodiLavoro1.Checked = Not ckPianodiLavoro2.Checked
            Case ckPianodiLavoro1.Name
                ckPianodiLavoro2.Checked = Not ckPianodiLavoro1.Checked
        End Select
        If BS_utenti.Count > 0 Then
            Dim iddip As Integer = DirectCast(BS_utenti.Current, DataRowView).Row.Field(Of Integer)("id")
            CaricaPianodiLavoro(iddip)
        End If

    End Sub

    Private Sub ckPianodiLavoro3_CheckedChanged(sender As Object, e As EventArgs) Handles ckPianodiLavoro3.CheckedChanged
        If BS_utenti.Count > 0 Then
            Dim iddip As Integer = DirectCast(BS_utenti.Current, DataRowView).Row.Field(Of Integer)("id")
            CaricaPianodiLavoro(iddip)
        End If
    End Sub

    Private Sub btnMassimizzaleGriglie_Click(sender As Object, e As EventArgs) Handles btnMassimizzaleGriglie.Click
        Select Case btnMassimizzaleGriglie.Tag
            Case 0
                btnMassimizzaleGriglie.Text = "max Cliente"
                btnMassimizzaleGriglie.Tag = 1
                Dim tbl As TableLayoutPanel = TBL_inserimentopresenzeweb
                Dim valoriAltezze() As Integer = {23, 23, 400, 23, 250, 23, 50}
                Dim xx As Integer = 0
                For Each tblrow As RowStyle In tbl.RowStyles
                    tblrow.SizeType = SizeType.Absolute
                    tblrow.Height = valoriAltezze(xx)
                    xx += 1
                    tblrow.SizeType = SizeType.Absolute
                Next
            Case 1
                btnMassimizzaleGriglie.Text = "max Elenco"
                btnMassimizzaleGriglie.Tag = 2
                Dim tbl As TableLayoutPanel = TBL_inserimentopresenzeweb
                Dim valoriAltezze() As Integer = {23, 23, 10, 23, 450, 23, 50}
                Dim xx As Integer = 0
                For Each tblrow As RowStyle In tbl.RowStyles
                    tblrow.SizeType = SizeType.Absolute
                    tblrow.Height = valoriAltezze(xx)
                    xx += 1
                    tblrow.SizeType = SizeType.Absolute
                Next

            Case 2
                btnMassimizzaleGriglie.Text = "max Dipendente"
                btnMassimizzaleGriglie.Tag = 0
                Dim tbl As TableLayoutPanel = TBL_inserimentopresenzeweb
                Dim valoriAltezze() As Integer = {23, 23, 10, 23, 10, 23, 450}
                Dim xx As Integer = 0
                For Each tblrow As RowStyle In tbl.RowStyles
                    tblrow.SizeType = SizeType.Absolute
                    tblrow.Height = valoriAltezze(xx)
                    xx += 1
                    tblrow.SizeType = SizeType.Absolute
                Next

        End Select
    End Sub

    Private Sub btnRipristinaGriglie_Click(sender As Object, e As EventArgs) Handles btnRipristinaGriglie.Click
        Dim tbl As TableLayoutPanel = TBL_inserimentopresenzeweb
        Dim valoriAltezze() As Integer = {23, 23, 300, 23, 200, 23, 100}
        Dim xx As Integer = 0
        For Each tblrow As RowStyle In tbl.RowStyles
            tblrow.SizeType = SizeType.Absolute
            tblrow.Height = valoriAltezze(xx)
            xx += 1
        Next
        btnMassimizzaleGriglie.Text = "max Dipendente"
        btnMassimizzaleGriglie.Tag = 0
    End Sub
    '-----------------------------------------------------------------------------------------
    '-
    '-
    '-

    Private Function CaricaPianodiLavoroperCliente(ByVal idDet As Integer) As Boolean

        Dim giorni As String() = {"lu_", "ma_", "me_", "gi_", "ve_", "sa_", "do_"}
        dgPianodiLavoroperCliente.Rows.Clear()

        Using dt As New DS_utenti.DT_orariDataTable
            Using ta As New DS_utentiTableAdapters.TA_orari
                ta.FillByDestinatari(dt, idDet)
            End Using
            If dt.Rows.Count = 0 Then
                Return (True)
            End If
            Dim oldIDCheck As Integer = dt(0).id_dip
            Dim UltimaSocieta As String = dt(0).anagrafica
            Dim pT(7) As Decimal
            Dim gT(7) As Decimal

            For Each rg As DS_utenti.DT_orariRow In dt.Rows
                Dim newIDCheck As Integer = rg.id_dip
                If ckPianodiLavoro3.Checked Then
                    If oldIDCheck <> newIDCheck Then
                        creaRigaTotaleOrario(dgPianodiLavoroperCliente, pT, Color.LightGreen, "TOTALE " & UltimaSocieta.Substring(0, If(UltimaSocieta.Length >= 15, 15, UltimaSocieta.Length)))
                        For i = 0 To pT.Count - 1
                            pT(i) = 0
                        Next
                        oldIDCheck = newIDCheck
                        UltimaSocieta = rg.societa
                    End If
                End If

                Dim R As New DataGridViewRow
                Dim T(7) As String
                Dim S(6) As String
                Dim x As Integer = 0
                Dim TT As Decimal = 0
                For Each day As String In giorni
                    Dim t01 As TimeSpan = TimeSpan.Parse(rg.Field(Of String)(day & "i"))
                    Dim t02 As TimeSpan = TimeSpan.Parse(rg.Field(Of String)(day & "u"))
                    T(x) = If(t02.TotalHours - t01.TotalHours = 0, "", (t02.TotalHours - t01.TotalHours).ToString("N2"))
                    S(x) = If(t02.TotalHours - t01.TotalHours = 0, "", TempoStringaCorta(t01) & " - " & TempoStringaCorta(t02))
                    TT += t02.TotalHours - t01.TotalHours
                    pT(x) += t02.TotalHours - t01.TotalHours
                    gT(x) += t02.TotalHours - t01.TotalHours
                    x += 1
                Next
                Dim valori As Object() = {rg.id, rg.id_dip, rg.anagrafica, S(0), T(0).ToString, S(1), T(1).ToString, S(2), T(2).ToString, S(3), T(3).ToString, S(4), T(4).ToString, S(5), T(5).ToString, S(6), T(6).ToString, TT.ToString}
                R.CreateCells(dgPianodiLavoroperCliente, valori)
                dgPianodiLavoroperCliente.Rows.Add(R)
            Next
            If ckPianodiLavoro3.Checked Then
                creaRigaTotaleOrario(dgPianodiLavoroperCliente, pT, Color.LightGreen, "TOTALE " & UltimaSocieta.Substring(0, If(UltimaSocieta.Length >= 15, 15, UltimaSocieta.Length)))
            End If
            For i = 0 To pT.Count - 1
                pT(i) = 0
            Next
            creaRigaTotaleOrario(dgPianodiLavoroperCliente, gT, Color.LightCoral, "Totale GENERALE")

        End Using

        Return (True)
    End Function
    Private Sub creaRigaTotaleOrario(ByRef dg As DataGridView, ByVal pT() As Decimal, ByVal C As Color, ByVal Titolo As String)
        Dim q As New DataGridViewRow
        Dim sT(7) As String
        For i = 0 To pT.Count - 2
            sT(i) = If(pT(i) = 0, "", pT(i).ToString("N2"))
        Next
        sT(7) = pT.Sum().ToString("N2")
        Dim totaliparziali As Object() = {0, 0, Titolo, "", sT(0), "", sT(1), "", sT(2), "", sT(3), "", sT(4), "", sT(5), "", sT(6), sT(7)}
        q.CreateCells(dg, totaliparziali)
        q.DefaultCellStyle.BackColor = C
        dg.Rows.Add(q)
    End Sub
    Private Sub dgPianodiLavoroperClienteMouseDown(sender As Object, e As MouseEventArgs) Handles dgPianodiLavoroperCliente.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cmsElilminaPianodiLavoro.Show(New Point(MousePosition.X, MousePosition.Y))
        End If
    End Sub
    Private Sub visualizzaMenuEliminarigaPianodiLavoro(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles cmsElilminaPianodiLavoro.ItemClicked
        cmsElilminaPianodiLavoro.Hide()
        If dgPianodiLavoroperCliente.RowCount > 0 Then
            Dim str As String = e.ClickedItem.Name
            Dim id As Integer = dgPianodiLavoroperCliente(DGWCidOrarioperCliente.Index, dgPianodiLavoroperCliente.CurrentRow.Index).Value
            Dim nome As String = dgPianodiLavoroperCliente(DGWCanagraficaPiano.Index, dgPianodiLavoroperCliente.CurrentRow.Index).Value
            Dim idDip As Integer = dgPianodiLavoroperCliente(DGWCiddipPianodiLavoro.Index, dgPianodiLavoroperCliente.CurrentRow.Index).Value
            Dim idDet As Integer

            If str = cmsEliminarigaPianodiLavoro.Name Then
                Dim risp As MsgBoxResult = MsgBox("Sei sicuro di voler eliminare il piano di lavoro di: " + nome + " definitivamente ?", MsgBoxStyle.YesNo)
                If risp = MsgBoxResult.Yes Then
                    Dim rmsg As Integer = TA_orari.QR_elimina(id)
                    If rmsg > 0 Then
                        idDet = DG_orari(DGWCiddes.Index, DG_orari.CurrentRow.Index).Value
                        CaricaPianodiLavoroperCliente(idDet)
                    End If
                End If
            ElseIf str = cmsAssegnarigaPianodiLavoro.Name Then
                Dim dt As DataTable = New DS_utenti.DT_orariDataTable
                Using ta As New DS_utentiTableAdapters.TA_orari
                    ta.FillBydipendente(dt, idDip)
                    Dim f As New frmDipendentePianodiLavoro(id, dt)
                    f.ShowDialog()
                    idDet = DG_orari(DGWCiddes.Index, DG_orari.CurrentRow.Index).Value
                    CaricaPianodiLavoroperCliente(idDet)
                End Using
            ElseIf str = cmsVaiAlDipendente.Name Then
                TTTestoRicerca.Text = ""
                Dim oldid As Integer = BS_utenti.Position
                BS_utenti.Position = BS_utenti.Find("id", idDip)
                If BS_utenti.Position > 0 Then
                    AggiornamentoRighe()
                Else
                    BS_utenti.Position = oldid
                    MsgBox("Non sono riuscito a reindirizzarti al dipendente")
                End If

            End If
        End If
    End Sub

    Private Sub tabpianodilavoro_Click(sender As Object, e As EventArgs) Handles tabPianodiLavoro.SelectedIndexChanged
        AggiornaTabPianodiLavoro()
    End Sub
    Private Sub AggiornaTabPianodiLavoro()
        Dim frase As String = "Sviluppo ore mensili"
        Select Case tabPianodiLavoro.SelectedTab.Name
            Case tbDettaglioClienti.Name
                If DG_orari.Rows.Count <= 0 Then
                    frase = DirectCast(BS_utenti.Current, DataRowView).Row.Field(Of String)("anagrafica") & "non lavora con nessuno "
                    dgPianodiLavoroperCliente.Rows.Clear()
                Else
                    frase = "Con chi lavora " & DirectCast(BS_utenti.Current, DataRowView).Row.Field(Of String)("anagrafica") & " in " & DG_orari(DGWCanagraficaPiano.Index, DG_orari.CurrentRow.Index).Value
                    Dim idDet As Integer
                    idDet = DG_orari(DGWCiddes.Index, DG_orari.CurrentRow.Index).Value
                    CaricaPianodiLavoroperCliente(idDet)
                End If
            Case tbSviluppoOrario.Name
                frase = "Ore previste nel mese di " & TT_CB_mese.SelectedItem & " Anno " & TT_CB_anno.SelectedItem & " per " & DirectCast(BS_utenti.Current, DataRowView).Row.Field(Of String)("anagrafica")
        End Select
        LB_PianoMensile.Text = frase

    End Sub
    '
    '
    ' Carica i documenti formativi
    '
    '
    Private Sub btCaricaDocumentoFormazione_Click(sender As Object, e As EventArgs) Handles btCaricaDocumentoFormazione.Click

        Dim CartellaDestinazione As String
        Dim Testonome As String
        Dim TestoAlias As String
        Dim TestoDesc As String
        Dim TestoEstensione As String
        Dim TestoSize As String
        Dim TestoData As DateTime
        '
        'Array con l'elenco dei documenti da caricare
        '
        Dim TestoPaths As String()
        Dim nomeDirectory As String
        Dim RGloc As DS_utenti.DT_utentiRow
        RGloc = DirectCast(BS_utenti.Current, DataRowView).Row
        '' Recupera ID dipendente
        'bsfile.CancelEdit()

        ' Verificare come mai non è gestito bene l'aggiunta, difficoltà a trovare il nome della cartella se uso aggiungi da datagridrow

        If bsfile.Count > 0 Then
            Dim RGdoc As DSwebcondiviso.DTfileRow
            RGdoc = DirectCast(bsfile.Current, DataRowView).Row
            nomeDirectory = RGdoc.cartella
            CartellaDestinazione = G_DirectoriDipendenti & RGdoc.cartella
        Else
            nomeDirectory = RGloc.cognome.Replace("'", "").Replace(" ", "_") & RGloc.nome.Replace("'", "_").Replace(" ", "_")
            Dim DirectoryInfo As DirectoryInfo
            CartellaDestinazione = G_DirectoriDipendenti & nomeDirectory
            DirectoryInfo = New DirectoryInfo(CartellaDestinazione)
            Dim CheckDirectory As Boolean = DirectoryInfo.Exists()
            If Not CheckDirectory Then
                If MsgBox("Non trovo la cartella di destinazione, la creo nuova ", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                    'TODO Creare la Cartella se non la trova
                    Exit Sub
                End If
            End If
        End If


        Dim DestinazioneDocumento As String
        Dim Info As FileInfo
        OpenFileDialog1.Multiselect = True
        'OpenFileDialog1.Filter '= "documenti (" & RGloc.cognome & ".*)|*" & RGloc.cognome & "*.*"
        OpenFileDialog1.FileName = ""
        If Not OpenFileDialog1.ShowDialog() > 0 Then
            MsgBox("Nessun Documento selezionato")
            Return
        End If

        TestoPaths = OpenFileDialog1.FileNames 'Seleziona i documenti da caricare
        For Each TestoPath As String In TestoPaths
            'Genera il nome della directory dove salvare i documenti

            Testonome = TestoPath.Split("\").Last
            DestinazioneDocumento = CartellaDestinazione & "\" & Testonome
            If TestoPath.Length < 1 Then
                Continue For
            End If
            Info = New FileInfo(TestoPath)
            If Not Info.Exists Then
                Continue For
            End If
            TestoAlias = Testonome.Replace(" ", "_")
            TestoData = Info.CreationTime
            'indica la descrizione nel database
            TestoDesc = String.Format("{0} di {1}", Testonome.Replace("-", " "), RGloc.cognome.Replace("'", "") & " " & RGloc.nome.Replace("'", " "))
            TestoEstensione = Info.Extension
            TestoSize = ControllaeFormattaNumeri(Info.Length / 1000) & " KB"
            Try
                If ckCopiaDocumentiFormazione.CheckState = 0 Then
                    My.Computer.FileSystem.MoveFile(TestoPath, DestinazioneDocumento, True)
                Else
                    My.Computer.FileSystem.CopyFile(TestoPath, DestinazioneDocumento, True)
                End If
                impostaPermessiFile(DestinazioneDocumento, "http")
            Catch ex As Exception
                MsgBox("Problemi a registrare il documento " & DestinazioneDocumento)
                Return
            End Try

            Dim ultimo As Integer = TAfile.SQultimoordine(RGloc.id, 1) + 1
            TAfile.inserisce(RGloc.id, Testonome, TestoDesc, TestoSize, Testonome, 0, "", 0, 11, RGloc.id, ultimo, 1, TestoData, TestoData, nomeDirectory, 3, 0)
            TAfile.FillByUtenteTipo(DSwebcondiviso.DTfile, RGloc.id, 3)
        Next


    End Sub

    Private Sub btEliminaDocumentoFormazione_Click(sender As Object, e As EventArgs) Handles btEliminaDocumentoFormazione.Click

        Dim RGloc As DS_utenti.DT_utentiRow
        RGloc = DirectCast(BS_utenti.Current, DataRowView).Row
        Dim RGdoc As DSwebcondiviso.DTfileRow
        RGdoc = DirectCast(bsfile.Current, DataRowView).Row
        If MsgBox("Vuoi eliminare il collegamento al Documento ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim risposta As MsgBoxResult = MsgBox("Vuoi eliminare anche il FILE ? **IRREVERSIBILE** " &
                  Chr(13) & RGdoc.title, MsgBoxStyle.YesNoCancel)
            If risposta = MsgBoxResult.Yes Then
                Dim NomeFile As String = RGdoc.title
                Dim folderPath As String = G_DirectoriDipendenti & RGdoc.cartella
                Dim FileDaEliminare As String
                FileDaEliminare = folderPath & "\" & NomeFile
                If My.Computer.FileSystem.FileExists(FileDaEliminare) = True Then
                    My.Computer.FileSystem.DeleteFile(FileDaEliminare)
                Else
                    MsgBox("non ho trovato corrispondenza nella cartella dei documenti")
                End If
                TAfile.elimina(RGdoc.id)
            ElseIf risposta = MsgBoxResult.No Then
                TAfile.elimina(RGdoc.id)
            End If
            TAfile.FillByUtenteTipo(DSwebcondiviso.DTfile, RGloc.id, 3)
        End If

    End Sub
    Private Sub dgwFerieDipendente_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgwFerieDipendente.DataError
        e.Cancel = False

    End Sub

    Private Sub dgwFormazioneDipendente_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwFormazioneDipendente.RowValidating
        Dim bs As BindingSource = bsfile
        Dim ta As DSwebcondivisoTableAdapters.TAfile
        ta = TAfile
        Dim rgRighe As DSwebcondiviso.DTfileRow
        If bs.Count <= 0 Then
            Return
        End If
        bs.EndEdit()
        rgRighe = DirectCast(bs.Current, DataRowView).Row
        Select Case rgRighe.RowState
            Case DataRowState.Modified
                ta.UpdateQuery(rgRighe.title, rgRighe.description, rgRighe.notes, rgRighe.data_creazione, rgRighe.id_cat, rgRighe.superata, rgRighe.id)
                rgRighe.AcceptChanges()
        End Select
    End Sub
    Private Sub dgwFormazioneDipendente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwFormazioneDipendente.CellClick

        Dim senderGrid As DataGridView
        senderGrid = DirectCast(sender, DataGridView)
        Dim Cella As DataGridViewCell = senderGrid(e.ColumnIndex, e.RowIndex)
        Dim RigaTabella As DataGridViewRow
        RigaTabella = senderGrid.Rows(e.RowIndex)
        Select Case True
            Case TypeOf Cella Is DataGridViewLinkCell
                If Not VisualizzaDocumenti(RigaTabella, dgwcDirectoryFormazione, dgwcNomeFile) Then
                    MsgBox("Attenzione Documento non disponibile", MsgBoxStyle.OkOnly)
                End If
        End Select
    End Sub

    Private Sub ckCopiaDocumentiFormazione_CheckedChanged(sender As Object, e As EventArgs) Handles ckCopiaDocumentiFormazione.CheckedChanged
        Dim stato() As String = {"Sposta", "Copia"}
        ckCopiaDocumentiFormazione.Text = stato(If(ckCopiaDocumentiFormazione.Checked, 1, 0))
    End Sub
    Private Sub dgwFormazioneDipendente_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwFormazioneDipendente.CellFormatting

        ' Replace string values in the Priority column with images.
        If dgwFormazioneDipendente.Columns(e.ColumnIndex).Name.Equals(dgwcDataFormazione.Name) Then

            ' Ensure that the value is a string.
            Dim tt As DateTime
            tt = DateTime.Parse(e.Value)
            Dim dataValore As String = TryCast(tt.ToShortDateString, String)
            If dataValore Is Nothing Then Return

            ' Set the cell ToolTip to the text value.
            Dim cell As DataGridViewCell = dgwFormazioneDipendente(e.ColumnIndex, e.RowIndex)
            Dim Tipo As DataGridViewCell = dgwFormazioneDipendente(dgwcTipoFormazione.Index, e.RowIndex)
            Dim superata As DataGridViewCell = dgwFormazioneDipendente(dgwcSuperataFormazione.Index, e.RowIndex)
            bsTipoFormazione.Filter = String.Format("id = {0}", Tipo.Value)
            Dim valoreScadenza As Integer = DirectCast(bsTipoFormazione.Current, DataRowView).Row.Field(Of Int32)("scadenza")


            cell.ToolTipText = dataValore
            ' Replace the string value with the image value.
            Dim ddata As DateTime = DateTime.Parse(dataValore)

            Dim nuovaData As DateTime = ddata.AddYears(valoreScadenza)

            Select Case nuovaData.Year
                Case >= Now().Year
                    e.CellStyle.BackColor = Color.LightGreen
                    e.CellStyle.SelectionBackColor = Color.LightGreen
                Case < Now().Year And valoreScadenza > 0 And superata.Value < 1
                    e.CellStyle.BackColor = Color.Red
                    e.CellStyle.SelectionBackColor = Color.Red
                Case < Now().Year And valoreScadenza > 0 And superata.Value = 1
                    e.CellStyle.BackColor = Color.LightGray
                    e.CellStyle.SelectionBackColor = Color.LightGray
                Case Else
                    e.CellStyle.BackColor = Color.LightGreen
                    e.CellStyle.SelectionBackColor = Color.LightGreen
            End Select

        End If
        bsTipoFormazione.RemoveFilter()
    End Sub

    Private Sub DgwSviluppoOreMese_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwSviluppoOreMese.CellDoubleClick
        Dim oldStileCella As New DataGridViewCellStyle
        Dim cella As DataGridViewCell
        cella = sender(e.ColumnIndex, e.RowIndex)

        Dim oTag As String
        oTag = cella.Tag
        If oTag = Nothing Then
            Return
        End If
        Dim iddip As Int16 = DirectCast(BS_utenti.Current, DataRowView).Row.Item("id")
        Dim str0 As DateTime = DateTime.Parse(oTag.Split("|").Skip(1).First)
        Dim sData As String = str0.ToShortDateString
        Dim dData As Date = Date.Parse(sData)
        'Dim f As New FRMgestSos(oTag, Me.DS_utenti.DT_utenti, Me.DS_utenti.DT_destinatari)
        Dim bssos As BindingSource = New BindingSource
        Using dt As New DS_ag.DTsostituzioniDataTable
            Using ta As New DS_agTableAdapters.TAsostituzioni
                ta.FillByDaA(dt, dData, dData)
                bssos.DataMember = "utenti_sostituzioni"
                bssos.DataSource = dt
            End Using
        End Using
        Dim f As New FrmAgendaModifica(bssos, oTag, Nothing, Nothing, Me.DS_utenti.DT_utenti, Me.DS_utenti.DT_clienti, Me.DS_utenti.DT_destinatari)

        f.ShowDialog()

        'se c'è stata una modifica allora aggiorna i dati.
        If f.Fsostituito Then
            AggiornamentoRighe()
        End If

    End Sub
    Function CaricaDatabase()
        Dim id As Int16
        If BS_utenti.Count > 0 Then
            Dim rg As DS_utenti.DT_utentiRow
            rg = DirectCast(BS_utenti.Current, DataRowView).Row
            id = rg.id
        End If

        Me.TA_utenti.Fill(DS_utenti.DT_utenti, GlobalVarPOP.G_idAZ)
        Me.TA_utentiFoto.Fill(Me.DS_utenti.DT_utentiFoto)
        Me.TA_utentiformazione.Fill(Me.DS_utenti.DT_utentiformazione)
        Me.TA_formazione.Fill(Me.DS_utenti.DT_formazione)
        Me.TA_tipologia.mostra(Me.DS_utenti.DT_tipologia)
        Me.TA_clienti.Fill(Me.DS_utenti.DT_clienti)
        Me.TA_destinatari.FillByAttivi(Me.DS_utenti.DT_destinatari, 1)
        Me.TA_cal.FillByPeriodo(Me.DS_utenti.DT_cal, PeriodoLocale)
        Me.TA_AUDP.Fill(Me.DS_utenti.DT_AUDP)
        Me.TA_lettere.FillByTipo(Me.DS_utenti.DT_lettere, 1)
        If id <> 0 Then
            BS_utenti.Position = BS_utenti.Find("id", id)
        End If
        Return True
    End Function
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles TSBTricaricadati.Click
        CaricaDatabase()
    End Sub
    Private Sub tbGestionePresenze_selectIndex(sender As Object, e As EventArgs) Handles tabControlloTimbrature.SelectedIndexChanged
        Dim tabTMP As TabControl
        tabTMP = DirectCast(sender, TabControl)
        Dim id As Int32
        id = DirectCast(BS_utenti.Current, DataRowView).Row.Field(Of Int32)("id")
        Dim kDat As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0)
        Using TA As New DS_utentiTableAdapters.TA_cal
            Using DT As New DS_utenti.DT_calDataTable
                TA.FillByPeriodo(DT, PeriodoLocale)
                BS_Cal.DataSource = DT
            End Using
        End Using
        Select Case tabTMP.SelectedTab.Name
            Case tbPreviste.Name
                Dim rit As Boolean = GeneraPianodiLavoroDipendente.CaricaIntestazioniPresenzePreviste(dgwOreinagenda, kDat.Day + 1, BS_Cal)
                Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
                Using ta As New DSfestivitaTableAdapters.TAtipoorario
                    ta.Fill(dtTipoOrario)
                End Using
                dtUT = GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioDipendente(dgwOreinagenda, dtUT, BS_utenti, PeriodoLocale, dtTipoOrario, False, BS_Cal, False)
            Case tbTimbrate.Name
                TA_presenzeWEB.FillByutenteperiodo(Me.DS_utenti.DT_presenzeWEB, PeriodoLocale, id)
                If BSPresenzeWEB.Count > 0 Then

                    Dim testo(2) As String
                    testo = ElaboraPresenze.CreaGriglieTimbratureRemote(kDat, BSPresenzeWEB, DG_totaleoreweb, DG_totaleOreWebCliente, BS_tipologia, BScal)
                    LBtotaleDipendenteWeb.Text = testo(0)
                    lbPresenzeCliente.Text = testo(1)
                    LBesitofiltro.Text = testo(2)
                Else
                    LBtotaleDipendenteWeb.Text = "0"
                End If
            Case tbConfrontoPresenze.Name

                TA_presenzeWEB.FillByutenteperiodo(Me.DS_utenti.DT_presenzeWEB, PeriodoLocale, id)
                If BSPresenzeWEB.Count > 0 Then
                    Dim testo(2) As String
                    testo = ElaboraPresenze.CreaGriglieTimbratureRemote(kDat, BSPresenzeWEB, dgwConfrontoPresenze, DG_totaleOreWebCliente, BS_tipologia, BScal, False)
                    LBtotaleDipendenteWeb.Text = testo(0)
                    lbPresenzeCliente.Text = testo(1)
                    LBesitofiltro.Text = testo(2)
                Else
                    LBtotaleDipendenteWeb.Text = "0"
                End If
                Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
                Using ta As New DSfestivitaTableAdapters.TAtipoorario
                    ta.Fill(dtTipoOrario)
                End Using
                dtUT = GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioDipendente(dgwConfrontoPresenze, dtUT, BS_utenti, PeriodoLocale, dtTipoOrario, False, BS_Cal, False)

        End Select
    End Sub




    Private Sub dgwOreinagenda_CellContentClick(sender As Object, e As MouseEventArgs) Handles dgwOreinagenda.MouseClick

        Dim oldStileCella As New DataGridViewCellStyle
        Dim cella As DataGridViewCell
        Dim dgw As DataGridView = DirectCast(sender, DataGridView)

        cella = dgw.CurrentCell

        Dim oTag As String
        oTag = cella.Tag
        If oTag = Nothing Then
            Return
        End If
        Dim iddip As Int16 = DirectCast(BS_utenti.Current, DataRowView).Row.Item("id")

        Dim str0 As DateTime = DateTime.Parse(oTag.Split("|").Skip(1).First)
        Dim sData As String = str0.ToShortDateString
        Dim dData As Date = Date.Parse(sData)
        'Dim f As New FRMgestSos(oTag, Me.DS_utenti.DT_utenti, Me.DS_utenti.DT_destinatari)
        Dim bssos As BindingSource = New BindingSource
        Using dt As New DS_ag.DTsostituzioniDataTable
            Using ta As New DS_agTableAdapters.TAsostituzioni
                ta.FillByDaA(dt, dData, dData)
                bssos.DataMember = "utenti_sostituzioni"
                bssos.DataSource = dt
            End Using
        End Using
        Dim f As New FrmAgendaModifica(bssos, oTag, Nothing, Nothing, Me.DS_utenti.DT_utenti, Me.DS_utenti.DT_clienti, Me.DS_utenti.DT_destinatari)

        f.ShowDialog()

        'se c'è stata una modifica allora aggiorna i dati.
        If f.Fsostituito Then
            AggiornamentoRighe()
        End If

    End Sub
    Private Function creaGruppoWebCategorie()
        Dim rrll As DS_utenti.DT_utentiRow
        rrll = DirectCast(BS_utenti.Current, DataRowView).Row
        Dim dt As New DSwebcondiviso.dtWebMenuCategorieDataTable
        Using ta As New DSwebcondivisoTableAdapters.taWebMenuCategorie
            ta.Fill(dt)
        End Using

        If IsNothing(grpWebButton.Controls("optBTN_1")) Then
            Dim valorealtezza As Int16
            For Each pul As DSwebcondiviso.dtWebMenuCategorieRow In dt.Rows
                Dim optBt As New CheckBox
                optBt.Appearance = Appearance.Button
                optBt.Name = "optBTN_" & pul.id.ToString
                optBt.Text = pul.nome
                optBt.Tag = pul.id
                optBt.Top = 10 + valorealtezza
                optBt.Height = 20
                valorealtezza += 21
                optBt.Left = 5
                optBt.Width = 150
                If rrll.id_terminale >= pul.livello Then
                    optBt.Checked = True
                End If
                grpWebButton.Controls.Add(optBt)
                AddHandler optBt.Click, AddressOf filtramenu
            Next
        Else
            For Each pul As DSwebcondiviso.dtWebMenuCategorieRow In dt.Rows
                For Each bb As CheckBox In grpWebButton.Controls
                    If rrll.id_terminale >= pul.livello Then
                        If bb.Tag = pul.id Then
                            bb.Checked = True
                        End If
                    Else
                        If bb.Tag = pul.id Then
                            bb.Checked = False
                        End If
                    End If
                Next
            Next
        End If
        Return True

    End Function
    Private Sub filtramenu(ByVal sender As Object, e As EventArgs)
        Dim btn = DirectCast(sender, CheckBox)
        bsWebMenu.Filter = "categoria = " & btn.Tag
        btnWebMenuCategoria.Text = "<=Carica="

    End Sub



    Private Function GeneraWebMenu(ByVal idC As Int16)
        If BS_utenti.Count = 0 Then
            Return True
        End If
        Dim utente As String
        Dim rg As DS_utenti.DT_utentiRow
        rg = DirectCast(BS_utenti.Current, DataRowView).Row
        utente = rg.cognome + " " + rg.nome
        Dim idCat As Int16
        If idC = Nothing Then
            Return True
        Else
            idCat = idC
        End If
        '        If MsgBox("Abbino a " + utente + vbCrLf + "la categoria " + "" + " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        bsWebMenu.Filter = "categoria = " & idCat
        If bsWebMenu.Count > 0 Then
            Dim rgM As DSwebcondiviso.dtWebMenuRow
            For Each rgMtmp In bsWebMenu
                rgM = DirectCast(rgMtmp, DataRowView).Row
                Dim esiste As Boolean
                If bsWebMenuAutorizzazioni.Count > 0 Then
                    For Each rgMA In bsWebMenuAutorizzazioni
                        If rgMA("id_menu") = rgM.id.ToString Then
                            esiste = True
                            Exit For
                        Else
                            Console.WriteLine(rgM.id.ToString & "-" & rg.id.ToString())
                            'TaWebMenuAutorizzazioni.Inserisci(rgM.id, rg.id, rg.livello, If(rgM.IssqlNull, Nothing, rgM.sql))
                        End If
                    Next
                End If
                If Not esiste Then
                    TaWebMenuAutorizzazioni.Inserisci(rgM.id, rg.id, rg.livello, If(rgM.IssqlNull, Nothing, rgM.sql))
                End If
            Next
            ApreDBAutorizzazioni(rg.id)
            '            End If
        End If
        bsWebMenu.RemoveFilter()
        Return True
    End Function
    Private Function ApreDBAutorizzazioni(ByVal iddip As Int16)
        TaWebMenuAutorizzazioni.Fill(Me.DSwebcondiviso.dtWebMenuAutorizzazioni)
        Dim filtrate = From v In Me.DSwebcondiviso.dtWebMenuAutorizzazioni Where v.id_dip = iddip


        Using dt As New DSwebcondiviso.dtWebMenuAutorizzazioniDataTable
            For Each rg In filtrate
                Dim rgM As DSwebcondiviso.dtWebMenuAutorizzazioniRow = dt.NewRow()
                rgM.id = rg("id")
                rgM.categoria = rg("categoria")
                rgM.id_dip = rg("id_dip")
                rgM.id_menu = rg("id_menu")
                rgM.livello = rg("livello")
                rgM.menu = rg("menu")
                rgM.sql = If(IsDBNull(rg("sql")), Nothing, rg("sql"))
                dt.Rows.Add(rgM)
                rgM.AcceptChanges()
            Next
            Me.DSwebcondiviso.dtWebMenuAutorizzazioni.Rows.Clear()
            dt.CopyToDataTable(Me.DSwebcondiviso.dtWebMenuAutorizzazioni, LoadOption.OverwriteChanges)
        End Using
        Me.DSwebcondiviso.dtWebMenuAutorizzazioni.AcceptChanges()
        Return True
    End Function

    Private Sub dgWebMenuAutorizzazioni_UserDeletedRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgWebMenuAutorizzazioni.UserDeletingRow
        'Dim idmenu As Int16 = e.Row.Cells(dgwCWebMenuAutorizzaid.Index).Value
        Dim menu As Integer = dgWebMenuAutorizzazioni.SelectedRows.Count
        Dim iduser = DirectCast(BS_utenti.Current, DataRowView).Row.Item("id")
        If bsWebMenuAutorizzazioni.Count > 0 Then
            If MsgBox("Sei sicuro di vole eliminare '" + menu.ToString + "' righe ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For Each righe As DataGridViewRow In dgWebMenuAutorizzazioni.SelectedRows
                    Dim idmenu As Int16 = righe.Cells(dgwCWebMenuAutorizzaid.Index).Value
                    TaWebMenuAutorizzazioni.elimina(idmenu)
                Next
                e.Cancel = True
                ApreDBAutorizzazioni(iduser)
            Else
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub btnWebMenuCategoria_Click(sender As Object, e As EventArgs) Handles btnWebMenuCategoria.Click
        For Each bb As CheckBox In grpWebButton.Controls
            If bb.Checked = True Then
                GeneraWebMenu(bb.Tag)
            End If
        Next
    End Sub

    Private Sub trbLivello_Validated(sender As Object, e As EventArgs) Handles trbLivello.Validated
        BS_utenti.EndEdit()
        Dim r As DS_utenti.DT_utentiRow
        r = DirectCast(BS_utenti.Current, DataRowView).Row
        Dim newLivello As Int16
        newLivello = trbLivello.Value
        If MsgBox("Sicuro di assegnare il livello " + newLivello.ToString + " al dipendente " + r.cognome + " " + r.nome, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Using ta As New DS_utentiTableAdapters.TA_utenti
                ta.QR_modifica(r.id, r.id_qr, r.pwd, r.nome, r.cognome, r.cf, newLivello,
                               r.titolo, r.data_creazione, r.indirizzo, r.citta, r.provincia,
                               r.cap, r.nazione, r.stato, r.telefono, r.cellulare,
                               r.emailname, r.dataass, r.datalic, r.livello, r.ore, r.datanascita,
                               r.luogonascita, r.provnascita, r.nazionalita, r.tagliadivisa, r.numeropiedi,
                               r.note, 1, r.dat_lic, r.licenzio, r.interinale, r.id_az, r.user, r.password, r.id_progressivo)
                ta.QRmodificaPWD(r.pwd, r.pwd, r.id)

            End Using
            r.AcceptChanges()

        End If
    End Sub

    Private Sub trbLivello_Scroll(sender As Object, e As EventArgs) Handles trbLivello.Scroll
        TextBox1.Text = trbLivello.Value
        creaGruppoWebCategorie()
    End Sub

    Private Sub dgwClassificazione_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        Dim cella As DataGridViewCell
        If e.ColumnIndex >= 0 Or e.RowIndex >= 0 Then
            cella = tmpDG(dgwcIDClassificazione.Index, e.RowIndex)
            Dim idClas As Int16
            idClas = cella.Value
            If cella.Value < 0 Then
                Dim risp As String = InputBox("Inserisci una nuova Classificazione ?", "Classificazione", "nuova")
                If MsgBox("Confermi l'inserimento della Classificazione " + risp + "?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    TaFileClassificazione.InsertQuery(risp, 1)
                    TaFileClassificazione.Fill(Me.DSwebcondiviso.dtFileClassificazione)
                    cella.Value = risp
                End If
            Else
                bsfile.Filter = String.Format("id_clas = '{0}'", idClas)
            End If
        End If
    End Sub

    Private Sub btnEliminaFiltriClassificazione_Click(sender As Object, e As EventArgs)
        bsfile.RemoveFilter()
    End Sub
    Private Sub dgwClassificazione_EliminaRiga(sender As Object, e As DataGridViewRowCancelEventArgs)
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        Dim cella As DataGridViewCell

        If Not IsDBNull(e.Row) Then
            cella = tmpDG(dgwcIDClassificazione.Index, e.Row.Index)
            Dim idClas As Int16
            idClas = cella.Value
            If cella.Value > 0 Then
                If MsgBox("Elimina " + tmpDG(dgwcDescrizioneClassificazione.Index, e.Row.Index).Value + " Classificazione e riassegna" + vbCrLf + "a Nessuna Classificazione tutti i documenti? ", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    TaFileClassificazione.DeleteQuery(idClas)
                    TaFileClassificazione.Fill(Me.DSwebcondiviso.dtFileClassificazione)
                    TAfile.UpdateQueryRiClassificazione(idClas)
                    e.Cancel = False
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub DGdocumenti_EliminaDocumentiFile(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DGdocumenti.UserDeletingRow
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        Dim tmpDgr As DataGridViewSelectedRowCollection
        tmpDgr = tmpDG.SelectedRows

        If IsDBNull(tmpDgr) Then
            Return
        End If
        Dim idUtente = DirectCast(BS_utenti.Current, DataRowView).Row.Item("id")

        TTPB.Value = 0
        TTPB.Maximum = tmpDgr.Count

        If MsgBox("Vuoi eliminare " + tmpDgr.Count.ToString() + " riga/e di collegamento al Documento ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim risposta As MsgBoxResult
            risposta = MsgBox("Vuoi eliminare anche il documento collegato ? **IRREVERSIBILE** ", MsgBoxStyle.YesNoCancel)

            For Each tmpRR As DataGridViewRow In tmpDgr
                Dim id As Int16
                If IsDBNull(tmpRR) Then
                    Exit For
                End If
                id = tmpRR.Cells(COLIDdocumenti.Index).Value
                Select Case risposta
                    Case MsgBoxResult.Yes
                        Dim titolo, cartella As String
                        titolo = tmpRR.Cells(COLdocumentifile.Index).Value
                        cartella = tmpRR.Cells(COLdocumentiCartella.Index).Value
                        'Dim NomeFile As String = RGdoc.title
                        Dim folderPath As String = G_DirectoriDipendenti & cartella
                        Dim FileDaEliminare As String
                        FileDaEliminare = folderPath & "\" & titolo
                        If My.Computer.FileSystem.FileExists(FileDaEliminare) = True Then
                            My.Computer.FileSystem.DeleteFile(FileDaEliminare)
                        Else
                            MsgBox("non ho trovato corrispondenza nella cartella dei documenti")
                        End If
                    Case MsgBoxResult.Cancel
                        e.Cancel = True
                        TAfile.FillByUtente(DSwebcondiviso.DTfile, idUtente, G_tipoFile)
                        Return
                End Select
                TAfile.elimina(id)
                TTPB.Value += 1
            Next
            e.Cancel = False
            TAfile.FillByUtente(DSwebcondiviso.DTfile, idUtente, G_tipoFile)

        Else
            e.Cancel = True
        End If
        TTPB.Value = 0
        Dim nRighe As Int16 = tmpDG.DisplayedRowCount(False)
        If nRighe > 0 Then
            tmpDG.CurrentCell = tmpDG.Item(1, nRighe)
        Else
            Try
                tmpDG.CurrentCell = tmpDG(1, tmpDG.Rows.GetLastRow(DataGridViewElementStates.Displayed))
            Catch ex As Exception

            End Try

        End If


    End Sub
    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles rbUp.CheckedChanged, rbMd.CheckedChanged, rbDn.CheckedChanged
        Dim rbTMP As RadioButton
        rbTMP = DirectCast(sender, RadioButton)
        If rbTMP.Checked Then
            Select Case rbTMP.Name
                Case "rbMd"
                    tblMonteOre.RowStyles(2).SizeType = SizeType.Percent
                    tblMonteOre.RowStyles(2).Height = 40
                    tblMonteOre.RowStyles(4).SizeType = SizeType.Percent
                    tblMonteOre.RowStyles(4).Height = 40
                Case "rbDn"
                    tblMonteOre.RowStyles(2).SizeType = SizeType.Percent
                    tblMonteOre.RowStyles(2).Height = 1
                    tblMonteOre.RowStyles(4).SizeType = SizeType.Percent
                    tblMonteOre.RowStyles(4).Height = 70

                Case "rbUp"
                    tblMonteOre.RowStyles(2).SizeType = SizeType.Percent
                    tblMonteOre.RowStyles(2).Height = 70
                    tblMonteOre.RowStyles(4).SizeType = SizeType.Percent
                    tblMonteOre.RowStyles(4).Height = 1

            End Select
        End If


    End Sub

    Private Sub tx_TextChanged(sender As Object, e As EventArgs) Handles tx.TextChanged
        Dim oldRG As DSfestivita.DTferieutenteRow
        oldRG = DirectCast(BSferieutente.Current, DataRowView).Row
        If oldRG.note <> tx.Text Then
            btnAggiungiFerie.Tag = 1
            btnAggiungiFerie.Text = If(btnAggiungiFerie.Tag = 1, "Salva", "Aggiungi")
        Else
            btnAggiungiFerie.Tag = 0
            btnAggiungiFerie.Text = If(btnAggiungiFerie.Tag = 1, "Salva", "Aggiungi")
        End If

    End Sub

    Private Sub btStampaRiepilogoPresenze_Click(sender As Object, e As EventArgs) Handles btStampaRiepilogoPresenze.Click
        Dim DT As DS_utenti.DTtotalepresenzeWEBtemporaneaDataTable = New DS_utenti.DTtotalepresenzeWEBtemporaneaDataTable
        DT = GenereDataRow(DT)
        bsTotaliStampa.DataSource = DT
        Me.ReportViewer1.ZoomMode = ZoomMode.FullPage
        Me.ReportViewer1.RefreshReport()

    End Sub

    ' Genera la riga della Tabella da stampare per le presenze remote
    Private Function GenereDataRow(ByRef dt As DS_utenti.DTtotalepresenzeWEBtemporaneaDataTable) As DS_utenti.DTtotalepresenzeWEBtemporaneaDataTable
        Dim id_Dip As Integer = DirectCast(BS_utenti.Current, DataRowView).Row.Field(Of Integer)("id")

        Dim RGtot As DS_utenti.DTtotalepresenzeWEBtemporaneaRow
        Using rg_dest As New DS_utentiTableAdapters.TA_presenzeWEB
            Using dtPW, dtuqPW As New DS_utenti.DT_presenzeWEBDataTable
                'cicla le presenze per destinatario
                rg_dest.FillByutenteperiodo(dtPW, PeriodoLocale, id_Dip)   'Carica la tabella delle presenze per il dip nel periodo
                rg_dest.FillByDipendentePeriodo(dtuqPW, id_Dip, PeriodoLocale)

                If dtuqPW.Rows.Count = 0 Then
                    Return Nothing
                End If

                Dim ttTMP(31) As Decimal
                For Each rgdest As DataRow In dtuqPW.Rows
                    RGtot = dt.NewRow()
                    RGtot.id_des = rgdest("id_locazione")
                    RGtot.id_cli = rgdest("id_terminale")
                    RGtot.id_dip = rgdest("id_utente")
                    RGtot.anagrafica = rgdest("anagrafica")
                    RGtot.dettaglio = rgdest("locazione")
                    RGtot.societa = rgdest("societa")
                    Dim aMese As String() = New String() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"}
                    RGtot.periodo = aMese(PeriodoLocale.Substring(5, 2) - 1) & " - " & PeriodoLocale.Substring(0, 4)
                    For j = 1 To 31
                        Dim sMese As String = PeriodoLocale.Substring(5, 2)
                        Dim sAnno As String = PeriodoLocale.Substring(0, 4)
                        Dim Umese As DateTime = DateAdd("m", 1, DateSerial(sAnno, sMese, 0))
                        If j <= Umese.Day Then
                            Dim dAccesso As DateTime = DateTime.Parse(j.ToString & "-" & sMese & "-" & sAnno)
                            Dim sGiorno As String = dAccesso.Day.ToString().PadLeft(2, "0") & WeekdayName(Weekday(dAccesso, FirstDayOfWeek.Monday)).Substring(0, 1)
                            RGtot("s" & j.ToString()) = sGiorno
                        Else
                            RGtot("s" & j.ToString()) = ""
                        End If
                    Next
                    Dim filtro As String = String.Format("id_locazione = {0}", rgdest("id_locazione"))
                    Dim righetrovate() As DataRow

                    righetrovate = dtPW.Select(filtro)
                    Dim nTMP(31) As Decimal   'Totale singola colonna
                    For Each RGrealizzate As DataRow In righetrovate
                        Dim Colonna As DateTime = DateTime.Parse(RGrealizzate("giorno"))
                        Dim Ore As TimeSpan
                        If Not Trim(RGrealizzate("orario")) = "" Then
                            Ore = TimeSpan.Parse(RGrealizzate("orario"))
                        Else
                            MessageBox.Show("Attenzione, c'è un valore errato nelle presenze del giorno " & Colonna)
                            Ore = TimeSpan.Parse("00:00")
                        End If

                        Dim Tipo As Int16 = RGrealizzate("inviato")
                        If Tipo = 2 Then
                            RGtot("n" & Colonna.Day) = "AA"
                        Else
                            nTMP(Colonna.Day) += Ore.TotalHours
                            ttTMP(Colonna.Day) += Ore.TotalHours
                            RGtot("n" & Colonna.Day) = nTMP(Colonna.Day)
                            RGtot("t" & Colonna.Day) = nTMP(Colonna.Day)
                        End If
                    Next
                    RGtot("ntot") = nTMP.Sum

                    dt.Rows.Add(RGtot)
                Next
            End Using
        End Using

        bsTotaliStampa.DataSource = dt
        Dim tmpT(31) As Decimal
        For gg = 1 To 31
            tmpT(gg) = dt.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("t" & gg))
        Next

        For Each tt In dt.Rows
            For col = 1 To 31
                tt("t" & col) = tmpT(col)
            Next
            tt("ttot") = tmpT.Sum
            tt.AcceptChanges()
        Next
        Return dt
    End Function

    Private Sub TabControl1_ChangeTab(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        Dim tmp As TabControl = DirectCast(sender, TabControl)
        Dim RGll As DS_utenti.DT_utentiRow
        RGll = DirectCast(BS_utenti.Current, DataRowView).Row
        Select Case tmp.SelectedTab.Name
            Case tpStampaRiepilogo.Name
                LinkLabelRiepilogoStampa.Text = RGll.cognome & " " & RGll.nome
                btStampaRiepilogoPresenze.PerformClick()
                TaPresenzaStampa.InsertQuery(RGll.id, Now, 1, GlobalVarPOP.G_idUtente, PeriodoLocale.Replace("-", ""))
            Case tpTimbrature.Name
                BTN_aggiornaPresenzeWeb.PerformClick()
        End Select
    End Sub

    Private Sub btnAssegnaCategoriaDocumenti_Click(sender As Object, e As EventArgs)

        Dim tmpDG As DataGridView
        tmpDG = DGdocumenti
        Dim OldPosizion As Integer = tmpDG.CurrentRow.Cells(COLIDdocumenti.Index).Value
        Dim tmpCella As DataGridViewSelectedRowCollection
        tmpCella = tmpDG.SelectedRows
        For Each tmpRow As DataGridViewRow In tmpCella
            Dim tmpID As Integer
            tmpID = tmpRow.Cells.Item(COLIDdocumenti.Index).Value
            Dim tmpClas As Int16
            tmpClas = ComboBox1.SelectedValue
            TAfile.UpdateQueryClassificazione(tmpClas, tmpID)
        Next
        AggiornamentoRighe()
        For Each tmpRow As DataGridViewRow In tmpDG.Rows
            If tmpRow.Cells(COLIDdocumenti.Index).Value = OldPosizion Then
                tmpDG.CurrentCell = tmpRow.Cells(COLIDdocumenti.Index)
                Exit For
            End If
        Next
    End Sub

    Private Sub dgPianodiLavoroperCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgPianodiLavoroperCliente.CellContentClick
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        Dim tmpType As Type = tmpDG(e.ColumnIndex, e.RowIndex).GetType
        If tmpType = GetType(DataGridViewLinkCell) Then
            Select Case tmpDG.Columns(e.ColumnIndex).Name
                Case DGWCanagraficaPiano.Name
                    Dim id As Int16
                    id = tmpDG(DGWCiddipPianodiLavoro.Index, tmpDG.CurrentRow.Index).Value
                    BS_utenti.Position = BS_utenti.Find("id", id)
                    AggiornamentoRighe()
            End Select
        End If
    End Sub

    Private Sub tabGestioneFormazioneSelectIndex(sender As Object, e As EventArgs) Handles tabGestioneFormazione.SelectedIndexChanged
        Dim TmpTab As TabControl
        TmpTab = DirectCast(sender, TabControl)
        Select Case TmpTab.TabPages(TmpTab.SelectedIndex).Name
            Case tbFormazione.Name
            Case tbScadenze.Name
                Using dt As New DSwebcondiviso.dtFFormazioneScadenzeDataTable
                    Dim lFormazione
                    Using ta As New DSwebcondivisoTableAdapters.taFormazioneScadenze
                        Try
                            ta.FillByNonLicenziati(dt)
                        Catch ex As Exception
                            Dim rr
                            rr = dt.GetErrors
                            For Each tt In rr
                                Console.WriteLine(tt)
                            Next

                        End Try

                        lFormazione = From r In dt Order By r.data_creazione Descending
                    End Using
                    For Each rr In lFormazione
                        'For Each cc In rr
                        '    Console.WriteLine(cc)
                        'Next
                    Next
                End Using
        End Select

    End Sub

    Private Sub TX_ricercaDocumenti_TextChanged(sender As Object, e As EventArgs) Handles TX_ricercaDocumenti.TextChanged
        Dim ricerca As String
        Dim tmpText As TextBox
        tmpText = DirectCast(sender, TextBox)
        ricerca = tmpText.Text
        Do While bsfile.Count >= 0
            ricerca = tmpText.Text.Substring(0, tmpText.Text.Length())
            bsfile.Filter = String.Format("description LIKE '%{0}%' OR title LIKE '%{0}%'", ricerca)
            If bsfile.Count > 0 Then
                tmpText.Text = ricerca
                tmpText.SelectionStart = tmpText.Text.Length
                Exit Do
            Else
                tmpText.Text = ricerca.Substring(0, ricerca.Length - 1)
                tmpText.SelectionStart = tmpText.Text.Length
            End If
        Loop
    End Sub
End Class

#Enable Warning CA1707 ' Gli identificatori non devono contenere caratteri di sottolineatura