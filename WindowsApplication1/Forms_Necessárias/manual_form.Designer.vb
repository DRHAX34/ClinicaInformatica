<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class manual_form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(manual_form))
        Me.Windows8Theme1 = New Telerik.WinControls.Themes.Windows8Theme()
        Me.RadPdfViewer1 = New Telerik.WinControls.UI.RadPdfViewer()
        Me.RadPdfViewerNavigator1 = New Telerik.WinControls.UI.RadPdfViewerNavigator()
        CType(Me.RadPdfViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadPdfViewer1
        '
        Me.RadPdfViewer1.Location = New System.Drawing.Point(0, 40)
        Me.RadPdfViewer1.Name = "RadPdfViewer1"
        Me.RadPdfViewer1.Size = New System.Drawing.Size(565, 295)
        Me.RadPdfViewer1.TabIndex = 1
        Me.RadPdfViewer1.Text = "RadPdfViewer1"
        Me.RadPdfViewer1.ThumbnailsScaleFactor = 0.15!
        '
        'RadPdfViewerNavigator1
        '
        Me.RadPdfViewerNavigator1.AssociatedViewer = Me.RadPdfViewer1
        Me.RadPdfViewerNavigator1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RadPdfViewerNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.RadPdfViewerNavigator1.Name = "RadPdfViewerNavigator1"
        Me.RadPdfViewerNavigator1.Size = New System.Drawing.Size(860, 34)
        Me.RadPdfViewerNavigator1.TabIndex = 1
        Me.RadPdfViewerNavigator1.Text = "RadPdfViewerNavigator1"
        Me.RadPdfViewerNavigator1.ThemeName = "Windows8"
        '
        'manual_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 413)
        Me.Controls.Add(Me.RadPdfViewerNavigator1)
        Me.Controls.Add(Me.RadPdfViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "manual_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Manual de Instruções"
        CType(Me.RadPdfViewer1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadPdfViewerNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Windows8Theme1 As Telerik.WinControls.Themes.Windows8Theme
    Friend WithEvents RadPdfViewer1 As Telerik.WinControls.UI.RadPdfViewer
    Friend WithEvents RadPdfViewerNavigator1 As Telerik.WinControls.UI.RadPdfViewerNavigator
End Class
