Imports MySql.Data.MySqlClient

Public Class AgregarLibro

    Public COD_CATEGORIA As Integer
    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub lblUbicacion_Click(sender As Object, e As EventArgs) Handles lblUbicacion.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblEditorial.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarUbicacion.Click
        AgregarUbicacion.ShowDialog()
    End Sub

    Private Sub btnAgregarEditorial_Click(sender As Object, e As EventArgs) Handles btnAgregarEditorial.Click
        AgregarEditorial.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUbicacion.SelectedIndexChanged

    End Sub

    Private Sub CargarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.CargarComboUbicacion()
        moduloBiblioteca.CargarComboEditorial()
        moduloBiblioteca.CargarComboCategoria()
        cargarTablaCategoria()
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        AgregarCategoria.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAutor.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarAutor.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim a As Integer

        a = MsgBox("Desea cancelar carga", MsgBoxStyle.YesNo, "Cargar libro")
        If a = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSeleccionarAutor_Click(sender As Object, e As EventArgs) Handles btnSeleccionarAutor.Click
        SeleccionAutor.ShowDialog()
    End Sub

    Private Sub btnLimpiarCamposAutor_Click(sender As Object, e As EventArgs) Handles btnLimpiarCamposAutor.Click
        LimpiarCampos.limpiarCamposCargarLibro()
    End Sub

    Private Sub btnGuardarAutor_Click(sender As Object, e As EventArgs) Handles btnGuardarAutor.Click
        If Me.Text = "Alta libro" Then
            moduloBiblioteca.altaLibro()
        Else
            moduloBiblioteca.modificarLibro()
        End If

    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtAutor_TextChanged(sender As Object, e As EventArgs) Handles txtAutor.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs) Handles btnCategoria.Click
        COD_CATEGORIA = Me.dgvCategoria.SelectedRows.Item(0).Cells(0).Value
        Me.listBoxCategoria.Items.Add(tomarCodCategoria(COD_CATEGORIA))
    End Sub

    Public Function tomarCodCategoria(COD_CATEGORIA As Integer) As String
        Dim Sql As String = "Select cod_categoria from categoria where cod_categoria=" & COD_CATEGORIA
        Dim estado As String
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As String = Trim(Datos("cod_categoria"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    estado = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return estado
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            'Cerramos la conexion a la BBDD MySQL
            Conexion.Close()

            'Eliminamos de la memoria el objeto CONSULTA que habiamos creado
            consulta = Nothing
            Return False
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (listBoxCategoria.SelectedIndex > -1) Then

            ' Eliminamos el elemento que se encuentra seleccionado 
            '
            listBoxCategoria.Items.RemoveAt(listBoxCategoria.SelectedIndex)

        End If
    End Sub
End Class