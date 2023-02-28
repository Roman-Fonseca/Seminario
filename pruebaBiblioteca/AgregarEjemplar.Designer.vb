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
        Me.lblTipoEjemplar = New System.Windows.Forms.Label()
        Me.lblEstadoEjemplar = New System.Windows.Forms.Label()
        Me.cbxTipoEjemplar = New System.Windows.Forms.ComboBox()
        Me.cbxEstado = New System.Windows.Forms.ComboBox()
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
        Me.lblPlazoPrestamo = New System.Windows.Forms.Label()
        Me.cbxPlazoPrestamo = New System.Windows.Forms.ComboBox()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNumeroEjemplar
        '
        Me.lblNumeroEjemplar.AutoSize = True
        Me.lblNumeroEjemplar.Location = New System.Drawing.Point(33, 44)
        Me.lblNumeroEjemplar.Name = "lblNumeroEjemplar"
        Me.lblNumeroEjemplar.Size = New System.Drawing.Size(90, 13)
        Me.lblNumeroEjemplar.TabIndex = 0
        Me.lblNumeroEjemplar.Text = "Numero Ejemplar:"
        '
        'txtNumeroEjemplar
        '
        Me.txtNumeroEjemplar.Enabled = False
        Me.txtNumeroEjemplar.Location = New System.Drawing.Point(138, 41)
        Me.txtNumeroEjemplar.Name = "txtNumeroEjemplar"
        Me.txtNumeroEjemplar.Size = New System.Drawing.Size(137, 20)
        Me.txtNumeroEjemplar.TabIndex = 1
        '
        'lblLibro
        '
        Me.lblLibro.AutoSize = True
        Me.lblLibro.Location = New System.Drawing.Point(90, 95)
        Me.lblLibro.Name = "lblLibro"
        Me.lblLibro.Size = New System.Drawing.Size(33, 13)
        Me.lblLibro.TabIndex = 2
        Me.lblLibro.Text = "Libro:"
        '
        'lblTipoEjemplar
        '
        Me.lblTipoEjemplar.AutoSize = True
        Me.lblTipoEjemplar.Location = New System.Drawing.Point(49, 141)
        Me.lblTipoEjemplar.Name = "lblTipoEjemplar"
        Me.lblTipoEjemplar.Size = New System.Drawing.Size(74, 13)
        Me.lblTipoEjemplar.TabIndex = 3
        Me.lblTipoEjemplar.Text = "Tipo Ejemplar:"
        '
        'lblEstadoEjemplar
        '
        Me.lblEstadoEjemplar.AutoSize = True
        Me.lblEstadoEjemplar.Location = New System.Drawing.Point(80, 197)
        Me.lblEstadoEjemplar.Name = "lblEstadoEjemplar"
        Me.lblEstadoEjemplar.Size = New System.Drawing.Size(43, 13)
        Me.lblEstadoEjemplar.TabIndex = 4
        Me.lblEstadoEjemplar.Text = "Estado:"
        '
        'cbxTipoEjemplar
        '
        Me.cbxTipoEjemplar.FormattingEnabled = True
        Me.cbxTipoEjemplar.Location = New System.Drawing.Point(138, 138)
        Me.cbxTipoEjemplar.Name = "cbxTipoEjemplar"
        Me.cbxTipoEjemplar.Size = New System.Drawing.Size(137, 21)
        Me.cbxTipoEjemplar.TabIndex = 5
        '
        'cbxEstado
        '
        Me.cbxEstado.FormattingEnabled = True
        Me.cbxEstado.Items.AddRange(New Object() {"Disponible", "Prestado"})
        Me.cbxEstado.Location = New System.Drawing.Point(138, 194)
        Me.cbxEstado.Name = "cbxEstado"
        Me.cbxEstado.Size = New System.Drawing.Size(137, 21)
        Me.cbxEstado.TabIndex = 6
        '
        'btnAgregarTipoEjemplar
        '
        Me.btnAgregarTipoEjemplar.Location = New System.Drawing.Point(293, 136)
        Me.btnAgregarTipoEjemplar.Name = "btnAgregarTipoEjemplar"
        Me.btnAgregarTipoEjemplar.Size = New System.Drawing.Size(42, 23)
        Me.btnAgregarTipoEjemplar.TabIndex = 7
        Me.btnAgregarTipoEjemplar.Text = "+"
        Me.btnAgregarTipoEjemplar.UseVisualStyleBackColor = True
        '
        'txtLibro
        '
        Me.txtLibro.Location = New System.Drawing.Point(138, 92)
        Me.txtLibro.Name = "txtLibro"
        Me.txtLibro.Size = New System.Drawing.Size(137, 20)
        Me.txtLibro.TabIndex = 8
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(701, 302)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 10
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(792, 302)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 11
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(885, 302)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'dgvLibros
        '
        Me.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibros.Location = New System.Drawing.Point(432, 44)
        Me.dgvLibros.Name = "dgvLibros"
        Me.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLibros.Size = New System.Drawing.Size(413, 183)
        Me.dgvLibros.TabIndex = 13
        '
        'lblLibros
        '
        Me.lblLibros.AutoSize = True
        Me.lblLibros.Location = New System.Drawing.Point(429, 12)
        Me.lblLibros.Name = "lblLibros"
        Me.lblLibros.Size = New System.Drawing.Size(69, 13)
        Me.lblLibros.TabIndex = 14
        Me.lblLibros.Text = "Buscar Libro:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(293, 90)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(42, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBuscarlibro
        '
        Me.txtBuscarlibro.Location = New System.Drawing.Point(504, 9)
        Me.txtBuscarlibro.Name = "txtBuscarlibro"
        Me.txtBuscarlibro.Size = New System.Drawing.Size(137, 20)
        Me.txtBuscarlibro.TabIndex = 16
        '
        'btnSeleccionarLibro
        '
        Me.btnSeleccionarLibro.Location = New System.Drawing.Point(850, 44)
        Me.btnSeleccionarLibro.Name = "btnSeleccionarLibro"
        Me.btnSeleccionarLibro.Size = New System.Drawing.Size(79, 23)
        Me.btnSeleccionarLibro.TabIndex = 17
        Me.btnSeleccionarLibro.Text = "Seleccionar"
        Me.btnSeleccionarLibro.UseVisualStyleBackColor = True
        '
        'lblPlazoPrestamo
        '
        Me.lblPlazoPrestamo.AutoSize = True
        Me.lblPlazoPrestamo.Location = New System.Drawing.Point(40, 242)
        Me.lblPlazoPrestamo.Name = "lblPlazoPrestamo"
        Me.lblPlazoPrestamo.Size = New System.Drawing.Size(83, 13)
        Me.lblPlazoPrestamo.TabIndex = 18
        Me.lblPlazoPrestamo.Text = "Plazo Prestamo:"
        '
        'cbxPlazoPrestamo
        '
        Me.cbxPlazoPrestamo.FormattingEnabled = True
        Me.cbxPlazoPrestamo.Items.AddRange(New Object() {"Sin Prestar", "Prestado"})
        Me.cbxPlazoPrestamo.Location = New System.Drawing.Point(138, 242)
        Me.cbxPlazoPrestamo.Name = "cbxPlazoPrestamo"
        Me.cbxPlazoPrestamo.Size = New System.Drawing.Size(137, 21)
        Me.cbxPlazoPrestamo.TabIndex = 19
        '
        'AgregarEjemplar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 337)
        Me.Controls.Add(Me.cbxPlazoPrestamo)
        Me.Controls.Add(Me.lblPlazoPrestamo)
        Me.Controls.Add(Me.btnSeleccionarLibro)
        Me.Controls.Add(Me.txtBuscarlibro)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblLibros)
        Me.Controls.Add(Me.dgvLibros)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtLibro)
        Me.Controls.Add(Me.btnAgregarTipoEjemplar)
        Me.Controls.Add(Me.cbxEstado)
        Me.Controls.Add(Me.cbxTipoEjemplar)
        Me.Controls.Add(Me.lblEstadoEjemplar)
        Me.Controls.Add(Me.lblTipoEjemplar)
        Me.Controls.Add(Me.lblLibro)
        Me.Controls.Add(Me.txtNumeroEjemplar)
        Me.Controls.Add(Me.lblNumeroEjemplar)
        Me.Name = "AgregarEjemplar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarEjemplar"
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblNumeroEjemplar As Label
    Friend WithEvents txtNumeroEjemplar As TextBox
    Friend WithEvents lblLibro As Label
    Friend WithEvents lblTipoEjemplar As Label
    Friend WithEvents lblEstadoEjemplar As Label
    Friend WithEvents cbxTipoEjemplar As ComboBox
    Friend WithEvents cbxEstado As ComboBox
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
    Friend WithEvents lblPlazoPrestamo As Label
    Friend WithEvents cbxPlazoPrestamo As ComboBox
End Class
