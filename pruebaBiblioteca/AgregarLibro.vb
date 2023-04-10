Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class AgregarLibro
    Dim dt As New DataTable
    Public COD_CATEGORIA As Integer
    Public COD_AUTOR As Integer
    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub lblUbicacion_Click(sender As Object, e As EventArgs) Handles lblUbicacion.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblEditorial.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarUbicacion.Click
        AgregarUbicacion.ShowDialog()
    End Sub

    Private Sub btnAgregarEditorial_Click(sender As Object, e As EventArgs) Handles btnAgregarEditorial.Click
        AgregarEditorial.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUbicacion.SelectedIndexChanged

    End Sub

    Private Sub CargarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.CargarComboUbicacion()
        moduloBiblioteca.CargarComboEditorial()
        'moduloBiblioteca.CargarComboCategoria()
        cargarTablaAutores()
        cargarTablaCategoria()
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        AgregarCategoria.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAutor.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarAutor.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim a As Integer

        a = MsgBox("Desea cancelar carga", MsgBoxStyle.YesNo, "Cargar libro")
        If a = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnSeleccionarAutor_Click(sender As Object, e As EventArgs) Handles btnSeleccionarAutor.Click
        SeleccionAutor.ShowDialog()
    End Sub

    Private Sub btnLimpiarCamposAutor_Click(sender As Object, e As EventArgs) Handles btnLimpiarCamposAutor.Click
        'LimpiarCampos.limpiarCamposCargarLibro()
        limpiarCampos()
    End Sub

    Private Sub btnGuardarAutor_Click(sender As Object, e As EventArgs) Handles btnGuardarAutor.Click
        'If Me.Text = "Cargar Libro" Then
        '    Me.Altalibro()
        '    Me.AltaLibroCategoria()
        '    Me.AltaLibroAutor()
        'Else
        '    '    moduloBiblioteca.modificarLibro()
        'End If

        If Me.txtTitulo.Text <> "" Then
            If cbxUbicacion.SelectedIndex = -1 Then
                MsgBox("Debe seleccionar ubicación")
                cbxUbicacion.BackColor = Color.Red
            Else
                If cbxEditorial.SelectedIndex = -1 Then
                    MsgBox("Debe seleccionar una editorial")
                    cbxEditorial.BackColor = Color.Red
                Else
                    If txtLibroEan.Text = "" Then
                        MsgBox("No puede dejar el campo Libro-EAN vacío")
                        txtLibroEan.BackColor = Color.Red
                    Else
                        If txtPais.Text = "" Then
                            MsgBox("No puede dejar el campo pais vacío")
                            txtPais.BackColor = Color.Red
                        Else
                            If txtSelloEditorial.Text = "" Then
                                MsgBox("No puede dejar el campo Sello Editorial vacío")
                                txtSelloEditorial.BackColor = Color.Red
                            Else
                                If txtCorrelativoAlTitulo.Text = "" Then
                                    MsgBox("No puede dejar el campo Correlativo al titulo vacio")
                                    txtCorrelativoAlTitulo.BackColor = Color.Red
                                Else
                                    If txtDigitoDeControl.Text = "" Then
                                        MsgBox("No puede dejar el campo Digito de control vacio")
                                        txtDigitoDeControl.BackColor = Color.Red
                                    Else
                                        If listBoxCategoria.Items.Count <= 0 Then
                                            MsgBox("Debe cargar por los menos una categoria")
                                        Else
                                            If ListBoxAutores.Items.Count <= 0 Then
                                                MsgBox("Debe seleccionar por los menos un autor")
                                            Else
                                                Me.Altalibro()
                                                Me.AltaLibroCategoria()
                                                Me.AltaLibroAutor()
                                            End If
                                        End If
                                    End If

                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Else
            MsgBox("Debe cargar el titulo del libro")
            txtTitulo.BackColor = Color.Red
        End If

        Me.limpiarCampos()


    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtAutor_TextChanged(sender As Object, e As EventArgs) Handles txtAutor.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnCategoria_Click(sender As Object, e As EventArgs)
        COD_CATEGORIA = Me.dgvCategoria.SelectedRows.Item(0).Cells(0).Value
        Me.listBoxCategoria.Items.Add(tomarCodCategoria(COD_CATEGORIA))
    End Sub

    Public Function tomarCodCategoria(COD_CATEGORIA As Integer) As String
        Dim Sql As String = "Select cod_categoria from categoria where cod_categoria=" & COD_CATEGORIA
        Dim estado As String
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As String = Trim(Datos("cod_categoria"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    estado = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return estado
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            'Cerramos la conexion a la BBDD MySQL
            Conexion.Close()

            'Eliminamos de la memoria el objeto CONSULTA que habiamos creado
            consulta = Nothing
            Return False
        End Try
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If (listBoxCategoria.SelectedIndex > -1) Then

            ' Eliminamos el elemento que se encuentra seleccionado 
            '
            listBoxCategoria.Items.RemoveAt(listBoxCategoria.SelectedIndex)

        End If
    End Sub

    Private Sub txtIsbn_TextChanged(sender As Object, e As EventArgs) Handles txtIsbn.TextChanged

    End Sub

    Private Sub txtIsbn_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIsbn.KeyPress
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtTitulo.Focus()
        End If
    End Sub

    Private Sub txtTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtTitulo.TextChanged
        txtTitulo.BackColor = Color.White
    End Sub

    Private Sub txtTitulo_Leave(sender As Object, e As EventArgs) Handles txtTitulo.Leave

    End Sub

    Private Sub txtTitulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTitulo.KeyPress
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            cbxUbicacion.Focus()
        End If
    End Sub

    Private Sub GroupBox2_Enter_1(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub botonAgregarCategoria_Click(sender As Object, e As EventArgs) Handles botonAgregarCategoria.Click
        Dim cod_categoria As Integer = Me.dgvCategoria.SelectedRows.Item(0).Cells(0).Value

        If Me.listBoxCategoria.FindStringExact(cod_categoria) = -1 Then
            Me.listBoxCategoria.Items.Add(cod_categoria)
        Else
            MsgBox("No puede agregar dos veces la mísma categoría")
        End If

    End Sub

    Private Sub cbxCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxCategoria.SelectedIndexChanged

    End Sub

    Public Sub cargarTablaAutores()
        Dim Consulta As String = "SELECT cod_autor, nombre, apellido FROM autor"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Me.dgvAutores.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Private Sub btnAgreagrAutor_Click(sender As Object, e As EventArgs) Handles btnAgreagrAutor.Click

        Dim cod_autor As Integer = Me.dgvAutores.SelectedRows.Item(0).Cells(0).Value

        If Me.ListBoxAutores.FindStringExact(cod_autor) = -1 Then
            Me.ListBoxAutores.Items.Add(cod_autor)
        Else
            MsgBox("No puede agregar dos veces el mísmo autor")
        End If

    End Sub

    Private Sub btnQuitarCategoria_Click(sender As Object, e As EventArgs) Handles btnQuitarCategoria.Click
        If (listBoxCategoria.SelectedIndex > -1) Then
            ' Eliminamos el elemento que se encuentra seleccionado 
            '
            listBoxCategoria.Items.RemoveAt(listBoxCategoria.SelectedIndex)
        End If
    End Sub

    Private Sub quitarAutor_Click(sender As Object, e As EventArgs) Handles quitarAutor.Click
        If (ListBoxAutores.SelectedIndex > -1) Then
            ' Eliminamos el elemento que se encuentra seleccionado 
            '
            ListBoxAutores.Items.RemoveAt(ListBoxAutores.SelectedIndex)
        End If
    End Sub

    Public Sub Altalibro()
        Dim LOC_consulta As String
        Dim isbn_completo As String

        Dim EAN As String = Me.txtLibroEan.Text
        Dim pais As String = Me.txtPais.Text
        Dim sello_editorial As String = Me.txtSelloEditorial.Text
        Dim correlativo_al_titulo As String = Me.txtCorrelativoAlTitulo.Text
        Dim digito_control As String = Me.txtDigitoDeControl.Text

        isbn_completo = EAN + "-" + pais + "-" + sello_editorial + "-" + correlativo_al_titulo + "-" + digito_control

        'Dim cod_libro As String

        Try
            'Alta libro'
            If ConexionMySQL() Then
                LOC_consulta = "insert into libro (titulo, isbn, cod_ubicacion ,cod_editorial) values('" & Me.txtTitulo.Text & "','" & isbn_completo & "','" & Me.cbxUbicacion.SelectedValue & "','" & Me.cbxEditorial.SelectedValue & "')"
                'MsgBox(LOC_consulta)
                EjecutarTransaccionAlta(LOC_consulta)
                MsgBox("Se agregó libro correctamente")
                limpiarCamposCargarLibro()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub AltaLibroCategoria()
        Dim a As Integer
        Dim consulta As String
        Dim ultimo_libro_cargado As Integer = tomarUltimoLibroCargado()
        Dim cod_categoria As Integer
        For a = 0 To listBoxCategoria.Items.Count - 1

            cod_categoria = listBoxCategoria.Items(a)
            'MsgBox(cod_categoria)
            Try
                'Alta libro'
                If ConexionMySQL() Then
                    consulta = "INSERT INTO `categoria_libro` (`cod_categoria`, `cod_libro`) VALUES (" & cod_categoria & ", " & ultimo_libro_cargado & ");"
                    'MsgBox(consulta)
                    EjecutarTransaccionAlta(consulta)
                    'MsgBox("Se agregó libro correctamente")
                    limpiarCamposCargarLibro()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next a
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)
        AltaLibroCategoria()
    End Sub

    Public Function tomarUltimoLibroCargado() As Integer
        Dim Sql As String = "SELECT cod_libro FROM libro ORDER BY cod_libro DESC limit 1;"
        Dim cod_libro As String
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    cod_libro = Trim(Datos("cod_libro"))
                    'MsgBox("Ultimo libro:" & cod_libro)
                    Return cod_libro
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            'Cerramos la conexion a la BBDD MySQL
            Conexion.Close()
            'Eliminamos de la memoria el objeto CONSULTA que habiamos creado
            consulta = Nothing
            Return False
        End Try
    End Function

    Public Sub AltaLibroAutor()
        Dim a As Integer
        Dim consulta As String
        Dim ultimo_libro_cargado As Integer = tomarUltimoLibroCargado()
        Dim cod_autor As Integer
        For a = 0 To ListBoxAutores.Items.Count - 1

            cod_autor = ListBoxAutores.Items(a)
            'MsgBox(cod_autor)
            Try
                'Alta libro'
                If ConexionMySQL() Then
                    consulta = "INSERT INTO `libro_autor` (`cod_libro`, `cod_autor`) VALUES (" & ultimo_libro_cargado & "," & cod_autor & ");"
                    'MsgBox(consulta)
                    EjecutarTransaccionAlta(consulta)
                    'MsgBox("Se agregó libro-autor correctamente")
                    limpiarCamposCargarLibro()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next a
    End Sub

    Private Sub txtBuscarCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarCategoria.TextChanged
        busquedaDinamicaCategoria(txtBuscarCategoria.Text, dgvCategoria)
    End Sub

    Public Sub busquedaDinamicaCategoria(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("SELECT cod_categoria, nombre FROM categoria WHERE nombre like '" & nombre + "%" & "'", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error con busqueda dinamica", ex.ToString)
        End Try
    End Sub

    Public Sub busquedaDinamicaAutor(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("SELECT cod_autor, nombre, apellido FROM autor WHERE nombre like '" & nombre + "%" & "'", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error con busqueda dinamica", ex.ToString)
        End Try
    End Sub

    Private Sub txtBuscarAutor_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarAutor.TextChanged
        busquedaDinamicaAutor(txtBuscarAutor.Text, dgvAutores)
    End Sub

    Private Sub txtLibroEan_TextChanged(sender As Object, e As EventArgs) Handles txtLibroEan.TextChanged
        txtLibroEan.BackColor = Color.White
    End Sub

    Private Sub txtLibroEan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLibroEan.KeyPress
        'Permito solamente números en el textbox
        txtLibroEan.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = True  ' Aceptas la introducción de espacios
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtPais.Focus()
        End If
    End Sub

    Private Sub txtPais_TextChanged(sender As Object, e As EventArgs) Handles txtPais.TextChanged
        txtPais.BackColor = Color.White
    End Sub

    Private Sub txtPais_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPais.KeyPress
        'Permito solamente números en el textbox
        txtPais.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = True  ' Aceptas la introducción de espacios
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtSelloEditorial.Focus()
        End If
    End Sub

    Private Sub txtSelloEditorial_TextChanged(sender As Object, e As EventArgs) Handles txtSelloEditorial.TextChanged
        txtSelloEditorial.BackColor = Color.White
    End Sub

    Private Sub txtSelloEditorial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSelloEditorial.KeyPress
        'Permito solamente números en el textbox
        txtSelloEditorial.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = True  ' Aceptas la introducción de espacios
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtCorrelativoAlTitulo.Focus()
        End If
    End Sub

    Private Sub txtCorrelativoAlTitulo_TextChanged(sender As Object, e As EventArgs) Handles txtCorrelativoAlTitulo.TextChanged
        txtCorrelativoAlTitulo.BackColor = Color.White
    End Sub

    Private Sub txtCorrelativoAlTitulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorrelativoAlTitulo.KeyPress
        'Permito solamente números en el textbox
        txtCorrelativoAlTitulo.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = True  ' Aceptas la introducción de espacios
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtDigitoDeControl.Focus()
        End If
    End Sub

    Private Sub txtDigitoDeControl_TextChanged(sender As Object, e As EventArgs) Handles txtDigitoDeControl.TextChanged
        txtDigitoDeControl.BackColor = Color.White
    End Sub

    Private Sub txtDigitoDeControl_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDigitoDeControl.KeyPress
        'Permito solamente números en el textbox
        txtDigitoDeControl.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = True  ' Aceptas la introducción de espacios
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtBuscarCategoria.Focus()
        End If
    End Sub

    Private Sub cbxUbicacion_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxUbicacion.MouseClick
        cbxUbicacion.BackColor = Color.White
    End Sub

    Private Sub cbxEditorial_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEditorial.SelectedIndexChanged

    End Sub

    Private Sub cbxEditorial_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxEditorial.MouseClick
        cbxEditorial.BackColor = Color.White
    End Sub

    Public Sub limpiarCampos()
        'limpio todos los cuadros de textos
        Me.txtTitulo.Clear()
        Me.cbxUbicacion.SelectedIndex = -1
        Me.cbxEditorial.SelectedIndex = -1
        Me.txtCod_libro.Clear()
        Me.txtLibroEan.Clear()
        Me.txtPais.Clear()
        Me.txtSelloEditorial.Clear()
        Me.txtCorrelativoAlTitulo.Clear()
        Me.txtDigitoDeControl.Clear()

        Me.txtBuscarAutor.Clear()
        Me.txtBuscarCategoria.Clear()

        Me.listBoxCategoria.Items.Clear()
        Me.ListBoxAutores.Items.Clear()

    End Sub
End Class