Imports MySql.Data.MySqlClient

Module ModuloFinalizarPrestamo

    'Alta prestamo finalizado
    Public Sub altaPrestamoFinalizado(cod_prestamo_socio As Integer, fecha_devolucion_real As Date, hora_devolucion_real As DateTime)
        Dim consulta As String
        Dim fecha_finalizacion_real As String = fecha_devolucion_real.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        Try

            If ConexionMySQL() Then
                consulta = "insert into prestamo_finalizado (fecha_finalizacion_real,hora_finalizacion_real,cod_prestamo_socio) 
                values('" & fecha_finalizacion_real & "','" & hora_devolucion_real & "','" & cod_prestamo_socio & "')"
                MsgBox(consulta)
                EjecutarTransaccionAltaPrestamoFinalizado(consulta)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'Ejecutar transaccion prestamo finalizado
    Public Sub EjecutarTransaccionAltaPrestamoFinalizado(MySQL As String)
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = MySQL
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glocomando.ExecuteNonQuery()
                GloconexionDB.Close()
                MsgBox("Se finalizó prestamo correctamente")
            End If

        Catch ex As Exception
            MsgBox("No se pudo finalizar préstamo", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            GloconexionDB.Close()
        End Try
    End Sub

    Public Sub registrarEjemplarAReponer()
        Dim LOC_consulta As String
        Dim cod_prestamo_finalizado As Integer = tomarUltimoPrestamoFinalizado()
        Try
            If ConexionMySQL() Then
                LOC_consulta = "insert into ejemplar_a_reponer (cod_prestamo_finalizado,repuesto) 
                values('" & cod_prestamo_finalizado & "','No')"
                MsgBox(LOC_consulta)
                EjecutarTransaccionAltaEjemplarAReponer(LOC_consulta)
                MsgBox("Se registró ejemplar a reponer correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub EjecutarTransaccionAltaEjemplarAReponer(MySQL As String)
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = MySQL
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glocomando.ExecuteNonQuery()
                GloconexionDB.Close()
                MsgBox("Se registró ejemplar a reponer correctamente")
            End If
        Catch ex As Exception
            MsgBox("No se pudo registrar el ejemplar a reponer", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            GloconexionDB.Close()
        End Try
    End Sub

End Module
