Imports System.Net.Http
Imports System.Text
Imports System.Windows.Forms
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Private stopwatch As Stopwatch
    Private isStopwatchRunning As Boolean = False

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Initialize the stopwatch
        stopwatch = New Stopwatch()

        ' Enable KeyPreview to capture key events at the form level.
        Me.KeyPreview = True

        ' Attach the KeyDown event handler for form-level shortcuts.
        AddHandler Me.KeyDown, AddressOf CreateSubmissionForm_KeyDown
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        ToggleStopwatch()
    End Sub

    Private Sub ToggleStopwatch()
        If isStopwatchRunning Then
            stopwatch.Stop()
        Else
            stopwatch.Start()
        End If
        isStopwatchRunning = Not isStopwatchRunning
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        lblStopwatch.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim name As String = txtName.Text
        Dim email As String = txtEmail.Text
        Dim phoneNum As String = txtPhone.Text
        Dim githubLink As String = txtGitHub.Text
        Dim stopwatchTime As String = lblStopwatch.Text

        ' Validate required fields
        If String.IsNullOrEmpty(name) OrElse String.IsNullOrEmpty(email) OrElse String.IsNullOrEmpty(phoneNum) OrElse String.IsNullOrEmpty(githubLink) Then
            MessageBox.Show("Please fill all fields before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Prepare data for submission
        Dim submissionData As New Dictionary(Of String, String) From {
            {"name", name},
            {"email", email},
            {"phone", phoneNum},
            {"github_link", githubLink},
            {"stopwatch_time", stopwatchTime}
        }

        ' Convert data to JSON
        Dim json As String = JsonConvert.SerializeObject(submissionData)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        ' Send data to backend
        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
                response.EnsureSuccessStatusCode()
                MessageBox.Show("Submission successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error submitting data: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub btnSubmit_KeyDown(sender As Object, e As KeyEventArgs) Handles btnSubmit.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            ' Handle Ctrl + S shortcut (e.g., save functionality)
            btnSubmit.PerformClick()
            e.SuppressKeyPress = True ' Prevents further processing of this key event
        End If
        ' Add more shortcuts as needed
    End Sub

    Private Sub btnToggleStopwatch_KeyDown(sender As Object, e As KeyEventArgs) Handles btnToggleStopwatch.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            ' Handle Ctrl + T shortcut (e.g., toggle stopwatch functionality)
            ToggleStopwatch()
            e.SuppressKeyPress = True ' Prevents further processing of this key event
        End If
        ' Add more shortcuts as needed
    End Sub

End Class






