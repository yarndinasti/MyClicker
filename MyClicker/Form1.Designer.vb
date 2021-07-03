<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ComboTypeClick = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.HoldClickPic = New System.Windows.Forms.PictureBox()
        Me.RepeatPic = New System.Windows.Forms.PictureBox()
        Me.SettingBtn = New System.Windows.Forms.PictureBox()
        Me.DelayPic = New System.Windows.Forms.PictureBox()
        Me.MousePic = New System.Windows.Forms.PictureBox()
        Me.HoldClickLbl = New System.Windows.Forms.Label()
        Me.HoldClickBtn = New System.Windows.Forms.Button()
        Me.DelayLbl = New System.Windows.Forms.Label()
        Me.DelayBtn = New System.Windows.Forms.Button()
        Me.RepeatBtn = New System.Windows.Forms.Button()
        Me.LblRepeat = New System.Windows.Forms.Label()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.HoldClickPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepeatPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SettingBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DelayPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MousePic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboTypeClick
        '
        Me.ComboTypeClick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboTypeClick.FormattingEnabled = True
        Me.ComboTypeClick.Location = New System.Drawing.Point(98, 107)
        Me.ComboTypeClick.Name = "ComboTypeClick"
        Me.ComboTypeClick.Size = New System.Drawing.Size(161, 21)
        Me.ComboTypeClick.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Click Mode"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel1.Controls.Add(Me.LblInfo)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(271, 100)
        Me.Panel1.TabIndex = 4
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.Location = New System.Drawing.Point(98, 73)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(85, 13)
        Me.LblInfo.TabIndex = 0
        Me.LblInfo.Text = "Press F2 to Start"
        '
        'HoldClickPic
        '
        Me.HoldClickPic.AccessibleName = ""
        Me.HoldClickPic.BackColor = System.Drawing.SystemColors.Control
        Me.HoldClickPic.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.HoldClickPic.Image = Global.MyClicker.My.Resources.Resources.click_time_8
        Me.HoldClickPic.Location = New System.Drawing.Point(15, 207)
        Me.HoldClickPic.Name = "HoldClickPic"
        Me.HoldClickPic.Size = New System.Drawing.Size(25, 25)
        Me.HoldClickPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.HoldClickPic.TabIndex = 3
        Me.HoldClickPic.TabStop = False
        Me.HoldClickPic.Tag = ""
        Me.ToolTip1.SetToolTip(Me.HoldClickPic, "Duration click pressed")
        '
        'RepeatPic
        '
        Me.RepeatPic.AccessibleName = ""
        Me.RepeatPic.BackColor = System.Drawing.SystemColors.Control
        Me.RepeatPic.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.RepeatPic.Image = Global.MyClicker.My.Resources.Resources.repeat_8
        Me.RepeatPic.Location = New System.Drawing.Point(15, 176)
        Me.RepeatPic.Name = "RepeatPic"
        Me.RepeatPic.Size = New System.Drawing.Size(25, 25)
        Me.RepeatPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RepeatPic.TabIndex = 3
        Me.RepeatPic.TabStop = False
        Me.RepeatPic.Tag = ""
        Me.ToolTip1.SetToolTip(Me.RepeatPic, "Repeat")
        '
        'SettingBtn
        '
        Me.SettingBtn.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.SettingBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SettingBtn.Image = Global.MyClicker.My.Resources.Resources.setting_8
        Me.SettingBtn.Location = New System.Drawing.Point(234, 12)
        Me.SettingBtn.Name = "SettingBtn"
        Me.SettingBtn.Size = New System.Drawing.Size(25, 25)
        Me.SettingBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SettingBtn.TabIndex = 3
        Me.SettingBtn.TabStop = False
        Me.ToolTip1.SetToolTip(Me.SettingBtn, "Settings")
        '
        'DelayPic
        '
        Me.DelayPic.AccessibleName = ""
        Me.DelayPic.BackColor = System.Drawing.SystemColors.Control
        Me.DelayPic.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DelayPic.Image = Global.MyClicker.My.Resources.Resources.time_8
        Me.DelayPic.Location = New System.Drawing.Point(15, 145)
        Me.DelayPic.Name = "DelayPic"
        Me.DelayPic.Size = New System.Drawing.Size(25, 25)
        Me.DelayPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DelayPic.TabIndex = 3
        Me.DelayPic.TabStop = False
        Me.DelayPic.Tag = ""
        Me.ToolTip1.SetToolTip(Me.DelayPic, "Duration Delay")
        '
        'MousePic
        '
        Me.MousePic.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MousePic.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MousePic.Image = Global.MyClicker.My.Resources.Resources.left_8
        Me.MousePic.Location = New System.Drawing.Point(12, 12)
        Me.MousePic.Name = "MousePic"
        Me.MousePic.Size = New System.Drawing.Size(75, 75)
        Me.MousePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MousePic.TabIndex = 0
        Me.MousePic.TabStop = False
        Me.ToolTip1.SetToolTip(Me.MousePic, "Mouse Button")
        '
        'HoldClickLbl
        '
        Me.HoldClickLbl.AutoSize = True
        Me.HoldClickLbl.Location = New System.Drawing.Point(46, 213)
        Me.HoldClickLbl.Name = "HoldClickLbl"
        Me.HoldClickLbl.Size = New System.Drawing.Size(58, 13)
        Me.HoldClickLbl.TabIndex = 5
        Me.HoldClickLbl.Text = "0 Seconds"
        '
        'HoldClickBtn
        '
        Me.HoldClickBtn.Location = New System.Drawing.Point(168, 207)
        Me.HoldClickBtn.Name = "HoldClickBtn"
        Me.HoldClickBtn.Size = New System.Drawing.Size(91, 25)
        Me.HoldClickBtn.TabIndex = 6
        Me.HoldClickBtn.Text = "Edit"
        Me.HoldClickBtn.UseVisualStyleBackColor = True
        '
        'DelayLbl
        '
        Me.DelayLbl.AutoSize = True
        Me.DelayLbl.Location = New System.Drawing.Point(46, 151)
        Me.DelayLbl.Name = "DelayLbl"
        Me.DelayLbl.Size = New System.Drawing.Size(58, 13)
        Me.DelayLbl.TabIndex = 5
        Me.DelayLbl.Text = "0 Seconds"
        '
        'DelayBtn
        '
        Me.DelayBtn.Location = New System.Drawing.Point(168, 145)
        Me.DelayBtn.Name = "DelayBtn"
        Me.DelayBtn.Size = New System.Drawing.Size(91, 25)
        Me.DelayBtn.TabIndex = 6
        Me.DelayBtn.Text = "Edit"
        Me.DelayBtn.UseVisualStyleBackColor = True
        '
        'RepeatBtn
        '
        Me.RepeatBtn.Location = New System.Drawing.Point(168, 176)
        Me.RepeatBtn.Name = "RepeatBtn"
        Me.RepeatBtn.Size = New System.Drawing.Size(91, 23)
        Me.RepeatBtn.TabIndex = 8
        Me.RepeatBtn.Text = "Edit"
        Me.RepeatBtn.UseVisualStyleBackColor = True
        '
        'LblRepeat
        '
        Me.LblRepeat.AutoSize = True
        Me.LblRepeat.Location = New System.Drawing.Point(46, 181)
        Me.LblRepeat.Name = "LblRepeat"
        Me.LblRepeat.Size = New System.Drawing.Size(13, 13)
        Me.LblRepeat.TabIndex = 9
        Me.LblRepeat.Text = "0"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "MyClicker"
        Me.NotifyIcon1.Visible = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 253)
        Me.Controls.Add(Me.LblRepeat)
        Me.Controls.Add(Me.RepeatBtn)
        Me.Controls.Add(Me.HoldClickBtn)
        Me.Controls.Add(Me.HoldClickLbl)
        Me.Controls.Add(Me.DelayBtn)
        Me.Controls.Add(Me.DelayLbl)
        Me.Controls.Add(Me.HoldClickPic)
        Me.Controls.Add(Me.RepeatPic)
        Me.Controls.Add(Me.SettingBtn)
        Me.Controls.Add(Me.DelayPic)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboTypeClick)
        Me.Controls.Add(Me.MousePic)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "MyClicker"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.HoldClickPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepeatPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SettingBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DelayPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MousePic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MousePic As PictureBox
    Friend WithEvents ComboTypeClick As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SettingBtn As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents HoldClickPic As PictureBox
    Friend WithEvents LblInfo As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents HoldClickLbl As Label
    Friend WithEvents HoldClickBtn As Button
    Friend WithEvents DelayPic As PictureBox
    Friend WithEvents DelayLbl As Label
    Friend WithEvents DelayBtn As Button
    Friend WithEvents RepeatPic As PictureBox
    Friend WithEvents RepeatBtn As Button
    Friend WithEvents LblRepeat As Label
    Friend WithEvents NotifyIcon1 As NotifyIcon
End Class
