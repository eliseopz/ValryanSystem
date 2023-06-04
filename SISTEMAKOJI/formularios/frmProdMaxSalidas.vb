Imports Microsoft.Reporting.WinForms
Imports SISTEMAKOJI.Module1
Public Class frmProdMaxSalidas
    Dim tblProd As New DBValyrianDataSet.ProductoMaxSalidasDataTable
    Dim rptProdMaxSalidas As New DBValyrianDataSetTableAdapters.ProductoMaxSalidasTableAdapter
    Dim tbl As New DataTable

    Private Sub LlenarRegistros()
        rptProdMaxSalidas.Fill(tblProd)
        DgvProducto.DataSource = tblProd
        For Each row As DataGridViewRow In DgvProducto.Rows
            row.Selected = True
        Next

        DgvProducto.Refresh()
    End Sub

    Private Sub frmProdMaxSalidas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistros()
    End Sub

    Public Function CrearTabla(query) As DataTable
        Dim tbl As DataTable = New DataTable("tblProd")
        Dim fila As DataRow

        tbl.Columns.Add("idSalida")
        tbl.Columns.Add("nombreProducto")
        tbl.Columns.Add("unidadesSalida")

        For Each prod In query
            fila = tbl.NewRow()
            fila("idSalida") = prod.idSalida
            fila("nombreProducto") = prod.nombreProducto
            fila("unidadesSalida") = prod.unidadesSalida
            tbl.Rows.Add(fila)
        Next
        Return tbl
    End Function

    Private Sub BuscarRegistro()
        Dim query = From prod In tblProd
                    Select prod.idSalida, prod.nombreProducto, prod.unidadesSalida

        tbl = CrearTabla(query)
        DgvProducto.DataSource = tbl
        DgvProducto.Refresh()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        BuscarRegistro()
        VerReporte(tbl, "DsProducto", "reportes\rptProductoMaxSalidas.rdlc")
    End Sub
End Class