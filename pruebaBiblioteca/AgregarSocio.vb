Imports MySql.Data.MySqlClient

Public Class AgregarSocio
    Private Sub AgregarSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.dtpFechaNacimiento.MaxDate = DateTime.Now.Date.AddDays(0)
        LimpiarCampos.limpiarCamposSocio()
        If Me.Text = "Modificar Socio" Then

            moduloBiblioteca.ConsultarSocioModificar()
            Me.btnAgregarSocio.Text = "Guardar Cambios"
        Else
            If Me.Text = "Agregar Socio" Then

            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarSocio.Click
        GLO_CambiosSocios = 0

        If Me.Text = "Modificar Socio" Then
            moduloBiblioteca.GuardarSocioModificado()
            Me.Close()
            moduloBiblioteca.mostrarSocios()

        ElseIf Me.Text = "Agregar Socio" Then
            If txtNombre.Text <> "" Then
                If txtApellido.Text <> "" Then
                    If txtDni.Text <> "" Then
                        If txtTelefono.Text <> "" Then
                            If txtDireccion.Text <> "" Then
                                moduloBiblioteca.cargarSocio()
                                moduloBiblioteca.cargarMembrecia()
                                Me.Close()
                                moduloBiblioteca.mostrarSocios()
                            Else
                                txtDireccion.Focus()
                                MsgBox("Debe cargar dirección")
                                txtDireccion.BackColor = Color.Red
                            End If
                        Else
                            txtTelefono.Focus()
                            MsgBox("Debe cargar telefono")
                            txtTelefono.BackColor = Color.Red
                        End If
                    Else
                        txtDni.Focus()
                        MsgBox("Debe cargar Dni")
                        txtDni.BackColor = Color.Red
                    End If
                Else
                    txtApellido.Focus()
                    MsgBox("Debe cargar apellido")
                    txtApellido.BackColor = Color.Red
                End If
            Else
                txtNombre.Focus()
                MsgBox("Debe cargar un nombre")
                txtNombre.BackColor = Color.Red
            End If
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        LimpiarCampos.limpiarCamposSocio()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub

    Private Sub txtDni_TextChanged(sender As Object, e As EventArgs) Handles txtDni.TextChanged

    End Sub

    Private Sub txtDni_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDni.KeyPress
        'Permito solamente números en el textbox
        txtDni.BackColor = Color.White
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
            txtTelefono.Focus()
        End If
    End Sub

    Private Sub txtTelefono_TextChanged(sender As Object, e As EventArgs) Handles txtTelefono.TextChanged

    End Sub

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
        'Permito solamente números en el cuadro de texto
        txtTelefono.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtDireccion.Focus()
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'Permito solamente letras en el textbox
        txtNombre.BackColor = Color.White

        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtApellido.Focus()
        End If

    End Sub

    Private Sub txtApellido_TextChanged(sender As Object, e As EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        'Permito solamente letras en el textbox
        txtApellido.BackColor = Color.White
        If Not Char.IsLetter(e.KeyChar) _
                     AndAlso Not Char.IsControl(e.KeyChar) _
                     AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtDni.Focus()
        End If
    End Sub

    Private Sub txtDireccion_TextChanged(sender As Object, e As EventArgs) Handles txtDireccion.TextChanged

    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        'Paso el control al proximo texbox con el botón enter
        txtDireccion.BackColor = Color.White
        If Asc(e.KeyChar) = 13 Then
            txtDireccion.Focus()
        End If
    End Sub

    Public Function tomarCantidadDias() As Integer
        Dim cod_tiempo_membresia As Integer = tomarCodTiempoMembresia()
        Dim Sql As String = "SELECT dias FROM tiempo_membresia WHERE cod_tiempo_membresia =" & cod_tiempo_membresia
        Dim dias As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)

        Dim consulta As New MySqlCommand(Sql, Conexion)

        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'llenamos
                    dias = Trim(Datos("dias"))
                    Return dias
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

    Public Function tomarCodTiempoMembresia() As Integer
        Dim Sql As String = "SELECT MAX(cod_tiempo_membresia) from tiempo_membresia"
        Dim codTiempoMembresia As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    ' llenamos
                    codTiempoMembresia = Trim(Datos("MAX(cod_tiempo_membresia)"))

                    Return codTiempoMembresia
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

    Private Sub dtpFechaNacimiento_ValueChanged(sender As Object, e As EventArgs) Handles dtpFechaNacimiento.ValueChanged

    End Sub
End Class