Public Class AgregarCategoria
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim a As Integer

        a = MsgBox("Desea cancelar carga", MsgBoxStyle.YesNo, "Cargar categoria")
        If a = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnCargarCategoria_Click(sender As Object, e As EventArgs) Handles btnCargarCategoria.Click
        If txtNombreCategoria.Text = "" Then
            MsgBox("No Puede dejar el campo Nombre Categoria Vacio")
        Else
            moduloBiblioteca.altaCategoria()
            Me.Close()
            moduloBiblioteca.CargarComboCategoria()
        End If
        moduloBiblioteca.CargarComboCategoria()
    End Sub
End Class