Public Class BuscarPedidos
    Public Nomprov, telprov, CiudProv, Dir As String
    Public idpedido As Integer




    Private Sub NomProvToolStripTextBox_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles NomProvToolStripTextBox.TextChanged
        Try
            Me.BuscarPedidosTableAdapter.Fill(Me.BuscarDSDataSet.BuscarPedidos, "%" & NomProvToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BuscarPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.BuscarPedidosTableAdapter.FillBytodos(Me.BuscarDSDataSet.BuscarPedidos)

        Catch ex As Exception

        End Try
    End Sub

    Private Sub BuscarPedidosDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarPedidosDataGridView.DoubleClick

        My.Forms.Ingresos.IdPedidoTB.Text = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).IdPed
        My.Forms.Ingresos.NombreProvTB.Text = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).NomProv
        My.Forms.Ingresos.TelefonoProvTB.Text = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).TelefProv
        My.Forms.Ingresos.DireccionProvTB.Text = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).DirProv
        My.Forms.Ingresos.CiudadProvTB.Text = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).CiudadProv

        idpedido = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).IdPed
        Nomprov = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).NomProv
        telprov = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).TelefProv
        Dir = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).DirProv
        CiudProv = Me.BuscarDSDataSet.BuscarPedidos(Me.BuscarPedidosBindingSource.Position).CiudadProv

        Me.Close()
    End Sub

    
End Class