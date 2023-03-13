Public Class AgregarParametroPago



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtMinimo.TextChanged

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.limpiarCampos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.Text = "Agregar parametro pago" Then
            If Me.txtMinimo.Text <> "" Then
                If Me.txtMaximo.Text <> "" Then
                    If Me.txtPagoCorrespondiente.Text <> "" Then
                        Me.cargarParametroPago()
                        Parametros.mostrarParametroPago()
                        Me.limpiarCampos()
                        Me.Close()
                    Else
                        MsgBox("Debe cargar el pago correspondiente", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Debe cargar la cantidad máxima de días", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Debe cargar la cantidad minima de días", MsgBoxStyle.Information)
            End If
        Else
            If Me.txtMinimo.Text <> "" Then
                If Me.txtMaximo.Text <> "" Then
                    If Me.txtPagoCorrespondiente.Text <> "" Then
                        Me.cargarParametroPagoModificado(Parametros.COD_PARAMETRO_PAGO_MODIFICAR)
                        Parametros.mostrarParametroPago()
                        Me.limpiarCampos()
                        Me.Close()
                    Else
                        MsgBox("Debe cargar el pago correspondiente", MsgBoxStyle.Information)
                    End If
                Else
                    MsgBox("Debe cargar la cantidad máxima de días", MsgBoxStyle.Information)
                End If
            Else
                MsgBox("Debe cargar la cantidad minima de días", MsgBoxStyle.Information)
            End If
        End If

    End Sub

    Public Sub cargarParametroPago()
        Dim LOC_consulta As String

        Try

            If ConexionMySQL() Then
                LOC_consulta = "insert into parametro_pago (minimo,maximo,pago_correspondiente) values('" & Me.txtMinimo.Text & "','" & Me.txtMaximo.Text & "','" & Me.txtPagoCorrespondiente.Text & "')"
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se agregó parámetro_espera correctamente")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        'Permito solamente números en el textbox
        txtMinimo.BackColor = Color.White
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
            txtMaximo.Focus()
        End If
    End Sub

    Private Sub txtMaximo_TextChanged(sender As Object, e As EventArgs) Handles txtMaximo.TextChanged

    End Sub

    Private Sub txtMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaximo.KeyPress
        'Permito solamente números en el textbox
        txtMinimo.BackColor = Color.White
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
            txtPagoCorrespondiente.Focus()
        End If
    End Sub

    Private Sub txtPagoCorrespondiente_TextChanged(sender As Object, e As EventArgs) Handles txtPagoCorrespondiente.TextChanged

    End Sub

    Private Sub txtPagoCorrespondiente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagoCorrespondiente.KeyPress
        'Permito solamente números en el textbox
        txtPagoCorrespondiente.BackColor = Color.White
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
            btnGuardar.Focus()
        End If
    End Sub

    Public Sub cargarParametroPagoModificado(cod_parametro_pago As Integer)
        Dim LOC_consulta As String
        Try
            If ConexionMySQL() Then
                LOC_consulta = "UPDATE parametro_pago SET minimo= " & Me.txtMinimo.Text & ",maximo = " & Me.txtMaximo.Text & " ,pago_correspondiente= " & Me.txtPagoCorrespondiente.Text & " 
                        WHERE cod_parametro_pago = " & cod_parametro_pago & ""
                MsgBox(LOC_consulta)
                EjecutarTransaccion(LOC_consulta)
                MsgBox("Se modificó parametro pago correctamente")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiarCampos()
        Me.txtMaximo.Clear()
        Me.txtMinimo.Clear()
        Me.txtPagoCorrespondiente.Clear()
    End Sub

End Class