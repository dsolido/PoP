Public Class FRMgestSos
    Dim lista As String
    Dim tmpDTSos As DataTable

    Dim tmpBSSos As BindingSource
    Dim bsLocazioni As BindingSource
    Dim dtUtenti As DS_utenti.DT_utentiDataTable
    Dim idRichiedente As Int16                          'è l'ID di chi richiede la variazione

    Dim Gperiodo As String
    Friend Fsostituito As Boolean
    Friend Fing, Fusc As TimeSpan
    Friend Fanagrafica As String
    Friend Fiddip As Int32

    Friend WithEvents dgPianolavoro As DataGridView
    Friend WithEvents dgwcid As DataGridViewTextBoxColumn
    Friend WithEvents dgwcidpass As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDettaglio As DataGridViewTextBoxColumn
    Friend WithEvents dgwcIng As DataGridViewTextBoxColumn
    Friend WithEvents dgwcusc As DataGridViewTextBoxColumn
    Friend WithEvents dgwcidcli As DataGridViewTextBoxColumn
    Friend WithEvents dgwciddet As DataGridViewTextBoxColumn
    Friend WithEvents dgwciddip As DataGridViewTextBoxColumn
    Friend WithEvents dgwcAssente As DataGridViewCheckBoxColumn
    Friend WithEvents dgwcSostituto As DataGridViewTextBoxColumn
    Friend WithEvents dgwcidSostituto As DataGridViewTextBoxColumn
    Friend WithEvents dgwcNote As DataGridViewTextBoxColumn
    Friend WithEvents dgwcDal As DataGridViewTextBoxColumn
    Friend WithEvents dgwcAl As DataGridViewTextBoxColumn
    Dim valorX



    Public Sub New(ByRef kList As String, ByVal Kdtutenti As DataTable, ByVal kdtDettagli As DataTable)
        ' La chiamata è richiesta dalla finestra di progettazione.

        InitializeComponent()

        lista = kList
        tmpDTSos = New DataTable("tmpSostituzioni")

        Dim column1 As DataColumn

        column1 = New DataColumn("ing")
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("usc")
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("dd")
        column1.DataType = System.Type.GetType("System.DateTime")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("ad")
        column1.DataType = System.Type.GetType("System.DateTime")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idsos")
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("iddip")
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idcli")
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("iddet")
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idyn")       'Se è stata sostituita o no
        column1.DataType = System.Type.GetType("System.Boolean")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idn")         'in caso sia già una sostituzione
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idtipo")         'in caso sia già una sostituzione
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("note")
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("dettaglio")   'Dettaglio Cantiere
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)


        column1 = New DataColumn("sostituto")   'Dettaglio Cantiere
        column1.DataType = System.Type.GetType("System.String")
        tmpDTSos.Columns.Add(column1)

        column1 = New DataColumn("idpass")   'Dettaglio Cantiere
        column1.DataType = System.Type.GetType("System.Int16")
        tmpDTSos.Columns.Add(column1)

        tmpBSSos = New BindingSource
        bsLocazioni = New BindingSource

        tmpBSSos.DataMember = "tmpDTSos"
        tmpBSSos.DataSource = tmpDTSos

        dtUtenti = Kdtutenti
        BSutenti.DataSource = dtUtenti
        bsLocazioni.DataSource = kdtDettagli

        CreaDatagrid()

        dgPianolavoro.DataSource = tmpBSSos
        tmpBSSos.EndEdit()
        tmpDTSos.AcceptChanges()
        Me.cmbSostituto.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", tmpBSSos, "idsos", True))

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
    End Sub
    Private Sub FRMsostituzioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim numeroTag As Int16 = lista.Split("|").Count - 1
        Gperiodo = GlobalVarPOP.GPeriodo
        Dim iddip, idsos, iddes, idcli, idn, idtip As Int16
        For r = 0 To numeroTag - 1 Step 9
            Dim rwTmp As DataRow
            rwTmp = tmpDTSos.NewRow()
            idRichiedente = lista.Split("|").Skip(0 + r).First
            Dim str0 As DateTime = lista.Split("|").Skip(1 + r).First
            Dim str1 As DateTime = lista.Split("|").Skip(2 + r).First
            Dim inizio As TimeSpan = TimeSpan.Parse(str0.ToShortTimeString)
            Dim fine As TimeSpan = TimeSpan.Parse(str1.ToShortTimeString)
            Dim DataDa As Date = DateTime.Parse(str0.ToShortDateString)
            Dim DataA As Date = DateTime.Parse(str1.ToShortDateString)

            rwTmp.Item("ing") = inizio.ToString().Substring(0, 5)
            rwTmp.Item("usc") = fine.ToString().Substring(0, 5)
            rwTmp.Item("dd") = DataDa
            rwTmp.Item("ad") = DataA
            iddip = If(IsNothing(lista), Nothing, lista.Split("|").Skip(3 + r).First)
            idsos = If(IsNothing(lista), Nothing, lista.Split("|").Skip(4 + r).First)
            idcli = If(IsNothing(lista), Nothing, lista.Split("|").Skip(5 + r).First)
            iddes = If(IsNothing(lista), Nothing, lista.Split("|").Skip(6 + r).First)
            idn = If(IsNothing(lista), Nothing, lista.Split("|").Skip(7 + r).First)
            idtip = If(IsNothing(lista), Nothing, lista.Split("|").Skip(8 + r).First)

            rwTmp.Item("iddip") = iddip
            rwTmp.Item("idsos") = idsos
            rwTmp.Item("idcli") = idcli
            rwTmp.Item("iddet") = iddes
            rwTmp.Item("idn") = idn
            rwTmp.Item("idtipo") = idtip
            rwTmp.Item("idyn") = IIf(idtip = 10, True, False)

            bsLocazioni.Position = bsLocazioni.Find("id", rwTmp.Item("iddet"))
            rwTmp.Item("dettaglio") = DirectCast(bsLocazioni.Current, DataRowView).Row.Item("locazione")
            Dim tt = (From ff In dtUtenti Where ff.id = idsos Select ff.Anagrafica).ToList
            Dim val As String = If(tt.Count = 0, "nulla", tt(0))
            rwTmp.Item("sostituto") = val

            tmpDTSos.Rows.Add(rwTmp)
            tmpDTSos.AcceptChanges()
        Next
        Dim tm As DataView = tmpDTSos.DefaultView
        'tm.Sort = "ing ASC"
        tmpDTSos = tm.ToTable()

        tm = Nothing
        Dim pass = From tt In tmpDTSos Group tt By k = tt.Field(Of Int16)("iddet") Into Group Select ak = k, niddet = Group.Count()
        Dim nn As Int16 = pass(0).niddet - 1
        Dim vv As Int16 = 0
        For vv = 0 To nn
            tmpDTSos(vv)("idpass") = vv
            'tmpDTSos(vv).AcceptChanges()
        Next



        Dim gg = (From ff In dtUtenti Where ff.id = iddip Select ff.Anagrafica).ToList
        If gg.Count > 0 Then
            txDipendente.Text = gg(0)
        End If

        gg = Nothing
        'For Each tr As DataRowView In tmpBSSos
        '    Dim rr As DataRow = DirectCast(tr, DataRowView).Row
        '    rr.AcceptChanges()
        'Next
        tmpBSSos.EndEdit()
        tmpDTSos.AcceptChanges()

    End Sub
    'Private Sub dgPianolavoroDataError(sender As Object, e As DataGridViewDataErrorEventArgs)
    '    Dim cella As DataGridViewCell
    '    cella = sender(e.ColumnIndex, e.RowIndex)
    '    Select Case cella.ColumnIndex
    '        Case dgwcSostituto.Index
    '            Console.WriteLine(valorX)
    '    End Select
    'End Sub


    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()
    End Sub


    Private Sub LVimpegni_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LVimpegni.SelectedIndexChanged

    End Sub
    Private Function PopolaListViewOrariPresenti(ByVal idDipendente As Integer, ByVal NomeDipendenta As String)

        Dim lv As ListView
        lv = LVimpegni
        lv.Items.Clear()
        If lv.Columns.Count = 0 Then
            With lv
                .View = View.Details
                .FullRowSelect = True
                .Columns.Add("id")
                .Columns.Add("dettaglio")
                .Columns.Add("data")
                .Columns.Add("inizio")
                .Columns.Add("fine")
                .Columns.Add("note")
            End With
        End If
        lv.Columns(0).TextAlign = HorizontalAlignment.Right
        lv.Columns(0).Width = 30
        lv.Columns(1).TextAlign = HorizontalAlignment.Left
        lv.Columns(1).Width = 120
        lv.Columns(2).TextAlign = HorizontalAlignment.Right
        lv.Columns(2).Width = 70
        lv.Columns(3).TextAlign = HorizontalAlignment.Right
        lv.Columns(3).Width = 70
        lv.Columns(4).TextAlign = HorizontalAlignment.Right
        lv.Columns(4).Width = 70
        lv.Columns(5).TextAlign = HorizontalAlignment.Left
        lv.Columns(5).Width = 200

        GroupBox1.Text = "già Programmato al dipendente " & NomeDipendenta
        Dim idDip As Integer = idDipendente
        Dim startDay As Date
        Dim endDay As Date
        'startDay = Dinizio.Value.ToShortDateString
        'endDay = Dfine.Value.ToShortDateString

        Using DTuf As New DSfestivita.DTutentisostituzioniDataTable
            Using TAuf As New DSfestivitaTableAdapters.TAutentisostituzioni
                TAuf.FillBydipendentedallaalla(DTuf, idDip, startDay.ToShortDateString, startDay.ToShortDateString)
            End Using
            Dim n As Integer = DTuf.Rows.Count
            For Each RGuf As DSfestivita.DTutentisostituzioniRow In DTuf.Rows
                lv.Items.Add(New ListViewItem({RGuf.id.ToString, RGuf.locazione.ToString, RGuf.data.ToShortDateString, RGuf.ing.ToString("t"), RGuf.usc.ToString("t"), RGuf.note}))
            Next
        End Using

        Return True
    End Function

    Private Sub dgPianoLavoro_CellClick(sender As Object, e As DataGridViewCellEventArgs)


    End Sub
    Private Sub dgPianolavoro_Valid(sender As Object, e As DataGridViewCellEventArgs) Handles dgPianolavoro.RowValidated
        'Dim idsos, iddes As Int16
        'Dim datdd, datad As DateTime
        'tmpBSSos.EndEdit()
        'Dim rg As DataRow = DirectCast(tmpBSSos.Current, DataRowView).Row
        'idsos = rg("idsos")
        'iddes = rg("iddet")
        'datad = rg("ad")
        'datdd = rg("dd")    'Dalla data
        'Dim data As DateTime
        'data = New DateTime(datdd.Year, datdd.Month, datdd.Day)
        'Dim numeroGiorni As Int16
        'Dim tidtipo, tiddip, tiddes, tidsos, tidcli, tidrec, tidpas As Int16
        'Dim tnote As String
        'Dim ting, tusc As DateTime
        'Dim tidyn As Boolean

        'For Each pg As DataRowView In tmpBSSos
        '    rg = DirectCast(pg, DataRowView).Row

        '    numeroGiorni = DateDiff(DateInterval.Day, datdd, datad)

        '    If numeroGiorni > 0 Then
        '        tidtipo = rg("idtipo")
        '        tiddip = rg("iddip")
        '        tidsos = rg("idsos")
        '        tiddes = rg("iddet")
        '        tidcli = rg("idcli")
        '        tidrec = rg("idn")
        '        tidpas = If(IsDBNull(rg("idpass")), 0, rg("idpass"))
        '        tnote = If(IsDBNull(rg("note")), Nothing, rg("note"))
        '        ting = DateTime.Parse(data.ToShortDateString() & " " & rg("ing").ToString().Replace(".", ":").Replace(",", ":"))
        '        tusc = DateTime.Parse(data.ToShortDateString() & " " & rg("usc").ToString().Replace(".", ":").Replace(",", ":"))
        '        tidyn = If(IsDBNull(rg("idyn")), Nothing, rg("idyn"))

        '    End If

        '    Dim idtip As Int16 = rg("idtipo")
        '    Dim note As String = If(IsDBNull(rg("note")), Nothing, rg("note"))
        '    Dim iddi As Int16 = rg("iddip")
        '    Dim idde As Int16 = rg("iddet")
        '    Dim idso As Int16 = rg("idsos")
        '    Dim idcl As Int16 = rg("idcli")
        '    Dim idyn As Boolean = If(IsDBNull(rg("idyn")), Nothing, rg("idyn"))
        '    Dim dat As DateTime = data
        '    Dim ing As DateTime = DateTime.Parse(data.ToShortDateString() & " " & rg("ing").ToString().Replace(".", ":").Replace(",", ":"))
        '    Dim usc As DateTime = DateTime.Parse(data.ToShortDateString() & " " & rg("usc").ToString().Replace(".", ":").Replace(",", ":"))
        '    Dim idre As Int16 = rg("idn")
        '    Dim idpas As Int16 = If(IsDBNull(rg("idpass")), 0, rg("idpass"))

        '    Select Case rg.RowState
        '        Case DataRowState.Modified
        '            If idre = -1 Then
        '                If idyn Then
        '                    idtip = 10
        '                    idso = 0
        '                End If
        '                Dim resp As Object = TAutentisostituzioni.QRinserisce(iddi, idde, dat, ing, usc, note, idso, idcl, idpas, idtip)
        '            Else
        '                Dim resp As Object = TAutentisostituzioni.QRmodifica(iddi, idde, dat, ing, usc, note, idso, idcl, idpas, idtip, idre)
        '            End If
        '            rg.AcceptChanges()
        '            Fsostituito = True
        '        Case DataRowState.Added
        '            Dim resp As Object = TAutentisostituzioni.QRinserisce(iddi, idde, dat, ing, usc, note, idso, idcl, idpas, idtip)
        '            rg.AcceptChanges()
        '            Fsostituito = True
        '    End Select
        'Next
        'numeroGiorni = DateDiff(DateInterval.Day, datdd, datad)
        'If numeroGiorni > 0 Then
        '    'Sconta il primo inserimento che è già stato messo
        '    For GG As Int16 = 1 To numeroGiorni - 1
        '        data = New DateTime(datdd.Year, datdd.Month, datdd.Day + GG)
        '        Dim resp As Object = TAutentisostituzioni.QRinserisce(tiddip, tiddes, data, ting, tusc, tnote, tidsos, tidcli, tidpas, tidtipo)
        '    Next
        'End If

        'Using dt As New DSfestivita.DTutentisostituzioniDataTable
        '    Using ta As New DSfestivitaTableAdapters.TAutentisostituzioni
        '        ta.FillBydipendentenelperiodo(dt, idsos, Gperiodo)
        '    End Using
        '    Dim RighealtriLavori = (From aa In dt Where aa.iddes = iddes And aa.data = datdd Order By aa.ing Select aa).ToList

        '    If RighealtriLavori.Count > 0 Then
        '        'MsgBox("Sono presenti altri lavori")
        '    End If

        'End Using

    End Sub

    Private Sub dgPianolavoro_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs)
        Dim cella As DataGridViewCell
        cella = sender(e.ColumnIndex, e.RowIndex)
        Select Case True
            Case e.ColumnIndex = dgwcIng.Index
                Dim tmpVal As String = e.Value
                Dim Val As String = tmpVal.Replace("-", ":").Replace(".", ":").Replace(" ", ":")
                e.Value = Val
                e.ParsingApplied = True
            Case e.ColumnIndex = dgwcusc.Index
                Dim tmpVal As String = e.Value
                Dim Val As String = tmpVal.Replace("-", ":").Replace(".", ":").Replace(" ", ":")
                e.Value = Val
                e.ParsingApplied = True
            Case e.ColumnIndex = dgwcDal.Index
                Dim tmpVal As String = e.Value
                Dim Val As String = tmpVal.Replace("-", "/").Replace(".", "/").Replace(" ", "/")
                e.Value = Val
                e.ParsingApplied = True
            Case e.ColumnIndex = dgwcAl.Index
                Dim tmpVal As String = e.Value
                Dim Val As String = tmpVal.Replace("-", "/").Replace(".", "/").Replace(" ", "/")
                e.Value = Val
                e.ParsingApplied = True
        End Select
    End Sub


    Private Sub dgPianoLavoro_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs)
        'Select Case True
        '    Case e.ColumnIndex = dgwcIng.Index Or e.ColumnIndex = dgwcusc.Index
        '        Dim tim As TimeSpan
        '        Dim sti As String = e.FormattedValue.Replace("-", ":").Replace(".", ":")
        '        Dim conta As Int16 = sti.Split(":").Count - 1
        '        If conta = 1 And sti.Length > 3 Then
        '            Dim ore As Int16 = sti.Split(":").First
        '            Dim min As Int16 = sti.Split(":").Skip(1).First
        '            tim = New TimeSpan(ore, min, 0)
        '            dgPianolavoro(e.ColumnIndex, e.RowIndex).Value = tim.ToString().Substring(0, 5)
        '            e.Cancel = False
        '        ElseIf sti.Length = 0 Then
        '            e.Cancel = False
        '        Else
        '            dgPianolavoro.Rows(e.RowIndex).ErrorText = "Il valore deve essere un' ora valida"
        '            e.Cancel = True
        '            Return
        '        End If
        '    Case e.ColumnIndex = dgwcDal.Index Or e.ColumnIndex = dgwcAl.Index
        '        Dim tim As DateTime
        '        Dim sti As String = e.FormattedValue.Replace("-", "/").Replace(".", "/")
        '        Dim conta As Int16 = sti.Split("/").Count - 1
        '        If conta = 2 And sti.Length > 5 Then
        '            Dim Anno As Int16 = sti.Split("/").Skip(2).First
        '            Dim Mese As Int16 = sti.Split("/").Skip(1).First
        '            Dim Gior As Int16 = sti.Split("/").Skip(0).First
        '            tim = New DateTime(Anno, Mese, Gior)
        '            dgPianolavoro(e.ColumnIndex, e.RowIndex).Value = tim.ToShortDateString
        '            e.Cancel = False
        '        ElseIf sti.Length = 0 Then
        '            e.Cancel = False
        '        Else
        '            dgPianolavoro.Rows(e.RowIndex).ErrorText = String.Empty
        '            e.Cancel = False
        '            Return
        '        End If
        'End Select

    End Sub

    Private Sub dgPianoLavoro_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

        dgPianolavoro.Rows(e.RowIndex).ErrorText = String.Empty

    End Sub


    Private Sub cmbSostituto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSostituto.Validated
        ' Dim rg As DataRow = DirectCast(tmpBSSos.Current, DataRowView).Row
        'rg("sostituto") = cmbSostituto.SelectedText
        'rg("idsos") = cmbSostituto.SelectedValue

        dgPianolavoro(dgwcidSostituto.Index, dgPianolavoro.CurrentRow.Index).Value = If(IsDBNull(cmbSostituto.SelectedItem), Nothing, cmbSostituto.SelectedItem.Row.id)
        dgPianolavoro(dgwcSostituto.Index, dgPianolavoro.CurrentRow.Index).Value = If(IsDBNull(cmbSostituto.SelectedItem), Nothing, cmbSostituto.SelectedItem.Row.anagrafica)


        'rg.AcceptChanges()
    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        Dim idsos, iddes As Int16
        Dim datdd, datad As DateTime
        tmpBSSos.EndEdit()
        tmpBSSos.MoveFirst()
        If tmpBSSos.Count = 0 Then
            Return
        End If
        Dim rg As DataRow = DirectCast(tmpBSSos.Current, DataRowView).Row
        If IsDBNull(rg("idn")) Then
            Return
        End If
        idsos = If(IsDBNull(rg("idsos")), 0, rg("idsos"))
        iddes = rg("iddet")
        datad = rg("ad")
        datdd = rg("dd")    'Dalla data
        Dim data As DateTime
        data = New DateTime(datdd.Year, datdd.Month, datdd.Day)
        Dim numeroGiorni As Int16
        Dim tidtipo, tiddip, tiddes, tidsos, tidcli, tidrec, tidpas As Int16
        Dim tnote As String
        Dim ting, tusc As DateTime
        Dim tidyn As Boolean

        For Each pg As DataRowView In tmpBSSos

            rg = DirectCast(pg, DataRowView).Row
            numeroGiorni = DateDiff(DateInterval.Day, datdd, datad)

            If numeroGiorni > 0 Then
                tidtipo = rg("idtipo")
                tiddip = rg("iddip")
                tidsos = rg("idsos")
                tiddes = rg("iddet")
                tidcli = rg("idcli")
                tidrec = rg("idn")
                tidpas = If(IsDBNull(rg("idpass")), 0, rg("idpass"))
                tnote = If(IsDBNull(rg("note")), Nothing, rg("note"))
                ting = DateTime.Parse(data.ToShortDateString() & " " & rg("ing").ToString().Replace(".", ":").Replace(",", ":"))
                tusc = DateTime.Parse(data.ToShortDateString() & " " & rg("usc").ToString().Replace(".", ":").Replace(",", ":"))
                tidyn = If(IsDBNull(rg("idyn")), Nothing, rg("idyn"))

            End If

            'TODO da terminare la valutazione di idTIPO

            Dim idtip As Int16
            If IsDBNull(rg("idtipo")) = True Then
                idtip = 1
            Else
                idtip = 3
            End If

            Dim note As String = If(IsDBNull(rg("note")), Nothing, rg("note"))
            Dim iddi As Int16 = IIf(IsDBNull(rg("idsos")), rg("iddip"), rg("idsos"))
            Dim idde As Int16 = rg("iddet")
            Dim idso As Int16 = rg("iddip")
            Dim idcl As Int16 = rg("idcli")
            Dim idyn As Boolean = If(IsDBNull(rg("idyn")), Nothing, rg("idyn"))
            Dim dat As DateTime = data
            Dim ing As DateTime = DateTime.Parse(data.ToShortDateString() & " " & rg("ing").ToString().Replace(".", ":").Replace(",", ":"))
            Dim usc As DateTime = DateTime.Parse(data.ToShortDateString() & " " & rg("usc").ToString().Replace(".", ":").Replace(",", ":"))
            Dim idre As Int16 = rg("idn")
            Dim idpas As Int16 = If(IsDBNull(rg("idpass")), 0, rg("idpass"))

            Select Case rg.RowState
                Case DataRowState.Modified
                    If idre = -1 Then
                        If idyn Then
                            idtip = 10
                            idso = 0
                        End If
                        Dim resp As Object = TAutentisostituzioni.QRinserisce(iddi, idde, dat, ing, usc, note, idso, idcl, idpas, idtip)
                    Else
                        If idyn Then
                            idtip = 10
                            idso = 0
                        End If
                        Dim resp As Object = TAutentisostituzioni.QRmodifica(iddi, idde, dat, ing, usc, note, idso, idcl, idpas, idtip, idre)
                    End If
                    rg.AcceptChanges()
                    Fsostituito = True
                Case DataRowState.Added
                    Dim resp As Object = TAutentisostituzioni.QRinserisce(iddi, idde, dat, ing, usc, note, idso, idcl, idpas, idtip)
                    rg.AcceptChanges()
                    Fsostituito = True
            End Select
        Next
        'numeroGiorni = DateDiff(DateInterval.Day, datdd, datad)
        'If numeroGiorni > 0 Then
        '    'Sconta il primo inserimento che è già stato messo
        '    For GG As Int16 = 1 To numeroGiorni - 1
        '        data = New DateTime(datdd.Year, datdd.Month, datdd.Day + GG)
        '        Dim resp As Object = TAutentisostituzioni.QRinserisce(tiddip, tiddes, data, ting, tusc, tnote, tidsos, tidcli, tidpas, tidtipo)
        '    Next
        'End If

        Using dt As New DSfestivita.DTutentisostituzioniDataTable
            Using ta As New DSfestivitaTableAdapters.TAutentisostituzioni
                ta.FillBydipendentenelperiodo(dt, idsos, Gperiodo)
            End Using
            Dim RighealtriLavori = (From aa In dt Where aa.iddes = iddes And aa.data = datdd Order By aa.ing Select aa).ToList

            If RighealtriLavori.Count > 0 Then
                'MsgBox("Sono presenti altri lavori")
            End If

        End Using

    End Sub

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim rg As DataRow = DirectCast(tmpBSSos.Current, DataRowView).Row
        Dim id As Int16 = rg("idn")
        If id > 0 Then
            If MsgBox("Elimino la modifica all'orario" & vbCrLf & "di lavoro ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                rg.Delete()
                Dim risp As Int16 = TAutentisostituzioni.QReliminaperid(id)
                Fsostituito = True
            End If


        End If

    End Sub

    Private Function CreaDatagrid()
        '
        'dgPianolavoro
        '

        Me.dgPianolavoro = New System.Windows.Forms.DataGridView()
        Me.dgwcid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcidpass = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcDettaglio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcIng = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcusc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcidcli = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwciddet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwciddip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcAssente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.dgwcSostituto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcidSostituto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcNote = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcDal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgwcAl = New System.Windows.Forms.DataGridViewTextBoxColumn()

        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        '
        'dgwcSostituto
        '
        'Me.dgwcid.HeaderText = "id"
        'dgwcidSostituto.Name = "dgwcid"
        'Me.dgwcidSostituto.FillWeight = 10.0!
        'dgwcidSostituto.DataPropertyName = "id"
        'Me.dgwcidSostituto.Visible = False
        '
        '
        Me.dgwcidSostituto.HeaderText = "Sostituto"
        dgwcidSostituto.Name = "dgwcidSostituito"
        Me.dgwcidSostituto.FillWeight = 10.0!
        dgwcidSostituto.DataPropertyName = "idsos"
        Me.dgwcidSostituto.Visible = False
        '
        'VisualSostituto
        '
        Me.dgwcSostituto.HeaderText = "Sostituto"
        dgwcSostituto.Name = "dgwcSostituito"
        Me.dgwcSostituto.FillWeight = 60.0!
        dgwcSostituto.DataPropertyName = "sostituto"
        Me.dgwcSostituto.Visible = True

        '
        'dgwcid
        '
        Me.dgwcid.DataPropertyName = "idn"
        Me.dgwcid.FillWeight = 0.1!
        Me.dgwcid.HeaderText = "id"
        Me.dgwcid.Name = "dgwcid"
        Me.dgwcid.Visible = True
        '
        'dgwcidpass
        '
        Me.dgwcidpass.DataPropertyName = "idpass"
        Me.dgwcidpass.FillWeight = 10.0!
        Me.dgwcidpass.HeaderText = "pass"
        Me.dgwcidpass.Name = "dgwcidpass"
        Me.dgwcidpass.Visible = False
        '
        'dgwcDettaglio
        '
        Me.dgwcDettaglio.DataPropertyName = "dettaglio"
        Me.dgwcDettaglio.FillWeight = 80.0!
        Me.dgwcDettaglio.HeaderText = "dettaglio"
        Me.dgwcDettaglio.Name = "dgwcDettaglio"
        Me.dgwcDettaglio.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgwcDettaglio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'dgwcIng
        '
        Me.dgwcIng.DataPropertyName = "ing"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "t"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgwcIng.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgwcIng.FillWeight = 25.0!
        Me.dgwcIng.HeaderText = "ing"
        Me.dgwcIng.Name = "dgwcIng"
        '
        'dgwcusc
        '
        Me.dgwcusc.DataPropertyName = "usc"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "t"
        Me.dgwcusc.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgwcusc.FillWeight = 25.0!
        Me.dgwcusc.HeaderText = "usc"
        Me.dgwcusc.Name = "dgwcusc"
        '
        'dgwcidcli
        '
        Me.dgwcidcli.DataPropertyName = "idcli"
        Me.dgwcidcli.FillWeight = 10.0!
        Me.dgwcidcli.HeaderText = "idcli"
        Me.dgwcidcli.Name = "dgwcidcli"
        Me.dgwcidcli.Visible = False
        '
        'dgwciddet
        '
        Me.dgwciddet.DataPropertyName = "iddet"
        Me.dgwciddet.HeaderText = "iddet"
        Me.dgwciddet.Name = "dgwciddet"
        Me.dgwciddet.Visible = False
        '
        'dgwciddip
        '
        Me.dgwciddip.DataPropertyName = "iddip"
        Me.dgwciddip.HeaderText = "iddip"
        Me.dgwciddip.Name = "dgwciddip"
        Me.dgwciddip.Visible = False
        '
        'dgwcAssente
        '
        Me.dgwcAssente.DataPropertyName = "idyn"
        Me.dgwcAssente.FalseValue = "False"
        Me.dgwcAssente.FillWeight = 20.0!
        Me.dgwcAssente.HeaderText = "ASS"
        Me.dgwcAssente.IndeterminateValue = "Nothing"
        Me.dgwcAssente.Name = "dgwcAssente"
        Me.dgwcAssente.TrueValue = "True"
        '
        'dgwcNote
        '
        Me.dgwcNote.DataPropertyName = "note"
        Me.dgwcNote.HeaderText = "Note"
        Me.dgwcNote.Name = "dgwcNote"
        '
        'dgwcDal
        '
        Me.dgwcDal.DataPropertyName = "dd"
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.dgwcDal.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgwcDal.FillWeight = 40.0!
        Me.dgwcDal.HeaderText = "dal"
        Me.dgwcDal.Name = "dgwcDal"
        Me.dgwcDal.Visible = False
        '
        'dgwcAl
        '
        Me.dgwcAl.DataPropertyName = "ad"
        DataGridViewCellStyle4.Format = "d"
        Me.dgwcAl.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgwcAl.FillWeight = 40.0!
        Me.dgwcAl.HeaderText = "Al"
        Me.dgwcAl.Name = "dgwcAl"
        Me.dgwcAl.Visible = False
        '

        Me.dgPianolavoro.AutoGenerateColumns = False
        Me.dgPianolavoro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgPianolavoro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPianolavoro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dgwcid, Me.dgwcidpass, Me.dgwcDettaglio, Me.dgwcIng, Me.dgwcusc, Me.dgwcidcli, Me.dgwciddet, Me.dgwciddip, Me.dgwcAssente, Me.dgwcSostituto, Me.dgwcidSostituto, Me.dgwcNote, Me.dgwcDal, Me.dgwcAl})
        Me.dgPianolavoro.Location = New System.Drawing.Point(0, 90)
        Me.dgPianolavoro.Name = "dgPianolavoro"
        Me.dgPianolavoro.Size = New System.Drawing.Size(1122, 150)
        Me.dgPianolavoro.TabIndex = 204
        Me.dgPianolavoro.DataMember = tmpBSSos.DataMember

        Me.Controls.Add(Me.dgPianolavoro)

        Return True
    End Function
End Class