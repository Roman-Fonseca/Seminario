Imports Microsoft.Reporting.WinForms
Imports MySql.Data.MySqlClient

Public Class FormularioReporteSocios
    Private Sub FormularioReporteSocios_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cadenaConexion As String = "Database=pruebabiblioteca; server=localhost; user id=root; convert zero datetime=True"
        Dim consulta As String = "Select nombre,apellido,dni,fecha_nacimiento,direccion,telefono,contador_prestamo from socio"
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

        Dim report As ReportDataSource = New ReportDataSource("DatSetSocios", sociosDT)

        ReportViewer1.LocalReport.DataSources.Add(report)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load

    End Sub
End Class