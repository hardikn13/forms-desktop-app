<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtGithubRepo = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnStopwatch = New System.Windows.Forms.Button()
        Me.lblGithubRepo = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.txtStopwatchTime = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        ' 
        ' Label6
        ' 
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(232, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(327, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Hardik Nahta, Slidely Task 2 - Create Submission"
        ' 
        ' txtGithubRepo
        ' 
        Me.txtGithubRepo.Location = New System.Drawing.Point(312, 234)
        Me.txtGithubRepo.Name = "txtGithubRepo"
        Me.txtGithubRepo.Size = New System.Drawing.Size(375, 27)
        Me.txtGithubRepo.TabIndex = 23
        ' 
        ' txtPhone
        ' 
        Me.txtPhone.Location = New System.Drawing.Point(312, 184)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(375, 27)
        Me.txtPhone.TabIndex = 22
        ' 
        ' txtEmail
        ' 
        Me.txtEmail.Location = New System.Drawing.Point(312, 134)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(375, 27)
        Me.txtEmail.TabIndex = 21
        ' 
        ' txtName
        ' 
        Me.txtName.Location = New System.Drawing.Point(312, 87)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(375, 27)
        Me.txtName.TabIndex = 20
        ' 
        ' btnSubmit
        ' 
        Me.btnSubmit.BackColor = System.Drawing.Color.Turquoise
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 11.0F)
        Me.btnSubmit.Location = New System.Drawing.Point(275, 354)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(284, 58)
        Me.btnSubmit.TabIndex = 19
        Me.btnSubmit.Text = "&SUBMIT (CTRL + S)"
        Me.btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' btnStopwatch
        ' 
        Me.btnStopwatch.BackColor = System.Drawing.Color.Gold
        Me.btnStopwatch.Font = New System.Drawing.Font("Segoe UI", 11.0F)
        Me.btnStopwatch.Location = New System.Drawing.Point(114, 291)
        Me.btnStopwatch.Name = "btnStopwatch"
        Me.btnStopwatch.Size = New System.Drawing.Size(361, 34)
        Me.btnStopwatch.TabIndex = 18
        Me.btnStopwatch.Text = "&TOGGLE STOPWATCH (CTRL + T)"
        Me.btnStopwatch.UseVisualStyleBackColor = False
        ' 
        ' lblGithubRepo
        ' 
        Me.lblGithubRepo.AutoSize = True
        Me.lblGithubRepo.Location = New System.Drawing.Point(114, 237)
        Me.lblGithubRepo.Name = "lblGithubRepo"
        Me.lblGithubRepo.Size = New System.Drawing.Size(86, 20)
        Me.lblGithubRepo.TabIndex = 16
        Me.lblGithubRepo.Text = "GitHub Link"
        ' 
        ' lblPhone
        ' 
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(114, 187)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(74, 20)
        Me.lblPhone.TabIndex = 15
        Me.lblPhone.Text = "Phone No"
        ' 
        ' lblEmail
        ' 
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(114, 137)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(46, 20)
        Me.lblEmail.TabIndex = 14
        Me.lblEmail.Text = "Email"
        ' 
        ' lblName
        ' 
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(114, 90)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 20)
        Me.lblName.TabIndex = 13
        Me.lblName.Text = "Name"
        ' 
        ' Timer1
        ' 
        Me.Timer1.Interval = 1000
        ' 
        ' txtStopwatchTime
        ' 
        Me.txtStopwatchTime.Location = New System.Drawing.Point(502, 297)
        Me.txtStopwatchTime.Name = "txtStopwatchTime"
        Me.txtStopwatchTime.ReadOnly = True
        Me.txtStopwatchTime.Size = New System.Drawing.Size(185, 27)
        Me.txtStopwatchTime.TabIndex = 24
        ' 
        ' CreateSubmissionForm
        ' 
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0F, 20.0F)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtStopwatchTime)
        Me.Controls.Add(Me.txtGithubRepo)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.btnStopwatch)
        Me.Controls.Add(Me.lblGithubRepo)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "CreateSubmissionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents txtGithubRepo As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStopwatch As Button
    Friend WithEvents lblGithubRepo As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblName As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents txtStopwatchTime As TextBox
End Class
