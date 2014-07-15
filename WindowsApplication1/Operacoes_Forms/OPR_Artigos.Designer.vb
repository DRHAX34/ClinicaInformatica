<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RadButton6 = New Telerik.WinControls.UI.RadButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.marcabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.modelobox = New ClinicaInformatica.WaterMarkTextBox()
        Me.numseriebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.observaçoesbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.tipo_componentebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomeclientelabel = New System.Windows.Forms.Label()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(34, 222)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 25)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Observações"
        '
        'RadButton4
        '
        Me.RadButton4.Location = New System.Drawing.Point(402, 364)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(103, 37)
        Me.RadButton4.TabIndex = 51
        Me.RadButton4.Text = "Cancelar"
        Me.RadButton4.ThemeName = "Windows8"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(294, 364)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(103, 37)
        Me.RadButton3.TabIndex = 50
        Me.RadButton3.Text = "Restaurar Dados Originais"
        Me.RadButton3.TextWrap = True
        Me.RadButton3.ThemeName = "Windows8"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(121, 364)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(103, 37)
        Me.RadButton1.TabIndex = 48
        Me.RadButton1.Text = "Editar"
        Me.RadButton1.ThemeName = "Windows8"
        '
        'RadButton5
        '
        Me.RadButton5.Location = New System.Drawing.Point(12, 364)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(103, 37)
        Me.RadButton5.TabIndex = 47
        Me.RadButton5.Text = "Adicionar"
        Me.RadButton5.ThemeName = "Windows8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(96, 9)
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
        Me.Label1.Location = New System.Drawing.Point(33, 106)
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
        'RadButton6
        '
        Me.RadButton6.Location = New System.Drawing.Point(111, 136)
        Me.RadButton6.Name = "RadButton6"
        Me.RadButton6.Size = New System.Drawing.Size(122, 23)
        Me.RadButton6.TabIndex = 60
        Me.RadButton6.Text = "Selecionar Cliente"
        Me.RadButton6.ThemeName = "Windows8"
        '
        'Timer1
        '
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_30101754Hz7aSVUe
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'marcabox
        '
        Me.marcabox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.marcabox.Location = New System.Drawing.Point(39, 188)
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
        Me.numseriebox.Name = "numseriebox"
        Me.numseriebox.Size = New System.Drawing.Size(178, 25)
        Me.numseriebox.TabIndex = 69
        Me.numseriebox.WaterMarkColor = System.Drawing.Color.Gray
        Me.numseriebox.WaterMarkText = "Obrigatório"
        '
        'observaçoesbox
        '
        Me.observaçoesbox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.observaçoesbox.Location = New System.Drawing.Point(39, 250)
        Me.observaçoesbox.Multiline = True
        Me.observaçoesbox.Name = "observaçoesbox"
        Me.observaçoesbox.Size = New System.Drawing.Size(447, 98)
        Me.observaçoesbox.TabIndex = 70
        Me.observaçoesbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.observaçoesbox.WaterMarkText = "Obrigatório"
        '
        'tipo_componentebox
        '
        Me.tipo_componentebox.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.tipo_componentebox.Location = New System.Drawing.Point(308, 134)
        Me.tipo_componentebox.Name = "tipo_componentebox"
        Me.tipo_componentebox.Size = New System.Drawing.Size(178, 25)
        Me.tipo_componentebox.TabIndex = 72
        Me.tipo_componentebox.WaterMarkColor = System.Drawing.Color.Gray
        Me.tipo_componentebox.WaterMarkText = "Obrigatório"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(303, 106)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 25)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "Tipo de Artigo"
        '
        'nomeclientelabel
        '
        Me.nomeclientelabel.AutoSize = True
        Me.nomeclientelabel.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomeclientelabel.Location = New System.Drawing.Point(111, 108)
        Me.nomeclientelabel.MaximumSize = New System.Drawing.Size(200, 25)
        Me.nomeclientelabel.Name = "nomeclientelabel"
        Me.nomeclientelabel.Size = New System.Drawing.Size(143, 21)
        Me.nomeclientelabel.TabIndex = 73
        Me.nomeclientelabel.Text = "Não selecionado!"
        '
        'OPR_Artigos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(523, 411)
        Me.Controls.Add(Me.nomeclientelabel)
        Me.Controls.Add(Me.tipo_componentebox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.observaçoesbox)
        Me.Controls.Add(Me.numseriebox)
        Me.Controls.Add(Me.modelobox)
        Me.Controls.Add(Me.marcabox)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadButton6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.RadButton4)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadButton5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OPR_Artigos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Artigos"
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RadButton6 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents marcabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents modelobox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents numseriebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents observaçoesbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents tipo_componentebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nomeclientelabel As System.Windows.Forms.Label
End Class
