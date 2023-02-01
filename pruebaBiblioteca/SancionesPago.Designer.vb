<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SancionesPago
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
        Me.dgvSancionesPago = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSancionesPago, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSancionesPago
        '
        Me.dgvSancionesPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSancionesPago.Location = New System.Drawing.Point(26, 42)
        Me.dgvSancionesPago.Name = "dgvSancionesPago"
        Me.dgvSancionesPago.Size = New System.Drawing.Size(506, 198)
        Me.dgvSancionesPago.TabIndex = 0
        '
        'SancionesPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 350)
        Me.Controls.Add(Me.dgvSancionesPago)
        Me.Name = "SancionesPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sanciones Pago"
        CType(Me.dgvSancionesPago, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvSancionesPago As DataGridView
End Class
