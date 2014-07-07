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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.datalabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.obsbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.de = New ClinicaInformatica.WaterMarkTextBox()
        Me.modelobox = New ClinicaInformatica.WaterMarkTextBox()
        Me.marcabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.tipobox = New ClinicaInformatica.WaterMarkTextBox()
        Me.localidadebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.cmovelbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.codpostalbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.moradabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.nomebox = New ClinicaInformatica.WaterMarkTextBox()
        Me.descavariabox = New ClinicaInformatica.WaterMarkTextBox()
        Me.numcompbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.reparbox = New ClinicaInformatica.WaterMarkTextBox()
        Me.empresalabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.empresalogobox = New System.Windows.Forms.PictureBox()
        Me.ClientesTableAdapter1 = New ClinicaInformatica._BD_C_IDataSetTableAdapters.ClientesTableAdapter()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.empresalogobox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.datalabel)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.obsbox)
        Me.Panel2.Controls.Add(Me.de)
        Me.Panel2.Controls.Add(Me.modelobox)
        Me.Panel2.Controls.Add(Me.marcabox)
        Me.Panel2.Controls.Add(Me.tipobox)
        Me.Panel2.Controls.Add(Me.localidadebox)
        Me.Panel2.Controls.Add(Me.cmovelbox)
        Me.Panel2.Controls.Add(Me.codpostalbox)
        Me.Panel2.Controls.Add(Me.moradabox)
        Me.Panel2.Controls.Add(Me.nomebox)
        Me.Panel2.Controls.Add(Me.descavariabox)
        Me.Panel2.Controls.Add(Me.numcompbox)
        Me.Panel2.Controls.Add(Me.reparbox)
        Me.Panel2.Location = New System.Drawing.Point(36, 201)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(601, 509)
        Me.Panel2.TabIndex = 15
        '
        'datalabel
        '
        Me.datalabel.AutoSize = True
        Me.datalabel.Location = New System.Drawing.Point(419, 417)
        Me.datalabel.Name = "datalabel"
        Me.datalabel.Size = New System.Drawing.Size(42, 13)
        Me.datalabel.TabIndex = 20
        Me.datalabel.Text = "<Date>"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(419, 477)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "____________________________"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(419, 446)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Assinatura"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(419, 394)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Data"
        '
        'obsbox
        '
        Me.obsbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.obsbox.Location = New System.Drawing.Point(46, 278)
        Me.obsbox.Multiline = True
        Me.obsbox.Name = "obsbox"
        Me.obsbox.ReadOnly = True
        Me.obsbox.Size = New System.Drawing.Size(215, 113)
        Me.obsbox.TabIndex = 16
        Me.obsbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.obsbox.WaterMarkText = "Observações"
        '
        'de
        '
        Me.de.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.de.Location = New System.Drawing.Point(354, 207)
        Me.de.Name = "de"
        Me.de.ReadOnly = True
        Me.de.Size = New System.Drawing.Size(137, 27)
        Me.de.TabIndex = 15
        Me.de.WaterMarkColor = System.Drawing.Color.Gray
        Me.de.WaterMarkText = "NºSérie"
        '
        'modelobox
        '
        Me.modelobox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.modelobox.Location = New System.Drawing.Point(354, 169)
        Me.modelobox.Name = "modelobox"
        Me.modelobox.ReadOnly = True
        Me.modelobox.Size = New System.Drawing.Size(125, 27)
        Me.modelobox.TabIndex = 14
        Me.modelobox.WaterMarkColor = System.Drawing.Color.Gray
        Me.modelobox.WaterMarkText = "Modelo"
        '
        'marcabox
        '
        Me.marcabox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.marcabox.Location = New System.Drawing.Point(354, 133)
        Me.marcabox.Name = "marcabox"
        Me.marcabox.ReadOnly = True
        Me.marcabox.Size = New System.Drawing.Size(125, 27)
        Me.marcabox.TabIndex = 13
        Me.marcabox.WaterMarkColor = System.Drawing.Color.Gray
        Me.marcabox.WaterMarkText = "Marca"
        '
        'tipobox
        '
        Me.tipobox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.tipobox.Location = New System.Drawing.Point(354, 94)
        Me.tipobox.Name = "tipobox"
        Me.tipobox.ReadOnly = True
        Me.tipobox.Size = New System.Drawing.Size(104, 27)
        Me.tipobox.TabIndex = 12
        Me.tipobox.WaterMarkColor = System.Drawing.Color.Gray
        Me.tipobox.WaterMarkText = "Tipo_Dispositivo"
        '
        'localidadebox
        '
        Me.localidadebox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.localidadebox.Location = New System.Drawing.Point(46, 207)
        Me.localidadebox.Name = "localidadebox"
        Me.localidadebox.ReadOnly = True
        Me.localidadebox.Size = New System.Drawing.Size(94, 27)
        Me.localidadebox.TabIndex = 11
        Me.localidadebox.WaterMarkColor = System.Drawing.Color.Gray
        Me.localidadebox.WaterMarkText = "Localidade"
        '
        'cmovelbox
        '
        Me.cmovelbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.cmovelbox.Location = New System.Drawing.Point(46, 245)
        Me.cmovelbox.Name = "cmovelbox"
        Me.cmovelbox.ReadOnly = True
        Me.cmovelbox.Size = New System.Drawing.Size(128, 27)
        Me.cmovelbox.TabIndex = 10
        Me.cmovelbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.cmovelbox.WaterMarkText = "Contacto_Movel"
        '
        'codpostalbox
        '
        Me.codpostalbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.codpostalbox.Location = New System.Drawing.Point(46, 169)
        Me.codpostalbox.Name = "codpostalbox"
        Me.codpostalbox.ReadOnly = True
        Me.codpostalbox.Size = New System.Drawing.Size(94, 27)
        Me.codpostalbox.TabIndex = 9
        Me.codpostalbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.codpostalbox.WaterMarkText = "Cod_Postal"
        '
        'moradabox
        '
        Me.moradabox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.moradabox.Location = New System.Drawing.Point(46, 133)
        Me.moradabox.Name = "moradabox"
        Me.moradabox.ReadOnly = True
        Me.moradabox.Size = New System.Drawing.Size(178, 27)
        Me.moradabox.TabIndex = 8
        Me.moradabox.WaterMarkColor = System.Drawing.Color.Gray
        Me.moradabox.WaterMarkText = "Morada"
        '
        'nomebox
        '
        Me.nomebox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.nomebox.Location = New System.Drawing.Point(46, 94)
        Me.nomebox.Name = "nomebox"
        Me.nomebox.ReadOnly = True
        Me.nomebox.Size = New System.Drawing.Size(128, 27)
        Me.nomebox.TabIndex = 7
        Me.nomebox.WaterMarkColor = System.Drawing.Color.Gray
        Me.nomebox.WaterMarkText = "Nome"
        '
        'descavariabox
        '
        Me.descavariabox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.descavariabox.Location = New System.Drawing.Point(354, 245)
        Me.descavariabox.Multiline = True
        Me.descavariabox.Name = "descavariabox"
        Me.descavariabox.ReadOnly = True
        Me.descavariabox.Size = New System.Drawing.Size(215, 146)
        Me.descavariabox.TabIndex = 4
        Me.descavariabox.WaterMarkColor = System.Drawing.Color.Gray
        Me.descavariabox.WaterMarkText = "DescAvaria"
        '
        'numcompbox
        '
        Me.numcompbox.Font = New System.Drawing.Font("Segoe UI", 11.25!)
        Me.numcompbox.Location = New System.Drawing.Point(354, 53)
        Me.numcompbox.Name = "numcompbox"
        Me.numcompbox.ReadOnly = True
        Me.numcompbox.Size = New System.Drawing.Size(51, 27)
        Me.numcompbox.TabIndex = 2
        Me.numcompbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.numcompbox.WaterMarkText = "NºComponente"
        '
        'reparbox
        '
        Me.reparbox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reparbox.Location = New System.Drawing.Point(46, 53)
        Me.reparbox.Name = "reparbox"
        Me.reparbox.ReadOnly = True
        Me.reparbox.Size = New System.Drawing.Size(37, 27)
        Me.reparbox.TabIndex = 1
        Me.reparbox.WaterMarkColor = System.Drawing.Color.Gray
        Me.reparbox.WaterMarkText = "NºReparação"
        '
        'empresalabel
        '
        Me.empresalabel.AutoSize = True
        Me.empresalabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.empresalabel.Location = New System.Drawing.Point(279, 113)
        Me.empresalabel.Name = "empresalabel"
        Me.empresalabel.Size = New System.Drawing.Size(198, 28)
        Me.empresalabel.TabIndex = 14
        Me.empresalabel.Text = "(Nome da Empresa)"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(-2, 735)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(660, 33)
        Me.Panel1.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(302, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(600, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label3"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(258, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Folha de Reparação"
        '
        'empresalogobox
        '
        Me.empresalogobox.Location = New System.Drawing.Point(17, 13)
        Me.empresalogobox.Name = "empresalogobox"
        Me.empresalogobox.Size = New System.Drawing.Size(148, 154)
        Me.empresalogobox.TabIndex = 11
        Me.empresalogobox.TabStop = False
        '
        'ClientesTableAdapter1
        '
        Me.ClientesTableAdapter1.ClearBeforeFill = True
        '
        'folha_repar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 780)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.empresalabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.empresalogobox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "folha_repar"
        Me.Text = "Form4"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.empresalogobox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents empresalabel As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents empresalogobox As System.Windows.Forms.PictureBox
    Friend WithEvents reparbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents nomebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents descavariabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents numcompbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents obsbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents de As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents modelobox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents marcabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents tipobox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents localidadebox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents cmovelbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents codpostalbox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents moradabox As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ClientesTableAdapter1 As ClinicaInformatica._BD_C_IDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents datalabel As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
