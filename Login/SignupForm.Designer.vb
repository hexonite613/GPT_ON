<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignupForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        ID = New TextBox()
        Label2 = New Label()
        Password = New TextBox()
        Password_Check = New Label()
        Password_TextCheck = New TextBox()
        Label3 = New Label()
        Email_Textbox = New TextBox()
        Label4 = New Label()
        Name_Textbox = New TextBox()
        Label5 = New Label()
        MonthCalendar1 = New MonthCalendar()
        BirthDay_Textbox = New TextBox()
        SignUp = New Button()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(117, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(43, 15)
        Label1.TabIndex = 0
        Label1.Text = "아이디"
        ' 
        ' ID
        ' 
        ID.Location = New Point(117, 52)
        ID.Name = "ID"
        ID.Size = New Size(100, 23)
        ID.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(117, 99)
        Label2.Name = "Label2"
        Label2.Size = New Size(210, 15)
        Label2.TabIndex = 2
        Label2.Text = "비밀번호(영문 대문자, 특수문자 포함)"
        ' 
        ' Password
        ' 
        Password.Location = New Point(117, 127)
        Password.Name = "Password"
        Password.PasswordChar = "*"c
        Password.Size = New Size(100, 23)
        Password.TabIndex = 3
        ' 
        ' Password_Check
        ' 
        Password_Check.AutoSize = True
        Password_Check.Location = New Point(117, 170)
        Password_Check.Name = "Password_Check"
        Password_Check.Size = New Size(83, 15)
        Password_Check.TabIndex = 4
        Password_Check.Text = "비밀번호 확인"
        ' 
        ' Password_TextCheck
        ' 
        Password_TextCheck.Location = New Point(117, 198)
        Password_TextCheck.Name = "Password_TextCheck"
        Password_TextCheck.PasswordChar = "*"c
        Password_TextCheck.Size = New Size(100, 23)
        Password_TextCheck.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(117, 543)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 6
        Label3.Text = "이메일"
        ' 
        ' Email_Textbox
        ' 
        Email_Textbox.Location = New Point(117, 571)
        Email_Textbox.Name = "Email_Textbox"
        Email_Textbox.Size = New Size(147, 23)
        Email_Textbox.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(117, 246)
        Label4.Name = "Label4"
        Label4.Size = New Size(31, 15)
        Label4.TabIndex = 8
        Label4.Text = "이름"
        ' 
        ' Name_Textbox
        ' 
        Name_Textbox.Location = New Point(117, 274)
        Name_Textbox.Name = "Name_Textbox"
        Name_Textbox.Size = New Size(100, 23)
        Name_Textbox.TabIndex = 5
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(117, 323)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 10
        Label5.Text = "생일"
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(117, 356)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 6
        ' 
        ' BirthDay_Textbox
        ' 
        BirthDay_Textbox.Enabled = False
        BirthDay_Textbox.Location = New Point(349, 495)
        BirthDay_Textbox.Name = "BirthDay_Textbox"
        BirthDay_Textbox.ReadOnly = True
        BirthDay_Textbox.Size = New Size(168, 23)
        BirthDay_Textbox.TabIndex = 12
        ' 
        ' SignUp
        ' 
        SignUp.Location = New Point(927, 554)
        SignUp.Name = "SignUp"
        SignUp.Size = New Size(75, 23)
        SignUp.TabIndex = 8
        SignUp.Text = "회원가입"
        SignUp.UseVisualStyleBackColor = True
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(248, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 14
        Label6.Visible = False
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(239, 201)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 15
        Label7.Visible = False
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(285, 574)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 15)
        Label8.TabIndex = 16
        Label8.Visible = False
        ' 
        ' SignupForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1097, 616)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(SignUp)
        Controls.Add(BirthDay_Textbox)
        Controls.Add(MonthCalendar1)
        Controls.Add(Label5)
        Controls.Add(Name_Textbox)
        Controls.Add(Label4)
        Controls.Add(Email_Textbox)
        Controls.Add(Label3)
        Controls.Add(Password_TextCheck)
        Controls.Add(Password_Check)
        Controls.Add(Password)
        Controls.Add(Label2)
        Controls.Add(ID)
        Controls.Add(Label1)
        Name = "SignupForm"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Password As TextBox
    Friend WithEvents Password_Check As Label
    Friend WithEvents Password_TextCheck As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Email_Textbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Name_Textbox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents BirthDay_Textbox As TextBox
    Friend WithEvents SignUp As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
