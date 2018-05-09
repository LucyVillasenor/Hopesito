Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmPrincipal
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UtileriasToolStripMenuItem.Click

    End Sub

    Private Sub RegistroEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroEmpleadosToolStripMenuItem.Click
        frmRegistroEmpleados.ShowDialog()
    End Sub

    Private Sub RegistroProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroProveedoresToolStripMenuItem.Click
        frmRegistroProveedores.ShowDialog()
    End Sub

    Private Sub RegistroArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroArticulosToolStripMenuItem.Click
        frmRegistroArticulos.ShowDialog()
    End Sub

    Private Sub RegistroModelosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroModelosToolStripMenuItem.Click
        frmRegistroModelos.ShowDialog()
    End Sub

    Private Sub RegistroCategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroCategoriasToolStripMenuItem.Click
        frmRegistroCategorias.ShowDialog()
    End Sub

    Private Sub RegistroCompraArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroCompraArticuloToolStripMenuItem.Click
        frmRegistroCompraArticulo.ShowDialog()
    End Sub

    Private Sub RegistroVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroVentasToolStripMenuItem.Click
        frmRegistroVentas.ShowDialog()
    End Sub

    Private Sub ConsultaCompraArticuloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaCompraArticuloToolStripMenuItem.Click
        frmConsultaCompra.ShowDialog()
    End Sub

    Private Sub ConsultaVentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaVentasToolStripMenuItem.Click
        frmConsultaVentas.ShowDialog()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If usuario = "admin" Then
            UsuariosToolStripMenuItem.Visible = True
        Else
            UsuariosToolStripMenuItem.Visible = False
        End If
    End Sub

    Private Sub RegistroUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroUsuariosToolStripMenuItem.Click
        frmUsuarios.ShowDialog()
    End Sub

    Private Sub RegistroDeApartadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroDeApartadoToolStripMenuItem.Click
        frmApartados.ShowDialog()
    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click
        frmConsIndApartado.ShowDialog()
    End Sub

    Private Sub RegistroAbonoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegistroAbonoToolStripMenuItem.Click
        frmAbonos.ShowDialog()
    End Sub

    Private Sub ConsultaAbonoToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmConsultaAbonos.ShowDialog()
    End Sub

    Private Sub ReporteEmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim CONEXION As New SqlConnection("Data Source=.;Initial Catalog=CasaEsther;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTEEMPLEADOS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet1"
        Dim reportes As New ReportDataSource("DataSet1", data.Tables(0))
        frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Victor\Desktop\CasaEstherNuevoUltraMasChidoringo\CasaEstherNuevoChido\CasaEsther\Reportes\ReporteEmpleados.rdlc"
        frmReporte.ReportViewer1.RefreshReport()
        frmReporte.ShowDialog()
        CONEXION.Close()
    End Sub

    Private Sub ReporteArticulosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteArticulosToolStripMenuItem.Click
        Dim CONEXION As New SqlConnection("Data Source=.;Initial Catalog=CasaEsther;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTEARTICULOS", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet2"
        Dim reportes As New ReportDataSource("DataSet2", data.Tables(0))
        frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Victor\Desktop\CasaEstherNuevoUltraMasChidoringo\CasaEstherNuevoChido\CasaEsther\Reportes\ReporteArticulos.rdlc"
        frmReporte.ReportViewer1.RefreshReport()
        frmReporte.ShowDialog()
        CONEXION.Close()
    End Sub

    Private Sub ReporteProveedoresToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ReporteProveedoresToolStripMenuItem1.Click
        Dim CONEXION As New SqlConnection("Data Source=.;Initial Catalog=CasaEsther;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTEPROVEEDORES", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet3"
        Dim reportes As New ReportDataSource("DataSet3", data.Tables(0))
        frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Victor\Desktop\CasaEstherNuevoUltraMasChidoringo\CasaEstherNuevoChido\CasaEsther\Reportes\ReporteProveedores.rdlc"
        frmReporte.ReportViewer1.RefreshReport()
        frmReporte.ShowDialog()
        CONEXION.Close()
    End Sub

    Private Sub ReporteClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReporteClientesToolStripMenuItem.Click
        Dim CONEXION As New SqlConnection("Data Source=.;Initial Catalog=CasaEsther;Integrated security=True")
        Dim cmd As New SqlCommand("REPORTECLIENTES", CONEXION)
        cmd.CommandType = CommandType.StoredProcedure
        Dim adaptador As New SqlDataAdapter(cmd)
        Dim data As New DataSet
        adaptador.Fill(data)
        data.DataSetName = "DataSet4"
        Dim reportes As New ReportDataSource("DataSet4", data.Tables(0))
        frmReporte.ReportViewer1.LocalReport.DataSources.Clear()
        frmReporte.ReportViewer1.LocalReport.DataSources.Add(reportes)
        frmReporte.ReportViewer1.LocalReport.ReportPath = "C:\Users\Victor\Desktop\CasaEstherNuevoUltraMasChidoringo\CasaEstherNuevoChido\CasaEsther\Reportes\ReporteClientes.rdlc"
        frmReporte.ReportViewer1.RefreshReport()
        frmReporte.ShowDialog()
        CONEXION.Close()
    End Sub

    Private Sub CompraDeArticulosPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDeArticulosPorPeriodoToolStripMenuItem.Click
        opcion = "CompraArticulos"
        frmPeriodo.ShowDialog()
    End Sub

    Private Sub CompraDeArticulosPorProveedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CompraDeArticulosPorProveedorToolStripMenuItem.Click
        opcion = "Proveedor"
        frmNombres.ShowDialog()
    End Sub

    Private Sub VentaPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaPorPeriodoToolStripMenuItem.Click
        opcion = "Venta"
        frmPeriodo.ShowDialog()
    End Sub

    Private Sub VentaPorEmpleadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentaPorEmpleadoToolStripMenuItem.Click
        opcion = "Empleado"
        frmNombres.ShowDialog()
    End Sub

    Private Sub ApartadosPorClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosPorClienteToolStripMenuItem.Click
        opcion = "Cliente"
        frmNombres.ShowDialog()
    End Sub

    Private Sub ApartadosPorPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosPorPeriodoToolStripMenuItem.Click
        opcion = "Apartado"
        frmPeriodo.ShowDialog()
    End Sub

    Private Sub ApartadosPorClienteEnUnPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApartadosPorClienteEnUnPeriodoToolStripMenuItem.Click
        opcion = "ClientePeriodo"
        frmNombres.ShowDialog()
    End Sub

    Private Sub SalirToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        End
    End Sub

    Private Sub ResToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackupToolStripMenuItem.Click
        frmBackup.Show()
    End Sub

    Private Sub RestaurarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestaurarToolStripMenuItem.Click
        frmRestauracion.Show()
    End Sub

    Private Sub frmPrincipal_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F1 Then
            System.Diagnostics.Process.Start("C:\Users\Victor\Desktop\CasaEstherNuevoUltraMasChidoringo\CasaEstherNuevoChido\Ayuda.chm")
        End If
    End Sub

    Private Sub TraspasoAHistoricosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TraspasoAHistoricosToolStripMenuItem.Click
        frmHistoricos.ShowDialog()
    End Sub
End Class
