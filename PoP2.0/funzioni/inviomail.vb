Module inviomail

    Public Sub inviaemail()

        Dim richiedeAutenticazione As Boolean = True
        Dim richiedeConnessioneProtetta As Boolean = True
        Dim smtpHost As String = “smtps.aruba.it”
        Dim smtpPort As Integer = 465 '25 default, 465 or 587 for what your provider wants..
        Dim username As String = “info@pegason.it”
        Dim password As String = “trichi”
        Dim allegato As String = “C:\Users\utente\Desktop\Temporanea\frame.png”
        Dim EmailMittente As String = “danilo@pegason.it”
        Dim NomeMittente As String = “Danilo Enrico Solidoro”
        Dim MailConfermaLettura As Boolean = True
        Dim MailConfermaRecapito As Boolean = True
        Dim invioAsincrono As Boolean = True

        Dim smtp As System.Net.Mail.SmtpClient
        smtp = New System.Net.Mail.SmtpClient

        Dim mail As System.Net.Mail.MailMessage
        mail = New System.Net.Mail.MailMessage

        Try

            If richiedeAutenticazione Then
                smtp.UseDefaultCredentials = False
                smtp.Credentials = New System.Net.NetworkCredential(username, password)
            Else
                smtp.UseDefaultCredentials = True
                smtp.Credentials = System.Net.CredentialCache.DefaultNetworkCredentials
            End If
            If richiedeConnessioneProtetta Then
                smtp.EnableSsl = True
            Else
                smtp.EnableSsl = False
            End If
            smtp.UseDefaultCredentials = True

            smtp.Host = smtpHost
            smtp.Port = smtpPort

            If String.IsNullOrEmpty(allegato) = False And IO.File.Exists(allegato) Then
                mail.Attachments.Add(New System.Net.Mail.Attachment(allegato))
            End If

            'INDIRIZZI
            'mittente
            mail.From = New System.Net.Mail.MailAddress(EmailMittente, NomeMittente)
            mail.Sender = New System.Net.Mail.MailAddress(EmailMittente, NomeMittente)
            'destinatari
            mail.To.Add(New System.Net.Mail.MailAddress(“info@pegason.it”, “info Pegaso”))
            'copia conoscenza
            mail.CC.Add(New System.Net.Mail.MailAddress(“dsolido@gmail.com”, “danilo dsolido”))
            'copia conoscenza nascosta
            mail.Bcc.Add(New System.Net.Mail.MailAddress(“d_solido@yahoo.it”, “danilo yahoo”))

            'chi farà rispondi alla mail, in automatico si troverà questo indirizzo
            mail.ReplyToList.Add(New System.Net.Mail.MailAddress(EmailMittente, NomeMittente))

            mail.Subject = “Prova di invio”
            mail.SubjectEncoding = System.Text.Encoding.UTF8

            mail.Body = “Corpo del messaggio, se in HTML e il destinatario è abilitato alla lettura in html, vedrà una pagina ben formattata, altrimenti solo testo..”
            mail.BodyEncoding = System.Text.Encoding.UTF8
            mail.IsBodyHtml = True

            'CONFERMA LETTURA
            If MailConfermaLettura = True Then
                mail.Headers.Add(“Disposition-Notification-To”, EmailMittente)
            End If

            'CONFERMA RECAPITO
            If MailConfermaRecapito = True Then
                mail.Headers.Add(“Return-Receipt-To”, EmailMittente)
                mail.DeliveryNotificationOptions = Net.Mail.DeliveryNotificationOptions.OnFailure Or Net.Mail.DeliveryNotificationOptions.OnSuccess
            End If

            mail.Priority = Net.Mail.MailPriority.High

            If invioAsincrono Then
                AddHandler smtp.SendCompleted, AddressOf SendCompletedCallback
                Dim mioparametro As Object = “qualsiasi cosa”
                smtp.SendAsync(mail, mioparametro)
            Else
                smtp.Send(mail)
                'invio basilare, ovviamente tutto il codice sopra non serve
                'With New System.Net.Mail.SmtpClient(smtpHost, smtpPort)
                '.Send(EmailMittente, “destinatario@mail.it”, “Oggetto mail”, “Testo mail”)
                'End With
            End If

        Catch smtpEx1 As System.Net.Mail.SmtpFailedRecipientsException
            'mail non inviata a nessuno!
            MsgBox(“Errore SMTP: ” & smtpEx1.Message, MsgBoxStyle.Exclamation, “Attenzione”)

        Catch smtpEx2 As System.Net.Mail.SmtpFailedRecipientException
            'mail non inviata ad alcuni destinatari
            MsgBox(“Errore SMTP: ” & smtpEx2.Message, MsgBoxStyle.Exclamation, “Attenzione”)

        Catch smtpEx3 As System.Net.Mail.SmtpException
            'errore di invio mail
            Dim risp As Object
            Try
                risp = smtpEx3.InnerException.ToString
            Catch ex As Exception
                risp = Nothing
            End Try

            If risp = Nothing Then
                risp = " "
            End If

            MsgBox(“Errore invio mail: ” & smtpEx3.Message & " " & risp, MsgBoxStyle.Exclamation, “Attenzione”)

        Catch ex As Exception
            'errore generale
            MsgBox(“Errore invio mail: ” & ex.Message, MsgBoxStyle.Exclamation, “Attenzione”)
        Finally
            'boh fate voi…

        End Try

    End Sub

    Private Sub SendCompletedCallback(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
        Dim mioparametro As Object = e.UserState
        Dim mailInviata As Boolean = False
        Dim risultato As String = “”
        If e.Cancelled Then
            mailInviata = False
            risultato = “Invio annullato”
        End If
        If IsNothing(e.Error) Then
            mailInviata = True
            risultato = “Messaggio inviato”
        Else
            mailInviata = False
            risultato = “Mail NON inviata: ” & e.Error.Message
        End If
        MsgBox(String.Format(“Mail Inviata: {0}; Risultato: {1}”, mailInviata, risultato), MsgBoxStyle.Exclamation, “Attenzione”)
    End Sub


End Module
