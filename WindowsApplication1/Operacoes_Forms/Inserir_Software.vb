Public Class Inserir_Software
    Public modo As Boolean
    Private Sub Inserir_software_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = RadButton5
        If modo = False Then
            Workspace.hardware_support = New DataTable
        End If
    End Sub
    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim h As New ArrayList
        h.Add("Instalação S.O")
        h.Add(caixapreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Recuperação S.O")
        h.Add(motherpreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Remoção Spyware")
        h.Add(coolerpreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Remoção Vírus")
        h.Add(VGApreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Remoção Cód. S.O")
        h.Add(opticpreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Limpeza")
        h.Add(redepreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        h = New ArrayList
        h.Add(otherdescriçaobox.Text)
        h.Add(otherpreçobox.Text)
        Workspace.software_support.Rows.Add(h)
        Me.Close()
    End Sub

    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
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

    Private Sub caixapreçobox_TextChanged(sender As Object, e As EventArgs) Handles caixapreçobox.TextChanged
        'NumberFormat(caixapreçobox)
    End Sub

    Private Sub motherpreçobox_TextChanged(sender As Object, e As EventArgs) Handles motherpreçobox.TextChanged
        'NumberFormat(motherpreçobox)
    End Sub

    Private Sub coolerpreçobox_TextChanged(sender As Object, e As EventArgs) Handles coolerpreçobox.TextChanged
        'NumberFormat(coolerpreçobox)
        
    End Sub

    Private Sub VGApreçobox_TextChanged(sender As Object, e As EventArgs) Handles vgapreçobox.TextChanged
        ''NumberFormat(VGApreçobox)
    End Sub

    Private Sub opticpreçobox_TextChanged(sender As Object, e As EventArgs) Handles opticpreçobox.TextChanged
        'NumberFormat(opticpreçobox)
    End Sub

    Private Sub redepreçobox_TextChanged(sender As Object, e As EventArgs) Handles redepreçobox.TextChanged
        'NumberFormat(redepreçobox)
    End Sub

    Private Sub otherpreçobox_TextChanged(sender As Object, e As EventArgs) Handles otherpreçobox.TextChanged
        'NumberFormat(fontepreçobox)
        
    End Sub
End Class