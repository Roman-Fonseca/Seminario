Public Class AgregarSocio
    Private Sub AgregarSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles txtAgregarSocio.Click
        moduloBiblioteca.cargarSocio()
        Me.Close()
        moduloBiblioteca.mostrarSocios()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnCancelar.Click

    End Sub
End Class