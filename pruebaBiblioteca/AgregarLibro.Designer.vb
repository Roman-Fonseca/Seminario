<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarLibro
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
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.lblUbicacion = New System.Windows.Forms.Label()
        Me.lblEditorial = New System.Windows.Forms.Label()
        Me.btnAgregarUbicacion = New System.Windows.Forms.Button()
        Me.btnAgregarEditorial = New System.Windows.Forms.Button()
        Me.cbxUbicacion = New System.Windows.Forms.ComboBox()
        Me.cbxEditorial = New System.Windows.Forms.ComboBox()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiarCamposAutor = New System.Windows.Forms.Button()
        Me.btnGuardarAutor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCod_libro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarAutor = New System.Windows.Forms.Button()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnAgregarCategoria = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnQuitarCategoria = New System.Windows.Forms.Button()
        Me.botonAgregarCategoria = New System.Windows.Forms.Button()
        Me.listBoxCategoria = New System.Windows.Forms.ListBox()
        Me.txtBuscarCategoria = New System.Windows.Forms.TextBox()
        Me.dgvCategoria = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.quitarAutor = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListBoxAutores = New System.Windows.Forms.ListBox()
        Me.dgvAutores = New System.Windows.Forms.DataGridView()
        Me.btnAgreagrAutor = New System.Windows.Forms.Button()
        Me.txtBuscarAutor = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvAutores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIsbn
        '
        Me.txtIsbn.Location = New System.Drawing.Point(589, 26)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(156, 20)
        Me.txtIsbn.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(527, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ISBN:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(34, 77)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(36, 13)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(81, 74)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(156, 20)
        Me.txtTitulo.TabIndex = 3
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Location = New System.Drawing.Point(20, 129)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(58, 13)
        Me.lblUbicacion.TabIndex = 4
        Me.lblUbicacion.Text = "Ubicación:"
        '
        'lblEditorial
        '
        Me.lblEditorial.AutoSize = True
        Me.lblEditorial.Location = New System.Drawing.Point(515, 77)
        Me.lblEditorial.Name = "lblEditorial"
        Me.lblEditorial.Size = New System.Drawing.Size(47, 13)
        Me.lblEditorial.TabIndex = 5
        Me.lblEditorial.Text = "Editorial:"
        '
        'btnAgregarUbicacion
        '
        Me.btnAgregarUbicacion.Location = New System.Drawing.Point(243, 126)
        Me.btnAgregarUbicacion.Name = "btnAgregarUbicacion"
        Me.btnAgregarUbicacion.Size = New System.Drawing.Size(46, 23)
        Me.btnAgregarUbicacion.TabIndex = 6
        Me.btnAgregarUbicacion.Text = "+"
        Me.btnAgregarUbicacion.UseVisualStyleBackColor = True
        '
        'btnAgregarEditorial
        '
        Me.btnAgregarEditorial.Location = New System.Drawing.Point(749, 71)
        Me.btnAgregarEditorial.Name = "btnAgregarEditorial"
        Me.btnAgregarEditorial.Size = New System.Drawing.Size(46, 23)
        Me.btnAgregarEditorial.TabIndex = 7
        Me.btnAgregarEditorial.Text = "+"
        Me.btnAgregarEditorial.UseVisualStyleBackColor = True
        '
        'cbxUbicacion
        '
        Me.cbxUbicacion.FormattingEnabled = True
        Me.cbxUbicacion.Location = New System.Drawing.Point(81, 126)
        Me.cbxUbicacion.Name = "cbxUbicacion"
        Me.cbxUbicacion.Size = New System.Drawing.Size(156, 21)
        Me.cbxUbicacion.TabIndex = 8
        '
        'cbxEditorial
        '
        Me.cbxEditorial.FormattingEnabled = True
        Me.cbxEditorial.Location = New System.Drawing.Point(589, 73)
        Me.cbxEditorial.Name = "cbxEditorial"
        Me.cbxEditorial.Size = New System.Drawing.Size(156, 21)
        Me.cbxEditorial.TabIndex = 9
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(668, 527)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiarCamposAutor
        '
        Me.btnLimpiarCamposAutor.Location = New System.Drawing.Point(587, 527)
        Me.btnLimpiarCamposAutor.Name = "btnLimpiarCamposAutor"
        Me.btnLimpiarCamposAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarCamposAutor.TabIndex = 17
        Me.btnLimpiarCamposAutor.Text = "Limpiar"
        Me.btnLimpiarCamposAutor.UseVisualStyleBackColor = True
        '
        'btnGuardarAutor
        '
        Me.btnGuardarAutor.Location = New System.Drawing.Point(749, 527)
        Me.btnGuardarAutor.Name = "btnGuardarAutor"
        Me.btnGuardarAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarAutor.TabIndex = 16
        Me.btnGuardarAutor.Text = "Guardar"
        Me.btnGuardarAutor.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 38)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "cod_libro:"
        '
        'txtCod_libro
        '
        Me.txtCod_libro.Enabled = False
        Me.txtCod_libro.Location = New System.Drawing.Point(93, 38)
        Me.txtCod_libro.Name = "txtCod_libro"
        Me.txtCod_libro.Size = New System.Drawing.Size(156, 20)
        Me.txtCod_libro.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblAutor)
        Me.GroupBox1.Controls.Add(Me.txtAutor)
        Me.GroupBox1.Controls.Add(Me.btnSeleccionarAutor)
        Me.GroupBox1.Controls.Add(Me.txtIsbn)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cbxCategoria)
        Me.GroupBox1.Controls.Add(Me.lblTitulo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtTitulo)
        Me.GroupBox1.Controls.Add(Me.btnAgregarEditorial)
        Me.GroupBox1.Controls.Add(Me.cbxEditorial)
        Me.GroupBox1.Controls.Add(Me.lblUbicacion)
        Me.GroupBox1.Controls.Add(Me.cbxUbicacion)
        Me.GroupBox1.Controls.Add(Me.lblEditorial)
        Me.GroupBox1.Controls.Add(Me.btnAgregarUbicacion)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(812, 238)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de libro"
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(35, 160)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(35, 13)
        Me.lblAutor.TabIndex = 13
        Me.lblAutor.Text = "Autor:"
        Me.lblAutor.Visible = False
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(81, 153)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(156, 20)
        Me.txtAutor.TabIndex = 20
        Me.txtAutor.Visible = False
        '
        'btnSeleccionarAutor
        '
        Me.btnSeleccionarAutor.Location = New System.Drawing.Point(243, 151)
        Me.btnSeleccionarAutor.Name = "btnSeleccionarAutor"
        Me.btnSeleccionarAutor.Size = New System.Drawing.Size(46, 23)
        Me.btnSeleccionarAutor.TabIndex = 19
        Me.btnSeleccionarAutor.Text = "Lista"
        Me.btnSeleccionarAutor.UseVisualStyleBackColor = True
        Me.btnSeleccionarAutor.Visible = False
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(81, 185)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(156, 21)
        Me.cbxCategoria.TabIndex = 11
        Me.cbxCategoria.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 185)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Categoria:"
        Me.Label2.Visible = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(319, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 68)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Cargar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(320, 64)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(46, 68)
        Me.btnAgregarCategoria.TabIndex = 12
        Me.btnAgregarCategoria.Text = "Cargar"
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.btnQuitarCategoria)
        Me.GroupBox2.Controls.Add(Me.botonAgregarCategoria)
        Me.GroupBox2.Controls.Add(Me.listBoxCategoria)
        Me.GroupBox2.Controls.Add(Me.btnAgregarCategoria)
        Me.GroupBox2.Controls.Add(Me.txtBuscarCategoria)
        Me.GroupBox2.Controls.Add(Me.dgvCategoria)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 256)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(395, 248)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categoria/s"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Orange
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(104, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(77, 28)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(267, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nombre:"
        '
        'btnQuitarCategoria
        '
        Me.btnQuitarCategoria.BackColor = System.Drawing.Color.Orange
        Me.btnQuitarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitarCategoria.Location = New System.Drawing.Point(104, 147)
        Me.btnQuitarCategoria.Name = "btnQuitarCategoria"
        Me.btnQuitarCategoria.Size = New System.Drawing.Size(77, 28)
        Me.btnQuitarCategoria.TabIndex = 23
        Me.btnQuitarCategoria.Text = "-"
        Me.btnQuitarCategoria.UseVisualStyleBackColor = False
        '
        'botonAgregarCategoria
        '
        Me.botonAgregarCategoria.BackColor = System.Drawing.SystemColors.Highlight
        Me.botonAgregarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.botonAgregarCategoria.Location = New System.Drawing.Point(270, 64)
        Me.botonAgregarCategoria.Name = "botonAgregarCategoria"
        Me.botonAgregarCategoria.Size = New System.Drawing.Size(44, 68)
        Me.botonAgregarCategoria.TabIndex = 21
        Me.botonAgregarCategoria.Text = "+"
        Me.botonAgregarCategoria.UseVisualStyleBackColor = False
        '
        'listBoxCategoria
        '
        Me.listBoxCategoria.FormattingEnabled = True
        Me.listBoxCategoria.Location = New System.Drawing.Point(6, 147)
        Me.listBoxCategoria.Name = "listBoxCategoria"
        Me.listBoxCategoria.Size = New System.Drawing.Size(92, 95)
        Me.listBoxCategoria.TabIndex = 22
        '
        'txtBuscarCategoria
        '
        Me.txtBuscarCategoria.Location = New System.Drawing.Point(270, 38)
        Me.txtBuscarCategoria.Name = "txtBuscarCategoria"
        Me.txtBuscarCategoria.Size = New System.Drawing.Size(102, 20)
        Me.txtBuscarCategoria.TabIndex = 21
        '
        'dgvCategoria
        '
        Me.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategoria.Location = New System.Drawing.Point(6, 19)
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategoria.Size = New System.Drawing.Size(243, 113)
        Me.dgvCategoria.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.quitarAutor)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.ListBoxAutores)
        Me.GroupBox3.Controls.Add(Me.dgvAutores)
        Me.GroupBox3.Controls.Add(Me.btnAgreagrAutor)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.txtBuscarAutor)
        Me.GroupBox3.Location = New System.Drawing.Point(436, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(388, 248)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Autores"
        '
        'quitarAutor
        '
        Me.quitarAutor.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.quitarAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quitarAutor.Location = New System.Drawing.Point(106, 147)
        Me.quitarAutor.Name = "quitarAutor"
        Me.quitarAutor.Size = New System.Drawing.Size(77, 28)
        Me.quitarAutor.TabIndex = 25
        Me.quitarAutor.Text = "-"
        Me.quitarAutor.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(266, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Nombre:"
        '
        'ListBoxAutores
        '
        Me.ListBoxAutores.FormattingEnabled = True
        Me.ListBoxAutores.Location = New System.Drawing.Point(6, 147)
        Me.ListBoxAutores.Name = "ListBoxAutores"
        Me.ListBoxAutores.Size = New System.Drawing.Size(92, 95)
        Me.ListBoxAutores.TabIndex = 24
        '
        'dgvAutores
        '
        Me.dgvAutores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAutores.Location = New System.Drawing.Point(6, 22)
        Me.dgvAutores.Name = "dgvAutores"
        Me.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAutores.Size = New System.Drawing.Size(243, 113)
        Me.dgvAutores.TabIndex = 24
        '
        'btnAgreagrAutor
        '
        Me.btnAgreagrAutor.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnAgreagrAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgreagrAutor.Location = New System.Drawing.Point(269, 64)
        Me.btnAgreagrAutor.Name = "btnAgreagrAutor"
        Me.btnAgreagrAutor.Size = New System.Drawing.Size(44, 68)
        Me.btnAgreagrAutor.TabIndex = 26
        Me.btnAgreagrAutor.Text = "+"
        Me.btnAgreagrAutor.UseVisualStyleBackColor = False
        '
        'txtBuscarAutor
        '
        Me.txtBuscarAutor.Location = New System.Drawing.Point(269, 38)
        Me.txtBuscarAutor.Name = "txtBuscarAutor"
        Me.txtBuscarAutor.Size = New System.Drawing.Size(102, 20)
        Me.txtBuscarAutor.TabIndex = 27
        '
        'AgregarLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(855, 562)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCod_libro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiarCamposAutor)
        Me.Controls.Add(Me.btnGuardarAutor)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AgregarLibro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Libro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvAutores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtIsbn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtTitulo As TextBox
    Friend WithEvents lblUbicacion As Label
    Friend WithEvents lblEditorial As Label
    Friend WithEvents btnAgregarUbicacion As Button
    Friend WithEvents btnAgregarEditorial As Button
    Friend WithEvents cbxUbicacion As ComboBox
    Friend WithEvents cbxEditorial As ComboBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpiarCamposAutor As Button
    Friend WithEvents btnGuardarAutor As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCod_libro As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents botonAgregarCategoria As Button
    Friend WithEvents listBoxCategoria As ListBox
    Friend WithEvents txtBuscarCategoria As TextBox
    Friend WithEvents dgvCategoria As DataGridView
    Friend WithEvents btnQuitarCategoria As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents lblAutor As Label
    Friend WithEvents btnSeleccionarAutor As Button
    Friend WithEvents dgvAutores As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAgreagrAutor As Button
    Friend WithEvents txtBuscarAutor As TextBox
    Friend WithEvents quitarAutor As Button
    Friend WithEvents ListBoxAutores As ListBox
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents Button2 As Button
End Class
