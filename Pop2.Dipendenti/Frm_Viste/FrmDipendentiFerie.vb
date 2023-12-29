Public Class frmDipendentiFerie
    Dim PeriodoLocale As String
    Dim collegaData As Boolean = True
    Private Sub frmDipendentiFerie_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        AggiornaComboPeriodo(TT_CB_mese, TT_CB_anno)
        Dim DT_memo As DS_servizio.DT_info_pop2Row
        DT_memo = dsolidofunc.legge_informazioni(Me.Name, GlobalVarPOP.G_nomeutente)
        PeriodoLocale = GlobalVarPOP.GPeriodo

        CaricaDT()
        AddHandler bsUtentiFerie.PositionChanged, AddressOf aggiornaRighe
        AddHandler TT_CB_anno.SelectedIndexChanged, AddressOf aggiornaalcambioperiodo
        AddHandler TT_CB_mese.SelectedIndexChanged, AddressOf aggiornaalcambioperiodo

        aggiornaRighe()

    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        dgwcControllo.DataSource = Nothing
        dgwFerieUtente.DataSource = Nothing
        Me.Close()
    End Sub
    Private Sub dgwferiUtente_Error(sender As Object, e As DataGridViewDataErrorEventArgs) Handles dgwFerieUtente.DataError
        e.Cancel = False
    End Sub
    Private Function CaricaDT()
        Dim periodo As Integer = TT_CB_anno.SelectedItem & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")

        Me.TaUtentiFerieLeggenda.Fill(Me.DSfestivita.dtUtentiFerieLeggenda)
        Dim Conta As Integer
        For Each i In tsFiltro.DropDownItems
            Console.WriteLine(i)
            Select Case Conta
                Case 0
                    collegaData = False
                    tsCollegamentoCambioData.PerformClick()
                    If i.checked Then   'Richieste da gestire
                        Me.TAferieutente.FillByDaGestire(Me.DSfestivita.DTferieutente)
                    End If
                Case 1
                    collegaData = True
                    tsCollegamentoCambioData.PerformClick()
                    If i.checked Then   'Richieste Approvate
                        Me.TAferieutente.FillByPeriodoConvalida(Me.DSfestivita.DTferieutente, periodo, 2)
                    End If
                Case 2
                    collegaData = True
                    tsCollegamentoCambioData.PerformClick()
                    If i.checked Then   'Ferie Rifiutate
                        Me.TAferieutente.FillByPeriodoConvalida(Me.DSfestivita.DTferieutente, periodo, 3)
                    End If
                Case 3
                    collegaData = True
                    tsCollegamentoCambioData.PerformClick()
                    If i.checked Then   'Tutte le richieste del mese
                        Me.TAferieutente.FillByPeriodo(Me.DSfestivita.DTferieutente, periodo)
                    End If
                Case 4
                    collegaData = True
                    tsCollegamentoCambioData.PerformClick()
                    If i.checked Then   'Tutte le richieste del mese
                        Dim dtTutti As DSfestivita.DTferieutenteDataTable
                        Me.TAferieutente.FillByPeriodo(Me.DSfestivita.DTferieutente, periodo)
                        dtTutti = Me.DSfestivita.DTferieutente
                        Dim dt As New DSfestivita.dtUtentiDataTable
                        Using ta As New DSfestivitaTableAdapters.taUtenti
                            ta.FillByStato(dt, 1)
                            For Each rg In dt.Rows
                                Dim posUtenteFerie As Int16
                                posUtenteFerie = bsUtentiFerie.Find("id_dip", rg.id)
                                If posUtenteFerie < 0 Then
                                    Dim nrg As DSfestivita.DTferieutenteRow = dtTutti.NewRow()
                                    nrg.anagrafica = rg.cognome & " " & rg.nome
                                    nrg.id_dip = rg.id
                                    nrg.controllo = 0
                                    nrg.inizio = Nothing
                                    nrg.fine = Nothing
                                    nrg.controllo = 10
                                    nrg.data = Nothing
                                    dtTutti.Rows.Add(nrg)
                                End If
                            Next
                            bsUtentiFerie.DataSource = dtTutti
                        End Using
                    End If
            End Select
            Conta += 1
        Next

        bsUtentiFerie.DataSource = Me.DSfestivita.DTferieutente
        If Not String.IsNullOrEmpty(PeriodoLocale) Then
            Using TA As New DS_utentiTableAdapters.TA_cal
                Using DT As New DS_utenti.DT_calDataTable
                    TA.FillByPeriodo(DT, PeriodoLocale)
                    bsCalendario.DataSource = DT
                    caricaIntestazioneMeseDipendente()
                    Me.TAferiecliente.Fill(Me.DSfestivita.DTferiecliente)
                    caricaintestazioneMeseCliente()
                End Using
            End Using
        End If
        Return True
    End Function
    Private Sub aggiornaalcambioperiodo(sender As Object, e As EventArgs)

        If TT_CB_mese.SelectedIndex >= 0 Then
            Dim RGDG As New DataGridViewRow
            PeriodoLocale = TT_CB_anno.SelectedItem & "-" & (TT_CB_mese.SelectedIndex + 1).ToString.PadLeft(2, "0")
        End If
        Using TA As New DS_utentiTableAdapters.TA_cal
            Using DT As New DS_utenti.DT_calDataTable
                If Not String.IsNullOrEmpty(PeriodoLocale) Then
                    TA.FillByPeriodo(DT, PeriodoLocale)
                    bsCalendario.DataSource = DT
                    caricaIntestazioneMeseDipendente()
                    caricaintestazioneMeseCliente()
                End If
            End Using
        End Using

        aggiornaRighe()
    End Sub
    Private Sub aggiornaRighe()

        If bsUtentiFerie.Count > 0 Then

            Dim rg As DSfestivita.DTferieutenteRow
            rg = DirectCast(bsUtentiFerie.Current, DataRowView).Row
            Dim id As Int16 = rg.id_dip

            Using dt As New DSfestivita.dtPianoOrarioDataTable
                Using ta As New DSfestivitaTableAdapters.taPianoOrario
                    ta.FillBydipendente(dt, id)
                    bsPianoOrarioDipendente.DataSource = dt
                End Using
            End Using
            If collegaData Then
                Dim Periodo As DateTime
                Periodo = rg.inizio
                Dim sPeriodo As String = Periodo.Year.ToString & "-" & Periodo.Month.ToString.PadLeft(2, "00")
                If PeriodoLocale <> Periodo Then
                    TT_CB_mese.SelectedIndex = Periodo.Month - 1
                    TT_CB_anno.SelectedItem = Periodo.Year.ToString
                    PeriodoLocale = Periodo
                End If
            End If
            caricaValoriMeseDipendente()
        End If

    End Sub
    Private Function caricaIntestazioneMeseDipendente()   'quando clicco su ricarica
        dgwSviluppoOreDipendenteMese.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dim I_numerocolonne = bsCalendario.Count
        Dim S_testoGiorno As String = ""
        Dim S_tot() As String = {"DOM", "LUN", "MAR", "MER", "GIO",
                                     "VEN", "SAB"}
        Dim datainizioferie As DateTime
        Dim datafineferie As DateTime
        Dim RGferie As DSfestivita.DTferieutenteRow
        If bsUtentiFerie.Count > 0 Then
            RGferie = DirectCast(bsUtentiFerie.Current, DataRowView).Row
            If bsUtentiFerie.Count > 0 Then
                datainizioferie = RGferie.inizio
                datafineferie = RGferie.fine
            End If
        End If
        dgwSviluppoOreDipendenteMese.ColumnCount = I_numerocolonne + 2
        dgwSviluppoOreDipendenteMese.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgwSviluppoOreDipendenteMese.Columns(0).HeaderText = "Destinatario"
        dgwSviluppoOreDipendenteMese.Columns(0).FillWeight = 150
        Dim rg As DS_utenti.DT_calRow
        Dim r As Integer = 1
        For Each l In bsCalendario
            rg = DirectCast(l, DataRowView).Row
            S_testoGiorno = rg.gm & "-" & S_tot(rg.giorno.DayOfWeek)
            dgwSviluppoOreDipendenteMese.Columns(r).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'rg.giorno
            If rg.festivo Then
                dgwSviluppoOreDipendenteMese.Columns(r).ToolTipText = rg.festa
                dgwSviluppoOreDipendenteMese.Columns(r).HeaderText = "FS"
            ElseIf rg.giorno >= datainizioferie And rg.giorno <= datafineferie Then
                dgwSviluppoOreDipendenteMese.Columns(r).ToolTipText = "in ferie"
                dgwSviluppoOreDipendenteMese.Columns(r).HeaderText = S_testoGiorno
            Else
                dgwSviluppoOreDipendenteMese.Columns(r).HeaderText = S_testoGiorno
            End If
            dgwSviluppoOreDipendenteMese.Columns(r).FillWeight = 40
            dgwSviluppoOreDipendenteMese.Columns(r).DefaultCellStyle.Format = "N2"
            r += 1  ' numero progressivo delle colonne
        Next
        dgwSviluppoOreDipendenteMese.Columns(dgwSviluppoOreDipendenteMese.Columns.Count - 1).FillWeight = 40
        dgwSviluppoOreDipendenteMese.Columns(dgwSviluppoOreDipendenteMese.Columns.Count - 1).DefaultCellStyle.Format = "N2"
        dgwSviluppoOreDipendenteMese.Columns(dgwSviluppoOreDipendenteMese.Columns.Count - 1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        ' 
        Return True
    End Function



    Private Function caricaValoriMeseDipendente() As Boolean

        'Memorizza l'inizio del Mese e la Fine
        'Memorizza l'ID del Dipendente
        '
        Dim inizio As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 1, 1)
        Dim fine As DateTime = DateSerial(TT_CB_anno.SelectedItem, TT_CB_mese.SelectedIndex + 2, 0)
        Dim idUtente As Integer = DirectCast(bsUtentiFerie.Current, DataRowView).Row.Field(Of Integer)("id_dip")
        '
        '
        Dim RGferie As DSfestivita.DTferieutenteRow

#Disable Warning CA1814 ' Preferire matrici di matrici rispetto a matrici multidimensionali
        Dim dataassenza(0, 0) As Date
#Enable Warning CA1814 ' Preferire matrici di matrici rispetto a matrici multidimensionali
        'DS_utenti.ute

        If bsUtentiFerie.Count > 0 Then
            ReDim dataassenza(bsUtentiFerie.Count - 1, 1)
            Dim x As Integer = 0
            For Each xi In bsUtentiFerie
                RGferie = DirectCast(xi, DataRowView).Row
                If RGferie.id_dip = idUtente Then

                    dataassenza(x, 0) = RGferie.inizio
                    dataassenza(x, 1) = RGferie.fine
                    x += 1
                End If
            Next
        End If


        Dim rg As DS_utenti.DT_calRow
        Dim NgiornoSettimana As Integer
        Dim Sgiornosettimana As String
        Dim inizioferieD As DateTime
        Dim fineferieD As DateTime

        '
        'Carica i dati nella tabella ordinata
        '
        '
        'Crea la nuova tabella Prendendo come esempio la tabella Orari

        Dim Ute As DataTable = NewDToremese()
        'Popola la tabella con gli orari da programma
        Ute = CaricaDatiOreDipendente(Ute, bsPianoOrarioDipendente)
        'POpola la tabella con le sostituzioni da Agenda

        Dim dtSost As New DSfestivita.DTutentisostituzioniDataTable
        Using taSost As New DSfestivitaTableAdapters.TAutentisostituzioni
            taSost.FillBydipendentedallaalla(dtSost, idUtente, inizio, fine)
        End Using

        Ute = CaricaDettagliSostituzioni(Ute, dtSost)
        '
        '
        'Crea la tabella Ordinata
        '
        '
        Dim tabellaordinata As DataTable = CalcolaOraridaContrattoDipendenti(Ute, bsPianoOrarioDipendente)
        Dim Riga As Integer = 0
        dgwSviluppoOreDipendenteMese.Rows.Clear()
        Dim oldDet As Integer
        If IsNothing(tabellaordinata) Then
            Return True
        End If
        If tabellaordinata.Rows.Count < 1 Then
            Return True
        End If
        Dim idPrimoDestinatario As Integer = tabellaordinata.Rows(0).Item("id_dettaglio")

        For Each RRorari In tabellaordinata.Rows
            dgwSviluppoOreDipendenteMese.Rows.Add()
            Dim idDestinatario As Integer = RRorari.item("id_dettaglio")
            Dim idTipoSostituzioni As Integer = RRorari.item("idtipoSost")
            If oldDet <> RRorari.item("id_dettaglio") Then
                oldDet = RRorari.item("id_dettaglio")
                Using TMP As New DSfestivitaTableAdapters.TAferiecliente
                    Dim DT As New DSfestivita.DTferieclienteDataTable
                    TMP.FillBydettaglio(DT, RRorari.item("id_dettaglio"), PeriodoLocale)
                    If DT.Rows.Count > 0 Then
                        inizioferieD = DT.Rows(0).Field(Of DateTime)("inizio")
                        fineferieD = DT.Rows(0).Field(Of DateTime)("fine")
                    Else
                        inizioferieD = Nothing
                        fineferieD = Nothing
                    End If
                End Using
            End If
            Dim totaleOrarioRiga As Decimal
            For Each l In bsCalendario
                rg = DirectCast(l, DataRowView).Row
                NgiornoSettimana = (rg.giorno.DayOfWeek)
                Sgiornosettimana = {"dom", "lun", "mar", "mer", "gio", "ven", "sab"}(NgiornoSettimana)
                Dim NColMese As Integer = CInt(rg.gm)
                If idDestinatario > 0 Then
                    If rg.giorno >= inizioferieD And rg.giorno <= fineferieD Then
                        Dim k As New DataGridViewCellStyle
                        k.ForeColor = Color.Black
                        k.BackColor = Color.Red
                        k.Font = New Font("Arial", 8, FontStyle.Bold)
                        k.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgwSviluppoOreDipendenteMese(NColMese, Riga).Style = k
                    ElseIf dgwSviluppoOreDipendenteMese.Columns(NColMese).HeaderText = "FS" Then ' Se e una festivita allora Cambia il colore di sfondo
                        Dim k As New DataGridViewCellStyle
                        k.BackColor = Color.DeepSkyBlue
                        k.Font = New Font("Arial", 8, FontStyle.Bold)
                        k.ForeColor = Color.Black
                        k.Alignment = DataGridViewContentAlignment.MiddleCenter
                        dgwSviluppoOreDipendenteMese(NColMese, Riga).Style = k
                    End If
                ElseIf RRorari.item("id_dettaglio") = 0 Then
                    '
                    '
                    'Stampa la riga prima del Totale
                    '
                    dgwSviluppoOreDipendenteMese.Rows(Riga).Height = 1
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.Black
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    For xxx = 0 To dgwSviluppoOreDipendenteMese.Columns.Count - 1
                        dgwSviluppoOreDipendenteMese(xxx, Riga).Style = k
                    Next
                End If
                Dim anag, detta As String
                anag = RRorari.item("anagrafica") 'Scrive il Nome del Destinatario
                detta = RRorari.item("dettaglio")
                anag = anag.Substring(0, If(anag.Length >= 20, 20, anag.Length))
                detta = detta.Substring(0, If(detta.Length >= 25, 25, detta.Length))
                dgwSviluppoOreDipendenteMese(0, Riga).Value = detta 'Scrive il nome del Dettaglio
                dgwSviluppoOreDipendenteMese(0, Riga).Tag = idDestinatario
                Dim val As Decimal = RRorari.item(Sgiornosettimana)
                Dim totore As Decimal
                If RRorari.item(Sgiornosettimana) <> 0 Then
                    totore = RRorari.item(Sgiornosettimana)
                    Dim seFerie As Boolean = False
                    For DDaa = 0 To (dataassenza.Length / 2) - 1
                        If rg.giorno >= dataassenza(DDaa, 0) And rg.giorno <= dataassenza(DDaa, 1) Then
                            dgwSviluppoOreDipendenteMese(NColMese, Riga).Value = "Fe " & totore
                            Dim k As New DataGridViewCellStyle
                            k.BackColor = Color.LightCoral
                            k.Font = New Font("Arial", 8, FontStyle.Bold)
                            k.ForeColor = Color.Black
                            k.Alignment = DataGridViewContentAlignment.MiddleCenter
                            dgwSviluppoOreDipendenteMese(NColMese, Riga).Style = k
                            seFerie = True
                        End If
                    Next
                    Select Case True
                        Case dgwSviluppoOreDipendenteMese.Columns(NColMese).HeaderText = "FS"
                            Dim k As New DataGridViewCellStyle
                            dgwSviluppoOreDipendenteMese(NColMese, Riga).Value = "Fs " & totore
                            k.BackColor = Color.DeepSkyBlue
                            k.Font = New Font("Arial", 8, FontStyle.Bold)
                            k.ForeColor = Color.Black
                            k.Alignment = DataGridViewContentAlignment.MiddleCenter
                            dgwSviluppoOreDipendenteMese(NColMese, Riga).Style = k
                        Case Not seFerie
                            Dim k As New DataGridViewCellStyle
                            'Se è Chiuso il cliente
                            If rg.giorno >= inizioferieD And rg.giorno <= fineferieD Then
                                k.ForeColor = Color.Black
                                k.BackColor = Color.Red
                                k.Font = New Font("Arial", 8, FontStyle.Bold)
                                k.Alignment = DataGridViewContentAlignment.MiddleCenter
                                dgwSviluppoOreDipendenteMese(NColMese, Riga).Style = k
                                dgwSviluppoOreDipendenteMese(NColMese, Riga).Value = "Fc " & totore
                            Else
                                dgwSviluppoOreDipendenteMese(NColMese, Riga).Value = totore
                                totaleOrarioRiga += totore
                            End If
                    End Select
                Else
                    If idTipoSostituzioni = 1 Then
                        Dim totSost As Decimal = AssegnaTotaleOreperGiornoSettimana(dtSost, rg.giorno, idDestinatario)
                        If totSost > 0 Then
                            dgwSviluppoOreDipendenteMese(NColMese, Riga).Value = totSost
                            totaleOrarioRiga += totSost
                        End If
                    End If
                End If
            Next
            Dim j As New DataGridViewCellStyle
            j.BackColor = Color.LightGreen
            j.Font = New Font("Arial", 8, FontStyle.Bold)
            dgwSviluppoOreDipendenteMese(dgwSviluppoOreDipendenteMese.Columns.Count - 1, Riga).Style = j
            dgwSviluppoOreDipendenteMese(dgwSviluppoOreDipendenteMese.Columns.Count - 1, Riga).Value = totaleOrarioRiga
            totaleOrarioRiga = 0
            Riga += 1
        Next
        Dim nuovariga As New DataGridViewRow
        nuovariga.CreateCells(dgwSviluppoOreDipendenteMese)
        Dim ore(dgwSviluppoOreDipendenteMese.Columns.Count - 1) As Decimal
        For Each rgDG As DataGridViewRow In dgwSviluppoOreDipendenteMese.Rows
            Dim tt As Integer
            For tt = 1 To rgDG.Cells.Count - 1
                Try
                    ore(tt) += rgDG.Cells(tt).Value
                Catch ex As Exception

                End Try
            Next
        Next

        Dim nCelle As Integer = 0
        Dim w As New DataGridViewCellStyle
        w.BackColor = Color.LightSeaGreen
        w.Font = New Font("Arial", 8, FontStyle.Bold)
        w.ForeColor = Color.Black
        w.Alignment = DataGridViewContentAlignment.MiddleCenter

        Dim ultimariga As Integer = dgwSviluppoOreDipendenteMese.Rows.Add()

        For Each tt In ore
            Console.WriteLine(tt)
            If tt > 0 Then
                dgwSviluppoOreDipendenteMese.Rows(ultimariga).Cells(nCelle).Value = tt
            End If

            dgwSviluppoOreDipendenteMese.Rows(ultimariga).Cells(nCelle).Style = w
            nCelle += 1
        Next
        'Imposta il primo cliente dove lavora il dipendente
        AggiornamentoValoriCliente(idPrimoDestinatario)
        Return True
    End Function

    Private Function caricaintestazioneMeseCliente()   'quando clicco su ricarica
        dgwDestinatariMese.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dim I_numerocolonne = bsCalendario.Count
        Dim S_testoGiorno As String
        Dim datainizioferie As DateTime
        Dim datafineferie As DateTime
        Dim RGferie As DSfestivita.DTferieclienteRow


        If bsUtentiFerie.Count > 0 Then
            RGferie = DirectCast(bsClientiFerie.Current, DataRowView).Row
            If bsUtentiFerie.Count > 0 Then
                datainizioferie = RGferie.inizio
                datafineferie = RGferie.fine
            End If
        End If

        Dim S_tot() As String = {"D", "L", "M", "M", "G",
                                     "V", "S"}
        dgwDestinatariMese.ColumnCount = I_numerocolonne + 1
        dgwDestinatariMese.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgwDestinatariMese.Columns(0).HeaderText = "Destinatario"
        dgwDestinatariMese.Columns(0).FillWeight = 100
        Dim rg As DS_utenti.DT_calRow
        Dim r As Integer = 1
        For Each l In bsCalendario
            rg = DirectCast(l, DataRowView).Row
            S_testoGiorno = rg.gm & "-" & S_tot(rg.giorno.DayOfWeek)
            dgwDestinatariMese.Columns(r).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'rg.giorno
            If rg.festivo Then
                dgwDestinatariMese.Columns(r).ToolTipText = rg.festa
                dgwDestinatariMese.Columns(r).HeaderText = "FS"
            ElseIf rg.giorno >= datainizioferie And rg.giorno <= datafineferie Then
                dgwDestinatariMese.Columns(r).ToolTipText = "Chiuso per ferie"
                dgwDestinatariMese.Columns(r).HeaderText = "X" & "-" & S_testoGiorno
            Else
                dgwDestinatariMese.Columns(r).HeaderText = S_testoGiorno
            End If

            dgwDestinatariMese.Columns(r).FillWeight = 25
            dgwDestinatariMese.Columns(r).DefaultCellStyle.Format = "N2"
            r += 1  ' numero progressivo delle colonne
        Next
        dgwDestinatariMese.Rows.Clear()

        Return True
    End Function

    Private Function caricaValoriMeseCliente(ByVal idDestinatario As Int16) As Boolean 'Carica i valori delle ore su tutto il mese
        If bsClientiFerie.Count = 0 Then
            Return True
        End If
        Dim Cli As DataTable = New DataTable
        Using DT As New DSfestivita.dtPianoOrarioDataTable
            Using TA As New DSfestivitaTableAdapters.taPianoOrario
                TA.FillByDestinatari(DT, idDestinatario)
                bsPianoOrarioCliente.DataSource = DT
            End Using
        End Using
        Cli = NewDToremeseCliente()
        Cli = CaricaDatiOreDipendente(Cli, bsPianoOrarioCliente)

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
        Dim rg As DS_utenti.DT_calRow
        Dim NgiornoSettimana As Integer
        Dim Sgiornosettimana As String
        Dim Riga As Integer = 0
        dgwDestinatariMese.Rows.Clear()
        Dim BSsost As New BindingSource

        For Each RRorari In TabellaOrdinata.Rows 'inizia a ciclare le ore in base al cantiere e il dipendente nei giorni

            dgwDestinatariMese.Rows.Add()
            Dim iddet, iddip As Int16
            If RRorari.item("ordine") = 99 Then ' Salta una riga
                dgwDestinatariMese.Rows(dgwDestinatariMese.Rows.Count - 1).Height = 4

                For kspace = 0 To dgwDestinatariMese.Columns.Count - 1
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.Black
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    dgwDestinatariMese(kspace, Riga).Style = k
                Next
                Riga += 1
                Continue For
            End If
            iddet = RRorari.item("id_dettaglio")
            iddip = RRorari.item("id_utente")
            bsClientiFerie.Filter = String.Format("id_det = {0}", iddet)
            Dim tmpFerie As Int16
            Dim periodoi As Int32
            periodoi = PeriodoLocale.Replace("-", "")
            Using TA As New DSfestivitaTableAdapters.TAutentisostituzioni   'Verifica la tabella delle sostituzioni
                Using DT As New DSfestivita.DTutentisostituzioniDataTable
                    TA.FillBydettaglionelperiodo(DT, iddet, periodoi)

                    BSsost.DataSource = DT 'Binding delle Sostituzioni
                End Using
            End Using
            Dim inizioferieU, fineferieU As DateTime
            inizioferieU = Nothing
            fineferieU = Nothing
            Using TA As New DSfestivitaTableAdapters.TAferieutente   'Verifica le Ferie del dipendente 
                Using DT As New DSfestivita.DTferieutenteDataTable
                    TA.FillByUtentePeriodo(DT, iddip, periodoi)
                    If DT.Rows.Count > 0 Then
                        inizioferieU = DT.Rows(0).Item("inizio")
                        fineferieU = DT.Rows(0).Item("fine")
                    End If
                End Using
            End Using




            Dim RFS As DSfestivita.DTferieclienteRow
            Dim inizioferieD, fineferieD As DateTime
            If bsClientiFerie.Count > 0 Then
                RFS = DirectCast(bsClientiFerie.Current, DataRowView).Row
                inizioferieD = RFS.inizio
                fineferieD = RFS.fine
            Else
                inizioferieD = Nothing
                fineferieD = Nothing
                tmpFerie = 0
            End If


            For Each l In bsCalendario
                rg = DirectCast(l, DataRowView).Row
                NgiornoSettimana = (rg.giorno.DayOfWeek)
                Sgiornosettimana = {"dom", "lun", "mar", "mer", "gio", "ven", "sab"}(NgiornoSettimana)
                Dim NColMese As Integer = CInt(rg.gm)
                BSsost.Filter = String.Format("data = '{0}' AND idsost = {1}", rg.giorno.ToShortDateString, RRorari.item("id_utente"))
                Dim RGsos As DSfestivita.DTutentisostituzioniRow


                Dim anag, detta As String
                anag = RRorari.item("anagrafica") 'Scrive il Nome del Destinatario
                detta = RRorari.item("dettaglio")
                anag = anag.Substring(0, If(anag.Length >= 15, 15, anag.Length))
                detta = detta.Substring(0, If(detta.Length >= 20, 20, detta.Length))
                dgwDestinatariMese(0, Riga).Value = detta & "-" & anag
                dgwDestinatariMese(0, Riga).Tag = iddet
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
                    dgwDestinatariMese(NColMese, Riga).Style = k
                    dgwDestinatariMese(NColMese, Riga).Value = If(totore > 0, totore, "")

                ElseIf dgwDestinatariMese.Columns(NColMese).HeaderText = "FS" Then ' Se e una festivita allora Cambia il colore di sfondo
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.DeepSkyBlue
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwDestinatariMese(NColMese, Riga).Style = k
                    dgwDestinatariMese(NColMese, Riga).Value = "F " & If(totore > 0, totore, "")
                    dgwDestinatariMese(NColMese, Riga).Tag = Tag
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
                        dgwDestinatariMese(NColMese, Riga).ToolTipText += RGsos.anagrafica & "/"
                        dgwDestinatariMese(NColMese, Riga).Value = If(Ttotore.TotalHours > 0, Ttotore.TotalHours, "")
                        dgwDestinatariMese(NColMese, Riga).Tag = Tag
                        dgwDestinatariMese(NColMese, Riga).Style = k

                    Next

                ElseIf rg.giorno >= inizioferieD And rg.giorno <= fineferieD And rg.giorno >= inizioferieU And rg.giorno <= fineferieU Then  'Se e' chiuso il cliente e manca anche il dipendente
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.DarkCyan  'Azzurro scuro
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwDestinatariMese(NColMese, Riga).Style = k
                    dgwDestinatariMese(NColMese, Riga).Value = ""
                    dgwDestinatariMese(NColMese, Riga).Tag = Tag
                ElseIf rg.giorno >= inizioferieD And rg.giorno <= fineferieD Then  'Se è chiuso il Dettaglio cliente
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.LightCyan  'Azzurro Chiaro
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwDestinatariMese(NColMese, Riga).Style = k
                    dgwDestinatariMese(NColMese, Riga).Value = ""
                    dgwDestinatariMese(NColMese, Riga).Tag = Tag
                ElseIf rg.giorno >= inizioferieU And rg.giorno <= fineferieU Then  'Se è in ferie il dipendente
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = Color.LightCoral  'Verde Oli
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwDestinatariMese(NColMese, Riga).Style = k
                    dgwDestinatariMese(NColMese, Riga).Value = If(totore > 0, totore, "")
                    dgwDestinatariMese(NColMese, Riga).Tag = Tag
                Else
                    Dim k As New DataGridViewCellStyle
                    k.BackColor = DefaultBackColor
                    k.Font = New Font("Arial", 8, FontStyle.Bold)
                    k.Alignment = DataGridViewContentAlignment.MiddleCenter
                    dgwDestinatariMese(NColMese, Riga).Style = k
                    dgwDestinatariMese(NColMese, Riga).Value = If(totore > 0, totore, "")
                    dgwDestinatariMese(NColMese, Riga).Tag = Tag
                End If

            Next
            Riga += 1
        Next
        bsClientiFerie.RemoveFilter()
        Return True
    End Function

    Private Sub dgwSviluppoOreDipendenteMese_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwSviluppoOreDipendenteMese.CellClick
        Dim iddestinatario As Int16
        iddestinatario = dgwSviluppoOreDipendenteMese(0, e.RowIndex).Tag
        '
        '
        'Quando seleziono il destinatario mi carica il riepilogo e l'impegno del mese del destinatario
        '
        '
        AggiornamentoValoriCliente(iddestinatario)
    End Sub
    Private Function AggiornamentoValoriCliente(ByVal idDes As Int16)

        caricaintestazioneMeseCliente()
        caricaValoriMeseCliente(idDes)
        CaricaPossibiliSostituti(idDes)
        lbDestinatarioMese.Text = "Situazione cliente nel Periodo Considerato di " & ritorna_mese(PeriodoLocale.Split("-").Skip(1).First)
        Return True
    End Function
    Private Sub dgwFerieUtente_Formatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwFerieUtente.CellFormatting
        Dim valore As DateTime
        Dim DG As DataGridView = DirectCast(sender, DataGridView)
        If collegaData Then
            valore = DG(dgwcFerieUtenteInizio.Index, e.RowIndex).Value
            Dim MeseConfronto As String
            MeseConfronto = Now().Month.ToString.PadLeft(2, "00") ' PeriodoLocale.Split("-").Skip(1).First  Se voglio che confronti il periodo analizzato
            If MeseConfronto = valore.Month.ToString.PadLeft(2, "00") Then
                e.CellStyle.BackColor = Color.LightCoral
            Else
                e.CellStyle.BackColor = DefaultBackColor
            End If
        End If

    End Sub
    Private Sub dgwFerieUtente_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwFerieUtente.RowValidating
        Dim bs As BindingSource = bsUtentiFerie
        Dim rgRighe As DSfestivita.DTferieutenteRow
        If bs.Count <= 0 Then
            Return
        End If
        bs.EndEdit()
        rgRighe = DirectCast(bs.Current, DataRowView).Row
        Select Case rgRighe.controllo
            Case 1
                rgRighe.id_user_visione = GlobalVarPOP.G_idUtente
                rgRighe.data_visione = Now()
            Case 2
                rgRighe.id_user_visione = If(rgRighe.Isid_user_visioneNull, GlobalVarPOP.G_idUtente, rgRighe.id_user_visione)
                rgRighe.data_visione = If(rgRighe.Isdata_visioneNull, Now(), rgRighe.data_visione)
                rgRighe.id_user_accettazione = GlobalVarPOP.G_idUtente
                rgRighe.data_accettazione = Now()
            Case 3
                rgRighe.id_user_visione = If(rgRighe.Isid_user_visioneNull, GlobalVarPOP.G_idUtente, rgRighe.id_user_visione)
                rgRighe.data_visione = If(rgRighe.Isdata_visioneNull, Now(), rgRighe.data_visione)
                rgRighe.id_user_accettazione = GlobalVarPOP.G_idUtente
                rgRighe.data_accettazione = Now()
        End Select

        Select Case rgRighe.RowState
            Case DataRowState.Modified
                TAferieutente.QRmodifica(rgRighe.id_dip, rgRighe.inizio, rgRighe.fine, rgRighe.note, rgRighe.controllo,
                                         If(rgRighe.Isid_cliNull, Nothing, rgRighe.id_cli),
                                         If(rgRighe.Isid_desNull, Nothing, rgRighe.id_des),
                                         If(rgRighe.Isid_user_visioneNull, Nothing, rgRighe.id_user_visione),
                                         If(rgRighe.Isid_user_accettazioneNull, Nothing, rgRighe.id_user_accettazione),
                                         If(rgRighe.Isdata_visioneNull, Nothing, rgRighe.data_visione),
                                         If(rgRighe.Isdata_accettazioneNull, Nothing, rgRighe.data_accettazione),
                                         rgRighe.id)
                rgRighe.AcceptChanges()
        End Select

    End Sub


    Sub CaricaPossibiliSostituti(ByVal id As Int16)

        Using DT As New DSfestivita.dtPossibiliSostituzioniDataTable
            Using TA As New DSfestivitaTableAdapters.taPossibiliSostituzioni
                TA.FillPossibiliSostituti(DT, id)
                bsPossibiliSostituti.DataSource = DT
            End Using
        End Using
    End Sub

    Private Sub FerieApprovateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FerieApprovateToolStripMenuItem.Click, FerieGestiteNelMeseToolStripMenuItem.Click, FerieRifiutateToolStripMenuItem.Click, VisualizzaLeFerieDaGestireToolStripMenuItem.Click, ElencoDiChiHaChiestoLeFerieToolStripMenuItem.Click
        Dim clic As ToolStripDropDownItem
        clic = DirectCast(sender, ToolStripDropDownItem)
        For Each mm As ToolStripMenuItem In tsFiltro.DropDownItems
            Console.WriteLine(mm.Name)
            Select Case True
                Case mm.Name = clic.Name
                    mm.Checked = True
                Case Else
                    mm.Checked = False
            End Select
        Next
        CaricaDT()
    End Sub

    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        If tblPrincipale.ColumnStyles(1).Width = 0 Then
            tblPrincipale.ColumnStyles(1).SizeType = SizeType.Absolute
            tblPrincipale.ColumnStyles(1).Width = 600
            Dim rp As ReportViewer = New ReportViewer
            rp.Dock = DockStyle.Fill
            rp.Name = "ElencoFerieDipendente"
            Dim rep As LocalReport
            rep = rp.LocalReport
            rep.DataSources.Add(New ReportDataSource("DataSet1", bsUtentiFerie))
            rep.ReportEmbeddedResource = "PoP2.Dipendenti.rpElencoRichiesteFerie.rdlc"
            tblPrincipale.Controls.Add(rp)
            rp.RefreshReport()
        Else
            tblPrincipale.ColumnStyles(1).SizeType = SizeType.Absolute
            tblPrincipale.ColumnStyles(1).Width = 0
        End If

    End Sub

    Private Sub tsCollegamentoCambioData_Click(sender As Object, e As EventArgs) Handles tsCollegamentoCambioData.Click
        collegaData = Not collegaData
        AggiornaPulsanteCollegamento()
    End Sub
    Private Sub AggiornaPulsanteCollegamento()
        Dim img As Image
        If collegaData Then
            img = PoP2.Comuni.My.Resources.Resources.ominoConferma48
            tsEtichettaSpiegazioni.Text = "Se selezioni un dipendente automaticamente sviluppa il periodo"
        Else
            img = PoP2.Comuni.My.Resources.Resources.ominonega48
            tsEtichettaSpiegazioni.Text = "aggiorna il periodo se vuoi visualizzare lo sviluppo del dipendente"
        End If
        tsCollegamentoCambioData.Image = img

    End Sub
End Class