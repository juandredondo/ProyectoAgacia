Public Class BuscarProveedor
    Public NIT, NOMBRE, TELEFONO, CONTACTO, CIUDAD, DIRECCION As String



    Private Sub BuscarProveedor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BuscarDSDataSet.BuscarPROVEEDORES' Puede moverla o quitarla según sea necesario.
        Me.BuscarPROVEEDORESTableAdapter.Fill(Me.BuscarDSDataSet.BuscarPROVEEDORES)

    End Sub

    Private Sub TextoCB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoCB.TextChanged
        Dim opc As String
        opc = CriterioCB.Text

        Select Case opc
            Case "NOMBRE"
                Try
                    Me.BuscarPROVEEDORESTableAdapter.FillByNombre(Me.BuscarDSDataSet.BuscarPROVEEDORES, "%" & Me.TextoCB.Text & "%")
                Catch ex As Exception
                    MsgBox(ex)
                End Try
            Case "CIUDAD"
                Try
                    BuscarPROVEEDORESTableAdapter.FillByCiudad(Me.BuscarDSDataSet.BuscarPROVEEDORES, "%" & TextoCB.Text & "%")
                Catch ex As Exception
                End Try
            Case "CONTACTO"
                Try
                    Me.BuscarPROVEEDORESTableAdapter.FillByContacto(Me.BuscarDSDataSet.BuscarPROVEEDORES, "%" & TextoCB.Text & "%")
                Catch ex As Exception
                    MsgBox(ex)
                End Try

        End Select
    End Sub

    Private Sub DataGridView1_CellContentDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentDoubleClick
        NIT = BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).NIT
        NOMBRE = BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).NOMBRE
        TELEFONO = BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).TELEFONO
        CONTACTO = BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).CONTACTO
        CIUDAD = BuscarDSDataSet.BuscarPROVEEDORES(BuscarPROVEEDORESBindingSource.Position).CIUDAD
        DIRECCION = Me.BuscarDSDataSet.BuscarPROVEEDORES(Me.BuscarDSDataSetBindingSource.Position).DIRECCION


        Me.Close()

    End Sub

    
    
End Class