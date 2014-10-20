
Option Explicit On

Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security

Public Class Passo3emeio
    
    Public Event ColourizationChanged As EventHandler(Of ColorizationChangedEventArgs)

    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_DWMCOLORIZATIONCOLORCHANGED As Integer = 800
        If m.Msg = WM_DWMCOLORIZATIONCOLORCHANGED Then
            Dim l As Boolean = (m.LParam.ToInt32 = 0)
            Dim w As Integer = m.WParam.ToInt32
            Dim c As New Colorization(w, l)
            Dim args As New ColorizationChangedEventArgs(c)
            RaiseEvent ColourizationChanged(Me, args)
        End If
        Try
            MyBase.WndProc(m)
        Catch ex As Exception
        End Try
    End Sub
    Public img_caminho As String
    Public image_tec As Image
    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Colorization.OsSupportsAero Then SetBackColor(Colorization.GetDwmColorization)
        Label1.Show()
        Timer1.Start()
        MaximizeBox = False
        MinimizeBox = False
        Me.AcceptButton = Button1
        If BLL.Login.verificar_aluno(BLL.Admin_only.Empresas.carregar_max) = True Then
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
    End Sub

    Private Sub Form1_ColourizationChanged(ByVal sender As Object, ByVal e As ColorizationChangedEventArgs) Handles Me.ColourizationChanged
        SetBackColor(e.Colorization)
    End Sub

    Private Sub SetBackColor(ByVal colorization As Colorization)
        If colorization.Color.ToArgb <> Color.FromArgb(0, 0, 0, 0).ToArgb Then
            Me.BackColor = colorization.SolidColor ' alpha is set to 255.
        Else
            Me.BackColor = Color.White
        End If
        numalunolabel.ForeColor = colorization.Inversecolor
        Label12.ForeColor = colorization.Inversecolor
        turmalabel.ForeColor = colorization.Inversecolor
        Localidadelabel.ForeColor = colorization.Inversecolor
        Label6.ForeColor = colorization.Inversecolor
        Label4.ForeColor = colorization.Inversecolor
        Label5.ForeColor = colorization.Inversecolor
        cod_postallabel.ForeColor = colorization.Inversecolor
        GroupBox1.ForeColor = colorization.Inversecolor
        GroupBox1.BackColor = colorization.SolidColor
        Label1.ForeColor = colorization.Inversecolor
        Label2.ForeColor = colorization.Inversecolor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Colorization.OsSupportsAero Then SetBackColor(Colorization.GetDwmColorization)
    End Sub

    Private Sub numalunobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles numalunobox.KeyPress
        Try
            If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                e.Handled = True
            End If
        Catch
        End Try
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim check_empresa As String = ""
        Dim check_nomutil As String = ""
        Dim check_pergunta As String = ""
        Dim check_resposta As String = ""
        Dim check_nome As String = ""
        Dim check_contacto As Boolean = False
        Dim check_localidade As String = ""
        Dim check_alunos As String = ""
        Dim check_turma As String = ""
        Dim check_codpostal As Boolean = False
        If caminhobox.Text = "" Then
            image_tec = My.Resources.nopicture_02
        End If
        Try
            check_nomutil = nomeutilizadorbox.Text
            check_nomutil.Trim()
        Catch ex As Exception
            check_nomutil = ""
        End Try
        Try
            check_pergunta = perguntabox.Text
            check_pergunta.Trim()
            check_resposta = respostabox.Text
            check_resposta.Trim()

            check_nome = nomebox.Text
            check_nome.Trim()
            check_localidade = localidadebox.Text
            If BLL.Login.verificar_aluno(BLL.Admin_only.Empresas.carregar_max) = True Then
                check_alunos = numalunobox.Text
                check_alunos.Trim()
                check_turma = turmabox.Text
                check_turma.Trim()
            Else
                check_alunos = 0
                check_turma = "N/A"
            End If
            If contactom_box.Text.Length = 9 Then
                check_contacto = True
            ElseIf contacto_fbox.Text.Length = 9 Then
                check_contacto = True
            End If
            cod_postalbox.TextMaskFormat = MaskFormat.IncludeLiterals
            If cod_postalbox.Text.Length = 8 Then
                check_codpostal = True
            End If
        Catch ex As Exception

        End Try
        Dim n_empresa As Integer
        If Not check_nome = "" And Not check_nomutil = "" And Not check_contacto = False And Not check_alunos = "" And Not check_turma = "" And Not check_localidade = "" And Not check_codpostal = False And Not check_pergunta = "" And Not check_resposta = "" Then
            Try
                If BLL.Login.check_exist(nomeutilizadorbox.Text) = True Then
                    MsgBox("O Técnico não pode ter o mesmo nome que o Administrador!", vbOKOnly, "Erro!")
                Else
                    BLL.n_empresa = BLL.Admin_only.Empresas.carregar_max()
                    n_empresa = BLL.Admin_only.Empresas.carregar_max()
                    BLL.Tecnicos.inserir(localidadebox.Text, cod_postalbox.Text, contactom_box.Text, contacto_fbox.Text, nomebox.Text, image_tec)
                    Dim password As String = passwordbox.Text
                    Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
                    Dim passencript As String = wrapper.EncryptData(password)
                    BLL.Admin_only.Login.Add_login_tecnico(perguntabox.Text, respostabox.Text, BLL.Tecnicos.carregar_max, nomeutilizadorbox.Text, passencript)
                    Workspace.config4.Show()
                    Me.Close()
                End If
            Catch ex As Exception
                MsgBox("Erro ao inserir: " & ex.Message)
            End Try
        Else
            MsgBox("Insira todos os dados!", vbOKOnly, "Erro!")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles limparbutton.Click
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
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles logobutton.Click
        OpenFileDialog1.Filter = "Imagens | *.png;*.jpg;*.jpeg;*.bmp"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        img_caminho = OpenFileDialog1.FileName
        If img_caminho <> "OpenFileDialog1" And img_caminho <> "" Then
            Try
                image_tec = Image.FromFile(img_caminho)
                imagembox.Image = image_tec
                caminhobox.Text = img_caminho
            Catch ex As Exception
                MsgBox("Erro ao importar a imagem: " & ex.Message)
            End Try
        End If
    End Sub
End Class