Public Class FRM_FIND_prodotti

    Dim BSRRO As New BindingSource
    Dim dataOrdine As DateTime
    Public Sub New(ByRef BSrighe As BindingSource, Optional _B As BindingSource = Nothing)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()

        BSRRO.DataSource = _B.DataSource
        BSRRO.DataMember = _B.DataMember
        BSRRO.Position = _B.Position
        BSRRG.DataSource = BSrighe
        BSRRG = BSrighe

        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub
    ' This event handler provides custom item-creation behavior.

    Private Sub FRM_FIND_prodotti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim RG_o As DS_Ordini.DT_ordiniRow
        RG_o = DirectCast(BSRRO.Current, DataRowView).Row
        Dim id_cli As Integer = RG_o.id_cliente
        Dim id_des As Int16 = RG_o.id_locazione
        dataOrdine = RG_o.data_ordine

        'Me.TA_storico.FillByIDCliente(DS_Ordini.DT_storico, id_cli)
        Me.TA_storico.FillByIDLocazione(DS_Ordini.DT_storico, id_des)
        Me.TA_prodotti.FillByFornitore(Me.DS_Ordini.DT_prodotti, RG_o.id_fornitore)
        TX_cercastorico.Focus()
        TX_cercastorico.SelectionStart = 0
        TX_cercastorico.SelectionLength = TX_cercastorico.Text.Length
    End Sub
    Private Sub BT_termina_Click(sender As Object, e As EventArgs) Handles BT_termina.Click
        Me.Close()
    End Sub

    Private Sub Ricerca(sender As Object, e As EventArgs) Handles TX_ricerca.TextChanged, TX_cercastorico.TextChanged
        Dim testo As TextBox
        testo = DirectCast(sender, TextBox)
        Dim ricerca As String = testo.Text.Trim
        Dim valore As Integer = 0
        Dim I_Ricerca As Integer = testo.Text.Length
        Do While True
            ricerca = ricerca.Substring(0, ricerca.Length - If(valore > ricerca.Length, ricerca.Length, valore))
            testo.Text = ricerca
            testo.SelectionStart = ricerca.Length
            Dim conta As Integer
            If testo.Name = "TX_cercastorico" Then
                BS_storico.Filter = String.Format("descrizione LIKE '%{0}%'", ricerca)
                conta = BS_storico.Count
            Else
                BS_prodotti.Filter = String.Format("prodotto LIKE '%{0}%'", ricerca)
                conta = BS_prodotti.Count
            End If
            If conta > 0 Then
                Exit Do
            Else
                valore += 1
                If I_Ricerca < valore Then
                    If testo.Name = "TX_cercastorico" Then
                        BS_storico.RemoveFilter()
                    Else
                        BS_prodotti.RemoveFilter()
                    End If
                    MsgBox("Nessun Filtro applicabile")
                    Exit Do
                End If
            End If
        Loop
    End Sub
    Private Sub RicercaPreunTasto(sender As Object, e As KeyEventArgs) Handles TX_ricerca.KeyDown, TX_cercastorico.KeyDown, DG_storico.KeyDown, DG_prodotti.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim PP As Object
            PP = sender.GetType.ToString
            Select Case sender.GetType.ToString
                Case "System.Windows.Forms.DataGridView"
                    PP = DirectCast(sender, DataGridView)
                    Select Case PP.name
                        Case "DG_storico"
                            ConfermaStorico()
                        Case "DG_prodotti"
                            DG_storico.Rows(0).Selected = True
                            SalvaTMP()
                            Me.Close()
                    End Select
                Case "System.Windows.Forms.TextBox"
                    PP = DirectCast(sender, TextBox)
                    Select Case PP.name
                        Case "TX_ricerca"
                            DG_storico.Rows(0).Selected = True
                            SalvaTMP()
                            Me.Close()
                        Case "TX_cercastorico"
                            ConfermaStorico()
                    End Select
            End Select

        End If

        'MsgBox(PP.ToString)
    End Sub


    Private Sub ConfermaProdotto() Handles BT_conferma.Click
        SalvaTMP()
        Me.Close()
    End Sub
    Private Sub SalvaTMP()
        Dim RRG As DS_Ordini.DT_ordinirigheRow
        Dim RG_prodo As DS_Ordini.DT_prodottiRow
        Dim tt As DataGridViewRow
        For Each tt In DG_prodotti.SelectedRows
            BS_prodotti.Position = BS_prodotti.Find("id", tt.Cells("Col_id").Value)
            RG_prodo = DirectCast(BS_prodotti.Current, DataRowView).Row
            RRG = DirectCast(BSRRG.Current, DataRowView).Row
            RRG.id_prodotto = RG_prodo.id
            RRG.prezzo_unitario = RG_prodo.prezzounitario
            RRG.quantita = RG_prodo.quantita_conf
            RRG.sconto = RG_prodo.sconto
            RRG.descrizione = RG_prodo.prodotto
            RRG.fatturabile = RG_prodo.fatturabile
            RRG.tax = GlobalVarPOP.G_iva
            RRG.posizione = BSRRG.Count
            RRG.aggiornamento = Now()
            RRG.dataordine = dataOrdine
            BSRRG.EndEdit()
        Next
        Me.Close()
    End Sub
    Private Sub ConfermaStorico()
        Dim RRG As DS_Ordini.DT_ordinirigheRow
        Dim RG_ro As DS_Ordini.DT_storicoRow
        RG_ro = DirectCast(BS_storico.Current, DataRowView).Row
        RRG = DirectCast(BSRRG.Current, DataRowView).Row
        RRG.id_prodotto = RG_ro.id_prodotto
        RRG.prezzo_unitario = RG_ro.prezzounitario
        RRG.quantita = RG_ro.quantita
        RRG.sconto = RG_ro.sconto
        RRG.descrizione = RG_ro.descrizione
        RRG.fatturabile = RG_ro.fatturabile
        RRG.tax = GlobalVarPOP.G_iva
        RRG.posizione = BSRRG.Count
        RRG.aggiornamento = Now()
        RRG.dataordine = dataOrdine
        BSRRG.EndEdit()
        Me.Close()
    End Sub
    Private Sub DG_storico_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DG_storico.CellDoubleClick
        ConfermaStorico()
    End Sub
End Class