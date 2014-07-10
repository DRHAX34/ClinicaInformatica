<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class folha_repar_orçamento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(folha_repar_orçamento))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.showdata = New Telerik.WinControls.UI.RadGridView()
        Me.WaterMarkTextBox13 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox12 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox11 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox10 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox9 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox8 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox6 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox5 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox3 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox7 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox4 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox2 = New ClinicaInformatica.WaterMarkTextBox()
        Me.WaterMarkTextBox1 = New ClinicaInformatica.WaterMarkTextBox()
        Me.empresalabel = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.empresalogobox = New System.Windows.Forms.PictureBox()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.Panel2.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.showdata.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.empresalogobox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.RadGridView1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.showdata)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox13)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox12)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox11)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox10)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox9)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox8)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox6)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox5)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox3)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox7)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox4)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox2)
        Me.Panel2.Controls.Add(Me.WaterMarkTextBox1)
        Me.Panel2.Location = New System.Drawing.Point(15, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(622, 512)
        Me.Panel2.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(338, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 13)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Software"
        '
        'RadGridView1
        '
        Me.RadGridView1.AutoSizeRows = True
        Me.RadGridView1.Location = New System.Drawing.Point(340, 249)
        '
        'RadGridView1
        '
        Me.RadGridView1.MasterTemplate.AllowAddNewRow = False
        Me.RadGridView1.MasterTemplate.AllowColumnResize = False
        Me.RadGridView1.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.Padding = New System.Windows.Forms.Padding(1)
        Me.RadGridView1.ReadOnly = True
        Me.RadGridView1.Size = New System.Drawing.Size(268, 258)
        Me.RadGridView1.TabIndex = 32
        Me.RadGridView1.Text = "Data"
        Me.RadGridView1.ThemeName = "Windows8"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(39, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Hardware"
        '
        'showdata
        '
        Me.showdata.AutoSizeRows = True
        Me.showdata.Location = New System.Drawing.Point(42, 209)
        '
        'showdata
        '
        Me.showdata.MasterTemplate.AllowAddNewRow = False
        Me.showdata.MasterTemplate.AllowColumnResize = False
        Me.showdata.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill
        Me.showdata.Name = "showdata"
        Me.showdata.Padding = New System.Windows.Forms.Padding(1)
        Me.showdata.ReadOnly = True
        Me.showdata.Size = New System.Drawing.Size(268, 298)
        Me.showdata.TabIndex = 30
        Me.showdata.Text = "Data"
        Me.showdata.ThemeName = "Windows8"
        '
        'WaterMarkTextBox13
        '
        Me.WaterMarkTextBox13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox13.Location = New System.Drawing.Point(393, 167)
        Me.WaterMarkTextBox13.Multiline = True
        Me.WaterMarkTextBox13.Name = "WaterMarkTextBox13"
        Me.WaterMarkTextBox13.Size = New System.Drawing.Size(215, 66)
        Me.WaterMarkTextBox13.TabIndex = 29
        Me.WaterMarkTextBox13.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox13.WaterMarkText = "Observações"
        '
        'WaterMarkTextBox12
        '
        Me.WaterMarkTextBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox12.Location = New System.Drawing.Point(393, 115)
        Me.WaterMarkTextBox12.Name = "WaterMarkTextBox12"
        Me.WaterMarkTextBox12.Size = New System.Drawing.Size(137, 20)
        Me.WaterMarkTextBox12.TabIndex = 28
        Me.WaterMarkTextBox12.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox12.WaterMarkText = "NºSérie"
        '
        'WaterMarkTextBox11
        '
        Me.WaterMarkTextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox11.Location = New System.Drawing.Point(393, 89)
        Me.WaterMarkTextBox11.Name = "WaterMarkTextBox11"
        Me.WaterMarkTextBox11.Size = New System.Drawing.Size(125, 20)
        Me.WaterMarkTextBox11.TabIndex = 27
        Me.WaterMarkTextBox11.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox11.WaterMarkText = "Modelo"
        '
        'WaterMarkTextBox10
        '
        Me.WaterMarkTextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox10.Location = New System.Drawing.Point(393, 63)
        Me.WaterMarkTextBox10.Name = "WaterMarkTextBox10"
        Me.WaterMarkTextBox10.Size = New System.Drawing.Size(125, 20)
        Me.WaterMarkTextBox10.TabIndex = 26
        Me.WaterMarkTextBox10.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox10.WaterMarkText = "Marca"
        '
        'WaterMarkTextBox9
        '
        Me.WaterMarkTextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox9.Location = New System.Drawing.Point(393, 37)
        Me.WaterMarkTextBox9.Name = "WaterMarkTextBox9"
        Me.WaterMarkTextBox9.Size = New System.Drawing.Size(104, 20)
        Me.WaterMarkTextBox9.TabIndex = 25
        Me.WaterMarkTextBox9.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox9.WaterMarkText = "Tipo_Dispositivo"
        '
        'WaterMarkTextBox8
        '
        Me.WaterMarkTextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox8.Location = New System.Drawing.Point(42, 115)
        Me.WaterMarkTextBox8.Name = "WaterMarkTextBox8"
        Me.WaterMarkTextBox8.Size = New System.Drawing.Size(94, 20)
        Me.WaterMarkTextBox8.TabIndex = 24
        Me.WaterMarkTextBox8.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox8.WaterMarkText = "Localidade"
        '
        'WaterMarkTextBox6
        '
        Me.WaterMarkTextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox6.Location = New System.Drawing.Point(42, 141)
        Me.WaterMarkTextBox6.Name = "WaterMarkTextBox6"
        Me.WaterMarkTextBox6.Size = New System.Drawing.Size(128, 20)
        Me.WaterMarkTextBox6.TabIndex = 23
        Me.WaterMarkTextBox6.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox6.WaterMarkText = "Contacto_Movel"
        '
        'WaterMarkTextBox5
        '
        Me.WaterMarkTextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox5.Location = New System.Drawing.Point(42, 89)
        Me.WaterMarkTextBox5.Name = "WaterMarkTextBox5"
        Me.WaterMarkTextBox5.Size = New System.Drawing.Size(94, 20)
        Me.WaterMarkTextBox5.TabIndex = 22
        Me.WaterMarkTextBox5.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox5.WaterMarkText = "Cod_Postal"
        '
        'WaterMarkTextBox3
        '
        Me.WaterMarkTextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox3.Location = New System.Drawing.Point(42, 63)
        Me.WaterMarkTextBox3.Name = "WaterMarkTextBox3"
        Me.WaterMarkTextBox3.Size = New System.Drawing.Size(178, 20)
        Me.WaterMarkTextBox3.TabIndex = 21
        Me.WaterMarkTextBox3.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox3.WaterMarkText = "Morada"
        '
        'WaterMarkTextBox7
        '
        Me.WaterMarkTextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox7.Location = New System.Drawing.Point(42, 34)
        Me.WaterMarkTextBox7.Name = "WaterMarkTextBox7"
        Me.WaterMarkTextBox7.Size = New System.Drawing.Size(128, 20)
        Me.WaterMarkTextBox7.TabIndex = 20
        Me.WaterMarkTextBox7.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox7.WaterMarkText = "Nome"
        '
        'WaterMarkTextBox4
        '
        Me.WaterMarkTextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox4.Location = New System.Drawing.Point(393, 141)
        Me.WaterMarkTextBox4.Name = "WaterMarkTextBox4"
        Me.WaterMarkTextBox4.Size = New System.Drawing.Size(193, 20)
        Me.WaterMarkTextBox4.TabIndex = 19
        Me.WaterMarkTextBox4.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox4.WaterMarkText = "DescAvaria"
        '
        'WaterMarkTextBox2
        '
        Me.WaterMarkTextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox2.Location = New System.Drawing.Point(393, 11)
        Me.WaterMarkTextBox2.Name = "WaterMarkTextBox2"
        Me.WaterMarkTextBox2.Size = New System.Drawing.Size(51, 20)
        Me.WaterMarkTextBox2.TabIndex = 18
        Me.WaterMarkTextBox2.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox2.WaterMarkText = "NºComponente"
        '
        'WaterMarkTextBox1
        '
        Me.WaterMarkTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.WaterMarkTextBox1.Location = New System.Drawing.Point(42, 8)
        Me.WaterMarkTextBox1.Name = "WaterMarkTextBox1"
        Me.WaterMarkTextBox1.Size = New System.Drawing.Size(37, 20)
        Me.WaterMarkTextBox1.TabIndex = 17
        Me.WaterMarkTextBox1.WaterMarkColor = System.Drawing.Color.Gray
        Me.WaterMarkTextBox1.WaterMarkText = "NºReparação"
        '
        'empresalabel
        '
        Me.empresalabel.AutoSize = True
        Me.empresalabel.Font = New System.Drawing.Font("Segoe UI", 15.0!, System.Drawing.FontStyle.Bold)
        Me.empresalabel.Location = New System.Drawing.Point(279, 113)
        Me.empresalabel.Name = "empresalabel"
        Me.empresalabel.Size = New System.Drawing.Size(198, 28)
        Me.empresalabel.TabIndex = 9
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
        Me.Panel1.TabIndex = 8
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
        Me.Label1.Location = New System.Drawing.Point(210, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Folha de Reparação Efetuada"
        '
        'empresalogobox
        '
        Me.empresalogobox.Location = New System.Drawing.Point(15, 12)
        Me.empresalogobox.Name = "empresalogobox"
        Me.empresalogobox.Size = New System.Drawing.Size(148, 154)
        Me.empresalogobox.TabIndex = 6
        Me.empresalogobox.TabStop = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'folha_repar_orçamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 768)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.empresalabel)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.empresalogobox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "folha_repar_orçamento"
        Me.Text = "Form5"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showdata.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.showdata, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents WaterMarkTextBox13 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox12 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox11 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox10 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox9 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox8 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox6 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox5 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox3 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox7 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox4 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox2 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents WaterMarkTextBox1 As ClinicaInformatica.WaterMarkTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents showdata As Telerik.WinControls.UI.RadGridView
    Friend WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
End Class
