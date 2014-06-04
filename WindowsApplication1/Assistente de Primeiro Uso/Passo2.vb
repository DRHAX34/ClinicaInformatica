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

    Private Sub form_resize(ByVal sender As Object, e As EventArgs) Handles Me.Resize
        seguintebutton.Location = New Point((Me.Width - (811 - 629)), (Me.Height - (474 - 364)))
        limparbutton.Location = New Point((Me.Width - (811 - 457)), (Me.Height - (474 - 373)))
        cancelarbutton.Location = New Point((Me.Width - (811 - 314)), (Me.Height - (474 - 376)))
    End Sub
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        Const WM_DWMCOLORIZATIONCOLORCHANGED As Integer = 800
        If m.Msg = WM_DWMCOLORIZATIONCOLORCHANGED Then
            Dim l As Boolean = (m.LParam.ToInt32 = 0)
            Dim w As Integer = m.WParam.ToInt32
            Dim c As New Colorization(w, l)
            Dim args As New ColorizationChangedEventArgs(c)
            RaiseEvent ColourizationChanged(Me, args)
        End If
        MyBase.WndProc(m)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Colorization.OsSupportsAero Then SetBackColor(Colorization.GetDwmColorization)
        Label1.Show()
        Timer1.Start()
        Localidadelabel.Show()
        MaximizeBox = False
        MinimizeBox = False
        caminhobox.Enabled = False
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
        If nomebox.Text <> "" And moradabox.Text <> "" And nifbox.Text <> "" And cod_postalbox.Text <> "" And localidadebox.Text <> "" And img_caminho <> "" Then
            BLL.Admin_only.Empresas.inserir(nomebox.Text, moradabox.Text, nifbox.Text, cod_postalbox.Text, localidadebox.Text, logo, True)
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

End Class