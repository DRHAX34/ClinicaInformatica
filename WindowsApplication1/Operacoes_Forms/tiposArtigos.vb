Public Class tiposArtigos

    Private Sub tiposArtigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim certoimagebutton As New Bitmap((My.Resources._1405695721_Select), btnOK.Height, btnOK.Height)
        certoimagebutton.MakeTransparent(Color.White)
        btnOK.Image = certoimagebutton
        Dim exitimagebutton As New Bitmap((My.Resources._1406140864_logout), btnFechar.Height, btnFechar.Height)
        exitimagebutton.MakeTransparent(Color.White)
        btnFechar.Image = exitimagebutton
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtTipo.GotFocus
        Me.AcceptButton = btnInserir
    End Sub
    Private Sub TextBox1_LostFocus(sender As Object, e As EventArgs) Handles txtTipo.LostFocus
        Me.AcceptButton = btnOK
    End Sub

    Private Sub btnInserir_Click(sender As Object, e As EventArgs) Handles btnInserir.Click
        listTipos.Items.Add(txtTipo.Text)
    End Sub
End Class