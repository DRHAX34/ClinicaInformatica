Imports System.IO
Imports System.Drawing.Imaging
Public Class OPR_Técnicos
    Public tecnico_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Public image_tec As Image
    Public img_caminho As String
    Public lock As Boolean = False
    Private Sub OPR_Técnicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saveimagebutton As New Bitmap((My.Resources._1405624185_floppy), savebutton.Height, savebutton.Height)
        savebutton.Image = saveimagebutton
        Dim reparaçoesefetuadasimagebutton As New Bitmap((My.Resources.oie_2417311E0OBPz25), reparaçoesefetuadasbutton.Height, reparaçoesefetuadasbutton.Height)
        reparaçoesefetuadasbutton.Image = reparaçoesefetuadasimagebutton
        Dim restartimagebutton As New Bitmap((My.Resources.Refresh_black_512), restartbutton.Height - 6, restartbutton.Height - 6)
        restartimagebutton.MakeTransparent(Color.White)
        Dim exitimagebutton As New Bitmap((My.Resources._1406140864_logout), exitbutton.Height, exitbutton.Height)
        exitimagebutton.MakeTransparent(Color.White)
        exitbutton.Image = exitimagebutton
        Dim limparimagebutton As New Bitmap((My.Resources._32x32), restartbutton.Height, restartbutton.Height)
        limparimagebutton.MakeTransparent(Color.White)
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
            restartbutton.Image = restartimagebutton
            Try
                If Workspace.Aluno = True Then
                    numalunobox.Text = tecnico_data.Rows.Item(0).Item("NºAluno").ToString()
                    turmabox.Text = tecnico_data.Rows.Item(0).Item("Turma").ToString()
                End If
                nomebox.Text = tecnico_data.Rows.Item(0).Item("Nome").ToString()
                contacto_fbox.Text = tecnico_data.Rows.Item(0).Item("Contacto_M").ToString()
                contactom_box.Text = tecnico_data.Rows.Item(0).Item("Contacto_F").ToString()
                localidadebox.Text = tecnico_data.Rows.Item(0).Item("Localidade").ToString()
                cod_postalbox.Text = tecnico_data.Rows.Item(0).Item("Cod_Postal").ToString()
                nomeutilizadorbox.Text = tecnico_data.Rows.Item(0).Item("Nome_util").ToString()
                Dim imagestream As Byte() = tecnico_data.Rows.Item(0).Item("Fotografia")
                Dim mStream As MemoryStream = New MemoryStream(imagestream)
                Dim img As Image = Image.FromStream(mStream)
                image_tec = img
                imagembox.Image = image_tec
                caminhobox.Text = "<Não Alterado>"
                lockbutton.PerformClick()
                reparaçoesefetuadasbutton.Enabled = True
            Catch ex As Exception
                MsgBox("Erro ao abrir técnico: " & ex.Message, vbOKOnly, "Erro!")
                Me.Close()
            End Try
            Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
            Dim passdecript As String = wrapper.DecryptData(tecnico_data.Rows.Item(0).Item("Password").ToString)
            passwordbox.Text = passdecript
            verifbox.Text = passdecript
            perguntabox.Text = tecnico_data.Rows.Item(0).Item("Pergunta_S")
            respostabox.Text = tecnico_data.Rows.Item(0).Item("Resposta_S")
        Else
            restartbutton.Image = limparimagebutton
            lockbutton.Hide()
            reparaçoesefetuadasbutton.Hide()
        End If
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles logobutton.Click
        OpenFileDialog1.Filter = "Imagens | *.png;*.jpg;*.jpeg;*.bmp"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        img_caminho = OpenFileDialog1.FileName
        If img_caminho <> "OpenFileDialog1" And img_caminho <> "" Then
            Try
                caminhobox.Text = img_caminho
                image_tec = Image.FromFile(img_caminho)
                imagembox.Image = image_tec
            Catch ex As Exception
                MsgBox("Erro ao importar a imagem: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub turmabox_onlynums(sender As Object, e As KeyPressEventArgs) Handles turmabox.KeyPress
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
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

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        If modo = False Then
            Dim check_nomutil As String = ""
            Dim check_pergunta As String = ""
            Dim check_resposta As String = ""
            Dim check_nome As String = ""
            Dim check_contacto As Boolean = False
            Dim check_localidade As String = ""
            Dim check_alunos As String = ""
            Dim check_turma As String = ""
            Dim check_codpostal As Boolean = False
            Dim check_caminho As String = caminhobox.Text
            Try
                check_nomutil = nomeutilizadorbox.Text
                check_nomutil.Trim()
            Catch ex As Exception
                check_nomutil = ""
            End Try
            If caminhobox.Text = "" Then
                image_tec = My.Resources.nopicture_02
            End If
            Try
                If passwordbox.Text <> "" Then
                    If passwordbox.Text = verifbox.Text Then
                        check_pergunta = perguntabox.Text
                        check_pergunta.Trim()
                        check_resposta = respostabox.Text
                        check_resposta.Trim()
                    End If
                Else
                    check_pergunta = "N/A"
                    check_resposta = "N/A"
                End If
                check_nome = nomebox.Text
                check_nome.Trim()
                check_localidade = localidadebox.Text
                If Workspace.Aluno = True Then
                    check_alunos = numalunobox.Text
                    check_alunos.Trim()
                    check_turma = turmabox.Text
                    check_turma.Trim()
                Else
                    check_alunos = "N/A"
                    check_turma = "N/A"
                End If
                If contactom_box.Text.Length >= 9 Then
                    check_contacto = True
                ElseIf contacto_fbox.Text.Length >= 9 Then
                    check_contacto = True
                End If
                cod_postalbox.TextMaskFormat = MaskFormat.IncludeLiterals
                If cod_postalbox.Text.Length > 7 Then
                    check_codpostal = True
                End If
            Catch ex As Exception

            End Try
            If Not check_nome = "" And Not check_nomutil = "" And Not check_contacto = False And Not check_alunos = "" And Not check_turma = "" And Not check_localidade = "" And Not check_codpostal = False And Not check_pergunta = "" And Not check_resposta = "" Then
                Try
                    If BLL.Tecnicos.check_exist(nomebox.Text) = 1 Then
                        MsgBox("Este técnico já existe!")
                    ElseIf BLL.Login.check_exist(nomeutilizadorbox.Text) = True Then
                        MsgBox("Este utilizador já existe!")
                    Else
                        BLL.Tecnicos.inserir(localidadebox.Text, cod_postalbox.Text, contactom_box.Text, contacto_fbox.Text, nomebox.Text, image_tec)
                        Dim password As String = passwordbox.Text
                        Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
                        Dim passencript As String = wrapper.EncryptData(password)
                        BLL.Admin_only.Login.Add_login_tecnico(perguntabox.Text, respostabox.Text, BLL.Tecnicos.carregar_max, nomeutilizadorbox.Text, passencript)
                        Workspace.tecnicosmenu.PerformClick()
                        Me.Close()
                    End If
                Catch ex As Exception
                    MsgBox("Erro ao inserir: " & ex.Message)
                End Try
            Else
                MsgBox("Verifique todos os dados!", vbOKOnly, "Erro!")
            End If
        Else
            Dim check_nomutil As String = ""
            Dim check_pergunta As String = ""
            Dim check_resposta As String = ""
            Dim check_nome As String = ""
            Dim check_contacto As Boolean = False
            Dim check_localidade As String = ""
            Dim check_alunos As String = ""
            Dim check_turma As String = ""
            Dim check_codpostal As Boolean = False
            Try
                check_nomutil = nomeutilizadorbox.Text
                check_nomutil.Trim()
            Catch ex As Exception
                check_nomutil = ""
            End Try
            Try
                If passwordbox.Text <> "" Then
                    If passwordbox.Text = verifbox.Text Then
                        check_pergunta = perguntabox.Text
                        check_pergunta.Trim()
                        check_resposta = respostabox.Text
                        check_resposta.Trim()
                    End If
                Else
                    check_pergunta = "N/A"
                    check_resposta = "N/A"
                End If
                check_nome = nomebox.Text
                check_nome.Trim()
                check_localidade = localidadebox.Text
                If Workspace.Aluno = True Then
                    check_alunos = numalunobox.Text
                    check_alunos.Trim()
                    check_turma = turmabox.Text
                    check_turma.Trim()
                Else
                    check_alunos = "N/A"
                    check_turma = "N/A"
                End If
                If contactom_box.Text.Length >= 9 Then
                    check_contacto = True
                ElseIf contacto_fbox.Text.Length >= 9 Then
                    check_contacto = True
                End If
                cod_postalbox.TextMaskFormat = MaskFormat.IncludeLiterals
                If cod_postalbox.Text.Length > 7 Then
                    check_codpostal = True
                End If
            Catch ex As Exception
            End Try
            If Not check_nome = "" And Not check_nomutil = "" And Not check_contacto = False And Not check_alunos = "" And Not check_turma = "" And Not check_localidade = "" And Not check_codpostal = False And Not check_pergunta = "" And Not check_resposta = "" Then
                Try
                    BLL.Tecnicos.alterar(localidadebox.Text, cod_postalbox.Text, contactom_box.Text, contacto_fbox.Text, nomebox.Text, image_tec, tecnico_data.Rows(0).Item("NºTécnico").ToString)
                    Dim password As String = passwordbox.Text
                    Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
                    Dim passencript As String = wrapper.EncryptData(password)
                    BLL.Admin_only.Login.alterar_login_tecnico(tecnico_data.Rows(0).Item("Cod_Utilizador").ToString, perguntabox.Text, respostabox.Text, BLL.Tecnicos.carregar_max, nomeutilizadorbox.Text, passencript)
                    MsgBox("Inserido com êxito!", vbOKOnly, "Inserido!")
                    Workspace.tecnicosmenu.PerformClick()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Erro ao inserir: " & ex.Message)
                End Try
            Else
                MsgBox("Verifique todos os dados!", vbOKOnly, "Erro!")
            End If
        End If

    End Sub



    Private Sub RadButton3_Click_1(sender As Object, e As EventArgs) Handles restartbutton.Click
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
        End If
    End Sub

    Private Sub RadButton4_Click_1(sender As Object, e As EventArgs) Handles exitbutton.Click
        Workspace.tecnicosmenu.PerformClick()
        Me.Close()
    End Sub

    Private Sub lockbutton_Click(sender As Object, e As EventArgs) Handles lockbutton.Click
        Dim imageunlockbutton As New Bitmap(My.Resources._1406134201_MB__UNLOCK, lockbutton.Height, lockbutton.Width)
        Dim imagelockbutton As New Bitmap(My.Resources._1406134201_MB__LOCK, lockbutton.Height, lockbutton.Width)
        If lock = False Then
            lock = True
            lockbutton.Image = imageunlockbutton
            nomebox.Enabled = False
            numalunobox.Enabled = False
            turmabox.Enabled = False
            contacto_fbox.Enabled = False
            contactom_box.Enabled = False
            localidadebox.Enabled = False
            cod_postalbox.Enabled = False
            logobutton.Enabled = False
            nomeutilizadorbox.Enabled = False
            passwordbox.Enabled = False
            verifbox.Enabled = False
            perguntabox.Enabled = False
            respostabox.Enabled = False
            savebutton.Enabled = False
            caminhobox.Enabled = False
        Else
            lock = False
            lockbutton.Image = imagelockbutton
            nomebox.Enabled = True
            numalunobox.Enabled = True
            turmabox.Enabled = True
            contacto_fbox.Enabled = True
            contactom_box.Enabled = True
            localidadebox.Enabled = True
            cod_postalbox.Enabled = True
            logobutton.Enabled = True
            nomeutilizadorbox.Enabled = True
            passwordbox.Enabled = True
            verifbox.Enabled = True
            perguntabox.Enabled = True
            respostabox.Enabled = True
            savebutton.Enabled = True
            caminhobox.Enabled = False
        End If
    End Sub

    Private Sub reparaçoesefetuadasbutton_Click(sender As Object, e As EventArgs) Handles reparaçoesefetuadasbutton.Click
        Try
            
        Catch ex As Exception
            MsgBox("Erro ao carregar: " & ex.Message, vbOKOnly, "Erro!")
        End Try
    End Sub
End Class