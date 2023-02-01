Public Class AgregarParametroPago

    Private Sub limpiarCampos()
        Me.txtMinimo.Clear()
        Me.txtMaximo.Clear()
        Me.txtPagoCorrespondiente.Clear()
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtMinimo.TextChanged

    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.limpiarCampos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.limpiarCampos()
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Me.cargarParametroPago()
        Me.Close()
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
End Class