Public Class LoginForm1

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim Ingreso As New Clasesdelproyecto.ClaseIngreso("Data Source=ZEUS;Initial Catalog=AgaciaBD;Persist Security Info=True;User ID=sa;Password=programacion")
        Dim Respuesta As String
        Respuesta = Ingreso.VerificarAcceso(UsernameTextBox.Text, PasswordTextBox.Text)
        MessageBox.Show(Respuesta)
        If Respuesta.Substring(0, 1) = "B" Then
            Visible = False
            MDIParent1.ShowDialog()
            Close()
        End If
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
