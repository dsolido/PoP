Public Class FRMsostituzioni
    Dim iddes As Int16
    Dim idcli As Int16
    Dim idsost As Int16
    Dim data As DateTime
    Dim ing, usc As TimeSpan
    Dim ids As Int16
    Dim lista As String
    Dim tmpDTSos As DataTable
    Dim tmpBSSos As BindingSource

    Dim nuovo As Boolean
    Dim Gperiodo As String
    Friend Fsostituito As Boolean
    Friend Fing, Fusc As TimeSpan
    Friend Fanagrafica As String
    Friend Fiddip As Int32



    Public Sub New(ByVal KDTutenti As DataTable, ByVal kiddes As Int16,
                   ByVal kidcli As Integer, ByVal kidsost As Integer, ByVal kdata As DateTime,
                   Optional ByVal king As TimeSpan = Nothing, Optional ByVal kusc As TimeSpan = Nothing,
                   Optional ByVal knuovo As Boolean = True,
                   Optional ByVal kid As Int16 = -1,
                   Optional ByRef kList As String = Nothing)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        If kid <> -1 Then
            ids = kid
        Else
            iddes = kiddes
            idcli = kidcli
            data = kdata
            Dfine.Value = data
            ing = king
            usc = kusc
            nuovo = knuovo
            idsost = kidsost
            Gperiodo = data.Year & "-" & data.Month.ToString.PadLeft(2, "0")
            Fsostituito = False
        End If
        BSutenti.DataSource = KDTutenti ' abbina gli utenti passati dalla precendente maschera
        BSutenti.Filter = "stato = 1"
        lista = kList

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().
    End Sub
    Private Sub FRMsostituzioni_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        If idsost <> Nothing Then
            'scorre tutte le sostituzioni per il cantiere
            TAutentisostituzioni.FillBydipendentedallaalla(DSfestivita.DTutentisostituzioni, idsost, data, data)
        ElseIf ids <> Nothing Then
            TAutentisostituzioni.FillByID(DSfestivita.DTutentisostituzioni, ids)
        Else
            'se esiste l'id della sostituzione
            TAutentisostituzioni.FillByDettaglioilGiorno(DSfestivita.DTutentisostituzioni, iddes, data)
        End If

        If idsost <> Nothing Then
            BSutenti.Position = BSutenti.Find("id", idsost)
            Dim Assente As String = DirectCast(BSutenti.Current, DataRowView).Row.Item("anagrafica")
            txDipendente.Text = Assente
        End If

        Dim xx As Int16 = 0

        Dim rg As DSfestivita.DTutentisostituzioniRow

        If BSutentisost.Count = 0 Then
            BSutentisost.AddNew()
            Dinizio.Value = data
            Dfine.Value = data
            IddesTextBox.Text = iddes
            TextBox1.Text = idsost
            IngTextBox.Text = ing.ToString()
            UscTextBox.Text = usc.ToString()
            visualizzapulsanti(False)
            IddipComboBox.Focus()

        Else
            rg = DirectCast(BSutentisost.Current, DataRowView).Row
            LBdettagliocliente.Text = rg.locazione
        End If
        IddipComboBox.SelectedIndex = If(IddipComboBox.SelectedIndex < 0, 0, IddipComboBox.SelectedIndex)
        Dim Nomedipendente As String = IddipComboBox.SelectedItem.row.anagrafica
        Dim IdDipendente As Integer = IddipComboBox.SelectedValue
        PopolaListViewOrariPresenti(IdDipendente, Nomedipendente)

    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        Dim RGsos As DSfestivita.DTutentisostituzioniRow
        BSutentisost.EndEdit()
        RGsos = DirectCast(BSutentisost.Current, DataRowView).Row
        Dim startDay As Date
        Dim endDay As Date
        startDay = Dinizio.Value
        endDay = Dfine.Value
        Dim GiornoSostituito As Date
        GiornoSostituito = startDay
        If RGsos.RowState = DataRowState.Added Then
            Do While (GiornoSostituito <= endDay)
                Dim resp As Object = TAutentisostituzioni.QRinserisce(RGsos.iddip, iddes, GiornoSostituito, RGsos.ing.ToString(), RGsos.usc.ToString(), RGsos.note, idsost, idcli, RGsos.idpassaggi, RGsos.idtipo)
                RGsos.AcceptChanges()
                visualizzapulsanti(True)
                Fsostituito = True
                Fing = RGsos.ing
                Fusc = RGsos.usc
                Fiddip = RGsos.iddip
                Dim Futenti As DS_utenti.DT_utentiRow
                Futenti = DirectCast(BSutenti.Current, DataRowView).Row
                Fanagrafica = Futenti.Anagrafica
                GiornoSostituito = GiornoSostituito.AddDays(1)
            Loop
        ElseIf RGsos.RowState = DataRowState.Modified Then
            Do While (GiornoSostituito <= endDay)
                Dim resp As Object = TAutentisostituzioni.QRmodifica(RGsos.iddip, iddes, GiornoSostituito, RGsos.ing.ToString(), RGsos.usc.ToString(), RGsos.note, idsost, idcli, RGsos.idpassaggi, RGsos.idtipo, RGsos.id)
                RGsos.AcceptChanges()
                visualizzapulsanti(True)
                Fsostituito = True
                Fing = RGsos.ing
                Fusc = RGsos.usc
                Fiddip = RGsos.iddip
                Dim Futenti As DS_utenti.DT_utentiRow
                Futenti = DirectCast(BSutenti.Current, DataRowView).Row
                Fanagrafica = Futenti.Anagrafica
                GiornoSostituito = GiornoSostituito.AddDays(1)
            Loop
        End If
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click

        BSutentisost.EndEdit()

        For Each RGutenti As DSfestivita.DTutentisostituzioniRow In Me.DSfestivita.DTutentisostituzioni
            If RGutenti.RowState <> DataRowState.Unchanged Then
                If MsgBox("Hai dei dati non salvati, li salvo?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    If RGutenti.RowState = DataRowState.Added Then
                        Dim resp As Object = TAutentisostituzioni.QRinserisce(RGutenti.iddip, iddes, RGutenti.data, RGutenti.ing.ToString(), RGutenti.usc.ToString(), RGutenti.note, idsost, idcli, RGutenti.idpassaggi, RGutenti.idtipo)
                        RGutenti.AcceptChanges()
                        visualizzapulsanti(True)
                        Fsostituito = True
                        Fing = RGutenti.ing
                        Fusc = RGutenti.usc
                        Fiddip = RGutenti.iddip
                        Dim Futenti As DS_utenti.DT_utentiRow
                        Futenti = DirectCast(BSutenti.Current, DataRowView).Row
                        Fanagrafica = Futenti.Anagrafica
                    ElseIf RGutenti.RowState = DataRowState.Modified Then
                        Dim resp As Object = TAutentisostituzioni.QRmodifica(RGutenti.iddip, iddes, RGutenti.data, RGutenti.ing.ToString(), RGutenti.usc.ToString(), RGutenti.note, idsost, idcli, RGutenti.idpassaggi, RGutenti.idtipo, RGutenti.id)
                        RGutenti.AcceptChanges()
                        visualizzapulsanti(True)
                        Fsostituito = True
                        Fing = RGutenti.ing
                        Fusc = RGutenti.usc
                        Fiddip = RGutenti.iddip
                        Dim Futenti As DS_utenti.DT_utentiRow
                        Futenti = DirectCast(BSutenti.Current, DataRowView).Row
                        Fanagrafica = Futenti.Anagrafica

                    End If
                End If
            End If

        Next
        Me.Close()
    End Sub

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim RGsos As DSfestivita.DTutentisostituzioniRow
        BSutentisost.EndEdit()
        RGsos = DirectCast(BSutentisost.Current, DataRowView).Row
        Dim startDay As Date
        Dim endDay As Date
        startDay = Dinizio.Value
        endDay = Dfine.Value

        If MsgBox("Vuoi eliminare la sostituzione di " & RGsos.anagrafica & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim GiornoSostituito As Date
            GiornoSostituito = startDay
            Dim ing As TimeSpan = RGsos.ing
            Dim usc As TimeSpan = RGsos.usc
            Dim iddip As Int32 = RGsos.iddip
            Dim idsos As Int32 = RGsos.idsost
            Do While (GiornoSostituito <= endDay)
                TAutentisostituzioni.FillByDettaglioilGiorno(DSfestivita.DTutentisostituzioni, iddes, GiornoSostituito)
                For Each rr In BSutentisost
                    RGsos = DirectCast(rr, DataRowView).Row
                    Fsostituito = True
                    Fing = TimeSpan.Parse("00:00")
                    Fusc = TimeSpan.Parse("00:00")
                    Fiddip = -1
                    Fanagrafica = ""
                    If ing = RGsos.ing And usc = RGsos.usc Then
                        Dim resp As Object = TAutentisostituzioni.QReliminaperid(RGsos.id)
                    End If
                Next
                GiornoSostituito = GiornoSostituito.AddDays(1)
            Loop
            visualizzapulsanti(True)
        End If

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
        startDay = Dinizio.Value.ToShortDateString
        endDay = Dfine.Value.ToShortDateString

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

    Private Sub IddipComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles IddipComboBox.SelectedIndexChanged

        Dim Nomedipendente As String = IddipComboBox.SelectedItem.row.anagrafica
        Dim IdDipendente As Integer = IddipComboBox.SelectedValue
        PopolaListViewOrariPresenti(IdDipendente, Nomedipendente)

    End Sub

    Private Sub dgPianolavoro_Valid(sender As Object, e As DataGridViewCellEventArgs) Handles dgPianolavoro.RowValidated

        Using dt As New DSfestivita.DTutentisostituzioniDataTable
            Using ta As New DSfestivitaTableAdapters.TAutentisostituzioni
                ta.FillBydipendentenelperiodo(dt, idsost, Gperiodo)
            End Using
            Dim RighealtriLavori = (From aa In dt Where aa.iddes = iddes And aa.data = data Order By aa.ing Select aa).ToList
            If RighealtriLavori.Count > 0 Then


                'MsgBox("Sono presenti altri lavori")


            End If
        End Using

    End Sub
    Private Sub dgpianoLavoroRowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles dgPianolavoro.RowEnter

    End Sub
    Private Sub dgpianoLavoroRowLeave(sender As Object, e As DataGridViewCellEventArgs) Handles dgPianolavoro.RowLeave

    End Sub

    Private Sub dgPianolavoro_CellParsing(sender As Object, e As DataGridViewCellParsingEventArgs) Handles dgPianolavoro.CellParsing
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


    Private Sub dgPianoLavoro_CellValidating(ByVal sender As Object, ByVal e As DataGridViewCellValidatingEventArgs) Handles dgPianolavoro.CellValidating
        Select Case True
            Case e.ColumnIndex = dgwcIng.Index Or e.ColumnIndex = dgwcusc.Index
                Dim tim As TimeSpan
                Dim sti As String = e.FormattedValue.Replace("-", ":").Replace(".", ":")
                Dim conta As Int16 = sti.Split(":").Count - 1
                If conta = 1 And sti.Length > 3 Then
                    Dim ore As Int16 = sti.Split(":").First
                    Dim min As Int16 = sti.Split(":").Skip(1).First
                    tim = New TimeSpan(ore, min, 0)
                    dgPianolavoro(e.ColumnIndex, e.RowIndex).Value = tim.ToString().Substring(0, 5)
                    e.Cancel = False
                ElseIf sti.Length = 0 Then
                    e.Cancel = False
                Else
                    dgPianolavoro.Rows(e.RowIndex).ErrorText = "Il valore deve essere un' ora valida"
                    e.Cancel = True
                    Return
                End If
            Case e.ColumnIndex = dgwcDal.Index Or e.ColumnIndex = dgwcAl.Index
                Dim tim As DateTime
                Dim sti As String = e.FormattedValue.Replace("-", "/").Replace(".", "/")
                Dim conta As Int16 = sti.Split("/").Count - 1
                If conta = 2 And sti.Length > 5 Then
                    Dim Anno As Int16 = sti.Split("/").Skip(2).First
                    Dim Mese As Int16 = sti.Split("/").Skip(1).First
                    Dim Gior As Int16 = sti.Split("/").Skip(0).First
                    tim = New DateTime(Anno, Mese, Gior)
                    dgPianolavoro(e.ColumnIndex, e.RowIndex).Value = tim.ToShortDateString
                    e.Cancel = False
                ElseIf sti.Length = 0 Then
                    e.Cancel = False
                Else
                    dgPianolavoro.Rows(e.RowIndex).ErrorText = "Il valore deve essere una data valida"
                    e.Cancel = True
                    Return
                End If
        End Select

    End Sub

    Private Sub dgPianoLavoro_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgPianolavoro.CellEndEdit

        dgPianolavoro.Rows(e.RowIndex).ErrorText = String.Empty

    End Sub








    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click
        TAutentisostituzioni.FillByDettaglioilGiorno(DSfestivita.DTutentisostituzioni, iddes, data)
        BSutentisost.AddNew()
        Dinizio.Value = data
        Dfine.Value = data
        IddesTextBox.Text = iddes
        TextBox1.Text = idsost
        IngTextBox.Text = ing.ToString()
        UscTextBox.Text = usc.ToString()
        visualizzapulsanti(False)
        IddipComboBox.Focus()
    End Sub

    Private Function visualizzapulsanti(ByVal visibile As Boolean)
        TTBTAggiunge.Visible = visibile
        TTBTElimina.Visible = visibile
        TTBTModifica.Visible = False
        TTBTTermina.Visible = visibile
        TTBTSalva.Visible = Not visibile
        Dim spazio As Size
        TTBTSalva.AutoSize = False
        spazio.Height = DM_barra.Height
        spazio.Width = DM_barra.Width - 10
        TTBTSalva.Size = spazio
        ToolStripButton1.Visible = visibile
        ToolStripButton2.Visible = visibile
        ToolStripButton3.Visible = visibile
        ToolStripButton4.Visible = visibile
        ToolStripTextBox1.Visible = visibile
        ToolStripLabel1.Visible = visibile
        ToolStripSeparator1.Visible = visibile
        ToolStripSeparator2.Visible = visibile
        ToolStripSeparator3.Visible = visibile
        ToolStripSeparator4.Visible = visibile
        Return True
    End Function
End Class