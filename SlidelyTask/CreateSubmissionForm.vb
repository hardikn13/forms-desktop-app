Public Class CreateSubmissionForm
    Dim stopwatchRunning As Boolean = False
    Dim stopwatchTime As TimeSpan = TimeSpan.Zero

    Public Sub New()
        InitializeComponent()
        txtStopwatchTime.Text = "00:00:00"
    End Sub
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
        txtStopwatchTime.Text = stopwatchTime.ToString("hh\:mm\:ss")
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        ' Code to save submission to the backend (to be implemented)
        MessageBox.Show("Submission saved!")
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
End Class