Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmPeriodo

    Public Sub pasarBitacora(nombreError As String, ex As Exception, nomLinea As Integer)
        Dim conexion2 As New SqlConnection("Data Source='.'; initial Catalog = 'Bitacora'; Integrated security = true")
        Dim comando2 As SqlCommand = conexion2.CreateCommand()
        conexion2.Open()
        comando2.CommandText = "select count(*) from Bitacora"
        Dim n As Integer = comando2.ExecuteScalar + 1
        comando2.CommandText = "insert into Bitacora values (" & n & ",'" & nombreError & "'," & "@error" & ",'" & Me.Name & "', " & nomLinea & ",'" & usuario & "'," & "GETDATE()" & ")"
        comando2.Parameters.Add("@error", SqlDbType.NVarChar).Value = ex.Message
        comando2.ExecuteNonQuery()
        conexion2.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If opcion = "CompraArticulos" Then
                Dim f1 As String
                Dim f2 As String
                f1 = dtpFechaInicio.Value.Day & "/" & dtpFechaInicio.Value.Month & "/" & dtpFechaInicio.Value.Year
                f2 = dtpFechaFin.Value.Day & "/" & dtpFechaFin.Value.Month & "/" & dtpFechaFin.Value.Year
                Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
                Dim comando As New SqlCommand("ReporteCompraPorPeriodo", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = conexion
                adaptador.SelectCommand.CommandText = "ReporteCompraPorPeriodo"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim p1 = New SqlParameter("@fecha1", SqlDbType.Date)
                Dim p2 = New SqlParameter("@fecha2", SqlDbType.Date)
                p1.Direction = ParameterDirection.Input
                p2.Direction = ParameterDirection.Input
                p1.Value = CDate(f1)
                p2.Value = CDate(f2)
                adaptador.SelectCommand.Parameters.Add(p1)
                adaptador.SelectCommand.Parameters.Add(p2)
                Dim dataSet As New DataSet
                adaptador.Fill(dataSet)
                dataSet.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataSet.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataSet.Tables(0)
                Dim e1 As New ReportParameter("F1", f1)
                Dim e2 As New ReportParameter("F2", f2)
                frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
                frmReporte.ReportViewer1.LocalReport.DataSources.Add(datasource)
                'Agregar direccion--------------------'
                frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Lucyy\Documents\GitHub\Hopesito\CasaEstherNuevoChido\CasaEsther\Reportes\CompraPorPeriodo.rdlc"
                frmReporte.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {e1, e2})
                frmReporte.ReportViewer1.RefreshReport()
                frmReporte.Show()
                conexion.Close()

            ElseIf opcion = "Apartado" Then
                Dim f1 As String
                Dim f2 As String
                f1 = dtpFechaInicio.Value.Day & "/" & dtpFechaInicio.Value.Month & "/" & dtpFechaInicio.Value.Year
                f2 = dtpFechaFin.Value.Day & "/" & dtpFechaFin.Value.Month & "/" & dtpFechaFin.Value.Year
                Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
                Dim comando As New SqlCommand("ReporteApartadoPorPeriodo", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = conexion
                adaptador.SelectCommand.CommandText = "ReporteApartadoPorPeriodo"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim p1 = New SqlParameter("@fecha1", SqlDbType.Date)
                Dim p2 = New SqlParameter("@fecha2", SqlDbType.Date)
                p1.Direction = ParameterDirection.Input
                p2.Direction = ParameterDirection.Input
                p1.Value = CDate(f1)
                p2.Value = CDate(f2)
                adaptador.SelectCommand.Parameters.Add(p1)
                adaptador.SelectCommand.Parameters.Add(p2)
                Dim dataSet As New DataSet
                adaptador.Fill(dataSet)
                dataSet.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataSet.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataSet.Tables(0)
                Dim e1 As New ReportParameter("F1", f1)
                Dim e2 As New ReportParameter("F2", f2)
                frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
                frmReporte.ReportViewer1.LocalReport.DataSources.Add(datasource)
                'Agregar direccion--------------------'
                frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Lucyy\Documents\GitHub\Hopesito\CasaEstherNuevoChido\CasaEsther\Reportes\ApartadoPorPeriodo.rdlc"
                frmReporte.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {e1, e2})
                frmReporte.ReportViewer1.RefreshReport()
                frmReporte.Show()
                conexion.Close()
            ElseIf opcion = "Venta" Then
                Dim f1 As String
                Dim f2 As String
                f1 = dtpFechaInicio.Value.Day & "/" & dtpFechaInicio.Value.Month & "/" & dtpFechaInicio.Value.Year
                f2 = dtpFechaFin.Value.Day & "/" & dtpFechaFin.Value.Month & "/" & dtpFechaFin.Value.Year
                Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
                Dim comando As New SqlCommand("ReporteVentaPorPeriodo", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = conexion
                adaptador.SelectCommand.CommandText = "ReporteVentaPorPeriodo"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim p1 = New SqlParameter("@fecha1", SqlDbType.Date)
                Dim p2 = New SqlParameter("@fecha2", SqlDbType.Date)
                p1.Direction = ParameterDirection.Input
                p2.Direction = ParameterDirection.Input
                p1.Value = CDate(f1)
                p2.Value = CDate(f2)
                adaptador.SelectCommand.Parameters.Add(p1)
                adaptador.SelectCommand.Parameters.Add(p2)
                Dim dataSet As New DataSet
                adaptador.Fill(dataSet)
                dataSet.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataSet.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataSet.Tables(0)
                Dim e1 As New ReportParameter("F1", f1)
                Dim e2 As New ReportParameter("F2", f2)
                frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
                frmReporte.ReportViewer1.LocalReport.DataSources.Add(datasource)
                'Agregar su direccion --------------------'
                frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Lucyy\Documents\GitHub\Hopesito\CasaEstherNuevoChido\CasaEsther\Reportes\VentaPorPeriodo.rdlc"
                frmReporte.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {e1, e2})
                frmReporte.ReportViewer1.RefreshReport()
                frmReporte.Show()
                conexion.Close()
            ElseIf opcion = "ApartadoCliente" Then
                Dim pro As String
                pro = id
                Dim f1 As String
                Dim f2 As String
                f1 = dtpFechaInicio.Value.Day & "/" & dtpFechaInicio.Value.Month & "/" & dtpFechaInicio.Value.Year
                f2 = dtpFechaFin.Value.Day & "/" & dtpFechaFin.Value.Month & "/" & dtpFechaFin.Value.Year
                Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
                Dim comando As New SqlCommand("ReporteApartadoPorClienteEnUnPeriodo", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = conexion
                adaptador.SelectCommand.CommandText = "ReporteApartadoPorClienteEnUnPeriodo"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim p1 = New SqlParameter("@fecha1", SqlDbType.Date)
                Dim p2 = New SqlParameter("@fecha2", SqlDbType.Date)
                Dim p3 = New SqlParameter("@cliente", SqlDbType.Int)
                p1.Direction = ParameterDirection.Input
                p2.Direction = ParameterDirection.Input
                p3.Direction = ParameterDirection.Input
                p1.Value = CDate(f1)
                p2.Value = CDate(f2)
                p3.Value = pro
                adaptador.SelectCommand.Parameters.Add(p1)
                adaptador.SelectCommand.Parameters.Add(p2)
                adaptador.SelectCommand.Parameters.Add(p3)
                Dim dataSet As New DataSet
                adaptador.Fill(dataSet)
                dataSet.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataSet.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataSet.Tables(0)
                Dim e1 As New ReportParameter("F1", f1)
                Dim e2 As New ReportParameter("F2", f2)
                Dim e3 As New ReportParameter("Nombre", nombre)
                Dim e4 As New ReportParameter("Domicilio", dom)
                Dim e5 As New ReportParameter("Telefono", tel)
                frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
                frmReporte.ReportViewer1.LocalReport.DataSources.Add(datasource)
                'Agregar direccion--------------------'
                frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Lucyy\Documents\GitHub\Hopesito\CasaEstherNuevoChido\CasaEsther\Reportes\ApartadoPorClienteEnUnPeriodo.rdlc"
                frmReporte.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {e1, e2, e3, e4, e5})
                frmReporte.ReportViewer1.RefreshReport()
                frmReporte.Show()
                conexion.Close()
            End If
        Catch ex As Exception
            MsgBox("Error de Reporte")
            Dim nombreError As String = "Error de reporte"
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            Dim frame = st.GetFrame(st.FrameCount - 1)
            Dim nomLinea As String = frame.GetFileLineNumber()
            pasarBitacora(nombreError, ex, nomLinea)
        End Try
    End Sub
End Class