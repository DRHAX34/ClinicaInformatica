Public Class OPR_Utilizadores
    Public modo As Boolean
    Public utilizador_data As New DataTable
    Private Sub OPR_Utilizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numalunobox.Text = utilizador_data.Rows.Item(0).Item("NºAluno").ToString()
        ComboBox1.DataSource = BLL.Tecnicos.carregar_tecnico
        For i = 0 To ComboBox1.Items.Count - 1
            If utilizador_data.Rows.Item(0).Item("NºTécnico").ToString() = ComboBox1.Items(i) Then
                ComboBox1.SelectedIndex = i
            End If
        Next
        nomeutilizadorbox.Text = utilizador_data.Rows.Item(0).Item("Nome_Util").ToString()
        passwordbox.Text = utilizador_data.Rows.Item(0).Item("Password").ToString()
    End Sub
End Class