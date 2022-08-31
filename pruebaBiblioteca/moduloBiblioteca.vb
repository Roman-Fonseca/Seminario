Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Module moduloBiblioteca

    Public Function cargarSocio() As Boolean
        Dim LOC_consulta As String

        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into socio (nombre,apellido,telefono,direccion,estado_socio) values('" & AgregarSocio.txtNombre.Text & "','" & AgregarSocio.txtApellido.Text & "','" & AgregarSocio.txtTelefono.Text & "','" & AgregarSocio.txtDireccion.Text & "','" & AgregarSocio.txtEstado.Text & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False
    End Function

    Public Sub mostrarSocios()
        Dim Consulta As String = "select cod_socio,nombre,apellido,telefono,direccion,estado_socio,contador_prestamos from socio"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Socios.listaSocios.DataSource = dt


                Glodatareader.Close()
                'GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub
End Module
