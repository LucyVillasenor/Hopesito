Public Class frmUsuarios
    Private Sub frmUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'CasaEstherDataSet1.Usuario' Puede moverla o quitarla según sea necesario.
        Me.UsuarioTableAdapter.Fill(Me.CasaEstherDataSet1.Usuario)

    End Sub

    Private Sub cmdInicio_Click(sender As Object, e As EventArgs) Handles cmdInicio.Click
        UsuarioBindingSource.MoveFirst()
    End Sub

    Private Sub cmdSiguiente_Click(sender As Object, e As EventArgs) Handles cmdSiguiente.Click
        UsuarioBindingSource.MoveNext()
    End Sub

    Private Sub cmdAnterior_Click(sender As Object, e As EventArgs) Handles cmdAnterior.Click
        UsuarioBindingSource.MovePrevious()
    End Sub

    Private Sub cmdUltimo_Click(sender As Object, e As EventArgs) Handles cmdUltimo.Click
        UsuarioBindingSource.MoveLast()
    End Sub
    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs)
        Dim n As Integer
        n = UsuarioBindingSource.Count + 1
        UsuarioBindingSource.AddNew()
        txtIdUsuario.Text = n
        txtNombre.Enabled = True
        txtEmail.Enabled = True
        txtUsuario.Enabled = True
        txtPassword.Enabled = True
        txtTelefono.Enabled = True
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
        txtNombre.Enabled = False
        txtEmail.Enabled = False
        txtUsuario.Enabled = False
        txtPassword.Enabled = False
        txtTelefono.Enabled = False
        cmdNuevo.Enabled = True
        cmdGrabar.Enabled = False
        cmdCancelar.Enabled = False
        cmdSalir.Enabled = True
        dgUsuario.Refresh()
        cmdInicio.Enabled = True
        cmdSiguiente.Enabled = True
        cmdAnterior.Enabled = True
        cmdUltimo.Enabled = True
    End Sub
    Private Sub cmdSalir_Click(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs)
        UsuarioBindingSource.CancelEdit()
        txtNombre.Enabled = False
        txtEmail.Enabled = False
        txtUsuario.Enabled = False
        txtPassword.Enabled = False
        txtTelefono.Enabled = False
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
        txtNombre.Enabled = False
        txtEmail.Enabled = False
        txtUsuario.Enabled = False
        txtPassword.Enabled = False
        txtTelefono.Enabled = False
        cmdNuevo.Enabled = False
        cmdGrabar.Enabled = True
        cmdCancelar.Enabled = True
        cmdSalir.Enabled = False
        cmdInicio.Enabled = False
        cmdSiguiente.Enabled = False
        cmdAnterior.Enabled = False
        cmdUltimo.Enabled = False
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        'solo letras
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

    Private Sub txtTelefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelefono.KeyPress
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