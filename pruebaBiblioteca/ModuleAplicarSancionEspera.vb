Imports MySql.Data.MySqlClient

Module ModuleAplicarSancionEspera

    'Verifica que por lo menos el socio tenga un prestamo cargado
    Public Function tienePrestamoAnterior(cod_socio) As Boolean
        Dim Sql As String = "Select MAX(cod_prestamo_socio) FROM prestamo_socio where cod_socio = " & cod_socio & ""
        Dim cod_prestamo_socio As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim tienePrestamo As Boolean = Not IsDBNull(Datos("MAX(cod_prestamo_socio)"))
                    If tienePrestamo = True Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function

    'Comprueba que el socio tenga por lo menos un prestamo atrasado registrado
    Public Function tienePrestamoAtrasadoRegistrado(cod_socio As Integer) As Integer
        Dim Sql As String = "SELECT MAX(prestamo_atrasado.cod_prestamo_atrasado) from prestamo_atrasado 
        INNER JOIN(SELECT prestamo_finalizado.cod_prestamo_finalizado from prestamo_finalizado 
        INNER JOIN prestamo_socio ON prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio where prestamo_socio.cod_socio = " & cod_socio & ") 
        AS AX ON prestamo_atrasado.cod_prestamo_finalizado = AX.cod_prestamo_finalizado;"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim tienePrestamoAtrasado As Boolean = Not IsDBNull(Datos("MAX(prestamo_atrasado.cod_prestamo_atrasado)"))
                    If tienePrestamoAtrasado = True Then
                        MsgBox("El socio tiene un prestamo atrasado registrado")
                        Return True
                    Else
                        MsgBox("El socio NO tiene un prestamo atrasado registrado")
                        Return False
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function

    'Toma el ultimo cod_prestamo_atrasado de un socio
    Public Function ultimoPrestamoAtrasado(cod_socio As Integer) As Integer
        Dim Sql As String = "SELECT prestamo_atrasado.cod_prestamo_atrasado from prestamo_atrasado 
        INNER JOIN (SELECT prestamo_finalizado.cod_prestamo_finalizado from prestamo_finalizado 
        INNER JOIN prestamo_socio ON prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio where prestamo_socio.cod_socio = " & cod_socio & ")
        AS AX ON prestamo_atrasado.cod_prestamo_finalizado = AX.cod_prestamo_finalizado ORDER BY prestamo_atrasado.cod_prestamo_atrasado DESC LIMIT 1"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim cod_prestamo_atrasado As Integer = Trim(Datos("cod_prestamo_atrasado"))
                    Return cod_prestamo_atrasado
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function

    Public Function tomarCodSancionEspera(cod_prestamo_atrasado As Integer) As Integer
        Dim Sql As String = "SELECT cod_sancion_espera FROM prestamo_atrasado WHERE cod_prestamo_atrasado = '" & cod_prestamo_atrasado & "'"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim cod_sancion_espera As Integer = Trim(Datos("cod_sancion_espera"))
                    Return cod_sancion_espera
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function

    Public Function tomarFechaFinalizacion(cod_sancion_espera As Integer) As Date
        Dim Sql As String = "SELECT fecha_finalizacion FROM sancion_espera WHERE cod_sancion_espera = '" & cod_sancion_espera & "'"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim fecha_finalizacion As Date = Trim(Datos("fecha_finalizacion"))
                    Return fecha_finalizacion
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function

    'El siguiente metodo carga la sancion espera al socio
    Public Sub cargarSancionEspera(fecha_inicioSTR As String)
        Dim consulta As String
        Dim dias_sancion As Integer = ModuleAplicarSancionEspera.CalcularSancionEsperaDias(Prestamos.FECHA_DEVOLUCION_PRESTAMO, Prestamos.fecha_actual)
        Dim fecha_finalizacion As Date = DateAdd("d", dias_sancion, fecha_inicioSTR)
        Dim fecha_finalizacionSTR As String = fecha_finalizacion.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        MsgBox("Fecha Inicio: " & fecha_inicioSTR)
        MsgBox("fecha finalizacion: " & fecha_finalizacionSTR)

        Try
            If ConexionMySQL() Then
                consulta = "insert into sancion_espera (fecha_inicio,fecha_finalizacion) values('" & fecha_inicioSTR & "','" & fecha_finalizacionSTR & "')"
                MsgBox(consulta)
                EjecutarTransaccionAlta(consulta)
                MsgBox("Se agregó sancion_espera correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'La siguiente funcion devuleve la cantidad de dias que le correponde de sancion a un socio
    Public Function CalcularSancionEsperaDias(fecha_devolucion As Date, fecha_actual As Date) As Integer
        Dim dias_sancion As Integer
        dias_sancion = ModuleAplicarSancionEspera.calcularSancion(fecha_devolucion, fecha_actual)
        Return dias_sancion
    End Function

    'Calcula los dias de sancion
    Public Function calcularSancion(fecha_devolucion As Date, fecha_actual As Date) As Integer
        Dim dias As Integer
        Dim dias_sancion As Integer
        Dim minimo As Integer
        Dim bandera As Integer
        Dim maximo As Integer
        dias = diffDias(fecha_devolucion, fecha_actual)
        Dim consulta As String = "select cod_parametro_espera,minimo,maximo,dias_sancion from parametro_espera"
        If GloconexionDB.State = ConnectionState.Closed Then
            GloconexionDB.ConnectionString = cadena_conexion
            GloconexionDB.Open()
        End If

        Dim command As New MySqlCommand(consulta, GloconexionDB)
        Dim reader As MySqlDataReader = command.ExecuteReader()

        bandera = 0

        While reader.Read()
            If (bandera = 0) Then
                minimo = Convert.ToInt32(reader("minimo"))
                maximo = Convert.ToInt32(reader("maximo"))
                dias_sancion = Convert.ToInt32(reader("dias_sancion"))
                If dias >= minimo Then
                    If dias <= maximo Then
                        MsgBox("Corresponde sancion de " & dias_sancion & " dias")
                        bandera += 1
                    End If
                End If
            End If
        End While

        If bandera = 0 Then
            MsgBox("Sancion espera - Fuera de rango")
        End If

        reader.Close()
        Return dias_sancion
    End Function

    'Registrar nuevo prestamo atrasado
    Public Sub registrarPrestamoAtrasado(fecha_devolucion As Date, fecha_actual As Date, cod_prestamo_finalizado As Integer, cod_sancion_espera As Integer)

        Dim LOC_consulta As String
        'Prueba motivo
        Dim motivo As String
        motivo = "Prestamo atrasado"
        'Calculo los dias de sancion
        Dim dias_sancion As Integer
        dias_sancion = moduloBiblioteca.calcularSancion(fecha_devolucion, fecha_actual)

        Try
            If ConexionMySQL() Then
                LOC_consulta = "insert into prestamo_atrasado (dias_sancion,motivo,cod_prestamo_finalizado,cod_sancion_espera) values('" & dias_sancion & "','" & motivo & "','" & cod_prestamo_finalizado & "', '" & cod_sancion_espera & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccionAlta(LOC_consulta)
                MsgBox("Se agregó prestamo_atrasado correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'moduloBiblioteca.calcularSancion(fecha_devolucion, fecha_actual)
    End Sub

    Public Sub modificarSancionEspera(cod_sancion_espera As Integer, fecha_finalizacion As Date)

        Dim consulta_local As String
        Dim agregar_dias As Integer

        agregar_dias = ModuleAplicarSancionEspera.CalcularSancionEsperaDias(Prestamos.FECHA_DEVOLUCION_PRESTAMO, Prestamos.fecha_actual)
        MsgBox("Se agregarán : " & agregar_dias & " dias a la sanción en curso", MsgBoxStyle.Information)
        fecha_finalizacion = DateAdd("d", agregar_dias, fecha_finalizacion)
        MsgBox("La nueva fecha_finalización es: " & fecha_finalizacion)

        'convierto fecha_finalizacion en string para el update
        Dim fecha_finalizacionSTR As String
        fecha_finalizacionSTR = fecha_finalizacion.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        MsgBox(fecha_finalizacionSTR)


        Try

            If ConexionMySQL() Then
                consulta_local = "UPDATE sancion_espera SET fecha_finalizacion = '" & fecha_finalizacionSTR & "' WHERE cod_sancion_espera = " & cod_sancion_espera & ""
                MsgBox(consulta_local)
                ModuleAplicarSancionEspera.EjecutarTransaccionModificacionSancionEspera(consulta_local)
                MsgBox("Se agregó correctamente")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub EjecutarTransaccionModificacionSancionEspera(MySQL As String)
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = MySQL
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glocomando.ExecuteNonQuery()
                GloconexionDB.Close()
                MsgBox("Se modificó Sanción Espera correctamente")
            End If

        Catch ex As Exception
            MsgBox("No se pudo modificar registro", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            GloconexionDB.Close()
        End Try

    End Sub

    Public Function tomarFechaInicio(cod_sancion_espera As Integer) As Date
        Dim Sql As String = "SELECT fecha_inicio FROM sancion_espera WHERE cod_sancion_espera = '" & cod_sancion_espera & "'"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim fecha_finalizacion As Date = Trim(Datos("fecha_inicio"))
                    Return fecha_finalizacion
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function

    Public Sub modificarSancionEsperaCasoEspecial(cod_sancion_espera As Integer, fecha_inicio As Date)

        Dim consulta_local As String
        Dim fecha_finalizacion As Date

        fecha_finalizacion = DateAdd("d", 30, fecha_inicio)
        MsgBox("La nueva fecha_finalización es: " & fecha_finalizacion)

        'convierto fecha_finalizacion en string para el update
        Dim fecha_finalizacionSTR As String
        fecha_finalizacionSTR = fecha_finalizacion.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        MsgBox(fecha_finalizacionSTR)


        Try

            If ConexionMySQL() Then
                consulta_local = "UPDATE sancion_espera SET fecha_finalizacion = '" & fecha_finalizacionSTR & "' WHERE cod_sancion_espera = " & cod_sancion_espera & ""
                MsgBox(consulta_local)
                ModuleAplicarSancionEspera.EjecutarTransaccionModificacionSancionEspera(consulta_local)
                MsgBox("Se modifico sancion_espera correctamente")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub


End Module
