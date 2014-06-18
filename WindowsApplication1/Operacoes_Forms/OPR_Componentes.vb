Public Class OPR_Componentes
    Public dispositivo_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Private Sub OPR_Dispositivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modo = True Then
            numbox.Text = dispositivo_data.Rows.Item(0).Item("NºCliente").ToString()
            marcabox.Text = dispositivo_data.Rows.Item(0).Item("Marca").ToString()
            modelobox.Text = dispositivo_data.Rows.Item(0).Item("Modelo").ToString()
            numseriebox.Text = dispositivo_data.Rows.Item(0).Item("NºSérie").ToString()
            observaçoesbox.Text = dispositivo_data.Rows.Item(0).Item("Observações").ToString()
            RadButton2.Enabled = True
            RadButton3.Text = "Restaurar Dados Originais"
            RadButton5.Enabled = False
        Else
            RadButton2.Enabled = False
            RadButton3.Text = "Limpar Dados"
        End If
        If removidos = True Then
            RadButton2.Text = "Restaurar"
        Else
            RadButton2.Text = "Remover"
        End If
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If modo = True Then
            numbox.Text = dispositivo_data.Rows.Item(0).Item("NºCliente").ToString()
            marcabox.Text = dispositivo_data.Rows.Item(0).Item("Marca").ToString()
            modelobox.Text = dispositivo_data.Rows.Item(0).Item("Modelo").ToString()
            numseriebox.Text = dispositivo_data.Rows.Item(0).Item("NºSérie").ToString()
            observaçoesbox.Text = dispositivo_data.Rows.Item(0).Item("Observações").ToString()
        Else
            numbox.Text = ""
            marcabox.Text = ""
            modelobox.Text = ""
            numseriebox.Text = ""
            observaçoesbox.Text = ""
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click

    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click

    End Sub
End Class