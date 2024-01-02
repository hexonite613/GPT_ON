Imports System.Configuration
Imports System.Data.SqlClient
Public Class LoginForm
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using connection As New SqlConnection(connectionString)
            connection.Open()
        End Using
    End Sub

    ' �α��� Ȯ�� �Լ�'
    Private Function CheckLogin(username As String, password As String) As String
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "SELECT name FROM GPT_Game.dbo.[user] WHERE id = @Username AND password = @Password"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@Username", username)
                command.Parameters.AddWithValue("@Password", password)

                Using reader As SqlDataReader = command.ExecuteReader()
                    ' �����Ͱ� �ִ��� Ȯ��
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

    '�α��� �õ�'
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim username As String = UsernameTextBox.Text
        Dim password As String = PasswordTextBox.Text

        ' ����� ���� Ȯ��'
        Dim loggedInUserName As String = CheckLogin(username, password)

        If loggedInUserName IsNot Nothing Then
            MessageBox.Show("�α��� ����" + vbCrLf + loggedInUserName + "�� ȯ���մϴ�.")
            Me.Close()
        Else
            MessageBox.Show("���̵� �Ǵ� ��й�ȣ�� Ʋ�Ƚ��ϴ�.")
        End If
    End Sub



    '*************ȸ�� ����*************'

    'ȸ�� ���� â �����ֱ�'
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        GroupBox1.Visible = True
    End Sub

    Private Sub MonthCalendar1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar1.DateChanged
        BirthDay_Textbox.Text = MonthCalendar1.SelectionRange.Start.ToString("yyyy-MM-dd")
    End Sub

    '��й�ȣ ���� Ȯ��'
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
            Label6.Text = "��й�ȣ�� ���ǿ� ��ġ�մϴ�."
            Label6.ForeColor = Color.LimeGreen
            Label6.Visible = True
        Else
            Label6.Text = "��й�ȣ�� ���ǿ� ��ġ���� �ʽ��ϴ�."
            Label6.ForeColor = Color.Red
            Label6.Visible = True
        End If
    End Sub

    '��й�ȣ Ȯ�� �ؽ�Ʈ ����'
    Private Function CheckPasswordText(Passwordcheck As String)
        If Password_TextCheck.Text = SignPassword.Text Then
            Label7.Text = "��й�ȣ�� ��ġ�մϴ�."
            Label7.ForeColor = Color.LimeGreen
            Label7.Visible = True
            Return True
        Else
            Label7.Text = "��й�ȣ�� ��ġ���� �ʽ��ϴ�."
            Label7.ForeColor = Color.Red
            Label7.Visible = True
            Return False
        End If
    End Function

    Private Sub Password_TextCheck_TextChanged(sender As Object, e As EventArgs) Handles Password_TextCheck.TextChanged
        CheckPasswordText(Password_TextCheck.Text)
    End Sub

    '�̸��� ���� Ȯ��'
    Private Sub Email_Textbox_TextChanged(sender As Object, e As EventArgs) Handles Email_Textbox.TextChanged
        If Email_Textbox.Text.Contains("@") Then
            Label8.Text = "�̸��� ������ �½��ϴ�."
            Label8.ForeColor = Color.LimeGreen
            Label8.Visible = True
        Else
            Label8.Text = "�̸��� ���Ŀ� ���缭 �����ֽñ� �ٶ��ϴ�."
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

    'ȸ�� ���� �õ�'
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
                        MsgBox(Name_Textbox.Text + "�� ȸ�������� ȯ���մϴ�")
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
                        MsgBox(Name_Textbox.Text + "�� ȸ�������� ȯ���մϴ�")
                        command.ExecuteNonQuery()
                        GroupBox1.Visible = False
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.Message)
                Finally
                    connection.Close()
                End Try
            Else
                MsgBox("�Է� ������ Ȯ�����ּ���")
            End If
        End Using
    End Sub

    'ȸ������ â �����'
    Private Sub Back_Login_Click(sender As Object, e As EventArgs) Handles Back_Login.Click
        GroupBox1.Visible = False
    End Sub
End Class

