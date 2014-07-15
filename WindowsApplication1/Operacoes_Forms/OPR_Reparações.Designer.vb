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
        Me.components = New System.ComponentModel.Container()
        Me.descriçaobox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.numcomponentebox = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dateinicio = New System.Windows.Forms.DateTimePicker()
        Me.datefim = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.insert_software = New Telerik.WinControls.UI.RadButton()
        Me.insert_hardware = New Telerik.WinControls.UI.RadButton()
        Me.insert_tecnicos = New Telerik.WinControls.UI.RadButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadButton7 = New Telerik.WinControls.UI.RadButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tempo_real = New System.Windows.Forms.Label()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.showdata = New Telerik.WinControls.UI.RadGridView()
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.preçobox = New System.Windows.Forms.TextBox()
        Me.nomeclientelabel = New System.Windows.Forms.Label()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.insert_software, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.insert_hardware, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.insert_tecnicos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showdata.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'descriçaobox
        '
        Me.descriçaobox.Enabled = False
        Me.descriçaobox.Location = New System.Drawing.Point(49, 294)
        Me.descriçaobox.Multiline = True
        Me.descriçaobox.Name = "descriçaobox"
        Me.descriçaobox.Size = New System.Drawing.Size(473, 117)
        Me.descriçaobox.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(195, 266)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 25)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Descrição da Avaria"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(232, 33)
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
        Me.Label7.Location = New System.Drawing.Point(553, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 25)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Data Inicio"
        '
        'RadButton4
        '
        Me.RadButton4.Location = New System.Drawing.Point(643, 431)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(147, 37)
        Me.RadButton4.TabIndex = 51
        Me.RadButton4.Text = "Cancelar"
        Me.RadButton4.ThemeName = "Windows8"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(476, 431)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(161, 37)
        Me.RadButton3.TabIndex = 50
        Me.RadButton3.Text = "Restaurar Dados Originais"
        Me.RadButton3.TextWrap = True
        Me.RadButton3.ThemeName = "Windows8"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(180, 431)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(146, 37)
        Me.RadButton1.TabIndex = 48
        Me.RadButton1.Text = "Editar"
        Me.RadButton1.ThemeName = "Windows8"
        '
        'RadButton5
        '
        Me.RadButton5.Location = New System.Drawing.Point(36, 431)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(138, 37)
        Me.RadButton5.TabIndex = 47
        Me.RadButton5.Text = "Adicionar"
        Me.RadButton5.ThemeName = "Windows8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(362, 86)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Reparações"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(50, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Artigo:"
        '
        'numcomponentebox
        '
        Me.numcomponentebox.Enabled = False
        Me.numcomponentebox.Location = New System.Drawing.Point(55, 146)
        Me.numcomponentebox.Name = "numcomponentebox"
        Me.numcomponentebox.Size = New System.Drawing.Size(36, 22)
        Me.numcomponentebox.TabIndex = 37
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(553, 118)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 25)
        Me.Label11.TabIndex = 61
        Me.Label11.Text = "Data Fim"
        '
        'dateinicio
        '
        Me.dateinicio.Location = New System.Drawing.Point(558, 41)
        Me.dateinicio.Name = "dateinicio"
        Me.dateinicio.Size = New System.Drawing.Size(232, 22)
        Me.dateinicio.TabIndex = 62
        Me.dateinicio.Value = New Date(2014, 7, 3, 0, 6, 0, 0)
        '
        'datefim
        '
        Me.datefim.Location = New System.Drawing.Point(558, 146)
        Me.datefim.Name = "datefim"
        Me.datefim.Size = New System.Drawing.Size(232, 22)
        Me.datefim.TabIndex = 63
        Me.datefim.Value = New Date(2014, 7, 3, 23, 52, 0, 0)
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.insert_software)
        Me.GroupBox1.Controls.Add(Me.insert_hardware)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(49, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(464, 76)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo"
        '
        'insert_software
        '
        Me.insert_software.Enabled = False
        Me.insert_software.Location = New System.Drawing.Point(340, 28)
        Me.insert_software.Name = "insert_software"
        Me.insert_software.Size = New System.Drawing.Size(105, 34)
        Me.insert_software.TabIndex = 67
        Me.insert_software.Text = "Inserir Software"
        Me.insert_software.ThemeName = "Windows8"
        '
        'insert_hardware
        '
        Me.insert_hardware.Enabled = False
        Me.insert_hardware.Location = New System.Drawing.Point(120, 28)
        Me.insert_hardware.Name = "insert_hardware"
        Me.insert_hardware.Size = New System.Drawing.Size(106, 34)
        Me.insert_hardware.TabIndex = 66
        Me.insert_hardware.Text = "Inserir Hardware"
        Me.insert_hardware.ThemeName = "Windows8"
        '
        'insert_tecnicos
        '
        Me.insert_tecnicos.Location = New System.Drawing.Point(574, 189)
        Me.insert_tecnicos.Name = "insert_tecnicos"
        Me.insert_tecnicos.Size = New System.Drawing.Size(188, 61)
        Me.insert_tecnicos.TabIndex = 65
        Me.insert_tecnicos.Text = "Inserir Técnicos"
        Me.insert_tecnicos.ThemeName = "Windows8"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClinicaInformatica.My.Resources.Resources.repair
        Me.PictureBox1.Location = New System.Drawing.Point(36, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'RadButton7
        '
        Me.RadButton7.Location = New System.Drawing.Point(97, 147)
        Me.RadButton7.Name = "RadButton7"
        Me.RadButton7.Size = New System.Drawing.Size(148, 23)
        Me.RadButton7.TabIndex = 67
        Me.RadButton7.Text = "Selecionar Componente"
        Me.RadButton7.ThemeName = "Windows8"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(411, 118)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 25)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Preço"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(553, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(241, 25)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "Tempo Real da Reparação"
        '
        'tempo_real
        '
        Me.tempo_real.AutoSize = True
        Me.tempo_real.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tempo_real.Location = New System.Drawing.Point(553, 93)
        Me.tempo_real.Name = "tempo_real"
        Me.tempo_real.Size = New System.Drawing.Size(0, 25)
        Me.tempo_real.TabIndex = 77
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'showdata
        '
        Me.showdata.AutoSizeRows = True
        Me.showdata.Location = New System.Drawing.Point(550, 266)
        '
        'showdata
        '
        Me.showdata.MasterTemplate.AllowAddNewRow = False
        Me.showdata.MasterTemplate.AllowColumnResize = False
        Me.showdata.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.showdata.Name = "showdata"
        Me.showdata.Padding = New System.Windows.Forms.Padding(1)
        Me.showdata.ReadOnly = True
        Me.showdata.Size = New System.Drawing.Size(240, 145)
        Me.showdata.TabIndex = 79
        Me.showdata.Text = "Data"
        Me.showdata.ThemeName = "Windows8"
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'preçobox
        '
        Me.preçobox.Enabled = False
        Me.preçobox.Location = New System.Drawing.Point(416, 147)
        Me.preçobox.Name = "preçobox"
        Me.preçobox.Size = New System.Drawing.Size(58, 22)
        Me.preçobox.TabIndex = 80
        '
        'nomeclientelabel
        '
        Me.nomeclientelabel.AutoSize = True
        Me.nomeclientelabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeclientelabel.Location = New System.Drawing.Point(123, 121)
        Me.nomeclientelabel.MaximumSize = New System.Drawing.Size(200, 25)
        Me.nomeclientelabel.Name = "nomeclientelabel"
        Me.nomeclientelabel.Size = New System.Drawing.Size(143, 21)
        Me.nomeclientelabel.TabIndex = 82
        Me.nomeclientelabel.Text = "Não selecionado!"
        '
        'OPR_Reparações
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(812, 474)
        Me.Controls.Add(Me.nomeclientelabel)
        Me.Controls.Add(Me.preçobox)
        Me.Controls.Add(Me.showdata)
        Me.Controls.Add(Me.tempo_real)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RadButton7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.insert_tecnicos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.datefim)
        Me.Controls.Add(Me.dateinicio)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.descriçaobox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RadButton4)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadButton5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numcomponentebox)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "OPR_Reparações"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Reparações"
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.insert_software, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.insert_hardware, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.insert_tecnicos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showdata.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents numcomponentebox As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents dateinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents datefim As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents insert_tecnicos As Telerik.WinControls.UI.RadButton
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadButton7 As Telerik.WinControls.UI.RadButton
    Friend WithEvents insert_software As Telerik.WinControls.UI.RadButton
    Friend WithEvents insert_hardware As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tempo_real As System.Windows.Forms.Label
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents showdata As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents preçobox As System.Windows.Forms.TextBox
    Friend WithEvents nomeclientelabel As System.Windows.Forms.Label
End Class
