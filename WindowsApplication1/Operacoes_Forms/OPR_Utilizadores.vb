Public Class OPR_Utilizadores
    Public modo As Boolean
    Public utilizador_data As New DataTable
    Private Sub OPR_Utilizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Workspace.Aluno = False Then
            Label1.Hide()
            numalunobox.Hide()
        Else
            Label1.Show()
            numalunobox.Show()
        End If
        If Workspace.admin = True Then
            admgeralcheck.Hide()
        End If
        If Workspace.admin_geral = True Then
            admgeralcheck.Show()
        End If
        naocheck.PerformClick()
        If modo = True Then
            RadButton3.PerformClick()
        Else
            RadButton5.Enabled = True
            RadButton1.Enabled = False
            RadButton3.Text = "Limpar Tudo"
        End If
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        numalunobox.Text = utilizador_data.Rows.Item(0).Item("NºAluno").ToString()
        tecnicobox.DataSource = BLL.Tecnicos.carregar_tecnico
        empresabox.DataSource = BLL.Login.Carregar_empresas()
        For i = 0 To tecnicobox.Items.Count - 1
            If utilizador_data.Rows.Item(0).Item("NºTécnico").ToString() = tecnicobox.Items(i) Then
                tecnicobox.SelectedIndex = i
            End If
        Next
        Dim nome As String
        nome = BLL.Admin_only.Empresas.check_name(utilizador_data.Rows.Item(0).Item("NºEmpresa").ToString())
        For i = 0 To empresabox.Items.Count - 1
            If nome = tecnicobox.Items(i) Then
                tecnicobox.SelectedIndex = i
            End If
        Next
        nomeutilizadorbox.Text = utilizador_data.Rows.Item(0).Item("Nome_Util").ToString()
        passwordbox.Text = utilizador_data.Rows.Item(0).Item("Password").ToString()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim check_num As Boolean = True
        Dim check_tecnico As Boolean = True
        Dim check_empresa As Boolean = True
        Dim check_nomutil As Boolean = True
        Dim check_pass As Boolean = True
        If Workspace.Aluno = True Then
            Try
                For i = 0 To numalunobox.Text.Count - 1
                    If numalunobox.Text.Chars(i) <> " " Then
                        check_num = False
                    End If
                Next
            Catch ex As Exception
                check_num = True
            End Try
        Else
            check_num = False
        End If
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
            If check_num = False And check_tecnico = False And check_empresa = False And check_nomutil = False And check_pass = False Then
                Try
                    If BLL.Admin_only.Login.check_exist(nomeutilizadorbox.Text) = 1 Then
                        MsgBox("Este Utilizador já existe!")
                    Else
                        BLL.Admin_only.Login.Add_login(admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, passwordbox.Text)
                        MsgBox("Inserido com sucesso!")
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                MsgBox("Insira os dados todos!")
            End If
        ElseIf Workspace.admin = True Then
            If check_num = False And check_tecnico = False And check_empresa = False And check_nomutil = False And check_pass = False Then
                    Try
                        If BLL.Admin_only.Login.check_exist(nomeutilizadorbox.Text) = 1 Then
                        MsgBox("Esta Utilizador já existe!")
                        Else
                            BLL.Admin_only.Login.Add_login(admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, passwordbox.Text)
                            MsgBox("Inserido com sucesso!")
                            Me.Close()
                        End If
                    Catch ex As Exception
                        MsgBox("Ocorreu um erro: " & ex.Message)
                    End Try
            Else
                MsgBox("Insira os dados todos!")
            End If
        End If
        
    End Sub


    Private Sub naocheck_CheckedChanged(sender As Object, e As EventArgs) Handles naocheck.Click
        simcheck.Checked = False
        naocheck.Checked = True
        tecnicobox.Enabled = False
        addtecnicobox.Enabled = False
    End Sub

    Private Sub simcheck_CheckedChanged(sender As Object, e As EventArgs) Handles simcheck.CheckedChanged
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
        Dim check_num As Boolean = True
        Dim check_tecnico As Boolean = True
        Dim check_empresa As Boolean = True
        Dim check_nomutil As Boolean = True
        Dim check_pass As Boolean = True
        If Workspace.Aluno = True Then
            Try
                For i = 0 To numalunobox.Text.Count - 1
                    If numalunobox.Text.Chars(i) <> " " Then
                        check_num = False
                    End If
                Next
            Catch ex As Exception
                check_num = True
            End Try
        Else
            check_num = False
        End If
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
            If check_num = False And check_tecnico = False And check_empresa = False And check_nomutil = False And check_pass = False Then
                Try
                        BLL.Admin_only.Login.Add_login(admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, passwordbox.Text)
                        MsgBox("Inserido com sucesso!")
                        Me.Close()
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                MsgBox("Insira os dados todos!")
            End If
        ElseIf Workspace.admin = True Then
            If check_num = False And check_tecnico = False And check_empresa = False And check_nomutil = False And check_pass = False Then
                Try
                    If BLL.Admin_only.Login.check_exist(nomeutilizadorbox.Text) = 1 Then
                        MsgBox("Esta Utilizador já existe!")
                    Else
                        BLL.Admin_only.Login.Add_login(admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, passwordbox.Text)
                        MsgBox("Inserido com sucesso!")
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                MsgBox("Insira os dados todos!")
            End If
        End If
    End Sub
End Class