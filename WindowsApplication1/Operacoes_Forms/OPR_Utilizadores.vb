Public Class OPR_Utilizadores
    Public modo As Boolean
    Public utilizador_data As New DataTable
    Private Sub OPR_Utilizadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numalunobox.Text = utilizador_data.Rows.Item(0).Item("NºAluno").ToString()
        tecnicobox.DataSource = BLL.Tecnicos.carregar_tecnico
        empresabox.DataSource = BLL.Login.Carregar_empresas()
        For i = 0 To tecnicobox.Items.Count - 1
            If utilizador_data.Rows.Item(0).Item("NºTécnico").ToString() = tecnicobox.Items(i) Then
                tecnicobox.SelectedIndex = i
            End If
        Next
        Dim nome As String
        nome = BLL.Admin_only.Empresas.check_name(utilizador_data.Rows.Item(0).Item("NºEmpresa").ToString())
        For i = 0 To empresabox.Items.Count - 1
            If nome = tecnicobox.Items(i) Then
                tecnicobox.SelectedIndex = i
            End If
        Next
        nomeutilizadorbox.Text = utilizador_data.Rows.Item(0).Item("Nome_Util").ToString()
        passwordbox.Text = utilizador_data.Rows.Item(0).Item("Password").ToString()
    End Sub
End Class