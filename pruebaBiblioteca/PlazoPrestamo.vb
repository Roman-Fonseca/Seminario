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
End Class