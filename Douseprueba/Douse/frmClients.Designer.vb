﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClients
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClients))
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.148.618-2", "Fernanda Mayer", "Canelones 1162", "091 689 277", "120"}, -1)
        Dim ListViewItem2 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.590.625-1", "Levi Brittos", "Canelones 1162", "095 109 991", "154"}, -1)
        Dim ListViewItem3 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.295.562-9", "Lucas Sanmartino", "Canelones 1162", "094 467 141", "168"}, -1)
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.101.056-5", "Angela Rosa", "Canelones 1162", "095 033 690", "195"}, -1)
        Me.btnBack = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Documento = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Direccion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Contacto = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.RaspberryPi = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnModifyClient = New System.Windows.Forms.Button()
        Me.btnDeleteClient = New System.Windows.Forms.Button()
        Me.btnAddClient = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Image = CType(resources.GetObject("btnBack.Image"), System.Drawing.Image)
        Me.btnBack.Location = New System.Drawing.Point(41, 14)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(46, 41)
        Me.btnBack.TabIndex = 8
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Documento, Me.Nombre, Me.Direccion, Me.Contacto, Me.RaspberryPi})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1, ListViewItem2, ListViewItem3, ListViewItem4})
        Me.ListView1.Location = New System.Drawing.Point(20, 70)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(718, 359)
        Me.ListView1.TabIndex = 4
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'Documento
        '
        Me.Documento.Text = "Documento"
        Me.Documento.Width = 124
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre completo"
        Me.Nombre.Width = 121
        '
        'Direccion
        '
        Me.Direccion.Text = "Direccion"
        Me.Direccion.Width = 193
        '
        'Contacto
        '
        Me.Contacto.Text = "Contacto"
        Me.Contacto.Width = 162
        '
        'RaspberryPi
        '
        Me.RaspberryPi.Text = "Raspberry Pi ID"
        Me.RaspberryPi.Width = 97
        '
        'btnModifyClient
        '
        Me.btnModifyClient.Image = CType(resources.GetObject("btnModifyClient.Image"), System.Drawing.Image)
        Me.btnModifyClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnModifyClient.Location = New System.Drawing.Point(614, 17)
        Me.btnModifyClient.Name = "btnModifyClient"
        Me.btnModifyClient.Size = New System.Drawing.Size(94, 34)
        Me.btnModifyClient.TabIndex = 7
        Me.btnModifyClient.Text = "     Modify client"
        Me.btnModifyClient.UseVisualStyleBackColor = True
        '
        'btnDeleteClient
        '
        Me.btnDeleteClient.Image = CType(resources.GetObject("btnDeleteClient.Image"), System.Drawing.Image)
        Me.btnDeleteClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeleteClient.Location = New System.Drawing.Point(516, 17)
        Me.btnDeleteClient.Name = "btnDeleteClient"
        Me.btnDeleteClient.Size = New System.Drawing.Size(92, 34)
        Me.btnDeleteClient.TabIndex = 6
        Me.btnDeleteClient.Text = "     Delete client"
        Me.btnDeleteClient.UseVisualStyleBackColor = True
        '
        'btnAddClient
        '
        Me.btnAddClient.Image = CType(resources.GetObject("btnAddClient.Image"), System.Drawing.Image)
        Me.btnAddClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAddClient.Location = New System.Drawing.Point(425, 17)
        Me.btnAddClient.Name = "btnAddClient"
        Me.btnAddClient.Size = New System.Drawing.Size(85, 34)
        Me.btnAddClient.TabIndex = 5
        Me.btnAddClient.Text = "     Add client"
        Me.btnAddClient.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(176, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(155, 42)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "CLIENTS"
        '
        'frmClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(759, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btnModifyClient)
        Me.Controls.Add(Me.btnDeleteClient)
        Me.Controls.Add(Me.btnAddClient)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmClientes"
        Me.Text = "frmClientes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Documento As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Direccion As ColumnHeader
    Friend WithEvents Contacto As ColumnHeader
    Friend WithEvents RaspberryPi As ColumnHeader
    Friend WithEvents btnModifyClient As Button
    Friend WithEvents btnDeleteClient As Button
    Friend WithEvents btnAddClient As Button
    Friend WithEvents Label5 As Label
End Class
