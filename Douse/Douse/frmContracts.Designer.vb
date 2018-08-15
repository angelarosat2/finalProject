<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContracts
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContracts))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.148.618-2", "Fernanda Mayer", "RPI 120", "Pro"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.590.625-1", "Levi Brittos", "RPI 154", "Básico"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.295.562-9", "Lucas Sanmartino", "RPI 168", "Pro"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.101.056-5", "Angela Rosa", "RPI 195", "Medio"}, -1)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lvwContract = New System.Windows.Forms.ListView()
        Me.ClientDocument = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClientName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.raspberryPi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SubsciptionType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnModifyContract = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(28, 18)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 8
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lvwContract
        '
        Me.lvwContract.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClientDocument, Me.ClientName, Me.raspberryPi, Me.SubsciptionType})
        Me.lvwContract.FullRowSelect = True
        Me.lvwContract.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.lvwContract.Location = New System.Drawing.Point(12, 79)
        Me.lvwContract.Name = "lvwContract"
        Me.lvwContract.Size = New System.Drawing.Size(718, 359)
        Me.lvwContract.TabIndex = 4
        Me.lvwContract.UseCompatibleStateImageBehavior = False
        Me.lvwContract.View = System.Windows.Forms.View.Details
        '
        'ClientDocument
        '
        Me.ClientDocument.Text = "Client document"
        Me.ClientDocument.Width = 124
        '
        'ClientName
        '
        Me.ClientName.Text = "Client Name"
        Me.ClientName.Width = 268
        '
        'raspberryPi
        '
        Me.raspberryPi.Text = "Raspberry Pi ID"
        Me.raspberryPi.Width = 86
        '
        'SubsciptionType
        '
        Me.SubsciptionType.Text = "Subsciption Type"
        Me.SubsciptionType.Width = 229
        '
        'btnModifyContract
        '
        Me.btnModifyContract.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifyContract.Image = CType(resources.GetObject("btnModifyContract.Image"), System.Drawing.Image)
        Me.btnModifyContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyContract.Location = New System.Drawing.Point(601, 21)
        Me.btnModifyContract.Name = "btnModifyContract"
        Me.btnModifyContract.Size = New System.Drawing.Size(108, 34)
        Me.btnModifyContract.TabIndex = 7
        Me.btnModifyContract.Text = "     Modify contract"
        Me.btnModifyContract.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeleteUser.Image = CType(resources.GetObject("btnDeleteUser.Image"), System.Drawing.Image)
        Me.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteUser.Location = New System.Drawing.Point(486, 21)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(109, 34)
        Me.btnDeleteUser.TabIndex = 6
        Me.btnDeleteUser.Text = "     Delete contract"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), System.Drawing.Image)
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddUser.Location = New System.Drawing.Point(370, 21)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(110, 34)
        Me.btnAddUser.TabIndex = 5
        Me.btnAddUser.Text = "     Add contract"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(117, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(210, 42)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "CONTRACTS"
        '
        'frmContracts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(742, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lvwContract)
        Me.Controls.Add(Me.btnModifyContract)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmContracts"
        Me.Text = "frmContratos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lvwContract As ListView
    Friend WithEvents ClientDocument As ColumnHeader
    Friend WithEvents ClientName As ColumnHeader
    Friend WithEvents raspberryPi As ColumnHeader
    Friend WithEvents btnModifyContract As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnAddUser As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SubsciptionType As ColumnHeader
End Class
