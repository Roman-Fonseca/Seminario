Public Class Ejemplares

    Public COD_EJEMPLAR_MODIFICAR As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarEjemplar_Click(sender As Object, e As EventArgs) Handles btnAgregarEjemplar.Click
        AgregarEjemplar.Text = "Agregar Ejemplar"
        AgregarEjemplar.btnAgregar.Text = "Cargar Ejemplar"
        AgregarEjemplar.txtBuscarlibro.Text = ""
        AgregarEjemplar.txtNumeroEjemplar.Text = ""
        AgregarEjemplar.txtLibro.Text = ""
        AgregarEjemplar.cbxPlazoPrestamo.Text = ""
        AgregarEjemplar.cbxTipoEjemplar.Text = ""
        AgregarEjemplar.ShowDialog()
    End Sub

    Private Sub Ejemplares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.mostrarEjemplares()
    End Sub

    Private Sub btnModificarEjemplar_Click(sender As Object, e As EventArgs) Handles btnModificarEjemplar.Click
        COD_EJEMPLAR_MODIFICAR = Me.listaEjemplares.SelectedRows.Item(0).Cells(0).Value
        AgregarEjemplar.Text = "Modificar Ejempplar"
        AgregarEjemplar.txtLibro.Text = ""
        AgregarEjemplar.txtBuscarlibro.Text = ""
        AgregarEjemplar.txtNumeroEjemplar.Text = ""
        consultarEjemplarModificar(COD_EJEMPLAR_MODIFICAR)
        AgregarEjemplar.btnAgregar.Text = "Guardar cambios"
        AgregarEjemplar.ShowDialog()
    End Sub

    Public Sub consultarEjemplarModificar(cod_ejemplar As Integer)

        Dim Consulta As String = "SELECT ejemplar.cod_ejemplar, ejemplar.numero_ejemplar, ejemplar.estado, libro.titulo, 
                                tipo_ejemplar.descripcion AS tipo, plazo_prestamo.descripcion FROM ejemplar INNER JOIN libro ON ejemplar.cod_libro = libro.cod_libro 
                                INNER JOIN tipo_ejemplar ON ejemplar.cod_tipo_ejemplar = tipo_ejemplar.cod_tipo_ejemplar INNER JOIN plazo_prestamo 
                                ON ejemplar.cod_plazo_prestamo = plazo_prestamo.cod_plazo_prestamo WHERE cod_ejemplar = " & cod_ejemplar & ""
        If conexion.ConexionMySQL() Then
            Glocomando.CommandText = Consulta
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader


            Dim dt As New DataTable
            dt.Load(Glodatareader)


            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)

            Try

                AgregarEjemplar.txtNumeroEjemplar.Text = Trim((CStr(row("numero_ejemplar"))))
                AgregarEjemplar.txtLibro.Text = Trim((CStr(row("titulo"))))
                AgregarEjemplar.cbxTipoEjemplar.SelectedItem = Trim((row("cod_tipo_ejemplar")))
                AgregarEjemplar.cbxTipoEjemplar.Text = Trim((CStr(row("cod_plazo_prestamo"))))
                Glodatareader.Close()
                GloconexionDB.Close()
            Catch ex As Exception
                GloconexionDB.Close()

            End Try
        End If
    End Sub



End Class