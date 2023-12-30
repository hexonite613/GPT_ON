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


    '��й�ȣ �ؾ��� �� form����'
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        SignupForm.ShowDialog()
    End Sub

End Class
