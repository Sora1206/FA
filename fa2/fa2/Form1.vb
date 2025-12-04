Imports System.Windows.Forms

Public Class Form1

    Private Const MIN_LENGTH_REQUIRED As Integer = 8 ' 6 for Username, 4+4 for Password

    ' Event handler for the Save button (Question 2c)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim fullNameInput As String = txtFullName.Text.Trim()

        ' Initial check for empty input
        If String.IsNullOrEmpty(fullNameInput) Then
            lblResult.Text = "Error: Full name cannot be empty."
            Exit Sub
        End If

        ' Use Try...Catch to handle the case where the name is too short (Q2d)
        Try
            Dim upperCaseName As String = fullNameInput.ToUpper()

            ' Ensure sufficient length for 6-char username and 4+4 char password
            If upperCaseName.Length < MIN_LENGTH_REQUIRED Then
                Throw New ArgumentOutOfRangeException("Name is too short.")
            End If

            ' Q2c Requirements:
            Dim username As String = upperCaseName.Substring(0, 6) ' First 6 letters

            ' First 4 letters + Last 4 letters
            Dim password As String = upperCaseName.Substring(0, 4) & upperCaseName.Substring(upperCaseName.Length - 4, 4)

            ' Format the output (Figure 2c)
            lblResult.Text = $"RESULT{Environment.NewLine}" &
                             $"Full name: {upperCaseName}{Environment.NewLine}" &
                             $"Username: {username}{Environment.NewLine}" &
                             $"Password: {password}"

        Catch ex As ArgumentOutOfRangeException
            ' Q2d Exception Handler: Display the required popup and update result label.
            MessageBox.Show("Sorry, registration failed. The full name is too short.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblResult.Text = $"Error: Name is too short (Requires at least {MIN_LENGTH_REQUIRED} characters)."
        Catch ex As Exception
            ' General error handler
            MessageBox.Show($"An unexpected error occurred: {ex.Message}", "System Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            lblResult.Text = "An unexpected system error occurred."
        End Try

    End Sub
End Class