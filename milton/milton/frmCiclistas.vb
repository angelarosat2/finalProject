Imports System.Data.SqlClient

Public Class frmCiclistas
    Private Sub frmCiclistas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oCiclista As New Ciclista()

        Dim resultado As SqlDataReader = oCiclista.obtenerListado()

        If resultado.HasRows Then
            While resultado.Read
                Dim lvItem As ListViewItem = ListView1.Items.Add(resultado("ci").ToString)
                lvItem.SubItems.Add(resultado("nombre").ToString)
            End While
        End If
    End Sub
End Class