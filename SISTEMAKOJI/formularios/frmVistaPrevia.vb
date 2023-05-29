Public Class frmVistaPrevia
    Private Sub frmVistaPrevia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'DBValyrianDataSet.DataTable1' Puede moverla o quitarla según sea necesario.
        Me.DataTable1TableAdapter.Fill(Me.DBValyrianDataSet.DataTable1)
        'TODO: esta línea de código carga datos en la tabla 'DBValyrianDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.DBValyrianDataSet.Productos)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class