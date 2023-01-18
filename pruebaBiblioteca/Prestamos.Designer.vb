<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Prestamos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.dgvPrestamos = New System.Windows.Forms.DataGridView()
        Me.gpbPrestamo = New System.Windows.Forms.GroupBox()
        Me.btnPrestamosVencidosDevueltos = New System.Windows.Forms.Button()
        Me.btnPrestamosVencidos = New System.Windows.Forms.Button()
        Me.lblFiltrar = New System.Windows.Forms.Label()
        Me.btnTodosLosPrestamos = New System.Windows.Forms.Button()
        Me.btnFinalizarPrestamo = New System.Windows.Forms.Button()
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPrestamo.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(564, 408)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(74, 34)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(644, 408)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(74, 34)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(727, 408)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 34)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'dgvPrestamos
        '
        Me.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrestamos.Location = New System.Drawing.Point(18, 73)
        Me.dgvPrestamos.Name = "dgvPrestamos"
        Me.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrestamos.Size = New System.Drawing.Size(731, 254)
        Me.dgvPrestamos.TabIndex = 1
        '
        'gpbPrestamo
        '
        Me.gpbPrestamo.Controls.Add(Me.btnPrestamosVencidosDevueltos)
        Me.gpbPrestamo.Controls.Add(Me.btnPrestamosVencidos)
        Me.gpbPrestamo.Controls.Add(Me.lblFiltrar)
        Me.gpbPrestamo.Controls.Add(Me.btnTodosLosPrestamos)
        Me.gpbPrestamo.Controls.Add(Me.dgvPrestamos)
        Me.gpbPrestamo.Location = New System.Drawing.Point(22, 22)
        Me.gpbPrestamo.Name = "gpbPrestamo"
        Me.gpbPrestamo.Size = New System.Drawing.Size(777, 349)
        Me.gpbPrestamo.TabIndex = 4
        Me.gpbPrestamo.TabStop = False
        Me.gpbPrestamo.Text = "Prestamos"
        '
        'btnPrestamosVencidosDevueltos
        '
        Me.btnPrestamosVencidosDevueltos.Location = New System.Drawing.Point(428, 37)
        Me.btnPrestamosVencidosDevueltos.Name = "btnPrestamosVencidosDevueltos"
        Me.btnPrestamosVencidosDevueltos.Size = New System.Drawing.Size(190, 31)
        Me.btnPrestamosVencidosDevueltos.TabIndex = 8
        Me.btnPrestamosVencidosDevueltos.Text = "Prestamos vencidos devueltos"
        Me.btnPrestamosVencidosDevueltos.UseVisualStyleBackColor = True
        '
        'btnPrestamosVencidos
        '
        Me.btnPrestamosVencidos.Location = New System.Drawing.Point(208, 37)
        Me.btnPrestamosVencidos.Name = "btnPrestamosVencidos"
        Me.btnPrestamosVencidos.Size = New System.Drawing.Size(214, 31)
        Me.btnPrestamosVencidos.TabIndex = 7
        Me.btnPrestamosVencidos.Text = "Prestamos Vencidos NO Devueltos"
        Me.btnPrestamosVencidos.UseVisualStyleBackColor = True
        '
        'lblFiltrar
        '
        Me.lblFiltrar.AutoSize = True
        Me.lblFiltrar.Location = New System.Drawing.Point(15, 46)
        Me.lblFiltrar.Name = "lblFiltrar"
        Me.lblFiltrar.Size = New System.Drawing.Size(35, 13)
        Me.lblFiltrar.TabIndex = 2
        Me.lblFiltrar.Text = "Filtrar:"
        '
        'btnTodosLosPrestamos
        '
        Me.btnTodosLosPrestamos.Location = New System.Drawing.Point(56, 37)
        Me.btnTodosLosPrestamos.Name = "btnTodosLosPrestamos"
        Me.btnTodosLosPrestamos.Size = New System.Drawing.Size(146, 31)
        Me.btnTodosLosPrestamos.TabIndex = 6
        Me.btnTodosLosPrestamos.Text = "Todos los prestamos"
        Me.btnTodosLosPrestamos.UseVisualStyleBackColor = True
        '
        'btnFinalizarPrestamo
        '
        Me.btnFinalizarPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFinalizarPrestamo.Location = New System.Drawing.Point(450, 408)
        Me.btnFinalizarPrestamo.Name = "btnFinalizarPrestamo"
        Me.btnFinalizarPrestamo.Size = New System.Drawing.Size(74, 34)
        Me.btnFinalizarPrestamo.TabIndex = 5
        Me.btnFinalizarPrestamo.Text = "Finalizar prestamo"
        Me.btnFinalizarPrestamo.UseVisualStyleBackColor = False
        '
        'Prestamos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 454)
        Me.Controls.Add(Me.btnFinalizarPrestamo)
        Me.Controls.Add(Me.gpbPrestamo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Name = "Prestamos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Prestamos"
        CType(Me.dgvPrestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPrestamo.ResumeLayout(False)
        Me.gpbPrestamo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents dgvPrestamos As DataGridView
    Friend WithEvents gpbPrestamo As GroupBox
    Friend WithEvents btnTodosLosPrestamos As Button
    Friend WithEvents btnPrestamosVencidos As Button
    Friend WithEvents lblFiltrar As Label
    Friend WithEvents btnPrestamosVencidosDevueltos As Button
    Friend WithEvents btnFinalizarPrestamo As Button
End Class
