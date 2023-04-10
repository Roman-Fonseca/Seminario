Public Class EjemplaresEliminados
    Private Sub EjemplaresEliminados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarLibrosEliminados()
    End Sub

    Public Sub mostrarLibrosEliminados()
        Dim Consulta As String = "SELECT * FROM ejemplar_eliminado"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Me.dgvLibrosEliminados.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Public Function altaEjemplarElima() As Boolean
        Dim LOC_consulta As String
        'Dim cod_ejemplar As String

        Try
            'Alta ejemplar'
            If ConexionMySQL() Then
                LOC_consulta = "insert into ejemplar(numero_ejemplar,estado,cod_libro,cod_tipo_ejemplar,cod_plazo_prestamo)
                values('" & AgregarEjemplar.txtNumeroEjemplar.Text & "','Disponible',
                 '" & GLO_CodLibro & "','" & AgregarEjemplar.cbxTipoEjemplar.SelectedValue & "',
                 '" & AgregarEjemplar.cbxPlazoPrestamo.SelectedValue & "')"
                'MsgBox(LOC_consulta)
                EjecutarTransaccionAlta(LOC_consulta)
                Return True
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try

        Return False

    End Function

End Class