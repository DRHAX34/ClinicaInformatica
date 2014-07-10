Public Class folha_repar
    Public cliente_data As New DataTable
    Public componentedata As New DataTable
    Public n_repar As Integer
    Private Sub folha_repar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'TODO: esta linha de código carrega dados na tabela '_BD_C_IDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
            Me.ClientesTableAdapter.Fill(Me._BD_C_IDataSet.Clientes, cliente_data.Rows(0).Item("NºCliente").ToString())
            'TODO: esta linha de código carrega dados na tabela '_BD_C_IDataSet.Componentes'. Você pode movê-la ou removê-la conforme necessário.
            Me.ComponentesTableAdapter.Fill(Me._BD_C_IDataSet.Componentes, componentedata.Rows(0).Item("NºComponente").ToString())
            'TODO: esta linha de código carrega dados na tabela '_BD_C_IDataSet.Reparações'. Você pode movê-la ou removê-la conforme necessário.
            Me.ReparaçõesTableAdapter.Fill(Me._BD_C_IDataSet.Reparações, n_repar)
            'TODO: esta linha de código carrega dados na tabela '_BD_C_IDataSet.Empresas'. Você pode movê-la ou removê-la conforme necessário.
            Me.EmpresasTableAdapter.Fill(Me._BD_C_IDataSet.Empresas, BLL.n_empresa)
            'TODO: esta linha de código carrega dados na tabela '_BD_C_IDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Catch ex As Exception
            MsgBox("Erro ao gerar Relatório: " & ex.Message)
            Me.ReportViewer1.RefreshReport()
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub

    Private Sub ClientesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles ClientesBindingSource.CurrentChanged

    End Sub
End Class