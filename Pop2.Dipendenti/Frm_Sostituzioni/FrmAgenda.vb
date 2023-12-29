

Public Class FrmAgenda
    Dim G_tiposettimana As Integer = 2 ' 1 per settimana inizia con oggi 2 per settimana che inizia sempre con Lunedi'
    Dim G_mese As Integer = Now.Month
    Dim G_anno As String = Now.Year
    Dim G_periodo As String = G_anno & "-" & G_mese.ToString.PadLeft(2, "0")
    Dim G_settimana As String = DatePart(DateInterval.WeekOfYear, Today)
    Dim AGiorni() As String = {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
    Dim AGiorniL() As String = {"Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato", "Domenica"}
    Dim GiornoI As DateTime
    Dim GiornoF As DateTime
    Dim GiornoOra As DateTime = Now

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TAsostituzioni.FillByMese(Me.DS_agenda.DTsostituzioni, G_periodo)



        CaricaDatiAgenda() 'Popola l'agenda
        CaricaDatiGiorno()  'Popola la tabella dei dipendenti nella giornata selezionata

    End Sub
    Private Sub PopolaGiorniAgenda()
        Dim GTxt As String 'Testo indicativo del giorno della settimana
        Dim GS As Integer = GiornoOra.DayOfWeek 'Giorno della settimana 0 a 6
        Dim GSD As Integer = If(GiornoOra.DayOfWeek < 1, 7, GiornoOra.DayOfWeek)
        Dim G As DateTime
        Select Case G_tiposettimana
            Case 1
                GiornoI = DateAdd(DateInterval.Day, (GS * -1), GiornoOra)
                GiornoF = DateAdd(DateInterval.Day, (GS * -1) + 3, GiornoOra)
                For dd = 0 To 6
                    G = DateAdd(DateInterval.Day, (GS * -1) + dd, GiornoOra)
                    GTxt = AGiorni(G.DayOfWeek)
                    DG_settimana.Columns(dd + 1).HeaderText = G.ToShortDateString & "-" & GTxt
                    DG_settimana.Columns(dd + 1).HeaderCell.Tag = G.ToShortDateString
                    If G.ToShortDateString = Now.ToShortDateString Then
                        'Colora tutte le righe
                        For Each Riga In DG_settimana.Rows
                            Riga.cells(dd + 1).Style.BackColor = Color.Aquamarine
                        Next
                    Else
                        For Each Riga In DG_settimana.Rows
                            Riga.cells(dd + 1).Style.BackColor = Color.White
                        Next
                    End If
                Next
            Case 2
                GiornoI = DateAdd(DateInterval.Day, (GSD * -1) + 1, GiornoOra)
                GiornoF = DateAdd(DateInterval.Day, (GSD * -1) + 7, GiornoOra)
                For dd = 1 To 7 Step 1
                    GTxt = AGiorniL(dd - 1)
                    G = DateAdd(DateInterval.Day, ((GSD) * -1) + dd, GiornoOra)
                    DG_settimana.Columns(dd).HeaderText = G.ToShortDateString & "-" & GTxt
                    DG_settimana.Columns(dd).HeaderCell.Tag = G.ToShortDateString
                    If G.ToShortDateString = Now.ToShortDateString Then
                        For Each Riga In DG_settimana.Rows
                            Riga.cells(dd).Style.BackColor = Color.Aquamarine
                        Next
                    Else
                        For Each Riga In DG_settimana.Rows
                            Riga.cells(dd).Style.BackColor = Color.White
                        Next
                    End If
                Next
        End Select
        TTLB_informazioni.Text = "Dal " & GiornoI.Day & " Al " & GiornoF.Day
    End Sub
    Private Sub PopolaOreAgenda()
        Dim OraInizio As New TimeSpan(6, 0, 0)
        Dim OraTermine As New TimeSpan(22, 0, 0)
        'Dim DG_cl As New DataGridTextBoxColumn
        Dim DGFontg As New Font("Tahoma", 7)
        Dim DGFontp As New Font("Tahoma", 6)
        Dim xx As Int16 = 0
        Dim Percento As Integer = (DG_settimana.Height) / ((OraTermine.Hours - OraInizio.Hours) * 2.2)
        'Dim DG_cl(8) As DataGridViewCell
        For Ora = OraInizio To OraTermine Step New TimeSpan(0, 30, 0)
            Dim DG_rg As New DataGridViewRow
            DG_rg.CreateCells(DG_settimana)
            DG_rg.Cells(0).Value = Ora
            DG_settimana.Rows.Add(DG_rg)
            DG_settimana.Rows(xx).Cells(0).ToolTipText = Ora.ToString
            DG_settimana.Rows(xx).Height = Percento
            If Ora.Minutes = 0 Then
                DG_settimana.Rows(xx).Cells(0).Style.Font = DGFontg
            Else
                DG_settimana.Rows(xx).Cells(0).Style.Font = DGFontp
            End If
            xx += 1
        Next
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub
    Private Sub CaricaDatiAgenda()
        DG_settimana.Rows.Clear()
        PopolaOreAgenda()
        PopolaGiorniAgenda()
        Dim DGFontp As New Font("Tahoma", 8)
        Dim D_periodo As String = G_anno & "-" & G_settimana
        Dim Giorno As DateTime
        Dim DT As New DS_ag.DTsostituzioniDataTable
        TAsostituzioni.FillByDaA(DT, GiornoI.ToShortDateString, GiornoF.ToShortDateString)

        'MsgBox(DT.Count)
        For Each RG_a In DT
            Giorno = GiornoI.ToShortDateString
            Dim AltezzaRiga As Integer = 1


            Do While Giorno < GiornoF
                Dim PosY As Integer = TrovaColonnaGiusta(Giorno)
                Dim PosX As Integer = If(TrovaCellaGiusta(RG_a.ing) < 0, 0, TrovaCellaGiusta(RG_a.ing))

                If RG_a.data.ToShortDateString = Giorno.ToShortDateString Then
                    Dim OldStringa As String = ""
                    Dim OldToolStrip As String = ""
                    Dim OldTag As String = ""

                    If DG_settimana(PosY, PosX).Value <> "" Then
                        Dim Cella As String = DG_settimana(PosY, PosX).Value.ToString
                        OldStringa = Cella.Substring(10, Cella.Length - 11)
                        OldToolStrip = DG_settimana(PosY, PosX).ToolTipText
                        OldTag = DG_settimana(PosY, PosX).Tag & ","
                    End If
                    AltezzaRiga = (OldTag.Count(Function(c As Char) c = ",") * 1) + 1
                    Dim Stringa As String
                    '                                       nero 1             rosso 2                  rosa 3                  verde 4            grigio scuro 5
                    Dim Colore As String = "{\colortbl;\red0\green0\blue0;\red255\green0\blue0;\red255\green192\blue203;\red0\green150\blue36;\red130\green130\blue130}"
                    Dim ToolStrip As String

                    Dim Conferma As String = "\cf4\b0"
                    If Not RG_a.IsidconfermaNull Then
                        If RG_a.idconferma = 0 Then
                            Conferma = "\cf3\b1"
                        End If
                    Else
                        Conferma = "\cf2\b1"
                    End If
                    'RG_a.societa & " => " & Se voglio aggiungere il nome della società

                    If RG_a.idsost = RG_a.iddip Then
                        Stringa = "\qc" + Colore + "\cf2\b0\par -" & AltezzaRiga & "-" & RG_a.locazione.Substring(0, If(RG_a.locazione.Length > 20, 20, RG_a.locazione.Length)) + " "
                        Stringa &= "\par"
                        Stringa &= "\ql" + Colore + Conferma        'Colore 5
                        Stringa &= " " + IIf(RG_a.Isanagrafica_ANull, "", RG_a.anagrafica_A.Substring(0, If(RG_a.anagrafica_A.Length > 25, 25, RG_a.anagrafica_A.Length))) + " "
                        Stringa &= "\par"
                        Stringa &= "\qr" + Colore + "\cf5\b1"
                        Stringa &= RG_a.descrizione
                        Stringa &= "\par "

                        ToolStrip = "|ORA:" & TempoStringaCorta(RG_a.ing) &
                                                    "->" & TempoStringaCorta(RG_a.usc) &
                                                    "|??:" & IIf(RG_a.Isanagrafica_ANull, "", RG_a.anagrafica_A.Substring(0, If(RG_a.anagrafica_A.Length > 25, 25, RG_a.anagrafica_A.Length))) &
                                                    "->" & "NESSUNA SOST" &
                                                    "|DOVE:" & RG_a.locazione.Substring(0, If(RG_a.locazione.Length > 20, 20, RG_a.locazione.Length)) &
                                                    If(RG_a.IsidconfermaNull, "NON CONFERMATO", If(RG_a.idconferma, "", "NON CONFERMATO")) &
                                                    Strings.Chr(13)
                    Else
                        Dim confermato As String = ""
                        Select Case True
                            Case RG_a.IsidconfermaNull = True
                                confermato = "NON CONFERMATO"
                            Case RG_a.idconferma = 0
                                confermato = ""
                            Case Else
                                confermato = "CONFERMATO"

                        End Select
                        Stringa = "\qc" + Colore + "\cf2\b0\par -" & AltezzaRiga & "-" & RG_a.locazione.Substring(0, If(RG_a.locazione.Length > 20, 20, RG_a.locazione.Length)) + " "
                        Stringa &= "\par"
                        Stringa &= "\ql " + Colore + Conferma
                        Stringa &= " " + IIf(RG_a.Isanagrafica_ANull, "", RG_a.anagrafica_A.Substring(0, If(RG_a.anagrafica_A.Length > 25, 25, RG_a.anagrafica_A.Length))) + " "
                        Stringa &= "\par"
                        Stringa &= "\qr" + Colore + "\cf4\b1"
                        Stringa &= " " + RG_a.anagrafica_S.Substring(0, If(RG_a.anagrafica_S.Length > 25, 25, RG_a.anagrafica_S.Length)) + " "
                        Stringa &= "\par "

                        ToolStrip = "|DOVE:" & RG_a.locazione.Substring(0, If(RG_a.locazione.Length > 20, 20, RG_a.locazione.Length)) &
                                                    Strings.Chr(13) & "|ORA:" & TempoStringaCorta(RG_a.ing) &
                                                    "->" & TempoStringaCorta(RG_a.usc) &
                                                    confermato &
                                                    Strings.Chr(13)
                    End If


                    DG_settimana(PosY, PosX).Style.Font = DGFontp
                    '                    AltezzaRiga = (OldTag.Count(Function(c As Char) c = ",") * 1) + 1
                    Dim AltezzaCella As Integer = (41 * (AltezzaRiga + 1))
                    DG_settimana.Rows(PosX).Height = If(DG_settimana.Rows(PosX).Height > AltezzaCella, DG_settimana.Rows(PosX).Height, AltezzaCella)
                    DG_settimana(PosY, PosX).Value = "{\rtf\ansi" & OldStringa & Stringa & "}"
                    DG_settimana(PosY, PosX).ToolTipText = OldToolStrip & ToolStrip
                    DG_settimana(PosY, PosX).Tag = OldTag & RG_a.id
                End If
                'Aggiunge uno alla data iniziale
                Giorno = DateAdd(DateInterval.Day, 1, Giorno)
            Loop
        Next
    End Sub
    Shared Function TrovaCellaGiusta(ByVal Ora As TimeSpan) As Integer
        Dim O As Integer = (Ora.Hours - 6) * 2
        Dim M As Decimal = (Ora.Minutes / 60) + 0.1
        Dim P As Integer = O + M
        Return P
    End Function
    Private Function TrovaColonnaGiusta(ByVal Giorno As DateTime) As Integer
        Dim Y As Integer = 0
        For Each Col In DG_settimana.Columns
            Dim DD As DateTime = Col.HeaderCell.Tag
            If DD.ToShortDateString = Giorno.ToShortDateString Then
                Y = Col.Index
            End If
        Next
        Return (Y)
    End Function

    Private Sub DG_settimana_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_settimana.CellDoubleClick
        Dim ClickCella As DataGridViewCell
        Dim DGW As DataGridView
        Dim A_id() As Integer
        Dim xx As Integer = 0
        Dim Filtro As String = ""
        Dim S_and As String = " OR "
        DGW = DirectCast(sender, DataGridView)

        'in caso si clicchi sull'intestazione
        If e.RowIndex < 0 Then
            Dim fday As New FRM_giorno()
            fday.ShowDialog() 'Utilizzare per aprire il giorno della settimana
            Return
        Else
            ClickCella = DGW(e.ColumnIndex, e.RowIndex)
        End If
        If ClickCella.Tag <> Nothing Then
            Dim ValTag As String = ClickCella.Tag
            A_id = StringaSplit(ValTag)
            For Each kk In A_id
                If Filtro.Length > 2 Then
                    If kk <> 0 Then
                        Filtro = Filtro & S_and
                    End If
                End If
                If kk <> 0 Then
                    Filtro = Filtro & "id=" & kk
                End If
            Next
            bsSostituzioni.RemoveFilter()
            bsSostituzioni.Filter = Filtro
        Else
            bsSostituzioni.RemoveFilter()
        End If
        Dim Ora As Integer = Fix(e.RowIndex / 2)
        Dim Minuti As Integer = If((e.RowIndex / 2) - Ora > 0, 30, 0)
        Dim Orainizio As TimeSpan = New TimeSpan((Ora) + 6, Minuti, 0)
        Dim Giornoinizio As DateTime = DG_settimana.Columns(e.ColumnIndex).HeaderCell.Tag
        Dim MeseCorrente As Integer = G_periodo.Split("-").Last
        If MeseCorrente <> Giornoinizio.Month Then
            G_periodo = Giornoinizio.Year.ToString.PadLeft(4) & "-" & Giornoinizio.Month.ToString.PadLeft(2, "0")
            Me.TAsostituzioni.FillByMese(Me.DS_agenda.DTsostituzioni, G_periodo)
        End If
        Dim F As New FrmAgendaModifica(bsSostituzioni, Nothing, Giornoinizio, Orainizio)
        F.ShowDialog()
        CaricaDatiAgenda()
    End Sub

    Shared Function StringaSplit(ByVal STR As String)
        Dim delimStr As String = ","
        Dim delimiter As Char() = delimStr.ToCharArray()
        If String.IsNullOrEmpty(STR) Then
            Return ""
        End If
        Dim words As String = STR

        Dim split(10) As Int32
        Dim Testo() As String = Nothing
        Dim x As Integer
        Dim Lunghezza As Integer
        Lunghezza = words.Split(delimiter).Length + 1
        For x = 1 To Lunghezza
            Testo = words.Split(delimiter, x)
        Next x
        Dim p As Int32 = 0
        For Each nn In Testo
            split(p) = Convert.ToInt32(nn)
            p += 1
        Next
        Return split
    End Function
    Private Sub TTTS_oggitipoAgenda(sender As Object, e As EventArgs) Handles TTTS_oggilunedi.Click, TTTS_oggiora.Click
        Dim PP As ToolStripMenuItem
        PP = DirectCast(sender, ToolStripMenuItem)
        G_tiposettimana = PP.Tag
        CaricaDatiAgenda()
    End Sub

    Private Sub Muovigiorno(sender As Object, e As EventArgs) Handles BT_Day1.Click, BT_Day7.Click, BT_Day_1.Click, BT_Day_7.Click
        Dim Pulsante As ToolStripButton = DirectCast(sender, ToolStripButton)
        Dim giorni As Integer = Pulsante.Tag
        GiornoOra = DateAdd(DateInterval.Day, giorni, GiornoOra)
        CaricaDatiAgenda()
    End Sub

    Private Sub TTBT_oggi_Click(sender As Object, e As EventArgs) Handles TTBT_oggi.Click
        GiornoOra = Now
        CaricaDatiAgenda()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles TTBT_aggiorna.Click
        Me.TAsostituzioni.FillByMese(Me.DS_agenda.DTsostituzioni, G_periodo)
        CaricaDatiAgenda() 'Popola l'agenda
        CaricaDatiGiorno()  'Popola la tabella dei dipendenti nella giornata selezionata

    End Sub

    Private Sub TT_Giorno_Click(sender As Object, e As EventArgs) Handles TT_Giorno.Click
        Dim FF As New FRM_giorno()
        FF.Show()

    End Sub


    Private Sub CaricaDatiGiorno()
        DG_giorno.Rows.Clear()
        Dim DGFontp As New Font("Tahoma", 8)
        'Dim D_periodo As String = G_anno & "-" & G_settimana
        Dim Giorno As DateTime = Now.ToShortDateString

        Dim DT As New DS_ag.DTsostituzioniDataTable
        TAsostituzioni.FillByGiorno(DT, Giorno)

        Dim xx As Integer = 0
        For Each RG_a In DT
            If RG_a.data.ToShortDateString = Giorno.ToShortDateString Then
                Dim OldStringa As String = ""
                Dim OldToolStrip As String = ""
                Dim OldTag As String = ""
                Console.WriteLine(RG_a.ing)
                Dim Stringa As String = IIf(RG_a.Isanagrafica_ANull, "", RG_a.anagrafica_A.Substring(0, If(RG_a.anagrafica_A.Length > 25, 25, RG_a.anagrafica_A.Length)))

                Dim ToolStrip As String = "|ORA:" & TempoStringaCorta(RG_a.ing) &
                                                    "->" & TempoStringaCorta(RG_a.usc) &
                                                    "|NO:" & IIf(RG_a.Isanagrafica_ANull, "", RG_a.anagrafica_A.Substring(0, If(RG_a.anagrafica_A.Length > 25, 25, RG_a.anagrafica_A.Length))) &
                                                    "->" & RG_a.anagrafica_S.Substring(0, If(RG_a.anagrafica_S.Length > 20, 20, RG_a.anagrafica_S.Length)) &
                                                    "|DOVE:" & RG_a.locazione.Substring(0, If(RG_a.locazione.Length > 20, 20, RG_a.locazione.Length)) &
                                                    Strings.Chr(13)
                DG_giorno.Rows.Add()
                DG_giorno("CC_ora", xx).Value = TempoStringaCorta(RG_a.ing) & "<-->" & TempoStringaCorta(RG_a.usc)
                DG_giorno(1, xx).Value = IIf(RG_a.Isanagrafica_ANull, "", RG_a.anagrafica_A)
                If RG_a.idsost < 0 Then
                    DG_giorno.Rows(xx).DefaultCellStyle.BackColor = Color.OrangeRed
                End If
                DG_giorno(2, xx).Value = RG_a.anagrafica_S
                DG_giorno("C_locazione", xx).Value = RG_a.locazione
                DG_giorno("C_cliente", xx).Value = RG_a.societa
                DG_giorno("C_tipo", xx).Value = RG_a.descrizione
                DG_giorno("C_note", xx).Value = RG_a.note
                xx += 1
            End If
        Next

    End Sub
End Class
