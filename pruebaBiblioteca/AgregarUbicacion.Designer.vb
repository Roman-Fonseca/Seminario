<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarUbicacion
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
        Me.lblPiso = New System.Windows.Forms.Label()
        Me.lblSector = New System.Windows.Forms.Label()
        Me.lblEstante = New System.Windows.Forms.Label()
        Me.txtPiso = New System.Windows.Forms.TextBox()
        Me.txtSector = New System.Windows.Forms.TextBox()
        Me.txtEstante = New System.Windows.Forms.TextBox()
        Me.btnCargarUbicacion = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPiso
        '
        Me.lblPiso.AutoSize = True
        Me.lblPiso.Location = New System.Drawing.Point(32, 35)
        Me.lblPiso.Name = "lblPiso"
        Me.lblPiso.Size = New System.Drawing.Size(30, 13)
        Me.lblPiso.TabIndex = 0
        Me.lblPiso.Text = "Piso:"
        '
        'lblSector
        '
        Me.lblSector.AutoSize = True
        Me.lblSector.Location = New System.Drawing.Point(21, 85)
        Me.lblSector.Name = "lblSector"
        Me.lblSector.Size = New System.Drawing.Size(41, 13)
        Me.lblSector.TabIndex = 1
        Me.lblSector.Text = "Sector:"
        '
        'lblEstante
        '
        Me.lblEstante.AutoSize = True
        Me.lblEstante.Location = New System.Drawing.Point(16, 136)
        Me.lblEstante.Name = "lblEstante"
        Me.lblEstante.Size = New System.Drawing.Size(46, 13)
        Me.lblEstante.TabIndex = 2
        Me.lblEstante.Text = "Estante:"
        '
        'txtPiso
        '
        Me.txtPiso.Location = New System.Drawing.Point(68, 32)
        Me.txtPiso.MaxLength = 2
        Me.txtPiso.Name = "txtPiso"
        Me.txtPiso.Size = New System.Drawing.Size(160, 20)
        Me.txtPiso.TabIndex = 3
        '
        'txtSector
        '
        Me.txtSector.Location = New System.Drawing.Point(68, 82)
        Me.txtSector.MaxLength = 5
        Me.txtSector.Name = "txtSector"
        Me.txtSector.Size = New System.Drawing.Size(160, 20)
        Me.txtSector.TabIndex = 4
        '
        'txtEstante
        '
        Me.txtEstante.Location = New System.Drawing.Point(68, 136)
        Me.txtEstante.MaxLength = 5
        Me.txtEstante.Name = "txtEstante"
        Me.txtEstante.Size = New System.Drawing.Size(160, 20)
        Me.txtEstante.TabIndex = 5
        '
        'btnCargarUbicacion
        '
        Me.btnCargarUbicacion.Location = New System.Drawing.Point(179, 196)
        Me.btnCargarUbicacion.Name = "btnCargarUbicacion"
        Me.btnCargarUbicacion.Size = New System.Drawing.Size(60, 32)
        Me.btnCargarUbicacion.TabIndex = 6
        Me.btnCargarUbicacion.Text = "Guardar"
        Me.btnCargarUbicacion.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(95, 196)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(60, 32)
        Me.btnLimpiar.TabIndex = 7
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(12, 196)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 32)
        Me.btnCancelar.TabIndex = 8
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'AgregarUbicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(251, 235)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnCargarUbicacion)
        Me.Controls.Add(Me.txtEstante)
        Me.Controls.Add(Me.txtSector)
        Me.Controls.Add(Me.txtPiso)
        Me.Controls.Add(Me.lblEstante)
        Me.Controls.Add(Me.lblSector)
        Me.Controls.Add(Me.lblPiso)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarUbicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarUbicacion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPiso As Label
    Friend WithEvents lblSector As Label
    Friend WithEvents lblEstante As Label
    Friend WithEvents txtPiso As TextBox
    Friend WithEvents txtSector As TextBox
    Friend WithEvents txtEstante As TextBox
    Friend WithEvents btnCargarUbicacion As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCancelar As Button
End Class
