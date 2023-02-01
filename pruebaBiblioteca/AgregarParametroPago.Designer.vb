<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarParametroPago
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
        Me.lblPagoCorrespondiente = New System.Windows.Forms.Label()
        Me.txtMinimo = New System.Windows.Forms.TextBox()
        Me.txtMaximo = New System.Windows.Forms.TextBox()
        Me.txtPagoCorrespondiente = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombreParametro
        '
        Me.lblNombreParametro.AutoSize = True
        Me.lblNombreParametro.Location = New System.Drawing.Point(53, 50)
        Me.lblNombreParametro.Name = "lblNombreParametro"
        Me.lblNombreParametro.Size = New System.Drawing.Size(0, 13)
        Me.lblNombreParametro.TabIndex = 0
        '
        'lblMinimo
        '
        Me.lblMinimo.AutoSize = True
        Me.lblMinimo.Location = New System.Drawing.Point(87, 46)
        Me.lblMinimo.Name = "lblMinimo"
        Me.lblMinimo.Size = New System.Drawing.Size(43, 13)
        Me.lblMinimo.TabIndex = 1
        Me.lblMinimo.Text = "Minimo:"
        '
        'lblMaximo
        '
        Me.lblMaximo.AutoSize = True
        Me.lblMaximo.Location = New System.Drawing.Point(84, 92)
        Me.lblMaximo.Name = "lblMaximo"
        Me.lblMaximo.Size = New System.Drawing.Size(46, 13)
        Me.lblMaximo.TabIndex = 2
        Me.lblMaximo.Text = "Maximo:"
        '
        'lblPagoCorrespondiente
        '
        Me.lblPagoCorrespondiente.AutoSize = True
        Me.lblPagoCorrespondiente.Location = New System.Drawing.Point(15, 131)
        Me.lblPagoCorrespondiente.Name = "lblPagoCorrespondiente"
        Me.lblPagoCorrespondiente.Size = New System.Drawing.Size(115, 13)
        Me.lblPagoCorrespondiente.TabIndex = 3
        Me.lblPagoCorrespondiente.Text = "Pago Correspondiente:"
        '
        'txtMinimo
        '
        Me.txtMinimo.Location = New System.Drawing.Point(155, 43)
        Me.txtMinimo.Name = "txtMinimo"
        Me.txtMinimo.Size = New System.Drawing.Size(120, 20)
        Me.txtMinimo.TabIndex = 5
        '
        'txtMaximo
        '
        Me.txtMaximo.Location = New System.Drawing.Point(155, 89)
        Me.txtMaximo.Name = "txtMaximo"
        Me.txtMaximo.Size = New System.Drawing.Size(120, 20)
        Me.txtMaximo.TabIndex = 6
        '
        'txtPagoCorrespondiente
        '
        Me.txtPagoCorrespondiente.Location = New System.Drawing.Point(155, 128)
        Me.txtPagoCorrespondiente.Name = "txtPagoCorrespondiente"
        Me.txtPagoCorrespondiente.Size = New System.Drawing.Size(120, 20)
        Me.txtPagoCorrespondiente.TabIndex = 7
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(10, 210)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 8
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(206, 210)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 9
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(110, 210)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AgregarParametroPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 250)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.txtPagoCorrespondiente)
        Me.Controls.Add(Me.txtMaximo)
        Me.Controls.Add(Me.txtMinimo)
        Me.Controls.Add(Me.lblPagoCorrespondiente)
        Me.Controls.Add(Me.lblMaximo)
        Me.Controls.Add(Me.lblMinimo)
        Me.Controls.Add(Me.lblNombreParametro)
        Me.Name = "AgregarParametroPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Parametro Pago"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreParametro As Label
    Friend WithEvents lblMinimo As Label
    Friend WithEvents lblMaximo As Label
    Friend WithEvents lblPagoCorrespondiente As Label
    Friend WithEvents txtMinimo As TextBox
    Friend WithEvents txtMaximo As TextBox
    Friend WithEvents txtPagoCorrespondiente As TextBox
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents btnCancelar As Button
End Class
