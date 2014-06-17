Public Class OPR_Clientes
    Public cliente_data As New DataTable
    Public modo, removidos As Boolean

    Private Sub OPR_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numalunobox.Hide()
        RadioButton2.Checked = True
        If Workspace.Aluno = False Then
            numalunobox.Hide()
            Label7.Hide()
            RadioButton1.Hide()
            RadioButton2.Hide()
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
                    RadButton5.Enabled = False
                    RadButton1.Enabled = True
                    RadButton3.Text = "Restaurar Dados Originais"
                    nomebox.Text = cliente_data.Rows.Item(0).Item("Nome").ToString()
                Obrigatório.Text = cliente_data.Rows.Item(0).Item("Morada").ToString()
                emailbox.Text = cliente_data.Rows.Item(0).Item("Email").ToString()
                nifbox.Text = cliente_data.Rows.Item(0).Item("NIF").ToString()
                codpostalbox.Text = cliente_data.Rows.Item(0).Item("Cod_Postal").ToString()
                cmovelbox.Text = cliente_data.Rows.Item(0).Item("Contacto_M").ToString()
                cfixobox.Text = cliente_data.Rows.Item(0).Item("Contacto_F").ToString()
                localidadebox.Text = cliente_data.Rows.Item(0).Item("Localidade").ToString()
            Catch ex As Exception
                MsgBox("Erro ao carregar os dados: " & ex.Message)
            End Try
            RadButton5.Enabled = False
        Else
            RadButton5.Enabled = True
            RadButton1.Enabled = False
            RadButton3.Text = "Limpar Tudo"
        End If
        If removidos = True Then
            RadButton2.Text = "Restaurar"
        Else
            RadButton2.Text = "Remover"
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

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
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
        For i = 0 To Obrigatório.Text.Count - 1
            If nomebox.Text.Chars(i) <> " " Then
                check_morada = False
            End If
        Next
        For i = 0 To nifbox.Text.Count - 1
            If nomebox.Text.Chars(i) <> " " Then
                check_nif = False
            End If
        Next
        For i = 0 To codpostalbox.Text.Count - 1
            If nomebox.Text.Chars(i) <> " " Then
                check_codpostal = False
            End If
        Next
        For i = 0 To localidadebox.Text.Count - 1
            If nomebox.Text.Chars(i) <> " " Then
                check_localidade = False
            End If
        Next
        Try
            If check_nome = False And check_morada = False And check_codpostal = False And check_nif = False And check_localidade = False And check_contactom = False Then
                BLL.Clientes.inserir(nifbox.Text, localidadebox.Text, nomebox.Text, Obrigatório.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                MsgBox("Inserido com sucesso")
                Workspace.AtivosToolStripMenuItem.PerformClick()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            If removidos = True Then
                BLL.Clientes.alterar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, Obrigatório.Text, codpostalbox.Text, emailbox.Text, False, cmovelbox.Text, cfixobox.Text)
                MsgBox("Editado com sucesso")
                Workspace.RemovidosToolStripMenuItem.PerformClick()
                Me.Close()
            Else
                BLL.Clientes.alterar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, Obrigatório.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                MsgBox("Editado com sucesso")
                Workspace.AtivosToolStripMenuItem.PerformClick()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Try
            If removidos = True Then
                BLL.Clientes.reativar_cliente(cliente_data.Rows.Item(0).Item("NºCliente").ToString())
                MsgBox("Restaurado com sucesso")
                Workspace.RemovidosToolStripMenuItem.PerformClick()
                Me.Close()
            Else
                BLL.Clientes.apagar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), nifbox.Text)
                MsgBox("Removido com sucesso")
                Workspace.AtivosToolStripMenuItem.PerformClick()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Me.Close()
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
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
                Obrigatório.Text = cliente_data.Rows.Item(0).Item("Morada").ToString()
                emailbox.Text = cliente_data.Rows.Item(0).Item("Email").ToString()
                nifbox.Text = cliente_data.Rows.Item(0).Item("NIF").ToString()
                codpostalbox.Text = cliente_data.Rows.Item(0).Item("Cod_Postal").ToString()
                cmovelbox.Text = cliente_data.Rows.Item(0).Item("Contacto_M").ToString()
                cfixobox.Text = cliente_data.Rows.Item(0).Item("Contacto_F").ToString()
                localidadebox.Text = cliente_data.Rows.Item(0).Item("Localidade").ToString()
            Else
                nomebox.Text = ""
                Obrigatório.Text = ""
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