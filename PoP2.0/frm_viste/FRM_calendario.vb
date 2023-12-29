
Public Class frm_calendario

    Private Sub frm_calendario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_cal.Fill(Me.DS_utenti.DT_cal)

        cmb_anno.SelectedItem = GlobalVarPOP.GPeriodo.Split("-").First.ToString
    End Sub

    Private Sub btn_genera_Click(sender As Object, e As EventArgs) Handles btn_genera.Click
        Dim dt_fine As DateTime
        Dim dt_ciclo As DateTime
        Dim anno As Integer
        anno = cmb_anno.SelectedItem
        dt_fine = DateSerial(anno, 12, 31)
        dt_ciclo = DateSerial(anno, 1, 1)
        Dim risp As Integer = bsCal.Find("giorno", dt_fine)
        ProgressBar1.Value = 0
        If risp > 0 Then
            MsgBox("Esiste Già il calendario di quest'anno")
        Else
            ProgressBar1.Maximum = DateDiff(DateInterval.Day, dt_ciclo, dt_fine)
            Dim xx As Integer = 0
            Do While dt_ciclo <= dt_fine
                TA_cal.inserisce(dt_ciclo, " ", 0)
                dt_ciclo = dt_ciclo.AddDays(1)
                ProgressBar1.Value = xx
                Application.DoEvents()
                xx += 1
            Loop
        End If
        Me.TA_cal.Fill(Me.DS_utenti.DT_cal)
        ProgressBar1.Value = 0
    End Sub

    Private Sub DT_calDataGridView_CellContentClick(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgCalendario.CellValidating
        bsCal.EndEdit()
        If dgCalendario.Columns(e.ColumnIndex).Name = DGWCfesta.Name Then
            Dim rg As DS_utenti.DT_calRow = DirectCast(bsCal.Current, DataRowView).Row
            rg.festivo = If(e.FormattedValue.ToString.Trim.Length > 0, 1, 0)
            rg.festa = e.FormattedValue.ToString.Trim
            'Dim giorno As DateTime = dgCalendario(DGWCgiorno.Index, e.RowIndex).Value


            TA_cal.modifica(rg.giorno, rg.festa, rg.festivo, rg.id)
            rg.AcceptChanges()
        End If

    End Sub
End Class