Public Class frmPrincipal
    'Private Sub closeForms(formDontClose As Form)
    '    'Cierra todos las ventanas abiertas expecto el actual
    '    My.Application.OpenForms.Cast(Of Form)() _
    '         .Except({Me}) _
    '         .Except({formDontClose}) _
    '         .ToList() _
    '         .ForEach(Sub(form) form.Close())
    'End Sub

    Private Sub openForm(form As Form)
        form.MdiParent = Me
        'closeForms(form)
        'Adapta el form children con el padre
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        openForm(frmUsuarios)
    End Sub

    Private Sub AgregarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuariosToolStripMenuItem.Click
        openForm(frmAddUser)
    End Sub

    Private Sub EliminarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarUsuariosToolStripMenuItem.Click
        openForm(frmUsuarios)
    End Sub

    Private Sub ModificarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificarUsuariosToolStripMenuItem.Click
        openForm(frmUsuarios)
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openForm(frmOpciones)
    End Sub
End Class