Public Class ViewForm
    Private modo As Integer
    Private table As String
    Private Sub Show_data(ByRef table As DataTable, ByVal layout As Integer, ByVal tabela As String)
        modo = layout
        'Se não metermos .Enabled=false ele reverte para o default, que é true
        'Código de Teste:
        'Select Case layout
        '    Case 1
        '        RadButton8.Enabled = False
        '    Case 2
        'End Select
        Me.Show()
        showdata.DataSource = table
        Me.Text = nome
    End Sub

    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        othersbutton.Enabled = True
    End Sub

    Private Sub newbutton_Click(sender As Object, e As EventArgs) Handles newbutton.Click
        
    End Sub
End Class