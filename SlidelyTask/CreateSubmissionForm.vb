Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class CreateSubmissionForm
    Dim stopwatchRunning As Boolean = False
    Dim stopwatchTime As TimeSpan = TimeSpan.Zero

    Private Sub btnStopwatch_Click(sender As Object, e As EventArgs) Handles btnStopwatch.Click
        If stopwatchRunning Then
            Timer1.Stop()
            btnStopwatch.Text = "Start Stopwatch"
        Else
            Timer1.Start()
            btnStopwatch.Text = "Pause Stopwatch"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        stopwatchTime = stopwatchTime.Add(TimeSpan.FromSeconds(1))
        txtStopwatchTime.Text = stopwatchTime.ToString("mm\:ss")
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission = New With {
            .name = txtName.Text,
            .email = txtEmail.Text,
            .phone = txtPhone.Text,
            .github_link = txtGithubRepo.Text,
            .stopwatch_time = txtStopwatchTime.Text
        }

        MessageBox.Show($"Name: {txtName.Text}, Email: {txtEmail.Text}, Phone: {txtPhone.Text}, GitHub Link: {txtGithubRepo.Text}, Stopwatch Time: {txtStopwatchTime.Text}")

        Dim json = JsonConvert.SerializeObject(submission)
        Dim data = New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response = Await client.PostAsync("http://localhost:3000/submit", data)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission saved!")
            Else
                MessageBox.Show("Failed to save submission.")
            End If
        End Using
    End Sub

    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.S) Then
            btnSubmit.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.T) Then
            btnStopwatch.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set initial stopwatch time to 00:00
        txtStopwatchTime.Text = "00:00"
    End Sub
End Class
