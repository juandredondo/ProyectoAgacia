Public Class Productos

    Public Sub HabilitaBotones(ByVal Nuevo As Boolean, ByVal Editar As Boolean, ByVal Eliminar As Boolean, ByVal Guardar As Boolean, ByVal Cancelar As Boolean, ByVal Buscar As Boolean, ByVal Salir As Boolean)
        Me.NuevoBtn.Enabled = Enabled
        Me.EliminarBtn.Enabled = Eliminar
        Me.GuardarBtn.Enabled = Guardar
        Me.CancelarBtn.Enabled = Cancelar
        Me.EditarBtn.Enabled = Editar
        Me.BuscarBtn.Enabled = Buscar
        Me.SalirBtn.Enabled = Salir
    End Sub



    Private Sub Productos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.BasicoDs.Productos)
        For Each ctrl As Control In InforGB.Controls
            ctrl.Enabled = False
        Next
        Me.InforGB.Enabled = False
        HabilitaBotones(True, True, True, False, False, True, True)

    End Sub

    Private Sub NuevoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoBtn.Click
        For Each ctrl As Control In InforGB.Controls
            ctrl.Enabled = True
        Next
        Me.InforGB.Enabled = True
        Try
            ProductosBindingSource.AddNew()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        HabilitaBotones(False, False, False, True, True, False, True)
    End Sub

    Private Sub EditarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBtn.Click
        'habilita los controles de edicion ecepto el dni
        For Each ctrl As Control In InforGB.Controls
            ctrl.Enabled = True
        Next
        Me.InforGB.Enabled = True

        Me.IdProdTextBox.Enabled = False
        Me.NomProdTextBox.Enabled = False
        Me.VrUnitProdTextBox.Enabled = False
        Me.SerialTextBox.Enabled = False
        Me.CantProdTextBox.Enabled = False
        Me.DescripProdRichTextBox.Enabled = False
        Me.VrUnitProdTextBox.Enabled = True

        'habilita los botones
        HabilitaBotones(False, False, False, True, True, False, False)
    End Sub

    Private Sub EliminarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarBtn.Click
        If (MsgBox("Eliminar registro?", MsgBoxStyle.YesNo, "eliminar") = MsgBoxResult.Yes) Then
            Try
                ProductosBindingSource.RemoveCurrent()
                Me.Validate()
                Me.ProductosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasicoDs)
                MsgBox(" Empleado eliminado exitosamente ", MsgBoxStyle.Information, "Agacia")
            Catch ex As Exception
                MsgBox("Este Producto tiene información relacionada en el sistema, por lo tanto no se puede eliminar", MsgBoxStyle.Critical)
            End Try
            ProductosBindingSource.RemoveCurrent()
        End If
    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        If IdProdTextBox.Text = Nothing Or NomProdTextBox.Text = Nothing Or SerialTextBox.Text = Nothing Or CantProdTextBox.Text = Nothing Or StockMinProdTextBox.Text = Nothing Or DescripProdRichTextBox.Text = Nothing Or VrUnitProdTextBox.Text = Nothing Then
            MsgBox("Faltan algunos datos por llenar", MsgBoxStyle.Information, "Agacia")
        Else
            Try
                Me.Validate()
                Me.ProductosBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasicoDs)
                MsgBox("Datos guardados exitosamente!", MsgBoxStyle.Information, "Agacia")
            Catch ex As Exception
                MsgBox(ex.Message.ToString)
                ProductosBindingSource.CancelEdit()
            End Try
            For Each ctrl As Control In InforGB.Controls
                ctrl.Enabled = False
            Next
            HabilitaBotones(True, True, True, False, False, True, True)
        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        ProductosBindingSource.CancelEdit()
        HabilitaBotones(True, True, True, False, False, True, True)
        'deshabilitar controles de texto
        For Each ctrl As Control In InforGB.Controls
            ctrl.Enabled = False
        Next
        Me.InforGB.Enabled = False
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        If (MsgBox("Salir del formulario?", MsgBoxStyle.YesNo, "salir") = MsgBoxResult.Yes) Then
            Me.Close()
        End If
    End Sub

    Private Sub IdProdTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles VrUnitProdTextBox.KeyPress, StockMinProdTextBox.KeyPress, IdProdTextBox.KeyPress, CantProdTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("En este Campo solo se puede digitar numeros y '-'")
        End If
    End Sub
End Class