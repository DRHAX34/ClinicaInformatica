﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Passo1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.nomelabel = New System.Windows.Forms.Label()
        Me.variascheck = New System.Windows.Forms.RadioButton()
        Me.umacheck = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Button2.Location = New System.Drawing.Point(529, 412)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 44)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(672, 400)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 56)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Seguinte"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 35.0!)
        Me.Label2.Location = New System.Drawing.Point(13, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(731, 62)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "do Programa ""Clínica Informática"""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 40.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(660, 72)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Bem-vindo à configuração"
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'nomelabel
        '
        Me.nomelabel.AutoSize = True
        Me.nomelabel.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nomelabel.Location = New System.Drawing.Point(210, 197)
        Me.nomelabel.Name = "nomelabel"
        Me.nomelabel.Size = New System.Drawing.Size(431, 20)
        Me.nomelabel.TabIndex = 42
        Me.nomelabel.Text = "Vai usar este programa com várias empresa ou apenas uma?"
        '
        'variascheck
        '
        Me.variascheck.AutoSize = True
        Me.variascheck.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.variascheck.Location = New System.Drawing.Point(286, 234)
        Me.variascheck.Name = "variascheck"
        Me.variascheck.Size = New System.Drawing.Size(67, 24)
        Me.variascheck.TabIndex = 43
        Me.variascheck.TabStop = True
        Me.variascheck.Text = "Várias"
        Me.variascheck.UseVisualStyleBackColor = True
        '
        'umacheck
        '
        Me.umacheck.AutoSize = True
        Me.umacheck.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.umacheck.Location = New System.Drawing.Point(424, 234)
        Me.umacheck.Name = "umacheck"
        Me.umacheck.Size = New System.Drawing.Size(111, 24)
        Me.umacheck.TabIndex = 44
        Me.umacheck.TabStop = True
        Me.umacheck.Text = "Apenas Uma"
        Me.umacheck.UseVisualStyleBackColor = True
        '
        'Passo1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 468)
        Me.Controls.Add(Me.umacheck)
        Me.Controls.Add(Me.variascheck)
        Me.Controls.Add(Me.nomelabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Passo1"
        Me.Text = "Assistente de Primeiro Uso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents nomelabel As System.Windows.Forms.Label
    Friend WithEvents variascheck As System.Windows.Forms.RadioButton
    Friend WithEvents umacheck As System.Windows.Forms.RadioButton
End Class
