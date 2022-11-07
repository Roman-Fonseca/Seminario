Public Class SeleccionAutor

    Private Sub SeleccionAutor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.llenarGrilla(dgvAutor)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombreAutor.TextChanged
        moduloBiblioteca.busquedaDinamicaAutor(txtNombreAutor.Text, dgvAutor)
    End Sub

    Private Sub dgvAutor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAutor.CellContentClick

    End Sub

    Private Sub brnCancelar_Click(sender As Object, e As EventArgs) Handles brnCancelar.Click
        GLO_CodSocioModificar = 0
        Me.Close()

    End Sub

    Private Sub btnSeleccionarAutor_Click(sender As Object, e As EventArgs) Handles btnSeleccionarAutor.Click
        GLO_CodAutor = Me.dgvAutor.SelectedRows.Item(0).Cells(0).Value
        GLO_ApellidoAutor = Me.dgvAutor.SelectedRows.Item(0).Cells(1).Value
        GLO_NombreAutor = Me.dgvAutor.SelectedRows.Item(0).Cells(3).Value
        Me.Close()
        AgregarLibro.txtAutor.Text = GLO_NombreAutor.ToString + " " + GLO_ApellidoAutor.ToString
    End Sub
End Class