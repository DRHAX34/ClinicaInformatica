<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class folha_repar
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me._BD_C_IDataSet = New ClinicaInformatica._BD_C_IDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ClinicaInformatica._BD_C_IDataSetTableAdapters.ClientesTableAdapter()
        Me.ComponentesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComponentesTableAdapter = New ClinicaInformatica._BD_C_IDataSetTableAdapters.ComponentesTableAdapter()
        Me.ReparaçõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReparaçõesTableAdapter = New ClinicaInformatica._BD_C_IDataSetTableAdapters.ReparaçõesTableAdapter()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New ClinicaInformatica._BD_C_IDataSetTableAdapters.EmpresasTableAdapter()
        CType(Me._BD_C_IDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComponentesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReparaçõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Clientes"
        ReportDataSource1.Value = Me.ClientesBindingSource
        ReportDataSource2.Name = "Componentes"
        ReportDataSource2.Value = Me.ComponentesBindingSource
        ReportDataSource3.Name = "Reparações"
        ReportDataSource3.Value = Me.ReparaçõesBindingSource
        ReportDataSource4.Name = "Empresas"
        ReportDataSource4.Value = Me.EmpresasBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ClinicaInformatica.Report5.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(658, 446)
        Me.ReportViewer1.TabIndex = 0
        '
        '_BD_C_IDataSet
        '
        Me._BD_C_IDataSet.DataSetName = "_BD_C_IDataSet"
        Me._BD_C_IDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me._BD_C_IDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ComponentesBindingSource
        '
        Me.ComponentesBindingSource.DataMember = "Componentes"
        Me.ComponentesBindingSource.DataSource = Me._BD_C_IDataSet
        '
        'ComponentesTableAdapter
        '
        Me.ComponentesTableAdapter.ClearBeforeFill = True
        '
        'ReparaçõesBindingSource
        '
        Me.ReparaçõesBindingSource.DataMember = "Reparações"
        Me.ReparaçõesBindingSource.DataSource = Me._BD_C_IDataSet
        '
        'ReparaçõesTableAdapter
        '
        Me.ReparaçõesTableAdapter.ClearBeforeFill = True
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me._BD_C_IDataSet
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'folha_repar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 446)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "folha_repar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form4"
        CType(Me._BD_C_IDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComponentesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReparaçõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents _BD_C_IDataSet As ClinicaInformatica._BD_C_IDataSet
    Friend WithEvents ComponentesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReparaçõesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ClinicaInformatica._BD_C_IDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ComponentesTableAdapter As ClinicaInformatica._BD_C_IDataSetTableAdapters.ComponentesTableAdapter
    Friend WithEvents ReparaçõesTableAdapter As ClinicaInformatica._BD_C_IDataSetTableAdapters.ReparaçõesTableAdapter
    Friend WithEvents EmpresasTableAdapter As ClinicaInformatica._BD_C_IDataSetTableAdapters.EmpresasTableAdapter
End Class
