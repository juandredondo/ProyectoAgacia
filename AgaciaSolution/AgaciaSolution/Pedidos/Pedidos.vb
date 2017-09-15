Public Class Pedidos
    Dim item As Integer = 0
    Dim Encuentraprod As Boolean = False


    Private Sub BuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBtn.Click
        My.Forms.BuscarProveedor.ShowDialog()
        Me.NombreProvTB.Text = My.Forms.BuscarProveedor.NOMBRE
        Me.DNIProveedorTB.Text = My.Forms.BuscarProveedor.NIT
        Me.CiudadProvTB.Text = My.Forms.BuscarProveedor.CIUDAD
        Me.TelefonoProvTB.Text = My.Forms.BuscarProveedor.TELEFONO
        Me.DireccionProvTB.Text = My.Forms.BuscarProveedor.DIRECCION
        Me.DNIProveedorTB.Enabled = False

    End Sub

    Private Sub IrBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrBtn.Click
        If Me.DNIProveedorTB.Text = Nothing Then
            MsgBox("Debe digitar el código del proveedor")
            Me.DNIProveedorTB.Focus()

        Else
            Try
                Me.BuscarPROVEEDORESTableAdapter.FillByNIT(Me.BuscarDSDataSet.BuscarPROVEEDORES, DNIProveedorTB.Text)
                'aqui se ejecuta el proceso de traer la informacion
                Me.NombreProvTB.Text = Me.BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).NOMBRE
                Me.DNIProveedorTB.Text = Me.BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).NIT
                Me.CiudadProvTB.Text = Me.BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).CIUDAD
                Me.TelefonoProvTB.Text = Me.BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).TELEFONO
                Me.DireccionProvTB.Text = Me.BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).DIRECCION
            Catch ex As Exception
                MsgBox("El código: " & DNIProveedorTB.Text & " de proveedor digitado no se encuentre registrado", MsgBoxStyle.Information, "AGACIA")

            End Try
        End If
    End Sub

    Private Sub Pedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.AgaciaBDDataSet.Empleados)
        Me.VendedorCB.Text = " "
        Dim cont As Integer

        Me.CuentaPedTableAdapter.Fill(Me.AgaciaBDDataSet1.CuentaPed)
        cont = Me.AgaciaBDDataSet1.CuentaPed(Me.CuentaPedBindingSource.Position).Column1
        If cont = 0 Then
            Me.IdPedidoLBL.Text = 10001
        Else
            Me.CuentaPedTableAdapter.FillByMaxPed(Me.AgaciaBDDataSet1.CuentaPed)
            cont = Me.AgaciaBDDataSet1.CuentaPed(Me.CuentaPedBindingSource.Position).Column1
            cont += 1
            Me.IdPedidoLBL.Text = cont.ToString
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrProdBTN.Click
        If Me.codproTB.Text = Nothing Then
            MsgBox("Debe digitar el código del producto", MsgBoxStyle.Exclamation)
        Else
            Try
                Me.ProductosTableAdapter.FillByIdProd(Me.AgaciaBDDataSet1.Productos, CType(codproTB.Text, Decimal))
                Me.DetalleprodTB.Text = Me.AgaciaBDDataSet1.Productos(ProductosBindingSource.Position).DescripProd
                Me.codproTB.Enabled = False
            Catch ex As Exception
                MsgBox("El codigo digitado no se encuentra registrado")
            End Try
            
        End If
    End Sub

    Private Sub BuscarProdBto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProdBto.Click
        My.Forms.BuscarProductos.ShowDialog()
        Me.codproTB.Text = My.Forms.BuscarProductos.IDPROD
        Me.DetalleprodTB.Text = My.Forms.BuscarProductos.NOMPROD
        Me.codproTB.Enabled = False
        Me.IrProdBTN.Enabled = False

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If codproTB.Text = Nothing Or DetalleprodTB.Text = Nothing Then
            MsgBox("Debe llenar la información del producto", MsgBoxStyle.Exclamation, "Agacia")
        Else
            Dim cont As Integer = 0
            Dim swi As Integer = 0
            Dim Ir As Integer = 0

            cont = Me.DataGridView1.RowCount - 1

            While (Ir <= cont And swi = 0)
                If Me.DataGridView1.Rows(Ir).Cells(1).Value = Me.codproTB.Text Then
                    Encuentraprod = True
                    swi = 1
                End If
                Ir = Ir + 1
            End While
            If Encuentraprod = True Then
                MsgBox("El producto que desea ingresar ya se encuentra en la lista")
                Me.codproTB.Text = Nothing
                Me.DetalleprodTB.Text = Nothing
                Me.CantidadNUD.Value = 1
                Me.codproTB.Enabled = True
                Me.IrProdBTN.Enabled = True
                Me.Encuentraprod = False
            Else

                item += 1
                Me.DataGridView1.Rows.Add()
                Me.DataGridView1.Rows(item - 1).Cells(0).Value = item.ToString
                Me.DataGridView1.Rows(item - 1).Cells(1).Value = codproTB.Text
                Me.DataGridView1.Rows(item - 1).Cells(2).Value = DetalleprodTB.Text
                Me.DataGridView1.Rows(item - 1).Cells(3).Value = CantidadNUD.Value.ToString

                Me.codproTB.Text = Nothing
                Me.DetalleprodTB.Text = Nothing
                Me.CantidadNUD.Value = 1
                Me.codproTB.Enabled = True
                Me.IrProdBTN.Enabled = True
                Me.Encuentraprod = False
            End If
           
        End If
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        If MsgBox("¿Esta seguro que desea eliminar este registro?", MsgBoxStyle.YesNo, "Agacia") = MsgBoxResult.Yes Then
            Dim cont As Integer
            Me.DataGridView1.Rows.Remove(Me.DataGridView1.CurrentRow)
            'reordenar items
            cont = Me.DataGridView1.Rows.Count + 1
            If cont = 0 Then
                item = 0
            Else
                item -= 1
                For i As Integer = 0 To item - 1
                    Me.DataGridView1.Rows(i).Cells(0).Value = i + 1
                Next

            End If
        End If

    End Sub

    Private Sub ModificarCantidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarCantidadToolStripMenuItem.Click
        Dim c As Integer
        c = Me.DataGridView1.CurrentRow.Cells(0).Value
        My.Forms.ModificarCanped.itemmod.Text = Me.DataGridView1.Rows(c - 1).Cells(0).Value
        My.Forms.ModificarCanped.codmod.Text = Me.DataGridView1.Rows(c - 1).Cells(1).Value
        My.Forms.ModificarCanped.promod.Text = Me.DataGridView1.Rows(c - 1).Cells(2).Value
        My.Forms.ModificarCanped.cantidad.Text = Me.DataGridView1.Rows(c - 1).Cells(3).Value
        My.Forms.ModificarCanped.ShowDialog()

    End Sub

    Private Sub codproTB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles codproTB.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se admiten valores numericos")
        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        Me.Close()
    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        If Me.DNIProveedorTB.Text = Nothing Or item = 0 Or VendedorCB.Text = " " Then
            MsgBox("Faltan campos por llenar", MsgBoxStyle.Information, "Agacia")
        Else

            Dim Obj As New Clasesdelproyecto.EjecutaSentencias
            Obj.ejecutar_sql("insert into Pedidos (IdPed, FechaPed, IdProvPed, IdEmpPed) values(" + CInt(IdPedidoLBL.Text).ToString + "," + Clasesdelproyecto.Class1.convetirfecha(Me.DateTimePicker1.Text) + ",'" + DNIProveedorTB.Text + "'," + CInt(IdEmpTextBox.Text).ToString + ")")

            Dim obj2 As New Clasesdelproyecto.EjecutaSentencias
            For I As Integer = 0 To Val(Me.DataGridView1.RowCount) - 1
                obj2.ejecutar_sql("INSERT INTO LineaPedidos(CantPedida,IdPed,IdProd)VALUES(" + CInt(Me.DataGridView1.Rows(I).Cells(3).Value).ToString + "," + CInt(Me.IdPedidoLBL.Text).ToString + "," + CInt(Me.DataGridView1.Rows(I).Cells(1).Value).ToString + ")")
            Next
            MsgBox("El pedido se guardo exitosamente", MsgBoxStyle.Information, "Agacia")
            Me.BuscarBtn.Enabled = False
            Me.VendedorCB.Enabled = False
            Me.IrProdBTN.Enabled = False
            Me.codproTB.Enabled = False
            Me.DetalleprodTB.Enabled = False
            Me.CantidadNUD.Enabled = False
            Me.Button1.Enabled = False
            Me.IrBtn.Enabled = False
            Me.NuevoBtn.Enabled = False
            Me.BuscarProdBto.Enabled = False
            Me.GuardarBtn.Enabled = False
            Me.CancelarBtn.Enabled = False
            Me.FacturarBtn.Enabled = True
            Me.DateTimePicker1.Enabled = False
        End If
    End Sub

End Class