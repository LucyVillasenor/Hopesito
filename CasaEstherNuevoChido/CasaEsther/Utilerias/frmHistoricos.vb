Imports System.Data.SqlClient
Public Class frmHistoricos
    Dim conexion As New SqlConnection("Data Source='.'; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim conexion2 As New SqlConnection("Data Source='.'; initial Catalog = 'HCasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim comando2 As SqlCommand = conexion2.CreateCommand()
    Dim lector As SqlDataReader
    Dim lector2 As SqlDataReader
    Private Sub frmHistoricos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Open()
        conexion2.Open()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        ' Declaracion de variables 
        Dim idArticulo, idModelo, maximo, minimo, existencia, estado, idCategoria, idEmpleado As Integer
        Dim idProveedor, idCliente, idApartado, cantidad, idAbono, factura, idCompra, idVenta As Integer
        Dim tamaño, color, concepto, nombre, domicilio, colonia, ciudad, descripcion, email, eestado, telefono, celular, cp As String
        Dim costo, precio, saldo, abono, total, importe, iva As Decimal
        Dim fecha As Date
        Dim fechaInicial As String = cmbFecha.Text + "-01-01"
        Dim fechaFinal As String = cmbFecha.Text + "-12-31"
        Dim ids As List(Of Integer)
        Dim ids2 As List(Of Integer)

        'Truncate a todos los catalogos
        comando2.CommandText = "TRUNCATE TABLE Articulo"
        comando2.ExecuteNonQuery()
        comando2.CommandText = "TRUNCATE TABLE Categoria"
        comando2.ExecuteNonQuery()
        comando2.CommandText = "TRUNCATE TABLE Empleado"
        comando2.ExecuteNonQuery()
        comando2.CommandText = "TRUNCATE TABLE Modelo"
        comando2.ExecuteNonQuery()
        comando2.CommandText = "TRUNCATE TABLE Proveedor"
        comando2.ExecuteNonQuery()

        comando2.CommandText = "TRUNCATE TABLE cliente"
        comando2.ExecuteNonQuery()

        'insercion en articulos
        comando.CommandText = "Select * from Articulo"
        lector = comando.ExecuteReader()
        While lector.Read()
            idArticulo = lector(0)
            idModelo = lector(1)
            tamaño = lector(2)
            maximo = lector(3)
            minimo = lector(4)
            existencia = lector(5)
            color = lector(6)
            costo = lector(7)
            precio = lector(8)
            estado = lector(9)
            comando2.CommandText = "insert into articulo(idArticulo, idModelo, tamaño, maximo, minimo, existencia,color,costo,precio,estado) values (" & idArticulo & "," & idModelo & ",'" & tamaño & "'," & maximo & "," & minimo & "," & existencia & ",'" & color & "'," & costo & "," & precio & "," & estado & ")"
            comando2.ExecuteNonQuery()
        End While
        lector.Close()

        'insercion en categorias
        comando.CommandText = "Select * from Categoria"
        lector = comando.ExecuteReader()
        While lector.Read()
            idCategoria = lector(0)
            concepto = lector(1)
            comando2.CommandText = "insert into categoria(idCategoria, concepto) values (" & idCategoria & ",'" & concepto & "'" & ")"
            comando2.ExecuteNonQuery()
        End While
        lector.Close()

        'insercion en empleados
        comando.CommandText = "Select * from Empleado"
        lector = comando.ExecuteReader()
        While lector.Read()
            idEmpleado = lector(0)
            nombre = lector(1)
            domicilio = lector(2)
            colonia = lector(3)
            ciudad = lector(4)
            cp = lector(5)
            telefono = lector(6)
            celular = lector(7)
            comando2.CommandText = "insert into empleado(idEmpleado, nombre,domicilio,colonia,ciudad,cp,telefono,celular) values (" & idEmpleado & ",'" & nombre & "','" & domicilio & "','" & colonia & "','" & ciudad & "','" & cp & "','" & telefono & "','" & celular & "')"
            comando2.ExecuteNonQuery()
        End While
        lector.Close()


        'insercion en modelo
        comando.CommandText = "Select * from Modelo"
        lector = comando.ExecuteReader()
        While lector.Read()
            idModelo = lector(0)
            idCategoria = lector(1)
            descripcion = lector(2)
            comando2.CommandText = "insert into modelo(idModelo,idCategoria,descripcion) values (" & idModelo & "," & idCategoria & ",'" & descripcion & "')"
            comando2.ExecuteNonQuery()
        End While
        lector.Close()

        'insercion en proveedor
        comando.CommandText = "Select * from Proveedor"
        lector = comando.ExecuteReader()
        While lector.Read()
            idProveedor = lector(0)
            nombre = lector(1)
            domicilio = lector(2)
            colonia = lector(3)
            ciudad = lector(4)
            eestado = lector(5)
            cp = lector(6)
            telefono = lector(7)
            celular = lector(8)
            email = lector(9)
            comando2.CommandText = "insert into proveedor(idProveedor,nombre,domicilio,colonia,ciudad,estado,cp,tel,cel,email) values (" & idProveedor & ",'" & nombre & "','" & domicilio & "','" & colonia & "','" & ciudad & "','" & eestado & "','" & cp & "','" & telefono & "','" & celular & "','" & email & "')"
            comando2.ExecuteNonQuery()
        End While
        lector.Close()

        comando.CommandText = "Delete from Venta where fecha between '" & fechaInicial & "' and '" & fechaFinal & "'"
        comando.ExecuteNonQuery()

        'insercion en Compra, DetCompra
        ids = New List(Of Integer)
        comando.CommandText = "Select * from CompraArticulo where fecha between '" & fechaInicial & "' and '" & fechaFinal & "'"
        lector = comando.ExecuteReader()
        While lector.Read()
            idCompra = lector(0)
            ids.Add(idCompra)
            idProveedor = lector(1)
            fecha = lector(2)
            factura = lector(3)
            total = lector(4)
            comando2.CommandText = "insert into compraArticulo(idCompra, idProveedor, fecha, factura, subtotal) values (" & idCompra & "," & idProveedor & ",'" & fecha & "'," & factura & "," & Str(total) & ")"
            comando2.ExecuteNonQuery()
        End While
        lector.Close()

        For i = 0 To ids.Count - 1
            comando.CommandText = "Select * from detCompraArticulo where idCompra = " & ids(i)
            lector = comando.ExecuteReader()
            While lector.Read
                idCompra = lector(0)
                idArticulo = lector(1)
                cantidad = lector(2)
                costo = lector(3)
                comando2.CommandText = "insert into detCompraArticulo(idCompra, idArticulo, cantidad, costo) Values (" & idCompra & "," & idArticulo & "," & cantidad & "," & Str(costo) & ")"
                comando2.ExecuteNonQuery()
            End While
            lector.Close()
        Next
        For i = 0 To ids.Count - 1
            comando.CommandText = "Delete from detCompraArticulo where idCompra = " & ids(i)
            comando.ExecuteNonQuery()
        Next
        comando.CommandText = "Delete from CompraArticulo where fecha between '" & fechaInicial & "' and '" & fechaFinal & "'"
        comando.ExecuteNonQuery()

        'insercion en Venta, DetVenta
        ids = New List(Of Integer)
        comando.CommandText = "Select * from Venta where fecha between '" & fechaInicial & "' and '" & fechaFinal & "'"
        lector = comando.ExecuteReader()
        While lector.Read()
            idVenta = lector(0)
            ids.Add(idVenta)
            idEmpleado = lector(1)
            fecha = lector(2)
            total = lector(3)
            iva = lector(4)
            comando2.CommandText = "insert into venta(idVenta, idEmpleado, fecha, subtotal, iva) values (" & idVenta & "," & idEmpleado & ",'" & fecha & "'," & Str(total) & "," & Str(iva) & ")"
            comando2.ExecuteNonQuery()
        End While
        lector.Close()

        For i = 0 To ids.Count - 1
            comando.CommandText = "Select * from detalleVenta where idVenta = " & ids(i)
            lector = comando.ExecuteReader()
            While lector.Read
                idVenta = lector(0)
                idArticulo = lector(1)
                cantidad = lector(2)
                precio = lector(3)
                comando2.CommandText = "insert into detalleVenta(idVenta, idArticulo, cantidad, precio) Values (" & idVenta & "," & idArticulo & "," & cantidad & "," & Str(precio) & ")"
                comando2.ExecuteNonQuery()
            End While
            lector.Close()
        Next
        For i = 0 To ids.Count - 1
            comando.CommandText = "Delete from detalleVenta where idVenta = " & ids(i)
            comando.ExecuteNonQuery()
        Next
        comando.CommandText = "Delete from Venta where fecha between '" & fechaInicial & "' and '" & fechaFinal & "'"
        comando.ExecuteNonQuery()
        'insercion en Cliente, abono, Apartado, DetApartado
        ids = New List(Of Integer)
        comando.CommandText = "Select * from Cliente where Saldo = 0"
        lector = comando.ExecuteReader()
        While lector.Read()
            idCliente = lector(0)
            ids.Add(idCliente)
            nombre = lector(1)
            ciudad = lector(2)
            domicilio = lector(3)
            colonia = lector(4)
            telefono = lector(5)
            saldo = lector(6)
            comando2.CommandText = "insert into cliente(idCliente,nombre,ciudad,domicilio,colonia,telefono,saldo)values (" & idCliente & ",'" & nombre & "','" & ciudad & "','" & domicilio & "','" & colonia & "','" & telefono & "'," & Str(saldo) & ")"
            comando2.ExecuteNonQuery()
        End While
        lector.Close()

        ids2 = New List(Of Integer)
        For i = 0 To ids.Count - 1
            comando.CommandText = "Select * from Apartado where idCliente = " & ids(i) & " and fecha between '" & fechaInicial & "' and '" & fechaFinal & "'"
            lector = comando.ExecuteReader()
            While lector.Read
                idApartado = lector(0)
                ids2.Add(idApartado)
                fecha = lector(2)
                abono = lector(3)
                total = lector(4)
                comando2.CommandText = "insert into apartado(idApartado, idCliente, fecha, abono, total) values (" & idApartado & "," & ids(i) & ",'" & fecha & "'," & Str(abono) & ", " & Str(total) & ")"
                comando2.ExecuteNonQuery()
            End While
            lector.Close()
        Next
        For i = 0 To ids.Count - 1
            comando.CommandText = "Delete from Apartado where idCliente = " & ids(i) & " and fecha between '" & fechaInicial & "' and '" & fechaFinal & "'"
            comando.ExecuteNonQuery()
        Next

        For i = 0 To ids2.Count - 1
            comando.CommandText = "Select * from DetApartado where IdApartado = " & ids2(i)
            lector = comando.ExecuteReader()
            While lector.Read
                idApartado = lector(0)
                idArticulo = lector(1)
                cantidad = lector(2)
                precio = lector(3)
                comando2.CommandText = "Insert into detApartado(idApartado, idArticulo, cantidad, precio) Values (" & idApartado & "," & idArticulo & "," & cantidad & ", " & Str(precio) & ")"
                comando2.ExecuteNonQuery()
            End While
            lector.Close()
        Next
        For i = 0 To ids2.Count - 1
            comando.CommandText = "Delete from DetApartado where IdApartado = " & ids2(i)
            comando.ExecuteNonQuery()
        Next

        For i = 0 To ids2.Count - 1
            comando.CommandText = "Select * from Abono where IdApartado = " & ids2(i) & " and fecha between '" & fechaInicial & "' and '" & fechaFinal & "'"
            lector = comando.ExecuteReader()
            While lector.Read
                idAbono = lector(0)
                idApartado = lector(1)
                fecha = lector(2)
                importe = lector(3)
                comando2.CommandText = "insert into abono(idAbono, idApartado, fecha, importe) values (" & idAbono & "," & idApartado & ",'" & fecha & "'," & Str(importe) & ")"
                comando2.ExecuteNonQuery()
            End While
            lector.Close()
        Next
        For i = 0 To ids2.Count - 1
            comando.CommandText = "Delete from Abono where IdApartado = " & ids2(i) & " and fecha between '" & fechaInicial & "' and '" & fechaFinal & "'"
            comando.ExecuteNonQuery()
        Next

        MsgBox("Exito")

    End Sub

    Private Sub frmHistoricos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        conexion.Close()
        conexion2.Close()
    End Sub
End Class