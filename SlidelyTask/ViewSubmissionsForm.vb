Imports Newtonsoft.Json
Imports System.Net.Http

Public Class ViewSubmissionsForm
    Dim currentIndex As Integer = 0
    Dim totalSubmissions As Integer = 0

    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Get the total number of submissions initially
        Await GetTotalSubmissions()
        ' Load the initial submission
        Await LoadSubmission(currentIndex)
    End Sub

    Private Async Function GetTotalSubmissions() As Task
        Using client As New HttpClient()
            Try
                Dim response = Await client.GetAsync("http://localhost:3000/totalSubmissions")
                If response.IsSuccessStatusCode Then
                    Dim total = Await response.Content.ReadAsStringAsync()
                    totalSubmissions = Integer.Parse(total)
                Else
                    MessageBox.Show($"Failed to get total submissions. Status Code: {response.StatusCode}")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End Using
    End Function

    Private Async Function LoadSubmission(index As Integer) As Task
        Using client As New HttpClient()
            Try
                Dim response = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()
                    Dim submission = JsonConvert.DeserializeObject(Of Submission)(json)
                    DisplaySubmission(submission)
                Else
                    MessageBox.Show($"Failed to load submission. Status Code: {response.StatusCode}")
                End If
            Catch ex As Exception
                MessageBox.Show($"Error: {ex.Message}")
            End Try
        End Using
    End Function

    Private Sub DisplaySubmission(submission As Submission)
        If submission IsNot Nothing Then
            TextBox1.Text = submission.Name
            TextBox2.Text = submission.Email
            TextBox3.Text = submission.Phone
            TextBox4.Text = submission.Github_Link
            TextBox5.Text = submission.Stopwatch_Time
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
        If currentIndex < totalSubmissions - 1 Then
            currentIndex += 1
            Await LoadSubmission(currentIndex)
        End If
    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property Phone As String
    Public Property Github_Link As String
    Public Property Stopwatch_Time As String
End Class
