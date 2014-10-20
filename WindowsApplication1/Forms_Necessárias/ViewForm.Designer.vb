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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewForm))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtProcurar = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.showdata = New System.Windows.Forms.DataGridView()
        Me.newbutton = New System.Windows.Forms.Button()
        Me.delbutton = New System.Windows.Forms.Button()
        Me.exitbutton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menuContexto = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.primeiroMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuContexto.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtProcurar)
        Me.GroupBox1.Location = New System.Drawing.Point(230, 329)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(232, 57)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Localizar"
        '
        'txtProcurar
        '
        Me.txtProcurar.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.txtProcurar.Location = New System.Drawing.Point(6, 19)
        Me.txtProcurar.Name = "txtProcurar"
        Me.txtProcurar.Size = New System.Drawing.Size(217, 22)
        Me.txtProcurar.TabIndex = 2
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
        Me.showdata.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.showdata.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.showdata.Location = New System.Drawing.Point(12, 62)
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
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(593, 329)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(86, 47)
        Me.exitbutton.TabIndex = 16
        Me.exitbutton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(406, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 37)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "txtCurrent"
        '
        'menuContexto
        '
        Me.menuContexto.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.primeiroMenuItem, Me.EditarMenuItem1})
        Me.menuContexto.Name = "menuContexto"
        Me.menuContexto.Size = New System.Drawing.Size(105, 48)
        '
        'primeiroMenuItem
        '
        Me.primeiroMenuItem.Name = "primeiroMenuItem"
        Me.primeiroMenuItem.Size = New System.Drawing.Size(104, 22)
        Me.primeiroMenuItem.Text = "Editar"
        '
        'EditarMenuItem1
        '
        Me.EditarMenuItem1.Name = "EditarMenuItem1"
        Me.EditarMenuItem1.Size = New System.Drawing.Size(104, 22)
        Me.EditarMenuItem1.Text = "Editar"
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1005, 506)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.delbutton)
        Me.Controls.Add(Me.newbutton)
        Me.Controls.Add(Me.showdata)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(707, 303)
        Me.Name = "ViewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generic Form"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuContexto.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtProcurar As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents showdata As System.Windows.Forms.DataGridView
    Friend WithEvents newbutton As System.Windows.Forms.Button
    Private components As System.ComponentModel.IContainer
    Friend WithEvents delbutton As System.Windows.Forms.Button
    Friend WithEvents exitbutton As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents menuContexto As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents primeiroMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EditarMenuItem1 As System.Windows.Forms.ToolStripMenuItem
End Class
