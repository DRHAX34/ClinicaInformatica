Public Class LoginForm

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Text = Application.ProductName & " Versão: " & Application.ProductVersion
        ComboBox1.SelectedIndex = 0
        Dim login As New Bitmap(My.Resources.Entrar, loginbutton.Width, loginbutton.Height)
        Dim sair As New Bitmap(My.Resources.Sair, exitbutton.Width, exitbutton.Height)
        Dim Ajuda As New Bitmap(My.Resources.Ajuda, buttonhelp.Width, buttonhelp.Height)
        loginbutton.Image = login
        exitbutton.Image = sair
        buttonhelp.Image = Ajuda
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Usernamelabel.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.SelectedIndex
            Case 0
                languagelabel.Text = "Linguagem:"
                Titlelabel1.Text = "Gestão"
                Titlelabel2.Text = "Clínica Informática"
                Usernamelabel.Text = "Nome de Utilizador:"
                passwordlabel.Text = "Palavra-Passe:"
                UsernameBox.WaterMarkText = "Nome de Utilizador"
                Passwordbox.WaterMarkText = "Palavra-Passe"
                Companylabel.Text = "Empresa:"
            Case 1
                languagelabel.Text = "Language"
                Titlelabel1.Text = "Computer Clinic"
                Titlelabel2.Text = "Management"
                Usernamelabel.Text = "Username:"
                passwordlabel.Text = "Password:"
                UsernameBox.WaterMarkText = "Username"
                Passwordbox.WaterMarkText = "Password"
                Companylabel.Text = "Company:"
            Case 2
                languagelabel.Text = "Langue"
                Titlelabel1.Text = "Computer Clinic"
                Titlelabel2.Text = "Management"
                Usernamelabel.Text = "Nom d'utilisateur:"
                passwordlabel.Text = "Mot de passe:"
                UsernameBox.WaterMarkText = "Nom d'utilisateur"
                Passwordbox.WaterMarkText = "Mot de passe"
                Companylabel.Text = "Entreprise:"
            Case 3
                languagelabel.Text = "Idioma"
                Titlelabel1.Text = "Computer Clinic"
                Titlelabel2.Text = "Management"
                Usernamelabel.Text = "Nombre de usuario:"
                passwordlabel.Text = "Contraseña:"
                UsernameBox.WaterMarkText = "Nombre de usuario"
                Passwordbox.WaterMarkText = "Contraseña"
                Companylabel.Text = "Empresa:"
        End Select
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub

    Private Sub helpbutton_Click(sender As Object, e As EventArgs) Handles buttonhelp.Click

    End Sub

    Private Sub loginbutton_Click(sender As Object, e As EventArgs) Handles loginbutton.Click

        Menuform.Show()
    End Sub
End Class
