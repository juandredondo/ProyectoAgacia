Public Class ModificarCanped
    Private Sub aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles aceptar.Click
        My.Forms.Pedidos.DataGridView1.Rows(CInt(itemmod.Text) - 1).Cells(3).Value = cantidad.Text
        Me.Close()
    End Sub

    Private Sub cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelar.Click
        Close()
    End Sub

    Private Sub cantidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cantidad.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se admiten valores numericos")
        End If

    End Sub
End Class