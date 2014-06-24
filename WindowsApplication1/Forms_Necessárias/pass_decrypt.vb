Public Class pass_decrypt

    Private Sub pass_decrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Hide()
        Label4.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim password As String = WaterMarkTextBox1.Text
        Dim wrapper As New Simple3Des("ODASONSNIAJCNDICAOSJDCNSNCASNDNCJNSAKJCBNKJSBDNJCBASKJDBKJASBKJCBSAKDBCHJBJK")
        Dim passencript As String = wrapper.EncryptData(password)
        Dim passdecrypt As String
        Try
            If Workspace.admin_geral = False Then
                passdecrypt = wrapper.DecryptData(BLL.Login.procura_dados_nome(nomebox.Text).Rows.Item(0).Item("Password"))
            Else
                passdecrypt = wrapper.DecryptData(BLL.Admin_only.Login.procura_dados_nutilizador_ativados(nomebox.Text).Rows.Item(0).Item("Password"))
            End If
        Catch
            MsgBox("O Nome de Utilizador não está correto ou o utilizador está desativado!")
        End Try
        If passencript = Workspace.string_pass Then
                Label3.Show()
                Label4.Show()
                Label4.Text = passdecrypt
            Else
                MsgBox("A Palavra-Passe não está correta!")
            End If

    End Sub
End Class