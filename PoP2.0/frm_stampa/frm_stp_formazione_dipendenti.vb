Public Class frm_stp_formazione_dipendenti
    Private _id As Integer
    Private nome As String = GlobalVarPOP.G_nomeutente

    Public Sub New(id As Integer)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        _id = id
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub frm_stp_formazione_dipendenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.DT_UtentiTableAdapter.riempie_per_id(Me.DS_personale.DT_Utenti, _id)
        Me.DT_utenti_for_TA.per_dipendente(Me.DS_personale.DT_utenti_for, _id)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class