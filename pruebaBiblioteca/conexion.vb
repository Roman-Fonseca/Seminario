Imports System.Data
Imports MySql.Data.MySqlClient

Module conexion
    'Defino Cadena Conexion'
    Public cadena_conexion As String = "server=localhost; user id=root; Database=pruebabiblioteca"

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

    Public Sub probarConexion()
        Dim verdadero = ConexionMySQL()
        If verdadero = True Then
            MsgBox("Conexion Exitosa")
        End If
    End Sub

    Public Sub EjecutarTransaccion(MySQL As String)
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = MySQL
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glocomando.ExecuteNonQuery()
                GloconexionDB.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            GloconexionDB.Close()
        End Try

    End Sub


End Module
