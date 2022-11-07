Public Class AgregarSocio
    Private Sub AgregarSocio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LimpiarCampos.limpiarCamposSocio()
        If Me.Text = "Modificar Socio" Then

            moduloBiblioteca.ConsultarSocioModificar()
            Me.btnAgregarSocio.Text = "Guardar Cambios"
            If Me.Text = "Agregar Socio" Then

            End If
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarSocio.Click
        GLO_CambiosSocios = 0

        If Me.Text = "Modificar Socio" Then
            moduloBiblioteca.GuardarSocioModificado()
            Me.Close()
            moduloBiblioteca.mostrarSocios()

        ElseIf Me.Text = "Agregar Socio" Then

            moduloBiblioteca.cargarSocio()
            Me.Close()
            moduloBiblioteca.mostrarSocios()

        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLimpiarCampos.Click
        LimpiarCampos.limpiarCamposSocio()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub
End Class