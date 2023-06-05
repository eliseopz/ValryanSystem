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
        Me.EntradasYSalidasPorUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntradasPorMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalidasPorMesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValorTotalDeSalidasPorUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ValorTotalDeEntradasPorUsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormularioToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FormularioToolStripMenuItem
        '
        Me.FormularioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem, Me.CategoriaToolStripMenuItem, Me.ProductoToolStripMenuItem, Me.EntradaToolStripMenuItem, Me.SalidaToolStripMenuItem})
        Me.FormularioToolStripMenuItem.Name = "FormularioToolStripMenuItem"
        Me.FormularioToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.FormularioToolStripMenuItem.Text = "Formulario"
        '
        'ProductosToolStripMenuItem
        '
        Me.ProductosToolStripMenuItem.Name = "ProductosToolStripMenuItem"
        Me.ProductosToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ProductosToolStripMenuItem.Text = "Usuario"
        '
        'CategoriaToolStripMenuItem
        '
        Me.CategoriaToolStripMenuItem.Name = "CategoriaToolStripMenuItem"
        Me.CategoriaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CategoriaToolStripMenuItem.Text = "Categoria"
        '
        'ProductoToolStripMenuItem
        '
        Me.ProductoToolStripMenuItem.Name = "ProductoToolStripMenuItem"
        Me.ProductoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ProductoToolStripMenuItem.Text = "Producto"
        '
        'EntradaToolStripMenuItem
        '
        Me.EntradaToolStripMenuItem.Name = "EntradaToolStripMenuItem"
        Me.EntradaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.EntradaToolStripMenuItem.Text = "Entrada"
        '
        'SalidaToolStripMenuItem
        '
        Me.SalidaToolStripMenuItem.Name = "SalidaToolStripMenuItem"
        Me.SalidaToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SalidaToolStripMenuItem.Text = "Salida"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductosToolStripMenuItem1, Me.ProductoConMasSalidasToolStripMenuItem, Me.UnidadesPorCategoriaToolStripMenuItem, Me.ProductosPorPrecioToolStripMenuItem, Me.ProductosPorSalidasToolStripMenuItem, Me.EntradasYSalidasPorUsuarioToolStripMenuItem, Me.EntradasPorMesToolStripMenuItem, Me.SalidasPorMesToolStripMenuItem, Me.ValorTotalDeSalidasPorUsuarioToolStripMenuItem, Me.ValorTotalDeEntradasPorUsuarioToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ProductosToolStripMenuItem1
        '
        Me.ProductosToolStripMenuItem1.Name = "ProductosToolStripMenuItem1"
        Me.ProductosToolStripMenuItem1.Size = New System.Drawing.Size(248, 22)
        Me.ProductosToolStripMenuItem1.Text = "Productos"
        '
        'ProductoConMasSalidasToolStripMenuItem
        '
        Me.ProductoConMasSalidasToolStripMenuItem.Name = "ProductoConMasSalidasToolStripMenuItem"
        Me.ProductoConMasSalidasToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ProductoConMasSalidasToolStripMenuItem.Text = "Producto con mas salidas"
        '
        'UnidadesPorCategoriaToolStripMenuItem
        '
        Me.UnidadesPorCategoriaToolStripMenuItem.Name = "UnidadesPorCategoriaToolStripMenuItem"
        Me.UnidadesPorCategoriaToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.UnidadesPorCategoriaToolStripMenuItem.Text = "Unidades por Categoria"
        '
        'ProductosPorPrecioToolStripMenuItem
        '
        Me.ProductosPorPrecioToolStripMenuItem.Name = "ProductosPorPrecioToolStripMenuItem"
        Me.ProductosPorPrecioToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ProductosPorPrecioToolStripMenuItem.Text = "Productos por precio"
        '
        'ProductosPorSalidasToolStripMenuItem
        '
        Me.ProductosPorSalidasToolStripMenuItem.Name = "ProductosPorSalidasToolStripMenuItem"
        Me.ProductosPorSalidasToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ProductosPorSalidasToolStripMenuItem.Text = "Productos por salidas"
        '
        'EntradasYSalidasPorUsuarioToolStripMenuItem
        '
        Me.EntradasYSalidasPorUsuarioToolStripMenuItem.Name = "EntradasYSalidasPorUsuarioToolStripMenuItem"
        Me.EntradasYSalidasPorUsuarioToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.EntradasYSalidasPorUsuarioToolStripMenuItem.Text = "Entradas y Salidas Por Usuario"
        '
        'EntradasPorMesToolStripMenuItem
        '
        Me.EntradasPorMesToolStripMenuItem.Name = "EntradasPorMesToolStripMenuItem"
        Me.EntradasPorMesToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.EntradasPorMesToolStripMenuItem.Text = "Entradas Por Mes"
        '
        'SalidasPorMesToolStripMenuItem
        '
        Me.SalidasPorMesToolStripMenuItem.Name = "SalidasPorMesToolStripMenuItem"
        Me.SalidasPorMesToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.SalidasPorMesToolStripMenuItem.Text = "Salidas Por Mes"
        '
        'ValorTotalDeSalidasPorUsuarioToolStripMenuItem
        '
        Me.ValorTotalDeSalidasPorUsuarioToolStripMenuItem.Name = "ValorTotalDeSalidasPorUsuarioToolStripMenuItem"
        Me.ValorTotalDeSalidasPorUsuarioToolStripMenuItem.Size = New System.Drawing.Size(248, 22)
        Me.ValorTotalDeSalidasPorUsuarioToolStripMenuItem.Text = "Valor Total De Salidas Por Usuario"
        '
        'ValorTotalDeEntradasPorUsuarioToolStripMenuItem
        '
        Me.ValorTotalDeEntradasPorUsuarioToolStripMenuItem.Name = "ValorTotalDeEntradasPorUsuarioToolStripMenuItem"
        Me.ValorTotalDeEntradasPorUsuarioToolStripMenuItem.Size = New System.Drawing.Size(257, 22)
        Me.ValorTotalDeEntradasPorUsuarioToolStripMenuItem.Text = "Valor Total De Entradas Por Usuario"
        '
        'FrmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 449)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
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
    Friend WithEvents EntradasYSalidasPorUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntradasPorMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalidasPorMesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValorTotalDeSalidasPorUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ValorTotalDeEntradasPorUsuarioToolStripMenuItem As ToolStripMenuItem
End Class
