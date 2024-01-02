Imports System.Configuration
Imports System.Data.SqlClient
Public Class LoginForm
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As New SqlConnection(connectionString)
            connection.Open()
        End Using
    End Sub

    ' 로그인 확인 함수'
    Private Function CheckLogin(username As String, password As String) As String
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT name FROM GPT_Game.dbo.[user] WHERE id = @Username AND password = @Password"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Using reader As SqlDataReader = command.ExecuteReader()
                    ' 데이터가 있는지 확인
                    If reader.Read() Then
                        Return reader("name").ToString()
                    End If
                End Using
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
                connection.Close()
            End Try
            Return Nothing
        End Using
    End Function

    '로그인 시도'
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        ' 사용자 정보 확인'
        Dim loggedInUserName As String = CheckLogin(username, password)

        If loggedInUserName IsNot Nothing Then
            MessageBox.Show("로그인 성공" + vbCrLf + loggedInUserName + "님 환영합니다.")
            Me.Close()
        Else
            MessageBox.Show("아이디 또는 비밀번호가 틀렸습니다.")
        End If
    End Sub



    '*************회원 가입*************'

    '회원 가입 창 보여주기'
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GroupBox1.Visible = True
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        BirthDay_Textbox.Text = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
    End Sub

    '비밀번호 조건 확인'
    Private Function CheckPassword(Passwordcheck As String)
        If Passwordcheck.Any(Function(c) Char.IsUpper(c)) Then
            If Passwordcheck.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles SignPassword.TextChanged
        If CheckPassword(SignPassword.Text) = True Then
            Label6.Text = "비밀번호가 조건에 일치합니다."
            Label6.ForeColor = Color.LimeGreen
            Label6.Visible = True
        Else
            Label6.Text = "비밀번호가 조건에 일치하지 않습니다."
            Label6.ForeColor = Color.Red
            Label6.Visible = True
        End If
    End Sub

    '비밀번호 확인 텍스트 변경'
    Private Function CheckPasswordText(Passwordcheck As String)
        If Password_TextCheck.Text = SignPassword.Text Then
            Label7.Text = "비밀번호가 일치합니다."
            Label7.ForeColor = Color.LimeGreen
            Label7.Visible = True
            Return True
        Else
            Label7.Text = "비밀번호가 일치하지 않습니다."
            Label7.ForeColor = Color.Red
            Label7.Visible = True
            Return False
        End If
    End Function

    Private Sub Password_TextCheck_TextChanged(sender As Object, e As EventArgs) Handles Password_TextCheck.TextChanged
        CheckPasswordText(Password_TextCheck.Text)
    End Sub

    '이메일 형식 확인'
    Private Sub Email_Textbox_TextChanged(sender As Object, e As EventArgs) Handles Email_Textbox.TextChanged
        If Email_Textbox.Text.Contains("@") Then
            Label8.Text = "이메일 형식이 맞습니다."
            Label8.ForeColor = Color.LimeGreen
            Label8.Visible = True
        Else
            Label8.Text = "이메일 형식에 맞춰서 적어주시기 바랍니다."
            Label8.ForeColor = Color.Red
            Label8.Visible = True
        End If
    End Sub

    Private Function CheckAll(ID As String, Pass As String, Name As String, Birth As String)
        If ID = "" Or Pass = "" Or Name = "" Or Birth = "" Or CheckPasswordText(Password_TextCheck.Text) = False Then
            Return False
        Else
            Return True
        End If

    End Function

    '회원 가입 시도'
    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        Using connection As New SqlConnection(connectionString)
            If CheckAll(ID.Text, SignPassword.Text, Name_Textbox.Text, BirthDay_Textbox.Text) Then

                Try
                    connection.Open()
                    If Email_Textbox.Text = "" Then
                        Dim query As String = "Insert Into GPT_Game.dbo.[user] (id, password, name, Birthday) values (@id, @password, @name, @Birthday)"
                        Dim command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@id", ID.Text)
                        command.Parameters.AddWithValue("@password", SignPassword.Text)
                        command.Parameters.AddWithValue("@name", Name_Textbox.Text)
                        command.Parameters.AddWithValue("@Birthday", BirthDay_Textbox.Text)
                        MsgBox(Name_Textbox.Text + "님 회원가입을 환영합니다")
                        command.ExecuteNonQuery()
                        GroupBox1.Visible = False
                    Else
                        Dim query As String = "Insert Into GPT_Game.dbo.[user] (id, password, name, Birthday, [E-mail]) values (@id, @password, @name, @Birthday, @Email)"
                        Dim command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@id", ID.Text)
                        command.Parameters.AddWithValue("@password", SignPassword.Text)
                        command.Parameters.AddWithValue("@name", Name_Textbox.Text)
                        command.Parameters.AddWithValue("@Birthday", BirthDay_Textbox.Text)
                        command.Parameters.AddWithValue("@Email", Email_Textbox.Text)
                        MsgBox(Name_Textbox.Text + "님 회원가입을 환영합니다")
                        command.ExecuteNonQuery()
                        GroupBox1.Visible = False
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                Finally
                    connection.Close()
                End Try
            Else
                MsgBox("입력 정보를 확인해주세요")
            End If
        End Using
    End Sub

    '회원가입 창 숨기기'
    Private Sub Back_Login_Click(sender As Object, e As EventArgs) Handles Back_Login.Click
        GroupBox1.Visible = False
    End Sub
End Class

