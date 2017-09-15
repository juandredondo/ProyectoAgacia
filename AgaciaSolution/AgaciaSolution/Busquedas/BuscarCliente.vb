Public Class BuscarCliente
    Public IDCLIE, NOMCLIE, TIPOCLIE, DIRCLIE, TELEFCLIE, EMAILCLIE, SEXOCLIE, CIUDADCLIE, ACTIVOCLIE As String

  

    Private Sub BuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet1.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.AgaciaBDDataSet1.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'AgaciaBDDataSet1.Clientes' Puede moverla o quitarla según sea necesario.




    End Sub

    Private Sub CriterioCB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CriterioCB.SelectedIndexChanged
        Dim Pn As String
        Dim Pj As String
        Pn = "PERSONA NATURAL"
        Pj = "PERSONA JURIDICA"
        If Me.CriterioCB.Text = Pj.Trim Then

            Try
                Me.ClientesTableAdapter.FillByTipPJ(Me.AgaciaBDDataSet1.Clientes)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)

            End Try
        ElseIf Me.CriterioCB.Text = Pn.Trim Then
            Try
                Me.ClientesTableAdapter.FillByTipPN(Me.AgaciaBDDataSet1.Clientes)
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try


        End If
    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AgaciaBDDataSet1)

    End Sub

    Private Sub TextoTB_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoTB.TextChanged
        
        Dim var As String
        var = Me.CriterioCB.Text
        If var = "PERSONA NATURAL" Then
            Try
                Me.ClientesTableAdapter.FillByTipPNnombre(Me.AgaciaBDDataSet1.Clientes, "%" & Me.TextoTB.Text & "%")
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        ElseIf var = "PERSONA JURIDICA" Then
            Try
                Me.ClientesTableAdapter.FillByTipPJNombre(Me.AgaciaBDDataSet1.Clientes, "%" & Me.TextoTB.Text & "%")
            Catch ex As Exception
                MessageBox.Show(ex.Message.ToString)
            End Try
        End If

        
    End Sub

    Private Sub ClientesDataGridView_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesDataGridView.DoubleClick
        Try
            IDCLIE = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).IdClie
            NOMCLIE = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).NomClie
            'TIPOCLIE = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).TipClie
            DIRCLIE = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).DirClie
            TELEFCLIE = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).TelefClie
            EMAILCLIE = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).EmailClie
            'SEXOCLIE = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).SexoClie
            CIUDADCLIE = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).CiudadClie
            ACTIVOCLIE = Me.AgaciaBDDataSet1.Clientes(Me.ClientesBindingSource.Position).ActivoClie
            Me.CriterioCB.Text = Nothing
            Me.TextoTB.Text = Nothing
            Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)

        End Try
    End Sub

    Private Sub TextoTB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextoTB.Click
        If Me.CriterioCB.Text = Nothing Then

            MsgBox("Debe escoger el tipo de cliente", MsgBoxStyle.Information, "AGACIA")
            Me.CriterioCB.Focus()

        End If
    End Sub
End Class