﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPR_Artigos
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
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.marcabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.modelobox = New ClinicaInformatica.WaterMarkTextBox()
        Me.numseriebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomeclientelabel = New System.Windows.Forms.Label()
        Me.restartbutton = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.lockbutton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(127, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 86)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Artigos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(137, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Modelo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Marca"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Cliente:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(303, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 25)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "NºSérie"
        '
        'marcabox
        '
        Me.marcabox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.marcabox.Location = New System.Drawing.Point(39, 188)
        Me.marcabox.MaxLength = 15
        Me.marcabox.Name = "marcabox"
        Me.marcabox.Size = New System.Drawing.Size(88, 25)
        Me.marcabox.TabIndex = 67
        Me.marcabox.WaterMarkColor = System.Drawing.Color.Gray
        Me.marcabox.WaterMarkText = "Obrigatório"
        '
        'modelobox
        '
        Me.modelobox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.modelobox.Location = New System.Drawing.Point(142, 188)
        Me.modelobox.MaxLength = 25
        Me.modelobox.Name = "modelobox"
        Me.modelobox.Size = New System.Drawing.Size(151, 25)
        Me.modelobox.TabIndex = 68
        Me.modelobox.WaterMarkColor = System.Drawing.Color.Gray
        Me.modelobox.WaterMarkText = "Obrigatório"
        '
        'numseriebox
        '
        Me.numseriebox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.numseriebox.Location = New System.Drawing.Point(308, 188)
        Me.numseriebox.MaxLength = 30
        Me.numseriebox.Name = "numseriebox"
        Me.numseriebox.Size = New System.Drawing.Size(178, 25)
        Me.numseriebox.TabIndex = 69
        Me.numseriebox.WaterMarkColor = System.Drawing.Color.Gray
        Me.numseriebox.WaterMarkText = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(303, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(142, 25)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Tipo de Artigo"
        '
        'nomeclientelabel
        '
        Me.nomeclientelabel.AutoSize = True
        Me.nomeclientelabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeclientelabel.Location = New System.Drawing.Point(107, 120)
        Me.nomeclientelabel.MaximumSize = New System.Drawing.Size(200, 25)
        Me.nomeclientelabel.Name = "nomeclientelabel"
        Me.nomeclientelabel.Size = New System.Drawing.Size(143, 21)
        Me.nomeclientelabel.TabIndex = 73
        Me.nomeclientelabel.Text = "Não selecionado!"
        '
        'restartbutton
        '
        Me.restartbutton.Location = New System.Drawing.Point(311, 228)
        Me.restartbutton.Name = "restartbutton"
        Me.restartbutton.Size = New System.Drawing.Size(97, 41)
        Me.restartbutton.TabIndex = 98
        Me.restartbutton.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(414, 228)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(97, 41)
        Me.exitbutton.TabIndex = 97
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'savebutton
        '
        Me.savebutton.Location = New System.Drawing.Point(12, 228)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(97, 41)
        Me.savebutton.TabIndex = 95
        Me.savebutton.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Portátil", "Fixo"})
        Me.ComboBox1.Location = New System.Drawing.Point(311, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 99
        '
        'lockbutton
        '
        Me.lockbutton.Location = New System.Drawing.Point(447, 12)
        Me.lockbutton.Name = "lockbutton"
        Me.lockbutton.Size = New System.Drawing.Size(64, 60)
        Me.lockbutton.TabIndex = 100
        Me.lockbutton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClinicaInformatica.My.Resources.Resources.icon_lg_devices
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'OPR_Artigos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(523, 280)
        Me.Controls.Add(Me.lockbutton)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.restartbutton)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.savebutton)
        Me.Controls.Add(Me.nomeclientelabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numseriebox)
        Me.Controls.Add(Me.modelobox)
        Me.Controls.Add(Me.marcabox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OPR_Artigos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Artigos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents marcabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents modelobox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents numseriebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nomeclientelabel As System.Windows.Forms.Label
    Friend WithEvents restartbutton As System.Windows.Forms.Button
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents savebutton As System.Windows.Forms.Button
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents lockbutton As System.Windows.Forms.Button
End Class
