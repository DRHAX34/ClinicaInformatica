﻿Public Class Selectform
    Public tabela As String
    Public modo As Boolean
    Private Sub onclose(sender As Object, e As EventArgs) Handles Me.FormClosed
        Workspace.check_select = False
    End Sub
    Private Sub Selectform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        Select Case tabela
            Case "Clientes"
                showdata.DataSource = BLL.Clientes.procura_dados_numcliente_mini("")
                modo = False
                RadioButton1.Text = "Nome"
                RadioButton2.Text = "Código Cliente"
                RadioButton3.Text = "NIF"
            Case "Artigos"
                showdata.DataSource = BLL.Artigos.procura_dados_numartigo_mini("")
                modo = True
                RadioButton1.Text = "Código Artigo"
                RadioButton2.Text = "Código Cliente"
                RadioButton3.Hide()

            Case "Empresas"
                showdata.DataSource = BLL.Admin_only.Empresas.procura_dados_Nome_mini("")
                modo = False
                RadioButton1.Text = "Nome"
                RadioButton2.Text = "Código Empresa"
                RadioButton3.Text = "NIF"
            Case "Técnicos"
                showdata.DataSource = BLL.Tecnicos.procura_dados_Nome_mini("")
                modo = False
                RadioButton1.Text = "Nome"
                RadioButton2.Text = "NºTécnico"
                RadioButton3.Hide()
        End Select
    End Sub
    
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If RadioButton1.Checked = True Then
            Select Case tabela
                Case "Clientes"
                    showdata.DataSource = BLL.Clientes.procura_dados_nome_mini("%" + TextBox1.Text + "%")
                Case "Artigos"
                    'If IsNumeric(TextBox1.Text) Then
                    showdata.DataSource = BLL.Artigos.procura_dados_numartigo_mini("%" + TextBox1.Text + "%")
                    'Else
                    '    Dim backup As Array = TextBox1.Text.ToCharArray
                    '    TextBox1.Text = ""
                    '    Try
                    '        For i = 0 To backup.Length - 1
                    '            TextBox1.Text += backup(i)
                    '        Next
                    '    Catch
                    '    End Try
                    'End If
                Case "Empresas"
                    showdata.DataSource = BLL.Admin_only.Empresas.procura_dados_Nome_mini("%" + TextBox1.Text + "%")
                Case "Técnicos"
                    showdata.DataSource = BLL.Tecnicos.procura_dados_Nome_mini("%" + TextBox1.Text + "%")
            End Select
        End If
        If RadioButton2.Checked = True Then
            If IsNumeric(TextBox1.Text) Then
                Select Case tabela
                    Case "Clientes"
                        showdata.DataSource = BLL.Clientes.procura_dados_numcliente_mini("%" + TextBox1.Text + "%")
                    Case "Artigos"
                        'If IsNumeric(TextBox1.Text) Then
                        showdata.DataSource = BLL.Artigos.procura_dados_numcliente_mini("%" + TextBox1.Text + "%")
                        'Else
                        '    Dim backup As Array = TextBox1.Text.ToCharArray
                        '    TextBox1.Text = ""
                        '    Try
                        '        For i = 0 To backup.Length - 1
                        '            TextBox1.Text += backup(i)
                        '        Next
                        '    Catch
                        '    End Try
                        'End If
                    Case "Empresas"
                        showdata.DataSource = BLL.Admin_only.Empresas.procura_dados_mini("%" + TextBox1.Text + "%")
                    Case "Técnicos"
                        showdata.DataSource = BLL.Tecnicos.procura_dados_ntecnico_mini("%" + TextBox1.Text + "%")
                End Select
            Else
                TextBox1.Text = ""
            End If
        End If
        If RadioButton3.Checked = True Then
            If IsNumeric(TextBox1.Text) Then
                Select Case tabela
                    Case "Clientes"
                        showdata.DataSource = BLL.Clientes.procura_dados_nif_mini("%" + TextBox1.Text + "%")
                    Case "Empresas"
                        showdata.DataSource = BLL.Admin_only.Empresas.procura_dados_nif_mini("%" + TextBox1.Text + "%")
                End Select
            Else
                TextBox1.Text = ""
            End If
        End If

    End Sub

    Private Sub adicionarbutton_Click(sender As Object, e As EventArgs) Handles adicionarbutton.Click
        Try
            Workspace.support = CInt(showdata.Rows(showdata.CurrentCell.RowIndex).Cells(0).Value.ToString())
            Me.Close()
        Catch ex As Exception
            MsgBox("Selecione algum dado na tabela!")
        End Try
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.Click
        RadioButton1.Checked = True
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        If Not tabela = "Artigos" Then
            modo = False
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = True
        RadioButton3.Checked = False
        modo = True
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.Click
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = True
        modo = True
    End Sub

    Public Sub OnlyDigitsOnKeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If tabela = "Artigos" Then
            Try
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            Catch
            End Try
        ElseIf RadioButton1.Checked = False Then
            Try
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            Catch
            End Try
        End If
    End Sub
End Class