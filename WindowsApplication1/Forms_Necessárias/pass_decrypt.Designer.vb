<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pass_decrypt
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.nomelabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.WaterMarkTextBox1 = New ClinicaInformatica.WaterMarkTextBox()
        Me.nomebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 48.0!)
        Me.Label1.Location = New System.Drawing.Point(28, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(888, 86)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Desbloqueio de Palavra-Passe"
        '
        'nomelabel
        '
        Me.nomelabel.AutoSize = True
        Me.nomelabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.nomelabel.Location = New System.Drawing.Point(383, 122)
        Me.nomelabel.Name = "nomelabel"
        Me.nomelabel.Size = New System.Drawing.Size(143, 20)
        Me.nomelabel.TabIndex = 26
        Me.nomelabel.Text = "Nome de Utilizador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(323, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(283, 20)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Insira a sua palavra-passe para confirmar:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(763, 301)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 68)
        Me.Button1.TabIndex = 29
        Me.Button1.Text = "Continuar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(339, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(237, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "A palavra-passe deste utilizador é:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(427, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "$pass"
        '
        'WaterMarkTextBox1
        '
        Me.WaterMarkTextBox1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaterMarkTextBox1.Location = New System.Drawing.Point(360, 212)
        Me.WaterMarkTextBox1.Name = "WaterMarkTextBox1"
        Me.WaterMarkTextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.WaterMarkTextBox1.Size = New System.Drawing.Size(183, 27)
        Me.WaterMarkTextBox1.TabIndex = 27
        Me.WaterMarkTextBox1.WaterMarkColor = System.Drawing.Color.DimGray
        Me.WaterMarkTextBox1.WaterMarkText = "Palavra-Passe"
        '
        'nomebox
        '
        Me.nomebox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomebox.Location = New System.Drawing.Point(360, 145)
        Me.nomebox.Name = "nomebox"
        Me.nomebox.Size = New System.Drawing.Size(183, 27)
        Me.nomebox.TabIndex = 25
        Me.nomebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.nomebox.WaterMarkText = "Nome de Utilizador"
        '
        'pass_decrypt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 381)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.WaterMarkTextBox1)
        Me.Controls.Add(Me.nomelabel)
        Me.Controls.Add(Me.nomebox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "pass_decrypt"
        Me.Text = "pass_decrypt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents nomelabel As System.Windows.Forms.Label
    Friend WithEvents nomebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents WaterMarkTextBox1 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
