<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblName = New Label()
        lblEmail = New Label()
        lblPhoneNum = New Label()
        lblGitHubLink = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGitHubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        lblStopwatch = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(225, 82)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(225, 135)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNum
        ' 
        lblPhoneNum.AutoSize = True
        lblPhoneNum.Location = New Point(225, 186)
        lblPhoneNum.Name = "lblPhoneNum"
        lblPhoneNum.Size = New Size(132, 25)
        lblPhoneNum.TabIndex = 2
        lblPhoneNum.Text = "Phone Number"
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Location = New Point(225, 235)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(104, 25)
        lblGitHubLink.TabIndex = 3
        lblGitHubLink.Text = "GitHub Link"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(400, 76)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 4
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(400, 129)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(150, 31)
        txtEmail.TabIndex = 5
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(400, 180)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.Size = New Size(150, 31)
        txtPhoneNum.TabIndex = 6
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(400, 235)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(150, 31)
        txtGitHubLink.TabIndex = 7
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(400, 280)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(150, 31)
        txtStopwatchTime.TabIndex = 8
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(225, 280)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(138, 25)
        lblStopwatch.TabIndex = 9
        lblStopwatch.Text = "Stopwatch Time"
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnToggleStopwatch.Location = New Point(94, 336)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(316, 34)
        btnToggleStopwatch.TabIndex = 10
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnSubmit.Location = New Point(311, 394)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(182, 34)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(209, 27)
        Label6.Name = "Label6"
        Label6.Size = New Size(359, 25)
        Label6.TabIndex = 12
        Label6.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(lblStopwatch)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhoneNum)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        KeyPreview = True
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNum As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label6 As Label
End Class
