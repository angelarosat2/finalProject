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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarUsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContratosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ServiciosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CerrarSesionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UsuariosToolStripMenuItem, Me.ClientesToolStripMenuItem, Me.ContratosToolStripMenuItem, Me.ServiciosToolStripMenuItem, Me.EquiposToolStripMenuItem, Me.CerrarSesionToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(710, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarUsuariosToolStripMenuItem, Me.EliminarUsuariosToolStripMenuItem, Me.ModificarUsuariosToolStripMenuItem})
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.UsuariosToolStripMenuItem.Text = "Users"
        '
        'AgregarUsuariosToolStripMenuItem
        '
        Me.AgregarUsuariosToolStripMenuItem.Name = "AgregarUsuariosToolStripMenuItem"
        Me.AgregarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.AgregarUsuariosToolStripMenuItem.Text = "Agregar usuarios"
        '
        'EliminarUsuariosToolStripMenuItem
        '
        Me.EliminarUsuariosToolStripMenuItem.Name = "EliminarUsuariosToolStripMenuItem"
        Me.EliminarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.EliminarUsuariosToolStripMenuItem.Text = "Eliminar usuarios"
        '
        'ModificarUsuariosToolStripMenuItem
        '
        Me.ModificarUsuariosToolStripMenuItem.Name = "ModificarUsuariosToolStripMenuItem"
        Me.ModificarUsuariosToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.ModificarUsuariosToolStripMenuItem.Text = "Modificar usuarios"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ClientesToolStripMenuItem.Text = "Clients"
        '
        'ContratosToolStripMenuItem
        '
        Me.ContratosToolStripMenuItem.Name = "ContratosToolStripMenuItem"
        Me.ContratosToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ContratosToolStripMenuItem.Text = "Subscriptions"
        '
        'ServiciosToolStripMenuItem
        '
        Me.ServiciosToolStripMenuItem.Name = "ServiciosToolStripMenuItem"
        Me.ServiciosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.ServiciosToolStripMenuItem.Text = "Services"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.EquiposToolStripMenuItem.Text = "Equipos"
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
        Me.ClientSize = New System.Drawing.Size(710, 498)
        Me.Controls.Add(Me.MenuStrip1)
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
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContratosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ServiciosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarSesionToolStripMenuItem As ToolStripMenuItem
End Class
