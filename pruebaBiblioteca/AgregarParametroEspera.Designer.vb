<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarParametroEspera
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
        Me.lblNombreParametro = New System.Windows.Forms.Label()
        Me.lblMinimo = New System.Windows.Forms.Label()
        Me.lblMaximo = New System.Windows.Forms.Label()
        Me.lblDiasSancion = New System.Windows.Forms.Label()
        Me.txtNombreParametro = New System.Windows.Forms.TextBox()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.txtSancion = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Cancelar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombreParametro
        '
        Me.lblNombreParametro.AutoSize = True
        Me.lblNombreParametro.Location = New System.Drawing.Point(6, 35)
        Me.lblNombreParametro.Name = "lblNombreParametro"
        Me.lblNombreParametro.Size = New System.Drawing.Size(97, 13)
        Me.lblNombreParametro.TabIndex = 0
        Me.lblNombreParametro.Text = "Nombre parametro:"
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Location = New System.Drawing.Point(57, 80)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(43, 13)
        Me.lblMinimo.TabIndex = 1
        Me.lblMinimo.Text = "Minimo:"
        '
        'lblMaximo
        '
        Me.lblMaximo.AutoSize = True
        Me.lblMaximo.Location = New System.Drawing.Point(57, 130)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(46, 13)
        Me.lblMaximo.TabIndex = 2
        Me.lblMaximo.Text = "Maximo:"
        '
        'lblDiasSancion
        '
        Me.lblDiasSancion.AutoSize = True
        Me.lblDiasSancion.Location = New System.Drawing.Point(27, 175)
        Me.lblDiasSancion.Name = "lblDiasSancion"
        Me.lblDiasSancion.Size = New System.Drawing.Size(76, 13)
        Me.lblDiasSancion.TabIndex = 3
        Me.lblDiasSancion.Text = "Sancion(días):"
        '
        'txtNombreParametro
        '
        Me.txtNombreParametro.Location = New System.Drawing.Point(118, 35)
        Me.txtNombreParametro.Name = "txtNombreParametro"
        Me.txtNombreParametro.Size = New System.Drawing.Size(170, 20)
        Me.txtNombreParametro.TabIndex = 4
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(118, 77)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(170, 20)
        Me.txtMinimo.TabIndex = 5
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(118, 127)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(170, 20)
        Me.txtMaximo.TabIndex = 6
        '
        'txtSancion
        '
        Me.txtSancion.Location = New System.Drawing.Point(118, 172)
        Me.txtSancion.Name = "txtSancion"
        Me.txtSancion.Size = New System.Drawing.Size(170, 20)
        Me.txtSancion.TabIndex = 7
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(27, 255)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Cancelar
        '
        Me.Cancelar.Location = New System.Drawing.Point(118, 255)
        Me.Cancelar.Name = "Cancelar"
        Me.Cancelar.Size = New System.Drawing.Size(75, 23)
        Me.Cancelar.TabIndex = 9
        Me.Cancelar.Text = "Cancelar"
        Me.Cancelar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(213, 255)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'AgregarParametroEspera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(318, 290)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Cancelar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtSancion)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.txtNombreParametro)
        Me.Controls.Add(Me.lblDiasSancion)
        Me.Controls.Add(Me.lblMaximo)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.lblNombreParametro)
        Me.Name = "AgregarParametroEspera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar parametro espera"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreParametro As Label
    Friend WithEvents lblMinimo As Label
    Friend WithEvents lblMaximo As Label
    Friend WithEvents lblDiasSancion As Label
    Friend WithEvents txtNombreParametro As TextBox
    Friend WithEvents txtMinimo As TextBox
    Friend WithEvents txtMaximo As TextBox
    Friend WithEvents txtSancion As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents Cancelar As Button
    Friend WithEvents btnGuardar As Button
End Class
