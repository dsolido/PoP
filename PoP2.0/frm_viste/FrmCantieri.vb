Imports System.Text
Imports System.IO
Imports System.Security.Cryptography
Imports System.Web
Imports Microsoft.SqlServer


Public Class FrmCantieri
    Dim FolderBrowser As New FolderBrowserDialog
    Dim G_idAZ As Integer = GlobalVarPOP.G_idAZ
    Dim G_livello As Integer = GlobalVarPOP.gradoaccesso

    Dim FAvvisi As New Form
    Dim LAvvisi As New ListBox

    Dim G_Directorypartenza As String = "V:\ns\documenti\clienti\"
    Dim G_DirectoriModelliLettera As String = "v:\ns\documenti\MODELLI LETTERE\"
    Dim G_tipologia As Integer = 2 ' Assegnato per i Clienti la tipologia per memorizzare i documenti remoti
    Dim G_TLPfatturazionepresenze() As Decimal
    Dim G_TLPfatturazionepresenzeTipo() As String
    Dim G_TLPfatturazioneordini As Integer
    Dim G_ultimaposizioneconosciuta As Integer
    Dim G_IndirizzoPaginaQRCode As String = "https://pulizieuffici.biz/PW/dc.php?y="
    Dim G_IndirizzoTemporaneoQRCode As String = "https://pulizieuffici.biz/xt/dc.php?y="
    Dim PeriodoLocale As String
    Dim rgMemoriaOrarioRiga As DS_utenti.DT_orariRow
    Dim dtTesseriniQRlocazioniDataTable As DS_clienti.dtTesseriniQRlocazioniDataTable = New DS_clienti.dtTesseriniQRlocazioniDataTable()
    Dim dtUT As DSfestivita.dtPianoDataTable
    Friend RichiamoPosizione As Int16

    'Crea un Datatable per avere le locaizoni disponibili per le ferie dei clienti

    'Dim G_filtro As String = "attivo = '1'"
    Private Sub chiusuraForm(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        DG_locazioni_new.DataSource = ""
        DG_documentiRemoti.DataSource = ""
        DG_fattura.DataSource = ""
        DG_contore.DataSource = ""
        DG_presenzeRemote.DataSource = ""
        DGmacchinari.DataSource = ""
    End Sub

    Private Sub FRM_Cantieri_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TABdettaglio.DrawMode = TabDrawMode.OwnerDrawFixed
        TABdettaglio.SizeMode = TabSizeMode.Fixed
        Dim tab_size As Size = TABdettaglio.ItemSize
        tab_size.Width = 100
        tab_size.Height += 3
        TABdettaglio.ItemSize = tab_size

        Dim DT_memo As DS_servizio.DT_info_pop2Row
        DT_memo = dsolidofunc.legge_informazioni(Me.Name, GlobalVarPOP.G_nomeutente)

        AggiornaComboPeriodo(TT_CB_mese, TT_CB_anno)
        PeriodoLocale = GlobalVarPOP.GPeriodo
        CaricaDati()

        If Not IsNothing(DT_memo) Then
            BS_clienti_new.Position = BS_clienti_new.Find(DT_memo.identificativo, DT_memo.valore_identificativo)
        End If
        Me.DT_calTableAdapter.FillByPeriodo(Me.DS_clienti.DT_cal, PeriodoLocale)
        AddHandler TT_CB_anno.SelectedIndexChanged, AddressOf aggiornaAlCambioPeriodo
        AddHandler TT_CB_mese.SelectedIndexChanged, AddressOf aggiornaAlCambioPeriodo
        AddHandler BS_clienti_new.PositionChanged, AddressOf AggiornaRighe

        AddHandler BS_fatture.PositionChanged, AddressOf VisualizzaAnteprimaFattura
        Dim Visibile As Boolean = False
        TTBTSalva.Visible = Not Visibile
        TTBTModifica.Visible = Not Visibile
        TTBTElimina.Visible = Not Visibile
        TTBTRicalcolaperFatture.Visible = Not Visibile
        TTBTAggiunge.Visible = Not Visibile
        TTBTStampa.Visible = Not Visibile
        Dim RRll As DS_clienti.DT_cantieri_newRow
        If BS_clienti_new.Count > 0 Then
            RRll = DirectCast(BS_clienti_new.Current, DataRowView).Row
            LL_anagrafica0.Text = RRll.societa
        Else
            LL_anagrafica0.Text = ""
        End If
        DGVdipendenti.AllowDrop = True
        'Ripassa la visualizzazione di alcune colonne inspiegabilmente risultate visibili
        DGVdipendenti.Columns(DGVdipendenti_id.Index).Visible = False
        DGV.Columns(DGViddes.Index).Visible = False
        DGV.Columns(DGVidcli.Index).Visible = False
        DGVprogramma.Columns(DGVprogrammaID.Index).Visible = False
        DGVprogramma.Columns(DGVprogrammanote.Index).Visible = False
        CK_filtro.SetItemChecked(1, True)
        CK_filtro_controllo()

        'Popola il Datagrid che spiega le varie tipologie di ore
        If RichiamoPosizione = 0 Then
            If Not IsNothing(DT_memo) Then
                BS_clienti_new.Position = BS_clienti_new.Find(DT_memo.identificativo, DT_memo.valore_identificativo)
            Else
                BS_clienti_new.MoveFirst()
            End If
        Else
            Dim pos As Int16 = BS_clienti_new.Find("id", RichiamoPosizione)
            BS_clienti_new.Position = pos
            BindingNavigatorMovePreviousItem.PerformClick()
            BindingNavigatorMoveNextItem.PerformClick()
            'For Each rd As DataGridViewRow In DG_cantieri_new.Rows
            '    If rd.Cells(DGCId.Index).Value = RichiamoPosizione Then
            '        Exit For
            '    End If
            'Next
            TABdettaglio.SelectedTab = tbGestioneRegistroSegnalazioni
        End If
        PopolaLeggenda()
        'Me.ReportViewer1.RefreshReport()
        ' Abilita la colorazione del TAB dettaglio utile quando ci sono degli elementi da evidenziare




    End Sub

    Private Sub AggiornaRighe()
        Dim visibile As Boolean = False
        Dim RRll As DS_clienti.DT_cantieri_newRow
        Dim Visto As Boolean = True

        TTEliminaObsoletiPianodilavoro.Visible = False
        TTBTAggiunge.Visible = False
        TTBTElimina.Visible = False
        TTBTModifica.Visible = False
        TTBTSalva.Visible = False
        TTBTStampa.Visible = False

        If BS_clienti_new.Count > 0 Then
            RRll = DirectCast(BS_clienti_new.Current, DataRowView).Row
        Else
            Return
        End If
        BSR_locazioni.RemoveFilter()
        Select Case TAB_clienti.SelectedTab.Name
            Case TB1_anagrafica.Name
                visibile = False
                LL_anagrafica0.Text = RRll.societa
                BSnote.Filter = String.Format("idcli = {0}", RRll.id)
                caricaNote(RRll.id)
                Me.TaCantieriSegnalazioni.FillByDettaglio(Me.DS_clienti.dtCantieriSegnalazioni, RRll.id)
                dgwRegistroSegnalazioni.Columns(dgwIdregistrosegnalazioni.Index).Visible = False
                Dim rs = From x In Me.DS_clienti.dtCantieriSegnalazioni Where x.id_cli = RRll.id Group By x.risoluzione Into Count(x.id)
                tbGestioneRegistroSegnalazioni.Text = "Segnalazioni"
                tbGestioneRegistroSegnalazioni.ToolTipText = ""
                tbGestioneRegistroSegnalazioni.BackColor = DefaultBackColor
                Dim testo As String = ""
                For Each rgSol In rs
                    'Se ci sono stati o sono ancora presenti dei problemi
                    If rgSol.risoluzione > 0 Then
                        testo = "risolti : " & rgSol.Count
                        tbGestioneRegistroSegnalazioni.BackColor = Color.Green
                        tbGestioneRegistroSegnalazioni.ToolTipText = testo
                    Else
                        testo += vbCrLf & "# non risolti:" & rgSol.Count
                        tbGestioneRegistroSegnalazioni.BackColor = Color.Red
                        tbGestioneRegistroSegnalazioni.ToolTipText = testo
                    End If
                Next

            Case TB_pianodilavoro.Name  'Piano di lavoro e Ferie
                Dim periodoricerca As String

                Select Case tbcFerieCliente.SelectedTab.Name
                    Case tbFerieMensili.Name
                        LL_AnagraficaFoglioPresenza.Text = RRll.societa
                        periodoricerca = PeriodoLocale.Replace("-", "")

                        'Carica le ferie dei dipendenti del cliente nel periodo
                        Me.TAferiecliente.FillByidClientePeriodo(Me.DSfestivita.DTferiecliente, RRll.id, periodoricerca)

                        'Carica il piano di lavoro del Cantiere
                        CaricaPianodiLavoro(RRll.id)

                        'Carica il piano settimanale
                        CaricaTBRiepilogoOreMese()
                        'Carica le intestazioni del mese
                        GeneraPianodiLavoroDipendente.F_caricaintestazioneMese(DG_Tmese, PeriodoLocale)

                        'Genera la DataTable che contiene i dati mensili comprese le assenze e sostituzioni e ferie
                        Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
                        Using ta As New DSfestivitaTableAdapters.TAtipoorario
                            ta.Fill(dtTipoOrario)
                        End Using

                        GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioCliente(DG_Tmese, dtUT, BS_clienti_new, BS_cal, PeriodoLocale, dtTipoOrario, True, ckFerieapprovate.Checked)

                        tbFerieSommario.Text = "Ferie Sommario"
                    Case tbFerieSommario.Name

                        'tbFerieMensili.Text = String.Format("Periodo analizzato {0} dell'Anno {1}", TT_CB_mese.Items, TT_CB_anno.Items)
                        'Me.TAferiecliente.FillByidClientePeriodo(Me.DSfestivita.DTferiecliente, RRll.id, PeriodoLocale.Split("-").First)
                        'F_caricaintestazioneMese(dgFerieAnnoCliente, 3)
                        'CaricaPianodiLavoro(RRll.id)
                        'tbFerieMensili.Text = "Ferie Dettaglio Mese"

                End Select

            Case TB3_Fatture.Name
                LL_anagraficaWEB.Text = RRll.societa
                Me.TAfile.FillByUtente(Me.DSwebcondiviso.DTfile, RRll.id, 2)
            Case TBL_inserimentopresenze.Name
                Me.TA_contore.FillByClientePeriodo(Me.DS_clienti.DT_contore, PeriodoLocale, RRll.id)
                visibile = False
                LLpresenze.Text = RRll.societa
                'caricaDG_PresenzeReali()
            Case TBL_inserimentopresenzeweb.Name
                Try
                    TA_presenzeWEB.FillByPeriodoTotale(Me.DS_clienti.DT_presenzeWEB, PeriodoLocale, RRll.id)
                Catch ex As Exception
                    Dim err As DataRow() = Me.DS_clienti.DT_presenzeWEB.GetErrors
                    For Each vv In err
                        Console.WriteLine(vv.RowError)
                    Next
                End Try
                LL_anagrafica1.Text = RRll.societa
                visibile = False
                ContaDG_totaliPresenzeWEB()
            Case TB_abbinamentodipendenti.Name
                visibile = False
                LL_abbinamentoPresenzeRemote.Text = RRll.societa
                DGVprogrammaID.Visible = False
                BSR_locazioni.Filter = "attivo = 1"
                Elencoobsoleti.Visible = False
            Case TB_fattureclienti.Name
                If G_livello < 800 Then
                    MsgBox("Non hai sufficienti diritti per questa applicazione")
                    TAB_clienti.SelectedIndex = 0
                    Return
                End If
                '
                '   Calcola se sono presenti Ordini e o Presenze evidenzia con del testo
                '
                CalcolaOrdiniPresenzeperFatturazione()
                visibile = False
                LL_clienteFattura.Text = RRll.societa
                Dim anno As Integer
                anno = TT_CB_anno.SelectedItem.ToString
                TA_fatture.FillByID_cli(DS_clienti.DT_fatture, anno, RRll.id)
                Dim totimp As Decimal = 0
                Dim totiva As Decimal = 0
                Dim totpag As Decimal = 0
                Dim totdap As Decimal
                Dim FRG As DS_clienti.DT_fattureRow
                For Each _frg In BS_fatture
                    FRG = DirectCast(_frg, DataRowView).Row
                    totimp = totimp + (FRG.totale * If(FRG.fat_nc = 0, 1, -1))
                    totiva = totiva + (FRG.imposta * If(FRG.fat_nc = 0, 1, -1))
                    totpag = totpag + FRG.fat_pa_imp
                Next

                Dim ultimaRiga As Integer = DG_fattura.Rows.GetLastRow(DataGridViewElementStates.None)
                If ultimaRiga <> -1 Then
                    DG_fattura.CurrentCell = DG_fattura.Item(1, ultimaRiga)
                End If

                totdap = totimp + totiva - totpag
                LB_imponibile_r.Text = totimp.ToString("N2")
                LB_imposta_r.Text = totiva.ToString("N2")
                LB_pagato_r.Text = totpag.ToString("N2")
                LB_dapagare_r.Text = totdap.ToString("N2")
                AggiornaTotaliFatturato()
            Case TB_ordini.Name
                LL_ordini.Text = RRll.societa
                visibile = False
                Dim anno As Integer
                anno = TT_CB_anno.SelectedItem.ToString
                TA_ordini.FillByClienteAnno(DS_Ordini.DT_ordini, RRll.id, G_idAZ, anno)
                Me.TA_fornitori.Fill(Me.DS_Ordini.DT_fornitori)
                Dim totlordo As Decimal = 0
                Dim totnetto As Decimal = 0
                Dim FRG As DS_Ordini.DT_ordiniRow
                For Each _frg In BSordini
                    FRG = DirectCast(_frg, DataRowView).Row
                    Dim TotL As Decimal = If(FRG.IstotalelordoNull, 0, FRG.totalelordo)
                    Dim TotN As Decimal = If(FRG.IstotalenettoNull, 0, FRG.totalenetto)
                    totlordo += TotL
                    totnetto += TotN
                Next
                LBordinelordo.Text = totlordo.ToString("N2")
                LBordinenetto.Text = totnetto.ToString("N2")
            Case tbGeneratoreQRcode.Name
                dtTesseriniQRlocazioniDataTable.Rows.Clear()
                txIndirizzoPaginaQR.Text = G_IndirizzoPaginaQRCode
                txIndirizzoQRTemporanei.Text = G_IndirizzoTemporaneoQRCode
            Case TBmacchinari.Name
                LLmacchinari.Text = RRll.societa
                TAmacchine.Fill(DSmacchinari.DTmacchine)
                TAservizio.Fill(DSmacchinari.DTservizio)
                TAmovimentimacchine.FillBycliente(DSmacchinari.DTmovimentimacchine, RRll.id)
            Case tbPreventiviAbbinati.Name
                llPreventivi.Text = RRll.societa
                Using dt As New dsPreventivi.dtCapitolatoDataTable
                    Using ta As New dsPreventiviTableAdapters.taCapitolato
                        Try
                            ta.FillByCliente(dt, RRll.id, 1)
                        Catch ex As Exception
                            Dim err As DataRow() = dt.GetErrors
                            Dim msg As New StringBuilder
#If DEBUG Then
                            For Each e In err
                                MascheraAvvisi()
                                LAvvisi.Items.Add(e.RowError)
                            Next
                            FAvvisi.ShowDialog()
                            FAvvisi.Close()
#End If
                        End Try
                        Dim tmpcap As New dsPreventivi.tmpCapitolatoDataTable

                        tmpcap.Rows.Clear()
                        tmpcap.AcceptChanges()
                        Dim x As Int16
                        For Each rg As dsPreventivi.dtCapitolatoRow In dt.Rows
                            x += 1
                            tmpcap.Rows.Add(x, rg.id_destinatario_preventivo, rg.id_categoria, rg.id_frequenza, rg.id_operazioni, rg.locazione, rg.categoria, rg.frequenza, rg.descrizione, rg.sort)
                        Next
                        RiempieilmioTreeView(RRll.societa, tmpcap)
                    End Using
                End Using
        End Select
        'TTBT_eliminaremoto.Visible = Visible
        TTBTStampa.Visible = Not visibile
        TTBTSalva.Visible = Not visibile
        TTBTModifica.Visible = Not visibile
        TTBTElimina.Visible = Not visibile
        TTBTRicalcolaperFatture.Visible = Not visibile
        TTBTAggiunge.Visible = Not visibile
        CK_spostacopia.Checked = True
    End Sub

    Private Sub CaricaTBRiepilogoOreMese()
        If TAB_clienti.SelectedTab.Name <> TBL_pianodilavoro.Name Then
            Return
        End If
        Dim RRloc As DS_clienti.DT_cantieri_newRow
        RRloc = DirectCast(BS_clienti_new.Current, DataRowView).Row

        Using TA As New DS_clientiTableAdapters.TA_orari
            TA.FillByClienteDestinatariAttivi(Me.DS_clienti.DT_orari, RRloc.id)
        End Using

        Using TA As New DS_utentiTableAdapters.TA_cal
            Using DT As New DS_utenti.DT_calDataTable
                TA.FillByPeriodo(DT, PeriodoLocale)
                BS_cal.DataSource = DT
            End Using
        End Using
        Me.TA_presenzeWEB.FillByPeriodo(Me.DS_clienti.DT_presenzeWEB, PeriodoLocale, 1)
    End Sub
    'Carica il piano di lavoro nella tabella DG_giorno

    Private Function CaricaPianodiLavoro(ByVal idcli As Integer) As Boolean

        Dim giorni As String() = {"lu_", "ma_", "me_", "gi_", "ve_", "sa_", "do_"}
        DG_orari.Rows.Clear()

        Using dt As New DS_clienti.DT_orariDataTable

            Using ta As New DS_clientiTableAdapters.TA_orari
                ta.FillByClienteDestinatariAttivi(dt, idcli)
            End Using
            If dt.Rows.Count = 0 Then
                Return (True)
            End If
            Dim oldIDDes As Integer = dt(0).id_des
            Dim pT(7) As Decimal
            Dim gT(7) As Decimal
            For Each rg As DS_clienti.DT_orariRow In dt.Rows
                If oldIDDes <> rg.id_des Then
                    creaRigaOrario(pT, Color.LightGreen)
                    For i = 0 To pT.Count - 1
                        pT(i) = 0
                    Next
                    oldIDDes = rg.id_des
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
                Dim valori As Object() = {rg.id, rg.anagrafica, rg.locazione, S(0), T(0).ToString, S(1), T(1).ToString, S(2), T(2).ToString, S(3), T(3).ToString, S(4), T(4).ToString, S(5), T(5).ToString, S(6), T(6).ToString, TT.ToString}
                R.CreateCells(DG_orari, valori)
                DG_orari.Rows.Add(R)
            Next
            creaRigaOrario(pT, Color.LightGreen)
            For i = 0 To pT.Count - 1
                pT(i) = 0
            Next
            creaRigaOrario(gT, Color.LightCoral)

        End Using

        Return (True)
    End Function
    Private Sub creaRigaOrario(ByVal pT() As Decimal, C As Color)
        Dim q As New DataGridViewRow
        Dim sT(7) As String
        For i = 0 To pT.Count - 2
            sT(i) = If(pT(i) = 0, "", pT(i).ToString("N2"))
        Next
        sT(7) = pT.Sum().ToString("N2")
        Dim totaliparziali As Object() = {0, "Totale PARZIALE", "", "", sT(0), "", sT(1), "", sT(2), "", sT(3), "", sT(4), "", sT(5), "", sT(6), sT(7)}
        q.CreateCells(DG_orari, totaliparziali)
        q.DefaultCellStyle.BackColor = C
        DG_orari.Rows.Add(q)
    End Sub
    Private Sub DG_totaleoreweb_cellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DG_totaleoreweb.CellFormatting

        Dim festivo As Integer = 0
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        Dim intesta As String
        intesta = tmpDG.Columns(e.ColumnIndex).HeaderText
        If intesta.Substring(0, 3) = "FES" Then
            festivo = 1
        Else
            festivo = 0
        End If
        If festivo > 0 Then
            e.CellStyle.BackColor = Color.CadetBlue
        End If
    End Sub


    Private Sub DG_presenzeRemote_cellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DG_presenzeRemote.CellFormatting
        ' If the column is the Artist column, check the
        ' value.

        If Me.DG_presenzeRemote.Columns(e.ColumnIndex).Name = "ingresso" Or Me.DG_presenzeRemote.Columns(e.ColumnIndex).Name = "uscita" Or Me.DG_presenzeRemote.Columns(e.ColumnIndex).Name = "orario" Then
            FormattaCellaOraCorta(e)
        ElseIf Me.DG_presenzeRemote.Columns(e.ColumnIndex).Name = "CpresenzewebGiorno" Then
            FormattaCellaDataCorta(e)
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
    Private Function AggiornaTotaliFatturato()
        Using DT As New DS_clienti.DT_fattureDataTable
            Try
                TA_fatture.FillByTotaliraggruppati(DT, TT_CB_anno.SelectedItem)
            Catch ex As Exception
                Dim err As DataRow() = DT.GetErrors
#If DEBUG Then
                For Each e In err
                    Console.WriteLine(e.RowError)
                Next
#End If
            End Try

            Dim FTmese, IvaMese As Decimal
            Dim FTanno, IvaAnno As Decimal
            For Each rg In DT
                FTanno = FTanno + rg.Item("tot_netto")
                IvaAnno = IvaAnno + rg.Item("tot_iva")
                If rg.Item("periodo") = PeriodoLocale Then
                    FTmese = rg.Item("tot_netto")
                    IvaMese = rg.Item("tot_iva")
                End If
            Next
            LB_imponibileTOT.Text = "Fatturato " & TT_CB_anno.SelectedItem & "-> " & FTanno.ToString("N2")
            LB_impostaTOT.Text = "Imposta " & TT_CB_anno.SelectedItem & "-> " & IvaAnno.ToString("N2")
            LB_pagatoTOT.Text = "Fatturato " & GlobalVarPOP.G_amese(TT_CB_mese.SelectedIndex) & "-> " & FTmese.ToString("N2")
            LB_dapagareTOT.Text = "Imposta " & GlobalVarPOP.G_amese(TT_CB_mese.SelectedIndex) & "-> " & IvaMese.ToString("N2")
        End Using
        Return True
    End Function

    Private Sub CK_filtro_controllo() Handles CK_filtro.ItemCheck, CK_filtro.SelectedIndexChanged
        If BS_clienti_new.Count <= 0 Then
            Return
        End If
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
                Case "Tutti"
                    S_Fil(0) = ""
                Case "Attivi"
                    S_Fil(1) = " AND attivo = 1"
                Case "Budget"
                    S_Fil(2) = " AND budget = 0"
                Case "In scadenza"
                    S_Fil(3) = String.Format(" AND data_termine > '{0}'", DataMysql(Now()))
                Case Else
            End Select
        Next
        T_Fil = ""
        For N_fil = 0 To 3
            T_Fil = T_Fil & S_Fil(N_fil)
        Next
        T_Fil = If(T_Fil.Length < 4, "", If(T_Fil.Substring(0, 4) = " AND", T_Fil.Substring(4, T_Fil.Length - 4), T_Fil))
        Try
            BS_clienti_new.Filter = T_Fil
        Catch ex As Exception
            BS_clienti_new.RemoveFilter()
        End Try


    End Sub

    Private Function CaricaDati()
        'Cantieri
        Try
            Me.TA_cantieri_new.Fill(Me.DS_clienti.DT_cantieri_new, G_idAZ)

        Catch ex As Exception
            Dim err As DataRow() = Me.DS_clienti.DT_cantieri_new.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each e In err
                MascheraAvvisi()
                LAvvisi.Items.Add(e.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
            Return (False)
        End Try
        Try
            Me.TA_utenti.Fill(Me.DS_utenti.DT_utenti, GlobalVarPOP.G_idAZ)
            BSutenti.Filter = "stato = 1"
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_clienti.DT_cantieri_fe.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each e In err
                MascheraAvvisi()
                LAvvisi.Items.Add(e.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
            Return (False)
        End Try
        Try
            Me.TA_cantieri_fe.Fill(Me.DS_clienti.DT_cantieri_fe, G_idAZ)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_clienti.DT_cantieri_fe.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each e In err
                MascheraAvvisi()
                LAvvisi.Items.Add(e.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
            Return (False)
        End Try
        Try
            Me.TA_pagamenti_new.Fill(Me.DS_clienti.DT_pagamenti_new)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_clienti.DT_pagamenti_new.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each e In err
                MascheraAvvisi()
                LAvvisi.Items.Add(e.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
            Return (False)
        End Try
        'Destinatari del servizio
        Try
            Me.TA_locazione_new.Fill(Me.DS_clienti.DT_locazione_new, G_idAZ)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_clienti.DT_locazione_new.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each e In err
                MascheraAvvisi()
                LAvvisi.Items.Add(e.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
            Return (False)
        End Try
        Try
            Me.TA_tipoIVA.Fill(Me.DS_clienti.DT_tipo_fatture_IVA_new)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_clienti.DT_tipo_fatture_IVA_new.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each e In err
                MascheraAvvisi()
                LAvvisi.Items.Add(e.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
            Return (False)
        End Try
        Try
            Me.TA_tiporighe.Fill(Me.DS_clienti.DT_tipo_fatture_righe_new)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_clienti.DT_tipo_fatture_righe_new.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each e In err
                MascheraAvvisi()
                LAvvisi.Items.Add(e.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
            Return (False)
        End Try
        'Carica i collegamenti ai file remoti
        Try
            Me.TA_categorie.Fill(Me.DS_clienti.DT_categorie)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_clienti.DT_categorie.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each e In err
                MascheraAvvisi()
                LAvvisi.Items.Add(e.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
            Return (False)
        End Try
        Try
            Me.TA_fornitori.Fill(Me.DS_Ordini.DT_fornitori)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_Ordini.DT_fornitori.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each e In err
                MascheraAvvisi()
                LAvvisi.Items.Add(e.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
            Return (False)
        End Try

        Me.TA_tipologia.mostra(Me.DS_utenti.DT_tipologia)
        Me.DT_AUDPTableAdapter.Fill(Me.DS_clienti.DT_AUDP)
        Me.TA_lettere.FillByTipo(Me.DS_utenti.DT_lettere, 2)
        DT_calTableAdapter.FillByPeriodo(Me.DS_clienti.DT_cal, PeriodoLocale)
        Return (True)
    End Function
    Private Sub riempie_riepilogo_giorni(ByVal cella As Integer, ByVal totale As Decimal, ByVal aggiunge As Boolean)
        'procedura per scrivere i valori nelle singole celle chiamate cella
        Dim dw As String() = New String() {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
        Dim tmp_data As DateTime
        Dim tmp_day As Integer = cella + 1  'Valore giorno (da 0 a massimogiorno mese)
        Dim ultimogiorno As Integer = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0).Day
        Dim LarghezzaCellaMassima As Integer = (DG_totalipresenze.Width - 50) / (ultimogiorno + 1)
        tmp_data = New DateTime(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, tmp_day) 'Ricrea il giorno del mese
        If aggiunge Then
            'Crea una cella con nome C & numero cella, intestazione Prima lettera del giorno della settimana oltre al giorno del mese
            DG_totalipresenze.Columns.Add("C" & cella, dw(tmp_data.DayOfWeek).Substring(0, 1) & " " & tmp_day.ToString.PadLeft(2, "0"))
        End If
        If totale > 0 Then
            'definisce quanto è grande la cella che visualizza il totale
            DG_totalipresenze.Columns("C" & cella).Width = LarghezzaCellaMassima
            If DG_totalipresenze.Rows.Count < 1 Then
                DG_totalipresenze.Rows.Add()
            End If
            'DG_totali.hea(des_giorno(cli).day -1).
            Dim strtot = Format(totale, "#.0#")
            Dim ncarat = strtot.Length

            '  DG_totali.Columns("C" & cella).Width = 9 * ncarat
            DG_totalipresenze(cella, 0).Value = IIf(totale > 0, strtot, "")
        Else
            'DG_totali(cella, 0).Value = ""
            DG_totalipresenze.Columns("C" & cella).Width = LarghezzaCellaMassima
        End If

    End Sub
    Private Sub TTTestoRicerca_Click(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        'Ricerca nell'elenco clienti

        Dim Ricerca As String = TTTestoRicerca.Text
        CK_filtro_controllo()

        Dim NN As Integer = 0
        BS_clienti_new.Filter = If(BS_clienti_new.Filter.Length > 0, BS_clienti_new.Filter & " AND ", "") & String.Format("ricerca LIKE '%{0}%'", Ricerca)
        Dim numeroRighe As Integer = BS_clienti_new.Count


        If numeroRighe = 0 Then
            BS_clienti_new.RemoveFilter()

            Dim unused = CambiaColore()
            CK_filtro_controllo()
            numeroRighe = BS_clienti_new.Count
            If IsNothing(G_ultimaposizioneconosciuta) <> True Or G_ultimaposizioneconosciuta <> 0 Then
                Dim pos As Integer = BS_clienti_new.Find("id", G_ultimaposizioneconosciuta)
                BS_clienti_new.Position = pos
            End If
            TTTestoRicerca.Text = TTTestoRicerca.Text.Substring(0, If(TTTestoRicerca.Text.Length() - 1 <= 0, 0, TTTestoRicerca.Text.Length() - 1))
            TTTestoRicerca.SelectionStart = TTTestoRicerca.Text.Length
        Else
            G_ultimaposizioneconosciuta = DirectCast(BS_clienti_new.Current, DataRowView).Row.Field(Of Integer)("id")
        End If
        Do While numeroRighe < 1
            NN += 1
            If Ricerca.Length() > 0 Then
                Ricerca = TTTestoRicerca.Text.Substring(0, If(TTTestoRicerca.Text.Length() - NN <= 0, 0, TTTestoRicerca.Text.Length() - NN))
                TTTestoRicerca.Text = Ricerca
                TTTestoRicerca.SelectionStart = TTTestoRicerca.Text.Length
                Dim unused = CambiaColore()
            Else
                CK_filtro_controllo()
                Exit Do
            End If
        Loop
        AggiornaRighe()
    End Sub
    Private Sub TTBTAggiunge_MouseDown(sender As Object, e As MouseEventArgs) Handles TTBTAggiunge.MouseDown
        'se hai premuto il click sinistro su cmd_stampa ti propone il menù di stampa
        If e.Button = Windows.Forms.MouseButtons.Left Then
            MNU_Aggiunta.Show(New Point(MousePosition.X, MousePosition.Y))
        End If
    End Sub
    Private Sub P_aggiunge(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles MNU_Aggiunta.ItemClicked
        'Dim menu = DirectCast(sender, ContextMenuStrip)
        Dim cg As DS_clienti.DT_cantieri_newRow
        Try
            cg = DirectCast(BS_clienti_new.Current, DataRowView).Row
        Catch ex As Exception
            cg = Nothing
        End Try
        Dim dg As DS_clienti.DT_locazione_newRow
        Dim toolStrip = e.ClickedItem
        Dim MNU_tmp As New ContextMenuStrip
        MNU_tmp = DirectCast(sender, ContextMenuStrip)
        Select Case toolStrip.Name
            Case "MNU_NuovoCliente"
                Dim oldCli As Integer
                oldCli = BS_clienti_new.Position
                AttivaPulsanti(False)
                BS_clienti_new.AddNew()
                Dim ff As New FRM_mod_cliente(Me.DS_clienti.DT_cantieri_new, BS_clienti_new, -1)
                ff.ShowDialog()
                Me.TA_cantieri_new.Fill(Me.DS_clienti.DT_cantieri_new, G_idAZ)
                BS_clienti_new.Position = oldCli
            Case "MNU_NuovoDestinatario"
                Try
                    BSR_locazioni.AddNew()
                Catch ex As Exception

                End Try
                dg = DirectCast(BSR_locazioni.Current, DataRowView).Row
                'Seleziona la cella corretta
                Dim neID As Int16 = TA_locazione_new.SP_ultimoID(G_idAZ)
                dg.id = neID + 1 'X_id_az.ToString.PadRight(4, "0") + 
                dg.address = cg.address
                dg.cap = cg.postalcode
                dg.citta = cg.city
                dg.locazione = cg.societa.Substring(0, If(cg.societa.Length < 10, cg.societa.Length, 10))
                Dim nuovoORD As Object = Nothing
                Try
                    nuovoORD = DG_locazioni_new.Rows.Count
                Catch ex As Exception

                End Try
                dg.ordine = If(nuovoORD <> Nothing, nuovoORD, 0)
                dg.extra = 1        'preimpostazione di canone
                dg.fatturabile = 1  'preimpostazione per Reverse Charge
                DG_locazioni_new.SelectionMode = DataGridViewSelectionMode.CellSelect

                AttivaPulsanti(False)
                DG_locazioni_new.Focus()
            Case "MNU_NuovoCodiceFatturaElettronica"
                AttivaPulsanti(False)
                If BSR_cantieriFE.Count = 0 Then
                    Dim o As DS_clienti.DT_cantieri_feRow
                    Dim R_cli As DS_clienti.DT_cantieri_newRow
                    BSR_cantieriFE.AddNew()
                    R_cli = DirectCast(BS_clienti_new.Current, DataRowView).Row
                    o = DirectCast(BSR_cantieriFE.Current, DataRowView).Row
                    o.id_cli = R_cli.id
                    o.id_az = G_idAZ
                    o._1151_telefono = ""
                    o._1152_email = ""
                    o.data_modifica = Now
                    BSR_cantieriFE.EndEdit()
                End If
                Me._114_codicedestinatarioTextBox.Focus()

        End Select
    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        Dim risposta As Boolean = True
        Dim oldCli As Integer
        Dim oldDes As Integer

        oldCli = BS_clienti_new.Position
        If BSR_locazioni.Count > 0 Then
            oldDes = BSR_locazioni.Position
        Else
            oldDes = 0
        End If

        BS_clienti_new.EndEdit()
        Dim rr As DS_clienti.DT_cantieri_newRow

        For Each RG In BS_clienti_new

            rr = DirectCast(RG, DataRowView).Row
            Select Case rr.RowState
                Case DataRowState.Modified
                    TA_cantieri_new.QR_Modifica(rr.societa, rr.address, rr.postalcode, rr.city,
                                       rr._region, rr.state, rr.title, rr.email_name, rr.first_name, rr.partitaiva,
                                       rr.work_phone, rr.work_extension, rr.home_phone, rr.mobile_phone,
                                       rr.fax_number, rr.pagamento, rr.bancaappog, rr.data_inizio, rr.data_termine,
                                       rr.contabilita, If(rr.IsattivoNull, 0, rr.attivo), If(rr.IsbudgetNull, 0, rr.budget), rr.condomino, rr.l_mobile, rr.data_creazione, If(rr.IspaNull, 0, rr.pa),
                                       rr.id_UQ, rr.id)
                    rr.AcceptChanges()
            End Select
        Next

        risposta = F_memorizza_destinatari()
        If Not risposta Then
            MsgBox("Non sono riuscito a memorizzare le destinazioni")
        End If
        BSR_locazioni.Position = oldDes
        risposta = F_memorizza_FE()
        If Not risposta Then
            MsgBox("Non riesco a memorizzare i dati per la Fattura elettronica")
        End If
        AttivaPulsanti(True)

    End Sub
    Private Function F_memorizza_FE() As Boolean
        Dim o As DS_clienti.DT_cantieri_feRow
        BSR_cantieriFE.EndEdit()
        'Dim ho As DS_clienti.DT_cantieri_feRow
        For Each HG In BSR_cantieriFE
            o = DirectCast(HG, DataRowView).Row
            Select Case o.RowState
                Case DataRowState.Modified
                    Try
                        'Se non inserisco alcuna voce, crea una riga con i parametri base
                        o._114_codicedestinatario = If(o.Is_114_codicedestinatarioNull, "0000000", o._114_codicedestinatario)
                        o._116_pecdestinatario = If(o.Is_116_pecdestinatarioNull, "nulla", o._116_pecdestinatario)
                        TA_cantieri_fe.modifica(o.id_cli, o._114_codicedestinatario, o._116_pecdestinatario, o.id)
                        o.AcceptChanges()
                    Catch
                        Return False
                    End Try
                Case DataRowState.Added
                    Try
                        'Se non inserisco alcuna voce, crea una riga con i parametri base
                        If BSR_cantieriFE.Count > 1 Then
                            o._114_codicedestinatario = If(o.Is_114_codicedestinatarioNull, "0000000", o._114_codicedestinatario)
                            o._116_pecdestinatario = If(o.Is_116_pecdestinatarioNull, "nulla", o._116_pecdestinatario)
                            TA_cantieri_fe.modifica(o.id_cli, o._114_codicedestinatario, o._116_pecdestinatario, o.id)
                            o.AcceptChanges()
                        Else
                            o._114_codicedestinatario = If(o.Is_114_codicedestinatarioNull, "0000000", o._114_codicedestinatario)
                            o._116_pecdestinatario = If(o.Is_116_pecdestinatarioNull, "nulla", o._116_pecdestinatario)
                            TA_cantieri_fe.inserisci(o.id_cli, o._114_codicedestinatario, o._116_pecdestinatario, G_idAZ)
                            o.AcceptChanges()
                        End If
                    Catch
                        Return False
                    End Try
            End Select
        Next
        Return True
    End Function
    Private Function F_memorizza_destinatari() As Boolean

        BSR_locazioni.EndEdit()
        Dim o As DS_clienti.DT_locazione_newRow
        Dim R_cli As DS_clienti.DT_cantieri_newRow
        R_cli = DirectCast(BS_clienti_new.Current, DataRowView).Row

        For Each rg In BSR_locazioni
            o = DirectCast(rg, DataRowView).Row
            Select Case o.RowState
                Case = DataRowState.Modified
                    Dim old_ID As Integer = o.id
                    Try
                        'Se non inserisco alcuna voce, crea una riga con i parametri base
                        o.locazione = If(o.IslocazioneNull, R_cli.societa & " ORD", If(o.locazione = "", R_cli.societa & " ORD", o.locazione))
                        o.address = If(o.IsaddressNull, R_cli.address, If(o.address = "", R_cli.address, o.address))
                        o.citta = If(o.IscittaNull, R_cli.city, If(o.citta = "", R_cli.city, o.citta))
                        o.cap = If(o.IscapNull, R_cli.postalcode, If(o.cap.Trim = "", R_cli.postalcode, o.cap))
                        o.attivo = If(o.IsattivoNull, 0, 1)
                        o.canone = If(o.IscanoneNull, 0, o.canone)
                        o.riga_fattura = If(o.Isriga_fatturaNull, "Canone servizio di pulizia", If(o.riga_fattura = "", "Inserire una riga ", o.riga_fattura))
                        o.extra = If(o.IsextraNull, 1, o.extra)
                        o.fatturabile = If(o.IsfatturabileNull, 1, o.fatturabile)
                        o.data_creazione = Now
                        o.l_Stampa = 0
                        o.lat = If(o.IslatNull, "", o.lat)
                        o.lon = If(o.IslonNull, "", o.lon)

                        TA_locazione_new.QR_Modifica(o.id_terminale, o.ordine, o.locazione, o.address,
                                                         o.citta, o.cap, o.canone, o.attivo, o.riga_fattura, o.extra,
                                                         o.fatturabile, o.data_creazione, o.l_Stampa, o.lat, o.lon, o.id_for,
                                                         old_ID)
                        o.AcceptChanges()
                    Catch ex As Exception
                        Return False
                    End Try
                Case = DataRowState.Added
                    Dim N_ID_nuovo As Integer = 0
                    N_ID_nuovo = TA_locazione_new.SP_ultimoID(G_idAZ) + 1
                    Try
                        o.locazione = If(o.IslocazioneNull, R_cli.societa & " ORD", If(o.locazione = "", R_cli.societa & " ORD", o.locazione))
                        o.address = If(o.IsaddressNull, R_cli.address, o.address)
                        o.citta = If(o.IscittaNull, R_cli.city, o.citta)
                        o.cap = If(o.IscapNull, R_cli.postalcode, o.cap)
                        o.canone = If(o.IscanoneNull, 0, o.canone)

                        'aggiunge 1 all'ultimo ordine
                        o.attivo = If(o.IsattivoNull, 1, 0)
                        o.riga_fattura = If(o.Isriga_fatturaNull, "Canone servizio di pulizia", o.riga_fattura)
                        o.extra = If(o.IsextraNull, 1, o.extra)
                        o.fatturabile = If(o.IsfatturabileNull, 1, o.fatturabile)
                        o.data_creazione = Now
                        o.l_Stampa = 0
                        o.lat = If(o.IslatNull, "", o.lat)
                        o.lon = If(o.IslonNull, "", o.lon)
                        TA_locazione_new.QR_Inserisce(N_ID_nuovo, o.id_terminale, o.ordine, o.locazione, o.address,
                                                     o.citta, o.cap, o.canone, o.attivo, o.riga_fattura, o.extra,
                                                     o.fatturabile, o.data_creazione, o.l_Stampa, o.lat, o.lon, G_idAZ, o.id_for)
                        o.AcceptChanges()
                    Catch ex As Exception
                        Return False
                    End Try

            End Select
        Next
        Try
            Me.TA_locazione_new.Fill(Me.DS_clienti.DT_locazione_new, G_idAZ)
        Catch ex As Exception
        End Try
        Return True
    End Function


    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Dim rg As DS_clienti.DT_cantieri_newRow
        If BS_clienti_new.Count > 0 Then
            rg = DirectCast(BS_clienti_new.Current, DataRowView).Row
            Dim nome_ri As Array = {BS_clienti_new.DataMember, "id", rg.id, TT_CB_mese.SelectedIndex + 1, TT_CB_anno.SelectedItem, ""}
            dsolidofunc.memorizza_informazioni(Me.Name, BS_clienti_new.Position, GlobalVarPOP.G_nomeutente, nome_ri)
        End If
        Me.Close()
    End Sub

    Private Sub aggiornaAlCambioPeriodo()

        Dim idTMP As Integer
        'Dim RGDG As New DataGridViewRow
        idTMP = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")

        PeriodoLocale = TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
        CaricaDati()
        CK_filtro_controllo()
        BS_clienti_new.Position = BS_clienti_new.Find("id", idTMP)
        AggiornaRighe()


    End Sub
    Shared Function Find(ByVal id As Integer, ByVal dg As DataGridView)
        If IsDBNull(dg) Then
            Return True
        Else
            dg.ClearSelection()
            Dim riga, righe, dgid As Integer
            righe = dg.RowCount
            For riga = 0 To righe - 1
                dgid = dg.Item(0, riga).Value
                If dgid = id Then
                    dg.Item(0, riga).Selected = True
                    dg.CurrentCell = dg(0, riga)
                End If
            Next
        End If
        Return True
    End Function

    Private Function AttivaPulsanti(ByRef Attivazione As Boolean)
        TTBTRicalcolaperFatture.Visible = Not Attivazione
        TTBTElimina.Visible = Attivazione
        TTBTSalva.Visible = True
        TTBTAggiunge.Visible = Attivazione
        TTBTStampa.Visible = Attivazione

        Return True
    End Function

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

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim N_ID As Object = Nothing
        Try
            'Cerca il record precedente per memorizzare la posizione nuova
            N_ID = DG_cantieri_new("C_ID", DG_cantieri_new.CurrentRow.Index - 1).Value
        Catch
        End Try
        If N_ID = Nothing Then
            N_ID = 0
        End If
        Dim R_tmp As DS_clienti.DT_cantieri_newRow
        R_tmp = DirectCast(BS_clienti_new.Current, DataRowView).Row
        Dim risp As New MsgBoxResult
        risp = MsgBox("Vuoi eliminare il cliente " & R_tmp.societa & " Attenzione è definitivo", MsgBoxStyle.YesNo, "Conferma")
        'Se risponde si elimina e ricarica le tabelle
        If risp = MsgBoxResult.Yes Then
            If MsgBox("SEI ASSOLUTAMENTE SICURO DELL'ELIMINAZIONE DEL CLIENTE", MsgBoxStyle.YesNo, "ATTENZIONE") <> MsgBoxResult.Yes Then
                Return
            End If
            TA_cantieri_new.QR_Elimina(R_tmp.id)
            TA_locazione_new.QR_EliminaIDTerminale(R_tmp.id)   'Elimina tutte le destinazioni
            TA_cantieri_fe.QR_eliminapercliente(R_tmp.id)
            CaricaDati()
            Dim posizione As Integer = BS_clienti_new.Find("id", N_ID)
            BS_clienti_new.Position = posizione
            Dim n_rPos As Integer
            If N_ID > 0 Then
                For Each DG_rg In DG_cantieri_new.Rows
                    If DG_rg("C_id").value = N_ID Then
                        DG_cantieri_new.CurrentCell = DG_rg(1)
                        DG_cantieri_new.CurrentRow.Selected = True
                        Exit For
                    End If
                    n_rPos += 1
                Next
            End If
        End If


    End Sub


    Private Sub TTBTModifica_Click(sender As Object, e As EventArgs) Handles TTBTModifica.Click
        AttivaPulsanti(False)
        Dim ID_cli As Integer = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")
        Dim ff As New FRM_mod_cliente(Me.DS_clienti.DT_cantieri_new, BS_clienti_new, ID_cli)
        ff.ShowDialog()
    End Sub




    Private Sub LB_presenze_Click(sender As Object, e As EventArgs)
        Dim RGC As DS_clienti.DT_cantieri_newRow
        Dim unused = CambiaColore(LB_presenze)
        RGC = DirectCast(BS_clienti_new.Current, DataRowView).Row
        'Dim FFI As New FRM_inserimento_ore(Nothing, Periodolocale, RGC)
        'FFI.Show()
    End Sub
    <CodeAnalysis.SuppressMessage("Design", "CA1062:Convalidare gli argomenti di metodi pubblici", Justification:="<In sospeso>")>
    Async Function CambiaColore(Optional LBTMP As Label = Nothing) As Task
        Select Case True
            Case Not IsNothing(LBTMP)
                Dim oldTX As String = LBTMP.Text
                LBTMP.BackColor = Color.GreenYellow
                LBTMP.Text = "Caricando..."
                System.Windows.Forms.Application.DoEvents()
                System.Threading.Thread.Sleep(100)
                LBTMP.BackColor = Color.LightBlue
                LBTMP.Text = oldTX
            Case IsNothing(LBTMP)
                LL_anagrafica0.BackColor = Color.DarkRed
                TTTestoRicerca.BackColor = Color.DarkRed
                Await Task.Delay(1000).ConfigureAwait(False) ' due secondi
                LL_anagrafica0.BackColor = DefaultBackColor
                TTTestoRicerca.BackColor = Color.LightCyan
        End Select
        Return
    End Function

    Private Sub L_mobileCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles L_mobileCheckBox.CheckedChanged
        Dim RGC As DS_clienti.DT_cantieri_newRow
        RGC = DirectCast(BS_clienti_new.Current, DataRowView).Row
        L_mobileCheckBox.ImageIndex = If(L_mobileCheckBox.Checked, 1, 0)
        RGC.l_mobile = If(L_mobileCheckBox.Checked, 1, 0)

    End Sub

    '
    ' Quando viene cliccato il TAB 
    '
    Private Sub TB2_modificaTAB(sender As Object, e As EventArgs) Handles TAB_clienti.SelectedIndexChanged
        AggiornaRighe()
    End Sub

    Private Sub DG_documenti(ByVal sender As Object, ByVal e As DataGridViewCellCancelEventArgs)
        RELcantierefile.EndEdit()

        Dim o = Me.DS_clienti.DT_file.DataSet.HasChanges
        If o = True Then
            Dim RR As DS_clienti.DT_fileRow
            For Each _R In RELcantierefile

                RR = DirectCast(_R, DataRowView).Row
                If RR.RowState = DataRowState.Modified Then
                    TA_file.ModificaDescrizione(RR.descrizione, RR.file_id)
                    RR.AcceptChanges()
                End If
            Next
        End If

    End Sub
    Private Shared Function ControllaDirectory(ByVal DirectoridaControllare As String)
        Dim outFile As String = DirectoridaControllare
        Try
            If Not File.Exists(outFile) Then
                ' Create a file to write to. 
                Using sw As StreamWriter = File.CreateText(outFile)
                    sw.WriteLine("Verifica")
                    sw.WriteLine("di")
                    sw.WriteLine("Trasferimento")
                End Using
            End If

            ' Open the file to read from. 
            Using sr As StreamReader = File.OpenText(outFile)
                Do While sr.Peek() >= 0
                    Console.WriteLine(sr.ReadLine())
                Loop
            End Using
        Catch ex As Exception
            MsgBox("Non puoi proseguire perché non hai accesso alla cartella " & DirectoridaControllare)
            Return (False)
        End Try
        Return (True)
    End Function


    Private Shared Sub EliminaCartellaCliente(ByVal Cartella As String)
        Try
            My.Computer.FileSystem.DeleteDirectory(Cartella, FileIO.DeleteDirectoryOption.DeleteAllContents)
        Catch ex As Exception
            MsgBox("Problemi a Creare la cartella " & Cartella)
        End Try
    End Sub
    Private Sub Apreildocumento(sender As Object, e As DataGridViewCellEventArgs)
        Dim senderGrid As DataGridView
        senderGrid = DirectCast(sender, DataGridView)
        Dim Colonna As Object = Nothing
        Try
            Colonna = DirectCast(senderGrid(e.ColumnIndex, e.RowIndex), DataGridViewLinkCell)
        Catch ex As Exception

        End Try
        If Not IsNothing(Colonna) Then
            Dim RGff As DS_clienti.DT_fileRow
            Dim RGcat As DS_clienti.DT_categorieRow
            RGff = DirectCast(RELcantierefile.Current, DataRowView).Row
            RGcat = DirectCast(RELCantieriCategorie.Current, DataRowView).Row
            Dim Documento As String
            Documento = G_Directorypartenza & "\" & RGcat.dir_categoria_parent & "\" & RGcat.dir_categoria & "\" & RGff.file_titolo
            If File.Exists(Documento) = True Then
                Process.Start(Documento)
            Else
                MsgBox("non trovo il documento")
            End If
        End If
    End Sub

    Private Sub UserTextBox_TextChanged(sender As Object, e As EventArgs) Handles UserTextBox.LostFocus
        Dim RGtmp As DS_clienti.DT_cantieri_newRow
        If BS_clienti_new.Count > 0 Then
            BS_clienti_new.EndEdit()
            RGtmp = DirectCast(BS_clienti_new.Current, DataRowView).Row
            If RGtmp.RowState = DataRowState.Modified Then
                TA_cantieri_new.QR_modificaUtente(UserTextBox.Text, RGtmp.id)
                RGtmp.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub PwdTextBox_TextChanged(sender As Object, e As EventArgs) Handles PwdTextBox.LostFocus
        Dim RGtmp As DS_clienti.DT_cantieri_newRow
        If BS_clienti_new.Count > 0 Then
            BS_clienti_new.EndEdit()
            RGtmp = DirectCast(BS_clienti_new.Current, DataRowView).Row
            If RGtmp.RowState = DataRowState.Modified Then

                TA_cantieri_new.QR_modificapassword(PwdTextBox.Text, RGtmp.id)
                TA_cantieri_new.QRaggiornaPassword("&Gi$.:", RGtmp.id) 'Aggiorna la password Remota
                RGtmp.AcceptChanges()
            End If
        End If
    End Sub


    Private Shared Function CreaParametri()
        Dim Parametri As String
        Dim apici As String = """"
        Parametri = "{" & apici & "admin_style" & apici &
            ":" & apici & apici & "," & apici & "admin_language" & apici &
            ":" & apici & apici & "," & apici & "language" & apici &
            ":" & apici & apici & "," & apici & "editor" & apici &
            ":" & apici & apici & "," & apici & "timezone" & apici &
            ":" & apici & apici & "}"
        Return Parametri
    End Function


    Private Sub CaricaFattureRemote() Handles BT_caricamentoFatture.Click

        If BS_clienti_new.Count < 1 Then
            Return
        End If
        AggiungeDocumentialcliente()
    End Sub
    Private Sub AggiungeDocumentialcliente(Optional ByVal posizionefiles As String() = Nothing, Optional ByVal EliminaDoc As Boolean = False)
        'Assegna la riga Utente Remoto
        Dim RGrem As DS_clienti.DT_cantieri_newRow
        If BS_clienti_new.Count = 0 Then
            Return
        End If
        RGrem = DirectCast(BS_clienti_new.Current, DataRowView).Row

        Dim idRem As Integer = RGrem.id
        Dim Testonome As String
        Dim TestoAlias As String
        Dim TestoDesc As String
        Dim TestoEstensione As String
        Dim TestoSize As String
        Dim TestoData As DateTime

        Dim TestoPaths As String()
        Dim folderPath As String
        Dim TestoDestinazione As String
        Dim Info As FileInfo
        Dim CartellaDestinazione
        CartellaDestinazione = RGrem.societa.Replace(" ", "_").Replace(".", "_").Replace("#", "_").Replace("pdf", "_").Replace("-", "_").Replace(ControlChars.Quote, "").Replace(vbLf, "")

        If IsNothing(posizionefiles) Then
            OpenFileDialog1.Multiselect = True
            OpenFileDialog1.Filter = "Tutti i documenti del cliente (.*)|*" & RGrem.societa.Substring(0, If(RGrem.societa.Length > 5, 5, RGrem.societa.Length)) & "*.*" 'All files (*.*)|*.*"
            OpenFileDialog1.FileName = ""
            If Not OpenFileDialog1.ShowDialog() > 0 Then
                MsgBox("Nessun Documento selezionato")
                Return
            End If
            TestoPaths = OpenFileDialog1.FileNames
        Else
            ReDim TestoPaths(posizionefiles.Length)
            Dim xx As Integer = posizionefiles.Length
            For Each gg In posizionefiles
                'xx = 8
                TestoPaths(xx) = gg
                xx = xx - 1
            Next
        End If

        For Each TestoPath In TestoPaths
            folderPath = G_Directorypartenza & CartellaDestinazione
            If IsDBNull(TestoPath) Then
                Continue For
            End If
            If TestoPath = Nothing Then
                Continue For
            End If
            If TestoPath.Length < 1 Then
                Continue For
            End If
            Info = New FileInfo(TestoPath)
            If Not Info.Exists Then
                Continue For
            End If
            Testonome = TestoPath.Split("\").Last
            'Scrive come deve rappresentare il documento nella linea di descrizione
            TestoAlias = Testonome.Replace("#", "").Replace("pdf", "")
            TestoDesc = Testonome.Replace("#", "|").Replace(".", "").Replace("pdf", "")

            'Elimina tutti i caratteri compromettenti
            Testonome = Testonome.Replace(" ", "_").Replace(".", "_").Replace("#", "_").Replace("pdf", "_").Replace("-", "_") & Info.Extension
            TestoDestinazione = folderPath & "\" & Testonome

            TestoEstensione = Info.Extension
            TestoSize = ControllaeFormattaNumeri(Info.Length / 1000) & " KB"
            TestoData = Info.CreationTime

            'Sposta o copia il documento
            'Se il parametro l'ha passato la generazione delle Fatture, sposta direttamente il documento, altrimenti lavora in base alla CK_spostacopia

            If EliminaDoc Then
                My.Computer.FileSystem.MoveFile(TestoPath, TestoDestinazione, True)
            Else
                Try
                    If CK_spostacopia.CheckState = 0 Then
                        My.Computer.FileSystem.MoveFile(TestoPath, TestoDestinazione, True)
                    Else
                        My.Computer.FileSystem.CopyFile(TestoPath, TestoDestinazione, True)
                    End If
                    impostaPermessiFile(TestoDestinazione, "http")
                Catch ex As Exception
                    MsgBox("Problemi a registrare il documento " & TestoDestinazione)
                    Return
                End Try

            End If

            Dim newOrd As Integer = -1
            'Crea la Variabile DataRow per la tabella Documenti
            Dim R As DSwebcondiviso.DTfileRow
            R = Me.DSwebcondiviso.DTfile.Rows.Add()

            'Riferimento al nome del file (deve essere esattamente = al file)
            R.title = TestoAlias

            R.size = TestoSize
            R.data_creazione = Now()
            R.url_download = Testonome

            R.data_modifica = Now
            R.user_id = idRem
            R.user_access = idRem
            R.downloads = 0
            R.access = 7
            R.views = 0
            R.published = 1
            R.notes = ""
            R.id_tipo = G_tipologia

            'TODO   Impostare l'ordine dei file
            R.ordering = TAfile.SQultimoordine(idRem, G_tipologia) + 1 ' ordina numero di carico

            Dim MeseTrovato As String = CercaMeseNelFILE(TestoPath)
            Dim Periodo As Integer
            Periodo = TestoData.Month - 1
            Dim Anno As Integer
            Anno = TT_CB_anno.SelectedItem
            Select Case Periodo
                Case 0
                    Periodo = 12
                    Anno -= 1
            End Select
            R.cartella = CartellaDestinazione
            R.description = IIf(TestoPath.Contains("#"), "Fattura " & TestoPath.Split("\").Last.Substring(0, 9) & " relativa a ", "Documento relativo a ") & IIf(MeseTrovato <> Nothing, MeseTrovato, GlobalVarPOP.G_amese(Periodo - 1)) & " Anno " & Anno

            TAfile.inserisce(R.user_id, R.title, R.description, R.size, R.url_download, R.downloads, R.notes, R.views,
                             R.access, R.user_access, R.ordering, R.published, R.data_creazione, R.data_modifica, R.cartella, R.id_tipo, 0)
            'R.AcceptChanges()
        Next
        TAfile.FillByUtente(Me.DSwebcondiviso.DTfile, idRem, G_tipologia)
    End Sub
    Private Shared Function CercaMeseNelFILE(ByVal file As String)
        Dim Mese As String = Nothing
        For Each mm In GlobalVarPOP.G_amese
            If file.Contains(mm.ToLower) Then
                Mese = mm
                Exit For
            End If
        Next
        Return Mese
    End Function
    Private Sub DG_documentiRemoti_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_documentiRemoti.CellContentClick
        Dim senderGrid As DataGridView
        senderGrid = DirectCast(sender, DataGridView)

        Dim Colonna As Object = Nothing
        Dim RGff As DSwebcondiviso.DTfileRow

        Try
            Colonna = DirectCast(senderGrid(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell)
        Catch ex As Exception
            Try
                Colonna = DirectCast(senderGrid(e.ColumnIndex, e.RowIndex), DataGridViewLinkCell)
            Catch ex1 As Exception
            End Try
        End Try
        Select Case True

            Case TypeOf Colonna Is DataGridViewCheckBoxCell
                Dim stato As DataGridViewCheckBoxCell
                stato = Colonna
                stato.Value = If(stato.Value > 0, 0, 1)
                RGff = DirectCast(bsfiles.Current, DataRowView).Row
                TAfile.pubblica(CInt(stato.Value), RGff.id)
                RGff.AcceptChanges()
            Case TypeOf Colonna Is DataGridViewLinkCell
                RGff = DirectCast(bsfiles.Current, DataRowView).Row
                Dim Documento As String
                Documento = G_Directorypartenza & RGff.cartella & "\" & RGff.url_download
                If File.Exists(Documento) = True Then
                    Process.Start(Documento)
                Else
                    MsgBox("non trovo il documento")
                End If
            Case Else

        End Select

        If Not IsNothing(Colonna) Then
        End If

    End Sub
    Private Sub DG_documentiRemoti_CellValidate(sender As Object, e As DataGridViewCellEventArgs) Handles DG_documentiRemoti.CellValidated
        bsfiles.EndEdit()
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)

        Dim Cell As DataGridViewCell
        Cell = tmpDG(e.ColumnIndex, e.RowIndex)

        Select Case Cell.ColumnIndex
            Case DGWCtitolofile.Index
        End Select



        For Each RR As DSwebcondiviso.DTfileRow In Me.DSwebcondiviso.DTfile
            If RR.RowState = DataRowState.Modified Then
                Select Case Cell.ColumnIndex
                    Case DGWCtitolofile.Index
                        TAfile.modificadescrizioni(RR.title, RR.description, RR.notes, RR.id)
                        RR.AcceptChanges()
                    Case DGWCdescrizionefile.Index
                        TAfile.modificadescrizioni(RR.title, RR.description, RR.notes, RR.id)
                        RR.AcceptChanges()
                    Case DGWCordinefile.Index
                        TAfile.modificadescrizioni(RR.title, RR.description, RR.notes, RR.id)
                        RR.AcceptChanges()
                    Case DGWCpubblicatofile.Index
                        TAfile.pubblica(RR.published, RR.id)
                End Select
            End If
        Next


    End Sub

    Private Sub BT_eliminadocumentiRemoti_Click(sender As Object, e As EventArgs) Handles BT_eliminadocumentiRemoti.Click
        Dim rgCli As DS_clienti.DT_cantieri_newRow
        rgCli = DirectCast(BS_clienti_new.Current, DataRowView).Row

        If G_livello < 700 Then
            MsgBox("Non hai sufficienti diritti per eliminare il documento")
            Return
        End If

        Dim ceDG As DataGridViewCell
        Dim nID As Integer

        For Each rgDG As DataGridViewRow In DG_documentiRemoti.SelectedRows
            ceDG = rgDG.Cells(DGWCidfile.Index)
            nID = ceDG.Value
            Dim RGff = Me.DSwebcondiviso.DTfile.AsEnumerable.Where(Function(dr) dr("id").ToString = nID)
            Dim ido As Integer = RGff(0).id
            Dim Documento As String
            Documento = G_Directorypartenza & RGff(0).cartella & "\" & RGff(0).url_download
            If File.Exists(Documento) = True Then
                If MsgBox("Vuoi eliminare anche il documento abbinato?, l'eliminazione è irreversibile ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    File.Delete(Documento)
                    TAfile.elimina(RGff(0).id)
                Else
                    TAfile.elimina(RGff(0).id)
                    'RGff.Delete()
                End If
            Else
                If MsgBox("non trovo il documento, elimino il collegamento ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    TAfile.elimina(RGff(0).id)
                End If
            End If
        Next
        Me.TAfile.FillByUtente(Me.DSwebcondiviso.DTfile, rgCli.id, 2)
    End Sub

    Private Shared Function NewDToremese(ByRef Optional BStmp As DataTable = Nothing) As DataTable 'Crea una DT e la popola con i valori passati dal Datatable
        Dim Cli
        Cli = New DataTable
        Cli.Namespace = "TABtmp"
        Dim CliRow As DataRow
        Dim colonna As DataColumn
        colonna = New DataColumn
        colonna.ColumnName = "ordine"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_utente"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_cliente"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_dettaglio"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "anagrafica"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "societa"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dettaglio"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "lun"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "olun"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "mar"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "omar"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "mer"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "omer"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "gio"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "ogio"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "ven"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "oven"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "sab"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "osab"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dom"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "odom"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        Dim rgWeb As DS_clienti.DT_orariRow

        If Not IsNothing(BStmp) Then
            For Each hg In BStmp.Rows
                CliRow = Cli.NewRow
                rgWeb = DirectCast(hg, DataRow)
                CliRow("ordine") = 1
                CliRow("id_utente") = rgWeb.id_dip
                CliRow("anagrafica") = rgWeb.anagrafica
                CliRow("id_cliente") = rgWeb.Field(Of Integer)("id_cli")
                CliRow("societa") = rgWeb.Field(Of String)("societa")
                CliRow("id_dettaglio") = rgWeb.Field(Of Integer)("id_des")
                CliRow("dettaglio") = rgWeb.Field(Of String)("locazione")
                CliRow("lun") = TimeSpan.Parse(rgWeb.Field(Of String)("T_lu")).TotalHours
                CliRow("olun") = String.Format("{0} | {1}", rgWeb.Field(Of String)("lu_i"), rgWeb.Field(Of String)("lu_u"))
                CliRow("mar") = TimeSpan.Parse(rgWeb.Field(Of String)("T_ma")).TotalHours
                CliRow("omar") = String.Format("{0} | {1}", rgWeb.Field(Of String)("ma_i"), rgWeb.Field(Of String)("ma_u"))
                CliRow("mer") = TimeSpan.Parse(rgWeb.Field(Of String)("T_me")).TotalHours
                CliRow("omer") = String.Format("{0} | {1}", rgWeb.Field(Of String)("me_i"), rgWeb.Field(Of String)("me_u"))
                CliRow("gio") = TimeSpan.Parse(rgWeb.Field(Of String)("T_gi")).TotalHours
                CliRow("ogio") = String.Format("{0} | {1}", rgWeb.Field(Of String)("gi_i"), rgWeb.Field(Of String)("gi_u"))
                CliRow("ven") = TimeSpan.Parse(rgWeb.Field(Of String)("T_ve")).TotalHours
                CliRow("oven") = String.Format("{0} | {1}", rgWeb.Field(Of String)("ve_i"), rgWeb.Field(Of String)("ve_u"))
                CliRow("sab") = TimeSpan.Parse(rgWeb.Field(Of String)("T_sa")).TotalHours
                CliRow("osab") = String.Format("{0} | {1}", rgWeb.Field(Of String)("sa_i"), rgWeb.Field(Of String)("sa_u"))
                CliRow("dom") = TimeSpan.Parse(rgWeb.Field(Of String)("T_do")).TotalHours
                CliRow("odom") = String.Format("{0} | {1}", rgWeb.Field(Of String)("do_i"), rgWeb.Field(Of String)("do_u"))
                Cli.Rows.Add(CliRow)
            Next
        End If

        Return Cli
    End Function
    Private Function F_caricaValoriMese(ByVal dgwTMP As DataGridView, ByVal numeroMesi As Int16) As Boolean 'Carica i valori delle ore su tutto il mese
        Dim id_cliente = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")
        Dim Cli As New DataTable
        Using DT As New DS_clienti.DT_orariDataTable
            Using TA As New DS_clientiTableAdapters.TA_orari
                TA.FillByClienteDestinatariAttivi(DT, id_cliente)
            End Using
            Cli = NewDToremese(DT)
        End Using

        Dim ListaOrari = Cli.AsEnumerable().GroupBy(Function(row) New With {
            Key .id_utente = row.Field(Of Int32)("id_utente"),
            Key .anagrafica = row.Field(Of String)("anagrafica"),
            Key .id_dettaglio = row.Field(Of Int32)("id_dettaglio"),
            Key .dettaglio = row.Field(Of String)("dettaglio")
        })

        Dim CliRaggruppata = Cli.Clone() ' empty table with same columns
        Dim xx As Integer
        For Each grp In ListaOrari

            CliRaggruppata.Rows.Add(xx, grp.Key.id_utente, 0, grp.Key.id_dettaglio,
                                        grp.Key.anagrafica, "", grp.Key.dettaglio,
                                        grp.Sum(Function(row) row.Field(Of Decimal)("lun")),
                                        grp.Last.Field(Of String)("olun"),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("mar")),
                                        grp.Last.Field(Of String)("omar"),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("mer")),
                                        grp.Last.Field(Of String)("omer"),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("gio")),
                                        grp.Last.Field(Of String)("ogio"),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("ven")),
                                        grp.Last.Field(Of String)("oven"),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("sab")),
                                        grp.Last.Field(Of String)("osab"),
                                        grp.Sum(Function(row) row.Field(Of Decimal)("dom")),
                                        grp.Last.Field(Of String)("odom"))
            xx += 1
        Next



        Dim ListaOrari1 = Cli.AsEnumerable().GroupBy(Function(row) New With {
            Key .id_cliente = row.Field(Of Int32)("id_cliente")
        })
        'Qui fa il totale della riga
        CliRaggruppata.Rows.Add(99)
        For Each grp In ListaOrari1
            CliRaggruppata.Rows.Add(100, 0, 0, 0,
                                        "TOTALE", "Totale", "",
                                        grp.Sum(Function(row) row.Field(Of Decimal)("lun")), "",
                                        grp.Sum(Function(row) row.Field(Of Decimal)("mar")), "",
                                        grp.Sum(Function(row) row.Field(Of Decimal)("mer")), "",
                                        grp.Sum(Function(row) row.Field(Of Decimal)("gio")), "",
                                        grp.Sum(Function(row) row.Field(Of Decimal)("ven")), "",
                                        grp.Sum(Function(row) row.Field(Of Decimal)("sab")), "",
                                        grp.Sum(Function(row) row.Field(Of Decimal)("dom")), "")
        Next


        'Ordina la tabella per cliente e Giorno
        Dim TabellaOrdinata As New DataTable
        TabellaOrdinata = OrdinaTabella(CliRaggruppata, "ordine")
#If DEBUG Then
        For Each ggg In TabellaOrdinata.Rows
            Console.WriteLine(ggg.item("ordine"))
        Next
#End If
        Dim rg As DS_clienti.DT_calRow
        Dim NgiornoSettimana As Integer
        Dim Sgiornosettimana As String
        Dim Riga As Integer = 0
        dgwTMP.Rows.Clear()
        Dim BSsost As New BindingSource

        For Each RRorari In TabellaOrdinata.Rows 'inizia a ciclare le ore in base al cantiere e il dipendente nei giorni

            dgwTMP.Rows.Add()
            Dim iddet, iddip As Int16
            If RRorari.item("ordine") = 99 Then ' Salta una riga
                dgwTMP.Rows(dgwTMP.Rows.Count - 1).Height = 4

                For kspace = 0 To dgwTMP.Columns.Count - 1
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.Black
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    dgwTMP(kspace, Riga).Style = k
                Next
                Riga += 1
                Continue For
            End If
            iddet = RRorari.item("id_dettaglio")
            iddip = RRorari.item("id_utente")
            BSferiecliente.Filter = String.Format("id_det = {0}", iddet)
            Dim tmpFerie As Int16
            Dim periodoInizio, periodoFine As String
            If numeroMesi > 1 Then
                Dim timeTMP As DateTime
                timeTMP = DateSerial(PeriodoLocale.Split("-").First, PeriodoLocale.Split("-").Skip(1).First - 1, 1)
                periodoInizio = timeTMP.Year & timeTMP.Month.ToString.PadLeft(2, "0")
                timeTMP = DateSerial(PeriodoLocale.Split("-").First, PeriodoLocale.Split("-").Skip(1).First + 1, 1)
                periodoFine = timeTMP.Year & timeTMP.Month.ToString.PadLeft(2, "0")
            Else
                periodoInizio = PeriodoLocale.Replace("-", "")
                periodoFine = PeriodoLocale.Replace("-", "")
            End If

            Using TA As New DSfestivitaTableAdapters.TAutentisostituzioni   'Verifica la tabella delle sostituzioni
                Using DT As New DSfestivita.DTutentisostituzioniDataTable
                    TA.FillByDettaglioDaA(DT, iddet, periodoInizio, periodoFine)
                    BSsost.DataSource = DT 'Binding delle Sostituzioni
                End Using
            End Using
            Dim inizioferieU, fineferieU As DateTime
            inizioferieU = Nothing
            fineferieU = Nothing
            Using TA As New DSfestivitaTableAdapters.TAferieutente   'Verifica le Ferie del dipendente 
                Using DT As New DSfestivita.DTferieutenteDataTable
                    TA.FillByUtentePeriodo(DT, iddip, periodoInizio)
                    '
                    If DT.Rows.Count > 0 Then
                        inizioferieU = DT.Rows(0).Item("inizio")
                        fineferieU = DT.Rows(0).Item("fine")
                    End If
                End Using
            End Using




            Dim RFS As DSfestivita.DTferieclienteRow
            Dim inizioferieD, fineferieD As DateTime
            If BSferiecliente.Count > 0 Then
                RFS = DirectCast(BSferiecliente.Current, DataRowView).Row
                inizioferieD = RFS.inizio
                fineferieD = RFS.fine
            Else
                inizioferieD = Nothing
                fineferieD = Nothing
                tmpFerie = 0
            End If

            Dim i As Int16 = 1

            For Each l In BS_cal
                rg = DirectCast(l, DataRowView).Row
                NgiornoSettimana = (rg.giorno.DayOfWeek)
                Sgiornosettimana = {"dom", "lun", "mar", "mer", "gio", "ven", "sab"}(NgiornoSettimana)
                Dim NColMese As Integer = CInt(i)
                i += 1
                BSsost.Filter = String.Format("data = '{0}' AND idsost = {1}", rg.giorno.ToShortDateString, RRorari.item("id_utente"))
                Dim RGsos As DSfestivita.DTutentisostituzioniRow


                Dim anag, detta As String
                anag = RRorari.item("anagrafica") 'Scrive il Nome del Destinatario
                detta = RRorari.item("dettaglio")
                anag = anag.Substring(0, If(anag.Length >= 12, 12, anag.Length))
                detta = detta.Substring(0, If(detta.Length >= 20, 20, detta.Length))
                dgwTMP(0, Riga).Value = detta & "-" & anag
                dgwTMP(0, Riga).Tag = iddet
                Dim val As Decimal = CType(If(IsDBNull(RRorari.item(Sgiornosettimana)), 0, RRorari.item(Sgiornosettimana)), Decimal)
                Dim Tag As String = CType(If(IsDBNull(RRorari.item("o" & Sgiornosettimana)), "", RRorari.item("o" & Sgiornosettimana)), String)
                Tag = Tag & "|" & RRorari.item("id_utente")
                Dim totore As Decimal
                If val <> 0 Then
                    totore = RRorari.item(Sgiornosettimana)
                Else
                    totore = 0
                End If
                Select Case True
                    Case True
                End Select
                If RRorari.item("ordine") = 100 Then
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.White
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwTMP(NColMese, Riga).Style = k
                    dgwTMP(NColMese, Riga).Value = If(totore > 0, totore, "")

                ElseIf dgwTMP.Columns(NColMese).HeaderText = "FS" Then ' Se e una festivita allora Cambia il colore di sfondo
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.DeepSkyBlue
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwTMP(NColMese, Riga).Style = k
                    dgwTMP(NColMese, Riga).Value = "F " & If(totore > 0, totore, "")
                    dgwTMP(NColMese, Riga).Tag = Tag
                ElseIf BSsost.Count > 0 Then    'Se c'è una sostituzione
                    Dim k As New DataGridViewCellStyle

                    k.BackColor = Color.MediumSpringGreen   'Verde Primavera
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter


                    ' Se sono più di una sostituzione trovare bisogna
                    ' trovare il loop che gli permetta di ricalcolare
                    ' la riga della sostituzione

                    Dim Ttotore As TimeSpan = Nothing
                    For Each hh As DataRowView In BSsost
                        RGsos = DirectCast(hh, DataRowView).Row

                        Ttotore += (RGsos.usc - RGsos.ing)  'Aggiunge al totale il totale precedente
                        dgwTMP(NColMese, Riga).ToolTipText += RGsos.anagrafica & "/"
                        dgwTMP(NColMese, Riga).Value = If(Ttotore.TotalHours > 0, Ttotore.TotalHours, "")
                        dgwTMP(NColMese, Riga).Tag = Tag
                        If RGsos.anagrafica.Contains("XXX") Then
                            k.BackColor = Color.LightPink   'Rosa tenue
                        End If
                        dgwTMP(NColMese, Riga).Style = k

                    Next

                ElseIf rg.giorno >= inizioferieD And rg.giorno <= fineferieD And rg.giorno >= inizioferieU And rg.giorno <= fineferieU Then  'Se e' chiuso il cliente e manca anche il dipendente
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.DarkCyan  'Azzurro scuro
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwTMP(NColMese, Riga).Style = k
                    dgwTMP(NColMese, Riga).Value = ""
                    dgwTMP(NColMese, Riga).Tag = Tag
                ElseIf rg.giorno >= inizioferieD And rg.giorno <= fineferieD Then  'Se è chiuso il Dettaglio cliente
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.LightCyan  'Azzurro Chiaro
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwTMP(NColMese, Riga).Style = k
                    dgwTMP(NColMese, Riga).Value = ""
                    dgwTMP(NColMese, Riga).Tag = Tag
                ElseIf rg.giorno >= inizioferieU And rg.giorno <= fineferieU Then  'Se è in ferie il dipendente
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.DarkRed  'Verde Oli
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwTMP(NColMese, Riga).Style = k
                    dgwTMP(NColMese, Riga).Value = If(totore > 0, totore, "")
                    dgwTMP(NColMese, Riga).Tag = Tag
                Else
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = DefaultBackColor
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwTMP(NColMese, Riga).Style = k
                    dgwTMP(NColMese, Riga).Value = If(totore > 0, totore, "")
                    dgwTMP(NColMese, Riga).Tag = Tag
                End If

            Next
            Riga += 1
        Next
        BSferiecliente.RemoveFilter()
        Return True
    End Function


    Private Sub LL_Anagrafica0_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LL_AnagraficaFoglioPresenza.LinkClicked, LL_anagraficaWEB.LinkClicked, LL_anagrafica0.LinkClicked,
                                                                                                         LL_abbinamentoPresenzeRemote.LinkClicked, LL_anagrafica1.LinkClicked, LL_clienteFattura.LinkClicked,
                                                                                                         LL_ordini.LinkClicked, LLmacchinari.LinkClicked, llPreventivi.LinkClicked

        Dim ID_cli As Integer = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")
        Dim ff As New FRM_mod_cliente(Me.DS_clienti.DT_cantieri_new, BS_clienti_new, ID_cli)
        ff.ShowDialog()

    End Sub

    Private Sub ElencoClientiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElencoClientiToolStripMenuItem.Click
        Dim stp_frm As New FRM_stp_clienti(1)   'stampa solo gli attivi
        stp_frm.ShowDialog()
    End Sub

    Private Sub ElencoConPECToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElencoConPECToolStripMenuItem.Click
        Dim filtro As String
        filtro = BS_clienti_new.Filter
        Dim stp_frm As New FRMstpclienticonpec(filtro)   'stampa solo gli attivi
        stp_frm.ShowDialog()
    End Sub



    Private Sub BK_filtro_Click(sender As Object, e As ToolStripItemClickedEventArgs) Handles BK_filtro.DropDownItemClicked
        Dim o As ToolStripItem = e.ClickedItem
        Select Case o.Text
            Case "Attivi"
                CK_filtro.SetItemChecked(0, False)
                CK_filtro.SetItemChecked(1, True)
                CK_filtro.SetItemChecked(2, False)
                CK_filtro.SetItemChecked(3, False)

            Case "in scadenza"
                CK_filtro.SetItemChecked(0, False)
                CK_filtro.SetItemChecked(1, False)
                CK_filtro.SetItemChecked(2, False)
                CK_filtro.SetItemChecked(3, True)

            Case "Tutti"
                CK_filtro.SetItemChecked(0, True)
                CK_filtro.SetItemChecked(1, False)
                CK_filtro.SetItemChecked(2, False)
                CK_filtro.SetItemChecked(3, False)
            Case "Budget"
                CK_filtro.SetItemChecked(0, False)
                CK_filtro.SetItemChecked(1, False)
                CK_filtro.SetItemChecked(2, True)
                CK_filtro.SetItemChecked(3, False)
        End Select
        CK_filtro_controllo()
        AggiornaRighe()
    End Sub


    Friend rowIndexFromMouseDown As Int16       'Indice Riga quando il mouse viene messo in DOWN
    Friend dragBoxFromMouseDown As Rectangle    'Memorizza il rettangolo che delimita le righe

    Private Sub DGVdipendenti_mouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGVdipendenti.MouseDown
        rowIndexFromMouseDown = DGVdipendenti.HitTest(e.X, e.Y).RowIndex
        If Not rowIndexFromMouseDown = -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            dragBoxFromMouseDown = New Rectangle(New Point(e.X - (dragSize.Width / 2), e.Y - (dragSize.Height / 2)), dragSize)
        Else
            dragBoxFromMouseDown = Rectangle.Empty
        End If

    End Sub

    Private Sub DGVdipendenti_mouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGVdipendenti.MouseMove
        Dim f1 As MouseButtons
        f1 = e.Button
        Console.WriteLine(f1)
        If e.Button = MouseButtons.Left Then
            If Not dragBoxFromMouseDown = Rectangle.Empty And Not dragBoxFromMouseDown.Contains(e.X, e.Y) Then
                Dim idDip As Integer = DGVdipendenti.Rows(rowIndexFromMouseDown).Cells(DGVdipendenti_id.Index).Value
                Dim dropEffect As DragDropEffects = DGVdipendenti.DoDragDrop(idDip, DragDropEffects.Move)
            End If
        End If
    End Sub
    Private Sub DGVdipendenti_drogOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGVdipendenti.DragOver
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
    Private Sub DGVprogramma_mouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles DGVprogramma.MouseDown
        'Se prende il dato dal programma destinato per il cestino
        If Not IsDBNull(DGVprogramma.CurrentRow.Index) Then
            Dim idTMP As Integer = If(IsNothing(DGVprogramma(DGVprogramma.Columns("DGVProgrammaID").Index, DGVprogramma.CurrentRow.Index).Value), 0, DGVprogramma(DGVprogramma.Columns("DGVProgrammaID").Index, DGVprogramma.CurrentRow.Index).Value)
            DGVprogramma.DoDragDrop(idTMP, DragDropEffects.Copy)
        End If


    End Sub
    Private Sub DGVprogramma_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles DGVprogramma.DragDrop

        'Ottiene i dati di tipo string presenti in memoria
        Dim idDip As String = e.Data.GetData(GetType(Integer))
        If idDip < 0 Then
            Return
        End If
        Dim RG As DS_clienti.DT_AUDPRow
        Dim idCli As Integer
        Dim idDes As Integer
        Dim Dettaglio, Societa As String
        Dim RGcli As DS_clienti.DT_cantieri_newRow
        RGcli = DirectCast(BS_clienti_new.Current, DataRowView).Row
        idCli = RGcli.id
        idDes = DGV(DGViddes.Index, DGV.CurrentRow.Index).Value
        Dettaglio = DGV(DGVdettaglio.Index, DGV.CurrentRow.Index).Value
        Societa = RGcli.societa
        Dim controlloPresenza As Integer = 0
        If RELAUDP.Count > 0 Then
            RG = DirectCast(RELAUDP.Current, DataRowView).Row
            controlloPresenza = DT_AUDPTableAdapter.SQesistegia(idDip, RG.id_des)
        End If
        If controlloPresenza = 0 Then
            RELAUDP.AddNew()
            RG = DirectCast(RELAUDP.Current, DataRowView).Row
            RG.note = Dettaglio
            RG.id_dip = idDip
            RG.id_cli = idCli
            RG.inizio_abbinamento = Now()
            RG.fine_abbinamento = Now().AddDays(365)
            RG.societa = Societa
            RG.locazione = Dettaglio
            Dim RGdip As DS_utenti.DT_utentiRow
            RGdip = DirectCast(BSutenti.Current, DataRowView).Row
            RG.anagrafica = RGdip.Anagrafica
            Dim livelloaccesso As Integer = 5
            RELAUDP.EndEdit()
            DT_AUDPTableAdapter.inserisce(RG.id_dip, RG.id_cli, RG.id_des, RG.inizio_abbinamento, RG.fine_abbinamento, RG.note, livelloaccesso)
            RG.AcceptChanges()
            DT_AUDPTableAdapter.Fill(DS_clienti.DT_AUDP)
        Else
            MsgBox("Già presente")
        End If

        e.Effect = DragDropEffects.None
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

    Private Sub TX_RX_cliente_TextChanged(sender As Object, e As EventArgs) Handles TX_RX_cliente.TextChanged
        '
        'Ricerca il dipendente che deve essere abbinato al Dettaglio Cliente
        '
        Dim TMPTX As TextBox
        Dim ricerca As String
        TMPTX = DirectCast(sender, TextBox)
        ricerca = TMPTX.Text

        Dim S_oldFiltro As String = BSutenti.Filter
        Dim inizio As Int16 = InStrRev(S_oldFiltro, "ricerca LIKE")
        If inizio > 0 Then
            If S_oldFiltro.Length - inizio > 5 Then
                S_oldFiltro = S_oldFiltro.Remove(inizio - 6)
            Else
                S_oldFiltro = S_oldFiltro.Remove(inizio - 1)
            End If

        End If

        Dim T_fil As String = If(IsNothing(S_oldFiltro), "", S_oldFiltro)
        BSutenti.Filter = If(T_fil.Length > 0, T_fil & " AND ", "") & String.Format("ricerca LIKE '%{0}%'", ricerca)
        Dim NN As Integer = 0
        Do While BSutenti.Count < 1
            NN += 1
            If ricerca.Length() > 0 Then
                ricerca = TMPTX.Text.Substring(0, If(TMPTX.Text.Length() - NN <= 0, 0, TMPTX.Text.Length() - NN))
                BSutenti.Filter = If(T_fil.Length > 0, T_fil & " AND ", "") & String.Format("ricerca LIKE '%{0}%'", ricerca)
                TMPTX.Text = ricerca
                TMPTX.SelectionStart = TMPTX.Text.Length
                Dim unused = CambiaColore()
            Else
                Exit Do
            End If
        Loop
    End Sub

    Private Sub Test()
        Dim RG As DS_clienti.DT_cantieri_newRow
        RG = DirectCast(BS_clienti_new.Current, DataRowView).Row

        Dim pdfModello As String
        Dim pdfNuovo As String
        Dim posizionenuovo As String = ""
        Dim idSelezionato As Integer = RG.id

        If TrovaPosizione.SelectedPath = "" Then
            Return
        Else
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
                pdfNuovo = destinazione & "\" & RGlettere.nomefile & "_" & EliminaCaratteriSpeciali(RG.societa, True) & ".pdf"

                Dim inputPath As String = pdfModello
                Dim outputPath As String = pdfNuovo

                Using pdfReader As New iText.Kernel.Pdf.PdfReader(inputPath)

                    Using pdfWriter As New iText.Kernel.Pdf.PdfWriter(outputPath)
                        Using pdfDocument As New iText.Kernel.Pdf.PdfDocument(pdfReader, pdfWriter)
                            ' Ottieni l'oggetto PdfAcroForm dal documento
                            ' Altre operazioni sui campi AcroForm...
                            'Dim templatePage = pdfTemplateDocument.GetPage(1)
                            'Dim templateCanvas = New iText.Kernel.Pdf.Canvas.PdfCanvas(templatePage)

                            ' Ora puoi aggiungere il tuo contenuto personalizzato al template
                            ' Ad esempio, aggiungi un testo al centro della pagina
                            Dim acroForm As iText.Forms.PdfAcroForm = iText.Forms.PdfAcroForm.GetAcroForm(pdfDocument, True)
                            ' Esempio: imposta il valore di un campo di testo
                            acroForm.GetField("societa").SetValue(RG.societa)
                            acroForm.GetField("indirizzo").SetValue(RG.address)
                            acroForm.GetField("localita").SetValue(RG.postalcode.Trim & " " & RG.city.Trim & " " & RG._region.Trim)
                            acroForm.GetField("specifiche").SetValue("Uffici, servizi igienici, spogliatoi, reparto produttivo,magazzino")
                            acroForm.GetField("responsabile").SetValue(RG.title & " " & RG.first_name)
                            acroForm.GetField("destinazione").SetValue(RG.address.Trim & " " & RG.postalcode.Trim & " " & RG.city.Trim & " " & RG._region.Trim)
                            acroForm.GetField("dal").SetValue(Now().ToShortDateString)
                            acroForm.GetField("al").SetValue(Now().ToShortDateString)
                            acroForm.GetField("datadocumento").SetValue(Now().ToShortDateString)
                        End Using
                    End Using
                End Using
            Catch ex As iText.Kernel.Exceptions.PdfException
                ' Accedi ai dettagli dell'eccezione
                Dim errorMessage As String = ex.Message

                ' Accedi alle informazioni sull'errore nella causa dell'eccezione
                If ex.InnerException IsNot Nothing Then
                    errorMessage += vbCrLf & "Causa: " & ex.InnerException.Message
                End If

                ' Stampa i dettagli dell'errore
                Console.WriteLine("IOException in iText: " & errorMessage)
            Catch ex As Exception
                ' Gestisci altre eccezioni qui...
                Console.WriteLine("Errore generico: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub GeneraDocumento_Click(sender As Object, e As EventArgs) Handles BT_generadocumento.Click
        TrovaPosizione.SelectedPath = G_DirectoriModelliLettera
        Do While True
            If TrovaPosizione.SelectedPath <> "" Then

                Test()
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

    Private Sub CK_spostacopia_CheckedChanged(sender As Object, e As EventArgs) Handles CK_spostacopia.CheckedChanged
        If CK_spostacopia.Checked Then
            CK_spostacopia.ImageIndex = 12

            CK_spostacopia.Text = "Copia Documenti"
        Else
            CK_spostacopia.ImageIndex = 11
            CK_spostacopia.Text = "Sposta Documenti"
        End If
    End Sub
    Private Sub DG_Orari_CellContentClick(sender As Object, e As MouseEventArgs) Handles DG_orari.MouseClick
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MNU_orari.Show(New Point(MousePosition.X, MousePosition.Y))
        End If

    End Sub
    Private Sub P_orari(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles MNU_orari.ItemClicked

        Dim toolStrip = e.ClickedItem
        MNU_orari.Hide()

        'Prende la riga di Utenti
        Dim rg As DS_clienti.DT_cantieri_newRow
        rg = DirectCast(BS_clienti_new.Current, DataRowView).Row
        Dim idOre As Int32
        Try
            idOre = DG_orari.CurrentRow.Cells(0).Value
        Catch ex As Exception

        End Try

        'Prende la riga degli orari

        Dim dt As DataTable = New DS_utenti.DT_orariDataTable


        Using ta As New DS_utentiTableAdapters.TA_orari
            ta.FillByID(dt, idOre)
        End Using

        Select Case toolStrip.Name

            Case "MNU_orarioinserisce"
                Dim kr As DS_utenti.DT_orariRow
                kr = dt.NewRow
                kr.id = -1
                kr.id_dip = -1
                kr.id_cli = rg.id
                kr.id_des = -1
                dt.Rows.Add(kr)
                Dim f As New frmDipendentePianodiLavoro(-1, dt)
                f.ShowDialog()
                AggiornaRighe()

            Case "MNU_orariomodifica"
                'rgnew = dt.Rows(0)
                Dim f As New frmDipendentePianodiLavoro(idOre, dt)
                f.ShowDialog()
                AggiornaRighe()
            Case "MNU_orariocopia"      'copia e lo tiene in memoria
                'Dim rgMemoriaOrarioRiga As DS_clienti.DT_orariRow
                If DG_orari.Rows.Count = 0 Then
                    Return
                End If
                'Dim lista As EnumerableRowCollection
                Using ta As New DS_utentiTableAdapters.TA_orari
                    ta.FillByID(DS_utenti.DT_orari, idOre)
                End Using

                rgMemoriaOrarioRiga = Me.DS_utenti.DT_orari.NewRow()
                rgMemoriaOrarioRiga = DirectCast(DS_utenti.DT_orari.Rows(0), DataRow)
                rgMemoriaOrarioRiga.id = -1
                '
                MsgBox("Orario Copiato")

            Case "MNU_orarioincolla"    'incolla as un altro dipendente

                If IsNothing(rgMemoriaOrarioRiga) <> True Then
                    Dim j As DS_utenti.DT_orariRow = rgMemoriaOrarioRiga
                    If j.Isid_cliNull Then
                        Return
                    End If
                    TA_orari.QR_inserisce(j.id_dip, j.id_cli, j.id_des, j.lu_i, j.lu_u, j.ma_i, j.ma_u, j.me_i, j.me_u, j.gi_i, j.gi_u, j.ve_i, j.ve_u, j.sa_i, j.sa_u, j.do_i, j.do_u)
                    idOre = TA_orari.QRultimoID()

                    Dim f As New frmDipendentePianodiLavoro(idOre, dt)
                    f.ShowDialog()
                    AggiornaRighe()
                End If
            Case "MNU_orarioelimina"    'elimina
                If idOre > 0 Then
                    If MsgBox("Confermi eliminazione del Dettaglio n° " & idOre.ToString() & " ?", MsgBoxStyle.YesNo, "Eliminazione") = MsgBoxResult.Yes Then
                        TA_orari.QR_elimina(idOre)
                        AggiornaRighe()
                    End If
                End If
        End Select
        'CalcolaTotali()
    End Sub
    Private Sub VisualizzaAnteprimaFattura()
        'Carica il numero di fattura e visualizza l'Anteprima
        If BS_fatture.Count <= 0 Then
            Return
        End If
        Dim numFattura As String
        numFattura = DirectCast(BS_fatture.Current, DataRowView).Row.Field(Of String)("fat_num_da")
        Me.TA_fattura_tot.FillByFattura(Me.DS_fattura.DT_fattura_tot, numFattura)
        Me.TA_fattura_righe.FillByFattura(Me.DS_fattura.DT_fattura_righe, numFattura)
        Me.TA_fattura.FillByFattura(Me.DS_fattura.DT_fattura, numFattura)
        Me.LBForniturepresenti.RefreshReport()
    End Sub
    Private Sub DT_fattureDataGridView_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DG_fattura.CellValidating
        Dim senderGrid As DataGridView
        senderGrid = DirectCast(sender, DataGridView)
        Dim G_anno = TT_CB_anno.SelectedItem
        Dim RGC As DS_clienti.DT_cantieri_newRow
        RGC = DirectCast(BS_clienti_new.Current, DataRowView).Row
        Dim RGF As DS_clienti.DT_fattureRow
        RGF = DirectCast(BS_fatture.Current, DataRowView).Row
        Dim Cella As DataGridViewCell
        Cella = senderGrid(e.ColumnIndex, e.RowIndex)
        Dim idFattura As Integer
        idFattura = RGF.idfatturaunq
        Dim numFattura As String
        numFattura = RGF.fat_num_da
        Dim Obj As Object = e.FormattedValue

        Select Case senderGrid.Columns(e.ColumnIndex).Name
            Case Cscadenza.Name
                If TypeOf Cella Is DataGridViewTextBoxCell Then
                    'Verifica che la fattura non sia stata inviata allo SDI
                    If e.FormattedValue = DG_fattura(e.ColumnIndex, e.RowIndex).Value Then
                        Return
                    End If
                    If RGF.inviata = 1 Then
                        If MsgBox("Attenzione la fattura è già stata stampata in XML, proseguo ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            BS_fatture.CancelEdit()
                            e.Cancel = True
                            Return
                        End If
                        TA_fatture.QRinviata(0, RGF.idfatturaunq)
                    End If

                    Dim ValoreScadenza As Integer
                    Using TA As New DS_clientiTableAdapters.TA_pagamenti_new
                        ValoreScadenza = TA.SQritornaNumeroScadenza(RGC.pagamento)

                    End Using

                    Using TA As New DS_fatturaTableAdapters.TA_fattura
                        Dim NuovaScadenza As DateTime
                        Dim NuovaData As DateTime
                        NuovaData = CType(DG_fattura(Cdatafattura.Index, e.RowIndex).Value, DateTime)
                        NuovaScadenza = CType(e.FormattedValue, DateTime)
                        Dim nPa As Integer = RGC.pagamento
                        If NuovaScadenza < Nuovadata Then
                            NuovaScadenza = Nuovadata
                        End If
                        Try
                            Dim risp As Object

                            risp = TA.QR_modificadata(Nuovadata, NuovaScadenza, nPa, idFattura)
                            'Accetta i cambiamenti
                            BS_fatture.EndEdit()
                            RGF = DirectCast(BS_fatture.Current, DataRowView).Row
                            RGF.AcceptChanges()
                            'Cella.Value = Nuovadata
                            senderGrid(Cscadenza.Index, e.RowIndex).Value = NuovaScadenza
                            senderGrid(Cdatafattura.Index, e.RowIndex).Value = NuovaData
                            senderGrid(Cpagata.Index, e.RowIndex).Value = nPa
                        Catch ex As Exception
#If DEBUG Then
                            MsgBox(ex.Message)
#End If
                        End Try
                    End Using
                End If

            Case Cdatafattura.Name  'Data Fattura
                If TypeOf Cella Is DataGridViewTextBoxCell Then
                    'Verifica che la fattura non sia stata inviata allo SDI
                    If e.FormattedValue = DG_fattura(e.ColumnIndex, e.RowIndex).Value Then
                        Return
                    End If
                    If RGF.inviata = 1 Then
                        If MsgBox("Attenzione la fattura è già stata stampata in XML, proseguo ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            BS_fatture.CancelEdit()
                            e.Cancel = True
                            Return
                        End If
                        TA_fatture.QRinviata(0, RGF.idfatturaunq)
                    End If

                    Dim ValoreScadenza As Integer
                    Using TA As New DS_clientiTableAdapters.TA_pagamenti_new
                        ValoreScadenza = TA.SQritornaNumeroScadenza(RGC.pagamento)
                    End Using

                    Using TA As New DS_fatturaTableAdapters.TA_fattura
                        Dim Nuovadata As DateTime
                        Nuovadata = CType(e.FormattedValue, DateTime)
                        If Nuovadata = Nothing Then
                            Return
                        End If
                        Dim NuovaScadenza As DateTime
                        Dim nPa As Integer = RGC.pagamento
                        Dim UltimaData As DateTime
                        UltimaData = TA.SQultimaData(G_anno)

                        If Nuovadata < UltimaData Then
                            If MsgBox("Attenzione Esiste una fattura con una data più recente ! " & vbCr & "proseguo con questa data?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                Nuovadata = e.FormattedValue
                            Else
                                Nuovadata = TA.SQultimaData(G_anno)
                            End If
                        End If

                        If NuovaScadenza < Nuovadata Then
                            NuovaScadenza = Nuovadata
                        End If
                        Try
                            Dim risp As Object

                            risp = TA.QR_modificadata(Nuovadata, NuovaScadenza, nPa, idFattura)
                            'Accetta i cambiamenti
                            BS_fatture.EndEdit()
                            RGF = DirectCast(BS_fatture.Current, DataRowView).Row
                            RGF.AcceptChanges()
                            'Cella.Value = Nuovadata
                            senderGrid(Cscadenza.Index, e.RowIndex).Value = NuovaScadenza
                            senderGrid(Cdatafattura.Index, e.RowIndex).Value = Nuovadata
                        Catch ex As Exception
#If DEBUG Then
                            MsgBox(ex.Message)
#End If
                        End Try
                    End Using
                End If
            Case Cpagata.Name
                If TypeOf Cella Is DataGridViewCheckBoxCell Then
                    If e.FormattedValue = DG_fattura(e.ColumnIndex, e.RowIndex).Value Then
                        Return
                    End If
                    Dim RGfat As DS_clienti.DT_fattureRow
                    RGfat = DirectCast(BS_fatture.Current, DataRowView).Row
                    If e.FormattedValue = 0 And DG_fattura(e.ColumnIndex, e.RowIndex).Value = 1 Then
                        If MsgBox("Sicuro che vuoi annullare il pagamento?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            RGfat.fat_paga = 1
                            Return
                        Else
                            RGfat.fat_pa_dat = New DateTime(1900, 1, 1)
                            RGfat.fat_pa_des = ""
                            RGfat.fat_pa_imp = 0
                            BS_fatture.EndEdit()
                            'DG_fattura(Cfat_pa_des.Index, e.RowIndex).Selected = True
                            ColorarigaDG(DG_fattura, e.ColumnIndex, e.RowIndex, RGfat.fat_paga)
                        End If
                    Else
                        RGfat.fat_paga = 1
                        RGfat.fat_pa_dat = Now.ToShortDateString
                        RGfat.fat_pa_des = "BB"
                        RGfat.fat_pa_imp = RGfat.lordo.ToString("N2")
                        BS_fatture.EndEdit()
                        DG_fattura(Cfat_pa_des.Index, e.RowIndex).Selected = True
                        ColorarigaDG(DG_fattura, e.ColumnIndex, e.RowIndex, RGfat.fat_paga)
                    End If
                    AttivapulsantiFattura(False)
                End If

            Case COL_nc.Name  'Nota di Credito
                If TypeOf Cella Is DataGridViewCheckBoxCell Then
                    If e.FormattedValue = DG_fattura(e.ColumnIndex, e.RowIndex).Value Then
                        Return
                    End If
                    If RGF.inviata = 1 Then
                        If MsgBox("Attenzione la fattura è già stata stampata in XML, proseguo ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            BS_fatture.CancelEdit()
                            e.Cancel = True
                            Return
                        End If
                        TA_fatture.QRinviata(0, RGF.idfatturaunq)
                        RGF.inviata = 0
                        BS_fatture.EndEdit()
                        RGF = DirectCast(BS_fatture.Current, DataRowView).Row
                        RGF.AcceptChanges()
                    End If

                    Using TA As New DS_clientiTableAdapters.TA_fatture
                        Dim NC As Integer
                        NC = IIf(e.FormattedValue, 1, 0)
                        BS_fatture.EndEdit()
                        RGF = DirectCast(BS_fatture.Current, DataRowView).Row
                        RGF.fat_nc = NC
                        TA.QR_notadicredito(NC, RGF.fat_num_da)
                        RGF.AcceptChanges()
                    End Using
                End If


        End Select

    End Sub
    Private Sub AttivapulsantiFattura(ByVal attivo As Boolean)
        Dim Lattivo As Boolean
        Lattivo = attivo
        If TAB_clienti.SelectedTab.Name = TB_fattureclienti.Name Then
            TTBTconfermapagamenti.Visible = Not Lattivo
            TTBTannullapagamenti.Visible = Not Lattivo
        End If
        TTBTAggiunge.Visible = Lattivo
        TTBTRicalcolaperFatture.Visible = Lattivo
        TTBTElimina.Visible = Lattivo
        TTBTModifica.Visible = Lattivo
        TTBTSalva.Visible = Lattivo
        BindingNavigatorMoveFirstItem.Visible = Lattivo
        BindingNavigatorMoveLastItem.Visible = Lattivo
        BindingNavigatorMoveNextItem.Visible = Lattivo
        BindingNavigatorMovePreviousItem.Visible = Lattivo
        TTBTStampa.Visible = Lattivo
        TX_RX_cliente.Visible = Lattivo
        TTTestoRicerca.Visible = Lattivo
        BindingNavigatorPositionItem.Visible = Lattivo
        BK_filtro.Visible = Lattivo
        BindingNavigatorCountItem.Visible = Lattivo
        TTPB.Visible = Lattivo
        BindingNavigatorSeparator.Visible = Lattivo
        BindingNavigatorSeparator1.Visible = Lattivo
        BindingNavigatorSeparator2.Visible = Lattivo
        TT_CB_anno.Visible = Lattivo
        TT_CB_mese.Visible = Lattivo
    End Sub
    Private Sub DT_fattureDataGridView_CellFormatting(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DG_fattura.CellFormatting
        For i As Integer = 0 To Me.DG_fattura.Rows.Count - 1
            Dim valTot As Integer
            If Not IsDBNull(Me.DG_fattura.Rows(i).Cells("C_totale").Value) Then
                valTot = Me.DG_fattura.Rows(i).Cells("C_totale").Value
            Else
                valTot = 0
            End If

            If valTot < 0 Then
                For T = 0 To DG_fattura.Columns.Count - 1
                    Me.DG_fattura.Rows(i).Cells(T).Style.ForeColor = Color.Red
                Next
            End If
        Next
    End Sub
    Private Shared Sub ColorarigaDG(ByVal nomeGriglia As DataGridView, ByVal numeroColonna As Integer, ByVal numeroRiga As Integer, Optional ByVal attivo As Boolean = True)
        Dim Col As Color
        If attivo Then
            Col = Color.DarkOrange
        Else
            If numeroRiga > 0 Then
                Col = Color.White
                Dim PreCol = nomeGriglia(numeroColonna, numeroRiga - 1).Style.BackColor

                If PreCol = Col Then
                    Col = Color.LightSlateGray
                End If
            End If
        End If
        For T = 0 To nomeGriglia.Columns.Count - 1
            nomeGriglia(T, numeroRiga).Style.BackColor = Col
        Next

    End Sub


    Private Sub DG_Fattura_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_fattura.CellContentClick
        'Legge se hai premuto sul LinkedCell e ti apre la fattura
        Dim senderGrid As DataGridView
        Try
            senderGrid = DirectCast(sender, DataGridView)
        Catch ex As Exception
            Return
        End Try
        Dim G_anno = TT_CB_anno.SelectedItem
        Dim RGC As DS_clienti.DT_cantieri_newRow
        RGC = DirectCast(BS_clienti_new.Current, DataRowView).Row
        Dim RG As DS_clienti.DT_fattureRow
        RG = DirectCast(BS_fatture.Current, DataRowView).Row
        Dim Cella As DataGridViewCell
        Cella = senderGrid(e.ColumnIndex, e.RowIndex)
        'Visualizza l'anteprima della fattura
        'VisualizzaAnteprimaFattura(RG.fat_num_da)
        Select Case e.ColumnIndex
            Case 1
                If TypeOf Cella Is DataGridViewLinkCell Then
                    If RG.inviata = 1 Then
                        If MsgBox("Attenzione la fattura è già stata stampata in XML, proseguo ?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                            Return
                        End If
                        TA_fatture.QRinviata(0, RG.idfatturaunq)
                    End If
                    Dim DRtmp As DataGridViewRow = DG_fattura.CurrentRow
                    'Dim vecchio As Decimal = DRtmp.Cells.Item(5).Value
                    Dim f As New FrmFatturaDettaglio(RG.fat_num_da, RGC, PeriodoLocale, DRtmp)
                    f.ShowDialog()
                    TA_fatture.FillByID_cli(DS_clienti.DT_fatture, G_anno, RGC.id)
                End If
        End Select

    End Sub
    Private Sub DGFattura(sender As Object, e As MouseEventArgs) Handles DG_fattura.Click
        'se hai premuto il click sinistro su cmd_stampa ti propone il menù di stampa
        If e.Button = Windows.Forms.MouseButtons.Right Then
            MNU_fatturazione.Show(New Point(MousePosition.X, MousePosition.Y))
        End If
    End Sub
    Private Sub FatturazioneMenu(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles MNU_fatturazione.ItemClicked
        If TAB_clienti.SelectedTab.Name <> TB_fattureclienti.Name Then
            Return
        End If
        Dim menu As ContextMenuStrip
        menu = DirectCast(sender, ContextMenuStrip)
        Select Case e.ClickedItem.Name
            Case MNAggiungeNuovaFattura.Name
                AggiungeNuovaFattura()
                'Crea il PDF e lo pubblica direttamente
            Case MNGeneraIlPDFEPubblicalo.Name
                'Dim id As Integer   ' id Fattura
                Dim fn As String    ' numero Fattura
                Me.FolderBrowserDialog1.ShowDialog()
                Dim posizione As String = FolderBrowserDialog1.SelectedPath

                Dim x As Int16 = 0
                Dim AIDfattura(DG_fattura.SelectedRows.Count - 1) As String

                For Each tmpID As DataGridViewRow In DG_fattura.SelectedRows
                    AIDfattura(x) = tmpID.Cells(1).Value                                                                        'NumeroFattura
                    x += 1
                Next

                Dim FattureGenerate(AIDfattura.Count - 1) As String
                'Return
                For H = 0 To AIDfattura.Count - 1   ' Inverte la processione delle fatture per metterle in ordine inverso
                    'Scorre le righe selezionate
                    'id = rgdg.Cells(0).Value
                    fn = AIDfattura(H) 'NumeroFattura
                    'Return

                    If BS_fatture.Count > 0 Then
                        Using DTFattura As New DS_fattura.DT_fatturaDataTable
                            Using TaFattura As New DS_fatturaTableAdapters.TA_fattura
                                TaFattura.FillByFattura(DTFattura, fn)                                              'carica la fattura specifica
                            End Using
                            Dim DTtotale As New DS_fattura.DT_fattura_totDataTable
                            Dim DTrighe As New DS_fattura.DT_fattura_righeDataTable
                            Using TaTotale As New DS_fatturaTableAdapters.TA_fattura_tot
                                TaTotale.FillByFattura(DTtotale, fn)                                                'carica la riga totali specifica
                            End Using
                            Using TArighe As New DS_fatturaTableAdapters.TA_fattura_righe
                                TArighe.FillByFattura(DTrighe, fn)                                                  'carica le righe della fattura specifiche
                            End Using
                            Dim BSfattura As New BindingSource
                            Dim BSrighe As New BindingSource
                            Dim BStotale As New BindingSource

                            'Assegna un binding ad ogni Datatableview per la stampa

                            BSfattura.DataMember = DTFattura.TableName
                            BSfattura.DataSource = DTFattura
                            BStotale.DataMember = DTtotale.TableName
                            BStotale.DataSource = DTtotale
                            BSrighe.DataMember = DTrighe.TableName
                            BSrighe.DataSource = DTrighe

                            Dim stampa As New FRM_stp_fattura(fn, "fattura", PeriodoLocale, posizione)              'avvia la procedura di stampa PDF della fattura specifica
                            stampa.ShowDialog()
                            Dim nomeFile As String = stampa.nomefileFatturaGenerata                             'Memorizza il nome della fattura generata

                            'nomeFile = EliminaCaratteriSpeciali(nomeFile)
                            FattureGenerate(H) = posizione & "\" & nomeFile & ".pdf"
                            If DG_fattura.SelectedRows.Count = 1 Then
                                If MsgBox("Apro la fattura generata ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    Process.Start(posizione & "\" & nomeFile & ".pdf")
                                End If
                            End If
                        End Using
                    Else
                        Return
                    End If
                    x += 1
                Next
                If MsgBox("Pubblico direttamente i documenti", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    AggiungeDocumentialcliente(FattureGenerate, True)
                End If
            Case MNStampaLaFattura.Name
                Dim RGFattura As DS_clienti.DT_fattureRow
                RGFattura = DirectCast(BS_fatture.Current, DataRowView).Row
                Dim stampa As New FRM_stp_fattura(RGFattura.fat_num_da, "fattura", PeriodoLocale,, 1)
                stampa.ShowDialog()
            Case MNUGeneraXMLFatturaElettronica.Name

                FolderBrowser.ShowNewFolderButton = True
                FolderBrowser.ShowDialog()
                Dim Path As String = FolderBrowser.SelectedPath
                If Path = Nothing Then
                    Return
                End If
                Dim Cli As DS_clienti.DT_cantieri_newRow
                Cli = DirectCast(BS_clienti_new.Current, DataRowView).Row

                Dim id As Integer   ' id Fattura
                Dim fn As String    ' numero Fattura
                Dim RGFattura As DS_clienti.DT_fattureRow
                'RGFattura = DirectCast(BS_fatture.Current, DataRowView).Row
                For Each rgdg As DataGridViewRow In DG_fattura.SelectedRows
                    id = rgdg.Cells(0).Value
                    fn = rgdg.Cells(1).Value
                    '                    id = RGFattura.idfatturaunq
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

                    Dim RWtrasmittente As DataRow
                    Using TA As New DS_FETableAdapters.TA_trasmittente
                        Using DT As New DS_FE.DT_trasmittenteDataTable
                            TA.Fill(DT)
                            RWtrasmittente = DT.Rows(0)
                        End Using

                    End Using
                    '
                    'Crea la fattura nuova in XML
                    '
                    creaFE.nuova(RWtrasmittente, Fat, Rig, Path)

                    'Segna come inviata la fattura llo SDI
                    TA_fatture.QRinviata(1, id)
                    'Cerca la fattura numero e la imposta come se fosse stata stampata
                    BS_fatture.Position = BS_fatture.Find("idfatturaunq", id)
                    RGFattura = DirectCast(BS_fatture.Current, DataRowView).Row
                    RGFattura.inviata = 1
                    BS_fatture.EndEdit()
                    RGFattura.AcceptChanges()

                Next


        End Select
    End Sub
    Private Sub AggiungeNuovaFattura()
        Dim nuovoID As Integer
        Dim NuovaData As DateTime
        Dim G_anno = TT_CB_anno.SelectedItem
        Dim RGC As DS_clienti.DT_cantieri_newRow
        RGC = DirectCast(BS_clienti_new.Current, DataRowView).Row
        Dim ValoreScadenza As Integer
        Using TA As New DS_clientiTableAdapters.TA_pagamenti_new
            ValoreScadenza = TA.SQritornaNumeroScadenza(RGC.pagamento)
        End Using
        Using DT As New DS_fattura.DT_fatturaDataTable
            Using TA As New DS_fatturaTableAdapters.TA_fattura
                nuovoID = TA.SQnuovoID(G_anno)
                NuovaData = TA.SQultimaData(G_anno)
                Dim RG As DataRow = DT.NewRow()
                Dim nID As Integer = nuovoID + 1
                Dim nCl As Integer = RGC.id
                Dim nIv As Integer = 0
                Dim nPa As Integer = RGC.pagamento
                Dim bPa As Integer = 0
                RG("fat_con_l") = RGC.condomino
                RG("fat_data") = NuovaData
                RG("fat_nc") = 0
                RG("fat_num_da") = (nuovoID + 1).ToString.PadLeft(4, "0") & "/" & G_anno
                Dim dPa As DateTime = New DateTime(1900, 1, 1)
                RG("fat_pa_des") = ""
                RG("fat_pa_fallimento") = 0
                RG("fat_pa_imp") = 0
                RG("fat_scad") = DateSerial(NuovaData.AddDays(ValoreScadenza).Year, NuovaData.AddDays(ValoreScadenza).Month, 0)
                If RG("fat_scad") < RG("fat_data") Then
                    RG("fat_scad") = RG("fat_data")
                End If
                RG("partitaiva") = RGC.partitaiva
                RG("codiceunico") = Now
                Try
                    Dim risp As Object
                    risp = TA.QR_inserisce(nID, RG("fat_num_da"), nCl, RG("fat_data"),
                                            RG("fat_scad"), bPa, dPa, RG("fat_pa_des"),
                                            RG("fat_con_l"), RG("fat_pa_imp"), nIv, RG("codiceunico"), nPa)

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            End Using
        End Using
        TA_fatture.FillByID_cli(DS_clienti.DT_fatture, G_anno, RGC.id)

    End Sub
    Private Sub DG_cantieri_new_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DG_cantieri_new.CellValidating

        Dim id As Integer = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")
        If e.RowIndex >= 0 Then
            Select Case DG_cantieri_new.Columns(e.ColumnIndex).Name
                Case COLcantattivo.Name
                    TA_cantieri_new.ModificaAttivo(If(e.FormattedValue, 1, 0), id)
                Case BudgetDataGridViewTextBoxColumn.Name
                    TA_cantieri_new.ModificaBudget(If(e.FormattedValue, 1, 0), id)
            End Select
        End If

    End Sub


    Private Sub DG_cantieri_new_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_cantieri_new.CellContentClick
        Dim Cella As DataGridViewCell
        Dim Griglia As DataGridView
        Griglia = DirectCast(sender, DataGridView)

        Dim id As Integer = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")

        If e.RowIndex >= 0 Then
            Cella = Griglia(e.ColumnIndex, e.RowIndex)
            Select Case Cella.GetType()
                Case GetType(DataGridViewLinkCell)
                    'Dim H As New FRMmail(Cella.Value)
                    'H.Show()
            End Select
        End If
    End Sub

    Private Sub BT_mailcredenziali_Click(sender As Object, e As EventArgs) Handles BT_mailcredenziali.Click
        Dim RGC As DS_clienti.DT_cantieri_newRow
        RGC = DirectCast(BS_clienti_new.Current, DataRowView).Row
        Dim userremoto As String = RGC.user
        'Dim userlocale As String = RGC.user
        Dim pwdlocale As String = RGC.pwd

        Dim indirizzoMail As String
        indirizzoMail = RGC.email_name
        Dim Testo As String
        Testo = "Gentilissimo " & RGC.title & " " & RGC.first_name & vbCr &
                "Qui sotto troverà l'indirizzo e le credenziali di accesso al nostro portale internet" & vbCr & vbCr &
                "".PadRight(30, "_") & vbCr &
                "URL: https://pulizieuffici.biz" & vbCr &
                "USR: " & userremoto & vbCr &
                "PSW: " & RGC.pwd & vbCr &
                "".PadRight(30, "_") & vbCr &
                vbCr & vbCr &
                "Cordiali Saluti" & vbCr
        If indirizzoMail.Length > 4 Then
            'Dim H As New FRMmail(indirizzoMail, "Credenziali accesso Portale", Testo)
            'H.Show()
        End If
    End Sub

    Private Sub DGordini_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGordini.CellContentClick
        Dim Cella As DataGridViewCell
        Cella = sender(e.ColumnIndex, e.RowIndex)
        If TypeOf Cella Is DataGridViewLinkCell Then
            If Cella.ColumnIndex = 0 Then
                Dim f As New FrmOrdineMateriale(Cella.Value)
                f.ShowDialog()
            End If
        ElseIf TypeOf Cella Is DataGridViewCheckBoxCell Then
            If Cella.ColumnIndex = 4 Then
            End If
        End If
    End Sub
    Private Sub DGordini_CellBeginEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGordini.CellEndEdit
        Dim Cella As DataGridViewCell
        Cella = sender(e.ColumnIndex, e.RowIndex)
        If TypeOf Cella Is DataGridViewLinkCell Then
            Dim Col As Integer
            Col = DGordini.Columns("COLanagraficaFornitore").Index
            If Cella.ColumnIndex = Col Then
                Dim f As New FrmProdotti(Cella.Value)

                f.ShowDialog()
            End If
        ElseIf TypeOf Cella Is DataGridViewCheckBoxCell Then
            Dim Col As Integer
            Col = DGordini.Columns("COLlocazione").Index
            If Cella.ColumnIndex = Col Then

            End If
        ElseIf TypeOf Cella Is DataGridViewComboBoxCell Then    'Se scegli il prodotto
            Dim Col As Integer
            Col = DGordini.Columns("COLanagraficaFornitore").Index
            If Cella.ColumnIndex = Col Then
                Dim tipo As Type
                tipo = sender(DGordini("COLlocazione", e.RowIndex).ColumnIndex, e.RowIndex).value.GetType
                If tipo <> GetType(Int32) Then
                    Dim tipoF As Type
                    tipoF = sender(DGordini("COLanagraficafornitore", e.RowIndex).ColumnIndex, e.RowIndex).value.GetType
                    If tipoF <> GetType(Int32) Then
                        BSordini.CancelEdit()
                        DGordini.CancelEdit()
                        Return
                    Else
                        MsgBox("devi prima inserire il destinatario dell'ordine")
                        DGordini.CurrentCell = DGordini(DGordini.Columns("COLlocazione").Index, e.RowIndex)
                    End If
                End If
                Dim RGo As DS_Ordini.DT_ordiniRow   'Prende la riga dell'ordine
                RGo = DirectCast(BSordini.Current, DataRowView).Row

                Dim RGc As DS_clienti.DT_cantieri_newRow  'prende la riga delle righe ordine
                RGc = DirectCast(BS_clienti_new.Current, DataRowView).Row

                sender(DGordini("COLdataordine", e.RowIndex).ColumnIndex, e.RowIndex).value = Now()
                sender(DGordini("COLnote", e.RowIndex).ColumnIndex, e.RowIndex).value = ""
                RGo.id_cliente = RGc.id
            End If
        ElseIf TypeOf Cella Is DataGridViewTextBoxCell Then

        End If
    End Sub

    Private Sub DGordini_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGordini.RowValidating
        'Valida la riga inserita

        If e.RowIndex < 0 Then
            Return
        End If
        Dim DG As DataGridView
        DG = DirectCast(sender, DataGridView)

        If e.ColumnIndex = DG.Columns("COLanagraficaFornitore").Index Then
            If DG.CurrentCell.Value.GetType <> GetType(Int32) Then
                MsgBox("Devi inserire almeno un fornitore")
                DGordini.CancelEdit()
                e.Cancel = True
            Else
                BSordini.EndEdit()
                e.Cancel = False
            End If
        End If
        If e.ColumnIndex = DG.Columns("COLlocazione").Index Then
            If DG.CurrentCell.Value.GetType <> GetType(Int32) Then
                MsgBox("Devi inserire almeno un dettaglio Cliente")
                DGordini.CancelEdit()
                e.Cancel = True
            Else
                BSordini.EndEdit()
                e.Cancel = False
            End If
        End If
    End Sub

    Private Sub BSordini_listChange(sender As Object, e As System.ComponentModel.ListChangedEventArgs) Handles BSordini.ListChanged
        Dim RGo As DS_Ordini.DT_ordiniRow  'prende la riga delle righe ordine

        If BSordini.Count > 0 Then
            RGo = DirectCast(BSordini.Current, DataRowView).Row
            If RGo.Isid_fornitoreNull Then
                MsgBox("Devi inserire almeno un fornitore")
            ElseIf RGo.Isid_locazioneNull Then
                MsgBox("Devi inserire almeno una locazione")
            End If
            Dim idWebOrdine As Int16
            idWebOrdine = IIf(RGo.Isid_webordiniNull, Nothing, RGo.id_webordini)
            Select Case RGo.RowState
                Case DataRowState.Added
                    Dim nuovoID As Integer
                    Using TA As New DS_OrdiniTableAdapters.TA_ordini
                        Dim xID
                        xID = TA.SQnuovoID()
                        TA.QR_Inserisce(xID, RGo.id_cliente, RGo.id_locazione, RGo.id_fornitore, 25, RGo.data_ordine, RGo.annotazioni, G_idAZ, 0, Now(), idWebOrdine)
                        nuovoID = TA.SQultimoID()
                    End Using
                    RGo.id = nuovoID
                    RGo.AcceptChanges()
                Case DataRowState.Modified

                    Using TA As New DS_OrdiniTableAdapters.TA_ordini
                        TA.QR_Modifica(RGo.id_cliente, RGo.id_locazione, RGo.id_fornitore, 25, RGo.data_ordine, G_idAZ, RGo.annotazioni, RGo.i_inviato, RGo.d_inviato, idWebOrdine, RGo.id)
                    End Using
                    RGo.AcceptChanges()
            End Select
        End If
    End Sub
    Private Sub DT_ordiniDataGridView_UserDeleting(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DGordini.UserDeletingRow

        If BSordini.Count > 0 Then
            Dim a As Integer = e.Row.Cells("COLidordini").Value
            If MsgBox("Confermi l 'eliminazione dell'Ordine n° ?" & a.ToString, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Using TA As New DS_OrdiniTableAdapters.TA_ordini
                    TA.QR_EliminaID(a)
                End Using
                Using TA As New DS_OrdiniTableAdapters.TA_ordinirighe
                    TA.QR_eliminaOrdine(a)
                End Using
            Else
                e.Cancel = True
            End If
        End If

    End Sub


    Private Sub TTBTconfermapagamenti_Click(sender As Object, e As EventArgs) Handles TTBTconfermapagamenti.Click
        If TAB_clienti.SelectedTab.Name = TB_fattureclienti.Name Then
            Dim RGcl As DS_clienti.DT_cantieri_newRow
            RGcl = DirectCast(BS_clienti_new.Current, DataRowView).Row
            Dim idCli As Integer = RGcl.id
            If MsgBox("Confermi il salvataggio dei pagamenti ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim RGft As DS_clienti.DT_fattureRow
                For Each RG As DataRowView In BS_fatture
                    RGft = DirectCast(RG, DataRowView).Row
                    Select Case RGft.RowState
                        Case DataRowState.Modified
                            TA_fatture.QRaggiornapagamento(RGft.fat_paga, RGft.fat_pa_dat, RGft.fat_pa_des, RGft.fat_pa_imp, RGft.idfatturaunq)
                            RGft.AcceptChanges()
                    End Select
                Next
            End If
            aggiornaFattureCliente(DirectCast(BS_clienti_new.Current, DataRowView))
            AttivapulsantiFattura(True)
        End If
    End Sub
    Private Sub aggiornaFattureCliente(ByVal Cli As DataRowView)
        If TAB_clienti.SelectedTab.Name <> TB_fattureclienti.Name Then
            Return
        End If
        Dim RRll As DS_clienti.DT_cantieri_newRow
        RRll = DirectCast(Cli, DataRowView).Row
        LL_clienteFattura.Text = RRll.societa
        Dim anno As Integer
        anno = TT_CB_anno.SelectedItem.ToString
        TA_fatture.FillByID_cli(DS_clienti.DT_fatture, anno, RRll.id)
        Dim totimp As Decimal = 0
        Dim totiva As Decimal = 0
        Dim totpag As Decimal = 0
        Dim totdap As Decimal
        Dim FRG As DS_clienti.DT_fattureRow
        For Each _frg In BS_fatture
            FRG = DirectCast(_frg, DataRowView).Row
            totimp = totimp + (FRG.totale * If(FRG.fat_nc = 0, 1, -1))
            totiva = totiva + (FRG.imposta * If(FRG.fat_nc = 0, 1, -1))
            totpag = totpag + FRG.fat_pa_imp
        Next
        totdap = totimp + totiva - totpag
        LB_imponibile_r.Text = totimp.ToString("N2")
        LB_imposta_r.Text = totiva.ToString("N2")
        LB_pagato_r.Text = totpag.ToString("N2")
        LB_dapagare_r.Text = totdap.ToString("N2")
        AggiornaTotaliFatturato()
        AttivapulsantiFattura(True)
    End Sub

    Private Sub TTBTannullapagamenti_Click(sender As Object, e As EventArgs) Handles TTBTannullapagamenti.Click
        If TAB_clienti.SelectedTab.Name <> TB_fattureclienti.Name Then
            Return
        End If
        aggiornaFattureCliente(DirectCast(BS_clienti_new.Current, DataRowView))
        AttivapulsantiFattura(True)
    End Sub

    Private Shared Sub SituazionePagamenti(ByVal Filtro As String, ByVal id As Integer)
        Dim stp_frm As New frm_stp_sca_ins(Filtro, id)
        stp_frm.ShowDialog()
    End Sub

    Private Sub FattureImpagateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FattureImpagateToolStripMenuItem.Click
        If G_livello < 800 Then
            Return
        End If

        Dim OldRiga As DS_clienti.DT_cantieri_newRow
        OldRiga = DirectCast(Me.BS_clienti_new.Current, DataRowView).Row
        Dim filtro As String
        filtro = String.Format("fat_paga <= {0} AND fat_pa_fallimento <= {1}", 0, 0)
        SituazionePagamenti(filtro, OldRiga.id)
    End Sub

    Private Sub ElencoScadenzeClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElencoScadenzeClienteToolStripMenuItem.Click
        If G_livello < 800 Then
            Return
        End If
        Dim OldRiga As DS_clienti.DT_cantieri_newRow
        OldRiga = DirectCast(Me.BS_clienti_new.Current, DataRowView).Row
        Dim filtro As String
        filtro = String.Format("")
        SituazionePagamenti(filtro, OldRiga.id)
    End Sub

    Private Sub FattureInsoluteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FattureInsoluteToolStripMenuItem.Click
        If G_livello < 800 Then
            Return
        End If
        Dim OldRiga As DS_clienti.DT_cantieri_newRow
        OldRiga = DirectCast(Me.BS_clienti_new.Current, DataRowView).Row
        Dim filtro As String
        filtro = String.Format(" fat_scad < '{0}' AND fat_paga <= {1} AND fat_pa_fallimento <= {2}", Now.ToShortDateString, 0, 0)
        SituazionePagamenti(filtro, OldRiga.id)
    End Sub

    Private Sub FattureInPerditaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FattureInPerditaToolStripMenuItem.Click
        If G_livello < 800 Then
            Return
        End If
        Dim OldRiga As DS_clienti.DT_cantieri_newRow
        OldRiga = DirectCast(Me.BS_clienti_new.Current, DataRowView).Row
        Dim filtro As String
        filtro = String.Format("fat_pa_fallimento = {0}", 1)
        SituazionePagamenti(filtro, OldRiga.id)
    End Sub

    Private Sub ElencoDiTtueLeFattureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElencoDiTtueLeFattureToolStripMenuItem.Click
        If G_livello < 800 Then
            Return
        End If
        Dim periodo As String

        Dim stampa As New FRM_stp_fattura_elenco(PeriodoLocale)
        stampa.ShowDialog()
    End Sub

    Private Sub ElencoDiTuttoLoScadutoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElencoDiTuttoLoScadutoToolStripMenuItem.Click
        If G_livello < 800 Then
            Return
        End If
        Dim filtro As String
        If MsgBox("Vuoi visualizzare anche le Note di Credito già compensate?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            filtro = String.Format(" fat_scad < '{0}' AND fat_paga <= {1} AND fat_pa_fallimento <= {2} OR fat_nc = 1 AND fat_scad < '{0}' AND fat_paga <= 1 AND fat_pa_fallimento <= {2} ", Now.ToShortDateString, 0, 0)
        Else
            filtro = String.Format(" fat_scad < '{0}' AND fat_paga <= {1} AND fat_pa_fallimento <= {2}", Now.ToShortDateString, 0, 0)
        End If

        SituazionePagamenti(filtro, -1)
    End Sub
    Private Sub Pulisce_riepilogo_giorni()
        'Ripulisce la griglia dei totali giornalieri
        Select Case TAB_clienti.SelectedTab.Name
            Case TBL_inserimentopresenze.Name
                'DG_totalipresenze.Columns.Clear()
                DG_totalipresenze.Rows.Clear()
                DG_totalipresenze.AllowUserToAddRows = False
                DG_totalipresenze.AllowUserToDeleteRows = False
            Case TBL_inserimentopresenzeweb.Name
                'DG_totaleoreweb.Columns.Clear()
                DG_totaleoreweb.Rows.Clear()
                DG_totaleoreweb.AllowUserToAddRows = False
                DG_totaleoreweb.AllowUserToDeleteRows = False
        End Select
    End Sub

    Private Sub CreanuovatabellaTotale(ByVal cella As Integer, ByVal giorni As Integer, ByVal festivo As Integer)
        'Funzione che crea i riepilogo delle ore e li carica nel DG
        Dim larghezzacella As Integer = 50
        Dim dw As String() = New String() {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
        Dim tmp_data As DateTime
        Dim tmp_day As Integer = cella  'Valore giorno (da 0 a massimogiorno mese)
        Dim ultimogiorno As Integer = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, 0).Day
        If cella > 0 And cella <= giorni Then
            tmp_data = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, cella)
        End If
        Dim DG_tmp As DataGridView = Nothing
        Dim DG_tmp2 As DataGridView = Nothing

        Select Case TAB_clienti.SelectedTab.Name
            Case TBL_inserimentopresenze.Name
                DG_tmp = DG_totalipresenze
                DG_tmp2 = DG_dettagliopresenze
            Case TBL_inserimentopresenzeweb.Name
                'DG_tmp = DG_totaleorewebOld
                DG_tmp = DG_totaleoreweb
                DG_tmp2 = DG_totaleOreWebCliente
        End Select


        Dim CelObj As String
        CelObj = "C" & cella
        Dim DGCol As DataGridViewColumn
        DGCol = CType(DG_tmp.Columns(CelObj), DataGridViewColumn)
        If IsNothing(DGCol) Then
            Dim col As New DataGridViewRolloverCellColumn()
            Dim Col2 As New DataGridViewRolloverCellColumn()
            Select Case True
                Case cella = 0
                    'larghezzacella = 170
                    With col
                        .HeaderText = "Cliente"
                        .Width = 170
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
                    With Col2
                        .HeaderText = "Dipendente"
                        .Width = larghezzacella
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
                Case cella > 0 And cella <= giorni
                    tmp_data = New DateTime(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, cella) 'Ricrea il giorno del mese
                    Dim colore As Color

                    With col
                        If festivo = 0 Then
                            .HeaderText = dw(tmp_data.DayOfWeek).Substring(0, 1) & " " & tmp_day.ToString.PadLeft(2, "0")
                        Else
                            .HeaderText = "FES" & " " & tmp_day.ToString.PadLeft(2, "0")
                        End If

                        .Width = larghezzacella
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
                    With Col2
                        If festivo = 0 Then
                            .HeaderText = dw(tmp_data.DayOfWeek).Substring(0, 1) & " " & tmp_day.ToString.PadLeft(2, "0")
                        Else
                            .HeaderText = "FES" & " " & tmp_day.ToString.PadLeft(2, "0")
                        End If
                        .Width = larghezzacella
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
                Case cella > giorni
                    larghezzacella = 40
                    With col
                        .HeaderText = "Totale"
                        .Width = larghezzacella
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
                    With Col2
                        .HeaderText = "Totale"
                        .Width = larghezzacella
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
            End Select
            DG_tmp.Columns.Add(col)
            Select Case TAB_clienti.SelectedTab.Name
                'Nel caso è presenze WEB allora compila anche il riepilogo Totale
                Case TBL_inserimentopresenzeweb.Name
                    DG_tmp2.Columns.Add(Col2)
            End Select
        Else
            If cella > 0 And cella <= giorni Then
                If festivo = 0 Then
                    DG_tmp.Columns("C" & cella).HeaderText = dw(tmp_data.DayOfWeek).Substring(0, 1) & " " & tmp_day.ToString.PadLeft(2, "0")
                Else
                    DG_tmp.Columns("C" & cella).HeaderText = "FES" & " " & tmp_day.ToString.PadLeft(2, "0")
                End If
            End If
        End If
    End Sub

    Private Sub ContaDG_totaliPresenzeWEB()
        'Procedura per calcolare i valori giornalieri delle presenze Remote

        If TAB_clienti.SelectedTab.Name <> TBL_inserimentopresenzeweb.Name Then
            Return
        End If

        Dim idCli As Integer = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")

        RELcantieriPresenzeWeb.Filter = "id_terminale = " & idCli
        Pulisce_riepilogo_giorni()
        Dim rg As DS_clienti.DT_presenzeWEBRow
        If RELcantieriPresenzeWeb.Count > 0 Then
            rg = DirectCast(RELcantieriPresenzeWeb.Current, DataRowView).Row
            RELcantieriPresenzeWeb.MoveFirst()
        Else
            LBtotaleDipendenteWeb.Text = "0"
            Return
        End If
        Dim idConfronto As Integer
        'Imposta il confronto per Operatore
        idConfronto = rg.id_utente
        'Ottiene l'ultimo giorno del mese
        Dim kdat As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0)
        'Crea la tabella con le 31 celle più il nome della società
        For tmpd = 0 To kdat.Day + 1
            Dim festivo As Integer = 0
            If tmpd > 0 And tmpd < kdat.Day Then
                Dim f As DateTime = New Date(kdat.Year, kdat.Month, tmpd)
                BS_cal.Position = BS_cal.Find("giorno", f)
                festivo = DirectCast(BS_cal.Current, DataRowView).Row.Item("festivo")
            End If
            CreanuovatabellaTotale(tmpd, kdat.Day, festivo)   'Ridefinisce la Griglia dove inserirà  i dati
        Next
        Dim Cli As DataTable
        Cli = CreaDTTotali(RELcantieriPresenzeWeb, "web") 'Crea una dataTable con i dati da inserire nella Tabella
        ' Test per inserire la griglia con i totali per cantiere selezionati dal dipendente
        Dim ClidaRag = Cli.AsEnumerable().GroupBy(Function(row) New With
            {Key .id_cli = row.Field(Of Int32)("id_cli"),
            Key .id_det = row.Field(Of Int32)("id_det"),
            Key .societa = row.Field(Of String)("societa"),
            Key .anagrafica = row.Field(Of String)("anagrafica"),
            Key .dettaglio = row.Field(Of String)("dettaglio"),
            Key .giorno = row.Field(Of Int32)("giorno"),
            Key .note = Trim(row.Field(Of String)("note")).ToLower(),
            Key .tipo = row.Field(Of Int32)("id_tipo"),
            Key .auto = row.Field(Of Int32)("auto"),
            Key .iddip = row.Field(Of Int32)("id_dip")
            })

        Dim CliRaggruppata = Cli.Clone() ' empty table with same columns
        For Each grp In ClidaRag
            CliRaggruppata.Rows.Add(grp.Key.id_cli, grp.Key.id_det, grp.Key.iddip, "", grp.Key.dettaglio, grp.Key.anagrafica, grp.Key.giorno, grp.Sum(Function(row) row.Field(Of Decimal)("ore")), grp.Key.note, grp.Key.tipo, grp.Key.auto)
        Next
        'Ordina la tabella per cliente e Giorno
        Dim TabellaOrdinata As New DataTable
        TabellaOrdinata = OrdinaTabella(CliRaggruppata, "dettaglio,id_tipo,giorno,anagrafica")
        Dim OldID As Int32 'Codice Confronto per Cliente
        Dim OldTi As Int32 'Codice Contronto per Tipologia
        OldID = 0
        OldTi = -1
        Dim tOra As Decimal = 0
        Dim oGiorno As Integer = 0
        Dim PrimoDipendente As Integer
        PrimoDipendente = TabellaOrdinata.Rows(0).Field(Of Int32)("id_dip")
        Dim PrimoDettaglioCliente As Integer = TabellaOrdinata.Rows(0).Field(Of Int32)("id_det")
        'Cicla la datatable e riempie la tabella
        Dim ora As Decimal = 0
        Dim DescTipo As String
#If DEBUG Then
        Console.WriteLine("ESEGUE LA LISTA DEL RIEPILOGO CLIENTI")
#End If
        '
        ' Inizia a caricare la tabella delle presenze
        '
        For Each dtt As DataRow In TabellaOrdinata.Rows

            'Carica le ore e le somma alle precedenti


            Dim tAnagrafica As String
            tAnagrafica = dtt.Field(Of String)("anagrafica")
            Dim id_dip As Integer
            id_dip = dtt.Field(Of Int32)("id_dip")
            Dim note As String
            note = dtt.Field(Of String)("note")
            Dim id_cli As Integer
            id_cli = dtt.Field(Of Int32)("id_cli")
            Dim iddet As Integer
            iddet = dtt.Field(Of Int32)("id_det")
            Dim idTip As Int16
            idTip = dtt.Field(Of Int32)("id_tipo")
            Dim tgiorno As Integer
            tgiorno = dtt.Field(Of Int32)("giorno")
            Dim tSocieta As String
            tSocieta = dtt.Field(Of String)("dettaglio")
            Dim auto As Int32
            auto = dtt.Field(Of Int32)("auto")

            'Se è assente non somma le ore
            ora += If(OldTi = 2, 0, dtt.Field(Of Decimal)("ore"))

            'se cambia il Dettaglio allora crea una nuova riga
#If DEBUG Then
            Console.WriteLine("******************** Anagrafica: " & tAnagrafica & "-Tipo " & idTip & "-Dettaglio: " & tSocieta & "-giorno: " & tgiorno & "-ore: " & ora.ToString)
#End If
            BS_tipologia.Position = BS_tipologia.Find("id_tipo", idTip)
            If BS_tipologia.Position > -1 Then
                DescTipo = DirectCast(BS_tipologia.Current, DataRowView).Row("descrizione")
            Else
                DescTipo = " "
            End If
            Dim festivo As Integer = 0

            Dim PrimaCella As String = CType(tSocieta & "-" & DescTipo.Substring(0, 3), String)
            If tgiorno > 0 And tgiorno < kdat.Day Then
                Dim f As DateTime = New Date(kdat.Year, kdat.Month, tgiorno)
                BS_cal.Position = BS_cal.Find("giorno", f)
                festivo = DirectCast(BS_cal.Current, DataRowView).Row.Item("festivo")
            End If


            If iddet.ToString() & idTip.ToString <> OldID.ToString & OldTi.ToString Then  'SE è un nuovo cliente crea una nuova riga
                'nuovo cliente azzera le ore e i totali
                tOra = 0
                ora = 0

                OldID = dtt.Field(Of Int32)("id_det")
                OldTi = dtt.Field(Of Int32)("id_tipo")
                oGiorno = tgiorno
                'Se il tipo è 2 (assente) allora non somma l'orario

                ora = If(OldTi = 2, 0, dtt.Field(Of Decimal)("ore"))
                tOra = ora
                ' Crea la prima riga dove mette l'intestazione del dettaglio
                AssegnaValoriTabella(DG_totaleoreweb, True, 0, PrimaCella, "", festivo, iddet, 0, OldTi, auto)
            Else
                If oGiorno <> tgiorno Then
                    'nuovo giorno azzera le ore e i totali
                    ora = 0
                    'tOra = 0
                    'Controlla che non sia Assente
                    ora = ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                    oGiorno = tgiorno
                End If
                tOra += ora

            End If
            ' Compila le varie celle del mese
            AssegnaValoriTabella(DG_totaleoreweb, False, tgiorno, ora, note, festivo, iddet, oGiorno, OldTi, auto)
            ' Questo assegna il totale all'ultima cella della riga
            AssegnaValoriTabella(DG_totaleoreweb, False, kdat.Day + 1, tOra, note, festivo, iddet, oGiorno, OldTi, 3)
        Next
#If DEBUG Then
        Console.WriteLine("TERMINA LA LISTA DEL RIEPILOGO CLIENTI")
#End If
        '
        'Calcola i le somme totali e le inserisce in ultima riga dellatabella DG_totaleOreWeb
        '
        Dim Clidasommare = TabellaOrdinata.AsEnumerable().GroupBy(Function(row) New With
            {Key .giorno = row.Field(Of Int32)("giorno"),
            Key .tipo = row.Field(Of Int32)("id_tipo")
            })

        Dim Clisommata = Cli.Clone() ' empty table with same columns

        For Each grp In Clidasommare
            Dim ore As Decimal
            Dim tipo As Int32
            Dim giorno As Int32 = grp.Key.giorno
            Console.WriteLine(grp.Key.giorno & " " & grp.Key.tipo)
            tipo = grp.Key.tipo
            ore = grp.Sum(Function(row) row.Field(Of Decimal)("ore"))
            Clisommata.Rows.Add(0, 0, 0, "", "", "", grp.Key.giorno, ore, "", tipo)
        Next
        'Ordina la tabella per cliente e Giorno
        '******


        riempie_riepilogo_giorni(-1, -1, -1, "", "", -1, DG_totaleoreweb, 0)
        riempie_riepilogo_giorni(0, 0, kdat.Day, "Parziale", "", -1, DG_totaleoreweb, 0)
        'Pubblica i parziali
        tOra = 0
        For Each dtt As DataRow In Clisommata.Rows
            Dim orx As Decimal = If(dtt.Field(Of Int32)("id_tipo") <> 2, dtt.Field(Of Decimal)("ore"), 0)
            tOra += orx
#If DEBUG Then
            Console.WriteLine("Giorno " & dtt.Field(Of Int32)("giorno") & " Ore " & orx.ToString & " Tipologia " & dtt.Field(Of Int32)("id_tipo"))
#End If

            riempie_riepilogo_giorni(dtt.Field(Of Int32)("giorno"), orx, kdat.Day, "", "", -1, DG_totaleoreweb, 0)
        Next
        riempie_riepilogo_giorni(kdat.Day + 1, tOra, kdat.Day, "Parziale", "", -1, DG_totaleoreweb, 0)
        LBtotaleDipendenteWeb.Text = tOra.ToString("n2")
        'Carica il dettaglio del primo cliente
        Using cDT As New DS_clienti.DT_presenzeWEBDataTable
            Using cTA As New DS_clientiTableAdapters.TA_presenzeWEB
                cTA.FillByLocazionePeriodo(cDT, PrimoDettaglioCliente, PeriodoLocale)
                caricaRiepilogoPresenzeClienti(DG_totaleOreWebCliente, cDT, "web")
            End Using
        End Using

        Dim Larghezzacellamassima As Integer
        Larghezzacellamassima = (DG_totaleoreweb.Width - 120) / (kdat.Day + 1)
        DimensioniGriglieWEB(DG_totaleoreweb, DG_totaleOreWebCliente, Larghezzacellamassima)
    End Sub
    Private Shared Function DimensioniGriglieWEB(ByVal tmpDG As DataGridView, ByVal tmpDGResoconto As DataGridView, ByRef DimensioniCella As Integer)

        For Each tmpCol As DataGridViewColumn In tmpDG.Columns
            If tmpCol.Index = 0 Then
                tmpDG.Columns(tmpCol.Index).Width = 120
                tmpDGResoconto.Columns(tmpCol.Index).Width = 120
            ElseIf tmpCol.Index = tmpDG.Columns.Count Then


                tmpDG.Columns(tmpCol.Index).Width = 80
                tmpDGResoconto.Columns(tmpCol.Index).Width = 80
            Else
                tmpDG.Columns(tmpCol.Index).Width = DimensioniCella
                tmpDGResoconto.Columns(tmpCol.Index).Width = DimensioniCella
            End If
        Next
        Return True
    End Function
    Private Function caricaRiepilogoPresenzeClienti(ByRef dataGridPresenze As DataGridView, ByVal dtPresenze As DataTable, ByVal tipoDatatable As String)
        '
        'Completa e carica i dati della tabella DG_totaleOreWebCliente
        '
        '

        With dataGridPresenze
            .Rows.Clear()
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
        End With

        Dim CBSoreWeb As New BindingSource 'Crea una Binding per gestire i dati dei clienti
        CBSoreWeb.DataSource = dtPresenze

        Dim kdat As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0)

        Dim CperD = CreaDTTotali(CBSoreWeb, tipoDatatable)  'modificato TODO
        Dim ClidaRag = CperD.AsEnumerable().GroupBy(Function(row) New With
        {Key .id_det = row.Field(Of Int32)("id_det"),
        Key .id_dip = row.Field(Of Int32)("id_dip"),
        Key .societa = row.Field(Of String)("societa"),
        Key .dettaglio = row.Field(Of String)("dettaglio"),
        Key .anagrafica = row.Field(Of String)("anagrafica"),
        Key .giorno = row.Field(Of Int32)("giorno"),
        Key .note = Trim(row.Field(Of String)("note")).ToLower(),
        Key .id_tipo = row.Field(Of Int32)("id_tipo")})

        Dim CliRaggruppata = CperD.Clone() ' empty table with same columns
        For Each grp In ClidaRag
            CliRaggruppata.Rows.Add(0, grp.Key.id_det, grp.Key.id_dip, grp.Key.societa, grp.Key.dettaglio, grp.Key.anagrafica, grp.Key.giorno, grp.Sum(Function(row) row.Field(Of Decimal)("ore")), grp.Key.note, grp.Key.id_tipo)
#If DEBUG Then
            Console.WriteLine("Riepilogo Conteggi PRIMARIO")
            Console.WriteLine("Dipendente" & grp.Key.anagrafica & " Giorno " & grp.Key.giorno.ToString() & " tipologia " & grp.Key.id_tipo.ToString() & " ore " & grp.Sum(Function(row) row.Field(Of Decimal)("ore")).ToString & " note " & grp.Key.note)
#End If
        Next
        'Ordina la tabella per cliente e Giorno
        Dim TabellaOrdinata As New DataTable
        TabellaOrdinata = OrdinaTabella(CliRaggruppata, "societa ASC,anagrafica ASC, id_tipo ASC, giorno ASC")
        Dim ttora As Decimal
        For Each dtt As DataRow In TabellaOrdinata.Rows

            ttora = dtt.Field(Of Decimal)("ore")
            Dim note As String
            note = dtt.Field(Of String)("note")
            Dim iddip As Integer
            iddip = dtt.Field(Of Int32)("id_dip")
            Dim tgiorno As Integer
            tgiorno = dtt.Field(Of Int32)("giorno")
            Dim tSocieta As String
            tSocieta = dtt.Field(Of String)("societa")
            Dim tDettaglio As String
            tDettaglio = dtt.Field(Of String)("dettaglio")
            Dim tAnagrafica As String
            tAnagrafica = dtt.Field(Of String)("anagrafica")
            Dim idTip As Integer
            idTip = dtt.Field(Of Int32)("id_tipo")
#If DEBUG Then
            Console.WriteLine("Riepilogo Conteggi SECONDARIO")
            Console.WriteLine("##############Dipendente " & tAnagrafica.PadRight(20, " ") & " Giorno " & tgiorno.ToString().PadRight(2, " ") & " tipologia " & idTip.ToString() & " ore " & ttora.ToString & " note " & note)
#End If

        Next
        Dim OldID As Integer
        OldID = 0
        Dim tora As Decimal = 0
        Dim oGiorno As Integer = 0
        'Dim oTipo As Integer = 0
        'Cicla la datatable e riempie la tabella
        Dim ora As Decimal = 0
        Dim oldNota As String = ""
        For Each dtt As DataRow In TabellaOrdinata.Rows
            ora += dtt.Field(Of Decimal)("ore")
            Dim note As String
            note = dtt.Field(Of String)("note")
            Dim iddip As Integer
            iddip = dtt.Field(Of Int32)("id_dip")
            Dim tgiorno As Integer
            tgiorno = dtt.Field(Of Int32)("giorno")
            Dim tSocieta As String
            tSocieta = dtt.Field(Of String)("societa")
            Dim tDettaglio As String
            tDettaglio = dtt.Field(Of String)("dettaglio")
            Dim tAnagrafica As String
            tAnagrafica = dtt.Field(Of String)("anagrafica")
            Dim idTip As Integer
            idTip = dtt.Field(Of Int32)("id_tipo")
            Dim festivo As Int16
            Dim f As DateTime = New Date(kdat.Year, kdat.Month, kdat.Day)
            BS_cal.Position = BS_cal.Find("giorno", f)
            festivo = DirectCast(BS_cal.Current, DataRowView).Row.Item("festivo")

            'se cambia il dipendente
            Select Case True
                Case OldID <> iddip
                    tora = 0
                    ora = 0
                    'If idTip <> 2 Then
                    ora = ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                    'Else
                    'ora = -1
                    'End If
                    oGiorno = tgiorno
                    riempie_riepilogo_giorni(0, tora, kdat.Day, tAnagrafica, "", 0, dataGridPresenze, iddip)
                    'aggiunge il totale
                    tora += ora
                    riempie_riepilogo_giorni(tgiorno, ora, kdat.Day, "", note, tgiorno, dataGridPresenze, festivo)
                    'scrive il totale in fondo alla griglia
                    riempie_riepilogo_giorni(kdat.Day + 1, tora, kdat.Day, "", "", -1, dataGridPresenze, festivo)
                    'aggiorna il codice ID del cliente
                    OldID = dtt.Field(Of Int32)("id_dip")
                    oldNota = note
                Case oGiorno <> tgiorno
                    'Qui controlla che non cambia il giorno
                    ora = 0
                    ora += ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                    oGiorno = tgiorno
                    riempie_riepilogo_giorni(tgiorno, ora, kdat.Day, "", note, tgiorno, dataGridPresenze, festivo)
                    'aggiorna il totale della riga
                    riempie_riepilogo_giorni(kdat.Day + 1, tora, kdat.Day, "", "", -1, dataGridPresenze, festivo)
                Case note <> oldNota And OldID <> iddip ' And note <> ""'Qui controlla se cambiano le note
                    ora = 0
                    ora += ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                    'oGiorno = tgiorno
                    oldNota = note
                    tora += ora
                    'memorizza il valore della cella nella data
                    riempie_riepilogo_giorni(tgiorno, ora, kdat.Day, "", note, tgiorno, dataGridPresenze, festivo)
                    'aggiorna il totale della riga
                    riempie_riepilogo_giorni(kdat.Day + 1, tora, kdat.Day, "", "", -1, dataGridPresenze, festivo)
                Case Else

            End Select
            Me.Label4.Text = "Riepilogo per:  " & tSocieta & " dettaglio cantiere: " & tDettaglio
        Next
        'Calcola i parziali
        Dim Clidasommare = TabellaOrdinata.AsEnumerable().GroupBy(Function(row) New With
            {Key .giorno = row.Field(Of Int32)("giorno"),
            Key .tipo = row.Field(Of Int32)("id_tipo"),
            Key .note = row.Field(Of String)("note")
            })

        Dim TotGiornaliero = TabellaOrdinata.AsEnumerable().GroupBy(Function(row) New With
            {Key .giorno = row.Field(Of Int32)("giorno"),
            Key .tipo = row.Field(Of Int32)("id_tipo")
            })

        Dim n = Clidasommare.Count


        Dim Clisommata = CperD.Clone() ' empty table with same columns
        '
#If DEBUG Then
        Console.WriteLine(" ATTENZIONE ELENCO SOMMATI")
#End If

        For Each grp In TotGiornaliero 'Clidasommare 
            Dim ore As Decimal
            Dim tipo As Int32
            Dim giorno As Int32 = grp.Key.giorno
            tipo = grp.Key.tipo
            Dim note As String = "" 'grp.Key.note
            ore = grp.Sum(Function(row) row.Field(Of Decimal)("ore"))
#If DEBUG Then
            Console.WriteLine(" Giorno " & giorno.ToString() & " tipologia " & tipo.ToString() & " ore " & ore.ToString & " note " & note)
#End If
            Clisommata.Rows.Add(0, 0, 0, "", "", "", grp.Key.giorno, ore, note, tipo)
        Next
        Dim CliSommataOrdinata As New DataTable
        CliSommataOrdinata = OrdinaTabella(Clisommata, "giorno ASC, id_tipo ASC")
#If DEBUG Then
        Console.WriteLine(" TERMINA ATTENZIONE ELENCO SOMMATI")
#End If

        'Ordina la tabella per cliente e Giorno
        riempie_riepilogo_giorni(-1, -1, -1, "", "", -2, dataGridPresenze, 0)
        riempie_riepilogo_giorni(0, 0, kdat.Day, "Totale Cliente", "", -2, dataGridPresenze, 0)
        'Pubblica i parziali
        'Dim otipo As Integer = 0    'Vecchia Tipologia


        Dim rp_note As String               'Note


        Dim rp_tipo As Integer
        Dim rp_ore As Decimal = 0   'Rapporto Ore
        Dim rp_giorno As Integer   ' Giorno e nuova Tipologia
        Dim oNota As String = ""
        Dim oTipo As Integer = 0
        tora = 0
        oGiorno = 0

        For Each dtt As DataRow In CliSommataOrdinata.Rows

            rp_tipo = dtt.Field(Of Int32)("id_tipo")
            rp_giorno = dtt.Field(Of Int32)("giorno")
            rp_note = dtt.Field(Of String)("note")
            rp_ore = ControllaOre(dtt.Field(Of Decimal)("ore"), rp_tipo)
            If oGiorno <> rp_giorno Then      'Qui controlla che non cambia il giorno
                rp_ore = 0
                rp_ore = ControllaOre(dtt.Field(Of Decimal)("ore"), rp_tipo)
                oGiorno = rp_giorno
            End If
            riempie_riepilogo_giorni(rp_giorno, rp_ore, kdat.Day, "", "", -1, dataGridPresenze, 0)
            tora += rp_ore

#If DEBUG Then
            Console.WriteLine("STO COMPILANDO L'ELENCO DEI RIEPILOGHI CLIENTI ")
            Console.WriteLine(" Giorno " & rp_giorno.ToString() & "tipologia " & rp_tipo.ToString() & " ore " & rp_ore.ToString & "Totale Ore " & tora.ToString)
#End If

        Next


        riempie_riepilogo_giorni(kdat.Day + 1, tora, kdat.Day, "Parziali", "", -2, dataGridPresenze, 0)
        LBtotalepresenzeClienteWEB.Text = tora.ToString("n2")
        Return True
    End Function
    Private Sub PopolaLeggenda()
        Dim cc As ColoriDettaglio = New ColoriDettaglio()
#Disable Warning BC42025 ' L'accesso del membro condiviso, del membro costante, del membro di enumerazione o del tipo nidificato verrà effettuato tramite un'istanza

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

    Private Shared Function ControllaOre(ByVal ora As Decimal, ByVal tipo As Int32) As Decimal
        If tipo <> 2 Then
            Return ora
        Else
            Console.WriteLine(ora)
            Return 0
        End If

    End Function

    Private Shared Function AssegnaValoriTabella(ByRef TMPDG As DataGridView, ByVal Nuova As Boolean, ByVal Colonna As Int32,
                                                 ByVal Valore As Object, ByVal Valore1 As Object, ByVal festivo As Int16,
                                                 Optional ByVal ID1 As Int32 = Nothing, Optional ByVal ID2 As Int32 = Nothing,
                                                 Optional ByVal ID3 As Int32 = Nothing, Optional ByVal auto As Int32 = 0)

        Dim cc As ColoriDettaglio = New ColoriDettaglio()

        If Nuova = True Then
            TMPDG.Rows.Add()
        End If

        Dim ultimariga As Integer
        ultimariga = TMPDG.Rows.Count - 1

        Dim CSfondo As Color = TMPDG(Colonna, ultimariga).Style.BackColor
        Dim CScritta As Color = TMPDG(Colonna, ultimariga).Style.ForeColor
        Dim StileAllineamento As DataGridViewContentAlignment = TMPDG(Colonna, ultimariga).Style.Alignment
        Dim StileCarattere As Font = TMPDG(Colonna, ultimariga).Style.Font
        Dim NTag As Integer = 0
        Dim SToolTips As String = ""

        Select Case True
            Case ID1 > 0
                NTag = ID1
            Case ID2 > 0
                NTag = ID2
        End Select


        Dim ValoreConvertibile As IConvertible = TryCast(Valore, IConvertible)
        Dim strValore As String = ""
        Select Case ValoreConvertibile.GetTypeCode()
            Case TypeCode.Decimal
                strValore = Format(Valore, "#0.0#")
            Case TypeCode.String
                strValore = Valore
                StileAllineamento = DataGridViewContentAlignment.MiddleLeft
                StileCarattere = New Font(FontFamily.GenericSerif, 9.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        End Select


        Dim strValore1 As String = CType(Valore1, String)

        TMPDG(Colonna, ultimariga).Tag = NTag
        TMPDG(Colonna, ultimariga).Value = strValore
        If Colonna > 0 Then
#Disable Warning BC42025 ' L'accesso del membro condiviso, del membro costante, del membro di enumerazione o del tipo nidificato verrà effettuato tramite un'istanza

            Select Case True
                Case auto = 3

                Case auto = 1 And ID3 = 2                   ' Se è inviato ed è assente
                    CSfondo = cc.XTrAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AA"
                    TMPDG(Colonna, ultimariga).ToolTipText = strValore
                Case auto = 1 And strValore1.Length > 0 And ID3 = 2 ' Se è con nota ed è stato inviato ed è assente
                    CSfondo = cc.XTrNoteAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AN"
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips

                Case auto = 1 And strValore1.Length > 0     ' Se è presente una nota ed è stato inviato
                    SToolTips = "inviato " & Valore1
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                    CSfondo = cc.XTrNote
                    CScritta = Color.White
                Case auto = 1                               ' se è stato solo inviato
                    CSfondo = cc.XTraPres
                    CScritta = Color.White
                    '
                    'Qui iniziano a delinearsi gli inserimenti non inviati
                    '
                Case auto = 0 And strValore1.Length > 0 And ID3 = 2 ' note e assente
                    CSfondo = cc.NorNoteAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AN"
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                Case auto = 0 And ID3 = 2 ' assente
                    CSfondo = cc.NorAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AA"
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips

                Case auto = 0 And strValore1.Length > 0 ' Note
                    SToolTips = Valore1
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                    TMPDG(Colonna, ultimariga).Value = "" & strValore
                    CSfondo = cc.NorNote
                    CScritta = Color.White
                Case Else
            End Select

#Enable Warning BC42025 ' L'accesso del membro condiviso, del membro costante, del membro di enumerazione o del tipo nidificato verrà effettuato tramite un'istanza

        End If

        If festivo > 0 Then
            CSfondo = Color.CadetBlue
        End If
        TMPDG(Colonna, ultimariga).Style.ForeColor = CScritta
        TMPDG(Colonna, ultimariga).Style.BackColor = CSfondo
        TMPDG(Colonna, ultimariga).Style.Font = StileCarattere
        TMPDG(Colonna, ultimariga).Style.Alignment = StileAllineamento
        Return True
    End Function

    Private Shared Function CreaDTTotali(ByRef BStmp As BindingSource, ByVal tiporiga As String) As DataTable
        Dim Cli
        Cli = New DataTable
        Cli.Namespace = "TabellaClienti"
        Dim CliRow As DataRow
        Dim colonna As DataColumn
        colonna = New DataColumn
        colonna.ColumnName = "id_cli"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_det"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_dip"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "societa"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dettaglio"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "anagrafica"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "giorno"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "ore"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "note"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_tipo"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "auto"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)

        Dim RGweb As DS_clienti.DT_presenzeWEBRow
        Dim RGloc As DS_clienti.DT_contoreRow

        For Each hg In BStmp
            CliRow = Cli.NewRow
            If tiporiga = "web" Then
                RGweb = DirectCast(hg, DataRowView).Row
                CliRow("id_cli") = RGweb.id_terminale
                CliRow("id_det") = RGweb.id_locazione
                CliRow("id_dip") = RGweb.id_utente
                CliRow("dettaglio") = RGweb.locazione
                CliRow("societa") = RGweb.societa
                CliRow("anagrafica") = RGweb.anagrafica
                CliRow("giorno") = RGweb.giorno.Day
                Dim Ore As New TimeSpan
                If RGweb.orario = " " Then
                    RGweb.orario = 0
                End If
                Ore = TimeSpan.Parse(RGweb.orario.ToString)
                CliRow("ore") = Ore.TotalHours
                CliRow("note") = RGweb.note
                CliRow("id_tipo") = RGweb.inviato
                CliRow("auto") = RGweb._auto
                Cli.Rows.Add(CliRow)
            ElseIf tiporiga = "loc" Then
                RGloc = DirectCast(hg, DataRowView).Row
                CliRow("id_cli") = RGloc.id_cli
                CliRow("id_det") = RGloc.id_dest
                CliRow("id_dip") = RGloc.id_dip
                CliRow("societa") = RGloc.locazione
                CliRow("anagrafica") = RGloc.anagrafica
                CliRow("dettaglio") = RGloc.locazione
                CliRow("giorno") = RGloc.data.Day
                CliRow("ore") = RGloc.ore
                CliRow("note") = RGloc.note
                CliRow("id_tipo") = RGloc.id_tipo
                'Mette a 0 il fatto che sono state trasferiti i dati
                CliRow("auto") = 0

                Cli.Rows.Add(CliRow)
            End If
        Next
        Return Cli
    End Function
    Private Shared Function OrdinaTabella(ByVal tabella As DataTable,
                                   ByVal Campo As String) As DataTable
        Dim view As DataView = tabella.DefaultView
        view.Sort = Campo
        Return view.ToTable()
    End Function
    '
    '
    'Procedura per calcolare i valori giornalieri delle presenze
    '
    '
    Private Sub caricaDG_Reali()

        If TAB_clienti.SelectedTab.Name <> TBL_inserimentopresenze.Name Then
            Return
        End If
        If RELclientecontore.Count = 0 Then
            DG_totalipresenze.Rows.Clear()
            DG_dettagliopresenze.Rows.Clear()
            Return
        End If
        Dim idCli As Integer = DirectCast(RELclientecontore.Current, DataRowView).Row.Item("id_cli")
        'RELcantieriPresenzeWeb.Filter = "id_utente = " & idCli
        'Pulisce_riepilogo_giorni()
        Dim rg As DS_clienti.DT_contoreRow
        rg = DirectCast(RELclientecontore.Current, DataRowView).Row
        RELclientecontore.MoveFirst()
        'Crea la tabella con le 31 celle più il nome della società da Class
        Dim pp As creaTabellaOreMese = New creaTabellaOreMese
        pp.Mese = PeriodoLocale.Split("-").Last
        pp.Anno = PeriodoLocale.Split("-").First
        pp.dataGridPresenze = DG_totalipresenze
        pp.dataGridTotale = DG_dettagliopresenze
        pp.dimFontCella = 8
        Dim risp As Boolean = pp.Crea()

        Dim kDat As DateTime = DateSerial(pp.Anno, pp.Mese + 1, 0)
        Dim Cli As DataTable
        Cli = CreaDTTotali(RELclientecontore, "loc") 'Crea una dataTable con i dati da inserire nella Tabella
        ' Test per inserire la griglia con i totali per cantiere selezionati dal dipendente
        Dim ClidaRag = Cli.AsEnumerable().GroupBy(Function(row) New With
            {Key .id_cli = row.Field(Of Int32)("id_cli"),
            Key .id_det = row.Field(Of Int32)("id_det"),
            Key .societa = row.Field(Of String)("societa"),
            Key .dettaglio = row.Field(Of String)("dettaglio"),
            Key .giorno = row.Field(Of Int32)("giorno"),
            Key .note = Trim(row.Field(Of String)("note")).ToLower(),
            Key .tipo = row.Field(Of Int32)("id_tipo"),
            Key .auto = row.Field(Of Int32)("auto"),
            Key .iddip = row.Field(Of Int32)("id_dip")
            })
        Dim CliRaggruppata = Cli.Clone() ' empty table with same columns
        For Each grp In ClidaRag
            CliRaggruppata.Rows.Add(grp.Key.id_cli, grp.Key.id_det, 0, "", grp.Key.dettaglio, grp.Key.societa, grp.Key.giorno, grp.Sum(Function(row) row.Field(Of Decimal)("ore")), grp.Key.note, grp.Key.tipo, grp.Key.auto)
        Next
        'Ordina la tabella per cliente e Giorno
        Dim TabellaOrdinata As New DataTable
        TabellaOrdinata = OrdinaTabella(CliRaggruppata, "societa ,dettaglio, id_tipo, giorno")
        Dim OldID As Int32 'Codice Confronto per Cliente
        Dim OldTi As Int32 'Codice Contronto per Tipologia
        OldID = 0
        OldTi = -1
        Dim tOra As Decimal = 0
        Dim oGiorno As Integer = 0
        '
        '
        ' assegna questo valore per poter partire nella datagrid DG_totaleOreWebCliente con il primo Dettaglio
        '
        '
        '
        Dim PrimoDettaglioCliente As Integer = TabellaOrdinata.Rows(0).Field(Of Int32)("id_det")
        'Cicla la datatable e riempie la tabella
        Dim ora As Decimal = 0
        Dim DescTipo As String
#If DEBUG Then
        Console.WriteLine("ESEGUE LA LISTA DEL RIEPILOGO CLIENTI")
#End If
        '
        ' Inizia a caricare la tabella delle presenze
        '
        For Each dtt As DataRow In TabellaOrdinata.Rows

            'Carica le ore e le somma alle precedenti
            ora += dtt.Field(Of Decimal)("ore")
            Dim tAnagrafica As String
            tAnagrafica = dtt.Field(Of String)("anagrafica")
            Dim note As String
            note = dtt.Field(Of String)("note")
            Dim id_cli As Integer
            id_cli = dtt.Field(Of Int32)("id_cli")
            Dim id_det As Integer
            id_det = dtt.Field(Of Int32)("id_det")
            Dim id_dip As Integer
            id_dip = dtt.Field(Of Int32)("id_dip")
            Dim idTip As Int16
            idTip = dtt.Field(Of Int32)("id_tipo")
            Dim tgiorno As Integer
            tgiorno = dtt.Field(Of Int32)("giorno")
            Dim tSocieta As String
            tSocieta = dtt.Field(Of String)("dettaglio")
            Dim auto As Int32
            auto = dtt.Field(Of Int32)("auto")
            'se cambia il cliente allora crea una nuova riga

            BS_tipologia.Position = BS_tipologia.Find("id_tipo", idTip)
            If BS_tipologia.Position > -1 Then
                DescTipo = DirectCast(BS_tipologia.Current, DataRowView).Row("descrizione")
            Else
                DescTipo = " "
            End If
            Dim PrimaCella As String = CType(tSocieta & "-" & DescTipo.Substring(0, 3), String)

            If id_det <> OldID Then  'SE è un nuovo cliente crea una nuova riga
                'nuovo cliente azzera le ore e i totali
                tOra = 0
                ora = 0
                OldID = dtt.Field(Of Int32)("id_det")
                OldTi = dtt.Field(Of Int32)("id_tipo")
                oGiorno = tgiorno
                'Se il tipo è 2 (assente) allora non somma l'orario
                ora = If(OldTi = 2, 0, dtt.Field(Of Decimal)("ore"))
                tOra = ora
                'Crea la prima riga dove mette l'intestazione del dettaglio
                'Assegna alla tabella Totali presenze, i valori per richiamarla dopo il click
                AssegnaValoriTabella(DG_totalipresenze, True, 0, PrimaCella, "", 0, id_det, 0, OldTi, auto)
            Else
                Select Case True
                'nuovo giorno azzera le ore e i totali
                    Case oGiorno <> tgiorno
                        ora = 0
                        'Controlla che non sia Assente
                        ora = ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                        oGiorno = tgiorno
                    'Se è lo stesso cliente ma un nuovo Tipodi inserimento Crea una nuova riga
                    Case idTip <> OldTi
                        ora = 0             ' azzera le ore
                        'Controlla che non sia Assente
                        ora = ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                        'imposta OldTi con il valore attuale
                        OldTi = dtt.Field(Of Int32)("id_tipo")
                        'Crea la prima riga dove mette l'intestazione del dettaglio
                        AssegnaValoriTabella(DG_totalipresenze, True, 0, PrimaCella, "", 0, id_det, 0, OldTi, auto)
                        'TODO: controllare il festivo
                        AssegnaValoriTabella(DG_totalipresenze, False, tgiorno, ora, note, 0, id_det, oGiorno, OldTi, auto)

                End Select
                tOra += ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
            End If
            'Totale delle ore nella riga
            'Compila le varie celle del mese
            '#TODO Trovare il problema della somma dei totali nel riepilogo
            AssegnaValoriTabella(DG_totalipresenze, False, tgiorno, ora, note, 0, id_det, oGiorno, OldTi, auto)
            'Questo assegna il totale all'ultima cella della riga
            AssegnaValoriTabella(DG_totalipresenze, False, kDat.Day + 1, tOra, note, 0, id_det, oGiorno, OldTi, 3)
        Next
#If DEBUG Then
        Console.WriteLine("TERMINA LA LISTA DEL RIEPILOGO CLIENTI")
#End If

        'Calcola i parziali e popola la tabella dei parziali

        Dim Clidasommare = TabellaOrdinata.AsEnumerable().GroupBy(Function(row) New With
                {Key .giorno = row.Field(Of Int32)("giorno"),
                Key .tipo = row.Field(Of Int32)("id_tipo")})

        Dim Clisommata = Cli.Clone() ' empty table with same columns

        For Each grp In Clidasommare
            Dim ore As Decimal
            Dim tipo As Int32
            Dim giorno As Int32 = grp.Key.giorno
            Console.WriteLine(grp.Key.giorno & " " & grp.Key.tipo)
            tipo = grp.Key.tipo
            ore = grp.Sum(Function(row) row.Field(Of Decimal)("ore"))
            Clisommata.Rows.Add(0, 0, 0, "", "", "", grp.Key.giorno, ore, "", tipo)
        Next
        'Ordina la tabella per cliente e Giorno
        '   ******


        riempie_riepilogo_giorni(-1, -1, -1, "", "", -1, DG_totalipresenze, 0)
        riempie_riepilogo_giorni(0, 0, kDat.Day, "Parziale", "", -1, DG_totalipresenze, 0)
        'Pubblica i parziali
        tOra = 0
        For Each dtt As DataRow In Clisommata.Rows
            Dim orx As Decimal = If(dtt.Field(Of Int32)("id_tipo") <> 2, dtt.Field(Of Decimal)("ore"), 0)
            tOra += orx
            Console.WriteLine("Giorno " & dtt.Field(Of Int32)("giorno") & " Ore " & orx.ToString & " Tipologia " & dtt.Field(Of Int32)("id_tipo"))
            riempie_riepilogo_giorni(dtt.Field(Of Int32)("giorno"), orx, kDat.Day, "", "",
                                     -1, DG_totalipresenze, 0)
        Next
        'Scrive i totali nella prima griglia
        riempie_riepilogo_giorni(kDat.Day + 1, tOra, kDat.Day, "Parziale", "", -1, DG_totalipresenze, 0)   'Scrive il totale generale
        LBtotaleDipendenteWeb.Text = tOra.ToString("n2")
        '
        'Carica il dettaglio del primo cliente
        '#Inizia a poplare la seconda griglia, quella dei dettagli del cliente
        '
        '
        Using cDT As New DS_clienti.DT_contoreDataTable
            Using cTA As New DS_clientiTableAdapters.TA_contore
                cTA.FillByDettaglioPeriodo(cDT, PrimoDettaglioCliente, PeriodoLocale)
                'Carica i valori nel dettaglio per locazione (seconda griglia)
                caricaRiepilogoPresenzeClienti(DG_dettagliopresenze, cDT, "loc") ' Passa il Datagrid, i dati e il tipo di dati
            End Using
        End Using

        Dim Larghezzacellamassima As Integer
        Larghezzacellamassima = (DG_totalipresenze.Width - 230) / (kDat.Day + 1)
        DimensioniGriglieWEB(DG_totalipresenze, DG_dettagliopresenze, Larghezzacellamassima)
    End Sub


    Private Sub dgPresenzeRealieWeb_click(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DG_totaleoreweb.CellMouseClick, DG_totalipresenze.CellMouseClick
        Dim iddip As Integer
        Dim giorno As Integer
        Dim DGV As DataGridView
        DGV = DirectCast(sender, DataGridView)
        If e.RowIndex >= 0 Then
            iddip = TryCast(DGV(0, e.RowIndex).Tag, IConvertible)
            giorno = TryCast(DGV(e.ColumnIndex, e.RowIndex).Tag, IConvertible)
        End If
        If iddip <> 0 Then
            Dim Larghezzacellamassima As Integer
            Larghezzacellamassima = (DGV.Width - 285) / DGV.Columns.Count - 2

            Select Case DGV.Name

                Case DG_totalipresenze.Name
                    Using cDT As New DS_clienti.DT_contoreDataTable
                        Using cTA As New DS_clientiTableAdapters.TA_contore
                            cTA.FillByDettaglioPeriodo(cDT, iddip, PeriodoLocale)
                            caricaRiepilogoPresenzeClienti(DG_dettagliopresenze, cDT, "loc")
                            'cDT.Rows.Count
                        End Using
                    End Using

                Case DG_totaleoreweb.Name
                    Using cDT As New DS_clienti.DT_presenzeWEBDataTable
                        Using cTA As New DS_clientiTableAdapters.TA_presenzeWEB
                            cTA.FillByLocazionePeriodo(cDT, iddip, PeriodoLocale)
                            caricaRiepilogoPresenzeClienti(DG_totaleOreWebCliente, cDT, "web")
                        End Using
                    End Using

            End Select


        End If
        BTN_filtro.TextImageRelation = TextImageRelation.ImageAboveText

        If iddip = 0 And e.ColumnIndex > 0 And e.ColumnIndex < DGV.Columns.Count - 1 And e.RowIndex < 0 Then
            Dim data As DateTime = New DateTime(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, e.ColumnIndex)
            RELcantieriPresenzeWeb.Filter = String.Format("giorno = '{0}'", data)
            RELclientecontore.Filter = String.Format("data = '{0}'", data)
            Label4.Text = "Filtrato per il giorno " & data.ToShortDateString
            BTN_filtro.Visible = True
            BTN_filtro.Text = "Filtrato per Giorno"

        ElseIf iddip = 0 Or giorno = 0 Or e.ColumnIndex = DGV.Columns.Count - 1 Then
            RELcantieriPresenzeWeb.RemoveFilter()
            RELclientecontore.RemoveFilter()
            Label4.Text = "Nessun filtro attivato"
            BTN_filtro.Visible = False
            BTN_filtro.Text = "Nessun Filtro attivato"

        ElseIf iddip = giorno And e.ColumnIndex = 0 Then
            RELcantieriPresenzeWeb.Filter = String.Format("id_locazione = {0}", iddip)
            RELclientecontore.Filter = String.Format("id_dest = '{0}'", iddip)
            Label4.Text = "Filtrato per dettaglio Cliente " & DGV(0, e.RowIndex).Value
            BTN_filtro.Visible = True
            BTN_filtro.Text = "Filtrato per dettaglio cliente"

        Else
            Dim data As DateTime = New DateTime(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, e.ColumnIndex)
            RELcantieriPresenzeWeb.Filter = String.Format("giorno = '{0}' AND id_locazione = {1}", data, iddip)
            RELclientecontore.Filter = String.Format("data = '{0}' AND id_dest = {1}", data, iddip)
            Label4.Text = "Filtrato per dettaglio Cliente " & DGV(0, e.RowIndex).Value & " " & " il giorno " & giorno
            BTN_filtro.Visible = True
            BTN_filtro.Text = "Filtrato per dettaglio Cliente e Giorno"

        End If

    End Sub

    Private Sub riempie_riepilogo_giorni(ByVal cella As Integer, ByVal totale As Decimal, ByVal giorni As Integer, ByVal societa As String,
                                         ByVal note As String, ByVal idcli As Integer, ByRef DG_tmp As DataGridView, ByVal festivo As Integer,
                                         Optional ByVal iddip As Integer = 0, Optional ByVal idTipo As Integer = Nothing)

        'procedura per scrivere i valori nelle singole celle chiamate cella
        Dim dw As String() = New String() {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
        Dim ultimogiorno As Integer = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0).Day
        Dim ultimariga As Integer
        Dim colo As Color
        Dim Tipo As Integer
        ultimariga = DG_tmp.Rows.Count - 1
        If idTipo = Nothing Then
            Tipo = 1
        Else
            Tipo = idTipo
        End If
        'colo = DG_tmp(0, ultimariga).Style.BackColor
        Try

            'If nuovariga = True Then
            If cella = -1 And totale = -1 And giorni = -1 Then
                DG_tmp.Rows.Add()
                colo = DG_tmp(0, ultimariga).Style.BackColor
                DG_tmp.Rows(DG_tmp.Rows.Count - 1).Height = 2
                For CC = 1 To DG_tmp.Columns.Count
                    DG_tmp(CC, DG_tmp.Rows.Count - 1).Style.BackColor = Color.Black
                Next
                Return
            End If
            ultimariga = DG_tmp.Rows.Count - 1
            If DG_tmp(0, ultimariga).Tag = -2 Then
                colo = Color.LightGoldenrodYellow
                For CC = 0 To DG_tmp.Columns.Count - 1
                    DG_tmp(CC, ultimariga).Style.BackColor = colo
                Next
            Else
                colo = DG_tmp(0, ultimariga).Style.BackColor
            End If
        Catch ex As Exception

        End Try
        Dim nCelle As Integer = DG_tmp.Columns.Count
        If nCelle = 0 Then
            Return
        End If
        If cella = 0 Then
            DG_tmp.Rows.Add()
            ultimariga = DG_tmp.Rows.Count - 1
            If societa.Length > 0 Then
                DG_tmp(cella, ultimariga).Value = societa
                DG_tmp(cella, ultimariga).Tag = idcli
                DG_tmp(cella, ultimariga).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                DG_tmp(cella, ultimariga).Style.Font = New Font(FontFamily.GenericSerif, 9.0F, FontStyle.Regular, GraphicsUnit.Pixel)
                DG_tmp(cella, ultimariga).Style.BackColor = colo
            End If
        ElseIf cella > 0 And cella <= giorni Then
            'Se esiste un valore da pubblicare


            If totale > 0 Then

                ultimariga = DG_tmp.Rows.Count - 1
                Dim valorecella = DG_tmp(cella, ultimariga).Value
                Dim valorePrecedente As Decimal = 0
                Dim risultato As Boolean = Decimal.TryParse(valorecella, valorePrecedente)
                Dim ncarat
                Dim strtot
                strtot = Format(totale + valorePrecedente, "#0.0#")
                ncarat = strtot.Length
                DG_tmp(cella, ultimariga).Value = strtot
                If idcli > 0 Then
                    DG_tmp(cella, ultimariga).Tag = idcli
                Else
                    DG_tmp(cella, ultimariga).Tag = iddip
                End If
                If note <> Nothing Then
                    DG_tmp(cella, ultimariga).Style.ForeColor = Color.White
                    DG_tmp(cella, ultimariga).Style.BackColor = Color.DarkRed
                    DG_tmp(cella, ultimariga).ToolTipText = note
                Else
                    If Tipo > 0 Then
                        DG_tmp(cella, ultimariga).Style.ForeColor = Color.Red
                        DG_tmp(cella, ultimariga).Style.BackColor = colo
                    Else
                        DG_tmp(cella, ultimariga).Style.ForeColor = DefaultForeColor
                        DG_tmp(cella, ultimariga).Style.BackColor = colo
                    End If
                End If

                'DG_tmp.Columns(cella).Width = larghezza
            Else
                DG_tmp(cella, ultimariga).Style.BackColor = colo
                'DG_tmp.Columns(cella).Width = larghezza
            End If
        ElseIf cella > giorni Then
            Dim strtot = Format(totale, "#0.0#")
            Dim ncarat = strtot.Length
            ultimariga = DG_tmp.Rows.Count - 1
            DG_tmp(cella, ultimariga).Value = IIf(totale > 0, strtot, "")
            DG_tmp(cella, ultimariga).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            DG_tmp(cella, ultimariga).Style.Font = New Font(FontFamily.GenericSerif, 9.0F, FontStyle.Regular, GraphicsUnit.Pixel)
            DG_tmp(cella, ultimariga).Style.BackColor = colo
        End If

    End Sub



    Private Sub BTN_aggiornaPresenzeWeb_Click(sender As Object, e As EventArgs) Handles BTN_aggiornaPresenzeWeb.Click
        Dim RRll As DS_clienti.DT_cantieri_newRow
        RRll = DirectCast(BS_clienti_new.Current, DataRowView).Row

        Dim idDGW As Int32 = 0
        Dim oldRow As Int32 = 0

        If DG_presenzeRemote.Rows.Count > 0 Then
            oldRow = DG_presenzeRemote.CurrentRow.Index
            idDGW = DG_presenzeRemote(DGWCOLid.Index, oldRow).Value
        End If

        TA_presenzeWEB.FillByPeriodoTotale(Me.DS_clienti.DT_presenzeWEB, PeriodoLocale, RRll.id)
        ContaDG_totaliPresenzeWEB()

        Dim xr As Int32 = 0
        For Each riga As DataGridViewRow In DG_presenzeRemote.Rows
            If riga.Cells(DGWCOLid.Index).Value = idDGW Then
                DG_presenzeRemote.CurrentCell = DG_presenzeRemote(DGWCOLid.Index, xr)
            End If
            xr += 1
        Next

    End Sub


    Private Sub BTN_inviapresenze_Click(sender As Object, e As EventArgs) Handles BTN_inviapresenze.Click
        If BS_clienti_new.Count = 0 Then
            Return
        End If
        Dim RRll As DS_clienti.DT_cantieri_newRow
        RRll = DirectCast(BS_clienti_new.Current, DataRowView).Row

        Dim RGp As DS_utenti.DT_presenzeWEBRow
        Dim LunghezzaFiltro As Int16
        '
        ' Analizza se c'è un filtro impostato e chiede di disattivarlo
        '
        If Not IsNothing(RELcantieriPresenzeWeb.Filter) Then
            LunghezzaFiltro = CType(RELcantieriPresenzeWeb.Filter.Length, Int16)
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
        '
        '
        '
        RELcantieriPresenzeWeb.Filter = "auto = 0"
        If RELcantieriPresenzeWeb.Count > 0 Then
            For Each RGpw In RELcantieriPresenzeWeb
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
                Using ta As New DS_utentiTableAdapters.TA_contore
                    Risp = ta.trasferimentoweb(RGp.id, RGp.id_terminale, RGp.id_utente, RGp.id_locazione, RGp.inviato, RGp.giorno, Risultato2, Nota, RGp.data, Now)
                End Using
                If Risp <> 1 Then
                    MsgBox("Inserimento del " & RGp.data.ToShortDateString & " per la societa :" & RGp.societa & " non riuscito")
                Else
                    TA_presenzeWEB.inviato(1, RGp.id)
                End If
            Next
        End If

        RELcantieriPresenzeWeb.RemoveFilter()
        TA_presenzeWEB.FillByPeriodoTotale(Me.DS_clienti.DT_presenzeWEB, PeriodoLocale, RRll.id)
        If MsgBox("Vuoi stampare il riepilogo delle presenze ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            BTstampariepilogooreweb.PerformClick()
        End If

    End Sub

    Private Sub BT_aggiunge_Click(sender As Object, e As EventArgs) Handles BT_aggiunge.Click
        Dim iddes As Integer    'Dettaglio
        Dim giorno As DateTime
        Dim idter As Integer    'Terminale
        Dim idute As Integer    'Utente
        Dim ing As TimeSpan
        Dim usc As TimeSpan
        Dim inv As Int32
        Dim RGweb As DS_clienti.DT_presenzeWEBRow
        If RELcantieriPresenzeWeb.Count > 0 Then
            RGweb = DirectCast(RELcantieriPresenzeWeb.Current, DataRowView).Row
            iddes = RGweb.id_locazione
            idter = RGweb.id_terminale
            idute = RGweb.id_utente
            giorno = RGweb.giorno
            ing = RGweb.ingresso
            usc = RGweb.uscita
            inv = RGweb.inviato
        End If
        RELcantieriPresenzeWeb.AddNew()
        RGweb = DirectCast(RELcantieriPresenzeWeb.Current, DataRowView).Row
        RGweb.data = Now
        RGweb.giorno = giorno
        RGweb.id_locazione = iddes
        RGweb.id_terminale = idter
        RGweb.id_utente = idute
        RGweb.ingresso = ing
        RGweb.uscita = usc
        RGweb.inviato = inv
        RGweb.note = "Inserito da Ufficio"
        RELcantieriPresenzeWeb.EndEdit()
        Dim idx As Integer
        Using TA As New DS_utentiTableAdapters.TA_presenzeWEB
            TA.QRinserisci(GlobalVarPOP.G_idUtente, RGweb.id_terminale, RGweb.id_locazione, RGweb.id_utente, Now(), RGweb.giorno, RGweb.ingresso.ToString(), RGweb.uscita.ToString(), RGweb.note)
            idx = TA.QRultimoid
        End Using

        RGweb.id = idx
        RGweb.AcceptChanges()
        Dim F As New FrmDipendentiPresenzeWeb(idx, Me.DS_utenti.DT_clienti, Me.DS_utenti.DT_destinatari, Nothing, RGweb)
        F.ShowDialog()
        BTN_aggiornaPresenzeWeb.PerformClick()
    End Sub
    Private Sub BTN_eliminaore_Click(sender As Object, e As EventArgs) Handles BT_eliminaW.Click
        Dim RGweb As DS_clienti.DT_presenzeWEBRow
        RGweb = DirectCast(RELcantieriPresenzeWeb.Current, DataRowView).Row
        If MsgBox("sei sicuro di voler eliminare l'inserimento ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Using TA As New DS_utentiTableAdapters.TA_presenzeWEB
                TA.QRelimina(RGweb.id)
                DG_presenzeRemote.Rows.RemoveAt(DG_presenzeRemote.CurrentRow.Index)
                RGweb.AcceptChanges()
            End Using
        End If
    End Sub

    Private Sub DG_presenzeRemote_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_presenzeRemote.CellContentClick

        'Apre Form modifica delle presenze Remote

        If e.RowIndex >= 0 And e.ColumnIndex = DGWCOLid.Index Then
            Dim RG As DS_clienti.DT_presenzeWEBRow
            RG = DirectCast(RELcantieriPresenzeWeb.Current, DataRowView).Row
            Dim F As New FrmDipendentiPresenzeWeb(RG.id, Me.DS_clienti.DT_cantieri_new, Me.DS_clienti.DT_locazione_new, Nothing, RG)
            F.ShowDialog()

            If RG.RowState = DataRowState.Modified Then
#If DEBUG Then
                MsgBox("Riga modificata")
#End If
                TA_presenzeWEB.modificaPresenze(RG.id_terminale, RG.id_locazione, RG.giorno, RG.ingresso.ToString(), RG.uscita.ToString(), RG.note, RG.inviato, RG.id)
                RG.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub DG_presenzeRemote_CellContentValidate(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DG_presenzeRemote.CellValidating
        Dim RG As DS_clienti.DT_presenzeWEBRow
        RG = DirectCast(RELcantieriPresenzeWeb.Current, DataRowView).Row
        Dim tmpDG As DataGridView = DirectCast(sender, DataGridView)
        If tmpDG.IsCurrentCellDirty = True Then
            If e.RowIndex >= 0 And e.ColumnIndex = DG_presenzeRemote.Columns(7).Index Then  'se modifico le note
                If e.FormattedValue <> RG.note Then
                    RELcantieriPresenzeWeb.EndEdit()
                    'If MsgBox("Modifica la riga?") Then
                    TA_presenzeWEB.QRmodificanota(e.FormattedValue, RG.id)
                    RG.AcceptChanges()
                    'End If
                End If
            ElseIf e.RowIndex >= 0 And e.ColumnIndex = DGWColGiorno.Index Then  'se modifico la data
                If e.FormattedValue <> RG.giorno Then
                    RELcantieriPresenzeWeb.EndEdit()
                    'If MsgBox("Modifica la riga?") Then
                    Using TA As New DS_clientiTableAdapters.TA_presenzeWEB
                        TA.QRmodificagiorno(e.FormattedValue, RG.id)
                        RG.AcceptChanges()
                    End Using
                End If
            ElseIf e.RowIndex >= 0 And e.ColumnIndex = COLinviato.Index Then ' se convalido
                Dim Valore As Integer
                Valore = CType(e.FormattedValue, Integer)
                Using TA As New DS_utentiTableAdapters.TA_presenzeWEB
                    TA.QRconvalida(Valore, RG.id)
                    RG.AcceptChanges()
                End Using
            ElseIf e.RowIndex >= 0 And e.ColumnIndex = ingresso.Index Then
                Dim tmpF As String = e.FormattedValue.ToString.Replace(".", ":").Replace("-", ":").Replace(",", ":")
                Dim tmpOrario As TimeSpan = TimeSpan.Parse(tmpF)
                RG.ingresso = tmpOrario
                Dim tmpTotale As String = (RG.uscita - RG.ingresso).ToString("hh\:mm")
                RG.orario = tmpTotale
                TA_presenzeWEB.modificaPresenze(RG.id_terminale, RG.id_locazione, RG.giorno, RG.ingresso.ToString("hh\:mm"), RG.uscita.ToString("hh\:mm"), RG.note, RG.inviato, RG.id)
                RG.AcceptChanges()

            ElseIf e.RowIndex >= 0 And e.ColumnIndex = uscita.Index Then
                Dim tmpF As String = e.FormattedValue.ToString.Replace(".", ":").Replace("-", ":").Replace(",", ":")
                Dim tmpOrario As TimeSpan = TimeSpan.Parse(tmpF)
                RG.uscita = tmpOrario
                Dim tmpTotale As String = (RG.uscita - RG.ingresso).ToString("hh\:mm")
                RG.orario = tmpTotale
                TA_presenzeWEB.modificaPresenze(RG.id_terminale, RG.id_locazione, RG.giorno, RG.ingresso.ToString("hh\:mm"), RG.uscita.ToString("hh\:mm"), RG.note, RG.inviato, RG.id)
                RG.AcceptChanges()
            End If
        End If
    End Sub

    Private Sub BTNeliminaferie_Click(sender As Object, e As EventArgs)
        Dim RG As DSfestivita.DTferieclienteRow
        If BSferiecliente.Count > 0 Then
            RG = DirectCast(BSferiecliente.Current, DataRowView).Row
            If MsgBox("Vuoi Eliminare il periodo dal " & RG.inizio & " al " & RG.fine & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TAferiecliente.QRelimina(RG.id)
                RG.Delete()
            End If
        End If
    End Sub

    Private Sub ProgrammaChiusureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammaChiusureToolStripMenuItem.Click
        If TAB_clienti.SelectedTab.Name <> TB_pianodilavoro.Name Then
            TAB_clienti.SelectTab(TB_pianodilavoro)
        End If

    End Sub
    Private Function F_CreaDTprogrammazioneoraria(ByVal completo As Boolean) As DataView
        Dim rg As DS_clienti.DT_calRow
        Dim og As DS_clienti.DT_orariRow
        'utilizzato in caso di ferie del cliente

        Dim inizioferieD As DateTime ' Ferie per il dettaglio del Cliente
        Dim fineferieD As DateTime
        Dim inizioferieU As DateTime    ' Ferie per l'Utente
        Dim fineferieU As DateTime
        Dim festa As DateTime = New DateTime(2021, 8, 15)
        Dim Riga As Integer = 0
        Dim Periodo As String = PeriodoLocale.Replace("-", "").ToString
        Dim DT_prog As New DS_Stampe.DTchiusureclientiDataTable
        Dim D_set() As String = {"Do", "Lu", "Ma", "Me", "Gi", "Ve", "Sa"}
        Dim idCli As Integer = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")
        'Dim nSel As Integer = DG_cantieri_new.GetCellCount(DataGridViewElementStates.Selected)
        'Dim ID_tmp(nSel - 1) As Integer
        Dim Btmp As New BindingSource
        Using TA As New DS_clientiTableAdapters.TA_orari
            Using DT As New DS_clienti.DT_orariDataTable
                Try
                    TA.FillByClienteDestinatariAttivi(DT, idCli)
                    Btmp.DataMember = DT.TableName
                    Btmp.DataSource = DT
                Catch ex As Exception
                    Dim err As DataRow() = DT.GetErrors
#If DEBUG Then
                    For Each e In err
                        Console.WriteLine(e.RowError)
                    Next
#End If
                End Try
            End Using
        End Using
        og = Nothing
        For Each TT_id In DG_cantieri_new.SelectedRows
            Dim oldDip As Integer
            For Each j In Btmp  'scorre i dettagli cliente per il cliente attivo
                og = DirectCast(j, DataRowView).Row
                Using TMP As New DSfestivitaTableAdapters.TAferiecliente    'cerca la chiusura del cliente
                    Dim DT As New DSfestivita.DTferieclienteDataTable
                    Dim IDdett As Int32
                    IDdett = og.id_des
                    TMP.FillBydettaglioperiodo(DT, IDdett, Periodo)
                    If DT.Rows.Count > 0 Then
                        'BSferiecliente.Position = BSferiecliente.Find("periodo", Periodolocale)

                        inizioferieD = DT.Rows(0).Field(Of DateTime)("inizio")
                        fineferieD = DT.Rows(0).Field(Of DateTime)("fine")
                    Else
                        inizioferieD = Nothing
                        fineferieD = Nothing
                    End If
                End Using

                BS_cal.MoveFirst()
                If oldDip <> og.id_dip Then
                    oldDip = og.id_dip
                    Using TMP As New DSfestivitaTableAdapters.TAferieutente 'cerca le ferie dei dipendenti
                        Dim DT As New DSfestivita.DTferieutenteDataTable
                        TMP.FillByUtentePeriodo(DT, oldDip, Periodo)
                        If DT.Rows.Count > 0 Then
                            inizioferieU = DT.Rows(0).Field(Of DateTime)("inizio")
                            fineferieU = DT.Rows(0).Field(Of DateTime)("fine")
                        Else
                            inizioferieU = Nothing
                            fineferieU = Nothing
                        End If
                    End Using
                End If

                DT_prog.Rows.Add()
                Riga = DT_prog.Rows.Count - 1
                DT_prog.Rows(Riga).Item("cliente") = og.societa
                DT_prog.Rows(Riga).Item("dettaglio") = og.locazione
                DT_prog.Rows(Riga).Item("dipendente") = og.anagrafica
                DT_prog.Rows(Riga).Item("id_dip") = og.id_dip
                DT_prog.Rows(Riga).Item("id_des") = og.id_des
                DT_prog.Rows(Riga).Item("nmese") = TT_CB_mese.SelectedIndex + 1
                DT_prog.Rows(Riga).Item("anno") = TT_CB_anno.SelectedItem
                DT_prog.Rows(Riga).Item("mese") = TT_CB_mese.SelectedItem


                For Each l In BS_cal
                    rg = DirectCast(l, DataRowView).Row
                    Dim nW As Integer = Weekday(rg.giorno)
                    Dim Campo1 As String = D_set(nW - 1) & "_i"
                    Dim Campo2 As String = D_set(nW - 1) & "_u"
                    Dim sIng = If(og.Item(Campo1) <> "00:00", "X", "")
                    Dim sUsc = If(og.Item(Campo2) <> "00:00", "X", "")
                    Select Case True
                        Case rg.giorno = festa
                            DT_prog.Rows(Riga).Item("d" & rg.gm) = "H"  'In  Caso di Festività
                        Case rg.giorno >= inizioferieU And rg.giorno <= fineferieU And rg.giorno >= inizioferieD And rg.giorno <= fineferieD
                            DT_prog.Rows(Riga).Item("d" & rg.gm) = "H"  ' Se manca sia il cliente che il dipendente
                        Case rg.giorno >= inizioferieD And rg.giorno <= fineferieD
                            DT_prog.Rows(Riga).Item("d" & rg.gm) = "H" ' se le ferie sono del cliente
                        Case rg.giorno >= inizioferieU And rg.giorno <= fineferieU
                            DT_prog.Rows(Riga).Item("d" & rg.gm) = sIng & sUsc  ' se le ferie sono del dipendente
                        Case Else
                            DT_prog.Rows(Riga).Item("d" & rg.gm) = "----"
                    End Select
                Next
            Next
            '
            ' Se vuoi che vengano inserite anche le sostituzioni deve essere il valore a True
            '
            If completo Then

                Dim BSsost As New BindingSource
                Dim RGsost As DSfestivita.DTutentisostituzioniRow
                Using TA As New DSfestivitaTableAdapters.TAutentisostituzioni   'carica la tabella delle sostituzioni e la mette in un BSsost
                    Using DT As New DSfestivita.DTutentisostituzioniDataTable
                        TA.FillByClientenelperiodo(DT, og.id_cli, PeriodoLocale)
                        BSsost.DataSource = DT
                    End Using
                End Using
                If BSsost.Count > 0 Then
                    BSsost.Sort = "iddip,iddes"
                    Dim Biddip As Integer
                    For Each l In BSsost
                        RGsost = DirectCast(l, DataRowView).Row
                        Dim Ttotore As TimeSpan
                        Ttotore = RGsost.usc - RGsost.ing
                        If RGsost.iddip <> Biddip Then
                            Biddip = RGsost.iddip
                            DT_prog.Rows.Add()
                            Riga = DT_prog.Rows.Count - 1
                        End If
                        DT_prog.Rows(Riga).Item("cliente") = og.societa
                        DT_prog.Rows(Riga).Item("dettaglio") = RGsost.locazione
                        DT_prog.Rows(Riga).Item("dipendente") = RGsost.anagrafica
                        DT_prog.Rows(Riga).Item("id_dip") = RGsost.iddip
                        DT_prog.Rows(Riga).Item("id_des") = RGsost.iddes
                        DT_prog.Rows(Riga).Item("nmese") = TT_CB_mese.SelectedIndex + 1
                        DT_prog.Rows(Riga).Item("anno") = TT_CB_anno.SelectedItem
                        DT_prog.Rows(Riga).Item("mese") = TT_CB_mese.SelectedItem
                        DT_prog.Rows(Riga).Item("d" & RGsost.data.Day.ToString.PadLeft(2, "0")) = "S"
                    Next
                End If
            End If

        Next

        Dim dv As New DataView
        dv = DT_prog.DefaultView

        dv.Sort = "dettaglio"
        Return (dv)

    End Function


    Private Sub DG_Tmese_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_Tmese.CellDoubleClick 'apre la form delle sostituzioni
        Dim oldStileCella As New DataGridViewCellStyle
        Dim cella As DataGridViewCell
        cella = sender(e.ColumnIndex, e.RowIndex)

        Dim oTag As String
        oTag = cella.Tag
        If oTag = Nothing Then
            Return
        End If
        'Dim iddip As Int16 = DirectCast(BS_utenti.Current, DataRowView).Row.Item("id")
        Dim str0 As DateTime = DateTime.Parse(oTag.Split("|").Skip(1).First)
        Dim sData As String = str0.ToShortDateString
        Dim dData As Date = Date.Parse(sData)

        Dim bssos As BindingSource = New BindingSource
        Using dt As New DS_ag.DTsostituzioniDataTable
            Using ta As New DS_agTableAdapters.TAsostituzioni
                ta.FillByDaA(dt, dData, dData)
                bssos.DataMember = "utenti_sostituzioni"
                bssos.DataSource = dt
            End Using
        End Using
        Dim f As New FrmAgendaModifica(bssos, oTag, Nothing, Nothing, Me.DS_utenti.DT_utenti, Nothing, Nothing)

        f.ShowDialog()

        'se c'è stata una modifica allora aggiorna i dati.
        If f.Fsostituito Then
            'AggiornamentoRighe()
        End If

    End Sub

    Private Sub PianoDiLavoroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PianoDiLavoroToolStripMenuItem.Click

        Dim I_riga As DS_clienti.DT_cantieri_newRow
        I_riga = DirectCast(BS_clienti_new.Current, DataRowView).Row
        Dim n_IDCli As Integer
        Try
            n_IDCli = I_riga.id 'Memorizza il codice del cliente
            Dim s As New FRM_STP_OreClienti(-1, n_IDCli)
            s.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DGmacchinari_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGmacchinari.CellDoubleClick
        'Se doppio clicchi sugli articoli preimpostati

        'If BS_clienti_new.Count <= 0 Then
        '    Return
        'End If
        'Dim nuovoOrdine As Integer
        'Dim RGRmov As DSmacchinari.DTmovimentimacchineRow

        'Dim RRll As DS_clienti.DT_cantieri_newRow
        'RRll = DirectCast(BS_clienti_new.Current, DataRowView).Row
        ''nuovoOrdine = OttienenuovoOrdine()
        ''End Using
        'BSmovimentimacchine.AddNew()
        'RGRmov = DirectCast(BSmovimentimacchine.Current, DataRowView).Row
        'Dim RGD As DS_fattura.DT_fatturaArticoliRow
        ''RGRmov.idcliente = RRll.id
        ''RGRmov. = nuovoOrdine
        ''Using TA As New DS_clientiTableAdapters.TA_tipo_fatture_IVA_new
        ''    RGR.cfa_iva = TA.SQvaloreIVA(RGD.id_codiceIVA)   'Imposta il valore dell'IVA
        ''    'RGR.tipo_iva = TA.SQ_tipoIVA(RGD.fatturabile)
        ''End Using
        ''RGRmov.id_servizio
        'RGRmov.EndEdit()
        'DGmacchinari.Focus()
    End Sub
    Private Sub DG_fatturaArticoli_RowInserisce(sender As Object, e As DataGridViewCellEventArgs) Handles DGmacchinari.RowValidated
        ' si verifica quando convalido una nuova riga preimpostata
        'Dim nuovoprodotto As Integer
        Dim RGF As DSmacchinari.DTmovimentimacchineRow
        'Ricava l'ultimo ID
        'nuovoprodotto = TAmovimentimacchine.SQultimoID() + 1
        BSmovimentimacchine.EndEdit()
        RGF = DirectCast(BSmovimentimacchine.Current, DataRowView).Row
        Select Case RGF.RowState
            Case DataViewRowState.Added
                'RGF.id = nuovoprodotto
                'TAmovimentimacchine.inserisce(RGF.idmacchina, RGF.idlocazione, RGF.idutente, RGF.data, RGF.note, RGF.idcliente, RGF.id_servizio)
            Case DataViewRowState.ModifiedCurrent
                TAmovimentimacchine.modifica(RGF.idmacchina, RGF.idlocazione, RGF.idutente, RGF.data, RGF.note, RGF.idcliente, RGF.id_servizio, RGF.id)
        End Select
        RGF.AcceptChanges()
    End Sub

    Private Sub DGnote_RowInserisce(sender As Object, e As DataGridViewCellEventArgs) Handles DGnote.RowValidated
        ' si verifica quando convalido una nuova riga preimpostata

        Dim idCli As Integer
        If BS_clienti_new.Count > 0 Then
            idCli = DirectCast(BS_clienti_new.Current, DataRowView).Row.Field(Of Int32)("id")
        Else
            Return
        End If
        Dim aggiornato As Boolean = False

        For Each ff As DS_clienti.DTnoteRow In Me.DS_clienti.DTnote.Rows
            Select Case ff.RowState
                Case DataViewRowState.Added
                    'BSnote.EndEdit()
                    TAnote.inserisce(idCli, ff.iddet, ff.note, Now(), Now())
                    aggiornato = True
                Case DataViewRowState.ModifiedCurrent
                    TAnote.modifica(ff.idcli, ff.iddet, ff.note, Now(), ff.id)
                    aggiornato = True
            End Select
        Next
        If aggiornato Then
            TAnote.FillBycliente(Me.DS_clienti.DTnote, idCli)
        End If
    End Sub
    Private Sub DGnote_rowElimina(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DGnote.UserDeletingRow
        Dim tt As DataGridViewRow = e.Row

        Dim id As Integer = tt.Cells(DGWnoteid.Index).Value
        If MsgBox("Sei sicuro di voler eliminare la nota: " & tt.Cells("DGWnoteNote").Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TAnote.elimina(id)
        End If
        'For Each tt As DataRow In Me.DS_clienti.DTnote.Rows
        '    Console.WriteLine(tt.RowState & " ")
        'Next
    End Sub

    Private Sub BTstampaprogrammaferie_Click(sender As Object, e As EventArgs) Handles BTstampaprogrammaferie.Click
        Dim f As New frmDipendentiGestioneFerie
        f.Show()
    End Sub

    Private Sub BTNconvalidaweb_Click(sender As Object, e As EventArgs) Handles BTNconvalidaweb.Click
        Dim RG As DS_clienti.DT_presenzeWEBRow
        RG = DirectCast(RELcantieriPresenzeWeb.Current, DataRowView).Row
        If MsgBox("Sei sicuro di voler convalidare le presenze del dipendente ?" & RG.anagrafica, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            RELcantieriPresenzeWeb.EndEdit()
            'If MsgBox("Modifica la riga?") Then
            Using TA As New DS_utentiTableAdapters.TA_presenzeWEB
                TA.QRconvalidaildipendentenelperiodo(1, RG.id_utente, PeriodoLocale)
                BTN_aggiornaPresenzeWeb.PerformClick()
            End Using
        End If
    End Sub

    Private Sub BTstampariepilogooreweb_Click(sender As Object, e As EventArgs) Handles BTstampariepilogooreweb.Click
        'If Not StampaPresenzeWeb() Then
        '    MsgBox("Non sono presenti presenze")
        'End If
    End Sub

    Private Sub TTBTRicalcolaperFatture_Click(sender As Object, e As EventArgs) Handles TTBTRicalcolaperFatture.Click
        CalcolaOrdiniPresenzeperFatturazione()
    End Sub

    Private Sub tableLayoutPanel_CellPaint(sender As Object, e As TableLayoutCellPaintEventArgs) Handles TLPFatturazione.CellPaint

        Select Case e.Column
            Case 2

                If G_TLPfatturazioneordini = 1 Then
                    e.Graphics.FillRectangle(New SolidBrush(Color.Green), e.CellBounds)
                    LBfattureordini.Font = New Font(LBfattureordini.Font.Name, 12, FontStyle.Bold)
                    LBfattureordini.BackColor = Color.Green
                    LBfattureordini.Text = "Presenti Ordini"

                Else
                    e.Graphics.FillRectangle(New SolidBrush(DefaultBackColor), e.CellBounds)
                    LBfattureordini.Font = New Font(LBfattureordini.Font.Name, 8, FontStyle.Regular)
                    LBfattureordini.BackColor = DefaultBackColor
                    LBfattureordini.Text = "Nessun Ordine"

                End If

        End Select
    End Sub
    Private Function CalcolaOrdiniPresenzeperFatturazione()
        Dim RGll As DS_clienti.DT_cantieri_newRow
        RGll = DirectCast(BS_clienti_new.Current, DataRowView).Row
        G_TLPfatturazioneordini = 0
        G_TLPfatturazionepresenze = Nothing
        G_TLPfatturazionepresenzeTipo = Nothing
        Using DT As New DS_Ordini.DTordinirigheDataTable
            Using TA As New DS_OrdiniTableAdapters.TAordinirighe
                TA.Fill(DT, PeriodoLocale, RGll.id, G_idAZ)
            End Using
            For Each FRG As DS_Ordini.DTordinirigheRow In DT.Rows
                Console.WriteLine(FRG.id_ordine & " " & FRG.data_ordine)
                If FRG.fatturabile Then

                    G_TLPfatturazioneordini = 1
                Else
                    G_TLPfatturazioneordini = 0
                End If
            Next
        End Using
        Dim GranTotale As Decimal = 0
        Using DT As New DS_clienti.DT_presenzeWEBDataTable
            Using TA As New DS_clientiTableAdapters.TA_presenzeWEB
                Try
                    TA.FillByclientepresenzeTotale(DT, RGll.id, PeriodoLocale)
                Catch ex As Exception
                    Dim err As DataRow() = Me.DS_clienti.DT_presenzeWEB.GetErrors
                    For Each vv In err
                        Console.WriteLine(vv.RowError)
                    Next
                End Try

            End Using
            Dim DTG As EnumerableRowCollection(Of DS_clienti.DT_presenzeWEBRow)
            DTG = From v In DT Order By v.inviato Select v
            Dim DTgrp As Object
            DTgrp = DT.GroupBy(Of Integer)(Function(s) s.inviato).ToList
            Dim xx As Integer = 0


            If DTG.Count > 0 Then
                Dim oldTipo As Integer = DTG(0).Item("inviato")
                ReDim G_TLPfatturazionepresenze(DTgrp.Count)
                ReDim G_TLPfatturazionepresenzeTipo(DTgrp.Count)
                G_TLPfatturazionepresenze(0) = 0
                G_TLPfatturazionepresenzeTipo(0) = ""
                For Each RG In DTG
                    If oldTipo <> RG.inviato Then
                        oldTipo = RG.inviato
                        xx += 1
                    End If
                    If IsNothing(G_TLPfatturazionepresenze) Then
                        G_TLPfatturazionepresenze(xx) = 0
                        G_TLPfatturazionepresenzeTipo(xx) = ""
                    End If

                    If Not RG.IsorarioNull Then
                        If RG.orario = "00:00:00" Or RG.orario = "" Then
                            MsgBox("Attenzione c'è una presenza a somma 0 " & "id numero " & RG.id)
                        Else
                            G_TLPfatturazionepresenze(xx) += TimeSpan.Parse(RG.orario).TotalHours
                            GranTotale += If(RG.inviato <> 2, TimeSpan.Parse(RG.orario).TotalHours, 0)
                        End If
                    Else
                        MsgBox("Attenzione controllare le presenze di " & RG.anagrafica)
                    End If
                    G_TLPfatturazionepresenzeTipo(xx) = RG.descrizione

                Next

                G_TLPfatturazionepresenze(DTgrp.Count) = GranTotale
                G_TLPfatturazionepresenzeTipo(DTgrp.Count) = "Totale"

            Else
                G_TLPfatturazionepresenze = Nothing
            End If
        End Using
        Dim rrDettaglio As DS_clienti.DT_locazione_newRow
        Dim CanoneMensile As Decimal
        For Each rDettaglio In BSR_locazioni
            rrDettaglio = DirectCast(rDettaglio, DataRowView).Row
            If rrDettaglio.extra = 1 Then
                CanoneMensile += rrDettaglio.canone
            End If
        Next
        DGpresenzecliente.Columns.Clear()
        If Not IsNothing(G_TLPfatturazionepresenze) Then
            For tt = 0 To G_TLPfatturazionepresenze.Count - 1
                DGpresenzecliente.Columns.Add("col" & tt.ToString, G_TLPfatturazionepresenzeTipo(tt))
            Next
            DGpresenzecliente.Columns.Add("col" & G_TLPfatturazionepresenze.Count, "Canone")
            DGpresenzecliente.Columns.Add("col" & G_TLPfatturazionepresenze.Count + 1, "Resa")
            DGpresenzecliente.Rows.Add()
            For uu = 0 To G_TLPfatturazionepresenze.Count - 1
                DGpresenzecliente.Rows(0).Cells(uu).Value = G_TLPfatturazionepresenze(uu).ToString("n2")
            Next
            DGpresenzecliente.Rows(0).Cells(G_TLPfatturazionepresenze.Count).Value = CanoneMensile
            DGpresenzecliente.Rows(0).Cells(G_TLPfatturazionepresenze.Count + 1).Value = (CanoneMensile / GranTotale).ToString("n2")
        End If

        Return True

    End Function

    Private Sub DGVprogramma_CellPainting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles DGVprogramma.CellPainting

        If e.ColumnIndex >= 0 And e.RowIndex >= 0 Then
            Select Case True
                Case DGVprogramma(DGWCstato.Index, e.RowIndex).Value = 0
                    DGVprogramma.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightCoral
                Case DGVprogramma(DGWClicenzio.Index, e.RowIndex).Value = 1
                    DGVprogramma.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.Coral
                Case Else
                    DGVprogramma.Rows(e.RowIndex).DefaultCellStyle.BackColor = DefaultBackColor
            End Select
        End If
    End Sub
    Private Sub BTeliminaabbinamentiobsoleti_Click(sender As Object, e As EventArgs) Handles BTeliminaabbinamentiobsoleti.Click
        Using TA As New DS_clientiTableAdapters.DT_AUDPTableAdapter
            Using DT As New DS_clienti.DT_AUDPDataTable
                TA.Fill(DT)
                Dim CC As Integer = 0
                '
                ' Metodo poco ortodosso per contare quanti soddisfano la condizione di essere eliminati
                '
                Elencoobsoleti.Items.Clear()

                For Each RR As DS_clienti.DT_AUDPRow In DT.Rows
                    Dim xx, yy As Boolean
                    xx = If(RR.IslicenzioNull, 1, RR.licenzio)
                    yy = If(RR.IsstatoNull, 0, RR.stato)
                    If xx Or Not yy Then
                        Elencoobsoleti.Items.Add(RR.anagrafica & " in " & RR.locazione)
                        CC += 1
                    End If
                Next
                If Elencoobsoleti.Items.Count > 0 Then
                    Elencoobsoleti.Visible = True
                    TTPB.Maximum = CC
                    TTPB.Value = 0
                    CC = 0
                    If MsgBox("Sei sicuro di voler procedere all'eliminazione degli abbinamenti obsoleti ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                        For Each RR As DS_clienti.DT_AUDPRow In DT.Rows
                            Dim xx, yy As Boolean
                            xx = If(RR.IslicenzioNull, 1, RR.licenzio)
                            yy = If(RR.IsstatoNull, 0, RR.stato)
                            If xx Or Not yy Then
                                TA.elimina(RR.id)
                                CC += 1
                                RR.Delete()
                            End If
                            TTPB.Value = CC
                        Next
                    End If
                    Elencoobsoleti.Items.Clear()
                    Elencoobsoleti.Visible = False
                End If
            End Using
        End Using
        DT_AUDPTableAdapter.Fill(Me.DS_clienti.DT_AUDP)
        TTPB.Value = 0
    End Sub
    Private Sub PIC_cestino_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles PIC_cestino.DragDrop
        'Ottiene i dati di tipo string presenti in memoria
        For Each rgdg As DataGridViewRow In DGVprogramma.SelectedRows
            Dim s As Integer = rgdg.Cells(DGVprogrammaID.Index).Value
            DT_AUDPTableAdapter.elimina(s)
        Next
        DT_AUDPTableAdapter.Fill(Me.DS_clienti.DT_AUDP)
        e.Effect = DragDropEffects.None
    End Sub

    Private Sub DT_locazione_newDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwLocazione_newQR.CellContentClick
        Dim tmpDG As DataGridView = DirectCast(sender, DataGridView)
        Dim tmpCol As DataGridViewColumn = tmpDG.Columns(e.ColumnIndex)


        If btnGeneraQR.Name = tmpCol.Name Then
            Dim riga As DS_clienti.DT_locazione_newRow = DirectCast(BSR_locazioni.Current, DataRowView).Row
            Dim valore As String = ("id_terminale=" & riga.id_terminale & "&&id_locazione=" & riga.id)

            Using myAes As Aes = Aes.Create()
                Dim iv As String = "fTjWnZr4u7x!A%D*"
                Dim key As String = "hE#hsW-XzMm4/(Fs"
                myAes.KeySize = 128
                myAes.Mode = CipherMode.CBC
                myAes.IV = ASCIIEncoding.ASCII.GetBytes(iv)
                myAes.Key = ASCIIEncoding.ASCII.GetBytes(key)

                Dim encrypted As Byte() = EncryptStringToBytes_Aes(valore, myAes.Key, myAes.IV)
                Dim roundtrip As String = DecryptStringFromBytes_Aes(encrypted, myAes.Key, myAes.IV)
                Dim crittato As String = System.Convert.ToBase64String(encrypted)
                riga.qr = crittato

                TA_locazione_new.QR_modificadettagli(riga.descrizione, riga.email, riga.tmpPSWD, crittato, riga.id)
                riga.AcceptChanges()
                fnzPreparaQR()
                'stampaQrLocazione()
            End Using
        End If

    End Sub

    Private Shared Function EncryptStringToBytes_Aes(ByVal plainText As String, ByVal Key() As Byte, ByVal IV() As Byte) As Byte()
        ' Check arguments.
        If plainText Is Nothing OrElse plainText.Length <= 0 Then
            Throw New ArgumentNullException(NameOf(plainText))
        End If
        If Key Is Nothing OrElse Key.Length <= 0 Then
            Throw New ArgumentNullException(NameOf(Key))
        End If
        If IV Is Nothing OrElse IV.Length <= 0 Then
            Throw New ArgumentNullException(NameOf(IV))
        End If
        Dim encrypted() As Byte

        ' Create an Aes object
        ' with the specified key and IV.
        Using aesAlg As Aes = Aes.Create()

            aesAlg.Key = Key
            aesAlg.IV = IV

            ' Create an encryptor to perform the stream transform.
            Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
            ' Create the streams used for encryption.
            Using msEncrypt As New MemoryStream()
                Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    Using swEncrypt As New StreamWriter(csEncrypt)
                        'Write all data to the stream.
                        swEncrypt.Write(plainText)
                    End Using
                    encrypted = msEncrypt.ToArray()
                End Using
            End Using
        End Using

        ' Return the encrypted bytes from the memory stream.
        Return encrypted

    End Function 'EncryptStringToBytes_Aes

    Private Shared Function DecryptStringFromBytes_Aes(ByVal cipherText() As Byte, ByVal Key() As Byte, ByVal IV() As Byte) As String
        ' Check arguments.
        If cipherText Is Nothing OrElse cipherText.Length <= 0 Then
            Throw New ArgumentNullException(NameOf(cipherText))
        End If
        If Key Is Nothing OrElse Key.Length <= 0 Then
            Throw New ArgumentNullException(NameOf(Key))
        End If
        If IV Is Nothing OrElse IV.Length <= 0 Then
            Throw New ArgumentNullException(NameOf(IV))
        End If
        ' Declare the string used to hold
        ' the decrypted text.
        Dim plaintext As String = Nothing

        ' Create an Aes object
        ' with the specified key and IV.
        Using aesAlg As Aes = Aes.Create()
            aesAlg.Key = Key
            aesAlg.IV = IV

            ' Create a decryptor to perform the stream transform.
            Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)

            ' Create the streams used for decryption.
            Using msDecrypt As New MemoryStream(cipherText)

                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)

                    Using srDecrypt As New StreamReader(csDecrypt)


                        ' Read the decrypted bytes from the decrypting stream
                        ' and place them in a string.
                        plaintext = srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using

        Return plaintext

    End Function 'DecryptStringFromBytes_Aes 

    Private Sub TBdettagliocliente_Click(sender As Object, e As EventArgs) Handles TABdettaglio.SelectedIndexChanged
        Dim TMPpage As TabControl
        TMPpage = DirectCast(sender, TabControl)
        Dim RRll As DS_clienti.DT_cantieri_newRow
        Dim RRdd As DS_clienti.DT_locazione_newRow

        If BS_clienti_new.Count = 0 Then
            Return
        End If
        RRll = DirectCast(BS_clienti_new.Current, DataRowView).Row
        RRdd = DirectCast(BSR_locazioni.Current, DataRowView).Row

        Select Case TMPpage.SelectedTab.Name
            Case TABdettaglio.Name
                caricaNote(RRll.id)
        End Select
    End Sub
    Private Function caricaNote(ByVal id As Integer)
        Try
            Me.TAnote.FillBycliente(Me.DS_clienti.DTnote, id)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_clienti.DTnote.GetErrors
            Dim msg As New StringBuilder
#If DEBUG Then
            For Each eh In err
                MascheraAvvisi()
                LAvvisi.Items.Add(eh.RowError)
            Next
            FAvvisi.ShowDialog()
            FAvvisi.Close()
#End If
        End Try
        Return True
    End Function



    Private Function fnzPreparaQR()
        Dim Matrix(,) As Short
        Dim QRSize As Short
        Dim y As Short
        Dim x As Integer
        Dim intScale As Short
        Dim off As Single
        Dim result As vbQRCode.vbQRError

        Dim vbQRObj As vbQRCode
        Dim strValue As String
        Dim dimx As Integer = 120
        Dim dimy As Integer = 120

        Dim bmp As New Bitmap(dimx, dimy)
        Dim g As Graphics = Graphics.FromImage(bmp)

        Dim brushColor As Brush
        Dim blackBrush As Brush = New SolidBrush(Color.Black)
        Dim redBrush As Brush = New SolidBrush(Color.Red)
        Dim greenBrush As Brush = New SolidBrush(Color.Green)
        Dim yellowBrush As Brush = New SolidBrush(Color.Yellow)
        Dim blueBrush As Brush = New SolidBrush(Color.Blue)
        Dim blueWhite As Brush = New SolidBrush(Color.White)
        Dim orangeBrush As Brush = New SolidBrush(Color.Orange)
        Dim greenDarkBrush As Brush = New SolidBrush(Color.DarkOliveGreen)
        Dim lightBlueBrush As Brush = New SolidBrush(Color.LightBlue)
        g.Clear(Drawing.Color.Gainsboro)
        Dim RigaLocazione As DS_clienti.DT_locazione_newRow
        RigaLocazione = DirectCast(BSR_locazioni.Current, DataRowView).Row


        If ckDipendenti.Checked = True Then
            strValue = txIndirizzoPaginaQR.Text & RigaLocazione.qr
        Else
            strValue = txIndirizzoQRTemporanei.Text & RigaLocazione.qr
        End If



        vbQRObj = New vbQRCode
        vbQRObj.Version = 4 'cmbVersion.SelectedIndex - 4
        vbQRObj.FindBestMask = 1 '(chkFindBestMask.CheckState = System.Windows.Forms.CheckState.Checked)
        vbQRObj.ShowMarkers = 1 '(chkShowMarkers.CheckState = System.Windows.Forms.CheckState.Checked)
        vbQRObj.QuietZone = 0 'cmbQuietZone.SelectedIndex
        vbQRObj.ApplyTilde = 1 '(chkApplyTilde.CheckState = System.Windows.Forms.CheckState.Checked)
        vbQRObj.UTF8 = 0 '(chkUTF8.CheckState = System.Windows.Forms.CheckState.Checked)
        vbQRObj.EncodingMode = -1 'cmbEncoding.SelectedIndex - 1

        vbQRObj.ErrorLevel = vbQRCode.vbQRErrorLevel.qrLevelH

        'If (chkAddLogo.CheckState = System.Windows.Forms.CheckState.Checked) Then
        Dim logo(10) As String
        logo(0) = "06600000000"
        logo(1) = "06200008800"
        logo(2) = "00020088000"
        logo(3) = "00420858000"
        logo(4) = "00338580000"
        logo(5) = "00473377000"
        logo(6) = "00473337500"
        logo(7) = "04440000500"
        logo(8) = "04040000500"
        logo(9) = "04044000500"
        logo(10) = "40040000580"

        Call vbQRObj.AddLogo(logo)
        result = vbQRObj.Encode(strValue)
        If (result = vbQRCode.vbQRError.qrNoError) Then
            QRSize = vbQRObj.Size
            intScale = Int(dimx / QRSize)

            off = (dimx - intScale * QRSize) / 2

            Matrix = vbQRObj.Matrix()
            For y = 0 To QRSize - 1
                For x = 0 To QRSize - 1
                    brushColor = blueWhite
                    Select Case Matrix(y, x)
                        Case 1
                            brushColor = blackBrush
                        Case 2
                            brushColor = redBrush
                        Case 3
                            brushColor = greenBrush
                        Case 4
                            brushColor = yellowBrush
                        Case 5
                            brushColor = blueBrush
                        Case 6
                            brushColor = orangeBrush
                        Case 7
                            brushColor = greenDarkBrush
                        Case 8
                            brushColor = lightBlueBrush

                        Case Else
                    End Select
                    g.FillRectangle(brushColor, off + x * intScale, off + y * intScale, intScale, intScale)

                Next
            Next



            'Converte l'immagine in Byte()
            Dim bytes As Byte() = CType((New ImageConverter()).ConvertTo(bmp, GetType(Byte())), Byte())
            stampaQrLocazione(bytes)
            'PicCode.Image = bmp
        Else
            Select Case result
                Case vbQRCode.vbQRError.qrEmptyCode
                    MsgBox("Codice Vuoto !")
                Case vbQRCode.vbQRError.qrEncodeFailed
                    MsgBox("C'è un'errore nella codifica!")
                Case vbQRCode.vbQRError.qrTooManyData
                    MsgBox("Troppi dati nella codifica!")
                Case Else
                    MsgBox("Errore nella processazione dei dati!")
            End Select

        End If
        vbQRObj = Nothing
        Return True
    End Function

    Private Sub stampaQrLocazione(ByVal immagine As Byte())

        Dim locazione As String = dgwLocazione_newQR(dgwcLocazione.Index, dgwLocazione_newQR.CurrentRow.Index).Value

        Dim Row As DataRow = dtTesseriniQRlocazioniDataTable.NewRow()
        Row(0) = locazione
        Row(1) = immagine
        If ckDipendenti.Checked = True Then
            Row(2) = "PaleTurquoise"

        Else
            Row(2) = "Plum" '"PaleTurquoise""Tomato"
        End If

        dtTesseriniQRlocazioniDataTable.Rows.Add(Row)
        Dim miorpt As LocalReport = ReportViewer1.LocalReport
        Dim ds As ReportDataSource = New ReportDataSource()
        ds.Name = "DataSet1"
        ds.Value = dtTesseriniQRlocazioniDataTable

        'miorpt.ReportPath = "c:\\....\mioReport.rdlc"
        miorpt.DataSources.Clear()
        miorpt.DataSources.Add(ds)
        ReportViewer1.RefreshReport()

    End Sub

    Private Sub ckDipendenti_CheckedChanged(sender As Object, e As EventArgs) Handles ckDipendenti.CheckedChanged
        ckTemporanei.Checked = Not ckDipendenti.Checked
    End Sub

    Private Sub ckTemporanei_CheckedChanged(sender As Object, e As EventArgs) Handles ckTemporanei.CheckedChanged
        ckDipendenti.Checked = Not ckTemporanei.Checked
    End Sub

    Private Sub tabFerieClienti_indexChange(sender As Object, e As EventArgs) Handles tbcFerieCliente.SelectedIndexChanged
        Dim tabTMP As TabControl
        tabTMP = DirectCast(sender, TabControl)
        Select Case tabTMP.SelectedTab.Name
            Case tbFerieMensili.Name
                AggiornaRighe()
            Case tbFerieSommario.Name
                AggiornaRighe()
        End Select

    End Sub
    Private Sub tbGestionePresenze_selectIndex(sender As Object, e As EventArgs) Handles tbGestionePresenze.SelectedIndexChanged
        Dim tabTMP As TabControl
        tabTMP = DirectCast(sender, TabControl)
        Select Case tabTMP.SelectedTab.Name
            Case tbInseritoinAgenda.Name
                GeneraPianodiLavoroDipendente.F_caricaintestazioneMese(DG_Tmese, PeriodoLocale)
                Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
                Using ta As New DSfestivitaTableAdapters.TAtipoorario
                    ta.Fill(dtTipoOrario)
                End Using
                GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioCliente(DG_Tmese, dtUT, BS_clienti_new, BS_cal, PeriodoLocale, dtTipoOrario, True, ckFerieapprovate.Checked)
                'PubblicaTabellaPianoOrarioDipendente()
        End Select


    End Sub

    Private Sub RiempieilmioTreeView(ByVal nomeCliente As String, ByRef capitolato As dsPreventivi.tmpCapitolatoDataTable)

        twCapitolato.BeginUpdate()
        twCapitolato.Nodes.Clear()
        Dim node As New TreeNode
        node.Name = nomeCliente
        node.Text = nomeCliente
        twCapitolato.Nodes.Add(node)
        Dim dCapitolato = capitolato.OrderBy(Function(i) i.Dettaglio).ToLookup(Function(x) x.Dettaglio)
        For Each dd In dCapitolato
            node = New TreeNode
            node.Name = dd.Key
            node.Text = dd.Key
            twCapitolato.Nodes(nomeCliente).Nodes.Add(node)
            Dim cCapitolato = dd.OrderByDescending(Function(i) i.Categoria).ToLookup(Function(x) x.Categoria)
            For Each ff In cCapitolato
                node = New TreeNode
                node.Name = ff.Key
                node.Text = ff.Key
                twCapitolato.Nodes(nomeCliente).Nodes(dd.Key).Nodes.Add(node)
                Dim fCapitolato = ff.OrderBy(Function(i) i.Frequenza).ToLookup(Function(x) x.Frequenza)
                For Each gg In fCapitolato
                    node = New TreeNode
                    node.Name = gg.Key
                    node.Text = gg.Key
                    twCapitolato.Nodes(nomeCliente).Nodes(dd.Key).Nodes(ff.Key).Nodes.Add(node)
                    Dim oCapitolato = gg.OrderBy(Function(i) i.Operazione).ToLookup(Function(x) x.Operazione)
                    For Each oo In oCapitolato
                        node = New TreeNode
                        node.Name = oo.Key
                        node.Text = oo.Key
                        twCapitolato.Nodes(nomeCliente).Nodes(dd.Key).Nodes(ff.Key).Nodes(gg.Key).Nodes.Add(node)
                    Next
                Next
            Next
        Next
        Cursor.Current = System.Windows.Forms.Cursors.Default
        twCapitolato.EndUpdate()

    End Sub

    Private Sub dgwFerieCliente_delete(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgwFerieCliente.UserDeletingRow

        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        ' Contiene le righe selezionate delle ferie
        Dim tmpDgr As DataGridViewSelectedRowCollection
        tmpDgr = tmpDG.SelectedRows

        If IsDBNull(tmpDgr) Then
            Return
        End If
        Dim idCliente = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")

        TTPB.Value = 0
        TTPB.Maximum = tmpDgr.Count

        If MsgBox("Vuoi eliminare " + tmpDgr.Count.ToString() + " Ferie ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each tmpRR As DataGridViewRow In tmpDgr
                Dim id As Int16
                If IsDBNull(tmpRR) Then
                    Exit For
                End If
                id = tmpRR.Cells(dgwcIDferie.Index).Value
                TAferiecliente.QRelimina(id)
            Next
            e.Cancel = False
            AggiornaRighe()
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub dgwFerieCliente_adding(sender As Object, e As DataGridViewCellEventArgs) Handles dgwFerieCliente.RowValidated
        Dim tmpDG As DataGridView
        tmpDG = DirectCast(sender, DataGridView)
        ' Contiene le righe selezionate delle ferie
        Dim tmpDgr As DataGridViewRow
        tmpDgr = tmpDG.Rows(e.RowIndex)
        If IsDBNull(tmpDgr) Then
            Return
        End If
        If Not tmpDgr.IsNewRow Then
            Dim id As Int16 = tmpDgr.Cells(dgwcIDferie.Index).Value

            Dim idCliente = DirectCast(BS_clienti_new.Current, DataRowView).Row.Item("id")
            Dim datainizio As DateTime = If(IsDBNull(tmpDgr.Cells(dgwcInizioFerie.Index).Value), Now().ToString, DateTime.Parse(tmpDgr.Cells(dgwcInizioFerie.Index).Value))
            Dim datafine As DateTime = If(IsDBNull(tmpDgr.Cells(dgwcFineFerie.Index).Value), Now(), DateTime.Parse(tmpDgr.Cells(dgwcFineFerie.Index).Value))
            Dim objN As Object
            objN = tmpDgr.Cells(dgwcNoteFerie.Index).Value
            Dim Note As String
            If Not IsDBNull(objN) Then
                If objN = "False" Then
                    objN = ""
                End If
                Note = objN
            End If



            Dim idDettaglio As Int16 = Int16.Parse(tmpDgr.Cells(dgwcLocazioneFerie.Index).Value)
            If id < 0 Then
                TAferiecliente.QRinserisci(idCliente, idDettaglio, datainizio, datafine, Note)
            Else
                TAferiecliente.QRmodifica(idCliente, idDettaglio, datainizio, datafine, Note, id)
            End If
            Me.TAferiecliente.FillByidClientePeriodo(Me.DSfestivita.DTferiecliente, idCliente, PeriodoLocale.Replace("-", "").ToString)
            AggiornaRighe()
        End If

    End Sub

    Private Sub DG_locazioni_new_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DG_locazioni_new.UserDeletingRow
        Dim id As Int16
        Dim dgwTmp As DataGridView
        dgwTmp = DirectCast(sender, DataGridView)
        id = dgwTmp(dgwcIDdestinatario.Index, e.Row.Index).Value
        Dim locazione As String
        locazione = dgwTmp(LocazioneDataGridViewTextBoxColumn4.Index, e.Row.Index).Value

        If MsgBox("Vuoi eliminare il destinatario" & vbCrLf & locazione & " dalla anagrafica ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TA_locazione_new.QR_Elimina(id)
            e.Cancel = False
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub rb_CheckedChanged(sender As Object, e As EventArgs) Handles rbUp.CheckedChanged, rbMd.CheckedChanged, rbDn.CheckedChanged
        Dim rbTMP As RadioButton
        rbTMP = DirectCast(sender, RadioButton)
        If rbTMP.Checked Then
            Select Case rbTMP.Name
                Case "rbMd"
                    TBL_pianodilavoro.RowStyles(2).SizeType = SizeType.Percent
                    TBL_pianodilavoro.RowStyles(2).Height = 50
                    TBL_pianodilavoro.RowStyles(4).SizeType = SizeType.Percent
                    TBL_pianodilavoro.RowStyles(4).Height = 30
                    TBL_pianodilavoro.RowStyles(6).SizeType = SizeType.Percent
                    TBL_pianodilavoro.RowStyles(6).Height = 20
                Case "rbDn"
                    TBL_pianodilavoro.RowStyles(2).SizeType = SizeType.Percent
                    TBL_pianodilavoro.RowStyles(2).Height = 1
                    TBL_pianodilavoro.RowStyles(4).SizeType = SizeType.Percent
                    TBL_pianodilavoro.RowStyles(4).Height = 70
                    TBL_pianodilavoro.RowStyles(6).SizeType = SizeType.Percent
                    TBL_pianodilavoro.RowStyles(6).Height = 20

                Case "rbUp"
                    TBL_pianodilavoro.RowStyles(2).SizeType = SizeType.Percent
                    TBL_pianodilavoro.RowStyles(2).Height = 70
                    TBL_pianodilavoro.RowStyles(4).SizeType = SizeType.Percent
                    TBL_pianodilavoro.RowStyles(4).Height = 1
                    TBL_pianodilavoro.RowStyles(6).SizeType = SizeType.Percent
                    TBL_pianodilavoro.RowStyles(6).Height = 20
            End Select
        End If


    End Sub

    Private Sub btLeggenda_Click(sender As Object, e As EventArgs) Handles btLeggenda.Click


        Dim g As New Form
        g.Name = "frmLeggendaColoriAssenze"

        For Each oForm As Form In System.Windows.Forms.Application.OpenForms
            If oForm.Name = g.Name Then
                oForm.Close()
                btLeggenda.Text = "Leggenda"
                Return
            End If
        Next
        btLeggenda.Text = "Chiude Leggenda"

        Dim coordinate As Point
        coordinate = Me.MousePosition
        g.StartPosition = FormStartPosition.Manual
        coordinate.Y = coordinate.Y - 200
        coordinate.X = coordinate.X + 50
        g.Location = coordinate
        g.Width = 250
        g.Height = 400
        g.FormBorderStyle = FormBorderStyle.None
        g.ControlBox = False


        Dim dgW As DataGridView = New DataGridView
        Dim colore As Color

        dgW.Name = "dgwLeggenda"
        dgW.Dock = DockStyle.Fill
        dgW.Columns.Add("dgwcLColore", "Colore")
        'dgW.Columns.Add("dgwcLDescrizione", "Descrizione")
        dgW.RowHeadersVisible = False
        For i As Integer = 0 To dgW.Columns.Count - 1
            dgW.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        Next
        Using ta As New DSfestivitaTableAdapters.TAtipoorario
            ta.Fill(Me.DSfestivita.DTtipoorario)
        End Using
        Dim k1 As DataGridViewCellStyle
        Dim riga As Int16
        For Each rg In Me.DSfestivita.DTtipoorario.Rows
            colore = Color.FromName(rg("colore"))
            dgW.Rows.Add(1)
            k1 = New DataGridViewCellStyle
            k1.ForeColor = Color.Black
            k1.BackColor = colore
            k1.Font = New Font("Arial", 8, FontStyle.Regular)
            k1.Alignment = DataGridViewContentAlignment.MiddleCenter

            dgW(0, riga).Style = k1
            dgW(0, riga).Value = rg("descrizione")
            riga += 1

        Next

        g.Controls.Add(dgW)
        g.Show()

    End Sub

    Private Sub btRigenera_Click(sender As Object, e As EventArgs) Handles btRigenera.Click
        AggiornaRighe()
    End Sub

    Private Sub dgwFerieCliente_CellDataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgwFerieCliente.DataError
        e.Cancel = False
    End Sub

    Private Sub dgwElencoFerieCliente_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgwElencoFerieCliente.DataError
        e.Cancel = False
    End Sub

    Private Sub ckFerieapprovate_CheckedChanged(sender As Object, e As EventArgs) Handles ckFerieapprovate.CheckedChanged
        If ckFerieapprovate.Checked Then
            ckFerieapprovate.Text = "Ferie confermate"
        Else
            ckFerieapprovate.Text = "Ferie da confermare"
        End If
    End Sub

    Private Sub txRicercaDocumento_TextChanged(sender As Object, e As EventArgs) Handles txRicercaDocumento.TextChanged
        Dim tmp As TextBox
        tmp = DirectCast(sender, TextBox)
        Do While True
            bsfiles.Filter = String.Format("description LIKE '%{0}%' or title LIKE '%{0}%'", tmp.Text)
            If bsfiles.Count > 0 Then
                Exit Do
            Else
                tmp.Text = tmp.Text.Substring(0, tmp.Text.Length - 1)
                tmp.SelectionStart = tmp.TextLength
            End If
        Loop
    End Sub

    Private Sub GeneraCapitolatoDaPreventivoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GeneraCapitolatoDaPreventivoToolStripMenuItem.Click

        Dim rrll As DS_clienti.DT_cantieri_newRow
        rrll = DirectCast(BS_clienti_new.Current, DataRowView).Row


        Using dt As New dsPreventivi.dtCapitolatoDataTable
            Using ta As New dsPreventiviTableAdapters.taCapitolato
                ta.FillByCliente(dt, rrll.id, 1)
            End Using


            Dim tmpcap As New dsPreventivi.tmpCapitolatoDataTable
            tmpcap.Rows.Clear()
            tmpcap.AcceptChanges()
            Dim x As Int16
            For Each rg As dsPreventivi.dtCapitolatoRow In dt.Rows
                x += 1
                tmpcap.Rows.Add(x, rg.id_destinatario_preventivo, rg.id_categoria, rg.id_frequenza, rg.id_operazioni, rg.locazione, rg.categoria, rg.frequenza, rg.descrizione, rg.sort)
            Next



            Dim dCapitolato = tmpcap.OrderBy(Function(i) i.Dettaglio).ToLookup(Function(h) h.Dettaglio)

            For Each dd In dCapitolato
                Dim path As New SaveFileDialog()
                With path
                    .InitialDirectory = "C:\Users\utente\Desktop\"
                    .Title = "Schegli dove salvare il file"
                    .FileName = "Capitolato " & rrll.societa & "-" & dd.Key
                    .AddExtension = True
                    .DefaultExt = "pdf"
                End With
                Dim docPos As String
                If path.ShowDialog() = DialogResult.OK Then
                    docPos = path.FileName
                Else
                    Return
                End If

                Dim lista As New List(Of String)

                lista = Riempieilmiotesto(dd.Key, tmpcap.Where(Function(y) y.Dettaglio = dd.Key))
                Call CreaPDFCapitolato(rrll.societa, docPos, lista)

            Next
        End Using

    End Sub

    Private Function CreaPDFCapitolato(ByVal titolo As String, ByVal Posizione As String, lista As List(Of String))
        Using pdfLetto As New iText.Kernel.Pdf.PdfReader(Posizione)
            Using pdfScritto As New iText.Kernel.Pdf.PdfWriter(Posizione)
                ' Ottieni le dimensioni del foglio
                Using pdfDocumento As New iText.Kernel.Pdf.PdfDocument(pdfLetto, pdfScritto)
                    'Questo è il documento editabile
                    Using document = New iText.Layout.Document(pdfDocumento)
                        Dim pdfDocumentoInfo As iText.Kernel.Pdf.PdfDocumentInfo = pdfDocumento.GetDocumentInfo()
                        Dim pageSize As iText.Kernel.Geom.Rectangle
                        pageSize = pdfDocumento.GetPage(1).GetPageSize

                        'Dimensioni del foglio in punti
                        Dim widthInPoints As Single = pageSize.GetWidth()
                        Dim heightInPoints As Single = pageSize.GetHeight()

                        'Conversione delle dimensioni da punti a pollici
                        Dim widthInInches As Single = widthInPoints / 72.0F
                        Dim heightInInches As Single = heightInPoints / 72.0F

                        Dim immagine As System.Drawing.Image = System.Drawing.Image.FromHbitmap(Comuni.My.Resources.logocolor.GetHbitmap())
                        Dim memoryStream As New System.IO.MemoryStream()
                        'Salva l'immagine in formato PNG nel memory stream
                        immagine.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png)
                        'Crea un oggetto Image di iText utilizzando il memory stream
                        Dim logo As New iText.Layout.Element.Image(iText.IO.Image.ImageDataFactory.Create(memoryStream.ToArray()))

                        'Imposta la scala dell'immagine
                        logo.ScaleAbsolute(75, 80)

                        'Imposta l'allineamento dell'immagine
                        logo.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.RIGHT)

                        'Aggiungi l'immagine al documento
                        document.Add(logo)

                        'Creazione dei paragrafi
                        Dim Font = iText.Kernel.Font.PdfFontFactory.CreateFont("Arial")
                        Dim ParTitolo As New iText.Layout.Element.Paragraph()
                        Dim TitoloPDF As String = ""
                        Dim ParagrafoPDF As String
                        Dim testoDelTitolo As New iText.Layout.Element.Text(TitoloPDF)
                        testoDelTitolo.SetFont(Font).SetItalic()
                        ParTitolo.Add(testoDelTitolo)

                        Dim ParTesto As New iText.Layout.Element.Paragraph()
                        Dim TestoDelParagrafo As New iText.Layout.Element.Text("Testo del paragrafo")
                        TestoDelParagrafo.SetFont(Font).SetBold()
                        ParTesto.Add(ParTitolo)

                        document.Add(ParTitolo)

                        For Each riga In lista
                            Dim comando As String = ""
                            comando = riga.Substring(0, 4)
                            Select Case comando
                                Case "tit."
                                    TitoloPDF = riga.Substring(4, riga.Length - 4)
                                    ParTitolo = New iText.Layout.Element.Paragraph()
                                    testoDelTitolo = New iText.Layout.Element.Text(TitoloPDF)
                                    testoDelTitolo.SetFont(Font).SetItalic().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                                    ParTitolo.Add(testoDelTitolo)
                                    document.Add(ParTitolo)
                                Case "cat."
                                    ParagrafoPDF = riga.Substring(4, riga.Length - 4)
                                    ParTesto = New iText.Layout.Element.Paragraph()
                                    TestoDelParagrafo = New iText.Layout.Element.Text(ParagrafoPDF)
                                    TestoDelParagrafo.SetFont(Font).SetItalic().SetTextAlignment(iText.Layout.Properties.TextAlignment.CENTER)
                                    ParTesto.Add(TestoDelParagrafo)
                                    document.Add(ParTesto)
                                Case "fre."
                                    ParagrafoPDF = riga.Substring(4, riga.Length - 4)
                                    ParTesto = New iText.Layout.Element.Paragraph()
                                    TestoDelParagrafo = New iText.Layout.Element.Text(ParagrafoPDF)
                                    TestoDelParagrafo.SetFont(Font).SetItalic().SetUnderline().SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                                    ParTesto.Add(TestoDelParagrafo)
                                    document.Add(ParTesto)
                                Case "ope."
                                    ParagrafoPDF = riga.Substring(4, riga.Length - 4)
                                    ParTesto = New iText.Layout.Element.Paragraph()
                                    TestoDelParagrafo = New iText.Layout.Element.Text(ParagrafoPDF)
                                    TestoDelParagrafo.SetFont(Font).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                                    ParTesto.Add(TestoDelParagrafo)
                                    document.Add(ParTesto)
                            End Select
                        Next
                        ParagrafoPDF = "tutti i diritti sono riservati, è vietata la copia"
                        ParTesto = New iText.Layout.Element.Paragraph()
                        TestoDelParagrafo = New iText.Layout.Element.Text(ParagrafoPDF)
                        TestoDelParagrafo.SetFont(Font).SetTextAlignment(iText.Layout.Properties.VerticalAlignment.BOTTOM).SetTextAlignment(iText.Layout.Properties.TextAlignment.LEFT)
                        ParTesto.Add(TestoDelParagrafo)
                        document.Add(ParTesto)
                        'ParTesto.Alignment = iTextSharp.text.Element.HEADER
                        'File nel quale inserire la filigrana
                        pdfDocumentoInfo.SetAuthor("Ufficio Tecnico Pegaso")
                        pdfDocumentoInfo.SetCreator("Danilo Enrico Solidoro")
                        pdfDocumentoInfo.SetTitle(titolo)
                        pdfDocumentoInfo.SetSubject(TitoloPDF)
                    End Using

                End Using

            End Using

        End Using

        Call aggiungenumeripaginaPDF(Posizione, titolo)
        Call filigrana(Posizione)
    End Function
    Private Sub aggiungenumeripaginaPDF(ByVal posizione As String, ByVal nomecliente As String)
        Dim oldFile As String = posizione

        Dim newFile As String = posizione.Replace(".pdf", "0.pdf")

        'Dim reader As iText.Kernel.Pdf.PdfReader = Nothing

        'Dim stamper As iText.Kernel.Pdf.PdfStamper = Nothing

        'Dim cb As iText.Kernel.Pdf.PdfContentByte = Nothing

        'Dim page As iTextSharp.text.Rectangle = Nothing

        'Try
        '    reader = New iText.Kernel.Pdf.PdfReader(oldFile)
        '    page = reader.GetPageSizeWithRotation(1)
        '    stamper = New iText.Kernel.Pdf.PdfStamper(reader, New System.IO.FileStream(newFile, IO.FileMode.Create))

        '    Dim ct As iText.Kernel.Pdf.ColumnText
        '    For i = 1 To reader.NumberOfPages
        '        cb = stamper.GetOverContent(i)
        '        ct = New iText.Kernel.Pdf.ColumnText(cb)
        '        ct.Alignment = iTextSharp.text.Element.ALIGN_LEFT
        '        Dim altezza, larghezza As Integer
        '        altezza = iTextSharp.text.PageSize.A4.Height
        '        larghezza = iTextSharp.text.PageSize.A4.Width
        '        ct.SetSimpleColumn(70, 86, larghezza - 36, altezza - 86)
        '        Dim nTbl As iText.Kernel.Pdf.PdfPTable = New iText.Kernel.Pdf.PdfPTable(2)
        '        Dim rows As Single() = {135.0F, 135.0F}
        '        'set row width 
        '        'nTbl.SetTotalWidth(rows)
        '        nTbl.AddCell(New iTextSharp.text.Paragraph("Capitolato tecnico " & nomecliente & " Pagina " & i.ToString & " di " & reader.NumberOfPages.ToString, iTextSharp.text.FontFactory.GetFont("Arial", 8)))
        '        Dim par As iTextSharp.text.Paragraph = New iTextSharp.text.Paragraph("Stampato il " & Now.ToShortDateString, iTextSharp.text.FontFactory.GetFont("Arial", 8))
        '        par.Alignment = iTextSharp.text.Element.ALIGN_RIGHT
        '        nTbl.AddCell(par)
        '        nTbl.TotalWidth = page.Width - 60
        '        Dim marginedestro, marginebasso As Int16
        '        marginedestro = 30
        '        marginebasso = 30
        '        nTbl.WriteSelectedRows(0, -1, marginedestro, marginebasso, stamper.GetOverContent(i))
        '        'nTbl.WriteSelectedRows(0, 50, 40, altezza, stamper.GetOverContent(i))
        '    Next
        '    stamper.Close()
        '    reader.Close()
        '    ct.Go()
        '    IO.File.Delete(posizione)
        'Catch
        'End Try

    End Sub
    Private Sub filigrana(ByVal Posizione As String)
        'Posizione = Posizione.Replace(".pdf", "0.pdf")
        'Dim nuovaPosizione = Posizione.Replace("0.pdf", ".pdf")
        'Dim pdfReader As New iText.Kernel.Pdf.PdfReader(Posizione)
        'Dim numeroPagine As Int16 = pdfReader.NumberOfPages
        'Dim data As DateTime = Now
        'Dim pdfStamper As New iText.Kernel.Pdf.PdfStamper(pdfReader, New FileStream(nuovaPosizione, FileMode.Create))
        ''file pdf con la filigrana da applicare
        'Dim pdfReaderFiligrana As New iText.Kernel.Pdf.PdfReader("\\192.168.166.254\ufficio\Marchi\pdffiligranato.pdf")
        ''byte del filigrana
        'Dim filigranaDaApplicare As iText.Kernel.Pdf.PdfContentByte
        ''Applico la filigrana per ogni pagina
        'For ContaPagine As Integer = 1 To numeroPagine
        '    filigranaDaApplicare = pdfStamper.GetOverContent(ContaPagine)
        '    Dim gsTrasparenza As New iText.Kernel.Pdf.PdfGState() With {.FillOpacity = 0.3F}
        '    filigranaDaApplicare.SetGState(gsTrasparenza)
        '    filigranaDaApplicare.AddTemplate(pdfStamper.GetImportedPage(pdfReaderFiligrana, 1), 0, 0)
        'Next
        'pdfStamper.FormFlattening = True
        'pdfStamper.Close()
        'pdfReader.Close()
        'pdfReaderFiligrana.Close()

        'IO.File.Delete(Posizione)
    End Sub

    Private Function Riempieilmiotesto(ByVal nomecliente As String, ByRef capitolato As EnumerableRowCollection(Of dsPreventivi.tmpCapitolatoRow)) As List(Of String)

        Dim mioTesto As New List(Of String)
        mioTesto.Add("tit." & nomecliente)
        If IsDBNull(capitolato) Then
            Return Nothing
        End If


        Dim cCapitolato = capitolato.OrderByDescending(Function(i) i.sort).ToLookup(Function(x) x.Categoria)
        For Each ff In cCapitolato
            mioTesto.Add("cat." & ff.Key)
            Dim fCapitolato = ff.OrderBy(Function(i) i.sort).ToLookup(Function(x) x.Frequenza)
            For Each gg In fCapitolato
                mioTesto.Add("fre." & gg.Key)
                Dim oCapitolato = gg.OrderBy(Function(i) i.sort).ToLookup(Function(x) x.Operazione)
                For Each oo In oCapitolato
                    mioTesto.Add("ope." & oo.Key)
                Next
            Next
        Next
        Return mioTesto
    End Function


    Private Sub dgwRegistroSegnalazioni_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgwRegistroSegnalazioni.DataError
#If DEBUG Then
        Dim problema As String
        problema = dgwRegistroSegnalazioni(e.ColumnIndex, e.RowIndex).Value
        Console.WriteLine("Problema nella colonna " & e.ColumnIndex.ToString)
        Console.WriteLine("Problema riga " & e.RowIndex.ToString)
        Console.WriteLine("valore " & problema)
#End If

    End Sub
    Private Sub dgwRegistroSegnalazioni_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgwRegistroSegnalazioni.RowValidated
        Dim idCli As Integer
        If BS_clienti_new.Count > 0 Then
            idCli = DirectCast(BS_clienti_new.Current, DataRowView).Row.Field(Of Int32)("id")
        Else
            Return
        End If
        'Dim iddes As Int16 = 0
        Dim aggiornato As Boolean = False
        BsCantieriSegnalazioni.EndEdit()

        For Each ff As DS_clienti.dtCantieriSegnalazioniRow In Me.DS_clienti.dtCantieriSegnalazioni

            Select Case ff.RowState
                Case DataViewRowState.Added
                    'BSnote.EndEdit()
                    If ff.IsdataverificaNull Then
                        ff.dataverifica = DateAdd(DateInterval.Month, 1, Now())
                    End If
                    If ff.IsdatasegnalazioneNull Then
                        ff.datasegnalazione = Now()
                    End If
                    If ff.IsdatachiusuraNull Then
                        ff.datachiusura = Nothing
                    End If
                    If ff.IsdataregistrazioneNull Then
                        ff.dataregistrazione = Now()
                    End If
                    If ff.IsrisoluzioneNull Then
                        ff.risoluzione = 0
                    End If
                    If ff.IsnoteNull Then
                        ff.note = Nothing
                    End If
                    If ff.IssoluzioneNull Then
                        ff.soluzione = Nothing
                    End If
                    If ff.IscausaNull Then
                        ff.causa = Nothing
                    End If
                    TaCantieriSegnalazioni.InsertQuery(GlobalVarPOP.G_idUtente, idCli, ff.id_des, ff.dataregistrazione, ff.datasegnalazione,
                                                       ff.originesegnalazione, ff.descrizionesegnalazione, ff.gravita, ff.dataverifica, ff.azionerisolutiva, ff.datachiusura, ff.risoluzione,
                                                       ff.causa, ff.soluzione, ff.note)
                    aggiornato = True
                    ff.AcceptChanges()
                Case DataViewRowState.ModifiedCurrent
                    If ff.IsdataverificaNull Then
                        ff.dataverifica = DateAdd(DateInterval.Month, 1, Now())
                    End If
                    If ff.IsdatasegnalazioneNull Then
                        ff.datasegnalazione = Now()
                    End If
                    If ff.IsdatachiusuraNull Then
                        ff.datachiusura = Nothing
                    End If
                    If ff.IsnoteNull Then
                        ff.note = Nothing
                    End If
                    If ff.IssoluzioneNull Then
                        ff.soluzione = Nothing
                    End If
                    If ff.IscausaNull Then
                        ff.causa = Nothing
                    End If
                    TaCantieriSegnalazioni.UpdateQuery(GlobalVarPOP.G_idUtente, idCli, ff.id_des, ff.dataregistrazione, ff.datasegnalazione,
                                                        ff.originesegnalazione, ff.descrizionesegnalazione, ff.gravita, ff.dataverifica, ff.azionerisolutiva, ff.datachiusura, ff.risoluzione,
                                                        ff.causa, ff.soluzione, ff.note, ff.id)
                    aggiornato = True
                    ff.AcceptChanges()
                Case DataViewRowState.Deleted
                    ff.RejectChanges()
                    If MsgBox("Confermi l'eliminazione della segnalazione: " & ff.descrizionesegnalazione & vbCrLf & "effettuata da " & ff.originesegnalazione, MsgBoxStyle.YesNo, "ATTENZIONE") = MsgBoxResult.Yes Then
                        TaCantieriSegnalazioni.DeleteQuery(ff.id)
                    End If
                    aggiornato = True
            End Select
        Next
        If aggiornato Then
            AggiornaRighe()
        End If
    End Sub

    Private Sub dgwRegistroSegnalazioni_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwRegistroSegnalazioni.CellDoubleClick
        Dim idCli, oldIDDes As Integer
        Dim OldDestinatario As String
        Dim rgSegnalazione As DS_clienti.dtCantieriSegnalazioniRow

        If BS_clienti_new.Count > 0 Then
            idCli = DirectCast(BS_clienti_new.Current, DataRowView).Row.Field(Of Int32)("id")
        Else
            Return
        End If
        Select Case e.ColumnIndex
            Case IddesDataGridViewTextBoxColumn.Index

                If BsCantieriSegnalazioni.Count > 0 Then
                    rgSegnalazione = DirectCast(BsCantieriSegnalazioni.Current, DataRowView).Row
                    If Not (rgSegnalazione.Isid_desNull) Then
                        oldIDDes = rgSegnalazione.id_des
                        OldDestinatario = rgSegnalazione.locazione
                    Else
                        OldDestinatario = ""
                    End If
                End If
                Dim f As New frmCercaDettaglioCliente(Me.DS_clienti.DT_locazione_new, oldIDDes, OldDestinatario, idCli)
                Dim Risposta(1) As String
                f.ShowDialog()
                Risposta = f.Risposta

                Dim newDestin As String
                Dim newIDDest As Int16
                newDestin = Risposta(1)
                newIDDest = Risposta(0)
                dgwRegistroSegnalazioni(IddesDataGridViewTextBoxColumn.Index, e.RowIndex).Value = newDestin
                dgwRegistroSegnalazioni(dgwcSegnalazioneid_des.Index, e.RowIndex).Value = newIDDest

        End Select
    End Sub

    Private Sub dgwRegistroSegnalazioni_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwRegistroSegnalazioni.CellFormatting
        'Colorariga in base alla gravità

        Dim tmpDGW As DataGridView
        tmpDGW = DirectCast(sender, DataGridView)

        Dim colonna As Integer = e.ColumnIndex

        Select Case colonna
            Case dgwcGravitaData.Index
                Dim valore As Int16
                valore = IIf(IsDBNull(tmpDGW(colonna, e.RowIndex).Value), 1, tmpDGW(colonna, e.RowIndex).Value)
                Select Case valore
                    Case 1
                        tmpDGW(colonna, e.RowIndex).Style.BackColor = Color.Green
                    Case 2
                        tmpDGW(colonna, e.RowIndex).Style.BackColor = Color.GreenYellow
                    Case 3
                        tmpDGW(colonna, e.RowIndex).Style.BackColor = Color.Yellow
                    Case 4
                        tmpDGW(colonna, e.RowIndex).Style.BackColor = Color.Orange
                    Case 5
                        tmpDGW(colonna, e.RowIndex).Style.BackColor = Color.Red
                End Select
        End Select


    End Sub
    Dim slGravita As TrackBar
    Private Sub dgwRegistroSegnalazioni_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwRegistroSegnalazioni.CellEnter
        '**** Controllo se entra nella cella Gravità
        ' valuta quale colonna è
        'se é la colonna 3 (clienti) allora crea una combobox per scegliere il destinatario
        Dim tmpDGW As DataGridView
        tmpDGW = DirectCast(sender, DataGridView)

        Dim colonna As Integer = e.ColumnIndex

        Select Case colonna
            Case dgwcGravitaData.Index
                Try
                    slGravita = New TrackBar
                    slGravita.Minimum = 1
                    slGravita.Maximum = 5
                    ' Calcoliamo il rettangolo che rappresenta lo spazio della cella attuale, ed assegnamo allo slider
                    ' la Location e la Size corrispondenti, in modo che occupi l'intera cella
                    Dim r As Rectangle = tmpDGW.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, True)
                    slGravita.Location = New Point(r.X, r.Y)
                    slGravita.Size = New Size(r.Width, r.Height)
                    ' Aggiungiamo un handler per fare in modo di controllare la selezione sul combo
                    AddHandler slGravita.ValueChanged, AddressOf SelezioneTrack
                    ' L'eventuale valore di cella deve essere trasferito come testo del combo
                    slGravita.Value = tmpDGW.CurrentCell.Value
                    ' Aggiungiamo il combo alla griglia
                    tmpDGW.Controls.Add(slGravita)
                    slGravita.Focus()
                Catch ex As Exception

                End Try
        End Select
    End Sub

    Private Sub SelezioneTrack()
        ' Se il combo è istanziato, allora facciamo in modo che il valore della cella venga prelevato dalla selezione in combo
        ' in questo modo, dopo essere usciti dalla combo la cella manterrà il valore selezionato
        Try
            If Not (IsNothing(slGravita)) Then
                Dim valore As Int16
                valore = slGravita.Value
                Select Case valore
                    Case 1
                        slGravita.BackColor = Color.Green
                    Case 2
                        slGravita.BackColor = Color.GreenYellow
                    Case 3
                        slGravita.BackColor = Color.Yellow
                    Case 4
                        slGravita.BackColor = Color.Orange
                    Case 5
                        slGravita.BackColor = Color.Red
                End Select
                dgwRegistroSegnalazioni.CurrentRow.Cells(dgwcGravitaData.Index).Value = slGravita.Value
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub dgwRegistroSegnalazioni_lasciacella(sender As Object, e As DataGridViewCellEventArgs) Handles dgwRegistroSegnalazioni.CellLeave
        ' Se il combo è istanziato, e la colonna è la terza, eseguiamo il Dispose del combo, per scaricarlo
        Dim tmpDGW As DataGridView
        tmpDGW = DirectCast(sender, DataGridView)

        Dim l As Boolean    'se é locazione
        Dim col As Integer

        l = IsNothing(slGravita)
        col = e.ColumnIndex
        'se non é vero che é nullo il combo ed é sulla colonna specifica
        Select Case col
            Case = dgwcGravitaData.Index
                If Not (l) Then
                    tmpDGW.CurrentRow.Cells(dgwcGravitaData.Index).Value = slGravita.Value
                    slGravita.Dispose()
                End If
        End Select
    End Sub

    Private Sub TabControl1_DrawItem(ByVal sender As Object,
         ByVal e As System.Windows.Forms.DrawItemEventArgs) Handles TABdettaglio.DrawItem
        Dim txt_brush As Brush
        Dim box_brush As Brush
        Dim box_pen As Pen
        Dim m_Xwid As Int16 = 0

        ' We draw in the TabRect rather than on e.Bounds
        ' so we can use TabRect later in MouseDown.
        Dim tab_rect As Rectangle =
            TABdettaglio.GetTabRect(e.Index)

        ' Draw the background.
        ' Pick appropriate pens and brushes.
        If TABdettaglio.TabPages(e.Index).ToolTipText.Contains("#") Then
            e.Graphics.FillRectangle(Brushes.Red,
            tab_rect)
            txt_brush = Brushes.White
            box_brush = Brushes.LightGray
            box_pen = Pens.Gray
        ElseIf TABdettaglio.TabPages(e.Index).ToolTipText <> "" Then
            e.Graphics.FillRectangle(Brushes.Green, tab_rect)
            txt_brush = Brushes.Black
            box_brush = Brushes.LightGray
            box_pen = Pens.Gray
        Else
            e.Graphics.FillRectangle(Brushes.Silver, tab_rect)
            txt_brush = Brushes.Black
            box_brush = Brushes.LightGray
            box_pen = Pens.DarkBlue
        End If
        Dim TAB_MARGIN As Int16 = 1
        ' Allow room for margins.
        Dim layout_rect As New RectangleF(tab_rect.Left + TAB_MARGIN, tab_rect.Y + TAB_MARGIN, tab_rect.Width - 2 * TAB_MARGIN, tab_rect.Height - 2 * TAB_MARGIN)
        Dim string_format As New StringFormat
        ' Draw the tab # in the upper left corner.
        Dim small_font As New Font(Me.Font.FontFamily, 8, FontStyle.Regular)
        string_format.Alignment = StringAlignment.Near
        string_format.LineAlignment = StringAlignment.Near

        'Scrive partendo dall'altomo in alto a SX

        'e.Graphics.DrawString(e.Index.ToString(), small_font, txt_brush, layout_rect, string_format)

        ' Draw the tab's text centered.
        Dim big_font As New Font(Me.Font, FontStyle.Regular)
        string_format.Alignment = StringAlignment.Center
        string_format.LineAlignment = StringAlignment.Center

        If TABdettaglio.TabPages(e.Index).ToolTipText <> "" Then
            e.Graphics.DrawString(TABdettaglio.TabPages(e.Index).ToolTipText.Replace("#", ""), small_font, txt_brush, layout_rect, string_format)
        Else
            e.Graphics.DrawString(TABdettaglio.TabPages(e.Index).Text, big_font, txt_brush, layout_rect, string_format)
        End If
        'e.Graphics.DrawString(TABdettaglio.TabPages(e.Index).ToolTipText, big_font, txt_brush, layout_rect, string_format)

        'Draw an X in the upper right corner.

        Dim rect As Rectangle = TABdettaglio.GetTabRect(e.Index)
        e.Graphics.FillRectangle(box_brush, layout_rect.Right - m_Xwid, layout_rect.Top, m_Xwid, m_Xwid)
        e.Graphics.DrawRectangle(box_pen, layout_rect.Right - m_Xwid, layout_rect.Top, m_Xwid, m_Xwid)
        e.Graphics.DrawLine(box_pen, layout_rect.Right - m_Xwid, layout_rect.Top, layout_rect.Right, layout_rect.Top + m_Xwid)
        e.Graphics.DrawLine(box_pen, layout_rect.Right - m_Xwid, layout_rect.Top + m_Xwid, layout_rect.Right, layout_rect.Top)
        'Clean up. (Don't Dispose the stock pens and brushes.)
        string_format.Dispose()
    End Sub
    Private Sub TABdettaglio_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TABdettaglio.MouseDown
        ' See if this is over a tab.
        Dim TAB_MARGIN As Int16 = 1
        Dim m_Xwid As Int16 = 1

        For i As Integer = 0 To TABdettaglio.TabPages.Count - 1
            ' Get the TabRect plus room for margins.
            Dim tab_rect As Rectangle =
                TABdettaglio.GetTabRect(i)
            Dim rect As New RectangleF(
                tab_rect.Left + TAB_MARGIN,
                tab_rect.Y + TAB_MARGIN,
                tab_rect.Width - 2 * TAB_MARGIN,
                tab_rect.Height - 2 * TAB_MARGIN)
            If e.X >= rect.Right - m_Xwid AndAlso
               e.X <= rect.Right AndAlso
               e.Y >= rect.Top AndAlso
               e.Y <= rect.Top + m_Xwid _
            Then
                Debug.WriteLine("Tab " & i)
                TABdettaglio.TabPages.RemoveAt(i)
                Exit Sub
            End If
        Next i
    End Sub
End Class


Class ScorporaCapitolato

    Private ll As List(Of String)
    Public Sub New(ByVal lista As List(Of String))
        Me.elencocompleto = lista(0).Split("|").Skip(0).First
    End Sub
    Public Property elencocompleto() As String
        Get
            ' Gets the property value.
            Return elencocompleto
        End Get
        Set(ByVal Value As String)
            ' Sets the property value.
            elencocompleto = Value
        End Set
    End Property

End Class