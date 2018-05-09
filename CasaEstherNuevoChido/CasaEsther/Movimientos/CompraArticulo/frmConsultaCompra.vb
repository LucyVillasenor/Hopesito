Imports System.Data.SqlClient

Public Class frmConsultaCompra
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader
    Private Sub frmConsultaCompra_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "select * from CompraArticulo"
        lector = comando.ExecuteReader
        While lector.Read
            cmboCompra.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "select * from CompraArticulo"
        lector = comando.ExecuteReader
        While lector.Read
            cmboFactura.Items.Add(lector(3))
        End While
        lector.Close()

        comando.CommandText = "select * from Proveedor"
        lector = comando.ExecuteReader
        While lector.Read
            cmboProveedor.Items.Add(lector(1))
        End While
        lector.Close()
    End Sub

    Private Sub cmboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboProveedor.SelectedIndexChanged
        comando.CommandText = "select * from Proveedor where Nombre = '" & cmboProveedor.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdProveedor.Text = lector(0)
        txtNombre.Text = lector(1)
        txtCiudad.Text = lector(4)
        txtDom.Text = lector(2)
        txtColonia.Text = lector(3)
        txtTel.Text = lector(7)
        lector.Close()
    End Sub

    Private Sub cmboCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboCompra.SelectedIndexChanged
        comando.CommandText = "select * from Apartado where idApartado = '" & cmboCompra.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdProveedor.Text = lector(1)
        lector.Close()

        comando.CommandText = "Select * from  Proveedor where IdProveedor ='" & txtIdProveedor.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdProveedor.Text = lector(0)
        txtNombre.Text = lector(1)
        txtCiudad.Text = lector(4)
        txtDom.Text = lector(2)
        txtColonia.Text = lector(3)
        txtTel.Text = lector(7)
        lector.Close()
    End Sub

    Private Sub cmboFactura_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboFactura.SelectedIndexChanged
        comando.CommandText = "select * from CompraArticulo where Factura = '" & cmboFactura.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdProveedor.Text = lector(1)
        lector.Close()

        comando.CommandText = "Select * from  Proveedor where IdProveedor ='" & txtIdProveedor.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdProveedor.Text = lector(0)
        txtNombre.Text = lector(1)
        txtCiudad.Text = lector(4)
        txtDom.Text = lector(2)
        txtColonia.Text = lector(3)
        txtTel.Text = lector(7)
        lector.Close()
    End Sub

    Private Sub rbFactura_CheckedChanged(sender As Object, e As EventArgs) Handles rbFactura.CheckedChanged
        rbFactura.Enabled = True
        cmboFactura.Enabled = True
        rbProveedor.Enabled = False
        cmboProveedor.Enabled = False
        rbPeriodo.Enabled = False
        lblA.Enabled = False
        lblDe.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaInicio.Enabled = False
        btnAceptar.Enabled = True
        rbCompra.Enabled = False
        gbProveedor.Enabled = False
    End Sub

    Private Sub rbProveedor_CheckedChanged(sender As Object, e As EventArgs) Handles rbProveedor.CheckedChanged
        rbProveedor.Enabled = True
        cmboProveedor.Enabled = True
        rbFactura.Enabled = False
        cmboFactura.Enabled = False
        rbPeriodo.Enabled = False
        lblA.Enabled = False
        lblDe.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaFin.Enabled = False
        btnAceptar.Enabled = True
        gbProveedor.Enabled = True
        rbCompra.Enabled = False
    End Sub

    Private Sub rbPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbPeriodo.CheckedChanged
        rbPeriodo.Enabled = True
        lblA.Enabled = True
        lblDe.Enabled = True
        dtpFechaInicio.Enabled = True
        dtpFechaFin.Enabled = True
        rbFactura.Enabled = False
        cmboFactura.Enabled = False
        rbProveedor.Enabled = False
        cmboProveedor.Enabled = False
        btnAceptar.Enabled = True
        rbCompra.Enabled = False
        gbProveedor.Enabled = False
    End Sub

    Private Sub rbIdCompra_CheckedChanged(sender As Object, e As EventArgs) Handles rbCompra.CheckedChanged
        cmboCompra.Enabled = True
        rbCompra.Enabled = True
        rbFactura.Enabled = False
        cmboFactura.Enabled = False
        rbProveedor.Enabled = False
        cmboProveedor.Enabled = False
        rbPeriodo.Enabled = False
        lblA.Enabled = False
        lblDe.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaInicio.Enabled = False
        btnAceptar.Enabled = True
        gbProveedor.Enabled = False
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgConsultaCompra.Rows.Clear()
        If rbFactura.Checked Then
            comando.CommandText = "select DetCompraArticulo.IdArticulo, m.Descripcion, DetCompraArticulo.Cantidad, DetCompraArticulo.Costo, ca.Subtotal, ca.Fecha from DetCompraArticulo inner join CompraArticulo ca on ca.IdCompra = DetCompraArticulo.IdCompra inner join Articulo a on a.IdArticulo = DetCompraArticulo.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo where ca.Factura = '" & cmboFactura.Text & "'"
            lector = comando.ExecuteReader()
            While lector.Read
                dgConsultaCompra.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
        End If
        lector.Close()


        If rbProveedor.Checked Then
            comando.CommandText = "select DetCompraArticulo.IdArticulo, m.Descripcion, DetCompraArticulo.Cantidad, DetCompraArticulo.Costo, ca.Subtotal, ca.Fecha from DetCompraArticulo inner join CompraArticulo ca on ca.IdCompra = DetCompraArticulo.IdCompra inner join Articulo a on a.IdArticulo = DetCompraArticulo.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo where ca.IdProveedor = '" & txtIdProveedor.Text & "'"
            lector = comando.ExecuteReader()
            While lector.Read
                dgConsultaCompra.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
        End If
        lector.Close()


        If rbPeriodo.Checked Then
            comando.CommandText = "select DetCompraArticulo.IdArticulo, m.Descripcion, DetCompraArticulo.Cantidad, DetCompraArticulo.Costo, ca.Subtotal, ca.Fecha from DetCompraArticulo inner join CompraArticulo ca on ca.IdCompra = DetCompraArticulo.IdCompra inner join Articulo a on a.IdArticulo = DetCompraArticulo.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo where ca.Fecha between '" & dtpFechaInicio.Value.Date & "' and '" & dtpFechaFin.Value.Date & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgConsultaCompra.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
            lector.Close()
        End If

        If rbCompra.Checked Then
            comando.CommandText = "select DetCompraArticulo.idArticulo, m.Descripcion, DetCompraArticulo.Cantidad, DetCompraArticulo.Costo, ca.Subtotal, ca.Fecha from DetCompraArticulo inner join CompraArticulo ca on ca.IdCompra = DetCompraArticulo.IdCompra inner join Articulo a on a.IdArticulo = DetCompraArticulo.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo where ca.idCompra = '" & cmboCompra.Text & "'"
            lector = comando.ExecuteReader()
            While lector.Read
                dgConsultaCompra.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5))
            End While
        End If
        lector.Close()

        rbFactura.Enabled = True
        cmboFactura.Enabled = False
        rbPeriodo.Enabled = True
        lblA.Enabled = False
        lblDe.Enabled = False
        dtpFechaInicio.Enabled = False
        dtpFechaInicio.Enabled = False
        rbProveedor.Enabled = True
        cmboProveedor.Enabled = False
        rbCompra.Enabled = True
        cmboCompra.Enabled = False
        rbCompra.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Close()
    End Sub

End Class