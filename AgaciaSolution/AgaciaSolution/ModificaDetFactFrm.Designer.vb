<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ModificaDetFactFrm
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.itemmod = New System.Windows.Forms.TextBox
        Me.cantidad = New System.Windows.Forms.TextBox
        Me.promod = New System.Windows.Forms.TextBox
        Me.codmod = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.existemod = New System.Windows.Forms.TextBox
        Me.aceptar = New System.Windows.Forms.Button
        Me.cancelar = New System.Windows.Forms.Button
        Me.vrunit = New System.Windows.Forms.TextBox
        Me.label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ítem "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 152)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Cantidad"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Producto:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(24, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Código"
        '
        'itemmod
        '
        Me.itemmod.Enabled = False
        Me.itemmod.Location = New System.Drawing.Point(96, 20)
        Me.itemmod.Name = "itemmod"
        Me.itemmod.Size = New System.Drawing.Size(52, 20)
        Me.itemmod.TabIndex = 7
        '
        'cantidad
        '
        Me.cantidad.Location = New System.Drawing.Point(97, 149)
        Me.cantidad.Name = "cantidad"
        Me.cantidad.Size = New System.Drawing.Size(52, 20)
        Me.cantidad.TabIndex = 10
        '
        'promod
        '
        Me.promod.Enabled = False
        Me.promod.Location = New System.Drawing.Point(96, 90)
        Me.promod.Name = "promod"
        Me.promod.Size = New System.Drawing.Size(210, 20)
        Me.promod.TabIndex = 11
        '
        'codmod
        '
        Me.codmod.Enabled = False
        Me.codmod.Location = New System.Drawing.Point(96, 56)
        Me.codmod.Name = "codmod"
        Me.codmod.Size = New System.Drawing.Size(74, 20)
        Me.codmod.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Existencia:"
        '
        'existemod
        '
        Me.existemod.Enabled = False
        Me.existemod.Location = New System.Drawing.Point(96, 179)
        Me.existemod.Name = "existemod"
        Me.existemod.Size = New System.Drawing.Size(74, 20)
        Me.existemod.TabIndex = 9
        '
        'aceptar
        '
        Me.aceptar.Location = New System.Drawing.Point(131, 226)
        Me.aceptar.Name = "aceptar"
        Me.aceptar.Size = New System.Drawing.Size(75, 23)
        Me.aceptar.TabIndex = 13
        Me.aceptar.Text = "Aceptar"
        Me.aceptar.UseVisualStyleBackColor = True
        '
        'cancelar
        '
        Me.cancelar.Location = New System.Drawing.Point(231, 226)
        Me.cancelar.Name = "cancelar"
        Me.cancelar.Size = New System.Drawing.Size(75, 23)
        Me.cancelar.TabIndex = 14
        Me.cancelar.Text = "Cancelar"
        Me.cancelar.UseVisualStyleBackColor = True
        '
        'vrunit
        '
        Me.vrunit.Enabled = False
        Me.vrunit.Location = New System.Drawing.Point(97, 120)
        Me.vrunit.Name = "vrunit"
        Me.vrunit.Size = New System.Drawing.Size(109, 20)
        Me.vrunit.TabIndex = 16
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(25, 123)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(57, 13)
        Me.label2.TabIndex = 15
        Me.label2.Text = "Vr unitario:"
        '
        'ModificaDetFactFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(325, 261)
        Me.Controls.Add(Me.vrunit)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.cancelar)
        Me.Controls.Add(Me.aceptar)
        Me.Controls.Add(Me.codmod)
        Me.Controls.Add(Me.promod)
        Me.Controls.Add(Me.cantidad)
        Me.Controls.Add(Me.existemod)
        Me.Controls.Add(Me.itemmod)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ModificaDetFactFrm"
        Me.Text = "ModificaDetFactFrm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents itemmod As System.Windows.Forms.TextBox
    Friend WithEvents cantidad As System.Windows.Forms.TextBox
    Friend WithEvents promod As System.Windows.Forms.TextBox
    Friend WithEvents codmod As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents existemod As System.Windows.Forms.TextBox
    Friend WithEvents aceptar As System.Windows.Forms.Button
    Friend WithEvents cancelar As System.Windows.Forms.Button
    Friend WithEvents vrunit As System.Windows.Forms.TextBox
    Friend WithEvents label2 As System.Windows.Forms.Label
End Class
