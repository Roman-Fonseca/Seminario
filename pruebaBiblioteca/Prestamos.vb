Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows.Input
Imports MySql.Data.MySqlClient

Public Class Prestamos


    Public fecha_devolucion_real As Date
    Public fecha_devolucion As Date
    Public hora_devolucion As DateTime
    Public fecha_actual As Date
    Public hora_actual As DateTime
    Public cod_prestamo_socio As Integer
    Dim dt As New DataTable
    Dim adaptador As MySqlDataAdapter

    Dim filtroEnCurso As Boolean = False

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
        cod_prestamo_socio = Me.dgvPrestamos.CurrentRow.Cells(8).Value
        AgregarPrestamo.Text = "Modificar Prestamo"

        AgregarPrestamo.BotonAgregarPrestamo.Text = "Guardar Cambios"
        ConsultarPrestamoModificar()
        AgregarPrestamo.btnFinalizarPrestamo.Show()
        AgregarPrestamo.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTodosLosPrestamos.Click
        moduloBiblioteca.mostrarPrestamos()
        Me.btnFinalizarPrestamo.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPrestamosVencidos.Click
        Me.filtroEnCurso = False
        moduloBiblioteca.mostrarPrestamosVencidos()
        Me.btnFinalizarPrestamo.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnPrestamosVencidosDevueltos.Click
        moduloBiblioteca.mostrarPrestamosVencidosDevueltos()
        Me.btnFinalizarPrestamo.Hide()
        Me.btnFinalizarPrestamo.Hide()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFinalizarPrestamo_Click(sender As Object, e As EventArgs) Handles btnFinalizarPrestamo.Click

        'Capturo fecha_devolucion
        fecha_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(4).Value
        'Capturo hora_devolucion
        hora_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(5).Value.ToString
        'Capturo fecha_actual
        fecha_actual = Today
        'Capturo hora_actual
        hora_actual = TimeOfDay
        'Capturo  cod_socio
        GLO_COD_SOCIO = Me.dgvPrestamos.SelectedRows.Item(0).Cells(7).Value
        'Capturo  cod_prestamo_socio
        cod_prestamo_socio = Me.dgvPrestamos.SelectedRows.Item(0).Cells(0).Value
        'Capturo GLO_CodEjemplarPrestamos
        GLO_CodEjemplarPrestamo = Me.dgvPrestamos.SelectedRows.Item(0).Cells(6).Value


        If MsgBox("¿El libro fue devuelto?", MsgBoxStyle.Information + vbYesNo) = vbYes Then

            If fecha_devolucion < fecha_actual Then
                MsgBox("El prestamo esta atrasado por " & diffDias(fecha_devolucion, fecha_actual) & " dia/s y " & diffHoras(hora_actual, hora_devolucion) & " horas", MsgBoxStyle.Information)
                Decision.btnEspera.Text = moduloBiblioteca.CalcularSancionEsperaDias(fecha_devolucion, fecha_actual, cod_prestamo_socio, hora_devolucion, hora_actual) & " dia/s"
                Decision.btnSancionPago.Text = "$" & moduloBiblioteca.CalcularSancionPago(fecha_devolucion, fecha_actual, cod_prestamo_socio, hora_devolucion, hora_actual) & " pesos"
                Decision.ShowDialog()
            ElseIf fecha_devolucion = fecha_actual Then
                MsgBox("El prestamo está atrasado por " & diffHoras(hora_actual, hora_devolucion) & "Horas", MsgBoxStyle.Information)
            End If
        Else

        End If


        moduloBiblioteca.mostrarPrestamos()
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

    Private Sub gpbPrestamo_Enter(sender As Object, e As EventArgs) Handles gpbPrestamo.Enter

    End Sub

    Private Sub dgvPrestamos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrestamos.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles Button1.Click
        Me.filtroEnCurso = True
        moduloBiblioteca.mostrarPrestamosEnCurso()
        Me.btnFinalizarPrestamo.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtSocioBusqueda.TextChanged
        Me.busquedaDinamicaPrestamo(txtSocioBusqueda.Text, dgvPrestamos)
    End Sub

    Public Sub busquedaDinamicaPrestamo(ByVal titulo As String, ByVal dgv As DataGridView)

        'Capturo la fecha Actual
        GLOBAL_DIA_ACTUAL = Today
        Dim dia_actual_string As String
        dia_actual_string = GLOBAL_DIA_ACTUAL.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        'Capturo la hora actual
        'Capturo la hora actual del sistema
        Dim horaActual As DateTime
        horaActual = TimeOfDay

        If Me.filtroEnCurso = False Then
            Try
                adaptador = New MySqlDataAdapter("Select * from (select prestamo_socio.cod_prestamo_socio, prestamo_socio.tipo_prestamo,prestamo_socio.fecha_prestamo,prestamo_socio.hora_prestamo,
                prestamo_socio.fecha_devolucion, prestamo_socio.hora_devolucion, prestamo_socio.cod_socio, prestamo_socio.cod_ejemplar,
                socio.nombre,socio.apellido from prestamo_socio INNER JOIN socio ON prestamo_socio.cod_socio = socio.cod_socio where ('" & dia_actual_string & "' >= fecha_devolucion AND hora_devolucion > '" & horaActual & "') 
                OR ('" & dia_actual_string & "' >= fecha_devolucion AND hora_devolucion < '" & horaActual & "')) where titulo like '" & titulo + "%" & "'", GloconexionDB)
                dt = New DataTable
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error con busqueda dinamica", ex.ToString)
            End Try
        Else
            Try
                adaptador = New MySqlDataAdapter("Select * from (select prestamo_socio.cod_prestamo_socio, prestamo_socio.tipo_prestamo,prestamo_socio.fecha_prestamo,prestamo_socio.hora_prestamo,
                prestamo_socio.fecha_devolucion, prestamo_socio.hora_devolucion, prestamo_socio.cod_socio, prestamo_socio.cod_ejemplar,
                socio.nombre,socio.apellido from prestamo_socio INNER JOIN socio ON prestamo_socio.cod_socio = socio.cod_socio where ('" & dia_actual_string & "' <= fecha_devolucion AND hora_devolucion < '" & horaActual & "') 
                OR ('" & dia_actual_string & "' <= fecha_devolucion AND hora_devolucion >= '" & horaActual & "')) where titulo like '" & titulo + "%" & "'", GloconexionDB)
                adaptador.Fill(dt)
                dgv.DataSource = dt
            Catch ex As Exception
                MessageBox.Show("Error con busqueda dinamica", ex.ToString)
            End Try
        End If


    End Sub



End Class