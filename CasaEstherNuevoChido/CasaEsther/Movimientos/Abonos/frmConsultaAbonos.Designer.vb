<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultaAbonos
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
        Me.dgConsultaAbonos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Client = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbArticulo = New System.Windows.Forms.RadioButton()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.lblA = New System.Windows.Forms.Label()
        Me.cmboArticulo = New System.Windows.Forms.ComboBox()
        Me.AbonoBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CasaEstherDataSet3 = New CasaEsther.CasaEstherDataSet3()
        Me.dtpFechaFin = New System.Windows.Forms.DateTimePicker()
        Me.lblDe = New System.Windows.Forms.Label()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.rbPeriodo = New System.Windows.Forms.RadioButton()
        Me.ApartadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CasaEstherDataSet2 = New CasaEsther.CasaEstherDataSet2()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ApartadoTableAdapter = New CasaEsther.CasaEstherDataSet2TableAdapters.ApartadoTableAdapter()
        Me.AbonoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonoTableAdapter = New CasaEsther.CasaEstherDataSet2TableAdapters.AbonoTableAdapter()
        Me.AbonoBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AbonoTableAdapter1 = New CasaEsther.CasaEstherDataSet3TableAdapters.AbonoTableAdapter()
        CType(Me.dgConsultaAbonos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AbonoBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasaEstherDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ApartadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasaEstherDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AbonoBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgConsultaAbonos
        '
        Me.dgConsultaAbonos.AllowUserToAddRows = False
        Me.dgConsultaAbonos.AllowUserToDeleteRows = False
        Me.dgConsultaAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsultaAbonos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Client, Me.Column6, Me.Column3, Me.Modelo, Me.Column4, Me.Column7})
        Me.dgConsultaAbonos.Location = New System.Drawing.Point(12, 293)
        Me.dgConsultaAbonos.Name = "dgConsultaAbonos"
        Me.dgConsultaAbonos.ReadOnly = True
        Me.dgConsultaAbonos.Size = New System.Drawing.Size(747, 150)
        Me.dgConsultaAbonos.TabIndex = 124
        '
        'Column1
        '
        Me.Column1.HeaderText = "idAbono"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Client
        '
        Me.Client.HeaderText = "Cliente"
        Me.Client.Name = "Client"
        Me.Client.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.HeaderText = "Fecha"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Articulo"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.HeaderText = "Restante"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbArticulo)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.lblA)
        Me.GroupBox1.Controls.Add(Me.cmboArticulo)
        Me.GroupBox1.Controls.Add(Me.dtpFechaFin)
        Me.GroupBox1.Controls.Add(Me.lblDe)
        Me.GroupBox1.Controls.Add(Me.dtpFechaInicio)
        Me.GroupBox1.Controls.Add(Me.rbPeriodo)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(104, 163)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(558, 115)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Consulta"
        '
        'rbArticulo
        '
        Me.rbArticulo.AutoSize = True
        Me.rbArticulo.Checked = True
        Me.rbArticulo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbArticulo.Location = New System.Drawing.Point(19, 31)
        Me.rbArticulo.Name = "rbArticulo"
        Me.rbArticulo.Size = New System.Drawing.Size(90, 25)
        Me.rbArticulo.TabIndex = 92
        Me.rbArticulo.TabStop = True
        Me.rbArticulo.Text = "Artículo"
        Me.rbArticulo.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.btnAceptar.Location = New System.Drawing.Point(474, 67)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 32)
        Me.btnAceptar.TabIndex = 86
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.lblA.Location = New System.Drawing.Point(305, 72)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(21, 21)
        Me.lblA.TabIndex = 90
        Me.lblA.Text = "a"
        Me.lblA.Visible = False
        '
        'cmboArticulo
        '
        Me.cmboArticulo.DataSource = Me.AbonoBindingSource2
        Me.cmboArticulo.DisplayMember = "IdArticulo"
        Me.cmboArticulo.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.cmboArticulo.FormattingEnabled = True
        Me.cmboArticulo.Location = New System.Drawing.Point(131, 28)
        Me.cmboArticulo.Name = "cmboArticulo"
        Me.cmboArticulo.Size = New System.Drawing.Size(121, 26)
        Me.cmboArticulo.TabIndex = 3
        Me.cmboArticulo.ValueMember = "IdArticulo"
        '
        'AbonoBindingSource2
        '
        Me.AbonoBindingSource2.DataMember = "Abono"
        Me.AbonoBindingSource2.DataSource = Me.CasaEstherDataSet3
        '
        'CasaEstherDataSet3
        '
        Me.CasaEstherDataSet3.DataSetName = "CasaEstherDataSet3"
        Me.CasaEstherDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'dtpFechaFin
        '
        Me.dtpFechaFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFin.Location = New System.Drawing.Point(348, 70)
        Me.dtpFechaFin.Name = "dtpFechaFin"
        Me.dtpFechaFin.Size = New System.Drawing.Size(106, 26)
        Me.dtpFechaFin.TabIndex = 91
        Me.dtpFechaFin.Visible = False
        '
        'lblDe
        '
        Me.lblDe.AutoSize = True
        Me.lblDe.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.lblDe.Location = New System.Drawing.Point(130, 72)
        Me.lblDe.Name = "lblDe"
        Me.lblDe.Size = New System.Drawing.Size(37, 21)
        Me.lblDe.TabIndex = 89
        Me.lblDe.Text = "De:"
        Me.lblDe.Visible = False
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(174, 69)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(109, 26)
        Me.dtpFechaInicio.TabIndex = 87
        Me.dtpFechaInicio.Visible = False
        '
        'rbPeriodo
        '
        Me.rbPeriodo.AutoSize = True
        Me.rbPeriodo.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.rbPeriodo.Location = New System.Drawing.Point(18, 69)
        Me.rbPeriodo.Name = "rbPeriodo"
        Me.rbPeriodo.Size = New System.Drawing.Size(95, 25)
        Me.rbPeriodo.TabIndex = 1
        Me.rbPeriodo.Text = "Periodo:"
        Me.rbPeriodo.UseVisualStyleBackColor = True
        '
        'ApartadoBindingSource
        '
        Me.ApartadoBindingSource.DataMember = "Apartado"
        Me.ApartadoBindingSource.DataSource = Me.CasaEstherDataSet2
        '
        'CasaEstherDataSet2
        '
        Me.CasaEstherDataSet2.DataSetName = "CasaEstherDataSet2"
        Me.CasaEstherDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSalir
        '
        Me.btnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.btnSalir.Image = Global.CasaEsther.My.Resources.Resources.Salir
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSalir.Location = New System.Drawing.Point(624, 449)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(96, 36)
        Me.btnSalir.TabIndex = 125
        Me.btnSalir.Text = "       Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CasaEsther.My.Resources.Resources.Imagen1
        Me.PictureBox2.Location = New System.Drawing.Point(37, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(152, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 122
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CasaEsther.My.Resources.Resources.ConsAbonos
        Me.PictureBox1.Location = New System.Drawing.Point(268, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(338, 125)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 121
        Me.PictureBox1.TabStop = False
        '
        'ApartadoTableAdapter
        '
        Me.ApartadoTableAdapter.ClearBeforeFill = True
        '
        'AbonoBindingSource
        '
        Me.AbonoBindingSource.DataMember = "Abono"
        Me.AbonoBindingSource.DataSource = Me.CasaEstherDataSet2
        '
        'AbonoTableAdapter
        '
        Me.AbonoTableAdapter.ClearBeforeFill = True
        '
        'AbonoBindingSource1
        '
        Me.AbonoBindingSource1.DataMember = "Abono"
        Me.AbonoBindingSource1.DataSource = Me.CasaEstherDataSet2
        '
        'AbonoTableAdapter1
        '
        Me.AbonoTableAdapter1.ClearBeforeFill = True
        '
        'frmConsultaAbonos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(771, 491)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgConsultaAbonos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "frmConsultaAbonos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmConsultaAbonos"
        CType(Me.dgConsultaAbonos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AbonoBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasaEstherDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ApartadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasaEstherDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AbonoBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgConsultaAbonos As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents lblA As Label
    Friend WithEvents dtpFechaFin As DateTimePicker
    Friend WithEvents lblDe As Label
    Friend WithEvents dtpFechaInicio As DateTimePicker
    Friend WithEvents rbPeriodo As RadioButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CasaEstherDataSet2 As CasaEstherDataSet2
    Friend WithEvents ApartadoBindingSource As BindingSource
    Friend WithEvents ApartadoTableAdapter As CasaEstherDataSet2TableAdapters.ApartadoTableAdapter
    Friend WithEvents AbonoBindingSource As BindingSource
    Friend WithEvents AbonoTableAdapter As CasaEstherDataSet2TableAdapters.AbonoTableAdapter
    Friend WithEvents cmboArticulo As ComboBox
    Friend WithEvents AbonoBindingSource1 As BindingSource
    Friend WithEvents CasaEstherDataSet3 As CasaEstherDataSet3
    Friend WithEvents AbonoBindingSource2 As BindingSource
    Friend WithEvents AbonoTableAdapter1 As CasaEstherDataSet3TableAdapters.AbonoTableAdapter
    Friend WithEvents rbArticulo As RadioButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Client As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Modelo As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
