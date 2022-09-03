Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Module moduloBiblioteca
    Public GLO_CodSocioModificar As Integer

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

    Public Sub ConsultarSocioModificar()

        GLO_CodSocioModificar = Socios.listaSocios.SelectedRows.Item(0).Cells(0).Value
        Dim Consulta As String = "Select nombre,apellido,telefono,direccion,estado_socio from socio where cod_socio= " & GLO_CodSocioModificar


        If conexion.ConexionMySQL() Then
            Glocomando.CommandText = Consulta
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader


            Dim dt As New DataTable
            dt.Load(Glodatareader)


            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)

            Try

                AgregarSocio.txtNombre.Text = Trim((CStr(row("nombre"))))
                AgregarSocio.txtApellido.Text = Trim((CStr(row("apellido"))))
                AgregarSocio.txtTelefono.Text = Trim((CStr(row("telefono"))))
                AgregarSocio.txtDireccion.Text = Trim((CStr(row("direccion"))))
                AgregarSocio.txtEstado.Text = Trim((CStr(row("estado_socio"))))

                Glodatareader.Close()
                GloconexionDB.Close()
            Catch ex As Exception
                GloconexionDB.Close()

            End Try
        End If
    End Sub

    Public Function EliminarSocio() As Boolean
        Dim LOC_socio As String
        Dim LOC_cod_socio, loc_consulta As String
        Dim a As Integer

        Try
            LOC_socio = (Socios.listaSocios.SelectedRows.Item(0).Cells(1).Value)
            LOC_cod_socio = (Socios.listaSocios.SelectedRows.Item(0).Cells(0).Value)

            a = MsgBox("Está seguro de eliminar este socio " & LOC_socio, MsgBoxStyle.YesNo, "ITEC 3")
            If a = MsgBoxResult.Yes Then
                loc_consulta = "delete from socio where cod_socio= " & LOC_cod_socio
                If ConexionMySQL() Then
                    EjecutarTransaccion(loc_consulta)
                    Return True
                End If
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return False

    End Function

    Public Function GuardarSocioModificado() As Boolean
        Dim LOC_consulta As String

        Try

            If ConexionMySQL() Then
                LOC_consulta = "update socio set  cod_socio=" & GLO_CodSocioModificar & ", 
                nombre = '" & AgregarSocio.txtNombre.Text & "', 
                apellido ='" & AgregarSocio.txtApellido.Text & "', 
                telefono='" & AgregarSocio.txtTelefono.Text & "', 
                direccion= '" & AgregarSocio.txtDireccion.Text & "', 
                estado_socio ='" & AgregarSocio.txtEstado.Text & "' where cod_socio= " & GLO_CodSocioModificar & ""
                MsgBox(LOC_consulta)
                Glocomando.CommandText = LOC_consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glodatareader = Glocomando.ExecuteReader
                Glodatareader.Close()
                MsgBox("Se Modificó Correctamente")
                GloconexionDB.Close()
                Return True


            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            GloconexionDB.Close()
            Return False
        End Try

        Return False
    End Function

    Public Sub limpiarCamposSocio()
        AgregarSocio.txtNombre.Clear()
        AgregarSocio.txtApellido.Clear()
        AgregarSocio.txtTelefono.Clear()
        AgregarSocio.txtDireccion.Clear()
        AgregarSocio.txtEstado.Clear()
    End Sub

    Public Function altaUbicacion() As Boolean
        Dim LOC_consulta As String

        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into ubicacion_libro (piso,sector,estante) values('" & AgregarUbicacion.txtPiso.Text & "','" & AgregarUbicacion.txtSector.Text & "','" & AgregarUbicacion.txtEstante.Text & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó ubicación correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False
    End Function

    Public Sub limpiarCamposAgregarUbicacion()
        AgregarUbicacion.txtPiso.Clear()
        AgregarUbicacion.txtSector.Clear()
        AgregarUbicacion.txtEstante.Clear()
    End Sub

    Public Function altaEditorial() As Boolean
        Dim LOC_consulta As String

        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into editorial (nombre_editorial,contacto,localizacion) values('" & AgregarEditorial.txtNombreEditorial.Text & "','" & AgregarEditorial.txtContactoEditorial.Text & "','" & AgregarEditorial.txtLocalizacionEditorial.Text & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó editorial correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False
    End Function

    Public Sub limpiarCamposAgregarEditorial()
        AgregarEditorial.txtNombreEditorial.Clear()
        AgregarEditorial.txtContactoEditorial.Clear()
        AgregarEditorial.txtLocalizacionEditorial.Clear()

    End Sub

    Public Sub CargarComboUbicacion()
        If ConexionMySQL() Then
            Glocomando.CommandText = "select cod_ubicacion_libro, piso, sector, estante from ubicacion_libro"
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader

            Dim dt As New DataTable
            dt.Load(Glodatareader)

            CargarLibro.cbxUbicacion.DataSource = dt
            CargarLibro.cbxUbicacion.DisplayMember = "cod_ubicacion_libro"
            CargarLibro.cbxUbicacion.ValueMember = "cod_ubicacion_libro"
            CargarLibro.cbxUbicacion.SelectedIndex = -1
            CargarLibro.cbxUbicacion.Text = "Selecione un codigo de ubicacion"

            Glodatareader.Close()
            GloconexionDB.Close()
        End If
    End Sub

    Public Sub CargarComboEditorial()
        If ConexionMySQL() Then
            Glocomando.CommandText = "select cod_editorial, nombre_editorial, contacto, localizacion from editorial"
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader

            Dim dt As New DataTable
            dt.Load(Glodatareader)

            CargarLibro.cbxEditorial.DataSource = dt
            CargarLibro.cbxEditorial.DisplayMember = "nombre_editorial"
            CargarLibro.cbxEditorial.ValueMember = "cod_editorial"
            CargarLibro.cbxEditorial.SelectedIndex = -1
            CargarLibro.cbxEditorial.Text = "Selecione una editorial"

            Glodatareader.Close()
            GloconexionDB.Close()
        End If
    End Sub

    Public Function altaCategoria() As Boolean
        Dim LOC_consulta As String

        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into categoria (nombre_categoria) values('" & AgregarCategoria.txtNombreCategoria.Text & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó categoria correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False
    End Function

    Public Sub CargarComboCategoria()
        If ConexionMySQL() Then
            Glocomando.CommandText = "select cod_categoria, nombre_categoria from categoria"
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader

            Dim dt As New DataTable
            dt.Load(Glodatareader)

            CargarLibro.cbxCategoria.DataSource = dt
            CargarLibro.cbxCategoria.DisplayMember = "nombre_categoria"
            CargarLibro.cbxCategoria.ValueMember = "cod_categoria"
            CargarLibro.cbxCategoria.SelectedIndex = -1
            CargarLibro.cbxCategoria.Text = "Selecione una categoria"

            Glodatareader.Close()
            GloconexionDB.Close()
        End If
    End Sub

    Public Function altaAutor() As Boolean
        Dim LOC_consulta As String

        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into autor (apellido,nacionalidad,nombre) values('" & AgregarAutor.txtApellido.Text & "','" & AgregarAutor.txtNacionalidad.Text & "','" & AgregarAutor.txtNombre.Text & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó autor correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False
    End Function

    Public Sub limpiarCamposAgregarAutor()
        AgregarAutor.txtNombre.Clear()
        AgregarAutor.txtApellido.Clear()
        AgregarAutor.txtNacionalidad.Clear()
    End Sub

End Module
