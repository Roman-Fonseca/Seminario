Public Class AgregarEditorial
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtContactoEditorial.TextChanged

    End Sub

    Private Sub btnLimpiarCamposEditorial_Click(sender As Object, e As EventArgs) Handles btnLimpiarCamposEditorial.Click
        moduloBiblioteca.limpiarCamposAgregarEditorial()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim a As Integer

        a = MsgBox("Desea cancelar carga", MsgBoxStyle.YesNo, "Cargar Editorial")
        If a = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnGuardarEditorial_Click(sender As Object, e As EventArgs) Handles btnGuardarEditorial.Click
        moduloBiblioteca.altaEditorial()
        moduloBiblioteca.limpiarCamposAgregarEditorial()
        Me.Close()
    End Sub
End Class