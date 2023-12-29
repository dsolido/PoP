Imports MySql.Data.MySqlClient

Public Class Frm_login


    Private Sub F_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.TA_credenziali.Fill(Me.DS_servizio.DT_credenziali)
        For Each rgUt As DS_servizio.DT_credenzialiRow In Me.DS_servizio.DT_credenziali.Rows
            GlobalVarPOP.gArrayColoreUtenti.Add(rgUt.colore)
            GlobalVarPOP.gArrayNomeUtenti.Add(rgUt.uid)
        Next
#If DEBUG Then
        Dim rg As DS_servizio.DT_credenzialiRow
        BS_credenziali.MoveLast()
        rg = DirectCast(BS_credenziali.Current, DataRowView).Row
        Dim f As New frmavvio(rg)
        f.Show()
#End If

    End Sub

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim rg As DataRow
        rg = F_CercaUtente()
        If rg("id") > 0 Then
            Dim f As New frmavvio(rg)
            f.Show()
            Me.Close()
        Else
            UsernameTextBox.Text = ""
            PasswordTextBox.Text = ""
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub


    Private Function F_CercaUtente() As DataRow
        BS_credenziali.Filter = String.Format("uid = '{0}' AND pwd = '{1}'", Me.UsernameTextBox.Text, Me.PasswordTextBox.Text)
        If BS_credenziali.Count > 0 Then
            Dim rg As DS_servizio.DT_credenzialiRow
            rg = DirectCast(BS_credenziali.Current, DataRowView).Row
            Return rg
        Else
            Dim rg As DS_servizio.DT_credenzialiRow
            BS_credenziali.AddNew()
            rg = DirectCast(BS_credenziali.Current, DataRowView).Row

            rg.gradoaccesso = 0
            rg.id = 0
            rg.id_az = 0
            rg.uid = "Nessun Utente"
            rg.id_web = -1     'Identificativo di collegamento con Utenti WEB
            rg.id_esterno = -1 'Identificativo di collegamento con Utenti

            Return rg
        End If

    End Function

End Class
