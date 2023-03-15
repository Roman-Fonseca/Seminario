<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarEjemplar
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
        Me.lblNumeroEjemplar = New System.Windows.Forms.Label()
        Me.txtNumeroEjemplar = New System.Windows.Forms.TextBox()
        Me.lblLibro = New System.Windows.Forms.Label()
        Me.btnAgregarTipoEjemplar = New System.Windows.Forms.Button()
        Me.txtLibro = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.dgvLibros = New System.Windows.Forms.DataGridView()
        Me.lblLibros = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBuscarlibro = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarLibro = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblTipoEjemplar = New System.Windows.Forms.Label()
        Me.lblEstadoEjemplar = New System.Windows.Forms.Label()
        Me.cbxTipoEjemplar = New System.Windows.Forms.ComboBox()
        Me.lblPlazoPrestamo = New System.Windows.Forms.Label()
        Me.cbxPlazoPrestamo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblNumeroEjemplar
        '
        Me.lblNumeroEjemplar.AutoSize = True
        Me.lblNumeroEjemplar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumeroEjemplar.Location = New System.Drawing.Point(33, 44)
        Me.lblNumeroEjemplar.Name = "lblNumeroEjemplar"
        Me.lblNumeroEjemplar.Size = New System.Drawing.Size(128, 18)
        Me.lblNumeroEjemplar.TabIndex = 0
        Me.lblNumeroEjemplar.Text = "Numero Ejemplar:"
        '
        'txtNumeroEjemplar
        '
        Me.txtNumeroEjemplar.Enabled = False
        Me.txtNumeroEjemplar.Location = New System.Drawing.Point(167, 45)
        Me.txtNumeroEjemplar.Name = "txtNumeroEjemplar"
        Me.txtNumeroEjemplar.Size = New System.Drawing.Size(137, 20)
        Me.txtNumeroEjemplar.TabIndex = 1
        '
        'lblLibro
        '
        Me.lblLibro.AutoSize = True
        Me.lblLibro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibro.Location = New System.Drawing.Point(116, 119)
        Me.lblLibro.Name = "lblLibro"
        Me.lblLibro.Size = New System.Drawing.Size(45, 18)
        Me.lblLibro.TabIndex = 2
        Me.lblLibro.Text = "Libro:"
        '
        'btnAgregarTipoEjemplar
        '
        Me.btnAgregarTipoEjemplar.Location = New System.Drawing.Point(310, 181)
        Me.btnAgregarTipoEjemplar.Name = "btnAgregarTipoEjemplar"
        Me.btnAgregarTipoEjemplar.Size = New System.Drawing.Size(42, 23)
        Me.btnAgregarTipoEjemplar.TabIndex = 7
        Me.btnAgregarTipoEjemplar.Text = "+"
        Me.btnAgregarTipoEjemplar.UseVisualStyleBackColor = True
        '
        'txtLibro
        '
        Me.txtLibro.Location = New System.Drawing.Point(167, 120)
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.Size = New System.Drawing.Size(137, 20)
        Me.txtLibro.TabIndex = 8
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(796, 336)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 42)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(715, 336)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 43)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(634, 336)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 43)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dgvLibros
        '
        Me.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibros.Location = New System.Drawing.Point(432, 74)
        Me.dgvLibros.MultiSelect = False
        Me.dgvLibros.Name = "dgvLibros"
        Me.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLibros.Size = New System.Drawing.Size(413, 200)
        Me.dgvLibros.TabIndex = 13
        '
        'lblLibros
        '
        Me.lblLibros.AutoSize = True
        Me.lblLibros.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLibros.Location = New System.Drawing.Point(429, 44)
        Me.lblLibros.Name = "lblLibros"
        Me.lblLibros.Size = New System.Drawing.Size(96, 18)
        Me.lblLibros.TabIndex = 14
        Me.lblLibros.Text = "Buscar Libro:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(310, 120)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBuscarlibro
        '
        Me.txtBuscarlibro.Location = New System.Drawing.Point(531, 44)
        Me.txtBuscarlibro.Name = "txtBuscarlibro"
        Me.txtBuscarlibro.Size = New System.Drawing.Size(137, 20)
        Me.txtBuscarlibro.TabIndex = 16
        '
        'btnSeleccionarLibro
        '
        Me.btnSeleccionarLibro.Location = New System.Drawing.Point(279, 20)
        Me.btnSeleccionarLibro.Name = "btnSeleccionarLibro"
        Me.btnSeleccionarLibro.Size = New System.Drawing.Size(79, 23)
        Me.btnSeleccionarLibro.TabIndex = 17
        Me.btnSeleccionarLibro.Text = "Seleccionar"
        Me.btnSeleccionarLibro.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(310, 251)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(42, 23)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "+"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblTipoEjemplar
        '
        Me.lblTipoEjemplar.AutoSize = True
        Me.lblTipoEjemplar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoEjemplar.Location = New System.Drawing.Point(58, 186)
        Me.lblTipoEjemplar.Name = "lblTipoEjemplar"
        Me.lblTipoEjemplar.Size = New System.Drawing.Size(103, 18)
        Me.lblTipoEjemplar.TabIndex = 3
        Me.lblTipoEjemplar.Text = "Tipo Ejemplar:"
        '
        'lblEstadoEjemplar
        '
        Me.lblEstadoEjemplar.AutoSize = True
        Me.lblEstadoEjemplar.Location = New System.Drawing.Point(80, 231)
        Me.lblEstadoEjemplar.Name = "lblEstadoEjemplar"
        Me.lblEstadoEjemplar.Size = New System.Drawing.Size(0, 13)
        Me.lblEstadoEjemplar.TabIndex = 4
        '
        'cbxTipoEjemplar
        '
        Me.cbxTipoEjemplar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoEjemplar.FormattingEnabled = True
        Me.cbxTipoEjemplar.Location = New System.Drawing.Point(167, 183)
        Me.cbxTipoEjemplar.Name = "cbxTipoEjemplar"
        Me.cbxTipoEjemplar.Size = New System.Drawing.Size(137, 21)
        Me.cbxTipoEjemplar.TabIndex = 5
        '
        'lblPlazoPrestamo
        '
        Me.lblPlazoPrestamo.AutoSize = True
        Me.lblPlazoPrestamo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlazoPrestamo.Location = New System.Drawing.Point(42, 253)
        Me.lblPlazoPrestamo.Name = "lblPlazoPrestamo"
        Me.lblPlazoPrestamo.Size = New System.Drawing.Size(119, 18)
        Me.lblPlazoPrestamo.TabIndex = 18
        Me.lblPlazoPrestamo.Text = "Plazo Prestamo:"
        '
        'cbxPlazoPrestamo
        '
        Me.cbxPlazoPrestamo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxPlazoPrestamo.FormattingEnabled = True
        Me.cbxPlazoPrestamo.Items.AddRange(New Object() {"Sin Prestar", "Prestado"})
        Me.cbxPlazoPrestamo.Location = New System.Drawing.Point(167, 253)
        Me.cbxPlazoPrestamo.Name = "cbxPlazoPrestamo"
        Me.cbxPlazoPrestamo.Size = New System.Drawing.Size(137, 21)
        Me.cbxPlazoPrestamo.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Location = New System.Drawing.Point(12, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 284)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del ejemplar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnSeleccionarLibro)
        Me.GroupBox2.Location = New System.Drawing.Point(412, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(468, 284)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccionar libro"
        '
        'AgregarEjemplar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 391)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cbxPlazoPrestamo)
        Me.Controls.Add(Me.lblPlazoPrestamo)
        Me.Controls.Add(Me.txtBuscarlibro)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblLibros)
        Me.Controls.Add(Me.dgvLibros)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtLibro)
        Me.Controls.Add(Me.btnAgregarTipoEjemplar)
        Me.Controls.Add(Me.cbxTipoEjemplar)
        Me.Controls.Add(Me.lblEstadoEjemplar)
        Me.Controls.Add(Me.lblTipoEjemplar)
        Me.Controls.Add(Me.lblLibro)
        Me.Controls.Add(Me.txtNumeroEjemplar)
        Me.Controls.Add(Me.lblNumeroEjemplar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarEjemplar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Ejemplar"
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumeroEjemplar As Label
    Friend WithEvents txtNumeroEjemplar As TextBox
    Friend WithEvents lblLibro As Label
    Friend WithEvents btnAgregarTipoEjemplar As Button
    Friend WithEvents txtLibro As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents lblLibros As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txtBuscarlibro As TextBox
    Friend WithEvents btnSeleccionarLibro As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents lblTipoEjemplar As Label
    Friend WithEvents lblEstadoEjemplar As Label
    Friend WithEvents cbxTipoEjemplar As ComboBox
    Friend WithEvents lblPlazoPrestamo As Label
    Friend WithEvents cbxPlazoPrestamo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
