Imports System.ComponentModel
Imports System.Security.Cryptography.X509Certificates
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
        'Capturo fecha_devolucion
        Dim fecha_devolucion As Date
        fecha_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(4).Value

        'Capturo hora_devolucion
        Dim hora_devolucion As DateTime
        hora_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(5).Value.ToString

        Dim hora_actual As DateTime
        hora_actual = TimeOfDay


        If DateTime.Compare(hora_devolucion, hora_actual) > 0 Then
            MsgBox("Atrasado")
        End If


        'Capturo fecha_actual
        'Dim fecha_actual As Date
        'fecha_actual = Today
        'If fecha_devolucion >= fecha_actual Then
        'MsgBox("El prestamo no está atrasado")
        'Else
        'MsgBox("El prestamo está atrasado")
        'End If

        'MsgBox(fecha_devolucion)
    End Sub
End Class