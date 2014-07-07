<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class otheroptions
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
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.repar_entregabox = New Telerik.WinControls.UI.RadButton()
        Me.repara_orçabox = New Telerik.WinControls.UI.RadButton()
        Me.percentagem_clientesbox = New Telerik.WinControls.UI.RadButton()
        Me.repar_localbox = New Telerik.WinControls.UI.RadButton()
        Me.tempo_mediobox = New Telerik.WinControls.UI.RadButton()
        Me.Sair = New Telerik.WinControls.UI.RadButton()
        CType(Me.repar_entregabox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repara_orçabox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.percentagem_clientesbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.repar_localbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tempo_mediobox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sair, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'repar_entregabox
        '
        Me.repar_entregabox.Location = New System.Drawing.Point(108, 12)
        Me.repar_entregabox.Name = "repar_entregabox"
        Me.repar_entregabox.Size = New System.Drawing.Size(102, 60)
        Me.repar_entregabox.TabIndex = 2
        Me.repar_entregabox.Text = "Folha de Reparação para Entrega"
        Me.repar_entregabox.TextWrap = True
        Me.repar_entregabox.ThemeName = "Windows8"
        '
        'repara_orçabox
        '
        Me.repara_orçabox.Location = New System.Drawing.Point(108, 78)
        Me.repara_orçabox.Name = "repara_orçabox"
        Me.repara_orçabox.Size = New System.Drawing.Size(102, 38)
        Me.repara_orçabox.TabIndex = 2
        Me.repara_orçabox.Text = "Folha Reparação Orçamento"
        Me.repara_orçabox.TextWrap = True
        Me.repara_orçabox.ThemeName = "Windows8"
        '
        'percentagem_clientesbox
        '
        Me.percentagem_clientesbox.Location = New System.Drawing.Point(108, 122)
        Me.percentagem_clientesbox.Name = "percentagem_clientesbox"
        Me.percentagem_clientesbox.Size = New System.Drawing.Size(102, 38)
        Me.percentagem_clientesbox.TabIndex = 2
        Me.percentagem_clientesbox.Text = "Percentagens de Clientes Alunos"
        Me.percentagem_clientesbox.ThemeName = "Windows8"
        '
        'repar_localbox
        '
        Me.repar_localbox.Location = New System.Drawing.Point(108, 166)
        Me.repar_localbox.Name = "repar_localbox"
        Me.repar_localbox.Size = New System.Drawing.Size(102, 38)
        Me.repar_localbox.TabIndex = 2
        Me.repar_localbox.Text = "Reparações por Localidade"
        Me.repar_localbox.TextWrap = True
        Me.repar_localbox.ThemeName = "Windows8"
        '
        'tempo_mediobox
        '
        Me.tempo_mediobox.Location = New System.Drawing.Point(108, 210)
        Me.tempo_mediobox.Name = "tempo_mediobox"
        Me.tempo_mediobox.Size = New System.Drawing.Size(102, 38)
        Me.tempo_mediobox.TabIndex = 2
        Me.tempo_mediobox.Text = "Tempo Médio de Reparações"
        Me.tempo_mediobox.TextWrap = True
        Me.tempo_mediobox.ThemeName = "Windows8"
        '
        'Sair
        '
        Me.Sair.Location = New System.Drawing.Point(226, 254)
        Me.Sair.Name = "Sair"
        Me.Sair.Size = New System.Drawing.Size(102, 38)
        Me.Sair.TabIndex = 2
        Me.Sair.Text = "Sair"
        Me.Sair.ThemeName = "Windows8"
        '
        'otheroptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(340, 304)
        Me.Controls.Add(Me.Sair)
        Me.Controls.Add(Me.tempo_mediobox)
        Me.Controls.Add(Me.repar_localbox)
        Me.Controls.Add(Me.percentagem_clientesbox)
        Me.Controls.Add(Me.repara_orçabox)
        Me.Controls.Add(Me.repar_entregabox)
        Me.Name = "otheroptions"
        Me.Text = "otheroptions"
        CType(Me.repar_entregabox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repara_orçabox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.percentagem_clientesbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.repar_localbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tempo_mediobox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sair, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents repar_entregabox As Telerik.WinControls.UI.RadButton
    Friend WithEvents repara_orçabox As Telerik.WinControls.UI.RadButton
    Friend WithEvents percentagem_clientesbox As Telerik.WinControls.UI.RadButton
    Friend WithEvents repar_localbox As Telerik.WinControls.UI.RadButton
    Friend WithEvents tempo_mediobox As Telerik.WinControls.UI.RadButton
    Friend WithEvents Sair As Telerik.WinControls.UI.RadButton
End Class
