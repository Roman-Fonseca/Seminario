﻿Imports MySql.Data.MySqlClient
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
        AgregarSocio.btnLimpiarCampos.Show()
        AgregarSocio.lblEstadoSocio.Hide()
        AgregarSocio.ShowDialog()
    End Sub

    Private Sub TodosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem1.Click
        Prestamos.ShowDialog()
    End Sub

    Private Sub AgregarEjemplarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarEjemplarToolStripMenuItem.Click
        AgregarEjemplar.Text = "Agregar Ejemplar"
        AgregarEjemplar.btnAgregar.Text = "Cargar Ejemplar"
        AgregarEjemplar.txtBuscarlibro.Text = ""
        AgregarEjemplar.txtNumeroEjemplar.Text = ""
        AgregarEjemplar.txtLibro.Text = ""
        AgregarEjemplar.cbxPlazoPrestamo.Text = ""
        AgregarEjemplar.cbxTipoEjemplar.Text = ""
        AgregarEjemplar.ShowDialog()
    End Sub

    Private Sub AgregarPlazoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarPlazoToolStripMenuItem.Click
        AgregarPlazoPrestamo.ShowDialog()
    End Sub

    Private Sub TodosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TodosToolStripMenuItem.Click
        Ejemplares.ShowDialog()
    End Sub

    Private Sub SanciónEsperaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanciónEsperaToolStripMenuItem.Click
        'Limpio los campos y saco el color
        AgregarParametroEspera.txtMinimo.BackColor = Color.White
        AgregarParametroEspera.txtMaximo.BackColor = Color.White
        AgregarParametroEspera.txtSancion.BackColor = Color.White
        AgregarParametroEspera.txtMinimo.Text = ""
        AgregarParametroEspera.txtMaximo.Text = ""
        AgregarParametroEspera.txtSancion.Text = ""
        'Cambio el titulo del formulario
        AgregarParametroEspera.Text = "Agregar parametro espera"
        AgregarParametroEspera.btnGuardar.Text = "Cargar"
        AgregarParametroEspera.ShowDialog()
    End Sub

    Private Sub SanciónDineroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SanciónDineroToolStripMenuItem.Click
        'Limpio los campos y saco el color
        AgregarParametroPago.txtMinimo.BackColor = Color.White
        AgregarParametroPago.txtMaximo.BackColor = Color.White
        AgregarParametroPago.txtPagoCorrespondiente.BackColor = Color.White
        AgregarParametroPago.txtMinimo.Text = ""
        AgregarParametroPago.txtMaximo.Text = ""
        AgregarParametroPago.txtPagoCorrespondiente.Text = ""
        'Cambio el titulo del formulario
        AgregarParametroPago.Text = "Agregar parametro pago"
        AgregarParametroPago.btnGuardar.Text = "Cargar"
        AgregarParametroPago.ShowDialog()
    End Sub

    Private Sub PrestamosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem.Click

    End Sub

    Private Sub PagoToolStripMenuItem_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub VerLibrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerLibrosToolStripMenuItem.Click
        AgregarLibro.ShowDialog()
    End Sub

    Private Sub VerLibrosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VerLibrosToolStripMenuItem1.Click
        Libros.ShowDialog()
        'MsgBox(tomarUltimoPrestamoFinalizado)
    End Sub

    Private Sub SociosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SociosToolStripMenuItem1.Click
        FormularioReporteSocios.ShowDialog()
    End Sub

    Private Sub InformeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformeToolStripMenuItem.Click

    End Sub

    Private Sub PrestadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrestadosToolStripMenuItem.Click
        mostrarEjemplaresPrestados()
        Ejemplares.ShowDialog()
    End Sub

    Public Sub mostrarEjemplaresPrestados()
        Dim Consulta As String = "SELECT ejemplar.cod_ejemplar, ejemplar.numero_ejemplar, ejemplar.estado, libro.titulo, 
                                    plazo_prestamo.descripcion AS plazo, tipo_ejemplar.descripcion as tipo_ejemplar 
                                    FROM ejemplar INNER JOIN libro ON ejemplar.cod_libro = libro.cod_libro INNER JOIN plazo_prestamo 
                                    ON ejemplar.cod_plazo_prestamo = plazo_prestamo.cod_plazo_prestamo INNER JOIN tipo_ejemplar 
                                    ON ejemplar.cod_tipo_ejemplar = tipo_ejemplar.cod_tipo_ejemplar WHERE estado = 'Prestado'"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Ejemplares.listaEjemplares.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Private Sub EsperaToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SancionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SancionesToolStripMenuItem.Click
        Sanciones.ShowDialog()
    End Sub

    Private Sub VerParametrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerParametrosToolStripMenuItem.Click
        Parametros.ShowDialog()
    End Sub

    Private Sub VerPlazosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerPlazosToolStripMenuItem.Click
        PlazoPrestamo.ShowDialog()
    End Sub

    Private Sub VerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerToolStripMenuItem.Click
        AgregarTiempoMembresia.ShowDialog()
    End Sub

    Private Sub TiempoDeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TiempoDeToolStripMenuItem.Click

    End Sub

    Private Sub VerTiempoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VerTiempoToolStripMenuItem.Click
        TiempoMembresia.ShowDialog()
    End Sub

    Private Sub ParametrosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametrosToolStripMenuItem.Click

    End Sub

    Private Sub AgregarParametroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarParametroToolStripMenuItem.Click

    End Sub

    Private Sub PrestamosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PrestamosToolStripMenuItem1.Click
        FormularioReportePrestamo.ShowDialog()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub EliminadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminadosToolStripMenuItem.Click
        EjemplaresEliminados.ShowDialog()
    End Sub
End Class
