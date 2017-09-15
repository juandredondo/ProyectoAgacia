Public Class Proveedores

    Public Sub HabilitaBotones(ByVal Nuevo As Boolean, ByVal Editar As Boolean, ByVal Eliminar As Boolean, ByVal Guardar As Boolean, ByVal Cancelar As Boolean, ByVal Buscar As Boolean, ByVal Salir As Boolean)
        Me.NuevoBtn.Enabled = Enabled
        Me.EliminarBtn.Enabled = Eliminar
        Me.GuardarBtn.Enabled = Guardar
        Me.CancelarBtn.Enabled = Cancelar
        Me.EditarBtn.Enabled = Editar
        Me.BuscarBtn.Enabled = Buscar
        Me.SalirBtn.Enabled = Salir

    End Sub
    

    Private Sub Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet.Proveedores' Puede moverla o quitarla según sea necesario.
        Me.ProveedoresTableAdapter.Fill(Me.BasicoDs.Proveedores)
        HabilitaBotones(True, True, True, False, False, True, True)
        For Each ctrl As Control In InfoGB.Controls
            ctrl.Enabled = False
        Next
    End Sub

    Private Sub NuevoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoBtn.Click
        For Each ctrl As Control In InfoGB.Controls
            ctrl.Enabled = True
        Next
        Me.InfoGB.Enabled = True

        Try
            Me.ProveedoresBindingSource.AddNew()
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

        Me.IdProvTextBox.Enabled = False
        'habilita los botones
        HabilitaBotones(False, False, False, True, True, False, False)

    End Sub

    Private Sub EliminarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBtn.Click
        If (MsgBox("Eliminar registro?", MsgBoxStyle.YesNo, "eliminar") = MsgBoxResult.Yes) Then
            Try
                ProveedoresBindingSource.RemoveCurrent()
                Me.Validate()
                Me.ProveedoresBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasicoDs)
                MsgBox(" Proveedor eliminado exitosamente ", MsgBoxStyle.Information, "Agacia")
            Catch ex As Exception

                MsgBox(ex.Message.ToString) '"Este Proveedor tiene información relacionada en el sistema, por lo tanto no se puede eliminar", MsgBoxStyle.Critical)
            End Try

        End If
    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        If IdProvTextBox.Text = Nothing Or NomProvTextBox.Text = Nothing Or DirProvTextBox.Text = Nothing Or TelefProvTextBox.Text = Nothing Or CiudadProvTextBox.Text = Nothing Or ContactoProvTextBox.Text = Nothing Or TelefContProvTextBox.Text = Nothing Or TitularCtaProvTextBox.Text = Nothing Or NomBancoProvTextBox.Text = Nothing Or NumCtaProvTextBox.Text = Nothing Or TipoCtaProvComboBox.Text = Nothing Then
            MsgBox("Faltan algunos datos por llenar", MsgBoxStyle.Information, "Agacia")
        Else
            Try
                Me.Validate()
                Me.ProveedoresBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasicoDs)
                MsgBox("Datos guardados exitosamente!", MsgBoxStyle.Information, "Agacia")
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                ProveedoresBindingSource.CancelEdit()
            End Try
            For Each ctrl As Control In InfoGB.Controls
                ctrl.Enabled = False
            Next
            HabilitaBotones(True, True, True, False, False, True, True)

        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        ProveedoresBindingSource.CancelEdit()
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

    Private Sub IdProvTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefProvTextBox.KeyPress, TelefContProvTextBox.KeyPress, NumCtaProvTextBox.KeyPress, IdProvTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("En este Campo solo se puede digitar numeros y '-'")
        End If
    End Sub

    Private Sub CiudadProvTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TitularCtaProvTextBox.KeyPress, NomBancoProvTextBox.KeyPress, ContactoProvTextBox.KeyPress, CiudadProvTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Este campo no admite valores numericos ni simbolos!", MsgBoxStyle.Information, "Agacia")
        End If
    End Sub
    
End Class