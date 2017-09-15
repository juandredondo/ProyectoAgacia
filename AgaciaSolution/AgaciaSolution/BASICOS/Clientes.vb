Public Class Clientes
    Public Sub HabilitaBotones(ByVal Nuevo As Boolean, ByVal Editar As Boolean, ByVal Eliminar As Boolean, ByVal Guardar As Boolean, ByVal Cancelar As Boolean, ByVal Buscar As Boolean, ByVal Salir As Boolean)
        Me.NuevoBtn.Enabled = Enabled
        Me.EliminarBtn.Enabled = Eliminar
        Me.GuardarBtn.Enabled = Guardar
        Me.CancelarBtn.Enabled = Cancelar
        Me.EditarBtn.Enabled = Editar
        Me.BuscarBtn.Enabled = Buscar
        Me.SalirBtn.Enabled = Salir

    End Sub
    

    Private Sub Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BasicoDs.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.BasicoDs.Clientes)
        Me.ClientesTableAdapter.Fill(Me.BasicoDs.Clientes)
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
            Me.ClientesBindingSource.AddNew()
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

        Me.IdClieTextBox.Enabled = False
        Me.TipClieComboBox.Enabled = False
        Me.SexoClieComboBox.Enabled = False
        'habilita los botones
        HabilitaBotones(False, False, False, True, True, False, False)
    End Sub

    Private Sub EliminarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBtn.Click
        If (MsgBox("Eliminar registro?", MsgBoxStyle.YesNo, "eliminar") = MsgBoxResult.Yes) Then
            Try
                'se elimina el registro
                ClientesBindingSource.RemoveCurrent()
                'se actualiza a el dataset
                Me.Validate()
                Me.ClientesBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.BasicoDs)
                MsgBox("Cliente Eliminado exitosamente!", MsgBoxStyle.Information, "Agacia")
            Catch ex As Exception
                Me.ClientesBindingSource.CancelEdit()

                MsgBox(" información relacionada en el sistema, por lo tanto no se puede eliminar", MsgBoxStyle.Critical)

            End Try


        End If
    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        If (IdClieTextBox.Text = Nothing Or NomClieTextBox.Text = Nothing Or DirClieTextBox.Text = Nothing Or TipClieComboBox.Text = Nothing Or ActivoClieComboBox.Text = Nothing) Then
            MsgBox("Faltan algunos datos por llenar", MsgBoxStyle.Information, "Agacia")

        Else
            Try
                Me.Validate()
                Me.ClientesBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasicoDs)
                MsgBox("Datos guardados exitosamente!", MsgBoxStyle.Information, "Agacia")
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                Me.ClientesBindingSource.CancelEdit()

            End Try

            For Each ctrl As Control In InfoGB.Controls
                ctrl.Enabled = False
            Next
            HabilitaBotones(True, True, True, False, False, True, True)

        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        ClientesBindingSource.CancelEdit()
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
    Private Sub TipClieComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipClieComboBox.SelectedIndexChanged
        If (TipClieComboBox.Text = "PERSONA JURIDICA") Then
            SexoClieComboBox.Visible = False
            SexoLbl.Visible = False
        End If

    End Sub
    Private Sub IdClieTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefClieTextBox.KeyPress, IdClieTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("En este Campo solo se puede digitar numeros y '-'")

        End If
    End Sub

    Private Sub NomClieTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NomClieTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Este campo no admite valores numericos ni simbolos!", MsgBoxStyle.Information, "Agacia")

        End If
    End Sub


    Private Sub CiudadClieTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CiudadClieTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Este campo no admite valores numericos ni simbolos!", MsgBoxStyle.Information, "Agacia")

        End If
    End Sub
End Class