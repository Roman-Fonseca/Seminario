Public Class Libros
    Private Sub Libros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.mostrarLibros()
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        GLO_CodLibro = Me.dgvLibros.SelectedRows.Item(0).Cells(0).Value
        AgregarLibro.Text = "Modificar libro"
        AgregarLibro.ShowDialog()
    End Sub
End Class