
Public Class FRM_STP_fatture
    Dim BS_FA As BindingSource
    Dim BS_FR As BindingSource
    Dim BS_FT As BindingSource
    'Friend BS_fattura As BindingSource

    'Dim BS_fattura As BindingSource

    Public Sub New(ByVal Optional _F As BindingSource = Nothing, Optional _R As BindingSource = Nothing, Optional _T As BindingSource = Nothing)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        BS_FA = _F
        BS_FR = _R
        BS_FT = _T


        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRM_STP_fatture_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        BS_fattura.DataSource = BS_FA.DataSource
        BS_fattura.DataMember = BS_FA.DataMember

        BS_righe.DataSource = BS_FR.DataSource
        BS_righe.DataMember = BS_FR.DataMember

        BS_tot.DataSource = BS_FT.DataSource
        BS_tot.DataMember = BS_FT.DataMember

        If BS_FA.Filter <> "" Then
            BS_fattura.Filter = BS_FA.Filter
        End If
        If BS_FR.Filter <> "" Then
            BS_righe.Filter = BS_FR.Filter
        End If
        Dim RG As DS_fattura.DT_fattura_totRow
        BS_FT.RemoveFilter()
        If BS_FT.Filter <> "" Then
            BS_tot.Filter = BS_FT.Filter
        End If
        For Each tmpRG In BS_tot
            RG = DirectCast(tmpRG, DataRowView).Row
            Console.WriteLine(RG.tot_netto.ToString & " " & RG.tot_iva.ToString)
        Next
        Me.ReportViewer2.RefreshReport()
    End Sub
End Class