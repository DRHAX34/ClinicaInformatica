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

    Private Sub txtReport_KeyPress(sender As Object, e As KeyEventArgs) Handles txtReport.KeyDown
        Try
            If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
                Dim count As Integer = 0
                For i = 0 To txtReport.Text.Length - 1
                    If txtReport.Text.Chars(i) = Chr(13) Or txtReport.Text.Chars(i) = Chr(10) Then
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

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class