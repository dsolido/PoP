Imports System.ComponentModel

Public Class FrmAgendaModifica
    Dim G_AZ As Integer = 1
    Dim Gperiodo As String
    Dim tmpDTSos As DataTable
    Dim idRichiedente As Int16
    Dim Lista As String
    Public Fsostituito As Boolean       'ritorna se ha compiuto delle azioni
    Dim dtUtenti, dtClienti, dtLocazioni As DataTable

    Dim Orainizio As TimeSpan
    Dim OraFine As TimeSpan
    Dim GiornoInizio As DateTime
    Dim ClienteInizio As Int16
    Dim DettaglioInizio As Int16
    Dim DipendenteAssente As Int16
    Dim Sostituzione As Int16
    Dim Tipologia As Int16
    Dim BBS As BindingSource

    Dim TWi() As String = {"do_i", "lu_i", "ma_i", "me_i", "gi_i", "ve_i", "sa_i"}
    Dim TWf() As String = {"do_u", "lu_u", "ma_u", "me_u", "gi_u", "ve_u", "sa_u"}
    Dim DTsos As New DS_ag.DTsostituzioniDataTable



    Public Sub New(ByRef BS As BindingSource, ByRef kList As String, Optional GiornoIniziale As DateTime = Nothing, Optional OraIniziale As TimeSpan = Nothing,
                   Optional dtUtentiT As DataTable = Nothing, Optional dtClientiT As DataTable = Nothing, Optional dtLocazioniT As DataTable = Nothing)

        ' La chiamata è richiesta dalla finestra di progettazione.


        InitializeComponent()

        BBS = New BindingSource
        BBS.DataMember = "DTsostituzioni"
        BBS = BS
        Orainizio = OraIniziale
        GiornoInizio = GiornoIniziale
        Dim GiornoFine As DateTime = GiornoIniziale

        'Tag += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", idDipRichiedente, dayDet.ing, dayDet.usc, idAss, idSos, idDet.idcli, idDet.iddet, If(dayDet.idrecupero = 0, -1, dayDet.idrecupero), dayDet.idtip)

        If IsNothing(kList) <> True Then
            Lista = kList
            Dim nTot As Int16
            nTot = Lista.Split("|").Count - 1

            For rr = 0 To nTot Step 10
                Dim bDini As Boolean = DateTime.TryParse(GiornoInizio & " " & Lista.Split("|").Skip(1).First, GiornoInizio)
                Dim bIng As Boolean = TimeSpan.TryParse(GiornoInizio.ToShortTimeString, Orainizio)
                Dim bDfin As Boolean = DateTime.TryParse(GiornoFine & " " & Lista.Split("|").Skip(2).First, GiornoFine)
                Dim bUsc As Boolean = TimeSpan.TryParse(GiornoFine.ToShortTimeString, OraFine)
                Dim bSos As Boolean = Integer.TryParse(Lista.Split("|").Skip(3).First, Sostituzione)
                Dim bDip As Boolean = Integer.TryParse(Lista.Split("|").Skip(4).First, DipendenteAssente)
                Dim bCli As Boolean = Integer.TryParse(Lista.Split("|").Skip(5).First, ClienteInizio)
                Dim bDet As Boolean = Integer.TryParse(Lista.Split("|").Skip(6).First, DettaglioInizio)
                Dim bTip As Boolean = Integer.TryParse(Lista.Split("|").Skip(8).First, Tipologia)
                If rr >= nTot Then
                    Exit For
                End If
                idRichiedente = Integer.Parse(Lista.Split("|").Skip(7 + rr).First)
            Next

            'BBS.Position = BBS.Find("id", idRichiedente)
            BBS.Filter = String.Format("id={0}", idRichiedente)
        End If
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
        'ckDefinitivo.Checked = True
        'AddHandler ckDefinitivo.CheckedChanged, AddressOf ckDefinitivo_ChangeChecked
        dtUtenti = dtUtentiT
        dtClienti = dtClientiT
        dtLocazioni = dtLocazioniT
    End Sub
    Private Sub FRM_MOD_agenda_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        completapulsanti()
        AddHandler BS_a.CurrentChanged, AddressOf aggiornaRighe
        CaricaLista(Lista)

        Me.TA_orari.FillByOrari(Me.DS_agenda.DT_orari)
        Dim G_periodo As String
        If IsNothing(GiornoInizio) Then
            G_periodo = GlobalVarPOP.GPeriodo
        Else
            G_periodo = GiornoInizio.Year.ToString.PadLeft(4) & "-" & GiornoInizio.Month.ToString.PadLeft(2, "0")
        End If
        Dim B_stato As Integer = 1
        Me.TaTipo.FillByAttiviDipendenti(Me.DS_agenda.dtTipo)

        Me.TA_utenti.FillByAttivi(Me.DS_agenda.DT_utenti, B_stato, G_AZ)
        'End If
        If Not IsNothing(dtLocazioni) Then
            For Each rg In dtLocazioni.Rows
                Dim rgn As DataRow
                rgn = Me.DS_agenda.DT_locazioni.NewRow
                rgn("id") = rg.id
                rgn("locazione") = rg.locazione
                rgn("id_terminale") = rg.id_terminale
                Me.DS_agenda.DT_locazioni.Rows.Add(rgn)
                rgn.AcceptChanges()
            Next
        Else
            Me.TA_locazioni.Fill(Me.DS_agenda.DT_locazioni)
        End If


        If Not IsNothing(dtClienti) Then
            For Each rg In dtClienti.Rows
                Dim rgn As DataRow
                rgn = Me.DS_agenda.DT_clienti.NewRow
                rgn("id") = rg.id
                rgn("societa") = rg.societa
                Me.DS_agenda.DT_clienti.Rows.Add(rgn)
                rgn.AcceptChanges()
            Next
        Else
            Me.TA_clienti.FillByAttivi(Me.DS_agenda.DT_clienti, B_stato, G_AZ)
        End If

        'assegna il binding dell'Agenda
        BS_a.DataSource = BBS.DataSource

        BS_a.Filter = BBS.Filter
        compilailform()

#If DEBUG Then
        For Each gg In BS_a
            Console.WriteLine(gg.item("societa") & " " & gg.item("id"))
        Next
#End If



    End Sub
    Private Sub aggiornaRighe()
        Dim RGa As DS_ag.DTsostituzioniRow
        RGa = DirectCast(BS_a.Current, DataRowView).Row
        If RGa.idtipo = 99 Or RGa.idtipo = 10 Then
            CB_utenteB.Visible = Not ckDefinitivo.Checked
            TXricercasostituto.Visible = Not ckDefinitivo.Checked
            lbSostituto.Text = "NON SOSTITUITO"
            ckDefinitivo.Checked = True
            ckDefinitivo.ImageIndex = If(ckDefinitivo.Checked = True, 1, 0)
        End If
    End Sub
    Private Sub compilailform()
        Dim RGa As DS_ag.DTsostituzioniRow

        If BS_a.Count = 0 Then
            BS_a.AddNew()
            RGa = DirectCast(BS_a.Current, DataRowView).Row
            RGa.ing = New TimeSpan(Orainizio.Hours, Orainizio.Minutes, 0)
            RGa.usc = New TimeSpan(OraFine.Hours, OraFine.Minutes, 0)
            RGa.data = GiornoInizio
            RGa.iddes = DettaglioInizio
            RGa.idcli = ClienteInizio
            RGa.idsost = DipendenteAssente
            RGa.idtipo = Tipologia
            BS_a.EndEdit()
        Else
            RGa = DirectCast(BS_a.Current, DataRowView).Row
            If RGa.id > 0 And Not ckDefinitivo.Checked Then
                Return
            End If

            RGa.ing = New TimeSpan(Orainizio.Hours, Orainizio.Minutes, 0)
            RGa.usc = New TimeSpan(OraFine.Hours, OraFine.Minutes, 0)
            RGa.data = GiornoInizio
            RGa.iddes = DettaglioInizio
            RGa.idcli = ClienteInizio
            RGa.idsost = DipendenteAssente
            If Not IsNothing(Sostituzione) Then
                RGa.iddip = Sostituzione
                RGa.idtipo = Tipologia
            Else
                RGa.idtipo = 99
            End If
            BS_a.EndEdit()
        End If
    End Sub

    Private Function completapulsanti()
        Dim x, y As Int16
        x = 40
        y = 40
        Dim callback As Image.GetThumbnailImageAbort = Nothing
        TT_inizio.Image = Comuni.My.Resources.sxsxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        TT_prima.Image = Comuni.My.Resources.sxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        TT_dopo.Image = Comuni.My.Resources.dxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        TT_ultimo.Image = Comuni.My.Resources.dxdxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        TT_salva.Image = Comuni.My.Resources.memorizzaDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        TT_elimina.Image = Comuni.My.Resources.obbiettiviDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        TT_aggiunge.Image = Comuni.My.Resources.aggiungiDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        TTBTtermina.Image = Comuni.My.Resources.spegniDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        btElaboratantigiorni.Image = Comuni.My.Resources.impostazioniDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        btMemorizzaDati.Image = Comuni.My.Resources.memorizzaDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        Return True
    End Function
    Private Shared Function CaricaLista(ByRef lista As String) As Boolean
        If lista = Nothing Then
            Return False
        End If
        Return True
    End Function

    Private Function CreaTabellaTemporaneaSostituzioni() As DataTable
        tmpDTSos = New DataTable("tmpSostituzioni")

        Dim column1 As DataColumn

        column1 = New DataColumn("ing")
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("usc")
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("dd")
        column1.DataType = System.Type.GetType("System.DateTime")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("ad")
        column1.DataType = System.Type.GetType("System.DateTime")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idsos")
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("iddip")
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idcli")
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("iddet")
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idyn")       'Se è stata sostituita o no
        column1.DataType = System.Type.GetType("System.Boolean")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idn")         'in caso sia già una sostituzione
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idtipo")         'in caso sia già una sostituzione
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("note")
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("dettaglio")   'Dettaglio Cantiere
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)


        column1 = New DataColumn("sostituto")   'Dettaglio Cantiere
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idpass")   'Dettaglio Cantiere
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        Return tmpDTSos
    End Function
    Private Sub TerminaForm() Handles MyBase.FormClosing
        BS_a.CancelEdit()
    End Sub
    Private Function controlloCoerenza() As Boolean
        Select Case True
            Case IsNothing(CB_utenteA.SelectedValue)
                'Return False
            Case IsNothing(CB_utenteB.SelectedValue)
                If CB_tipo.SelectedValue = 99 Then
                    Return True
                End If
                Return False
            Case IsNothing(CB_locazioni.SelectedValue)
                Return False
            Case CB_utenteA.SelectedValue.ToString().Length() = 0
                'Return False
            Case CB_utenteB.SelectedValue.ToString().Length = 0
                Return False
            Case CB_locazioni.SelectedValue.ToString().Length = 0
                Return False
        End Select
        Return True
    End Function
    Private Sub TT_Salva_Click(sender As Object, e As EventArgs) Handles TT_salva.Click
        'Dim oldFiltro As String = BS_a.Filter
        '        Dim i = DG_orari.RowCount
        If Not controlloCoerenza() Then
            Return
        End If
        If DG_orari.SelectedRows.Count > 1 Then
            For Each RR As DataGridViewRow In DG_orari.SelectedRows
                Dim DTsos As New DS_ag.DTsostituzioniDataTable
                Dim DTrgn As DS_ag.DTsostituzioniRow
                DTrgn = DTsos.NewRow

                Dim RGorari As DS_ag.DT_orariRow
                bsOrario.Position = bsOrario.Find("id", RR.Cells(0).Value)
                RGorari = DirectCast(bsOrario.Current, DataRowView).Row
                Dim Data As DateTime = DT_dallaData.Value
                DTrgn.data = Data
                'RGsos.data = Data
                Dim NSettimana As Integer = Data.DayOfWeek
                Dim ValoreI As New TimeSpan
                Dim ValoreF As New TimeSpan
                ValoreI = CType(TimeSpan.Parse(RGorari.Item(TWi(NSettimana))), TimeSpan)
                ValoreF = CType(TimeSpan.Parse(RGorari.Item(TWf(NSettimana))), TimeSpan)
                DTrgn.ing = ValoreI
                DTrgn.usc = ValoreF
                DTrgn.idcli = RGorari.Item("id_cli")
                DTrgn.iddes = RGorari.Item("id_des")
                DTrgn.idsost = IIf(CB_utenteA.SelectedValue = Nothing, 0, CB_utenteA.SelectedValue)
                DTrgn.iddip = CB_utenteB.SelectedValue
                DTrgn.note = NoteTextBox.Text
                If CB_tipo.SelectedValue > 0 Then
                    DTrgn.idtipo = CB_tipo.SelectedValue
                Else
                    MsgBox("Attenzione non hai specificato il tipo di sostituzione")
                    Return
                End If

                DTrgn.idraggruppamento = TAsostituzioni.SQnuovoID()
                'DTrgn.idconferma = ckDefinitivo.Checked
                DTsos.Rows.Add(DTrgn)
                Dim tmpIDconferma As Int16
                If DTrgn.IsidconfermaNull Then
                    tmpIDconferma = 1
                Else
                    tmpIDconferma = DTrgn.idconferma
                End If

                TAsostituzioni.QRinserisce(DTrgn.iddip, DTrgn.iddes, DTrgn.data,
                    DTrgn.note, DTrgn.ing.ToString(), DTrgn.usc.ToString(),
                    IIf(DTrgn.IsidsostNull, Nothing, DTrgn.idsost), DTrgn.idcli, If(DTrgn.IsidpassaggiNull, 0, DTrgn.idpassaggi),
                    DTrgn.idtipo, DTrgn.idraggruppamento, tmpIDconferma)
                DTrgn.AcceptChanges()
            Next
            'se hai usato il moltiplicatore termina il salvataggio
            Me.Close()
            Return
        End If
        BS_a.EndEdit()


        Dim RG As DS_ag.DTsostituzioniRow
        Dim risp As String

        For Each _rg As DataRowView In BS_a
            RG = DirectCast(_rg, DataRowView).Row
            Select Case RG.RowState
                Case DataRowState.Added
                    risp = Controllo(RG)
                    If risp <> "" Then
                        MsgBox(risp)
                    Else
                        RG.idraggruppamento = TAsostituzioni.SQnuovoID()
                        Dim idsos As Int16
                        idsos = IIf(RG.IsidsostNull, 0, RG.idsost)
                        If RG.idtipo = 0 Then
                            MsgBox("Attenzione non hai specificato il tipo di sostituzione")
                            Return
                        End If
                        Dim tmpIDconferma As Int16
                        If RG.IsidconfermaNull Then
                            tmpIDconferma = 1
                        Else
                            tmpIDconferma = RG.idconferma
                        End If

                        TAsostituzioni.QRinserisce(RG.iddip, RG.iddes, RG.data, RG.note, RG.ing.ToString(), RG.usc.ToString(), idsos,
                                                   RG.idcli, IIf(RG.IsidpassaggiNull, 0, RG.idpassaggi), RG.idtipo, RG.idraggruppamento, tmpIDconferma)
                        RG.AcceptChanges()
                    End If
                Case DataRowState.Modified
                    risp = Controllo(RG)
                    If risp <> "" Then
                        MsgBox(risp)
                    Else
                        TAsostituzioni.QRmodifica(RG.iddip, RG.iddes, RG.data, RG.note, RG.ing.ToString(), RG.usc.ToString(), IIf(RG.IsidsostNull, 0, RG.idsost),
                                                    RG.idcli, If(RG.IsidpassaggiNull, 0, RG.idpassaggi), RG.idtipo, If(RG.IsidraggruppamentoNull, Nothing, RG.idraggruppamento), RG.idconferma, RG.id)
                        RG.AcceptChanges()
                    End If
                Case Else
                    Console.WriteLine(RG.id)
            End Select

        Next

        Me.Close()

    End Sub
    Private Function Controllo(ByRef _RG As DataRow) As String
        Dim RG As DS_ag.DTsostituzioniRow
        RG = _RG
        'controlla se è premuto il check allora annulla il codice dipendente sostituito

        If RG.IsiddipNull Then
            Return "Nessuna Sostituzione"
        End If
        If RG.IsidcliNull Then
            Return "Cliente non presente"
        End If
        If RG.IsidsostNull And RG.idtipo <> 10 Then
            Return "Utente non Presente"
        End If
        If RG.IsidsostNull Then
            RG.idsost = 0
        End If
        If RG.IsiddesNull Then
            Return "Locazione non presente"
        End If
        If RG.IsidtipoNull Then
            RG.idtipo = 1
        End If
        If RG.IsnoteNull Then
            RG.note = ""
        End If
        If RG.IsingNull Then
            Return "Inizia"
        End If
        If RG.IsuscNull Then
            Return "Termina"
        End If
        If RG.IsidpassaggiNull Then
            RG.idpassaggi = 0
        End If

        Return ""
    End Function

    Private Sub TT_elimina_Click(sender As Object, e As EventArgs) Handles TT_elimina.Click

        If Not controlloCoerenza() Then
            Return
        End If

        Dim Risp As MsgBoxResult = MsgBox("Elimino la sostituzione ?", MsgBoxStyle.YesNo)
        If Risp = MsgBoxResult.Yes Then
            Dim RGa As DS_ag.DTsostituzioniRow
            RGa = DirectCast(BS_a.Current, DataRowView).Row
            Dim r As Integer = TAsostituzioni.QRelimina(RGa.id)
            RGa.AcceptChanges()
        End If
        Me.Close()
    End Sub

    'Private Sub CK_nosostituito_CheckedChanged(sender As Object, e As EventArgs) Handles CK_nosostituito.CheckedChanged
    '    If IsNothing(CB_utenteB.SelectedValue) Then
    '        Return
    '    End If
    '    CK_nosostituito.ImageIndex = If(CK_nosostituito.Checked = True, 1, 0)
    '    CK_nosostituito.Text = If(CK_nosostituito.Checked = True, "Non Sostituito", "Sostituito")
    '    CK_nosostituito.TextAlign = If(CK_nosostituito.Checked = True, 16, 64)
    '    CB_utenteB.Visible = Not CK_nosostituito.Checked
    'End Sub
    Private Sub CB_utenteA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_utenteA.SelectedIndexChanged
        Dim TMP_CB As ListBox
        TMP_CB = DirectCast(sender, ListBox)
        If IsNothing(TMP_CB.SelectedValue) Then
            BS_relOrari.Filter = "id=-1"
            Return
        End If
        BS_relOrari.RemoveFilter()
        BS_relOrari.Filter = "id_dip = " & TMP_CB.SelectedValue
    End Sub

    Private Sub DG_orari_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_orari.CellClick
        Dim RGorari As DS_ag.DT_orariRow
        RGorari = DirectCast(BS_relOrari.Current, DataRowView).Row
        Dim Data As DateTime = DT_dallaData.Value
        Dim NSettimana As Integer = Data.DayOfWeek
        Dim ValoreI As New DateTime
        Dim ValoreF As New DateTime
        ValoreI = CType(Data.ToShortDateString & " " & RGorari.Item(TWi(NSettimana)), DateTime)
        ValoreF = CType(Data.ToShortDateString & " " & RGorari.Item(TWf(NSettimana)), DateTime)
        If ValoreI.Hour = 0 And ValoreI.Minute = 0 Then
            MsgBox("Non puoi assegnare questo lavoro oggi, non è previsto")
            Return
        End If
        Ora_iDateTimePicker.Value = ValoreI
        Ora_fDateTimePicker.Value = ValoreF
        CB_clienti.SelectedIndex = CB_clienti.FindStringExact(RGorari.societa)
        CB_locazioni.SelectedIndex = CB_locazioni.FindStringExact(RGorari.locazione)
        'CB_tipo.SelectedIndex = 6
    End Sub

    Private Sub DT_dallaData_ValueChanged(sender As Object, e As EventArgs) Handles DT_dallaData.ValueChanged
        Dim Data As DateTime = DT_dallaData.Value
        Dim NSettimana As Integer = Data.DayOfWeek
        NSettimana = If(NSettimana = 0, 7, NSettimana)
        Dim COL As DataGridViewColumn
        DT_allaData.Value = DT_allaData.Value
        For Each COL In DG_orari.Columns

            If COL.Index > 2 Then
                If COL.Index - 2 = NSettimana Then
                    COL.Visible = True
                Else
                    COL.Visible = False
                End If
            End If
        Next
    End Sub

    Private Sub customersBindingSource_ListChanged(ByVal sender As Object, ByVal e As ListChangedEventArgs) Handles BS_a.ListChanged
        Console.WriteLine(e.ListChangedType.ToString())
    End Sub

    Private Sub CB_utenteB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_utenteB.SelectedIndexChanged
        ' TODO deve eseguire la scansione di tutto quello che fa e vedere se ha disponibilità
        Dim tmpRiga As DataRowView
        tmpRiga = DirectCast(CB_utenteB.SelectedItem, DataRowView)
        If IsNothing(tmpRiga) Then
            GRorarisostituto.Visible = False
            Return
        Else
            GRorarisostituto.Visible = True
        End If
        GRorarisostituto.Text = "Visualizza impegno di " & tmpRiga.Row.Field(Of String)("anagrafica")
        Dim DTsos As New DS_ag.DTsostituzioniDataTable
        Dim DTora As New DS_ag.DT_orariDataTable
        Dim dDa As DateTime = DT_dallaData.Value
        Using TAsos As New DS_agTableAdapters.TAsostituzioni
            TAsos.FillByDaAperDipendente(DTsos, dDa, dDa, tmpRiga.Row.Field(Of Int32)("id"))
        End Using

        Dim xx As Int16 = 0
        DGorarisostituto.Rows.Clear()
        Dim tmpSostituzione As DataTable = New DataTable
        tmpSostituzione = DTsos.Clone

        For Each RR As DS_ag.DTsostituzioniRow In DTsos.Rows
            Dim ingresso As String = TempoStringaCorta(RR.ing)
            Dim tipo As Int16 = RR.idtipo

            If ingresso = "00:00" Or tipo = 10 Then
                Dim aTMPOrario As DS_ag.DTsostituzioniRow
                aTMPOrario = tmpSostituzione.NewRow
                aTMPOrario.data = RR.data
                aTMPOrario.ing = RR.ing
                aTMPOrario.usc = RR.usc
                aTMPOrario.iddes = RR.iddes
                tmpSostituzione.Rows.Add(aTMPOrario)
                tmpSostituzione.AcceptChanges()
                Continue For
            End If
            DGorarisostituto.Rows.Add()
            DGorarisostituto(colCantiere.Index, xx).Value = RR.locazione
            DGorarisostituto(colInizio.Index, xx).Value = ingresso
            DGorarisostituto(colFine.Index, xx).Value = TempoStringaCorta(RR.usc)
            DGorarisostituto(colTipo.Index, xx).Value = "SOS"
            xx += 1
        Next
        Using TAora As New DS_agTableAdapters.TA_orari
            TAora.FillByDipendente(DTora, tmpRiga.Row.Field(Of Int32)("id"))
        End Using
        Dim NSettimana As Integer = dDa.DayOfWeek
        For Each RR As DS_ag.DT_orariRow In DTora
            Dim ingresso As String = RR.Field(Of String)(TWi(NSettimana))
            If ingresso = "00:00:00" Then
                Continue For
            End If
            Dim uscita As String = RR.Field(Of String)(TWf(NSettimana))
            DGorarisostituto.Rows.Add()
            DGorarisostituto(colCantiere.Index, xx).Value = RR.locazione
            DGorarisostituto(colInizio.Index, xx).Value = ingresso.Substring(0, 5)
            DGorarisostituto(colFine.Index, xx).Value = uscita.Substring(0, 5)
            DGorarisostituto(colTipo.Index, xx).Value = "ORD"


            For Each rt As DS_ag.DTsostituzioniRow In tmpSostituzione.Rows
                Dim tmpIng As String = TempoStringaCorta(rt.ing) & ":00"
                If tmpIng = ingresso And rt.iddes = RR.id_des Then
                    DGorarisostituto.Rows.RemoveAt(xx)
                    xx -= 1
                End If
            Next
            xx += 1
        Next
        'If CB_utenteB.SelectedValue <> 0 Then
        '    ckDefinitivo.Checked = 1
        'End If
        DGorarisostituto.Sort(DGorarisostituto.Columns(colInizio.Index), ListSortDirection.Ascending)

    End Sub
    Private Sub btElaboratantigiorni_MousEnter(sender As Object, e As EventArgs) Handles btElaboratantigiorni.MouseEnter
        Dim x, y As Int16
        x = 50
        y = 55
        Dim btn As Button
        Dim img As Image = Nothing
        Dim callback As Image.GetThumbnailImageAbort = Nothing

        btn = DirectCast(sender, Button)
        Select Case btn.Name
            Case btElaboratantigiorni.Name
                img = Comuni.My.Resources.impostazioniDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case btMemorizzaDati.Name
                img = Comuni.My.Resources.memorizzaDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        End Select
        btn.Image = Nothing
        btn.Image = img

    End Sub

    Private Sub btElaboratantigiorni_MouseLeave(sender As Object, e As EventArgs) Handles btElaboratantigiorni.MouseLeave
        Dim x, y As Int16
        x = 40
        y = 40
        Dim btn As Button
        Dim img As Image = Nothing
        Dim callback As Image.GetThumbnailImageAbort = Nothing

        btn = DirectCast(sender, Button)
        Select Case btn.Name
            Case btElaboratantigiorni.Name
                img = Comuni.My.Resources.impostazioniDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case btMemorizzaDati.Name
                img = Comuni.My.Resources.memorizzaDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        End Select
        btn.Image = Nothing
        btn.Image = img

    End Sub

    Private Sub btElaboratantigiorni_Click(sender As Object, e As EventArgs) Handles btElaboratantigiorni.Click
        If Not controlloCoerenza() Then
            Return
        End If

        Dim o_iddip As Integer = CB_utenteA.SelectedValue        'Dipendente che sostituisce
        Dim o_idsos As Integer = CB_utenteB.SelectedValue   'Dipendente Assente o da sostituire
        Dim o_id_cli As Integer = CB_clienti.SelectedValue
        Dim o_id_des As Integer = CB_locazioni.SelectedValue
        Dim o_id_tipo As Integer = CB_tipo.SelectedValue
        Dim o_idconferma As Integer = ckDefinitivo.Checked
        Dim o_ora_i As DateTime
        Dim o_ora_f As DateTime
        Dim o_note As String = NoteTextBox.Text
        Dim DataValutata As DateTime
        Dim giorni As Int16 = DateDiff(DateInterval.Day, DT_dallaData.Value, DT_allaData.Value)
        Dim datapartenza As DateTime = DT_dallaData.Value
        '    'Valuta i giorni fino a che deve inserire l'evento
        Dim RGorari As DS_ag.DT_orariRow

        BS_relOrari.Filter = "id_dip = " & CB_utenteA.SelectedValue & " AND id_des = " & CB_locazioni.SelectedValue
        If BS_relOrari.Count <= 0 Then
            MsgBox("Nessun requisito soddisfa la richiesta")
            Return
        End If
        RGorari = DirectCast(BS_relOrari.Current, DataRowView).Row
        LWperiodo.Columns.Clear()
        LWperiodo.Items.Clear()

        LWperiodo.View = View.Details
        LWperiodo.CheckBoxes = True
        LWperiodo.GridLines = True
        LWperiodo.FullRowSelect = True
        LWperiodo.LabelEdit = True

        Dim columnHeader0 As New ColumnHeader()
        columnHeader0.Text = "Data"
        columnHeader0.Width = 100
        Dim columnHeader1 As New ColumnHeader()
        columnHeader1.Text = "Inizio"
        columnHeader1.Width = 100

        Dim columnHeader2 As New ColumnHeader()
        columnHeader2.Text = "Fine"
        columnHeader2.Width = 100
        Dim columnHeader3 As New ColumnHeader()
        columnHeader3.Text = "idCli"
        columnHeader3.Width = 0
        Dim columnHeader4 As New ColumnHeader()
        columnHeader4.Text = "idDes"
        columnHeader4.Width = 0
        Dim columnHeader5 As New ColumnHeader()
        columnHeader5.Text = "idTipo"
        columnHeader5.Width = 0
        Dim columnHeader6 As New ColumnHeader()
        columnHeader6.Text = "note"
        columnHeader6.Width = 80
        Dim columnHeader7 As New ColumnHeader()
        columnHeader7.Text = "idDip"
        columnHeader7.Width = 0
        Dim columnHeader8 As New ColumnHeader()
        columnHeader8.Text = "idSos"
        columnHeader8.Width = 0
        Dim columnHeader9 As New ColumnHeader()
        columnHeader9.Text = "idconferma"
        columnHeader9.Width = 0

        Dim columnHeader10 As New ColumnHeader()
        columnHeader10.Text = "id"
        columnHeader10.Width = 0
        ' Add the column headers to myListView.
        LWperiodo.Columns.AddRange(New ColumnHeader() {columnHeader0, columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9, columnHeader10})


        'LWperiodo.Groups.Add("item1", "Cliente")
        For i = 0 To giorni
            DataValutata = datapartenza.AddDays(i).ToShortDateString
            Dim NSettimana As Integer = DataValutata.DayOfWeek

            o_ora_i = CType(DataValutata.ToShortDateString & " " & RGorari.Item(TWi(NSettimana)), DateTime)
            o_ora_f = CType(DataValutata.ToShortDateString & " " & RGorari.Item(TWf(NSettimana)), DateTime)

            If o_ora_i.Hour = 0 And o_ora_i.Minute = 0 Then
                'MsgBox("Non puoi assegnare questo lavoro il giorno " & giorni.ToString & ", non è previsto")
                Continue For
            End If
            '
            ' Toglie l'orario di controllo e 
            ' Imposta l'orario che gli è stato assegnato
            '
            o_ora_i = CType(DataValutata.ToShortDateString & " " & Ora_iDateTimePicker.Value.ToShortTimeString, DateTime)
            o_ora_f = CType(DataValutata.ToShortDateString & " " & Ora_fDateTimePicker.Value.ToShortTimeString, DateTime)

            Using DTtmp As New DS_ag.DTsostituzioniDataTable
                Using TAsos As New DS_agTableAdapters.TAsostituzioni
                    TAsos.FillByRicercaPresenza(DTtmp, o_id_des, o_iddip, DataValutata)
                End Using
                For Each ttt As DS_ag.DTsostituzioniRow In DTtmp.Rows
                    If TimeValue(ttt.ing.ToString) = TimeValue(o_ora_i) Then
                        If MsgBox("Già Presente, vuoi modificarla ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            Dim riga As New ListViewItem(DataValutata.ToShortDateString.ToString(), 30)
                            riga.Checked = True
                            riga.SubItems.Add(o_ora_i.ToShortTimeString)
                            riga.SubItems.Add(o_ora_f.ToShortTimeString)
                            riga.SubItems.Add(o_id_cli)
                            riga.SubItems.Add(o_id_des)
                            riga.SubItems.Add(o_id_tipo)
                            riga.SubItems.Add(o_note)
                            riga.SubItems.Add(o_idsos)
                            riga.SubItems.Add(o_iddip)
                            riga.SubItems.Add(o_idconferma)
                            riga.SubItems.Add(ttt.id)
                            LWperiodo.Items.AddRange(New ListViewItem() {riga})
                        End If
                    Else
                        Dim riga As New ListViewItem(DataValutata.ToShortDateString.ToString(), 30)
                        riga.Checked = True
                        riga.SubItems.Add(o_ora_i.ToShortTimeString)
                        riga.SubItems.Add(o_ora_f.ToShortTimeString)
                        riga.SubItems.Add(o_id_cli)
                        riga.SubItems.Add(o_id_des)
                        riga.SubItems.Add(o_id_tipo)
                        riga.SubItems.Add(o_note)
                        riga.SubItems.Add(o_idsos)
                        riga.SubItems.Add(o_iddip)
                        riga.SubItems.Add(o_idconferma)
                        riga.SubItems.Add(-1)
                        LWperiodo.Items.AddRange(New ListViewItem() {riga})
                    End If
                Next

                If DTtmp.Count = 0 Then
                    Dim riga As New ListViewItem(DataValutata.ToShortDateString.ToString(), 30)
                    riga.Checked = True
                    riga.SubItems.Add(o_ora_i.ToShortTimeString)
                    riga.SubItems.Add(o_ora_f.ToShortTimeString)
                    riga.SubItems.Add(o_id_cli)
                    riga.SubItems.Add(o_id_des)
                    riga.SubItems.Add(o_id_tipo)
                    riga.SubItems.Add(o_note)
                    riga.SubItems.Add(o_idsos)
                    riga.SubItems.Add(o_iddip)
                    riga.SubItems.Add(-1)
                    LWperiodo.Items.AddRange(New ListViewItem() {riga})
                End If
            End Using
        Next

    End Sub
    Private Sub MemorizzaSostituzionePiuGiorni()
        If Not controlloCoerenza() Then
            Return
        End If
        Using DT As New DS_ag.DTsostituzioniDataTable
            Dim idraggruppamento = TAsostituzioni.SQnuovoID()
            For Each lista As ListViewItem In LWperiodo.Items
                Dim ttt As DS_ag.DTsostituzioniRow
                Dim id As Integer = lista.SubItems(9).Text
                Dim check As Boolean = lista.Checked
                ttt = DT.NewDTsostituzioniRow
                If id > 0 And check Then
                    ttt.data = lista.SubItems(0).Text
                    ttt.ing = TimeSpan.Parse(lista.SubItems(1).Text)
                    ttt.usc = TimeSpan.Parse(lista.SubItems(2).Text)
                    ttt.idcli = lista.SubItems(3).Text
                    ttt.iddes = lista.SubItems(4).Text
                    ttt.idtipo = lista.SubItems(5).Text

                    ttt.note = lista.SubItems(6).Text
                    ttt.idsost = lista.SubItems(7).Text
                    ttt.iddip = lista.SubItems(8).Text
                    ttt.idconferma = lista.SubItems(9).Text

                    TAsostituzioni.QRmodifica(IIf(ttt.IsidsostNull, Nothing, ttt.idsost), ttt.iddes, ttt.data, ttt.note, ttt.ing.ToString(), ttt.usc.ToString(), ttt.iddip, ttt.idcli, If(ttt.IsidpassaggiNull, 0, ttt.idpassaggi), ttt.idtipo, ttt.idraggruppamento, ttt.idconferma, id)
                ElseIf check Then
                    ttt.data = lista.SubItems(0).Text
                    ttt.ing = TimeSpan.Parse(lista.SubItems(1).Text)
                    ttt.usc = TimeSpan.Parse(lista.SubItems(2).Text)
                    ttt.idcli = lista.SubItems(3).Text
                    ttt.iddes = lista.SubItems(4).Text
                    ttt.idtipo = lista.SubItems(5).Text
                    If ttt.idtipo = 0 Then
                        MsgBox("Non hai specificato il Tipo")
                        Return
                    End If
                    ttt.note = lista.SubItems(6).Text
                    ttt.idsost = lista.SubItems(7).Text
                    ttt.iddip = lista.SubItems(8).Text
                    ttt.idconferma = lista.SubItems(9).Text
                    TAsostituzioni.QRinserisce(IIf(ttt.IsidsostNull, Nothing, ttt.idsost), ttt.iddes, ttt.data, ttt.note, ttt.ing.ToString(), ttt.usc.ToString(), ttt.iddip, ttt.idcli, If(ttt.IsidpassaggiNull, 0, ttt.idpassaggi), ttt.idtipo, idraggruppamento, ttt.idconferma)
                End If
            Next
        End Using
    End Sub

    Private Sub Termina_Click(sender As Object, e As EventArgs) Handles btMemorizzaDati.Click
        MemorizzaSostituzionePiuGiorni()
        Me.Close()
    End Sub

    Private Sub TXricercautente_TextChanged(sender As Object, e As EventArgs) Handles TXricercautente.TextChanged
        Dim tmpTXT As TextBox
        tmpTXT = DirectCast(sender, TextBox)
        Dim tmpBind As BindingSource
        tmpBind = BS_utentiA

        Do While True
            Dim ricerca As String
            ricerca = tmpTXT.Text
            tmpBind.Filter = String.Format("anagrafica LIKE '%{0}%'", ricerca)
            If tmpBind.Count > 0 Then
                Exit Do
            Else
                tmpTXT.Text = tmpTXT.Text.Substring(0, tmpTXT.Text.Length - 1)
                tmpTXT.SelectionStart = tmpTXT.Text.Length
            End If
        Loop
        CB_utenteA_SelectedIndexChanged(CB_utenteA, Nothing)
    End Sub
    Private Sub TXricercasostituto_TextChanged(sender As Object, e As EventArgs) Handles TXricercasostituto.TextChanged
        Dim tmpTXT As TextBox
        tmpTXT = DirectCast(sender, TextBox)
        Dim tmpBind As BindingSource
        tmpBind = BS_utentiB

        Do While True
            Dim ricerca As String
            ricerca = tmpTXT.Text
            tmpBind.Filter = String.Format("anagrafica LIKE '%{0}%'", ricerca)
            If tmpBind.Count > 0 Then
                Exit Do
            Else
                tmpTXT.Text = tmpTXT.Text.Substring(0, tmpTXT.Text.Length - 1)
                tmpTXT.SelectionStart = tmpTXT.Text.Length
            End If
        Loop
        CB_utenteB_SelectedIndexChanged(CB_utenteB, Nothing)
    End Sub

    Private Sub TTBTtermina_Click(sender As Object, e As EventArgs) Handles TTBTtermina.Click
        Me.Close()
    End Sub

    Private Sub TT_inizio_Enter(sender As Object, e As EventArgs) Handles TT_inizio.MouseEnter, TT_dopo.MouseEnter, TT_prima.MouseEnter, TT_ultimo.MouseEnter,
                TTBTtermina.MouseEnter, TT_aggiunge.MouseEnter, TT_elimina.MouseEnter, TT_salva.MouseEnter
        Dim x, y As Int16
        x = 50
        y = 55
        Dim btn As ToolStripButton
        Dim img As Image = Nothing
        Dim callback As Image.GetThumbnailImageAbort = Nothing
        btn = DirectCast(sender, ToolStripButton)
        Select Case btn.Name
            Case TT_inizio.Name
                img = Comuni.My.Resources.sxsxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_prima.Name
                img = Comuni.My.Resources.sxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_dopo.Name
                img = Comuni.My.Resources.dxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_ultimo.Name
                img = Comuni.My.Resources.dxdxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_salva.Name
                img = Comuni.My.Resources.memorizzaDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_elimina.Name
                img = Comuni.My.Resources.obbiettiviDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_aggiunge.Name
                img = Comuni.My.Resources.aggiungiDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TTBTtermina.Name
                img = Comuni.My.Resources.spegniDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        End Select
        btn.Image = Nothing
        btn.Image = img
        btn.ImageScaling = ToolStripItemImageScaling.None
    End Sub
    Private Sub TT_inizio_Leave(sender As Object, e As EventArgs) Handles TT_inizio.MouseLeave, TT_dopo.MouseLeave, TT_prima.MouseLeave, TT_ultimo.MouseLeave,
                                                                            TTBTtermina.MouseLeave, TT_aggiunge.MouseLeave, TT_elimina.MouseLeave, TT_salva.MouseLeave
        Dim x, y As Int16
        x = 40
        y = 40
        Dim btn As ToolStripButton
        Dim img As Image = Nothing
        Dim callback As Image.GetThumbnailImageAbort = Nothing

        btn = DirectCast(sender, ToolStripButton)
        Select Case btn.Name
            Case TT_inizio.Name
                img = Comuni.My.Resources.sxsxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_prima.Name
                img = Comuni.My.Resources.sxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_dopo.Name
                img = Comuni.My.Resources.dxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_ultimo.Name
                img = Comuni.My.Resources.dxdxpulsanteDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_salva.Name
                img = Comuni.My.Resources.memorizzaDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_elimina.Name
                img = Comuni.My.Resources.obbiettiviDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TT_aggiunge.Name
                img = Comuni.My.Resources.aggiungiDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
            Case TTBTtermina.Name
                img = Comuni.My.Resources.spegniDN.GetThumbnailImage(x, y, callback, IntPtr.Zero)
        End Select
        btn.Image = Nothing
        btn.Image = img
        btn.ImageScaling = ToolStripItemImageScaling.None
    End Sub


    Private Sub BT_alla_CheckedChanged(sender As Object, e As EventArgs) Handles BT_alla.CheckedChanged
        Dim consenso As Boolean = BT_alla.Checked
        DT_allaData.Visible = consenso
        btElaboratantigiorni.Visible = consenso
        btMemorizzaDati.Visible = consenso
        BN_navigazione.Visible = Not consenso
    End Sub
    Private Sub ckDefinitivo_Click(sender As Object, e As EventArgs) Handles ckDefinitivo.Click
        'ckDefinitivo.Checked = Not ckDefinitivo.Checked
        ckDefinitivo_ChangeChecked()
    End Sub
    Private Sub ckDefinitivo_ChangeChecked() '(sender As Object, e As EventArgs)
        ckDefinitivo.ImageIndex = If(ckDefinitivo.Checked = True, 1, 0)
        CB_utenteB.Visible = Not ckDefinitivo.Checked
        TXricercasostituto.Visible = Not ckDefinitivo.Checked

        'sostituto_label.Text = IIf(ckDefinitivo.Checked, "NON SOSTITUITO", "Sostituito")
        If ckDefinitivo.Checked Then
            compilailform()
            lbSostituto.Text = "NON SOSTITUITO"
        Else
            CB_tipo.SelectedIndex = 0
            lbSostituto.Text = "Sostituto"
        End If
    End Sub
End Class