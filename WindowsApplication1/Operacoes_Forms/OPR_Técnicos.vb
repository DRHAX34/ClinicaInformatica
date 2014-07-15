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
            nomeutilizadorbox.Text = tecnico_data.Rows.Item(0).Item("Nome_util").ToString()
            Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
            Dim passdecript As String = wrapper.DecryptData(tecnico_data.Rows.Item(0).Item("Password").ToString)
            passwordbox.Text = passdecript
            verifbox.Text = passdecript
            perguntabox.Text = tecnico_data.Rows.Item(0).Item("Pergunta_S")
            respostabox.Text = tecnico_data.Rows.Item(0).Item("Resposta_S")
            For i = 0 To empresabox.Items.Count - 1
                If empresabox.Items(i).ToString = BLL.Admin_only.Empresas.carregar_dados_numempresa(tecnico_data.Rows.Item(0).Item("NºEmpresa").ToString()).Rows.Item(0).Item("Nome").ToString Then
                    empresabox.SelectedIndex = i
                End If
            Next
        Else
            contacto_fbox.Text = "+351"
            contactom_box.Text = "+351"
            RadButton1.Enabled = False
            RadButton5.Enabled = True
            RadButton3.Text = "Limpar Tudo"
        End If
    End Sub


    Private Sub RadButton3_Click(sender As Object, e As EventArgs)
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

    Private Sub RadButton1_Click(sender As Object, e As EventArgs)
        Dim check_nome As String = nomebox.Text
        Dim check_contactom As Boolean = False
        Dim check_contactof As Boolean = False
        Dim check_naluno As String = numalunobox.Text
        Dim check_turma As String = turmabox.Text
        Dim checklogo As String = caminhobox.Text
        Dim checklocalidade As String = localidadebox.Text
        Dim checkcodpostal As Boolean = False
        Try
            check_nome.Trim()
            If contacto_fbox.Text.Length < 9 Then
                check_contactof = False
            Else
                check_contactof = True
            End If
            If contactom_box.Text.Length < 9 Then
                check_contactom = False
            Else
                check_contactof = True
            End If
            If Workspace.Aluno = True Then
                check_naluno.Trim()
                check_turma.Trim()
            Else
                check_naluno = "N/A"
                check_turma = "N/A"
            End If
            checklogo.Trim()
            If cod_postalbox.Text.Length < 7 Then
                checkcodpostal = False
            Else
                checkcodpostal = True
            End If
            checklocalidade.Trim()
            If Not (checklocalidade = "" And checkcodpostal = False And check_nome = "" And check_contactof = False And check_contactom = False And checklogo = "") Then
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

    Private Sub RadButton2_Click(sender As Object, e As EventArgs)
        Try
            BLL.Tecnicos.apagar(tecnico_data.Rows.Item(0).Item("NºTécnico").ToString())
            MsgBox("Removido com sucesso!")
            Me.Close()
        Catch ex As Exception
            MsgBox("Não foi possível remover: " & ex.Message)
        End Try
    End Sub

    Private Sub turmabox_onlynums(sender As Object, e As KeyPressEventArgs) Handles turmabox.KeyPress
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub contactom_box_onlynumbers(sender As Object, e As KeyPressEventArgs) Handles contactom_box.KeyPress
        Try
            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub

    Public Sub OnlyDigitsOnKeyPress_contactof(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles contacto_fbox.KeyPress
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
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

    Private Sub cod_postalbox_click(sender As Object, e As EventArgs) Handles cod_postalbox.Click
        cod_postalbox.Select(0, cod_postalbox.Text.Length)
    End Sub

    Private Sub RadButton5_Click_1(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim check_empresa As String = ""
        Dim check_nomutil As String = ""
        Dim check_pass As String = ""
        Dim check_pergunta As String = ""
        Dim check_resposta As String = ""
        Dim check_nome As String = ""
        Dim check_cmovel As Boolean = False
        Dim check_cfixo As Boolean = False
        Dim check_localidade As String = ""
        Dim check_alunos As String = ""
        Dim check_turma As String = ""
        Dim check_codpostal As Boolean = False
        Dim check_image As String = ""
        Try
            check_nomutil = nomeutilizadorbox.Text
            check_nomutil.Trim()
        Catch ex As Exception
            check_nomutil = ""
        End Try
        If passwordbox.Text = verifbox.Text Then
            Try
                check_pass = passwordbox.Text
                check_pass.Trim()
            Catch ex As Exception
                check_pass = ""
            End Try
        Else
            check_pass = ""
        End If
        Try
            check_pergunta = perguntabox.Text
            check_pergunta.Trim()
            check_resposta = respostabox.Text
            check_resposta.Trim()
        
        check_nome = nomebox.Text
        check_nome.Trim()
        check_localidade = localidadebox.Text
        check_alunos = numalunobox.Text
        check_alunos.Trim()
        check_turma = turmabox.Text
        check_turma.Trim()
        If contactom_box.Text.Length >= 9 Then
            check_cmovel = True
        End If
        If contacto_fbox.Text.Length >= 9 Then
            check_cfixo = True
        End If
        cod_postalbox.TextMaskFormat = MaskFormat.IncludeLiterals
        If cod_postalbox.Text.Length = 8 Then
            check_codpostal = True
        End If
        check_image = caminhobox.Text
        check_image.Trim()
        check_empresa = empresabox.Text
            check_empresa = ""
        Catch ex As Exception

        End Try
        Dim n_empresa As Integer
        If Not check_nome = "" And Not check_nomutil = "" And Not check_cfixo = False And Not check_cmovel = False And Not check_alunos = "" And Not check_turma = "" And Not check_empresa = "" And Not check_image = "" And Not check_localidade = "" And Not check_codpostal = False And Not check_pass = "" And Not check_pergunta = "" And Not check_resposta = "" Then
            Try
                BLL.Tecnicos.inserir(localidadebox.Text, cod_postalbox.Text, contactom_box.Text, contacto_fbox.Text, nomebox.Text, image_tec)
                n_empresa = BLL.Login.return_n_empresa(empresabox.SelectedItem.ToString)
                Dim password As String = passwordbox.Text
                Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
                Dim passencript As String = wrapper.EncryptData(password)
                BLL.Admin_only.Login.Add_login_tecnico(perguntabox.Text, respostabox.Text, BLL.Tecnicos.carregar_max, nomeutilizadorbox.Text, passencript)
                MsgBox("Inserido com êxito!")
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao inserir: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub RadButton1_Click_1(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim check_empresa As String = ""
        Dim check_nomutil As String = ""
        Dim check_pass As String = ""
        Dim check_pergunta As String = ""
        Dim check_resposta As String = ""
        Dim check_nome As String = ""
        Dim check_cmovel As Boolean = False
        Dim check_cfixo As Boolean = False
        Dim check_localidade As String = ""
        Dim check_alunos As String = ""
        Dim check_turma As String = ""
        Dim check_codpostal As Boolean = False
        Dim check_image As String = ""
        Try
            check_nomutil = nomeutilizadorbox.Text
            check_nomutil.Trim()
        Catch ex As Exception
            check_nomutil = ""
        End Try
        If passwordbox.Text = verifbox.Text Then
            Try
                check_pass = passwordbox.Text
                check_pass.Trim()
            Catch ex As Exception
                check_pass = ""
            End Try
        Else
            check_pass = ""
        End If
        Try
            check_pergunta = perguntabox.Text
            check_pergunta.Trim()
            check_resposta = respostabox.Text
            check_resposta.Trim()

            check_nome = nomebox.Text
            check_nome.Trim()
            check_localidade = localidadebox.Text
            check_alunos = numalunobox.Text
            check_alunos.Trim()
            check_turma = turmabox.Text
            check_turma.Trim()
            If contactom_box.Text.Length >= 9 Then
                check_cmovel = True
            End If
            If contacto_fbox.Text.Length >= 9 Then
                check_cfixo = True
            End If
            cod_postalbox.TextMaskFormat = MaskFormat.IncludeLiterals
            If cod_postalbox.Text.Length = 8 Then
                check_codpostal = True
            End If
            check_image = caminhobox.Text
            check_image.Trim()
            check_empresa = empresabox.Text
            check_empresa = ""
        Catch ex As Exception

        End Try
        Dim n_empresa As Integer
        If Not check_nome = "" And Not check_nomutil = "" And Not check_cfixo = False And Not check_cmovel = False And Not check_alunos = "" And Not check_turma = "" And Not check_empresa = "" And Not check_image = "" And Not check_localidade = "" And Not check_codpostal = False And Not check_pass = "" And Not check_pergunta = "" And Not check_resposta = "" Then
            Try
                BLL.n_empresa = BLL.Login.return_n_empresa(empresabox.SelectedItem.ToString)
                BLL.Tecnicos.alterar(localidadebox.Text, cod_postalbox.Text, contactom_box.Text, contacto_fbox.Text, nomebox.Text, image_tec, tecnico_data.Rows(0).Item("NºTécnico").ToString)
                n_empresa = BLL.Login.return_n_empresa(empresabox.SelectedItem.ToString)
                Dim password As String = passwordbox.Text
                Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
                Dim passencript As String = wrapper.EncryptData(password)
                BLL.Admin_only.Login.alterar_login_tecnico(tecnico_data.Rows(0).Item("Cod_Utilizador").ToString, perguntabox.Text, respostabox.Text, BLL.Tecnicos.carregar_max, nomeutilizadorbox.Text, passencript)
                MsgBox("Inserido com êxito!")
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao inserir: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub RadButton3_Click_1(sender As Object, e As EventArgs) Handles RadButton3.Click
        If modo = True Then
            numalunobox.Text = tecnico_data.Rows.Item(0).Item("NºAluno").ToString()
            turmabox.Text = tecnico_data.Rows.Item(0).Item("Turma").ToString()
            nomebox.Text = tecnico_data.Rows.Item(0).Item("Nome").ToString()
            contacto_fbox.Text = tecnico_data.Rows.Item(0).Item("Contacto_M").ToString()
            contactom_box.Text = tecnico_data.Rows.Item(0).Item("Contacto_F").ToString()
            localidadebox.Text = tecnico_data.Rows.Item(0).Item("Localidade").ToString()
            cod_postalbox.Text = tecnico_data.Rows.Item(0).Item("Cod_Postal").ToString()
            nomeutilizadorbox.Text = tecnico_data.Rows.Item(0).Item("Nome_util").ToString()
            Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
            Dim passdecript As String = wrapper.DecryptData(tecnico_data.Rows.Item(0).Item("Password").ToString)
            passwordbox.Text = passdecript
            verifbox.Text = passdecript
            perguntabox.Text = tecnico_data.Rows.Item(0).Item("Pergunta_S")
            respostabox.Text = tecnico_data.Rows.Item(0).Item("Resposta_S")
            For i = 0 To empresabox.Items.Count - 1
                If empresabox.Items(i).ToString = BLL.Admin_only.Empresas.carregar_dados_numempresa(tecnico_data.Rows.Item(0).Item("NºEmpresa").ToString()).Rows.Item(0).Item("Nome").ToString Then
                    empresabox.SelectedIndex = i
                End If
            Next
        Else
            numalunobox.Text = ""
            turmabox.Text = ""
            nomebox.Text = ""
            contacto_fbox.Text = ""
            contactom_box.Text = ""
            localidadebox.Text = ""
            cod_postalbox.Text = ""
            nomeutilizadorbox.Text = ""
            passwordbox.Text = ""
            verifbox.Text = ""
            perguntabox.Text = ""
            respostabox.Text = ""
            empresabox.SelectedIndex = 0
        End If
    End Sub

    Private Sub RadButton4_Click_1(sender As Object, e As EventArgs) Handles RadButton4.Click
        Me.Close()
    End Sub

    
End Class