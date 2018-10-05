<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmOpciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOpciones))
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnEquipos = New System.Windows.Forms.Button()
        Me.btnServices = New System.Windows.Forms.Button()
        Me.btnSubscriptions = New System.Windows.Forms.Button()
        Me.btnClients = New System.Windows.Forms.Button()
        Me.btnUsers = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLogout
        '
        Me.btnLogout.Cursor = System.Windows.Forms.Cursors.Default
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Image = CType(resources.GetObject("btnLogout.Image"), System.Drawing.Image)
        Me.btnLogout.Location = New System.Drawing.Point(500, 265)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(172, 170)
        Me.btnLogout.TabIndex = 18
        Me.btnLogout.Text = "Log out"
        Me.btnLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnEquipos
        '
        Me.btnEquipos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEquipos.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEquipos.Image = CType(resources.GetObject("btnEquipos.Image"), System.Drawing.Image)
        Me.btnEquipos.Location = New System.Drawing.Point(284, 265)
        Me.btnEquipos.Name = "btnEquipos"
        Me.btnEquipos.Size = New System.Drawing.Size(172, 170)
        Me.btnEquipos.TabIndex = 17
        Me.btnEquipos.Text = "Devices"
        Me.btnEquipos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEquipos.UseVisualStyleBackColor = True
        '
        'btnServices
        '
        Me.btnServices.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnServices.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnServices.Image = CType(resources.GetObject("btnServices.Image"), System.Drawing.Image)
        Me.btnServices.Location = New System.Drawing.Point(67, 265)
        Me.btnServices.Name = "btnServices"
        Me.btnServices.Size = New System.Drawing.Size(172, 170)
        Me.btnServices.TabIndex = 16
        Me.btnServices.Text = "Services"
        Me.btnServices.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnServices.UseVisualStyleBackColor = True
        '
        'btnSubscriptions
        '
        Me.btnSubscriptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSubscriptions.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubscriptions.Image = CType(resources.GetObject("btnSubscriptions.Image"), System.Drawing.Image)
        Me.btnSubscriptions.Location = New System.Drawing.Point(500, 69)
        Me.btnSubscriptions.Name = "btnSubscriptions"
        Me.btnSubscriptions.Size = New System.Drawing.Size(172, 170)
        Me.btnSubscriptions.TabIndex = 15
        Me.btnSubscriptions.Text = "Contracts"
        Me.btnSubscriptions.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSubscriptions.UseVisualStyleBackColor = True
        '
        'btnClients
        '
        Me.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClients.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClients.Image = CType(resources.GetObject("btnClients.Image"), System.Drawing.Image)
        Me.btnClients.Location = New System.Drawing.Point(284, 69)
        Me.btnClients.Name = "btnClients"
        Me.btnClients.Size = New System.Drawing.Size(172, 170)
        Me.btnClients.TabIndex = 14
        Me.btnClients.Text = "Clients"
        Me.btnClients.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnClients.UseVisualStyleBackColor = True
        '
        'btnUsers
        '
        Me.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUsers.Font = New System.Drawing.Font("Bahnschrift", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUsers.Image = CType(resources.GetObject("btnUsers.Image"), System.Drawing.Image)
        Me.btnUsers.Location = New System.Drawing.Point(67, 69)
        Me.btnUsers.Name = "btnUsers"
        Me.btnUsers.Size = New System.Drawing.Size(172, 170)
        Me.btnUsers.TabIndex = 13
        Me.btnUsers.Text = "Users"
        Me.btnUsers.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnUsers.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(311, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 42)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "MENU"
        '
        'frmOpciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(742, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnLogout)
        Me.Controls.Add(Me.btnEquipos)
        Me.Controls.Add(Me.btnServices)
        Me.Controls.Add(Me.btnSubscriptions)
        Me.Controls.Add(Me.btnClients)
        Me.Controls.Add(Me.btnUsers)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmOpciones"
        Me.Text = "Opciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLogout As Button
    Friend WithEvents btnEquipos As Button
    Friend WithEvents btnServices As Button
    Friend WithEvents btnSubscriptions As Button
    Friend WithEvents btnClients As Button
    Friend WithEvents btnUsers As Button
    Friend WithEvents Label5 As Label
End Class
