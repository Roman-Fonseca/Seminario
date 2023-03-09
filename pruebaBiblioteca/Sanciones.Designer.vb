<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sanciones
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
        Me.dgvSanciones = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnSancionesEspera = New System.Windows.Forms.Button()
        Me.lblFiltrar = New System.Windows.Forms.Label()
        CType(Me.dgvSanciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSanciones
        '
        Me.dgvSanciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSanciones.Location = New System.Drawing.Point(23, 52)
        Me.dgvSanciones.Name = "dgvSanciones"
        Me.dgvSanciones.Size = New System.Drawing.Size(974, 232)
        Me.dgvSanciones.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(23, 294)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 41)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 27)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Sanciones Pago"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnSancionesEspera
        '
        Me.btnSancionesEspera.Location = New System.Drawing.Point(214, 19)
        Me.btnSancionesEspera.Name = "btnSancionesEspera"
        Me.btnSancionesEspera.Size = New System.Drawing.Size(113, 27)
        Me.btnSancionesEspera.TabIndex = 3
        Me.btnSancionesEspera.Text = "Sanciones Espera"
        Me.btnSancionesEspera.UseVisualStyleBackColor = True
        '
        'lblFiltrar
        '
        Me.lblFiltrar.AutoSize = True
        Me.lblFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrar.Location = New System.Drawing.Point(24, 21)
        Me.lblFiltrar.Name = "lblFiltrar"
        Me.lblFiltrar.Size = New System.Drawing.Size(53, 20)
        Me.lblFiltrar.TabIndex = 4
        Me.lblFiltrar.Text = "Filtrar:"
        '
        'Sanciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 354)
        Me.Controls.Add(Me.lblFiltrar)
        Me.Controls.Add(Me.btnSancionesEspera)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvSanciones)
        Me.Name = "Sanciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sanciones"
        CType(Me.dgvSanciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvSanciones As DataGridView
    Friend WithEvents btnVolver As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnSancionesEspera As Button
    Friend WithEvents lblFiltrar As Label
End Class
