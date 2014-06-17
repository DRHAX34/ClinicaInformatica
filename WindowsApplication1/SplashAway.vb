Public NotInheritable Class SplashAway

    'TODO: Este formulário pode ser facilmente configurado como a tela inicial da aplicação através da edição da aba "Aplicação"
    '  no Designer de Projeto ("Propriedades" dentro do menu "Projetos").


    

    Private Sub SplashAway_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        versaolabel.Text = "Versão: " & Application.ProductVersion
    End Sub
End Class
