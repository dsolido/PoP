Public NotInheritable Class frmSplash

    Private Sub frmSplash_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.TaInformazioniReadme.Fill(Me.DS_servizio.dtInformazioniReadme)

        'Titolo dell'applicazione
        If My.Application.Info.Title <> "" Then
            ApplicationTitle.Text = My.Application.Info.Title
        Else
            'Se il titolo dell'applicazione manca, verrà usato il nome dell'applicazione, senza l'estensione
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        'Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)
        Copyright.Text = My.Application.Info.Copyright
    End Sub
End Class
