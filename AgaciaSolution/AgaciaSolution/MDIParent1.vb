Imports System.Windows.Forms
Imports System.Data

Imports System.Data.SqlClient
Imports System.Data.SqlClient.SqlException


Public Class MDIParent1

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cree una nueva instancia del formulario secundario.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Conviértalo en un elemento secundario de este formulario MDI antes de mostrarlo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Ventana " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: agregue código aquí para abrir el archivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: agregue código aquí para guardar el contenido actual del formulario en un archivo.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Utilice My.Computer.Clipboard para insertar el texto o las imágenes seleccionadas en el Portapapeles
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Utilice My.Computer.Clipboard.GetText() o My.Computer.Clipboard.GetData para recuperar la información del Portapapeles.
    End Sub

 

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Cierre todos los formularios secundarios del principal.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    
    
  


    
    Private Sub ClientesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesToolStripMenuItem.Click
        My.Forms.Clientes.MdiParent = Me
        My.Forms.Clientes.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        My.Forms.Ventas.MdiParent = Me
        My.Forms.Ventas.Show()


    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        My.Forms.Pedidos.MdiParent = Me
        My.Forms.Pedidos.Show()

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        My.Forms.RegistroDxP.MdiParent = Me
        My.Forms.RegistroDxP.Show()
    End Sub

    
    Private Sub NuevoIngresoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuevoIngresoToolStripMenuItem.Click
        My.Forms.Ingresos.MdiParent = Me
        My.Forms.Ingresos.Show()

    End Sub

   
    Private Sub AbonosDeCargosPorCobrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbonosDeCargosPorCobrarToolStripMenuItem.Click
        My.Forms.AbonosDxCVentas.MdiParent = Me
        My.Forms.AbonosDxCVentas.Show()

    End Sub

    Private Sub AsignarFacturaPorPagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignarFacturaPorPagarToolStripMenuItem.Click
        My.Forms.RegistroDxP.MdiParent = Me
        My.Forms.RegistroDxP.Show()



    End Sub

    Private Sub VerTodosLosCargosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerTodosLosCargosToolStripMenuItem.Click
        My.Forms.ListadoDxC.Show()
    End Sub

    Private Sub ListarFacturasPorPagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListarFacturasPorPagarToolStripMenuItem.Click
        My.Forms.ListadoDxP.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        My.Forms.Consultas.MdiParent = Me
        My.Forms.Consultas.Show()

    End Sub

    Private Sub MDIParent1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim Conexion As New SqlConnection("Data Source=ZEUS;Initial Catalog=AgaciaBD;Persist Security Info=True;User ID=sa;Password=programacion")
        Dim Comando As New SqlCommand("dbo.TRAERFUNCIONES", Conexion)
        Comando.CommandType = CommandType.StoredProcedure

        Dim Parametro As New SqlParameter()
        Parametro.ParameterName = "Login"
        Parametro.DbType = DbType.String
        Parametro.Direction = ParameterDirection.Input
        Parametro.Value = LoginForm1.UsernameTextBox.Text
        Comando.Parameters.Add(Parametro)

        Parametro = New SqlParameter()
        Parametro.ParameterName = "Password"
        Parametro.DbType = DbType.String
        Parametro.Direction = ParameterDirection.Input
        Parametro.Value = LoginForm1.PasswordTextBox.Text
        Comando.Parameters.Add(Parametro)

        Try
            Conexion.Open()
            Dim lector As SqlDataReader
            lector = Comando.ExecuteReader()
            While lector.Read()
                Select Case lector(0).ToString()
                    Case "VENTAS"
                        Button2.Visible = False
                    Case "CONSULTAS"
                        Button2.Visible = True

                End Select
            End While
            lector.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            Conexion.Close()
        End Try


    End Sub

    Private Sub EmpresaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpresaToolStripMenuItem.Click
        My.Forms.Empresa.MdiParent = Me
        My.Forms.Empresa.Show()
    End Sub

    Private Sub ProductosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosToolStripMenuItem.Click
        My.Forms.Productos.MdiParent = Me
        My.Forms.Productos.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProveedoresToolStripMenuItem.Click
        My.Forms.Proveedores.MdiParent = Me
        My.Forms.Proveedores.Show()
    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        My.Forms.Empleados.MdiParent = Me
        My.Forms.Empleados.Show()
    End Sub
End Class
