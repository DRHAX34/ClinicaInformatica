Public Class ViewForm
    Public data_table As DataTable
    Public layout As Integer
    Public tabela As String

    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        othersbutton.Enabled = True
        'Se não metermos .Enabled=false ele reverte para o default, que é true
        'Código de Teste:
        'Select Case layout
        '    Case 1
        '        RadButton8.Enabled = False
        '    Case 2
        'End Select
        Me.Show()
        showdata.DataSource = data_table
    End Sub

    Private Sub newbutton_Click(sender As Object, e As EventArgs) Handles newbutton.Click
        Select Case tabela
            Case "Clientes"
                Workspace.opr_clientes.modo = False
                Workspace.opr_clientes.Show()
            Case "Dispositivos"
                Workspace.opr_dispositivos.modo = False
                Workspace.opr_dispositivos.Show()
            Case "Reparações"
                Workspace.opr_reparacoes.modo = False
                Workspace.opr_reparacoes.Show()
            Case "Técnicos"
                Workspace.opr_tecnicos.modo = False
                Workspace.opr_tecnicos.Show()
        End Select
    End Sub

    Private Sub editbutton_Click(sender As Object, e As EventArgs) Handles editbutton.Click
        Dim string_data As String
        string_data = showdata.Rows(showdata.CurrentCell.RowIndex).Cells(0).Value.ToString()
        Select Case tabela
            Case "Clientes"
                Workspace.opr_clientes.modo = True
                If Workspace.Aluno = True Then
                    Workspace.opr_clientes.cliente_data = BLL.Clientes.procura_dados_numcliente_alunos(string_data)
                    Workspace.opr_clientes.Show()
                Else
                    Workspace.opr_clientes.cliente_data = BLL.Clientes.procura_dados_numcliente(string_data)
                    Workspace.opr_clientes.Show()
                End If
            Case "Dispositivos"
                Workspace.opr_dispositivos.dispositivo_data = BLL.Dispositivos.procura_dados_numdispositivo(string_data)
                Workspace.opr_dispositivos.modo = False
                Workspace.opr_dispositivos.Show()
            Case "Reparações"
                Workspace.opr_reparacoes.reparaçao_data = BLL.Reparacoes.procura_dados_numreparação(string_data)
                Workspace.opr_reparacoes.modo = False
                Workspace.opr_reparacoes.Show()
            Case "Técnicos"
                Workspace.opr_tecnicos.tecnicos_data = BLL.Tecnicos.procura_dados_ntecnico_ativados(string_data)
                Workspace.opr_tecnicos.modo = False
                Workspace.opr_tecnicos.Show()
        End Select
    End Sub
End Class