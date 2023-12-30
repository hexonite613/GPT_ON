Imports System.Configuration
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class SignupForm
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Private Sub SignupForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As New SqlConnection(connectionString)
            connection.Open()
        End Using
    End Sub
    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        BirthDay_Textbox.Text = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
    End Sub

    '비밀번호 조건 확인'
    Private Function CheckPassword(password As String)
        If password.Any(Function(c) Char.IsUpper(c)) Then
            If password.Any(Function(c) Not Char.IsLetterOrDigit(c)) Then
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If
    End Function

    '비밀번호 텍스트 변경'
    Private Sub Password_TextChanged(sender As Object, e As EventArgs) Handles Password.TextChanged
        If CheckPassword(Password.Text) = True Then
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
    Private Sub Password_TextCheck_TextChanged(sender As Object, e As EventArgs) Handles Password_TextCheck.TextChanged
        If Password_TextCheck.Text = Password.Text Then
            Label7.Text = "비밀번호가 일치합니다."
            Label7.ForeColor = Color.LimeGreen
            Label7.Visible = True
        Else
            Label7.Text = "비밀번호가 일치하지 않습니다."
            Label7.ForeColor = Color.Red
            Label7.Visible = True
        End If
    End Sub

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

    '회원가입 버튼 클릭 시'
    Private Sub SignUp_Click(sender As Object, e As EventArgs) Handles SignUp.Click
        Using connection As New SqlConnection(connectionString)

            Try
                connection.Open()
                If Email_Textbox.Text = "" Then
                    Dim query As String = "Insert Into GPT_Game.dbo.[user] (id, password, name, Birthday) values (@id, @password, @name, @Birthday)"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", ID.Text)
                    command.Parameters.AddWithValue("@password", Password.Text)
                    command.Parameters.AddWithValue("@name", Name_Textbox.Text)
                    command.Parameters.AddWithValue("@Birthday", BirthDay_Textbox.Text)
                    MsgBox("회원가입을 환영합니다")
                    command.ExecuteNonQuery()
                    Me.Close()
                Else
                    Dim query As String = "Insert Into GPT_Game.dbo.[user] (id, password, name, Birthday, [E-mail]) values (@id, @password, @name, @Birthday, @Email)"
                    Dim command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@id", ID.Text)
                    command.Parameters.AddWithValue("@password", Password.Text)
                    command.Parameters.AddWithValue("@name", Name_Textbox.Text)
                    command.Parameters.AddWithValue("@Birthday", BirthDay_Textbox.Text)
                    command.Parameters.AddWithValue("@Email", Email_Textbox.Text)
                    MsgBox("회원가입을 환영합니다")
                    command.ExecuteNonQuery()
                    Me.Close()
                End If
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            Finally
                connection.Close()
            End Try
        End Using
    End Sub

End Class