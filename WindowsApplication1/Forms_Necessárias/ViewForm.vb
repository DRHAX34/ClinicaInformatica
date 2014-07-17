Public Class ViewForm
    Public data_table As DataTable
    Public tabela As String
    Public removidos As Boolean
    Dim timer As Integer
    'Protected Overrides Sub WndProc(ByRef m As Message)
    '    If (m.Msg = &H112) AndAlso (m.WParam.ToInt32() = &HF010) Then
    '        Return
    '    End If
    '    If (m.Msg = &HA1) AndAlso (m.WParam.ToInt32() = &H2) Then
    '        Return
    '    End If
    '    MyBase.WndProc(m)
    'End Sub
    Private Sub resizing(sender As Object, e As EventArgs) Handles Me.Resize
        showdata.Width = Me.Width - 50
        showdata.Height = Me.Height - 210
        othersbutton.Location = New Point((Me.Width - (750 - 494)), (Me.Height - (506 - 417)))
        exitbutton.Location = New Point((Me.Width - (750 - 620)), (Me.Height - (506 - 417)))
        delbutton.Location = New Point((delbutton.Location.X), (Me.Height - (506 - 417)))
        updatebutton.Location = New Point((updatebutton.Location.X), (Me.Height - (506 - 417)))
        findbutton.Location = New Point((Me.Width - (750 - 494)), (Me.Height - (506 - 364)))
        showbutton.Location = New Point((Me.Width - (750 - 620)), (Me.Height - (506 - 364)))
        newbutton.Location = New Point((newbutton.Location.X), (Me.Height - (506 - 364)))
        editbutton.Location = New Point((editbutton.Location.X), (Me.Height - (506 - 364)))
        Label1.Location = New Point(((Me.Width / 2) - 53), (Me.Height - (506 - 321)))
        GroupBox1.Location = New Point((Me.Width / 2 - 114), (Me.Height - (506 - 355)))
    End Sub
    Private Sub onclose(sender As Object, e As EventArgs) Handles Me.FormClosing
        Select Case tabela
            Case "Clientes"
                Workspace.check_clientes = False
            Case "Artigos"
                Workspace.check_artigos = False
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
        Dim newimagebutton As New Bitmap((My.Resources._1405624626_Add), newbutton.Height, newbutton.Height)
        newbutton.Image = newimagebutton
        othersbutton.Enabled = True
        'Se não metermos .Enabled=false ele reverte para o default, que é true
        'Código de Teste:
        Select Case tabela
            Case "Clientes"
                othersbutton.Enabled = False
                RadioButton1.Text = "Nome"
                RadioButton2.Text = "NIF"
            Case "Artigos"
                othersbutton.Enabled = False
                RadioButton1.Text = "NºArtigos"
                RadioButton2.Text = "NºCliente"
            Case "Empresas"
                othersbutton.Enabled = False
                RadioButton1.Text = "Nome"
                RadioButton2.Text = "NIF"
            Case "Reparações"
                'othersbutton.Enabled = True
                RadioButton1.Text = "NºReparação"
                RadioButton2.Text = "NºArtigo"
            Case "Técnicos"
                othersbutton.Enabled = True
                RadioButton1.Text = "NºTécnico"
                RadioButton2.Text = "Nome"
            Case "Utilizadores"
                othersbutton.Enabled = False
                RadioButton1.Text = "NºUtilizador"
                RadioButton2.Text = "NºTécnico"
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
        Label1.Hide()
        GroupBox1.Hide()
        If Workspace.admin = True Then
            CheckBox1.Show()
        Else
            CheckBox1.Hide()
        End If
    End Sub

    Private Sub newbutton_Click(sender As Object, e As EventArgs) Handles newbutton.Click
        GroupBox1.Hide()
        Select Case tabela
            Case "Clientes"
                Dim opr_clientes As New OPR_Clientes
                opr_clientes.modo = False
                opr_clientes.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                opr_clientes.Show()
            Case "Artigos"
                Dim opr_artigos As New OPR_Artigos
                OPR_Artigos.modo = False
                OPR_Artigos.MdiParent = Workspace
                Workspace.m_ChildFormNumber += 1
                OPR_Artigos.Show()
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
        Try
            Dim string_data As String
            string_data = showdata.Rows(showdata.CurrentCell.RowIndex).Cells(0).Value.ToString()
            Try
                Select Case tabela
                    Case "Clientes"
                        Dim opr_clientes As New OPR_Clientes
                        opr_clientes.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_clientes.modo = True
                        If removidos = True Then
                            If Workspace.Aluno = True Then
                                opr_clientes.cliente_data = BLL.Clientes.carregar_dados_numcliente_desativados_alunos(string_data)
                                opr_clientes.removidos = True
                                opr_clientes.Show()
                            Else
                                opr_clientes.cliente_data = BLL.Clientes.carregar_dados_numcliente_desativados(string_data)
                                opr_clientes.removidos = True
                                opr_clientes.Show()
                            End If
                        Else
                            If Workspace.Aluno = True Then
                                opr_clientes.cliente_data = BLL.Clientes.carregar_dados_numcliente_alunos(string_data)
                                opr_clientes.removidos = False
                                opr_clientes.Show()
                            Else
                                opr_clientes.cliente_data = BLL.Clientes.carregar_dados_numcliente(string_data)
                                opr_clientes.removidos = False
                                opr_clientes.Show()
                            End If
                        End If
                    Case "Artigos"
                        Dim opr_artigos As New OPR_Artigos
                        opr_artigos.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_artigos.modo = True
                        If removidos = True Then
                            opr_artigos.dispositivo_data = BLL.Artigos.carregar_dados_numartigo_desativo(string_data)
                            opr_artigos.removidos = True
                            opr_artigos.Show()
                        Else
                            opr_artigos.dispositivo_data = BLL.Artigos.carregar_dados_numartigo(string_data)
                            opr_artigos.removidos = False
                            opr_artigos.Show()
                        End If
                    Case "Reparações"
                        Dim opr_reparacoes As New OPR_Reparações
                        opr_reparacoes.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_reparacoes.modo = True
                        Workspace.hardware_support = BLL.Hardware.return_hardware(string_data)
                        Workspace.software_support = BLL.Software.return_software(string_data)
                        Workspace.tecnicos_support = BLL.Participacoes.procurar_part(string_data)
                        If removidos = True Then
                            opr_reparacoes.reparaçao_data = BLL.Reparacoes.carregar_dados_numreparação_desativo(string_data)
                            opr_reparacoes.removidos = True
                            opr_reparacoes.Show()
                        Else
                            opr_reparacoes.reparaçao_data = BLL.Reparacoes.carregar_dados_numreparação(string_data)
                            opr_reparacoes.removidos = False
                            opr_reparacoes.Show()
                        End If
                    Case "Técnicos"
                        Dim opr_tecnicos As New OPR_Técnicos
                        opr_tecnicos.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_tecnicos.modo = True
                        If Workspace.Aluno = True Then
                            If removidos = True Then
                                opr_tecnicos.tecnico_data = BLL.Tecnicos.Alunos.carregar_dados_ntecnico_desativados(string_data)
                                opr_tecnicos.removidos = True
                                opr_tecnicos.Show()
                            Else
                                opr_tecnicos.tecnico_data = BLL.Tecnicos.Alunos.carregar_dados_ntecnico_ativados(string_data)
                                opr_tecnicos.removidos = False
                                opr_tecnicos.Show()
                            End If
                        Else
                            If removidos = True Then
                                opr_tecnicos.tecnico_data = BLL.Tecnicos.carregar_dados_ntecnico_desativados(string_data)
                                opr_tecnicos.removidos = True
                                opr_tecnicos.Show()
                            Else
                                opr_tecnicos.tecnico_data = BLL.Tecnicos.carregar_dados_ntecnico_ativados(string_data)
                                opr_tecnicos.removidos = False
                                opr_tecnicos.Show()
                            End If
                        End If
                    Case "Empresas"
                        Dim opr_empresas As New OPR_Empresas
                        opr_empresas.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_empresas.modo = True
                        If removidos = True Then
                            opr_empresas.empresa_data = BLL.Admin_only.Empresas.carregar_dados_numempresa_desativados(string_data)
                            opr_empresas.removidos = True
                            opr_empresas.Show()
                        Else
                            opr_empresas.empresa_data = BLL.Admin_only.Empresas.carregar_dados_numempresa(string_data)
                            opr_empresas.removidos = True
                            opr_empresas.Show()
                        End If

                End Select
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao Editar: " & ex.Message)
            End Try
        Catch
            MsgBox("Selecione algo na tabela primeiro!")
        End Try
    End Sub


    Private Sub delbutton_Click(sender As Object, e As EventArgs) Handles delbutton.Click
        GroupBox1.Hide()
        Try
            Dim string_data As String
            string_data = showdata.Rows(showdata.CurrentCell.RowIndex).Cells(0).Value.ToString()
            Try
                Select Case tabela
                    Case "Clientes"
                        If removidos = True Then
                            BLL.Clientes.reativar_cliente(string_data)
                            MsgBox("Restaurado com sucesso!")
                            If Workspace.Aluno = True Then
                                showdata.DataSource = BLL.Clientes.carregar_eliminados_alunos()
                            Else
                                showdata.DataSource = BLL.Clientes.carregar_eliminados()
                            End If
                        Else
                            BLL.Clientes.apagar(string_data)
                            MsgBox("Eliminado com sucesso!")
                            If Workspace.Aluno = True Then
                                showdata.DataSource = BLL.Clientes.carregar_alunos()
                            Else
                                showdata.DataSource = BLL.Clientes.carregar()
                            End If
                        End If
                    Case "Artigos"
                        If removidos = True Then
                            BLL.Artigos.restaurar(string_data, showdata.Rows(showdata.CurrentCell.RowIndex).Cells(1).Value.ToString())
                            MsgBox("Restaurado com sucesso!")
                            showdata.DataSource = BLL.Artigos.carregar_desativos()
                        Else
                            BLL.Artigos.apagar(string_data, showdata.Rows(showdata.CurrentCell.RowIndex).Cells(1).Value.ToString())
                            MsgBox("Removido com sucesso!")
                            showdata.DataSource = BLL.Artigos.carregar()
                        End If
                    Case "Empresas"
                        If removidos = True Then
                            BLL.Admin_only.Empresas.restaurar(string_data, 0)
                            MsgBox("Restaurado com sucesso!")
                            showdata.DataSource = BLL.Admin_only.Empresas.carregar_eliminados
                        Else
                            Try
                                Dim result As Integer
                                result = MsgBox("Deseja eliminar permanentemente a empresa?", vbYesNoCancel, "Eliminar")
                                If result = vbYes Then
                                    BLL.Admin_only.eliminar_empresa(string_data)
                                    MsgBox("Eliminada com sucesso!")
                                    Workspace.EmpresasToolStripMenuItem.PerformClick()
                                    Me.Close()
                                ElseIf result = vbNo Then
                                    If MsgBox("Deseja marcar a empresa como inativa?", vbYesNoCancel) = vbYes Then
                                        BLL.Admin_only.Empresas.apagar(string_data, 0)
                                        MsgBox("Eliminada com sucesso!")
                                        Workspace.EmpresasToolStripMenuItem.PerformClick()
                                        Me.Close()
                                    Else
                                        MsgBox("A empresa não foi removida.", MsgBoxStyle.Exclamation, "Erro, nenhuma opção selecionada")
                                    End If
                                Else
                                    MsgBox("A empresa não foi removida.", MsgBoxStyle.Exclamation, "Cancelado")
                                End If
                            Catch ex As Exception
                                MsgBox("Ocorreu um erro: " & ex.Message)
                            End Try
                        End If
                    Case "Reparações"
                        If removidos = True Then
                            BLL.Reparacoes.restaurar(string_data, 1)
                            MsgBox("Restaurado com sucesso!")
                            showdata.DataSource = BLL.Reparacoes.carregar_desativos()
                        Else
                            BLL.Reparacoes.apagar(string_data, 1)
                            MsgBox("Removido com sucesso!")
                            showdata.DataSource = BLL.Reparacoes.carregar()
                        End If
                    Case "Técnicos"
                        If removidos = True Then
                            BLL.Tecnicos.restaurar(string_data)
                            BLL.Admin_only.Login.restore_login(string_data)
                            MsgBox("Restaurado com sucesso!")
                            showdata.DataSource = BLL.Tecnicos.carregar_eliminados
                        Else
                            BLL.Tecnicos.apagar(string_data)
                            BLL.Admin_only.Login.remove_login(string_data)
                            MsgBox("Removido com sucesso!")
                            showdata.DataSource = BLL.Tecnicos.carregar()
                        End If
                End Select
            Catch ex As Exception
                MsgBox("Ocorreu um erro: " & ex.Message)
            End Try
        Catch
            MsgBox("Selecione algo na tabela primeiro!")
        End Try

    End Sub

    Private Sub updatebutton_Click(sender As Object, e As EventArgs) Handles updatebutton.Click
        GroupBox1.Hide()
        Try
            Select Case tabela
                Case "Clientes"
                    If removidos = True Then
                        If Workspace.Aluno = True Then
                            showdata.DataSource = BLL.Clientes.carregar_eliminados_alunos()
                        Else
                            showdata.DataSource = BLL.Clientes.carregar_eliminados()
                        End If
                    Else
                        If Workspace.Aluno = True Then
                            showdata.DataSource = BLL.Clientes.carregar_alunos()
                        Else
                            showdata.DataSource = BLL.Clientes.carregar()
                        End If
                    End If
                Case "Artigos"
                    If removidos = True Then
                        showdata.DataSource = BLL.Artigos.carregar_desativos()
                    Else
                        showdata.DataSource = BLL.Artigos.carregar()
                    End If
                Case "Empresas"
                    If removidos = True Then
                        showdata.DataSource = BLL.Admin_only.Empresas.carregar_eliminados
                    Else
                        showdata.DataSource = BLL.Admin_only.Empresas.carregar()
                    End If
                Case "Reparações"
                    If removidos = True Then
                        showdata.DataSource = BLL.Reparacoes.carregar_desativos()
                    Else
                        showdata.DataSource = BLL.Reparacoes.carregar()
                    End If
                Case "Técnicos"
                    If removidos = True Then
                        showdata.DataSource = BLL.Tecnicos.carregar_eliminados
                    Else
                        showdata.DataSource = BLL.Tecnicos.carregar()
                    End If
                
            End Select
            Timer1.Start()
            Label1.Show()
        Catch ex As Exception
            MsgBox("Erro ao atualizar: " & ex.Message)
        End Try
    End Sub

    Private Sub findbutton_Click(sender As Object, e As EventArgs) Handles findbutton.Click
        GroupBox1.Show()
        RadioButton1.Checked = True
    End Sub

    Private Sub showbutton_Click(sender As Object, e As EventArgs) Handles showbutton.Click
        GroupBox1.Hide()
        Try
            Dim string_data As String
            string_data = showdata.Rows(showdata.CurrentCell.RowIndex).Cells(0).Value.ToString()
            Try
                Select Case tabela
                    Case "Clientes"
                        Dim opr_clientes As New OPR_Clientes
                        opr_clientes.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_clientes.modo = True
                        If removidos = True Then
                            If Workspace.Aluno = True Then
                                opr_clientes.cliente_data = BLL.Clientes.carregar_dados_numcliente_desativados_alunos(string_data)
                                opr_clientes.removidos = True
                                opr_clientes.Show()
                            Else
                                opr_clientes.cliente_data = BLL.Clientes.carregar_dados_numcliente_desativados(string_data)
                                opr_clientes.removidos = True
                                opr_clientes.Show()
                            End If
                        Else
                            If Workspace.Aluno = True Then
                                opr_clientes.cliente_data = BLL.Clientes.carregar_dados_numcliente_alunos(string_data)
                                opr_clientes.removidos = False
                                opr_clientes.Show()
                            Else
                                opr_clientes.cliente_data = BLL.Clientes.carregar_dados_numcliente(string_data)
                                opr_clientes.removidos = False
                                opr_clientes.Show()
                            End If
                        End If
                        opr_clientes.editarbutton.Enabled = False
                        opr_clientes.restorebutton.Enabled = False
                        opr_clientes.nomebox.ReadOnly = True
                        opr_clientes.moradabox.ReadOnly = True
                        opr_clientes.codpostalbox.ReadOnly = True
                        opr_clientes.localidadebox.ReadOnly = True
                        opr_clientes.cmovelbox.ReadOnly = True
                        opr_clientes.cfixobox.ReadOnly = True
                        opr_clientes.nifbox.ReadOnly = True
                        opr_clientes.emailbox.ReadOnly = True
                        opr_clientes.numalunobox.ReadOnly = True
                        opr_clientes.turmabox.ReadOnly = True
                        opr_clientes.RadioButton1.Enabled = False
                        opr_clientes.RadioButton2.Enabled = False
                    Case "Artigos"
                        Dim opr_artigos As New OPR_Artigos
                        opr_artigos.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_artigos.modo = True
                        If removidos = True Then
                            opr_artigos.dispositivo_data = BLL.Artigos.carregar_dados_numartigo_desativo(string_data)
                            opr_artigos.removidos = True
                            opr_artigos.Show()
                        Else
                            opr_artigos.dispositivo_data = BLL.Artigos.carregar_dados_numartigo(string_data)
                            opr_artigos.removidos = False
                            opr_artigos.Show()
                        End If
                        opr_artigos.numseriebox.ReadOnly = True
                        opr_artigos.observaçoesbox.ReadOnly = True
                        opr_artigos.marcabox.ReadOnly = True
                        opr_artigos.modelobox.ReadOnly = True
                        opr_artigos.RadButton6.Enabled = False
                    Case "Reparações"
                        Dim opr_reparacoes As New OPR_Reparações
                        opr_reparacoes.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_reparacoes.modo = True
                        Workspace.hardware_support = BLL.Hardware.return_hardware(string_data)
                        Workspace.software_support = BLL.Software.return_software(string_data)
                        Workspace.tecnicos_support = BLL.Participacoes.procurar_part(string_data)
                        If removidos = True Then
                            opr_reparacoes.reparaçao_data = BLL.Reparacoes.carregar_dados_numreparação_desativo(string_data)
                            opr_reparacoes.removidos = True
                            opr_reparacoes.Show()
                        Else
                            opr_reparacoes.reparaçao_data = BLL.Reparacoes.carregar_dados_numreparação(string_data)
                            opr_reparacoes.removidos = False
                            opr_reparacoes.Show()
                        End If
                        opr_reparacoes.dateinicio.Hide()
                        opr_reparacoes.datefim.Hide()
                        opr_reparacoes.dateinicio.Value = opr_reparacoes.reparaçao_data.Rows(0).Item("DIRepar")
                        If opr_reparacoes.reparaçao_data.Rows(0).Item("DFRepar") <> New Date Then
                            opr_reparacoes.datefim.Text = opr_reparacoes.reparaçao_data.Rows(0).Item("DFRepar")
                        End If
                        opr_reparacoes.numcomponentebox.ReadOnly = True
                        opr_reparacoes.RadButton7.Enabled = False
                        opr_reparacoes.preçobox.ReadOnly = True
                        opr_reparacoes.CheckBox1.Enabled = False
                        opr_reparacoes.CheckBox2.Enabled = False
                        opr_reparacoes.insert_tecnicos.Text = "Ver Técnicos Participantes"
                        opr_reparacoes.insert_tecnicos.TextWrap = True
                        opr_reparacoes.descriçaobox.ReadOnly = True
                        opr_reparacoes.RadButton5.Enabled = False
                        opr_reparacoes.RadButton1.Enabled = False
                        opr_reparacoes.RadButton3.Enabled = False
                        opr_reparacoes.read_only = True
                    Case "Técnicos"
                        Dim opr_tecnicos As New OPR_Técnicos
                        opr_tecnicos.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_tecnicos.modo = True
                        If removidos = True Then
                            opr_tecnicos.tecnico_data = BLL.Tecnicos.carregar_dados_ntecnico_desativados(string_data)
                            opr_tecnicos.removidos = True
                            opr_tecnicos.Show()
                        Else
                            opr_tecnicos.tecnico_data = BLL.Tecnicos.carregar_dados_ntecnico_ativados(string_data)
                            opr_tecnicos.removidos = False
                            opr_tecnicos.Show()
                        End If
                    Case "Empresas"
                        Dim opr_empresas As New OPR_Empresas
                        opr_empresas.MdiParent = Workspace
                        Workspace.m_ChildFormNumber += 1
                        opr_empresas.modo = True
                        If removidos = True Then
                            opr_empresas.empresa_data = BLL.Admin_only.Empresas.carregar_dados_numempresa_desativados(string_data)
                            opr_empresas.removidos = True
                            opr_empresas.Show()
                        Else
                            opr_empresas.empresa_data = BLL.Admin_only.Empresas.carregar_dados_numempresa(string_data)
                            opr_empresas.removidos = True
                            opr_empresas.Show()
                        End If
                    
                End Select
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao Editar: " & ex.Message)
            End Try
        Catch
            MsgBox("Selecione algo na tabela primeiro!")
        End Try
    End Sub

    Private Sub othersbutton_Click(sender As Object, e As EventArgs) Handles othersbutton.Click
        GroupBox1.Hide()
        Try
            Dim string_data As String
            string_data = showdata.Rows(showdata.CurrentCell.RowIndex).Cells(0).Value.ToString()
                If tabela = "Reparações" Then
                    Dim otheroptions As New otheroptions
                    otheroptions.MdiParent = Workspace
                    otheroptions.Show()
                    Workspace.pass_string = string_data
                End If
        Catch
        End Try
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            Label1.Hide()
            Timer1.Stop()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            If RadioButton1.Checked = True Then
                Select Case tabela
                    Case "Clientes"
                        If removidos = True Then
                            If Workspace.Aluno = True Then
                                showdata.DataSource = BLL.Clientes.procura_dados_nome_desativados_alunos("%" + TextBox1.Text + "%")
                            Else
                                showdata.DataSource = BLL.Clientes.procura_dados_nome_desativados("%" + TextBox1.Text + "%")
                            End If
                        Else
                            If Workspace.Aluno = True Then
                                showdata.DataSource = BLL.Clientes.procura_dados_nome_alunos("%" + TextBox1.Text + "%")
                            Else
                                showdata.DataSource = BLL.Clientes.procura_dados_nome("%" + TextBox1.Text + "%")
                            End If
                        End If
                    Case "Artigos"
                        If removidos = True Then
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Artigos.procura_dados_numartigo_desativo(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        Else
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Artigos.procura_dados_numartigo(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        End If
                    Case "Reparações"
                        If removidos = True Then
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Reparacoes.procura_dados_numreparação_desativo(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        Else
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Reparacoes.procura_dados_numreparação(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        End If
                    Case "Técnicos"
                        If removidos = True Then
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Tecnicos.procura_dados_ntecnico_desativados(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        Else
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Tecnicos.procura_dados_ntecnico_ativados(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        End If
                    Case "Empresas"
                        If removidos = True Then
                            showdata.DataSource = BLL.Admin_only.Empresas.procura_dados_Nome_desativados("%" + TextBox1.Text + "%")
                        Else
                            showdata.DataSource = BLL.Admin_only.Empresas.procura_dados_Nome_ativados("%" + TextBox1.Text + "%")
                        End If
                End Select
            End If
            If RadioButton2.Checked = True Then
                Select Case tabela
                    Case "Clientes"
                        If removidos = True Then
                            If Workspace.Aluno Then
                                showdata.DataSource = BLL.Clientes.procura_dados_nif_desativados_alunos("%" + TextBox1.Text + "%")
                            Else
                                showdata.DataSource = BLL.Clientes.procura_dados_nif_desativados("%" + TextBox1.Text + "%")
                            End If
                        Else
                            If Workspace.Aluno Then
                                showdata.DataSource = BLL.Clientes.procura_dados_nif_alunos("%" + TextBox1.Text + "%")
                            Else
                                showdata.DataSource = BLL.Clientes.procura_dados_nif("%" + TextBox1.Text + "%")
                            End If
                        End If
                    Case "Artigos"
                        If removidos = True Then
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Artigos.procura_dados_numcliente_desativo(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        Else
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Artigos.procura_dados_numcliente(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        End If
                    Case "Reparações"
                        If removidos = True Then
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Reparacoes.procura_dados_numartigo_desativo(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        Else
                            If IsNumeric(TextBox1.Text.Chars(TextBox1.Text.Length - 1)) Then
                                showdata.DataSource = BLL.Reparacoes.procura_dados_numartigo(TextBox1.Text)
                            Else
                                TextBox1.Text = ""
                            End If
                        End If
                    Case "Técnicos"
                        If removidos = True Then
                            showdata.DataSource = BLL.Tecnicos.procura_dados_Nome_desativados(TextBox1.Text)
                        Else
                            showdata.DataSource = BLL.Tecnicos.procura_dados_Nome_ativados(TextBox1.Text)
                        End If
                    Case "Empresas"

                        If removidos = True Then
                            showdata.DataSource = BLL.Admin_only.Empresas.procura_dados_nif_ativados("%" + TextBox1.Text + "%")
                        Else
                            showdata.DataSource = BLL.Admin_only.Empresas.procura_dados_nif_desativados("%" + TextBox1.Text + "%")
                        End If
                End Select
            End If
        Catch
        End Try
    End Sub

   
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        Select Case tabela
            Case "Clientes"
                If CheckBox1.Checked = True Then
                    If Workspace.Aluno = True Then
                        data_table = BLL.Clientes.carregar_eliminados_alunos()
                    Else
                        data_table = BLL.Clientes.carregar_eliminados()
                    End If
                    removidos = True
                Else
                    If Workspace.Aluno = True Then
                        data_table = BLL.Clientes.carregar_alunos()
                    Else
                        data_table = BLL.Clientes.carregar()
                    End If
                    removidos = False
                End If
                
            Case "Artigos"
                If CheckBox1.Checked = True Then
                    data_table = BLL.Artigos.carregar_desativos
                    removidos = True
                Else
                    data_table = BLL.Artigos.carregar
                    removidos = False
                End If
            Case "Reparações"
                If CheckBox1.Checked = True Then
                    data_table = BLL.Reparacoes.carregar_desativos
                    removidos = True
                Else
                    data_table = BLL.Reparacoes.carregar
                    removidos = False
                End If
            Case "Técnicos"
                If CheckBox1.Checked = True Then
                    data_table = BLL.Tecnicos.carregar_eliminados()
                    removidos = True
                Else
                    data_table = BLL.Tecnicos.carregar
                    removidos = False
                End If
            Case "Empresas"
                If CheckBox1.Checked = True Then
                    data_table = BLL.Admin_only.Empresas.carregar_eliminados
                    removidos = True
                Else
                    data_table = BLL.Admin_only.Empresas.carregar_eliminados
                    removidos = False
                End If
        End Select
        If removidos = True Then
            delbutton.Text = "Restaurar"
            newbutton.Enabled = False
        Else
            delbutton.Text = "Eliminar"
            newbutton.Enabled = True
        End If
    End Sub
End Class