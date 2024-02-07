Imports System.Configuration
Imports System.IO
Imports System.Media


Public Class Form1
    Dim apiurl As String = ConfigurationManager.AppSettings("apiurl")
    Dim apikey As String = ConfigurationManager.AppSettings("apikey")
    Dim backgroundMusic As SoundPlayer
    Dim isplaying = True

    '실행 파일 위치'
    Dim AppDirectory = Path.GetDirectoryName(Reflection.Assembly.GetExecutingAssembly.Location)
    '루트 디렉토리'
    Dim RootDirectory = Path.GetFullPath(Path.Combine(AppDirectory, "..\..\.."))

    Private Sub Form1_PreLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        '메인으로 다이렉트'
        Main.Hide()

        backgroundMusic = New SoundPlayer(My.Resources.backgroundms)
        backgroundMusic.PlayLooping()

        '투명 배경을 이미지로 투영시키기 위한 부모 변경'
        Label3.Parent = PictureBox1
        PictureBox2.Parent = PictureBox1
        Label2.Font = New Font("던파 비트비트체 v2", 20.25)
        Label2.ForeColor = Color.White
        Label4.Parent = PictureBox1
        Label4.BackColor = Color.Transparent
        PictureBox4.Parent = PictureBox1
        'Label2 위치 조정'
        Dim labelX = (Me.Size.Width - Label2.Size.Width) / 2
        Label2.Location = New Point(labelX, Label2.Location.Y)
        Label2.Parent = PictureBox1
        Label2.BackColor = Color.Transparent
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
    '상대 경로랑 합병'
    Dim HtmlPath = Path.Combine(RootDirectory, RelativePath)

    Private Async Function InitializeWebViewAsync() As Task
        ' WebView2 컨트롤 초기화
        Await WebView21.EnsureCoreWebView2Async(Nothing)
    End Function

    Private Sub LoadHtmlFileAsync(relativePath As String)
        WebView21.CoreWebView2.Navigate("file:///" & HtmlPath)
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        backgroundMusic.Stop()
        If isplaying = True Then
            backgroundMusic.Stop()
            isplaying = False
        Else
            backgroundMusic.PlayLooping()
            isplaying = True
        End If
    End Sub
End Class
