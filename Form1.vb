Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("MyConnectionString").ConnectionString
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "select * from GPT_Game.dbo.[user];"
                Dim command As New SqlCommand(query, connection)
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim one As String = reader("name").ToString()
                    Label1.Text = Label1.Text + "  " + one
                End While
            Catch ex As Exception
                Console.WriteLine("오류")
            End Try
        End Using
    End Sub
End Class
