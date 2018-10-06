Imports System.Data.SqlClient

Public Class frmAddClient

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ' Los chequeos que los haga mickey
        Dim oClient As New Client(txtDocument.Text, txtName.Text, txtAddress.Text, txtEmail.Text)

        If oClient.Insertar() = 1 Then
            MsgBox("El cliente se ha guardado correctamente", MsgBoxStyle.Information, "Success!")
        End If

        Me.Close()
        openForm(frmClients)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        openForm(frmClients)
        Me.Close()
    End Sub
End Class