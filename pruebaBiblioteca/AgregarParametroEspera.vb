Public Class AgregarParametroEspera
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.limpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        moduloBiblioteca.cargarParametro()
        Me.Close()
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.limpiarCampos()
        Me.Close()
    End Sub

    Private Sub limpiarCampos()
        Me.txtMaximo.Clear()
        Me.txtMinimo.Clear()
        Me.txtSancion.Clear()
    End Sub
End Class