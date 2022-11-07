Public Class AgregarAutor
    Private Sub btnGuardarAutor_Click(sender As Object, e As EventArgs) Handles btnGuardarAutor.Click
        moduloBiblioteca.altaAutor()
        LimpiarCampos.limpiarCamposAgregarAutor()
    End Sub

    Private Sub btnLimpiarCamposAutor_Click(sender As Object, e As EventArgs) Handles btnLimpiarCamposAutor.Click
        LimpiarCampos.limpiarCamposSocio()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim a As Integer

        a = MsgBox("Desea cancelar carga de autor", MsgBoxStyle.YesNo, "Cargar Autor")
        If a = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub txtNombre_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged

    End Sub
End Class