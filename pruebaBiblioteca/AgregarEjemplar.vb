Imports MySql.Data.MySqlClient

Public Class AgregarEjemplar
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTipoEjemplar.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEstado.SelectedIndexChanged

    End Sub

    Private Sub btnAgregarTipoEjemplar_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoEjemplar.Click
        AgregarTipoEjemplar.ShowDialog()
    End Sub

    Private Sub AgregarEjemplar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.CargarComboTipoEjemplar()
        moduloBiblioteca.llenarGrillaLibros(dgvLibros)
        moduloBiblioteca.CargarComboPlazoPrestamo()
    End Sub

    Private Sub btnSeleccionarLibro_Click(sender As Object, e As EventArgs)
        'SeleccionarLibro.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibros.CellContentClick

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblLibros.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarlibro.TextChanged
        moduloBiblioteca.busquedaDinamicaLibro(txtBuscarlibro.Text, dgvLibros)
    End Sub

    Private Sub btnSeleccionarLibro_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionarLibro.Click
        GLO_CodLibro = Me.dgvLibros.SelectedRows.Item(0).Cells(0).Value
        GLO_TituloLibro = Me.dgvLibros.SelectedRows.Item(0).Cells(2).Value

        If IsDBNull(buscarUltimoNumeroEjemplar(GLO_CodLibro)) Then
            Me.txtNumeroEjemplar.Text = 1
        Else
            Me.txtNumeroEjemplar.Text = buscarUltimoNumeroEjemplar(GLO_CodLibro) + 1
        End If

        Me.txtLibro.Text = GLO_TituloLibro.ToString


    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        moduloBiblioteca.altaEjemplar()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarLibro.ShowDialog()
    End Sub

    Private Sub txtNumeroEjemplar_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroEjemplar.TextChanged

    End Sub

    Private Function buscarUltimoNumeroEjemplar(cod_libro) As Integer
        Dim Sql As String = "SELECT numero_ejemplar FROM ejemplar WHERE cod_libro = '" & cod_libro & "' ORDER BY numero_ejemplar DESC LIMIT 1"
        Dim numero_ejemplar As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("numero_ejemplar"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    numero_ejemplar = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return numero_ejemplar
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
        AgregarPlazoPrestamo.Show()
    End Sub
End Class