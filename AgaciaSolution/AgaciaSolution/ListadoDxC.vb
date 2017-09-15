Public Class ListadoDxC

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Me.ConsultaCobrosTableAdapter.FillByConsultacobrosTodos(Me.AgaciaBDDataSet1.ConsultaCobros)
        Catch ex As Exception

        End Try

    End Sub
End Class