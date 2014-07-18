<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Selectform
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.showdata = New Telerik.WinControls.UI.RadGridView()
        Me.adicionarbutton = New Telerik.WinControls.UI.RadButton()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showdata.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adicionarbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Procurar:"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(127, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(206, 35)
        Me.TextBox1.TabIndex = 1
        '
        'showdata
        '
        Me.showdata.AutoSizeRows = True
        Me.showdata.Location = New System.Drawing.Point(19, 50)
        '
        'showdata
        '
        Me.showdata.MasterTemplate.AllowAddNewRow = False
        Me.showdata.MasterTemplate.AllowColumnResize = False
        Me.showdata.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.showdata.Name = "showdata"
        Me.showdata.Padding = New System.Windows.Forms.Padding(1)
        Me.showdata.ReadOnly = True
        Me.showdata.Size = New System.Drawing.Size(583, 277)
        Me.showdata.TabIndex = 10
        Me.showdata.Text = "Data"
        Me.showdata.ThemeName = "Windows8"
        '
        'adicionarbutton
        '
        Me.adicionarbutton.Image = Global.ClinicaInformatica.My.Resources.Resources._1405695721_Select
        Me.adicionarbutton.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.adicionarbutton.Location = New System.Drawing.Point(531, 333)
        Me.adicionarbutton.Name = "adicionarbutton"
        Me.adicionarbutton.Size = New System.Drawing.Size(71, 53)
        Me.adicionarbutton.TabIndex = 22
        '
        'Selectform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(614, 394)
        Me.Controls.Add(Me.adicionarbutton)
        Me.Controls.Add(Me.showdata)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Selectform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Selecionar"
        CType(Me.showdata.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adicionarbutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents showdata As Telerik.WinControls.UI.RadGridView
    Friend WithEvents adicionarbutton As Telerik.WinControls.UI.RadButton
End Class
