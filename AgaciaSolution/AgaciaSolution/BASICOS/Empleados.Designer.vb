<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleados
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
        Dim ActivoEmpLabel As System.Windows.Forms.Label
        Dim IdEmpLabel As System.Windows.Forms.Label
        Dim EmailEmpLabel As System.Windows.Forms.Label
        Dim TelefEmpLabel As System.Windows.Forms.Label
        Dim SalarioEmpLabel As System.Windows.Forms.Label
        Dim SexoEmpLabel As System.Windows.Forms.Label
        Dim FechaIngrEmpLabel As System.Windows.Forms.Label
        Dim NomEmpLabel As System.Windows.Forms.Label
        Dim DirEmpLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleados))
        Me.InfoGB = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.IdEmpTextBox = New System.Windows.Forms.TextBox
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasicoDs = New AgaciaSolution.BasicoDs
        Me.NomEmpTextBox = New System.Windows.Forms.TextBox
        Me.DirEmpTextBox = New System.Windows.Forms.TextBox
        Me.TelefEmpTextBox = New System.Windows.Forms.TextBox
        Me.EmailEmpTextBox = New System.Windows.Forms.TextBox
        Me.SalarioEmpTextBox = New System.Windows.Forms.TextBox
        Me.FechaIngrEmpDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.SexoEmpComboBox = New System.Windows.Forms.ComboBox
        Me.ActivoEmpComboBox = New System.Windows.Forms.ComboBox
        Me.BotonesGB = New System.Windows.Forms.GroupBox
        Me.SalirBtn = New System.Windows.Forms.Button
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.NuevoBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        Me.EditarBtn = New System.Windows.Forms.Button
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.EmpleadosLbl = New System.Windows.Forms.Label
        Me.EmpleadoPB = New System.Windows.Forms.PictureBox
        Me.EmpleadosTableAdapter = New AgaciaSolution.BasicoDsTableAdapters.EmpleadosTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator
        ActivoEmpLabel = New System.Windows.Forms.Label
        IdEmpLabel = New System.Windows.Forms.Label
        EmailEmpLabel = New System.Windows.Forms.Label
        TelefEmpLabel = New System.Windows.Forms.Label
        SalarioEmpLabel = New System.Windows.Forms.Label
        SexoEmpLabel = New System.Windows.Forms.Label
        FechaIngrEmpLabel = New System.Windows.Forms.Label
        NomEmpLabel = New System.Windows.Forms.Label
        DirEmpLabel = New System.Windows.Forms.Label
        Me.InfoGB.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BotonesGB.SuspendLayout()
        CType(Me.EmpleadoPB, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActivoEmpLabel
        '
        ActivoEmpLabel.AutoSize = True
        ActivoEmpLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ActivoEmpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        ActivoEmpLabel.Location = New System.Drawing.Point(337, 129)
        ActivoEmpLabel.Name = "ActivoEmpLabel"
        ActivoEmpLabel.Size = New System.Drawing.Size(52, 15)
        ActivoEmpLabel.TabIndex = 33
        ActivoEmpLabel.Text = "Activo :"
        '
        'IdEmpLabel
        '
        IdEmpLabel.AutoSize = True
        IdEmpLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdEmpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        IdEmpLabel.Location = New System.Drawing.Point(14, 37)
        IdEmpLabel.Name = "IdEmpLabel"
        IdEmpLabel.Size = New System.Drawing.Size(97, 15)
        IdEmpLabel.TabIndex = 25
        IdEmpLabel.Text = "DNI Empleado :"
        '
        'EmailEmpLabel
        '
        EmailEmpLabel.AutoSize = True
        EmailEmpLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailEmpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        EmailEmpLabel.Location = New System.Drawing.Point(14, 128)
        EmailEmpLabel.Name = "EmailEmpLabel"
        EmailEmpLabel.Size = New System.Drawing.Size(59, 15)
        EmailEmpLabel.TabIndex = 29
        EmailEmpLabel.Text = "E - mail :"
        '
        'TelefEmpLabel
        '
        TelefEmpLabel.AutoSize = True
        TelefEmpLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefEmpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        TelefEmpLabel.Location = New System.Drawing.Point(337, 98)
        TelefEmpLabel.Name = "TelefEmpLabel"
        TelefEmpLabel.Size = New System.Drawing.Size(50, 15)
        TelefEmpLabel.TabIndex = 28
        TelefEmpLabel.Text = "Tel (s) :"
        '
        'SalarioEmpLabel
        '
        SalarioEmpLabel.AutoSize = True
        SalarioEmpLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalarioEmpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        SalarioEmpLabel.Location = New System.Drawing.Point(316, 191)
        SalarioEmpLabel.Name = "SalarioEmpLabel"
        SalarioEmpLabel.Size = New System.Drawing.Size(55, 15)
        SalarioEmpLabel.TabIndex = 30
        SalarioEmpLabel.Text = "Salario :"
        '
        'SexoEmpLabel
        '
        SexoEmpLabel.AutoSize = True
        SexoEmpLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SexoEmpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        SexoEmpLabel.Location = New System.Drawing.Point(337, 69)
        SexoEmpLabel.Name = "SexoEmpLabel"
        SexoEmpLabel.Size = New System.Drawing.Size(40, 15)
        SexoEmpLabel.TabIndex = 32
        SexoEmpLabel.Text = "Sexo :"
        '
        'FechaIngrEmpLabel
        '
        FechaIngrEmpLabel.AutoSize = True
        FechaIngrEmpLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaIngrEmpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        FechaIngrEmpLabel.Location = New System.Drawing.Point(14, 194)
        FechaIngrEmpLabel.Name = "FechaIngrEmpLabel"
        FechaIngrEmpLabel.Size = New System.Drawing.Size(99, 15)
        FechaIngrEmpLabel.TabIndex = 31
        FechaIngrEmpLabel.Text = "Fecha de Inicio :"
        '
        'NomEmpLabel
        '
        NomEmpLabel.AutoSize = True
        NomEmpLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomEmpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        NomEmpLabel.Location = New System.Drawing.Point(14, 69)
        NomEmpLabel.Name = "NomEmpLabel"
        NomEmpLabel.Size = New System.Drawing.Size(61, 15)
        NomEmpLabel.TabIndex = 26
        NomEmpLabel.Text = "Nombre :"
        '
        'DirEmpLabel
        '
        DirEmpLabel.AutoSize = True
        DirEmpLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DirEmpLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DirEmpLabel.Location = New System.Drawing.Point(14, 98)
        DirEmpLabel.Name = "DirEmpLabel"
        DirEmpLabel.Size = New System.Drawing.Size(69, 15)
        DirEmpLabel.TabIndex = 27
        DirEmpLabel.Text = "Dirección :"
        '
        'InfoGB
        '
        Me.InfoGB.Controls.Add(Me.Label1)
        Me.InfoGB.Controls.Add(Me.IdEmpTextBox)
        Me.InfoGB.Controls.Add(Me.NomEmpTextBox)
        Me.InfoGB.Controls.Add(Me.DirEmpTextBox)
        Me.InfoGB.Controls.Add(Me.TelefEmpTextBox)
        Me.InfoGB.Controls.Add(Me.EmailEmpTextBox)
        Me.InfoGB.Controls.Add(Me.SalarioEmpTextBox)
        Me.InfoGB.Controls.Add(Me.FechaIngrEmpDateTimePicker)
        Me.InfoGB.Controls.Add(ActivoEmpLabel)
        Me.InfoGB.Controls.Add(IdEmpLabel)
        Me.InfoGB.Controls.Add(Me.SexoEmpComboBox)
        Me.InfoGB.Controls.Add(Me.ActivoEmpComboBox)
        Me.InfoGB.Controls.Add(EmailEmpLabel)
        Me.InfoGB.Controls.Add(TelefEmpLabel)
        Me.InfoGB.Controls.Add(SalarioEmpLabel)
        Me.InfoGB.Controls.Add(SexoEmpLabel)
        Me.InfoGB.Controls.Add(FechaIngrEmpLabel)
        Me.InfoGB.Controls.Add(NomEmpLabel)
        Me.InfoGB.Controls.Add(DirEmpLabel)
        Me.InfoGB.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoGB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InfoGB.Location = New System.Drawing.Point(14, 110)
        Me.InfoGB.Name = "InfoGB"
        Me.InfoGB.Size = New System.Drawing.Size(522, 226)
        Me.InfoGB.TabIndex = 0
        Me.InfoGB.TabStop = False
        Me.InfoGB.Text = "Información Empleados"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Contrato"
        '
        'IdEmpTextBox
        '
        Me.IdEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IdEmp", True))
        Me.IdEmpTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdEmpTextBox.Location = New System.Drawing.Point(109, 33)
        Me.IdEmpTextBox.Name = "IdEmpTextBox"
        Me.IdEmpTextBox.Size = New System.Drawing.Size(117, 22)
        Me.IdEmpTextBox.TabIndex = 39
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.BasicoDs
        '
        'BasicoDs
        '
        Me.BasicoDs.DataSetName = "BasicoDs"
        Me.BasicoDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NomEmpTextBox
        '
        Me.NomEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "NomEmp", True))
        Me.NomEmpTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomEmpTextBox.Location = New System.Drawing.Point(108, 67)
        Me.NomEmpTextBox.Name = "NomEmpTextBox"
        Me.NomEmpTextBox.Size = New System.Drawing.Size(223, 22)
        Me.NomEmpTextBox.TabIndex = 41
        '
        'DirEmpTextBox
        '
        Me.DirEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "DirEmp", True))
        Me.DirEmpTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirEmpTextBox.Location = New System.Drawing.Point(109, 95)
        Me.DirEmpTextBox.Name = "DirEmpTextBox"
        Me.DirEmpTextBox.Size = New System.Drawing.Size(200, 22)
        Me.DirEmpTextBox.TabIndex = 43
        '
        'TelefEmpTextBox
        '
        Me.TelefEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "TelefEmp", True))
        Me.TelefEmpTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefEmpTextBox.Location = New System.Drawing.Point(387, 97)
        Me.TelefEmpTextBox.Name = "TelefEmpTextBox"
        Me.TelefEmpTextBox.Size = New System.Drawing.Size(114, 22)
        Me.TelefEmpTextBox.TabIndex = 45
        '
        'EmailEmpTextBox
        '
        Me.EmailEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "EmailEmp", True))
        Me.EmailEmpTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailEmpTextBox.Location = New System.Drawing.Point(109, 123)
        Me.EmailEmpTextBox.Name = "EmailEmpTextBox"
        Me.EmailEmpTextBox.Size = New System.Drawing.Size(200, 22)
        Me.EmailEmpTextBox.TabIndex = 47
        '
        'SalarioEmpTextBox
        '
        Me.SalarioEmpTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "SalarioEmp", True))
        Me.SalarioEmpTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalarioEmpTextBox.Location = New System.Drawing.Point(387, 189)
        Me.SalarioEmpTextBox.Name = "SalarioEmpTextBox"
        Me.SalarioEmpTextBox.Size = New System.Drawing.Size(114, 22)
        Me.SalarioEmpTextBox.TabIndex = 49
        '
        'FechaIngrEmpDateTimePicker
        '
        Me.FechaIngrEmpDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpleadosBindingSource, "FechaIngrEmp", True))
        Me.FechaIngrEmpDateTimePicker.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaIngrEmpDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaIngrEmpDateTimePicker.Location = New System.Drawing.Point(110, 188)
        Me.FechaIngrEmpDateTimePicker.Name = "FechaIngrEmpDateTimePicker"
        Me.FechaIngrEmpDateTimePicker.Size = New System.Drawing.Size(199, 22)
        Me.FechaIngrEmpDateTimePicker.TabIndex = 51
        '
        'SexoEmpComboBox
        '
        Me.SexoEmpComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "SexoEmp", True))
        Me.SexoEmpComboBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SexoEmpComboBox.FormattingEnabled = True
        Me.SexoEmpComboBox.Items.AddRange(New Object() {"F", "M"})
        Me.SexoEmpComboBox.Location = New System.Drawing.Point(387, 67)
        Me.SexoEmpComboBox.Name = "SexoEmpComboBox"
        Me.SexoEmpComboBox.Size = New System.Drawing.Size(61, 23)
        Me.SexoEmpComboBox.TabIndex = 53
        '
        'ActivoEmpComboBox
        '
        Me.ActivoEmpComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "ActivoEmp", True))
        Me.ActivoEmpComboBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActivoEmpComboBox.FormattingEnabled = True
        Me.ActivoEmpComboBox.Items.AddRange(New Object() {"SI", "NO"})
        Me.ActivoEmpComboBox.Location = New System.Drawing.Point(389, 126)
        Me.ActivoEmpComboBox.Name = "ActivoEmpComboBox"
        Me.ActivoEmpComboBox.Size = New System.Drawing.Size(61, 23)
        Me.ActivoEmpComboBox.TabIndex = 55
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
        Me.BotonesGB.Location = New System.Drawing.Point(542, 110)
        Me.BotonesGB.Name = "BotonesGB"
        Me.BotonesGB.Size = New System.Drawing.Size(41, 271)
        Me.BotonesGB.TabIndex = 37
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
        'EmpleadosLbl
        '
        Me.EmpleadosLbl.AutoSize = True
        Me.EmpleadosLbl.Font = New System.Drawing.Font("Georgia", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpleadosLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.EmpleadosLbl.Location = New System.Drawing.Point(171, 37)
        Me.EmpleadosLbl.Name = "EmpleadosLbl"
        Me.EmpleadosLbl.Size = New System.Drawing.Size(319, 49)
        Me.EmpleadosLbl.TabIndex = 34
        Me.EmpleadosLbl.Text = "EMPLEADOS"
        '
        'EmpleadoPB
        '
        Me.EmpleadoPB.Image = CType(resources.GetObject("EmpleadoPB.Image"), System.Drawing.Image)
        Me.EmpleadoPB.Location = New System.Drawing.Point(75, 12)
        Me.EmpleadoPB.Name = "EmpleadoPB"
        Me.EmpleadoPB.Size = New System.Drawing.Size(90, 73)
        Me.EmpleadoPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpleadoPB.TabIndex = 36
        Me.EmpleadoPB.TabStop = False
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosDxCTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DxCTableAdapter = Nothing
        Me.TableAdapterManager.DxPTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
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
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Nothing
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Nothing
        Me.EmpleadosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(161, 354)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(211, 25)
        Me.EmpleadosBindingNavigator.TabIndex = 38
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
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
        'Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(589, 390)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Controls.Add(Me.InfoGB)
        Me.Controls.Add(Me.EmpleadoPB)
        Me.Controls.Add(Me.BotonesGB)
        Me.Controls.Add(Me.EmpleadosLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empleados"
        Me.InfoGB.ResumeLayout(False)
        Me.InfoGB.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BotonesGB.ResumeLayout(False)
        CType(Me.EmpleadoPB, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InfoGB As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BotonesGB As System.Windows.Forms.GroupBox
    Friend WithEvents SalirBtn As System.Windows.Forms.Button
    Friend WithEvents BuscarBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents NuevoBtn As System.Windows.Forms.Button
    Friend WithEvents EliminarBtn As System.Windows.Forms.Button
    Friend WithEvents EditarBtn As System.Windows.Forms.Button
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents EmpleadoPB As System.Windows.Forms.PictureBox
    Friend WithEvents EmpleadosLbl As System.Windows.Forms.Label
    Friend WithEvents BasicoDs As AgaciaSolution.BasicoDs
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As AgaciaSolution.BasicoDsTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IdEmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NomEmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DirEmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefEmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailEmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SalarioEmpTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaIngrEmpDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents SexoEmpComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents ActivoEmpComboBox As System.Windows.Forms.ComboBox
End Class
