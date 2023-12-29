#Disable Warning CA1707 ' Gli identificatori non devono contenere caratteri di sottolineatura
Imports System.Windows.Forms.DataVisualization.Charting
Imports Pop2.Comuni

Public Class FrmPreventivo
    Dim dtTest As New DataTable
    Dim dsTest As New DataSet
    Dim lPreventivi
    Private Sub FrmPreventivo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txCostoOrario.Text = 19.8
        caricadati()
        Me.dgwDestinatari.Rows(1).Frozen = True
        AddHandler bsPreventiviDestinatari.CurrentChanged, AddressOf AggiornaDati

    End Sub
    Private Sub dgwPreventiviCercaOperazione(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewEditingControlShowingEventArgs) Handles dgwPreventivi.EditingControlShowing

        Dim dgw As DataGridView = dgwPreventivi
        Dim tt As DataGridViewCell
        tt = dgw.CurrentCell

        If tt.ColumnIndex <> dgwcOperazione.Index Then
            RemoveHandler e.Control.KeyPress, AddressOf cellTextBox_KeyPress
            '            Return
        Else
            AddHandler e.Control.KeyPress, AddressOf cellTextBox_KeyPress
        End If

    End Sub
    Private Sub cellTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Dim dgw As DataGridView = dgwPreventivi

        Dim txtbox As String = e.KeyChar
        Dim fr As New FrmCercaOperazionePulizie(bsPreventiviOperazioni, txtbox)
        fr.ShowDialog()
        Dim idOp As Int16 = fr.idOperazione
        Dim txOp As String = fr.txOperazione
        bsPreventiviOperazioni.Position = bsPreventiviOperazioni.Find("id", idOp)
        Dim rg As dsPreventivi.dtPreventiviOperazioniRow
        rg = DirectCast(bsPreventiviOperazioni.Current, DataRowView).Row
        dgw(dgwcID_Operazioni.Index, dgw.CurrentRow.Index).Value = idOp
        Dim eR As Int16 = dgw.CurrentRow.Index
        dgw(dgwcImpegnomq.Index, eR).Value = If(rg.IsimpegnometroquadroNull, Nothing, rg.impegnometroquadro)
        dgw(dgwcImpegnonumero.Index, eR).Value = If(rg.IsimpegnonumeroNull, Nothing, rg.impegnonumero)
        dgw(dgwcRisultato.Index, eR).Value = aggiornareseOrarie(If(rg.IsimpegnometroquadroNull, Nothing, rg.impegnometroquadro),
                                                                        If(rg.IsimpegnometroquadroNull, Nothing, rg.impegnometroquadro),
                                                                        If(IsDBNull(dgw(dgwcFreq.Index, eR).Value), Nothing, dgw(dgwcFreq.Index, eR).Value),
                                                                        If(IsDBNull(dgw(dgwcDimensioni.Index, eR).Value), Nothing, dgw(dgwcDimensioni.Index, eR).Value),
                                                                        If(IsDBNull(dgw(dgwcTaratura.Index, eR).Value), Nothing, dgw(dgwcTaratura.Index, eR).Value))
        dgw(dgwcFrequenza.Index, eR).Selected = True
        e.Handled = True
        sender.Text = txOp
        dgw.CurrentCell = dgw(dgwcFrequenza.Index, dgw.CurrentRow.Index)

    End Sub

    Private Sub caricadati()
        Me.TaPreventiviDimensioni.Fill(Me.DsPreventivi.dtPreventiviDimensioni)
        Me.TA_cantieri_new.FillByAttivi(Me.DS_clienti.DT_cantieri_new, GlobalVarPOP.G_idAZ, 1)
        Me.TA_locazione_new.Fill(Me.DS_clienti.DT_locazione_new, GlobalVarPOP.G_idAZ)
        Me.TaPreventiviCategorie.Fill(Me.DsPreventivi.dtPreventiviCategorie)
        Me.TaPreventiviFrequenze.Fill(Me.DsPreventivi.dtPreventiviFrequenze)
        Me.TaPreventiviOperazioni.Fill(Me.DsPreventivi.dtPreventiviOperazioni)
        Me.TaPreventiviAbbinamento.Fill(Me.DsPreventivi.dtPreventiviAbbinamento)
        Me.TaPreventivi.Fill(Me.DsPreventivi.dtPreventivi)
        Me.TaPreventiviDestinatari.Fill(Me.DsPreventivi.dtPreventiviDestinatari)
    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        bsPreventivi.CancelEdit()

        dgwDestinatari.DataSource = Nothing
        dgwPreventivi.DataSource = Nothing
        dgwDimensioni.DataSource = Nothing
        Me.Dispose()

    End Sub
    Private Sub dgwDeletingRow(ByVal sender As Object, ByVal e As DataGridViewRowCancelEventArgs) Handles dgwPreventivi.UserDeletingRow

        If MsgBox(String.Format("Confermi l'eliminazione della operazione: {0}", e.Row.Cells(dgwcOperazione.Index).Value), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TaPreventivi.DeleteQuery(e.Row.Cells(dgwcIDpreventivi.Index).Value)
            e.Cancel = False
        Else
            e.Cancel = True
        End If

    End Sub
    Private Sub dgwPreventivi_cellValidating(ByVal sender As Object, e As DataGridViewCellEventArgs) Handles dgwPreventivi.CellValidated
        Dim dgw As DataGridView = DirectCast(sender, DataGridView)
        Select Case e.ColumnIndex
            Case dgwcOperazione.Index
                Dim idOp As Integer
                idOp = If(IsDBNull(dgw(dgwcID_Operazioni.Index, e.RowIndex).Value), vbEmpty, dgw(dgwcID_Operazioni.Index, e.RowIndex).Value)

                If idOp <> vbEmpty Then
                    bsPreventiviOperazioni.Position = bsPreventiviOperazioni.Find("id", idOp)
                    Dim rgOp As dsPreventivi.dtPreventiviOperazioniRow
                    rgOp = DirectCast(bsPreventiviOperazioni.Current, DataRowView).Row
                    If rgOp.IsimpegnometroquadroNull = vbFalse Then
                        If IsDBNull(dgw(dgwcImpegnomq.Index, e.RowIndex).Value) <> vbTrue Then
                            If dgw(dgwcImpegnomq.Index, e.RowIndex).Value <> Nothing And dgw(dgwcImpegnomq.Index, e.RowIndex).Value <> rgOp.impegnometroquadro Then
                                If MsgBox("Impegno al m² già presente, vuoi reimpostarla ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    dgw(dgwcImpegnomq.Index, e.RowIndex).Value = rgOp.impegnometroquadro
                                End If
                            End If
                        Else
                            dgw(dgwcImpegnomq.Index, e.RowIndex).Value = rgOp.impegnometroquadro
                        End If
                    End If
                    If rgOp.IsimpegnonumeroNull = vbFalse Then
                        If IsDBNull(dgw(dgwcImpegnonumero.Index, e.RowIndex).Value) <> vbTrue Then
                            If dgw(dgwcImpegnonumero.Index, e.RowIndex).Value <> Nothing And dgw(dgwcImpegnonumero.Index, e.RowIndex).Value <> rgOp.impegnonumero Then
                                If MsgBox("Resa a numero già presente, vuoi reimpostarla ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                                    dgw(dgwcImpegnonumero.Index, e.RowIndex).Value = rgOp.impegnonumero
                                End If
                            End If
                        Else
                            dgw(dgwcImpegnonumero.Index, e.RowIndex).Value = rgOp.impegnonumero
                        End If
                    End If
                End If
            Case dgwcFrequenza.Index
                Dim idFr As Integer

                idFr = If(IsDBNull(dgw(dgwcFrequenza.Index, e.RowIndex).Value), Nothing, dgw(dgwcFrequenza.Index, e.RowIndex).Value)

                If idFr <> vbEmpty Then
                    bsPreventiviFrequenze.Position = bsPreventiviFrequenze.Find("id", idFr)
                    Dim rgFr As dsPreventivi.dtPreventiviFrequenzeRow
                    rgFr = DirectCast(bsPreventiviFrequenze.Current, DataRowView).Row
                    If rgFr.IsnumerointerventiNull = vbFalse Then
                        dgw(dgwcFreq.Index, e.RowIndex).Value = rgFr.numerointerventi
                    End If
                End If
            Case dgwcid_dimensioni.Index
                Dim idDi As Integer
                If IsDBNull(dgw(dgwcid_dimensioni.Index, e.RowIndex).Value) Then
                    Return
                End If
                idDi = dgw(dgwcid_dimensioni.Index, e.RowIndex).Value
                If idDi <> vbEmpty Then
                    bsPreventiviDimensioni.Position = bsPreventiviDimensioni.Find("id", idDi)
                    Dim rgDi As dsPreventivi.dtPreventiviDimensioniRow
                    rgDi = DirectCast(bsPreventiviDimensioni.Current, DataRowView).Row
                    If rgDi.IsdimensioniNull = vbFalse Then
                        dgw(dgwcDimensioni.Index, e.RowIndex).Value = rgDi.dimensioni
                    End If
                End If
        End Select
        dgw(dgwcRisultato.Index, e.RowIndex).Value = aggiornareseOrarie(If(IsDBNull(dgw(dgwcImpegnomq.Index, e.RowIndex).Value), Nothing, dgw(dgwcImpegnomq.Index, e.RowIndex).Value),
                                                                        If(IsDBNull(dgw(dgwcImpegnonumero.Index, e.RowIndex).Value), Nothing, dgw(dgwcImpegnonumero.Index, e.RowIndex).Value),
                                                                        If(IsDBNull(dgw(dgwcFreq.Index, e.RowIndex).Value), Nothing, dgw(dgwcFreq.Index, e.RowIndex).Value),
                                                                        If(IsDBNull(dgw(dgwcDimensioni.Index, e.RowIndex).Value), Nothing, dgw(dgwcDimensioni.Index, e.RowIndex).Value),
                                                                        If(IsDBNull(dgw(dgwcTaratura.Index, e.RowIndex).Value), Nothing, dgw(dgwcTaratura.Index, e.RowIndex).Value))
    End Sub
    Shared Function aggiornareseOrarie(ByVal impm As Decimal, ByVal impn As Decimal, ByVal freq As Int16, ByVal Dime As Decimal, ByVal Tara As Decimal) As Decimal
        If impm <> Nothing And impm <> 0 And freq <> Nothing And Dime <> Nothing Then
            aggiornareseOrarie = ((Dime / impm) / 60 * 100) + (((Dime / impm) / 60 * 100) * Tara / 100) '* freq / 100 * 60
        End If
        If impn <> Nothing And impn <> 0 And freq <> Nothing And Dime <> Nothing Then
            aggiornareseOrarie = ((Dime * impn / 60)) + (((Dime * impn / 60)) * Tara / 100) '* freq / 100 * 60
        End If
        Return IIf(IsDBNull(aggiornareseOrarie), 0, aggiornareseOrarie)
    End Function
    Private Sub AggiornaDati()
        Dim rgll As dsPreventivi.dtPreventiviDestinatariRow
        rgll = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row
        Dim pos As Int16
        pos = bsPreventiviabbinamento.Find("id_destinatario_preventivo", rgll.id)
        Dim rgrr As dsPreventivi.dtPreventiviAbbinamentoRow
        If pos > 0 Then
            lbClienteAbbinato.Items.Clear()
            For Each rigaAbbinamento In bsPreventiviabbinamento
                rgrr = DirectCast(rigaAbbinamento, DataRowView).Row
                If rgrr.id_destinatario_preventivo = rgll.id Then
                    lbClienteAbbinato.Items.Add(rgrr.destinatario)
                End If
            Next
            gbAbbinamentoCliente.Visible = True
            btEliminaAbbinamento.Visible = True
        Else
            lbClienteAbbinato.Items.Clear()
            gbAbbinamentoCliente.Visible = True
            btEliminaAbbinamento.Visible = False
        End If

    End Sub
    Private Sub dgwPreventivi_RowValidating(ByVal sender As Object, e As DataGridViewCellEventArgs) Handles dgwPreventivi.RowValidated
        If bsRelPreventiviDestinatariPreventivi.Count > 0 Then
            Dim rg As dsPreventivi.dtPreventiviRow
            '            bsRelPreventiviDestinatariPreventivi.EndEdit()
            bsRelPreventiviDestinatariPreventivi.EndEdit()
            rg = DirectCast(bsRelPreventiviDestinatariPreventivi.Current, DataRowView).Row
            'rg.id_destinatario = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row.Field(Of Int16)("id")
            Select Case rg.RowState
                Case DataRowState.Added
                    Dim ultimoSort As Integer = TaPreventivi.SQultimoOrdine(rg.id_destinatario) + 1

                    dgwPreventivi(dgwcSortPreventivi.Index, e.RowIndex).Value = ultimoSort
                    bsRelPreventiviDestinatariPreventivi.EndEdit()
                    TaPreventivi.InsertQuery(rg.id_operazioni, rg.id_destinatario, If(rg.IsdataNull, Now(), rg.data), If(rg.IsnoteNull, Nothing, rg.note),
                                             If(rg.IsprezzoNull, 0, rg.prezzo), rg.id_frequenza, rg.id_categoria, rg.sort, rg.id_dimensioni, If(rg.IsimpegnomqNull, Nothing, rg.impegnomq),
                                             If(rg.IsimpegnonumeroNull, Nothing, rg.impegnonumero), If(rg.IsdimensioniNull, Nothing, rg.dimensioni), If(rg.IsvisibileNull, 0, rg.visibile),
                                             If(rg.IstaraturaNull, Nothing, rg.taratura))
                    rg.id = TaPreventivi.SQultimoID()
                    rg.AcceptChanges()

                Case DataRowState.Modified
                    TaPreventivi.UpdateQuery(rg.id_operazioni, rg.id_destinatario, If(rg.IsdataNull, Now(), rg.data), If(rg.IsnoteNull, Nothing, rg.note), If(rg.IsprezzoNull, 0, rg.prezzo), rg.id_frequenza,
                                             rg.id_categoria, rg.sort, rg.id_dimensioni, If(rg.IsimpegnomqNull, Nothing, rg.impegnomq),
                                             If(rg.IsimpegnonumeroNull, Nothing, rg.impegnonumero), If(rg.IsdimensioniNull, Nothing, rg.dimensioni),
                                             If(rg.IsvisibileNull, 0, rg.visibile),
                                             If(rg.IstaraturaNull, Nothing, rg.taratura), rg.id)
                    rg.AcceptChanges()
            End Select
        End If

    End Sub
    Private Sub dgwDimensioni_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDimensioni.RowValidated
        If relPreventiviDestinatariPreventiviDimensioni.Count > 0 Then
            Dim rg As dsPreventivi.dtPreventiviDimensioniRow
            rg = DirectCast(relPreventiviDestinatariPreventiviDimensioni.Current, DataRowView).Row
            Dim dimensioni As Decimal
            dimensioni = If(rg.IsdimensioniNull, 0, rg.dimensioni)
            Select Case rg.RowState
                Case DataRowState.Added
                    TaPreventiviDimensioni.InsertQuery(rg.id_preventivo, rg.descrizione, dimensioni)
                    rg.id = TaPreventiviDimensioni.sqUltimoID()
                    rg.AcceptChanges()

                Case DataRowState.Modified
                    TaPreventiviDimensioni.UpdateQuery(rg.id_preventivo, rg.descrizione, dimensioni, rg.id)
                    rg.AcceptChanges()
            End Select
        End If
    End Sub

    Private Sub tsbOperazioni_Click(sender As Object, e As EventArgs) Handles tsbOperazioni.Click
        Dim f As New FrmOperazioni
        f.ShowDialog()
        TaPreventiviOperazioni.Fill(DsPreventivi.dtPreventiviOperazioni)

    End Sub

    Private Sub dgwDestinatari_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwDestinatari.RowValidating
        Dim f As New funzioni
        bsPreventiviDestinatari.EndEdit()
        Dim rg As dsPreventivi.dtPreventiviDestinatariRow
        rg = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row
        If rg.RowState = DataRowState.Added Then
            If rg.IssocietaNull Then
                bsPreventiviDestinatari.CancelEdit()
                Return
            End If
            TaPreventiviDestinatari.InsertQuery(rg.societa, f.Ctrlval(rg, "indirizzo"), f.Ctrlval(rg, "cap"), f.Ctrlval(rg, "localita"), f.Ctrlval(rg, "prv"), f.Ctrlval(rg, "tit"), f.Ctrlval(rg, "Resp"),
                                                f.Ctrlval(rg, "telefono"), f.Ctrlval(rg, "sicurezzaluoghi"), If(rg.IsprezzooranumNull, 0, rg.prezzooranum), f.Ctrlval(rg, "prezzooratxt"),
                                                If(rg.IscanonenumNull, 0, rg.canonenum), f.Ctrlval(rg, "canonetxt"), If(rg.IssicurezzanumNull, 0, rg.sicurezzanum), f.Ctrlval(rg, "sicurezzatxt"),
                                                If(rg.IsprovanumNull, 0, rg.provanum), f.Ctrlval(rg, "provadat"),
                                                f.Ctrlval(rg, "scadenza"), f.Ctrlval(rg, "note"), f.Ctrlval(rg, "ricontatti"), f.Ctrlval(rg, "r_tel"), f.Ctrlval(rg, "r_mail"),
                                                f.Ctrlval(rg, "decorrenza"), f.Ctrlval(rg, "p_iva"), f.Ctrlval(rg, "c_f"))
            rg.id = TaPreventiviDestinatari.sqUltimoID()
            rg.AcceptChanges()
        ElseIf rg.RowState = DataRowState.Modified Then
            TaPreventiviDestinatari.UpdateQuery(rg.societa, f.Ctrlval(rg, "indirizzo"), f.Ctrlval(rg, "cap"), f.Ctrlval(rg, "localita"), f.Ctrlval(rg, "prv"), f.Ctrlval(rg, "tit"), f.Ctrlval(rg, "Resp"),
                                                f.Ctrlval(rg, "telefono"), f.Ctrlval(rg, "sicurezzaluoghi"), If(rg.IsprezzooranumNull, 0, rg.prezzooranum), f.Ctrlval(rg, "prezzooratxt"),
                                                If(rg.IscanonenumNull, 0, rg.canonenum), f.Ctrlval(rg, "canonetxt"), If(rg.IssicurezzanumNull, 0, rg.sicurezzanum), f.Ctrlval(rg, "sicurezzatxt"),
                                                If(rg.IsprovanumNull, 0, rg.provanum), f.Ctrlval(rg, "provadat"),
                                                f.Ctrlval(rg, "scadenza"), f.Ctrlval(rg, "note"), f.Ctrlval(rg, "ricontatti"), f.Ctrlval(rg, "r_tel"), f.Ctrlval(rg, "r_mail"), If(rg.IscreatoilNull, Now(), rg.creatoil),
                                                f.Ctrlval(rg, "decorrenza"), f.Ctrlval(rg, "p_iva"), f.Ctrlval(rg, "c_f"), rg.id)

            rg.AcceptChanges()
        End If

    End Sub


    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        Dim rg As dsPreventivi.dtPreventiviDestinatariRow
        rg = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row
        Dim dt As DataTable
        Using dtPR As New dsPreventivi.dtPreventiviDataTable
            Using taPR As New dsPreventiviTableAdapters.taPreventivi
                taPR.Fill(dtPR)
            End Using
            dt = (From rig In dtPR Where rig.id_destinatario = rg.id).CopyToDataTable

            ProvaScrittura.Main(rg, dt)
        End Using

    End Sub
    Private Sub AggiornaListaPreventivo(ByVal dtGR As dsPreventivi.dtGraficoDataTable, ByVal idPreventivo As Int16)

        Dim gr = From tabella In dtGR.Where(Function(c) c.idpreventivo = idPreventivo And c.visibile = 1)
                 Group New With {Key .GFreq = tabella} By groupkey = New With {Key tabella.numerointerventi, Key tabella.frequenza} Into Group = Group
                 Select New With {Key .interventi = groupkey.numerointerventi, Key .freq = groupkey.frequenza, Key .sum = Group.Sum(Function(e) e.GFreq.ore / e.GFreq.numerointerventi)}


        Dim colColl As DataGridViewTextBoxColumn
        colColl = New DataGridViewTextBoxColumn
        Dim dgwcStile As DataGridViewCellStyle = New DataGridViewCellStyle
        Dim dgwcNormalStile As DataGridViewCellStyle = New DataGridViewCellStyle
        dgwcStile.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        dgwcStile.Format = "N2"
        dgwcStile.NullValue = Nothing
        dgwcNormalStile.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        dgwcNormalStile.Format = Nothing
        dgwcNormalStile.NullValue = Nothing


        dgwRisultato.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        If dgwRisultato.Columns.Count < 4 Then
            colColl.Name = "dgwcInt"
            colColl.HeaderText = "Int"
            colColl.DefaultCellStyle = dgwcStile
            colColl.FillWeight = 30
            dgwRisultato.Columns.Add(colColl)
            colColl = New DataGridViewTextBoxColumn
            colColl.Name = "dgwcFreq"
            colColl.DefaultCellStyle = dgwcNormalStile
            colColl.HeaderText = "Frequenza"
            colColl.FillWeight = 100
            dgwRisultato.Columns.Add(colColl)
            colColl = New DataGridViewTextBoxColumn
            colColl.DefaultCellStyle = dgwcStile
            colColl.Name = "dgwcOre"
            colColl.HeaderText = "Ore"
            colColl.FillWeight = 40
            dgwRisultato.Columns.Add(colColl)
            colColl = New DataGridViewTextBoxColumn
            colColl.DefaultCellStyle = dgwcStile
            colColl.Name = "dgwcImpGiorno"
            colColl.HeaderText = "Importo Int"
            colColl.FillWeight = 60
            dgwRisultato.Columns.Add(colColl)
            colColl = New DataGridViewTextBoxColumn
            colColl.DefaultCellStyle = dgwcStile
            colColl.Name = "dgwcImpMese"
            colColl.HeaderText = "Importo Mese"
            colColl.FillWeight = 60
            dgwRisultato.Columns.Add(colColl)
        End If
        If String.IsNullOrEmpty(txCostoOrario.Text.Trim) Then
            MsgBox("inserisci un valore per il costo orario")
            Return
        End If
        If String.IsNullOrEmpty(txSconto.Text.Trim) Then
            txSconto.Text = 0
        End If

        Dim sconto As Decimal = Decimal.Parse(txSconto.Text)
        Dim prezzoOra As Decimal = txCostoOrario.Text
        Dim prezzoScontato As Decimal = prezzoOra * (1 - (sconto / 100))
        dgwRisultato.Rows.Clear()
        Dim nOre, nPrezzoInt, nCanoneMese As Decimal
        Dim tOre, tmOre, tPrezzoInt, tCanoneMese As Decimal

        For Each f In gr
            nOre = If(Double.IsNaN(f.sum), 0, f.sum)
            nPrezzoInt = (nOre * prezzoScontato)
            nCanoneMese = (nOre * prezzoScontato * f.interventi / 12)
            tmOre += nOre * f.interventi / 12
            tOre += nOre
            tPrezzoInt += nPrezzoInt
            tCanoneMese += nCanoneMese
            dgwRisultato.Rows.Add(f.interventi, f.freq, nOre.ToString("n2"), nPrezzoInt.ToString("n2"), nCanoneMese.ToString("n2"))
        Next
        dgwRisultato.Rows.Add()
        dgwRisultato.Rows.Add("", "Ore Mese", tmOre.ToString("n2"), tPrezzoInt.ToString("n2"), tCanoneMese.ToString("n2"))
    End Sub
    Private Sub btAggiornaGrafico_Click(sender As Object, e As EventArgs) Handles btAggiornaGrafico.Click
        Dim idpr As Int32
        idpr = DirectCast(bsRelPreventiviDestinatariPreventivi.Current, DataRowView).Row.Field(Of Int32)("id_destinatario")
        If dsTest.Tables.Count = 0 Then
            dtTest = dsTest.Tables.Add("dtTest")
            dtTest.Columns.Add("Ambiente", GetType(String))
            dtTest.Columns.Add("Operazioni", GetType(String))
            dtTest.Columns.Add("Ore", GetType(Decimal))
            dtTest.Columns.Add("Frequenza", GetType(String))
            dtTest.Columns.Add("numerointerventi", GetType(Int32))
        Else
            dtTest.Rows.Clear()
        End If

        Using dtGR As New dsPreventivi.dtGraficoDataTable
            Using taGR As New dsPreventiviTableAdapters.taGrafico
                Try
                    taGR.Fill(dtGR)
                Catch ex As Exception
                    Dim ms
                    ms = dtGR.GetErrors
                End Try
            End Using

            Dim dtRow() As DataRow = dtGR.Select(String.Format("idpreventivo = '{0}' AND visibile = {1}", idpr, 1))
            AggiornaListaPreventivo(dtGR, idpr)

            For Each r As dsPreventivi.dtGraficoRow In dtRow
                Dim value1 As String = r.dettagliocliente
                Dim value2 As String = r.operazionidaeffettuare
                Dim value3 As Integer = r.ore
                Dim value4 As String = r.frequenza
                Dim value5 As Int16 = r.numerointerventi
                dtTest.Rows.Add(value1, value2, value3, value4, value5)
            Next
        End Using

        chGraficoPreventivo.Series.Clear()

        If chGraficoPreventivo.Series.Count < 1 Then
            chGraficoPreventivo.Series.Add("Impegno")
            chGraficoPreventivo.Series.Add("Operazioni")
        End If
        With chGraficoPreventivo.Series(0)
            .Name = "Ore"
            .Font = New Font("Arial", 7, FontStyle.Regular)
            .BackGradientStyle = GradientStyle.TopBottom
            .Color = Color.Magenta
            .BackSecondaryColor = Color.Purple
            .IsValueShownAsLabel = False
            .LabelBackColor = Color.Transparent
            .LabelForeColor = Color.Purple
            .Points.DataBind(dtTest.DefaultView, "Operazioni", "numerointerventi", Nothing)
            .CustomProperties = "DrawingStyle = Cylinder , PixelPointWidth = 26"
        End With
        With chGraficoPreventivo.Series(1)
            .Name = "Impegno"
            .Font = New Font("Arial", 8, FontStyle.Italic)
            .BackGradientStyle = GradientStyle.TopBottom
            .Color = Color.Aqua
            .BackSecondaryColor = Color.Blue
            .IsValueShownAsLabel = True
            .SmartLabelStyle.CalloutStyle = LabelCalloutStyle.Box
            .LabelBackColor = Color.Transparent
            .LabelForeColor = Color.Blue
            .Points.DataBindY(dtTest.DefaultView, "Ore")
            .CustomProperties = "DrawingStyle = Cylinder , PixelPointWidth = 26"
        End With
        With chGraficoPreventivo.ChartAreas(0)
            .AxisX.Interval = 1
            .AxisX.LabelStyle.Angle = -90
            .AxisX.Title = "Ambiente"
            .AxisY.Title = "Impegno"
        End With

        Dim strip As New StripLine
        strip.BackColor = Color.LightSalmon
        strip.IntervalOffset = 50
        strip.StripWidth = 2
        chGraficoPreventivo.ChartAreas(0).AxisY.StripLines.Add(strip)

        'Me.Size = New Size(754, 600)
    End Sub

    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click
        dgwDestinatari.CurrentCell = dgwDestinatari(dgwcSocietaDestinatario.Index, dgwDestinatari.Rows.GetLastRow(DataGridViewElementStates.None))
        CreatoilDateTimePicker.Value = Now().ToShortDateString

        SocietaTextBox.Focus()
        dgwDestinatari.BeginEdit(True)
    End Sub

    Private Sub dgwDestinatari_CancelRowEdit(sender As Object, e As QuestionEventArgs) Handles dgwDestinatari.CancelRowEdit
        If dgwDestinatari(dgwcSocietaDestinatario.Index, dgwDestinatari.CurrentRow.Index).Value.ToString.Trim = vbEmpty Then
            dgwDestinatari.CancelEdit()
        End If
    End Sub


    Private Sub btDuplica_Click(sender As Object, e As EventArgs) Handles btDuplica.Click
        Dim f As New funzioni
        Dim RG As dsPreventivi.dtPreventiviDestinatariRow
        RG = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row
        TaPreventiviDestinatari.InsertQuery(RG.societa, f.Ctrlval(RG, "indirizzo"), f.Ctrlval(RG, "cap"), f.Ctrlval(RG, "localita"), f.Ctrlval(RG, "prv"), f.Ctrlval(RG, "tit"), f.Ctrlval(RG, "Resp"),
                                                f.Ctrlval(RG, "telefono"), f.Ctrlval(RG, "sicurezzaluoghi"), If(RG.IsprezzooranumNull, 0, RG.prezzooranum), f.Ctrlval(RG, "prezzooratxt"),
                                                If(RG.IscanonenumNull, 0, RG.canonenum), f.Ctrlval(RG, "canonetxt"), If(RG.IssicurezzanumNull, 0, RG.sicurezzanum), f.Ctrlval(RG, "sicurezzatxt"),
                                                If(RG.IsprovanumNull, 0, RG.provanum), f.Ctrlval(RG, "provadat"),
                                                f.Ctrlval(RG, "scadenza"), f.Ctrlval(RG, "note"), f.Ctrlval(RG, "ricontatti"), f.Ctrlval(RG, "r_tel"), f.Ctrlval(RG, "r_mail"),
                                                f.Ctrlval(RG, "decorrenza"), f.Ctrlval(RG, "p_iva"), f.Ctrlval(RG, "c_f"))
        TaPreventiviDestinatari.Fill(Me.DsPreventivi.dtPreventiviDestinatari)
    End Sub

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim RG As dsPreventivi.dtPreventiviDestinatariRow
        RG = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row
        If MsgBox("Se sicuro di voler eliminare " & RG.societa.ToUpper & " dall'elenco ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TaPreventiviDestinatari.DeleteQuery(RG.id)
        End If

    End Sub

    Private Sub dgwPreventivi_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgwPreventivi.CellValidating

        Select Case True
            Case e.ColumnIndex = dgwcid_dimensioni.Index
                If String.IsNullOrEmpty(e.FormattedValue) Then
                    dgwPreventivi.Rows(e.RowIndex).ErrorText = "Indica le dimensioni"
                    e.Cancel = True
                End If
            Case e.ColumnIndex = dgwcOperazione.Index
                If String.IsNullOrEmpty(e.FormattedValue) Then
                    dgwPreventivi.Rows(e.RowIndex).ErrorText = "Indica l'operazione"
                    e.Cancel = True
                End If
            Case e.ColumnIndex = dgwcCategoria.Index
                If String.IsNullOrEmpty(e.FormattedValue) Then
                    dgwPreventivi.Rows(e.RowIndex).ErrorText = "Indica la categora"
                    e.Cancel = True
                End If
            Case e.ColumnIndex = dgwcFrequenza.Index
                If String.IsNullOrEmpty(e.FormattedValue) Then
                    dgwPreventivi.Rows(e.RowIndex).ErrorText = "Seleziona la frequenza"
                    e.Cancel = True
                End If

            Case Else
                Return
        End Select
        ' Abort validation if cell is not in the CompanyName column.
    End Sub

    Private Sub TTBTRicarica_Click(sender As Object, e As EventArgs) Handles TTBTRicarica.Click
        Dim rr As dsPreventivi.dtPreventiviDestinatariRow
        rr = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row
        caricadati()
        dgwDestinatari.CurrentCell = dgwDestinatari(0, dgwDestinatari.Rows.GetFirstRow(DataGridViewElementStates.None))

        'bsPreventiviDestinatari.Position = bsPreventiviDestinatari.Find(rr.id, "id")
    End Sub

    Private Sub TTTestoRicerca_Click(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        Dim testo As String = DirectCast(sender, ToolStripTextBox).Text

        Select Case tabPreventivi.SelectedTab.Name
            Case tbElencoOperazioni.Name
                If bsPreventiviOperazioni.Count > 0 Then
                    Dim ricerca As String = String.Format("descrizione LIKE '%{0}%'", testo)
                    bsPreventiviOperazioni.Filter = ricerca
                    Dim lunghezza As Int16
                    Do While True
                        If bsPreventiviOperazioni.Count < 1 Then
                            lunghezza += 1
                            If testo.Length - lunghezza > 0 Then
                                testo = testo.Substring(0, (testo.Length - lunghezza))
                            Else
                                bsPreventiviOperazioni.RemoveFilter()
                                DirectCast(sender, ToolStripTextBox).Text = testo
                                DirectCast(sender, ToolStripTextBox).SelectionStart = testo.Length
                                Exit Do
                            End If
                            ricerca = String.Format("descrizione LIKE '%{0}%'", testo)
                            bsPreventiviOperazioni.Filter = ricerca
                        Else
                            DirectCast(sender, ToolStripTextBox).Text = testo
                            DirectCast(sender, ToolStripTextBox).SelectionStart = testo.Length
                            Exit Do
                        End If
                    Loop
                End If
            Case tbPreventivo.Name
                If bsPreventiviDestinatari.Count > 0 Then
                    Dim ricerca As String = String.Format("societa LIKE '%{0}%' or localita LIKE '%{0}%'", testo)
                    bsPreventiviDestinatari.Filter = ricerca
                    Dim lunghezza As Int16
                    Do While True
                        If bsPreventiviDestinatari.Count < 1 Then
                            lunghezza += 1
                            If testo.Length - lunghezza > 0 Then
                                testo = testo.Substring(0, (testo.Length - lunghezza))
                            Else
                                bsPreventiviDestinatari.RemoveFilter()
                                DirectCast(sender, ToolStripTextBox).Text = testo
                                DirectCast(sender, ToolStripTextBox).SelectionStart = testo.Length
                                Exit Do
                            End If
                            bsPreventiviDestinatari.Filter = String.Format("societa LIKE '%{0}%' or localita LIKE '%{0}%'", testo)
                        Else
                            DirectCast(sender, ToolStripTextBox).Text = testo
                            DirectCast(sender, ToolStripTextBox).SelectionStart = testo.Length
                            Exit Do
                        End If
                    Loop
                End If

        End Select

    End Sub

    Private Sub dgwPreventivi_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwPreventivi.CellFormatting
        Dim dgw As DataGridView
        dgw = DirectCast(sender, DataGridView)
        If (e.ColumnIndex < 0) Then
            Return
        End If
        If IsDBNull(dgw(e.ColumnIndex, e.RowIndex).Value) = False Then
            Select Case e.ColumnIndex
                Case dgwcid_dimensioni.Index
                    Dim idDim As Integer
                    idDim = dgw(dgwcid_dimensioni.Index, e.RowIndex).Value
                    If idDim <> vbEmpty Then
                        bsPreventiviDimensioni.Position = bsPreventiviDimensioni.Find("id", idDim)
                        Dim rgDi As dsPreventivi.dtPreventiviDimensioniRow
                        rgDi = DirectCast(bsPreventiviDimensioni.Current, DataRowView).Row
                        If rgDi.IsdimensioniNull = vbFalse Then
                            Dim dimensione As Decimal
                            dimensione = rgDi.dimensioni
                            dgw(dgwcDimensioni.Index, e.RowIndex).Value = dimensione
                        End If
                    End If

                Case dgwcFrequenza.Index
                    Dim idFr As Integer
                    idFr = dgw(dgwcFrequenza.Index, e.RowIndex).Value
                    If idFr <> vbEmpty Then
                        bsPreventiviFrequenze.Position = bsPreventiviFrequenze.Find("id", idFr)
                        Dim rgFr As dsPreventivi.dtPreventiviFrequenzeRow
                        rgFr = DirectCast(bsPreventiviFrequenze.Current, DataRowView).Row
                        If rgFr.IsnumerointerventiNull = vbFalse Then
                            dgw(dgwcFreq.Index, e.RowIndex).Value = rgFr.numerointerventi
                        End If
                    End If
                Case dgwcRisultato.Index
                    dgw(dgwcRisultato.Index, e.RowIndex).Value = aggiornareseOrarie(If(IsDBNull(dgw(dgwcImpegnomq.Index, e.RowIndex).Value), Nothing, dgw(dgwcImpegnomq.Index, e.RowIndex).Value),
                                                                                            If(IsDBNull(dgw(dgwcImpegnonumero.Index, e.RowIndex).Value), Nothing, dgw(dgwcImpegnonumero.Index, e.RowIndex).Value),
                                                                                            If(IsDBNull(dgw(dgwcFreq.Index, e.RowIndex).Value), Nothing, dgw(dgwcFreq.Index, e.RowIndex).Value),
                                                                                            If(IsDBNull(dgw(dgwcDimensioni.Index, e.RowIndex).Value), Nothing, dgw(dgwcDimensioni.Index, e.RowIndex).Value),
                                                                                            If(IsDBNull(dgw(dgwcTaratura.Index, e.RowIndex).Value), Nothing, dgw(dgwcTaratura.Index, e.RowIndex).Value))
            End Select
        End If
    End Sub

    Private Sub btMemorizza_Click(sender As Object, e As EventArgs) Handles btMemorizza.Click
        Dim f As New funzioni
        bsPreventiviDestinatari.EndEdit()
        Dim rg As dsPreventivi.dtPreventiviDestinatariRow
        rg = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row
        If rg.RowState = DataRowState.Added Then
            If rg.IssocietaNull Then
                bsPreventiviDestinatari.CancelEdit()
                Return
            End If
            TaPreventiviDestinatari.InsertQuery(rg.societa, f.Ctrlval(rg, "indirizzo"), f.Ctrlval(rg, "cap"), f.Ctrlval(rg, "localita"), f.Ctrlval(rg, "prv"), f.Ctrlval(rg, "tit"), f.Ctrlval(rg, "Resp"),
                                                f.Ctrlval(rg, "telefono"), f.Ctrlval(rg, "sicurezzaluoghi"), If(rg.IsprezzooranumNull, 0, rg.prezzooranum), f.Ctrlval(rg, "prezzooratxt"),
                                                If(rg.IscanonenumNull, 0, rg.canonenum), f.Ctrlval(rg, "canonetxt"), If(rg.IssicurezzanumNull, 0, rg.sicurezzanum), f.Ctrlval(rg, "sicurezzatxt"),
                                                If(rg.IsprovanumNull, 0, rg.provanum), f.Ctrlval(rg, "provadat"),
                                                f.Ctrlval(rg, "scadenza"), f.Ctrlval(rg, "note"), f.Ctrlval(rg, "ricontatti"), f.Ctrlval(rg, "r_tel"), f.Ctrlval(rg, "r_mail"),
                                                f.Ctrlval(rg, "decorrenza"), f.Ctrlval(rg, "p_iva"), f.Ctrlval(rg, "c_f"))
            rg.id = TaPreventiviDestinatari.sqUltimoID()
            rg.AcceptChanges()
        ElseIf rg.RowState = DataRowState.Modified Then
            TaPreventiviDestinatari.UpdateQuery(rg.societa, f.Ctrlval(rg, "indirizzo"), f.Ctrlval(rg, "cap"), f.Ctrlval(rg, "localita"), f.Ctrlval(rg, "prv"), f.Ctrlval(rg, "tit"), f.Ctrlval(rg, "Resp"),
                                                f.Ctrlval(rg, "telefono"), f.Ctrlval(rg, "sicurezzaluoghi"), If(rg.IsprezzooranumNull, 0, rg.prezzooranum), f.Ctrlval(rg, "prezzooratxt"),
                                                If(rg.IscanonenumNull, 0, rg.canonenum), f.Ctrlval(rg, "canonetxt"), If(rg.IssicurezzanumNull, 0, rg.sicurezzanum), f.Ctrlval(rg, "sicurezzatxt"),
                                                If(rg.IsprovanumNull, 0, rg.provanum), f.Ctrlval(rg, "provadat"),
                                                f.Ctrlval(rg, "scadenza"), f.Ctrlval(rg, "note"), f.Ctrlval(rg, "ricontatti"), f.Ctrlval(rg, "r_tel"), f.Ctrlval(rg, "r_mail"), If(rg.IscreatoilNull, Now(), rg.creatoil),
                                                f.Ctrlval(rg, "decorrenza"), f.Ctrlval(rg, "p_iva"), f.Ctrlval(rg, "c_f"), rg.id)

            rg.AcceptChanges()
        End If
    End Sub

    Private Sub dgwOperazioni_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgwOperazioni.RowValidated
        If bsPreventiviOperazioni.Count > 0 Then
            Dim rg As dsPreventivi.dtPreventiviOperazioniRow
            rg = DirectCast(bsPreventiviOperazioni.Current, DataRowView).Row
            Select Case rg.RowState
                Case DataRowState.Added
                    TaPreventiviOperazioni.InsertQuery(rg.descrizione, If(rg.IsimpegnometroquadroNull, Nothing, rg.impegnometroquadro), If(rg.IsdataNull, Now(), rg.data), If(rg.IsattivoNull, 1, rg.attivo), rg.idcategoria, If(rg.IsimpegnonumeroNull, Nothing, rg.impegnonumero))
                    rg.id = TaPreventiviDimensioni.sqUltimoID()
                    rg.AcceptChanges()

                Case DataRowState.Modified
                    TaPreventiviOperazioni.UpdateQuery(rg.descrizione, If(rg.IsimpegnometroquadroNull, Nothing, rg.impegnometroquadro), If(rg.IsdataNull, Now(), rg.data), rg.attivo, rg.idcategoria, If(rg.IsimpegnonumeroNull, Nothing, rg.impegnonumero), rg.id)
                    rg.AcceptChanges()
            End Select
        End If
    End Sub

    Private Sub btnPreventiviCopia_Click(sender As Object, e As EventArgs) Handles btnPreventiviCopia.Click
        Dim idDest As Int16 = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row.Item("id")
        lPreventivi = From s In Me.DsPreventivi.dtPreventivi Where s.id_destinatario = idDest
        btnPreventiviIncolla.Enabled = True
        btnPreventivisvuotaArray.Enabled = True
        btnPreventiviCopia.Enabled = False
    End Sub

    Private Sub btnPreventiviIncolla_Click(sender As Object, e As EventArgs) Handles btnPreventiviIncolla.Click
        Dim idDest As Int16 = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row.Item("id")
        Dim idImpe As Int16
        Dim dimensione As Decimal
        Dim Taratura As Decimal
        Dim Visibile As Int16
        If relPreventiviDestinatariPreventiviDimensioni.Count > 0 Then
            idImpe = DirectCast(relPreventiviDestinatariPreventiviDimensioni.Current, DataRowView).Row.Item("id")
            dimensione = DirectCast(relPreventiviDestinatariPreventiviDimensioni.Current, DataRowView).Row.Item("dimensioni")
            'Taratura = DirectCast(relPreventiviDestinatariPreventiviDimensioni.Current, DataRowView).Row.Item("taratura")
            Visibile = 1 'DirectCast(relPreventiviDestinatariPreventiviDimensioni.Current, DataRowView).Row.Item("visibile")
        Else
            MsgBox("Inserisci prima almeno una dimensione")
            Return
        End If
        Dim x As Int16
        For Each tmprg In lPreventivi
            TaPreventivi.InsertQuery(tmprg.id_operazioni, idDest, Now(), Nothing, 0, tmprg.id_frequenza, tmprg.id_categoria, x, idImpe, tmprg.impegnomq, tmprg.impegnonumero, dimensione, Visibile, Taratura)
            x += 1
        Next
        btnPreventiviIncolla.Enabled = False
        btnPreventivisvuotaArray.Enabled = False
        btnPreventiviCopia.Enabled = True
        TTBTRicarica.PerformClick()
    End Sub

    Private Sub btnPreventivisvuotaArray_Click(sender As Object, e As EventArgs) Handles btnPreventivisvuotaArray.Click
        lPreventivi = Nothing
        btnPreventiviIncolla.Enabled = False
        btnPreventivisvuotaArray.Enabled = False
        btnPreventiviCopia.Enabled = True
    End Sub

    Private Sub btAbbinaPreventivo_Click(sender As Object, e As EventArgs) Handles btAbbinaPreventivo.Click
        Dim idCli, idDet As Int16
        idCli = DirectCast(bsCantieri.Current, DataRowView).Row.Item("id")
        idDet = DirectCast(relDettaglio.Current, DataRowView).Row.Item("id")
        Dim rgPD As dsPreventivi.dtPreventiviDestinatariRow
        rgPD = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row
        TaPreventiviAbbinamento.InsertQuery(idCli, rgPD.id, Now(), 1, idDet)
        TaPreventiviAbbinamento.Fill(DsPreventivi.dtPreventiviAbbinamento)
        AggiornaDati()
    End Sub

    Private Sub btEliminaAbbinamento_Click(sender As Object, e As EventArgs) Handles btEliminaAbbinamento.Click
        If bsPreventiviabbinamento.Count > 0 Then
            Dim rgrr As dsPreventivi.dtPreventiviAbbinamentoRow
            rgrr = DirectCast(bsPreventiviabbinamento.Current, DataRowView).Row
            TaPreventiviAbbinamento.DeleteQuery(rgrr.id)
            TaPreventiviAbbinamento.Fill(DsPreventivi.dtPreventiviAbbinamento)
            AggiornaDati()
        End If
    End Sub

    Private Sub tbRicercaClienteabbinabile_TextChanged(sender As Object, e As EventArgs) Handles tbRicercaClienteabbinabile.TextChanged
        Dim tx As String
        tx = tbRicercaClienteabbinabile.Text
        bsCantieri.Filter = String.Format("societa LIKE '%{0}%'", tx.Trim)
        If bsCantieri.Count = 0 Then
            tx = tx.Substring(0, tx.Length - 1)
            tbRicercaClienteabbinabile.Text = tx
            tbRicercaClienteabbinabile.SelectionStart = tx.Length
            bsCantieri.Filter = String.Format("societa LIKE '%{0}%'", tx.Trim)
        End If
    End Sub

    Private Sub btCreaCliente_Click(sender As Object, e As EventArgs) Handles btCreaCliente.Click
        Dim rg As dsPreventivi.dtPreventiviDestinatariRow
        rg = DirectCast(bsPreventiviDestinatari.Current, DataRowView).Row
        Dim id As Int16
        Using ta As New DS_clientiTableAdapters.TA_cantieri_new
            id = ta.SP_UltimoID(GlobalVarPOP.G_idAZ) + 1
            ta.QR_Inserisce(id, "0000", rg.societa, rg.indirizzo, rg.cap, rg.localita, rg.prv, "ITALIA", rg.tit, rg.r_mail, rg.Resp,
                                If(rg.Isp_ivaNull, "", rg.p_iva), If(rg.IstelefonoNull, "", rg.telefono), "", "", If(rg.Isr_telNull, "", rg.r_tel),
                                "", 1, "IT", rg.decorrenza, If(rg.IsscadenzaNull, DateAdd(DateInterval.Year, 1, rg.decorrenza), rg.scadenza), If(rg.IsricontattiNull, "", rg.ricontatti), 1, 1, 0, 0, 0, GlobalVarPOP.G_idAZ, 0)
        End Using
        Dim idl As Int16

        Using ta As New DS_clientiTableAdapters.TA_locazione_new
            idl = ta.SP_ultimoID(GlobalVarPOP.G_idAZ) + 1
            ta.QR_Inserisce(idl, id, 0, rg.societa.Substring(0, If(rg.societa.Length > 15, 15, rg.societa.Length)) + " ORD", rg.indirizzo, rg.localita, rg.cap, rg.canonenum, 1, "Canone Mensile per il Servizio di pulizia", 1,
                            1, Now(), 0, 0, 0, GlobalVarPOP.G_idAZ, 1)
            idl = ta.SP_ultimoID(GlobalVarPOP.G_idAZ) + 1
            ta.QR_Inserisce(idl, id, 1, rg.societa.Substring(0, If(rg.societa.Length > 15, 15, rg.societa.Length)) + " SIC 3%", rg.indirizzo, rg.localita, rg.cap, rg.sicurezzanum, 1, "Costo Sicurezza al 3% per il Servizio di pulizia ordinario", 4,
                            1, Now(), 0, 0, 0, GlobalVarPOP.G_idAZ, 1)
            idl = ta.SP_ultimoID(GlobalVarPOP.G_idAZ) + 1
            ta.QR_Inserisce(idl, id, 2, rg.societa.Substring(0, If(rg.societa.Length > 15, 15, rg.societa.Length)) + " STR", rg.indirizzo, rg.localita, rg.cap, rg.prezzooranum, 1, "Canone Mensile per il Servizio di pulizia", 2,
                            1, Now(), 0, 0, 0, GlobalVarPOP.G_idAZ, 1)
            idl = ta.SP_ultimoID(GlobalVarPOP.G_idAZ) + 1
            ta.QR_Inserisce(idl, id, 3, rg.societa.Substring(0, If(rg.societa.Length > 15, 15, rg.societa.Length)) + " SIC 5%", rg.indirizzo, rg.localita, rg.cap, (rg.prezzooranum * 0.5), 1, "Canone Mensile per il Servizio di pulizia", 5,
                            1, Now(), 0, 0, 0, GlobalVarPOP.G_idAZ, 1)

        End Using

    End Sub

End Class
#Enable Warning CA1707 ' Gli identificatori non devono contenere caratteri di sottolineatura