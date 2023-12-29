Public Class frmCantieriRese
    Dim G_idAZ = GlobalVarPOP.G_idAZ
    Dim Periodo As String = GlobalVarPOP.GPeriodo
    Dim dtOre As New DS_fattura.DT_oreDataTable
    Dim dtres As New DS_fattura.DT_reseDataTable
    Dim dtPre As New DS_fattura.dtPresenzeDataTable

    Private Sub FRM_Clienti_Rese_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: questa riga di codice carica i dati nella tabella 'DS_utenti.DT_tipologia'. È possibile spostarla o rimuoverla se necessario.
        Me.TA_tipologia.mostra(Me.DS_utenti.DT_tipologia)
        'TODO: questa riga di codice carica i dati nella tabella 'DS_ag.dtTipo'. È possibile spostarla o rimuoverla se necessario.
        Me.TaTipo.Fill(Me.DS_ag.dtTipo)

        Me.TA_fattura_tipo.Fill(Me.DS_fattura.DT_fattura_tipo)
        Dim anno As Integer = Periodo.Split("-").First

        For sA As Integer = anno To anno - 10 Step -1
            cmbAnno.Items.Add(sA)
        Next

        cmbAnno.SelectedItem = anno
        Me.TA_ClientiFatturanti.FillClientiFatturantiPeriodo(Me.DS_clienti.DT_ClientiFatturanti, cmbAnno.SelectedItem, GlobalVarPOP.G_idAZ)

        Aggiornatutto()
        AddHandler BS_clienti.PositionChanged, AddressOf AggiornaDataGrid

    End Sub
    Private Sub Aggiornatutto()

        Dim idTipo As Int16
        idTipo = CB_selezionatipofattura.SelectedValue

        Dim RGcli As DS_clienti.DT_ClientiFatturantiRow
        If BS_clienti.Count <= 0 Then
            Return
        End If
        Dim Anno As String = cmbAnno.SelectedItem
        RGcli = DirectCast(BS_clienti.Current, DataRowView).Row
        Dim idCliente As Integer = RGcli.id

        Using taPresenze As New DS_fatturaTableAdapters.taPresenze
            taPresenze.FillByPeriodo(dtPre, Periodo)
        End Using

        Using taRes As New DS_fatturaTableAdapters.TA_rese
            Me.TA_rese.FillByAnnoGroupTipoMese(dtres, Anno)
            'DGWfatturato.Columns(DGWCdettaglio.Index).Visible = False
        End Using
        PopolaDGWFatturato(dtPre, dtres)
        CalcolaTotali(dtPre, dtres)
        GeneraTabella(dtPre, dtres)
    End Sub


    Private Sub PopolaDGWFatturato(ByRef dtPre As DS_fattura.dtPresenzeDataTable, ByRef dtRes As DS_fattura.DT_reseDataTable)
        DGWfatturato.Rows.Clear()
        Dim rgDGW As DataGridViewRow
        DGWfatturato.AllowUserToAddRows = True
        Dim ore(11) As Decimal
        Dim Resa(11) As Decimal
        Dim Imponibile(11) As Decimal
        Dim sMese(11) As String
        Dim idCli As Int16
        idCli = DirectCast(BS_clienti.Current, DataRowView).Row.Item("id")
        For mese = 0 To 11
            ore(mese) = 0
            Resa(mese) = 0
            Imponibile(mese) = 0
        Next

        For mese = 0 To 11

            Dim pr = From f In dtPre Where f.data.Month = mese + 1 And f.id_terminale = idCli
                     Group By mm = f.data.Month, f.inviato Into Group
                     Select mm, inviato, Totale = Group.Sum(Function(f) f.totale)

            Dim gg = From f In dtRes Where f.Data.Month = mese + 1 And f.IDcli = idCli
                     Group By mm = f.Data.Month, tipo = f.cfa_tipo Into Group
                     Select mm, tipo, Totale = Group.Sum(Function(f) f.Importo)

            For Each r In pr
                If ckTipoFatturato.Checked Then
                    If cmbTipoOre.SelectedValue = r.inviato Then
                        ore(mese) += r.Totale
                    End If
                    Else
                    ore(mese) += r.Totale
                End If
            Next
            For Each r In gg
                If ckTipoFatturato.Checked Then
                    If CB_selezionatipofattura.SelectedValue = r.tipo Then
                        Imponibile(mese) += r.Totale
                    End If
                Else
                    Imponibile(mese) += r.Totale
                End If
            Next


            sMese(mese) = MonthName(mese + 1)
            If ore(mese) = 0 Then
                Resa(mese) = Imponibile(mese) / 1
            Else
                Resa(mese) = Imponibile(mese) / ore(mese)
            End If

            rgDGW = DGWfatturato.Rows(DGWfatturato.NewRowIndex).Clone
            rgDGW.Cells(DGWCdettaglio.Index).Value = "--"
            rgDGW.Cells(DGWCMese.Index).Value = sMese(mese).ToUpperInvariant
            rgDGW.Cells(DGWCTotaleImporto.Index).Value = IIf(Imponibile(mese) <> 0, Imponibile(mese).ToString("c2"), "")
            rgDGW.Cells(DGWCTotaleOre.Index).Value = IIf(ore(mese) > 0, ore(mese), "")
            rgDGW.Cells(DGWCresaOraria.Index).Value = IIf(Resa(mese) > 0, Resa(mese).ToString("n2"), "")
            DGWfatturato.Rows.Add(rgDGW)
        Next



        If ckTipoFatturato.Checked Then
            '            rgDGW.Cells(DGWCdettaglio.Index).Value = rgResa.Locazione
        Else
        End If

        DGWfatturato.Rows.Add()
        rgDGW = DGWfatturato.Rows(DGWfatturato.NewRowIndex).Clone
        If Not ckTipoFatturato.Checked Then
            Dim Cliente As String
            Cliente = DirectCast(BS_clienti.Current, DataRowView).Row.Item("societa")
            rgDGW.Cells(DGWCdettaglio.Index).Value = "Riepilogo " & Cliente & " :"
        Else
            If CB_selezionatipofattura.Items.Count > 0 Then
                Dim tmpRigaTipo As DataRowView
                tmpRigaTipo = CB_selezionatipofattura.SelectedItem
                If Not IsNothing(tmpRigaTipo) Then
                    rgDGW.Cells(DGWCdettaglio.Index).Value = "Riepilogo " & tmpRigaTipo.Row.Field(Of String)("descrizione") & " :"
                End If

            End If

        End If
            rgDGW.Cells(DGWCMese.Index).Value = cmbAnno.SelectedItem
        rgDGW.Cells(DGWCTotaleImporto.Index).Value = Imponibile.Sum().ToString("c2")
        rgDGW.Cells(DGWCTotaleOre.Index).Value = ore.Sum().ToString("n2")
        Dim tmpOre As Decimal
        tmpOre = IIf(ore.Sum() = 0, 1, ore.Sum())

        rgDGW.Cells(DGWCresaOraria.Index).Value = (Imponibile.Sum() / tmpOre).ToString("c2")
        DGWfatturato.Rows.Add(rgDGW)
        DGWfatturato.AllowUserToAddRows = False
    End Sub

    Private Sub CalcolaTotali(dtPre As DS_fattura.dtPresenzeDataTable, ByRef dtRes As DS_fattura.DT_reseDataTable)
        Dim totOre As Decimal
        Dim totFat As Decimal

        If dtPre.Rows.Count > 0 Then
            Dim pr = From f In dtPre
                     Group By f.data.Year, f.inviato Into Group
                     Select inviato, Totale = Group.Sum(Function(f) f.totale)

            For Each tot In pr
                If ckTipoFatturato.Checked Then
                    If tot.inviato = cmbTipoOre.SelectedValue Then
                        totOre += tot.Totale
                    End If
                Else
                    totOre += tot.Totale
                End If
            Next
        Else
            MsgBox("Non sono presenti Ore nel periodo selezionato")
        End If

        If dtRes.Rows.Count > 0 Then
            Dim rr = From f In dtRes
                     Group By f.Data.Year, f.cfa_tipo Into Group
                     Select cfa_tipo, Totale = Group.Sum(Function(f) f.Importo)

            For Each tot In rr
                If ckTipoFatturato.Checked Then
                    Dim idTipo As Int16
                    idTipo = CB_selezionatipofattura.SelectedValue
                    If tot.cfa_tipo = idTipo Then
                        totOre += tot.Totale
                    End If
                Else
                    totOre += tot.Totale
                End If
            Next



            Dim dImporto As Decimal
            For Each tot In dtRes.Rows
                dImporto += tot.Importo
            Next
            totFat = dImporto
        Else
            MsgBox("Non sono presenti Fatture nel periodo selezionato")
            Me.Close()
        End If
        LB_ore.Text = totOre.ToString("N2")
        LB_importo.Text = "Fatturato Tot :" & totFat.ToString("C2")
        totOre = IIf(totOre = 0, 1, totOre)
        LB_resa.Text = (totFat / totOre).ToString("C2")

    End Sub
    Private Sub GeneraTabella(ByRef dtPresenze As DS_fattura.dtPresenzeDataTable, ByRef dtRese As DS_fattura.DT_reseDataTable)
        If Chart1.Series.Count = 0 Then
            Return
        End If
        Call ImpostaGrafico()

        Chart1.Series(0).Points.Clear()
        Chart1.Series(1).Points.Clear()
        Chart1.Series(2).Points.Clear()

        Dim rgOre As DS_fattura.DT_oreRow
        Dim rgRes As DS_fattura.DT_reseRow
        Dim TotResa As Decimal
        Dim tmpImporto As Decimal
        Dim tmpOre As Decimal
        Dim mese As String = ""

        Using taPresenze As New DS_fatturaTableAdapters.taPresenze
            taPresenze.FillByPeriodo(dtPresenze, Periodo)
        End Using

        Using taFatture As New DS_fatturaTableAdapters.TA_rese
            If ckTipoFatturato.Checked Then
                'taFatture.FillByTotaleAnnuoPerTipologia(dtRese, Periodo, CB_selezionatipofattura.SelectedValue)
            Else
                taFatture.FillByAnnoGroupTipoMese(dtRese, Periodo)
            End If
        End Using

        Dim q = From v In dtPresenze
                Group v By mm = v.data.Month, v.inviato Into Group
                Select mm, inviato,
                    Totale = Group.Sum(Function(v) v.uscita.TotalHours - v.ingresso.TotalHours)
        Dim r = From v In dtRese
                Group v By mm = v.Mese Into Group
                Select mm,
                    Totale = Group.Sum(Function(v) v.Importo)


        For k = 1 To 13
            mese = k.ToString.PadLeft(2, "0")
            tmpOre = 0
            tmpImporto = 0

            For Each totO In q
                If k = totO.mm Then
                    tmpOre += totO.Totale
                End If

            Next
            For Each totO In r
                If k = totO.mm Then
                    tmpImporto += totO.Totale
                End If
            Next

            Try
                TotResa = tmpImporto / tmpOre
            Catch ex As Exception
                TotResa = 0
            End Try
            Chart1.Series(0).Points.AddXY(k, TotResa.ToString("C"))
            Chart1.Series(1).Points.AddXY(k, tmpOre.ToString("C"))
            Chart1.Series(2).Points.AddXY(k, (tmpImporto / 10).ToString("C")) 'Crea una scala per rendere il grafico piacevole
        Next
        'Chart1.ChartAreas(0).AxisX.LabelStyle.Angle = -90
        Chart1.Series(0).IsValueShownAsLabel = True
        Chart1.Series(1).IsValueShownAsLabel = True
        Chart1.Series(2).IsValueShownAsLabel = True
        Chart1.Series(0).LabelAngle = 90
        Chart1.Series(0).LegendText = "Resa Oraria"
        Chart1.Series(1).LegendText = "Ore Mese"
        Chart1.Series(2).LegendText = "Importo / 10"
    End Sub

    Private Sub ImpostaGrafico()
        If Chart1.ChartAreas.Count > 0 Then
            With Chart1.ChartAreas(0)
                .AxisX.Minimum = 1
                .AxisX.Maximum = 12
                .AxisX.Interval = 1
                .AxisY.Minimum = 0
                .AxisX.Title = "Mesi"
                .AxisY.Title = "Resa"

            End With
        End If

    End Sub

    Private Sub CB_selezionatipofattura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_selezionatipofattura.SelectedIndexChanged
        AggiornaDataGrid()
    End Sub

    Private Sub cmbAnno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAnno.SelectedIndexChanged
        DGWfatturato.Rows.Clear()
        Periodo = cmbAnno.SelectedItem.ToString
        Me.TA_ClientiFatturanti.FillClientiFatturantiPeriodo(Me.DS_clienti.DT_ClientiFatturanti, Periodo, G_idAZ)
        Aggiornatutto()
    End Sub

    Private Sub AggiornaDataGrid()
        DGWfatturato.Rows.Clear()
        PopolaDGWFatturato(dtPre, dtres)
    End Sub

    Private Sub cmbTipoOre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbTipoOre.SelectedIndexChanged
        AggiornaDataGrid()
    End Sub
End Class