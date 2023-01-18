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
        Me.Label1.Location = New System.Drawing.Point(49, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ISBN:"
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Location = New System.Drawing.Point(49, 145)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(36, 13)
        Me.lblTitulo.TabIndex = 2
        Me.lblTitulo.Text = "Titulo:"
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(93, 142)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(156, 20)
        Me.txtTitulo.TabIndex = 3
        '
        'lblUbicacion
        '
        Me.lblUbicacion.AutoSize = True
        Me.lblUbicacion.Location = New System.Drawing.Point(29, 206)
        Me.lblUbicacion.Name = "lblUbicacion"
        Me.lblUbicacion.Size = New System.Drawing.Size(58, 13)
        Me.lblUbicacion.TabIndex = 4
        Me.lblUbicacion.Text = "Ubicación:"
        '
        'lblEditorial
        '
        Me.lblEditorial.AutoSize = True
        Me.lblEditorial.Location = New System.Drawing.Point(38, 257)
        Me.lblEditorial.Name = "lblEditorial"
        Me.lblEditorial.Size = New System.Drawing.Size(47, 13)
        Me.lblEditorial.TabIndex = 5
        Me.lblEditorial.Text = "Editorial:"
        '
        'btnAgregarUbicacion
        '
        Me.btnAgregarUbicacion.Location = New System.Drawing.Point(255, 201)
        Me.btnAgregarUbicacion.Name = "btnAgregarUbicacion"
        Me.btnAgregarUbicacion.Size = New System.Drawing.Size(46, 23)
        Me.btnAgregarUbicacion.TabIndex = 6
        Me.btnAgregarUbicacion.Text = "+"
        Me.btnAgregarUbicacion.UseVisualStyleBackColor = True
        '
        'btnAgregarEditorial
        '
        Me.btnAgregarEditorial.Location = New System.Drawing.Point(255, 252)
        Me.btnAgregarEditorial.Name = "btnAgregarEditorial"
        Me.btnAgregarEditorial.Size = New System.Drawing.Size(46, 23)
        Me.btnAgregarEditorial.TabIndex = 7
        Me.btnAgregarEditorial.Text = "+"
        Me.btnAgregarEditorial.UseVisualStyleBackColor = True
        '
        'cbxUbicacion
        '
        Me.cbxUbicacion.FormattingEnabled = True
        Me.cbxUbicacion.Location = New System.Drawing.Point(93, 203)
        Me.cbxUbicacion.Name = "cbxUbicacion"
        Me.cbxUbicacion.Size = New System.Drawing.Size(156, 21)
        Me.cbxUbicacion.TabIndex = 8
        '
        'cbxEditorial
        '
        Me.cbxEditorial.FormattingEnabled = True
        Me.cbxEditorial.Location = New System.Drawing.Point(93, 252)
        Me.cbxEditorial.Name = "cbxEditorial"
        Me.cbxEditorial.Size = New System.Drawing.Size(156, 21)
        Me.cbxEditorial.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 301)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Categoria:"
        '
        'cbxCategoria
        '
        Me.cbxCategoria.FormattingEnabled = True
        Me.cbxCategoria.Location = New System.Drawing.Point(93, 298)
        Me.cbxCategoria.Name = "cbxCategoria"
        Me.cbxCategoria.Size = New System.Drawing.Size(156, 21)
        Me.cbxCategoria.TabIndex = 11
        '
        'btnAgregarCategoria
        '
        Me.btnAgregarCategoria.Location = New System.Drawing.Point(255, 299)
        Me.btnAgregarCategoria.Name = "btnAgregarCategoria"
        Me.btnAgregarCategoria.Size = New System.Drawing.Size(46, 23)
        Me.btnAgregarCategoria.TabIndex = 12
        Me.btnAgregarCategoria.Text = "+"
        Me.btnAgregarCategoria.UseVisualStyleBackColor = True
        '
        'lblAutor
        '
        Me.lblAutor.AutoSize = True
        Me.lblAutor.Location = New System.Drawing.Point(513, 31)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(35, 13)
        Me.lblAutor.TabIndex = 13
        Me.lblAutor.Text = "Autor:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(713, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "+"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(713, 357)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 18
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnLimpiarCamposAutor
        '
        Me.btnLimpiarCamposAutor.Location = New System.Drawing.Point(620, 357)
        Me.btnLimpiarCamposAutor.Name = "btnLimpiarCamposAutor"
        Me.btnLimpiarCamposAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiarCamposAutor.TabIndex = 17
        Me.btnLimpiarCamposAutor.Text = "Limpiar"
        Me.btnLimpiarCamposAutor.UseVisualStyleBackColor = True
        '
        'btnGuardarAutor
        '
        Me.btnGuardarAutor.Location = New System.Drawing.Point(516, 357)
        Me.btnGuardarAutor.Name = "btnGuardarAutor"
        Me.btnGuardarAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardarAutor.TabIndex = 16
        Me.btnGuardarAutor.Text = "Guardar"
        Me.btnGuardarAutor.UseVisualStyleBackColor = True
        '
        'btnSeleccionarAutor
        '
        Me.btnSeleccionarAutor.Location = New System.Drawing.Point(713, 62)
        Me.btnSeleccionarAutor.Name = "btnSeleccionarAutor"
        Me.btnSeleccionarAutor.Size = New System.Drawing.Size(46, 23)
        Me.btnSeleccionarAutor.TabIndex = 19
        Me.btnSeleccionarAutor.Text = "Lista"
        Me.btnSeleccionarAutor.UseVisualStyleBackColor = True
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(554, 28)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(141, 20)
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
        'AgregarLibro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 387)
        Me.Controls.Add(Me.txtCod_libro)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAutor)
        Me.Controls.Add(Me.btnSeleccionarAutor)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiarCamposAutor)
        Me.Controls.Add(Me.btnGuardarAutor)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblAutor)
        Me.Controls.Add(Me.btnAgregarCategoria)
        Me.Controls.Add(Me.cbxCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbxEditorial)
        Me.Controls.Add(Me.cbxUbicacion)
        Me.Controls.Add(Me.btnAgregarEditorial)
        Me.Controls.Add(Me.btnAgregarUbicacion)
        Me.Controls.Add(Me.lblEditorial)
        Me.Controls.Add(Me.lblUbicacion)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIsbn)
        Me.Name = "AgregarLibro"
        Me.Text = "CargarLibro"
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
End Class
