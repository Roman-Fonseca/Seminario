Public Class CargarLibro
    Private Sub lblTitulo_Click(sender As Object, e As EventArgs) Handles lblTitulo.Click

    End Sub

    Private Sub lblUbicacion_Click(sender As Object, e As EventArgs) Handles lblUbicacion.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblEditorial.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAgregarUbicacion.Click
        AgregarUbicacion.ShowDialog()
    End Sub

    Private Sub btnAgregarEditorial_Click(sender As Object, e As EventArgs) Handles btnAgregarEditorial.Click
        AgregarEditorial.ShowDialog()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxUbicacion.SelectedIndexChanged

    End Sub

    Private Sub CargarLibro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.CargarComboUbicacion()
        moduloBiblioteca.CargarComboEditorial()
        moduloBiblioteca.CargarComboCategoria()
    End Sub

    Private Sub Label2_Click_1(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
        AgregarCategoria.ShowDialog()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAutor.Click

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        AgregarAutor.ShowDialog()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim a As Integer

        a = MsgBox("Desea cancelar carga", MsgBoxStyle.YesNo, "Cargar libro")
        If a = MsgBoxResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class