Public Class PlazoPrestamo
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnVolver.Click

    End Sub

    Private Sub PlazoPrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarPlazosPrestamos()
    End Sub

    Public Sub mostrarPlazosPrestamos()
        Dim Consulta As String = "SELECT * FROM plazo_prestamo"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Me.dgvPlazoPrestamo.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cod_plazo_prestamo As Integer = Me.dgvPlazoPrestamo.SelectedRows.Item(0).Cells(0).Value
        EliminarPlazoPrestamo(cod_plazo_prestamo)
        mostrarPlazosPrestamos()
    End Sub

    Public Sub EliminarPlazoPrestamo(cod_plazo_prestamo As Integer)
        Dim loc_consulta As String
        Dim a As Integer
        Try
            a = MsgBox("¿ Está seguro de eliminar el plazo_prestamo cod_plazo_prestamo: " & cod_plazo_prestamo & " ?", MsgBoxStyle.YesNo, "Biblioteca LA")
            If a = MsgBoxResult.Yes Then
                loc_consulta = "DELETE FROM plazo_prestamo WHERE cod_plazo_prestamo = " & cod_plazo_prestamo
                If ConexionMySQL() Then
                    EjecutarTransaccionBaja(loc_consulta)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click

    End Sub
End Class