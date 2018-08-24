<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEquipos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEquipos))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"COM 001", "Yes", "douse001"}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"COM 002", "Yes", "douse002", ""}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"COM 003", "No", "douse003", "Levi Brittos"}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"COM 004", "No", "douse003", "Angela Rosa"}, -1)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.deviceID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.available = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.devicePassword = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.deviceAssignedTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnModifyUser = New System.Windows.Forms.Button()
        Me.btnDeleteDevice = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(176, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 42)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "DEVICES"
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(33, 19)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 13
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.deviceID, Me.available, Me.devicePassword, Me.deviceAssignedTo})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.ListView1.Location = New System.Drawing.Point(12, 75)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(718, 359)
        Me.ListView1.TabIndex = 9
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'deviceID
        '
        Me.deviceID.Text = "Device ID"
        Me.deviceID.Width = 124
        '
        'available
        '
        Me.available.Text = "Available"
        Me.available.Width = 171
        '
        'devicePassword
        '
        Me.devicePassword.Text = "Password"
        Me.devicePassword.Width = 302
        '
        'deviceAssignedTo
        '
        Me.deviceAssignedTo.Text = "Assigned To"
        Me.deviceAssignedTo.Width = 113
        '
        'btnModifyUser
        '
        Me.btnModifyUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnModifyUser.Image = CType(resources.GetObject("btnModifyUser.Image"), System.Drawing.Image)
        Me.btnModifyUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyUser.Location = New System.Drawing.Point(606, 22)
        Me.btnModifyUser.Name = "btnModifyUser"
        Me.btnModifyUser.Size = New System.Drawing.Size(99, 34)
        Me.btnModifyUser.TabIndex = 12
        Me.btnModifyUser.Text = "     Modify device"
        Me.btnModifyUser.UseVisualStyleBackColor = True
        '
        'btnDeleteDevice
        '
        Me.btnDeleteDevice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDeleteDevice.Image = CType(resources.GetObject("btnDeleteDevice.Image"), System.Drawing.Image)
        Me.btnDeleteDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteDevice.Location = New System.Drawing.Point(504, 22)
        Me.btnDeleteDevice.Name = "btnDeleteDevice"
        Me.btnDeleteDevice.Size = New System.Drawing.Size(96, 34)
        Me.btnDeleteDevice.TabIndex = 11
        Me.btnDeleteDevice.Text = "     Delete device"
        Me.btnDeleteDevice.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), System.Drawing.Image)
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddUser.Location = New System.Drawing.Point(413, 22)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(85, 34)
        Me.btnAddUser.TabIndex = 10
        Me.btnAddUser.Text = "     Add device"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'frmEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(742, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnModifyUser)
        Me.Controls.Add(Me.btnDeleteDevice)
        Me.Controls.Add(Me.btnAddUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmEquipos"
        Me.Text = "frmEquipos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents deviceID As ColumnHeader
    Friend WithEvents available As ColumnHeader
    Friend WithEvents devicePassword As ColumnHeader
    Friend WithEvents deviceAssignedTo As ColumnHeader
    Friend WithEvents btnModifyUser As Button
    Friend WithEvents btnDeleteDevice As Button
    Friend WithEvents btnAddUser As Button
End Class
