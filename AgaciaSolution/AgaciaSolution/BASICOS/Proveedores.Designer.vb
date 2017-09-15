<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedores
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
        Dim CiudadProvLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedores))
        Me.NumeroCuentaLbl = New System.Windows.Forms.Label
        Me.TipodeCuentaLbl = New System.Windows.Forms.Label
        Me.InfoGB = New System.Windows.Forms.GroupBox
        Me.IdProvTextBox = New System.Windows.Forms.TextBox
        Me.ProveedoresBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasicoDs = New AgaciaSolution.BasicoDs
        Me.NomProvTextBox = New System.Windows.Forms.TextBox
        Me.DirProvTextBox = New System.Windows.Forms.TextBox
        Me.TelefProvTextBox = New System.Windows.Forms.TextBox
        Me.CiudadProvTextBox = New System.Windows.Forms.TextBox
        Me.ContactoProvTextBox = New System.Windows.Forms.TextBox
        Me.TelefContProvTextBox = New System.Windows.Forms.TextBox
        Me.EmailContProvTextBox = New System.Windows.Forms.TextBox
        Me.TipoCtaProvComboBox = New System.Windows.Forms.ComboBox
        Me.NomBancoProvTextBox = New System.Windows.Forms.TextBox
        Me.TitularCtaProvTextBox = New System.Windows.Forms.TextBox
        Me.NumCtaProvTextBox = New System.Windows.Forms.TextBox
        Me.TelProveedorContactoLbl = New System.Windows.Forms.Label
        Me.TelProveedorLbl = New System.Windows.Forms.Label
        Me.TitulatCuentaLbl = New System.Windows.Forms.Label
        Me.NombreBancoLbl = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.NomProveedorContactoLbl = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.EmailProveedorLbl = New System.Windows.Forms.Label
        Me.DireProveedorLbl = New System.Windows.Forms.Label
        Me.NomProveedorLbl = New System.Windows.Forms.Label
        Me.IdProveedorLbl = New System.Windows.Forms.Label
        Me.EmpleadosLbl = New System.Windows.Forms.Label
        Me.BotonesGB = New System.Windows.Forms.GroupBox
        Me.SalirBtn = New System.Windows.Forms.Button
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.NuevoBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        Me.EditarBtn = New System.Windows.Forms.Button
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.EmpleadoPB = New System.Windows.Forms.PictureBox
        Me.ProveedoresTableAdapter = New AgaciaSolution.BasicoDsTableAdapters.ProveedoresTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
        Me.ProveedoresBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        CiudadProvLabel = New System.Windows.Forms.Label
        Me.InfoGB.SuspendLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BotonesGB.SuspendLayout()
        CType(Me.EmpleadoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ProveedoresBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'CiudadProvLabel
        '
        CiudadProvLabel.AutoSize = True
        CiudadProvLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadProvLabel.Location = New System.Drawing.Point(6, 96)
        CiudadProvLabel.Name = "CiudadProvLabel"
        CiudadProvLabel.Size = New System.Drawing.Size(55, 15)
        CiudadProvLabel.TabIndex = 28
        CiudadProvLabel.Text = "Ciudad :"
        '
        'NumeroCuentaLbl
        '
        Me.NumeroCuentaLbl.AutoSize = True
        Me.NumeroCuentaLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumeroCuentaLbl.Location = New System.Drawing.Point(307, 217)
        Me.NumeroCuentaLbl.Name = "NumeroCuentaLbl"
        Me.NumeroCuentaLbl.Size = New System.Drawing.Size(71, 15)
        Me.NumeroCuentaLbl.TabIndex = 42
        Me.NumeroCuentaLbl.Text = "N° Cuenta:"
        '
        'TipodeCuentaLbl
        '
        Me.TipodeCuentaLbl.AutoSize = True
        Me.TipodeCuentaLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipodeCuentaLbl.Location = New System.Drawing.Point(307, 194)
        Me.TipodeCuentaLbl.Name = "TipodeCuentaLbl"
        Me.TipodeCuentaLbl.Size = New System.Drawing.Size(97, 15)
        Me.TipodeCuentaLbl.TabIndex = 41
        Me.TipodeCuentaLbl.Text = "Tipo de Cuenta:"
        '
        'InfoGB
        '
        Me.InfoGB.Controls.Add(CiudadProvLabel)
        Me.InfoGB.Controls.Add(Me.IdProvTextBox)
        Me.InfoGB.Controls.Add(Me.NomProvTextBox)
        Me.InfoGB.Controls.Add(Me.DirProvTextBox)
        Me.InfoGB.Controls.Add(Me.TelefProvTextBox)
        Me.InfoGB.Controls.Add(Me.CiudadProvTextBox)
        Me.InfoGB.Controls.Add(Me.ContactoProvTextBox)
        Me.InfoGB.Controls.Add(Me.TelefContProvTextBox)
        Me.InfoGB.Controls.Add(Me.EmailContProvTextBox)
        Me.InfoGB.Controls.Add(Me.TipoCtaProvComboBox)
        Me.InfoGB.Controls.Add(Me.NumeroCuentaLbl)
        Me.InfoGB.Controls.Add(Me.NomBancoProvTextBox)
        Me.InfoGB.Controls.Add(Me.TitularCtaProvTextBox)
        Me.InfoGB.Controls.Add(Me.TipodeCuentaLbl)
        Me.InfoGB.Controls.Add(Me.NumCtaProvTextBox)
        Me.InfoGB.Controls.Add(Me.TelProveedorContactoLbl)
        Me.InfoGB.Controls.Add(Me.TelProveedorLbl)
        Me.InfoGB.Controls.Add(Me.TitulatCuentaLbl)
        Me.InfoGB.Controls.Add(Me.NombreBancoLbl)
        Me.InfoGB.Controls.Add(Me.Label3)
        Me.InfoGB.Controls.Add(Me.NomProveedorContactoLbl)
        Me.InfoGB.Controls.Add(Me.Label1)
        Me.InfoGB.Controls.Add(Me.EmailProveedorLbl)
        Me.InfoGB.Controls.Add(Me.DireProveedorLbl)
        Me.InfoGB.Controls.Add(Me.NomProveedorLbl)
        Me.InfoGB.Controls.Add(Me.IdProveedorLbl)
        Me.InfoGB.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoGB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InfoGB.Location = New System.Drawing.Point(5, 104)
        Me.InfoGB.Name = "InfoGB"
        Me.InfoGB.Size = New System.Drawing.Size(522, 243)
        Me.InfoGB.TabIndex = 28
        Me.InfoGB.TabStop = False
        Me.InfoGB.Text = "Información Proveedores"
        '
        'IdProvTextBox
        '
        Me.IdProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "IdProv", True))
        Me.IdProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProvTextBox.Location = New System.Drawing.Point(103, 22)
        Me.IdProvTextBox.Name = "IdProvTextBox"
        Me.IdProvTextBox.Size = New System.Drawing.Size(121, 22)
        Me.IdProvTextBox.TabIndex = 31
        '
        'ProveedoresBindingSource
        '
        Me.ProveedoresBindingSource.DataMember = "Proveedores"
        Me.ProveedoresBindingSource.DataSource = Me.BasicoDs
        '
        'BasicoDs
        '
        Me.BasicoDs.DataSetName = "BasicoDs"
        Me.BasicoDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomProvTextBox
        '
        Me.NomProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "NomProv", True))
        Me.NomProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomProvTextBox.Location = New System.Drawing.Point(102, 47)
        Me.NomProvTextBox.Name = "NomProvTextBox"
        Me.NomProvTextBox.Size = New System.Drawing.Size(302, 22)
        Me.NomProvTextBox.TabIndex = 33
        '
        'DirProvTextBox
        '
        Me.DirProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "DirProv", True))
        Me.DirProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirProvTextBox.Location = New System.Drawing.Point(101, 70)
        Me.DirProvTextBox.Name = "DirProvTextBox"
        Me.DirProvTextBox.Size = New System.Drawing.Size(234, 22)
        Me.DirProvTextBox.TabIndex = 35
        '
        'TelefProvTextBox
        '
        Me.TelefProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "TelefProv", True))
        Me.TelefProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefProvTextBox.Location = New System.Drawing.Point(394, 72)
        Me.TelefProvTextBox.Name = "TelefProvTextBox"
        Me.TelefProvTextBox.Size = New System.Drawing.Size(110, 22)
        Me.TelefProvTextBox.TabIndex = 37
        '
        'CiudadProvTextBox
        '
        Me.CiudadProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "CiudadProv", True))
        Me.CiudadProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadProvTextBox.Location = New System.Drawing.Point(101, 94)
        Me.CiudadProvTextBox.Name = "CiudadProvTextBox"
        Me.CiudadProvTextBox.Size = New System.Drawing.Size(184, 22)
        Me.CiudadProvTextBox.TabIndex = 39
        '
        'ContactoProvTextBox
        '
        Me.ContactoProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "ContactoProv", True))
        Me.ContactoProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactoProvTextBox.Location = New System.Drawing.Point(101, 133)
        Me.ContactoProvTextBox.Name = "ContactoProvTextBox"
        Me.ContactoProvTextBox.Size = New System.Drawing.Size(303, 22)
        Me.ContactoProvTextBox.TabIndex = 41
        '
        'TelefContProvTextBox
        '
        Me.TelefContProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "TelefContProv", True))
        Me.TelefContProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefContProvTextBox.Location = New System.Drawing.Point(394, 162)
        Me.TelefContProvTextBox.Name = "TelefContProvTextBox"
        Me.TelefContProvTextBox.Size = New System.Drawing.Size(110, 22)
        Me.TelefContProvTextBox.TabIndex = 43
        '
        'EmailContProvTextBox
        '
        Me.EmailContProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "EmailContProv", True))
        Me.EmailContProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailContProvTextBox.Location = New System.Drawing.Point(101, 157)
        Me.EmailContProvTextBox.Name = "EmailContProvTextBox"
        Me.EmailContProvTextBox.Size = New System.Drawing.Size(234, 22)
        Me.EmailContProvTextBox.TabIndex = 45
        '
        'TipoCtaProvComboBox
        '
        Me.TipoCtaProvComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "TipoCtaProv", True))
        Me.TipoCtaProvComboBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TipoCtaProvComboBox.FormattingEnabled = True
        Me.TipoCtaProvComboBox.Items.AddRange(New Object() {"AHORROS", "CORRIENTE"})
        Me.TipoCtaProvComboBox.Location = New System.Drawing.Point(401, 187)
        Me.TipoCtaProvComboBox.Name = "TipoCtaProvComboBox"
        Me.TipoCtaProvComboBox.Size = New System.Drawing.Size(103, 23)
        Me.TipoCtaProvComboBox.TabIndex = 47
        '
        'NomBancoProvTextBox
        '
        Me.NomBancoProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "NomBancoProv", True))
        Me.NomBancoProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomBancoProvTextBox.Location = New System.Drawing.Point(102, 217)
        Me.NomBancoProvTextBox.Name = "NomBancoProvTextBox"
        Me.NomBancoProvTextBox.Size = New System.Drawing.Size(199, 22)
        Me.NomBancoProvTextBox.TabIndex = 51
        '
        'TitularCtaProvTextBox
        '
        Me.TitularCtaProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "TitularCtaProv", True))
        Me.TitularCtaProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitularCtaProvTextBox.Location = New System.Drawing.Point(103, 191)
        Me.TitularCtaProvTextBox.Name = "TitularCtaProvTextBox"
        Me.TitularCtaProvTextBox.Size = New System.Drawing.Size(198, 22)
        Me.TitularCtaProvTextBox.TabIndex = 53
        '
        'NumCtaProvTextBox
        '
        Me.NumCtaProvTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProveedoresBindingSource, "NumCtaProv", True))
        Me.NumCtaProvTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumCtaProvTextBox.Location = New System.Drawing.Point(394, 215)
        Me.NumCtaProvTextBox.Name = "NumCtaProvTextBox"
        Me.NumCtaProvTextBox.Size = New System.Drawing.Size(110, 22)
        Me.NumCtaProvTextBox.TabIndex = 49
        '
        'TelProveedorContactoLbl
        '
        Me.TelProveedorContactoLbl.AutoSize = True
        Me.TelProveedorContactoLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelProveedorContactoLbl.Location = New System.Drawing.Point(338, 164)
        Me.TelProveedorContactoLbl.Name = "TelProveedorContactoLbl"
        Me.TelProveedorContactoLbl.Size = New System.Drawing.Size(50, 15)
        Me.TelProveedorContactoLbl.TabIndex = 40
        Me.TelProveedorContactoLbl.Text = "Tel (s) :"
        '
        'TelProveedorLbl
        '
        Me.TelProveedorLbl.AutoSize = True
        Me.TelProveedorLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelProveedorLbl.Location = New System.Drawing.Point(341, 76)
        Me.TelProveedorLbl.Name = "TelProveedorLbl"
        Me.TelProveedorLbl.Size = New System.Drawing.Size(47, 15)
        Me.TelProveedorLbl.TabIndex = 39
        Me.TelProveedorLbl.Text = "Tel (s):"
        '
        'TitulatCuentaLbl
        '
        Me.TitulatCuentaLbl.AutoSize = True
        Me.TitulatCuentaLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitulatCuentaLbl.Location = New System.Drawing.Point(6, 197)
        Me.TitulatCuentaLbl.Name = "TitulatCuentaLbl"
        Me.TitulatCuentaLbl.Size = New System.Drawing.Size(53, 15)
        Me.TitulatCuentaLbl.TabIndex = 38
        Me.TitulatCuentaLbl.Text = "Titular:"
        '
        'NombreBancoLbl
        '
        Me.NombreBancoLbl.AutoSize = True
        Me.NombreBancoLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreBancoLbl.Location = New System.Drawing.Point(6, 219)
        Me.NombreBancoLbl.Name = "NombreBancoLbl"
        Me.NombreBancoLbl.Size = New System.Drawing.Size(96, 15)
        Me.NombreBancoLbl.TabIndex = 37
        Me.NombreBancoLbl.Text = "Nombre Banco:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(6, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 18)
        Me.Label3.TabIndex = 36
        Me.Label3.Text = "Cuenta"
        '
        'NomProveedorContactoLbl
        '
        Me.NomProveedorContactoLbl.AutoSize = True
        Me.NomProveedorContactoLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomProveedorContactoLbl.Location = New System.Drawing.Point(6, 139)
        Me.NomProveedorContactoLbl.Name = "NomProveedorContactoLbl"
        Me.NomProveedorContactoLbl.Size = New System.Drawing.Size(58, 15)
        Me.NomProveedorContactoLbl.TabIndex = 35
        Me.NomProveedorContactoLbl.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(6, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Contacto "
        '
        'EmailProveedorLbl
        '
        Me.EmailProveedorLbl.AutoSize = True
        Me.EmailProveedorLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailProveedorLbl.Location = New System.Drawing.Point(6, 159)
        Me.EmailProveedorLbl.Name = "EmailProveedorLbl"
        Me.EmailProveedorLbl.Size = New System.Drawing.Size(50, 15)
        Me.EmailProveedorLbl.TabIndex = 33
        Me.EmailProveedorLbl.Text = "E-mail:"
        '
        'DireProveedorLbl
        '
        Me.DireProveedorLbl.AutoSize = True
        Me.DireProveedorLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireProveedorLbl.Location = New System.Drawing.Point(6, 72)
        Me.DireProveedorLbl.Name = "DireProveedorLbl"
        Me.DireProveedorLbl.Size = New System.Drawing.Size(66, 15)
        Me.DireProveedorLbl.TabIndex = 32
        Me.DireProveedorLbl.Text = "Direccion:"
        '
        'NomProveedorLbl
        '
        Me.NomProveedorLbl.AutoSize = True
        Me.NomProveedorLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomProveedorLbl.Location = New System.Drawing.Point(6, 49)
        Me.NomProveedorLbl.Name = "NomProveedorLbl"
        Me.NomProveedorLbl.Size = New System.Drawing.Size(58, 15)
        Me.NomProveedorLbl.TabIndex = 31
        Me.NomProveedorLbl.Text = "Nombre:"
        '
        'IdProveedorLbl
        '
        Me.IdProveedorLbl.AutoSize = True
        Me.IdProveedorLbl.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdProveedorLbl.Location = New System.Drawing.Point(6, 26)
        Me.IdProveedorLbl.Name = "IdProveedorLbl"
        Me.IdProveedorLbl.Size = New System.Drawing.Size(95, 15)
        Me.IdProveedorLbl.TabIndex = 30
        Me.IdProveedorLbl.Text = "DNI Proveedor:"
        '
        'EmpleadosLbl
        '
        Me.EmpleadosLbl.AutoSize = True
        Me.EmpleadosLbl.Font = New System.Drawing.Font("Georgia", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadosLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.EmpleadosLbl.Location = New System.Drawing.Point(130, 34)
        Me.EmpleadosLbl.Name = "EmpleadosLbl"
        Me.EmpleadosLbl.Size = New System.Drawing.Size(329, 43)
        Me.EmpleadosLbl.TabIndex = 27
        Me.EmpleadosLbl.Text = "PROVEEDORES"
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
        Me.BotonesGB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BotonesGB.Location = New System.Drawing.Point(533, 104)
        Me.BotonesGB.Name = "BotonesGB"
        Me.BotonesGB.Size = New System.Drawing.Size(41, 271)
        Me.BotonesGB.TabIndex = 29
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
        Me.NuevoBtn.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.NuevoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuevoBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NuevoBtn.FlatAppearance.BorderSize = 2
        Me.NuevoBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.NuevoBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.NuevoBtn.Image = CType(resources.GetObject("NuevoBtn.Image"), System.Drawing.Image)
        Me.NuevoBtn.Location = New System.Drawing.Point(0, 9)
        Me.NuevoBtn.Name = "NuevoBtn"
        Me.NuevoBtn.Size = New System.Drawing.Size(41, 37)
        Me.NuevoBtn.TabIndex = 6
        Me.NuevoBtn.UseVisualStyleBackColor = False
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
        'EmpleadoPB
        '
        Me.EmpleadoPB.Image = CType(resources.GetObject("EmpleadoPB.Image"), System.Drawing.Image)
        Me.EmpleadoPB.Location = New System.Drawing.Point(22, 12)
        Me.EmpleadoPB.Name = "EmpleadoPB"
        Me.EmpleadoPB.Size = New System.Drawing.Size(102, 77)
        Me.EmpleadoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpleadoPB.TabIndex = 26
        Me.EmpleadoPB.TabStop = False
        '
        'ProveedoresTableAdapter
        '
        Me.ProveedoresTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.ProveedoresTableAdapter = Me.ProveedoresTableAdapter
        Me.TableAdapterManager.RolesTableAdapter = Nothing
        Me.TableAdapterManager.ROLxFUNCIONESTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsuariosTableAdapter = Nothing
        '
        'ProveedoresBindingNavigator
        '
        Me.ProveedoresBindingNavigator.AddNewItem = Nothing
        Me.ProveedoresBindingNavigator.BindingSource = Me.ProveedoresBindingSource
        Me.ProveedoresBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ProveedoresBindingNavigator.DeleteItem = Nothing
        Me.ProveedoresBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.ProveedoresBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.ProveedoresBindingNavigator.Location = New System.Drawing.Point(167, 353)
        Me.ProveedoresBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ProveedoresBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ProveedoresBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ProveedoresBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ProveedoresBindingNavigator.Name = "ProveedoresBindingNavigator"
        Me.ProveedoresBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ProveedoresBindingNavigator.Size = New System.Drawing.Size(211, 25)
        Me.ProveedoresBindingNavigator.TabIndex = 30
        Me.ProveedoresBindingNavigator.Text = "BindingNavigator1"
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
        'Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(578, 387)
        Me.Controls.Add(Me.ProveedoresBindingNavigator)
        Me.Controls.Add(Me.InfoGB)
        Me.Controls.Add(Me.EmpleadoPB)
        Me.Controls.Add(Me.EmpleadosLbl)
        Me.Controls.Add(Me.BotonesGB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proveedores"
        Me.InfoGB.ResumeLayout(False)
        Me.InfoGB.PerformLayout()
        CType(Me.ProveedoresBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BotonesGB.ResumeLayout(False)
        CType(Me.EmpleadoPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProveedoresBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ProveedoresBindingNavigator.ResumeLayout(False)
        Me.ProveedoresBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NumeroCuentaLbl As System.Windows.Forms.Label
    Friend WithEvents TipodeCuentaLbl As System.Windows.Forms.Label
    Friend WithEvents InfoGB As System.Windows.Forms.GroupBox
    Friend WithEvents TelProveedorContactoLbl As System.Windows.Forms.Label
    Friend WithEvents TelProveedorLbl As System.Windows.Forms.Label
    Friend WithEvents TitulatCuentaLbl As System.Windows.Forms.Label
    Friend WithEvents NombreBancoLbl As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents NomProveedorContactoLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents EmailProveedorLbl As System.Windows.Forms.Label
    Friend WithEvents DireProveedorLbl As System.Windows.Forms.Label
    Friend WithEvents NomProveedorLbl As System.Windows.Forms.Label
    Friend WithEvents IdProveedorLbl As System.Windows.Forms.Label
    Friend WithEvents EmpleadoPB As System.Windows.Forms.PictureBox
    Friend WithEvents EmpleadosLbl As System.Windows.Forms.Label
    Friend WithEvents BotonesGB As System.Windows.Forms.GroupBox
    Friend WithEvents SalirBtn As System.Windows.Forms.Button
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents NuevoBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents EditarBtn As System.Windows.Forms.Button
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents BasicoDs As AgaciaSolution.BasicoDs
    Friend WithEvents ProveedoresBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProveedoresTableAdapter As AgaciaSolution.BasicoDsTableAdapters.ProveedoresTableAdapter
    Friend WithEvents TableAdapterManager As AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
    Friend WithEvents ProveedoresBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IdProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CiudadProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ContactoProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefContProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailContProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TipoCtaProvComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents NomBancoProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TitularCtaProvTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NumCtaProvTextBox As System.Windows.Forms.TextBox
End Class
