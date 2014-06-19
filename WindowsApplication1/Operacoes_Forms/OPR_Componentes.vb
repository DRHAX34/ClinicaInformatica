Public Class OPR_Componentes
    Public dispositivo_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Private Sub OPR_Dispositivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modo = True Then
            numbox.Text = dispositivo_data.Rows.Item(0).Item("NºCliente").ToString()
            marcabox.Text = dispositivo_data.Rows.Item(0).Item("Marca").ToString()
            modelobox.Text = dispositivo_data.Rows.Item(0).Item("Modelo").ToString()
            numseriebox.Text = dispositivo_data.Rows.Item(0).Item("NºSérie").ToString()
            observaçoesbox.Text = dispositivo_data.Rows.Item(0).Item("Observações").ToString()
            RadButton2.Enabled = True
            RadButton3.Text = "Restaurar Dados Originais"
            RadButton5.Enabled = False
        Else
            RadButton2.Enabled = False
            RadButton3.Text = "Limpar Dados"
        End If
        If removidos = True Then
            RadButton2.Text = "Restaurar"
        Else
            RadButton2.Text = "Remover"
        End If
        
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles RadButton3.Click
        If modo = True Then
            numbox.Text = dispositivo_data.Rows.Item(0).Item("NºCliente").ToString()
            marcabox.Text = dispositivo_data.Rows.Item(0).Item("Marca").ToString()
            modelobox.Text = dispositivo_data.Rows.Item(0).Item("Modelo").ToString()
            numseriebox.Text = dispositivo_data.Rows.Item(0).Item("NºSérie").ToString()
            observaçoesbox.Text = dispositivo_data.Rows.Item(0).Item("Observações").ToString()
        Else
            numbox.Text = ""
            marcabox.Text = ""
            modelobox.Text = ""
            numseriebox.Text = ""
            observaçoesbox.Text = ""
        End If
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
        Try
            If removidos = False Then
                BLL.Componentes.apagar(dispositivo_data.Rows.Item(0).Item("NºComponente").ToString(), dispositivo_data.Rows.Item(0).Item("NºCliente").ToString())
                MsgBox("Removido com sucesso!")
                Workspace.componentesAtivosToolStripMenuItem.PerformClick()
                Me.Close()
            Else
                BLL.Componentes.restaurar(dispositivo_data.Rows.Item(0).Item("NºComponente").ToString(), dispositivo_data.Rows.Item(0).Item("NºCliente").ToString())
                MsgBox("Restaurado com sucesso!")
                Workspace.componentesRemovidosToolStripMenuItem.PerformClick()
                Me.Close()
            End If

        Catch ex As Exception
            If removidos = False Then
                MsgBox("Erro ao Remover: " & ex.Message)
            Else
                MsgBox("Erro ao Restaurar:" & ex.Message)
            End If
        End Try
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim check_numcliente As Boolean = True
        Dim check_numserie As Boolean = True
        Dim check_marca As Boolean = True
        Dim check_modelo As Boolean = True
        Dim check_observaçoes As Boolean = True
        For i = 0 To numbox.Text.Count - 1
            If numbox.Text.Chars(i) <> " " Then
                check_numcliente = False
            End If
        Next
        For i = 0 To numseriebox.Text.Count - 1
            If numseriebox.Text.Chars(i) <> " " Then
                check_numserie = False
            End If
        Next
        For i = 0 To marcabox.Text.Count - 1
            If marcabox.Text.Chars(i) <> " " Then
                check_marca = False
            End If
        Next
        For i = 0 To modelobox.Text.Count - 1
            If modelobox.Text.Chars(i) <> " " Then
                check_modelo = False
            End If
        Next
        For i = 0 To observaçoesbox.Text.Count - 1
            If observaçoesbox.Text.Chars(i) <> " " Then
                check_observaçoes = False
            End If
        Next
            Try
            If check_numcliente = False And check_numserie = False And check_marca = False And check_modelo = False And check_observaçoes = False Then
                BLL.Componentes.inserir(numbox.Text, marcabox.Text, modelobox.Text, numseriebox.Text, observaçoesbox.Text)
                MsgBox("Inserido com sucesso")
                Workspace.componentesAtivosToolStripMenuItem.PerformClick()
                Me.Close()
            Else
                MsgBox("Introduza todos os dados!")
            End If
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message)
            End Try
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        If Workspace.check_select = False Then
            Dim select_comp As New Selectform
            select_comp.MdiParent = Workspace
            Workspace.m_ChildFormNumber += 1
            select_comp.tabela = "Clientes"
            select_comp.Show()
            Timer1.Start()
            Workspace.check_select = True
        Else
            MsgBox("Já tem uma janela de Selecionar aberta!")
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        numbox.Text = Workspace.support
        If Workspace.check_select = False Then
            Timer1.Stop()
        End If
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Dim check_numcliente As Boolean = True
        Dim check_numserie As Boolean = True
        Dim check_marca As Boolean = True
        Dim check_modelo As Boolean = True
        Dim check_observaçoes As Boolean = True
        For i = 0 To numbox.Text.Count - 1
            If numbox.Text.Chars(i) <> " " Then
                check_numcliente = False
            End If
        Next
        For i = 0 To numseriebox.Text.Count - 1
            If numseriebox.Text.Chars(i) <> " " Then
                check_numserie = False
            End If
        Next
        For i = 0 To marcabox.Text.Count - 1
            If marcabox.Text.Chars(i) <> " " Then
                check_marca = False
            End If
        Next
        For i = 0 To modelobox.Text.Count - 1
            If modelobox.Text.Chars(i) <> " " Then
                check_modelo = False
            End If
        Next
        For i = 0 To observaçoesbox.Text.Count - 1
            If observaçoesbox.Text.Chars(i) <> " " Then
                check_observaçoes = False
            End If
        Next
        Try
            If check_numcliente = False And check_numserie = False And check_marca = False And check_modelo = False And check_observaçoes = False Then
                BLL.Componentes.alterar(dispositivo_data.Rows.Item(0).Item("NºComponente").ToString(), numbox.Text, marcabox.Text, modelobox.Text, numseriebox.Text, observaçoesbox.Text)
                MsgBox("Alterado com sucesso")
                If removidos = True Then
                    Workspace.componentesRemovidosToolStripMenuItem.PerformClick()
                    Me.Close()
                Else
                    Workspace.componentesAtivosToolStripMenuItem.PerformClick()
                    Me.Close()
                End If
            Else
                MsgBox("Introduza todos os dados!")
            End If
        Catch ex As Exception
            MsgBox("Ocorreu um erro: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        If removidos = True Then
            Workspace.componentesRemovidosToolStripMenuItem.PerformClick()
        Else
            Workspace.componentesAtivosToolStripMenuItem.PerformClick()
        End If
        Me.Close()
    End Sub

End Class