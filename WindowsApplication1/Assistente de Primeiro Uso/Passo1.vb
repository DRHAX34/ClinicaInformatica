Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Runtime.InteropServices
Imports System.Security
Imports System.CodeDom.Compiler

Public Class Passo1

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
        Timer1.Start()
        Me.MinimizeBox = False
        MinimizeBox = False
        Me.MaximizeBox = False
        MaximizeBox = False
        Me.WindowState = FormWindowState.Minimized
        Me.WindowState = FormWindowState.Maximized
        variascheck.Checked = True
    End Sub
    Private Sub Form1_ColourizationChanged(ByVal sender As Object, ByVal e As ColorizationChangedEventArgs) Handles Me.ColourizationChanged
        SetBackColor(e.Colorization)
    End Sub

    Private Sub SetBackColor(ByVal colorization As Colorization)
        Dim debug_txt As String
        debug_txt = colorization.Color.ToString & " " & colorization.OpaqueBlend.ToString
        If colorization.Color.ToArgb <> Color.FromArgb(0, 0, 0, 0).ToArgb Then
            Me.BackColor = colorization.SolidColor ' alpha is set to 255.
        Else
            Me.BackColor = Color.White
        End If
        Label1.ForeColor = colorization.Inversecolor
        Label2.ForeColor = colorization.Inversecolor
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Workspace.config2.Show()
        Workspace.varias_empresas = variascheck.Checked
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Tem a certeza que deseja cancelar?", MsgBoxStyle.OkCancel) = vbOK Then
            Workspace.Close()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Colorization.OsSupportsAero Then SetBackColor(Colorization.GetDwmColorization)
    End Sub

    Private Sub umacheck_Click(sender As Object, e As EventArgs) Handles umacheck.Click
        variascheck.Checked = False
        umacheck.Checked = True
    End Sub

    Private Sub variascheck_Click(sender As Object, e As EventArgs) Handles variascheck.Click
        umacheck.Checked = False
        variascheck.Checked = True
    End Sub
End Class

Public Class Colorization

    Public Property Color As Color
    Public Property SolidColor As Color
    Public Property Inversecolor As Color
    Public Property OpaqueBlend As Boolean

    <SuppressUnmanagedCodeSecurity()> _
    Private Class NativeMethods
        <DllImport("dwmapi.dll")> _
        Public Shared Function DwmGetColorizationColor(<Out()> ByRef pColor As Integer, <Out()> ByRef opaqueBlend As Boolean) As Integer
        End Function
    End Class

    Public Sub New(ByVal argb As Integer, ByVal opaqueBlend As Boolean)
        Dim argb_new As Integer
        Me.Color = Color.FromArgb(argb)
        Me.SolidColor = Color.FromArgb(argb Or &HFF000000)
        argb_new = 255 - argb
        Me.OpaqueBlend = opaqueBlend
        Me.Inversecolor = Color.FromArgb(argb_new)
    End Sub

    Public Shared Function GetDwmColorization() As Colorization
        Dim argb As Integer
        Dim opaqueBlend As Boolean
        Dim result As Integer = NativeMethods.DwmGetColorizationColor(argb, opaqueBlend)
        If result <> 0 Then Throw New Win32Exception
        Return New Colorization(argb, opaqueBlend)
    End Function

    Public Shared Function OsSupportsAero() As Boolean
        Return (Environment.OSVersion.Version.Major > 5)
    End Function

End Class


Public Class ColorizationChangedEventArgs
    Inherits EventArgs

    Public Property Colorization As Colorization

    Public Sub New(ByVal colorization As Colorization)
        Me.Colorization = colorization
    End Sub

End Class