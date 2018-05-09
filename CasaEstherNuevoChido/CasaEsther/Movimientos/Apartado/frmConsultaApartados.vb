Imports System.Data.SqlClient
Public Class frmConsIndApartado
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader
    Private Sub frnConsultaApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "select * from Cliente"
        lector = comando.ExecuteReader
        While lector.Read
            cmboNombre.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "select * from Apartado"
        lector = comando.ExecuteReader
        While lector.Read
            cmboIdCompra.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

    Private Sub cmboNombre_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboNombre.SelectedIndexChanged
        comando.CommandText = "Select * from  Cliente where Nombre ='" & cmboNombre.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdCliente.Text = lector(0)
        txtNombre.Text = lector(1)
        txtCiudad.Text = lector(2)
        txtDom.Text = lector(3)
        txtColonia.Text = lector(4)
        txtTel.Text = lector(5)
        txtSaldo.Text = lector(6)
        lector.Close()
    End Sub

    Private Sub cmboIdCompra_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboIdCompra.SelectedIndexChanged
        comando.CommandText = "select * from Apartado where idApartado = '" & cmboIdCompra.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdCliente.Text = lector(1)
        lector.Close()

        comando.CommandText = "Select * from  Cliente where idCliente ='" & txtIdCliente.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdCliente.Text = lector(0)
        txtNombre.Text = lector(1)
        txtCiudad.Text = lector(2)
        txtDom.Text = lector(3)
        txtColonia.Text = lector(4)
        txtTel.Text = lector(5)
        txtSaldo.Text = lector(6)
        lector.Close()
    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        cmboNombre.Enabled = True
        rbPeriodo.Enabled = False
        lblA.Enabled = False
        lblDe.Enabled = False
        dtpFechaFin.Enabled = False
        dtpFechaInicio.Enabled = False
        cmboIdCompra.Enabled = False
        btnAceptar.Enabled = True
    End Sub

    Private Sub rbPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbPeriodo.CheckedChanged
        rbNombre.Enabled = False
        cmboNombre.Enabled = False
        lblA.Enabled = True
        lblDe.Enabled = True
        dtpFechaFin.Enabled = True
        dtpFechaInicio.Enabled = True
        btnAceptar.Enabled = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgConsultaApartados.Rows.Clear()
        If rbNombre.Checked Then
            comando.CommandText = "select DetApartado.IdArticulo, m.Descripcion, DetApartado.Cantidad, ap.Total, ap.Fecha from DetApartado inner join Apartado ap on ap.IdApartado = DetApartado.IdApartado inner join Articulo a on a.IdArticulo = DetApartado.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo where ap.IdCliente = '" & txtIdCliente.Text & "'"
            lector = comando.ExecuteReader()
            While lector.Read
                dgConsultaApartados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
        End If
        lector.Close()

        If rbPeriodo.Checked Then
            comando.CommandText = "select DetApartado.IdArticulo, m.Descripcion, DetApartado.Cantidad, ap.Total, ap.Fecha from DetApartado inner join Apartado ap on ap.IdApartado = DetApartado.IdApartado inner join Articulo a on a.IdArticulo = DetApartado.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo where  ap.Fecha between '" & dtpFechaInicio.Value.Date & "' and '" & dtpFechaFin.Value.Date & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgConsultaApartados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
            lector.Close()
        End If

        If Compra.Checked Then
            comando.CommandText = "select DetApartado.IdArticulo, m.Descripcion, DetApartado.Cantidad, ap.Total, ap.Fecha from DetApartado inner join Apartado ap on ap.IdApartado = DetApartado.IdApartado inner join Articulo a on a.IdArticulo = DetApartado.IdArticulo inner join Modelo m on m.IdModelo = a.IdModelo where ap.IdApartado = '" & cmboIdCompra.Text & "'"
            lector = comando.ExecuteReader()
            While lector.Read
                dgConsultaApartados.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4))
            End While
        End If
        lector.Close()

        rbNombre.Enabled = True
        cmboNombre.Enabled = False
        rbPeriodo.Enabled = True
        lblA.Enabled = False
        lblDe.Enabled = False
        dtpFechaFin.Enabled = False
        dtpFechaInicio.Enabled = False
        cmboIdCompra.Enabled = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Close()
    End Sub

    Private Sub rbIdCompra_CheckedChanged(sender As Object, e As EventArgs) Handles Compra.CheckedChanged
        cmboNombre.Enabled = False
        rbPeriodo.Enabled = False
        lblA.Enabled = False
        lblDe.Enabled = False
        dtpFechaFin.Enabled = False
        dtpFechaInicio.Enabled = False
        btnAceptar.Enabled = True
        cmboIdCompra.Enabled = True
    End Sub


End Class