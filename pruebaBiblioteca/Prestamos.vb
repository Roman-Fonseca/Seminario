Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows.Input
Imports MySql.Data.MySqlClient

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
        'Me.btnFinalizarPrestamo.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPrestamosVencidos.Click
        moduloBiblioteca.mostrarPrestamosVencidos()
        Me.btnFinalizarPrestamo.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnPrestamosVencidosDevueltos.Click
        moduloBiblioteca.mostrarPrestamosVencidosDevueltos()
        Me.btnFinalizarPrestamo.Hide()
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
        'Capturo  cod_socio
        Dim cod_socio As Integer
        cod_socio = Me.dgvPrestamos.SelectedRows.Item(0).Cells(8).Value
        'Capturo  cod_prestamo_socio
        Dim cod_prestamo_socio As Integer
        cod_prestamo_socio = Me.dgvPrestamos.SelectedRows.Item(0).Cells(0).Value

        If NoEstaDevuelto(fecha_devolucion_real) Then
            moduloBiblioteca.finalizarPrestamoAtajo()
        End If

        If fecha_devolucion < fecha_actual Then
            moduloBiblioteca.aplicarSancionEspera(fecha_devolucion, fecha_actual, cod_prestamo_socio, hora_devolucion, hora_actual)
        End If

        moduloBiblioteca.mostrarPrestamosVencidos()
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

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        'Capturo fecha_devolucion
        Dim fecha_devolucion As Date
        fecha_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(4).Value
        'Capturo fecha_actual
        Dim fecha_actual As DateTime
        fecha_actual = Today
        MsgBox(calcularSancion(fecha_devolucion, fecha_actual))
    End Sub

    Private Sub Button3_Click_2(sender As Object, e As EventArgs) Handles Button3.Click
        GLO_CodSocioModificar = Me.dgvPrestamos.SelectedRows.Item(0).Cells(8).Value
        Dim Sql As String = "Select contador_prestamos From socio where cod_socio=" & GLO_CodSocioModificar
        Dim contador_prestamos As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As String = Trim(Datos("contador_prestamos"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    contador_prestamos = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    'Lanzamos la direccion web al navegador para imprimerla en pantalla
                    'WebBrowser1.Navigate(VARIABLE_QUE_CONTENDRA_EL_VALOR )

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            'Cerramos la conexion a la BBDD MySQL
            Conexion.Close()

            'Eliminamos de la memoria el objeto CONSULTA que habiamos creado
            consulta = Nothing
        End Try


    End Sub

    Private Sub gpbPrestamo_Enter(sender As Object, e As EventArgs) Handles gpbPrestamo.Enter

    End Sub
End Class