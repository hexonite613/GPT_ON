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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Label1 = New Label()
        Label2 = New Label()
        Main = New GroupBox()
        WebView21 = New Microsoft.Web.WebView2.WinForms.WebView2()
        Panel1 = New Panel()
        PictureBox1 = New Guna.UI2.WinForms.Guna2PictureBox()
        Label3 = New Label()
        Main.SuspendLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
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
        Label2.Font = New Font("맑은 고딕", 20F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(809, 344)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 37)
        Label2.TabIndex = 2
        Label2.Text = "님, 환영합니다"
        Label2.Visible = False
        ' 
        ' Main
        ' 
        Main.BackColor = Color.FromArgb(CByte(70), CByte(70), CByte(100))
        Main.Controls.Add(WebView21)
        Main.Controls.Add(Panel1)
        Main.Location = New Point(12, 918)
        Main.Name = "Main"
        Main.Size = New Size(1266, 939)
        Main.TabIndex = 3
        Main.TabStop = False
        Main.Text = "GroupBox1"
        ' 
        ' WebView21
        ' 
        WebView21.AllowExternalDrop = True
        WebView21.CreationProperties = Nothing
        WebView21.DefaultBackgroundColor = Color.White
        WebView21.Location = New Point(302, 19)
        WebView21.Margin = New Padding(0)
        WebView21.Name = "WebView21"
        WebView21.Size = New Size(961, 917)
        WebView21.TabIndex = 5
        WebView21.ZoomFactor = 1R
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(105))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(3, 19)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(293, 917)
        Panel1.TabIndex = 4
        ' 
        ' PictureBox1
        ' 
        PictureBox1.CustomizableEdges = CustomizableEdges1
        PictureBox1.Image = My.Resources.Resources.maingif
        PictureBox1.ImageRotate = 0F
        PictureBox1.Location = New Point(0, 0)
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
        Label3.Location = New Point(491, 789)
        Label3.Name = "Label3"
        Label3.Size = New Size(304, 50)
        Label3.TabIndex = 7
        Label3.Text = "로그인 및 회원가입"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1264, 921)
        Controls.Add(Label3)
        Controls.Add(PictureBox1)
        Controls.Add(Main)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        Main.ResumeLayout(False)
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Main As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents PictureBox1 As Guna.UI2.WinForms.Guna2PictureBox
    Friend WithEvents Label3 As Label

End Class
