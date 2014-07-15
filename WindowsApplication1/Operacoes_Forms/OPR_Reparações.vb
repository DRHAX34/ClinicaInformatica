Public Class OPR_Reparações
    Public reparaçao_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Public read_only As Boolean
    Public check As Boolean = True
    Private Sub OPR_Reparações_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modo = True Then
            numcomponentebox.Text = reparaçao_data.Rows.Item(0).Item("NºArtigo").ToString()
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
            If Workspace.hardware_support.Columns.Count <> 0 Then
                If Workspace.hardware_support.Rows.Count <> 0 Then
                    CheckBox1.Checked = True
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
            RadButton1.Enabled = True
            RadButton5.Enabled = False

            datefim.Enabled = True
            insert_tecnicos.Enabled = True
            check = False
            preçobox.Enabled = True
            descriçaobox.Enabled = True
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
        Else
            dateinicio.MinDate = Today
            datefim.MinDate = Today
            datefim.Enabled = False
            preçobox.Enabled = False
            insert_hardware.Enabled = False
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            insert_software.Enabled = False
            insert_tecnicos.Enabled = False
            showdata.Enabled = False
            RadButton1.Enabled = False
            RadButton5.Enabled = True

            descriçaobox.Enabled = True
        End If
        If Workspace.Aluno = True Then
            insert_tecnicos.Show()
            showdata.Show()
        Else
            insert_tecnicos.Hide()
            showdata.Hide()
        End If
    End Sub
    
    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim check_componente As Boolean = False
        Dim check_descrição As String = descriçaobox.Text
        If numcomponentebox.Text.Count <> 0 Or numcomponentebox.Text <> "" Then
            check_componente = True
        Else
            check_componente = False
        End If
        Try
            check_descrição.Trim()
        Catch
        End Try
        If Not check_componente = False And Not check_descrição = "" Then
            Try
                BLL.Reparacoes.inserir(numcomponentebox.Text, descriçaobox.Text, dateinicio.Value)
                MsgBox("Reparação Inserida com sucesso!")
                Workspace.reparacoesmenu.PerformClick()
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao inserir: " & ex.Message)
            End Try
        Else
            MsgBox("Verifique se inseriu o número de Artigo, a data inicial ou a descrição da avaria!", vbOK, "Erro!")
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
            tecnicosform.editbutton.Hide()
            tecnicosform.delbutton.Hide()
            tecnicosform.updatebutton.Hide()
            tecnicosform.findbutton.Hide()
            tecnicosform.othersbutton.Hide()
            tecnicosform.showbutton.Hide()
        Else
            Dim add_tecnicos As New Adicionar_tecnicos
            add_tecnicos.MdiParent = Workspace
            add_tecnicos.Show()
            Workspace.check_select = True
            Timer4.Start()
        End If
    End Sub

    Private Sub numcomponentebox_TextChanged(sender As Object, e As EventArgs) Handles numcomponentebox.TextChanged
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
        Dim artigo As DataTable = BLL.Artigos.carregar_dados_numartigo(numcomponentebox.Text)
        nomeclientelabel.Text = artigo.Rows(0).Item("Marca").ToString + " " + artigo.Rows(0).Item("Modelo").ToString()
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Workspace.reparacoesmenu.PerformClick()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

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

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
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
        If numcomponentebox.Text <> 0 Or numcomponentebox.Text <> "" Then
            check_componente = True
        Else
            MsgBox("Selecione o Artigo!")
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
                BLL.Reparacoes.alterar_datafim(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), numcomponentebox.Text, temporeal.TotalHours.ToString, descriçaobox.Text, dateinicio.Value, datefim.Value, preçobox.Text)
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
                    Workspace.tecnicos_support.Rows.Add(Workspace.tecnico, BLL.Tecnicos.carregar_dados_ntecnico_ativados(Workspace.tecnico).Rows(0).Item("Nome").ToString())
                End If
                If Workspace.tecnicos_support.Columns.Count <> 0 Then
                    If Workspace.tecnicos_support.Rows.Count <> 0 Then
                        For i = 0 To Workspace.tecnicos_support.Rows.Count - 1
                            BLL.Participacoes.adicionar_part(Workspace.tecnicos_support.Rows(i).Item("NºTécnico").ToString, reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), Workspace.tecnicos_support.Rows(i).Item("Nome").ToString)
                        Next
                    End If
                End If
                MsgBox("Reparação Editada com sucesso!")
                If removidos = True Then
                    Workspace.reparacoesmenu.PerformClick()
                Else
                    Workspace.reparacoesmenu.PerformClick()
                End If
                Me.Close()
                check = False
            Catch ex As Exception
                MsgBox("Erro ao inserir: " & ex.Message)
            End Try
        Else
            MsgBox("Insira todos os dados!", vbOKOnly, "Erro!")
        End If
    End Sub

    Private Sub dateinicio_ValueChanged(sender As Object, e As EventArgs) Handles dateinicio.ValueChanged
        datefim.MinDate = dateinicio.Value
        If datefim.Value < dateinicio.Value Then
            datefim.Value = dateinicio.Value
        End If
    End Sub
    
    Private Sub preçobox_TextChanged(sender As Object, e As EventArgs)
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs)
        If removidos = False Then
            Try
                BLL.Reparacoes.apagar(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), 1)
                MsgBox("Removido com sucesso!")
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao Eliminar : " & ex.Message)
            End Try
        Else
            Try
                BLL.Reparacoes.restaurar(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), 1)
                MsgBox("Restaurado com sucesso!")
                Me.Close()
            Catch ex As Exception
                MsgBox("Erro ao Restaurar : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub datefim_ValueChanged(sender As Object, e As EventArgs) Handles datefim.ValueChanged
        Dim temporeal As TimeSpan
        temporeal = datefim.Value.Subtract(dateinicio.Value)
        tempo_real.Text = temporeal.TotalHours & " Horas"
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub RadButton7_Click(sender As Object, e As EventArgs) Handles RadButton7.Click
        If Workspace.check_select = False Then
            Dim select_comp As New Selectform
            select_comp.MdiParent = Workspace
            Workspace.m_ChildFormNumber += 1
            select_comp.tabela = "Artigos"
            select_comp.Show()
            Timer3.Start()
            Workspace.check_select = True
        Else
            MsgBox("Já tem uma janela de Selecionar aberta!")
        End If
    End Sub

    

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            numcomponentebox.Text = Workspace.support
            Dim artigo As DataTable = BLL.Artigos.carregar_dados_numartigo(Workspace.support)
            nomeclientelabel.Text = artigo.Rows(0).Item("Marca").ToString + " " + artigo.Rows(0).Item("Modelo").ToString()
            If Workspace.check_select = False Then
                Timer3.Stop()
            End If
        Catch
        End Try
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

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)
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
    End Sub
    Private Sub numcomponentebox_onlynums(sender As Object, e As KeyPressEventArgs) Handles numcomponentebox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)

    End Sub
End Class