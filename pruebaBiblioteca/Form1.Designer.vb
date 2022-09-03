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
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
