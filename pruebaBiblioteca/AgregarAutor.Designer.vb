<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarAutor
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
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiarCamposAutor = New System.Windows.Forms.Button()
        Me.btnGuardarAutor = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(47, 38)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Location = New System.Drawing.Point(47, 88)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(47, 13)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(100, 35)
        Me.txtNombre.MaxLength = 25
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(144, 20)
        Me.txtNombre.TabIndex = 3
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(100, 85)
        Me.txtApellido.MaxLength = 20
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(144, 20)
        Me.txtApellido.TabIndex = 4
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(182, 204)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiarCamposAutor
        '
        Me.btnLimpiarCamposAutor.Location = New System.Drawing.Point(101, 204)
        Me.btnLimpiarCamposAutor.Name = "btnLimpiarCamposAutor"
        Me.btnLimpiarCamposAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarCamposAutor.TabIndex = 10
        Me.btnLimpiarCamposAutor.Text = "Limpiar"
        Me.btnLimpiarCamposAutor.UseVisualStyleBackColor = True
        '
        'btnGuardarAutor
        '
        Me.btnGuardarAutor.Location = New System.Drawing.Point(20, 204)
        Me.btnGuardarAutor.Name = "btnGuardarAutor"
        Me.btnGuardarAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarAutor.TabIndex = 9
        Me.btnGuardarAutor.Text = "Guardar"
        Me.btnGuardarAutor.UseVisualStyleBackColor = True
        '
        'AgregarAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 249)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiarCamposAutor)
        Me.Controls.Add(Me.btnGuardarAutor)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblApellido)
        Me.Controls.Add(Me.lblNombre)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarAutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CargarAutor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpiarCamposAutor As Button
    Friend WithEvents btnGuardarAutor As Button
End Class
