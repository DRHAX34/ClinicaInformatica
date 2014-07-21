Public Class OPR_Artigos
    Public dispositivo_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Public n_cliente As String
    Private Sub OPR_Artigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saveimagebutton As New Bitmap((My.Resources._1405624185_floppy), savebutton.Height, savebutton.Height)
        savebutton.Image = saveimagebutton
        Dim reparaçoesimagebutton As New Bitmap((My.Resources.oie_2417311E0OBPz25), reparaçoesbutton.Height, reparaçoesbutton.Height)
        reparaçoesbutton.Image = reparaçoesimagebutton
        Dim restartimagebutton As New Bitmap((My.Resources._1405624497_MB__reload), restartbutton.Height, restartbutton.Height)
        Dim exitimagebutton As New Bitmap((My.Resources.Sair), exitbutton.Height, exitbutton.Height)
        exitbutton.Image = exitimagebutton
        Dim limparimagebutton As New Bitmap((My.Resources._32x32), restartbutton.Height, restartbutton.Height)
        If modo = True Then
            restartbutton.Image = restartimagebutton
            n_cliente = dispositivo_data.Rows.Item(0).Item("NºCliente").ToString()
            nomeclientelabel.Text = BLL.Clientes.carregar_dados_numcliente(n_cliente, True).Rows(0).Item("Nome").ToString()
            marcabox.Text = dispositivo_data.Rows.Item(0).Item("Marca").ToString()
            modelobox.Text = dispositivo_data.Rows.Item(0).Item("Modelo").ToString()
            numseriebox.Text = dispositivo_data.Rows.Item(0).Item("NºSérie").ToString()
            observaçoesbox.Text = dispositivo_data.Rows.Item(0).Item("Observações").ToString()
        Else
            restartbutton.Image = limparimagebutton
        End If

    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs)
        Try
            If modo = True Then
                n_cliente = dispositivo_data.Rows.Item(0).Item("NºCliente").ToString()
                marcabox.Text = dispositivo_data.Rows.Item(0).Item("Marca").ToString()
                modelobox.Text = dispositivo_data.Rows.Item(0).Item("Modelo").ToString()
                numseriebox.Text = dispositivo_data.Rows.Item(0).Item("NºSérie").ToString()
                observaçoesbox.Text = dispositivo_data.Rows.Item(0).Item("Observações").ToString()
            Else
                n_cliente = ""
                nomeclientelabel.Text = "Não Selecionado!"
                marcabox.Text = ""
                modelobox.Text = ""
                numseriebox.Text = ""
                observaçoesbox.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Erro ao restaurar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs)
        Try
            If removidos = False Then
                BLL.Artigos.apagar(dispositivo_data.Rows.Item(0).Item("NºArtigo").ToString(), dispositivo_data.Rows.Item(0).Item("NºCliente").ToString())
                MsgBox("Removido com sucesso!")
                Workspace.dispositivosmenu.PerformClick()
                Me.Close()
            Else
                BLL.Artigos.restaurar(dispositivo_data.Rows.Item(0).Item("NºArtigo").ToString(), dispositivo_data.Rows.Item(0).Item("NºCliente").ToString())
                MsgBox("Restaurado com sucesso!")
                Workspace.dispositivosmenu.PerformClick()
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

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        If modo = True Then
            Dim check_numcliente As String = ""
            Dim check_marca As String = ""
            Dim check_modelo As String = ""
            Dim check_observaçoes As String = ""
            Dim check_componente As String = tipo_componentebox.Text
            Try
                check_numcliente = n_cliente
                check_numcliente.Trim()
                check_marca = marcabox.Text
                check_marca.Trim()
                check_modelo = modelobox.Text
                check_modelo.Trim()
                check_observaçoes = observaçoesbox.Text
                check_observaçoes.Trim()
                check_componente.Trim()
            Catch
            End Try
            Try
                If Not (check_numcliente = "" And check_marca = "" And check_modelo = "" And check_observaçoes = "") Then
                    BLL.Artigos.alterar(dispositivo_data.Rows.Item(0).Item("NºArtigo").ToString(), n_cliente, marcabox.Text, modelobox.Text, numseriebox.Text, observaçoesbox.Text, tipo_componentebox.Text)
                    MsgBox("Alterado com sucesso")
                    If removidos = True Then
                        Workspace.dispositivosmenu.PerformClick()
                        Me.Close()
                    Else
                        Workspace.dispositivosmenu.PerformClick()
                        Me.Close()
                    End If
                Else
                    MsgBox("Introduza todos os dados!")
                End If
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message)
            End Try
        Else
            Dim check_numcliente As String = ""
            Dim check_marca As String = ""
            Dim check_modelo As String = ""
            Dim check_observaçoes As String = ""
            Dim check_tipo As String = ""
            Try
                check_numcliente = n_cliente
                check_numcliente.Trim()
                check_marca = marcabox.Text
                check_marca.Trim()
                check_modelo = modelobox.Text
                check_modelo.Trim()
                check_observaçoes = observaçoesbox.Text
                check_observaçoes.Trim()
                check_tipo = tipo_componentebox.Text
                check_tipo.Trim()
            Catch
            End Try
            Try
                If Not check_tipo = "" And Not check_numcliente = "" And Not check_marca = "" And Not check_modelo = "" And Not check_observaçoes = "" Then
                    BLL.Artigos.inserir(n_cliente, marcabox.Text, modelobox.Text, numseriebox.Text, observaçoesbox.Text, tipo_componentebox.Text)
                    MsgBox("Inserido com sucesso")
                    If MsgBox("Deseja inserir uma reparação para este Artigo?", vbYesNo, "Novo Artigo") = vbYes Then
                        If BLL.Tecnicos.carregar(True).Rows.Count = 0 Then
                            If Workspace.admin = True Then
                                If MsgBox("Não tem nenhum técnico inserido no programa, deseja inserir algum técnico?", vbYesNo, "Sem técnicos!") = vbYes Then
                                    Dim opr_tecnicos As New OPR_Técnicos
                                    opr_tecnicos.MdiParent = Workspace
                                    opr_tecnicos.modo = False
                                    opr_tecnicos.Show()
                                    Me.Close()
                                Else
                                    MsgBox("Não poderá criar nenhuma reparação sem inserir pelo menos um técnico!", vbOKOnly, "Sem Técnicos!")
                                    Me.Close()
                                End If
                            Else
                                MsgBox("Não existem Técnicos no programa, tem que pedir ao seu Administrador que adicione pelo menos um técnico!", vbOKOnly, "Sem Técnicos!")
                                Me.Close()
                            End If
                        Else
                            Dim opr_reparações As New OPR_Reparações
                            opr_reparações.MdiParent = Workspace
                            opr_reparações.modo = False
                            'opr_reparações. = BLL.Artigos.carregar(True).Rows(BLL.Artigos.carregar(True).Rows.Count - 1).Item("NºArtigo").ToString
                            opr_reparações.Show()
                            Me.Close()
                        End If

                    Else
                        Workspace.dispositivosmenu.PerformClick()
                        Me.Close()
                    End If

                Else
                    MsgBox("Introduza todos os dados!")
                End If
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message)
            End Try
        End If

    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs)
        
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs)
        If removidos = True Then
            Workspace.dispositivosmenu.PerformClick()
        Else
            Workspace.dispositivosmenu.PerformClick()
        End If
        Me.Close()
    End Sub

    Private Sub savebutton_Click(sender As Object, e As EventArgs) Handles savebutton.Click

    End Sub
End Class