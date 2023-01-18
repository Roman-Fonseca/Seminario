Imports System.Data.SqlClient
Imports System.Globalization
Imports System.Reflection.Emit
Imports System.Security.Cryptography.X509Certificates
Imports MySql.Data.MySqlClient

Module moduloBiblioteca
    Public GLO_CodSocioModificar As Integer
    Public GLO_CodSocioPrestamo As Integer
    Public GLO_CodEjemplarPrestamo As Integer 'Esta variable se utiliza a la hora de realizar un prestamo y toma el valor del cod_ejemplar prestado
    Public GLO_CodAutor As Integer  'Esta variable se utilza especialmenet para mostrar el autor seleccionado a la hora de cargar un LIBRO'
    Public GLO_ApellidoAutor As String
    Public GLO_NombreAutor As String
    Public cod_prestamo_modificar As Integer
    Public cod_prestamo_socio As Integer
    Public GLOBAL_DIA_ACTUAL As Date

    Public GLO_CodLibro As Integer
    Public GLO_TituloLibro As String

    Dim dt As New DataTable
    Public adaptador As MySqlDataAdapter

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
        Dim Consulta As String = "select cod_socio,nombre,apellido,telefono,direccion,contador_prestamos,estado_socio from socio"
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
                GloconexionDB.Close()
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



    Public Sub CargarComboUbicacion()
        If ConexionMySQL() Then
            Glocomando.CommandText = "select cod_ubicacion_libro, piso, sector, estante from ubicacion_libro"
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader

            Dim dt As New DataTable
            dt.Load(Glodatareader)

            AgregarLibro.cbxUbicacion.DataSource = dt
            AgregarLibro.cbxUbicacion.DisplayMember = "cod_ubicacion_libro"
            AgregarLibro.cbxUbicacion.ValueMember = "cod_ubicacion_libro"
            AgregarLibro.cbxUbicacion.SelectedIndex = -1
            AgregarLibro.cbxUbicacion.Text = "Selecione un codigo de ubicacion"

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

            AgregarLibro.cbxEditorial.DataSource = dt
            AgregarLibro.cbxEditorial.DisplayMember = "nombre_editorial"
            AgregarLibro.cbxEditorial.ValueMember = "cod_editorial"
            AgregarLibro.cbxEditorial.SelectedIndex = -1
            AgregarLibro.cbxEditorial.Text = "Selecione una editorial"

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

            AgregarLibro.cbxCategoria.DataSource = dt
            AgregarLibro.cbxCategoria.DisplayMember = "nombre_categoria"
            AgregarLibro.cbxCategoria.ValueMember = "cod_categoria"
            AgregarLibro.cbxCategoria.SelectedIndex = -1
            AgregarLibro.cbxCategoria.Text = "Selecione una categoria"

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

    Public Function altaTipoEjemplar() As Boolean
        Dim LOC_consulta As String

        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into tipo_ejemplar (descripcion) values('" & AgregarTipoEjemplar.txtNombreTipoEjemplar.Text & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó Tipo Ejemplar correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False
    End Function

    Public Sub CargarComboTipoEjemplar()
        If ConexionMySQL() Then
            Glocomando.CommandText = "select cod_tipo_ejemplar, descripcion from tipo_ejemplar"
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader

            Dim dt As New DataTable
            dt.Load(Glodatareader)

            AgregarEjemplar.cbxTipoEjemplar.DataSource = dt
            AgregarEjemplar.cbxTipoEjemplar.DisplayMember = "descripcion"
            AgregarEjemplar.cbxTipoEjemplar.ValueMember = "cod_tipo_ejemplar"
            AgregarEjemplar.cbxTipoEjemplar.SelectedIndex = -1
            AgregarEjemplar.cbxTipoEjemplar.Text = "Selecione un tipo de ejemplar"

            Glodatareader.Close()
            GloconexionDB.Close()
        End If
    End Sub


    Public Sub llenarGrilla(ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("Select * from autor", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la grilla", ex.ToString)
        End Try
    End Sub

    Public Sub busquedaDinamicaAutor(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("Select * from autor where nombre like '" & nombre + "%" & "'", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error con busqueda dinamica", ex.ToString)
        End Try
    End Sub

    Public Function altaLibro() As Boolean
        Dim LOC_consulta As String
        'Dim cod_libro As String

        Try
            'Alta libro'
            If ConexionMySQL() Then
                LOC_consulta = "insert into libro (isbn,titulo,cod_ubicacion_libro,cod_editorial) values('" & AgregarLibro.txtIsbn.Text & "','" & AgregarLibro.txtTitulo.Text & "','" & AgregarLibro.cbxUbicacion.SelectedValue & "','" & AgregarLibro.cbxEditorial.SelectedValue & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó libro correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False

    End Function
    Public Function eliminarLibro() As Boolean
        Dim LOC_autor As String
        Dim LOC_cod_autor, loc_consulta As String
        Dim a As Integer

        Try
            LOC_autor = (SeleccionAutor.dgvAutor.SelectedRows.Item(0).Cells(1).Value)
            LOC_cod_autor = (SeleccionAutor.dgvAutor.SelectedRows.Item(0).Cells(0).Value)

            a = MsgBox("Está seguro de eliminar este autor " & LOC_autor, MsgBoxStyle.YesNo, "ITEC 3")
            If a = MsgBoxResult.Yes Then
                loc_consulta = "delete from socio where cod_socio= " & LOC_cod_autor
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

    Public Sub mostrarEjemplares()
        Dim Consulta As String = "select cod_ejemplar_libro,num_ejemplar,cod_libro,cod_tipo_ejemplar,estado from ejemplar_libro"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Ejemplares.listaEjemplares.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Public Sub CargarComboPlazoPrestamo()
        If ConexionMySQL() Then
            Glocomando.CommandText = "select cod_plazo_prestamo,descripcion_plazo from plazo_prestamo"
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader

            Dim dt As New DataTable
            dt.Load(Glodatareader)

            AgregarEjemplar.cbxPlazoPrestamo.DataSource = dt
            AgregarEjemplar.cbxPlazoPrestamo.DisplayMember = "descripcion_plazo"
            AgregarEjemplar.cbxPlazoPrestamo.ValueMember = "cod_plazo_prestamo"
            AgregarEjemplar.cbxPlazoPrestamo.SelectedIndex = -1
            AgregarEjemplar.cbxPlazoPrestamo.Text = "Selecione una Plazo"

            Glodatareader.Close()
            GloconexionDB.Close()
        End If
    End Sub

    'Public Sub CargarComboSocioPrestamo()
    '    If ConexionMySQL() Then
    '        Glocomando.CommandText = "select cod_socio,nombre,apellido from socio"
    '        Glocomando.CommandType = CommandType.Text
    '        Glocomando.Connection = GloconexionDB

    '        Glodatareader = Glocomando.ExecuteReader

    '        Dim dt As New DataTable
    '        dt.Load(Glodatareader)

    '        AgregarPrestamo.cbxSocios.DataSource = dt
    '        AgregarPrestamo.cbxSocios.DisplayMember = "nombre"
    '        AgregarPrestamo.cbxSocios.ValueMember = "cod_socio"
    '        AgregarPrestamo.cbxSocios.SelectedIndex = -1
    '        AgregarPrestamo.cbxSocios.Text = "Selecione un socio"

    '        Glodatareader.Close()
    '        GloconexionDB.Close()
    '    End If
    'End Sub

    Public Sub llenarGrillaLibros(ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("Select * from libro", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la grilla", ex.ToString)
        End Try
    End Sub

    Public Sub busquedaDinamicaLibro(ByVal titulo As String, ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("Select * from libro where titulo like '" & titulo + "%" & "'", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error con busqueda dinamica", ex.ToString)
        End Try
    End Sub

    Public Function altaEjemplar() As Boolean
        Dim LOC_consulta As String
        'Dim cod_ejemplar As String

        Try
            'Alta ejemplar'
            If ConexionMySQL() Then
                LOC_consulta = "insert into ejemplar_libro(estado,num_ejemplar,cod_tipo_ejemplar,cod_libro,cod_plazo_prestamo)
                values('" & AgregarEjemplar.cbxEstado.Text & "','" & AgregarEjemplar.txtNumeroEjemplar.Text & "','" & AgregarEjemplar.cbxTipoEjemplar.SelectedValue & "',
                '" & GLO_CodLibro & "', '" & AgregarEjemplar.cbxPlazoPrestamo.SelectedValue & "'
                )"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó ejemplar correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False

    End Function

    Public Function altaPlazoPrestamo() As Boolean
        Dim LOC_consulta As String

        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into plazo_prestamo (descripcion_plazo,dias_plazo) values('" & AgregarPlazoPrestamo.txtDescripcion.Text & "','" & AgregarPlazoPrestamo.txtDias.Text & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó plazo prestamo correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False
    End Function

    Public Sub busquedaDinamicaEjemplar(ByVal cod_libro As String, ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("Select * from ejemplar_libro where cod_libro like '" & cod_libro + "%" & "'", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error con busqueda dinamica", ex.ToString)
        End Try
    End Sub

    Public Sub llenarGrillaEjemplares(ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("Select * from ejemplar_libro", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la grilla", ex.ToString)
        End Try
    End Sub

    Public Sub busquedaDinamicaSocio(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("Select * from socio where nombre like '" & nombre + "%" & "'", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error con busqueda dinamica", ex.ToString)
        End Try
    End Sub
    Public Sub llenarGrillaSocios(ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("Select * from socio", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error al cargar la grilla", ex.ToString)
        End Try
    End Sub

    Public Function altaPrestamo() As Boolean
        Dim LOC_consulta As String
        GLO_CodSocioPrestamo = AgregarPrestamo.dgvSocio.SelectedRows.Item(0).Cells(0).Value
        GLO_CodEjemplarPrestamo = AgregarPrestamo.dgvEjemplar.SelectedRows.Item(0).Cells(0).Value

        'Capturo fecha actual del sistema
        Dim fechaPrestamoDate As Date
        fechaPrestamoDate = Today

        'Convierto la fecha actual en string
        Dim fechaPrestamoString As String
        fechaPrestamoString = fechaPrestamoDate.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        'Convierto la fechaPrestamoString a fechaPrestamoDate
        'fechaPrestamoDate = Date.ParseExact(fechaPrestamoString, "yyyy/MM/dd", CultureInfo.CurrentCulture, DateTimeStyles.None)



        'Capturo hora actual del sistema
        Dim horaPrestamo As DateTime
        horaPrestamo = TimeOfDay

        Dim hora_devolucionString = AgregarPrestamo.txtHoraDevolucion.Text
        'Dim hora_devolucion As DateTime = DateTime.ParseExact(hora_devolucionString, "hh/mm/ss", CultureInfo.CurrentCulture, DateTimeStyles.None)


        'Capturo dia selecionado para devolucion Prestamo
        Dim fechaDevolucionDate As Date
        fechaDevolucionDate = Format(AgregarPrestamo.dtpFechaDevolucion.Value, "short date")

        'Convierto la fechaDevolucionDate en string
        Dim fechaDevolucionString As String
        fechaDevolucionString = fechaDevolucionDate.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        'Convierto la fechaDevolucionString a fechaDevolucionDate
        'fechaDevolucionDate = Date.ParseExact(fechaDevolucionString, "yyyy/MM/dd", CultureInfo.CurrentCulture, DateTimeStyles.None)

        'Alta prestamo
        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into prestamo_socio (tipo_prestamo,fecha_prestamo,hora_prestamo,fecha_devolucion,
                                hora_devolucion,cod_socio,cod_ejemplar_libro) 
                                values('" & AgregarPrestamo.cbxTipoPrestamo.Text & "','" & fechaPrestamoString & "','" & horaPrestamo & "','" & fechaDevolucionString & "'
                                ,'" & hora_devolucionString & "','" & GLO_CodSocioPrestamo & "','" & GLO_CodEjemplarPrestamo & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó prestamo correctamente")
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return False
    End Function

    Public Function altaPrestamo_ejemplar()

        Dim LOC_consulta2 As String
        Dim cod_ejemplar As Integer
        Dim cod_ultimo_prestamo As Integer

        Dim CONSULTA_ultimoRegistroPrestamo As String
        CONSULTA_ultimoRegistroPrestamo = "Select max(cod_prestamo_socio) from prestamo_socio"

        GloconexionDB.Open()

        Dim consulta As MySqlCommand
        consulta = New MySqlCommand(CONSULTA_ultimoRegistroPrestamo, GloconexionDB)

        cod_ultimo_prestamo = Convert.ToInt32(consulta.ExecuteScalar())

        'MsgBox(cod_ultimpo_prestamo)

        cod_ejemplar = AgregarPrestamo.dgvEjemplar.SelectedRows.Item(0).Cells(0).Value

        Try
            If ConexionMySQL() Then
                LOC_consulta2 = "INSERT INTO `ejemplar_libro prestamo_socio`(`cod_ejemplar_libro`, `cod_prestamo_socio`) VALUES ('" & cod_ejemplar & "','" & cod_ultimo_prestamo & "')"
                MsgBox(LOC_consulta2)
                EjecutarTransaccion(LOC_consulta2)
                MsgBox("Se agregó prestamo correctamente")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        GloconexionDB.Close()
        Return True
    End Function

    Public Sub prueba()

        Dim fechaPrestamoString As String
        fechaPrestamoString = Today.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        Dim fechaPrestamoDate As Date
        fechaPrestamoDate = Convert.ToDateTime(fechaPrestamoString)




        'Capturo hora actual del sistema
        Dim horaPrestamo As DateTime
        horaPrestamo = TimeOfDay

        'Capturo dia selecionado para devolucion Prestamo
        Dim fechaDevolucionDate As Date
        fechaDevolucionDate = Format(Form1.dtpFechaDevolucion.Value, "short date")

        'Convierto la fechaDevolucionDate en string
        Dim fechaDevolucionString As String
        fechaDevolucionString = fechaDevolucionDate.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)




        MsgBox("La fecha es " & fechaPrestamoDate & "")
        MsgBox("La hora es " & horaPrestamo & "")
        MsgBox("La fecha de devolucion es " & fechaDevolucionString & "")
    End Sub

    Public Sub mostrarPrestamos()
        'Mostrar prestamos pendientes de finalizar
        Dim Consulta As String = "select cod_prestamo_socio,tipo_prestamo,fecha_prestamo,hora_prestamo,fecha_devolucion,hora_devolucion,fecha_devolucion_real,hora_devolucion_real,cod_socio from prestamo_socio"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Prestamos.dgvPrestamos.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Public Sub ConsultarPrestamoModificar()

        'cod_prestamo_modificar = Prestamos.dgvPrestamos.SelectedRows.Item(0).Cells(0).Value
        'cod_prestamo_socio = Prestamos.dgvPrestamos.SelectedRows.Item(0).Cells(0).Value
        Dim ConsultarPrestamo As String = "Select tipo_prestamo,fecha_prestamo,hora_prestamo,fecha_devolucion,hora_devolucion,fecha_devolucion_real,hora_devolucion_real,cod_socio from prestamo_socio where cod_prestamo_socio=" & cod_prestamo_modificar


        If conexion.ConexionMySQL() Then
            Glocomando.CommandText = ConsultarPrestamo
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader


            Dim dt As New DataTable
            dt.Load(Glodatareader)


            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)

            Try
                AgregarPrestamo.cbxTipoPrestamo.Text = CStr(row("tipo_prestamo"))
                AgregarPrestamo.dtpFechaDevolucion.Value = CStr(row("fecha_devolucion"))
                AgregarPrestamo.txtHoraDevolucion.Text = row("hora_devolucion").ToString
                AgregarPrestamo.txtBuscarSocio.Text = CStr(row("cod_socio"))




                Glodatareader.Close()
                GloconexionDB.Close()
            Catch ex As Exception
                GloconexionDB.Close()

            End Try
        End If

        'Tomar el numero del ejemplar prestado para cargalo en el txtBuscarEjemplar 
        'Dim Consultar_prestamo_ejemplar As String = "Select * from `ejemplar_libro prestamo_socio`
        '    where cod_prestamo_socio=" & cod_prestamo_modificar

        'If conexion.ConexionMySQL() Then
        '    Glocomando.CommandText = ConsultarPrestamo
        '    Glocomando.CommandType = CommandType.Text
        '    Glocomando.Connection = GloconexionDB

        '    Glodatareader = Glocomando.ExecuteReader

        '    Dim dt As New DataTable
        '    dt.Load(Glodatareader)

        '    Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)

        '    Try
        '        AgregarPrestamo.txtBuscarEjemplar.Text = CStr(row("cod_ejemplar_libro"))

        '        Glodatareader.Close()
        '        GloconexionDB.Close()
        '    Catch ex As Exception
        '        GloconexionDB.Close()

        '    End Try
        'End If
    End Sub

    Public Function modificarPrestamo() As Boolean
        Dim LOC_consulta As String
        Try

            If ConexionMySQL() Then
                LOC_consulta = "update prestamo_socio set
                tipo_prestamo = '" & AgregarPrestamo.cbxTipoPrestamo.Text & "', 
                fecha_devolucion ='" & AgregarPrestamo.dtpFechaDevolucion.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) & "', 
                hora_devolucion='" & AgregarPrestamo.txtHoraDevolucion.Text & "', 
                cod_socio= '" & 1 & "' where cod_prestamo_socio= " & cod_prestamo_modificar & ""
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

            'Convierto la fechaDevolucionDate en string
            'Dim fechaDevolucionString As String
            'fechaDevolucionString = fechaDevolucionDate.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)


        Catch ex As Exception
            MsgBox(ex.Message)
            GloconexionDB.Close()
            Return False
        End Try

        Return False
    End Function

    Public Function finalizarPrestamo() As Boolean
        Dim LOC_consulta As String

        'Capturo fecha actual del sistema
        Dim fechaPrestamoDate As Date
        fechaPrestamoDate = Today

        'Convierto la fecha actual en string
        Dim fechaPrestamoString As String
        fechaPrestamoString = fechaPrestamoDate.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        'Capturo la hora actual del sistema
        Dim horaPrestamo As DateTime
        horaPrestamo = TimeOfDay


        'Capturo la fecha_devolucion_real del prestamo
        Dim fecha_devolucion_real As Date
        fecha_devolucion_real = Today

        'Update
        Try

            If ConexionMySQL() Then
                LOC_consulta = "update prestamo_socio set
                tipo_prestamo = '" & AgregarPrestamo.cbxTipoPrestamo.Text & "', 
                fecha_devolucion ='" & AgregarPrestamo.dtpFechaDevolucion.Value.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture) & "', 
                hora_devolucion='" & AgregarPrestamo.txtHoraDevolucion.Text & "', 
                fecha_devolucion_real='" & fechaPrestamoString & "',
                hora_devolucion_real='" & horaPrestamo & "',
                cod_socio= '" & 1 & "' where cod_prestamo_socio= " & cod_prestamo_modificar & ""
                MsgBox(LOC_consulta)
                Glocomando.CommandText = LOC_consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glodatareader = Glocomando.ExecuteReader
                Glodatareader.Close()
                MsgBox("Se finalizo prestamo correctamente")
                GloconexionDB.Close()
                Return True
            End If

            'Comparo fecha_devolución con fecha_devolucion_real 

            GLO_CodEjemplarPrestamo = AgregarPrestamo.dgvEjemplar.SelectedRows.Item(0).Cells(0).Value

            'Convierto la fechaDevolucionDate en string
            'Dim fechaDevolucionString As String
            'fechaDevolucionString = fechaDevolucionDate.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)


        Catch ex As Exception
            MsgBox(ex.Message)
            GloconexionDB.Close()
            Return False
        End Try

        Return False
    End Function

    Public Function finalizarPrestamoAtajo() As Boolean
        Dim LOC_consulta As String

        'Capturo cod_prestamo
        cod_prestamo_modificar = Prestamos.dgvPrestamos.SelectedRows.Item(0).Cells(0).Value

        'Capturo fecha actual del sistema
        Dim fecha_actual As Date
        fecha_actual = Today

        'Convierto la fecha actual en string
        Dim fecha_actual_string As String
        fecha_actual_string = fecha_actual.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        'Capturo la hora actual del sistema
        Dim hora_actual As DateTime
        hora_actual = TimeOfDay

        'Capturo fecha_devolucion
        Dim fecha_devolucion As Date
        fecha_devolucion = Prestamos.dgvPrestamos.SelectedRows.Item(0).Cells(4).Value


        'Capturo hora_devolución
        Dim hora_devolucion As DateTime
        fecha_devolucion = Prestamos.dgvPrestamos.SelectedRows.Item(0).Cells(5).Value.ToString

        'Update
        Try

            If ConexionMySQL() Then
                LOC_consulta = "update prestamo_socio set
                fecha_devolucion_real='" & fecha_actual_string & "',
                hora_devolucion_real='" & hora_actual & "' where cod_prestamo_socio= " & cod_prestamo_modificar & ""
                MsgBox(LOC_consulta)
                Glocomando.CommandText = LOC_consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glodatareader = Glocomando.ExecuteReader
            End If
            Glodatareader.Close()
            MsgBox("Se finalizo prestamo correctamente")
            GloconexionDB.Close()
            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            GloconexionDB.Close()
            Return False
        End Try


    End Function

    Public Function compararFechas(fecha_devolucion As Date, fecha_actual As Date, hora_devolucion As DateTime,
                                   hora_actual As DateTime) As Boolean
        If (fecha_actual > fecha_devolucion) Then
            MsgBox("Prestamo atrasado")
        ElseIf fecha_actual = fecha_devolucion Then
            If hora_actual > hora_devolucion Then
                MsgBox("Prestamo atrasado")
            Else
                MsgBox("Faltan Horas")
            End If
        Else
            MsgBox("El prestamo no está atrasado")
        End If
    End Function


    Public Sub mostrarPrestamosVencidos()
        'Capturo la fecha Actual
        GLOBAL_DIA_ACTUAL = Today
        Dim dia_actual_string As String
        dia_actual_string = GLOBAL_DIA_ACTUAL.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        'Capturo la hora actual
        'Capturo la hora actual del sistema
        Dim horaActual As DateTime
        horaActual = TimeOfDay

        'Mostrar prestamos donde la fecha actual es mayor a la fecha de devolucion del prestamo
        Dim Consulta As String = "select cod_prestamo_socio,tipo_prestamo,fecha_prestamo,hora_prestamo,fecha_devolucion,hora_devolucion,cod_socio from prestamo_socio where '" & dia_actual_string & "' >= fecha_devolucion AND hora_devolucion > '" & horaActual & "' AND fecha_devolucion_real  = '0000-00-00'"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)



                Prestamos.dgvPrestamos.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Public Sub mostrarPrestamosVencidosDevueltos()
        'Capturo la fecha Actual
        GLOBAL_DIA_ACTUAL = Today
        Dim dia_actual_string As String
        dia_actual_string = GLOBAL_DIA_ACTUAL.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        'Capturo la hora actual
        'Capturo la hora actual del sistema
        Dim horaActual As DateTime
        horaActual = TimeOfDay

        'Mostrar prestamos donde la fecha actual es mayor a la fecha de devolucion del prestamo
        Dim Consulta As String = "select cod_prestamo_socio,tipo_prestamo,fecha_prestamo,hora_prestamo,fecha_devolucion,hora_devolucion,cod_socio,fecha_devolucion_real,hora_devolucion_real from prestamo_socio where '" & dia_actual_string & "' > fecha_devolucion AND hora_devolucion < '" & horaActual & "' AND fecha_devolucion_real IS NOT NULL OR fecha_devolucion_real != '0000-00-00'"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)



                Prestamos.dgvPrestamos.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

End Module
