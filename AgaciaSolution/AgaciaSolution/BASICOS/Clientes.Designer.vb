<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Clientes
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
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim ActivoClieLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Clientes))
        Me.BotonesGB = New System.Windows.Forms.GroupBox
        Me.SalirBtn = New System.Windows.Forms.Button
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.NuevoBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        Me.EditarBtn = New System.Windows.Forms.Button
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.ClientesLbl = New System.Windows.Forms.Label
        Me.InfoGB = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ActivoClieComboBox = New System.Windows.Forms.ComboBox
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasicoDs = New AgaciaSolution.BasicoDs
        Me.TipClieComboBox = New System.Windows.Forms.ComboBox
        Me.SexoLbl = New System.Windows.Forms.Label
        Me.IdClieTextBox = New System.Windows.Forms.TextBox
        Me.NomClieTextBox = New System.Windows.Forms.TextBox
        Me.DirClieTextBox = New System.Windows.Forms.TextBox
        Me.TelefClieTextBox = New System.Windows.Forms.TextBox
        Me.EmailClieTextBox = New System.Windows.Forms.TextBox
        Me.SexoClieComboBox = New System.Windows.Forms.ComboBox
        Me.CiudadClieTextBox = New System.Windows.Forms.TextBox
        Me.ClientesTableAdapter = New AgaciaSolution.BasicoDsTableAdapters.ClientesTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
        Me.ClientesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.EmpleadoPB = New System.Windows.Forms.PictureBox
        Label1 = New System.Windows.Forms.Label
        Label2 = New System.Windows.Forms.Label
        Label3 = New System.Windows.Forms.Label
        Label4 = New System.Windows.Forms.Label
        Label5 = New System.Windows.Forms.Label
        Label6 = New System.Windows.Forms.Label
        Label7 = New System.Windows.Forms.Label
        ActivoClieLabel = New System.Windows.Forms.Label
        Me.BotonesGB.SuspendLayout()
        Me.InfoGB.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ClientesBindingNavigator.SuspendLayout()
        CType(Me.EmpleadoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label1.Location = New System.Drawing.Point(6, 59)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(81, 15)
        Label1.TabIndex = 32
        Label1.Text = "DNI Cliente :"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label2.Location = New System.Drawing.Point(6, 31)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(39, 15)
        Label2.TabIndex = 34
        Label2.Text = "Tipo :"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label3.Location = New System.Drawing.Point(292, 134)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(55, 15)
        Label3.TabIndex = 38
        Label3.Text = "Ciudad :"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label4.Location = New System.Drawing.Point(6, 114)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(69, 15)
        Label4.TabIndex = 35
        Label4.Text = "Dirreción :"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label5.Location = New System.Drawing.Point(6, 84)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(61, 15)
        Label5.TabIndex = 33
        Label5.Text = "Nombre :"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label6.Location = New System.Drawing.Point(292, 108)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(47, 15)
        Label6.TabIndex = 36
        Label6.Text = "Tel (s):"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Label7.Location = New System.Drawing.Point(6, 142)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(59, 15)
        Label7.TabIndex = 37
        Label7.Text = "E - mail :"
        '
        'ActivoClieLabel
        '
        ActivoClieLabel.AutoSize = True
        ActivoClieLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActivoClieLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        ActivoClieLabel.Location = New System.Drawing.Point(6, 15)
        ActivoClieLabel.Name = "ActivoClieLabel"
        ActivoClieLabel.Size = New System.Drawing.Size(52, 15)
        ActivoClieLabel.TabIndex = 17
        ActivoClieLabel.Text = "Activo :"
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
        Me.BotonesGB.Location = New System.Drawing.Point(488, 93)
        Me.BotonesGB.Name = "BotonesGB"
        Me.BotonesGB.Size = New System.Drawing.Size(41, 271)
        Me.BotonesGB.TabIndex = 27
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
        'ClientesLbl
        '
        Me.ClientesLbl.AutoSize = True
        Me.ClientesLbl.Font = New System.Drawing.Font("Georgia", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClientesLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.ClientesLbl.Location = New System.Drawing.Point(162, 35)
        Me.ClientesLbl.Name = "ClientesLbl"
        Me.ClientesLbl.Size = New System.Drawing.Size(239, 46)
        Me.ClientesLbl.TabIndex = 28
        Me.ClientesLbl.Text = "CLIENTES"
        '
        'InfoGB
        '
        Me.InfoGB.Controls.Add(Me.GroupBox2)
        Me.InfoGB.Controls.Add(Me.TipClieComboBox)
        Me.InfoGB.Controls.Add(Me.SexoLbl)
        Me.InfoGB.Controls.Add(Label1)
        Me.InfoGB.Controls.Add(Me.IdClieTextBox)
        Me.InfoGB.Controls.Add(Label2)
        Me.InfoGB.Controls.Add(Label3)
        Me.InfoGB.Controls.Add(Label4)
        Me.InfoGB.Controls.Add(Me.NomClieTextBox)
        Me.InfoGB.Controls.Add(Label5)
        Me.InfoGB.Controls.Add(Label6)
        Me.InfoGB.Controls.Add(Label7)
        Me.InfoGB.Controls.Add(Me.DirClieTextBox)
        Me.InfoGB.Controls.Add(Me.TelefClieTextBox)
        Me.InfoGB.Controls.Add(Me.EmailClieTextBox)
        Me.InfoGB.Controls.Add(Me.SexoClieComboBox)
        Me.InfoGB.Controls.Add(Me.CiudadClieTextBox)
        Me.InfoGB.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoGB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InfoGB.Location = New System.Drawing.Point(12, 101)
        Me.InfoGB.Name = "InfoGB"
        Me.InfoGB.Size = New System.Drawing.Size(470, 218)
        Me.InfoGB.TabIndex = 30
        Me.InfoGB.TabStop = False
        Me.InfoGB.Text = "Información Clientes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(ActivoClieLabel)
        Me.GroupBox2.Controls.Add(Me.ActivoClieComboBox)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 161)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(126, 39)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'ActivoClieComboBox
        '
        Me.ActivoClieComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "ActivoClie", True))
        Me.ActivoClieComboBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivoClieComboBox.FormattingEnabled = True
        Me.ActivoClieComboBox.Items.AddRange(New Object() {"SI", "NO"})
        Me.ActivoClieComboBox.Location = New System.Drawing.Point(64, 12)
        Me.ActivoClieComboBox.Name = "ActivoClieComboBox"
        Me.ActivoClieComboBox.Size = New System.Drawing.Size(52, 23)
        Me.ActivoClieComboBox.TabIndex = 41
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.BasicoDs
        '
        'BasicoDs
        '
        Me.BasicoDs.DataSetName = "BasicoDs"
        Me.BasicoDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TipClieComboBox
        '
        Me.TipClieComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "TipClie", True))
        Me.TipClieComboBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipClieComboBox.FormattingEnabled = True
        Me.TipClieComboBox.Items.AddRange(New Object() {"PERSONA NATURAL", "PERSONA JURIDICA"})
        Me.TipClieComboBox.Location = New System.Drawing.Point(86, 29)
        Me.TipClieComboBox.Name = "TipClieComboBox"
        Me.TipClieComboBox.Size = New System.Drawing.Size(121, 23)
        Me.TipClieComboBox.TabIndex = 40
        '
        'SexoLbl
        '
        Me.SexoLbl.AutoSize = True
        Me.SexoLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexoLbl.Location = New System.Drawing.Point(292, 59)
        Me.SexoLbl.Name = "SexoLbl"
        Me.SexoLbl.Size = New System.Drawing.Size(33, 15)
        Me.SexoLbl.TabIndex = 39
        Me.SexoLbl.Text = "Sexo"
        '
        'IdClieTextBox
        '
        Me.IdClieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "IdClie", True))
        Me.IdClieTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdClieTextBox.Location = New System.Drawing.Point(86, 57)
        Me.IdClieTextBox.Name = "IdClieTextBox"
        Me.IdClieTextBox.Size = New System.Drawing.Size(121, 22)
        Me.IdClieTextBox.TabIndex = 1
        '
        'NomClieTextBox
        '
        Me.NomClieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "NomClie", True))
        Me.NomClieTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomClieTextBox.Location = New System.Drawing.Point(86, 82)
        Me.NomClieTextBox.Name = "NomClieTextBox"
        Me.NomClieTextBox.Size = New System.Drawing.Size(346, 22)
        Me.NomClieTextBox.TabIndex = 3
        '
        'DirClieTextBox
        '
        Me.DirClieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "DirClie", True))
        Me.DirClieTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirClieTextBox.Location = New System.Drawing.Point(86, 109)
        Me.DirClieTextBox.Name = "DirClieTextBox"
        Me.DirClieTextBox.Size = New System.Drawing.Size(159, 22)
        Me.DirClieTextBox.TabIndex = 7
        '
        'TelefClieTextBox
        '
        Me.TelefClieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "TelefClie", True))
        Me.TelefClieTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefClieTextBox.Location = New System.Drawing.Point(345, 105)
        Me.TelefClieTextBox.Name = "TelefClieTextBox"
        Me.TelefClieTextBox.Size = New System.Drawing.Size(121, 22)
        Me.TelefClieTextBox.TabIndex = 9
        '
        'EmailClieTextBox
        '
        Me.EmailClieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "EmailClie", True))
        Me.EmailClieTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailClieTextBox.Location = New System.Drawing.Point(86, 135)
        Me.EmailClieTextBox.Name = "EmailClieTextBox"
        Me.EmailClieTextBox.Size = New System.Drawing.Size(198, 22)
        Me.EmailClieTextBox.TabIndex = 11
        '
        'SexoClieComboBox
        '
        Me.SexoClieComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "SexoClie", True))
        Me.SexoClieComboBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexoClieComboBox.FormattingEnabled = True
        Me.SexoClieComboBox.Items.AddRange(New Object() {"F", "M"})
        Me.SexoClieComboBox.Location = New System.Drawing.Point(328, 54)
        Me.SexoClieComboBox.Name = "SexoClieComboBox"
        Me.SexoClieComboBox.Size = New System.Drawing.Size(47, 23)
        Me.SexoClieComboBox.TabIndex = 13
        '
        'CiudadClieTextBox
        '
        Me.CiudadClieTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "CiudadClie", True))
        Me.CiudadClieTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadClieTextBox.Location = New System.Drawing.Point(347, 132)
        Me.CiudadClieTextBox.Name = "CiudadClieTextBox"
        Me.CiudadClieTextBox.Size = New System.Drawing.Size(121, 22)
        Me.CiudadClieTextBox.TabIndex = 15
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosDxCTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Me.ClientesTableAdapter
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
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Nothing
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.ROLxFUNCIONESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ClientesBindingNavigator
        '
        Me.ClientesBindingNavigator.AddNewItem = Nothing
        Me.ClientesBindingNavigator.BindingSource = Me.ClientesBindingSource
        Me.ClientesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ClientesBindingNavigator.DeleteItem = Nothing
        Me.ClientesBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ClientesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ClientesBindingNavigator.Location = New System.Drawing.Point(129, 332)
        Me.ClientesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ClientesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ClientesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ClientesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ClientesBindingNavigator.Name = "ClientesBindingNavigator"
        Me.ClientesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ClientesBindingNavigator.Size = New System.Drawing.Size(211, 25)
        Me.ClientesBindingNavigator.TabIndex = 31
        Me.ClientesBindingNavigator.Text = "BindingNavigator1"
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
        'EmpleadoPB
        '
        Me.EmpleadoPB.Location = New System.Drawing.Point(40, 12)
        Me.EmpleadoPB.Name = "EmpleadoPB"
        Me.EmpleadoPB.Size = New System.Drawing.Size(86, 69)
        Me.EmpleadoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpleadoPB.TabIndex = 29
        Me.EmpleadoPB.TabStop = False
        '
        'Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(533, 366)
        Me.Controls.Add(Me.ClientesBindingNavigator)
        Me.Controls.Add(Me.InfoGB)
        Me.Controls.Add(Me.EmpleadoPB)
        Me.Controls.Add(Me.ClientesLbl)
        Me.Controls.Add(Me.BotonesGB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.BotonesGB.ResumeLayout(False)
        Me.InfoGB.ResumeLayout(False)
        Me.InfoGB.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ClientesBindingNavigator.ResumeLayout(False)
        Me.ClientesBindingNavigator.PerformLayout()
        CType(Me.EmpleadoPB, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents EmpleadoPB As System.Windows.Forms.PictureBox
    Friend WithEvents ClientesLbl As System.Windows.Forms.Label
    Friend WithEvents InfoGB As System.Windows.Forms.GroupBox
    Friend WithEvents BasicoDs As AgaciaSolution.BasicoDs
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As AgaciaSolution.BasicoDsTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
    Friend WithEvents ClientesBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IdClieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomClieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirClieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefClieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailClieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexoClieComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents CiudadClieTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ActivoClieComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TipClieComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents SexoLbl As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
