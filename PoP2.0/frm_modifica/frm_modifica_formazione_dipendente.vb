Public Class frm_modifica_formazione_dipendente
    Private _id As Integer = 0
    Private _idd As Integer = 0
    Private _idf As Integer = 0
    Private _idt As Date = Now()
    Private oldRiga As DS_personale.DT_utenti_forRow

    Public Sub New(ByVal id As Integer, ByVal idd As Integer, ByVal idf As Integer, ByVal idt As DateTime)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        _id = id
        _idd = idd
        _idf = idf
        _idt = idt
        ' Aggiungere le eventuali istruzioni di inizializzazione dopo la chiamata a InitializeComponent().

    End Sub

    Private Sub frm_modifica_formazione_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'assegna il tipo di connessione
        Me.DT_utenti_for_TA.mostra_per_id(Me.DS_personale.DT_utenti_for, _id)
        Me.DT_tipo_form_TA.Fill(Me.DS_personale.DT_tipo_form)
        If _id > 0 Then
            oldRiga = DirectCast(DT_utenti_forBindingSource.Current, DataRowView).Row
        Else
            DT_utenti_forBindingSource.AddNew()
            oldRiga = DirectCast(DT_utenti_forBindingSource.Current, DataRowView).Row
            oldRiga.dt_for = Now()
            oldRiga.note = ""
            oldRiga.id_dip = _idd
        End If
    End Sub
    Private Sub cmd_Click(sender As Object, e As EventArgs) Handles cmd_termina.Click, cmd_salva.Click, cmd_elimina.Click
        Try
            'trasferisco l'oggetto sender in un pulsante
            Dim tmp_butt As Button = DirectCast(sender, Button)
            'in base al tipo di pulsante decido cosa fare
            Select Case tmp_butt.Name
                Case "cmd_termina"
                    Me.Dispose()
                    Me.Close()
                Case "cmd_elimina"
                    oldRiga = DirectCast(DT_utenti_forBindingSource.Current, DataRowView).Row
                    'domanda se eliminare o no
                    If oldRiga.id > 0 Then

                        If MsgBox("Elimino la scheda di " & oldRiga.descrizione, MsgBoxStyle.YesNo) = DialogResult.Yes Then
                            DT_utenti_for_TA.elimina(oldRiga.id)
                            Me.Dispose()
                            Me.Close()
                        End If
                    Else
                        MsgBox("non hai nulla da eliminare")
                    End If

                Case "cmd_salva"
                    ' se é una modifica o un nuovo inserimento
                    Dim oldID As Integer = oldRiga.id
                    If oldID > 0 Then
                        DT_utenti_for_TA.modifica_per_id(_idd, oldRiga.id_for, oldRiga.dt_for, oldRiga.note, oldID)
                        DT_utenti_for_TA.Mostra(DS_personale.DT_utenti_for)
                    Else
                        DT_utenti_for_TA.inserisce(_idd, oldRiga.id_for, oldRiga.dt_for, oldRiga.note)
                        DT_utenti_for_TA.Mostra(DS_personale.DT_utenti_for)
                    End If
                    Me.Dispose()
                    Me.Close()

                Case "cmd_stampa"
            End Select
        Catch ex As Exception
#If DEBUG Then
            Console.WriteLine(ex.Message)
#End If
        End Try

    End Sub

End Class