Imports Microsoft.Web.WebView2.Core

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label2 = New Label()
        Main = New GroupBox()
        PictureBox5 = New PictureBox()
        backgroundms = New AxWMPLib.AxWindowsMediaPlayer()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        PictureBox3 = New PictureBox()
        PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        GroupBox1 = New GroupBox()
        Soundbar = New Guna.UI2.WinForms.Guna2TrackBar()
        Label4 = New Label()
        PictureBox4 = New PictureBox()
        Main.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(backgroundms, ComponentModel.ISupportInitialize).BeginInit()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(365, 137)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 0
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("맑은 고딕", 20.25F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(550, 815)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 37)
        Label2.TabIndex = 2
        Label2.Text = "님, 환영합니다"
        Label2.Visible = False
        ' 
        ' Main
        ' 
        Main.BackColor = Color.FromArgb(CByte(70), CByte(70), CByte(100))
        Main.Controls.Add(PictureBox5)
        Main.Controls.Add(backgroundms)
        Main.Controls.Add(WebView21)
        Main.Controls.Add(PictureBox3)
        Main.Location = New Point(0, 0)
        Main.Name = "Main"
        Main.Size = New Size(1272, 939)
        Main.TabIndex = 3
        Main.TabStop = False
        Main.Text = "GroupBox1"
        ' 
        ' PictureBox5
        ' 
        PictureBox5.BackColor = Color.Transparent
        PictureBox5.Image = My.Resources.Resources.boy_portrait1
        PictureBox5.Location = New Point(43, 205)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(445, 498)
        PictureBox5.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox5.TabIndex = 11
        PictureBox5.TabStop = False
        ' 
        ' backgroundms
        ' 
        backgroundms.Enabled = True
        backgroundms.Location = New Point(20, 36)
        backgroundms.Name = "backgroundms"
        backgroundms.OcxState = CType(resources.GetObject("backgroundms.OcxState"), AxHost.State)
        backgroundms.Size = New Size(75, 23)
        backgroundms.TabIndex = 10
        backgroundms.Visible = False
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Location = New Point(514, 14)
        WebView21.Margin = New Padding(0)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(758, 922)
        WebView21.TabIndex = 5
        WebView21.ZoomFactor = 1R
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), Image)
        PictureBox3.Location = New Point(0, 13)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(515, 921)
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.CustomizableEdges = CustomizableEdges1
        PictureBox1.Image = My.Resources.Resources.maingif
        PictureBox1.ImageRotate = 0F
        PictureBox1.Location = New Point(6, 13)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        PictureBox1.Size = New Size(1264, 921)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("던파 비트비트체 v2", 25F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = Color.White
        Label3.Location = New Point(497, 802)
        Label3.Name = "Label3"
        Label3.Size = New Size(304, 50)
        Label3.TabIndex = 7
        Label3.Text = "로그인 및 회원가입"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = Color.Transparent
        PictureBox2.Image = My.Resources.Resources.only_logo_white
        PictureBox2.Location = New Point(298, 25)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(700, 700)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Main)
        GroupBox1.Controls.Add(Soundbar)
        GroupBox1.Controls.Add(Label4)
        GroupBox1.Controls.Add(PictureBox4)
        GroupBox1.Controls.Add(PictureBox2)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(PictureBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Location = New Point(-8, -13)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(1272, 934)
        GroupBox1.TabIndex = 9
        GroupBox1.TabStop = False
        GroupBox1.Text = "GroupBox1"
        ' 
        ' Soundbar
        ' 
        Soundbar.BackColor = Color.Transparent
        Soundbar.Location = New Point(20, 802)
        Soundbar.Name = "Soundbar"
        Soundbar.Size = New Size(191, 23)
        Soundbar.TabIndex = 11
        Soundbar.ThumbColor = Color.FromArgb(CByte(160), CByte(113), CByte(255))
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("던파 비트비트체 v2", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = Color.White
        Label4.Location = New Point(69, 830)
        Label4.Name = "Label4"
        Label4.Size = New Size(91, 17)
        Label4.TabIndex = 9
        Label4.Text = "음악 켜기/끄기"
        ' 
        ' PictureBox4
        ' 
        PictureBox4.BackColor = Color.Transparent
        PictureBox4.Image = My.Resources.Resources.pause
        PictureBox4.Location = New Point(89, 851)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(50, 50)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 7
        PictureBox4.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1264, 921)
        Controls.Add(Label1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        Main.ResumeLayout(False)
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(backgroundms, ComponentModel.ISupportInitialize).EndInit()
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Main As GroupBox
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Soundbar As Guna.UI2.WinForms.Guna2TrackBar
    Friend WithEvents backgroundms As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents PictureBox5 As PictureBox

End Class
