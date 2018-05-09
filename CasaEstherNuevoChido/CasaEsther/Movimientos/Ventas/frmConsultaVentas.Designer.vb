<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaVentas
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
        Me.components = New System.ComponentModel.Container()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.gbEmpleado = New System.Windows.Forms.GroupBox()
        Me.txtIdEmpleado = New System.Windows.Forms.TextBox()
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
        Me.dgVenta = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmboIdVenta = New System.Windows.Forms.ComboBox()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CasaEstherDataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CasaEstherDataSet4 = New CasaEsther.CasaEstherDataSet4()
        Me.rbIdVenta = New System.Windows.Forms.RadioButton()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.cmboEmpleado = New System.Windows.Forms.ComboBox()
        Me.EmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblA = New System.Windows.Forms.Label()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.rbPeriodo = New System.Windows.Forms.RadioButton()
        Me.VentaTableAdapter = New CasaEsther.CasaEstherDataSet4TableAdapters.VentaTableAdapter()
        Me.EmpleadoTableAdapter = New CasaEsther.CasaEstherDataSet4TableAdapters.EmpleadoTableAdapter()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbEmpleado.SuspendLayout()
        CType(Me.dgVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasaEstherDataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasaEstherDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CasaEsther.My.Resources.Resources.Imagen1
        Me.PictureBox1.Location = New System.Drawing.Point(33, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(119, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 106
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CasaEsther.My.Resources.Resources.ConsVentas
        Me.PictureBox2.Location = New System.Drawing.Point(240, 14)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(305, 109)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 112
        Me.PictureBox2.TabStop = False
        '
        'gbEmpleado
        '
        Me.gbEmpleado.Controls.Add(Me.txtIdEmpleado)
        Me.gbEmpleado.Controls.Add(Me.Label1)
        Me.gbEmpleado.Controls.Add(Me.txtNombre)
        Me.gbEmpleado.Controls.Add(Me.txtColonia)
        Me.gbEmpleado.Controls.Add(Me.Label18)
        Me.gbEmpleado.Controls.Add(Me.txtTel)
        Me.gbEmpleado.Controls.Add(Me.txtDom)
        Me.gbEmpleado.Controls.Add(Me.Label4)
        Me.gbEmpleado.Controls.Add(Me.txtCiudad)
        Me.gbEmpleado.Controls.Add(Me.Label6)
        Me.gbEmpleado.Controls.Add(Me.Label3)
        Me.gbEmpleado.Controls.Add(Me.Label5)
        Me.gbEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.gbEmpleado.Location = New System.Drawing.Point(22, 291)
        Me.gbEmpleado.Name = "gbEmpleado"
        Me.gbEmpleado.Size = New System.Drawing.Size(744, 132)
        Me.gbEmpleado.TabIndex = 130
        Me.gbEmpleado.TabStop = False
        Me.gbEmpleado.Text = "Datos del Empleado"
        Me.gbEmpleado.Visible = False
        '
        'txtIdEmpleado
        '
        Me.txtIdEmpleado.Enabled = False
        Me.txtIdEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtIdEmpleado.Location = New System.Drawing.Point(449, 106)
        Me.txtIdEmpleado.Name = "txtIdEmpleado"
        Me.txtIdEmpleado.Size = New System.Drawing.Size(138, 26)
        Me.txtIdEmpleado.TabIndex = 131
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label1.Location = New System.Drawing.Point(323, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 21)
        Me.Label1.TabIndex = 130
        Me.Label1.Text = "idEmpleado:"
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
        Me.btnSalir.Location = New System.Drawing.Point(349, 597)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 36)
        Me.btnSalir.TabIndex = 129
        Me.btnSalir.Text = "       Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'dgVenta
        '
        Me.dgVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgVenta.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgVenta.Location = New System.Drawing.Point(68, 434)
        Me.dgVenta.Name = "dgVenta"
        Me.dgVenta.Size = New System.Drawing.Size(645, 150)
        Me.dgVenta.TabIndex = 128
        '
        'Column1
        '
        Me.Column1.HeaderText = "idArticulo"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Modelo"
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
        Me.Column5.HeaderText = "Subtotal"
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
        Me.GroupBox1.Controls.Add(Me.cmboIdVenta)
        Me.GroupBox1.Controls.Add(Me.rbIdVenta)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.cmboEmpleado)
        Me.GroupBox1.Controls.Add(Me.lblA)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.lblDe)
        Me.GroupBox1.Controls.Add(Me.rbEmpleado)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.rbPeriodo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(103, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(622, 144)
        Me.GroupBox1.TabIndex = 127
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Consulta"
        '
        'cmboIdVenta
        '
        Me.cmboIdVenta.DataSource = Me.VentaBindingSource
        Me.cmboIdVenta.DisplayMember = "IdVenta"
        Me.cmboIdVenta.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.cmboIdVenta.FormattingEnabled = True
        Me.cmboIdVenta.Location = New System.Drawing.Point(130, 22)
        Me.cmboIdVenta.Name = "cmboIdVenta"
        Me.cmboIdVenta.Size = New System.Drawing.Size(121, 26)
        Me.cmboIdVenta.TabIndex = 93
        Me.cmboIdVenta.ValueMember = "IdVenta"
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.CasaEstherDataSet4BindingSource
        '
        'CasaEstherDataSet4BindingSource
        '
        Me.CasaEstherDataSet4BindingSource.DataSource = Me.CasaEstherDataSet4
        Me.CasaEstherDataSet4BindingSource.Position = 0
        '
        'CasaEstherDataSet4
        '
        Me.CasaEstherDataSet4.DataSetName = "CasaEstherDataSet4"
        Me.CasaEstherDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'rbIdVenta
        '
        Me.rbIdVenta.AutoSize = True
        Me.rbIdVenta.Checked = True
        Me.rbIdVenta.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbIdVenta.Location = New System.Drawing.Point(18, 21)
        Me.rbIdVenta.Name = "rbIdVenta"
        Me.rbIdVenta.Size = New System.Drawing.Size(97, 25)
        Me.rbIdVenta.TabIndex = 92
        Me.rbIdVenta.TabStop = True
        Me.rbIdVenta.Text = "idVenta:"
        Me.rbIdVenta.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAceptar.Location = New System.Drawing.Point(496, 96)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 32)
        Me.btnAceptar.TabIndex = 86
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'cmboEmpleado
        '
        Me.cmboEmpleado.DataSource = Me.EmpleadoBindingSource
        Me.cmboEmpleado.DisplayMember = "Nombre"
        Me.cmboEmpleado.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.cmboEmpleado.FormattingEnabled = True
        Me.cmboEmpleado.Location = New System.Drawing.Point(131, 65)
        Me.cmboEmpleado.Name = "cmboEmpleado"
        Me.cmboEmpleado.Size = New System.Drawing.Size(121, 26)
        Me.cmboEmpleado.TabIndex = 4
        Me.cmboEmpleado.ValueMember = "IdEmpleado"
        '
        'EmpleadoBindingSource
        '
        Me.EmpleadoBindingSource.DataMember = "Empleado"
        Me.EmpleadoBindingSource.DataSource = Me.CasaEstherDataSet4BindingSource
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.lblA.Location = New System.Drawing.Point(305, 100)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(21, 21)
        Me.lblA.TabIndex = 90
        Me.lblA.Text = "a"
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(348, 98)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(106, 26)
        Me.dtpFechaFin.TabIndex = 91
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.lblDe.Location = New System.Drawing.Point(130, 100)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(37, 21)
        Me.lblDe.TabIndex = 89
        Me.lblDe.Text = "De:"
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbEmpleado.Location = New System.Drawing.Point(18, 64)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(115, 25)
        Me.rbEmpleado.TabIndex = 2
        Me.rbEmpleado.Text = "Empleado:"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(174, 97)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(109, 26)
        Me.dtpFechaInicio.TabIndex = 87
        '
        'rbPeriodo
        '
        Me.rbPeriodo.AutoSize = True
        Me.rbPeriodo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbPeriodo.Location = New System.Drawing.Point(18, 97)
        Me.rbPeriodo.Name = "rbPeriodo"
        Me.rbPeriodo.Size = New System.Drawing.Size(95, 25)
        Me.rbPeriodo.TabIndex = 1
        Me.rbPeriodo.Text = "Periodo:"
        Me.rbPeriodo.UseVisualStyleBackColor = True
        '
        'VentaTableAdapter
        '
        Me.VentaTableAdapter.ClearBeforeFill = True
        '
        'EmpleadoTableAdapter
        '
        Me.EmpleadoTableAdapter.ClearBeforeFill = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(559, 599)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 21)
        Me.Label2.TabIndex = 121
        Me.Label2.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.txtTotal.Location = New System.Drawing.Point(622, 597)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(91, 26)
        Me.txtTotal.TabIndex = 123
        '
        'frmConsultaVentas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(785, 653)
        Me.Controls.Add(Me.gbEmpleado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgVenta)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmConsultaVentas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Ventas"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbEmpleado.ResumeLayout(False)
        Me.gbEmpleado.PerformLayout()
        CType(Me.dgVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasaEstherDataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasaEstherDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents gbEmpleado As GroupBox
    Friend WithEvents txtIdEmpleado As TextBox
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
    Friend WithEvents dgVenta As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cmboIdVenta As ComboBox
    Friend WithEvents rbIdVenta As RadioButton
    Friend WithEvents btnAceptar As Button
    Friend WithEvents cmboEmpleado As ComboBox
    Friend WithEvents lblA As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblDe As Label
    Friend WithEvents rbEmpleado As RadioButton
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents rbPeriodo As RadioButton
    Friend WithEvents CasaEstherDataSet4BindingSource As BindingSource
    Friend WithEvents CasaEstherDataSet4 As CasaEstherDataSet4
    Friend WithEvents VentaBindingSource As BindingSource
    Friend WithEvents VentaTableAdapter As CasaEstherDataSet4TableAdapters.VentaTableAdapter
    Friend WithEvents EmpleadoBindingSource As BindingSource
    Friend WithEvents EmpleadoTableAdapter As CasaEstherDataSet4TableAdapters.EmpleadoTableAdapter
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
End Class
