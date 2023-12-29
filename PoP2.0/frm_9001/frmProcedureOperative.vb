Imports System.Text



Public Class frmProcedureOperative
    Friend dtTabRighe As DataTable = New dsProcedure.dtProcedureRigheDataTable
    Friend dtTabIOP As DataTable = New dsProcedure.dtProcedureIOPDataTable
    Friend dtTabRev As DataTable = New dsProcedure.dtProcedureRevisioneDataTable
    Dim rgNuova As Boolean = False


    Private Sub frmProcedureOperative_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TaProdotti.Fill(Me.DsProcedure.dtProdotti)
        Me.TaProcedureIstruzioni.Fill(Me.DsProcedure.dtProcedureIstruzioni)
        Me.TaMacchinari.Fill(Me.DsProcedure.dtMacchinari)
        Me.TaProcedureCategorie.Fill(Me.DsProcedure.dtProcedureCategorie)
        Me.TaProcedureRevisione.Fill(Me.DsProcedure.dtProcedureRevisione)
        Me.TaProcedureIOP.Fill(Me.DsProcedure.dtProcedureIOP)

        AddHandler bsProcedureIOP.CurrentChanged, AddressOf aggiornaOperazioni
        ReportViewer1.ZoomMode = ZoomMode.FullPage
        aggiornaOperazioni()

    End Sub


    Private Sub aggiornaOperazioni()
        Dim rgOperative As dsProcedure.dtProcedureIOPRow
        rgOperative = DirectCast(bsProcedureIOP.Current, DataRowView).Row
        Dim drow As DataTable = New DataTable

        Try
            Me.TaProcedureRighe.Fill(Me.DsProcedure.dtProcedureRighe)
            drow = Me.DsProcedure.dtProcedureRighe.Select(String.Format("id_operative = {0}", rgOperative.id)).CopyToDataTable
        Catch ex As Exception
            Dim err As DataRow() = drow.GetErrors
            For Each vv In err
                Console.WriteLine(vv.RowError)
            Next
        End Try
        Dim ddt As dsProcedure.dtProcedureRigheDataTable = Me.DsProcedure.dtProcedureRighe
        ddt.Rows.Clear()
        Dim rrg As dsProcedure.dtProcedureRigheRow

        For Each i In drow.Rows
            rrg = ddt.NewRow
            rrg.descrizione = If(IsDBNull(i("descrizione")), "", i("descrizione"))
            rrg.id = If(IsDBNull(i("id")), "", i("id"))
            rrg.id_categoria = If(IsDBNull(i("id_categoria")), 0, i("id_categoria"))
            rrg.id_istruzioni = If(IsDBNull(i("id_istruzioni")), 0, i("id_istruzioni"))
            rrg.id_macchinario = If(IsDBNull(i("id_macchinario")), 0, i("id_macchinario"))
            rrg.id_operative = If(IsDBNull(i("id_operative")), 0, i("id_operative"))
            rrg.id_prodotto = If(IsDBNull(i("id_prodotto")), 0, i("id_prodotto"))
            rrg.note = If(IsDBNull(i("note")), Nothing, i("note"))
            rrg.prodotto = If(IsDBNull(i("prodotto")), "", i("prodotto"))
            rrg.sort = If(IsDBNull(i("sort")), 0, i("sort"))
            rrg.testo = If(IsDBNull(i("testo")), "", i("testo"))
            ddt.Rows.Add(rrg)
        Next
        ddt.AcceptChanges()
        dtProcedureIOPBindingSource.Filter = String.Format("id = {0}", rgOperative.id)
        dtProcedureRevisioneBindingSource.Filter = String.Format("id_procedura = {0}", rgOperative.id)
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub dgwIOP_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgwIOP.RowValidated
        Dim bs As BindingSource = bsProcedureIOP
        Dim ta As dsProcedureTableAdapters.taProcedureIOP
        ta = TaProcedureIOP
        Dim rgRighe As dsProcedure.dtProcedureIOPRow
        If bs.Count <= 0 Then
            Return
        End If
        bs.EndEdit()
        rgRighe = DirectCast(bs.Current, DataRowView).Row
        Select Case rgRighe.RowState
            Case DataRowState.Added

                Dim ris As Integer = ta.InsertQuery(converteUTF8(rgRighe.titolo), If(rgRighe.IsdataNull, Now().ToShortDateString, rgRighe.data), If(rgRighe.IslivelloNull, 1, rgRighe.livello), If(rgRighe.IsnoteNull, Nothing, If(rgRighe.note = "", Nothing, rgRighe.note)))
                'rgRighe.id = ta.SQultimoID()
                'dgwIOP(dgwcIDIOP.Index, e.RowIndex).Value = rgRighe.id
                rgRighe.AcceptChanges()
            Case DataRowState.Modified
                Dim ris As Integer = ta.UpdateQuery(converteUTF8(rgRighe.titolo), If(rgRighe.IsdataNull, Now().ToShortDateString, rgRighe.data), If(rgRighe.IslivelloNull, 1, rgRighe.livello), If(rgRighe.IsnoteNull, Nothing, If(rgRighe.note = "", Nothing, rgRighe.note)), rgRighe.id)
                rgRighe.AcceptChanges()
        End Select
    End Sub
    Private Function converteUTF8(ByVal s As String) As String
        '       Return s


        Dim utf8 As System.Text.UTF8Encoding = New System.Text.UTF8Encoding(True, True)


        ' We need to dimension the array, since we'll populate it with 2 method calls.
        Dim bytes(utf8.GetByteCount(s) + utf8.GetPreamble().Length - 1) As Byte
        ' Encode the string.
        Array.Copy(utf8.GetPreamble(), bytes, utf8.GetPreamble().Length)
        utf8.GetBytes(s, 0, s.Length, bytes, utf8.GetPreamble().Length)

        ' Decode the byte array.
        Dim s2 As String = utf8.GetString(bytes, 0, bytes.Length)
        Console.WriteLine(s2)
        Return s2
    End Function
    Private Sub dgwRevisione(sender As Object, e As DataGridViewCellEventArgs) Handles dgwRevisioni.RowValidated
        Dim ultimaRev As Decimal
        Dim idIOP As Int32 = DirectCast(bsProcedureIOP.Current, DataRowView).Row.Field(Of Int32)("id")
        Dim bs As BindingSource = rlProcedureIOP_ProcedureRevisione
        Dim ta As dsProcedureTableAdapters.taProcedureRevisione
        ta = TaProcedureRevisione
        Try
            ultimaRev = ta.SQultimaVersione(idIOP)
        Catch ex As Exception
            ultimaRev = 0
        End Try



        Dim rgRighe As dsProcedure.dtProcedureRevisioneRow
        If bs.Count <= 0 Then
            Return
        End If
        bs.EndEdit()
        rgRighe = DirectCast(bs.Current, DataRowView).Row
        Select Case rgRighe.RowState
            Case DataRowState.Added
                Dim ris As Integer = ta.InsertQuery(rgRighe.id_procedura, Now().ToShortDateString, ultimaRev + 1)
                rgRighe.AcceptChanges()
            Case DataRowState.Modified
                Dim ris As Integer = ta.UpdateQuery(rgRighe.id_procedura, rgRighe.data, rgRighe.num_rev, rgRighe.id)
                rgRighe.AcceptChanges()
        End Select
    End Sub
    Private Sub dgwRighe_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles dgwProdotti.RowValidated, dgwAttrezzature.RowValidated, dgwDPI.RowValidated,
                                                                                                dgwMacchinari.RowValidated, dgwIstruzioni.RowValidated
        Dim dgw As DataGridView
        dgw = DirectCast(sender, DataGridView)
        Dim bs As BindingSource = dgw.DataSource
        If bs.Count <= 0 Then
            Return
        End If

        Dim ta As dsProcedureTableAdapters.taProcedureRighe
        ta = TaProcedureRighe
        Dim rgRighe As dsProcedure.dtProcedureRigheRow
        rgRighe = DirectCast(bs.Current, DataRowView).Row
        Select Case rgRighe.RowState
            Case DataRowState.Modified
                'If Not rgRighe.IsnoteNull Then
                Dim ris As Integer = ta.UpdateQuery(rgRighe.id_operative, rgRighe.id_categoria, If(rgRighe.Isid_macchinarioNull, Nothing, rgRighe.id_macchinario),
                                                                                                    If(rgRighe.Isid_istruzioniNull, Nothing, rgRighe.id_istruzioni),
                                                                                                    If(rgRighe.Isid_prodottoNull, Nothing, rgRighe.id_prodotto),
                                                                                                    If(rgRighe.IsnoteNull, Nothing, If(rgRighe.note = "", Nothing, rgRighe.note)), rgRighe.sort, rgRighe.id)
                rgRighe.AcceptChanges()
                aggiornaOperazioni()
                'End If
        End Select
        bs.EndEdit()

    End Sub
    Private Sub dgwIOP_UserDeleting(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgwIOP.UserDeletingRow
        If MsgBox("Elimino la riga ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim id As Int16
            id = e.Row.Cells(0).Value
            Dim ta As dsProcedureTableAdapters.taProcedureIOP
            ta = TaProcedureIOP
            Dim ris As Int16 = ta.DeleteQuery(id)
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub dgw_UserDeleting(sender As Object, e As DataGridViewRowCancelEventArgs) Handles dgwProdotti.UserDeletingRow, dgwAttrezzature.UserDeletingRow, dgwDPI.UserDeletingRow, dgwIstruzioni.UserDeletingRow, dgwMacchinari.UserDeletingRow
        If e.Row.Index >= 0 Then
            Dim cosa As String = e.Row.Cells(1).Value
            If MsgBox("Elimino " + cosa + " dalla riga ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim id As Int16
                id = e.Row.Cells(0).Value
                If id > 0 Then
                    Dim ta As dsProcedureTableAdapters.taProcedureRighe
                    ta = TaProcedureRighe
                    Dim ris As Int16 = ta.DeleteQuery(id)
                End If
            Else
                e.Cancel = True
            End If
            aggiornaOperazioni()
        End If

    End Sub


    Private MouseDownRectangle As Rectangle
    Private rowIndexFromMouseDown As Integer

    Private Sub dgw_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgwProdotti.MouseMove, dgwMacchinari.MouseMove,
                                                                                         dgwIstruzioni.MouseMove, dgwDPI.MouseMove, dgwAttrezzature.MouseMove

        Dim dgw As DataGridView = DirectCast(sender, DataGridView)
        If (e.Button And MouseButtons.Left) = MouseButtons.Left Then
            If MouseDownRectangle <> Rectangle.Empty AndAlso (Not MouseDownRectangle.Contains(e.X, e.Y)) Then
                rowIndexFromMouseDown = dgw.CurrentRow.Index
                Dim dropEffect As DragDropEffects = dgw.DoDragDrop(dgw.Rows(rowIndexFromMouseDown), DragDropEffects.Move)
            End If
        End If
    End Sub
    Private Sub dgw_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles dgwProdotti.MouseDown, dgwMacchinari.MouseDown,
                                                                                         dgwIstruzioni.MouseDown, dgwDPI.MouseDown, dgwAttrezzature.MouseDown

        Dim dgw As DataGridView = DirectCast(sender, DataGridView)

        rowIndexFromMouseDown = dgw.HitTest(e.X, e.Y).RowIndex
        If rowIndexFromMouseDown <> -1 Then
            Dim dragSize As Size = SystemInformation.DragSize
            MouseDownRectangle = New Rectangle(New Point(e.X - (dragSize.Width \ 2), e.Y - (dragSize.Height \ 2)), dragSize)
        Else
            MouseDownRectangle = Rectangle.Empty
        End If
    End Sub
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub DataGridView1_DragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles dgwProdotti.DragOver, dgwMacchinari.DragOver,
                                                                                         dgwIstruzioni.DragOver, dgwDPI.DragOver, dgwAttrezzature.DragOver
        e.Effect = DragDropEffects.Move
    End Sub



    Private Sub dgwRighe_DragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles dgwAttrezzature.DragDrop, dgwDPI.DragDrop, dgwIstruzioni.DragDrop,
                                                                                            dgwMacchinari.DragDrop, dgwProdotti.DragDrop
        Dim dgw As DataGridView = DirectCast(sender, DataGridView)
        Dim bs As BindingSource = dgw.DataSource

        Dim ta As dsProcedureTableAdapters.taProcedureRighe
        ta = TaProcedureRighe
        Dim col As DataGridViewTextBoxColumn = dgw.Columns(3)   'Colonna Sort

        Dim clientPoint As Point = dgw.PointToClient(New Point(e.X, e.Y))
        Dim rowdoporilascio As Int16
        Dim rowprimarilascio As Int16
        rowdoporilascio = dgw.HitTest(clientPoint.X, clientPoint.Y).RowIndex
        rowprimarilascio = dgw.CurrentRow.Index

        Dim ValdopoRilascio As Int16
        If rowdoporilascio >= dgw.Rows.Count - 1 Then
            ValdopoRilascio = dgw.Rows.Count - 1
        Else
            ValdopoRilascio = dgw(col.Index, rowdoporilascio).Value
            'Aggiunge alla riga dove mi posiziono il valore della sua riga + uno in modo da spostarla più in basso
            dgw(col.Index, rowdoporilascio).Value = dgw(col.Index, rowdoporilascio).Value + 1
        End If

        If e.Effect = DragDropEffects.Move Then
            'Aggiunge alla riga che devo posizionare il valore della riga del datagrid
            dgw(col.Index, rowprimarilascio).Value = rowdoporilascio

            Dim idrigaVecchia As Int16 = dgw(0, rowprimarilascio).Value
            'imposta il Sort nel datatable
            ta.UpdateSort(ValdopoRilascio, idrigaVecchia)
            bs.EndEdit()

            dgw.Sort(col, System.ComponentModel.ListSortDirection.Ascending)
            Dim max As Int16
            max = dgw.Rows.Count - 1

            Dim id As Integer
            Dim sort As Int16
            For Each dgrg As DataGridViewRow In dgw.Rows
                dgrg.Cells(col.Index).Value = sort
                id = dgrg.Cells(0).Value
                Dim ris As Integer = ta.UpdateSort(sort, id)
                sort += 1
                If sort = max Then
                    Continue For
                End If
            Next
            dgw.Rows.Remove(dgw.Rows(max))
            dgw.Sort(col, System.ComponentModel.ListSortDirection.Ascending)
        End If
    End Sub

    Private Sub dgwRighe_PremoF7(sender As Object, e As KeyEventArgs) Handles dgwAttrezzature.KeyDown, dgwDPI.KeyDown, dgwIstruzioni.KeyDown, dgwMacchinari.KeyDown, dgwProdotti.KeyDown

        If e.KeyCode <> Keys.F7 Then
            Return
        End If
        CaricaFormRicerca(sender)

    End Sub


    Private Sub CaricaFormRicerca(sender As Object)
        Dim dgw As DataGridView
        dgw = DirectCast(sender, DataGridView)
        Dim posizione As Point = dgw.PointToScreen(New Point(dgw.Location.X, dgw.Location.Y))
        posizione = dgw.PointToScreen(New Point(0, 0))
        Dim bs, tmpBS As BindingSource ' = New BindingSource
        Dim idCat As Int32
        Dim idRiga As Int32 = -1
        If dgw.DataSource.Position >= 0 Then
            tmpBS = dgw.DataSource
            'dgwcIDriga.
            idRiga = DirectCast(tmpBS.Current, DataRowView).Row.Field(Of Int32)("id")
        End If

        Select Case dgw.Name
            Case dgwAttrezzature.Name   'Attrezzature
                lbRicerca.Text = "Ricerca Attrezzature"
                bs = bsProdotti
                bs.Filter = "id_tipologia = 2 Or id_tipologia = 6"
                idCat = 1
            Case dgwProdotti.Name       'Prodotti
                bs = bsProdotti
                bs.Filter = "id_tipologia= 1"
                lbRicerca.Text = "Ricerca Prodotti"
                idCat = 2
            Case dgwDPI.Name            'DPI
                bs = bsProdotti
                bs.Filter = "id_tipologia= 4 Or id_tipologia = 5"
                lbRicerca.Text = "Ricerca DPI"
                idCat = 3
            Case dgwMacchinari.Name
                lbRicerca.Text = "Ricerca Macchinari"
                bs = bsMacchinari
                idCat = 4
            Case dgwIstruzioni.Name
                lbRicerca.Text = "Ricerca Istruzioni"
                bs = bsProcedureIstruzioni
                idCat = 5
        End Select

        Dim dgwR As DataGridView = dgwRicerca
        Dim x = posizione.X - Me.Left
        Dim y = posizione.Y - Me.Top
        Dim y1 As Int32 = y + PannelloRicerca.Height
        Dim y2 As Int32 = DT_BarraNavigazione.PointToScreen(DT_BarraNavigazione.Location).Y
        If y1 > y2 Then
            PannelloRicerca.Height = ((Me.Top + Me.Height) - DT_BarraNavigazione.Top - 100)
        End If
        PannelloRicerca.Location = New Point(x, y) 'New Point(posizione.X - Me.Location.X, (Me.Height + Me.Location.Y) - posizione.Y)
        PannelloRicerca.Visible = True

        ' Dim etichetta() As String = {"Attrezzature", "Prodotti", "DPI", "Macchinari", "Istruzioni"}
        Dim Cella As DataGridViewCell = dgw.CurrentCell

        dgwR.Rows.Clear()

        For Each rgt As DataRowView In bs

            Dim rr As DataGridViewRow = New DataGridViewRow
            rr.CreateCells(dgwR)
            rr.Cells(0).Value = rgt(0)
            rr.Cells(1).Value = rgt(1)
            rr.Cells(2).Value = idCat
            rr.Cells(3).Value = DirectCast(bsProcedureIOP.Current, DataRowView).Row.Field(Of Int32)("id")
            rr.Cells(4).Value = idRiga
            dgwR.Rows.AddRange(rr)
        Next
        txRicerca.Focus()

    End Sub
    Private Sub txRicerca_KeyPreview(sender As Object, e As PreviewKeyDownEventArgs) Handles txRicerca.PreviewKeyDown
        If e.KeyValue = Keys.Escape Then
            PannelloRicerca.Visible = False
        End If
    End Sub

    Private Sub txRicerca_TextChanged(sender As Object, e As EventArgs) Handles txRicerca.TextChanged
        Dim bs As BindingSource = New BindingSource
        Dim str As String
        Dim idCat As Int32
        Try
            idCat = dgwRicerca(2, 0).Value
        Catch ex As Exception
            txRicerca.Text = ""
            Return
        End Try


        Select Case idCat
            Case 1 'Attrezzature
                bs = bsProdotti
                str = String.Format("id_tipologia= 2 And descrizionecommerciale Like '%{0}%' OR id_tipologia= 2 AND tag LIKE '%{0}%' " &
                                    "OR id_tipologia= 6 AND descrizionecommerciale LIKE '%{0}%' OR id_tipologia= 6 And tag Like '%{0}%'", txRicerca.Text)
                bs.Filter = str
            Case 2 'prodotti
                bs = bsProdotti
                str = String.Format("id_tipologia= 1 AND descrizionecommerciale LIKE '%{0}%' OR id_tipologia= 1 AND tag LIKE '%{0}%'", txRicerca.Text)
                bs.Filter = str
            Case 3 ' DPI
                bs = bsProdotti
                str = String.Format("id_tipologia= 4 AND descrizionecommerciale LIKE '%{0}%' OR id_tipologia= 4 AND tag LIKE '%{0}%'" &
                                    " OR id_tipologia= 5 AND descrizionecommerciale LIKE '%{0}%' OR id_tipologia= 5 AND tag LIKE '%{0}%'", txRicerca.Text)
                bs.Filter = str
            Case 4
                bs = bsMacchinari
                str = String.Format(" descrizione Like '%{0}%'", txRicerca.Text)
                bs.Filter = str
            Case 5
                bs = bsProcedureIstruzioni
                str = String.Format("testo LIKE '%{0}%'", txRicerca.Text)
                bs.Filter = str
        End Select


        Dim x As Int16
        Do While True

            x += 1
            If bs.Count > 0 Then
                dgwRicerca.Rows.Clear()
                For Each rgt As DataRowView In bs
                    Dim rr As DataGridViewRow = New DataGridViewRow
                    rr.CreateCells(dgwRicerca)
                    rr.Cells(0).Value = rgt(0)
                    rr.Cells(1).Value = rgt(1)
                    rr.Cells(2).Value = idCat
                    dgwRicerca.Rows.AddRange(rr)
                Next
                Exit Do
            Else
                txRicerca.Text = txRicerca.Text.Substring(0, txRicerca.Text.Length - x)
                txRicerca.SelectionStart = txRicerca.Text.Length
                Exit Do
            End If
        Loop

    End Sub
    Private Sub dgwProc(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowEventArgs) Handles dgwProdotti.DefaultValuesNeeded, dgwAttrezzature.DefaultValuesNeeded, dgwDPI.DefaultValuesNeeded,
                                                                                                                    dgwIstruzioni.DefaultValuesNeeded, dgwMacchinari.DefaultValuesNeeded
        If e.Row.IsNewRow Then
            rgNuova = True
            CaricaFormRicerca(sender)
        Else
            rgNuova = False
        End If

    End Sub
    Private Sub dgwRicerca_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwRicerca.CellDoubleClick


        Dim id, idCat, idIOP, idRiga As Int32
        Dim dgw As DataGridView = DirectCast(sender, DataGridView)
        id = dgw(0, e.RowIndex).Value
        idCat = dgw(2, e.RowIndex).Value

        idIOP = DirectCast(bsProcedureIOP.Current, DataRowView).Row.Field(Of Int32)("id")

        idRiga = dgw(4, e.RowIndex).Value
        Dim dgwr As DataGridView
        Dim bs As BindingSource
        bs = bsProcedureRighe

        If rgNuova Then
            bs.AddNew()
        End If
        rgNuova = False

        Dim rg As dsProcedure.dtProcedureRigheRow
        rg = DirectCast(bs.Current, DataRowView).Row

        Select Case idCat
            Case 1 'Attrezzature
                dgwr = dgwAttrezzature
                rg.id_categoria = idCat
                rg.id_macchinario = Nothing
                rg.id_prodotto = id
                rg.id_istruzioni = Nothing
            Case 2 'prodotti
                dgwr = dgwProdotti
                rg.id_categoria = idCat
                rg.id_macchinario = Nothing
                rg.id_prodotto = id
                rg.id_istruzioni = Nothing
            Case 3 'DPI
                dgwr = dgwProdotti
                rg.id_categoria = idCat
                rg.id_macchinario = Nothing
                rg.id_prodotto = id
                rg.id_istruzioni = Nothing
            Case 4 'Macchinari
                dgwr = dgwMacchinari
                rg.id_categoria = idCat
                rg.id_macchinario = id
                rg.id_prodotto = Nothing
                rg.id_istruzioni = Nothing
            Case 5 'Istruzioni
                dgwr = dgwIstruzioni
                rg.id_categoria = idCat
                rg.id_macchinario = Nothing
                rg.id_prodotto = Nothing
                rg.id_istruzioni = id
        End Select
        bs.EndEdit()
        PannelloRicerca.Visible = False


        Select Case rg.RowState
            Case DataRowState.Added
                Dim ris As Integer = TaProcedureRighe.InsertQuery(idIOP, rg.id_categoria, rg.id_macchinario, rg.id_istruzioni, rg.id_prodotto, If(rg.IsnoteNull, Nothing, If(rg.note = "", Nothing, rg.note)), dgw.Rows.Count)
            Case DataRowState.Modified
                Dim ris As Integer = TaProcedureRighe.UpdateQuery(idIOP, rg.id_categoria, rg.id_macchinario, rg.id_istruzioni, rg.id_prodotto, If(rg.IsnoteNull, Nothing, If(rg.note = "", Nothing, rg.note)), rg.sort, idRiga)
        End Select
        rg.AcceptChanges()
        aggiornaOperazioni()
        txRicerca.Text = ""
    End Sub

    Private Sub dgwDPI_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgwDPI.CellDoubleClick, dgwAttrezzature.CellDoubleClick, dgwIstruzioni.CellDoubleClick, dgwMacchinari.CellDoubleClick, dgwProdotti.CellDoubleClick
        CaricaFormRicerca(sender)
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()

    End Sub

    Private Sub TTBTRicerca_Click(sender As Object, e As EventArgs) Handles TTBTRicarica.Click

        ' Carica l'ID della IOP

        Dim idIop As Integer = DirectCast(bsProcedureIOP.Current, DataRowView).Row.Field(Of Int32)("id")
        Using ta As New dsProcedureTableAdapters.taProcedureIOP
            ta.FillByID(dtTabIOP, idIop)
        End Using
        Using ta As New dsProcedureTableAdapters.taProcedureRevisione
            ta.FillByIOP(dtTabRev, idIop)
        End Using
        Using ta As New dsProcedureTableAdapters.taProcedureRighe
            ta.FillByOperative(dtTabRighe, idIop)
        End Using
        Me.TaProdotti.Fill(Me.DsProcedure.dtProdotti)
        Me.TaProcedureIstruzioni.Fill(Me.DsProcedure.dtProcedureIstruzioni)
        Me.TaMacchinari.Fill(Me.DsProcedure.dtMacchinari)
        Me.TaProcedureCategorie.Fill(Me.DsProcedure.dtProcedureCategorie)

        dtProcedureIOPBindingSource.DataSource = dtTabIOP
        dtProcedureRigheBindingSource.DataSource = dtTabRighe
        dtProcedureRevisioneBindingSource.DataSource = dtTabRev
        ReportViewer1.RefreshReport()
    End Sub
End Class