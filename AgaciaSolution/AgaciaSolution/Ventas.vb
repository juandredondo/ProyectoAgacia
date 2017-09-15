Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException



Public Class Ventas
    Dim item As Integer = 0
    Dim terminavent As Boolean = False
    Dim Encuentraprod As Boolean = False


    Dim subtotal, iva, total As Double



    Private Sub BuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBtn.Click
        My.Forms.BuscarCliente.ShowDialog()
        Me.NomClienteTB.Text = My.Forms.BuscarCliente.NOMCLIE
        Me.IdentificacionClienteTB.Text = My.Forms.BuscarCliente.IDCLIE
        Me.TelclienteTB.Text = My.Forms.BuscarCliente.TELEFCLIE
        Me.DireccionClienteTB.Text = My.Forms.BuscarCliente.DIRCLIE

    End Sub

    Private Sub IrBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IrBtn.Click
        If Me.IdentificacionClienteTB.Text = Nothing Then
            MsgBox("Debe digitar el número de identificación del cliente", MsgBoxStyle.Information, "AGACIA")
            Me.IdentificacionClienteTB.Focus()

        Else
            Try
                Me.ClientesTableAdapter.BuscarClienteXId(AgaciaBDDataSet1.Clientes, Me.IdentificacionClienteTB.Text)
                Me.NomClienteTB.Text = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).NomClie
                Me.IdentificacionClienteTB.Text = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).IdClie
                Me.TelclienteTB.Text = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).TelefClie
                Me.DireccionClienteTB.Text = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).DirClie
            Catch ex As Exception
                MsgBox("El número de identificación digitado no se encuentra registrado", MsgBoxStyle.Information, "AGACIA")

            End Try
        End If
    End Sub


    Private Sub BuscarProductoBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarProductoBtn.Click
        My.Forms.BuscarProductos.ShowDialog()
        Me.CodProdTB.Text = My.Forms.BuscarProductos.IDPROD
        Me.ExistenciaTB.Text = My.Forms.BuscarProductos.CANT
        Me.VrUnitTB.Text = My.Forms.BuscarProductos.VRUNIT
        Me.NomProdTB.Text = My.Forms.BuscarProductos.NOMPROD


    End Sub



    Private Sub Ventas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.subtotalTB.Text = 0
        Me.ivaTB.Text = 0
        Me.TotalTB.Text = 0


        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.AgaciaBDDataSet.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet1.Facturas' Puede moverla o quitarla según sea necesario.
        Me.VendedorCB.Text = " "
        'Me.IdEmpTextBox.Visible = False
        Dim cant As Integer
        Try
            Me.CuentafacturasTableAdapter.Fillcuentafact(Me.AgaciaBDDataSet1.Cuentafacturas)
            cant = AgaciaBDDataSet1.Cuentafacturas(CuentafacturasBindingSource.Position).Column1
            If cant = 0 Then
                Me.IdfactTB.Text = InputBox("Digite el numero de la factura")
            Else
                Me.CuentafacturasTableAdapter.FillBymax(Me.AgaciaBDDataSet1.Cuentafacturas)
                cant = AgaciaBDDataSet1.Cuentafacturas(CuentafacturasBindingSource.Position).Column1
                cant += 1
                Me.IdfactTB.Text = cant.ToString
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.CantidadProTB.Text = Nothing Then
            MsgBox("Debe digitar la cantidad", MsgBoxStyle.Information, "AGACIA")
            Me.CantidadProTB.Text = Nothing
            Me.CantidadProTB.Focus()
        ElseIf Me.CodProdTB.Text = Nothing Then
            MsgBox("Debe buscar el producto ", MsgBoxStyle.Information, "AGACIA")
            Me.BuscarProductoBtn.Focus()
        ElseIf CInt(Me.CantidadProTB.Text) > CInt(Me.ExistenciaTB.Text) Then
            MsgBox("La cantidad digitada es mayor que la existencia", MsgBoxStyle.Information, "AGACIA")
            Me.CantidadProTB.Text = Nothing
            Me.CantidadProTB.Focus()
        Else

            Dim cuentaLin As Integer
            Dim i As Integer = 1
            Dim sw As Integer = 0
            Dim Ir As Integer = 0
            Dim cont As Integer = 0
            Dim swi As Integer = 0

            cont = Me.DataGridView1.RowCount - 1

            While (Ir <= cont And swi = 0)
                If Me.DataGridView1.Rows(Ir).Cells(1).Value = Me.CodProdTB.Text Then
                    Encuentraprod = True
                    swi = 1
                End If
                Ir = Ir + 1
            End While
            If Encuentraprod = True Then
                MsgBox("El producto que desea registrar ya se encuentra en la lista")
                Me.CodProdTB.Text = Nothing
                Me.NomProdTB.Text = Nothing
                Me.VrUnitTB.Text = Nothing
                Me.ExistenciaTB.Text = Nothing
                Me.CantidadProTB.Text = Nothing
                Me.Encuentraprod = False
            Else
                cuentaLin = Me.DataGridView1.Rows.Count
                item += 1
                Try
                    Me.DataGridView1.Rows.Add()
                    Me.DataGridView1.Rows(cuentaLin).Cells(0).Value = item.ToString
                    Me.DataGridView1.Rows(cuentaLin).Cells(1).Value = CodProdTB.Text
                    Me.DataGridView1.Rows(cuentaLin).Cells(2).Value = NomProdTB.Text
                    Me.DataGridView1.Rows(cuentaLin).Cells(3).Value = CantidadProTB.Text
                    Me.DataGridView1.Rows(cuentaLin).Cells(4).Value = VrUnitTB.Text
                    Me.DataGridView1.Rows(cuentaLin).Cells(5).Value = CInt(CantidadProTB.Text) * CInt(VrUnitTB.Text)
                    Me.CodProdTB.Text = Nothing
                    Me.NomProdTB.Text = Nothing
                    Me.VrUnitTB.Text = Nothing
                    Me.ExistenciaTB.Text = Nothing
                    Me.CantidadProTB.Text = Nothing
                    Me.Encuentraprod = False

                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                End Try
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

    Private Sub DataGridView1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGridView1.DoubleClick
        
    End Sub

    Private Sub DataGridView1_RowsAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If item = 0 Then
            MsgBox("Debe añadir los productos que desea vender", MsgBoxStyle.Exclamation, "AGACIA")
        Else

            If MsgBox("¿Está seguro que desea finalizar la venta?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                For i As Integer = 0 To item - 1
                    subtotal = subtotal + CInt(Me.DataGridView1.Rows(i).Cells(5).Value)
                Next
                Me.subtotalTB.Text = subtotal.ToString
                iva = subtotal * 0.16
                total = iva + subtotal
                Me.ivaTB.Text = iva.ToString
                Me.TotalTB.Text = total.ToString
                Me.Button1.Enabled = False
                Me.IdentificacionClienteTB.Enabled = False
                Me.CantidadProTB.Enabled = False
                Me.Button5.Enabled = False
                Me.IrBtn.Enabled = False
                Me.BuscarProductoBtn.Enabled = False
                Me.BuscarBtn.Enabled = False
                Me.NuevoBtn.Enabled = False
                Me.IdentificacionClienteTB.Enabled = False
                Me.CantidadProTB.Enabled = False
                Me.DataGridView1.Enabled = False
                Me.DateTimePicker1.Enabled = False
                Me.GuardarBtn.Enabled = True
            End If
        End If


        

    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        If Me.IdentificacionClienteTB.Text = Nothing Or Me.IdfactTB.Text = Nothing Or item = 0 Or Me.VendedorCB.Text = Nothing Or FormadePagoCB.Text = Nothing Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Exclamation, "AGACIA")
        Else
            Dim saldada, fecha As String
            If Me.FormadePagoCB.Text = "CONTADO" Then
                saldada = "SI"
            Else
                saldada = "NO"
            End If

            fecha = Clasesdelproyecto.Class1.convetirfecha(Me.DateTimePicker1.Text)
            Dim conexion As New SqlConnection("Data Source=ZEUS;Initial Catalog=AgaciaBD;Persist Security Info=True;User ID=sa;Password=programacion")
            Dim cmd As New SqlCommand("dbo.Insertafact", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim Parametro As New SqlParameter()
            Parametro.ParameterName = "idfact"
            Parametro.DbType = DbType.Int32
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = Integer.Parse(Me.IdfactTB.Text)
            cmd.Parameters.Add(Parametro)

            Parametro = New SqlParameter()
            Parametro.ParameterName = "fechafact"
            Parametro.DbType = DbType.DateTime
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = fecha
            cmd.Parameters.Add(Parametro)


            Parametro = New SqlParameter()
            Parametro.ParameterName = "formpago"
            Parametro.DbType = DbType.String
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = Me.FormadePagoCB.Text
            cmd.Parameters.Add(Parametro)

            Parametro = New SqlParameter()
            Parametro.ParameterName = "idclie"
            Parametro.DbType = DbType.String
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = Me.IdentificacionClienteTB.Text
            cmd.Parameters.Add(Parametro)

            Parametro = New SqlParameter()
            Parametro.ParameterName = "idemp"
            Parametro.DbType = DbType.Int32
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = Integer.Parse(Me.IdEmpTextBox.Text)
            cmd.Parameters.Add(Parametro)


            Parametro = New SqlParameter()
            Parametro.ParameterName = "saldada"
            Parametro.DbType = DbType.String
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = saldada
            cmd.Parameters.Add(Parametro)

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            Finally
                conexion.Close()
            End Try

            Dim obj As New Clasesdelproyecto.EjecutaSentencias

            For I As Integer = 0 To Val(Me.DataGridView1.RowCount) - 1
                obj.ejecutar_sql("INSERT INTO LineaFactura(IdFact, CantVendida, IdProd, VrTotalLin)VALUES(" + CInt(Me.IdfactTB.Text).ToString + "," + CInt(Me.DataGridView1.Rows(I).Cells(3).Value).ToString + "," + CInt(Me.DataGridView1.Rows(I).Cells(1).Value).ToString + "," + CInt(Me.DataGridView1.Rows(I).Cells(5).Value).ToString + ")")
                obj.ejecutar_sql("UPDATE Productos set CantProd=CantProd-" + CInt(Me.DataGridView1.Rows(I).Cells(3).Value).ToString + " where IdProd=" + CInt(Me.DataGridView1.Rows(I).Cells(1).Value).ToString + "")
            Next
            If Me.FormadePagoCB.Text = "CONTADO" Then
                MsgBox("la venta se registró exitosamente", MsgBoxStyle.Information, "AGACIA")
                Me.IdentificacionClienteTB.Enabled = False
                Me.FacturarBtn.Enabled = True
                Me.VendedorCB.Enabled = False
                Me.FormadePagoCB.Enabled = False
                Me.GuardarBtn.Enabled = False
                Me.CancelarBtn.Enabled = False
                Me.SalirBtn.Enabled = False

            Else
                My.Forms.RegistroDxC.IdfactTB.Text = Me.IdfactTB.Text
                My.Forms.RegistroDxC.MontoTotalTB.Text = total
                My.Forms.RegistroDxC.IdClie.Text = Me.IdentificacionClienteTB.Text
                My.Forms.RegistroDxC.NomClienteTB.Text = Me.NomClienteTB.Text
                My.Forms.RegistroDxC.DireClienteTB.Text = Me.DireccionClienteTB.Text
                My.Forms.RegistroDxC.TelClienteTB.Text = Me.TelclienteTB.Text
                My.Forms.RegistroDxC.ShowDialog()
                MsgBox("la venta se registró exitosamente", MsgBoxStyle.Information, "AGACIA")
                Me.IdentificacionClienteTB.Enabled = False
                Me.FacturarBtn.Enabled = True
                Me.VendedorCB.Enabled = False
                Me.FormadePagoCB.Enabled = False
                Me.GuardarBtn.Enabled = False
                Me.CancelarBtn.Enabled = False
                Me.SalirBtn.Enabled = False
            End If
            
        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.Close()

    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        Me.Close()

    End Sub

    Private Sub ModificarCantidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModificarCantidadToolStripMenuItem.Click
        Dim c As Integer
        c = Me.DataGridView1.CurrentRow.Cells(0).Value
        My.Forms.ModificaDetFactFrm.itemmod.Text = Me.DataGridView1.Rows(c - 1).Cells(0).Value
        My.Forms.ModificaDetFactFrm.codmod.Text = Me.DataGridView1.Rows(c - 1).Cells(1).Value
        My.Forms.ModificaDetFactFrm.promod.Text = Me.DataGridView1.Rows(c - 1).Cells(2).Value
        My.Forms.ModificaDetFactFrm.cantidad.Text = Me.DataGridView1.Rows(c - 1).Cells(3).Value
        My.Forms.ModificaDetFactFrm.vrunit.Text = Me.DataGridView1.Rows(c - 1).Cells(4).Value
        Try
            Me.BucaexistprodTableAdapter.Fillexistprod(Me.AgaciaBDDataSet1.bucaexistprod, CType(Me.DataGridView1.Rows(item - 1).Cells(1).Value, Decimal))
            My.Forms.ModificaDetFactFrm.existemod.Text = Me.AgaciaBDDataSet1.bucaexistprod(Me.BucaexistprodBindingSource.Position).CantProd
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try

        My.Forms.ModificaDetFactFrm.ShowDialog()

    End Sub

    Private Sub FacturarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FacturarBtn.Click
        Dim conexion As New SqlConnection("Data Source=ZEUS;Initial Catalog=AgaciaBD;Persist Security Info=True;User ID=sa;Password=programacion")
        Dim cmd As New SqlCommand("dbo.GenerarFactura", conexion)
        cmd.CommandType = CommandType.StoredProcedure

        Dim Parametro As New SqlParameter()
        Parametro.ParameterName = "idfact"
        Parametro.DbType = DbType.Int32
        Parametro.Direction = ParameterDirection.Input
        Parametro.Value = Integer.Parse(Me.IdfactTB.Text)
        cmd.Parameters.Add(Parametro)



        Dim adaptador As New SqlDataAdapter(cmd)
        Dim conjuntodatos As New ReportesDataSet


        Try
            conexion.Open()
            conjuntodatos = New ReportesDataSet
            adaptador.Fill(conjuntodatos.Tables(0))
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            conexion.Close()
        End Try

        Dim reporte As New CrystalReport1
        reporte.SetDataSource(conjuntodatos.Tables(0))
        My.Forms.GenerarFactura.CrystalReportViewer1.ReportSource = reporte
        My.Forms.GenerarFactura.CrystalReportViewer1.Refresh()
        Me.Close()
        My.Forms.GenerarFactura.ShowDialog()


    End Sub
    Private Sub IdentificacionClienteTB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles IdentificacionClienteTB.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se admiten valores numericos")
        End If

    End Sub
End Class