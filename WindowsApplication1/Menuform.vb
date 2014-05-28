Imports System.Windows.Forms

Public Class menuform
    
    Private Sub menuform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim login As New LoginForm
        login.Show()
    End Sub
End Class
