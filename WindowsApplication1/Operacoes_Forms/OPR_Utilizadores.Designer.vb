<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPR_Utilizadores
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
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.respostabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.perguntabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.verifbox = New System.Windows.Forms.TextBox()
        Me.passwordbox = New System.Windows.Forms.TextBox()
        Me.nomeutilizadorbox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.empresabox = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton4
        '
        Me.RadButton4.Location = New System.Drawing.Point(568, 312)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(120, 36)
        Me.RadButton4.TabIndex = 78
        Me.RadButton4.Text = "Cancelar"
        Me.RadButton4.ThemeName = "Windows8"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(442, 312)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(120, 36)
        Me.RadButton3.TabIndex = 77
        Me.RadButton3.Text = "Restaurar Dados Originais"
        Me.RadButton3.TextWrap = True
        Me.RadButton3.ThemeName = "Windows8"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(148, 312)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(120, 36)
        Me.RadButton1.TabIndex = 75
        Me.RadButton1.Text = "Editar"
        Me.RadButton1.ThemeName = "Windows8"
        '
        'RadButton5
        '
        Me.RadButton5.Location = New System.Drawing.Point(22, 312)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(120, 36)
        Me.RadButton5.TabIndex = 74
        Me.RadButton5.Text = "Adicionar"
        Me.RadButton5.ThemeName = "Windows8"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(132, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(371, 86)
        Me.Label6.TabIndex = 73
        Me.Label6.Text = "Utilizadores"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.Label3.Location = New System.Drawing.Point(48, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(159, 23)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Nome de Utilizador"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.Label4.Location = New System.Drawing.Point(246, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 23)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Palavra-Passe"
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
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.GroupBox1.Location = New System.Drawing.Point(22, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(666, 162)
        Me.GroupBox1.TabIndex = 80
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações da Conta"
        '
        'respostabox
        '
        Me.respostabox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.respostabox.Location = New System.Drawing.Point(347, 114)
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
        Me.perguntabox.Location = New System.Drawing.Point(52, 114)
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
        Me.Label8.Location = New System.Drawing.Point(343, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(72, 20)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Resposta:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(48, 91)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 20)
        Me.Label10.TabIndex = 94
        Me.Label10.Text = "Pergunta de Segurança:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.25!)
        Me.Label1.Location = New System.Drawing.Point(443, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 23)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "Confirmar Palavra-Passe"
        '
        'empresabox
        '
        Me.empresabox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.empresabox.FormattingEnabled = True
        Me.empresabox.Location = New System.Drawing.Point(539, 117)
        Me.empresabox.Name = "empresabox"
        Me.empresabox.Size = New System.Drawing.Size(121, 21)
        Me.empresabox.TabIndex = 87
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(446, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 25)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Empresa"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_3010633jb6OZwQ51
        Me.PictureBox1.Location = New System.Drawing.Point(42, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 92
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'OPR_Utilizadores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(721, 360)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.empresabox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RadButton4)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadButton5)
        Me.Controls.Add(Me.Label6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "OPR_Utilizadores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Utilizadores"
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents empresabox As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents verifbox As System.Windows.Forms.TextBox
    Friend WithEvents passwordbox As System.Windows.Forms.TextBox
    Friend WithEvents nomeutilizadorbox As System.Windows.Forms.TextBox
    Friend WithEvents respostabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents perguntabox As ClinicaInformatica.WaterMarkTextBox
End Class
