<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionAutor
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
        Me.dgvAutor = New System.Windows.Forms.DataGridView()
        Me.lblNombreAutor = New System.Windows.Forms.Label()
        Me.txtNombreAutor = New System.Windows.Forms.TextBox()
        Me.btnSeleccionarAutor = New System.Windows.Forms.Button()
        Me.brnCancelar = New System.Windows.Forms.Button()
        CType(Me.dgvAutor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvAutor
        '
        Me.dgvAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAutor.Location = New System.Drawing.Point(15, 59)
        Me.dgvAutor.Name = "dgvAutor"
        Me.dgvAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAutor.Size = New System.Drawing.Size(331, 124)
        Me.dgvAutor.TabIndex = 0
        '
        'lblNombreAutor
        '
        Me.lblNombreAutor.AutoSize = True
        Me.lblNombreAutor.Location = New System.Drawing.Point(12, 23)
        Me.lblNombreAutor.Name = "lblNombreAutor"
        Me.lblNombreAutor.Size = New System.Drawing.Size(75, 13)
        Me.lblNombreAutor.TabIndex = 1
        Me.lblNombreAutor.Text = "Nombre Autor:"
        '
        'txtNombreAutor
        '
        Me.txtNombreAutor.Location = New System.Drawing.Point(87, 23)
        Me.txtNombreAutor.Name = "txtNombreAutor"
        Me.txtNombreAutor.Size = New System.Drawing.Size(142, 20)
        Me.txtNombreAutor.TabIndex = 2
        '
        'btnSeleccionarAutor
        '
        Me.btnSeleccionarAutor.Location = New System.Drawing.Point(173, 215)
        Me.btnSeleccionarAutor.Name = "btnSeleccionarAutor"
        Me.btnSeleccionarAutor.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionarAutor.TabIndex = 3
        Me.btnSeleccionarAutor.Text = "Seleccionar"
        Me.btnSeleccionarAutor.UseVisualStyleBackColor = True
        '
        'brnCancelar
        '
        Me.brnCancelar.Location = New System.Drawing.Point(271, 215)
        Me.brnCancelar.Name = "brnCancelar"
        Me.brnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.brnCancelar.TabIndex = 4
        Me.brnCancelar.Text = "Cancelar"
        Me.brnCancelar.UseVisualStyleBackColor = True
        '
        'SeleccionAutor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(362, 246)
        Me.Controls.Add(Me.brnCancelar)
        Me.Controls.Add(Me.btnSeleccionarAutor)
        Me.Controls.Add(Me.txtNombreAutor)
        Me.Controls.Add(Me.lblNombreAutor)
        Me.Controls.Add(Me.dgvAutor)
        Me.Name = "SeleccionAutor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SeleccionAutor"
        CType(Me.dgvAutor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvAutor As DataGridView
    Friend WithEvents lblNombreAutor As Label
    Friend WithEvents txtNombreAutor As TextBox
    Friend WithEvents btnSeleccionarAutor As Button
    Friend WithEvents brnCancelar As Button
End Class
