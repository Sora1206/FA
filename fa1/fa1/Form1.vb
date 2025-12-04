Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbCategory.SelectedIndex = -1
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim fullName As String = txtFullName.Text
        Dim address As String = txtAddress.Text
        Dim email As String = txtEmail.Text
        Dim age As Integer = CInt(nudAge.Value)
        Dim category As String = cmbCategory.Text


        Dim gender As String = If(rdoMale.Checked, "Male", If(rdoFemale.Checked, "Female", "Not specified"))


        If String.IsNullOrWhiteSpace(fullName) OrElse String.IsNullOrWhiteSpace(address) OrElse String.IsNullOrWhiteSpace(email) OrElse String.IsNullOrWhiteSpace(category) Then
            MessageBox.Show("Please fill in all required fields (Full name, Address, E-mail, Category).", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If


        Dim summary As String = $"Registration Details:{Environment.NewLine}{Environment.NewLine}" &
                                $"Full Name: {fullName}{Environment.NewLine}" &
                                $"Address: {address}{Environment.NewLine}" &
                                $"E-mail: {email}{Environment.NewLine}" &
                                $"Age: {age} years{Environment.NewLine}" &
                                $"Gender: {gender}{Environment.NewLine}" &
                                $"Category: {category}"

        MessageBox.Show(summary, "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Clear text boxes
        txtFullName.Clear()
        txtAddress.Clear()
        txtEmail.Clear()


        nudAge.Value = 0
        cmbCategory.SelectedIndex = -1
        rdoMale.Checked = True

        MessageBox.Show("Form fields have been reset.", "Form Reset", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

End Class