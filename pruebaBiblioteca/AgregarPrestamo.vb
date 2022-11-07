Public Class AgregarPrestamo
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub AgregarPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.CargarComboPlazoPrestamo()
        'moduloBiblioteca.CargarComboSocioPrestamo()
        moduloBiblioteca.llenarGrillaEjemplares(dgvEjemplar)
        moduloBiblioteca.llenarGrillaSocios(dgvSocio)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        moduloBiblioteca.busquedaDinamicaSocio(txtBuscarSocio.Text, dgvSocio)
    End Sub

    Private Sub txtBuscarEjemplar_TextChanged(sender As Object, e As EventArgs)
        moduloBiblioteca.busquedaDinamicaEjemplar(txtBuscarEjemplar.Text, dgvEjemplar)
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs)

    End Sub

    Private Sub btnAgregarPrestamo_Click(sender As Object, e As EventArgs)
        moduloBiblioteca.altaPrestamo()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtTipoPrestamo_TextChanged(sender As Object, e As EventArgs) Handles txtTipoPrestamo.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles gbxDatosPrestramos.Enter

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub dgvEjemplar_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEjemplar.CellContentClick

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.txtBuscarEjemplar.Clear()
        Me.txtBuscarSocio.Clear()
        Me.txtHoraDevolucion.Clear()
        Me.txtTipoPrestamo.Clear()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BotonAgregarPrestamo.Click
        If Me.Text = "Agregar Prestamo" Then
            moduloBiblioteca.altaPrestamo()
        Else
            moduloBiblioteca.modificarPrestamo()
        End If
        'If AgregarPrestamo.txt = "Agregar Prestamo" Then

        'End If

        'moduloBiblioteca.altaPrestamo()
        'moduloBiblioteca.altaPrestamo_ejemplar()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles btnAgregarEjemplar.Click
        Dim COD_Ejemplar_agregar_list As Integer
        COD_Ejemplar_agregar_list = Me.dgvEjemplar.SelectedRows.Item(0).Cells(0).Value
        Me.listBoxEjemplares.Items.Insert(0, COD_Ejemplar_agregar_list)
    End Sub

    Private Sub btnEliminarEjemplar_Click(sender As Object, e As EventArgs) Handles btnEliminarEjemplar.Click
        Dim COD_Eliminar_Ejemplar_list As Integer
        COD_Eliminar_Ejemplar_list = Me.listBoxEjemplares.SelectedItem
        MsgBox(COD_Eliminar_Ejemplar_list)
        Me.listBoxEjemplares.Items.Remove(Me.listBoxEjemplares.SelectedItem)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub btnFinalizarPrestamo_Click(sender As Object, e As EventArgs) Handles btnFinalizarPrestamo.Click
        moduloBiblioteca.finalizarPrestamo()
    End Sub
End Class