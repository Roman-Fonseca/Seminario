Public Class Parametros

    Public COD_PARAMETRO_PAGO_MODIFICAR As Integer
    Public COD_PARAMETRO_ESPERA_MODIFICAR As Integer
    Dim Entero As Integer = 1
    Private Sub Parametros_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrarParametroPago()
    End Sub

    Public Sub mostrarParametroPago()
        Dim Consulta As String = "SELECT cod_parametro_pago, minimo, maximo, pago_correspondiente AS pago FROM parametro_pago"
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
        Dim Consulta As String = "SELECT cod_parametro_espera, minimo, maximo, dias_sancion FROM parametro_espera"
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
        Entero = 2
        mostrarParametroEspera()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Entero = 1
        mostrarParametroPago()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnEditarParametro.Click
        If Entero = 1 Then
            COD_PARAMETRO_PAGO_MODIFICAR = Me.dgvParametro.SelectedRows.Item(0).Cells(0).Value
            AgregarParametroPago.Text = "Modificar parametro pago"
            consultarParametroPagoModificar(COD_PARAMETRO_PAGO_MODIFICAR)
            AgregarParametroPago.btnGuardar.Text = "Guardar cambios"
            AgregarParametroPago.ShowDialog()
        Else
            COD_PARAMETRO_ESPERA_MODIFICAR = Me.dgvParametro.SelectedRows.Item(0).Cells(0).Value
            AgregarParametroEspera.Text = "Modificar parametro espera"
            consultarParametroEsperaModificar(COD_PARAMETRO_ESPERA_MODIFICAR)
            AgregarParametroEspera.btnGuardar.Text = "Guardar Cambios"
            AgregarParametroEspera.ShowDialog()
        End If

    End Sub



    Public Sub consultarParametroPagoModificar(cod_parametro_pago As Integer)

        Dim Consulta As String = "SELECT minimo, maximo, pago_correspondiente FROM parametro_pago  WHERE cod_parametro_pago = " & cod_parametro_pago & ""
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

    Private Sub dgvParametro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvParametro.CellContentClick

    End Sub

    Public Sub consultarParametroEsperaModificar(cod_parametro_espera As Integer)

        Dim Consulta As String = "SELECT minimo, maximo, dias_sancion FROM parametro_espera  WHERE cod_parametro_espera = " & cod_parametro_espera & ""
        If conexion.ConexionMySQL() Then
            Glocomando.CommandText = Consulta
            Glocomando.CommandType = CommandType.Text
            Glocomando.Connection = GloconexionDB

            Glodatareader = Glocomando.ExecuteReader


            Dim dt As New DataTable
            dt.Load(Glodatareader)


            Dim row As DataRow = dt.Rows(dt.Rows.Count - 1)

            Try
                AgregarParametroEspera.txtMinimo.Text = Trim((CStr(row("minimo"))))
                AgregarParametroEspera.txtMaximo.Text = Trim((CStr(row("maximo"))))
                AgregarParametroEspera.txtSancion.Text = Trim((CStr(row("dias_sancion"))))
                Glodatareader.Close()
                GloconexionDB.Close()
            Catch ex As Exception
                GloconexionDB.Close()

            End Try
        End If
    End Sub
End Class