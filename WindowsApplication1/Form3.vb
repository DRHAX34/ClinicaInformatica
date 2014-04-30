Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Dim img As Image = New Bitmap(OpenFileDialog1.FileName)
        PictureBox1.Image = img
        DAL.store_pic_Sql(img)
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DAL.CreateConnection()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Image = Nothing
        System.Threading.Thread.Sleep(50)
        Dim img As Image = DAL.Load_Pic_Sql(1)
        PictureBox1.Image = img
    End Sub
End Class