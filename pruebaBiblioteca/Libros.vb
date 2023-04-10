Imports MySql.Data.MySqlClient

Public Class Libros
    Dim dt As New DataTable
    Private Sub Libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.mostrarLibros()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        GLO_CodLibro = Me.dgvLibros.SelectedRows.Item(0).Cells(0).Value
        AgregarLibro.Text = "Modificar libro"
        AgregarLibro.ShowDialog()
    End Sub

    Private Sub dgvLibros_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibros.CellContentClick
        Dim cod_libro As Integer = Me.dgvLibros.SelectedRows.Item(0).Cells(0).Value
        mostrarAutoresDelLibro(cod_libro)
        mostrarCategoriasDelLibro(cod_libro)
    End Sub

    Public Sub mostrarAutoresDelLibro(cod_libro As Integer)
        Dim Consulta As String = "SELECT autor.nombre, autor.apellido from autor INNER JOIN libro_autor ON autor.cod_autor = libro_autor.cod_autor WHERE libro_autor.cod_libro = " & cod_libro & ";"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Me.dgvAutoresLibro.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Public Sub mostrarCategoriasDelLibro(cod_libro As Integer)
        Dim Consulta As String = "SELECT categoria.nombre from categoria INNER JOIN categoria_libro ON 
        categoria.cod_categoria = categoria_libro.cod_categoria WHERE categoria_libro.cod_libro = " & cod_libro & ""
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Me.dgvCategoria.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Public Sub busquedaDinamicaLibro(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("SELECT * FROM libro WHERE titulo like '" & nombre + "%" & "'", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error con busqueda dinamica", ex.ToString)
        End Try
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Me.busquedaDinamicaLibro(Me.TextBox1.Text, dgvLibros)
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

    End Sub
End Class