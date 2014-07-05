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
            contacto_fbox.Text = "+"
            contactom_box.Text = "+"
            RadButton1.Enabled = False
            RadButton5.Enabled = True
            RadButton3.Text = "Limpar Tudo"
        End If
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
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
            Catch
        End Try
        Try
            If Not checklocalidade = "" And Not checkcodpostal = False And Not check_nome = "" And Not check_contactof = False And Not check_contactom = False And Not checklogo = "" Then
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

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
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

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
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
        cod_postalbox.Select(0, cod_postalbox.Text.Length + 1)
    End Sub

    Private Sub cod_postalbox_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles cod_postalbox.MaskInputRejected

    End Sub
End Class