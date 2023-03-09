Imports MySql.Data.MySqlClient

Public Class Socios
    Dim dt As New DataTable
    Private Sub btnAgregarSocio_Click(sender As Object, e As EventArgs) Handles btnAgregarSocio.Click
        AgregarSocio.Text = "Agregar Socio"
        AgregarSocio.txtEstado.Hide()
        AgregarSocio.btnLimpiarCampos.Show()
        AgregarSocio.lblEstadoSocio.Hide()
        AgregarSocio.ShowDialog()
    End Sub

    Private Sub btnModificarSocio_Click(sender As Object, e As EventArgs) Handles btnModificarSocio.Click
        GLO_CodSocioModificar = Me.listaSocios.SelectedRows.Item(0).Cells(0).Value
        AgregarSocio.Text = "Modificar Socio"
        AgregarSocio.btnLimpiarCampos.Hide()
        AgregarSocio.txtEstado.Hide()
        AgregarSocio.lblEstadoSocio.Hide()
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

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblNombre.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombre.TextChanged
        busquedaDinamicaSocio(txtNombre.Text, listaSocios)
    End Sub

    Public Sub busquedaDinamicaSocio(ByVal nombre As String, ByVal dgv As DataGridView)
        Try
            adaptador = New MySqlDataAdapter("SELECT * FROM socio WHERE nombre like '" & nombre + "%" & "'", GloconexionDB)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Error con busqueda dinamica", ex.ToString)
        End Try
    End Sub

End Class