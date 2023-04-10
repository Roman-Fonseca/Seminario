Public Class AgregarTipoEjemplar
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtNombreTipoEjemplar.TextChanged

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAgregarTipoEjemplar_Click(sender As Object, e As EventArgs) Handles btnAgregarTipoEjemplar.Click

        If Me.txtNombreTipoEjemplar.Text <> "" Then
            moduloBiblioteca.altaTipoEjemplar()
            Me.txtNombreTipoEjemplar.Clear()
            Me.Close()
            moduloBiblioteca.CargarComboTipoEjemplar()
        Else
            MsgBox("No puede dejar el campo vacío", MsgBoxStyle.Exclamation)
        End If



    End Sub

    Private Sub AgregarTipoEjemplar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class