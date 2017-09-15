<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Plantilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Plantilla))
        Me.InicioBtn = New System.Windows.Forms.Button
        Me.AnteriorBtn = New System.Windows.Forms.Button
        Me.SiguienteBtn = New System.Windows.Forms.Button
        Me.FinBtn = New System.Windows.Forms.Button
        Me.TituloLbl = New System.Windows.Forms.Label
        Me.PB = New System.Windows.Forms.PictureBox
        Me.BotonesGB = New System.Windows.Forms.GroupBox
        Me.SalirBtn = New System.Windows.Forms.Button
        Me.BuscarBtn = New System.Windows.Forms.Button
        Me.CancelarBtn = New System.Windows.Forms.Button
        Me.NuevoBtn = New System.Windows.Forms.Button
        Me.EliminarBtn = New System.Windows.Forms.Button
        Me.EditarBtn = New System.Windows.Forms.Button
        Me.GuardarBtn = New System.Windows.Forms.Button
        Me.InfoGB = New System.Windows.Forms.GroupBox
        CType(Me.PB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BotonesGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'InicioBtn
        '
        Me.InicioBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.InicioBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InicioBtn.FlatAppearance.BorderSize = 2
        Me.InicioBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.InicioBtn.Image = CType(resources.GetObject("InicioBtn.Image"), System.Drawing.Image)
        Me.InicioBtn.Location = New System.Drawing.Point(426, 526)
        Me.InicioBtn.Name = "InicioBtn"
        Me.InicioBtn.Size = New System.Drawing.Size(34, 33)
        Me.InicioBtn.TabIndex = 26
        Me.InicioBtn.UseVisualStyleBackColor = True
        '
        'AnteriorBtn
        '
        Me.AnteriorBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AnteriorBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.AnteriorBtn.FlatAppearance.BorderSize = 2
        Me.AnteriorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AnteriorBtn.Image = CType(resources.GetObject("AnteriorBtn.Image"), System.Drawing.Image)
        Me.AnteriorBtn.Location = New System.Drawing.Point(466, 526)
        Me.AnteriorBtn.Name = "AnteriorBtn"
        Me.AnteriorBtn.Size = New System.Drawing.Size(33, 33)
        Me.AnteriorBtn.TabIndex = 25
        Me.AnteriorBtn.UseVisualStyleBackColor = True
        '
        'SiguienteBtn
        '
        Me.SiguienteBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SiguienteBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SiguienteBtn.FlatAppearance.BorderSize = 2
        Me.SiguienteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SiguienteBtn.Image = CType(resources.GetObject("SiguienteBtn.Image"), System.Drawing.Image)
        Me.SiguienteBtn.Location = New System.Drawing.Point(505, 525)
        Me.SiguienteBtn.Name = "SiguienteBtn"
        Me.SiguienteBtn.Size = New System.Drawing.Size(32, 34)
        Me.SiguienteBtn.TabIndex = 20
        Me.SiguienteBtn.UseVisualStyleBackColor = True
        '
        'FinBtn
        '
        Me.FinBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FinBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.FinBtn.FlatAppearance.BorderSize = 2
        Me.FinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.FinBtn.Image = CType(resources.GetObject("FinBtn.Image"), System.Drawing.Image)
        Me.FinBtn.Location = New System.Drawing.Point(543, 525)
        Me.FinBtn.Name = "FinBtn"
        Me.FinBtn.Size = New System.Drawing.Size(34, 34)
        Me.FinBtn.TabIndex = 19
        Me.FinBtn.UseVisualStyleBackColor = True
        '
        'TituloLbl
        '
        Me.TituloLbl.AutoSize = True
        Me.TituloLbl.Font = New System.Drawing.Font("Georgia", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TituloLbl.ForeColor = System.Drawing.Color.RoyalBlue
        Me.TituloLbl.Location = New System.Drawing.Point(226, 59)
        Me.TituloLbl.Name = "TituloLbl"
        Me.TituloLbl.Size = New System.Drawing.Size(208, 49)
        Me.TituloLbl.TabIndex = 24
        Me.TituloLbl.Text = "Titulooo"
        '
        'PB
        '
        Me.PB.Image = CType(resources.GetObject("PB.Image"), System.Drawing.Image)
        Me.PB.Location = New System.Drawing.Point(73, 23)
        Me.PB.Name = "PB"
        Me.PB.Size = New System.Drawing.Size(134, 117)
        Me.PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PB.TabIndex = 22
        Me.PB.TabStop = False
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
        Me.BotonesGB.Location = New System.Drawing.Point(611, 163)
        Me.BotonesGB.Name = "BotonesGB"
        Me.BotonesGB.Size = New System.Drawing.Size(61, 356)
        Me.BotonesGB.TabIndex = 23
        Me.BotonesGB.TabStop = False
        '
        'SalirBtn
        '
        Me.SalirBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SalirBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.SalirBtn.FlatAppearance.BorderSize = 2
        Me.SalirBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SalirBtn.Image = CType(resources.GetObject("SalirBtn.Image"), System.Drawing.Image)
        Me.SalirBtn.Location = New System.Drawing.Point(12, 307)
        Me.SalirBtn.Name = "SalirBtn"
        Me.SalirBtn.Size = New System.Drawing.Size(40, 43)
        Me.SalirBtn.TabIndex = 10
        Me.SalirBtn.UseVisualStyleBackColor = True
        '
        'BuscarBtn
        '
        Me.BuscarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BuscarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.BuscarBtn.FlatAppearance.BorderSize = 2
        Me.BuscarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuscarBtn.Image = CType(resources.GetObject("BuscarBtn.Image"), System.Drawing.Image)
        Me.BuscarBtn.Location = New System.Drawing.Point(12, 257)
        Me.BuscarBtn.Name = "BuscarBtn"
        Me.BuscarBtn.Size = New System.Drawing.Size(40, 43)
        Me.BuscarBtn.TabIndex = 9
        Me.BuscarBtn.UseVisualStyleBackColor = True
        '
        'CancelarBtn
        '
        Me.CancelarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CancelarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.CancelarBtn.FlatAppearance.BorderSize = 2
        Me.CancelarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelarBtn.Image = CType(resources.GetObject("CancelarBtn.Image"), System.Drawing.Image)
        Me.CancelarBtn.Location = New System.Drawing.Point(12, 208)
        Me.CancelarBtn.Name = "CancelarBtn"
        Me.CancelarBtn.Size = New System.Drawing.Size(40, 43)
        Me.CancelarBtn.TabIndex = 8
        Me.CancelarBtn.UseVisualStyleBackColor = True
        '
        'NuevoBtn
        '
        Me.NuevoBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NuevoBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NuevoBtn.FlatAppearance.BorderSize = 2
        Me.NuevoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.NuevoBtn.Image = CType(resources.GetObject("NuevoBtn.Image"), System.Drawing.Image)
        Me.NuevoBtn.Location = New System.Drawing.Point(12, 10)
        Me.NuevoBtn.Name = "NuevoBtn"
        Me.NuevoBtn.Size = New System.Drawing.Size(40, 45)
        Me.NuevoBtn.TabIndex = 6
        Me.NuevoBtn.UseVisualStyleBackColor = True
        '
        'EliminarBtn
        '
        Me.EliminarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EliminarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.EliminarBtn.FlatAppearance.BorderSize = 2
        Me.EliminarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EliminarBtn.Image = CType(resources.GetObject("EliminarBtn.Image"), System.Drawing.Image)
        Me.EliminarBtn.Location = New System.Drawing.Point(12, 110)
        Me.EliminarBtn.Name = "EliminarBtn"
        Me.EliminarBtn.Size = New System.Drawing.Size(40, 43)
        Me.EliminarBtn.TabIndex = 5
        Me.EliminarBtn.UseVisualStyleBackColor = True
        '
        'EditarBtn
        '
        Me.EditarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.EditarBtn.FlatAppearance.BorderSize = 2
        Me.EditarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditarBtn.Image = CType(resources.GetObject("EditarBtn.Image"), System.Drawing.Image)
        Me.EditarBtn.Location = New System.Drawing.Point(12, 61)
        Me.EditarBtn.Name = "EditarBtn"
        Me.EditarBtn.Size = New System.Drawing.Size(40, 43)
        Me.EditarBtn.TabIndex = 4
        Me.EditarBtn.UseVisualStyleBackColor = True
        '
        'GuardarBtn
        '
        Me.GuardarBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GuardarBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.GuardarBtn.FlatAppearance.BorderSize = 2
        Me.GuardarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GuardarBtn.Image = CType(resources.GetObject("GuardarBtn.Image"), System.Drawing.Image)
        Me.GuardarBtn.Location = New System.Drawing.Point(12, 159)
        Me.GuardarBtn.Name = "GuardarBtn"
        Me.GuardarBtn.Size = New System.Drawing.Size(40, 43)
        Me.GuardarBtn.TabIndex = 3
        Me.GuardarBtn.UseVisualStyleBackColor = True
        '
        'InfoGB
        '
        Me.InfoGB.Font = New System.Drawing.Font("Georgia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InfoGB.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.InfoGB.Location = New System.Drawing.Point(27, 158)
        Me.InfoGB.Name = "InfoGB"
        Me.InfoGB.Size = New System.Drawing.Size(578, 361)
        Me.InfoGB.TabIndex = 21
        Me.InfoGB.TabStop = False
        Me.InfoGB.Text = "Informacion "
        '
        'Plantilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(673, 579)
        Me.Controls.Add(Me.InicioBtn)
        Me.Controls.Add(Me.AnteriorBtn)
        Me.Controls.Add(Me.SiguienteBtn)
        Me.Controls.Add(Me.FinBtn)
        Me.Controls.Add(Me.TituloLbl)
        Me.Controls.Add(Me.PB)
        Me.Controls.Add(Me.BotonesGB)
        Me.Controls.Add(Me.InfoGB)
        Me.MaximizeBox = False
        Me.Name = "Plantilla"
        Me.Text = "Plantilla"
        CType(Me.PB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BotonesGB.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents InicioBtn As System.Windows.Forms.Button
    Protected WithEvents AnteriorBtn As System.Windows.Forms.Button
    Protected WithEvents SiguienteBtn As System.Windows.Forms.Button
    Protected WithEvents FinBtn As System.Windows.Forms.Button
    Protected WithEvents TituloLbl As System.Windows.Forms.Label
    Protected WithEvents PB As System.Windows.Forms.PictureBox
    Protected WithEvents BotonesGB As System.Windows.Forms.GroupBox
    Protected WithEvents SalirBtn As System.Windows.Forms.Button
    Protected WithEvents BuscarBtn As System.Windows.Forms.Button
    Protected WithEvents CancelarBtn As System.Windows.Forms.Button
    Protected WithEvents NuevoBtn As System.Windows.Forms.Button
    Protected WithEvents EliminarBtn As System.Windows.Forms.Button
    Protected WithEvents EditarBtn As System.Windows.Forms.Button
    Protected WithEvents GuardarBtn As System.Windows.Forms.Button
    Protected WithEvents InfoGB As System.Windows.Forms.GroupBox
End Class
