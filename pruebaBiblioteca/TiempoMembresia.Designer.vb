<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiempoMembresia
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
        Me.dgvTiempoMembresia = New System.Windows.Forms.DataGridView()
        Me.lblTituloTiempo = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgvTiempoMembresia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvTiempoMembresia
        '
        Me.dgvTiempoMembresia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTiempoMembresia.Location = New System.Drawing.Point(12, 66)
        Me.dgvTiempoMembresia.Name = "dgvTiempoMembresia"
        Me.dgvTiempoMembresia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTiempoMembresia.Size = New System.Drawing.Size(334, 62)
        Me.dgvTiempoMembresia.TabIndex = 0
        '
        'lblTituloTiempo
        '
        Me.lblTituloTiempo.AutoSize = True
        Me.lblTituloTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTituloTiempo.Location = New System.Drawing.Point(118, 23)
        Me.lblTituloTiempo.Name = "lblTituloTiempo"
        Me.lblTituloTiempo.Size = New System.Drawing.Size(143, 20)
        Me.lblTituloTiempo.TabIndex = 1
        Me.lblTituloTiempo.Text = "Tiempo Membresía"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(271, 158)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TiempoMembresia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 195)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.lblTituloTiempo)
        Me.Controls.Add(Me.dgvTiempoMembresia)
        Me.Name = "TiempoMembresia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tiempo Membresia"
        CType(Me.dgvTiempoMembresia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvTiempoMembresia As DataGridView
    Friend WithEvents lblTituloTiempo As Label
    Friend WithEvents Button2 As Button
End Class
