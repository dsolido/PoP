Imports System
Imports System.Linq
Imports System.Data
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Reflection

Public Class PresenzeWeb

    Public Function CreaTabellaPresenze(ByVal oldPresenzaWeb As DataTable, ByVal periodo As DateTime) As DataTable

        If IsDBNull(oldPresenzaWeb) Then
            Return (Nothing)
        End If

        'tmpPresenze = DirectCast(oldPresenzaWeb, DataTable)


        If oldPresenzaWeb.Rows.Count = Nothing Then

        End If

        Dim result = oldPresenzaWeb.AsEnumerable().Select(Function(row) New With
            {
                Key .id = row.Field(Of Int32)("id"),
                Key .idcli = row.Field(Of Int32)("id_terminale"),
                Key .iddet = row.Field(Of Int32)("id_locazione"),
                Key .iddip = row.Field(Of Int32)("id_utente"),
                Key .societa = row.Field(Of String)("societa"),
                Key .dettaglio = row.Field(Of String)("locazione"),
                Key .anagrafica = row.Field(Of String)("anagrafica"),
                Key .giorno = row.Field(Of DateTime)("giorno"),
                Key .idtip = row.Field(Of Int32)("inviato"),
                Key .tipologia = row.Field(Of String)("descrizione"),
                Key .oretotali = row.Field(Of TimeSpan)("uscita").TotalHours - row.Field(Of TimeSpan)("ingresso").TotalHours
                }).OrderBy(Function(a) a.iddet).ThenBy(Function(a) a.giorno).ThenBy(Function(a) a.iddip).ToList()

        Dim soloPresenti = oldPresenzaWeb.AsEnumerable().GroupBy(Function(row) New With
            {
                Key .idcli = row.Field(Of Int32)("id_terminale"),
                Key .iddet = row.Field(Of Int32)("id_locazione"),
                Key .iddip = row.Field(Of Int32)("id_utente"),
                Key .idtip = row.Field(Of Int32)("inviato"),
                Key .societa = row.Field(Of String)("societa"),
                Key .dettaglio = row.Field(Of String)("locazione"),
                Key .anagrafica = row.Field(Of String)("anagrafica"),
                Key .tipologia = row.Field(Of String)("descrizione"),
                Key .giorno = row.Field(Of DateTime)("giorno")
            }).Select(Function(riga) New With
                {Key .idcli = riga.Key.idcli,
                Key .iddet = riga.Key.iddet,
                Key .iddip = riga.Key.iddip,
                Key .idtip = riga.Key.idtip,
                Key .societa = riga.Key.societa,
                Key .dettaglio = riga.Key.dettaglio,
                Key .anagrafica = riga.Key.anagrafica,
                Key .tipologia = riga.Key.tipologia,
                Key .giorno = riga.Key.giorno
            }).ToList()

        Dim elencopresenti As DataTable = ToDataTable(soloPresenti.ToList())
        Dim newPresenze As DataTable = ToDataTable(result.ToList())
        '    //
        '    // Imposta la nuova DataTable dove depositare le ore
        '    //
        Dim dtNewOre As DS_utenti.DTpresenzeWEBtemporaneeDataTable = New DS_utenti.DTpresenzeWEBtemporaneeDataTable()
        'Dim rwTmpOre As DS_utenti.DTpresenzeWEBtemporaneeRow '= New DS_utenti.DTpresenzeWEBtemporaneeRow()
        Dim rwNewOre As DataRow
        Dim rid_Cli As Int32
        'Dim ridcli As Int32
        Dim rid_Des As Int32
        'Dim riDdes As Int32
        Dim rid_Dip As Int32
        'Dim riDdip As Int32
        Dim rid_Tip As Int32
        'Dim ridTip As Int32

        For Each rgPresenzeByLocazione In soloPresenti
            rwNewOre = dtNewOre.NewRow()
            rid_Cli = rgPresenzeByLocazione.idcli
            rwNewOre("id_cli") = rid_Cli
            rid_Des = rgPresenzeByLocazione.iddet
            rwNewOre("id_des") = rid_Des
            rid_Dip = rgPresenzeByLocazione.iddip
            rwNewOre("id_dip") = rid_Dip
            rid_Tip = rgPresenzeByLocazione.idtip
            '
            'rwNewOre("id_tip") = rid_Tip
            rwNewOre("societa") = rgPresenzeByLocazione.societa

            rwNewOre("dettaglio") = rgPresenzeByLocazione.dettaglio
            rwNewOre("anagrafica") = rgPresenzeByLocazione.anagrafica
            'rwNewOre("tipologia") = rgPresenzeByLocazione.tipologia
            '        // Assegnare la data

            rwNewOre("periodo") = periodo
            dtNewOre.AddDTpresenzeWEBtemporaneeRow(rwNewOre)

        Next
        Return dtNewOre
    End Function

    Public Shared Function ToDataTable(Of T)(ByRef data As IList(Of T)) As DataTable

        'Dim g = TypeOf
        Dim props As PropertyDescriptorCollection = TypeDescriptor.GetProperties(GetType(T))

        Dim table As DataTable = New DataTable()
        Dim Propiedad As Type
        For i = 0 To props.Count - 1
            Dim prop As PropertyDescriptor = props(i)
            Propiedad = prop.PropertyType
            If Propiedad.IsGenericType AndAlso Propiedad.GetGenericTypeDefinition() = GetType(Nullable) Then
                Propiedad = Nullable.GetUnderlyingType(Propiedad)
            End If
            table.Columns.Add(prop.Name, Propiedad)
        Next
        Dim values(props.Count - 1) As Object
        For Each item As T In data
            For i = 0 To values.Length - 1
                values(i) = props(i).GetValue(item)
            Next
            table.Rows.Add(values)
        Next
        Return table

    End Function

End Class


