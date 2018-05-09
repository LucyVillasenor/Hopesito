Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class frmRestauracion

    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        ofd.Filter = "Archivos Restauracion (*.bak)|*.bak|Todos(*.*)|*.*"
        ofd.FilterIndex = 1
        ofd.FileName = "RespaldoCasaEsther"
        If ofd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtRuta.Text = ofd.FileName
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        SqlConnection.ClearAllPools()
        Dim resultado As DialogResult
        Try
            resultado = MessageBox.Show("¿Desea restaurar la base de datos?", "Restaurar Base de Datos")
            If (resultado = System.Windows.Forms.DialogResult.OK) Then
                Using conexion As New SqlConnection("Data Source='.'; initial Catalog = 'master'; Integrated security = true")
                    conexion.Open()
                    Using comando As New SqlCommand
                        comando.Connection = conexion
                        comando.CommandText = "RESTORE DATABASE [CasaEsther] FROM DISK = '" & txtRuta.Text & "'" & "WITH REPLACE"
                        comando.ExecuteNonQuery()
                        MessageBox.Show("La base de datos se ha restaurado exitosamente")
                    End Using
                    conexion.Close()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class