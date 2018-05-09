Public Class frmRegistroCategorias
    Private Sub Categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CasaEstherDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.CasaEstherDataSet.Categoria)
        SqlDataAdapter1.Fill(CasaEstherDataSet.Categoria)
    End Sub
    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        CategoriaBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        CategoriaBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        CategoriaBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        CategoriaBindingSource.MoveLast()
    End Sub
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs)
        Dim n As Integer
        n = CategoriaBindingSource.Count + 1
        CategoriaBindingSource.AddNew()
        txtIdCategoria.Text = n
        txtConcepto.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdSalir.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
    End Sub
    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs)
        txtConcepto.Enabled = False
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        dgCategoria.Refresh()
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
        Try
            CategoriaBindingSource.EndEdit()
            CategoriaTableAdapter.Update(CasaEstherDataSet.Categoria)
            SqlDataAdapter1.Update(CasaEstherDataSet.Categoria)
            CasaEstherDataSet.Categoria.Clear()
            SqlDataAdapter1.Fill(CasaEstherDataSet.Categoria)
        Catch ex As System.Data.DBConcurrencyException
            MessageBox.Show("Error de concurrencia. El registro ya ha sido modificado.")
            CasaEstherDataSet.Categoria.Clear()
            SqlDataAdapter1.Fill(CasaEstherDataSet.Categoria)
        End Try
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs)
        CategoriaBindingSource.CancelEdit()
        txtConcepto.Enabled = False
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
    End Sub

    Private Sub cmdModificar_Click(sender As Object, e As EventArgs)
        txtConcepto.Enabled = True
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdSalir.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
    End Sub
    Private Sub SqlDataAdapter1_RowUpdated(ByVal sender As Object, ByVal e As System.Data.SqlClient.SqlRowUpdatedEventArgs)
        If e.Status = UpdateStatus.ErrorsOccurred Then
            MessageBox.Show(e.Errors.Message & vbCrLf & e.Row.Item("NOMBRE", DataRowVersion.Original) & vbCrLf & e.Row.Item("NOMBRE", DataRowVersion.Current))
            e.Status = UpdateStatus.SkipCurrentRow
        End If
    End Sub

    Private Sub txtConcepto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtConcepto.KeyPress
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

End Class