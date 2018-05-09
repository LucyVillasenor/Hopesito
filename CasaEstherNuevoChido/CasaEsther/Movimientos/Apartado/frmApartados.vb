Imports System.Data.SqlClient
Public Class frmApartados
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim transaction As SqlTransaction
    Dim lector As SqlDataReader

    Private Sub frmApartados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        dgApartado.Rows.Clear()
        cmboCliente.Items.Clear()
        cmboArticulo.Items.Clear()
        comando.CommandText = "Select * from Articulo where Existencia - Estado >= 1"
        lector = comando.ExecuteReader()
        While lector.Read()
            cmboArticulo.Items.Add(lector(0))
        End While
        lector.Close()

        comando.CommandText = "Select * from Cliente"
        lector = comando.ExecuteReader()
        While lector.Read()
            cmboCliente.Items.Add(lector(1))
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

    Private Sub cmboCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboCliente.SelectedIndexChanged
        comando.CommandText = "Select * from  Cliente where Nombre ='" & cmboCliente.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtIdCliente.Text = lector(0)
        txtCiudad.Text = lector(2)
        txtDom.Text = lector(3)
        txtColonia.Text = lector(4)
        txtTel.Text = lector(5)
        txtSaldo.Text = lector(6)
        lector.Close()
    End Sub

    Private Sub cmboArticulo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmboArticulo.SelectedIndexChanged
        'Primero obtengo el articulo para poder sacar el concepto
        Dim articulo As Integer

        articulo = cmboArticulo.Text
        comando.CommandText = "Select * from Articulo where IdArticulo ='" & articulo & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtidArticulo.Text = lector(0)
        txtModelo.Text = lector(1)
        txtTamaño.Text = lector(2)
        txtPrecio.Text = lector(8)
        txtExistencia.Text = (lector(5) - lector(9))
        lector.Close()

        comando.CommandText = "Select * from Modelo where IdModelo ='" & txtModelo.Text & "'"
        lector = comando.ExecuteReader()
        lector.Read()
        txtModelo.Text = lector(2)
        lector.Close()
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgApartado.Refresh()
        comando.CommandText = "select IDENT_CURRENT('Apartado')"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        txtidApartado.Text = n
        cmboCliente.Enabled = True
        cmboArticulo.Enabled = True
        txtCantidad.Enabled = True
        btnAceptar.Enabled = True
        btnGrabar.Enabled = True
        btnNuevo.Enabled = False
        cmboCliente.Enabled = True

    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Dim suma As Double = 0
        Dim ban As Boolean = False
        Dim id As Integer
        Dim x As Integer
        Dim act As Integer
        For i = 0 To dgApartado.Rows.Count - 2
            id = CInt(dgApartado.Item(0, i).Value)
            If id = txtidArticulo.Text Then
                ban = True
                x = i
            End If
        Next

        If ban = False Then
            dgApartado.Rows.Add(txtidArticulo.Text, txtModelo.Text, Val(txtCantidad.Text), Val(txtPrecio.Text), Val(txtCantidad.Text * txtPrecio.Text))
        Else
            act = dgApartado.Item(2, x).Value + Val(txtCantidad.Text)
            dgApartado.Item(2, x).Value = act
            dgApartado.Item(4, x).Value = act * Val(txtPrecio.Text)

        End If

        For i = 0 To dgApartado.Rows.Count - 2
            suma = suma + dgApartado(4, i).Value
        Next
        txtTotal.Text = suma
        txtModelo.Text = ""
        txtExistencia.Text = ""
        txtCantidad.Text = ""
        txtPrecio.Text = ""
        txtTamaño.Text = ""
        cmboArticulo.Text = ""
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        btnGrabar.Enabled = False
        cmboArticulo.Enabled = False
        txtCantidad.Enabled = False
        btnAceptar.Enabled = False
        btnNuevo.Enabled = False

        Dim idAprtado, idArticulo, cantidad, idCliente As Integer
        Dim estado As Integer = 1
        Dim total, precio As Decimal
        Dim fecha As Date

        idAprtado = Val(txtidApartado.Text)
        idCliente = txtIdCliente.Text
        fecha = dtpFecha.Value.Date
        total = Val(txtTotal.Text)

        ' Iniciar una transacción local 
        transaction = conexion.BeginTransaction("SampleTransaction")

        'Debe asignar el objeto de la transacción y la conexión 
        'A un objeto comando para una transación local pendiente. 
        comando.Connection = conexion
        comando.Transaction = transaction

        Try
            comando.CommandText = "insert into Apartado(IdCliente, Fecha, Abono, Total) values (" & idCliente & ",'" & fecha & "', 0, " & total & ")"
            comando.ExecuteNonQuery()

            For i = 0 To dgApartado.Rows.Count - 2
                idArticulo = dgApartado.Item(0, i).Value
                cantidad = dgApartado.Item(2, i).Value
                precio = dgApartado.Item(3, i).Value
                comando.CommandText = "Insert into DetApartado(IdApartado, IdArticulo, Cantidad, Precio) Values (" & idAprtado & "," & idArticulo & "," & cantidad & ", " & precio & ")"
                comando.ExecuteNonQuery()
                comando.CommandText = "update Articulo set Estado = Estado +" & cantidad & " where IdArticulo =" & idArticulo
                comando.ExecuteNonQuery()
            Next
            comando.CommandText = "update Cliente set Saldo = Saldo + " & total & " where IdCliente =" & idCliente
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
        cmboCliente.Text = ""
        txtCiudad.Text = ""
        txtDom.Text = ""
        txtTel.Text = ""
        txtTotal.Text = ""
        txtColonia.Text = ""
        txtSaldo.Text = ""
        txtCiudad.Text = ""
        cmboCliente.Enabled = False
        btnNuevo.Enabled = True
        dgApartado.Refresh()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        conexion.Close()
        Close()
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

    Private Sub txtAnticipo_KeyPress(sender As Object, e As KeyPressEventArgs)
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