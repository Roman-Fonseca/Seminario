<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Socios
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
        Me.listaSocios = New System.Windows.Forms.DataGridView()
        Me.btnAgregarSocio = New System.Windows.Forms.Button()
        Me.btnModificarSocio = New System.Windows.Forms.Button()
        Me.btnEliminarSocio = New System.Windows.Forms.Button()
        CType(Me.listaSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listaSocios
        '
        Me.listaSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaSocios.Location = New System.Drawing.Point(43, 39)
        Me.listaSocios.Name = "listaSocios"
        Me.listaSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listaSocios.Size = New System.Drawing.Size(723, 205)
        Me.listaSocios.TabIndex = 0
        '
        'btnAgregarSocio
        '
        Me.btnAgregarSocio.Location = New System.Drawing.Point(43, 278)
        Me.btnAgregarSocio.Name = "btnAgregarSocio"
        Me.btnAgregarSocio.Size = New System.Drawing.Size(72, 45)
        Me.btnAgregarSocio.TabIndex = 1
        Me.btnAgregarSocio.Text = "Agregar Socio"
        Me.btnAgregarSocio.UseVisualStyleBackColor = True
        '
        'btnModificarSocio
        '
        Me.btnModificarSocio.Location = New System.Drawing.Point(142, 278)
        Me.btnModificarSocio.Name = "btnModificarSocio"
        Me.btnModificarSocio.Size = New System.Drawing.Size(72, 45)
        Me.btnModificarSocio.TabIndex = 2
        Me.btnModificarSocio.Text = "Modificar Socio"
        Me.btnModificarSocio.UseVisualStyleBackColor = True
        '
        'btnEliminarSocio
        '
        Me.btnEliminarSocio.Location = New System.Drawing.Point(237, 278)
        Me.btnEliminarSocio.Name = "btnEliminarSocio"
        Me.btnEliminarSocio.Size = New System.Drawing.Size(72, 45)
        Me.btnEliminarSocio.TabIndex = 3
        Me.btnEliminarSocio.Text = "Eliminar Socio"
        Me.btnEliminarSocio.UseVisualStyleBackColor = True
        '
        'Socios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnEliminarSocio)
        Me.Controls.Add(Me.btnModificarSocio)
        Me.Controls.Add(Me.btnAgregarSocio)
        Me.Controls.Add(Me.listaSocios)
        Me.Name = "Socios"
        Me.Text = "Socios"
        CType(Me.listaSocios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents listaSocios As DataGridView
    Friend WithEvents btnAgregarSocio As Button
    Friend WithEvents btnModificarSocio As Button
    Friend WithEvents btnEliminarSocio As Button
End Class
