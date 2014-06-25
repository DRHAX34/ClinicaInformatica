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
        Else
            numalunobox.Show()
            turmabox.Show()
            Label7.Show()
            RadioButton1.Show()
            RadioButton2.Show()
        End If
        If modo = True Then
            Try
                adicionarbutton.Enabled = False
                editarbutton.Enabled = True
                restorebutton.Text = "Restaurar Dados Originais"
                Try
                    If cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> 0 Or cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> "" Then
                        RadioButton1.Checked = True
                        RadioButton2.Checked = False
                        numalunobox.Text = cliente_data.Rows.Item(0).Item("NºAluno").ToString()
                        turmabox.Text = cliente_data.Rows.Item(0).Item("Turma").ToString()
                    Else
                        RadioButton1.Checked = False
                        RadioButton2.Checked = True
                    End If
                Catch
                End Try
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
            cmovelbox.Text = "+"
            cfixobox.Text = "+"
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
        If nifbox.Text.Length = 9 Then
            For i = 0 To nifbox.Text.Count - 1
                If nifbox.Text.Chars(i) <> " " Then
                    check_nif = False
                End If
            Next
        Else
            check_nif = True
        End If
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
        If cmovelbox.Text > 9 Then
            For i = 0 To cmovelbox.Text.Count - 1
                If cmovelbox.Text.Chars(i) <> " " Then
                    check_contactom = False
                End If
            Next
        Else
            check_contactom = True
        End If
        If Not BLL.Clientes.procura_dados_nome(nomebox.Text).Rows.Count <> 0 Then
            Try
                If check_nome = False And check_morada = False And check_codpostal = False And check_nif = False And check_localidade = False And check_contactom = False Then
                    BLL.Clientes.inserir(nifbox.Text, localidadebox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                    MsgBox("Inserido com sucesso")
                    If MsgBox("Deseja inserir um componente associado a este cliente?", vbYesNo, "Adicionar Componente") = vbYes Then
                        Dim opr_componente As New OPR_Componentes
                        opr_componente.modo = False
                        opr_componente.numbox.Text = BLL.Clientes.carregar_max()
                        opr_componente.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_componente.Show()
                        Me.Close()
                    Else
                        Workspace.clientesativos.PerformClick()
                        Me.Close()
                    End If
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
                    Workspace.clientesremovidos.PerformClick()
                    Me.Close()
                Else
                    BLL.Clientes.alterar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                    MsgBox("Editado com sucesso")
                    Workspace.clientesativos.PerformClick()
                    Me.Close()
                End If
            Else
                If removidos = True Then
                    BLL.Clientes.alterar_aluno(numalunobox.Text, turmabox.Text, cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, False, cmovelbox.Text, cfixobox.Text)
                    MsgBox("Editado com sucesso")
                    Workspace.clientesremovidos.PerformClick()
                    Me.Close()
                Else
                    BLL.Clientes.alterar_aluno(numalunobox.Text, turmabox.Text, cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                    MsgBox("Editado com sucesso")
                    Workspace.clientesativos.PerformClick()
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
                Workspace.clientesremovidos.PerformClick()
                Me.Close()
            Else
                BLL.Clientes.apagar(cliente_data.Rows.Item(0).Item("NºCliente").ToString())
                MsgBox("Removido com sucesso")
                Workspace.clientesativos.PerformClick()
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles cancelarbutton.Click
        If removidos = False Then
            Workspace.clientesativos.PerformClick()
        Else
            Workspace.clientesremovidos.PerformClick()
        End If
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
    Private Sub numalunobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles numalunobox.KeyPress
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub
    Private Sub contactom_onlynums(sender As Object, e As KeyPressEventArgs) Handles cmovelbox.KeyPress
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub
    Private Sub contactof_onlynums(sender As Object, e As KeyPressEventArgs) Handles cfixobox.KeyPress
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub
    Private Sub nifbox_onlynums(sender As Object, e As KeyPressEventArgs) Handles nifbox.KeyPress
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub

    Private Sub cmovelbox_TextChanged(sender As Object, e As EventArgs) Handles cmovelbox.TextChanged
        If cmovelbox.Text.Count = 0 Then
            cmovelbox.Text = "+"
        End If
    End Sub

    Private Sub cfixobox_TextChanged(sender As Object, e As EventArgs) Handles cfixobox.TextChanged
        If cfixobox.Text.Count = 0 Then
            cfixobox.Text = "+"
        End If
    End Sub
End Class