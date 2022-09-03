<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarCategoria
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
        Me.lblNombreCategoria = New System.Windows.Forms.Label()
        Me.txtNombreCategoria = New System.Windows.Forms.TextBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnCargarCategoria = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblNombreCategoria
        '
        Me.lblNombreCategoria.AutoSize = True
        Me.lblNombreCategoria.Location = New System.Drawing.Point(12, 31)
        Me.lblNombreCategoria.Name = "lblNombreCategoria"
        Me.lblNombreCategoria.Size = New System.Drawing.Size(95, 13)
        Me.lblNombreCategoria.TabIndex = 0
        Me.lblNombreCategoria.Text = "Nombre Categoria:"
        '
        'txtNombreCategoria
        '
        Me.txtNombreCategoria.Location = New System.Drawing.Point(119, 28)
        Me.txtNombreCategoria.Name = "txtNombreCategoria"
        Me.txtNombreCategoria.Size = New System.Drawing.Size(100, 20)
        Me.txtNombreCategoria.TabIndex = 1
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(302, 136)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(60, 32)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnCargarCategoria
        '
        Me.btnCargarCategoria.Location = New System.Drawing.Point(226, 136)
        Me.btnCargarCategoria.Name = "btnCargarCategoria"
        Me.btnCargarCategoria.Size = New System.Drawing.Size(60, 32)
        Me.btnCargarCategoria.TabIndex = 9
        Me.btnCargarCategoria.Text = "Guardar"
        Me.btnCargarCategoria.UseVisualStyleBackColor = True
        '
        'AgregarCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 180)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnCargarCategoria)
        Me.Controls.Add(Me.txtNombreCategoria)
        Me.Controls.Add(Me.lblNombreCategoria)
        Me.Name = "AgregarCategoria"
        Me.Text = "AgregarCategoria"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNombreCategoria As Label
    Friend WithEvents txtNombreCategoria As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnCargarCategoria As Button
End Class
