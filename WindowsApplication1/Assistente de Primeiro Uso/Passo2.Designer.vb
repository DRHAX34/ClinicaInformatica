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
        Me.cod_postalbox = New ClinicaInformatica.MaskedWaterMarkTextBox()
        Me.localidadebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.moradabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.nomebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.niflabel = New System.Windows.Forms.Label()
        Me.nifbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.logolabel = New System.Windows.Forms.Label()
        Me.logobox = New System.Windows.Forms.PictureBox()
        Me.caminhobox = New ClinicaInformatica.WaterMarkTextBox()
        Me.imagebutton = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.logobox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelarbutton
        '
        Me.cancelarbutton.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.cancelarbutton.Location = New System.Drawing.Point(486, 376)
        Me.cancelarbutton.Name = "cancelarbutton"
        Me.cancelarbutton.Size = New System.Drawing.Size(137, 44)
        Me.cancelarbutton.TabIndex = 11
        Me.cancelarbutton.Text = "Cancelar"
        Me.cancelarbutton.UseVisualStyleBackColor = True
        '
        'seguintebutton
        '
        Me.seguintebutton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.seguintebutton.Location = New System.Drawing.Point(629, 364)
        Me.seguintebutton.Name = "seguintebutton"
        Me.seguintebutton.Size = New System.Drawing.Size(153, 56)
        Me.seguintebutton.TabIndex = 10
        Me.seguintebutton.Text = "Seguinte"
        Me.seguintebutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 40.0!)
        Me.Label1.Location = New System.Drawing.Point(13, 17)
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
        Me.nomelabel.Size = New System.Drawing.Size(53, 20)
        Me.nomelabel.TabIndex = 13
        Me.nomelabel.Text = "Nome:"
        '
        'moradalabel
        '
        Me.moradalabel.AutoSize = True
        Me.moradalabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.moradalabel.Location = New System.Drawing.Point(220, 115)
        Me.moradalabel.Name = "moradalabel"
        Me.moradalabel.Size = New System.Drawing.Size(61, 20)
        Me.moradalabel.TabIndex = 15
        Me.moradalabel.Text = "Morada"
        '
        'cod_postallabel
        '
        Me.cod_postallabel.AutoSize = True
        Me.cod_postallabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cod_postallabel.Location = New System.Drawing.Point(220, 168)
        Me.cod_postallabel.Name = "cod_postallabel"
        Me.cod_postallabel.Size = New System.Drawing.Size(102, 20)
        Me.cod_postallabel.TabIndex = 17
        Me.cod_postallabel.Text = "Código Postal"
        '
        'Localidadelabel
        '
        Me.Localidadelabel.AutoSize = True
        Me.Localidadelabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Localidadelabel.Location = New System.Drawing.Point(21, 168)
        Me.Localidadelabel.Name = "Localidadelabel"
        Me.Localidadelabel.Size = New System.Drawing.Size(82, 20)
        Me.Localidadelabel.TabIndex = 19
        Me.Localidadelabel.Text = "Localidade"
        '
        'Timer1
        '
        '
        'cod_postalbox
        '
        Me.cod_postalbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cod_postalbox.Location = New System.Drawing.Point(224, 191)
        Me.cod_postalbox.Mask = "0000-000"
        Me.cod_postalbox.Name = "cod_postalbox"
        Me.cod_postalbox.Size = New System.Drawing.Size(183, 27)
        Me.cod_postalbox.TabIndex = 20
        Me.cod_postalbox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.cod_postalbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.cod_postalbox.WaterMarkText = "Código Postal"
        '
        'localidadebox
        '
        Me.localidadebox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.localidadebox.Location = New System.Drawing.Point(25, 191)
        Me.localidadebox.Name = "localidadebox"
        Me.localidadebox.Size = New System.Drawing.Size(183, 27)
        Me.localidadebox.TabIndex = 18
        Me.localidadebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.localidadebox.WaterMarkText = "Localidade"
        '
        'moradabox
        '
        Me.moradabox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.moradabox.Location = New System.Drawing.Point(224, 138)
        Me.moradabox.Name = "moradabox"
        Me.moradabox.Size = New System.Drawing.Size(183, 27)
        Me.moradabox.TabIndex = 14
        Me.moradabox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.moradabox.WaterMarkText = "Morada"
        '
        'nomebox
        '
        Me.nomebox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomebox.Location = New System.Drawing.Point(25, 138)
        Me.nomebox.Name = "nomebox"
        Me.nomebox.Size = New System.Drawing.Size(183, 27)
        Me.nomebox.TabIndex = 12
        Me.nomebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.nomebox.WaterMarkText = "Nome da Empresa"
        '
        'niflabel
        '
        Me.niflabel.AutoSize = True
        Me.niflabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.niflabel.Location = New System.Drawing.Point(119, 226)
        Me.niflabel.Name = "niflabel"
        Me.niflabel.Size = New System.Drawing.Size(31, 20)
        Me.niflabel.TabIndex = 22
        Me.niflabel.Text = "NIF"
        '
        'nifbox
        '
        Me.nifbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nifbox.Location = New System.Drawing.Point(123, 249)
        Me.nifbox.Name = "nifbox"
        Me.nifbox.Size = New System.Drawing.Size(183, 27)
        Me.nifbox.TabIndex = 21
        Me.nifbox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.nifbox.WaterMarkText = "NIF"
        '
        'logolabel
        '
        Me.logolabel.AutoSize = True
        Me.logolabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.logolabel.Location = New System.Drawing.Point(520, 89)
        Me.logolabel.Name = "logolabel"
        Me.logolabel.Size = New System.Drawing.Size(125, 20)
        Me.logolabel.TabIndex = 23
        Me.logolabel.Text = "Logo da Empresa"
        '
        'logobox
        '
        Me.logobox.Location = New System.Drawing.Point(524, 115)
        Me.logobox.Name = "logobox"
        Me.logobox.Size = New System.Drawing.Size(210, 193)
        Me.logobox.TabIndex = 24
        Me.logobox.TabStop = False
        '
        'caminhobox
        '
        Me.caminhobox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caminhobox.Location = New System.Drawing.Point(524, 314)
        Me.caminhobox.Name = "caminhobox"
        Me.caminhobox.Size = New System.Drawing.Size(183, 27)
        Me.caminhobox.TabIndex = 25
        Me.caminhobox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.caminhobox.WaterMarkText = "Caminho"
        '
        'imagebutton
        '
        Me.imagebutton.Location = New System.Drawing.Point(707, 315)
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
        'Passo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 436)
        Me.Controls.Add(Me.imagebutton)
        Me.Controls.Add(Me.caminhobox)
        Me.Controls.Add(Me.logobox)
        Me.Controls.Add(Me.logolabel)
        Me.Controls.Add(Me.niflabel)
        Me.Controls.Add(Me.nifbox)
        Me.Controls.Add(Me.cod_postalbox)
        Me.Controls.Add(Me.Localidadelabel)
        Me.Controls.Add(Me.localidadebox)
        Me.Controls.Add(Me.cod_postallabel)
        Me.Controls.Add(Me.moradalabel)
        Me.Controls.Add(Me.moradabox)
        Me.Controls.Add(Me.nomelabel)
        Me.Controls.Add(Me.nomebox)
        Me.Controls.Add(Me.cancelarbutton)
        Me.Controls.Add(Me.seguintebutton)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Passo2"
        Me.Text = "Assistente de Primeiro Uso"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.logobox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelarbutton As System.Windows.Forms.Button
    Friend WithEvents seguintebutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nomebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents nomelabel As System.Windows.Forms.Label
    Friend WithEvents moradalabel As System.Windows.Forms.Label
    Friend WithEvents moradabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents cod_postallabel As System.Windows.Forms.Label
    Friend WithEvents Localidadelabel As System.Windows.Forms.Label
    Friend WithEvents localidadebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents cod_postalbox As ClinicaInformatica.MaskedWaterMarkTextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents niflabel As System.Windows.Forms.Label
    Friend WithEvents nifbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents logolabel As System.Windows.Forms.Label
    Friend WithEvents logobox As System.Windows.Forms.PictureBox
    Friend WithEvents caminhobox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents imagebutton As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
