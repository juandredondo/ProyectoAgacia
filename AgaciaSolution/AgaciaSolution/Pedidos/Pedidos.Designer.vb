<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pedidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pedidos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.IdPedidoLBL = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.InfoPedGB = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.IrProdBTN = New System.Windows.Forms.Button
        Me.AñadirCMI = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ListarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AgregarNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CantidadNUD = New System.Windows.Forms.NumericUpDown
        Me.codproTB = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarCantidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BuscarProdBto = New System.Windows.Forms.Button
        Me.DetalleprodTB = New System.Windows.Forms.TextBox
        Me.NomClienteLbl = New System.Windows.Forms.Label
        Me.NombreProvTB = New System.Windows.Forms.TextBox
        Me.IdentificacionClienteLbl = New System.Windows.Forms.Label
        Me.DNIProveedorTB = New System.Windows.Forms.TextBox
        Me.NuevoBtn = New System.Windows.Forms.Button
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.IrBtn = New System.Windows.Forms.Button
        Me.DireccionClieLbl = New System.Windows.Forms.Label
        Me.DireccionProvTB = New System.Windows.Forms.TextBox
        Me.TelefonoClienteLbl = New System.Windows.Forms.Label
        Me.TelefonoProvTB = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.CiudadProvTB = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.IdEmpTextBox = New System.Windows.Forms.TextBox
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgaciaBDDataSet = New AgaciaSolution.AgaciaBDDataSet
        Me.Label12 = New System.Windows.Forms.Label
        Me.VendedorCB = New System.Windows.Forms.ComboBox
        Me.VendedorLbl = New System.Windows.Forms.Label
        Me.AccionesGB = New System.Windows.Forms.GroupBox
        Me.FacturarBtn = New System.Windows.Forms.Button
        Me.SalirBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.BuscarPROVEEDORESTableAdapter = New AgaciaSolution.BuscarDSDataSetTableAdapters.BuscarPROVEEDORESTableAdapter
        Me.BuscarDSDataSet = New AgaciaSolution.BuscarDSDataSet
        Me.BuscarDSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarPROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentaPedTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.CuentaPedTableAdapter
        Me.AgaciaBDDataSet1 = New AgaciaSolution.AgaciaBDDataSet1
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.ProductosTableAdapter
        Me.CuentaPedBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New AgaciaSolution.AgaciaBDDataSetTableAdapters.EmpleadosTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.AgaciaBDDataSetTableAdapters.TableAdapterManager
        Me.GroupBox1.SuspendLayout()
        Me.InfoPedGB.SuspendLayout()
        Me.AñadirCMI.SuspendLayout()
        CType(Me.CantidadNUD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgaciaBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AccionesGB.SuspendLayout()
        CType(Me.BuscarDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarDSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarPROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentaPedBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdPedidoLBL)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(373, 15)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 44)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'IdPedidoLBL
        '
        Me.IdPedidoLBL.AutoSize = True
        Me.IdPedidoLBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdPedidoLBL.ForeColor = System.Drawing.Color.Red
        Me.IdPedidoLBL.Location = New System.Drawing.Point(108, 9)
        Me.IdPedidoLBL.Name = "IdPedidoLBL"
        Me.IdPedidoLBL.Size = New System.Drawing.Size(66, 24)
        Me.IdPedidoLBL.TabIndex = 2
        Me.IdPedidoLBL.Text = "Label4"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(73, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "N° :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(8, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PEDIDO "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(373, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(428, 64)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(145, 21)
        Me.DateTimePicker1.TabIndex = 4
        '
        'InfoPedGB
        '
        Me.InfoPedGB.Controls.Add(Me.Label5)
        Me.InfoPedGB.Controls.Add(Me.Button1)
        Me.InfoPedGB.Controls.Add(Me.IrProdBTN)
        Me.InfoPedGB.Controls.Add(Me.CantidadNUD)
        Me.InfoPedGB.Controls.Add(Me.codproTB)
        Me.InfoPedGB.Controls.Add(Me.Label10)
        Me.InfoPedGB.Controls.Add(Me.Label9)
        Me.InfoPedGB.Controls.Add(Me.Label7)
        Me.InfoPedGB.Controls.Add(Me.DataGridView1)
        Me.InfoPedGB.Controls.Add(Me.BuscarProdBto)
        Me.InfoPedGB.Controls.Add(Me.DetalleprodTB)
        Me.InfoPedGB.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoPedGB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InfoPedGB.Location = New System.Drawing.Point(22, 259)
        Me.InfoPedGB.Name = "InfoPedGB"
        Me.InfoPedGB.Size = New System.Drawing.Size(554, 221)
        Me.InfoPedGB.TabIndex = 16
        Me.InfoPedGB.TabStop = False
        Me.InfoPedGB.Text = "Información del Pedido"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Gainsboro
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(513, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 21)
        Me.Label5.TabIndex = 38
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(513, 49)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 29)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Ir"
        Me.ToolTip1.SetToolTip(Me.Button1, "Ir")
        Me.Button1.UseVisualStyleBackColor = True
        '
        'IrProdBTN
        '
        Me.IrProdBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.IrProdBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.IrProdBTN.ContextMenuStrip = Me.AñadirCMI
        Me.IrProdBTN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IrProdBTN.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IrProdBTN.FlatAppearance.BorderSize = 2
        Me.IrProdBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IrProdBTN.Font = New System.Drawing.Font("Georgia", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IrProdBTN.Location = New System.Drawing.Point(125, 53)
        Me.IrProdBTN.Name = "IrProdBTN"
        Me.IrProdBTN.Size = New System.Drawing.Size(28, 22)
        Me.IrProdBTN.TabIndex = 36
        Me.IrProdBTN.Text = "Ir"
        Me.IrProdBTN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.IrProdBTN, "Añadir")
        Me.IrProdBTN.UseVisualStyleBackColor = True
        '
        'AñadirCMI
        '
        Me.AñadirCMI.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListarToolStripMenuItem, Me.AgregarNuevoToolStripMenuItem})
        Me.AñadirCMI.Name = "AñadirCMI"
        Me.AñadirCMI.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.AñadirCMI.Size = New System.Drawing.Size(153, 48)
        '
        'ListarToolStripMenuItem
        '
        Me.ListarToolStripMenuItem.Image = CType(resources.GetObject("ListarToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListarToolStripMenuItem.Name = "ListarToolStripMenuItem"
        Me.ListarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ListarToolStripMenuItem.Text = "Listar"
        '
        'AgregarNuevoToolStripMenuItem
        '
        Me.AgregarNuevoToolStripMenuItem.Image = CType(resources.GetObject("AgregarNuevoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AgregarNuevoToolStripMenuItem.Name = "AgregarNuevoToolStripMenuItem"
        Me.AgregarNuevoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AgregarNuevoToolStripMenuItem.Text = "Agregar nuevo"
        '
        'CantidadNUD
        '
        Me.CantidadNUD.Location = New System.Drawing.Point(447, 52)
        Me.CantidadNUD.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.CantidadNUD.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.CantidadNUD.Name = "CantidadNUD"
        Me.CantidadNUD.Size = New System.Drawing.Size(68, 25)
        Me.CantidadNUD.TabIndex = 35
        Me.CantidadNUD.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'codproTB
        '
        Me.codproTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.codproTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.codproTB.Location = New System.Drawing.Point(10, 53)
        Me.codproTB.Name = "codproTB"
        Me.codproTB.Size = New System.Drawing.Size(116, 22)
        Me.codproTB.TabIndex = 33
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 25)
        Me.Label10.TabIndex = 34
        Me.Label10.Text = "Codigo"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(447, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 25)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Cantidad"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(152, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(297, 25)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Detalle"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DataGridView1.Location = New System.Drawing.Point(10, 77)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(533, 117)
        Me.DataGridView1.TabIndex = 26
        '
        'Column1
        '
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column2.HeaderText = "Codigo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column3.HeaderText = "Detalle"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.ModificarCantidadToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(177, 48)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ModificarCantidadToolStripMenuItem
        '
        Me.ModificarCantidadToolStripMenuItem.Name = "ModificarCantidadToolStripMenuItem"
        Me.ModificarCantidadToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.ModificarCantidadToolStripMenuItem.Text = "Modificar Cantidad"
        '
        'BuscarProdBto
        '
        Me.BuscarProdBto.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.BuscarProdBto.BackgroundImage = CType(resources.GetObject("BuscarProdBto.BackgroundImage"), System.Drawing.Image)
        Me.BuscarProdBto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.BuscarProdBto.ContextMenuStrip = Me.AñadirCMI
        Me.BuscarProdBto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarProdBto.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuscarProdBto.FlatAppearance.BorderSize = 2
        Me.BuscarProdBto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarProdBto.Location = New System.Drawing.Point(429, 53)
        Me.BuscarProdBto.Name = "BuscarProdBto"
        Me.BuscarProdBto.Size = New System.Drawing.Size(20, 22)
        Me.BuscarProdBto.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.BuscarProdBto, "Añadir")
        Me.BuscarProdBto.UseVisualStyleBackColor = True
        '
        'DetalleprodTB
        '
        Me.DetalleprodTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DetalleprodTB.Enabled = False
        Me.DetalleprodTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DetalleprodTB.Location = New System.Drawing.Point(153, 53)
        Me.DetalleprodTB.Name = "DetalleprodTB"
        Me.DetalleprodTB.Size = New System.Drawing.Size(296, 22)
        Me.DetalleprodTB.TabIndex = 5
        '
        'NomClienteLbl
        '
        Me.NomClienteLbl.AutoSize = True
        Me.NomClienteLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomClienteLbl.Location = New System.Drawing.Point(12, 61)
        Me.NomClienteLbl.Name = "NomClienteLbl"
        Me.NomClienteLbl.Size = New System.Drawing.Size(57, 14)
        Me.NomClienteLbl.TabIndex = 4
        Me.NomClienteLbl.Text = "Nombre:"
        '
        'NombreProvTB
        '
        Me.NombreProvTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NombreProvTB.Enabled = False
        Me.NombreProvTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreProvTB.Location = New System.Drawing.Point(125, 57)
        Me.NombreProvTB.Name = "NombreProvTB"
        Me.NombreProvTB.Size = New System.Drawing.Size(377, 22)
        Me.NombreProvTB.TabIndex = 5
        '
        'IdentificacionClienteLbl
        '
        Me.IdentificacionClienteLbl.AutoSize = True
        Me.IdentificacionClienteLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdentificacionClienteLbl.Location = New System.Drawing.Point(12, 32)
        Me.IdentificacionClienteLbl.Name = "IdentificacionClienteLbl"
        Me.IdentificacionClienteLbl.Size = New System.Drawing.Size(35, 14)
        Me.IdentificacionClienteLbl.TabIndex = 6
        Me.IdentificacionClienteLbl.Text = "NIT: "
        '
        'DNIProveedorTB
        '
        Me.DNIProveedorTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DNIProveedorTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DNIProveedorTB.Location = New System.Drawing.Point(127, 27)
        Me.DNIProveedorTB.Name = "DNIProveedorTB"
        Me.DNIProveedorTB.Size = New System.Drawing.Size(122, 22)
        Me.DNIProveedorTB.TabIndex = 7
        '
        'NuevoBtn
        '
        Me.NuevoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuevoBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NuevoBtn.FlatAppearance.BorderSize = 2
        Me.NuevoBtn.Image = CType(resources.GetObject("NuevoBtn.Image"), System.Drawing.Image)
        Me.NuevoBtn.Location = New System.Drawing.Point(328, 22)
        Me.NuevoBtn.Name = "NuevoBtn"
        Me.NuevoBtn.Size = New System.Drawing.Size(32, 29)
        Me.NuevoBtn.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.NuevoBtn, "Agregar")
        Me.NuevoBtn.UseVisualStyleBackColor = True
        '
        'BuscarBtn
        '
        Me.BuscarBtn.BackColor = System.Drawing.Color.AliceBlue
        Me.BuscarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuscarBtn.FlatAppearance.BorderSize = 2
        Me.BuscarBtn.Image = CType(resources.GetObject("BuscarBtn.Image"), System.Drawing.Image)
        Me.BuscarBtn.Location = New System.Drawing.Point(291, 22)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(31, 29)
        Me.BuscarBtn.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.BuscarBtn, "Buscar")
        Me.BuscarBtn.UseVisualStyleBackColor = False
        '
        'IrBtn
        '
        Me.IrBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IrBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IrBtn.FlatAppearance.BorderSize = 2
        Me.IrBtn.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IrBtn.Location = New System.Drawing.Point(254, 22)
        Me.IrBtn.Name = "IrBtn"
        Me.IrBtn.Size = New System.Drawing.Size(31, 29)
        Me.IrBtn.TabIndex = 11
        Me.IrBtn.Text = "Ir"
        Me.ToolTip1.SetToolTip(Me.IrBtn, "Ir")
        Me.IrBtn.UseVisualStyleBackColor = True
        '
        'DireccionClieLbl
        '
        Me.DireccionClieLbl.AutoSize = True
        Me.DireccionClieLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionClieLbl.Location = New System.Drawing.Point(12, 92)
        Me.DireccionClieLbl.Name = "DireccionClieLbl"
        Me.DireccionClieLbl.Size = New System.Drawing.Size(68, 14)
        Me.DireccionClieLbl.TabIndex = 12
        Me.DireccionClieLbl.Text = "Dirección :"
        '
        'DireccionProvTB
        '
        Me.DireccionProvTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DireccionProvTB.Enabled = False
        Me.DireccionProvTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionProvTB.Location = New System.Drawing.Point(127, 87)
        Me.DireccionProvTB.Name = "DireccionProvTB"
        Me.DireccionProvTB.Size = New System.Drawing.Size(375, 22)
        Me.DireccionProvTB.TabIndex = 13
        '
        'TelefonoClienteLbl
        '
        Me.TelefonoClienteLbl.AutoSize = True
        Me.TelefonoClienteLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoClienteLbl.Location = New System.Drawing.Point(12, 122)
        Me.TelefonoClienteLbl.Name = "TelefonoClienteLbl"
        Me.TelefonoClienteLbl.Size = New System.Drawing.Size(70, 14)
        Me.TelefonoClienteLbl.TabIndex = 14
        Me.TelefonoClienteLbl.Text = "Telefonos  :"
        '
        'TelefonoProvTB
        '
        Me.TelefonoProvTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TelefonoProvTB.Enabled = False
        Me.TelefonoProvTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoProvTB.Location = New System.Drawing.Point(127, 117)
        Me.TelefonoProvTB.Name = "TelefonoProvTB"
        Me.TelefonoProvTB.Size = New System.Drawing.Size(148, 22)
        Me.TelefonoProvTB.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.CiudadProvTB)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.TelefonoProvTB)
        Me.GroupBox2.Controls.Add(Me.TelefonoClienteLbl)
        Me.GroupBox2.Controls.Add(Me.DireccionProvTB)
        Me.GroupBox2.Controls.Add(Me.DireccionClieLbl)
        Me.GroupBox2.Controls.Add(Me.IrBtn)
        Me.GroupBox2.Controls.Add(Me.BuscarBtn)
        Me.GroupBox2.Controls.Add(Me.NuevoBtn)
        Me.GroupBox2.Controls.Add(Me.DNIProveedorTB)
        Me.GroupBox2.Controls.Add(Me.IdentificacionClienteLbl)
        Me.GroupBox2.Controls.Add(Me.NombreProvTB)
        Me.GroupBox2.Controls.Add(Me.NomClienteLbl)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(22, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(554, 157)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Proveedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(303, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 14)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Ciudad:"
        '
        'CiudadProvTB
        '
        Me.CiudadProvTB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CiudadProvTB.Enabled = False
        Me.CiudadProvTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadProvTB.Location = New System.Drawing.Point(360, 117)
        Me.CiudadProvTB.Name = "CiudadProvTB"
        Me.CiudadProvTB.Size = New System.Drawing.Size(142, 22)
        Me.CiudadProvTB.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(406, 125)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 14)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Ciudad:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.IdEmpTextBox)
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.VendedorCB)
        Me.GroupBox5.Controls.Add(Me.VendedorLbl)
        Me.GroupBox5.Location = New System.Drawing.Point(22, 482)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(554, 47)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        '
        'IdEmpTextBox
        '
        Me.IdEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IdEmp", True))
        Me.IdEmpTextBox.Location = New System.Drawing.Point(448, -31)
        Me.IdEmpTextBox.Name = "IdEmpTextBox"
        Me.IdEmpTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdEmpTextBox.TabIndex = 32
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.AgaciaBDDataSet
        '
        'AgaciaBDDataSet
        '
        Me.AgaciaBDDataSet.DataSetName = "AgaciaBDDataSet"
        Me.AgaciaBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(383, -31)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 14)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Cedula :"
        '
        'VendedorCB
        '
        Me.VendedorCB.DataSource = Me.EmpleadosBindingSource
        Me.VendedorCB.DisplayMember = "NomEmp"
        Me.VendedorCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendedorCB.FormattingEnabled = True
        Me.VendedorCB.Location = New System.Drawing.Point(81, 14)
        Me.VendedorCB.Name = "VendedorCB"
        Me.VendedorCB.Size = New System.Drawing.Size(276, 23)
        Me.VendedorCB.TabIndex = 30
        Me.VendedorCB.ValueMember = "IdEmp"
        '
        'VendedorLbl
        '
        Me.VendedorLbl.AutoSize = True
        Me.VendedorLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendedorLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.VendedorLbl.Location = New System.Drawing.Point(2, 17)
        Me.VendedorLbl.Name = "VendedorLbl"
        Me.VendedorLbl.Size = New System.Drawing.Size(66, 14)
        Me.VendedorLbl.TabIndex = 29
        Me.VendedorLbl.Text = "Vendedor:"
        '
        'AccionesGB
        '
        Me.AccionesGB.Controls.Add(Me.FacturarBtn)
        Me.AccionesGB.Controls.Add(Me.SalirBtn)
        Me.AccionesGB.Controls.Add(Me.CancelarBtn)
        Me.AccionesGB.Controls.Add(Me.GuardarBtn)
        Me.AccionesGB.Location = New System.Drawing.Point(376, 530)
        Me.AccionesGB.Name = "AccionesGB"
        Me.AccionesGB.Size = New System.Drawing.Size(200, 61)
        Me.AccionesGB.TabIndex = 32
        Me.AccionesGB.TabStop = False
        '
        'FacturarBtn
        '
        Me.FacturarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FacturarBtn.Enabled = False
        Me.FacturarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FacturarBtn.FlatAppearance.BorderSize = 2
        Me.FacturarBtn.Image = CType(resources.GetObject("FacturarBtn.Image"), System.Drawing.Image)
        Me.FacturarBtn.Location = New System.Drawing.Point(57, 12)
        Me.FacturarBtn.Name = "FacturarBtn"
        Me.FacturarBtn.Size = New System.Drawing.Size(40, 43)
        Me.FacturarBtn.TabIndex = 39
        Me.FacturarBtn.UseVisualStyleBackColor = True
        '
        'SalirBtn
        '
        Me.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SalirBtn.FlatAppearance.BorderSize = 2
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(149, 12)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Size = New System.Drawing.Size(40, 43)
        Me.SalirBtn.TabIndex = 34
        Me.ToolTip1.SetToolTip(Me.SalirBtn, "Sallir")
        Me.SalirBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelarBtn.FlatAppearance.BorderSize = 2
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.Location = New System.Drawing.Point(103, 12)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(40, 43)
        Me.CancelarBtn.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.CancelarBtn, "Cancelar")
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GuardarBtn.FlatAppearance.BorderSize = 2
        Me.GuardarBtn.Image = CType(resources.GetObject("GuardarBtn.Image"), System.Drawing.Image)
        Me.GuardarBtn.Location = New System.Drawing.Point(11, 12)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(40, 43)
        Me.GuardarBtn.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.GuardarBtn, "Guardar")
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'BuscarPROVEEDORESTableAdapter
        '
        Me.BuscarPROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'BuscarDSDataSet
        '
        Me.BuscarDSDataSet.DataSetName = "BuscarDSDataSet"
        Me.BuscarDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscarDSDataSetBindingSource
        '
        Me.BuscarDSDataSetBindingSource.DataSource = Me.BuscarDSDataSet
        Me.BuscarDSDataSetBindingSource.Position = 0
        '
        'BuscarPROVEEDORESBindingSource
        '
        Me.BuscarPROVEEDORESBindingSource.DataMember = "BuscarPROVEEDORES"
        Me.BuscarPROVEEDORESBindingSource.DataSource = Me.BuscarDSDataSetBindingSource
        '
        'CuentaPedTableAdapter
        '
        Me.CuentaPedTableAdapter.ClearBeforeFill = True
        '
        'AgaciaBDDataSet1
        '
        Me.AgaciaBDDataSet1.DataSetName = "AgaciaBDDataSet1"
        Me.AgaciaBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'CuentaPedBindingSource
        '
        Me.CuentaPedBindingSource.DataMember = "CuentaPed"
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AgaciaSolution.AgaciaBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(598, 600)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.AccionesGB)
        Me.Controls.Add(Me.InfoPedGB)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Pedidos"
        Me.Text = "Registro de Pedidos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.InfoPedGB.ResumeLayout(False)
        Me.InfoPedGB.PerformLayout()
        Me.AñadirCMI.ResumeLayout(False)
        CType(Me.CantidadNUD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgaciaBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AccionesGB.ResumeLayout(False)
        CType(Me.BuscarDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarDSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarPROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentaPedBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents InfoPedGB As System.Windows.Forms.GroupBox
    Friend WithEvents DetalleprodTB As System.Windows.Forms.TextBox
    Friend WithEvents BuscarProdBto As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents NomClienteLbl As System.Windows.Forms.Label
    Friend WithEvents NombreProvTB As System.Windows.Forms.TextBox
    Friend WithEvents IdentificacionClienteLbl As System.Windows.Forms.Label
    Friend WithEvents DNIProveedorTB As System.Windows.Forms.TextBox
    Friend WithEvents NuevoBtn As System.Windows.Forms.Button
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents IrBtn As System.Windows.Forms.Button
    Friend WithEvents DireccionClieLbl As System.Windows.Forms.Label
    Friend WithEvents DireccionProvTB As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoClienteLbl As System.Windows.Forms.Label
    Friend WithEvents TelefonoProvTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents VendedorLbl As System.Windows.Forms.Label
    Friend WithEvents VendedorCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AccionesGB As System.Windows.Forms.GroupBox
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents SalirBtn As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CiudadProvTB As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents codproTB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents AñadirCMI As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ListarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgregarNuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CantidadNUD As System.Windows.Forms.NumericUpDown
    Friend WithEvents IdPedidoLBL As System.Windows.Forms.Label
    Friend WithEvents BuscarPROVEEDORESTableAdapter As AgaciaSolution.BuscarDSDataSetTableAdapters.BuscarPROVEEDORESTableAdapter
    Friend WithEvents BuscarDSDataSet As AgaciaSolution.BuscarDSDataSet
    Friend WithEvents BuscarDSDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuscarPROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents IrProdBTN As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CuentaPedTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.CuentaPedTableAdapter
    Friend WithEvents CuentaPedBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgaciaBDDataSet1 As AgaciaSolution.AgaciaBDDataSet1
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.ProductosTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarCantidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AgaciaBDDataSet As AgaciaSolution.AgaciaBDDataSet
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As AgaciaSolution.AgaciaBDDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents IdEmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager As AgaciaSolution.AgaciaBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FacturarBtn As System.Windows.Forms.Button
End Class
