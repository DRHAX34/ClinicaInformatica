Public Class Inserir_Hardware_desk
    Public modo As Boolean
    Public reparaçao_data As New DataTable
    Public artigos As Integer
    Private Sub Inserir_Hardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim certoimagebutton As New Bitmap((My.Resources._1405695721_Select), certobutton.Height, certobutton.Height)
        certoimagebutton.MakeTransparent(Color.White)
        certobutton.Image = certoimagebutton
        Dim exitimagebutton As New Bitmap((My.Resources.Sair), exitbutton.Height, exitbutton.Height)
        exitimagebutton.MakeTransparent(Color.White)
        exitbutton.Image = exitimagebutton
        Me.AcceptButton = certobutton
        If modo = False Then
            caixapreçobox.Text = "0.00"
            motherpreçobox.Text = "0.00"
            coolerqtdbox.Value = "0"
            coolerpreçobox.Text = "0.00"
            vgaqtdbox.Value = "0"
            vgapreçobox.Text = "0.00"
            opticqtdbox.Value = "0"
            opticpreçobox.Text = "0.00"
            redeqtdbox.Value = "0"
            redepreçobox.Text = "0.00"
            fontepreçobox.Text = "0.00"
            processadorpreçobox.Text = "0.00"
            memoriaqtdbox.Value = "0"
            memóriapreçobox.Text = "0.00"
            discoqtdbox.Value = "0"
            discopreçobox.Text = "0.00"
            leitorqtdbox.Value = "0"
            leitorpreçobox.Text = "0.00"
            otherqtdbox.Value = "0"
            otherpreçobox.Text = "0.00"
            otherdescriçaobox.Text = ""
            Workspace.hardware_support = New DataTable
        Else
            caixapreçobox.Text = Workspace.hardware_support.Rows(0).Item("Preço")
            motherpreçobox.Text = Workspace.hardware_support.Rows(1).Item("Preço")
            coolerqtdbox.Value = Workspace.hardware_support.Rows(2).Item("Qtd")
            coolerpreçobox.Text = Workspace.hardware_support.Rows(2).Item("Preço")
            vgaqtdbox.Value = Workspace.hardware_support.Rows(3).Item("Qtd")
            vgapreçobox.Text = Workspace.hardware_support.Rows(3).Item("Preço")
            opticqtdbox.Value = Workspace.hardware_support.Rows(4).Item("Qtd")
            opticpreçobox.Text = Workspace.hardware_support.Rows(4).Item("Preço")
            redeqtdbox.Value = Workspace.hardware_support.Rows(5).Item("Qtd")
            redepreçobox.Text = Workspace.hardware_support.Rows(5).Item("Preço")
            fontepreçobox.Text = Workspace.hardware_support.Rows(6).Item("Preço")
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

    Private Sub certobutton_Click(sender As Object, e As EventArgs) Handles certobutton.Click
        'Try
        '    If caixapreçobox.Text <> "" Then
        '        BLL.Hardware.adicionar_hardware(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), "Caixa", caixapreçobox.Text, 1)
        '    Else
        '        BLL.Hardware.adicionar_hardware(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), "Caixa", caixapreçobox.Text, 0)
        '    End If
        '    If motherpreçobox.Text <> "" Then
        '        BLL.Hardware.adicionar_hardware(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), "Motherboard", motherpreçobox.Text, 1)
        '    Else
        '        BLL.Hardware.adicionar_hardware(reparaçao_data.Rows.Item(0).Item("NºReparação").ToString(), "Motherboard", motherpreçobox.Text, 0)
        '    End If
        'Catch ex As Exception

        'End Try
        Workspace.hardware_support = New DataTable
        Dim h(2) As Object
        If Workspace.hardware_support.Columns.Count <> 3 Then
            Workspace.hardware_support.Columns.Add("Tipo")
            Workspace.hardware_support.Columns.Add("Qtd")
            Workspace.hardware_support.Columns.Add("Preço")
        End If
        h(0) = "Caixa"
        If CDbl(caixapreçobox.Text) <> 0.0 Then
            h(1) = 1
        End If
        h(2) = caixapreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "Motherboard"
        If CDbl(motherpreçobox.Text) <> 0.0 Then
            h(1) = 1
        End If
        h(2) = motherpreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "Cooler"
        h(1) = coolerqtdbox.Value
        h(2) = coolerpreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "VGA"
        h(1) = vgaqtdbox.Value
        h(2) = vgapreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "Unidade Óptica"
        h(1) = opticqtdbox.Value
        h(2) = opticpreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Placa de Rede")
        h(1) = redeqtdbox.Value
        h(2) = redepreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Fonte")
        If CDbl(fontepreçobox.Text) <> 0.0 Then
            h(1) = 1
        End If
        h(2) = fontepreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Processador")
        h(1) = processadorqtdbox.Value
        h(2) = processadorpreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Memória")
        h(1) = memoriaqtdbox.Value
        h(2) = memóriapreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Disco")
        h(1) = discoqtdbox.Value
        h(2) = discopreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Leitor de Cartões")
        h(1) = leitorqtdbox.Value
        h(2) = leitorpreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = otherdescriçaobox.Text
        h(1) = otherqtdbox.Value
        h(2) = otherpreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        Workspace.software_support = New DataTable
        If Workspace.software_support.Columns.Count = 0 Then
            Workspace.software_support.Columns.Add("Tipo")
            Workspace.software_support.Columns.Add("Preço")
        End If
        Dim s(1) As Object
        s(0) = ("Instalação S.O")
        s(1) = txtInstOS.Text
        Workspace.software_support.Rows.Add(s)
        s(0) = ("Recuperação S.O")
        s(1) = txtRecSO.Text
        Workspace.software_support.Rows.Add(s)
        s(0) = ("Remoção Spyware")
        s(1) = txtSpyware.Text
        Workspace.software_support.Rows.Add(s)
        s(0) = ("Remoção Vírus")
        s(1) = txtVirus.Text
        Workspace.software_support.Rows.Add(s)
        s(0) = ("Remoção Cód. S.O")
        s(1) = txtCodSO.Text
        Workspace.software_support.Rows.Add(s)
        s(0) = ("Limpeza")
        s(1) = txtLimpeza.Text
        Workspace.software_support.Rows.Add(s)
        s(0) = txtDescricaoSO.Text
        s(1) = txtOtherSO.Text
        Workspace.software_support.Rows.Add(s)
        BLL.Hardware.delete_hardware(reparaçao_data.Rows(0).Item("NºReparação"))
        BLL.Software.delete_software(reparaçao_data.Rows(0).Item("NºReparação"))
        If modo = False Then
            If Workspace.hardware_support.Columns.Count <> 0 Then
                If Workspace.hardware_support.Rows.Count <> 0 Then
                    For i = 0 To Workspace.hardware_support.Rows.Count - 1
                        BLL.Hardware.adicionar_hardware(reparaçao_data.Rows(0).Item("NºReparação"), Workspace.hardware_support.Rows(i).Item("Tipo").ToString(), Workspace.hardware_support.Rows(i).Item("Preço").ToString, Workspace.hardware_support.Rows(i).Item("Qtd").ToString)
                    Next
                End If
            End If
            If Workspace.software_support.Columns.Count <> 0 Then
                If Workspace.software_support.Rows.Count <> 0 Then
                    For i = 0 To Workspace.software_support.Rows.Count - 1
                        BLL.Software.adicionar_software(reparaçao_data.Rows(0).Item("NºReparação"), Workspace.software_support.Rows(i).Item("Tipo").ToString(), Workspace.software_support.Rows(i).Item("Preço"))
                    Next
                End If
            End If
            BLL.Reparacoes.terminarReparacao(reparaçao_data.Rows(0).Item("NºReparação"), Today.Date, txtPreço.Text)
            folha_repar.MdiParent = Workspace
            folha_repar.n_repar = reparaçao_data.Rows(0).Item(0).ToString()
            folha_repar.artigodata = BLL.Artigos.carregar_dados_numartigo(artigos, True)
            folha_repar.cliente_data = BLL.Clientes.carregar_dados_numcliente(folha_repar.artigodata.Rows(0).Item("NºCliente").ToString(), True)
            folha_repar.Show()
        Else
            If Workspace.hardware_support.Columns.Count <> 0 Then
                If Workspace.hardware_support.Rows.Count <> 0 Then
                    For i = 0 To Workspace.hardware_support.Rows.Count - 1
                        BLL.Hardware.adicionar_hardware(reparaçao_data.Rows(0).Item("NºReparação"), Workspace.hardware_support.Rows(i).Item("Tipo").ToString(), Workspace.hardware_support.Rows(i).Item("Preço").ToString, Workspace.hardware_support.Rows(i).Item("Qtd").ToString)
                    Next
                End If
            End If
            If Workspace.software_support.Columns.Count <> 0 Then
                If Workspace.software_support.Rows.Count <> 0 Then
                    For i = 0 To Workspace.software_support.Rows.Count - 1
                        BLL.Software.adicionar_software(reparaçao_data.Rows(0).Item("NºReparação"), Workspace.software_support.Rows(i).Item("Tipo").ToString(), Workspace.software_support.Rows(i).Item("Preço"))
                    Next
                End If
            End If
            BLL.Reparacoes.alterarReparTerm(reparaçao_data.Rows(0).Item("NºReparação"), txtPreço.Text)
            folha_repar.MdiParent = Workspace
            folha_repar.n_repar = reparaçao_data.Rows(0).Item(0).ToString()
            folha_repar.artigodata = BLL.Artigos.carregar_dados_numartigo(artigos, True)
            folha_repar.cliente_data = BLL.Clientes.carregar_dados_numcliente(folha_repar.artigodata.Rows(0).Item("NºCliente").ToString(), True)
            folha_repar.Show()
        End If
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

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub

    Private Sub caixapreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles caixapreçobox.LostFocus
        Try
            caixapreçobox.Text = caixapreçobox.Text.Replace(",", ".")
            caixapreçobox.Text = FormatCurrency(caixapreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            caixapreçobox.Focus()
        End Try
        
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click

    End Sub

    Private Sub motherpreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles motherpreçobox.LostFocus
        Try
            motherpreçobox.Text = motherpreçobox.Text.Replace(",", ".")
            motherpreçobox.Text = FormatCurrency(motherpreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            motherpreçobox.Focus()
        End Try
    End Sub

    Private Sub coolerpreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles coolerpreçobox.LostFocus
        Try
            If coolerpreçobox.Text <> "0" And coolerpreçobox.Text <> "0.00" And coolerpreçobox.Text <> FormatCurrency("0.00", 2) Then
                If coolerqtdbox.Value = 0 Then
                    coolerqtdbox.Value = 1
                End If
            End If
            coolerpreçobox.Text = coolerpreçobox.Text.Replace(",", ".")
            coolerpreçobox.Text = FormatCurrency(coolerpreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            coolerpreçobox.Focus()
        End Try

    End Sub

    Private Sub vgapreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles vgapreçobox.LostFocus
        Try
            If vgapreçobox.Text <> "0" And vgapreçobox.Text <> "0.00" And vgapreçobox.Text <> FormatCurrency("0.00", 2) Then
                If vgaqtdbox.Value = 0 Then
                    vgaqtdbox.Value = 1
                End If
            End If
            vgapreçobox.Text = vgapreçobox.Text.Replace(",", ".")
            vgapreçobox.Text = FormatCurrency(vgapreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            vgapreçobox.Focus()
        End Try
    End Sub

    Private Sub opticpreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles opticpreçobox.LostFocus
        Try
            If opticpreçobox.Text <> "0" And opticpreçobox.Text <> "0.00" And opticpreçobox.Text <> FormatCurrency("0.00", 2) Then
                If opticqtdbox.Value = 0 Then
                    opticqtdbox.Value = 1
                End If
            End If
            opticpreçobox.Text = opticpreçobox.Text.Replace(",", ".")
            opticpreçobox.Text = FormatCurrency(opticpreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            opticpreçobox.Focus()
        End Try
    End Sub

    Private Sub redepreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles redepreçobox.LostFocus
        Try
            If redepreçobox.Text <> "0" And redepreçobox.Text <> "0.00" And redepreçobox.Text <> FormatCurrency("0.00", 2) Then
                If redeqtdbox.Value = 0 Then
                    redeqtdbox.Value = 1
                End If
            End If
            redepreçobox.Text = redepreçobox.Text.Replace(",", ".")
            redepreçobox.Text = FormatCurrency(redepreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            redepreçobox.Focus()
        End Try
    End Sub

    Private Sub fontepreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles fontepreçobox.LostFocus
        Try
            fontepreçobox.Text = fontepreçobox.Text.Replace(",", ".")
            fontepreçobox.Text = FormatCurrency(fontepreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            fontepreçobox.Focus()
        End Try
    End Sub

    Private Sub processadorpreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles processadorpreçobox.LostFocus
        Try
            If processadorpreçobox.Text <> "0" And processadorpreçobox.Text <> "0.00" And processadorpreçobox.Text <> FormatCurrency("0.00", 2) Then
                If processadorqtdbox.Value = 0 Then
                    processadorqtdbox.Value = 1
                End If
            End If
            processadorpreçobox.Text = processadorpreçobox.Text.Replace(",", ".")
            processadorpreçobox.Text = FormatCurrency(processadorpreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            processadorpreçobox.Focus()
        End Try
    End Sub

    Private Sub memóriapreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles memóriapreçobox.LostFocus
        Try
            If memóriapreçobox.Text <> "0" And memóriapreçobox.Text <> "0.00" And memóriapreçobox.Text <> FormatCurrency("0.00", 2) Then
                If memoriaqtdbox.Value = 0 Then
                    memoriaqtdbox.Value = 1
                End If
            End If
            memóriapreçobox.Text = memóriapreçobox.Text.Replace(",", ".")
            memóriapreçobox.Text = FormatCurrency(memóriapreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            memóriapreçobox.Focus()
        End Try
    End Sub

    Private Sub discopreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles discopreçobox.LostFocus
        Try
            If discopreçobox.Text <> "0" And discopreçobox.Text <> "0.00" And discopreçobox.Text <> FormatCurrency("0.00", 2) Then
                If discoqtdbox.Value = 0 Then
                    discoqtdbox.Value = 1
                End If
            End If
            discopreçobox.Text = discopreçobox.Text.Replace(",", ".")
            discopreçobox.Text = FormatCurrency(discopreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            discopreçobox.Focus()
        End Try
    End Sub

    Private Sub leitorpreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles leitorpreçobox.LostFocus
        Try
            If leitorpreçobox.Text <> "0" And leitorpreçobox.Text <> "0.00" And leitorpreçobox.Text <> FormatCurrency("0.00", 2) Then
                If leitorqtdbox.Value = 0 Then
                    leitorqtdbox.Value = 1
                End If
            End If
            leitorpreçobox.Text = leitorpreçobox.Text.Replace(",", ".")
            leitorpreçobox.Text = FormatCurrency(leitorpreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            leitorpreçobox.Focus()
        End Try
    End Sub

    Private Sub otherpreçobox_TextChanged_1(sender As Object, e As EventArgs) Handles otherpreçobox.LostFocus
        Try
            If otherpreçobox.Text <> "0" And otherpreçobox.Text <> "0.00" And otherpreçobox.Text <> FormatCurrency("0.00", 2) Then
                If otherqtdbox.Value = 0 Then
                    otherqtdbox.Value = 1
                End If
            End If
            otherpreçobox.Text = otherpreçobox.Text.Replace(",", ".")
            otherpreçobox.Text = FormatCurrency(otherpreçobox.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            otherpreçobox.Focus()
        End Try
    End Sub

    Private Sub txtInstOS_TextChanged(sender As Object, e As EventArgs) Handles txtInstOS.LostFocus
        Try
            txtInstOS.Text = txtInstOS.Text.Replace(",", ".")
            txtInstOS.Text = FormatCurrency(txtInstOS.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            txtInstOS.Focus()
        End Try
    End Sub

    Private Sub txtRecSO_TextChanged(sender As Object, e As EventArgs) Handles txtRecSO.LostFocus
        Try
            txtRecSO.Text = txtRecSO.Text.Replace(",", ".")
            txtRecSO.Text = FormatCurrency(txtRecSO.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            txtRecSO.Focus()
        End Try
    End Sub

    Private Sub txtSpyware_TextChanged(sender As Object, e As EventArgs) Handles txtSpyware.LostFocus
        Try
            txtSpyware.Text = txtSpyware.Text.Replace(",", ".")
            txtSpyware.Text = FormatCurrency(txtSpyware.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            txtSpyware.Focus()
        End Try
    End Sub

    Private Sub txtVirus_TextChanged(sender As Object, e As EventArgs) Handles txtVirus.LostFocus
        Try
            txtVirus.Text = txtVirus.Text.Replace(",", ".")
            txtVirus.Text = FormatCurrency(txtVirus.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            txtVirus.Focus()
        End Try
    End Sub

    Private Sub txtCodSO_TextChanged(sender As Object, e As EventArgs) Handles txtCodSO.LostFocus
        Try
            txtCodSO.Text = txtCodSO.Text.Replace(",", ".")
            txtCodSO.Text = FormatCurrency(txtCodSO.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            txtCodSO.Focus()
        End Try
    End Sub

    Private Sub txtLimpeza_TextChanged(sender As Object, e As EventArgs) Handles txtLimpeza.LostFocus
        Try
            txtLimpeza.Text = txtLimpeza.Text.Replace(",", ".")
            txtLimpeza.Text = FormatCurrency(txtLimpeza.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            txtLimpeza.Focus()
        End Try
    End Sub

    Private Sub txtOtherSO_TextChanged(sender As Object, e As EventArgs) Handles txtOtherSO.LostFocus
        Try
            txtOtherSO.Text = txtOtherSO.Text.Replace(",", ".")
            txtOtherSO.Text = FormatCurrency(txtOtherSO.Text, 2)
            Try
                txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
            Catch ex As Exception
                MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
            End Try
        Catch
            MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
            txtOtherSO.Focus()
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
        Catch ex As Exception
            MsgBox("Erro ao gerar preço final", MsgBoxStyle.OkOnly, "Erro!")
        End Try
    End Sub
End Class