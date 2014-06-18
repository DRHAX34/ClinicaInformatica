Public Class OPR_Clientes
    Public cliente_data As New DataTable
    Public modo, removidos As Boolean

    Private Sub OPR_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numalunobox.Hide()
        RadioButton2.Checked = True
        If Workspace.Aluno = False Then
            numalunobox.Hide()
            turmabox.Hide()
            Label7.Hide()
            RadioButton1.Hide()
            RadioButton2.Hide()
            Me.Size = New Size(Me.Width, Me.Height - 50)
            adicionarbutton.Location = New Point(adicionarbutton.Location.X, (adicionarbutton.Location.Y - 60))
            editarbutton.Location = New Point(editarbutton.Location.X, (editarbutton.Location.Y - 60))
            removerbutton.Location = New Point(removerbutton.Location.X, (removerbutton.Location.Y - 60))
            restorebutton.Location = New Point(restorebutton.Location.X, (restorebutton.Location.Y - 60))
            cancelarbutton.Location = New Point(cancelarbutton.Location.X, (cancelarbutton.Location.Y - 60))
        Else
            If cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> 0 Or cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> "" Then
                RadioButton1.Checked = True
                RadioButton2.Checked = False
                numalunobox.Text = cliente_data.Rows.Item(0).Item("NºAluno").ToString()
                turmabox.Text = cliente_data.Rows.Item(0).Item("Turma").ToString()
            Else
                RadioButton1.Checked = False
                RadioButton2.Checked = True
            End If
        End If
            If modo = True Then
                Try
                adicionarbutton.Enabled = False
                editarbutton.Enabled = True
                restorebutton.Text = "Restaurar Dados Originais"
                nomebox.Text = cliente_data.Rows.Item(0).Item("Nome").ToString()
                moradabox.Text = cliente_data.Rows.Item(0).Item("Morada").ToString()
                emailbox.Text = cliente_data.Rows.Item(0).Item("Email").ToString()
                nifbox.Text = cliente_data.Rows.Item(0).Item("NIF").ToString()
                codpostalbox.Text = cliente_data.Rows.Item(0).Item("Cod_Postal").ToString()
                cmovelbox.Text = cliente_data.Rows.Item(0).Item("Contacto_M").ToString()
                cfixobox.Text = cliente_data.Rows.Item(0).Item("Contacto_F").ToString()
                localidadebox.Text = cliente_data.Rows.Item(0).Item("Localidade").ToString()
            Catch ex As Exception
                MsgBox("Erro ao carregar os dados: " & ex.Message)
            End Try
            adicionarbutton.Enabled = False
            removerbutton.Enabled = True
        Else
            adicionarbutton.Enabled = True
            editarbutton.Enabled = False
            removerbutton.Enabled = False
            restorebutton.Text = "Limpar Tudo"
        End If
        If removidos = True Then
            removerbutton.Text = "Restaurar"
        Else
            removerbutton.Text = "Remover"
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click
        RadioButton2.Checked = False
        RadioButton1.Checked = True
        numalunobox.Enabled = True
        numalunobox.Show()
        turmabox.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.Click
        RadioButton2.Checked = True
        RadioButton1.Checked = False
        numalunobox.Enabled = False
        numalunobox.Hide()
        turmabox.Hide()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles adicionarbutton.Click
        Dim check_nome As Boolean = True
        Dim check_morada As Boolean = True
        Dim check_nif As Boolean = True
        Dim check_codpostal As Boolean = True
        Dim check_localidade As Boolean = True
        Dim check_contactom As Boolean = True
        For i = 0 To nomebox.Text.Count - 1
            If nomebox.Text.Chars(i) <> " " Then
                check_nome = False
            End If
        Next
        For i = 0 To moradabox.Text.Count - 1
            If moradabox.Text.Chars(i) <> " " Then
                check_morada = False
            End If
        Next
        For i = 0 To nifbox.Text.Count - 1
            If nifbox.Text.Chars(i) <> " " Then
                check_nif = False
            End If
        Next
        For i = 0 To codpostalbox.Text.Count - 1
            If codpostalbox.Text.Chars(i) <> " " Then
                check_codpostal = False
            End If
        Next
        For i = 0 To localidadebox.Text.Count - 1
            If localidadebox.Text.Chars(i) <> " " Then
                check_localidade = False
            End If
        Next
        For i = 0 To cmovelbox.Text.Count - 1
            If cmovelbox.Text.Chars(i) <> " " Then
                check_contactom = False
            End If
        Next
        If Not BLL.Clientes.procura_dados_nome(nomebox.Text).Rows.Count <> 0 Then
            Try
                If check_nome = False And check_morada = False And check_codpostal = False And check_nif = False And check_localidade = False And check_contactom = False Then
                    BLL.Clientes.inserir(nifbox.Text, localidadebox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                    MsgBox("Inserido com sucesso")
                    Workspace.AtivosToolStripMenuItem.PerformClick()
                    Me.Close()
                Else
                    MsgBox("Introduza todos os dados!")
                End If
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message)
            End Try
        Else
            MsgBox("Este nome já existe na base-de-dados! Por favor insira outro nome ou o nome completo!")
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles editarbutton.Click
        Try
            If Workspace.Aluno = False Then
                If removidos = True Then
                    BLL.Clientes.alterar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, False, cmovelbox.Text, cfixobox.Text)
                    MsgBox("Editado com sucesso")
                    Workspace.RemovidosToolStripMenuItem.PerformClick()
                    Me.Close()
                Else
                    BLL.Clientes.alterar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                    MsgBox("Editado com sucesso")
                    Workspace.AtivosToolStripMenuItem.PerformClick()
                    Me.Close()
                End If
            Else
                If removidos = True Then
                    BLL.Clientes.alterar_aluno(numalunobox.Text, turmabox.Text, cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, False, cmovelbox.Text, cfixobox.Text)
                    MsgBox("Editado com sucesso")
                    Workspace.RemovidosToolStripMenuItem.PerformClick()
                    Me.Close()
                Else
                    BLL.Clientes.alterar_aluno(numalunobox.Text, turmabox.Text, cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                    MsgBox("Editado com sucesso")
                    Workspace.AtivosToolStripMenuItem.PerformClick()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles removerbutton.Click
        Try
            If removidos = True Then
                BLL.Clientes.reativar_cliente(cliente_data.Rows.Item(0).Item("NºCliente").ToString())
                MsgBox("Restaurado com sucesso")
                Workspace.RemovidosToolStripMenuItem.PerformClick()
                Me.Close()
            Else
                BLL.Clientes.apagar(cliente_data.Rows.Item(0).Item("NºCliente").ToString())
                MsgBox("Removido com sucesso")
                Workspace.AtivosToolStripMenuItem.PerformClick()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles cancelarbutton.Click
        Me.Close()
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles restorebutton.Click
        Try
            If modo = True Then
                If Not Workspace.Aluno = False Then
                    If cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> 0 Or cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> "" Then
                        RadioButton1.Checked = True
                        RadioButton2.Checked = False
                        numalunobox.Text = cliente_data.Rows.Item(0).Item("NºAluno").ToString()
                    Else
                        RadioButton1.Checked = False
                        RadioButton2.Checked = True
                    End If
                    If cliente_data.Rows.Item(0).Item("Turma").ToString() <> 0 Or cliente_data.Rows.Item(0).Item("Turma").ToString() <> "" Then
                        RadioButton1.Checked = True
                        RadioButton2.Checked = False
                        turmabox.Text = cliente_data.Rows.Item(0).Item("Turma").ToString()
                    Else
                        RadioButton1.Checked = False
                        RadioButton2.Checked = True
                    End If
                End If
                nomebox.Text = cliente_data.Rows.Item(0).Item("Nome").ToString()
                moradabox.Text = cliente_data.Rows.Item(0).Item("Morada").ToString()
                emailbox.Text = cliente_data.Rows.Item(0).Item("Email").ToString()
                nifbox.Text = cliente_data.Rows.Item(0).Item("NIF").ToString()
                codpostalbox.Text = cliente_data.Rows.Item(0).Item("Cod_Postal").ToString()
                cmovelbox.Text = cliente_data.Rows.Item(0).Item("Contacto_M").ToString()
                cfixobox.Text = cliente_data.Rows.Item(0).Item("Contacto_F").ToString()
                localidadebox.Text = cliente_data.Rows.Item(0).Item("Localidade").ToString()
            Else
                nomebox.Text = ""
                moradabox.Text = ""
                emailbox.Text = ""
                nifbox.Text = ""
                codpostalbox.Text = ""
                cmovelbox.Text = ""
                cfixobox.Text = ""
                localidadebox.Text = ""
                RadioButton1.Checked = False
                RadioButton2.Checked = True
            End If
        Catch ex As Exception
            MsgBox("Erro ao restaurar os dados: " & ex.Message)
        End Try
    End Sub


End Class