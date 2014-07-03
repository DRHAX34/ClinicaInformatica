Public Class OPR_Utilizadores
    Public modo As Boolean
    Public utilizador_data As New DataTable
    Public removidos As Boolean
    Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
    Private Sub OPR_Utilizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Workspace.admin = True Then
            admgeralcheck.Hide()
            empresabox.Hide()
            Label5.Hide()
        End If
        If Workspace.varias_empresas = False Then
            admgeralcheck.Hide()
            admincheck.Location = New Point(312, 237)
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
            RadButton2.Enabled = True
        Else
            RadButton5.Enabled = True
            RadButton1.Enabled = False
            RadButton2.Enabled = False
            RadButton3.Text = "Limpar Tudo"
        End If
        If removidos = True Then
            RadButton2.Text = "Restaurar"
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
            Dim password As String = utilizador_data.Rows.Item(0).Item("Password").ToString()
            passwordbox.Text = wrapper.DecryptData(password)
        Else
            tecnicobox.Text = ""
            empresabox.SelectedIndex = 0
            nomeutilizadorbox.Text = ""
            passwordbox.Text = ""
        End If
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim check_tecnico As Boolean = False
        Dim check_empresa As String = ""
        Dim check_nomutil As String = ""
        Dim check_pass As String = ""
        Dim check_pergunta As String = ""
        Dim check_resposta As String = ""
        If admgeralcheck.Checked = False Then
            If simcheck.Checked = True Then
                Try
                    If tecnicobox.Text <> "" Or tecnicobox.Text <> 0 Then
                        check_tecnico = True
                    Else
                        check_tecnico = False
                    End If
                Catch ex As Exception
                    check_tecnico = False
                End Try
            Else
                check_tecnico = True
            End If
        Else
            check_tecnico = True
        End If
        If admgeralcheck.Checked = False Then
            Try
                check_empresa = empresabox.Text
                check_empresa.Trim()
            Catch ex As Exception
                check_empresa = ""
            End Try
        Else
            check_empresa = "n/d"
        End If
        Try
            check_nomutil = nomeutilizadorbox.Text
            check_nomutil.Trim()
        Catch ex As Exception
            check_nomutil = ""
        End Try
        Try
            check_pass = passwordbox.Text
            check_pass.Trim()
        Catch ex As Exception
            check_pass = ""
        End Try
        Try
            check_pergunta = perguntabox.Text
            check_pergunta.Trim()
            check_resposta = respostabox.Text
        Catch ex As Exception

        End Try
        If Not (check_tecnico = False And check_empresa = "" And check_nomutil = "" And check_pass = "" And check_pergunta = "" And check_resposta = "") Then
            Try
                Dim n_empresa As Integer
                If admgeralcheck.Checked = False Then
                    n_empresa = BLL.Login.return_n_empresa(empresabox.SelectedItem.ToString)
                End If
                If BLL.Admin_only.Login.check_exist(nomeutilizadorbox.Text) = 1 Then
                    MsgBox("Este Utilizador já existe!")
                Else
                    Dim password As String = passwordbox.Text
                    Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
                    Dim passencript As String = wrapper.EncryptData(password)
                    If admgeralcheck.Checked = True Then
                        BLL.Admin_only.Login.Add_login_non_student_admin(perguntabox.Text, respostabox.Text, admgeralcheck.Checked, nomeutilizadorbox.Text, passencript)
                        MsgBox("Inserido com sucesso!")
                        Workspace.utilativos.PerformClick()
                        Me.Close()
                    Else
                        n_empresa = BLL.n_empresa
                        BLL.Admin_only.Login.Add_login_non_student_noadmin(perguntabox.Text, respostabox.Text, admincheck.Checked, nomeutilizadorbox.Text, passencript, n_empresa)
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
        tecnicolabel.Enabled = False
        tecnicobox.Enabled = False
        addtecnicobox.Enabled = False
        questionlabel.Enabled = False
        simcheck.Enabled = False
        naocheck.Enabled = False
    End Sub

    Private Sub admincheck_CheckedChanged(sender As Object, e As EventArgs) Handles admincheck.Click
        admgeralcheck.Checked = False
        admincheck.Checked = True
        empresabox.Enabled = admincheck.Checked
        tecnicolabel.Enabled = True
        tecnicobox.Enabled = True
        addtecnicobox.Enabled = True
        questionlabel.Enabled = True
        simcheck.Enabled = True
        naocheck.Enabled = True
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
                        BLL.Admin_only.Login.alterar_login_non_student(perguntabox.Text, respostabox.Text, utilizador_data.Rows.Item(0).Item("Cod_Utilizador").ToString(), admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, wrapper.EncryptData(passwordbox.Text), 0)
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
                            BLL.Admin_only.Login.alterar_login_tecnico(perguntabox.Text, respostabox.Text, utilizador_data.Rows.Item(0).Item("Cod_Utilizador").ToString(), tecnicobox.Text, admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, wrapper.EncryptData(passwordbox.Text))
                            MsgBox("Editado com sucesso!")
                            Me.Close()
                        Else
                            BLL.Admin_only.Login.alterar_login_non_student(perguntabox.Text, respostabox.Text, utilizador_data.Rows.Item(0).Item("Cod_Utilizador").ToString(), admgeralcheck.Checked, admincheck.Checked, nomeutilizadorbox.Text, wrapper.EncryptData(passwordbox.Text), n_empresa)
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

    
    Private Sub addtecnicobox_Click(sender As Object, e As EventArgs) Handles addtecnicobox.Click
        If Workspace.check_select = False Then
            Dim select_comp As New Selectform
            select_comp.MdiParent = Workspace
            Workspace.m_ChildFormNumber += 1
            select_comp.tabela = "Clientes"
            select_comp.Show()
            Timer1.Start()
            Workspace.check_select = True
        Else
            MsgBox("Já tem uma janela de Selecionar aberta!")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        tecnicobox.Text = Workspace.support
        If Workspace.check_select = False Then
            Timer1.Stop()
        End If
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class