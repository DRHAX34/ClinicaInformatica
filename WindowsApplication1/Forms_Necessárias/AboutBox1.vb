Public NotInheritable Class AboutBox1

    Private Sub AboutBox1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Configura o titulo do formulário.
        Dim ApplicationTitle As String
        If My.Application.Info.Title <> "" Then
            ApplicationTitle = My.Application.Info.Title
        Else
            ApplicationTitle = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If
        Me.Text = String.Format("Sobre {0}", ApplicationTitle)
        ' Inicializa todo o texto exibido na About Box.
        ' TODO: Personalize o assembly da aplicação no painel "Application" das propriedades do projeto 
        '    (abaixo do menu"Project").
        Me.versaolabel.Text = String.Format("Versão {0}", My.Application.Info.Version.ToString)
        Dim logo As Bitmap = PictureBox1.Image
        logo.MakeTransparent(Color.White)
        PictureBox1.Image = logo
    End Sub
    Private Sub closewhenlostfocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.lostfocus
        Me.Close()
    End Sub
    Private Sub closewhenmousecapturechanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class
