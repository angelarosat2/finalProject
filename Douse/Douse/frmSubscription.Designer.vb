<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSubscription))
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lvwSubscription = New System.Windows.Forms.ListView()
        Me.number = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
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
        Me.Label5.Location = New System.Drawing.Point(128, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(282, 42)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "SUBSCRIPTIONS"
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(62, 18)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 26
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lvwSubscription
        '
        Me.lvwSubscription.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.number, Me.description, Me.price})
        Me.lvwSubscription.FullRowSelect = True
        Me.lvwSubscription.Location = New System.Drawing.Point(41, 74)
        Me.lvwSubscription.Name = "lvwSubscription"
        Me.lvwSubscription.Size = New System.Drawing.Size(718, 359)
        Me.lvwSubscription.TabIndex = 22
        Me.lvwSubscription.UseCompatibleStateImageBehavior = False
        Me.lvwSubscription.View = System.Windows.Forms.View.Details
        '
        'number
        '
        Me.number.Text = "Number"
        Me.number.Width = 91
        '
        'description
        '
        Me.description.Text = "Description"
        Me.description.Width = 304
        '
        'price
        '
        Me.price.Text = "Price"
        Me.price.Width = 193
        '
        'btnModifyDevice
        '
        Me.btnModifyDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyDevice.Image = CType(resources.GetObject("btnModifyDevice.Image"), System.Drawing.Image)
        Me.btnModifyDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyDevice.Location = New System.Drawing.Point(635, 21)
        Me.btnModifyDevice.Name = "btnModifyDevice"
        Me.btnModifyDevice.Size = New System.Drawing.Size(99, 34)
        Me.btnModifyDevice.TabIndex = 25
        Me.btnModifyDevice.Text = "     Modify device"
        Me.btnModifyDevice.UseVisualStyleBackColor = True
        '
        'btnDeleteDevice
        '
        Me.btnDeleteDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteDevice.Image = CType(resources.GetObject("btnDeleteDevice.Image"), System.Drawing.Image)
        Me.btnDeleteDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteDevice.Location = New System.Drawing.Point(525, 21)
        Me.btnDeleteDevice.Name = "btnDeleteDevice"
        Me.btnDeleteDevice.Size = New System.Drawing.Size(104, 34)
        Me.btnDeleteDevice.TabIndex = 24
        Me.btnDeleteDevice.Text = "     Delete device"
        Me.btnDeleteDevice.UseVisualStyleBackColor = True
        '
        'btnAddDevice
        '
        Me.btnAddDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddDevice.Image = CType(resources.GetObject("btnAddDevice.Image"), System.Drawing.Image)
        Me.btnAddDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddDevice.Location = New System.Drawing.Point(430, 21)
        Me.btnAddDevice.Name = "btnAddDevice"
        Me.btnAddDevice.Size = New System.Drawing.Size(89, 34)
        Me.btnAddDevice.TabIndex = 23
        Me.btnAddDevice.Text = "     Add device"
        Me.btnAddDevice.UseVisualStyleBackColor = True
        '
        'frmSubscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lvwSubscription)
        Me.Controls.Add(Me.btnModifyDevice)
        Me.Controls.Add(Me.btnDeleteDevice)
        Me.Controls.Add(Me.btnAddDevice)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmSubscription"
        Me.Text = "frmSubscription"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents lvwSubscription As ListView
    Friend WithEvents number As ColumnHeader
    Friend WithEvents description As ColumnHeader
    Friend WithEvents price As ColumnHeader
    Friend WithEvents btnModifyDevice As Button
    Friend WithEvents btnDeleteDevice As Button
    Friend WithEvents btnAddDevice As Button
End Class
