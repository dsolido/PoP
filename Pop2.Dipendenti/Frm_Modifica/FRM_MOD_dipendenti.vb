Public Class FRM_MOD_dipendenti
    Dim DT_D As DataTable = Nothing
    Dim G_AZ = GlobalVarPOP.G_idAZ
    Dim Nuovo As Boolean = False
    Dim Nid As Integer = -1
    Public Sub New(ByRef _DT_dip As DataTable, Optional ByVal _Nid As Integer = -1,
                    Optional ByRef _nuovo As Boolean = False)

        ' La chiamata è richiesta dalla finestra di progettazione.
        InitializeComponent()
        'BS_utenti.DataMember = _DT_dip.TableName
        BS_utenti.DataSource = _DT_dip
        '
        BS_utenti.Position = BS_utenti.Find("id", _Nid)
        Nuovo = _nuovo
        If Nuovo Then
            BS_utenti.AddNew()
            Dim o As DS_utenti.DT_utentiRow = Nothing
            o = DirectCast(BS_utenti.Current, DataRowView).Row
            o.id = _Nid
            Dim RND As New Random
            o.pwd = RND.Next(9999)
            o.id_qr = _Nid
            Nuovo = True
        End If

        Nid = _Nid


    End Sub
    Private Sub FRM_MOD_dipendenti_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.TA_livelli.Fill(Me.DS_utenti.DT_livelli)
        Catch ex As Exception

        End Try
        If Nid > 0 Then
            Dim RG As DS_utenti.DT_utentiRow
            RG = DirectCast(BS_utenti.Current, DataRowView).Row
            RG.id = Nid
            'BS_livelli.Position = BS_livelli.Find("id", RG.livello)
        End If
        'PictureBox1.Image = Image.FromStream(BS_foto.Item("foto"))

    End Sub
    Private Sub TTBTTermina_Click(sender As Object, e As EventArgs) Handles TTBTTermina.Click
        If Nuovo Then
            Dim o As DS_utenti.DT_utentiRow = Nothing
            o = DirectCast(BS_utenti.Current, DataRowView).Row
            o.Delete()
        End If
        BS_utenti.CancelEdit()
        Me.Close()
    End Sub


    Private Sub TTBTSalva_Click(sender As Object, e As EventArgs) Handles TTBTSalva.Click
        Dim o As DS_utenti.DT_utentiRow
        o = DirectCast(BS_utenti.Current, DataRowView).Row

        BS_utenti.EndEdit()
        Select Case o.RowState
            'datarowState.
            Case = DataRowState.Modified
                o.data_creazione = Now.ToShortDateString
                Try
                    If Not F_controlloCoerenza(o) Then
                        Return
                    End If

                    TA_utenti.QR_modifica(o.id, o.id_qr, o.pwd, o.nome, o.cognome, o.cf, o.id_terminale, o.titolo, o.data_creazione,
                                              o.indirizzo, o.citta, o.provincia, o.cap, o.nazione, o.stato, o.telefono, o.cellulare, o.emailname, o.dataass, o.datalic,
                                              o.livello, o.ore, o.datanascita, o.luogonascita, o.provnascita, o.nazionalita, o.tagliadivisa, o.numeropiedi,
                                              o.note, 0, o.dat_lic, o.licenzio, o.interinale, G_AZ, o.user, o.pwd, o.id_progressivo)
                    o.AcceptChanges()
                Catch ex As Exception
                    Return
                End Try
            Case = DataRowState.Added
                Try
                    If Not F_controlloCoerenza(o) Then
                        Return
                    End If

                    o.stato = 1 ' imposta lo stato come attivo
                    TA_utenti.QR_Inserisce(o.id, o.id_qr, o.pwd, o.nome, o.cognome, o.cf, o.id_terminale, o.titolo, o.data_creazione,
                                          o.indirizzo, o.citta, o.provincia, o.cap, o.nazione, o.stato, o.telefono, o.cellulare, o.emailname, o.dataass, o.datalic,
                                          o.livello, o.ore, o.datanascita, o.luogonascita, o.provnascita, o.nazionalita, o.tagliadivisa, o.numeropiedi,
                                          o.note, 0, o.dat_lic, o.licenzio, o.interinale, G_AZ, o.user, o.pwd)
                    o.AcceptChanges()

                Catch ex As Exception
                    Return
                End Try
        End Select

        Me.Close()

    End Sub
    Private Function F_controlloCoerenza(ByRef o As DS_utenti.DT_utentiRow)

        o.cap = If(o.IscapNull, "00000", o.cap)
        o.titolo = If(o.IstitoloNull, "Sig.", ProperCase(o.titolo))
        If o.IscognomeNull Then
            MsgBox("Inserisci il cognome")
            Return False
        End If
        If o.IsnomeNull Then
            MsgBox("Inserisci il nome")
            Return False
        End If
        o.cf = If(o.IscfNull, "", o.cf.ToUpper)                             'Converte in Maiuscolo
        o.citta = If(o.IscittaNull, "", StrConv(o.citta, vbProperCase))     'Prima lettera Maiuscola
        o.provincia = If(o.IsprovinciaNull, "", o.provincia.ToUpper)          'Tutto Maiuscolo
        o.indirizzo = If(o.IsindirizzoNull, "", StrConv(o.indirizzo, vbProperCase))
        o.provnascita = If(o.IsprovnascitaNull, o.provincia, o.provnascita.ToUpper) 'Maiuscolo
        o.numeropiedi = If(o.IsnumeropiediNull, "0", o.numeropiedi)
        o.interinale = If(o.IsinterinaleNull, 0, o.interinale)
        o.licenzio = If(o.IslicenzioNull, 0, o.licenzio)                      'se non selezionato lo imposta a 0
        o.interinale = If(o.IsinterinaleNull, 0, o.interinale)
        o.id_terminale = If(o.Isid_terminaleNull, 1, o.id_terminale)                                             ' Blocca l'azienda
        o.data_creazione = Now()
        o.telefono = If(o.IstelefonoNull, "", o.telefono)
        o.cellulare = If(o.IscellulareNull, "", o.cellulare)
        o.emailname = If(o.IsemailnameNull, "", o.emailname)
        o.dataass = If(o.IsdataassNull, Now().ToShortDateString, o.dataass)
        o.datalic = If(o.IsdatalicNull, DateTime.Parse("1900-01-01"), o.datalic)
        o.datanascita = If(o.IsdatanascitaNull, Now().AddYears(-20).ToShortDateString, o.datanascita)
        o.luogonascita = If(o.IsluogonascitaNull, o.citta, o.luogonascita)
        o.nazione = If(o.IsnazioneNull, "ITALIA", o.nazione)
        o.nazionalita = If(o.IsnazionalitaNull, "Italiana", o.nazionalita)
        o.dat_lic = If(o.Isdat_licNull, DateTime.Parse("1900-01-01"), o.dat_lic)
        o.note = If(o.IsnoteNull, "", o.note)
        o.livello = If(o.IslivelloNull, 1, o.livello)
        o.ore = If(o.IsoreNull, 0, o.ore)
        'o.pwd = If(o.ispwdNull, 0, o.pwd)
        o.id_qr = If(o.Isid_qrNull, 0, o.id_qr)
        o.tagliadivisa = If(o.IstagliadivisaNull, "", o.tagliadivisa)
        Dim t1 As String = o.cognome
        Dim t2 As String = o.nome
        t1 = t1.Substring(0, 1).ToUpperInvariant & t1.Substring(1, 1)

        t2 = t2.Substring(0, 1).ToUpper & t2.Substring(1)
        o.user = If(o.IsuserNull, t1 & t2, o.user)
        Return True
    End Function
    Private Sub TTBTannulla_Click(sender As Object, e As EventArgs)
        BS_utenti.CancelEdit()
        Me.Close()
    End Sub

    Private Sub TTBTStampa_Click(sender As Object, e As EventArgs) Handles TTBTStampa.Click
        Dim ID_dip As DS_utenti.DT_utentiRow
        ID_dip = DirectCast(BS_utenti.Current, DataRowView).Row

        If ID_dip.id > 0 Then
            Dim f As New FRM_stp_Tesserino(ID_dip.id)
            f.Show()
        End If
    End Sub
    Private Sub TTBTElimina_Click(sender As Object, e As EventArgs)
        Dim rg As DS_utenti.DT_utentiRow
        rg = DirectCast(BS_utenti.Current, DataRowView).Row
        Dim S_anagrafica As String = rg.cognome & " " & rg.nome
        Dim L_rsp As MsgBoxResult = MsgBox("Elimino definitivamente " & S_anagrafica & " o modifico lo STATO", MsgBoxStyle.YesNoCancel, "Elimino")
        Select Case L_rsp
            Case MsgBoxResult.Yes
                Using TA As New DS_utentiTableAdapters.TA_utenti
                    TA.QR_elimina(rg.id)
                End Using
            Case MsgBoxResult.No
                Using TA As New DS_utentiTableAdapters.TA_utenti
                    TA.QR_modificaStatoByID(0, rg.id)
                End Using

            Case MsgBoxResult.Cancel
                Return
        End Select
    End Sub

    Private Declare Sub Sleep Lib "kernel32.dll" (ByVal milliSec As Long)

    Private Sub LicenzioCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles LicenzioCheckBox.Click
        If LicenzioCheckBox.Checked Then
            Dim iddip As Integer = DirectCast(bs_Utenti.Current, DataRowView).Row.Field(Of Integer)("id_progressivo")
            Dim risp As MsgBoxResult
            risp = MsgBox("Riassegno tutti i lavori e gli abbinamenti al dipendente XXXX ?", MsgBoxStyle.YesNo)

            If risp = MsgBoxResult.Yes Then
                Using dt As New DS_utenti.DT_orariDataTable
                    Using ta As New DS_utentiTableAdapters.TA_orari
                        ta.FillBydipendente(dt, iddip)
                        ttProgressbar.Maximum = dt.Count
                        ttProgressbar.Value = 0
                        For Each rg In dt
                            rg.id_dip = 10
                            ta.QR_Assegna_IDUtente(rg.id_dip, rg.id)
                            ttProgressbar.Value += 1
                            Application.DoEvents()
                            Sleep(100)
                        Next
                        ttProgressbar.Value = 0
                        MsgBox("Riassegnati n° " + ttProgressbar.Maximum.ToString() + " Programmi di lavoro")
                    End Using
                End Using

            End If

            risp = MsgBox("Elimino tutti gli abbinamenti con i clienti al dipendente XXXX ?", MsgBoxStyle.YesNo)

            If risp = MsgBoxResult.Yes Then
                Using dt As New DS_utenti.DT_AUDPDataTable
                    Using ta As New DS_utentiTableAdapters.TA_AUDP
                        ta.FillByDipendente(dt, iddip)
                        ttProgressbar.Maximum = dt.Count
                        ttProgressbar.Value = 0
                        For Each rg In dt
                            ta.elimina(rg.id)
                            ttProgressbar.Value += 1
                            Application.DoEvents()
                            Sleep(100)
                        Next
                        ttProgressbar.Value = 0
                        MsgBox("Riassegnati n° " + ttProgressbar.Maximum.ToString() + " Abbinamenti Clienti")
                    End Using
                End Using
            End If
        End If

    End Sub


End Class