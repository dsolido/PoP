Public Class frmDipendentePianodiLavoro
    Dim idOrario As Integer
    Dim rgOra As DS_utenti.DT_orariRow
    Dim dtUte As New DS_utenti.DT_utentiDataTable
    Dim dtCli As New DS_utenti.DT_clientiDataTable
    Dim dtLoc As New DS_utenti.DT_destinatariDataTable

    Public Sub New(ByRef id As Integer, ByRef DT As DataTable)



        InitializeComponent()

        bsOrari.DataSource = DT
        idOrario = id

    End Sub
    Private Sub FRM_ore_new_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DT_BarraNavigazione.BindingSource = bsOrari

        abbinaBinding()

        caricaUtenti()
        caricaClienti()


        If idOrario < 0 Then
            bsOrari.MoveLast()
            Me.BackColor = DefaultBackColor
            rgOra = DirectCast(bsOrari.Current, DataRowView).Row
        Else
            bsOrari.Position = bsOrari.Find("id", idOrario)
            rgOra = DirectCast(bsOrari.Current, DataRowView).Row
            Me.BackColor = Color.PaleVioletRed

        End If

        For Each ss In bsOrari
            Console.WriteLine(ss.item("id_dip").ToString() + "  " + ss.item("id_cli").ToString())
        Next
        Dim Dip As String = UtentiDaID(rgOra.id_dip)
        CB_utenti.SelectedItem = Dip

        Dim Cli As String = ClientedaID(rgOra.id_cli)
        CB_clienti.SelectedItem = Cli

        Dim Det As String = DettagliodaID(rgOra.id_des)
        LBdestinatari.SelectedItem = Det

    End Sub
    Private Sub abbinaBinding()

        Me.Lu_iTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "lu_i", True))
        Me.Lu_uTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "lu_u", True))
        Me.Ma_iTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "ma_i", True))
        Me.Ma_uTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "ma_u", True))
        Me.Me_iTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "me_i", True))
        Me.Me_uTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "me_u", True))
        Me.Gi_iTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "gi_i", True))
        Me.Gi_uTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "gi_u", True))
        Me.Ve_iTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "ve_i", True))
        Me.Ve_uTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "ve_u", True))
        Me.Sa_iTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "sa_i", True))
        Me.Sa_uTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "sa_u", True))
        Me.Do_iTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "do_i", True))
        Me.Do_uTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", bsOrari, "do_u", True))
        Me.QuindicinaleCheckBox.DataBindings.Add(New Binding("Checked", bsOrari, "quindicinale", True))
        Me.NoteTextBox.DataBindings.Add(New Binding("Text", bsOrari, "note", True))
        Me.AttivoCheckBox.DataBindings.Add(New Binding("Checked", bsOrari, "attivo", True))
    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()
    End Sub
    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        bsOrari.EndEdit()
        Dim rgOra As DS_utenti.DT_orariRow
        For Each ss In bsOrari
            Console.WriteLine(ss.item("id_dip").ToString() + "  " + ss.item("id_cli").ToString())
        Next

        For Each rr As DataRowView In bsOrari
            rgOra = DirectCast(rr, DataRowView).Row
            Dim I_stato As DataRowState = rgOra.RowState
            Select Case I_stato
                Case DataRowState.Modified
                    F_ControllaCoerenzaOre(rgOra)
                    Using ta As New DS_utentiTableAdapters.TA_orari
                        Dim yt As Integer = ta.modifica(rgOra.id_dip, rgOra.id_cli, rgOra.id_des,
                                            If(rgOra.Islu_iNull, Nothing, If(rgOra.lu_i = "0", "00:00", rgOra.lu_i)),
                                            If(rgOra.Islu_uNull, Nothing, If(rgOra.lu_u = "0", "00:00", rgOra.lu_u)),
                                            If(rgOra.Isma_iNull, Nothing, If(rgOra.ma_i = "0", "00:00", rgOra.ma_i)),
                                            If(rgOra.Isma_uNull, Nothing, If(rgOra.ma_u = "0", "00:00", rgOra.ma_u)),
                                            If(rgOra.Isme_iNull, Nothing, If(rgOra.me_i = "0", "00:00", rgOra.me_i)),
                                            If(rgOra.Isme_uNull, Nothing, If(rgOra.me_u = "0", "00:00", rgOra.me_u)),
                                            If(rgOra.Isgi_iNull, Nothing, If(rgOra.gi_i = "0", "00:00", rgOra.gi_i)),
                                            If(rgOra.Isgi_uNull, Nothing, If(rgOra.gi_u = "0", "00:00", rgOra.gi_u)),
                                            If(rgOra.Isve_iNull, Nothing, If(rgOra.ve_i = "0", "00:00", rgOra.ve_i)),
                                            If(rgOra.Isve_uNull, Nothing, If(rgOra.ve_u = "0", "00:00", rgOra.ve_u)),
                                            If(rgOra.Issa_iNull, Nothing, If(rgOra.sa_i = "0", "00:00", rgOra.sa_i)),
                                            If(rgOra.Issa_uNull, Nothing, If(rgOra.sa_u = "0", "00:00", rgOra.sa_u)),
                                            If(rgOra.Isdo_iNull, Nothing, If(rgOra.do_i = "0", "00:00", rgOra.do_i)),
                                            If(rgOra.Isdo_uNull, Nothing, If(rgOra.do_u = "0", "00:00", rgOra.do_u)),
                                            Now(), Now().AddYears(50), rgOra.attivo, rgOra.note, rgOra.quindicinale, rgOra.id)
                        If yt = 1 Then
                            CheckBox1.ImageIndex = 1
                        Else
                            CheckBox1.ImageIndex = 0
                        End If
                        Application.DoEvents()
                        Threading.Thread.Sleep(300)
                        CheckBox1.ImageIndex = Nothing
                    End Using
                    rgOra.AcceptChanges()
                Case DataRowState.Added
                    F_ControllaCoerenzaOre(rgOra)
                    Using ta As New DS_utentiTableAdapters.TA_orari
                        Dim yt As Integer = ta.inserisce(rgOra.id_dip, rgOra.id_cli, rgOra.id_des,
                                            If(rgOra.Islu_iNull, Nothing, If(rgOra.lu_i = "0", "00:00", rgOra.lu_i)),
                                            If(rgOra.Islu_uNull, Nothing, If(rgOra.lu_u = "0", "00:00", rgOra.lu_u)),
                                            If(rgOra.Isma_iNull, Nothing, If(rgOra.ma_i = "0", "00:00", rgOra.ma_i)),
                                            If(rgOra.Isma_uNull, Nothing, If(rgOra.ma_u = "0", "00:00", rgOra.ma_u)),
                                            If(rgOra.Isme_iNull, Nothing, If(rgOra.me_i = "0", "00:00", rgOra.me_i)),
                                            If(rgOra.Isme_uNull, Nothing, If(rgOra.me_u = "0", "00:00", rgOra.me_u)),
                                            If(rgOra.Isgi_iNull, Nothing, If(rgOra.gi_i = "0", "00:00", rgOra.gi_i)),
                                            If(rgOra.Isgi_uNull, Nothing, If(rgOra.gi_u = "0", "00:00", rgOra.gi_u)),
                                            If(rgOra.Isve_iNull, Nothing, If(rgOra.ve_i = "0", "00:00", rgOra.ve_i)),
                                            If(rgOra.Isve_uNull, Nothing, If(rgOra.ve_u = "0", "00:00", rgOra.ve_u)),
                                            If(rgOra.Issa_iNull, Nothing, If(rgOra.sa_i = "0", "00:00", rgOra.sa_i)),
                                            If(rgOra.Issa_uNull, Nothing, If(rgOra.sa_u = "0", "00:00", rgOra.sa_u)),
                                            If(rgOra.Isdo_iNull, Nothing, If(rgOra.do_i = "0", "00:00", rgOra.do_i)),
                                            If(rgOra.Isdo_uNull, Nothing, If(rgOra.do_u = "0", "00:00", rgOra.do_u)),
                                            Now(), Now().AddYears(50), rgOra.attivo, rgOra.note, rgOra.quindicinale)
                        If yt = 1 Then
                            CheckBox1.ImageIndex = 1
                        Else
                            CheckBox1.ImageIndex = 0
                        End If
                        Application.DoEvents()
                        Threading.Thread.Sleep(300)
                        CheckBox1.ImageIndex = Nothing
                    End Using
                    rgOra.AcceptChanges()
            End Select
        Next
        Me.Close()
    End Sub
    Private Function F_ControllaCoerenzaOre(ByRef rgOra As DS_utenti.DT_orariRow)

        rgOra.lu_i = If(rgOra.Islu_iNull, "00:00", If(rgOra.lu_i.ToString().Length = 0, "00:00", rgOra.lu_i))
        rgOra.lu_u = If(rgOra.Islu_uNull, "00:00", rgOra.lu_u)
        rgOra.ma_i = If(rgOra.Isma_iNull, "00:00", rgOra.ma_i)
        rgOra.ma_u = If(rgOra.Isma_uNull, "00:00", rgOra.ma_u)
        rgOra.me_i = If(rgOra.Isme_iNull, "00:00", rgOra.me_i)
        rgOra.me_u = If(rgOra.Isme_uNull, "00:00", rgOra.me_u)
        rgOra.gi_i = If(rgOra.Isgi_iNull, "00:00", rgOra.gi_i)
        rgOra.gi_u = If(rgOra.Isgi_uNull, "00:00", rgOra.gi_u)
        rgOra.ve_i = If(rgOra.Isve_iNull, "00:00", rgOra.ve_i)
        rgOra.ve_u = If(rgOra.Isve_uNull, "00:00", rgOra.ve_u)
        rgOra.sa_i = If(rgOra.Issa_iNull, "00:00", rgOra.sa_i)
        rgOra.sa_u = If(rgOra.Issa_uNull, "00:00", rgOra.sa_u)
        rgOra.do_i = If(rgOra.Isdo_iNull, "00:00", rgOra.do_i)
        rgOra.do_u = If(rgOra.Isdo_uNull, "00:00", rgOra.do_u)
        If rgOra.Isid_dipNull Then
            MsgBox("Verifica il dipendente")
            CB_utenti.Focus()
            Return rgOra
        End If
        If rgOra.Isid_cliNull Then
            MsgBox("Verifica il Cliente")
            CB_clienti.Focus()
            Return rgOra
        End If
        If rgOra.Isid_desNull Then
            MsgBox("Verifica la destinazione")
            LBdestinatari.Focus()
            Return rgOra
        End If
        If rgOra.IsnoteNull Then
            rgOra.note = ""
        End If
        If rgOra.IsquindicinaleNull Then
            rgOra.quindicinale = 0
        End If
        If rgOra.IsattivoNull Then
            rgOra.attivo = 1
        End If
        Return (rgOra)
    End Function

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        If MsgBox("Sei sicuro di voler eliminare l'orario con ID " & "", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            'TA_orario.elimina(RigaOrario.id)
            TTBTTermina.PerformClick()
        End If
    End Sub

    Private Sub BT_giornaliero_Click(sender As Object, e As EventArgs) Handles BT_giornaliero.Click
        'in caso di pressione assegna tutti i giorni il valore di lu (ingresso) e (uscita) 
        If Lu_iTextBox.Text <> "" And Lu_uTextBox.Text <> "" Then
            Ma_iTextBox.Text = Lu_iTextBox.Text
            Ma_uTextBox.Text = Lu_uTextBox.Text
            Me_iTextBox.Text = Lu_iTextBox.Text
            Me_uTextBox.Text = Lu_uTextBox.Text
            Gi_iTextBox.Text = Lu_iTextBox.Text
            Gi_uTextBox.Text = Lu_uTextBox.Text
            Ve_iTextBox.Text = Lu_iTextBox.Text
            Ve_uTextBox.Text = Lu_uTextBox.Text
            Sa_iTextBox.Text = "00:00"
            Sa_uTextBox.Text = "00:00"
            Do_iTextBox.Text = "00:00"
            Do_uTextBox.Text = "00:00"

        End If
    End Sub

    Private Sub BT_trisettimanale_Click(sender As Object, e As EventArgs) Handles BT_trisettimanale.Click
        'in caso di pressione assegna a giorni alterni il valore di lu (ingresso) e (uscita) 
        If Lu_iTextBox.Text <> "" And Lu_uTextBox.Text <> "" Then
            Ma_iTextBox.Text = ""
            Ma_uTextBox.Text = ""
            Me_iTextBox.Text = Lu_iTextBox.Text
            Me_uTextBox.Text = Lu_uTextBox.Text
            Gi_iTextBox.Text = ""
            Gi_uTextBox.Text = ""
            Ve_iTextBox.Text = Lu_iTextBox.Text
            Ve_uTextBox.Text = Lu_uTextBox.Text
            Sa_iTextBox.Text = ""
            Sa_uTextBox.Text = ""
            Do_iTextBox.Text = ""
            Do_uTextBox.Text = ""
        End If
    End Sub

    Private Sub Lu_iTextBox_TextChanged(sender As Object, e As KeyPressEventArgs) Handles Lu_iTextBox.KeyPress, Lu_uTextBox.KeyPress,
            Ma_iTextBox.KeyPress, Ma_uTextBox.KeyPress, Me_iTextBox.KeyPress, Me_uTextBox.KeyPress,
            Gi_iTextBox.KeyPress, Gi_uTextBox.KeyPress, Ve_iTextBox.KeyPress, Ve_uTextBox.KeyPress,
            Sa_iTextBox.KeyPress, Sa_uTextBox.KeyPress, Do_iTextBox.KeyPress, Do_uTextBox.KeyPress

        Dim TX_temp As TextBox
        TX_temp = DirectCast(sender, TextBox)
        Dim KeyAscii As Short = Asc(e.KeyChar)
        If KeyAscii < 48 And KeyAscii <> 24 And KeyAscii <> 8 And e.KeyChar <> ":" And e.KeyChar <> "." And e.KeyChar <> "," Then
            KeyAscii = 0
        ElseIf KeyAscii > 59 Then
            KeyAscii = 0
        End If
        If e.KeyChar = "," Then
            KeyAscii = 58 ' 58 è il codice ascii dei due punti
        End If
        If e.KeyChar = "." Then
            KeyAscii = 58
        End If
        ' I 2punti è consentito
        ' ma non come primo carattere
        If TX_temp.TextLength = 0 And KeyAscii = 58 Then
            KeyAscii = 0
        End If
        ' ovviamente se c'è un 2punti
        ' non è consentito digitarne altri
        If (KeyAscii = 58) And
            TX_temp.Text.IndexOf(":") > 0 Then
            KeyAscii = 0
        End If
        ' Reimposto il keychar
        e.KeyChar = Chr(KeyAscii)

    End Sub

    Private Sub BT_vuota_Click(sender As Object, e As EventArgs) Handles BT_vuota.Click
        Lu_iTextBox.Text = "00:00"
        Lu_uTextBox.Text = "00:00"
        Ma_iTextBox.Text = "00:00"
        Ma_uTextBox.Text = "00:00"
        Me_iTextBox.Text = "00:00"
        Me_uTextBox.Text = "00:00"
        Gi_iTextBox.Text = "00:00"
        Gi_uTextBox.Text = "00:00"
        Ve_iTextBox.Text = "00:00"
        Ve_uTextBox.Text = "00:00"
        Sa_iTextBox.Text = "00:00"
        Sa_uTextBox.Text = "00:00"
        Do_iTextBox.Text = "00:00"
        Do_uTextBox.Text = "00:00"
    End Sub


    Private Sub BT_attivaCombo_Click(sender As Object, e As EventArgs)
        CB_clienti.Visible = True
        CB_utenti.Visible = True
        LBdestinatari.Visible = True
        Label2.Visible = True
        Label3.Visible = True
    End Sub

    Private Sub CB_clienti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_clienti.SelectedIndexChanged
        Dim idTmp = ClientedaSTR(CB_clienti.SelectedItem)
        Using ta As New DS_utentiTableAdapters.TA_destinatari
            ta.FillByCliente(dtLoc, idTmp)
            Dim aLB As ListBox.ObjectCollection
            'Dim Arr(dtLoc.Rows.Count - 1, 1) As String
            Dim xx As Integer = 0
            For Each rgLoc As DS_utenti.DT_destinatariRow In dtLoc.Rows
                LBdestinatari.Items.Add(rgLoc.locazione)
            Next
        End Using
        Dim rgOrari As DS_utenti.DT_orariRow = DirectCast(bsOrari.Current, DataRowView).Row
        rgOrari.id_cli = idTmp
    End Sub
    Private Sub CB_Utenti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_utenti.SelectedIndexChanged
        Dim idTmp = UtentiDaSTR(CB_utenti.SelectedItem)
        Dim rgOrari As DS_utenti.DT_orariRow = DirectCast(bsOrari.Current, DataRowView).Row
        rgOrari.id_dip = idTmp
    End Sub
    Private Sub LBdestinatari_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBdestinatari.SelectedIndexChanged
        Dim idTmp = DettagliodaSTR(LBdestinatari.SelectedItem)
        Dim rgOrari As DS_utenti.DT_orariRow = DirectCast(bsOrari.Current, DataRowView).Row
        rgOrari.id_des = idTmp
    End Sub

    Private Sub caricaClienti()

        Using ta As New DS_utentiTableAdapters.TA_clienti
            Dim idcli = 0
            ta.FillByTuttiiClientiAttivi(dtCli, 1)
            For Each rgLoc As DS_utenti.DT_clientiRow In dtCli.Rows
                CB_clienti.Items.Add(rgLoc.societa)
            Next
        End Using
    End Sub
    Private Function ClientedaSTR(ByVal Tmp As String) As Integer
        ClientedaSTR = 0
        For Each rgcli As DS_utenti.DT_clientiRow In dtCli.Rows
            If rgcli.societa = Tmp Then
                ClientedaSTR = rgcli.id
                Return ClientedaSTR
            End If
        Next
        Return ClientedaSTR
    End Function
    Private Function ClientedaID(ByVal idTmp As Integer) As String
        ClientedaID = ""
        For Each rgcli As DS_utenti.DT_clientiRow In dtCli.Rows
            If rgcli.id = idTmp Then
                ClientedaID = rgcli.societa
                Return ClientedaID
            End If
        Next
        Return ClientedaID
    End Function
    Private Function DettagliodaSTR(ByVal Tmp As String) As Integer
        DettagliodaSTR = 0
        For Each rgDet As DS_utenti.DT_destinatariRow In dtLoc.Rows
            If rgDet.locazione = Tmp Then
                DettagliodaSTR = rgDet.id
                Return DettagliodaSTR
            End If
        Next
        Return DettagliodaSTR
    End Function
    Private Function DettagliodaID(ByVal idTmp As Integer) As String
        DettagliodaID = ""
        For Each rgDet As DS_utenti.DT_destinatariRow In dtLoc.Rows
            If rgDet.id = idTmp Then
                DettagliodaID = rgDet.locazione
                Return DettagliodaID
            End If
        Next
        Return DettagliodaID
    End Function

    Private Sub caricaUtenti()
        Using ta As New DS_utentiTableAdapters.TA_utenti
            Dim idUte = 0
            ta.FillByAttivi(dtUte, 1, GlobalVarPOP.G_idAZ)
            For Each rgUte As DS_utenti.DT_utentiRow In dtUte.Rows
                CB_utenti.Items.Add(rgUte.Anagrafica)
            Next
        End Using
    End Sub
    Private Function UtentiDaID(ByVal idTmp As Integer) As String
        UtentiDaID = ""
        For Each rgute As DS_utenti.DT_utentiRow In dtUte.Rows
            If rgute.id = idTmp Then
                UtentiDaID = rgute.Anagrafica
                Return UtentiDaID
            End If
        Next
        Return UtentiDaID
    End Function
    Private Function UtentiDaSTR(ByVal Tmp As String) As Integer
        UtentiDaSTR = 0
        For Each rgute As DS_utenti.DT_utentiRow In dtUte.Rows
            If rgute.Anagrafica = Tmp Then
                UtentiDaSTR = rgute.id
                Return UtentiDaSTR
            End If
        Next
        Return UtentiDaSTR
    End Function

End Class