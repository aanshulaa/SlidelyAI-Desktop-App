Imports System.Net.Http
Imports System.Threading.Tasks

Public Class ViewSubmissionsForm
    Private currentIndex As Integer = 0

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Enable KeyPreview to capture key events at the form level.
        Me.KeyPreview = True

        ' Attach the KeyDown event handler for global shortcuts
        AddHandler Me.KeyDown, AddressOf ViewSubmissionsForm_KeyDown

        ' Load the first submission
        LoadSubmission(currentIndex)
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs)
        ' Handle global keyboard shortcuts for the form
        If e.Control AndAlso e.KeyCode = Keys.Left Then
            ' Ctrl + LeftArrow: Previous
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.Right Then
            ' Ctrl + RightArrow: Next
            btnNext.PerformClick()
        End If
    End Sub

    Private Async Sub LoadSubmission(index As Integer)
        Dim client As New HttpClient()
        Try
            Dim response As HttpResponseMessage = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim submission As String = Await response.Content.ReadAsStringAsync()
                Dim submissionData As Dictionary(Of String, String) = Newtonsoft.Json.JsonConvert.DeserializeObject(Of Dictionary(Of String, String))(submission)
                UpdateUI(submissionData)
            Else
                MessageBox.Show("No more submissions.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Adjust currentIndex if necessary to prevent going out of bounds
                If index > 0 Then
                    currentIndex -= 1
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Error loading submission: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub UpdateUI(submissionData As Dictionary(Of String, String))
        ' Update UI elements with submission data
        txtName.Text = submissionData("name")
        txtEmail.Text = submissionData("email")
        txtPhoneNum.Text = submissionData("phone")
        txtGithubLink.Text = submissionData("github_link")
        lblStopwatch.Text = submissionData("stopwatch_time")
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            LoadSubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        currentIndex += 1
        LoadSubmission(currentIndex)
    End Sub

    Private Sub btnPrevious_KeyDown(sender As Object, e As KeyEventArgs) Handles btnPrevious.KeyDown
        ' Handle keyboard shortcut specific to btnPrevious
        If e.Control AndAlso e.KeyCode = Keys.Enter Then
            ' Ctrl + Enter: PerformClick will trigger btnPrevious_Click
            btnPrevious.PerformClick()
        End If
    End Sub

    Private Sub btnNext_KeyDown(sender As Object, e As KeyEventArgs) Handles btnNext.KeyDown
        ' Handle keyboard shortcut specific to btnNext
        If e.Control AndAlso e.KeyCode = Keys.Enter Then
            ' Ctrl + Enter: PerformClick will trigger btnNext_Click
            btnNext.PerformClick()
        End If
    End Sub

    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim submissionId As Integer = ' Retrieve the ID of the current submission to delete

        Using client As New HttpClient()
            Try
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/submissions/{submissionId}")
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Optionally refresh the submissions list or move to the next/previous submission
                Else
                    MessageBox.Show($"Failed to delete submission. Server returned: {response.ReasonPhrase}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show($"Error deleting submission: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub


End Class
