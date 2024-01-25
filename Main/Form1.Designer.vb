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
        Button1 = New Guna.UI2.WinForms.Guna2Button()
        Main.SuspendLayout()
        CType(WebView21, ComponentModel.ISupportInitialize).BeginInit()
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
        Main.Location = New Point(0, -16)
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
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Button1.Animated = True
        Button1.AutoRoundedCorners = True
        Button1.BorderRadius = 21
        Button1.BorderStyle = Drawing2D.DashStyle.DashDot
        Button1.CustomizableEdges = CustomizableEdges1
        Button1.DisabledState.BorderColor = Color.DarkGray
        Button1.DisabledState.CustomBorderColor = Color.DarkGray
        Button1.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Button1.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.ForeColor = Color.White
        Button1.Location = New Point(526, 766)
        Button1.Name = "Button1"
        Button1.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Button1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Button1.Size = New Size(180, 45)
        Button1.TabIndex = 4
        Button1.Text = "로그인 및 회원가입"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1264, 921)
        Controls.Add(Main)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        Main.ResumeLayout(False)
        CType(WebView21, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Main As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents WebView21 As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents Button1 As Guna.UI2.WinForms.Guna2Button

End Class
