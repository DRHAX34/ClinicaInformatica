<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPR_Técnicos
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
        Me.turmalabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numalunolabel = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Localidadelabel = New System.Windows.Forms.Label()
        Me.cod_postallabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.imagembox = New System.Windows.Forms.PictureBox()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.contactom_box = New ClinicaInformatica.MaskedWaterMarkTextBox()
        Me.contacto_fbox = New ClinicaInformatica.MaskedWaterMarkTextBox()
        Me.nomebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.numalunobox = New ClinicaInformatica.WaterMarkTextBox()
        Me.turmabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.localidadebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.cod_postalbox = New ClinicaInformatica.MaskedWaterMarkTextBox()
        Me.caminhobox = New ClinicaInformatica.WaterMarkTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.respostabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.perguntabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.verifbox = New System.Windows.Forms.TextBox()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.nomeutilizadorbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.restartbutton = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.reparaçoesefetuadasbutton = New System.Windows.Forms.Button()
        Me.logobutton = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imagembox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(108, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(281, 86)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Técnicos"
        '
        'turmalabel
        '
        Me.turmalabel.AutoSize = True
        Me.turmalabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.turmalabel.Location = New System.Drawing.Point(371, 122)
        Me.turmalabel.Name = "turmalabel"
        Me.turmalabel.Size = New System.Drawing.Size(70, 25)
        Me.turmalabel.TabIndex = 43
        Me.turmalabel.Text = "Turma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nome"
        '
        'numalunolabel
        '
        Me.numalunolabel.AutoSize = True
        Me.numalunolabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numalunolabel.Location = New System.Drawing.Point(241, 122)
        Me.numalunolabel.Name = "numalunolabel"
        Me.numalunolabel.Size = New System.Drawing.Size(90, 25)
        Me.numalunolabel.TabIndex = 41
        Me.numalunolabel.Text = "NºAluno"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 177)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 25)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Contacto Móvel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(192, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Contacto Fixo"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Localidadelabel
        '
        Me.Localidadelabel.AutoSize = True
        Me.Localidadelabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Localidadelabel.Location = New System.Drawing.Point(334, 177)
        Me.Localidadelabel.Name = "Localidadelabel"
        Me.Localidadelabel.Size = New System.Drawing.Size(107, 25)
        Me.Localidadelabel.TabIndex = 64
        Me.Localidadelabel.Text = "Localidade"
        '
        'cod_postallabel
        '
        Me.cod_postallabel.AutoSize = True
        Me.cod_postallabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.cod_postallabel.Location = New System.Drawing.Point(464, 177)
        Me.cod_postallabel.Name = "cod_postallabel"
        Me.cod_postallabel.Size = New System.Drawing.Size(136, 25)
        Me.cod_postallabel.TabIndex = 63
        Me.cod_postallabel.Text = "Código Postal"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_301011418NFe0o9M1
        Me.PictureBox1.Location = New System.Drawing.Point(33, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 67
        Me.PictureBox1.TabStop = False
        '
        'imagembox
        '
        Me.imagembox.Location = New System.Drawing.Point(629, 33)
        Me.imagembox.Name = "imagembox"
        Me.imagembox.Size = New System.Drawing.Size(141, 141)
        Me.imagembox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imagembox.TabIndex = 55
        Me.imagembox.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label1.Location = New System.Drawing.Point(69, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 13)
        Me.Label1.TabIndex = 76
        Me.Label1.Text = "Não se esqueça de inserir o indicativo do país!"
        '
        'contactom_box
        '
        Me.contactom_box.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.contactom_box.Location = New System.Drawing.Point(38, 205)
        Me.contactom_box.Mask = "+0000000000000"
        Me.contactom_box.Name = "contactom_box"
        Me.contactom_box.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.contactom_box.Size = New System.Drawing.Size(107, 22)
        Me.contactom_box.TabIndex = 85
        Me.contactom_box.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.contactom_box.WaterMarkColor = System.Drawing.Color.Gray
        Me.contactom_box.WaterMarkText = "Obrigatório"
        '
        'contacto_fbox
        '
        Me.contacto_fbox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.contacto_fbox.Location = New System.Drawing.Point(197, 205)
        Me.contacto_fbox.Mask = "+0000000000000"
        Me.contacto_fbox.Name = "contacto_fbox"
        Me.contacto_fbox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.contacto_fbox.Size = New System.Drawing.Size(101, 22)
        Me.contacto_fbox.TabIndex = 86
        Me.contacto_fbox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.contacto_fbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.contacto_fbox.WaterMarkText = ""
        '
        'nomebox
        '
        Me.nomebox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.nomebox.Location = New System.Drawing.Point(38, 152)
        Me.nomebox.Name = "nomebox"
        Me.nomebox.Size = New System.Drawing.Size(204, 22)
        Me.nomebox.TabIndex = 87
        Me.nomebox.WaterMarkColor = System.Drawing.Color.Gray
        Me.nomebox.WaterMarkText = "Obrigatório"
        '
        'numalunobox
        '
        Me.numalunobox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.numalunobox.Location = New System.Drawing.Point(246, 152)
        Me.numalunobox.Name = "numalunobox"
        Me.numalunobox.Size = New System.Drawing.Size(119, 22)
        Me.numalunobox.TabIndex = 88
        Me.numalunobox.WaterMarkColor = System.Drawing.Color.Gray
        Me.numalunobox.WaterMarkText = "Obrigatório"
        '
        'turmabox
        '
        Me.turmabox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.turmabox.Location = New System.Drawing.Point(376, 150)
        Me.turmabox.Name = "turmabox"
        Me.turmabox.Size = New System.Drawing.Size(69, 22)
        Me.turmabox.TabIndex = 89
        Me.turmabox.WaterMarkColor = System.Drawing.Color.Gray
        Me.turmabox.WaterMarkText = "Obrigatório"
        '
        'localidadebox
        '
        Me.localidadebox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.localidadebox.Location = New System.Drawing.Point(339, 205)
        Me.localidadebox.Name = "localidadebox"
        Me.localidadebox.Size = New System.Drawing.Size(119, 22)
        Me.localidadebox.TabIndex = 90
        Me.localidadebox.WaterMarkColor = System.Drawing.Color.Gray
        Me.localidadebox.WaterMarkText = "Obrigatório"
        '
        'cod_postalbox
        '
        Me.cod_postalbox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.cod_postalbox.Location = New System.Drawing.Point(469, 205)
        Me.cod_postalbox.Mask = "0000-000"
        Me.cod_postalbox.Name = "cod_postalbox"
        Me.cod_postalbox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.cod_postalbox.Size = New System.Drawing.Size(69, 22)
        Me.cod_postalbox.TabIndex = 91
        Me.cod_postalbox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.cod_postalbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.cod_postalbox.WaterMarkText = "Obrigatório"
        '
        'caminhobox
        '
        Me.caminhobox.Enabled = False
        Me.caminhobox.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.caminhobox.Location = New System.Drawing.Point(629, 180)
        Me.caminhobox.Name = "caminhobox"
        Me.caminhobox.Size = New System.Drawing.Size(102, 22)
        Me.caminhobox.TabIndex = 92
        Me.caminhobox.WaterMarkColor = System.Drawing.Color.Gray
        Me.caminhobox.WaterMarkText = ""
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.respostabox)
        Me.GroupBox1.Controls.Add(Me.perguntabox)
        Me.GroupBox1.Controls.Add(Me.verifbox)
        Me.GroupBox1.Controls.Add(Me.passwordbox)
        Me.GroupBox1.Controls.Add(Me.nomeutilizadorbox)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 246)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(693, 167)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações da Conta"
        '
        'respostabox
        '
        Me.respostabox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.respostabox.Location = New System.Drawing.Point(400, 114)
        Me.respostabox.Name = "respostabox"
        Me.respostabox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.respostabox.Size = New System.Drawing.Size(208, 27)
        Me.respostabox.TabIndex = 104
        Me.respostabox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.respostabox.WaterMarkText = "Resposta"
        '
        'perguntabox
        '
        Me.perguntabox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perguntabox.Location = New System.Drawing.Point(105, 114)
        Me.perguntabox.Name = "perguntabox"
        Me.perguntabox.Size = New System.Drawing.Size(267, 27)
        Me.perguntabox.TabIndex = 103
        Me.perguntabox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.perguntabox.WaterMarkText = "Pergunta de Segurança"
        '
        'verifbox
        '
        Me.verifbox.Location = New System.Drawing.Point(447, 55)
        Me.verifbox.Name = "verifbox"
        Me.verifbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.verifbox.Size = New System.Drawing.Size(155, 33)
        Me.verifbox.TabIndex = 102
        '
        'passwordbox
        '
        Me.passwordbox.Location = New System.Drawing.Point(250, 55)
        Me.passwordbox.Name = "passwordbox"
        Me.passwordbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passwordbox.Size = New System.Drawing.Size(155, 33)
        Me.passwordbox.TabIndex = 101
        '
        'nomeutilizadorbox
        '
        Me.nomeutilizadorbox.Location = New System.Drawing.Point(52, 55)
        Me.nomeutilizadorbox.Name = "nomeutilizadorbox"
        Me.nomeutilizadorbox.Size = New System.Drawing.Size(155, 33)
        Me.nomeutilizadorbox.TabIndex = 100
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(396, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Resposta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(101, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 20)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Pergunta de Segurança:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.Label7.Location = New System.Drawing.Point(443, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(195, 23)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Confirmar Palavra-Passe"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.Label9.Location = New System.Drawing.Point(48, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(159, 23)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = "Nome de Utilizador"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.Label11.Location = New System.Drawing.Point(246, 29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 23)
        Me.Label11.TabIndex = 65
        Me.Label11.Text = "Palavra-Passe"
        '
        'restartbutton
        '
        Me.restartbutton.Location = New System.Drawing.Point(549, 419)
        Me.restartbutton.Name = "restartbutton"
        Me.restartbutton.Size = New System.Drawing.Size(97, 41)
        Me.restartbutton.TabIndex = 108
        Me.restartbutton.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(673, 419)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(97, 41)
        Me.exitbutton.TabIndex = 107
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'savebutton
        '
        Me.savebutton.Location = New System.Drawing.Point(33, 419)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(97, 41)
        Me.savebutton.TabIndex = 105
        Me.savebutton.UseVisualStyleBackColor = True
        '
        'reparaçoesefetuadasbutton
        '
        Me.reparaçoesefetuadasbutton.Location = New System.Drawing.Point(160, 419)
        Me.reparaçoesefetuadasbutton.Name = "reparaçoesefetuadasbutton"
        Me.reparaçoesefetuadasbutton.Size = New System.Drawing.Size(97, 41)
        Me.reparaçoesefetuadasbutton.TabIndex = 106
        Me.reparaçoesefetuadasbutton.UseVisualStyleBackColor = True
        '
        'logobutton
        '
        Me.logobutton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logobutton.Location = New System.Drawing.Point(738, 181)
        Me.logobutton.Name = "logobutton"
        Me.logobutton.Size = New System.Drawing.Size(42, 23)
        Me.logobutton.TabIndex = 109
        Me.logobutton.Text = "..."
        Me.logobutton.UseVisualStyleBackColor = True
        '
        'OPR_Técnicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(810, 476)
        Me.Controls.Add(Me.logobutton)
        Me.Controls.Add(Me.restartbutton)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.caminhobox)
        Me.Controls.Add(Me.reparaçoesefetuadasbutton)
        Me.Controls.Add(Me.savebutton)
        Me.Controls.Add(Me.cod_postalbox)
        Me.Controls.Add(Me.localidadebox)
        Me.Controls.Add(Me.turmabox)
        Me.Controls.Add(Me.numalunobox)
        Me.Controls.Add(Me.nomebox)
        Me.Controls.Add(Me.contacto_fbox)
        Me.Controls.Add(Me.contactom_box)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Localidadelabel)
        Me.Controls.Add(Me.cod_postallabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.imagembox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.turmalabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.numalunolabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OPR_Técnicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Técnicos"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imagembox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents turmalabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents numalunolabel As System.Windows.Forms.Label
    Friend WithEvents imagembox As System.Windows.Forms.PictureBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Localidadelabel As System.Windows.Forms.Label
    Friend WithEvents cod_postallabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents contactom_box As ClinicaInformatica.MaskedWaterMarkTextBox
    Friend WithEvents contacto_fbox As ClinicaInformatica.MaskedWaterMarkTextBox
    Friend WithEvents nomebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents numalunobox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents turmabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents localidadebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents cod_postalbox As ClinicaInformatica.MaskedWaterMarkTextBox
    Friend WithEvents caminhobox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents respostabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents perguntabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents verifbox As System.Windows.Forms.TextBox
    Friend WithEvents passwordbox As System.Windows.Forms.TextBox
    Friend WithEvents nomeutilizadorbox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents restartbutton As System.Windows.Forms.Button
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents savebutton As System.Windows.Forms.Button
    Friend WithEvents reparaçoesefetuadasbutton As System.Windows.Forms.Button
    Friend WithEvents logobutton As System.Windows.Forms.Button
End Class
