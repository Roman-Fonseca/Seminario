Public Class Socios
    Private Sub btnAgregarSocio_Click(sender As Object, e As EventArgs) Handles btnAgregarSocio.Click
        AgregarSocio.Text = "Agregar Socio"
        AgregarSocio.ShowDialog()
    End Sub

    Private Sub btnModificarSocio_Click(sender As Object, e As EventArgs) Handles btnModificarSocio.Click
        GLO_CodSocioModificar = Me.listaSocios.SelectedRows.Item(0).Cells(0).Value
        AgregarSocio.Text = "Modificar Socio"
        AgregarSocio.ShowDialog()
    End Sub

    Private Sub btnEliminarSocio_Click(sender As Object, e As EventArgs) Handles btnEliminarSocio.Click
        moduloBiblioteca.EliminarSocio()
        moduloBiblioteca.mostrarSocios()

    End Sub
End Class