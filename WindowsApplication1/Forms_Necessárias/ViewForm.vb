Public Class ViewForm
    Public data_table As DataTable
    Public layout As Integer
    Public tabela As String
    Public removidos As Boolean
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
        If removidos = True Then
            delbutton.Text = "Restaurar"
            newbutton.Enabled = False
        Else
            delbutton.Text = "Eliminar"
            newbutton.Enabled = True
        End If
    End Sub

    Private Sub newbutton_Click(sender As Object, e As EventArgs) Handles newbutton.Click





        Select Case tabela
            Case "Clientes"
                Dim opr_clientes As New OPR_Clientes
                opr_clientes.modo = False
                opr_clientes.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_clientes.Show()
            Case "Componentes"
                Dim opr_componentes As New OPR_Componentes
                opr_componentes.modo = False
                opr_componentes.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_componentes.Show()
            Case "Reparações"
                Dim opr_reparacoes As New OPR_Reparações
                opr_reparacoes.modo = False
                opr_reparacoes.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_reparacoes.Show()
            Case "Técnicos"
                Dim opr_tecnicos As New OPR_Técnicos
                opr_tecnicos.modo = False
                opr_tecnicos.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_tecnicos.Show()
            Case "Utilizadores"
                Dim opr_utilizadores As New OPR_Utilizadores
                opr_utilizadores.modo = False
                opr_utilizadores.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_utilizadores.Show()
            Case "Empresas"
                Dim opr_empresas As New OPR_Empresas
                opr_empresas.modo = False
                opr_empresas.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_empresas.Show()
        End Select
        Me.Close()
    End Sub

    Private Sub editbutton_Click(sender As Object, e As EventArgs) Handles editbutton.Click
        Dim string_data As String
        string_data = showdata.Rows(showdata.CurrentCell.RowIndex).Cells(0).Value.ToString()
        Select Case tabela
            Case "Clientes"
                Dim opr_clientes As New OPR_Clientes
                opr_clientes.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_clientes.modo = True
                If removidos = True Then
                    If Workspace.Aluno = True Then
                        opr_clientes.cliente_data = BLL.Clientes.procura_dados_numcliente_desativados_alunos(string_data)
                        opr_clientes.removidos = True
                        opr_clientes.Show()
                    Else
                        opr_clientes.cliente_data = BLL.Clientes.procura_dados_numcliente_desativados(string_data)
                        opr_clientes.removidos = True
                        opr_clientes.Show()
                    End If
                Else
                    If Workspace.Aluno = True Then
                        opr_clientes.cliente_data = BLL.Clientes.procura_dados_numcliente_alunos(string_data)
                        opr_clientes.removidos = False
                        opr_clientes.Show()
                    Else
                        opr_clientes.cliente_data = BLL.Clientes.procura_dados_numcliente(string_data)
                        opr_clientes.removidos = False
                        opr_clientes.Show()
                    End If
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