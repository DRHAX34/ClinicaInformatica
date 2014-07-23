Public Class Inserir_Hardware_port
    Public modo As Boolean
    Private Sub Inserir_Hardware_port_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim certoimagebutton As New Bitmap((My.Resources._1405695721_Select), certobutton.Height, certobutton.Height)
        certobutton.Image = certoimagebutton
        Dim exitimagebutton As New Bitmap((My.Resources.Sair), exitbutton.Height, exitbutton.Height)
        exitbutton.Image = exitimagebutton
        Me.AcceptButton = certobutton
        If modo = False Then
            Workspace.hardware_support = New DataTable
        Else
            lcdpreçobox.Text = Workspace.hardware_support.Rows(0).Item("Preço")
            motherpreçobox.Text = Workspace.hardware_support.Rows(1).Item("Preço")
            coolerqtdbox.Value = Workspace.hardware_support.Rows(2).Item("Qtd")
            coolerpreçobox.Text = Workspace.hardware_support.Rows(2).Item("Preço")
            vgaqtdbox.Value = Workspace.hardware_support.Rows(3).Item("Qtd")
            vgapreçobox.Text = Workspace.hardware_support.Rows(3).Item("Preço")
            opticpreçobox.Text = Workspace.hardware_support.Rows(4).Item("Preço")
            touchpadpreçobox.Text = Workspace.hardware_support.Rows(5).Item("Preço")
            tecladopreçobox.Text = Workspace.hardware_support.Rows(6).Item("Preço")
            usbqtdbox.Text = Workspace.hardware_support.Rows(6).Item("Qtd")
            usbpreçobox.Text = Workspace.hardware_support.Rows(6).Item("Preço")
            carregadorpreçobox.Text = Workspace.hardware_support.Rows(6).Item("Preço")
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
        Dim h(2) As Object
        If Workspace.hardware_support.Columns.Count <> 3 Then
            Workspace.hardware_support.Columns.Add("Tipo")
            Workspace.hardware_support.Columns.Add("Qtd")
            Workspace.hardware_support.Columns.Add("Preço")
        End If
        h(0) = "LCD"
        If lcdpreçobox.Text <> "" Then
            h(1) = 1
        Else
            h(1) = 0
        End If
        h(2) = (lcdpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "Motherboard"
        If motherpreçobox.Text <> "" Then
            h(1) = 1
        Else
            h(1) = 0
        End If
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
        If opticpreçobox.Text <> "" Then
            h(1) = 1
        Else
            h(1) = 0
        End If
        h(2) = (opticpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Touchpad")
        If touchpadpreçobox.Text <> 0 Then
            h(1) = 1
        Else
            h(1) = 0
        End If
        h(2) = (touchpadpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Teclado")
        If tecladopreçobox.Text <> "" Then
            h(1) = 1
        Else
            h(1) = 0
        End If
        h(2) = (tecladopreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = "USB"
        h(1) = coolerqtdbox.Value
        h(2) = (coolerpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Carregador A/C")
        If carregadorpreçobox.Text <> "" Then
            h(1) = 1
        Else
            h(1) = 0
        End If
        h(2) = (carregadorpreçobox.Text)
        Workspace.hardware_support.Rows.Add(h)
        h(0) = ("Processador")
        If processadorpreçobox.Text <> "" Then
            h(1) = 1
        Else
            h(1) = 0
        End If
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
End Class