Public Class OPR_Clientes

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            TextBox2.Enabled = True
            TextBox2.Show()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            TextBox2.Enabled = False
            TextBox2.Hide()
        End If
    End Sub

    Private Sub OPR_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.Hide()
        CheckBox2.Checked = True
    End Sub
End Class