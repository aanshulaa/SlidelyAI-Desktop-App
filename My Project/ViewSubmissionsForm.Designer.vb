<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewSubmissionsForm
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
        lblPhoneNumber = New Label()
        lblGitHubRepo = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhoneNum = New TextBox()
        txtGithubLink = New TextBox()
        lblStopwatch = New Label()
        txtStopwatchTime = New TextBox()
        btnNext = New Button()
        btnPrevious = New Button()
        Label1 = New Label()
        btnDelete = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(209, 97)
        lblName.Name = "lblName"
        lblName.Size = New Size(59, 25)
        lblName.TabIndex = 0
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(209, 154)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(54, 25)
        lblEmail.TabIndex = 1
        lblEmail.Text = "Email"
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Location = New Point(209, 207)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(132, 25)
        lblPhoneNumber.TabIndex = 2
        lblPhoneNumber.Text = "Phone Number"
        ' 
        ' lblGitHubRepo
        ' 
        lblGitHubRepo.AutoSize = True
        lblGitHubRepo.Location = New Point(209, 262)
        lblGitHubRepo.Name = "lblGitHubRepo"
        lblGitHubRepo.Size = New Size(104, 25)
        lblGitHubRepo.TabIndex = 3
        lblGitHubRepo.Text = "GitHub Link"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(370, 91)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(175, 31)
        txtName.TabIndex = 4
        txtName.Text = "John Doe"
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(370, 151)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.Size = New Size(175, 31)
        txtEmail.TabIndex = 5
        txtEmail.Text = "johndoe@gmail.com"
        ' 
        ' txtPhoneNum
        ' 
        txtPhoneNum.Location = New Point(370, 207)
        txtPhoneNum.Name = "txtPhoneNum"
        txtPhoneNum.ReadOnly = True
        txtPhoneNum.Size = New Size(175, 31)
        txtPhoneNum.TabIndex = 6
        txtPhoneNum.Text = "9876543210"
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Location = New Point(370, 262)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.ReadOnly = True
        txtGithubLink.Size = New Size(175, 31)
        txtGithubLink.TabIndex = 7
        txtGithubLink.Text = "https://github.com/john_doe/my_slidely_task/"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Location = New Point(209, 313)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(138, 25)
        lblStopwatch.TabIndex = 8
        lblStopwatch.Text = "Stopwatch Time"
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(370, 313)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(175, 31)
        txtStopwatchTime.TabIndex = 9
        txtStopwatchTime.Text = "00:01:19"
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnNext.Location = New Point(625, 356)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(163, 34)
        btnNext.TabIndex = 10
        btnNext.Text = "NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnPrevious.Location = New Point(36, 356)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(209, 34)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(200, 34)
        Label1.Name = "Label1"
        Label1.Size = New Size(359, 25)
        Label1.TabIndex = 12
        Label1.Text = "John Doe, Slidely Task 2 - View Submissions"
        ' 
        ' btnDelete
        ' 
        btnDelete.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btnDelete.Location = New Point(133, 404)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(112, 34)
        btnDelete.TabIndex = 13
        btnDelete.Text = "Delete"
        btnDelete.UseVisualStyleBackColor = False
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnDelete)
        Controls.Add(Label1)
        Controls.Add(btnPrevious)
        Controls.Add(btnNext)
        Controls.Add(txtStopwatchTime)
        Controls.Add(lblStopwatch)
        Controls.Add(txtGithubLink)
        Controls.Add(txtPhoneNum)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGitHubRepo)
        Controls.Add(lblPhoneNumber)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        KeyPreview = True
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblGitHubRepo As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhoneNum As TextBox
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
End Class
