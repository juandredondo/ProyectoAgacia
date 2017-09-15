Public Class BuscarProductos

    Public IDPROD, CANT, STOCK As Integer
    Public NOMPROD, DESCRIP, SERIAL As String
    Public VRUNIT As Double


    Private Sub BuscarProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet1.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.AgaciaBDDataSet1.Productos)

    End Sub


   
    Private Sub TextoTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoTB.TextChanged
        Dim opc As String
        opc = Me.CriterioCB.Text

        Select Case opc
            Case "NOMBRE DEL PRODUCTO"
                Try
                    Me.ProductosTableAdapter.FillByNomprod(Me.AgaciaBDDataSet1.Productos, "%" & Me.TextoTB.Text & "%")
                Catch ex As Exception
                    MsgBox("No se encontró ningún registro con este contexto", MsgBoxStyle.Information, "Agacia")
                End Try
            Case "CÓDIGO DEL PRODUCTO"
                Try
                    Me.ProductosTableAdapter.FillByIdProd(Me.AgaciaBDDataSet1.Productos, CType(Me.TextoTB.Text, Decimal))
                Catch ex As Exception
                    MsgBox("No se encontró ningún registro con este contexto", MsgBoxStyle.Information, "Agacia")
                End Try
        End Select

    End Sub

    Private Sub ProductosDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosDataGridView.DoubleClick
        Try
            IDPROD = Me.AgaciaBDDataSet1.Productos(Me.ProductosBindingSource.Position).IdProd.ToString
            NOMPROD = Me.AgaciaBDDataSet1.Productos(Me.ProductosBindingSource.Position).NomProd
            VRUNIT = Me.AgaciaBDDataSet1.Productos(Me.ProductosBindingSource.Position).VrUnitProd.ToString
            STOCK = Me.AgaciaBDDataSet1.Productos(Me.ProductosBindingSource.Position).StockMinProd.ToString
            DESCRIP = Me.AgaciaBDDataSet1.Productos(Me.ProductosBindingSource.Position).DescripProd
            CANT = Me.AgaciaBDDataSet1.Productos(Me.ProductosBindingSource.Position).CantProd.ToString
            Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub CriterioCB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriterioCB.SelectedIndexChanged

    End Sub
End Class