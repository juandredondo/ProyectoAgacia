<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
        Me.MenuStrip = New System.Windows.Forms.MenuStrip
        Me.DatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoIngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturasPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerTodosLosCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbonosDeCargosPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturasPorPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignarFacturaPorPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ListarFacturasPorPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.CuentasToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem1})
        Me.DatosToolStripMenuItem.Name = "DatosToolStripMenuItem"
        Me.DatosToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.DatosToolStripMenuItem.Text = "Datos"
        '
        'EmpresaToolStripMenuItem
        '
        Me.EmpresaToolStripMenuItem.Name = "EmpresaToolStripMenuItem"
        Me.EmpresaToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EmpresaToolStripMenuItem.Text = "Empresa"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProductosToolStripMenuItem.Text = "Productos"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoIngresoToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'NuevoIngresoToolStripMenuItem
        '
        Me.NuevoIngresoToolStripMenuItem.Name = "NuevoIngresoToolStripMenuItem"
        Me.NuevoIngresoToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NuevoIngresoToolStripMenuItem.Text = "Nuevo ingreso"
        '
        'CuentasToolStripMenuItem
        '
        Me.CuentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacturasPorCobrarToolStripMenuItem, Me.FacturasPorPagarToolStripMenuItem})
        Me.CuentasToolStripMenuItem.Name = "CuentasToolStripMenuItem"
        Me.CuentasToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.CuentasToolStripMenuItem.Text = "Cuentas"
        '
        'FacturasPorCobrarToolStripMenuItem
        '
        Me.FacturasPorCobrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerTodosLosCargosToolStripMenuItem, Me.AbonosDeCargosPorCobrarToolStripMenuItem})
        Me.FacturasPorCobrarToolStripMenuItem.Name = "FacturasPorCobrarToolStripMenuItem"
        Me.FacturasPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FacturasPorCobrarToolStripMenuItem.Text = "Facturas por cobrar"
        '
        'VerTodosLosCargosToolStripMenuItem
        '
        Me.VerTodosLosCargosToolStripMenuItem.Name = "VerTodosLosCargosToolStripMenuItem"
        Me.VerTodosLosCargosToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.VerTodosLosCargosToolStripMenuItem.Text = "Listar facturas por cobrar"
        '
        'AbonosDeCargosPorCobrarToolStripMenuItem
        '
        Me.AbonosDeCargosPorCobrarToolStripMenuItem.Name = "AbonosDeCargosPorCobrarToolStripMenuItem"
        Me.AbonosDeCargosPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(218, 22)
        Me.AbonosDeCargosPorCobrarToolStripMenuItem.Text = "Abonos facturas por cobrar"
        '
        'FacturasPorPagarToolStripMenuItem
        '
        Me.FacturasPorPagarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarFacturaPorPagarToolStripMenuItem, Me.ListarFacturasPorPagarToolStripMenuItem})
        Me.FacturasPorPagarToolStripMenuItem.Name = "FacturasPorPagarToolStripMenuItem"
        Me.FacturasPorPagarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FacturasPorPagarToolStripMenuItem.Text = "Facturas por pagar"
        '
        'AsignarFacturaPorPagarToolStripMenuItem
        '
        Me.AsignarFacturaPorPagarToolStripMenuItem.Name = "AsignarFacturaPorPagarToolStripMenuItem"
        Me.AsignarFacturaPorPagarToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.AsignarFacturaPorPagarToolStripMenuItem.Text = "Asignar factura por pagar"
        '
        'ListarFacturasPorPagarToolStripMenuItem
        '
        Me.ListarFacturasPorPagarToolStripMenuItem.Name = "ListarFacturasPorPagarToolStripMenuItem"
        Me.ListarFacturasPorPagarToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ListarFacturasPorPagarToolStripMenuItem.Text = "Listar facturas por pagar"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(632, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 49)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(223, 458)
        Me.Panel1.TabIndex = 10
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 332)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(193, 123)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(184, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.TabStop = False
        Me.Button1.Text = "Nueva Venta"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(3, 38)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(184, 29)
        Me.Button4.TabIndex = 3
        Me.Button4.TabStop = False
        Me.Button4.Text = "Nuevo Pedido"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 73)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.TabStop = False
        Me.Button2.Text = "Consultas"
        Me.Button2.UseVisualStyleBackColor = False
        Me.Button2.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 507)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "Agacia V 1.0"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoIngresoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasPorCobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerTodosLosCargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbonosDeCargosPorCobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasPorPagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents EmpleadosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarFacturaPorPagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListarFacturasPorPagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
