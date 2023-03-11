Public Class TiempoMembresia

    Public GLO_COD_TIEMPO_MEMBRESIA As Integer
    Private Sub TiempoMembresia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarTiempoMembresia()
    End Sub

    Public Sub mostrarTiempoMembresia()
        Dim Consulta As String = "SELECT * FROM tiempo_membresia"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Me.dgvTiempoMembresia.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        AgregarTiempoMembresia.Text = "Modificar Tiempo Membresía"
        AgregarTiempoMembresia.GroupBox1.Text = "Modificar Tiempo"
        ConsultarTiempoModificar()
        AgregarTiempoMembresia.ShowDialog()
    End Sub

    Public Sub ConsultarTiempoModificar()

        GLO_COD_TIEMPO_MEMBRESIA = Me.dgvTiempoMembresia.SelectedRows.Item(0).Cells(0).Value
        Dim Consulta As String = "SELECT descripcion,dias FROM tiempo_membresia WHERE cod_tiempo_membresia= " & GLO_COD_TIEMPO_MEMBRESIA

        If conexion.ConexionMySQL() Then
            Glocomando.CommandText = Consulta
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader

            Dim dt As New DataTable
            dt.Load(Glodatareader)
            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)
            Try
                AgregarTiempoMembresia.txtDescripcion.Text = Trim((CStr(row("descripcion"))))
                AgregarTiempoMembresia.txtDias.Text = Trim((CStr(row("dias"))))

                Glodatareader.Close()
                GloconexionDB.Close()
            Catch ex As Exception
                GloconexionDB.Close()

            End Try
        End If
    End Sub
End Class