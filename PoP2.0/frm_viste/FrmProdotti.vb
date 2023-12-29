Imports System.Windows.Forms.DataVisualization.Charting

Public Class FrmProdotti
    Friend WithEvents Pic As PictureBox
    Friend WithEvents ProdottiTag As TextBox
    Dim PosizioneImmagini As String
    Dim idDBImmagini As Integer = 1
    Dim bsProdottiSimili As BindingSource
    Dim dsProdottiSimili As DataTable
    Dim grStatistiche As New System.Windows.Forms.DataVisualization.Charting.Chart()
    Dim dtStat As New DS_Ordini.dtStatisticheProdottiDataTable
    Dim idFor As Int16
    Public Sub New(Optional ByVal fornitore As Int16 = 0)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        idFor = fornitore
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FrmProdotti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        nudAnno.Maximum = Integer.Parse(GlobalVarPOP.GPeriodo.Split("-").First)
        nudAnno.Minimum = Integer.Parse(GlobalVarPOP.GPeriodo.Split("-").First) - 20
        nudAnno.Value = Integer.Parse(GlobalVarPOP.GPeriodo.Split("-").First)
        pagStatistiche.Controls.Add(grStatistiche)
        PosizioneImmagini = "V:\ns\PW\images\prodotti\"
        Me.TaCategorie.Fill(Me.DS_Ordini.dtCategorie)
        Me.TaProdotti.Fill(Me.DS_Ordini.dtProdotti)
        dsProdottiSimili = DS_Ordini.dtProdotti

        bsProdottiSimili = New BindingSource
        bsProdottiSimili.DataMember = dsProdottiSimili.TableName
        bsProdottiSimili.DataSource = dsProdottiSimili

        Me.TaProdottiMarche.Fill(Me.DS_Ordini.dtProdottiMarche)
        Me.TA_fornitori.Fill(Me.DS_Ordini.DT_fornitori)
        Me.TaImmagini.FillByDatabase(Me.DS_Ordini.DTimmagini, idDBImmagini)
        'Me.dgwProdotti.Controls.Add(Pic)
        If idFor <> 0 Then
            bsProdotti.Filter = String.Format("id_fornitore = {0}", idFor)
            'bsProdotti.Position = bsProdotti.Find(idPro, "id_fornitore")
        End If
        AddHandler bsProdotti.CurrentChanged, AddressOf AggiornaInfo

    End Sub
    Private Sub CreaImmagine(ByVal posizione As Point)
        Pic = New System.Windows.Forms.PictureBox()
        'Dim pos As Point = New System.Drawing.Point(0, 0)
        CType(Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Pic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Pic.Location = posizione
        Pic.Name = "Pic"
        Pic.Size = New System.Drawing.Size(300, 300)
        Pic.TabIndex = 120
        Pic.TabStop = False
        Pic.Visible = True
        Pic.SizeMode = PictureBoxSizeMode.StretchImage
        Pic.Dock = DockStyle.Fill
        Pic.BackgroundImageLayout = ImageLayout.Tile
        CType(Pic, System.ComponentModel.ISupportInitialize).EndInit()
    End Sub
    Private Sub AggiornaInfo()
        If bsProdotti.Count < 0 Then
            Return
        End If
        Dim rg As DS_Ordini.dtProdottiRow
        rg = DirectCast(bsProdotti.Current, DataRowView).Row

        dgwProdottiSimili.Rows.Clear()
        bsProdottiSimili.RemoveFilter()
        If rg.tag.Length > 0 Then
            Dim numeroTag As Integer = rg.tag.Split(",").Count
            Dim Parole(numeroTag) As String
            Dim Frase As String

            For hh = 0 To numeroTag - 1

                Parole(hh) = rg.tag.Split(",").Skip(hh).First
                If hh = 0 Then
                    Frase = "tag like '%{" + hh.ToString() + "}%'"
                Else
                    Frase += " OR tag like '%{" + hh.ToString() + "}%'"
                End If

            Next
            Dim Filtro As String
            Filtro = String.Format(Frase, Parole)
            bsProdottiSimili.Filter = Filtro
            If bsProdottiSimili.Count = bsProdotti.Count Then
            Else
                For Each rgSimili As DataRowView In bsProdottiSimili
                    Dim rgtmp As DS_Ordini.dtProdottiRow
                    rgtmp = DirectCast(rgSimili, DataRowView).Row
                    Dim paDG() As String = {rgtmp.id.ToString(), rgtmp.descrizione, rgtmp.prezzounitario.ToString("c2"), rgtmp.fornitore}
                    dgwProdottiSimili.Rows.Add(paDG)
                Next
            End If

        End If
        AggiornaImmagine(rg)

    End Sub
    Private Sub picAggiungeElimina(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgwProdotti.CellMouseClick
        If e.Button = MouseButtons.Right Then
            Dim RGim As DS_Ordini.DTimmaginiRow
            Dim pos As Integer = bsImmagini.Position
            Dim idImmagine As Integer = DirectCast(bsProdotti.Current, DataRowView).Row.Field(Of Integer)("id")
            If pos > 0 Then
                Dim PosDoc As New OpenFileDialog()
                If PosDoc.ShowDialog() = DialogResult.OK Then
                    Dim VecchiaImmagine As String = PosDoc.FileName()
                    Dim Estensione As String
                    Estensione = System.IO.Path.GetExtension(VecchiaImmagine)
                    Dim NuovaImmagine As String
                    NuovaImmagine = PosizioneImmagini & idImmagine & Estensione
                    'Cerco se esite il file immagine
                    Rimodella_e_memorizza_Immagine(VecchiaImmagine, NuovaImmagine, 300, 300, 150)
                    bsImmagini.AddNew()
                    RGim = DirectCast(bsImmagini.Current, DataRowView).Row
                    RGim.iddatabase = 1
                    RGim.idriferimento = idImmagine
                    RGim.urlfoto = idImmagine & Estensione
                    If TaImmagini.inserisce(RGim.iddatabase, RGim.idriferimento, RGim.urlfoto) > 0 Then
                        bsImmagini.EndEdit()
                        RGim.AcceptChanges()
                    End If
                End If
            Else
                Dim risposta As MsgBoxResult = MsgBox("Vuoi eliminare l'immagine o annullare?", MsgBoxStyle.YesNo)
                Select Case risposta
                    Case MsgBoxResult.Yes
                        bsImmagini.Position = pos
                        RGim = DirectCast(bsImmagini.Current, DataRowView).Row
                        'Cerco se esite il file immagine
                        Dim flImmagine As String = PosizioneImmagini & RGim.urlfoto
                        If IO.File.Exists(flImmagine) Then
                            Pic.Image.Dispose()
                            'IO.File.Delete(flImmagine)
                            TaImmagini.elimina(RGim.id)
                            RGim.Delete()
                        End If

                End Select
            End If
        End If

    End Sub
    Private Sub AggiornaImmagine(ByVal rg As DS_Ordini.dtProdottiRow)
        If TrovaControl(Pic) Then
            tblImmagini.Controls.Remove(Pic)
        End If
        If rg.RowState = DataRowState.Added Or rg.RowState = DataRowState.Detached Then
            Return
        End If

        Dim idProd As Integer = rg.id
        If idProd < 0 Then
            Return
        End If
        Dim RGimg As DS_Ordini.DTimmaginiRow

        Dim pos As Integer = bsImmagini.Find("idriferimento", idProd)

        If pos >= 0 Then
            bsImmagini.Position = pos
            RGimg = DirectCast(bsImmagini.Current, DataRowView).Row
            Dim posizione As Point = New Point 'Me.PointToClient(dgwProdotti.MousePosition)
            posizione.X = 10
            posizione.Y = pagProdotti.Height - 300
            CreaImmagine(posizione)
            Dim flImmagine As String = PosizioneImmagini & RGimg.urlfoto
            If IO.File.Exists(flImmagine) Then
                Dim Immagine As Bitmap
                Immagine = New Bitmap(flImmagine)
                Pic.Image = Immagine
                tblImmagini.Controls.Add(Pic)
                'pagProdotti.Controls.Add(Pic)
            End If
        End If
    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        dgwProdotti.DataSource = ""
        Me.Close()
    End Sub
    Private Function TrovaControl(ByVal controllo As Control)
        If Not IsNothing(controllo) Then
            For Each ctl As Control In tblImmagini.Controls
                If ctl.Name = controllo.Name Then
                    Return True
                End If
            Next
            Return False
        End If
        Return False
    End Function

    Private Sub dgwProdotti_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles dgwProdotti.CellValidating

        Dim rg As DS_Ordini.dtProdottiRow = DirectCast(bsProdotti.Current, DataRowView).Row
        Dim campo As String = dgwProdotti.Columns(e.ColumnIndex).DataPropertyName
        Dim Cella As DataGridViewCell = dgwProdotti(e.ColumnIndex, e.RowIndex)
        Dim cancella As Boolean = False
        Dim risposta As String = ""

        Dim tipo As Type
        tipo = rg.Item(campo).GetType
        If rg.RowState = DataRowState.Modified Then
            Select Case tipo.Name
                Case "Int32"
                    Select Case campo
                        Case "id_tipologia"
                            If bsCategorie.Find("descrizione", e.FormattedValue) >= 0 Then
                                Dim tipoID As Integer = DirectCast(bsCategorie.Current, DataRowView).Row.Item("id")
                                rg.Item(campo) = tipoID
                            Else
                                risposta = "Tipologia non valida"
                                cancella = True
                            End If
                        Case "id_fornitore"
                            If bsFornitori.Find("anagrafica", e.FormattedValue) >= 0 Then
                                Dim tipoID As Integer = DirectCast(bsFornitori.Current, DataRowView).Row.Item("id")
                                rg.Item(campo) = tipoID
                            Else
                                risposta = "Fornitore non valido"
                                cancella = True
                            End If
                        Case "id_marca"
                            If bsProdottiMarche.Find("Azienda", e.FormattedValue) >= 0 Then
                                Dim tipoID As Integer = DirectCast(bsProdottiMarche.Current, DataRowView).Row.Item("id")
                                rg.Item(campo) = tipoID
                            Else
                                risposta = "Marca non valido"
                                cancella = True
                            End If

                        Case "id"
                            If e.FormattedValue <> rg.Item(campo) Then
                                rg.Item(campo) = e.FormattedValue
                            End If
                    End Select
            End Select

        End If
        Cella.ErrorText = risposta
        e.Cancel = cancella

    End Sub

    Private Sub dgwProdotti_UserDeleting(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgwProdotti.UserDeletingRow
        Dim rg As DS_Ordini.dtProdottiRow
        rg = DirectCast(bsProdotti.Current, DataRowView).Row
        Dim nProdottiUsati As Integer
        Dim UltimoOrdine As DateTime
        Dim idprodotto As Integer = rg.id
        Using taOrd As New DS_OrdiniTableAdapters.TAordinirighe
            nProdottiUsati = taOrd.SQcercaprodottiusati(idprodotto)
            If nProdottiUsati > 0 Then
                UltimoOrdine = taOrd.SQUltimoUtilizzoProdotto(idprodotto)
            End If
        End Using
        If MsgBox("Confermi l'eliminazione ? " +
                  If(nProdottiUsati > 0, " Sono presenti " +
                  nProdottiUsati.ToString +
                  " ordini con questo prodotto " +
                  "Ultimo Ordine il " + UltimoOrdine.ToShortDateString, ""), MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TaProdotti.Elimina(idprodotto)
        Else
            e.Cancel = True
        End If
    End Sub
    Private Sub dgwProdotti_UserDeleted(sender As Object, e As DataGridViewRowEventArgs) Handles dgwProdotti.UserDeletedRow
        Dim rg As DS_Ordini.dtProdottiRow
        rg = DirectCast(bsProdotti.Current, DataRowView).Row
        Dim idprodotto As Integer = rg.id
        bsProdotti.RemoveFilter()
        TTTestoRicerca.Text = ""
        bsProdotti.Position = bsProdotti.Find("id", idprodotto)
    End Sub

    Private Sub dgwProdotti_RowValidating(sender As Object, e As DataGridViewCellCancelEventArgs) Handles dgwProdotti.RowValidating
        If dgwProdotti(DGWCId.Index, e.RowIndex).Value < 0 Then
            Dim Cella As DataGridViewCell = dgwProdotti(e.ColumnIndex, e.RowIndex)
            Dim cancella As Boolean = False
            Dim risposta As String = ""
            Dim rg As DS_Ordini.dtProdottiRow
            rg = DirectCast(bsProdotti.Current, DataRowView).Row
            Select Case True
                Case rg.Isid_fornitoreNull
                    risposta = "Fornitore mancante"
                    cancella = True
                Case rg.Isid_marcaNull
                    risposta = "Marca Mancante"
                    cancella = True
                Case rg.Isid_tipologiaNull
                    risposta = "Tipologia Mancante"
                    cancella = True
                Case rg.IsprezzoconfezioneNull
                    dgwProdotti(DGWCPrezzoconfezione.Index, e.RowIndex).Value = dgwProdotti(DGWCPrezzounitario.Index, e.RowIndex).Value * dgwProdotti(DGWCquantita.Index, e.RowIndex).Value
                Case rg.IstipoconfezioneNull
                    risposta = "Tipo Confezione Mancante"
                    cancella = True
                Case rg.IsdescrizioneNull
                    risposta = "Descrizione Mancante"
                    cancella = True
                Case IsDBNull(dgwProdotti(DGWCNote.Index, e.RowIndex).Value)
                    dgwProdotti(DGWCNote.Index, e.RowIndex).Value = ""
                Case rg.data.ToString = "01/01/2001 00:00:00"
                    dgwProdotti(DGWCdata.Index, e.RowIndex).Value = Now()
                Case rg.IstaxNull
                    dgwProdotti(DGWCtax.Index, e.RowIndex).Value = GlobalVarPOP.G_iva
                    cancella = False
                Case rg.IsscontoNull
                    dgwProdotti(DGWCsconto.Index, e.RowIndex).Value = 0
                Case rg.Isquantita_confNull
                    dgwProdotti(DGWCquantita.Index, e.RowIndex).Value = 1
            End Select
            If cancella Then
                Cella.ErrorText = risposta
            End If
            e.Cancel = cancella
        End If

    End Sub
    Private Sub dgwProdotti_RowValidate(sender As Object, e As DataGridViewCellEventArgs) Handles dgwProdotti.RowValidated
        Dim rg As DS_Ordini.dtProdottiRow
        rg = DirectCast(bsProdotti.Current, DataRowView).Row
        Select Case rg.RowState
            Case DataRowState.Added
                TaProdotti.Inserisce(rg.descrizione, rg.id_tipologia,
                             rg.id_fornitore, rg.sconto,
                             rg.prezzoconfezione, rg.tipoconfezione,
                             rg.prezzounitario, rg.quantita_conf,
                             rg.data, rg.note,
                             rg.schedatura, rg.fatturabile,
                             rg.id_marca, rg.tag, rg.tax,
                             If(rg.IsprezzovenditaNull, vbNull, rg.prezzovendita),
                             If(rg.IsdescrizioneclienteNull, rg.descrizione, rg.descrizionecliente))
                rg.id = TaProdotti.SQultimoID()
                rg.AcceptChanges()

            Case DataRowState.Modified
                TaProdotti.ModificaByID(rg.descrizione, rg.id_tipologia, rg.id_fornitore, rg.sconto, rg.prezzoconfezione, rg.prezzounitario,
                                        rg.tipoconfezione, rg.quantita_conf, rg.data,
                                        rg.note, rg.schedatura, rg.fatturabile, rg.id_marca, rg.tag, rg.tax,
                                        If(rg.IsprezzovenditaNull, vbNull, rg.prezzovendita), If(rg.IsdescrizioneclienteNull, rg.descrizione, rg.descrizionecliente), rg.id)
                rg.AcceptChanges()
        End Select

    End Sub

    Private Sub TTTestoRicerca_Click(sender As Object, e As EventArgs) Handles TTTestoRicerca.TextChanged
        If bsProdotti.Count < 0 Then
            Return
        End If
        Dim testo As ToolStripTextBox = DirectCast(sender, ToolStripTextBox)
        bsProdotti.Filter = String.Format("descrizione like '%{0}%' or tag like '%{0}%'", testo.Text)
        If bsProdotti.Count <= 0 Then
            testo.Text = ""
            bsProdotti.RemoveFilter()
        End If
    End Sub

    Private Sub TTBTRicarica_Click(sender As Object, e As EventArgs) Handles TTBTRicarica.Click
        Dim rg As DS_Ordini.dtProdottiRow
        rg = DirectCast(bsProdotti.Current, DataRowView).Row
        Dim oldID As Integer = rg.id
        Me.TaProdotti.Fill(Me.DS_Ordini.dtProdotti)
        bsProdotti.RemoveFilter()
        TTTestoRicerca.Text = ""
        bsProdotti.Position = bsProdotti.Find("id", oldID)
    End Sub

    Private Sub DescrizioneclienteTextBox_TextChanged(sender As Object, e As EventArgs)
        If bsProdotti.Count <= 0 Then
            Return
        End If
        bsProdotti.EndEdit()
        Dim rg As DS_Ordini.dtProdottiRow
        rg = DirectCast(bsProdotti.Current, DataRowView).Row
        Select Case rg.RowState
            Case DataRowState.Added
                TaProdotti.Inserisce(rg.descrizione, rg.id_tipologia,
                             rg.id_fornitore, rg.sconto,
                             rg.prezzoconfezione, rg.tipoconfezione,
                             rg.prezzounitario, rg.quantita_conf,
                             rg.data, rg.note,
                             rg.schedatura, rg.fatturabile,
                             rg.id_marca, rg.tag, rg.tax,
                             If(rg.IsprezzovenditaNull, vbNull, rg.prezzovendita),
                             If(rg.IsdescrizioneclienteNull, rg.descrizione, rg.descrizionecliente))
                rg.id = TaProdotti.SQultimoID()
                rg.AcceptChanges()

            Case DataRowState.Modified
                TaProdotti.ModificaByID(rg.descrizione, rg.id_tipologia, rg.id_fornitore, rg.sconto, rg.prezzoconfezione, rg.prezzounitario,
                                        rg.tipoconfezione, rg.quantita_conf, rg.data,
                                        rg.note, rg.schedatura, rg.fatturabile, rg.id_marca, rg.tag, rg.tax,
                                        If(rg.IsprezzovenditaNull, vbNull, rg.prezzovendita), If(rg.IsdescrizioneclienteNull, rg.descrizione, rg.descrizionecliente), rg.id)
                rg.AcceptChanges()
        End Select

    End Sub


    Private Sub dgwProdottiSimili_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        Dim id As Integer
        id = dgwProdottiSimili(dgwcSID.Index, e.RowIndex).Value
        If MsgBox("Vado al prodotto selezionato ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            bsProdotti.RemoveFilter()
            bsProdotti.Position = bsProdotti.Find("id", id)
        End If
    End Sub

    Private Sub btPropostaPrezzoVendita_Click(sender As Object, e As EventArgs)
        If bsProdotti.Count <= 0 Then
            Return
        End If
        Dim rg As DS_Ordini.dtProdottiRow
        rg = DirectCast(bsProdotti.Current, DataRowView).Row
        PrezzovenditaTextBox.Text = Math.Round((rg.prezzounitario * rg.sconto / 100 * 1.7), 1)
        PrezzovenditaTextBox.Focus()
    End Sub

    Private Sub tabCambia(sender As Object, e As EventArgs) Handles tapProdotti.SelectedIndexChanged

        If pagStatistiche.Name = tapProdotti.SelectedTab.Name Then
            caricaTabellaStatistiche()
        End If

    End Sub

    Private Sub nudAnno_ValueChanged(sender As Object, e As EventArgs) Handles nudAnno.ValueChanged
        caricaTabellaStatistiche()
    End Sub
    Private Sub caricaTabellaStatistiche()
        If bsProdotti.Count <= 0 Then
            Return
        End If
        dtStat.Rows.Clear()
        Using taStat As New DS_OrdiniTableAdapters.taStatisticheProdotti
            Select Case True
                Case ckAnno.Checked
                    taStat.FillByAnno(dtStat, nudAnno.Value)
                Case ckFornitore.Checked
                    taStat.FillByFornitore(dtStat, cbFornitore.SelectedValue)
                Case ckProdotto.Checked
                    Dim id As Int16 = Nothing
                    Try
                        id = dgwStatistiche(dgwcStid_prodotto.Index, dgwStatistiche.CurrentRow.Index).Value
                        taStat.FillByIDprodotto(dtStat, id)
                    Catch ex As Exception
                        If id = Nothing Then
                            Return
                        End If
                    End Try
                Case Else
                    taStat.FillByContaOccorrenze(dtStat)
            End Select
            dgwStatistiche.Rows.Clear()
            For Each rgSimili As DS_Ordini.dtStatisticheProdottiRow In dtStat.Rows
                Dim dgr As New DataGridViewRow
                dgr.CreateCells(dgwStatistiche)
                dgr.Cells(dgwcStid_prodotto.Index).Value = rgSimili.id_prodotto
                dgr.Cells(dgwcStDescrizione.Index).Value = rgSimili.descrizione
                dgr.Cells(dgwcStPrezzoLordo.Index).Value = rgSimili.spesalorda
                dgr.Cells(dgwcStPrezzoNetto.Index).Value = rgSimili.spesanetta
                dgr.Cells(dgwcStidFornitore.Index).Value = rgSimili.id_fornitore
                dgr.Cells(dgwcStOccorrenze.Index).Value = rgSimili.occorrenze
                dgr.Cells(dgwcStAnno.Index).Value = If(rgSimili.IsannoNull, "", rgSimili.anno)
                dgwStatistiche.Rows.Add(dgr)
            Next
        End Using
    End Sub

    Private Sub cbFornitore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbFornitore.SelectedIndexChanged
        ckAnno.Checked = Not ckFornitore.Checked
        ckProdotto.Checked = Not ckFornitore.Checked
        If ckFornitore.Checked Then
            caricaTabellaStatistiche()
        End If
    End Sub

    Private Sub ckAnno_CheckedChanged(sender As Object, e As EventArgs) Handles ckAnno.CheckedChanged
        ckProdotto.Checked = Not ckAnno.Checked
        ckFornitore.Checked = Not ckAnno.Checked
        If ckAnno.Checked = True Then
            caricaTabellaStatistiche()
        End If
    End Sub
    Private Sub ckProdotto_CheckedChanged(sender As Object, e As EventArgs) Handles ckProdotto.CheckedChanged
        ckAnno.Checked = Not ckProdotto.Checked
        ckFornitore.Checked = Not ckProdotto.Checked
        If ckProdotto.Checked = True Then
            caricaTabellaStatistiche()
        End If
    End Sub


    Private Sub tracciaGrafico(ByVal tmpTabella As DataTable)
        grStatistiche.ChartAreas.Clear()
        grStatistiche.Legends.Clear()
        grStatistiche.Series.Clear()
        grStatistiche.Visible = True
        Dim ChartArea1 As ChartArea = New ChartArea()
        Dim Legend1 As Legend = New Legend()
        Dim Series1 As Series = New Series()
        ChartArea1.Name = "Area 1"
        grStatistiche.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legenda"
        grStatistiche.Legends.Add(Legend1)
        grStatistiche.Name = "Grafico"
        Series1.ChartArea = "Area 1"
        Series1.Legend = "Legenda"
        Series1.Name = "Occorrenze"
        grStatistiche.Series.Add(Series1)
        grStatistiche.Size = New System.Drawing.Size(800, 400)
        grStatistiche.TabIndex = 0
        grStatistiche.Text = "Grafico Statistico"
        grStatistiche.Series("Occorrenze").XValueMember = "anno"
        grStatistiche.Series("Occorrenze").YValueMembers = "occorrenze"
        grStatistiche.DataSource = tmpTabella
        grStatistiche.Location = New Point(10, 10)
    End Sub

    Private Sub btTracciailGrafico_Click(sender As Object, e As EventArgs) Handles btTracciailGrafico.Click
        If dtStat.Rows.Count > 0 Then
            tracciaGrafico(dtStat)
        End If
    End Sub

End Class