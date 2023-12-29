Public Class FRMmodificarigaordineweb
    Friend tmpRG As DS_Ordini.DTordiniRigaWebRow
    Dim RGparent As DataRow
    Dim wFornitore As String = "tutti i fornitori"
    Public Sub New(ByRef tRG As BindingSource, ByVal oRG As DataRow)
        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        If IsDBNull(tRG) Then
            Return
        End If
        tmpRG = DirectCast(tRG.Current, DataRowView).Row
        RGparent = oRG
    End Sub
    Private Sub FRMmodificarigaordineweb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TA_prodotti.Fill(Me.DS_Ordini.DT_prodotti)
        Me.TA_destinatari.Fill(Me.DS_Ordini.DT_destinatari, GlobalVarPOP.G_idAZ)
        Me.TA_utenti.FillByAttivi(Me.DS_Ordini.DT_utenti, GlobalVarPOP.G_idAZ, 0)

        Me.TAordiniRigaWeb.Fill(Me.DS_Ordini.DTordiniRigaWeb)


        If tmpRG.id < 0 Then


            BSordiniRigaWeb.Filter = "id_ordine = " & tmpRG.id_ordine
            Dim pos As Int32 = BSordiniRigaWeb.Count
            BSordiniRigaWeb.RemoveFilter()
            BSordiniRigaWeb.AddNew()
            Dim tRg As DS_Ordini.DTordiniRigaWebRow
            tRg = DirectCast(BSordiniRigaWeb.Current, DataRowView).Row
            tRg.id_fornitore = RGparent.Item("id_fornitore")
            tRg.id_ordine = tmpRG.id_ordine
            tRg.id_az = RGparent.Item("id_az")
            tRg.id_locazione = RGparent.Item("id_locazione")
            tRg.id_utente = RGparent.Item("id_utente")
            tRg.posizione = pos + 1
            tRg.fornitore = "MaxClean"
            BSordiniRigaWeb.EndEdit()
        End If
        BSordiniRigaWeb.Filter = "id_ordine = " & tmpRG.id_ordine
        BSordiniRigaWeb.Position = BSordiniRigaWeb.Find("id", tmpRG.id)


        'BSordiniRigaWeb.EndEdit()
        caricaFornitori()
        caricaProdotti()
        CBfornitore.SelectedItem = tmpRG.fornitore
        TXricercaprodotto.Text = tmpRG.descrizione
    End Sub
    Private Sub caricaFornitori()
        CBfornitore.Items.Add("tutti i fornitori")

        Using TA As New DS_OrdiniTableAdapters.TA_fornitori
            Using DS As New DS_Ordini.DT_fornitoriDataTable
                Dim gRG As DS_Ordini.DT_fornitoriRow
                TA.Fill(DS)
                For Each RG As DataRow In DS.Rows
                    gRG = DirectCast(RG, DataRow)
                    'gRG.id.ToString().PadLeft(4, "0") & " " & 
                    CBfornitore.Items.Add(gRG.anagrafica)
                Next
            End Using
        End Using
        CBfornitore.SelectedIndex() = CBfornitore.FindString("tutti i fornitori")
    End Sub
    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        BSordiniRigaWeb.EndEdit()
        Dim tRg As DS_Ordini.DTordiniRigaWebRow
        For Each rg As DataRowView In BSordiniRigaWeb
            tRg = DirectCast(rg, DataRowView).Row
            If tRg.RowState = DataRowState.Modified Then
                TAordiniRigaWeb.AggiornaRiga(tRg.posizione, tRg.id_prodotto, tRg.quantita, tRg.id_locazione, tRg.id_utente, tRg.id)
                tmpRG = tRg
                tmpRG.AcceptChanges()
            End If
            If tRg.RowState = DataRowState.Added Then
                TAordiniRigaWeb.inserisci(tRg.id_az, tRg.id_ordine, tRg.posizione, RGparent.Field(Of DateTime)("data_ordine"), tRg.id_prodotto, tRg.quantita, tRg.id_locazione, tRg.id_utente, 0, tRg.id_fornitore, tRg.descrizione)
            End If
        Next
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        BSordiniRigaWeb.EndEdit()
        Dim tRg As DS_Ordini.DTordiniRigaWebRow
        For Each rg As DataRowView In BSordiniRigaWeb
            tRg = DirectCast(rg, DataRowView).Row
            If tRg.RowState <> DataRowState.Unchanged Then
                If MsgBox("Attenzione, modifiche in corso. " & Chr(13) & "Proseguo ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Me.Close()
                Else
                    Return
                End If
            End If
        Next
        Me.Close()
    End Sub

    Private Sub CBfornitore_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBfornitore.SelectedIndexChanged
        wFornitore = CBfornitore.SelectedItem
        caricaProdotti()
    End Sub

    Private Sub caricaProdotti()
        LBprodotti.Items.Clear()
        Dim nP As Integer = 0
        Using TA As New DS_OrdiniTableAdapters.TA_prodotti
            Using DS As New DS_Ordini.DT_prodottiDataTable
                Dim gRG As DS_Ordini.DT_prodottiRow
                TA.Fill(DS)
                For Each RG As DataRow In DS.Rows
                    gRG = DirectCast(RG, DataRow)
                    Dim prodotto As String = Trim(gRG.prodotto.ToLower())
                    Dim tt As cMyProdotto = New cMyProdotto(prodotto)
                    tt.xID = gRG.id
                    tt.xPrezzoConfezione = gRG.prezzoconfezione
                    tt.xPrezzoUnitario = gRG.prezzounitario
                    tt.xSconto = gRG.sconto
                    tt.xQuantitaConfezione = gRG.quantita_conf
                    If wFornitore = "tutti i fornitori" Or Trim(gRG.fornitore) = Trim(wFornitore) Then
                        If TXricercaprodotto.Text = "" Then
                            LBprodotti.Items.Add(tt)
                            nP += 1
                        Else
                            If prodotto.Contains(Trim(TXricercaprodotto.Text).ToLower) Then
                                LBprodotti.Items.Add(tt)
                                nP += 1
                            End If
                        End If

                    Else
                        Continue For
                    End If
                Next
            End Using
        End Using
        LBnumero.Text = "Prodotti trovati: " & nP
    End Sub

    Private Sub TXricercaprodotto_TextChanged(sender As Object, e As EventArgs) Handles TXricercaprodotto.TextChanged
        caricaProdotti()
    End Sub

    Private Sub LBprodotti_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBprodotti.SelectedIndexChanged
        Dim RGor As DS_Ordini.DTordiniRigaWebRow
        RGor = DirectCast(BSordiniRigaWeb.Current, DataRowView).Row

        Dim prezzoConf As Decimal
        Dim prezzoUnit As Decimal
        Dim Sconto As Decimal
        Dim Quantita As Decimal
        Dim id As Integer
        With DirectCast(LBprodotti.SelectedItem, cMyProdotto)
            prezzoConf = .xPrezzoConfezione
            prezzoUnit = .xPrezzoUnitario
            Sconto = .xSconto
            Quantita = .xQuantitaConfezione
            id = .xID
        End With
        RGor.id_prodotto = id
        RGor.sconto = Sconto
        PrezzounitarioTextBox.Text = prezzoUnit
        QuantitaTextBox.Text = Quantita
        BSordiniRigaWeb.EndEdit()
    End Sub
    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim RGor As DS_Ordini.DTordiniRigaWebRow
        RGor = DirectCast(BSordiniRigaWeb.Current, DataRowView).Row
        Dim idord As Integer = RGor.id_ordine
        If MsgBox("Attenzione, vuoi eliminare l'articolo. " & RGor.descrizione & Chr(13) & "Proseguo ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            TAordiniRigaWeb.elimina(RGor.id)
            RGor.Delete()
            If BSordiniRigaWeb.Count > 0 Then
                RGor = DirectCast(BSordiniRigaWeb.Current, DataRowView).Row
                TXricercaprodotto.Text = RGor.descrizione
            Else
                TXricercaprodotto.Text = ""
            End If
        End If


    End Sub


    Private Class cMyProdotto
        Public Sub New(ByVal sTesto As String)
            Testo = sTesto
            'MyIDTag = iMyIDTag
        End Sub
        '...stendiamo un velo pietoso sul public e la mancanza del Get/Set delle proprietà
        Public Testo As String
        'Public MyIDTag As Integer
        Public Overrides Function Tostring() As String
            Return Testo
        End Function
        Private tPrezzoConfezione As Decimal
        Private tID As Integer
        Private tQuantitaConfezione As Decimal
        Private tSconto As Decimal
        Private tTasse As Decimal
        Private tPrezzoUnitario As Decimal
        Public Property xID As Integer
            Get
                Return tID
            End Get
            Set(ByVal value As Integer)
                tID = value
            End Set
        End Property
        Public Property xQuantitaConfezione As Decimal
            Get
                Return tQuantitaConfezione
            End Get
            Set(ByVal value As Decimal)
                tQuantitaConfezione = value
            End Set
        End Property
        Public Property xPrezzoConfezione As Decimal
            Get
                Return tPrezzoConfezione
            End Get
            Set(ByVal value As Decimal)
                tPrezzoConfezione = value
            End Set
        End Property
        Public Property xPrezzoUnitario As Decimal
            Get
                Return tPrezzoUnitario
            End Get
            Set(ByVal value As Decimal)
                tPrezzoUnitario = value
            End Set
        End Property
        Public Property xSconto As Decimal
            Get
                Return tSconto
            End Get
            Set(ByVal value As Decimal)
                tSconto = value
            End Set
        End Property
        Public Property xTasse As Decimal
            Get
                Return tTasse
            End Get
            Set(ByVal value As Decimal)
                tTasse = value
            End Set
        End Property

    End Class

End Class