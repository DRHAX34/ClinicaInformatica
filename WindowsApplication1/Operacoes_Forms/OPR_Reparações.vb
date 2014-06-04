Public Class OPR_Reparações
    Public reparaçao_data As New DataTable
    Public modo As Boolean
    Private Sub OPR_Reparações_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numdispositivobox.Text = reparaçao_data.Rows.Item(0).Item("NºDispositivo").ToString()
        categoriabox.Text = reparaçao_data.Rows.Item(0).Item("Categoria").ToString()
        temporealbox.Text = reparaçao_data.Rows.Item(0).Item("TempoRealReparação").ToString()
        dateinicio.Value = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString()
        datefim.Value = reparaçao_data.Rows.Item(0).Item("DFRepar").ToString()
        descriçaobox.Text = reparaçao_data.Rows.Item(0).Item("DescAvaria").ToString()
        If reparaçao_data.Rows.Item(0).Item("Tipo_hard").ToString() <> "" Then
            CheckBox1.Checked = True
            hardwarebox.Text = reparaçao_data.Rows.Item(0).Item("Tipo_hard").ToString()
        End If
        If reparaçao_data.Rows.Item(0).Item("Tipo_soft").ToString() Then
            CheckBox2.Checked = True
            softwarebox.Text = reparaçao_data.Rows.Item(0).Item("Tipo_soft").ToString()
        End If
    End Sub
End Class