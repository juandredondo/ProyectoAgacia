<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empresa
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
        Dim NomEmpreLabel As System.Windows.Forms.Label
        Dim NitEmpreLabel As System.Windows.Forms.Label
        Dim RepEmpreLabel As System.Windows.Forms.Label
        Dim FechaConstEmpreLabel As System.Windows.Forms.Label
        Dim DirEmpreLabel As System.Windows.Forms.Label
        Dim TelefEmpreLabel As System.Windows.Forms.Label
        Dim EmailEmpreLabel As System.Windows.Forms.Label
        Dim CodPostalEmpreLabel As System.Windows.Forms.Label
        Dim WebEmpreLabel As System.Windows.Forms.Label
        Dim LogoEmpreLabel As System.Windows.Forms.Label
        Dim RegEmpreLabel As System.Windows.Forms.Label
        Dim TelefaxEmpreLabel As System.Windows.Forms.Label
        Dim ObjetosocEmpreLabel As System.Windows.Forms.Label
        Dim CiudadEmpreLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empresa))
        Me.InfoGB = New System.Windows.Forms.GroupBox
        Me.NomEmpreTextBox = New System.Windows.Forms.TextBox
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BasicoDs = New AgaciaSolution.BasicoDs
        Me.NitEmpreTextBox = New System.Windows.Forms.TextBox
        Me.RepEmpreTextBox = New System.Windows.Forms.TextBox
        Me.FechaConstEmpreDateTimePicker = New System.Windows.Forms.DateTimePicker
        Me.DirEmpreTextBox = New System.Windows.Forms.TextBox
        Me.TelefEmpreTextBox = New System.Windows.Forms.TextBox
        Me.EmailEmpreTextBox = New System.Windows.Forms.TextBox
        Me.CodPostalEmpreTextBox = New System.Windows.Forms.TextBox
        Me.WebEmpreTextBox = New System.Windows.Forms.TextBox
        Me.LogoEmprePictureBox = New System.Windows.Forms.PictureBox
        Me.RegEmpreComboBox = New System.Windows.Forms.ComboBox
        Me.TelefaxEmpreTextBox = New System.Windows.Forms.TextBox
        Me.ObjetosocEmpreRichTextBox = New System.Windows.Forms.RichTextBox
        Me.CiudadEmpreTextBox = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TituloLbl = New System.Windows.Forms.Label
        Me.SalirBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.EditarBtn = New System.Windows.Forms.Button
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.PB = New System.Windows.Forms.PictureBox
        Me.EmpresaTableAdapter = New AgaciaSolution.BasicoDsTableAdapters.EmpresaTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
        Me.AbrirImagenOFD = New System.Windows.Forms.OpenFileDialog
        NomEmpreLabel = New System.Windows.Forms.Label
        NitEmpreLabel = New System.Windows.Forms.Label
        RepEmpreLabel = New System.Windows.Forms.Label
        FechaConstEmpreLabel = New System.Windows.Forms.Label
        DirEmpreLabel = New System.Windows.Forms.Label
        TelefEmpreLabel = New System.Windows.Forms.Label
        EmailEmpreLabel = New System.Windows.Forms.Label
        CodPostalEmpreLabel = New System.Windows.Forms.Label
        WebEmpreLabel = New System.Windows.Forms.Label
        LogoEmpreLabel = New System.Windows.Forms.Label
        RegEmpreLabel = New System.Windows.Forms.Label
        TelefaxEmpreLabel = New System.Windows.Forms.Label
        ObjetosocEmpreLabel = New System.Windows.Forms.Label
        CiudadEmpreLabel = New System.Windows.Forms.Label
        Me.InfoGB.SuspendLayout()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LogoEmprePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NomEmpreLabel
        '
        NomEmpreLabel.AutoSize = True
        NomEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        NomEmpreLabel.Location = New System.Drawing.Point(6, 61)
        NomEmpreLabel.Name = "NomEmpreLabel"
        NomEmpreLabel.Size = New System.Drawing.Size(61, 15)
        NomEmpreLabel.TabIndex = 0
        NomEmpreLabel.Text = "Nombre :"
        '
        'NitEmpreLabel
        '
        NitEmpreLabel.AutoSize = True
        NitEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NitEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        NitEmpreLabel.Location = New System.Drawing.Point(6, 110)
        NitEmpreLabel.Name = "NitEmpreLabel"
        NitEmpreLabel.Size = New System.Drawing.Size(36, 15)
        NitEmpreLabel.TabIndex = 2
        NitEmpreLabel.Text = "NIT :"
        '
        'RepEmpreLabel
        '
        RepEmpreLabel.AutoSize = True
        RepEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RepEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        RepEmpreLabel.Location = New System.Drawing.Point(6, 87)
        RepEmpreLabel.Name = "RepEmpreLabel"
        RepEmpreLabel.Size = New System.Drawing.Size(97, 15)
        RepEmpreLabel.TabIndex = 4
        RepEmpreLabel.Text = "Representante :"
        '
        'FechaConstEmpreLabel
        '
        FechaConstEmpreLabel.AutoSize = True
        FechaConstEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FechaConstEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        FechaConstEmpreLabel.Location = New System.Drawing.Point(6, 32)
        FechaConstEmpreLabel.Name = "FechaConstEmpreLabel"
        FechaConstEmpreLabel.Size = New System.Drawing.Size(140, 15)
        FechaConstEmpreLabel.TabIndex = 6
        FechaConstEmpreLabel.Text = "Fecha de Constitución :"
        '
        'DirEmpreLabel
        '
        DirEmpreLabel.AutoSize = True
        DirEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DirEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        DirEmpreLabel.Location = New System.Drawing.Point(6, 162)
        DirEmpreLabel.Name = "DirEmpreLabel"
        DirEmpreLabel.Size = New System.Drawing.Size(69, 15)
        DirEmpreLabel.TabIndex = 8
        DirEmpreLabel.Text = "Dirreción :"
        '
        'TelefEmpreLabel
        '
        TelefEmpreLabel.AutoSize = True
        TelefEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        TelefEmpreLabel.Location = New System.Drawing.Point(6, 137)
        TelefEmpreLabel.Name = "TelefEmpreLabel"
        TelefEmpreLabel.Size = New System.Drawing.Size(47, 15)
        TelefEmpreLabel.TabIndex = 10
        TelefEmpreLabel.Text = "Tel (s):"
        '
        'EmailEmpreLabel
        '
        EmailEmpreLabel.AutoSize = True
        EmailEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        EmailEmpreLabel.Location = New System.Drawing.Point(6, 212)
        EmailEmpreLabel.Name = "EmailEmpreLabel"
        EmailEmpreLabel.Size = New System.Drawing.Size(59, 15)
        EmailEmpreLabel.TabIndex = 12
        EmailEmpreLabel.Text = "E - mail :"
        '
        'CodPostalEmpreLabel
        '
        CodPostalEmpreLabel.AutoSize = True
        CodPostalEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CodPostalEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        CodPostalEmpreLabel.Location = New System.Drawing.Point(6, 187)
        CodPostalEmpreLabel.Name = "CodPostalEmpreLabel"
        CodPostalEmpreLabel.Size = New System.Drawing.Size(89, 15)
        CodPostalEmpreLabel.TabIndex = 14
        CodPostalEmpreLabel.Text = "Codigo Postal :"
        '
        'WebEmpreLabel
        '
        WebEmpreLabel.AutoSize = True
        WebEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        WebEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        WebEmpreLabel.Location = New System.Drawing.Point(6, 237)
        WebEmpreLabel.Name = "WebEmpreLabel"
        WebEmpreLabel.Size = New System.Drawing.Size(82, 15)
        WebEmpreLabel.TabIndex = 16
        WebEmpreLabel.Text = "Pagina Web :"
        '
        'LogoEmpreLabel
        '
        LogoEmpreLabel.AutoSize = True
        LogoEmpreLabel.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LogoEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        LogoEmpreLabel.Location = New System.Drawing.Point(381, 18)
        LogoEmpreLabel.Name = "LogoEmpreLabel"
        LogoEmpreLabel.Size = New System.Drawing.Size(40, 14)
        LogoEmpreLabel.TabIndex = 18
        LogoEmpreLabel.Text = "Logo :"
        '
        'RegEmpreLabel
        '
        RegEmpreLabel.AutoSize = True
        RegEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RegEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        RegEmpreLabel.Location = New System.Drawing.Point(6, 264)
        RegEmpreLabel.Name = "RegEmpreLabel"
        RegEmpreLabel.Size = New System.Drawing.Size(65, 15)
        RegEmpreLabel.TabIndex = 20
        RegEmpreLabel.Text = "Regimen :"
        '
        'TelefaxEmpreLabel
        '
        TelefaxEmpreLabel.AutoSize = True
        TelefaxEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TelefaxEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        TelefaxEmpreLabel.Location = New System.Drawing.Point(275, 136)
        TelefaxEmpreLabel.Name = "TelefaxEmpreLabel"
        TelefaxEmpreLabel.Size = New System.Drawing.Size(59, 15)
        TelefaxEmpreLabel.TabIndex = 22
        TelefaxEmpreLabel.Text = "Telefax  :"
        '
        'ObjetosocEmpreLabel
        '
        ObjetosocEmpreLabel.AutoSize = True
        ObjetosocEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ObjetosocEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        ObjetosocEmpreLabel.Location = New System.Drawing.Point(6, 291)
        ObjetosocEmpreLabel.Name = "ObjetosocEmpreLabel"
        ObjetosocEmpreLabel.Size = New System.Drawing.Size(88, 15)
        ObjetosocEmpreLabel.TabIndex = 24
        ObjetosocEmpreLabel.Text = "Objeto Social :"
        '
        'CiudadEmpreLabel
        '
        CiudadEmpreLabel.AutoSize = True
        CiudadEmpreLabel.Font = New System.Drawing.Font("Georgia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CiudadEmpreLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        CiudadEmpreLabel.Location = New System.Drawing.Point(275, 161)
        CiudadEmpreLabel.Name = "CiudadEmpreLabel"
        CiudadEmpreLabel.Size = New System.Drawing.Size(55, 15)
        CiudadEmpreLabel.TabIndex = 26
        CiudadEmpreLabel.Text = "Ciudad :"
        '
        'InfoGB
        '
        Me.InfoGB.Controls.Add(Me.NomEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.NitEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.RepEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.FechaConstEmpreDateTimePicker)
        Me.InfoGB.Controls.Add(Me.DirEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.TelefEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.EmailEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.CodPostalEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.WebEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.LogoEmprePictureBox)
        Me.InfoGB.Controls.Add(Me.RegEmpreComboBox)
        Me.InfoGB.Controls.Add(Me.TelefaxEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.ObjetosocEmpreRichTextBox)
        Me.InfoGB.Controls.Add(Me.CiudadEmpreTextBox)
        Me.InfoGB.Controls.Add(Me.Button1)
        Me.InfoGB.Controls.Add(NomEmpreLabel)
        Me.InfoGB.Controls.Add(NitEmpreLabel)
        Me.InfoGB.Controls.Add(RepEmpreLabel)
        Me.InfoGB.Controls.Add(FechaConstEmpreLabel)
        Me.InfoGB.Controls.Add(DirEmpreLabel)
        Me.InfoGB.Controls.Add(TelefEmpreLabel)
        Me.InfoGB.Controls.Add(EmailEmpreLabel)
        Me.InfoGB.Controls.Add(CodPostalEmpreLabel)
        Me.InfoGB.Controls.Add(WebEmpreLabel)
        Me.InfoGB.Controls.Add(LogoEmpreLabel)
        Me.InfoGB.Controls.Add(RegEmpreLabel)
        Me.InfoGB.Controls.Add(TelefaxEmpreLabel)
        Me.InfoGB.Controls.Add(ObjetosocEmpreLabel)
        Me.InfoGB.Controls.Add(CiudadEmpreLabel)
        Me.InfoGB.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoGB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InfoGB.Location = New System.Drawing.Point(17, 127)
        Me.InfoGB.Name = "InfoGB"
        Me.InfoGB.Size = New System.Drawing.Size(509, 436)
        Me.InfoGB.TabIndex = 43
        Me.InfoGB.TabStop = False
        Me.InfoGB.Text = "Información Empresa"
        '
        'NomEmpreTextBox
        '
        Me.NomEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "NomEmpre", True))
        Me.NomEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomEmpreTextBox.Location = New System.Drawing.Point(100, 53)
        Me.NomEmpreTextBox.Name = "NomEmpreTextBox"
        Me.NomEmpreTextBox.Size = New System.Drawing.Size(259, 22)
        Me.NomEmpreTextBox.TabIndex = 29
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "Empresa"
        Me.EmpresaBindingSource.DataSource = Me.BasicoDs
        '
        'BasicoDs
        '
        Me.BasicoDs.DataSetName = "BasicoDs"
        Me.BasicoDs.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NitEmpreTextBox
        '
        Me.NitEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "NitEmpre", True))
        Me.NitEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NitEmpreTextBox.Location = New System.Drawing.Point(100, 102)
        Me.NitEmpreTextBox.Name = "NitEmpreTextBox"
        Me.NitEmpreTextBox.Size = New System.Drawing.Size(174, 22)
        Me.NitEmpreTextBox.TabIndex = 31
        '
        'RepEmpreTextBox
        '
        Me.RepEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "RepEmpre", True))
        Me.RepEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RepEmpreTextBox.Location = New System.Drawing.Point(100, 77)
        Me.RepEmpreTextBox.Name = "RepEmpreTextBox"
        Me.RepEmpreTextBox.Size = New System.Drawing.Size(259, 22)
        Me.RepEmpreTextBox.TabIndex = 33
        '
        'FechaConstEmpreDateTimePicker
        '
        Me.FechaConstEmpreDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.EmpresaBindingSource, "FechaConstEmpre", True))
        Me.FechaConstEmpreDateTimePicker.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FechaConstEmpreDateTimePicker.Location = New System.Drawing.Point(145, 29)
        Me.FechaConstEmpreDateTimePicker.Name = "FechaConstEmpreDateTimePicker"
        Me.FechaConstEmpreDateTimePicker.Size = New System.Drawing.Size(233, 22)
        Me.FechaConstEmpreDateTimePicker.TabIndex = 35
        '
        'DirEmpreTextBox
        '
        Me.DirEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "DirEmpre", True))
        Me.DirEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DirEmpreTextBox.Location = New System.Drawing.Point(100, 151)
        Me.DirEmpreTextBox.Name = "DirEmpreTextBox"
        Me.DirEmpreTextBox.Size = New System.Drawing.Size(174, 22)
        Me.DirEmpreTextBox.TabIndex = 37
        '
        'TelefEmpreTextBox
        '
        Me.TelefEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "TelefEmpre", True))
        Me.TelefEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefEmpreTextBox.Location = New System.Drawing.Point(100, 126)
        Me.TelefEmpreTextBox.Name = "TelefEmpreTextBox"
        Me.TelefEmpreTextBox.Size = New System.Drawing.Size(174, 22)
        Me.TelefEmpreTextBox.TabIndex = 39
        '
        'EmailEmpreTextBox
        '
        Me.EmailEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "EmailEmpre", True))
        Me.EmailEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailEmpreTextBox.Location = New System.Drawing.Point(100, 208)
        Me.EmailEmpreTextBox.Name = "EmailEmpreTextBox"
        Me.EmailEmpreTextBox.Size = New System.Drawing.Size(275, 22)
        Me.EmailEmpreTextBox.TabIndex = 41
        '
        'CodPostalEmpreTextBox
        '
        Me.CodPostalEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "CodPostalEmpre", True))
        Me.CodPostalEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CodPostalEmpreTextBox.Location = New System.Drawing.Point(101, 180)
        Me.CodPostalEmpreTextBox.Name = "CodPostalEmpreTextBox"
        Me.CodPostalEmpreTextBox.Size = New System.Drawing.Size(80, 22)
        Me.CodPostalEmpreTextBox.TabIndex = 43
        '
        'WebEmpreTextBox
        '
        Me.WebEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "WebEmpre", True))
        Me.WebEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WebEmpreTextBox.Location = New System.Drawing.Point(100, 233)
        Me.WebEmpreTextBox.Name = "WebEmpreTextBox"
        Me.WebEmpreTextBox.Size = New System.Drawing.Size(275, 22)
        Me.WebEmpreTextBox.TabIndex = 45
        '
        'LogoEmprePictureBox
        '
        Me.LogoEmprePictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.EmpresaBindingSource, "LogoEmpre", True))
        Me.LogoEmprePictureBox.Location = New System.Drawing.Point(384, 32)
        Me.LogoEmprePictureBox.Name = "LogoEmprePictureBox"
        Me.LogoEmprePictureBox.Size = New System.Drawing.Size(120, 93)
        Me.LogoEmprePictureBox.TabIndex = 47
        Me.LogoEmprePictureBox.TabStop = False
        '
        'RegEmpreComboBox
        '
        Me.RegEmpreComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "RegEmpre", True))
        Me.RegEmpreComboBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RegEmpreComboBox.FormattingEnabled = True
        Me.RegEmpreComboBox.Items.AddRange(New Object() {"COMUN", "SIMPLIFICADO"})
        Me.RegEmpreComboBox.Location = New System.Drawing.Point(100, 258)
        Me.RegEmpreComboBox.Name = "RegEmpreComboBox"
        Me.RegEmpreComboBox.Size = New System.Drawing.Size(200, 23)
        Me.RegEmpreComboBox.TabIndex = 49
        '
        'TelefaxEmpreTextBox
        '
        Me.TelefaxEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "TelefaxEmpre", True))
        Me.TelefaxEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelefaxEmpreTextBox.Location = New System.Drawing.Point(340, 130)
        Me.TelefaxEmpreTextBox.Name = "TelefaxEmpreTextBox"
        Me.TelefaxEmpreTextBox.Size = New System.Drawing.Size(125, 22)
        Me.TelefaxEmpreTextBox.TabIndex = 51
        '
        'ObjetosocEmpreRichTextBox
        '
        Me.ObjetosocEmpreRichTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "ObjetosocEmpre", True))
        Me.ObjetosocEmpreRichTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ObjetosocEmpreRichTextBox.Location = New System.Drawing.Point(101, 291)
        Me.ObjetosocEmpreRichTextBox.Name = "ObjetosocEmpreRichTextBox"
        Me.ObjetosocEmpreRichTextBox.Size = New System.Drawing.Size(274, 96)
        Me.ObjetosocEmpreRichTextBox.TabIndex = 53
        Me.ObjetosocEmpreRichTextBox.Text = ""
        '
        'CiudadEmpreTextBox
        '
        Me.CiudadEmpreTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpresaBindingSource, "CiudadEmpre", True))
        Me.CiudadEmpreTextBox.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CiudadEmpreTextBox.Location = New System.Drawing.Point(340, 158)
        Me.CiudadEmpreTextBox.Name = "CiudadEmpreTextBox"
        Me.CiudadEmpreTextBox.Size = New System.Drawing.Size(125, 22)
        Me.CiudadEmpreTextBox.TabIndex = 55
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(471, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(33, 28)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TituloLbl
        '
        Me.TituloLbl.AutoSize = True
        Me.TituloLbl.Font = New System.Drawing.Font("Georgia", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloLbl.ForeColor = System.Drawing.Color.DarkRed
        Me.TituloLbl.Location = New System.Drawing.Point(207, 38)
        Me.TituloLbl.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TituloLbl.Name = "TituloLbl"
        Me.TituloLbl.Size = New System.Drawing.Size(220, 49)
        Me.TituloLbl.TabIndex = 42
        Me.TituloLbl.Text = "Empresa"
        '
        'SalirBtn
        '
        Me.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SalirBtn.FlatAppearance.BorderSize = 2
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(382, 569)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Size = New System.Drawing.Size(41, 40)
        Me.SalirBtn.TabIndex = 47
        Me.SalirBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelarBtn.Enabled = False
        Me.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelarBtn.FlatAppearance.BorderSize = 2
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.Location = New System.Drawing.Point(335, 569)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(41, 40)
        Me.CancelarBtn.TabIndex = 46
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'EditarBtn
        '
        Me.EditarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.EditarBtn.FlatAppearance.BorderSize = 2
        Me.EditarBtn.Image = CType(resources.GetObject("EditarBtn.Image"), System.Drawing.Image)
        Me.EditarBtn.Location = New System.Drawing.Point(429, 569)
        Me.EditarBtn.Name = "EditarBtn"
        Me.EditarBtn.Size = New System.Drawing.Size(41, 40)
        Me.EditarBtn.TabIndex = 45
        Me.EditarBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GuardarBtn.FlatAppearance.BorderSize = 2
        Me.GuardarBtn.Image = CType(resources.GetObject("GuardarBtn.Image"), System.Drawing.Image)
        Me.GuardarBtn.Location = New System.Drawing.Point(476, 569)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(41, 41)
        Me.GuardarBtn.TabIndex = 44
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'PB
        '
        Me.PB.Image = CType(resources.GetObject("PB.Image"), System.Drawing.Image)
        Me.PB.Location = New System.Drawing.Point(65, 12)
        Me.PB.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(107, 97)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB.TabIndex = 41
        Me.PB.TabStop = False
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AbonosDxCTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DxCTableAdapter = Nothing
        Me.TableAdapterManager.DxPTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.EmpresaTableAdapter = Me.EmpresaTableAdapter
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
        'AbrirImagenOFD
        '
        Me.AbrirImagenOFD.FileName = "OpenFileDialog1"
        '
        'Empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(540, 614)
        Me.Controls.Add(Me.SalirBtn)
        Me.Controls.Add(Me.CancelarBtn)
        Me.Controls.Add(Me.EditarBtn)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.InfoGB)
        Me.Controls.Add(Me.TituloLbl)
        Me.Controls.Add(Me.PB)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Empresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Empresa"
        Me.InfoGB.ResumeLayout(False)
        Me.InfoGB.PerformLayout()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BasicoDs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LogoEmprePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SalirBtn As System.Windows.Forms.Button
    Friend WithEvents CancelarBtn As System.Windows.Forms.Button
    Friend WithEvents EditarBtn As System.Windows.Forms.Button
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents InfoGB As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Protected WithEvents TituloLbl As System.Windows.Forms.Label
    Protected WithEvents PB As System.Windows.Forms.PictureBox
    Friend WithEvents BasicoDs As AgaciaSolution.BasicoDs
    Friend WithEvents EmpresaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpresaTableAdapter As AgaciaSolution.BasicoDsTableAdapters.EmpresaTableAdapter
    Friend WithEvents TableAdapterManager As AgaciaSolution.BasicoDsTableAdapters.TableAdapterManager
    Friend WithEvents NomEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents NitEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RepEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaConstEmpreDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents DirEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents EmailEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CodPostalEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents WebEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents LogoEmprePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents RegEmpreComboBox As System.Windows.Forms.ComboBox
    Friend WithEvents TelefaxEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ObjetosocEmpreRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents CiudadEmpreTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AbrirImagenOFD As System.Windows.Forms.OpenFileDialog
End Class
