﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(folha_repar))
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SQLToReportConnection = New ClinicaInformatica.SQLToReportConnection()
        Me.ArtigosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArtigosTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.ArtigosTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.ClientesTableAdapter()
        Me.EmpresasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresasTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.EmpresasTableAdapter()
        Me.ReparaçõesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReparaçõesTableAdapter = New ClinicaInformatica.SQLToReportConnectionTableAdapters.ReparaçõesTableAdapter()
        CType(Me.SQLToReportConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReparaçõesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "Artigos"
        ReportDataSource1.Value = Me.ArtigosBindingSource
        ReportDataSource2.Name = "Clientes"
        ReportDataSource2.Value = Me.ClientesBindingSource
        ReportDataSource3.Name = "Empresas"
        ReportDataSource3.Value = Me.EmpresasBindingSource
        ReportDataSource4.Name = "Reparações"
        ReportDataSource4.Value = Me.ReparaçõesBindingSource
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
        'SQLToReportConnection
        '
        Me.SQLToReportConnection.DataSetName = "SQLToReportConnection"
        Me.SQLToReportConnection.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ArtigosBindingSource
        '
        Me.ArtigosBindingSource.DataMember = "Artigos"
        Me.ArtigosBindingSource.DataSource = Me.SQLToReportConnection
        '
        'ArtigosTableAdapter
        '
        Me.ArtigosTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.SQLToReportConnection
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'EmpresasBindingSource
        '
        Me.EmpresasBindingSource.DataMember = "Empresas"
        Me.EmpresasBindingSource.DataSource = Me.SQLToReportConnection
        '
        'EmpresasTableAdapter
        '
        Me.EmpresasTableAdapter.ClearBeforeFill = True
        '
        'ReparaçõesBindingSource
        '
        Me.ReparaçõesBindingSource.DataMember = "Reparações"
        Me.ReparaçõesBindingSource.DataSource = Me.SQLToReportConnection
        '
        'ReparaçõesTableAdapter
        '
        Me.ReparaçõesTableAdapter.ClearBeforeFill = True
        '
        'folha_repar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 446)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "folha_repar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Folha de Reparação - Entrega ao Cliente"
        CType(Me.SQLToReportConnection, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtigosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReparaçõesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ArtigosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SQLToReportConnection As ClinicaInformatica.SQLToReportConnection
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReparaçõesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ArtigosTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.ArtigosTableAdapter
    Friend WithEvents ClientesTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.ClientesTableAdapter
    Friend WithEvents EmpresasTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.EmpresasTableAdapter
    Friend WithEvents ReparaçõesTableAdapter As ClinicaInformatica.SQLToReportConnectionTableAdapters.ReparaçõesTableAdapter
End Class
