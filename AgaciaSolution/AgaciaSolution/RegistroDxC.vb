Imports System
Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException

Public Class RegistroDxC

    Private Sub RegistroDxC_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet1.DxC' Puede moverla o quitarla según sea necesario.
        ' Me.DxCTableAdapter.Fill(Me.AgaciaBDDataSet1.DxC)
        Dim cont As Integer
        Me.MaxDxCTableAdapter.FillBycuentaDXC(Me.AgaciaBDDataSet1.MaxDxC)
        cont = Me.AgaciaBDDataSet1.MaxDxC(Me.MaxDxCBindingSource.Position).Column1
        If cont = 0 Then
            Me.IdDXCTB.Text = 101
        Else
            Me.MaxDxCTableAdapter.FillmaxDXC(Me.AgaciaBDDataSet1.MaxDxC)
            cont = Me.AgaciaBDDataSet1.MaxDxC(Me.MaxDxCBindingSource.Position).Column1
            cont += 1
            Me.IdDXCTB.Text = cont.ToString
        End If

    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        Try
            Dim fecha As String

            fecha = Clasesdelproyecto.Class1.convetirfecha(Me.DateTimePicker1.Text)
            Dim conexion As New SqlConnection("Data Source=ZEUS;Initial Catalog=AgaciaBD;Persist Security Info=True;User ID=sa;Password=programacion")
            Dim cmd As New SqlCommand("dbo.InsertaDXC", conexion)
            cmd.CommandType = CommandType.StoredProcedure

            Dim Parametro As New SqlParameter()
            Parametro.ParameterName = "idDXC"
            Parametro.DbType = DbType.Int16
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = Integer.Parse(Me.IdDXCTB.Text)
            cmd.Parameters.Add(Parametro)

            Parametro = New SqlParameter()
            Parametro.ParameterName = "fechavecfact"
            Parametro.DbType = DbType.DateTime
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = fecha
            cmd.Parameters.Add(Parametro)


            Parametro = New SqlParameter()
            Parametro.ParameterName = "idfacDXC"
            Parametro.DbType = DbType.Int32
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = Integer.Parse(Me.IdfactTB.Text)
            cmd.Parameters.Add(Parametro)


            Parametro = New SqlParameter()
            Parametro.ParameterName = "totalcargo"
            Parametro.DbType = DbType.Double
            Parametro.Direction = ParameterDirection.Input
            Parametro.Value = Integer.Parse(Me.MontoTotalTB.Text)
            cmd.Parameters.Add(Parametro)

            Try
                conexion.Open()
                cmd.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            Finally
                conexion.Close()
            End Try
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Me.Close()

    End Sub

End Class