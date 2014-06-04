Public Class OPR_Técnicos
    Public tecnico_data As New DataTable
    Public modo As Boolean
    Private Sub OPR_Técnicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numalunobox.Text = tecnico_data.Rows.Item(0).Item("NºCliente").ToString()
        turmabox.Text = tecnico_data.Rows.Item(0).Item("Turma").ToString()
        nomebox.Text = tecnico_data.Rows.Item(0).Item("Nome").ToString()
    End Sub
End Class