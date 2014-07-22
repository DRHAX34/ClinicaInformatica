<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPR_Empresas
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.caminhobox = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.logobox = New System.Windows.Forms.PictureBox()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.restartbutton = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.logobutton = New System.Windows.Forms.Button()
        Me.sitebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.emailbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.contactofixbox = New ClinicaInformatica.MaskedWaterMarkTextBox()
        Me.contactofixlabel = New System.Windows.Forms.Label()
        Me.naocheck = New System.Windows.Forms.RadioButton()
        Me.simcheck = New System.Windows.Forms.RadioButton()
        Me.nifbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.cod_postalbox = New ClinicaInformatica.MaskedWaterMarkTextBox()
        Me.localidadebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.moradabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.nomebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.alunoslabel = New System.Windows.Forms.Label()
        Me.Localidadelabel = New System.Windows.Forms.Label()
        Me.cod_postallabel = New System.Windows.Forms.Label()
        Me.moradalabel = New System.Windows.Forms.Label()
        Me.nomelabel = New System.Windows.Forms.Label()
        Me.niflabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.logobox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(304, 86)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Empresas"
        '
        'caminhobox
        '
        Me.caminhobox.Location = New System.Drawing.Point(506, 287)
        Me.caminhobox.Name = "caminhobox"
        Me.caminhobox.Size = New System.Drawing.Size(103, 20)
        Me.caminhobox.TabIndex = 61
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClinicaInformatica.My.Resources.Resources.company
        Me.PictureBox1.Location = New System.Drawing.Point(36, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'logobox
        '
        Me.logobox.Location = New System.Drawing.Point(506, 140)
        Me.logobox.Name = "logobox"
        Me.logobox.Size = New System.Drawing.Size(141, 141)
        Me.logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logobox.TabIndex = 59
        Me.logobox.TabStop = False
        '
        'savebutton
        '
        Me.savebutton.Location = New System.Drawing.Point(36, 417)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(113, 44)
        Me.savebutton.TabIndex = 71
        Me.savebutton.UseVisualStyleBackColor = True
        '
        'restartbutton
        '
        Me.restartbutton.Location = New System.Drawing.Point(415, 420)
        Me.restartbutton.Name = "restartbutton"
        Me.restartbutton.Size = New System.Drawing.Size(113, 44)
        Me.restartbutton.TabIndex = 72
        Me.restartbutton.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(534, 420)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(113, 44)
        Me.exitbutton.TabIndex = 73
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'logobutton
        '
        Me.logobutton.Location = New System.Drawing.Point(615, 284)
        Me.logobutton.Name = "logobutton"
        Me.logobutton.Size = New System.Drawing.Size(32, 21)
        Me.logobutton.TabIndex = 74
        Me.logobutton.Text = "..."
        Me.logobutton.UseVisualStyleBackColor = True
        '
        'sitebox
        '
        Me.sitebox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.sitebox.Location = New System.Drawing.Point(35, 359)
        Me.sitebox.MaxLength = 9
        Me.sitebox.Name = "sitebox"
        Me.sitebox.Size = New System.Drawing.Size(183, 27)
        Me.sitebox.TabIndex = 104
        Me.sitebox.Text = "Website"
        Me.sitebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.sitebox.WaterMarkText = "Site"
        '
        'emailbox
        '
        Me.emailbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailbox.Location = New System.Drawing.Point(35, 304)
        Me.emailbox.MaxLength = 9
        Me.emailbox.Name = "emailbox"
        Me.emailbox.Size = New System.Drawing.Size(184, 27)
        Me.emailbox.TabIndex = 103
        Me.emailbox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.emailbox.WaterMarkText = "Email"
        '
        'contactofixbox
        '
        Me.contactofixbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.contactofixbox.Location = New System.Drawing.Point(235, 252)
        Me.contactofixbox.Mask = "+0000000000000"
        Me.contactofixbox.Name = "contactofixbox"
        Me.contactofixbox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.contactofixbox.Size = New System.Drawing.Size(110, 27)
        Me.contactofixbox.TabIndex = 102
        Me.contactofixbox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.contactofixbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.contactofixbox.WaterMarkText = "Contacto Fixo"
        '
        'contactofixlabel
        '
        Me.contactofixlabel.AutoSize = True
        Me.contactofixlabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.contactofixlabel.Location = New System.Drawing.Point(231, 228)
        Me.contactofixlabel.Name = "contactofixlabel"
        Me.contactofixlabel.Size = New System.Drawing.Size(100, 20)
        Me.contactofixlabel.TabIndex = 101
        Me.contactofixlabel.Text = "Contacto Fixo"
        '
        'naocheck
        '
        Me.naocheck.AutoSize = True
        Me.naocheck.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.naocheck.Location = New System.Drawing.Point(288, 306)
        Me.naocheck.Name = "naocheck"
        Me.naocheck.Size = New System.Drawing.Size(51, 21)
        Me.naocheck.TabIndex = 100
        Me.naocheck.TabStop = True
        Me.naocheck.Text = "Não"
        Me.naocheck.UseVisualStyleBackColor = True
        '
        'simcheck
        '
        Me.simcheck.AutoSize = True
        Me.simcheck.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.simcheck.Location = New System.Drawing.Point(235, 306)
        Me.simcheck.Name = "simcheck"
        Me.simcheck.Size = New System.Drawing.Size(47, 21)
        Me.simcheck.TabIndex = 99
        Me.simcheck.TabStop = True
        Me.simcheck.Text = "Sim"
        Me.simcheck.UseVisualStyleBackColor = True
        '
        'nifbox
        '
        Me.nifbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nifbox.Location = New System.Drawing.Point(35, 252)
        Me.nifbox.MaxLength = 9
        Me.nifbox.Name = "nifbox"
        Me.nifbox.Size = New System.Drawing.Size(119, 27)
        Me.nifbox.TabIndex = 98
        Me.nifbox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.nifbox.WaterMarkText = "NIF"
        '
        'cod_postalbox
        '
        Me.cod_postalbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cod_postalbox.Location = New System.Drawing.Point(235, 193)
        Me.cod_postalbox.Mask = "0000-000"
        Me.cod_postalbox.Name = "cod_postalbox"
        Me.cod_postalbox.Size = New System.Drawing.Size(107, 27)
        Me.cod_postalbox.TabIndex = 97
        Me.cod_postalbox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.cod_postalbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.cod_postalbox.WaterMarkText = "Código Postal"
        '
        'localidadebox
        '
        Me.localidadebox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.localidadebox.Location = New System.Drawing.Point(35, 193)
        Me.localidadebox.Name = "localidadebox"
        Me.localidadebox.Size = New System.Drawing.Size(119, 27)
        Me.localidadebox.TabIndex = 96
        Me.localidadebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.localidadebox.WaterMarkText = "Localidade"
        '
        'moradabox
        '
        Me.moradabox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moradabox.Location = New System.Drawing.Point(235, 140)
        Me.moradabox.Name = "moradabox"
        Me.moradabox.Size = New System.Drawing.Size(183, 27)
        Me.moradabox.TabIndex = 95
        Me.moradabox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.moradabox.WaterMarkText = "Morada"
        '
        'nomebox
        '
        Me.nomebox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomebox.Location = New System.Drawing.Point(36, 140)
        Me.nomebox.Name = "nomebox"
        Me.nomebox.Size = New System.Drawing.Size(183, 27)
        Me.nomebox.TabIndex = 94
        Me.nomebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.nomebox.WaterMarkText = "Nome da Empresa"
        '
        'alunoslabel
        '
        Me.alunoslabel.AutoSize = True
        Me.alunoslabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.alunoslabel.Location = New System.Drawing.Point(231, 282)
        Me.alunoslabel.Name = "alunoslabel"
        Me.alunoslabel.Size = New System.Drawing.Size(94, 20)
        Me.alunoslabel.TabIndex = 93
        Me.alunoslabel.Text = "Tem Alunos?"
        '
        'Localidadelabel
        '
        Me.Localidadelabel.AutoSize = True
        Me.Localidadelabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Localidadelabel.Location = New System.Drawing.Point(32, 170)
        Me.Localidadelabel.Name = "Localidadelabel"
        Me.Localidadelabel.Size = New System.Drawing.Size(82, 20)
        Me.Localidadelabel.TabIndex = 92
        Me.Localidadelabel.Text = "Localidade"
        '
        'cod_postallabel
        '
        Me.cod_postallabel.AutoSize = True
        Me.cod_postallabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cod_postallabel.Location = New System.Drawing.Point(231, 170)
        Me.cod_postallabel.Name = "cod_postallabel"
        Me.cod_postallabel.Size = New System.Drawing.Size(102, 20)
        Me.cod_postallabel.TabIndex = 91
        Me.cod_postallabel.Text = "Código Postal"
        '
        'moradalabel
        '
        Me.moradalabel.AutoSize = True
        Me.moradalabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.moradalabel.Location = New System.Drawing.Point(231, 117)
        Me.moradalabel.Name = "moradalabel"
        Me.moradalabel.Size = New System.Drawing.Size(61, 20)
        Me.moradalabel.TabIndex = 90
        Me.moradalabel.Text = "Morada"
        '
        'nomelabel
        '
        Me.nomelabel.AutoSize = True
        Me.nomelabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.nomelabel.Location = New System.Drawing.Point(32, 117)
        Me.nomelabel.Name = "nomelabel"
        Me.nomelabel.Size = New System.Drawing.Size(50, 20)
        Me.nomelabel.TabIndex = 89
        Me.nomelabel.Text = "Nome"
        '
        'niflabel
        '
        Me.niflabel.AutoSize = True
        Me.niflabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.niflabel.Location = New System.Drawing.Point(32, 229)
        Me.niflabel.Name = "niflabel"
        Me.niflabel.Size = New System.Drawing.Size(37, 20)
        Me.niflabel.TabIndex = 105
        Me.niflabel.Text = "NIF*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(31, 281)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 20)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(31, 336)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Website"
        '
        'OPR_Empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(682, 476)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.niflabel)
        Me.Controls.Add(Me.sitebox)
        Me.Controls.Add(Me.emailbox)
        Me.Controls.Add(Me.contactofixbox)
        Me.Controls.Add(Me.contactofixlabel)
        Me.Controls.Add(Me.naocheck)
        Me.Controls.Add(Me.simcheck)
        Me.Controls.Add(Me.nifbox)
        Me.Controls.Add(Me.cod_postalbox)
        Me.Controls.Add(Me.localidadebox)
        Me.Controls.Add(Me.moradabox)
        Me.Controls.Add(Me.nomebox)
        Me.Controls.Add(Me.alunoslabel)
        Me.Controls.Add(Me.Localidadelabel)
        Me.Controls.Add(Me.cod_postallabel)
        Me.Controls.Add(Me.moradalabel)
        Me.Controls.Add(Me.nomelabel)
        Me.Controls.Add(Me.logobutton)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.restartbutton)
        Me.Controls.Add(Me.savebutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.caminhobox)
        Me.Controls.Add(Me.logobox)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OPR_Empresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Clientes"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.logobox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents caminhobox As System.Windows.Forms.TextBox
    Friend WithEvents logobox As System.Windows.Forms.PictureBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents savebutton As System.Windows.Forms.Button
    Friend WithEvents restartbutton As System.Windows.Forms.Button
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents logobutton As System.Windows.Forms.Button
    Friend WithEvents sitebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents emailbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents contactofixbox As ClinicaInformatica.MaskedWaterMarkTextBox
    Friend WithEvents contactofixlabel As System.Windows.Forms.Label
    Friend WithEvents naocheck As System.Windows.Forms.RadioButton
    Friend WithEvents simcheck As System.Windows.Forms.RadioButton
    Friend WithEvents nifbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents cod_postalbox As ClinicaInformatica.MaskedWaterMarkTextBox
    Friend WithEvents localidadebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents moradabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents nomebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents alunoslabel As System.Windows.Forms.Label
    Friend WithEvents Localidadelabel As System.Windows.Forms.Label
    Friend WithEvents cod_postallabel As System.Windows.Forms.Label
    Friend WithEvents moradalabel As System.Windows.Forms.Label
    Friend WithEvents nomelabel As System.Windows.Forms.Label
    Friend WithEvents niflabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
