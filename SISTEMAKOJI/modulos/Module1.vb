Imports Microsoft.Reporting.WinForms

Module Module1
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
End Module
