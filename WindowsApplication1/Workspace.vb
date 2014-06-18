Imports System.Windows.Forms


Public Class Workspace
    Public config2 As New Passo2
    Public config3 As New Passo3
    Public config3_5 As New Passo3emeio
    Public config4 As New Passo4
    Public modo As Integer
    Public Aluno, admin, admin_geral As Boolean
    Public companyname1 As String
    Public check_clientes, check_componentes, check_reparacoes, check_tecnicos, check_utilizadores, check_empresas As Boolean
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
        terminarsessaobutton.Location = New Point((Me.Width - (1035 - 908)), 12)
    End Sub
    Private Sub onclose(sender As Object, e As EventArgs) Handles Me.FormClosing
        DAL.CloseConnection()
        DAL.TerminateConnection()
    End Sub
    Private Sub Workspace_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestão Clínica Informática " & Application.ProductVersion
        MenuStrip.Hide()
        Me.BackgroundImageLayout = ImageLayout.Stretch
        StatusStrip.Hide()
        terminarsessaobutton.Hide()
        Dim estado As Integer = DAL.CreateConnection()
        LoginForm.MdiParent = Me
        m_ChildFormNumber += 1
        Me.FormBorderStyle = 1
        If BLL.Login.Carregar_empresas.Count = 0 Then
            Me.WindowState = FormWindowState.Normal
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
        Else
            Me.WindowState = FormWindowState.Maximized
            LoginForm.Show()
        End If
        Me.DoubleBuffered = True

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

    Private Sub AtivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtivosToolStripMenuItem.Click
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

    Private Sub RemovidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemovidosToolStripMenuItem.Click
        If check_clientes = False Then
            Dim clientesview As New ViewForm
            check_clientes = True
            clientesview.Text = "Clientes"
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

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles terminarsessaobutton.Click
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
        Dim LoginForm1 As New LoginForm
        StatusStrip.Hide()
        MenuStrip.Hide()
        LoginForm1.MdiParent = Me
        LoginForm1.Show()
        m_ChildFormNumber += 1
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        terminarsessaobutton.Hide()
    End Sub
End Class
