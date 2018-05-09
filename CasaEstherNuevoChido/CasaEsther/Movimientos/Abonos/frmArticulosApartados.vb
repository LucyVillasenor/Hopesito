Imports System.Data.SqlClient
Public Class frmArticulosApartados
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader
    Private Sub frmArticulosApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        txtIdApartado.Text = idApartado
        dtpFecha.Value = fecha
        comando.CommandText = "Select da.IdArticulo, m.Descripcion, da.Precio, da.Cantidad From DetApartado da inner Join Articulo a on a.IdArticulo = da.IdArticulo inner Join Modelo m on m.IdModelo = a.IdModelo Where da.IdApartado = " & idApartado
        lector = comando.ExecuteReader()
        While lector.Read()
            dgArticulos.Rows.Add(lector(0), lector(1), lector(2), lector(3))
        End While
        lector.Close()
        txtTotal.Text = total
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        dgArticulos.Rows.Clear()
        conexion.Close()
        Close()
    End Sub

End Class