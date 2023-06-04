<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVistaPrevia
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.ProductoMaxSalidasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBValyrianDataSet = New SISTEMAKOJI.DBValyrianDataSet()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New SISTEMAKOJI.DBValyrianDataSetTableAdapters.ProductosTableAdapter()
        Me.DataTable1TableAdapter = New SISTEMAKOJI.DBValyrianDataSetTableAdapters.DataTable1TableAdapter()
        Me.ProductoMaxSalidasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductoMaxSalidasTableAdapter = New SISTEMAKOJI.DBValyrianDataSetTableAdapters.ProductoMaxSalidasTableAdapter()
        CType(Me.ProductoMaxSalidasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBValyrianDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoMaxSalidasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SISTEMAKOJI.rptUnidadesCategoria.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(1062, 673)
        Me.ReportViewer1.TabIndex = 0
        '
        'ProductoMaxSalidasBindingSource1
        '
        Me.ProductoMaxSalidasBindingSource1.DataMember = "ProductoMaxSalidas"
        Me.ProductoMaxSalidasBindingSource1.DataSource = Me.DBValyrianDataSet
        '
        'DBValyrianDataSet
        '
        Me.DBValyrianDataSet.DataSetName = "DBValyrianDataSet"
        Me.DBValyrianDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DBValyrianDataSet
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.DBValyrianDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'ProductoMaxSalidasBindingSource
        '
        Me.ProductoMaxSalidasBindingSource.DataMember = "ProductoMaxSalidas"
        Me.ProductoMaxSalidasBindingSource.DataSource = Me.DBValyrianDataSet
        '
        'ProductoMaxSalidasTableAdapter
        '
        Me.ProductoMaxSalidasTableAdapter.ClearBeforeFill = True
        '
        'frmVistaPrevia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1062, 673)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmVistaPrevia"
        Me.Text = "frmVistaPrevia"
        CType(Me.ProductoMaxSalidasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBValyrianDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoMaxSalidasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DBValyrianDataSet As DBValyrianDataSet
    Friend WithEvents ProductosBindingSource As BindingSource
    Friend WithEvents ProductosTableAdapter As DBValyrianDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents DataTable1BindingSource As BindingSource
    Friend WithEvents DataTable1TableAdapter As DBValyrianDataSetTableAdapters.DataTable1TableAdapter
    Friend WithEvents ProductoMaxSalidasBindingSource As BindingSource
    Friend WithEvents ProductoMaxSalidasBindingSource1 As BindingSource
    Friend WithEvents ProductoMaxSalidasTableAdapter As DBValyrianDataSetTableAdapters.ProductoMaxSalidasTableAdapter
End Class
