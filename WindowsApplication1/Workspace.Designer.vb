﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.clientesmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.dispositivosmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.reparacoesmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.tecnicosmenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilizadoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.terminarsessao = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpresasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.empresasativas = New System.Windows.Forms.ToolStripMenuItem()
        Me.empresasremovidas = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupDeDadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestauroDeDadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Statuscheck = New System.Windows.Forms.Timer(Me.components)
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.StatusStrip.SuspendLayout()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 446)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1102, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
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
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.clientesmenu, Me.dispositivosmenu, Me.reparacoesmenu, Me.tecnicosmenu, Me.EmpresasToolStripMenuItem, Me.HelpMenu, Me.UtilizadoresToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.MdiWindowListItem = Me.tecnicosmenu
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1102, 62)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'clientesmenu
        '
        Me.clientesmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.clientesmenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_30101554lClK1zzf
        Me.clientesmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.clientesmenu.Name = "clientesmenu"
        Me.clientesmenu.Size = New System.Drawing.Size(117, 58)
        Me.clientesmenu.Text = "Clientes"
        '
        'dispositivosmenu
        '
        Me.dispositivosmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.dispositivosmenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_30101754Hz7aSVUe
        Me.dispositivosmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.dispositivosmenu.Name = "dispositivosmenu"
        Me.dispositivosmenu.Size = New System.Drawing.Size(113, 58)
        Me.dispositivosmenu.Text = "Artigos"
        '
        'reparacoesmenu
        '
        Me.reparacoesmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.reparacoesmenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_2417311E0OBPz25
        Me.reparacoesmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.reparacoesmenu.Name = "reparacoesmenu"
        Me.reparacoesmenu.Size = New System.Drawing.Size(137, 58)
        Me.reparacoesmenu.Text = "Reparações"
        '
        'tecnicosmenu
        '
        Me.tecnicosmenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.tecnicosmenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_301011418NFe0o9M1
        Me.tecnicosmenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tecnicosmenu.Name = "tecnicosmenu"
        Me.tecnicosmenu.Size = New System.Drawing.Size(121, 58)
        Me.tecnicosmenu.Text = "Técnicos"
        '
        'UtilizadoresToolStripMenuItem
        '
        Me.UtilizadoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.terminarsessao})
        Me.UtilizadoresToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UtilizadoresToolStripMenuItem.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_3010633jb6OZwQ5
        Me.UtilizadoresToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UtilizadoresToolStripMenuItem.Name = "UtilizadoresToolStripMenuItem"
        Me.UtilizadoresToolStripMenuItem.Size = New System.Drawing.Size(127, 58)
        Me.UtilizadoresToolStripMenuItem.Text = "Utilizador"
        '
        'terminarsessao
        '
        Me.terminarsessao.Name = "terminarsessao"
        Me.terminarsessao.Size = New System.Drawing.Size(165, 22)
        Me.terminarsessao.Text = "Terminar Sessão"
        '
        'EmpresasToolStripMenuItem
        '
        Me.EmpresasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.empresasativas, Me.empresasremovidas})
        Me.EmpresasToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.EmpresasToolStripMenuItem.Image = Global.ClinicaInformatica.My.Resources.Resources.companyicon
        Me.EmpresasToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EmpresasToolStripMenuItem.Name = "EmpresasToolStripMenuItem"
        Me.EmpresasToolStripMenuItem.Size = New System.Drawing.Size(125, 58)
        Me.EmpresasToolStripMenuItem.Text = "Empresas"
        '
        'empresasativas
        '
        Me.empresasativas.Name = "empresasativas"
        Me.empresasativas.Size = New System.Drawing.Size(135, 22)
        Me.empresasativas.Text = "Ativas"
        '
        'empresasremovidas
        '
        Me.empresasremovidas.Name = "empresasremovidas"
        Me.empresasremovidas.Size = New System.Drawing.Size(135, 22)
        Me.empresasremovidas.Text = "Removidas"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndexToolStripMenuItem, Me.ToolStripSeparator8, Me.AboutToolStripMenuItem, Me.BackupDeDadosToolStripMenuItem, Me.RestauroDeDadosToolStripMenuItem})
        Me.HelpMenu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.HelpMenu.Image = Global.ClinicaInformatica.My.Resources.Resources.oie_transparent
        Me.HelpMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(104, 58)
        Me.HelpMenu.Text = "Ajuda"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Image = CType(resources.GetObject("IndexToolStripMenuItem.Image"), System.Drawing.Image)
        Me.IndexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.IndexToolStripMenuItem.Text = "Manual de Utilizador"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(185, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.AboutToolStripMenuItem.Text = "&Sobre ..."
        '
        'BackupDeDadosToolStripMenuItem
        '
        Me.BackupDeDadosToolStripMenuItem.Name = "BackupDeDadosToolStripMenuItem"
        Me.BackupDeDadosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.BackupDeDadosToolStripMenuItem.Text = "Backup de Dados"
        '
        'RestauroDeDadosToolStripMenuItem
        '
        Me.RestauroDeDadosToolStripMenuItem.Name = "RestauroDeDadosToolStripMenuItem"
        Me.RestauroDeDadosToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.RestauroDeDadosToolStripMenuItem.Text = "Restauro de Dados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1032, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Label1"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(1032, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(70, 25)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Label2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Statuscheck
        '
        Me.Statuscheck.Enabled = True
        Me.Statuscheck.Interval = 5
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Workspace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1102, 468)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.MinimumSize = New System.Drawing.Size(863, 506)
        Me.Name = "Workspace"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clínica Informática"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
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
    Friend WithEvents IndexToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents UtilizadoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents empresasativas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents empresasremovidas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents terminarsessao As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Statuscheck As System.Windows.Forms.Timer
    Friend WithEvents BackupDeDadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents RestauroDeDadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog

End Class
