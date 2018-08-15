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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmControlPanel))
        Me.btnCocina = New System.Windows.Forms.Button()
        Me.btnDormitorio = New System.Windows.Forms.Button()
        Me.btnBaño = New System.Windows.Forms.Button()
        Me.btnLiving = New System.Windows.Forms.Button()
        Me.btnComedor = New System.Windows.Forms.Button()
        Me.btnPasillo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCocina
        '
        Me.btnCocina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCocina.Image = CType(resources.GetObject("btnCocina.Image"), System.Drawing.Image)
        Me.btnCocina.Location = New System.Drawing.Point(58, 63)
        Me.btnCocina.Name = "btnCocina"
        Me.btnCocina.Size = New System.Drawing.Size(146, 125)
        Me.btnCocina.TabIndex = 0
        Me.btnCocina.Text = "Cocina"
        Me.btnCocina.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCocina.UseVisualStyleBackColor = True
        '
        'btnDormitorio
        '
        Me.btnDormitorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDormitorio.Image = CType(resources.GetObject("btnDormitorio.Image"), System.Drawing.Image)
        Me.btnDormitorio.Location = New System.Drawing.Point(255, 63)
        Me.btnDormitorio.Name = "btnDormitorio"
        Me.btnDormitorio.Size = New System.Drawing.Size(146, 125)
        Me.btnDormitorio.TabIndex = 1
        Me.btnDormitorio.Text = "Dormitorio"
        Me.btnDormitorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDormitorio.UseVisualStyleBackColor = True
        '
        'btnBaño
        '
        Me.btnBaño.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBaño.Image = CType(resources.GetObject("btnBaño.Image"), System.Drawing.Image)
        Me.btnBaño.Location = New System.Drawing.Point(449, 63)
        Me.btnBaño.Name = "btnBaño"
        Me.btnBaño.Size = New System.Drawing.Size(146, 125)
        Me.btnBaño.TabIndex = 2
        Me.btnBaño.Text = "Baño"
        Me.btnBaño.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnBaño.UseVisualStyleBackColor = True
        '
        'btnLiving
        '
        Me.btnLiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLiving.Image = CType(resources.GetObject("btnLiving.Image"), System.Drawing.Image)
        Me.btnLiving.Location = New System.Drawing.Point(58, 224)
        Me.btnLiving.Name = "btnLiving"
        Me.btnLiving.Size = New System.Drawing.Size(146, 125)
        Me.btnLiving.TabIndex = 3
        Me.btnLiving.Text = "Living"
        Me.btnLiving.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLiving.UseVisualStyleBackColor = True
        '
        'btnComedor
        '
        Me.btnComedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComedor.Image = CType(resources.GetObject("btnComedor.Image"), System.Drawing.Image)
        Me.btnComedor.Location = New System.Drawing.Point(255, 224)
        Me.btnComedor.Name = "btnComedor"
        Me.btnComedor.Size = New System.Drawing.Size(146, 125)
        Me.btnComedor.TabIndex = 4
        Me.btnComedor.Text = "Comedor"
        Me.btnComedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnComedor.UseVisualStyleBackColor = True
        '
        'btnPasillo
        '
        Me.btnPasillo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPasillo.Image = CType(resources.GetObject("btnPasillo.Image"), System.Drawing.Image)
        Me.btnPasillo.Location = New System.Drawing.Point(449, 224)
        Me.btnPasillo.Name = "btnPasillo"
        Me.btnPasillo.Size = New System.Drawing.Size(146, 125)
        Me.btnPasillo.TabIndex = 5
        Me.btnPasillo.Text = "Pasillo"
        Me.btnPasillo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnPasillo.UseVisualStyleBackColor = True
        '
        'frmControlPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(653, 391)
        Me.Controls.Add(Me.btnPasillo)
        Me.Controls.Add(Me.btnComedor)
        Me.Controls.Add(Me.btnLiving)
        Me.Controls.Add(Me.btnBaño)
        Me.Controls.Add(Me.btnDormitorio)
        Me.Controls.Add(Me.btnCocina)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmControlPanel"
        Me.Text = "frmControlPanel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCocina As Button
    Friend WithEvents btnDormitorio As Button
    Friend WithEvents btnBaño As Button
    Friend WithEvents btnLiving As Button
    Friend WithEvents btnComedor As Button
    Friend WithEvents btnPasillo As Button
End Class
