Public Class FRM_giorno
    Dim G_idaz As Integer = GlobalVarPOP.G_idAZ

    Private Sub FRM_giorno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CaricaDatiAgenda()
    End Sub

    Private Sub CaricaDatiAgenda()
        DG_giorno.Rows.Clear()
        Dim DGFontp As New Font("Tahoma", 8)
        'Dim D_periodo As String = G_anno & "-" & G_settimana
        Dim Giorno As DateTime = Now.ToShortDateString
        Using TA As New DS_agTableAdapters.TA_agenda
            Using DT As New DS_ag.DT_agendaDataTable
                TA.FillByGiorno(DT, Giorno, G_idaz)
                Dim xx As Integer = 0
                For Each RG_a In DT
                    If RG_a.dataevento.ToShortDateString = Giorno.ToShortDateString Then
                        Dim OldStringa As String = ""
                        Dim OldToolStrip As String = ""
                        Dim OldTag As String = ""
                        Console.WriteLine(RG_a.ora_i)
                        Dim Stringa As String = RG_a.anagrafica_A.Substring(0, If(RG_a.anagrafica_A.Length > 20, 20, RG_a.anagrafica_A.Length))
                        Dim ToolStrip As String = "|ORA:" & RG_a.ora_i.ToShortTimeString &
                                                    "->" & RG_a.ora_f.ToShortTimeString &
                                                    "|NO:" & RG_a.anagrafica_A.Substring(0, If(RG_a.anagrafica_A.Length > 20, 20, RG_a.anagrafica_A.Length)) &
                                                    "->" & RG_a.anagrafica_B.Substring(0, If(RG_a.anagrafica_B.Length > 20, 20, RG_a.anagrafica_B.Length)) &
                                                    "|DOVE:" & RG_a.locazione.Substring(0, If(RG_a.locazione.Length > 20, 20, RG_a.locazione.Length)) &
                                                    Strings.Chr(13)
                        DG_giorno.Rows.Add()
                        DG_giorno("C_ora", xx).Value = RG_a.ora_i.ToShortTimeString & "<-->" & RG_a.ora_f.ToShortTimeString
                        DG_giorno(1, xx).Value = RG_a.anagrafica_A
                        If RG_a.id_dip_b < 0 Then
                            DG_giorno.Rows(xx).DefaultCellStyle.BackColor = Color.OrangeRed
                        End If
                        DG_giorno(2, xx).Value = RG_a.anagrafica_B
                        DG_giorno("C_locazione", xx).Value = RG_a.locazione
                        DG_giorno("C_cliente", xx).Value = RG_a.societa
                        DG_giorno("C_tipo", xx).Value = RG_a.descrizione
                        DG_giorno("C_note", xx).Value = RG_a.note

                        xx += 1
                    End If
                Next
            End Using
        End Using
    End Sub

End Class