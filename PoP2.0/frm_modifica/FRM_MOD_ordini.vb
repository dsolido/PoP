Public Class FRM_MOD_ordini

    Dim BS As BindingSource
    Dim G_az As Integer = GlobalVarPOP.G_idAZ
    Public Sub New(ByRef _BS As BindingSource)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        BS = _BS
    End Sub
    Private Sub FRM_MOD_ordini_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TA_frasi.FillByID_contesto(Me.DS_Ordini.DT_frasi, 6)
        For Each RG_F In DS_Ordini.DT_frasi
            LB_Frase.Items.Add(RG_F.frase)
        Next
        Me.TA_fornitori.Fill(Me.DS_Ordini.DT_fornitori)

        Dim RG As DS_Ordini.DT_ordiniRow
        RG = DirectCast(BS.Current, DataRowView).Row
        CaricaTabelle()
        Try
            CB_clienti.SelectedIndex = CB_clienti.FindStringExact(RG.societa)
        Catch
        End Try
        Try
            CB_locazioni.SelectedIndex = CB_locazioni.FindStringExact(RG.locazione)
        Catch ex As Exception

        End Try
        Try
            CB_utenti.SelectedIndex = CB_utenti.FindStringExact(RG.anagrafica)
        Catch ex As Exception

        End Try
        Try
            CB_fornitore.SelectedIndex = CB_fornitore.FindStringExact(RG.fornitore)
        Catch ex As Exception

        End Try
        Try
            TX_data.Text = RG.data_ordine.ToShortDateString
        Catch ex As Exception

        End Try

        TX_id.Text = RG.id
        TX_note.Text = RG.annotazioni
    End Sub

    Private Sub CaricaTabelle()
        Try
            Me.TA_destinatari.Fill(Me.DS_Ordini.DT_destinatari, G_az)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.TA_clienti.FillByAttivo(Me.DS_Ordini.DT_clienti, G_az, 1)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        Try
            Me.TA_utenti.FillByAttivi(Me.DS_Ordini.DT_utenti, G_az, 0)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub COMBO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_clienti.SelectedIndexChanged, CB_locazioni.SelectedIndexChanged, CB_utenti.SelectedIndexChanged, CB_fornitore.SelectedIndexChanged
        Dim XS As ComboBox
        XS = DirectCast(sender, ComboBox)
        Dim RG As DS_Ordini.DT_ordiniRow
        RG = DirectCast(BS.Current, DataRowView).Row
        Select Case XS.Name
            Case "CB_clienti"
                RG.id_cliente = CB_clienti.SelectedValue
                BS_locazioni.Filter = "id_terminale = " & RG.id_cliente
            Case "CB_locazioni"
                RG.id_locazione = CB_locazioni.SelectedValue
            Case "CB_utenti"
                RG.id_utente = CB_utenti.SelectedValue
            Case "CB_fornitore"
                RG.id_fornitore = CB_fornitore.SelectedValue
        End Select
    End Sub
    Private Sub TX_TextChanged(sender As Object, e As EventArgs) Handles TX_note.TextChanged, TX_data.TextChanged
        Dim XS As TextBox
        XS = DirectCast(sender, TextBox)
        Dim RG As DS_Ordini.DT_ordiniRow
        RG = DirectCast(BS.Current, DataRowView).Row
        Select Case XS.Name
            Case "TX_note"
                RG.annotazioni = TX_note.Text
            Case "TX_data"
                RG.data_ordine = TX_data.Text
        End Select
    End Sub
    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click
        Dim RG As DS_Ordini.DT_ordiniRow
        BS.AddNew()
        RG = DirectCast(BS.Current, DataRowView).Row
        CB_clienti.SelectedIndex = 0
        CB_locazioni.SelectedIndex = 0
        CB_utenti.SelectedIndex = 0
        CB_fornitore.SelectedIndex = 0
        TX_data.Text = Now.ToShortDateString
        Dim newID As Integer
        Using TA As New DS_OrdiniTableAdapters.TA_ordini
            newID = TA.SQnuovoID()
        End Using
        TX_id.Text = newID
        RG.id = newID
        RG.data_ordine = Now.ToShortDateString
        RG.id_locazione = 0
        RG.id_utente = 0
        RG.id_cliente = 0
        RG.id_fornitore = 0
        RG.i_inviato = 0
        RG.d_inviato = Now()
        RG.annotazioni = ""
        TX_note.Text = ""
    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Dim RG As DS_Ordini.DT_ordiniRow
        RG = DirectCast(BS.Current, DataRowView).Row
        Dim Passa As Integer = 0
        Dim Cosa As String = ""
        Select Case True
            Case RG.id_locazione = 0
                Cosa = "Destinazione"
            Case RG.id_utente = 0
                Cosa = "Utente"
            Case RG.id_cliente = 0
                Cosa = "Cliente"
            Case RG.id_fornitore = 0
                Cosa = "Fornitore"
            Case Else

                Passa = 1
        End Select
        If Passa Then
            Me.Close()
        Else
            If MsgBox("Devi Selezionare il " & Cosa & " Termino senza salvare?", MsgBoxStyle.YesNo, "Conferma") = MsgBoxResult.Yes Then
                BS.CancelEdit()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TTBTannulla_Click(sender As Object, e As EventArgs) Handles TTBTannulla.Click
        BS.CancelEdit()
        Me.Close()
    End Sub

    Private Sub LB_Frase_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LB_Frase.SelectedIndexChanged
        Dim LB_T As ListBox
        LB_T = DirectCast(sender, ListBox)
        TX_note.Text = LB_T.SelectedItem
    End Sub
End Class