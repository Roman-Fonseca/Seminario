Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class FormularioReportePrestamo
    Private Sub FormularioReportePrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click

        'Capturo  fecha_inicio
        Dim fecha_inicio As Date
        fecha_inicio = Format(Me.dtpFechaInicio.Value, "short date")

        'Convierto fecha_inicio en string 
        Dim fecha_inicio_STR As String
        fecha_inicio_STR = fecha_inicio.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)

        'Capturo  fecha_finalizacion
        Dim fecha_final As Date
        fecha_final = Format(Me.dtpFechaFinal.Value, "short date")

        'Convierto fecha_inicio en string 
        Dim fecha_final_STR As String
        fecha_final_STR = fecha_final.ToString("yyyy/MM/dd", System.Globalization.CultureInfo.InvariantCulture)


        If Me.cbVencido.Checked = True Then
            Dim cadenaConexion As String = "Database=pruebabiblioteca; server=localhost; user id=root; convert zero datetime=True"
            Dim consulta As String = "SELECT socio.nombre, socio.apellido, prestamo_socio.tipo_prestamo, prestamo_socio.fecha_prestamo, 
            prestamo_socio.fecha_devolucion, libro.titulo, plazo_prestamo.dias_plazo from prestamo_socio
            INNER JOIN socio ON prestamo_socio.cod_socio = socio.cod_socio INNER JOIN ejemplar 
            ON prestamo_socio.cod_ejemplar = ejemplar.cod_ejemplar INNER JOIN libro 
            ON ejemplar.cod_libro = libro.cod_libro INNER JOIN plazo_prestamo 
            ON ejemplar.cod_plazo_prestamo = plazo_prestamo.cod_plazo_prestamo WHERE prestamo_socio.cod_prestamo_socio 
            NOT IN (SELECT prestamo_finalizado.cod_prestamo_socio from prestamo_finalizado) AND prestamo_socio.tipo_prestamo='Externo' 
            AND (CURRENT_DATE >= fecha_devolucion AND prestamo_socio.hora_devolucion > CURRENT_TIME) AND prestamo_socio.fecha_devolucion >= '" & fecha_inicio_STR & "' AND prestamo_socio.fecha_prestamo < '" & fecha_final_STR & "';"
            MsgBox(consulta)
            Dim conexion As New MySqlConnection()
            conexion.ConnectionString = cadenaConexion

            Try
                conexion.Open()
                MsgBox("Conectado")
            Catch ex As Exception
                MsgBox("No se pudo conectar")
            End Try

            Dim sociosDA As New MySqlDataAdapter(consulta, conexion)
            Dim sociosDT As New DataTable
            sociosDA.Fill(sociosDT)
            ReportViewer1.LocalReport.DataSources.Clear()
            Dim report As ReportDataSource = New ReportDataSource("DatSetPrestamos", sociosDT)
            ReportViewer1.LocalReport.DataSources.Add(report)
            ReportViewer1.RefreshReport()
        Else
            Dim cadenaConexion As String = "Database=pruebabiblioteca; server=localhost; user id=root; convert zero datetime=True"
            Dim consulta As String = "SELECT socio.nombre, socio.apellido, prestamo_socio.tipo_prestamo, prestamo_socio.fecha_prestamo,
            prestamo_socio.cod_prestamo_socio, prestamo_socio.fecha_devolucion, libro.titulo, plazo_prestamo.dias_plazo from prestamo_socio 
            INNER JOIN socio ON prestamo_socio.cod_socio = socio.cod_socio INNER JOIN ejemplar 
            ON prestamo_socio.cod_ejemplar = ejemplar.cod_ejemplar INNER JOIN libro ON ejemplar.cod_libro = libro.cod_libro 
            INNER JOIN plazo_prestamo ON ejemplar.cod_plazo_prestamo = plazo_prestamo.cod_plazo_prestamo 
            WHERE prestamo_socio.cod_prestamo_socio NOT IN (SELECT prestamo_finalizado.cod_prestamo_socio from prestamo_finalizado) 
            AND prestamo_socio.tipo_prestamo='Externo' AND prestamo_socio.fecha_devolucion >= CURRENT_DATE 
            AND prestamo_socio.hora_devolucion >= CURRENT_TIME;"
            MsgBox(consulta)
            Dim conexion As New MySqlConnection()
            conexion.ConnectionString = cadenaConexion

            Try
                conexion.Open()
                MsgBox("Conectado")
            Catch ex As Exception
                MsgBox("No se pudo conectar")
            End Try

            Dim sociosDA As New MySqlDataAdapter(consulta, conexion)
            Dim sociosDT As New DataTable
            sociosDA.Fill(sociosDT)
            ReportViewer1.LocalReport.DataSources.Clear()
            Dim report As ReportDataSource = New ReportDataSource("DatSetPrestamos", sociosDT)
            ReportViewer1.LocalReport.DataSources.Add(report)
            ReportViewer1.RefreshReport()
        End If

    End Sub
End Class