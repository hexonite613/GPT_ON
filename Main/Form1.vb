Imports System.Configuration
Imports System.Net
Imports Newtonsoft.Json.Linq
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class Form1
    Dim apiurl As String = ConfigurationManager.AppSettings("apiurl")
    Dim apikey As String = ConfigurationManager.AppSettings("apikey")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Visible = False
        Main.Show()
    End Sub

    Private Sub SendMessageButton_Click(sender As Object, e As EventArgs) Handles Enter.Click
        ' 자신의 메시지를 채팅 창에 추가
        Dim message As String = TextBox1.Text
        AddMessage("나", message)


        ' 채팅 서버에 메시지 전송'
        Dim client As New WebClient()
        client.Headers.Add("Content-Type", "application/json")
        client.Headers.Add("Authorization", "Bearer " & apikey)

        'Chat Gpt 설정'
        Dim sendata As String = "{
            ""model"":""gpt-3.5-turbo"",
            ""messages"":[
                {
                    ""role"":""system"",
                    ""content"":""넌 용사님을 돕는 요정이야""
                },
                {
                    ""role"":""user"",
                    ""content"":""" & message & """
                }
            ],
            ""max_tokens"": 100,
            ""temperature"": 0.6
        }"

        'Chat Gpt 응답 받기'
        Dim Raw_Response As String = client.UploadString(apiurl, sendata)
        ' JSON 파싱'
        Dim jsonResponse As JObject = JObject.Parse(Raw_Response)
        '값을 추출'
        Dim contentValue As String = jsonResponse.SelectToken("choices[0].message.content")?.ToString()

        'Chat Gpt 응답 출력'
        AddMessage("요정", contentValue)

        ' 메시지 전송 후 텍스트 상자 초기화
        TextBox1.Text = ""
    End Sub

    Private Sub AddMessage(senderName As String, messageText As String)
        ' 채팅 창에 메시지를 추가하는 함수
        Dim message As String = $"{senderName}: {messageText}"
        If senderName = "나" Then
            ListBox1.Items.Add(message)
        Else
            ListBox1.Items.Add(message)
        End If

        ' 채팅 창의 스크롤을 마지막으로 이동
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    End Sub

End Class
