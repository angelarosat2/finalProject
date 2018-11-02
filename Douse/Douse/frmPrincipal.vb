Public Class frmPrincipal

    Private Sub openForm(form As Form)
        form.MdiParent = Me
        'closeForms(form)
        'Adapta el form children con el padre
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openForm(frmLogin)
    End Sub

    Private Sub btnUsuario_Click(sender As Object, e As EventArgs) Handles btnUsuario.Click
        openForm(frmUsuarios)
    End Sub

    Private Sub btnAgregarUsuario_Click(sender As Object, e As EventArgs) Handles btnAgregarUsuario.Click
        openForm(frmAddUser)
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        openForm(frmOpciones)
    End Sub

    Private Sub btnContratos_Click(sender As Object, e As EventArgs) Handles btnContratos.Click
        openForm(frmContracts)
    End Sub

    Private Sub btnAgregarContrato_Click(sender As Object, e As EventArgs) Handles btnAgregarContrato.Click
        openForm(frmAddContract)
    End Sub

    Private Sub btnAgregarEquipo_Click(sender As Object, e As EventArgs) Handles btnAgregarEquipo.Click
        openForm(frmAddDevice)
    End Sub

    Private Sub btnCliente_Click(sender As Object, e As EventArgs) Handles btnCliente.Click
        openForm(frmClients)
    End Sub

    Private Sub btnAgregarCliente_Click(sender As Object, e As EventArgs) Handles btnAgregarCliente.Click
        openForm(frmAddClient)
    End Sub
End Class