Public Class frmOpciones
    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        'closeForms(form)
        'Adapta el form children con el padre
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnUsers_Click(sender As Object, e As EventArgs) Handles btnUsers.Click
        openForm(frmUsuarios)
    End Sub

    Private Sub btnClients_Click(sender As Object, e As EventArgs) Handles btnClients.Click
        openForm(frmClientes)
    End Sub

    Private Sub btnSubscriptions_Click(sender As Object, e As EventArgs) Handles btnSubscriptions.Click
        openForm(frmContratos)
    End Sub

    Private Sub btnServices_Click(sender As Object, e As EventArgs) Handles btnServices.Click
        openForm(frmServicios)
    End Sub

    Private Sub btnEquipos_Click(sender As Object, e As EventArgs) Handles btnEquipos.Click
        openForm(frmEquipos)
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        openForm(frmLogin)
    End Sub
End Class