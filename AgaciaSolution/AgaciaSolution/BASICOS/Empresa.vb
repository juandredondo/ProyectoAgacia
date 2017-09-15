Imports System.IO

Public Class Empresa
    Public Registrada As Integer

    Public Sub HabilitaBotones(ByVal Editar As Boolean, ByVal Guardar As Boolean, ByVal Salir As Boolean, ByVal Cancelar As Boolean)
        Me.EditarBtn.Enabled = Editar
        Me.GuardarBtn.Enabled = Guardar
        Me.SalirBtn.Enabled = Salir
        Me.CancelarBtn.Enabled = Cancelar
    End Sub

    Private Sub Empresa_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'ejecutamos cuentaempresa
        Registrada = EmpresaTableAdapter.CuentaEmpresa


        If (Registrada <> 0) Then
            HabilitaBotones(True, False, True, False)
            For Each ctrl As Control In InfoGB.Controls
                ctrl.Enabled = False
            Next
        ElseIf (Registrada = 0) Then
            Me.EmpresaBindingSource.AddNew()
            'si registrada es falso habilita para agregar una nueva empresa
            For Each ctrl As Control In InfoGB.Controls
                ctrl.Enabled = True
            Next
            HabilitaBotones(False, True, True, True)
            Button1.Enabled = True
            'habrimos en modo addnew
        End If
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet.Empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.BasicoDs.Empresa)

    End Sub
    Private Sub EditarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditarBtn.Click
        For Each ctrl As Control In InfoGB.Controls
            ctrl.Enabled = True
        Next
        HabilitaBotones(False, True, True, True)

    End Sub
    Private Sub TelefaxEmpreTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TelefEmpreTextBox.KeyPress, TelefaxEmpreTextBox.KeyPress, NitEmpreTextBox.KeyPress, CodPostalEmpreTextBox.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("En este Campo solo se puede digitar numeros y '-'")
        End If
    End Sub
    Private Sub GuardarBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GuardarBtn.Click
        Dim vacio As Boolean
        'comfirmamos que todos los datos esten llenos
        For Each ctrl As Control In InfoGB.Controls
            If TypeOf ctrl Is TextBox Then
                If ctrl.Text = Nothing Then
                    If EmailEmpreTextBox.Text = Nothing Or WebEmpreTextBox.Text = Nothing Then
                        vacio = False
                    Else
                        vacio = True
                    End If
                End If
            End If
        Next
        If vacio = True Then
            MsgBox("Debe llenar todos los campos")
        Else
            'guardamos 
            Try
                Me.Validate()
                Me.EmpresaBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.BasicoDs)
                MsgBox("Datos Guardados correctamente", MsgBoxStyle.Information)


            Catch ex As Exception
                MsgBox(ex.Message.ToString, MsgBoxStyle.Critical)
            End Try
        End If
        HabilitaBotones(True, False, True, False)
        For Each ctrl As Control In InfoGB.Controls
            ctrl.Enabled = False
        Next
        Me.InfoGB.Enabled = False
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim conn As New System.Data.SqlClient.SqlConnection 'conexion con la base de datos
        Dim cmd As New System.Data.SqlClient.SqlCommand 'sentencia sql a utilizar
        Dim pa As New System.Data.SqlClient.SqlParameter("@data", SqlDbType.VarBinary, 50) 'parametro de la sentencia sql
        Dim data() As Byte 'arreglo de bytes el cual contedra la imagen
        Dim ios As FileStream 'Manejo de archivos
        Try
            Me.AbrirImagenOFD.Filter = "Imagenes (BMP)|*.bmp" 'filtro de archivos del OpenFileDialog 
            If Me.AbrirImagenOFD.ShowDialog() = Windows.Forms.DialogResult.Cancel Then ' en caso de que se aplaste el boton cancelar salga y no haga nada
                Exit Sub
            Else
                ios = New FileStream(Me.AbrirImagenOFD.FileName, FileMode.Open, FileAccess.Read) 'instanciamos en Stream indicandole la ruta del arvhivo,el modo de acceso y si es de lectura o escritura
                ReDim data(ios.Length) 'llenamos el arreglo
                ios.Read(data, 0, CInt(ios.Length)) 'llenamos el arreglo
                Me.LogoEmprePictureBox.SizeMode = PictureBoxSizeMode.StretchImage 'establecemos como se visualiza la imagen
                Me.LogoEmprePictureBox.Load(Me.AbrirImagenOFD.FileName) 'visualizamos abriendo el archivo seleccionado
                Me.LogoEmprePictureBox.ImageLocation = AbrirImagenOFD.FileName
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification) 'en caso de error muestre un mensaje
        End Try
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.EmpresaBindingSource.AddNew()
        For Each ctrl As Control In InfoGB.Controls
            ctrl.Enabled = True
            HabilitaBotones(False, True, True, True)
        Next
    End Sub

    Private Sub RepEmpreTextBox_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RepEmpreTextBox.KeyPress, CiudadEmpreTextBox.KeyPress
        If Char.IsNumber(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Then
            e.Handled = True
            MsgBox("Este campo no admite valores numericos ni simbolos!", MsgBoxStyle.Information, "Agacia")

        End If
    End Sub
End Class