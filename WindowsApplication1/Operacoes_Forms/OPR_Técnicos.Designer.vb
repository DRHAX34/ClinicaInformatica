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
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.turmabox = New System.Windows.Forms.TextBox()
        Me.nomebox = New System.Windows.Forms.TextBox()
        Me.numalunobox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.RadButton6 = New Telerik.WinControls.UI.RadButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadButton4
        '
        Me.RadButton4.Location = New System.Drawing.Point(418, 467)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(75, 63)
        Me.RadButton4.TabIndex = 51
        Me.RadButton4.Text = "Cancelar"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(321, 467)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(75, 63)
        Me.RadButton3.TabIndex = 50
        Me.RadButton3.Text = "Restaurar Dados Originais"
        Me.RadButton3.TextWrap = True
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(226, 467)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(75, 63)
        Me.RadButton2.TabIndex = 49
        Me.RadButton2.Text = "Remover"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(131, 467)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(75, 63)
        Me.RadButton1.TabIndex = 48
        Me.RadButton1.Text = "Editar"
        '
        'RadButton5
        '
        Me.RadButton5.Location = New System.Drawing.Point(35, 467)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(75, 63)
        Me.RadButton5.TabIndex = 47
        Me.RadButton5.Text = "Adicionar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(281, 86)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Técnicos"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(196, 156)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Turma"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Nome"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "NºAluno"
        '
        'turmabox
        '
        Me.turmabox.Location = New System.Drawing.Point(201, 184)
        Me.turmabox.Name = "turmabox"
        Me.turmabox.Size = New System.Drawing.Size(100, 20)
        Me.turmabox.TabIndex = 40
        '
        'nomebox
        '
        Me.nomebox.Location = New System.Drawing.Point(32, 266)
        Me.nomebox.Name = "nomebox"
        Me.nomebox.Size = New System.Drawing.Size(243, 20)
        Me.nomebox.TabIndex = 38
        '
        'numalunobox
        '
        Me.numalunobox.Location = New System.Drawing.Point(35, 184)
        Me.numalunobox.Name = "numalunobox"
        Me.numalunobox.Size = New System.Drawing.Size(124, 20)
        Me.numalunobox.TabIndex = 37
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(383, 40)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 141)
        Me.PictureBox1.TabIndex = 55
        Me.PictureBox1.TabStop = False
        '
        'RadButton6
        '
        Me.RadButton6.Location = New System.Drawing.Point(418, 213)
        Me.RadButton6.Name = "RadButton6"
        Me.RadButton6.Size = New System.Drawing.Size(56, 25)
        Me.RadButton6.TabIndex = 57
        Me.RadButton6.Text = "Procurar"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(383, 187)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 58
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 301)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(153, 25)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Contacto Móvel"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(32, 329)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(243, 20)
        Me.TextBox2.TabIndex = 59
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(27, 362)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 25)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Contacto Fixo"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(32, 390)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(243, 20)
        Me.TextBox3.TabIndex = 61
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'OPR_Técnicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(569, 553)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.RadButton6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RadButton4)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadButton5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.turmabox)
        Me.Controls.Add(Me.nomebox)
        Me.Controls.Add(Me.numalunobox)
        Me.Name = "OPR_Técnicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Técnicos"
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents turmabox As System.Windows.Forms.TextBox
    Friend WithEvents nomebox As System.Windows.Forms.TextBox
    Friend WithEvents numalunobox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents RadButton6 As Telerik.WinControls.UI.RadButton
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
