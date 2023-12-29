Public Class frmElencoPresenzeInserite
    Dim dtPresenze As DataTable
    Public Sub New(ByVal _dt As DataTable)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        dtPresenze = _dt
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub frmElencoPresenzeInserite_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'dgwElencoPresenze.DataSource = dtPresenze
        Dim creaTabella As creaTabelladaDataTable = New creaTabelladaDataTable
        creaTabella.datatable = dtPresenze
        creaTabella.dimFontCella = 8
        creaTabella.dataGridPresenze = dgwElencoPresenze
        Dim campi As String() = {"id", "societa", "dettaglio", "giorno", "ore", "note"}
        creaTabella.ColCollection = campi
        creaTabella.Crea()
        dgwElencoPresenze.DataSource = dtPresenze

        'Dim CliRow As DataRow
        'Dim colonna As DataColumn
        'colonna = New DataColumn
        'colonna.ColumnName = "id"
        'colonna.DataType = Type.GetType("System.Int32")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "id_cli"
        'colonna.DataType = Type.GetType("System.Int32")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "id_det"
        'colonna.DataType = Type.GetType("System.Int32")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "id_dip"
        'colonna.DataType = Type.GetType("System.Int32")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "societa"
        'colonna.DataType = Type.GetType("System.String")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "dettaglio"
        'colonna.DataType = Type.GetType("System.String")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "anagrafica"
        'colonna.DataType = Type.GetType("System.String")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "giorno"
        'colonna.DataType = Type.GetType("System.Int32")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "ore"
        'colonna.DataType = Type.GetType("System.Decimal")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "note"
        'colonna.DataType = Type.GetType("System.String")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "id_tipo"
        'colonna.DataType = Type.GetType("System.Int32")
        'Cli.Columns.Add(colonna)
        'colonna = New DataColumn
        'colonna.ColumnName = "auto"
        'colonna.DataType = Type.GetType("System.Int32")
        'Cli.Columns.Add(colonna)


    End Sub
End Class