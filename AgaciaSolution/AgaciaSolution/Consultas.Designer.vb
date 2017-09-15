<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consultas
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView4 = New System.Windows.Forms.DataGridView
        Me.IdentificaciónDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DirecciónDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TeléfonosDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CiudadDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ContactoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ListarProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ConsultasDS = New AgaciaSolution.ConsultasDS
        Me.DataGridView2 = New System.Windows.Forms.DataGridView
        Me.IdentificaciónDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DirecciónDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TeléfonoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CiudadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActivoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ListarClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView3 = New System.Windows.Forms.DataGridView
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.VrUnitarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.StockMínimoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ExistenciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SerialDelProductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ListarProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.IdentificaciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DirecciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TeléfonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SalarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FechaDeIngresoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SexoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ActivoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.ListarEmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoDeEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoDeClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoDeProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListadoDeProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListarClientesTableAdapter = New AgaciaSolution.ConsultasDSTableAdapters.ListarClientesTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.ConsultasDSTableAdapters.TableAdapterManager
        Me.ListarEmpleadosTableAdapter = New AgaciaSolution.ConsultasDSTableAdapters.ListarEmpleadosTableAdapter
        Me.ListarProductosTableAdapter = New AgaciaSolution.ConsultasDSTableAdapters.ListarProductosTableAdapter
        Me.ListarProveedoresTableAdapter = New AgaciaSolution.ConsultasDSTableAdapters.ListarProveedoresTableAdapter
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListarProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultasDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListarClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListarProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ListarEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView4)
        Me.GroupBox2.Controls.Add(Me.DataGridView2)
        Me.GroupBox2.Controls.Add(Me.DataGridView3)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(16, 135)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(668, 326)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados"
        '
        'DataGridView4
        '
        Me.DataGridView4.AllowUserToAddRows = False
        Me.DataGridView4.AllowUserToDeleteRows = False
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Linen
        Me.DataGridView4.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView4.AutoGenerateColumns = False
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificaciónDataGridViewTextBoxColumn2, Me.NombreDataGridViewTextBoxColumn3, Me.DirecciónDataGridViewTextBoxColumn2, Me.TeléfonosDataGridViewTextBoxColumn, Me.CiudadDataGridViewTextBoxColumn1, Me.ContactoDataGridViewTextBoxColumn})
        Me.DataGridView4.DataSource = Me.ListarProveedoresBindingSource
        Me.DataGridView4.Location = New System.Drawing.Point(18, 26)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.ReadOnly = True
        Me.DataGridView4.Size = New System.Drawing.Size(629, 294)
        Me.DataGridView4.TabIndex = 9
        Me.DataGridView4.Visible = False
        '
        'IdentificaciónDataGridViewTextBoxColumn2
        '
        Me.IdentificaciónDataGridViewTextBoxColumn2.DataPropertyName = "Identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn2.HeaderText = "Identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn2.Name = "IdentificaciónDataGridViewTextBoxColumn2"
        Me.IdentificaciónDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn3
        '
        Me.NombreDataGridViewTextBoxColumn3.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn3.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn3.Name = "NombreDataGridViewTextBoxColumn3"
        Me.NombreDataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DirecciónDataGridViewTextBoxColumn2
        '
        Me.DirecciónDataGridViewTextBoxColumn2.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn2.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn2.Name = "DirecciónDataGridViewTextBoxColumn2"
        Me.DirecciónDataGridViewTextBoxColumn2.ReadOnly = True
        '
        'TeléfonosDataGridViewTextBoxColumn
        '
        Me.TeléfonosDataGridViewTextBoxColumn.DataPropertyName = "Teléfonos"
        Me.TeléfonosDataGridViewTextBoxColumn.HeaderText = "Teléfonos"
        Me.TeléfonosDataGridViewTextBoxColumn.Name = "TeléfonosDataGridViewTextBoxColumn"
        Me.TeléfonosDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CiudadDataGridViewTextBoxColumn1
        '
        Me.CiudadDataGridViewTextBoxColumn1.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn1.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn1.Name = "CiudadDataGridViewTextBoxColumn1"
        Me.CiudadDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ContactoDataGridViewTextBoxColumn
        '
        Me.ContactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto"
        Me.ContactoDataGridViewTextBoxColumn.HeaderText = "Contacto"
        Me.ContactoDataGridViewTextBoxColumn.Name = "ContactoDataGridViewTextBoxColumn"
        Me.ContactoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ListarProveedoresBindingSource
        '
        Me.ListarProveedoresBindingSource.DataMember = "ListarProveedores"
        Me.ListarProveedoresBindingSource.DataSource = Me.ConsultasDS
        '
        'ConsultasDS
        '
        Me.ConsultasDS.DataSetName = "ConsultasDS"
        Me.ConsultasDS.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificaciónDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn1, Me.DirecciónDataGridViewTextBoxColumn1, Me.TeléfonoDataGridViewTextBoxColumn1, Me.EmailDataGridViewTextBoxColumn1, Me.CiudadDataGridViewTextBoxColumn, Me.ActivoDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.ListarClientesBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(18, 26)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(629, 294)
        Me.DataGridView2.TabIndex = 7
        Me.DataGridView2.Visible = False
        '
        'IdentificaciónDataGridViewTextBoxColumn1
        '
        Me.IdentificaciónDataGridViewTextBoxColumn1.DataPropertyName = "Identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn1.HeaderText = "Identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn1.Name = "IdentificaciónDataGridViewTextBoxColumn1"
        '
        'NombreDataGridViewTextBoxColumn1
        '
        Me.NombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn1.Name = "NombreDataGridViewTextBoxColumn1"
        '
        'DirecciónDataGridViewTextBoxColumn1
        '
        Me.DirecciónDataGridViewTextBoxColumn1.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn1.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn1.Name = "DirecciónDataGridViewTextBoxColumn1"
        '
        'TeléfonoDataGridViewTextBoxColumn1
        '
        Me.TeléfonoDataGridViewTextBoxColumn1.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn1.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn1.Name = "TeléfonoDataGridViewTextBoxColumn1"
        '
        'EmailDataGridViewTextBoxColumn1
        '
        Me.EmailDataGridViewTextBoxColumn1.DataPropertyName = "E-mail"
        Me.EmailDataGridViewTextBoxColumn1.HeaderText = "E-mail"
        Me.EmailDataGridViewTextBoxColumn1.Name = "EmailDataGridViewTextBoxColumn1"
        '
        'CiudadDataGridViewTextBoxColumn
        '
        Me.CiudadDataGridViewTextBoxColumn.DataPropertyName = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.HeaderText = "Ciudad"
        Me.CiudadDataGridViewTextBoxColumn.Name = "CiudadDataGridViewTextBoxColumn"
        '
        'ActivoDataGridViewTextBoxColumn1
        '
        Me.ActivoDataGridViewTextBoxColumn1.DataPropertyName = "Activo"
        Me.ActivoDataGridViewTextBoxColumn1.HeaderText = "Activo"
        Me.ActivoDataGridViewTextBoxColumn1.Name = "ActivoDataGridViewTextBoxColumn1"
        '
        'ListarClientesBindingSource
        '
        Me.ListarClientesBindingSource.DataMember = "ListarClientes"
        Me.ListarClientesBindingSource.DataSource = Me.ConsultasDS
        '
        'DataGridView3
        '
        Me.DataGridView3.AutoGenerateColumns = False
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn2, Me.VrUnitarioDataGridViewTextBoxColumn, Me.StockMínimoDataGridViewTextBoxColumn, Me.DescripciónDataGridViewTextBoxColumn, Me.ExistenciaDataGridViewTextBoxColumn, Me.SerialDelProductoDataGridViewTextBoxColumn})
        Me.DataGridView3.DataSource = Me.ListarProductosBindingSource
        Me.DataGridView3.Location = New System.Drawing.Point(18, 26)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(629, 294)
        Me.DataGridView3.TabIndex = 8
        Me.DataGridView3.Visible = False
        '
        'CódigoDataGridViewTextBoxColumn
        '
        Me.CódigoDataGridViewTextBoxColumn.DataPropertyName = "Código"
        Me.CódigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CódigoDataGridViewTextBoxColumn.Name = "CódigoDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn2
        '
        Me.NombreDataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn2.Name = "NombreDataGridViewTextBoxColumn2"
        '
        'VrUnitarioDataGridViewTextBoxColumn
        '
        Me.VrUnitarioDataGridViewTextBoxColumn.DataPropertyName = "Vr Unitario"
        Me.VrUnitarioDataGridViewTextBoxColumn.HeaderText = "Vr Unitario"
        Me.VrUnitarioDataGridViewTextBoxColumn.Name = "VrUnitarioDataGridViewTextBoxColumn"
        '
        'StockMínimoDataGridViewTextBoxColumn
        '
        Me.StockMínimoDataGridViewTextBoxColumn.DataPropertyName = "Stock mínimo"
        Me.StockMínimoDataGridViewTextBoxColumn.HeaderText = "Stock mínimo"
        Me.StockMínimoDataGridViewTextBoxColumn.Name = "StockMínimoDataGridViewTextBoxColumn"
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Descripción"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        '
        'ExistenciaDataGridViewTextBoxColumn
        '
        Me.ExistenciaDataGridViewTextBoxColumn.DataPropertyName = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.HeaderText = "Existencia"
        Me.ExistenciaDataGridViewTextBoxColumn.Name = "ExistenciaDataGridViewTextBoxColumn"
        '
        'SerialDelProductoDataGridViewTextBoxColumn
        '
        Me.SerialDelProductoDataGridViewTextBoxColumn.DataPropertyName = "Serial del producto"
        Me.SerialDelProductoDataGridViewTextBoxColumn.HeaderText = "Serial del producto"
        Me.SerialDelProductoDataGridViewTextBoxColumn.Name = "SerialDelProductoDataGridViewTextBoxColumn"
        '
        'ListarProductosBindingSource
        '
        Me.ListarProductosBindingSource.DataMember = "ListarProductos"
        Me.ListarProductosBindingSource.DataSource = Me.ConsultasDS
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdentificaciónDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DirecciónDataGridViewTextBoxColumn, Me.TeléfonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.SalarioDataGridViewTextBoxColumn, Me.FechaDeIngresoDataGridViewTextBoxColumn, Me.SexoDataGridViewTextBoxColumn, Me.ActivoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ListarEmpleadosBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(18, 26)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(629, 294)
        Me.DataGridView1.TabIndex = 0
        Me.DataGridView1.Visible = False
        '
        'IdentificaciónDataGridViewTextBoxColumn
        '
        Me.IdentificaciónDataGridViewTextBoxColumn.DataPropertyName = "identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn.HeaderText = "identificación"
        Me.IdentificaciónDataGridViewTextBoxColumn.Name = "IdentificaciónDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'DirecciónDataGridViewTextBoxColumn
        '
        Me.DirecciónDataGridViewTextBoxColumn.DataPropertyName = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DirecciónDataGridViewTextBoxColumn.Name = "DirecciónDataGridViewTextBoxColumn"
        '
        'TeléfonoDataGridViewTextBoxColumn
        '
        Me.TeléfonoDataGridViewTextBoxColumn.DataPropertyName = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.HeaderText = "Teléfono"
        Me.TeléfonoDataGridViewTextBoxColumn.Name = "TeléfonoDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "E-mail"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'SalarioDataGridViewTextBoxColumn
        '
        Me.SalarioDataGridViewTextBoxColumn.DataPropertyName = "Salario"
        Me.SalarioDataGridViewTextBoxColumn.HeaderText = "Salario"
        Me.SalarioDataGridViewTextBoxColumn.Name = "SalarioDataGridViewTextBoxColumn"
        '
        'FechaDeIngresoDataGridViewTextBoxColumn
        '
        Me.FechaDeIngresoDataGridViewTextBoxColumn.DataPropertyName = "Fecha de ingreso"
        Me.FechaDeIngresoDataGridViewTextBoxColumn.HeaderText = "Fecha de ingreso"
        Me.FechaDeIngresoDataGridViewTextBoxColumn.Name = "FechaDeIngresoDataGridViewTextBoxColumn"
        '
        'SexoDataGridViewTextBoxColumn
        '
        Me.SexoDataGridViewTextBoxColumn.DataPropertyName = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.HeaderText = "Sexo"
        Me.SexoDataGridViewTextBoxColumn.Name = "SexoDataGridViewTextBoxColumn"
        '
        'ActivoDataGridViewTextBoxColumn
        '
        Me.ActivoDataGridViewTextBoxColumn.DataPropertyName = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.HeaderText = "Activo"
        Me.ActivoDataGridViewTextBoxColumn.Name = "ActivoDataGridViewTextBoxColumn"
        '
        'ListarEmpleadosBindingSource
        '
        Me.ListarEmpleadosBindingSource.DataMember = "ListarEmpleados"
        Me.ListarEmpleadosBindingSource.DataSource = Me.ConsultasDS
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultasToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(696, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListadoDeEmpleadosToolStripMenuItem, Me.ListadoDeClientesToolStripMenuItem, Me.ListadoDeProductosToolStripMenuItem, Me.ListadoDeProveedoresToolStripMenuItem})
        Me.ConsultasToolStripMenuItem.Image = Global.AgaciaSolution.My.Resources.Resources.images
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.ConsultasToolStripMenuItem.Text = "Peticiones"
        '
        'ListadoDeEmpleadosToolStripMenuItem
        '
        Me.ListadoDeEmpleadosToolStripMenuItem.Name = "ListadoDeEmpleadosToolStripMenuItem"
        Me.ListadoDeEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ListadoDeEmpleadosToolStripMenuItem.Text = "Listado de Empleados"
        '
        'ListadoDeClientesToolStripMenuItem
        '
        Me.ListadoDeClientesToolStripMenuItem.Name = "ListadoDeClientesToolStripMenuItem"
        Me.ListadoDeClientesToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ListadoDeClientesToolStripMenuItem.Text = "Listado de Clientes"
        '
        'ListadoDeProductosToolStripMenuItem
        '
        Me.ListadoDeProductosToolStripMenuItem.Name = "ListadoDeProductosToolStripMenuItem"
        Me.ListadoDeProductosToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ListadoDeProductosToolStripMenuItem.Text = "Listado de Productos"
        '
        'ListadoDeProveedoresToolStripMenuItem
        '
        Me.ListadoDeProveedoresToolStripMenuItem.Name = "ListadoDeProveedoresToolStripMenuItem"
        Me.ListadoDeProveedoresToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ListadoDeProveedoresToolStripMenuItem.Text = "Listado de proveedores"
        '
        'ListarClientesTableAdapter
        '
        Me.ListarClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = AgaciaSolution.ConsultasDSTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ListarEmpleadosTableAdapter
        '
        Me.ListarEmpleadosTableAdapter.ClearBeforeFill = True
        '
        'ListarProductosTableAdapter
        '
        Me.ListarProductosTableAdapter.ClearBeforeFill = True
        '
        'ListarProveedoresTableAdapter
        '
        Me.ListarProveedoresTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(178, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 33)
        Me.Label1.TabIndex = 7
        '
        'Consultas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(696, 484)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Consultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consultas"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListarProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultasDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListarClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListarProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ListarEmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ConsultasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeEmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListadoDeProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasDS As AgaciaSolution.ConsultasDS
    Friend WithEvents ListarClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListarClientesTableAdapter As AgaciaSolution.ConsultasDSTableAdapters.ListarClientesTableAdapter
    Friend WithEvents TableAdapterManager As AgaciaSolution.ConsultasDSTableAdapters.TableAdapterManager
    Friend WithEvents ListarEmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListarEmpleadosTableAdapter As AgaciaSolution.ConsultasDSTableAdapters.ListarEmpleadosTableAdapter
    Friend WithEvents ListarProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListarProductosTableAdapter As AgaciaSolution.ConsultasDSTableAdapters.ListarProductosTableAdapter
    Friend WithEvents ListarProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ListarProveedoresTableAdapter As AgaciaSolution.ConsultasDSTableAdapters.ListarProveedoresTableAdapter
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents IdentificaciónDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdentificaciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeléfonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechaDeIngresoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ActivoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents IdentificaciónDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DirecciónDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TeléfonosDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CiudadDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CódigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VrUnitarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockMínimoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ExistenciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SerialDelProductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
