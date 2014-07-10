Public Class Recuperação_pass
    Public int As Integer = 0
    Public arrayl As ArrayList
    Public passdecrypt, respostadecript, perguntadecript As String
    Private Sub seguintebutton_Click(sender As Object, e As EventArgs) Handles seguintebutton.Click
        Select Case int
            Case 0
                Try
                    arrayl = BLL.Admin_only.Login.return_p_r(moradabox.Text)
                    If arrayl.Item(0) <> "" Or arrayl.Item(0) <> "0" Then
                        Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
                        perguntadecript = wrapper.DecryptData(arrayl.Item(0))
                        respostadecript = wrapper.DecryptData(arrayl.Item(1))
                        passdecrypt = wrapper.DecryptData(arrayl.Item(2))
                        Label5.Text = perguntadecript
                        GroupBox1.Show()
                        int = 1
                    Else
                        MsgBox("Introduza um nome de utilizador válido!", vbOKOnly, "Erro!")
                    End If
                Catch ex As Exception
                    MsgBox("Erro ao devolver da Base-de-Dados: " & ex.Message)
                End Try
            Case 1
                If resposta_segur.Text = respostadecript Then
                    Label7.Text = passdecrypt
                    Label6.Show()
                    Label7.Show()
                    seguintebutton.Text = "Sair"
                    int = 2
                Else
                    MsgBox("Resposta Errada!", vbOKOnly, "Erro!")
                End If
            Case 2
                Me.Close()
        End Select
    End Sub
End Class