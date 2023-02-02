Imports MySql.Data.MySqlClient

Public Class Decision
    Private Sub btnEspera_Click(sender As Object, e As EventArgs) Handles btnEspera.Click
        verificarExistenciaPrestamoAtrasado(GLO_COD_SOCIO)
        'verificarSancionActiva(GLO_COD_SOCIO)
        moduloBiblioteca.registrarPrestamoAtrasado(Prestamos.fecha_devolucion, Prestamos.fecha_actual, Prestamos.cod_prestamo_socio, Prestamos.hora_devolucion, Prestamos.hora_actual)
        moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Sin Prestar")
        Me.Close()
    End Sub

    Private Sub btnSancionPago_Click(sender As Object, e As EventArgs) Handles btnSancionPago.Click
        moduloBiblioteca.registrarPagoSancion(Prestamos.fecha_devolucion, Prestamos.fecha_actual, Prestamos.cod_prestamo_socio)
        moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Sin Prestar")
        Me.Close()
    End Sub

    Private Sub verificarSancionActiva(cod_socio As Integer)
        Dim cod_prestamo_atrasado As Integer = tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO)
        'Dim cod_sancion_espera As Integer = tomarSancionEspera(cod_prestamo_atrasado)
        'Dim fecha_finalizacion As Date = tomarFechaFinalizacion(cod_sancion_espera)
        'Dim fecha_actual = Today

        MsgBox("Cod_prestamo_atrasado = " & cod_prestamo_atrasado)
        'MsgBox("Cod_sancion_espera = " & cod_sancion_espera)
        'MsgBox("Cod_fecha_finalizacion = " & fecha_finalizacion)
        'MsgBox("Fecha actual = " & fecha_actual)
    End Sub


    'Esta funcion toma el ultimo cod_prestamo_atrasado de un socio
    Public Function tomarUltimoPrestamoAtrasadoSocio(cod_socio As Integer) As Integer
        Dim cod_prestamo_socio = tomarUltimoPrestamoSocio(cod_socio)
        Dim Sql As String = "SELECT MAX(cod_prestamo_atrasado) from prestamo_atrasado WHERE cod_prestamo_socio= " & cod_socio & ""
        Dim cod_prestamo_atrasado As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("MAX(cod_prestamo_atrasado)"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    cod_prestamo_atrasado = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return cod_prestamo_atrasado
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


    Public Function tomarSancionEspera(cod_prestamo_atrasado) As Integer
        Dim Sql As String = "SELECT cod_sancion_espera from prestamo_atrasado WHERE cod_prestamo_atrasado=" & cod_prestamo_atrasado & ""
        Dim cod_sancion_espera As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As String = Trim(Datos("cod_prestamo_etrasado"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    cod_sancion_espera = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return cod_sancion_espera
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

    Public Function tomarFechaFinalizacion(cod_sancion_espera) As Date
        Dim Sql As String = "SELECT fecha_finalizacion from sancion_espera WHERE cod_sancion_espera=" & cod_sancion_espera & ""
        Dim fecha_finalizacion As Date
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As String = Trim(Datos("fecha_finalizacion"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    fecha_finalizacion = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return fecha_finalizacion
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

    'Esta funcion toma el ultimo cod_prestamo socio de un socio
    Public Function tomarUltimoPrestamoSocio(cod_socio As Integer) As Integer
        Dim Sql As String = "SELECT MAX(cod_prestamo_socio) from prestamo_socio where cod_socio = " & cod_socio & ""
        Dim cod_prestamo_socio As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("MAX(cod_prestamo_socio)"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    cod_prestamo_socio = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return cod_prestamo_socio
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

    Public Function verificarExistenciaPrestamoAtrasado(cod_socio As Integer) As Boolean
        If Not IsDBNull(tomarUltimoPrestamoAtrasadoSocio(cod_socio)) Then
            MsgBox("No está vacio")
            Return True
        End If
        Return False
    End Function

End Class