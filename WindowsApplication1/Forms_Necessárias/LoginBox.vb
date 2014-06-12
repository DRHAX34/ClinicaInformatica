Public Class LoginForm
    Public user As Integer
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim p As New ArrayList
        p = BLL.Login.Carregar_empresas
        Companybox.DataSource = p
        'Me.Text = Application.ProductName & " Versão: " & Application.ProductVersion
        If Not Companybox.Items.Count = Nothing Then
            Companybox.SelectedIndex = 0
        End If
        Dim login As New Bitmap(My.Resources.Entrar, loginbutton.Width, loginbutton.Height)
        Dim sair As New Bitmap(My.Resources.Sair, exitbutton.Width, exitbutton.Height)
        'Dim button As New Bitmap(My.Resources.Sair, sairbutton.Width, sairbutton.Height)
        Dim Ajuda As New Bitmap(My.Resources.Ajuda, buttonhelp.Width, buttonhelp.Height)
        loginbutton.Image = login
        exitbutton.Image = sair
        buttonhelp.Image = Ajuda
        'sairbutton.Image = button
        Workspace.FormBorderStyle = 2
        datalabel.Text = System.DateTime.Now.Date
        Me.AcceptButton = Me.loginbutton
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
        Dim check As Boolean = False
        n_empresa = BLL.Login.return_n_empresa(Companybox.SelectedItem.ToString)
        user = BLL.Login.Verificar_Login(UsernameBox.Text, Passwordbox.Text, n_empresa)
        If user <> 0 Then
            'menuform.show()
            Workspace.StatusStrip.Show()
            Workspace.MenuStrip.Show()
            Workspace.modo = 2
            Me.Hide()
            check = True
        Else
            user = BLL.Admin_only.Login.Verificar_Login_admin(UsernameBox.Text, Passwordbox.Text)
            If user = 0 Then
                MsgBox("Nome de Utilizador/Palavra-Passe errados!")
            Else
                Workspace.StatusStrip.Show()
                Workspace.MenuStrip.Show()
                Workspace.modo = 1
                Me.Hide()
                check = True
            End If
        End If
        If Check = True Then
            If BLL.Login.verificar_aluno(n_empresa) = True Then
                Workspace.Aluno = True
            End If
            Workspace.companyname1 = Companybox.Text
            Workspace.login_load()
            BLL.n_empresa = n_empresa
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Workspace.Close()
    End Sub
End Class
