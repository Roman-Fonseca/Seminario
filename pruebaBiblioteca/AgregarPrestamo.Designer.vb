<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarPrestamo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AgregarPrestamo))
        Me.gbxDatosPrestramos = New System.Windows.Forms.GroupBox()
        Me.cbxTipoPrestamo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpFechaDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraDevolucion = New System.Windows.Forms.Label()
        Me.lblFechaDevolucion = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBuscarEjemplar = New System.Windows.Forms.TextBox()
        Me.lblBuscarEjemplar = New System.Windows.Forms.Label()
        Me.dgvEjemplar = New System.Windows.Forms.DataGridView()
        Me.lblLibro = New System.Windows.Forms.Label()
        Me.gpbAgregarSocio = New System.Windows.Forms.GroupBox()
        Me.btnAgregarPrestamo = New System.Windows.Forms.Button()
        Me.txtBuscarSocio = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvSocio = New System.Windows.Forms.DataGridView()
        Me.BotonAgregarPrestamo = New System.Windows.Forms.Button()
        Me.btnCancelarPrestamo = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnFinalizarPrestamo = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.dtpHoraDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.gbxDatosPrestramos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvEjemplar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbAgregarSocio.SuspendLayout()
        CType(Me.dgvSocio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDatosPrestramos
        '
        Me.gbxDatosPrestramos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.gbxDatosPrestramos.Controls.Add(Me.dtpHoraDevolucion)
        Me.gbxDatosPrestramos.Controls.Add(Me.cbxTipoPrestamo)
        Me.gbxDatosPrestramos.Controls.Add(Me.Label4)
        Me.gbxDatosPrestramos.Controls.Add(Me.dtpFechaDevolucion)
        Me.gbxDatosPrestramos.Controls.Add(Me.lblHoraDevolucion)
        Me.gbxDatosPrestramos.Controls.Add(Me.lblFechaDevolucion)
        Me.gbxDatosPrestramos.Controls.Add(Me.Label1)
        Me.gbxDatosPrestramos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbxDatosPrestramos.ForeColor = System.Drawing.Color.Black
        Me.gbxDatosPrestramos.Location = New System.Drawing.Point(292, 29)
        Me.gbxDatosPrestramos.Name = "gbxDatosPrestramos"
        Me.gbxDatosPrestramos.Size = New System.Drawing.Size(306, 211)
        Me.gbxDatosPrestramos.TabIndex = 29
        Me.gbxDatosPrestramos.TabStop = False
        Me.gbxDatosPrestramos.Text = "Datos Prestamo"
        '
        'cbxTipoPrestamo
        '
        Me.cbxTipoPrestamo.FormattingEnabled = True
        Me.cbxTipoPrestamo.Items.AddRange(New Object() {"Local", "Externo"})
        Me.cbxTipoPrestamo.Location = New System.Drawing.Point(135, 52)
        Me.cbxTipoPrestamo.Name = "cbxTipoPrestamo"
        Me.cbxTipoPrestamo.Size = New System.Drawing.Size(131, 24)
        Me.cbxTipoPrestamo.TabIndex = 38
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(37, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 36
        '
        'dtpFechaDevolucion
        '
        Me.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDevolucion.Location = New System.Drawing.Point(135, 111)
        Me.dtpFechaDevolucion.Name = "dtpFechaDevolucion"
        Me.dtpFechaDevolucion.Size = New System.Drawing.Size(131, 22)
        Me.dtpFechaDevolucion.TabIndex = 35
        '
        'lblHoraDevolucion
        '
        Me.lblHoraDevolucion.AutoSize = True
        Me.lblHoraDevolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraDevolucion.Location = New System.Drawing.Point(13, 169)
        Me.lblHoraDevolucion.Name = "lblHoraDevolucion"
        Me.lblHoraDevolucion.Size = New System.Drawing.Size(104, 13)
        Me.lblHoraDevolucion.TabIndex = 34
        Me.lblHoraDevolucion.Text = "Hora devolución:"
        '
        'lblFechaDevolucion
        '
        Me.lblFechaDevolucion.AutoSize = True
        Me.lblFechaDevolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFechaDevolucion.Location = New System.Drawing.Point(6, 111)
        Me.lblFechaDevolucion.Name = "lblFechaDevolucion"
        Me.lblFechaDevolucion.Size = New System.Drawing.Size(112, 13)
        Me.lblFechaDevolucion.TabIndex = 33
        Me.lblFechaDevolucion.Text = "Fecha devolución:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Tipo Prestamo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.txtBuscarEjemplar)
        Me.GroupBox1.Controls.Add(Me.lblBuscarEjemplar)
        Me.GroupBox1.Controls.Add(Me.dgvEjemplar)
        Me.GroupBox1.Controls.Add(Me.lblLibro)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(623, 29)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 211)
        Me.GroupBox1.TabIndex = 30
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccionar ejemplar"
        '
        'txtBuscarEjemplar
        '
        Me.txtBuscarEjemplar.Location = New System.Drawing.Point(130, 32)
        Me.txtBuscarEjemplar.Name = "txtBuscarEjemplar"
        Me.txtBuscarEjemplar.Size = New System.Drawing.Size(131, 22)
        Me.txtBuscarEjemplar.TabIndex = 21
        '
        'lblBuscarEjemplar
        '
        Me.lblBuscarEjemplar.AutoSize = True
        Me.lblBuscarEjemplar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBuscarEjemplar.Location = New System.Drawing.Point(23, 34)
        Me.lblBuscarEjemplar.Name = "lblBuscarEjemplar"
        Me.lblBuscarEjemplar.Size = New System.Drawing.Size(101, 13)
        Me.lblBuscarEjemplar.TabIndex = 20
        Me.lblBuscarEjemplar.Text = "Buscar ejemplar:"
        '
        'dgvEjemplar
        '
        Me.dgvEjemplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEjemplar.Location = New System.Drawing.Point(26, 60)
        Me.dgvEjemplar.Name = "dgvEjemplar"
        Me.dgvEjemplar.ReadOnly = True
        Me.dgvEjemplar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEjemplar.Size = New System.Drawing.Size(372, 119)
        Me.dgvEjemplar.TabIndex = 19
        '
        'lblLibro
        '
        Me.lblLibro.AutoSize = True
        Me.lblLibro.Location = New System.Drawing.Point(79, 44)
        Me.lblLibro.Name = "lblLibro"
        Me.lblLibro.Size = New System.Drawing.Size(0, 16)
        Me.lblLibro.TabIndex = 18
        '
        'gpbAgregarSocio
        '
        Me.gpbAgregarSocio.Controls.Add(Me.btnAgregarPrestamo)
        Me.gpbAgregarSocio.Controls.Add(Me.txtBuscarSocio)
        Me.gpbAgregarSocio.Controls.Add(Me.Label3)
        Me.gpbAgregarSocio.Controls.Add(Me.dgvSocio)
        Me.gpbAgregarSocio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gpbAgregarSocio.Location = New System.Drawing.Point(292, 246)
        Me.gpbAgregarSocio.Name = "gpbAgregarSocio"
        Me.gpbAgregarSocio.Size = New System.Drawing.Size(744, 188)
        Me.gpbAgregarSocio.TabIndex = 31
        Me.gpbAgregarSocio.TabStop = False
        Me.gpbAgregarSocio.Text = "Seleccionar Socio"
        '
        'btnAgregarPrestamo
        '
        Me.btnAgregarPrestamo.Location = New System.Drawing.Point(231, 190)
        Me.btnAgregarPrestamo.Name = "btnAgregarPrestamo"
        Me.btnAgregarPrestamo.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregarPrestamo.TabIndex = 26
        Me.btnAgregarPrestamo.Text = "Agregar"
        Me.btnAgregarPrestamo.UseVisualStyleBackColor = True
        '
        'txtBuscarSocio
        '
        Me.txtBuscarSocio.Location = New System.Drawing.Point(135, 21)
        Me.txtBuscarSocio.Name = "txtBuscarSocio"
        Me.txtBuscarSocio.Size = New System.Drawing.Size(131, 22)
        Me.txtBuscarSocio.TabIndex = 25
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Buscar socio:"
        '
        'dgvSocio
        '
        Me.dgvSocio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSocio.Location = New System.Drawing.Point(26, 47)
        Me.dgvSocio.Name = "dgvSocio"
        Me.dgvSocio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSocio.Size = New System.Drawing.Size(703, 123)
        Me.dgvSocio.TabIndex = 23
        '
        'BotonAgregarPrestamo
        '
        Me.BotonAgregarPrestamo.BackColor = System.Drawing.Color.LawnGreen
        Me.BotonAgregarPrestamo.Location = New System.Drawing.Point(961, 440)
        Me.BotonAgregarPrestamo.Name = "BotonAgregarPrestamo"
        Me.BotonAgregarPrestamo.Size = New System.Drawing.Size(75, 40)
        Me.BotonAgregarPrestamo.TabIndex = 33
        Me.BotonAgregarPrestamo.Text = "Agregar Prestamo"
        Me.BotonAgregarPrestamo.UseVisualStyleBackColor = False
        '
        'btnCancelarPrestamo
        '
        Me.btnCancelarPrestamo.Location = New System.Drawing.Point(787, 440)
        Me.btnCancelarPrestamo.Name = "btnCancelarPrestamo"
        Me.btnCancelarPrestamo.Size = New System.Drawing.Size(75, 40)
        Me.btnCancelarPrestamo.TabIndex = 35
        Me.btnCancelarPrestamo.Text = "Cancelar Prestamo"
        Me.btnCancelarPrestamo.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(877, 440)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 40)
        Me.btnLimpiar.TabIndex = 34
        Me.btnLimpiar.Text = "Limpiar Campos"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'btnFinalizarPrestamo
        '
        Me.btnFinalizarPrestamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnFinalizarPrestamo.Location = New System.Drawing.Point(623, 440)
        Me.btnFinalizarPrestamo.Name = "btnFinalizarPrestamo"
        Me.btnFinalizarPrestamo.Size = New System.Drawing.Size(147, 40)
        Me.btnFinalizarPrestamo.TabIndex = 37
        Me.btnFinalizarPrestamo.Text = "Finalizar Prestamo"
        Me.btnFinalizarPrestamo.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 29)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(254, 405)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'dtpHoraDevolucion
        '
        Me.dtpHoraDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraDevolucion.Location = New System.Drawing.Point(135, 162)
        Me.dtpHoraDevolucion.Name = "dtpHoraDevolucion"
        Me.dtpHoraDevolucion.ShowUpDown = True
        Me.dtpHoraDevolucion.Size = New System.Drawing.Size(131, 22)
        Me.dtpHoraDevolucion.TabIndex = 39
        '
        'AgregarPrestamo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1048, 488)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnFinalizarPrestamo)
        Me.Controls.Add(Me.btnCancelarPrestamo)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.BotonAgregarPrestamo)
        Me.Controls.Add(Me.gpbAgregarSocio)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbxDatosPrestramos)
        Me.Name = "AgregarPrestamo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbxDatosPrestramos.ResumeLayout(False)
        Me.gbxDatosPrestramos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvEjemplar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbAgregarSocio.ResumeLayout(False)
        Me.gpbAgregarSocio.PerformLayout()
        CType(Me.dgvSocio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDatosPrestramos As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dtpFechaDevolucion As DateTimePicker
    Friend WithEvents lblHoraDevolucion As Label
    Friend WithEvents lblFechaDevolucion As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtBuscarEjemplar As TextBox
    Friend WithEvents lblBuscarEjemplar As Label
    Friend WithEvents dgvEjemplar As DataGridView
    Friend WithEvents lblLibro As Label
    Friend WithEvents gpbAgregarSocio As GroupBox
    Friend WithEvents btnAgregarPrestamo As Button
    Friend WithEvents txtBuscarSocio As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvSocio As DataGridView
    Friend WithEvents BotonAgregarPrestamo As Button
    Friend WithEvents btnCancelarPrestamo As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents cbxTipoPrestamo As ComboBox
    Friend WithEvents btnFinalizarPrestamo As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dtpHoraDevolucion As DateTimePicker
End Class
