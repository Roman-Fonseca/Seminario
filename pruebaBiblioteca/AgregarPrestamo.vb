Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class AgregarPrestamo

    Public DIAS_PLAZO_EJEMPLAR As Integer

    Dim dt As New DataTable
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgregarPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'moduloBiblioteca.CargarComboPlazoPrestamo()
        'moduloBiblioteca.CargarComboSocioPrestamo()
        Me.dtpFechaDevolucion.Enabled = False
        moduloBiblioteca.llenarGrillaEjemplares()
        moduloBiblioteca.llenarGrillaSocios(dgvSocio)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        moduloBiblioteca.busquedaDinamicaSocio(txtBuscarSocio.Text, dgvSocio)
    End Sub

    Private Sub txtBuscarEjemplar_TextChanged(sender As Object, e As EventArgs)
        moduloBiblioteca.busquedaDinamicaEjemplar(txtBuscarEjemplar.Text, dgvEjemplar)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub btnAgregarPrestamo_Click(sender As Object, e As EventArgs)
        moduloBiblioteca.altaPrestamo()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTipoPrestamo_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbxDatosPrestramos.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvEjemplar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEjemplar.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtBuscarEjemplar.Clear()
        Me.txtBuscarSocio.Clear()
        Me.cbxTipoPrestamo.ResetText()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BotonAgregarPrestamo.Click

        GLO_CodSocioPrestamo = Me.dgvSocio.SelectedRows.Item(0).Cells(0).Value
        GLO_CodEjemplarPrestamo = Me.dgvEjemplar.SelectedRows.Item(0).Cells(0).Value

        If membresiaEnRegla(GLO_CodSocioPrestamo) Then
            If Me.cbxTipoPrestamo.Text.Equals("Local") Then
                If compararEstadoEjemplar(GLO_CodEjemplarPrestamo) Then
                    moduloBiblioteca.altaPrestamo()
                    moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Prestado")
                Else
                    MsgBox("El ejemplar seleccionado no se encuentra disponible")
                End If
            Else
                If Not moduloBiblioteca.primerPrestamoSocio(GLO_CodSocioPrestamo) Then
                    If Not tieneSancionActiva(GLO_CodSocioPrestamo) Then
                        If moduloBiblioteca.debeEjemplarAReponer(GLO_CodSocioPrestamo) Then
                            MsgBox("El socio tiene ejemplares por reponer")
                        Else
                            If tienePrestamosVencidosSinDevolver(GLO_CodSocioPrestamo) Then
                                MsgBox("El socio tiene prestamos vencidos sin devolver")
                            Else
                                If compararEstadoEjemplar(GLO_CodEjemplarPrestamo) Then
                                    If contarPrestamosActivos(GLO_CodSocioPrestamo) < 3 Then
                                        altaPrestamo()
                                        moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Prestado")
                                        moduloBiblioteca.llenarGrillaEjemplares()
                                    Else
                                        MsgBox("El socio ya tiene 3 prestamos activos")
                                    End If
                                Else
                                    MsgBox("El ejemplar no se encuentra disponible")
                                End If
                            End If
                        End If
                    Else
                        MsgBox("El socio tiene sancion activa")
                    End If
                Else
                    If compararEstadoEjemplar(GLO_CodEjemplarPrestamo) Then
                        altaPrestamo()
                        moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Prestado")
                    Else
                        MsgBox("El ejemplar no se encuentra disponible")
                    End If
                End If

            End If
        End If
        'If Decision.primerPrestamoSocio(GLO_CodSocioPrestamo) = True Then
        'MsgBox("Primer prestamo del socio")
        'Else
        'GLO_ULTIMO_PRESTAMO_SOCIO = Decision.tomarUltimoPrestamoSocio(GLO_CodSocioPrestamo)
        'MsgBox(GLO_ULTIMO_PRESTAMO_SOCIO)
        'End If

        'If Me.noDebeLibro(GLO_CodSocioPrestamo) < 0 Then
        'MsgBox("El socio no debe libros")
        'Else
        'MsgBox("El socio debe " & Me.noDebeLibro(GLO_CodSocioPrestamo) & " libros")
        'End If


        'If Me.Text = "Agregar Prestamo" And tomarCantidadPrestamosEnElDia(GLO_CodSocioPrestamo) < 3 Then
        'If moduloBiblioteca.verificarEstadoSocio(GLO_CodSocioPrestamo) And estaEnCondicion(GLO_CodSocioPrestamo) Then
        'If moduloBiblioteca.compararEstadoEjemplar(GLO_CodEjemplarPrestamo) Then
        'moduloBiblioteca.altaPrestamo()
        'moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Prestado")
        'Else
        'MsgBox("El Libro ya esta Prestado")
        'End If
        'Else
        'MsgBox("El socio está sancionado", vbCritical)
        'End If
        'Else
        'MsgBox("El socio ya registro 3 prestamos en el dia")
        'End If
        'If Me.Text = "Modificar Prestamo" Then
        'moduloBiblioteca.modificarPrestamo()
        'End If

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)
        Dim COD_Ejemplar_agregar_list As Integer
        COD_Ejemplar_agregar_list = Me.dgvEjemplar.SelectedRows.Item(0).Cells(0).Value
        'Me.listBoxEjemplares.Items.Insert(0, COD_Ejemplar_agregar_list)
    End Sub

    Private Sub btnEliminarEjemplar_Click(sender As Object, e As EventArgs)
        'Dim COD_Eliminar_Ejemplar_list As Integer
        'COD_Eliminar_Ejemplar_list = 'Me.listBoxEjemplares.SelectedItem
        'MsgBox(COD_Eliminar_Ejemplar_list)
        'Me.listBoxEjemplares.Items.Remove(Me.listBoxEjemplares.SelectedItem)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub

    'Private Sub btnFinalizarPrestamo_Click(sender As Object, e As EventArgs) Handles btnFinalizarPrestamo.Click
    'moduloBiblioteca.finalizarPrestamo()
    'End Sub

    Public Sub comprobarCantidadPrestamosPorDia()

    End Sub

    Private Sub dgvSocio_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSocio.CellContentClick

    End Sub

    Public Function estaEnCondicion(cod_socio As Integer) As Boolean
        Dim fecha_finalizacion As Date = Decision.tomarFechaFinalizacion(cod_socio)
        MsgBox("la fecha finalizacion del ultimo sancion_espera del socio es: " & fecha_finalizacion)
        If fecha_finalizacion < Today Then
            MsgBox("El socio esta en condición")
            Return True
        Else
            MsgBox("El socio tiene una sancion en curso hasta el dia: " & fecha_finalizacion)
            Return False
        End If
    End Function

    Public Function noDebeLibro(cod_socio) As Integer
        'Capturo fecha actual para la consulta
        Dim fecha_actual As Date
        fecha_actual = Today
        'Covierto fecha_actual en string
        Dim fecha_actual_STR As String
        fecha_actual_STR = fecha_actual.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        Dim Sql As String = "SELECT COUNT(cod_prestamo_socio) FROM prestamo_socio where cod_socio = " & cod_socio & " and fecha_devolucion_real = 0000-00-00 AND fecha_devolucion < " & fecha_actual_STR & ""
        Dim libros_sin_devolver As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("COUNT(cod_prestamo_socio)"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    libros_sin_devolver = VARIABLE_QUE_CONTENDRA_EL_VALOR


                    Return libros_sin_devolver
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

    Private Sub GroupBox1_Enter_1(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    'Private Sub btnFinalizarPrestamo_Click(sender As Object, e As EventArgs) Handles btnFinalizarPrestamo.Click
    '
    'End Sub

    Public Function membresiaEnRegla(cod_socio) As Boolean
        If tomarFechaVencimientoMembresia(cod_socio) >= Today Then
            MsgBox("Membresia en curso")
            MsgBox("La membresia vence el: " & tomarFechaVencimientoMembresia(cod_socio))
            Return True
        Else
            MsgBox("Membrecia vencida")
            MsgBox("La membresia venció el: " & tomarFechaVencimientoMembresia(cod_socio))
            Return False
        End If

    End Function

    Public Function tomarFechaVencimientoMembresia(cod_socio) As Date
        Dim Sql As String = "SELECT fecha_vencimiento FROM membresia WHERE cod_socio = '" & cod_socio & "'"
        Dim fecha_vencimiento As Date
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Date = Trim(Datos("fecha_vencimiento"))
                    fecha_vencimiento = VARIABLE_QUE_CONTENDRA_EL_VALOR
                    Return fecha_vencimiento
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

    Public Function debeEjemplarAReponer(cod_socio) As Boolean

    End Function

    Public Function tienePrestamosVencidosSinDevolver(cod_socio) As Boolean
        Dim Sql As String = "SELECT COUNT(cod_prestamo_socio) FROM prestamo_socio WHERE cod_prestamo_socio 
        NOT IN (SELECT prestamo_finalizado.cod_prestamo_socio FROM prestamo_finalizado) AND prestamo_socio.fecha_devolucion < CURRENT_DATE 
        AND prestamo_socio.cod_socio = '" & cod_socio & "'"
        Dim cantidad As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("COUNT(cod_prestamo_socio)"))
                    cantidad = VARIABLE_QUE_CONTENDRA_EL_VALOR
                    If cantidad > 0 Then
                        Return True
                    Else
                        Return False
                    End If
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

    Public Function tomarCodSancionEspera(cod_socio As Integer) As Integer
        Dim Sql As String = "SELECT MAX(sancion_espera.cod_sancion_espera) FROM sancion_espera INNER JOIN prestamo_atrasado ON
                            sancion_espera.cod_sancion_espera = prestamo_atrasado.cod_sancion_espera INNER JOIN prestamo_finalizado 
                            ON prestamo_atrasado.cod_prestamo_finalizado = prestamo_finalizado.cod_prestamo_finalizado INNER JOIN prestamo_socio 
                            On prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio 
                            INNER JOIN socio ON prestamo_socio.cod_socio = " & cod_socio & " LIMIT 1"
        Dim cod_sancion_e As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("MAX(sancion_espera.cod_sancion_espera)"))
                    cod_sancion_e = VARIABLE_QUE_CONTENDRA_EL_VALOR
                    MsgBox("Ultima sancion espera del socio: " & cod_sancion_e)
                    Return cod_sancion_e
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

    Public Function NoexisteSancionEspera(cod_socio As Integer) As Boolean
        Dim Sql As String = "SELECT MAX(sancion_espera.cod_sancion_espera) FROM sancion_espera INNER JOIN prestamo_atrasado ON
                            sancion_espera.cod_sancion_espera = prestamo_atrasado.cod_sancion_espera INNER JOIN prestamo_finalizado 
                            ON prestamo_atrasado.cod_prestamo_finalizado = prestamo_finalizado.cod_prestamo_finalizado INNER JOIN prestamo_socio 
                            On prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio 
                            INNER JOIN socio ON prestamo_socio.cod_socio = " & cod_socio & " LIMIT 1"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim Noexiste As Boolean = IsDBNull((Datos("MAX(sancion_espera.cod_sancion_espera)")))
                    If Noexiste = True Then
                        Return True
                    Else
                        Return False
                    End If
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


    Public Function tomar_fecha_finalizacion(cod_socio As Integer) As Date
        Dim cod_sancion_e As Integer = tomarCodSancionEspera(cod_socio)
        Dim Sql As String = "SELECT fecha_finalizacion FROM sancion_espera WHERE cod_sancion_espera = " & cod_sancion_e & ""
        Dim f_finalizacion As Date
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Date = Trim(Datos("fecha_finalizacion"))
                    f_finalizacion = VARIABLE_QUE_CONTENDRA_EL_VALOR
                    Return f_finalizacion
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

    Public Function tieneSancionActiva(cod_socio As Integer) As Boolean
        If Me.NoexisteSancionEspera(cod_socio) = True Then
            MsgBox("El socio no tiene sanción activa")
        Else
            Dim fecha_finalizacion As Date = tomar_fecha_finalizacion(cod_socio)
            MsgBox("La fecha de finalizacion es: " & fecha_finalizacion)

            Try
                If fecha_finalizacion > Today Then
                    MsgBox("Tiene sancion activa")
                    Return True
                Else
                    MsgBox("No tiene sancion activa")
                    Return False
                End If
            Catch ex As Exception

            End Try
        End If

    End Function

    Public Function contarPrestamosActivos(cod_socio As Integer) As Integer
        'Capturo la cantidad de prestamos activos
        Dim Sql As String = "SELECT COUNT(cod_prestamo_socio) FROM prestamo_socio t1 
                             WHERE NOT EXISTS (SELECT NULL FROM prestamo_finalizado t2 WHERE t2.cod_prestamo_socio = t1.cod_prestamo_socio)
                             AND cod_socio = " & cod_socio & ""
        Dim cantidad As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("COUNT(cod_prestamo_socio)"))
                    cantidad = VARIABLE_QUE_CONTENDRA_EL_VALOR
                    Return cantidad
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

    Private Sub cbxTipoPrestamo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoPrestamo.SelectedIndexChanged

    End Sub

    Private Sub cbxTipoPrestamo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxTipoPrestamo.SelectedValueChanged
        'Desabilito el dtpFechaDevolucion
        If Me.cbxTipoPrestamo.Text = "Local" Then
            Me.dtpFechaDevolucion.Enabled = False
        End If

        'habilito el dtpFechaDevolución
        If Me.cbxTipoPrestamo.Text = "Externo" Then
            Me.dtpFechaDevolucion.Enabled = True
        End If
    End Sub

    Private Sub txtBuscarEjemplar_TextChanged_1(sender As Object, e As EventArgs) Handles txtBuscarEjemplar.TextChanged

    End Sub

    Public Sub busquedaDinamicaSocio(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("SELECT * FROM socio WHERE nombre like '" & nombre + "%" & "'", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            Me.dgvSocio.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error con busqueda dinamica", ex.ToString)
        End Try
    End Sub

    Private Sub txtBuscarSocio_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarSocio.TextChanged
        busquedaDinamicaSocio(txtBuscarSocio.Text, dgvSocio)
    End Sub

    Private Sub cbxTipoPrestamo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cbxTipoPrestamo.KeyPress

    End Sub

    Private Sub dgvEjemplar_LostFocus(sender As Object, e As EventArgs) Handles dgvEjemplar.LostFocus

    End Sub

    Public Function tomarDiasPlazo(cod_ejemplar As Integer) As Integer

    End Function

    Private Sub dtpFechaDevolucion_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaDevolucion.ValueChanged

    End Sub

    Private Sub dtpFechaDevolucion_Click(sender As Object, e As EventArgs) Handles dtpFechaDevolucion.Click

    End Sub

    Private Sub dgvEjemplar_MouseClick(sender As Object, e As MouseEventArgs) Handles dgvEjemplar.MouseClick
        'Tomo la cantidad de dias que se puede prestar el libro
        Me.DIAS_PLAZO_EJEMPLAR = Me.dgvEjemplar.SelectedRows.Item(0).Cells(6).Value
        'MsgBox(DIAS_PLAZO_EJEMPLAR)
        dtpFechaDevolucion.MaxDate = DateTime.Now.Date.AddDays(DIAS_PLAZO_EJEMPLAR)
        If Me.cbxTipoPrestamo.Text = "Externo" Then
            dtpFechaDevolucion.Enabled = True
        End If


    End Sub
End Class