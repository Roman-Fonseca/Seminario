Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar
Imports System.Windows.Input
Imports MySql.Data.MySqlClient

Public Class Prestamos


    Public fecha_devolucion_real As Date
    Public FECHA_DEVOLUCION_PRESTAMO As Date
    Public hora_devolucion As DateTime
    Public fecha_actual As Date
    Public hora_actual As DateTime
    Public cod_prestamo_socio As Integer
    Dim dt As New DataTable
    Dim adaptador As MySqlDataAdapter

    Dim filtroEnCurso As Boolean = False
    Dim se_esta_filtrando_prestamos_en_curso As Boolean
    Dim entero As Integer


    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        AgregarPrestamo.Text = "Agregar Prestamo"
        AgregarPrestamo.btnFinalizarPrestamo.Hide()
        AgregarPrestamo.ShowDialog()
    End Sub

    Private Sub Prestamos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.mostrarPrestamos()
        Me.btnTodosLosPrestamos.BackColor = Color.Green
        Me.btnPrestamosVencidos.BackColor = Color.White
        Me.btnEnCurso.BackColor = Color.White
        Me.btnPrestamosVencidosDevueltos.BackColor = Color.White
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        'Capturo cod_prestamo
        cod_prestamo_modificar = Me.dgvPrestamos.SelectedRows.Item(0).Cells(0).Value
        'Capturo cod_socio
        cod_prestamo_socio = Me.dgvPrestamos.CurrentRow.Cells(9).Value
        AgregarPrestamo.Text = "Modificar Prestamo"

        AgregarPrestamo.BotonAgregarPrestamo.Text = "Guardar Cambios"
        ConsultarPrestamoModificar()
        AgregarPrestamo.btnFinalizarPrestamo.Show()
        AgregarPrestamo.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTodosLosPrestamos.Click
        moduloBiblioteca.mostrarPrestamos()
        Me.btnFinalizarPrestamo.Hide()
        Me.btnTodosLosPrestamos.BackColor = Color.Green
        Me.btnPrestamosVencidos.BackColor = Color.White
        Me.btnEnCurso.BackColor = Color.White
        Me.btnPrestamosVencidosDevueltos.BackColor = Color.White
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnPrestamosVencidos.Click
        Me.se_esta_filtrando_prestamos_en_curso = False
        moduloBiblioteca.mostrarPrestamosVencidos()
        Me.btnTodosLosPrestamos.BackColor = Color.White
        Me.btnPrestamosVencidos.BackColor = Color.Green
        Me.btnEnCurso.BackColor = Color.White
        Me.btnPrestamosVencidosDevueltos.BackColor = Color.White
        Me.btnFinalizarPrestamo.Show()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnPrestamosVencidosDevueltos.Click
        moduloBiblioteca.mostrarPrestamosVencidosDevueltos()
        Me.btnTodosLosPrestamos.BackColor = Color.White
        Me.btnPrestamosVencidos.BackColor = Color.White
        Me.btnEnCurso.BackColor = Color.White
        Me.btnPrestamosVencidosDevueltos.BackColor = Color.Green
        Me.btnFinalizarPrestamo.Hide()
        Me.btnFinalizarPrestamo.Hide()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnFinalizarPrestamo_Click(sender As Object, e As EventArgs) Handles btnFinalizarPrestamo.Click


        'Tomo los valores para finalizar un prestamo_en curso
        'Capturo fecha_devolucion
        FECHA_DEVOLUCION_PRESTAMO = Me.dgvPrestamos.SelectedRows.Item(0).Cells(3).Value
        'Capturo hora_devolucion
        hora_devolucion = Me.dgvPrestamos.SelectedRows.Item(0).Cells(4).Value.ToString
        'Capturo fecha_actual
        fecha_actual = Today
        'Capturo hora_actual
        hora_actual = TimeOfDay
        'Capturo  cod_socio
        GLO_COD_SOCIO = Me.dgvPrestamos.SelectedRows.Item(0).Cells(7).Value
        'Capturo  cod_prestamo_socio
        cod_prestamo_socio = Me.dgvPrestamos.SelectedRows.Item(0).Cells(0).Value
        'Capturo GLO_CodEjemplarPrestamos
        GLO_CodEjemplarPrestamo = Me.dgvPrestamos.SelectedRows.Item(0).Cells(5).Value


        'Registro prestamo finalizado
        'En caso de ser necesario registro ejemplar a reponer
        ModuloFinalizarPrestamo.altaPrestamoFinalizado(cod_prestamo_socio, fecha_actual, hora_actual)
        If MsgBox("¿El libro fue devuelto?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
            If MsgBox("¿En buen estado?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
                MsgBox("El préstamo fue devuelto en buen estado")
            Else
                If MsgBox("¿Desea registrar ejemplar a reponer?", MsgBoxStyle.Information + vbYesNo) = vbYes Then
                    ModuloFinalizarPrestamo.registrarEjemplarAReponer()
                End If
            End If
        Else
            ModuloFinalizarPrestamo.registrarEjemplarAReponer()
        End If



        If Today > FECHA_DEVOLUCION_PRESTAMO Then
            'Aplicar Sancion
            MsgBox("El prestamo se devolvió " & diffDias(Today, FECHA_DEVOLUCION_PRESTAMO) & " dia/s y " & diffHoras(hora_actual, hora_devolucion) & " tarde")
            Decision.btnEspera.Text = moduloBiblioteca.CalcularSancionEsperaDias(FECHA_DEVOLUCION_PRESTAMO, fecha_actual, cod_prestamo_socio, hora_devolucion, hora_actual) & " dia/s"
            Decision.btnSancionPago.Text = "$" & moduloBiblioteca.CalcularSancionPago(FECHA_DEVOLUCION_PRESTAMO, fecha_actual, cod_prestamo_socio, hora_devolucion, hora_actual) & " pesos"
            Decision.ShowDialog()
        ElseIf Today = FECHA_DEVOLUCION_PRESTAMO And hora_actual > hora_devolucion Then
            'Mostrar un mensaje con las diferencias de horas
            MsgBox("Prestamo atrasado por: " & diffHoras(hora_actual, hora_devolucion))
            MsgBox("No corresponde ningun tipo de sanción")
        Else
            'Mostrar mensaje "Fue entregado a tiempo"
            MsgBox("El prestamo fue entregado a tiempo")
        End If


        'If fecha_devolucion <= fecha_actual And hora_devolucion > hora_actual Then
        'MsgBox("El prestamo esta atrasado por " & diffDias(fecha_devolucion, fecha_actual) & " dia/s y " & diffHoras(hora_actual, hora_devolucion) & " horas", MsgBoxStyle.Information)
        'Decision.btnEspera.Text = moduloBiblioteca.CalcularSancionEsperaDias(fecha_devolucion, fecha_actual, cod_prestamo_socio, hora_devolucion, hora_actual) & " dia/s"
        'Decision.btnSancionPago.Text = "$" & moduloBiblioteca.CalcularSancionPago(fecha_devolucion, fecha_actual, cod_prestamo_socio, hora_devolucion, hora_actual) & " pesos"
        'Decision.ShowDialog()
        'ElseIf fecha_devolucion = fecha_actual Then
        'MsgBox("El prestamo está atrasado por " & diffHoras(hora_actual, hora_devolucion) & "Horas", MsgBoxStyle.Information)
        'End If
        cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Disponible")

        If se_esta_filtrando_prestamos_en_curso = True Then
            moduloBiblioteca.mostrarPrestamosEnCurso()
        Else
            moduloBiblioteca.mostrarPrestamosVencidos()
        End If

        'If entero = 1 Then
        '    moduloBiblioteca.mostrarPrestamosEnCurso()
        'Else
        '    moduloBiblioteca.mostrarPrestamosVencidos()
        'End If

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
        'MsgBox(calcularSancion(fecha_devolucion, fecha_actual))
    End Sub

    Private Sub gpbPrestamo_Enter(sender As Object, e As EventArgs) Handles gpbPrestamo.Enter

    End Sub

    Private Sub dgvPrestamos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPrestamos.CellContentClick

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles btnEnCurso.Click
        'Me.filtroEnCurso = True
        'entero = 1
        Me.se_esta_filtrando_prestamos_en_curso = True
        moduloBiblioteca.mostrarPrestamosEnCurso()
        Me.btnFinalizarPrestamo.Show()
        Me.btnTodosLosPrestamos.BackColor = Color.White
        Me.btnPrestamosVencidos.BackColor = Color.White
        Me.btnEnCurso.BackColor = Color.Green
        Me.btnPrestamosVencidosDevueltos.BackColor = Color.White
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
                adaptador = New MySqlDataAdapter("SELECT prestamo_socio.cod_prestamo_socio, prestamo_socio.tipo_prestamo,prestamo_socio.fecha_prestamo,prestamo_socio.hora_prestamo,
        prestamo_socio.fecha_devolucion, prestamo_socio.hora_devolucion, prestamo_socio.cod_socio, prestamo_socio.cod_ejemplar,
        socio.nombre,socio.apellido FROM prestamo_socio INNER JOIN socio ON prestamo_socio.cod_socio = socio.cod_socio 
        where ('" & dia_actual_string & "' <= fecha_devolucion AND hora_devolucion < '" & horaActual & "')
        OR ('" & dia_actual_string & "' <= fecha_devolucion AND hora_devolucion >= '" & horaActual & "' WHERE nombre like '" & titulo + "%" & "'", GloconexionDB)
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

    Public Sub altaPrestamoFinalizado(cod_prestamo_socio As Integer, fecha_devolucion_real As Date, hora_devolucion_real As DateTime)
        Dim LOC_consulta As String
        Dim fecha_finalizacion_real As String = fecha_devolucion_real.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into prestamo_finalizado (fecha_finalizacion_real,hora_finalizacion_real,cod_prestamo_socio) 
                values('" & fecha_finalizacion_real & "','" & hora_devolucion_real & "','" & cod_prestamo_socio & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccionAlta(LOC_consulta)
                MsgBox("Se finalizó prestamo correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub



    Public Function tomarUltimoPrestamoFinalizado() As Integer
        Dim Sql As String = "SELECT MAX(cod_prestamo_finalizado) FROM prestamo_finalizado"
        Dim cod_prestamo_finalizado As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("MAX(cod_prestamo_finalizado)"))
                    cod_prestamo_finalizado = VARIABLE_QUE_CONTENDRA_EL_VALOR
                    Return cod_prestamo_finalizado
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            'Cerramos la conexion a la BBDD MySQL
            Conexion.Close()
            'Eliminamos de la memoria el objeto CONSULTA que habiamos creado
            consulta = Nothing
        End Try
    End Function

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cod_prestamo As Integer = (Me.dgvPrestamos.SelectedRows.Item(0).Cells(0).Value)
        EliminarPrestamo(cod_prestamo)
    End Sub

    Public Sub EliminarPrestamo(cod_prestamo As Integer)
        Dim loc_consulta As String
        Dim a As Integer
        Try
            a = MsgBox("¿ Está seguro de eliminar el prestamo cod_prestamo: " & cod_prestamo & " ?", MsgBoxStyle.YesNo, "Biblioteca LA")
            If a = MsgBoxResult.Yes Then
                loc_consulta = "delete from prestamo_socio where cod_prestamo_socio= " & cod_prestamo
                If ConexionMySQL() Then
                    EjecutarTransaccionBaja(loc_consulta)

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

End Class