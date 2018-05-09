Imports System.Data.SqlClient
Public Class frmAbonos
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim transaction As SqlTransaction
    Dim lector As SqlDataReader
    Private Sub frmAbonos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        cmboCliente.Items.Clear()
        cmboApartado.Items.Clear()
        dgApartados.Rows.Clear()
        comando.CommandText = "Select * from Cliente where Saldo > 0"
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
        dgApartados.Rows.Clear()
        cmboApartado.Items.Clear()
        Dim cliente As String
        Dim idCliente As Integer
        cliente = cmboCliente.Text
        comando.CommandText = "Select * from Cliente where Nombre = '" & cliente & "'"
        lector = comando.ExecuteReader
        lector.Read()
        idCliente = lector(0)
        txtIdCliente.Text = idCliente
        txtCiudad.Text = lector(2)
        txtDom.Text = lector(3)
        txtColonia.Text = lector(4)
        txtTel.Text = lector(5)
        txtSaldoCliente.Text = lector(6)
        lector.Close()

        comando.CommandText = "Select a.IdApartado, a.Fecha, a.Total, a.Abono From Apartado a Where a.IdCliente = " & idCliente
        lector = comando.ExecuteReader()
        While lector.Read()
            dgApartados.Rows.Add(lector(0), lector(1), lector(2), lector(3), "Ver", (lector(2) - lector(3)))
        End While
        lector.Close()

        comando.CommandText = "Select * from Apartado where IdCliente = " & idCliente
        lector = comando.ExecuteReader()
        While lector.Read()
            cmboApartado.Items.Add(lector(0))
        End While
        lector.Close()

    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        dgApartados.Rows.Clear()
        comando.CommandText = "select IDENT_CURRENT('Abono')"
        Dim n As Integer
        n = comando.ExecuteScalar + 1
        txtIdAbono.Text = n
        cmboCliente.Enabled = True
        txtImporte.Enabled = True
        cmboApartado.Enabled = True
        btnGrabar.Enabled = True
        btnNuevo.Enabled = False
    End Sub

    Private Sub btnGrabar_Click(sender As Object, e As EventArgs) Handles btnGrabar.Click
        btnGrabar.Enabled = False
        cmboCliente.Enabled = False
        txtImporte.Enabled = False
        cmboApartado.Enabled = False
        btnNuevo.Enabled = False

        Dim idAbono, idApartado As Integer
        Dim importe As Decimal
        Dim fecha As Date

        idAbono = Val(txtIdAbono.Text)
        fecha = dtpFecha.Value.Date
        idApartado = Val(cmboApartado.Text)
        importe = Val(txtImporte.Text)
        ' Iniciar una transacción local 
        transaction = conexion.BeginTransaction("SampleTransaction")

        'Debe asignar el objeto de la transacción y la conexión 
        'A un objeto comando para una transación local pendiente. 
        comando.Connection = conexion
        comando.Transaction = transaction

        Try
            comando.CommandText = "insert into Abono(IdApartado, Fecha, Importe) values (" & idApartado & ",'" & fecha & "'," & importe & ")"
            comando.ExecuteNonQuery()

            comando.CommandText = "update Apartado set Abono = Abono + " & importe & " where IdApartado = " & Val(cmboApartado.Text)
            comando.ExecuteNonQuery()

            comando.CommandText = "update Cliente set Saldo = Saldo - " & importe & " where Nombre = '" & cmboCliente.Text & "'"
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
        dgApartados.Rows.Clear()
        txtCiudad.Text = ""
        txtDom.Text = ""
        txtTel.Text = ""
        txtColonia.Text = ""
        txtSaldoCliente.Text = ""
        btnNuevo.Enabled = True
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        dgApartados.Rows.Clear()
        conexion.Close()
        Close()
    End Sub

    Private Sub txtImporte_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtImporte.KeyPress
        'solo números
        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub dgArticulos_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles dgApartados.CellContentClick
        Dim row As DataGridViewRow = dgApartados.CurrentRow
        idApartado = row.Cells(0).Value
        fecha = row.Cells(1).Value
        total = row.Cells(2).Value
        If dgApartados.Columns(e.ColumnIndex).Name = "Articulos" Then
            frmArticulosApartados.ShowDialog()
        End If
    End Sub
End Class