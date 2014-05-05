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
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadButton1 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton2 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton3 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton4 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton5 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton6 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton7 = New Telerik.WinControls.UI.RadButton()
        Me.RadButton8 = New Telerik.WinControls.UI.RadButton()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGridView1
        '
        Me.RadGridView1.Location = New System.Drawing.Point(13, 13)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Padding = New System.Windows.Forms.Padding(1)
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(709, 335)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        Me.RadGridView1.ThemeName = "Windows8"
        '
        'RadButton1
        '
        Me.RadButton1.Location = New System.Drawing.Point(13, 364)
        Me.RadButton1.Name = "RadButton1"
        Me.RadButton1.Size = New System.Drawing.Size(102, 38)
        Me.RadButton1.TabIndex = 1
        Me.RadButton1.Text = "Novo"
        '
        'RadButton2
        '
        Me.RadButton2.Location = New System.Drawing.Point(13, 417)
        Me.RadButton2.Name = "RadButton2"
        Me.RadButton2.Size = New System.Drawing.Size(102, 38)
        Me.RadButton2.TabIndex = 2
        Me.RadButton2.Text = "Eliminar"
        '
        'RadButton3
        '
        Me.RadButton3.Location = New System.Drawing.Point(137, 364)
        Me.RadButton3.Name = "RadButton3"
        Me.RadButton3.Size = New System.Drawing.Size(102, 38)
        Me.RadButton3.TabIndex = 3
        Me.RadButton3.Text = "Editar"
        '
        'RadButton4
        '
        Me.RadButton4.Location = New System.Drawing.Point(137, 417)
        Me.RadButton4.Name = "RadButton4"
        Me.RadButton4.Size = New System.Drawing.Size(102, 38)
        Me.RadButton4.TabIndex = 4
        Me.RadButton4.Text = "Atualizar"
        '
        'RadButton5
        '
        Me.RadButton5.Location = New System.Drawing.Point(494, 364)
        Me.RadButton5.Name = "RadButton5"
        Me.RadButton5.Size = New System.Drawing.Size(102, 38)
        Me.RadButton5.TabIndex = 5
        Me.RadButton5.Text = "Localizar"
        '
        'RadButton6
        '
        Me.RadButton6.Location = New System.Drawing.Point(620, 364)
        Me.RadButton6.Name = "RadButton6"
        Me.RadButton6.Size = New System.Drawing.Size(102, 38)
        Me.RadButton6.TabIndex = 6
        Me.RadButton6.Text = "Mostrar Dados Completos"
        Me.RadButton6.TextWrap = True
        '
        'RadButton7
        '
        Me.RadButton7.Location = New System.Drawing.Point(620, 417)
        Me.RadButton7.Name = "RadButton7"
        Me.RadButton7.Size = New System.Drawing.Size(102, 38)
        Me.RadButton7.TabIndex = 7
        Me.RadButton7.Text = "Sair"
        '
        'RadButton8
        '
        Me.RadButton8.Location = New System.Drawing.Point(494, 417)
        Me.RadButton8.Name = "RadButton8"
        Me.RadButton8.Size = New System.Drawing.Size(102, 38)
        Me.RadButton8.TabIndex = 8
        Me.RadButton8.Text = "Outras Funções"
        Me.RadButton8.TextWrap = True
        '
        'ViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(734, 467)
        Me.Controls.Add(Me.RadButton8)
        Me.Controls.Add(Me.RadButton7)
        Me.Controls.Add(Me.RadButton6)
        Me.Controls.Add(Me.RadButton5)
        Me.Controls.Add(Me.RadButton4)
        Me.Controls.Add(Me.RadButton3)
        Me.Controls.Add(Me.RadButton2)
        Me.Controls.Add(Me.RadButton1)
        Me.Controls.Add(Me.RadGridView1)
        Me.Name = "ViewForm"
        Me.Text = "Form2"
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadButton8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadButton1 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton2 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton3 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton4 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton5 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton6 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton7 As Telerik.WinControls.UI.RadButton
    Friend WithEvents RadButton8 As Telerik.WinControls.UI.RadButton
End Class
