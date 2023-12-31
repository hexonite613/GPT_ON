<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Login As System.Windows.Forms.Button

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        LogoPictureBox = New PictureBox()
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        Login = New Button()
        LinkLabel1 = New LinkLabel()
        GroupBox1 = New GroupBox()
        Back_Login = New Button()
        SignUp = New Button()
        MonthCalendar1 = New MonthCalendar()
        Label8 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        ID = New TextBox()
        Label6 = New Label()
        Label2 = New Label()
        SignPassword = New TextBox()
        BirthDay_Textbox = New TextBox()
        Password_Check = New Label()
        Password_TextCheck = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Name_Textbox = New TextBox()
        Email_Textbox = New TextBox()
        Label4 = New Label()
        Login_Form = New GroupBox()
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        Login_Form.SuspendLayout()
        SuspendLayout()
        ' 
        ' LogoPictureBox
        ' 
        LogoPictureBox.BackColor = Color.Transparent
        LogoPictureBox.Image = CType(resources.GetObject("LogoPictureBox.Image"), Image)
        LogoPictureBox.Location = New Point(82, 118)
        LogoPictureBox.Name = "LogoPictureBox"
        LogoPictureBox.Size = New Size(415, 415)
        LogoPictureBox.SizeMode = PictureBoxSizeMode.AutoSize
        LogoPictureBox.TabIndex = 0
        LogoPictureBox.TabStop = False
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.ForeColor = Color.IndianRed
        UsernameLabel.Location = New Point(668, 212)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(43, 15)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "아이디"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.ForeColor = Color.IndianRed
        PasswordLabel.Location = New Point(668, 295)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(31, 15)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "암호"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(668, 247)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 23)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(668, 313)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 23)
        PasswordTextBox.TabIndex = 3
        ' 
        ' Login
        ' 
        Login.BackColor = Color.Transparent
        Login.BackgroundImageLayout = ImageLayout.Center
        Login.ForeColor = Color.White
        Login.Location = New Point(668, 387)
        Login.Name = "Login"
        Login.Size = New Size(220, 23)
        Login.TabIndex = 4
        Login.Text = "로그인"
        Login.UseVisualStyleBackColor = False
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Location = New Point(668, 357)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(149, 15)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "비밀번호를 까먹으셨나요?"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Back_Login)
        GroupBox1.Controls.Add(SignUp)
        GroupBox1.Controls.Add(MonthCalendar1)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(ID)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(SignPassword)
        GroupBox1.Controls.Add(BirthDay_Textbox)
        GroupBox1.Controls.Add(Password_Check)
        GroupBox1.Controls.Add(Password_TextCheck)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Name_Textbox)
        GroupBox1.Controls.Add(Email_Textbox)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(0)
        GroupBox1.Size = New Size(1297, 782)
        GroupBox1.TabIndex = 18
        GroupBox1.TabStop = False
        GroupBox1.Text = "SignUp_Form"
        GroupBox1.Visible = False
        ' 
        ' Back_Login
        ' 
        Back_Login.Location = New Point(739, 566)
        Back_Login.Name = "Back_Login"
        Back_Login.Size = New Size(75, 23)
        Back_Login.TabIndex = 18
        Back_Login.Text = "로그인으로"
        Back_Login.UseVisualStyleBackColor = True
        ' 
        ' SignUp
        ' 
        SignUp.Location = New Point(914, 566)
        SignUp.Name = "SignUp"
        SignUp.Size = New Size(75, 23)
        SignUp.TabIndex = 17
        SignUp.Text = "회원가입"
        SignUp.UseVisualStyleBackColor = True
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(52, 373)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(217, 588)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 15)
        Label8.TabIndex = 16
        Label8.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(49, 38)
        Label1.Name = "Label1"
        Label1.Size = New Size(48, 15)
        Label1.TabIndex = 0
        Label1.Text = "아이디*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(171, 215)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 15)
        Label7.TabIndex = 15
        Label7.Visible = False
        ' 
        ' ID
        ' 
        ID.Location = New Point(52, 69)
        ID.Name = "ID"
        ID.Size = New Size(100, 23)
        ID.TabIndex = 1
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(180, 144)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 15)
        Label6.TabIndex = 14
        Label6.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(49, 113)
        Label2.Name = "Label2"
        Label2.Size = New Size(215, 15)
        Label2.TabIndex = 2
        Label2.Text = "비밀번호(영문 대문자, 특수문자 포함)*"
        ' 
        ' SignPassword
        ' 
        SignPassword.Location = New Point(52, 144)
        SignPassword.Name = "SignPassword"
        SignPassword.PasswordChar = "*"c
        SignPassword.Size = New Size(100, 23)
        SignPassword.TabIndex = 3
        ' 
        ' BirthDay_Textbox
        ' 
        BirthDay_Textbox.Enabled = False
        BirthDay_Textbox.Location = New Point(284, 512)
        BirthDay_Textbox.Name = "BirthDay_Textbox"
        BirthDay_Textbox.ReadOnly = True
        BirthDay_Textbox.Size = New Size(168, 23)
        BirthDay_Textbox.TabIndex = 12
        ' 
        ' Password_Check
        ' 
        Password_Check.AutoSize = True
        Password_Check.Location = New Point(49, 184)
        Password_Check.Name = "Password_Check"
        Password_Check.Size = New Size(88, 15)
        Password_Check.TabIndex = 4
        Password_Check.Text = "비밀번호 확인*"
        ' 
        ' Password_TextCheck
        ' 
        Password_TextCheck.Location = New Point(52, 215)
        Password_TextCheck.Name = "Password_TextCheck"
        Password_TextCheck.PasswordChar = "*"c
        Password_TextCheck.Size = New Size(100, 23)
        Password_TextCheck.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(49, 337)
        Label5.Name = "Label5"
        Label5.Size = New Size(36, 15)
        Label5.TabIndex = 10
        Label5.Text = "생일*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(49, 557)
        Label3.Name = "Label3"
        Label3.Size = New Size(43, 15)
        Label3.TabIndex = 6
        Label3.Text = "이메일"
        ' 
        ' Name_Textbox
        ' 
        Name_Textbox.Location = New Point(52, 291)
        Name_Textbox.Name = "Name_Textbox"
        Name_Textbox.Size = New Size(100, 23)
        Name_Textbox.TabIndex = 5
        ' 
        ' Email_Textbox
        ' 
        Email_Textbox.Location = New Point(52, 588)
        Email_Textbox.Name = "Email_Textbox"
        Email_Textbox.Size = New Size(147, 23)
        Email_Textbox.TabIndex = 7
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(49, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(36, 15)
        Label4.TabIndex = 8
        Label4.Text = "이름*"
        ' 
        ' Login_Form
        ' 
        Login_Form.BackgroundImage = My.Resources.Resources._9091671__1_
        Login_Form.Controls.Add(GroupBox1)
        Login_Form.Controls.Add(LogoPictureBox)
        Login_Form.Controls.Add(UsernameLabel)
        Login_Form.Controls.Add(LinkLabel1)
        Login_Form.Controls.Add(PasswordLabel)
        Login_Form.Controls.Add(Login)
        Login_Form.Controls.Add(UsernameTextBox)
        Login_Form.Controls.Add(PasswordTextBox)
        Login_Form.Location = New Point(-1, -15)
        Login_Form.Name = "Login_Form"
        Login_Form.Size = New Size(1099, 633)
        Login_Form.TabIndex = 19
        Login_Form.TabStop = False
        Login_Form.Text = "GroupBox2"
        ' 
        ' LoginForm
        ' 
        AcceptButton = Login
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(1097, 616)
        Controls.Add(Login_Form)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        MinimizeBox = False
        Name = "LoginForm"
        SizeGripStyle = SizeGripStyle.Hide
        StartPosition = FormStartPosition.CenterParent
        Text = "LoginForm1"
        CType(LogoPictureBox, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        Login_Form.ResumeLayout(False)
        Login_Form.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SignPassword As TextBox
    Friend WithEvents BirthDay_Textbox As TextBox
    Friend WithEvents Password_Check As Label
    Friend WithEvents Password_TextCheck As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Name_Textbox As TextBox
    Friend WithEvents Email_Textbox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents SignUp As Button
    Friend WithEvents Back_Login As Button
    Friend WithEvents Login_Form As GroupBox

End Class
