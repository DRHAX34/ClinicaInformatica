Public Class OPR_Técnicos
    Public tecnico_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Private Sub OPR_Técnicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numalunobox.Text = tecnico_data.Rows.Item(0).Item("NºCliente").ToString()
        turmabox.Text = tecnico_data.Rows.Item(0).Item("Turma").ToString()
        nomebox.Text = tecnico_data.Rows.Item(0).Item("Nome").ToString()
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click

    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If modo = True Then
            numalunobox.Text = tecnico_data.Rows.Item(0).Item("NºCliente").ToString()
            turmabox.Text = tecnico_data.Rows.Item(0).Item("Turma").ToString()
            nomebox.Text = tecnico_data.Rows.Item(0).Item("Nome").ToString()
        Else
            numalunobox.Text = ""
            turmabox.Text = ""
            nomebox.Text = ""
        End If
    End Sub
End Class