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
        Workspace.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
        Workspace.MaximizeBox = False
        datalabel.Text = System.DateTime.Now.Date
        Me.AcceptButton = Me.loginbutton
        DAL.CreateConnection()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Usernamelabel.Click

    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Workspace.Close()
    End Sub

    Private Sub helpbutton_Click(sender As Object, e As EventArgs) Handles buttonhelp.Click
        Recuperação_pass.MdiParent = Workspace
        Recuperação_pass.Show()
    End Sub

    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click
        Dim n_empresa As Integer
        Dim check As Boolean = False
        If Companybox.Items.Count <> 0 Then
            n_empresa = BLL.Login.return_n_empresa(Companybox.SelectedItem.ToString)
        Else
            n_empresa = 0
        End If
        Dim password As String = Passwordbox.Text
        Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
        Dim passencript As String = wrapper.EncryptData(password)
        If BLL.Admin_only.Login.check_admin_geral() = 0 Then
            Workspace.varias_empresas = False
        End If
        user = BLL.Login.Verificar_Login(UsernameBox.Text, passencript, n_empresa)
        Dim tipo As String = ""
        If user <> 0 Then
            'menuform.show()
            Workspace.StatusStrip.Show()
            Workspace.MenuStrip.Show()
            Workspace.tecnicosmenu.Enabled = True
            If BLL.Login.verificar_admin(user) = True Then
                Workspace.UtilizadoresToolStripMenuItem.Visible = True
                Workspace.utilativos.Visible = True
                Workspace.utilremovidos.Visible = True
                Workspace.tecnicosmenu.Visible = True
                Workspace.admin = True
                Workspace.admin_geral = False
                tipo = "Administrador"
            Else
                Workspace.UtilizadoresToolStripMenuItem.Visible = True
                Workspace.utilativos.Visible = False
                Workspace.utilremovidos.Visible = False
                Workspace.tecnicosmenu.Visible = False
                Workspace.admin = False
                Workspace.admin_geral = False
                tipo = "Utilizador Padrão"
            End If
            Workspace.clientesmenu.Enabled = True
            Workspace.dispositivosmenu.Enabled = True
            Workspace.reparacoesmenu.Enabled = True
            Workspace.empresasativas.Visible = False
            Workspace.empresasremovidas.Visible = False
            Workspace.modo = 2
            check = True
        Else
            user = BLL.Admin_only.Login.Verificar_Login_admin(UsernameBox.Text, passencript)
            If user = 0 Then
                MsgBox("Nome de Utilizador/Palavra-Passe errados!")
            Else
                Workspace.StatusStrip.Show()
                Workspace.MenuStrip.Show()
                Workspace.UtilizadoresToolStripMenuItem.Visible = True
                Workspace.clientesmenu.Enabled = False
                Workspace.dispositivosmenu.Enabled = False
                Workspace.reparacoesmenu.Enabled = False
                Workspace.tecnicosmenu.Enabled = False
                Workspace.empresasativas.Visible = True
                Workspace.empresasremovidas.Visible = True
                Workspace.utilativos.Visible = True
                Workspace.utilremovidos.Visible = True
                Workspace.admin = False
                Workspace.admin_geral = True
                Workspace.modo = 1
                check = True
                tipo = "Administrador Geral"
            End If
        End If
        If check = True Then
            If BLL.Login.verificar_aluno(n_empresa) = True Then
                Workspace.Aluno = True
            End If
            Workspace.companyname1 = Companybox.Text
            BLL.n_empresa = n_empresa
            Workspace.login_load()
            Workspace.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            Workspace.MaximizeBox = True
            Workspace.string_pass = passencript
            'Workspace.UtilizadoresToolStripMenuItem.Text = UsernameBox.Text
            Workspace.Label1.Text = UsernameBox.Text
            Workspace.Label2.Text = tipo
            Workspace.Label1.Show()
            Workspace.Label2.Show()
            Workspace.Label1.BringToFront()
            Workspace.Label2.BringToFront()
            Workspace.user = user
            Me.Close()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Workspace.Close()
    End Sub

    Private Sub RadClock1_Click(sender As Object, e As EventArgs) Handles RadClock1.Click

    End Sub
End Class
