Imports System.Data.SqlClient
Public Class frmRegistroArticulos
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim transaction As SqlTransaction
    Dim lector As SqlDataReader
    Dim idModelo As Integer
    Private Sub Articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "Select * from Modelo"
        lector = comando.ExecuteReader()
        While lector.Read()
            cmbModelo.Items.Add(lector(2))
        End While
        lector.Close()

        comando.CommandText = "Select * from Articulo"
        lector = comando.ExecuteReader()
        While lector.Read()
            dgArticulo.Rows.Add(lector(0), lector(1), lector(2), lector(3), lector(4), lector(5), lector(6), lector(7), lector(8), lector(9))
        End While
        lector.Close()
    End Sub

    Private Sub cmbModelo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbModelo.SelectedIndexChanged
        comando.CommandText = "Select * from Modelo where Descripcion ='" & cmbModelo.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        idModelo = lector(0)
        lector.Close()

    End Sub

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        comando.CommandText = "select count(*) from Articulo"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        txtIdArticulo.Text = n
        cmbModelo.Enabled = True
        txtTamano.Enabled = True
        txtMaximo.Enabled = True
        txtMinimo.Enabled = True
        txtExistencias.Enabled = True
        txtColor.Enabled = True
        txtCosto.Enabled = True
        txtPrecio.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdSalir.Enabled = False
    End Sub
    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click
        cmbModelo.Enabled = False
        txtTamano.Enabled = False
        txtMaximo.Enabled = False
        txtMinimo.Enabled = False
        txtExistencias.Enabled = False
        txtColor.Enabled = False
        txtCosto.Enabled = False
        txtPrecio.Enabled = False
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        dgArticulo.Refresh()

        Dim idArticulo, maximo, minimo, existencia As Integer
        Dim tamano, color As String
        Dim costo, precio As Decimal

        idArticulo = txtIdArticulo.Text
        tamano = txtTamano.Text
        maximo = txtMaximo.Text
        minimo = txtMinimo.Text
        existencia = txtExistencias.Text
        color = txtColor.Text
        costo = txtCosto.Text
        precio = txtPrecio.Text

        ' Iniciar una transacción local 
        transaction = conexion.BeginTransaction("SampleTransaction")

        'Debe asignar el objeto de la transacción y la conexión 
        'A un objeto comando para una transación local pendiente. 
        comando.Connection = conexion
        comando.Transaction = transaction

        Try
            comando.CommandText = "insert into Articulo(IdArticulo, IdModelo, Tamano, Maximo, Minimo, Existencia, Color, Costo, Precio, Estado) values (" & idArticulo & "," & idModelo & ",'" & tamano & "'," & maximo & "," & minimo & "," & existencia & ",'" & color & "'," & Str(costo) & "," & precio & ", '0')"
            comando.ExecuteNonQuery()

            If MsgBox("¿Desea ejecutar transacción?", MsgBoxStyle.YesNo, "Ejecutar") = MsgBoxResult.Yes Then
                transaction.Commit()
                MsgBox("Ok")
            Else
                transaction.Rollback()
                MsgBox("Transacción cancelada")
            End If

        Catch ex As Exception
            MsgBox("Commit Exception Type {0} No se pudo insertar por Error")
            Try
                transaction.Rollback()

            Catch ex2 As Exception
                '	Este bloque de catch manejará los errores
                '	que pueden ser ocurridos en el servidor y que podrían causar el rollback tal como una conexión cerrada.
                MsgBox("Error Rollback")

            End Try
        End Try

    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs) Handles cmdSalir.Click
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        cmbModelo.Enabled = False
        txtTamano.Enabled = False
        txtMaximo.Enabled = False
        txtMinimo.Enabled = False
        txtExistencias.Enabled = False
        txtColor.Enabled = False
        txtCosto.Enabled = False
        txtPrecio.Enabled = False
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs) Handles cmdModificar.Click
        cmbModelo.Enabled = True
        txtTamano.Enabled = True
        txtMaximo.Enabled = True
        txtMinimo.Enabled = True
        txtExistencias.Enabled = True
        txtColor.Enabled = True
        txtCosto.Enabled = True
        txtPrecio.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdSalir.Enabled = False
    End Sub

    Private Sub txtColor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtColor.KeyPress
        'solo  letras
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        'solo nunmeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtExistencias_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtExistencias.KeyPress
        'solo nunmeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMaximo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMaximo.KeyPress
        'solo nunmeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtMinimo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMinimo.KeyPress
        'solo nunmeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        'solo nunmeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class