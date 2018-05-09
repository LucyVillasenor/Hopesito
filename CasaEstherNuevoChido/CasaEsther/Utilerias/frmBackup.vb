Imports System.Data.SqlClient
Imports System.ComponentModel
Public Class frmBackup
    Private Sub btnRuta_Click(sender As Object, e As EventArgs) Handles btnRuta.Click
        sfd.Filter = "Archivos Respaldo (*.bak)|*.bak|Todos(*.*)|*.*"
        sfd.FilterIndex = 1
        sfd.FileName = "RespaldoCasaEsther" & Today.Date.Day & Today.Date.Month & "" & Today.Date.Year
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            txtRuta.Text = sfd.FileName
        End If
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        SqlConnection.ClearAllPools()
        Dim resultado As DialogResult
        Try
            resultado = MessageBox.Show("¿Desea realizar copia de seguridad?", "Copia de Seguridad")
            If (resultado = System.Windows.Forms.DialogResult.OK) Then
                Using conexion As New SqlConnection("Data Source='.'; initial Catalog = 'master'; Integrated security = true")
                    conexion.Open()
                    Using comando As New SqlCommand
                        comando.Connection = conexion
                        comando.CommandText = "BACKUP DATABASE [CasaEsther] TO  DISK = '" & txtRuta.Text & "'"
                        comando.ExecuteNonQuery()
                        MessageBox.Show("La base de datos se ha respaldado exitosamente")
                    End Using
                    conexion.Close()
                End Using
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class