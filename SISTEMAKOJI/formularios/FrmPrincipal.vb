﻿Imports SISTEMAKOJI.Module1
Public Class FrmPrincipal
    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Dim frm As New FrmUsuarios
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub CategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriaToolStripMenuItem.Click
        Dim frm As New FrmCategoria
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub ProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoToolStripMenuItem.Click
        Dim frm As New FrmProductos
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub EntradaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradaToolStripMenuItem.Click
        Dim frm As New FrmEntrada
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SalidaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidaToolStripMenuItem.Click
        Dim frm As New FrmSalidas
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProductosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem1.Click
        Dim tbl As New DataTable
        Dim reporteProductos As New DBValyrianDataSetTableAdapters.DataTable1TableAdapter

        tbl = reporteProductos.GetData
        VerReporte(tbl, "DsReporteProductos", "reportes\rptProductos.rdlc")
    End Sub

    Private Sub ProductoConMasSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductoConMasSalidasToolStripMenuItem.Click
        Dim rptProdMaxSalidas As New DBValyrianDataSetTableAdapters.ProductoMaxSalidasTableAdapter
        Dim tbl As New DataTable

        tbl = rptProdMaxSalidas.GetData
        VerReporte(tbl, "DsProducto", "reportes\rptProductoMaxSalidas.rdlc")
    End Sub

    Private Sub UnidadesPorCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnidadesPorCategoriaToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporteUnidadesPorCategoria As New DBValyrianDataSetTableAdapters.UnidadesCategoriaTableAdapter


        tbl = reporteUnidadesPorCategoria.GetData()
        VerReporte(tbl, "DsUnidadesCategoria", "reportes\rptUnidadesCategoria.rdlc")

    End Sub

    Private Sub ProductosPorPrecioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorPrecioToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporte As New DBValyrianDataSetTableAdapters.ProductosMayorMenorTableAdapter

        tbl = reporte.GetData
        VerReporte(tbl, "DsProductoMayorMenor", "reportes\rptProdMayorMenor.rdlc")
    End Sub

    Private Sub ProductosPorSalidasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorSalidasToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporte As New DBValyrianDataSetTableAdapters.ProductosPorSalidaTableAdapter

        tbl = reporte.GetData
        VerReporte(tbl, "DsProductoPorSalidas", "reportes\rptProductoPorSalidas.rdlc")
    End Sub

    Private Sub EntradasYSalidasPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasYSalidasPorUsuarioToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporte As New DBValyrianDataSetTableAdapters.EntradasSalidasUsuarioTableAdapter
        tbl = reporte.GetData
        VerReporte(tbl, "DsEntradaSalidaUsuario", "reportes\rptEntradasSalidasUsuario.rdlc")
    End Sub

    Private Sub EntradasPorMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasPorMesToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporte As New DBValyrianDataSetTableAdapters.EntradasPorMesDataAdapter
        tbl = reporte.GetData
        VerReporte(tbl, "DsEntradaPorMes", "reportes\rptEntradasPorMes.rdlc")
    End Sub

    Private Sub SalidasPorMesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasPorMesToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporte As New DBValyrianDataSetTableAdapters.SalidasPorMesDataAdapter
        tbl = reporte.GetData
        VerReporte(tbl, "DsSalidaPorMes", "reportes\rptSalidaPorMes.rdlc")
    End Sub

    Private Sub ValorTotalDeSalidasPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValorTotalDeSalidasPorUsuarioToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporte As New DBValyrianDataSetTableAdapters.TotalSalidasUsuarioTableAdapter
        tbl = reporte.GetData
        VerReporte(tbl, "DsTotalSalidasUsuarios", "reportes\rptValorTotalSalidasUsuarios.rdlc")
    End Sub

    Private Sub ValorTotalDeEntradasPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ValorTotalDeEntradasPorUsuarioToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporte As New DBValyrianDataSetTableAdapters.TotalEntradasUsuarioTableAdapter
        tbl = reporte.GetData
        VerReporte(tbl, "DsValorTotalEntradaUsuarios", "reportes\rptValorTotalEntradasUsuarios.rdlc")
    End Sub

    Private Sub EntradasPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntradasPorUsuarioToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporte As New DBValyrianDataSetTableAdapters.EntradasUsuariosTableAdapter
        tbl = reporte.GetData
        VerReporte(tbl, "DsEntradasUsuarios", "reportes\rptEntradasUsuarios.rdlc")
    End Sub

    Private Sub SalidasPorUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalidasPorUsuarioToolStripMenuItem.Click
        Dim tbl As New DataTable
        Dim reporte As New DBValyrianDataSetTableAdapters.SalidasUsuariosTableAdapter
        tbl = reporte.GetData
        VerReporte(tbl, "DsSalidasUsuarios", "reportes\rptSalidasUsuarios.rdlc")
    End Sub

    Private Sub ProductosPorCategoriaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosPorCategoriaToolStripMenuItem.Click
        Dim frm As New frmRptProdCategoria
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class