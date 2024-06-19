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
        components = New ComponentModel.Container()
        Label6 = New Label()
        TextBox4 = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        btnSubmit = New Button()
        btnStopwatch = New Button()
        txtGithubRepo = New Label()
        txtPhone = New Label()
        txtEmail = New Label()
        txtName = New Label()
        Timer1 = New Timer(components)
        txtStopwatchTime = New TextBox()
        SuspendLayout()
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(232, 44)
        Label6.Name = "Label6"
        Label6.Size = New Size(327, 20)
        Label6.TabIndex = 25
        Label6.Text = "Hardik Nahta, Slidely Task 2 - Create Submission"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(312, 234)
        TextBox4.Name = "TextBox4"
        TextBox4.Size = New Size(375, 27)
        TextBox4.TabIndex = 23
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(312, 184)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(375, 27)
        TextBox3.TabIndex = 22
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(312, 134)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(375, 27)
        TextBox2.TabIndex = 21
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(312, 87)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(375, 27)
        TextBox1.TabIndex = 20
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.Turquoise
        btnSubmit.Font = New Font("Segoe UI", 11F)
        btnSubmit.Location = New Point(275, 354)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(284, 58)
        btnSubmit.TabIndex = 19
        btnSubmit.Text = "&SUBMIT (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnStopwatch
        ' 
        btnStopwatch.BackColor = Color.Gold
        btnStopwatch.Font = New Font("Segoe UI", 11F)
        btnStopwatch.Location = New Point(114, 291)
        btnStopwatch.Name = "btnStopwatch"
        btnStopwatch.Size = New Size(361, 34)
        btnStopwatch.TabIndex = 18
        btnStopwatch.Text = "&TOGGLE STOPWATCH (CTRL + T)"
        btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' txtGithubRepo
        ' 
        txtGithubRepo.AutoSize = True
        txtGithubRepo.Location = New Point(114, 237)
        txtGithubRepo.Name = "txtGithubRepo"
        txtGithubRepo.Size = New Size(86, 20)
        txtGithubRepo.TabIndex = 16
        txtGithubRepo.Text = "GitHub Link"
        ' 
        ' txtPhone
        ' 
        txtPhone.AutoSize = True
        txtPhone.Location = New Point(114, 187)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(74, 20)
        txtPhone.TabIndex = 15
        txtPhone.Text = "Phone No"
        ' 
        ' txtEmail
        ' 
        txtEmail.AutoSize = True
        txtEmail.Location = New Point(114, 137)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(46, 20)
        txtEmail.TabIndex = 14
        txtEmail.Text = "Email"
        ' 
        ' txtName
        ' 
        txtName.AutoSize = True
        txtName.Location = New Point(114, 90)
        txtName.Name = "txtName"
        txtName.Size = New Size(49, 20)
        txtName.TabIndex = 13
        txtName.Text = "Name"
        ' 
        ' Timer1
        ' 
        Timer1.Interval = 1000
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(502, 297)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(185, 27)
        txtStopwatchTime.TabIndex = 24
        ' 
        ' CreateSubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(txtStopwatchTime)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnSubmit)
        Controls.Add(btnStopwatch)
        Controls.Add(txtGithubRepo)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "CreateSubmissionForm"
        Text = "CreateSubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents txtGithubRepo As Label
    Friend WithEvents txtPhone As Label
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtStopwatchTime As TextBox
End Class
