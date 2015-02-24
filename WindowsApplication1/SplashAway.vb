Imports System.IO
Imports System.IO.Compression
Public NotInheritable Class SplashAway
    Public check As Boolean
    'TODO: Este formulário pode ser facilmente configurado como a tela inicial da aplicação através da edição da aba "Aplicação"
    '  no Designer de Projeto ("Propriedades" dentro do menu "Projetos").

    Private Sub load_form()
        Me.Refresh()
        ProgressBar1.Value = 5
        ProgressBar1.Refresh()
        Workspace.Label1.Hide()
        ProgressBar1.Value = 10
        ProgressBar1.Refresh()
        ProgressBar1.Value = 15
        ProgressBar1.Refresh()
        Workspace.check_bd = False
        ProgressBar1.Value = 20
        ProgressBar1.Refresh()
        'If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\BD\BD-C.I.mdf") Then
        '    unzip()
        '    ProgressBar1.Value = 25
        '    Workspace.check_bd = True
        'Else
        If Not System.IO.Directory.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Manual_instr") Then
            System.IO.Directory.CreateDirectory(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Manual_instr")
        End If
        If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Manual_instr\manual.pdf") = True Then
            System.IO.File.WriteAllBytes(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Manual_instr\manual.pdf", My.Resources.Manual_de_Instruções)
        End If
        Try
            System.IO.File.Delete(".\Resources\BD-C.I_log.ldf")
        Catch
        End Try
        Workspace.check_bd = True
        ProgressBar1.Value = 25
        ProgressBar1.Refresh()
        'End If
        ProgressBar1.Value = 30
        ProgressBar1.Refresh()
        If Workspace.check_bd = True Then
            Try
                ProgressBar1.Value = 40
                ProgressBar1.Refresh()
                Workspace.Text = "Gestão Clínica Informática "
                ProgressBar1.Value = 45
                ProgressBar1.Refresh()
                Workspace.MenuStrip.Hide()
                ProgressBar1.Value = 50
                ProgressBar1.Refresh()
                Workspace.BackgroundImageLayout = ImageLayout.Stretch
                ProgressBar1.Value = 55
                ProgressBar1.Refresh()
                Workspace.StatusStrip.Hide()
                ProgressBar1.Value = 65
                ProgressBar1.Refresh()
                'terminarsessaobutton.Hide()
                ProgressBar1.Value = 70
                ProgressBar1.Refresh()
                LoginForm.MdiParent = Workspace
                ProgressBar1.Value = 75
                ProgressBar1.Refresh()
                Workspace.m_ChildFormNumber += 1
                ProgressBar1.Value = 80
                ProgressBar1.Refresh()
                Workspace.FormBorderStyle = 1
                ProgressBar1.Value = 85
                ProgressBar1.Refresh()
                If System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Config\config.cfg") Then
                    Workspace.varias_empresas = File.ReadAllText((Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Config\config.cfg"))
                End If
                ProgressBar1.Value = 90
                ProgressBar1.Refresh()
                ProgressBar1.Value = 93
                ProgressBar1.Refresh()
                'Workspace.
                ProgressBar1.Value = 98
                ProgressBar1.Refresh()
                'Workspace.
                ProgressBar1.Value = 100
                ProgressBar1.Refresh()
                Timer1.Stop()
            Catch ex As Exception
                Timer1.Stop()
                If check = False Then
                    check = True
                    MsgBox("Erro no programa: " & ex.Message, vbOKOnly, "Erro!")
                End If
                Me.Close()
            Finally
                Threading.Thread.Sleep(1000)
                Workspace.Show()
                Me.Close()
            End Try
        Else
            Workspace.Show()
            Me.Close()
        End If
    End Sub


    Private Sub SplashAway_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'versaolabel.Text = "Versão: " & Application.ProductVersion
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        load_form()
        Timer1.Stop()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub versaolabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class
