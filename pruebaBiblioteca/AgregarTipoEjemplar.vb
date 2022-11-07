Public Class AgregarTipoEjemplar
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombreTipoEjemplar.TextChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarTipoEjemplar_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoEjemplar.Click
        moduloBiblioteca.altaTipoEjemplar()
        Me.Close()
        moduloBiblioteca.CargarComboTipoEjemplar()

    End Sub
End Class