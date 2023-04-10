<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EjemplaresEliminados
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
        Me.dgvLibrosEliminados = New System.Windows.Forms.DataGridView()
        CType(Me.dgvLibrosEliminados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvLibrosEliminados
        '
        Me.dgvLibrosEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibrosEliminados.Location = New System.Drawing.Point(24, 61)
        Me.dgvLibrosEliminados.Name = "dgvLibrosEliminados"
        Me.dgvLibrosEliminados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLibrosEliminados.Size = New System.Drawing.Size(478, 205)
        Me.dgvLibrosEliminados.TabIndex = 0
        '
        'EjemplaresEliminados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 319)
        Me.Controls.Add(Me.dgvLibrosEliminados)
        Me.Name = "EjemplaresEliminados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ejemplares Eliminados"
        CType(Me.dgvLibrosEliminados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvLibrosEliminados As DataGridView
End Class
