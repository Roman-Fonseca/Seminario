Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class FormularioReporteSocios
    Private Sub FormularioReporteSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport
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

        Dim cadenaConexion As String = "Database=pruebabiblioteca; server=localhost; user id=root; convert zero datetime=True"
        Dim consulta As String = "SELECT socio.nombre, socio.apellido, socio.dni, socio.telefono, membresia.fecha_registro,
        membresia.hora_registro, membresia.fecha_vencimiento, socio.direccion from socio INNER JOIN membresia ON socio.cod_socio = membresia.cod_socio 
        WHERE fecha_registro >= '" & fecha_inicio_STR & "' AND fecha_registro <= '" & fecha_final_STR & "' "
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

        Dim report As ReportDataSource = New ReportDataSource("DataSetSociosCargados", sociosDT)

        ReportViewer1.LocalReport.DataSources.Add(report)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs)

    End Sub
End Class