Imports System.Data.SqlClient
Public Class frmClients

    Private Sub frmClients_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oClient As New Client()

        Dim resultado As SqlDataReader = oClient.obtenerListado()

        If resultado.HasRows Then
            While resultado.Read
                Dim document As ListViewItem = lvwClients.Items.Add(resultado("document").ToString)
                document.SubItems.Add(resultado("name").ToString)
                document.SubItems.Add(resultado("address").ToString)
                document.SubItems.Add(resultado("email").ToString)
            End While
        End If
    End Sub

    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        openForm(frmOpciones)
        Me.Close()
    End Sub

    Private Sub btnAddClient_Click(sender As Object, e As EventArgs) Handles btnAddClient.Click
        openForm(frmAddClient)
        Me.Close()
    End Sub

    Private Sub btnModifyClient_Click(sender As Object, e As EventArgs) Handles btnModifyClient.Click
        openForm(frmModifyClient)
        Me.Close()
    End Sub

    Private Sub btnDeleteClient_Click(sender As Object, e As EventArgs) Handles btnDeleteClient.Click
        MsgBox("Esta seguro que desea eliminar este cliente?", MsgBoxStyle.Exclamation, "Atention")
    End Sub

    Private Sub lvwClients_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwClients.SelectedIndexChanged

    End Sub
End Class