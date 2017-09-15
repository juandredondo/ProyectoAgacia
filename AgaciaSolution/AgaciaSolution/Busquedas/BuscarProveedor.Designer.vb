<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProveedor
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextoCB = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CriterioCB = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.NITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMBREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DIRECCIONDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TELEFONODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CIUDADDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CONTACTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TELEFONODELCONTACTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TIPODECUENTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NUMERODELACUENTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NOMBREDELBANCODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TITULARDELACUENTADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BuscarPROVEEDORESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarDSDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarDSDataSet = New AgaciaSolution.BuscarDSDataSet
        Me.BuscarPROVEEDORESTableAdapter = New AgaciaSolution.BuscarDSDataSetTableAdapters.BuscarPROVEEDORESTableAdapter
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarPROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarDSDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextoCB)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CriterioCB)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(19, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(843, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterio de Búsqueda"
        '
        'TextoCB
        '
        Me.TextoCB.Location = New System.Drawing.Point(416, 45)
        Me.TextoCB.Name = "TextoCB"
        Me.TextoCB.Size = New System.Drawing.Size(347, 22)
        Me.TextoCB.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(313, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Con el texto"
        '
        'CriterioCB
        '
        Me.CriterioCB.FormattingEnabled = True
        Me.CriterioCB.Items.AddRange(New Object() {"NIT", "NOMBRE", "CIUDAD", "CONTACTO"})
        Me.CriterioCB.Location = New System.Drawing.Point(116, 45)
        Me.CriterioCB.Name = "CriterioCB"
        Me.CriterioCB.Size = New System.Drawing.Size(180, 24)
        Me.CriterioCB.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(12, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar por:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 147)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(853, 268)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resultados de la búsqueda"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Window
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NITDataGridViewTextBoxColumn, Me.NOMBREDataGridViewTextBoxColumn, Me.DIRECCIONDataGridViewTextBoxColumn, Me.TELEFONODataGridViewTextBoxColumn, Me.CIUDADDataGridViewTextBoxColumn, Me.CONTACTODataGridViewTextBoxColumn, Me.TELEFONODELCONTACTODataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.TIPODECUENTADataGridViewTextBoxColumn, Me.NUMERODELACUENTADataGridViewTextBoxColumn, Me.NOMBREDELBANCODataGridViewTextBoxColumn, Me.TITULARDELACUENTADataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BuscarPROVEEDORESBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 18)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(847, 247)
        Me.DataGridView1.TabIndex = 0
        '
        'NITDataGridViewTextBoxColumn
        '
        Me.NITDataGridViewTextBoxColumn.DataPropertyName = "NIT"
        Me.NITDataGridViewTextBoxColumn.HeaderText = "NIT"
        Me.NITDataGridViewTextBoxColumn.Name = "NITDataGridViewTextBoxColumn"
        Me.NITDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDataGridViewTextBoxColumn
        '
        Me.NOMBREDataGridViewTextBoxColumn.DataPropertyName = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.HeaderText = "NOMBRE"
        Me.NOMBREDataGridViewTextBoxColumn.Name = "NOMBREDataGridViewTextBoxColumn"
        Me.NOMBREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DIRECCIONDataGridViewTextBoxColumn
        '
        Me.DIRECCIONDataGridViewTextBoxColumn.DataPropertyName = "DIRECCION"
        Me.DIRECCIONDataGridViewTextBoxColumn.HeaderText = "DIRECCION"
        Me.DIRECCIONDataGridViewTextBoxColumn.Name = "DIRECCIONDataGridViewTextBoxColumn"
        Me.DIRECCIONDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TELEFONODataGridViewTextBoxColumn
        '
        Me.TELEFONODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn.HeaderText = "TELEFONO"
        Me.TELEFONODataGridViewTextBoxColumn.Name = "TELEFONODataGridViewTextBoxColumn"
        Me.TELEFONODataGridViewTextBoxColumn.ReadOnly = True
        '
        'CIUDADDataGridViewTextBoxColumn
        '
        Me.CIUDADDataGridViewTextBoxColumn.DataPropertyName = "CIUDAD"
        Me.CIUDADDataGridViewTextBoxColumn.HeaderText = "CIUDAD"
        Me.CIUDADDataGridViewTextBoxColumn.Name = "CIUDADDataGridViewTextBoxColumn"
        Me.CIUDADDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CONTACTODataGridViewTextBoxColumn
        '
        Me.CONTACTODataGridViewTextBoxColumn.DataPropertyName = "CONTACTO"
        Me.CONTACTODataGridViewTextBoxColumn.HeaderText = "CONTACTO"
        Me.CONTACTODataGridViewTextBoxColumn.Name = "CONTACTODataGridViewTextBoxColumn"
        Me.CONTACTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TELEFONODELCONTACTODataGridViewTextBoxColumn
        '
        Me.TELEFONODELCONTACTODataGridViewTextBoxColumn.DataPropertyName = "TELEFONO DEL CONTACTO"
        Me.TELEFONODELCONTACTODataGridViewTextBoxColumn.HeaderText = "TELEFONO DEL CONTACTO"
        Me.TELEFONODELCONTACTODataGridViewTextBoxColumn.Name = "TELEFONODELCONTACTODataGridViewTextBoxColumn"
        Me.TELEFONODELCONTACTODataGridViewTextBoxColumn.ReadOnly = True
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "E-MAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "E-MAIL"
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TIPODECUENTADataGridViewTextBoxColumn
        '
        Me.TIPODECUENTADataGridViewTextBoxColumn.DataPropertyName = "TIPO DE CUENTA"
        Me.TIPODECUENTADataGridViewTextBoxColumn.HeaderText = "TIPO DE CUENTA"
        Me.TIPODECUENTADataGridViewTextBoxColumn.Name = "TIPODECUENTADataGridViewTextBoxColumn"
        Me.TIPODECUENTADataGridViewTextBoxColumn.ReadOnly = True
        '
        'NUMERODELACUENTADataGridViewTextBoxColumn
        '
        Me.NUMERODELACUENTADataGridViewTextBoxColumn.DataPropertyName = "NUMERO DE LA CUENTA"
        Me.NUMERODELACUENTADataGridViewTextBoxColumn.HeaderText = "NUMERO DE LA CUENTA"
        Me.NUMERODELACUENTADataGridViewTextBoxColumn.Name = "NUMERODELACUENTADataGridViewTextBoxColumn"
        Me.NUMERODELACUENTADataGridViewTextBoxColumn.ReadOnly = True
        '
        'NOMBREDELBANCODataGridViewTextBoxColumn
        '
        Me.NOMBREDELBANCODataGridViewTextBoxColumn.DataPropertyName = "NOMBRE DEL BANCO"
        Me.NOMBREDELBANCODataGridViewTextBoxColumn.HeaderText = "NOMBRE DEL BANCO"
        Me.NOMBREDELBANCODataGridViewTextBoxColumn.Name = "NOMBREDELBANCODataGridViewTextBoxColumn"
        Me.NOMBREDELBANCODataGridViewTextBoxColumn.ReadOnly = True
        '
        'TITULARDELACUENTADataGridViewTextBoxColumn
        '
        Me.TITULARDELACUENTADataGridViewTextBoxColumn.DataPropertyName = "TITULAR DE LA CUENTA"
        Me.TITULARDELACUENTADataGridViewTextBoxColumn.HeaderText = "TITULAR DE LA CUENTA"
        Me.TITULARDELACUENTADataGridViewTextBoxColumn.Name = "TITULARDELACUENTADataGridViewTextBoxColumn"
        Me.TITULARDELACUENTADataGridViewTextBoxColumn.ReadOnly = True
        '
        'BuscarPROVEEDORESBindingSource
        '
        Me.BuscarPROVEEDORESBindingSource.DataMember = "BuscarPROVEEDORES"
        Me.BuscarPROVEEDORESBindingSource.DataSource = Me.BuscarDSDataSetBindingSource
        '
        'BuscarDSDataSetBindingSource
        '
        Me.BuscarDSDataSetBindingSource.DataSource = Me.BuscarDSDataSet
        Me.BuscarDSDataSetBindingSource.Position = 0
        '
        'BuscarDSDataSet
        '
        Me.BuscarDSDataSet.DataSetName = "BuscarDSDataSet"
        Me.BuscarDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscarPROVEEDORESTableAdapter
        '
        Me.BuscarPROVEEDORESTableAdapter.ClearBeforeFill = True
        '
        'BuscarProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(895, 434)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "BuscarProveedor"
        Me.Text = "Buscar Proveedor"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarPROVEEDORESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarDSDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BuscarDSDataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuscarDSDataSet As AgaciaSolution.BuscarDSDataSet
    Friend WithEvents BuscarPROVEEDORESBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuscarPROVEEDORESTableAdapter As AgaciaSolution.BuscarDSDataSetTableAdapters.BuscarPROVEEDORESTableAdapter
    Friend WithEvents NITDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DIRECCIONDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEFONODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIUDADDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CONTACTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TELEFONODELCONTACTODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TIPODECUENTADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NUMERODELACUENTADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOMBREDELBANCODataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TITULARDELACUENTADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Protected WithEvents TextoCB As System.Windows.Forms.TextBox
    Protected WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Protected WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents CriterioCB As System.Windows.Forms.ComboBox
End Class
