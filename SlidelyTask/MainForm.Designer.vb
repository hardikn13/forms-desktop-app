<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        btnCreateSubmission = New Button()
        btnViewSubmissions = New Button()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' btnCreateSubmission
        ' 
        btnCreateSubmission.BackColor = Color.Turquoise
        btnCreateSubmission.Font = New Font("Segoe UI", 11F)
        btnCreateSubmission.Location = New Point(111, 261)
        btnCreateSubmission.Name = "btnCreateSubmission"
        btnCreateSubmission.Size = New Size(510, 89)
        btnCreateSubmission.TabIndex = 0
        btnCreateSubmission.Text = "&CREATE NEW SUBMISSION (Alt + C)"
        btnCreateSubmission.UseVisualStyleBackColor = False
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Gold
        btnViewSubmissions.Font = New Font("Segoe UI", 11F)
        btnViewSubmissions.Location = New Point(111, 152)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(510, 87)
        btnViewSubmissions.TabIndex = 1
        btnViewSubmissions.Text = "&VIEW SUBMISSIONS (Alt + V)"
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(210, 89)
        Label6.Name = "Label6"
        Label6.Size = New Size(319, 20)
        Label6.TabIndex = 13
        Label6.Text = "Hardik Nahta, Slidely Task 2 - Slidely Form App"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label6)
        Controls.Add(btnViewSubmissions)
        Controls.Add(btnCreateSubmission)
        Name = "Form1"
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCreateSubmission As Button
    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents Label6 As Label

End Class
