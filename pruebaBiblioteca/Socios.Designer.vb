﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Socios))
        Me.listaSocios = New System.Windows.Forms.DataGridView()
        Me.btnAgregarSocio = New System.Windows.Forms.Button()
        Me.btnModificarSocio = New System.Windows.Forms.Button()
        Me.btnEliminarSocio = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnRenovarMembresia = New System.Windows.Forms.Button()
        CType(Me.listaSocios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'listaSocios
        '
        Me.listaSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listaSocios.Location = New System.Drawing.Point(222, 64)
        Me.listaSocios.Name = "listaSocios"
        Me.listaSocios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.listaSocios.Size = New System.Drawing.Size(809, 371)
        Me.listaSocios.TabIndex = 0
        '
        'btnAgregarSocio
        '
        Me.btnAgregarSocio.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAgregarSocio.Location = New System.Drawing.Point(754, 458)
        Me.btnAgregarSocio.Name = "btnAgregarSocio"
        Me.btnAgregarSocio.Size = New System.Drawing.Size(72, 45)
        Me.btnAgregarSocio.TabIndex = 1
        Me.btnAgregarSocio.Text = "Agregar Socio"
        Me.btnAgregarSocio.UseVisualStyleBackColor = False
        '
        'btnModificarSocio
        '
        Me.btnModificarSocio.BackColor = System.Drawing.Color.Yellow
        Me.btnModificarSocio.Location = New System.Drawing.Point(853, 458)
        Me.btnModificarSocio.Name = "btnModificarSocio"
        Me.btnModificarSocio.Size = New System.Drawing.Size(72, 45)
        Me.btnModificarSocio.TabIndex = 2
        Me.btnModificarSocio.Text = "Modificar Socio"
        Me.btnModificarSocio.UseVisualStyleBackColor = False
        '
        'btnEliminarSocio
        '
        Me.btnEliminarSocio.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnEliminarSocio.Location = New System.Drawing.Point(948, 458)
        Me.btnEliminarSocio.Name = "btnEliminarSocio"
        Me.btnEliminarSocio.Size = New System.Drawing.Size(72, 45)
        Me.btnEliminarSocio.TabIndex = 3
        Me.btnEliminarSocio.Text = "Eliminar Socio"
        Me.btnEliminarSocio.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 69)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(191, 205)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(218, 32)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 20)
        Me.lblNombre.TabIndex = 5
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(293, 34)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(176, 20)
        Me.txtNombre.TabIndex = 6
        '
        'btnRenovarMembresia
        '
        Me.btnRenovarMembresia.BackColor = System.Drawing.Color.Aquamarine
        Me.btnRenovarMembresia.Location = New System.Drawing.Point(559, 458)
        Me.btnRenovarMembresia.Name = "btnRenovarMembresia"
        Me.btnRenovarMembresia.Size = New System.Drawing.Size(170, 45)
        Me.btnRenovarMembresia.TabIndex = 7
        Me.btnRenovarMembresia.Text = "Renovar Membresia"
        Me.btnRenovarMembresia.UseVisualStyleBackColor = False
        '
        'Socios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1072, 529)
        Me.Controls.Add(Me.btnRenovarMembresia)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnEliminarSocio)
        Me.Controls.Add(Me.btnModificarSocio)
        Me.Controls.Add(Me.btnAgregarSocio)
        Me.Controls.Add(Me.listaSocios)
        Me.MinimizeBox = False
        Me.Name = "Socios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Socios"
        CType(Me.listaSocios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents listaSocios As DataGridView
    Friend WithEvents btnAgregarSocio As Button
    Friend WithEvents btnModificarSocio As Button
    Friend WithEvents btnEliminarSocio As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnRenovarMembresia As Button
End Class
