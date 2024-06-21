Imports Newtonsoft.Json
Imports System.Net.Http

Public Class ViewSubmissionsForm
    Dim currentIndex As Integer = 0
    Dim submissions As List(Of Submission) = New List(Of Submission) ' Placeholder for submission data

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load the initial submission
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Dim response = Await client.GetAsync($"http://localhost:3000/read?index={index}")
            If response.IsSuccessStatusCode Then
                Dim json = Await response.Content.ReadAsStringAsync()
                Dim submission = JsonConvert.DeserializeObject(Of Submission)(json)
                DisplaySubmission(submission)
            Else
                MessageBox.Show("Failed to load submission.")
            End If
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        If submission IsNot Nothing Then
            TextBox1.Text = submission.Name
            TextBox2.Text = submission.Email
            TextBox3.Text = submission.Phone
            TextBox4.Text = submission.GithubRepo
            TextBox5.Text = submission.StopwatchTime
        Else
            MessageBox.Show("Submission is null.")
        End If
    End Sub

    Private Async Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub

    Private Async Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Assuming you have a method to get the total count of submissions
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property GithubRepo As String
    Public Property StopwatchTime As String
End Class
