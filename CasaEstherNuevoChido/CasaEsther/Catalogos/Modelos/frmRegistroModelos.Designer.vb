<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroModelos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRegistroModelos))
        Me.dgModelo = New System.Windows.Forms.DataGridView()
        Me.IdModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CasaEstherDataSet = New CasaEsther.CasaEstherDataSet()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cmdSiguiente = New System.Windows.Forms.Button()
        Me.cmdUltimo = New System.Windows.Forms.Button()
        Me.cmdAnterior = New System.Windows.Forms.Button()
        Me.cmdInicio = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIdModelo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ModeloTableAdapter = New CasaEsther.CasaEstherDataSetTableAdapters.ModeloTableAdapter()
        Me.CategoriaTableAdapter = New CasaEsther.CasaEstherDataSetTableAdapters.CategoriaTableAdapter()
        Me.SqlSelectCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlConnection1 = New System.Data.SqlClient.SqlConnection()
        Me.SqlInsertCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlUpdateCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDeleteCommand1 = New System.Data.SqlClient.SqlCommand()
        Me.SqlDataAdapter1 = New System.Data.SqlClient.SqlDataAdapter()
        Me.cmdModificar = New System.Windows.Forms.Button()
        Me.cmdCancelar = New System.Windows.Forms.Button()
        Me.cmdSalir = New System.Windows.Forms.Button()
        Me.cmdGrabar = New System.Windows.Forms.Button()
        Me.cmdNuevo = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmdNuevo1 = New System.Windows.Forms.Button()
        CType(Me.dgModelo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ModeloBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CasaEstherDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgModelo
        '
        Me.dgModelo.AllowUserToAddRows = False
        Me.dgModelo.AllowUserToDeleteRows = False
        Me.dgModelo.AutoGenerateColumns = False
        Me.dgModelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgModelo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdModeloDataGridViewTextBoxColumn, Me.IdCategoriaDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn})
        Me.dgModelo.DataSource = Me.ModeloBindingSource
        Me.dgModelo.Location = New System.Drawing.Point(74, 242)
        Me.dgModelo.Name = "dgModelo"
        Me.dgModelo.ReadOnly = True
        Me.dgModelo.Size = New System.Drawing.Size(426, 150)
        Me.dgModelo.TabIndex = 92
        '
        'IdModeloDataGridViewTextBoxColumn
        '
        Me.IdModeloDataGridViewTextBoxColumn.DataPropertyName = "IdModelo"
        Me.IdModeloDataGridViewTextBoxColumn.HeaderText = "IdModelo"
        Me.IdModeloDataGridViewTextBoxColumn.Name = "IdModeloDataGridViewTextBoxColumn"
        Me.IdModeloDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IdCategoriaDataGridViewTextBoxColumn
        '
        Me.IdCategoriaDataGridViewTextBoxColumn.DataPropertyName = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.HeaderText = "IdCategoria"
        Me.IdCategoriaDataGridViewTextBoxColumn.Name = "IdCategoriaDataGridViewTextBoxColumn"
        Me.IdCategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 180
        '
        'ModeloBindingSource
        '
        Me.ModeloBindingSource.DataMember = "Modelo"
        Me.ModeloBindingSource.DataSource = Me.CasaEstherDataSet
        '
        'CasaEstherDataSet
        '
        Me.CasaEstherDataSet.DataSetName = "CasaEstherDataSet"
        Me.CasaEstherDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtDescripcion
        '
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModeloBindingSource, "Descripcion", True))
        Me.txtDescripcion.Enabled = False
        Me.txtDescripcion.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 61)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(361, 25)
        Me.txtDescripcion.TabIndex = 91
        '
        'cmdSiguiente
        '
        Me.cmdSiguiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdSiguiente.Location = New System.Drawing.Point(206, 208)
        Me.cmdSiguiente.Name = "cmdSiguiente"
        Me.cmdSiguiente.Size = New System.Drawing.Size(75, 23)
        Me.cmdSiguiente.TabIndex = 87
        Me.cmdSiguiente.Text = "Siguiente"
        Me.cmdSiguiente.UseVisualStyleBackColor = True
        '
        'cmdUltimo
        '
        Me.cmdUltimo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdUltimo.Location = New System.Drawing.Point(436, 208)
        Me.cmdUltimo.Name = "cmdUltimo"
        Me.cmdUltimo.Size = New System.Drawing.Size(75, 23)
        Me.cmdUltimo.TabIndex = 88
        Me.cmdUltimo.Text = "Último"
        Me.cmdUltimo.UseVisualStyleBackColor = True
        '
        'cmdAnterior
        '
        Me.cmdAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdAnterior.Location = New System.Drawing.Point(312, 208)
        Me.cmdAnterior.Name = "cmdAnterior"
        Me.cmdAnterior.Size = New System.Drawing.Size(75, 23)
        Me.cmdAnterior.TabIndex = 89
        Me.cmdAnterior.Text = "Anterior"
        Me.cmdAnterior.UseVisualStyleBackColor = True
        '
        'cmdInicio
        '
        Me.cmdInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.cmdInicio.Location = New System.Drawing.Point(79, 208)
        Me.cmdInicio.Name = "cmdInicio"
        Me.cmdInicio.Size = New System.Drawing.Size(75, 23)
        Me.cmdInicio.TabIndex = 90
        Me.cmdInicio.Text = "Inicio"
        Me.cmdInicio.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label5.Location = New System.Drawing.Point(10, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 21)
        Me.Label5.TabIndex = 81
        Me.Label5.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB", 14.25!)
        Me.Label2.Location = New System.Drawing.Point(20, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 80
        Me.Label2.Text = "Categoria:"
        '
        'txtIdModelo
        '
        Me.txtIdModelo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ModeloBindingSource, "IdModelo", True))
        Me.txtIdModelo.Enabled = False
        Me.txtIdModelo.Location = New System.Drawing.Point(118, 19)
        Me.txtIdModelo.Name = "txtIdModelo"
        Me.txtIdModelo.Size = New System.Drawing.Size(116, 22)
        Me.txtIdModelo.TabIndex = 76
        Me.txtIdModelo.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 16)
        Me.Label1.TabIndex = 86
        Me.Label1.Text = "IdModelo:"
        Me.Label1.Visible = False
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ModeloBindingSource, "IdCategoria", True))
        Me.cmbCategoria.DataSource = Me.CategoriaBindingSource
        Me.cmbCategoria.DisplayMember = "Concepto"
        Me.cmbCategoria.Enabled = False
        Me.cmbCategoria.Font = New System.Drawing.Font("Berlin Sans FB", 12.0!)
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(118, 21)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(180, 26)
        Me.cmbCategoria.TabIndex = 100
        Me.cmbCategoria.ValueMember = "IdCategoria"
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.CasaEstherDataSet
        '
        'ModeloTableAdapter
        '
        Me.ModeloTableAdapter.ClearBeforeFill = True
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'SqlSelectCommand1
        '
        Me.SqlSelectCommand1.CommandText = "SELECT        Modelo.*" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "FROM            Modelo"
        Me.SqlSelectCommand1.Connection = Me.SqlConnection1
        '
        'SqlConnection1
        '
        Me.SqlConnection1.ConnectionString = "Data Source=Victor-PC;Initial Catalog=CasaEsther;Integrated Security=True"
        Me.SqlConnection1.FireInfoMessageEventOnUserErrors = False
        '
        'SqlInsertCommand1
        '
        Me.SqlInsertCommand1.CommandText = "INSERT INTO [Modelo] ([IdModelo], [IdCategoria], [Descripcion]) VALUES (@IdModelo" &
    ", @IdCategoria, @Descripcion);" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "SELECT IdModelo, IdCategoria, Descripcion FROM M" &
    "odelo WHERE (IdModelo = @IdModelo)"
        Me.SqlInsertCommand1.Connection = Me.SqlConnection1
        Me.SqlInsertCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdModelo", System.Data.SqlDbType.Int, 0, "IdModelo"), New System.Data.SqlClient.SqlParameter("@IdCategoria", System.Data.SqlDbType.Int, 0, "IdCategoria"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.NVarChar, 0, "Descripcion")})
        '
        'SqlUpdateCommand1
        '
        Me.SqlUpdateCommand1.CommandText = resources.GetString("SqlUpdateCommand1.CommandText")
        Me.SqlUpdateCommand1.Connection = Me.SqlConnection1
        Me.SqlUpdateCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@IdModelo", System.Data.SqlDbType.Int, 0, "IdModelo"), New System.Data.SqlClient.SqlParameter("@IdCategoria", System.Data.SqlDbType.Int, 0, "IdCategoria"), New System.Data.SqlClient.SqlParameter("@Descripcion", System.Data.SqlDbType.NVarChar, 0, "Descripcion"), New System.Data.SqlClient.SqlParameter("@Original_IdModelo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdModelo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCategoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDeleteCommand1
        '
        Me.SqlDeleteCommand1.CommandText = resources.GetString("SqlDeleteCommand1.CommandText")
        Me.SqlDeleteCommand1.Connection = Me.SqlConnection1
        Me.SqlDeleteCommand1.Parameters.AddRange(New System.Data.SqlClient.SqlParameter() {New System.Data.SqlClient.SqlParameter("@Original_IdModelo", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdModelo", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@Original_IdCategoria", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "IdCategoria", System.Data.DataRowVersion.Original, Nothing), New System.Data.SqlClient.SqlParameter("@IsNull_Descripcion", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, True, Nothing, "", "", ""), New System.Data.SqlClient.SqlParameter("@Original_Descripcion", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, False, CType(0, Byte), CType(0, Byte), "Descripcion", System.Data.DataRowVersion.Original, Nothing)})
        '
        'SqlDataAdapter1
        '
        Me.SqlDataAdapter1.DeleteCommand = Me.SqlDeleteCommand1
        Me.SqlDataAdapter1.InsertCommand = Me.SqlInsertCommand1
        Me.SqlDataAdapter1.SelectCommand = Me.SqlSelectCommand1
        Me.SqlDataAdapter1.TableMappings.AddRange(New System.Data.Common.DataTableMapping() {New System.Data.Common.DataTableMapping("Table", "Modelo", New System.Data.Common.DataColumnMapping() {New System.Data.Common.DataColumnMapping("IdModelo", "IdModelo"), New System.Data.Common.DataColumnMapping("IdCategoria", "IdCategoria"), New System.Data.Common.DataColumnMapping("Descripcion", "Descripcion")})})
        Me.SqlDataAdapter1.UpdateCommand = Me.SqlUpdateCommand1
        '
        'cmdModificar
        '
        Me.cmdModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdModificar.Image = Global.CasaEsther.My.Resources.Resources.Modificar
        Me.cmdModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdModificar.Location = New System.Drawing.Point(121, 407)
        Me.cmdModificar.Name = "cmdModificar"
        Me.cmdModificar.Size = New System.Drawing.Size(117, 35)
        Me.cmdModificar.TabIndex = 105
        Me.cmdModificar.Text = "      Modificar"
        Me.cmdModificar.UseVisualStyleBackColor = True
        '
        'cmdCancelar
        '
        Me.cmdCancelar.Enabled = False
        Me.cmdCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdCancelar.Image = Global.CasaEsther.My.Resources.Resources.Camcelar
        Me.cmdCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancelar.Location = New System.Drawing.Point(360, 406)
        Me.cmdCancelar.Name = "cmdCancelar"
        Me.cmdCancelar.Size = New System.Drawing.Size(111, 35)
        Me.cmdCancelar.TabIndex = 104
        Me.cmdCancelar.Text = "       Cancelar"
        Me.cmdCancelar.UseVisualStyleBackColor = True
        '
        'cmdSalir
        '
        Me.cmdSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdSalir.Image = Global.CasaEsther.My.Resources.Resources.Salir
        Me.cmdSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdSalir.Location = New System.Drawing.Point(484, 405)
        Me.cmdSalir.Name = "cmdSalir"
        Me.cmdSalir.Size = New System.Drawing.Size(96, 36)
        Me.cmdSalir.TabIndex = 103
        Me.cmdSalir.Text = "       Salir"
        Me.cmdSalir.UseVisualStyleBackColor = True
        '
        'cmdGrabar
        '
        Me.cmdGrabar.Enabled = False
        Me.cmdGrabar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdGrabar.Image = Global.CasaEsther.My.Resources.Resources.Grabar
        Me.cmdGrabar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdGrabar.Location = New System.Drawing.Point(251, 407)
        Me.cmdGrabar.Name = "cmdGrabar"
        Me.cmdGrabar.Size = New System.Drawing.Size(96, 35)
        Me.cmdGrabar.TabIndex = 102
        Me.cmdGrabar.Text = "       Grabar"
        Me.cmdGrabar.UseVisualStyleBackColor = True
        '
        'cmdNuevo
        '
        Me.cmdNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdNuevo.Image = Global.CasaEsther.My.Resources.Resources.if_plus_1646001
        Me.cmdNuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo.Location = New System.Drawing.Point(-183, 371)
        Me.cmdNuevo.Name = "cmdNuevo"
        Me.cmdNuevo.Size = New System.Drawing.Size(96, 33)
        Me.cmdNuevo.TabIndex = 101
        Me.cmdNuevo.Text = "      Nuevo"
        Me.cmdNuevo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbCategoria)
        Me.GroupBox1.Controls.Add(Me.txtIdModelo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic)
        Me.GroupBox1.Location = New System.Drawing.Point(33, 99)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(512, 100)
        Me.GroupBox1.TabIndex = 106
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Modelo"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CasaEsther.My.Resources.Resources.RegMod
        Me.PictureBox1.Location = New System.Drawing.Point(137, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(346, 82)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 107
        Me.PictureBox1.TabStop = False
        '
        'cmdNuevo1
        '
        Me.cmdNuevo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!)
        Me.cmdNuevo1.Image = Global.CasaEsther.My.Resources.Resources.if_plus_1646001
        Me.cmdNuevo1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdNuevo1.Location = New System.Drawing.Point(12, 406)
        Me.cmdNuevo1.Name = "cmdNuevo1"
        Me.cmdNuevo1.Size = New System.Drawing.Size(96, 36)
        Me.cmdNuevo1.TabIndex = 117
        Me.cmdNuevo1.Text = "      Nuevo"
        Me.cmdNuevo1.UseVisualStyleBackColor = True
        '
        'frmRegistroModelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 451)
        Me.Controls.Add(Me.cmdNuevo1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdModificar)
        Me.Controls.Add(Me.cmdCancelar)
        Me.Controls.Add(Me.cmdSalir)
        Me.Controls.Add(Me.cmdGrabar)
        Me.Controls.Add(Me.cmdNuevo)
        Me.Controls.Add(Me.dgModelo)
        Me.Controls.Add(Me.cmdSiguiente)
        Me.Controls.Add(Me.cmdUltimo)
        Me.Controls.Add(Me.cmdAnterior)
        Me.Controls.Add(Me.cmdInicio)
        Me.Name = "frmRegistroModelos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modelos"
        CType(Me.dgModelo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ModeloBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CasaEstherDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgModelo As DataGridView
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents cmdSiguiente As Button
    Friend WithEvents cmdUltimo As Button
    Friend WithEvents cmdAnterior As Button
    Friend WithEvents cmdInicio As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtIdModelo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents CasaEstherDataSet As CasaEstherDataSet
    Friend WithEvents ModeloBindingSource As BindingSource
    Friend WithEvents ModeloTableAdapter As CasaEstherDataSetTableAdapters.ModeloTableAdapter
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As CasaEstherDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents IdModeloDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdCategoriaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SqlSelectCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlConnection1 As SqlClient.SqlConnection
    Friend WithEvents SqlInsertCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlUpdateCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDeleteCommand1 As SqlClient.SqlCommand
    Friend WithEvents SqlDataAdapter1 As SqlClient.SqlDataAdapter
    Friend WithEvents cmdModificar As System.Windows.Forms.Button
    Friend WithEvents cmdCancelar As System.Windows.Forms.Button
    Friend WithEvents cmdSalir As System.Windows.Forms.Button
    Friend WithEvents cmdGrabar As System.Windows.Forms.Button
    Friend WithEvents cmdNuevo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmdNuevo1 As Button
End Class
