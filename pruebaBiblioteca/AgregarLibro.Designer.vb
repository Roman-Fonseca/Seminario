<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarLibro
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbxCategoria = New System.Windows.Forms.ComboBox()
        Me.btnAgregarCategoria = New System.Windows.Forms.Button()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnLimpiarCamposAutor = New System.Windows.Forms.Button()
        Me.btnGuardarAutor = New System.Windows.Forms.Button()
        Me.btnSeleccionarAutor = New System.Windows.Forms.Button()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCod_libro = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.listBoxCategoria = New System.Windows.Forms.ListBox()
        Me.btnCategoria = New System.Windows.Forms.Button()
        Me.dgvCategoria = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtIsbn
        '
        Me.txtIsbn.Location = New System.Drawing.Point(93, 85)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(156, 20)
        Me.txtIsbn.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ISBN:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(37, 114)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(36, 13)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(81, 114)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(156, 20)
        Me.txtTitulo.TabIndex = 3
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Location = New System.Drawing.Point(17, 178)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(58, 13)
        Me.lblUbicacion.TabIndex = 4
        Me.lblUbicacion.Text = "Ubicación:"
        '
        'lblEditorial
        '
        Me.lblEditorial.AutoSize = True
        Me.lblEditorial.Location = New System.Drawing.Point(26, 237)
        Me.lblEditorial.Name = "lblEditorial"
        Me.lblEditorial.Size = New System.Drawing.Size(47, 13)
        Me.lblEditorial.TabIndex = 5
        Me.lblEditorial.Text = "Editorial:"
        '
        'btnAgregarUbicacion
        '
        Me.btnAgregarUbicacion.Location = New System.Drawing.Point(243, 175)
        Me.btnAgregarUbicacion.Name = "btnAgregarUbicacion"
        Me.btnAgregarUbicacion.Size = New System.Drawing.Size(46, 23)
        Me.btnAgregarUbicacion.TabIndex = 6
        Me.btnAgregarUbicacion.Text = "+"
        Me.btnAgregarUbicacion.UseVisualStyleBackColor = True
        '
        'btnAgregarEditorial
        '
        Me.btnAgregarEditorial.Location = New System.Drawing.Point(243, 227)
        Me.btnAgregarEditorial.Name = "btnAgregarEditorial"
        Me.btnAgregarEditorial.Size = New System.Drawing.Size(46, 23)
        Me.btnAgregarEditorial.TabIndex = 7
        Me.btnAgregarEditorial.Text = "+"
        Me.btnAgregarEditorial.UseVisualStyleBackColor = True
        '
        'cbxUbicacion
        '
        Me.cbxUbicacion.FormattingEnabled = True
        Me.cbxUbicacion.Location = New System.Drawing.Point(81, 175)
        Me.cbxUbicacion.Name = "cbxUbicacion"
        Me.cbxUbicacion.Size = New System.Drawing.Size(156, 21)
        Me.cbxUbicacion.TabIndex = 8
        '
        'cbxEditorial
        '
        Me.cbxEditorial.FormattingEnabled = True
        Me.cbxEditorial.Location = New System.Drawing.Point(81, 229)
        Me.cbxEditorial.Name = "cbxEditorial"
        Me.cbxEditorial.Size = New System.Drawing.Size(156, 21)
        Me.cbxEditorial.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 293)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Categoria:"
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(81, 293)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(156, 21)
        Me.cbxCategoria.TabIndex = 11
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(243, 293)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(46, 23)
        Me.btnAgregarCategoria.TabIndex = 12
        Me.btnAgregarCategoria.Text = "+"
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(38, 350)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(35, 13)
        Me.lblAutor.TabIndex = 13
        Me.lblAutor.Text = "Autor:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(623, 421)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiarCamposAutor
        '
        Me.btnLimpiarCamposAutor.Location = New System.Drawing.Point(542, 421)
        Me.btnLimpiarCamposAutor.Name = "btnLimpiarCamposAutor"
        Me.btnLimpiarCamposAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarCamposAutor.TabIndex = 17
        Me.btnLimpiarCamposAutor.Text = "Limpiar"
        Me.btnLimpiarCamposAutor.UseVisualStyleBackColor = True
        '
        'btnGuardarAutor
        '
        Me.btnGuardarAutor.Location = New System.Drawing.Point(704, 421)
        Me.btnGuardarAutor.Name = "btnGuardarAutor"
        Me.btnGuardarAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarAutor.TabIndex = 16
        Me.btnGuardarAutor.Text = "Guardar"
        Me.btnGuardarAutor.UseVisualStyleBackColor = True
        '
        'btnSeleccionarAutor
        '
        Me.btnSeleccionarAutor.Location = New System.Drawing.Point(295, 345)
        Me.btnSeleccionarAutor.Name = "btnSeleccionarAutor"
        Me.btnSeleccionarAutor.Size = New System.Drawing.Size(46, 23)
        Me.btnSeleccionarAutor.TabIndex = 19
        Me.btnSeleccionarAutor.Text = "Lista"
        Me.btnSeleccionarAutor.UseVisualStyleBackColor = True
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(81, 347)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(156, 20)
        Me.txtAutor.TabIndex = 20
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
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnAgregarCategoria)
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
        Me.GroupBox1.Size = New System.Drawing.Size(390, 391)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de libro"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.listBoxCategoria)
        Me.GroupBox2.Controls.Add(Me.btnCategoria)
        Me.GroupBox2.Controls.Add(Me.dgvCategoria)
        Me.GroupBox2.Location = New System.Drawing.Point(452, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 391)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categoria/s"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(128, 199)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(57, 26)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "-"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'listBoxCategoria
        '
        Me.listBoxCategoria.FormattingEnabled = True
        Me.listBoxCategoria.Location = New System.Drawing.Point(25, 199)
        Me.listBoxCategoria.Name = "listBoxCategoria"
        Me.listBoxCategoria.Size = New System.Drawing.Size(97, 173)
        Me.listBoxCategoria.TabIndex = 22
        '
        'btnCategoria
        '
        Me.btnCategoria.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCategoria.ForeColor = System.Drawing.Color.White
        Me.btnCategoria.Location = New System.Drawing.Point(274, 25)
        Me.btnCategoria.Name = "btnCategoria"
        Me.btnCategoria.Size = New System.Drawing.Size(37, 152)
        Me.btnCategoria.TabIndex = 21
        Me.btnCategoria.Text = "+"
        Me.btnCategoria.UseVisualStyleBackColor = False
        '
        'dgvCategoria
        '
        Me.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategoria.Location = New System.Drawing.Point(25, 25)
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCategoria.Size = New System.Drawing.Size(243, 150)
        Me.dgvCategoria.TabIndex = 0
        '
        'AgregarLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(825, 456)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCod_libro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiarCamposAutor)
        Me.Controls.Add(Me.btnGuardarAutor)
        Me.Controls.Add(Me.txtIsbn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AgregarLibro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cargar Libro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label2 As Label
    Friend WithEvents cbxCategoria As ComboBox
    Friend WithEvents btnAgregarCategoria As Button
    Friend WithEvents lblAutor As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnLimpiarCamposAutor As Button
    Friend WithEvents btnGuardarAutor As Button
    Friend WithEvents btnSeleccionarAutor As Button
    Friend WithEvents txtAutor As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCod_libro As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvCategoria As DataGridView
    Friend WithEvents Button2 As Button
    Friend WithEvents listBoxCategoria As ListBox
    Friend WithEvents btnCategoria As Button
End Class
