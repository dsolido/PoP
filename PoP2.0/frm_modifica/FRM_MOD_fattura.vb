Public Class FRM_mod_fattura
    Friend RG_fat As DS_fattura.DT_fatturaRow
    Friend Modificato As Boolean

    Public Sub New(Optional ByRef tmpRG As DS_fattura.DT_fatturaRow = Nothing)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        RG_fat = tmpRG
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

        '
    End Sub
    Private Sub FRM_fattura_mod_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TA_pagamenti.Fill(Me.DS_fattura.DT_pagamenti)
        P_popolaTxt()
    End Sub
    Private Sub P_popolaTxt()
        TA_cantieri.Fill(Me.DS_fattura.DT_cantieri)
        BS_cantieri.Position = BS_cantieri.Find("id", RG_fat.fat_cli_id)
        BS_pagamenti.Position = BS_pagamenti.Find("id", RG_fat.fat_cod_paga)
        TX_num_da.Text = RG_fat.fat_num_da
        TX_fat_da.Text = RG_fat.fat_data
        'Posiziona sul cantiere corretto
        TX_scadenza.Text = RG_fat.fat_scad
        TX_pagamento.Text = DirectCast(BS_pagamenti.Current, DataRowView).Row.Item("des")
        CK_pagata.CheckState = RG_fat.fat_paga
        CK_nc.CheckState = RG_fat.fat_nc
        CK_condominio.CheckState = RG_fat.fat_con_l
        TX_pagamento_data.Text = RG_fat.fat_pa_dat
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Select Case True
            Case RG_fat.fat_cli_id <> ComboBox1.SelectedValue
                Modificato = True
            Case RG_fat.fat_nc <> CK_nc.Checked
                Modificato = True
            Case RG_fat.fat_data <> TX_fat_da.Text
                Modificato = True
            Case RG_fat.fat_scad <> TX_scadenza.Text
                Modificato = True
            Case Else
        End Select
        If Modificato Then
            RG_fat.fat_cli_id = ComboBox1.SelectedValue
            RG_fat.fat_nc = CK_nc.Checked
            RG_fat.fat_data = TX_fat_da.Text
            RG_fat.fat_scad = TX_scadenza.Text
        End If
        Me.Close()
    End Sub

    Private Sub TX_cliente_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub BT_cliente_Click(sender As Object, e As EventArgs) Handles BT_cliente.Click
        'TODO inserire la modifica del cliente
        ComboBox1.Enabled = Not ComboBox1.Enabled
    End Sub

    Private Sub BT_pagamenti_Click(sender As Object, e As EventArgs) Handles BT_pagamenti.Click
        Dim f As New FRM_selezionapagamenti(RG_fat)
        f.ShowDialog()
        BS_pagamenti.Position = BS_pagamenti.Find("id", RG_fat.fat_cod_paga)
        TX_pagamento.Text = DirectCast(BS_pagamenti.Current, DataRowView).Row.Item("des")
        TX_scadenza.Text = RG_fat.fat_scad
    End Sub

    Private Sub CK_condominio_CheckedChanged(sender As Object, e As EventArgs) Handles CK_condominio.CheckedChanged, CK_pagata.CheckedChanged,
                                                                                        CK_nc.CheckedChanged
        RG_fat.fat_nc = CK_nc.CheckState
        RG_fat.fat_con_l = CK_condominio.CheckState
        RG_fat.fat_paga = CK_pagata.CheckState
    End Sub
    Private Sub TX_fat_da_TextChanged(sender As Object, e As EventArgs) Handles TX_fat_da.LostFocus
        Try
            RG_fat.fat_data = CType(TX_fat_da.Text, DateTime)
        Catch ex As Exception
            MsgBox("Data Fattura non Valida")
        End Try
    End Sub
    Private Sub TX_scadenza_TextChanged(sender As Object, e As EventArgs) Handles TX_scadenza.LostFocus
        Try
            RG_fat.fat_scad = CType(TX_scadenza.Text, DateTime)
        Catch ex As Exception
            MsgBox("Data Scadenza Fattura non Valida")
        End Try

    End Sub
End Class