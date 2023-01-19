Imports System.ComponentModel
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar

Public Class Prestamos
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarPrestamo.Text = "Agregar Prestamo"
        AgregarPrestamo.btnFinalizarPrestamo.Hide()
        AgregarPrestamo.ShowDialog()
    End Sub

    Private Sub Prestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.mostrarPrestamos()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Capturo cod_prestamo
        cod_prestamo_modificar = Me.dgvPrestamos.SelectedRows.Item(0).Cells(0).Value
        'Capturo cod_socio
        cod_prestamo_socio = Me.dgvPrestamos.CurrentRow.Cells(6).Value
        AgregarPrestamo.Text = "Modificar Prestamo"

        AgregarPrestamo.BotonAgregarPrestamo.Text = "Guardar Cambios"
        ConsultarPrestamoModificar()
        AgregarPrestamo.btnFinalizarPrestamo.Show()
        AgregarPrestamo.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTodosLosPrestamos.Click
        moduloBiblioteca.mostrarPrestamos()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPrestamosVencidos.Click
        moduloBiblioteca.mostrarPrestamosVencidos()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnPrestamosVencidosDevueltos.Click
        moduloBiblioteca.mostrarPrestamosVencidosDevueltos()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFinalizarPrestamo_Click(sender As Object, e As EventArgs) Handles btnFinalizarPrestamo.Click
        'Capturo la fecha_devolucion_real
        Dim fecha_devolucion_real As Date
        fecha_devolucion_real = Me.dgvPrestamos.SelectedRows.Item(0).Cells(6).Value
        'Capturo fecha_devolucion
        Dim fecha_devolucion As Date
        fecha_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(4).Value
        'Capturo hora_devolucion
        Dim hora_devolucion As Date
        hora_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(5).Value.ToString
        'Capturo fecha_actual
        Dim fecha_actual As DateTime
        fecha_actual = Today
        'Capturo hora_actual
        Dim hora_actual As DateTime
        hora_actual = TimeOfDay

        If EstaDevuelto(fecha_devolucion_real) Then
            moduloBiblioteca.finalizarPrestamoAtajo()
            moduloBiblioteca.compararFechas(fecha_devolucion, fecha_actual, hora_devolucion, hora_actual)
        End If

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

        'Capturo fecha_devolucion
        Dim fecha_devolucion As Date
        fecha_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(4).Value
        'Capturo fecha_actual
        Dim fecha_actual As DateTime
        fecha_actual = Today

        moduloBiblioteca.diffDias(fecha_devolucion, fecha_actual)

        'Capturo hora_devolucion
        Dim hora_devolucion As DateTime
        hora_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(5).Value.ToString

        'Capturo hora_actual
        Dim hora_actual As DateTime
        hora_actual = TimeOfDay.ToString

        moduloBiblioteca.diffHoras(hora_devolucion, hora_actual)




    End Sub
End Class