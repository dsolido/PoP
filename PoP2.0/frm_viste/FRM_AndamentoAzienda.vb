
Imports System.Text
Imports System.Windows.Forms.DataVisualization.Charting

Public Class FRM_AndamentoAzienda
    'Dim dtGraph As New DataTable
    'Dim dtOre As New DataTable
    Private fontLab As New Font(FontFamily.GenericSansSerif, 14, FontStyle.Regular)
    Private DT As New DataTable("TabellaDati")
    Private maxI As Integer 'Massimo Importo
    Private maxO As Integer 'Massimo Orario
    Private maxR As Integer 'Massima Resa

    'Private percorsoBmp As String = Application.StartupPath & "\"
    'Private nomeBmp As String = "arrow.bmp"
    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Formattazione DataTable Tabella Dati per contenere due serie
        'Asse X comune alle Serie Dati
        DT.Columns.Add("totale", GetType(Integer))
        DT.Columns.Add("anno", GetType(Integer))
        DT.Columns.Add("ore", GetType(Integer))
        DT.Columns.Add("resa", GetType(Integer))
        DT.PrimaryKey = {DT.Columns("anno")}
        RiepilogoAnnuale()
        CaricoDati()
        Chart1.Series.Clear()
        Chart1.DataSource = DT
        Dim Sfat As New DataVisualization.Charting.Series("fatturato")
        With Sfat
            .ChartType = DataVisualization.Charting.SeriesChartType.Column
            .Color = Color.Goldenrod
            .BorderWidth = 1
            .BorderColor = Color.Black
            .XValueMember = DT.Columns("anno").ToString
            .YValueMembers = DT.Columns("totale").ToString
        End With
        Chart1.Series.Add(Sfat)
        Sfat.ToolTip = Sfat.Name & " [ #VALX{F0} | #VALY{F2} ]"

        'Serie2
        Dim SOre As New DataVisualization.Charting.Series("ore")
        With SOre
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Color = Color.Red
            .BorderWidth = 2
            .MarkerSize = 12
            .MarkerBorderColor = Color.Black
            .MarkerBorderWidth = 2
            .MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond

            .XValueMember = DT.Columns("anno").ToString
            .YValueMembers = DT.Columns("ore").ToString
        End With
        Chart1.Series.Add(SOre)
        'Serie3
        Dim Sresa As New DataVisualization.Charting.Series("resa")
        With Sresa
            .ChartType = DataVisualization.Charting.SeriesChartType.Line
            .Color = Color.SlateBlue
            .BorderWidth = 2
            .MarkerSize = 10
            .MarkerBorderColor = Color.Blue
            .MarkerBorderWidth = 2
            .MarkerStyle = DataVisualization.Charting.MarkerStyle.Circle
            .XValueMember = DT.Columns("anno").ToString
            .YValueMembers = DT.Columns("resa").ToString
        End With
        Chart1.Series.Add(Sresa)

        With ComboBox2
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = DT
            .ValueMember = DT.Columns("anno").ToString
            .DisplayMember = DT.Columns("ore").ToString
        End With

        With ComboBox3
            .DropDownStyle = ComboBoxStyle.DropDownList
            .DataSource = DT
            .ValueMember = DT.Columns("anno").ToString
            .DisplayMember = DT.Columns("resa").ToString
        End With

    End Sub

    Private Function RiepilogoAnnuale()
        Me.TA_fattura_tot.FillByTuttigliAnni(Me.DS_fattura.DT_fattura_tot)

        Try
            Me.TA_contoreTot.FillByOreAnni(DS_fattura.DT_contoreTot)
        Catch ex As Exception
            Dim err As DataRow() = Me.DS_fattura.DT_contoreTot.GetErrors
            Dim msg As New StringBuilder
            For Each e In err
                Console.WriteLine(e.RowError)
            Next
            Return (False)
        End Try
        Return True
    End Function
    Private Function CaricoDati()
        Dim rg_tot As DS_fattura.DT_fattura_totRow
        For Each rg_tot In DS_fattura.DT_fattura_tot
            Dim totale As Decimal = If(rg_tot.tot_netto > 0, rg_tot.tot_netto, 1) / 10
            totale = Format(totale, "N2")
            DT.Rows.Add(totale, rg_tot.anno)
            maxI = If(maxI < totale, totale, maxI)
        Next
        Dim rg_ore As DS_fattura.DT_contoreTotRow
        For Each rg_ore In DS_fattura.DT_contoreTot
            If IsNothing(DT.Rows.Find(rg_ore.Item("anno"))) Then
            Else
                Dim totale As Decimal = DT.Rows.Find(rg_ore.Item("anno")).Item("totale")
                totale = Format(If(totale > 0, totale, 1), "N2")
                Dim ore As Decimal = rg_ore.totOre
                ore = Format(If(ore > 0, ore, 1), "N2")

                DT.Rows.Find(rg_ore.Item("anno")).Item("ore") = ore
                DT.Rows.Find(rg_ore.Item("anno")).Item("resa") = ((totale * 10) / ore)
                maxO = If(maxO < ore, ore, maxO)
                maxR = If(maxR < (totale * 10) / ore, (totale * 10) / ore, maxR)
            End If
        Next
        Dim Nscala As Integer = maxI / maxO
        Dim N2Scala As Integer = maxI / maxR
        For Each rg_ore In DS_fattura.DT_contoreTot
            If IsNothing(DT.Rows.Find(rg_ore.Item("anno"))) Then
            Else
                Dim totale As Decimal = DT.Rows.Find(rg_ore.Item("anno")).Item("totale")
                totale = Format(If(totale > 0, totale, 1), "N2")
                Dim ore As Decimal = DT.Rows.Find(rg_ore.Item("anno")).Item("ore")
                DT.Rows.Find(rg_ore.Item("anno")).Item("ore") = ore * Nscala
                DT.Rows.Find(rg_ore.Item("anno")).Item("resa") = (totale / ore) * N2Scala
            End If
        Next


        Return True

    End Function

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()
    End Sub

    Private Sub cmb_serie2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged

        Dim Nscala As Integer = maxI / maxO
        Dim N2Scala As Integer = maxI / maxR

        With Chart1.Series("ore")
            If .Points.Count = 0 Then Exit Sub
            For i As Integer = 0 To .Points.Count - 1
                .Points(i).Label = String.Empty
                .Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond
            Next
        End With
        With Chart1.Series("resa")
            If .Points.Count = 0 Then Exit Sub
            For i As Integer = 0 To .Points.Count - 1
                .Points(i).Label = String.Empty
                .Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Diamond
            Next
        End With
        With Chart1.Series("ore").Points(ComboBox2.SelectedIndex)
            .Font = fontLab
            .Label = "ore - " & "Anno = " & ComboBox2.SelectedValue & " | Ore = " & ComboBox2.Text / Nscala
            .LabelBackColor = Color.Gold
            .LabelBorderColor = Color.Black
            .LabelBorderWidth = 1
            .LabelForeColor = Color.Black
            .MarkerStyle = DataVisualization.Charting.MarkerStyle.Star10
        End With
        With Chart1.Series("resa").Points(ComboBox2.SelectedIndex)
            .Font = fontLab
            .Label = "resa - " & "Anno = " & ComboBox3.SelectedValue & " | resa = " & If(ComboBox3.Text.Length > 0, ComboBox3.Text, 1 / N2Scala)
            .LabelBackColor = Color.LightSalmon
            .LabelBorderColor = Color.Black
            .LabelBorderWidth = 1
            .LabelForeColor = Color.Black
            .MarkerStyle = DataVisualization.Charting.MarkerStyle.Cross
        End With

    End Sub

    Private Sub cmb_serie3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox3.SelectedIndexChanged

        With Chart1.Series("resa")
            If .Points.Count = 0 Then Exit Sub
            For i As Integer = 0 To .Points.Count - 1
                .Points(i).MarkerImage = String.Empty
            Next
        End With

        With Chart1.Series("ore").Points(ComboBox3.SelectedIndex)
            '.MarkerImage = percorsoBmp & nomeBmp
            .MarkerImageTransparentColor = Color.White
        End With

    End Sub

    Private Sub Chart1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Chart1.MouseMove

        Dim HTR As DataVisualization.Charting.HitTestResult = Chart1.HitTest(e.X, e.Y)
        'Controllo sul fatto che sia un DataPoint valido
        If Not HTR.ChartElementType = DataVisualization.Charting.ChartElementType.DataPoint Then Exit Sub
        'Controllo sul fatto che sia la Serie desiderata ( Serie4 )
        If Not HTR.Series.Name = "fatturato" Then Exit Sub

        With Chart1.Series("fatturato")
            For i As Integer = 0 To .Points.Count - 1
                .Points(i).Label = String.Empty
                .Points(i).MarkerStyle = DataVisualization.Charting.MarkerStyle.Square
            Next
        End With
        With Chart1.Series("fatturato").Points(HTR.PointIndex)
            .Font = fontLab
            .Label = "fatturato - " & "X = " & .XValue & " | Y = " & .YValues(0)
            .LabelBackColor = Color.YellowGreen
            .LabelBorderColor = Color.Black
            .LabelBorderWidth = 1
            .LabelForeColor = Color.Black
            .MarkerStyle = DataVisualization.Charting.MarkerStyle.Star10
        End With
    End Sub

End Class