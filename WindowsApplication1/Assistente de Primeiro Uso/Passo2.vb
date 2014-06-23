Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.CodeDom.Compiler

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
        Dim check_nome As Boolean = True
        Dim check_morada As Boolean = True
        Dim check_nif As Boolean = True
        Dim check_codpostal As Boolean = True
        Dim check_localidade As Boolean = True
        Dim check_logo As Boolean = True
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
        For i = 0 To nifbox.Text.Count - 1
            If nifbox.Text.Chars(i) <> " " Then
                check_nif = False
            End If
        Next
        For i = 0 To cod_postalbox.Text.Count - 1
            If cod_postalbox.Text.Chars(i) <> " " Then
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
                check_logo = False
            End If
        Next
        If check_nome = False And check_morada = False And check_codpostal = False And check_nif = False And check_localidade = False And check_logo = False Then
            BLL.Admin_only.Empresas.inserir(simcheck.Checked, nomebox.Text, moradabox.Text, nifbox.Text, cod_postalbox.Text, localidadebox.Text, logo, True)
            Workspace.config3.Show()
            Me.Close()
        Else
            MsgBox("Preencha todos os dados!")
        End If
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

    Private Sub nifbox_TextChanged(sender As Object, e As EventArgs) Handles nifbox.TextChanged
        If Not IsNumeric(nifbox.Text.Chars(nifbox.Text.Length - 1)) Then
            nifbox.Text = ""
        End If
    End Sub
End Class