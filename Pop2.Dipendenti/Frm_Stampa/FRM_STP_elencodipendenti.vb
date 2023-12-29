Public Class FRM_STP_elencodipendenti
    Dim rg As BindingSource
    Public Sub New(_RG As BindingSource)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        rg = _RG

    End Sub
    Private Sub FRM_STP_elencodipendenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TA_azienda.Fill(Me.DS_azienda.DT_azienda)
        Me.TA_utenti.Fill(DS_utenti.DT_utenti, GlobalVarPOP.G_idAZ)
        BS_dipendenti.Filter = rg.Filter
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class