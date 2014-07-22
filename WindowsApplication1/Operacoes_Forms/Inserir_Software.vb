Public Class Inserir_Software
    Public modo As Boolean
    Private Sub Inserir_software_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim certoimagebutton As New Bitmap((My.Resources._1405695721_Select), certobutton.Height, certobutton.Height)
        certobutton.Image = certoimagebutton
        Dim exitimagebutton As New Bitmap((My.Resources.Sair), exitbutton.Height, exitbutton.Height)
        exitbutton.Image = exitimagebutton
        Me.AcceptButton = certobutton
        If modo = False Then
            Workspace.software_support = New DataTable
        Else
            caixapreçobox.Text = Workspace.hardware_support.Rows(0).Item("Preço")
            motherpreçobox.Text = Workspace.hardware_support.Rows(1).Item("Preço")
            coolerpreçobox.Text = Workspace.hardware_support.Rows(2).Item("Preço")
            vgapreçobox.Text = Workspace.hardware_support.Rows(3).Item("Preço")
            opticpreçobox.Text = Workspace.hardware_support.Rows(4).Item("Preço")
            redepreçobox.Text = Workspace.hardware_support.Rows(5).Item("Preço")
            otherdescriçaobox.Text = Workspace.hardware_support.Rows(6).Item("Tipo")
            otherpreçobox.Text = Workspace.hardware_support.Rows(6).Item("Preço")
        End If
    End Sub
    Private Sub RadButton5_Click(sender As Object, e As EventArgs)
        If Workspace.software_support.Columns.Count <> 2 Then
            Workspace.software_support.Columns.Add("Tipo")
            Workspace.software_support.Columns.Add("Preço")
        End If
        Dim h(1) As Object
        h(0) = ("Instalação S.O")
        h(1) = (caixapreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h(0) = ("Recuperação S.O")
        h(1) = (motherpreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h(0) = ("Remoção Spyware")
        h(1) = (coolerpreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h(0) = ("Remoção Vírus")
        h(1) = (vgapreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h(0) = ("Remoção Cód. S.O")
        h(1) = (opticpreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h(0) = ("Limpeza")
        h(1) = (redepreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h(0) = (otherdescriçaobox.Text)
        h(1) = (otherpreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        Me.Close()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs)
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

    Private Sub caixapreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(caixapreçobox)
    End Sub

    Private Sub motherpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(motherpreçobox)
    End Sub

    Private Sub coolerpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(coolerpreçobox)

    End Sub

    Private Sub VGApreçobox_TextChanged(sender As Object, e As EventArgs)
        ''NumberFormat(VGApreçobox)
    End Sub

    Private Sub opticpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(opticpreçobox)
    End Sub

    Private Sub redepreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(redepreçobox)
    End Sub

    Private Sub otherpreçobox_TextChanged(sender As Object, e As EventArgs)
        'NumberFormat(fontepreçobox)

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

    Private Sub caixapreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles caixapreçobox.TextChanged

    End Sub
End Class