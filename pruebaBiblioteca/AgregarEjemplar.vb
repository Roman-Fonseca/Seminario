Public Class AgregarEjemplar
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblTipoEjemplar.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxEstado.SelectedIndexChanged

    End Sub

    Private Sub btnAgregarTipoEjemplar_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoEjemplar.Click
        AgregarTipoEjemplar.ShowDialog()
    End Sub

    Private Sub AgregarEjemplar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.CargarComboTipoEjemplar()
        moduloBiblioteca.llenarGrillaLibros(dgvLibros)
        moduloBiblioteca.CargarComboPlazoPrestamo()
    End Sub

    Private Sub btnSeleccionarLibro_Click(sender As Object, e As EventArgs)
        'SeleccionarLibro.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibros.CellContentClick

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblLibros.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtBuscarlibro.TextChanged
        moduloBiblioteca.busquedaDinamicaLibro(txtBuscarlibro.Text, dgvLibros)
    End Sub

    Private Sub btnSeleccionarLibro_Click_1(sender As Object, e As EventArgs) Handles btnSeleccionarLibro.Click
        GLO_CodLibro = Me.dgvLibros.SelectedRows.Item(0).Cells(0).Value
        GLO_TituloLibro = Me.dgvLibros.SelectedRows.Item(0).Cells(2).Value
        Me.txtLibro.Text = GLO_TituloLibro.ToString
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        moduloBiblioteca.altaEjemplar()
    End Sub
End Class