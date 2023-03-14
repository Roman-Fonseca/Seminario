Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Public Class Decision
    Private Sub btnEspera_Click(sender As Object, e As EventArgs) Handles btnEspera.Click

        Dim fecha_inicio As String = Today.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        If tienePrestamoAnterior(GLO_COD_SOCIO) Then
            If tienePrestamoAtrasadoRegistrado(GLO_COD_SOCIO) Then
                Dim cod_prestamo_atrasado As Integer = ultimoPrestamoAtrasado(GLO_COD_SOCIO)
                Dim cod_sancion_espera As Integer = tomarCodSancionEspera(cod_prestamo_atrasado)
                Dim fecha_finalizacion As Date = tomarFechaFinalizacion(cod_sancion_espera)

                MsgBox("KKKKK" & fecha_finalizacion)
                MsgBox("KKKKK" & Today)

                If fecha_finalizacion > Today Then
                    'Agregar dias a sancion_espera
                Else
                    'Registrar nueva sancion_espera
                    cargarSancionEspera(fecha_inicio)
                    'Registrar nuevo prestamo atrasado con ultimo con_sancion_espera
                    registrarPrestamoAtrasado(Prestamos.fecha_devolucion, Prestamos.fecha_actual, tomarUltimoPrestamoFinalizado(), tomarUltimoCodSancionEspera())
                End If
            End If
        Else
            'Cargar sanción espera y prestamo atrasado
            cargarSancionEspera(Prestamos.fecha_actual) 'Carga un nuevo sancion_espera para ser asignado a el nuevo registro prestamo_atrasado
            registrarPrestamoAtrasado(Prestamos.fecha_devolucion, Prestamos.fecha_actual, tomarUltimoPrestamoFinalizado(), tomarUltimoCodSancionEspera())
        End If

        'Dim resultado As Boolean = NOexistePrestamoAtrasado(GLO_COD_SOCIO)
        'Dim local_fecha_finalizacion As Date
        'MsgBox(resultado)
        'If resultado.Equals(True) Then
        'cargarSancionEspera(Prestamos.fecha_actual) 'Carga un nuevo sancion_espera para ser asignado a el nuevo registro prestamo_atrasado
        'registrarPrestamoAtrasado(Prestamos.fecha_devolucion, Prestamos.fecha_actual, Prestamos.cod_prestamo_socio, tomarUltimoCodSancionEspera)
        'Else
        'MsgBox("Hola")
        'MsgBox("Penultimo prestamo: " & penultimoPrestamoSocio(GLO_COD_SOCIO))
        'local_fecha_finalizacion = tomarFechaFinalizacion(GLO_COD_SOCIO)
        'MsgBox(local_fecha_finalizacion)
        'If local_fecha_finalizacion > Today Then
        'MsgBox("Fecha finalizacion es mayor por ende se expande sancion")
        'modificarSancionEspera(tomarCodSancionEspera(GLO_COD_SOCIO), GLO_COD_SOCIO)
        'registrarPrestamoAtrasado(Prestamos.fecha_devolucion, Prestamos.fecha_actual, tomarUltimoPrestamoSocio(GLO_COD_SOCIO), tomarCodSancionEspera(GLO_COD_SOCIO))
        'End If
        '
        'End If


        'MsgBox("Ultimo Prestamo atrasado socio: " & tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO)) 'Devuelve el
        ''ultimo prestamo atrasado de un socio, el proble es si el prestamo atrasado a registrar es el primero de un socio ya que seria null
        'MsgBox("Cod sancion espera: " & tomarCodSancionEspera(tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO)))
        'MsgBox("Fecha_finalizacion : " & tomarFechaFinalizacion(GLO_COD_SOCIO))



        'Este fragmento de codigo da de alta un prestamo atrasado y modifica una sancion espera
        'El problema es que debe encontrar si o si un prestamo atrasado de un socio

        'If tomarFechaFinalizacion(GLO_COD_SOCIO) > Today Then
        '    MsgBox("Fecha actual es menor")
        '    modificarSancionEspera(tomarCodSancionEspera(GLO_COD_SOCIO), GLO_COD_SOCIO)
        '    moduloBiblioteca.registrarPrestamoAtrasado(Prestamos.fecha_devolucion, Prestamos.fecha_actual, tomarUltimoPrestamoSocio(GLO_COD_SOCIO), tomarCodSancionEspera(GLO_COD_SOCIO))
        'Else
        '    MsgBox("Fecha Actual es mayor")
        'End If


        'moduloBiblioteca.registrarPrestamoAtrasado(Prestamos.fecha_devolucion, Prestamos.fecha_actual, Prestamos.cod_prestamo_socio)
        'MsgBox("Ultimo prestamo socio: " & tomarUltimoPrestamoSocio(GLO_COD_SOCIO)) 'Funciona
        'MsgBox("Ultimo prestamo atrasado: " & tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO))
        'tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO)
        'moduloBiblioteca.registrarPrestamoAtrasado(Prestamos.fecha_devolucion, Prestamos.fecha_actual, Prestamos.cod_prestamo_socio, Prestamos.hora_devolucion, Prestamos.hora_actual)
        'moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Sin Prestar")
        'verificarExistenciaPrestamoAtrasado(GLO_COD_SOCIO)
        'verificarSancionActiva(GLO_COD_SOCIO)
        Me.Close()
    End Sub

    Private Sub btnSancionPago_Click(sender As Object, e As EventArgs) Handles btnSancionPago.Click
        Dim ultimo_prestamo_finalizado As Integer = tomarUltimoPrestamoFinalizado()
        moduloBiblioteca.registrarPagoSancion(Prestamos.fecha_devolucion, Prestamos.fecha_actual, ultimo_prestamo_finalizado)
        moduloBiblioteca.cambiarEstadoEjemplar(GLO_CodEjemplarPrestamo, "Disponible")
        Me.Close()
    End Sub

    'Private Sub verificarSancionActiva(cod_socio As Integer)
    '    Dim cod_prestamo_atrasado As Integer = tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO)
    '    'Dim cod_sancion_espera As Integer = tomarSancionEspera(cod_prestamo_atrasado)
    '    'Dim fecha_finalizacion As Date = tomarFechaFinalizacion(cod_sancion_espera)
    '    'Dim fecha_actual = Today

    '    MsgBox("Cod_prestamo_atrasado = " & cod_prestamo_atrasado)
    '    'MsgBox("Cod_sancion_espera = " & cod_sancion_espera)
    '    'MsgBox("Cod_fecha_finalizacion = " & fecha_finalizacion)
    '    'MsgBox("Fecha actual = " & fecha_actual)
    'End Sub


    'Esta funcion toma el ultimo cod_prestamo_atrasado de un socio
    Public Function tomarUltimoPrestamoAtrasadoSocio(cod_socio As Integer) As Integer
        Dim cod_prestamo_socio = penultimoPrestamoSocio(cod_socio)
        Dim Sql As String = "SELECT cod_prestamo_atrasado from prestamo_atrasado WHERE cod_prestamo_socio= " & cod_prestamo_socio & ""
        Dim cod_prestamo_atrasado As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("cod_prestamo_atrasado"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    cod_prestamo_atrasado = VARIABLE_QUE_CONTENDRA_EL_VALOR
                    '
                    MsgBox("Ultimo prestamo_atrasado" & cod_prestamo_atrasado)
                    '

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


    'Public Function tomarSancionEspera(cod_prestamo_atrasado) As Integer
    '    Dim Sql As String = "SELECT cod_sancion_espera from prestamo_atrasado WHERE cod_prestamo_atrasado=" & cod_prestamo_atrasado & ""
    '    Dim cod_sancion_espera As Integer
    '    Dim Conexion As New MySqlConnection(cadena_conexion)

    '    Dim consulta As New MySqlCommand(Sql, Conexion)

    '    Try
    '        If Conexion.State = ConnectionState.Closed Then
    '            Conexion.Open()
    '            Dim Datos As MySqlDataReader = consulta.ExecuteReader
    '            If Datos.Read Then
    '                'Declaramos y llenamos
    '                Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As String = Trim(Datos("cod_prestamo_etrasado"))

    '                'Vemos que contiene la variable asignada para la direccion URL extraida
    '                'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

    '                'Imprimimos en el cuadro de texto la direccion URL
    '                cod_sancion_espera = VARIABLE_QUE_CONTENDRA_EL_VALOR

    '                Return cod_sancion_espera
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        'Cerramos la conexion a la BBDD MySQL
    '        Conexion.Close()

    '        'Eliminamos de la memoria el objeto CONSULTA que habiamos creado
    '        consulta = Nothing
    '    End Try
    'End Function

    'Public Function tomarFechaFinalizacion(cod_sancion_espera) As Date
    '    Dim Sql As String = "SELECT fecha_finalizacion from sancion_espera WHERE cod_sancion_espera=" & cod_sancion_espera & ""
    '    Dim fecha_finalizacion As Date
    '    Dim Conexion As New MySqlConnection(cadena_conexion)

    '    Dim consulta As New MySqlCommand(Sql, Conexion)

    '    Try
    '        If Conexion.State = ConnectionState.Closed Then
    '            Conexion.Open()
    '            Dim Datos As MySqlDataReader = consulta.ExecuteReader
    '            If Datos.Read Then
    '                'Declaramos y llenamos
    '                Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As String = Trim(Datos("fecha_finalizacion"))

    '                'Vemos que contiene la variable asignada para la direccion URL extraida
    '                'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

    '                'Imprimimos en el cuadro de texto la direccion URL
    '                fecha_finalizacion = VARIABLE_QUE_CONTENDRA_EL_VALOR

    '                Return fecha_finalizacion
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        'Cerramos la conexion a la BBDD MySQL
    '        Conexion.Close()

    '        'Eliminamos de la memoria el objeto CONSULTA que habiamos creado
    '        consulta = Nothing
    '    End Try
    'End Function

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
                    '
                    MsgBox("Ultimo prestamo_socio" & cod_prestamo_socio)
                    '

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

    Public Function primerPrestamoSocio(cod_socio As Integer) As Boolean
        Dim Sql As String = "SELECT MAX(cod_prestamo_socio) from prestamo_socio WHERE cod_socio= " & cod_socio & ""
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Boolean = IsDBNull(Datos("MAX(cod_prestamo_socio)"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL


                    Return VARIABLE_QUE_CONTENDRA_EL_VALOR
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

    'Public Function verificarExistenciaPrestamoAtrasado(cod_socio As Integer) As Boolean
    '    If Not IsDBNull(tomarUltimoPrestamoAtrasadoSocio(cod_socio)) Then
    '        MsgBox("No está vacio")
    '        Return True
    '    End If
    '    Return False
    'End Function

    'Private Sub verificarSancionActiva(cod_socio As Integer)
    '    Dim cod_prestamo_atrasado As Integer = tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO)
    '    'Dim cod_sancion_espera As Integer = tomarSancionEspera(cod_prestamo_atrasado)
    '    'Dim fecha_finalizacion As Date = tomarFechaFinalizacion(cod_sancion_espera)
    '    'Dim fecha_actual = Today

    '    MsgBox("Cod_prestamo_atrasado = " & cod_prestamo_atrasado)
    '    'MsgBox("Cod_sancion_espera = " & cod_sancion_espera)
    '    'MsgBox("Cod_fecha_finalizacion = " & fecha_finalizacion)
    '    'MsgBox("Fecha actual = " & fecha_actual)
    'End Sub



    Public Function verificarSancionActiva(cod_socio As Integer, cod_ultimo_prestamo_atrasado As Integer) As Integer
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

    'Esta funcion retorna cod_sancion_espera del ultimo prestamo atrasado en la tabla prestamo_atrasado sancion_espera 
    Public Function tomarUltimoSancionEsperaSocio(cod_socio As Integer) As Integer
        Dim ultimo_prestamo_atrasado As Integer = tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO)
        Dim Sql As String = "SELECT sancion_espera from prestamo_atrasado sancion_espera WHERE cod_prestamo_atrasado = " & ultimo_prestamo_atrasado & ""
        Dim cod_sancion_espera As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("cod_sancion_espera"))

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

    'Esta funcion retorna cod_sancion_espera del ultimo prestamo atrasado en la tabla prestamo_atrasado sancion_espera 

    'Public Function tomarCodSancionEspera(cod_socio As Integer) As Integer
    'Dim ultimo_prestamo_atrasado As Integer = tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO)
    'Dim Sql As String = "SELECT cod_sancion_espera from prestamo_atrasado WHERE cod_prestamo_atrasado = " & ultimo_prestamo_atrasado & ""
    'Dim cod_sancion_espera As Integer
    'Dim Conexion As New MySqlConnection(cadena_conexion)

    'Dim consulta As New MySqlCommand(Sql, Conexion)

    'Try
    '  If Conexion.State = ConnectionState.Closed Then
    '     Conexion.Open()
    '    Dim Datos As MySqlDataReader = consulta.ExecuteReader
    '   If Datos.Read Then
    '      'Declaramos y llenamos
    '     Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("cod_sancion_espera"))
    '
    'Vemos que contiene la variable asignada para la direccion URL extraida
    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

    'Imprimimos en el cuadro de texto la direccion URL
    '           cod_sancion_espera = VARIABLE_QUE_CONTENDRA_EL_VALOR
    '
    '
    '          MsgBox("Cod_sancion_espera:" & cod_sancion_espera)
    '

    '         Return cod_sancion_espera
    '    End If
    'End If
    'Catch ex As Exception
    '   MsgBox(ex.Message, MsgBoxStyle.Critical)
    'Cerramos la conexion a la BBDD MySQL
    '  Conexion.Close()

    'Eliminamos de la memoria el objeto CONSULTA que habiamos creado
    ' consulta = Nothing
    'End Try
    'End Function

    'Public Function tomarFechaFinalizacion(cod_socio As Integer) As Date
    'Dim cod_sancion_espera As Integer = tomarCodSancionEspera(GLO_COD_SOCIO)
    'Dim Sql As String = "SELECT fecha_finalizacion from sancion_espera WHERE cod_sancion_espera = " & cod_sancion_espera & ""
    'Dim fecha_finalizacion As Date
    'Dim Conexion As New MySqlConnection(cadena_conexion)

    '    Dim consulta As New MySqlCommand(Sql, Conexion)

    '    Try
    '        If Conexion.State = ConnectionState.Closed Then
    '            Conexion.Open()
    '            Dim Datos As MySqlDataReader = consulta.ExecuteReader
    '            If Datos.Read Then
    '                'Declaramos y llenamos
    '                Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Date = Trim(Datos("fecha_finalizacion"))

    '                'Vemos que contiene la variable asignada para la direccion URL extraida
    '                'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

    '                'Imprimimos en el cuadro de texto la direccion URL
    '                fecha_finalizacion = VARIABLE_QUE_CONTENDRA_EL_VALOR
    '                '
    '                MsgBox("Fecha finalizacion:" & fecha_finalizacion)
    '                '
    '                Return fecha_finalizacion
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MsgBox(ex.Message, MsgBoxStyle.Critical)
    '        'Cerramos la conexion a la BBDD MySQL
    '        Conexion.Close()

    '        'Eliminamos de la memoria el objeto CONSULTA que habiamos creado
    '        consulta = Nothing
    '    End Try
    'End Function
    Public Sub modificarSancionEspera(cod_sancion_espera As Integer, cod_socio As Integer)
        Dim consulta_local As String

        Dim fecha_finalizacion As Date
        fecha_finalizacion = tomarFechaFinalizacion(cod_socio)

        Dim agregar_dias As Integer
        agregar_dias = CalcularSancionEsperaDias(Prestamos.fecha_devolucion, Prestamos.fecha_actual, GLO_COD_SOCIO, Prestamos.hora_devolucion, Prestamos.hora_actual)
        MsgBox("Agregar dias: " & agregar_dias)
        fecha_finalizacion = DateAdd("d", agregar_dias, fecha_finalizacion)
        MsgBox("Agregar dias: " & fecha_finalizacion)


        'convierto fecha_finalizacion en string para el update
        Dim fecha_finalizacionSTR As String
        fecha_finalizacionSTR = fecha_finalizacion.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        MsgBox(fecha_finalizacionSTR)


        Try

            If ConexionMySQL() Then
                consulta_local = "update sancion_espera set fecha_finalizacion = '" & fecha_finalizacionSTR & "' where cod_sancion_espera = " & cod_sancion_espera & ""
                MsgBox(consulta_local)
                EjecutarTransaccion(consulta_local)
                MsgBox("Se agregó correctamente")

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Public Function NOexistePrestamoAtrasado(cod_socio) As Boolean
        Dim cod_prestamo_socio As Integer = cod_socio
        MsgBox("Ultimo prestamo_socio: " & cod_prestamo_socio)
        Dim Sql As String = "SELECT MAX(cod_prestamo_atrasado) from prestamo_atrasado WHERE cod_prestamo_socio= " & cod_prestamo_socio & ""
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Boolean = IsDBNull(Datos("MAX(cod_prestamo_atrasado)"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL


                    Return VARIABLE_QUE_CONTENDRA_EL_VALOR
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

    Public Sub cargarSancionEspera(fecha_inicio As Date)
        Dim consulta As String
        Dim fecha_inicioSTR As String = fecha_inicio.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        Dim dias_sancion As Integer = moduloBiblioteca.CalcularSancionEsperaDias(Prestamos.fecha_devolucion, Prestamos.fecha_actual, Prestamos.cod_prestamo_socio, Prestamos.hora_devolucion, Prestamos.hora_actual)
        Dim fecha_finalizacion As Date = DateAdd("d", dias_sancion, fecha_inicio)
        Dim fecha_finalizacionSTR As String = fecha_finalizacion.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        MsgBox("Fecha Inicio: " & fecha_inicioSTR)
        MsgBox("fecha finalizacion: " & fecha_finalizacionSTR)

        Try
            If ConexionMySQL() Then
                consulta = "insert into sancion_espera (fecha_inicio,fecha_finalizacion) values('" & fecha_inicioSTR & "','" & fecha_finalizacionSTR & "')"
                MsgBox(consulta)
                EjecutarTransaccion(consulta)
                MsgBox("Se agregó sancion_espera correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Function tomarUltimoCodSancionEspera() As Integer

        Dim Sql As String = "SELECT MAX(cod_sancion_espera) from sancion_espera"
        Dim max_sancion_espera As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("MAX(cod_sancion_espera)"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    max_sancion_espera = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return max_sancion_espera
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

    Public Function tomarUltimoCodSancionEsperaSocio() As Integer

        Dim Sql As String = "SELECT MAX(cod_sancion_espera) from sancion_espera"
        Dim max_sancion_espera As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("MAX(cod_sancion_espera)"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    max_sancion_espera = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return max_sancion_espera
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

    Public Function penultimoPrestamoSocio(cod_socio As Integer) As Integer

        Dim Sql As String = "Select cod_prestamo_socio FROM prestamo_socio where cod_socio = " & cod_socio & "  ORDER BY cod_prestamo_socio ASC LIMIT 1"
        Dim cod_prestamo_socio As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("cod_prestamo_socio"))

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

    Private Sub Decision_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

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
                    Dim vacio As Boolean = Not IsDBNull(Datos("MAX(cod_prestamo_socio)"))
                    If vacio = True Then
                        Return True
                    Else
                        Return False
                    End If
                    Return cod_prestamo_socio
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function

    Public Function tienePrestamoAtrasadoRegistrado(cod_socio As Integer) As Integer
        Dim Sql As String = "SELECT MAX(prestamo_atrasado.cod_prestamo_atrasado)
        from prestamo_atrasado INNER JOIN(SELECT prestamo_finalizado.cod_prestamo_finalizado 
        from prestamo_finalizado INNER JOIN prestamo_socio ON prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio where prestamo_socio.cod_socio = 19)
        AS AX ON prestamo_atrasado.cod_prestamo_finalizado = AX.cod_prestamo_finalizado;"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim cod As Boolean = Not IsDBNull(Datos("MAX(prestamo_atrasado.cod_prestamo_atrasado)"))
                    If cod = True Then
                        MsgBox("El socio tiene un prestamo atrasado registrado")
                        Return True
                    Else
                        MsgBox("El socio NOOOO tiene un prestamo atrasado registrado")
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

    Public Function ultimoPrestamoAtrasado(cod_socio As Integer) As Integer
        Dim Sql As String = "SELECT prestamo_atrasado.cod_prestamo_atrasado from prestamo_atrasado 
                            INNER JOIN (SELECT prestamo_finalizado.cod_prestamo_finalizado from prestamo_finalizado 
                            INNER JOIN prestamo_socio ON prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio where prestamo_socio.cod_socio = 19) 
                            AS AX ON prestamo_atrasado.cod_prestamo_finalizado = AX.cod_prestamo_finalizado ORDER BY prestamo_atrasado.cod_prestamo_atrasado DESC LIMIT 1;"
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
        Dim Sql As String = "SELECT cod_sancion_espera from sancion_espera WHERE cod_sancion_espera = '" & cod_prestamo_atrasado & "'"
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
        Dim Sql As String = "SELECT fecha_finalizacion from sancion_espera WHERE cod_sancion_espera = '" & cod_sancion_espera & "'"
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

    Public Function tomarUltimoPrestamoFinalizado() As Integer
        Dim Sql As String = "SELECT MAX(cod_prestamo_finalizado) from prestamo_finalizado limit 1"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim cod_prestamo_finalizado As Integer = Trim(Datos("MAX(cod_prestamo_finalizado)"))
                    Return cod_prestamo_finalizado
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function

    'Acontinuación se detalla los procedimientos para corrrobarar que el socio puede recibir una sancion maxima de 30 dias
    Public Function puedeRecibirSancion() As Boolean
        Dim cod_sancion_espera As Integer = Me.tomarCodSancionEspera(Me.tomarUltimoPrestamoAtrasadoSocio(GLO_COD_SOCIO))
        Dim fecha_finalizacion As Date = Me.tomarFechaFinalizacion(cod_sancion_espera)
        Dim fecha_inicio As Date = Me.tomarFechaInicio(cod_sancion_espera)
        If diffDias(fecha_inicio, fecha_finalizacion) > 30 Then
            MsgBox("El socio puede recibir sanción")
        End If
    End Function


    Public Function tomarFechaInicio(cod_sancion_espera As Integer) As Date
        Dim Sql As String = "SELECT fecha_inicio from sancion_espera WHERE cod_sancion_espera = '" & cod_sancion_espera & "'"
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    Dim fecha_inicio As Date = Trim(Datos("fecha_inicio"))
                    Return fecha_inicio
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Conexion.Close()
            consulta = Nothing
        End Try
    End Function


End Class