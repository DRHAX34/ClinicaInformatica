Public Class OPR_Artigos
    Public dispositivo_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Public n_cliente As String
    Public lock As Boolean = False
    Private Sub OPR_Artigos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.SelectedIndex = 0
        Dim saveimagebutton As New Bitmap((My.Resources._1405624185_floppy), savebutton.Height - 1, savebutton.Height - 1)
        savebutton.Image = saveimagebutton
        Dim reparaçoesimagebutton As New Bitmap((My.Resources.oie_2417311E0OBPz25), reparaçoesbutton.Height - 1, reparaçoesbutton.Height - 1)
        reparaçoesbutton.Image = reparaçoesimagebutton
        Dim restartimagebutton As New Bitmap((My.Resources._1405624497_MB__reload), restartbutton.Height - 1, restartbutton.Height - 1)
        Dim exitimagebutton As New Bitmap((My.Resources.Sair), exitbutton.Height - 1, exitbutton.Height - 1)
        exitbutton.Image = exitimagebutton
        Dim limparimagebutton As New Bitmap((My.Resources._32x32), restartbutton.Height - 1, restartbutton.Height - 1)
        Try
            If modo = True Then
                restartbutton.Image = restartimagebutton
                n_cliente = dispositivo_data.Rows.Item(0).Item("NºCliente").ToString()
                marcabox.Text = dispositivo_data.Rows.Item(0).Item("Marca").ToString()
                modelobox.Text = dispositivo_data.Rows.Item(0).Item("Modelo").ToString()
                numseriebox.Text = dispositivo_data.Rows.Item(0).Item("NºSérie").ToString()
                observaçoesbox.Text = dispositivo_data.Rows.Item(0).Item("Observações").ToString()
                lockbutton.PerformClick()
                reparaçoesbutton.Enabled = True
            Else
                lockbutton.Hide()
                restartbutton.Image = limparimagebutton
                reparaçoesbutton.Enabled = False
            End If
            nomeclientelabel.Text = BLL.Clientes.carregar_dados_numcliente(n_cliente, True).Rows(0).Item("Nome").ToString()
        Catch ex As Exception
            MsgBox("Erro ao carregar: " & ex.Message, vbOKOnly, "Erro!")
        End Try
    End Sub

    Private Sub RadButton3_Click(sender As Object, e As EventArgs) Handles restartbutton.Click
        Try
            If modo = True Then
                marcabox.Text = dispositivo_data.Rows.Item(0).Item("Marca").ToString()
                modelobox.Text = dispositivo_data.Rows.Item(0).Item("Modelo").ToString()
                numseriebox.Text = dispositivo_data.Rows.Item(0).Item("NºSérie").ToString()
                observaçoesbox.Text = dispositivo_data.Rows.Item(0).Item("Observações").ToString()
            Else
                marcabox.Text = ""
                modelobox.Text = ""
                numseriebox.Text = ""
                observaçoesbox.Text = ""
            End If
        Catch ex As Exception
            MsgBox("Erro ao restaurar os dados: " & ex.Message)
        End Try
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        If modo = True Then
            Dim check_numcliente As String = ""
            Dim check_marca As String = ""
            Dim check_modelo As String = ""
            Dim check_observaçoes As String = ""
            Try
                check_numcliente = n_cliente
                check_numcliente.Trim()
                check_marca = marcabox.Text
                check_marca.Trim()
                check_modelo = modelobox.Text
                check_modelo.Trim()
                check_observaçoes = observaçoesbox.Text
                check_observaçoes.Trim()
            Catch
            End Try
            Try
                If Not (check_numcliente = "" And check_marca = "" And check_modelo = "" And check_observaçoes = "") Then
                    BLL.Artigos.alterar(dispositivo_data.Rows.Item(0).Item("NºArtigo").ToString(), n_cliente, marcabox.Text, modelobox.Text, numseriebox.Text, observaçoesbox.Text, ComboBox1.SelectedItem)
                    Me.Close()
                Else
                    MsgBox("Introduza todos os dados!")
                End If
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message)
            End Try
        Else
            Dim check_marca As String = ""
            Dim check_modelo As String = ""
            Dim check_observaçoes As String = ""
            Try
                check_marca = marcabox.Text
                check_marca.Trim()
                check_modelo = modelobox.Text
                check_modelo.Trim()
                check_observaçoes = observaçoesbox.Text
                check_observaçoes.Trim()
            Catch
            End Try
            Try
                If Not check_marca = "" And Not check_modelo = "" And Not check_observaçoes = "" Then
                    BLL.Artigos.inserir(n_cliente, marcabox.Text, modelobox.Text, numseriebox.Text, observaçoesbox.Text, ComboBox1.Text)
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
                            opr_reparações.cliente = n_cliente
                            opr_reparações.artigos = BLL.Artigos.carregar(True).Rows(BLL.Artigos.carregar(True).Rows.Count - 1).Item("NºArtigo").ToString()
                            'opr_reparações. = BLL.Artigos.carregar(True).Rows(BLL.Artigos.carregar(True).Rows.Count - 1).Item("NºArtigo").ToString
                            opr_reparações.Show()
                            Me.Close()
                        End If

                    Else
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

    Private Sub reparaçoesbutton_Click(sender As Object, e As EventArgs) Handles reparaçoesbutton.Click
        Dim repararview As New ViewForm
        Workspace.check_reparacoes = True
        repararview.Text = "Reparações"
        repararview.tabela = "Reparações"
        repararview.MdiParent = Workspace
        repararview.n_cliente = n_cliente
        Workspace.m_ChildFormNumber += 1
        repararview.artigo = dispositivo_data.Rows.Item(0).Item("NºArtigo").ToString()
        repararview.data_table = BLL.Reparacoes.carregar_dados_numartigo(dispositivo_data.Rows.Item(0).Item("NºArtigo").ToString(), True)
        repararview.removidos = False
        repararview.Show()
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub

    Private Sub lockbutton_Click(sender As Object, e As EventArgs) Handles lockbutton.Click
        Dim imageunlockbutton As New Bitmap(My.Resources._1406134201_MB__UNLOCK, lockbutton.Height - 5, lockbutton.Width - 5)
        Dim imagelockbutton As New Bitmap(My.Resources._1406134201_MB__LOCK, lockbutton.Height - 5, lockbutton.Width - 5)
        If lock = False Then
            lock = True
            lockbutton.Image = imageunlockbutton
            marcabox.Enabled = False
            modelobox.Enabled = False
            numseriebox.Enabled = False
            observaçoesbox.Enabled = False
            ComboBox1.Enabled = False
            savebutton.Enabled = False
        Else
            lock = False
            lockbutton.Image = imagelockbutton
            marcabox.Enabled = True
            modelobox.Enabled = True
            numseriebox.Enabled = True
            observaçoesbox.Enabled = True
            ComboBox1.Enabled = True
            savebutton.Enabled = True
        End If
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class