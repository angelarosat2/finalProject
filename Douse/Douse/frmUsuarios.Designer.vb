<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmUsuarios))
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnModifyUser = New System.Windows.Forms.Button()
        Me.lvwUsers = New System.Windows.Forms.ListView()
        Me.email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.user = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnAddUser
        '
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), System.Drawing.Image)
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddUser.Location = New System.Drawing.Point(417, 26)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(85, 34)
        Me.btnAddUser.TabIndex = 0
        Me.btnAddUser.Text = "     Add user"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteUser.Image = CType(resources.GetObject("btnDeleteUser.Image"), System.Drawing.Image)
        Me.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteUser.Location = New System.Drawing.Point(508, 26)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(92, 34)
        Me.btnDeleteUser.TabIndex = 1
        Me.btnDeleteUser.Text = "     Delete user"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnModifyUser
        '
        Me.btnModifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModifyUser.Image = CType(resources.GetObject("btnModifyUser.Image"), System.Drawing.Image)
        Me.btnModifyUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyUser.Location = New System.Drawing.Point(606, 26)
        Me.btnModifyUser.Name = "btnModifyUser"
        Me.btnModifyUser.Size = New System.Drawing.Size(94, 34)
        Me.btnModifyUser.TabIndex = 2
        Me.btnModifyUser.Text = "     Modify user"
        Me.btnModifyUser.UseVisualStyleBackColor = True
        '
        'lvwUsers
        '
        Me.lvwUsers.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.email, Me.user, Me.password})
        Me.lvwUsers.FullRowSelect = True
        Me.lvwUsers.Location = New System.Drawing.Point(12, 79)
        Me.lvwUsers.Name = "lvwUsers"
        Me.lvwUsers.Size = New System.Drawing.Size(718, 359)
        Me.lvwUsers.TabIndex = 0
        Me.lvwUsers.UseCompatibleStateImageBehavior = False
        Me.lvwUsers.View = System.Windows.Forms.View.Details
        '
        'email
        '
        Me.email.Text = "email"
        Me.email.Width = 124
        '
        'user
        '
        Me.user.Text = "user"
        Me.user.Width = 285
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(33, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 3
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(184, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 42)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "USERS"
        '
        'password
        '
        Me.password.Text = "password"
        '
        'frmUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(742, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lvwUsers)
        Me.Controls.Add(Me.btnModifyUser)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmUsuarios"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddUser As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnModifyUser As Button
    Friend WithEvents lvwUsers As ListView
    Friend WithEvents email As ColumnHeader
    Friend WithEvents user As ColumnHeader
    Friend WithEvents btnBack As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents password As ColumnHeader
End Class
