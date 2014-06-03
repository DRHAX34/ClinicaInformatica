Public Class LoginForm
    Public user As Integer
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New ArrayList
        p = BLL.Login.Carregar_empresas
        Companybox.DataSource = p
        Me.Text = Application.ProductName & " Versão: " & Application.ProductVersion
        If Not Companybox.Items.Count = Nothing Then
            Companybox.SelectedIndex = 0
        End If
        Dim login As New Bitmap(My.Resources.Entrar, loginbutton.Width, loginbutton.Height)
        Dim sair As New Bitmap(My.Resources.Sair, exitbutton.Width, exitbutton.Height)
        Dim Ajuda As New Bitmap(My.Resources.Ajuda, buttonhelp.Width, buttonhelp.Height)
        loginbutton.Image = login
        exitbutton.Image = sair
        buttonhelp.Image = Ajuda
        Workspace.FormBorderStyle = 2
        datalabel.Text = System.DateTime.Now.Date
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Usernamelabel.Click

    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Workspace.Close()
    End Sub

    Private Sub helpbutton_Click(sender As Object, e As EventArgs) Handles buttonhelp.Click

    End Sub

    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        Dim n_empresa As Integer
        n_empresa = BLL.Login.return_n_empresa(Companybox.Text)
        user = BLL.Login.Verificar_Login(UsernameBox.Text, Passwordbox.Text, n_empresa)
        If user <> 0 Then
            'menuform.show()
            Workspace.StatusStrip.Show()
            Workspace.MenuStrip.Show()
            BLL.n_empresa = n_empresa
            Dim teste As Object =
            Workspace.modo = 2
                Me.Hide()
            Else
                user = BLL.Admin_only.Login.Verificar_Login_admin(UsernameBox.Text, Passwordbox.Text)
                If user = 0 Then
                    MsgBox("Nome de Utilizador/Palavra-Passe errados!")
                Else
                    Workspace.StatusStrip.Show()
                    Workspace.MenuStrip.Show()
                    Workspace.modo = 1
                    Me.Hide()
                End If
            End If
    End Sub
End Class
