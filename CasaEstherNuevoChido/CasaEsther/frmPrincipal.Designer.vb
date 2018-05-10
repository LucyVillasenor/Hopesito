<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CatalogosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroEmpleadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModelosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroModelosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroCategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MovimientosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroCompraArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaCompraArticuloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaVentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApartadosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeApartadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbonosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroAbonoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteArticulosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteProveedoresToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraDeArticulosPorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraDeArticulosPorProveedorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaPorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentaPorEmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApartadosPorClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApartadosPorPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ApartadosPorClienteEnUnPeriodoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtileriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestaurarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TraspasoAHistoricosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CerrarSesiónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Black
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI", 14.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CatalogosToolStripMenuItem, Me.MovimientosToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.UtileriasToolStripMenuItem, Me.CerrarSesiónToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Margin = New System.Windows.Forms.Padding(0, 2, 0, 0)
        Me.MenuStrip1.MaximumSize = New System.Drawing.Size(0, 50)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(651, 31)
        Me.MenuStrip1.TabIndex = 0
        '
        'CatalogosToolStripMenuItem
        '
        Me.CatalogosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmpleadosToolStripMenuItem, Me.ProveedoresToolStripMenuItem, Me.ArticulosToolStripMenuItem, Me.ModelosToolStripMenuItem, Me.CategoriasToolStripMenuItem, Me.UsuariosToolStripMenuItem})
        Me.CatalogosToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.CatalogosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CatalogosToolStripMenuItem.Name = "CatalogosToolStripMenuItem"
        Me.CatalogosToolStripMenuItem.Size = New System.Drawing.Size(108, 27)
        Me.CatalogosToolStripMenuItem.Text = "Catálogos"
        Me.CatalogosToolStripMenuItem.ToolTipText = "Catálogos de Casa Esther"
        '
        'EmpleadosToolStripMenuItem
        '
        Me.EmpleadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroEmpleadosToolStripMenuItem})
        Me.EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem"
        Me.EmpleadosToolStripMenuItem.Size = New System.Drawing.Size(188, 28)
        Me.EmpleadosToolStripMenuItem.Text = "Empleados"
        '
        'RegistroEmpleadosToolStripMenuItem
        '
        Me.RegistroEmpleadosToolStripMenuItem.Name = "RegistroEmpleadosToolStripMenuItem"
        Me.RegistroEmpleadosToolStripMenuItem.Size = New System.Drawing.Size(148, 28)
        Me.RegistroEmpleadosToolStripMenuItem.Text = "Registro"
        '
        'ProveedoresToolStripMenuItem
        '
        Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroProveedoresToolStripMenuItem})
        Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
        Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(188, 28)
        Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
        '
        'RegistroProveedoresToolStripMenuItem
        '
        Me.RegistroProveedoresToolStripMenuItem.Name = "RegistroProveedoresToolStripMenuItem"
        Me.RegistroProveedoresToolStripMenuItem.Size = New System.Drawing.Size(148, 28)
        Me.RegistroProveedoresToolStripMenuItem.Text = "Registro"
        '
        'ArticulosToolStripMenuItem
        '
        Me.ArticulosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroArticulosToolStripMenuItem})
        Me.ArticulosToolStripMenuItem.Name = "ArticulosToolStripMenuItem"
        Me.ArticulosToolStripMenuItem.Size = New System.Drawing.Size(188, 28)
        Me.ArticulosToolStripMenuItem.Text = "Artículos"
        '
        'RegistroArticulosToolStripMenuItem
        '
        Me.RegistroArticulosToolStripMenuItem.Name = "RegistroArticulosToolStripMenuItem"
        Me.RegistroArticulosToolStripMenuItem.Size = New System.Drawing.Size(148, 28)
        Me.RegistroArticulosToolStripMenuItem.Text = "Registro"
        '
        'ModelosToolStripMenuItem
        '
        Me.ModelosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroModelosToolStripMenuItem})
        Me.ModelosToolStripMenuItem.Name = "ModelosToolStripMenuItem"
        Me.ModelosToolStripMenuItem.Size = New System.Drawing.Size(188, 28)
        Me.ModelosToolStripMenuItem.Text = "Modelos"
        '
        'RegistroModelosToolStripMenuItem
        '
        Me.RegistroModelosToolStripMenuItem.Name = "RegistroModelosToolStripMenuItem"
        Me.RegistroModelosToolStripMenuItem.Size = New System.Drawing.Size(148, 28)
        Me.RegistroModelosToolStripMenuItem.Text = "Registro"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroCategoriasToolStripMenuItem})
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(188, 28)
        Me.CategoriasToolStripMenuItem.Text = "Categorías"
        '
        'RegistroCategoriasToolStripMenuItem
        '
        Me.RegistroCategoriasToolStripMenuItem.Name = "RegistroCategoriasToolStripMenuItem"
        Me.RegistroCategoriasToolStripMenuItem.Size = New System.Drawing.Size(148, 28)
        Me.RegistroCategoriasToolStripMenuItem.Text = "Registro"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(188, 28)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        Me.UsuariosToolStripMenuItem.Visible = False
        '
        'RegistroUsuariosToolStripMenuItem
        '
        Me.RegistroUsuariosToolStripMenuItem.Name = "RegistroUsuariosToolStripMenuItem"
        Me.RegistroUsuariosToolStripMenuItem.Size = New System.Drawing.Size(148, 28)
        Me.RegistroUsuariosToolStripMenuItem.Text = "Registro"
        '
        'MovimientosToolStripMenuItem
        '
        Me.MovimientosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompraArticuloToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ApartadosToolStripMenuItem, Me.AbonosToolStripMenuItem})
        Me.MovimientosToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.MovimientosToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MovimientosToolStripMenuItem.Name = "MovimientosToolStripMenuItem"
        Me.MovimientosToolStripMenuItem.Size = New System.Drawing.Size(130, 27)
        Me.MovimientosToolStripMenuItem.Text = "Movimientos"
        Me.MovimientosToolStripMenuItem.ToolTipText = "Movimientos de Casa Esther"
        '
        'CompraArticuloToolStripMenuItem
        '
        Me.CompraArticuloToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroCompraArticuloToolStripMenuItem, Me.ConsultaCompraArticuloToolStripMenuItem})
        Me.CompraArticuloToolStripMenuItem.Name = "CompraArticuloToolStripMenuItem"
        Me.CompraArticuloToolStripMenuItem.Size = New System.Drawing.Size(258, 28)
        Me.CompraArticuloToolStripMenuItem.Text = "Compra de Artículos"
        '
        'RegistroCompraArticuloToolStripMenuItem
        '
        Me.RegistroCompraArticuloToolStripMenuItem.Name = "RegistroCompraArticuloToolStripMenuItem"
        Me.RegistroCompraArticuloToolStripMenuItem.Size = New System.Drawing.Size(155, 28)
        Me.RegistroCompraArticuloToolStripMenuItem.Text = "Registro"
        '
        'ConsultaCompraArticuloToolStripMenuItem
        '
        Me.ConsultaCompraArticuloToolStripMenuItem.Name = "ConsultaCompraArticuloToolStripMenuItem"
        Me.ConsultaCompraArticuloToolStripMenuItem.Size = New System.Drawing.Size(155, 28)
        Me.ConsultaCompraArticuloToolStripMenuItem.Text = "Consulta"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroVentasToolStripMenuItem, Me.ConsultaVentasToolStripMenuItem})
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(258, 28)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'RegistroVentasToolStripMenuItem
        '
        Me.RegistroVentasToolStripMenuItem.Name = "RegistroVentasToolStripMenuItem"
        Me.RegistroVentasToolStripMenuItem.Size = New System.Drawing.Size(155, 28)
        Me.RegistroVentasToolStripMenuItem.Text = "Registro"
        '
        'ConsultaVentasToolStripMenuItem
        '
        Me.ConsultaVentasToolStripMenuItem.Name = "ConsultaVentasToolStripMenuItem"
        Me.ConsultaVentasToolStripMenuItem.Size = New System.Drawing.Size(155, 28)
        Me.ConsultaVentasToolStripMenuItem.Text = "Consulta"
        '
        'ApartadosToolStripMenuItem
        '
        Me.ApartadosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroDeApartadoToolStripMenuItem, Me.ConsultaToolStripMenuItem})
        Me.ApartadosToolStripMenuItem.Name = "ApartadosToolStripMenuItem"
        Me.ApartadosToolStripMenuItem.Size = New System.Drawing.Size(258, 28)
        Me.ApartadosToolStripMenuItem.Text = "Apartados"
        '
        'RegistroDeApartadoToolStripMenuItem
        '
        Me.RegistroDeApartadoToolStripMenuItem.Name = "RegistroDeApartadoToolStripMenuItem"
        Me.RegistroDeApartadoToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.RegistroDeApartadoToolStripMenuItem.Text = "Registro de Apartado"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(267, 28)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'AbonosToolStripMenuItem
        '
        Me.AbonosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistroAbonoToolStripMenuItem})
        Me.AbonosToolStripMenuItem.Name = "AbonosToolStripMenuItem"
        Me.AbonosToolStripMenuItem.Size = New System.Drawing.Size(258, 28)
        Me.AbonosToolStripMenuItem.Text = "Abonos"
        '
        'RegistroAbonoToolStripMenuItem
        '
        Me.RegistroAbonoToolStripMenuItem.Name = "RegistroAbonoToolStripMenuItem"
        Me.RegistroAbonoToolStripMenuItem.Size = New System.Drawing.Size(148, 28)
        Me.RegistroAbonoToolStripMenuItem.Text = "Registro"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ReporteArticulosToolStripMenuItem, Me.ReporteProveedoresToolStripMenuItem1, Me.ReporteClientesToolStripMenuItem, Me.CompraDeArticulosPorPeriodoToolStripMenuItem, Me.CompraDeArticulosPorProveedorToolStripMenuItem, Me.VentaPorPeriodoToolStripMenuItem, Me.VentaPorEmpleadoToolStripMenuItem, Me.ApartadosPorClienteToolStripMenuItem, Me.ApartadosPorPeriodoToolStripMenuItem, Me.ApartadosPorClienteEnUnPeriodoToolStripMenuItem})
        Me.ReportesToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReportesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(97, 27)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'ReporteArticulosToolStripMenuItem
        '
        Me.ReporteArticulosToolStripMenuItem.Name = "ReporteArticulosToolStripMenuItem"
        Me.ReporteArticulosToolStripMenuItem.Size = New System.Drawing.Size(397, 28)
        Me.ReporteArticulosToolStripMenuItem.Text = "Artículos"
        '
        'ReporteProveedoresToolStripMenuItem1
        '
        Me.ReporteProveedoresToolStripMenuItem1.Name = "ReporteProveedoresToolStripMenuItem1"
        Me.ReporteProveedoresToolStripMenuItem1.Size = New System.Drawing.Size(397, 28)
        Me.ReporteProveedoresToolStripMenuItem1.Text = "Proveedores"
        '
        'ReporteClientesToolStripMenuItem
        '
        Me.ReporteClientesToolStripMenuItem.Name = "ReporteClientesToolStripMenuItem"
        Me.ReporteClientesToolStripMenuItem.Size = New System.Drawing.Size(397, 28)
        Me.ReporteClientesToolStripMenuItem.Text = "Clientes"
        '
        'CompraDeArticulosPorPeriodoToolStripMenuItem
        '
        Me.CompraDeArticulosPorPeriodoToolStripMenuItem.Name = "CompraDeArticulosPorPeriodoToolStripMenuItem"
        Me.CompraDeArticulosPorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(397, 28)
        Me.CompraDeArticulosPorPeriodoToolStripMenuItem.Text = "Compra de Articulos por periodo"
        '
        'CompraDeArticulosPorProveedorToolStripMenuItem
        '
        Me.CompraDeArticulosPorProveedorToolStripMenuItem.Name = "CompraDeArticulosPorProveedorToolStripMenuItem"
        Me.CompraDeArticulosPorProveedorToolStripMenuItem.Size = New System.Drawing.Size(397, 28)
        Me.CompraDeArticulosPorProveedorToolStripMenuItem.Text = "Compra de Articulos por Proveedor"
        '
        'VentaPorPeriodoToolStripMenuItem
        '
        Me.VentaPorPeriodoToolStripMenuItem.Name = "VentaPorPeriodoToolStripMenuItem"
        Me.VentaPorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(397, 28)
        Me.VentaPorPeriodoToolStripMenuItem.Text = "Venta por periodo"
        '
        'VentaPorEmpleadoToolStripMenuItem
        '
        Me.VentaPorEmpleadoToolStripMenuItem.Name = "VentaPorEmpleadoToolStripMenuItem"
        Me.VentaPorEmpleadoToolStripMenuItem.Size = New System.Drawing.Size(397, 28)
        Me.VentaPorEmpleadoToolStripMenuItem.Text = "Venta por Empleado"
        '
        'ApartadosPorClienteToolStripMenuItem
        '
        Me.ApartadosPorClienteToolStripMenuItem.Name = "ApartadosPorClienteToolStripMenuItem"
        Me.ApartadosPorClienteToolStripMenuItem.Size = New System.Drawing.Size(397, 28)
        Me.ApartadosPorClienteToolStripMenuItem.Text = "Apartados por Cliente"
        '
        'ApartadosPorPeriodoToolStripMenuItem
        '
        Me.ApartadosPorPeriodoToolStripMenuItem.Name = "ApartadosPorPeriodoToolStripMenuItem"
        Me.ApartadosPorPeriodoToolStripMenuItem.Size = New System.Drawing.Size(397, 28)
        Me.ApartadosPorPeriodoToolStripMenuItem.Text = "Apartados por periodo"
        '
        'ApartadosPorClienteEnUnPeriodoToolStripMenuItem
        '
        Me.ApartadosPorClienteEnUnPeriodoToolStripMenuItem.Name = "ApartadosPorClienteEnUnPeriodoToolStripMenuItem"
        Me.ApartadosPorClienteEnUnPeriodoToolStripMenuItem.Size = New System.Drawing.Size(397, 28)
        Me.ApartadosPorClienteEnUnPeriodoToolStripMenuItem.Text = "Apartados por Cliente en un periodo"
        '
        'UtileriasToolStripMenuItem
        '
        Me.UtileriasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupToolStripMenuItem, Me.RestaurarToolStripMenuItem, Me.TraspasoAHistoricosToolStripMenuItem})
        Me.UtileriasToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.UtileriasToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.UtileriasToolStripMenuItem.Name = "UtileriasToolStripMenuItem"
        Me.UtileriasToolStripMenuItem.Size = New System.Drawing.Size(90, 27)
        Me.UtileriasToolStripMenuItem.Text = "Utilerias"
        '
        'BackupToolStripMenuItem
        '
        Me.BackupToolStripMenuItem.Name = "BackupToolStripMenuItem"
        Me.BackupToolStripMenuItem.Size = New System.Drawing.Size(342, 28)
        Me.BackupToolStripMenuItem.Text = "Copia de Seguridad (BackUp)"
        '
        'RestaurarToolStripMenuItem
        '
        Me.RestaurarToolStripMenuItem.Name = "RestaurarToolStripMenuItem"
        Me.RestaurarToolStripMenuItem.Size = New System.Drawing.Size(342, 28)
        Me.RestaurarToolStripMenuItem.Text = "Restaurar"
        '
        'TraspasoAHistoricosToolStripMenuItem
        '
        Me.TraspasoAHistoricosToolStripMenuItem.Name = "TraspasoAHistoricosToolStripMenuItem"
        Me.TraspasoAHistoricosToolStripMenuItem.Size = New System.Drawing.Size(342, 28)
        Me.TraspasoAHistoricosToolStripMenuItem.Text = "Traspaso a Históricos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.SalirToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(59, 27)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CasaEsther.My.Resources.Resources.Logo
        Me.PictureBox1.Location = New System.Drawing.Point(71, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 349)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'CerrarSesiónToolStripMenuItem
        '
        Me.CerrarSesiónToolStripMenuItem.Font = New System.Drawing.Font("Berlin Sans FB", 15.75!)
        Me.CerrarSesiónToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.CerrarSesiónToolStripMenuItem.Name = "CerrarSesiónToolStripMenuItem"
        Me.CerrarSesiónToolStripMenuItem.Size = New System.Drawing.Size(134, 27)
        Me.CerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(651, 395)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Casa Esther"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CatalogosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModelosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MovimientosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraArticuloToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UtileriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroEmpleadosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroModelosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroCategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroCompraArticuloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaCompraArticuloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultaVentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApartadosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeApartadoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbonosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RegistroAbonoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteArticulosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReporteProveedoresToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ReporteClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompraDeArticulosPorPeriodoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CompraDeArticulosPorProveedorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents VentaPorPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentaPorEmpleadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApartadosPorClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApartadosPorPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ApartadosPorClienteEnUnPeriodoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RestaurarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TraspasoAHistoricosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesiónToolStripMenuItem As ToolStripMenuItem
End Class
