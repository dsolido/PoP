Imports System.IO
Imports Microsoft.Reporting.WinForms

Public Class FRM_STP_Ordini
    Private id As Integer
    Dim posizione As String = ""
    Dim Tipo As Integer
    Public nomefileFatturaGenerata As String

    Public Sub New(ByVal _id As Integer, ByVal TipoStampa As Integer, Optional pos As String = "")    'passa il numero d'ordine e se Stampa o PDF
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        id = _id
        Tipo = TipoStampa
        posizione = pos
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TA_ordinirighe.FillByID_ordine(Me.DS_Ordini.DT_ordinirighe, id)
        Me.TA_ordini.FillByID(Me.DS_Ordini.DT_ordini, id)

        If Tipo = 1 Then
            Esporta()
        Else
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub
    Private Sub Esporta()
        If posizione = "" Then
            MsgBox("Devi inserire una posizione valida dove salvare il documento", MsgBoxResult.Abort)
            Return
        End If
        Dim warnings As Warning() = Nothing
        Dim streamids As String() = Nothing
        Dim mimeType As String = Nothing
        Dim encoding As String = Nothing
        Dim extension As String = Nothing
        Dim bytes As Byte()
        Dim riga As DS_Ordini.DT_ordiniRow
        riga = DirectCast(DT_ordiniBindingSource.Current, DataRowView).Row
        Try
            Dim nomefile As String
            nomefile = "ODF-" & riga.id.ToString & "-" & riga.locazione.Trim() & "-" & riga.fornitore.Trim() & "-" & MonthName(riga.data_ordine.Month, False) & "-" & riga.data_ordine.Year
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
            Me.Close()

        Catch ex As Exception
        End Try
    End Sub
End Class