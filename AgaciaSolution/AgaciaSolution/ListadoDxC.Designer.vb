<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoDxC
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
        Me.ConsultaCobrosDataGridView = New System.Windows.Forms.DataGridView
        Me.ConsultaCobrosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AgaciaBDDataSet1 = New AgaciaSolution.AgaciaBDDataSet1
        Me.ConsultaCobrosTableAdapter = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.ConsultaCobrosTableAdapter
        Me.TableAdapterManager = New AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.ConsultaCobrosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaCobrosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ConsultaCobrosDataGridView
        '
        Me.ConsultaCobrosDataGridView.AllowUserToAddRows = False
        Me.ConsultaCobrosDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Linen
        Me.ConsultaCobrosDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.ConsultaCobrosDataGridView.AutoGenerateColumns = False
        Me.ConsultaCobrosDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.ConsultaCobrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultaCobrosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.ConsultaCobrosDataGridView.DataSource = Me.ConsultaCobrosBindingSource
        Me.ConsultaCobrosDataGridView.Location = New System.Drawing.Point(0, 58)
        Me.ConsultaCobrosDataGridView.Name = "ConsultaCobrosDataGridView"
        Me.ConsultaCobrosDataGridView.ReadOnly = True
        Me.ConsultaCobrosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ConsultaCobrosDataGridView.Size = New System.Drawing.Size(738, 231)
        Me.ConsultaCobrosDataGridView.TabIndex = 2
        '
        'ConsultaCobrosBindingSource
        '
        Me.ConsultaCobrosBindingSource.DataMember = "ConsultaCobros"
        Me.ConsultaCobrosBindingSource.DataSource = Me.AgaciaBDDataSet1
        '
        'AgaciaBDDataSet1
        '
        Me.AgaciaBDDataSet1.DataSetName = "AgaciaBDDataSet1"
        Me.AgaciaBDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsultaCobrosTableAdapter
        '
        Me.ConsultaCobrosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DxCTableAdapter = Nothing
        Me.TableAdapterManager.FacturasTableAdapter = Nothing
        Me.TableAdapterManager.LineaFacturaTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdClie"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id Cliente"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NomClie"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 170
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdDxC"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Codigo DxC"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 80
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdFact"
        Me.DataGridViewTextBoxColumn4.HeaderText = "N° factura"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 80
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "FechaFact"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Fecha Factura"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "FechaVencFacDxC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Fecha de Vencimiento"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "TOTAL_FACTURA"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Total factura"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Georgia", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(94, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(581, 38)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Listado de documentos por cobrar"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(736, 289)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConsultaCobrosDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista Facturas Por Cobrar"
        CType(Me.ConsultaCobrosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaCobrosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AgaciaBDDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AgaciaBDDataSet1 As AgaciaSolution.AgaciaBDDataSet1
    Friend WithEvents ConsultaCobrosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ConsultaCobrosTableAdapter As AgaciaSolution.AgaciaBDDataSet1TableAdapters.ConsultaCobrosTableAdapter
    Friend WithEvents TableAdapterManager As AgaciaSolution.AgaciaBDDataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ConsultaCobrosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
