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
        Dim n_artigo As Integer = BLL.Reparacoes.carregar_dados_numreparação(Workspace.pass_string, True).Rows(0).Item("NºArtigo").ToString()
        folha_repar_entrega.n_repar = Workspace.pass_string
        folha_repar_entrega.artigodata = BLL.Artigos.carregar_dados_numartigo(n_artigo, True)
        folha_repar_entrega.cliente_data = BLL.Clientes.carregar_dados_numcliente(folha_repar_entrega.artigodata.Rows(0).Item("NºCliente").ToString, True)
        folha_repar_entrega.Show()
    End Sub
End Class