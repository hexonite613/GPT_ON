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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges11 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges12 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges13 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges14 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges15 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges16 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges17 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges18 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        UsernameLabel = New Label()
        PasswordLabel = New Label()
        UsernameTextBox = New TextBox()
        PasswordTextBox = New TextBox()
        LinkLabel1 = New LinkLabel()
        GroupBox1 = New GroupBox()
        PictureBox2 = New PictureBox()
        Back_Login = New Guna.UI2.WinForms.Guna2Button()
        SignUp = New Guna.UI2.WinForms.Guna2Button()
        Email_Textbox = New Guna.UI2.WinForms.Guna2TextBox()
        BirthDay_Textbox = New Guna.UI2.WinForms.Guna2TextBox()
        Name_Textbox = New Guna.UI2.WinForms.Guna2TextBox()
        Password_TextCheck = New Guna.UI2.WinForms.Guna2TextBox()
        SignPassword = New Guna.UI2.WinForms.Guna2TextBox()
        ID = New Guna.UI2.WinForms.Guna2TextBox()
        MonthCalendar1 = New MonthCalendar()
        Label8 = New Label()
        Label1 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        Password_Check = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Login_Form = New GroupBox()
        Login_button = New Guna.UI2.WinForms.Guna2Button()
        PictureBox1 = New PictureBox()
        GroupBox1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Login_Form.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' UsernameLabel
        ' 
        UsernameLabel.AutoSize = True
        UsernameLabel.BackColor = Color.Transparent
        UsernameLabel.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        UsernameLabel.ForeColor = Color.IndianRed
        UsernameLabel.Location = New Point(706, 233)
        UsernameLabel.Name = "UsernameLabel"
        UsernameLabel.Size = New Size(40, 14)
        UsernameLabel.TabIndex = 0
        UsernameLabel.Text = "아이디"
        UsernameLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PasswordLabel
        ' 
        PasswordLabel.AutoSize = True
        PasswordLabel.BackColor = Color.Transparent
        PasswordLabel.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        PasswordLabel.ForeColor = Color.IndianRed
        PasswordLabel.Location = New Point(706, 299)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New Size(29, 14)
        PasswordLabel.TabIndex = 2
        PasswordLabel.Text = "암호"
        PasswordLabel.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' UsernameTextBox
        ' 
        UsernameTextBox.Location = New Point(706, 251)
        UsernameTextBox.Name = "UsernameTextBox"
        UsernameTextBox.Size = New Size(220, 23)
        UsernameTextBox.TabIndex = 1
        ' 
        ' PasswordTextBox
        ' 
        PasswordTextBox.Location = New Point(706, 317)
        PasswordTextBox.Name = "PasswordTextBox"
        PasswordTextBox.PasswordChar = "*"c
        PasswordTextBox.Size = New Size(220, 23)
        PasswordTextBox.TabIndex = 3
        ' 
        ' LinkLabel1
        ' 
        LinkLabel1.AutoSize = True
        LinkLabel1.BackColor = Color.Transparent
        LinkLabel1.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        LinkLabel1.LinkColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        LinkLabel1.Location = New Point(706, 361)
        LinkLabel1.Name = "LinkLabel1"
        LinkLabel1.Size = New Size(137, 14)
        LinkLabel1.TabIndex = 5
        LinkLabel1.TabStop = True
        LinkLabel1.Text = "비밀번호를 까먹으셨나요?"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(Back_Login)
        GroupBox1.Controls.Add(SignUp)
        GroupBox1.Controls.Add(Email_Textbox)
        GroupBox1.Controls.Add(BirthDay_Textbox)
        GroupBox1.Controls.Add(Name_Textbox)
        GroupBox1.Controls.Add(Password_TextCheck)
        GroupBox1.Controls.Add(SignPassword)
        GroupBox1.Controls.Add(ID)
        GroupBox1.Controls.Add(MonthCalendar1)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label6)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Password_Check)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Location = New Point(0, 0)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(0)
        GroupBox1.Size = New Size(1093, 633)
        GroupBox1.TabIndex = 18
        GroupBox1.TabStop = False
        GroupBox1.Text = "SignUp_Form"
        GroupBox1.Visible = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.revised_expand_right_side
        PictureBox2.Location = New Point(499, 12)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(600, 618)
        PictureBox2.TabIndex = 27
        PictureBox2.TabStop = False
        ' 
        ' Back_Login
        ' 
        Back_Login.CustomizableEdges = CustomizableEdges1
        Back_Login.DisabledState.BorderColor = Color.DarkGray
        Back_Login.DisabledState.CustomBorderColor = Color.DarkGray
        Back_Login.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Back_Login.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Back_Login.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Back_Login.ForeColor = Color.White
        Back_Login.Location = New Point(387, 36)
        Back_Login.Name = "Back_Login"
        Back_Login.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Back_Login.Size = New Size(87, 23)
        Back_Login.TabIndex = 25
        Back_Login.Text = "로그인으로"
        ' 
        ' SignUp
        ' 
        SignUp.CustomizableEdges = CustomizableEdges3
        SignUp.DisabledState.BorderColor = Color.DarkGray
        SignUp.DisabledState.CustomBorderColor = Color.DarkGray
        SignUp.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        SignUp.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        SignUp.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        SignUp.ForeColor = Color.White
        SignUp.Location = New Point(369, 572)
        SignUp.Name = "SignUp"
        SignUp.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        SignUp.Size = New Size(124, 36)
        SignUp.TabIndex = 26
        SignUp.Text = "회원가입"
        ' 
        ' Email_Textbox
        ' 
        Email_Textbox.CustomizableEdges = CustomizableEdges5
        Email_Textbox.DefaultText = ""
        Email_Textbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Email_Textbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Email_Textbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Email_Textbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Email_Textbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Email_Textbox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Email_Textbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Email_Textbox.Location = New Point(52, 583)
        Email_Textbox.Name = "Email_Textbox"
        Email_Textbox.PasswordChar = ChrW(0)
        Email_Textbox.PlaceholderText = ""
        Email_Textbox.SelectedText = ""
        Email_Textbox.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        Email_Textbox.Size = New Size(200, 25)
        Email_Textbox.TabIndex = 24
        ' 
        ' BirthDay_Textbox
        ' 
        BirthDay_Textbox.BackColor = SystemColors.Control
        BirthDay_Textbox.CustomizableEdges = CustomizableEdges7
        BirthDay_Textbox.DefaultText = ""
        BirthDay_Textbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        BirthDay_Textbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        BirthDay_Textbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        BirthDay_Textbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        BirthDay_Textbox.Enabled = False
        BirthDay_Textbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        BirthDay_Textbox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        BirthDay_Textbox.ForeColor = Color.Black
        BirthDay_Textbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        BirthDay_Textbox.Location = New Point(52, 517)
        BirthDay_Textbox.Name = "BirthDay_Textbox"
        BirthDay_Textbox.PasswordChar = ChrW(0)
        BirthDay_Textbox.PlaceholderText = ""
        BirthDay_Textbox.ReadOnly = True
        BirthDay_Textbox.SelectedText = ""
        BirthDay_Textbox.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        BirthDay_Textbox.Size = New Size(168, 25)
        BirthDay_Textbox.TabIndex = 23
        ' 
        ' Name_Textbox
        ' 
        Name_Textbox.CustomizableEdges = CustomizableEdges9
        Name_Textbox.DefaultText = ""
        Name_Textbox.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Name_Textbox.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Name_Textbox.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Name_Textbox.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Name_Textbox.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Name_Textbox.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Name_Textbox.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Name_Textbox.Location = New Point(52, 277)
        Name_Textbox.Name = "Name_Textbox"
        Name_Textbox.PasswordChar = ChrW(0)
        Name_Textbox.PlaceholderText = ""
        Name_Textbox.SelectedText = ""
        Name_Textbox.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        Name_Textbox.Size = New Size(119, 25)
        Name_Textbox.TabIndex = 22
        ' 
        ' Password_TextCheck
        ' 
        Password_TextCheck.CustomizableEdges = CustomizableEdges11
        Password_TextCheck.DefaultText = ""
        Password_TextCheck.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        Password_TextCheck.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        Password_TextCheck.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Password_TextCheck.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        Password_TextCheck.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Password_TextCheck.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Password_TextCheck.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        Password_TextCheck.Location = New Point(49, 156)
        Password_TextCheck.Name = "Password_TextCheck"
        Password_TextCheck.PasswordChar = ChrW(0)
        Password_TextCheck.PlaceholderText = ""
        Password_TextCheck.SelectedText = ""
        Password_TextCheck.ShadowDecoration.CustomizableEdges = CustomizableEdges12
        Password_TextCheck.Size = New Size(200, 25)
        Password_TextCheck.TabIndex = 21
        ' 
        ' SignPassword
        ' 
        SignPassword.CustomizableEdges = CustomizableEdges13
        SignPassword.DefaultText = ""
        SignPassword.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        SignPassword.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        SignPassword.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        SignPassword.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        SignPassword.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SignPassword.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        SignPassword.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        SignPassword.Location = New Point(49, 212)
        SignPassword.Name = "SignPassword"
        SignPassword.PasswordChar = ChrW(0)
        SignPassword.PlaceholderText = ""
        SignPassword.SelectedText = ""
        SignPassword.ShadowDecoration.CustomizableEdges = CustomizableEdges14
        SignPassword.Size = New Size(200, 25)
        SignPassword.TabIndex = 20
        ' 
        ' ID
        ' 
        ID.CustomizableEdges = CustomizableEdges15
        ID.DefaultText = ""
        ID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        ID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        ID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        ID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ID.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        ID.Location = New Point(52, 75)
        ID.Name = "ID"
        ID.PasswordChar = ChrW(0)
        ID.PlaceholderText = ""
        ID.SelectedText = ""
        ID.ShadowDecoration.CustomizableEdges = CustomizableEdges16
        ID.Size = New Size(200, 25)
        ID.TabIndex = 19
        ' 
        ' MonthCalendar1
        ' 
        MonthCalendar1.Location = New Point(52, 343)
        MonthCalendar1.Name = "MonthCalendar1"
        MonthCalendar1.TabIndex = 6
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label8.Location = New Point(270, 589)
        Label8.Name = "Label8"
        Label8.Size = New Size(0, 14)
        Label8.TabIndex = 16
        Label8.Visible = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = Color.White
        Label1.Location = New Point(52, 58)
        Label1.Name = "Label1"
        Label1.Size = New Size(46, 14)
        Label1.TabIndex = 0
        Label1.Text = "아이디*"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(272, 223)
        Label7.Name = "Label7"
        Label7.Size = New Size(0, 14)
        Label7.TabIndex = 15
        Label7.Visible = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(272, 163)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 14)
        Label6.TabIndex = 14
        Label6.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = Color.White
        Label2.Location = New Point(49, 139)
        Label2.Name = "Label2"
        Label2.Size = New Size(198, 14)
        Label2.TabIndex = 2
        Label2.Text = "비밀번호(영문 대문자, 특수문자 포함)*"
        ' 
        ' Password_Check
        ' 
        Password_Check.AutoSize = True
        Password_Check.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Password_Check.ForeColor = Color.White
        Password_Check.Location = New Point(49, 200)
        Password_Check.Name = "Password_Check"
        Password_Check.Size = New Size(82, 14)
        Password_Check.TabIndex = 4
        Password_Check.Text = "비밀번호 확인*"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = Color.White
        Label5.Location = New Point(52, 320)
        Label5.Name = "Label5"
        Label5.Size = New Size(35, 14)
        Label5.TabIndex = 10
        Label5.Text = "생일*"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(52, 566)
        Label3.Name = "Label3"
        Label3.Size = New Size(40, 14)
        Label3.TabIndex = 6
        Label3.Text = "이메일"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("세종병원체 Bold", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(49, 260)
        Label4.Name = "Label4"
        Label4.Size = New Size(35, 14)
        Label4.TabIndex = 8
        Label4.Text = "이름*"
        ' 
        ' Login_Form
        ' 
        Login_Form.Controls.Add(GroupBox1)
        Login_Form.Controls.Add(Login_button)
        Login_Form.Controls.Add(UsernameLabel)
        Login_Form.Controls.Add(LinkLabel1)
        Login_Form.Controls.Add(PasswordLabel)
        Login_Form.Controls.Add(UsernameTextBox)
        Login_Form.Controls.Add(PasswordTextBox)
        Login_Form.Controls.Add(PictureBox1)
        Login_Form.Location = New Point(-1, -15)
        Login_Form.Name = "Login_Form"
        Login_Form.Size = New Size(1099, 633)
        Login_Form.TabIndex = 19
        Login_Form.TabStop = False
        Login_Form.Text = "GroupBox2"
        ' 
        ' Login_button
        ' 
        Login_button.Animated = True
        Login_button.CustomizableEdges = CustomizableEdges17
        Login_button.DisabledState.BorderColor = Color.DarkGray
        Login_button.DisabledState.CustomBorderColor = Color.DarkGray
        Login_button.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Login_button.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Login_button.Font = New Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point)
        Login_button.ForeColor = Color.White
        Login_button.Location = New Point(706, 399)
        Login_button.Name = "Login_button"
        Login_button.ShadowDecoration.CustomizableEdges = CustomizableEdges18
        Login_button.Size = New Size(220, 45)
        Login_button.TabIndex = 21
        Login_button.Text = "로그인"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.revised_expand
        PictureBox1.ImageLocation = ""
        PictureBox1.Location = New Point(0, 15)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(541, 618)
        PictureBox1.TabIndex = 20
        PictureBox1.TabStop = False
        ' 
        ' LoginForm
        ' 
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
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Login_Form.ResumeLayout(False)
        Login_Form.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)

    End Sub

    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Password_Check As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Login_Form As GroupBox
    Friend WithEvents Login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Login_button As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents SignPassword As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BirthDay_Textbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Name_Textbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Password_TextCheck As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Email_Textbox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Back_Login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents SignUp As Guna.UI2.WinForms.Guna2Button

End Class
