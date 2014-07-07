Public Class folha_repar
    Public cliente_data As New DataTable
    Public componentedata As New DataTable
    Public n_repar As Integer
    Private Sub folha_repar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datalabel.Text = Today
    End Sub
End Class