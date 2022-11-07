Public Class AgregarUbicacion
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPiso.Click

    End Sub

    Private Sub btnCargarUbicacion_Click(sender As Object, e As EventArgs) Handles btnCargarUbicacion.Click
        moduloBiblioteca.altaUbicacion()
        Me.Close()
        moduloBiblioteca.CargarComboUbicacion()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        LimpiarCampos.limpiarCamposAgregarUbicacion()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim a As Integer

        a = MsgBox("Desea cancelar carga", MsgBoxStyle.YesNo, "Cargar Ubicacion")
        If a = MsgBoxResult.Yes Then
            Me.Close()
        End If

    End Sub

    Private Sub AgregarUbicacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class