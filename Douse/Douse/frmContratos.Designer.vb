<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmContratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmContratos))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.148.618-2", "fmayer", "dousep1"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.590.625-1", "lbrittos", "dousep2"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.295.562-9", "lsanmartino", "dousep3"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.101.056-5", "arosa", "dousep4"}, -1)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lvwContract = New System.Windows.Forms.ListView()
        Me.document = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.user = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.password = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnModifyContract = New System.Windows.Forms.Button()
        Me.btnDeleteUser = New System.Windows.Forms.Button()
        Me.btnAddUser = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(58, 18)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 8
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lvwContract
        '
        Me.lvwContract.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.document, Me.user, Me.password})
        Me.lvwContract.FullRowSelect = True
        Me.lvwContract.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.lvwContract.Location = New System.Drawing.Point(37, 74)
        Me.lvwContract.Name = "lvwContract"
        Me.lvwContract.Size = New System.Drawing.Size(718, 359)
        Me.lvwContract.TabIndex = 4
        Me.lvwContract.UseCompatibleStateImageBehavior = False
        Me.lvwContract.View = System.Windows.Forms.View.Details
        '
        'document
        '
        Me.document.Text = "document"
        Me.document.Width = 124
        '
        'user
        '
        Me.user.Text = "user"
        Me.user.Width = 285
        '
        'password
        '
        Me.password.Text = "password"
        Me.password.Width = 302
        '
        'btnModifyContract
        '
        Me.btnModifyContract.Image = CType(resources.GetObject("btnModifyContract.Image"), System.Drawing.Image)
        Me.btnModifyContract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyContract.Location = New System.Drawing.Point(631, 21)
        Me.btnModifyContract.Name = "btnModifyContract"
        Me.btnModifyContract.Size = New System.Drawing.Size(108, 34)
        Me.btnModifyContract.TabIndex = 7
        Me.btnModifyContract.Text = "     Modify contract"
        Me.btnModifyContract.UseVisualStyleBackColor = True
        '
        'btnDeleteUser
        '
        Me.btnDeleteUser.Image = CType(resources.GetObject("btnDeleteUser.Image"), System.Drawing.Image)
        Me.btnDeleteUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteUser.Location = New System.Drawing.Point(522, 21)
        Me.btnDeleteUser.Name = "btnDeleteUser"
        Me.btnDeleteUser.Size = New System.Drawing.Size(103, 34)
        Me.btnDeleteUser.TabIndex = 6
        Me.btnDeleteUser.Text = "     Delete contract"
        Me.btnDeleteUser.UseVisualStyleBackColor = True
        '
        'btnAddUser
        '
        Me.btnAddUser.Image = CType(resources.GetObject("btnAddUser.Image"), System.Drawing.Image)
        Me.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddUser.Location = New System.Drawing.Point(406, 21)
        Me.btnAddUser.Name = "btnAddUser"
        Me.btnAddUser.Size = New System.Drawing.Size(110, 34)
        Me.btnAddUser.TabIndex = 5
        Me.btnAddUser.Text = "     Add contract"
        Me.btnAddUser.UseVisualStyleBackColor = True
        '
        'frmContratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lvwContract)
        Me.Controls.Add(Me.btnModifyContract)
        Me.Controls.Add(Me.btnDeleteUser)
        Me.Controls.Add(Me.btnAddUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmContratos"
        Me.Text = "frmContratos"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lvwContract As ListView
    Friend WithEvents document As ColumnHeader
    Friend WithEvents user As ColumnHeader
    Friend WithEvents password As ColumnHeader
    Friend WithEvents btnModifyContract As Button
    Friend WithEvents btnDeleteUser As Button
    Friend WithEvents btnAddUser As Button
End Class
