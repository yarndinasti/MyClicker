<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SettingsFrm
  Inherits System.Windows.Forms.Form

  'Form overrides dispose to clean up the component list.
  <System.Diagnostics.DebuggerNonUserCode()> _
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
  <System.Diagnostics.DebuggerStepThrough()> _
  Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DonateCombo = New System.Windows.Forms.CheckBox()
        Me.DebugCombo = New System.Windows.Forms.CheckBox()
        Me.StartupCombo = New System.Windows.Forms.CheckBox()
        Me.TaskbarCheck = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.KeyList = New System.Windows.Forms.ListView()
        Me.funcCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KeyCol = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.NameLbl = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.WebsiteLink = New System.Windows.Forms.LinkLabel()
        Me.SteamlabsLink = New System.Windows.Forms.LinkLabel()
        Me.SaweriaLink = New System.Windows.Forms.LinkLabel()
        Me.PatreonLink = New System.Windows.Forms.LinkLabel()
        Me.TrakteerLink = New System.Windows.Forms.LinkLabel()
        Me.KaryaLink = New System.Windows.Forms.LinkLabel()
        Me.TwitchLink = New System.Windows.Forms.LinkLabel()
        Me.GitHubLink = New System.Windows.Forms.LinkLabel()
        Me.TikTokLink = New System.Windows.Forms.LinkLabel()
        Me.FacebookLink = New System.Windows.Forms.LinkLabel()
        Me.InstagramLink = New System.Windows.Forms.LinkLabel()
        Me.TwitterLink = New System.Windows.Forms.LinkLabel()
        Me.ACirclesLink = New System.Windows.Forms.LinkLabel()
        Me.YoutubeLink = New System.Windows.Forms.LinkLabel()
        Me.ComName = New System.Windows.Forms.Label()
        Me.sourceLink = New System.Windows.Forms.LinkLabel()
        Me.VersionLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WikiBtn = New System.Windows.Forms.Button()
        Me.DonateBtn = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(375, 343)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DonateCombo)
        Me.TabPage1.Controls.Add(Me.DebugCombo)
        Me.TabPage1.Controls.Add(Me.StartupCombo)
        Me.TabPage1.Controls.Add(Me.TaskbarCheck)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(367, 317)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Settings"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DonateCombo
        '
        Me.DonateCombo.AutoSize = True
        Me.DonateCombo.Location = New System.Drawing.Point(29, 244)
        Me.DonateCombo.Name = "DonateCombo"
        Me.DonateCombo.Size = New System.Drawing.Size(134, 17)
        Me.DonateCombo.TabIndex = 4
        Me.DonateCombo.Text = "Show donate message"
        Me.DonateCombo.UseVisualStyleBackColor = True
        '
        'DebugCombo
        '
        Me.DebugCombo.AutoSize = True
        Me.DebugCombo.Location = New System.Drawing.Point(29, 220)
        Me.DebugCombo.Name = "DebugCombo"
        Me.DebugCombo.Size = New System.Drawing.Size(123, 17)
        Me.DebugCombo.TabIndex = 3
        Me.DebugCombo.Text = "Run Debug Program"
        Me.DebugCombo.UseVisualStyleBackColor = True
        '
        'StartupCombo
        '
        Me.StartupCombo.AutoSize = True
        Me.StartupCombo.Location = New System.Drawing.Point(29, 197)
        Me.StartupCombo.Name = "StartupCombo"
        Me.StartupCombo.Size = New System.Drawing.Size(94, 17)
        Me.StartupCombo.TabIndex = 1
        Me.StartupCombo.Text = "Set As Startup"
        Me.StartupCombo.UseVisualStyleBackColor = True
        '
        'TaskbarCheck
        '
        Me.TaskbarCheck.AutoSize = True
        Me.TaskbarCheck.Location = New System.Drawing.Point(29, 174)
        Me.TaskbarCheck.Name = "TaskbarCheck"
        Me.TaskbarCheck.Size = New System.Drawing.Size(155, 17)
        Me.TaskbarCheck.TabIndex = 1
        Me.TaskbarCheck.Text = "Move in notify when closed"
        Me.TaskbarCheck.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ResetBtn)
        Me.GroupBox1.Controls.Add(Me.KeyList)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Setting keyboard"
        '
        'ResetBtn
        '
        Me.ResetBtn.Location = New System.Drawing.Point(282, 125)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(63, 23)
        Me.ResetBtn.TabIndex = 2
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'KeyList
        '
        Me.KeyList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.funcCol, Me.KeyCol})
        Me.KeyList.FullRowSelect = True
        Me.KeyList.HideSelection = False
        Me.KeyList.Location = New System.Drawing.Point(7, 20)
        Me.KeyList.MultiSelect = False
        Me.KeyList.Name = "KeyList"
        Me.KeyList.Size = New System.Drawing.Size(338, 97)
        Me.KeyList.TabIndex = 1
        Me.KeyList.UseCompatibleStateImageBehavior = False
        Me.KeyList.View = System.Windows.Forms.View.Details
        '
        'funcCol
        '
        Me.funcCol.Text = "Function"
        Me.funcCol.Width = 220
        '
        'KeyCol
        '
        Me.KeyCol.Text = "Keys"
        Me.KeyCol.Width = 100
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(222, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(54, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.NameLbl)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.ComName)
        Me.TabPage2.Controls.Add(Me.sourceLink)
        Me.TabPage2.Controls.Add(Me.VersionLbl)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.PictureBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(367, 317)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "About"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'NameLbl
        '
        Me.NameLbl.AutoSize = True
        Me.NameLbl.Location = New System.Drawing.Point(129, 90)
        Me.NameLbl.Name = "NameLbl"
        Me.NameLbl.Size = New System.Drawing.Size(39, 13)
        Me.NameLbl.TabIndex = 6
        Me.NameLbl.Text = "Label2"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.WebsiteLink)
        Me.GroupBox2.Controls.Add(Me.SteamlabsLink)
        Me.GroupBox2.Controls.Add(Me.SaweriaLink)
        Me.GroupBox2.Controls.Add(Me.PatreonLink)
        Me.GroupBox2.Controls.Add(Me.TrakteerLink)
        Me.GroupBox2.Controls.Add(Me.KaryaLink)
        Me.GroupBox2.Controls.Add(Me.TwitchLink)
        Me.GroupBox2.Controls.Add(Me.GitHubLink)
        Me.GroupBox2.Controls.Add(Me.TikTokLink)
        Me.GroupBox2.Controls.Add(Me.FacebookLink)
        Me.GroupBox2.Controls.Add(Me.InstagramLink)
        Me.GroupBox2.Controls.Add(Me.TwitterLink)
        Me.GroupBox2.Controls.Add(Me.ACirclesLink)
        Me.GroupBox2.Controls.Add(Me.YoutubeLink)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 173)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Social Media"
        '
        'WebsiteLink
        '
        Me.WebsiteLink.AutoSize = True
        Me.WebsiteLink.Location = New System.Drawing.Point(210, 104)
        Me.WebsiteLink.Name = "WebsiteLink"
        Me.WebsiteLink.Size = New System.Drawing.Size(46, 13)
        Me.WebsiteLink.TabIndex = 6
        Me.WebsiteLink.TabStop = True
        Me.WebsiteLink.Text = "Website"
        '
        'SteamlabsLink
        '
        Me.SteamlabsLink.AutoSize = True
        Me.SteamlabsLink.Location = New System.Drawing.Point(210, 89)
        Me.SteamlabsLink.Name = "SteamlabsLink"
        Me.SteamlabsLink.Size = New System.Drawing.Size(59, 13)
        Me.SteamlabsLink.TabIndex = 6
        Me.SteamlabsLink.TabStop = True
        Me.SteamlabsLink.Text = "Streamlabs"
        '
        'SaweriaLink
        '
        Me.SaweriaLink.AutoSize = True
        Me.SaweriaLink.Location = New System.Drawing.Point(210, 74)
        Me.SaweriaLink.Name = "SaweriaLink"
        Me.SaweriaLink.Size = New System.Drawing.Size(45, 13)
        Me.SaweriaLink.TabIndex = 6
        Me.SaweriaLink.TabStop = True
        Me.SaweriaLink.Text = "Saweria"
        '
        'PatreonLink
        '
        Me.PatreonLink.AutoSize = True
        Me.PatreonLink.Location = New System.Drawing.Point(210, 59)
        Me.PatreonLink.Name = "PatreonLink"
        Me.PatreonLink.Size = New System.Drawing.Size(44, 13)
        Me.PatreonLink.TabIndex = 6
        Me.PatreonLink.TabStop = True
        Me.PatreonLink.Text = "Patreon"
        '
        'TrakteerLink
        '
        Me.TrakteerLink.AutoSize = True
        Me.TrakteerLink.Location = New System.Drawing.Point(210, 44)
        Me.TrakteerLink.Name = "TrakteerLink"
        Me.TrakteerLink.Size = New System.Drawing.Size(47, 13)
        Me.TrakteerLink.TabIndex = 6
        Me.TrakteerLink.TabStop = True
        Me.TrakteerLink.Text = "Trakteer"
        '
        'KaryaLink
        '
        Me.KaryaLink.AutoSize = True
        Me.KaryaLink.Location = New System.Drawing.Point(210, 29)
        Me.KaryaLink.Name = "KaryaLink"
        Me.KaryaLink.Size = New System.Drawing.Size(60, 13)
        Me.KaryaLink.TabIndex = 6
        Me.KaryaLink.TabStop = True
        Me.KaryaLink.Text = "Karyakarsa"
        '
        'TwitchLink
        '
        Me.TwitchLink.AutoSize = True
        Me.TwitchLink.Location = New System.Drawing.Point(19, 119)
        Me.TwitchLink.Name = "TwitchLink"
        Me.TwitchLink.Size = New System.Drawing.Size(39, 13)
        Me.TwitchLink.TabIndex = 5
        Me.TwitchLink.TabStop = True
        Me.TwitchLink.Text = "Twitch"
        '
        'GitHubLink
        '
        Me.GitHubLink.AutoSize = True
        Me.GitHubLink.Location = New System.Drawing.Point(210, 119)
        Me.GitHubLink.Name = "GitHubLink"
        Me.GitHubLink.Size = New System.Drawing.Size(40, 13)
        Me.GitHubLink.TabIndex = 5
        Me.GitHubLink.TabStop = True
        Me.GitHubLink.Text = "GitHub"
        '
        'TikTokLink
        '
        Me.TikTokLink.AutoSize = True
        Me.TikTokLink.Location = New System.Drawing.Point(19, 104)
        Me.TikTokLink.Name = "TikTokLink"
        Me.TikTokLink.Size = New System.Drawing.Size(41, 13)
        Me.TikTokLink.TabIndex = 4
        Me.TikTokLink.TabStop = True
        Me.TikTokLink.Text = "TikTok"
        '
        'FacebookLink
        '
        Me.FacebookLink.AutoSize = True
        Me.FacebookLink.Location = New System.Drawing.Point(19, 90)
        Me.FacebookLink.Name = "FacebookLink"
        Me.FacebookLink.Size = New System.Drawing.Size(55, 13)
        Me.FacebookLink.TabIndex = 3
        Me.FacebookLink.TabStop = True
        Me.FacebookLink.Text = "Facebook"
        '
        'InstagramLink
        '
        Me.InstagramLink.AutoSize = True
        Me.InstagramLink.Location = New System.Drawing.Point(19, 75)
        Me.InstagramLink.Name = "InstagramLink"
        Me.InstagramLink.Size = New System.Drawing.Size(53, 13)
        Me.InstagramLink.TabIndex = 3
        Me.InstagramLink.TabStop = True
        Me.InstagramLink.Text = "Instagram"
        '
        'TwitterLink
        '
        Me.TwitterLink.AutoSize = True
        Me.TwitterLink.Location = New System.Drawing.Point(19, 60)
        Me.TwitterLink.Name = "TwitterLink"
        Me.TwitterLink.Size = New System.Drawing.Size(39, 13)
        Me.TwitterLink.TabIndex = 2
        Me.TwitterLink.TabStop = True
        Me.TwitterLink.Text = "Twitter"
        '
        'ACirclesLink
        '
        Me.ACirclesLink.AutoSize = True
        Me.ACirclesLink.Location = New System.Drawing.Point(19, 45)
        Me.ACirclesLink.Name = "ACirclesLink"
        Me.ACirclesLink.Size = New System.Drawing.Size(101, 13)
        Me.ACirclesLink.TabIndex = 1
        Me.ACirclesLink.TabStop = True
        Me.ACirclesLink.Text = "YouTube (A Circles)"
        '
        'YoutubeLink
        '
        Me.YoutubeLink.AutoSize = True
        Me.YoutubeLink.Location = New System.Drawing.Point(19, 29)
        Me.YoutubeLink.Name = "YoutubeLink"
        Me.YoutubeLink.Size = New System.Drawing.Size(115, 13)
        Me.YoutubeLink.TabIndex = 0
        Me.YoutubeLink.TabStop = True
        Me.YoutubeLink.Text = "YouTube (Ardian Chn.)"
        '
        'ComName
        '
        Me.ComName.AutoSize = True
        Me.ComName.Location = New System.Drawing.Point(129, 64)
        Me.ComName.Name = "ComName"
        Me.ComName.Size = New System.Drawing.Size(39, 13)
        Me.ComName.TabIndex = 4
        Me.ComName.Text = "Label2"
        '
        'sourceLink
        '
        Me.sourceLink.AutoSize = True
        Me.sourceLink.Location = New System.Drawing.Point(129, 106)
        Me.sourceLink.Name = "sourceLink"
        Me.sourceLink.Size = New System.Drawing.Size(69, 13)
        Me.sourceLink.TabIndex = 3
        Me.sourceLink.TabStop = True
        Me.sourceLink.Text = "Source Code"
        '
        'VersionLbl
        '
        Me.VersionLbl.AutoSize = True
        Me.VersionLbl.Location = New System.Drawing.Point(129, 49)
        Me.VersionLbl.Name = "VersionLbl"
        Me.VersionLbl.Size = New System.Drawing.Size(13, 13)
        Me.VersionLbl.TabIndex = 2
        Me.VersionLbl.Text = "v"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 29)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "MyClicker"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.MyClicker.My.Resources.Resources.icon_8
        Me.PictureBox1.Location = New System.Drawing.Point(17, 18)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 101)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'WikiBtn
        '
        Me.WikiBtn.Location = New System.Drawing.Point(288, 349)
        Me.WikiBtn.Name = "WikiBtn"
        Me.WikiBtn.Size = New System.Drawing.Size(75, 23)
        Me.WikiBtn.TabIndex = 1
        Me.WikiBtn.Text = "Wiki"
        Me.WikiBtn.UseVisualStyleBackColor = True
        '
        'DonateBtn
        '
        Me.DonateBtn.Location = New System.Drawing.Point(207, 349)
        Me.DonateBtn.Name = "DonateBtn"
        Me.DonateBtn.Size = New System.Drawing.Size(75, 23)
        Me.DonateBtn.TabIndex = 2
        Me.DonateBtn.Text = "Donate"
        Me.DonateBtn.UseVisualStyleBackColor = True
        '
        'SettingsFrm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 381)
        Me.Controls.Add(Me.DonateBtn)
        Me.Controls.Add(Me.WikiBtn)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "SettingsFrm"
        Me.Text = "References"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DonateCombo As CheckBox
    Friend WithEvents DebugCombo As CheckBox
    Friend WithEvents StartupCombo As CheckBox
    Friend WithEvents TaskbarCheck As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents WikiBtn As Button
    Friend WithEvents KeyList As ListView
    Friend WithEvents funcCol As ColumnHeader
    Friend WithEvents KeyCol As ColumnHeader
    Friend WithEvents ResetBtn As Button
    Friend WithEvents VersionLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ComName As Label
    Friend WithEvents sourceLink As LinkLabel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GitHubLink As LinkLabel
    Friend WithEvents TikTokLink As LinkLabel
    Friend WithEvents InstagramLink As LinkLabel
    Friend WithEvents TwitterLink As LinkLabel
    Friend WithEvents ACirclesLink As LinkLabel
    Friend WithEvents YoutubeLink As LinkLabel
    Friend WithEvents SteamlabsLink As LinkLabel
    Friend WithEvents SaweriaLink As LinkLabel
    Friend WithEvents PatreonLink As LinkLabel
    Friend WithEvents TrakteerLink As LinkLabel
    Friend WithEvents KaryaLink As LinkLabel
    Friend WithEvents DonateBtn As Button
    Friend WithEvents TwitchLink As LinkLabel
    Friend WithEvents WebsiteLink As LinkLabel
    Friend WithEvents FacebookLink As LinkLabel
    Friend WithEvents NameLbl As Label
End Class
