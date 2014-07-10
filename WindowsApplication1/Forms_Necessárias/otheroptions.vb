Public Class otheroptions

    Private Sub otheroptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Workspace.Aluno = False Then
            percentagem_clientesbox.Hide()
            tempo_mediobox.Location = repar_localbox.Location
            repar_localbox.Location = percentagem_clientesbox.Location
        Else
            percentagem_clientesbox.Show()
        End If
    End Sub

    Private Sub newbutton_Click(sender As Object, e As EventArgs) Handles repar_entregabox.Click
        Dim folha_repar_entrega As New folha_repar
        folha_repar_entrega.MdiParent = Workspace
        Dim n_componente As Integer = BLL.Reparacoes.procura_dados_numreparação(Workspace.pass_string).Rows(0).Item("NºComponente").ToString()
        folha_repar_entrega.n_repar = Workspace.pass_string
        folha_repar_entrega.componentedata = BLL.Componentes.carregar_dados_numcomponente(n_componente)
        folha_repar_entrega.cliente_data = BLL.Clientes.carregar_dados_numcliente(folha_repar_entrega.componentedata.Rows(0).Item("NºCliente").ToString)
        folha_repar_entrega.Show()

    End Sub
End Class