Public Class Empleados

    Public Sub HabilitaBotones(ByVal Nuevo As Boolean, ByVal Editar As Boolean, ByVal Eliminar As Boolean, ByVal Guardar As Boolean, ByVal Cancelar As Boolean, ByVal Buscar As Boolean, ByVal Salir As Boolean)
        Me.NuevoBtn.Enabled = Enabled
        Me.EliminarBtn.Enabled = Eliminar
        Me.GuardarBtn.Enabled = Guardar
        Me.CancelarBtn.Enabled = Cancelar
        Me.EditarBtn.Enabled = Editar
        Me.BuscarBtn.Enabled = Buscar
        Me.SalirBtn.Enabled = Salir
    End Sub

    

    Private Sub Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.BasicoDs.Empleados)
        For Each ctrl As Control In InfoGB.Controls
            ctrl.Enabled = False
        Next
        Me.InfoGB.Enabled = False
        HabilitaBotones(True, True, True, False, False, True, True)

    End Sub

    Private Sub NuevoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoBtn.Click
        For Each ctrl As Control In InfoGB.Controls
            ctrl.Enabled = True
        Next
        Me.InfoGB.Enabled = True
        Try
            EmpleadosBindingSource.AddNew()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        HabilitaBotones(False, False, False, True, True, False, True)
    End Sub

    Private Sub EditarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBtn.Click
        'habilita los controles de edicion ecepto el dni
        For Each ctrl As Control In InfoGB.Controls
            ctrl.Enabled = True
        Next
        Me.InfoGB.Enabled = True

        Me.IdEmpTextBox.Enabled = False
        SexoEmpComboBox.Enabled = False
        ActivoEmpComboBox.Enabled = False
        'habilita los botones
        HabilitaBotones(False, False, False, True, True, False, False)

    End Sub

    Private Sub EliminarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBtn.Click
        If (MsgBox("Eliminar registro?", MsgBoxStyle.YesNo, "eliminar") = MsgBoxResult.Yes) Then
            Try
                EmpleadosBindingSource.RemoveCurrent()
                Me.Validate()
                Me.EmpleadosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasicoDs)
                MsgBox(" Empleado eliminado exitosamente ", MsgBoxStyle.Information, "Agacia")
            Catch ex As Exception
                MsgBox("Este Empleado tiene información relacionada en el sistema, por lo tanto no se puede eliminar", MsgBoxStyle.Critical)
            End Try
            EmpleadosBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        If IdEmpTextBox.Text = Nothing Or NomEmpTextBox.Text = Nothing Or SexoEmpComboBox.Text = Nothing Or DirEmpTextBox.Text = Nothing Or ActivoEmpComboBox.Text = Nothing Or FechaIngrEmpDateTimePicker.Text = Nothing Or SalarioEmpTextBox.Text = Nothing Then
            MsgBox("Faltan algunos datos por llenar", MsgBoxStyle.Information, "Agacia")
        Else
            Try
                Me.Validate()
                Me.EmpleadosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasicoDs)
                MsgBox("Datos guardados exitosamente!", MsgBoxStyle.Information, "Agacia")
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                EmpleadosBindingSource.CancelEdit()
            End Try
            For Each ctrl As Control In InfoGB.Controls
                ctrl.Enabled = False
            Next
            HabilitaBotones(True, True, True, False, False, True, True)
        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        EmpleadosBindingSource.CancelEdit()
        HabilitaBotones(True, True, True, False, False, True, True)
        'deshabilitar controles de texto
        For Each ctrl As Control In InfoGB.Controls
            ctrl.Enabled = False
        Next
        Me.InfoGB.Enabled = False
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        If (MsgBox("Salir del formulario?", MsgBoxStyle.YesNo, "salir") = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub IdEmpTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefEmpTextBox.KeyPress, SalarioEmpTextBox.KeyPress, IdEmpTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("En este Campo solo se puede digitar numeros y '-'")
        End If
    End Sub


    Private Sub NomEmpTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomEmpTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Este campo no admite valores numericos ni simbolos!", MsgBoxStyle.Information, "Agacia")

        End If
    End Sub

    
End Class