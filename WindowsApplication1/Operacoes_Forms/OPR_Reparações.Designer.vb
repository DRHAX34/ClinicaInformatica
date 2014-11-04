<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OPR_Reparações
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
        Me.components = New System.ComponentModel.Container()
        Me.descriçaobox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dateinicio = New System.Windows.Forms.DateTimePicker()
        Me.clienteshow = New System.Windows.Forms.Label()
        Me.clientelabel = New System.Windows.Forms.Label()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.nomeclientelabel = New System.Windows.Forms.Label()
        Me.restartbutton = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.savebutton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'descriçaobox
        '
        Me.descriçaobox.Enabled = False
        Me.descriçaobox.Location = New System.Drawing.Point(27, 259)
        Me.descriçaobox.MaxLength = 255
        Me.descriçaobox.Multiline = True
        Me.descriçaobox.Name = "descriçaobox"
        Me.descriçaobox.Size = New System.Drawing.Size(473, 117)
        Me.descriçaobox.TabIndex = 58
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(171, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(185, 25)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Descrição da Avaria"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(211, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 25)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Data Inicio"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(112, 12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(362, 86)
        Me.Label6.TabIndex = 46
        Me.Label6.Text = "Reparações"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(335, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Artigo:"
        '
        'dateinicio
        '
        Me.dateinicio.Location = New System.Drawing.Point(152, 197)
        Me.dateinicio.Name = "dateinicio"
        Me.dateinicio.Size = New System.Drawing.Size(232, 22)
        Me.dateinicio.TabIndex = 62
        Me.dateinicio.Value = New Date(2014, 7, 3, 0, 6, 0, 0)
        '
        'clienteshow
        '
        Me.clienteshow.AutoSize = True
        Me.clienteshow.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.clienteshow.Location = New System.Drawing.Point(31, 144)
        Me.clienteshow.MaximumSize = New System.Drawing.Size(232, 25)
        Me.clienteshow.Name = "clienteshow"
        Me.clienteshow.Size = New System.Drawing.Size(232, 25)
        Me.clienteshow.TabIndex = 1
        Me.clienteshow.Text = "(clieeeeeeeeeeeeetteeeee"
        '
        'clientelabel
        '
        Me.clientelabel.AutoSize = True
        Me.clientelabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.clientelabel.Location = New System.Drawing.Point(31, 119)
        Me.clientelabel.Name = "clientelabel"
        Me.clientelabel.Size = New System.Drawing.Size(78, 25)
        Me.clientelabel.TabIndex = 0
        Me.clientelabel.Text = "Cliente:"
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'Timer4
        '
        Me.Timer4.Interval = 1
        '
        'nomeclientelabel
        '
        Me.nomeclientelabel.AutoSize = True
        Me.nomeclientelabel.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.nomeclientelabel.Location = New System.Drawing.Point(335, 144)
        Me.nomeclientelabel.MaximumSize = New System.Drawing.Size(200, 25)
        Me.nomeclientelabel.Name = "nomeclientelabel"
        Me.nomeclientelabel.Size = New System.Drawing.Size(165, 25)
        Me.nomeclientelabel.TabIndex = 82
        Me.nomeclientelabel.Text = "Não selecionado!"
        '
        'restartbutton
        '
        Me.restartbutton.Location = New System.Drawing.Point(299, 401)
        Me.restartbutton.Name = "restartbutton"
        Me.restartbutton.Size = New System.Drawing.Size(97, 41)
        Me.restartbutton.TabIndex = 102
        Me.restartbutton.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(403, 401)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(97, 41)
        Me.exitbutton.TabIndex = 101
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'savebutton
        '
        Me.savebutton.Location = New System.Drawing.Point(27, 401)
        Me.savebutton.Name = "savebutton"
        Me.savebutton.Size = New System.Drawing.Size(97, 41)
        Me.savebutton.TabIndex = 99
        Me.savebutton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ClinicaInformatica.My.Resources.Resources.repair
        Me.PictureBox1.Location = New System.Drawing.Point(36, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(88, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 66
        Me.PictureBox1.TabStop = False
        '
        'OPR_Reparações
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(529, 454)
        Me.Controls.Add(Me.clienteshow)
        Me.Controls.Add(Me.clientelabel)
        Me.Controls.Add(Me.restartbutton)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.nomeclientelabel)
        Me.Controls.Add(Me.savebutton)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dateinicio)
        Me.Controls.Add(Me.descriçaobox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.Name = "OPR_Reparações"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Operações Reparações"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents descriçaobox As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dateinicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents nomeclientelabel As System.Windows.Forms.Label
    Friend WithEvents clienteshow As System.Windows.Forms.Label
    Friend WithEvents clientelabel As System.Windows.Forms.Label
    Friend WithEvents restartbutton As System.Windows.Forms.Button
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents savebutton As System.Windows.Forms.Button
End Class
