Public Class AbonosDxCVentas
    Dim item As Integer = 0

    Private Sub AbonosDxCVentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cont As Integer
        Me.MaxAbonoDXCTableAdapter.FillByCuentaAbono(Me.AgaciaBDDataSet1.MaxAbonoDXC)
        cont = Me.AgaciaBDDataSet1.MaxAbonoDXC(Me.MaxAbonoDXCBindingSource.Position).Column1
        If cont = 0 Then
            Me.IdAbonoDxCLabel1.Text = 30001
        Else
            Me.MaxAbonoDXCTableAdapter.FillMaxAbonoDXC(Me.AgaciaBDDataSet1.MaxAbonoDXC)
            cont = Me.AgaciaBDDataSet1.MaxAbonoDXC(Me.MaxAbonoDXCBindingSource.Position).Column1
            cont += 1
            Me.IdAbonoDxCLabel1.Text = cont.ToString
        End If
    End Sub

    Private Sub BuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBtn.Click
        My.Forms.ConsultarCobros.ShowDialog()
        Try
            Dim cont As Integer = 0
            Me.VerAbonosXIdClieTableAdapter.FillAbonoXClie(Me.AgaciaBDDataSet1.VerAbonosXIdClie, CType(Me.CodCobro.Text, Decimal))
            cont = Me.DataGridView1.RowCount
            If cont = 0 Then
                MsgBox("El cliente no ha realizado ninún abono a la cuenta")
                Me.Label11.Text = Me.MontoTotal.Text
            Else
                Dim suma As Double = 0
                For I As Integer = 0 To cont - 1
                    suma = suma + Me.DataGridView1.Rows(I).Cells(3).Value
                Next
                Me.Label8.Text = suma.ToString
                Me.Label11.Text = (CInt(Me.MontoTotal.Text) - suma).ToString

            End If



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub






    Private Sub NuevoAbonoTB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NuevoAbonoTB.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
            MsgBox("Sólo se admiten valores numéricos")

        End If
    End Sub

    Private Sub AñadirAbonoBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AñadirAbonoBTN.Click
        If Me.NuevoAbonoTB.Text = Nothing Or Me.CodCobro.Text = Nothing Then
            MsgBox("Debe seleccionar el código del cobro y digitar el nuevo abono", MsgBoxStyle.Information, "Agacia")
        Else
            If CInt(Me.NuevoAbonoTB.Text) > CInt(Me.Label11.Text) Then
                MsgBox("El Nuevo abono es mayor que el saldo")
                Me.NuevoAbonoTB.Text = Nothing
                Me.NuevoAbonoTB.Focus()

            End If
        End If
    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        If Me.CodCobro.Text = Nothing Or Me.NuevoAbonoTB.Text = Nothing Then
            MsgBox("Faltan datos por llenar")
        Else
            If MsgBox("¿Está seguro que desea abonar " + Me.NuevoAbonoTB.Text + "  a la cuenta?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim obj As New Clasesdelproyecto.EjecutaSentencias
                obj.ejecutar_sql("Insert into AbonosDxC( IdAbonoDxC, FechaAbonoDxC, IdDxC, AbonoDxC)values(" + CInt(Me.IdAbonoDxCLabel1.Text).ToString + "," + Clasesdelproyecto.Class1.convetirfecha(Me.DateTimePicker1.Text) + "," + CInt(Me.CodCobro.Text).ToString + "," + CInt(Me.NuevoAbonoTB.Text).ToString + ")")
                Me.Label11.Text = (CInt(Label11.Text) - CInt(NuevoAbonoTB.Text)).ToString
                Me.NuevoAbonoTB.Enabled = False
                If CInt(Me.Label8.Text) = CInt(Me.MontoTotal.Text) Then
                    obj.ejecutar_sql("UPDATE  Facturas Set Saldada= SI where IdFact=" + CInt(Me.Numfact.Text).ToString + "")
                End If
                MsgBox("El abono se realizó satisfactoriamente")
                Me.NuevoAbonoTB.Enabled = False
                Me.DateTimePicker1.Enabled = False
                Me.GuardarBtn.Enabled = False
                Me.CancelarBtn.Enabled = False
                Me.VerAbonosXIdClieTableAdapter.FillAbonoXClie(Me.AgaciaBDDataSet1.VerAbonosXIdClie, CType(Me.CodCobro.Text, Decimal))
                Dim suma As Double = 0
                Dim cont As Integer = 0
                cont = Me.DataGridView1.RowCount
                For I As Integer = 0 To cont - 1
                    suma = suma + Me.DataGridView1.Rows(I).Cells(3).Value
                Next
                Me.Label8.Text = suma.ToString
                Me.Label11.Text = (CInt(Me.MontoTotal.Text) - suma).ToString

            End If

        End If
    End Sub
End Class