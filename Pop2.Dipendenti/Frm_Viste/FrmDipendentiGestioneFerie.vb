Imports System.IO
Imports System.Text
Imports Excel = Microsoft.Office.Interop.Excel

Public Class frmDipendentiGestioneFerie
    Dim RGll As DS_utenti.DT_utentiRow  'RIGA utenti
    Dim Mesi() = {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"}
    Dim Giorno() = {"Domenica", "Lunedì", "Martedì", "Mercoloedì", "Giovedì", "Venerdì", "Sabato"}
    Dim G_periodo As String
    Dim DT_memo As DS_servizio.DT_info_pop2Row
    Dim dtUT As DSfestivita.dtPianoDataTable

    '
    'ASSEGNA A DTPIANO LA TABELLA PRINCIPALE
    '
    '

    Private Sub FRMGestioneFerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DT_memo = dsolidofunc.legge_informazioni(Me.Name, GlobalVarPOP.G_nomeutente)
        AggiornaComboPeriodo(TTcmbmese, TTcmbanno)

        G_periodo = GlobalVarPOP.GPeriodo
        bsutenti.Filter = "stato = 1"

        For Each riga As DataGridViewRow In DGelencoUtenti.Rows
            If riga.Cells("DGWCidDip").Value = DT_memo.valore_identificativo Then
                riga.Selected = True
                DGelencoUtenti.CurrentCell = riga.Cells("DGWCidDip")
            End If
        Next
        aggiornaRelazione()
        AddHandler bsutenti.CurrentChanged, AddressOf aggiornaRelazione
    End Sub

    Private Function caricaTabelle()
        Try
            Me.TaPiano.Fill(Me.DSfestivita.dtPiano)                                                 'Tutti i piani di lavoro dei clienti
            Me.TAutentisostituzioni.FillByPeriodo(Me.DSfestivita.DTutentisostituzioni, G_periodo)   'Tutte le sostituzioni fatte nel periodo
            Me.TAtipoorario.FillByAttivoDip(Me.DSfestivita.DTtipoorario)                            'Leggenda del Tipo di assenza
            Me.TA_utenti.Fill(Me.DS_utenti.DT_utenti, GlobalVarPOP.G_idAZ)                              'I Dipendenti Attivo
            Me.TA_orario.Fill(Me.DS_orari.DT_orario)                                                    'Tutti i piani di lavoro dei dipendenti
            'Me.TApianodilavoro.Fill(Me.DSfestivita.DTpianodilavoro)                                    'Non comprensibile al momento
            Me.TAferieutente.FillByPeriodo(Me.DSfestivita.DTferieutente, G_periodo.Replace("-", ""))    'Elenco Richiesta ferie nel periodo
            Return True
        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Sub aggiornaRelazione()
        If bsutenti.Count > 0 Then
            RGll = DirectCast(bsutenti.Current, DataRowView).Row
            bsferie.Filter = String.Format("id_dip = {0}", RGll.id)             'Filtra le ferie del dipendente
            bsorariolavoro.Filter = String.Format("id_dip = {0}", RGll.id)      'Filtra il piano di lavoro del dipendente
            bssostituzioni.Filter = String.Format("iddip = {0}", RGll.id)       'Filtra le sostituzioni che deve fare
        End If
    End Sub
    Private Function aggiornaPosizione() As DataRow
        RGll = DirectCast(bsutenti.Current, DataRowView).Row
        Return RGll
    End Function


    Private Sub BTtermina_Click(sender As Object, e As EventArgs) Handles BTtermina.Click
        aggiornaPosizione()

        Dim nome_ri As Array = {bsutenti.DataMember, "iddip", RGll.id, TTcmbmese.SelectedIndex + 1, TTcmbanno.SelectedItem, ""}
        dsolidofunc.memorizza_informazioni(Me.Name, bsferie.Position, GlobalVarPOP.G_nomeutente, nome_ri)
        Me.Close()
    End Sub

    Private Sub BTaggiorna_Click(sender As Object, e As EventArgs) Handles BTaggiorna.Click
        Dim oldPos As Int16 = DGelencoUtenti.CurrentRow.Cells("DGWCidDip").Value
        If Not caricaTabelle() Then
            MsgBox("Non riesco a caricare le tabelle correttamente")
            Me.Close()
        Else
            For Each riga As DataGridViewRow In DGelencoUtenti.Rows
                If riga.Cells("DGWCidDip").Value = oldPos Then
                    riga.Selected = True
                    DGelencoUtenti.CurrentCell = riga.Cells("DGWCidDip")
                End If
            Next
        End If
    End Sub

    Private Sub TTcmbCambia(sender As Object, e As EventArgs) Handles TTcmbmese.SelectedIndexChanged, TTcmbanno.SelectedIndexChanged
        Dim N_Periodo As String
        If Not IsNothing(TTcmbanno.SelectedItem) Then
            N_Periodo = TTcmbanno.SelectedItem & "-" & (TTcmbmese.SelectedIndex + 1).ToString.PadLeft(2, "0")
        Else
            Return
        End If


        If G_periodo = N_Periodo Then
            Return
        End If
        G_periodo = TTcmbanno.SelectedItem & "-" & (TTcmbmese.SelectedIndex + 1).ToString.PadLeft(2, "0")

        Dim oldPos As Int16
        If DGelencoUtenti.Rows.Count > 0 Then
            oldPos = DGelencoUtenti.CurrentRow.Cells("DGWCidDip").Value
        End If

        If Not caricaTabelle() Then
            MsgBox("Non riesco a caricare le tabelle correttamente")
            Me.Close()
        Else
            For Each riga As DataGridViewRow In DGelencoUtenti.Rows
                If riga.Cells("DGWCidDip").Value = oldPos Then
                    riga.Selected = True
                    DGelencoUtenti.CurrentCell = riga.Cells("DGWCidDip")
                End If
            Next
        End If

    End Sub
    Private Sub BTgenera_Click(sender As Object, e As EventArgs) Handles BTgenera.Click


        PGbar.Maximum = 7
        Dim nidDip As Integer = aggiornaPosizione().Field(Of Int32)("id")


        dtUT = New DSfestivita.dtPianoDataTable
        Dim anno As String = TTcmbanno.SelectedItem
        Dim mese As String = (TTcmbmese.SelectedIndex + 1).ToString.PadLeft(2, "0")
        Dim daUT As DateTime = New Date(TTcmbanno.SelectedItem, TTcmbmese.SelectedIndex + 1, 1)
        Dim periodo As String = anno.ToString & "-" & mese.ToString


        'Genera la DataTable che contiene i dati mensili comprese le assenze e sostituzioni e ferie
        Dim tt As DataGridView = New DataGridView

        Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
        Using ta As New DSfestivitaTableAdapters.TAtipoorario
            ta.Fill(dtTipoOrario)
        End Using

        dtUT = GeneraPianodiLavoroDipendente.GeneraValoriPianoOrarioDipendente(tt, dtUT, bsutenti, periodo, dtTipoOrario, True, Nothing, True, ckFerienonconfermate.Checked)


        bsPiano.DataSource = dtUT

        'CreaTabellaFoglioPresenze(dtUT, dgwFoglioPresenza)
        CreaDGWFoglioPresenza(dtUT, dgwFoglioPresenza, periodo, nidDip, ckNonVisualizzaLavoriInFerie.Checked, dtTipoOrario)
        PGbar.Value = 0


    End Sub
    Private Sub CreaDGWFoglioPresenza(ByRef dtUT As DSfestivita.dtPianoDataTable, ByRef dgwTMP As DataGridView,
                                      ByVal periodo As String, ByVal nIdDip As Int16,
                                      ByVal NonVisualizzaLavoriInFerie As Boolean,
                                      ByVal dtTipoOrario As DSfestivita.DTtipoorarioDataTable)


        dgwTMP.Columns.Clear()
        dgwTMP.Rows.Clear()


        Dim LeggendaFerie As DataTable
        Dim col1 As DataColumn
        col1 = New DataColumn("id", Type.GetType("System.Int16"))
        Dim col2 As DataColumn
        col2 = New DataColumn("descrizione", Type.GetType("System.String"))
        LeggendaFerie = New DataTable
        LeggendaFerie.Columns.AddRange({col1, col2})



        Using dt As New DSfestivita.dtUtentiFerieLeggendaDataTable
            Using ta As New DSfestivitaTableAdapters.taUtentiFerieLeggenda
                ta.Fill(dt)
                Dim riga As DataRow
                For Each r In dt
                    riga = LeggendaFerie.NewRow
                    riga("id") = r.id
                    riga("descrizione") = r.descrizione
                    LeggendaFerie.Rows.Add(riga)
                    riga.AcceptChanges()
                Next
            End Using
        End Using

        Dim k1 As DataGridViewCellStyle
        k1 = New DataGridViewCellStyle
        k1.ForeColor = Color.Black
        k1.Font = New Font("Arial", 8, FontStyle.Regular)
        k1.Alignment = DataGridViewContentAlignment.MiddleCenter
        Dim cc As DataGridViewTextBoxColumn

        cc = New DataGridViewTextBoxColumn
        cc.Name = "dgwCGiorno"
        cc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
        cc.HeaderText = "Giorno"
        dgwTMP.Columns.Add(cc)


        '   Crea tutte le righe della tabella 
        '   Mettendo la data nelle Righe

        Dim dtCal As New DS_utenti.DT_calDataTable
        Using ta As New DS_utentiTableAdapters.TA_cal
            ta.FillByPeriodo(dtCal, periodo)
        End Using

        Dim idDetGroup = (From v In dtUT Order By v.ing, v.loc, v.ana, v.dat, v.ing Group v By v.cking Into Risultato =
           Group).ToList


        Dim oldAna As String
        Dim tips As String = ""
        Dim Tag As String = ""

        For ee As Int16 = 0 To idDetGroup.Count - 1
            cc = New DataGridViewTextBoxColumn
            cc.Name = "dgwC" & ee.ToString
            cc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            cc.FillWeight = 50
            dgwTMP.Columns.Add(cc)
        Next
        dgwTMP.Columns(0).HeaderText = MonthName(dtCal.First.giorno.Month)
        dgwTMP.Columns(0).FillWeight = 35
        For Each Giorno As DS_utenti.DT_calRow In dtCal.Rows

            dgwTMP.Rows.Add()
            Dim nRiga As Int16
            nRiga = Giorno.gm - 1
            dgwTMP(0, nRiga).Style = k1
            dgwTMP(0, nRiga).Value = Giorno.gm & "-" & WeekdayName(Weekday(Giorno.giorno, FirstDayOfWeek.Monday), True).ToString
        Next

        Dim nColonna As Int16

        For Each gIdDet In idDetGroup   'Scorre il raggruppamento ottenuto per Destinatario (LOC)
            nColonna += 1
            oldAna = gIdDet.Risultato.First.ana
            dgwTMP.Columns(nColonna).HeaderText = gIdDet.cking
            'Dim totaleOreGiorno As Decimal

            '   Se trova un cliente nuovo crea la Colonna


            For Each f In gIdDet.Risultato 'Scorre il destinatario e popola il Datagridview

                Dim totOre As Decimal = 0
                'Dim lTag As List(Of String) = New List(Of String)
                Dim idSos, idDip, idtip As Int16
                Dim sAss, sSos As String
                Dim colore As Color = Color.White
                Dim oreGiorno As Decimal
                Dim nRiga As Int16

                idSos = f.idsos
                idDip = f.iddip
                idtip = f.idtip
                sAss = f.ana
                sSos = f.sos

                nRiga = f.dat.Day - 1
                If Not IsDBNull(f.sos) Then
                    sSos = f.sos
                End If

                Dim hColor As String() = GeneraPianodiLavoroDipendente.restituiscecolori(dtTipoOrario, idtip)
                If Color.FromName(hColor(0)) <> Color.White Then
                    colore = Color.FromName(hColor(0))
                End If
                k1 = New DataGridViewCellStyle
                k1.ForeColor = Color.Black
                k1.BackColor = colore
                k1.Font = New Font("Arial", 8, FontStyle.Regular)
                k1.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgwTMP(nColonna, nRiga).Style = k1
                Dim quindicinale As Boolean = False

                If Not quindicinale Then
                    'oreGiorno = (f.usc - f.ing).TotalHours
                    'totaleOreGiorno += oreGiorno
                    Select Case f.idtip
                        Case 2  'Ferie
                            If nIdDip = idDip Then
                                dgwTMP(nColonna, nRiga).Value = "FERIE"
                            Else
                                dgwTMP(nColonna, nRiga).Value = f.ing.ToShortTimeString & "-" & f.usc.ToShortTimeString
                            End If
                        Case 3 'Cambio Cantiere
                            dgwTMP(nColonna, nRiga).Value = f.ing.ToShortTimeString & "-" & f.usc.ToShortTimeString
                        Case 6  'Festivo
                            dgwTMP(nColonna, nRiga).Value = ""
                        Case 7  'Chiusura
                            dgwTMP(nColonna, nRiga).Value = ""
                        Case 9  'Chiusura e Ferie
                            dgwTMP(nColonna, nRiga).Value = ""
                        Case 10 'Non Sostituito
                            dgwTMP(nColonna, nRiga).Value = f.idtip
                        Case 12 'Assente
                            If nIdDip = idDip Then
                                dgwTMP(nColonna, nRiga).Value = ""
                            Else
                                dgwTMP(nColonna, nRiga).Value = f.ing.ToShortTimeString & "-" & f.usc.ToShortTimeString
                            End If
                        Case 13 'Sostituito
                            If nIdDip = idDip Then  'Sostituisce
                                dgwTMP(nColonna, nRiga).Value = f.ing.ToShortTimeString & "-" & f.usc.ToShortTimeString
                            End If
                        Case 99 'Sostituito
                            If nIdDip = idDip Then  'Sostituisce
                                dgwTMP(nColonna, nRiga).Value = "ANNULLATO"
                            End If

                        Case Else
                            dgwTMP(nColonna, nRiga).Value = f.ing.ToShortTimeString & "-" & f.usc.ToShortTimeString
                    End Select


                End If

                tips = String.Format("{6}->{3} {0} - {1} = {2} {5}", f.ing.ToShortTimeString, f.usc.ToShortTimeString, oreGiorno, f.ana, hColor(1), vbCrLf, "")
                Tag = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", f.iddip, f.ing, f.usc, idDip, idSos, f.idcli, f.iddet, If(f.idrecupero = 0, -1, f.idrecupero), f.idtip)

                dgwTMP(nColonna, nRiga).Tag = Tag
                dgwTMP(nColonna, nRiga).ToolTipText = tips

            Next
        Next
        If NonVisualizzaLavoriInFerie Then

            Using dt As New DSfestivita.DTferieutenteDataTable
                Using ta As New DSfestivitaTableAdapters.TAferieutente
                    If Not ckFerienonconfermate.Checked Then
                        ta.FillByUtentePeriodo(dt, nIdDip, Integer.Parse(periodo.Replace("-", "")))
                    Else
                        ta.FillByUtenteConvalidaPeriodo_AnnoMese(dt, nIdDip, 2, Integer.Parse(periodo.Replace("-", "")))
                    End If
                    For Each yy As DSfestivita.DTferieutenteRow In dt.Rows
                        Dim inizio As DateTime = yy.inizio
                        Dim fine As DateTime = yy.fine
                        Dim dest As Int16

                        If yy.Isid_desNull Then
                            dest = 0
                        Else
                            dest = yy.id_des
                        End If

                        Dim nCol = 1
                        If dest = 0 Then
                            nCol = dgwTMP.Columns.Count
                        Else
                            nCol = dgwTMP.Columns.Count
                        End If

                        Dim nInizio As Int16
                        Dim nFine As Int16
                        Dim dRiferimento As DateTime 'Data di riferimento per l'analisi
                        dRiferimento = New DateTime(periodo.Split("-").First, periodo.Split("-").Last, 1)

                        Select Case True
                            'Se sto analizzando un anno ma la fine delle ferie è oltre imposto l'ultimo giorno come ultimo giorno del periodo di riferimento
                            Case dRiferimento.Year < fine.Year
                                nInizio = inizio.Day
                                nFine = DateTime.DaysInMonth(dRiferimento.Year, dRiferimento.Month)
                            Case inizio.Month < dRiferimento.Month
                                nInizio = 1
                                If fine.Month > dRiferimento.Month Then
                                    nFine = DateTime.DaysInMonth(dRiferimento.Year, dRiferimento.Month)
                                Else
                                    nFine = fine.Day
                                End If

                            Case inizio.Month < dRiferimento.Month
                                nInizio = dRiferimento.Day
                                nFine = DateTime.DaysInMonth(dRiferimento.Year, dRiferimento.Month)
                            Case fine.Month > dRiferimento.Month
                                nInizio = inizio.Day
                                nFine = DateTime.DaysInMonth(dRiferimento.Year, dRiferimento.Month)
                            Case inizio.Month = fine.Month
                                nInizio = inizio.Day
                                nFine = fine.Day
                        End Select

                        For ff = nInizio To nFine
                            k1 = New DataGridViewCellStyle
                            k1.ForeColor = Color.Black
                            k1.BackColor = Color.Aquamarine
                            k1.Font = New Font("Arial", 8, FontStyle.Regular)
                            k1.Alignment = DataGridViewContentAlignment.MiddleCenter
                            For gg = 1 To nCol - 1
                                If dest = 0 Then
                                    dgwTMP(gg, ff - 1).Style = k1
                                Else
                                    k1.BackColor = Color.MediumAquamarine
                                    dgwTMP(gg, ff - 1).Style = k1
                                End If

                            Next

                        Next


                    Next


                End Using
            End Using

        End If


    End Sub

    Private Sub CreaExcel(ByVal dt As DSfestivita.dtPianoDataTable, ByVal nIdDip As Int16, ByVal periodo As String)

        Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()
        If xlApp Is Nothing Then
            MessageBox.Show("Excel non è installato correttamente!!")
            Return
        End If
        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("foglio1")
        Dim raggruppamentoDati = From x In dt Order By x.loc, x.ing Group x By x.ana, x.soc, x.loc, x.cking Into H = Group
        Dim fAnagrafica As String
        Dim fPeriodo As String
        fAnagrafica = raggruppamentoDati(0).ana

        fAnagrafica = fAnagrafica.Replace("'", "").Replace(".", "").Replace("-", "")
        Dim idDipendente As Int16 = raggruppamentoDati(0).H(0).iddip
        fPeriodo = raggruppamentoDati(0).H(0).dat.Year & "-" & Mesi(raggruppamentoDati(0).H(0).dat.Month - 1)
        With xlWorkSheet
            .Range("A1:BC50").Font.Name = "Times New Roman"
            .Range("A1:BC50").Font.Size = 10
            .Range("A1:B1").Borders.LineStyle = 0
            .Range("A1:B1").Borders.Weight = 1
            .Range("A1").Value = fAnagrafica
            .Range("A1").ColumnWidth = 9
            .Range("A1").Font.Bold = True
            .Range("A2").Value = String.Format("Stampato il :{0}", Now().ToString)
            .Range("A2").ColumnWidth = 9
            .Range("A2").Font.Bold = True
            Using uD As New DS_orari.DT_calDataTable
                Using uT As New DS_orariTableAdapters.TA_cal
                    uT.mostraper_periodo(uD, G_periodo)
                    .Range("D1").Value = "Mese :"
                    .Range("E1").Font.Bold = True
                    .Range("E1").Borders.LineStyle = 0
                    .Range("E1").Borders.Weight = 1
                    .Range("E1").Value = Mesi(uD(0).giorno.Month - 1)
                    .Range("G1").Value = "Anno :"
                    .Range("H1").Borders.LineStyle = 0
                    .Range("H1").Borders.Weight = 1
                    .Range("H1").Font.Bold = True
                    .Range("H1").Value = uD(0).giorno.Year
                    For Each uR As DS_orari.DT_calRow In uD.Rows
                        .Cells(uR.giorno.Day + 4, 1).ColumnWidth = 5
                        .Cells(uR.giorno.Day + 4, 1).value = uR.gm & "-" & Giorno(uR.giorno.DayOfWeek).ToString.Substring(0, 2)
                        .Range(.Cells(uR.giorno.Day + 4, 1), .Cells(uR.giorno.Day + 4, 1)).Borders(9).LineStyle = 0
                    Next
                End Using
            End Using
        End With


        Dim k As Int16 = 2
        Dim tX As Decimal = 0 'somma il totale pèer raggruppamento
        Dim rigafinale As Int16 = 31

        For Each row In raggruppamentoDati
            With xlWorkSheet
                Dim ultimaRiga As Int16 = 0
                .Range(.Cells(3, k), .Cells(4, k + 1)).Borders(9).LineStyle = 0
                .Range(.Cells(3, k), .Cells(4, k + 1)).Borders(9).Weight = 2
                .Range(.Cells(3, k), .Cells(4, k + 1)).Borders(8).LineStyle = 0
                .Range(.Cells(3, k), .Cells(4, k + 1)).Borders(8).Weight = 2
                .Range(.Cells(3, k), .Cells(4, k + 1)).Borders(7).LineStyle = 0
                .Range(.Cells(3, k), .Cells(4, k + 1)).Borders(7).Weight = 2
                .Range(.Cells(3, k), .Cells(4, k + 1)).Borders(10).LineStyle = 0
                .Range(.Cells(3, k), .Cells(4, k + 1)).Borders(10).Weight = 2

                .Range(.Cells(3, k), .Cells(3, k + 1)).Font.Size = 6
                .Range(.Cells(3, k), .Cells(3, k + 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range(.Cells(3, k), .Cells(3, k + 1)).Merge()
                .Cells(3, k).Value = row.soc

                .Range(.Cells(4, k), .Cells(4, k + 1)).Font.Size = 6
                .Range(.Cells(4, k), .Cells(4, k + 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                .Range(.Cells(4, k), .Cells(4, k + 1)).Merge()
                .Cells(4, k).Value = row.loc

                'CREA il quadrante presenze riquadrandolo per dettaglio 
                .Range(.Cells(5, k), .Cells(35, k + 1)).Borders(9).LineStyle = 0
                .Range(.Cells(5, k), .Cells(35, k + 1)).Borders(9).Weight = 2
                .Range(.Cells(5, k), .Cells(35, k + 1)).Borders(8).LineStyle = 0
                .Range(.Cells(5, k), .Cells(35, k + 1)).Borders(8).Weight = 2
                .Range(.Cells(5, k), .Cells(35, k + 1)).Borders(7).LineStyle = 0
                .Range(.Cells(5, k), .Cells(35, k + 1)).Borders(7).Weight = 2
                .Range(.Cells(5, k), .Cells(35, k + 1)).Borders(10).LineStyle = 0
                .Range(.Cells(5, k), .Cells(35, k + 1)).Borders(10).Weight = 2

                For Each elenco In row.H

                    .Range("F1").Borders.Weight = 1
                    Dim newIdDip As Int16
                    newIdDip = elenco.iddip
                    Dim nRiga As Int16 = elenco.dat.Day
                    .Cells(nRiga + 4, k).ColumnWidth = 4
                    .Cells(nRiga + 4, k + 1).ColumnWidth = 4


                    Select Case elenco.idtip
                        Case 2  'Ferie
                            If elenco.idsos = nIdDip Then
                                .Cells(nRiga + 4, k).Value = elenco.ing.ToShortTimeString
                                .Cells(nRiga + 4, k + 1).Value = elenco.usc.ToShortTimeString
                            Else
                                .Range(.Cells(nRiga + 4, k), .Cells(nRiga + 4, k + 1)).Borders.LineStyle = 1
                                .Range(.Cells(nRiga + 4, k), .Cells(nRiga + 4, k + 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                                .Range(.Cells(nRiga + 4, k), .Cells(nRiga + 4, k + 1)).Merge()
                                .Cells(nRiga + 4, 2).Interior.ColorIndex = 45
                                .Cells(nRiga + 4, 2).value = "FERIE"
                            End If

                        Case 3 'Cambio Cantiere
                            If nIdDip = newIdDip Then
                                .Cells(nRiga + 4, k).Value = "C" & elenco.ing.ToShortTimeString
                                .Cells(nRiga + 4, k + 1).Value = elenco.usc.ToShortTimeString
                            Else
                                .Cells(nRiga + 4, k).Value = elenco.ing.ToShortTimeString
                                .Cells(nRiga + 4, k + 1).Value = elenco.usc.ToShortTimeString
                            End If
                        Case 5
                            .Cells(nRiga + 4, k).Value = elenco.ing.ToShortTimeString
                            .Cells(nRiga + 4, k + 1).Value = elenco.usc.ToShortTimeString
                            .Cells(nRiga + 4, k).Interior.ColorIndex = 32
                            .Cells(nRiga + 4, k + 1).Interior.ColorIndex = 32
                        Case 6  'Festivo
                            .Range(.Cells(nRiga + 4, k), .Cells(nRiga + 4, k + 1)).Borders.LineStyle = 1
                            .Range(.Cells(nRiga + 4, k), .Cells(nRiga + 4, k + 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            .Range(.Cells(nRiga + 4, k), .Cells(nRiga + 4, k + 1)).Merge()
                            .Cells(nRiga + 4, k).Interior.ColorIndex = 8
                            .Cells(nRiga + 4, k).value = "FESTIVO"
                        Case 7  'Chiusura
                            .Range(.Cells(nRiga + 4, k), .Cells(nRiga + 4, k + 1)).Borders.LineStyle = 1
                            .Range(.Cells(nRiga + 4, k), .Cells(nRiga + 4, k + 1)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                            .Range(.Cells(nRiga + 4, k), .Cells(nRiga + 4, k + 1)).Merge()
                            .Cells(nRiga + 4, k).Interior.ColorIndex = 35
                            .Cells(nRiga + 4, k).value = "CHIUSO"
                        Case 9  'Chiusura e Ferie

                        Case 10 'Non Sostituito
                            .Cells(nRiga + 4, k).Value = elenco.ing.ToShortTimeString
                            .Cells(nRiga + 4, k + 1).Value = elenco.usc.ToShortTimeString
                        Case 12 'Assente
                            .Cells(nRiga + 4, k).Value = elenco.ing.ToShortTimeString
                            .Cells(nRiga + 4, k + 1).Value = elenco.usc.ToShortTimeString
                        Case 13 'Sostituito
                            .Cells(nRiga + 4, k).Value = elenco.ing.ToShortTimeString
                            .Cells(nRiga + 4, k + 1).Value = elenco.usc.ToShortTimeString
                            .Cells(nRiga + 4, k).Interior.ColorIndex = 24
                            .Cells(nRiga + 4, k + 1).Interior.ColorIndex = 24
                        Case 99 'Sostituito
                            If elenco.idsos = nIdDip Then
                                .Cells(nRiga + 4, k).Value = "ANNU"
                                .Cells(nRiga + 4, k + 1).Value = "LLATO"
                            Else

                            End If


                        Case Else
                            .Cells(nRiga + 4, k).Value = elenco.ing.ToShortTimeString
                            .Cells(nRiga + 4, k + 1).Value = elenco.usc.ToShortTimeString
                    End Select
                    ultimaRiga = nRiga
                Next
            End With
            k += 2
        Next

        Using dtP As New DSfestivita.DTferieutenteDataTable
            Using ta As New DSfestivitaTableAdapters.TAferieutente
                If Not ckFerienonconfermate.Checked Then
                    ta.FillByUtentePeriodo(dtP, nIdDip, periodo.Replace("-", ""))
                Else
                    ta.FillByUtenteConvalidaPeriodo_AnnoMese(dtP, nIdDip, 2, periodo.Replace("-", ""))
                End If
                For Each yy As DSfestivita.DTferieutenteRow In dtP.Rows
                    Dim inizio As DateTime = yy.inizio
                    Dim fine As DateTime = yy.fine
                    Dim dest As Int16
                    If yy.Isid_desNull Then
                        dest = 0
                    Else
                        dest = yy.id_des
                    End If

                    Dim nCol = 1
                    If dest = 0 Then
                        nCol = k
                    Else
                        nCol = k
                    End If
                    Dim nInizio As Int16
                    Dim nFine As Int16
                    Dim dRiferimento As DateTime 'Data di riferimento per l'analisi
                    dRiferimento = New DateTime(periodo.Split("-").First, periodo.Split("-").Last, 1)

                    Select Case True
                            'Se sto analizzando un anno ma la fine delle ferie è oltre imposto l'ultimo giorno come ultimo giorno del periodo di riferimento
                        Case dRiferimento.Year < fine.Year
                            nInizio = inizio.Day
                            nFine = DateTime.DaysInMonth(dRiferimento.Year, dRiferimento.Month)
                        Case inizio.Month < dRiferimento.Month
                            nInizio = 1
                            If fine.Month > dRiferimento.Month Then
                                nFine = DateTime.DaysInMonth(dRiferimento.Year, dRiferimento.Month)
                            Else
                                nFine = fine.Day
                            End If

                        Case inizio.Month < dRiferimento.Month
                            nInizio = dRiferimento.Day
                            nFine = DateTime.DaysInMonth(dRiferimento.Year, dRiferimento.Month)
                        Case fine.Month > dRiferimento.Month
                            nInizio = inizio.Day
                            nFine = DateTime.DaysInMonth(dRiferimento.Year, dRiferimento.Month)
                        Case inizio.Month = fine.Month
                            nInizio = inizio.Day
                            nFine = fine.Day
                    End Select



                    For ff = nInizio To nFine

                        For gg = 2 To nCol - 1
                            'If dest = 0 Then
                            With xlWorkSheet
                                .Range(.Cells(ff + 4, gg), .Cells(ff + 4, gg)).Borders.LineStyle = 1
                                .Range(.Cells(ff + 4, gg), .Cells(ff + 4, gg)).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
                                .Range(.Cells(ff + 4, gg), .Cells(ff + 4, gg)).Merge()
                                .Cells(ff + 4, gg).Interior.ColorIndex = 45
                                Dim valore = .Cells(ff + 4, gg).value
                                If Not IsNothing(valore) Then
                                    If valore.ToString <> "" Then
                                        .Cells(ff + 4, gg).value = ""
                                    End If
                                Else

                                End If


                            End With
                            'End If

                        Next

                    Next


                Next


            End Using
        End Using


        With xlWorkSheet
            .Range(.Cells(1 + 4, 1), .Cells(rigafinale + 4, k - 1)).Borders(12).LineStyle = 0
            .Range(.Cells(1 + 4, 1), .Cells(rigafinale + 4, k - 1)).Borders(12).Weight = 1
            .Cells(rigafinale + 5, 1).Interior.ColorIndex = 35
            .Cells(rigafinale + 5, 2).value = "CHIUSO"

            .Cells(rigafinale + 6, 1).Interior.ColorIndex = 24
            .Cells(rigafinale + 6, 2).value = "SOSTITUZIONE"

            .Cells(rigafinale + 7, 1).Interior.ColorIndex = 32
            .Cells(rigafinale + 7, 2).value = "CAMBIO ORARIO"

            .Cells(rigafinale + 8, 1).Interior.ColorIndex = 45
            .Cells(rigafinale + 8, 2).value = "FERIE"

            .Cells(rigafinale + 9, 1).Interior.ColorIndex = 8
            .Cells(rigafinale + 9, 2).value = "FESTIVO"


        End With

        Dim salvaFile As SaveFileDialog = New SaveFileDialog()

        salvaFile.Filter = "File Excel(.xls)|*.xls"
        salvaFile.Title = "Salva file sul pc"
        salvaFile.CheckPathExists = True
        salvaFile.FileName = fPeriodo & "-" & fAnagrafica & ".xls"
        'salvaFile.InitialDirectory = Environment.GetFolderPath(Environment.CurrentDirectory)
        If salvaFile.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                xlWorkBook.SaveAs(salvaFile.FileName, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue,
             Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
                xlWorkBook.Close(True, misValue, misValue)
            Catch ex As Exception
                MsgBox("Attenzione, probabilmente il file è già aperto")
            End Try

            xlApp.Quit()
        Else
            MessageBox.Show("File NON salvato Correttamente")
        End If
        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)
        raggruppamentoDati = Nothing
    End Sub




    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ttsButtonCaricaDati_Click(sender As Object, e As EventArgs) Handles ttsButtonCaricaDati.Click
        If IsDBNull(dtUT) Then
            Return
        End If
        If dtUT.Count > 0 Then
            Dim nidDip As Integer = aggiornaPosizione().Field(Of Int32)("id")
            Dim anno As String = TTcmbanno.SelectedItem
            Dim mese As String = (TTcmbmese.SelectedIndex + 1).ToString.PadLeft(2, "0")
            Dim periodo As String = anno.ToString & "-" & mese.ToString
            CreaExcel(dtUT, nidDip, periodo)
        End If

    End Sub

    Private Sub ckFerienonconfermate_CheckedChanged(sender As Object, e As EventArgs) Handles ckFerienonconfermate.CheckedChanged
        If ckFerienonconfermate.Checked Then
            ckFerienonconfermate.Text = "Visualizza SOLO le ferie confermate"
        Else
            ckFerienonconfermate.Text = "Visualizza tutte le ferie anche non confermate"
        End If
    End Sub
End Class