Public Class FrmDipendentiPresenzeWeb

    Dim DTcli() As DataRow
    Dim DTdes As DataTable
    'Dim DTpre As DataTable
    Dim BScli As New BindingSource
    Dim BSdes As New BindingSource
    Dim BStipo As New BindingSource
    Dim CMBClienti As New ComboBox
    Dim CMBDestinatari As New ComboBox
    Dim CMBTipo As New ComboBox
    'Dim RGpres As DS_utenti.DT_presenzeWEBRow
    Public ediT As Boolean = False
    Private RGpres As DS_utenti.DT_presenzeWEBRow
    Private RGpresCli As DS_clienti.DT_presenzeWEBRow
    Public Sub New(ByVal id As Integer, Optional ByVal cli As DataTable = Nothing, Optional ByVal des As DataTable = Nothing, Optional ByRef preDip As DataRow = Nothing, Optional ByRef preCli As DataRow = Nothing)
        'Inizializza l'archivio Tipologia
        Using DT As New DS_utenti.DT_tipologiaDataTable
            Using TA As New DS_utentiTableAdapters.TA_tipologia
                TA.mostra(DT)
                BStipo.DataMember = DT.TableName
                BStipo.DataSource = DT
            End Using
        End Using
        InitializeComponent()
        'Inizializza l'archivio clienti
        If IsNothing(cli) Then
            Dim DTrowCli As New DS_clienti.DT_cantieri_newDataTable
            Using TA As New DS_clientiTableAdapters.TA_cantieri_new
                TA.FillByAttivi(DTrowCli, GlobalVarPOP.G_idAZ, 1)
            End Using
            DTcli = DTrowCli.Select("attivo = 1")
        Else
            DTcli = cli.Select("attivo = 1")
        End If
        'Inizializza archivio Dettaglio Clienti
        If IsNothing(des) Then
            '            Dim DTrowDes As New DS_clienti.DT_locazione_newDataTable
            Using DTrowDes As New DS_clienti.DT_locazione_newDataTable
                Using TA As New DS_clientiTableAdapters.TA_locazione_new
                    TA.Fill(DTrowDes, GlobalVarPOP.G_idAZ)
                End Using
                DTdes = DTrowDes
            End Using

        Else
            DTdes = des
        End If

        BScli.DataSource = DTcli
        BSdes.DataMember = DTdes.TableName
        BSdes.DataSource = DTdes
        Dim x As Integer = 0
        ''        If IsNothing(preDip) Then
        'Using DGpres As New DS_utenti.DT_presenzeWEBDataTable
        '    Using TApres As New DS_utentiTableAdapters.TA_presenzeWEB
        '        TApres.FillByID(DGpres, id)
        '    End Using
        '    BS_presenzeWEB.DataSource = DGpres
        RGpres = preDip
        'End Using

        'RGpres = Nothing
        '       Else
        '      RGpres = preDip
        '     End If
        'If IsNothing(preCli) Then
        '    Using DGpres As New DS_clienti.DT_presenzeWEBDataTable
        '        Using TApres As New DS_clientiTableAdapters.TA_presenzeWEB
        '            TApres.FillByID(DGpres, id)
        '        End Using
        '        RGpresCli = DGpres.Rows.Item(0)
        '    End Using
        'Else
        RGpresCli = preCli
        'End If


        Aggiungecomponenti()
        Me.Controls.Add(CMBClienti)
        AddHandler CMBClienti.SelectedIndexChanged, AddressOf CMBclienti_SelectedIndexChanged
        Me.Controls.Add(CMBDestinatari)
        Me.Controls.Add(CMBTipo)
    End Sub
    Private Sub FRMmodificapresenzeweb_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub Aggiungecomponenti()

        If IsNothing(RGpres) Then
            CMBClienti.DataBindings.Add(New Binding("SelectedValue", RGpresCli, "id_terminale", True))
        Else
            CMBClienti.DataBindings.Add(New Binding("SelectedValue", RGpres, "id_terminale", True))
        End If

        CMBClienti.DataSource = BScli
        CMBClienti.FormattingEnabled = True
        CMBClienti.Location = New Point(169, 133)
        CMBClienti.Margin = New Padding(4, 5, 4, 5)
        CMBClienti.Size = New Size(215, 28)
        CMBClienti.TabIndex = 1
        CMBClienti.ValueMember = "id"
        CMBClienti.DisplayMember = "societa"
        CMBClienti.TabIndex = 3

        If IsNothing(RGpres) Then
            CMBDestinatari.DataBindings.Add(New Binding("SelectedValue", RGpresCli, "id_locazione", True))
        Else
            CMBDestinatari.DataBindings.Add(New Binding("SelectedValue", RGpres, "id_locazione", True))
        End If

        CMBDestinatari.DataSource = DTdes
        CMBDestinatari.DisplayMember = "locazione"
        CMBDestinatari.FormattingEnabled = True
        CMBDestinatari.Location = New Point(169, 175)
        CMBDestinatari.Margin = New Padding(4, 5, 4, 5)
        CMBDestinatari.Name = "CMBdestinatari"
        CMBDestinatari.Size = New Size(215, 28)
        CMBDestinatari.TabIndex = 2
        CMBDestinatari.ValueMember = "id"
        CMBDestinatari.TabIndex = 4

        If IsNothing(RGpres) Then
            CMBTipo.DataBindings.Add(New Binding("SelectedValue", RGpresCli, "inviato", True))
        Else
            CMBTipo.DataBindings.Add(New Binding("SelectedValue", RGpres, "inviato", True))
        End If

        CMBTipo.DataSource = BStipo
        CMBTipo.DisplayMember = "descrizione"
        CMBTipo.FormattingEnabled = True
        CMBTipo.Location = New Point(169, 217)
        CMBTipo.Margin = New Padding(4, 5, 4, 5)
        CMBTipo.Name = "CMBTipo"
        CMBTipo.Size = New Size(215, 28)
        CMBTipo.TabIndex = 2
        CMBTipo.ValueMember = "id_tipo"
        CMBTipo.TabIndex = 5

        GiornoDateTimePicker.DataBindings.RemoveAt(0)
        If IsNothing(RGpres) Then
            GiornoDateTimePicker.DataBindings.Add(New Binding("Value", RGpresCli, "giorno", True))
        Else
            GiornoDateTimePicker.DataBindings.Add(New Binding("Value", RGpres, "giorno", True))
        End If

        IngressoTextBox.DataBindings.RemoveAt(0)
        UscitaTextBox.DataBindings.RemoveAt(0)
        NoteTextBox.DataBindings.RemoveAt(0)

        If IsNothing(RGpres) Then
            IngressoTextBox.DataBindings.Add(New Binding("Text", RGpresCli, "ingresso", True))
            UscitaTextBox.DataBindings.Add(New Binding("Text", RGpresCli, "uscita", True))
            NoteTextBox.DataBindings.Add(New Binding("Text", RGpresCli, "note", True))
        Else
            IngressoTextBox.DataBindings.Add(New Binding("Text", RGpres, "ingresso", True))
            UscitaTextBox.DataBindings.Add(New Binding("Text", RGpres, "uscita", True))
            NoteTextBox.DataBindings.Add(New Binding("Text", RGpres, "note", True))
        End If
    End Sub
    Private Sub CMBclienti_SelectedIndexChanged(sender As Object, e As EventArgs)
        If IsNothing(RGpres) Then
            Dim idTer As DS_clienti.DT_cantieri_newRow
            idTer = CMBClienti.SelectedItem
            If IsNothing(idTer) Then
                Return
            End If
            BSdes.RemoveFilter()
            BSdes.Filter = "id_terminale = " & idTer.id
        Else
            Dim idTer As DS_utenti.DT_clientiRow
            idTer = CMBClienti.SelectedItem
            If IsNothing(idTer) Then
                Return
            End If
            BSdes.RemoveFilter()
            BSdes.Filter = "id_terminale = " & idTer.id
        End If
    End Sub
    Private Sub CMBdestinatari_SelectedIndexChanged(sender As Object, e As EventArgs)
        If IsNothing(RGpres) Then
            Dim idLoc As DS_clienti.DT_locazione_newRow
            idLoc = CMBDestinatari.SelectedItem
            RGpresCli.id_locazione = idLoc.id
            RGpresCli.locazione = idLoc.locazione
        Else
            Dim idLoc As DS_utenti.DT_destinatariRow
            idLoc = CMBDestinatari.SelectedItem
            RGpres.id_locazione = idLoc.id
            RGpres.locazione = idLoc.locazione
        End If

    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        BS_presenzeWEB.EndEdit()
        If IsNothing(RGpres) Then
            RGpresCli.note = If(RGpresCli.IsnoteNull, "", RGpresCli.note)
            TA_presenzeWEB.modificaPresenze(RGpresCli.id_terminale, RGpresCli.id_locazione, RGpresCli.giorno, RGpresCli.ingresso.ToString(), RGpresCli.uscita.ToString(), RGpresCli.note, If(RGpresCli.IsinviatoNull, 0, RGpresCli.inviato), RGpresCli.id)
            RGpresCli.AcceptChanges()
        Else
            RGpres.note = If(RGpres.IsnoteNull, "", RGpres.note)
            TA_presenzeWEB.modificaPresenze(RGpres.id_terminale, RGpres.id_locazione, RGpres.giorno, RGpres.ingresso.ToString(), RGpres.uscita.ToString(), RGpres.note, If(RGpres.IsinviatoNull, 0, RGpres.inviato), RGpres.id)
            RGpres.AcceptChanges()
        End If


        Me.Close()
    End Sub

    Private Sub TTBTannulla_Click(sender As Object, e As EventArgs) Handles TTBTannulla.Click
        BS_presenzeWEB.CancelEdit()
        If IsNothing(RGpres) Then
            RGpresCli.RejectChanges()
        Else
            RGpres.RejectChanges()
        End If
        Me.Close()
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        If IsNothing(RGpres) Then
            RGpresCli.note = If(RGpresCli.IsnoteNull, "", RGpresCli.note)
        Else
            RGpres.note = If(RGpres.IsnoteNull, "", RGpres.note)
        End If
        BS_presenzeWEB.EndEdit()
        Me.Close()
    End Sub

    Private Sub Testo_orari(sender As Object, e As KeyPressEventArgs) Handles IngressoTextBox.KeyPress, UscitaTextBox.KeyPress

        If Not Char.IsControl(e.KeyChar) And Not Char.IsDigit(e.KeyChar) And (e.KeyChar <> ":") Then
            e.Handled = True
        End If

        Dim tasto As Object = e.KeyChar
        Dim testo As TextBox
        testo = DirectCast(sender, TextBox)

        If tasto = "." Or tasto = "," Then
            tasto = ":"
            testo.Text = testo.Text.ToString.Substring(0, testo.Text.Length) & tasto
            testo.SelectionStart = testo.Text.Length

        End If
    End Sub
End Class