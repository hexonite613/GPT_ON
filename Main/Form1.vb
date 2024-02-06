Imports System.Configuration
Imports System.IO


Public Class Form1
    Dim apiurl As String = ConfigurationManager.AppSettings("apiurl")
    Dim apikey As String = ConfigurationManager.AppSettings("apikey")

    Private Sub Form1_PreLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        '메인으로 다이렉트'
        Main.Hide()

        '텍스트 부모 변경'
        Label3.Parent = PictureBox1
    End Sub


    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Label3.Click
        LoginForm.Show()
        Hide()
    End Sub

    Private Async Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Label2.Visible = False
        ' WebView2 초기화
        Await InitializeWebViewAsync()

        ' HTML 파일 다운로드 및 표시 (상대 경로 사용)
        LoadHtmlFileAsync(HtmlPath)

        WebView21.CoreWebView2.Settings.IsScriptEnabled = True

        '개발자 도구 막기'
        WebView21.CoreWebView2.Settings.AreDevToolsEnabled = False

        Main.Show()
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
