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
        txtName = New Label()
        txtEmail = New Label()
        txtPhone = New Label()
        txtGithubRepo = New Label()
        txtStopwatchTime = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        TextBox4 = New TextBox()
        TextBox5 = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.AutoSize = True
        txtName.Location = New Point(124, 85)
        txtName.Name = "txtName"
        txtName.Size = New Size(49, 20)
        txtName.TabIndex = 0
        txtName.Text = "Name"
        ' 
        ' txtEmail
        ' 
        txtEmail.AutoSize = True
        txtEmail.Location = New Point(124, 132)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(46, 20)
        txtEmail.TabIndex = 1
        txtEmail.Text = "Email"
        ' 
        ' txtPhone
        ' 
        txtPhone.AutoSize = True
        txtPhone.Location = New Point(124, 182)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(74, 20)
        txtPhone.TabIndex = 2
        txtPhone.Text = "Phone No"
        ' 
        ' txtGithubRepo
        ' 
        txtGithubRepo.AutoSize = True
        txtGithubRepo.Location = New Point(124, 232)
        txtGithubRepo.Name = "txtGithubRepo"
        txtGithubRepo.Size = New Size(86, 20)
        txtGithubRepo.TabIndex = 3
        txtGithubRepo.Text = "GitHub Link"
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.AutoSize = True
        txtStopwatchTime.Location = New Point(124, 287)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(116, 20)
        txtStopwatchTime.TabIndex = 4
        txtStopwatchTime.Text = "Stopwatch Time"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Gold
        btnPrevious.Font = New Font("Segoe UI", 11F)
        btnPrevious.Location = New Point(124, 344)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(284, 58)
        btnPrevious.TabIndex = 5
        btnPrevious.Text = "&PREVIOUS (CTRL + P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.Turquoise
        btnNext.Font = New Font("Segoe UI", 11F)
        btnNext.Location = New Point(413, 344)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(284, 58)
        btnNext.TabIndex = 6
        btnNext.Text = "&NEXT (CTRL + N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(322, 82)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(375, 27)
        TextBox1.TabIndex = 7
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(322, 129)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(375, 27)
        TextBox2.TabIndex = 8
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(322, 179)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(375, 27)
        TextBox3.TabIndex = 9
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(322, 229)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(375, 27)
        TextBox4.TabIndex = 10
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(322, 284)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(375, 27)
        TextBox5.TabIndex = 11
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(242, 39)
        Label6.Name = "Label6"
        Label6.Size = New Size(322, 20)
        Label6.TabIndex = 12
        Label6.Text = "Hardik Nahta, Slidely Task 2 - View Submissions"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(TextBox5)
        Controls.Add(TextBox4)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGithubRepo)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As Label
    Friend WithEvents txtEmail As Label
    Friend WithEvents txtPhone As Label
    Friend WithEvents txtGithubRepo As Label
    Friend WithEvents txtStopwatchTime As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
End Class
