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
        End If
            If modo = True Then
                Try
                    RadButton5.Enabled = False
                    RadButton1.Enabled = True
                    RadButton3.Text = "Restaurar Dados Originais"
                    nomebox.Text = cliente_data.Rows.Item(0).Item("Nome").ToString()
                    moradabox.Text = cliente_data.Rows.Item(0).Item("Morada").ToString()
                    emailbox.Text = cliente_data.Rows.Item(0).Item("Email").ToString()
                    nifbox.Text = cliente_data.Rows.Item(0).Item("NIF").ToString()
                    codpostalbox.Text = cliente_data.Rows.Item(0).Item("Cod_Postal").ToString()
                    cmovelbox.Text = cliente_data.Rows.Item(0).Item("Contacto_M").ToString()
                    cfixobox.Text = cliente_data.Rows.Item(0).Item("Contacto_F").ToString()
                    If cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> 0 Or cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> "" Then
                        RadioButton1.Checked = True
                        RadioButton2.Checked = False
                        numalunobox.Text = cliente_data.Rows.Item(0).Item("NºAluno").ToString()
                    Else
                        RadioButton1.Checked = False
                        RadioButton2.Checked = True
                End If
                Catch ex As Exception
                    MsgBox("Erro")
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
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.Click
        RadioButton2.Checked = True
        RadioButton1.Checked = False
        numalunobox.Enabled = False
        numalunobox.Hide()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Try
            BLL.Clientes.inserir(nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
            MsgBox("Inserido com sucesso")
            Workspace.clientesmenu.PerformClick()
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles codpostalbox.MaskInputRejected

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Try
            If removidos = True Then
                BLL.Clientes.alterar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, False, cmovelbox.Text, cfixobox.Text)
                MsgBox("Editado com sucesso")
                Workspace.RemovidosToolStripMenuItem.PerformClick()
                Me.Close()
            Else
                BLL.Clientes.alterar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
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

    End Sub
End Class