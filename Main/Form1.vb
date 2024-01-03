Imports System.Configuration
Imports System.Data.SqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Visible = False
        Main.Show()
    End Sub

    Private Sub SendMessageButton_Click(sender As Object, e As EventArgs) Handles Enter.Click
        AddMessage("상대방", "안녕하세요!")
        Dim message As String = TextBox1.Text

        ' 자신의 메시지를 채팅 창에 추가
        AddMessage("나", message)

        ' 메시지 전송 후 텍스트 상자 초기화
        TextBox1.Text = ""
    End Sub

    Private Sub AddMessage(senderName As String, messageText As String)
        ' 채팅 창에 메시지를 추가하는 함수
        Dim message As String = $"{senderName}: {messageText}"
        If senderName = "나" Then
            ' 자신의 메시지는 오른쪽에 추가
            ListBox1.Items.Add(message.PadLeft(message.Length + 180))
        Else
            ' 상대방의 메시지는 왼쪽에 추가
            ListBox1.Items.Add(message)
        End If

        ' 채팅 창의 스크롤을 마지막으로 이동
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    End Sub


End Class
