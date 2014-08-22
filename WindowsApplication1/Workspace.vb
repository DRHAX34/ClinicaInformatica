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
    Public Aluno, admin As Boolean
    Public tecnico As String
    Public companyname1 As String
    Public support As Integer
    Public tecnicos_support As New DataTable
    Public hardware_support As New DataTable
    Public software_support As New DataTable
    Public string_pass, pass_string As String
    Public erros As Boolean
    Public preço As String
    Public check_bd, check_clientes, check_artigos, check_reparacoes, check_tecnicos, check_utilizadores, check_empresas, check_select, check_add As Boolean
    Public Sub New()
        InitializeComponent()
        WindowState = FormWindowState.Maximized
        Dim mdi As New MdiClientWithoutScrollBars(Me)
    End Sub
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
        Label1.Location = New Point((Me.Width - (1035 - (956 - (Label1.Size.Width) - (5)))), 15)
        companylogo.Location = New Point((Me.Width - (1118 - 1032)), 0)
        Label2.Location = New Point((Me.Width - Label2.Size.Width - 25), (Me.Height - (506 - 446)))
    End Sub
    Private Sub onclose(sender As Object, e As EventArgs) Handles Me.FormClosing
    End Sub
    
    Private Sub Workspace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AutoScroll = False
        Me.AutoSize = False
        companylogo.Hide()
        Label2.Hide()
        If cache_users.Rows.Count = 0 Then
            If cache_empresas.Count = 0 Then
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
        Dim companyimage As Image = BLL.Admin_only.Empresas.return_pic()
        Workspace.companylogo.Image = companyimage
        Workspace.Label1.Text = Workspace.companyname1
    End Sub
    Private Sub clientesmenu_Click(sender As Object, e As EventArgs) Handles clientesmenu.Click
        If check_clientes = False Then
            Dim clientesview As New ViewForm
            check_clientes = True
            clientesview.Text = "Clientes"
            clientesview.tabela = "Clientes"
            clientesview.MdiParent = Me
            m_ChildFormNumber += 1
            If Aluno = True Then
                clientesview.data_table = BLL.Clientes.carregar_alunos(True)
            Else
                clientesview.data_table = BLL.Clientes.carregar(True)
            End If
            clientesview.removidos = False
            clientesview.Show()
        Else
            MsgBox("Já tem a janela dos Clientes aberta!")
        End If
    End Sub
    Private Sub RadButton1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tecremovidos_Click(sender As Object, e As EventArgs)
        If check_tecnicos = False Then
            Try
                Dim tecnicoview As New ViewForm
                check_tecnicos = True
                tecnicoview.Text = "Técnicos Removidos"
                tecnicoview.tabela = "Técnicos"
                tecnicoview.MdiParent = Me
                m_ChildFormNumber += 1
                tecnicoview.data_table = BLL.Tecnicos.carregar(False)
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

    Private Sub BackupDeDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupDeDadosToolStripMenuItem.Click
        'DAL.Connection.Close()
        'DAL.Connection.Dispose()
        'Console.RunCommandCom("/F /IM sqlservr.exe", "", True)
        'DAL.Connection.Dispose()
        Dim sql_caminho, sqlnome As String
        SaveFileDialog1.Filter = "Base-de-Dados Clínica Informática | *.CIDB"
        SaveFileDialog1.FileName = ""
        SaveFileDialog1.ShowDialog()
        sql_caminho = SaveFileDialog1.FileName
        Try
            If sql_caminho <> "OpenFileDialog1" And sql_caminho <> "" Then
                If System.IO.File.Exists(sql_caminho) = True Then
                    System.IO.File.Delete(sql_caminho)
                End If
                'System.IO.File.Copy("|DataDirectory|\Resources\BD-C.I.mdf", sql_caminho)
                DAL.BackUpDB(sql_caminho)
            End If
        Catch ex As Exception
            MsgBox("Erro ao fazer o backup: " & ex.Message, vbOKOnly, "Erro ao fazer Backup!")
        End Try
    End Sub

    Private Sub RestauroDeDadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestauroDeDadosToolStripMenuItem.Click
        If MsgBox("O programa será reiniciado e todos os dados existentes serão sobrescritos, continuar?", vbYesNo, "Aviso!") = vbYes Then
            'DAL.Connection.Close()
            'DAL.Connection.Dispose()
            'Console.RunCommandCom("/F /IM sqlservr.exe", "", True)
            Dim sql_caminho As String
            OpenFileDialog1.Filter = "Base-de-Dados Clínica Informática | *.CIDB"
            OpenFileDialog1.FileName = ""
            OpenFileDialog1.ShowDialog()
            sql_caminho = OpenFileDialog1.FileName
            If sql_caminho <> "OpenFileDialog1" And sql_caminho <> "" Then
                Try
                    DAL.RestoreDB(sql_caminho)
                    Application.Restart()
                Catch ex As Exception
                    MsgBox("Erro ao Restaurar Cópia: " & ex.Message, vbOKOnly, "Erro ao fazer Backup!")
                End Try
            End If
        End If
    End Sub

    
    Private Sub IndexToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IndexToolStripMenuItem.Click
        manual_form.MdiParent = Me
        manual_form.Show()
    End Sub

    Private Sub dispositivosmenu_Click(sender As Object, e As EventArgs)
        If check_artigos = False Then
            Try
                If BLL.Clientes.carregar(True).Rows.Count = 0 Then
                    If MsgBox("Antes de adicionar/alterar um Artigo, tem que adicionar um Cliente, deseja fazê-lo agora?", vbOKCancel, "Erro") = vbOK Then
                        Dim opr_clientes As New OPR_Clientes
                        opr_clientes.MdiParent = Me
                        m_ChildFormNumber += 1
                        opr_clientes.Show()
                    Else
                        MsgBox("Não poderá adicionar um Artigo até adicionar um cliente!")
                    End If
                Else
                    Dim artigosview As New ViewForm
                    check_artigos = True
                    artigosview.Text = "Artigos"
                    artigosview.tabela = "Artigos"
                    artigosview.MdiParent = Me
                    m_ChildFormNumber += 1
                    artigosview.data_table = BLL.Artigos.carregar(True)
                    artigosview.removidos = False
                    artigosview.Show()
                End If
            Catch ex As Exception
                MsgBox("Erro ao executar comando: " & ex.Message)
                Me.Close()
            End Try
        Else
            MsgBox("Já tem a janela dos Artigos aberta!")
        End If
    End Sub

    Private Sub reparacoesmenu_Click(sender As Object, e As EventArgs)
        If check_reparacoes = False Then
            If BLL.Clientes.carregar(True).Rows.Count <> 0 Then
                If BLL.Artigos.carregar(True).Rows.Count <> 0 Then
                    Try
                        Dim repararview As New ViewForm
                        check_reparacoes = True
                        repararview.Text = "Reparações"
                        repararview.tabela = "Reparações"
                        repararview.MdiParent = Me
                        m_ChildFormNumber += 1
                        repararview.data_table = BLL.Reparacoes.carregar(True)
                        repararview.removidos = False
                        repararview.Show()
                    Catch ex As Exception
                        MsgBox("Erro ao executar comando: " & ex.Message)
                        Me.Close()
                    End Try
                Else
                    If MsgBox("Não tem nenhum componente inserido no programa, deseja criar um?", vbYesNo, "Nenhum Componente Inserido") = vbYes Then
                        Dim opr_artigos As New OPR_Artigos
                        opr_artigos.MdiParent = Me
                        m_ChildFormNumber += 1
                        opr_artigos.modo = False
                        opr_artigos.Show()
                    Else
                        MsgBox("Não poderá inserir/visualizar Reparações até inserir um Componente!", vbOKOnly, "Erro")
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
                    MsgBox("Não poderá inserir/visualizar Reparações até inserir um cliente!", vbOKOnly, "Erro")
                End If
            End If
        Else
            MsgBox("Já tem a janela das Reparações abertas!")
        End If
    End Sub

    Private Sub tecnicosmenu_Click(sender As Object, e As EventArgs) Handles tecnicosmenu.Click
        If check_tecnicos = False Then
            Try
                Dim tecnicoview As New ViewForm
                check_tecnicos = True
                tecnicoview.Text = "Técnicos"
                tecnicoview.tabela = "Técnicos"
                tecnicoview.MdiParent = Me
                m_ChildFormNumber += 1
                tecnicoview.data_table = BLL.Tecnicos.carregar(True)
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

    Private Sub UtilizadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtilizadoresToolStripMenuItem.Click
        If MsgBox("Tem a certeza que quer terminar sessão?", vbYesNo, "Terminar Sessão") = vbYes Then
            For Each ChildForm As Form In Me.MdiChildren
                ChildForm.Close()
            Next
            Try
                DAL.CreateConnection()
            Catch
            End Try
            Dim LoginForm1 As New LoginForm
            StatusStrip.Hide()
            MenuStrip.Hide()
            Label1.Hide()
            Label2.Hide()
            companylogo.Hide()
            LoginForm1.MdiParent = Me
            LoginForm1.Show()
            m_ChildFormNumber += 1
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
            Me.MaximizeBox = False
            'terminarsessaobutton.Hide()
        End If
    End Sub
End Class
