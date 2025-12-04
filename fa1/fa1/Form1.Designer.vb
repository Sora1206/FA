' Form1.Designer.vb

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtFullName = New TextBox()
        txtAddress = New TextBox()
        txtEmail = New TextBox()
        nudAge = New NumericUpDown()
        cmbCategory = New ComboBox()
        btnSave = New Button()
        btnCancel = New Button()
        btnReset = New Button()
        PanelGender = New Panel()
        rdoFemale = New RadioButton()
        rdoMale = New RadioButton()
        lblGender = New Label()
        lblYears = New Label()
        CType(nudAge, ComponentModel.ISupportInitialize).BeginInit()
        PanelGender.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 18)
        Label1.Name = "Label1"
        Label1.Size = New Size(311, 21)
        Label1.TabIndex = 0
        Label1.Text = "Registration of Charity Run Participants"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(16, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 1
        Label2.Text = "Full name"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(16, 114)
        Label3.Name = "Label3"
        Label3.Size = New Size(49, 15)
        Label3.TabIndex = 2
        Label3.Text = "Address"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(16, 209)
        Label4.Name = "Label4"
        Label4.Size = New Size(41, 15)
        Label4.TabIndex = 3
        Label4.Text = "E-mail"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(16, 255)
        Label5.Name = "Label5"
        Label5.Size = New Size(28, 15)
        Label5.TabIndex = 4
        Label5.Text = "Age"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(16, 301)
        Label6.Name = "Label6"
        Label6.Size = New Size(55, 15)
        Label6.TabIndex = 5
        Label6.Text = "Category"
        ' 
        ' txtFullName
        ' 
        txtFullName.Location = New Point(117, 65)
        txtFullName.Name = "txtFullName"
        txtFullName.Size = New Size(400, 23)
        txtFullName.TabIndex = 6
        ' 
        ' txtAddress
        ' 
        txtAddress.Location = New Point(117, 111)
        txtAddress.Multiline = True
        txtAddress.Name = "txtAddress"
        txtAddress.Size = New Size(400, 75)
        txtAddress.TabIndex = 7
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(117, 206)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(400, 23)
        txtEmail.TabIndex = 8
        ' 
        ' nudAge
        ' 
        nudAge.Location = New Point(117, 253)
        nudAge.Name = "nudAge"
        nudAge.Size = New Size(50, 23)
        nudAge.TabIndex = 9
        ' 
        ' cmbCategory
        ' 
        cmbCategory.FormattingEnabled = True
        cmbCategory.Items.AddRange(New Object() {"5 km", "10 km", "Half Marathon"})
        cmbCategory.Location = New Point(117, 298)
        cmbCategory.Name = "cmbCategory"
        cmbCategory.Size = New Size(180, 23)
        cmbCategory.TabIndex = 10
        ' 
        ' btnSave
        ' 
        btnSave.Location = New Point(117, 360)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(100, 35)
        btnSave.TabIndex = 11
        btnSave.Text = "SAVE"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(237, 360)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(100, 35)
        btnCancel.TabIndex = 12
        btnCancel.Text = "CANCEL"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(357, 360)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(100, 35)
        btnReset.TabIndex = 13
        btnReset.Text = "RESET"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' PanelGender
        ' 
        PanelGender.Controls.Add(rdoFemale)
        PanelGender.Controls.Add(rdoMale)
        PanelGender.Location = New Point(357, 250)
        PanelGender.Name = "PanelGender"
        PanelGender.Size = New Size(180, 30)
        PanelGender.TabIndex = 14
        ' 
        ' rdoFemale
        ' 
        rdoFemale.AutoSize = True
        rdoFemale.Location = New Point(90, 3)
        rdoFemale.Name = "rdoFemale"
        rdoFemale.Size = New Size(63, 19)
        rdoFemale.TabIndex = 1
        rdoFemale.TabStop = True
        rdoFemale.Text = "Female"
        rdoFemale.UseVisualStyleBackColor = True
        ' 
        ' rdoMale
        ' 
        rdoMale.AutoSize = True
        rdoMale.Checked = True
        rdoMale.Location = New Point(3, 3)
        rdoMale.Name = "rdoMale"
        rdoMale.Size = New Size(51, 19)
        rdoMale.TabIndex = 0
        rdoMale.TabStop = True
        rdoMale.Text = "Male"
        rdoMale.UseVisualStyleBackColor = True
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(290, 255)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(45, 15)
        lblGender.TabIndex = 15
        lblGender.Text = "Gender"
        ' 
        ' lblYears
        ' 
        lblYears.AutoSize = True
        lblYears.Location = New Point(173, 255)
        lblYears.Name = "lblYears"
        lblYears.Size = New Size(34, 15)
        lblYears.TabIndex = 16
        lblYears.Text = "years"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(540, 420)
        Controls.Add(lblGender)
        Controls.Add(lblYears)
        Controls.Add(PanelGender)
        Controls.Add(btnReset)
        Controls.Add(btnCancel)
        Controls.Add(btnSave)
        Controls.Add(cmbCategory)
        Controls.Add(nudAge)
        Controls.Add(txtEmail)
        Controls.Add(txtAddress)
        Controls.Add(txtFullName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Name = "Form1"
        Text = "Registration Form"
        CType(nudAge, ComponentModel.ISupportInitialize).EndInit()
        PanelGender.ResumeLayout(False)
        PanelGender.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents Label1 As System.Windows.Forms.Label ' Title
    Friend WithEvents Label2 As System.Windows.Forms.Label ' Full name
    Friend WithEvents Label3 As System.Windows.Forms.Label ' Address
    Friend WithEvents Label4 As System.Windows.Forms.Label ' E-mail
    Friend WithEvents Label5 As System.Windows.Forms.Label ' Age
    Friend WithEvents Label6 As System.Windows.Forms.Label ' Category

    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox ' Multiline
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents nudAge As System.Windows.Forms.NumericUpDown
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox

    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnReset As System.Windows.Forms.Button

    Friend WithEvents PanelGender As System.Windows.Forms.Panel ' Grouping for RadioButtons
    Friend WithEvents rdoFemale As System.Windows.Forms.RadioButton
    Friend WithEvents rdoMale As System.Windows.Forms.RadioButton
    Friend WithEvents lblGender As System.Windows.Forms.Label ' "Gender" text
    Friend WithEvents lblYears As System.Windows.Forms.Label ' "years" text

End Class