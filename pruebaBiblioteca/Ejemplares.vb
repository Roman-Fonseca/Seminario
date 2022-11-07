Public Class Ejemplares
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarEjemplar_Click(sender As Object, e As EventArgs) Handles btnAgregarEjemplar.Click
        AgregarEjemplar.ShowDialog()
    End Sub

    Private Sub Ejemplares_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.mostrarEjemplares()
    End Sub
End Class