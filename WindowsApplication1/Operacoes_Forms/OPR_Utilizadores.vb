Public Class OPR_Utilizadores
    Public modo As Boolean
    Public utilizador_data As New DataTable
    Public removidos As Boolean
    Private Sub OPR_Utilizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Workspace.admin = True Then
            admgeralcheck.Hide()
        End If
        empresabox.DataSource = BLL.Login.Carregar_empresas()
        If Workspace.admin_geral = True Then
            admgeralcheck.Show()
        End If
        naocheck.PerformClick()
        If modo = True Then
            RadButton3.PerformClick()
            RadButton5.Enabled = False
            RadButton1.Enabled = True
        Else
            RadButton5.Enabled = True
            RadButton1.Enabled = False
            RadButton3.Text = "Limpar Tudo"
        End If
        tecnicobox.Enabled = False
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If modo = True Then
            empresabox.DataSource = BLL.Login.Carregar_empresas()
            tecnicobox.Text = utilizador_data.Rows.Item(0).Item("NºTécnico").ToString()
            Dim nome As String
            nome = BLL.Admin_only.Empresas.check_name(utilizador_data.Rows.Item(0).Item("NºEmpresa").ToString())
            For i = 0 To empresabox.Items.Count - 1
                If nome = empresabox.Items(i) Then
                    empresabox.SelectedIndex = i
                End If
            Next
            nomeutilizadorbox.Text = utilizador_data.Rows.Item(0).Item("Nome_Util").ToString()
            passwordbox.Text = utilizador_data.Rows.Item(0).Item("Password").ToString()
        Else
            tecnicobox.Text = ""
            empresabox.SelectedIndex = 0
            nomeutilizadorbox.Text = ""
            passwordbox.Text = ""
        End If
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim check_tecnico As Boolean = True
        Dim check_empresa As Boolean = True
        Dim check_nomutil As Boolean = True
        Dim check_pass As Boolean = True
        If simcheck.Checked = True Then
            Try
                For i = 0 To tecnicobox.Text.Count - 1
                    If tecnicobox.Text.Chars(i) <> " " Then
                        check_tecnico = False
                    End If
                Next
            Catch ex As Exception
                check_tecnico = True
            End Try
        Else
            check_tecnico = False
        End If
        If admgeralcheck.Checked = False Then
            Try
                For i = 0 To empresabox.Text.Count - 1
                    If empresabox.Text.Chars(i) <> " " Then
                        check_empresa = False
                    End If
                Next
            Catch ex As Exception
                check_empresa = True
            End Try
        Else
            check_empresa = False
        End If
        Try
            If nomeutilizadorbox.Text <> "" Or nomeutilizadorbox.Text.Chars(0) = " " Then
                check_nomutil = False
            End If

        Catch ex As Exception
            check_nomutil = True
        End Try
        Try
            For i = 0 To passwordbox.Text.Count - 1
                If passwordbox.Text.Chars(i) <> " " Then
                    check_pass = False
                End If
            Next
            
        Catch ex As Exception
            check_pass = True
        End Try

        If check_tecnico = False And check_empresa = False And check_nomutil = False And check_pass = False Then
            Try
                Dim n_empresa As Integer
                n_empresa = BLL.Login.return_n_empresa(empresabox.SelectedItem.ToString)
                If BLL.Admin_only.Login.check_exist(nomeutilizadorbox.Text) = 1 Then
                    MsgBox("Este Utilizador já existe!")
                Else
                    Dim password As String = passwordbox.Text
                    Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
                    Dim passencript As String = wrapper.EncryptData(password)
                    If admgeralcheck.Checked = True Then
                        BLL.Admin_only.Login.Add_login_non_student_admin(admgeralcheck.Checked, nomeutilizadorbox.Text, password)
                        MsgBox("Inserido com sucesso!")
                        Workspace.utilativos.PerformClick()
                        Me.Close()
                    Else
                        BLL.Admin_only.Login.Add_login_non_student_noadmin(admincheck.Checked, nomeutilizadorbox.Text, password, n_empresa)
                        MsgBox("Inserido com sucesso!")
                        Workspace.utilativos.PerformClick()
                        Me.Close()
                    End If
                End If
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message)
            End Try
        Else
            MsgBox("Insira os dados todos!")
        End If

    End Sub


    Private Sub naocheck_CheckedChanged(sender As Object, e As EventArgs) Handles naocheck.Click
        simcheck.Checked = False
        naocheck.Checked = True
        tecnicobox.Enabled = False
        addtecnicobox.Enabled = False
    End Sub

    Private Sub simcheck_CheckedChanged(sender As Object, e As EventArgs) Handles simcheck.Click
        simcheck.Checked = True
        naocheck.Checked = False
        tecnicobox.Enabled = True
        addtecnicobox.Enabled = True
    End Sub

    Private Sub admgeralcheck_CheckedChanged(sender As Object, e As EventArgs) Handles admgeralcheck.Click
        admgeralcheck.Checked = True
        admincheck.Checked = False
        empresabox.Enabled = admincheck.Checked
    End Sub

    Private Sub admincheck_CheckedChanged(sender As Object, e As EventArgs) Handles admincheck.Click
        admgeralcheck.Checked = False
        admincheck.Checked = True
        empresabox.Enabled = admincheck.Checked
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim check_tecnico As Boolean = True
        Dim check_empresa As Boolean = True
        Dim check_nomutil As Boolean = True
        Dim check_pass As Boolean = True
        If simcheck.Checked = True Then
            Try
                For i = 0 To tecnicobox.Text.Count - 1
                    If tecnicobox.Text.Chars(i) <> " " Then
                        check_tecnico = False
                    End If
                Next
            Catch ex As Exception
                check_tecnico = True
            End Try
        Else
            check_tecnico = False
        End If
        If admgeralcheck.Checked = False Then
            Try
                For i = 0 To empresabox.Text.Count - 1
                    If empresabox.Text.Chars(i) <> " " Then
                        check_empresa = False
                    End If
                Next
            Catch ex As Exception
                check_empresa = True
            End Try
        Else
            check_empresa = False
        End If
        Try
            For i = 0 To nomeutilizadorbox.Text.Count - 1
                If nomeutilizadorbox.Text.Chars(i) <> " " Then
                    check_nomutil = False
                End If
            Next
        Catch ex As Exception
            check_nomutil = True
        End Try
        Try
            For i = 0 To passwordbox.Text.Count - 1
                If passwordbox.Text.Chars(i) <> " " Then
                    check_pass = False
                End If
            Next
        Catch ex As Exception
            check_pass = True
        End Try
        If Workspace.admin_geral = True Then
            If check_tecnico = False And check_empresa = False And check_nomutil = False And check_pass = False Then
                Try
                    If BLL.Admin_only.Login.check_exist(nomeutilizadorbox.Text) = 1 Then
                        MsgBox("Este Utilizador já existe!")
                    Else
                        BLL.Admin_only.Login.alterar_login_non_student(utilizador_data.Rows.Item(0).Item("Cod_Utilizadr").ToString(), admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, passwordbox.Text)
                        MsgBox("Editado com sucesso!")
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                MsgBox("Insira os dados todos!")
            End If
        ElseIf Workspace.admin = True Then
            If check_tecnico = False And check_empresa = False And check_nomutil = False And check_pass = False Then
                Try
                    Dim n_empresa As Integer
                    n_empresa = BLL.Login.return_n_empresa(empresabox.SelectedItem.ToString)
                    If BLL.Admin_only.Login.check_exist(nomeutilizadorbox.Text) = 1 Then
                        MsgBox("Este Utilizador já existe!")
                    Else
                        If simcheck.Checked = True Then
                            BLL.Admin_only.Login.Add_login_tecnico(n_empresa, tecnicobox.Text, admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, passwordbox.Text)
                            MsgBox("Editado com sucesso!")
                            Me.Close()
                        Else
                            BLL.Admin_only.Login.Add_login_non_student_noadmin(admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, passwordbox.Text)
                            MsgBox("Editado com sucesso!")
                            Me.Close()
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                MsgBox("Insira os dados todos!")
            End If
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Try
            BLL.Admin_only.Login.remove_login(utilizador_data.Rows.Item(0).Item("Cod_Utilizador").ToString())
            MsgBox("Removido com sucesso!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Erro ao remover: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Me.Close()
    End Sub

    
End Class