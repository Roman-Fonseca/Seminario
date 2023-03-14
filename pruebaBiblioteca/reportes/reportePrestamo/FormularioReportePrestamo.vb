Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class FormularioReportePrestamo
    Private Sub FormularioReportePrestamo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cadenaConexion As String = "Database=pruebabiblioteca; server=localhost; user id=root; convert zero datetime=True"
        Dim consulta As String = "SELECT socio.nombre, socio.apellido, prestamo_socio.tipo_prestamo, prestamo_socio.fecha_prestamo, prestamo_socio.fecha_devolucion, libro.titulo, plazo_prestamo.dias_plazo from prestamo_socio INNER JOIN socio ON prestamo_socio.cod_socio = socio.cod_socio INNER JOIN ejemplar ON prestamo_socio.cod_ejemplar = ejemplar.cod_ejemplar INNER JOIN libro ON ejemplar.cod_libro = libro.cod_libro INNER JOIN plazo_prestamo ON ejemplar.cod_plazo_prestamo = plazo_prestamo.cod_plazo_prestamo WHERE prestamo_socio.cod_prestamo_socio NOT IN (SELECT prestamo_finalizado.cod_prestamo_socio from prestamo_finalizado) AND prestamo_socio.tipo_prestamo='Externo' "
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
        '

        '

        Dim report As ReportDataSource = New ReportDataSource("DatSetPrestamos", sociosDT)

        ReportViewer1.LocalReport.DataSources.Add(report)
        ReportViewer1.RefreshReport()
    End Sub
End Class