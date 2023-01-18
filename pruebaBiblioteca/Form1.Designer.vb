<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Me.btnConectar = New System.Windows.Forms.Button()
        Me.btnSocios = New System.Windows.Forms.Button()
        Me.btnLibros = New System.Windows.Forms.Button()
        Me.btnEjemplares = New System.Windows.Forms.Button()
        Me.btnPrestamos = New System.Windows.Forms.Button()
        Me.btnPlazoPrestamo = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtpFechaDevolucion = New System.Windows.Forms.DateTimePicker()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarSocioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerSociosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPrestamoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPrestamosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnProcesoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtrasadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EjemplaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarEjemplarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerEjemplaresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TodosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrestadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SancionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarParametroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanciónEsperaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SanciónDineroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlazosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarPlazoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPlazosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConectar
        '
        Me.btnConectar.Location = New System.Drawing.Point(558, 80)
        Me.btnConectar.Name = "btnConectar"
        Me.btnConectar.Size = New System.Drawing.Size(203, 81)
        Me.btnConectar.TabIndex = 0
        Me.btnConectar.Text = "Conectar"
        Me.btnConectar.UseVisualStyleBackColor = True
        '
        'btnSocios
        '
        Me.btnSocios.Location = New System.Drawing.Point(38, 80)
        Me.btnSocios.Name = "btnSocios"
        Me.btnSocios.Size = New System.Drawing.Size(127, 55)
        Me.btnSocios.TabIndex = 2
        Me.btnSocios.Text = "Socios"
        Me.btnSocios.UseVisualStyleBackColor = True
        '
        'btnLibros
        '
        Me.btnLibros.Location = New System.Drawing.Point(38, 191)
        Me.btnLibros.Name = "btnLibros"
        Me.btnLibros.Size = New System.Drawing.Size(127, 47)
        Me.btnLibros.TabIndex = 3
        Me.btnLibros.Text = "Libros"
        Me.btnLibros.UseVisualStyleBackColor = True
        '
        'btnEjemplares
        '
        Me.btnEjemplares.Location = New System.Drawing.Point(38, 289)
        Me.btnEjemplares.Name = "btnEjemplares"
        Me.btnEjemplares.Size = New System.Drawing.Size(127, 47)
        Me.btnEjemplares.TabIndex = 4
        Me.btnEjemplares.Text = "Ejemplares"
        Me.btnEjemplares.UseVisualStyleBackColor = True
        '
        'btnPrestamos
        '
        Me.btnPrestamos.Location = New System.Drawing.Point(171, 289)
        Me.btnPrestamos.Name = "btnPrestamos"
        Me.btnPrestamos.Size = New System.Drawing.Size(146, 47)
        Me.btnPrestamos.TabIndex = 5
        Me.btnPrestamos.Text = "Prestamos"
        Me.btnPrestamos.UseVisualStyleBackColor = True
        '
        'btnPlazoPrestamo
        '
        Me.btnPlazoPrestamo.Location = New System.Drawing.Point(558, 191)
        Me.btnPlazoPrestamo.Name = "btnPlazoPrestamo"
        Me.btnPlazoPrestamo.Size = New System.Drawing.Size(83, 47)
        Me.btnPlazoPrestamo.TabIndex = 6
        Me.btnPlazoPrestamo.Text = "Plazo Prestamo"
        Me.btnPlazoPrestamo.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(558, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 47)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Probar Hora y fecha"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtpFechaDevolucion
        '
        Me.dtpFechaDevolucion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDevolucion.Location = New System.Drawing.Point(558, 369)
        Me.dtpFechaDevolucion.Name = "dtpFechaDevolucion"
        Me.dtpFechaDevolucion.Size = New System.Drawing.Size(134, 20)
        Me.dtpFechaDevolucion.TabIndex = 8
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SociosToolStripMenuItem, Me.PrestamosToolStripMenuItem, Me.EjemplaresToolStripMenuItem, Me.SancionesToolStripMenuItem, Me.ParametrosToolStripMenuItem, Me.PlazosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SociosToolStripMenuItem
        '
        Me.SociosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarSocioToolStripMenuItem, Me.VerSociosToolStripMenuItem})
        Me.SociosToolStripMenuItem.Name = "SociosToolStripMenuItem"
        Me.SociosToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.SociosToolStripMenuItem.Text = "Socios"
        '
        'AgregarSocioToolStripMenuItem
        '
        Me.AgregarSocioToolStripMenuItem.Name = "AgregarSocioToolStripMenuItem"
        Me.AgregarSocioToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.AgregarSocioToolStripMenuItem.Text = "Agregar Socio"
        '
        'VerSociosToolStripMenuItem
        '
        Me.VerSociosToolStripMenuItem.Name = "VerSociosToolStripMenuItem"
        Me.VerSociosToolStripMenuItem.Size = New System.Drawing.Size(148, 22)
        Me.VerSociosToolStripMenuItem.Text = "Ver Socios"
        '
        'PrestamosToolStripMenuItem
        '
        Me.PrestamosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPrestamoToolStripMenuItem, Me.VerPrestamosToolStripMenuItem})
        Me.PrestamosToolStripMenuItem.Name = "PrestamosToolStripMenuItem"
        Me.PrestamosToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.PrestamosToolStripMenuItem.Text = "Prestamos"
        '
        'AgregarPrestamoToolStripMenuItem
        '
        Me.AgregarPrestamoToolStripMenuItem.Name = "AgregarPrestamoToolStripMenuItem"
        Me.AgregarPrestamoToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AgregarPrestamoToolStripMenuItem.Text = "Agregar prestamo"
        '
        'VerPrestamosToolStripMenuItem
        '
        Me.VerPrestamosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosToolStripMenuItem1, Me.EnProcesoToolStripMenuItem, Me.AtrasadosToolStripMenuItem})
        Me.VerPrestamosToolStripMenuItem.Name = "VerPrestamosToolStripMenuItem"
        Me.VerPrestamosToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.VerPrestamosToolStripMenuItem.Text = "Ver prestamos"
        '
        'TodosToolStripMenuItem1
        '
        Me.TodosToolStripMenuItem1.Name = "TodosToolStripMenuItem1"
        Me.TodosToolStripMenuItem1.Size = New System.Drawing.Size(132, 22)
        Me.TodosToolStripMenuItem1.Text = "Todos"
        '
        'EnProcesoToolStripMenuItem
        '
        Me.EnProcesoToolStripMenuItem.Name = "EnProcesoToolStripMenuItem"
        Me.EnProcesoToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EnProcesoToolStripMenuItem.Text = "En proceso"
        '
        'AtrasadosToolStripMenuItem
        '
        Me.AtrasadosToolStripMenuItem.Name = "AtrasadosToolStripMenuItem"
        Me.AtrasadosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.AtrasadosToolStripMenuItem.Text = "Atrasados"
        '
        'EjemplaresToolStripMenuItem
        '
        Me.EjemplaresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarEjemplarToolStripMenuItem, Me.VerEjemplaresToolStripMenuItem})
        Me.EjemplaresToolStripMenuItem.Name = "EjemplaresToolStripMenuItem"
        Me.EjemplaresToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EjemplaresToolStripMenuItem.Text = "Ejemplares"
        '
        'AgregarEjemplarToolStripMenuItem
        '
        Me.AgregarEjemplarToolStripMenuItem.Name = "AgregarEjemplarToolStripMenuItem"
        Me.AgregarEjemplarToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AgregarEjemplarToolStripMenuItem.Text = "Agregar ejemplar"
        '
        'VerEjemplaresToolStripMenuItem
        '
        Me.VerEjemplaresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TodosToolStripMenuItem, Me.EliminadosToolStripMenuItem, Me.PrestadosToolStripMenuItem})
        Me.VerEjemplaresToolStripMenuItem.Name = "VerEjemplaresToolStripMenuItem"
        Me.VerEjemplaresToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.VerEjemplaresToolStripMenuItem.Text = "Ver Ejemplares"
        '
        'TodosToolStripMenuItem
        '
        Me.TodosToolStripMenuItem.Name = "TodosToolStripMenuItem"
        Me.TodosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.TodosToolStripMenuItem.Text = "Todos"
        '
        'EliminadosToolStripMenuItem
        '
        Me.EliminadosToolStripMenuItem.Name = "EliminadosToolStripMenuItem"
        Me.EliminadosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.EliminadosToolStripMenuItem.Text = "Eliminados"
        '
        'PrestadosToolStripMenuItem
        '
        Me.PrestadosToolStripMenuItem.Name = "PrestadosToolStripMenuItem"
        Me.PrestadosToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PrestadosToolStripMenuItem.Text = "Prestados"
        '
        'SancionesToolStripMenuItem
        '
        Me.SancionesToolStripMenuItem.Name = "SancionesToolStripMenuItem"
        Me.SancionesToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.SancionesToolStripMenuItem.Text = "Sanciones"
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarParametroToolStripMenuItem, Me.VerParametrosToolStripMenuItem})
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.ParametrosToolStripMenuItem.Text = "Parametros"
        '
        'AgregarParametroToolStripMenuItem
        '
        Me.AgregarParametroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SanciónEsperaToolStripMenuItem, Me.SanciónDineroToolStripMenuItem})
        Me.AgregarParametroToolStripMenuItem.Name = "AgregarParametroToolStripMenuItem"
        Me.AgregarParametroToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.AgregarParametroToolStripMenuItem.Text = "Agregar parametro"
        '
        'SanciónEsperaToolStripMenuItem
        '
        Me.SanciónEsperaToolStripMenuItem.Name = "SanciónEsperaToolStripMenuItem"
        Me.SanciónEsperaToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SanciónEsperaToolStripMenuItem.Text = "Sanción espera"
        '
        'SanciónDineroToolStripMenuItem
        '
        Me.SanciónDineroToolStripMenuItem.Name = "SanciónDineroToolStripMenuItem"
        Me.SanciónDineroToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.SanciónDineroToolStripMenuItem.Text = "Sanción dinero "
        '
        'VerParametrosToolStripMenuItem
        '
        Me.VerParametrosToolStripMenuItem.Name = "VerParametrosToolStripMenuItem"
        Me.VerParametrosToolStripMenuItem.Size = New System.Drawing.Size(174, 22)
        Me.VerParametrosToolStripMenuItem.Text = "Ver parametros"
        '
        'PlazosToolStripMenuItem
        '
        Me.PlazosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarPlazoToolStripMenuItem, Me.VerPlazosToolStripMenuItem})
        Me.PlazosToolStripMenuItem.Name = "PlazosToolStripMenuItem"
        Me.PlazosToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.PlazosToolStripMenuItem.Text = "Plazos"
        '
        'AgregarPlazoToolStripMenuItem
        '
        Me.AgregarPlazoToolStripMenuItem.Name = "AgregarPlazoToolStripMenuItem"
        Me.AgregarPlazoToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.AgregarPlazoToolStripMenuItem.Text = "Agregar Plazo"
        '
        'VerPlazosToolStripMenuItem
        '
        Me.VerPlazosToolStripMenuItem.Name = "VerPlazosToolStripMenuItem"
        Me.VerPlazosToolStripMenuItem.Size = New System.Drawing.Size(147, 22)
        Me.VerPlazosToolStripMenuItem.Text = "Ver Plazos"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(407, 289)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 47)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Prueba horario"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 409)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.dtpFechaDevolucion)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnPlazoPrestamo)
        Me.Controls.Add(Me.btnPrestamos)
        Me.Controls.Add(Me.btnEjemplares)
        Me.Controls.Add(Me.btnLibros)
        Me.Controls.Add(Me.btnSocios)
        Me.Controls.Add(Me.btnConectar)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConectar As Button
    Friend WithEvents btnSocios As Button
    Friend WithEvents btnLibros As Button
    Friend WithEvents btnEjemplares As Button
    Friend WithEvents btnPrestamos As Button
    Friend WithEvents btnPlazoPrestamo As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents dtpFechaDevolucion As DateTimePicker
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarSocioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerSociosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPrestamoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPrestamosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EnProcesoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtrasadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EjemplaresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarEjemplarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerEjemplaresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TodosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PrestadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SancionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParametrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarParametroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SanciónEsperaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SanciónDineroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerParametrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlazosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarPlazoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPlazosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
End Class
