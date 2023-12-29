Public Class frmAggiungeAziendaAutofattura
    Dim percorso As String
    Dim tipoTDFattura As String
    Private Sub frmAggiungeAziendaAutofattura_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TaFatturaCodiciTD.Fill(Me.DS_fattura.dtFatturaCodiciTD)
        Me.TA_iva.Fill(Me.DS_fattura.DT_iva)
        Me.TA_pagamenti.Fill(Me.DS_fattura.DT_pagamenti)
        Me.TA_azienda.FillByAutofatturazione(Me.DS_FE.DT_azienda)
        Me.TaFatturaRigheAutofattura.Fill(Me.DS_FE.dtFatturaRigheAutofattura)
        Me.TaFatturaAutofattura.Fill(Me.DS_FE.dtFatturaAutofattura)
        ComboBox1.SelectedIndex = 7
    End Sub

    Private Sub dgwAzienda_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwAzienda.RowValidating
        Dim f As New funzioni

        Try
            bsAzienda.EndEdit()
        Catch ex As Exception
            MsgBox("Controlla i campi, c'è qualcosa che non quadra")
            Return
        End Try

        Dim rg As DS_FE.DT_aziendaRow
        rg = DirectCast(bsAzienda.Current, DataRowView).Row
        If rg.RowState = DataRowState.Added Then
            If rg.Isragione_socialeNull Then
                bsAzienda.CancelEdit()
                Return
            End If
            TA_azienda.InsertQuery(f.Ctrlval(rg, "ragione_sociale"), f.Ctrlval(rg, "indirizzo_leg"), f.Ctrlval(rg, "localita_leg"), f.Ctrlval(rg, "cap_leg"), f.Ctrlval(rg, "provincia_leg"),
                        f.Ctrlval(rg, "valore_IVA"), f.Ctrlval(rg, "valore_ritenuta"), f.Ctrlval(rg, "partita_IVA"), f.Ctrlval(rg, "codicefiscale"), f.Ctrlval(rg, "Nazione"), 1)
            rg.id = TA_azienda.UltimoID()
            rg.AcceptChanges()

        ElseIf rg.RowState = DataRowState.Modified Then
            If rg.IsautofatturazioneNull Then
                Return
            End If
            TA_azienda.UpdateQuery(f.Ctrlval(rg, "ragione_sociale"), f.Ctrlval(rg, "indirizzo_leg"), f.Ctrlval(rg, "localita_leg"), f.Ctrlval(rg, "cap_leg"), f.Ctrlval(rg, "provincia_leg"),
                        f.Ctrlval(rg, "valore_IVA"), f.Ctrlval(rg, "valore_ritenuta"), f.Ctrlval(rg, "partita_IVA"), f.Ctrlval(rg, "codicefiscale"), f.Ctrlval(rg, "Nazione"), rg.autofatturazione, rg.id)
            rg.AcceptChanges()
        End If
    End Sub


    Private Sub dgwFattura_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwFatturaAutofattura.RowValidating

        Try
            rbsFatturaAutofattura.EndEdit()
        Catch ex As Exception
            MsgBox("Controlla i campi, c'è qualcosa che non quadra")
            Return
        End Try

        Dim rg As DS_FE.dtFatturaAutofatturaRow
        rg = DirectCast(rbsFatturaAutofattura.Current, DataRowView).Row

        If rg.RowState = DataRowState.Unchanged Then
            Return
        End If
        Dim f As New funzioni
        Dim anno As Int16 = GlobalVarPOP.GPeriodo.Split("-").First

        Dim nFat As Integer = TaFatturaAutofattura.UltimonumeroFattura(anno) + 1
        Dim numeroFatt As String = "A" & nFat.ToString.PadLeft(4, "000") + "/" + anno.ToString


        If rg.Isfat_dataNull Then
            rbsFatturaAutofattura.CancelEdit()
            Return
        End If

        If rg.RowState = DataRowState.Added Then
            TaFatturaAutofattura.InsertQuery(numeroFatt, rg.fat_cli_id, rg.fat_data, rg.fat_scad, f.Ctrlval(rg, "fat_paga"), rg.fat_pa_dat, f.Ctrlval(rg, "fat_pa_des"), If(rg.Isfat_cod_ivaNull, Nothing, rg.fat_cod_iva), rg.fat_cod_paga,
                                             f.Ctrlval(rg, "fat_nc"), f.Ctrlval(rg, "datainvio"), f.Ctrlval(rg, "note"))
            rg.fat_num_da = numeroFatt
            rg.id = TaFatturaAutofattura.ultimoID
            rg.AcceptChanges()

        ElseIf rg.RowState = DataRowState.Modified Then
            If rg.Isfat_dataNull Then
                Return
            End If
            TaFatturaAutofattura.UpdateQuery(rg.fat_num_da, rg.fat_cli_id, rg.fat_data, rg.fat_scad, f.Ctrlval(rg, "fat_paga"), rg.fat_pa_dat, f.Ctrlval(rg, "fat_pa_des"), If(rg.Isfat_cod_ivaNull, Nothing, rg.fat_cod_iva), rg.fat_cod_paga,
                                             f.Ctrlval(rg, "fat_nc"), rg.datainvio, f.Ctrlval(rg, "note"), rg.id)
            rg.AcceptChanges()
        End If

    End Sub
    Private Sub dgwFattura_righe_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwFatturaRigheAutofattura.RowValidating
        Dim f As New funzioni


        Try
            rbsFatturaRigheAutofattura.EndEdit()
        Catch ex As Exception
            MsgBox("Controlla i campi, c'è qualcosa che non quadra")
            Return
        End Try

        Dim rg As DS_FE.dtFatturaRigheAutofatturaRow
        rg = DirectCast(rbsFatturaRigheAutofattura.Current, DataRowView).Row
        If rg.Iscfa_desNull Then
            rbsFatturaRigheAutofattura.CancelEdit()
            Return
        End If
        Dim sort As Int16 = dgwFatturaRigheAutofattura.Rows.Count
        If rg.RowState = DataRowState.Added Then
            TaFatturaRigheAutofattura.InsertQuery(sort, rg.cfa_fa_num, f.Ctrlval(rg, "cfa_des"), If(rg.Iscfa_quantiNull, 1, rg.cfa_quanti), If(rg.Iscfa_prezzoNull, 1, rg.cfa_prezzo), If(rg.Iscfa_scontoNull, 0, rg.cfa_sconto), If(rg.Iscfa_rcNull, 1, rg.cfa_rc))
            rg.AcceptChanges()
        ElseIf rg.RowState = DataRowState.Modified Then
            If rg.IsordineNull Then
                Return
            End If
            TaFatturaRigheAutofattura.UpdateQuery(rg.ordine, rg.cfa_fa_num, f.Ctrlval(rg, "cfa_des"), If(rg.Iscfa_quantiNull, 1, rg.cfa_quanti), If(rg.Iscfa_prezzoNull, 1, rg.cfa_prezzo), If(rg.Iscfa_scontoNull, 0, rg.cfa_sconto), If(rg.Iscfa_rcNull, 1, rg.cfa_rc), rg.id)
            rg.AcceptChanges()
        End If

    End Sub

    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        If rbsFatturaAutofattura.Count() > 0 Then
            CiclaFatture()
        End If
    End Sub
    Private Sub CiclaFatture()
        percorso = TrovaCartella("F:\")
        ' il prestatore in questo caso è il Fornitore Estero
        Dim rg_prestatore As DS_FE.DT_aziendaRow
        rg_prestatore = DirectCast(bsAzienda.Current, DataRowView).Row

        ' il Cessionario in questo caso è Pegaso
        Dim rg_cessionario As DS_FE.DT_aziendaRow
        Using dt As New DS_FE.DT_aziendaDataTable
            Using ta As New DS_FETableAdapters.TA_azienda
                'Seleziona solo le aziende non in autofatturazione (in questo caso Pegaso che è la prima
                ta.FillByAzienda(dt)
                rg_cessionario = dt.First
            End Using
        End Using

        'Il trasmittente è Aliquid
        Dim rg_trasmittente As DS_FE.DT_trasmittenteRow
        Using dt As New DS_FE.DT_trasmittenteDataTable
            Using ta As New DS_FETableAdapters.TA_trasmittente
                ta.Fill(dt)
                rg_trasmittente = dt.First
            End Using
        End Using

        For Each rg As DataGridViewRow In dgwFatturaAutofattura.SelectedRows
            Dim nf As String = rg.Cells(dgwcNumeroFattura.Index).Value
            Dim id As Integer = rg.Cells(dgwcIDfattura.Index).Value

            Dim Fattura As New DS_FE.dtFatturaAutofatturaDataTable
            Dim RigheFattura As New DS_FE.dtFatturaRigheAutofatturaDataTable

            Using TFE As New DS_FETableAdapters.taFatturaAutofattura
                Try
                    TFE.Fill(Fattura)
                Catch ex As Exception
                    Dim err As DataRow() = Fattura.GetErrors
                    For Each List In err
                        Console.WriteLine(List.RowError)
                    Next
                End Try
            End Using
            Dim tFattura As New DS_FE.dtFatturaAutofatturaDataTable
            Dim oFattura As DataTable = (From c In Fattura Where c.id = id Select c).CopyToDataTable
            For Each tRiga As DataRow In oFattura.Rows
                Dim r As DS_FE.dtFatturaAutofatturaRow
                r = tFattura.NewRow
                For Each nomeC As DataColumn In tFattura.Columns
                    r.Item(nomeC.ColumnName) = tRiga.Item(nomeC.ColumnName)
                Next
                tFattura.Rows.Add(r)
                r.AcceptChanges()
            Next
            Dim numeroFattura As String
            numeroFattura = tFattura.First.fat_num_da
            Dim rrff As EnumerableRowCollection
            Using TFR As New DS_FETableAdapters.taFatturaRigheAutofattura
                TFR.Fill(RigheFattura)
                rrff = From tv In RigheFattura Where tv.cfa_fa_num = numeroFattura
            End Using

            Dim f As New funzioni
            If tipoTDFattura = "" Then
                MsgBox("Seleziona prima il tipo di Fattura")
            Else
                f.AutofatturaXML(rg_trasmittente, rg_prestatore, rg_cessionario, tFattura, rrff, Me.DS_fattura.DT_iva, RigheFattura, Me.DS_fattura.DT_pagamenti, percorso, tipoTDFattura)
            End If

        Next
    End Sub
    Public Function TrovaCartella(ByRef nomeCartella As String) As String
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            nomeCartella = FolderBrowserDialog1.SelectedPath
        End If
        If FolderBrowserDialog1.SelectedPath.Trim.Length = 0 Then
            Return False
        Else
            Return nomeCartella
        End If

    End Function

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        dgwFatturaAutofattura.DataSource = ""
        Me.Close()
    End Sub
    Private Sub dgwFatturaRigheAutofattura_CellContentClick(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgwFatturaRigheAutofattura.UserDeletingRow
        If MsgBox("Vuoi eliminare la riga " & e.Row.Cells(dgwcDescrizioneRiga.Index).Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TaFatturaRigheAutofattura.DeleteQuery(e.Row.Cells(dgwcIDrighe.Index).Value)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub dgwAzienda_Deleting(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgwAzienda.UserDeletingRow
        If MsgBox("Vuoi eliminare il cliente/fornitore " & e.Row.Cells(dgwcragionesociale.Index).Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TA_azienda.DeleteQuery(e.Row.Cells(dgwcidAzienda.Index).Value)
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub dgwFattura_Deleting(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgwFatturaAutofattura.UserDeletingRow
        If MsgBox("Vuoi eliminare la Fattura " & e.Row.Cells(dgwcNumeroFattura.Index).Value, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TaFatturaAutofattura.DeleteQuery(e.Row.Cells(dgwcIDfattura.Index).Value)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        tipoTDFattura = ComboBox1.SelectedValue
    End Sub

    Private Sub ttxRicerca_Changed(sender As Object, e As EventArgs) Handles ttxRicerca.TextChanged
        bsAzienda.Filter = String.Format("ragione_sociale LIKE '%{0}%'", ttxRicerca.Text)
    End Sub

End Class