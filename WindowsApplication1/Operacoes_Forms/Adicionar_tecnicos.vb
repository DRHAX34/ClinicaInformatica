<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adicionar_tecnicos
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub
    Friend WithEvents Adicionar As Telerik.WinControls.UI.RadButton
    Friend WithEvents button1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents button2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents button3 As Telerik.WinControls.UI.RadButton

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Adicionar = New Telerik.WinControls.UI.RadButton()
        Me.button1 = New Telerik.WinControls.UI.RadButton()
        Me.button2 = New Telerik.WinControls.UI.RadButton()
        Me.button3 = New Telerik.WinControls.UI.RadButton()
        CType(Me.Adicionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.button1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.button2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.button3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(12, 36)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(230, 342)
        Me.ListBox1.Sorted = True
        Me.ListBox1.TabIndex = 0
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(371, 36)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(230, 342)
        Me.ListBox2.Sorted = True
        Me.ListBox2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Adicionar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Remover"
        '
        'Adicionar
        '
        Me.Adicionar.Location = New System.Drawing.Point(272, 119)
        Me.Adicionar.Name = "Adicionar"
        Me.Adicionar.Size = New System.Drawing.Size(72, 22)
        Me.Adicionar.TabIndex = 22
        Me.Adicionar.Text = ">>"
        '
        'button1
        '
        Me.button1.Location = New System.Drawing.Point(272, 217)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(72, 22)
        Me.button1.TabIndex = 22
        Me.button1.Text = "<<"
        '
        'button2
        '
        Me.button2.Location = New System.Drawing.Point(400, 400)
        Me.button2.Name = "button2"
        Me.button2.Size = New System.Drawing.Size(106, 34)
        Me.button2.TabIndex = 22
        Me.button2.Text = "Adicionar"
        '
        'button3
        '
        Me.button3.Location = New System.Drawing.Point(512, 400)
        Me.button3.Name = "button3"
        Me.button3.Size = New System.Drawing.Size(89, 34)
        Me.button3.TabIndex = 22
        Me.button3.Text = "Cancelar"
        '
        'Adicionar_tecnicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(613, 446)
        Me.Controls.Add(Me.button3)
        Me.Controls.Add(Me.button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.Adicionar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Adicionar_tecnicos"
        Me.Text = "Adicionar Peças"
        CType(Me.Adicionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.button1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.button2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.button3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class

Public Class Adicionar_tecnicos
    Public indexes(199) As String
    Public datatable As New DataTable
    Private Sub Adicionar_tecnicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To ((BLL.Tecnicos.carregar_tecnico).Rows.Count - 1)
            If i <> 9 Then
                ListBox1.Items.Add("0" & ((BLL.Tecnicos.carregar_tecnico).Rows(i).Item("NºTécnico").ToString) & " . " & ((BLL.Tecnicos.carregar_tecnico).Rows(i).Item("Tipo").ToString) & " " & ((BLL.Tecnicos.carregar_tecnico).Rows(i).Item("Marca").ToString))
            Else
                ListBox1.Items.Add(((BLL.Tecnicos.carregar_tecnico).Rows(i).Item("NºTécnico").ToString) & " . " & ((BLL.Tecnicos.carregar_tecnico).Rows(i).Item("Tipo").ToString) & " " & ((BLL.Tecnicos.carregar_tecnico).Rows(i).Item("Marca").ToString))
            End If
        Next
        ListBox1.SelectedIndex = 0
        Button1.Enabled = False
    End Sub

    Private Sub Adicionar_Click(sender As Object, e As EventArgs) Handles Adicionar.Click

        ListBox2.Items.Add(ListBox1.SelectedItem)
        ListBox2.SelectedIndex = 0
        ListBox1.Items.Remove(ListBox1.SelectedItem)
        If ListBox1.Items.Count <> 0 Then
            ListBox1.SelectedIndex = 0
        Else
            Adicionar.Enabled = False
        End If
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ListBox1.Items.Add(ListBox2.SelectedItem)
        ListBox2.Items.Remove(ListBox2.SelectedItem)
        If ListBox2.Items.Count <> 0 Then
            ListBox2.SelectedIndex = 0
        Else
            Button1.Enabled = False
        End If
        Adicionar.Enabled = True
    End Sub


    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim datatable1 As New DataTable
        datatable1.Columns.Add("NºTécnico")
        datatable1.Columns.Add("Nome")
        Me.Hide()
        If ListBox2.Items.Count <> 0 Then
            For i = 0 To ListBox2.Items.Count - 1
                ListBox2.SelectedIndex = i
                If ListBox2.SelectedItem.ToString.Chars(0) <> "0" Then
                    If i < 99 Then
                        datatable1.ImportRow(BLL.Tecnicos.procura_dados_ntecnico_ativados(ListBox2.SelectedItem.ToString.Chars(0) & ListBox2.SelectedItem.ToString.Chars(1)).Rows(0))
                    ElseIf i < 9999 Then
                        datatable1.ImportRow(BLL.Tecnicos.procura_dados_ntecnico_ativados(ListBox2.SelectedItem.ToString.Chars(0) & ListBox2.SelectedItem.ToString.Chars(1) & ListBox1.SelectedItem.ToString.Chars(2) & ListBox1.SelectedItem.ToString.Chars(3)).Rows(0))
                    End If
                Else
                    datatable1.ImportRow(BLL.Tecnicos.procura_dados_ntecnico_ativados(ListBox2.SelectedItem.ToString.Chars(1)).Rows(0))
                End If
            Next
            datatable = datatable1
            Workspace.tecnicos_support = datatable1
            Me.Close()
        Else
            MsgBox("Introduza algum Técnico para guardar")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
End Class