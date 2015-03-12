Public Class txtRelatorio_Form
    Dim backup_text As String
    Private Sub txtRelatorio_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'TODO: esta linha de código carrega dados na tabela 'SQLToReportConnection.Artigos'. Você pode movê-la ou removê-la conforme necessário.
        Me.ArtigosTableAdapter.Fill(Me.SQLToReportConnection.Artigos, 1)
        'TODO: esta linha de código carrega dados na tabela 'SQLToReportConnection.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.SQLToReportConnection.Clientes, 1)
        'TODO: esta linha de código carrega dados na tabela 'SQLToReportConnection.Empresas'. Você pode movê-la ou removê-la conforme necessário.
        Me.EmpresasTableAdapter.Fill(Me.SQLToReportConnection.Empresas, 1)
        'TODO: esta linha de código carrega dados na tabela 'SQLToReportConnection.Reparações'. Você pode movê-la ou removê-la conforme necessário.
        Try
            Me.ReparaçõesTableAdapter.Fill(Me.SQLToReportConnection.Reparações, 1)
            'TODO: esta linha de código carrega dados na tabela 'SQLToReportConnection.Participações'. Você pode movê-la ou removê-la conforme necessário.
            Me.ParticipaçõesTableAdapter.Fill(Me.SQLToReportConnection.Participações, 1)
        Catch
        End Try
        'TODO: esta linha de código carrega dados na tabela 'SQLToReportConnection.Hardware'. Você pode movê-la ou removê-la conforme necessário.
        Me.HardwareTableAdapter.Fill(Me.SQLToReportConnection.Hardware, 1)
        'TODO: esta linha de código carrega dados na tabela 'SQLToReportConnection.Software'. Você pode movê-la ou removê-la conforme necessário.
        Me.SoftwareTableAdapter.Fill(Me.SQLToReportConnection.Software, 1)
        Dim certoimagebutton As New Bitmap((My.Resources._1405695721_Select), btnOK.Height, btnOK.Height)
        certoimagebutton.MakeTransparent(Color.White)
        btnOK.Image = certoimagebutton
        Dim exitimagebutton As New Bitmap((My.Resources._1406140864_logout), btnFechar.Height, btnFechar.Height)
        exitimagebutton.MakeTransparent(Color.White)
        btnFechar.Image = exitimagebutton
        Try
            backup_text = BLL.textReport.return_text()
            txtReport.Text = backup_text
        Catch
        End Try
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Try
            BLL.textReport.editar(txtReport.Text)
        Catch ex As Exception
            MsgBox("Erro!!" & ex.Message)
        Finally
            Me.Close()
        End Try

    End Sub

    Private Sub txtReport_KeyPress(sender As Object, e As KeyEventArgs) Handles txtReport.KeyDown
        Try
            If e.KeyCode = Keys.Return Or e.KeyCode = Keys.Enter Then
                Dim count As Integer = 0
                For i = 0 To txtReport.Text.Length - 1
                    If txtReport.Text.Chars(i) = Chr(13) Or txtReport.Text.Chars(i) = Chr(10) Then
                        count += 1
                    End If
                Next
                If count = 3 Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub btnFechar_Click(sender As Object, e As EventArgs) Handles btnFechar.Click
        txtReport.Text = backup_text
        BLL.textReport.editar(txtReport.Text)
        Me.Close()
    End Sub

    Private Sub btnRepor_Click(sender As Object, e As EventArgs) Handles btnRepor.Click
        txtReport.Text = backup_text
    End Sub

    Private Sub btnPreVisualizar_click(sender As Object, e As EventArgs) Handles btnPreVisualizar.Click
        Try
            BLL.textReport.editar(txtReport.Text)
            Me.EmpresasTableAdapter.Fill(Me.SQLToReportConnection.Empresas, 1)
            ReportViewer1.RefreshReport()
        Catch ex As Exception
            MsgBox("Erro!!" & ex.Message)
        End Try
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class