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
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: O procedimento a seguir é exigido pelo Windows Form Designer
    'Ele pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewForm))
        Me.showdata = New Telerik.WinControls.UI.RadGridView()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.newbutton = New Telerik.WinControls.UI.RadButton()
        Me.delbutton = New Telerik.WinControls.UI.RadButton()
        Me.editbutton = New Telerik.WinControls.UI.RadButton()
        Me.updatebutton = New Telerik.WinControls.UI.RadButton()
        Me.findbutton = New Telerik.WinControls.UI.RadButton()
        Me.showbutton = New Telerik.WinControls.UI.RadButton()
        Me.exitbutton = New Telerik.WinControls.UI.RadButton()
        Me.othersbutton = New Telerik.WinControls.UI.RadButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showdata.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.newbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.delbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.editbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.updatebutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.findbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.exitbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.othersbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'showdata
        '
        Me.showdata.AutoSizeRows = True
        Me.showdata.Location = New System.Drawing.Point(13, 13)
        '
        'showdata
        '
        Me.showdata.MasterTemplate.AllowAddNewRow = False
        Me.showdata.MasterTemplate.AllowColumnResize = False
        Me.showdata.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.showdata.Name = "showdata"
        Me.showdata.Padding = New System.Windows.Forms.Padding(1)
        Me.showdata.ReadOnly = True
        Me.showdata.Size = New System.Drawing.Size(709, 322)
        Me.showdata.TabIndex = 0
        Me.showdata.Text = "Data"
        Me.showdata.ThemeName = "Windows8"
        '
        'newbutton
        '
        Me.newbutton.Location = New System.Drawing.Point(13, 364)
        Me.newbutton.Name = "newbutton"
        Me.newbutton.Size = New System.Drawing.Size(102, 38)
        Me.newbutton.TabIndex = 1
        Me.newbutton.Text = "Novo"
        Me.newbutton.ThemeName = "Windows8"
        '
        'delbutton
        '
        Me.delbutton.Location = New System.Drawing.Point(13, 417)
        Me.delbutton.Name = "delbutton"
        Me.delbutton.Size = New System.Drawing.Size(102, 38)
        Me.delbutton.TabIndex = 2
        Me.delbutton.Text = "Eliminar"
        Me.delbutton.ThemeName = "Windows8"
        '
        'editbutton
        '
        Me.editbutton.Location = New System.Drawing.Point(137, 364)
        Me.editbutton.Name = "editbutton"
        Me.editbutton.Size = New System.Drawing.Size(102, 38)
        Me.editbutton.TabIndex = 3
        Me.editbutton.Text = "Editar"
        Me.editbutton.ThemeName = "Windows8"
        '
        'updatebutton
        '
        Me.updatebutton.Location = New System.Drawing.Point(137, 417)
        Me.updatebutton.Name = "updatebutton"
        Me.updatebutton.Size = New System.Drawing.Size(102, 38)
        Me.updatebutton.TabIndex = 4
        Me.updatebutton.Text = "Atualizar"
        Me.updatebutton.ThemeName = "Windows8"
        '
        'findbutton
        '
        Me.findbutton.Location = New System.Drawing.Point(494, 364)
        Me.findbutton.Name = "findbutton"
        Me.findbutton.Size = New System.Drawing.Size(102, 38)
        Me.findbutton.TabIndex = 5
        Me.findbutton.Text = "Localizar"
        Me.findbutton.ThemeName = "Windows8"
        '
        'showbutton
        '
        Me.showbutton.Location = New System.Drawing.Point(620, 364)
        Me.showbutton.Name = "showbutton"
        Me.showbutton.Size = New System.Drawing.Size(102, 38)
        Me.showbutton.TabIndex = 6
        Me.showbutton.Text = "Mostrar Dados Completos"
        Me.showbutton.TextWrap = True
        Me.showbutton.ThemeName = "Windows8"
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(620, 417)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(102, 38)
        Me.exitbutton.TabIndex = 7
        Me.exitbutton.Text = "Sair"
        Me.exitbutton.ThemeName = "Windows8"
        '
        'othersbutton
        '
        Me.othersbutton.Location = New System.Drawing.Point(494, 417)
        Me.othersbutton.Name = "othersbutton"
        Me.othersbutton.Size = New System.Drawing.Size(102, 38)
        Me.othersbutton.TabIndex = 8
        Me.othersbutton.Text = "Outras Funções"
        Me.othersbutton.TextWrap = True
        Me.othersbutton.ThemeName = "Windows8"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(315, 351)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Atualizado!"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 5000
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(259, 355)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(229, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Localizar"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.TextBox1.Location = New System.Drawing.Point(6, 52)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(217, 22)
        Me.TextBox1.TabIndex = 2
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(133, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(6, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.CheckBox1.Location = New System.Drawing.Point(640, 341)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(82, 17)
        Me.CheckBox1.TabIndex = 11
        Me.CheckBox1.Text = "Removidos"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(741, 464)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.othersbutton)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.showbutton)
        Me.Controls.Add(Me.findbutton)
        Me.Controls.Add(Me.updatebutton)
        Me.Controls.Add(Me.editbutton)
        Me.Controls.Add(Me.delbutton)
        Me.Controls.Add(Me.newbutton)
        Me.Controls.Add(Me.showdata)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(757, 303)
        Me.Name = "ViewForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Generic Form"
        CType(Me.showdata.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.newbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.delbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.editbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.updatebutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.findbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.exitbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.othersbutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents showdata As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents newbutton As Telerik.WinControls.UI.RadButton
    Friend WithEvents delbutton As Telerik.WinControls.UI.RadButton
    Friend WithEvents editbutton As Telerik.WinControls.UI.RadButton
    Friend WithEvents updatebutton As Telerik.WinControls.UI.RadButton
    Friend WithEvents findbutton As Telerik.WinControls.UI.RadButton
    Friend WithEvents showbutton As Telerik.WinControls.UI.RadButton
    Friend WithEvents exitbutton As Telerik.WinControls.UI.RadButton
    Friend WithEvents othersbutton As Telerik.WinControls.UI.RadButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
End Class
