<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEditorial
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
        Me.lblNombreEditorial = New System.Windows.Forms.Label()
        Me.lblContactoEditorial = New System.Windows.Forms.Label()
        Me.lblLocalizacionEditorial = New System.Windows.Forms.Label()
        Me.txtNombreEditorial = New System.Windows.Forms.TextBox()
        Me.txtContactoEditorial = New System.Windows.Forms.TextBox()
        Me.txtLocalizacionEditorial = New System.Windows.Forms.TextBox()
        Me.btnGuardarEditorial = New System.Windows.Forms.Button()
        Me.btnLimpiarCamposEditorial = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombreEditorial
        '
        Me.lblNombreEditorial.AutoSize = True
        Me.lblNombreEditorial.Location = New System.Drawing.Point(28, 40)
        Me.lblNombreEditorial.Name = "lblNombreEditorial"
        Me.lblNombreEditorial.Size = New System.Drawing.Size(47, 13)
        Me.lblNombreEditorial.TabIndex = 0
        Me.lblNombreEditorial.Text = "Nombre:"
        '
        'lblContactoEditorial
        '
        Me.lblContactoEditorial.AutoSize = True
        Me.lblContactoEditorial.Location = New System.Drawing.Point(22, 88)
        Me.lblContactoEditorial.Name = "lblContactoEditorial"
        Me.lblContactoEditorial.Size = New System.Drawing.Size(53, 13)
        Me.lblContactoEditorial.TabIndex = 1
        Me.lblContactoEditorial.Text = "Contacto:"
        '
        'lblLocalizacionEditorial
        '
        Me.lblLocalizacionEditorial.AutoSize = True
        Me.lblLocalizacionEditorial.Location = New System.Drawing.Point(6, 135)
        Me.lblLocalizacionEditorial.Name = "lblLocalizacionEditorial"
        Me.lblLocalizacionEditorial.Size = New System.Drawing.Size(69, 13)
        Me.lblLocalizacionEditorial.TabIndex = 2
        Me.lblLocalizacionEditorial.Text = "Localización:"
        '
        'txtNombreEditorial
        '
        Me.txtNombreEditorial.Location = New System.Drawing.Point(80, 37)
        Me.txtNombreEditorial.MaxLength = 25
        Me.txtNombreEditorial.Name = "txtNombreEditorial"
        Me.txtNombreEditorial.Size = New System.Drawing.Size(179, 20)
        Me.txtNombreEditorial.TabIndex = 3
        '
        'txtContactoEditorial
        '
        Me.txtContactoEditorial.Location = New System.Drawing.Point(81, 85)
        Me.txtContactoEditorial.MaxLength = 10
        Me.txtContactoEditorial.Name = "txtContactoEditorial"
        Me.txtContactoEditorial.Size = New System.Drawing.Size(178, 20)
        Me.txtContactoEditorial.TabIndex = 4
        '
        'txtLocalizacionEditorial
        '
        Me.txtLocalizacionEditorial.Location = New System.Drawing.Point(80, 135)
        Me.txtLocalizacionEditorial.MaxLength = 30
        Me.txtLocalizacionEditorial.Name = "txtLocalizacionEditorial"
        Me.txtLocalizacionEditorial.Size = New System.Drawing.Size(179, 20)
        Me.txtLocalizacionEditorial.TabIndex = 5
        '
        'btnGuardarEditorial
        '
        Me.btnGuardarEditorial.Location = New System.Drawing.Point(13, 216)
        Me.btnGuardarEditorial.Name = "btnGuardarEditorial"
        Me.btnGuardarEditorial.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarEditorial.TabIndex = 6
        Me.btnGuardarEditorial.Text = "Guardar"
        Me.btnGuardarEditorial.UseVisualStyleBackColor = True
        '
        'btnLimpiarCamposEditorial
        '
        Me.btnLimpiarCamposEditorial.Location = New System.Drawing.Point(105, 216)
        Me.btnLimpiarCamposEditorial.Name = "btnLimpiarCamposEditorial"
        Me.btnLimpiarCamposEditorial.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarCamposEditorial.TabIndex = 7
        Me.btnLimpiarCamposEditorial.Text = "Limpiar"
        Me.btnLimpiarCamposEditorial.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(196, 216)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AgregarEditorial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiarCamposEditorial)
        Me.Controls.Add(Me.btnGuardarEditorial)
        Me.Controls.Add(Me.txtLocalizacionEditorial)
        Me.Controls.Add(Me.txtContactoEditorial)
        Me.Controls.Add(Me.txtNombreEditorial)
        Me.Controls.Add(Me.lblLocalizacionEditorial)
        Me.Controls.Add(Me.lblContactoEditorial)
        Me.Controls.Add(Me.lblNombreEditorial)
        Me.Name = "AgregarEditorial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarEditorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreEditorial As Label
    Friend WithEvents lblContactoEditorial As Label
    Friend WithEvents lblLocalizacionEditorial As Label
    Friend WithEvents txtNombreEditorial As TextBox
    Friend WithEvents txtContactoEditorial As TextBox
    Friend WithEvents txtLocalizacionEditorial As TextBox
    Friend WithEvents btnGuardarEditorial As Button
    Friend WithEvents btnLimpiarCamposEditorial As Button
    Friend WithEvents btnCancelar As Button
End Class
