Public Class ViewSubmissionsForm
    Dim currentIndex As Integer = 0
    Dim submissions As List(Of Submission) = New List(Of Submission) ' Placeholder for submission data

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load submissions from the backend (to be implemented)
        If submissions.Count > 0 Then
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub DisplaySubmission(submission As Submission)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhone.Text = submission.Phone
        txtGithubRepo.Text = submission.GithubRepo
        txtStopwatchTime.Text = submission.StopwatchTime
    End Sub
End Class
