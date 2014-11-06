Public Class OPR_Empresas
    Public empresa_data As New DataTable
    Public modo As Boolean
    Public img_caminho As String
    Public logo As Image
    Public removidos As Boolean
    
    Private Sub OPR_Empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saveimagebutton As New Bitmap((My.Resources._1405624185_floppy), savebutton.Height - 1, savebutton.Height - 1)
        savebutton.Image = saveimagebutton
        Dim restartimagebutton As New Bitmap((My.Resources.Refresh_black_512), restartbutton.Height - 6, restartbutton.Height - 6)
        restartimagebutton.MakeTransparent(Color.White)
        Dim exitimagebutton As New Bitmap((My.Resources._1406140864_logout), exitbutton.Height - 1, exitbutton.Height - 1)
        exitimagebutton.MakeTransparent(Color.White)
        exitbutton.Image = exitimagebutton
        naocheck.Checked = True
        logobox.Enabled = False
        modo = True
        If modo = True Then
            restartbutton.Image = restartimagebutton
        End If
        Try
            nomebox.Text = empresa_data.Rows(0).Item("Nome").ToString()
            moradabox.Text = empresa_data.Rows(0).Item("Morada").ToString()
            nifbox.Text = empresa_data.Rows(0).Item("NIF").ToString()
            cod_postalbox.Text = empresa_data.Rows(0).Item("Cod_Postal").ToString()
            localidadebox.Text = empresa_data.Rows(0).Item("Localidade").ToString()
            caminhobox.Text = "<Não Alterado>"
            logobox.Image = BLL.Admin_only.Empresas.return_pic()
            logo = BLL.Admin_only.Empresas.return_pic()
            If empresa_data.Rows(0).Item("Alunos").ToString() = True Then
                simcheck.Checked = True
                naocheck.Checked = False
            Else
                simcheck.Checked = False
                naocheck.Checked = True
            End If
            emailbox.Text = empresa_data.Rows(0).Item("Email").ToString()
            sitebox.Text = empresa_data.Rows(0).Item("Site").ToString()
            contactofixbox.Text = empresa_data.Rows(0).Item("Contacto_F").ToString()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        naocheck.Checked = False
        simcheck.Checked = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        naocheck.Checked = True
        simcheck.Checked = False
    End Sub
    

    

    Private Sub RadButton4_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs)
        simcheck.Checked = True
        naocheck.Checked = False
    End Sub
    Private Sub RadioButton2_CheckedChanged_1(sender As Object, e As EventArgs) Handles naocheck.Click
        naocheck.Checked = True
        simcheck.Checked = False
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles logobutton.Click
        OpenFileDialog1.Filter = "Imagens | *.png;*.jpg;*.jpeg;*.bmp"
        OpenFileDialog1.FileName = ""
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

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles restartbutton.Click
            Try
                nomebox.Text = empresa_data.Rows(0).Item("Nome").ToString()
                moradabox.Text = empresa_data.Rows(0).Item("Morada").ToString()
                nifbox.Text = empresa_data.Rows(0).Item("NIF").ToString()
                cod_postalbox.Text = empresa_data.Rows(0).Item("Cod_Postal").ToString()
                localidadebox.Text = empresa_data.Rows(0).Item("Localidade").ToString()
                caminhobox.Text = "<Não Alterado>"
            logobox.Image = BLL.Admin_only.Empresas.return_pic()
            logo = BLL.Admin_only.Empresas.return_pic()
            If empresa_data.Rows(0).Item("Alunos").ToString() = True Then
                simcheck.Checked = True
                naocheck.Checked = False
            Else
                simcheck.Checked = False
                naocheck.Checked = True
            End If
                emailbox.Text = empresa_data.Rows(0).Item("Email").ToString()
                sitebox.Text = empresa_data.Rows(0).Item("Site").ToString()
                contactofixbox.Text = empresa_data.Rows(0).Item("Contacto_F").ToString()
            Catch ex As Exception
                MsgBox("Erro: " & ex.Message)
            End Try
    End Sub

    Private Sub nifbox_onlynums(sender As Object, e As KeyPressEventArgs)
        Try

            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub

    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click
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
            cod_postalbox.TextMaskFormat = MaskFormat.IncludePromptAndLiterals
            If cod_postalbox.Text < 8 Then
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
                    BLL.Admin_only.Empresas.alterar(empresa_data.Rows.Item(0).Item("NºEmpresa").ToString(), nomebox.Text, moradabox.Text, nifbox.Text, cod_postalbox.Text, localidadebox.Text, logo, emailbox.Text, sitebox.Text, contactofixbox.Text, True)
                Catch ex As Exception
                    MsgBox("Ocorreu um erro: " & ex.Message)
                    cod_postalbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
                End Try
            Else
                MsgBox("Preencha todos os dados!")
            End If
        Else
            MsgBox("Indique se a Empresa tem alunos ou não!")
        End If
    End Sub
    Private Sub codpostalbox_TextChanged(sender As Object, e As EventArgs) Handles cod_postalbox.Click
        cod_postalbox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals
        If cod_postalbox.Text.Length = 0 Then
            cod_postalbox.Select(0, 0)
        End If
        cod_postalbox.TextMaskFormat = MaskFormat.IncludeLiterals
    End Sub
    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub
End Class