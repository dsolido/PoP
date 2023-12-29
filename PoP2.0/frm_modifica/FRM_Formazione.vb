Public Class FRM_Formazione
    Dim Nuovo As Boolean
    Dim ID_dip As Integer
    Dim OldID As Integer
    Friend L_editato As Boolean = False
    Public Sub New(ByRef _BSF As BindingSource, ByRef _BSFU As BindingSource,
                   ByVal _ID_dip As Integer)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()


        BS_utentiformazione.DataSource = _BSFU.DataSource
        BS_utentiformazione.DataMember = _BSFU.DataMember
        '        BS_utentiformazione = _BSFU

        If BS_utentiformazione.Count > 0 Then
            Dim RGFU As DS_utenti.DT_utentiformazioneRow
            RGFU = DirectCast(BS_utentiformazione.Current, DataRowView).Row
            OldID = RGFU.id
        End If
        ID_dip = _ID_dip

    End Sub
    Private Sub FRM_Formazione_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TA_formazione.Fill(Me.DS_utenti.DT_formazione)
        Dim RGFU As DS_utenti.DT_utentiformazioneRow = Nothing
        If BS_utentiformazione.Count < 1 Then
            Try
                BS_utentiformazione.AddNew()
                RGFU = DirectCast(BS_utentiformazione.Current, DataRowView).Row
            Catch ex As Exception
            End Try
            Dim I_nuovoDT As DateTime = Now().ToShortDateString
            ''inserisce il nuovo codice ID nella colonna corretta
            RGFU.dt_for = I_nuovoDT
        Else
            Dim Tpos As Integer = 0
            'cerca di posizionarsi sulla riga corretta
            For Each pp In BS_utentiformazione
                Tpos += 1
                RGFU = DirectCast(pp, DataRowView).Row
                If RGFU.id = OldID Then
                    Exit For
                End If
                BindingNavigatorMoveNextItem.PerformClick()
            Next
        End If
    End Sub

    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        Dim RGFU As DS_utenti.DT_utentiformazioneRow

        For Each TT In BS_utentiformazione
            RGFU = DirectCast(TT, DataRowView).Row
            If RGFU.RowState <> DataRowState.Unchanged Then
                ''If MsgBox("ATTENZIONE, mancato salvataggio dati Formazione del " & RGFU.dt_for & " confermi ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                'ConfermaFormazione()
                'Else
                '    BS_utentiformazione.CancelEdit()
                '    L_editato = False
                '    Exit For
                'End If
            End If
        Next
        Me.Close()
    End Sub

    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        ConfermaFormazione()
    End Sub

    Private Function F_controlloCoerenzaFormazione(ByRef o As Object)
        'Dim o As DS_utenti.DT_utentiformazioneRow = Nothing
        o.note = If(o.IsnoteNull, "", o.note)
        o.dt_for = If(o.Isdt_forNull, Now(), o.dt_for)
        o.id_dip = If(o.Isid_dipNull, ID_dip, o.id_dip)
        o.id_for = If(o.Isid_forNull, 1, o.id_for)
        Return True
    End Function

    Private Sub ConfermaFormazione()
        BS_utentiformazione.EndEdit()
        Dim RGFU As DS_utenti.DT_utentiformazioneRow
        RGFU = DirectCast(BS_utentiformazione.Current, DataRowView).Row
        If RGFU.RowState = DataRowState.Added Then
            Try
                F_controlloCoerenzaFormazione(RGFU)
                TA_utentiformazione.QR_inserisce(RGFU.id_dip, RGFU.id_for, RGFU.dt_for, RGFU.note)
                RGFU.AcceptChanges()
                L_editato = True
            Catch ex As Exception
            End Try
        ElseIf RGFU.RowState = DataRowState.Modified Then
            Try
                F_controlloCoerenzaFormazione(RGFU)
                TA_utentiformazione.QR_modifica(RGFU.id_dip, RGFU.id_for, RGFU.dt_for, RGFU.note, RGFU.id)
                RGFU.AcceptChanges()
                L_editato = True
            Catch ex As Exception

            End Try
        End If
    End Sub
    Private Sub EliminaFormazione()
        Dim RGFU As DS_utenti.DT_utentiformazioneRow
        RGFU = DirectCast(BS_utentiformazione.Current, DataRowView).Row
        TA_utentiformazione.QR_elimina(RGFU.id)
        RGFU.Delete()

    End Sub

    Private Sub TTBTAggiunge_Click(sender As Object, e As EventArgs) Handles TTBTAggiunge.Click
        Dim RGFU As DS_utenti.DT_utentiformazioneRow
        BS_utentiformazione.AddNew()
        RGFU = DirectCast(BS_utentiformazione.Current, DataRowView).Row
        Dim I_nuovoDT As DateTime = Now().ToShortDateString
        ''inserisce il nuovo codice ID nella colonna corretta
        RGFU.dt_for = I_nuovoDT
        CB_descrizione.Focus()

    End Sub

    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs) Handles TTBTElimina.Click
        Dim RGFU As DS_utenti.DT_utentiformazioneRow
        RGFU = DirectCast(BS_utentiformazione.Current, DataRowView).Row

        If MsgBox("Elimino la formazione del " & RGFU.dt_for & " ?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            TA_utentiformazione.QR_elimina(RGFU.id)
        End If
    End Sub
End Class