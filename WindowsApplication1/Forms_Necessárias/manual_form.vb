Public Class manual_form

    Private Sub me_onresize(sender As Object, e As EventArgs) Handles Me.Resize
        RadPdfViewer1.Size = New Size(Me.ClientRectangle.Width, Me.ClientRectangle.Height - 34)

    End Sub

    Private Sub manual_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadPdfViewerNavigator1.OpenButton.Enabled = False
        If Not System.IO.Directory.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Manual_instr") Then
            System.IO.Directory.CreateDirectory(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Manual_instr")
        End If
        If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Manual_instr\manual.pdf") = True Then
            System.IO.File.WriteAllBytes(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Manual_instr\manual.pdf", My.Resources.Manual_de_Instruções)
        End If
        RadPdfViewer1.LoadDocument(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Manual_instr\manual.pdf")
    End Sub
End Class