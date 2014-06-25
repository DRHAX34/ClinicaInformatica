Public Class OPR_Empresas
    Public empresa_data As New DataTable
    Public modo As Boolean
    Public img_caminho As String
    Public logo As Image
    Public removidos As Boolean
    Private Sub nifbox_onlynums(sender As Object, e As KeyPressEventArgs) Handles nifbox.KeyPress
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub
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

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles simcheck.Click
        naocheck.Checked = False
        simcheck.Checked = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles naocheck.Click
        naocheck.Checked = True
        simcheck.Checked = False
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        If removidos = False Then
            Dim check_nome As Boolean = True
            Dim check_morada As Boolean = True
            Dim check_nif As Boolean = True
            Dim check_codpostal As Boolean = True
            Dim check_localidade As Boolean = True
            Dim checklogo As Boolean = True
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
            For i = 0 To caminhobox.Text.Count - 1
                If caminhobox.Text.Chars(i) <> " " Then
                    checklogo = False
                End If
            Next
            If simcheck.Checked = True Or naocheck.Checked = True Then
                If check_nome = False And check_morada = False And check_nif = False And check_localidade = False And check_codpostal = False And checklogo = False Then
                    Try
                        If BLL.Admin_only.Empresas.check_exist(nomebox.Text) = 1 Then
                            MsgBox("Esta Empresa já existe!")
                        Else
                            BLL.Admin_only.Empresas.inserir(simcheck.Checked, nomebox.Text, moradabox.Text, nifbox.Text, codpostalbox.Text, localidadebox.Text, logo, True)
                            If MsgBox("Tem que criar um utilizador para esta empresa. Deseja criar agora?", MsgBoxStyle.YesNo) = vbYes Then
                                Dim opr_utilizadores As New OPR_Utilizadores
                                opr_utilizadores.MdiParent = Workspace
                                opr_utilizadores.modo = False
                                opr_utilizadores.Show()
                                For i = 0 To opr_utilizadores.empresabox.Items.Count - 1
                                    If opr_utilizadores.empresabox.Items.Item(i) = nomebox.Text Then
                                        opr_utilizadores.empresabox.SelectedIndex = i
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
            Else
                MsgBox("Indique se a Empresa tem alunos ou não!")
            End If
        Else
            Try
                BLL.Admin_only.eliminar_empresa(empresa_data.Rows.Item(0).Item("NºEmpresa").ToString())
                MsgBox("Removida com sucesso!")
                Workspace.empresasremovidas.PerformClick()
            Catch ex As Exception
                MsgBox("Erro ao remover: " & ex.Message)
            End Try
        End If
    End Sub

    

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim check_nome, check_morada, check_nif, check_codpostal, check_localidade, checklogo As Boolean
        For i = 0 To nomebox.Text.Count - 1
            If nomebox.Text.Chars(i) <> " " Then
                check_nome = False
            End If
        Next
        For i = 0 To moradabox.Text.Count - 1
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
        For i = 0 To caminhobox.Text.Count - 1
            If caminhobox.Text.Chars(i) <> " " Then
                checklogo = False
            End If
        Next
        If simcheck.Checked = True And naocheck.Checked = True Then
            If check_nome = False And check_morada = False And check_nif = False And check_localidade = False And check_codpostal = False And checklogo = False Then
                Try
                    BLL.Admin_only.Empresas.alterar(empresa_data.Rows.Item(0).Item("NºCliente").ToString(), nomebox.Text, moradabox.Text, nifbox.Text, codpostalbox.Text, localidadebox.Text, logo, True)
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

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Try
            Dim result As Integer
            result = MsgBox("Deseja eliminar permanentemente a empresa?", vbYesNoCancel, "Eliminar")
            If result = vbYes Then
                BLL.Admin_only.eliminar_empresa(empresa_data.Rows.Item(0).Item("NºEmpresa").ToString())
                MsgBox("Eliminada com sucesso!")
                Workspace.empresasativas.PerformClick()
                Me.Close()
            ElseIf result = vbNo Then
                If MsgBox("Deseja marcar a empresa como inativa?", vbYesNoCancel) = vbYes Then
                    BLL.Admin_only.Empresas.apagar(empresa_data.Rows.Item(0).Item("NºEmpresa").ToString, empresa_data.Rows.Item(0).Item("NIF"))
                    MsgBox("Eliminada com sucesso!")
                    Workspace.empresasativas.PerformClick()
                    Me.Close()
                Else
                    MsgBox("A empresa não foi removida.", MsgBoxStyle.Exclamation, "Erro, nenhuma opção selecionada")
                End If
            Else
                MsgBox("A empresa não foi removida.", MsgBoxStyle.Exclamation, "Cancelado")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        If removidos = True Then
            Workspace.empresasremovidas.PerformClick()
        Else
            Workspace.empresasativas.PerformClick()
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
            simcheck.Checked = False
        End If
    End Sub

    Private Sub nifbox_TextChanged(sender As Object, e As EventArgs) Handles nifbox.TextChanged
        If Not IsNumeric(nifbox.Text) Then
            nifbox.Text = ""
        End If
    End Sub
End Class