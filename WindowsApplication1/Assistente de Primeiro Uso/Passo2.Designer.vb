<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passo2
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cancelarbutton = New System.Windows.Forms.Button()
        Me.seguintebutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nomelabel = New System.Windows.Forms.Label()
        Me.moradalabel = New System.Windows.Forms.Label()
        Me.cod_postallabel = New System.Windows.Forms.Label()
        Me.Localidadelabel = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.niflabel = New System.Windows.Forms.Label()
        Me.logolabel = New System.Windows.Forms.Label()
        Me.caminhobox = New ClinicaInformatica.WaterMarkTextBox()
        Me.imagebutton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.alunoslabel = New System.Windows.Forms.Label()
        Me.nomebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.moradabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.localidadebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.cod_postalbox = New ClinicaInformatica.MaskedWaterMarkTextBox()
        Me.nifbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.simcheck = New System.Windows.Forms.RadioButton()
        Me.naocheck = New System.Windows.Forms.RadioButton()
        Me.limparbutton = New System.Windows.Forms.Button()
        Me.logobox = New System.Windows.Forms.PictureBox()
        Me.emaillabel = New System.Windows.Forms.Label()
        Me.sitelabel = New System.Windows.Forms.Label()
        Me.contactofixlabel = New System.Windows.Forms.Label()
        Me.notalabel = New System.Windows.Forms.Label()
        Me.contactofixbox = New ClinicaInformatica.MaskedWaterMarkTextBox()
        Me.emailbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.sitebox = New ClinicaInformatica.WaterMarkTextBox()
        CType(Me.logobox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelarbutton
        '
        Me.cancelarbutton.Font = New System.Drawing.Font("Segoe UI", 14.25!)
        Me.cancelarbutton.Location = New System.Drawing.Point(533, 412)
        Me.cancelarbutton.Name = "cancelarbutton"
        Me.cancelarbutton.Size = New System.Drawing.Size(137, 44)
        Me.cancelarbutton.TabIndex = 11
        Me.cancelarbutton.Text = "Cancelar"
        Me.cancelarbutton.UseVisualStyleBackColor = True
        '
        'seguintebutton
        '
        Me.seguintebutton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seguintebutton.Location = New System.Drawing.Point(676, 412)
        Me.seguintebutton.Name = "seguintebutton"
        Me.seguintebutton.Size = New System.Drawing.Size(153, 44)
        Me.seguintebutton.TabIndex = 10
        Me.seguintebutton.Text = "Seguinte"
        Me.seguintebutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 40.0!)
        Me.Label1.Location = New System.Drawing.Point(53, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(776, 72)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Insira os dados da sua Empresa"
        '
        'nomelabel
        '
        Me.nomelabel.AutoSize = True
        Me.nomelabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.nomelabel.Location = New System.Drawing.Point(21, 115)
        Me.nomelabel.Name = "nomelabel"
        Me.nomelabel.Size = New System.Drawing.Size(56, 20)
        Me.nomelabel.TabIndex = 13
        Me.nomelabel.Text = "Nome*"
        '
        'moradalabel
        '
        Me.moradalabel.AutoSize = True
        Me.moradalabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.moradalabel.Location = New System.Drawing.Point(220, 115)
        Me.moradalabel.Name = "moradalabel"
        Me.moradalabel.Size = New System.Drawing.Size(67, 20)
        Me.moradalabel.TabIndex = 15
        Me.moradalabel.Text = "Morada*"
        '
        'cod_postallabel
        '
        Me.cod_postallabel.AutoSize = True
        Me.cod_postallabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cod_postallabel.Location = New System.Drawing.Point(220, 168)
        Me.cod_postallabel.Name = "cod_postallabel"
        Me.cod_postallabel.Size = New System.Drawing.Size(108, 20)
        Me.cod_postallabel.TabIndex = 17
        Me.cod_postallabel.Text = "Código Postal*"
        '
        'Localidadelabel
        '
        Me.Localidadelabel.AutoSize = True
        Me.Localidadelabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Localidadelabel.Location = New System.Drawing.Point(21, 168)
        Me.Localidadelabel.Name = "Localidadelabel"
        Me.Localidadelabel.Size = New System.Drawing.Size(88, 20)
        Me.Localidadelabel.TabIndex = 19
        Me.Localidadelabel.Text = "Localidade*"
        '
        'Timer1
        '
        '
        'niflabel
        '
        Me.niflabel.AutoSize = True
        Me.niflabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.niflabel.Location = New System.Drawing.Point(21, 226)
        Me.niflabel.Name = "niflabel"
        Me.niflabel.Size = New System.Drawing.Size(37, 20)
        Me.niflabel.TabIndex = 22
        Me.niflabel.Text = "NIF*"
        '
        'logolabel
        '
        Me.logolabel.AutoSize = True
        Me.logolabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.logolabel.Location = New System.Drawing.Point(615, 89)
        Me.logolabel.Name = "logolabel"
        Me.logolabel.Size = New System.Drawing.Size(125, 20)
        Me.logolabel.TabIndex = 23
        Me.logolabel.Text = "Logo da Empresa"
        '
        'caminhobox
        '
        Me.caminhobox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caminhobox.Location = New System.Drawing.Point(619, 314)
        Me.caminhobox.Name = "caminhobox"
        Me.caminhobox.Size = New System.Drawing.Size(183, 27)
        Me.caminhobox.TabIndex = 25
        Me.caminhobox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.caminhobox.WaterMarkText = "Caminho"
        '
        'imagebutton
        '
        Me.imagebutton.Location = New System.Drawing.Point(802, 315)
        Me.imagebutton.Name = "imagebutton"
        Me.imagebutton.Size = New System.Drawing.Size(27, 26)
        Me.imagebutton.TabIndex = 26
        Me.imagebutton.Text = "..."
        Me.imagebutton.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'alunoslabel
        '
        Me.alunoslabel.AutoSize = True
        Me.alunoslabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.alunoslabel.Location = New System.Drawing.Point(220, 280)
        Me.alunoslabel.Name = "alunoslabel"
        Me.alunoslabel.Size = New System.Drawing.Size(94, 20)
        Me.alunoslabel.TabIndex = 36
        Me.alunoslabel.Text = "Tem Alunos?"
        '
        'nomebox
        '
        Me.nomebox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomebox.Location = New System.Drawing.Point(25, 138)
        Me.nomebox.Name = "nomebox"
        Me.nomebox.Size = New System.Drawing.Size(183, 27)
        Me.nomebox.TabIndex = 39
        Me.nomebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.nomebox.WaterMarkText = "Nome da Empresa"
        '
        'moradabox
        '
        Me.moradabox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moradabox.Location = New System.Drawing.Point(224, 138)
        Me.moradabox.Name = "moradabox"
        Me.moradabox.Size = New System.Drawing.Size(183, 27)
        Me.moradabox.TabIndex = 40
        Me.moradabox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.moradabox.WaterMarkText = "Morada"
        '
        'localidadebox
        '
        Me.localidadebox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.localidadebox.Location = New System.Drawing.Point(24, 191)
        Me.localidadebox.Name = "localidadebox"
        Me.localidadebox.Size = New System.Drawing.Size(119, 27)
        Me.localidadebox.TabIndex = 41
        Me.localidadebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.localidadebox.WaterMarkText = "Localidade"
        '
        'cod_postalbox
        '
        Me.cod_postalbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cod_postalbox.Location = New System.Drawing.Point(224, 191)
        Me.cod_postalbox.Mask = "0000-000"
        Me.cod_postalbox.Name = "cod_postalbox"
        Me.cod_postalbox.Size = New System.Drawing.Size(107, 27)
        Me.cod_postalbox.TabIndex = 42
        Me.cod_postalbox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.cod_postalbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.cod_postalbox.WaterMarkText = "Código Postal"
        '
        'nifbox
        '
        Me.nifbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nifbox.Location = New System.Drawing.Point(24, 250)
        Me.nifbox.MaxLength = 9
        Me.nifbox.Name = "nifbox"
        Me.nifbox.Size = New System.Drawing.Size(119, 27)
        Me.nifbox.TabIndex = 43
        Me.nifbox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.nifbox.WaterMarkText = "NIF"
        '
        'simcheck
        '
        Me.simcheck.AutoSize = True
        Me.simcheck.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.simcheck.Location = New System.Drawing.Point(224, 304)
        Me.simcheck.Name = "simcheck"
        Me.simcheck.Size = New System.Drawing.Size(47, 21)
        Me.simcheck.TabIndex = 44
        Me.simcheck.TabStop = True
        Me.simcheck.Text = "Sim"
        Me.simcheck.UseVisualStyleBackColor = True
        '
        'naocheck
        '
        Me.naocheck.AutoSize = True
        Me.naocheck.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.naocheck.Location = New System.Drawing.Point(277, 304)
        Me.naocheck.Name = "naocheck"
        Me.naocheck.Size = New System.Drawing.Size(51, 21)
        Me.naocheck.TabIndex = 45
        Me.naocheck.TabStop = True
        Me.naocheck.Text = "Não"
        Me.naocheck.UseVisualStyleBackColor = True
        '
        'limparbutton
        '
        Me.limparbutton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limparbutton.Image = Global.ClinicaInformatica.My.Resources.Resources._48x48
        Me.limparbutton.Location = New System.Drawing.Point(477, 412)
        Me.limparbutton.Name = "limparbutton"
        Me.limparbutton.Size = New System.Drawing.Size(50, 44)
        Me.limparbutton.TabIndex = 35
        Me.limparbutton.UseVisualStyleBackColor = True
        '
        'logobox
        '
        Me.logobox.Location = New System.Drawing.Point(619, 115)
        Me.logobox.Name = "logobox"
        Me.logobox.Size = New System.Drawing.Size(210, 193)
        Me.logobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.logobox.TabIndex = 24
        Me.logobox.TabStop = False
        '
        'emaillabel
        '
        Me.emaillabel.AutoSize = True
        Me.emaillabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.emaillabel.Location = New System.Drawing.Point(21, 280)
        Me.emaillabel.Name = "emaillabel"
        Me.emaillabel.Size = New System.Drawing.Size(46, 20)
        Me.emaillabel.TabIndex = 49
        Me.emaillabel.Text = "Email"
        '
        'sitelabel
        '
        Me.sitelabel.AutoSize = True
        Me.sitelabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.sitelabel.Location = New System.Drawing.Point(21, 332)
        Me.sitelabel.Name = "sitelabel"
        Me.sitelabel.Size = New System.Drawing.Size(63, 20)
        Me.sitelabel.TabIndex = 50
        Me.sitelabel.Text = "Website"
        '
        'contactofixlabel
        '
        Me.contactofixlabel.AutoSize = True
        Me.contactofixlabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.contactofixlabel.Location = New System.Drawing.Point(220, 226)
        Me.contactofixlabel.Name = "contactofixlabel"
        Me.contactofixlabel.Size = New System.Drawing.Size(106, 20)
        Me.contactofixlabel.TabIndex = 53
        Me.contactofixlabel.Text = "Contacto Fixo*"
        '
        'notalabel
        '
        Me.notalabel.AutoSize = True
        Me.notalabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.notalabel.Location = New System.Drawing.Point(21, 436)
        Me.notalabel.Name = "notalabel"
        Me.notalabel.Size = New System.Drawing.Size(171, 20)
        Me.notalabel.TabIndex = 61
        Me.notalabel.Text = "* - Campos Obrigatórios"
        '
        'contactofixbox
        '
        Me.contactofixbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.contactofixbox.Location = New System.Drawing.Point(224, 250)
        Me.contactofixbox.Mask = "+0000000000000"
        Me.contactofixbox.Name = "contactofixbox"
        Me.contactofixbox.PromptChar = Global.Microsoft.VisualBasic.ChrW(32)
        Me.contactofixbox.Size = New System.Drawing.Size(110, 27)
        Me.contactofixbox.TabIndex = 86
        Me.contactofixbox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.contactofixbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.contactofixbox.WaterMarkText = "Contacto Fixo"
        '
        'emailbox
        '
        Me.emailbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.emailbox.Location = New System.Drawing.Point(25, 302)
        Me.emailbox.MaxLength = 9
        Me.emailbox.Name = "emailbox"
        Me.emailbox.Size = New System.Drawing.Size(184, 27)
        Me.emailbox.TabIndex = 87
        Me.emailbox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.emailbox.WaterMarkText = "Email"
        '
        'sitebox
        '
        Me.sitebox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.sitebox.Location = New System.Drawing.Point(26, 355)
        Me.sitebox.MaxLength = 9
        Me.sitebox.Name = "sitebox"
        Me.sitebox.Size = New System.Drawing.Size(183, 27)
        Me.sitebox.TabIndex = 88
        Me.sitebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.sitebox.WaterMarkText = "Website"
        '
        'Passo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 468)
        Me.Controls.Add(Me.sitebox)
        Me.Controls.Add(Me.emailbox)
        Me.Controls.Add(Me.contactofixbox)
        Me.Controls.Add(Me.notalabel)
        Me.Controls.Add(Me.contactofixlabel)
        Me.Controls.Add(Me.sitelabel)
        Me.Controls.Add(Me.emaillabel)
        Me.Controls.Add(Me.naocheck)
        Me.Controls.Add(Me.simcheck)
        Me.Controls.Add(Me.nifbox)
        Me.Controls.Add(Me.cod_postalbox)
        Me.Controls.Add(Me.localidadebox)
        Me.Controls.Add(Me.moradabox)
        Me.Controls.Add(Me.nomebox)
        Me.Controls.Add(Me.alunoslabel)
        Me.Controls.Add(Me.limparbutton)
        Me.Controls.Add(Me.imagebutton)
        Me.Controls.Add(Me.caminhobox)
        Me.Controls.Add(Me.logobox)
        Me.Controls.Add(Me.logolabel)
        Me.Controls.Add(Me.niflabel)
        Me.Controls.Add(Me.Localidadelabel)
        Me.Controls.Add(Me.cod_postallabel)
        Me.Controls.Add(Me.moradalabel)
        Me.Controls.Add(Me.nomelabel)
        Me.Controls.Add(Me.cancelarbutton)
        Me.Controls.Add(Me.seguintebutton)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Passo2"
        Me.Text = "Assistente de Primeiro Uso - Passo 2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.logobox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelarbutton As System.Windows.Forms.Button
    Friend WithEvents seguintebutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nomelabel As System.Windows.Forms.Label
    Friend WithEvents moradalabel As System.Windows.Forms.Label
    Friend WithEvents cod_postallabel As System.Windows.Forms.Label
    Friend WithEvents Localidadelabel As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents niflabel As System.Windows.Forms.Label
    Friend WithEvents logolabel As System.Windows.Forms.Label
    Friend WithEvents logobox As System.Windows.Forms.PictureBox
    Friend WithEvents caminhobox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents imagebutton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents limparbutton As System.Windows.Forms.Button
    Friend WithEvents alunoslabel As System.Windows.Forms.Label
    Friend WithEvents nomebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents moradabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents localidadebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents cod_postalbox As ClinicaInformatica.MaskedWaterMarkTextBox
    Friend WithEvents nifbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents simcheck As System.Windows.Forms.RadioButton
    Friend WithEvents naocheck As System.Windows.Forms.RadioButton
    Friend WithEvents emaillabel As System.Windows.Forms.Label
    Friend WithEvents sitelabel As System.Windows.Forms.Label
    Friend WithEvents contactofixlabel As System.Windows.Forms.Label
    Friend WithEvents notalabel As System.Windows.Forms.Label
    Friend WithEvents contactofixbox As ClinicaInformatica.MaskedWaterMarkTextBox
    Friend WithEvents emailbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents sitebox As ClinicaInformatica.WaterMarkTextBox
End Class
