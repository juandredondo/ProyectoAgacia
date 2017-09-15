<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarPedidos
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.FillToolStrip = New System.Windows.Forms.ToolStrip
        Me.NomProvToolStripLabel = New System.Windows.Forms.ToolStripLabel
        Me.NomProvToolStripTextBox = New System.Windows.Forms.ToolStripTextBox
        Me.FillToolStripButton = New System.Windows.Forms.ToolStripButton
        Me.BuscarPedidosDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BuscarPedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BuscarDSDataSet = New AgaciaSolution.BuscarDSDataSet
        Me.BuscarPedidosTableAdapter = New AgaciaSolution.BuscarDSDataSetTableAdapters.BuscarPedidosTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.BuscarDSDataSetTableAdapters.TableAdapterManager
        Me.FillToolStrip.SuspendLayout()
        CType(Me.BuscarPedidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarPedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BuscarDSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FillToolStrip
        '
        Me.FillToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomProvToolStripLabel, Me.NomProvToolStripTextBox, Me.FillToolStripButton})
        Me.FillToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillToolStrip.Name = "FillToolStrip"
        Me.FillToolStrip.Size = New System.Drawing.Size(646, 25)
        Me.FillToolStrip.TabIndex = 1
        Me.FillToolStrip.Text = "FillToolStrip"
        '
        'NomProvToolStripLabel
        '
        Me.NomProvToolStripLabel.Name = "NomProvToolStripLabel"
        Me.NomProvToolStripLabel.Size = New System.Drawing.Size(242, 22)
        Me.NomProvToolStripLabel.Text = "Digite el nombre del proveedor o parte de el:"
        '
        'NomProvToolStripTextBox
        '
        Me.NomProvToolStripTextBox.Name = "NomProvToolStripTextBox"
        Me.NomProvToolStripTextBox.Size = New System.Drawing.Size(250, 25)
        '
        'FillToolStripButton
        '
        Me.FillToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillToolStripButton.Name = "FillToolStripButton"
        Me.FillToolStripButton.Size = New System.Drawing.Size(26, 22)
        Me.FillToolStripButton.Text = "Fill"
        Me.FillToolStripButton.Visible = False
        '
        'BuscarPedidosDataGridView
        '
        Me.BuscarPedidosDataGridView.AllowUserToAddRows = False
        Me.BuscarPedidosDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        Me.BuscarPedidosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.BuscarPedidosDataGridView.AutoGenerateColumns = False
        Me.BuscarPedidosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BuscarPedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BuscarPedidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.BuscarPedidosDataGridView.DataSource = Me.BuscarPedidosBindingSource
        Me.BuscarPedidosDataGridView.Location = New System.Drawing.Point(0, 61)
        Me.BuscarPedidosDataGridView.Name = "BuscarPedidosDataGridView"
        Me.BuscarPedidosDataGridView.ReadOnly = True
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuscarPedidosDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.BuscarPedidosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.BuscarPedidosDataGridView.Size = New System.Drawing.Size(646, 220)
        Me.BuscarPedidosDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "NomProv"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Proveedor"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "DirProv"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "TelefProv"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CiudadProv"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ciudad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "IdPed"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Pedido N°"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FechaPed"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha de pedido"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'BuscarPedidosBindingSource
        '
        Me.BuscarPedidosBindingSource.DataMember = "BuscarPedidos"
        Me.BuscarPedidosBindingSource.DataSource = Me.BuscarDSDataSet
        '
        'BuscarDSDataSet
        '
        Me.BuscarDSDataSet.DataSetName = "BuscarDSDataSet"
        Me.BuscarDSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BuscarPedidosTableAdapter
        '
        Me.BuscarPedidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = AgaciaSolution.BuscarDSDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuscarPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 309)
        Me.Controls.Add(Me.BuscarPedidosDataGridView)
        Me.Controls.Add(Me.FillToolStrip)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "BuscarPedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarPedidos"
        Me.FillToolStrip.ResumeLayout(False)
        Me.FillToolStrip.PerformLayout()
        CType(Me.BuscarPedidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarPedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BuscarDSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BuscarDSDataSet As AgaciaSolution.BuscarDSDataSet
    Friend WithEvents BuscarPedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents BuscarPedidosTableAdapter As AgaciaSolution.BuscarDSDataSetTableAdapters.BuscarPedidosTableAdapter
    Friend WithEvents TableAdapterManager As AgaciaSolution.BuscarDSDataSetTableAdapters.TableAdapterManager
    Friend WithEvents FillToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents NomProvToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents NomProvToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents BuscarPedidosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
