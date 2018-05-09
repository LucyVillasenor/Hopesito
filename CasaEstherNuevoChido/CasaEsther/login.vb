Imports System.Data.SqlClient
Public Class login
    Dim conexion As New SqlConnection("Data Source=.; initial Catalog = 'CasaEsther'; Integrated security = true")
    Dim comando As SqlCommand = conexion.CreateCommand()
    Dim lector As SqlDataReader

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conexion.Open()
        Try
            comando.CommandText = "Select * from Usuario where NomUsuario ='" & txtUsuario.Text & "' And Password ='" & txtContrasena.Text & "'"
            lector = comando.ExecuteReader()
            lector.Read()
            usuario = lector(1)
            contrasena = lector(2)
            lector.Close()
        Catch ex As Exception
            MsgBox("Usuario o Contraseña Incorrecta", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "")
            txtUsuario.Clear()
            txtContrasena.Clear()
            conexion.Close()
        End Try
        If usuario = "" And contrasena = "" Then
            txtUsuario.Clear()
            txtContrasena.Clear()
            conexion.Close()
        ElseIf txtUsuario.Text = usuario And txtContrasena.Text = contrasena Then
            conexion.Close()
            Me.Hide()
            frmPrincipal.ShowDialog()
        Else
            MsgBox("Usuario o Contraseña Incorrecta", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "")
            txtUsuario.Clear()
            txtContrasena.Clear()
            conexion.Close()
        End If

    End Sub

End Class