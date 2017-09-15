Public Class ListadoDxP


    Private Sub ListadoDxP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet1.ConsultaCxP' Puede moverla o quitarla según sea necesario.
        Me.ConsultaCxPTableAdapter.FillConsultaDxP(Me.AgaciaBDDataSet1.ConsultaCxP)

    End Sub
End Class