Imports System.Text
Public Class Form1


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Dim postcode As String = String.Empty
        Dim stringSearch As New StringBuilder
        Try
            stringSearch.Append("http://www.google.co.uk/maps?h1=en&tab=w1")
            If txtSearch.Text <> String.Empty Then
                postcode = txtSearch.Text.Replace(" ", "+")
                stringSearch.Append(postcode + "," & "+")

            End If

            WebBrowser1.Navigate(stringSearch.ToString)
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try





    End Sub
End Class
