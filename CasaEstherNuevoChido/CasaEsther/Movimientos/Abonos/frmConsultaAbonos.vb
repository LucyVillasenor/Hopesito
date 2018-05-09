Imports System.Data.SqlClient
Public Class frmConsultaAbonos
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader
    Dim cliente As Integer
    Private Sub frnConsultaApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CasaEstherDataSet3.Abono' Puede moverla o quitarla según sea necesario.
        Me.AbonoTableAdapter1.Fill(Me.CasaEstherDataSet3.Abono)
        'TODO: esta línea de código carga datos en la tabla 'CasaEstherDataSet2.Apartado' Puede moverla o quitarla según sea necesario.
        Me.ApartadoTableAdapter.Fill(Me.CasaEstherDataSet2.Apartado)
        conexion.Open()

    End Sub

    Private Sub rbArticulo_CheckedChanged(sender As Object, e As EventArgs) Handles rbArticulo.CheckedChanged
        cmboArticulo.Visible = True
        dtpFechaInicio.Visible = False
        lblA.Visible = False
        lblA.Visible = False
        dtpFechaFin.Visible = False
    End Sub

    Private Sub rbPeriodo_CheckedChanged(sender As Object, e As EventArgs) Handles rbPeriodo.CheckedChanged
        cmboArticulo.Visible = False
        dtpFechaInicio.Visible = True
        lblA.Visible = True
        lblA.Visible = True
        dtpFechaFin.Visible = True
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        dgConsultaAbonos.Rows.Clear()

        If rbArticulo.Checked Then
            comando.CommandText = "select Abono.IdAbono, Apartado.NomCliente, Abono.Fecha, Abono.IdArticulo, Modelo.descripcion, Abono.Cantidad, DetApartado.Subtotal from Abono inner join Articulo on Articulo.IdArticulo = Abono.IdArticulo inner join  Modelo on Modelo.IdModelo = Articulo.IdModelo inner join DetApartado on DetApartado.IdApartado = Abono.IdApartado inner join Apartado on Apartado.IdApartado = Abono.IdApartado where Abono.IdArticulo = " & Val(cmboArticulo.Text)
            lector = comando.ExecuteReader()
            While lector.Read
                dgConsultaAbonos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While
            lector.Close()

        ElseIf rbPeriodo.Checked Then
            comando.CommandText = "select Abono.IdAbono, Apartado.NomCliente, Abono.Fecha, Abono.IdArticulo, Modelo.descripcion, Abono.Cantidad, DetApartado.Subtotal from Abono inner join Articulo on Articulo.IdArticulo = Abono.IdArticulo inner join  Modelo on Modelo.IdModelo = Articulo.IdModelo inner join DetApartado on DetApartado.IdApartado = Abono.IdApartado inner join Apartado on Apartado.IdApartado = Abono.IdApartado where Abono.fecha between '" & dtpFechaInicio.Value.Date & "' and '" & dtpFechaFin.Value.Date & "'"
            lector = comando.ExecuteReader
            While lector.Read
                dgConsultaAbonos.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6))
            End While

            lector.Close()
        End If
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Close()
    End Sub
End Class