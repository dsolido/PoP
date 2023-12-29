Imports MailKit.Net
Public Class FRMmail
    'Dim DestinatarioEmail As String
    'Dim OggettoEmail As String
    'Dim MessaggioEmail As String
    'Dim myMail As MimeKit.MimeMessage
    'Dim Multipart As MimeKit.Multipart

    'Public Sub New(ByVal destinatario As String, Optional oggetto As String = Nothing, Optional messaggio As String = Nothing)
    '    ' La chiamata è richiesta dalla finestra di progettazione.
    '    InitializeComponent()
    '    DestinatarioEmail = destinatario
    '    OggettoEmail = oggetto
    '    MessaggioEmail = messaggio
    '    Multipart = New MimeKit.Multipart("mixed")
    'End Sub
    'Private Sub FRMmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    '    myMail = New MimeKit.MimeMessage
    '    myMail.Sender = New MimeKit.MailboxAddress(GlobalVarPOP.G_nomeutente, GlobalVarPOP.G_emailutente)
    '    TXdestinatario.Text = DestinatarioEmail
    '    RTXmessaggio.Text = MessaggioEmail
    '    TXoggetto.Text = OggettoEmail
    '    PB_mail.Maximum = 100
    '    PB_mail.Value = 0
    'End Sub
    'Private Sub InvioMail()
    '    'Try
    '    '    PB_mail.Value = 20
    '    '    myMail.To.Add(New MimeKit.MailboxAddress(TXdestinatario.Text))
    '    '    myMail.Subject = TXoggetto.Text
    '    '    'myMail.HtmlBody = False
    '    '    Dim sText As New MimeKit.TextPart("plain")
    '    '    sText.SetText("UTF-8", RTXmessaggio.Text)
    '    '    PB_mail.Value = 30

    '    '    Multipart.Add(sText)
    '    '    myMail.Body = multipart
    '    '    Using smtp = New MailKit.Net.Smtp.SmtpClient()
    '    '        smtp.CheckCertificateRevocation = False
    '    '        Dim smtpServer As String = globalVarPop.G_indirizzosmtp
    '    '        PB_mail.Value = 40
    '    '        Dim Utente As String = globalVarPop.G_emailutente
    '    '        Dim Pass As String = globalVarPop.G_pwdutente
    '    '        smtp.Connect(smtpServer, 25, MailKit.Security.SecureSocketOptions.None)
    '    '        PB_mail.Value = 60
    '    '        smtp.Authenticate(Utente, Pass)
    '    '        smtp.Send(myMail)
    '    '        PB_mail.Value = 80
    '    '        smtp.Disconnect(True)
    '    '        PB_mail.Value = 100
    '    '    End Using
    '    '    LBX_esito.Items.Add("Email inviata con successo " & Now().ToShortTimeString)
    '    '    PB_mail.Value = 0
    '    'Catch se As MailKit.ProtocolException
    '    '    LBX_esito.Items.Add("Problema invio")
    '    '    LBX_esito.Items.Add(se.ToString)
    '    'End Try
    'End Sub

    'Private Sub BTNinvio_Click(sender As Object, e As EventArgs) Handles BTNinvio.Click
    '    InvioMail()
    '    Me.Close()
    'End Sub

    'Private Sub BT_termina_Click(sender As Object, e As EventArgs) Handles BTtermina.Click
    '    Me.Close()
    'End Sub

    'Private Sub BTAllega_Click(sender As Object, e As EventArgs) Handles BTAllega.Click
    '    Dim File As String
    '    cercaallegato.ShowDialog()
    '    File = cercaallegato.FileName
    '    Dim Allegato As MimeKit.MimePart = New MimeKit.MimePart("documento", "pdf")
    '    Allegato.Content = New MimeKit.MimeContent(System.IO.File.OpenRead(File))
    '    Allegato.ContentDisposition = New MimeKit.ContentDisposition(MimeKit.ContentDisposition.Attachment)
    '    Allegato.ContentTransferEncoding = MimeKit.ContentEncoding.Base64
    '    Allegato.FileName = cercaallegato.SafeFileName

    '    Multipart.Add(Allegato)
    '    myMail.Body = Multipart
    '    Disegnaallegati(cercaallegato.SafeFileName)
    'End Sub
    'Private Sub Disegnaallegati(ByVal nome As String)
    '    ' Create three items and three sets of subitems for each item.
    '    Dim item1 As New ListViewItem(nome, 0)
    '    LWelenco.Items.Add(item1)
    '    ' Create two ImageList objects.

    'End Sub
    'Public Function SelezionaLinea(ByVal lineNumber As Integer, ByVal richTextBox As RichTextBox)
    '    Dim linea As Integer = 0
    '    For i As Integer = 0 To lineNumber - 1 'Calcola nr caratt. dalla Ia linea fino all'inizio della linea da selezionare (lineNumber)       
    '        linea += richTextBox.Lines(i).Length
    '        linea += 1
    '    Next
    '    Dim length As Integer = richTextBox.Lines(lineNumber).Length 'nr caratteri della linea da selezionare       
    '    RTXmessaggio.[Select](linea, length) 'seleziona a partire da "linea" un nr di caratteri pari a "lenght"
    'End Function
    'Private Sub BTFirma_Click(sender As Object, e As EventArgs) Handles BTFirma.Click
    '    Dim Daz(9) As String
    '    Daz(0) = "Pegaso srl "
    '    Daz(1) = "pulizia-sanificazione - disinfestazione"
    '    Daz(2) = "via Cesare Battisti, 5"
    '    Daz(3) = "IT-20010 - Canegrate - MI"
    '    Daz(4) = "tel: +39.0331.407226 / +39.0331.407927"
    '    Daz(5) = "mail " & GlobalVarPOP.G_emailutente
    '    Daz(6) = "P.IVA 122.69.440.157"
    '    Daz(7) = "In conformità al nuovo Regolamento Europeo GDPR n. 679/2016, le informazioni contenute in questo messaggio, così come i relativi allegati, sono strettamente riservate e confidenziali. Il loro utilizzo è consentito esclusivamente al destinatario del messaggio, per le finalità indicate nel messaggio stesso. Qualora lei non fosse la persona a cui il presente messaggio è destinato, la invitiamo ad eliminarlo ed a distruggere le varie copie o stampe, dandocene gentilmente comunicazione. Ogni utilizzo improprio è contrario ai principi del nuovo Regolamento Europeo GDPR n. 679/2016. PEGASO SRL opera in conformità al nuovo Regolamento Europeo GDPR n. 679/2016. Per qualsiasi informazione potete consultare il nostro sito internet."
    '    Daz(8) = "The Information contained in this message as well as the attached file(s) are highly confidential And are only intended for the person to whom it Is addressed. If the reader of this message Is Not the intended recipient Or if you have received this communication in error, please be aware that any dissemination, distribution Or duplication Is strictly prohibited pursuant to the Regulation EU n. 2016/679 And can be illegal. Please notify us immediately And delete all copies from your mailbox And other archives. PEGASO SRL operates in compliance with the New European Regulation GDPR no. 679/2016. For more information visit our website."
    '    Daz(9) = "".PadLeft(30, "_")

    '    'Se trova corrispondenza elimina la Firma Vecchia
    '    RTXmessaggio.Find(Daz(9), RichTextBoxFinds.MatchCase)
    '    Dim inizioRiga As Integer
    '    Dim fineRiga As Integer
    '    Dim inizioFrase As Integer = RTXmessaggio.SelectionStart

    '    inizioRiga = RTXmessaggio.GetLineFromCharIndex(RTXmessaggio.SelectionStart)
    '    RTXmessaggio.Find(Daz(8), RichTextBoxFinds.MatchCase)
    '    fineRiga = RTXmessaggio.GetLineFromCharIndex(RTXmessaggio.SelectionStart) - 3
    '    If fineRiga > 0 Then
    '        'For T = 0 To 8
    '        'inizioRiga = RTXmessaggio.Find(Daz(T), RichTextBoxFinds.None)
    '        Dim linea As Integer = 0
    '        For i As Integer = inizioRiga To fineRiga 'Calcola nr caratt. dalla Ia linea fino all'inizio della linea da selezionare (lineNumber)  
    '            linea += RTXmessaggio.Lines(i).Length
    '            linea += 1
    '        Next
    '        Dim length As Integer = RTXmessaggio.Lines(fineRiga).Length
    '        RTXmessaggio.Select(inizioFrase, linea)
    '        RTXmessaggio.SelectedText = ""
    '    End If
    '    RTXmessaggio.AppendText(Daz(9))
    '    RTXmessaggio.Find(Daz(9), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 10, FontStyle.Regular)
    '    RTXmessaggio.SelectionColor = Color.Black
    '    RTXmessaggio.AppendText(vbCr)
    '    RTXmessaggio.AppendText(Daz(0))
    '    RTXmessaggio.Find(Daz(0), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 12, FontStyle.Bold)
    '    RTXmessaggio.SelectionColor = Color.SteelBlue
    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Daz(1))
    '    RTXmessaggio.Find(Daz(1), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 8, FontStyle.Bold)
    '    RTXmessaggio.SelectionColor = Color.SteelBlue
    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Daz(2))
    '    RTXmessaggio.Find(Daz(2), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 10, FontStyle.Italic)
    '    RTXmessaggio.SelectionColor = Color.SteelBlue
    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Daz(3))
    '    RTXmessaggio.Find(Daz(3), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 10, FontStyle.Italic)
    '    RTXmessaggio.SelectionColor = Color.SteelBlue
    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Daz(4))
    '    RTXmessaggio.Find(Daz(4), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 10, FontStyle.Italic)
    '    RTXmessaggio.SelectionColor = Color.SteelBlue

    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Daz(5))
    '    RTXmessaggio.Find(Daz(5), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 8, FontStyle.Italic)
    '    RTXmessaggio.SelectionColor = Color.SteelBlue

    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Daz(6))
    '    RTXmessaggio.Find(Daz(6), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 8, FontStyle.Italic)
    '    RTXmessaggio.SelectionColor = Color.SteelBlue
    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Daz(7))
    '    RTXmessaggio.Find(Daz(7), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 7, FontStyle.Italic)
    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Chr(13))
    '    RTXmessaggio.AppendText(Daz(8))
    '    RTXmessaggio.Find(Daz(8), RichTextBoxFinds.MatchCase)
    '    RTXmessaggio.SelectionFont = New Font("Verdana", 7, FontStyle.Italic)

    'End Sub
End Class