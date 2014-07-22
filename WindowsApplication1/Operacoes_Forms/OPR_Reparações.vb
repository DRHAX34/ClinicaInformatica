Public Class OPR_Reparações
    Public reparaçao_data As New DataTable
    Public artigos As String
    Public modo As Boolean
    Public removidos As Boolean
    Public read_only As Boolean
    Public check As Boolean = True
    Public cliente As Integer
    Private Sub OPR_Reparações_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saveimagebutton As New Bitmap((My.Resources._1405624185_floppy), savebutton.Height, savebutton.Height)
        savebutton.Image = saveimagebutton
        Dim reportimagebutton As New Bitmap((My.Resources._1405976976_distributor_report), reportbutton.Height, reportbutton.Height)
        reportbutton.Image = reportimagebutton
        Dim restartimagebutton As New Bitmap((My.Resources._1405624497_MB__reload), restartbutton.Height, restartbutton.Height)
        Dim exitimagebutton As New Bitmap((My.Resources.Sair), exitbutton.Height, exitbutton.Height)
        exitbutton.Image = exitimagebutton
        Dim limparimagebutton As New Bitmap((My.Resources._32x32), restartbutton.Height, restartbutton.Height)
        If Workspace.Aluno = True Then
            Panel1.Hide()
        Else
            clienteshow.Text = BLL.Clientes.carregar_dados_numcliente(cliente, True).Rows(0).Item("Nome").ToString
            Panel1.Show()
            Panel1.BringToFront()
        End If
        If modo = True Then
            restartbutton.Image = restartimagebutton
            If reparaçao_data.Rows.Item(0).Item("Preço").ToString() <> "" Then
                preçobox.Text = reparaçao_data.Rows.Item(0).Item("Preço").ToString().Replace(",", ".")
            End If
            dateinicio.Value = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString()
            dateinicio.MinDate = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString()
            If reparaçao_data.Rows.Item(0).Item("DFRepar").ToString() <> "" Then
                datefim.Value = reparaçao_data.Rows.Item(0).Item("DFRepar").ToString
            Else
                restartbutton.Image = limparimagebutton
                datefim.Value = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString
            End If
            datefim.MinDate = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString()
            descriçaobox.Text = reparaçao_data.Rows.Item(0).Item("DescAvaria").ToString()
            If Workspace.hardware_support.Columns.Count <> 0 Then
                If Workspace.hardware_support.Rows.Count <> 0 Then
                    checkbox1.Checked = True
                    insert_hardware.Enabled = True
                End If
            End If
            If Workspace.software_support.Columns.Count <> 0 Then
                If Workspace.software_support.Rows.Count <> 0 Then
                    CheckBox2.Checked = True
                    insert_software.Enabled = True
                End If
            End If
            showdata.DataSource = Workspace.tecnicos_support
            datefim.Enabled = True
            insert_tecnicos.Enabled = True
            check = False
            preçobox.Enabled = True
            descriçaobox.Enabled = True
            checkbox1.Enabled = True
            CheckBox2.Enabled = True
        Else
            dateinicio.MinDate = Today
            datefim.MinDate = Today
            datefim.Enabled = False
            preçobox.Enabled = False
            insert_hardware.Enabled = False
            checkbox1.Enabled = False
            CheckBox2.Enabled = False
            insert_software.Enabled = False
            insert_tecnicos.Enabled = False
            showdata.Enabled = False

            descriçaobox.Enabled = True
        End If
        If Workspace.Aluno = True Then
            insert_tecnicos.Show()
            showdata.Show()
        Else
            insert_tecnicos.Hide()
            showdata.Hide()
        End If
        Dim artigo As DataTable = BLL.Artigos.carregar_dados_numartigo(artigos, True)
        nomeclientelabel.Text = artigo.Rows(0).Item("Marca").ToString + " " + artigo.Rows(0).Item("Modelo").ToString()
    End Sub
    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        If modo = False Then
            Dim check_componente As Boolean = False
            Dim check_descrição As String = descriçaobox.Text
            Try
                check_descrição.Trim()
            Catch
            End Try
            If Not check_componente = False And Not check_descrição = "" Then
                Try
                    BLL.Reparacoes.inserir(artigos, descriçaobox.Text, dateinicio.Value)
                    folha_repar = New folha_repar
                    folha_repar.MdiParent = Workspace
                    folha_repar.n_repar = BLL.Reparacoes.carregar(True).Rows(BLL.Reparacoes.carregar(True).Rows.Count - 1).Item("NºReparação").ToString()
                    folha_repar.artigodata = BLL.Artigos.carregar_dados_numartigo(artigos, True)
                    folha_repar.cliente_data = BLL.Clientes.carregar_dados_numcliente(folha_repar.artigodata.Rows(0).Item("NºCliente").ToString, True)
                    folha_repar.Show()
                    Me.Close()
                Catch ex As Exception
                    MsgBox("Erro ao inserir: " & ex.Message)
                End Try
            Else
                MsgBox("Verifique se inseriu o número de Artigo, a data inicial ou a descrição da avaria!", vbOK, "Erro!")
            End If
        Else
            Dim check_componente As Boolean = False
            Dim check_descrição As String = descriçaobox.Text
            Dim check_data As Boolean = False
            Dim temporeal As TimeSpan
            If datefim.Value = dateinicio.Value Then
                check_data = False
                temporeal = New TimeSpan
            Else
                temporeal = datefim.Value.Subtract(dateinicio.Value)
                check_data = True
            End If
            Try
                check_descrição.Trim()
            Catch
            End Try
            If BLL.Hardware.return_all <> 0 Then
                BLL.Hardware.delete_hardware(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString())
            End If
            If BLL.Software.return_all <> 0 Then
                BLL.Software.delete_software(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString())
            End If
            If BLL.Participacoes.return_all <> 0 Then
                BLL.Participacoes.remover_part(0, reparaçao_data.Rows.Item(0).Item("NºReparação").ToString())
            End If
            If Not check_componente = False And Not check_descrição = "" And Not check_data = False Then
                Try
                    BLL.Reparacoes.alterar_datafim(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), artigos, temporeal.TotalHours.ToString, descriçaobox.Text, dateinicio.Value, datefim.Value, preçobox.Text)
                    If Workspace.hardware_support.Columns.Count <> 0 Then
                        If Workspace.hardware_support.Rows.Count <> 0 Then
                            For i = 0 To Workspace.hardware_support.Rows.Count - 1
                                BLL.Hardware.adicionar_hardware(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), Workspace.hardware_support.Rows(i).Item("Tipo").ToString(), Workspace.hardware_support.Rows(i).Item("Preço").ToString, Workspace.hardware_support.Rows(i).Item("Qtd").ToString)
                            Next
                        End If
                    End If
                    If Workspace.software_support.Columns.Count <> 0 Then
                        If Workspace.software_support.Rows.Count <> 0 Then
                            For i = 0 To Workspace.software_support.Rows.Count - 1
                                BLL.Software.adicionar_software(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), Workspace.hardware_support.Rows(i).Item("Tipo").ToString(), Workspace.hardware_support.Rows(i).Item("Preço"))
                            Next
                        End If
                    End If
                    If Workspace.Aluno = False Then
                        Workspace.tecnicos_support.Rows.Add(Workspace.tecnico, BLL.Tecnicos.carregar_dados(Workspace.tecnico, True).Rows(0).Item("Nome").ToString())
                    End If
                    If Workspace.tecnicos_support.Columns.Count <> 0 Then
                        If Workspace.tecnicos_support.Rows.Count <> 0 Then
                            For i = 0 To Workspace.tecnicos_support.Rows.Count - 1
                                BLL.Participacoes.adicionar_part(Workspace.tecnicos_support.Rows(i).Item("NºTécnico").ToString, reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), Workspace.tecnicos_support.Rows(i).Item("Nome").ToString)
                            Next
                        End If
                    End If
                    MsgBox("Reparação Editada com sucesso!")
                    '-----INSERIR CÓDIGO AQUI------"
                    Me.Close()
                    check = False
                Catch ex As Exception
                    MsgBox("Erro ao inserir: " & ex.Message)
                End Try
            Else
                MsgBox("Insira todos os dados!", vbOKOnly, "Erro!")
            End If
        End If
    End Sub
    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles insert_tecnicos.Click
        If insert_tecnicos.Text = "Ver Técnicos Participantes" Then
            Dim tecnicosform As New ViewForm
            tecnicosform.MdiParent = Workspace
            tecnicosform.data_table = BLL.Participacoes.procurar_part(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString())
            tecnicosform.tabela = "None"
            tecnicosform.Text = "Técnicos Participantes"
            tecnicosform.Show()
            tecnicosform.newbutton.Hide()
            tecnicosform.delbutton.Hide()
            tecnicosform.findbutton.Hide()
        Else
            Dim add_tecnicos As New Adicionar_tecnicos
            add_tecnicos.MdiParent = Workspace
            add_tecnicos.Show()
            Workspace.check_select = True
            Timer4.Start()
        End If
    End Sub
    Private Sub numcomponentebox_TextChanged(sender As Object, e As EventArgs)
        'Try
        '    If Not IsNumeric(numcomponentebox.Text.Chars(numcomponentebox.Text.Length - 1)) Then
        '        Dim backup As Array = numcomponentebox.Text.ToCharArray
        '        numcomponentebox.Text = ""
        '        Try
        '            If numcomponentebox.Text.Length = 1 Then
        '                numcomponentebox.Text = ""
        '            Else
        '                For i = 0 To backup.Length - 2
        '                    numcomponentebox.Text += backup(i)
        '                Next
        '            End If
        '            numcomponentebox.
        '        Catch()
        '        End Try
        '    End If
        'Catch
        'End Try
        
    End Sub
    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub
    Private Sub RadButton8_Click(sender As Object, e As EventArgs) Handles insert_hardware.Click
        Dim select_hardware As New Inserir_Hardware
        select_hardware.MdiParent = Workspace
        If Workspace.hardware_support.Columns.Count <> 0 Then
            If Workspace.hardware_support.Rows.Count <> 0 Then
                select_hardware.modo = True
            Else
                select_hardware.modo = False
            End If
        Else
            select_hardware.modo = False
        End If
        select_hardware.Show()
    End Sub
    Private Sub RadButton9_Click(sender As Object, e As EventArgs) Handles insert_software.Click
        Dim select_software As New Inserir_Software
        select_software.MdiParent = Workspace
        If Workspace.software_support.Columns.Count <> 0 Then
            If Workspace.software_support.Rows.Count <> 0 Then
                select_software.modo = True
            Else
                select_software.modo = False
            End If

        Else
            select_software.modo = False
        End If
        select_software.Show()
    End Sub
    Private Sub dateinicio_ValueChanged(sender As Object, e As EventArgs) Handles dateinicio.ValueChanged
        datefim.MinDate = dateinicio.Value
        If datefim.Value < dateinicio.Value Then
            datefim.Value = dateinicio.Value
        End If
    End Sub
    Private Sub datefim_ValueChanged(sender As Object, e As EventArgs) Handles datefim.ValueChanged
        Dim temporeal As TimeSpan
        temporeal = datefim.Value.Subtract(dateinicio.Value)
        tempo_real.Text = temporeal.TotalHours & " Horas"
    End Sub
    Private Sub checkbox1_click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        insert_hardware.Enabled = CheckBox1.Checked
    End Sub
    Private Sub checkbox2_click(sender As Object, e As EventArgs) Handles CheckBox2.Click
        insert_software.Enabled = CheckBox2.Checked
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Try
            showdata.DataSource = Workspace.tecnicos_support
            If Workspace.check_select = False Then
                Timer4.Stop()
            End If
        Catch
        End Try
    End Sub
    Private Sub preçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles preçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
        Dim check As Boolean = False
        Dim count As Integer = 0
        For i = 0 To preçobox.Text.Length() - 1
            If preçobox.Text.Chars(i) = "." And check = False Then
                check = True
            End If
            If check = True Then
                count += 1
            End If
        Next
        If count = 2 Then
            e.Handled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub
End Class