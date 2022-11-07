<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarTipoEjemplar
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombreTipoEjemplar = New System.Windows.Forms.TextBox()
        Me.btnAgregarTipoEjemplar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Tipo Ejemplar:"
        '
        'txtNombreTipoEjemplar
        '
        Me.txtNombreTipoEjemplar.Location = New System.Drawing.Point(147, 33)
        Me.txtNombreTipoEjemplar.Name = "txtNombreTipoEjemplar"
        Me.txtNombreTipoEjemplar.Size = New System.Drawing.Size(129, 20)
        Me.txtNombreTipoEjemplar.TabIndex = 1
        '
        'btnAgregarTipoEjemplar
        '
        Me.btnAgregarTipoEjemplar.Location = New System.Drawing.Point(185, 128)
        Me.btnAgregarTipoEjemplar.Name = "btnAgregarTipoEjemplar"
        Me.btnAgregarTipoEjemplar.Size = New System.Drawing.Size(65, 23)
        Me.btnAgregarTipoEjemplar.TabIndex = 2
        Me.btnAgregarTipoEjemplar.Text = "Agregar"
        Me.btnAgregarTipoEjemplar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(275, 128)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(65, 23)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AgregarTipoEjemplar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 163)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAgregarTipoEjemplar)
        Me.Controls.Add(Me.txtNombreTipoEjemplar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarTipoEjemplar"
        Me.Text = "AgregarTipoEjemplar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombreTipoEjemplar As TextBox
    Friend WithEvents btnAgregarTipoEjemplar As Button
    Friend WithEvents btnCancelar As Button
End Class
