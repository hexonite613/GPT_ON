Imports System.Configuration
Imports System.Net
Imports Newtonsoft.Json.Linq
Imports System.IO
Imports Microsoft.Web.WebView2.Core

Public Class Form1
    Dim apiurl As String = ConfigurationManager.AppSettings("apiurl")
    Dim apikey As String = ConfigurationManager.AppSettings("apikey")

    Private Sub Form1_PreLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        '메인으로 다이렉트'
        Main.Hide()

        '하드웨어 가속 사용 안함'
        Environment.SetEnvironmentVariable("WEBVIEW2_ADDITIONAL_BROWSER_ARGUMENTS", "--disable-auto-reload", EnvironmentVariableTarget.User)

    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Async Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Visible = False
        ' WebView2 초기화
        Await InitializeWebViewAsync()

        ' HTML 파일 다운로드 및 표시 (상대 경로 사용)
        LoadHtmlFileAsync(HtmlPath)

        WebView21.CoreWebView2.Settings.IsScriptEnabled = True

        Main.Show()
    End Sub

    'enter.click 추가'
    Private Sub SendMessageButton_Click(sender As Object, e As EventArgs)
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
        'JSON 파싱'
        Dim jsonResponse As JObject = JObject.Parse(Raw_Response)
        '값을 추출'
        Dim contentValue As String = jsonResponse.SelectToken("choices[0].message.content")?.ToString()

        'Chat Gpt 응답 출력'
        AddMessage("요정", contentValue)

        '텍스트 상자 초기화'
        TextBox1.Text = ""
    End Sub

    Private Sub AddMessage(sender As Object, e As String)

    End Sub


    '메인 html 상대 경로 설정'
    Dim RelativePath = "Mainweb\Main.html"
    '실행 파일 위치'
    Dim AppDirectory = Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly.Location)
    '루트 디렉토리'
    Dim RootDirectory = Path.GetFullPath(Path.Combine(AppDirectory, "..\..\.."))
    '상대 경로랑 합병'
    Dim HtmlPath = Path.Combine(RootDirectory, RelativePath)

    Private Async Function InitializeWebViewAsync() As Task
        ' WebView2 컨트롤 초기화
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Function

    Private Sub LoadHtmlFileAsync(relativePath As String)
        WebView21.CoreWebView2.Navigate("file:///" & HtmlPath)
    End Sub

End Class
