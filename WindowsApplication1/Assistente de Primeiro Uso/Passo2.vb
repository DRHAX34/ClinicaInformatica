Option Explicit On

Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security

Public Class Passo2
    Public logo As Image
    Dim img_caminho As String
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

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Colorization.OsSupportsAero Then SetBackColor(Colorization.GetDwmColorization)
        Label1.Show()
        Timer1.Start()
        Localidadelabel.Show()
        MaximizeBox = False
        MinimizeBox = False
        caminhobox.Enabled = False
        simcheck.Checked = False
        naocheck.Checked = True
        Me.AcceptButton = seguintebutton
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
        Label1.ForeColor = colorization.Inversecolor
        Localidadelabel.ForeColor = colorization.Inversecolor
        moradalabel.ForeColor = colorization.Inversecolor
        nomelabel.ForeColor = colorization.Inversecolor
        cod_postallabel.ForeColor = colorization.Inversecolor
        logolabel.ForeColor = colorization.Inversecolor
        niflabel.ForeColor = colorization.Inversecolor
        alunoslabel.ForeColor = colorization.Inversecolor
        simcheck.ForeColor = colorization.Inversecolor
        naocheck.ForeColor = colorization.Inversecolor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Colorization.OsSupportsAero Then SetBackColor(Colorization.GetDwmColorization)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles seguintebutton.Click
        Dim check_nome As String = ""
        Dim check_morada As String = ""
        Dim check_nif As Boolean = False
        Dim check_codpostal As Boolean = False
        Dim check_localidade As String = ""
        Dim check_logo As String = ""
        Try
            Try
                check_nome = nomebox.Text
                check_morada = moradabox.Text
                If nifbox.Text.Length = 9 Then
                    check_nif = True
                Else
                    check_nif = False
                End If
                If cod_postalbox.Text.Length = 7 Then
                    check_codpostal = True
                Else
                    check_codpostal = False
                End If
                check_localidade = localidadebox.Text
                check_logo = caminhobox.Text
                check_nome.Trim()
                check_morada.Trim()
                check_localidade.Trim()
                check_logo.Trim()
            Catch
            End Try
            If Not (check_nome = "" And check_morada = "" And check_codpostal = False And check_nif = False And check_localidade = "" And check_logo = "") Then
                BLL.Admin_only.Empresas.inserir(simcheck.Checked, nomebox.Text, moradabox.Text, nifbox.Text, cod_postalbox.Text, localidadebox.Text, logo, True)
                If Workspace.varias_empresas = True Then
                    Workspace.config3.Show()
                Else
                    Workspace.config3_5.Show()
                End If
                Me.Close()
            Else
                MsgBox("Preencha todos os dados!")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro na Aplicação: " & ex.Message)
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles imagebutton.Click
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

    Private Sub cancelarbutton_Click(sender As Object, e As EventArgs) Handles cancelarbutton.Click
        Workspace.Close()
    End Sub

    Private Sub limparbutton_Click(sender As Object, e As EventArgs) Handles limparbutton.Click
        nomebox.Text = ""
        moradabox.Text = ""
        caminhobox.Text = ""
        logobox.Image = Nothing
        nifbox.Text = ""
        cod_postalbox.Text = ""
        localidadebox.Text = ""
        naocheck.PerformClick()
    End Sub

    Private Sub simcheck_CheckedChanged(sender As Object, e As EventArgs) Handles simcheck.Click
        naocheck.Checked = False
        simcheck.Checked = True

    End Sub
    Private Sub naocheck_CheckedChanged(sender As Object, e As EventArgs) Handles naocheck.Click
        naocheck.Checked = True
        simcheck.Checked = False

    End Sub

    Private Sub nifbox_onlynums(sender As Object, e As KeyPressEventArgs) Handles nifbox.KeyPress
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