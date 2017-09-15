Public Class RegistroDxP

 
    Private Sub RegistroDxP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As Integer
        Me.MaxDXPTableAdapter.FillCuentaDXP(Me.AgaciaBDDataSet1.MaxDXP)
        con = Me.AgaciaBDDataSet1.MaxDXP(Me.MaxDXPBindingSource.Position).Column1
        If con = 0 Then
            Me.IdDxPLabel1.Text = 1001
        Else
            Me.MaxDXPTableAdapter.FillByMaxDXP(Me.AgaciaBDDataSet1.MaxDXP)
            con = Me.AgaciaBDDataSet1.MaxDXP(Me.MaxDXPBindingSource.Position).Column1
            con += 1
            Me.IdDxPLabel1.Text = con.ToString
        End If
    End Sub

    Private Sub BuscarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarBtn.Click
        My.Forms.BuscarPedidos.ShowDialog()
        Me.IdPedDXPTextBox.Text = My.Forms.BuscarPedidos.idpedido
        Me.NomProvTextBox.Text = My.Forms.BuscarPedidos.Nomprov
        Me.CiudadProvTextBox.Text = My.Forms.BuscarPedidos.CiudProv
        Me.TelefProvTextBox.Text = My.Forms.BuscarPedidos.telprov
        Me.DirprovedorTB.Text = My.Forms.BuscarPedidos.Dir
    End Sub

    Private Sub CancelarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelarBtn.Click
        Me.Close()
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirBtn.Click
        Me.Close()
    End Sub

    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        If Me.IdPedDXPTextBox.Text = Nothing Or Me.NumfactCompraTB.Text = Nothing Or Me.MontoDxPTextBox.Text = Nothing Then
            MsgBox("Faltan datos por llenar", MsgBoxStyle.Exclamation, "AGACIA")
        Else
            Dim obj As New Clasesdelproyecto.EjecutaSentencias
            obj.ejecutar_sql("Insert into DxP(IdDxP, FechaEmiFactuDXP, NumFactCompraDXP, IdPedDXP, MontoDxP) values(" + CInt(Me.IdDxPLabel1.Text).ToString + "," + Clasesdelproyecto.Class1.convetirfecha(Me.DateTimePicker1.Text) + ", " + CInt(Me.NumfactCompraTB.Text).ToString + "," + CInt(Me.IdPedDXPTextBox.Text).ToString + "," + CInt(Me.MontoDxPTextBox.Text).ToString + ")")
            MsgBox("Los datos fueron guardados exitosamente", MsgBoxStyle.Information, "AGACIA")
            Me.DateTimePicker1.Enabled = False
            Me.NumfactCompraTB.Enabled = False
            Me.MontoDxPTextBox.Enabled = False
            Me.GuardarBtn.Enabled = False
            Me.CancelarBtn.Enabled = False
        End If
    End Sub

    Private Sub NumfactCompraTB_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumfactCompraTB.KeyPress, MontoDxPTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsSeparator(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se admiten valores numéricos", MsgBoxStyle.Exclamation, "Agacia")
        End If
    End Sub
End Class