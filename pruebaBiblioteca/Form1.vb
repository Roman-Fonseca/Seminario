Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnConectar.Click
        conexion.probarConexion()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        AgregarSocio.ShowDialog()
        AgregarSocio.Text = "AgregarProducto"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnSocios.Click
        moduloBiblioteca.mostrarSocios()
        Socios.ShowDialog()
    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles btnLibros.Click
        CargarLibro.ShowDialog()
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles btnEjemplares.Click

    End Sub
End Class
