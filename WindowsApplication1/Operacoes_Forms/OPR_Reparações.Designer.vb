<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPR_Reparações
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
        Me.descriçaobox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.categoriabox = New System.Windows.Forms.TextBox()
        Me.temporealbox = New System.Windows.Forms.TextBox()
        Me.numdispositivobox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dateinicio = New System.Windows.Forms.DateTimePicker()
        Me.datefim = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.softwarebox = New System.Windows.Forms.TextBox()
        Me.hardwarebox = New System.Windows.Forms.TextBox()
        Me.RadButton6 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'descriçaobox
        '
        Me.descriçaobox.Enabled = False
        Me.descriçaobox.Location = New System.Drawing.Point(395, 315)
        Me.descriçaobox.Multiline = True
        Me.descriçaobox.Name = "descriçaobox"
        Me.descriçaobox.Size = New System.Drawing.Size(393, 161)
        Me.descriçaobox.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(505, 287)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 25)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Descrição da Avaria"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(6, 88)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(111, 29)
        Me.CheckBox2.TabIndex = 54
        Me.CheckBox2.Text = "Software"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 33)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(119, 29)
        Me.CheckBox1.TabIndex = 53
        Me.CheckBox1.Text = "Hardware"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(617, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 25)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Data Inicio"
        '
        'RadButton4
        '
        Me.RadButton4.Location = New System.Drawing.Point(699, 527)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(75, 63)
        Me.RadButton4.TabIndex = 51
        Me.RadButton4.Text = "Cancelar"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(529, 527)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(75, 63)
        Me.RadButton3.TabIndex = 50
        Me.RadButton3.Text = "Restaurar Dados Originais"
        Me.RadButton3.TextWrap = True
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(361, 527)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(75, 63)
        Me.RadButton2.TabIndex = 49
        Me.RadButton2.Text = "Remover"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(196, 527)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(75, 63)
        Me.RadButton1.TabIndex = 48
        Me.RadButton1.Text = "Editar"
        '
        'RadButton5
        '
        Me.RadButton5.Location = New System.Drawing.Point(32, 527)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(75, 63)
        Me.RadButton5.TabIndex = 47
        Me.RadButton5.Text = "Adicionar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(362, 86)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Reparações"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Categoria"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 127)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "NºDispositivo"
        '
        'categoriabox
        '
        Me.categoriabox.Location = New System.Drawing.Point(196, 188)
        Me.categoriabox.Name = "categoriabox"
        Me.categoriabox.Size = New System.Drawing.Size(275, 22)
        Me.categoriabox.TabIndex = 40
        '
        'temporealbox
        '
        Me.temporealbox.Location = New System.Drawing.Point(196, 242)
        Me.temporealbox.Name = "temporealbox"
        Me.temporealbox.Size = New System.Drawing.Size(142, 22)
        Me.temporealbox.TabIndex = 39
        '
        'numdispositivobox
        '
        Me.numdispositivobox.Location = New System.Drawing.Point(196, 127)
        Me.numdispositivobox.Name = "numdispositivobox"
        Me.numdispositivobox.Size = New System.Drawing.Size(136, 22)
        Me.numdispositivobox.TabIndex = 37
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 237)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tempo-Real"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(617, 162)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 25)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Data Fim"
        '
        'dateinicio
        '
        Me.dateinicio.Location = New System.Drawing.Point(560, 127)
        Me.dateinicio.Name = "dateinicio"
        Me.dateinicio.Size = New System.Drawing.Size(200, 22)
        Me.dateinicio.TabIndex = 62
        '
        'datefim
        '
        Me.datefim.Location = New System.Drawing.Point(560, 190)
        Me.datefim.Name = "datefim"
        Me.datefim.Size = New System.Drawing.Size(200, 22)
        Me.datefim.TabIndex = 63
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.softwarebox)
        Me.GroupBox1.Controls.Add(Me.hardwarebox)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 291)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(270, 150)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'softwarebox
        '
        Me.softwarebox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.softwarebox.Location = New System.Drawing.Point(131, 84)
        Me.softwarebox.Name = "softwarebox"
        Me.softwarebox.Size = New System.Drawing.Size(133, 25)
        Me.softwarebox.TabIndex = 56
        '
        'hardwarebox
        '
        Me.hardwarebox.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hardwarebox.Location = New System.Drawing.Point(131, 33)
        Me.hardwarebox.Name = "hardwarebox"
        Me.hardwarebox.Size = New System.Drawing.Size(133, 25)
        Me.hardwarebox.TabIndex = 55
        '
        'RadButton6
        '
        Me.RadButton6.Location = New System.Drawing.Point(560, 228)
        Me.RadButton6.Name = "RadButton6"
        Me.RadButton6.Size = New System.Drawing.Size(200, 47)
        Me.RadButton6.TabIndex = 65
        Me.RadButton6.Text = "Técnicos Participantes"
        '
        'OPR_Reparações
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(812, 606)
        Me.Controls.Add(Me.RadButton6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datefim)
        Me.Controls.Add(Me.dateinicio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.descriçaobox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RadButton4)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadButton5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.categoriabox)
        Me.Controls.Add(Me.temporealbox)
        Me.Controls.Add(Me.numdispositivobox)
        Me.Controls.Add(Me.Label4)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "OPR_Reparações"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Reparações"
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents descriçaobox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents categoriabox As System.Windows.Forms.TextBox
    Friend WithEvents temporealbox As System.Windows.Forms.TextBox
    Friend WithEvents numdispositivobox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dateinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents datefim As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents softwarebox As System.Windows.Forms.TextBox
    Friend WithEvents hardwarebox As System.Windows.Forms.TextBox
    Friend WithEvents RadButton6 As Telerik.WinControls.UI.RadButton
End Class
