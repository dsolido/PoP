Public Class FRM_selezionapagamenti
    Dim RFattura As DS_fattura.DT_fatturaRow
    Public Sub New(Optional ByRef cg As DataRow = Nothing)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        RFattura = cg
    End Sub
    Private Sub FRM_selezionapagamenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_pagamenti_new.Fill(Me.DS_clienti.DT_pagamenti_new)
        TX_ricerca.Focus()
    End Sub
    Private Sub TX_ricerca_TextChanged(sender As Object, e As EventArgs) Handles TX_ricerca.TextChanged
        Dim testo As TextBox
        testo = DirectCast(sender, TextBox)
        Dim ricerca As String = testo.Text.Trim
        Dim valore As Integer = 0
        Dim I_Ricerca As Integer = testo.Text.Length
        Do While True
            ricerca = ricerca.Substring(0, ricerca.Length - valore)
            testo.Text = ricerca
            testo.SelectionStart = ricerca.Length
            BS_pagamenti.Filter = String.Format("des LIKE '%{0}%'", ricerca)
            If BS_pagamenti.Count > 0 Then
                Exit Do
            Else
                valore += 1
                If I_Ricerca < valore Then
                    BS_pagamenti.RemoveFilter()
                    MsgBox("Nessun Filtro applicabile")
                    Exit Do
                End If
            End If
        Loop
    End Sub
    Private Sub TX_ricerca_TextInvio(sender As Object, e As KeyEventArgs) Handles TX_ricerca.KeyDown
        Dim rg As DS_clienti.DT_pagamenti_newRow
        rg = DirectCast(BS_pagamenti.Current, DataRowView).Row

        If e.KeyCode = Keys.Enter Then
            If MsgBox("Confermi il tipo di pagamento " & rg.des, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                BT_termina.PerformClick()
            End If
        End If
    End Sub

    Private Sub BT_termina_Click(sender As Object, e As EventArgs) Handles BT_termina.Click
        Dim rg As DS_clienti.DT_pagamenti_newRow
        rg = DirectCast(BS_pagamenti.Current, DataRowView).Row
        RFattura.fat_scad = DateAdd(DateInterval.Day, rg.num, RFattura.fat_data)
        RFattura.fat_scad = DateSerial(RFattura.fat_scad.Year, RFattura.fat_scad.Month, 0)
        RFattura.fat_cod_paga = rg.id

        Me.Close()
    End Sub
End Class