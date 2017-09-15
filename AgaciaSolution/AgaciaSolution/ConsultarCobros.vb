Public Class ConsultarCobros

    

    Private Sub ConsultarCobros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            Me.ConsultaCobrosTableAdapter.FillByConsultacobrosTodos(Me.AgaciaBDDataSet1.ConsultaCobros)
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
    End Sub

    

    Private Sub TextoCB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoCB.TextChanged
        Dim OPC As String
        OPC = Me.CriterioCB.Text
        Select Case OPC
            Case "NOMBRE"
                Try
                    Me.ConsultaCobrosTableAdapter.FillByNom(Me.AgaciaBDDataSet1.ConsultaCobros, "%" & Me.TextoCB.Text & "%")
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
            Case "IDENTIFICACION"

                Try
                    Me.ConsultaCobrosTableAdapter.FillByconsultaxid(Me.AgaciaBDDataSet1.ConsultaCobros, "%" & Me.TextoCB.Text & "%")
                Catch ex As Exception
                    MsgBox(ex.Message.ToString)
                End Try
        End Select

        
    End Sub

    
    Private Sub ConsultaCobrosDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaCobrosDataGridView.DoubleClick

        My.Forms.AbonosDxCVentas.CodCobro.Text = Me.AgaciaBDDataSet1.ConsultaCobros(Me.ConsultaCobrosBindingSource.Position).IdDxC
        My.Forms.AbonosDxCVentas.Numfact.Text = Me.AgaciaBDDataSet1.ConsultaCobros(Me.ConsultaCobrosBindingSource.Position).IdFact
        My.Forms.AbonosDxCVentas.NomClie.Text = Me.AgaciaBDDataSet1.ConsultaCobros(Me.ConsultaCobrosBindingSource.Position).NomClie
        My.Forms.AbonosDxCVentas.IdClie.Text = Me.AgaciaBDDataSet1.ConsultaCobros(Me.ConsultaCobrosBindingSource.Position).IdClie
        My.Forms.AbonosDxCVentas.MontoTotal.Text = Me.AgaciaBDDataSet1.ConsultaCobros(Me.ConsultaCobrosBindingSource.Position).TOTAL_FACTURA

        Me.Close()

    End Sub
End Class