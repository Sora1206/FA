Imports MySql.Data.MySqlClient
Imports System.Windows.Forms

Public Class Form1

    Private Const CONNECTION_STRING As String = "Server=localhost;Database=dbphon;Uid=root;Pwd=;"

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim partialName As String = txtPartialName.Text.Trim()

        txtContactName.Clear()
        txtContactNumber.Clear()

        If String.IsNullOrWhiteSpace(partialName) Then
            MessageBox.Show("Enter a partial name.", "Missing Input")
            Exit Sub
        End If

        Dim query As String = "SELECT contactName, contactNumber FROM tblPhoneNo WHERE contactName LIKE @SearchParam"

        Using connection As New MySqlConnection(CONNECTION_STRING)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@SearchParam", "%" & partialName & "%")

                Try
                    connection.Open()
                    Dim reader As MySqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        txtContactName.Text = reader("contactName").ToString()
                        txtContactNumber.Text = reader("contactNumber").ToString()
                    Else
                        txtContactName.Text = "N/A"
                        txtContactNumber.Text = "N/A"
                        MessageBox.Show("No contact found.", "Search Result")
                    End If

                    reader.Close()
                Catch ex As Exception
                    MessageBox.Show($"Database Error: {ex.Message}", "Error")
                End Try
            End Using
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtContactName.Text = ""
        txtContactNumber.Text = ""
    End Sub
End Class