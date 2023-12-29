Imports Microsoft.Reporting.WinForms
Imports System.IO

Public Class FRM_stp_fattura
    Dim id As String = ""
    Dim nome As String = ""
    Dim periodo As String = ""
    Dim oldriga As DS_fattura.DT_fatturaRow
    Dim posizione As String = ""
    Dim supporto As Integer
    Public nomefileFatturaGenerata As String
    Public Sub New(ByVal i As String, ByVal nom As String, per As String, Optional ByRef pos As String = "", Optional ByRef sup As Integer = 0)    'passa il numero della fattura e il nome della fattura
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        id = i
        nome = nom
        periodo = per
        posizione = pos
        supporto = sup


        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub FRM_stp_fattura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If supporto = 1 Then
            If Not IsNothing(id) Then
                Me.TA_fattura_tot.FillByFattura(Me.DS_fattura.DT_fattura_tot, id)
                Me.TA_fattura_righe.FillByFattura(Me.DS_fattura.DT_fattura_righe, id)
                Me.TA_fattura.FillByFattura(Me.DS_fattura.DT_fattura, id)
            Else
                Me.TA_fattura_tot.FillByPeriodo(Me.DS_fattura.DT_fattura_tot, periodo)
                Me.TA_fattura_righe.FillByPeriodo(Me.DS_fattura.DT_fattura_righe, periodo)
                Me.TA_fattura.FillByPeriodo(Me.DS_fattura.DT_fattura, periodo)
            End If
        Else
            If id.Length = 0 Then
                Me.TA_fattura_tot.FillByPeriodo(Me.DS_fattura.DT_fattura_tot, periodo)
                Me.TA_fattura_righe.FillByPeriodo(Me.DS_fattura.DT_fattura_righe, periodo)
                Me.TA_fattura.FillByPeriodo(Me.DS_fattura.DT_fattura, periodo)
            Else
                Me.TA_fattura_tot.FillByFattura(Me.DS_fattura.DT_fattura_tot, id)
                Me.TA_fattura_righe.FillByFattura(Me.DS_fattura.DT_fattura_righe, id)
                Try
                    Me.TA_fattura.FillByFattura(Me.DS_fattura.DT_fattura, id)
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                End Try
            End If

        End If

        If supporto = 1 Then
            Stampa()
        ElseIf supporto = 0 Then
            Esporta()

            Me.Close()
        End If


    End Sub

    Private Sub Stampa()
        ReportViewer1.RefreshReport()
    End Sub
    Private Sub Esporta()
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim bytes As Byte()
        Dim riga As DS_fattura.DT_fatturaRow
        riga = DirectCast(BS_fattura.Current, DataRowView).Row
        Try
            Dim nomefile As String
            nomefile = riga.fat_num_da.ToString & " #" & riga.fat_cli_id & "# " & riga.societa.Substring(0, IIf(riga.societa.Length >= 30, 30, riga.societa.Length)).Trim & "-" & MonthName(riga.fat_data.Month, False) & "-" & riga.fat_data.Year
            nomefile = nomefile.Replace("/", "-")
            nomefile = nomefile.Replace("\", "-")
            Try
                bytes = ReportViewer1.LocalReport.Render("pdf", Nothing, mimeType,
                encoding, extension, streamids, warnings)
            Catch ex As Exception

            End Try

            Dim fs As New FileStream(posizione & "\" & nomefile & ".pdf", FileMode.Create)
            fs.Write(bytes, 0, bytes.Length)
            fs.Close()
            nomefileFatturaGenerata = nomefile
        Catch ex As Exception
        End Try
    End Sub


End Class