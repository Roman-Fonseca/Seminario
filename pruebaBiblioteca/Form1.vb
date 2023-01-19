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
        AgregarLibro.ShowDialog()
    End Sub

    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles btnEjemplares.Click
        Ejemplares.ShowDialog()
    End Sub

    Private Sub btnPrestamos_Click(sender As Object, e As EventArgs) Handles btnPrestamos.Click
        Prestamos.ShowDialog()
    End Sub

    Private Sub btnPlazoPrestamo_Click(sender As Object, e As EventArgs) Handles btnPlazoPrestamo.Click
        AgregarPlazoPrestamo.ShowDialog()
    End Sub

    Private Sub Button1_Click_5(sender As Object, e As EventArgs) Handles Button1.Click
        moduloBiblioteca.prueba()
    End Sub

    Private Sub AgregarPrestamoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPrestamoToolStripMenuItem.Click
        AgregarPrestamo.Text = "Agregar Prestamo"
        AgregarPrestamo.btnFinalizarPrestamo.Hide()
        AgregarPrestamo.ShowDialog()
    End Sub

    Private Sub SociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SociosToolStripMenuItem.Click

    End Sub

    Private Sub VerSociosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerSociosToolStripMenuItem.Click
        moduloBiblioteca.mostrarSocios()
        Socios.ShowDialog()
    End Sub

    Private Sub AgregarSocioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarSocioToolStripMenuItem.Click
        AgregarSocio.Text = "Agregar Socio"
        AgregarSocio.ShowDialog()
    End Sub

    Private Sub TodosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem1.Click
        Prestamos.ShowDialog()
    End Sub

    Private Sub AgregarEjemplarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEjemplarToolStripMenuItem.Click
        AgregarEjemplar.ShowDialog()
    End Sub

    Private Sub AgregarPlazoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPlazoToolStripMenuItem.Click
        AgregarPlazoPrestamo.ShowDialog()
    End Sub

    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem.Click
        Ejemplares.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Captura la fecha Actual con formato
        Dim fecha_actual As Date
        fecha_actual = Format(Today, "yyyy-MM-dd")
        MsgBox(fecha_actual)

        'Captura la hora actual con formato
        Dim hora_actual As DateTime
        hora_actual = Format(TimeOfDay, "Long Time")
        MsgBox(hora_actual)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SanciónEsperaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanciónEsperaToolStripMenuItem.Click
        AgregarParametroEspera.ShowDialog()
    End Sub

    Private Sub SanciónDineroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanciónDineroToolStripMenuItem.Click

    End Sub
End Class
