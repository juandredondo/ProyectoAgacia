<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ventas))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.IdfactTB = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.IdEmpTextBox = New System.Windows.Forms.TextBox
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgaciaBDDataSet = New AgaciaSolution.AgaciaBDDataSet
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModificarCantidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VrUnitTB = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.ExistenciaTB = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.CantidadProTB = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.BuscarProductoBtn = New System.Windows.Forms.Button
        Me.CodProdTB = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.NomProdTB = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.NomClienteLbl = New System.Windows.Forms.Label
        Me.NomClienteTB = New System.Windows.Forms.TextBox
        Me.IdentificacionClienteLbl = New System.Windows.Forms.Label
        Me.IdentificacionClienteTB = New System.Windows.Forms.TextBox
        Me.NuevoBtn = New System.Windows.Forms.Button
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.IrBtn = New System.Windows.Forms.Button
        Me.DireccionClieLbl = New System.Windows.Forms.Label
        Me.DireccionClienteTB = New System.Windows.Forms.TextBox
        Me.TelefonoClienteLbl = New System.Windows.Forms.Label
        Me.TelclienteTB = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.TotalTB = New System.Windows.Forms.TextBox
        Me.ivaTB = New System.Windows.Forms.TextBox
        Me.subtotalTB = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.VendedorCB = New System.Windows.Forms.ComboBox
        Me.VendedorLbl = New System.Windows.Forms.Label
        Me.FormadePagoCB = New System.Windows.Forms.ComboBox
        Me.FormadepagoLbl = New System.Windows.Forms.Label
        Me.AccionesGB = New System.Windows.Forms.GroupBox
        Me.SalirBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.TableAdapterManager = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager
        Me.ClientesTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.ClientesTableAdapter
        Me.ProductosTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.ProductosTableAdapter
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgaciaBDDataSet1 = New AgaciaSolution.AgaciaBDDataSet1
        Me.TableAdapterManager1 = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgaciaBDDataSet11 = New AgaciaSolution.AgaciaBDDataSet1
        Me.FacturasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CuentafacturasTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.CuentafacturasTableAdapter
        Me.CuentafacturasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BucaexistprodTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.bucaexistprodTableAdapter
        Me.BucaexistprodBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New AgaciaSolution.AgaciaBDDataSetTableAdapters.EmpleadosTableAdapter
        Me.TableAdapterManager2 = New AgaciaSolution.AgaciaBDDataSetTableAdapters.TableAdapterManager
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.FacturarBtn = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgaciaBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.AccionesGB.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgaciaBDDataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CuentafacturasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BucaexistprodBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdfactTB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(407, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(230, 67)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'IdfactTB
        '
        Me.IdfactTB.Enabled = False
        Me.IdfactTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdfactTB.Location = New System.Drawing.Point(77, 38)
        Me.IdfactTB.Name = "IdfactTB"
        Me.IdfactTB.Size = New System.Drawing.Size(112, 21)
        Me.IdfactTB.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(42, 40)
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
        Me.Label1.Location = New System.Drawing.Point(40, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FACTURA DE VENTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(404, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Fecha :"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(462, 74)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(175, 21)
        Me.DateTimePicker1.TabIndex = 4
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.IdEmpTextBox)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Controls.Add(Me.VrUnitTB)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ExistenciaTB)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.CantidadProTB)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.BuscarProductoBtn)
        Me.GroupBox3.Controls.Add(Me.CodProdTB)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.NomProdTB)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox3.Location = New System.Drawing.Point(12, 227)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(625, 255)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información de Venta"
        '
        'IdEmpTextBox
        '
        Me.IdEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IdEmp", True))
        Me.IdEmpTextBox.Location = New System.Drawing.Point(158, 282)
        Me.IdEmpTextBox.Name = "IdEmpTextBox"
        Me.IdEmpTextBox.Size = New System.Drawing.Size(100, 25)
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
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(546, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(31, 29)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Ir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Button5.FlatAppearance.BorderSize = 2
        Me.Button5.Location = New System.Drawing.Point(469, 218)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(146, 29)
        Me.Button5.TabIndex = 28
        Me.Button5.Text = "Finalizar venta"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.Info
        Me.DataGridView1.Location = New System.Drawing.Point(9, 91)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(606, 121)
        Me.DataGridView1.TabIndex = 26
        '
        'Column1
        '
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle3
        Me.Column1.FillWeight = 50.0!
        Me.Column1.HeaderText = "Ítem"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle4
        Me.Column2.HeaderText = "Código"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column3.DefaultCellStyle = DataGridViewCellStyle5
        Me.Column3.HeaderText = "Detalle"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle6
        Me.Column4.HeaderText = "Cant"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 50
        '
        'Column5
        '
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle7
        Me.Column5.HeaderText = "Vr Unitario"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column6.DefaultCellStyle = DataGridViewCellStyle8
        Me.Column6.HeaderText = "Vr Total"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem, Me.ModificarCantidadToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(175, 48)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ModificarCantidadToolStripMenuItem
        '
        Me.ModificarCantidadToolStripMenuItem.Name = "ModificarCantidadToolStripMenuItem"
        Me.ModificarCantidadToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.ModificarCantidadToolStripMenuItem.Text = "Modificar cantidad"
        '
        'VrUnitTB
        '
        Me.VrUnitTB.Enabled = False
        Me.VrUnitTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VrUnitTB.Location = New System.Drawing.Point(487, 56)
        Me.VrUnitTB.Name = "VrUnitTB"
        Me.VrUnitTB.Size = New System.Drawing.Size(90, 22)
        Me.VrUnitTB.TabIndex = 25
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(428, 61)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 14)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Vr Unit:"
        '
        'ExistenciaTB
        '
        Me.ExistenciaTB.Enabled = False
        Me.ExistenciaTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExistenciaTB.Location = New System.Drawing.Point(351, 56)
        Me.ExistenciaTB.Name = "ExistenciaTB"
        Me.ExistenciaTB.Size = New System.Drawing.Size(60, 22)
        Me.ExistenciaTB.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(264, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 14)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Existencia :"
        '
        'CantidadProTB
        '
        Me.CantidadProTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadProTB.Location = New System.Drawing.Point(440, 27)
        Me.CantidadProTB.Name = "CantidadProTB"
        Me.CantidadProTB.Size = New System.Drawing.Size(62, 22)
        Me.CantidadProTB.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(360, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 14)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Cantidad :"
        '
        'BuscarProductoBtn
        '
        Me.BuscarProductoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarProductoBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuscarProductoBtn.FlatAppearance.BorderSize = 2
        Me.BuscarProductoBtn.Image = CType(resources.GetObject("BuscarProductoBtn.Image"), System.Drawing.Image)
        Me.BuscarProductoBtn.Location = New System.Drawing.Point(267, 20)
        Me.BuscarProductoBtn.Name = "BuscarProductoBtn"
        Me.BuscarProductoBtn.Size = New System.Drawing.Size(31, 29)
        Me.BuscarProductoBtn.TabIndex = 17
        Me.BuscarProductoBtn.UseVisualStyleBackColor = True
        '
        'CodProdTB
        '
        Me.CodProdTB.Enabled = False
        Me.CodProdTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodProdTB.Location = New System.Drawing.Point(157, 27)
        Me.CodProdTB.Name = "CodProdTB"
        Me.CodProdTB.Size = New System.Drawing.Size(101, 22)
        Me.CodProdTB.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(16, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 14)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Codigo del Producto :"
        '
        'NomProdTB
        '
        Me.NomProdTB.Enabled = False
        Me.NomProdTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomProdTB.Location = New System.Drawing.Point(97, 56)
        Me.NomProdTB.Name = "NomProdTB"
        Me.NomProdTB.Size = New System.Drawing.Size(161, 22)
        Me.NomProdTB.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Nombre:"
        '
        'NomClienteLbl
        '
        Me.NomClienteLbl.AutoSize = True
        Me.NomClienteLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomClienteLbl.Location = New System.Drawing.Point(16, 61)
        Me.NomClienteLbl.Name = "NomClienteLbl"
        Me.NomClienteLbl.Size = New System.Drawing.Size(63, 14)
        Me.NomClienteLbl.TabIndex = 4
        Me.NomClienteLbl.Text = "Nombre:"
        '
        'NomClienteTB
        '
        Me.NomClienteTB.Enabled = False
        Me.NomClienteTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomClienteTB.Location = New System.Drawing.Point(127, 56)
        Me.NomClienteTB.Name = "NomClienteTB"
        Me.NomClienteTB.Size = New System.Drawing.Size(410, 22)
        Me.NomClienteTB.TabIndex = 5
        '
        'IdentificacionClienteLbl
        '
        Me.IdentificacionClienteLbl.AutoSize = True
        Me.IdentificacionClienteLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdentificacionClienteLbl.Location = New System.Drawing.Point(16, 32)
        Me.IdentificacionClienteLbl.Name = "IdentificacionClienteLbl"
        Me.IdentificacionClienteLbl.Size = New System.Drawing.Size(105, 14)
        Me.IdentificacionClienteLbl.TabIndex = 6
        Me.IdentificacionClienteLbl.Text = "Identificación :"
        '
        'IdentificacionClienteTB
        '
        Me.IdentificacionClienteTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdentificacionClienteTB.Location = New System.Drawing.Point(127, 27)
        Me.IdentificacionClienteTB.Name = "IdentificacionClienteTB"
        Me.IdentificacionClienteTB.Size = New System.Drawing.Size(122, 22)
        Me.IdentificacionClienteTB.TabIndex = 7
        '
        'NuevoBtn
        '
        Me.NuevoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuevoBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NuevoBtn.FlatAppearance.BorderSize = 2
        Me.NuevoBtn.Image = CType(resources.GetObject("NuevoBtn.Image"), System.Drawing.Image)
        Me.NuevoBtn.Location = New System.Drawing.Point(331, 17)
        Me.NuevoBtn.Name = "NuevoBtn"
        Me.NuevoBtn.Size = New System.Drawing.Size(32, 29)
        Me.NuevoBtn.TabIndex = 7
        Me.NuevoBtn.UseVisualStyleBackColor = True
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuscarBtn.FlatAppearance.BorderSize = 2
        Me.BuscarBtn.Image = CType(resources.GetObject("BuscarBtn.Image"), System.Drawing.Image)
        Me.BuscarBtn.Location = New System.Drawing.Point(294, 17)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(31, 29)
        Me.BuscarBtn.TabIndex = 10
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'IrBtn
        '
        Me.IrBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.IrBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IrBtn.FlatAppearance.BorderSize = 2
        Me.IrBtn.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IrBtn.Location = New System.Drawing.Point(257, 17)
        Me.IrBtn.Name = "IrBtn"
        Me.IrBtn.Size = New System.Drawing.Size(31, 29)
        Me.IrBtn.TabIndex = 11
        Me.IrBtn.Text = "Ir"
        Me.IrBtn.UseVisualStyleBackColor = True
        '
        'DireccionClieLbl
        '
        Me.DireccionClieLbl.AutoSize = True
        Me.DireccionClieLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionClieLbl.Location = New System.Drawing.Point(16, 92)
        Me.DireccionClieLbl.Name = "DireccionClieLbl"
        Me.DireccionClieLbl.Size = New System.Drawing.Size(75, 14)
        Me.DireccionClieLbl.TabIndex = 12
        Me.DireccionClieLbl.Text = "Dirección :"
        '
        'DireccionClienteTB
        '
        Me.DireccionClienteTB.Enabled = False
        Me.DireccionClienteTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireccionClienteTB.Location = New System.Drawing.Point(127, 87)
        Me.DireccionClienteTB.Name = "DireccionClienteTB"
        Me.DireccionClienteTB.Size = New System.Drawing.Size(122, 22)
        Me.DireccionClienteTB.TabIndex = 13
        '
        'TelefonoClienteLbl
        '
        Me.TelefonoClienteLbl.AutoSize = True
        Me.TelefonoClienteLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefonoClienteLbl.Location = New System.Drawing.Point(255, 92)
        Me.TelefonoClienteLbl.Name = "TelefonoClienteLbl"
        Me.TelefonoClienteLbl.Size = New System.Drawing.Size(79, 14)
        Me.TelefonoClienteLbl.TabIndex = 14
        Me.TelefonoClienteLbl.Text = "Telefonos  :"
        '
        'TelclienteTB
        '
        Me.TelclienteTB.Enabled = False
        Me.TelclienteTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelclienteTB.Location = New System.Drawing.Point(340, 87)
        Me.TelclienteTB.Name = "TelclienteTB"
        Me.TelclienteTB.Size = New System.Drawing.Size(197, 22)
        Me.TelclienteTB.TabIndex = 15
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TelclienteTB)
        Me.GroupBox2.Controls.Add(Me.TelefonoClienteLbl)
        Me.GroupBox2.Controls.Add(Me.DireccionClienteTB)
        Me.GroupBox2.Controls.Add(Me.DireccionClieLbl)
        Me.GroupBox2.Controls.Add(Me.IrBtn)
        Me.GroupBox2.Controls.Add(Me.BuscarBtn)
        Me.GroupBox2.Controls.Add(Me.NuevoBtn)
        Me.GroupBox2.Controls.Add(Me.IdentificacionClienteTB)
        Me.GroupBox2.Controls.Add(Me.IdentificacionClienteLbl)
        Me.GroupBox2.Controls.Add(Me.NomClienteTB)
        Me.GroupBox2.Controls.Add(Me.NomClienteLbl)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(12, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(625, 125)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información del Cliente"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TotalTB)
        Me.GroupBox4.Controls.Add(Me.ivaTB)
        Me.GroupBox4.Controls.Add(Me.subtotalTB)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(438, 483)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(199, 93)
        Me.GroupBox4.TabIndex = 17
        Me.GroupBox4.TabStop = False
        '
        'TotalTB
        '
        Me.TotalTB.Enabled = False
        Me.TotalTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalTB.Location = New System.Drawing.Point(103, 64)
        Me.TotalTB.Name = "TotalTB"
        Me.TotalTB.Size = New System.Drawing.Size(86, 22)
        Me.TotalTB.TabIndex = 31
        '
        'ivaTB
        '
        Me.ivaTB.Enabled = False
        Me.ivaTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ivaTB.Location = New System.Drawing.Point(103, 37)
        Me.ivaTB.Name = "ivaTB"
        Me.ivaTB.Size = New System.Drawing.Size(86, 22)
        Me.ivaTB.TabIndex = 30
        '
        'subtotalTB
        '
        Me.subtotalTB.Enabled = False
        Me.subtotalTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.subtotalTB.Location = New System.Drawing.Point(103, 12)
        Me.subtotalTB.Name = "subtotalTB"
        Me.subtotalTB.Size = New System.Drawing.Size(86, 22)
        Me.subtotalTB.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(9, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "Total           ($)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(6, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "IVA              ($)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(5, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sub Total  ($)"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label12)
        Me.GroupBox5.Controls.Add(Me.VendedorCB)
        Me.GroupBox5.Controls.Add(Me.VendedorLbl)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 483)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(409, 46)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label12.Location = New System.Drawing.Point(6, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 14)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "Cedula :"
        Me.Label12.Visible = False
        '
        'VendedorCB
        '
        Me.VendedorCB.DataSource = Me.EmpleadosBindingSource
        Me.VendedorCB.DisplayMember = "NomEmp"
        Me.VendedorCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendedorCB.FormattingEnabled = True
        Me.VendedorCB.Location = New System.Drawing.Point(81, 14)
        Me.VendedorCB.Name = "VendedorCB"
        Me.VendedorCB.Size = New System.Drawing.Size(310, 23)
        Me.VendedorCB.TabIndex = 30
        Me.VendedorCB.ValueMember = "IdEmp"
        '
        'VendedorLbl
        '
        Me.VendedorLbl.AutoSize = True
        Me.VendedorLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VendedorLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.VendedorLbl.Location = New System.Drawing.Point(2, 17)
        Me.VendedorLbl.Name = "VendedorLbl"
        Me.VendedorLbl.Size = New System.Drawing.Size(74, 14)
        Me.VendedorLbl.TabIndex = 29
        Me.VendedorLbl.Text = "Vendedor:"
        '
        'FormadePagoCB
        '
        Me.FormadePagoCB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormadePagoCB.FormattingEnabled = True
        Me.FormadePagoCB.Items.AddRange(New Object() {"CONTADO", "CREDITO"})
        Me.FormadePagoCB.Location = New System.Drawing.Point(117, 12)
        Me.FormadePagoCB.Name = "FormadePagoCB"
        Me.FormadePagoCB.Size = New System.Drawing.Size(112, 23)
        Me.FormadePagoCB.TabIndex = 31
        '
        'FormadepagoLbl
        '
        Me.FormadepagoLbl.AutoSize = True
        Me.FormadepagoLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormadepagoLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FormadepagoLbl.Location = New System.Drawing.Point(6, 17)
        Me.FormadepagoLbl.Name = "FormadepagoLbl"
        Me.FormadepagoLbl.Size = New System.Drawing.Size(105, 14)
        Me.FormadepagoLbl.TabIndex = 29
        Me.FormadepagoLbl.Text = "Forma de Pago:"
        '
        'AccionesGB
        '
        Me.AccionesGB.Controls.Add(Me.SalirBtn)
        Me.AccionesGB.Controls.Add(Me.CancelarBtn)
        Me.AccionesGB.Controls.Add(Me.GuardarBtn)
        Me.AccionesGB.Location = New System.Drawing.Point(438, 576)
        Me.AccionesGB.Name = "AccionesGB"
        Me.AccionesGB.Size = New System.Drawing.Size(199, 61)
        Me.AccionesGB.TabIndex = 32
        Me.AccionesGB.TabStop = False
        '
        'SalirBtn
        '
        Me.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SalirBtn.FlatAppearance.BorderSize = 2
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(136, 12)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Size = New System.Drawing.Size(40, 43)
        Me.SalirBtn.TabIndex = 34
        Me.SalirBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelarBtn.FlatAppearance.BorderSize = 2
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.Location = New System.Drawing.Point(92, 12)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(40, 43)
        Me.CancelarBtn.TabIndex = 33
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GuardarBtn.Enabled = False
        Me.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GuardarBtn.FlatAppearance.BorderSize = 2
        Me.GuardarBtn.Image = CType(resources.GetObject("GuardarBtn.Image"), System.Drawing.Image)
        Me.GuardarBtn.Location = New System.Drawing.Point(6, 12)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(40, 43)
        Me.GuardarBtn.TabIndex = 33
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
        Me.TableAdapterManager.DxCTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.LineaFacturaTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'AgaciaBDDataSet1
        '
        Me.AgaciaBDDataSet1.DataSetName = "AgaciaBDDataSet1"
        Me.AgaciaBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.ClientesTableAdapter = Nothing
        Me.TableAdapterManager1.DxCTableAdapter = Nothing
        Me.TableAdapterManager1.FacturasTableAdapter = Nothing
        Me.TableAdapterManager1.LineaFacturaTableAdapter = Nothing
        Me.TableAdapterManager1.PedidosTableAdapter = Nothing
        Me.TableAdapterManager1.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager1.UpdateOrder = AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.AgaciaBDDataSet11
        '
        'AgaciaBDDataSet11
        '
        Me.AgaciaBDDataSet11.DataSetName = "AgaciaBDDataSet1"
        Me.AgaciaBDDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FacturasBindingSource1
        '
        Me.FacturasBindingSource1.DataMember = "Facturas"
        Me.FacturasBindingSource1.DataSource = Me.AgaciaBDDataSet1
        '
        'CuentafacturasTableAdapter
        '
        Me.CuentafacturasTableAdapter.ClearBeforeFill = True
        '
        'CuentafacturasBindingSource
        '
        Me.CuentafacturasBindingSource.DataMember = "Cuentafacturas"
        Me.CuentafacturasBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'BucaexistprodTableAdapter
        '
        Me.BucaexistprodTableAdapter.ClearBeforeFill = True
        '
        'BucaexistprodBindingSource
        '
        Me.BucaexistprodBindingSource.DataMember = "bucaexistprod"
        Me.BucaexistprodBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager2
        '
        Me.TableAdapterManager2.BackupDataSetBeforeUpdate = False
        ' = Nothing
        Me.TableAdapterManager2.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager2.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager2.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager2.UpdateOrder = AgaciaSolution.AgaciaBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.FormadePagoCB)
        Me.GroupBox6.Controls.Add(Me.FormadepagoLbl)
        Me.GroupBox6.Location = New System.Drawing.Point(12, 535)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(406, 41)
        Me.GroupBox6.TabIndex = 33
        Me.GroupBox6.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(126, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 34
        Me.PictureBox1.TabStop = False
        '
        'FacturarBtn
        '
        Me.FacturarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FacturarBtn.Enabled = False
        Me.FacturarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FacturarBtn.FlatAppearance.BorderSize = 2
        Me.FacturarBtn.Image = CType(resources.GetObject("FacturarBtn.Image"), System.Drawing.Image)
        Me.FacturarBtn.Location = New System.Drawing.Point(487, 588)
        Me.FacturarBtn.Name = "FacturarBtn"
        Me.FacturarBtn.Size = New System.Drawing.Size(40, 43)
        Me.FacturarBtn.TabIndex = 38
        Me.FacturarBtn.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(651, 637)
        Me.Controls.Add(Me.FacturarBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.AccionesGB)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de Ventas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgaciaBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.AccionesGB.ResumeLayout(False)
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgaciaBDDataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CuentafacturasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BucaexistprodBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents BuscarProductoBtn As System.Windows.Forms.Button
    Friend WithEvents CodProdTB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NomProdTB As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ExistenciaTB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CantidadProTB As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents VrUnitTB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NomClienteLbl As System.Windows.Forms.Label
    Friend WithEvents NomClienteTB As System.Windows.Forms.TextBox
    Friend WithEvents IdentificacionClienteLbl As System.Windows.Forms.Label
    Friend WithEvents IdentificacionClienteTB As System.Windows.Forms.TextBox
    Friend WithEvents NuevoBtn As System.Windows.Forms.Button
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents IrBtn As System.Windows.Forms.Button
    Friend WithEvents DireccionClieLbl As System.Windows.Forms.Label
    Friend WithEvents DireccionClienteTB As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoClienteLbl As System.Windows.Forms.Label
    Friend WithEvents TelclienteTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents subtotalTB As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TotalTB As System.Windows.Forms.TextBox
    Friend WithEvents ivaTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents VendedorLbl As System.Windows.Forms.Label
    Friend WithEvents FormadepagoLbl As System.Windows.Forms.Label
    Friend WithEvents VendedorCB As System.Windows.Forms.ComboBox
    Friend WithEvents FormadePagoCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents AccionesGB As System.Windows.Forms.GroupBox
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents SalirBtn As System.Windows.Forms.Button
    Friend WithEvents TableAdapterManager As AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ClientesTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.ClientesTableAdapter
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgaciaBDDataSet1 As AgaciaSolution.AgaciaBDDataSet1
    Friend WithEvents ProductosTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager1 As AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgaciaBDDataSet11 As AgaciaSolution.AgaciaBDDataSet1
    Friend WithEvents FacturasBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents IdfactTB As System.Windows.Forms.TextBox
    Friend WithEvents CuentafacturasTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.CuentafacturasTableAdapter
    Friend WithEvents CuentafacturasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BucaexistprodTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.bucaexistprodTableAdapter
    Friend WithEvents BucaexistprodBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents AgaciaBDDataSet As AgaciaSolution.AgaciaBDDataSet
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As AgaciaSolution.AgaciaBDDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents IdEmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TableAdapterManager2 As AgaciaSolution.AgaciaBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModificarCantidadToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents FacturarBtn As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn

    
End Class
