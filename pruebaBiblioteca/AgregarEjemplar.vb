Imports Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel
Imports MySql.Data.MySqlClient

Public Class AgregarEjemplar
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTipoEjemplar.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAgregarTipoEjemplar_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoEjemplar.Click
        AgregarTipoEjemplar.ShowDialog()
    End Sub

    Private Sub AgregarEjemplar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.CargarComboTipoEjemplar()
        moduloBiblioteca.llenarGrillaLibros(dgvLibros)
        moduloBiblioteca.CargarComboPlazoPrestamo()
        txtLibro.Enabled = False
    End Sub

    Private Sub btnSeleccionarLibro_Click(sender As Object, e As EventArgs)
        'SeleccionarLibro.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibros.CellContentClick

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblLibros.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarlibro.TextChanged
        moduloBiblioteca.busquedaDinamicaLibro(txtBuscarlibro.Text, dgvLibros)
    End Sub

    Private Sub btnSeleccionarLibro_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionarLibro.Click
        GLO_CodLibro = Me.dgvLibros.SelectedRows.Item(0).Cells(0).Value
        GLO_TituloLibro = Me.dgvLibros.SelectedRows.Item(0).Cells(2).Value
        txtLibro.BackColor = Color.White

        If IsDBNull(buscarUltimoNumeroEjemplar(GLO_CodLibro)) Then
            Me.txtNumeroEjemplar.Text = 1
        Else
            Me.txtNumeroEjemplar.Text = buscarUltimoNumeroEjemplar(GLO_CodLibro) + 1
        End If

        Me.txtLibro.Text = GLO_TituloLibro.ToString

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        If Me.Text = "Agregar Ejemplar" Then
            If txtLibro.Text <> "" Then
                If cbxTipoEjemplar.Text <> "" Then
                    If cbxPlazoPrestamo.Text <> "" Then
                        moduloBiblioteca.altaEjemplar()
                        Me.txtLibro.Clear()
                        Me.txtNumeroEjemplar.Clear()
                        Me.cbxTipoEjemplar.Text = ""
                        Me.cbxPlazoPrestamo.Text = ""
                        Me.cbxPlazoPrestamo.SelectedIndex = -1
                        Me.cbxTipoEjemplar.SelectedIndex = -1
                    Else
                        MsgBox("Debe seleccionar un plazo prestamo para el libro", MsgBoxStyle.Information, "Agregar ejemplar")
                        Me.cbxPlazoPrestamo.Focus()
                        Me.cbxPlazoPrestamo.BackColor = Color.Red
                    End If
                Else
                    MsgBox("Debe seleccionar el tipo de ejemplar del libro", MsgBoxStyle.Information, "Agregar ejemplar")
                    Me.cbxTipoEjemplar.Focus()
                    Me.cbxTipoEjemplar.BackColor = Color.Red
                End If
            Else
                MsgBox("Debe seleccioanr un libro de la grilla de la derecha", MsgBoxStyle.Information, "Agregar ejemplar")
                txtLibro.Focus()
                txtLibro.BackColor = Color.Red
            End If
        Else
            If txtLibro.Text <> "" Then
                If cbxTipoEjemplar.Text <> "" Then
                    If cbxPlazoPrestamo.Text <> "" Then
                        Me.GuardarEjemplarModificado(Ejemplares.COD_EJEMPLAR_MODIFICAR)
                        moduloBiblioteca.mostrarEjemplares()
                        Me.txtLibro.Clear()
                        Me.cbxTipoEjemplar.Text = ""
                        Me.cbxPlazoPrestamo.Text = ""
                        Me.cbxPlazoPrestamo.SelectedIndex = -1
                        Me.cbxTipoEjemplar.SelectedIndex = -1
                        Me.Close()
                    Else
                        MsgBox("Debe seleccionar un plazo prestamo para el libro", MsgBoxStyle.Information, "Agregar ejemplar")
                        Me.cbxPlazoPrestamo.Focus()
                        Me.cbxPlazoPrestamo.BackColor = Color.Red
                    End If
                Else
                    MsgBox("Debe seleccionar el tipo de ejemplar del libro", MsgBoxStyle.Information, "Agregar ejemplar")
                    Me.cbxTipoEjemplar.Focus()
                    Me.cbxTipoEjemplar.BackColor = Color.Red
                End If
            Else
                MsgBox("Debe seleccioanr un libro de la grilla de la derecha", MsgBoxStyle.Information, "Agregar ejemplar")
                txtLibro.Focus()
                txtLibro.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarLibro.ShowDialog()
    End Sub

    Private Sub txtNumeroEjemplar_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroEjemplar.TextChanged

    End Sub

    Private Function buscarUltimoNumeroEjemplar(cod_libro) As Integer
        Dim Sql As String = "SELECT numero_ejemplar FROM ejemplar WHERE cod_libro = '" & cod_libro & "' ORDER BY numero_ejemplar DESC LIMIT 1"
        Dim numero_ejemplar As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    Dim VARIABLE_QUE_CONTENDRA_EL_VALOR As Integer = Trim(Datos("numero_ejemplar"))

                    'Vemos que contiene la variable asignada para la direccion URL extraida
                    'MessageBox.Show(VARIABLE_QUE_CONTENDRA_EL_VALOR)

                    'Imprimimos en el cuadro de texto la direccion URL
                    numero_ejemplar = VARIABLE_QUE_CONTENDRA_EL_VALOR

                    Return numero_ejemplar
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AgregarPlazoPrestamo.Show()
    End Sub

    Private Sub txtLibro_TextChanged(sender As Object, e As EventArgs) Handles txtLibro.TextChanged

    End Sub

    Private Sub txtLibro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLibro.KeyPress
        Me.BackColor = Color.White
    End Sub

    Private Sub cbxTipoEjemplar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxTipoEjemplar.SelectedIndexChanged

    End Sub

    Private Sub cbxTipoEjemplar_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxTipoEjemplar.SelectedValueChanged
        Me.BackColor = Color.White
    End Sub

    Private Sub cbxEstado_SelectedValueChanged(sender As Object, e As EventArgs)
        Me.BackColor = Color.White
    End Sub

    Private Sub cbxPlazoPrestamo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxPlazoPrestamo.SelectedIndexChanged

    End Sub

    Private Sub cbxPlazoPrestamo_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxPlazoPrestamo.SelectedValueChanged
        Me.BackColor = Color.White
    End Sub

    Private Sub cbxTipoEjemplar_Click(sender As Object, e As EventArgs) Handles cbxTipoEjemplar.Click
        Me.BackColor = Color.White
    End Sub

    Private Sub cbxTipoEjemplar_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cbxTipoEjemplar.SelectionChangeCommitted
        Me.BackColor = Color.White
    End Sub

    Private Sub cbxTipoEjemplar_TextChanged(sender As Object, e As EventArgs) Handles cbxTipoEjemplar.TextChanged
        Me.BackColor = Color.White
    End Sub

    Private Sub cbxTipoEjemplar_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxTipoEjemplar.MouseClick
        cbxTipoEjemplar.BackColor = Color.White
    End Sub

    Private Sub cbxPlazoPrestamo_MouseClick(sender As Object, e As MouseEventArgs) Handles cbxPlazoPrestamo.MouseClick
        cbxPlazoPrestamo.BackColor = Color.White
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtBuscarlibro.Clear()
        Me.txtLibro.Clear()
        Me.cbxPlazoPrestamo.SelectedIndex = -1
        Me.cbxTipoEjemplar.SelectedIndex = -1
        Me.txtNumeroEjemplar.Text = ""
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.txtBuscarlibro.Clear()
        Me.txtLibro.Clear()
        Me.cbxPlazoPrestamo.Text = ""
        Me.cbxTipoEjemplar.Text = ""
        Me.txtNumeroEjemplar.Text = ""
        Me.Close()
    End Sub

    Public Sub GuardarEjemplarModificado(cod_ejemplar As Integer)
        Dim LOC_consulta As String
        Try

            If ConexionMySQL() Then
                LOC_consulta = "UPDATE ejemplar SET cod_tipo_ejemplar = " & Me.cbxTipoEjemplar.SelectedValue & ", cod_plazo_prestamo = " & Me.cbxPlazoPrestamo.SelectedValue & "
                                WHERE `ejemplar`.`cod_ejemplar` = " & cod_ejemplar & ""
                Glocomando.CommandText = LOC_consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glodatareader = Glocomando.ExecuteReader
                Glodatareader.Close()
                MsgBox("Se Modificó ejemplar Correctamente")
                GloconexionDB.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            GloconexionDB.Close()
        End Try

    End Sub

End Class