Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging

Public Class FrmAbbinamentoCantieriCQ

    Private Sub FrmAbbinamentoCantieriCQ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RicaricaArchivi()
        AggiornaClienti()
        AddHandler dgwDettaglioClienti.Rows.CollectionChanged, AddressOf aggiornaDettagli
        aggiornaDettagli()
        popolaGrigliaCheckList()
    End Sub
    Private Sub AggiornaDati()
        RicaricaArchivi()
        AggiornaClienti()
        aggiornaDettagli()
    End Sub

    Private Sub RicaricaArchivi()
        Me.TaDestinatari.Fill(Me.DsControlloQualita.dtDestinatari)
        Me.TaClienti.FillByAttiviAzienda(Me.DsControlloQualita.dtClienti, GlobalVarPOP.G_idAZ, 1)
        Me.DtCqDettaglio.Fill(Me.DsControlloQualita.dtCqDettaglio)
        Me.TaCqCategorie.Fill(Me.DsControlloQualita.dtCqArea)
        Me.DtCqAbbinaAreaDettaglioDestinatario.Fill(Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario)

    End Sub

    Private Sub dgwDestinatarioArea_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDestinatarioArea.RowEnter
        Dim tmpDGW As DataGridView
        tmpDGW = DirectCast(sender, DataGridView)
        Dim idDest, idArea As Int16

        If DtClientidtDestinatariBindingSource.Count <= 0 Then
            Return
        End If
        Dim rgDest As dsControlloQualita.dtDestinatariRow
        rgDest = DirectCast(DtClientidtDestinatariBindingSource.Current, DataRowView).Row
        idDest = rgDest.id

        idArea = tmpDGW(dgwcID_Area.Index, e.RowIndex).Value
        Console.WriteLine(idDest.ToString + "--" + idArea.ToString)
        For Each posDettaglio As DataGridViewRow In dgwDettaglio.Rows
            posDettaglio.Cells(dgwcDettaglioControllo.Index).Value = False
            posDettaglio.Cells(dgwcIDAbbinamentoTMP.Index).Value = -1
        Next
        If idDest > 0 And idArea > 0 Then
            For Each rgDettaglio As dsControlloQualita.dtCqAbbinaAreaDettaglioDestinatarioRow In Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario
                If rgDettaglio.id_dest = idDest And rgDettaglio.id_area = idArea Then
                    Dim iddett As Int16 = rgDettaglio.id_dettaglio
                    Dim idAbbinamento As Int16 = rgDettaglio.id
                    For Each posDettaglio As DataGridViewRow In dgwDettaglio.Rows
                        'Dim stile As New DataGridViewCellStyle
                        'stile.BackColor = Color.White
                        If posDettaglio.Cells(dgwcDettaglioID.Index).Value = iddett Then
                            posDettaglio.Cells(dgwcIDAbbinamentoTMP.Index).Value = idAbbinamento
                            posDettaglio.Cells(dgwcDettaglioControllo.Index).Value = True
                            'stile.BackColor = Color.Coral
                        End If
                        'posDettaglio.DefaultCellStyle = stile
                    Next
                End If
            Next
        End If
    End Sub
    Private Sub aggiornaDettagli()
        If DtClientidtDestinatariBindingSource.Count <= 0 Then
            Return
        End If
        Dim rgCli As dsControlloQualita.dtClientiRow
        rgCli = DirectCast(bsClienti.Current, DataRowView).Row
        Dim idCli, idDett As Int16
        idCli = rgCli.id
        Dim lst = From item In Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario
                  Order By item.id_dest
                  Where item.id_cli = idCli
                  Group By item.id_dest Into Group


        For Each rigaDataGrid As DataGridViewRow In dgwDettaglioClienti.Rows
            idDett = rigaDataGrid.Cells(dgwcidLocazione.Index).Value
            Dim stile As New DataGridViewCellStyle()
            stile.BackColor = Color.White
            rigaDataGrid.DefaultCellStyle = stile
            For Each rigaGruppo In lst
                If rigaGruppo.id_dest = idDett Then
                    stile.BackColor = Color.Coral
                    rigaDataGrid.DefaultCellStyle = stile
                End If
            Next
        Next


    End Sub
    Private Sub AggiornaClienti()
        Dim lst = From item In Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario
                  Order By item.id_cli
                  Group By item.id_cli Into Group

        Me.taCq.Fill(Me.DsControlloQualita.dtCq)


        Dim nuovaColonna As New DataColumn
        nuovaColonna.ColumnName = "Attiva"
        nuovaColonna.DataType = System.Type.GetType("System.Int32")
        nuovaColonna.DefaultValue = 0
        Dim ControllataColonna As New DataColumn
        ControllataColonna.ColumnName = "controllata"
        ControllataColonna.DataType = System.Type.GetType("System.Int32")
        ControllataColonna.DefaultValue = 0
        Dim columns As DataColumnCollection = Me.DsControlloQualita.dtClienti.Columns
        If columns.Contains("attiva") Then
            Try
                Me.DsControlloQualita.dtClienti.Columns.Remove(nuovaColonna)
            Catch ex As Exception

            End Try
        End If
        If columns.Contains("controllata") Then
            Me.DsControlloQualita.dtClienti.Columns.Remove(ControllataColonna)
        End If

        Me.DsControlloQualita.dtClienti.Columns.Add(nuovaColonna)
        Me.DsControlloQualita.dtClienti.Columns.Add(ControllataColonna)

        For Each dtr As dsControlloQualita.dtClientiRow In Me.DsControlloQualita.dtClienti.Rows
            For Each rigaGruppo In lst
                If rigaGruppo.id_cli = dtr.id Then
                    Dim hon = From eseguiti In Me.DsControlloQualita.dtCq
                              Order By eseguiti.societa
                              Where eseguiti.id_cli = rigaGruppo.id_cli
                              Group By eseguiti.data Into Group
                    dtr("Attiva") = 1
                    dtr("controllata") = (hon.Count - 1) / 2
                End If
                dtr.AcceptChanges()
            Next
        Next
        DsControlloQualita.dtClienti.AcceptChanges()

        Dim nuovaDGWC As New DataGridViewTextBoxColumn
        nuovaDGWC.HeaderText = " Attiva"
        nuovaDGWC.DataPropertyName = "Attiva"
        nuovaDGWC.ReadOnly = True
        nuovaDGWC.Name = "dgwcAttivaClienti"
        nuovaDGWC.Visible = False
        nuovaDGWC.FillWeight = 20
        Dim dgwcCK As New DataGridViewTextBoxColumn
        dgwcCK.HeaderText = " CK"
        dgwcCK.DataPropertyName = "controllata"
        dgwcCK.ReadOnly = True
        dgwcCK.Name = "dgwcControllaClienti"
        dgwcCK.Visible = True
        dgwcCK.FillWeight = 20

        dgwCliente.Columns.Add(nuovaDGWC)
        dgwCliente.Columns.Add(dgwcCK)
        Dim pos As Int16 = nuovaDGWC.Index
        dgwCliente.Sort(dgwCliente.Columns(pos), System.ComponentModel.ListSortDirection.Descending)


    End Sub
    Private Sub dgwCliente_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwCliente.CellFormatting
        Dim tmpDGW As DataGridView
        tmpDGW = DirectCast(sender, DataGridView)
        Dim stile As New DataGridViewCellStyle
        Dim pos As Int16 = tmpDGW.Columns("dgwcAttivaClienti").Index
        Dim pp As Int16 = tmpDGW.Columns("dgwcControllaClienti").Index
        If tmpDGW(pos, e.RowIndex).Value = 1 Then
            tmpDGW.Rows(e.RowIndex).Cells(dgwcDettaglioIDdettaglio.Index).Style.BackColor = Color.Orange
            tmpDGW.Rows(e.RowIndex).Cells(pp).Style.BackColor = Color.Green
            tmpDGW.Rows(e.RowIndex).Cells(dgwcDettaglioControllo.Index).Style.BackColor = Color.Orange
            tmpDGW.Rows(e.RowIndex).Cells(dgwcDettaglioControllo.Index).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If

    End Sub
    Private Sub dgwDestinatario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDettaglioClienti.CellClick
        Dim tmpDGW As DataGridView
        tmpDGW = DirectCast(sender, DataGridView)
        Dim idDest, idArea As Int16
        'TODO impostare una tabella Virtuale dove si colleghi l'Area al Destinatario
        If DtClientidtDestinatariBindingSource.Count <= 0 Then
            Return
        End If
        Dim rgDest As dsControlloQualita.dtDestinatariRow
        rgDest = DirectCast(DtClientidtDestinatariBindingSource.Current, DataRowView).Row
        idDest = rgDest.id

        Dim lst = From item In Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario
                  Order By item.id_area
                  Where item.id_dest = idDest
                  Group By item.id_area Into Group

        For Each rigaDataGrid As DataGridViewRow In dgwDestinatarioArea.Rows
            idArea = rigaDataGrid.Cells(dgwcID_Area.Index).Value
            Dim stile As New DataGridViewCellStyle
            stile.BackColor = Color.White
            rigaDataGrid.DefaultCellStyle = stile
            For Each rigaGruppo In lst
                If rigaGruppo.id_area = idArea Then
                    stile.BackColor = Color.Coral
                    rigaDataGrid.DefaultCellStyle = stile
                End If
            Next
        Next
        'Dim tmpDGW As DataGridView
        tsbStampa.DropDownItems.Clear()
        tsbEliminaControllo.DropDownItems.Clear()

        tmpDGW = dgwCliente
        Dim idCli As Int16

        idCli = tmpDGW(dgwcClientiID.Index, tmpDGW.CurrentRow.Index).Value

        Dim Linq = From x In DsControlloQualita.dtCq Where x.id_cli = idCli And x.id_des = idDest Group By x.data.ToShortDateString Into Group

        tbPresenzaControlli.Maximum = 100
        tbPresenzaControlli.Value = 0
        If Linq.Count >= 1 Then
            tbPresenzaControlli.Maximum = Linq.Count
            For Each kk In Linq
                tsbStampa.DropDownItems.Add("Controllo del: " & kk.ToShortDateString)
                tsbEliminaControllo.DropDownItems.Add("Elimina il controllo del: " & kk.ToShortDateString)
            Next
            tbPresenzaControlli.Value = Linq.Count
        End If


    End Sub

    Private Sub dgwDettaglio_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwDettaglio.RowValidating
        Dim tmpDGW As DataGridView
        tmpDGW = DirectCast(sender, DataGridView)

        bsDettaglio.EndEdit()
        For Each rr In bsDettaglio
            Dim rg As dsControlloQualita.dtCqDettaglioRow
            rg = DirectCast(rr, DataRowView).Row
            Select Case rg.RowState
                Case DataRowState.Modified
                    DtCqDettaglio.UpdateQuery(rg.nome, rg.id)
                Case DataRowState.Added
                    DtCqDettaglio.InsertQuery(rg.nome)
                Case DataRowState.Deleted
                    DtCqDettaglio.DeleteQuery(rg.id)
            End Select
            rg.AcceptChanges()
        Next

        Dim Controllo As Boolean
        Controllo = Boolean.Parse(tmpDGW(dgwcDettaglioControllo.Index, e.RowIndex).Value)
        Dim idDettaglio, idArea, idDestinatario, idCliente As Int16

        Dim tmpDettaglioClienti As DataGridView
        tmpDettaglioClienti = dgwDettaglioClienti

        Dim rgDest As dsControlloQualita.dtDestinatariRow
        rgDest = DirectCast(relClientiDestinatari.Current, DataRowView).Row


        idDestinatario = tmpDettaglioClienti(dgwcidLocazione.Index, tmpDettaglioClienti.CurrentRow.Index).Value
        idCliente = rgDest.id_terminale

        idArea = dgwDestinatarioArea(dgwcID_Area.Index, dgwDestinatarioArea.CurrentRow.Index).Value
        Dim idAbbinamento As Int16 = Int16.Parse(tmpDGW(dgwcIDAbbinamentoTMP.Index, e.RowIndex).Value)


        If Controllo = True Then
            Dim modificato As Boolean = False
            For Each rgDettaglio As dsControlloQualita.dtCqAbbinaAreaDettaglioDestinatarioRow In Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario
                If rgDettaglio.id = idAbbinamento Then
                    DtCqAbbinaAreaDettaglioDestinatario.DeleteQuery(idAbbinamento)
                    modificato = True
                    Exit For
                End If
            Next
            If Not modificato Then
                idDettaglio = DirectCast(bsDettaglio.Current, DataRowView).Row.Item("id")
                Dim ultimo As Int16
                ultimo = DtCqAbbinaAreaDettaglioDestinatario.sqUltimo(idDestinatario, idArea)
                DtCqAbbinaAreaDettaglioDestinatario.InsertQuery(idArea, idDettaglio, ultimo + 1, idDestinatario, idCliente)
                Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario.AcceptChanges()
            End If
            DtCqAbbinaAreaDettaglioDestinatario.Fill(Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario)
        Else
            For Each rgDettaglio As dsControlloQualita.dtCqAbbinaAreaDettaglioDestinatarioRow In Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario
                If rgDettaglio.id = idAbbinamento Then
                    DtCqAbbinaAreaDettaglioDestinatario.DeleteQuery(idAbbinamento)
                    DtCqAbbinaAreaDettaglioDestinatario.Fill(Me.DsControlloQualita.dtCqAbbinaAreaDettaglioDestinatario)
                    Exit For
                End If
            Next
        End If

    End Sub

    Private Sub TTBTAggiorna_Click(sender As Object, e As EventArgs) Handles TTBTAggiorna.Click
        AggiornaDati()
    End Sub

    Private Sub TTTestoRicerca_TextChanged(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        Dim testo As String = DirectCast(sender, ToolStripTextBox).Text
        If bsClienti.Count > 0 Then
            Dim ricerca As String = String.Format("societa LIKE '%{0}%'", testo)
            bsClienti.Filter = ricerca
            Dim lunghezza As Int16
            Do While True
                If bsClienti.Count < 1 Then
                    lunghezza += 1
                    If testo.Length - lunghezza > 0 Then
                        testo = testo.Substring(0, (testo.Length - lunghezza))
                    Else
                        bsClienti.RemoveFilter()
                        DirectCast(sender, ToolStripTextBox).Text = testo
                        DirectCast(sender, ToolStripTextBox).SelectionStart = testo.Length
                        Exit Do
                    End If
                    bsClienti.Filter = String.Format("societa LIKE '%{0}%'", testo)
                Else
                    DirectCast(sender, ToolStripTextBox).Text = testo
                    DirectCast(sender, ToolStripTextBox).SelectionStart = testo.Length
                    Exit Do
                End If
            Loop
        End If
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        bsClienti.RemoveFilter()
        DtClientidtDestinatariBindingSource.RemoveFilter()
        bsArea.RemoveFilter()
        bsDettaglio.RemoveFilter()
        dgwDettaglio.DataSource = ""

        Me.Close()
    End Sub

    Private Sub dgwDettaglio_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgwDettaglio.CellFormatting
        Dim tmpDGW As DataGridView
        tmpDGW = DirectCast(sender, DataGridView)
        Dim stile As New DataGridViewCellStyle

        If tmpDGW(dgwcDettaglioControllo.Index, e.RowIndex).Value = True Then
            tmpDGW.Rows(e.RowIndex).Cells(dgwcDettaglioIDdettaglio.Index).Style.BackColor = Color.Orange
            tmpDGW.Rows(e.RowIndex).Cells(dgwcDettaglioControllo.Index).Style.BackColor = Color.Orange
            tmpDGW.Rows(e.RowIndex).Cells(dgwcDettaglioControllo.Index).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        Else
            tmpDGW.Rows(e.RowIndex).Cells(dgwcDettaglioIDdettaglio.Index).Style.BackColor = Color.White
            tmpDGW.Rows(e.RowIndex).Cells(dgwcDettaglioControllo.Index).Style.BackColor = Color.White
            tmpDGW.Rows(e.RowIndex).Cells(dgwcDettaglioControllo.Index).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End If
    End Sub

    Private Sub tsbStampa_DropDownItem(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbStampa.DropDownItemClicked
        Dim tmpDGW As DataGridView
        tmpDGW = dgwCliente
        Dim idDest As Int16
        Dim rgDest As dsControlloQualita.dtDestinatariRow
        rgDest = DirectCast(DtClientidtDestinatariBindingSource.Current, DataRowView).Row
        idDest = rgDest.id
        Dim data As DateTime = DateTime.Parse(e.ClickedItem.Text.Substring(e.ClickedItem.Text.Length - 10, 10))
        stampaReport(idDest, data)
    End Sub
    Private Sub stampaReport(ByVal iddes As Int16, ByVal data As DateTime)

        Dim DataCorta As String = data.ToShortDateString
        Dim tpCq = (From g In Me.DsControlloQualita.dtCq Where g.data.ToShortDateString = DataCorta And g.id_des = iddes).ToLookup(Function(k) k.descrizione)
        Dim rtmp As dsControlloQualita.tmpCQRow
        Using TmpCQ As dsControlloQualita.tmpCQDataTable = New dsControlloQualita.tmpCQDataTable

            For Each rigaO In tpCq
                For Each rigaQ In rigaO
                    If rigaQ.valore = -1 Then
                        Continue For
                    End If
                    rtmp = TmpCQ.NewRow
                    rtmp.anagrafica = rigaQ.anagrafica
                    rtmp.societa = rigaQ.societa
                    rtmp.locazione = rigaQ.locazione
                    rtmp.valore = rigaQ.valore
                    rtmp.data = rigaQ.data
                    rtmp.area = rigaQ.descrizione
                    rtmp.nota = rigaQ.note
                    rtmp.descrizione = rigaQ.nome
                    rtmp.annotazioni = If(rigaQ.IsannotazioniNull, "", rigaQ.annotazioni)

                    If Not IsDBNull(rigaQ.location) Then
                        If Not rigaQ.location = "" Then
                            Try
                                Dim converter As New ImageConverter
                                Dim filename As String = String.Format("V:\ns\PW\cq\{0}", rigaQ.location)
                                rtmp.immagine = converter.ConvertTo(caricaImmagine(filename), GetType(Byte()))
                                'Dim img() As Byte = GetPhoto(String.Format("V:\ns\PW\cq\{0}", rigaQ.location))
                                'rtmp.immagine = img
                            Catch ex As Exception
                                MsgBox("Attenzione, Immagine mancante")
                            End Try


                        End If
                    End If
                    'TmpCQBindingSource.Add(rtmp)

                    TmpCQ.AddtmpCQRow(rtmp)
                    rtmp.AcceptChanges()

                Next

            Next
            TmpCQBindingSource.EndEdit()
            Me.ReportViewer1.ZoomMode = ZoomMode.PageWidth
            If TmpCQ.Count > 0 Then
                ReportViewer1.LocalReport.DataSources.Clear()
                Me.ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("DataSet1", TmpCQ.CopyToDataTable))
                Me.ReportViewer1.RefreshReport()
            Else
                MsgBox("Nessun Dato disponibile")
            End If

        End Using

    End Sub
    Private Sub tsbEliminaControllo_ItemClick(sender As Object, e As ToolStripItemClickedEventArgs) Handles tsbEliminaControllo.DropDownItemClicked
        Dim tmpDGW As DataGridView
        tmpDGW = dgwCliente
        Dim idCli, idDest As Int16
        Dim rgDest As dsControlloQualita.dtDestinatariRow
        rgDest = DirectCast(DtClientidtDestinatariBindingSource.Current, DataRowView).Row
        idDest = rgDest.id
        idCli = tmpDGW(dgwcClientiID.Index, tmpDGW.CurrentRow.Index).Value

        Dim k As String = e.ClickedItem.Text.Substring(e.ClickedItem.Text.Length - 10, 10)
        Dim data As DateTime = DateTime.Parse(k)
        Dim DataCorta As String = data.ToShortDateString
        If MsgBox("sei sicuro di vole eliminare la scheda del " & DataCorta & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Me.taCq.Eliminaschedaclienteperdata(idCli, idDest, DataCorta)
            AggiornaDati()
        End If
    End Sub



    Public Shared Function GetPhoto(filePath As String) As Byte()
        Dim stream As FileStream = New FileStream(
           filePath, FileMode.Open, FileAccess.Read)
        Dim reader As BinaryReader = New BinaryReader(stream)

        Dim photo() As Byte = reader.ReadBytes(stream.Length)

        reader.Close()
        stream.Close()

        Return photo
    End Function
    Private Shared Function caricaImmagine(ByVal filename As String) As System.Drawing.Image

        Dim stream As FileStream = New FileStream(
           filename, FileMode.Open, FileAccess.Read)
        Dim reader As BinaryReader = New BinaryReader(stream)
        Dim photo As Byte() = reader.ReadBytes(stream.Length)
        Dim maxwidth As Int16 = 177
        Dim maxheight As Int16 = 236


        Dim objImage As System.Drawing.Image
        Dim objResizedImg As System.Drawing.Image
        'Dim imgOutputFormat As ImageFormat
        'Dim ContentTypeName As String
        Dim DimOrizz As Integer
        Dim DimVert As Integer

        'Crea una istanza della immagine originale
        objImage = System.Drawing.Image.FromFile(filename)
        objImage.RotateFlip(RotateFlipType.Rotate90FlipX)
        DimOrizz = objImage.Width
        DimVert = objImage.Height
        If DimOrizz > maxwidth Then
            DimOrizz = maxwidth
            DimVert = (maxwidth / objImage.Width) * objImage.Height
            If maxheight > 0 Then
                If DimVert > maxheight Then
                    DimVert = maxheight *
                    DimOrizz = (maxheight / objImage.Height) * objImage.Width
                End If
            End If
        Else
            If DimVert > maxheight Then
                DimVert = maxheight
                DimOrizz = (maxheight / objImage.Height) * objImage.Width
            Else
                DimOrizz = objImage.Width
                DimVert = objImage.Height
            End If
        End If

        'Crea una istanza della immagine ridotta
        Dim callback As Image.GetThumbnailImageAbort
        callback = Nothing
        objResizedImg = objImage.GetThumbnailImage(DimOrizz, DimVert, callback, IntPtr.Zero)

        Return objResizedImg

        objImage.Dispose()
        objResizedImg.Dispose()

    End Function

    Private Function On_GetThumbnailAbort() As Boolean
        Return False
    End Function

    Dim ultimoIdDest As Int16
    Dim UltimaData As DateTime


    Private Sub tcSchedaElenco_SelectedIndexChange(sender As Object, e As EventArgs) Handles TCSchedaElenco.SelectedIndexChanged
        Dim tmpTC As TabControl
        tmpTC = DirectCast(sender, TabControl)

        Select Case tmpTC.SelectedIndex
            Case tpDettaglioInterventi.TabIndex

            Case tpReportCheckList.TabIndex
                popolaGrigliaCheckList()

                If ultimoIdDest <> 0 Then
                    For Each riga As DataGridViewRow In dgwElencoCheckUp.Rows
                        If riga.Cells(dgwcidDest.Index).Value = ultimoIdDest Then
                            If riga.Cells(dgwcData.Index).Value = UltimaData Then
                                dgwElencoCheckUp.CurrentCell = riga.Cells(dgwcDestinatario.Index)
                                Exit For

                            End If
                        End If
                    Next
                End If
        End Select

    End Sub
    Private Sub popolaGrigliaCheckList()
        dgwElencoCheckUp.Rows.Clear()
        Dim tpCq = (From g In Me.DsControlloQualita.dtCq Order By g.data Descending Group By g.id_des, g.locazione, g.data.ToShortDateString, g.anagrafica Into Group).ToList
        For Each tR In tpCq
            dgwElencoCheckUp.Rows.Add({tR.locazione, tR.id_des, tR.ToShortDateString, tR.anagrafica})
        Next

    End Sub

    Private Sub dgwElencoCheckUp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwElencoCheckUp.CellContentClick
        ultimoIdDest = dgwElencoCheckUp(dgwcidDest.Index, dgwElencoCheckUp.CurrentRow.Index).Value
        UltimaData = dgwElencoCheckUp(dgwcData.Index, dgwElencoCheckUp.CurrentRow.Index).Value

        Dim idDes As Int16
        Dim data As DateTime
        Dim tmpDGW As DataGridView
        tmpDGW = DirectCast(sender, DataGridView)
        idDes = tmpDGW(dgwcidDest.Index, e.RowIndex).Value
        data = tmpDGW(dgwcData.Index, e.RowIndex).Value
        stampaReport(idDes, data)
    End Sub

    Private Sub dgwDettaglio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDettaglio.CellContentClick

    End Sub
End Class