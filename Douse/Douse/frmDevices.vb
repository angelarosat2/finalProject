Public Class frmDevices

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnAddDevice_Click(sender As Object, e As EventArgs) Handles btnAddDevice.Click
        Me.Close()
        openForm(frmAddDevice)
    End Sub

    Private Sub btnModifyDevice_Click(sender As Object, e As EventArgs) Handles btnModifyDevice.Click
        Me.Close()
        openForm(frmModifyDevice)
    End Sub
End Class