Imports System.Data.SqlClient

Public Class frmSubscription
    Private Sub openForm(form As Form)
        form.MdiParent = frmPrincipal
        form.Dock = DockStyle.Fill
        form.Show()
    End Sub
    Private Sub frmSubscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oSubscription As New Subscription()

        Dim resultado As SqlDataReader = oSubscription.ObtenerListado()

        If resultado.HasRows Then
            While resultado.Read
                Dim document As ListViewItem = lvwSubscription.Items.Add(resultado("number").ToString)
                document.SubItems.Add(resultado("description").ToString)
                document.SubItems.Add(resultado("price").ToString)
            End While
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        openForm(frmOpciones)
        Me.Close()
    End Sub
End Class