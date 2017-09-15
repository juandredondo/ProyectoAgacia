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
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoIngresoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ControlDeInventarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TodosLosMovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovimientosEntreFechasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SaldosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CuentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturasPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AsignarCargoPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VerTodosLosCargosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AbonosDeCargosPorCobrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacturasPorPagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministrarCuentasDeUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuevoUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistrarRolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RegistarFuncionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RolesPorFunciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ÍndiceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatosToolStripMenuItem, Me.InventarioToolStripMenuItem, Me.CuentasToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'DatosToolStripMenuItem
        '
        Me.DatosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpresaToolStripMenuItem, Me.ProductosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.EmpleadosToolStripMenuItem})
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
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'InventarioToolStripMenuItem
        '
        Me.InventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoIngresoToolStripMenuItem, Me.ControlDeInventarioToolStripMenuItem})
        Me.InventarioToolStripMenuItem.Name = "InventarioToolStripMenuItem"
        Me.InventarioToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.InventarioToolStripMenuItem.Text = "Inventario"
        '
        'NuevoIngresoToolStripMenuItem
        '
        Me.NuevoIngresoToolStripMenuItem.Name = "NuevoIngresoToolStripMenuItem"
        Me.NuevoIngresoToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.NuevoIngresoToolStripMenuItem.Text = "Nuevo ingreso"
        '
        'ControlDeInventarioToolStripMenuItem
        '
        Me.ControlDeInventarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosLosMovimientosToolStripMenuItem, Me.MovimientosEntreFechasToolStripMenuItem, Me.SaldosToolStripMenuItem})
        Me.ControlDeInventarioToolStripMenuItem.Name = "ControlDeInventarioToolStripMenuItem"
        Me.ControlDeInventarioToolStripMenuItem.Size = New System.Drawing.Size(186, 22)
        Me.ControlDeInventarioToolStripMenuItem.Text = "Control de Inventario"
        '
        'TodosLosMovimientosToolStripMenuItem
        '
        Me.TodosLosMovimientosToolStripMenuItem.Name = "TodosLosMovimientosToolStripMenuItem"
        Me.TodosLosMovimientosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.TodosLosMovimientosToolStripMenuItem.Text = "Todos los movimientos"
        '
        'MovimientosEntreFechasToolStripMenuItem
        '
        Me.MovimientosEntreFechasToolStripMenuItem.Name = "MovimientosEntreFechasToolStripMenuItem"
        Me.MovimientosEntreFechasToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.MovimientosEntreFechasToolStripMenuItem.Text = "Movimientos entre fechas"
        '
        'SaldosToolStripMenuItem
        '
        Me.SaldosToolStripMenuItem.Name = "SaldosToolStripMenuItem"
        Me.SaldosToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SaldosToolStripMenuItem.Text = "Saldos"
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
        Me.FacturasPorCobrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AsignarCargoPorCobrarToolStripMenuItem, Me.VerTodosLosCargosToolStripMenuItem, Me.AbonosDeCargosPorCobrarToolStripMenuItem})
        Me.FacturasPorCobrarToolStripMenuItem.Name = "FacturasPorCobrarToolStripMenuItem"
        Me.FacturasPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FacturasPorCobrarToolStripMenuItem.Text = "Facturas por cobrar"
        '
        'AsignarCargoPorCobrarToolStripMenuItem
        '
        Me.AsignarCargoPorCobrarToolStripMenuItem.Name = "AsignarCargoPorCobrarToolStripMenuItem"
        Me.AsignarCargoPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AsignarCargoPorCobrarToolStripMenuItem.Text = "Asignar cargo por cobrar"
        '
        'VerTodosLosCargosToolStripMenuItem
        '
        Me.VerTodosLosCargosToolStripMenuItem.Name = "VerTodosLosCargosToolStripMenuItem"
        Me.VerTodosLosCargosToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.VerTodosLosCargosToolStripMenuItem.Text = "Ver todos los cargos"
        '
        'AbonosDeCargosPorCobrarToolStripMenuItem
        '
        Me.AbonosDeCargosPorCobrarToolStripMenuItem.Name = "AbonosDeCargosPorCobrarToolStripMenuItem"
        Me.AbonosDeCargosPorCobrarToolStripMenuItem.Size = New System.Drawing.Size(227, 22)
        Me.AbonosDeCargosPorCobrarToolStripMenuItem.Text = "Abonos de cargos por cobrar"
        '
        'FacturasPorPagarToolStripMenuItem
        '
        Me.FacturasPorPagarToolStripMenuItem.Name = "FacturasPorPagarToolStripMenuItem"
        Me.FacturasPorPagarToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.FacturasPorPagarToolStripMenuItem.Text = "|"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdministrarCuentasDeUsuarioToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'AdministrarCuentasDeUsuarioToolStripMenuItem
        '
        Me.AdministrarCuentasDeUsuarioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoUsuarioToolStripMenuItem, Me.RegistrarRolesToolStripMenuItem, Me.RegistarFuncionesToolStripMenuItem, Me.RolesPorFunciónToolStripMenuItem})
        Me.AdministrarCuentasDeUsuarioToolStripMenuItem.Name = "AdministrarCuentasDeUsuarioToolStripMenuItem"
        Me.AdministrarCuentasDeUsuarioToolStripMenuItem.Size = New System.Drawing.Size(238, 22)
        Me.AdministrarCuentasDeUsuarioToolStripMenuItem.Text = "Administrar cuentas de usuario"
        '
        'NuevoUsuarioToolStripMenuItem
        '
        Me.NuevoUsuarioToolStripMenuItem.Name = "NuevoUsuarioToolStripMenuItem"
        Me.NuevoUsuarioToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.NuevoUsuarioToolStripMenuItem.Text = "Nuevo Usuario"
        '
        'RegistrarRolesToolStripMenuItem
        '
        Me.RegistrarRolesToolStripMenuItem.Name = "RegistrarRolesToolStripMenuItem"
        Me.RegistrarRolesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RegistrarRolesToolStripMenuItem.Text = "Registrar roles"
        '
        'RegistarFuncionesToolStripMenuItem
        '
        Me.RegistarFuncionesToolStripMenuItem.Name = "RegistarFuncionesToolStripMenuItem"
        Me.RegistarFuncionesToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RegistarFuncionesToolStripMenuItem.Text = "Registar Funciones"
        '
        'RolesPorFunciónToolStripMenuItem
        '
        Me.RolesPorFunciónToolStripMenuItem.Name = "RolesPorFunciónToolStripMenuItem"
        Me.RolesPorFunciónToolStripMenuItem.Size = New System.Drawing.Size(173, 22)
        Me.RolesPorFunciónToolStripMenuItem.Text = "Roles por función"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ÍndiceToolStripMenuItem, Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'ÍndiceToolStripMenuItem
        '
        Me.ÍndiceToolStripMenuItem.Name = "ÍndiceToolStripMenuItem"
        Me.ÍndiceToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ÍndiceToolStripMenuItem.Text = "Índice"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de..."
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 485)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel.Text = "Estado"
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
        Me.Panel1.Size = New System.Drawing.Size(223, 436)
        Me.Panel1.TabIndex = 10
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button2)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(12, 251)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(193, 182)
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
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(3, 73)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(184, 29)
        Me.Button3.TabIndex = 2
        Me.Button3.TabStop = False
        Me.Button3.Text = "Gestión de Taller"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(3, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(184, 29)
        Me.Button2.TabIndex = 1
        Me.Button2.TabStop = False
        Me.Button2.Text = "Reportes"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(223, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(409, 436)
        Me.Panel2.TabIndex = 11
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
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.Text = "Agacia"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents DatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpresaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoIngresoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeInventarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TodosLosMovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientosEntreFechasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaldosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasPorCobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AsignarCargoPorCobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VerTodosLosCargosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbonosDeCargosPorCobrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacturasPorPagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdministrarCuentasDeUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoUsuarioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrarRolesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistarFuncionesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RolesPorFunciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÍndiceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class
