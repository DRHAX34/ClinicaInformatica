Public Class OPR_Técnicos
    Public tecnico_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Public image_tec As Image
    Public img_caminho As String
    Private Sub OPR_Técnicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Workspace.Aluno = True Then
            numalunobox.Show()
            numalunolabel.Show()
            turmabox.Show()
            turmalabel.Show()
        Else
            numalunobox.Hide()
            numalunolabel.Hide()
            turmabox.Hide()
            turmalabel.Hide()
        End If
        If modo = True Then
            RadButton1.Enabled = True
            RadButton5.Enabled = False
            RadButton3.Text = "Restaurar Dados Originais"
            numalunobox.Text = tecnico_data.Rows.Item(0).Item("NºAluno").ToString()
            turmabox.Text = tecnico_data.Rows.Item(0).Item("Turma").ToString()
            nomebox.Text = tecnico_data.Rows.Item(0).Item("Nome").ToString()
            contacto_fbox.Text = tecnico_data.Rows.Item(0).Item("Contacto_M").ToString()
            contactom_box.Text = tecnico_data.Rows.Item(0).Item("Contacto_F").ToString()
            localidadebox.Text = tecnico_data.Rows.Item(0).Item("Localidade").ToString()
            cod_postalbox.Text = tecnico_data.Rows.Item(0).Item("Cod_Postal").ToString()
        Else
            RadButton1.Enabled = False
            RadButton5.Enabled = True
            RadButton3.Text = "Limpar Tudo"
        End If
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim check_nome As Boolean = True
        Dim check_contactom As Boolean = True
        Dim check_contactof As Boolean = True
        Dim check_naluno As Boolean = True
        Dim check_turma As Boolean = True
        Dim checklogo As Boolean = True
        Dim checklocalidade As Boolean = True
        Dim checkcodpostal As Boolean = True
        Try
            For i = 0 To nomebox.Text.Count - 1
                If nomebox.Text.Chars(i) <> " " Then
                    check_nome = False
                End If
            Next
            For i = 0 To contacto_fbox.Text.Count - 1
                If contacto_fbox.Text.Chars(i) <> " " Then
                    check_contactof = False
                End If
            Next
            For i = 0 To contactom_box.Text.Count - 1
                If contactom_box.Text.Chars(i) <> " " Then
                    check_contactom = False
                End If
            Next
            If Workspace.Aluno = True Then
                For i = 0 To numalunobox.Text.Count - 1
                    If numalunobox.Text.Chars(i) <> " " Then
                        check_naluno = False
                    End If
                Next
                For i = 0 To turmabox.Text.Count - 1
                    If turmabox.Text.Chars(i) <> " " Then
                        check_turma = False
                    End If
                Next
            Else
                check_naluno = False
                check_turma = False
            End If
            For i = 0 To caminhobox.Text.Count - 1
                If caminhobox.Text.Chars(i) <> " " Then
                    checklogo = False
                End If
            Next
            For i = 0 To localidadebox.Text.Count - 1
                If localidadebox.Text.Chars(i) <> " " Then
                    checklocalidade = False
                End If
            Next
            For i = 0 To cod_postalbox.Text.Count - 1
                If cod_postalbox.Text.Chars(i) <> " " Then
                    checkcodpostal = False
                End If
            Next
            If checklocalidade = False And checkcodpostal = False And check_nome = False And check_contactof = False And check_contactom = False And check_naluno = False And check_turma = False And checklogo = False Then
                Try
                    If BLL.Tecnicos.check_exist(nomebox.Text) = 1 Then
                        MsgBox("Esta Empresa já existe!")
                    Else
                        If Workspace.Aluno = False Then
                            BLL.Tecnicos.inserir(localidadebox.Text, cod_postalbox.Text, contactom_box.Text, contacto_fbox.Text, nomebox.Text, image_tec)
                        Else
                            BLL.Tecnicos.Alunos.inserir(localidadebox.Text, cod_postalbox.Text, contactom_box.Text, contacto_fbox.Text, nomebox.Text, image_tec, numalunobox.Text, turmabox.Text)
                        End If
                        If MsgBox("Tem que criar um utilizador para este técnico. Deseja criar agora?", MsgBoxStyle.YesNo) = vbYes Then
                            Dim opr_utilizadores As New OPR_Utilizadores
                            opr_utilizadores.MdiParent = Workspace
                            opr_utilizadores.modo = False
                            opr_utilizadores.Show()
                            opr_utilizadores.tecnicobox.Text = BLL.Tecnicos.carregar_max()
                            opr_utilizadores.empresabox.Text = BLL.Admin_only.Empresas.procura_dados_numempresa(BLL.n_empresa).Rows.Item(0).Item("NºEmpresa").ToString
                        End If
                    End If
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                MsgBox("Insira os dados todos!")
            End If
        Catch ex As Exception
            MsgBox("Os dados não foram todos introduzidos!")
        End Try
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If modo = True Then
            numalunobox.Text = tecnico_data.Rows.Item(0).Item("NºCliente").ToString()
            turmabox.Text = tecnico_data.Rows.Item(0).Item("Turma").ToString()
            nomebox.Text = tecnico_data.Rows.Item(0).Item("Nome").ToString()
        Else
            numalunobox.Text = ""
            turmabox.Text = ""
            nomebox.Text = ""
        End If
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        OpenFileDialog1.Filter = "Imagens | *.png;*.jpg;*.jpeg;*.bmp"
        OpenFileDialog1.ShowDialog()
        img_caminho = OpenFileDialog1.FileName
        caminhobox.Text = img_caminho
        If img_caminho <> "OpenFileDialog1" Then
            Try
                image_tec = Image.FromFile(img_caminho)
                imagembox.Image = image_tec
            Catch ex As Exception
                MsgBox("Erro ao importar a imagem: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim check_nome As Boolean = True
        Dim check_contactom As Boolean = True
        Dim check_contactof As Boolean = True
        Dim check_naluno As Boolean = True
        Dim check_turma As Boolean = True
        Dim checklogo As Boolean = True
        Dim checklocalidade As Boolean = True
        Dim checkcodpostal As Boolean = True
        Try
            For i = 0 To nomebox.Text.Count - 1
                If nomebox.Text.Chars(i) <> " " Then
                    check_nome = False
                End If
            Next
            For i = 0 To contacto_fbox.Text.Count - 1
                If contacto_fbox.Text.Chars(i) <> " " Then
                    check_contactof = False
                End If
            Next
            For i = 0 To contactom_box.Text.Count - 1
                If contactom_box.Text.Chars(i) <> " " Then
                    check_contactom = False
                End If
            Next
            For i = 0 To numalunobox.Text.Count - 1
                If numalunobox.Text.Chars(i) <> " " Then
                    check_naluno = False
                End If
            Next
            For i = 0 To turmabox.Text.Count - 1
                If turmabox.Text.Chars(i) <> " " Then
                    check_turma = False
                End If
            Next
            For i = 0 To caminhobox.Text.Count - 1
                If caminhobox.Text.Chars(i) <> " " Then
                    checklogo = False
                End If
            Next
            For i = 0 To localidadebox.Text.Count - 1
                If localidadebox.Text.Chars(i) <> " " Then
                    checklocalidade = False
                End If
            Next
            For i = 0 To cod_postalbox.Text.Count - 1
                If cod_postalbox.Text.Chars(i) <> " " Then
                    checkcodpostal = False
                End If
            Next
            If checklocalidade = False And checkcodpostal = False And check_nome = False And check_contactof = False And check_contactom = False And check_naluno = False And check_turma = False And checklogo = False Then
                Try
                    If BLL.Tecnicos.check_exist(nomebox.Text) = 1 Then
                        MsgBox("Esta Empresa já existe!")
                    Else
                        BLL.Tecnicos.alterar(localidadebox.Text, cod_postalbox.Text, contactom_box.Text, contacto_fbox.Text, nomebox.Text, image_tec, tecnico_data.Rows.Item(0).Item("NºTécnico").ToString())
                    End If
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                End Try
            Else
                MsgBox("Insira os dados todos!")
            End If
        Catch ex As Exception
            MsgBox("Os dados não foram todos introduzidos!")
        End Try
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Try
            BLL.Tecnicos.apagar(tecnico_data.Rows.Item(0).Item("NºTécnico").ToString())
            MsgBox("Removido com sucesso!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Não foi possível remover: " & ex.Message)
        End Try
    End Sub

    Private Sub turmabox_TextChanged(sender As Object, e As EventArgs) Handles turmabox.TextChanged

    End Sub
End Class