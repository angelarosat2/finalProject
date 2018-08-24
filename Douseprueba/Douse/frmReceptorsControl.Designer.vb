<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmControlPanel
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
        Dim ListViewItem9 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"1", "Enchufe bam", "Enchufe", "", "120"}, -1)
        Dim ListViewItem10 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.590.625-1", "Levi Brittos", "Canelones 1162", "095 109 991", "154"}, -1)
        Dim ListViewItem11 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.295.562-9", "Lucas Sanmartino", "Canelones 1162", "094 467 141", "168"}, -1)
        Dim ListViewItem12 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New String() {"5.101.056-5", "Angela Rosa", "Canelones 1162", "095 033 690", "195"}, -1)
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Tipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Estado = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Consumo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ConsumoCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESSTADOCOL = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Tipo, Me.Nombre, Me.Estado, Me.Consumo})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem9, ListViewItem10, ListViewItem11, ListViewItem12})
        Me.ListView1.Location = New System.Drawing.Point(-1, 84)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(711, 295)
        Me.ListView1.TabIndex = 5
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 124
        '
        'Tipo
        '
        Me.Tipo.Text = "Tipo"
        Me.Tipo.Width = 121
        '
        'Nombre
        '
        Me.Nombre.Text = "Nombre"
        Me.Nombre.Width = 193
        '
        'Estado
        '
        Me.Estado.Text = "Estado"
        Me.Estado.Width = 162
        '
        'Consumo
        '
        Me.Consumo.Text = "Consumo"
        Me.Consumo.Width = 97
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDCol, Me.TipoCol, Me.NombreCol, Me.EstadoCol, Me.ConsumoCol, Me.ESSTADOCOL})
        Me.DataGridView1.Location = New System.Drawing.Point(30, 210)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(656, 150)
        Me.DataGridView1.TabIndex = 6
        '
        'IDCol
        '
        Me.IDCol.HeaderText = "Id"
        Me.IDCol.Name = "IDCol"
        '
        'TipoCol
        '
        Me.TipoCol.HeaderText = "Tipo"
        Me.TipoCol.Name = "TipoCol"
        '
        'NombreCol
        '
        Me.NombreCol.HeaderText = "Nombre"
        Me.NombreCol.Name = "NombreCol"
        '
        'EstadoCol
        '
        Me.EstadoCol.HeaderText = "Estado"
        Me.EstadoCol.Name = "EstadoCol"
        '
        'ConsumoCol
        '
        Me.ConsumoCol.HeaderText = "Consumo"
        Me.ConsumoCol.Name = "ConsumoCol"
        '
        'ESSTADOCOL
        '
        Me.ESSTADOCOL.HeaderText = "ESTADO"
        Me.ESSTADOCOL.Name = "ESSTADOCOL"
        '
        'frmControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(722, 391)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmControlPanel"
        Me.Text = "frmControlPanel"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ID As ColumnHeader
    Friend WithEvents Tipo As ColumnHeader
    Friend WithEvents Nombre As ColumnHeader
    Friend WithEvents Estado As ColumnHeader
    Friend WithEvents Consumo As ColumnHeader
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDCol As DataGridViewTextBoxColumn
    Friend WithEvents TipoCol As DataGridViewTextBoxColumn
    Friend WithEvents NombreCol As DataGridViewTextBoxColumn
    Friend WithEvents EstadoCol As DataGridViewTextBoxColumn
    Friend WithEvents ConsumoCol As DataGridViewTextBoxColumn
    Friend WithEvents ESSTADOCOL As DataGridViewButtonColumn
End Class
