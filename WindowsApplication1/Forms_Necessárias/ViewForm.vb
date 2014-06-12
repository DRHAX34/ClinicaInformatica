Public Class ViewForm
    Public data_table As DataTable
    Public tabela As String
    Public removidos As Boolean
    Private Sub resizing(sender As Object, e As EventArgs) Handles Me.Resize
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
            Case "Componentes"
                Workspace.check_componentes = False
            Case "Empresas"
                Workspace.check_empresas = False
            Case "Reparações"
                Workspace.check_reparacoes = False
            Case "Técnicos"
                Workspace.check_tecnicos = False
            Case "Utilizadores"
                Workspace.check_utilizadores = False
        End Select
    End Sub
    Private Sub ViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        othersbutton.Enabled = True
        'Se não metermos .Enabled=false ele reverte para o default, que é true
        'Código de Teste:
        Select Case tabela
            Case "Clientes"
                othersbutton.Enabled = False
            Case "Componentes"
                othersbutton.Enabled = False 'Até falarmos com o prof.João
            Case "Empresas"
                othersbutton.Enabled = False 'Até falarmos com o prof.João, podem sempre haver outras funções
            Case "Reparações"
                othersbutton.Enabled = True 'Aqui vão estar as opções de Relatórios
            Case "Técnicos"
                othersbutton.Enabled = False '(Emanuel)Creio eu
            Case "Utilizadores"
                othersbutton.Enabled = False '(Emanuel) igualmente creio eu
        End Select
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
                Dim opr_componentes As New OPR_Componentes
                opr_componentes.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_componentes.modo = True
                If removidos = True Then
                    opr_componentes.dispositivo_data = BLL.Componentes.procura_dados_numcomponente_desativo(string_data)
                    opr_componentes.removidos = True
                    opr_componentes.Show()
                Else
                    opr_componentes.dispositivo_data = BLL.Componentes.procura_dados_numcomponente(string_data)
                    opr_componentes.removidos = False
                    opr_componentes.Show()
                End If
            Case "Reparações"
                Dim opr_reparacoes As New OPR_Reparações
                opr_reparacoes.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_reparacoes.modo = True
                If removidos = True Then
                    opr_reparacoes.reparaçao_data = BLL.Reparacoes.procura_dados_numreparação_desativo(string_data)
                    opr_reparacoes.removidos = True
                    opr_reparacoes.Show()
                Else
                    opr_reparacoes.reparaçao_data = BLL.Reparacoes.procura_dados_numreparação(string_data)
                    opr_reparacoes.removidos = False
                    opr_reparacoes.Show()
                End If
            Case "Técnicos"
                Dim opr_tecnicos As New OPR_Técnicos
                opr_tecnicos.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_tecnicos.modo = True
                If removidos = True Then
                    opr_tecnicos.tecnico_data = BLL.Tecnicos.procura_dados_ntecnico_desativados(string_data)
                    opr_tecnicos.removidos = True
                    opr_tecnicos.Show()
                Else
                    opr_tecnicos.tecnico_data = BLL.Tecnicos.procura_dados_ntecnico_ativados(string_data)
                    opr_tecnicos.removidos = False
                    opr_tecnicos.Show()
                End If
            Case "Empresas"
                Dim opr_empresas As New OPR_Empresas
                opr_empresas.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_empresas.modo = True
                If removidos = True Then
                    opr_empresas.empresa_data = BLL.Admin_only.Empresas.procura_dados_numempresa_desativados(string_data)
                    opr_empresas.removidos = True
                    opr_empresas.Show()
                Else
                    opr_empresas.empresa_data = BLL.Admin_only.Empresas.procura_dados_numempresa(string_data)
                    opr_empresas.removidos = True
                    opr_empresas.Show()
                End If
            Case "Utilizadores"
                Dim opr_utilizadores As New OPR_Utilizadores
                opr_utilizadores.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_utilizadores.modo = True
                If removidos = True Then
                    opr_utilizadores.utilizador_data = BLL.Admin_only.Login.procura_dados_codutilizador_desativados(string_data)
                    opr_utilizadores.removidos = True
                    opr_utilizadores.Show()
                Else
                    opr_utilizadores.utilizador_data = BLL.Admin_only.Login.procura_dados_codutilizador_ativados(string_data)
                    opr_utilizadores.removidos = True
                    opr_utilizadores.Show()
                End If
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