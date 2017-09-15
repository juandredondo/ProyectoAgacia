<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificarCanped
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
        Me.cancelar = New System.Windows.Forms.Button
        Me.aceptar = New System.Windows.Forms.Button
        Me.codmod = New System.Windows.Forms.TextBox
        Me.promod = New System.Windows.Forms.TextBox
        Me.cantidad = New System.Windows.Forms.TextBox
        Me.itemmod = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(215, 158)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cancelar.TabIndex = 28
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(115, 158)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(75, 23)
        Me.aceptar.TabIndex = 27
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'codmod
        '
        Me.codmod.Enabled = False
        Me.codmod.Location = New System.Drawing.Point(84, 50)
        Me.codmod.Name = "codmod"
        Me.codmod.Size = New System.Drawing.Size(74, 20)
        Me.codmod.TabIndex = 26
        '
        'promod
        '
        Me.promod.Enabled = False
        Me.promod.Location = New System.Drawing.Point(84, 84)
        Me.promod.Name = "promod"
        Me.promod.Size = New System.Drawing.Size(210, 20)
        Me.promod.TabIndex = 25
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(85, 113)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(52, 20)
        Me.cantidad.TabIndex = 24
        '
        'itemmod
        '
        Me.itemmod.Enabled = False
        Me.itemmod.Location = New System.Drawing.Point(84, 14)
        Me.itemmod.Name = "itemmod"
        Me.itemmod.Size = New System.Drawing.Size(52, 20)
        Me.itemmod.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 53)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Código"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Producto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Cantidad"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Ítem "
        '
        'ModificarCanped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 189)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.codmod)
        Me.Controls.Add(Me.promod)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.itemmod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificarCanped"
        Me.Text = "ModificarCanped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cancelar As System.Windows.Forms.Button
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents codmod As System.Windows.Forms.TextBox
    Friend WithEvents promod As System.Windows.Forms.TextBox
    Friend WithEvents cantidad As System.Windows.Forms.TextBox
    Friend WithEvents itemmod As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
