<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passo3
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.passlabel = New System.Windows.Forms.Label()
        Me.nomelabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.nomebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.passbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.verifbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.perguntabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.respostabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.limparbutton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 40.0!)
        Me.Label1.Location = New System.Drawing.Point(113, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(587, 72)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Crie um Administrador!"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(666, 409)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(171, 47)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Continuar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'passlabel
        '
        Me.passlabel.AutoSize = True
        Me.passlabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.passlabel.Location = New System.Drawing.Point(183, 221)
        Me.passlabel.Name = "passlabel"
        Me.passlabel.Size = New System.Drawing.Size(102, 20)
        Me.passlabel.TabIndex = 26
        Me.passlabel.Text = "Palavra-Passe:"
        '
        'nomelabel
        '
        Me.nomelabel.AutoSize = True
        Me.nomelabel.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.nomelabel.Location = New System.Drawing.Point(183, 168)
        Me.nomelabel.Name = "nomelabel"
        Me.nomelabel.Size = New System.Drawing.Size(143, 20)
        Me.nomelabel.TabIndex = 24
        Me.nomelabel.Text = "Nome de Utilizador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(226, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(324, 17)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Nota:Um Administrador apenas pode gerir Empresas."
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(183, 274)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 20)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Confirme a palavra-passe:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(423, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 20)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Pergunta de Segurança:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(423, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Resposta:"
        '
        'nomebox
        '
        Me.nomebox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomebox.Location = New System.Drawing.Point(187, 191)
        Me.nomebox.Name = "nomebox"
        Me.nomebox.Size = New System.Drawing.Size(183, 27)
        Me.nomebox.TabIndex = 41
        Me.nomebox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.nomebox.WaterMarkText = "Nome de Utilizador"
        '
        'passbox
        '
        Me.passbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passbox.Location = New System.Drawing.Point(187, 244)
        Me.passbox.Name = "passbox"
        Me.passbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.passbox.Size = New System.Drawing.Size(183, 27)
        Me.passbox.TabIndex = 42
        Me.passbox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.passbox.WaterMarkText = "Palavra-Passe"
        '
        'verifbox
        '
        Me.verifbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.verifbox.Location = New System.Drawing.Point(187, 297)
        Me.verifbox.Name = "verifbox"
        Me.verifbox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.verifbox.Size = New System.Drawing.Size(183, 27)
        Me.verifbox.TabIndex = 43
        Me.verifbox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.verifbox.WaterMarkText = "Confirme a palavra-passe"
        '
        'perguntabox
        '
        Me.perguntabox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.perguntabox.Location = New System.Drawing.Point(427, 191)
        Me.perguntabox.Name = "perguntabox"
        Me.perguntabox.Size = New System.Drawing.Size(233, 27)
        Me.perguntabox.TabIndex = 44
        Me.perguntabox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.perguntabox.WaterMarkText = "Pergunta de Segurança"
        '
        'respostabox
        '
        Me.respostabox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.respostabox.Location = New System.Drawing.Point(427, 244)
        Me.respostabox.Name = "respostabox"
        Me.respostabox.Size = New System.Drawing.Size(233, 27)
        Me.respostabox.TabIndex = 45
        Me.respostabox.WaterMarkColor = System.Drawing.Color.DimGray
        Me.respostabox.WaterMarkText = "Resposta"
        '
        'limparbutton
        '
        Me.limparbutton.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limparbutton.Image = Global.ClinicaInformatica.My.Resources.Resources._48x48
        Me.limparbutton.Location = New System.Drawing.Point(610, 411)
        Me.limparbutton.Name = "limparbutton"
        Me.limparbutton.Size = New System.Drawing.Size(50, 44)
        Me.limparbutton.TabIndex = 121
        Me.limparbutton.UseVisualStyleBackColor = True
        '
        'Passo3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 468)
        Me.Controls.Add(Me.limparbutton)
        Me.Controls.Add(Me.respostabox)
        Me.Controls.Add(Me.perguntabox)
        Me.Controls.Add(Me.verifbox)
        Me.Controls.Add(Me.passbox)
        Me.Controls.Add(Me.nomebox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.passlabel)
        Me.Controls.Add(Me.nomelabel)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Passo3"
        Me.Text = "Assistente de Primeiro Uso - Passo 3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents passlabel As System.Windows.Forms.Label
    Friend WithEvents nomelabel As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents nomebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents passbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents verifbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents perguntabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents respostabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents limparbutton As System.Windows.Forms.Button
End Class
