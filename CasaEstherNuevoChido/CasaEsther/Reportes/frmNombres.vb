Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmNombres
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader

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

    Private Sub frmNombres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        cmboNombre.Items.Clear()
        cmboNombre.Text = ""
        If opcion = "Proveedor" Then
            comando.CommandText = "select * from Proveedor"
            lector = comando.ExecuteReader
            While lector.Read
                cmboNombre.Items.Add(lector(1))
            End While
            lector.Close()
        ElseIf opcion = "Cliente" Then
            comando.CommandText = "select * from Cliente"
            lector = comando.ExecuteReader
            While lector.Read
                cmboNombre.Items.Add(lector(1))
            End While
            lector.Close()
        ElseIf opcion = "ClientePeriodo" Then
            comando.CommandText = "select * from Cliente"
            lector = comando.ExecuteReader
            While lector.Read
            cmboNombre.Items.Add(lector(1))
            End While
            lector.Close()
        End If
    End Sub

    Private Sub cmboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboNombre.SelectedIndexChanged
        If opcion = "Proveedor" Then
            comando.CommandText = "Select * from Proveedor where Nombre ='" & cmboNombre.Text & "'"
            lector = comando.ExecuteReader()
            lector.Read()
            id = lector(0)
            nombre = lector(1)
            dom = lector(2)
            tel = lector(7)
            lector.Close()
        ElseIf opcion = "Cliente" Then
            comando.CommandText = "Select * from Cliente where nombre ='" & cmboNombre.Text & "'"
            lector = comando.ExecuteReader()
            lector.Read()
            id = lector(0)
            nombre = lector(1)
            dom = lector(3)
            tel = lector(5)
            lector.Close()
        ElseIf opcion = "ClientePeriodo" Then
            comando.CommandText = "Select * from Cliente where nombre ='" & cmboNombre.Text & "'"
            lector = comando.ExecuteReader()
            lector.Read()
            id = lector(0)
            nombre = lector(1)
            dom = lector(3)
            tel = lector(5)
            lector.Close()
        End If

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Try
            If opcion = "Proveedor" Then
                Dim pro As String
                pro = id
                Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
                Dim comando As New SqlCommand("ReporteCompraPorProveedor", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = conexion
                adaptador.SelectCommand.CommandText = "ReporteCompraPorProveedor"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim p1 = New SqlParameter("@proveedor", SqlDbType.Int)
                p1.Direction = ParameterDirection.Input
                p1.Value = pro
                adaptador.SelectCommand.Parameters.Add(p1)
                Dim dataSet As New DataSet
                adaptador.Fill(dataSet)
                dataSet.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataSet.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataSet.Tables(0)
                Dim e1 As New ReportParameter("Nombre", nombre)
                Dim e2 As New ReportParameter("Domicilio", dom)
                Dim e3 As New ReportParameter("Telefono", tel)
                frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
                frmReporte.ReportViewer1.LocalReport.DataSources.Add(datasource)
                'cambiar la direccion'
                frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Victor\Desktop\CasaEstherNuevoUltraMasChidoringo\CasaEstherNuevoChido\CasaEsther\Reportes\ComprasPorProveedor.rdlc"
                frmReporte.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {e1, e2, e3})
                frmReporte.ReportViewer1.RefreshReport()
                frmReporte.Show()
                conexion.Close()
            ElseIf opcion = "Cliente" Then
                Dim pro As String
                pro = id
                Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
                Dim comando As New SqlCommand("ReporteApartadoPorCliente", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = conexion
                adaptador.SelectCommand.CommandText = "ReporteApartadoPorCliente"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim p1 = New SqlParameter("@cliente", SqlDbType.Int)
                p1.Direction = ParameterDirection.Input
                p1.Value = pro
                adaptador.SelectCommand.Parameters.Add(p1)
                Dim dataSet As New DataSet
                adaptador.Fill(dataSet)
                dataSet.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataSet.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataSet.Tables(0)
                Dim e1 As New ReportParameter("Nombre", nombre)
                Dim e2 As New ReportParameter("Domicilio", dom)
                Dim e3 As New ReportParameter("Telefono", tel)
                frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
                frmReporte.ReportViewer1.LocalReport.DataSources.Add(datasource)
                'cambiar la direccion'
                frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Victor\Desktop\CasaEstherNuevoUltraMasChidoringo\CasaEstherNuevoChido\CasaEsther\Reportes\ApartadosPorCliente.rdlc"
                frmReporte.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {e1, e2, e3})
                frmReporte.ReportViewer1.RefreshReport()
                frmReporte.Show()
                conexion.Close()
            ElseIf opcion = "Empleado" Then
                Dim pro As String
                pro = id
                Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
                Dim comando As New SqlCommand("ReporteVentaPorEmpleado", conexion)
                comando.CommandType = CommandType.StoredProcedure
                Dim adaptador As New SqlDataAdapter(comando)
                adaptador.SelectCommand = New SqlCommand
                adaptador.SelectCommand.Connection = conexion
                adaptador.SelectCommand.CommandText = "ReporteVentaPorEmpleado"
                adaptador.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim p1 = New SqlParameter("@empleado", SqlDbType.Int)
                p1.Direction = ParameterDirection.Input
                p1.Value = pro
                adaptador.SelectCommand.Parameters.Add(p1)
                Dim dataSet As New DataSet
                adaptador.Fill(dataSet)
                dataSet.DataSetName = "DataSet1"
                Dim datasource As New ReportDataSource("DataSet1", dataSet.Tables(0))
                datasource.Name = "DataSet1"
                datasource.Value = dataSet.Tables(0)
                Dim e1 As New ReportParameter("Nombre", nombre)
                Dim e2 As New ReportParameter("Domicilio", dom)
                Dim e3 As New ReportParameter("Telefono", tel)
                frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
                frmReporte.ReportViewer1.LocalReport.DataSources.Add(datasource)
                'cambiar la direccion'
                frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Victor\Desktop\CasaEstherNuevoUltraMasChidoringo\CasaEstherNuevoChido\CasaEsther\Reportes\VentaPorEmpleado.rdlc"
                frmReporte.ReportViewer1.LocalReport.SetParameters(New ReportParameter() {e1, e2, e3})
                frmReporte.ReportViewer1.RefreshReport()
                frmReporte.Show()
                conexion.Close()
            ElseIf opcion = "ClientePeriodo" Then
                opcion = "ApartadoCliente"
                frmPeriodo.ShowDialog()
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
    Private Sub frmNombes_Closing(sender As Object, e As EventArgs) Handles MyBase.Closing
        conexion.Close()
    End Sub

End Class