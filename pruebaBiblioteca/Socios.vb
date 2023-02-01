Public Class Socios
    Private Sub btnAgregarSocio_Click(sender As Object, e As EventArgs) Handles btnAgregarSocio.Click
        AgregarSocio.Text = "Agregar Socio"
        AgregarSocio.txtEstado.Hide()
        AgregarSocio.lblEstadoSocio.Hide()
        AgregarSocio.ShowDialog()
    End Sub

    Private Sub btnModificarSocio_Click(sender As Object, e As EventArgs) Handles btnModificarSocio.Click
        GLO_CodSocioModificar = Me.listaSocios.SelectedRows.Item(0).Cells(0).Value
        AgregarSocio.Text = "Modificar Socio"
        AgregarSocio.txtEstado.Show()
        AgregarSocio.lblEstadoSocio.Show()
        AgregarSocio.ShowDialog()
    End Sub

    Private Sub btnEliminarSocio_Click(sender As Object, e As EventArgs) Handles btnEliminarSocio.Click
        moduloBiblioteca.EliminarSocio()
        moduloBiblioteca.mostrarSocios()
    End Sub

    Private Sub Socios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub listaSocios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles listaSocios.CellContentClick

    End Sub
End Class