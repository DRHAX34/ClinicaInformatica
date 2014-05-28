Public Class ViewForm
    Private modo As Integer
    Private Sub Show_data(ByRef table As String, ByVal layout As Integer)
        modo = layout
        'Se não metermos .Enabled=false ele reverte para o default, que é true
        Select Case layout
            Case 1
                RadButton8.Enabled = False
            Case 2
        End Select
    End Sub

    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadButton8.Enabled = True
    End Sub
End Class