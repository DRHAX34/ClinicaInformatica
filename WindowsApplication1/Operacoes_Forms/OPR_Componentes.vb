Public Class OPR_Componentes
    Public dispositivo_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Private Sub OPR_Dispositivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numbox.Text = dispositivo_data.Rows.Item(0).Item("NºCliente").ToString()
        marcabox.Text = dispositivo_data.Rows.Item(0).Item("Marca").ToString()
        modelobox.Text = dispositivo_data.Rows.Item(0).Item("Modelo").ToString()
        numseriebox.Text = dispositivo_data.Rows.Item(0).Item("NºSérie").ToString()
        observaçoesbox.Text = dispositivo_data.Rows.Item(0).Item("Observações").ToString()

    End Sub
End Class