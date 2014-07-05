Public Class OPR_Reparações
    Public reparaçao_data As New DataTable
    Public modo As Boolean
    Public removidos As Boolean
    Public read_only As Boolean
    Public check As Boolean = True
    Private Sub OPR_Reparações_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If modo = True Then
            numcomponentebox.Text = reparaçao_data.Rows.Item(0).Item("NºComponente").ToString()
            preçobox.Text = reparaçao_data.Rows.Item(0).Item("Preço").ToString()
            dateinicio.Value = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString()
            dateinicio.MinDate = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString()
            datefim.Value = reparaçao_data.Rows.Item(0).Item("DFRepar").ToString()
            datefim.MinDate = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString()
            descriçaobox.Text = reparaçao_data.Rows.Item(0).Item("DescAvaria").ToString()
            If Workspace.hardware_support.Rows.Count <> 0 Then
                CheckBox1.Checked = True
            End If
            If Workspace.software_support.Rows.Count <> 0 Then
                CheckBox2.Checked = True
            End If
            RadButton1.Enabled = True
            RadButton5.Enabled = False
            RadButton2.Enabled = True
            datefim.Enabled = True
            insert_hardware.Enabled = True
            insert_software.Enabled = True
            insert_tecnicos.Enabled = True
            check = False
        Else
            dateinicio.MinDate = Today
            datefim.MinDate = Today
            datefim.Enabled = False
            insert_hardware.Enabled = False
            insert_software.Enabled = False
            insert_tecnicos.Enabled = False
            RadButton1.Enabled = False
            RadButton5.Enabled = True
            RadButton2.Enabled = False
        End If
        NumberFormat(preçobox)
    End Sub
    Private Sub me_onclose(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If check = True Then
            If MsgBox("Tem a certeza que quer fechar esta janela?", vbYesNo, "Fechar Janela") = vbNo Then
                e.Cancel = True
            Else
                Workspace.reparativos.PerformClick()
            End If
        Else
            Workspace.reparativos.PerformClick()
        End If
    End Sub
    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim check_componente As Boolean = False
        Dim check_descrição As String = descriçaobox.Text
        If numcomponentebox.Text <> 0 Or numcomponentebox.Text <> "" Then
            check_componente = True
        Else
            MsgBox("Selecione o Componente!")
        End If
        Try
            check_descrição.Trim()
        Catch
        End Try
        If check_componente = True And check_descrição = "" Then
            Try
                BLL.Reparacoes.inserir(numcomponentebox.Text, descriçaobox.Text, dateinicio.Value)
                MsgBox("Reparação Inserida com sucesso!")
                Me.Close()
                check = False
            Catch ex As Exception
                MsgBox("Erro ao inserir: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles insert_tecnicos.Click
        If insert_tecnicos.Text = "Ver Técnicos Participantes" Then
            Dim tecnicosform As New ViewForm
            tecnicosform.MdiParent = Workspace
            tecnicosform.data_table = BLL.Participacoes.procurar_part(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString())
            tecnicosform.tabela = "None"
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
    End Sub

    Private Sub RadButton4_Click(sender As Object, e As EventArgs) Handles RadButton4.Click
        Workspace.reparativos.PerformClick()
        Me.Close()
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub RadButton8_Click(sender As Object, e As EventArgs) Handles insert_hardware.Click
        Dim select_hardware As New Inserir_Hardware
        select_hardware.MdiParent = Workspace
        select_hardware.modo = modo
        select_hardware.Show()
        Me.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Workspace.hardware_support.Rows.Count <> 0 Then
            Me.Enabled = True
        End If
    End Sub

    Private Sub RadButton9_Click(sender As Object, e As EventArgs) Handles insert_software.Click
        Dim select_software As New Inserir_Software
        select_software.MdiParent = Workspace
        select_software.modo = modo
        select_software.Show()
        Me.Enabled = False
        Timer1.Start()
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
        End If
        If numcomponentebox.Text <> 0 Or numcomponentebox.Text <> "" Then
            check_componente = True
        Else
            MsgBox("Selecione o Componente!")
        End If
        Try
            check_descrição.Trim()
        Catch
        End Try
        BLL.Hardware.delete_hardware(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString())
        BLL.Software.delete_software(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString())
        BLL.Participacoes.remover_part(0, reparaçao_data.Rows.Item(0).Item("NºReparação").ToString())
        If Not (check_componente = True And check_descrição = "" And check_data = False) Then
            Try
                BLL.Reparacoes.alterar_datafim(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), numcomponentebox.Text, temporeal.ToString(), Workspace.tecnicos_support, descriçaobox.Text, dateinicio.Value, datefim.Value, preçobox.Text)
                If Workspace.hardware_support.Rows.Count <> 0 Then
                    For i = 0 To Workspace.hardware_support.Rows.Count - 1
                        BLL.Hardware.adicionar_hardware(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), Workspace.hardware_support.Rows(i).Item("Tipo").ToString(), Workspace.hardware_support.Rows(i).Item("Preço"), Workspace.hardware_support.Rows(i).Item("Qtd").ToString)
                    Next
                End If
                If Workspace.software_support.Rows.Count <> 0 Then
                    For i = 0 To Workspace.software_support.Rows.Count - 1
                        BLL.Software.adicionar_software(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), Workspace.hardware_support.Rows(i).Item("Tipo").ToString(), Workspace.hardware_support.Rows(i).Item("Preço"))
                    Next
                End If
                MsgBox("Reparação Editada com sucesso!")
                Me.Close()
                check = False
            Catch ex As Exception
                MsgBox("Erro ao inserir: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub dateinicio_ValueChanged(sender As Object, e As EventArgs) Handles dateinicio.ValueChanged
        datefim.MinDate = dateinicio.Value
        If datefim.Value < dateinicio.Value Then
            datefim.Value = dateinicio.Value
        End If
    End Sub
    Public Sub NumberFormat(ByVal Text As TextBox)
        Dim temptext As TextBox = Text
        If Len(temptext.Text) > 0 Then
            'estou a por estes comentários para te explicar como funcionam estes códigos.
            'tira o simbolo do Euro 

            If temptext.Text.StartsWith("€") Then
                temptext.Text = temptext.Text.Substring(1, temptext.TextLength - 1)
            End If
            'esta parte adiciona o decimal por isso se o utilizador introduzir 1234 é equivalente a 12.34 
            'se não houver decimal, adiciona automáticamente

            If temptext.Text.Contains(".") Then
            Else
                If temptext.TextLength > 1 Then
                    Dim tempstr As String = temptext.Text.Substring(0, temptext.TextLength - 2)
                    Dim tempstrlast2 As String = temptext.Text.Substring(temptext.TextLength - 2, 2)
                    temptext.Text = CDec(tempstr & "." & tempstrlast2)
                Else
                    temptext.Text = ".0" & temptext.Text
                End If
            End If

            ' alterar isto de 0 para -1 dá o valor decimal 

            temptext.Text = FormatNumber(CDbl(temptext.Text), -1)
            Dim x As Integer = temptext.Selectionstart.ToString
            If x = 0 Then
                temptext.Selectionstart = Len(temptext.Text)
                temptext.SelectionLength = 0
            Else
                temptext.Selectionstart = x
                temptext.SelectionLength = 0
            End If
        End If

        'Adiciona o simbolo €

        Text.Text = temptext.Text & "€"
    End Sub
    Private Sub preçobox_TextChanged(sender As Object, e As EventArgs) Handles preçobox.TextChanged
        NumberFormat(preçobox)
        preçocivalabel.Text = CDbl(preçobox.Text) + (CDbl(preçobox.Text) * 23 / 100)
    End Sub

    Private Sub RadButton2_Click(sender As Object, e As EventArgs) Handles RadButton2.Click
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
End Class