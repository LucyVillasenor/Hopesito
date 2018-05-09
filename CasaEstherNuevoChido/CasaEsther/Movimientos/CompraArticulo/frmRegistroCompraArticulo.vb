Imports System.Data.SqlClient
Public Class frmRegistroCompraArticulo
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim transaction As SqlTransaction
    Dim lector As SqlDataReader
    Dim idCategoria As Integer
    Private Sub CompraArticulo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        comando.CommandText = "Select * from Proveedor"
        lector = comando.ExecuteReader()
        While lector.Read()
            cmboProveedor.Items.Add(lector(1))
        End While
        lector.Close()

        comando.CommandText = "Select * from Articulo"
        lector = comando.ExecuteReader()
        While lector.Read()
            cmboArticulo.Items.Add(lector(0))
        End While
        lector.Close()
    End Sub

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

    Private Sub cmboProveedor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboProveedor.SelectedIndexChanged
        comando.CommandText = "Select * from Proveedor where Nombre ='" & cmboProveedor.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtidProveedor.Text = lector(0)
        txtDomicilio.Text = lector(2)
        txtTel.Text = lector(7)
        lector.Close()
    End Sub

    Private Sub cmboArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboArticulo.SelectedIndexChanged
        'Primero obtengo el articulo para poder sacar el concepto
        Dim articulo As Integer
        Dim idcat As Integer

        articulo = cmboArticulo.Text
        comando.CommandText = "Select * from Articulo where IdArticulo ='" & articulo & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdArticulo.Text = lector(0)
        txtModelo.Text = lector(1)
        txtTamaño.Text = lector(2)
        txtExistencia.Text = lector(5)
        txtCostoUltimo.Text = lector(7)
        txtMax.Text = lector(3)
        txtMin.Text = lector(4)
        lector.Close()


        comando.CommandText = "Select * from Modelo where IdModelo ='" & txtModelo.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        idcat = lector(1)
        txtModelo.Text = lector(2)
        lector.Close()

        comando.CommandText = "Select * from Categoria where IdCategoria ='" & idcat & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        idCategoria = lector(0)
        txtCategoria.Text = lector(1)
        lector.Close()

    End Sub
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        comando.CommandText = "select IDENT_CURRENT('CompraArticulo')"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        txtidCompra.Text = n
        btnGrabar.Enabled = True
        txtFactura.Enabled = True
        cmboProveedor.Enabled = True
        cmboArticulo.Enabled = True
        txtCantidad.Enabled = True
        txtCosto.Enabled = True
        btnAceptar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim suma As Double = 0
        dgCompraArticulo.Rows.Add(txtIdArticulo.Text, txtModelo.Text, Val(txtCantidad.Text), Val(txtCosto.Text), Val((txtCantidad.Text) * (txtCosto.Text)))
        For i = 0 To dgCompraArticulo.Rows.Count - 1
            suma = suma + dgCompraArticulo.Item(4, i).Value
        Next
        cmboArticulo.Text = ""
        txtCategoria.Text = ""
        txtModelo.Text = ""
        txtIdArticulo.Text = ""
        txtExistencia.Text = ""
        txtMax.Text = ""
        txtMin.Text = ""
        txtTamaño.Text = ""
        txtCosto.Text = ""
        txtCostoUltimo.Text = ""
        txtCantidad.Text = ""
        txtTotal.Text = suma
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        btnGrabar.Enabled = False
        txtFactura.Enabled = False
        cmboProveedor.Enabled = False
        txtCategoria.Enabled = False
        cmboArticulo.Enabled = False
        txtCantidad.Enabled = False
        txtCosto.Enabled = False
        btnAceptar.Enabled = False
        btnNuevo.Enabled = False

        Dim idCompra, idProveeedor, factura, idArtic, cant, existencia As Integer
        Dim total, costo As Decimal
        Dim fecha As Date

        idCompra = Val(txtidCompra.Text)
        idArtic = Val(txtIdArticulo.Text)
        idProveeedor = Val(txtidProveedor.Text)
        factura = Val(txtFactura.Text)
        fecha = dtpFecha.Value.Date
        total = txtTotal.Text
        costo = Val(txtCosto.Text)
        cant = Val(txtCantidad.Text)
        existencia = Val(txtExistencia.Text)

        ' Iniciar una transacción local 
        transaction = conexion.BeginTransaction("SampleTransaction")

        'Debe asignar el objeto de la transacción y la conexión 
        'A un objeto comando para una transación local pendiente. 
        comando.Connection = conexion
        comando.Transaction = transaction

        Try
            comando.CommandText = "insert into CompraArticulo(IdProveedor, Fecha, Factura, Subtotal) values (" & idProveeedor & ",'" & fecha & "'," & factura & "," & Str(total) & ")"
            comando.ExecuteNonQuery()

            For i = 0 To dgCompraArticulo.Rows.Count - 1
                idArtic = dgCompraArticulo.Item(0, i).Value
                cant = dgCompraArticulo.Item(2, i).Value
                costo = CDbl(dgCompraArticulo.Item(3, i).Value)
                comando.CommandText = "Insert into DetCompraArticulo (IdCompra, IdArticulo, Cantidad, Costo) Values (" & idCompra & "," & idArtic & "," & cant & "," & costo & ")"
                comando.ExecuteNonQuery()
                comando.CommandText = "update Articulo set Existencia = Existencia + " & cant & ", costo = " & costo & " where IdArticulo =" & idArtic
                comando.ExecuteNonQuery()
            Next

            If MsgBox("¿Desea ejecutar transacción?", MsgBoxStyle.YesNo, "Ejecutar") = MsgBoxResult.Yes Then
                transaction.Commit()
                MsgBox("Ok")
            Else
                transaction.Rollback()
                MsgBox("Transacción cancelada")
            End If

        Catch ex As Exception
            MsgBox("Commit Exception Type {0} No se pudo insertar por Error")
            Dim nombreError As String = "Error de inserción"
            Dim st As New StackTrace(True)
            st = New StackTrace(ex, True)
            Dim frame = st.GetFrame(st.FrameCount - 1)
            Dim nomLinea As String = frame.GetFileLineNumber()
            pasarBitacora(nombreError, ex, nomLinea)
            Try
                transaction.Rollback()

            Catch ex2 As Exception
                '	Este bloque de catch manejará los errores
                '	que pueden ser ocurridos en el servidor y que podrían causar el rollback tal como una conexión cerrada.
                MsgBox("Error Rollback")

            End Try
        End Try
        btnNuevo.Enabled = True
        txtFactura.Text = ""
        dgCompraArticulo.Refresh()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs)
        'SOLO LETRAS
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

    Private Sub TextBox2_KeyPress1(sender As Object, e As KeyPressEventArgs)
        'solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCosto.KeyPress
        'solo numeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        'solo nunmeros
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFactura.KeyPress
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class