<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaCompra
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
        Me.gbProveedor = New System.Windows.Forms.GroupBox()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtColonia = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.txtDom = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgConsultaCompra = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmboCompra = New System.Windows.Forms.ComboBox()
        Me.rbCompra = New System.Windows.Forms.RadioButton()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmboProveedor = New System.Windows.Forms.ComboBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.cmboFactura = New System.Windows.Forms.ComboBox()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.rbProveedor = New System.Windows.Forms.RadioButton()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.rbPeriodo = New System.Windows.Forms.RadioButton()
        Me.rbFactura = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbProveedor.SuspendLayout()
        CType(Me.dgConsultaCompra, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbProveedor
        '
        Me.gbProveedor.Controls.Add(Me.txtIdProveedor)
        Me.gbProveedor.Controls.Add(Me.Label1)
        Me.gbProveedor.Controls.Add(Me.txtNombre)
        Me.gbProveedor.Controls.Add(Me.txtColonia)
        Me.gbProveedor.Controls.Add(Me.Label18)
        Me.gbProveedor.Controls.Add(Me.txtTel)
        Me.gbProveedor.Controls.Add(Me.txtDom)
        Me.gbProveedor.Controls.Add(Me.Label4)
        Me.gbProveedor.Controls.Add(Me.txtCiudad)
        Me.gbProveedor.Controls.Add(Me.Label6)
        Me.gbProveedor.Controls.Add(Me.Label3)
        Me.gbProveedor.Controls.Add(Me.Label5)
        Me.gbProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.gbProveedor.Location = New System.Drawing.Point(20, 316)
        Me.gbProveedor.Name = "gbProveedor"
        Me.gbProveedor.Size = New System.Drawing.Size(744, 132)
        Me.gbProveedor.TabIndex = 126
        Me.gbProveedor.TabStop = False
        Me.gbProveedor.Text = "Datos del Proveedor"
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.Enabled = False
        Me.txtIdProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtIdProveedor.Location = New System.Drawing.Point(449, 106)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(138, 26)
        Me.txtIdProveedor.TabIndex = 131
        Me.txtIdProveedor.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(323, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 21)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "idProveedor:"
        Me.Label1.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.Enabled = False
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtNombre.Location = New System.Drawing.Point(95, 31)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(293, 26)
        Me.txtNombre.TabIndex = 129
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
        Me.btnSalir.Location = New System.Drawing.Point(347, 616)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 36)
        Me.btnSalir.TabIndex = 125
        Me.btnSalir.Text = "       Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgConsultaCompra
        '
        Me.dgConsultaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsultaCompra.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgConsultaCompra.Location = New System.Drawing.Point(66, 461)
        Me.dgConsultaCompra.Name = "dgConsultaCompra"
        Me.dgConsultaCompra.Size = New System.Drawing.Size(645, 150)
        Me.dgConsultaCompra.TabIndex = 124
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
        'Column4
        '
        Me.Column4.HeaderText = "Costo"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Importe"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CasaEsther.My.Resources.Resources.Imagen1
        Me.PictureBox2.Location = New System.Drawing.Point(20, 9)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 123
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmboCompra)
        Me.GroupBox1.Controls.Add(Me.rbCompra)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.cmboProveedor)
        Me.GroupBox1.Controls.Add(Me.lblA)
        Me.GroupBox1.Controls.Add(Me.cmboFactura)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.lblDe)
        Me.GroupBox1.Controls.Add(Me.rbProveedor)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.rbPeriodo)
        Me.GroupBox1.Controls.Add(Me.rbFactura)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(101, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 158)
        Me.GroupBox1.TabIndex = 122
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Consulta"
        '
        'cmboCompra
        '
        Me.cmboCompra.Enabled = False
        Me.cmboCompra.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.cmboCompra.FormattingEnabled = True
        Me.cmboCompra.Location = New System.Drawing.Point(109, 123)
        Me.cmboCompra.Name = "cmboCompra"
        Me.cmboCompra.Size = New System.Drawing.Size(121, 26)
        Me.cmboCompra.TabIndex = 132
        '
        'rbCompra
        '
        Me.rbCompra.AutoSize = True
        Me.rbCompra.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbCompra.Location = New System.Drawing.Point(17, 123)
        Me.rbCompra.Name = "rbCompra"
        Me.rbCompra.Size = New System.Drawing.Size(93, 25)
        Me.rbCompra.TabIndex = 92
        Me.rbCompra.Text = "Compra"
        Me.rbCompra.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Enabled = False
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAceptar.Location = New System.Drawing.Point(496, 93)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 32)
        Me.btnAceptar.TabIndex = 86
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmboProveedor
        '
        Me.cmboProveedor.Enabled = False
        Me.cmboProveedor.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.cmboProveedor.FormattingEnabled = True
        Me.cmboProveedor.Location = New System.Drawing.Point(131, 63)
        Me.cmboProveedor.Name = "cmboProveedor"
        Me.cmboProveedor.Size = New System.Drawing.Size(121, 26)
        Me.cmboProveedor.TabIndex = 4
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Enabled = False
        Me.lblA.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.lblA.Location = New System.Drawing.Point(305, 97)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(21, 21)
        Me.lblA.TabIndex = 90
        Me.lblA.Text = "a"
        '
        'cmboFactura
        '
        Me.cmboFactura.Enabled = False
        Me.cmboFactura.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.cmboFactura.FormattingEnabled = True
        Me.cmboFactura.Location = New System.Drawing.Point(131, 27)
        Me.cmboFactura.Name = "cmboFactura"
        Me.cmboFactura.Size = New System.Drawing.Size(121, 26)
        Me.cmboFactura.TabIndex = 3
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Enabled = False
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(348, 95)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(106, 26)
        Me.dtpFechaFin.TabIndex = 91
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Enabled = False
        Me.lblDe.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.lblDe.Location = New System.Drawing.Point(130, 97)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(37, 21)
        Me.lblDe.TabIndex = 89
        Me.lblDe.Text = "De:"
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbProveedor.Location = New System.Drawing.Point(18, 62)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(117, 25)
        Me.rbProveedor.TabIndex = 2
        Me.rbProveedor.Text = "Proveedor:"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Enabled = False
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(174, 94)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(109, 26)
        Me.dtpFechaInicio.TabIndex = 87
        '
        'rbPeriodo
        '
        Me.rbPeriodo.AutoSize = True
        Me.rbPeriodo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbPeriodo.Location = New System.Drawing.Point(18, 94)
        Me.rbPeriodo.Name = "rbPeriodo"
        Me.rbPeriodo.Size = New System.Drawing.Size(95, 25)
        Me.rbPeriodo.TabIndex = 1
        Me.rbPeriodo.Text = "Periodo:"
        Me.rbPeriodo.UseVisualStyleBackColor = True
        '
        'rbFactura
        '
        Me.rbFactura.AutoSize = True
        Me.rbFactura.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbFactura.Location = New System.Drawing.Point(19, 26)
        Me.rbFactura.Name = "rbFactura"
        Me.rbFactura.Size = New System.Drawing.Size(96, 25)
        Me.rbFactura.TabIndex = 0
        Me.rbFactura.Text = "Factura:"
        Me.rbFactura.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CasaEsther.My.Resources.Resources.ConsCompra
        Me.PictureBox1.Location = New System.Drawing.Point(290, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(305, 109)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
        '
        'frmConsultaCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 653)
        Me.Controls.Add(Me.gbProveedor)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgConsultaCompra)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmConsultaCompra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Compra"
        Me.gbProveedor.ResumeLayout(False)
        Me.gbProveedor.PerformLayout()
        CType(Me.dgConsultaCompra, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbProveedor As GroupBox
    Friend WithEvents txtIdProveedor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtColonia As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtDom As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgConsultaCompra As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbCompra As RadioButton
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cmboProveedor As ComboBox
    Friend WithEvents lblA As Label
    Friend WithEvents cmboFactura As ComboBox
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblDe As Label
    Friend WithEvents rbProveedor As RadioButton
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents rbPeriodo As RadioButton
    Friend WithEvents rbFactura As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmboCompra As System.Windows.Forms.ComboBox
End Class
