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
        Label1 = New Label()
        Button1 = New Button()
        Label2 = New Label()
        Main = New GroupBox()
        ListBox1 = New ListBox()
        Panel1 = New Panel()
        Enter = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Main.SuspendLayout()
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
        ' Button1
        ' 
        Button1.Location = New Point(386, 462)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 23)
        Button1.TabIndex = 1
        Button1.Text = "로그인"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("맑은 고딕", 20F)
        Label2.Location = New Point(336, 462)
        Label2.Name = "Label2"
        Label2.Size = New Size(194, 37)
        Label2.TabIndex = 2
        Label2.Text = "님, 환영합니다"
        Label2.Visible = False
        ' 
        ' Main
        ' 
        Main.BackColor = Color.FromArgb(CByte(70), CByte(70), CByte(100))
        Main.Controls.Add(TextBox2)
        Main.Controls.Add(ListBox1)
        Main.Controls.Add(Panel1)
        Main.Controls.Add(Enter)
        Main.Controls.Add(TextBox1)
        Main.Location = New Point(0, -16)
        Main.Name = "Main"
        Main.Size = New Size(1099, 632)
        Main.TabIndex = 3
        Main.TabStop = False
        Main.Text = "GroupBox1"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(299, 19)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(794, 469)
        ListBox1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(80), CByte(80), CByte(105))
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(3, 19)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(293, 610)
        Panel1.TabIndex = 4
        ' 
        ' Enter
        ' 
        Enter.Location = New Point(991, 507)
        Enter.Name = "Enter"
        Enter.Size = New Size(102, 99)
        Enter.TabIndex = 2
        Enter.Text = "입력"
        Enter.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.AcceptsReturn = True
        TextBox1.AcceptsTab = True
        TextBox1.Location = New Point(299, 507)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(670, 100)
        TextBox1.TabIndex = 1
        ' 
        ' TextBox2
        ' 
        TextBox2.AcceptsReturn = True
        TextBox2.AcceptsTab = True
        TextBox2.Location = New Point(302, 217)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(791, 271)
        TextBox2.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1097, 616)
        Controls.Add(Main)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        Main.ResumeLayout(False)
        Main.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Main As GroupBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Enter As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents TextBox2 As TextBox

End Class
