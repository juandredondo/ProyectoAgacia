Public Class ModificaDetFactFrm

    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        If CInt(cantidad.Text) > CInt(existemod.Text) Then
            MsgBox("la cantidad digitada es mayor que la existencia", MsgBoxStyle.Exclamation, "AGACIA")
            Me.cantidad.Text = Nothing
            Me.cantidad.Focus()
        Else
            My.Forms.Ventas.DataGridView1.Rows(CInt(itemmod.Text) - 1).Cells(3).Value = cantidad.Text
            My.Forms.Ventas.DataGridView1.Rows(CInt(itemmod.Text) - 1).Cells(5).Value = CInt(vrunit.Text) * CInt(cantidad.Text)
            Me.Close()
        End If
    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Me.Close()
    End Sub

    Private Sub cantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cantidad.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se admiten valores numericos")
        End If
    End Sub
End Class