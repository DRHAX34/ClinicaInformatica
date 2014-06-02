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
        Me.SuspendLayout()
        '
        'showdata
        '
        Me.showdata.Location = New System.Drawing.Point(13, 13)
        '
        'showdata
        '
        Me.showdata.MasterTemplate.AllowAddNewRow = False
        Me.showdata.Name = "showdata"
        Me.showdata.Padding = New System.Windows.Forms.Padding(1)
        Me.showdata.ReadOnly = True
        Me.showdata.Size = New System.Drawing.Size(709, 335)
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
        '
        'delbutton
        '
        Me.delbutton.Location = New System.Drawing.Point(13, 417)
        Me.delbutton.Name = "delbutton"
        Me.delbutton.Size = New System.Drawing.Size(102, 38)
        Me.delbutton.TabIndex = 2
        Me.delbutton.Text = "Eliminar"
        '
        'editbutton
        '
        Me.editbutton.Location = New System.Drawing.Point(137, 364)
        Me.editbutton.Name = "editbutton"
        Me.editbutton.Size = New System.Drawing.Size(102, 38)
        Me.editbutton.TabIndex = 3
        Me.editbutton.Text = "Editar"
        '
        'updatebutton
        '
        Me.updatebutton.Location = New System.Drawing.Point(137, 417)
        Me.updatebutton.Name = "updatebutton"
        Me.updatebutton.Size = New System.Drawing.Size(102, 38)
        Me.updatebutton.TabIndex = 4
        Me.updatebutton.Text = "Atualizar"
        '
        'findbutton
        '
        Me.findbutton.Location = New System.Drawing.Point(494, 364)
        Me.findbutton.Name = "findbutton"
        Me.findbutton.Size = New System.Drawing.Size(102, 38)
        Me.findbutton.TabIndex = 5
        Me.findbutton.Text = "Localizar"
        '
        'showbutton
        '
        Me.showbutton.Location = New System.Drawing.Point(620, 364)
        Me.showbutton.Name = "showbutton"
        Me.showbutton.Size = New System.Drawing.Size(102, 38)
        Me.showbutton.TabIndex = 6
        Me.showbutton.Text = "Mostrar Dados Completos"
        Me.showbutton.TextWrap = True
        '
        'exitbutton
        '
        Me.exitbutton.Location = New System.Drawing.Point(620, 417)
        Me.exitbutton.Name = "exitbutton"
        Me.exitbutton.Size = New System.Drawing.Size(102, 38)
        Me.exitbutton.TabIndex = 7
        Me.exitbutton.Text = "Sair"
        '
        'othersbutton
        '
        Me.othersbutton.Location = New System.Drawing.Point(494, 417)
        Me.othersbutton.Name = "othersbutton"
        Me.othersbutton.Size = New System.Drawing.Size(102, 38)
        Me.othersbutton.TabIndex = 8
        Me.othersbutton.Text = "Outras Funções"
        Me.othersbutton.TextWrap = True
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 467)
        Me.Controls.Add(Me.othersbutton)
        Me.Controls.Add(Me.exitbutton)
        Me.Controls.Add(Me.showbutton)
        Me.Controls.Add(Me.findbutton)
        Me.Controls.Add(Me.updatebutton)
        Me.Controls.Add(Me.editbutton)
        Me.Controls.Add(Me.delbutton)
        Me.Controls.Add(Me.newbutton)
        Me.Controls.Add(Me.showdata)
        Me.Name = "ViewForm"
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
        Me.ResumeLayout(False)

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
End Class
