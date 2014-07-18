Public Class Selectform
    Public tabela As String
    Public modo As Boolean
    Public ID As Integer
    Private Sub onclose(sender As Object, e As EventArgs) Handles Me.FormClosed
        Workspace.check_select = False
    End Sub
    Private Sub Selectform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            showdata.DataSource = BLL.Artigos.procura_dados("", True)
        Catch ex As Exception
            MsgBox("Erro ao carregar: " & ex.Message, vbOKOnly, "Erro!")
        End Try
    End Sub
    
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            showdata.DataSource = BLL.Artigos.procura_dados(TextBox1.Text, True)
        Catch ex As Exception
            MsgBox("Erro ao procurar: " & ex.Message, vbOKOnly, "Erro!")
        End Try
    End Sub

    Private Sub adicionarbutton_Click(sender As Object, e As EventArgs) Handles adicionarbutton.Click
        Try
            Workspace.support = CInt(showdata.Rows(showdata.CurrentCell.RowIndex).Cells(0).Value.ToString())
            Me.Close()
        Catch ex As Exception
            MsgBox("Selecione algum dado na tabela!")
        End Try
    End Sub
End Class