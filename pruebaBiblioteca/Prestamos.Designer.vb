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
        Me.txtSocioBusqueda = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
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
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(860, 376)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(74, 34)
        Me.btnAgregar.TabIndex = 1
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnModificar.Location = New System.Drawing.Point(940, 376)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(74, 34)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.MistyRose
        Me.btnEliminar.Location = New System.Drawing.Point(1023, 376)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(74, 34)
        Me.btnEliminar.TabIndex = 3
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'dgvPrestamos
        '
        Me.dgvPrestamos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrestamos.Location = New System.Drawing.Point(18, 73)
        Me.dgvPrestamos.Name = "dgvPrestamos"
        Me.dgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPrestamos.Size = New System.Drawing.Size(1031, 254)
        Me.dgvPrestamos.TabIndex = 1
        '
        'gpbPrestamo
        '
        Me.gpbPrestamo.Controls.Add(Me.txtSocioBusqueda)
        Me.gpbPrestamo.Controls.Add(Me.Label1)
        Me.gpbPrestamo.Controls.Add(Me.Button1)
        Me.gpbPrestamo.Controls.Add(Me.btnPrestamosVencidosDevueltos)
        Me.gpbPrestamo.Controls.Add(Me.btnPrestamosVencidos)
        Me.gpbPrestamo.Controls.Add(Me.lblFiltrar)
        Me.gpbPrestamo.Controls.Add(Me.btnTodosLosPrestamos)
        Me.gpbPrestamo.Controls.Add(Me.dgvPrestamos)
        Me.gpbPrestamo.Location = New System.Drawing.Point(22, 22)
        Me.gpbPrestamo.Name = "gpbPrestamo"
        Me.gpbPrestamo.Size = New System.Drawing.Size(1072, 349)
        Me.gpbPrestamo.TabIndex = 4
        Me.gpbPrestamo.TabStop = False
        Me.gpbPrestamo.Text = "Prestamos"
        '
        'txtSocioBusqueda
        '
        Me.txtSocioBusqueda.Location = New System.Drawing.Point(880, 35)
        Me.txtSocioBusqueda.Name = "txtSocioBusqueda"
        Me.txtSocioBusqueda.Size = New System.Drawing.Size(169, 20)
        Me.txtSocioBusqueda.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(827, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 17)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Socio:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(188, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 48)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "En curso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnPrestamosVencidosDevueltos
        '
        Me.btnPrestamosVencidosDevueltos.Location = New System.Drawing.Point(424, 19)
        Me.btnPrestamosVencidosDevueltos.Name = "btnPrestamosVencidosDevueltos"
        Me.btnPrestamosVencidosDevueltos.Size = New System.Drawing.Size(103, 49)
        Me.btnPrestamosVencidosDevueltos.TabIndex = 8
        Me.btnPrestamosVencidosDevueltos.Text = " Vencidos devueltos"
        Me.btnPrestamosVencidosDevueltos.UseVisualStyleBackColor = True
        '
        'btnPrestamosVencidos
        '
        Me.btnPrestamosVencidos.Location = New System.Drawing.Point(311, 19)
        Me.btnPrestamosVencidos.Name = "btnPrestamosVencidos"
        Me.btnPrestamosVencidos.Size = New System.Drawing.Size(107, 49)
        Me.btnPrestamosVencidos.TabIndex = 7
        Me.btnPrestamosVencidos.Text = "Vencidos NO Devueltos"
        Me.btnPrestamosVencidos.UseVisualStyleBackColor = True
        '
        'lblFiltrar
        '
        Me.lblFiltrar.AutoSize = True
        Me.lblFiltrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFiltrar.Location = New System.Drawing.Point(6, 44)
        Me.lblFiltrar.Name = "lblFiltrar"
        Me.lblFiltrar.Size = New System.Drawing.Size(48, 17)
        Me.lblFiltrar.TabIndex = 2
        Me.lblFiltrar.Text = "Filtrar:"
        '
        'btnTodosLosPrestamos
        '
        Me.btnTodosLosPrestamos.Location = New System.Drawing.Point(56, 19)
        Me.btnTodosLosPrestamos.Name = "btnTodosLosPrestamos"
        Me.btnTodosLosPrestamos.Size = New System.Drawing.Size(117, 49)
        Me.btnTodosLosPrestamos.TabIndex = 6
        Me.btnTodosLosPrestamos.Text = "Todos los prestamos"
        Me.btnTodosLosPrestamos.UseVisualStyleBackColor = True
        '
        'btnFinalizarPrestamo
        '
        Me.btnFinalizarPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFinalizarPrestamo.Location = New System.Drawing.Point(746, 376)
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
        Me.ClientSize = New System.Drawing.Size(1106, 422)
        Me.Controls.Add(Me.btnFinalizarPrestamo)
        Me.Controls.Add(Me.gpbPrestamo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSocioBusqueda As TextBox
End Class
