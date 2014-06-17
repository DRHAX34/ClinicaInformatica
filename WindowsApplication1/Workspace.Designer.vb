<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Workspace
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Workspace))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.clientesmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RemovidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dispositivosmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.reparacoesmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tecnicosmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilizadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.terminarsessaobutton = New Telerik.WinControls.UI.RadButton()
        Me.MenuStrip.SuspendLayout()
        CType(Me.terminarsessaobutton, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusStrip.Location = New System.Drawing.Point(0, 446)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1019, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(46, 17)
        Me.ToolStripStatusLabel.Text = "Pronto!"
        '
        'MenuStrip
        '
        Me.MenuStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clientesmenu, Me.dispositivosmenu, Me.reparacoesmenu, Me.tecnicosmenu, Me.UtilizadoresToolStripMenuItem, Me.EmpresasToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.tecnicosmenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1019, 62)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'clientesmenu
        '
        Me.clientesmenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtivosToolStripMenuItem, Me.RemovidosToolStripMenuItem})
        Me.clientesmenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_30101554lClK1zzf
        Me.clientesmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.clientesmenu.Name = "clientesmenu"
        Me.clientesmenu.Size = New System.Drawing.Size(115, 58)
        Me.clientesmenu.Text = "Clientes"
        '
        'AtivosToolStripMenuItem
        '
        Me.AtivosToolStripMenuItem.Name = "AtivosToolStripMenuItem"
        Me.AtivosToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AtivosToolStripMenuItem.Text = "Ativos"
        '
        'RemovidosToolStripMenuItem
        '
        Me.RemovidosToolStripMenuItem.Name = "RemovidosToolStripMenuItem"
        Me.RemovidosToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.RemovidosToolStripMenuItem.Text = "Removidos"
        '
        'dispositivosmenu
        '
        Me.dispositivosmenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_30101754Hz7aSVUe
        Me.dispositivosmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.dispositivosmenu.Name = "dispositivosmenu"
        Me.dispositivosmenu.Size = New System.Drawing.Size(148, 58)
        Me.dispositivosmenu.Text = "Componentes"
        '
        'reparacoesmenu
        '
        Me.reparacoesmenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_30101423KaMIRkur
        Me.reparacoesmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.reparacoesmenu.Name = "reparacoesmenu"
        Me.reparacoesmenu.Size = New System.Drawing.Size(133, 58)
        Me.reparacoesmenu.Text = "Reparações"
        '
        'tecnicosmenu
        '
        Me.tecnicosmenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_301011418NFe0o9M1
        Me.tecnicosmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tecnicosmenu.Name = "tecnicosmenu"
        Me.tecnicosmenu.Size = New System.Drawing.Size(120, 58)
        Me.tecnicosmenu.Text = "Técnicos"
        '
        'UtilizadoresToolStripMenuItem
        '
        Me.UtilizadoresToolStripMenuItem.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_3010633jb6OZwQ5
        Me.UtilizadoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UtilizadoresToolStripMenuItem.Name = "UtilizadoresToolStripMenuItem"
        Me.UtilizadoresToolStripMenuItem.Size = New System.Drawing.Size(134, 58)
        Me.UtilizadoresToolStripMenuItem.Text = "Utilizadores"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.Image = Global.ClinicaInformatica.My.Resources.Resources.companyicon
        Me.EmpresasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(123, 58)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SearchToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem})
        Me.HelpMenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_transparent
        Me.HelpMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(104, 58)
        Me.HelpMenu.Text = "Ajuda"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F1), System.Windows.Forms.Keys)
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.ContentsToolStripMenuItem.Text = "&Conteúdo"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.IndexToolStripMenuItem.Text = "&Índice"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Image = CType(resources.GetObject("SearchToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.SearchToolStripMenuItem.Text = "&Procurar"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(170, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.AboutToolStripMenuItem.Text = "&Sobre ..."
        '
        'terminarsessaobutton
        '
        Me.terminarsessaobutton.Location = New System.Drawing.Point(908, 12)
        Me.terminarsessaobutton.Name = "terminarsessaobutton"
        Me.terminarsessaobutton.Size = New System.Drawing.Size(99, 39)
        Me.terminarsessaobutton.TabIndex = 49
        Me.terminarsessaobutton.Text = "Terminar Sessão"
        '
        'Workspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1019, 468)
        Me.Controls.Add(Me.terminarsessaobutton)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(863, 506)
        Me.Name = "Workspace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clínica Informática"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        CType(Me.terminarsessaobutton, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents clientesmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dispositivosmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents reparacoesmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tecnicosmenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents UtilizadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AtivosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RemovidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents terminarsessaobutton As Telerik.WinControls.UI.RadButton

End Class
