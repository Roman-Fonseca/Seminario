Imports MySql.Data.MySqlClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim fecha As Date
        fecha = Today
        Label1.Text = fecha
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
        AgregarSocio.txtEstado.Hide()
        AgregarSocio.lblEstadoSocio.Hide()
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

    Private Sub SanciónEsperaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanciónEsperaToolStripMenuItem.Click
        AgregarParametroEspera.ShowDialog()
    End Sub

    Private Sub SanciónDineroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanciónDineroToolStripMenuItem.Click
        AgregarParametroPago.ShowDialog()
    End Sub

    Private Sub PrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem.Click

    End Sub

    Private Sub PagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PagoToolStripMenuItem.Click
        SancionesPago.ShowDialog()
    End Sub

    Private Sub VerLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLibrosToolStripMenuItem.Click
        AgregarLibro.ShowDialog()
    End Sub

    Private Sub VerLibrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerLibrosToolStripMenuItem1.Click
        Libros.ShowDialog()
    End Sub

    Private Sub SociosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SociosToolStripMenuItem1.Click
        informeSocios.ShowDialog()
    End Sub
End Class
