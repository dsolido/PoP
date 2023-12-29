
Imports System.Web.Script.Serialization
Imports Newtonsoft.Json.Linq
Imports System.Dynamic
Imports System.Net
Imports Newtonsoft.Json
Imports System.IO

Public Class frmControlloPosizioneGPS
    Dim request As HttpWebRequest

    Dim reader As IO.StreamReader
    Dim ApiKey As String = "AIzaSyDMz2fYZaNiAPBokHt_wnNCoanNNl_XTEY"
    Private Sub frmControlloPosizioneGPS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_utenti.FillByAttivi(Me.DS_utenti.DT_utenti, 1, GlobalVarPOP.G_idAZ)
        Me.TA_locazione_new.FillByDettagliAttivi(Me.DS_clienti.DT_locazione_new, GlobalVarPOP.G_idAZ, "%%")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x As Integer
        Dim max As Integer
        For Each rr In dgwDettaglioCliente.SelectedRows
            max += 1
        Next

        pbRegistrazione.Maximum = max

        For Each RGselect In dgwDettaglioCliente.SelectedRows
            pbRegistrazione.Value = x
            Dim id As Integer = RGselect.Cells(dgwcIDdettaglio.Index).Value
            Dim RG As DS_clienti.DT_locazione_newRow
            '        For Each rgTmp In bsElencoDettagli
            Dim pos As Integer = bsElencoDettagli.Find("id", id)
            If pos >= 0 Then
                bsElencoDettagli.Position = pos
            Else
                Continue For
            End If

            RG = DirectCast(bsElencoDettagli.Current, DataRowView).Row
            '       Next
            Dim indirizzoDaRilevare As String = (Uri.EscapeDataString(RG.address.ToLower().Replace(",", " ")) + ("," + (RG.citta + (",Italia"))))


            Dim url As System.Uri = New Uri(String.Format("https://maps.googleapis.com/maps/api/geocode/json?address={1}&key={0}", ApiKey, indirizzoDaRilevare))

            Dim request As WebRequest = WebRequest.Create(url)


            'request = DirectCast(WebRequest.Create(url), HttpWebRequest)
            Dim response As WebResponse


            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())

            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            rawresp = rawresp.Replace(vbLf, "")

            Dim lista As JObject = JsonConvert.DeserializeObject(Of JObject)(rawresp)
            Dim lat, lon As String
            Dim JToken As JObject

            For Each item In lista
                For Each y1 As Object In item.Value
                    Dim jObj As Object
                    jObj = JsonConvert.DeserializeObject(y1.ToString)
                    JToken = DirectCast(jObj, JObject)
                Next

            Next

            Dim Jtoken1 As JObject = JToken.SelectToken("geometry")
            Dim Jtoken2 As JObject = Jtoken1.SelectToken("location")

            lat = Jtoken2.SelectToken("lat")
            lon = Jtoken2.SelectToken("lng")


            If lat = Nothing Or lon = Nothing Then
                MsgBox("Non trovo le coordinate")
                Return
            Else
                txtLatitudine.Text = lat
                txtLongitudine.Text = lon
                TA_locazione_new.AggiornaGPS(lat.ToString, lon.ToString, RG.id)
            End If
            x += 1

        Next
        Dim risultatorichiesta As String = "https://maps.googleapis.com/maps/api/staticmap?center={0},{1}&{2}&&markers=color:red%7Clabel:Y%7C{0},{1}&key={3}"
        Dim risultatoCodificato = String.Format(risultatorichiesta, txtLatitudine.Text.Trim.Replace(",", "."), txtLongitudine.Text.Trim.Replace(",", "."), "zoom=15&size=300x300", ApiKey)
        WebBrowser1.Navigate(risultatoCodificato)

    End Sub


    Private Sub btAggiornaDipendenti_Click(sender As Object, e As EventArgs) Handles btAggiornaDipendenti.Click
        Dim x As Integer
        Dim max As Integer
        For Each rr In dgwDipendenti.SelectedRows
            max += 1
        Next

        pbRegistrazione.Maximum = max

        For Each RGselect In dgwDipendenti.SelectedRows
            pbRegistrazione.Value = x
            Dim id As Integer = RGselect.Cells(dgwcIDDipendente.Index).Value
            Dim RG As DS_utenti.DT_utentiRow

            Dim pos As Integer = bsUtenti.Find("id", id)
            If pos >= 0 Then
                bsUtenti.Position = pos
            Else
                Continue For
            End If

            RG = DirectCast(bsUtenti.Current, DataRowView).Row
            '       Next
            Dim indirizzoDaRilevare As String = (Uri.EscapeDataString(RG.indirizzo.ToLower().Replace(",", " ")) + ("," + (RG.citta + (",Italia," + RG.cap))))
            Dim url As String = "https://maps.googleapis.com/maps/api/geocode/json?address={1}&key={0}"

            url = String.Format(url, ApiKey, indirizzoDaRilevare)
            Dim request As WebRequest = WebRequest.Create(url)


            'request = DirectCast(WebRequest.Create(url), HttpWebRequest)
            Dim response As WebResponse


            response = DirectCast(request.GetResponse(), HttpWebResponse)
            reader = New StreamReader(response.GetResponseStream())
            Dim rawresp As String
            rawresp = reader.ReadToEnd()
            rawresp = rawresp.Replace(vbLf, "")

            Dim lista As JObject = JsonConvert.DeserializeObject(Of JObject)(rawresp)
            Dim lat, lon As Decimal
            Dim JToken As JObject

            For Each item In lista
                For Each y1 As Object In item.Value
                    Dim jObj As Object
                    jObj = JsonConvert.DeserializeObject(y1.ToString)
                    JToken = DirectCast(jObj, JObject)
                Next

            Next
            Dim Jtoken1, Jtoken2 As JObject

            Try
                Jtoken1 = JToken.SelectToken("geometry")
                Jtoken2 = Jtoken1.SelectToken("location")
            Catch ex As Exception
                MsgBox("Problemi nella rilevazione della localizzazione")
                Continue For
            End Try


            lat = Decimal.Parse(Jtoken2.SelectToken("lat").ToString.Trim.Replace(".", ","))
            lon = Decimal.Parse(Jtoken2.SelectToken("lng").ToString.Trim.Replace(".", ","))

            If lat = Nothing Or lon = Nothing Then
                MsgBox("Non trovo le coordinate")
                Continue For
            Else
                txLatDipendente.Text = lat.ToString
                txLonDipendente.Text = lon.ToString
                TA_utenti.AggiornaGPS(lat, lon, RG.id)
            End If
            x += 1

        Next
        Dim risultatorichiesta As String = "https://maps.googleapis.com/maps/api/staticmap?center={0},{1}&{2}&&markers=color:red%7Clabel:Y%7C{0},{1}&key={3}"
        Dim risultatoCodificato = String.Format(risultatorichiesta, txLatDipendente.Text.Trim.Replace(",", "."), txLonDipendente.Text.Trim.Replace(",", "."), "zoom=15&size=300x300", ApiKey)
        WebBrowser1.Navigate(risultatoCodificato)
    End Sub

    Private Sub btnCalcolaDistanzenelMese_Click(sender As Object, e As EventArgs) Handles btnCalcolaDistanzenelMese.Click
        Dim dt As New DS_utenti.dtDistanzeTimbrateDataTable
        Dim filtro As String = String.Format("%{0}%", tbFiltrodettagliocantiere.Text)

        Using ta As New DS_utentiTableAdapters.taDistanzeTimbrate
            ta.FillByPeriodoTipo(dt, GlobalVarPOP.GPeriodo, filtro)
        End Using
        dgwDistanzePercorse.Columns.Clear()
        dgwDistanzePercorse.Rows.Clear()
        pbRegistrazione.Value = 0

        If ckDettaglio.Checked Then
            pbRegistrazione.Maximum = dt.Rows.Count
        Else
            Dim totaleRigheDipendente As Int16
            Dim tt = dt.AsEnumerable.GroupBy(Function(x) x.cognome & x.nome)
            totaleRigheDipendente = tt.Count
            pbRegistrazione.Maximum = totaleRigheDipendente
        End If


        Dim dgwcDip As DataGridViewTextBoxColumn
        dgwcDip = New DataGridViewTextBoxColumn()
        dgwcDip.Name = "dgwcDipendente"
        dgwcDip.HeaderText = "Dipendente"
        Dim dgwcLoc As DataGridViewTextBoxColumn
        dgwcLoc = New DataGridViewTextBoxColumn()
        dgwcLoc.Name = "dgwcLocazione"
        dgwcLoc.HeaderText = "Destinatario"
        Dim dgwcDis As DataGridViewTextBoxColumn
        dgwcDis = New DataGridViewTextBoxColumn()
        dgwcDis.Name = "dgwcDistanza"
        dgwcDis.HeaderText = "Distanza"
        Dim dgwcCos As DataGridViewTextBoxColumn
        dgwcCos = New DataGridViewTextBoxColumn()
        dgwcCos.Name = "dgwcCosto"
        dgwcCos.HeaderText = "Costo"
        Dim stile As New DataGridViewCellStyle
        stile.Alignment = DataGridViewContentAlignment.BottomRight

        dgwcCos.DefaultCellStyle = stile

        dgwDistanzePercorse.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {dgwcDip, dgwcLoc, dgwcDis, dgwcCos})
        Dim Progressivo As Int16
        Dim ultimoDip As String = dt(0).cognome & " " & dt(0).nome
        Dim ultimaLoc As String = dt(0).locazione
        Dim ultimaLocazione As String = dt(0).locazione
        Dim TotaleLocazione As Decimal = 0
        Dim TotaleDipendente As Decimal = 0
        Dim GranTotaleDipendente As Decimal = 0
        Dim GranTotale As Decimal = 0
        Dim cantierivisitati As Int16 = 0
        'dgwDistanzePercorse.Rows.Add()
        Dim ultimaRiga As Int16 = 0
        Dim totalecarburante As Decimal = 0
        Dim resaalkm As Decimal

        Try
            totalecarburante = txCostoCarburante.Text
            resaalkm = txResaLitriaChilometro.Text
        Catch ex As Exception

        End Try

        For Each rg As DS_utenti.dtDistanzeTimbrateRow In dt.Rows
            If ckDettaglio.Checked Then
                Progressivo += 1
            End If
            Try
                If rg.lonCL <> vbEmpty And rg.latCL <> vbEmpty Then

                    Dim dipendente As String = rg.cognome & " " & rg.nome
                    Dim locazione As String = rg.locazione
                    Dim Distanza As Double
                    'Calcola la distanza tra due punti
                    Distanza = RitornaDistanza(rg.lonUT, rg.latUT, rg.lonCL, rg.latCL)
                    GranTotale += Distanza
                    Select Case True
                        Case ultimoDip = dipendente And ultimaLoc = locazione
                            If ckDettaglio.Checked Then     'Stampa i dettagli
                                dgwDistanzePercorse.Rows.Add()
                                stile = New DataGridViewCellStyle
                                stile.BackColor = DefaultBackColor
                                dgwcCos.DefaultCellStyle = stile
                                dgwDistanzePercorse(dgwcDip.Index, ultimaRiga).Value = dipendente
                                dgwDistanzePercorse(dgwcLoc.Index, ultimaRiga).Value = locazione
                                dgwDistanzePercorse(dgwcDis.Index, ultimaRiga).Value = (Distanza / 1000).ToString("N2")
                                dgwDistanzePercorse(dgwcCos.Index, ultimaRiga).Value = Decimal.Parse((totalecarburante * resaalkm * (Distanza / 1000)).ToString("N2"))
                                ultimaRiga += 1
                            End If
                            GranTotaleDipendente += Distanza
                            TotaleDipendente += Distanza
                            TotaleLocazione += Distanza
                            cantierivisitati += 1

                        Case ultimoDip = dipendente And ultimaLoc <> locazione
                            If ckDettaglio.Checked Then
                                Progressivo += 1
                                pbRegistrazione.Value = Progressivo
                                Application.DoEvents()
                                dgwDistanzePercorse.Rows.Add()
                                stile = New DataGridViewCellStyle
                                stile.BackColor = Color.Orange
                                stile.Alignment = DataGridViewContentAlignment.MiddleLeft
                                dgwDistanzePercorse(dgwcDip.Index, ultimaRiga).Style = stile
                                dgwDistanzePercorse(dgwcDip.Index, ultimaRiga).Value = ultimoDip
                                dgwDistanzePercorse(dgwcLoc.Index, ultimaRiga).Style = stile
                                dgwDistanzePercorse(dgwcLoc.Index, ultimaRiga).Value = "N° movimenti " & cantierivisitati.ToString()
                                stile = New DataGridViewCellStyle
                                stile.BackColor = Color.Orange
                                stile.Alignment = DataGridViewContentAlignment.MiddleRight
                                dgwDistanzePercorse(dgwcDis.Index, ultimaRiga).Style = stile
                                dgwDistanzePercorse(dgwcDis.Index, ultimaRiga).Value = "Km Cantiere " & (TotaleLocazione / 1000).ToString("N2") 'Inserisce il totale KM del dipendente
                                dgwDistanzePercorse(dgwcCos.Index, ultimaRiga).Style = stile
                                dgwDistanzePercorse(dgwcCos.Index, ultimaRiga).Value = Decimal.Parse((totalecarburante * resaalkm * (TotaleLocazione / 1000)).ToString("N2"))
                                'Aggiorna i contatori
                                ultimaRiga += 1
                                cantierivisitati = 0
                            End If
                            ultimaLoc = locazione
                            TotaleDipendente += Distanza
                            GranTotaleDipendente += Distanza
                            TotaleLocazione += Distanza
                        Case ultimoDip <> dipendente
                            'Stampa il resoconto dell'ultimo dipendente
                            '
                            '
                            Progressivo += 1
                            pbRegistrazione.Value = Progressivo
                            Application.DoEvents()
                            dgwDistanzePercorse.Rows.Add()

                            stile = New DataGridViewCellStyle
                            stile.BackColor = Color.LightCoral
                            stile.Alignment = DataGridViewContentAlignment.MiddleLeft
                            dgwDistanzePercorse(dgwcDip.Index, ultimaRiga).Style = stile
                            dgwDistanzePercorse(dgwcDip.Index, ultimaRiga).Value = ultimoDip
                            dgwDistanzePercorse(dgwcLoc.Index, ultimaRiga).Style = stile
                            If ckDettaglio.Checked Then
                                dgwDistanzePercorse(dgwcLoc.Index, ultimaRiga).Value = "Totale dipendente"
                            Else
                                dgwDistanzePercorse(dgwcLoc.Index, ultimaRiga).Value = "N° movimenti " & cantierivisitati.ToString()
                            End If


                            stile = New DataGridViewCellStyle
                            stile.BackColor = Color.LightCoral
                            stile.Alignment = DataGridViewContentAlignment.MiddleRight
                            dgwDistanzePercorse(dgwcDis.Index, ultimaRiga).Style = stile
                            dgwDistanzePercorse(dgwcDis.Index, ultimaRiga).Value = "Km Dipendente " & (GranTotaleDipendente / 1000).ToString("N2") 'Inserisce il totale KM del dipendente
                            dgwDistanzePercorse(dgwcCos.Index, ultimaRiga).Style = stile
                            dgwDistanzePercorse(dgwcCos.Index, ultimaRiga).Value = Decimal.Parse((totalecarburante * resaalkm * (GranTotaleDipendente / 1000)).ToString("N2"))
                            'Aggiorna i contatori
                            TotaleDipendente = 0
                            TotaleLocazione = 0
                            GranTotaleDipendente = 0
                            ultimaRiga += 1
                            cantierivisitati = 0
                            ultimaLoc = locazione
                            ultimoDip = dipendente
                            TotaleDipendente += Distanza
                            GranTotaleDipendente += Distanza
                            TotaleLocazione += Distanza

                    End Select
                End If

            Catch ex As Exception
#If DEBUG Then
                Console.WriteLine(rg.cognome & " " & rg.locazione & rg.giorno)
#End If
            End Try
        Next
        stile = New DataGridViewCellStyle
        stile.BackColor = Color.Coral
        stile.Alignment = DataGridViewContentAlignment.MiddleRight
        dgwDistanzePercorse(dgwcDis.Index, ultimaRiga).Style = stile
        dgwDistanzePercorse(dgwcDis.Index, ultimaRiga).Value = "Totale KM " & (GranTotale / 1000).ToString("N2") 'Inserisce il totale KM del dipendente
        dgwDistanzePercorse(dgwcCos.Index, ultimaRiga).Style = stile
        dgwDistanzePercorse(dgwcCos.Index, ultimaRiga).Value = Decimal.Parse((totalecarburante * resaalkm * (GranTotale / 1000)).ToString("N2"))

        pbRegistrazione.Value = 0
    End Sub
    Private Shared Function RitornaDistanza(ByVal lonUT As Double, ByVal latUT As Double, ByVal lonCL As Double, ByVal latCL As Double) As Double
        Dim distanza As Double
        Dim theta As Decimal = lonUT - lonCL

        distanza = (Math.Sin(deg2rad(latUT)) * Math.Sin(deg2rad(latCL))) + (Math.Cos(deg2rad(lonUT)) * Math.Cos(deg2rad(lonCL)) * Math.Cos(deg2rad(theta)))
        distanza = Math.Acos(distanza)
        distanza = rad2deg(distanza)
        distanza = distanza * 60 * 1.609344
        distanza = Math.Round(distanza, 2)
        Return distanza
    End Function
    Private Shared Function deg2rad(ByVal degrees As Double) As Double
        Return degrees * Math.PI / 180
    End Function

    Private Shared Function rad2deg(ByVal radians As Double) As Double
        Return radians * 180 / Math.PI
    End Function
End Class
