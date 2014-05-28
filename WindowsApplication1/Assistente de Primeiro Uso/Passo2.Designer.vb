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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nomebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.nomelabel = New System.Windows.Forms.Label()
        Me.moradalabel = New System.Windows.Forms.Label()
        Me.moradabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.cod_postallabel = New System.Windows.Forms.Label()
        Me.Localidadelabel = New System.Windows.Forms.Label()
        Me.localidadebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.cod_postalbox = New ClinicaInformatica.MaskedWaterMarkTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(486, 376)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 44)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(629, 364)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 56)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Seguinte"
        Me.Button1.UseVisualStyleBackColor = True
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
        'cod_postallabel
        '
        Me.cod_postallabel.AutoSize = True
        Me.cod_postallabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.cod_postallabel.Location = New System.Drawing.Point(625, 115)
        Me.cod_postallabel.Name = "cod_postallabel"
        Me.cod_postallabel.Size = New System.Drawing.Size(102, 20)
        Me.cod_postallabel.TabIndex = 17
        Me.cod_postallabel.Text = "Código Postal"
        '
        'Localidadelabel
        '
        Me.Localidadelabel.AutoSize = True
        Me.Localidadelabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Localidadelabel.Location = New System.Drawing.Point(420, 115)
        Me.Localidadelabel.Name = "Localidadelabel"
        Me.Localidadelabel.Size = New System.Drawing.Size(82, 20)
        Me.Localidadelabel.TabIndex = 19
        Me.Localidadelabel.Text = "Localidade"
        '
        'localidadebox
        '
        Me.localidadebox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.localidadebox.Location = New System.Drawing.Point(424, 138)
        Me.localidadebox.Name = "localidadebox"
        Me.localidadebox.Size = New System.Drawing.Size(183, 27)
        Me.localidadebox.TabIndex = 18
        Me.localidadebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.localidadebox.WaterMarkText = "Localidade"
        '
        'cod_postalbox
        '
        Me.cod_postalbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cod_postalbox.Location = New System.Drawing.Point(629, 138)
        Me.cod_postalbox.Mask = "0000-000"
        Me.cod_postalbox.Name = "cod_postalbox"
        Me.cod_postalbox.Size = New System.Drawing.Size(100, 27)
        Me.cod_postalbox.TabIndex = 20
        Me.cod_postalbox.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals
        Me.cod_postalbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.cod_postalbox.WaterMarkText = "Código Postal"
        '
        'Passo2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(795, 436)
        Me.Controls.Add(Me.cod_postalbox)
        Me.Controls.Add(Me.Localidadelabel)
        Me.Controls.Add(Me.localidadebox)
        Me.Controls.Add(Me.cod_postallabel)
        Me.Controls.Add(Me.moradalabel)
        Me.Controls.Add(Me.moradabox)
        Me.Controls.Add(Me.nomelabel)
        Me.Controls.Add(Me.nomebox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Passo2"
        Me.Text = "Passo2"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
End Class
