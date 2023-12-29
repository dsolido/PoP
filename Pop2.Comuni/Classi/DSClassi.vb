#Disable Warning CA1707 ' Gli identificatori non devono contenere caratteri di sottolineatura
Imports System.ComponentModel
Imports System.Globalization
Imports System.IO
Imports System.Xml.Serialization

<CodeAnalysis.SuppressMessage("Design", "CA1052:I tipi che contengono membri static devono Static o NotInheritable", Justification:="<In sospeso>")>
Public Class GlobalVarPOP
#Disable Warning CA2211 ' I campi non costanti non devono essere visibili
    Public Shared G_idUtente As Integer    ' identificativo dell'utente registrato
    Public Shared G_nomeutente As String
    Public Shared G_id_remotoUtente As Integer
    Public Shared G_id_localeUtente As Integer
    Public Shared G_idAZ As Integer
    Public Shared G_emailutente As String
    Public Shared G_pwdutente As String
    Public Shared G_indirizzosmtp As String
    Public Shared G_culture As CultureInfo
    Public Shared G_iva As Decimal = 22        'predispone l'iva al 22%
    Public Shared gradoaccesso As Integer
    Public Shared G_amese As String() = New String() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"}
    Public Shared G_aAnno As String()
    Public Shared GPeriodo As String
    Public Shared ResaMinima As Decimal = 19.5
    Public Shared GColoreUtenteLoggato As String
    Public Shared gArrayColoreUtenti As String()
    Public Shared gArrayNomeUtenti As String()

#Enable Warning CA2211 ' I campi non costanti non devono essere visibili
End Class

Public Class TextBoxX
    Inherits TextBox

    Private m_EnterValue As String = ""
#Disable Warning CA1805 ' Non eseguire inutilmente l'inizializzazione
    Private _identifico As Integer = 0
#Enable Warning CA1805 ' Non eseguire inutilmente l'inizializzazione
    <CodeAnalysis.SuppressMessage("Design", "CA1003:Usare istanze del gestore dell'evento generico", Justification:="<In sospeso>")>
    Public Event ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs)

    Private Sub InitializeComponent()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
    End Sub
    Overloads Property Tag(ByVal identifico As Integer) As Integer
        Get
            Return _identifico
        End Get
        Set(value As Integer)
            _identifico = value
        End Set
    End Property
    Overloads Property Text(ByVal FormatData As Boolean) As String
        Get
            Text = Me.Text
        End Get
        Set(ByVal Value As String)
            Me.Text = Value
            m_EnterValue = Me.Text
        End Set
    End Property

    Property EnterValue() As String
        Get
            EnterValue = m_EnterValue
        End Get
        Set(ByVal Value As String)
            m_EnterValue = Value
        End Set
    End Property

    Private Sub YourControlName_Leave(ByVal sender As Object, ByVal e _
            As System.EventArgs) Handles MyBase.Leave
        If m_EnterValue < Me.Text Then RaiseEvent ValueChanged(sender, e)
    End Sub

End Class


Public Class DGCellElementID
    'Inherits DataGridViewElement
    Private _testo
    Private _id1
    Private _name
    Private _extradata
    Public Property TXextra As String
        Get
            Return _testo
        End Get
        Set(value As String)
            _testo = value
        End Set
    End Property
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Property Tag As String
        Get
            Return _extradata
        End Get
        Set(ByVal value As String)
            _extradata = value
        End Set
    End Property
    Public Property idData As Integer
        Get
            Return _id1
        End Get
        Set(ByVal value As Integer)
            _id1 = value
        End Set
    End Property
    Public Overrides Function ToString() As String
        Return TXextra
    End Function

End Class

Public Class DataGridViewRolloverCell
    Inherits DataGridViewTextBoxCell
    Private _identifico As Integer
    <CodeAnalysis.SuppressMessage("Naming", "CA1725:I nomi di parametro devono corrispondere alla dichiarazione di base", Justification:="<In sospeso>")>
    Protected Overrides Sub Paint(
        ByVal graphics As Graphics,
        ByVal clipBounds As Rectangle,
        ByVal cellBounds As Rectangle,
        ByVal rowIndex As Integer,
        ByVal elementState As DataGridViewElementStates,
        ByVal value As Object,
        ByVal formattedValue As Object,
        ByVal errorText As String,
        ByVal cellStyle As DataGridViewCellStyle,
        ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle,
        ByVal paintParts As DataGridViewPaintParts)

        ' Call the base class method to paint the default cell appearance.
        MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, elementState,
            value, formattedValue, errorText, cellStyle,
            advancedBorderStyle, paintParts)

        ' Retrieve the client location of the mouse pointer.
        Dim cursorPosition As Point =
            Me.DataGridView.PointToClient(Cursor.Position)

        ' If the mouse pointer is over the current cell, draw a custom border.
        If cellBounds.Contains(cursorPosition) Then
            Dim newRect As New Rectangle(cellBounds.X + 1,
                cellBounds.Y + 1, cellBounds.Width - 4,
                cellBounds.Height - 4)
#Disable Warning CA1062 ' Convalidare gli argomenti di metodi pubblici
            graphics.DrawRectangle(Pens.Red, newRect)
#Enable Warning CA1062 ' Convalidare gli argomenti di metodi pubblici
        End If

    End Sub
    Overloads Property TagX As Integer
        Get
            Return _identifico
        End Get
        Set(value As Integer)
            _identifico = value
        End Set
    End Property
    ' Force the cell to repaint itself when the mouse pointer enters it.
    Protected Overrides Sub OnMouseEnter(ByVal rowIndex As Integer)
        Me.DataGridView.InvalidateCell(Me)
    End Sub

    ' Force the cell to repaint itself when the mouse pointer leaves it.
    Protected Overrides Sub OnMouseLeave(ByVal rowIndex As Integer)
        Me.DataGridView.InvalidateCell(Me)
    End Sub

End Class

Public Class DataGridViewRolloverCellColumn
    Inherits DataGridViewColumn

    Public Sub New()
        Me.CellTemplate = New DataGridViewRolloverCell()
    End Sub

End Class
Public Class CheckAvvisi
    Private xname As String
    Private xextraData As String
    Private xID1 As Integer
    Private xID2 As Integer
    Private xattivo As Integer
    Private xtesto As String


    Public Property Testo As String
        Get
            Return xtesto
        End Get
        Set(ByVal value As String)
            xtesto = value
        End Set
    End Property

    Public Property Name As String
        Get
            Return xname
        End Get
        Set(ByVal value As String)
            xname = value
        End Set
    End Property

    Public Property Tag As String
        Get
            Return xextraData
        End Get
        Set(ByVal value As String)
            xextraData = value
        End Set
    End Property
    Public Property IDa As Integer
        Get
            Return xID1
        End Get
        Set(ByVal value As Integer)
            xID1 = value
        End Set
    End Property
    Public Property IDb As Integer
        Get
            Return xID2
        End Get
        Set(ByVal value As Integer)
            xID2 = value
        End Set
    End Property
    Public Property Attivo As Integer
        Get
            Return xattivo
        End Get
        Set(ByVal value As Integer)
            xattivo = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Testo
    End Function
End Class
Public Class creaTabellaOreMese
    Private xDatagridPresenze As DataGridView
    Private xDataGridTotale As DataGridView
    Private xMese As Integer
    Private xAnno As Integer
    Private xDescrizionePrimaTabella As String
    Private xDescrizioneSecondaTabella As String
    Private xdimFontCella As Integer = 8

    Public Property dataGridPresenze As DataGridView
        Get
            Return xDatagridPresenze
        End Get
        Set(value As DataGridView)
            xDatagridPresenze = value
        End Set
    End Property
    Public Property dataGridTotale As DataGridView
        Get
            Return xDataGridTotale
        End Get
        Set(value As DataGridView)
            xDataGridTotale = value
        End Set
    End Property
    Public Property Anno As Integer
        Get
            Return xAnno
        End Get
        Set(value As Integer)
            xAnno = value
        End Set
    End Property

    Public Property Mese As Integer
        Get
            Return xMese
        End Get
        Set(value As Integer)
            xMese = value
        End Set
    End Property
    Public Property DescPrimaTabella As String
        Get
            Return xDescrizionePrimaTabella
        End Get
        Set(value As String)
            xDescrizionePrimaTabella = value
        End Set
    End Property
    Public Property DescSecondaTabella As String
        Get
            Return xDescrizioneSecondaTabella
        End Get
        Set(value As String)
            xDescrizioneSecondaTabella = value
        End Set
    End Property
    Public Property dimFontCella As Integer
        Get
            Return xdimFontCella
        End Get
        Set(value As Integer)
            xdimFontCella = value
        End Set
    End Property
    '*'*    Crea la tabella che viene utilizzata nel riepilogo delle Fatture nella Maschera Clienti
    '       TODO verificare se è possibile utilizzarla anche per altro o accorparla nella Classe successiva.
    Public Function Crea() As Boolean
        'Funzione che crea i riepilogo delle ore e li carica nel DG
        Dim dw As String() = New String() {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
        Dim tmp_data As DateTime

        Select Case True
            Case IsNothing(Anno)
                Return False
            Case Anno = 0
                Return False
            Case IsNothing(Mese)
                Return False
            Case Mese = 0
                Return False
        End Select
        If Not IsNothing(dataGridPresenze) Then
            dataGridPresenze.Columns.Clear()
        End If

        If Not IsNothing(dataGridTotale) Then
            dataGridTotale.Columns.Clear()
        End If


        tmp_data = DateSerial(Anno, Mese, 1)
        Dim ultimogiorno As Integer = DateSerial(Anno, Mese + 1, 0).Day
        Dim larghezzacella As Integer = dataGridPresenze.Width / (ultimogiorno + 6)
        Dim tmp_day = tmp_data

        For prog = 0 To ultimogiorno + 1
            Dim dataCella = 1
            Select Case prog
                Case > 0 And prog <= ultimogiorno
                    dataCella = prog
                Case > ultimogiorno
                    dataCella = ultimogiorno
            End Select

            tmp_day = DateSerial(Anno, Mese, dataCella)

            Dim CelObj As String
            CelObj = "C" & prog
            Dim DGCol As DataGridViewRolloverCellColumn
            DGCol = CType(dataGridPresenze.Columns(CelObj), DataGridViewRolloverCellColumn)
            If IsNothing(DGCol) Then
                Dim col As New DataGridViewRolloverCellColumn()
                Dim Col2 As New DataGridViewRolloverCellColumn()
                Select Case True
                        '
                        'Inserisce Colonna intestazione
                        '
                    Case prog = 0
                        With col
                            .HeaderText = If(IsNothing(DescPrimaTabella), "Cliente", DescPrimaTabella)
                            .Width = larghezzacella * 4
                            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                            .DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
                            .Name = "C" & prog
                        End With
                        With Col2
                            .HeaderText = If(IsNothing(DescSecondaTabella), "Dipendente", DescSecondaTabella)
                            .Width = larghezzacella * 4
                            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                            .DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
                            .Name = "C" & prog
                        End With
                        '
                        'inserisce colonna giorni
                        '
                    Case prog > 0 And prog <= ultimogiorno
                        tmp_data = New DateTime(Anno, Mese, dataCella) 'Ricrea il giorno del mese
                        With col
                            .HeaderText = dw(tmp_data.DayOfWeek).Substring(0, 1) & " " & tmp_day.Day.ToString.PadLeft(2, "0")
                            .Width = larghezzacella
                            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                            .DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
                            .Name = "C" & prog
                        End With
                        With Col2
                            .HeaderText = dw(tmp_data.DayOfWeek).Substring(0, 1) & " " & tmp_day.Day.ToString.PadLeft(2, "0")
                            .Width = larghezzacella
                            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                            .DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
                            .Name = "C" & prog
                        End With
                        '
                        'inserisce colonna del Totale
                        '
                    Case prog = ultimogiorno + 1
                        With col
                            .HeaderText = "Totale"
                            .Width = larghezzacella * 1.3
                            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                            .DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
                            .Name = "C" & prog
                        End With
                        With Col2
                            .HeaderText = "Totale"
                            .Width = larghezzacella * 1.3
                            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                            .DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
                            .Name = "C" & prog
                        End With
                End Select
                '
                'Se è stata passato il Datagrid
                '
                If Not IsNothing(dataGridPresenze) Then
                    dataGridPresenze.Columns.Add(col)
                End If

                If Not IsNothing(dataGridTotale) Then
                    dataGridTotale.Columns.Add(Col2)
                End If
            End If
        Next

        Return True
    End Function

End Class

Public Class dgCaricaDatiPresenze
    Private xdtPresenze As DataTable
    Private xidCantiere As Integer
    Private xrgDataRow As DataRowView
    Private xMese As Integer
    Private xAnno As Integer
    'Private xTipoTabellaSupporto As String
    Private xdataGridAppoggio As DataGridView
    Private xReale As Boolean
    Private xRemota As Boolean
    Public Property Anno As Integer
        Get
            Return xAnno
        End Get
        Set(value As Integer)
            xAnno = value
        End Set
    End Property

    Public Property Mese As Integer
        Get
            Return xMese
        End Get
        Set(value As Integer)
            xMese = value
        End Set
    End Property

    Public Property dtPresenze As DataTable
        Get
            Return xdtPresenze
        End Get
        Set(value As DataTable)
            xdtPresenze = value
        End Set
    End Property
    Public Property idCantiere As Integer
        Get
            Return xidCantiere
        End Get
        Set(value As Integer)
            xidCantiere = value
        End Set
    End Property
    Public Property rgDataRow As DataRowView
        Get
            Return xrgDataRow
        End Get
        Set(value As DataRowView)
            xrgDataRow = value
        End Set
    End Property

    'Public Property tipoTabellaSupporto As String
    '    Get
    '        Return xTipoTabellaSupporto
    '    End Get
    '    Set(value As String)
    '        xTipoTabellaSupporto = value
    '    End Set
    'End Property
    Public Property reale As Boolean
        Get
            Return xReale
        End Get
        Set(value As Boolean)
            xReale = value
        End Set
    End Property
    Public Property remota As Boolean
        Get
            Return xRemota
        End Get
        Set(value As Boolean)
            xRemota = value
        End Set
    End Property
    Public Property dataGridAppoggio As DataGridView
        Get
            Return xdataGridAppoggio
        End Get
        Set(value As DataGridView)
            xdataGridAppoggio = value
        End Set
    End Property
    Public Function caricaDati() As Boolean
        'Procedura per calcolare i valori giornalieri delle presenze Remote
        Dim idCli As Integer
        idCli = idCantiere

        If dtPresenze.Rows.Count = 0 Then
            Return False
        End If
        Dim dtTipo As DataTable
        Using dt As New DS_utenti.DT_tipologiaDataTable
            Using ta As New DS_utentiTableAdapters.TA_tipologia
                ta.mostra(dt)
                dtTipo = dt
            End Using
        End Using

        Dim idConfronto As Integer
        'Imposta il confronto per Operatore
        idConfronto = rgDataRow.Item("id_utente")
        'Ottiene l'ultimo giorno del mese
        Dim kdat As DateTime = DateSerial(Anno, Mese + 1, 0)
        'Crea la tabella con le 31 celle più il nome della società
        Dim Cli As DataTable

        Cli = CreaDTTotali(dtPresenze) 'Crea una dataTable con i dati da inserire nella Tabella

        Dim DescTipo As String
        '
        ' Inizia a caricare la tabella delle presenze
        '

        Dim presenzeGrpDettaglioTipo =
            (From presenze In Cli.AsEnumerable
             Group presenze By
           id_det = presenze.Field(Of Integer)("id_det"),
           tipo = presenze.Field(Of Integer)("id_tipo")
           Into g = Group Select New With {
           Key id_det,
           tipo,
           .ore = g.Sum(Function(r) r.Field(Of Decimal)("ore"))
           }).OrderBy(Function(O) O.id_det).ThenBy(Function(U) U.tipo).ToList()
        Dim dtPresenzeGrpDettaglioTipo As DataTable = ConverteToDataTable(presenzeGrpDettaglioTipo)

        Dim presenzedettaglio =
            (From presenze In Cli.AsEnumerable
             Group presenze By
            id_cli = presenze.Field(Of Int32)("id_cli"),
            id_det = presenze.Field(Of Integer)("id_det"),
            tipo = presenze.Field(Of Integer)("id_tipo"),
            giorno = presenze.Field(Of Integer)("giorno"),
            anagrafica = presenze.Field(Of String)("anagrafica"),
            societa = presenze.Field(Of String)("societa"),
            dettaglio = presenze.Field(Of String)("dettaglio"),
            note = Trim(presenze.Field(Of String)("note")).ToLower(),
            auto = presenze.Field(Of Int32)("auto"),
            iddip = presenze.Field(Of Int32)("id_dip")
            Into g = Group
             Select New With {
            Key id_cli,
            id_det,
            tipo,
            giorno,
            anagrafica,
            societa,
            dettaglio,
            note,
            auto,
            iddip,
            .ore = g.Sum(Function(r) r.Field(Of Decimal)("ore"))
            }).OrderBy(Function(O) O.id_det).ThenBy(Function(U) U.tipo).ThenBy(Function(F) F.giorno).ThenBy(Function(R) R.anagrafica).ToList()


        Dim dtDettagliopresenze As DataTable = Cli.Clone() ' empty table with same columns

        For Each grp In presenzedettaglio
            dtDettagliopresenze.Rows.Add(0, grp.id_cli, grp.id_det, grp.iddip, "", grp.dettaglio, grp.anagrafica, grp.giorno, grp.ore, grp.note, grp.tipo, grp.auto)
        Next

        Dim TestoRiepilogo As String
        Dim DettaglioRiga As IList
        Dim Sommadettaglio As IList
        Dim oldTipo As Integer = dtPresenzeGrpDettaglioTipo.Rows(0).Field(Of Int32)("tipo")
        Dim oldidde As Integer = dtPresenzeGrpDettaglioTipo.Rows(0).Field(Of Int32)("id_det")
        Dim tpOre As Decimal = 0
        Dim iddet As Integer
        DescTipo = ""
        TestoRiepilogo = ""
        For Each dtt As DataRow In dtPresenzeGrpDettaglioTipo.Rows


            iddet = dtt.Field(Of Int32)("id_det")
            Dim idTipo As Int16
            idTipo = dtt.Field(Of Int32)("tipo")
            TestoRiepilogo = ""
            For Each rgTipo As DS_utenti.DT_tipologiaRow In dtTipo.Rows
                If rgTipo.id_tipo = idTipo Then
                    DescTipo = rgTipo.descrizione
                End If
            Next

            For Each rgTipo As DataRow In dtDettagliopresenze.Rows
                If rgTipo.Field(Of Integer)("id_det") = iddet Then
                    TestoRiepilogo = rgTipo.Field(Of String)("dettaglio")
                End If
            Next

            If oldidde <> iddet Then
                '
                'Colora tutta la riga
                '
                AssegnaValoriTabella(dataGridAppoggio, True, 0, "", "", 0, 0, 0, -1)

                For ddd = 0 To kdat.Day
                    AssegnaValoriTabella(dataGridAppoggio, False, ddd, 0, "", 0, 0, 0, -1)
                Next
                '
                'Fa il parziale
                '
                AssegnaValoriTabella(dataGridAppoggio, False, 0, "PARZ-" & TestoRiepilogo, "", oldidde, 0, 0, -1)
                Sommadettaglio = RielaboraPresenze(dtDettagliopresenze, oldidde)

                tpOre = 0
                For Each grp In Sommadettaglio
                    Dim pore As Decimal
                    'Dim ptipo As Int32
                    Dim pDet As Int32
                    Dim pgiorno As Int32 = grp.giorno
                    pore = grp.ore
                    'Console.WriteLine(grp.Key.giorno & " " & grp.Key.tipo)
                    pDet = grp.id_det
                    tpOre += pore
                    AssegnaValoriTabella(dataGridAppoggio, False, pgiorno, pore, "", oldidde, 0, 0, -1)
                Next
                AssegnaValoriTabella(dataGridAppoggio, False, kdat.Day + 1, tpOre, "", oldidde, 0, 0, -1)
                oldidde = iddet
            End If

            DettaglioRiga = RielaboraPresenze(Cli, iddet, idTipo)

            AssegnaValoriTabella(dataGridAppoggio, True, 0, TestoRiepilogo & "-" & DescTipo.Substring(0, 3), "", iddet, 0, 0, 0)
            tpOre = 0
            For Each grp In DettaglioRiga
                Dim pore As Decimal
                Dim pgiorno As Int32 = grp.giorno
                pore = grp.ore
                tpOre += grp.ore
                AssegnaValoriTabella(dataGridAppoggio, False, pgiorno, pore, "", 0, iddet, 0, 0, 0)
            Next
            AssegnaValoriTabella(dataGridAppoggio, False, kdat.Day + 1, tpOre, "", iddet, 0, 0, 0)

        Next

        AssegnaValoriTabella(dataGridAppoggio, True, 0, "", "", 0, 0, 0, -1, 0)

        For ddd = 0 To kdat.Day
            AssegnaValoriTabella(dataGridAppoggio, False, ddd, 0, "", 0, 0, 0, 0, -1)
        Next
        '
        'Fa il parziale
        '
        AssegnaValoriTabella(dataGridAppoggio, False, 0, "PARZ-" & TestoRiepilogo, "", 0, 0, oldTipo, 0, -1)
        Sommadettaglio = RielaboraPresenze(dtDettagliopresenze, oldidde)

        tpOre = 0
        For Each grp In Sommadettaglio
            Dim pore As Decimal
            'Dim ptipo As Int32
            Dim pDet As Int32
            Dim pgiorno As Int32 = grp.giorno
            pore = grp.ore
            'Console.WriteLine(grp.Key.giorno & " " & grp.Key.tipo)
            pDet = grp.id_det
            tpOre += pore
            AssegnaValoriTabella(dataGridAppoggio, False, pgiorno, pore, "", iddet, 0, 0, -1)
        Next
        AssegnaValoriTabella(dataGridAppoggio, False, kdat.Day + 1, tpOre, "", iddet, 0, 0, -1)




        '
        'Calcola i le somme totali e le inserisce in ultima riga dellatabella DG_totaleOreWeb
        '
        AssegnaValoriTabella(dataGridAppoggio, True, 0, "", "", 0, 0, 0, -2)
        For ddd = 0 To kdat.Day
            AssegnaValoriTabella(dataGridAppoggio, False, ddd, "", "", 0, 0, 0, -2)
        Next
        AssegnaValoriTabella(dataGridAppoggio, False, 0, "TOTALE" & TestoRiepilogo, "", 0, 0, oldTipo, -2)


        Sommadettaglio = RielaboraPresenze(dtDettagliopresenze)
        Dim tgOre As Decimal
        For Each grp In Sommadettaglio
            Dim pore As Decimal
            Dim pgiorno As Int32
            pgiorno = grp.giorno
            pore = grp.ore
            tgOre += pore
            AssegnaValoriTabella(dataGridAppoggio, False, pgiorno, pore, "", 0, 0, 0, -2)
        Next
        AssegnaValoriTabella(dataGridAppoggio, False, kdat.Day + 1, tgOre, "", 0, 0, 0, -2)
        Return True
    End Function
    Private Shared Function RielaboraPresenze(ByRef Lista As DataTable, Optional idconfronto As Integer = Nothing, Optional idtipo As Integer = Nothing) As IList
        Select Case True
            Case IsNothing(idconfronto) Or idconfronto = 0
                RielaboraPresenze = (From presenze In Lista.AsEnumerable
                                     Group presenze By
                          giorno = presenze.Field(Of Integer)("giorno")
                      Into g = Group
                                     Select New With {
                            giorno,
                            .ore = g.Sum(Function(r) r.Field(Of Decimal)("ore"))
                       }).ToList()

            Case IsNothing(idtipo) Or idtipo = 0
                RielaboraPresenze = (From presenze In Lista.AsEnumerable
                                     Group presenze By
                          id_det = presenze.Field(Of Integer)("id_det"),
                          giorno = presenze.Field(Of Integer)("giorno")
                      Into g = Group
                                     Select New With {
                            Key id_det,
                            giorno,
                            .ore = g.Sum(Function(r) r.Field(Of Decimal)("ore"))
                       }).Where(Function(W) W.id_det = idconfronto).ToList()
            Case Else

                RielaboraPresenze = (From presenze In Lista.AsEnumerable
                                     Group presenze By
                        id_det = presenze.Field(Of Integer)("id_det"),
                        id_tipo = presenze.Field(Of Integer)("id_tipo"),
                        giorno = presenze.Field(Of Integer)("giorno")
                    Into g = Group
                                     Select New With {
                            Key id_det,
                            id_tipo,
                            giorno,
                            .ore = g.Sum(Function(r) r.Field(Of Decimal)("ore"))
                       }).Where(Function(W) W.id_det = idconfronto And W.id_tipo = idtipo).ToList()


        End Select

        Return RielaboraPresenze
    End Function
    Private Shared Function AssegnaValoriTabella(ByRef TMPDG As DataGridView, ByVal Nuova As Boolean, ByVal Colonna As Int32,
                                                 ByVal Valore As Object, ByVal Valore1 As Object, ByVal festivo As Int16,
                                                 Optional ByVal ID1 As Int32 = Nothing,
                                                 Optional ByVal ID2 As Int32 = Nothing, Optional ByVal ID3 As Int32 = Nothing,
                                                 Optional ByVal auto As Int32 = 0)
        'TMPDG è la griglia alla quale assegnare i valori
        'Nuova:     indica se deve aggiungere una nuova riga
        'Colonna:
        ''Datagrid delle presenze sia Remote che locali

        Dim dw As String() = New String() {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
        Dim cc As ColoriDettaglio = New ColoriDettaglio()

        If Nuova = True Then
            TMPDG.Rows.Add()
        End If

        Dim ultimariga As Integer
        ultimariga = TMPDG.Rows.Count - 1

        Dim CSfondo As Color = TMPDG(Colonna, ultimariga).Style.BackColor
        Dim CScritta As Color = TMPDG(Colonna, ultimariga).Style.ForeColor
        Dim StileAllineamento As DataGridViewContentAlignment = TMPDG(Colonna, ultimariga).Style.Alignment
        Dim StileCarattere As Font = New Font("Arial", 8, FontStyle.Regular)
        Dim NTag As Integer = 0
        Dim SToolTips As String = ""

        Select Case True
            Case ID1 > 0 '(Cliente)
                NTag = ID1
            Case ID2 > 0 '(Dipendente)
                NTag = ID2
        End Select

        Dim ValoreConvertibile As IConvertible = TryCast(Valore, IConvertible)
        Dim strValore As String = ""
        Select Case ValoreConvertibile.GetTypeCode()
            Case TypeCode.Decimal
                If auto < 0 Then
                    StileCarattere = New Font("Arial", 8, FontStyle.Regular)
                Else
                    StileCarattere = New Font("Arial", 8, FontStyle.Regular)
                End If
                StileAllineamento = DataGridViewContentAlignment.MiddleRight
                strValore = Format(Valore, "#0.00#")
            Case TypeCode.String
                strValore = Valore
                StileAllineamento = DataGridViewContentAlignment.MiddleLeft
                StileCarattere = New Font("Arial", 8, FontStyle.Regular)
        End Select


        Dim strValore1 As String = CType(Valore1, String)

        TMPDG(Colonna, ultimariga).Tag = NTag
        TMPDG(Colonna, ultimariga).Value = strValore
        If Colonna > 0 Then
            Select Case True
                Case auto = 3

                Case auto = 1 And ID3 = 2                   ' Se è inviato ed è assente
                    CSfondo = cc.XTrAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AA"
                    TMPDG(Colonna, ultimariga).ToolTipText = strValore
                Case auto = 1 And strValore1.Length > 0 And ID3 = 2 ' Se è con nota ed è stato inviato ed è assente
                    CSfondo = cc.XTrNoteAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AN"
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips

                Case auto = 1 And strValore1.Length > 0     ' Se è presente una nota ed è stato inviato
                    SToolTips = "inviato " & Valore1
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                    CSfondo = cc.XTrNote
                    CScritta = Color.White
                Case auto = 1                               ' se è stato solo inviato
                    CSfondo = cc.XTraPres
                    CScritta = Color.White
                    '
                    'Qui iniziano a delinearsi gli inserimenti non inviati
                    '
                Case auto = 0 And strValore1.Length > 0 And ID3 = 2 ' note e assente
                    CSfondo = cc.NorNoteAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AN"
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                Case auto = 0 And ID3 = 2 ' assente
                    CSfondo = cc.NorAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AA"
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips

                Case auto = 0 And strValore1.Length > 0
                    SToolTips = Valore1
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                    'TMPDG(Colonna, ultimariga).Value = "" & strValore
                    CSfondo = cc.NorNote
                    CScritta = Color.White
                Case auto = -1 ' Note
                    SToolTips = Valore1
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                    'TMPDG(Colonna, ultimariga).Value = strValore
                    CSfondo = ColoriDettaglio.Parziale
                    CScritta = Color.Black
                Case auto = -2
                    SToolTips = Valore1
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                    'TMPDG(Colonna, ultimariga).Value = strValore
                    CSfondo = ColoriDettaglio.Totale
                    CScritta = Color.Black
                Case Else

            End Select
            If festivo = 1 Then
                TMPDG(Colonna, ultimariga).Style.BackColor = Color.CadetBlue
            End If
        End If

        TMPDG(Colonna, ultimariga).Style.ForeColor = CScritta
        TMPDG(Colonna, ultimariga).Style.BackColor = CSfondo
        TMPDG(Colonna, ultimariga).Style.Font = StileCarattere
        TMPDG(Colonna, ultimariga).Style.Alignment = StileAllineamento
        Return True
    End Function
    Private Shared Function ConverteToDataTable(Of T)(list As IList(Of T)) As DataTable
        Dim entityType As Type = GetType(T)
        Dim table As New DataTable()
        Dim properties As PropertyDescriptorCollection = TypeDescriptor.GetProperties(entityType)
        For Each prop As PropertyDescriptor In properties
            table.Columns.Add(prop.Name, If(Nullable.GetUnderlyingType(prop.PropertyType), prop.PropertyType))
        Next
        For Each item As T In list
            Dim row As DataRow = table.NewRow()
            For Each prop As PropertyDescriptor In properties
                row(prop.Name) = If(prop.GetValue(item), DBNull.Value)
            Next
            table.Rows.Add(row)
        Next
        Return table
    End Function

    <CodeAnalysis.SuppressMessage("Design", "CA1062:Convalidare gli argomenti di metodi pubblici", Justification:="<In sospeso>")>
    Public Function CreaDTTotali(ByRef BStmp As DataTable) As DataTable
        Dim Cli
        Cli = New DataTable
        Cli.Namespace = "TabellaClienti"
        Dim CliRow As DataRow
        Dim colonna As DataColumn
        colonna = New DataColumn
        colonna.ColumnName = "id"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_cli"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_det"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_dip"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "societa"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dettaglio"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "anagrafica"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "giorno"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "ore"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "note"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_tipo"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "auto"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)

        Dim RGweb As DS_clienti.DT_presenzeWEBRow
        Dim RGloc As DS_clienti.DT_contoreRow
        If Not IsDBNull(BStmp) Then
            For Each hg In BStmp.Rows
                CliRow = Cli.NewRow
                If remota Then
                    RGweb = DirectCast(hg, DS_clienti.DT_presenzeWEBRow)
                    CliRow("id") = RGweb.id
                    CliRow("id_cli") = RGweb.Item("id_terminale")
                    CliRow("id_det") = RGweb.Item("id_locazione")
                    CliRow("id_dip") = RGweb.Item("id_utente")
                    CliRow("dettaglio") = RGweb.Item("locazione")
                    CliRow("societa") = RGweb.Item("societa")
                    CliRow("anagrafica") = RGweb.Item("anagrafica")
                    CliRow("giorno") = RGweb.Item("giorno").Day
                    Dim Ore As New TimeSpan
                    If RGweb.orario = " " Or RGweb.orario.ToString = "01-01-1900 00:00:00" Then
                        RGweb.Item("orario") = 0
                    End If
                    Ore = TimeSpan.Parse(RGweb.Item("orario").ToString)
                    CliRow("ore") = Ore.TotalHours
                    CliRow("note") = RGweb.Item("note")
                    CliRow("id_tipo") = RGweb.Item("inviato")
                    CliRow("auto") = RGweb.Item("auto")
                    Cli.Rows.Add(CliRow)
                ElseIf reale Then
                    RGloc = DirectCast(hg, DS_clienti.DT_contoreRow)
                    CliRow("id") = RGloc.Item("id")
                    CliRow("id_cli") = RGloc.id_cli
                    CliRow("id_det") = RGloc.id_dest
                    CliRow("id_dip") = RGloc.id_dip
                    CliRow("societa") = RGloc.locazione
                    CliRow("anagrafica") = RGloc.anagrafica
                    CliRow("dettaglio") = RGloc.locazione
                    CliRow("giorno") = RGloc.data.Day
                    CliRow("ore") = RGloc.ore
                    CliRow("note") = RGloc.note
                    CliRow("id_tipo") = RGloc.id_tipo
                    'Mette a 0 il fatto che sono state trasferiti i dati
                    CliRow("auto") = 0

                    Cli.Rows.Add(CliRow)
                End If
            Next

        End If
        Return Cli
    End Function
    Private Shared Function OrdinaTabella(ByVal tabella As DataTable,
                                   ByVal Campo As String) As DataTable
        Dim view As DataView = tabella.DefaultView
        view.Sort = Campo
        Return view.ToTable()
    End Function
    Private Shared Function ControllaOre(ByVal ora As Decimal, ByVal tipo As Int32) As Decimal
        If tipo <> 2 Then
            Return ora
        Else
            Console.WriteLine(ora)
            Return 0
        End If

    End Function


End Class
Public Class creaTabelladaDataTable
    Private xDatagridPresenze As DataGridView
    Private xdimFontCella As Integer = 10
    Private xDT As DataTable
    Private xDTcol() As String

    Public Property dataGridPresenze As DataGridView
        Get
            Return xDatagridPresenze
        End Get
        Set(value As DataGridView)
            xDatagridPresenze = value
        End Set
    End Property
    Public Property dimFontCella As Integer
        Get
            Return xdimFontCella
        End Get
        Set(value As Integer)
            xdimFontCella = value
        End Set
    End Property
    Public Property datatable As DataTable
        Get
            Return xDT
        End Get
        Set(value As DataTable)
            xDT = value
        End Set
    End Property
    <CodeAnalysis.SuppressMessage("Performance", "CA1819:Le proprietà non devono restituire matrici", Justification:="<In sospeso>")>
    Public Property ColCollection() As String()
        Get
            Return xDTcol
        End Get
        Set(value() As String)
            xDTcol = value
        End Set
    End Property

    Public Function Crea() As Boolean
        If IsNothing(datatable) Then
            Return False
        End If
        If IsNothing(ColCollection) Then
            Return False
        End If
        If Not IsNothing(dataGridPresenze) Then
            dataGridPresenze.Columns.Clear()
        End If

        For Each campi As DataColumn In datatable.Columns
            If ColCollection.Contains(campi.ColumnName) Then
                Dim CelName As String
                CelName = "DGWC" & campi.ColumnName
                Dim DGCol As DataGridViewRolloverCellColumn
                DGCol = CType(dataGridPresenze.Columns(CelName), DataGridViewRolloverCellColumn)
                Dim col As New DataGridViewRolloverCellColumn()
                With col
                    .HeaderText = campi.ColumnName
                    '.Width = larghezzacella * 4
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                    .DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
                    .Name = CelName
                End With
                If Not IsNothing(dataGridPresenze) Then
                    dataGridPresenze.Columns.Add(col)
                End If
            End If
        Next

        Return True
    End Function


End Class
Public Class funzioni
#Disable Warning CA1822 ' Contrassegnare i membri come static
    Public Function Ctrlval(ByRef rr As DataRow, ByRef cc As String) As Object
#Enable Warning CA1822 ' Contrassegnare i membri come static
        If rr.IsNull(cc) Then
            Return Nothing
        Else
            Return rr.Item(cc)
        End If
    End Function

#Disable Warning CA1822 ' Contrassegnare i membri come static
    Public Sub AutofatturaXML(ByVal dati_trasm As DataRow, ByVal dati_prest As DataRow, ByVal dati_cessa As DataRow,
                              ByVal dati_fattura As DataTable, ByVal dati_riga_fattura As EnumerableRowCollection, dati_iva As DataTable, dtRigheFatturaAuto As DS_FE.dtFatturaRigheAutofatturaDataTable, ByVal dati_paga As DataTable, ByVal percorso As String, ByVal tipoFattura As String)
#Enable Warning CA1822 ' Contrassegnare i membri come static
        ' dati trasmittente,prestatore (il fornitore Estero),cessionario (l'azienda PEGAO), Fattura , riga fattura

        Dim f As New funzioni
        Dim dtras As DS_FE.DT_trasmittenteRow = dati_trasm  'Colui che trasmette (Aliquid)
        Dim dpres As DS_FE.DT_aziendaRow = dati_prest  ' Colui che fa la fattura (Fornitore estero)
        Dim dcess As DS_FE.DT_aziendaRow = dati_cessa  ' Colui a cui viene fatta la fattura (Pegaso)
        'Dim dFatt As DS_FE.dtFatturaAutofatturaDataTable = dati_fattura ' Dati della fattura
        'Dim drFat As DS_FE.dtFatturaRigheAutofatturaDataTable
        Dim dIva As DS_fattura.DT_ivaDataTable = dati_iva
        Dim dPag As DS_fattura.DT_pagamentiDataTable = dati_paga
        Dim id_cessionario As String    ' identificativo cessionario
        Dim Progressivo As Integer


        Dim FatturaGroup As Object
        FatturaGroup = (From c As DS_FE.dtFatturaAutofatturaRow In dati_fattura
                        Join s In dPag On s.id Equals c.fat_cod_paga
                        Where s.id = c.fat_cod_paga
                        Select c.fat_num_da, s.modalitaFE, c.fat_cod_paga, s.des, c.fat_pa_dat, c.fat_paga,
                            c.fat_data, c.fat_scad, c.fat_pa_des).ToList()

        'Dim s_prog As Object = dFatt.First.fat_num_da.Split("/").First
        'Dim dataFattura As DateTime = dFatt.First.fat_data
        Dim rFattura As DS_FE.dtFatturaAutofatturaRow
        Dim dFattura As DataTable
        dFattura = dati_fattura.Clone
        dFattura.Columns.Add("modalitaFE", Type.GetType("System.String"))
        dFattura.Columns.Add("desPagamento", Type.GetType("System.String"))
        For Each tmp In FatturaGroup
            rFattura = dFattura.NewRow
            rFattura.fat_num_da = tmp.fat_num_da
            rFattura("modalitaFE") = tmp.modalitaFE
            rFattura("desPagamento") = tmp.des
            rFattura.fat_cod_paga = tmp.fat_cod_paga
            rFattura.fat_pa_dat = tmp.fat_pa_dat
            Try
                rFattura.fat_pa_des = tmp.fat_pa_des
            Catch ex As Exception
                rFattura.fat_pa_des = ""
            End Try
            rFattura.fat_paga = tmp.fat_paga
            rFattura.fat_data = tmp.fat_data
            rFattura.fat_scad = tmp.fat_scad
            dFattura.Rows.Add(rFattura)
            rFattura.AcceptChanges()
        Next
        Dim sNum As String
        sNum = dFattura(0).Item("fat_num_da").ToString().Split("/").First
        sNum = sNum.Substring(1, sNum.Length - 1)
        Progressivo = CType(sNum, Integer)

        'inizio creazione
        Dim nodoPrincipale As New FatturaElettronica()
        Dim overviewIntestazione As New FatturaElettronicaHeader()
        Dim datiTrasmissione As New DatiTrasmissione()
        Dim idTrasmittente As New IdTrasmittente()

        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        idTrasmittente.IdPaese = dtras("idPaese")
        idTrasmittente.IdCodice = dcess("partita_IVA")
        datiTrasmissione.IdTrasmittente = idTrasmittente

        datiTrasmissione.ProgressivoInvio = Progressivo.ToString.PadLeft(6, "0") ' inserire il numero progressivo di trasmissione
        'Il cessionario è Pegaso
        datiTrasmissione.FormatoTrasmissione = "FPR12"  'codice FPR12 per Privati e FPA12 per PA

        'identifica se è presente il codice destinatario o la pec
        id_cessionario = dcess.idSDI

        datiTrasmissione.CodiceDestinatario = id_cessionario

        Dim ContattiTrasmittente As New ContattiTrasmittente()
        ContattiTrasmittente.Telefono = dtras.Telefono
        ContattiTrasmittente.Email = dtras.Email
        datiTrasmissione.ContattiTrasmittente = ContattiTrasmittente
        'Scrivi XML
        overviewIntestazione.DatiTrasmissione = datiTrasmissione
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ' Blocco 1.2 Cedente Prestatore
        Dim cedentePrestatore As New CedentePrestatore()
        Dim datiAnagrafici As New DatiAnagrafici()
        '   Blocco 1.2.1
        Dim idFiscaleIVA As New IdFiscaleIVA()
        idFiscaleIVA.IdPaese = dpres("Nazione").Substring(0, 2).ToUpper
        idFiscaleIVA.IdCodice = dpres("partita_IVA")
        datiAnagrafici.IdFiscaleIVA = idFiscaleIVA
        '       Blocco 1.2.1.3
        Dim anagrafica As New Anagrafica()

        anagrafica.Denominazione = dpres("ragione_sociale")

        datiAnagrafici.Anagrafica = anagrafica
        datiAnagrafici.RegimeFiscale = "RF01" ' RF01 ordinario / RF18 Altro
        '
        cedentePrestatore.DatiAnagrafici = datiAnagrafici
        '   Blocco 1.2.2
        Dim sede As New Sede()
        sede.Indirizzo = Split(dpres("indirizzo_leg"), ",").First
        sede.NumeroCivico = Split(dpres("indirizzo_leg"), ",").Last
        sede.CAP = dpres("cap_leg")
        sede.Comune = dpres("localita_leg")
        sede.Provincia = dpres("provincia_leg").ToUpper.Substring(0, 2)
        sede.Nazione = dpres("Nazione").ToUpper.Substring(0, 2).ToUpper
        '
        cedentePrestatore.Sede = sede
        'Scrivi XML

        overviewIntestazione.CedentePrestatore = cedentePrestatore
        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        'Blocco 1.4 Cessionaria Committente

        Dim cessionarioCommittente As New CessionarioCommittente()
        '   Blocco 1.4.1 Dati anagrafici CESSIONARIO (Cliente)
        Dim datiAnagraficiCommittente As New DatiAnagrafici()
        '       Blocco 1.4.1.1
        'se è un condominio o se è una onlus o altro, non crea la riga IVA
        Dim datiRitenuta As New DatiRitenuta()


        idFiscaleIVA = New IdFiscaleIVA()
        idFiscaleIVA.IdPaese = "IT"
        idFiscaleIVA.IdCodice = dcess.partita_IVA
        datiAnagraficiCommittente.IdFiscaleIVA = idFiscaleIVA
        datiAnagraficiCommittente.CodiceFiscale = dcess.codicefiscale

        Dim anagraficaCommittente As New Anagrafica()
        anagraficaCommittente.Denominazione = dcess.ragione_sociale
        datiAnagraficiCommittente.Anagrafica = anagraficaCommittente
        cessionarioCommittente.DatiAnagrafici = datiAnagraficiCommittente

        'Blocco 1.4.2
        Dim sedeCommittente As New Sede()
        sedeCommittente.Indirizzo = dcess.indirizzo_leg

        sedeCommittente.CAP = dcess.cap_leg
        sedeCommittente.Comune = dcess.localita_leg
        sedeCommittente.Provincia = dcess.provincia_leg
        sedeCommittente.Nazione = dcess.Nazione
        cessionarioCommittente.Sede = sedeCommittente

        ''Scrivi XML
        overviewIntestazione.CessionarioCommittente = cessionarioCommittente
        overviewIntestazione.SoggettoEmittente = "CC"   ' cessionario / committente
        ''@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
        ''apre il blocco 2   Corpo Fattura
        Dim overviewCorpo As New FatturaElettronicaBody()
        '' il blocco 2.1 è stato spostato più avanti per poter inserire il totale documento

        ''@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ò   Cicla con Distinzione per codici IVA
        ''Blocco 2.2 DatiBeniServizi
        Dim datiBeniServizi As New DatiBeniServizi()
        Dim totalePagamento As Decimal = 0
        Dim TotaleRitenuta As Decimal = 0
        Dim RigheFatturaGroup As Object

        RigheFatturaGroup = (From c As DS_FE.dtFatturaRigheAutofatturaRow In dati_riga_fattura
                             Join s In dIva On s.codiceiva Equals c.cfa_rc
                             Group s.valoreiva, s.descrizione, s.pagata, s.cod_FE, c.cfa_des, c.cfa_rc, c.cfa_quanti, c.cfa_prezzo, c.cfa_sconto By c.cfa_rc Into righeFattura = Group).ToList()


        Dim dtRighe As DataTable = New DataTable
        dtRighe = dtRigheFatturaAuto.Clone()
        Dim rgRighe As DS_FE.dtFatturaRigheAutofatturaRow
        dtRighe.Columns.Add("totale", System.Type.GetType("System.Decimal"))
        dtRighe.Columns.Add("imposta", System.Type.GetType("System.Decimal"))
        dtRighe.Columns.Add("scontato", System.Type.GetType("System.Decimal"))
        dtRighe.Columns.Add("descrizione", System.Type.GetType("System.String"))
        dtRighe.Columns.Add("totaleperIVA", System.Type.GetType("System.Decimal"))
        dtRighe.Columns.Add("impostaperIVA", System.Type.GetType("System.Decimal"))
        dtRighe.Columns.Add("cod_FE", System.Type.GetType("System.String"))
        Dim n As Int16
        Dim codIVA As Integer()
        For Each righepertipoIVA In RigheFatturaGroup
            Dim totRighe As Decimal = 0
            Dim totSconto As Decimal = 0
            Dim totImpos As Decimal = 0
            Dim valoreIVA As Decimal = 0
            Dim desIva As String = ""
            Dim tipoIva As Integer
            Dim codFE As String = ""
            codIVA.Add(righepertipoIVA.cfa_rc)

            For Each rigaFattura In righepertipoIVA.righeFattura
                rgRighe = dtRighe.NewRow
                n += 1
                rgRighe.id = n
                rgRighe.cfa_des = rigaFattura.cfa_des
                rgRighe.cfa_prezzo = rigaFattura.cfa_prezzo
                rgRighe.cfa_quanti = rigaFattura.cfa_quanti
                rgRighe.cfa_sconto = rigaFattura.cfa_sconto
                rgRighe.cfa_rc = rigaFattura.cfa_rc
                tipoIva = rigaFattura.cfa_rc
                rgRighe.cfa_iva = rigaFattura.valoreiva
                rgRighe("cod_FE") = rigaFattura.cod_FE
                rgRighe("totale") = rigaFattura.cfa_prezzo * rigaFattura.cfa_quanti
                rgRighe("scontato") = (rgRighe("totale")) * rigaFattura.cfa_sconto / 100
                rgRighe("imposta") = (rgRighe("totale") - rgRighe("scontato")) * rigaFattura.valoreiva / 100

                totRighe += rgRighe("totale")
                totSconto += rgRighe("totale") - rgRighe("scontato")
                totImpos += rgRighe("imposta")

                valoreIVA = rigaFattura.valoreiva
                codFE = rigaFattura.cod_FE
                desIva = rigaFattura.descrizione
                dtRighe.Rows.Add(rgRighe)
                rgRighe.AcceptChanges()
            Next
            rgRighe = dtRighe.NewRow
            n += 1
            rgRighe.id = n
            rgRighe("cod_FE") = codFE
            rgRighe.cfa_rc = -1 * righepertipoIVA.cfa_rc
            rgRighe.cfa_des = "Totale per " & desIva
            rgRighe("totale") = totRighe
            rgRighe("imposta") = totImpos
            rgRighe("scontato") = totSconto
            rgRighe("descrizione") = desIva
            rgRighe("cfa_iva") = valoreIVA
            dtRighe.Rows.Add(rgRighe)
            rgRighe.AcceptChanges()
        Next

        For Each rF As DS_FE.dtFatturaRigheAutofatturaRow In dtRighe.Rows

            Console.WriteLine(rF.id & vbTab & rF.cfa_des & vbTab & rF("totale") & vbTab & rF("imposta") & vbTab & vbTab & rF("impostaperIVA"))

        Next
        Dim listaLinee As New List(Of DettaglioLinee)()
        Dim nRiga As Int16
        If codIVA.Length = 0 Then
            MsgBox("Attenzione non sono presenti righe nella fattura")
            Return
        End If
        For Each rg_IVA In codIVA
            For Each det_righe In dtRighe.Rows  'scorre le righe che soddisfano lo stesso criterio di codice iva
                If det_righe.cfa_rc = rg_IVA Then
                    'Blocco 2.2.1
                    nRiga += 1
                    Dim dettaglioLinee As New DettaglioLinee()
                    dettaglioLinee.NumeroLinea = nRiga
                    dettaglioLinee.Descrizione = det_righe.cfa_des
                    dettaglioLinee.Quantita = ControllaeFormattaNumeri(det_righe.cfa_quanti)
                    dettaglioLinee.PrezzoUnitario = ControllaeFormattaNumeri(det_righe.cfa_prezzo)
                    'se è presente uno sconto, valorizza questi campi

                    If det_righe.cfa_sconto <> 0 Then
                        Dim scontoemaggiorazione As New ScontoMaggiorazione
                        scontoemaggiorazione.Percentuale = ControllaeFormattaNumeri(det_righe.cfa_sconto)
                        scontoemaggiorazione.Tipo = "SC"
                        'imposta l'importo dello sconto
                        'scontoemaggiorazione.Importo = ControllaeFormattaNumeri(det_righe("scontato"))
                        dettaglioLinee.ScontoMaggiorazione = scontoemaggiorazione

                    End If
                    dettaglioLinee.PrezzoTotale = ControllaeFormattaNumeri(det_righe("totale") - det_righe("scontato"))
                    If det_righe("cod_FE").Trim.Length <> 0 Then
                        If det_righe("cod_FE") = "S" Then
                            dettaglioLinee.Natura = "" 'impostare N6 se reverse Charge
                        Else
                            dettaglioLinee.Natura = det_righe("cod_FE")
                        End If
                    End If
                    dettaglioLinee.AliquotaIVA = ControllaeFormattaNumeri(det_righe.cfa_iva)
                    listaLinee.Add(dettaglioLinee)
                End If
            Next
        Next

        datiBeniServizi.DettaglioLinee = listaLinee


        '        '@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ò   
        '        'Blocco 2.2.2 riepilogo per tipo di IVA
        Dim listaRiepilogo As New List(Of DatiRiepilogo)()

        Dim nemesirg_IVA As Int16
        For Each rg_IVA As Integer In codIVA
            nemesirg_IVA = -1 * rg_IVA
            Dim datiRiepilogo As New DatiRiepilogo()
            For Each det_righe In dtRighe.Rows  'scorre le righe che soddisfano lo stesso criterio di codice iva
                If det_righe.cfa_rc = nemesirg_IVA Then
                    Select Case det_righe("cod_FE")
                        Case "S"    'se è previsto lo split payement
                            datiRiepilogo.EsigibilitaIVA = "S"
                            datiRiepilogo.RiferimentoNormativo = det_righe("descrizione")
                            totalePagamento = totalePagamento + det_righe("scontato")
                        Case "N6.7"   'se è solo reverse charge
                            datiRiepilogo.EsigibilitaIVA = "I"
                            datiRiepilogo.Natura = det_righe("cod_FE") 'impostare N6 se reverse Charge
                            datiRiepilogo.RiferimentoNormativo = det_righe("descrizione")
                            totalePagamento = totalePagamento + det_righe("scontato") + det_righe("imposta")
                        Case "N4"
                            datiRiepilogo.EsigibilitaIVA = "I"
                            datiRiepilogo.Natura = det_righe("cod_FE") 'impostare N6 se reverse Charge
                            datiRiepilogo.RiferimentoNormativo = det_righe("descrizione")
                            totalePagamento = totalePagamento + det_righe("scontato") + det_righe("imposta")
                        Case "N1"
                            datiRiepilogo.EsigibilitaIVA = "I"
                            datiRiepilogo.Natura = det_righe("cod_FE") 'impostare N6 se reverse Charge
                            datiRiepilogo.RiferimentoNormativo = det_righe("descrizione")
                            totalePagamento = totalePagamento + det_righe("scontato") + det_righe("imposta")
                        Case Else
                            datiRiepilogo.EsigibilitaIVA = "I"
                            datiRiepilogo.RiferimentoNormativo = det_righe("descrizione")
                            totalePagamento = totalePagamento + det_righe("scontato") + det_righe("imposta")
                    End Select

                    datiRiepilogo.ImponibileImporto = ControllaeFormattaNumeri(det_righe("scontato"))
                    datiRiepilogo.Imposta = ControllaeFormattaNumeri(det_righe("imposta"))
                    datiRiepilogo.AliquotaIVA = ControllaeFormattaNumeri(det_righe("cfa_iva"))
                    listaRiepilogo.Add(datiRiepilogo)
                    '            'chiude il nodo beni e servizi

                End If
            Next

        Next
        datiBeniServizi.DatiRiepilogo = listaRiepilogo
        overviewCorpo.DatiBeniServizi = datiBeniServizi

        ''Dati generali inserito ora per poter avere il totale pagamento
        Dim datiGenerali As New DatiGenerali()
        ''Blocco 2.1.1

        Dim datiGeneraliDocumento As New DatiGeneraliDocumento()
        datiGeneraliDocumento.TipoDocumento = tipoFattura    'TD01 Fattura / TD04 Nota di credito
        datiGeneraliDocumento.ImportoTotaleDocumento = ControllaeFormattaNumeri(totalePagamento)
        datiGeneraliDocumento.Divisa = "EUR"


        Dim tmData As DateTime = DateTime.Parse(dFattura(0).Item("fat_data").ToString())
        datiGeneraliDocumento.Data = tmData.ToString("yyyy-MM-dd")



        datiGeneraliDocumento.Numero = dFattura(0).Item("fat_num_da")

        datiGenerali.DatiGeneraliDocumento = datiGeneraliDocumento
        overviewCorpo.DatiGenerali = datiGenerali

        ''@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ se si utilizza il contratto pubblico con numero CIG

        ''Blocco 2.4 Pagamento
        Dim datipagamento As New DatiPagamento
        datipagamento.CondizioniPagamento = "TP02"
        Dim dettaglipagamento As New DettaglioPagamento
        'dettaglipagamento.ABI = ""
        ''dettaglipagamento.CAB = ""
        ''dettaglipagamento.BIC = ""
        'Dim banca As String = dcess.bancaappog.Replace(".", "").Replace(" ", "").Replace("IBAN", "").TrimEnd
        'If banca.Length() <> 27 And banca.Length() > 0 Then
        '    MsgBox("Verificare codice IBAN " & Chr(13) &
        '        " " & banca & Chr(13) &
        '           "per il cliente " & Chr(13) &
        '           dcess.societa & " la fattura non verrà creata")
        '    Return
        'ElseIf banca.Length = 27 Then
        '    dettaglipagamento.IBAN = banca
        '    'Dettaglio da quando decorrono i termini di pagamento
        'ElseIf banca.Length = 0 Then

        'End If

        tmData = DateTime.Parse(dFattura(0).Item("fat_pa_dat").ToString())
        dettaglipagamento.DataRiferimentoTerminiPagamento = tmData.ToString("yyyy-MM-dd")
        '' Termine del pagamento
        tmData = DateTime.Parse(dFattura(0).Item("fat_scad").ToString())
        dettaglipagamento.DataScadenzaPagamento = tmData.ToString("yyyy-MM-dd")
        dettaglipagamento.ImportoPagamento = ControllaeFormattaNumeri(totalePagamento)
        datipagamento.DettaglioPagamento = dettaglipagamento
        dettaglipagamento.Beneficiario = dpres.ragione_sociale
        dettaglipagamento.ModalitaPagamento = dFattura(0).Item("modalitaFE") 'imposta il tipo di pagamento
        ''@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Chiude i Pagamenti
        overviewCorpo.DatiPagamento = datipagamento

        Dim Datiintermediario As New TerzoIntermediarioOSoggettoEmittente
        datiAnagrafici = New DatiAnagrafici
        anagrafica = New Anagrafica()
        idFiscaleIVA = New IdFiscaleIVA
        anagrafica.Denominazione = dtras.Nominativo
        datiAnagrafici.Anagrafica = anagrafica
        idFiscaleIVA.IdCodice = dtras.idCodice
        idFiscaleIVA.IdPaese = dtras.idPaese
        datiAnagrafici.IdFiscaleIVA = idFiscaleIVA
        Datiintermediario.DatiAnagrafici = datiAnagrafici
        ''@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Dati intermediario che invia la fattura

        nodoPrincipale.FatturaElettronicaHeader = overviewIntestazione
        nodoPrincipale.FatturaElettronicaBody = overviewCorpo
        ''@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ Chiude il nodo Fattura
        ''Scrivi XML

        Dim XmlRoot As New XmlRootAttribute()
        XmlRoot.Namespace = "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2"
        Dim myxmlAttribute As XmlAttributes = New XmlAttributes
        myxmlAttribute.XmlRoot = XmlRoot
        Dim xmlAttributeOverrides As XmlAttributeOverrides = New XmlAttributeOverrides
        xmlAttributeOverrides.Add(GetType(FatturaElettronica), myxmlAttribute)
        '' in case you want to remove prefix from members
        Dim emptyNsAttribute As New XmlAttributes()
        Dim xElementoVuoto As New XmlElementAttribute()
        xElementoVuoto.Namespace = ""
        emptyNsAttribute.XmlElements.Add(xElementoVuoto)
        xmlAttributeOverrides.Add(GetType(FatturaElettronica), "FatturaElettronicaHeader", emptyNsAttribute)
        xmlAttributeOverrides.Add(GetType(FatturaElettronica), "FatturaElettronicaBody", emptyNsAttribute)
        '' if you actual library type contains more members, then you have to list all of them
        nodoPrincipale.versione = "FPR12"
        Dim ser As New XmlSerializer(nodoPrincipale.[GetType](), xmlAttributeOverrides)
        Dim ns As New XmlSerializerNamespaces()
        ns.Add("ds", "http://www.w3.org/2000/09/xmldsig#")

        ns.Add("p", "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2")
        ns.Add("xis", "http://www.w3.org/2001/XMLSchema-instance")

        'crea il nome del file con IT _ numero ID trasmittente _ numero progressivo e lo salva dove hai deciso di memorizzare le informazioni
        Dim NomeFile As String = "AF" & dcess.partita_IVA.Replace(".", "") & "_" & Progressivo.ToString.PadLeft(5, "0")
        percorso = percorso & "//" & NomeFile & ".xml"
        Dim file As System.IO.FileStream = System.IO.File.Create(percorso)
        ser.Serialize(New StreamWriter(file, New System.Text.UTF8Encoding()), nodoPrincipale, ns)
        file.Close()
        ' genera il file XSD
        'GeneraXMLfileXSD(NomeFile)
        System.IO.File.Delete(NomeFile & ".xml")
        System.IO.File.Copy(percorso, NomeFile & ".xml")
        System.Diagnostics.Process.Start(NomeFile & ".xml")
    End Sub


End Class
Public Class GeneraPianodiLavoroDipendente

    Shared Function F_caricaintestazioneMese(ByRef dgwTmp As DataGridView, ByVal periodo As String)   'quando clicco su ricarica

        dgwTmp.Columns.Clear()
        dgwTmp.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Dim I_numerocolonne As Integer
        Using dt As New DS_clienti.DT_calDataTable
            Using ta As New DS_clientiTableAdapters.DT_calTableAdapter
                ta.FillByPeriodo(dt, periodo)
                I_numerocolonne = dt.Rows.Count

            End Using

            Dim S_testoGiorno As String

            Dim S_tot() As String = {"DOM", "LUN", "MAR", "MER", "GIO",
                                         "VEN", "SAB"}

            dgwTmp.ColumnCount = I_numerocolonne + 2
            dgwTmp.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            dgwTmp.Columns(0).HeaderText = "Destinatario"
            dgwTmp.Columns(0).FillWeight = 150

            Dim r As Integer = 1
            For Each rg As DS_clienti.DT_calRow In dt.Rows

                S_testoGiorno = rg.gm & "-" & S_tot(rg.giorno.DayOfWeek)
                dgwTmp.Columns(r).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                'rg.giorno
                If rg.festivo Then
                    dgwTmp.Columns(r).ToolTipText = rg.festa
                    dgwTmp.Columns(r).HeaderText = "FS"
                Else
                    dgwTmp.Columns(r).HeaderText = S_testoGiorno
                End If
                dgwTmp.Columns(r).FillWeight = 40
                dgwTmp.Columns(r).DefaultCellStyle.Format = "N2"
                r += 1  ' numero progressivo delle colonne
            Next
        End Using

        Return True

    End Function



    Public Shared Function PianoLavoro(ByVal dt As DSfestivita.dtPianoDataTable, ByVal ud As DS_orari.DT_orarioDataTable, ByVal Periodo As DateTime) As DataTable
        '
        '
        '   Funzione che analizza la programmazione oraria del dipendente e la sviluppa sul mese
        '   Edited by DaSol Soft Giugno 2023
        '
        '
        Dim rn As DSfestivita.dtPianoRow

        Dim aIddestGroup = From x In ud Order By x.id_des, x.id_dip, x.lu_i, x.ma_i, x.me_i Group By x.id_des, x.id Into Group
        Dim aGiorniAnalisi() As Date
        Dim dayi() = {"do_i", "lu_i", "ma_i", "me_i", "gi_i", "ve_i", "sa_i"}
        Dim dayu() = {"do_u", "lu_u", "ma_u", "me_u", "gi_u", "ve_u", "sa_u"}
        Dim Passaggi As Int32
        Dim oldIdDes As Int16
        Dim oldIdDip As Int16

        aGiorniAnalisi = ritornainiziofinemese(Periodo)
        If aIddestGroup.Count = 0 Then
            Return dt
        End If
        oldIdDes = aIddestGroup.First.id_des
        oldIdDip = aIddestGroup.First.Group.First.id_dip

        For Each tt In aIddestGroup    'Scorre tutta la tabella delle ordinarie per popolare la tabella temporanea
            If tt.id_des <> oldIdDes Or tt.Group.First.id_dip <> oldIdDip Then
                Passaggi = 0
                oldIdDes = tt.id_des
                oldIdDip = tt.Group.First.id_dip
            End If

            For Each RigaTrovata In tt.Group
                Dim DataAnalizzata As Date = aGiorniAnalisi(0)
                For nGiorno = aGiorniAnalisi(0).Day To aGiorniAnalisi(1).Day
                    Dim ing As TimeSpan
                    Dim usc As TimeSpan
                    Dim idCli As Integer = RigaTrovata.id_cli
                    Dim idDes As Integer = RigaTrovata.id_des
                    Dim idDip As Integer = RigaTrovata.id_dip
                    Dim soc As String = RigaTrovata.societa
                    Dim loc As String = RigaTrovata.destinatario
                    Dim ana As String = RigaTrovata.anagrafica
                    Dim periodicita As Integer
                    If RigaTrovata.IsquindicinaleNull Then
                        periodicita = 0
                    Else
                        periodicita = RigaTrovata.quindicinale
                    End If
                    'periodicita = IIf(RigaTrovata.IsquindicinaleNull, 0, RigaTrovata.quindicinale)

                    ' Scorre il mese analizzato
                    Dim nGiornoWeek As Int32 = Weekday(DataAnalizzata, DayOfWeek.Monday) - 1
                    ing = RigaTrovata(dayi(nGiornoWeek))    'trova il campo per i valori di ingresso
                    usc = RigaTrovata(dayu(nGiornoWeek))    'trova il campo per i valori di uscita
                    rn = dt.NewRow
                    rn.idcli = idCli
                    rn.iddet = idDes
                    rn.iddip = idDip
                    rn.idsos = 0
                    rn.idtip = 1
                    rn.idrecupero = 0
                    rn.ing = DataAnalizzata.ToShortDateString + " " + ing.ToString.Split(" ").Last
                    rn.usc = DataAnalizzata.ToShortDateString + " " + usc.ToString.Split(" ").Last
                    rn.tot = usc.TotalHours - ing.TotalHours
                    rn.dat = DataAnalizzata
                    rn.ana = ana
                    rn.sos = ""
                    rn.soc = soc
                    rn.loc = loc
                    rn.idday = nGiornoWeek
                    rn.day = WeekdayName(Weekday(DataAnalizzata, DayOfWeek.Monday), True)
                    rn.note = If(periodicita, "Quindicinale", "")
                    rn.pass = Passaggi
                    rn.cking = loc & "-" & Passaggi
                    If rn.tot > 0 Then
                        dt.Rows.Add(rn)
                        rn.AcceptChanges()
                    End If
                    DataAnalizzata = DataAnalizzata.AddDays(1)
                Next
            Next
            Passaggi += 1
        Next
        Return dt
    End Function
    Public Shared Function SostituzioniDipendente(ByVal dt As DSfestivita.dtPianoDataTable, ByVal dtTipoOrario As DSfestivita.DTtipoorarioDataTable, ByVal dtUS As DSfestivita.DTutentisostituzioniDataTable, ByVal Sostituzione_Fatte_Ricevute As Boolean, ByVal idRif As Int16) As DataTable
        '
        '
        'Funzione che aggiunge alla tabella le sostituzioni da fare
        '
        '
        Dim bbtipo As BindingSource = New BindingSource
        bbtipo.DataMember = dtTipoOrario.TableName
        bbtipo.DataSource = dtTipoOrario


        If dtUS.Rows.Count = 0 Then
            Return dt
        End If
        'Order By oo.iddes, oo.iddip, oo.data, oo.ing
        Dim GruppaperSostituzione = From oo In dtUS Group By oo.idsost, oo.iddes Into perfascia = Group
        Dim aggiungeRigaTMP As Boolean = False
        Dim rf As DSfestivita.dtPianoRow
        If GruppaperSostituzione.Count > 0 Then     'Se ci sono sostituzioni
            Dim pass As Int16 = 0

            For Each ww In GruppaperSostituzione
                Dim codiceassoluto As String
                For Each jj In ww.perfascia
                    Dim filtro As String

                    codiceassoluto = jj.idsost & jj.iddes & Format(jj.data, “yyyy/MM/dd”) & jj.ing.ToString

                    If Sostituzione_Fatte_Ricevute Then
                        filtro = String.Format("iddip = {0} AND iddet = {1} and dat = '{2}'", jj.idsost, jj.iddes, Format(jj.data, “yyyy/MM/dd”))
                    Else
                        filtro = String.Format("idsos = {0} AND iddet = {1} and dat = '{2}'", jj.idsost, jj.iddes, Format(jj.data, “yyyy/MM/dd”))
                    End If

                    Dim TabellaOraria As DataRow()
                    TabellaOraria = dt.Select(filtro)
                    Dim inga As TimeSpan
                    inga = jj.ing
                    If TabellaOraria.Count > 0 Then
                        Dim primopassaggio As Boolean = False
                        For Each rf In TabellaOraria
                            Dim ingB As TimeSpan
                            ingB = TimeSpan.Parse(DateTime.Parse(rf("ing")).ToShortTimeString)
                            If inga = ingB Then
                                'Esiste già nel piano di lavoro e l'orario di inizio della sostituzione corrisponde all'orario corretto
                                rf("idrecupero") = jj.id
                                rf("idsos") = jj.idsost
                                rf("iddip") = jj.iddip
                                rf("idcli") = jj.idcli
                                rf("iddet") = jj.iddes
                                rf("ana") = jj.anagrafica
                                rf("sos") = IIf(jj.Isanagrafica_AssenteNull, Nothing, jj.anagrafica_Assente)
                                rf("cking") = jj.locazione
                                rf("pass") = jj.idpassaggi
                                primopassaggio = True
                                rf("idday") = Weekday(jj.data, FirstDayOfWeek.Monday)
                                rf("day") = WeekdayName(rf("idday"), True, FirstDayOfWeek.Monday)
                                rf("note") = jj.note
                                rf("loc") = jj.locazione
                                rf("soc") = jj.societa
                                rf("dat") = jj.data
                                'imposta il Tipo a Sostituito
                                If jj.idtipo = 99 Then
                                    jj = RitornaInBasealTipo(jj, idRif, Sostituzione_Fatte_Ricevute)
                                    rf("ing") = jj.data.ToShortDateString + " " + jj.ing.ToString
                                    rf("usc") = jj.data.ToShortDateString + " " + jj.usc.ToString
                                    rf("tot") = jj.usc.TotalHours - jj.ing.TotalHours
                                    rf("idtip") = jj.idtipo
                                Else
                                    If Not Sostituzione_Fatte_Ricevute Then
                                        jj = RitornaInBasealTipo(jj, idRif, Sostituzione_Fatte_Ricevute)
                                        rf("ing") = jj.data.ToShortDateString + " " + jj.ing.ToString
                                        rf("usc") = jj.data.ToShortDateString + " " + jj.usc.ToString
                                        rf("tot") = jj.usc.TotalHours - jj.ing.TotalHours
                                        rf("idtip") = jj.idtipo
                                    Else
                                        rf("idtip") = 13
                                        jj = RitornaInBasealTipo(jj, idRif, Sostituzione_Fatte_Ricevute)
                                        rf("ing") = jj.data.ToShortDateString + " " + jj.ing.ToString
                                        rf("usc") = jj.data.ToShortDateString + " " + jj.usc.ToString
                                        rf("tot") = jj.usc.TotalHours - jj.ing.TotalHours
                                    End If
                                End If
                                'End Select
                            Else
                                If primopassaggio Then
                                    rf = dt.NewRow
                                End If
                                'Esiste già nel piano di lavoro e l'orario di inizio non corrisponde all'orario di termine
                                rf("iddip") = jj.iddip
                                rf("idsos") = jj.idsost
                                'imposta il Tipo a Sostituito

                                If jj.idtipo = 99 Then
                                    rf("idtip") = 99
                                    jj = RitornaInBasealTipo(jj, idRif, Sostituzione_Fatte_Ricevute)
                                    rf("ing") = jj.data.ToShortDateString + " " + jj.ing.ToString
                                    rf("usc") = jj.data.ToShortDateString + " " + jj.usc.ToString
                                    rf("tot") = jj.usc.TotalHours - jj.ing.TotalHours
                                Else
                                    If Not Sostituzione_Fatte_Ricevute Then
                                        jj = RitornaInBasealTipo(jj, idRif, Sostituzione_Fatte_Ricevute)
                                        rf("ing") = jj.data.ToShortDateString + " " + jj.ing.ToString
                                        rf("usc") = jj.data.ToShortDateString + " " + jj.usc.ToString
                                        rf("tot") = jj.usc.TotalHours - jj.ing.TotalHours
                                        rf("idtip") = jj.idtipo
                                    Else
                                        rf("idtip") = 13
                                        jj = RitornaInBasealTipo(jj, idRif, Sostituzione_Fatte_Ricevute)
                                        rf("ing") = jj.data.ToShortDateString + " " + jj.ing.ToString
                                        rf("usc") = jj.data.ToShortDateString + " " + jj.usc.ToString
                                        rf("tot") = jj.usc.TotalHours - jj.ing.TotalHours
                                        rf("idtip") = jj.idtipo
                                    End If
                                End If
                                rf("dat") = jj.data
                                rf("note") = jj.note
                                'End Select
                                rf("idrecupero") = jj.id
                                rf("ana") = jj.anagrafica
                                rf("sos") = IIf(jj.Isanagrafica_AssenteNull, Nothing, jj.anagrafica_Assente)
                                rf("idcli") = jj.idcli
                                rf("iddet") = jj.iddes
                                rf("loc") = jj.locazione
                                rf("soc") = jj.societa
                                rf("pass") = jj.idpassaggi
                                rf("idday") = Weekday(jj.data, FirstDayOfWeek.Monday)
                                rf("day") = WeekdayName(rf("idday"), True, FirstDayOfWeek.Monday)
                                rf("cking") = jj.locazione
                                If primopassaggio Then
                                    dt.Rows.Add(rf)
                                End If
                            End If
                            rf.AcceptChanges()
                        Next
                    Else

                        If Sostituzione_Fatte_Ricevute Then
                            rf = dt.NewRow
                        Else
                            filtro = String.Format("idsos = {0} AND iddet = {1} and dat = '{2}'", jj.idsost, jj.iddes, Format(jj.data, “yyyy/MM/dd”))
                            Dim TB As DataRow()
                            TB = dt.Select(filtro)
                            If TB.Count > 0 Then
                                rf = TB.First
                            Else
                                aggiungeRigaTMP = True
                                'Sostituzione_Fatte_Ricevute = True
                                rf = dt.NewRow
                            End If

                        End If

                        rf("iddip") = jj.iddip
                        rf("idsos") = jj.idsost
                        rf("dat") = jj.data
                        rf("idrecupero") = jj.id
                        rf("idsos") = jj.idsost
                        rf("iddip") = jj.iddip
                        rf("idcli") = jj.idcli
                        rf("iddet") = jj.iddes
                        rf("loc") = jj.locazione
                        rf("soc") = jj.societa
                        rf("ana") = jj.anagrafica
                        If jj.Isanagrafica_AssenteNull Then
                            rf("sos") = jj.anagrafica
                        Else
                            rf("sos") = jj.anagrafica_Assente
                        End If
                        rf("cking") = jj.locazione
                        rf("idday") = Weekday(jj.data, FirstDayOfWeek.Monday)
                        rf("day") = WeekdayName(rf("idday"), True, FirstDayOfWeek.Monday)
                        rf("note") = jj.note
                        rf("pass") = jj.idpassaggi

                        If Not Sostituzione_Fatte_Ricevute Then
                            jj = RitornaInBasealTipo(jj, idRif, Sostituzione_Fatte_Ricevute)
                            rf("dat") = jj.data
                            rf("ing") = jj.data.ToShortDateString + " " + jj.ing.ToString
                            rf("usc") = jj.data.ToShortDateString + " " + jj.usc.ToString
                            rf("tot") = jj.usc.TotalHours - jj.ing.TotalHours
                            rf("idtip") = jj.idtipo
                        Else
                            jj = RitornaInBasealTipo(jj, idRif, Sostituzione_Fatte_Ricevute)
                            rf("ing") = jj.data.ToShortDateString + " " + jj.ing.ToString
                            rf("usc") = jj.data.ToShortDateString + " " + jj.usc.ToString
                            rf("tot") = jj.usc.TotalHours - jj.ing.TotalHours
                            rf("idtip") = jj.idtipo
                        End If
                        If aggiungeRigaTMP Then
                            dt.Rows.Add(rf)
                            aggiungeRigaTMP = False
                        ElseIf Sostituzione_Fatte_Ricevute Then
                            dt.Rows.Add(rf)
                        End If

                    End If
#Disable Warning BC42104 ' La variabile 'rf' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
                    rf.AcceptChanges()
#Enable Warning BC42104 ' La variabile 'rf' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.

                    '   Memorizza la data per verificare successivamente se è cambiata, a quel punto azzera il Pass
                    '   Altrimenti mantiene attivo il Pass per poter creare una nuova colonna nel foglio presenze sullo stesso cantiere
                Next
            Next
        End If
        dt.AcceptChanges()
        Return dt
    End Function
    Private Shared Function RitornaInBasealTipo(ByVal jj As DSfestivita.DTutentisostituzioniRow, ByVal idRif As Int16, ByVal Sostituzioni_Fatte_Ricevute As Boolean) As DSfestivita.DTutentisostituzioniRow


        Console.WriteLine(String.Format("dip {0} ing {1} idtip {2}", jj.iddip, jj.ing, jj.idtipo))

        Select Case jj.idtipo
            Case 2
                If Sostituzioni_Fatte_Ricevute Then
                    jj.idtipo = 13
                End If
                Select Case True
                    Case jj.idsost = idRif
                        jj.ing = New TimeSpan(0, 0, 0)
                        jj.usc = New TimeSpan(0, 0, 0)
                End Select
            Case 12
                jj.ing = New TimeSpan(0, 0, 0)
                jj.usc = New TimeSpan(0, 0, 0)
                jj.idtipo = jj.idtipo
            Case 99
                jj.ing = New TimeSpan(0, 0, 0)
                jj.usc = New TimeSpan(0, 0, 0)
        End Select

        Return jj
    End Function
    Public Shared Function CodificaidoppiPassaggi(ByVal dt As DSfestivita.dtPianoDataTable) As DataTable
        Dim Doppipassaggi = From dp In dt Order By dp.loc, dp.dat Group By dp.iddet, dp.dat Into doppio = Group

        For Each rgDP In Doppipassaggi
            Dim pass As Int16 = 0
            For Each sp In rgDP.doppio
                sp.pass = pass
                sp.cking = sp.loc & "-" & pass
                pass += 1
                sp.AcceptChanges()
            Next
        Next
        dt.AcceptChanges()

        Dim CantieriValidi = From dp In dt Order By dp.loc, dp.dat Group By dp.cking, dp.pass Into doppio = Group Select New With {
                .ckIng = cking,
                .pass = pass,
                .Total = doppio.Sum(Function(dp) dp.Field(Of Decimal)("tot"))}
        For Each gg In CantieriValidi
            Console.WriteLine(gg.ckIng & " - " & gg.Total)
        Next
        Return dt
    End Function


    Public Shared Function FerieCliente(ByVal dtPL As DSfestivita.dtPianoDataTable, ByVal Periodo As DateTime, Optional eliminaSos As Boolean = True) As DataTable
        '
        '   VALORIZZA LA TABELLA CON LE FERIE DEL CLIENTE
        '
        Dim periodos As String = Periodo.Year.ToString + "-" + Periodo.Month.ToString.PadLeft(2, "0")

        Dim DetGroup = (From v In dtPL Order By v.ing, v.iddet Group v By v.iddet Into Group).ToList
        If DetGroup.Count = 0 Then
            Return dtPL
        End If
        Dim oldDet = DetGroup(0).iddet

        '   Scorre i dettagli clienti che sono presenti nella
        '   tabella dtPL raggruppati per cliente e per dettaglio cliente

        For Each destinatario In DetGroup
            Using dtFD As New DSfestivita.DTferieclienteDataTable
                Using uT As New DSfestivitaTableAdapters.TAferiecliente

                    '   Carica la tabella delle ferie del cliente per ogni singolo dettaglio
                    '   del cliente

                    uT.FillBydettaglioperiodo(dtFD, destinatario.iddet, periodos.Replace("-", ""))
                End Using


                For Each rgFerieDest As DSfestivita.DTferieclienteRow In dtFD        'Tabella delle Ferie per Dettaglio Cliente
                    Dim Inizio As Date = rgFerieDest.inizio
                    Dim Fine As Date = rgFerieDest.fine

                    '   Scorre la tabella PianodiLavoro e se trova nella tabella ferie destinatario una corrispondenza
                    '   nel caso eliminasos
                    '   Elimina la riga direttamente dalla tabella
                    '   Nel caso NON eliminasos
                    '   Imposta la tipologia a 7 se il dipendente non è già in ferie
                    '   Altrimenti imposta 9

                    If eliminaSos Then

                        For Each rigaPL In destinatario.Group
                            If rigaPL.dat >= Inizio And rigaPL.dat <= Fine Then
                                rigaPL.Delete()
                            End If
                        Next
                    Else
                        For Each rigaPL In destinatario.Group
                            If rigaPL.dat >= Inizio And rigaPL.dat <= Fine Then
                                If rigaPL.idtip = 2 Then
                                    rigaPL.idtip = 9   'Valore per Ferie del cliente
                                Else
                                    rigaPL.idtip = 7   'Valore per Ferie del cliente
                                End If
                                rigaPL.ing = rigaPL.dat & " " & New TimeSpan(0, 0, 0).ToString
                                rigaPL.usc = rigaPL.dat & " " & New TimeSpan(0, 0, 0).ToString
                                rigaPL.tot = 0
                            End If
                            rigaPL.AcceptChanges()
                        Next
                    End If
                Next
            End Using
        Next
        dtPL.AcceptChanges()
        Return dtPL
    End Function


    Public Shared Function FerieDipendenteDaCliente(ByVal dt As DSfestivita.dtPianoDataTable, idUT As Integer, ByVal Periodo As DateTime, Optional eliminaSos As Boolean = True) As DataTable
        '
        '   VALORIZZA LA TABELLA CON LE FERIE PER IL DIPENDENTE
        '
        Dim oreaZero As New TimeSpan(0, 0, 0)

        Dim periodos As String = Periodo.Year.ToString + "-" + Periodo.Month.ToString.PadLeft(2, "0")
        Using uD As New DSfestivita.DTferieutenteDataTable
            Using uT As New DSfestivitaTableAdapters.TAferieutente
                uT.FillByUtentePeriodo(uD, idUT, periodos.Replace("-", ""))
            End Using
            Dim Tmese As Int32 = periodos.Split("-").Last
            For Each tt As DataRow In uD.Rows
                Dim rt As DSfestivita.DTferieutenteRow
                rt = DirectCast(tt, DataRow)
                Dim Inizio As Date = tt.Field(Of Date)("inizio")
                Dim Fine As Date = tt.Field(Of Date)("fine")
                Dim ultimadelmese As Date
                Dim ultimogiornodelmese As Int16 = System.DateTime.DaysInMonth(periodos.Split("-").First.ToString, periodos.Split("-").Last.ToString)
                ultimadelmese = Date.Parse(periodos & "-" & ultimogiornodelmese)
                If Fine > ultimadelmese Then
                    Fine = ultimadelmese
                End If
                Dim totGiorni As Int16 = DateDiff(DateInterval.Day, Inizio, Fine)
                For i = 0 To totGiorni
                    Dim tDat As Date
                    tDat = Inizio.AddDays(i)
                    Dim rgDel As DataRow() = Nothing
                    If eliminaSos Then
                        For Each rn As DSfestivita.dtPianoRow In dt.Rows
                            If rn.dat = tDat Then
                                rgDel.Add(rn)
                            End If
                        Next
                        If IsNothing(rgDel) <> True Then
                            For Each r As DataRow In rgDel
                                dt.Rows.Remove(r)
                            Next
                        End If
                    Else
                        For Each rn As DSfestivita.dtPianoRow In dt.Rows
                            'Se trova la stessa data occupata
                            If rn.dat = tDat Then
                                Dim controllo As Integer
                                controllo = rt.controllo
                                Dim chiApprova As String
                                If rt.IsautorizzatoNull Then
                                    chiApprova = ""
                                Else
                                    chiApprova = rt.autorizzato
                                End If

                                If rn.iddip = idUT Then
                                    Select Case rn.idtip
                                        Case 7
                                            rn.idtip = 9
                                            rn.ing = rn.dat.ToShortDateString & " " & oreaZero.ToString
                                            rn.usc = rn.dat.ToShortDateString + " " + oreaZero.ToString
                                            rn.tot = 0
                                            rn.note = "#CHIUSO#FERIE"
                                        Case Else
                                            rn.idtip = 2
                                            rn.ing = rn.dat.ToShortDateString & " " & oreaZero.ToString
                                            rn.usc = rn.dat.ToShortDateString + " " + oreaZero.ToString
                                            rn.tot = 0
                                            rn.note = "#FERIE"
                                    End Select
                                End If
                            End If

                            rn.AcceptChanges()

                        Next
                    End If
                Next
            Next
        End Using
        dt.AcceptChanges()
        Return dt
    End Function


    Public Shared Function FerieDipendente(ByVal dtPL As DSfestivita.dtPianoDataTable, ByVal dtFU As DSfestivita.DTferieutenteDataTable, ByVal Periodo As DateTime, ByVal Optional eliminaSos As Boolean = True, ByVal Optional nonconvalidato As Boolean = False) As DataTable
        '
        '   VALORIZZA LA TABELLA CON LE FERIE PER IL DIPENDENTE
        '
        Dim periodos As String = Periodo.Year.ToString + "-" + Periodo.Month.ToString.PadLeft(2, "0")
        Dim oreaZero As New TimeSpan(0, 0, 0)

        Dim Tmese As Int32 = periodos.Split("-").Last
        For Each tt As DataRow In dtFU.Rows
            Dim rt As DSfestivita.DTferieutenteRow
            rt = DirectCast(tt, DataRow)
            Dim Inizio As Date = tt.Field(Of Date)("inizio")
            Dim Fine As Date = tt.Field(Of Date)("fine")
            Dim ultimadelmese As Date
            Dim ultimogiornodelmese As Int16 = System.DateTime.DaysInMonth(periodos.Split("-").First.ToString, periodos.Split("-").Last.ToString)
            ultimadelmese = Date.Parse(periodos & "-" & ultimogiornodelmese)
            If Fine > ultimadelmese Then
                Fine = ultimadelmese
            End If
            Dim totGiorni As Int16 = DateDiff(DateInterval.Day, Inizio, Fine)

#Disable Warning BC42024 ' Variabile locale inutilizzata: 'Valori'.
            Dim Valori As String()
#Enable Warning BC42024 ' Variabile locale inutilizzata: 'Valori'.

            For i = 0 To totGiorni
                Dim tDat As Date
                tDat = Inizio.AddDays(i)
                Dim rgDel As DataRow() = Nothing
                If eliminaSos Then
                    For Each rn As DSfestivita.dtPianoRow In dtPL.Rows
                        If rn.dat = tDat Then
                            rgDel.Add(rn)
                        End If
                    Next
                    If IsNothing(rgDel) <> True Then
                        For Each r As DataRow In rgDel
                            dtPL.Rows.Remove(r)
                        Next
                    End If
                Else
                    For Each rn As DSfestivita.dtPianoRow In dtPL.Rows
                        If rn.iddip = rt.id_dip Then
                            If rn.dat = tDat Then
                                rn.idtip = 2
                                'rn.ing =
                                'rn.usc =
                                'rn.tot =
                                rn.AcceptChanges()
                            End If
                        End If
                    Next
                End If
            Next
        Next
        dtPL.AcceptChanges()
        Return dtPL
    End Function
    Public Shared Function Eliminagiornifestivi(ByVal dt As DSfestivita.dtPianoDataTable, idUT As Integer, ByVal Periodo As DateTime, Optional eliminaSos As Boolean = True) As DataTable

        Dim aPeriodo() As DateTime = ritornainiziofinemese(Periodo)

        Using dtDay As New DS_utenti.DT_calDataTable
            Using ta As New DS_utentiTableAdapters.TA_cal
                ta.FillByDaA(dtDay, aPeriodo(0), aPeriodo(1))
            End Using
            For Each rg As DS_utenti.DT_calRow In dtDay.Rows
                Dim giornoFestivo As DateTime
                If rg.festivo Then
                    giornoFestivo = rg.giorno
                End If
                Dim rgDel As DataRow() = Nothing
                If eliminaSos Then
                    For Each rn As DSfestivita.dtPianoRow In dt.Rows
                        If rn.dat = giornoFestivo Then
                            rgDel.Add(rn)
                        End If
                    Next
                    If IsNothing(rgDel) <> True Then
                        For Each rn As DataRow In rgDel
                            dt.Rows.Remove(rn)
                        Next
                    End If
                Else
                    For Each rn As DSfestivita.dtPianoRow In dt
                        If rn.dat = giornoFestivo Then
                            rn.day = "festivo"
                            rn.ing = rg.giorno.ToShortDateString + " " + New TimeSpan(0, 0, 0).ToString
                            rn.usc = rg.giorno.ToShortDateString + " " + New TimeSpan(0, 0, 0).ToString
                            rn.tot = 0
                            rn.idtip = 6
                        End If
                    Next
                End If
                dt.AcceptChanges()
            Next
        End Using
        Return dt
    End Function
    Public Shared Function Ordinapianodilavoro(ByRef dt As DSfestivita.dtPianoDataTable, ByVal Ordine As String) As DataTable
        Dim DataTableNew As DataTable = New DataTable
        DataTableNew = dt.Clone

        Dim query = From c In dt.AsEnumerable Order By c.loc Ascending
        query.CopyToDataTable(DataTableNew, LoadOption.OverwriteChanges)
        Return DataTableNew
    End Function

    Public Shared Function EliminaiCantierinonlavorati(ByVal dt As DSfestivita.dtPianoDataTable) As DataTable
        Dim result = (From piano In dt.AsEnumerable
                      Group piano By ck = piano.Field(Of String)("cking") Into g = Group
                      Select New With {Key ck,
                      .somma = g.Sum(Function(r) r.Field(Of Decimal)("tot"))
                      }).OrderBy(Function(tkey) tkey.ck).ToList()

        For Each hh In result
            For Each rr As DSfestivita.dtPianoRow In dt.Rows
                If rr.cking = hh.ck And hh.somma = 0 Then
                    rr.Delete()
                End If
            Next
            dt.AcceptChanges()
        Next
        Return dt
    End Function
    Public Shared Function CaricaIntestazioniPresenzePreviste(ByRef dgwTMP As DataGridView, ByVal numeroCelle As Integer, ByRef BBTmp As BindingSource)   'quando clicco su ricarica
        Dim Larghezzacellamassima As Integer
        If numeroCelle > 0 Then
            Larghezzacellamassima = (dgwTMP.Width - 173) / (numeroCelle + 2)
        End If
        dgwTMP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        Dim I_numerocolonne = BBTmp.Count
        Dim S_testoGiorno As String = ""
        Dim S_tot() As String = {"D", "L", "M", "M", "G",
                                     "V", "S"}

        dgwTMP.ColumnCount = I_numerocolonne + 2
        dgwTMP.Columns(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgwTMP.Columns(0).HeaderText = "Destinatario"
        dgwTMP.Columns(0).Width = 173
        Dim rg As DS_utenti.DT_calRow
        Dim r As Integer = 1
        For Each l In BBTmp
            rg = DirectCast(l, DataRowView).Row
            S_testoGiorno = S_tot(rg.giorno.DayOfWeek) + vbCrLf + rg.gm
            dgwTMP.Columns(r).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            'rg.giorno
            If rg.festivo Then
                dgwTMP.Columns(r).ToolTipText = rg.festa
                dgwTMP.Columns(r).HeaderText = "FS"
            Else
                dgwTMP.Columns(r).HeaderText = S_testoGiorno
            End If
            dgwTMP.Columns(r).Width = Larghezzacellamassima
            dgwTMP.Columns(r).DefaultCellStyle.Format = "N2"
            r += 1
        Next
        dgwTMP.Columns(numeroCelle).HeaderText = "Totale"
        dgwTMP.Columns(numeroCelle).Width = Larghezzacellamassima * 2
        dgwTMP.RowHeadersWidth = 100

        Return True

    End Function
    Public Shared Function restituiscecolori(ByVal dtCOLOR As DSfestivita.DTtipoorarioDataTable, ByVal idColore As Int16) As String()

        For Each r As DSfestivita.DTtipoorarioRow In dtCOLOR.Rows
            If idColore = r.id Then
                Return {r.colore, r.descrizione}
            End If
        Next
        Return {"grey", "nessuna corrispondenza"}
    End Function

    Public Shared Function GeneraValoriPianoOrarioCliente(ByRef dgwTMP As DataGridView, ByRef dtUT As DSfestivita.dtPianoDataTable, ByVal bbCli As BindingSource,
                                                          ByVal bbCal As BindingSource, ByVal periodolocale As String,
                                                          ByVal dtTipoFerie As DSfestivita.DTtipoorarioDataTable,
                                                          Optional ByVal CancelloPregresso As Boolean = True, Optional ByVal nonConvalidate As Boolean = True) As DataTable
        '
        '
        '   Riempie i valori delle ferie per il dipendente nel piano di lavoro Mensile
        '   Edited by DaSolSoft Luglio 2023
        '   Crea la tabella che servirà per generare il piano di lavoro o piano ferie suddivisa per cliente
        '
        '
        Dim dtTipoOrario As New DSfestivita.DTtipoorarioDataTable
        Dim LeggendaFerie As DataTable
        Dim col1 As DataColumn
        col1 = New DataColumn("id", Type.GetType("System.Int16"))
        Dim col2 As DataColumn
        col2 = New DataColumn("descrizione", Type.GetType("System.String"))
        LeggendaFerie = New DataTable
        LeggendaFerie.Columns.AddRange({col1, col2})

        Using dt As New DSfestivita.dtUtentiFerieLeggendaDataTable
            Using ta As New DSfestivitaTableAdapters.taUtentiFerieLeggenda
                ta.Fill(dt)
                Dim riga As DataRow
                For Each r In dt
                    riga = LeggendaFerie.NewRow
                    riga("id") = r.id
                    riga("descrizione") = r.descrizione

                    LeggendaFerie.Rows.Add(riga)
                    riga.AcceptChanges()
                Next
            End Using
        End Using

        Dim nRiga As Integer

        Dim idCL As Integer = DirectCast(bbCli.Current, DataRowView).Row.Field(Of Integer)("id")
        dtUT = New DSfestivita.dtPianoDataTable
        Dim anno As Integer = periodolocale.Split("-").First
        Dim mese As Integer = periodolocale.Split("-").Skip(1).First
        Dim daUT As DateTime = New Date(anno, mese, 1)
        Dim periodo As String = anno.ToString & mese.ToString.PadLeft(2, "0")

        '   Scorre tutti i dipendenti che lavorano dal cliente
        '   e carica i vari piani di lavoro per ogni dipendente nella tabella dtUT
        '   alla Classe PianoLavoro bisogna passargli dtUT, la tabella dei piani di lavoro ed il periodo del piano di lavoro

        Using uD As New DS_orari.DT_orarioDataTable
            Using uT As New DS_orariTableAdapters.TA_orario
                uT.FillByClienti(uD, idCL)
            End Using
            'PIANO DI LAVORO
            dtUT = GeneraPianodiLavoroDipendente.PianoLavoro(dtUT, uD, daUT)
        End Using

        '   Carica le ferie del cliente e assegna di conseguenza le righe alla tabella
        '   dtUT impostando il valore su 7 se chiuso il cliente o 9 se chiuso il cliente e assente il dipendente
        '   la Classe è solo per le ferie del cliente

        '   FERIE CLIENTE


        Dim feriePerogniDipendente = From h In dtUT Group h By h.iddip Into l = Group
        For Each b In feriePerogniDipendente
            Dim iddip As Int16
            iddip = b.iddip
            Using uDFD As New DSfestivita.DTferieutenteDataTable
                Using uT As New DSfestivitaTableAdapters.TAferieutente
                    'FERIE UTENTE / DIPENDENTE  
                    uT.FillByUtentePeriodo(uDFD, iddip, periodo)

                End Using
                dtUT = GeneraPianodiLavoroDipendente.FerieDipendente(dtUT, uDFD, daUT, False)
            End Using
        Next


        Using dtUS As New DSfestivita.DTutentisostituzioniDataTable
            Dim Sostituzioni_Fatte_Ricevute As Boolean

            Using uT As New DSfestivitaTableAdapters.TAutentisostituzioni
                uT.FillByPeriodoSostituzioniFatteDalCliente(dtUS, idCL, periodo)
                Sostituzioni_Fatte_Ricevute = True

                dtUT = GeneraPianodiLavoroDipendente.SostituzioniDipendente(dtUT, dtTipoOrario, dtUS, Sostituzioni_Fatte_Ricevute, 0)

            End Using
        End Using

        dtUT = GeneraPianodiLavoroDipendente.FerieCliente(dtUT, daUT, False)

        dtUT = GeneraPianodiLavoroDipendente.EliminaiCantierinonlavorati(dtUT)

        dtUT = GeneraPianodiLavoroDipendente.CodificaidoppiPassaggi(dtUT)

        dtUT = GeneraPianodiLavoroDipendente.Ordinapianodilavoro(dtUT, "loc")


        dtUT.AcceptChanges()


        Dim idDetGroup = (From v In dtUT Order By v.loc, v.ana, v.dat, v.ing Group v By v.loc Into Risultato =
                    Group).ToList

        If CancelloPregresso Then
            dgwTMP.Rows.Clear()
        End If
        Dim k1 As DataGridViewCellStyle

        Dim oldAna As String
        Dim newAna As String


        dgwTMP.Rows.Add()
        nRiga = dgwTMP.Rows.Count - 1

        For Each gIdDet In idDetGroup   'Scorre il raggruppamento ottenuto per Destinatario (LOC)

            oldAna = gIdDet.Risultato.First.ana
            Dim tips As String = ""
            Dim Tag As String = ""
            Dim oldGiorno As Int16
            Dim totaleOreGiorno As Decimal = 0
            Dim totaleOreCantiere(31) As Decimal
            'SCRIVE IL TITOLO del cantiere occupando la prima riga 

            k1 = New DataGridViewCellStyle
            k1.ForeColor = Color.White
            k1.BackColor = Color.Gray
            k1.Font = New Font("Arial", 8, FontStyle.Regular)
            k1.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgwTMP(0, nRiga).Value = gIdDet.Risultato.First.loc
            dgwTMP(0, nRiga).Style = k1
            For Each Giorno As DataRowView In bbCal
                Dim nColonna As Int16
                nColonna = Giorno.Row("giorno").day
                dgwTMP(nColonna, nRiga).Style = k1
            Next

            dgwTMP.Rows.Add()
            nRiga = dgwTMP.Rows.Count - 1

            For Each f In gIdDet.Risultato 'Scorre il destinatario e popola il Datagridview
                newAna = f.ana
                If oldGiorno <> f.dat.Day Then
                    totaleOreGiorno = 0
                    oldGiorno = f.dat.Day
                    tips = ""
                    Tag = ""
                End If
                If oldAna <> newAna Then
                    totaleOreGiorno = 0
                    oldAna = newAna
                    dgwTMP.Rows.Add()
                    nRiga = dgwTMP.Rows.Count - 1
                    tips = ""
                    Tag = ""
                End If

                dgwTMP(0, nRiga).Value = newAna


                'For Each f In iddip.Risultato
                Dim colonna As Int16
                colonna = f.dat.Day
                Dim totOre As Decimal = 0
                Dim lTag As List(Of String) = New List(Of String)
                Dim idSos, idDip, idtip As Int16
                Dim sAss, sSos As String
                Dim colore As Color = Color.White
                Dim oreGiorno As Decimal

                Dim l As List(Of String) = New List(Of String)
                l.Add(f.ing.ToShortTimeString)
                l.Add(f.usc.ToShortTimeString)
                l.Add(f.iddip.ToString)
                l.Add(f.idcli)
                l.Add(f.iddet)
                l.Add(If(f.idrecupero = 0, -1, f.idrecupero))
                lTag.AddRange(l)

                idSos = f.idsos
                idDip = f.iddip
                idtip = f.idtip
                sAss = f.ana
                If Not IsDBNull(f.sos) Then
                    sSos = f.sos
                End If

                Dim hColor As String() = restituiscecolori(dtTipoFerie, idtip)

                If Color.FromName(hColor(0)) <> Color.White Then
                    colore = Color.FromName(hColor(0))
                End If
                k1 = New DataGridViewCellStyle
                k1.ForeColor = Color.Black
                k1.BackColor = colore
                k1.Font = New Font("Arial", 8, FontStyle.Regular)
                k1.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgwTMP(colonna, nRiga).Style = k1
                Dim quindicinale As Boolean = False

                If Not quindicinale Then
                    oreGiorno = (f.usc - f.ing).TotalHours
                    totaleOreGiorno += oreGiorno
                    totaleOreCantiere(oldGiorno) += totaleOreGiorno
                    dgwTMP(colonna, nRiga).Value = If(totaleOreGiorno > 0, totaleOreGiorno.ToString("N"), "")
                End If
                Dim scorporaNote As Object
                Dim DisposizioniFerie As String = ""
                If f.note.Length > 0 Then
                    scorporaNote = f.note.Split("#").Last
                    Dim id As Int32 = 0
                    Dim h As Boolean = Int32.TryParse(scorporaNote, id)
                    If h = False Then
                        If f.note = "Quindicinale" Then
                            quindicinale = Not quindicinale
                        End If
                    End If
                    Dim opzioneFerie() As DataRow
                    opzioneFerie = LeggendaFerie.Select("id = " & id)
                    DisposizioniFerie = opzioneFerie.First.Field(Of String)("descrizione")
                End If
#Disable Warning BC42104 ' La variabile 'sSos' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
                tips += String.Format("{6}->{3} {0} - {1} = {2} {5}", f.ing.ToShortTimeString, f.usc.ToShortTimeString, oreGiorno, sSos, hColor(1), vbCrLf, DisposizioniFerie)
#Enable Warning BC42104 ' La variabile 'sSos' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
                Tag += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", f.iddip, f.ing, f.usc, idDip, idSos, f.idcli, f.iddet, If(f.idrecupero = 0, -1, f.idrecupero), f.idtip)

                dgwTMP(colonna, nRiga).Tag = Tag
                dgwTMP(colonna, nRiga).ToolTipText = tips

            Next
            dgwTMP.Rows.Add()
            nRiga = dgwTMP.Rows.Count - 1

            k1 = New DataGridViewCellStyle
            k1.ForeColor = Color.White
            k1.BackColor = Color.Black
            k1.Font = New Font("Arial", 8, FontStyle.Regular)
            k1.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgwTMP(0, nRiga).Value = ""
            dgwTMP.Rows(nRiga).Height = 2
            dgwTMP(0, nRiga).Style = k1
            For Each Giorno As DataRowView In bbCal
                Dim nColonna As Int16
                nColonna = Giorno.Row("giorno").day
                dgwTMP(nColonna, nRiga).Style = k1
            Next
            dgwTMP.Rows.Add()
            nRiga = dgwTMP.Rows.Count - 1

            k1 = New DataGridViewCellStyle
            k1.ForeColor = Color.Black
            k1.BackColor = Color.White
            k1.Font = New Font("Arial", 8, FontStyle.Regular)
            k1.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgwTMP(0, nRiga).Value = "Totale"
            dgwTMP.Rows(nRiga).Height = 22
            dgwTMP(0, nRiga).Style = k1
            For Each Giorno As DataRowView In bbCal
                Dim nColonna As Int16
                nColonna = Giorno.Row("giorno").day
                dgwTMP(nColonna, nRiga).Style = k1
                If totaleOreCantiere(nColonna) <> 0 Then
                    dgwTMP(nColonna, nRiga).Value = totaleOreCantiere(nColonna)
                    totaleOreCantiere(nColonna) = 0
                End If
            Next
            dgwTMP.Rows.Add()
            nRiga = dgwTMP.Rows.Count - 1

        Next
        Return dtUT

    End Function

    Public Shared Function GeneraValoriPianoOrarioDipendente(ByRef dgwTMP As DataGridView, ByRef dtUT As DSfestivita.dtPianoDataTable, ByVal bbUte As BindingSource, ByVal periodolocale As String,
                                                             ByVal dtTipoOrario As DSfestivita.DTtipoorarioDataTable,
                                                             Optional ByVal SoloTabella As Boolean = False, Optional ByVal bbCal As BindingSource = Nothing,
                                                             Optional ByVal CancelloPregresso As Boolean = True, Optional ByVal nonConvalidate As Boolean = True
                                                            ) As DataTable

        '
        '
        'Riempie i valori delle ferie per il dipendente nel piano di lavoro Mensile
        '
        '
        'TODO *************************************************

#Disable Warning BC42024 ' Variabile locale inutilizzata: 'tipoFerie'.
        Dim tipoFerie As String()
#Enable Warning BC42024 ' Variabile locale inutilizzata: 'tipoFerie'.
        Dim LeggendaFerie As DataTable
        Dim col1 As DataColumn
        col1 = New DataColumn("id", Type.GetType("System.Int16"))
        Dim col2 As DataColumn
        col2 = New DataColumn("descrizione", Type.GetType("System.String"))
        LeggendaFerie = New DataTable
        LeggendaFerie.Columns.AddRange({col1, col2})


        Using dt As New DSfestivita.dtUtentiFerieLeggendaDataTable
            Using ta As New DSfestivitaTableAdapters.taUtentiFerieLeggenda
                ta.Fill(dt)
                Dim riga As DataRow
                For Each r In dt
                    riga = LeggendaFerie.NewRow
                    riga("id") = r.id
                    riga("descrizione") = r.descrizione
                    LeggendaFerie.Rows.Add(riga)
                    riga.AcceptChanges()
                Next
            End Using
        End Using

        Dim nRiga As Integer

        Dim nidDip As Integer = DirectCast(bbUte.Current, DataRowView).Row.Field(Of Integer)("id")


        dtUT = New DSfestivita.dtPianoDataTable
        Dim anno As Integer = periodolocale.Split("-").First
        Dim mese As Integer = periodolocale.Split("-").Skip(1).First
        Dim daUT As DateTime = New Date(anno, mese, 1)
        Dim periodo As String = anno.ToString & mese.ToString.PadLeft(2, "0")

        Using uD As New DS_orari.DT_orarioDataTable
            Using uT As New DS_orariTableAdapters.TA_orario

                uT.FillByDipendente(uD, nidDip)

            End Using

            dtUT = GeneraPianodiLavoroDipendente.PianoLavoro(dtUT, uD, daUT)

        End Using


        Using dtUS As New DSfestivita.DTutentisostituzioniDataTable

            Using uT As New DSfestivitaTableAdapters.TAutentisostituzioni

                Dim Sostituzioni_Fatte_Ricevute As Boolean
                'Analizza le sostituzioni che il dipendente ha fatto
                uT.FillByPeriodoSostituzioniFatteDipendente(dtUS, nidDip, periodo)

                Sostituzioni_Fatte_Ricevute = True

                dtUT = GeneraPianodiLavoroDipendente.SostituzioniDipendente(dtUT, dtTipoOrario, dtUS, Sostituzioni_Fatte_Ricevute, nidDip)

                'Analizza le sostituzioni che hanno dovuto fare al dipendente
                uT.FillByPeriodoSostituzioniFatteALDipendente(dtUS, nidDip, periodo)

                Sostituzioni_Fatte_Ricevute = False

                dtUT = GeneraPianodiLavoroDipendente.SostituzioniDipendente(dtUT, dtTipoOrario, dtUS, Sostituzioni_Fatte_Ricevute, nidDip)

            End Using

        End Using

        dtUT = GeneraPianodiLavoroDipendente.FerieCliente(dtUT, daUT, False)

        Using uDFD As New DSfestivita.DTferieutenteDataTable
            Using uT As New DSfestivitaTableAdapters.TAferieutente

                If Not nonConvalidate Then
                    '   Indica le ferie anche se non sono ancora state convalidate
                    uT.FillByUtentePeriodo(uDFD, nidDip, periodo)
                Else

                    uT.FillByUtenteConvalidaPeriodo_AnnoMese(uDFD, nidDip, 2, periodo)
                End If

            End Using
            dtUT = GeneraPianodiLavoroDipendente.FerieDipendente(dtUT, uDFD, daUT, False)
        End Using

        'dtUT = GeneraPianodiLavoroDipendente.Eliminagiornifestivi(dtUT, nidDip, daUT, False)
        dtUT = GeneraPianodiLavoroDipendente.EliminaiCantierinonlavorati(dtUT)

        dtUT = GeneraPianodiLavoroDipendente.CodificaidoppiPassaggi(dtUT)

        dtUT = GeneraPianodiLavoroDipendente.Ordinapianodilavoro(dtUT, "loc")


        dtUT.AcceptChanges()


        'SE Richiesti solo i dati della tabella Piano immettere True nella Classe

        If SoloTabella Then
            Return dtUT
        End If




        Dim idDetGroup = (From v In dtUT Order By v.loc, v.ana, v.dat, v.ing Group v By v.loc Into Risultato =
                   Group).ToList

        'Dim tmpDetGroup = (From v In dtUT).ToLookup(Function(x) x.loc)


        If CancelloPregresso Then
            dgwTMP.Rows.Clear()
        End If
        Dim k1 As DataGridViewCellStyle

        Dim oldAna As String
        Dim newAna As String


        dgwTMP.Rows.Add()
        nRiga = dgwTMP.Rows.Count - 1

        For Each gIdDet In idDetGroup   'Scorre il raggruppamento ottenuto per Destinatario (LOC)

            oldAna = gIdDet.Risultato.First.ana
            Dim tips As String
            Dim Tag As String
            Dim oldGiorno As Int16
            Dim totaleOreGiorno As Decimal


            For Each f In gIdDet.Risultato 'Scorre il destinatario e popola il Datagridview
                newAna = f.ana
                If oldGiorno <> f.dat.Day Then
                    totaleOreGiorno = 0
                    oldGiorno = f.dat.Day
                    tips = ""
                    Tag = ""
                End If
                If oldAna <> newAna Then
                    totaleOreGiorno = 0
                    oldAna = newAna
                    dgwTMP.Rows.Add()
                    nRiga = dgwTMP.Rows.Count - 1
                    tips = ""
                    Tag = ""
                End If

                dgwTMP(0, nRiga).Value = newAna


                'For Each f In iddip.Risultato
                Dim colonna As Int16
                colonna = f.dat.Day
                Dim totOre As Decimal = 0
                Dim lTag As List(Of String) = New List(Of String)
                Dim idSos, idDip, idtip As Int16
                Dim sAss, sSos As String
                Dim colore As Color = Color.White
                Dim oreGiorno As Decimal

                Dim l As List(Of String) = New List(Of String)
                l.Add(f.ing.ToShortTimeString)
                l.Add(f.usc.ToShortTimeString)
                l.Add(f.iddip.ToString)
                l.Add(f.idcli)
                l.Add(f.iddet)
                l.Add(If(f.idrecupero = 0, -1, f.idrecupero))
                lTag.AddRange(l)

                idSos = f.idsos
                idDip = f.iddip
                idtip = f.idtip
                sAss = f.ana
                If Not IsDBNull(f.sos) Then
                    sSos = f.sos
                End If

                'totOre += IIf(idtip <> 10, f.tOre, 0)
                If Color.FromName(restituiscecolori(dtTipoOrario, idtip)(0)) <> Color.White Then
                    colore = Color.FromName(restituiscecolori(dtTipoOrario, idtip)(0))
                End If
                k1 = New DataGridViewCellStyle
                k1.ForeColor = Color.Black
                k1.BackColor = colore
                k1.Font = New Font("Arial", 8, FontStyle.Regular)
                k1.Alignment = DataGridViewContentAlignment.MiddleCenter
                dgwTMP(colonna, nRiga).Style = k1
                Dim quindicinale As Boolean = False

                If Not quindicinale Then
                    oreGiorno = (f.usc - f.ing).TotalHours
                    totaleOreGiorno += oreGiorno
                    dgwTMP(colonna, nRiga).Value = If(totaleOreGiorno > 0, totaleOreGiorno.ToString("N"), "")
                End If
                Dim scorporaNote As Object
                Dim DisposizioniFerie As String = ""
                If f.note.Length > 0 Then
                    scorporaNote = f.note.Split("#").Last
                    Dim id As Int32 = 0
                    Dim h As Boolean = Int32.TryParse(scorporaNote, id)
                    If h = False Then
                        If f.note = "Quindicinale" Then
                            quindicinale = Not quindicinale
                        End If
                    End If
                    Dim opzioneFerie() As DataRow
                    opzioneFerie = LeggendaFerie.Select("id = " & id)
                    DisposizioniFerie = opzioneFerie.First.Field(Of String)("descrizione")
                End If
#Disable Warning BC42104 ' La variabile 'tips' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
#Disable Warning BC42104 ' La variabile 'sSos' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
                tips += String.Format("{6}->{3} {0} - {1} = {2} {5}", f.ing.ToShortTimeString, f.usc.ToShortTimeString, oreGiorno, sSos, restituiscecolori(dtTipoOrario, idtip)(1), vbCrLf, DisposizioniFerie)
#Enable Warning BC42104 ' La variabile 'sSos' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
#Enable Warning BC42104 ' La variabile 'tips' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
#Disable Warning BC42104 ' La variabile 'Tag' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.
                Tag += String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}|{8}|", f.iddip, f.ing, f.usc, idDip, idSos, f.idcli, f.iddet, If(f.idrecupero = 0, -1, f.idrecupero), f.idtip)
#Enable Warning BC42104 ' La variabile 'Tag' è stata usata prima dell'assegnazione di un valore. È possibile che in fase di esecuzione venga restituita un'eccezione dovuta a un riferimento Null.

                dgwTMP(colonna, nRiga).Tag = Tag
                dgwTMP(colonna, nRiga).ToolTipText = tips

            Next
            dgwTMP.Rows.Add()
            nRiga = dgwTMP.Rows.Count - 1

            k1 = New DataGridViewCellStyle
            k1.ForeColor = Color.White
            k1.BackColor = Color.Gray
            k1.Font = New Font("Arial", 8, FontStyle.Regular)
            k1.Alignment = DataGridViewContentAlignment.MiddleCenter
            dgwTMP(0, nRiga).Value = gIdDet.Risultato.First.loc
            dgwTMP(0, nRiga).Style = k1
            For Each Giorno As DataRowView In bbCal
                Dim nColonna As Int16
                nColonna = Giorno.Row("giorno").day
                dgwTMP(nColonna, nRiga).Style = k1
            Next

            dgwTMP.Rows.Add()
            nRiga = dgwTMP.Rows.Count - 1

        Next
        Return dtUT

    End Function

End Class
Public Class ElaboraPresenze
    Public Shared Function CreaGriglieTimbratureRemote(ByVal kDat As DateTime, ByRef bbPresenzeRemote As BindingSource,
                                                       ByRef dgCosaElaboro As DataGridView, ByRef dgTotali As DataGridView,
                                                       ByRef bbTipologia As BindingSource, ByRef bbCal As BindingSource,
                                                       Optional ByVal conDettagli As Boolean = True,
                                                       Optional ByVal remotelocali As Boolean = True) As String()
        '
        '
        'Procedura per calcolare i valori giornalieri delle presenze Remote e metterli nella prima GRIGLIA
        '
        '
        Dim Totali_Dip_Cant(2) As String
        'Crea la tabella con le 31 celle più il nome della società

        For tmpd = 0 To kDat.Day + 1
            If remotelocali = False Then
                CreaDataGridTotali(tmpd, kDat, dgCosaElaboro, bbCal)   'Ridefinisce la Griglia dove inserirà  i dati
            Else
                CreaDataGridTotali(tmpd, kDat, dgCosaElaboro, bbCal, dgTotali)   'Ridefinisce la Griglia dove inserirà  i dati
            End If
        Next
        dgCosaElaboro.Rows.Clear()
        If remotelocali = False Then
        Else
            dgTotali.Rows.Clear()
        End If


        Dim Cli As DataTable
        Dim CliRaggruppata
        ' Test per inserire la griglia con i totali per cantiere selezionati dal dipendente

        If remotelocali = False Then
            Cli = CreaDataTableTotali(bbPresenzeRemote, "loc") 'Crea una dataTable con i dati da inserire nella Tabella
            Dim ClidaRag = Cli.AsEnumerable().GroupBy(Function(row) New With
                {Key .id_cli = row.Field(Of Int32)("id_cli"),
                Key .societa = row.Field(Of String)("societa"),
                Key .giorno = row.Field(Of Int32)("giorno")})

            CliRaggruppata = Cli.Clone() ' empty table with same columns
            For Each grp In ClidaRag
                CliRaggruppata.Rows.Add(grp.Key.id_cli, 0, 0, grp.Key.societa, "", "", grp.Key.giorno, grp.Sum(Function(row) row.Field(Of Decimal)("ore")))
            Next
        Else
            Cli = CreaDataTableTotali(bbPresenzeRemote, "web") 'Crea una dataTable con i dati da inserire nella Tabella
            If conDettagli Then
                Dim clidarag = Cli.AsEnumerable().GroupBy(Function(row) New With
                        {Key .id_cli = row.Field(Of Int32)("id_cli"),
                        Key .id_det = row.Field(Of Int32)("id_det"),
                        Key .societa = row.Field(Of String)("societa"),
                        Key .dettaglio = row.Field(Of String)("dettaglio"),
                        Key .giorno = row.Field(Of Int32)("giorno"),
                        Key .note = Trim(row.Field(Of String)("note")).ToLower(),
                        Key .tipo = row.Field(Of Int32)("id_tipo"),
                        Key .auto = row.Field(Of Int32)("auto"),
                        Key .iddip = row.Field(Of Int32)("id_dip")
                        })
                CliRaggruppata = Cli.Clone() ' empty table with same columns
                For Each grp In clidarag
                    CliRaggruppata.Rows.Add(grp.Key.id_cli, grp.Key.id_det, 0, "", grp.Key.dettaglio, grp.Key.societa, grp.Key.giorno, grp.Sum(Function(r1) r1.Field(Of Decimal)("ore")), grp.Key.note, grp.Key.tipo, grp.Key.auto)
                Next

            Else
                Dim ClidaRag = Cli.AsEnumerable().GroupBy(Function(row) New With
                    {Key .id_cli = row.Field(Of Int32)("id_cli"),
                    Key .id_det = row.Field(Of Int32)("id_det"),
                    Key .societa = row.Field(Of String)("societa"),
                    Key .dettaglio = row.Field(Of String)("dettaglio"),
                    Key .giorno = row.Field(Of Int32)("giorno"),
                    Key .note = Trim(row.Field(Of String)("note")).ToLower(),
                    Key .auto = row.Field(Of Int32)("auto"),
                    Key .iddip = row.Field(Of Int32)("id_dip")
                    })
                CliRaggruppata = Cli.Clone() ' empty table with same columns
                For Each grp In ClidaRag
                    CliRaggruppata.Rows.Add(grp.Key.id_cli, grp.Key.id_det, 0, "", grp.Key.dettaglio, grp.Key.societa, grp.Key.giorno, grp.Sum(Function(r1) r1.Field(Of Decimal)("ore")), grp.Key.note, 0, grp.Key.auto)
                Next

            End If

        End If




        'Ordina la tabella per cliente e Giorno
        Dim TabellaOrdinata As New DataTable
        TabellaOrdinata = OrdinaTabella(CliRaggruppata, "societa ,dettaglio, id_tipo, giorno")
        Dim OldID As Int32 'Codice Confronto per Cliente
        Dim OldTi As Int32 'Codice Contronto per Tipologia
        OldID = 0
        OldTi = -1
        Dim tOra As Decimal = 0
        Dim oGiorno As Integer = 0
        Dim PrimoDettaglioCliente As Integer = TabellaOrdinata.Rows(0).Field(Of Int32)("id_det")
        'Cicla la datatable e riempie la tabella
        Dim ora As Decimal = 0
        Dim DescTipo As String

        '
        ' Inizia a caricare la tabella delle presenze
        '
        If remotelocali Then

            For Each dtt As DataRow In TabellaOrdinata.Rows

                'Carica le ore e le somma alle precedenti
                ora += dtt.Field(Of Decimal)("ore")
                Dim tAnagrafica As String
                tAnagrafica = dtt.Field(Of String)("anagrafica")
                Dim note As String
                note = dtt.Field(Of String)("note")
                Dim idcli As Integer
                idcli = dtt.Field(Of Int32)("id_det")
                Dim idTip As Int16
                idTip = dtt.Field(Of Int32)("id_tipo")
                Dim tgiorno As Integer
                tgiorno = dtt.Field(Of Int32)("giorno")
                Dim tSocieta As String
                tSocieta = dtt.Field(Of String)("dettaglio")
                Dim auto As Int32
                auto = dtt.Field(Of Int32)("auto")
                'se cambia il cliente allora crea una nuova riga

                bbTipologia.Position = bbTipologia.Find("id_tipo", idTip)

                If bbTipologia.Position > -1 Then
                    DescTipo = DirectCast(bbTipologia.Current, DataRowView).Row("descrizione")
                Else
                    DescTipo = " "
                End If
                Dim PrimaCella As String
                If conDettagli Then
                    PrimaCella = CType(tSocieta & "-" & DescTipo.Substring(0, 5), String)
                Else
                    PrimaCella = CType(tSocieta & " (T)", String)
                End If
                Dim festivo As Integer = 0

                If tgiorno > 0 And tgiorno < kDat.Day Then
                    Dim f As DateTime = New Date(kDat.Year, kDat.Month, tgiorno)
                    bbCal.Position = bbCal.Find("giorno", f)
                    festivo = DirectCast(bbCal.Current, DataRowView).Row.Item("festivo")
                End If


                If idcli <> OldID Then  'SE è un nuovo cliente crea una nuova riga
                    'nuovo cliente azzera le ore e i totali
                    tOra = 0
                    ora = 0
                    OldID = dtt.Field(Of Int32)("id_det")
                    OldTi = dtt.Field(Of Int32)("id_tipo")
                    oGiorno = tgiorno
                    'Se il tipo è 2 (assente) allora non somma l'orario
                    ora = If(OldTi = 2, 0, dtt.Field(Of Decimal)("ore"))
                    tOra = ora
                    ' Crea la prima riga dove mette l'intestazione del dettaglio
                    AssegnaValoriTabellaWeb(dgCosaElaboro, True, 0, PrimaCella, "", festivo, idcli, 0, OldTi, auto)
                Else
                    If oGiorno <> tgiorno Then
                        'nuovo giorno azzera le ore e i totali
                        ora = 0
                        'tOra = 0
                        'Controlla che non sia Assente
                        ora = ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                        oGiorno = tgiorno
                    End If
                    If idTip <> OldTi Then  'Se è lo stesso cliente ma un nuovo Tipodi inserimento Crea una nuova riga
                        'nuovo tipo azzera le ore e i totali
                        ora = 0             ' azzera le ore
                        tOra = 0            ' azzera il totale righe ore
                        'Controlla che non sia Assente
                        ora = ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                        'imposta OldTi con il valore attuale
                        OldTi = dtt.Field(Of Int32)("id_tipo")
                        ' Crea la prima riga dove mette l'intestazione del dettaglio
                        AssegnaValoriTabellaWeb(dgCosaElaboro, True, 0, PrimaCella, "", festivo, idcli, 0, OldTi, auto)
                        AssegnaValoriTabellaWeb(dgCosaElaboro, False, tgiorno, ora, note, festivo, idcli, oGiorno, OldTi, auto)
                    Else
                        'ora = 0
                    End If
                    'Totale delle ore nella riga
                    tOra += ora
                End If
                ' Compila le varie celle del mese
                AssegnaValoriTabellaWeb(dgCosaElaboro, False, tgiorno, ora, note, festivo, idcli, oGiorno, OldTi, auto)
                ' Questo assegna il totale all'ultima cella della riga
                AssegnaValoriTabellaWeb(dgCosaElaboro, False, kDat.Day + 1, tOra, note, festivo, idcli, oGiorno, OldTi, 3)
            Next
            Dim Clidasommare = TabellaOrdinata.AsEnumerable().GroupBy(Function(row) New With
             {Key .giorno = row.Field(Of Int32)("giorno"),
             Key .tipo = row.Field(Of Int32)("id_tipo")})

            Dim Clisommata = Cli.Clone() ' empty table with same columns

            For Each grp In Clidasommare
                Dim ore As Decimal
                Dim tipo As Int32
                Dim giorno As Int32 = grp.Key.giorno
                Console.WriteLine(grp.Key.giorno & " " & grp.Key.tipo)
                tipo = grp.Key.tipo
                ore = grp.Sum(Function(row) row.Field(Of Decimal)("ore"))
                Clisommata.Rows.Add(0, 0, 0, "", "", "", grp.Key.giorno, ore, "", tipo)
            Next
            'Ordina la tabella per cliente e Giorno
            '******


            AssegnaRiepilogoGiorni(-1, -1, -1, "", "", -1, dgCosaElaboro)
            AssegnaRiepilogoGiorni(0, 0, kDat.Day, "..Totale Timbrato", "", -1, dgCosaElaboro)
            'Pubblica i parziali
            tOra = 0
            For Each dtt As DataRow In Clisommata.Rows
                Dim orx As Decimal = If(dtt.Field(Of Int32)("id_tipo") <> 2, dtt.Field(Of Decimal)("ore"), 0)
                tOra += orx
                Console.WriteLine("Giorno " & dtt.Field(Of Int32)("giorno") & " Ore " & orx.ToString & " Tipologia " & dtt.Field(Of Int32)("id_tipo"))
                AssegnaRiepilogoGiorni(dtt.Field(Of Int32)("giorno"), orx, kDat.Day, "", "", -1, dgCosaElaboro)
            Next
            AssegnaRiepilogoGiorni(kDat.Day + 1, tOra, kDat.Day, "..Totale Timbrato", "", -1, dgCosaElaboro)
            Totali_Dip_Cant(0) = tOra.ToString("N2")

        Else
            TabellaOrdinata = OrdinaTabella(CliRaggruppata, "societa ASC,id_tipo ASC, giorno ASC")

            For Each dtt As DataRow In TabellaOrdinata.Rows
                ora += dtt.Field(Of Decimal)("ore")
                Dim note As String
                note = dtt.Field(Of String)("note")
                Dim idcli As Integer
                idcli = dtt.Field(Of Int32)("id_cli")
                Dim tgiorno As Integer
                tgiorno = dtt.Field(Of Int32)("giorno")
                Dim tSocieta As String
                tSocieta = dtt.Field(Of String)("societa")
                'se cambia il cliente
                If OldID <> idcli Then
                    tOra = 0
                    ora = 0
                    ora += dtt.Field(Of Decimal)("ore")
                    oGiorno = tgiorno
                    ElaboraPresenze.AssegnaRiepilogoGiorni(0, tOra, kDat.Day, tSocieta, "", idcli, dgCosaElaboro)
                    'aggiunge il totale
                    tOra += ora
                    ElaboraPresenze.AssegnaRiepilogoGiorni(tgiorno, ora, kDat.Day, "", note, tgiorno, dgCosaElaboro)
                    'scrive il totale
                    ElaboraPresenze.AssegnaRiepilogoGiorni(kDat.Day + 1, tOra, kDat.Day, "", "", -1, dgCosaElaboro)
                    'aggiorna il codice ID de cliente
                    OldID = dtt.Field(Of Int32)("id_cli")
                Else
                    If oGiorno <> tgiorno Then
                        ora = 0
                        ora += dtt.Field(Of Decimal)("ore")
                        oGiorno = tgiorno
                    End If
                    tOra += ora
                    'memorizza il valore della cella nella data
                    ElaboraPresenze.AssegnaRiepilogoGiorni(tgiorno, ora, kDat.Day, "", note, tgiorno, dgCosaElaboro)
                    'aggiorna il totale della riga
                    ElaboraPresenze.AssegnaRiepilogoGiorni(kDat.Day + 1, tOra, kDat.Day, "", "", -1, dgCosaElaboro)
                End If
            Next
            Dim Clidasommare = TabellaOrdinata.AsEnumerable().GroupBy(Function(row) New With
                {Key .giorno = row.Field(Of Int32)("giorno")})
            Dim Clisommata = Cli.Clone() ' empty table with same columns
            For Each grp In Clidasommare
                Clisommata.Rows.Add(0, 0, 0, "", "", "", grp.Key.giorno, grp.Sum(Function(row) row.Field(Of Decimal)("ore")))
            Next
            'Ordina la tabella per cliente e Giorno
            '****************************************
            ElaboraPresenze.AssegnaRiepilogoGiorni(0, 0, kDat.Day, "Parziale", "", -2, dgCosaElaboro)
            'Pubblica i parziali
            tOra = 0
            For Each dtt As DataRow In Clisommata.Rows
                tOra += (dtt.Field(Of Decimal)("ore"))
                ElaboraPresenze.AssegnaRiepilogoGiorni(dtt.Field(Of Int32)("giorno"), dtt.Field(Of Decimal)("ore"), kDat.Day, "", "", -2, dgCosaElaboro)
            Next
            '******************************************
            ElaboraPresenze.AssegnaRiepilogoGiorni(kDat.Day + 1, tOra, kDat.Day, "Parziale", "", -2, dgCosaElaboro)
        End If

        '
        'Calcola i parziali e popola la tabella dei parziali
        '


        'Carica il dettaglio del primo cliente
        If remotelocali = False Then
        Else
            Dim testorisposta(1) As String
            testorisposta = caricaRaccoltaClienti(PrimoDettaglioCliente, dgTotali, kDat)
            Totali_Dip_Cant(1) = testorisposta(1)
            Totali_Dip_Cant(2) = testorisposta(0)
            Dim Larghezzacellamassima As Integer
            Larghezzacellamassima = (dgTotali.Width - 230) / (kDat.Day + 1)
            DimensioniGriglieWEB(Larghezzacellamassima, dgCosaElaboro, dgTotali)
        End If
        Return Totali_Dip_Cant
    End Function



    Private Shared Function DimensioniGriglieWEB(ByRef DimensioniCella As Integer, ByRef dgElaborata As DataGridView, ByRef dgTotale As DataGridView)

        For Each tmpCol As DataGridViewColumn In dgElaborata.Columns
            If tmpCol.Index = 0 Then
                dgElaborata.Columns(tmpCol.Index).Width = 170
                dgTotale.Columns(tmpCol.Index).Width = 170

            ElseIf tmpCol.Index = dgElaborata.Columns.Count - 1 Then
                dgElaborata.Columns(tmpCol.Index).Width = 50
                dgElaborata.Columns(tmpCol.Index).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
                dgTotale.Columns(tmpCol.Index).Width = 50
            Else
                dgElaborata.Columns(tmpCol.Index).Width = DimensioniCella
                dgTotale.Columns(tmpCol.Index).Width = DimensioniCella
            End If
        Next
        Return True
    End Function
    Private Shared Function ControllaOre(ByVal ora As Decimal, ByVal tipo As Int32) As Decimal
        If tipo <> 2 Then
            Return ora
        Else
            Console.WriteLine(ora)
            Return 0
        End If

    End Function

    Public Shared Function caricaRaccoltaClienti(ByVal idDet As Integer, ByRef dgTotali As DataGridView, ByVal kDat As DateTime) As String()    'Ritorna la frase per il filtro e il totale del dipendente

        With dgTotali
            .Rows.Clear()
            .AllowUserToAddRows = False
            .AllowUserToDeleteRows = False
        End With

        'Variabili che restituisce uno etichetta fiultro l'altra per il totale del cliente

        Dim Etichettarestituita As String = ""
        Dim RisultatoOttenuto(1) As String

        Dim CBSoreWeb As New BindingSource 'Crea una Binding per gestire i dati dei clienti

        Using cDT As New DS_clienti.DT_presenzeWEBDataTable
            Using cTA As New DS_clientiTableAdapters.TA_presenzeWEB
                cTA.FillByLocazionePeriodo(cDT, idDet, GlobalVarPOP.GPeriodo)
                CBSoreWeb.DataSource = cDT
            End Using
        End Using
        Dim CperD = ElaboraPresenze.CreaDataTableTotali(CBSoreWeb, "cliweb")
        Dim ClidaRag = CperD.AsEnumerable().GroupBy(Function(row) New With
        {Key .id_det = row.Field(Of Int32)("id_det"),
        Key .id_dip = row.Field(Of Int32)("id_dip"),
        Key .societa = row.Field(Of String)("societa"),
        Key .dettaglio = row.Field(Of String)("dettaglio"),
        Key .anagrafica = row.Field(Of String)("anagrafica"),
        Key .giorno = row.Field(Of Int32)("giorno"),
        Key .note = Trim(row.Field(Of String)("note")).ToLower(),
        Key .id_tipo = row.Field(Of Int32)("id_tipo")})

        Dim CliRaggruppata = CperD.Clone() ' empty table with same columns
        For Each grp In ClidaRag
            CliRaggruppata.Rows.Add(0, grp.Key.id_det, grp.Key.id_dip, grp.Key.societa, grp.Key.dettaglio, grp.Key.anagrafica, grp.Key.giorno, grp.Sum(Function(row) row.Field(Of Decimal)("ore")), grp.Key.note, grp.Key.id_tipo)
        Next
        'Ordina la tabella per cliente e Giorno
        Dim TabellaOrdinata As New DataTable
        TabellaOrdinata = OrdinaTabella(CliRaggruppata, "societa ASC,anagrafica ASC, id_tipo ASC, giorno ASC")
        Dim ttora As Decimal
        For Each dtt As DataRow In TabellaOrdinata.Rows
            ttora = dtt.Field(Of Decimal)("ore")
            Dim note As String
            note = dtt.Field(Of String)("note")
            Dim iddip As Integer
            iddip = dtt.Field(Of Int32)("id_dip")
            Dim tgiorno As Integer
            tgiorno = dtt.Field(Of Int32)("giorno")
            Dim tSocieta As String
            tSocieta = dtt.Field(Of String)("societa")
            Dim tDettaglio As String
            tDettaglio = dtt.Field(Of String)("dettaglio")
            Dim tAnagrafica As String
            tAnagrafica = dtt.Field(Of String)("anagrafica")
            Dim idTip As Integer
            idTip = dtt.Field(Of Int32)("id_tipo")
        Next
        Dim OldID As Integer
        OldID = 0
        Dim tora As Decimal = 0
        Dim oGiorno As Integer = 0
        'Cicla la datatable e riempie la tabella
        Dim ora As Decimal = 0
        Dim oldNota As String = ""
        For Each dtt As DataRow In TabellaOrdinata.Rows
            ora += dtt.Field(Of Decimal)("ore")
            Dim note As String
            note = dtt.Field(Of String)("note")
            Dim iddip As Integer
            iddip = dtt.Field(Of Int32)("id_dip")
            Dim tgiorno As Integer
            tgiorno = dtt.Field(Of Int32)("giorno")
            Dim tSocieta As String
            tSocieta = dtt.Field(Of String)("societa")
            Dim tDettaglio As String
            tDettaglio = dtt.Field(Of String)("dettaglio")
            Dim tAnagrafica As String
            tAnagrafica = dtt.Field(Of String)("anagrafica")
            Dim idTip As Integer
            idTip = dtt.Field(Of Int32)("id_tipo")

            'se cambia il dipendente
            Select Case True
                Case OldID <> iddip
                    tora = 0
                    ora = 0
                    'If idTip <> 2 Then
                    ora = ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                    'Else
                    'ora = -1
                    'End If
                    oGiorno = tgiorno
                    AssegnaRiepilogoGiorni(0, tora, kDat.Day, tAnagrafica, "", 0, dgTotali, iddip)
                    'aggiunge il totale
                    tora += ora
                    AssegnaRiepilogoGiorni(tgiorno, ora, kDat.Day, "", note, tgiorno, dgTotali)
                    'scrive il totale in fondo alla griglia
                    AssegnaRiepilogoGiorni(kDat.Day + 1, tora, kDat.Day, "", "", -1, dgTotali)
                    'aggiorna il codice ID del cliente
                    OldID = dtt.Field(Of Int32)("id_dip")
                    oldNota = note
                Case oGiorno <> tgiorno
                    'Qui controlla che non cambia il giorno
                    ora = 0
                    ora += ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                    oGiorno = tgiorno
                    AssegnaRiepilogoGiorni(tgiorno, ora, kDat.Day, "", note, tgiorno, dgTotali)
                    'aggiorna il totale della riga
                    AssegnaRiepilogoGiorni(kDat.Day + 1, tora, kDat.Day, "", "", -1, dgTotali)
                Case note <> oldNota ' And note <> ""'Qui controlla se cambiano le note
                    ora = 0
                    ora += ControllaOre(dtt.Field(Of Decimal)("ore"), idTip)
                    'oGiorno = tgiorno
                    oldNota = note
                    tora += ora
                    'memorizza il valore della cella nella data
                    AssegnaRiepilogoGiorni(tgiorno, ora, kDat.Day, "", note, tgiorno, dgTotali)
                    'aggiorna il totale della riga
                    AssegnaRiepilogoGiorni(kDat.Day + 1, tora, kDat.Day, "", "", -1, dgTotali)

            End Select
            Etichettarestituita = "Riepilogo per:  " & tSocieta & " dettaglio cantiere: " & tDettaglio
        Next
        'Calcola i parziali
        Dim Clidasommare = TabellaOrdinata.AsEnumerable().GroupBy(Function(row) New With
            {Key .giorno = row.Field(Of Int32)("giorno"),
            Key .tipo = row.Field(Of Int32)("id_tipo"),
            Key .note = row.Field(Of String)("note")
            })

        Dim TotGiornaliero = TabellaOrdinata.AsEnumerable().GroupBy(Function(row) New With
            {Key .giorno = row.Field(Of Int32)("giorno"),
            Key .tipo = row.Field(Of Int32)("id_tipo")
            })

        Dim n = Clidasommare.Count


        Dim Clisommata = CperD.Clone() ' empty table with same columns

        For Each grp In TotGiornaliero 'Clidasommare 
            Dim ore As Decimal
            Dim tipo As Int32
            Dim giorno As Int32 = grp.Key.giorno
            tipo = grp.Key.tipo
            Dim note As String = "" 'grp.Key.note
            ore = grp.Sum(Function(row) row.Field(Of Decimal)("ore"))
            Clisommata.Rows.Add(0, 0, 0, "", "", "", grp.Key.giorno, ore, note, tipo)
        Next
        Dim CliSommataOrdinata As New DataTable
        CliSommataOrdinata = OrdinaTabella(Clisommata, "giorno ASC, id_tipo ASC")

        'Ordina la tabella per cliente e Giorno
        AssegnaRiepilogoGiorni(-1, -1, -1, "", "", -2, dgTotali)
        AssegnaRiepilogoGiorni(0, 0, kDat.Day, "Totale Cliente", "", -2, dgTotali)
        'Pubblica i parziali

        Dim rp_note As String               'Note

        Dim rp_tipo As Integer
        Dim rp_ore As Decimal = 0   'Rapporto Ore
        Dim rp_giorno As Integer   ' Giorno e nuova Tipologia
        Dim oNota As String = ""
        Dim oTipo As Integer = 0
        tora = 0
        oGiorno = 0

        For Each dtt As DataRow In CliSommataOrdinata.Rows
            rp_tipo = dtt.Field(Of Int32)("id_tipo")
            rp_giorno = dtt.Field(Of Int32)("giorno")
            rp_note = dtt.Field(Of String)("note")
            rp_ore += ControllaOre(dtt.Field(Of Decimal)("ore"), rp_tipo)
            If oGiorno <> rp_giorno Then      'Qui controlla che non cambia il giorno
                rp_ore = ControllaOre(dtt.Field(Of Decimal)("ore"), rp_tipo)
                oGiorno = rp_giorno
            End If
            If oTipo <> rp_tipo Then
                rp_ore = ControllaOre(dtt.Field(Of Decimal)("ore"), rp_tipo)
                oTipo = rp_tipo
            End If
            AssegnaRiepilogoGiorni(rp_giorno, rp_ore, kDat.Day, "", "", -1, dgTotali)
            tora += rp_ore
        Next

        AssegnaRiepilogoGiorni(kDat.Day + 1, tora, kDat.Day, "Parziali", "", -2, dgTotali)

        RisultatoOttenuto(0) = Etichettarestituita
        RisultatoOttenuto(1) = tora.ToString("N2")

        Return RisultatoOttenuto


    End Function


    Public Shared Function AssegnaValoriTabellaWeb(ByRef TMPDG As DataGridView,
                                                ByVal Nuova As Boolean,
                                                ByVal Colonna As Int32,
                                                ByVal Valore As Object, ByVal Valore1 As Object,
                                                   ByVal festivo As Int16,
                                                Optional ByVal ID1 As Int32 = Nothing,
                                                Optional ByVal ID2 As Int32 = Nothing,
                                                Optional ByVal ID3 As Int32 = Nothing,
                                                Optional ByVal auto As Int32 = 0)
        'TMPDG è la griglia alla quale assegnare i valori
        'Nuova:     indica se deve aggiungere una nuova riga
        'Colonna:   
        Dim dw As String() = New String() {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
        Dim cc As ColoriDettaglio = New ColoriDettaglio()

        If Nuova = True Then
            TMPDG.Rows.Add()
        End If

        Dim ultimariga As Integer
        ultimariga = TMPDG.Rows.Count - 1

        Dim CSfondo As Color = TMPDG(Colonna, ultimariga).Style.BackColor
        Dim CScritta As Color = TMPDG(Colonna, ultimariga).Style.ForeColor
        Dim StileAllineamento As DataGridViewContentAlignment = TMPDG(Colonna, ultimariga).Style.Alignment

        Dim StileCarattere As Font = New Font("Arial", 8, FontStyle.Regular)
        Dim NTag As Integer = 0
        Dim SToolTips As String = ""


        If ID1 > 0 Then  'Se esiste il Primo ID (Cliente)
            NTag = ID1
        End If
        If ID2 > 0 Then  'Se esiste il Primo ID (Dipendente)
            NTag = ID2
        End If


        Dim ValoreConvertibile As IConvertible = TryCast(Valore, IConvertible)
        Dim strValore As String = ""
        Select Case ValoreConvertibile.GetTypeCode()
            Case TypeCode.Decimal
                strValore = Format(Valore, "#0.00#")
                StileAllineamento = DataGridViewContentAlignment.MiddleCenter
            Case TypeCode.String
                strValore = Valore
                StileAllineamento = DataGridViewContentAlignment.MiddleLeft
        End Select


        Dim strValore1 As String = CType(Valore1, String)

        TMPDG(Colonna, ultimariga).Tag = NTag
        TMPDG(Colonna, ultimariga).Value = strValore
        If Colonna > 0 Then
            Select Case True
#Disable Warning BC42025 ' L'accesso del membro condiviso, del membro costante, del membro di enumerazione o del tipo nidificato verrà effettuato tramite un'istanza
                Case auto = 3

                Case auto = 1 And ID3 = 2                   ' Se è inviato ed è assente
                    CSfondo = cc.XTrAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AA"
                    TMPDG(Colonna, ultimariga).ToolTipText = strValore
                Case auto = 1 And strValore1.Length > 0 And ID3 = 2 ' Se è con nota ed è stato inviato ed è assente
                    CSfondo = cc.XTrNoteAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AN"
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips

                Case auto = 1 And strValore1.Length > 0     ' Se è presente una nota ed è stato inviato
                    SToolTips = "Trasportato " & Valore1
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                    CSfondo = cc.XTrNote
                    CScritta = Color.White
                Case auto = 1                               ' se è stato solo inviato
                    CSfondo = cc.XTraPres
                    CScritta = Color.White
                    '
                    'Qui iniziano a delinearsi gli inserimenti non inviati
                    '
                Case auto = 0 And strValore1.Length > 0 And ID3 = 2 ' note e assente
                    CSfondo = cc.NorNoteAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AN"
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                Case auto = 0 And ID3 = 2 ' assente
                    CSfondo = cc.NorAss
                    CScritta = Color.Black
                    TMPDG(Colonna, ultimariga).Value = "AA"
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips

                Case auto = 0 And strValore1.Length > 0 ' Note
                    SToolTips = Valore1
                    TMPDG(Colonna, ultimariga).ToolTipText = SToolTips
                    TMPDG(Colonna, ultimariga).Value = "" & strValore
                    CSfondo = cc.NorNote
                    CScritta = Color.White
                Case Else
#Enable Warning BC42025 ' L'accesso del membro condiviso, del membro costante, del membro di enumerazione o del tipo nidificato verrà effettuato tramite un'istanza
            End Select
            If festivo = 1 Then
                TMPDG(Colonna, ultimariga).Style.BackColor = Color.CadetBlue
            End If
        End If

        TMPDG(Colonna, ultimariga).Style.ForeColor = CScritta
        TMPDG(Colonna, ultimariga).Style.BackColor = CSfondo
        TMPDG(Colonna, ultimariga).Style.Font = StileCarattere
        TMPDG(Colonna, ultimariga).Style.Alignment = StileAllineamento
        Return True
    End Function
    Public Shared Sub AssegnaRiepilogoGiorni(ByVal cella As Integer, ByVal totale As Decimal,
                                             ByVal giorni As Integer, ByVal societa As String,
                                             ByVal note As String, ByVal idcli As Integer,
                                             ByRef DG_tmp As DataGridView,
                                             Optional ByVal iddip As Integer = 0,
                                             Optional ByVal idTipo As Integer = Nothing)

        'procedura per scrivere i valori nelle singole celle chiamate cella
        Dim dw As String() = New String() {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}

        Dim ultimariga As Integer
        Dim colo As Color
        Dim Tipo As Integer
        ultimariga = DG_tmp.Rows.Count - 1
        If idTipo = Nothing Then
            Tipo = 1
        Else
            Tipo = idTipo
        End If
        'colo = DG_tmp(0, ultimariga).Style.BackColor
        Try

            'If nuovariga = True Then
            If cella = -1 And totale = -1 And giorni = -1 Then
                DG_tmp.Rows.Add()
                colo = DG_tmp(0, ultimariga).Style.BackColor
                DG_tmp.Rows(DG_tmp.Rows.Count - 1).Height = 2
                For CC = 1 To DG_tmp.Columns.Count
                    DG_tmp(CC, DG_tmp.Rows.Count - 1).Style.BackColor = Color.Black
                Next
                Return
            End If
            'ultimariga = DG_tmp.Rows.Count - 1
            If DG_tmp(0, ultimariga).Tag = -2 Then
                colo = Color.LightGoldenrodYellow
                For CC = 0 To DG_tmp.Columns.Count - 1
                    DG_tmp(CC, ultimariga).Style.BackColor = colo
                Next
            Else
                colo = DG_tmp(0, ultimariga).Style.BackColor
            End If
        Catch ex As Exception

        End Try

        If cella = 0 Then
            DG_tmp.Rows.Add()
            ultimariga = DG_tmp.Rows.Count - 1
            If societa.Length > 0 Then
                DG_tmp(cella, ultimariga).Value = societa
                DG_tmp(cella, ultimariga).Tag = idcli
                DG_tmp(cella, ultimariga).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                DG_tmp(cella, ultimariga).Style.Font = New Font("Arial", 8, FontStyle.Regular)
                DG_tmp(cella, ultimariga).Style.BackColor = colo
            End If
        ElseIf cella > 0 And cella <= giorni Then
            'Se esiste un valore da pubblicare
            If totale > 0 Then
                ultimariga = DG_tmp.Rows.Count - 1
                Dim valorecella = DG_tmp(cella, ultimariga).Value
                Dim valorePrecedente As Decimal = 0
                Dim risultato As Boolean = Decimal.TryParse(valorecella, valorePrecedente)
                Dim ncarat
                Dim strtot
                strtot = Format(totale + valorePrecedente, "#0.00#")
                ncarat = strtot.Length
                DG_tmp(cella, ultimariga).Value = strtot
                If idcli > 0 Then
                    DG_tmp(cella, ultimariga).Tag = idcli
                Else
                    DG_tmp(cella, ultimariga).Tag = iddip
                End If
                If note <> Nothing Then
                    DG_tmp(cella, ultimariga).Style.ForeColor = Color.White
                    DG_tmp(cella, ultimariga).Style.BackColor = Color.DarkRed
                    DG_tmp(cella, ultimariga).Style.Font = New Font("Arial", 8, FontStyle.Regular)
                    DG_tmp(cella, ultimariga).ToolTipText = note
                Else
                    If Tipo > 0 Then
                        DG_tmp(cella, ultimariga).Style.Alignment = DataGridViewContentAlignment.MiddleLeft
                        DG_tmp(cella, ultimariga).Style.Font = New Font("Arial", 8, FontStyle.Regular)
                        DG_tmp(cella, ultimariga).Style.ForeColor = Color.DarkRed
                        DG_tmp(cella, ultimariga).Style.BackColor = colo
                    Else
                        DG_tmp(cella, ultimariga).Style.Font = New Font("Arial", 8, FontStyle.Regular)
                        DG_tmp(cella, ultimariga).Style.ForeColor = Color.Transparent
                        DG_tmp(cella, ultimariga).Style.BackColor = colo
                    End If
                End If
            Else
                DG_tmp(cella, ultimariga).Style.Font = New Font("Arial", 8, FontStyle.Regular)
                DG_tmp(cella, ultimariga).Style.BackColor = colo
            End If
        ElseIf cella > giorni Then
            Dim strtot = Format(totale, "#0.00#")
            Dim ncarat = strtot.Length
            ultimariga = DG_tmp.Rows.Count - 1
            DG_tmp(cella, ultimariga).Value = IIf(totale > 0, strtot, "")
            DG_tmp(cella, ultimariga).Style.Alignment = DataGridViewContentAlignment.MiddleRight
            DG_tmp(cella, ultimariga).Style.Font = New Font("Arial", 8, FontStyle.Regular)
            DG_tmp(cella, ultimariga).Style.BackColor = colo
        End If

    End Sub


    Public Shared Function CreaDataTableTotali(ByRef BStmp As BindingSource, ByVal tiporiga As String) As DataTable
        Dim Cli
        Cli = New DataTable
        Cli.Namespace = "TabellaClienti"
        Dim CliRow As DataRow
        Dim colonna As DataColumn
        colonna = New DataColumn
        colonna.ColumnName = "id_cli"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_det"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_dip"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "societa"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "dettaglio"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "anagrafica"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "giorno"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "ore"
        colonna.DataType = Type.GetType("System.Decimal")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "note"
        colonna.DataType = Type.GetType("System.String")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "id_tipo"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)
        colonna = New DataColumn
        colonna.ColumnName = "auto"
        colonna.DataType = Type.GetType("System.Int32")
        Cli.Columns.Add(colonna)

        Dim RGweb As DS_utenti.DT_presenzeWEBRow
        Dim RGloc As DS_utenti.DT_contoreRow
        Dim RGcli As DS_clienti.DT_presenzeWEBRow

        For Each hg In BStmp
            CliRow = Cli.NewRow
            If tiporiga = "web" Then
                RGweb = DirectCast(hg, DataRowView).Row
                CliRow("id_cli") = RGweb.id_terminale
                CliRow("id_det") = RGweb.id_locazione
                CliRow("id_dip") = RGweb.id_utente
                CliRow("dettaglio") = RGweb.locazione
                CliRow("societa") = RGweb.societa
                CliRow("anagrafica") = RGweb.anagrafica
                CliRow("giorno") = RGweb.giorno.Day
                Dim Ore As New TimeSpan
                If RGweb.orario = " " Then
                    RGweb.orario = 0
                End If
                Ore = TimeSpan.Parse(RGweb.orario.ToString)
                CliRow("ore") = Ore.TotalHours
                CliRow("note") = RGweb.note
                CliRow("id_tipo") = RGweb.inviato
                CliRow("auto") = RGweb._auto
                Cli.Rows.Add(CliRow)
            ElseIf tiporiga = "cliweb" Then
                RGcli = DirectCast(hg, DataRowView).Row
                CliRow("id_cli") = RGcli.id_terminale
                CliRow("id_det") = RGcli.id_locazione
                CliRow("id_dip") = RGcli.id_utente
                CliRow("societa") = RGcli.societa
                CliRow("dettaglio") = RGcli.locazione
                CliRow("anagrafica") = RGcli.anagrafica
                CliRow("giorno") = RGcli.giorno.Day
                Dim Ore As New TimeSpan
                If RGcli.orario = " " Then
                    RGcli.orario = 0
                End If
                Ore = TimeSpan.Parse(RGcli.orario.ToString)
                CliRow("ore") = Ore.TotalHours
                CliRow("note") = RGcli.note
                CliRow("id_tipo") = RGcli.inviato
                Cli.Rows.Add(CliRow)
            ElseIf tiporiga = "loc" Then
                RGloc = DirectCast(hg, DataRowView).Row
                CliRow("id_cli") = RGloc.id_cli
                CliRow("id_det") = RGloc.id_dest
                CliRow("id_dip") = RGloc.id_dip
                CliRow("societa") = RGloc.locazione
                CliRow("anagrafica") = RGloc.anagrafica
                CliRow("dettaglio") = RGloc.locazione
                CliRow("giorno") = RGloc.data.Day
                CliRow("ore") = RGloc.ore
                CliRow("note") = RGloc.note
                CliRow("id_tipo") = RGloc.id_tipo
                Cli.Rows.Add(CliRow)
            End If

        Next
        Return Cli
    End Function

    Public Shared Sub CreaDataGridTotali(ByVal cella As Integer, ByVal dataAnalisi As DateTime,
                                         ByRef dgCosaElaboro As DataGridView,
                                         ByRef bbCal As BindingSource,
                                         Optional ByRef dgTotale As DataGridView = Nothing)
        'Funzione che crea i riepilogo delle ore e li carica nel DG

        Dim Larghezzacellamassima As Integer
        If cella > 0 Then
            Larghezzacellamassima = (dgCosaElaboro.Width - 173) / (dataAnalisi.Day - 1)
        End If
        dgCosaElaboro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None
        'Dim larghezzacella As Integer = 50
        Dim dw As String() = New String() {"Domenica", "Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato"}
        Dim tmp_data As DateTime
        Dim tmp_day As Integer = cella  'Valore giorno (da 0 a massimogiorno mese)

        Dim ultimogiorno As Integer = dataAnalisi.Day
        Dim festivo As Int16 = 0
        If cella > 0 And cella <= ultimogiorno Then
            tmp_data = DateSerial(dataAnalisi.Year, dataAnalisi.Month, cella)
            bbCal.Position = bbCal.Find("giorno", tmp_data)
            festivo = DirectCast(bbCal.Current, DataRowView).Row.Item("festivo")
        End If
        Dim DG_tmp As DataGridView = Nothing
        Dim DG_tmp2 As DataGridView = Nothing
        DG_tmp2 = dgTotale
        DG_tmp = dgCosaElaboro

        Dim CelObj As String
        CelObj = "C" & cella
        Dim DGCol As DataGridViewColumn
        DGCol = CType(DG_tmp.Columns(CelObj), DataGridViewColumn)
        If IsNothing(DGCol) Then
            Dim col As New DataGridViewRolloverCellColumn()
            Dim Col2 As New DataGridViewRolloverCellColumn()
            Select Case True
                Case cella = 0
                    'larghezzacella = 170
                    With col
                        .DefaultCellStyle.Font = New Font("Arial", 8, FontStyle.Regular)
                        .HeaderText = "Cliente"
                        .Width = 285
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
                    With Col2
                        .HeaderText = "Dipendente"
                        .Width = 285
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
                Case cella > 0 And cella <= ultimogiorno
                    With col
                        .HeaderText = dw(tmp_data.DayOfWeek).Substring(0, 1) & " " & tmp_day.ToString.PadLeft(2, "0")
                        .Width = Larghezzacellamassima
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella


                    End With
                    With Col2
                        .HeaderText = dw(tmp_data.DayOfWeek).Substring(0, 1) & " " & tmp_day.ToString.PadLeft(2, "0")
                        .Width = Larghezzacellamassima
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
                Case cella > ultimogiorno
                    Larghezzacellamassima = 40
                    With col
                        .HeaderText = "Totale"
                        .Width = Larghezzacellamassima + 10
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
                    With Col2
                        .HeaderText = "Totale"
                        .Width = Larghezzacellamassima + 10
                        .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
                        .Name = "C" & cella
                    End With
            End Select
            DG_tmp.Columns.Add(col)
            If festivo = 1 Then
                DG_tmp.Columns("C" & cella).HeaderText = "FS " & tmp_day.ToString.PadLeft(2, "0")
                DG_tmp.Columns("C" & cella).DefaultCellStyle.BackColor = Color.CadetBlue
            End If
            If DG_tmp2 Is Nothing Then
            Else
                DG_tmp2.Columns.Add(Col2)
                If festivo = 1 Then
                    DG_tmp.Columns("C" & cella).HeaderText = "FS " & tmp_day.ToString.PadLeft(2, "0")
                    DG_tmp.Columns("C" & cella).DefaultCellStyle.BackColor = Color.CadetBlue
                End If
            End If

        Else
            Select Case True
                Case cella > 0 And cella <= ultimogiorno
                    DG_tmp.Columns("C" & cella).HeaderText = dw(tmp_data.DayOfWeek).Substring(0, 1) & " " & tmp_day.ToString.PadLeft(2, "0")
                    If festivo = 1 Then
                        DG_tmp.Columns("C" & cella).HeaderText = "FS " & tmp_day.ToString.PadLeft(2, "0")
                        DG_tmp.Columns("C" & cella).DefaultCellStyle.BackColor = Color.CadetBlue
                    End If
            End Select
        End If
    End Sub

End Class
Public Class ColoriDettaglio
    Public Shared Property Totale As Color
        Get
            Totale = Color.Orange
        End Get
        Set(value As Color)

        End Set
    End Property

    Public Shared Property Parziale As Color
        Get
            Parziale = Color.LightCoral
        End Get
        Set(value As Color)

        End Set
    End Property
    Public Shared Property NorAss As Color
        Get
            NorAss = Color.DeepSkyBlue
        End Get
        Set(value As Color)

        End Set
    End Property
    Public Shared Property NorNote As Color
        Get
            NorNote = Color.DarkBlue
        End Get
        Set(value As Color)

        End Set
    End Property

    Public Shared Property NorNoteAss As Color
        Get
            NorNoteAss = Color.LightBlue
        End Get
        Set(value As Color)

        End Set
    End Property

    Public Shared Property XTraPres As Color
        Get
            XTraPres = Color.LightCoral
        End Get
        Set(value As Color)

        End Set
    End Property
    Public Shared Property XTrAss As Color
        Get
            XTrAss = Color.OrangeRed
        End Get
        Set(value As Color)

        End Set
    End Property
    Public Shared Property XTrNote As Color
        Get
            XTrNote = Color.Red
        End Get
        Set(value As Color)

        End Set
    End Property

    Public Shared Property XTrNoteAss As Color
        Get
            XTrNoteAss = Color.MediumVioletRed
        End Get
        Set(value As Color)

        End Set
    End Property

End Class


#Enable Warning CA1707 ' Gli identificatori non devono contenere caratteri di sottolineatura