<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.btnMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAgregarUsuario = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAgregarCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnContratos = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAgregarContrato = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnEquipos = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAgregarEquipo = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnMenu, Me.btnUsuario, Me.btnCliente, Me.btnContratos, Me.btnEquipos, Me.ServiciosToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(726, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnMenu
        '
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(50, 20)
        Me.btnMenu.Text = "Menu"
        '
        'btnUsuario
        '
        Me.btnUsuario.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarUsuario})
        Me.btnUsuario.Name = "btnUsuario"
        Me.btnUsuario.Size = New System.Drawing.Size(47, 20)
        Me.btnUsuario.Text = "Users"
        '
        'btnAgregarUsuario
        '
        Me.btnAgregarUsuario.Name = "btnAgregarUsuario"
        Me.btnAgregarUsuario.Size = New System.Drawing.Size(121, 22)
        Me.btnAgregarUsuario.Text = "Add user"
        '
        'btnCliente
        '
        Me.btnCliente.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarCliente})
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(55, 20)
        Me.btnCliente.Text = "Clients"
        '
        'btnAgregarCliente
        '
        Me.btnAgregarCliente.Name = "btnAgregarCliente"
        Me.btnAgregarCliente.Size = New System.Drawing.Size(180, 22)
        Me.btnAgregarCliente.Text = "Add client"
        '
        'btnContratos
        '
        Me.btnContratos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarContrato})
        Me.btnContratos.Name = "btnContratos"
        Me.btnContratos.Size = New System.Drawing.Size(70, 20)
        Me.btnContratos.Text = "Contracts"
        '
        'btnAgregarContrato
        '
        Me.btnAgregarContrato.Name = "btnAgregarContrato"
        Me.btnAgregarContrato.Size = New System.Drawing.Size(143, 22)
        Me.btnAgregarContrato.Text = "Add contract"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ServiciosToolStripMenuItem.Text = "Services"
        '
        'btnEquipos
        '
        Me.btnEquipos.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregarEquipo})
        Me.btnEquipos.Name = "btnEquipos"
        Me.btnEquipos.Size = New System.Drawing.Size(59, 20)
        Me.btnEquipos.Text = "Devices"
        '
        'btnAgregarEquipo
        '
        Me.btnAgregarEquipo.Name = "btnAgregarEquipo"
        Me.btnAgregarEquipo.Size = New System.Drawing.Size(180, 22)
        Me.btnAgregarEquipo.Text = "Add device"
        '
        'CerrarSesionToolStripMenuItem
        '
        Me.CerrarSesionToolStripMenuItem.Name = "CerrarSesionToolStripMenuItem"
        Me.CerrarSesionToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.CerrarSesionToolStripMenuItem.Text = "Log out"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(726, 451)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "Douse"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents btnUsuario As ToolStripMenuItem
    Friend WithEvents btnAgregarUsuario As ToolStripMenuItem
    Friend WithEvents btnContratos As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnEquipos As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnMenu As ToolStripMenuItem
    Friend WithEvents btnAgregarContrato As ToolStripMenuItem
    Friend WithEvents btnAgregarEquipo As ToolStripMenuItem
    Friend WithEvents btnCliente As ToolStripMenuItem
    Friend WithEvents btnAgregarCliente As ToolStripMenuItem
End Class
