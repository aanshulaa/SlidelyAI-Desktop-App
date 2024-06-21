Public Class Form1
    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewForm As New ViewSubmissionsForm()
        viewForm.Show()
    End Sub

    Private Sub btnCreateSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateSubmission.Click
        Dim createForm As New CreateSubmissionForm()
        createForm.Show()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle global keyboard shortcuts for the form
        If e.Control AndAlso e.KeyCode = Keys.V Then
            ' Ctrl + V: View Submissions
            MessageBox.Show("View Submissions shortcut (Ctrl + V) triggered!")
            ' Implement your action for View Submissions here
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            ' Ctrl + N: Create New Submission
            MessageBox.Show("Create New Submission shortcut (Ctrl + N) triggered!")
            ' Implement your action for Create New Submission here
        End If
    End Sub


    Private Sub btnViewSubmissions_KeyDown(sender As Object, e As KeyEventArgs) Handles btnViewSubmissions.KeyDown
        ' Handle keyboard shortcuts specific to btnViewSubmissions
        If e.Control AndAlso e.KeyCode = Keys.Enter Then
            ' Ctrl + Enter: Example action (View Submissions)
            MessageBox.Show("View Submissions shortcut (Ctrl + Enter) triggered!")
            ' Implement your action for View Submissions here
        End If
    End Sub

    Private Sub btnCreateSubmission_KeyDown(sender As Object, e As KeyEventArgs) Handles btnCreateSubmission.KeyDown
        ' Handle keyboard shortcuts specific to btnCreateSubmission
        If e.Control AndAlso e.KeyCode = Keys.Enter Then
            ' Ctrl + Enter: Example action (Create New Submission)
            MessageBox.Show("Create New Submission shortcut (Ctrl + Enter) triggered!")
            ' Implement your action for Create New Submission here
        End If
    End Sub

End Class
