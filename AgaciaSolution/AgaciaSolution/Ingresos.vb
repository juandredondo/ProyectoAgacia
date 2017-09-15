Public Class Ingresos
    Dim Item As Integer = 0
    Dim Encuentraprod As Boolean = False



    Private Sub Ingresos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.AgaciaBDDataSet.Empleados)
        Me.VendedorCB.Text = " "
        Dim cont As Integer
        Me.CuentaIngresoTableAdapter.FillcuentaIngr(Me.AgaciaBDDataSet1.CuentaIngreso)
        cont = Me.AgaciaBDDataSet1.CuentaIngreso(Me.CuentaIngresoBindingSource.Position).Column1
        If cont = 0 Then
            Me.IdIngresoLBL.Text = 20001
        Else
            Me.CuentaIngresoTableAdapter.FillBymaxIngr(Me.AgaciaBDDataSet1.CuentaIngreso)
            cont = Me.AgaciaBDDataSet1.CuentaIngreso(Me.CuentaIngresoBindingSource.Position).Column1
            cont += 1
            IdIngresoLBL.Text = cont.ToString
        End If

    End Sub


    Private Sub IdPedidoTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdPedidoTB.TextChanged

    End Sub

    Private Sub BuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBtn.Click
        My.Forms.BuscarPedidos.ShowDialog()
        Try
            Me.VerDetallePedTableAdapter.FillVerPed(Me.BuscarDSDataSet.VerDetallePed, CType(Me.IdPedidoTB.Text, Decimal))
            Me.VerdetalleBtn.Enabled = True
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try

    End Sub

    Private Sub VerdetalleBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerdetalleBtn.Click
        'Dim c As Integer
        Me.codproTB.Text = Me.DataGridView2.CurrentRow.Cells(1).Value
        Me.DetalleprodTB.Text = Me.DataGridView2.CurrentRow.Cells(2).Value
        Me.CPTB.Text = Me.DataGridView2.CurrentRow.Cells(0).Value

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Me.codproTB.Text = Nothing Or DetalleprodTB.Text = Nothing Or CPTB.Text = Nothing Or CRTB.Text = Nothing Then
            MsgBox("Debe escoger el producto que desea ingresar y digitar la cantidad recibida", MsgBoxStyle.Exclamation, "Agacia")
        Else
            Dim i As Integer = 0
            Dim cont As Integer = 0
            Dim swi As Integer = 0

            cont = Me.DataGridView1.RowCount - 1

            While (i <= cont And swi = 0)
                If Me.DataGridView1.Rows(i).Cells(1).Value = Me.codproTB.Text Then
                    Encuentraprod = True
                    swi = 1
                End If
                i = i + 1
            End While
            If Encuentraprod = True Then
                MsgBox("El producto que desea ingresar ya se encuentra en la lista", MsgBoxStyle.Exclamation, "Agacia")
                Me.codproTB.Text = Nothing
                Me.DetalleprodTB.Text = Nothing
                Me.CPTB.Text = Nothing
                Me.CRTB.Text = Nothing
                Encuentraprod = False

            Else

                Item += 1
                Me.DataGridView1.Rows.Add()
                Me.DataGridView1.Rows(Item - 1).Cells(0).Value = Item.ToString
                Me.DataGridView1.Rows(Item - 1).Cells(1).Value = Me.codproTB.Text
                Me.DataGridView1.Rows(Item - 1).Cells(2).Value = Me.DetalleprodTB.Text
                Me.DataGridView1.Rows(Item - 1).Cells(3).Value = Me.CRTB.Text
                Encuentraprod = False
                Me.codproTB.Text = Nothing
                Me.DetalleprodTB.Text = Nothing
                Me.CPTB.Text = Nothing
                Me.CRTB.Text = Nothing

            End If



        End If
    End Sub

    Private Sub CRTB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CRTB.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se admiten valores numericos", MsgBoxStyle.Exclamation, "Agacia")

        End If
    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        If IdPedidoTB.Text = Nothing Or VendedorCB.Text = " " Or Item = 0 Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Exclamation, "AGACIA")
        Else
            Dim obj As New Clasesdelproyecto.EjecutaSentencias
            obj.ejecutar_sql("Insert Into Ingresos(IdIngr,FechaIngr,IdPedIngr,ObservIngr,IdEmpIngr)Values(" + CInt(IdIngresoLBL.Text).ToString + "," + Clasesdelproyecto.Class1.convetirfecha(Me.DateTimePicker1.Text) + "," + CInt(Me.IdPedidoTB.Text).ToString + ",'" + Me.ObservaRTB.Text + "' , " + CInt(Me.IdEmpTextBox1.Text).ToString + ") ")
            For I As Integer = 0 To Val(Me.DataGridView1.RowCount) - 1
                obj.ejecutar_sql("INSERT INTO LinIngreso(IdIngrLinIngr, CantLinIngr, IdProdLinIngr)VALUES(" + CInt(Me.IdIngresoLBL.Text).ToString + "," + CInt(Me.DataGridView1.Rows(I).Cells(3).Value).ToString + "," + CInt(Me.DataGridView1.Rows(I).Cells(1).Value).ToString + ")")
                obj.ejecutar_sql("UPDATE Productos set CantProd=CantProd+" + CInt(Me.DataGridView1.Rows(I).Cells(3).Value).ToString + " where IdProd=" + CInt(Me.DataGridView1.Rows(I).Cells(1).Value).ToString + "")
            Next

            MsgBox("El ingreso se realizó satisfactoriamente")
            Me.VendedorCB.Enabled = False
            Me.BuscarBtn.Enabled = False
            Me.VerdetalleBtn.Enabled = False
            Me.Button1.Enabled = False
            Me.CRTB.Enabled = False
            Me.DateTimePicker1.Enabled = False
            Me.ObservaRTB.Enabled = False
            Me.CancelarBtn.Enabled = False
            Me.GuardarBtn.Enabled = False
        End If
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.Close()

    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        Me.Close()

    End Sub
End Class