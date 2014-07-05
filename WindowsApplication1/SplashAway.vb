﻿Imports System.IO
Imports System.IO.Compression
Public NotInheritable Class SplashAway

    'TODO: Este formulário pode ser facilmente configurado como a tela inicial da aplicação através da edição da aba "Aplicação"
    '  no Designer de Projeto ("Propriedades" dentro do menu "Projetos").

    Private Sub load_form()
        ProgressBar1.Value = 5
        Workspace.Label1.Hide()
        ProgressBar1.Value = 10
        Workspace.Label2.Hide()
        ProgressBar1.Value = 15
        Workspace.check_bd = False
        ProgressBar1.Value = 20
        If Not System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\BD\BD-C.I.mdf") Then
            unzip()
            ProgressBar1.Value = 25
            Workspace.check_bd = True
        Else
            Workspace.check_bd = True
            ProgressBar1.Value = 25
        End If
        ProgressBar1.Value = 30
        If Workspace.check_bd = True Then
            Try
                ProgressBar1.Value = 40
                Workspace.Text = "Gestão Clínica Informática "
                ProgressBar1.Value = 45
                Workspace.MenuStrip.Hide()
                ProgressBar1.Value = 50
                Workspace.BackgroundImageLayout = ImageLayout.Stretch
                ProgressBar1.Value = 55
                Workspace.StatusStrip.Hide()
                ProgressBar1.Value = 65
                'terminarsessaobutton.Hide()
                Dim estado As Integer = DAL.CreateConnection()
                ProgressBar1.Value = 70
                LoginForm.MdiParent = Workspace
                ProgressBar1.Value = 75
                Workspace.m_ChildFormNumber += 1
                ProgressBar1.Value = 80
                Workspace.FormBorderStyle = 1
                ProgressBar1.Value = 85
                If System.IO.File.Exists(Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Config\config.cfg") Then
                    Workspace.varias_empresas = File.ReadAllText((Environment.GetEnvironmentVariable("APPDATA") & "\Clínica Informática\Config\config.cfg"))
                End If
                ProgressBar1.Value = 90
                ProgressBar1.Value = 93
                Workspace.cache_empresas = BLL.Login.Carregar_empresas
                ProgressBar1.Value = 98
                Workspace.cache_users = BLL.Admin_only.Login.carregar_users
                ProgressBar1.Value = 100
                Workspace.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro no programa: " & ex.Message)
            End Try
        Else
            Workspace.Show()
            Me.Close()
        End If
    End Sub


    Private Sub SplashAway_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        versaolabel.Text = "Versão: " & Application.ProductVersion
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        load_form()
    End Sub
End Class
