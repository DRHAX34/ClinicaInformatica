<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPR_Dispositivos
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.observaçoesbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.modelobox = New System.Windows.Forms.TextBox()
        Me.numseriebox = New System.Windows.Forms.TextBox()
        Me.marcabox = New System.Windows.Forms.TextBox()
        Me.numbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'observaçoesbox
        '
        Me.observaçoesbox.Enabled = False
        Me.observaçoesbox.Location = New System.Drawing.Point(241, 353)
        Me.observaçoesbox.Multiline = True
        Me.observaçoesbox.Name = "observaçoesbox"
        Me.observaçoesbox.Size = New System.Drawing.Size(345, 114)
        Me.observaçoesbox.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(61, 347)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(124, 25)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Observações"
        '
        'RadButton4
        '
        Me.RadButton4.Location = New System.Drawing.Point(433, 555)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(75, 63)
        Me.RadButton4.TabIndex = 51
        Me.RadButton4.Text = "Cancelar"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(336, 555)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(75, 63)
        Me.RadButton3.TabIndex = 50
        Me.RadButton3.Text = "Restaurar Dados Originais"
        Me.RadButton3.TextWrap = True
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(241, 555)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(75, 63)
        Me.RadButton2.TabIndex = 49
        Me.RadButton2.Text = "Remover"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(146, 555)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(75, 63)
        Me.RadButton1.TabIndex = 48
        Me.RadButton1.Text = "Editar"
        '
        'RadButton5
        '
        Me.RadButton5.Location = New System.Drawing.Point(50, 555)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(75, 63)
        Me.RadButton5.TabIndex = 47
        Me.RadButton5.Text = "Adicionar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(378, 86)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Dispositivos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 241)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Marca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(59, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "NºCliente"
        '
        'modelobox
        '
        Me.modelobox.Location = New System.Drawing.Point(239, 245)
        Me.modelobox.Name = "modelobox"
        Me.modelobox.Size = New System.Drawing.Size(275, 20)
        Me.modelobox.TabIndex = 40
        '
        'numseriebox
        '
        Me.numseriebox.Location = New System.Drawing.Point(239, 298)
        Me.numseriebox.Name = "numseriebox"
        Me.numseriebox.Size = New System.Drawing.Size(192, 20)
        Me.numseriebox.TabIndex = 39
        '
        'marcabox
        '
        Me.marcabox.Location = New System.Drawing.Point(239, 198)
        Me.marcabox.Name = "marcabox"
        Me.marcabox.Size = New System.Drawing.Size(275, 20)
        Me.marcabox.TabIndex = 38
        '
        'numbox
        '
        Me.numbox.Location = New System.Drawing.Point(239, 141)
        Me.numbox.Name = "numbox"
        Me.numbox.Size = New System.Drawing.Size(61, 20)
        Me.numbox.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 294)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "NºSérie"
        '
        'OPR_Dispositivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(613, 632)
        Me.Controls.Add(Me.observaçoesbox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadButton4)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadButton5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.modelobox)
        Me.Controls.Add(Me.numseriebox)
        Me.Controls.Add(Me.marcabox)
        Me.Controls.Add(Me.numbox)
        Me.Controls.Add(Me.Label4)
        Me.Name = "OPR_Dispositivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Dispositivos"
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents observaçoesbox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents modelobox As System.Windows.Forms.TextBox
    Friend WithEvents numseriebox As System.Windows.Forms.TextBox
    Friend WithEvents marcabox As System.Windows.Forms.TextBox
    Friend WithEvents numbox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
