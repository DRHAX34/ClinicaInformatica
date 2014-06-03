Public Class OPR_Clientes
    Public cliente_data As New DataTable

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            numalunobox.Enabled = True
            numalunobox.Show()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            numalunobox.Enabled = False
            numalunobox.Hide()
        End If
    End Sub

    Private Sub OPR_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numalunobox.Hide()
        CheckBox2.Checked = True
        Try
            nomebox.Text = cliente_data.Rows.Item(0).Item("Nome").ToString()
            moradabox.Text = cliente_data.Rows.Item(0).Item("Morada").ToString()
            emailbox.Text = cliente_data.Rows.Item(0).Item("Email").ToString()
            MaskedTextBox1.Text = cliente_data.Rows.Item(0).Item("Cod_Postal").ToString()
            cmovelbox.Text = cliente_data.Rows.Item(0).Item("Contacto Móvel").ToString()
            cfixobox.Text = cliente_data.Rows.Item(0).Item("Contacto Fixo").ToString()
            If cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> 0 Or cliente_data.Rows.Item(0).Item("NºAluno").ToString() <> "" Then
                CheckBox1.Checked = True
                CheckBox2.Checked = False
                numalunobox.Text = cliente_data.Rows.Item(0).Item("NºAluno").ToString()
            Else
                CheckBox1.Checked = False
                CheckBox2.Checked = True
            End If

        Catch ex As Exception
            MsgBox("Erro")
        End Try
    End Sub
End Class