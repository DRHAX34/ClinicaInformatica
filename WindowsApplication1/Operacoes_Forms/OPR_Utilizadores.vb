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
        Dim check_morada As Boolean = True
        Dim check_nif As Boolean = True
        Dim check_codpostal As Boolean = True
        Dim check_localidade As Boolean = True
        Dim checklogo As Boolean = True
        If Workspace.Aluno = True Then
            For i = 0 To numalunobox.Text.Count - 1
                If numalunobox.Text.Chars(i) <> " " Then
                    check_num = False
                End If
            Next
        Else
            check_num = False
        End If
        If simcheck.Checked = True Then
            For i = 0 To tecnicobox.Text.Count - 1
                If tecnicobox.Text.Chars(i) <> " " Then
                    check_morada = False
                End If
            Next
        Else
            check_morada = False
        End If
        If admgeralcheck.Checked = False Then
            For i = 0 To empresabox.Text.Count - 1
                If empresabox.Text.Chars(i) <> " " Then
                    check_nif = False
                End If
            Next
        Else
            check_nif = False
        End If
        For i = 0 To nomeutilizadorbox.Text.Count - 1
            If nomeutilizadorbox.Text.Chars(i) <> " " Then
                check_codpostal = False
            End If
        Next
        For i = 0 To passwordbox.Text.Count - 1
            If passwordbox.Text.Chars(i) <> " " Then
                check_localidade = False
            End If
        Next
            If check_nome = False And check_morada = False And check_nif = False And check_localidade = False And check_codpostal = False And checklogo = False Then
                Try
                    If BLL.Admin_only.Empresas.check_exist(nomebox.Text) = 1 Then
                        MsgBox("Esta Empresa já existe!")
                    Else
                        BLL.Admin_only.Empresas.inserir(nomebox.Text, moradabox.Text, nifbox.Text, codpostalbox.Text, localidadebox.Text, logo, True)
                        If MsgBox("Tem que criar um utilizador para esta empresa. Deseja criar agora?", MsgBoxStyle.YesNo) = vbOK Then
                            Workspace.opr_utilizadores.modo = False
                            Workspace.opr_utilizadores.Show()
                            For i = 0 To Workspace.opr_utilizadores.empresabox.Items.Count - 1
                                If Workspace.opr_utilizadores.empresabox.Items.Item(i) = nomebox.Text Then
                                    Workspace.opr_utilizadores.empresabox.SelectedIndex = i
                                End If
                            Next
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

    Private Sub simcheck_CheckedChanged(sender As Object, e As EventArgs) Handles simcheck.CheckedChanged
        simcheck.Checked = True
        naocheck.Checked = False
        tecnicobox.Enabled = True
        addtecnicobox.Enabled = True
    End Sub

    Private Sub admgeralcheck_CheckedChanged(sender As Object, e As EventArgs) Handles admgeralcheck.CheckedChanged
        empresabox.Enabled = admgeralcheck.Checked
    End Sub
End Class