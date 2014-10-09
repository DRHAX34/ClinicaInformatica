Public Class OPR_Reparações
    Public reparaçao_data As New DataTable
    Public artigos As Integer
    Public modo As Boolean
    Public removidos As Boolean
    Public read_only As Boolean
    Public check As Boolean = True
    Public cliente As Integer
    Public tipo_artigo As String
    Private Sub OPR_Reparações_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim saveimagebutton As New Bitmap((My.Resources._1405624185_floppy), savebutton.Height - 1, savebutton.Height - 1)
        savebutton.Image = saveimagebutton
        Dim reportimagebutton As New Bitmap((My.Resources._1405976976_distributor_report), reportbutton.Height - 1, reportbutton.Height - 1)
        reportbutton.Image = reportimagebutton
        Dim restartimagebutton As New Bitmap((My.Resources._1405624497_MB__reload), restartbutton.Height - 1, restartbutton.Height - 1)
        Dim exitimagebutton As New Bitmap((My.Resources._1406140864_logout), exitbutton.Height - 1, exitbutton.Height - 1)
        exitimagebutton.MakeTransparent(Color.White)
        exitbutton.Image = exitimagebutton
        Dim limparimagebutton As New Bitmap((My.Resources._32x32), restartbutton.Height - 1, restartbutton.Height - 1)
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
                datefim.Value = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString
            End If
            datefim.MinDate = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString()
            descriçaobox.Text = reparaçao_data.Rows.Item(0).Item("DescAvaria").ToString()
            showdata.DataSource = Workspace.tecnicos_support
            datefim.Enabled = True
            insert_tecnicos.Enabled = True
            check = False
            preçobox.Enabled = True
            descriçaobox.Enabled = True
            insert_hardware.Enabled = True
            insert_software.Enabled = True
            reportbutton.Enabled = True
        Else
            restartbutton.Image = limparimagebutton
            dateinicio.MinDate = Today
            datefim.MinDate = Today
            datefim.Enabled = False
            preçobox.Enabled = False
            insert_hardware.Enabled = False
            insert_software.Enabled = False
            insert_tecnicos.Enabled = False
            showdata.Enabled = False
            reportbutton.Enabled = False
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
        tipo_artigo = artigo.Rows(0).Item("Tipo_Artigo").ToString()
    End Sub
    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles savebutton.Click
        If modo = False Then
                Dim h(2) As Object
                If Workspace.hardware_support.Columns.Count <> 3 Then
                    Workspace.hardware_support.Columns.Add("Tipo")
                    Workspace.hardware_support.Columns.Add("Qtd")
                    Workspace.hardware_support.Columns.Add("Preço")
                End If
                h(0) = "Caixa"
                h(1) = 0
                h(2) = 0.0
                Workspace.hardware_support.Rows.Add(h)
                h(0) = "Motherboard"
                Workspace.hardware_support.Rows.Add(h)
                h(0) = "Cooler"
                Workspace.hardware_support.Rows.Add(h)
                h(0) = "VGA"
                Workspace.hardware_support.Rows.Add(h)
                h(0) = "Unidade Óptica"
                Workspace.hardware_support.Rows.Add(h)
                h(0) = ("Placa de Rede")
                Workspace.hardware_support.Rows.Add(h)
                h(0) = ("Fonte")
                Workspace.hardware_support.Rows.Add(h)
                h(0) = ("Processador")
                Workspace.hardware_support.Rows.Add(h)
                h(0) = ("Memória")
                Workspace.hardware_support.Rows.Add(h)
                h(0) = ("Disco")
                Workspace.hardware_support.Rows.Add(h)
                h(0) = ("Leitor de Cartões")
                Workspace.hardware_support.Rows.Add(h)
                h(0) = ("Outro:")
                Workspace.hardware_support.Rows.Add(h)
            If Workspace.software_support.Columns.Count = 0 Then
                Workspace.software_support.Columns.Add("Tipo")
                Workspace.software_support.Columns.Add("Preço")
            End If
            Dim s(1) As Object
            s(0) = ("Instalação S.O")
            s(1) = 0.0
            Workspace.software_support.Rows.Add(s)
            s(0) = ("Recuperação S.O")
            Workspace.software_support.Rows.Add(s)
            s(0) = ("Remoção Spyware")
            Workspace.software_support.Rows.Add(s)
            s(0) = ("Remoção Vírus")
            Workspace.software_support.Rows.Add(s)
            s(0) = ("Remoção Cód. S.O")
            Workspace.software_support.Rows.Add(s)
            s(0) = ("Limpeza")
            Workspace.software_support.Rows.Add(s)
            s(0) = ("Outro:")
            Workspace.software_support.Rows.Add(s)
            Dim check_descrição As String = descriçaobox.Text
            Try
                check_descrição.Trim()
            Catch
            End Try
            If Not check_descrição = "" Then
                Try
                    BLL.Reparacoes.inserir(artigos, descriçaobox.Text, dateinicio.Value)
                    If Workspace.hardware_support.Columns.Count <> 0 Then
                        If Workspace.hardware_support.Rows.Count <> 0 Then
                            For i = 0 To Workspace.hardware_support.Rows.Count - 1
                                BLL.Hardware.adicionar_hardware(BLL.Reparacoes.carregar(True).Rows(BLL.Reparacoes.carregar(True).Rows.Count - 1).Item("NºReparação"), Workspace.hardware_support.Rows(i).Item("Tipo").ToString(), Workspace.hardware_support.Rows(i).Item("Preço").ToString, Workspace.hardware_support.Rows(i).Item("Qtd").ToString)
                            Next
                        End If
                    End If
                    If Workspace.software_support.Columns.Count <> 0 Then
                        If Workspace.software_support.Rows.Count <> 0 Then
                            For i = 0 To Workspace.software_support.Rows.Count - 1
                                BLL.Software.adicionar_software(BLL.Reparacoes.carregar(True).Rows(BLL.Reparacoes.carregar(True).Rows.Count - 1).Item("NºReparação"), Workspace.hardware_support.Rows(i).Item("Tipo").ToString(), Workspace.hardware_support.Rows(i).Item("Preço"))
                            Next
                        End If
                    End If
                    BLL.Participacoes.adicionar_part(CInt(Workspace.tecnico), CInt(BLL.Reparacoes.carregar(True).Rows(BLL.Reparacoes.carregar(True).Rows.Count - 1).Item(0).ToString), BLL.Tecnicos.carregar_dados(Workspace.tecnico, True).Rows(0).Item("Nome").ToString)
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
            Dim check_descrição As String = descriçaobox.Text
            Dim check_data As Boolean = False
            Dim temporeal As TimeSpan
            check_data = True
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
            If Not check_descrição = "" And Not check_data = False Then
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
                    If MsgBox("Reparação Editada com sucesso! Deseja mostrar o Relatório da Reparação?", MsgBoxStyle.YesNo, "Sucesso!") = vbYes Then
                        folha_repar.MdiParent = Workspace
                        folha_repar.n_repar = reparaçao_data.Rows(0).Item(0).ToString()
                        folha_repar.artigodata = BLL.Artigos.carregar_dados_numartigo(artigos, True)
                        folha_repar.cliente_data = BLL.Clientes.carregar_dados_numcliente(folha_repar.artigodata.Rows(0).Item("NºCliente").ToString(), True)
                        folha_repar.Show()
                    End If
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
        Workspace.select_hardware = New Inserir_Hardware_desk
        Workspace.select_hardware.MdiParent = Workspace
            If Workspace.hardware_support.Columns.Count <> 0 Then
                If Workspace.hardware_support.Rows.Count <> 0 Then
                Workspace.select_hardware.modo = True
                Else
                Workspace.select_hardware.modo = False
                End If
            Else
            Workspace.select_hardware.modo = False
            End If
        Workspace.select_hardware.Show()
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
        Dim check As Boolean = False
        Dim count As Integer = 0
        Try
            For i = 0 To preçobox.Text.Length() - 1
                If preçobox.Text.Chars(i) = "." And check = False Then
                    check = True
                End If
                If check = True Then
                    count += 1
                End If
            Next
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
        If count = 3 And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
            e.Handled = True
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub reportbutton_Click(sender As Object, e As EventArgs) Handles reportbutton.Click
        folha_repar.MdiParent = Workspace
        folha_repar.n_repar = reparaçao_data.Rows(0).Item(0).ToString()
        folha_repar.artigodata = BLL.Artigos.carregar_dados_numartigo(artigos, True)
        folha_repar.cliente_data = BLL.Clientes.carregar_dados_numcliente(folha_repar.artigodata.Rows(0).Item("NºCliente").ToString(), True)
        folha_repar.Show()
    End Sub
End Class