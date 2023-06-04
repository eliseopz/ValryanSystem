<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FormularioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductoConMasSalidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadesPorCategoriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosPorPrecioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductosPorSalidasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormularioToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(782, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormularioToolStripMenuItem
        '
        Me.FormularioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.EntradaToolStripMenuItem, Me.SalidaToolStripMenuItem})
        Me.FormularioToolStripMenuItem.Name = "FormularioToolStripMenuItem"
        Me.FormularioToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.FormularioToolStripMenuItem.Text = "Formulario"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.ProductosToolStripMenuItem.Text = "Usuario"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'EntradaToolStripMenuItem
        '
        Me.EntradaToolStripMenuItem.Name = "EntradaToolStripMenuItem"
        Me.EntradaToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.EntradaToolStripMenuItem.Text = "Entrada"
        '
        'SalidaToolStripMenuItem
        '
        Me.SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        Me.SalidaToolStripMenuItem.Size = New System.Drawing.Size(157, 26)
        Me.SalidaToolStripMenuItem.Text = "Salida"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem1, Me.ProductoConMasSalidasToolStripMenuItem, Me.UnidadesPorCategoriaToolStripMenuItem, Me.ProductosPorPrecioToolStripMenuItem, Me.ProductosPorSalidasToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(82, 24)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(260, 26)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'ProductoConMasSalidasToolStripMenuItem
        '
        Me.ProductoConMasSalidasToolStripMenuItem.Name = "ProductoConMasSalidasToolStripMenuItem"
        Me.ProductoConMasSalidasToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.ProductoConMasSalidasToolStripMenuItem.Text = "Producto con mas salidas"
        '
        'UnidadesPorCategoriaToolStripMenuItem
        '
        Me.UnidadesPorCategoriaToolStripMenuItem.Name = "UnidadesPorCategoriaToolStripMenuItem"
        Me.UnidadesPorCategoriaToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.UnidadesPorCategoriaToolStripMenuItem.Text = "Unidades por Categoria"
        '
        'ProductosPorPrecioToolStripMenuItem
        '
        Me.ProductosPorPrecioToolStripMenuItem.Name = "ProductosPorPrecioToolStripMenuItem"
        Me.ProductosPorPrecioToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.ProductosPorPrecioToolStripMenuItem.Text = "Productos por precio"
        '
        'ProductosPorSalidasToolStripMenuItem
        '
        Me.ProductosPorSalidasToolStripMenuItem.Name = "ProductosPorSalidasToolStripMenuItem"
        Me.ProductosPorSalidasToolStripMenuItem.Size = New System.Drawing.Size(260, 26)
        Me.ProductosPorSalidasToolStripMenuItem.Text = "Productos por salidas"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 553)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmPrincipal"
        Me.Text = "Menú Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FormularioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ProductoConMasSalidasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadesPorCategoriaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosPorPrecioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductosPorSalidasToolStripMenuItem As ToolStripMenuItem
End Class
