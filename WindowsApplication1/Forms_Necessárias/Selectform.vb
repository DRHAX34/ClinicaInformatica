Public Class Selectform
    Public tabela As String
    Public removidos As Boolean
    Private Sub Selectform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Se não metermos .Enabled=false ele reverte para o default, que é true
        'Código de Teste:
        Select Case tabela
            Case "Clientes"
                showdata.DataSource = BLL.Clientes.carregar_clientes()
            Case "Componentes"
                showdata.DataSource = BLL.Componentes.carregar_componentes()
            Case "Empresas"
                showdata.DataSource = BLL.Login.Carregar_empresas()
            Case "Utilizadores"
                showdata.DataSource = BLL.Login.carregar_users
        End Select
    End Sub
End Class