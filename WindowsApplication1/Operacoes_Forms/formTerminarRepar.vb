Public Class Inserir_Hardware_desk
    Public modo As Boolean
    Public reparaçao_data As New DataTable
    Public artigos As Integer
    Private check As Boolean
    Private Sub Inserir_Hardware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim certoimagebutton As New Bitmap((My.Resources._1405695721_Select), certobutton.Height, certobutton.Height)
        certoimagebutton.MakeTransparent(Color.White)
        certobutton.Image = certoimagebutton
        Dim exitimagebutton As New Bitmap((My.Resources._1406140864_logout), exitbutton.Height, exitbutton.Height)
        exitimagebutton.MakeTransparent(Color.White)
        exitbutton.Image = exitimagebutton
        If modo = False Then
            caixapreçobox.Text = "0,00"
            motherpreçobox.Text = "0,00"
            coolerqtdbox.Value = "0"
            coolerpreçobox.Text = "0,00"
            vgaqtdbox.Value = "0"
            vgapreçobox.Text = "0,00"
            opticqtdbox.Value = "0"
            opticpreçobox.Text = "0,00"
            redeqtdbox.Value = "0"
            redepreçobox.Text = "0,00"
            fontepreçobox.Text = "0,00"
            processadorpreçobox.Text = "0,00"
            memoriaqtdbox.Value = "0"
            memóriapreçobox.Text = "0,00"
            discoqtdbox.Value = "0"
            discopreçobox.Text = "0,00"
            leitorqtdbox.Value = "0"
            leitorpreçobox.Text = "0,00"
            otherqtdbox.Value = "0"
            otherpreçobox.Text = "0,00"
            otherdescriçaobox.Text = ""
            txtInstOS.Text = "0,00"
            txtCodSO.Text = "0,00"
            txtLimpeza.Text = "0,00"
            txtVirus.Text = "0,00"
            txtSpyware.Text = "0,00"
            txtOtherSO.Text = "0,00"
            txtRecSO.Text = "0,00"
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
            txtInstOS.Text = Workspace.software_support.Rows(0).Item("Preço")
            txtRecSO.Text = Workspace.software_support.Rows(1).Item("Preço")
            txtSpyware.Text = Workspace.software_support.Rows(2).Item("Preço")
            txtVirus.Text = Workspace.software_support.Rows(3).Item("Preço")
            txtCodSO.Text = Workspace.software_support.Rows(4).Item("Preço")
            txtLimpeza.Text = Workspace.software_support.Rows(5).Item("Preço")
            txtDescricaoSO.Text = Workspace.software_support.Rows(6).Item("Tipo")
            txtOtherSO.Text = Workspace.software_support.Rows(6).Item("Preço")
            txtPreço.Text = reparaçao_data.Rows(0).Item("Preço")
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
        Else
            h(1) = 0
        End If
        h(2) = caixapreçobox.Text
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "Motherboard"
        If CDbl(motherpreçobox.Text) <> 0.0 Then
            h(1) = 1
        Else
            h(1) = 0
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
        Else
            h(1) = 0
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
        Me.Close()
    End Sub

    Private Sub caixapreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles caixapreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If caixapreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub motherpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles motherpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If motherpreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub coolerpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles coolerpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If coolerpreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub vgapreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles vgapreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If vgapreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub opticpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles opticpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If opticpreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub redepreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles redepreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If redepreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub fontepreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles fontepreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If fontepreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub processadorpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles processadorpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If processadorpreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub memoriapreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles memóriapreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If memóriapreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub discopreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles discopreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If discopreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub leitorpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles leitorpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If leitorpreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub otherpreçobox_onlynums(sender As Object, e As KeyPressEventArgs) Handles otherpreçobox.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If otherpreçobox.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub txtInstOS_onlynums(sender As Object, e As KeyPressEventArgs) Handles txtInstOS.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If txtInstOS.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub txtRecOS_onlynums(sender As Object, e As KeyPressEventArgs) Handles txtRecSO.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If txtRecSO.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub txtLimpeza_onlynums(sender As Object, e As KeyPressEventArgs) Handles txtLimpeza.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If txtLimpeza.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub txtVirus_onlynums(sender As Object, e As KeyPressEventArgs) Handles txtVirus.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If txtVirus.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub txtSpyware_onlynums(sender As Object, e As KeyPressEventArgs) Handles txtSpyware.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If txtSpyware.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub txtCodOS_onlynums(sender As Object, e As KeyPressEventArgs) Handles txtCodSO.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If txtCodSO.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub txtOtherSO_onlynums(sender As Object, e As KeyPressEventArgs) Handles txtOtherSO.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If txtOtherSO.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub
    Private Sub txtPreço_onlynums(sender As Object, e As KeyPressEventArgs) Handles txtPreço.KeyPress
        Try
            If e.KeyChar <> Microsoft.VisualBasic.Chr(44) And e.KeyChar <> Microsoft.VisualBasic.Chr(46) Then
                If System.Char.IsDigit(e.KeyChar) = False And e.KeyChar <> Microsoft.VisualBasic.Chr(8) Then
                    e.Handled = True
                End If
            Else
                If txtPreço.Text.Contains(",") Then
                    e.Handled = True
                Else
                    e.KeyChar = ","
                End If
            End If
        Catch
        End Try
    End Sub

    Private Sub exitbutton_Click(sender As Object, e As EventArgs) Handles exitbutton.Click
        Me.Close()
    End Sub

    Private Sub caixapreçobox_gotfocus(sender As Object, e As EventArgs) Handles caixapreçobox.GotFocus
        check = False
    End Sub
    Private Sub caixapreçobox_LostFocus(sender As Object, e As EventArgs) Handles caixapreçobox.LostFocus
        If check = False Then
            Try
                caixapreçobox.Text = caixapreçobox.Text.Replace(".", ",")
                caixapreçobox.Text = FormatCurrency(caixapreçobox.Text, 2)
                caixapreçobox.Text = caixapreçobox.Text.Trim("€")
                caixapreçobox.Text = caixapreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception
                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                caixapreçobox.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub txtpreçobox_lostfocus(sender As Object, e As EventArgs) Handles txtPreço.LostFocus
        Try
            txtPreço.Text = txtPreço.Text.Replace(".", ",")
            txtPreço.Text = FormatCurrency(txtPreço.Text, 2)
            txtPreço.Text = txtPreço.Text.Trim("€")
            txtPreço.Text = txtPreço.Text.Trim()
        Catch
            MsgBox("Erro no preço final", MsgBoxStyle.OkOnly, "Erro!")
        End Try
    End Sub
    Private Sub motherpreçobox_gotfocus(sender As Object, e As EventArgs) Handles motherpreçobox.GotFocus
        check = False
    End Sub
    Private Sub motherpreçobox_LostFocus(sender As Object, e As EventArgs) Handles motherpreçobox.LostFocus
        If check = False Then
            Try
                motherpreçobox.Text = motherpreçobox.Text.Replace(".", ",")
                motherpreçobox.Text = FormatCurrency(motherpreçobox.Text, 2)
                motherpreçobox.Text = motherpreçobox.Text.Trim("€")
                motherpreçobox.Text = motherpreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                motherpreçobox.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub coolerpreçobox_gotfocus(sender As Object, e As EventArgs) Handles coolerpreçobox.GotFocus
        check = False
    End Sub
    Private Sub coolerpreçobox_LostFocus(sender As Object, e As EventArgs) Handles coolerpreçobox.LostFocus
        If check = False Then
            Try
                If coolerpreçobox.Text <> "0" And coolerpreçobox.Text <> "0,00" And coolerpreçobox.Text <> FormatCurrency("0,00", 2).Trim("€").Trim() Then
                    If coolerqtdbox.Value = 0 Then
                        coolerqtdbox.Value = 1
                    End If
                End If
                coolerpreçobox.Text = coolerpreçobox.Text.Replace(".", ",")
                coolerpreçobox.Text = FormatCurrency(coolerpreçobox.Text, 2)
                coolerpreçobox.Text = coolerpreçobox.Text.Trim("€")
                coolerpreçobox.Text = coolerpreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                coolerpreçobox.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub vgapreçobox_gotfocus(sender As Object, e As EventArgs) Handles vgapreçobox.GotFocus
        check = False
    End Sub
    Private Sub vgapreçobox_LostFocus(sender As Object, e As EventArgs) Handles vgapreçobox.LostFocus
        If check = False Then
            Try
                If vgapreçobox.Text <> "0" And vgapreçobox.Text <> "0,00" And vgapreçobox.Text <> FormatCurrency("0,00", 2).Trim("€").Trim() Then
                    If vgaqtdbox.Value = 0 Then
                        vgaqtdbox.Value = 1
                    End If
                End If
                vgapreçobox.Text = vgapreçobox.Text.Replace(".", ",")
                vgapreçobox.Text = FormatCurrency(vgapreçobox.Text, 2)
                vgapreçobox.Text = vgapreçobox.Text.Trim("€")
                vgapreçobox.Text = vgapreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                vgapreçobox.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub opticpreçobox_gotfocus(sender As Object, e As EventArgs) Handles opticpreçobox.GotFocus
        check = False
    End Sub
    Private Sub opticpreçobox_LostFocus(sender As Object, e As EventArgs) Handles opticpreçobox.LostFocus
        If check = False Then
            Try
                If opticpreçobox.Text <> "0" And opticpreçobox.Text <> "0,00" And opticpreçobox.Text <> FormatCurrency("0,00", 2).Trim("€").Trim() Then
                    If opticqtdbox.Value = 0 Then
                        opticqtdbox.Value = 1
                    End If
                End If
                opticpreçobox.Text = opticpreçobox.Text.Replace(".", ",")
                opticpreçobox.Text = FormatCurrency(opticpreçobox.Text, 2)
                opticpreçobox.Text = opticpreçobox.Text.Trim("€")
                opticpreçobox.Text = opticpreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                opticpreçobox.Text = "0,00"
            End Try
        End If

    End Sub

    Private Sub redepreçobox_gotfocus(sender As Object, e As EventArgs) Handles redepreçobox.GotFocus
        check = False
    End Sub
    Private Sub redepreçobox_LostFocus(sender As Object, e As EventArgs) Handles redepreçobox.LostFocus
        If check = False Then
            Try
                If redepreçobox.Text <> "0" And redepreçobox.Text <> "0,00" And redepreçobox.Text <> FormatCurrency("0,00", 2).Trim("€").Trim() Then
                    If redeqtdbox.Value = 0 Then
                        redeqtdbox.Value = 1
                    End If
                End If
                redepreçobox.Text = redepreçobox.Text.Replace(".", ",")
                redepreçobox.Text = FormatCurrency(redepreçobox.Text, 2)
                redepreçobox.Text = redepreçobox.Text.Trim("€")
                redepreçobox.Text = redepreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                redepreçobox.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub fontepreçobox_gotfocus(sender As Object, e As EventArgs) Handles fontepreçobox.GotFocus
        check = False
    End Sub
    Private Sub fontepreçobox_LostFocus(sender As Object, e As EventArgs) Handles fontepreçobox.LostFocus
        If check = False Then
            Try
                fontepreçobox.Text = fontepreçobox.Text.Replace(".", ",")
                fontepreçobox.Text = FormatCurrency(fontepreçobox.Text, 2)
                fontepreçobox.Text = fontepreçobox.Text.Trim("€")
                fontepreçobox.Text = fontepreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                fontepreçobox.Text = "0,00"
            End Try
        End If

    End Sub

    Private Sub processadorpreçobox_gotfocus(sender As Object, e As EventArgs) Handles processadorpreçobox.GotFocus
        check = False
    End Sub
    Private Sub processadorpreçobox_LostFocus(sender As Object, e As EventArgs) Handles processadorpreçobox.LostFocus
        If check = False Then
            Try
                If processadorpreçobox.Text <> "0" And processadorpreçobox.Text <> "0,00" And processadorpreçobox.Text <> FormatCurrency("0,00", 2).Trim("€").Trim() Then
                    If processadorqtdbox.Value = 0 Then
                        processadorqtdbox.Value = 1
                    End If
                End If
                processadorpreçobox.Text = processadorpreçobox.Text.Replace(".", ",")
                processadorpreçobox.Text = FormatCurrency(processadorpreçobox.Text, 2)
                processadorpreçobox.Text = processadorpreçobox.Text.Trim("€")
                processadorpreçobox.Text = processadorpreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                processadorpreçobox.Text = "0,00"
            End Try
        End If

    End Sub

    Private Sub memoriapreçobox_gotfocus(sender As Object, e As EventArgs) Handles memóriapreçobox.GotFocus
        check = False
    End Sub
    Private Sub memoriapreçobox_LostFocus(sender As Object, e As EventArgs) Handles memóriapreçobox.LostFocus
        If check = False Then
            Try
                If memóriapreçobox.Text <> "0" And memóriapreçobox.Text <> "0,00" And memóriapreçobox.Text <> FormatCurrency("0,00", 2).Trim("€").Trim() Then
                    If memoriaqtdbox.Value = 0 Then
                        memoriaqtdbox.Value = 1
                    End If
                End If
                memóriapreçobox.Text = memóriapreçobox.Text.Replace(".", ",")
                memóriapreçobox.Text = FormatCurrency(memóriapreçobox.Text, 2)
                memóriapreçobox.Text = memóriapreçobox.Text.Trim("€")
                memóriapreçobox.Text = memóriapreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                memóriapreçobox.Text = "0,00"
            End Try
        End If

    End Sub

    Private Sub discopreçobox_gotfocus(sender As Object, e As EventArgs) Handles discopreçobox.GotFocus
        check = False
    End Sub
    Private Sub discopreçobox_LostFocus(sender As Object, e As EventArgs) Handles discopreçobox.LostFocus
        If check = False Then
            Try
                If discopreçobox.Text <> "0" And discopreçobox.Text <> "0,00" And discopreçobox.Text <> FormatCurrency("0,00", 2).Trim("€").Trim() Then
                    If discoqtdbox.Value = 0 Then
                        discoqtdbox.Value = 1
                    End If
                End If
                discopreçobox.Text = discopreçobox.Text.Replace(".", ",")
                discopreçobox.Text = FormatCurrency(discopreçobox.Text, 2)
                discopreçobox.Text = discopreçobox.Text.Trim("€")
                discopreçobox.Text = discopreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                discopreçobox.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub leitorpreçobox_gotfocus(sender As Object, e As EventArgs) Handles leitorpreçobox.GotFocus
        check = False
    End Sub
    Private Sub leitorpreçobox_LostFocus(sender As Object, e As EventArgs) Handles leitorpreçobox.LostFocus
        If check = False Then
            Try
                If leitorpreçobox.Text <> "0" And leitorpreçobox.Text <> "0,00" And leitorpreçobox.Text <> FormatCurrency("0,00", 2).Trim("€").Trim() Then
                    If leitorqtdbox.Value = 0 Then
                        leitorqtdbox.Value = 1
                    End If
                End If
                leitorpreçobox.Text = leitorpreçobox.Text.Replace(".", ",")
                leitorpreçobox.Text = FormatCurrency(leitorpreçobox.Text, 2)
                leitorpreçobox.Text = leitorpreçobox.Text.Trim("€")
                leitorpreçobox.Text = leitorpreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                leitorpreçobox.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub otherpreçobox_gotfocus(sender As Object, e As EventArgs) Handles otherpreçobox.GotFocus
        check = False
    End Sub
    Private Sub otherpreçobox_LostFocus(sender As Object, e As EventArgs) Handles otherpreçobox.LostFocus
        If check = False Then
            Try
                If otherpreçobox.Text <> "0" And otherpreçobox.Text <> "0,00" And otherpreçobox.Text <> FormatCurrency("0,00", 2).Trim("€").Trim() Then
                    If otherqtdbox.Value = 0 Then
                        otherqtdbox.Value = 1
                    End If
                End If
                otherpreçobox.Text = otherpreçobox.Text.Replace(".", ",")
                otherpreçobox.Text = FormatCurrency(otherpreçobox.Text, 2)
                otherpreçobox.Text = otherpreçobox.Text.Trim("€")
                otherpreçobox.Text = otherpreçobox.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                otherpreçobox.Text = "0,00"
            End Try
        End If

    End Sub

    Private Sub txtInstSO_gotfocus(sender As Object, e As EventArgs) Handles txtInstOS.GotFocus
        check = False
    End Sub
    Private Sub txtInstSO_LostFocus(sender As Object, e As EventArgs) Handles txtInstOS.LostFocus
        If check = False Then
            Try
                txtInstOS.Text = txtInstOS.Text.Replace(".", ",")
                txtInstOS.Text = FormatCurrency(txtInstOS.Text, 2)
                txtInstOS.Text = txtInstOS.Text.Trim("€")
                txtInstOS.Text = txtInstOS.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                txtInstOS.Text = "0,00"
            End Try
        End If

    End Sub

    Private Sub txtRecSO_gotfocus(sender As Object, e As EventArgs) Handles txtRecSO.GotFocus
        check = False
    End Sub
    Private Sub txtRecSO_LostFocus(sender As Object, e As EventArgs) Handles txtRecSO.LostFocus
        If check = False Then
            Try
                txtRecSO.Text = txtRecSO.Text.Replace(".", ",")
                txtRecSO.Text = FormatCurrency(txtRecSO.Text, 2)
                txtRecSO.Text = txtRecSO.Text.Trim("€")
                txtRecSO.Text = txtRecSO.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                txtRecSO.Text = "0,00"
            End Try
        End If

    End Sub

    Private Sub txtSpyware_gotfocus(sender As Object, e As EventArgs) Handles txtSpyware.GotFocus
        check = False
    End Sub
    Private Sub txtSpyware_LostFocus(sender As Object, e As EventArgs) Handles txtSpyware.LostFocus
        If check = False Then
            Try
                txtSpyware.Text = txtSpyware.Text.Replace(".", ",")
                txtSpyware.Text = FormatCurrency(txtSpyware.Text, 2)
                txtSpyware.Text = txtSpyware.Text.Trim("€")
                txtSpyware.Text = txtSpyware.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                txtSpyware.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub txtVirus_gotfocus(sender As Object, e As EventArgs) Handles txtVirus.GotFocus
        check = False
    End Sub
    Private Sub txtVirus_LostFocus(sender As Object, e As EventArgs) Handles txtVirus.LostFocus
        If check = False Then
            Try
                txtVirus.Text = txtVirus.Text.Replace(".", ",")
                txtVirus.Text = FormatCurrency(txtVirus.Text, 2)
                txtVirus.Text = txtVirus.Text.Trim("€")
                txtVirus.Text = txtVirus.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                txtVirus.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub txtCodSO_gotfocus(sender As Object, e As EventArgs) Handles txtCodSO.GotFocus
        check = False
    End Sub
    Private Sub txtCodSO_LostFocus(sender As Object, e As EventArgs) Handles txtCodSO.LostFocus
        If check = False Then
            Try
                txtCodSO.Text = txtCodSO.Text.Replace(".", ",")
                txtCodSO.Text = FormatCurrency(txtCodSO.Text, 2)
                txtCodSO.Text = txtCodSO.Text.Trim("€")
                txtCodSO.Text = txtCodSO.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                txtCodSO.Text = "0,00"
            End Try
        End If

    End Sub
    Private Sub txtLimpeza_gotfocus(sender As Object, e As EventArgs) Handles txtLimpeza.GotFocus
        check = False
    End Sub
    Private Sub txtLimpeza_LostFocus(sender As Object, e As EventArgs) Handles txtLimpeza.LostFocus
        If check = False Then
            Try
                txtLimpeza.Text = txtLimpeza.Text.Replace(".", ",")
                txtLimpeza.Text = FormatCurrency(txtLimpeza.Text, 2)
                txtLimpeza.Text = txtLimpeza.Text.Trim("€")
                txtLimpeza.Text = txtLimpeza.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                txtLimpeza.Text = "0,00"
            End Try
        End If

    End Sub

    Private Sub txtOtherSO_gotfocus(sender As Object, e As EventArgs) Handles txtOtherSO.GotFocus
        check = False
    End Sub
    Private Sub txtOtherSO_LostFocus(sender As Object, e As EventArgs) Handles txtOtherSO.LostFocus
        If check = False Then
            Try
                txtOtherSO.Text = txtOtherSO.Text.Replace(".", ",")
                txtOtherSO.Text = FormatCurrency(txtOtherSO.Text, 2)
                txtOtherSO.Text = txtOtherSO.Text.Trim("€")
                txtOtherSO.Text = txtOtherSO.Text.Trim()
                Try
                    txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
                Catch ex As Exception

                    check = True
                End Try

            Catch
                MsgBox("Insira um valor válido!", MsgBoxStyle.OkOnly, "Valor Inválido!")
                check = True
                txtOtherSO.Text = "0,00"
            End Try
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            txtPreço.Text = CDec(caixapreçobox.Text) + CDec(motherpreçobox.Text) + (coolerqtdbox.Value * CDec(coolerpreçobox.Text)) + (vgaqtdbox.Value * CDec(vgapreçobox.Text)) + (opticqtdbox.Value * CDec(opticpreçobox.Text)) + (redeqtdbox.Value * CDec(redepreçobox.Text)) + CDec(fontepreçobox.Text) + (processadorqtdbox.Value * CDec(processadorpreçobox.Text)) + (discoqtdbox.Value * CDec(discopreçobox.Text)) + (memoriaqtdbox.Value * CDec(memóriapreçobox.Text)) + (leitorqtdbox.Value * CDec(leitorpreçobox.Text)) + (otherqtdbox.Value * CDec(otherpreçobox.Text)) + CDec(txtInstOS.Text) + CDec(txtRecSO.Text) + CDec(txtLimpeza.Text) + CDec(txtCodSO.Text) + CDec(txtSpyware.Text) + CDec(txtVirus.Text) + CDec(txtOtherSO.Text)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub coolerqtdbox_ValueChanged(sender As Object, e As EventArgs) Handles coolerqtdbox.ValueChanged
        Button1.PerformClick()
    End Sub

    Private Sub vgaqtdbox_ValueChanged(sender As Object, e As EventArgs) Handles vgaqtdbox.ValueChanged
        Button1.PerformClick()
    End Sub

    Private Sub opticqtdbox_ValueChanged(sender As Object, e As EventArgs) Handles opticqtdbox.ValueChanged
        Button1.PerformClick()
    End Sub

    Private Sub redeqtdbox_ValueChanged(sender As Object, e As EventArgs) Handles redeqtdbox.ValueChanged
        Button1.PerformClick()
    End Sub

    Private Sub processadorqtdbox_ValueChanged(sender As Object, e As EventArgs) Handles processadorqtdbox.ValueChanged
        Button1.PerformClick()
    End Sub

    Private Sub memoriaqtdbox_ValueChanged(sender As Object, e As EventArgs) Handles memoriaqtdbox.ValueChanged
        Button1.PerformClick()
    End Sub

    Private Sub discoqtdbox_ValueChanged(sender As Object, e As EventArgs) Handles discoqtdbox.ValueChanged
        Button1.PerformClick()
    End Sub

    Private Sub leitorqtdbox_ValueChanged(sender As Object, e As EventArgs) Handles leitorqtdbox.ValueChanged
        Button1.PerformClick()
    End Sub

    Private Sub otherqtdbox_ValueChanged(sender As Object, e As EventArgs) Handles otherqtdbox.ValueChanged
        Button1.PerformClick()
    End Sub
End Class