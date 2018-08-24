<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevices))
        Dim ListViewItem5 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"COM 001", "Yes", "douse001", ""}, -1)
        Dim ListViewItem6 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"COM 002", "No", "douse002", "Levi Brittos"}, -1)
        Dim ListViewItem7 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"COM 003", "Yes", "douse003", ""}, -1)
        Dim ListViewItem8 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"COM 004", "No", "douse004", "Lucas Sanmartino"}, -1)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.DeviceID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Available = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AssignedTo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnModifyDevice = New System.Windows.Forms.Button()
        Me.btnDeleteDevice = New System.Windows.Forms.Button()
        Me.btnAddDevice = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(168, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 42)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "DEVICES"
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(33, 18)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 20
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.DeviceID, Me.Available, Me.Password, Me.AssignedTo})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem5, ListViewItem6, ListViewItem7, ListViewItem8})
        Me.ListView1.Location = New System.Drawing.Point(12, 74)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(718, 359)
        Me.ListView1.TabIndex = 16
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'DeviceID
        '
        Me.DeviceID.Text = "Device ID"
        Me.DeviceID.Width = 124
        '
        'Available
        '
        Me.Available.Text = "Available"
        Me.Available.Width = 121
        '
        'Password
        '
        Me.Password.Text = "Password"
        Me.Password.Width = 193
        '
        'AssignedTo
        '
        Me.AssignedTo.Text = "Assigned To"
        Me.AssignedTo.Width = 209
        '
        'btnModifyDevice
        '
        Me.btnModifyDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyDevice.Image = CType(resources.GetObject("btnModifyDevice.Image"), System.Drawing.Image)
        Me.btnModifyDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyDevice.Location = New System.Drawing.Point(606, 21)
        Me.btnModifyDevice.Name = "btnModifyDevice"
        Me.btnModifyDevice.Size = New System.Drawing.Size(99, 34)
        Me.btnModifyDevice.TabIndex = 19
        Me.btnModifyDevice.Text = "     Modify device"
        Me.btnModifyDevice.UseVisualStyleBackColor = True
        '
        'btnDeleteDevice
        '
        Me.btnDeleteDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteDevice.Image = CType(resources.GetObject("btnDeleteDevice.Image"), System.Drawing.Image)
        Me.btnDeleteDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteDevice.Location = New System.Drawing.Point(496, 21)
        Me.btnDeleteDevice.Name = "btnDeleteDevice"
        Me.btnDeleteDevice.Size = New System.Drawing.Size(104, 34)
        Me.btnDeleteDevice.TabIndex = 18
        Me.btnDeleteDevice.Text = "     Delete device"
        Me.btnDeleteDevice.UseVisualStyleBackColor = True
        '
        'btnAddDevice
        '
        Me.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDevice.Image = CType(resources.GetObject("btnAddDevice.Image"), System.Drawing.Image)
        Me.btnAddDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDevice.Location = New System.Drawing.Point(401, 21)
        Me.btnAddDevice.Name = "btnAddDevice"
        Me.btnAddDevice.Size = New System.Drawing.Size(89, 34)
        Me.btnAddDevice.TabIndex = 17
        Me.btnAddDevice.Text = "     Add device"
        Me.btnAddDevice.UseVisualStyleBackColor = True
        '
        'frmDevices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(742, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnModifyDevice)
        Me.Controls.Add(Me.btnDeleteDevice)
        Me.Controls.Add(Me.btnAddDevice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDevices"
        Me.Text = "frmDevices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents DeviceID As ColumnHeader
    Friend WithEvents Available As ColumnHeader
    Friend WithEvents AssignedTo As ColumnHeader
    Friend WithEvents btnModifyDevice As Button
    Friend WithEvents btnDeleteDevice As Button
    Friend WithEvents btnAddDevice As Button
    Friend WithEvents Password As ColumnHeader
End Class
