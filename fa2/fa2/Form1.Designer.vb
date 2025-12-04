<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Label1 = New Label()
        txtFullName = New TextBox()
        btnSave = New Button()
        lblOutputTitle = New Label()
        lblResult = New Label()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(10, 14)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(172, 25)
        lblTitle.TabIndex = 0
        lblTitle.Text = "Registration Form"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(14, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(59, 15)
        Label1.TabIndex = 1
        Label1.Text = "Full name"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(88, 54)
        txtFullName.Margin = New Padding(3, 2, 3, 2)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(307, 23)
        txtFullName.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.BackColor = Color.FromArgb(CByte(64), CByte(64), CByte(64))
        btnSave.FlatStyle = FlatStyle.Flat
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(298, 90)
        btnSave.Margin = New Padding(3, 2, 3, 2)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(96, 26)
        btnSave.TabIndex = 3
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = False
        ' 
        ' lblOutputTitle
        ' 
        lblOutputTitle.AutoSize = True
        lblOutputTitle.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblOutputTitle.Location = New Point(14, 131)
        lblOutputTitle.Name = "lblOutputTitle"
        lblOutputTitle.Size = New Size(57, 19)
        lblOutputTitle.TabIndex = 4
        lblOutputTitle.Text = "RESULT"
        ' 
        ' lblResult
        ' 
        lblResult.BackColor = SystemColors.ControlLight
        lblResult.BorderStyle = BorderStyle.FixedSingle
        lblResult.Location = New Point(18, 158)
        lblResult.Name = "lblResult"
        lblResult.Padding = New Padding(4, 4, 4, 4)
        lblResult.Size = New Size(376, 90)
        lblResult.TabIndex = 5
        lblResult.Text = "Please fill in the full name and click the Save button"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(411, 262)
        Controls.Add(lblResult)
        Controls.Add(lblOutputTitle)
        Controls.Add(btnSave)
        Controls.Add(txtFullName)
        Controls.Add(Label1)
        Controls.Add(lblTitle)
        Font = New Font("Segoe UI", 9.0F)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Form1"
        Text = "Registration Form"
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblOutputTitle As System.Windows.Forms.Label
    Friend WithEvents lblResult As System.Windows.Forms.Label

End Class