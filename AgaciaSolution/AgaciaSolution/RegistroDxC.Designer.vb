<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistroDxC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegistroDxC))
        Me.Label1 = New System.Windows.Forms.Label
        Me.IdDXCTB = New System.Windows.Forms.TextBox
        Me.DxCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgaciaBDDataSet1 = New AgaciaSolution.AgaciaBDDataSet1
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.MontoTotalTB = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.IdfactTB = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DireClienteTB = New System.Windows.Forms.TextBox
        Me.DireClienteLbl = New System.Windows.Forms.Label
        Me.TelClienteTB = New System.Windows.Forms.TextBox
        Me.TelClienteLbl = New System.Windows.Forms.Label
        Me.NomClienteTB = New System.Windows.Forms.TextBox
        Me.NomClienteLbl = New System.Windows.Forms.Label
        Me.IdClie = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.DxCTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.DxCTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager
        Me.MaxDxCTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.MaxDxCTableAdapter
        Me.MaxDxCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.DxCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MaxDxCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label1.Location = New System.Drawing.Point(15, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de Cobro:"
        '
        'IdDXCTB
        '
        Me.IdDXCTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DxCBindingSource, "IdDxC", True))
        Me.IdDXCTB.Enabled = False
        Me.IdDXCTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdDXCTB.Location = New System.Drawing.Point(132, 28)
        Me.IdDXCTB.Name = "IdDXCTB"
        Me.IdDXCTB.Size = New System.Drawing.Size(87, 21)
        Me.IdDXCTB.TabIndex = 1
        '
        'DxCBindingSource
        '
        Me.DxCBindingSource.DataMember = "DxC"
        Me.DxCBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'AgaciaBDDataSet1
        '
        Me.AgaciaBDDataSet1.DataSetName = "AgaciaBDDataSet1"
        Me.AgaciaBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.IdDXCTB)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(323, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(235, 74)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.MontoTotalTB)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.IdfactTB)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox2.Location = New System.Drawing.Point(21, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(535, 112)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Información de la Factura"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DxCBindingSource, "FechaVencFacDxC", True))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(191, 57)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(245, 21)
        Me.DateTimePicker1.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(16, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(147, 14)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fecha Limite de Pago:"
        '
        'MontoTotalTB
        '
        Me.MontoTotalTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DxCBindingSource, "TotalCargoDxC", True))
        Me.MontoTotalTB.Enabled = False
        Me.MontoTotalTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MontoTotalTB.Location = New System.Drawing.Point(309, 29)
        Me.MontoTotalTB.Name = "MontoTotalTB"
        Me.MontoTotalTB.Size = New System.Drawing.Size(127, 21)
        Me.MontoTotalTB.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(218, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 14)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monto Total "
        '
        'IdfactTB
        '
        Me.IdfactTB.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DxCBindingSource, "IdFactDXC", True))
        Me.IdfactTB.Enabled = False
        Me.IdfactTB.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdfactTB.Location = New System.Drawing.Point(102, 29)
        Me.IdfactTB.Name = "IdfactTB"
        Me.IdfactTB.Size = New System.Drawing.Size(100, 21)
        Me.IdfactTB.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(16, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 14)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Factura N° "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.DireClienteTB)
        Me.GroupBox3.Controls.Add(Me.DireClienteLbl)
        Me.GroupBox3.Controls.Add(Me.TelClienteTB)
        Me.GroupBox3.Controls.Add(Me.TelClienteLbl)
        Me.GroupBox3.Controls.Add(Me.NomClienteTB)
        Me.GroupBox3.Controls.Add(Me.NomClienteLbl)
        Me.GroupBox3.Controls.Add(Me.IdClie)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GroupBox3.Location = New System.Drawing.Point(21, 209)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(535, 128)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Información del Cliente"
        '
        'DireClienteTB
        '
        Me.DireClienteTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.DireClienteTB.Enabled = False
        Me.DireClienteTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireClienteTB.Location = New System.Drawing.Point(102, 86)
        Me.DireClienteTB.Name = "DireClienteTB"
        Me.DireClienteTB.Size = New System.Drawing.Size(201, 22)
        Me.DireClienteTB.TabIndex = 48
        '
        'DireClienteLbl
        '
        Me.DireClienteLbl.AutoSize = True
        Me.DireClienteLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DireClienteLbl.Location = New System.Drawing.Point(18, 94)
        Me.DireClienteLbl.Name = "DireClienteLbl"
        Me.DireClienteLbl.Size = New System.Drawing.Size(72, 14)
        Me.DireClienteLbl.TabIndex = 47
        Me.DireClienteLbl.Text = "Direccion:"
        '
        'TelClienteTB
        '
        Me.TelClienteTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TelClienteTB.Enabled = False
        Me.TelClienteTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelClienteTB.Location = New System.Drawing.Point(400, 86)
        Me.TelClienteTB.Name = "TelClienteTB"
        Me.TelClienteTB.Size = New System.Drawing.Size(103, 22)
        Me.TelClienteTB.TabIndex = 46
        '
        'TelClienteLbl
        '
        Me.TelClienteLbl.AutoSize = True
        Me.TelClienteLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TelClienteLbl.Location = New System.Drawing.Point(308, 91)
        Me.TelClienteLbl.Name = "TelClienteLbl"
        Me.TelClienteLbl.Size = New System.Drawing.Size(86, 14)
        Me.TelClienteLbl.TabIndex = 45
        Me.TelClienteLbl.Text = "Telefono (s):"
        '
        'NomClienteTB
        '
        Me.NomClienteTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.NomClienteTB.Enabled = False
        Me.NomClienteTB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomClienteTB.Location = New System.Drawing.Point(102, 58)
        Me.NomClienteTB.Name = "NomClienteTB"
        Me.NomClienteTB.Size = New System.Drawing.Size(401, 22)
        Me.NomClienteTB.TabIndex = 44
        '
        'NomClienteLbl
        '
        Me.NomClienteLbl.AutoSize = True
        Me.NomClienteLbl.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomClienteLbl.Location = New System.Drawing.Point(18, 63)
        Me.NomClienteLbl.Name = "NomClienteLbl"
        Me.NomClienteLbl.Size = New System.Drawing.Size(63, 14)
        Me.NomClienteLbl.TabIndex = 43
        Me.NomClienteLbl.Text = "Nombre:"
        '
        'IdClie
        '
        Me.IdClie.Enabled = False
        Me.IdClie.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdClie.Location = New System.Drawing.Point(102, 29)
        Me.IdClie.Name = "IdClie"
        Me.IdClie.Size = New System.Drawing.Size(100, 21)
        Me.IdClie.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Georgia", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(16, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 14)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "ID Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(27, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(116, 68)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 47
        Me.PictureBox1.TabStop = False
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GuardarBtn.FlatAppearance.BorderSize = 2
        Me.GuardarBtn.Image = CType(resources.GetObject("GuardarBtn.Image"), System.Drawing.Image)
        Me.GuardarBtn.Location = New System.Drawing.Point(511, 343)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(45, 44)
        Me.GuardarBtn.TabIndex = 48
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'DxCTableAdapter
        '
        Me.DxCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.DxCTableAdapter = Me.DxCTableAdapter
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.LineaFacturaTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'MaxDxCTableAdapter
        '
        Me.MaxDxCTableAdapter.ClearBeforeFill = True
        '
        'MaxDxCBindingSource
        '
        Me.MaxDxCBindingSource.DataMember = "MaxDxC"
        Me.MaxDxCBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'RegistroDxC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(577, 394)
        Me.Controls.Add(Me.GuardarBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RegistroDxC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistroDxC"
        CType(Me.DxCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MaxDxCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents IdDXCTB As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents IdfactTB As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MontoTotalTB As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents IdClie As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DireClienteTB As System.Windows.Forms.TextBox
    Friend WithEvents DireClienteLbl As System.Windows.Forms.Label
    Friend WithEvents TelClienteTB As System.Windows.Forms.TextBox
    Friend WithEvents TelClienteLbl As System.Windows.Forms.Label
    Friend WithEvents NomClienteTB As System.Windows.Forms.TextBox
    Friend WithEvents NomClienteLbl As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GuardarBtn As System.Windows.Forms.Button
    Friend WithEvents AgaciaBDDataSet1 As AgaciaSolution.AgaciaBDDataSet1
    Friend WithEvents DxCBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DxCTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.DxCTableAdapter
    Friend WithEvents TableAdapterManager As AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents MaxDxCTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.MaxDxCTableAdapter
    Friend WithEvents MaxDxCBindingSource As System.Windows.Forms.BindingSource
End Class
