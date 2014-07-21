<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adicionar_tecnicos
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
    Private WithEvents Adicionar As Telerik.WinControls.UI.RadButton
    Private WithEvents removerbutton As Telerik.WinControls.UI.RadButton
    Private WithEvents confirmbutton As Telerik.WinControls.UI.RadButton
    Private WithEvents cancellbutton As Telerik.WinControls.UI.RadButton
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents showdata As System.Windows.Forms.DataGridView
    Friend WithEvents addedata As System.Windows.Forms.DataGridView

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Adicionar = New Telerik.WinControls.UI.RadButton()
        Me.removerbutton = New Telerik.WinControls.UI.RadButton()
        Me.confirmbutton = New Telerik.WinControls.UI.RadButton()
        Me.cancellbutton = New Telerik.WinControls.UI.RadButton()
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.showdata = New System.Windows.Forms.DataGridView()
        Me.addedata = New System.Windows.Forms.DataGridView()
        CType(Me.Adicionar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.removerbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.confirmbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cancellbutton, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.addedata, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(269, 103)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Adicionar"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(269, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Remover"
        '
        'Adicionar
        '
        Me.Adicionar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Adicionar.Location = New System.Drawing.Point(272, 119)
        Me.Adicionar.Name = "Adicionar"
        '
        '
        '
        Me.Adicionar.RootElement.AccessibleDescription = Nothing
        Me.Adicionar.RootElement.AccessibleName = Nothing
        Me.Adicionar.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.Adicionar.Size = New System.Drawing.Size(72, 22)
        Me.Adicionar.TabIndex = 22
        Me.Adicionar.Text = ">>"
        Me.Adicionar.ThemeName = "Windows8"
        '
        'removerbutton
        '
        Me.removerbutton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.removerbutton.Location = New System.Drawing.Point(272, 217)
        Me.removerbutton.Name = "removerbutton"
        '
        '
        '
        Me.removerbutton.RootElement.AccessibleDescription = Nothing
        Me.removerbutton.RootElement.AccessibleName = Nothing
        Me.removerbutton.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.removerbutton.Size = New System.Drawing.Size(72, 22)
        Me.removerbutton.TabIndex = 22
        Me.removerbutton.Text = "<<"
        Me.removerbutton.ThemeName = "Windows8"
        '
        'confirmbutton
        '
        Me.confirmbutton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.confirmbutton.Location = New System.Drawing.Point(400, 400)
        Me.confirmbutton.Name = "confirmbutton"
        '
        '
        '
        Me.confirmbutton.RootElement.AccessibleDescription = Nothing
        Me.confirmbutton.RootElement.AccessibleName = Nothing
        Me.confirmbutton.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.confirmbutton.Size = New System.Drawing.Size(106, 34)
        Me.confirmbutton.TabIndex = 22
        Me.confirmbutton.Text = "Adicionar"
        Me.confirmbutton.ThemeName = "Windows8"
        '
        'cancellbutton
        '
        Me.cancellbutton.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.cancellbutton.Location = New System.Drawing.Point(512, 400)
        Me.cancellbutton.Name = "cancellbutton"
        '
        '
        '
        Me.cancellbutton.RootElement.AccessibleDescription = Nothing
        Me.cancellbutton.RootElement.AccessibleName = Nothing
        Me.cancellbutton.RootElement.ControlBounds = New System.Drawing.Rectangle(0, 0, 110, 24)
        Me.cancellbutton.Size = New System.Drawing.Size(89, 34)
        Me.cancellbutton.TabIndex = 22
        Me.cancellbutton.Text = "Cancelar"
        Me.cancellbutton.ThemeName = "Windows8"
        '
        'showdata
        '
        Me.showdata.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.showdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.showdata.Location = New System.Drawing.Point(12, 29)
        Me.showdata.Name = "showdata"
        Me.showdata.Size = New System.Drawing.Size(240, 341)
        Me.showdata.TabIndex = 23
        '
        'addedata
        '
        Me.addedata.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.addedata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.addedata.Location = New System.Drawing.Point(361, 29)
        Me.addedata.Name = "addedata"
        Me.addedata.Size = New System.Drawing.Size(240, 341)
        Me.addedata.TabIndex = 24
        '
        'Adicionar_tecnicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(613, 446)
        Me.Controls.Add(Me.addedata)
        Me.Controls.Add(Me.showdata)
        Me.Controls.Add(Me.cancellbutton)
        Me.Controls.Add(Me.confirmbutton)
        Me.Controls.Add(Me.removerbutton)
        Me.Controls.Add(Me.Adicionar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Adicionar_tecnicos"
        Me.Text = "Adicionar Técnicos"
        CType(Me.Adicionar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.removerbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.confirmbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cancellbutton, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.addedata, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class

Public Class Adicionar_tecnicos
    Public indexes(199) As String
    Public datatable As New DataTable
    Public cache As New DataTable
    Private Sub Adicionar_tecnicos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cache = BLL.Tecnicos.carregar_tecnico
        showdata.DataSource = cache
        addedata.DataSource = datatable
        datatable.Columns.Add("NºTécnico")
        datatable.Columns.Add("Nome")
        removerbutton.Enabled = False
    End Sub

    Private Sub Adicionar_Click(sender As Object, e As EventArgs) Handles Adicionar.Click
        Try
            datatable.ImportRow(cache.Rows(showdata.CurrentCell.RowIndex))
            cache.Rows.Remove(cache.Rows(showdata.CurrentCell.RowIndex))
            If cache.Rows.Count = 0 Then
                Adicionar.Enabled = False
            End If
            removerbutton.Enabled = True
        Catch
        End Try
    End Sub

    Private Sub remover_Click(sender As Object, e As EventArgs) Handles removerbutton.Click
        Try
            cache.ImportRow(datatable.Rows(addedata.CurrentCell.RowIndex))
            datatable.Rows.Remove(datatable.Rows(addedata.CurrentCell.RowIndex))
            If datatable.Rows.Count = 0 Then
                removerbutton.Enabled = False
            End If
            Adicionar.Enabled = True
        Catch
        End Try
    End Sub

    Private Sub confirm_Click(sender As Object, e As EventArgs) Handles confirmbutton.Click
        If datatable.Rows.Count <> 0 Then
            Workspace.tecnicos_support = datatable
            Me.Close()
        Else
            MsgBox("Introduza algum Técnico para guardar!")
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles cancellbutton.Click
        Me.Close()
    End Sub
End Class