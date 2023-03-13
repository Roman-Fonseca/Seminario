Public Class Parametros

    Public COD_PARAMETRO_MODIFICAR As Integer
    Private Sub Parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarParametroPago()
    End Sub

    Public Sub mostrarParametroPago()
        Dim Consulta As String = "SELECT minimo, maximo, pago_correspondiente AS pago FROM parametro_pago"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Me.dgvParametro.DataSource = dt


                Glodatareader.Close()
                GloconexionDB.Close()
            Else

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Error en la conexion")
        End Try
    End Sub

    Public Sub mostrarParametroEspera()
        Dim Consulta As String = "SELECT minimo, maximo, dias_sancion FROM parametro_espera"
        Try
            If ConexionMySQL() Then
                Glocomando.CommandText = Consulta
                Glocomando.CommandType = CommandType.Text
                Glocomando.Connection = GloconexionDB

                Glodatareader = Glocomando.ExecuteReader


                Dim dt As New DataTable
                dt.Load(Glodatareader)


                Me.dgvParametro.DataSource = dt


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
        mostrarParametroEspera()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mostrarParametroPago()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEditarParametro.Click
        COD_PARAMETRO_MODIFICAR = Me.dgvParametro.SelectedRows.Item(0).Cells(0).Value
        consultarParametroPagoModificar(COD_PARAMETRO_MODIFICAR)
        AgregarParametroPago.Text = "Modificar Parametro"
        AgregarParametroPago.ShowDialog()
    End Sub

    Public Sub consultarParametroPagoModificar(cod_parametro As Integer)
        Dim Consulta As String = "SELECT * FROM parametro_pago  WHERE cod_parametro_pago = " & cod_parametro & ""

        If conexion.ConexionMySQL() Then
            Glocomando.CommandText = Consulta
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB
            Glodatareader = Glocomando.ExecuteReader

            Dim dt As New DataTable
            dt.Load(Glodatareader)

            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)

            Try
                AgregarParametroPago.txtMinimo.Text = Trim((CStr(row("minimo"))))
                AgregarParametroPago.txtMaximo.Text = Trim((CStr(row("maximo"))))
                AgregarParametroPago.txtPagoCorrespondiente.Text = Trim((CStr(row("pago_correspondiente"))))
                Glodatareader.Close()
                GloconexionDB.Close()
            Catch ex As Exception
                GloconexionDB.Close()

            End Try
        End If
    End Sub

End Class