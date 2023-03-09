Public Class AgregarPlazoPrestamo
    Private Sub AgregarPlazoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        moduloBiblioteca.altaPlazoPrestamo()
        Me.txtDescripcion.Clear()
        Me.txtDias.Clear()
        Me.Close()
        moduloBiblioteca.CargarComboPlazoPrestamo()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDescripcion.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtDias.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblDias.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDescripcion.Click

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dim b As Integer
        b = MsgBox("Desea cancelar carga de plazo prestamo ", MsgBoxStyle.YesNo, "ITEC 3")
        If b = MsgBoxResult.Yes Then
            Me.txtDescripcion.Clear()
            Me.txtDias.Clear()
            Me.Close()
        End If
    End Sub
End Class