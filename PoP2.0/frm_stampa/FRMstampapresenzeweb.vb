Public Class FRMstampapresenzeweb
    Protected Friend IDdip As Integer
    Protected Friend SPeriodo As String
    'Protected Friend ColonneComplete As Integer = 33
    Protected Friend D_set() As String = {"Do", "Lu", "Ma", "Me", "Gi", "Ve", "Sa"}
    Dim DT As New DS_utenti.DTtotalepresenzeWEBtemporaneaDataTable
    Public Sub New(ByVal _Periodo As String, ByVal _id As Integer)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        SPeriodo = _Periodo
        IDdip = _id
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    Private Sub FRMstampapresenzeweb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenereDataRow()
        BStotali.DataSource = DT
        Me.ReportViewer1.RefreshReport()
    End Sub
    ' Genera la riga della Tabella da stampare per le presenze remote
    Private Sub GenereDataRow()
        Dim RGtot As DS_utenti.DTtotalepresenzeWEBtemporaneaRow

        Using rg_dest As New DS_utentiTableAdapters.TA_presenzeWEB
            Using dtPW, dtuqPW As New DS_utenti.DT_presenzeWEBDataTable
                Dim id_dip As Integer = IDdip
                'cicla le presenze per destinatario
                rg_dest.FillByutenteperiodo(dtPW, SPeriodo, id_dip)   'Carica la tabella delle presenze per il dip nel periodo
                rg_dest.FillByDipendentePeriodo(dtuqPW, id_dip, SPeriodo)

                If dtuqPW.Rows.Count = 0 Then
                    Return
                End If

                Dim ttTMP(31) As Decimal
                For Each rgdest As DataRow In dtuqPW.Rows
                    RGtot = DT.NewRow()
                    RGtot.id_des = rgdest("id_locazione")
                    RGtot.id_cli = rgdest("id_terminale")
                    RGtot.id_dip = rgdest("id_utente")
                    RGtot.anagrafica = rgdest("anagrafica")
                    RGtot.dettaglio = rgdest("locazione")
                    RGtot.societa = rgdest("societa")
                    Dim aMese As String() = New String() {"Gennaio", "Febbraio", "Marzo", "Aprile", "Maggio", "Giugno", "Luglio", "Agosto", "Settembre", "Ottobre", "Novembre", "Dicembre"}
                    RGtot.periodo = aMese(SPeriodo.Substring(5, 2) - 1) & " - " & SPeriodo.Substring(0, 4)
                    For j = 1 To 31
                        Dim sMese As String = SPeriodo.Substring(5, 2)
                        Dim sAnno As String = SPeriodo.Substring(0, 4)
                        Dim Umese As DateTime = DateAdd("m", 1, DateSerial(sAnno, sMese, 0))
                        If j <= Umese.Day Then
                            Dim dAccesso As DateTime = DateTime.Parse(j.ToString & "-" & sMese & "-" & sAnno)
                            Dim sGiorno As String = dAccesso.Day.ToString().PadLeft(2, "0") & D_set(dAccesso.DayOfWeek).Substring(0, 1)
                            RGtot("s" & j.ToString()) = sGiorno
                        Else
                            RGtot("s" & j.ToString()) = ""
                        End If
                    Next
                    Dim filtro As String = String.Format("id_locazione = {0}", rgdest("id_locazione"))
                    Dim righetrovate() As DataRow

                    righetrovate = dtPW.Select(filtro)
                    Dim nTMP(31) As Decimal   'Totale singola colonna
                    For Each RGrealizzate As DataRow In righetrovate
                        Dim Colonna As DateTime = DateTime.Parse(RGrealizzate("giorno"))
                        Dim Ore As TimeSpan
                        If Not Trim(RGrealizzate("orario")) = "" Then
                            Ore = TimeSpan.Parse(RGrealizzate("orario"))
                        Else
                            MessageBox.Show("Attenzione, c'è un valore errato nelle presenze del giorno " & Colonna)
                            Ore = TimeSpan.Parse("00:00")
                        End If

                        Dim Tipo As Int16 = RGrealizzate("inviato")
                        If Tipo = 2 Then
                            RGtot("n" & Colonna.Day) = "AA"
                        Else
                            nTMP(Colonna.Day) += Ore.TotalHours
                            ttTMP(Colonna.Day) += Ore.TotalHours
                            RGtot("n" & Colonna.Day) = nTMP(Colonna.Day)
                            RGtot("t" & Colonna.Day) = nTMP(Colonna.Day)
                        End If
                    Next
                    RGtot("ntot") = nTMP.Sum

                    DT.Rows.Add(RGtot)
                Next
            End Using
        End Using

        BStotali.DataSource = DT
        Dim tmpT(31) As Decimal
        For gg = 1 To 31
            tmpT(gg) = DT.AsEnumerable().Sum(Function(row) row.Field(Of Decimal)("t" & gg))
        Next

        For Each tt In DT
            For col = 1 To 31
                tt("t" & col) = tmpT(col)
            Next
            tt("ttot") = tmpT.Sum
            tt.AcceptChanges()
        Next
    End Sub

End Class