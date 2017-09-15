<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Productos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Productos))
        Me.BotonesGB = New System.Windows.Forms.GroupBox
        Me.SalirBtn = New System.Windows.Forms.Button
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.NuevoBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        Me.EditarBtn = New System.Windows.Forms.Button
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.InforGB = New System.Windows.Forms.GroupBox
        Me.ValorProductoLbl = New System.Windows.Forms.Label
        Me.CantProdTextBox = New System.Windows.Forms.TextBox
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasicoDs = New AgaciaSolution.BasicoDs
        Me.SerialTextBox = New System.Windows.Forms.TextBox
        Me.IdProdTextBox = New System.Windows.Forms.TextBox
        Me.NomProdTextBox = New System.Windows.Forms.TextBox
        Me.VrUnitProdTextBox = New System.Windows.Forms.TextBox
        Me.StockMinProdTextBox = New System.Windows.Forms.TextBox
        Me.DescripProdRichTextBox = New System.Windows.Forms.RichTextBox
        Me.SerialProductoLbl = New System.Windows.Forms.Label
        Me.DescripcionProducLbl = New System.Windows.Forms.Label
        Me.StockMinimoLbl = New System.Windows.Forms.Label
        Me.CantidadLbl = New System.Windows.Forms.Label
        Me.NomProductoLbl = New System.Windows.Forms.Label
        Me.IdProductoLbl = New System.Windows.Forms.Label
        Me.ClientesLbl = New System.Windows.Forms.Label
        Me.EmpleadoPB = New System.Windows.Forms.PictureBox
        Me.ProductosTableAdapter = New AgaciaSolution.BasicoDsTableAdapters.ProductosTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
        Me.ProductosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.BotonesGB.SuspendLayout()
        Me.InforGB.SuspendLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProductosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'BotonesGB
        '
        Me.BotonesGB.Controls.Add(Me.SalirBtn)
        Me.BotonesGB.Controls.Add(Me.BuscarBtn)
        Me.BotonesGB.Controls.Add(Me.CancelarBtn)
        Me.BotonesGB.Controls.Add(Me.NuevoBtn)
        Me.BotonesGB.Controls.Add(Me.EliminarBtn)
        Me.BotonesGB.Controls.Add(Me.EditarBtn)
        Me.BotonesGB.Controls.Add(Me.GuardarBtn)
        Me.BotonesGB.Location = New System.Drawing.Point(405, 108)
        Me.BotonesGB.Name = "BotonesGB"
        Me.BotonesGB.Size = New System.Drawing.Size(41, 271)
        Me.BotonesGB.TabIndex = 33
        Me.BotonesGB.TabStop = False
        '
        'SalirBtn
        '
        Me.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SalirBtn.FlatAppearance.BorderSize = 2
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(0, 226)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Size = New System.Drawing.Size(41, 43)
        Me.SalirBtn.TabIndex = 10
        Me.SalirBtn.UseVisualStyleBackColor = True
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuscarBtn.FlatAppearance.BorderSize = 2
        Me.BuscarBtn.Image = CType(resources.GetObject("BuscarBtn.Image"), System.Drawing.Image)
        Me.BuscarBtn.Location = New System.Drawing.Point(0, 191)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(41, 35)
        Me.BuscarBtn.TabIndex = 9
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelarBtn.Enabled = False
        Me.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelarBtn.FlatAppearance.BorderSize = 2
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.Location = New System.Drawing.Point(0, 154)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(41, 39)
        Me.CancelarBtn.TabIndex = 8
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'NuevoBtn
        '
        Me.NuevoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuevoBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NuevoBtn.FlatAppearance.BorderSize = 2
        Me.NuevoBtn.Image = CType(resources.GetObject("NuevoBtn.Image"), System.Drawing.Image)
        Me.NuevoBtn.Location = New System.Drawing.Point(0, 9)
        Me.NuevoBtn.Name = "NuevoBtn"
        Me.NuevoBtn.Size = New System.Drawing.Size(41, 37)
        Me.NuevoBtn.TabIndex = 6
        Me.NuevoBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EliminarBtn.Enabled = False
        Me.EliminarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.EliminarBtn.FlatAppearance.BorderSize = 2
        Me.EliminarBtn.Image = CType(resources.GetObject("EliminarBtn.Image"), System.Drawing.Image)
        Me.EliminarBtn.Location = New System.Drawing.Point(0, 81)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(41, 37)
        Me.EliminarBtn.TabIndex = 5
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'EditarBtn
        '
        Me.EditarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditarBtn.Enabled = False
        Me.EditarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.EditarBtn.FlatAppearance.BorderSize = 2
        Me.EditarBtn.Image = CType(resources.GetObject("EditarBtn.Image"), System.Drawing.Image)
        Me.EditarBtn.Location = New System.Drawing.Point(0, 46)
        Me.EditarBtn.Name = "EditarBtn"
        Me.EditarBtn.Size = New System.Drawing.Size(41, 34)
        Me.EditarBtn.TabIndex = 4
        Me.EditarBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GuardarBtn.Enabled = False
        Me.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GuardarBtn.FlatAppearance.BorderSize = 2
        Me.GuardarBtn.Image = CType(resources.GetObject("GuardarBtn.Image"), System.Drawing.Image)
        Me.GuardarBtn.Location = New System.Drawing.Point(0, 118)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(41, 36)
        Me.GuardarBtn.TabIndex = 3
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'InforGB
        '
        Me.InforGB.Controls.Add(Me.ValorProductoLbl)
        Me.InforGB.Controls.Add(Me.CantProdTextBox)
        Me.InforGB.Controls.Add(Me.SerialTextBox)
        Me.InforGB.Controls.Add(Me.IdProdTextBox)
        Me.InforGB.Controls.Add(Me.NomProdTextBox)
        Me.InforGB.Controls.Add(Me.VrUnitProdTextBox)
        Me.InforGB.Controls.Add(Me.StockMinProdTextBox)
        Me.InforGB.Controls.Add(Me.DescripProdRichTextBox)
        Me.InforGB.Controls.Add(Me.SerialProductoLbl)
        Me.InforGB.Controls.Add(Me.DescripcionProducLbl)
        Me.InforGB.Controls.Add(Me.StockMinimoLbl)
        Me.InforGB.Controls.Add(Me.CantidadLbl)
        Me.InforGB.Controls.Add(Me.NomProductoLbl)
        Me.InforGB.Controls.Add(Me.IdProductoLbl)
        Me.InforGB.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InforGB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InforGB.Location = New System.Drawing.Point(11, 111)
        Me.InforGB.Name = "InforGB"
        Me.InforGB.Size = New System.Drawing.Size(388, 223)
        Me.InforGB.TabIndex = 32
        Me.InforGB.TabStop = False
        Me.InforGB.Text = "Infomación Productos "
        '
        'ValorProductoLbl
        '
        Me.ValorProductoLbl.AutoSize = True
        Me.ValorProductoLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ValorProductoLbl.Location = New System.Drawing.Point(183, 117)
        Me.ValorProductoLbl.Name = "ValorProductoLbl"
        Me.ValorProductoLbl.Size = New System.Drawing.Size(78, 15)
        Me.ValorProductoLbl.TabIndex = 40
        Me.ValorProductoLbl.Text = "Vr Unitario:"
        '
        'CantProdTextBox
        '
        Me.CantProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "CantProd", True))
        Me.CantProdTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantProdTextBox.Location = New System.Drawing.Point(91, 85)
        Me.CantProdTextBox.Name = "CantProdTextBox"
        Me.CantProdTextBox.Size = New System.Drawing.Size(60, 22)
        Me.CantProdTextBox.TabIndex = 45
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.BasicoDs
        '
        'BasicoDs
        '
        Me.BasicoDs.DataSetName = "BasicoDs"
        Me.BasicoDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SerialTextBox
        '
        Me.SerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Serial", True))
        Me.SerialTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialTextBox.Location = New System.Drawing.Point(267, 85)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(100, 22)
        Me.SerialTextBox.TabIndex = 47
        '
        'IdProdTextBox
        '
        Me.IdProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "IdProd", True))
        Me.IdProdTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProdTextBox.Location = New System.Drawing.Point(91, 25)
        Me.IdProdTextBox.Name = "IdProdTextBox"
        Me.IdProdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.IdProdTextBox.TabIndex = 35
        '
        'NomProdTextBox
        '
        Me.NomProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "NomProd", True))
        Me.NomProdTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomProdTextBox.Location = New System.Drawing.Point(91, 53)
        Me.NomProdTextBox.Name = "NomProdTextBox"
        Me.NomProdTextBox.Size = New System.Drawing.Size(276, 22)
        Me.NomProdTextBox.TabIndex = 37
        '
        'VrUnitProdTextBox
        '
        Me.VrUnitProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "VrUnitProd", True))
        Me.VrUnitProdTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VrUnitProdTextBox.Location = New System.Drawing.Point(267, 115)
        Me.VrUnitProdTextBox.Name = "VrUnitProdTextBox"
        Me.VrUnitProdTextBox.Size = New System.Drawing.Size(100, 22)
        Me.VrUnitProdTextBox.TabIndex = 39
        '
        'StockMinProdTextBox
        '
        Me.StockMinProdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "StockMinProd", True))
        Me.StockMinProdTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockMinProdTextBox.Location = New System.Drawing.Point(91, 112)
        Me.StockMinProdTextBox.Name = "StockMinProdTextBox"
        Me.StockMinProdTextBox.Size = New System.Drawing.Size(60, 22)
        Me.StockMinProdTextBox.TabIndex = 41
        '
        'DescripProdRichTextBox
        '
        Me.DescripProdRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "DescripProd", True))
        Me.DescripProdRichTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripProdRichTextBox.Location = New System.Drawing.Point(91, 147)
        Me.DescripProdRichTextBox.Name = "DescripProdRichTextBox"
        Me.DescripProdRichTextBox.Size = New System.Drawing.Size(276, 57)
        Me.DescripProdRichTextBox.TabIndex = 43
        Me.DescripProdRichTextBox.Text = ""
        '
        'SerialProductoLbl
        '
        Me.SerialProductoLbl.AutoSize = True
        Me.SerialProductoLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialProductoLbl.Location = New System.Drawing.Point(183, 88)
        Me.SerialProductoLbl.Name = "SerialProductoLbl"
        Me.SerialProductoLbl.Size = New System.Drawing.Size(51, 15)
        Me.SerialProductoLbl.TabIndex = 39
        Me.SerialProductoLbl.Text = "Serial  :"
        '
        'DescripcionProducLbl
        '
        Me.DescripcionProducLbl.AutoSize = True
        Me.DescripcionProducLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DescripcionProducLbl.Location = New System.Drawing.Point(6, 147)
        Me.DescripcionProducLbl.Name = "DescripcionProducLbl"
        Me.DescripcionProducLbl.Size = New System.Drawing.Size(81, 15)
        Me.DescripcionProducLbl.TabIndex = 38
        Me.DescripcionProducLbl.Text = "Descripción :"
        '
        'StockMinimoLbl
        '
        Me.StockMinimoLbl.AutoSize = True
        Me.StockMinimoLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockMinimoLbl.Location = New System.Drawing.Point(6, 117)
        Me.StockMinimoLbl.Name = "StockMinimoLbl"
        Me.StockMinimoLbl.Size = New System.Drawing.Size(48, 15)
        Me.StockMinimoLbl.TabIndex = 37
        Me.StockMinimoLbl.Text = "Stock  :"
        '
        'CantidadLbl
        '
        Me.CantidadLbl.AutoSize = True
        Me.CantidadLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadLbl.Location = New System.Drawing.Point(6, 87)
        Me.CantidadLbl.Name = "CantidadLbl"
        Me.CantidadLbl.Size = New System.Drawing.Size(67, 15)
        Me.CantidadLbl.TabIndex = 36
        Me.CantidadLbl.Text = "Cantidad :"
        '
        'NomProductoLbl
        '
        Me.NomProductoLbl.AutoSize = True
        Me.NomProductoLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomProductoLbl.Location = New System.Drawing.Point(6, 58)
        Me.NomProductoLbl.Name = "NomProductoLbl"
        Me.NomProductoLbl.Size = New System.Drawing.Size(58, 15)
        Me.NomProductoLbl.TabIndex = 35
        Me.NomProductoLbl.Text = "Nombre:"
        '
        'IdProductoLbl
        '
        Me.IdProductoLbl.AutoSize = True
        Me.IdProductoLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProductoLbl.Location = New System.Drawing.Point(6, 27)
        Me.IdProductoLbl.Name = "IdProductoLbl"
        Me.IdProductoLbl.Size = New System.Drawing.Size(79, 15)
        Me.IdProductoLbl.TabIndex = 34
        Me.IdProductoLbl.Text = "Id Producto :"
        '
        'ClientesLbl
        '
        Me.ClientesLbl.AutoSize = True
        Me.ClientesLbl.Font = New System.Drawing.Font("Georgia", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.ClientesLbl.Location = New System.Drawing.Point(118, 35)
        Me.ClientesLbl.Name = "ClientesLbl"
        Me.ClientesLbl.Size = New System.Drawing.Size(268, 41)
        Me.ClientesLbl.TabIndex = 30
        Me.ClientesLbl.Text = "PRODUCTOS "
        '
        'EmpleadoPB
        '
        Me.EmpleadoPB.Location = New System.Drawing.Point(22, 21)
        Me.EmpleadoPB.Name = "EmpleadoPB"
        Me.EmpleadoPB.Size = New System.Drawing.Size(90, 73)
        Me.EmpleadoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpleadoPB.TabIndex = 31
        Me.EmpleadoPB.TabStop = False
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosDxCTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DxCTableAdapter = Nothing
        Me.TableAdapterManager.DxPTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.FuncionesTableAdapter = Nothing
        Me.TableAdapterManager.IngresosTableAdapter = Nothing
        Me.TableAdapterManager.LineaFacturaTableAdapter = Nothing
        Me.TableAdapterManager.LineaPedidosTableAdapter = Nothing
        Me.TableAdapterManager.LinIngresoTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.ROLxFUNCIONESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ProductosBindingNavigator
        '
        Me.ProductosBindingNavigator.AddNewItem = Nothing
        Me.ProductosBindingNavigator.BindingSource = Me.ProductosBindingSource
        Me.ProductosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProductosBindingNavigator.DeleteItem = Nothing
        Me.ProductosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ProductosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ProductosBindingNavigator.Location = New System.Drawing.Point(102, 352)
        Me.ProductosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProductosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProductosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProductosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProductosBindingNavigator.Name = "ProductosBindingNavigator"
        Me.ProductosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProductosBindingNavigator.Size = New System.Drawing.Size(211, 25)
        Me.ProductosBindingNavigator.TabIndex = 34
        Me.ProductosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Productos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(452, 385)
        Me.Controls.Add(Me.ProductosBindingNavigator)
        Me.Controls.Add(Me.BotonesGB)
        Me.Controls.Add(Me.InforGB)
        Me.Controls.Add(Me.EmpleadoPB)
        Me.Controls.Add(Me.ClientesLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Productos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Productos"
        Me.BotonesGB.ResumeLayout(False)
        Me.InforGB.ResumeLayout(False)
        Me.InforGB.PerformLayout()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProductosBindingNavigator.ResumeLayout(False)
        Me.ProductosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BotonesGB As System.Windows.Forms.GroupBox
    Friend WithEvents SalirBtn As System.Windows.Forms.Button
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents NuevoBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents EditarBtn As System.Windows.Forms.Button
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents InforGB As System.Windows.Forms.GroupBox
    Friend WithEvents ValorProductoLbl As System.Windows.Forms.Label
    Friend WithEvents SerialProductoLbl As System.Windows.Forms.Label
    Friend WithEvents DescripcionProducLbl As System.Windows.Forms.Label
    Friend WithEvents StockMinimoLbl As System.Windows.Forms.Label
    Friend WithEvents CantidadLbl As System.Windows.Forms.Label
    Friend WithEvents NomProductoLbl As System.Windows.Forms.Label
    Friend WithEvents IdProductoLbl As System.Windows.Forms.Label
    Friend WithEvents EmpleadoPB As System.Windows.Forms.PictureBox
    Friend WithEvents ClientesLbl As System.Windows.Forms.Label
    Friend WithEvents BasicoDs As AgaciaSolution.BasicoDs
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As AgaciaSolution.BasicoDsTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
    Friend WithEvents ProductosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents CantProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SerialTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents VrUnitProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents StockMinProdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescripProdRichTextBox As System.Windows.Forms.RichTextBox
End Class
