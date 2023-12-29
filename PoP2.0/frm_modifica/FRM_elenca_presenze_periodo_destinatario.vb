Public Class FRM_elenca_presenze_periodo_destinatario
    Dim DT As New DS_personale.DT_riepilogoOreDataTable
    Public Sub New(ByVal _DT As DataTable)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        DT = _DT
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRM_elenca_presenze_periodo_destinatario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RG_col As DS_personale.DT_riepilogoOreRow
        For Each RG In DT.Rows
            RG_col = RG
            Dim RigaDT As New DataGridViewRow
            Dim ColDT As String() = {RG_col.Item("data"), RG_col.locazione, RG_col.descrizione, RG_col.Item("cognome"), RG_col("nome"), RG_col.totale, RG_col.note}
            RigaDT.CreateCells(DG_destinatari, ColDT)
            DG_destinatari.Rows.Add(RigaDT)
        Next
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Me.Close()
    End Sub

    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        'Dim F As New FRM_riepilogo_presenze_Cliente(BS_)
        'F.Show()
    End Sub
End Class