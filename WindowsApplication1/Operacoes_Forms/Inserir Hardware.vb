﻿Public Class Inserir_Hardware
    Public modo As Boolean
    Private Sub Inserir_Hardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AcceptButton = RadButton5
        If modo = False Then
            Workspace.hardware_support = New DataTable
        End If
    End Sub

    Private Sub RadButton5_Click(sender As Object, e As EventArgs) Handles RadButton5.Click
        Dim h As New ArrayList
        Workspace.hardware_support.Columns.Add("Tipo")
        Workspace.hardware_support.Columns.Add("Quantidade")
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


    Private Sub RadButton1_Click(sender As Object, e As EventArgs) Handles RadButton1.Click
        Workspace.hardware_support.Columns.Add("N/A")
        Dim p As New ArrayList
        p.Add("N/A")
        Workspace.hardware_support.Rows.Add(p)
        Me.Close()
    End Sub

    Private Sub caixapreçobox_TextChanged(sender As Object, e As EventArgs) Handles caixapreçobox.TextChanged
        NumberFormat(caixapreçobox)
    End Sub

    Private Sub motherpreçobox_TextChanged(sender As Object, e As EventArgs) Handles motherpreçobox.TextChanged
        NumberFormat(motherpreçobox)
    End Sub

    Private Sub coolerpreçobox_TextChanged(sender As Object, e As EventArgs) Handles coolerpreçobox.TextChanged
        NumberFormat(coolerpreçobox)
    End Sub

    Private Sub VGApreçobox_TextChanged(sender As Object, e As EventArgs) Handles VGApreçobox.TextChanged
        NumberFormat(VGApreçobox)
    End Sub

    Private Sub opticpreçobox_TextChanged(sender As Object, e As EventArgs) Handles opticpreçobox.TextChanged
        NumberFormat(opticpreçobox)
    End Sub

    Private Sub redepreçobox_TextChanged(sender As Object, e As EventArgs) Handles redepreçobox.TextChanged
        NumberFormat(redepreçobox)
    End Sub

    Private Sub fontepreçobox_TextChanged(sender As Object, e As EventArgs) Handles fontepreçobox.TextChanged
        NumberFormat(fontepreçobox)
    End Sub

    Private Sub processadorpreçobox_TextChanged(sender As Object, e As EventArgs) Handles processadorpreçobox.TextChanged
        NumberFormat(processadorpreçobox)
    End Sub

    Private Sub memóriapreçobox_TextChanged(sender As Object, e As EventArgs) Handles memóriapreçobox.TextChanged
        NumberFormat(memóriapreçobox)
    End Sub

    Private Sub discopreçobox_TextChanged(sender As Object, e As EventArgs) Handles discopreçobox.TextChanged
        NumberFormat(discopreçobox)
    End Sub

    Private Sub leitorpreçobox_TextChanged(sender As Object, e As EventArgs) Handles leitorpreçobox.TextChanged
        NumberFormat(leitorpreçobox)
    End Sub

    Private Sub otherpreçobox_TextChanged(sender As Object, e As EventArgs) Handles otherpreçobox.TextChanged
        NumberFormat(otherpreçobox)
    End Sub
End Class