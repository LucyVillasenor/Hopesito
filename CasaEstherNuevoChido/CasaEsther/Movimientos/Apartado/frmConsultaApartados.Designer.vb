<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsIndApartado
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtSaldo = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgConsultaApartados = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmboIdCompra = New System.Windows.Forms.ComboBox()
        Me.Compra = New System.Windows.Forms.RadioButton()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblA = New System.Windows.Forms.Label()
        Me.cmboNombre = New System.Windows.Forms.ComboBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.rbPeriodo = New System.Windows.Forms.RadioButton()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgConsultaApartados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtNombre)
        Me.GroupBox2.Controls.Add(Me.txtIdCliente)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtColonia)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.txtSaldo)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtTel)
        Me.GroupBox2.Controls.Add(Me.txtDom)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtCiudad)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(744, 132)
        Me.GroupBox2.TabIndex = 126
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos del Cliente"
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNombre.Location = New System.Drawing.Point(95, 30)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(279, 26)
        Me.txtNombre.TabIndex = 131
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Enabled = False
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtIdCliente.Location = New System.Drawing.Point(514, 97)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(138, 26)
        Me.txtIdCliente.TabIndex = 130
        Me.txtIdCliente.Visible = False
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label17.Location = New System.Drawing.Point(436, 99)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(79, 21)
        Me.Label17.TabIndex = 129
        Me.Label17.Text = "idCliente"
        Me.Label17.Visible = False
        '
        'txtColonia
        '
        Me.txtColonia.Enabled = False
        Me.txtColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtColonia.Location = New System.Drawing.Point(514, 65)
        Me.txtColonia.Name = "txtColonia"
        Me.txtColonia.Size = New System.Drawing.Size(138, 26)
        Me.txtColonia.TabIndex = 128
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label18.Location = New System.Drawing.Point(436, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 21)
        Me.Label18.TabIndex = 127
        Me.Label18.Text = "Colonia:"
        '
        'txtSaldo
        '
        Me.txtSaldo.Enabled = False
        Me.txtSaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtSaldo.Location = New System.Drawing.Point(318, 97)
        Me.txtSaldo.Name = "txtSaldo"
        Me.txtSaldo.Size = New System.Drawing.Size(112, 26)
        Me.txtSaldo.TabIndex = 126
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label16.Location = New System.Drawing.Point(243, 99)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(69, 21)
        Me.Label16.TabIndex = 125
        Me.Label16.Text = "Saldo $"
        '
        'txtTel
        '
        Me.txtTel.Enabled = False
        Me.txtTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTel.Location = New System.Drawing.Point(95, 95)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(138, 26)
        Me.txtTel.TabIndex = 123
        '
        'txtDom
        '
        Me.txtDom.Enabled = False
        Me.txtDom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtDom.Location = New System.Drawing.Point(95, 65)
        Me.txtDom.Name = "txtDom"
        Me.txtDom.Size = New System.Drawing.Size(328, 26)
        Me.txtDom.TabIndex = 120
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label4.Location = New System.Drawing.Point(394, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 21)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Ciudad:"
        '
        'txtCiudad
        '
        Me.txtCiudad.Enabled = False
        Me.txtCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtCiudad.Location = New System.Drawing.Point(468, 31)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(232, 26)
        Me.txtCiudad.TabIndex = 122
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label6.Location = New System.Drawing.Point(7, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 21)
        Me.Label6.TabIndex = 121
        Me.Label6.Text = "Tel o Cel:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label3.Location = New System.Drawing.Point(6, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 21)
        Me.Label3.TabIndex = 104
        Me.Label3.Text = "Domicilio:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(10, 30)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 21)
        Me.Label5.TabIndex = 103
        Me.Label5.Text = "Nombre:"
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnSalir.Image = Global.CasaEsther.My.Resources.Resources.Salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(344, 590)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 36)
        Me.btnSalir.TabIndex = 125
        Me.btnSalir.Text = "       Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgConsultaApartados
        '
        Me.dgConsultaApartados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsultaApartados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column5, Me.Column6})
        Me.dgConsultaApartados.Location = New System.Drawing.Point(76, 430)
        Me.dgConsultaApartados.Name = "dgConsultaApartados"
        Me.dgConsultaApartados.Size = New System.Drawing.Size(646, 150)
        Me.dgConsultaApartados.TabIndex = 124
        '
        'Column1
        '
        Me.Column1.HeaderText = "idArticulo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Articulo"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Total"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmboIdCompra)
        Me.GroupBox1.Controls.Add(Me.Compra)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.lblA)
        Me.GroupBox1.Controls.Add(Me.cmboNombre)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.lblDe)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.rbPeriodo)
        Me.GroupBox1.Controls.Add(Me.rbNombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(107, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 126)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Consulta"
        '
        'cmboIdCompra
        '
        Me.cmboIdCompra.Enabled = False
        Me.cmboIdCompra.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.cmboIdCompra.FormattingEnabled = True
        Me.cmboIdCompra.Location = New System.Drawing.Point(127, 94)
        Me.cmboIdCompra.Name = "cmboIdCompra"
        Me.cmboIdCompra.Size = New System.Drawing.Size(121, 26)
        Me.cmboIdCompra.TabIndex = 93
        '
        'Compra
        '
        Me.Compra.AutoSize = True
        Me.Compra.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Compra.Location = New System.Drawing.Point(18, 94)
        Me.Compra.Name = "Compra"
        Me.Compra.Size = New System.Drawing.Size(93, 25)
        Me.Compra.TabIndex = 92
        Me.Compra.Text = "Compra"
        Me.Compra.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAceptar.Location = New System.Drawing.Point(474, 58)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 32)
        Me.btnAceptar.TabIndex = 86
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Enabled = False
        Me.lblA.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.lblA.Location = New System.Drawing.Point(305, 63)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(21, 21)
        Me.lblA.TabIndex = 90
        Me.lblA.Text = "a"
        '
        'cmboNombre
        '
        Me.cmboNombre.Enabled = False
        Me.cmboNombre.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.cmboNombre.FormattingEnabled = True
        Me.cmboNombre.Location = New System.Drawing.Point(131, 25)
        Me.cmboNombre.Name = "cmboNombre"
        Me.cmboNombre.Size = New System.Drawing.Size(121, 26)
        Me.cmboNombre.TabIndex = 3
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(348, 61)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(106, 26)
        Me.dtpFechaFin.TabIndex = 91
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Enabled = False
        Me.lblDe.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.lblDe.Location = New System.Drawing.Point(130, 63)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(37, 21)
        Me.lblDe.TabIndex = 89
        Me.lblDe.Text = "De:"
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Enabled = False
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(174, 60)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(109, 26)
        Me.dtpFechaInicio.TabIndex = 87
        '
        'rbPeriodo
        '
        Me.rbPeriodo.AutoSize = True
        Me.rbPeriodo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbPeriodo.Location = New System.Drawing.Point(18, 60)
        Me.rbPeriodo.Name = "rbPeriodo"
        Me.rbPeriodo.Size = New System.Drawing.Size(95, 25)
        Me.rbPeriodo.TabIndex = 1
        Me.rbPeriodo.Text = "Periodo:"
        Me.rbPeriodo.UseVisualStyleBackColor = True
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbNombre.Location = New System.Drawing.Point(19, 26)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(94, 25)
        Me.rbNombre.TabIndex = 0
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CasaEsther.My.Resources.Resources.Imagen1
        Me.PictureBox2.Location = New System.Drawing.Point(37, 17)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 122
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CasaEsther.My.Resources.Resources.ConsApartados
        Me.PictureBox1.Location = New System.Drawing.Point(268, 20)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
        '
        'frmConsultaApartados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 642)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgConsultaApartados)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaApartados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta Apartados"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgConsultaApartados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtSaldo As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtDom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgConsultaApartados As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmboIdCompra As ComboBox
    Friend WithEvents Compra As RadioButton
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblA As Label
    Friend WithEvents cmboNombre As ComboBox
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblDe As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents rbPeriodo As RadioButton
    Friend WithEvents rbNombre As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
