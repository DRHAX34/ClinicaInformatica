<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewForm
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

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.showdata = New System.Windows.Forms.DataGridView()
        Me.newbutton = New System.Windows.Forms.Button()
        Me.delbutton = New System.Windows.Forms.Button()
        Me.findbutton = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(230, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 57)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Localizar"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TextBox1.Location = New System.Drawing.Point(6, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 22)
        Me.TextBox1.TabIndex = 2
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.CheckBox1.Location = New System.Drawing.Point(604, 311)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Removidos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'showdata
        '
        Me.showdata.AllowUserToAddRows = False
        Me.showdata.AllowUserToDeleteRows = False
        Me.showdata.AllowUserToOrderColumns = True
        Me.showdata.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.showdata.Location = New System.Drawing.Point(12, 12)
        Me.showdata.Name = "showdata"
        Me.showdata.ReadOnly = True
        Me.showdata.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.showdata.Size = New System.Drawing.Size(667, 293)
        Me.showdata.TabIndex = 12
        '
        'newbutton
        '
        Me.newbutton.Image = Global.ClinicaInformatica.My.Resources.Resources._1405624626_Add
        Me.newbutton.Location = New System.Drawing.Point(12, 329)
        Me.newbutton.Name = "newbutton"
        Me.newbutton.Size = New System.Drawing.Size(86, 47)
        Me.newbutton.TabIndex = 13
        Me.newbutton.UseVisualStyleBackColor = True
        '
        'delbutton
        '
        Me.delbutton.Location = New System.Drawing.Point(104, 329)
        Me.delbutton.Name = "delbutton"
        Me.delbutton.Size = New System.Drawing.Size(86, 47)
        Me.delbutton.TabIndex = 14
        Me.delbutton.UseVisualStyleBackColor = True
        '
        'findbutton
        '
        Me.findbutton.Location = New System.Drawing.Point(501, 329)
        Me.findbutton.Name = "findbutton"
        Me.findbutton.Size = New System.Drawing.Size(86, 47)
        Me.findbutton.TabIndex = 15
        Me.findbutton.UseVisualStyleBackColor = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(593, 329)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(86, 47)
        Me.exitbutton.TabIndex = 16
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(691, 398)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.findbutton)
        Me.Controls.Add(Me.delbutton)
        Me.Controls.Add(Me.newbutton)
        Me.Controls.Add(Me.showdata)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(707, 303)
        Me.Name = "ViewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generic Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents showdata As System.Windows.Forms.DataGridView
    Friend WithEvents newbutton As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer
    Friend WithEvents delbutton As System.Windows.Forms.Button
    Friend WithEvents findbutton As System.Windows.Forms.Button
    Friend WithEvents exitbutton As System.Windows.Forms.Button
End Class
