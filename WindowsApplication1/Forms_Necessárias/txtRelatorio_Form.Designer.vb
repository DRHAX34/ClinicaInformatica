<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class txtRelatorio_Form
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ArtigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SQLToReportConnection = New ClinicaInformatica.SQLToReportConnection()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReparaçõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ParticipaçõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.HardwareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SoftwareBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.txtReport = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPreVisualizar = New System.Windows.Forms.Button()
        Me.btnRepor = New System.Windows.Forms.Button()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ArtigosTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.ArtigosTableAdapter()
        Me.ClientesTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.ClientesTableAdapter()
        Me.EmpresasTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.EmpresasTableAdapter()
        Me.ReparaçõesTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.ReparaçõesTableAdapter()
        Me.ParticipaçõesTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.ParticipaçõesTableAdapter()
        Me.HardwareTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.HardwareTableAdapter()
        Me.SoftwareTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.SoftwareTableAdapter()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SQLToReportConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReparaçõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ParticipaçõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HardwareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SoftwareBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ArtigosBindingSource
        '
        Me.ArtigosBindingSource.DataMember = "Artigos"
        Me.ArtigosBindingSource.DataSource = Me.SQLToReportConnection
        '
        'SQLToReportConnection
        '
        Me.SQLToReportConnection.DataSetName = "SQLToReportConnection"
        Me.SQLToReportConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.SQLToReportConnection
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.SQLToReportConnection
        '
        'ReparaçõesBindingSource
        '
        Me.ReparaçõesBindingSource.DataMember = "Reparações"
        Me.ReparaçõesBindingSource.DataSource = Me.SQLToReportConnection
        '
        'ParticipaçõesBindingSource
        '
        Me.ParticipaçõesBindingSource.DataMember = "Participações"
        Me.ParticipaçõesBindingSource.DataSource = Me.SQLToReportConnection
        '
        'HardwareBindingSource
        '
        Me.HardwareBindingSource.DataMember = "Hardware"
        Me.HardwareBindingSource.DataSource = Me.SQLToReportConnection
        '
        'SoftwareBindingSource
        '
        Me.SoftwareBindingSource.DataMember = "Software"
        Me.SoftwareBindingSource.DataSource = Me.SQLToReportConnection
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(695, 463)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(73, 52)
        Me.btnOK.TabIndex = 0
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnFechar.Location = New System.Drawing.Point(617, 463)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(73, 52)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'txtReport
        '
        Me.txtReport.Location = New System.Drawing.Point(12, 36)
        Me.txtReport.MaxLength = 1000
        Me.txtReport.Multiline = True
        Me.txtReport.Name = "txtReport"
        Me.txtReport.Size = New System.Drawing.Size(756, 103)
        Me.txtReport.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(766, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Insira o texto que deseja mostrar na folha de entrega ao cliente: (Deixe em branc" & _
    "o para repor o texto predefinido)"
        '
        'btnPreVisualizar
        '
        Me.btnPreVisualizar.Location = New System.Drawing.Point(643, 145)
        Me.btnPreVisualizar.Name = "btnPreVisualizar"
        Me.btnPreVisualizar.Size = New System.Drawing.Size(125, 37)
        Me.btnPreVisualizar.TabIndex = 4
        Me.btnPreVisualizar.Text = "Pré-Visualizar"
        Me.btnPreVisualizar.UseVisualStyleBackColor = True
        '
        'btnRepor
        '
        Me.btnRepor.Location = New System.Drawing.Point(512, 145)
        Me.btnRepor.Name = "btnRepor"
        Me.btnRepor.Size = New System.Drawing.Size(125, 37)
        Me.btnRepor.TabIndex = 5
        Me.btnRepor.Text = "Repor Texto"
        Me.btnRepor.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "Artigos"
        ReportDataSource1.Value = Me.ArtigosBindingSource
        ReportDataSource2.Name = "Clientes"
        ReportDataSource2.Value = Me.ClientesBindingSource
        ReportDataSource3.Name = "Empresas"
        ReportDataSource3.Value = Me.EmpresasBindingSource
        ReportDataSource4.Name = "Reparações"
        ReportDataSource4.Value = Me.ReparaçõesBindingSource
        ReportDataSource5.Name = "Participações"
        ReportDataSource5.Value = Me.ParticipaçõesBindingSource
        ReportDataSource6.Name = "Hardware"
        ReportDataSource6.Value = Me.HardwareBindingSource
        ReportDataSource7.Name = "Software"
        ReportDataSource7.Value = Me.SoftwareBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ClinicaInformatica.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 186)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(756, 271)
        Me.ReportViewer1.TabIndex = 6
        '
        'ArtigosTableAdapter
        '
        Me.ArtigosTableAdapter.ClearBeforeFill = True
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'ReparaçõesTableAdapter
        '
        Me.ReparaçõesTableAdapter.ClearBeforeFill = True
        '
        'ParticipaçõesTableAdapter
        '
        Me.ParticipaçõesTableAdapter.ClearBeforeFill = True
        '
        'HardwareTableAdapter
        '
        Me.HardwareTableAdapter.ClearBeforeFill = True
        '
        'SoftwareTableAdapter
        '
        Me.SoftwareTableAdapter.ClearBeforeFill = True
        '
        'txtRelatorio_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnFechar
        Me.ClientSize = New System.Drawing.Size(780, 527)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.btnRepor)
        Me.Controls.Add(Me.btnPreVisualizar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtReport)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "txtRelatorio_Form"
        Me.Text = "Texto Folha do Cliente"
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SQLToReportConnection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReparaçõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ParticipaçõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HardwareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SoftwareBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtReport As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnPreVisualizar As System.Windows.Forms.Button
    Friend WithEvents btnRepor As System.Windows.Forms.Button
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ArtigosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SQLToReportConnection As ClinicaInformatica.SQLToReportConnection
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReparaçõesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ParticipaçõesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents HardwareBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SoftwareBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArtigosTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.ArtigosTableAdapter
    Friend WithEvents ClientesTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.ClientesTableAdapter
    Friend WithEvents EmpresasTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.EmpresasTableAdapter
    Friend WithEvents ReparaçõesTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.ReparaçõesTableAdapter
    Friend WithEvents ParticipaçõesTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.ParticipaçõesTableAdapter
    Friend WithEvents HardwareTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.HardwareTableAdapter
    Friend WithEvents SoftwareTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.SoftwareTableAdapter
End Class
