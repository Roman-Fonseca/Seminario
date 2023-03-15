<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libros
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
        Me.dgvLibros = New System.Windows.Forms.DataGridView()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dgvAutoresLibro = New System.Windows.Forms.DataGridView()
        Me.dgvCategoria = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAutoresLibro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLibros
        '
        Me.dgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibros.Location = New System.Drawing.Point(24, 64)
        Me.dgvLibros.Name = "dgvLibros"
        Me.dgvLibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLibros.Size = New System.Drawing.Size(588, 229)
        Me.dgvLibros.TabIndex = 0
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(24, 322)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(75, 23)
        Me.btnVolver.TabIndex = 1
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(537, 322)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 2
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(451, 322)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 3
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(21, 27)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 18)
        Me.lblNombre.TabIndex = 4
        Me.lblNombre.Text = "Nombre:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(93, 27)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(173, 20)
        Me.TextBox1.TabIndex = 5
        '
        'dgvAutoresLibro
        '
        Me.dgvAutoresLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAutoresLibro.Location = New System.Drawing.Point(649, 64)
        Me.dgvAutoresLibro.Name = "dgvAutoresLibro"
        Me.dgvAutoresLibro.Size = New System.Drawing.Size(240, 106)
        Me.dgvAutoresLibro.TabIndex = 6
        '
        'dgvCategoria
        '
        Me.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCategoria.Location = New System.Drawing.Point(649, 194)
        Me.dgvCategoria.Name = "dgvCategoria"
        Me.dgvCategoria.Size = New System.Drawing.Size(138, 99)
        Me.dgvCategoria.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(646, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Autor/es"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(646, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Categoria/s"
        '
        'Libros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(921, 379)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvCategoria)
        Me.Controls.Add(Me.dgvAutoresLibro)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.dgvLibros)
        Me.Name = "Libros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Libros"
        CType(Me.dgvLibros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAutoresLibro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvCategoria, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvLibros As DataGridView
    Friend WithEvents btnVolver As Button
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents lblNombre As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents dgvAutoresLibro As DataGridView
    Friend WithEvents dgvCategoria As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
