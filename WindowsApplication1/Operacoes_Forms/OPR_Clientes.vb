Public Class OPR_Clientes
    Public cliente_data As New DataTable
    Public modo As Boolean

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox1.Checked = True Then
            CheckBox2.Checked = False
            numalunobox.Enabled = True
            numalunobox.Show()
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs)
        If CheckBox2.Checked = True Then
            CheckBox1.Checked = False
            numalunobox.Enabled = False
            numalunobox.Hide()
        End If
    End Sub

    Private Sub OPR_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numalunobox.Hide()
        CheckBox2.Checked = True
        If Workspace.alunos = False Then
            numalunobox.Hide()
            Label7.Hide()
            CheckBox1.Hide()
            CheckBox2.Hide()
        End If
        If modo = True Then
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
        End If
            

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click
        RadioButton2.Checked = False
        RadioButton1.Checked = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.Click
        RadioButton2.Checked = True
        RadioButton1.Checked = False
    End Sub
End Class