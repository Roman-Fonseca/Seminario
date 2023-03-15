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
            'moduloBiblioteca.CargarComboCategoria()
        End If
        'moduloBiblioteca.CargarComboCategoria()
        moduloBiblioteca.cargarTablaCategoria()

    End Sub

    Private Sub txtNombreCategoria_TextChanged(sender As Object, e As EventArgs) Handles txtNombreCategoria.TextChanged

    End Sub

    Private Sub txtNombreCategoria_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombreCategoria.KeyPress
        'Permito solamente letras en el textbox
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = True
            MsgBox("Solo se puede ingresar valores de tipo texto", MsgBoxStyle.Exclamation, "Ingreso de Texto")
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = False
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtNombreCategoria.Focus()
        End If
    End Sub

    Private Sub AgregarCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtNombreCategoria.Clear()
    End Sub
End Class