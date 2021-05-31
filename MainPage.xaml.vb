' O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

Imports Windows.ApplicationModel.Email
''' <summary>
''' Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Dim MyEmail As EmailMessage = New EmailMessage()
    Dim SendTo As String = "lumiamodels@outlook.com"
    Dim MailSubject As String = "Sent via MyMail by @LumiaModels and @Hbisneto"
    Dim MailPlaceHolder As String = "I would like to help LumiaModels be better. That would be great if you implement..."

    Private Async Sub SendEmail_Tapped(sender As Object, e As TappedRoutedEventArgs) Handles SendEmail.Tapped
        Dim EmailAddress = New Windows.ApplicationModel.Email.EmailRecipient(EmailString.Text)
        MyEmail.Subject = SubjectString.Text
        MyEmail.Body = EmailBody.Text
        MyEmail.To.Add(EmailAddress)

        Await Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(MyEmail)
    End Sub

    Private Sub Page_Loaded(sender As Object, e As RoutedEventArgs)
        EmailString.Text = SendTo
        SubjectString.Text = MailSubject
        EmailBody.PlaceholderText = MailPlaceHolder
    End Sub
End Class
