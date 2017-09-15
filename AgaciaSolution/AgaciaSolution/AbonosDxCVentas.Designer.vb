<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbonosDxCVentas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbonosDxCVentas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.NomClie = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.IdClie = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.CodCobro = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.MontoTotal = New System.Windows.Forms.TextBox
        Me.Numfact = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.NuevoAbonoTB = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.IdAbonoDxCLabel1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdAbonoDxCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaAbonoDxCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.IdDxCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.AbonoDxCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VerAbonosXIdClieBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgaciaBDDataSet1 = New AgaciaSolution.AgaciaBDDataSet1
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.AbonosLbl = New System.Windows.Forms.Label
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.MaxDxCTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.MaxDxCTableAdapter
        Me.MaxDxCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VerAbonosXIdClieTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.VerAbonosXIdClieTableAdapter
        Me.MaxAbonoDXCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MaxAbonoDXCTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.MaxAbonoDXCTableAdapter
        Me.AñadirAbonoBTN = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerAbonosXIdClieBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.MaxDxCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxAbonoDXCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.NomClie)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.IdClie)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.BuscarBtn)
        Me.GroupBox2.Controls.Add(Me.CodCobro)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.MontoTotal)
        Me.GroupBox2.Controls.Add(Me.Numfact)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(12, 131)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(585, 100)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion De La  Deuda"
        '
        'NomClie
        '
        Me.NomClie.Enabled = False
        Me.NomClie.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomClie.Location = New System.Drawing.Point(70, 63)
        Me.NomClie.Name = "NomClie"
        Me.NomClie.Size = New System.Drawing.Size(283, 20)
        Me.NomClie.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(12, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 14)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Cliente:"
        '
        'IdClie
        '
        Me.IdClie.Enabled = False
        Me.IdClie.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdClie.Location = New System.Drawing.Point(455, 63)
        Me.IdClie.Name = "IdClie"
        Me.IdClie.Size = New System.Drawing.Size(122, 20)
        Me.IdClie.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(359, 66)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(90, 14)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Identificación:"
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuscarBtn.FlatAppearance.BorderSize = 2
        Me.BuscarBtn.Image = CType(resources.GetObject("BuscarBtn.Image"), System.Drawing.Image)
        Me.BuscarBtn.Location = New System.Drawing.Point(208, 24)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(26, 24)
        Me.BuscarBtn.TabIndex = 17
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'CodCobro
        '
        Me.CodCobro.Enabled = False
        Me.CodCobro.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodCobro.Location = New System.Drawing.Point(109, 28)
        Me.CodCobro.Name = "CodCobro"
        Me.CodCobro.Size = New System.Drawing.Size(93, 20)
        Me.CodCobro.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(6, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 14)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Codigo de Cobro:"
        '
        'MontoTotal
        '
        Me.MontoTotal.Enabled = False
        Me.MontoTotal.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoTotal.Location = New System.Drawing.Point(477, 28)
        Me.MontoTotal.Name = "MontoTotal"
        Me.MontoTotal.Size = New System.Drawing.Size(100, 20)
        Me.MontoTotal.TabIndex = 7
        '
        'Numfact
        '
        Me.Numfact.Enabled = False
        Me.Numfact.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Numfact.Location = New System.Drawing.Point(316, 28)
        Me.Numfact.Name = "Numfact"
        Me.Numfact.Size = New System.Drawing.Size(95, 20)
        Me.Numfact.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(240, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Factura N° :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(425, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto:"
        '
        'NuevoAbonoTB
        '
        Me.NuevoAbonoTB.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuevoAbonoTB.Location = New System.Drawing.Point(429, 259)
        Me.NuevoAbonoTB.Name = "NuevoAbonoTB"
        Me.NuevoAbonoTB.Size = New System.Drawing.Size(125, 20)
        Me.NuevoAbonoTB.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(333, 262)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 14)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Nuevo Abono :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(484, 101)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(111, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(437, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 14)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Codigo Abono"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdAbonoDxCLabel1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(431, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(164, 38)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        '
        'IdAbonoDxCLabel1
        '
        Me.IdAbonoDxCLabel1.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdAbonoDxCLabel1.Location = New System.Drawing.Point(101, 11)
        Me.IdAbonoDxCLabel1.Name = "IdAbonoDxCLabel1"
        Me.IdAbonoDxCLabel1.Size = New System.Drawing.Size(54, 19)
        Me.IdAbonoDxCLabel1.TabIndex = 56
        Me.IdAbonoDxCLabel1.Text = "00000"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdAbonoDxCDataGridViewTextBoxColumn, Me.FechaAbonoDxCDataGridViewTextBoxColumn, Me.IdDxCDataGridViewTextBoxColumn, Me.AbonoDxCDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.VerAbonosXIdClieBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(43, 24)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(506, 150)
        Me.DataGridView1.TabIndex = 15
        '
        'IdAbonoDxCDataGridViewTextBoxColumn
        '
        Me.IdAbonoDxCDataGridViewTextBoxColumn.DataPropertyName = "IdAbonoDxC"
        Me.IdAbonoDxCDataGridViewTextBoxColumn.HeaderText = "Código de abono"
        Me.IdAbonoDxCDataGridViewTextBoxColumn.Name = "IdAbonoDxCDataGridViewTextBoxColumn"
        Me.IdAbonoDxCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FechaAbonoDxCDataGridViewTextBoxColumn
        '
        Me.FechaAbonoDxCDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FechaAbonoDxCDataGridViewTextBoxColumn.DataPropertyName = "FechaAbonoDxC"
        Me.FechaAbonoDxCDataGridViewTextBoxColumn.HeaderText = "Fecha de abono"
        Me.FechaAbonoDxCDataGridViewTextBoxColumn.Name = "FechaAbonoDxCDataGridViewTextBoxColumn"
        Me.FechaAbonoDxCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdDxCDataGridViewTextBoxColumn
        '
        Me.IdDxCDataGridViewTextBoxColumn.DataPropertyName = "IdDxC"
        Me.IdDxCDataGridViewTextBoxColumn.HeaderText = "Código de cobro"
        Me.IdDxCDataGridViewTextBoxColumn.Name = "IdDxCDataGridViewTextBoxColumn"
        Me.IdDxCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AbonoDxCDataGridViewTextBoxColumn
        '
        Me.AbonoDxCDataGridViewTextBoxColumn.DataPropertyName = "AbonoDxC"
        Me.AbonoDxCDataGridViewTextBoxColumn.HeaderText = "Abono"
        Me.AbonoDxCDataGridViewTextBoxColumn.Name = "AbonoDxCDataGridViewTextBoxColumn"
        Me.AbonoDxCDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VerAbonosXIdClieBindingSource
        '
        Me.VerAbonosXIdClieBindingSource.DataMember = "VerAbonosXIdClie"
        Me.VerAbonosXIdClieBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'AgaciaBDDataSet1
        '
        Me.AgaciaBDDataSet1.DataSetName = "AgaciaBDDataSet1"
        Me.AgaciaBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 470)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(202, 39)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(122, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(16, 18)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DarkRed
        Me.Label7.Location = New System.Drawing.Point(6, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(117, 14)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Total Abonos:    $"
        '
        'AbonosLbl
        '
        Me.AbonosLbl.Font = New System.Drawing.Font("Georgia", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbonosLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.AbonosLbl.Location = New System.Drawing.Point(119, 18)
        Me.AbonosLbl.Name = "AbonosLbl"
        Me.AbonosLbl.Size = New System.Drawing.Size(430, 46)
        Me.AbonosLbl.TabIndex = 37
        Me.AbonosLbl.Text = "    Abonos Documentos por  Cobrar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelarBtn.Enabled = False
        Me.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelarBtn.FlatAppearance.BorderSize = 2
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.Location = New System.Drawing.Point(44, 10)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(41, 42)
        Me.CancelarBtn.TabIndex = 39
        Me.ToolTip1.SetToolTip(Me.CancelarBtn, "Cancelar")
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GuardarBtn.FlatAppearance.BorderSize = 2
        Me.GuardarBtn.Image = CType(resources.GetObject("GuardarBtn.Image"), System.Drawing.Image)
        Me.GuardarBtn.Location = New System.Drawing.Point(0, 10)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(42, 42)
        Me.GuardarBtn.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.GuardarBtn, "Guardar")
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CancelarBtn)
        Me.GroupBox4.Controls.Add(Me.GuardarBtn)
        Me.GroupBox4.Location = New System.Drawing.Point(501, 482)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(85, 58)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.DataGridView1)
        Me.GroupBox6.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox6.Location = New System.Drawing.Point(12, 279)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(583, 180)
        Me.GroupBox6.TabIndex = 48
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Listado de Abonos"
        '
        'MaxDxCTableAdapter
        '
        Me.MaxDxCTableAdapter.ClearBeforeFill = True
        '
        'MaxDxCBindingSource
        '
        Me.MaxDxCBindingSource.DataMember = "MaxDxC"
        Me.MaxDxCBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'VerAbonosXIdClieTableAdapter
        '
        Me.VerAbonosXIdClieTableAdapter.ClearBeforeFill = True
        '
        'MaxAbonoDXCBindingSource
        '
        Me.MaxAbonoDXCBindingSource.DataMember = "MaxAbonoDXC"
        Me.MaxAbonoDXCBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'MaxAbonoDXCTableAdapter
        '
        Me.MaxAbonoDXCTableAdapter.ClearBeforeFill = True
        '
        'AñadirAbonoBTN
        '
        Me.AñadirAbonoBTN.Location = New System.Drawing.Point(560, 257)
        Me.AñadirAbonoBTN.Name = "AñadirAbonoBTN"
        Me.AñadirAbonoBTN.Size = New System.Drawing.Size(31, 23)
        Me.AñadirAbonoBTN.TabIndex = 49
        Me.AñadirAbonoBTN.Text = "Ir"
        Me.AñadirAbonoBTN.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label11)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Location = New System.Drawing.Point(255, 470)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(202, 39)
        Me.GroupBox5.TabIndex = 50
        Me.GroupBox5.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(122, 12)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 18)
        Me.Label11.TabIndex = 12
        Me.Label11.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(36, 15)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 14)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Saldo:    $"
        '
        'AbonosDxCVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(603, 540)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.AñadirAbonoBTN)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.NuevoAbonoTB)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.AbonosLbl)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AbonosDxCVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AbonosDxC"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerAbonosXIdClieBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        CType(Me.MaxDxCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxAbonoDXCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MontoTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Numfact As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CodCobro As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents NuevoAbonoTB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents AbonosLbl As System.Windows.Forms.Label
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents MaxDxCTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.MaxDxCTableAdapter
    Friend WithEvents MaxDxCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgaciaBDDataSet1 As AgaciaSolution.AgaciaBDDataSet1
    Friend WithEvents IdAbonoDxCLabel1 As System.Windows.Forms.Label
    Friend WithEvents NomClie As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents IdClie As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents VerAbonosXIdClieBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents VerAbonosXIdClieTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.VerAbonosXIdClieTableAdapter
    Friend WithEvents MaxAbonoDXCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MaxAbonoDXCTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.MaxAbonoDXCTableAdapter
    Friend WithEvents IdAbonoDxCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaAbonoDxCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdDxCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbonoDxCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AñadirAbonoBTN As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
