Public Class Sanciones
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        moduloBiblioteca.mostrarSancionesPago()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblFiltrar.Click

    End Sub

    Private Sub Sanciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        moduloBiblioteca.mostrarSancionesPago()
    End Sub

    Private Sub btnSancionesEspera_Click(sender As Object, e As EventArgs) Handles btnSancionesEspera.Click
        mostrarSancionesEspera()
    End Sub

    Public Sub mostrarSancionesEspera()
        Dim Consulta As String = "SELECT sancion_espera.cod_sancion_espera, socio.nombre, socio.apellido,prestamo_atrasado.dias_sancion, sancion_espera.fecha_inicio, sancion_espera.fecha_finalizacion, prestamo_finalizado.cod_prestamo_finalizado, prestamo_socio.cod_ejemplar from sancion_espera INNER Join prestamo_atrasado on sancion_espera.cod_sancion_espera = prestamo_atrasado.cod_sancion_espera INNER JOIN prestamo_finalizado ON prestamo_atrasado.cod_prestamo_finalizado = prestamo_finalizado.cod_prestamo_finalizado INNER JOIN prestamo_socio ON prestamo_finalizado.cod_prestamo_socio = prestamo_socio.cod_prestamo_socio INNER JOIN socio ON prestamo_socio.cod_socio = socio.cod_socio;"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Me.dgvSanciones.DataSource = dt


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