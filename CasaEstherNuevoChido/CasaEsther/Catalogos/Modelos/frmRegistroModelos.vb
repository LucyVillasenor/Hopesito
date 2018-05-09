Public Class frmRegistroModelos
    Private Sub Modelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CategoriaTableAdapter.Fill(Me.CasaEstherDataSet.Categoria)
        'TODO: esta línea de código carga datos en la tabla 'CasaEstherDataSet.Modelo' Puede moverla o quitarla según sea necesario.
        Me.ModeloTableAdapter.Fill(Me.CasaEstherDataSet.Modelo)
        SqlDataAdapter1.Fill(CasaEstherDataSet.Modelo)
    End Sub
    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        ModeloBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        ModeloBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        ModeloBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        ModeloBindingSource.MoveLast()
    End Sub
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs)
        Dim n As Integer
        n = ModeloBindingSource.Count + 1
        ModeloBindingSource.AddNew()
        txtIdModelo.Text = n
        cmbCategoria.Enabled = True
        txtDescripcion.Enabled = True
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
        cmbCategoria.Enabled = False
        txtDescripcion.Enabled = False
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        dgModelo.Refresh()
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
        Try
            ModeloBindingSource.EndEdit()
            ModeloTableAdapter.Update(CasaEstherDataSet.Modelo)
            SqlDataAdapter1.Update(CasaEstherDataSet.Modelo)
            CasaEstherDataSet.Modelo.Clear()
            SqlDataAdapter1.Fill(CasaEstherDataSet.Modelo)
        Catch ex As System.Data.DBConcurrencyException
            MessageBox.Show("Error de concurrencia. El registro ya ha sido modificado.")
            CasaEstherDataSet.Modelo.Clear()
            SqlDataAdapter1.Fill(CasaEstherDataSet.Modelo)
        End Try
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs)
        ModeloBindingSource.CancelEdit()
        cmbCategoria.Enabled = False
        txtDescripcion.Enabled = False
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
        cmbCategoria.Enabled = True
        txtDescripcion.Enabled = True
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

    Private Sub txtDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDescripcion.KeyPress
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