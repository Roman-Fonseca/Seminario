﻿Imports System.Data
Imports MySql.Data.MySqlClient

Module conexion
    'Defino Cadena Conexion'
    Public cadena_conexion As String = "server=localhost; user id=root; Database=pruebabiblioteca;convert zero datetime=True"

    Public GLO_CambiosSocios As Integer = 0

    'Defino GloConexion Como Conexion MySql'
    Public GloconexionDB As New MySql.Data.MySqlClient.MySqlConnection
    Public Glocomando As New MySql.Data.MySqlClient.MySqlCommand
    Public Glodatareader As MySql.Data.MySqlClient.MySqlDataReader

    'Defino Funcion que retorna true si se pudo establecer conexion con la base de datos'
    Public Function ConexionMySQL() As Boolean
        If GloconexionDB.State = ConnectionState.Closed Then
            GloconexionDB.ConnectionString = cadena_conexion
            GloconexionDB.Open()
        End If
        Return True
    End Function

    Public Sub abrirConexionMySql()
        If GloconexionDB.State = ConnectionState.Closed Then
            GloconexionDB.ConnectionString = cadena_conexion
            GloconexionDB.Open()
        End If
    End Sub

    Public Sub probarConexion()
        Dim verdadero = ConexionMySQL()
        If verdadero = True Then
            MsgBox("Conexion Exitosa")
        End If
    End Sub

    Public Sub EjecutarTransaccionAlta(MySQL As String)
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = MySQL
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glocomando.ExecuteNonQuery()
                GloconexionDB.Close()
                MsgBox("Se agregó registro correctamente")
            End If

        Catch ex As Exception
            MsgBox("No se pudo cargar registro", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            GloconexionDB.Close()
        End Try

    End Sub

    Public Sub EjecutarTransaccionBaja(MySQL As String)
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = MySQL
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glocomando.ExecuteNonQuery()
                GloconexionDB.Close()
                MsgBox("Se eliminó registro correctamente")
            End If

        Catch ex As Exception
            MsgBox("El registro se encuentra en otras tablas. La eliminacion del mísmo esta restringida", MsgBoxStyle.Critical)
            'MsgBox(ex.Message)
            GloconexionDB.Close()
        End Try
    End Sub

    Public Sub EjecutarTransaccionModificacion(MySQL As String)
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = MySQL
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glocomando.ExecuteNonQuery()
                GloconexionDB.Close()
                MsgBox("Se modificó registro correctamente")
            End If

        Catch ex As Exception
            MsgBox("No se pudo modificar registro", MsgBoxStyle.Critical)
            MsgBox(ex.Message)
            GloconexionDB.Close()
        End Try

    End Sub


End Module
