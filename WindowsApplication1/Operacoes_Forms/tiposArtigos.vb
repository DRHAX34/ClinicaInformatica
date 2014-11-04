Public Class tiposArtigos

    Private Sub tiposArtigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim certoimagebutton As New Bitmap((My.Resources._1405695721_Select), btnOK.Height, btnOK.Height)
        certoimagebutton.MakeTransparent(Color.White)
        btnOK.Image = certoimagebutton
        Dim exitimagebutton As New Bitmap((My.Resources._1406140864_logout), btnFechar.Height, btnFechar.Height)
        exitimagebutton.MakeTransparent(Color.White)
        btnFechar.Image = exitimagebutton
        Dim dta As ArrayList = BLL.Tipo_Artigo.Return_tudo()
        For i = 0 To dta.Count - 1
            listTipos.Items.Add(dta.Item(i))
        Next
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

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        listTipos.Items.Remove(listTipos.SelectedItem)
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            BLL.Tipo_Artigo.remover()
            If listTipos.Items.Count <> 0 Then
                For i = 0 To listTipos.Items.Count - 1
                    BLL.Tipo_Artigo.inserir_novotipo(listTipos.Items.Item(i))
                Next
                Me.Close()
            Else
                MsgBox("Tem que ter pelo menos um tipo de item!", MsgBoxStyle.Exclamation, "Erro!")
            End If
        Catch
        End Try
    End Sub
End Class