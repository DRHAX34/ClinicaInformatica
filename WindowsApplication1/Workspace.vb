Imports System.Windows.Forms
Imports System.IO
Imports System.IO.Compression


Public Class Workspace
    Public config2 As New Passo2
    Public config3 As New Passo3
    Public config3_5 As New Passo3emeio
    Public config4 As New Passo4
    Public varias_empresas As Boolean
    Public cache_empresas As ArrayList
    Public cache_users, cache_users2 As DataTable
    Public modo As Integer
    Public user As Integer
    Public Aluno, admin, admin_geral As Boolean
    Public companyname1 As String
    Public support As Integer
    Public tecnicos_support As New DataTable
    Public hardware_support As New DataTable
    Public software_support As New DataTable
    Public string_pass As String
    Public erros As Boolean
    Public check_bd, check_clientes, check_componentes, check_reparacoes, check_tecnicos, check_utilizadores, check_empresas, check_select, check_add As Boolean
    'Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click
    '    Dim OpenFileDialog As New OpenFileDialog
    '    OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    OpenFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"
    '    If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = OpenFileDialog.FileName
    '        ' TODO: Adicione aqui código para abrir o arquivo.
    '    End If
    'End Sub

    'Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
    '    Dim SaveFileDialog As New SaveFileDialog
    '    SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
    '    SaveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"

    '    If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
    '        Dim FileName As String = SaveFileDialog.FileName
    '        ' TODO: Adicionar código aqui para salvar em arquivo o conteúdo atual do formulário.
    '    End If
    'End Sub


    'Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
    '    Me.Close()
    'End Sub

    'Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
    '    ' Use My.Computer.Clipboard para inserir texto ou imagens selecionados na Área de Transferência
    'End Sub

    'Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
    '    ' Use My.Computer.Clipboard para inserir texto ou imagens selecionados na Área de Transferência
    'End Sub

    'Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
    '    'Use My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData para obter informações da Área de Transferência.
    'End Sub


    'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
    '    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    'End Sub

    'Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
    '    Me.LayoutMdi(MdiLayout.Cascade)
    'End Sub

    'Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
    '    Me.LayoutMdi(MdiLayout.TileVertical)
    'End Sub

    'Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
    '    Me.LayoutMdi(MdiLayout.TileHorizontal)
    'End Sub

    'Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
    '    Me.LayoutMdi(MdiLayout.ArrangeIcons)
    'End Sub

    'Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
    '    ' Feche todos os formulários filhos do pai.
    '    For Each ChildForm As Form In Me.MdiChildren
    '        ChildForm.Close()
    '    Next
    'End Sub
    Public m_ChildFormNumber As Integer
    Private Sub resizing(sender As Object, e As EventArgs) Handles Me.Resize
        'terminarsessaobutton.Location = New Point((Me.Width - (1035 - 908)), 12)
        Label1.Location = New Point((Me.Width - (1035 - (965 - (Label1.Size.Width / 2)))), 0)
        Label2.Location = New Point((Me.Width - (1035 - (1015 - (Label2.Size.Width)))), 25)
    End Sub
    Private Sub onclose(sender As Object, e As EventArgs) Handles Me.FormClosing
        DAL.CloseConnection()
        DAL.TerminateConnection()
    End Sub
    
    Private Sub Workspace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If cache_empresas.Count = 0 Then
            If cache_users.Rows.Count = 0 Then
                Me.WindowState = FormWindowState.Normal
                Me.Size = Passo1.Size
                Dim config As New Passo1
                config.MdiParent = Me
                m_ChildFormNumber += 1
                config.Show()
                config2.MdiParent = Me
                m_ChildFormNumber += 1
                config3.MdiParent = Me
                m_ChildFormNumber += 1
                config3_5.MdiParent = Me
                config4.MdiParent = Me
                m_ChildFormNumber += 1
                Me.MaximizeBox = False
            Else
                Me.WindowState = FormWindowState.Maximized
                LoginForm.Show()
            End If
        Else
            If cache_users.Rows.Count = 0 Then
                If varias_empresas = False Then
                    config3_5.MdiParent = Me
                    m_ChildFormNumber += 1
                    config3_5.Show()
                    config3_5.WindowState = FormWindowState.Maximized
                Else
                    config3.MdiParent = Me
                    m_ChildFormNumber += 1
                    config3.Show()
                    config3.WindowState = FormWindowState.Maximized
                End If
            Else
                    Me.WindowState = FormWindowState.Maximized
                    LoginForm.Show()
            End If
        End If
                    Me.DoubleBuffered = True
    End Sub
    Private Sub form_closing(ByVal sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim check As Boolean = False
        For Each ChildForm As Form In Me.MdiChildren
            If ChildForm.Text = "Assistente de Primeiro Uso - Passo 3" And check = False And ChildForm.Visible = True Then
                check = True
                MsgBox("Não pode cancelar o assistente neste momento!")
                e.Cancel = True
            End If
        Next
    End Sub
    Shared Sub login_load()
        If Workspace.modo = 1 Then
            Workspace.EmpresasToolStripMenuItem.Text = "Empresas"
            Workspace.EmpresasToolStripMenuItem.Enabled = True
            Workspace.EmpresasToolStripMenuItem.Image = My.Resources.companyicon
        Else
            Dim imagecompany As Image = BLL.Admin_only.Empresas.carregar_pic()
            Dim companyimage As New Bitmap(imagecompany, 54, 54)
            Workspace.EmpresasToolStripMenuItem.Image = companyimage
            Workspace.EmpresasToolStripMenuItem.Text = Workspace.companyname1
        End If
    End Sub
    Private Sub clientesmenu_Click(sender As Object, e As EventArgs) Handles clientesmenu.Click
        
    End Sub

    Private Sub AtivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles clientesativos.Click
        If check_clientes = False Then
            Dim clientesview As New ViewForm
            check_clientes = True
            clientesview.Text = "Clientes"
            clientesview.tabela = "Clientes"
            clientesview.MdiParent = Me
            m_ChildFormNumber += 1
            If Aluno = True Then
                clientesview.data_table = BLL.Clientes.carregar_alunos()
            Else
                clientesview.data_table = BLL.Clientes.carregar()
            End If
            clientesview.removidos = False
            clientesview.Show()
        Else
            MsgBox("Já tem a janela dos Clientes aberta!")
        End If
    End Sub

    Private Sub RemovidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles clientesremovidos.Click
        If check_clientes = False Then
            Dim clientesview As New ViewForm
            check_clientes = True
            clientesview.Text = "Clientes Removidos"
            clientesview.tabela = "Clientes"
            clientesview.MdiParent = Me
            m_ChildFormNumber += 1
            If Aluno = True Then
                clientesview.data_table = BLL.Clientes.carregar_eliminados_alunos()
            Else
                clientesview.data_table = BLL.Clientes.carregar_eliminados()
            End If
            clientesview.removidos = True
            clientesview.Show()
        Else
            MsgBox("Já tem a janela dos Clientes aberta!")
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles terminarsessao.Click
        If MsgBox("Tem a certeza que quer terminar sessão?", vbYesNo, "Terminar Sessão") = vbYes Then
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            Dim LoginForm1 As New LoginForm
            StatusStrip.Hide()
            MenuStrip.Hide()
            Label1.Hide()
            Label2.Hide()
            LoginForm1.MdiParent = Me
            LoginForm1.Show()
            m_ChildFormNumber += 1
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            'terminarsessaobutton.Hide()
        End If
    End Sub

    Private Sub componentesAtivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles componentesAtivosToolStripMenuItem.Click
        If check_componentes = False Then
            Try
                If BLL.Clientes.carregar.Rows.Count = 0 Then
                    If MsgBox("Antes de adicionar/alterar um componente, tem que adicionar um Cliente, deseja fazê-lo agora?", vbOKCancel, "Erro") = vbOK Then
                        Dim opr_clientes As New OPR_Clientes
                        opr_clientes.MdiParent = Me
                        m_ChildFormNumber += 1
                        opr_clientes.Show()
                    Else
                        MsgBox("Não poderá adicionar um componente até adicionar um cliente!")
                    End If
                Else
                    Dim componentesview As New ViewForm
                    check_componentes = True
                    componentesview.Text = "Componentes"
                    componentesview.tabela = "Componentes"
                    componentesview.MdiParent = Me
                    m_ChildFormNumber += 1
                    componentesview.data_table = BLL.Componentes.carregar
                    componentesview.removidos = False
                    componentesview.Show()
                End If
            Catch ex As Exception
                MsgBox("Erro ao executar comando: " & ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("Já tem a janela dos Componentes aberta!")
        End If
    End Sub

    Private Sub componentesRemovidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles componentesRemovidosToolStripMenuItem.Click
        If check_componentes = False Then
            If BLL.Clientes.carregar.Rows.Count = 0 Then
                If MsgBox("Antes de adicionar/alterar um componente, tem que adicionar um Cliente, deseja fazê-lo agora?", vbOKCancel, "Erro") = vbOK Then
                    clientesativos.PerformClick()
                    Dim opr_clientes As New OPR_Clientes
                    opr_clientes.MdiParent = Me
                    m_ChildFormNumber += 1
                    opr_clientes.Show()
                Else
                    MsgBox("Não poderá adicionar um componente até adicionar um cliente!")
                End If
            Else
                Dim componentesview As New ViewForm
                check_componentes = True
                componentesview.Text = "Componentes Removidos"
                componentesview.tabela = "Componentes"
                componentesview.MdiParent = Me
                m_ChildFormNumber += 1
                componentesview.data_table = BLL.Componentes.carregar_desativos
                componentesview.removidos = True
                componentesview.Show()
            End If
        Else
            MsgBox("Já tem a janela dos Componentes aberta!")
        End If
    End Sub

    Private Sub empresasativas_Click(sender As Object, e As EventArgs) Handles empresasativas.Click
        If check_empresas = False Then
            Try
                Dim empresasview As New ViewForm
                check_empresas = True
                empresasview.Text = "Empresas"
                empresasview.tabela = "Empresas"
                empresasview.MdiParent = Me
                m_ChildFormNumber += 1
                empresasview.data_table = BLL.Admin_only.Empresas.carregar()
                empresasview.removidos = False
                empresasview.Show()
            Catch ex As Exception
                MsgBox("Erro ao executar comando: " & ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("Já tem a janela das Empresas abertas!")
        End If
    End Sub

    Private Sub empresasremovidas_Click(sender As Object, e As EventArgs) Handles empresasremovidas.Click
        If check_empresas = False Then
            Try
                Dim empresasview As New ViewForm
                check_empresas = True
                empresasview.Text = "Empresas"
                empresasview.tabela = "Empresas"
                empresasview.MdiParent = Me
                m_ChildFormNumber += 1
                empresasview.data_table = BLL.Admin_only.Empresas.carregar_eliminados
                empresasview.removidos = True
                empresasview.Show()
            Catch ex As Exception
                MsgBox("Erro ao executar comando: " & ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("Já tem a janela das Empresas abertas!")
        End If
    End Sub

    Private Sub reparativos_Click(sender As Object, e As EventArgs) Handles reparativos.Click
        If check_reparacoes = False Then
            If BLL.Clientes.carregar.Rows.Count <> 0 Then
                If BLL.Componentes.carregar.Rows.Count <> 0 Then
                    If BLL.Tecnicos.carregar.Rows.Count <> 0 Then
                        Try
                            Dim repararview As New ViewForm
                            check_reparacoes = True
                            repararview.Text = "Reparações"
                            repararview.tabela = "Reparações"
                            repararview.MdiParent = Me
                            m_ChildFormNumber += 1
                            repararview.data_table = BLL.Reparacoes.carregar()
                            repararview.removidos = False
                            repararview.Show()
                        Catch ex As Exception
                            MsgBox("Erro ao executar comando: " & ex.Message)
                            Me.Close()
                        End Try
                    Else
                        If MsgBox("Não tem nenhum técnico inserido, deseja inserir um técnico?", vbYesNo, "Sem Técnicos!") = vbYes Then
                            Dim opr_tecnicos As New OPR_Técnicos
                            opr_tecnicos.MdiParent = Me
                            m_ChildFormNumber += 1
                            opr_tecnicos.modo = False
                            opr_tecnicos.Show()
                        Else
                            MsgBox("Não poderá inserir/visualizar reparações até inserir pelo menos um técnico!", vbOKOnly, "Sem Técnicos!")
                        End If
                End If
            Else
                If MsgBox("Não tem nenhum cliente inserido, deseja inserir algum?", vbYesNo, "Nenhum Cliente Inserido") = vbYes Then
                    Dim opr_clientes As New OPR_Clientes
                    opr_clientes.MdiParent = Me
                    m_ChildFormNumber += 1
                    opr_clientes.modo = False
                    opr_clientes.Show()
                Else
                    MsgBox("Não poderá inserir/visualizar Reparações até inserir um cliente!", vbOK, "Erro")
                End If
            End If
            Else
                If MsgBox("Não tem nenhum componente inserido no programa, deseja criar um?", vbYesNo, "Nenhum Componente Inserido") = vbYes Then
                    Dim opr_componentes As New OPR_Componentes
                    opr_componentes.MdiParent = Me
                    m_ChildFormNumber += 1
                    opr_componentes.modo = False
                    opr_componentes.Show()
                Else
                    MsgBox("Não poderá inserir/visualizar Reparações até inserir um Componente!", vbOK, "Erro")
                End If
            End If
        Else
            MsgBox("Já tem a janela das Reparações abertas!")
        End If
    End Sub

    Private Sub utilativos_Click(sender As Object, e As EventArgs) Handles utilativos.Click
        If check_utilizadores = False Then
            Try
                Dim utilizadorview As New ViewForm
                check_utilizadores = True
                utilizadorview.Text = "Utilizadores"
                utilizadorview.tabela = "Utilizadores"
                utilizadorview.MdiParent = Me
                m_ChildFormNumber += 1
                If admin_geral = True Then
                    utilizadorview.data_table = BLL.Admin_only.Login.carregar_users()
                Else
                    utilizadorview.data_table = BLL.Admin_only.Login.carregar_users_empresa(BLL.n_empresa)
                End If
                utilizadorview.removidos = False
                utilizadorview.Show()
            Catch ex As Exception
                MsgBox("Erro ao executar comando: " & ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("Já tem a janela dos Utilizadores abertas!")
        End If
    End Sub

    Private Sub utilremovidos_Click(sender As Object, e As EventArgs) Handles utilremovidos.Click
        If check_utilizadores = False Then
            Try
                Dim utilizadorview As New ViewForm
                check_utilizadores = True
                utilizadorview.Text = "Utilizadores"
                utilizadorview.tabela = "Utilizadores"
                utilizadorview.MdiParent = Me
                m_ChildFormNumber += 1
                If admin_geral = True Then
                    utilizadorview.data_table = BLL.Admin_only.Login.carregar_users_eliminados
                Else
                    utilizadorview.data_table = BLL.Admin_only.Login.carregar_users_eliminados_empresa(BLL.n_empresa)
                End If
                utilizadorview.removidos = True
                utilizadorview.Show()
            Catch ex As Exception
                MsgBox("Erro ao executar comando: " & ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("Já tem a janela dos Utilizadores abertas!")
        End If
    End Sub

    Private Sub EmpresasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmpresasToolStripMenuItem.Click

    End Sub

    Private Sub reparremovidos_Click(sender As Object, e As EventArgs) Handles reparremovidos.Click
        If check_reparacoes = False Then
            Try
                Dim repararview As New ViewForm
                check_reparacoes = True
                repararview.Text = "Reparações Removidas"
                repararview.tabela = "Reparações"
                repararview.MdiParent = Me
                m_ChildFormNumber += 1
                repararview.data_table = BLL.Reparacoes.carregar_desativos
                repararview.removidos = True
                repararview.Show()
            Catch ex As Exception
                MsgBox("Erro ao executar comando: " & ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("Já tem a janela das Reparações abertas!")
        End If
    End Sub

    Private Sub tecnicosativos_Click(sender As Object, e As EventArgs) Handles tecnicosativos.Click
        If check_tecnicos = False Then
            Try
                Dim tecnicoview As New ViewForm
                check_tecnicos = True
                tecnicoview.Text = "Técnicos"
                tecnicoview.tabela = "Técnicos"
                tecnicoview.MdiParent = Me
                m_ChildFormNumber += 1
                tecnicoview.data_table = BLL.Tecnicos.carregar()
                tecnicoview.removidos = False
                tecnicoview.Show()
            Catch ex As Exception
                MsgBox("Erro ao executar comando: " & ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("Já tem a janela dos Técnicos abertas!")
        End If
    End Sub

    Private Sub tecremovidos_Click(sender As Object, e As EventArgs) Handles tecremovidos.Click
        If check_tecnicos = False Then
            Try
                Dim tecnicoview As New ViewForm
                check_tecnicos = True
                tecnicoview.Text = "Técnicos Removidos"
                tecnicoview.tabela = "Técnicos"
                tecnicoview.MdiParent = Me
                m_ChildFormNumber += 1
                tecnicoview.data_table = BLL.Tecnicos.carregar_eliminados()
                tecnicoview.removidos = True
                tecnicoview.Show()
            Catch ex As Exception
                MsgBox("Erro ao executar comando: " & ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("Já tem a janela dos Técnicos abertas!")
        End If
    End Sub

    
    Private Sub Statuscheck_Tick(sender As Object, e As EventArgs) Handles Statuscheck.Tick
        If erros = True Then
            ToolStripStatusLabel1.Text = "Ocorreram Erros no Programa"
        Else
            ToolStripStatusLabel1.Text = "O programa está a decorrer normalmente!"
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox1.MdiParent = Me
        AboutBox1.Show()
    End Sub
End Class
