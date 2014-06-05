Public Class ViewForm
    Public data_table As DataTable
    Public layout As Integer
    Public tabela As String
    Private Sub onresize(sender As Object, e As EventArgs) Handles Me.Resize
        showdata.Width = Me.Width - 50
        showdata.Height = Me.Height - 200
        othersbutton.Location = New Point((Me.Width - (750 - 494)), (Me.Height - (506 - 417)))
        exitbutton.Location = New Point((Me.Width - (750 - 620)), (Me.Height - (506 - 417)))
        delbutton.Location = New Point((delbutton.Location.X), (Me.Height - (506 - 417)))
        updatebutton.Location = New Point((updatebutton.Location.X), (Me.Height - (506 - 417)))
        findbutton.Location = New Point((Me.Width - (750 - 494)), (Me.Height - (506 - 364)))
        showbutton.Location = New Point((Me.Width - (750 - 620)), (Me.Height - (506 - 364)))
        newbutton.Location = New Point((newbutton.Location.X), (Me.Height - (506 - 364)))
        editbutton.Location = New Point((editbutton.Location.X), (Me.Height - (506 - 364)))
    End Sub
    Private Sub onclose(sender As Object, e As EventArgs) Handles Me.FormClosing
        Select Case tabela
            Case "Clientes"
                Workspace.check_clientes = False
        End Select
    End Sub
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
        showdata.AllowAutoSizeColumns = True
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
            Case "Utilizadores"
                Workspace.opr_utilizadores.modo = False
                Workspace.opr_utilizadores.Show()
            Case "Empresas"

        End Select
        Me.Close()
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
            Case "Componentes"
                Workspace.opr_dispositivos.dispositivo_data = BLL.Componentes.procura_dados_numcomponente(string_data)
                Workspace.opr_dispositivos.modo = False
                Workspace.opr_dispositivos.Show()
            Case "Reparações"
                Workspace.opr_reparacoes.reparaçao_data = BLL.Reparacoes.procura_dados_numreparação(string_data)
                Workspace.opr_reparacoes.modo = False
                Workspace.opr_reparacoes.Show()
            Case "Técnicos"
                Workspace.opr_tecnicos.tecnico_data = BLL.Tecnicos.procura_dados_ntecnico_ativados(string_data)
                Workspace.opr_tecnicos.modo = False
                Workspace.opr_tecnicos.Show()
        End Select
        Me.Close()
    End Sub

    
    Private Sub delbutton_Click(sender As Object, e As EventArgs) Handles delbutton.Click
        Me.Close()
    End Sub

    Private Sub updatebutton_Click(sender As Object, e As EventArgs) Handles updatebutton.Click

    End Sub

    Private Sub findbutton_Click(sender As Object, e As EventArgs) Handles findbutton.Click
    End Sub

    Private Sub showbutton_Click(sender As Object, e As EventArgs) Handles showbutton.Click
        Me.Close()
    End Sub

    Private Sub othersbutton_Click(sender As Object, e As EventArgs) Handles othersbutton.Click

    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub
End Class