<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ejemplares
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
        Me.listaEjemplares = New System.Windows.Forms.DataGridView()
        Me.btnEliminarEjemplar = New System.Windows.Forms.Button()
        Me.btnModificarEjemplar = New System.Windows.Forms.Button()
        Me.btnAgregarEjemplar = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.listaEjemplares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listaEjemplares
        '
        Me.listaEjemplares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaEjemplares.Location = New System.Drawing.Point(40, 12)
        Me.listaEjemplares.Name = "listaEjemplares"
        Me.listaEjemplares.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listaEjemplares.Size = New System.Drawing.Size(538, 144)
        Me.listaEjemplares.TabIndex = 1
        '
        'btnEliminarEjemplar
        '
        Me.btnEliminarEjemplar.Location = New System.Drawing.Point(700, 287)
        Me.btnEliminarEjemplar.Name = "btnEliminarEjemplar"
        Me.btnEliminarEjemplar.Size = New System.Drawing.Size(72, 45)
        Me.btnEliminarEjemplar.TabIndex = 6
        Me.btnEliminarEjemplar.Text = "Eliminar"
        Me.btnEliminarEjemplar.UseVisualStyleBackColor = True
        '
        'btnModificarEjemplar
        '
        Me.btnModificarEjemplar.Location = New System.Drawing.Point(605, 287)
        Me.btnModificarEjemplar.Name = "btnModificarEjemplar"
        Me.btnModificarEjemplar.Size = New System.Drawing.Size(72, 45)
        Me.btnModificarEjemplar.TabIndex = 5
        Me.btnModificarEjemplar.Text = "Modificar Ejemplar"
        Me.btnModificarEjemplar.UseVisualStyleBackColor = True
        '
        'btnAgregarEjemplar
        '
        Me.btnAgregarEjemplar.Location = New System.Drawing.Point(506, 287)
        Me.btnAgregarEjemplar.Name = "btnAgregarEjemplar"
        Me.btnAgregarEjemplar.Size = New System.Drawing.Size(72, 45)
        Me.btnAgregarEjemplar.TabIndex = 4
        Me.btnAgregarEjemplar.Text = "Agregar Ejemplar"
        Me.btnAgregarEjemplar.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(40, 287)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(72, 45)
        Me.btnVolver.TabIndex = 7
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'Ejemplares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 344)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnEliminarEjemplar)
        Me.Controls.Add(Me.btnModificarEjemplar)
        Me.Controls.Add(Me.btnAgregarEjemplar)
        Me.Controls.Add(Me.listaEjemplares)
        Me.Name = "Ejemplares"
        Me.Text = "Ejemplares"
        CType(Me.listaEjemplares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listaEjemplares As DataGridView
    Friend WithEvents btnEliminarEjemplar As Button
    Friend WithEvents btnModificarEjemplar As Button
    Friend WithEvents btnAgregarEjemplar As Button
    Friend WithEvents btnVolver As Button
End Class
