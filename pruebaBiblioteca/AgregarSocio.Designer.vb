<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarSocio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarSocio))
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido = New System.Windows.Forms.Label()
        Me.lblTelefono = New System.Windows.Forms.Label()
        Me.lblDireccion = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.btnAgregarSocio = New System.Windows.Forms.Button()
        Me.btnLimpiarCampos = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.txtDni = New System.Windows.Forms.TextBox()
        Me.lblDni = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblEstadoSocio = New System.Windows.Forms.Label()
        Me.imgSocio = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.imgSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(25, 40)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(62, 15)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre:"
        '
        'lblApellido
        '
        Me.lblApellido.AutoSize = True
        Me.lblApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblApellido.Location = New System.Drawing.Point(18, 93)
        Me.lblApellido.Name = "lblApellido"
        Me.lblApellido.Size = New System.Drawing.Size(63, 15)
        Me.lblApellido.TabIndex = 1
        Me.lblApellido.Text = "Apellido:"
        '
        'lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTelefono.Location = New System.Drawing.Point(12, 201)
        Me.lblTelefono.Name = "lblTelefono"
        Me.lblTelefono.Size = New System.Drawing.Size(67, 15)
        Me.lblTelefono.TabIndex = 2
        Me.lblTelefono.Text = "Telefono:"
        '
        'lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDireccion.Location = New System.Drawing.Point(383, 40)
        Me.lblDireccion.Name = "lblDireccion"
        Me.lblDireccion.Size = New System.Drawing.Size(72, 15)
        Me.lblDireccion.TabIndex = 3
        Me.lblDireccion.Text = "Dirección:"
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(93, 39)
        Me.txtNombre.MaxLength = 30
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(143, 26)
        Me.txtNombre.TabIndex = 5
        '
        'txtApellido
        '
        Me.txtApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido.Location = New System.Drawing.Point(93, 92)
        Me.txtApellido.MaxLength = 30
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(143, 26)
        Me.txtApellido.TabIndex = 6
        '
        'txtTelefono
        '
        Me.txtTelefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.Location = New System.Drawing.Point(93, 196)
        Me.txtTelefono.MaxLength = 11
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(143, 26)
        Me.txtTelefono.TabIndex = 7
        '
        'txtDireccion
        '
        Me.txtDireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.Location = New System.Drawing.Point(461, 39)
        Me.txtDireccion.MaxLength = 35
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(143, 26)
        Me.txtDireccion.TabIndex = 8
        '
        'btnAgregarSocio
        '
        Me.btnAgregarSocio.BackColor = System.Drawing.Color.YellowGreen
        Me.btnAgregarSocio.Location = New System.Drawing.Point(693, 272)
        Me.btnAgregarSocio.Name = "btnAgregarSocio"
        Me.btnAgregarSocio.Size = New System.Drawing.Size(81, 46)
        Me.btnAgregarSocio.TabIndex = 10
        Me.btnAgregarSocio.Text = "Agregar Socio"
        Me.btnAgregarSocio.UseVisualStyleBackColor = False
        '
        'btnLimpiarCampos
        '
        Me.btnLimpiarCampos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnLimpiarCampos.Location = New System.Drawing.Point(591, 272)
        Me.btnLimpiarCampos.Name = "btnLimpiarCampos"
        Me.btnLimpiarCampos.Size = New System.Drawing.Size(81, 46)
        Me.btnLimpiarCampos.TabIndex = 11
        Me.btnLimpiarCampos.Text = "Limpiar Campos"
        Me.btnLimpiarCampos.UseVisualStyleBackColor = False
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(494, 272)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(81, 46)
        Me.btnCancelar.TabIndex = 12
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtpFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.lblFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.lblDni)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.lblApellido)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.txtTelefono)
        Me.GroupBox1.Controls.Add(Me.txtEstado)
        Me.GroupBox1.Controls.Add(Me.lblTelefono)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtDireccion)
        Me.GroupBox1.Controls.Add(Me.lblEstadoSocio)
        Me.GroupBox1.Controls.Add(Me.lblDireccion)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(146, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(628, 237)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos socio"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(461, 100)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(143, 21)
        Me.dtpFechaNacimiento.TabIndex = 13
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.AutoSize = True
        Me.lblFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(356, 100)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(100, 15)
        Me.lblFechaNacimiento.TabIndex = 12
        Me.lblFechaNacimiento.Text = "F_Nacimiento:"
        '
        'txtDni
        '
        Me.txtDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDni.Location = New System.Drawing.Point(93, 145)
        Me.txtDni.MaxLength = 8
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(143, 26)
        Me.txtDni.TabIndex = 11
        '
        'lblDni
        '
        Me.lblDni.AutoSize = True
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(46, 150)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(33, 15)
        Me.lblDni.TabIndex = 10
        Me.lblDni.Text = "Dni:"
        '
        'txtEstado
        '
        Me.txtEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado.Location = New System.Drawing.Point(461, 152)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(143, 26)
        Me.txtEstado.TabIndex = 9
        '
        'lblEstadoSocio
        '
        Me.lblEstadoSocio.AutoSize = True
        Me.lblEstadoSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEstadoSocio.Location = New System.Drawing.Point(401, 153)
        Me.lblEstadoSocio.Name = "lblEstadoSocio"
        Me.lblEstadoSocio.Size = New System.Drawing.Size(55, 15)
        Me.lblEstadoSocio.TabIndex = 4
        Me.lblEstadoSocio.Text = "Estado:"
        '
        'imgSocio
        '
        Me.imgSocio.Image = CType(resources.GetObject("imgSocio.Image"), System.Drawing.Image)
        Me.imgSocio.Location = New System.Drawing.Point(12, 39)
        Me.imgSocio.Name = "imgSocio"
        Me.imgSocio.Size = New System.Drawing.Size(128, 227)
        Me.imgSocio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgSocio.TabIndex = 14
        Me.imgSocio.TabStop = False
        '
        'AgregarSocio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 336)
        Me.Controls.Add(Me.imgSocio)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnLimpiarCampos)
        Me.Controls.Add(Me.btnAgregarSocio)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarSocio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Socio"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.imgSocio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblNombre As Label
    Friend WithEvents lblApellido As Label
    Friend WithEvents lblTelefono As Label
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents btnAgregarSocio As Button
    Friend WithEvents btnLimpiarCampos As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblEstadoSocio As Label
    Friend WithEvents lblFechaNacimiento As Label
    Friend WithEvents txtDni As TextBox
    Friend WithEvents lblDni As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents imgSocio As PictureBox
    Friend WithEvents txtEstado As TextBox
End Class
