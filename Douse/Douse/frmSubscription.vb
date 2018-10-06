Imports System.Data.SqlClient

Public Class frmSubscription
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
End Class