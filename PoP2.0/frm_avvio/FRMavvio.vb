Imports MySql.Data.MySqlClient

Public Class Frmavvio

    'Assegnazioni per creare un orologio
    Dim puntoSecondi1 As Point
    Dim puntoSecondi2 As Point
    Dim puntoMinuti1 As Point
    Dim puntoMinuti2 As Point
    Dim puntoOre1 As Point
    Dim puntoOre2 As Point
    'coordinate della form 
    Dim penna As New Pen(Color.Black, 3)
    Dim inc As Integer
    Dim DT_avvisi As New DS_ag.DT_avvisiDataTable
    Dim BS_avvisi As New BindingSource
    Dim ValoriAzienda As New DS_azienda.DT_aziendaDataTable

    <CodeAnalysis.SuppressMessage("Design", "CA1062:Convalidare gli argomenti di metodi pubblici", Justification:="<In sospeso>")>
    Public Sub New(ByVal rigaUtente As DataRow)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        GlobalVarPOP.G_idUtente = rigaUtente("id") ' identificativo dell'utente registrato
        GlobalVarPOP.G_nomeutente = rigaUtente("uid")
        GlobalVarPOP.G_idAZ = rigaUtente("id_az")
        GlobalVarPOP.G_emailutente = rigaUtente("email")
        GlobalVarPOP.G_pwdutente = rigaUtente("pswinvio")
        GlobalVarPOP.G_indirizzosmtp = rigaUtente("smtpserver")
        GlobalVarPOP.gradoaccesso = rigaUtente("gradoaccesso")
        GlobalVarPOP.GColoreUtenteLoggato = rigaUtente("colore")
    End Sub

    Private Sub F_Avvio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        caricaAziendaProduttiva()
        If GlobalVarPOP.gradoaccesso > 750 Then
            lbAzienda.Visible = True
            CBazienda.Visible = True
        Else
            CBazienda.Visible = False
            lbAzienda.Visible = False
        End If

        CreaOrologio()
        Dim DT_memo As DS_servizio.DT_info_pop2Row
        DT_memo = dsolidofunc.legge_informazioni(Me.Name, GlobalVarPOP.G_nomeutente)
        'Carica Array Mesi
        cmbMese.Items.AddRange(GlobalVarPOP.G_amese)

        'Carica gli Anni
        Dim aArray As String()
        For yy = Now.Year + 1 To Now.Year - 10 Step -1
            aArray.Add(yy.ToString)
        Next
        GlobalVarPOP.G_aAnno = aArray

        cmbAnno.Items.AddRange(GlobalVarPOP.G_aAnno)

        If IsNothing(DT_memo) Then
            'Assegna l'anno e il mese corrente
            cmbAnno.SelectedItem = Now.Year.ToString
            cmbMese.SelectedItem = GlobalVarPOP.G_amese(Now.Month - 1)
        Else
            'Assegna l'anno e il mese memorizzati
            cmbAnno.SelectedItem = DT_memo.anno.ToString
            cmbMese.SelectedItem = GlobalVarPOP.G_amese(DT_memo.mese - 1)
        End If

        GlobalVarPOP.GPeriodo = cmbAnno.SelectedItem & "-" & (cmbMese.SelectedIndex + 1).ToString.PadLeft(2, "0")

        If cmbAnno.SelectedItem <> Now.Year Then
            If MsgBox("Stai lavorando nell'anno " & cmbAnno.SelectedItem & ", imposto l'anno Corretto ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cmbAnno.SelectedItem = Now.Year.ToString()
            End If
        End If
        If cmbMese.SelectedIndex <> Now.Month - 1 Then
            If MsgBox("Stai lavorando col mese di " & cmbMese.SelectedItem & ", imposto il mese Corretto ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cmbMese.SelectedIndex = Now.Month - 1
            End If
        End If

#If DEBUG Then
        'BT_videoscrittura.Visible = True
#Else
        'BT_videoscrittura.Visible = False
#End If
        'CreaElencoAvvisi()
        'CKL_avvisi.HorizontalScrollbar = True
        Etichetta_rete.Text = "Versione : " & String.Format("{0}.{1}.{2}.{3}", My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)
        Timer1.Interval = 60000
        Timer1.Enabled = True
        Timer2.Interval = 1000
        Timer2.Enabled = True
        If Not StatoConnessione.ConnessioneInternet() Then
            MsgBox("Non é presente una connessione a Internet valida")
            Me.Close()
        End If
        '
        ' Controlla le situazione inserite dai dipendenti
        '
        controllaRemoti()
        'á il benvenuto indicando il nome dell'utente
        If GlobalVarPOP.gradoaccesso > 100 Then
            TX_avvio.BackColor = Color.White
        Else
            TX_avvio.BackColor = Color.Red
        End If
        AggiornaAgendaOggi()
        ControlloAggiornamentoAgenda()
        subControllaNuoveFerie()
        ControlloSegnalazioniCliente()
        'Avvisi()
    End Sub
    Private Sub ControlloSegnalazioniCliente()
        Dim tv As TreeView = tvSegnalazioniClienti
        tv.Nodes.Clear()

        Using dt As New DS_clienti.dtCantieriSegnalazioniDataTable
            Using ta As New DS_clientiTableAdapters.taCantieriSegnalazioni
                ta.Fill(dt)
                Dim rs = From x In dt Group By x.risoluzione Into Count(x.id), segnalazioni = Group
                For Each rgSol In rs
                    'Se ci sono stati o sono ancora presenti dei problemi
                    If rgSol.risoluzione > 0 Then
                        Dim x As Int16 = 0
                        tv.Nodes.Add("Risolti", "Risolti")
                        tv.Nodes("Risolti").Tag = "#"
                        For Each rrSol In rgSol.segnalazioni
                            x += 1
                            tv.Nodes("Risolti").Text = x.ToString & " Risolti"
                            tv.Nodes("Risolti").ForeColor = Color.DarkGreen
                            tv.Nodes("Risolti").Nodes.Add(rrSol.id.ToString & rrSol.risoluzione, rrSol.locazione & " | " & rrSol.datachiusura.ToShortDateString)
                            tv.Nodes("Risolti").Nodes(rrSol.id.ToString & rrSol.risoluzione).Tag = rrSol.id_cli
                            tv.Nodes("Risolti").Nodes(rrSol.id.ToString & rrSol.risoluzione).ToolTipText = "Clicca per visualizzare"
                        Next
                    Else
                        tv.Nodes.Add("InCorso", "In Corso")
                        tv.Nodes("InCorso").Tag = "#"
                        Dim x As Int16 = 0
                        For Each rrSol In rgSol.segnalazioni
                            x += 1
                            tv.Nodes("InCorso").Text = x.ToString & " In Corso"
                            tv.Nodes("InCorso").ForeColor = Color.Red
                            tv.Nodes("InCorso").Nodes.Add(rrSol.id.ToString & rrSol.risoluzione, rrSol.locazione & " | " & rrSol.datasegnalazione.ToShortDateString)
                            tv.Nodes("InCorso").Nodes(rrSol.id.ToString & rrSol.risoluzione).Tag = rrSol.id_cli
                            tv.Nodes("InCorso").Nodes(rrSol.id.ToString & rrSol.risoluzione).ToolTipText = "Clicca per visualizzare"
                        Next
                    End If
                Next
            End Using
        End Using
    End Sub
    Private Sub tvSegnalazioniClienti_MouseDoubleClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles tvSegnalazioniClienti.NodeMouseDoubleClick
        Dim tv As TreeView = tvSegnalazioniClienti
        Dim idCli As Int16
        If IsNothing(e.Node.Tag) Then
            Return
        End If
        If e.Node.Tag.ToString <> "#" Then
            Select Case False
                Case IsNothing(tv.Nodes("InCorso"))
                    idCli = tv.Nodes("InCorso").Nodes(e.Node.Index).Tag
                    If Not IsNothing(idCli) Then
                        If GlobalVarPOP.gradoaccesso > 200 Then
                            Dim tmp As New FrmCantieri
                            tmp.RichiamoPosizione = idCli
                            avvio_maschera(tmp)
                        Else
                            MsgBox("Non hai sufficienti diritti di accesso ai fornitori")
                        End If
                    End If
                Case IsNothing(tv.Nodes("Risolti"))
                    idCli = tv.Nodes("Risolti").Nodes(e.Node.Index).Tag
                    If Not IsNothing(idCli) Then
                        If GlobalVarPOP.gradoaccesso > 200 Then
                            Dim tmp As New FrmCantieri
                            tmp.RichiamoPosizione = idCli
                            avvio_maschera(tmp)
                        Else
                            MsgBox("Non hai sufficienti diritti di accesso ai fornitori")
                        End If
                    End If
            End Select
        End If
        TX_avvio.BackColor = Color.White
        TX_avvio.Text = "Benvenuto " & GlobalVarPOP.G_nomeutente
    End Sub


    Private Sub subControllaNuoveFerie()
        Using dt As New DSfestivita.DTferieutenteDataTable
            Using ta As New DSfestivitaTableAdapters.TAferieutente
                ta.FillByNuoveFerie(dt)
                Dim num As Int16 = dt.Rows.Count
                If num > 0 Then
                    Dim nUrgenti As Integer
                    For Each riga As DSfestivita.DTferieutenteRow In dt.Rows
                        If riga.inizio.Year.ToString = GlobalVarPOP.GPeriodo.Split("-").First Then
                            Dim mese As String = riga.inizio.Month.ToString.PadLeft(2, "00")
                            If mese = GlobalVarPOP.GPeriodo.Split("-").Skip(1).First Then
                                nUrgenti += 1
                            End If
                        End If
                    Next

                    btFeriePresenti.Text = String.Format("{0} URGENTI " & Chr(13) &
                                                         "{1} TOTALI", nUrgenti, num)
                End If
            End Using
        End Using
    End Sub
    Private Sub controllaRemoti()
        '
        ' Controlla se sono presenti degli ordini Remoti da evadere
        '
        Dim TA As New DS_OrdiniTableAdapters.TAordiniWeb
        Dim totaleOrdini As Integer = TA.SQconta_inviato(1)
        Dim totaleOrdiniattesa As Integer = TA.SQconta_inviato(0)
        Dim stringaOrdiniRemoti As String = ""
        Select Case totaleOrdini
            Case = 0
                stringaOrdiniRemoti = String.Format("Nessun ordine presente, {0} in attesa", totaleOrdiniattesa)
            Case = 1
                stringaOrdiniRemoti = String.Format("Presente {0} ordine convalidato, {1} in attesa", totaleOrdini, totaleOrdiniattesa)
            Case > 1
                stringaOrdiniRemoti = String.Format("Presenti {0} ordini convalidati, {1} in attesa", totaleOrdini, totaleOrdiniattesa)
        End Select
        LL_ordiniweb.Text = stringaOrdiniRemoti

    End Sub

    Private Sub avvio_maschera(tmp_form As Form)
        'lancia tutte le maschere
        Try
            TX_avvio.BackColor = Color.Green
            TX_avvio.Text = "Avviando ..."
            System.Windows.Forms.Application.DoEvents()
            If Not controlla_form_aperto(tmp_form) Then
                System.Windows.Forms.Application.DoEvents()
                Dim ftmp As New Form
                ftmp = tmp_form
                ftmp.Show(Me)
                System.Windows.Forms.Application.DoEvents()
            End If
        Catch ex As Exception
#If DEBUG Then
            Console.WriteLine(ex.Message)
#End If
        End Try
    End Sub

    'Private Sub Button1_Click(sender As Object, e As EventArgs)
    '    Dim fFornitori As New frm_fornitori
    '    fFornitori.ShowDialog()
    'End Sub

    Private Sub STS_clienti_Click(sender As Object, e As EventArgs) Handles STS_clienti.Click, STS_dipendenti.Click,
        STS_materiale.Click, STS_contabilita.Click, STS_impostazioni.Click
        Dim s_nodo As String = ""


        Try
            Select Case sender.name
                Case "STS_clienti"
                    s_nodo = "nd_clienti"
                    If GlobalVarPOP.gradoaccesso > 200 Then
                        Dim tmp As New FrmCantieri
                        avvio_maschera(tmp)
                    Else
                        MsgBox("Non hai sufficienti diritti di accesso ai fornitori")
                    End If
                Case "STS_dipendenti"
                    s_nodo = "nd_dipendenti"
                    If GlobalVarPOP.gradoaccesso > 200 Then
                        Dim tmp As New FrmDipendenti
                        avvio_maschera(tmp)
                    Else
                        MsgBox("Non hai sufficienti diritti di accesso ai Dipendenti")
                    End If

                Case "STS_materiale"
                    s_nodo = "nd_magazzino"
                    If GlobalVarPOP.gradoaccesso > 200 Then
                        Dim tmp As New FrmOrdineMateriale
                        tmp.Show()
                        'avvio_maschera(tmp)
                    Else
                        MsgBox("Non hai sufficienti diritti di accesso ai clienti")
                    End If

                Case "STS_contabilita"
                    s_nodo = "nd_contabilita"
                    If GlobalVarPOP.gradoaccesso > 800 Then
                        Dim tmp As New FrmFattura
                        avvio_maschera(tmp)
                    Else
                        MsgBox("Non hai sufficienti diritti")
                    End If
                Case "STS_www"
                    s_nodo = "nd_generaPDF"
                    If GlobalVarPOP.gradoaccesso > 500 Then
                        Dim tmp As New FRM_separatorePDF
                        avvio_maschera(tmp)
                    Else
                        MsgBox("Non hai sufficienti diritti")
                    End If

                Case "STS_impostazioni"
                    s_nodo = "nd_impostazioni"
                    Dim tmp As New Frm_login
                    avvio_maschera(tmp)
            End Select
            TX_avvio.BackColor = Color.White
            TX_avvio.Text = "Benvenuto " & GlobalVarPOP.G_nomeutente
            If menu_principale.Nodes.Item(s_nodo).IsExpanded Then
                Me.menu_principale.Nodes.Item(s_nodo).Collapse()
            Else
                Me.menu_principale.Nodes.Item(s_nodo).ExpandAll()
            End If

        Catch ex As Exception
#If DEBUG Then
            Console.WriteLine(ex.Message)
#End If
        End Try

    End Sub



    Private Sub frmavvio_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode

            Case 113        'F2
                STS_dipendenti.PerformClick()
            Case 114        'F3
                STS_clienti.PerformClick()
            Case 115        'F4
                STS_materiale.PerformClick()
            Case 116        'F5
                STS_contabilita.PerformClick()
            Case 120        'F9
                STS_impostazioni.PerformClick()
            Case 27
                If MessageBox.Show("Vuoi terminare la sessione ?", "Termino Sessione", MessageBoxButtons.YesNo) = vbYes Then
                    Me.Dispose()
                    Me.Close()
                    End
                End If
            Case Else
#If DEBUG Then
                Console.WriteLine(e.KeyCode)
#End If

        End Select

    End Sub

    Private Sub menu_principale_NodeMouseClick(sender As Object, e As TreeNodeMouseClickEventArgs) Handles menu_principale.NodeMouseClick
        Select Case e.Node.Name.ToString
            Case "nd_dipendenti"
                If GlobalVarPOP.gradoaccesso > 200 Then
                    Dim tmp As New FrmDipendenti
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti di accesso ai Dipendenti")
                End If

            Case "nd_dip_lettere"
                If GlobalVarPOP.gradoaccesso > 200 Then
                    'Dim tmp As New FRM_word
                    'avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti inserire le presenze")
                End If
            Case "ndautofatturazione"
                If GlobalVarPOP.gradoaccesso > 200 Then
                    Dim tmp As New frmAggiungeAziendaAutofattura
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti inserire le presenze")
                End If

            Case "nd_mag_prodotti2"
                If GlobalVarPOP.gradoaccesso > 100 Then
                    Dim tmp As New FrmProdotti
                    avvio_maschera(tmp)

                Else
                    MsgBox("Non hai sufficienti diritti di accesso ai prodotti")
                End If
            Case "ndReportQualita"
                If GlobalVarPOP.gradoaccesso > 100 Then
                    Dim tmp As New FrmRapportoQualita
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti di accesso ai fornitori")
                End If

            Case "nd_mag_fornitori"
                If GlobalVarPOP.gradoaccesso > 100 Then
                    'Dim tmp As New frm_fornitori
                    'avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti di accesso ai fornitori")
                End If

            Case "nd_mag_ordiniWeb"
                If GlobalVarPOP.gradoaccesso > 100 Then
                    Dim tmp As New FRMOrdiniWeb
                    avvio_maschera(tmp)

                Else
                    MsgBox("Non hai sufficienti diritti di accesso ai prodotti")
                End If
            Case "nd_mag_macchinari"
                If GlobalVarPOP.gradoaccesso > 600 Then
                    Dim tmp As New FRMmacchinari
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti gestire i Macchinari")
                End If

            Case "nd_cli_anagrafica"
                If GlobalVarPOP.gradoaccesso > 200 Then
                    Dim tmp As New FrmCantieri
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti di accesso ai clienti")
                End If
            Case "nd_documentiremoti"
                If GlobalVarPOP.gradoaccesso > 600 Then
                    Dim tmp As New FRM_gestioneDocumentale
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti di accesso ai documenti")
                End If

            Case "ND_cli_riepilogo_ore"
                If GlobalVarPOP.gradoaccesso > 650 Then
                    Dim tmp As New frmCantieriRiepilogoPresenze
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti di accesso al riepilogo Ore")
                End If
            Case "nd_cli_red"
                If GlobalVarPOP.gradoaccesso > 900 Then
                    Dim tmp As New frmCantieriRese
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti di accesso per visionare il monte ore del cliente")
                End If
                'Se il nodo é contabilitá (nd_con.....)
                'Se il nodo é contabilitá (nd_con.....)

            Case "nd_con_fatture"
                If GlobalVarPOP.gradoaccesso > 800 Then

                    Dim tmp As New FrmFattura
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti inserire le presenze")
                End If
            Case "ndFatPublicazione"
                If GlobalVarPOP.gradoaccesso > 800 Then
                    Dim tmp As New FRMpubblicaFatturePDF
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti inserire le presenze")
                End If

            Case "nd_con_generafatture"
                If GlobalVarPOP.gradoaccesso > 800 Then
                    Dim tmp As New FRM_genera_fatture
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti inserire le presenze")
                End If
            Case "nd_con_fattelettronica"
                If GlobalVarPOP.gradoaccesso > 800 Then
                    Dim tmp As New FRM_FatturazioneB2B
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti inserire le presenze")
                End If

            Case "nd_con_analisiordiniperfattura"
                If GlobalVarPOP.gradoaccesso > 800 Then
                    'Dim tmp As New FRM_OrdiniRiepiloghiMensili
                    'avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti inserire le presenze")
                End If
            Case "nd_con_analizzaazienda"
                If GlobalVarPOP.gradoaccesso > 800 Then
                    Dim tmp As New FRM_AndamentoAzienda
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti inserire le presenze")
                End If

            Case "nd_con_scadenze"
                If GlobalVarPOP.gradoaccesso > 600 Then
                    Dim tmp As New FRM_fatture_scadenze
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti per gestire i pagamenti")
                End If

            Case "nd_mag_ordini2"
                If GlobalVarPOP.gradoaccesso > 200 Then
                    'Try
                    Dim tmp As New FrmOrdineMateriale
                    avvio_maschera(tmp)

                Else
                    MsgBox("Non hai sufficienti diritti di accesso ai clienti")
                End If

            Case "nd_generaPDF"
                If GlobalVarPOP.gradoaccesso > 500 Then
                    Dim tmp As New FRM_separatorePDF
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti di accesso")
                End If

            Case "nd_imp_cap"
                'Dim tmp As New frm_cap(0, "", "")
                'avvio_maschera(tmp)
            Case "nd_imp_tipo_formazione"
                Dim tmp As New frmDipendentiTipoFormazione("")
                avvio_maschera(tmp)
            '    End Using
            Case "nd_dip_ferie"
                Dim tmp As New frmDipendentiGestioneFerie()
                avvio_maschera(tmp)

            Case "nd_imp_calendario"
                Dim tmp As New frm_calendario()
                avvio_maschera(tmp)
            Case "nd_termina"
                Me.Dispose()
                Me.Close()
                End
            Case "ndRicercaPersonale"
                'Dim RicercaPersonale As New RicercaSostituzioni.frmGestioneSostituzioni
                'RicercaPersonale.ShowDialog()

            Case "ndAutorizzaFerie"

                Dim tmp As New frmDipendentiFerie
                avvio_maschera(tmp)
            Case "ndIOP"
                If GlobalVarPOP.gradoaccesso > 500 Then
                    Dim tmp As New frmProcedureOperative
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti")
                End If
            Case "ndIstruzioni"
                If GlobalVarPOP.gradoaccesso > 500 Then
                    Dim tmp As New frmIstruzioniOperative
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti")
                End If
            Case "ndDescrizioneProdotti"
                If GlobalVarPOP.gradoaccesso > 500 Then
                    Dim tmp As New frmDescrizioneProdotti
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti")
                End If
            Case "ndAssegnaGPS"
                If GlobalVarPOP.gradoaccesso > 500 Then
                    Dim tmp As New frmControlloPosizioneGPS
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti Gestire il controllo GPS")
                End If
            Case "ndPreventivazione"
                If GlobalVarPOP.gradoaccesso > 800 Then
                    Dim tmp As New FrmPreventivo
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti per gestire i preventivi")
                End If
            Case "ndCQclienti"
                If GlobalVarPOP.gradoaccesso > 600 Then
                    Dim tmp As New FrmAbbinamentoCantieriCQ
                    avvio_maschera(tmp)
                Else
                    MsgBox("Non hai sufficienti diritti per gestire i preventivi")
                End If

        End Select
#If DEBUG Then
        Console.WriteLine(e.Node.Name.ToString)
#End If

        TX_avvio.BackColor = Color.White
        TX_avvio.Text = "Benvenuto " & GlobalVarPOP.G_nomeutente
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            ControlloAggiornamentoAgenda()
            ControlloSegnalazioniCliente()
        Catch ex As Exception

        End Try

    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        AggiornaOrologio()

    End Sub

    Private Sub ControlloAggiornamentoAgenda()
        'Try
        AggiornaAgenda()

        TX_avvio.Text = "Benvenuto " & GlobalVarPOP.G_nomeutente
        TX_avvio.BackColor = Color.White

    End Sub
    Private Sub AggiornaAgenda()
        Dim NomeStampa As String
        NomeStampa = ""
        Dim tipo As Integer = Nothing
        Select Case True
            Case NomeStampa.ToLower.Contains("ferie")
                tipo = 2 ' Ferie
            Case NomeStampa.ToLower.Contains("malattia")
                tipo = 1 ' Malattia
            Case Else
                tipo = Nothing
        End Select

        DG_giorno.Rows.Clear()
        Dim DGFontp As New Font("Tahoma", 8)
        If TX_dataoggi.Text = "" Then
            Return
        End If
        Dim Giorno As DateTime = Date.Parse(TX_dataoggi.Text)
        Dim xx As Integer = 0
        Dim DT As New DS_ag.DTsostituzioniDataTable

        If IsNothing(tipo) Or tipo = 0 Then
            Try
                Using TA As New DS_agTableAdapters.TAsostituzioni
                    TA.FillByGiorno(DT, Giorno)
                End Using
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            Using TA As New DS_agTableAdapters.TAsostituzioni
                TA.FillByGiornoTipo(DT, Giorno, tipo)
            End Using

        End If

        For Each RG_a As DS_ag.DTsostituzioniRow In DT.Rows
            'RG_a = DirectCast(RG_p, ).Row
            If RG_a.data.ToShortDateString = Giorno.ToShortDateString Then
                Dim OldStringa As String = ""
                Dim OldToolStrip As String = ""
                Dim OldTag As String = ""
                Dim anaA As String
                Try
                    anaA = IIf(RG_a.Isanagrafica_ANull, "", RG_a.anagrafica_A)
                Catch ex As Exception
                    anaA = ""
                End Try

                Dim Stringa As String = anaA.Substring(0, If(anaA.Length > 20, 20, anaA.Length))
                Dim ToolStrip As String = "|ORA:" & TempoStringaCorta(RG_a.ing) &
                                                            "->" & TempoStringaCorta(RG_a.usc) &
                                                            "|NO:" & Stringa &
                                                            "->" & RG_a.anagrafica_S.Substring(0, If(RG_a.anagrafica_S.Length > 20, 20, RG_a.anagrafica_S.Length)) &
                                                            "|DOVE:" & RG_a.locazione.Substring(0, If(RG_a.locazione.Length > 20, 20, RG_a.locazione.Length)) &
                                                            Strings.Chr(13)
                DG_giorno.Rows.Add()

                DG_giorno("C_ora", xx).Value = TempoStringaCorta(RG_a.ing) & "--" & TempoStringaCorta(RG_a.usc)
                DG_giorno.Columns("C_ora").Width = 70
                DG_giorno("C_Assente", xx).Value = RG_a.anagrafica_S
                If RG_a.idsost < 0 Then
                    DG_giorno.Rows(xx).DefaultCellStyle.BackColor = Color.OrangeRed
                End If
                DG_giorno("C_sostituto", xx).Value = RG_a.anagrafica_A
                DG_giorno("CAgendaID", xx).Value = RG_a.id
                DG_giorno("C_locazione", xx).Style.Font = New Font("Microsoft Sans Serif", 10, FontStyle.Bold)
                DG_giorno("C_locazione", xx).Value = RG_a.locazione
                DG_giorno("C_cliente", xx).Value = RG_a.societa
                DG_giorno("C_tipo", xx).Value = RG_a.descrizione
                DG_giorno("C_note", xx).Value = RG_a.note
                DG_giorno("C_iddip", xx).Value = RG_a.iddip
                DG_giorno("C_IDsost", xx).Value = RG_a.idsost
                DG_giorno("C_IDcli", xx).Value = RG_a.idcli
                DG_giorno("C_data", xx).Value = RG_a.data
                DG_giorno(DGWCsostidraggruppamento.Index, xx).Value = If(RG_a.IsidraggruppamentoNull, 0, RG_a.idraggruppamento)
                DG_giorno(DGWCsostidconfermato.Index, xx).Value = If(RG_a.IsidconfermaNull, 0, RG_a.idconferma)
                xx += 1
            End If
        Next

        Dim dttmp As Object = DT.ToList

        LB_assenti.Text = "Assenti di oggi: " & xx
    End Sub
    Private Sub AggiornaData(sender As Object, e As EventArgs) Handles BT_indietro.Click, BT_avanti.Click
        Dim BTtmp As Button
        BTtmp = DirectCast(sender, Button)
        Dim DTtmp As New DateTime
        Dim Giorno() As String = {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
        DTtmp = TX_dataoggi.Text
        TX_dataoggi.Text = DateAdd(DateInterval.Day, BTtmp.Tag, DTtmp).ToShortDateString
        TX_nomegiorno.Text = Giorno(DateAdd(DateInterval.Day, BTtmp.Tag, DTtmp).DayOfWeek)
        ControlloAggiornamentoAgenda()
    End Sub
    Private Sub AggiornaAgendaOggi()
        Dim Giorno() As String = {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
        Dim DTtmp As DateTime = Now()
        TX_dataoggi.Text = DTtmp.ToShortDateString
        TX_nomegiorno.Text = Giorno(DTtmp.DayOfWeek)
    End Sub
    Private Sub BT_oggi_Click(sender As Object, e As EventArgs) Handles BT_oggi.Click
        AggiornaAgendaOggi()
        ControlloAggiornamentoAgenda()
        ControlloSegnalazioniCliente()
    End Sub
    Private Sub FormnonFOCUS() Handles MyBase.Deactivate
        Timer1.Enabled = False
        Timer2.Enabled = False
    End Sub
    Private Sub FormFOCUS() Handles MyBase.Activated
        Timer1.Enabled = True
        Timer2.Enabled = True
    End Sub

    Private Sub DG_giorno_rigaClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_giorno.CellDoubleClick
        TX_avvio.BackColor = Color.Green
        TX_avvio.Text = "Avviando ..."
        System.Windows.Forms.Application.DoEvents()
        Dim Cella As DataGridView
        Cella = DirectCast(sender, DataGridView)
        Dim Giorno As DateTime = TX_dataoggi.Text
        Dim BS As New BindingSource

        Using TA As New DS_agTableAdapters.TAsostituzioni
            Using DT As New DS_ag.DTsostituzioniDataTable
                TA.FillByGiorno(DT, Giorno)
                BS.DataMember = DT.ToString
                BS.DataSource = DT
                If e.RowIndex >= 0 Then
                    BS.Filter = "id = " & DG_giorno("CAgendaID", e.RowIndex).Value
                    Dim rg As DS_ag.DTsostituzioniRow
                    rg = DirectCast(BS.Current, DataRowView).Row

                    Dim Tag As String
                    ' Tag += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", f.iddip, f.ing, f.usc, idDip, idSos, f.idcli, f.iddet, If(f.idrecupero = 0, -1, f.idrecupero), f.idtip)
                    Tag = String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", rg.iddip, rg.ing, rg.usc, rg.iddip, rg.idsost, rg.idcli, rg.iddes, DG_giorno("CAgendaID", e.RowIndex).Value, rg.idtipo)
                    Dim FF As New FrmAgendaModifica(BS, Tag, Giorno, Now.TimeOfDay)
                    FF.ShowDialog()
                End If

            End Using
        End Using
        TX_avvio.BackColor = Color.White
        ControlloAggiornamentoAgenda()
        TX_avvio.Text = "Benvenuto " & GlobalVarPOP.G_nomeutente
        TX_avvio.BackColor = Color.White

    End Sub
    Private Sub AggiornaOrologio()
        'calcola le coordinate dei punti in cui si trovano le lancette al trascorrere dei secondi 
        Dim misurax As Integer = PClock.Width / 3
        puntoSecondi1 = CalcolaPunto(6 * DateTime.Now.Second - 90, misurax)
        puntoSecondi2 = CalcolaPunto(6 * DateTime.Now.Second - 90, 3)
        puntoMinuti1 = CalcolaPunto(6 * DateTime.Now.Minute - 90, misurax)
        puntoMinuti2 = CalcolaPunto(6 * DateTime.Now.Minute - 90, 3)
        inc = DateTime.Now.Minute \ 12
        puntoOre1 = CalcolaPunto(30 * DateTime.Now.Hour - 90 + inc * 6, misurax - misurax / 2)
        puntoOre2 = CalcolaPunto(30 * DateTime.Now.Hour - 90 + inc * 6, 3)
        PClock.Refresh()
    End Sub

    Private Sub DGWFormattaRighe(ByVal sender As Object, ByVal e As DataGridViewCellFormattingEventArgs) Handles DG_giorno.CellFormatting
        Dim ora As TimeSpan = TimeSpan.Parse(Now.ToShortTimeString)
        Dim dgwTMP As DataGridView = DirectCast(sender, DataGridView)

        Dim orario As String = dgwTMP(dgwTMP.Columns("C_Ora").Index, e.RowIndex).Value
        Dim ing As TimeSpan = TimeSpan.Parse(orario.Substring(0, 5))
        Dim usc As TimeSpan = TimeSpan.Parse(orario.Substring(orario.Length - 5, 5))
        Dim Data As DateTime = DateTime.Parse(dgwTMP(dgwTMP.Columns("C_data").Index, e.RowIndex).Value & " " & usc.ToString)
        Dim modo As Integer = 0


        modo = e.RowIndex Mod 2
        If modo > 0 Then
            If Data < Now Then                 'non confermato passato
                e.CellStyle.BackColor = Color.Pink
                'colorarigaDGW(dgwTMP.Rows(e.RowIndex).Cells, Color.LightPink, "Passato")
            End If
            If Data >= Now Then     'confermato e non passato
                e.CellStyle.BackColor = Color.White
                'colorarigaDGW(dgwTMP.Rows(e.RowIndex).Cells, Color.White, "da passare")
            End If
        Else
            If Data < Now Then      'non confermato passato
                e.CellStyle.BackColor = Color.LightPink

                'colorarigaDGW(dgwTMP.Rows(e.RowIndex).Cells, Color.Pink, "Passato")
            End If
            If Data >= Now Then     'confermato e non passato
                e.CellStyle.BackColor = Color.Silver
                'colorarigaDGW(dgwTMP.Rows(e.RowIndex).Cells, Color.Silver, "da passare")
            End If

        End If
    End Sub
    Private Function colorarigaDGW(ByRef celle As DataGridViewCellCollection, ByVal colore As Color, ByVal tipsText As String)
        For Each cella As DataGridViewCell In celle
            cella.Style.BackColor = colore
            cella.ToolTipText = tipsText
        Next

    End Function
    Private Function CalcolaPunto(ByVal angolo As Single, ByVal raggio As Integer) As Point
        Dim Larghezza As Integer = PClock.Width
        Dim Altezza As Integer = PClock.Height
        Dim MezzaLarghezza As Integer = Larghezza / 2
        Dim MezzaAltezza As Integer = Altezza / 2
        Dim punto As Point
        'converte in radianti 
        angolo = CType(angolo * Math.PI / 180, Single)
        '(100,100) coordinate del centro del quadrante) 
        punto.X = CType(raggio * Math.Cos(angolo) + MezzaLarghezza, Integer)
        punto.Y = CType(raggio * Math.Sin(angolo) + MezzaAltezza, Integer)
        Return punto

    End Function
    Private Sub PBClock_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PClock.Paint
        Dim g As Graphics = e.Graphics
        'lancetta dei secondi 
        g.DrawLine(Pens.Black, puntoSecondi2.X, puntoSecondi2.Y, puntoSecondi1.X, puntoSecondi1.Y)
        'lancetta dei minuti 
        g.DrawLine(penna, puntoMinuti2.X, puntoMinuti2.Y, puntoMinuti1.X, puntoMinuti1.Y)
        'lancetta delle ore 
        g.DrawLine(penna, puntoOre2.X, puntoOre2.Y, puntoOre1.X, puntoOre1.Y)
    End Sub
    Private Sub CreaOrologio()
        'calcola le coordinate dei punti in cui si trovano le lancette quando viene visualizzata la form 
        puntoSecondi1 = CalcolaPunto(6 * DateTime.Now.Second - 90, 40)
        puntoSecondi2 = CalcolaPunto(6 * DateTime.Now.Second - 90, 3)
        puntoMinuti1 = CalcolaPunto(6 * DateTime.Now.Minute - 90, 35)
        puntoMinuti2 = CalcolaPunto(6 * DateTime.Now.Minute - 90, 3)
        inc = DateTime.Now.Minute \ 12
        puntoOre1 = CalcolaPunto(30 * DateTime.Now.Hour - 90 + inc * 6, 30)
        puntoOre2 = CalcolaPunto(30 * DateTime.Now.Hour - 90 + inc * 6, 3)
    End Sub

    Private Sub BT_nuovo_Click(sender As Object, e As EventArgs) Handles BT_nuovo.Click
        TX_avvio.BackColor = Color.Green
        TX_avvio.Text = "Avviando ..."
        System.Windows.Forms.Application.DoEvents()
        Dim Giorno As DateTime = TX_dataoggi.Text
        Dim BS As New BindingSource
        Using TA As New DS_agTableAdapters.TAsostituzioni
            Using DT As New DS_ag.DTsostituzioniDataTable
                TA.FillByGiorno(DT, Giorno)
                BS.DataMember = DT.ToString
                BS.DataSource = DT
                BS.Filter = "ID = -1"
                Dim FF As New FrmAgendaModifica(BS, Nothing, Giorno, Now.TimeOfDay)
                FF.ShowDialog()
            End Using
        End Using


        TX_avvio.BackColor = Color.White
        ControlloAggiornamentoAgenda()

    End Sub

    Private Sub BT_termina_Click(sender As Object, e As EventArgs) Handles BT_termina.Click
        Dim nome_ri As Array = {"", "id", 0, cmbMese.SelectedIndex + 1, cmbAnno.SelectedItem, ""}
        dsolidofunc.memorizza_informazioni(Me.Name, 0, GlobalVarPOP.G_nomeutente, nome_ri)
        Me.Close()
    End Sub

    Private Sub BT_stampa_Click(sender As Object, e As EventArgs) Handles BT_stampa.Click
        Dim NomeStampa As String
        NomeStampa = "settimanale"
        Dim Giorno As DateTime = TX_dataoggi.Text
        Dim UltimoGiornoSettimana As Date
        Dim PrimoLunedi As Date
        Dim iddip As Integer = Nothing  'Dipendente che deve sostituire
        Dim tmpDT As DataTable
        tmpDT = Nothing

        Select Case NomeStampa.ToLower
            Case "settimanale"
                PrimoLunedi = DateAdd("d", -Weekday(Giorno, vbMonday) + 1, Giorno)
                UltimoGiornoSettimana = PrimoLunedi.AddDays(6)
            Case "per dipendente settimanale"
                PrimoLunedi = DateAdd("d", -Weekday(Giorno, vbMonday) + 1, Giorno)
                UltimoGiornoSettimana = PrimoLunedi.AddDays(6)
                iddip = DG_giorno("C_iddip", DG_giorno.SelectedRows(0).Index).Value
                Using DT As New DS_ag.DTsostituzioniDataTable
                    Using TA As New DS_agTableAdapters.TAsostituzioni
                        TA.FillByDaAperDipendente(DT, PrimoLunedi, UltimoGiornoSettimana, iddip)
                        tmpDT = creaTabellaDipendenteSettimana(DT, PrimoLunedi, UltimoGiornoSettimana)
                    End Using
                End Using
            Case "per dipendente giornaliero"
                PrimoLunedi = Giorno
                UltimoGiornoSettimana = PrimoLunedi.AddDays(0)
                iddip = DG_giorno("C_iddip", DG_giorno.SelectedRows(0).Index).Value
            Case "giornaliero"
                PrimoLunedi = Giorno
                UltimoGiornoSettimana = PrimoLunedi.AddDays(0)
            Case "ferie giornaliero"
                PrimoLunedi = Giorno
                UltimoGiornoSettimana = PrimoLunedi.AddDays(0)
                iddip = DG_giorno("C_iddip", DG_giorno.SelectedRows(0).Index).Value
                Dim tipo As Integer = 2 ' Ferie
                Using DT As New DS_ag.DTsostituzioniDataTable
                    Using TA As New DS_agTableAdapters.TAsostituzioni
                        TA.FillByDaADipendenteTipo(DT, PrimoLunedi, UltimoGiornoSettimana, iddip, tipo)
                    End Using
                End Using
            Case "malattia giornaliero"
                PrimoLunedi = Giorno
                UltimoGiornoSettimana = PrimoLunedi.AddDays(0)
                iddip = DG_giorno("C_iddip", DG_giorno.SelectedRows(0).Index).Value
                Dim tipo As Integer = 1 'Malattia
                Using DT As New DS_ag.DTsostituzioniDataTable
                    Using TA As New DS_agTableAdapters.TAsostituzioni
                        TA.FillByDaADipendenteTipo(DT, PrimoLunedi, UltimoGiornoSettimana, iddip, tipo)
                    End Using
                End Using
            Case "ferie settimanale"
                PrimoLunedi = DateAdd("d", -Weekday(Giorno, vbMonday) + 1, Giorno)
                UltimoGiornoSettimana = PrimoLunedi.AddDays(6)
                Dim tipo As Integer = 1 'Malattia
                Using DT As New DS_ag.DTsostituzioniDataTable
                    Using TA As New DS_agTableAdapters.TAsostituzioni
                        TA.FillByDaADipendenteTipo(DT, PrimoLunedi, UltimoGiornoSettimana, iddip, tipo)
                    End Using
                End Using

            Case "malattia settimanale"
                PrimoLunedi = DateAdd("d", -Weekday(Giorno, vbMonday) + 1, Giorno)
                iddip = DG_giorno("C_iddip", DG_giorno.SelectedRows(0).Index).Value
                UltimoGiornoSettimana = PrimoLunedi.AddDays(6)
                Dim tipo As Integer = 1 'Malattia
                Using DT As New DS_ag.DTsostituzioniDataTable
                    Using TA As New DS_agTableAdapters.TAsostituzioni
                        TA.FillByDaADipendenteTipo(DT, PrimoLunedi, UltimoGiornoSettimana, iddip, tipo)
                    End Using
                End Using
        End Select


        Dim f As New FRMSTPagendaSettimanale(PrimoLunedi, UltimoGiornoSettimana, iddip, tmpDT)
        f.ShowDialog()
    End Sub

    Private Sub MacchinariToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MacchinariToolStripMenuItem.Click
        Dim f As New FRMmacchinari
        f.Show()
        TX_avvio.Text = "Benvenuto " & GlobalVarPOP.G_nomeutente
        TX_avvio.BackColor = Color.White

    End Sub

    Private Sub LLapreordiniremoti(sender As Object, e As EventArgs) Handles LL_ordiniweb.Click
        Dim F As New FRMOrdiniWeb
        F.Show()
        TX_avvio.Text = "Benvenuto " & GlobalVarPOP.G_nomeutente
        TX_avvio.BackColor = Color.White

    End Sub
    Private Shared Function creaTabellaDipendenteSettimana(ByVal _dt As DataTable, ByVal inizioS As Date, ByVal fineS As Date, Optional tipo As Integer = Nothing) As DataTable
        Dim DT As New DataTable
        DT = _dt.Clone
        Dim tInizio As New TimeSpan(6, 0, 0)
        Dim tFine As New TimeSpan(22, 0, 0)
        Dim tStep As New TimeSpan(0, 30, 0)
        Dim nRG As DataRow
        Dim idtipo As Integer = tipo


        Dim groupingresso = From ingressi In _dt
                            Order By ingressi.Item("ing")
                            Group ingressi By Key = ingressi.Item("ing").ToString() Into g = Group

        Dim listaingressi(groupingresso.Count - 1) As String
        Dim xx As Int16 = 0
        For Each tt In groupingresso
            listaingressi(xx) = tt.g(0).Item("ing").ToString()
            xx += 1
        Next

        For dd As Integer = inizioS.Day To fineS.Day    'inizia a contare il primo giorno
            Dim dConfronto As Date
            dConfronto = New DateTime(inizioS.Year, inizioS.Month, dd)
            For Each hh In listaingressi
                Dim tempo As TimeSpan = TimeSpan.Parse(hh)
                nRG = DT.NewRow()
                'Dim ora As Integer = CInt(hh)
                'Dim Minuti As Integer = (hh - ora) * 60
                nRG.Item("ing") = tempo
                nRG.Item("data") = dConfronto
                nRG.Item("usc") = TimeSpan.Parse("00:00")
                nRG.Item("idcli") = 0
                nRG.Item("iddes") = 0
                nRG.Item("iddip") = 0
                nRG.Item("idsost") = 0
                nRG.Item("idtipo") = 0
                nRG.Item("anagrafica_S") = ""
                nRG.Item("anagrafica_A") = ""
                nRG.Item("societa") = ""
                nRG.Item("locazione") = ""
                For Each RR As DS_ag.DTsostituzioniRow In _dt.Rows
                    If RR.data = dConfronto Then
                        If IsNothing(idtipo) Or idtipo = 0 Then
                            If RR.ing.Hours = tempo.Hours And RR.ing.Minutes = tempo.Minutes Then
                                nRG.Item("ing") = RR.ing
                                nRG.Item("data") = RR.data
                                nRG.Item("usc") = RR.usc
                                nRG.Item("idcli") = RR.idcli
                                nRG.Item("iddes") = RR.iddes
                                nRG.Item("iddip") = RR.iddip
                                nRG.Item("idsost") = RR.idsost
                                nRG.Item("idtipo") = RR.idtipo
                                nRG.Item("anagrafica_S") = RR.anagrafica_S
                                nRG.Item("anagrafica_A") = RR.anagrafica_A
                                nRG.Item("societa") = RR.societa
                                nRG.Item("locazione") = RR.locazione
                            End If
                        ElseIf RR.idtipo = idtipo Then
                            If RR.ing.Hours = tempo.Hours And RR.ing.Minutes = tempo.Minutes Then
                                nRG.Item("ing") = RR.ing
                                nRG.Item("data") = RR.data
                                nRG.Item("usc") = RR.usc
                                nRG.Item("idcli") = RR.idcli
                                nRG.Item("iddes") = RR.iddes
                                nRG.Item("iddip") = RR.iddip
                                nRG.Item("idsost") = RR.idsost
                                nRG.Item("idtipo") = RR.idtipo
                                nRG.Item("anagrafica_S") = RR.anagrafica_S
                                nRG.Item("anagrafica_A") = RR.anagrafica_A
                                nRG.Item("societa") = RR.societa
                                nRG.Item("locazione") = RR.locazione
                            End If
                        End If
                    End If
                Next
                DT.Rows.Add(nRG)
            Next
        Next
        Dim DW As DataView
        DW = DT.DefaultView
        DW.Sort = "data,ing"
        DT = DW.ToTable
        Return DT
    End Function

    Private Sub SettaggioVariabiliToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettaggioVariabiliToolStripMenuItem.Click
        Dim D As New FolderBrowserDialog
    End Sub

    Private Sub BT_agenda_Click(sender As Object, e As EventArgs) Handles BT_agenda.Click
        Try
            AggiornaAgenda()
        Catch ex As Exception

        End Try
        Dim G As New FrmAgenda
        G.Show()
        TX_avvio.Text = "Benvenuto " & GlobalVarPOP.G_nomeutente
        TX_avvio.BackColor = Color.White

    End Sub

    Private Sub cmbMese_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMese.SelectedIndexChanged, cmbAnno.SelectedIndexChanged
        GlobalVarPOP.GPeriodo = cmbAnno.SelectedItem & "-" & (cmbMese.SelectedIndex + 1).ToString.PadLeft(2, "0")
    End Sub


    Private Sub btFeriePresenti_Click(sender As Object, e As EventArgs) Handles btFeriePresenti.Click
        If btFeriePresenti.Text <> "" Then
            If GlobalVarPOP.gradoaccesso > 500 Then
                Dim tmp As New frmDipendentiFerie
                avvio_maschera(tmp)
            Else
                MsgBox("Non hai sufficienti diritti inserire le presenze")
            End If
        End If
    End Sub
    Private Function caricaAziendaProduttiva()

        Using ta As New DS_aziendaTableAdapters.TA_azienda
            Try
                ta.Fill(ValoriAzienda)
            Catch ex As Exception
                Dim err As DataRow() = ValoriAzienda.GetErrors
                For Each vv In err
                    Console.WriteLine(vv.RowError)
                Next
            End Try


            For Each rg As DS_azienda.DT_aziendaRow In ValoriAzienda.Rows
                If rg.autofatturazione <> 0 Then
                    rg.Delete()
                End If
            Next
        End Using
        Dim bn As BindingSource = New BindingSource
        bn.DataSource = ValoriAzienda


        'CBazienda.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", bn, "id_det", True))
        CBazienda.DataSource = bn
        CBazienda.DisplayMember = "ragione_sociale"
        CBazienda.ValueMember = "id"
        Return True
    End Function

    Private Sub CBazienda_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBazienda.SelectedIndexChanged
        Dim cb As ComboBox
        cb = DirectCast(sender, ComboBox)
        Dim ris As Integer
        Try
            ris = cb.SelectedValue
        Catch ex As Exception
            Return
        End Try
        GlobalVarPOP.G_idAZ = ris

    End Sub

End Class
