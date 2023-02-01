Public Class Decision
    Private Sub btnEspera_Click(sender As Object, e As EventArgs) Handles btnEspera.Click
        moduloBiblioteca.aplicarSancionEspera(Prestamos.fecha_devolucion, Prestamos.fecha_actual, Prestamos.cod_prestamo_socio, Prestamos.hora_devolucion, Prestamos.hora_actual)
        moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Sin Prestar")
        Me.Close()
    End Sub

    Private Sub btnSancionPago_Click(sender As Object, e As EventArgs) Handles btnSancionPago.Click
        moduloBiblioteca.registrarPagoSancion(Prestamos.fecha_devolucion, Prestamos.fecha_actual, Prestamos.cod_prestamo_socio)
        moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Sin Prestar")
        Me.Close()
    End Sub
End Class