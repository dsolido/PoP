Public Class FRM_mod_cliente
    Dim RG_cli As New BindingSource
    Dim NuovoID As Integer
    Dim G_idAz As Integer = GlobalVarPOP.G_idAZ
    Dim dtCliente As DS_clienti.DT_cantieri_newDataTable
    Public Sub New(ByRef DTclienti As DataTable, Optional ByRef tmpRG As BindingSource = Nothing, Optional ByVal tmpID As Integer = -1)
        InitializeComponent()
        BS_clienti.DataSource = tmpRG.DataSource
        NuovoID = tmpID
        dtCliente = DirectCast(DTclienti, DataTable)

        If NuovoID > 0 Then
            BS_clienti.Filter = "id = " & NuovoID
        End If

    End Sub
    Private Sub FRM_fattura_mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I_nuovoID As Integer
        If NuovoID < 1 Then
            Using ta As New DS_clientiTableAdapters.TA_cantieri_new
                I_nuovoID = ta.SP_UltimoID(G_idAz)
            End Using
            Dim RG As DS_clienti.DT_cantieri_newRow
            BS_clienti.AddNew()
            RG = DirectCast(BS_clienti.Current, DataRowView).Row
            RG.id = I_nuovoID + 1
            RG.data_inizio = Now
            RG.data_termine = DateAdd(DateInterval.Day, 365, Now)
            RG.state = "ITALIA"

            Me.IdTextBox.Text = RG.id
        End If
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Dim RG As DS_clienti.DT_cantieri_newRow
        BS_clienti.EndEdit()
        RG = DirectCast(BS_clienti.Current, DataRowView).Row
        If RG.RowState <> DataRowState.Unchanged Then
            If MsgBox("Sei sicuro di annullare le modifiche ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Me.Close()
            End If
        Else
            Me.Close()
        End If

    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        BS_clienti.EndEdit()
        If BS_clienti.Count = 0 Then
            Return
        End If
        Dim tt As DS_clienti.DT_cantieri_newRow
        tt = DirectCast(BS_clienti.Current, DataRowView).Row
        If tt.societa.Length = 0 Then
            MsgBox("Inserisci un valore valido")
            Return
        End If
        Select Case tt.RowState
            Case DataRowState.Added
                tt = controlloCantiere(tt)
                Dim ris As Integer = TA_cantieri_new.QR_Inserisce(tt.id, tt.imei, tt.societa,
                                     tt.address, tt.postalcode,
                                     tt.city, tt._region, tt.state, tt.title, tt.email_name,
                                     tt.first_name, tt.partitaiva, tt.work_phone, tt.work_extension,
                                     tt.home_phone, tt.mobile_phone, tt.fax_number, tt.pagamento,
                                     tt.bancaappog, tt.data_inizio, tt.data_termine,
                                     tt.contabilita, tt.attivo, tt.budget, tt.condomino, tt.l_mobile, tt.pa, G_idAz, tt.id_UQ)
                If ris < 0 Then
                    MsgBox("non riuscito l'inserimento")
                End If
                tt.AcceptChanges()
            Case DataRowState.Modified
                tt = controlloCantiere(tt)
                Dim ris As Integer = TA_cantieri_new.QR_Modifica(tt.societa, tt.address, tt.postalcode, tt.city,
                                       tt._region, tt.state, tt.title, tt.email_name, tt.first_name, tt.partitaiva,
                                       tt.work_phone, tt.work_extension, tt.home_phone, tt.mobile_phone,
                                       tt.fax_number, tt.pagamento, tt.bancaappog, tt.data_inizio, tt.data_termine,
                                       tt.contabilita, tt.attivo, tt.budget, tt.condomino, tt.l_mobile, tt.data_creazione, tt.pa,
                                       tt.id_UQ, tt.id)
                tt.AcceptChanges()
        End Select
        Me.Close()
    End Sub
    Private Function controlloCantiere(Optional ByRef O As DS_clienti.DT_cantieri_newRow = Nothing)
        O.data_inizio = If(O.Isdata_inizioNull, Now.ToShortDateString, O.data_inizio)
        O.data_termine = If(O.Isdata_termineNull, Now.AddDays(365).ToShortDateString, O.data_termine)
        O.data_creazione = If(O.Isdata_creazioneNull, Now.AddDays(365).ToShortDateString, O.data_creazione)
        O.imei = If(O.IsimeiNull, "0000", O.imei)
        O.address = If(O.IsaddressNull, "", O.address)
        O.postalcode = If(O.IspostalcodeNull, "00000", O.postalcode)
        O.city = If(O.IscityNull, "", O.city)
        O._region = If(O.Is_regionNull, "MI", O._region)
        O.state = If(O.IsstateNull, "ITALIA", O.state)
        O.title = If(O.IstitleNull, "Sig.", O.title)
        O.email_name = If(O.Isemail_nameNull, "@", O.email_name)
        O.first_name = If(O.Isfirst_nameNull, "", O.first_name)
        O.partitaiva = If(O.IspartitaivaNull, "", O.partitaiva)
        O.work_phone = If(O.Iswork_phoneNull, "", O.work_phone)
        O.work_extension = If(O.Iswork_extensionNull, "", O.work_extension)
        O.home_phone = If(O.Ishome_phoneNull, "", O.home_phone)
        O.mobile_phone = If(O.Ismobile_phoneNull, "", O.mobile_phone)
        O.fax_number = If(O.Isfax_numberNull, "", O.fax_number)
        O.pagamento = If(O.IspagamentoNull, 1, O.pagamento)
        O.bancaappog = If(O.IsbancaappogNull, "", O.bancaappog)
        O.contabilita = If(O.IscontabilitaNull, "", O.contabilita)
        O.attivo = If(O.IsattivoNull, 1, O.attivo)
        O.budget = If(O.IsbudgetNull, 1, O.budget)
        O.condomino = If(O.IscondominoNull, 0, O.condomino)
        O.pa = If(O.IspaNull, 0, O.pa)
        Return O
    End Function

    Private Sub TitleTextBox_TextChanged(sender As Object, e As EventArgs) Handles TitleTextBox.Validated
        Dim TT As TextBox
        TT = DirectCast(sender, TextBox)
        If TT.Text.Length > 6 Then
            TT.Text = TT.Text.Substring(0, 6)
        End If
    End Sub

    Private Sub TTBTannulla_Click(sender As Object, e As EventArgs) Handles TTBTannulla.Click
        BS_clienti.CancelEdit()
        Me.Close()
    End Sub
    '
    '   Controlla se i pulsanti sono stati premuti e li colora.
    '
    Private Sub ControlloBox_CheckedChanged(sender As Object, e As EventArgs) Handles AttivoCheckBox.CheckedChanged, BudgetCheckBox.CheckedChanged, CondominoCheckBox.CheckedChanged, L_mobileCheckBox.CheckedChanged
        Dim CK As CheckBox
        CK = DirectCast(sender, CheckBox)
        If CK.Checked Then
            CK.BackColor = Color.GreenYellow
        Else
            CK.BackColor = Color.DarkRed
        End If
    End Sub
End Class