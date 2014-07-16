Public Class OPR_Empresas
    Public empresa_data As New DataTable
    Public modo As Boolean
    Public img_caminho As String
    Public logo As Image
    Public removidos As Boolean
    
    Private Sub OPR_Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        naocheck.Checked = True
        logobox.Enabled = False
        If modo = True Then
            RadButton3.PerformClick()
        Else
            RadButton5.Enabled = True
            RadButton1.Enabled = False
            RadButton3.Text = "Limpar Tudo"
        End If
        If removidos = True Then
            RadButton5.Text = "Remover Permanentemente"
        Else
            RadButton5.Text = "Adicionar"
        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        naocheck.Checked = False
        simcheck.Checked = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles naocheck.Click
        naocheck.Checked = True
        simcheck.Checked = False
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        If removidos = False Then
            Dim check_nome As String = ""
            Dim check_morada As String = ""
            Dim check_nif As Boolean = True
            Dim check_codpostal As Boolean = True
            Dim check_localidade As String = ""
            Dim checklogo As Boolean = False
            Try
                check_nome = nomebox.Text
                check_nome.Trim()
                check_morada = moradabox.Text
                check_morada.Trim()
                If nifbox.Text < 9 Then
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
                If caminhobox.Text <> "" Then
                    checklogo = True
                Else
                    checklogo = False
                End If
            Catch
            End Try
            If simcheck.Checked = True Or naocheck.Checked = True Then
                If Not check_nome = "" And Not check_morada = "" And Not check_nif = False And Not check_localidade = "" And Not check_codpostal = False And Not checklogo = False Then
                    Try
                        If BLL.Admin_only.Empresas.check_exist(nomebox.Text) = 1 Then
                            MsgBox("Esta Empresa já existe!")
                        Else
                            BLL.Admin_only.Empresas.inserir(simcheck.Checked, nomebox.Text, moradabox.Text, nifbox.Text, codpostalbox.Text, localidadebox.Text, logo, True)
                            If MsgBox("Tem que criar um técnico para esta empresa. Deseja criar agora?", MsgBoxStyle.YesNo) = vbYes Then
                                Dim opr_tecnicos As New OPR_Técnicos
                                opr_tecnicos.MdiParent = Workspace
                                opr_tecnicos.modo = False
                                opr_tecnicos.Show()
                                For i = 0 To opr_tecnicos.empresabox.Items.Count - 1
                                    If opr_tecnicos.empresabox.Items.Item(i) = nomebox.Text Then
                                        opr_tecnicos.empresabox.SelectedIndex = i
                                    End If
                                Next
                                Me.Close()
                            Else
                                MsgBox("Não poderá inserir dados nesta empresa ou iniciar sessão até criar pelo menos um técnico", vbOK, "Sem Técnicos!")
                                Me.Close()
                            End If
                        End If
                    Catch ex As Exception
                        MsgBox("Ocorreu um erro: " & ex.Message)
                    End Try
                Else
                    MsgBox("Insira os dados todos!")
                End If
            Else
                MsgBox("Indique se a Empresa tem alunos ou não!")
            End If
        Else
            Try
                BLL.Admin_only.eliminar_empresa(empresa_data.Rows.Item(0).Item("NºEmpresa").ToString())
                MsgBox("Removida com sucesso!")
                Workspace.EmpresasToolStripMenuItem.PerformClick()
            Catch ex As Exception
                MsgBox("Erro ao remover: " & ex.Message)
            End Try
        End If
    End Sub

    

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim check_nome As String = ""
        Dim check_morada As String = ""
        Dim check_nif As Boolean = True
        Dim check_codpostal As Boolean = True
        Dim check_localidade As String = ""
        Dim checklogo As Boolean = False
        Try
            check_nome = nomebox.Text
            check_nome.Trim()
            check_morada = moradabox.Text
            check_morada.Trim()
            If nifbox.Text < 9 Then
                check_nif = False
            Else
                check_nif = True
            End If
            If codpostalbox.Text < 7 Then
                check_codpostal = False
            Else
                check_codpostal = True
            End If
            check_localidade = localidadebox.Text
            check_localidade.Trim()
            If caminhobox.Text <> "" Then
                checklogo = True
            Else
                checklogo = False
            End If
        Catch
        End Try
        If simcheck.Checked = True Or naocheck.Checked = True Then
            If Not (check_nome = "" And check_morada = "" And check_nif = False And check_localidade = "" And check_codpostal = False And checklogo = False) Then
                Try
                    BLL.Admin_only.Empresas.alterar(empresa_data.Rows.Item(0).Item("NºEmpresa").ToString(), nomebox.Text, moradabox.Text, nifbox.Text, codpostalbox.Text, localidadebox.Text, logo, True)
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                MsgBox("Preencha todos os dados!")
            End If
        Else
            MsgBox("Indique se a Empresa tem alunos ou não!")
        End If
    End Sub

    

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        If removidos = True Then
            Workspace.EmpresasToolStripMenuItem.PerformClick()
        Else
            Workspace.EmpresasToolStripMenuItem.PerformClick()
        End If
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs) Handles simcheck.Click
        simcheck.Checked = True
        naocheck.Checked = False
    End Sub
    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles naocheck.Click
        naocheck.Checked = True
        simcheck.Checked = False
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        OpenFileDialog1.Filter = "Imagens | *.png;*.jpg;*.jpeg;*.bmp"
        OpenFileDialog1.ShowDialog()
        img_caminho = OpenFileDialog1.FileName
        caminhobox.Text = img_caminho
        If img_caminho <> "OpenFileDialog1" Then
            Try
                logo = Image.FromFile(img_caminho)
                logobox.Image = logo
            Catch ex As Exception
                MsgBox("Erro ao importar a imagem: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If modo = True Then
            Try
                nomebox.Text = empresa_data.Rows.Item(0).Item("Nome").ToString()
                moradabox.Text = empresa_data.Rows.Item(0).Item("Morada").ToString()
                localidadebox.Text = empresa_data.Rows.Item(0).Item("Localidade").ToString()
                nifbox.Text = empresa_data.Rows.Item(0).Item("NIF").ToString()
                codpostalbox.Text = empresa_data.Rows.Item(0).Item("Cod_Postal").ToString()
                If empresa_data.Rows.Item(0).Item("Alunos") = True Then
                    simcheck.Checked = True
                    naocheck.Checked = False
                Else
                    naocheck.Checked = True
                    simcheck.Checked = False
                End If
                caminhobox.Text = "<Não Alterado>"
                logo = BLL.Admin_only.Empresas.carregar_pic()
                logobox.Image = logo
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message)
            End Try
        Else
            nomebox.Text = ""
            moradabox.Text = ""
            localidadebox.Text = ""
            nifbox.Text = ""
            codpostalbox.Text = ""
            simcheck.Checked = False
            naocheck.Checked = True
        End If
    End Sub

    Private Sub nifbox_onlynums(sender As Object, e As KeyPressEventArgs) Handles nifbox.KeyPress
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub

    
End Class