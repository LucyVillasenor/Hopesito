Imports System.Data.SqlClient
Public Class frmConsultaVentas
    Dim conexion As New SqlConnection("Data Source = .; Initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader
    Private Sub frmConsultaVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CasaEstherDataSet4.Empleado' Puede moverla o quitarla según sea necesario.
        Me.EmpleadoTableAdapter.Fill(Me.CasaEstherDataSet4.Empleado)
        'TODO: esta línea de código carga datos en la tabla 'CasaEstherDataSet4.Venta' Puede moverla o quitarla según sea necesario.
        Me.VentaTableAdapter.Fill(Me.CasaEstherDataSet4.Venta)
        conexion.Open()
    End Sub

    Private Sub rbEmpleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbEmpleado.CheckedChanged
        cmboEmpleado.Visible = True
        cmboIdVenta.Visible = False
        dtpFechaInicio.Visible = False
        lblDe.Visible = False
        lblA.Visible = False
        dtpFechaFin.Visible = False
    End Sub

    Private Sub rbPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbPeriodo.CheckedChanged
        cmboEmpleado.Visible = False
        cmboIdVenta.Visible = False
        dtpFechaInicio.Visible = True
        lblDe.Visible = True
        lblA.Visible = True
        dtpFechaFin.Visible = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgVenta.Rows.Clear()
        Dim suma As Double
        If rbEmpleado.Checked = True Then
            suma = 0
            comando.CommandText = "select DetalleVenta.IdArticulo, m.Descripcion, DetalleVenta.Cantidad, DetalleVenta.Precio, v.Fecha from DetalleVenta inner join Venta v on v.IdVenta = DetalleVenta.IdVenta inner join Articulo a on a.IdArticulo = DetalleVenta.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo inner Join Empleado on Empleado.IdEmpleado = v.IdEmpleado where Empleado.Nombre = '" & cmboEmpleado.Text & "'"
            lector = comando.ExecuteReader()
            While lector.Read
                dgVenta.Rows.Add(lector(0), lector(1), lector(2), lector(3), (lector(2) * lector(3)), lector(4))
            End While
            lector.Close()
            For i = 0 To dgVenta.Rows.Count - 1
                suma = suma + dgVenta.Item(4, i).Value
            Next
            txtTotal.Text = suma
        ElseIf rbIdVenta.Checked = True Then
            suma = 0
            comando.CommandText = "select DetalleVenta.IdArticulo, m.Descripcion, DetalleVenta.Cantidad, DetalleVenta.Precio, v.Fecha from DetalleVenta inner join Venta v on v.IdVenta = DetalleVenta.IdVenta inner join Articulo a on a.IdArticulo = DetalleVenta.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo where v.IdVenta = " & cmboIdVenta.Text
            lector = comando.ExecuteReader()
            While lector.Read
                dgVenta.Rows.Add(lector(0), lector(1), lector(2), lector(3), (lector(2) * lector(3)), lector(4))
            End While
            lector.Close()
            For i = 0 To dgVenta.Rows.Count - 1
                suma = suma + dgVenta.Item(4, i).Value
            Next
            txtTotal.Text = suma
        ElseIf rbPeriodo.Checked = True Then
            suma = 0
            Dim fi As Date = dtpFechaInicio.Value.Date
            Dim ff As Date = dtpFechaFin.Value.Date
            comando.CommandText = "select DetalleVenta.IdArticulo, m.Descripcion, DetalleVenta.Cantidad, DetalleVenta.Precio, v.Fecha from DetalleVenta inner join Venta v on v.IdVenta = DetalleVenta.IdVenta inner join Articulo a on a.IdArticulo = DetalleVenta.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo where v.Fecha >= '" & fi & "' and v.Fecha <= '" & ff & "'"
            lector = comando.ExecuteReader()
            While lector.Read
                dgVenta.Rows.Add(lector(0), lector(1), lector(2), lector(3), (lector(2) * lector(3)), lector(4))
            End While
            lector.Close()
            For i = 0 To dgVenta.Rows.Count - 1
                suma = suma + dgVenta.Item(4, i).Value
            Next
            txtTotal.Text = suma
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Me.Dispose()
    End Sub

    Private Sub cmboEmpleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboEmpleado.SelectedIndexChanged
        comando.CommandText = "select * from Empleado where Nombre = '" & cmboEmpleado.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdEmpleado.Text = lector(0)
        txtNombre.Text = lector(1)
        txtCiudad.Text = lector(4)
        txtDom.Text = lector(2)
        txtColonia.Text = lector(3)
        txtTel.Text = lector(6)
        lector.Close()
    End Sub

    Private Sub rbIdVenta_CheckedChanged(sender As Object, e As EventArgs) Handles rbIdVenta.CheckedChanged
        cmboEmpleado.Visible = False
        cmboIdVenta.Visible = True
        dtpFechaInicio.Visible = False
        lblDe.Visible = False
        lblA.Visible = False
        dtpFechaFin.Visible = False
    End Sub
End Class