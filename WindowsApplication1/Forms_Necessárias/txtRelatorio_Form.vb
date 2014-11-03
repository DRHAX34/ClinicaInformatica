Public Class txtRelatorio_Form

    Private Sub txtRelatorio_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim certoimagebutton As New Bitmap((My.Resources._1405695721_Select), btnOK.Height, btnOK.Height)
        certoimagebutton.MakeTransparent(Color.White)
        btnOK.Image = certoimagebutton
        Dim exitimagebutton As New Bitmap((My.Resources._1406140864_logout), btnFechar.Height, btnFechar.Height)
        exitimagebutton.MakeTransparent(Color.White)
        btnFechar.Image = exitimagebutton
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            BLL.textReport.editar(txtReport.Text)
        Catch ex As Exception
            MsgBox("Erro!!" & ex.Message)
        Finally
            Me.Close()
        End Try

    End Sub

    Private Sub txtReport_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtReport.KeyPress
        Try
            If e.KeyChar = Microsoft.VisualBasic.Chr(10) Then
                Dim count As Integer = 0
                For i = 0 To txtReport.Text.Length - 1
                    If txtReport.Text.Chars(i) = Chr(10) Then
                        count += 1
                    End If
                Next
                If count = 3 Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
End Class