Imports Microsoft.Reporting.WinForms
Imports SISTEMAKOJI.Module1
Public Class rptUnidadesCategoria
    Dim tblCategoria As New DBValyrianDataSet.UnidadesCategoriaDataTable
    Dim rptUnidadesPorCategoria As New DBValyrianDataSetTableAdapters.UnidadesCategoriaTableAdapter
    Dim tbl As New DataTable

    Private Sub LlenarRegistros()
        rptUnidadesPorCategoria.Fill(tblCategoria)
        DgvRegistros.DataSource = tblCategoria
        DgvRegistros.Refresh()
    End Sub

    Private Sub rptUnidadesCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistros()
    End Sub

    Public Function CrearTabla(query) As DataTable
        Dim tbl As DataTable = New DataTable("tblCategoria")
        Dim fila As DataRow

        tbl.Columns.Add("nombreCategoria")
        tbl.Columns.Add("unidadesProducto")

        For Each categoria In query
            fila = tbl.NewRow()
            fila("nombreCategoria") = categoria.nombreCategoria
            fila("unidadesProducto") = categoria.unidadesProducto
            tbl.Rows.Add(fila)
        Next
        Return tbl
    End Function

    Private Sub BuscarRegistro()
        Dim query = From categoria In tblCategoria
                    Select categoria.nombreCategoria, categoria.unidadesProducto

        tbl = CrearTabla(query)
        DgvRegistros.DataSource = tbl
        DgvRegistros.Refresh()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        BuscarRegistro()
        VerReporte(tbl, "DsCategoria", "reportes\rptUnidadesCategoria.rdlc")
    End Sub
End Class