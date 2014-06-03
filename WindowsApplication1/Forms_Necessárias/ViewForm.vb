Public Class ViewForm
    Public data_table As DataTable
    Public layout As Integer
    Public tabela As String

    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        othersbutton.Enabled = True
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
    End Sub

    Private Sub newbutton_Click(sender As Object, e As EventArgs) Handles newbutton.Click
        
    End Sub
End Class