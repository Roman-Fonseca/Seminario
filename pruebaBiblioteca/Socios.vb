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

    Private Sub btnRenovarMembresia_Click(sender As Object, e As EventArgs) Handles btnRenovarMembresia.Click
        Dim cod_socio As Integer
        Dim cod_membresia As Integer
        Dim fecha_vencimiento As Date = Me.listaSocios.SelectedRows.Item(0).Cells(9).Value
        Dim nombre As String
        Dim a As Integer
        Dim consulta As String
        If fecha_vencimiento >= Today Then
            MsgBox("La membresia aún no vence", MsgBoxStyle.Exclamation)
        Else
            Try
                cod_socio = Me.listaSocios.SelectedRows.Item(0).Cells(0).Value
                nombre = Me.listaSocios.SelectedRows.Item(0).Cells(1).Value
                cod_membresia = Me.listaSocios.SelectedRows.Item(0).Cells(10).Value
                a = MsgBox("¿ Está seguro de renovar la membresía del socio " & cod_socio & " " & nombre & "", MsgBoxStyle.YesNo, "Biblioteca LA")
                If a = MsgBoxResult.Yes Then
                    renovarMembresiaSocio(cod_socio, cod_membresia)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox("No se pudo renovar la membresía del socio")
            End Try
            mostrarSocios()
        End If

    End Sub

    Public Function renovarMembresiaSocio(codSocio As Integer, cod_membresia As Integer) As Boolean
        Dim consulta As String
        Dim fecha_actual As Date = Today
        Dim dias_a_agregar As Integer = AgregarSocio.tomarCantidadDias()
        Dim fecha_vencimiento_STR = DateAdd("d", dias_a_agregar, fecha_actual).ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)
        Try
            If ConexionMySQL() Then
                consulta = "UPDATE membresia SET fecha_vencimiento = '" & fecha_vencimiento_STR & "' WHERE membresia.cod_membresia = " & cod_membresia & " AND cod_socio = " & codSocio & ""
                MsgBox(consulta)
                Glocomando.CommandText = consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB
                Glodatareader = Glocomando.ExecuteReader
                Glodatareader.Close()
                MsgBox("Se renovó membresía Correctamente")
                GloconexionDB.Close()
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            GloconexionDB.Close()
            Return False
        End Try
    End Function





End Class