
Public Class FRMmacchinari
    Dim PosizioneImmagini As String
    Dim idDatabaseMacchinari As Integer
    Dim mLoc As Point
    Dim ZoomEnabled As Boolean
    Dim ImmagineAttiva As Boolean = True
    Dim G_Disco As String = "V:"
    Dim G_Posizione As String = "\ns\PW\images\macchinari"
    Private Sub FRMmacchinari_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        idDatabaseMacchinari = 2
        caricaDB()
        PosizioneImmagini = G_Disco & G_Posizione

    End Sub
    Private Function caricaDB()
        Me.TA_cantieri_new.Fill(DS_clienti.DT_cantieri_new, GlobalVarPOP.G_idAZ)
        Me.TA_locazione_new.Fill(DS_clienti.DT_locazione_new, GlobalVarPOP.G_idAZ)
        Me.TAimmagini.FillByDatabase(Me.DS_prodotti.DTimmagini, idDatabaseMacchinari)
        Me.TA_utenti.Fill(Me.DS_utenti.DT_utenti, GlobalVarPOP.G_idAZ)
        Me.TAmovimentimacchine.Fill(Me.DSmacchinari.DTmovimentimacchine)
        Me.TAservizio.Fill(Me.DSmacchinari.DTservizio)
        Me.TAfornitori.Fill(Me.DSmacchinari.DTfornitori)
        Me.TAmarche.Fill(Me.DSmacchinari.DTmarche)
        Me.TAmacchine.Fill(Me.DSmacchinari.DTmacchine)
        Return True
    End Function
    Private Sub DGmacchinari_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGmacchinari.DataError
#If DEBUG Then
        Dim DGtmp As DataGridView
        DGtmp = DirectCast(sender, DataGridView)
        Dim risultato As String
        'risultato = String.Format("Errore {0} colonna {1} Eccezione {2} Valore Cella {3}", e.ThrowException.ToString, e.ColumnIndex.ToString, e.Exception, DGtmp.CurrentCell.Value)
        Console.WriteLine(risultato)
#End If
    End Sub
    Private Sub DGmovimenti_DataError(sender As Object, e As DataGridViewDataErrorEventArgs) Handles DGmovimenti.DataError
#If DEBUG Then
        Dim DGtmp As DataGridView
        DGtmp = DirectCast(sender, DataGridView)
        Dim risultato As String
        risultato = String.Format("Errore {0} colonna {1} Eccezione {2} Valore Cella {3}", e.ThrowException.ToString, e.ColumnIndex.ToString, e.Exception, DGtmp.CurrentCell.Value)
        Console.WriteLine(risultato)
#End If
    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click

        BSimmagini.DataSource = Nothing
        DGWCMACidFornitore.DataSource = Nothing
        DGWCMACidMarca.DataSource = Nothing
        DGmacchinari.DataSource = Nothing

        DGWCMovidcliente.DataSource = Nothing
        DGWCMovidlocazione.DataSource = Nothing
        DGWCMovidmacchina.DataSource = Nothing
        DGWCMovidservizio.DataSource = Nothing
        DGWCMovidutente.DataSource = Nothing
        DGmovimenti.DataSource = Nothing

        Me.Close()
    End Sub
    Private Sub LLmacchina_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLmacchina.LinkClicked
        ModificaMacchina()
    End Sub
    Private Sub ModificaMacchina()
        Dim RG As DSmacchinari.DTmacchineRow
        RG = DirectCast(BSmacchinari.Current, DataRowView).Row
        Dim f As New FRMmod_macchinari(DSmacchinari.DTmacchine)
        f.ShowDialog()
    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        Select Case TABmovimenti.SelectedTab.Name
            Case TBmovimenti.Name
                If BSmovimenti.Count = 0 Then
                    Return
                End If
                'Dim tmpRG
                'tmpRG = DirectCast(BSmovimenti.Current, DataRowView).Row

                BSmovimenti.EndEdit()
                Dim RG As DSmacchinari.DTmovimentimacchineRow
                For Each rgT As DataRowView In BSmovimenti
                    RG = DirectCast(rgT, DataRowView).Row
                    Select Case RG.RowState
                        Case DataRowState.Modified
                            Dim i As Integer = TAmovimentimacchine.modifica(RG.idmacchina, RG.idlocazione, RG.idutente, RG.data, RG.note, RG.idcliente, RG.id_servizio, RG.id)
                            If i < 0 Then
                                MsgBox("errori nella memorizzazione" & RG.id)
                            End If
                            RG.AcceptChanges()
                        Case DataRowState.Added
                            'Dim i As Integer = TAmacchine.inserisce(RG.descrizione, RG.idforn, RG.idmarca, RG.dtacquisto, RG.prezzo, RG.nu, RG.revisione, RG.batterie, RG.note)
                            'If i < 0 Then
                            '    MsgBox("errori nella memorizzazione" & RG.descrizione)
                            'End If
                    End Select
                Next

            Case TBmacchinari.Name
                If BSmacchinari.Count = 0 Then
                    Return
                End If
                'Dim tmpRG
                'tmpRG = DirectCast(BSmacchinari.Current, DataRowView).Row

                BSmacchinari.EndEdit()
                Dim RG As DSmacchinari.DTmacchineRow
                For Each rgT As DataRowView In BSmacchinari
                    RG = DirectCast(rgT, DataRowView).Row
                    Select Case RG.RowState
                        Case DataRowState.Modified
                            Dim i As Integer = TAmacchine.modifica(RG.descrizione, RG.idforn, RG.idmarca, RG.dtacquisto, RG.prezzo, RG.nu, RG.revisione, RG.batterie, RG.note, RG.id)
                            If i < 0 Then
                                MsgBox("errori nella memorizzazione" & RG.descrizione)
                            End If
                            RG.AcceptChanges()
                        Case DataRowState.Added
                            Dim i As Integer = TAmacchine.inserisce(RG.descrizione, RG.idforn, RG.idmarca, RG.dtacquisto, RG.prezzo, RG.nu, RG.revisione, RG.batterie, RG.note)
                            If i < 0 Then
                                MsgBox("errori nella memorizzazione" & RG.descrizione)
                            End If
                    End Select
                Next

        End Select

    End Sub
    Private Sub Pic_MouseLeave(sender As Object, e As System.EventArgs) Handles Pic.MouseLeave
        ZoomEnabled = False   'disable the zoom if leaving the picturebox
        Pic.Invalidate()
    End Sub

    Private Sub Pic_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Pic.MouseMove
        mLoc = e.Location
        If ZoomEnabled Then
            Pic.Invalidate()
        End If
    End Sub

    Private Sub Pic_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Pic.MouseUp
        ZoomEnabled = Not ZoomEnabled  'toggle zoom on or off
        Pic.Invalidate()
    End Sub

    Private Sub Pic_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Pic.Paint
        If ZoomEnabled Then
            Dim gp As New Drawing2D.GraphicsPath
            gp.AddEllipse(New Rectangle(mLoc.X - 100, mLoc.Y - 100, 200, 200))
            e.Graphics.SetClip(gp)
            e.Graphics.DrawImage(Pic.Image, New Rectangle(mLoc.X - 100, mLoc.Y - 100, 200, 200), New Rectangle(mLoc.X - 50, mLoc.Y - 50, 100, 100), GraphicsUnit.Pixel)
            gp.Dispose()
        End If
    End Sub
    Private Sub DGmacchinari_FormatCell(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles DGmacchinari.CellFormatting
        If BSimmagini.Count = 0 Or e.RowIndex < 0 Or e.ColumnIndex < 0 Then
            Return
        End If
        If e.ColumnIndex = DGWCMacImmagine.Index And DGWCMACidMacchinari.Index >= 0 Then
            Dim objAsConvertible As IConvertible = TryCast(DGmacchinari(DGWCMACidMacchinari.Index, e.RowIndex).Value, IConvertible)
            Dim ValCol As Integer
            If objAsConvertible Is Nothing Then
                Return
            Else
                ValCol = DGmacchinari(DGWCMACidMacchinari.Index, e.RowIndex).Value
            End If

            Dim pos As Integer = BSimmagini.Find("idriferimento", ValCol)
            If pos >= 0 Then
                DGmacchinari(DGWCMacImmagine.Index, e.RowIndex).Value = "SI"
            Else
                DGmacchinari(DGWCMacImmagine.Index, e.RowIndex).Value = "NO"
            End If
        End If
    End Sub
    Private Sub DGmacchinari_MouseOver(sender As Object, e As DataGridViewCellEventArgs) Handles DGmacchinari.CellMouseLeave
        If e.ColumnIndex = DGWCMacImmagine.Index And Not ImmagineAttiva Then
            Pic.Visible = ImmagineAttiva
            ImmagineAttiva = Not ImmagineAttiva
        End If
    End Sub
    Private Sub DGmacchinari_MouseEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DGmacchinari.CellMouseEnter

        If e.RowIndex < 0 Then
            Return
        End If
        If e.ColumnIndex = DGWCMacImmagine.Index And ImmagineAttiva Then

            Dim RGimg As DS_prodotti.DTimmaginiRow
            'Ottengo l'ID del prodotto che corrisponde anche al nome dell'immagine

            Dim idProd As Integer = DGmacchinari(DGWCMACidMacchinari.Index, e.RowIndex).Value
            Dim pos As Integer = BSimmagini.Find("idriferimento", idProd)
            If pos <= 0 Then
                ImmagineAttiva = Not ImmagineAttiva
                Pic.Visible = ImmagineAttiva
                Return
            End If
            Dim position As Point = Me.PointToClient(MousePosition)
            position.X = position.X + 300
            If position.Y > Me.Height - 500 Then
                position.Y = Me.Height - 500
            End If
            Pic.Location = position
            Pic.Visible = CheckImmagineAttiva.Checked

            ImmagineAttiva = Not CheckImmagineAttiva.Checked
            'Se trovo l'immagine allora ottengo il nome del file immagine
            BSimmagini.Position = pos
            RGimg = DirectCast(BSimmagini.Current, DataRowView).Row
            'Cerco se esite il file immagine
            Dim flImmagine As String = PosizioneImmagini & RGimg.urlfoto
            If IO.File.Exists(flImmagine) Then
                Dim Immagine As Bitmap
                Immagine = New Bitmap(flImmagine)
                Pic.Image = Immagine
                Return
            End If
            'Else
            '    Pic.Image = Nothing
            '    Pic.Visible = ImmagineAttiva
            '    ImmagineAttiva = Not ImmagineAttiva
        End If
    End Sub

    Private Sub DGmacchinari_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGmacchinari.CellContentClick
        If e.ColumnIndex = DGWCMacImmagine.Index And Not ImmagineAttiva Then
            Dim RGim As DS_prodotti.DTimmaginiRow
            Dim idImmagine As String = DGmacchinari(DGWCMACidMacchinari.Index, e.RowIndex).Value
            Dim pos As Integer = BSimmagini.Find("idriferimento", idImmagine)
            If pos < 0 Then
                Dim PosDoc As New OpenFileDialog()
                If PosDoc.ShowDialog() = DialogResult.OK Then
                    Dim VecchiaImmagine As String = PosDoc.FileName()
                    Dim Estensione As String
                    Estensione = System.IO.Path.GetExtension(VecchiaImmagine)
                    Dim NuovaImmagine As String
                    NuovaImmagine = PosizioneImmagini & idImmagine & Estensione
                    'Cerco se esite il file immagine
                    Rimodella_e_memorizza_Immagine(VecchiaImmagine, NuovaImmagine, 300, 300, 150)
                    BSimmagini.AddNew()
                    RGim = DirectCast(BSimmagini.Current, DataRowView).Row
                    RGim.iddatabase = idDatabaseMacchinari
                    RGim.idriferimento = idImmagine
                    RGim.urlfoto = idImmagine & Estensione
                    If TAimmagini.inserisce(RGim.iddatabase, RGim.idriferimento, RGim.urlfoto) > 0 Then
                        BSimmagini.EndEdit()
                        RGim.AcceptChanges()
                    End If
                End If
            Else
                Dim risposta As MsgBoxResult = MsgBox("Vuoi eliminare l'immagine o annullare?", MsgBoxStyle.YesNo)
                Select Case risposta
                    Case MsgBoxResult.Yes
                        BSimmagini.Position = pos
                        RGim = DirectCast(BSimmagini.Current, DataRowView).Row
                        'Cerco se esite il file immagine
                        Dim flImmagine As String = PosizioneImmagini & RGim.urlfoto

                        If IO.File.Exists(flImmagine) Then
                            Pic.Image.Dispose()
                            'IO.File.Delete(flImmagine)
                        End If
                        TAimmagini.elimina(RGim.id)
                        RGim.Delete()

                End Select
            End If
        End If
    End Sub
    Private Sub DGmacchinari_convalid(sender As Object, e As DataGridViewCellCancelEventArgs) Handles DGmacchinari.RowValidating
        If BSmacchinari.Count = 0 Then
            Return
        End If
        BSmacchinari.EndEdit()
        Dim RG As DSmacchinari.DTmacchineRow
        RG = DirectCast(BSmacchinari.Current, DataRowView).Row
        Select Case RG.RowState
            Case DataRowState.Modified
                Dim i As Integer = TAmacchine.modifica(RG.descrizione, RG.idforn, RG.idmarca, RG.dtacquisto, RG.prezzo, RG.nu, RG.revisione, RG.batterie, RG.note, RG.id)
                If i < 0 Then
                    MsgBox("errori nella memorizzazione" & RG.descrizione)
                End If
                RG.AcceptChanges()
            Case DataRowState.Added
                Dim i As Integer = TAmacchine.inserisce(RG.descrizione, RG.idforn, RG.idmarca, RG.dtacquisto, RG.prezzo, RG.nu, RG.revisione, RG.batterie, RG.note)
                If i < 0 Then
                    MsgBox("errori nella memorizzazione" & RG.descrizione)
                    Return
                End If
                RG.id = TAmacchine.SQultimoID()
                RG.AcceptChanges()
        End Select
    End Sub
    Private Sub DGmacchinariCell_convalid(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles DGmacchinari.CellValidating
        Console.WriteLine(" Colonna analizzata " & e.ColumnIndex)
        Select Case e.ColumnIndex
            Case DGWCMacRevisione.Index
                If e.FormattedValue = Nothing Then
                    Console.WriteLine("Ho inserito il valore di oggi")
                    DGmacchinari(DGWCMacRevisione.Index, e.RowIndex).Value = Now.ToShortDateString
                End If
            Case DGWCMACDescrizione.Index
                If e.FormattedValue = Nothing Then
                    DGmacchinari.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = "compila il campo"
                    e.Cancel = True
                Else
                    DGmacchinari.Rows(e.RowIndex).Cells(e.ColumnIndex).ErrorText = ""
                    e.Cancel = False
                End If

        End Select
    End Sub
    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click

        BSmacchinari.AddNew()
        DGmovimenti.Focus()

    End Sub

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Select Case TABmovimenti.SelectedTab.Name
            Case TBmovimenti.Name
                If BSmovimenti.Count = 0 Then
                    Return
                End If
                BSmovimenti.EndEdit()
                Dim RG As DSmacchinari.DTmovimentimacchineRow
                For Each rgT As DataRowView In BSmovimenti
                    RG = DirectCast(rgT, DataRowView).Row
                    Select Case RG.RowState
                        Case DataRowState.Modified
                            Dim i As Integer = TAmovimentimacchine.modifica(RG.idmacchina, RG.idlocazione, RG.idutente, RG.data, RG.note, RG.idcliente, RG.id_servizio, RG.id)
                            If i < 0 Then
                                MsgBox("errori nella memorizzazione" & RG.id)
                            End If
                            RG.AcceptChanges()
                        Case DataRowState.Added
                            'Dim i As Integer = TAmacchine.inserisce(RG.descrizione, RG.idforn, RG.idmarca, RG.dtacquisto, RG.prezzo, RG.nu, RG.revisione, RG.batterie, RG.note)
                            'If i < 0 Then
                            '    MsgBox("errori nella memorizzazione" & RG.descrizione)
                            'End If
                    End Select
                Next

            Case TBmacchinari.Name
                If BSmacchinari.Count = 0 Then
                    Return
                End If
                BSmacchinari.EndEdit()
                Dim RG As DSmacchinari.DTmacchineRow
                RG = DirectCast(BSmacchinari.Current, DataRowView).Row
                Dim risp As MsgBoxResult = MsgBox("Elimino " & RG.descrizione, MsgBoxStyle.YesNo)
                If risp Then
                    Dim i As Integer = TAmacchine.elimina(RG.id)
                    RG.Delete()
                End If
        End Select

    End Sub

    Private Sub CheckImmagineAttiva_CheckedChanged(sender As Object, e As EventArgs) Handles CheckImmagineAttiva.CheckedChanged
        CheckImmagineAttiva.ImageIndex = CheckImmagineAttiva.Checked
    End Sub
End Class