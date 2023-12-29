Imports MySql.Data.MySqlClient
Public Class frmDipendentiTipoFormazione
    Public _Des As String
    Private oldRiga As DS_personale.DT_tipo_formRow
    Private nome As String = GlobalVarPOP.G_nomeutente


    Public Sub New(ByVal des As String)
        ' La chiamata è richiesta dalla finestra di progettazione.

        InitializeComponent()

        _Des = des
    End Sub

    Private Sub frm_tipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oldNum As DataRow = Nothing
        Try
            Try
                oldNum = dsolidofunc.legge_informazioni(Me.Name, nome)
            Catch ex As Exception
#If DEBUG Then
                MsgBox(ex.Message)
#End If
            End Try
            'Imposta se la connessione é remota o locale
            Me.DT_tipo_form_TA.Fill(Me.DS_personale.DT_tipo_form)
            Dim tmpRicerca As String = ""

            If _Des.Length > 0 Then
                tmpRicerca = _Des.Trim
            End If
            'Si posiziona sul numero recuperato
            If oldNum.Item(0) > 0 Then
                If oldNum.Item(0) > 0 Then
                    DT_tipo_formBindingSource.Position = DT_tipo_formBindingSource.Find(oldNum.Item("identificativo"), oldNum.Item("valore_identificativo"))
                End If
            End If
            Me.DT_tipo_formBindingSource.Filter = String.Format("descrizione LIKE '%{0}%'", tmpRicerca)
            If DT_tipo_formBindingSource.Count < 1 Then
                MessageBox.Show("nessuna corrispondenza")
                Me.DT_tipo_formBindingSource.RemoveFilter()
                Me.TXT_ricerca.Focus()
            End If

        Catch ex As Exception
#If DEBUG Then
            MessageBox.Show(ex.Message)
#End If

        End Try
        'Me.DT_capTableAdapter.Fill(Me.DS_magazzino.DT_cap)
    End Sub

    Private Sub TXT_ricerca_TextChanged(sender As Object, e As EventArgs) Handles TXT_ricerca.TextChanged
        Dim tmp_ric As String = TXT_ricerca.Text.ToUpper.Trim
        DT_tipo_formBindingSource.Filter = String.Format("descrizione LIKE '%{0}%'", tmp_ric)
    End Sub
    Private Sub clicca_rilascia(ByVal schiaccia As Boolean, ByVal cosa As Button)
        If schiaccia Then
            cosa.Top = cosa.Top + 1
            cosa.Left = cosa.Left + 1
        Else
            cosa.Top = cosa.Top - 1
            cosa.Left = cosa.Left - 1
        End If
    End Sub
    Private Sub cmd_MouseDown(sender As Object, e As MouseEventArgs) Handles cmd_termina.MouseDown, cmd_aggiunge.MouseDown,
                                                                    cmd_annulla.MouseDown, cmd_salva.MouseDown,
                                                                    cmd_elimina.MouseDown
        Dim tmpbutt As Button = DirectCast(sender, Button)
        clicca_rilascia(True, tmpbutt)
    End Sub

    Private Sub cmd_MouseUp(sender As Object, e As MouseEventArgs) Handles cmd_termina.MouseUp, cmd_aggiunge.MouseUp,
                                                                    cmd_annulla.MouseUp, cmd_salva.MouseUp,
                                                                    cmd_elimina.MouseUp
        Dim tmpbutt As Button = DirectCast(sender, Button)
        clicca_rilascia(False, tmpbutt)
    End Sub
    Private Sub cmd_Click(sender As Object, e As EventArgs) Handles cmd_termina.Click, cmd_aggiunge.Click,
                                                                    cmd_annulla.Click, cmd_salva.Click, cmd_elimina.Click
        Try
            'trasferisco l'oggetto sender in un pulsante
            Dim tmp_butt As Button = DirectCast(sender, Button)
            Dim oldPos = DT_tipo_formBindingSource.Position
            'in base al tipo di pulsante decido cosa fare
            Select Case tmp_butt.Name
                Case "cmd_aggiunge"
                    DT_tipo_formBindingSource.AddNew()
                    oldRiga = DirectCast(DT_tipo_formBindingSource.Current, DataRowView).Row
                Case "cmd_termina"
                    ' _Des = dsolidofunc.Propper(oldRiga.Descrizione)
                    'richiama l'ultima riga
                    oldRiga = DirectCast(DT_tipo_formBindingSource.Current, DataRowView).Row
                    'imposta le informazioni da memorizzare
                    Dim nome_ri = {"DT_tipo_form_TA", "id", oldRiga.id.ToString}
                    'memorizza le informazioni
                    If Not memorizza_informazioni(Me.Name, DT_tipo_formBindingSource.Position, nome, nome_ri) Then
                        MessageBox.Show("problemi con la memorizzazione delle informazioni in uscita")
                    End If
                    Me.Dispose()
                    Me.Close()
                Case "cmd_annulla"  'se ho premuto annulla
                    DT_tipo_formBindingSource.CancelEdit()
                Case "cmd_elimina"
                    oldRiga = DirectCast(DT_tipo_formBindingSource.Current, DataRowView).Row
                    'domanda se eliminare o no
                    If MsgBox("Elimino la scheda di " & oldRiga.Descrizione, MsgBoxStyle.YesNo) = DialogResult.Yes Then
                        DT_tipo_form_TA.elimina(oldRiga.id)
                        Me.DT_tipo_form_TA.Fill(Me.DS_personale.DT_tipo_form)
                        DT_tipo_formBindingSource.Position = oldPos - 1
                    End If
                Case "cmd_salva"
                    DT_tipo_formBindingSource.EndEdit()
                    ' se é una modifica o un nuovo inserimento

                    oldRiga = DirectCast(DT_tipo_formBindingSource.Current, DataRowView).Row
                    Dim oldID As Integer = oldRiga.id

                    If oldRiga.id > 0 Then
                        DT_tipo_form_TA.modifica(dsolidofunc.Propper(oldRiga.Descrizione), oldRiga.id)
                        DT_tipo_form_TA.Fill(DS_personale.DT_tipo_form)
                        DT_tipo_formBindingSource.Position = DT_tipo_formBindingSource.Find("id", oldID)
                    Else
                        DT_tipo_form_TA.inserisce(dsolidofunc.Propper(oldRiga.Descrizione))
                        DT_tipo_form_TA.Fill(DS_personale.DT_tipo_form)
                        DT_tipo_formBindingSource.MoveLast()
                    End If
                Case "cmd_stampa"
            End Select
        Catch ex As Exception
#If DEBUG Then
            Console.WriteLine(ex.Message)
#End If
        End Try

    End Sub
End Class