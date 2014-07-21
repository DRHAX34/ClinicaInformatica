Public Class OPR_Clientes
    Public cliente_data As New DataTable
    Public modo, removidos As Boolean

    Private Sub OPR_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saveimagebutton As New Bitmap((My.Resources._1405624185_floppy), savebutton.Height, savebutton.Height)
        savebutton.Image = saveimagebutton
        Dim componentesimagebutton As New Bitmap((My.Resources.oie_30101754Hz7aSVUe), componentesbutton.Height, componentesbutton.Height)
        componentesbutton.Image = componentesimagebutton
        Dim restartimagebutton As New Bitmap((My.Resources._1405624497_MB__reload), restartbutton.Height, restartbutton.Height)
        Dim exitimagebutton As New Bitmap((My.Resources.Sair), exitbutton.Height, exitbutton.Height)
        exitbutton.Image = exitimagebutton
        Dim limparimagebutton As New Bitmap((My.Resources._32x32), restartbutton.Height, restartbutton.Height)
        If modo = True Then
            restartbutton.Image = restartimagebutton
        Else
            restartbutton.Image = limparimagebutton
        End If
        Me.AcceptButton = savebutton
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
        Else
            cmovelbox.Text = "+351"
            cfixobox.Text = "+351"
            RadioButton2.Checked = True
            numalunobox.Hide()
            turmabox.Hide()
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

    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        If modo = False Then
            Dim check_nome As String = ""
            Dim check_morada As String = ""
            Dim check_codpostal As Boolean = False
            Dim check_localidade As String = ""
            Dim check_contactom As Boolean = False
            Try
                check_nome = nomebox.Text
                check_nome.Trim()
                check_morada = moradabox.Text
                check_morada.Trim()
                If codpostalbox.Text.Count < 7 Then
                    check_codpostal = False
                Else
                    check_codpostal = True
                End If
                check_localidade = localidadebox.Text
                check_localidade.Trim()
                If cmovelbox.Text.Count < 9 Then
                    check_contactom = False
                Else
                    check_contactom = True
                End If
            Catch ex As Exception
                MsgBox("Preencha todos os dados marcados como obrigatórios!")
            End Try
            Try
                If Not check_nome = "" And Not check_morada = "" And Not check_codpostal = False And Not check_localidade = "" And Not check_contactom = False Then
                    codpostalbox.TextMaskFormat = MaskFormat.IncludeLiterals
                    If Workspace.Aluno = False Then
                        BLL.Clientes.inserir(nifbox.Text, localidadebox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                    Else
                        BLL.Clientes.inserir_aluno(numalunobox.Text, turmabox.Text, nifbox.Text, localidadebox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                    End If
                    codpostalbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
                    MsgBox("Inserido com sucesso")
                    If MsgBox("Deseja inserir um componente associado a este cliente?", vbYesNo, "Adicionar Componente") = vbYes Then
                        Dim opr_componente As New OPR_Artigos
                        opr_componente.modo = False
                        opr_componente.n_cliente = BLL.Clientes.carregar_max(True)
                        opr_componente.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_componente.Show()
                        Me.Close()
                    Else
                        Workspace.clientesmenu.PerformClick()
                        Me.Close()
                    End If
                Else
                    MsgBox("Introduza todos os dados!")
                End If
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message)
            End Try
        Else
            Dim check_nome As String = ""
            Dim check_morada As String = ""
            Dim check_nif As Boolean = False
            Dim check_codpostal As Boolean = False
            Dim check_localidade As String = ""
            Dim check_contactom As Boolean = False
            Try
                check_nome = nomebox.Text
                check_nome.Trim()
                check_morada = moradabox.Text
                check_morada.Trim()
                If nifbox.Text.Length < 9 Then
                    check_nif = False
                Else
                    check_nif = True
                End If
                If codpostalbox.Text.Count < 7 Then
                    check_codpostal = False
                Else
                    check_codpostal = True
                End If
                check_localidade = localidadebox.Text
                check_localidade.Trim()
                If cmovelbox.Text.Count < 9 Then
                    check_contactom = False
                Else
                    check_contactom = True
                End If
            Catch ex As Exception
                MsgBox("Preencha todos os dados marcados como obrigatórios!")
            End Try
            If Not (check_nome = "" And check_morada = "" And check_codpostal = False And check_nif = False And check_localidade = "" And check_contactom = False) Then
                Try
                    If Workspace.Aluno = False Then
                        If removidos = True Then
                            BLL.Clientes.alterar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, False, cmovelbox.Text, cfixobox.Text)
                            MsgBox("Editado com sucesso")
                            Workspace.clientesmenu.PerformClick()
                            Me.Close()
                        Else
                            BLL.Clientes.alterar(cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                            MsgBox("Editado com sucesso")
                            Workspace.clientesmenu.PerformClick()
                            Me.Close()
                        End If
                    Else
                        If removidos = True Then
                            BLL.Clientes.alterar_aluno(numalunobox.Text, turmabox.Text, cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, False, cmovelbox.Text, cfixobox.Text)
                            MsgBox("Editado com sucesso")
                            Workspace.clientesmenu.PerformClick()
                            Me.Close()
                        Else
                            BLL.Clientes.alterar_aluno(numalunobox.Text, turmabox.Text, cliente_data.Rows.Item(0).Item("NºCliente").ToString(), localidadebox.Text, nifbox.Text, nomebox.Text, moradabox.Text, codpostalbox.Text, emailbox.Text, True, cmovelbox.Text, cfixobox.Text)
                            MsgBox("Editado com sucesso")
                            Workspace.clientesmenu.PerformClick()
                            Me.Close()
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                MsgBox("Introduza todos os dados marcados como obrigatórios!")
            End If
        End If
    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        If removidos = False Then
            Workspace.clientesmenu.PerformClick()
        Else
            Workspace.clientesmenu.PerformClick()
        End If
        Me.Close()
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles restartbutton.Click
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

    Private Sub cmovelbox_TextChanged(sender As Object, e As EventArgs) Handles cmovelbox.Click
        cmovelbox.Select(0, cmovelbox.Text.Length + 1)
    End Sub

    Private Sub cfixobox_TextChanged(sender As Object, e As EventArgs) Handles cfixobox.Click
        cfixobox.Select(0, cfixobox.Text.Length + 1)
    End Sub

    
End Class