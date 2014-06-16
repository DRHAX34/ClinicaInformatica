
Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.CodeDom.Compiler

Public Class Passo4
    Private Sub form_resize(ByVal sender As Object, e As EventArgs) Handles Me.Resize
        Button2.Location = New Point((Me.Width - (811 - 629)), (Me.Height - (474 - 364)))
    End Sub
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
        MyBase.WndProc(m)
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Colorization.OsSupportsAero Then SetBackColor(Colorization.GetDwmColorization)
        Label1.Show()
        Timer1.Start()
        MaximizeBox = False
        MinimizeBox = False
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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Colorization.OsSupportsAero Then SetBackColor(Colorization.GetDwmColorization)
    End Sub
    Private Sub Passo4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "Parabéns! O seu programa está" & vbNewLine & "agora configurado!"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Workspace.LoginForm1.Show()
        Me.Close()
    End Sub
End Class