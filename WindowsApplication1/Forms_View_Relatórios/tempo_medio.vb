Public Class tempomedioprintpage

    Private Sub tempomedio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        empresalogobox.Image = BLL.Admin_only.Empresas.return_pic()
        empresalabel.Text = Workspace.EmpresasToolStripMenuItem.Text()
        'Inserir aqui comandos da BLL para devolver a média de estas coisas todas
    End Sub
End Class