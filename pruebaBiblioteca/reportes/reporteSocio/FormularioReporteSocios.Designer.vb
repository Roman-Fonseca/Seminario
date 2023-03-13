<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularioReporteSocios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.dtpFechaFinal)
        Me.Panel1.Controls.Add(Me.dtpFechaInicio)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(860, 101)
        Me.Panel1.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(659, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha final"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(543, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha inicio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(387, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Socios Cargados"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(774, 38)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 2
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dtpFechaFinal.Location = New System.Drawing.Point(651, 37)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(93, 20)
        Me.dtpFechaFinal.TabIndex = 6
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(536, 37)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(93, 20)
        Me.dtpFechaInicio.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Script", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 33)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Biblioteca LA"
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "pruebaBiblioteca.ReportSociosCargados.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 159)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(849, 463)
        Me.ReportViewer1.TabIndex = 6
        '
        'FormularioReporteSocios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(882, 634)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.Name = "FormularioReporteSocios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormularioReporteSocios"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBuscar As Button
    Friend WithEvents dtpFechaFinal As DateTimePicker
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
End Class
