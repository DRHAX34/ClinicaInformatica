Public Class Inserir_Hardware
    Public modo As Boolean
    Private Sub Inserir_Hardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = RadButton5
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
            VGApreçobox.Text = Workspace.hardware_support.Rows(3).Item("Preço")
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

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim h As New ArrayList
        Workspace.hardware_support.Columns.Add("Tipo")
        Workspace.hardware_support.Columns.Add("Qtd")
        Workspace.hardware_support.Columns.Add("Preço")
        h.Add("Caixa")
        h.Add(caixaqtdbox.Value)
        h.Add(caixapreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Motherboard")
        h.Add(motherqtdbox.Value)
        h.Add(motherpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Cooler")
        h.Add(coolerqtdbox.Value)
        h.Add(coolerpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add("VGA")
        h.Add(vgaqtdbox.Value)
        h.Add(VGApreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Unidade Óptica")
        h.Add(opticqtdbox.Value)
        h.Add(opticpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Placa de Rede")
        h.Add(redeqtdbox.Value)
        h.Add(redepreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Fonte")
        h.Add(fonteqtdbox.Value)
        h.Add(fontepreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Processador")
        h.Add(processadorqtdbox.Value)
        h.Add(processadorpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Memória")
        h.Add(memoriaqtdbox.Value)
        h.Add(memóriapreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add("Disco")
        h.Add(discoqtdbox.Value)
        h.Add(discopreçobox.Text)
        h.Add("Leitor de Cartões")
        h.Add(leitorqtdbox.Value)
        h.Add(leitorpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h = New ArrayList
        h.Add(otherdescriçaobox.Text)
        h.Add(otherqtdbox.Value)
        h.Add(otherpreçobox.Text)
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


    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Workspace.hardware_support.Columns.Add("N/A")
        Dim p As New ArrayList
        p.Add("N/A")
        Workspace.hardware_support.Rows.Add(p)
        Me.Close()
    End Sub

    Private Sub caixapreçobox_TextChanged(sender As Object, e As EventArgs) Handles caixapreçobox.TextChanged
        'NumberFormat(caixapreçobox)
        caixapreçoivalabel.Text = CDbl(caixapreçobox.Text) + ((CDbl(caixapreçobox.Text) * 23) / 100)
    End Sub

    Private Sub motherpreçobox_TextChanged(sender As Object, e As EventArgs) Handles motherpreçobox.TextChanged
        'NumberFormat(motherpreçobox)
        motherpreçoivalabel.Text = CDbl(motherpreçobox.Text) + ((CDbl(motherpreçobox.Text) * 23) / 100)
    End Sub

    Private Sub coolerpreçobox_TextChanged(sender As Object, e As EventArgs) Handles coolerpreçobox.TextChanged
        'NumberFormat(coolerpreçobox)
        coolerpreçoivalabel.Text = CDbl(coolerpreçobox.Text) + ((CDbl(coolerpreçobox.Text) * 23) / 100)
    End Sub

    Private Sub VGApreçobox_TextChanged(sender As Object, e As EventArgs) Handles VGApreçobox.TextChanged
        ''NumberFormat(VGApreçobox)
        vgapreçoivalabel.Text = CDbl(VGApreçobox.Text) + ((CDbl(VGApreçobox.Text) * 23) / 100)
    End Sub

    Private Sub opticpreçobox_TextChanged(sender As Object, e As EventArgs) Handles opticpreçobox.TextChanged
        'NumberFormat(opticpreçobox)
        opticpreçoivalabel.Text = CDbl(opticpreçobox.Text) + ((CDbl(opticpreçobox.Text) * 23) / 100)
    End Sub

    Private Sub redepreçobox_TextChanged(sender As Object, e As EventArgs) Handles redepreçobox.TextChanged
        'NumberFormat(redepreçobox)
        redepreçoivalabel.Text = CDbl(redepreçobox.Text) + ((CDbl(redepreçobox.Text) * 23) / 100)
    End Sub

    Private Sub fontepreçobox_TextChanged(sender As Object, e As EventArgs) Handles fontepreçobox.TextChanged
        'NumberFormat(fontepreçobox)
        fontepreçoivalabel.Text = CDbl(fontepreçobox.Text) + ((CDbl(fontepreçobox.Text) * 23) / 100)
    End Sub

    Private Sub processadorpreçobox_TextChanged(sender As Object, e As EventArgs) Handles processadorpreçobox.TextChanged
        'NumberFormat(processadorpreçobox)
        processadorpreçoivalabel.Text = CDbl(processadorpreçobox.Text) + ((CDbl(processadorpreçobox.Text) * 23) / 100)
    End Sub

    Private Sub memóriapreçobox_TextChanged(sender As Object, e As EventArgs) Handles memóriapreçobox.TextChanged
        'NumberFormat(memóriapreçobox)
        memoriapreçoivalabel.Text = CDbl(memóriapreçobox.Text) + ((CDbl(memóriapreçobox.Text) * 23) / 100)
    End Sub

    Private Sub discopreçobox_TextChanged(sender As Object, e As EventArgs) Handles discopreçobox.TextChanged
        'NumberFormat(discopreçobox)
        discopreçoivalabel.Text = CDbl(discopreçobox.Text) + ((CDbl(discopreçobox.Text) * 23) / 100)
    End Sub

    Private Sub leitorpreçobox_TextChanged(sender As Object, e As EventArgs) Handles leitorpreçobox.TextChanged
        'NumberFormat(leitorpreçobox)
        leitorpreçoivalabel.Text = CDbl(leitorpreçobox.Text) + ((CDbl(leitorpreçobox.Text) * 23) / 100)
    End Sub

    Private Sub otherpreçobox_TextChanged(sender As Object, e As EventArgs) Handles otherpreçobox.TextChanged
        'NumberFormat(otherpreçobox)
        otherpreçoivalabel.Text = CDbl(otherpreçobox.Text) + ((CDbl(otherpreçobox.Text) * 23) / 100)
    End Sub
End Class