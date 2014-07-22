Public Class Inserir_Hardware_desk
    Public modo As Boolean
    Private Sub Inserir_Hardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim certoimagebutton As New Bitmap((My.Resources._1405695721_Select), certobutton.Height, certobutton.Height)
        certobutton.Image = certoimagebutton
        Dim exitimagebutton As New Bitmap((My.Resources.Sair), exitbutton.Height, exitbutton.Height)
        exitbutton.Image = exitimagebutton
        Me.AcceptButton = certobutton
        If modo = False Then
            Workspace.hardware_support = New DataTable
        Else
            caixaqtdbox.Value = Workspace.hardware_support.Rows(0).Item("Qtd")
            caixapreçobox.Text = Workspace.hardware_support.Rows(0).Item("Preço")
            motherqtdbox.Value = Workspace.hardware_support.Rows(1).Item("Qtd")
            motherpreçobox.Text = Workspace.hardware_support.Rows(1).Item("Preço")
            coolerqtdbox.Value = Workspace.hardware_support.Rows(2).Item("Qtd")
            coolerpreçobox.Text = Workspace.hardware_support.Rows(2).Item("Preço")
            vgaqtdbox.Value = Workspace.hardware_support.Rows(3).Item("Qtd")
            vgapreçobox.Text = Workspace.hardware_support.Rows(3).Item("Preço")
            opticqtdbox.Value = Workspace.hardware_support.Rows(4).Item("Qtd")
            opticpreçobox.Text = Workspace.hardware_support.Rows(4).Item("Preço")
            redeqtdbox.Value = Workspace.hardware_support.Rows(5).Item("Qtd")
            redepreçobox.Text = Workspace.hardware_support.Rows(5).Item("Preço")
            fonteqtdbox.Value = Workspace.hardware_support.Rows(6).Item("Qtd")
            fontepreçobox.Text = Workspace.hardware_support.Rows(6).Item("Preço")
            processadorqtdbox.Value = Workspace.hardware_support.Rows(7).Item("Qtd")
            processadorpreçobox.Text = Workspace.hardware_support.Rows(7).Item("Preço")
            memoriaqtdbox.Value = Workspace.hardware_support.Rows(8).Item("Qtd")
            memóriapreçobox.Text = Workspace.hardware_support.Rows(8).Item("Preço")
            discoqtdbox.Value = Workspace.hardware_support.Rows(9).Item("Qtd")
            discopreçobox.Text = Workspace.hardware_support.Rows(9).Item("Preço")
            leitorqtdbox.Value = Workspace.hardware_support.Rows(10).Item("Qtd")
            leitorpreçobox.Text = Workspace.hardware_support.Rows(10).Item("Preço")
            otherqtdbox.Value = Workspace.hardware_support.Rows(11).Item("Qtd")
            otherpreçobox.Text = Workspace.hardware_support.Rows(11).Item("Preço")
            otherdescriçaobox.Text = Workspace.hardware_support.Rows(11).Item("Tipo")
        End If
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs)
        Dim h(2) As Object
        If Workspace.hardware_support.Columns.Count <> 3 Then
            Workspace.hardware_support.Columns.Add("Tipo")
            Workspace.hardware_support.Columns.Add("Qtd")
            Workspace.hardware_support.Columns.Add("Preço")
        End If
        h(0) = "Caixa"
        h(1) = caixaqtdbox.Value
        h(2) = (caixapreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "Motherboard"
        h(1) = motherqtdbox.Value
        h(2) = (motherpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "Cooler"
        h(1) = coolerqtdbox.Value
        h(2) = (coolerpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "VGA"
        h(1) = vgaqtdbox.Value
        h(2) = (vgapreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "Unidade Óptica"
        h(1) = (opticqtdbox.Value)
        h(2) = (opticpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Placa de Rede")
        h(1) = (redeqtdbox.Value)
        h(2) = (redepreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Fonte")
        h(1) = (fonteqtdbox.Value)
        h(2) = (fontepreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Processador")
        h(1) = (processadorqtdbox.Value)
        h(2) = (processadorpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Memória")
        h(1) = (memoriaqtdbox.Value)
        h(2) = (memóriapreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Disco")
        h(1) = (discoqtdbox.Value)
        h(2) = (discopreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Leitor de Cartões")
        h(1) = (leitorqtdbox.Value)
        h(2) = (leitorpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = (otherdescriçaobox.Text)
        h(1) = (otherqtdbox.Value)
        h(2) = (otherpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        Me.Close()
    End Sub

    'Public Sub NumberFormat(ByVal Text As TextBox)
    '    Dim temptext As TextBox = Text
    '    If Len(temptext.Text) > 0 Then
    '        'estou a por estes comentários para te explicar como funcionam estes códigos.
    '        'tira o simbolo do Euro 

    '        If temptext.Text.StartsWith("€") Then
    '            temptext.Text = temptext.Text.Substring(1, temptext.TextLength - 1)
    '        End If
    '        'esta parte adiciona o decimal por isso se o utilizador introduzir 1234 é equivalente a 12.34 
    '        'se não houver decimal, adiciona automáticamente

    '        If temptext.Text.Contains(".") Then
    '        Else
    '            If temptext.TextLength > 1 Then
    '                Dim tempstr As String = temptext.Text.Substring(0, temptext.TextLength - 2)
    '                Dim tempstrlast2 As String = temptext.Text.Substring(temptext.TextLength - 2, 2)
    '                temptext.Text = CDec(tempstr & "." & tempstrlast2)
    '            Else
    '                temptext.Text = ".0" & temptext.Text
    '            End If
    '        End If

    '        ' alterar isto de 0 para -1 dá o valor decimal 

    '        temptext.Text = FormatNumber(CDbl(temptext.Text), -1)
    '        Dim x As Integer = temptext.Selectionstart.ToString
    '        If x = 0 Then
    '            temptext.Selectionstart = Len(temptext.Text)
    '            temptext.SelectionLength = 0
    '        Else
    '            temptext.Selectionstart = x
    '            temptext.SelectionLength = 0
    '        End If
    '    End If

    '    'Adiciona o simbolo €

    '    Text.Text = temptext.Text & "€"
    'End Sub


    Private Sub RadButton1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub caixapreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(caixapreçobox)
        'Try
        '    caixapreçoivalabel.Text = CDec(caixapreçobox.Text) + ((CDec(caixapreçobox.Text) * 23) / 100)
        'Catch
        'End Try
    End Sub

    Private Sub motherpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(motherpreçobox)
        'Try
        '    motherpreçoivalabel.Text = CDec(motherpreçobox.Text) + ((CDec(motherpreçobox.Text) * 23) / 100)
        'Catch
        'End Try
    End Sub

    Private Sub coolerpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(coolerpreçobox)
        Try
            'coolerpreçoivalabel.Text = CDec(coolerpreçobox.Text) + ((CDec(coolerpreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub VGApreçobox_TextChanged(sender As Object, e As EventArgs)
        ''NumberFormat(VGApreçobox)
        Try
            'vgapreçoivalabel.Text = CDec(vgapreçobox.Text) + ((CDec(vgapreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub opticpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(opticpreçobox)
        Try
            ''opticpreçoivalabel.Text = CDec(opticpreçobox.Text) + ((CDec(opticpreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub redepreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(redepreçobox)
        Try
            'redepreçoivalabel.Text = CDec(redepreçobox.Text) + ((CDec(redepreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub fontepreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(fontepreçobox)
        Try
            'fontepreçoivalabel.Text = CDec(fontepreçobox.Text) + ((CDec(fontepreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub processadorpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(processadorpreçobox)
        Try
            'processadorpreçoivalabel.Text = CDec(processadorpreçobox.Text) + ((CDec(processadorpreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub memóriapreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(memóriapreçobox)
        Try
            'memoriapreçoivalabel.Text = CDec(memóriapreçobox.Text) + ((CDec(memóriapreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub discopreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(discopreçobox)
        Try
            'discopreçoivalabel.Text = CDec(discopreçobox.Text) + ((CDec(discopreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub leitorpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(leitorpreçobox)
        Try
            'leitorpreçoivalabel.Text = CDec(leitorpreçobox.Text) + ((CDec(leitorpreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub otherpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(otherpreçobox)
        Try

            'otherpreçoivalabel.Text = CDec(otherpreçobox.Text) + ((CDec(otherpreçobox.Text) * 23) / 100)
        Catch
        End Try
    End Sub

    Private Sub RadLabel1_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub caixapreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles caixapreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub motherpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles motherpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub coolerpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles coolerpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub vgapreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles vgapreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub opticpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles opticpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub redepreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles redepreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub fontepreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles fontepreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub processadorpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles processadorpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub memoriapreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles memóriapreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub discopreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles discopreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub leitorpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles leitorpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub otherpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles otherpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Or (InStr(sender.text, ".") > 0 And e.KeyChar = Microsoft.VisualBasic.Chr(46)) Then
                    e.Handled = True
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub RadLabel7_Click(sender As Object, e As EventArgs)

    End Sub
End Class