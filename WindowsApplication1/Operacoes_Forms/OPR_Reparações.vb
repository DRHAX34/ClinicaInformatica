Public Class OPR_Reparações
    Public reparaçao_data As New DataTable
    Public hardware_data As String
    Public software_data As String
    Public modo As Boolean
    Public removidos As Boolean
    Private Sub OPR_Reparações_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datainiciolabel.Hide()
        datafimlabel.Hide()
        If modo = True Then
            numcomponentebox.Text = reparaçao_data.Rows.Item(0).Item("NºDispositivo").ToString()
            categoriabox.Text = reparaçao_data.Rows.Item(0).Item("Categoria").ToString()
            dateinicio.Value = reparaçao_data.Rows.Item(0).Item("DIRepar").ToString()
            datefim.Value = reparaçao_data.Rows.Item(0).Item("DFRepar").ToString()
            descriçaobox.Text = reparaçao_data.Rows.Item(0).Item("DescAvaria").ToString()
            If hardware_data <> "" Or hardware_data = "NULL" Then
                CheckBox1.Checked = True
                hardwarebox.Text = hardware_data
            End If
            If software_data <> "" Or software_data = "NULL" Then
                CheckBox2.Checked = True
                softwarebox.Text = software_data
            End If
            RadButton1.Enabled = True
            RadButton5.Enabled = False
            RadButton2.Enabled = True
        Else
            RadButton1.Enabled = False
            RadButton5.Enabled = True
            RadButton2.Enabled = False
        End If
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        If Workspace.tecnicos_support.Rows.Count <> 0 Then
            Dim check_componente As Boolean = True
            Dim check_categoria As String = ""
            Dim check_codpostal As String = ""
            Dim check_hardware As String = ""
            Dim check_software As String = ""
            Dim check_descricao As String = ""
            Dim check_date As Boolean = ""
            If datefim.Value = dateinicio.Value Then
                check_date = False
            End If
            For i = 0 To numcomponentebox.Text.Count - 1
                If numcomponentebox.Text.Chars(i) <> " " Then
                    check_componente = False
                End If
            Next
        Else
            MsgBox("Selecione os técnicos participantes!")
        End If
    End Sub

    Private Sub RadButton6_Click(sender As Object, e As EventArgs) Handles RadButton6.Click
        If RadButton6.Text = "Ver Técnicos Participantes" Then
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
End Class