Imports Microsoft.Reporting.WinForms

Public Class frmRptProdCategoria
    Dim tblProd As New DBValyrianDataSet.DataTable1DataTable
    Dim rptProductos As New DBValyrianDataSetTableAdapters.DataTable1TableAdapter
    Dim tbl As New DataTable

    Private Sub LlenarRegistros()
        rptProductos.Fill(tblProd)
        DgvRegistros.DataSource = tblProd
        DgvRegistros.Refresh()

    End Sub

    Private Sub frmRptProdCategoria_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LlenarRegistros()
    End Sub

    Private Function CrearTabla(query) As DataTable
        Dim tbl As DataTable = New DataTable("tblProd")
        Dim fila As DataRow

        tbl.Columns.Add("nombreProducto")
        tbl.Columns.Add("precioProducto")
        tbl.Columns.Add("unidadesProducto")
        tbl.Columns.Add("unidadMedidaProducto")
        tbl.Columns.Add("descripcionProducto")
        tbl.Columns.Add("nombreCategoria")

        For Each prod In query
            fila = tbl.NewRow()
            fila("nombreProducto") = prod.nombreProducto
            fila("precioProducto") = prod.precioProducto
            fila("unidadesProducto") = prod.unidadesProducto
            fila("unidadMedidaProducto") = prod.unidadMedidaProducto
            fila("descripcionProducto") = prod.descripcionProducto
            fila("nombreCategoria") = prod.nombreCategoria
            tbl.Rows.Add(fila)
        Next
        Return tbl
    End Function

    Private Sub BuscarRegistro()
        Dim dato As String = txtDato.Text & "*"
        Dim campo As String = "prod.nombreProducto"
        Dim query = From prod In tblProd
                    Select prod.nombreProducto, prod.precioProducto, prod.unidadesProducto, prod.unidadMedidaProducto, prod.descripcionProducto, prod.nombreCategoria

        Select Case cbxCampo.SelectedIndex
            Case -1
                query = From prod In tblProd Where prod.nombreCategoria Like dato
                        Select prod.nombreProducto, prod.precioProducto, prod.unidadesProducto, prod.unidadMedidaProducto, prod.descripcionProducto, prod.nombreCategoria
            Case 0
                query = From prod In tblProd Where prod.nombreCategoria Like dato
                        Select prod.nombreProducto, prod.precioProducto, prod.unidadesProducto, prod.unidadMedidaProducto, prod.descripcionProducto, prod.nombreCategoria
            Case 1
                query = From prod In tblProd Where prod.nombreProducto Like dato
                        Select prod.nombreProducto, prod.precioProducto, prod.unidadesProducto, prod.unidadMedidaProducto, prod.descripcionProducto, prod.nombreCategoria
        End Select

        tbl = CrearTabla(query)
        DgvRegistros.DataSource = tbl
        DgvRegistros.Refresh()
    End Sub

    Sub VerReporte(ByVal t As DataTable, ByVal nombreDS As String, nombreRpt As String)
        Try
            Dim rpt As New ReportDataSource(nombreDS, t)
            With frmVistaPrevia
                .ReportViewer1.LocalReport.DataSources.Clear()
                .ReportViewer1.LocalReport.DataSources.Add(rpt)
                .ReportViewer1.LocalReport.ReportPath = nombreRpt
                .ReportViewer1.Refresh()
                .Show()
            End With
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        BuscarRegistro()
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        'VerReporte(tbl, "DSReporte", "C:\Users\MSI DRAGON\source\repos\ValryanSystem\SISTEMAKOJI\reportes\rptProductos.rdlc")'
        'frmVistaPrevia.Show()'
        'VerReporte(tbl, "DsReporte", "reportes\rptProductos.rdlc")'
        VerReporte(tbl, "DataSet1", "reportes\rptProductos.rdlc")
    End Sub
End Class