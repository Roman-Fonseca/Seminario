<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnSocios = New System.Windows.Forms.Button()
        Me.btnLibros = New System.Windows.Forms.Button()
        Me.btnEjemplares = New System.Windows.Forms.Button()
        Me.btnPrestamos = New System.Windows.Forms.Button()
        Me.btnPlazoPrestamo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpFechaDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(585, 12)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(203, 81)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnSocios
        '
        Me.btnSocios.Location = New System.Drawing.Point(65, 12)
        Me.btnSocios.Name = "btnSocios"
        Me.btnSocios.Size = New System.Drawing.Size(203, 81)
        Me.btnSocios.TabIndex = 2
        Me.btnSocios.Text = "Socios"
        Me.btnSocios.UseVisualStyleBackColor = True
        '
        'btnLibros
        '
        Me.btnLibros.Location = New System.Drawing.Point(65, 123)
        Me.btnLibros.Name = "btnLibros"
        Me.btnLibros.Size = New System.Drawing.Size(203, 81)
        Me.btnLibros.TabIndex = 3
        Me.btnLibros.Text = "Libros"
        Me.btnLibros.UseVisualStyleBackColor = True
        '
        'btnEjemplares
        '
        Me.btnEjemplares.Location = New System.Drawing.Point(65, 221)
        Me.btnEjemplares.Name = "btnEjemplares"
        Me.btnEjemplares.Size = New System.Drawing.Size(203, 81)
        Me.btnEjemplares.TabIndex = 4
        Me.btnEjemplares.Text = "Ejemplares"
        Me.btnEjemplares.UseVisualStyleBackColor = True
        '
        'btnPrestamos
        '
        Me.btnPrestamos.Location = New System.Drawing.Point(65, 322)
        Me.btnPrestamos.Name = "btnPrestamos"
        Me.btnPrestamos.Size = New System.Drawing.Size(203, 81)
        Me.btnPrestamos.TabIndex = 5
        Me.btnPrestamos.Text = "Prestamos"
        Me.btnPrestamos.UseVisualStyleBackColor = True
        '
        'btnPlazoPrestamo
        '
        Me.btnPlazoPrestamo.Location = New System.Drawing.Point(585, 123)
        Me.btnPlazoPrestamo.Name = "btnPlazoPrestamo"
        Me.btnPlazoPrestamo.Size = New System.Drawing.Size(83, 47)
        Me.btnPlazoPrestamo.TabIndex = 6
        Me.btnPlazoPrestamo.Text = "Plazo Prestamo"
        Me.btnPlazoPrestamo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(585, 221)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 47)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Probar Hora y fecha"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpFechaDevolucion
        '
        Me.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDevolucion.Location = New System.Drawing.Point(585, 301)
        Me.dtpFechaDevolucion.Name = "dtpFechaDevolucion"
        Me.dtpFechaDevolucion.Size = New System.Drawing.Size(134, 20)
        Me.dtpFechaDevolucion.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpFechaDevolucion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPlazoPrestamo)
        Me.Controls.Add(Me.btnPrestamos)
        Me.Controls.Add(Me.btnEjemplares)
        Me.Controls.Add(Me.btnLibros)
        Me.Controls.Add(Me.btnSocios)
        Me.Controls.Add(Me.btnConectar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents btnSocios As Button
    Friend WithEvents btnLibros As Button
    Friend WithEvents btnEjemplares As Button
    Friend WithEvents btnPrestamos As Button
    Friend WithEvents btnPlazoPrestamo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpFechaDevolucion As DateTimePicker
End Class
