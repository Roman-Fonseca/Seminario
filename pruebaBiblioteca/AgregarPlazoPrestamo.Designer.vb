<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarPlazoPrestamo
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
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblDias = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtDias = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(12, 31)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(66, 13)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion:"
        '
        'lblDias
        '
        Me.lblDias.AutoSize = True
        Me.lblDias.Location = New System.Drawing.Point(210, 31)
        Me.lblDias.Name = "lblDias"
        Me.lblDias.Size = New System.Drawing.Size(33, 13)
        Me.lblDias.TabIndex = 1
        Me.lblDias.Text = "Días:"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(84, 28)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(100, 20)
        Me.txtDescripcion.TabIndex = 2
        '
        'txtDias
        '
        Me.txtDias.Location = New System.Drawing.Point(249, 28)
        Me.txtDias.Name = "txtDias"
        Me.txtDias.Size = New System.Drawing.Size(100, 20)
        Me.txtDias.TabIndex = 3
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(180, 96)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 4
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(274, 96)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 5
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AgregarPlazoPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 156)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtDias)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDias)
        Me.Controls.Add(Me.lblDescripcion)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarPlazoPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Plazo Prestamo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblDescripcion As Label
    Friend WithEvents lblDias As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents txtDias As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnCancelar As Button
End Class
