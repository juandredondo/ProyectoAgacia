Public Class Consultas
    Private Sub Esconderdatagrid(ByVal DG1 As Boolean, ByVal DG2 As Boolean, ByVal DG3 As Boolean, ByVal DG4 As Boolean)
        Me.DataGridView1.Visible = DG1
        Me.DataGridView2.Visible = DG2
        Me.DataGridView3.Visible = DG3
        Me.DataGridView4.Visible = DG4
    End Sub

    Private Sub ListadoDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeEmpleadosToolStripMenuItem.Click
        Try
            Me.Label1.Text = "LISTADO DE EMPLEADOS"
            Esconderdatagrid(True, False, False, False)

            Me.ListarEmpleadosTableAdapter.Fill(Me.ConsultasDS.ListarEmpleados)

        Catch ex As Exception

        End Try
    End Sub



    Private Sub ListadoDeClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeClientesToolStripMenuItem.Click
        Try
            Me.Label1.Text = "LISTADO DE CLIENTES"
            Esconderdatagrid(False, True, False, False)
            Me.ListarClientesTableAdapter.Fill(Me.ConsultasDS.ListarClientes)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListadoDeProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeProductosToolStripMenuItem.Click
        Try
            Me.Label1.Text = "LISTADO DE PRODUCTOS"
            Esconderdatagrid(False, False, True, False)
            Me.ListarProductosTableAdapter.Fill(Me.ConsultasDS.ListarProductos)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListadoDeProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListadoDeProveedoresToolStripMenuItem.Click
        Try
            Me.Label1.Text = "LISTADO DE PROVEEDORES"
            Esconderdatagrid(False, False, False, True)
            Me.ListarProveedoresTableAdapter.Fill(Me.ConsultasDS.ListarProveedores)
        Catch ex As Exception

        End Try
    End Sub

    
    Private Sub Consultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class