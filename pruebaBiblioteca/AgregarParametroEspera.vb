Public Class AgregarParametroEspera
    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.limpiarCampos()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If Me.Text = "Agregar parametro espera" Then
            If Me.txtMinimo.Text <> "" Then
                If Me.txtMaximo.Text <> "" Then
                    If Me.txtSancion.Text <> "" Then
                        moduloBiblioteca.cargarParametro()
                        Me.Close()
                    Else
                        MsgBox("Debe cargar los días de sanción")
                        Me.txtSancion.Focus()
                        Me.txtSancion.BackColor = Color.Red
                    End If
                Else
                    MsgBox("Debe cargar la cantidad máxima de días")
                    Me.txtMaximo.Focus()
                    Me.txtMaximo.BackColor = Color.Red
                End If
            Else
                MsgBox("Debe cargar la cantidad mínima de días")
                Me.txtMinimo.Focus()
                Me.txtMinimo.BackColor = Color.Red
            End If
        End If
    End Sub

    Private Sub Cancelar_Click(sender As Object, e As EventArgs) Handles Cancelar.Click
        Me.limpiarCampos()
        Me.Close()
    End Sub

    Private Sub limpiarCampos()
        Me.txtMaximo.Clear()
        Me.txtMinimo.Clear()
        Me.txtSancion.Clear()
    End Sub

    Private Sub lblMaximo_Click(sender As Object, e As EventArgs) Handles lblMaximo.Click

    End Sub

    Private Sub txtMinimo_TextChanged(sender As Object, e As EventArgs) Handles txtMinimo.TextChanged

    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        'Permito solamente números en el textbox
        txtMinimo.BackColor = Color.White
        txtMinimo.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = True  ' Aceptas la introducción de espacios
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtMaximo.Focus()
        End If
    End Sub

    Private Sub txtMaximo_TextChanged(sender As Object, e As EventArgs) Handles txtMaximo.TextChanged

    End Sub

    Private Sub txtMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaximo.KeyPress
        'Permito solamente números en el textbox
        txtMaximo.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = True  ' Aceptas la introducción de espacios
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            txtSancion.Focus()
        End If
    End Sub

    Private Sub txtSancion_TextChanged(sender As Object, e As EventArgs) Handles txtSancion.TextChanged

    End Sub

    Private Sub txtSancion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSancion.KeyPress
        txtSancion.BackColor = Color.White
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar.IsSeparator(e.KeyChar) Then
            e.Handled = True  ' Aceptas la introducción de espacios
        Else
            e.Handled = True
        End If
        'Paso el control al proximo texbox con el botón enter
        If Asc(e.KeyChar) = 13 Then
            btnGuardar.Focus()
        End If
    End Sub

    Private Sub AgregarParametroEspera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtMinimo.Text = ""
        Me.txtMaximo.Text = ""
        Me.txtSancion.Text = ""
        Me.txtMinimo.Focus()
    End Sub
End Class