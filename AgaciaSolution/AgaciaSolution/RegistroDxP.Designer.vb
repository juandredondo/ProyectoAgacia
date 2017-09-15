<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroDxP
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim NomProvLabel As System.Windows.Forms.Label
        Dim TelefProvLabel As System.Windows.Forms.Label
        Dim CiudadProvLabel As System.Windows.Forms.Label
        Dim FechaEmiFactuDXPLabel As System.Windows.Forms.Label
        Dim IdPedDXPLabel As System.Windows.Forms.Label
        Dim MontoDxPLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroDxP))
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DirprovedorTB = New System.Windows.Forms.TextBox
        Me.NomProvTextBox = New System.Windows.Forms.TextBox
        Me.TelefProvTextBox = New System.Windows.Forms.TextBox
        Me.CiudadProvTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.NumfactCompraTB = New System.Windows.Forms.TextBox
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.IdPedDXPTextBox = New System.Windows.Forms.TextBox
        Me.MontoDxPTextBox = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.IdDxPLabel1 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.AgaciaBDDataSet1 = New AgaciaSolution.AgaciaBDDataSet1
        Me.MaxDXPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaxDXPTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.MaxDXPTableAdapter
        Me.SalirBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        NomProvLabel = New System.Windows.Forms.Label
        TelefProvLabel = New System.Windows.Forms.Label
        CiudadProvLabel = New System.Windows.Forms.Label
        FechaEmiFactuDXPLabel = New System.Windows.Forms.Label
        IdPedDXPLabel = New System.Windows.Forms.Label
        MontoDxPLabel = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxDXPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomProvLabel
        '
        NomProvLabel.AutoSize = True
        NomProvLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomProvLabel.Location = New System.Drawing.Point(13, 36)
        NomProvLabel.Name = "NomProvLabel"
        NomProvLabel.Size = New System.Drawing.Size(61, 15)
        NomProvLabel.TabIndex = 2
        NomProvLabel.Text = "Nombre :"
        '
        'TelefProvLabel
        '
        TelefProvLabel.AutoSize = True
        TelefProvLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefProvLabel.Location = New System.Drawing.Point(11, 64)
        TelefProvLabel.Name = "TelefProvLabel"
        TelefProvLabel.Size = New System.Drawing.Size(47, 15)
        TelefProvLabel.TabIndex = 6
        TelefProvLabel.Text = "Tel (s):"
        '
        'CiudadProvLabel
        '
        CiudadProvLabel.AutoSize = True
        CiudadProvLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadProvLabel.Location = New System.Drawing.Point(255, 65)
        CiudadProvLabel.Name = "CiudadProvLabel"
        CiudadProvLabel.Size = New System.Drawing.Size(55, 15)
        CiudadProvLabel.TabIndex = 8
        CiudadProvLabel.Text = "Ciudad :"
        '
        'FechaEmiFactuDXPLabel
        '
        FechaEmiFactuDXPLabel.AutoSize = True
        FechaEmiFactuDXPLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaEmiFactuDXPLabel.Location = New System.Drawing.Point(13, 103)
        FechaEmiFactuDXPLabel.Name = "FechaEmiFactuDXPLabel"
        FechaEmiFactuDXPLabel.Size = New System.Drawing.Size(102, 15)
        FechaEmiFactuDXPLabel.TabIndex = 2
        FechaEmiFactuDXPLabel.Text = "N° de la factura:"
        '
        'IdPedDXPLabel
        '
        IdPedDXPLabel.AutoSize = True
        IdPedDXPLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdPedDXPLabel.Location = New System.Drawing.Point(13, 30)
        IdPedDXPLabel.Name = "IdPedDXPLabel"
        IdPedDXPLabel.Size = New System.Drawing.Size(67, 15)
        IdPedDXPLabel.TabIndex = 6
        IdPedDXPLabel.Text = "Pedido Nº:"
        '
        'MontoDxPLabel
        '
        MontoDxPLabel.AutoSize = True
        MontoDxPLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MontoDxPLabel.Location = New System.Drawing.Point(268, 103)
        MontoDxPLabel.Name = "MontoDxPLabel"
        MontoDxPLabel.Size = New System.Drawing.Size(50, 15)
        MontoDxPLabel.TabIndex = 8
        MontoDxPLabel.Text = "Monto :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.Location = New System.Drawing.Point(13, 64)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(173, 15)
        Label2.TabIndex = 60
        Label2.Text = "Fecha de Emisión de factura:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.Location = New System.Drawing.Point(13, 97)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(69, 15)
        Label3.TabIndex = 11
        Label3.Text = "Dirección :"
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GuardarBtn.FlatAppearance.BorderSize = 2
        Me.GuardarBtn.Image = CType(resources.GetObject("GuardarBtn.Image"), System.Drawing.Image)
        Me.GuardarBtn.Location = New System.Drawing.Point(325, 385)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(45, 44)
        Me.GuardarBtn.TabIndex = 58
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 57
        Me.PictureBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Label3)
        Me.GroupBox3.Controls.Add(Me.DirprovedorTB)
        Me.GroupBox3.Controls.Add(NomProvLabel)
        Me.GroupBox3.Controls.Add(Me.NomProvTextBox)
        Me.GroupBox3.Controls.Add(TelefProvLabel)
        Me.GroupBox3.Controls.Add(Me.TelefProvTextBox)
        Me.GroupBox3.Controls.Add(CiudadProvLabel)
        Me.GroupBox3.Controls.Add(Me.CiudadProvTextBox)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox3.Location = New System.Drawing.Point(4, 236)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(460, 133)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del Proveedor"
        '
        'DirprovedorTB
        '
        Me.DirprovedorTB.Enabled = False
        Me.DirprovedorTB.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirprovedorTB.Location = New System.Drawing.Point(88, 90)
        Me.DirprovedorTB.Name = "DirprovedorTB"
        Me.DirprovedorTB.Size = New System.Drawing.Size(361, 22)
        Me.DirprovedorTB.TabIndex = 10
        '
        'NomProvTextBox
        '
        Me.NomProvTextBox.Enabled = False
        Me.NomProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomProvTextBox.Location = New System.Drawing.Point(88, 33)
        Me.NomProvTextBox.Name = "NomProvTextBox"
        Me.NomProvTextBox.Size = New System.Drawing.Size(361, 22)
        Me.NomProvTextBox.TabIndex = 3
        '
        'TelefProvTextBox
        '
        Me.TelefProvTextBox.Enabled = False
        Me.TelefProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefProvTextBox.Location = New System.Drawing.Point(88, 62)
        Me.TelefProvTextBox.Name = "TelefProvTextBox"
        Me.TelefProvTextBox.Size = New System.Drawing.Size(164, 22)
        Me.TelefProvTextBox.TabIndex = 7
        '
        'CiudadProvTextBox
        '
        Me.CiudadProvTextBox.Enabled = False
        Me.CiudadProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadProvTextBox.Location = New System.Drawing.Point(316, 62)
        Me.CiudadProvTextBox.Name = "CiudadProvTextBox"
        Me.CiudadProvTextBox.Size = New System.Drawing.Size(133, 22)
        Me.CiudadProvTextBox.TabIndex = 9
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Label2)
        Me.GroupBox2.Controls.Add(Me.NumfactCompraTB)
        Me.GroupBox2.Controls.Add(Me.BuscarBtn)
        Me.GroupBox2.Controls.Add(FechaEmiFactuDXPLabel)
        Me.GroupBox2.Controls.Add(IdPedDXPLabel)
        Me.GroupBox2.Controls.Add(Me.IdPedDXPTextBox)
        Me.GroupBox2.Controls.Add(MontoDxPLabel)
        Me.GroupBox2.Controls.Add(Me.MontoDxPTextBox)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(6, 92)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(460, 138)
        Me.GroupBox2.TabIndex = 55
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Pedido"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(192, 59)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 61
        '
        'NumfactCompraTB
        '
        Me.NumfactCompraTB.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumfactCompraTB.Location = New System.Drawing.Point(121, 100)
        Me.NumfactCompraTB.Name = "NumfactCompraTB"
        Me.NumfactCompraTB.Size = New System.Drawing.Size(131, 22)
        Me.NumfactCompraTB.TabIndex = 59
        '
        'BuscarBtn
        '
        Me.BuscarBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.BuscarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuscarBtn.FlatAppearance.BorderSize = 2
        Me.BuscarBtn.Image = CType(resources.GetObject("BuscarBtn.Image"), System.Drawing.Image)
        Me.BuscarBtn.Location = New System.Drawing.Point(252, 21)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(31, 29)
        Me.BuscarBtn.TabIndex = 59
        Me.BuscarBtn.UseVisualStyleBackColor = False
        '
        'IdPedDXPTextBox
        '
        Me.IdPedDXPTextBox.Enabled = False
        Me.IdPedDXPTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdPedDXPTextBox.Location = New System.Drawing.Point(115, 26)
        Me.IdPedDXPTextBox.Name = "IdPedDXPTextBox"
        Me.IdPedDXPTextBox.Size = New System.Drawing.Size(131, 22)
        Me.IdPedDXPTextBox.TabIndex = 7
        '
        'MontoDxPTextBox
        '
        Me.MontoDxPTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoDxPTextBox.Location = New System.Drawing.Point(319, 100)
        Me.MontoDxPTextBox.Name = "MontoDxPTextBox"
        Me.MontoDxPTextBox.Size = New System.Drawing.Size(128, 22)
        Me.MontoDxPTextBox.TabIndex = 9
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdDxPLabel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(231, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 46)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        '
        'IdDxPLabel1
        '
        Me.IdDxPLabel1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdDxPLabel1.Location = New System.Drawing.Point(141, 11)
        Me.IdDxPLabel1.Name = "IdDxPLabel1"
        Me.IdDxPLabel1.Size = New System.Drawing.Size(83, 19)
        Me.IdDxPLabel1.TabIndex = 55
        Me.IdDxPLabel1.Text = "00000"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Código de la  Deuda :"
        '
        'AgaciaBDDataSet1
        '
        Me.AgaciaBDDataSet1.DataSetName = "AgaciaBDDataSet1"
        Me.AgaciaBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MaxDXPBindingSource
        '
        Me.MaxDXPBindingSource.DataMember = "MaxDXP"
        Me.MaxDXPBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'MaxDXPTableAdapter
        '
        Me.MaxDXPTableAdapter.ClearBeforeFill = True
        '
        'SalirBtn
        '
        Me.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SalirBtn.FlatAppearance.BorderSize = 2
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(422, 385)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Size = New System.Drawing.Size(40, 43)
        Me.SalirBtn.TabIndex = 60
        Me.SalirBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelarBtn.FlatAppearance.BorderSize = 2
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.Location = New System.Drawing.Point(376, 385)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(40, 43)
        Me.CancelarBtn.TabIndex = 59
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'RegistroDxP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(477, 431)
        Me.Controls.Add(Me.SalirBtn)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "RegistroDxP"
        Me.Text = "RegistroDxP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxDXPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents NomProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents IdPedDXPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MontoDxPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdDxPLabel1 As System.Windows.Forms.Label
    Friend WithEvents AgaciaBDDataSet1 As AgaciaSolution.AgaciaBDDataSet1
    Friend WithEvents MaxDXPBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaxDXPTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.MaxDXPTableAdapter
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents NumfactCompraTB As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DirprovedorTB As System.Windows.Forms.TextBox
    Friend WithEvents SalirBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
End Class
