Public Class teste

    Private Sub teste_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim image2 As Image
        DAL.CreateConnection()
        image2 = BLL.Admin_only.Empresas.carregar_pic(1)
        PictureBox1.Image = image2
    End Sub
End Class