Imports MySql.Data.MySqlClient

Module ModuloValidarPrestamo
    'La siguiente funcion comprueba que la membresia del socio no haya vencido
    Public Function membresiaActiva(cod_socio As Integer) As Boolean
        Dim LOC_FECHA_VENCIMIENTO As Date = ModuloValidarPrestamo.tomarFechaVencimientoMembresia(cod_socio)
        If LOC_FECHA_VENCIMIENTO > Today Then
            'MsgBox("La membresia del socio está activa", MsgBoxStyle.Information)
            Return True
        Else
            Return False
        End If
    End Function

    'La siguiente funcion toma la fecha de vencimiento de la mebresia del socio
    Public Function tomarFechaVencimientoMembresia(cod_socio As Integer) As Date
        Dim Sql As String = "SELECT fecha_vencimiento from membresia WHERE cod_socio = '" & cod_socio & "'"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim fecha_vencimiento As Date = Trim(Datos("fecha_vencimiento"))
                    Return fecha_vencimiento
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function

    'La siguiente funcion comprueba que el socio no tiene ejemplares por reponer
    Public Function TieneEjemplaresPorReponer(cod_socio) As Boolean
        Dim Sql As String = "SELECT COUNT(ejemplar_a_reponer.cod_ejemplar_a_reponer) FROM ejemplar_a_reponer 
        INNER JOIN prestamo_finalizado ON ejemplar_a_reponer.cod_prestamo_finalizado = prestamo_finalizado.cod_prestamo_finalizado 
        INNER JOIN prestamo_socio ON prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio
        WHERE prestamo_socio.cod_socio = " & cod_socio & " AND ejemplar_a_reponer.repuesto = 'No';"
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)
        'MsgBox(Sql)
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim catidad As Integer = Datos("COUNT(ejemplar_a_reponer.cod_ejemplar_a_reponer)")
                    MsgBox("El socio tiene " & catidad & " ejemplares por reponer")
                    If catidad > 0 Then
                        Return True
                    Else
                        Return false
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

    'La siguiente funcion comprueba si el socio no tiene prestamos vencidos por devolver 
    Public Function tieneAlgunPrestamoVencidoPorDevolver(cod_socio As Integer) As Boolean
        Dim Sql As String = "SELECT COUNT(cod_prestamo_socio) FROM prestamo_socio t1 WHERE NOT EXISTS (SELECT NULL FROM prestamo_finalizado t2
                             WHERE t2.cod_prestamo_socio = t1.cod_prestamo_socio) AND (CURRENT_DATE >= fecha_devolucion) 
                             AND ((CURRENT_TIME > hora_devolucion) OR (CURRENT_TIME < hora_devolucion)) 
                             AND cod_socio = " & cod_socio & ";"
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)
        'MsgBox(Sql)
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim catidad As Integer = Datos("COUNT(cod_prestamo_socio)")
                    'MsgBox("")
                    If catidad > 0 Then
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

    'La siguiente funcion verifica si el socio se encuentra en una sancion activa
    Public Function socioTieneSancionActiva(cod_socio) As Boolean
        If socioTieneRegistroDePrestamoAtrasado(cod_socio) Then
            'Dim cod_sancion_espera As Integer = ModuloValidarPrestamo.tomarUltimoCodPrestamoVencido(cod_socio)
            Dim cod_prestamo_atrasado As Integer = ModuloValidarPrestamo.tomarUltimoCodPrestamoVencido(cod_socio)
            Dim cod_sancion_espera As Integer = tomarCodSancionEspera(cod_prestamo_atrasado)
            Dim fecha_finalizacion As Date = ModuloValidarPrestamo.tomarFechaVencimientoSancionEspera(cod_sancion_espera)
            MsgBox("Fecha finalización de la ultima sanción del socio: " & fecha_finalizacion)
            If fecha_finalizacion > Today Then
                MsgBox("El socio tiene sanción espera hasta el dia: " & fecha_finalizacion, MsgBoxStyle.Exclamation)
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Function tomarUltimoCodPrestamoVencido(cod_socio As Integer) As Integer
        Dim Sql As String = "SELECT MAX(cod_prestamo_atrasado) from prestamo_atrasado INNER JOIN prestamo_finalizado 
        ON prestamo_atrasado.cod_prestamo_finalizado = prestamo_finalizado.cod_prestamo_finalizado 
        INNER JOIN prestamo_socio ON prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio 
        where prestamo_socio.cod_socio = " & cod_socio & ""
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)
        'MsgBox(Sql)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim cod_prestamo_atrasado As Integer = Datos("MAX(cod_prestamo_atrasado)")
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


    'La siguiente funcion toma la fecha de finalizacion de la sancion espera del socio
    Public Function tomarFechaVencimientoSancionEspera(cod_sancion_espera As Integer) As Date
        Dim Sql As String = "SELECT fecha_finalizacion from sancion_espera WHERE cod_sancion_espera = " & cod_sancion_espera & ""
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)
        'MsgBox(Sql)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim fecha_finalizacion As Date = Datos("fecha_finalizacion")
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

    Public Function socioTieneRegistroDePrestamoAtrasado(cod_socio As Integer) As Boolean
        Dim Sql As String = "SELECT COUNT(cod_prestamo_atrasado) from prestamo_atrasado 
        INNER JOIN prestamo_finalizado ON prestamo_atrasado.cod_prestamo_finalizado = prestamo_finalizado.cod_prestamo_finalizado 
        INNER JOIN prestamo_socio ON prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio WHERE prestamo_socio.cod_socio = " & cod_socio & ";"
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)
        'MsgBox(Sql)
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim cantidad As Integer = Datos("COUNT(cod_prestamo_atrasado)")
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

    'La siguiente funcion devuelve la cantidad de prestamo en curso del socio

    Public Function tomarCantidadPrestamosEnCurso(cod_socio As Integer) As Integer
        Dim Sql As String = "Select COUNT(cod_prestamo_socio) FROM prestamo_socio t1 
                             WHERE Not EXISTS(SELECT NULL FROM prestamo_finalizado t2 WHERE t2.cod_prestamo_socio = t1.cod_prestamo_socio)
                             AND cod_socio = " & cod_socio & ""
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)
        'MsgBox(Sql)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim cantidad As Integer = Datos("COUNT(cod_prestamo_socio)")
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

    Public Function EjemplarEstáDisponible(cod_ejemplar) As Boolean
        Dim Sql As String = "SELECT estado FROM ejemplar WHERE cod_ejemplar = " & cod_ejemplar & " "
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)
        'MsgBox(Sql)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim estado As String = Datos("estado")
                    If estado.Equals("Disponible") Then
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


End Module
