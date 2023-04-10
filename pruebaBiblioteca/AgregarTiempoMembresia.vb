Imports MySql.Data.MySqlClient

Public Class AgregarTiempoMembresia
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtDias.TextChanged

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDias.KeyPress
        'Permito solamente números en el textbox
        txtDias.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            Me.btnGuardar.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
        'Permito solamente letras en el textbox
        txtDescripcion.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            Me.txtDias.Focus()
        End If
    End Sub

    Public Sub cargarTiempoMembresia(descripcion As String, dias As Integer)
        Dim consulta As String

        Try
            If ConexionMySQL() Then
                consulta = "INSERT INTO tiempo_membresia (descripcion,dias) VALUES ('" & descripcion & "'," & dias & ")"
                'MsgBox(consulta)
                EjecutarTransaccionAlta(consulta)
                MsgBox("Se agregó tiempo_membresía correctamente")
                txtDescripcion.Clear()
                txtDias.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If Me.Text = "Agregar Tiempo Membresia" Then
            If txtDescripcion.Text <> "" And txtDias.Text <> "" Then
                Dim descripcion As String = txtDescripcion.Text
                Dim dias As Integer = txtDias.Text
                If sePuedeCargarTiempo() Then
                    cargarTiempoMembresia(descripcion, dias)
                    TiempoMembresia.mostrarTiempoMembresia()
                    Me.Close()
                Else
                    MsgBox("No se puede cargar otro registro. Solo se puede tener uno")
                End If
            ElseIf txtDescripcion.Text = "" Then
                txtDescripcion.Focus()
                MsgBox("No puede dejar el campo descripción vacío")
                txtDescripcion.BackColor = Color.Red
            Else
                txtDias.Focus()
                MsgBox("Debe cargar la cantidad de días")
                txtDias.BackColor = Color.Red
            End If
        Else
            If txtDescripcion.Text <> "" And txtDias.Text <> "" Then
                Dim descripcion As String = txtDescripcion.Text
                Dim dias As Integer = txtDias.Text
                guardarTiempoModificado()
                TiempoMembresia.mostrarTiempoMembresia()
                Me.Close()
            ElseIf txtDescripcion.Text = "" Then
                txtDescripcion.Focus()
                txtDescripcion.BackColor = Color.Red
                MsgBox("No puede dejar el campo descripción vacío")
            Else
                txtDias.Focus()
                txtDias.BackColor = Color.Red
                MsgBox("Debe cargar la cantidad de días")
            End If
        End If

    End Sub

    Private Sub txtDescripcion_LostFocus(sender As Object, e As EventArgs) Handles txtDescripcion.LostFocus

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        txtDescripcion.Clear()
        txtDias.Clear()
        Me.Close()
    End Sub

    Private Sub AgregarTiempoMembresia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub guardarTiempoModificado()
        Dim consulta As String
        Dim descripcion As String = txtDescripcion.Text
        Dim dias As Integer = txtDias.Text
        Try

            If ConexionMySQL() Then
                consulta = "UPDATE tiempo_membresia SET descripcion = '" & descripcion & "', dias = '" & dias & "' WHERE cod_tiempo_membresia = " & TiempoMembresia.GLO_COD_TIEMPO_MEMBRESIA & ""
                'MsgBox(consulta)
                Glocomando.CommandText = consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glodatareader = Glocomando.ExecuteReader
                Glodatareader.Close()
                MsgBox("Se Modificó Correctamente")
                GloconexionDB.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            GloconexionDB.Close()

        End Try
    End Sub

    Public Function sePuedeCargarTiempo() As Boolean
        Dim Sql As String = "SELECT COUNT(cod_tiempo_membresia) from tiempo_membresia"
        Dim cantidad As Integer
        Dim Conexion As New MySqlConnection(cadena_conexion)
        Dim consulta As New MySqlCommand(Sql, Conexion)
        Try
            If Conexion.State = ConnectionState.Closed Then
                Conexion.Open()
                Dim Datos As MySqlDataReader = consulta.ExecuteReader
                If Datos.Read Then
                    'Declaramos y llenamos
                    cantidad = Trim(Datos("COUNT(cod_tiempo_membresia)"))
                    If cantidad <= 0 Then
                        Return True
                    Else
                        Return False
                    End If
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

End Class