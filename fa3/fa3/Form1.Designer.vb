<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1 ' Renamed to Form1
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblTitle = New Label()
        lblPartialName = New Label()
        txtPartialName = New TextBox()
        btnSearch = New Button()
        GroupBox1 = New GroupBox()
        txtContactNumber = New TextBox()
        txtContactName = New TextBox()
        lblContactNumber = New Label()
        lblContactName = New Label()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(10, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(74, 15)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Phone Book"
        ' 
        ' lblPartialName
        ' 
        lblPartialName.AutoSize = True
        lblPartialName.Location = New Point(14, 49)
        lblPartialName.Name = "lblPartialName"
        lblPartialName.Size = New Size(73, 15)
        lblPartialName.TabIndex = 1
        lblPartialName.Text = "Partial name"
        ' 
        ' txtPartialName
        ' 
        txtPartialName.Location = New Point(102, 46)
        txtPartialName.Margin = New Padding(3, 2, 3, 2)
        txtPartialName.Name = "txtPartialName"
        txtPartialName.Size = New Size(132, 23)
        txtPartialName.TabIndex = 2
        ' 
        ' btnSearch
        ' 
        btnSearch.BackColor = SystemColors.Control
        btnSearch.FlatStyle = FlatStyle.System
        btnSearch.Location = New Point(245, 46)
        btnSearch.Margin = New Padding(3, 2, 3, 2)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(66, 20)
        btnSearch.TabIndex = 3
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(txtContactNumber)
        GroupBox1.Controls.Add(txtContactName)
        GroupBox1.Controls.Add(lblContactNumber)
        GroupBox1.Controls.Add(lblContactName)
        GroupBox1.Location = New Point(10, 79)
        GroupBox1.Margin = New Padding(3, 2, 3, 2)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 2, 3, 2)
        GroupBox1.Size = New Size(302, 94)
        GroupBox1.TabIndex = 4
        GroupBox1.TabStop = False
        GroupBox1.Text = "Contact information"
        ' 
        ' txtContactNumber
        ' 
        txtContactNumber.Location = New Point(116, 60)
        txtContactNumber.Margin = New Padding(3, 2, 3, 2)
        txtContactNumber.Name = "txtContactNumber"
        txtContactNumber.ReadOnly = True
        txtContactNumber.Size = New Size(167, 23)
        txtContactNumber.TabIndex = 8
        txtContactNumber.Text = "04-9886200"
        ' 
        ' txtContactName
        ' 
        txtContactName.Location = New Point(116, 30)
        txtContactName.Margin = New Padding(3, 2, 3, 2)
        txtContactName.Name = "txtContactName"
        txtContactName.ReadOnly = True
        txtContactName.Size = New Size(167, 23)
        txtContactName.TabIndex = 7
        txtContactName.Text = "Ahammad"
        ' 
        ' lblContactNumber
        ' 
        lblContactNumber.AutoSize = True
        lblContactNumber.Location = New Point(7, 62)
        lblContactNumber.Name = "lblContactNumber"
        lblContactNumber.Size = New Size(94, 15)
        lblContactNumber.TabIndex = 6
        lblContactNumber.Text = "Contact number"
        ' 
        ' lblContactName
        ' 
        lblContactName.AutoSize = True
        lblContactName.Location = New Point(7, 32)
        lblContactName.Name = "lblContactName"
        lblContactName.Size = New Size(82, 15)
        lblContactName.TabIndex = 5
        lblContactName.Text = "Contact name"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(324, 188)
        Controls.Add(GroupBox1)
        Controls.Add(btnSearch)
        Controls.Add(txtPartialName)
        Controls.Add(lblPartialName)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 9.0F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Phone Book"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents lblPartialName As System.Windows.Forms.Label
    Friend WithEvents txtPartialName As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents lblContactNumber As System.Windows.Forms.Label
    Friend WithEvents lblContactName As System.Windows.Forms.Label
End Class